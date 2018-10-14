using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace WPFsearchUIblend
{
    public class DataAccess
    {
        //Funksjonen GetPeople tar imot en tekststreng som inneholder enten fornavn, mellomnavn, etternavn, adresse, postnummer, osv,
        //og returnerer en liste med Person som alle inneholder denne tekststrengen i ett av feltene sine. Merk at også postnummer, som egentlig består av 4 siffer, 
        //sendes gjennom her som en tekst-streng. (NB: Sjekk om postnummer "0032" f.ekse ender opp som 32 på grunn av konvertering mellom int-string-int!!)
        public List<Person> GetPeople(string anyField)
        {
            //Bruker using-statement for at forbindelsen skal bli brutt etterpå. Innenfor "using {} har vi direkte kontakt med databasen "PersonlisteDB".
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("PersonlisteDB")))
            {
                //AnyField er en tekststreng men kan bestå av et postnummer. I SQL-tabellen vår er postnummeret et "Integer" og ikke "String".'
                //Hvis brukeren har søkt på postnummer, må vi gjøre om fra string til int.
                int postnumber = 0;
                try {postnumber = int.Parse(anyField);}
                catch{}

                //Hvis postnummer er blitt søkt etter:
                if (postnumber>= 999)
                {
                    //Overgang fra string til int gikk bra - bruker har søkt på postnummer. 
                    //Her har vi kall mot lagrede funksjoner som ligger inn i SQL databasen vår.
                    //Koden "new {Postnumber = postnumber}" er en dynamisk tilnærming der man oppretter en ny klasse "Postnumber" som tar inn postnumber
                    //som er innparameter til "GetByPostnumber". Dapper vil putte det som kommer ut av "new {Postnumber = postnumber}", inn i @Postnumber.
                    var output = connection.Query<Person>("dbo.spPersontabell_GetByPostnumber @Postnumber", new { Postnumber = postnumber }).ToList();
                    return output;
                }

                //ellers, et annet felt enn postnummer har blitt søkt etter.
                else
                {
                    //Her har vi kall mot lagrede funksjoner som ligger inn i SQL databasen vår.
                    //Koden "new {AnyField = anyField}" er en dynamisk tilnærming der man oppretter en ny klasse "AnyField" som tar inn anyField
                    //som er innparameter til "GetBySearchingAnyFields". Dapper vil putte det som kommer ut av "new {AnyField = anyField}", inn i @AnyField.
                    var output = connection.Query<Person>("dbo.spPersontabell_GetBySearchingAnyFields @AnyField", new { AnyField = anyField }).ToList();
                    return output;
                }
            }
        }

        public void InsertPerson(string fornavn, string mellomnavn, string etternavn, string adresse, int postnummerInt, string poststed, string email)
        {
            //Bruker using-statement for at forbindelsen skal bli brutt etterpå. Her har vi kall mot lagrede funksjoner som ligger inn i SQL databasen vår.
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("PersonlisteDB")))
            {
                List<Person> people = new List<Person>();

                //Den korte varianten.
                //Person newPerson = new Person { Fornavn = fornavn, Mellomnavn = mellomnavn, Etternavn = etternavn, Adresse1 = adresse, Postnummer1 = postnummerInt, Poststed1 = poststed, Email1 = email };

                //Den litt mer oversiktlige måten. Grei når man skal forlenge listen under vedlikehold..
                Person newPerson = new Person();
                newPerson.ID = 5;
                newPerson.Fornavn = fornavn;
                newPerson.Mellomnavn = mellomnavn;
                newPerson.Etternavn = etternavn;
                newPerson.Adresse1 = adresse;
                newPerson.Adresse2 = String.Empty; //Her ligger Adresse 2 klar til å brukes. Den må bare legges inn i GUI. 
                newPerson.Adresse3 = String.Empty; //Her ligger Adresse 3 klar til å brukes. Den må bare legges inn i GUI. 
                newPerson.Adresse4 = String.Empty; //Her ligger Adresse 4 klar til å brukes. Den må bare legges inn i GUI.
                newPerson.Adresse5 = String.Empty; //Her ligger Adresse 5 klar til å brukes. Den må bare legges inn i GUI.
                newPerson.Postnummer1 = postnummerInt;
                newPerson.Postnummer2 = 0; //Her ligger Postnummer2 klar til å brukes. Den må bare legges inn i GUI.
                newPerson.Postnummer3 = 0; //Her ligger Postnummer3 klar til å brukes. Den må bare legges inn i GUI.
                newPerson.Postnummer4 = 0; //Her ligger Postnummer4 klar til å brukes. Den må bare legges inn i GUI.
                newPerson.Postnummer5 = 0; //Her ligger Postnummer5 klar til å brukes. Den må bare legges inn i GUI.
                newPerson.Poststed1 = poststed;
                newPerson.Poststed2 = String.Empty; //Her ligger Poststed2 klar til å brukes. Den må bare legges inn i GUI. 
                newPerson.Poststed3 = String.Empty; //Her ligger Poststed3 klar til å brukes. Den må bare legges inn i GUI. 
                newPerson.Poststed4 = String.Empty; //Her ligger Poststed4 klar til å brukes. Den må bare legges inn i GUI. 
                newPerson.Poststed5 = String.Empty; //Her ligger Poststed5 klar til å brukes. Den må bare legges inn i GUI. 
                newPerson.Email1 = email;
                newPerson.Email2 = String.Empty; //Her ligger Email2 klar til å brukes. Den må bare legges inn i GUI. 
                newPerson.Email3 = String.Empty; //Her ligger Email3 klar til å brukes. Den må bare legges inn i GUI. 
                newPerson.Email4 = String.Empty; //Her ligger Email4 klar til å brukes. Den må bare legges inn i GUI. 
                newPerson.Email5 = String.Empty; //Her ligger Email5 klar til å brukes. Den må bare legges inn i GUI. 

                people.Add(newPerson);

                //Gjør et kall til "Stored Procedure" inne i databasen. Prosedyren/funksjonen heter "dbo.spPersontabell_InsertPerson" og
                //den tar inn hele raden med innparameter fra "people"-listen med "Person"-objekter. 
                connection.Execute("dbo.spPersontabell_InsertPerson @ID, @Fornavn, @Mellomnavn, @Etternavn, @Adresse1, @Adresse2, @Adresse3, " +
                    "@Adresse4, @Adresse5, @Postnummer1, @Postnummer2, @Postnummer3, @Postnummer4, @Postnummer5, " +
                    "@Poststed1, @Poststed2, @Poststed3, @Poststed4, @Poststed5, @Email1, @Email2, @Email3, @Email4, @Email5", people);
            }
        }

        public List<Person> GetAllInfo()
        {
            //Bruker using-statement for at forbindelsen skal bli brutt etterpå. Innenfor "using {} har vi direkte kontakt med databasen "PersonlisteDB".
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("PersonlisteDB")))
            {
                //Her har vi kall mot den lagrede funksjonen dbo.spPersontabell_GetAll som ligger inn i SQL databasen vår
                var output = connection.Query<Person>("dbo.spPersontabell_GetAll").ToList();
                    return output;
            }
        }
    }
}

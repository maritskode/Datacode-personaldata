using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dapper;

namespace WPFsearchUIblend
{
    public partial class ReportForm : Form
    {

        //Begynner med en tom liste med personer
        List<Person> people = new List<Person>();

        public ReportForm()
        {
            InitializeComponent();
        }

        private void loadButton_Click(object sender, EventArgs e)
        {
            //Opprett tilgang til databasen
            DataAccess db = new DataAccess();

            //Kjører den lagrede database funksjonen "GetAllInfo" og få ut en liste med personer - "people".
            people = db.GetAllInfo();

            //Sender listen med personer inn som datakilde til GridViewTextBox som er inne i "ReportForm"-klassen.
            personBindingSource.DataSource = people;

            /* TEST - Forsøker å fjerne kolonner i GridViewTextBox som ikke inneholder data!
             * På den måten vil rapporten inne i GridViewTextBox se mye mer ryddig ut! 
             * Forsøket virket dessverre ikke.. 
            //La oss ta en sjekk hvor mange personer som er inne i datalisten vår.
            //Denne informasjonen kan brukes til å sette riktig IDnummer.
            int numberOfPersonsInList = people.Count();

            //Skriv informasjonen ut i en tekstboks.
            MessageBox.Show(numberOfPersonsInList.ToString());

            //Vi ønsker å kun printe ut kolonner som inneholder verdier...
            bool Adresse2Empty = true; //Vi starter med å anta at Adresse2 er tom
            bool Adresse3Empty = true; //Vi starter med å anta at Adresse3 er tom
            bool Adresse4Empty = true; //Vi starter med å anta at Adresse4 er tom
            bool Adresse5Empty = true; //Vi starter med å anta at Adresse4 er tom

            for (int i = 0; i < numberOfPersonsInList; i++)
            {
                if (this.people[i].Adresse2 != String.Empty)
                {
                    //Det er angitt en Adresse2 for person med index i.
                    Adresse2Empty = false;
                }
                if (this.people[i].Adresse3 != String.Empty)
                {
                    //Det er angitt en Adresse3 for person med index i.
                    Adresse3Empty = false;
                }
                if(this.people[i].Adresse4 != String.Empty)
                {
                    //Det er angitt en Adresse4 for person med index i.
                    Adresse4Empty = false;
                }
                if (this.people[i].Adresse5 != String.Empty)
                {
                    //Det er angitt en Adresse4 for person med index i.
                    Adresse5Empty = false;
                }
            }
            if (Adresse2Empty) { adresse2DataGridViewTextBoxColumn.Visible = false; }
            if (Adresse3Empty) { adresse3DataGridViewTextBoxColumn.Visible = false; }
            if (Adresse4Empty) { adresse4DataGridViewTextBoxColumn.Visible = false; }
            if (Adresse5Empty) { adresse5DataGridViewTextBoxColumn.Visible = false; }
            */
        }
    }
}

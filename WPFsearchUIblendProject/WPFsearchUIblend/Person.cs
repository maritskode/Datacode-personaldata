using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFsearchUIblend
{
    public class Person
    {
        public int ID { get; set; }
        public string Fornavn { get; set; }
        public string Mellomnavn { get; set; }
        public string Etternavn { get; set; }
        public string Adresse1 { get; set; }
        public string Adresse2 { get; set; }
        public string Adresse3 { get; set; }
        public string Adresse4 { get; set; }
        public string Adresse5 { get; set; }
        public int Postnummer1 { get; set; }
        public int Postnummer2 { get; set; }
        public int Postnummer3 { get; set; }
        public int Postnummer4 { get; set; }
        public int Postnummer5 { get; set; }
        public string Poststed1 { get; set; }
        public string Poststed2 { get; set; }
        public string Poststed3 { get; set; }
        public string Poststed4 { get; set; }
        public string Poststed5 { get; set; }
        public string Email1 { get; set; }
        public string Email2 { get; set; }
        public string Email3 { get; set; }
        public string Email4 { get; set; }
        public string Email5 { get; set; }

        public string getFullInfo
        {
            get
            {
                string fullInfoString = "";
                if (Adresse1 == null && Email1 != null)
                {
                    fullInfoString = $"{ Fornavn } { Mellomnavn } { Etternavn }, ({ Email1 })";
                }
                if (Adresse1 == null && Email1 == null)
                {
                    fullInfoString = $"{ Fornavn } { Mellomnavn } { Etternavn }";
                }
                //Beate Knutsen, Tirilveien 5, 5263 Hamar (beate.knutsen@gmail.com)
                if (Adresse1 != null && Email1 != null)
                {
                    fullInfoString = $"{ Fornavn } { Mellomnavn } { Etternavn }, { Adresse1 }, { Postnummer1 } { Poststed1 } ({ Email1 })";
                }
                if (Adresse1 != null && Email1 == null)
                {
                    fullInfoString = $"{ Fornavn } { Mellomnavn } { Etternavn }, { Adresse1 }, { Postnummer1 } { Poststed1 }";
                }
                return fullInfoString;
            }
        }
    }
}

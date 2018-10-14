using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace WPFsearchUIblend
{
    /// <summary>
    /// Interaction logic for MainWindow2.xaml
    /// </summary>
    public partial class MainWindow2 : Window
    {
        //public object WPFsearchUI { get; private set; }

        //public List<Person> people = new List<Person>();

        public MainWindow2()
        {
            InitializeComponent();
            //people.Add(new Person { FirstName = "Ola", Lastname = "Hansen" });
            //people.Add(new Person { FirstName = "Mari", Lastname = "Olsen" });
            //people.Add(new Person { FirstName = "Per", Lastname = "Jakobsen" });

            //myComboBox.ItemsSourch = people;
        }

        //public void emptyAllFields()
       //{
        //    fornavnText.Text = String.Empty;
        //    mellomnavnText.Text = String.Empty;
        //    etternavnText.Text = String.Empty;
        //    gateadresseText.Text = String.Empty;
       //     postnummerText.Text = String.Empty;
       //     poststedText.Text = String.Empty;
       //     emailText.Text = String.Empty;
       // }

        private void emptyFieldButton_Click(object sender, RoutedEventArgs e)
        {
            fornavnText.Text = String.Empty;
            mellomnavnText.Text = String.Empty;
            etternavnText.Text = String.Empty;
            gateadresseText.Text = String.Empty;
            postnummerText.Text = String.Empty;
            poststedText.Text = String.Empty;
            emailText.Text = String.Empty;
        }

        private void saveButton_Click(object sender, RoutedEventArgs e)
        {
            //Før vi lagrer burde vi ta full kontroll over input fra brukeren. Har brukeren fyllt inn noe feil? 

            //Foreløpig kontrollerer vi bare "string postnummer" - dette skal ikke være en tekststreng inne i databasen. 
            int postnummerInt = 0;

            //Tester først om det er skrevet noe som helst inni Postnummerfeltet..
            if (postnummerText.Text != String.Empty)
            {
                //Vi gjør konverteringen fra "string" til "int" her. 
                //Ideellt sett, så skulle vi nok ha laget en egen "class Library" der vi hadde samlet alle slike funksjonene. 
                try
                {
                    postnummerInt = int.Parse(postnummerText.Text);
                }
                catch
                {
                    //Noe gikk galt når vi prøvde å gjøre "string postnummer" om til "int postnummerInt". 
                    //Skriver feilmelding og nekter å lagre personen i databasen.
                    string message = "Sjekk om postnummeret er riktig skrevet.";
                    string title = "Advarsel";
                    System.Windows.MessageBox.Show(message, title);
                    return;
                }
            }
            DataAccess db = new DataAccess();

            db.InsertPerson(fornavnText.Text, mellomnavnText.Text, etternavnText.Text, gateadresseText.Text, postnummerInt, poststedText.Text, emailText.Text);

            fornavnText.Text = String.Empty;
            mellomnavnText.Text = String.Empty;
            etternavnText.Text = String.Empty;
            gateadresseText.Text = String.Empty;
            postnummerText.Text = String.Empty;
            poststedText.Text = String.Empty;
            emailText.Text = String.Empty;
        }

        private void closeButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void searchButton_Click(object sender, RoutedEventArgs e)
        {
            SubWindow searchWindow = new SubWindow();
            searchWindow.Show();
        }

        private void reportButton_Click(object sender, RoutedEventArgs e)
        {
            ReportForm reportform = new ReportForm();
            reportform.Show();
        }
    }
    //public class Person
    //{
    //    public string FirstName { get; set; }

    //}
}

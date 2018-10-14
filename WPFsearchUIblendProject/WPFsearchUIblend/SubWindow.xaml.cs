using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPFsearchUIblend
{
    /// <summary>
    /// Interaction logic for SubWindow.xaml
    /// </summary>
    public partial class SubWindow : Window
    {
        //Begynner med en tom liste med personer
        List<Person> people = new List<Person>();

        public object FoundComboBox_SelectionChanged { get; private set; }

        public SubWindow()
        {
            InitializeComponent();

            //System.Collections.ObjectModel.ObservableCollection observableCollection = 

        }

        //public ObservableCollection<string> StringCollection { get; set; }

        //public RelayCommand AddCollectionCommand { get; set; }

        //public MainWindowViewModel()
        //{
        //StringCollection = new ObservableCollection<string> { "Line One", "Line Two" };
        //AddCollectionCommand = new RelayCommand(AddCollection);
        //}

        //private void AddCollection()
        //{
        //StringCollection.Add(myString);
        //}

        private void closeButton_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void searchButton_Click(object sender, RoutedEventArgs e)
        {
            DataAccess db = new DataAccess();

            people = db.GetPeople(searchWord.Text);

            peopleFoundComboBox.ItemsSource = people;
        }

        private void peopleFoundComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //Vi henter frem ComboBox-indeksen til den personen som brukeren har valgt ut blant 
            //listen av personer som ble funnet i søket.
            int thisSelectedIndex = (sender as ComboBox).SelectedIndex;

            //Vi åpner et nytt hovedvindu
            MainWindow2 editWindow = new MainWindow2();
            editWindow.Show();

            //***** 
            //I dette nye hovedvinduet blir personalia fra den brukervalgte personen blir fylt inn.
            editWindow.fornavnText.Text = people[thisSelectedIndex].Fornavn;
            editWindow.mellomnavnText.Text = people[thisSelectedIndex].Mellomnavn;
            editWindow.etternavnText.Text = people[thisSelectedIndex].Etternavn;
            editWindow.gateadresseText.Text = people[thisSelectedIndex].Adresse1;

            //Det er kun hvis postnummeret er noe annet enn 0, at vi velger å fylle det inn i skjemaet.
            if (people[thisSelectedIndex].Postnummer1 != 0)
            {
                editWindow.postnummerText.Text = people[thisSelectedIndex].Postnummer1.ToString();
            }
            editWindow.poststedText.Text = people[thisSelectedIndex].Poststed1;
            editWindow.emailText.Text = people[thisSelectedIndex].Email1;
            //*****
        }
    }
}

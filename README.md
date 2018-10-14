# Datacode-personaldata
The project aim to administrate personal data (e.g. name, address, email address) of a set of people.

# Development stage
This project contains my absolutely first programs in C#, xaml, WPF, and stored procedures in SQL database.

# Important note
All persons saved in the SQL database table, and shown in the examples, are only for test purposes - they are just fiction and not real persons. All text on the Graphic User Interfaces are written in Norwegian.  

# Prerequisite
The code makes use of Dapper in order to easy connect to the SQL server. Dapper is developed and supported by the people behind Stackoverflow.com. 
Do you need to install Dapper? Follow these steps: Open Visual Studio, right-click on "References" in the "Solution Explorer" window, choose "Manage NuGet Packages". Mark the area on the top named "Browse" (instead of "Installed") and fill out the searchfield just below with the word "Dapper". Select "Dapper by Sam Saffron, Marc Gravell, Nick Craver,(...)" and press "Install"-button on the right. In the output-window below, you will get information about the process of installing Dapper.   

# Installation
MainWindow2.xaml should be added to the startupURI inside App.xaml: >>StartupUri="MainWindow2.xaml"> - such that it will be built first. The two other windows, SubWindow.xaml and ReportForm.cs, will be called from MainWindow2.xaml. 

The ReportForm.cs consists of a "DataGridView" that needs to be connected to a project data source. Follow these steps in order to set up this connection: Open Visual Studio and this project, build the ReportForm.cs so that you can see the ReportForm.cs [Design] window and the DataGridView (the grey square area). In the upper right corner of the grey area, you will see a small arrow. Press this small arrow and you will get a popup window menu. This menu should contain "Add Project Data Source". Choose that and you will open a "Data Source Configuration Wizard". Choose the project "WPFsearchUIblend" and tick the "Person" on the list, then "Finish". The class Person is the class that will return all the information that you want to display inside the "DataGridView". The "DataGridView" sheet is editable, just use DataGridView Tasks + Edit Columns if you want to remove any unnesseary columns.  

The Helper.cs is directly responsible for the connection to your server and your database. In order to make your connections work, open the Visual Studio and this project, and then open App.config. After <configuration> and <startup>, add 
  <connectionStrings>
    <add name="PersonlisteDB" connectionString="XX" providerName="System.Data.SqlClient"/>
   </connectionStrings>      
Instead of XX you should put the information that you find at https://www.connectionstrings.com/sql-server/.
Depending on the security of the connection, you should either choose: "Standard security", "Trusted connection" or "Connection to a SQL server instance". 
  => E.g. if you choose "Standard security", you should replace XX with "Server=myServerAddress;Database=myDataBase;User Id=myUsername;Password=myPassword;
  => Substitute "myServerAddress", "myDataBase", "myUsername", and "myPassword" with correct values/strings. 
You have now established a connectionstring for your SQL server connection.
  
# Description
MainWindow2.xaml is the main window where you can fill out name, address and email of a new person that can be saved into your database. "Postnummer" (means "Zipcode") can only contain integers, or you will get a warning when you try to save the person into the database.

MainWindow2.xaml will open SubWindow.xaml when you hit the "Åpne søkevindu"-button ("Open the searchwindow"-button). The search window that appears, allows you to search for all persons inside your database. The word given in the search-field can be firstname, middle name, lastname, street address, zipcode or area/city. The results from the search will be given in the drop-down menu. You can use the dropdown menu just to look throught the results, or you can hit one of the persons on the result-list and all info about the person will appear in the textfields of a new MainWindow2.xaml. Now you can adjust or correct the information you got on the person you looked up. 

MainWindow2.xaml will open ReportForm.cs (a report-window), when you hit the "Åpne rapportvindu"-button (means "Open the reportwindow"-button). When this new window opens, you can press the "Last inn alle data"-button (means "Load all data"-button) in order to display a report of all people and information in the SQL database table. 

The Person.cs holds all the personaldata of a person - Firstname, middle name, lastname, streetaddress, zipcode, area/city and emailaddress. The Person.cs contains one function called getFullInfo() that returns a string with all the person's stored personaldata.

The DataAccess.cs is responsible for the connections with the SQL server through using-statements and call to the stored procedures at the SQL server. DataAccess.cs contains three functions; GetPeople(), InsertPerson() and GetAllInfo()

The DataAccess.cs uses Helper.cs to get hold on the connection strings for the SQL server connection. See "Installation"-chapter for more information on how to set your correct connection string.

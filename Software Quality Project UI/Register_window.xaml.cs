using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using Sql;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Relational;


namespace Software_Quality_Project_UI
{
    /// <summary>
    /// Interaction logic for Register_window.xaml
    /// </summary>
    public partial class Register_window : Window
    {
        public Register_window()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            this.Close();
            mainWindow.Show();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            //creating a new user account

            Regex nameRegex = new Regex(@"^[A-z]+$");
            Regex emailRegex = new Regex(@"^[\w -\.] +@([\w -] +\.) +[\w -]{ 2,4}+$"); //DO NOT CHANGE THIS LINE IT WORKS FOR EMAILS!
            bool firstNameOK = false;
            bool lastNameOK = false;
            bool emailOK = false;
            bool passMatch = false;
            bool driverORuser = false;
            

            //checking the first name
            if(nameRegex.IsMatch(firstName.Text))
            {
                firstNameOK = true;
                invalidFirstName.Visibility= Visibility.Hidden;
            }
            else
            {
                invalidFirstName.Visibility = Visibility.Visible;
                //if the name isn't in the correct format the error comes up
                firstNameOK = false;
            }

            //checking the last name
            if(nameRegex.IsMatch(lastName.Text))
            {
                lastNameOK = true;
                invalidLastName.Visibility= Visibility.Hidden;
            }
            else
            {
                invalidLastName.Visibility = Visibility.Visible;
                //if the last name isn't in the correct format the error shows up
                lastNameOK = false;
            }

            //checking the email
            if (emailRegex.IsMatch(email.Text))
            {
                emailOK = true;
                invalidEmail.Visibility= Visibility.Hidden;
            }
            else
            {
                invalidEmail.Visibility = Visibility.Visible;
                //if the email isn't in the correct format this error comes up
                emailOK = false;
            }

            //checking if the passwords entered match
            if (pass == confirmPass)
            {
                passNotMatch.Visibility = Visibility.Hidden;
                passMatch = true;
            }
            else
            {
                passNotMatch.Visibility = Visibility.Visible;
                passMatch = false;
            }

            string accountType = null;

            if (userAccount.IsChecked == false && driverAccount.IsChecked == false)
            {
                //if both of these ae not checked the account can't be created the user must select one
                invalidAccountType.Visibility= Visibility.Visible;
                driverORuser = false;
            }
            else
            {
                driverORuser = true;
                if(userAccount.IsChecked == true)
                {
                    accountType = "user";
                    invalidAccountType.Visibility = Visibility.Hidden;
                }
                if(driverAccount.IsChecked == true)
                {
                    accountType = "driver";
                    invalidAccountType.Visibility = Visibility.Hidden;
                }
            }


            //checking if the data is all correct and if it is it will call a method to be uploaded to the SQL database

            if (firstNameOK && lastNameOK && emailOK && passMatch && driverORuser)
            {
                //if it gets into here then all the information should be ok
                //inside here it will submit to the SQL server
                string data = firstName.Text + ", " + lastName.Text + ", " + email.Text + ", " + pass + ", " + "false";


               
                MySqlConnection conn = new MySqlConnection(); //creating a new connection
                SQL sqlConnection = new SQL(conn);
                sqlConnection.Register(accountType, email.Text, data);
            }

            //format the data for users and drivers like this:
            /// Jonathon, Gregoric, asiof@gmail.com, 123abc#, false




        }
    }
}

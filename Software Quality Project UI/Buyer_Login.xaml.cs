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

namespace Software_Quality_Project_UI
{
    /// <summary>
    /// Interaction logic for Buyer_Login.xaml
    /// </summary>
    public partial class Buyer_Login : Window
    {
        public Buyer_Login()
        {
            InitializeComponent();
        }

        private void Login_Click(object sender, RoutedEventArgs e)
        {
            //compare the username and their password to the username and password from the server
            string uName = userName.Text;
            string pass = Password.Password;
            string test_uName = "Testing123";
            string test_pass = "PASSWORD123";

            bool goodName = false;
            bool goodPass = false;



            if (uName == test_uName) //is username is good
            {
                goodName= true;
            }

            if (pass == test_pass) //if password is good
            {
                goodPass= true;
            }

            if (goodName && goodPass) //if both of them are good
            {
                MessageBox.Show("username and pass ok");
                //go to buyer page
            }
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            this.Close();
            mainWindow.Show();
        }
    }
}

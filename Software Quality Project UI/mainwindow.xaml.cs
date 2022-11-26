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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Software_Quality_Project_UI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Buyer_Login BuyerWindow = new Buyer_Login();
            this.Close();
            BuyerWindow.Show();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Planner_Login BuyerWindow = new Planner_Login();
            this.Close();
            BuyerWindow.Show();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Admin_Login BuyerWindow = new Admin_Login();
            this.Close();
            BuyerWindow.Show();
        }

        private void Create_Account(object sender, RoutedEventArgs e)
        {
            Register_window register = new Register_window();
            this.Close();
            register.Show();
        }
    }
}

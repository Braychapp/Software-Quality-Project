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
    /// Interaction logic for BuyerMenu.xaml
    /// </summary>
    /// 

    //menuOption currentOrder = new menuOption();
    public partial class BuyerMenu : Window
    {
        public BuyerMenu()
        {
            InitializeComponent();
            //needs to initiate contact with the contract marketplace to recieve contracts from customers below this line

        }

        private void ReviewCustomers_Click(object sender, RoutedEventArgs e)
        {
            //bring up a list of old / existing customers in this button press (probably do it in a message box or create a new window that's just a
            //big text box kinda like the notepad assignment from windows programming but it's read only and it displays
            //all the existing customers information for the buyer to scroll through
            Review_Customers reviewCustomers = new Review_Customers();
            reviewCustomers.Show();

        }

        private void AcceptCustomers_Click(object sender, RoutedEventArgs e)
        {
            //bring up a list of new customers for the buyer to select from (not exactly sure how to implement this, maybe use a new window or a bunch of message boxes)
            AcceptCustomers acceptCustomers = new AcceptCustomers();
            acceptCustomers.Show();
        }


        private void Back_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            this.Close();
            mainWindow.Show();

        }

        private void ReviewOrders_Click(object sender, RoutedEventArgs e)
        {
            //create a new window with completed orders and process them for invoice generation
            
        }
    }
}

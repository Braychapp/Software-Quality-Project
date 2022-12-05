/* 
* Filename: receivedOrders.xaml.cd
* Project: Software Quality TMS Milestone
* Author: Bakr Jasim
* Date: December 05, 2022
* Description: This the UI logic for displaying the orders from buyer
*/


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

namespace PlannerUI
{
    /// <summary>
    /// Interaction logic for receivedOrders.xaml
    /// </summary>
    public partial class receivedOrders : Window
    {
        public receivedOrders()
        {
            InitializeComponent();
        }

        /*
        * Function: Button_Click
        * Description:This function is navigaes back to the mainwindow screen of the planner
        */
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            this.Close();
            mainWindow.Show();
        }
    }
}

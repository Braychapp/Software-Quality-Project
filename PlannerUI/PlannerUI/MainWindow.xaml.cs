/* 
* Filename: MainWindo.xaml.cd
* Project: Software Quality TMS Milestone
* Author: Bakr Jasim
* Date: December 05, 2022
* Description: This file is for any functions related to the main window of the planner UI
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PlannerUI
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

        /*
        * Function: received_orders_click
        * Description:This function displays the received order to the planner
        */
        private void received_orders_click(object sender, RoutedEventArgs e)
        {
            receivedOrders received = new receivedOrders();
            this.Close();
            received.Show();

        }

        /*
        * Function: add_trips_click
        * Description:This function displays the window where planner can add trips
        */
        private void add_trips_click(object sender, RoutedEventArgs e)
        {
            AddTrips add = new AddTrips();
            this.Close();
            add.Show();
        }

        /*
        * Function: confirm_order_click
        * Description:This function changes windows so planner can select and confirm orders
        */
        private void confirm_order_click(object sender, RoutedEventArgs e)
        {
            ConfirmOrder confirm = new ConfirmOrder();
            this.Close();
            confirm.Show();
        }

        /*
        * Function: active_orders_click
        * Description:This function displays the active orders to the planner
        */
        private void active_orders_click(object sender, RoutedEventArgs e)
        {
            DisplayActiveOrders active = new DisplayActiveOrders();
            this.Close();
            active.Show();
        }

        /*
        * Function: generate_summary_click
        * Description:this funciton generates the summary report of order for the planner
        */
        private void generate_summary_click(object sender, RoutedEventArgs e)
        {
            GenerateSummary generateSummary = new GenerateSummary();
            this.Close();
            generateSummary.Show();
        }
    }
}

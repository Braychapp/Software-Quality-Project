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

        private void received_orders_click(object sender, RoutedEventArgs e)
        {
            receivedOrders received = new receivedOrders();
            this.Close();
            received.Show();

        }

        private void add_trips_click(object sender, RoutedEventArgs e)
        {
            AddTrips add = new AddTrips();
            this.Close();
            add.Show();
        }

        private void confirm_order_click(object sender, RoutedEventArgs e)
        {
            ConfirmOrder confirm = new ConfirmOrder();
            this.Close();
            confirm.Show();
        }

        private void active_orders_click(object sender, RoutedEventArgs e)
        {
            DisplayActiveOrders active = new DisplayActiveOrders();
            this.Close();
            active.Show();
        }

        private void generate_summary_click(object sender, RoutedEventArgs e)
        {
            GenerateSummary generateSummary = new GenerateSummary();
            this.Close();
            generateSummary.Show();
        }
    }
}

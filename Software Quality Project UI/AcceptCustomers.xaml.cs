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
    /// Interaction logic for AcceptCustomers.xaml
    /// </summary>
    public partial class AcceptCustomers : Window
    {
        menuOption[] options = new menuOption[10]; //10 possible menu options
        menuOption m;
        public AcceptCustomers()
        {
            InitializeComponent();
            //below here we need to fill the OrderSelect combo box with the orders for the buyer to choose from
            //using a default for now for testing purposes
            //the orders are going to be new instances of the menuOption class

            DateTime date = DateTime.Now;
            menuOption option1 = new menuOption(12348, 843712, date, "couches", 440.42, "Toronto", "Burlington", (decimal)1872.33, "NOT accepted"); //created a fake menu option (this should be replaced by an sql connection feeding into the array)
            options[0] = option1;
            OrderSelect.Items.Add(options[0].trip_id.ToString()); //setting the drop down with this trip ID
            //adding the fake menu option to the selector from the ORDER ID
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if(OrderSelect.SelectedIndex!= -1 )//if something is selected
            {
                
                string n = OrderSelect.SelectedItem.ToString(); //making m equal to the order selected through casting
                int i;
                int menuop = -1; ;
                int.TryParse(n, out i);
                for (int a = 0; a < 10; a++) //ignore the warning for this it is wrong
                {
                    if (i == options[a].trip_id)
                    {
                        menuop= a;
                        break;
                    }
                    else
                    {
                        return;
                    }
                }
                m = options[menuop];
                OrderInfo.Text = "Trip ID: " + m.trip_id.ToString() + "\n" + "Buyer ID: " + m.buyer_id.ToString() + "\n" + "Date Ordered: " + m.date_ordered.ToString() + "\n" + "Cargo: " + m.cargo + "\n" + "Weight: " + m.weight.ToString() + "\n" + "Starting Location: " + m.start_location +  "\n" + "Ending Location: " + m.end_location + "Price: $" + m.price.ToString() + "\n" + "Status: " + m.status;
            }
        }

        private void AcceptOrder_Click(object sender, RoutedEventArgs e)
        {
            //this button click is going to take the currently selected menu option and pass it to the next section of order completion
            //this button will just open another window to the next page but it will pass it the current order that has been accepted
            AcceptOrder acceptOrder = new AcceptOrder(m);
            this.Close();
            acceptOrder.Show();
        }
    }

}

using Org.BouncyCastle.Asn1.X9;
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
    /// Interaction logic for AcceptOrder.xaml
    /// </summary>
    public partial class AcceptOrder : Window
    {
        menuOption acceptedOrder;
        menuOption[] options = new menuOption[10]; //10 possible menu options
        menuOption m;
        public AcceptOrder(menuOption acceptedOrder)
        {
            this.acceptedOrder = acceptedOrder;
            InitializeComponent();
            DateTime date = DateTime.Now;
            menuOption option1 = new menuOption(12345, "available"); //created a fake menu option (this should be replaced by an sql connection feeding into the array)
            options[0] = option1;
            selectDriver.Items.Add(options[0].trip_id.ToString());
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (selectDriver.SelectedIndex != -1)//if something is selected
            {

                string n = selectDriver.SelectedItem.ToString(); //making m equal to the order selected through casting
                int i;
                int menuop = -1; ;
                int.TryParse(n, out i);
                for (int a = 0; a < 10; a++) //ignore the warning for this it is wrong
                {
                    if (i == options[a].trip_id)
                    {
                        menuop = a;
                        break;
                    }
                    else
                    {
                        return;
                    }
                }
                m = options[menuop];
                driverInfo.Text = m.driver_id.ToString() + "\n" + m.status.ToString();
                acceptedOrder.addDriver(m.driver_id);//adding a driver to the order
                
            }
        }

        private void SendToPlanner_Click(object sender, RoutedEventArgs e)
        {
            //in here the acceptedOrder needs to be sent to the planner or the SQL database for use later in the planner

            //then it will close and go back to the regular buyer menu window

            MessageBox.Show("Order Sent To Planner!");

            this.Close();
            //going back to the buyer menu

        }
    }
}

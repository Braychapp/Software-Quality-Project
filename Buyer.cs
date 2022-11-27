using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareQuality
{
    internal class Buyer
    {
        private string Name { get; set; }
        private string Email { get; set; }
        private string Password { get; set; }


        // Initiates contact with the Contract Marketplace to receive contracts from Customers
        private void ViewMarketContracts()
        {

        }

        // Buyer may review existing Customers in the TMS system
        private void ViewExistingCustomers()
        {

        }

        // Buyer may accept new Customers (from the Marketplace) into the TMS system
        private void AcceptNewCustomer(string customerInformation)
        {

        }

        // Buyer may initiate a new Order from the Marketplace requests
        private void PlaceNewOrder(string orderID)
        {

        }

        // Buyer may select relevant Cities for the Order. This will nominate Carriers in those Cities
        // for Order completion (which is confirmed by the Planner)
        private void PlaceNewOrder(string orderID, string Cities)
        {

        }

        // Buyer may review completed Orders and process them for Invoice Generation
        private void ReviewOrders()
        {

        }

        // Invoice Generation results in a text file being generated with appropriate billing details. 
        // This information is also stored in the TMS database
        private void GenerateInvoice(string orderID)
        {

        }
    }
}

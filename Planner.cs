using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareQuality
{
    internal class Planner
    {
        private string Name { get; set; }
        private string Email { get; set; }
        private string Password { get; set; }


        // Planner receives Orders from the Buyer
        private void ReviewOrder(string orderID)
        {

        }

        // Planner selects Carriers from the targeted cities to complete the Order which adds a ‘Trip’ to the Order for each Carrier selected
        private void SelectCarrier(string carrierID)
        {

        }

        // The Planner may simulate the passage of time in 1-day increments in order to mover Orders and their trips to completed state
        private void PassOneDay()
        {

        }

        // Planner may confirm an order is completed. Completed Orders are marked for follow-up from the Buyer
        private void ConfirmOrder(string orderID)
        {

        }

        // Planner may see a summary of all active Orders in a status screen
        private void ViewAllActiveOrders()
        {

        }

        // Planner may generate a summary report of all Invoice data for the 'past 2 weeks' of simulated time
        private void GenerateSummaryTwoWeeks()
        {

        }


        // Planner may generate a summary report of all Invoice data for all time
        private void GenerateSummaryAllTime()
        {

        }
    }
}

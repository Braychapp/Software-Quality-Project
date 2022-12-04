using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Software_Quality_Project_UI
{
    public class menuOption
    {
        public int trip_id;
        public int buyer_id;
        public int driver_id;
        public DateTime date_ordered;
        public string cargo;
        public double weight;
        public string start_location;
        public string end_location;
        public decimal price;
        public string status;

        public menuOption(int trip, int buyer, DateTime date, string Cargo, double Weight, string start, string end, decimal Price, string stats)
        {
            //constructor needs to set most of these values here other values will be set with mutators / accessors
            trip_id = trip;
            buyer_id = buyer;
            date_ordered = date;
            cargo = Cargo;
            weight = Weight;
            start_location = start;
            end_location = end;
            price = Price;
            status = stats;
        }

        public menuOption(int driver, string availability)
        {
            driver_id = driver;
            status = availability;
        }

        public void addDriver(int driver)
        {
            driver_id = driver;
        }

        public void changeStatus(string stats)
        {
            status = stats;
        }

        
    }
}

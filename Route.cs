/*
* FILE              : Route.cs
* PROJECT           : Software Quality TMS
* PROGRAMMER        : Evan O'Hara
* FIRST VERSION     : 2022-12-04
*                   :
* DESCRIPTION       : Set route table. Methods to return total km driven and total time spent driving.
*                   : 
*/


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareQualityTMS
{
    public class Route
    {
        public string RDestination { get; set; }
        public int RKm { get; set; }
        public decimal RTime { get; set; }
        public string RWest { get; set; }
        public string REast { get; set; }

        public Route (string rDestination, int rKm, decimal rTime, string rWest, string rEast)
        {
            RDestination = rDestination;
            RKm = rKm;
            RTime = rTime;
            RWest = rWest;
            REast = rEast;
        }


        /*  -- Method Header Comment
        Name	 :	RouteTotalKm
        Purpose  :	Calculate total km driven from start to end
                 :  
        Inputs	 :	string start - starting destination, string end - ending destination
        Outputs	 :	NONE
        Returns  :	int totalKm - total km driven
        */
        public int RouteTotalKm (string start, string end)
        {
            Route windsor = new Route("Windsor", 191, 2.5m, "END", "London");
            Route london = new Route("London", 128, 1.75m, "Windsor", "Hamilton");
            Route hamilton = new Route("Hamilton", 68, 1.25m, "London", "Toronto");
            Route toronto = new Route("Toronto", 60, 1.3m, "Hamilton", "Oshawa");
            Route oshawa = new Route("Oshawa", 134, 1.65m, "Toronto", "Belleville");
            Route belleville = new Route("Belleville", 82, 1.2m, "Oshawa", "Kingston");
            Route kingston = new Route("Kingston", 196, 2.5m, "Belleville", "Ottawa");
            Route ottawa = new Route("Ottawa", 0, 0, "Kingston", "END");


            // put into an array
            Route[] RouteArray = new Route[8] { windsor, london, hamilton, toronto, oshawa, belleville, kingston, ottawa };

            // initialize index of start destination and index of end destination
            int startIndex = -1;
            int endIndex = -1;


            // find the start destination index
            for (int i = 0; i < RouteArray.Length; i++)
            {
                if (RouteArray[i].RDestination == start)
                {
                    startIndex = i;
                }
            }

            // find the end destination index
            for (int i = 0; i < RouteArray.Length; i++)
            {
                if (RouteArray[i].RDestination == end)
                {
                    endIndex = i;
                }
            }



            // variable to store total km
            int totalKm = 0;

            // EAST TO WEST total km calculation
            if (startIndex - endIndex > 0 )
            {
                for (int k = startIndex - 1; k >= endIndex; k--)
                {
                    totalKm += RouteArray[k].RKm;
                }
            }

            // WEST TO EAST total km calculation
            else if (startIndex - endIndex < 0)
            {
                int k = Math.Abs(startIndex - endIndex);
                for (k = startIndex; k < endIndex; k++)
                {
                    totalKm += RouteArray[k].RKm;
                }
            }

            return totalKm;


        }


        /*  -- Method Header Comment
        Name	 :	RouteTotalTime
        Purpose  :	Calculate total time spent driving
                 :  
        Inputs	 :	string start - starting destination, string end - ending destination
        Outputs	 :	NONE
        Returns  :	decimal totalTime - total time spent driving in hours
        */

        public decimal RouteTotalTime(string start, string end)
        {
            Route windsor = new Route("Windsor", 191, 2.5m, "END", "London");
            Route london = new Route("London", 128, 1.75m, "Windsor", "Hamilton");
            Route hamilton = new Route("Hamilton", 68, 1.25m, "London", "Toronto");
            Route toronto = new Route("Toronto", 60, 1.3m, "Hamilton", "Oshawa");
            Route oshawa = new Route("Oshawa", 134, 1.65m, "Toronto", "Belleville");
            Route belleville = new Route("Belleville", 82, 1.2m, "Oshawa", "Kingston");
            Route kingston = new Route("Kingston", 196, 2.5m, "Belleville", "Ottawa");
            Route ottawa = new Route("Ottawa", 0, 0, "Kingston", "END");


            // put into an array
            Route[] RouteArray = new Route[8] { windsor, london, hamilton, toronto, oshawa, belleville, kingston, ottawa };

            // initialize index of start destination and index of end destination
            int startIndex = -1;
            int endIndex = -1;


            // find the start destination index
            for (int i = 0; i < RouteArray.Length; i++)
            {
                if (RouteArray[i].RDestination == start)
                {
                    startIndex = i;
                }
            }

            // find the end destination index
            for (int i = 0; i < RouteArray.Length; i++)
            {
                if (RouteArray[i].RDestination == end)
                {
                    endIndex = i;
                }
            }



            // variable to store total km
            decimal totalTime = 0;

            // EAST TO WEST total km calculation
            if (startIndex - endIndex > 0)
            {
                for (int k = startIndex - 1; k >= endIndex; k--)
                {
                    totalTime += RouteArray[k].RTime;
                }
            }

            // WEST TO EAST total km calculation
            else if (startIndex - endIndex < 0)
            {
                int k = Math.Abs(startIndex - endIndex);
                for (k = startIndex; k < endIndex; k++)
                {
                    totalTime += RouteArray[k].RTime;
                }
            }

            return totalTime;


        }


    }


}

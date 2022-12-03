/*
* FILE              : Order.cs
* PROJECT           : SoftwareQualityTMS
* PROGRAMMER        : Evan O'Hara
* FIRST VERSION     : 2022-12-03
*                   :
* DESCRIPTION       : Contains code for the Order object. OrderID, OrderType, OrderQuantity
*                   : 
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareQualityTMS
{
    public class Order
    {
        public int OrderID { get; set; }
        public string OrderType { get; set; }
        public int OrderQuantity { get; set; }
        public string OrderOrigin { get; set; }
        public string OrderDestination { get; set; }
        public string OrderDate { get; set; }
        public bool OrderStatus { get; set; }



        /*  -- Method Header Comment -- CONSTRUCTOR
        Name	 :	Order
        Purpose  :	Constructor to initialize an Order 
                 :  
        Inputs	 :	int orderID, string orderType, int orderQuantity, string orderOrigin, string orderDestination, string orderDate, bool orderStatus
        Outputs	 :	NONE
        Returns  :	NONE
        */
        public Order (int orderID, string orderType, int orderQuantity, string orderOrigin, string orderDestination, string orderDate, bool orderStatus)
        {
            OrderID = orderID;
            OrderType = orderType;
            OrderQuantity = orderQuantity;
            OrderOrigin = orderOrigin;
            OrderDestination = orderDestination;
            OrderDate = orderDate;
            OrderStatus = orderStatus;
        }


        /*  -- Method Header Comment
        Name	 :	ConfirmOrder
        Purpose  :  For the Planner to confirm that the order is completed	 
                 :  
        Inputs	 :	int OrderID
        Outputs	 :	NONE
        Returns  :	true if the order status has changed to be completed, false if the order status is unchanged
        */
        public bool ConfirmOrder (int orderID)
        {
            // checks to make sure the orderID entered by the planner is equal to the current Order object's OrderID
            if (orderID == OrderID)
            {
                OrderStatus = true;
                return true;
            }

            return false;
        }



    }
}

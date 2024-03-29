﻿using AdministratorApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdministratorApp
{
    /// <summary>
    /// Model class for the order
    /// The class contains getters and setters for all variables which are neccessery for the order.
    /// </summary>
    /// <remarks>
    /// Can set all variables in the class
    /// Can get data from all variables in the class
    /// </remarks>
    public class Order
    {
        
        public string orderNumber { get; set; }
        public string companyID { get; set; }
        public Address pickUpAddress { get; set; }
        public string pickUpDeadline { get; set; }
        public Address dropOffAddress { get; set; }
        public string dropOffDeadline { get; set; }
        public string contentDescription { get; set; }
        public string containerSize { get; set; }
        public float weight { get; set; }
        public string size { get; set; }
        public float price { get; set; }
        public string responsibleCompany { get; set; }
        public bool awaitingPickUp { get; set; }
        public bool pickedUp { get; set; }
        public bool delivered { get; set; }
        public bool lateDelivery { get; set; }
        public double distance { get; set; }

        public string getStatus()
        {
            string status;

            if (awaitingPickUp)
                status = "Assigned";
            else if (pickedUp)
                status = "Picked up";
            else if (delivered)
                status = "Delivered";
            else if (lateDelivery)
                status = "Late";
            else
                status = "Not assigned";

            return status;
        }
    }
}

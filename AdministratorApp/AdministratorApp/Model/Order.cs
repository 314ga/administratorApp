using AdministratorApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdministratorApp
{
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
    }
}

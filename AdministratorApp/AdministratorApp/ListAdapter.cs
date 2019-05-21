using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdministratorApp
{
    public class ListAdapter
    {
        public List<string[]> GetAllOrdersList(OrderList orderList)
        {
            List<string[]> orders = new List<string[]>();
            foreach (Order order in orderList.Orders)
            {
                string[] row = { order.orderNumber, order.companyID, order.pickUpAddress.ToString(), order.pickUpDeadline,
                    order.dropOffAddress.ToString(), order.dropOffDeadline, order.contentDescription, order.weight.ToString(),
                    order.size, order.price.ToString(), getStatus(order) };
                orders.Add(row);
            }
            return orders;

        }

        public List<string[]> GetAssignedOrderList(OrderList orderList)
        { 
            List<string[]> orders = new List<string[]>();
            foreach (Order order in orderList.Orders)
            {
                string[] row = { order.orderNumber, order.companyID, order.pickUpAddress.ToString(), order.pickUpDeadline,
                    order.dropOffAddress.ToString(), order.dropOffDeadline, order.contentDescription, order.weight.ToString(), order.size, order.price.ToString() };
                orders.Add(row);
            }
            return orders;

        }

        private string getStatus(Order order)
        {
            string status;

            if (order.awaitingPickUp)
                status = "Assigned";
            else if (order.pickedUp)
                status = "Picked up";
            else if (order.delivered)
                status = "Delivered";
            else if (order.lateDelivery)
                status = "Late";
            else
                status = "Not assigned";

            return status;
        }
    }
}

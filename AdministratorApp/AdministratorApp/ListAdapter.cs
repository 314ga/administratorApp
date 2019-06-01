﻿using AdministratorApp.Model;
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
            foreach (Order order in orderList.orders)
            {
                string[] row = { order.orderNumber, order.companyID, order.pickUpAddress.ToString(),
                    order.pickUpDeadline, order.dropOffAddress.ToString(), order.dropOffDeadline, order.getStatus() };
                orders.Add(row);
            }
            return orders;
        }

        public List<string[]> GetAllCustomers(ClientList clientList)
        {
           

            List<string[]> clients = new List<string[]>();
            foreach (AbstractClient client in clientList.clients)
            {
                string[] row = { client.clientId, client.companyName, client.address.ToString(), client.telephoneNumber, client.email };
                clients.Add(row);
            }
            return clients;
        }


       
    }
}

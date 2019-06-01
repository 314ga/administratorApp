using AdministratorApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdministratorApp.Service
{
    public interface IAdministratorService
    {
        OrderList GetOrdersList();
        Order GetOrderById(string id);
        OrderList GetAssignedOrders();
        OrderList GetUnassignedOrders();
        ClientList GetContractors();
        ClientList GetClients();
        AbstractClient GetClientById(string id);
        ClientList GetCustomers();
        void UpdateOrder(Order order);
        void DeleteOrder(Order order);
        Boolean AddClient(AbstractClient client);
        void UpdateClient(AbstractClient client);
        void DeleteClient(AbstractClient client);

    }
}

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
        OrderList GetOrdersByStatus();
        OrderList GetAllOrdersOrderByDeadline();
        Order GetOrderById(string id);
        OrderList GetAssignedOrders();
        OrderList GetUnassignedOrders();
        ClientList GetContractors();
        ClientList GetClients();

        AbstractClient GetClientById(string id);
        ClientList GetCustomers();
        Boolean UpdateOrder(Order order);
        Boolean DeleteOrder(Order order);
        Boolean AddClient(AbstractClient client);
        Boolean UpdateClient(AbstractClient client);
        Boolean DeleteClient(AbstractClient client);

    }
}

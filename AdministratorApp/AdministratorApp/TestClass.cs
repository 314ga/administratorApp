using AdministratorApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdministratorApp
{
    public class TestClass
    {

        public OrderList getFakeOrders()
        {
            Order order = new Order();
            order.companyID = "111";
            order.contentDescription = "ffff";
            Address adress = new Address();
            adress.city = "aaa";
            adress.country = "bbbb";
            adress.street = "cc";
            adress.zipCode = "d";
            order.pickUpAddress = adress;
            order.pickUpDeadline = "dddddddddddd";
            order.dropOffAddress = adress;
            order.dropOffDeadline = "wewwewwew";
            order.contentDescription = "ffff";
            order.containerSize = "111";
            order.weight = 44;
            order.size = "ffff";
            order.price = 4444;
            order.containerSize = "111";
            order.weight = 44;
            order.size = "ffff";
            order.price = 4444;
            List<Order> aladar = new List<Order>();
            aladar.Add(order);
            aladar.Add(order);
            aladar.Add(order);
            aladar.Add(order);
            OrderList orderList = new OrderList();
            orderList.Orders = aladar;
            return orderList;
            
        }
    }
}

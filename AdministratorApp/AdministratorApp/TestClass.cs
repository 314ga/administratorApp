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

using AdministratorApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdministratorApp
{
    class TestClass
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
            order.awaitingPickUp = false;
            order.pickedUp = false;
            order.delivered = false;
            order.lateDelivery = true;

            List<Order> aladar = new List<Order>();
            aladar.Add(order);
            aladar.Add(order);
            aladar.Add(order);
            aladar.Add(order);
            OrderList orderList = new OrderList();
            orderList.orders = aladar;
            return orderList;
        }

        public ClientList getFakeCustomers() {
            AbstractClient customer1 = new AbstractClient();
            customer1.clientId = "11";
            customer1.companyName = "customer";
            Address adress = new Address();
            adress.city = "aaa";
            adress.country = "bbbb";
            adress.street = "cc";
            adress.zipCode = "d";
            customer1.address = adress;
            customer1.email = "fsf@gmail.com";
            customer1.telephoneNumber = "0904 253 365";

            AbstractClient customer2 = new AbstractClient();
            customer2.clientId = "11";
            customer2.companyName = "kdk";
            customer2.address = adress;
            customer2.email = "fsf@gmail.com";
            customer2.telephoneNumber = "0904 253 365";

            List<AbstractClient> listadat = new List<AbstractClient>();
            listadat.Add(customer1);
            listadat.Add(customer2);

            ClientList clientList = new ClientList();
            clientList.clients = listadat;
            return clientList;
        }


        public ClientList getFakeContractors()
        {
            AbstractClient customer1 = new AbstractClient();
            customer1.clientId = "22";
            customer1.companyName = "contractor";
            Address adress = new Address();
            adress.city = "aaa";
            adress.country = "bbbb";
            adress.street = "cc";
            adress.zipCode = "d";
            customer1.address = adress;
            customer1.email = "fsf@gmail.com";
            customer1.telephoneNumber = "0904 253 365";

            AbstractClient customer2 = new AbstractClient();
            customer2.clientId = "11";
            customer2.companyName = "cont2";
            customer2.address = adress;
            customer2.email = "fsf@gmail.com";
            customer2.telephoneNumber = "0904 253 365";

            List<AbstractClient> listadat = new List<AbstractClient>();
            listadat.Add(customer1);
            listadat.Add(customer2);

            ClientList clientList = new ClientList();
            clientList.clients = listadat;
            return clientList;
        }

        public ClientList getFakeClients() {
            AbstractClient customer1 = new AbstractClient();
            customer1.clientId = "22";
            customer1.companyName = "contractor";
            Address adress = new Address();
            adress.city = "aaa";
            adress.country = "bbbb";
            adress.street = "cc";
            adress.zipCode = "d";
            customer1.address = adress;
            customer1.email = "fsf@gmail.com";
            customer1.telephoneNumber = "0904 253 365";

            AbstractClient customer2 = new AbstractClient();
            customer2.clientId = "11";
            customer2.companyName = "cont2";
            customer2.address = adress;
            customer2.email = "fsf@gmail.com";
            customer2.telephoneNumber = "0904 253 365";

            AbstractClient customer3 = new AbstractClient();
            customer3.clientId = "11";
            customer3.companyName = "customer";
           
            customer3.address = adress;
            customer3.email = "fsf@gmail.com";
            customer3.telephoneNumber = "0904 253 365";

            AbstractClient customer4 = new AbstractClient();
            customer4.clientId = "11";
            customer4.companyName = "kdk";
            customer4.address = adress;
            customer4.email = "fsf@gmail.com";
            customer4.telephoneNumber = "0904 253 365";

            List<AbstractClient> listadat = new List<AbstractClient>();
            listadat.Add(customer1);
            listadat.Add(customer2);
            listadat.Add(customer3);
            listadat.Add(customer4);

            ClientList clientList = new ClientList();
            clientList.clients = listadat;
            return clientList;


        }


    }
}

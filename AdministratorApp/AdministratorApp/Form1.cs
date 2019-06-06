using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AdministratorApp.Model;
using AdministratorApp.Controller;


namespace AdministratorApp
{
    public partial class form1 : Form
    {
        private ListAdapter listAdapter = new ListAdapter();
        private OrderList orderList;
        private ClientList clientList;
        private ListViewItem selectedRow;
        private AdministratorController administratorService = new AdministratorController();
    
        public form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        #region orders radio buttons
        private void allRadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            // get all orders from database
            if (allRadioBtn.Checked == true)
            {
                orderList = administratorService.GetOrdersList();
                updateListView();
            }
                
        }

        private void assignedRadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (assignedRadioBtn.Checked == true)
            {
                orderList = administratorService.GetAssignedOrders();
                updateListView();
            }
        }

        private void unassignedRadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (unassignedRadioBtn.Checked == true)
            {
                orderList = administratorService.GetUnassignedOrders();
                updateListView();
            }
        }

        #endregion

        #region clients radio buttons
        private void CustomerButton_CheckedChanged(object sender, EventArgs e)
        {
            if (CustomerButton.Checked == true)
            {
                clientList = administratorService.GetCustomers();
                updateCustomerView();
            }
        }

        private void ContractorButton_CheckedChanged(object sender, EventArgs e)
        {
            if (ContractorButton.Checked == true)
            {
                clientList = administratorService.GetContractors();
                updateCustomerView();
            }
        }

        private void AllClients_CheckedChanged(object sender, EventArgs e)
        {
            if (AllClients.Checked == true)
            {
                clientList = administratorService.GetClients();
                updateCustomerView();
            }
        }
        #endregion


        private void AddClient_Click(object sender, EventArgs e)
        {
            Form2 addClient = new Form2();
            addClient.ShowDialog();
        }


        private void clientTab_Enter(object sender, EventArgs e)
        {
            if (AllClients.Checked)
            {
                clientList = administratorService.GetClients();
                updateCustomerView();
            }
            else
                AllClients.Checked = true;

        }

        private void allOrders_Enter(object sender, EventArgs e)
        {
            if (allRadioBtn.Checked)
            {
                orderList = administratorService.GetOrdersList();
                updateListView();
            }
            else
                allRadioBtn.Checked = true;

            foreach (ListViewItem item in clientListView.Items)
            {
                item.BackColor = item.Index % 2 == 0 ? Color.LightGray : Color.LightBlue;
            }
        }

        #region update listViews private methods


        private void updateListView()
        {
            orderListView.Items.Clear();
            List<string[]> orders = listAdapter.GetAllOrdersList(orderList);
            foreach (string[] order in orders)
            {
                orderListView.Items.Add(new ListViewItem(order));
            }
            paintOrderRows();
        }

        private void updateCustomerView()
        {
            clientListView.Items.Clear();
            List<string[]> clients = listAdapter.GetAllCustomers(clientList);
            foreach (string[] client in clients)
            {
                clientListView.Items.Add(new ListViewItem(client));
            }
            paintClientRows();
        }


        #endregion


        private string ConstructOrderString(Order order)
        {
            string result = "Order number: " + order.orderNumber + Environment.NewLine +
                "Created by: " + order.companyID + Environment.NewLine +
                "Status: " + order.getStatus() + Environment.NewLine +
                "Responsible company: " + order.responsibleCompany + Environment.NewLine +
                "Price: " + order.price + " €" + Environment.NewLine +
                "Package size: " + order.size + Environment.NewLine +
                "Weight: " + order.weight + " kg" + Environment.NewLine +
                "Pick up address: " + order.pickUpAddress + Environment.NewLine +
                "Drop off address: " + order.dropOffAddress + Environment.NewLine +
                "Description: " + order.contentDescription + Environment.NewLine +
                "Container size: " + order.containerSize + Environment.NewLine +
                "Distance: " + order.distance + " km";
            return result;


        }
        private string ConstructClientString(AbstractClient client)
        {
            string result = "Created by: " + client.clientId + Environment.NewLine
                + "Client type: " + client.clientType + Environment.NewLine
                + "Company name: " + client.companyName + Environment.NewLine
                + "E-mail: " + client.email + Environment.NewLine
                + "Tel. number: " + client.telephoneNumber + Environment.NewLine
                + "Address: " + client.address + Environment.NewLine;

            return result;


        }

        private void allInfoBtn_Click(object sender, EventArgs e)
        {
            if (orderListView.SelectedItems.Count > 0)
            {
                ListViewItem item = orderListView.SelectedItems[0];
                Order order = administratorService.GetOrderById(item.SubItems[0].Text);
                CustomMessageBox.ShowMessage(ConstructOrderString(order), "Order Details", MessageBoxButtons.OK, 2);
            }
            else
            {

            }
        }

        private void clientInfo_Click(object sender, EventArgs e)
        {
            if (clientListView.SelectedItems.Count > 0)
            {
                ListViewItem item = clientListView.SelectedItems[0];
                AbstractClient client = administratorService.GetClientById(item.SubItems[0].Text);
                CustomMessageBox.ShowMessage(ConstructClientString(client), "Order Details", MessageBoxButtons.OK, 2);
            }
            else
            {

            }
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            if (orderListView.SelectedItems.Count > 0)
            {
                OrderViewForm editOrder = new OrderViewForm();
                ListViewItem item = orderListView.SelectedItems[0];
                Order order = administratorService.GetOrderById(item.SubItems[0].Text);
                Address pickUpAddress = order.pickUpAddress;
                Address dropOffAddress = order.dropOffAddress;
                editOrder.avaitingPickUp = order.awaitingPickUp;
                editOrder.PickedUp = order.pickedUp;
                editOrder.LateDelivery = order.lateDelivery;
                editOrder.Delivered = order.delivered;
                editOrder.Description = order.contentDescription;
                editOrder.PriceField = order.price.ToString();
                editOrder.ContainerSize = order.containerSize;
                editOrder.PackageSizeField = order.size;
                editOrder.Weight = order.weight.ToString();
                editOrder.ContainerSize = order.containerSize;
                editOrder.PickCityField = pickUpAddress.city;
                editOrder.PickPostcodeField = pickUpAddress.zipCode;
                editOrder.PickStateFeild = pickUpAddress.country;
                editOrder.PickStreetField = pickUpAddress.street;
                editOrder.DropCityField = dropOffAddress.city;
                editOrder.DropPostcodeField = dropOffAddress.zipCode;
                editOrder.DropStateFeild = dropOffAddress.country;
                editOrder.DropStreetField = dropOffAddress.street;
                editOrder.SetDropOffPicker(order.dropOffDeadline);
                editOrder.SetPickUpPicker(order.pickUpDeadline);
                editOrder.setOrderID(item.SubItems[0].Text);
                editOrder.ShowDialog();
            }
        }

        private void EditClient_Click(object sender, EventArgs e)
        {
            if (clientListView.SelectedItems.Count > 0)
            {
                Form2 addClient = new Form2();
                ListViewItem item = clientListView.SelectedItems[0];
                AbstractClient client = administratorService.GetClientById(item.SubItems[0].Text);
                addClient.CompanyNameField = client.companyName;
                addClient.TelNumberField = client.telephoneNumber;
                addClient.EmailField = client.email;
                addClient.StreetField = client.address.street;
                addClient.PostcodeField = client.address.zipCode;
                addClient.CityField = client.address.city;
                addClient.StateFeild = client.address.country;
                addClient.Title = "     Edit client";
                addClient.setClientID(item.SubItems[0].Text);
                addClient.changeButtonName("Save changes");
                if (client.clientType.Equals("customer"))
                {
                    addClient.CustomerButton = true;
                }
                else
                {
                    addClient.ContractorButton = true;
                }
                addClient.ShowDialog();
            }
        }

        private void DeleteClient_Click(object sender, EventArgs e)
        {
            if (clientListView.SelectedItems.Count > 0)
            {
                ListViewItem item = clientListView.SelectedItems[0];
                AbstractClient client = administratorService.GetClientById(item.SubItems[0].Text);
                if (administratorService.DeleteClient(client))
                {
                    MessageBox.Show("Client succesfully deleted");
                    if (AllClients.Checked)
                    {
                        clientList = administratorService.GetClients();
                        updateCustomerView();
                    }
                    else
                        AllClients.Checked = true;
                }
                else
                {
                    MessageBox.Show("Error deleting user", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            
        }

        private void clientListView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            if (AllClients.Checked)
            {
                clientList = administratorService.GetClients();
                updateCustomerView();
            }

            else
                AllClients.Checked = true;
        }

        private void RefreshButton_Click(object sender, EventArgs e)
        {
            if (allRadioBtn.Checked)
            {
                orderList = administratorService.GetOrdersList();
                updateListView();
            }
            else
                allRadioBtn.Checked = true;

        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if (orderListView.SelectedItems.Count > 0)
            {
                ListViewItem item = orderListView.SelectedItems[0];
                Order order = new Order();
                order.orderNumber = item.SubItems[0].Text;
                if (administratorService.DeleteOrder(order))
                {
                    MessageBox.Show("Order succesfully deleted");
                    if (allRadioBtn.Checked)
                    {
                        orderList = administratorService.GetOrdersList();
                        updateListView();
                    }
                    else
                        allRadioBtn.Checked = true;
                }
                else
                {
                    MessageBox.Show("Error deleting order", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void DeadlineFIlter_CheckedChanged(object sender, EventArgs e)
        {
            if (DeadlineFIlter.Checked == true)
            {
                orderList = administratorService.GetAllOrdersOrderByDeadline();
                updateListView();
            }
        }

        private void CustomerFilter_CheckedChanged(object sender, EventArgs e)
        {
            if (CustomerButton.Checked)
            {
                orderList = administratorService.GetOrdersList();
                updateListView();
            }
        }

        private void StatusFilter_CheckedChanged(object sender, EventArgs e)
        {
            if (StatusFilter.Checked)
            {
                orderList = administratorService.GetOrdersByStatus();
                updateListView();
            }
        }

        private void paintClientRows()
        {
            foreach (ListViewItem item in clientListView.Items)
            {
                item.BackColor = item.Index % 2 == 0 ? Color.LightGray : Color.LightBlue;
            }
        }
        private void paintOrderRows()
        {
            foreach (ListViewItem item in orderListView.Items)
            {
                item.BackColor = item.Index % 2 == 0 ? Color.LightGray : Color.LightBlue;
            }
        }

        private void orderListView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

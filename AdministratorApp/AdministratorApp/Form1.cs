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
using AdministratorApp.Service;


namespace AdministratorApp
{
    /// <summary>
    /// The class creates main view for the administrator application
    /// </summary>
    /// <remarks>
    /// responsible for logic after clicking on the buttons
    /// constructing string for client and order information
    /// painting list row colors
    /// </remarks>
    public partial class form1 : Form
    {
        private ListAdapter listAdapter = new ListAdapter();
        private OrderList orderList;
        private ClientList clientList;
        private ListViewItem selectedRow;
        private AdministratorService administratorService = new AdministratorService();
    
        public form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        #region orders radio buttons
        /// <summary>
        /// get all orders from the database after checking all check button
        /// </summary>
        private void allRadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            // get all orders from database
            if (allRadioBtn.Checked == true)
            {
                orderList = administratorService.GetOrdersList();
                updateListView();
            }
                
        }

        /// <summary>
        /// get all assign orders from the database after checking assigned check button
        /// </summary>
        private void assignedRadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (assignedRadioBtn.Checked == true)
            {
                orderList = administratorService.GetAssignedOrders();
                updateListView();
            }
        }

        /// <summary>
        /// get all unassign orders from the database after checking unassigned check button
        /// </summary>
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
        /// <summary>
        /// get all customers from the database after checking customer check button
        /// </summary>
        private void CustomerButton_CheckedChanged(object sender, EventArgs e)
        {
            if (CustomerButton.Checked == true)
            {
                clientList = administratorService.GetCustomers();
                updateCustomerView();
            }
        }
        /// <summary>
        /// get all contractor from the database after checking contractor check button
        /// </summary>
        private void ContractorButton_CheckedChanged(object sender, EventArgs e)
        {
            if (ContractorButton.Checked == true)
            {
                clientList = administratorService.GetContractors();
                updateCustomerView();
            }
        }
        /// <summary>
        /// get all clients from the database after checking all clients check button
        /// </summary>
        private void AllClients_CheckedChanged(object sender, EventArgs e)
        {
            if (AllClients.Checked == true)
            {
                clientList = administratorService.GetClients();
                updateCustomerView();
            }
        }
        #endregion

        /// <summary>
        /// shows dialog after clicking on the ad client
        /// </summary>
        private void AddClient_Click(object sender, EventArgs e)
        {
            Form2 addClient = new Form2();
            addClient.ShowDialog();
        }

        /// <summary>
        /// getting all clients and updating list view after enter client view tab
        /// </summary>
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

        /// <summary>
        /// getting all orders and updating list view after enter order view tab
        /// </summary>
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

        /// <summary>
        /// update order list view
        /// </summary>
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
        /// <summary>
        /// update customer list view
        /// </summary>
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

        /// <summary>
        /// costruct string for the dialog from order object
        /// </summary>
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

        /// <summary>
        /// construct string object from the AbstractClient object
        /// </summary>
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

        /// <summary>
        /// showing dialog window after click on the all information button
        /// </summary>
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

        /// <summary>
        /// showing dialog window after click on the all information button
        /// </summary>
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

        /// <summary>
        /// showing edit dialog window for order after click on the edit button
        /// </summary>
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

        /// <summary>
        /// showing edit client dialog window after click on the edit button
        /// </summary>
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

        /// <summary>
        /// delete client from the database after click on the delete button
        /// </summary>
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


        /// <summary>
        /// refresh client list view after click on the refresh button
        /// </summary>
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

        /// <summary>
        /// refresh order list view after click on the refresh button
        /// </summary>
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

        /// <summary>
        /// delete order from the database after click on the delete button
        /// </summary>
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

        /// <summary>
        /// getting order from database ordered by deadline
        /// </summary>
        private void DeadlineFIlter_CheckedChanged(object sender, EventArgs e)
        {
            if (DeadlineFIlter.Checked == true)
            {
                orderList = administratorService.GetAllOrdersOrderByDeadline();
                updateListView();
            }
        }

        /// <summary>
        /// getting order from database ordered by customer
        /// </summary>
        private void CustomerFilter_CheckedChanged(object sender, EventArgs e)
        {
            if (CustomerButton.Checked)
            {
                orderList = administratorService.GetOrdersList();
                updateListView();
            }
        }


        /// <summary>
        /// getting order from database ordered by status
        /// </summary>
        private void StatusFilter_CheckedChanged(object sender, EventArgs e)
        {
            if (StatusFilter.Checked)
            {
                orderList = administratorService.GetOrdersByStatus();
                updateListView();
            }
        }


        /// <summary>
        /// painitng rows in list view for clients
        /// </summary>
        private void paintClientRows()
        {
            foreach (ListViewItem item in clientListView.Items)
            {
                item.BackColor = item.Index % 2 == 0 ? Color.LightGray : Color.LightBlue;
            }
        }


        /// <summary>
        /// painting rows in list view for orders
        /// </summary>
        private void paintOrderRows()
        {
            foreach (ListViewItem item in orderListView.Items)
            {
                item.BackColor = item.Index % 2 == 0 ? Color.LightGray : Color.LightBlue;
            }
        }
    }
}

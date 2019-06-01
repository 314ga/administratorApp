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
        }

        private void updateCustomerView()
        {
            clientListView.Items.Clear();
            List<string[]> clients = listAdapter.GetAllCustomers(clientList);
            foreach (string[] client in clients)
            {
                clientListView.Items.Add(new ListViewItem(client));
            }
        }
        #endregion


        private string ConstructOrderString(Order order)
        {
            string result = "Created by: " + order.companyID + Environment.NewLine +
                "Created by: " + order.companyID + Environment.NewLine +
                "Created by: " + order.companyID + Environment.NewLine +
                "Created by: " + order.companyID + Environment.NewLine +
                "Created by: " + order.companyID + Environment.NewLine +
                "Created by: " + order.companyID + Environment.NewLine +
                "Created by: " + order.companyID + Environment.NewLine +
                "Created by: " + order.companyID + Environment.NewLine +
                "Created by: " + order.companyID + Environment.NewLine;
            return result;


        }
        private string ConstructClientString(AbstractClient client)
        {
            string result = "Created by: " + client.clientId + Environment.NewLine +
                "Created by: " + client.clientType + Environment.NewLine;
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
           
        }

        private void EditClient_Click(object sender, EventArgs e)
        {
            Form2 addClient = new Form2();
            ListViewItem item = clientListView.SelectedItems[0];
            AbstractClient client = administratorService.GetClientById(item.SubItems[0].Text);
            addClient.CompanyNameField = client.companyName;
            addClient.ShowDialog();
        }

        private void orderListView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

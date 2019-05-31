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
        ListAdapter listAdapter = new ListAdapter();
        OrderList orderList;
        ClientList clientList;
        AdministratorService administratorService = new AdministratorService();
    
        public form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void updateListView()
        {
            listView1.Items.Clear();
            List<string[]> orders = listAdapter.GetAllOrdersList(orderList);
            foreach (string[] order in orders)
            {
                listView1.Items.Add(new ListViewItem(order));
            }
        }

        private void updateCustomerView()
        {
            listView2.Items.Clear();
            List<string[]> clients = listAdapter.GetAllCustomers(clientList);
            foreach (string[] client in clients)
            {
                listView2.Items.Add(new ListViewItem(client));
            }
        }



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




        private void AddClient_Click(object sender, EventArgs e)
        {
            Form2 addClient = new Form2();
            addClient.ShowDialog();
        }
    }
}

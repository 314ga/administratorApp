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
       

       // AdministratorService client = new AdministratorService();
        public form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

 
        private void tabControl1_Enter(object sender, EventArgs e)
        {
            //get all orders from database
            TestClass testData = new TestClass();
            testData.getFakeOrders();
            updateListView();
        }

        private void allClientView_Enter(object sender, EventArgs e)
        {
            //get all orders from database
            TestClass testData = new TestClass();
            testData.getFakeClients();
            updateListView();
        }

        private void button1_Click(object sender, EventArgs e)
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
            TestClass testData = new TestClass();
            testData.getFakeOrders();
            updateListView();
        }

        private void assignedRadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            //TODO: get assigned orders from database
            TestClass testData = new TestClass();
            testData.getFakeOrders();
            updateListView();
        }

        private void unassignedRadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            //TODO: get unassigned orders from database
            TestClass testData = new TestClass();
            testData.getFakeOrders();
            updateListView();
        }

        private void AllClients_CheckedChanged(object sender, EventArgs e)
        {
            TestClass testData = new TestClass();
            testData.getFakeClients();
            updateCustomerView();

        }

        private void CustomerButton_CheckedChanged(object sender, EventArgs e)
        {
            TestClass testData = new TestClass();
            testData.getFakeCustomers();
            updateCustomerView();
        }

        private void ContractorButton_CheckedChanged(object sender, EventArgs e)
        {
            TestClass testData = new TestClass();
            testData.getFakeContractors();
            updateCustomerView();
        }


        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            
        }

       

        private void AddClient_Click(object sender, EventArgs e)
        {
            Form2 addClient = new Form2();
            addClient.ShowDialog();
        }

    }
}

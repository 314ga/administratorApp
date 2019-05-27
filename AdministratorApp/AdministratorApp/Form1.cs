using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AdministratorApp.Service;


namespace AdministratorApp
{
    public partial class form1 : Form
    {
        ListAdapter listAdapter = new ListAdapter();
        OrderList orderList;
        public form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

 
        private void tabControl1_Enter(object sender, EventArgs e)
        {
            //TODO: get all orders from database
            AdministratorService client = new AdministratorService();
            orderList = client.GetOrdersList();
            updateListView();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void allRadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            //TODO: get all orders from database
            AdministratorService client = new AdministratorService();
            orderList = client.GetOrdersList();
            updateListView();
        }

        private void updateListView()
        {
            listView1.Items.Clear();
            List<string[]> orders = listAdapter.GetAllOrdersList(orderList);
            int rowNumber = 0;
            foreach (string[] order in orders)
            {
                listView1.Items.Add("" + rowNumber).SubItems.AddRange(order);
                rowNumber++;
            }
        }

        private void assignedRadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            //TODO: get assigned orders from database
            AdministratorService client = new AdministratorService();
            orderList = client.GetOrdersList();

            updateListView();
        }

        private void unassignedRadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            //TODO: get unassigned orders from database
            AdministratorService client = new AdministratorService();
            orderList = client.GetOrdersList();
            updateListView();
        }
    }
}

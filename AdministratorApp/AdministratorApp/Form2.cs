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
    public partial class Form2 : Form
    {
        IAdministratorService administratorService = new AdministratorService();
        public Form2()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        #region hints

        private void TelNo_Enter(object sender, EventArgs e)
        {
            if (TelNo.Text == "Tel. number")
            {
                TelNo.Text = "";

                TelNo.ForeColor = Color.Black;
            }
        }

        private void TelNo_Leave(object sender, EventArgs e)
        {
            if (TelNo.Text == "")
            {
                TelNo.Text = "Tel. number";

                TelNo.ForeColor = Color.Silver;
            }
        }

        private void Email_Enter(object sender, EventArgs e)
        {
            if (Email.Text == "Email")
            {
                Email.Text = "";

                Email.ForeColor = Color.Black;
            }
        }

        private void Email_Leave(object sender, EventArgs e)
        {
            if (Email.Text == "")
            {
                Email.Text = "Email";

                Email.ForeColor = Color.Silver;
            }
        }

        private void CompanyName_Enter(object sender, EventArgs e)
        {
            if (CompanyName.Text == "Company name")
            {
                CompanyName.Text = "";

                CompanyName.ForeColor = Color.Black;
            }
        }

        private void CompanyName_Leave(object sender, EventArgs e)
        {
            if (CompanyName.Text == "")
            {
                CompanyName.Text = "Company name";

                CompanyName.ForeColor = Color.Silver;
            }
        }


        private void street_Enter(object sender, EventArgs e)
        {
            if (street.Text == "Street")
            {
                street.Text = "";

                street.ForeColor = Color.Black;
            }
        }

        private void street_Leave(object sender, EventArgs e)
        {
            if (street.Text == "")
            {
                street.Text = "Street";

                street.ForeColor = Color.Silver;
            }
        }

        private void postcode_Enter(object sender, EventArgs e)
        {
            if (postcode.Text == "Postcode")
            {
                postcode.Text = "";

                postcode.ForeColor = Color.Black;
            }
        }

        private void postcode_Leave(object sender, EventArgs e)
        {
            if (postcode.Text == "")
            {
                postcode.Text = "Postcode";

                postcode.ForeColor = Color.Silver;
            }
        }

        private void city_Enter(object sender, EventArgs e)
        {
            if (city.Text == "City")
            {
                city.Text = "";

                city.ForeColor = Color.Black;
            }
        }

        private void city_Leave(object sender, EventArgs e)
        {
            if (city.Text == "")
            {
                city.Text = "City";

                city.ForeColor = Color.Silver;
            }
        }

        private void state_Enter(object sender, EventArgs e)
        {
            if (state.Text == "State")
            {
                state.Text = "";

                state.ForeColor = Color.Black;
            }
        }

        private void state_Leave(object sender, EventArgs e)
        {
            if (state.Text == "")
            {
                state.Text = "State";

                state.ForeColor = Color.Silver;
            }
        }
        #endregion

        private void button1_Click(object sender, EventArgs e)
        {
            if (city.Text.Equals("City") || state.Text.Equals("State") || street.Text.Equals("Street")
                || state.Text.Equals("State") || postcode.Text.Equals("Postcode") || CompanyName.Text.Equals("Company name")
                || Email.Text.Equals("Email") || TelNo.Text.Equals("Tel. number") || !(customer.Checked || contractor.Checked))
            {
                MessageBox.Show("Wrong input", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {

                Address address = new Address();
                address.city = city.Text;
                address.country = state.Text;
                address.street = street.Text;
                address.zipCode = postcode.Text;
                AbstractClient client = new AbstractClient();
                client.address = address;
                client.companyName = CompanyName.Text;
                client.email = Email.Text;
                client.telephoneNumber = TelNo.Text;
                if (customer.Checked)
                    client.clientType = "customer";
                else
                    client.clientType = "contractor";
                client.passwordHash = "123456";
                if (administratorService.AddClient(client))
                {
                    this.Close();
                    MessageBox.Show("Client succesfully created");
                }
                else
                {
                    MessageBox.Show("Error creating user","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
            }

             
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}

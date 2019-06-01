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
    public partial class OrderViewForm : Form
    {
        IAdministratorService administratorService = new AdministratorService();
        public OrderViewForm()
        {
            InitializeComponent();
        }
        #region getters, setters
    
        public string EmailField
        {
            get { return Email.Text; }
            set { Email.Text = value; }

        }
        public string StreetField
        {
            get { return street.Text; }
            set { street.Text = value; }

        }
        public string PostcodeField
        {
            get { return postcode.Text; }
            set { postcode.Text = value; }

        }
        public string CityField
        {
            get { return city.Text; }
            set { city.Text = value; }

        }
        public string StateFeild
        {
            get { return state.Text; }
            set { state.Text = value; }

        }
        public Boolean CustomerButton
        {
            get { return customer.Checked; }
            set { customer.Checked = value; }

        }
        public Boolean ContractorButton
        {
            get { return contractor.Checked; }
            set { contractor.Checked = value; }

        }
        #endregion

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        #region hints

       

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

       

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

 
    }
}

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

        public string PickStreetField
        {
            get { return street.Text; }
            set { street.Text = value; }

        }
        public string PickPostcodeField
        {
            get { return postcode.Text; }
            set { postcode.Text = value; }

        }
        public string PickCityField
        {
            get { return city.Text; }
            set { city.Text = value; }

        }
        public string PickStateFeild
        {
            get { return state.Text; }
            set { state.Text = value; }

        }
        public string DropStreetField
        {
            get { return dropStreet.Text; }
            set { dropStreet.Text = value; }

        }
        public string DropPostcodeField
        {
            get { return dropPostcode.Text; }
            set { dropPostcode.Text = value; }

        }
        public string DropCityField
        {
            get { return dropCity.Text; }
            set { dropCity.Text = value; }

        }
        public string DropStateFeild
        {
            get { return dropState.Text; }
            set { dropState.Text = value; }

        }
        public string Weight
        {
            get { return weight.Text; }
            set { weight.Text = value; }

        }
        public string PriceField
        {
            get { return Price.Text; }
            set { Price.Text = value; }

        }
        public string PackageSizeField
        {
            get { return Size.Text; }
            set { Size.Text = value; }

        }
        public string ContainerSize
        {
            get { return containerSize.Text; }
            set { containerSize.Text = value; }

        }
        public Boolean avaitingPickUp
        {
            get { return avaitingPickCheck.Checked; }
            set { avaitingPickCheck.Checked = value; }

        }
        public Boolean PickedUp
        {
            get { return pickedUpCheck.Checked; }
            set { pickedUpCheck.Checked = value; }
        }
        public Boolean LateDelivery
        {
            get { return lateDeliveryCheck.Checked; }
            set { lateDeliveryCheck.Checked = value; }

        }
        public Boolean Delivered
        {
            get { return deliveredCheck.Checked; }
            set { deliveredCheck.Checked = value; }
        }

        #endregion

   

        #region hints

       

             
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


       
    }
}

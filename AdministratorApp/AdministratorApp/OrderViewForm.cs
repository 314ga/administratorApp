using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
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
        private IAdministratorService administratorService = new AdministratorService();
        private string orderID = "0";
        public OrderViewForm()
        {
            InitializeComponent();
        }
        #region getters, setters

        public void setOrderID(string id)
        {
            orderID = id;
        }

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
        public string Description
        {
            get { return description.Text; }
            set { description.Text = value; }

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
        public void SetPickUpPicker(string date)
        {
            pickUpPicker.Value = DateTime.ParseExact(date, "dd-MM-yyyy HH:mm:ss", CultureInfo.InvariantCulture);
        }
        public void SetDropOffPicker(string date)
        {
            dropOffPicker.Value = DateTime.ParseExact(date, "dd-MM-yyyy HH:mm:ss", CultureInfo.InvariantCulture);
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

        private void saveChanges_Click(object sender, EventArgs e)
        {
            if (city.Text.Equals("") || state.Text.Equals("") || street.Text.Equals("")
                || postcode.Text.Equals("") ||dropCity.Text.Equals("") || dropState.Text.Equals("") || dropStreet.Text.Equals("")
                || dropPostcode.Text.Equals("") || Price.Equals("")
                || weight.Equals("Email") ||containerSize.Equals("Tel. number"))
            {
                MessageBox.Show("Wrong input", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {

                Order order = new Order();
                Address pickUpAddress = new Address();
                Address dropOffAddress = new Address();
                order.orderNumber = orderID;
                order.awaitingPickUp = avaitingPickCheck.Checked;
                order.pickedUp = pickedUpCheck.Checked;
                order.lateDelivery = lateDeliveryCheck.Checked;
                order.delivered = deliveredCheck.Checked;
                order.contentDescription = description.Text;
                order.price = float.Parse(Price.Text);
                order.containerSize = containerSize.Text;
                order.size = Size.Text;
                order.weight = float.Parse(weight.Text);
                order.containerSize = containerSize.Text;
                pickUpAddress.city = city.Text;
                pickUpAddress.zipCode = postcode.Text;
                pickUpAddress.country = state.Text;
                pickUpAddress.street = street.Text;
                order.pickUpAddress = pickUpAddress;
                dropOffAddress.city = dropCity.Text;
                dropOffAddress.zipCode = dropPostcode.Text;
                dropOffAddress.country = dropState.Text;
                dropOffAddress.street = dropStreet.Text;
                order.dropOffAddress = dropOffAddress;
                order.dropOffDeadline = dropOffPicker.Value.ToString("dd-MM-yyyy HH:mm:ss");
                order.pickUpDeadline = pickUpPicker.Value.ToString("dd-MM-yyyy HH:mm:ss");
             
                if (administratorService.UpdateOrder(order))
                {

                    this.Close();
                    MessageBox.Show("Order succesfully change");
                }
                else
                {
                    MessageBox.Show("Error changing user", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }


        }
    }
    
}

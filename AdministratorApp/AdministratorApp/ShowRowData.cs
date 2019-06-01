using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdministratorApp
{
    public partial class ShowRowData : Form
    {
        public ShowRowData()
        {
            InitializeComponent();
        }

        public Image MessageIcon
        {
            get { return pictureBox1.Image; }
            set { pictureBox1.Image = value; }

        }


        public string Message
        {
            get { return clientInfoTxtBox.Text; }
            set { clientInfoTxtBox.Text = value; }

        }

    }
}

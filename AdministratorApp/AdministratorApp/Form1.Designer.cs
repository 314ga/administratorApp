using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace AdministratorApp
{
    partial class form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.allOrdersList = new System.Windows.Forms.TabControl();
            this.allOrders = new System.Windows.Forms.TabPage();
            this.unassignedRadioBtn = new System.Windows.Forms.RadioButton();
            this.assignedRadioBtn = new System.Windows.Forms.RadioButton();
            this.allRadioBtn = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.allInfoBtn = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.editBtn = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.refreshBtn = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.orderID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.created = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pickUpAdd = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pickUpDead = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dropOffAdd = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dropOffDead = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.description = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.weight = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Size = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.price = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.status = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clientTab = new System.Windows.Forms.TabPage();
            this.orderNumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.createdBy = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pickUpAddress = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.allOrdersList.SuspendLayout();
            this.allOrders.SuspendLayout();
            this.SuspendLayout();
            // 
            // allOrdersList
            // 
            this.allOrdersList.Controls.Add(this.allOrders);
            this.allOrdersList.Controls.Add(this.clientTab);
            this.allOrdersList.ItemSize = new System.Drawing.Size(100, 18);
            this.allOrdersList.Location = new System.Drawing.Point(0, -1);
            this.allOrdersList.Name = "allOrdersList";
            this.allOrdersList.SelectedIndex = 0;
            this.allOrdersList.Size = new System.Drawing.Size(1158, 605);
            this.allOrdersList.TabIndex = 0;
            this.allOrdersList.Enter += new System.EventHandler(this.tabControl1_Enter);
            // 
            // allOrders
            // 
            this.allOrders.AccessibleRole = System.Windows.Forms.AccessibleRole.Cursor;
            this.allOrders.BackColor = System.Drawing.Color.Blue;
            this.allOrders.Controls.Add(this.unassignedRadioBtn);
            this.allOrders.Controls.Add(this.assignedRadioBtn);
            this.allOrders.Controls.Add(this.allRadioBtn);
            this.allOrders.Controls.Add(this.label1);
            this.allOrders.Controls.Add(this.allInfoBtn);
            this.allOrders.Controls.Add(this.button5);
            this.allOrders.Controls.Add(this.editBtn);
            this.allOrders.Controls.Add(this.deleteBtn);
            this.allOrders.Controls.Add(this.textBox1);
            this.allOrders.Controls.Add(this.refreshBtn);
            this.allOrders.Controls.Add(this.listView1);
            this.allOrders.Font = new System.Drawing.Font("Adobe Fan Heiti Std B", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.allOrders.ForeColor = System.Drawing.Color.White;
            this.allOrders.Location = new System.Drawing.Point(4, 22);
            this.allOrders.Name = "allOrders";
            this.allOrders.Padding = new System.Windows.Forms.Padding(3);
            this.allOrders.Size = new System.Drawing.Size(1150, 579);
            this.allOrders.TabIndex = 0;
            this.allOrders.Text = "All orders";
            this.allOrders.UseVisualStyleBackColor = true;
            // 
            // unassignedRadioBtn
            // 
            this.unassignedRadioBtn.BackColor = System.Drawing.Color.SlateGray;
            this.unassignedRadioBtn.Font = new System.Drawing.Font("Adobe Fan Heiti Std B", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.unassignedRadioBtn.Location = new System.Drawing.Point(1029, 213);
            this.unassignedRadioBtn.Name = "unassignedRadioBtn";
            this.unassignedRadioBtn.Size = new System.Drawing.Size(115, 29);
            this.unassignedRadioBtn.TabIndex = 11;
            this.unassignedRadioBtn.TabStop = true;
            this.unassignedRadioBtn.Text = "Unassigned";
            this.unassignedRadioBtn.UseVisualStyleBackColor = false;
            this.unassignedRadioBtn.CheckedChanged += new System.EventHandler(this.unassignedRadioBtn_CheckedChanged);
            // 
            // assignedRadioBtn
            // 
            this.assignedRadioBtn.BackColor = System.Drawing.Color.SlateGray;
            this.assignedRadioBtn.Font = new System.Drawing.Font("Adobe Fan Heiti Std B", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.assignedRadioBtn.Location = new System.Drawing.Point(1029, 179);
            this.assignedRadioBtn.Name = "assignedRadioBtn";
            this.assignedRadioBtn.Size = new System.Drawing.Size(115, 28);
            this.assignedRadioBtn.TabIndex = 10;
            this.assignedRadioBtn.TabStop = true;
            this.assignedRadioBtn.Text = "Assigned";
            this.assignedRadioBtn.UseVisualStyleBackColor = false;
            this.assignedRadioBtn.CheckedChanged += new System.EventHandler(this.assignedRadioBtn_CheckedChanged);
            // 
            // allRadioBtn
            // 
            this.allRadioBtn.BackColor = System.Drawing.Color.SlateGray;
            this.allRadioBtn.Checked = true;
            this.allRadioBtn.Font = new System.Drawing.Font("Adobe Fan Heiti Std B", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.allRadioBtn.Location = new System.Drawing.Point(1029, 145);
            this.allRadioBtn.Name = "allRadioBtn";
            this.allRadioBtn.Size = new System.Drawing.Size(115, 28);
            this.allRadioBtn.TabIndex = 9;
            this.allRadioBtn.TabStop = true;
            this.allRadioBtn.Text = "All";
            this.allRadioBtn.UseVisualStyleBackColor = false;
            this.allRadioBtn.CheckedChanged += new System.EventHandler(this.allRadioBtn_CheckedChanged);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Adobe Fan Heiti Std B", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(1029, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 50);
            this.label1.TabIndex = 8;
            this.label1.Text = "Order selection:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // allInfoBtn
            // 
            this.allInfoBtn.Location = new System.Drawing.Point(1029, 413);
            this.allInfoBtn.Name = "allInfoBtn";
            this.allInfoBtn.Size = new System.Drawing.Size(115, 39);
            this.allInfoBtn.TabIndex = 7;
            this.allInfoBtn.Text = "All info";
            this.allInfoBtn.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(974, 6);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(49, 45);
            this.button5.TabIndex = 6;
            this.button5.Text = "search";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // editBtn
            // 
            this.editBtn.Location = new System.Drawing.Point(1029, 458);
            this.editBtn.Name = "editBtn";
            this.editBtn.Size = new System.Drawing.Size(115, 47);
            this.editBtn.TabIndex = 5;
            this.editBtn.Text = "Edit";
            this.editBtn.UseVisualStyleBackColor = true;
            // 
            // deleteBtn
            // 
            this.deleteBtn.Location = new System.Drawing.Point(1029, 511);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(115, 47);
            this.deleteBtn.TabIndex = 3;
            this.deleteBtn.Text = "Delete";
            this.deleteBtn.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(0, 6);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(968, 45);
            this.textBox1.TabIndex = 1;
            // 
            // refreshBtn
            // 
            this.refreshBtn.Location = new System.Drawing.Point(1029, 6);
            this.refreshBtn.Name = "refreshBtn";
            this.refreshBtn.Size = new System.Drawing.Size(109, 45);
            this.refreshBtn.TabIndex = 2;
            this.refreshBtn.Text = "Refresh";
            this.refreshBtn.UseVisualStyleBackColor = true;
            this.refreshBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // listView1
            // 
            this.listView1.AllowColumnReorder = true;
            this.listView1.BackColor = System.Drawing.SystemColors.Window;
            this.listView1.CheckBoxes = true;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.orderID,
            this.created,
            this.pickUpAdd,
            this.pickUpDead,
            this.dropOffAdd,
            this.dropOffDead,
            this.description,
            this.weight,
            this.Size,
            this.price,
            this.status});
            this.listView1.Font = new System.Drawing.Font("Adobe Fan Heiti Std B", 12F, System.Drawing.FontStyle.Bold);
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(0, 57);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1023, 507);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // orderID
            // 
            this.orderID.Text = "   Order ID";
            this.orderID.Width = 86;
            // 
            // created
            // 
            this.created.Text = "Created By";
            this.created.Width = 93;
            // 
            // pickUpAdd
            // 
            this.pickUpAdd.Text = "Pick up address";
            this.pickUpAdd.Width = 127;
            // 
            // pickUpDead
            // 
            this.pickUpDead.Text = "Pick Up Deadline";
            this.pickUpDead.Width = 136;
            // 
            // dropOffAdd
            // 
            this.dropOffAdd.Text = "Drop off address";
            this.dropOffAdd.Width = 133;
            // 
            // dropOffDead
            // 
            this.dropOffDead.Text = "Drop off deadline";
            this.dropOffDead.Width = 140;
            // 
            // description
            // 
            this.description.Text = "Description";
            this.description.Width = 96;
            // 
            // weight
            // 
            this.weight.Text = "Weight";
            this.weight.Width = 66;
            // 
            // Size
            // 
            this.Size.Text = "Size";
            this.Size.Width = 41;
            // 
            // price
            // 
            this.price.Text = "Price";
            this.price.Width = 48;
            // 
            // status
            // 
            this.status.Text = "Status";
            this.status.Width = 91;
            // 
            // clientTab
            // 
            this.clientTab.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.clientTab.Location = new System.Drawing.Point(4, 22);
            this.clientTab.Name = "clientTab";
            this.clientTab.Padding = new System.Windows.Forms.Padding(3);
            this.clientTab.Size = new System.Drawing.Size(1150, 579);
            this.clientTab.TabIndex = 1;
            this.clientTab.Text = "Clients";
            this.clientTab.UseVisualStyleBackColor = true;
            // 
            // orderNumber
            // 
            this.orderNumber.Text = "Order Number";
            // 
            // createdBy
            // 
            this.createdBy.Text = "Created by";
            // 
            // pickUpAddress
            // 
            this.pickUpAddress.Text = "Pick up address";
            // 
            // form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(91)))), ((int)(((byte)(119)))));
            this.ClientSize = new System.Drawing.Size(1160, 603);
            this.Controls.Add(this.allOrdersList);
            this.Name = "form1";
            this.Text = "3TL Administrator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.allOrdersList.ResumeLayout(false);
            this.allOrders.ResumeLayout(false);
            this.allOrders.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl allOrdersList;
        private TabPage allOrders;
        private ListView listView1;
        private ColumnHeader orderNumber;
        private ColumnHeader createdBy;
        private ColumnHeader pickUpAddress;
        private TextBox textBox1;
        private ColumnHeader orderID;
        private ColumnHeader created;
        private ColumnHeader pickUpAdd;
        private ColumnHeader pickUpDead;
        private ColumnHeader dropOffAdd;
        private ColumnHeader dropOffDead;
        private ColumnHeader description;
        private ColumnHeader weight;
        private ColumnHeader Size;
        private ColumnHeader price;
        private ColumnHeader status;
        private Button refreshBtn;
        private Button button5;
        private Button editBtn;
        private Button deleteBtn;
        private Button allInfoBtn;
        private TabPage clientTab;
        private Label label1;
        private RadioButton allRadioBtn;
        private RadioButton unassignedRadioBtn;
        private RadioButton assignedRadioBtn;
    }
}


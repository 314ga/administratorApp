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
            this.allClientView = new System.Windows.Forms.TabControl();
            this.allOrders = new System.Windows.Forms.TabPage();
            this.RefreshButton = new System.Windows.Forms.Button();
            this.CustomerFilter = new System.Windows.Forms.RadioButton();
            this.DeadlineFIlter = new System.Windows.Forms.RadioButton();
            this.StatusFilter = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.unassignedRadioBtn = new System.Windows.Forms.RadioButton();
            this.assignedRadioBtn = new System.Windows.Forms.RadioButton();
            this.allRadioBtn = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.allInfoBtn = new System.Windows.Forms.Button();
            this.editBtn = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.orderID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.created = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pickUpAdd = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pickUpDead = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dropOffAdd = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dropOffDead = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.status = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clientTab = new System.Windows.Forms.TabPage();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.SearchButton = new System.Windows.Forms.Button();
            this.ContractorButton = new System.Windows.Forms.RadioButton();
            this.CustomerButton = new System.Windows.Forms.RadioButton();
            this.AllClients = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.AddClient = new System.Windows.Forms.Button();
            this.EditClient = new System.Windows.Forms.Button();
            this.DeleteClient = new System.Windows.Forms.Button();
            this.listView2 = new System.Windows.Forms.ListView();
            this.CustomerID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Column2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Address = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PhoneNumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Email = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.orderNumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.createdBy = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pickUpAddress = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.allClientView.SuspendLayout();
            this.allOrders.SuspendLayout();
            this.clientTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // allClientView
            // 
            this.allClientView.Controls.Add(this.allOrders);
            this.allClientView.Controls.Add(this.clientTab);
            this.allClientView.ItemSize = new System.Drawing.Size(100, 28);
            this.allClientView.Location = new System.Drawing.Point(1, 1);
            this.allClientView.Margin = new System.Windows.Forms.Padding(4);
            this.allClientView.Name = "allClientView";
            this.allClientView.Padding = new System.Drawing.Point(16, 5);
            this.allClientView.SelectedIndex = 0;
            this.allClientView.Size = new System.Drawing.Size(1544, 745);
            this.allClientView.TabIndex = 0;
            this.allClientView.Enter += new System.EventHandler(this.allClientView_Enter);
            // 
            // allOrders
            // 
            this.allOrders.AccessibleRole = System.Windows.Forms.AccessibleRole.Cursor;
            this.allOrders.BackColor = System.Drawing.Color.Blue;
            this.allOrders.Controls.Add(this.RefreshButton);
            this.allOrders.Controls.Add(this.CustomerFilter);
            this.allOrders.Controls.Add(this.DeadlineFIlter);
            this.allOrders.Controls.Add(this.StatusFilter);
            this.allOrders.Controls.Add(this.label2);
            this.allOrders.Controls.Add(this.unassignedRadioBtn);
            this.allOrders.Controls.Add(this.assignedRadioBtn);
            this.allOrders.Controls.Add(this.allRadioBtn);
            this.allOrders.Controls.Add(this.label1);
            this.allOrders.Controls.Add(this.allInfoBtn);
            this.allOrders.Controls.Add(this.editBtn);
            this.allOrders.Controls.Add(this.deleteBtn);
            this.allOrders.Controls.Add(this.textBox1);
            this.allOrders.Controls.Add(this.listView1);
            this.allOrders.Font = new System.Drawing.Font("Adobe Fan Heiti Std B", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.allOrders.ForeColor = System.Drawing.Color.White;
            this.allOrders.Location = new System.Drawing.Point(4, 32);
            this.allOrders.Margin = new System.Windows.Forms.Padding(4);
            this.allOrders.Name = "allOrders";
            this.allOrders.Padding = new System.Windows.Forms.Padding(4);
            this.allOrders.Size = new System.Drawing.Size(1536, 709);
            this.allOrders.TabIndex = 0;
            this.allOrders.Text = "Orders";
            this.allOrders.UseVisualStyleBackColor = true;
            // 
            // RefreshButton
            // 
            this.RefreshButton.BackColor = System.Drawing.Color.GreenYellow;
            this.RefreshButton.Location = new System.Drawing.Point(1337, 7);
            this.RefreshButton.Margin = new System.Windows.Forms.Padding(4);
            this.RefreshButton.Name = "RefreshButton";
            this.RefreshButton.Size = new System.Drawing.Size(182, 59);
            this.RefreshButton.TabIndex = 16;
            this.RefreshButton.Text = "Refresh";
            this.RefreshButton.UseVisualStyleBackColor = false;
            // 
            // CustomerFilter
            // 
            this.CustomerFilter.BackColor = System.Drawing.Color.SlateGray;
            this.CustomerFilter.Font = new System.Drawing.Font("Adobe Fan Heiti Std B", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.CustomerFilter.Location = new System.Drawing.Point(1355, 415);
            this.CustomerFilter.Margin = new System.Windows.Forms.Padding(4);
            this.CustomerFilter.Name = "CustomerFilter";
            this.CustomerFilter.Size = new System.Drawing.Size(153, 36);
            this.CustomerFilter.TabIndex = 15;
            this.CustomerFilter.TabStop = true;
            this.CustomerFilter.Text = "Customer";
            this.CustomerFilter.UseVisualStyleBackColor = false;
            this.CustomerFilter.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // DeadlineFIlter
            // 
            this.DeadlineFIlter.BackColor = System.Drawing.Color.SlateGray;
            this.DeadlineFIlter.Font = new System.Drawing.Font("Adobe Fan Heiti Std B", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.DeadlineFIlter.Location = new System.Drawing.Point(1355, 373);
            this.DeadlineFIlter.Margin = new System.Windows.Forms.Padding(4);
            this.DeadlineFIlter.Name = "DeadlineFIlter";
            this.DeadlineFIlter.Size = new System.Drawing.Size(153, 34);
            this.DeadlineFIlter.TabIndex = 14;
            this.DeadlineFIlter.TabStop = true;
            this.DeadlineFIlter.Text = "Deadline";
            this.DeadlineFIlter.UseVisualStyleBackColor = false;
            this.DeadlineFIlter.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // StatusFilter
            // 
            this.StatusFilter.BackColor = System.Drawing.Color.SlateGray;
            this.StatusFilter.Checked = true;
            this.StatusFilter.Font = new System.Drawing.Font("Adobe Fan Heiti Std B", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.StatusFilter.Location = new System.Drawing.Point(1355, 331);
            this.StatusFilter.Margin = new System.Windows.Forms.Padding(4);
            this.StatusFilter.Name = "StatusFilter";
            this.StatusFilter.Size = new System.Drawing.Size(153, 34);
            this.StatusFilter.TabIndex = 13;
            this.StatusFilter.TabStop = true;
            this.StatusFilter.Text = "Status";
            this.StatusFilter.UseVisualStyleBackColor = false;
            this.StatusFilter.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Adobe Fan Heiti Std B", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(1356, 281);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 62);
            this.label2.TabIndex = 12;
            this.label2.Text = "Order by";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // unassignedRadioBtn
            // 
            this.unassignedRadioBtn.BackColor = System.Drawing.Color.SlateGray;
            this.unassignedRadioBtn.Font = new System.Drawing.Font("Adobe Fan Heiti Std B", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.unassignedRadioBtn.Location = new System.Drawing.Point(1356, 234);
            this.unassignedRadioBtn.Margin = new System.Windows.Forms.Padding(4);
            this.unassignedRadioBtn.Name = "unassignedRadioBtn";
            this.unassignedRadioBtn.Size = new System.Drawing.Size(153, 36);
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
            this.assignedRadioBtn.Location = new System.Drawing.Point(1356, 192);
            this.assignedRadioBtn.Margin = new System.Windows.Forms.Padding(4);
            this.assignedRadioBtn.Name = "assignedRadioBtn";
            this.assignedRadioBtn.Size = new System.Drawing.Size(153, 34);
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
            this.allRadioBtn.Location = new System.Drawing.Point(1356, 150);
            this.allRadioBtn.Margin = new System.Windows.Forms.Padding(4);
            this.allRadioBtn.Name = "allRadioBtn";
            this.allRadioBtn.Size = new System.Drawing.Size(153, 34);
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
            this.label1.Location = new System.Drawing.Point(1356, 100);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 62);
            this.label1.TabIndex = 8;
            this.label1.Text = "Order type";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // allInfoBtn
            // 
            this.allInfoBtn.BackColor = System.Drawing.Color.Orange;
            this.allInfoBtn.ForeColor = System.Drawing.Color.Transparent;
            this.allInfoBtn.Location = new System.Drawing.Point(1355, 503);
            this.allInfoBtn.Margin = new System.Windows.Forms.Padding(4);
            this.allInfoBtn.Name = "allInfoBtn";
            this.allInfoBtn.Size = new System.Drawing.Size(153, 40);
            this.allInfoBtn.TabIndex = 7;
            this.allInfoBtn.Text = "All info";
            this.allInfoBtn.UseVisualStyleBackColor = false;
            // 
            // editBtn
            // 
            this.editBtn.BackColor = System.Drawing.Color.Orange;
            this.editBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.editBtn.Location = new System.Drawing.Point(1355, 551);
            this.editBtn.Margin = new System.Windows.Forms.Padding(4);
            this.editBtn.Name = "editBtn";
            this.editBtn.Size = new System.Drawing.Size(153, 40);
            this.editBtn.TabIndex = 5;
            this.editBtn.Text = "Edit";
            this.editBtn.UseVisualStyleBackColor = false;
            // 
            // deleteBtn
            // 
            this.deleteBtn.BackColor = System.Drawing.Color.Orange;
            this.deleteBtn.Location = new System.Drawing.Point(1356, 599);
            this.deleteBtn.Margin = new System.Windows.Forms.Padding(4);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(153, 38);
            this.deleteBtn.TabIndex = 3;
            this.deleteBtn.Text = "Delete";
            this.deleteBtn.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(26, 7);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(1289, 54);
            this.textBox1.TabIndex = 1;
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
            this.status});
            this.listView1.Font = new System.Drawing.Font("Adobe Fan Heiti Std B", 12F, System.Drawing.FontStyle.Bold);
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(26, 84);
            this.listView1.Margin = new System.Windows.Forms.Padding(4);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1289, 603);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            this.listView1.DoubleClick += new System.EventHandler(this.listView1_DoubleClick);
            // 
            // orderID
            // 
            this.orderID.Text = "   Order ID";
            this.orderID.Width = 103;
            // 
            // created
            // 
            this.created.Text = "Customer";
            this.created.Width = 140;
            // 
            // pickUpAdd
            // 
            this.pickUpAdd.Text = "Pick up address";
            this.pickUpAdd.Width = 242;
            // 
            // pickUpDead
            // 
            this.pickUpDead.Text = "Pick Up Deadline";
            this.pickUpDead.Width = 172;
            // 
            // dropOffAdd
            // 
            this.dropOffAdd.Text = "Drop off address";
            this.dropOffAdd.Width = 286;
            // 
            // dropOffDead
            // 
            this.dropOffDead.Text = "Drop off deadline";
            this.dropOffDead.Width = 223;
            // 
            // status
            // 
            this.status.Text = "Status";
            this.status.Width = 131;
            // 
            // clientTab
            // 
            this.clientTab.Controls.Add(this.textBox2);
            this.clientTab.Controls.Add(this.SearchButton);
            this.clientTab.Controls.Add(this.ContractorButton);
            this.clientTab.Controls.Add(this.CustomerButton);
            this.clientTab.Controls.Add(this.AllClients);
            this.clientTab.Controls.Add(this.label3);
            this.clientTab.Controls.Add(this.AddClient);
            this.clientTab.Controls.Add(this.EditClient);
            this.clientTab.Controls.Add(this.DeleteClient);
            this.clientTab.Controls.Add(this.listView2);
            this.clientTab.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.clientTab.Location = new System.Drawing.Point(4, 32);
            this.clientTab.Margin = new System.Windows.Forms.Padding(4);
            this.clientTab.Name = "clientTab";
            this.clientTab.Padding = new System.Windows.Forms.Padding(4);
            this.clientTab.Size = new System.Drawing.Size(1536, 709);
            this.clientTab.TabIndex = 1;
            this.clientTab.Text = "Clients";
            this.clientTab.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(37, 41);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(1289, 31);
            this.textBox2.TabIndex = 25;
            // 
            // SearchButton
            // 
            this.SearchButton.BackColor = System.Drawing.Color.PaleGreen;
            this.SearchButton.Location = new System.Drawing.Point(1334, 34);
            this.SearchButton.Margin = new System.Windows.Forms.Padding(4);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(148, 45);
            this.SearchButton.TabIndex = 24;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = false;
            this.SearchButton.Click += new System.EventHandler(this.button4_Click);
            // 
            // ContractorButton
            // 
            this.ContractorButton.BackColor = System.Drawing.Color.SlateGray;
            this.ContractorButton.Font = new System.Drawing.Font("Adobe Fan Heiti Std B", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.ContractorButton.Location = new System.Drawing.Point(1329, 293);
            this.ContractorButton.Margin = new System.Windows.Forms.Padding(4);
            this.ContractorButton.Name = "ContractorButton";
            this.ContractorButton.Size = new System.Drawing.Size(153, 51);
            this.ContractorButton.TabIndex = 23;
            this.ContractorButton.TabStop = true;
            this.ContractorButton.Text = "Contractors";
            this.ContractorButton.UseVisualStyleBackColor = false;
            this.ContractorButton.CheckedChanged += new System.EventHandler(this.ContractorButton_CheckedChanged);
            // 
            // CustomerButton
            // 
            this.CustomerButton.BackColor = System.Drawing.Color.SlateGray;
            this.CustomerButton.Font = new System.Drawing.Font("Adobe Fan Heiti Std B", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.CustomerButton.Location = new System.Drawing.Point(1329, 234);
            this.CustomerButton.Margin = new System.Windows.Forms.Padding(4);
            this.CustomerButton.Name = "CustomerButton";
            this.CustomerButton.Size = new System.Drawing.Size(153, 51);
            this.CustomerButton.TabIndex = 22;
            this.CustomerButton.TabStop = true;
            this.CustomerButton.Text = "Customers";
            this.CustomerButton.UseVisualStyleBackColor = false;
            this.CustomerButton.CheckedChanged += new System.EventHandler(this.CustomerButton_CheckedChanged);
            // 
            // AllClients
            // 
            this.AllClients.BackColor = System.Drawing.Color.SlateGray;
            this.AllClients.Checked = true;
            this.AllClients.Font = new System.Drawing.Font("Adobe Fan Heiti Std B", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.AllClients.Location = new System.Drawing.Point(1329, 175);
            this.AllClients.Margin = new System.Windows.Forms.Padding(4);
            this.AllClients.Name = "AllClients";
            this.AllClients.Size = new System.Drawing.Size(153, 51);
            this.AllClients.TabIndex = 21;
            this.AllClients.TabStop = true;
            this.AllClients.Text = "All";
            this.AllClients.UseVisualStyleBackColor = false;
            this.AllClients.CheckedChanged += new System.EventHandler(this.AllClients_CheckedChanged);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Adobe Fan Heiti Std B", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(1329, 109);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(153, 62);
            this.label3.TabIndex = 20;
            this.label3.Text = "Choose type";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AddClient
            // 
            this.AddClient.BackColor = System.Drawing.Color.Orange;
            this.AddClient.ForeColor = System.Drawing.Color.Transparent;
            this.AddClient.Location = new System.Drawing.Point(1329, 432);
            this.AddClient.Margin = new System.Windows.Forms.Padding(4);
            this.AddClient.Name = "AddClient";
            this.AddClient.Size = new System.Drawing.Size(153, 56);
            this.AddClient.TabIndex = 18;
            this.AddClient.Text = "Add client";
            this.AddClient.UseVisualStyleBackColor = false;
            this.AddClient.Click += new System.EventHandler(this.AddClient_Click);
            // 
            // EditClient
            // 
            this.EditClient.BackColor = System.Drawing.Color.Orange;
            this.EditClient.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EditClient.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.EditClient.Location = new System.Drawing.Point(1329, 496);
            this.EditClient.Margin = new System.Windows.Forms.Padding(4);
            this.EditClient.Name = "EditClient";
            this.EditClient.Size = new System.Drawing.Size(153, 46);
            this.EditClient.TabIndex = 17;
            this.EditClient.Text = "Edit client";
            this.EditClient.UseVisualStyleBackColor = false;
            // 
            // DeleteClient
            // 
            this.DeleteClient.BackColor = System.Drawing.Color.Orange;
            this.DeleteClient.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DeleteClient.Location = new System.Drawing.Point(1329, 549);
            this.DeleteClient.Margin = new System.Windows.Forms.Padding(4);
            this.DeleteClient.Name = "DeleteClient";
            this.DeleteClient.Size = new System.Drawing.Size(153, 51);
            this.DeleteClient.TabIndex = 16;
            this.DeleteClient.Text = "Delete client";
            this.DeleteClient.UseVisualStyleBackColor = false;
            // 
            // listView2
            // 
            this.listView2.BackColor = System.Drawing.SystemColors.Window;
            this.listView2.BackgroundImageTiled = true;
            this.listView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.CustomerID,
            this.Column2,
            this.Address,
            this.PhoneNumber,
            this.Email});
            this.listView2.GridLines = true;
            this.listView2.Location = new System.Drawing.Point(93, 88);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(1190, 595);
            this.listView2.TabIndex = 0;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.View = System.Windows.Forms.View.Details;
            // 
            // CustomerID
            // 
            this.CustomerID.Text = "CustomerID";
            this.CustomerID.Width = 134;
            // 
            // Column2
            // 
            this.Column2.Text = "Company name";
            this.Column2.Width = 154;
            // 
            // Address
            // 
            this.Address.Text = "Address";
            this.Address.Width = 351;
            // 
            // PhoneNumber
            // 
            this.PhoneNumber.Text = "PhoneNumber";
            this.PhoneNumber.Width = 291;
            // 
            // Email
            // 
            this.Email.Text = "Email";
            this.Email.Width = 379;
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
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(91)))), ((int)(((byte)(119)))));
            this.ClientSize = new System.Drawing.Size(1547, 742);
            this.Controls.Add(this.allClientView);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "form1";
            this.Text = "3TL Administrator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.allClientView.ResumeLayout(false);
            this.allOrders.ResumeLayout(false);
            this.allOrders.PerformLayout();
            this.clientTab.ResumeLayout(false);
            this.clientTab.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl allClientView;
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
        private ColumnHeader status;
        private Button editBtn;
        private Button deleteBtn;
        private Button allInfoBtn;
        private TabPage clientTab;
        private Label label1;
        private RadioButton allRadioBtn;
        private RadioButton unassignedRadioBtn;
        private RadioButton assignedRadioBtn;
        private RadioButton CustomerFilter;
        private RadioButton DeadlineFIlter;
        private RadioButton StatusFilter;
        private Label label2;
        private Button RefreshButton;
        private ListView listView2;
        private ColumnHeader CustomerID;
        private ColumnHeader Column2;
        private ColumnHeader Address;
        private ColumnHeader PhoneNumber;
        private ColumnHeader Email;
        private Button AddClient;
        private Button EditClient;
        private Button DeleteClient;
        private Button SearchButton;
        private RadioButton ContractorButton;
        private RadioButton CustomerButton;
        private RadioButton AllClients;
        private Label label3;
        private TextBox textBox2;
    }
}


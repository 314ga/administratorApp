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
            this.NavBar = new System.Windows.Forms.TabControl();
            this.allOrders = new System.Windows.Forms.TabPage();
            this.CustomerFilter = new System.Windows.Forms.RadioButton();
            this.StatusFilter = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.allRadioBtn = new System.Windows.Forms.RadioButton();
            this.assignedRadioBtn = new System.Windows.Forms.RadioButton();
            this.unassignedRadioBtn = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.DeadlineFIlter = new System.Windows.Forms.RadioButton();
            this.RefreshButton = new System.Windows.Forms.Button();
            this.allInfoBtn = new System.Windows.Forms.Button();
            this.editBtn = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.orderListView = new System.Windows.Forms.ListView();
            this.orderID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.created = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pickUpAdd = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pickUpDead = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dropOffAdd = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dropOffDead = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.status = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clientTab = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.clientInfo = new System.Windows.Forms.Button();
            this.SearchButton = new System.Windows.Forms.Button();
            this.ContractorButton = new System.Windows.Forms.RadioButton();
            this.CustomerButton = new System.Windows.Forms.RadioButton();
            this.AllClients = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.AddClient = new System.Windows.Forms.Button();
            this.EditClient = new System.Windows.Forms.Button();
            this.DeleteClient = new System.Windows.Forms.Button();
            this.clientListView = new System.Windows.Forms.ListView();
            this.CustomerID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Column2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Address = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PhoneNumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Email = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clietType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.orderNumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.createdBy = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pickUpAddress = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label2 = new System.Windows.Forms.Label();
            this.NavBar.SuspendLayout();
            this.allOrders.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.clientTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // NavBar
            // 
            this.NavBar.Controls.Add(this.allOrders);
            this.NavBar.Controls.Add(this.clientTab);
            this.NavBar.ItemSize = new System.Drawing.Size(100, 28);
            this.NavBar.Location = new System.Drawing.Point(1, 1);
            this.NavBar.Name = "NavBar";
            this.NavBar.Padding = new System.Drawing.Point(16, 5);
            this.NavBar.SelectedIndex = 0;
            this.NavBar.Size = new System.Drawing.Size(1158, 605);
            this.NavBar.TabIndex = 0;
            // 
            // allOrders
            // 
            this.allOrders.AccessibleRole = System.Windows.Forms.AccessibleRole.Cursor;
            this.allOrders.BackColor = System.Drawing.Color.Blue;
            this.allOrders.Controls.Add(this.groupBox1);
            this.allOrders.Controls.Add(this.label5);
            this.allOrders.Controls.Add(this.RefreshButton);
            this.allOrders.Controls.Add(this.allInfoBtn);
            this.allOrders.Controls.Add(this.editBtn);
            this.allOrders.Controls.Add(this.deleteBtn);
            this.allOrders.Controls.Add(this.orderListView);
            this.allOrders.Font = new System.Drawing.Font("Adobe Fan Heiti Std B", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.allOrders.ForeColor = System.Drawing.Color.White;
            this.allOrders.Location = new System.Drawing.Point(4, 32);
            this.allOrders.Name = "allOrders";
            this.allOrders.Padding = new System.Windows.Forms.Padding(3);
            this.allOrders.Size = new System.Drawing.Size(1150, 569);
            this.allOrders.TabIndex = 0;
            this.allOrders.Text = "Orders";
            this.allOrders.UseVisualStyleBackColor = true;
            this.allOrders.Enter += new System.EventHandler(this.allOrders_Enter);
            // 
            // CustomerFilter
            // 
            this.CustomerFilter.BackColor = System.Drawing.Color.SlateGray;
            this.CustomerFilter.Checked = true;
            this.CustomerFilter.Font = new System.Drawing.Font("Adobe Fan Heiti Std B", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.CustomerFilter.Location = new System.Drawing.Point(25, 186);
            this.CustomerFilter.Name = "CustomerFilter";
            this.CustomerFilter.Size = new System.Drawing.Size(115, 29);
            this.CustomerFilter.TabIndex = 15;
            this.CustomerFilter.TabStop = true;
            this.CustomerFilter.Text = "Customer";
            this.CustomerFilter.UseVisualStyleBackColor = false;
            this.CustomerFilter.CheckedChanged += new System.EventHandler(this.CustomerFilter_CheckedChanged);
            // 
            // StatusFilter
            // 
            this.StatusFilter.BackColor = System.Drawing.Color.SlateGray;
            this.StatusFilter.Font = new System.Drawing.Font("Adobe Fan Heiti Std B", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.StatusFilter.Location = new System.Drawing.Point(26, 255);
            this.StatusFilter.Name = "StatusFilter";
            this.StatusFilter.Size = new System.Drawing.Size(115, 28);
            this.StatusFilter.TabIndex = 13;
            this.StatusFilter.Text = "Status";
            this.StatusFilter.UseVisualStyleBackColor = false;
            this.StatusFilter.CheckedChanged += new System.EventHandler(this.StatusFilter_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Controls.Add(this.CustomerFilter);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.allRadioBtn);
            this.groupBox1.Controls.Add(this.StatusFilter);
            this.groupBox1.Controls.Add(this.assignedRadioBtn);
            this.groupBox1.Controls.Add(this.unassignedRadioBtn);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.DeadlineFIlter);
            this.groupBox1.Location = new System.Drawing.Point(990, 109);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(160, 298);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            // 
            // allRadioBtn
            // 
            this.allRadioBtn.BackColor = System.Drawing.Color.SlateGray;
            this.allRadioBtn.Checked = true;
            this.allRadioBtn.Font = new System.Drawing.Font("Adobe Fan Heiti Std B", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.allRadioBtn.Location = new System.Drawing.Point(23, 29);
            this.allRadioBtn.Name = "allRadioBtn";
            this.allRadioBtn.Size = new System.Drawing.Size(115, 28);
            this.allRadioBtn.TabIndex = 9;
            this.allRadioBtn.TabStop = true;
            this.allRadioBtn.Text = "All";
            this.allRadioBtn.UseVisualStyleBackColor = false;
            this.allRadioBtn.CheckedChanged += new System.EventHandler(this.allRadioBtn_CheckedChanged);
            // 
            // assignedRadioBtn
            // 
            this.assignedRadioBtn.BackColor = System.Drawing.Color.SlateGray;
            this.assignedRadioBtn.Font = new System.Drawing.Font("Adobe Fan Heiti Std B", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.assignedRadioBtn.Location = new System.Drawing.Point(23, 63);
            this.assignedRadioBtn.Name = "assignedRadioBtn";
            this.assignedRadioBtn.Size = new System.Drawing.Size(115, 28);
            this.assignedRadioBtn.TabIndex = 10;
            this.assignedRadioBtn.TabStop = true;
            this.assignedRadioBtn.Text = "Assigned";
            this.assignedRadioBtn.UseVisualStyleBackColor = false;
            this.assignedRadioBtn.CheckedChanged += new System.EventHandler(this.assignedRadioBtn_CheckedChanged);
            // 
            // unassignedRadioBtn
            // 
            this.unassignedRadioBtn.BackColor = System.Drawing.Color.SlateGray;
            this.unassignedRadioBtn.Font = new System.Drawing.Font("Adobe Fan Heiti Std B", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.unassignedRadioBtn.Location = new System.Drawing.Point(23, 97);
            this.unassignedRadioBtn.Name = "unassignedRadioBtn";
            this.unassignedRadioBtn.Size = new System.Drawing.Size(115, 29);
            this.unassignedRadioBtn.TabIndex = 11;
            this.unassignedRadioBtn.TabStop = true;
            this.unassignedRadioBtn.Text = "Unassigned";
            this.unassignedRadioBtn.UseVisualStyleBackColor = false;
            this.unassignedRadioBtn.CheckedChanged += new System.EventHandler(this.unassignedRadioBtn_CheckedChanged);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Adobe Fan Heiti Std B", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(23, -10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 50);
            this.label1.TabIndex = 8;
            this.label1.Text = "Order type";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Adobe Fan Heiti Std B", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(994, 410);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(156, 30);
            this.label5.TabIndex = 17;
            this.label5.Text = "Manage order ";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DeadlineFIlter
            // 
            this.DeadlineFIlter.BackColor = System.Drawing.Color.SlateGray;
            this.DeadlineFIlter.Font = new System.Drawing.Font("Adobe Fan Heiti Std B", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.DeadlineFIlter.Location = new System.Drawing.Point(26, 221);
            this.DeadlineFIlter.Name = "DeadlineFIlter";
            this.DeadlineFIlter.Size = new System.Drawing.Size(115, 28);
            this.DeadlineFIlter.TabIndex = 14;
            this.DeadlineFIlter.Text = "Deadline";
            this.DeadlineFIlter.UseVisualStyleBackColor = false;
            this.DeadlineFIlter.CheckedChanged += new System.EventHandler(this.DeadlineFIlter_CheckedChanged);
            // 
            // RefreshButton
            // 
            this.RefreshButton.BackColor = System.Drawing.Color.GreenYellow;
            this.RefreshButton.Location = new System.Drawing.Point(1003, 6);
            this.RefreshButton.Name = "RefreshButton";
            this.RefreshButton.Size = new System.Drawing.Size(136, 48);
            this.RefreshButton.TabIndex = 16;
            this.RefreshButton.Text = "Refresh";
            this.RefreshButton.UseVisualStyleBackColor = false;
            this.RefreshButton.Click += new System.EventHandler(this.RefreshButton_Click);
            // 
            // allInfoBtn
            // 
            this.allInfoBtn.BackColor = System.Drawing.Color.Orange;
            this.allInfoBtn.ForeColor = System.Drawing.Color.Transparent;
            this.allInfoBtn.Location = new System.Drawing.Point(1016, 442);
            this.allInfoBtn.Name = "allInfoBtn";
            this.allInfoBtn.Size = new System.Drawing.Size(115, 32);
            this.allInfoBtn.TabIndex = 7;
            this.allInfoBtn.Text = "All info";
            this.allInfoBtn.UseVisualStyleBackColor = false;
            this.allInfoBtn.Click += new System.EventHandler(this.allInfoBtn_Click);
            // 
            // editBtn
            // 
            this.editBtn.BackColor = System.Drawing.Color.Orange;
            this.editBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.editBtn.Location = new System.Drawing.Point(1016, 481);
            this.editBtn.Name = "editBtn";
            this.editBtn.Size = new System.Drawing.Size(115, 32);
            this.editBtn.TabIndex = 5;
            this.editBtn.Text = "Edit";
            this.editBtn.UseVisualStyleBackColor = false;
            this.editBtn.Click += new System.EventHandler(this.editBtn_Click);
            // 
            // deleteBtn
            // 
            this.deleteBtn.BackColor = System.Drawing.Color.Orange;
            this.deleteBtn.Location = new System.Drawing.Point(1017, 520);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(115, 31);
            this.deleteBtn.TabIndex = 3;
            this.deleteBtn.Text = "Delete";
            this.deleteBtn.UseVisualStyleBackColor = false;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // orderListView
            // 
            this.orderListView.AllowColumnReorder = true;
            this.orderListView.BackColor = System.Drawing.SystemColors.Window;
            this.orderListView.CheckBoxes = true;
            this.orderListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.orderID,
            this.created,
            this.pickUpAdd,
            this.pickUpDead,
            this.dropOffAdd,
            this.dropOffDead,
            this.status});
            this.orderListView.Font = new System.Drawing.Font("Adobe Fan Heiti Std B", 12F, System.Drawing.FontStyle.Bold);
            this.orderListView.FullRowSelect = true;
            this.orderListView.GridLines = true;
            this.orderListView.Location = new System.Drawing.Point(7, 6);
            this.orderListView.Name = "orderListView";
            this.orderListView.Size = new System.Drawing.Size(981, 553);
            this.orderListView.TabIndex = 0;
            this.orderListView.UseCompatibleStateImageBehavior = false;
            this.orderListView.View = System.Windows.Forms.View.Details;
            // 
            // orderID
            // 
            this.orderID.Text = "   Order ID";
            this.orderID.Width = 86;
            // 
            // created
            // 
            this.created.Text = "Customer";
            this.created.Width = 83;
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
            // status
            // 
            this.status.Text = "Status";
            this.status.Width = 259;
            // 
            // clientTab
            // 
            this.clientTab.Controls.Add(this.label4);
            this.clientTab.Controls.Add(this.clientInfo);
            this.clientTab.Controls.Add(this.SearchButton);
            this.clientTab.Controls.Add(this.ContractorButton);
            this.clientTab.Controls.Add(this.CustomerButton);
            this.clientTab.Controls.Add(this.AllClients);
            this.clientTab.Controls.Add(this.label3);
            this.clientTab.Controls.Add(this.AddClient);
            this.clientTab.Controls.Add(this.EditClient);
            this.clientTab.Controls.Add(this.DeleteClient);
            this.clientTab.Controls.Add(this.clientListView);
            this.clientTab.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.clientTab.Location = new System.Drawing.Point(4, 32);
            this.clientTab.Name = "clientTab";
            this.clientTab.Padding = new System.Windows.Forms.Padding(3);
            this.clientTab.Size = new System.Drawing.Size(1150, 569);
            this.clientTab.TabIndex = 1;
            this.clientTab.Text = "Clients";
            this.clientTab.UseVisualStyleBackColor = true;
            this.clientTab.Enter += new System.EventHandler(this.clientTab_Enter);
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Adobe Fan Heiti Std B", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(997, 323);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 27);
            this.label4.TabIndex = 27;
            this.label4.Text = "Manage client";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // clientInfo
            // 
            this.clientInfo.BackColor = System.Drawing.Color.Orange;
            this.clientInfo.ForeColor = System.Drawing.Color.Transparent;
            this.clientInfo.Location = new System.Drawing.Point(997, 353);
            this.clientInfo.Name = "clientInfo";
            this.clientInfo.Size = new System.Drawing.Size(115, 46);
            this.clientInfo.TabIndex = 26;
            this.clientInfo.Text = "Client Info";
            this.clientInfo.UseVisualStyleBackColor = false;
            this.clientInfo.Click += new System.EventHandler(this.clientInfo_Click);
            // 
            // SearchButton
            // 
            this.SearchButton.BackColor = System.Drawing.Color.LawnGreen;
            this.SearchButton.Location = new System.Drawing.Point(997, 10);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(115, 45);
            this.SearchButton.TabIndex = 24;
            this.SearchButton.Text = "Refresh";
            this.SearchButton.UseVisualStyleBackColor = false;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // ContractorButton
            // 
            this.ContractorButton.BackColor = System.Drawing.Color.SlateGray;
            this.ContractorButton.Font = new System.Drawing.Font("Adobe Fan Heiti Std B", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.ContractorButton.Location = new System.Drawing.Point(997, 238);
            this.ContractorButton.Name = "ContractorButton";
            this.ContractorButton.Size = new System.Drawing.Size(115, 41);
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
            this.CustomerButton.Location = new System.Drawing.Point(997, 190);
            this.CustomerButton.Name = "CustomerButton";
            this.CustomerButton.Size = new System.Drawing.Size(115, 41);
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
            this.AllClients.Location = new System.Drawing.Point(997, 142);
            this.AllClients.Name = "AllClients";
            this.AllClients.Size = new System.Drawing.Size(115, 41);
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
            this.label3.Location = new System.Drawing.Point(997, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 28);
            this.label3.TabIndex = 20;
            this.label3.Text = "Choose type";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AddClient
            // 
            this.AddClient.BackColor = System.Drawing.Color.Orange;
            this.AddClient.ForeColor = System.Drawing.Color.Transparent;
            this.AddClient.Location = new System.Drawing.Point(997, 405);
            this.AddClient.Name = "AddClient";
            this.AddClient.Size = new System.Drawing.Size(115, 46);
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
            this.EditClient.Location = new System.Drawing.Point(997, 457);
            this.EditClient.Name = "EditClient";
            this.EditClient.Size = new System.Drawing.Size(115, 37);
            this.EditClient.TabIndex = 17;
            this.EditClient.Text = "Edit client";
            this.EditClient.UseVisualStyleBackColor = false;
            this.EditClient.Click += new System.EventHandler(this.EditClient_Click);
            // 
            // DeleteClient
            // 
            this.DeleteClient.BackColor = System.Drawing.Color.Orange;
            this.DeleteClient.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DeleteClient.Location = new System.Drawing.Point(997, 500);
            this.DeleteClient.Name = "DeleteClient";
            this.DeleteClient.Size = new System.Drawing.Size(115, 41);
            this.DeleteClient.TabIndex = 16;
            this.DeleteClient.Text = "Delete client";
            this.DeleteClient.UseVisualStyleBackColor = false;
            this.DeleteClient.Click += new System.EventHandler(this.DeleteClient_Click);
            // 
            // clientListView
            // 
            this.clientListView.BackColor = System.Drawing.SystemColors.Window;
            this.clientListView.BackgroundImageTiled = true;
            this.clientListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.CustomerID,
            this.Column2,
            this.Address,
            this.PhoneNumber,
            this.Email,
            this.clietType});
            this.clientListView.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.clientListView.FullRowSelect = true;
            this.clientListView.GridLines = true;
            this.clientListView.Location = new System.Drawing.Point(15, 10);
            this.clientListView.Margin = new System.Windows.Forms.Padding(2);
            this.clientListView.Name = "clientListView";
            this.clientListView.Size = new System.Drawing.Size(950, 531);
            this.clientListView.TabIndex = 0;
            this.clientListView.UseCompatibleStateImageBehavior = false;
            this.clientListView.View = System.Windows.Forms.View.Details;
            // 
            // CustomerID
            // 
            this.CustomerID.Text = "CustomerID";
            this.CustomerID.Width = 108;
            // 
            // Column2
            // 
            this.Column2.Text = "Company name";
            this.Column2.Width = 135;
            // 
            // Address
            // 
            this.Address.Text = "Address";
            this.Address.Width = 78;
            // 
            // PhoneNumber
            // 
            this.PhoneNumber.Text = "Phone number";
            this.PhoneNumber.Width = 125;
            // 
            // Email
            // 
            this.Email.Text = "Email";
            this.Email.Width = 56;
            // 
            // clietType
            // 
            this.clietType.Text = "Client type";
            this.clietType.Width = 405;
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
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Adobe Fan Heiti Std B", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(29, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 50);
            this.label2.TabIndex = 16;
            this.label2.Text = "Order by";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(91)))), ((int)(((byte)(119)))));
            this.ClientSize = new System.Drawing.Size(1160, 603);
            this.Controls.Add(this.NavBar);
            this.Name = "form1";
            this.Text = "3TL Administrator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.NavBar.ResumeLayout(false);
            this.allOrders.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.clientTab.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl NavBar;
        private TabPage allOrders;
        private ListView orderListView;
        private ColumnHeader orderNumber;
        private ColumnHeader createdBy;
        private ColumnHeader pickUpAddress;
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
        private Button RefreshButton;
        private ListView clientListView;
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
        private Button clientInfo;
        private ColumnHeader clietType;
        private Label label4;
        private Label label5;
        private GroupBox groupBox1;
        private RadioButton CustomerFilter;
        private RadioButton StatusFilter;
        private RadioButton DeadlineFIlter;
        private Label label2;
    }
}


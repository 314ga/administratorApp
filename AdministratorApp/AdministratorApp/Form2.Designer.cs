namespace AdministratorApp
{
    partial class Form2
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
            this.clientConfirmBtn = new System.Windows.Forms.Button();
            this.showClientTitle = new System.Windows.Forms.Label();
            this.TelNo = new System.Windows.Forms.TextBox();
            this.Email = new System.Windows.Forms.TextBox();
            this.CompanyName = new System.Windows.Forms.TextBox();
            this.street = new System.Windows.Forms.TextBox();
            this.postcode = new System.Windows.Forms.TextBox();
            this.city = new System.Windows.Forms.TextBox();
            this.state = new System.Windows.Forms.TextBox();
            this.contractor = new System.Windows.Forms.RadioButton();
            this.customer = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // clientConfirmBtn
            // 
            this.clientConfirmBtn.BackColor = System.Drawing.Color.Chartreuse;
            this.clientConfirmBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.clientConfirmBtn.Location = new System.Drawing.Point(55, 369);
            this.clientConfirmBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.clientConfirmBtn.Name = "clientConfirmBtn";
            this.clientConfirmBtn.Size = new System.Drawing.Size(207, 35);
            this.clientConfirmBtn.TabIndex = 7;
            this.clientConfirmBtn.Text = "Create client";
            this.clientConfirmBtn.UseVisualStyleBackColor = false;
            this.clientConfirmBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // showClientTitle
            // 
            this.showClientTitle.AutoSize = true;
            this.showClientTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold);
            this.showClientTitle.Location = new System.Drawing.Point(75, 25);
            this.showClientTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.showClientTitle.Name = "showClientTitle";
            this.showClientTitle.Size = new System.Drawing.Size(178, 24);
            this.showClientTitle.TabIndex = 8;
            this.showClientTitle.Text = "Create new client ";
            // 
            // TelNo
            // 
            this.TelNo.Font = new System.Drawing.Font("Lucida Sans Unicode", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TelNo.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.TelNo.Location = new System.Drawing.Point(55, 108);
            this.TelNo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TelNo.Name = "TelNo";
            this.TelNo.Size = new System.Drawing.Size(210, 30);
            this.TelNo.TabIndex = 9;
            this.TelNo.Text = "Tel. number";
            this.TelNo.Enter += new System.EventHandler(this.TelNo_Enter);
            this.TelNo.Leave += new System.EventHandler(this.TelNo_Leave);
            // 
            // Email
            // 
            this.Email.Font = new System.Drawing.Font("Lucida Sans Unicode", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Email.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.Email.Location = new System.Drawing.Point(56, 154);
            this.Email.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(209, 30);
            this.Email.TabIndex = 10;
            this.Email.Text = "Email";
            this.Email.Enter += new System.EventHandler(this.Email_Enter);
            this.Email.Leave += new System.EventHandler(this.Email_Leave);
            // 
            // CompanyName
            // 
            this.CompanyName.Font = new System.Drawing.Font("Lucida Sans Unicode", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.CompanyName.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.CompanyName.Location = new System.Drawing.Point(55, 64);
            this.CompanyName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CompanyName.Name = "CompanyName";
            this.CompanyName.Size = new System.Drawing.Size(210, 30);
            this.CompanyName.TabIndex = 11;
            this.CompanyName.Text = "Company name";
            this.CompanyName.Enter += new System.EventHandler(this.CompanyName_Enter);
            this.CompanyName.Leave += new System.EventHandler(this.CompanyName_Leave);
            // 
            // street
            // 
            this.street.Font = new System.Drawing.Font("Lucida Sans Unicode", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.street.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.street.Location = new System.Drawing.Point(55, 197);
            this.street.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.street.Name = "street";
            this.street.Size = new System.Drawing.Size(209, 30);
            this.street.TabIndex = 13;
            this.street.Text = "Street";
            this.street.Enter += new System.EventHandler(this.street_Enter);
            this.street.Leave += new System.EventHandler(this.street_Leave);
            // 
            // postcode
            // 
            this.postcode.Font = new System.Drawing.Font("Lucida Sans Unicode", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.postcode.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.postcode.Location = new System.Drawing.Point(55, 239);
            this.postcode.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.postcode.Name = "postcode";
            this.postcode.Size = new System.Drawing.Size(69, 30);
            this.postcode.TabIndex = 14;
            this.postcode.Text = "Postcode";
            this.postcode.Enter += new System.EventHandler(this.postcode_Enter);
            this.postcode.Leave += new System.EventHandler(this.postcode_Leave);
            // 
            // city
            // 
            this.city.Font = new System.Drawing.Font("Lucida Sans Unicode", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.city.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.city.Location = new System.Drawing.Point(128, 239);
            this.city.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.city.Name = "city";
            this.city.Size = new System.Drawing.Size(137, 30);
            this.city.TabIndex = 15;
            this.city.Text = "City";
            this.city.Enter += new System.EventHandler(this.city_Enter);
            this.city.Leave += new System.EventHandler(this.city_Leave);
            // 
            // state
            // 
            this.state.Font = new System.Drawing.Font("Lucida Sans Unicode", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.state.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.state.Location = new System.Drawing.Point(56, 283);
            this.state.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.state.Name = "state";
            this.state.Size = new System.Drawing.Size(209, 30);
            this.state.TabIndex = 16;
            this.state.Text = "State";
            this.state.Enter += new System.EventHandler(this.state_Enter);
            this.state.Leave += new System.EventHandler(this.state_Leave);
            // 
            // contractor
            // 
            this.contractor.AutoSize = true;
            this.contractor.Location = new System.Drawing.Point(191, 324);
            this.contractor.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.contractor.Name = "contractor";
            this.contractor.Size = new System.Drawing.Size(74, 17);
            this.contractor.TabIndex = 17;
            this.contractor.TabStop = true;
            this.contractor.Text = "Contractor";
            this.contractor.UseVisualStyleBackColor = true;
            // 
            // customer
            // 
            this.customer.AutoSize = true;
            this.customer.Location = new System.Drawing.Point(56, 324);
            this.customer.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.customer.Name = "customer";
            this.customer.Size = new System.Drawing.Size(69, 17);
            this.customer.TabIndex = 18;
            this.customer.TabStop = true;
            this.customer.Text = "Customer";
            this.customer.UseVisualStyleBackColor = true;
            this.customer.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(326, 458);
            this.Controls.Add(this.customer);
            this.Controls.Add(this.contractor);
            this.Controls.Add(this.state);
            this.Controls.Add(this.city);
            this.Controls.Add(this.postcode);
            this.Controls.Add(this.street);
            this.Controls.Add(this.CompanyName);
            this.Controls.Add(this.Email);
            this.Controls.Add(this.TelNo);
            this.Controls.Add(this.showClientTitle);
            this.Controls.Add(this.clientConfirmBtn);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button clientConfirmBtn;
        private System.Windows.Forms.Label showClientTitle;
        private System.Windows.Forms.TextBox TelNo;
        private System.Windows.Forms.TextBox Email;
        private System.Windows.Forms.TextBox CompanyName;
        private System.Windows.Forms.TextBox street;
        private System.Windows.Forms.TextBox postcode;
        private System.Windows.Forms.TextBox city;
        private System.Windows.Forms.TextBox state;
        private System.Windows.Forms.RadioButton contractor;
        private System.Windows.Forms.RadioButton customer;
    }
}
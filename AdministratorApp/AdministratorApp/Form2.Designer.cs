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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
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
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Chartreuse;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.Location = new System.Drawing.Point(73, 454);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(276, 43);
            this.button1.TabIndex = 7;
            this.button1.Text = "Create client";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(100, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(223, 29);
            this.label1.TabIndex = 8;
            this.label1.Text = "Create new client ";
            // 
            // TelNo
            // 
            this.TelNo.Font = new System.Drawing.Font("Lucida Sans Unicode", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TelNo.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.TelNo.Location = new System.Drawing.Point(73, 133);
            this.TelNo.Name = "TelNo";
            this.TelNo.Size = new System.Drawing.Size(278, 35);
            this.TelNo.TabIndex = 9;
            this.TelNo.Text = "Tel. number";
            this.TelNo.Enter += new System.EventHandler(this.TelNo_Enter);
            this.TelNo.Leave += new System.EventHandler(this.TelNo_Leave);
            // 
            // Email
            // 
            this.Email.Font = new System.Drawing.Font("Lucida Sans Unicode", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Email.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.Email.Location = new System.Drawing.Point(74, 190);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(277, 35);
            this.Email.TabIndex = 10;
            this.Email.Text = "Email";
            this.Email.Enter += new System.EventHandler(this.Email_Enter);
            this.Email.Leave += new System.EventHandler(this.Email_Leave);
            // 
            // CompanyName
            // 
            this.CompanyName.Font = new System.Drawing.Font("Lucida Sans Unicode", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.CompanyName.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.CompanyName.Location = new System.Drawing.Point(73, 79);
            this.CompanyName.Name = "CompanyName";
            this.CompanyName.Size = new System.Drawing.Size(278, 35);
            this.CompanyName.TabIndex = 11;
            this.CompanyName.Text = "Company name";
            this.CompanyName.Enter += new System.EventHandler(this.CompanyName_Enter);
            this.CompanyName.Leave += new System.EventHandler(this.CompanyName_Leave);
            // 
            // street
            // 
            this.street.Font = new System.Drawing.Font("Lucida Sans Unicode", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.street.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.street.Location = new System.Drawing.Point(73, 242);
            this.street.Name = "street";
            this.street.Size = new System.Drawing.Size(277, 35);
            this.street.TabIndex = 13;
            this.street.Text = "Street";
            this.street.Enter += new System.EventHandler(this.street_Enter);
            this.street.Leave += new System.EventHandler(this.street_Leave);
            // 
            // postcode
            // 
            this.postcode.Font = new System.Drawing.Font("Lucida Sans Unicode", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.postcode.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.postcode.Location = new System.Drawing.Point(73, 294);
            this.postcode.Name = "postcode";
            this.postcode.Size = new System.Drawing.Size(91, 35);
            this.postcode.TabIndex = 14;
            this.postcode.Text = "Postcode";
            this.postcode.Enter += new System.EventHandler(this.postcode_Enter);
            this.postcode.Leave += new System.EventHandler(this.postcode_Leave);
            // 
            // city
            // 
            this.city.Font = new System.Drawing.Font("Lucida Sans Unicode", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.city.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.city.Location = new System.Drawing.Point(170, 294);
            this.city.Name = "city";
            this.city.Size = new System.Drawing.Size(181, 35);
            this.city.TabIndex = 15;
            this.city.Text = "City";
            this.city.Enter += new System.EventHandler(this.city_Enter);
            this.city.Leave += new System.EventHandler(this.city_Leave);
            // 
            // state
            // 
            this.state.Font = new System.Drawing.Font("Lucida Sans Unicode", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.state.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.state.Location = new System.Drawing.Point(74, 348);
            this.state.Name = "state";
            this.state.Size = new System.Drawing.Size(277, 35);
            this.state.TabIndex = 16;
            this.state.Text = "State";
            this.state.Enter += new System.EventHandler(this.state_Enter);
            this.state.Leave += new System.EventHandler(this.state_Leave);
            // 
            // contractor
            // 
            this.contractor.AutoSize = true;
            this.contractor.Location = new System.Drawing.Point(255, 399);
            this.contractor.Name = "contractor";
            this.contractor.Size = new System.Drawing.Size(95, 21);
            this.contractor.TabIndex = 17;
            this.contractor.TabStop = true;
            this.contractor.Text = "Contractor";
            this.contractor.UseVisualStyleBackColor = true;
            // 
            // customer
            // 
            this.customer.AutoSize = true;
            this.customer.Location = new System.Drawing.Point(75, 399);
            this.customer.Name = "customer";
            this.customer.Size = new System.Drawing.Size(89, 21);
            this.customer.TabIndex = 18;
            this.customer.TabStop = true;
            this.customer.Text = "Customer";
            this.customer.UseVisualStyleBackColor = true;
            this.customer.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 564);
            this.Controls.Add(this.customer);
            this.Controls.Add(this.contractor);
            this.Controls.Add(this.state);
            this.Controls.Add(this.city);
            this.Controls.Add(this.postcode);
            this.Controls.Add(this.street);
            this.Controls.Add(this.CompanyName);
            this.Controls.Add(this.Email);
            this.Controls.Add(this.TelNo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
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
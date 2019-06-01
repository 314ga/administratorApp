namespace AdministratorApp
{
    partial class OrderViewForm
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
            this.editDeleteOrder = new System.Windows.Forms.Label();
            this.Email = new System.Windows.Forms.TextBox();
            this.street = new System.Windows.Forms.TextBox();
            this.postcode = new System.Windows.Forms.TextBox();
            this.city = new System.Windows.Forms.TextBox();
            this.state = new System.Windows.Forms.TextBox();
            this.contractor = new System.Windows.Forms.RadioButton();
            this.customer = new System.Windows.Forms.RadioButton();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Chartreuse;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.Location = new System.Drawing.Point(54, 398);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(207, 35);
            this.button1.TabIndex = 7;
            this.button1.Text = "Create client";
            this.button1.UseVisualStyleBackColor = false;

            // 
            // editDeleteOrder
            // 
            this.editDeleteOrder.AutoSize = true;
            this.editDeleteOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold);
            this.editDeleteOrder.Location = new System.Drawing.Point(101, 25);
            this.editDeleteOrder.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.editDeleteOrder.Name = "editDeleteOrder";
            this.editDeleteOrder.Size = new System.Drawing.Size(112, 24);
            this.editDeleteOrder.TabIndex = 8;
            this.editDeleteOrder.Text = "Edit Order ";
            // 
            // Email
            // 
            this.Email.Font = new System.Drawing.Font("Lucida Sans Unicode", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Email.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.Email.Location = new System.Drawing.Point(55, 183);
            this.Email.Margin = new System.Windows.Forms.Padding(2);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(209, 30);
            this.Email.TabIndex = 10;
            this.Email.Text = "Email";
            this.Email.Enter += new System.EventHandler(this.Email_Enter);
            this.Email.Leave += new System.EventHandler(this.Email_Leave);
            // 
            // street
            // 
            this.street.Font = new System.Drawing.Font("Lucida Sans Unicode", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.street.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.street.Location = new System.Drawing.Point(54, 226);
            this.street.Margin = new System.Windows.Forms.Padding(2);
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
            this.postcode.Location = new System.Drawing.Point(54, 268);
            this.postcode.Margin = new System.Windows.Forms.Padding(2);
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
            this.city.Location = new System.Drawing.Point(127, 268);
            this.city.Margin = new System.Windows.Forms.Padding(2);
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
            this.state.Location = new System.Drawing.Point(55, 312);
            this.state.Margin = new System.Windows.Forms.Padding(2);
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
            this.contractor.Location = new System.Drawing.Point(190, 353);
            this.contractor.Margin = new System.Windows.Forms.Padding(2);
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
            this.customer.Location = new System.Drawing.Point(55, 353);
            this.customer.Margin = new System.Windows.Forms.Padding(2);
            this.customer.Name = "customer";
            this.customer.Size = new System.Drawing.Size(69, 17);
            this.customer.TabIndex = 18;
            this.customer.TabStop = true;
            this.customer.Text = "Customer";
            this.customer.UseVisualStyleBackColor = true;
            this.customer.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(54, 88);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(210, 20);
            this.dateTimePicker1.TabIndex = 19;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(54, 136);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker2.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(102, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 17);
            this.label1.TabIndex = 21;
            this.label1.Text = "Pick up Deadline";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(102, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 17);
            this.label2.TabIndex = 22;
            this.label2.Text = "Pick up Deadline";
           
            // 
            // OrderViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(326, 458);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.customer);
            this.Controls.Add(this.contractor);
            this.Controls.Add(this.state);
            this.Controls.Add(this.city);
            this.Controls.Add(this.postcode);
            this.Controls.Add(this.street);
            this.Controls.Add(this.Email);
            this.Controls.Add(this.editDeleteOrder);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "OrderViewForm";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label editDeleteOrder;
        private System.Windows.Forms.TextBox Email;
        private System.Windows.Forms.TextBox street;
        private System.Windows.Forms.TextBox postcode;
        private System.Windows.Forms.TextBox city;
        private System.Windows.Forms.TextBox state;
        private System.Windows.Forms.RadioButton contractor;
        private System.Windows.Forms.RadioButton customer;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}
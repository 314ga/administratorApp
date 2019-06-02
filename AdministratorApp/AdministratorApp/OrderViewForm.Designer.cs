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
            this.saveChanges = new System.Windows.Forms.Button();
            this.editDeleteOrder = new System.Windows.Forms.Label();
            this.street = new System.Windows.Forms.TextBox();
            this.postcode = new System.Windows.Forms.TextBox();
            this.city = new System.Windows.Forms.TextBox();
            this.state = new System.Windows.Forms.TextBox();
            this.pickUpPicker = new System.Windows.Forms.DateTimePicker();
            this.dropOffPicker = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dropState = new System.Windows.Forms.TextBox();
            this.dropCity = new System.Windows.Forms.TextBox();
            this.dropPostcode = new System.Windows.Forms.TextBox();
            this.dropStreet = new System.Windows.Forms.TextBox();
            this.Size = new System.Windows.Forms.TextBox();
            this.weight = new System.Windows.Forms.TextBox();
            this.Price = new System.Windows.Forms.TextBox();
            this.containerSize = new System.Windows.Forms.TextBox();
            this.pickedUpCheck = new System.Windows.Forms.RadioButton();
            this.avaitingPickCheck = new System.Windows.Forms.RadioButton();
            this.lateDeliveryCheck = new System.Windows.Forms.RadioButton();
            this.deliveredCheck = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.description = new System.Windows.Forms.TextBox();
            this.descriptionLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // saveChanges
            // 
            this.saveChanges.BackColor = System.Drawing.Color.Chartreuse;
            this.saveChanges.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.saveChanges.Location = new System.Drawing.Point(160, 513);
            this.saveChanges.Margin = new System.Windows.Forms.Padding(2);
            this.saveChanges.Name = "saveChanges";
            this.saveChanges.Size = new System.Drawing.Size(207, 35);
            this.saveChanges.TabIndex = 7;
            this.saveChanges.Text = "Save changes";
            this.saveChanges.UseVisualStyleBackColor = false;
            this.saveChanges.Click += new System.EventHandler(this.saveChanges_Click);
            // 
            // editDeleteOrder
            // 
            this.editDeleteOrder.AutoSize = true;
            this.editDeleteOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold);
            this.editDeleteOrder.Location = new System.Drawing.Point(205, 20);
            this.editDeleteOrder.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.editDeleteOrder.Name = "editDeleteOrder";
            this.editDeleteOrder.Size = new System.Drawing.Size(112, 24);
            this.editDeleteOrder.TabIndex = 8;
            this.editDeleteOrder.Text = "Edit Order ";
            // 
            // street
            // 
            this.street.Font = new System.Drawing.Font("Lucida Sans Unicode", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.street.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.street.Location = new System.Drawing.Point(39, 138);
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
            this.postcode.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.postcode.Location = new System.Drawing.Point(39, 180);
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
            this.city.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.city.Location = new System.Drawing.Point(112, 180);
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
            this.state.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.state.Location = new System.Drawing.Point(40, 224);
            this.state.Margin = new System.Windows.Forms.Padding(2);
            this.state.Name = "state";
            this.state.Size = new System.Drawing.Size(209, 30);
            this.state.TabIndex = 16;
            this.state.Text = "State";
            this.state.Enter += new System.EventHandler(this.state_Enter);
            this.state.Leave += new System.EventHandler(this.state_Leave);
            // 
            // pickUpPicker
            // 
            this.pickUpPicker.Location = new System.Drawing.Point(38, 87);
            this.pickUpPicker.Name = "pickUpPicker";
            this.pickUpPicker.Size = new System.Drawing.Size(210, 20);
            this.pickUpPicker.TabIndex = 19;
            // 
            // dropOffPicker
            // 
            this.dropOffPicker.Location = new System.Drawing.Point(266, 87);
            this.dropOffPicker.Name = "dropOffPicker";
            this.dropOffPicker.Size = new System.Drawing.Size(210, 20);
            this.dropOffPicker.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(86, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 17);
            this.label1.TabIndex = 21;
            this.label1.Text = "Pick up Deadline";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(314, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 17);
            this.label2.TabIndex = 22;
            this.label2.Text = "Drop off Deadline";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(86, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 17);
            this.label3.TabIndex = 23;
            this.label3.Text = "Pick up address";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(313, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 17);
            this.label4.TabIndex = 28;
            this.label4.Text = "Drop off address";
            // 
            // dropState
            // 
            this.dropState.Font = new System.Drawing.Font("Lucida Sans Unicode", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dropState.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dropState.Location = new System.Drawing.Point(267, 224);
            this.dropState.Margin = new System.Windows.Forms.Padding(2);
            this.dropState.Name = "dropState";
            this.dropState.Size = new System.Drawing.Size(209, 30);
            this.dropState.TabIndex = 27;
            this.dropState.Text = "State";
            // 
            // dropCity
            // 
            this.dropCity.Font = new System.Drawing.Font("Lucida Sans Unicode", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dropCity.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dropCity.Location = new System.Drawing.Point(339, 180);
            this.dropCity.Margin = new System.Windows.Forms.Padding(2);
            this.dropCity.Name = "dropCity";
            this.dropCity.Size = new System.Drawing.Size(137, 30);
            this.dropCity.TabIndex = 26;
            this.dropCity.Text = "City";
            // 
            // dropPostcode
            // 
            this.dropPostcode.Font = new System.Drawing.Font("Lucida Sans Unicode", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dropPostcode.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dropPostcode.Location = new System.Drawing.Point(266, 180);
            this.dropPostcode.Margin = new System.Windows.Forms.Padding(2);
            this.dropPostcode.Name = "dropPostcode";
            this.dropPostcode.Size = new System.Drawing.Size(69, 30);
            this.dropPostcode.TabIndex = 25;
            this.dropPostcode.Text = "Postcode";
            // 
            // dropStreet
            // 
            this.dropStreet.Font = new System.Drawing.Font("Lucida Sans Unicode", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dropStreet.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dropStreet.Location = new System.Drawing.Point(266, 138);
            this.dropStreet.Margin = new System.Windows.Forms.Padding(2);
            this.dropStreet.Name = "dropStreet";
            this.dropStreet.Size = new System.Drawing.Size(209, 30);
            this.dropStreet.TabIndex = 24;
            this.dropStreet.Text = "Street";
            // 
            // Size
            // 
            this.Size.Font = new System.Drawing.Font("Lucida Sans Unicode", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Size.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Size.Location = new System.Drawing.Point(41, 288);
            this.Size.Margin = new System.Windows.Forms.Padding(2);
            this.Size.Name = "Size";
            this.Size.Size = new System.Drawing.Size(209, 30);
            this.Size.TabIndex = 29;
            this.Size.Text = "Package size";
            // 
            // weight
            // 
            this.weight.Font = new System.Drawing.Font("Lucida Sans Unicode", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.weight.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.weight.Location = new System.Drawing.Point(267, 288);
            this.weight.Margin = new System.Windows.Forms.Padding(2);
            this.weight.Name = "weight";
            this.weight.Size = new System.Drawing.Size(209, 30);
            this.weight.TabIndex = 30;
            this.weight.Text = "Weight";
            // 
            // Price
            // 
            this.Price.Font = new System.Drawing.Font("Lucida Sans Unicode", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Price.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Price.Location = new System.Drawing.Point(40, 350);
            this.Price.Margin = new System.Windows.Forms.Padding(2);
            this.Price.Name = "Price";
            this.Price.Size = new System.Drawing.Size(209, 30);
            this.Price.TabIndex = 31;
            this.Price.Text = "Price";
            // 
            // containerSize
            // 
            this.containerSize.Font = new System.Drawing.Font("Lucida Sans Unicode", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.containerSize.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.containerSize.Location = new System.Drawing.Point(266, 350);
            this.containerSize.Margin = new System.Windows.Forms.Padding(2);
            this.containerSize.Name = "containerSize";
            this.containerSize.Size = new System.Drawing.Size(209, 30);
            this.containerSize.TabIndex = 32;
            this.containerSize.Text = "Container size";
            // 
            // pickedUpCheck
            // 
            this.pickedUpCheck.AutoSize = true;
            this.pickedUpCheck.Location = new System.Drawing.Point(187, 479);
            this.pickedUpCheck.Margin = new System.Windows.Forms.Padding(2);
            this.pickedUpCheck.Name = "pickedUpCheck";
            this.pickedUpCheck.Size = new System.Drawing.Size(73, 17);
            this.pickedUpCheck.TabIndex = 17;
            this.pickedUpCheck.TabStop = true;
            this.pickedUpCheck.Text = "Picked up";
            this.pickedUpCheck.UseVisualStyleBackColor = true;
            // 
            // avaitingPickCheck
            // 
            this.avaitingPickCheck.AutoSize = true;
            this.avaitingPickCheck.Location = new System.Drawing.Point(60, 479);
            this.avaitingPickCheck.Margin = new System.Windows.Forms.Padding(2);
            this.avaitingPickCheck.Name = "avaitingPickCheck";
            this.avaitingPickCheck.Size = new System.Drawing.Size(102, 17);
            this.avaitingPickCheck.TabIndex = 18;
            this.avaitingPickCheck.TabStop = true;
            this.avaitingPickCheck.Text = "Avaiting Pick up";
            this.avaitingPickCheck.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.avaitingPickCheck.UseVisualStyleBackColor = true;
            // 
            // lateDeliveryCheck
            // 
            this.lateDeliveryCheck.AutoSize = true;
            this.lateDeliveryCheck.Location = new System.Drawing.Point(286, 479);
            this.lateDeliveryCheck.Margin = new System.Windows.Forms.Padding(2);
            this.lateDeliveryCheck.Name = "lateDeliveryCheck";
            this.lateDeliveryCheck.Size = new System.Drawing.Size(85, 17);
            this.lateDeliveryCheck.TabIndex = 34;
            this.lateDeliveryCheck.TabStop = true;
            this.lateDeliveryCheck.Text = "Late delivery";
            this.lateDeliveryCheck.UseVisualStyleBackColor = true;
            // 
            // deliveredCheck
            // 
            this.deliveredCheck.AutoSize = true;
            this.deliveredCheck.Location = new System.Drawing.Point(395, 479);
            this.deliveredCheck.Margin = new System.Windows.Forms.Padding(2);
            this.deliveredCheck.Name = "deliveredCheck";
            this.deliveredCheck.Size = new System.Drawing.Size(70, 17);
            this.deliveredCheck.TabIndex = 35;
            this.deliveredCheck.TabStop = true;
            this.deliveredCheck.Text = "Delivered";
            this.deliveredCheck.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(103, 269);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 17);
            this.label5.TabIndex = 36;
            this.label5.Text = "Package size";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(327, 269);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 17);
            this.label6.TabIndex = 37;
            this.label6.Text = "Weight(kg)";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(120, 331);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 17);
            this.label7.TabIndex = 38;
            this.label7.Text = "Price(€)";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label8.Location = new System.Drawing.Point(315, 331);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(98, 17);
            this.label8.TabIndex = 39;
            this.label8.Text = "Container size";
            // 
            // description
            // 
            this.description.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.description.Location = new System.Drawing.Point(39, 416);
            this.description.Multiline = true;
            this.description.Name = "description";
            this.description.Size = new System.Drawing.Size(437, 58);
            this.description.TabIndex = 40;
            // 
            // descriptionLbl
            // 
            this.descriptionLbl.AutoSize = true;
            this.descriptionLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.descriptionLbl.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.descriptionLbl.Location = new System.Drawing.Point(220, 396);
            this.descriptionLbl.Name = "descriptionLbl";
            this.descriptionLbl.Size = new System.Drawing.Size(79, 17);
            this.descriptionLbl.TabIndex = 41;
            this.descriptionLbl.Text = "Description";
            // 
            // OrderViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 574);
            this.Controls.Add(this.descriptionLbl);
            this.Controls.Add(this.description);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.deliveredCheck);
            this.Controls.Add(this.lateDeliveryCheck);
            this.Controls.Add(this.containerSize);
            this.Controls.Add(this.Price);
            this.Controls.Add(this.weight);
            this.Controls.Add(this.Size);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dropState);
            this.Controls.Add(this.dropCity);
            this.Controls.Add(this.dropPostcode);
            this.Controls.Add(this.dropStreet);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dropOffPicker);
            this.Controls.Add(this.pickUpPicker);
            this.Controls.Add(this.avaitingPickCheck);
            this.Controls.Add(this.pickedUpCheck);
            this.Controls.Add(this.state);
            this.Controls.Add(this.city);
            this.Controls.Add(this.postcode);
            this.Controls.Add(this.street);
            this.Controls.Add(this.editDeleteOrder);
            this.Controls.Add(this.saveChanges);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "OrderViewForm";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button saveChanges;
        private System.Windows.Forms.Label editDeleteOrder;
        private System.Windows.Forms.TextBox street;
        private System.Windows.Forms.TextBox postcode;
        private System.Windows.Forms.TextBox city;
        private System.Windows.Forms.TextBox state;
        private System.Windows.Forms.DateTimePicker pickUpPicker;
        private System.Windows.Forms.DateTimePicker dropOffPicker;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox dropState;
        private System.Windows.Forms.TextBox dropCity;
        private System.Windows.Forms.TextBox dropPostcode;
        private System.Windows.Forms.TextBox dropStreet;
        private System.Windows.Forms.TextBox Size;
        private System.Windows.Forms.TextBox weight;
        private System.Windows.Forms.TextBox Price;
        private System.Windows.Forms.TextBox containerSize;
        private System.Windows.Forms.RadioButton pickedUpCheck;
        private System.Windows.Forms.RadioButton avaitingPickCheck;
        private System.Windows.Forms.RadioButton lateDeliveryCheck;
        private System.Windows.Forms.RadioButton deliveredCheck;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox description;
        private System.Windows.Forms.Label descriptionLbl;
    }
}
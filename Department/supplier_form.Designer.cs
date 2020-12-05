namespace Department
{
    partial class supplier_form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(supplier_form));
            this.supplierData = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.add_button = new System.Windows.Forms.Button();
            this.edit_button = new System.Windows.Forms.Button();
            this.delete_button = new System.Windows.Forms.Button();
            this.control_groupBox = new System.Windows.Forms.GroupBox();
            this.hide_button = new System.Windows.Forms.Button();
            this.error_label = new System.Windows.Forms.Label();
            this.save_button = new System.Windows.Forms.Button();
            this.clear_button = new System.Windows.Forms.Button();
            this.contacts_textbox = new System.Windows.Forms.TextBox();
            this.address_textbox = new System.Windows.Forms.TextBox();
            this.name_textbox = new System.Windows.Forms.TextBox();
            this.contacts_label = new System.Windows.Forms.Label();
            this.address_label = new System.Windows.Forms.Label();
            this.name_label = new System.Windows.Forms.Label();
            this.search_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.supplierData)).BeginInit();
            this.panel1.SuspendLayout();
            this.control_groupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // supplierData
            // 
            this.supplierData.AllowUserToAddRows = false;
            this.supplierData.AllowUserToDeleteRows = false;
            this.supplierData.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.supplierData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.supplierData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.supplierData.Location = new System.Drawing.Point(13, 13);
            this.supplierData.Name = "supplierData";
            this.supplierData.ReadOnly = true;
            this.supplierData.RowHeadersWidth = 51;
            this.supplierData.RowTemplate.Height = 24;
            this.supplierData.Size = new System.Drawing.Size(958, 205);
            this.supplierData.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Id";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Name";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Address";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 125;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Contacts";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 125;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(171)))), ((int)(((byte)(171)))));
            this.panel1.Controls.Add(this.add_button);
            this.panel1.Controls.Add(this.edit_button);
            this.panel1.Controls.Add(this.delete_button);
            this.panel1.Location = new System.Drawing.Point(13, 225);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(140, 213);
            this.panel1.TabIndex = 1;
            // 
            // add_button
            // 
            this.add_button.Location = new System.Drawing.Point(2, 1);
            this.add_button.Name = "add_button";
            this.add_button.Size = new System.Drawing.Size(136, 70);
            this.add_button.TabIndex = 2;
            this.add_button.Text = "add";
            this.add_button.UseVisualStyleBackColor = true;
            this.add_button.Click += new System.EventHandler(this.add_button_Click);
            // 
            // edit_button
            // 
            this.edit_button.Location = new System.Drawing.Point(2, 70);
            this.edit_button.Name = "edit_button";
            this.edit_button.Size = new System.Drawing.Size(136, 70);
            this.edit_button.TabIndex = 3;
            this.edit_button.Text = "edit";
            this.edit_button.UseVisualStyleBackColor = true;
            this.edit_button.Click += new System.EventHandler(this.edit_button_Click);
            // 
            // delete_button
            // 
            this.delete_button.Location = new System.Drawing.Point(2, 140);
            this.delete_button.Name = "delete_button";
            this.delete_button.Size = new System.Drawing.Size(136, 70);
            this.delete_button.TabIndex = 4;
            this.delete_button.Text = "delete";
            this.delete_button.UseVisualStyleBackColor = true;
            this.delete_button.Click += new System.EventHandler(this.delete_button_Click);
            // 
            // control_groupBox
            // 
            this.control_groupBox.Controls.Add(this.hide_button);
            this.control_groupBox.Controls.Add(this.error_label);
            this.control_groupBox.Controls.Add(this.save_button);
            this.control_groupBox.Controls.Add(this.clear_button);
            this.control_groupBox.Controls.Add(this.contacts_textbox);
            this.control_groupBox.Controls.Add(this.address_textbox);
            this.control_groupBox.Controls.Add(this.name_textbox);
            this.control_groupBox.Controls.Add(this.contacts_label);
            this.control_groupBox.Controls.Add(this.address_label);
            this.control_groupBox.Controls.Add(this.name_label);
            this.control_groupBox.Location = new System.Drawing.Point(160, 225);
            this.control_groupBox.Name = "control_groupBox";
            this.control_groupBox.Size = new System.Drawing.Size(877, 210);
            this.control_groupBox.TabIndex = 2;
            this.control_groupBox.TabStop = false;
            this.control_groupBox.Text = "groupBox";
            this.control_groupBox.Visible = false;
            // 
            // hide_button
            // 
            this.hide_button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("hide_button.BackgroundImage")));
            this.hide_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.hide_button.Location = new System.Drawing.Point(832, 22);
            this.hide_button.Name = "hide_button";
            this.hide_button.Size = new System.Drawing.Size(30, 30);
            this.hide_button.TabIndex = 9;
            this.hide_button.UseVisualStyleBackColor = true;
            this.hide_button.Click += new System.EventHandler(this.hide_button_Click);
            // 
            // error_label
            // 
            this.error_label.AutoSize = true;
            this.error_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.error_label.ForeColor = System.Drawing.Color.Red;
            this.error_label.Location = new System.Drawing.Point(38, 36);
            this.error_label.Name = "error_label";
            this.error_label.Size = new System.Drawing.Size(151, 17);
            this.error_label.TabIndex = 8;
            this.error_label.Text = "Some fields are empty!";
            this.error_label.Visible = false;
            // 
            // save_button
            // 
            this.save_button.Location = new System.Drawing.Point(737, 144);
            this.save_button.Name = "save_button";
            this.save_button.Size = new System.Drawing.Size(100, 50);
            this.save_button.TabIndex = 7;
            this.save_button.Text = "save";
            this.save_button.UseVisualStyleBackColor = true;
            this.save_button.Click += new System.EventHandler(this.save_button_Click);
            // 
            // clear_button
            // 
            this.clear_button.Location = new System.Drawing.Point(600, 144);
            this.clear_button.Name = "clear_button";
            this.clear_button.Size = new System.Drawing.Size(100, 50);
            this.clear_button.TabIndex = 6;
            this.clear_button.Text = "clear";
            this.clear_button.UseVisualStyleBackColor = true;
            this.clear_button.Click += new System.EventHandler(this.clear_button_Click);
            // 
            // contacts_textbox
            // 
            this.contacts_textbox.Location = new System.Drawing.Point(109, 158);
            this.contacts_textbox.Name = "contacts_textbox";
            this.contacts_textbox.Size = new System.Drawing.Size(440, 22);
            this.contacts_textbox.TabIndex = 5;
            // 
            // address_textbox
            // 
            this.address_textbox.Location = new System.Drawing.Point(109, 105);
            this.address_textbox.Name = "address_textbox";
            this.address_textbox.Size = new System.Drawing.Size(440, 22);
            this.address_textbox.TabIndex = 4;
            // 
            // name_textbox
            // 
            this.name_textbox.Location = new System.Drawing.Point(94, 56);
            this.name_textbox.Name = "name_textbox";
            this.name_textbox.Size = new System.Drawing.Size(455, 22);
            this.name_textbox.TabIndex = 3;
            // 
            // contacts_label
            // 
            this.contacts_label.AutoSize = true;
            this.contacts_label.Location = new System.Drawing.Point(38, 158);
            this.contacts_label.Name = "contacts_label";
            this.contacts_label.Size = new System.Drawing.Size(67, 17);
            this.contacts_label.TabIndex = 2;
            this.contacts_label.Text = "Contacts:";
            // 
            // address_label
            // 
            this.address_label.AutoSize = true;
            this.address_label.Location = new System.Drawing.Point(38, 105);
            this.address_label.Name = "address_label";
            this.address_label.Size = new System.Drawing.Size(64, 17);
            this.address_label.TabIndex = 1;
            this.address_label.Text = "Address:";
            // 
            // name_label
            // 
            this.name_label.AutoSize = true;
            this.name_label.Location = new System.Drawing.Point(38, 56);
            this.name_label.Name = "name_label";
            this.name_label.Size = new System.Drawing.Size(49, 17);
            this.name_label.TabIndex = 0;
            this.name_label.Text = "Name:";
            // 
            // search_button
            // 
            this.search_button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("search_button.BackgroundImage")));
            this.search_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.search_button.Location = new System.Drawing.Point(977, 12);
            this.search_button.Name = "search_button";
            this.search_button.Size = new System.Drawing.Size(60, 60);
            this.search_button.TabIndex = 3;
            this.search_button.UseVisualStyleBackColor = true;
            this.search_button.Click += new System.EventHandler(this.search_button_Click);
            // 
            // supplier_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1049, 450);
            this.Controls.Add(this.search_button);
            this.Controls.Add(this.control_groupBox);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.supplierData);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "supplier_form";
            this.Text = "supplier";
            this.Load += new System.EventHandler(this.supplier_form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.supplierData)).EndInit();
            this.panel1.ResumeLayout(false);
            this.control_groupBox.ResumeLayout(false);
            this.control_groupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView supplierData;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button add_button;
        private System.Windows.Forms.Button edit_button;
        private System.Windows.Forms.Button delete_button;
        private System.Windows.Forms.GroupBox control_groupBox;
        private System.Windows.Forms.Label error_label;
        private System.Windows.Forms.Button save_button;
        private System.Windows.Forms.Button clear_button;
        private System.Windows.Forms.TextBox contacts_textbox;
        private System.Windows.Forms.TextBox address_textbox;
        private System.Windows.Forms.TextBox name_textbox;
        private System.Windows.Forms.Label contacts_label;
        private System.Windows.Forms.Label address_label;
        private System.Windows.Forms.Label name_label;
        private System.Windows.Forms.Button hide_button;
        private System.Windows.Forms.Button search_button;
    }
}
namespace Department
{
    partial class supplier_search
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(supplier_search));
            this.control_groupBox = new System.Windows.Forms.GroupBox();
            this.address_textBox = new System.Windows.Forms.TextBox();
            this.id_textBox = new System.Windows.Forms.TextBox();
            this.name_textBox = new System.Windows.Forms.TextBox();
            this.contacts_textBox = new System.Windows.Forms.TextBox();
            this.address_label = new System.Windows.Forms.Label();
            this.name_label = new System.Windows.Forms.Label();
            this.contacts_label = new System.Windows.Forms.Label();
            this.id_label = new System.Windows.Forms.Label();
            this.search_button = new System.Windows.Forms.Button();
            this.clear_button = new System.Windows.Forms.Button();
            this.supplierData = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cancel_button = new System.Windows.Forms.Button();
            this.ok_button = new System.Windows.Forms.Button();
            this.control_groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.supplierData)).BeginInit();
            this.SuspendLayout();
            // 
            // control_groupBox
            // 
            this.control_groupBox.Controls.Add(this.address_textBox);
            this.control_groupBox.Controls.Add(this.id_textBox);
            this.control_groupBox.Controls.Add(this.name_textBox);
            this.control_groupBox.Controls.Add(this.contacts_textBox);
            this.control_groupBox.Controls.Add(this.address_label);
            this.control_groupBox.Controls.Add(this.name_label);
            this.control_groupBox.Controls.Add(this.contacts_label);
            this.control_groupBox.Controls.Add(this.id_label);
            this.control_groupBox.Controls.Add(this.search_button);
            this.control_groupBox.Controls.Add(this.clear_button);
            this.control_groupBox.Location = new System.Drawing.Point(13, 13);
            this.control_groupBox.Name = "control_groupBox";
            this.control_groupBox.Size = new System.Drawing.Size(784, 146);
            this.control_groupBox.TabIndex = 0;
            this.control_groupBox.TabStop = false;
            // 
            // address_textBox
            // 
            this.address_textBox.Location = new System.Drawing.Point(89, 86);
            this.address_textBox.Name = "address_textBox";
            this.address_textBox.Size = new System.Drawing.Size(168, 22);
            this.address_textBox.TabIndex = 9;
            // 
            // id_textBox
            // 
            this.id_textBox.Location = new System.Drawing.Point(89, 21);
            this.id_textBox.Name = "id_textBox";
            this.id_textBox.Size = new System.Drawing.Size(168, 22);
            this.id_textBox.TabIndex = 8;
            // 
            // name_textBox
            // 
            this.name_textBox.Location = new System.Drawing.Point(347, 21);
            this.name_textBox.Name = "name_textBox";
            this.name_textBox.Size = new System.Drawing.Size(271, 22);
            this.name_textBox.TabIndex = 7;
            // 
            // contacts_textBox
            // 
            this.contacts_textBox.Location = new System.Drawing.Point(347, 86);
            this.contacts_textBox.Name = "contacts_textBox";
            this.contacts_textBox.Size = new System.Drawing.Size(193, 22);
            this.contacts_textBox.TabIndex = 6;
            // 
            // address_label
            // 
            this.address_label.AutoSize = true;
            this.address_label.Location = new System.Drawing.Point(19, 89);
            this.address_label.Name = "address_label";
            this.address_label.Size = new System.Drawing.Size(64, 17);
            this.address_label.TabIndex = 5;
            this.address_label.Text = "Address:";
            // 
            // name_label
            // 
            this.name_label.AutoSize = true;
            this.name_label.Location = new System.Drawing.Point(274, 24);
            this.name_label.Name = "name_label";
            this.name_label.Size = new System.Drawing.Size(49, 17);
            this.name_label.TabIndex = 4;
            this.name_label.Text = "Name:";
            // 
            // contacts_label
            // 
            this.contacts_label.AutoSize = true;
            this.contacts_label.Location = new System.Drawing.Point(274, 89);
            this.contacts_label.Name = "contacts_label";
            this.contacts_label.Size = new System.Drawing.Size(67, 17);
            this.contacts_label.TabIndex = 3;
            this.contacts_label.Text = "Contacts:";
            // 
            // id_label
            // 
            this.id_label.AutoSize = true;
            this.id_label.Location = new System.Drawing.Point(19, 26);
            this.id_label.Name = "id_label";
            this.id_label.Size = new System.Drawing.Size(23, 17);
            this.id_label.TabIndex = 2;
            this.id_label.Text = "Id:";
            // 
            // search_button
            // 
            this.search_button.Location = new System.Drawing.Point(684, 96);
            this.search_button.Name = "search_button";
            this.search_button.Size = new System.Drawing.Size(100, 50);
            this.search_button.TabIndex = 1;
            this.search_button.Text = "search";
            this.search_button.UseVisualStyleBackColor = true;
            this.search_button.Click += new System.EventHandler(this.search_button_Click);
            // 
            // clear_button
            // 
            this.clear_button.Location = new System.Drawing.Point(548, 96);
            this.clear_button.Name = "clear_button";
            this.clear_button.Size = new System.Drawing.Size(100, 50);
            this.clear_button.TabIndex = 0;
            this.clear_button.Text = "clear";
            this.clear_button.UseVisualStyleBackColor = true;
            this.clear_button.Click += new System.EventHandler(this.clear_button_Click);
            // 
            // supplierData
            // 
            this.supplierData.AllowUserToAddRows = false;
            this.supplierData.AllowUserToDeleteRows = false;
            this.supplierData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.supplierData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.supplierData.Location = new System.Drawing.Point(13, 166);
            this.supplierData.Name = "supplierData";
            this.supplierData.ReadOnly = true;
            this.supplierData.RowHeadersWidth = 51;
            this.supplierData.RowTemplate.Height = 24;
            this.supplierData.Size = new System.Drawing.Size(784, 242);
            this.supplierData.TabIndex = 1;
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
            // cancel_button
            // 
            this.cancel_button.Location = new System.Drawing.Point(561, 428);
            this.cancel_button.Name = "cancel_button";
            this.cancel_button.Size = new System.Drawing.Size(100, 50);
            this.cancel_button.TabIndex = 2;
            this.cancel_button.Text = "cancel";
            this.cancel_button.UseVisualStyleBackColor = true;
            this.cancel_button.Click += new System.EventHandler(this.cancel_button_Click);
            // 
            // ok_button
            // 
            this.ok_button.Location = new System.Drawing.Point(697, 428);
            this.ok_button.Name = "ok_button";
            this.ok_button.Size = new System.Drawing.Size(100, 50);
            this.ok_button.TabIndex = 3;
            this.ok_button.Text = "ok";
            this.ok_button.UseVisualStyleBackColor = true;
            this.ok_button.Click += new System.EventHandler(this.ok_button_Click);
            // 
            // supplier_search
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(809, 490);
            this.Controls.Add(this.ok_button);
            this.Controls.Add(this.cancel_button);
            this.Controls.Add(this.supplierData);
            this.Controls.Add(this.control_groupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "supplier_search";
            this.Text = "search: supplier";
            this.control_groupBox.ResumeLayout(false);
            this.control_groupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.supplierData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox control_groupBox;
        private System.Windows.Forms.DataGridView supplierData;
        private System.Windows.Forms.Button cancel_button;
        private System.Windows.Forms.Button ok_button;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.Button search_button;
        private System.Windows.Forms.Button clear_button;
        private System.Windows.Forms.TextBox address_textBox;
        private System.Windows.Forms.TextBox id_textBox;
        private System.Windows.Forms.TextBox name_textBox;
        private System.Windows.Forms.TextBox contacts_textBox;
        private System.Windows.Forms.Label address_label;
        private System.Windows.Forms.Label name_label;
        private System.Windows.Forms.Label contacts_label;
        private System.Windows.Forms.Label id_label;
    }
}
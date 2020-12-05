namespace Department
{
    partial class delivery_form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(delivery_form));
            this.deliveryData = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fullData_button = new System.Windows.Forms.Button();
            this.control_panel = new System.Windows.Forms.Panel();
            this.delete_button = new System.Windows.Forms.Button();
            this.edit_button = new System.Windows.Forms.Button();
            this.add_button = new System.Windows.Forms.Button();
            this.control_groupBox = new System.Windows.Forms.GroupBox();
            this.hide_button = new System.Windows.Forms.Button();
            this.error_label = new System.Windows.Forms.Label();
            this.date = new System.Windows.Forms.DateTimePicker();
            this.count_textBox = new System.Windows.Forms.TextBox();
            this.storage_button = new System.Windows.Forms.Button();
            this.supplier_button = new System.Windows.Forms.Button();
            this.goods_button = new System.Windows.Forms.Button();
            this.worker_button = new System.Windows.Forms.Button();
            this.date_label = new System.Windows.Forms.Label();
            this.count_label = new System.Windows.Forms.Label();
            this.storage_label = new System.Windows.Forms.Label();
            this.supplier_label = new System.Windows.Forms.Label();
            this.goods_label = new System.Windows.Forms.Label();
            this.worker_label = new System.Windows.Forms.Label();
            this.save_button = new System.Windows.Forms.Button();
            this.clear_button = new System.Windows.Forms.Button();
            this.search_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.deliveryData)).BeginInit();
            this.control_panel.SuspendLayout();
            this.control_groupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // deliveryData
            // 
            this.deliveryData.AllowUserToAddRows = false;
            this.deliveryData.AllowUserToDeleteRows = false;
            this.deliveryData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.deliveryData.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.deliveryData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.deliveryData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column3,
            this.Column6,
            this.Column2,
            this.Column4,
            this.Column5,
            this.Column7});
            this.deliveryData.Location = new System.Drawing.Point(12, 12);
            this.deliveryData.Name = "deliveryData";
            this.deliveryData.ReadOnly = true;
            this.deliveryData.RowHeadersWidth = 51;
            this.deliveryData.RowTemplate.Height = 24;
            this.deliveryData.Size = new System.Drawing.Size(1138, 256);
            this.deliveryData.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Id";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 125;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Goods";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 125;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Count ";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 125;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Worker";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 125;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Storage";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 125;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Supplier";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 125;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Date";
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Width = 125;
            // 
            // fullData_button
            // 
            this.fullData_button.Location = new System.Drawing.Point(1156, 138);
            this.fullData_button.Name = "fullData_button";
            this.fullData_button.Size = new System.Drawing.Size(102, 130);
            this.fullData_button.TabIndex = 1;
            this.fullData_button.Text = "full information";
            this.fullData_button.UseVisualStyleBackColor = true;
            this.fullData_button.Click += new System.EventHandler(this.fullData_button_Click);
            // 
            // control_panel
            // 
            this.control_panel.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.control_panel.Controls.Add(this.delete_button);
            this.control_panel.Controls.Add(this.edit_button);
            this.control_panel.Controls.Add(this.add_button);
            this.control_panel.Location = new System.Drawing.Point(12, 274);
            this.control_panel.Name = "control_panel";
            this.control_panel.Size = new System.Drawing.Size(115, 216);
            this.control_panel.TabIndex = 2;
            // 
            // delete_button
            // 
            this.delete_button.Location = new System.Drawing.Point(2, 144);
            this.delete_button.Name = "delete_button";
            this.delete_button.Size = new System.Drawing.Size(111, 69);
            this.delete_button.TabIndex = 2;
            this.delete_button.Text = "delete";
            this.delete_button.UseVisualStyleBackColor = true;
            this.delete_button.Click += new System.EventHandler(this.delete_button_Click);
            // 
            // edit_button
            // 
            this.edit_button.Location = new System.Drawing.Point(2, 73);
            this.edit_button.Name = "edit_button";
            this.edit_button.Size = new System.Drawing.Size(111, 69);
            this.edit_button.TabIndex = 1;
            this.edit_button.Text = "edit";
            this.edit_button.UseVisualStyleBackColor = true;
            this.edit_button.Click += new System.EventHandler(this.edit_button_Click);
            // 
            // add_button
            // 
            this.add_button.Location = new System.Drawing.Point(2, 2);
            this.add_button.Name = "add_button";
            this.add_button.Size = new System.Drawing.Size(111, 69);
            this.add_button.TabIndex = 0;
            this.add_button.Text = "add";
            this.add_button.UseVisualStyleBackColor = true;
            this.add_button.Click += new System.EventHandler(this.add_button_Click);
            // 
            // control_groupBox
            // 
            this.control_groupBox.Controls.Add(this.hide_button);
            this.control_groupBox.Controls.Add(this.error_label);
            this.control_groupBox.Controls.Add(this.date);
            this.control_groupBox.Controls.Add(this.count_textBox);
            this.control_groupBox.Controls.Add(this.storage_button);
            this.control_groupBox.Controls.Add(this.supplier_button);
            this.control_groupBox.Controls.Add(this.goods_button);
            this.control_groupBox.Controls.Add(this.worker_button);
            this.control_groupBox.Controls.Add(this.date_label);
            this.control_groupBox.Controls.Add(this.count_label);
            this.control_groupBox.Controls.Add(this.storage_label);
            this.control_groupBox.Controls.Add(this.supplier_label);
            this.control_groupBox.Controls.Add(this.goods_label);
            this.control_groupBox.Controls.Add(this.worker_label);
            this.control_groupBox.Controls.Add(this.save_button);
            this.control_groupBox.Controls.Add(this.clear_button);
            this.control_groupBox.Location = new System.Drawing.Point(134, 274);
            this.control_groupBox.Name = "control_groupBox";
            this.control_groupBox.Size = new System.Drawing.Size(1124, 216);
            this.control_groupBox.TabIndex = 3;
            this.control_groupBox.TabStop = false;
            this.control_groupBox.Text = "groupBox";
            this.control_groupBox.Visible = false;
            // 
            // hide_button
            // 
            this.hide_button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("hide_button.BackgroundImage")));
            this.hide_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.hide_button.Location = new System.Drawing.Point(1085, 14);
            this.hide_button.Name = "hide_button";
            this.hide_button.Size = new System.Drawing.Size(30, 30);
            this.hide_button.TabIndex = 15;
            this.hide_button.UseVisualStyleBackColor = true;
            this.hide_button.Click += new System.EventHandler(this.hide_button_Click);
            // 
            // error_label
            // 
            this.error_label.AutoSize = true;
            this.error_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.error_label.ForeColor = System.Drawing.Color.Red;
            this.error_label.Location = new System.Drawing.Point(42, 24);
            this.error_label.Name = "error_label";
            this.error_label.Size = new System.Drawing.Size(151, 17);
            this.error_label.TabIndex = 14;
            this.error_label.Text = "Some fields are empty!";
            this.error_label.Visible = false;
            // 
            // date
            // 
            this.date.Location = new System.Drawing.Point(428, 166);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(200, 22);
            this.date.TabIndex = 13;
            // 
            // count_textBox
            // 
            this.count_textBox.Location = new System.Drawing.Point(428, 113);
            this.count_textBox.Name = "count_textBox";
            this.count_textBox.Size = new System.Drawing.Size(155, 22);
            this.count_textBox.TabIndex = 12;
            // 
            // storage_button
            // 
            this.storage_button.Location = new System.Drawing.Point(428, 49);
            this.storage_button.Name = "storage_button";
            this.storage_button.Size = new System.Drawing.Size(80, 40);
            this.storage_button.TabIndex = 11;
            this.storage_button.Text = "select";
            this.storage_button.UseVisualStyleBackColor = true;
            this.storage_button.Click += new System.EventHandler(this.storage_button_Click);
            // 
            // supplier_button
            // 
            this.supplier_button.Location = new System.Drawing.Point(109, 157);
            this.supplier_button.Name = "supplier_button";
            this.supplier_button.Size = new System.Drawing.Size(80, 40);
            this.supplier_button.TabIndex = 10;
            this.supplier_button.Text = "button3";
            this.supplier_button.UseVisualStyleBackColor = true;
            this.supplier_button.Click += new System.EventHandler(this.supplier_button_Click);
            // 
            // goods_button
            // 
            this.goods_button.Location = new System.Drawing.Point(109, 101);
            this.goods_button.Name = "goods_button";
            this.goods_button.Size = new System.Drawing.Size(80, 40);
            this.goods_button.TabIndex = 9;
            this.goods_button.Text = "select";
            this.goods_button.UseVisualStyleBackColor = true;
            this.goods_button.Click += new System.EventHandler(this.goods_button_Click);
            // 
            // worker_button
            // 
            this.worker_button.Location = new System.Drawing.Point(109, 45);
            this.worker_button.Name = "worker_button";
            this.worker_button.Size = new System.Drawing.Size(80, 40);
            this.worker_button.TabIndex = 8;
            this.worker_button.Text = "select";
            this.worker_button.UseVisualStyleBackColor = true;
            this.worker_button.Click += new System.EventHandler(this.worker_button_Click);
            // 
            // date_label
            // 
            this.date_label.AutoSize = true;
            this.date_label.Location = new System.Drawing.Point(363, 169);
            this.date_label.Name = "date_label";
            this.date_label.Size = new System.Drawing.Size(42, 17);
            this.date_label.TabIndex = 7;
            this.date_label.Text = "Date:";
            // 
            // count_label
            // 
            this.count_label.AutoSize = true;
            this.count_label.Location = new System.Drawing.Point(360, 113);
            this.count_label.Name = "count_label";
            this.count_label.Size = new System.Drawing.Size(49, 17);
            this.count_label.TabIndex = 6;
            this.count_label.Text = "Count:";
            // 
            // storage_label
            // 
            this.storage_label.AutoSize = true;
            this.storage_label.Location = new System.Drawing.Point(360, 61);
            this.storage_label.Name = "storage_label";
            this.storage_label.Size = new System.Drawing.Size(62, 17);
            this.storage_label.TabIndex = 5;
            this.storage_label.Text = "Storage:";
            // 
            // supplier_label
            // 
            this.supplier_label.AutoSize = true;
            this.supplier_label.Location = new System.Drawing.Point(39, 166);
            this.supplier_label.Name = "supplier_label";
            this.supplier_label.Size = new System.Drawing.Size(64, 17);
            this.supplier_label.TabIndex = 4;
            this.supplier_label.Text = "Supplier:";
            // 
            // goods_label
            // 
            this.goods_label.AutoSize = true;
            this.goods_label.Location = new System.Drawing.Point(39, 113);
            this.goods_label.Name = "goods_label";
            this.goods_label.Size = new System.Drawing.Size(54, 17);
            this.goods_label.TabIndex = 3;
            this.goods_label.Text = "Goods:";
            // 
            // worker_label
            // 
            this.worker_label.AutoSize = true;
            this.worker_label.Location = new System.Drawing.Point(39, 57);
            this.worker_label.Name = "worker_label";
            this.worker_label.Size = new System.Drawing.Size(58, 17);
            this.worker_label.TabIndex = 2;
            this.worker_label.Text = "Worker:";
            // 
            // save_button
            // 
            this.save_button.Location = new System.Drawing.Point(996, 153);
            this.save_button.Name = "save_button";
            this.save_button.Size = new System.Drawing.Size(100, 50);
            this.save_button.TabIndex = 1;
            this.save_button.Text = "save";
            this.save_button.UseVisualStyleBackColor = true;
            this.save_button.Click += new System.EventHandler(this.save_button_Click);
            // 
            // clear_button
            // 
            this.clear_button.Location = new System.Drawing.Point(828, 153);
            this.clear_button.Name = "clear_button";
            this.clear_button.Size = new System.Drawing.Size(100, 50);
            this.clear_button.TabIndex = 0;
            this.clear_button.Text = "clear";
            this.clear_button.UseVisualStyleBackColor = true;
            this.clear_button.Click += new System.EventHandler(this.clear_button_Click);
            // 
            // search_button
            // 
            this.search_button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("search_button.BackgroundImage")));
            this.search_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.search_button.Location = new System.Drawing.Point(1156, 13);
            this.search_button.Name = "search_button";
            this.search_button.Size = new System.Drawing.Size(102, 119);
            this.search_button.TabIndex = 4;
            this.search_button.UseVisualStyleBackColor = true;
            this.search_button.Click += new System.EventHandler(this.search_button_Click);
            // 
            // delivery_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1270, 502);
            this.Controls.Add(this.search_button);
            this.Controls.Add(this.control_groupBox);
            this.Controls.Add(this.control_panel);
            this.Controls.Add(this.fullData_button);
            this.Controls.Add(this.deliveryData);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "delivery_form";
            this.Text = "delivery";
            this.Load += new System.EventHandler(this.delivery_form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.deliveryData)).EndInit();
            this.control_panel.ResumeLayout(false);
            this.control_groupBox.ResumeLayout(false);
            this.control_groupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView deliveryData;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.Button fullData_button;
        private System.Windows.Forms.Panel control_panel;
        private System.Windows.Forms.Button delete_button;
        private System.Windows.Forms.Button edit_button;
        private System.Windows.Forms.Button add_button;
        private System.Windows.Forms.GroupBox control_groupBox;
        private System.Windows.Forms.Label count_label;
        private System.Windows.Forms.Label storage_label;
        private System.Windows.Forms.Label supplier_label;
        private System.Windows.Forms.Label goods_label;
        private System.Windows.Forms.Label worker_label;
        private System.Windows.Forms.Button save_button;
        private System.Windows.Forms.Button clear_button;
        private System.Windows.Forms.Button storage_button;
        private System.Windows.Forms.Button supplier_button;
        private System.Windows.Forms.Button goods_button;
        private System.Windows.Forms.Button worker_button;
        private System.Windows.Forms.Label date_label;
        private System.Windows.Forms.DateTimePicker date;
        private System.Windows.Forms.TextBox count_textBox;
        private System.Windows.Forms.Label error_label;
        private System.Windows.Forms.Button hide_button;
        private System.Windows.Forms.Button search_button;
    }
}
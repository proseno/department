namespace Department
{
    partial class delivery_search
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(delivery_search));
            this.control_groupBox = new System.Windows.Forms.GroupBox();
            this.on_off_button = new System.Windows.Forms.Button();
            this.storage_button = new System.Windows.Forms.Button();
            this.supplier_button = new System.Windows.Forms.Button();
            this.goods_button = new System.Windows.Forms.Button();
            this.workers_button = new System.Windows.Forms.Button();
            this.date = new System.Windows.Forms.DateTimePicker();
            this.id_textBox = new System.Windows.Forms.TextBox();
            this.count_textBox = new System.Windows.Forms.TextBox();
            this.search_button = new System.Windows.Forms.Button();
            this.clear_button = new System.Windows.Forms.Button();
            this.id_label = new System.Windows.Forms.Label();
            this.worker_label = new System.Windows.Forms.Label();
            this.goods_label = new System.Windows.Forms.Label();
            this.count_label = new System.Windows.Forms.Label();
            this.supplier_label = new System.Windows.Forms.Label();
            this.storage_label = new System.Windows.Forms.Label();
            this.date_label = new System.Windows.Forms.Label();
            this.deliveryData = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cancel_button = new System.Windows.Forms.Button();
            this.ok_button = new System.Windows.Forms.Button();
            this.fullinfo_button = new System.Windows.Forms.Button();
            this.control_groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.deliveryData)).BeginInit();
            this.SuspendLayout();
            // 
            // control_groupBox
            // 
            this.control_groupBox.Controls.Add(this.on_off_button);
            this.control_groupBox.Controls.Add(this.storage_button);
            this.control_groupBox.Controls.Add(this.supplier_button);
            this.control_groupBox.Controls.Add(this.goods_button);
            this.control_groupBox.Controls.Add(this.workers_button);
            this.control_groupBox.Controls.Add(this.date);
            this.control_groupBox.Controls.Add(this.id_textBox);
            this.control_groupBox.Controls.Add(this.count_textBox);
            this.control_groupBox.Controls.Add(this.search_button);
            this.control_groupBox.Controls.Add(this.clear_button);
            this.control_groupBox.Controls.Add(this.id_label);
            this.control_groupBox.Controls.Add(this.worker_label);
            this.control_groupBox.Controls.Add(this.goods_label);
            this.control_groupBox.Controls.Add(this.count_label);
            this.control_groupBox.Controls.Add(this.supplier_label);
            this.control_groupBox.Controls.Add(this.storage_label);
            this.control_groupBox.Controls.Add(this.date_label);
            this.control_groupBox.Location = new System.Drawing.Point(13, 13);
            this.control_groupBox.Name = "control_groupBox";
            this.control_groupBox.Size = new System.Drawing.Size(928, 150);
            this.control_groupBox.TabIndex = 0;
            this.control_groupBox.TabStop = false;
            // 
            // on_off_button
            // 
            this.on_off_button.Location = new System.Drawing.Point(871, 35);
            this.on_off_button.Name = "on_off_button";
            this.on_off_button.Size = new System.Drawing.Size(50, 25);
            this.on_off_button.TabIndex = 21;
            this.on_off_button.Text = "off";
            this.on_off_button.UseVisualStyleBackColor = true;
            this.on_off_button.Click += new System.EventHandler(this.on_off_button_Click);
            // 
            // storage_button
            // 
            this.storage_button.Location = new System.Drawing.Point(511, 92);
            this.storage_button.Name = "storage_button";
            this.storage_button.Size = new System.Drawing.Size(80, 40);
            this.storage_button.TabIndex = 20;
            this.storage_button.Text = "select";
            this.storage_button.UseVisualStyleBackColor = true;
            this.storage_button.Click += new System.EventHandler(this.storage_button_Click);
            this.storage_button.Paint += new System.Windows.Forms.PaintEventHandler(this.storage_button_Paint);
            // 
            // supplier_button
            // 
            this.supplier_button.Location = new System.Drawing.Point(511, 27);
            this.supplier_button.Name = "supplier_button";
            this.supplier_button.Size = new System.Drawing.Size(80, 40);
            this.supplier_button.TabIndex = 19;
            this.supplier_button.Text = "select";
            this.supplier_button.UseVisualStyleBackColor = true;
            this.supplier_button.Click += new System.EventHandler(this.supplier_button_Click);
            this.supplier_button.Paint += new System.Windows.Forms.PaintEventHandler(this.supplier_button_Paint);
            // 
            // goods_button
            // 
            this.goods_button.Location = new System.Drawing.Point(308, 26);
            this.goods_button.Name = "goods_button";
            this.goods_button.Size = new System.Drawing.Size(80, 40);
            this.goods_button.TabIndex = 18;
            this.goods_button.Text = "select";
            this.goods_button.UseVisualStyleBackColor = true;
            this.goods_button.Click += new System.EventHandler(this.goods_button_Click);
            this.goods_button.Paint += new System.Windows.Forms.PaintEventHandler(this.goods_button_Paint);
            // 
            // workers_button
            // 
            this.workers_button.Location = new System.Drawing.Point(123, 92);
            this.workers_button.Name = "workers_button";
            this.workers_button.Size = new System.Drawing.Size(80, 40);
            this.workers_button.TabIndex = 17;
            this.workers_button.Text = "select";
            this.workers_button.UseVisualStyleBackColor = true;
            this.workers_button.Click += new System.EventHandler(this.workers_button_Click);
            this.workers_button.Paint += new System.Windows.Forms.PaintEventHandler(this.workers_button_Paint);
            // 
            // date
            // 
            this.date.Location = new System.Drawing.Point(665, 36);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(200, 22);
            this.date.TabIndex = 16;
            // 
            // id_textBox
            // 
            this.id_textBox.Location = new System.Drawing.Point(71, 36);
            this.id_textBox.Name = "id_textBox";
            this.id_textBox.Size = new System.Drawing.Size(132, 22);
            this.id_textBox.TabIndex = 15;
            // 
            // count_textBox
            // 
            this.count_textBox.Location = new System.Drawing.Point(287, 101);
            this.count_textBox.Name = "count_textBox";
            this.count_textBox.Size = new System.Drawing.Size(125, 22);
            this.count_textBox.TabIndex = 14;
            // 
            // search_button
            // 
            this.search_button.Location = new System.Drawing.Point(828, 98);
            this.search_button.Name = "search_button";
            this.search_button.Size = new System.Drawing.Size(100, 50);
            this.search_button.TabIndex = 13;
            this.search_button.Text = "search";
            this.search_button.UseVisualStyleBackColor = true;
            this.search_button.Click += new System.EventHandler(this.search_button_Click);
            // 
            // clear_button
            // 
            this.clear_button.Location = new System.Drawing.Point(682, 98);
            this.clear_button.Name = "clear_button";
            this.clear_button.Size = new System.Drawing.Size(100, 50);
            this.clear_button.TabIndex = 12;
            this.clear_button.Text = "clear";
            this.clear_button.UseVisualStyleBackColor = true;
            this.clear_button.Click += new System.EventHandler(this.clear_button_Click);
            // 
            // id_label
            // 
            this.id_label.AutoSize = true;
            this.id_label.Location = new System.Drawing.Point(42, 39);
            this.id_label.Name = "id_label";
            this.id_label.Size = new System.Drawing.Size(23, 17);
            this.id_label.TabIndex = 5;
            this.id_label.Text = "Id:";
            // 
            // worker_label
            // 
            this.worker_label.AutoSize = true;
            this.worker_label.Location = new System.Drawing.Point(42, 104);
            this.worker_label.Name = "worker_label";
            this.worker_label.Size = new System.Drawing.Size(58, 17);
            this.worker_label.TabIndex = 6;
            this.worker_label.Text = "Worker:";
            // 
            // goods_label
            // 
            this.goods_label.AutoSize = true;
            this.goods_label.Location = new System.Drawing.Point(232, 39);
            this.goods_label.Name = "goods_label";
            this.goods_label.Size = new System.Drawing.Size(54, 17);
            this.goods_label.TabIndex = 7;
            this.goods_label.Text = "Goods:";
            // 
            // count_label
            // 
            this.count_label.AutoSize = true;
            this.count_label.Location = new System.Drawing.Point(232, 104);
            this.count_label.Name = "count_label";
            this.count_label.Size = new System.Drawing.Size(49, 17);
            this.count_label.TabIndex = 8;
            this.count_label.Text = "Count:";
            // 
            // supplier_label
            // 
            this.supplier_label.AutoSize = true;
            this.supplier_label.Location = new System.Drawing.Point(443, 39);
            this.supplier_label.Name = "supplier_label";
            this.supplier_label.Size = new System.Drawing.Size(64, 17);
            this.supplier_label.TabIndex = 9;
            this.supplier_label.Text = "Supplier:";
            // 
            // storage_label
            // 
            this.storage_label.AutoSize = true;
            this.storage_label.Location = new System.Drawing.Point(443, 104);
            this.storage_label.Name = "storage_label";
            this.storage_label.Size = new System.Drawing.Size(62, 17);
            this.storage_label.TabIndex = 10;
            this.storage_label.Text = "Storage:";
            // 
            // date_label
            // 
            this.date_label.AutoSize = true;
            this.date_label.Location = new System.Drawing.Point(619, 38);
            this.date_label.Name = "date_label";
            this.date_label.Size = new System.Drawing.Size(42, 17);
            this.date_label.TabIndex = 11;
            this.date_label.Text = "Date:";
            // 
            // deliveryData
            // 
            this.deliveryData.AllowUserToAddRows = false;
            this.deliveryData.AllowUserToDeleteRows = false;
            this.deliveryData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.deliveryData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column7,
            this.Column4,
            this.Column5,
            this.Column6});
            this.deliveryData.Location = new System.Drawing.Point(13, 170);
            this.deliveryData.Name = "deliveryData";
            this.deliveryData.ReadOnly = true;
            this.deliveryData.RowHeadersWidth = 51;
            this.deliveryData.RowTemplate.Height = 24;
            this.deliveryData.Size = new System.Drawing.Size(928, 264);
            this.deliveryData.TabIndex = 1;
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
            this.Column2.HeaderText = "Worker";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Goods";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 125;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Count";
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Width = 125;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Supplier";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 125;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Storage";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 125;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Date";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 125;
            // 
            // cancel_button
            // 
            this.cancel_button.Location = new System.Drawing.Point(695, 454);
            this.cancel_button.Name = "cancel_button";
            this.cancel_button.Size = new System.Drawing.Size(100, 50);
            this.cancel_button.TabIndex = 2;
            this.cancel_button.Text = "cancel";
            this.cancel_button.UseVisualStyleBackColor = true;
            this.cancel_button.Click += new System.EventHandler(this.cancel_button_Click);
            // 
            // ok_button
            // 
            this.ok_button.Location = new System.Drawing.Point(841, 454);
            this.ok_button.Name = "ok_button";
            this.ok_button.Size = new System.Drawing.Size(100, 50);
            this.ok_button.TabIndex = 3;
            this.ok_button.Text = "ok";
            this.ok_button.UseVisualStyleBackColor = true;
            this.ok_button.Click += new System.EventHandler(this.ok_button_Click);
            // 
            // fullinfo_button
            // 
            this.fullinfo_button.Location = new System.Drawing.Point(13, 454);
            this.fullinfo_button.Name = "fullinfo_button";
            this.fullinfo_button.Size = new System.Drawing.Size(100, 50);
            this.fullinfo_button.TabIndex = 4;
            this.fullinfo_button.Text = "full information";
            this.fullinfo_button.UseVisualStyleBackColor = true;
            this.fullinfo_button.Click += new System.EventHandler(this.fullinfo_button_Click);
            // 
            // delivery_search
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(953, 516);
            this.Controls.Add(this.fullinfo_button);
            this.Controls.Add(this.ok_button);
            this.Controls.Add(this.cancel_button);
            this.Controls.Add(this.deliveryData);
            this.Controls.Add(this.control_groupBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "delivery_search";
            this.Text = "search: delivery";
            this.control_groupBox.ResumeLayout(false);
            this.control_groupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.deliveryData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox control_groupBox;
        private System.Windows.Forms.DataGridView deliveryData;
        private System.Windows.Forms.Button cancel_button;
        private System.Windows.Forms.Button ok_button;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.Button fullinfo_button;
        private System.Windows.Forms.Button search_button;
        private System.Windows.Forms.Button clear_button;
        private System.Windows.Forms.Label id_label;
        private System.Windows.Forms.Label worker_label;
        private System.Windows.Forms.Label goods_label;
        private System.Windows.Forms.Label count_label;
        private System.Windows.Forms.Label supplier_label;
        private System.Windows.Forms.Label storage_label;
        private System.Windows.Forms.Label date_label;
        private System.Windows.Forms.DateTimePicker date;
        private System.Windows.Forms.TextBox id_textBox;
        private System.Windows.Forms.TextBox count_textBox;
        private System.Windows.Forms.Button on_off_button;
        private System.Windows.Forms.Button storage_button;
        private System.Windows.Forms.Button supplier_button;
        private System.Windows.Forms.Button goods_button;
        private System.Windows.Forms.Button workers_button;
    }
}
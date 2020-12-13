namespace Department
{
    partial class goods_search
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(goods_search));
            this.control_groupBox = new System.Windows.Forms.GroupBox();
            this.name_textBox = new System.Windows.Forms.TextBox();
            this.id_textBox = new System.Windows.Forms.TextBox();
            this.price_textBox = new System.Windows.Forms.TextBox();
            this.price_label = new System.Windows.Forms.Label();
            this.name_label = new System.Windows.Forms.Label();
            this.id_label = new System.Windows.Forms.Label();
            this.clear_button = new System.Windows.Forms.Button();
            this.search_button = new System.Windows.Forms.Button();
            this.goodsData = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cancel_button = new System.Windows.Forms.Button();
            this.ok_button = new System.Windows.Forms.Button();
            this.control_groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.goodsData)).BeginInit();
            this.SuspendLayout();
            // 
            // control_groupBox
            // 
            this.control_groupBox.Controls.Add(this.name_textBox);
            this.control_groupBox.Controls.Add(this.id_textBox);
            this.control_groupBox.Controls.Add(this.price_textBox);
            this.control_groupBox.Controls.Add(this.price_label);
            this.control_groupBox.Controls.Add(this.name_label);
            this.control_groupBox.Controls.Add(this.id_label);
            this.control_groupBox.Controls.Add(this.clear_button);
            this.control_groupBox.Controls.Add(this.search_button);
            this.control_groupBox.Location = new System.Drawing.Point(13, 13);
            this.control_groupBox.Name = "control_groupBox";
            this.control_groupBox.Size = new System.Drawing.Size(775, 134);
            this.control_groupBox.TabIndex = 0;
            this.control_groupBox.TabStop = false;
            // 
            // name_textBox
            // 
            this.name_textBox.Location = new System.Drawing.Point(92, 83);
            this.name_textBox.Name = "name_textBox";
            this.name_textBox.Size = new System.Drawing.Size(342, 22);
            this.name_textBox.TabIndex = 9;
            // 
            // id_textBox
            // 
            this.id_textBox.Location = new System.Drawing.Point(92, 30);
            this.id_textBox.Name = "id_textBox";
            this.id_textBox.Size = new System.Drawing.Size(189, 22);
            this.id_textBox.TabIndex = 8;
            // 
            // price_textBox
            // 
            this.price_textBox.Location = new System.Drawing.Point(355, 30);
            this.price_textBox.Name = "price_textBox";
            this.price_textBox.Size = new System.Drawing.Size(168, 22);
            this.price_textBox.TabIndex = 7;
            // 
            // price_label
            // 
            this.price_label.AutoSize = true;
            this.price_label.Location = new System.Drawing.Point(305, 30);
            this.price_label.Name = "price_label";
            this.price_label.Size = new System.Drawing.Size(44, 17);
            this.price_label.TabIndex = 4;
            this.price_label.Text = "Price:";
            // 
            // name_label
            // 
            this.name_label.AutoSize = true;
            this.name_label.Location = new System.Drawing.Point(37, 85);
            this.name_label.Name = "name_label";
            this.name_label.Size = new System.Drawing.Size(49, 17);
            this.name_label.TabIndex = 5;
            this.name_label.Text = "Name:";
            // 
            // id_label
            // 
            this.id_label.AutoSize = true;
            this.id_label.Location = new System.Drawing.Point(37, 30);
            this.id_label.Name = "id_label";
            this.id_label.Size = new System.Drawing.Size(23, 17);
            this.id_label.TabIndex = 6;
            this.id_label.Text = "Id:";
            // 
            // clear_button
            // 
            this.clear_button.Location = new System.Drawing.Point(518, 81);
            this.clear_button.Name = "clear_button";
            this.clear_button.Size = new System.Drawing.Size(100, 50);
            this.clear_button.TabIndex = 1;
            this.clear_button.Text = "clear";
            this.clear_button.UseVisualStyleBackColor = true;
            this.clear_button.Click += new System.EventHandler(this.clear_button_Click);
            // 
            // search_button
            // 
            this.search_button.Location = new System.Drawing.Point(675, 81);
            this.search_button.Name = "search_button";
            this.search_button.Size = new System.Drawing.Size(100, 50);
            this.search_button.TabIndex = 0;
            this.search_button.Text = "search";
            this.search_button.UseVisualStyleBackColor = true;
            this.search_button.Click += new System.EventHandler(this.search_button_Click);
            // 
            // goodsData
            // 
            this.goodsData.AllowUserToAddRows = false;
            this.goodsData.AllowUserToDeleteRows = false;
            this.goodsData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.goodsData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.goodsData.Location = new System.Drawing.Point(12, 153);
            this.goodsData.Name = "goodsData";
            this.goodsData.ReadOnly = true;
            this.goodsData.RowHeadersWidth = 51;
            this.goodsData.RowTemplate.Height = 24;
            this.goodsData.Size = new System.Drawing.Size(776, 217);
            this.goodsData.TabIndex = 1;
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
            this.Column3.HeaderText = "Price";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 125;
            // 
            // cancel_button
            // 
            this.cancel_button.Location = new System.Drawing.Point(531, 388);
            this.cancel_button.Name = "cancel_button";
            this.cancel_button.Size = new System.Drawing.Size(100, 50);
            this.cancel_button.TabIndex = 2;
            this.cancel_button.Text = "cancel";
            this.cancel_button.UseVisualStyleBackColor = true;
            this.cancel_button.Click += new System.EventHandler(this.cancel_button_Click);
            // 
            // ok_button
            // 
            this.ok_button.Location = new System.Drawing.Point(688, 388);
            this.ok_button.Name = "ok_button";
            this.ok_button.Size = new System.Drawing.Size(100, 50);
            this.ok_button.TabIndex = 3;
            this.ok_button.Text = "ok";
            this.ok_button.UseVisualStyleBackColor = true;
            this.ok_button.Click += new System.EventHandler(this.ok_button_Click);
            // 
            // goods_search
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ok_button);
            this.Controls.Add(this.cancel_button);
            this.Controls.Add(this.goodsData);
            this.Controls.Add(this.control_groupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "goods_search";
            this.Text = "search: goods";
            this.control_groupBox.ResumeLayout(false);
            this.control_groupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.goodsData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox control_groupBox;
        private System.Windows.Forms.DataGridView goodsData;
        private System.Windows.Forms.Button cancel_button;
        private System.Windows.Forms.Button ok_button;
        private System.Windows.Forms.Button clear_button;
        private System.Windows.Forms.Button search_button;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.TextBox name_textBox;
        private System.Windows.Forms.TextBox id_textBox;
        private System.Windows.Forms.TextBox price_textBox;
        private System.Windows.Forms.Label price_label;
        private System.Windows.Forms.Label name_label;
        private System.Windows.Forms.Label id_label;
    }
}
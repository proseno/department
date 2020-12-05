namespace Department
{
    partial class goods_form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(goods_form));
            this.goodsData = new System.Windows.Forms.DataGridView();
            this.control_panel = new System.Windows.Forms.Panel();
            this.delete_button = new System.Windows.Forms.Button();
            this.edit_button = new System.Windows.Forms.Button();
            this.add_button = new System.Windows.Forms.Button();
            this.control_groupBox = new System.Windows.Forms.GroupBox();
            this.hide_button = new System.Windows.Forms.Button();
            this.error_label = new System.Windows.Forms.Label();
            this.save_button = new System.Windows.Forms.Button();
            this.clear_button = new System.Windows.Forms.Button();
            this.price_textbox = new System.Windows.Forms.TextBox();
            this.name_textbox = new System.Windows.Forms.TextBox();
            this.price_label = new System.Windows.Forms.Label();
            this.name_label = new System.Windows.Forms.Label();
            this.search_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.goodsData)).BeginInit();
            this.control_panel.SuspendLayout();
            this.control_groupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // goodsData
            // 
            this.goodsData.AllowUserToAddRows = false;
            this.goodsData.AllowUserToDeleteRows = false;
            this.goodsData.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.goodsData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.goodsData.Location = new System.Drawing.Point(13, 13);
            this.goodsData.Name = "goodsData";
            this.goodsData.ReadOnly = true;
            this.goodsData.RowHeadersWidth = 51;
            this.goodsData.RowTemplate.Height = 24;
            this.goodsData.Size = new System.Drawing.Size(757, 224);
            this.goodsData.TabIndex = 0;
            // 
            // control_panel
            // 
            this.control_panel.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.control_panel.Controls.Add(this.delete_button);
            this.control_panel.Controls.Add(this.edit_button);
            this.control_panel.Controls.Add(this.add_button);
            this.control_panel.Location = new System.Drawing.Point(13, 244);
            this.control_panel.Name = "control_panel";
            this.control_panel.Size = new System.Drawing.Size(142, 194);
            this.control_panel.TabIndex = 1;
            // 
            // delete_button
            // 
            this.delete_button.Location = new System.Drawing.Point(2, 129);
            this.delete_button.Name = "delete_button";
            this.delete_button.Size = new System.Drawing.Size(138, 63);
            this.delete_button.TabIndex = 2;
            this.delete_button.Text = "delete";
            this.delete_button.UseVisualStyleBackColor = true;
            this.delete_button.Click += new System.EventHandler(this.delete_button_Click);
            // 
            // edit_button
            // 
            this.edit_button.Location = new System.Drawing.Point(2, 65);
            this.edit_button.Name = "edit_button";
            this.edit_button.Size = new System.Drawing.Size(138, 63);
            this.edit_button.TabIndex = 1;
            this.edit_button.Text = "edit";
            this.edit_button.UseVisualStyleBackColor = true;
            this.edit_button.Click += new System.EventHandler(this.edit_button_Click);
            // 
            // add_button
            // 
            this.add_button.Location = new System.Drawing.Point(2, 1);
            this.add_button.Name = "add_button";
            this.add_button.Size = new System.Drawing.Size(138, 63);
            this.add_button.TabIndex = 0;
            this.add_button.Text = "add";
            this.add_button.UseVisualStyleBackColor = true;
            this.add_button.Click += new System.EventHandler(this.add_button_Click);
            // 
            // control_groupBox
            // 
            this.control_groupBox.Controls.Add(this.hide_button);
            this.control_groupBox.Controls.Add(this.error_label);
            this.control_groupBox.Controls.Add(this.save_button);
            this.control_groupBox.Controls.Add(this.clear_button);
            this.control_groupBox.Controls.Add(this.price_textbox);
            this.control_groupBox.Controls.Add(this.name_textbox);
            this.control_groupBox.Controls.Add(this.price_label);
            this.control_groupBox.Controls.Add(this.name_label);
            this.control_groupBox.Location = new System.Drawing.Point(162, 245);
            this.control_groupBox.Name = "control_groupBox";
            this.control_groupBox.Size = new System.Drawing.Size(674, 193);
            this.control_groupBox.TabIndex = 2;
            this.control_groupBox.TabStop = false;
            this.control_groupBox.Text = "groupBox";
            this.control_groupBox.Visible = false;
            // 
            // hide_button
            // 
            this.hide_button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("hide_button.BackgroundImage")));
            this.hide_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.hide_button.Location = new System.Drawing.Point(627, 21);
            this.hide_button.Name = "hide_button";
            this.hide_button.Size = new System.Drawing.Size(30, 30);
            this.hide_button.TabIndex = 7;
            this.hide_button.UseVisualStyleBackColor = true;
            this.hide_button.Click += new System.EventHandler(this.hide_button_Click);
            // 
            // error_label
            // 
            this.error_label.AutoSize = true;
            this.error_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.error_label.ForeColor = System.Drawing.Color.Red;
            this.error_label.Location = new System.Drawing.Point(18, 23);
            this.error_label.Name = "error_label";
            this.error_label.Size = new System.Drawing.Size(151, 17);
            this.error_label.TabIndex = 6;
            this.error_label.Text = "Some fields are empty!";
            this.error_label.Visible = false;
            // 
            // save_button
            // 
            this.save_button.Location = new System.Drawing.Point(557, 127);
            this.save_button.Name = "save_button";
            this.save_button.Size = new System.Drawing.Size(100, 50);
            this.save_button.TabIndex = 5;
            this.save_button.Text = "save";
            this.save_button.UseVisualStyleBackColor = true;
            this.save_button.Click += new System.EventHandler(this.save_button_Click);
            // 
            // clear_button
            // 
            this.clear_button.Location = new System.Drawing.Point(415, 127);
            this.clear_button.Name = "clear_button";
            this.clear_button.Size = new System.Drawing.Size(100, 50);
            this.clear_button.TabIndex = 4;
            this.clear_button.Text = "clear";
            this.clear_button.UseVisualStyleBackColor = true;
            this.clear_button.Click += new System.EventHandler(this.clear_button_Click);
            // 
            // price_textbox
            // 
            this.price_textbox.Location = new System.Drawing.Point(70, 105);
            this.price_textbox.Name = "price_textbox";
            this.price_textbox.Size = new System.Drawing.Size(284, 22);
            this.price_textbox.TabIndex = 3;
            // 
            // name_textbox
            // 
            this.name_textbox.Location = new System.Drawing.Point(70, 43);
            this.name_textbox.Name = "name_textbox";
            this.name_textbox.Size = new System.Drawing.Size(284, 22);
            this.name_textbox.TabIndex = 2;
            // 
            // price_label
            // 
            this.price_label.AutoSize = true;
            this.price_label.Location = new System.Drawing.Point(18, 105);
            this.price_label.Name = "price_label";
            this.price_label.Size = new System.Drawing.Size(44, 17);
            this.price_label.TabIndex = 1;
            this.price_label.Text = "Price:";
            // 
            // name_label
            // 
            this.name_label.AutoSize = true;
            this.name_label.Location = new System.Drawing.Point(18, 46);
            this.name_label.Name = "name_label";
            this.name_label.Size = new System.Drawing.Size(49, 17);
            this.name_label.TabIndex = 0;
            this.name_label.Text = "Name:";
            // 
            // search_button
            // 
            this.search_button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("search_button.BackgroundImage")));
            this.search_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.search_button.Location = new System.Drawing.Point(776, 13);
            this.search_button.Name = "search_button";
            this.search_button.Size = new System.Drawing.Size(60, 60);
            this.search_button.TabIndex = 3;
            this.search_button.UseVisualStyleBackColor = true;
            this.search_button.Click += new System.EventHandler(this.search_button_Click);
            // 
            // goods_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(848, 450);
            this.Controls.Add(this.search_button);
            this.Controls.Add(this.control_groupBox);
            this.Controls.Add(this.control_panel);
            this.Controls.Add(this.goodsData);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "goods_form";
            this.Text = "goods";
            this.Load += new System.EventHandler(this.goods_form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.goodsData)).EndInit();
            this.control_panel.ResumeLayout(false);
            this.control_groupBox.ResumeLayout(false);
            this.control_groupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView goodsData;
        private System.Windows.Forms.Panel control_panel;
        private System.Windows.Forms.Button delete_button;
        private System.Windows.Forms.Button edit_button;
        private System.Windows.Forms.Button add_button;
        private System.Windows.Forms.GroupBox control_groupBox;
        private System.Windows.Forms.Button save_button;
        private System.Windows.Forms.Button clear_button;
        private System.Windows.Forms.TextBox price_textbox;
        private System.Windows.Forms.TextBox name_textbox;
        private System.Windows.Forms.Label price_label;
        private System.Windows.Forms.Label name_label;
        private System.Windows.Forms.Label error_label;
        private System.Windows.Forms.Button hide_button;
        private System.Windows.Forms.Button search_button;
    }
}
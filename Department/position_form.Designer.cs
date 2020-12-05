namespace Department
{
    partial class position_form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(position_form));
            this.positionData = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.control_panel = new System.Windows.Forms.Panel();
            this.delete_button = new System.Windows.Forms.Button();
            this.edit_button = new System.Windows.Forms.Button();
            this.add_button = new System.Windows.Forms.Button();
            this.controls_groupBox = new System.Windows.Forms.GroupBox();
            this.hide_button = new System.Windows.Forms.Button();
            this.salary_numerics = new System.Windows.Forms.NumericUpDown();
            this.error_label = new System.Windows.Forms.Label();
            this.clear_button = new System.Windows.Forms.Button();
            this.save_button = new System.Windows.Forms.Button();
            this.name_textbox = new System.Windows.Forms.TextBox();
            this.name_label = new System.Windows.Forms.Label();
            this.salary_label = new System.Windows.Forms.Label();
            this.search_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.positionData)).BeginInit();
            this.control_panel.SuspendLayout();
            this.controls_groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.salary_numerics)).BeginInit();
            this.SuspendLayout();
            // 
            // positionData
            // 
            this.positionData.AllowUserToAddRows = false;
            this.positionData.AllowUserToDeleteRows = false;
            this.positionData.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.positionData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.positionData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.positionData.Location = new System.Drawing.Point(12, 12);
            this.positionData.Name = "positionData";
            this.positionData.ReadOnly = true;
            this.positionData.RowHeadersWidth = 51;
            this.positionData.RowTemplate.Height = 24;
            this.positionData.Size = new System.Drawing.Size(614, 196);
            this.positionData.TabIndex = 0;
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
            this.Column3.HeaderText = "Salary";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 125;
            // 
            // control_panel
            // 
            this.control_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(171)))), ((int)(((byte)(171)))));
            this.control_panel.Controls.Add(this.delete_button);
            this.control_panel.Controls.Add(this.edit_button);
            this.control_panel.Controls.Add(this.add_button);
            this.control_panel.Location = new System.Drawing.Point(12, 214);
            this.control_panel.Name = "control_panel";
            this.control_panel.Size = new System.Drawing.Size(100, 156);
            this.control_panel.TabIndex = 1;
            // 
            // delete_button
            // 
            this.delete_button.Location = new System.Drawing.Point(2, 104);
            this.delete_button.Name = "delete_button";
            this.delete_button.Size = new System.Drawing.Size(96, 50);
            this.delete_button.TabIndex = 3;
            this.delete_button.Text = "delete";
            this.delete_button.UseVisualStyleBackColor = true;
            this.delete_button.Click += new System.EventHandler(this.delete_button_Click);
            // 
            // edit_button
            // 
            this.edit_button.Location = new System.Drawing.Point(2, 53);
            this.edit_button.Name = "edit_button";
            this.edit_button.Size = new System.Drawing.Size(96, 50);
            this.edit_button.TabIndex = 2;
            this.edit_button.Text = "edit";
            this.edit_button.UseVisualStyleBackColor = true;
            this.edit_button.Click += new System.EventHandler(this.edit_button_Click);
            // 
            // add_button
            // 
            this.add_button.Location = new System.Drawing.Point(2, 3);
            this.add_button.Name = "add_button";
            this.add_button.Size = new System.Drawing.Size(96, 50);
            this.add_button.TabIndex = 2;
            this.add_button.Text = "add";
            this.add_button.UseVisualStyleBackColor = true;
            this.add_button.Click += new System.EventHandler(this.add_button_Click);
            // 
            // controls_groupBox
            // 
            this.controls_groupBox.Controls.Add(this.hide_button);
            this.controls_groupBox.Controls.Add(this.salary_numerics);
            this.controls_groupBox.Controls.Add(this.error_label);
            this.controls_groupBox.Controls.Add(this.clear_button);
            this.controls_groupBox.Controls.Add(this.save_button);
            this.controls_groupBox.Controls.Add(this.name_textbox);
            this.controls_groupBox.Controls.Add(this.name_label);
            this.controls_groupBox.Controls.Add(this.salary_label);
            this.controls_groupBox.Location = new System.Drawing.Point(118, 214);
            this.controls_groupBox.Name = "controls_groupBox";
            this.controls_groupBox.Size = new System.Drawing.Size(568, 156);
            this.controls_groupBox.TabIndex = 2;
            this.controls_groupBox.TabStop = false;
            this.controls_groupBox.Text = "groupBox";
            this.controls_groupBox.Visible = false;
            // 
            // hide_button
            // 
            this.hide_button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("hide_button.BackgroundImage")));
            this.hide_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.hide_button.Location = new System.Drawing.Point(523, 15);
            this.hide_button.Name = "hide_button";
            this.hide_button.Size = new System.Drawing.Size(30, 30);
            this.hide_button.TabIndex = 11;
            this.hide_button.UseVisualStyleBackColor = true;
            this.hide_button.Click += new System.EventHandler(this.hide_button_Click);
            // 
            // salary_numerics
            // 
            this.salary_numerics.Location = new System.Drawing.Point(70, 94);
            this.salary_numerics.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.salary_numerics.Name = "salary_numerics";
            this.salary_numerics.Size = new System.Drawing.Size(260, 22);
            this.salary_numerics.TabIndex = 10;
            this.salary_numerics.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.salary_numerics.ThousandsSeparator = true;
            // 
            // error_label
            // 
            this.error_label.AutoSize = true;
            this.error_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.error_label.ForeColor = System.Drawing.Color.Red;
            this.error_label.Location = new System.Drawing.Point(12, 22);
            this.error_label.Name = "error_label";
            this.error_label.Size = new System.Drawing.Size(151, 17);
            this.error_label.TabIndex = 9;
            this.error_label.Text = "Some fields are empty!";
            this.error_label.Visible = false;
            // 
            // clear_button
            // 
            this.clear_button.Location = new System.Drawing.Point(336, 100);
            this.clear_button.Name = "clear_button";
            this.clear_button.Size = new System.Drawing.Size(100, 50);
            this.clear_button.TabIndex = 8;
            this.clear_button.Text = "clear";
            this.clear_button.UseVisualStyleBackColor = true;
            this.clear_button.Click += new System.EventHandler(this.clear_button_Click);
            // 
            // save_button
            // 
            this.save_button.Location = new System.Drawing.Point(456, 100);
            this.save_button.Name = "save_button";
            this.save_button.Size = new System.Drawing.Size(100, 50);
            this.save_button.TabIndex = 7;
            this.save_button.Text = "save";
            this.save_button.UseVisualStyleBackColor = true;
            this.save_button.Click += new System.EventHandler(this.save_button_Click);
            // 
            // name_textbox
            // 
            this.name_textbox.Location = new System.Drawing.Point(68, 42);
            this.name_textbox.Name = "name_textbox";
            this.name_textbox.Size = new System.Drawing.Size(262, 22);
            this.name_textbox.TabIndex = 5;
            // 
            // name_label
            // 
            this.name_label.AutoSize = true;
            this.name_label.Location = new System.Drawing.Point(12, 42);
            this.name_label.Name = "name_label";
            this.name_label.Size = new System.Drawing.Size(49, 17);
            this.name_label.TabIndex = 3;
            this.name_label.Text = "Name:";
            // 
            // salary_label
            // 
            this.salary_label.AutoSize = true;
            this.salary_label.Location = new System.Drawing.Point(12, 96);
            this.salary_label.Name = "salary_label";
            this.salary_label.Size = new System.Drawing.Size(52, 17);
            this.salary_label.TabIndex = 4;
            this.salary_label.Text = "Salary:";
            // 
            // search_button
            // 
            this.search_button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("search_button.BackgroundImage")));
            this.search_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.search_button.Location = new System.Drawing.Point(636, 12);
            this.search_button.Name = "search_button";
            this.search_button.Size = new System.Drawing.Size(50, 50);
            this.search_button.TabIndex = 3;
            this.search_button.UseVisualStyleBackColor = true;
            this.search_button.Click += new System.EventHandler(this.search_button_Click);
            // 
            // position_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(698, 381);
            this.Controls.Add(this.search_button);
            this.Controls.Add(this.controls_groupBox);
            this.Controls.Add(this.control_panel);
            this.Controls.Add(this.positionData);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "position_form";
            this.Text = "position";
            this.Load += new System.EventHandler(this.position_form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.positionData)).EndInit();
            this.control_panel.ResumeLayout(false);
            this.controls_groupBox.ResumeLayout(false);
            this.controls_groupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.salary_numerics)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView positionData;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.Panel control_panel;
        private System.Windows.Forms.Button add_button;
        private System.Windows.Forms.Button delete_button;
        private System.Windows.Forms.Button edit_button;
        private System.Windows.Forms.GroupBox controls_groupBox;
        private System.Windows.Forms.TextBox name_textbox;
        private System.Windows.Forms.Label name_label;
        private System.Windows.Forms.Label salary_label;
        private System.Windows.Forms.Button clear_button;
        private System.Windows.Forms.Button save_button;
        private System.Windows.Forms.Label error_label;
        private System.Windows.Forms.NumericUpDown salary_numerics;
        private System.Windows.Forms.Button hide_button;
        private System.Windows.Forms.Button search_button;
    }
}
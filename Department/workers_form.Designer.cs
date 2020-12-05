namespace Department
{
    partial class workers_form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(workers_form));
            this.workersData = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fullInfo_button = new System.Windows.Forms.Button();
            this.control_panel = new System.Windows.Forms.Panel();
            this.delete_button = new System.Windows.Forms.Button();
            this.edit_button = new System.Windows.Forms.Button();
            this.add_button = new System.Windows.Forms.Button();
            this.control_groupBox = new System.Windows.Forms.GroupBox();
            this.hide_button = new System.Windows.Forms.Button();
            this.error_label = new System.Windows.Forms.Label();
            this.cech_button = new System.Windows.Forms.Button();
            this.position_button = new System.Windows.Forms.Button();
            this.person_button = new System.Windows.Forms.Button();
            this.tillnow_button = new System.Windows.Forms.Button();
            this.or_label = new System.Windows.Forms.Label();
            this.end_date = new System.Windows.Forms.DateTimePicker();
            this.start_date = new System.Windows.Forms.DateTimePicker();
            this.end_label = new System.Windows.Forms.Label();
            this.start_label = new System.Windows.Forms.Label();
            this.cech_label = new System.Windows.Forms.Label();
            this.position_label = new System.Windows.Forms.Label();
            this.person_label = new System.Windows.Forms.Label();
            this.clear_button = new System.Windows.Forms.Button();
            this.save_button = new System.Windows.Forms.Button();
            this.search_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.workersData)).BeginInit();
            this.control_panel.SuspendLayout();
            this.control_groupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // workersData
            // 
            this.workersData.AllowUserToAddRows = false;
            this.workersData.AllowUserToDeleteRows = false;
            this.workersData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.workersData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.workersData.Location = new System.Drawing.Point(13, 13);
            this.workersData.Name = "workersData";
            this.workersData.ReadOnly = true;
            this.workersData.RowHeadersWidth = 51;
            this.workersData.RowTemplate.Height = 24;
            this.workersData.Size = new System.Drawing.Size(1025, 294);
            this.workersData.TabIndex = 0;
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
            this.Column3.HeaderText = "Position";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 125;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Cech";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 125;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Start";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 125;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "End";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 125;
            // 
            // fullInfo_button
            // 
            this.fullInfo_button.Location = new System.Drawing.Point(1044, 150);
            this.fullInfo_button.Name = "fullInfo_button";
            this.fullInfo_button.Size = new System.Drawing.Size(88, 157);
            this.fullInfo_button.TabIndex = 1;
            this.fullInfo_button.Text = "full information";
            this.fullInfo_button.UseVisualStyleBackColor = true;
            this.fullInfo_button.Click += new System.EventHandler(this.fullInfo_button_Click);
            // 
            // control_panel
            // 
            this.control_panel.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.control_panel.Controls.Add(this.delete_button);
            this.control_panel.Controls.Add(this.edit_button);
            this.control_panel.Controls.Add(this.add_button);
            this.control_panel.Location = new System.Drawing.Point(13, 314);
            this.control_panel.Name = "control_panel";
            this.control_panel.Size = new System.Drawing.Size(150, 227);
            this.control_panel.TabIndex = 2;
            // 
            // delete_button
            // 
            this.delete_button.Location = new System.Drawing.Point(2, 150);
            this.delete_button.Name = "delete_button";
            this.delete_button.Size = new System.Drawing.Size(146, 74);
            this.delete_button.TabIndex = 2;
            this.delete_button.Text = "delete";
            this.delete_button.UseVisualStyleBackColor = true;
            this.delete_button.Click += new System.EventHandler(this.delete_button_Click);
            // 
            // edit_button
            // 
            this.edit_button.Location = new System.Drawing.Point(2, 76);
            this.edit_button.Name = "edit_button";
            this.edit_button.Size = new System.Drawing.Size(146, 74);
            this.edit_button.TabIndex = 1;
            this.edit_button.Text = "edit";
            this.edit_button.UseVisualStyleBackColor = true;
            this.edit_button.Click += new System.EventHandler(this.edit_button_Click);
            // 
            // add_button
            // 
            this.add_button.Location = new System.Drawing.Point(2, 2);
            this.add_button.Name = "add_button";
            this.add_button.Size = new System.Drawing.Size(146, 74);
            this.add_button.TabIndex = 0;
            this.add_button.Text = "add";
            this.add_button.UseVisualStyleBackColor = true;
            this.add_button.Click += new System.EventHandler(this.add_button_Click);
            // 
            // control_groupBox
            // 
            this.control_groupBox.Controls.Add(this.hide_button);
            this.control_groupBox.Controls.Add(this.error_label);
            this.control_groupBox.Controls.Add(this.cech_button);
            this.control_groupBox.Controls.Add(this.position_button);
            this.control_groupBox.Controls.Add(this.person_button);
            this.control_groupBox.Controls.Add(this.tillnow_button);
            this.control_groupBox.Controls.Add(this.or_label);
            this.control_groupBox.Controls.Add(this.end_date);
            this.control_groupBox.Controls.Add(this.start_date);
            this.control_groupBox.Controls.Add(this.end_label);
            this.control_groupBox.Controls.Add(this.start_label);
            this.control_groupBox.Controls.Add(this.cech_label);
            this.control_groupBox.Controls.Add(this.position_label);
            this.control_groupBox.Controls.Add(this.person_label);
            this.control_groupBox.Controls.Add(this.clear_button);
            this.control_groupBox.Controls.Add(this.save_button);
            this.control_groupBox.Location = new System.Drawing.Point(170, 314);
            this.control_groupBox.Name = "control_groupBox";
            this.control_groupBox.Size = new System.Drawing.Size(962, 227);
            this.control_groupBox.TabIndex = 3;
            this.control_groupBox.TabStop = false;
            this.control_groupBox.Text = "groupBox";
            this.control_groupBox.Visible = false;
            // 
            // hide_button
            // 
            this.hide_button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("hide_button.BackgroundImage")));
            this.hide_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.hide_button.Location = new System.Drawing.Point(916, 18);
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
            this.error_label.Location = new System.Drawing.Point(48, 31);
            this.error_label.Name = "error_label";
            this.error_label.Size = new System.Drawing.Size(151, 17);
            this.error_label.TabIndex = 14;
            this.error_label.Text = "Some fields are empty!";
            this.error_label.Visible = false;
            // 
            // cech_button
            // 
            this.cech_button.Location = new System.Drawing.Point(109, 159);
            this.cech_button.Name = "cech_button";
            this.cech_button.Size = new System.Drawing.Size(80, 40);
            this.cech_button.TabIndex = 13;
            this.cech_button.Text = "select";
            this.cech_button.UseVisualStyleBackColor = true;
            this.cech_button.Click += new System.EventHandler(this.cech_button_Click);
            // 
            // position_button
            // 
            this.position_button.Location = new System.Drawing.Point(109, 105);
            this.position_button.Name = "position_button";
            this.position_button.Size = new System.Drawing.Size(80, 40);
            this.position_button.TabIndex = 12;
            this.position_button.Text = "select";
            this.position_button.UseVisualStyleBackColor = true;
            this.position_button.Click += new System.EventHandler(this.position_button_Click);
            // 
            // person_button
            // 
            this.person_button.Location = new System.Drawing.Point(109, 53);
            this.person_button.Name = "person_button";
            this.person_button.Size = new System.Drawing.Size(80, 40);
            this.person_button.TabIndex = 11;
            this.person_button.Text = "select";
            this.person_button.UseVisualStyleBackColor = true;
            this.person_button.Click += new System.EventHandler(this.person_button_Click);
            // 
            // tillnow_button
            // 
            this.tillnow_button.Location = new System.Drawing.Point(567, 149);
            this.tillnow_button.Name = "tillnow_button";
            this.tillnow_button.Size = new System.Drawing.Size(75, 23);
            this.tillnow_button.TabIndex = 10;
            this.tillnow_button.Text = "till now";
            this.tillnow_button.UseVisualStyleBackColor = true;
            this.tillnow_button.Visible = false;
            this.tillnow_button.Click += new System.EventHandler(this.tillnow_button_Click);
            this.tillnow_button.Paint += new System.Windows.Forms.PaintEventHandler(this.tillnow_button_Paint);
            // 
            // or_label
            // 
            this.or_label.AutoSize = true;
            this.or_label.Location = new System.Drawing.Point(540, 149);
            this.or_label.Name = "or_label";
            this.or_label.Size = new System.Drawing.Size(21, 17);
            this.or_label.TabIndex = 9;
            this.or_label.Text = "or";
            this.or_label.Visible = false;
            // 
            // end_date
            // 
            this.end_date.Location = new System.Drawing.Point(334, 149);
            this.end_date.Name = "end_date";
            this.end_date.Size = new System.Drawing.Size(200, 22);
            this.end_date.TabIndex = 8;
            this.end_date.Visible = false;
            // 
            // start_date
            // 
            this.start_date.Location = new System.Drawing.Point(334, 65);
            this.start_date.Name = "start_date";
            this.start_date.Size = new System.Drawing.Size(200, 22);
            this.start_date.TabIndex = 7;
            // 
            // end_label
            // 
            this.end_label.AutoSize = true;
            this.end_label.Location = new System.Drawing.Point(285, 149);
            this.end_label.Name = "end_label";
            this.end_label.Size = new System.Drawing.Size(37, 17);
            this.end_label.TabIndex = 6;
            this.end_label.Text = "End:";
            this.end_label.Visible = false;
            // 
            // start_label
            // 
            this.start_label.AutoSize = true;
            this.start_label.Location = new System.Drawing.Point(285, 65);
            this.start_label.Name = "start_label";
            this.start_label.Size = new System.Drawing.Size(42, 17);
            this.start_label.TabIndex = 5;
            this.start_label.Text = "Start:";
            // 
            // cech_label
            // 
            this.cech_label.AutoSize = true;
            this.cech_label.Location = new System.Drawing.Point(45, 171);
            this.cech_label.Name = "cech_label";
            this.cech_label.Size = new System.Drawing.Size(44, 17);
            this.cech_label.TabIndex = 4;
            this.cech_label.Text = "Cech:";
            // 
            // position_label
            // 
            this.position_label.AutoSize = true;
            this.position_label.Location = new System.Drawing.Point(45, 117);
            this.position_label.Name = "position_label";
            this.position_label.Size = new System.Drawing.Size(62, 17);
            this.position_label.TabIndex = 3;
            this.position_label.Text = "Position:";
            // 
            // person_label
            // 
            this.person_label.AutoSize = true;
            this.person_label.Location = new System.Drawing.Point(45, 65);
            this.person_label.Name = "person_label";
            this.person_label.Size = new System.Drawing.Size(57, 17);
            this.person_label.TabIndex = 2;
            this.person_label.Text = "Person:";
            // 
            // clear_button
            // 
            this.clear_button.Location = new System.Drawing.Point(714, 162);
            this.clear_button.Name = "clear_button";
            this.clear_button.Size = new System.Drawing.Size(100, 50);
            this.clear_button.TabIndex = 1;
            this.clear_button.Text = "clear";
            this.clear_button.UseVisualStyleBackColor = true;
            this.clear_button.Click += new System.EventHandler(this.clear_button_Click);
            // 
            // save_button
            // 
            this.save_button.Location = new System.Drawing.Point(846, 162);
            this.save_button.Name = "save_button";
            this.save_button.Size = new System.Drawing.Size(100, 50);
            this.save_button.TabIndex = 0;
            this.save_button.Text = "save";
            this.save_button.UseVisualStyleBackColor = true;
            this.save_button.Click += new System.EventHandler(this.save_button_Click);
            // 
            // search_button
            // 
            this.search_button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("search_button.BackgroundImage")));
            this.search_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.search_button.Location = new System.Drawing.Point(1044, 13);
            this.search_button.Name = "search_button";
            this.search_button.Size = new System.Drawing.Size(87, 131);
            this.search_button.TabIndex = 4;
            this.search_button.UseVisualStyleBackColor = true;
            this.search_button.Click += new System.EventHandler(this.search_button_Click);
            // 
            // workers_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1146, 553);
            this.Controls.Add(this.search_button);
            this.Controls.Add(this.control_groupBox);
            this.Controls.Add(this.control_panel);
            this.Controls.Add(this.fullInfo_button);
            this.Controls.Add(this.workersData);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "workers_form";
            this.Text = "workers";
            this.Load += new System.EventHandler(this.workers_form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.workersData)).EndInit();
            this.control_panel.ResumeLayout(false);
            this.control_groupBox.ResumeLayout(false);
            this.control_groupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView workersData;
        private System.Windows.Forms.Button fullInfo_button;
        private System.Windows.Forms.Panel control_panel;
        private System.Windows.Forms.GroupBox control_groupBox;
        private System.Windows.Forms.Button delete_button;
        private System.Windows.Forms.Button edit_button;
        private System.Windows.Forms.Button add_button;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.Button clear_button;
        private System.Windows.Forms.Button save_button;
        private System.Windows.Forms.Button cech_button;
        private System.Windows.Forms.Button position_button;
        private System.Windows.Forms.Button person_button;
        private System.Windows.Forms.Button tillnow_button;
        private System.Windows.Forms.Label or_label;
        private System.Windows.Forms.DateTimePicker end_date;
        private System.Windows.Forms.DateTimePicker start_date;
        private System.Windows.Forms.Label end_label;
        private System.Windows.Forms.Label start_label;
        private System.Windows.Forms.Label cech_label;
        private System.Windows.Forms.Label position_label;
        private System.Windows.Forms.Label person_label;
        private System.Windows.Forms.Label error_label;
        private System.Windows.Forms.Button hide_button;
        private System.Windows.Forms.Button search_button;
    }
}
namespace Department
{
    partial class person_form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(person_form));
            this.personData = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.control_panel = new System.Windows.Forms.Panel();
            this.delete_button = new System.Windows.Forms.Button();
            this.edit_button = new System.Windows.Forms.Button();
            this.add_button = new System.Windows.Forms.Button();
            this.add_groupBox = new System.Windows.Forms.GroupBox();
            this.hide_button = new System.Windows.Forms.Button();
            this.error_label = new System.Windows.Forms.Label();
            this.save_button = new System.Windows.Forms.Button();
            this.clear_button = new System.Windows.Forms.Button();
            this.add_birth_date = new System.Windows.Forms.DateTimePicker();
            this.add_birth_label = new System.Windows.Forms.Label();
            this.add_Address_label = new System.Windows.Forms.Label();
            this.add_idcode_label = new System.Windows.Forms.Label();
            this.add_Pasport_label = new System.Windows.Forms.Label();
            this.add_Address_textbox = new System.Windows.Forms.TextBox();
            this.add_idcode_textbox = new System.Windows.Forms.TextBox();
            this.add_Pasport_textbox = new System.Windows.Forms.TextBox();
            this.add_Name_textbox = new System.Windows.Forms.TextBox();
            this.add_Name_label = new System.Windows.Forms.Label();
            this.search_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.personData)).BeginInit();
            this.control_panel.SuspendLayout();
            this.add_groupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // personData
            // 
            this.personData.AllowUserToAddRows = false;
            this.personData.AllowUserToDeleteRows = false;
            this.personData.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.personData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.personData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.personData.Location = new System.Drawing.Point(12, 12);
            this.personData.Name = "personData";
            this.personData.ReadOnly = true;
            this.personData.RowHeadersWidth = 51;
            this.personData.RowTemplate.Height = 24;
            this.personData.Size = new System.Drawing.Size(1051, 228);
            this.personData.TabIndex = 0;
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
            this.Column3.HeaderText = "Pasport";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 125;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Id code";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 125;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Address";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 125;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Birth";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 125;
            // 
            // control_panel
            // 
            this.control_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(171)))), ((int)(((byte)(171)))));
            this.control_panel.Controls.Add(this.delete_button);
            this.control_panel.Controls.Add(this.edit_button);
            this.control_panel.Controls.Add(this.add_button);
            this.control_panel.Location = new System.Drawing.Point(13, 247);
            this.control_panel.Name = "control_panel";
            this.control_panel.Size = new System.Drawing.Size(118, 191);
            this.control_panel.TabIndex = 1;
            // 
            // delete_button
            // 
            this.delete_button.Location = new System.Drawing.Point(4, 127);
            this.delete_button.Name = "delete_button";
            this.delete_button.Size = new System.Drawing.Size(111, 60);
            this.delete_button.TabIndex = 2;
            this.delete_button.Text = "delete";
            this.delete_button.UseVisualStyleBackColor = true;
            this.delete_button.Click += new System.EventHandler(this.delete_button_Click);
            // 
            // edit_button
            // 
            this.edit_button.Location = new System.Drawing.Point(4, 65);
            this.edit_button.Name = "edit_button";
            this.edit_button.Size = new System.Drawing.Size(111, 60);
            this.edit_button.TabIndex = 1;
            this.edit_button.Text = "edit";
            this.edit_button.UseVisualStyleBackColor = true;
            this.edit_button.Click += new System.EventHandler(this.edit_button_Click);
            // 
            // add_button
            // 
            this.add_button.Location = new System.Drawing.Point(4, 4);
            this.add_button.Name = "add_button";
            this.add_button.Size = new System.Drawing.Size(111, 60);
            this.add_button.TabIndex = 0;
            this.add_button.Text = "add";
            this.add_button.UseVisualStyleBackColor = true;
            this.add_button.Click += new System.EventHandler(this.add_button_Click);
            // 
            // add_groupBox
            // 
            this.add_groupBox.Controls.Add(this.hide_button);
            this.add_groupBox.Controls.Add(this.error_label);
            this.add_groupBox.Controls.Add(this.save_button);
            this.add_groupBox.Controls.Add(this.clear_button);
            this.add_groupBox.Controls.Add(this.add_birth_date);
            this.add_groupBox.Controls.Add(this.add_birth_label);
            this.add_groupBox.Controls.Add(this.add_Address_label);
            this.add_groupBox.Controls.Add(this.add_idcode_label);
            this.add_groupBox.Controls.Add(this.add_Pasport_label);
            this.add_groupBox.Controls.Add(this.add_Address_textbox);
            this.add_groupBox.Controls.Add(this.add_idcode_textbox);
            this.add_groupBox.Controls.Add(this.add_Pasport_textbox);
            this.add_groupBox.Controls.Add(this.add_Name_textbox);
            this.add_groupBox.Controls.Add(this.add_Name_label);
            this.add_groupBox.Location = new System.Drawing.Point(138, 247);
            this.add_groupBox.Name = "add_groupBox";
            this.add_groupBox.Size = new System.Drawing.Size(979, 187);
            this.add_groupBox.TabIndex = 2;
            this.add_groupBox.TabStop = false;
            this.add_groupBox.Text = "add new item";
            this.add_groupBox.Visible = false;
            // 
            // hide_button
            // 
            this.hide_button.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.hide_button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("hide_button.BackgroundImage")));
            this.hide_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.hide_button.Cursor = System.Windows.Forms.Cursors.Default;
            this.hide_button.Location = new System.Drawing.Point(931, 18);
            this.hide_button.Name = "hide_button";
            this.hide_button.Size = new System.Drawing.Size(30, 30);
            this.hide_button.TabIndex = 13;
            this.hide_button.UseVisualStyleBackColor = false;
            this.hide_button.Click += new System.EventHandler(this.hide_button_Click);
            // 
            // error_label
            // 
            this.error_label.AutoSize = true;
            this.error_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.error_label.ForeColor = System.Drawing.Color.Red;
            this.error_label.Location = new System.Drawing.Point(10, 18);
            this.error_label.Name = "error_label";
            this.error_label.Size = new System.Drawing.Size(151, 17);
            this.error_label.TabIndex = 12;
            this.error_label.Text = "Some fields are empty!";
            this.error_label.Visible = false;
            // 
            // save_button
            // 
            this.save_button.Location = new System.Drawing.Point(722, 132);
            this.save_button.Name = "save_button";
            this.save_button.Size = new System.Drawing.Size(180, 50);
            this.save_button.TabIndex = 11;
            this.save_button.Text = "save";
            this.save_button.UseVisualStyleBackColor = true;
            this.save_button.Click += new System.EventHandler(this.save_button_Click);
            // 
            // clear_button
            // 
            this.clear_button.Location = new System.Drawing.Point(488, 132);
            this.clear_button.Name = "clear_button";
            this.clear_button.Size = new System.Drawing.Size(180, 50);
            this.clear_button.TabIndex = 3;
            this.clear_button.Text = "clear";
            this.clear_button.UseVisualStyleBackColor = true;
            this.clear_button.Click += new System.EventHandler(this.clear_button_Click);
            // 
            // add_birth_date
            // 
            this.add_birth_date.Location = new System.Drawing.Point(532, 80);
            this.add_birth_date.Name = "add_birth_date";
            this.add_birth_date.Size = new System.Drawing.Size(178, 22);
            this.add_birth_date.TabIndex = 10;
            // 
            // add_birth_label
            // 
            this.add_birth_label.AutoSize = true;
            this.add_birth_label.Location = new System.Drawing.Point(485, 84);
            this.add_birth_label.Name = "add_birth_label";
            this.add_birth_label.Size = new System.Drawing.Size(41, 17);
            this.add_birth_label.TabIndex = 9;
            this.add_birth_label.Text = "Birth:";
            // 
            // add_Address_label
            // 
            this.add_Address_label.AutoSize = true;
            this.add_Address_label.Location = new System.Drawing.Point(485, 39);
            this.add_Address_label.Name = "add_Address_label";
            this.add_Address_label.Size = new System.Drawing.Size(64, 17);
            this.add_Address_label.TabIndex = 8;
            this.add_Address_label.Text = "Address:";
            // 
            // add_idcode_label
            // 
            this.add_idcode_label.AutoSize = true;
            this.add_idcode_label.Location = new System.Drawing.Point(10, 137);
            this.add_idcode_label.Name = "add_idcode_label";
            this.add_idcode_label.Size = new System.Drawing.Size(58, 17);
            this.add_idcode_label.TabIndex = 7;
            this.add_idcode_label.Text = "Id code:";
            this.add_idcode_label.Click += new System.EventHandler(this.add_idcode_label_Click);
            // 
            // add_Pasport_label
            // 
            this.add_Pasport_label.AutoSize = true;
            this.add_Pasport_label.Location = new System.Drawing.Point(10, 84);
            this.add_Pasport_label.Name = "add_Pasport_label";
            this.add_Pasport_label.Size = new System.Drawing.Size(61, 17);
            this.add_Pasport_label.TabIndex = 6;
            this.add_Pasport_label.Text = "Pasport:";
            // 
            // add_Address_textbox
            // 
            this.add_Address_textbox.Location = new System.Drawing.Point(558, 36);
            this.add_Address_textbox.Name = "add_Address_textbox";
            this.add_Address_textbox.Size = new System.Drawing.Size(343, 22);
            this.add_Address_textbox.TabIndex = 5;
            this.add_Address_textbox.TextChanged += new System.EventHandler(this.add_Address_textbox_TextChanged);
            // 
            // add_idcode_textbox
            // 
            this.add_idcode_textbox.Location = new System.Drawing.Point(74, 137);
            this.add_idcode_textbox.MaxLength = 10;
            this.add_idcode_textbox.Name = "add_idcode_textbox";
            this.add_idcode_textbox.Size = new System.Drawing.Size(352, 22);
            this.add_idcode_textbox.TabIndex = 3;
            this.add_idcode_textbox.TextChanged += new System.EventHandler(this.add_idcode_textbox_TextChanged);
            // 
            // add_Pasport_textbox
            // 
            this.add_Pasport_textbox.Location = new System.Drawing.Point(77, 84);
            this.add_Pasport_textbox.MaxLength = 10;
            this.add_Pasport_textbox.Name = "add_Pasport_textbox";
            this.add_Pasport_textbox.Size = new System.Drawing.Size(349, 22);
            this.add_Pasport_textbox.TabIndex = 2;
            // 
            // add_Name_textbox
            // 
            this.add_Name_textbox.Location = new System.Drawing.Point(66, 36);
            this.add_Name_textbox.Name = "add_Name_textbox";
            this.add_Name_textbox.Size = new System.Drawing.Size(360, 22);
            this.add_Name_textbox.TabIndex = 1;
            // 
            // add_Name_label
            // 
            this.add_Name_label.AutoSize = true;
            this.add_Name_label.Location = new System.Drawing.Point(10, 36);
            this.add_Name_label.Name = "add_Name_label";
            this.add_Name_label.Size = new System.Drawing.Size(49, 17);
            this.add_Name_label.TabIndex = 0;
            this.add_Name_label.Text = "Name:";
            // 
            // search_button
            // 
            this.search_button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("search_button.BackgroundImage")));
            this.search_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.search_button.Location = new System.Drawing.Point(1069, 12);
            this.search_button.Name = "search_button";
            this.search_button.Size = new System.Drawing.Size(50, 50);
            this.search_button.TabIndex = 3;
            this.search_button.UseVisualStyleBackColor = true;
            this.search_button.Click += new System.EventHandler(this.search_button_Click);
            // 
            // person_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1129, 450);
            this.Controls.Add(this.search_button);
            this.Controls.Add(this.control_panel);
            this.Controls.Add(this.personData);
            this.Controls.Add(this.add_groupBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "person_form";
            this.Text = "person";
            this.Load += new System.EventHandler(this.person_form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.personData)).EndInit();
            this.control_panel.ResumeLayout(false);
            this.add_groupBox.ResumeLayout(false);
            this.add_groupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView personData;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.Panel control_panel;
        private System.Windows.Forms.Button delete_button;
        private System.Windows.Forms.Button edit_button;
        private System.Windows.Forms.Button add_button;
        private System.Windows.Forms.GroupBox add_groupBox;
        private System.Windows.Forms.DateTimePicker add_birth_date;
        private System.Windows.Forms.Label add_birth_label;
        private System.Windows.Forms.Label add_Address_label;
        private System.Windows.Forms.Label add_idcode_label;
        private System.Windows.Forms.Label add_Pasport_label;
        private System.Windows.Forms.TextBox add_Address_textbox;
        private System.Windows.Forms.TextBox add_idcode_textbox;
        private System.Windows.Forms.TextBox add_Pasport_textbox;
        private System.Windows.Forms.TextBox add_Name_textbox;
        private System.Windows.Forms.Label add_Name_label;
        private System.Windows.Forms.Button save_button;
        private System.Windows.Forms.Button clear_button;
        private System.Windows.Forms.Label error_label;
        private System.Windows.Forms.Button hide_button;
        private System.Windows.Forms.Button search_button;
    }
}
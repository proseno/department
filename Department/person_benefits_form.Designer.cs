namespace Department
{
    partial class person_benefits_form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(person_benefits_form));
            this.person_benefitsData = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.control_panel = new System.Windows.Forms.Panel();
            this.add_button = new System.Windows.Forms.Button();
            this.edit_button = new System.Windows.Forms.Button();
            this.delete_button = new System.Windows.Forms.Button();
            this.control_groupBox = new System.Windows.Forms.GroupBox();
            this.hide_button = new System.Windows.Forms.Button();
            this.tillnow_button = new System.Windows.Forms.Button();
            this.or_label = new System.Windows.Forms.Label();
            this.error_label = new System.Windows.Forms.Label();
            this.end_date = new System.Windows.Forms.DateTimePicker();
            this.end_label = new System.Windows.Forms.Label();
            this.save_button = new System.Windows.Forms.Button();
            this.clear_button = new System.Windows.Forms.Button();
            this.start_label = new System.Windows.Forms.Label();
            this.start_date = new System.Windows.Forms.DateTimePicker();
            this.benefits_button = new System.Windows.Forms.Button();
            this.person_button = new System.Windows.Forms.Button();
            this.benefits_label = new System.Windows.Forms.Label();
            this.person_label = new System.Windows.Forms.Label();
            this.full_button = new System.Windows.Forms.Button();
            this.search_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.person_benefitsData)).BeginInit();
            this.control_panel.SuspendLayout();
            this.control_groupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // person_benefitsData
            // 
            this.person_benefitsData.AllowUserToAddRows = false;
            this.person_benefitsData.AllowUserToDeleteRows = false;
            this.person_benefitsData.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.person_benefitsData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.person_benefitsData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column3,
            this.Column4});
            this.person_benefitsData.Location = new System.Drawing.Point(12, 12);
            this.person_benefitsData.Name = "person_benefitsData";
            this.person_benefitsData.ReadOnly = true;
            this.person_benefitsData.RowHeadersWidth = 51;
            this.person_benefitsData.RowTemplate.Height = 24;
            this.person_benefitsData.Size = new System.Drawing.Size(1179, 206);
            this.person_benefitsData.TabIndex = 0;
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
            // Column6
            // 
            this.Column6.HeaderText = "Benefits name";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 125;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Descriprion";
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Width = 125;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Kind";
            this.Column8.MinimumWidth = 6;
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            this.Column8.Width = 125;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Start";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 125;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "End";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 125;
            // 
            // control_panel
            // 
            this.control_panel.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.control_panel.Controls.Add(this.add_button);
            this.control_panel.Controls.Add(this.edit_button);
            this.control_panel.Controls.Add(this.delete_button);
            this.control_panel.Location = new System.Drawing.Point(13, 225);
            this.control_panel.Name = "control_panel";
            this.control_panel.Size = new System.Drawing.Size(126, 213);
            this.control_panel.TabIndex = 1;
            // 
            // add_button
            // 
            this.add_button.Location = new System.Drawing.Point(2, 1);
            this.add_button.Name = "add_button";
            this.add_button.Size = new System.Drawing.Size(122, 70);
            this.add_button.TabIndex = 2;
            this.add_button.Text = "add";
            this.add_button.UseVisualStyleBackColor = true;
            this.add_button.Click += new System.EventHandler(this.add_button_Click);
            // 
            // edit_button
            // 
            this.edit_button.Location = new System.Drawing.Point(2, 72);
            this.edit_button.Name = "edit_button";
            this.edit_button.Size = new System.Drawing.Size(122, 70);
            this.edit_button.TabIndex = 3;
            this.edit_button.Text = "edit";
            this.edit_button.UseVisualStyleBackColor = true;
            this.edit_button.Click += new System.EventHandler(this.edit_button_Click);
            // 
            // delete_button
            // 
            this.delete_button.Location = new System.Drawing.Point(2, 143);
            this.delete_button.Name = "delete_button";
            this.delete_button.Size = new System.Drawing.Size(122, 70);
            this.delete_button.TabIndex = 4;
            this.delete_button.Text = "delete";
            this.delete_button.UseVisualStyleBackColor = true;
            this.delete_button.Click += new System.EventHandler(this.delete_button_Click);
            // 
            // control_groupBox
            // 
            this.control_groupBox.Controls.Add(this.hide_button);
            this.control_groupBox.Controls.Add(this.tillnow_button);
            this.control_groupBox.Controls.Add(this.or_label);
            this.control_groupBox.Controls.Add(this.error_label);
            this.control_groupBox.Controls.Add(this.end_date);
            this.control_groupBox.Controls.Add(this.end_label);
            this.control_groupBox.Controls.Add(this.save_button);
            this.control_groupBox.Controls.Add(this.clear_button);
            this.control_groupBox.Controls.Add(this.start_label);
            this.control_groupBox.Controls.Add(this.start_date);
            this.control_groupBox.Controls.Add(this.benefits_button);
            this.control_groupBox.Controls.Add(this.person_button);
            this.control_groupBox.Controls.Add(this.benefits_label);
            this.control_groupBox.Controls.Add(this.person_label);
            this.control_groupBox.Location = new System.Drawing.Point(146, 225);
            this.control_groupBox.Name = "control_groupBox";
            this.control_groupBox.Size = new System.Drawing.Size(1154, 213);
            this.control_groupBox.TabIndex = 2;
            this.control_groupBox.TabStop = false;
            this.control_groupBox.Text = "groupBox";
            this.control_groupBox.Visible = false;
            // 
            // hide_button
            // 
            this.hide_button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("hide_button.BackgroundImage")));
            this.hide_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.hide_button.Location = new System.Drawing.Point(1103, 22);
            this.hide_button.Name = "hide_button";
            this.hide_button.Size = new System.Drawing.Size(30, 30);
            this.hide_button.TabIndex = 15;
            this.hide_button.UseVisualStyleBackColor = true;
            this.hide_button.Click += new System.EventHandler(this.hide_button_Click);
            // 
            // tillnow_button
            // 
            this.tillnow_button.Location = new System.Drawing.Point(670, 122);
            this.tillnow_button.Name = "tillnow_button";
            this.tillnow_button.Size = new System.Drawing.Size(75, 23);
            this.tillnow_button.TabIndex = 14;
            this.tillnow_button.Text = "till now";
            this.tillnow_button.UseVisualStyleBackColor = true;
            this.tillnow_button.Visible = false;
            this.tillnow_button.Click += new System.EventHandler(this.tillnow_button_Click);
            this.tillnow_button.Paint += new System.Windows.Forms.PaintEventHandler(this.tillnow_button_Paint);
            // 
            // or_label
            // 
            this.or_label.AutoSize = true;
            this.or_label.Location = new System.Drawing.Point(642, 125);
            this.or_label.Name = "or_label";
            this.or_label.Size = new System.Drawing.Size(21, 17);
            this.or_label.TabIndex = 13;
            this.or_label.Text = "or";
            this.or_label.Visible = false;
            // 
            // error_label
            // 
            this.error_label.AutoSize = true;
            this.error_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.error_label.ForeColor = System.Drawing.Color.Red;
            this.error_label.Location = new System.Drawing.Point(24, 22);
            this.error_label.Name = "error_label";
            this.error_label.Size = new System.Drawing.Size(151, 17);
            this.error_label.TabIndex = 12;
            this.error_label.Text = "Some fields are empty!";
            this.error_label.Visible = false;
            // 
            // end_date
            // 
            this.end_date.Location = new System.Drawing.Point(436, 124);
            this.end_date.Name = "end_date";
            this.end_date.Size = new System.Drawing.Size(200, 22);
            this.end_date.TabIndex = 11;
            this.end_date.Visible = false;
            // 
            // end_label
            // 
            this.end_label.AutoSize = true;
            this.end_label.Location = new System.Drawing.Point(392, 124);
            this.end_label.Name = "end_label";
            this.end_label.Size = new System.Drawing.Size(37, 17);
            this.end_label.TabIndex = 10;
            this.end_label.Text = "End:";
            this.end_label.Visible = false;
            // 
            // save_button
            // 
            this.save_button.Location = new System.Drawing.Point(1007, 143);
            this.save_button.Name = "save_button";
            this.save_button.Size = new System.Drawing.Size(100, 50);
            this.save_button.TabIndex = 9;
            this.save_button.Text = "save";
            this.save_button.UseVisualStyleBackColor = true;
            this.save_button.Click += new System.EventHandler(this.save_button_Click);
            // 
            // clear_button
            // 
            this.clear_button.Location = new System.Drawing.Point(842, 143);
            this.clear_button.Name = "clear_button";
            this.clear_button.Size = new System.Drawing.Size(100, 50);
            this.clear_button.TabIndex = 8;
            this.clear_button.Text = "clear";
            this.clear_button.UseVisualStyleBackColor = true;
            this.clear_button.Click += new System.EventHandler(this.clear_button_Click);
            // 
            // start_label
            // 
            this.start_label.AutoSize = true;
            this.start_label.Location = new System.Drawing.Point(389, 54);
            this.start_label.Name = "start_label";
            this.start_label.Size = new System.Drawing.Size(42, 17);
            this.start_label.TabIndex = 5;
            this.start_label.Text = "Start:";
            // 
            // start_date
            // 
            this.start_date.Location = new System.Drawing.Point(437, 49);
            this.start_date.Name = "start_date";
            this.start_date.Size = new System.Drawing.Size(200, 22);
            this.start_date.TabIndex = 4;
            // 
            // benefits_button
            // 
            this.benefits_button.Location = new System.Drawing.Point(90, 119);
            this.benefits_button.Name = "benefits_button";
            this.benefits_button.Size = new System.Drawing.Size(80, 40);
            this.benefits_button.TabIndex = 3;
            this.benefits_button.Text = "select ";
            this.benefits_button.UseVisualStyleBackColor = true;
            this.benefits_button.Click += new System.EventHandler(this.benefits_button_Click);
            // 
            // person_button
            // 
            this.person_button.Location = new System.Drawing.Point(90, 42);
            this.person_button.Name = "person_button";
            this.person_button.Size = new System.Drawing.Size(80, 40);
            this.person_button.TabIndex = 2;
            this.person_button.Text = "select";
            this.person_button.UseVisualStyleBackColor = true;
            this.person_button.Click += new System.EventHandler(this.person_button_Click);
            // 
            // benefits_label
            // 
            this.benefits_label.AutoSize = true;
            this.benefits_label.Location = new System.Drawing.Point(21, 131);
            this.benefits_label.Name = "benefits_label";
            this.benefits_label.Size = new System.Drawing.Size(63, 17);
            this.benefits_label.TabIndex = 1;
            this.benefits_label.Text = "Benefits:";
            // 
            // person_label
            // 
            this.person_label.AutoSize = true;
            this.person_label.Location = new System.Drawing.Point(21, 54);
            this.person_label.Name = "person_label";
            this.person_label.Size = new System.Drawing.Size(57, 17);
            this.person_label.TabIndex = 0;
            this.person_label.Text = "Person:";
            // 
            // full_button
            // 
            this.full_button.Location = new System.Drawing.Point(1196, 118);
            this.full_button.Name = "full_button";
            this.full_button.Size = new System.Drawing.Size(102, 102);
            this.full_button.TabIndex = 3;
            this.full_button.Text = "full information";
            this.full_button.UseVisualStyleBackColor = true;
            this.full_button.Click += new System.EventHandler(this.full_button_Click);
            // 
            // search_button
            // 
            this.search_button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("search_button.BackgroundImage")));
            this.search_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.search_button.Location = new System.Drawing.Point(1198, 12);
            this.search_button.Name = "search_button";
            this.search_button.Size = new System.Drawing.Size(100, 100);
            this.search_button.TabIndex = 4;
            this.search_button.UseVisualStyleBackColor = true;
            this.search_button.Click += new System.EventHandler(this.search_button_Click);
            // 
            // person_benefits_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1312, 450);
            this.Controls.Add(this.search_button);
            this.Controls.Add(this.full_button);
            this.Controls.Add(this.control_groupBox);
            this.Controls.Add(this.control_panel);
            this.Controls.Add(this.person_benefitsData);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "person_benefits_form";
            this.Text = "person benefits";
            this.Load += new System.EventHandler(this.person_benefits_form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.person_benefitsData)).EndInit();
            this.control_panel.ResumeLayout(false);
            this.control_groupBox.ResumeLayout(false);
            this.control_groupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView person_benefitsData;
        private System.Windows.Forms.Panel control_panel;
        private System.Windows.Forms.Button add_button;
        private System.Windows.Forms.Button edit_button;
        private System.Windows.Forms.Button delete_button;
        private System.Windows.Forms.GroupBox control_groupBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.Button full_button;
        private System.Windows.Forms.Label benefits_label;
        private System.Windows.Forms.Label person_label;
        private System.Windows.Forms.Button save_button;
        private System.Windows.Forms.Button clear_button;
        private System.Windows.Forms.Label start_label;
        private System.Windows.Forms.DateTimePicker start_date;
        private System.Windows.Forms.Button benefits_button;
        private System.Windows.Forms.Button person_button;
        private System.Windows.Forms.DateTimePicker end_date;
        private System.Windows.Forms.Label end_label;
        private System.Windows.Forms.Label error_label;
        private System.Windows.Forms.Button tillnow_button;
        private System.Windows.Forms.Label or_label;
        private System.Windows.Forms.Button hide_button;
        private System.Windows.Forms.Button search_button;
    }
}
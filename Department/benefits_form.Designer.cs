namespace Department
{
    partial class benefits_form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(benefits_form));
            this.benefitsData = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.control_panel = new System.Windows.Forms.Panel();
            this.edit_button = new System.Windows.Forms.Button();
            this.delete_button = new System.Windows.Forms.Button();
            this.add_button = new System.Windows.Forms.Button();
            this.control_groupBox = new System.Windows.Forms.GroupBox();
            this.hide_button = new System.Windows.Forms.Button();
            this.error_label = new System.Windows.Forms.Label();
            this.save_button = new System.Windows.Forms.Button();
            this.clear_button = new System.Windows.Forms.Button();
            this.kind_textbox = new System.Windows.Forms.TextBox();
            this.description_textbox = new System.Windows.Forms.TextBox();
            this.name_textbox = new System.Windows.Forms.TextBox();
            this.kind_label = new System.Windows.Forms.Label();
            this.description_label = new System.Windows.Forms.Label();
            this.name_label = new System.Windows.Forms.Label();
            this.search_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.benefitsData)).BeginInit();
            this.control_panel.SuspendLayout();
            this.control_groupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // benefitsData
            // 
            this.benefitsData.AllowUserToAddRows = false;
            this.benefitsData.AllowUserToDeleteRows = false;
            this.benefitsData.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.benefitsData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.benefitsData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.benefitsData.Location = new System.Drawing.Point(12, 12);
            this.benefitsData.Name = "benefitsData";
            this.benefitsData.ReadOnly = true;
            this.benefitsData.RowHeadersWidth = 51;
            this.benefitsData.RowTemplate.Height = 24;
            this.benefitsData.Size = new System.Drawing.Size(870, 232);
            this.benefitsData.TabIndex = 0;
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
            this.Column3.HeaderText = "Description";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 125;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Kind";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 125;
            // 
            // control_panel
            // 
            this.control_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(171)))), ((int)(((byte)(171)))));
            this.control_panel.Controls.Add(this.edit_button);
            this.control_panel.Controls.Add(this.delete_button);
            this.control_panel.Controls.Add(this.add_button);
            this.control_panel.Location = new System.Drawing.Point(12, 251);
            this.control_panel.Name = "control_panel";
            this.control_panel.Size = new System.Drawing.Size(123, 187);
            this.control_panel.TabIndex = 1;
            // 
            // edit_button
            // 
            this.edit_button.Location = new System.Drawing.Point(3, 64);
            this.edit_button.Name = "edit_button";
            this.edit_button.Size = new System.Drawing.Size(117, 60);
            this.edit_button.TabIndex = 2;
            this.edit_button.Text = "edit";
            this.edit_button.UseVisualStyleBackColor = true;
            this.edit_button.Click += new System.EventHandler(this.edit_button_Click);
            // 
            // delete_button
            // 
            this.delete_button.Location = new System.Drawing.Point(3, 124);
            this.delete_button.Name = "delete_button";
            this.delete_button.Size = new System.Drawing.Size(117, 60);
            this.delete_button.TabIndex = 3;
            this.delete_button.Text = "delete";
            this.delete_button.UseVisualStyleBackColor = true;
            this.delete_button.Click += new System.EventHandler(this.delete_button_Click);
            // 
            // add_button
            // 
            this.add_button.Location = new System.Drawing.Point(3, 3);
            this.add_button.Name = "add_button";
            this.add_button.Size = new System.Drawing.Size(117, 60);
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
            this.control_groupBox.Controls.Add(this.kind_textbox);
            this.control_groupBox.Controls.Add(this.description_textbox);
            this.control_groupBox.Controls.Add(this.name_textbox);
            this.control_groupBox.Controls.Add(this.kind_label);
            this.control_groupBox.Controls.Add(this.description_label);
            this.control_groupBox.Controls.Add(this.name_label);
            this.control_groupBox.Location = new System.Drawing.Point(142, 251);
            this.control_groupBox.Name = "control_groupBox";
            this.control_groupBox.Size = new System.Drawing.Size(809, 187);
            this.control_groupBox.TabIndex = 2;
            this.control_groupBox.TabStop = false;
            this.control_groupBox.Text = "groupBox";
            this.control_groupBox.Visible = false;
            // 
            // hide_button
            // 
            this.hide_button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("hide_button.BackgroundImage")));
            this.hide_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.hide_button.Location = new System.Drawing.Point(764, 18);
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
            this.error_label.Location = new System.Drawing.Point(21, 20);
            this.error_label.Name = "error_label";
            this.error_label.Size = new System.Drawing.Size(151, 17);
            this.error_label.TabIndex = 8;
            this.error_label.Text = "Some fields are empty!";
            this.error_label.Visible = false;
            // 
            // save_button
            // 
            this.save_button.Location = new System.Drawing.Point(692, 122);
            this.save_button.Name = "save_button";
            this.save_button.Size = new System.Drawing.Size(100, 50);
            this.save_button.TabIndex = 7;
            this.save_button.Text = "save";
            this.save_button.UseVisualStyleBackColor = true;
            this.save_button.Click += new System.EventHandler(this.save_button_Click);
            // 
            // clear_button
            // 
            this.clear_button.Location = new System.Drawing.Point(551, 122);
            this.clear_button.Name = "clear_button";
            this.clear_button.Size = new System.Drawing.Size(100, 50);
            this.clear_button.TabIndex = 6;
            this.clear_button.Text = "clear";
            this.clear_button.UseVisualStyleBackColor = true;
            this.clear_button.Click += new System.EventHandler(this.clear_button_Click);
            // 
            // kind_textbox
            // 
            this.kind_textbox.Location = new System.Drawing.Point(68, 124);
            this.kind_textbox.Name = "kind_textbox";
            this.kind_textbox.Size = new System.Drawing.Size(436, 22);
            this.kind_textbox.TabIndex = 5;
            // 
            // description_textbox
            // 
            this.description_textbox.Location = new System.Drawing.Point(111, 80);
            this.description_textbox.Name = "description_textbox";
            this.description_textbox.Size = new System.Drawing.Size(393, 22);
            this.description_textbox.TabIndex = 4;
            // 
            // name_textbox
            // 
            this.name_textbox.Location = new System.Drawing.Point(77, 40);
            this.name_textbox.Name = "name_textbox";
            this.name_textbox.Size = new System.Drawing.Size(427, 22);
            this.name_textbox.TabIndex = 3;
            // 
            // kind_label
            // 
            this.kind_label.AutoSize = true;
            this.kind_label.Location = new System.Drawing.Point(21, 124);
            this.kind_label.Name = "kind_label";
            this.kind_label.Size = new System.Drawing.Size(40, 17);
            this.kind_label.TabIndex = 2;
            this.kind_label.Text = "Kind:";
            // 
            // description_label
            // 
            this.description_label.AutoSize = true;
            this.description_label.Location = new System.Drawing.Point(21, 86);
            this.description_label.Name = "description_label";
            this.description_label.Size = new System.Drawing.Size(83, 17);
            this.description_label.TabIndex = 1;
            this.description_label.Text = "Description:";
            // 
            // name_label
            // 
            this.name_label.AutoSize = true;
            this.name_label.Location = new System.Drawing.Point(21, 46);
            this.name_label.Name = "name_label";
            this.name_label.Size = new System.Drawing.Size(49, 17);
            this.name_label.TabIndex = 0;
            this.name_label.Text = "Name:";
            // 
            // search_button
            // 
            this.search_button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("search_button.BackgroundImage")));
            this.search_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.search_button.Location = new System.Drawing.Point(888, 13);
            this.search_button.Name = "search_button";
            this.search_button.Size = new System.Drawing.Size(63, 63);
            this.search_button.TabIndex = 3;
            this.search_button.UseVisualStyleBackColor = true;
            this.search_button.Click += new System.EventHandler(this.search_button_Click);
            // 
            // benefits_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(963, 450);
            this.Controls.Add(this.search_button);
            this.Controls.Add(this.control_groupBox);
            this.Controls.Add(this.control_panel);
            this.Controls.Add(this.benefitsData);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "benefits_form";
            this.Text = "benefits";
            this.Load += new System.EventHandler(this.benefits_form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.benefitsData)).EndInit();
            this.control_panel.ResumeLayout(false);
            this.control_groupBox.ResumeLayout(false);
            this.control_groupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView benefitsData;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.Panel control_panel;
        private System.Windows.Forms.Button edit_button;
        private System.Windows.Forms.Button delete_button;
        private System.Windows.Forms.Button add_button;
        private System.Windows.Forms.GroupBox control_groupBox;
        private System.Windows.Forms.Button save_button;
        private System.Windows.Forms.Button clear_button;
        private System.Windows.Forms.TextBox kind_textbox;
        private System.Windows.Forms.TextBox description_textbox;
        private System.Windows.Forms.TextBox name_textbox;
        private System.Windows.Forms.Label kind_label;
        private System.Windows.Forms.Label description_label;
        private System.Windows.Forms.Label name_label;
        private System.Windows.Forms.Label error_label;
        private System.Windows.Forms.Button hide_button;
        private System.Windows.Forms.Button search_button;
    }
}
namespace Department
{
    partial class person_search
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(person_search));
            this.control_groupBox = new System.Windows.Forms.GroupBox();
            this.on_off_button = new System.Windows.Forms.Button();
            this.birth_date = new System.Windows.Forms.DateTimePicker();
            this.address_textBox = new System.Windows.Forms.TextBox();
            this.idcode_textBox = new System.Windows.Forms.TextBox();
            this.id_textBox = new System.Windows.Forms.TextBox();
            this.name_textBox = new System.Windows.Forms.TextBox();
            this.pasport_textBox = new System.Windows.Forms.TextBox();
            this.clear_button = new System.Windows.Forms.Button();
            this.search_button = new System.Windows.Forms.Button();
            this.id_label = new System.Windows.Forms.Label();
            this.idcode_label = new System.Windows.Forms.Label();
            this.pasport_label = new System.Windows.Forms.Label();
            this.name_label = new System.Windows.Forms.Label();
            this.birth_label = new System.Windows.Forms.Label();
            this.address_label = new System.Windows.Forms.Label();
            this.personData = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ok_button = new System.Windows.Forms.Button();
            this.cancel_button = new System.Windows.Forms.Button();
            this.control_groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.personData)).BeginInit();
            this.SuspendLayout();
            // 
            // control_groupBox
            // 
            this.control_groupBox.Controls.Add(this.on_off_button);
            this.control_groupBox.Controls.Add(this.birth_date);
            this.control_groupBox.Controls.Add(this.address_textBox);
            this.control_groupBox.Controls.Add(this.idcode_textBox);
            this.control_groupBox.Controls.Add(this.id_textBox);
            this.control_groupBox.Controls.Add(this.name_textBox);
            this.control_groupBox.Controls.Add(this.pasport_textBox);
            this.control_groupBox.Controls.Add(this.clear_button);
            this.control_groupBox.Controls.Add(this.search_button);
            this.control_groupBox.Controls.Add(this.id_label);
            this.control_groupBox.Controls.Add(this.idcode_label);
            this.control_groupBox.Controls.Add(this.pasport_label);
            this.control_groupBox.Controls.Add(this.name_label);
            this.control_groupBox.Controls.Add(this.birth_label);
            this.control_groupBox.Controls.Add(this.address_label);
            this.control_groupBox.Location = new System.Drawing.Point(13, 13);
            this.control_groupBox.Name = "control_groupBox";
            this.control_groupBox.Size = new System.Drawing.Size(923, 175);
            this.control_groupBox.TabIndex = 0;
            this.control_groupBox.TabStop = false;
            // 
            // on_off_button
            // 
            this.on_off_button.Location = new System.Drawing.Point(624, 119);
            this.on_off_button.Name = "on_off_button";
            this.on_off_button.Size = new System.Drawing.Size(46, 23);
            this.on_off_button.TabIndex = 18;
            this.on_off_button.Text = "off";
            this.on_off_button.UseVisualStyleBackColor = true;
            this.on_off_button.Click += new System.EventHandler(this.on_off_button_Click);
            // 
            // birth_date
            // 
            this.birth_date.Location = new System.Drawing.Point(439, 119);
            this.birth_date.Name = "birth_date";
            this.birth_date.Size = new System.Drawing.Size(179, 22);
            this.birth_date.TabIndex = 17;
            // 
            // address_textBox
            // 
            this.address_textBox.Location = new System.Drawing.Point(461, 78);
            this.address_textBox.Name = "address_textBox";
            this.address_textBox.Size = new System.Drawing.Size(250, 22);
            this.address_textBox.TabIndex = 16;
            // 
            // idcode_textBox
            // 
            this.idcode_textBox.Location = new System.Drawing.Point(461, 35);
            this.idcode_textBox.Name = "idcode_textBox";
            this.idcode_textBox.Size = new System.Drawing.Size(250, 22);
            this.idcode_textBox.TabIndex = 15;
            // 
            // id_textBox
            // 
            this.id_textBox.Location = new System.Drawing.Point(98, 35);
            this.id_textBox.Name = "id_textBox";
            this.id_textBox.Size = new System.Drawing.Size(269, 22);
            this.id_textBox.TabIndex = 14;
            // 
            // name_textBox
            // 
            this.name_textBox.Location = new System.Drawing.Point(98, 78);
            this.name_textBox.Name = "name_textBox";
            this.name_textBox.Size = new System.Drawing.Size(269, 22);
            this.name_textBox.TabIndex = 13;
            // 
            // pasport_textBox
            // 
            this.pasport_textBox.Location = new System.Drawing.Point(98, 119);
            this.pasport_textBox.Name = "pasport_textBox";
            this.pasport_textBox.Size = new System.Drawing.Size(269, 22);
            this.pasport_textBox.TabIndex = 12;
            // 
            // clear_button
            // 
            this.clear_button.Location = new System.Drawing.Point(691, 119);
            this.clear_button.Name = "clear_button";
            this.clear_button.Size = new System.Drawing.Size(100, 50);
            this.clear_button.TabIndex = 11;
            this.clear_button.Text = "clear";
            this.clear_button.UseVisualStyleBackColor = true;
            this.clear_button.Click += new System.EventHandler(this.clear_button_Click);
            // 
            // search_button
            // 
            this.search_button.Location = new System.Drawing.Point(823, 119);
            this.search_button.Name = "search_button";
            this.search_button.Size = new System.Drawing.Size(100, 50);
            this.search_button.TabIndex = 10;
            this.search_button.Text = "search";
            this.search_button.UseVisualStyleBackColor = true;
            this.search_button.Click += new System.EventHandler(this.search_button_Click);
            // 
            // id_label
            // 
            this.id_label.AutoSize = true;
            this.id_label.Location = new System.Drawing.Point(31, 35);
            this.id_label.Name = "id_label";
            this.id_label.Size = new System.Drawing.Size(23, 17);
            this.id_label.TabIndex = 9;
            this.id_label.Text = "Id:";
            // 
            // idcode_label
            // 
            this.idcode_label.AutoSize = true;
            this.idcode_label.Location = new System.Drawing.Point(391, 35);
            this.idcode_label.Name = "idcode_label";
            this.idcode_label.Size = new System.Drawing.Size(58, 17);
            this.idcode_label.TabIndex = 8;
            this.idcode_label.Text = "Id code:";
            // 
            // pasport_label
            // 
            this.pasport_label.AutoSize = true;
            this.pasport_label.Location = new System.Drawing.Point(31, 120);
            this.pasport_label.Name = "pasport_label";
            this.pasport_label.Size = new System.Drawing.Size(61, 17);
            this.pasport_label.TabIndex = 4;
            this.pasport_label.Text = "Pasport:";
            // 
            // name_label
            // 
            this.name_label.AutoSize = true;
            this.name_label.Location = new System.Drawing.Point(31, 79);
            this.name_label.Name = "name_label";
            this.name_label.Size = new System.Drawing.Size(49, 17);
            this.name_label.TabIndex = 5;
            this.name_label.Text = "Name:";
            // 
            // birth_label
            // 
            this.birth_label.AutoSize = true;
            this.birth_label.Location = new System.Drawing.Point(391, 120);
            this.birth_label.Name = "birth_label";
            this.birth_label.Size = new System.Drawing.Size(41, 17);
            this.birth_label.TabIndex = 6;
            this.birth_label.Text = "Birth:";
            // 
            // address_label
            // 
            this.address_label.AutoSize = true;
            this.address_label.Location = new System.Drawing.Point(391, 79);
            this.address_label.Name = "address_label";
            this.address_label.Size = new System.Drawing.Size(64, 17);
            this.address_label.TabIndex = 7;
            this.address_label.Text = "Address:";
            // 
            // personData
            // 
            this.personData.AllowUserToAddRows = false;
            this.personData.AllowUserToDeleteRows = false;
            this.personData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.personData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.personData.Location = new System.Drawing.Point(13, 194);
            this.personData.Name = "personData";
            this.personData.ReadOnly = true;
            this.personData.RowHeadersWidth = 51;
            this.personData.RowTemplate.Height = 24;
            this.personData.Size = new System.Drawing.Size(923, 228);
            this.personData.TabIndex = 1;
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
            // ok_button
            // 
            this.ok_button.Location = new System.Drawing.Point(836, 440);
            this.ok_button.Name = "ok_button";
            this.ok_button.Size = new System.Drawing.Size(100, 50);
            this.ok_button.TabIndex = 2;
            this.ok_button.Text = "ok";
            this.ok_button.UseVisualStyleBackColor = true;
            this.ok_button.Click += new System.EventHandler(this.ok_button_Click);
            // 
            // cancel_button
            // 
            this.cancel_button.Location = new System.Drawing.Point(704, 440);
            this.cancel_button.Name = "cancel_button";
            this.cancel_button.Size = new System.Drawing.Size(100, 50);
            this.cancel_button.TabIndex = 3;
            this.cancel_button.Text = "cancel";
            this.cancel_button.UseVisualStyleBackColor = true;
            this.cancel_button.Click += new System.EventHandler(this.cancel_button_Click);
            // 
            // person_search
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(948, 502);
            this.Controls.Add(this.cancel_button);
            this.Controls.Add(this.ok_button);
            this.Controls.Add(this.personData);
            this.Controls.Add(this.control_groupBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "person_search";
            this.Text = "search: person";
            this.control_groupBox.ResumeLayout(false);
            this.control_groupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.personData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox control_groupBox;
        private System.Windows.Forms.DataGridView personData;
        private System.Windows.Forms.Button ok_button;
        private System.Windows.Forms.Button cancel_button;
        private System.Windows.Forms.DateTimePicker birth_date;
        private System.Windows.Forms.TextBox address_textBox;
        private System.Windows.Forms.TextBox idcode_textBox;
        private System.Windows.Forms.TextBox id_textBox;
        private System.Windows.Forms.TextBox name_textBox;
        private System.Windows.Forms.TextBox pasport_textBox;
        private System.Windows.Forms.Button clear_button;
        private System.Windows.Forms.Button search_button;
        private System.Windows.Forms.Label id_label;
        private System.Windows.Forms.Label idcode_label;
        private System.Windows.Forms.Label pasport_label;
        private System.Windows.Forms.Label name_label;
        private System.Windows.Forms.Label birth_label;
        private System.Windows.Forms.Label address_label;
        private System.Windows.Forms.Button on_off_button;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
    }
}
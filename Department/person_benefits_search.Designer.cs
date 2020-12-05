namespace Department
{
    partial class person_benefits_search
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(person_benefits_search));
            this.control_groupBox = new System.Windows.Forms.GroupBox();
            this.start_on_off_button = new System.Windows.Forms.Button();
            this.end_on_off_button = new System.Windows.Forms.Button();
            this.end_date = new System.Windows.Forms.DateTimePicker();
            this.start_date = new System.Windows.Forms.DateTimePicker();
            this.benefits_button = new System.Windows.Forms.Button();
            this.person_button = new System.Windows.Forms.Button();
            this.id_textBox = new System.Windows.Forms.TextBox();
            this.id_label = new System.Windows.Forms.Label();
            this.benefits_label = new System.Windows.Forms.Label();
            this.person_label = new System.Windows.Forms.Label();
            this.end_label = new System.Windows.Forms.Label();
            this.start_label = new System.Windows.Forms.Label();
            this.search_button = new System.Windows.Forms.Button();
            this.clear_button = new System.Windows.Forms.Button();
            this.person_benefitsData = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fullInfo_button = new System.Windows.Forms.Button();
            this.cancel_button = new System.Windows.Forms.Button();
            this.ok_button = new System.Windows.Forms.Button();
            this.control_groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.person_benefitsData)).BeginInit();
            this.SuspendLayout();
            // 
            // control_groupBox
            // 
            this.control_groupBox.Controls.Add(this.start_on_off_button);
            this.control_groupBox.Controls.Add(this.end_on_off_button);
            this.control_groupBox.Controls.Add(this.end_date);
            this.control_groupBox.Controls.Add(this.start_date);
            this.control_groupBox.Controls.Add(this.benefits_button);
            this.control_groupBox.Controls.Add(this.person_button);
            this.control_groupBox.Controls.Add(this.id_textBox);
            this.control_groupBox.Controls.Add(this.id_label);
            this.control_groupBox.Controls.Add(this.benefits_label);
            this.control_groupBox.Controls.Add(this.person_label);
            this.control_groupBox.Controls.Add(this.end_label);
            this.control_groupBox.Controls.Add(this.start_label);
            this.control_groupBox.Controls.Add(this.search_button);
            this.control_groupBox.Controls.Add(this.clear_button);
            this.control_groupBox.Location = new System.Drawing.Point(13, 13);
            this.control_groupBox.Name = "control_groupBox";
            this.control_groupBox.Size = new System.Drawing.Size(980, 122);
            this.control_groupBox.TabIndex = 0;
            this.control_groupBox.TabStop = false;
            // 
            // start_on_off_button
            // 
            this.start_on_off_button.Location = new System.Drawing.Point(569, 18);
            this.start_on_off_button.Name = "start_on_off_button";
            this.start_on_off_button.Size = new System.Drawing.Size(50, 25);
            this.start_on_off_button.TabIndex = 18;
            this.start_on_off_button.Text = "off";
            this.start_on_off_button.UseVisualStyleBackColor = true;
            this.start_on_off_button.Click += new System.EventHandler(this.start_on_off_button_Click);
            // 
            // end_on_off_button
            // 
            this.end_on_off_button.Location = new System.Drawing.Point(908, 18);
            this.end_on_off_button.Name = "end_on_off_button";
            this.end_on_off_button.Size = new System.Drawing.Size(50, 25);
            this.end_on_off_button.TabIndex = 17;
            this.end_on_off_button.Text = "off";
            this.end_on_off_button.UseVisualStyleBackColor = true;
            this.end_on_off_button.Click += new System.EventHandler(this.end_on_off_button_Click);
            // 
            // end_date
            // 
            this.end_date.Location = new System.Drawing.Point(702, 20);
            this.end_date.Name = "end_date";
            this.end_date.Size = new System.Drawing.Size(200, 22);
            this.end_date.TabIndex = 16;
            // 
            // start_date
            // 
            this.start_date.Location = new System.Drawing.Point(363, 20);
            this.start_date.Name = "start_date";
            this.start_date.Size = new System.Drawing.Size(200, 22);
            this.start_date.TabIndex = 15;
            // 
            // benefits_button
            // 
            this.benefits_button.Location = new System.Drawing.Point(384, 63);
            this.benefits_button.Name = "benefits_button";
            this.benefits_button.Size = new System.Drawing.Size(80, 40);
            this.benefits_button.TabIndex = 14;
            this.benefits_button.Text = "select";
            this.benefits_button.UseVisualStyleBackColor = true;
            this.benefits_button.Click += new System.EventHandler(this.benefits_button_Click);
            this.benefits_button.Paint += new System.Windows.Forms.PaintEventHandler(this.benefits_button_Paint);
            // 
            // person_button
            // 
            this.person_button.Location = new System.Drawing.Point(89, 63);
            this.person_button.Name = "person_button";
            this.person_button.Size = new System.Drawing.Size(80, 40);
            this.person_button.TabIndex = 13;
            this.person_button.Text = "select";
            this.person_button.UseVisualStyleBackColor = true;
            this.person_button.Click += new System.EventHandler(this.person_button_Click);
            this.person_button.Paint += new System.Windows.Forms.PaintEventHandler(this.person_button_Paint);
            // 
            // id_textBox
            // 
            this.id_textBox.Location = new System.Drawing.Point(55, 20);
            this.id_textBox.Name = "id_textBox";
            this.id_textBox.Size = new System.Drawing.Size(214, 22);
            this.id_textBox.TabIndex = 12;
            // 
            // id_label
            // 
            this.id_label.AutoSize = true;
            this.id_label.Location = new System.Drawing.Point(26, 22);
            this.id_label.Name = "id_label";
            this.id_label.Size = new System.Drawing.Size(23, 17);
            this.id_label.TabIndex = 7;
            this.id_label.Text = "Id:";
            // 
            // benefits_label
            // 
            this.benefits_label.AutoSize = true;
            this.benefits_label.Location = new System.Drawing.Point(315, 72);
            this.benefits_label.Name = "benefits_label";
            this.benefits_label.Size = new System.Drawing.Size(63, 17);
            this.benefits_label.TabIndex = 8;
            this.benefits_label.Text = "Benefits:";
            // 
            // person_label
            // 
            this.person_label.AutoSize = true;
            this.person_label.Location = new System.Drawing.Point(26, 72);
            this.person_label.Name = "person_label";
            this.person_label.Size = new System.Drawing.Size(57, 17);
            this.person_label.TabIndex = 9;
            this.person_label.Text = "Person:";
            // 
            // end_label
            // 
            this.end_label.AutoSize = true;
            this.end_label.Location = new System.Drawing.Point(659, 22);
            this.end_label.Name = "end_label";
            this.end_label.Size = new System.Drawing.Size(37, 17);
            this.end_label.TabIndex = 10;
            this.end_label.Text = "End:";
            // 
            // start_label
            // 
            this.start_label.AutoSize = true;
            this.start_label.Location = new System.Drawing.Point(315, 22);
            this.start_label.Name = "start_label";
            this.start_label.Size = new System.Drawing.Size(42, 17);
            this.start_label.TabIndex = 11;
            this.start_label.Text = "Start:";
            // 
            // search_button
            // 
            this.search_button.Location = new System.Drawing.Point(880, 72);
            this.search_button.Name = "search_button";
            this.search_button.Size = new System.Drawing.Size(100, 50);
            this.search_button.TabIndex = 4;
            this.search_button.Text = "search";
            this.search_button.UseVisualStyleBackColor = true;
            this.search_button.Click += new System.EventHandler(this.search_button_Click);
            // 
            // clear_button
            // 
            this.clear_button.Location = new System.Drawing.Point(740, 72);
            this.clear_button.Name = "clear_button";
            this.clear_button.Size = new System.Drawing.Size(100, 50);
            this.clear_button.TabIndex = 3;
            this.clear_button.Text = "clear";
            this.clear_button.UseVisualStyleBackColor = true;
            this.clear_button.Click += new System.EventHandler(this.clear_button_Click);
            // 
            // person_benefitsData
            // 
            this.person_benefitsData.AllowUserToAddRows = false;
            this.person_benefitsData.AllowUserToDeleteRows = false;
            this.person_benefitsData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.person_benefitsData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.person_benefitsData.Location = new System.Drawing.Point(13, 142);
            this.person_benefitsData.Name = "person_benefitsData";
            this.person_benefitsData.ReadOnly = true;
            this.person_benefitsData.RowHeadersWidth = 51;
            this.person_benefitsData.RowTemplate.Height = 24;
            this.person_benefitsData.Size = new System.Drawing.Size(980, 223);
            this.person_benefitsData.TabIndex = 1;
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
            this.Column3.HeaderText = "Benefits";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 125;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Start";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 125;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "End";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 125;
            // 
            // fullInfo_button
            // 
            this.fullInfo_button.Location = new System.Drawing.Point(13, 384);
            this.fullInfo_button.Name = "fullInfo_button";
            this.fullInfo_button.Size = new System.Drawing.Size(100, 60);
            this.fullInfo_button.TabIndex = 2;
            this.fullInfo_button.Text = "full info";
            this.fullInfo_button.UseVisualStyleBackColor = true;
            this.fullInfo_button.Click += new System.EventHandler(this.fullInfo_button_Click);
            // 
            // cancel_button
            // 
            this.cancel_button.Location = new System.Drawing.Point(753, 394);
            this.cancel_button.Name = "cancel_button";
            this.cancel_button.Size = new System.Drawing.Size(100, 50);
            this.cancel_button.TabIndex = 5;
            this.cancel_button.Text = "cancel";
            this.cancel_button.UseVisualStyleBackColor = true;
            this.cancel_button.Click += new System.EventHandler(this.cancel_button_Click);
            // 
            // ok_button
            // 
            this.ok_button.Location = new System.Drawing.Point(893, 394);
            this.ok_button.Name = "ok_button";
            this.ok_button.Size = new System.Drawing.Size(100, 50);
            this.ok_button.TabIndex = 6;
            this.ok_button.Text = "ok";
            this.ok_button.UseVisualStyleBackColor = true;
            this.ok_button.Click += new System.EventHandler(this.ok_button_Click);
            // 
            // person_benefits_search
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1005, 456);
            this.Controls.Add(this.ok_button);
            this.Controls.Add(this.cancel_button);
            this.Controls.Add(this.fullInfo_button);
            this.Controls.Add(this.person_benefitsData);
            this.Controls.Add(this.control_groupBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "person_benefits_search";
            this.Text = "search: person benefits";
            this.control_groupBox.ResumeLayout(false);
            this.control_groupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.person_benefitsData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox control_groupBox;
        private System.Windows.Forms.DataGridView person_benefitsData;
        private System.Windows.Forms.Button fullInfo_button;
        private System.Windows.Forms.Button search_button;
        private System.Windows.Forms.Button clear_button;
        private System.Windows.Forms.Button cancel_button;
        private System.Windows.Forms.Button ok_button;
        private System.Windows.Forms.DateTimePicker end_date;
        private System.Windows.Forms.DateTimePicker start_date;
        private System.Windows.Forms.Button benefits_button;
        private System.Windows.Forms.Button person_button;
        private System.Windows.Forms.TextBox id_textBox;
        private System.Windows.Forms.Label id_label;
        private System.Windows.Forms.Label benefits_label;
        private System.Windows.Forms.Label person_label;
        private System.Windows.Forms.Label end_label;
        private System.Windows.Forms.Label start_label;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.Button start_on_off_button;
        private System.Windows.Forms.Button end_on_off_button;
    }
}
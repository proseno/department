namespace Department
{
    partial class benefits_search
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(benefits_search));
            this.control_groupBox = new System.Windows.Forms.GroupBox();
            this.kind_textBox = new System.Windows.Forms.TextBox();
            this.description_textBox = new System.Windows.Forms.TextBox();
            this.id_textBox = new System.Windows.Forms.TextBox();
            this.name_textBox = new System.Windows.Forms.TextBox();
            this.id_label = new System.Windows.Forms.Label();
            this.name_label = new System.Windows.Forms.Label();
            this.kind_label = new System.Windows.Forms.Label();
            this.description_label = new System.Windows.Forms.Label();
            this.clear_button = new System.Windows.Forms.Button();
            this.search_button = new System.Windows.Forms.Button();
            this.benefitsData = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cancel_button = new System.Windows.Forms.Button();
            this.ok_button = new System.Windows.Forms.Button();
            this.control_groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.benefitsData)).BeginInit();
            this.SuspendLayout();
            // 
            // control_groupBox
            // 
            this.control_groupBox.Controls.Add(this.kind_textBox);
            this.control_groupBox.Controls.Add(this.description_textBox);
            this.control_groupBox.Controls.Add(this.id_textBox);
            this.control_groupBox.Controls.Add(this.name_textBox);
            this.control_groupBox.Controls.Add(this.id_label);
            this.control_groupBox.Controls.Add(this.name_label);
            this.control_groupBox.Controls.Add(this.kind_label);
            this.control_groupBox.Controls.Add(this.description_label);
            this.control_groupBox.Controls.Add(this.clear_button);
            this.control_groupBox.Controls.Add(this.search_button);
            this.control_groupBox.Location = new System.Drawing.Point(13, 13);
            this.control_groupBox.Name = "control_groupBox";
            this.control_groupBox.Size = new System.Drawing.Size(821, 135);
            this.control_groupBox.TabIndex = 0;
            this.control_groupBox.TabStop = false;
            // 
            // kind_textBox
            // 
            this.kind_textBox.Location = new System.Drawing.Point(363, 76);
            this.kind_textBox.Name = "kind_textBox";
            this.kind_textBox.Size = new System.Drawing.Size(212, 22);
            this.kind_textBox.TabIndex = 13;
            // 
            // description_textBox
            // 
            this.description_textBox.Location = new System.Drawing.Point(363, 27);
            this.description_textBox.Name = "description_textBox";
            this.description_textBox.Size = new System.Drawing.Size(212, 22);
            this.description_textBox.TabIndex = 12;
            // 
            // id_textBox
            // 
            this.id_textBox.Location = new System.Drawing.Point(80, 27);
            this.id_textBox.Name = "id_textBox";
            this.id_textBox.Size = new System.Drawing.Size(177, 22);
            this.id_textBox.TabIndex = 11;
            // 
            // name_textBox
            // 
            this.name_textBox.Location = new System.Drawing.Point(80, 77);
            this.name_textBox.Name = "name_textBox";
            this.name_textBox.Size = new System.Drawing.Size(177, 22);
            this.name_textBox.TabIndex = 10;
            // 
            // id_label
            // 
            this.id_label.AutoSize = true;
            this.id_label.Location = new System.Drawing.Point(24, 29);
            this.id_label.Name = "id_label";
            this.id_label.Size = new System.Drawing.Size(23, 17);
            this.id_label.TabIndex = 9;
            this.id_label.Text = "Id:";
            // 
            // name_label
            // 
            this.name_label.AutoSize = true;
            this.name_label.Location = new System.Drawing.Point(24, 79);
            this.name_label.Name = "name_label";
            this.name_label.Size = new System.Drawing.Size(49, 17);
            this.name_label.TabIndex = 8;
            this.name_label.Text = "Name:";
            // 
            // kind_label
            // 
            this.kind_label.AutoSize = true;
            this.kind_label.Location = new System.Drawing.Point(273, 79);
            this.kind_label.Name = "kind_label";
            this.kind_label.Size = new System.Drawing.Size(40, 17);
            this.kind_label.TabIndex = 7;
            this.kind_label.Text = "Kind:";
            // 
            // description_label
            // 
            this.description_label.AutoSize = true;
            this.description_label.Location = new System.Drawing.Point(273, 29);
            this.description_label.Name = "description_label";
            this.description_label.Size = new System.Drawing.Size(83, 17);
            this.description_label.TabIndex = 6;
            this.description_label.Text = "Description:";
            // 
            // clear_button
            // 
            this.clear_button.Location = new System.Drawing.Point(597, 77);
            this.clear_button.Name = "clear_button";
            this.clear_button.Size = new System.Drawing.Size(100, 50);
            this.clear_button.TabIndex = 4;
            this.clear_button.Text = "clear";
            this.clear_button.UseVisualStyleBackColor = true;
            this.clear_button.Click += new System.EventHandler(this.clear_button_Click);
            // 
            // search_button
            // 
            this.search_button.Location = new System.Drawing.Point(721, 79);
            this.search_button.Name = "search_button";
            this.search_button.Size = new System.Drawing.Size(100, 50);
            this.search_button.TabIndex = 5;
            this.search_button.Text = "search";
            this.search_button.UseVisualStyleBackColor = true;
            this.search_button.Click += new System.EventHandler(this.search_button_Click);
            // 
            // benefitsData
            // 
            this.benefitsData.AllowUserToAddRows = false;
            this.benefitsData.AllowUserToDeleteRows = false;
            this.benefitsData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.benefitsData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.benefitsData.Location = new System.Drawing.Point(12, 154);
            this.benefitsData.Name = "benefitsData";
            this.benefitsData.ReadOnly = true;
            this.benefitsData.RowHeadersWidth = 51;
            this.benefitsData.RowTemplate.Height = 24;
            this.benefitsData.Size = new System.Drawing.Size(822, 212);
            this.benefitsData.TabIndex = 1;
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
            // cancel_button
            // 
            this.cancel_button.Location = new System.Drawing.Point(610, 381);
            this.cancel_button.Name = "cancel_button";
            this.cancel_button.Size = new System.Drawing.Size(100, 50);
            this.cancel_button.TabIndex = 2;
            this.cancel_button.Text = "cancel";
            this.cancel_button.UseVisualStyleBackColor = true;
            this.cancel_button.Click += new System.EventHandler(this.cancel_button_Click);
            // 
            // ok_button
            // 
            this.ok_button.Location = new System.Drawing.Point(734, 381);
            this.ok_button.Name = "ok_button";
            this.ok_button.Size = new System.Drawing.Size(100, 50);
            this.ok_button.TabIndex = 3;
            this.ok_button.Text = "ok";
            this.ok_button.UseVisualStyleBackColor = true;
            this.ok_button.Click += new System.EventHandler(this.ok_button_Click);
            // 
            // benefits_search
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(846, 443);
            this.Controls.Add(this.ok_button);
            this.Controls.Add(this.cancel_button);
            this.Controls.Add(this.benefitsData);
            this.Controls.Add(this.control_groupBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "benefits_search";
            this.Text = "search: benefits";
            this.control_groupBox.ResumeLayout(false);
            this.control_groupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.benefitsData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox control_groupBox;
        private System.Windows.Forms.DataGridView benefitsData;
        private System.Windows.Forms.TextBox kind_textBox;
        private System.Windows.Forms.TextBox description_textBox;
        private System.Windows.Forms.TextBox id_textBox;
        private System.Windows.Forms.TextBox name_textBox;
        private System.Windows.Forms.Label id_label;
        private System.Windows.Forms.Label name_label;
        private System.Windows.Forms.Label kind_label;
        private System.Windows.Forms.Label description_label;
        private System.Windows.Forms.Button clear_button;
        private System.Windows.Forms.Button search_button;
        private System.Windows.Forms.Button cancel_button;
        private System.Windows.Forms.Button ok_button;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
    }
}
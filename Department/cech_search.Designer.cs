namespace Department
{
    partial class cech_search
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(cech_search));
            this.control_groupBox = new System.Windows.Forms.GroupBox();
            this.name_textBox = new System.Windows.Forms.TextBox();
            this.id_textBox = new System.Windows.Forms.TextBox();
            this.name_label = new System.Windows.Forms.Label();
            this.id_label = new System.Windows.Forms.Label();
            this.clear_button = new System.Windows.Forms.Button();
            this.search_button = new System.Windows.Forms.Button();
            this.cechData = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ok_button = new System.Windows.Forms.Button();
            this.cancel_button = new System.Windows.Forms.Button();
            this.control_groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cechData)).BeginInit();
            this.SuspendLayout();
            // 
            // control_groupBox
            // 
            this.control_groupBox.Controls.Add(this.name_textBox);
            this.control_groupBox.Controls.Add(this.id_textBox);
            this.control_groupBox.Controls.Add(this.name_label);
            this.control_groupBox.Controls.Add(this.id_label);
            this.control_groupBox.Controls.Add(this.clear_button);
            this.control_groupBox.Controls.Add(this.search_button);
            this.control_groupBox.Location = new System.Drawing.Point(13, 13);
            this.control_groupBox.Name = "control_groupBox";
            this.control_groupBox.Size = new System.Drawing.Size(670, 95);
            this.control_groupBox.TabIndex = 0;
            this.control_groupBox.TabStop = false;
            // 
            // name_textBox
            // 
            this.name_textBox.Location = new System.Drawing.Point(103, 56);
            this.name_textBox.Name = "name_textBox";
            this.name_textBox.Size = new System.Drawing.Size(224, 22);
            this.name_textBox.TabIndex = 9;
            // 
            // id_textBox
            // 
            this.id_textBox.Location = new System.Drawing.Point(103, 13);
            this.id_textBox.Name = "id_textBox";
            this.id_textBox.Size = new System.Drawing.Size(224, 22);
            this.id_textBox.TabIndex = 8;
            // 
            // name_label
            // 
            this.name_label.AutoSize = true;
            this.name_label.Location = new System.Drawing.Point(48, 59);
            this.name_label.Name = "name_label";
            this.name_label.Size = new System.Drawing.Size(49, 17);
            this.name_label.TabIndex = 7;
            this.name_label.Text = "Name:";
            // 
            // id_label
            // 
            this.id_label.AutoSize = true;
            this.id_label.Location = new System.Drawing.Point(48, 18);
            this.id_label.Name = "id_label";
            this.id_label.Size = new System.Drawing.Size(23, 17);
            this.id_label.TabIndex = 6;
            this.id_label.Text = "Id:";
            // 
            // clear_button
            // 
            this.clear_button.Location = new System.Drawing.Point(440, 46);
            this.clear_button.Name = "clear_button";
            this.clear_button.Size = new System.Drawing.Size(100, 50);
            this.clear_button.TabIndex = 4;
            this.clear_button.Text = "clear";
            this.clear_button.UseVisualStyleBackColor = true;
            this.clear_button.Click += new System.EventHandler(this.clear_button_Click);
            // 
            // search_button
            // 
            this.search_button.Location = new System.Drawing.Point(570, 46);
            this.search_button.Name = "search_button";
            this.search_button.Size = new System.Drawing.Size(100, 50);
            this.search_button.TabIndex = 5;
            this.search_button.Text = "search";
            this.search_button.UseVisualStyleBackColor = true;
            this.search_button.Click += new System.EventHandler(this.search_button_Click);
            // 
            // cechData
            // 
            this.cechData.AllowUserToAddRows = false;
            this.cechData.AllowUserToDeleteRows = false;
            this.cechData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cechData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.cechData.Location = new System.Drawing.Point(13, 115);
            this.cechData.Name = "cechData";
            this.cechData.ReadOnly = true;
            this.cechData.RowHeadersWidth = 51;
            this.cechData.RowTemplate.Height = 24;
            this.cechData.Size = new System.Drawing.Size(670, 176);
            this.cechData.TabIndex = 1;
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
            // ok_button
            // 
            this.ok_button.Location = new System.Drawing.Point(583, 310);
            this.ok_button.Name = "ok_button";
            this.ok_button.Size = new System.Drawing.Size(100, 50);
            this.ok_button.TabIndex = 2;
            this.ok_button.Text = "ok";
            this.ok_button.UseVisualStyleBackColor = true;
            this.ok_button.Click += new System.EventHandler(this.ok_button_Click);
            // 
            // cancel_button
            // 
            this.cancel_button.Location = new System.Drawing.Point(453, 310);
            this.cancel_button.Name = "cancel_button";
            this.cancel_button.Size = new System.Drawing.Size(100, 50);
            this.cancel_button.TabIndex = 3;
            this.cancel_button.Text = "cancel";
            this.cancel_button.UseVisualStyleBackColor = true;
            this.cancel_button.Click += new System.EventHandler(this.cancel_button_Click);
            // 
            // cech_search
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(695, 372);
            this.Controls.Add(this.cancel_button);
            this.Controls.Add(this.ok_button);
            this.Controls.Add(this.cechData);
            this.Controls.Add(this.control_groupBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "cech_search";
            this.Text = "search: cech";
            this.control_groupBox.ResumeLayout(false);
            this.control_groupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cechData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox control_groupBox;
        private System.Windows.Forms.DataGridView cechData;
        private System.Windows.Forms.Button ok_button;
        private System.Windows.Forms.Button cancel_button;
        private System.Windows.Forms.Label name_label;
        private System.Windows.Forms.Label id_label;
        private System.Windows.Forms.Button clear_button;
        private System.Windows.Forms.Button search_button;
        private System.Windows.Forms.TextBox name_textBox;
        private System.Windows.Forms.TextBox id_textBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
    }
}
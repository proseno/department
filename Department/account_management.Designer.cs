namespace Department
{
    partial class account_management
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(account_management));
            this.login_label = new System.Windows.Forms.Label();
            this.password_label = new System.Windows.Forms.Label();
            this.functionality_label = new System.Windows.Forms.Label();
            this.login_textBox = new System.Windows.Forms.TextBox();
            this.password_textBox = new System.Windows.Forms.TextBox();
            this.reports_checkList = new System.Windows.Forms.CheckedListBox();
            this.submit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tables_checkList = new System.Windows.Forms.CheckedListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.isAdmin_checkBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // login_label
            // 
            this.login_label.AutoSize = true;
            this.login_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_label.Location = new System.Drawing.Point(33, 31);
            this.login_label.Name = "login_label";
            this.login_label.Size = new System.Drawing.Size(72, 29);
            this.login_label.TabIndex = 0;
            this.login_label.Text = "login:";
            // 
            // password_label
            // 
            this.password_label.AutoSize = true;
            this.password_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password_label.Location = new System.Drawing.Point(33, 89);
            this.password_label.Name = "password_label";
            this.password_label.Size = new System.Drawing.Size(124, 29);
            this.password_label.TabIndex = 1;
            this.password_label.Text = "password:";
            // 
            // functionality_label
            // 
            this.functionality_label.AutoSize = true;
            this.functionality_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.functionality_label.Location = new System.Drawing.Point(33, 155);
            this.functionality_label.Name = "functionality_label";
            this.functionality_label.Size = new System.Drawing.Size(144, 29);
            this.functionality_label.TabIndex = 2;
            this.functionality_label.Text = "functionality:";
            // 
            // login_textBox
            // 
            this.login_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_textBox.Location = new System.Drawing.Point(164, 28);
            this.login_textBox.Name = "login_textBox";
            this.login_textBox.Size = new System.Drawing.Size(340, 34);
            this.login_textBox.TabIndex = 3;
            // 
            // password_textBox
            // 
            this.password_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password_textBox.Location = new System.Drawing.Point(164, 86);
            this.password_textBox.Name = "password_textBox";
            this.password_textBox.Size = new System.Drawing.Size(340, 34);
            this.password_textBox.TabIndex = 4;
            // 
            // reports_checkList
            // 
            this.reports_checkList.BackColor = System.Drawing.SystemColors.Control;
            this.reports_checkList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.reports_checkList.CheckOnClick = true;
            this.reports_checkList.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reports_checkList.FormattingEnabled = true;
            this.reports_checkList.Items.AddRange(new object[] {
            "Workers",
            "People",
            "Benefits",
            "Cech",
            "Position",
            "Delivery",
            "Goods",
            "Storage",
            "Supplier",
            "Person benefits"});
            this.reports_checkList.Location = new System.Drawing.Point(346, 226);
            this.reports_checkList.Name = "reports_checkList";
            this.reports_checkList.Size = new System.Drawing.Size(158, 220);
            this.reports_checkList.TabIndex = 5;
            // 
            // submit
            // 
            this.submit.Location = new System.Drawing.Point(38, 471);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(250, 63);
            this.submit.TabIndex = 6;
            this.submit.Text = "submit";
            this.submit.UseVisualStyleBackColor = true;
            this.submit.Click += new System.EventHandler(this.submit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(342, 198);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Reports:";
            // 
            // tables_checkList
            // 
            this.tables_checkList.BackColor = System.Drawing.SystemColors.Control;
            this.tables_checkList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tables_checkList.CheckOnClick = true;
            this.tables_checkList.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tables_checkList.FormattingEnabled = true;
            this.tables_checkList.Items.AddRange(new object[] {
            "Workers",
            "Person",
            "Benefits",
            "Cech",
            "Position",
            "Delivery",
            "Goods",
            "Storage",
            "Supplier",
            "Person benefits"});
            this.tables_checkList.Location = new System.Drawing.Point(38, 226);
            this.tables_checkList.Name = "tables_checkList";
            this.tables_checkList.Size = new System.Drawing.Size(209, 220);
            this.tables_checkList.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(34, 198);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Tables:";
            // 
            // isAdmin_checkBox
            // 
            this.isAdmin_checkBox.AutoSize = true;
            this.isAdmin_checkBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.isAdmin_checkBox.Location = new System.Drawing.Point(408, 160);
            this.isAdmin_checkBox.Name = "isAdmin_checkBox";
            this.isAdmin_checkBox.Size = new System.Drawing.Size(96, 24);
            this.isAdmin_checkBox.TabIndex = 10;
            this.isAdmin_checkBox.Text = "is Admin";
            this.isAdmin_checkBox.UseVisualStyleBackColor = true;
            this.isAdmin_checkBox.CheckedChanged += new System.EventHandler(this.isAdmin_checkBox_CheckedChanged);
            // 
            // account_management
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 557);
            this.Controls.Add(this.isAdmin_checkBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tables_checkList);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.submit);
            this.Controls.Add(this.reports_checkList);
            this.Controls.Add(this.password_textBox);
            this.Controls.Add(this.login_textBox);
            this.Controls.Add(this.functionality_label);
            this.Controls.Add(this.password_label);
            this.Controls.Add(this.login_label);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "account_management";
            this.Text = "Account management";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label login_label;
        private System.Windows.Forms.Label password_label;
        private System.Windows.Forms.Label functionality_label;
        private System.Windows.Forms.TextBox login_textBox;
        private System.Windows.Forms.TextBox password_textBox;
        private System.Windows.Forms.CheckedListBox reports_checkList;
        private System.Windows.Forms.Button submit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckedListBox tables_checkList;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox isAdmin_checkBox;
    }
}
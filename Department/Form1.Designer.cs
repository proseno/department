namespace Department
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.header_label = new System.Windows.Forms.Label();
            this.connect_button = new System.Windows.Forms.Button();
            this.login_textBox = new System.Windows.Forms.TextBox();
            this.password_textBox = new System.Windows.Forms.TextBox();
            this.login_label = new System.Windows.Forms.Label();
            this.password_label = new System.Windows.Forms.Label();
            this.visible_button = new System.Windows.Forms.Button();
            this.error_label = new System.Windows.Forms.Label();
            this.error_img = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.error_img)).BeginInit();
            this.SuspendLayout();
            // 
            // header_label
            // 
            this.header_label.AutoSize = true;
            this.header_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.header_label.Location = new System.Drawing.Point(99, 56);
            this.header_label.Name = "header_label";
            this.header_label.Size = new System.Drawing.Size(369, 36);
            this.header_label.TabIndex = 0;
            this.header_label.Text = "Department: authentication";
            // 
            // connect_button
            // 
            this.connect_button.Location = new System.Drawing.Point(235, 271);
            this.connect_button.Name = "connect_button";
            this.connect_button.Size = new System.Drawing.Size(180, 59);
            this.connect_button.TabIndex = 1;
            this.connect_button.Text = "Connect";
            this.connect_button.UseVisualStyleBackColor = true;
            this.connect_button.Click += new System.EventHandler(this.connect_button_Click);
            // 
            // login_textBox
            // 
            this.login_textBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.login_textBox.Location = new System.Drawing.Point(235, 132);
            this.login_textBox.MaxLength = 128;
            this.login_textBox.Name = "login_textBox";
            this.login_textBox.Size = new System.Drawing.Size(350, 34);
            this.login_textBox.TabIndex = 2;
            this.login_textBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.login_textBox_KeyDown);
            // 
            // password_textBox
            // 
            this.password_textBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.password_textBox.Location = new System.Drawing.Point(235, 194);
            this.password_textBox.MaxLength = 128;
            this.password_textBox.Name = "password_textBox";
            this.password_textBox.Size = new System.Drawing.Size(350, 34);
            this.password_textBox.TabIndex = 3;
            this.password_textBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.password_textBox_KeyDown);
            // 
            // login_label
            // 
            this.login_label.AutoSize = true;
            this.login_label.Location = new System.Drawing.Point(100, 137);
            this.login_label.Name = "login_label";
            this.login_label.Size = new System.Drawing.Size(72, 29);
            this.login_label.TabIndex = 4;
            this.login_label.Text = "login:";
            // 
            // password_label
            // 
            this.password_label.AutoSize = true;
            this.password_label.Location = new System.Drawing.Point(100, 194);
            this.password_label.Name = "password_label";
            this.password_label.Size = new System.Drawing.Size(124, 29);
            this.password_label.TabIndex = 5;
            this.password_label.Text = "password:";
            // 
            // visible_button
            // 
            this.visible_button.BackColor = System.Drawing.Color.Transparent;
            this.visible_button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("visible_button.BackgroundImage")));
            this.visible_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.visible_button.FlatAppearance.BorderSize = 0;
            this.visible_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.visible_button.Location = new System.Drawing.Point(591, 192);
            this.visible_button.Name = "visible_button";
            this.visible_button.Size = new System.Drawing.Size(34, 34);
            this.visible_button.TabIndex = 6;
            this.visible_button.UseVisualStyleBackColor = true;
            this.visible_button.Click += new System.EventHandler(this.visible_button_Click);
            this.visible_button.Paint += new System.Windows.Forms.PaintEventHandler(this.visible_button_Paint);
            // 
            // error_label
            // 
            this.error_label.AutoSize = true;
            this.error_label.BackColor = System.Drawing.Color.Transparent;
            this.error_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.error_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(48)))), ((int)(((byte)(37)))));
            this.error_label.Location = new System.Drawing.Point(261, 109);
            this.error_label.Name = "error_label";
            this.error_label.Size = new System.Drawing.Size(195, 20);
            this.error_label.TabIndex = 7;
            this.error_label.Text = "Wrong login or password\r\n";
            this.error_label.Visible = false;
            // 
            // error_img
            // 
            this.error_img.BackColor = System.Drawing.Color.Transparent;
            this.error_img.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("error_img.BackgroundImage")));
            this.error_img.Location = new System.Drawing.Point(236, 108);
            this.error_img.Name = "error_img";
            this.error_img.Size = new System.Drawing.Size(20, 20);
            this.error_img.TabIndex = 8;
            this.error_img.TabStop = false;
            this.error_img.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 403);
            this.Controls.Add(this.error_img);
            this.Controls.Add(this.error_label);
            this.Controls.Add(this.visible_button);
            this.Controls.Add(this.password_label);
            this.Controls.Add(this.login_label);
            this.Controls.Add(this.password_textBox);
            this.Controls.Add(this.login_textBox);
            this.Controls.Add(this.connect_button);
            this.Controls.Add(this.header_label);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Department: authentication";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.error_img)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label header_label;
        private System.Windows.Forms.Button connect_button;
        private System.Windows.Forms.TextBox login_textBox;
        private System.Windows.Forms.TextBox password_textBox;
        private System.Windows.Forms.Label login_label;
        private System.Windows.Forms.Label password_label;
        private System.Windows.Forms.Button visible_button;
        private System.Windows.Forms.Label error_label;
        private System.Windows.Forms.PictureBox error_img;
    }
}


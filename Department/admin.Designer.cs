namespace Department
{
    partial class admin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(admin));
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.tables_menu = new System.Windows.Forms.ToolStripMenuItem();
            this.person_table = new System.Windows.Forms.ToolStripMenuItem();
            this.position_table = new System.Windows.Forms.ToolStripMenuItem();
            this.workers_table = new System.Windows.Forms.ToolStripMenuItem();
            this.benefits_table = new System.Windows.Forms.ToolStripMenuItem();
            this.personBenefits_table = new System.Windows.Forms.ToolStripMenuItem();
            this.cech_table = new System.Windows.Forms.ToolStripMenuItem();
            this.goods_table = new System.Windows.Forms.ToolStripMenuItem();
            this.storage_table = new System.Windows.Forms.ToolStripMenuItem();
            this.supplier_table = new System.Windows.Forms.ToolStripMenuItem();
            this.delivery_table = new System.Windows.Forms.ToolStripMenuItem();
            this.reportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.workersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.peopleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.benefitsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cechToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.positionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deliveryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.goodsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.storageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.supplierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.personBenefitsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip2
            // 
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tables_menu,
            this.reportsToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Padding = new System.Windows.Forms.Padding(14, 4, 0, 4);
            this.menuStrip2.Size = new System.Drawing.Size(982, 32);
            this.menuStrip2.TabIndex = 1;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // tables_menu
            // 
            this.tables_menu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.person_table,
            this.position_table,
            this.workers_table,
            this.benefits_table,
            this.personBenefits_table,
            this.cech_table,
            this.goods_table,
            this.storage_table,
            this.supplier_table,
            this.delivery_table});
            this.tables_menu.Name = "tables_menu";
            this.tables_menu.Size = new System.Drawing.Size(64, 24);
            this.tables_menu.Text = "Tables";
            // 
            // person_table
            // 
            this.person_table.Image = ((System.Drawing.Image)(resources.GetObject("person_table.Image")));
            this.person_table.Name = "person_table";
            this.person_table.Size = new System.Drawing.Size(224, 26);
            this.person_table.Text = "Person";
            this.person_table.Click += new System.EventHandler(this.person_table_Click);
            // 
            // position_table
            // 
            this.position_table.Image = ((System.Drawing.Image)(resources.GetObject("position_table.Image")));
            this.position_table.Name = "position_table";
            this.position_table.Size = new System.Drawing.Size(204, 26);
            this.position_table.Text = "Position";
            this.position_table.Click += new System.EventHandler(this.position_table_Click);
            // 
            // workers_table
            // 
            this.workers_table.Image = ((System.Drawing.Image)(resources.GetObject("workers_table.Image")));
            this.workers_table.Name = "workers_table";
            this.workers_table.Size = new System.Drawing.Size(204, 26);
            this.workers_table.Text = "Worker";
            this.workers_table.Click += new System.EventHandler(this.workers_table_Click);
            // 
            // benefits_table
            // 
            this.benefits_table.Image = ((System.Drawing.Image)(resources.GetObject("benefits_table.Image")));
            this.benefits_table.Name = "benefits_table";
            this.benefits_table.Size = new System.Drawing.Size(204, 26);
            this.benefits_table.Text = "Benefits";
            this.benefits_table.Click += new System.EventHandler(this.benefits_table_Click);
            // 
            // personBenefits_table
            // 
            this.personBenefits_table.Image = ((System.Drawing.Image)(resources.GetObject("personBenefits_table.Image")));
            this.personBenefits_table.Name = "personBenefits_table";
            this.personBenefits_table.Size = new System.Drawing.Size(204, 26);
            this.personBenefits_table.Text = "Person benefits";
            this.personBenefits_table.Click += new System.EventHandler(this.personBenefits_table_Click);
            // 
            // cech_table
            // 
            this.cech_table.Image = ((System.Drawing.Image)(resources.GetObject("cech_table.Image")));
            this.cech_table.Name = "cech_table";
            this.cech_table.Size = new System.Drawing.Size(204, 26);
            this.cech_table.Text = "Cech";
            this.cech_table.Click += new System.EventHandler(this.cech_table_Click);
            // 
            // goods_table
            // 
            this.goods_table.Image = ((System.Drawing.Image)(resources.GetObject("goods_table.Image")));
            this.goods_table.Name = "goods_table";
            this.goods_table.Size = new System.Drawing.Size(204, 26);
            this.goods_table.Text = "Goods";
            this.goods_table.Click += new System.EventHandler(this.goods_table_Click);
            // 
            // storage_table
            // 
            this.storage_table.Image = ((System.Drawing.Image)(resources.GetObject("storage_table.Image")));
            this.storage_table.Name = "storage_table";
            this.storage_table.Size = new System.Drawing.Size(204, 26);
            this.storage_table.Text = "Storage";
            this.storage_table.Click += new System.EventHandler(this.storage_table_Click);
            // 
            // supplier_table
            // 
            this.supplier_table.Image = ((System.Drawing.Image)(resources.GetObject("supplier_table.Image")));
            this.supplier_table.Name = "supplier_table";
            this.supplier_table.Size = new System.Drawing.Size(204, 26);
            this.supplier_table.Text = "Supplier";
            this.supplier_table.Click += new System.EventHandler(this.supplier_table_Click);
            // 
            // delivery_table
            // 
            this.delivery_table.Image = ((System.Drawing.Image)(resources.GetObject("delivery_table.Image")));
            this.delivery_table.Name = "delivery_table";
            this.delivery_table.Size = new System.Drawing.Size(204, 26);
            this.delivery_table.Text = "Delivery";
            this.delivery_table.Click += new System.EventHandler(this.delivery_table_Click);
            // 
            // reportsToolStripMenuItem
            // 
            this.reportsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.workersToolStripMenuItem,
            this.peopleToolStripMenuItem,
            this.benefitsToolStripMenuItem,
            this.cechToolStripMenuItem,
            this.positionToolStripMenuItem,
            this.deliveryToolStripMenuItem,
            this.goodsToolStripMenuItem,
            this.storageToolStripMenuItem,
            this.supplierToolStripMenuItem,
            this.personBenefitsToolStripMenuItem});
            this.reportsToolStripMenuItem.Name = "reportsToolStripMenuItem";
            this.reportsToolStripMenuItem.Size = new System.Drawing.Size(74, 24);
            this.reportsToolStripMenuItem.Text = "Reports";
            // 
            // workersToolStripMenuItem
            // 
            this.workersToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("workersToolStripMenuItem.Image")));
            this.workersToolStripMenuItem.Name = "workersToolStripMenuItem";
            this.workersToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.workersToolStripMenuItem.Text = "Workers";
            this.workersToolStripMenuItem.Click += new System.EventHandler(this.workersToolStripMenuItem_Click);
            // 
            // peopleToolStripMenuItem
            // 
            this.peopleToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("peopleToolStripMenuItem.Image")));
            this.peopleToolStripMenuItem.Name = "peopleToolStripMenuItem";
            this.peopleToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.peopleToolStripMenuItem.Text = "People";
            this.peopleToolStripMenuItem.Click += new System.EventHandler(this.peopleToolStripMenuItem_Click);
            // 
            // benefitsToolStripMenuItem
            // 
            this.benefitsToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("benefitsToolStripMenuItem.Image")));
            this.benefitsToolStripMenuItem.Name = "benefitsToolStripMenuItem";
            this.benefitsToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.benefitsToolStripMenuItem.Text = "Benefits";
            this.benefitsToolStripMenuItem.Click += new System.EventHandler(this.benefitsToolStripMenuItem_Click);
            // 
            // cechToolStripMenuItem
            // 
            this.cechToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("cechToolStripMenuItem.Image")));
            this.cechToolStripMenuItem.Name = "cechToolStripMenuItem";
            this.cechToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.cechToolStripMenuItem.Text = "Cech";
            this.cechToolStripMenuItem.Click += new System.EventHandler(this.cechToolStripMenuItem_Click);
            // 
            // positionToolStripMenuItem
            // 
            this.positionToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("positionToolStripMenuItem.Image")));
            this.positionToolStripMenuItem.Name = "positionToolStripMenuItem";
            this.positionToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.positionToolStripMenuItem.Text = "Position";
            this.positionToolStripMenuItem.Click += new System.EventHandler(this.positionToolStripMenuItem_Click);
            // 
            // deliveryToolStripMenuItem
            // 
            this.deliveryToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("deliveryToolStripMenuItem.Image")));
            this.deliveryToolStripMenuItem.Name = "deliveryToolStripMenuItem";
            this.deliveryToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.deliveryToolStripMenuItem.Text = "Delivery";
            this.deliveryToolStripMenuItem.Click += new System.EventHandler(this.deliveryToolStripMenuItem_Click);
            // 
            // goodsToolStripMenuItem
            // 
            this.goodsToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("goodsToolStripMenuItem.Image")));
            this.goodsToolStripMenuItem.Name = "goodsToolStripMenuItem";
            this.goodsToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.goodsToolStripMenuItem.Text = "Goods";
            this.goodsToolStripMenuItem.Click += new System.EventHandler(this.goodsToolStripMenuItem_Click);
            // 
            // storageToolStripMenuItem
            // 
            this.storageToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("storageToolStripMenuItem.Image")));
            this.storageToolStripMenuItem.Name = "storageToolStripMenuItem";
            this.storageToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.storageToolStripMenuItem.Text = "Storage";
            this.storageToolStripMenuItem.Click += new System.EventHandler(this.storageToolStripMenuItem_Click);
            // 
            // supplierToolStripMenuItem
            // 
            this.supplierToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("supplierToolStripMenuItem.Image")));
            this.supplierToolStripMenuItem.Name = "supplierToolStripMenuItem";
            this.supplierToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.supplierToolStripMenuItem.Text = "Supplier";
            this.supplierToolStripMenuItem.Click += new System.EventHandler(this.supplierToolStripMenuItem_Click);
            // 
            // personBenefitsToolStripMenuItem
            // 
            this.personBenefitsToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("personBenefitsToolStripMenuItem.Image")));
            this.personBenefitsToolStripMenuItem.Name = "personBenefitsToolStripMenuItem";
            this.personBenefitsToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.personBenefitsToolStripMenuItem.Text = "Person benefits";
            this.personBenefitsToolStripMenuItem.Click += new System.EventHandler(this.personBenefitsToolStripMenuItem_Click);
            // 
            // admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 553);
            this.Controls.Add(this.menuStrip2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "admin";
            this.Text = "admin";
            this.Load += new System.EventHandler(this.admin_Load);
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem tables_menu;
        private System.Windows.Forms.ToolStripMenuItem person_table;
        private System.Windows.Forms.ToolStripMenuItem position_table;
        private System.Windows.Forms.ToolStripMenuItem workers_table;
        private System.Windows.Forms.ToolStripMenuItem benefits_table;
        private System.Windows.Forms.ToolStripMenuItem personBenefits_table;
        private System.Windows.Forms.ToolStripMenuItem cech_table;
        private System.Windows.Forms.ToolStripMenuItem goods_table;
        private System.Windows.Forms.ToolStripMenuItem storage_table;
        private System.Windows.Forms.ToolStripMenuItem supplier_table;
        private System.Windows.Forms.ToolStripMenuItem delivery_table;
        private System.Windows.Forms.ToolStripMenuItem reportsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem workersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem peopleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem benefitsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cechToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem positionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deliveryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem goodsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem storageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem supplierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem personBenefitsToolStripMenuItem;
    }
}
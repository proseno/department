namespace Department
{
    partial class storage_reports
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.commonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.allStoragesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewer = new Microsoft.Reporting.WinForms.ReportViewer();
            this.Procedures = new Department.Procedures();
            this.storageFullInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.storageFullInfoTableAdapter = new Department.ProceduresTableAdapters.storageFullInfoTableAdapter();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Procedures)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.storageFullInfoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.commonToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(874, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // commonToolStripMenuItem
            // 
            this.commonToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.allStoragesToolStripMenuItem});
            this.commonToolStripMenuItem.Name = "commonToolStripMenuItem";
            this.commonToolStripMenuItem.Size = new System.Drawing.Size(84, 24);
            this.commonToolStripMenuItem.Text = "Common";
            // 
            // allStoragesToolStripMenuItem
            // 
            this.allStoragesToolStripMenuItem.Name = "allStoragesToolStripMenuItem";
            this.allStoragesToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.allStoragesToolStripMenuItem.Text = "All storages";
            this.allStoragesToolStripMenuItem.Click += new System.EventHandler(this.allStoragesToolStripMenuItem_Click);
            // 
            // viewer
            // 
            this.viewer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            reportDataSource1.Name = "storageFullInfo";
            reportDataSource1.Value = this.storageFullInfoBindingSource;
            this.viewer.LocalReport.DataSources.Add(reportDataSource1);
            this.viewer.LocalReport.ReportEmbeddedResource = "Department.storageFullInfo.rdlc";
            this.viewer.Location = new System.Drawing.Point(12, 31);
            this.viewer.Name = "viewer";
            this.viewer.ServerReport.BearerToken = null;
            this.viewer.Size = new System.Drawing.Size(850, 463);
            this.viewer.TabIndex = 1;
            // 
            // Procedures
            // 
            this.Procedures.DataSetName = "Procedures";
            this.Procedures.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // storageFullInfoBindingSource
            // 
            this.storageFullInfoBindingSource.DataMember = "storageFullInfo";
            this.storageFullInfoBindingSource.DataSource = this.Procedures;
            // 
            // storageFullInfoTableAdapter
            // 
            this.storageFullInfoTableAdapter.ClearBeforeFill = true;
            // 
            // storage_reports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(874, 506);
            this.Controls.Add(this.viewer);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "storage_reports";
            this.Text = "storage_reports";
            this.Load += new System.EventHandler(this.storage_reports_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Procedures)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.storageFullInfoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem commonToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem allStoragesToolStripMenuItem;
        private Microsoft.Reporting.WinForms.ReportViewer viewer;
        private System.Windows.Forms.BindingSource storageFullInfoBindingSource;
        private Procedures Procedures;
        private ProceduresTableAdapters.storageFullInfoTableAdapter storageFullInfoTableAdapter;
    }
}
namespace Department
{
    partial class workers_reports
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.workersFullInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Procedures = new Department.Procedures();
            this.workers_reports_menu = new System.Windows.Forms.MenuStrip();
            this.common_menu = new System.Windows.Forms.ToolStripMenuItem();
            this.onJob_category = new System.Windows.Forms.ToolStripMenuItem();
            this.viewer = new Microsoft.Reporting.WinForms.ReportViewer();
            this.workersFullInfoTableAdapter = new Department.ProceduresTableAdapters.workersFullInfoTableAdapter();
            this.workers_to_one_personBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.workers_to_one_personTableAdapter = new Department.ProceduresTableAdapters.workers_to_one_personTableAdapter();
            this.perPersonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.workersFullInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Procedures)).BeginInit();
            this.workers_reports_menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.workers_to_one_personBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // workersFullInfoBindingSource
            // 
            this.workersFullInfoBindingSource.DataMember = "workersFullInfo";
            this.workersFullInfoBindingSource.DataSource = this.Procedures;
            // 
            // Procedures
            // 
            this.Procedures.DataSetName = "Procedures";
            this.Procedures.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // workers_reports_menu
            // 
            this.workers_reports_menu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.workers_reports_menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.common_menu});
            this.workers_reports_menu.Location = new System.Drawing.Point(0, 0);
            this.workers_reports_menu.Name = "workers_reports_menu";
            this.workers_reports_menu.Size = new System.Drawing.Size(1126, 28);
            this.workers_reports_menu.TabIndex = 1;
            this.workers_reports_menu.Text = "menuStrip1";
            // 
            // common_menu
            // 
            this.common_menu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.onJob_category,
            this.perPersonToolStripMenuItem});
            this.common_menu.Name = "common_menu";
            this.common_menu.Size = new System.Drawing.Size(84, 24);
            this.common_menu.Text = "Common";
            // 
            // onJob_category
            // 
            this.onJob_category.Name = "onJob_category";
            this.onJob_category.Size = new System.Drawing.Size(224, 26);
            this.onJob_category.Text = "All workers";
            this.onJob_category.Click += new System.EventHandler(this.onJob_category_Click);
            // 
            // viewer
            // 
            this.viewer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            reportDataSource3.Name = "workers_full_report";
            reportDataSource3.Value = this.workersFullInfoBindingSource;
            this.viewer.LocalReport.DataSources.Add(reportDataSource3);
            this.viewer.LocalReport.ReportEmbeddedResource = "Department.workers_full_report.rdlc";
            this.viewer.Location = new System.Drawing.Point(13, 32);
            this.viewer.Name = "viewer";
            this.viewer.ServerReport.BearerToken = null;
            this.viewer.Size = new System.Drawing.Size(1101, 508);
            this.viewer.TabIndex = 2;
            // 
            // workersFullInfoTableAdapter
            // 
            this.workersFullInfoTableAdapter.ClearBeforeFill = true;
            // 
            // workers_to_one_personBindingSource
            // 
            this.workers_to_one_personBindingSource.DataMember = "workers_to_one_person";
            this.workers_to_one_personBindingSource.DataSource = this.Procedures;
            // 
            // workers_to_one_personTableAdapter
            // 
            this.workers_to_one_personTableAdapter.ClearBeforeFill = true;
            // 
            // perPersonToolStripMenuItem
            // 
            this.perPersonToolStripMenuItem.Name = "perPersonToolStripMenuItem";
            this.perPersonToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.perPersonToolStripMenuItem.Text = "Now working";
            this.perPersonToolStripMenuItem.Click += new System.EventHandler(this.perPersonToolStripMenuItem_Click);
            // 
            // workers_reports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1126, 561);
            this.Controls.Add(this.viewer);
            this.Controls.Add(this.workers_reports_menu);
            this.MainMenuStrip = this.workers_reports_menu;
            this.Name = "workers_reports";
            this.Text = "workers_reports";
            this.Load += new System.EventHandler(this.workers_reports_Load);
            ((System.ComponentModel.ISupportInitialize)(this.workersFullInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Procedures)).EndInit();
            this.workers_reports_menu.ResumeLayout(false);
            this.workers_reports_menu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.workers_to_one_personBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip workers_reports_menu;
        private System.Windows.Forms.ToolStripMenuItem common_menu;
        private System.Windows.Forms.ToolStripMenuItem onJob_category;
        private Microsoft.Reporting.WinForms.ReportViewer viewer;
        private System.Windows.Forms.BindingSource workersFullInfoBindingSource;
        private Procedures Procedures;
        private ProceduresTableAdapters.workersFullInfoTableAdapter workersFullInfoTableAdapter;
        private System.Windows.Forms.BindingSource workers_to_one_personBindingSource;
        private ProceduresTableAdapters.workers_to_one_personTableAdapter workers_to_one_personTableAdapter;
        private System.Windows.Forms.ToolStripMenuItem perPersonToolStripMenuItem;
    }
}
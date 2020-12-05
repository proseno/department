namespace Department
{
    partial class person_reports
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.commonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.allPeopleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewer = new Microsoft.Reporting.WinForms.ReportViewer();
            this.Procedures = new Department.Procedures();
            this.personFullInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.personFullInfoTableAdapter = new Department.ProceduresTableAdapters.personFullInfoTableAdapter();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Procedures)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personFullInfoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.commonToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1229, 38);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // commonToolStripMenuItem
            // 
            this.commonToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.allPeopleToolStripMenuItem});
            this.commonToolStripMenuItem.Name = "commonToolStripMenuItem";
            this.commonToolStripMenuItem.Size = new System.Drawing.Size(84, 34);
            this.commonToolStripMenuItem.Text = "Common";
            // 
            // allPeopleToolStripMenuItem
            // 
            this.allPeopleToolStripMenuItem.Name = "allPeopleToolStripMenuItem";
            this.allPeopleToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.allPeopleToolStripMenuItem.Text = "All people";
            this.allPeopleToolStripMenuItem.Click += new System.EventHandler(this.allPeopleToolStripMenuItem_Click);
            // 
            // viewer
            // 
            this.viewer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            reportDataSource2.Name = "personFullInfo";
            reportDataSource2.Value = this.personFullInfoBindingSource;
            this.viewer.LocalReport.DataSources.Add(reportDataSource2);
            this.viewer.LocalReport.ReportEmbeddedResource = "Department.personFullInfo.rdlc";
            this.viewer.Location = new System.Drawing.Point(12, 31);
            this.viewer.Name = "viewer";
            this.viewer.ServerReport.BearerToken = null;
            this.viewer.Size = new System.Drawing.Size(961, 520);
            this.viewer.TabIndex = 1;
            // 
            // Procedures
            // 
            this.Procedures.DataSetName = "Procedures";
            this.Procedures.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // personFullInfoBindingSource
            // 
            this.personFullInfoBindingSource.DataMember = "personFullInfo";
            this.personFullInfoBindingSource.DataSource = this.Procedures;
            // 
            // personFullInfoTableAdapter
            // 
            this.personFullInfoTableAdapter.ClearBeforeFill = true;
            // 
            // person_reports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(983, 563);
            this.Controls.Add(this.viewer);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "person_reports";
            this.Text = "person_reports";
            this.Load += new System.EventHandler(this.person_reports_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Procedures)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personFullInfoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem commonToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem allPeopleToolStripMenuItem;
        private Microsoft.Reporting.WinForms.ReportViewer viewer;
        private System.Windows.Forms.BindingSource personFullInfoBindingSource;
        private Procedures Procedures;
        private ProceduresTableAdapters.personFullInfoTableAdapter personFullInfoTableAdapter;
    }
}
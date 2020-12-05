using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Department
{
    public partial class storage_reports : Form
    {
        public storage_reports()
        {
            InitializeComponent();
        }

        private void storage_reports_Load(object sender, EventArgs e)
        {
            this.viewer.Reset();
            this.viewer.RefreshReport();
        }

        private void allStoragesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.storageFullInfoTableAdapter.Fill(this.Procedures.storageFullInfo);
            this.viewer.Reset();
            ReportDataSource rds = new ReportDataSource("storageFullInfo");
            rds.Value = this.storageFullInfoBindingSource;
            viewer.LocalReport.DataSources.Add(rds);
            viewer.LocalReport.ReportPath = @"C:\Users\acer\Desktop\Studing\C#\Department\Department\storageFullInfo.rdlc";
            viewer.RefreshReport();
        }
    }
}

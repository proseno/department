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
    public partial class cech_reports : Form
    {
        public cech_reports()
        {
            InitializeComponent();
        }

        private void cech_reports_Load(object sender, EventArgs e)
        {
            this.viewer.Reset();
            this.viewer.RefreshReport();
        }

        private void allCechToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.cechFullInfoTableAdapter.Fill(this.Procedures.cechFullInfo);
            this.viewer.Reset();
            ReportDataSource rds = new ReportDataSource("cechFullInfo");
            rds.Value = this.cechFullInfoBindingSource;
            viewer.LocalReport.DataSources.Add(rds);
            viewer.LocalReport.ReportPath = @"C:\Users\acer\Desktop\Studing\C#\Department\Department\cechFullInfo.rdlc";
            viewer.RefreshReport();
        }
    }
}

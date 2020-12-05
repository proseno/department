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
    public partial class benefits_reports : Form
    {
        public benefits_reports()
        {
            InitializeComponent();
        }

        private void benefits_reports_Load(object sender, EventArgs e)
        {
            this.viewer.Reset();
            this.viewer.RefreshReport();
        }

        private void allBenefitsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.benefitsFullInfoTableAdapter.Fill(this.Procedures.benefitsFullInfo);
            this.viewer.Reset();
            ReportDataSource rds = new ReportDataSource("benefitsFullInfo");
            rds.Value = this.benefitsFullInfoBindingSource;
            viewer.LocalReport.DataSources.Add(rds);
            viewer.LocalReport.ReportPath = @"C:\Users\acer\Desktop\Studing\C#\Department\Department\benefitsFullInfo.rdlc";
            viewer.RefreshReport();
        }
    }
}

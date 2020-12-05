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
    public partial class workers_reports : Form
    {
        public workers_reports()
        {
            InitializeComponent();
        }

        private void workers_reports_Load(object sender, EventArgs e)
        {
            this.viewer.Reset();
            this.viewer.RefreshReport();
        }

        private void onJob_category_Click(object sender, EventArgs e)
        {

            this.workers_to_one_personTableAdapter.Fill(this.Procedures.workers_to_one_person);
            this.viewer.Reset();
            ReportDataSource rds = new ReportDataSource("workers_to_one_person");
            rds.Value = this.workers_to_one_personBindingSource;
            viewer.LocalReport.DataSources.Add(rds);
            viewer.LocalReport.ReportPath = @"C:\Users\acer\Desktop\Studing\C#\Department\Department\workers_by_person.rdlc";
            viewer.RefreshReport();
        }

        private void perPersonToolStripMenuItem_Click(object sender, EventArgs e)
        {

            this.workersFullInfoTableAdapter.Fill(this.Procedures.workersFullInfo);
            this.viewer.Reset();
            ReportDataSource rds = new ReportDataSource("workers_full_report");
            rds.Value = this.workersFullInfoBindingSource;
            viewer.LocalReport.DataSources.Add(rds);
            viewer.LocalReport.ReportPath = @"C:\Users\acer\Desktop\Studing\C#\Department\Department\workers_full_report.rdlc";
            viewer.RefreshReport();
        }
    }
}

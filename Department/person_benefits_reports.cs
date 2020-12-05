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
    public partial class person_benefits_reports : Form
    {
        public person_benefits_reports()
        {
            InitializeComponent();
        }

        private void allBenefitsPerPersonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.person_benefitsFullInfoTableAdapter.Fill(this.Procedures.person_benefitsFullInfo);
            this.viewer.Reset();
            ReportDataSource rds = new ReportDataSource("person_benefitsFullInfo");
            rds.Value = this.person_benefitsFullInfoBindingSource;
            viewer.LocalReport.DataSources.Add(rds);
            viewer.LocalReport.ReportPath = @"C:\Users\acer\Desktop\Studing\C#\Department\Department\person_benefitsFullInfo.rdlc";
            viewer.RefreshReport();
        }

        private void person_benefits_reports_Load(object sender, EventArgs e)
        {
            this.viewer.Reset();
            this.viewer.RefreshReport();
        }
    }
}

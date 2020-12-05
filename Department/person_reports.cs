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
    public partial class person_reports : Form
    {
        public person_reports()
        {
            InitializeComponent();
        }

        private void person_reports_Load(object sender, EventArgs e)
        {
            this.viewer.Reset();
            this.viewer.RefreshReport();
        }

        private void allPeopleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.personFullInfoTableAdapter.Fill(this.Procedures.personFullInfo);
            this.viewer.Reset();
            ReportDataSource rds = new ReportDataSource("personFullInfo");
            rds.Value = this.personFullInfoBindingSource;
            viewer.LocalReport.DataSources.Add(rds);
            viewer.LocalReport.ReportPath = @"C:\Users\acer\Desktop\Studing\C#\Department\Department\personFullInfo.rdlc";
            viewer.RefreshReport();
        }
    }
}

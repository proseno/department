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
    public partial class position_reports : Form
    {
        public position_reports()
        {
            InitializeComponent();
        }

        private void position_reports_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'Procedures.positionFullInfo' table. You can move, or remove it, as needed.
            this.positionFullInfoTableAdapter.Fill(this.Procedures.positionFullInfo);
            this.viewer.Reset();
            this.viewer.RefreshReport();
        }

        private void allPositionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.positionFullInfoTableAdapter.Fill(this.Procedures.positionFullInfo);
            this.viewer.Reset();
            ReportDataSource rds = new ReportDataSource("positionFullInfo");
            rds.Value = this.positionFullInfoBindingSource;
            viewer.LocalReport.DataSources.Add(rds);
            viewer.LocalReport.ReportPath = @"C:\Users\acer\Desktop\Studing\C#\Department\Department\positionFullInfo.rdlc";
            viewer.RefreshReport();
        }
    }
}

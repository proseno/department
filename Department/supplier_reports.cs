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
    public partial class supplier_reports : Form
    {
        public supplier_reports()
        {
            InitializeComponent();
        }

        private void allSuppliersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.supplierFullInfoTableAdapter.Fill(this.Procedures.supplierFullInfo);
            this.viewer.Reset();
            ReportDataSource rds = new ReportDataSource("supplierFullInfo");
            rds.Value = this.supplierFullInfoBindingSource;
            viewer.LocalReport.DataSources.Add(rds);
            viewer.LocalReport.ReportPath = @"C:\Users\acer\Desktop\Studing\C#\Department\Department\supplierFullInfo.rdlc";
            viewer.RefreshReport();
        }

        private void supplier_reports_Load(object sender, EventArgs e)
        {
            this.viewer.Reset();
            this.viewer.RefreshReport();
        }
    }
}

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
    public partial class delivery_reports : Form
    {
        public delivery_reports()
        {
            InitializeComponent();
        }

        private void delivery_reports_Load(object sender, EventArgs e)
        {
            this.viewer.Reset();
            this.viewer.RefreshReport();
        }

        private void allDeliveryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.deliveryFullInfoTableAdapter.Fill(this.Procedures.deliveryFullInfo);
            this.viewer.Reset();
            ReportDataSource rds = new ReportDataSource("deliveryFullInfo");
            rds.Value = this.deliveryFullInfoBindingSource;
            viewer.LocalReport.DataSources.Add(rds);
            viewer.LocalReport.ReportPath = @"C:\Users\acer\Desktop\Studing\C#\Department\Department\deliveryFullInfo.rdlc";
            viewer.RefreshReport();
        }
    }
}

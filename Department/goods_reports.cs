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
    public partial class goods_reports : Form
    {
        public goods_reports()
        {
            InitializeComponent();
        }

        private void goods_reports_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'Procedures.goodsFullInfo' table. You can move, or remove it, as needed.
            this.goodsFullInfoTableAdapter.Fill(this.Procedures.goodsFullInfo);
            this.viewer.Reset();
            this.viewer.RefreshReport();
        }

        private void allGoodsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.goodsFullInfoTableAdapter.Fill(this.Procedures.goodsFullInfo);
            this.viewer.Reset();
            ReportDataSource rds = new ReportDataSource("goodsFullInfo");
            rds.Value = this.goodsFullInfoBindingSource;
            viewer.LocalReport.DataSources.Add(rds);
            viewer.LocalReport.ReportPath = @"C:\Users\acer\Desktop\Studing\C#\Department\Department\goodsFullInfo.rdlc";
            viewer.RefreshReport();
        }
    }
}

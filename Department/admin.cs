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
    public partial class admin : Form
    {
        public admin(string status, string login)
        {
            InitializeComponent();
            if (status != "1")
            {
                var tablesAndReports = status.Split('|');
                string tablesString = tablesAndReports[0].Substring(3);
                string reportsString = tablesAndReports[1].Substring(3);
                var tables = tablesString.Split(new char[] { ':' }, StringSplitOptions.RemoveEmptyEntries);
                var reports = reportsString.Split(new char[] { ':' }, StringSplitOptions.RemoveEmptyEntries);
                if (tablesString == "")
                {
                    tables_menu.Visible = false;
                }
                if (reportsString == "")
                {

                    reports_menu.Visible = false;
                }

                foreach (ToolStripMenuItem item in tables_menu.DropDownItems)
                {
                    item.Visible = false;
                }

                foreach (ToolStripMenuItem item in reports_menu.DropDownItems)
                {
                    item.Visible = false;
                }
                accountManage_menu.Visible = false;

                foreach (var table in tables)
                {
                    foreach (ToolStripMenuItem item in tables_menu.DropDownItems)
                    {
                        if (table == item.Text)
                        {
                            item.Visible = true;
                        }
                    }
                }

                foreach (var report in reports)
                {
                    foreach (ToolStripMenuItem item in reports_menu.DropDownItems)
                    {
                        if (report == item.Text)
                        {
                            item.Visible = true;
                        }
                    }
                }

                this.Text = login;
                hello_label.Text += login;
            }
            else if(status == "1")
            {
                hello_label.Text += "oniichan";
            }
        }

        private void admin_Load(object sender, EventArgs e)
        {

        }

        private void person_table_Click(object sender, EventArgs e)
        {
            person_form pf = new person_form();
            pf.Show();
        }

        private void position_table_Click(object sender, EventArgs e)
        {
            position_form pf = new position_form();
            pf.Show();
        }

        private void benefits_table_Click(object sender, EventArgs e)
        {
            benefits_form bf = new benefits_form();
            bf.Show();
        }

        private void cech_table_Click(object sender, EventArgs e)
        {
            cech_form cf = new cech_form();
            cf.Show();
        }

        private void supplier_table_Click(object sender, EventArgs e)
        {
            supplier_form sf = new supplier_form();
            sf.Show();
        }

        private void goods_table_Click(object sender, EventArgs e)
        {
            goods_form gf = new goods_form();
            gf.Show();
        }

        private void storage_table_Click(object sender, EventArgs e)
        {
            storage_form sf = new storage_form();
            sf.Show();
        }

        private void workers_table_Click(object sender, EventArgs e)
        {
            workers_form wf = new workers_form();
            wf.Show();
        }

        private void personBenefits_table_Click(object sender, EventArgs e)
        {
            person_benefits_form pbf = new person_benefits_form();
            pbf.Show();
        }

        private void delivery_table_Click(object sender, EventArgs e)
        {
            delivery_form df = new delivery_form();
            df.Show();
        }

        private void workersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            workers_reports wr = new workers_reports();
            wr.Show();
        }

        private void peopleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            person_reports pr = new person_reports();
            pr.Show();
        }

        private void benefitsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            benefits_reports br = new benefits_reports();
            br.Show();
        }

        private void cechToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cech_reports cr = new cech_reports();
            cr.Show();
        }

        private void positionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            position_reports pr = new position_reports();
            pr.Show();
        }

        private void deliveryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            delivery_reports dr = new delivery_reports();
            dr.Show();
        }

        private void goodsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            goods_reports gr = new goods_reports();
            gr.Show();
        }

        private void storageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            storage_reports sr = new storage_reports();
            sr.Show();
        }

        private void supplierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            supplier_reports sr = new supplier_reports();
            sr.Show();
        }

        private void personBenefitsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            person_benefits_reports pbr = new person_benefits_reports();
            pbr.Show();
        }

        private void accountManage_menu_Click(object sender, EventArgs e)
        {
            account_management ac = new account_management();
            ac.ShowDialog();
        }
    }
}

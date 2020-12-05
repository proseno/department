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
        public admin()
        {
            InitializeComponent();
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
    }
}

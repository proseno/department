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
    public partial class select_cech_form : Form
    {
        private int id = new int();

        public select_cech_form(int id)
        {
            InitializeComponent();
            this.id = id;
        }

        public select_cech_form()
        {
            InitializeComponent();
        }

        private void select_cech_form_Load(object sender, EventArgs e)
        {
            getData();
            foreach (DataGridViewRow row in cechData.Rows)
            {
                if (Convert.ToInt32(row.Cells[0].Value) == id)
                {
                    cechData.Rows[row.Index].Selected = true;
                }
            }
        }

        private void getData()
        {
            cechData.Rows.Clear();
            using (DepartmentEntities db = new DepartmentEntities())
            {
                var data = from cech in db.cech
                           select new
                           {
                               cech.cechNUM,
                               cech.cechNAME
                           };

                int i = 0;
                foreach (var item in data)
                {
                    cechData.Rows.Add();
                    cechData.Rows[i].Cells[0].Value = item.cechNUM;
                    cechData.Rows[i].Cells[1].Value = item.cechNAME;
                    i++;
                }
            }
        }

        private void cancel_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ok_button_Click(object sender, EventArgs e)
        {
            if (cechData.SelectedRows.Count == 1)
            {

                cech temp = new cech()
                {
                    cechNUM = Convert.ToInt32(cechData.SelectedRows[0].Cells[0].Value),
                    cechNAME = Convert.ToString(cechData.SelectedRows[0].Cells[1].Value)
                };
                temp_info.select_cech_workers = temp;
                this.Close();
            }
            else
            {
                MessageBox.Show("Please select 1 item");
            }
        }
    }
}

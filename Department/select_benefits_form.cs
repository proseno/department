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
    public partial class select_benefits_form : Form
    {
        private int id = new int();

        public select_benefits_form()
        {
            InitializeComponent();
        }

        public select_benefits_form(int id)
        {
            InitializeComponent();
            this.id = id;
        }

        private void select_benefits_form_Load(object sender, EventArgs e)
        {
            getData();
            foreach (DataGridViewRow row in benefitsData.Rows)
            {
                if (Convert.ToInt32(row.Cells[0].Value) == id)
                {
                    benefitsData.Rows[row.Index].Selected = true;
                }
            }
        }

        private void getData()
        {
            benefitsData.DataSource = null;
            using(DepartmentEntities db = new DepartmentEntities())
            {
                var data = from benefits in db.benefits
                           select new
                           {
                               benefits.benefitsNUM,
                               benefits.benefitsNAME,
                               benefits.benefitsDESCRIPTION,
                               benefits.benefitsKIND
                           };
                benefitsData.DataSource = data.ToList();
                benefitsData.Columns[0].HeaderText = "Id";
                benefitsData.Columns[1].HeaderText = "Name";
                benefitsData.Columns[2].HeaderText = "Description";
                benefitsData.Columns[3].HeaderText = "Kind";
            }
        }

        private void ok_button_Click(object sender, EventArgs e)
        {
            if(benefitsData.SelectedRows.Count == 1)
            {
                temp_info.select_benefits = new benefits()
                {
                    benefitsNUM = Convert.ToInt32(benefitsData.SelectedRows[0].Cells[0].Value),
                    benefitsNAME = Convert.ToString(benefitsData.SelectedRows[0].Cells[1].Value),
                    benefitsDESCRIPTION = Convert.ToString(benefitsData.SelectedRows[0].Cells[2].Value),
                    benefitsKIND = Convert.ToString(benefitsData.SelectedRows[0].Cells[3].Value)
                };
                this.Close();
            }
            else
            {
                MessageBox.Show("Please, select 1 item");
            }
        }

        private void cancel_button_Click(object sender, EventArgs e)
        {
            //temp_info.select_benefits = null;
            this.Close();
        }
    }
}

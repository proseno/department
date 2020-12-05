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
    public partial class select_worker_form : Form
    {
        private int id = new int();

        public select_worker_form()
        {
            InitializeComponent();
        }

        public select_worker_form(int id)
        {
            InitializeComponent();
            this.id = id;
        }

        private void select_worker_form_Load(object sender, EventArgs e)
        {
            getData();
            foreach (DataGridViewRow row in workersData.Rows)
            {
                if (Convert.ToInt32(row.Cells[0].Value) == id)
                {
                    workersData.Rows[row.Index].Selected = true;
                }
            }
        }

        private void getData()
        {
            workersData.Rows.Clear();
            using (DepartmentEntities db = new DepartmentEntities())
            {
                var data = from workers in db.workers
                           join person in db.person on workers.personNUM equals person.personNUM
                           join position in db.position on workers.positionNUM equals position.positionNUM
                           join cech in db.cech on workers.cechNUM equals cech.cechNUM
                           select new
                           {
                               workers.workersNUM,
                               person.personNAME,
                               position.positionNAME,
                               cech.cechNAME,
                               workers.workersSTART,
                               workers.workersEND
                           };
                int i = 0;
                foreach (var item in data)
                {
                    workersData.Rows.Add();
                    workersData.Rows[i].Cells[0].Value = item.workersNUM;
                    workersData.Rows[i].Cells[1].Value = item.personNAME;
                    workersData.Rows[i].Cells[2].Value = item.positionNAME;
                    workersData.Rows[i].Cells[3].Value = item.cechNAME;
                    workersData.Rows[i].Cells[4].Value = item.workersSTART.Date.ToShortDateString();
                    if (item.workersEND == null)
                        workersData.Rows[i].Cells[5].Value = "till now";
                    else
                        workersData.Rows[i].Cells[5].Value = Convert.ToDateTime(item.workersEND).Date.ToShortDateString();
                    i++;
                }
            }
        }

        private void fullinfo_button_Click(object sender, EventArgs e)
        {
            if (workersData.SelectedRows.Count == 1)
            {
                fullData_workers df = new fullData_workers(Convert.ToInt32(workersData.SelectedRows[0].Cells[0].Value));
                df.ShowDialog();
            }
            else
            {
                MessageBox.Show("Please, select 1 item");
            }
        }

        private void cancel_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ok_button_Click(object sender, EventArgs e)
        {
            if (workersData.SelectedRows.Count == 1)
            {
                using (DepartmentEntities db = new DepartmentEntities()) 
                {
                    int index = Convert.ToInt32(workersData.SelectedRows[0].Cells[0].Value);
                    workers temp = db.workers.FirstOrDefault(i => i.workersNUM == index);
                    temp_info.select_workers = temp;
                }                
                this.Close();
            }
            else
            {
                MessageBox.Show("Please select 1 item");
            }
        }
    }
}

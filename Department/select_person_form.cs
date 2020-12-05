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
    public partial class select_person_form : Form
    {
        private int id = new int();
        string status;

        public select_person_form(string status)
        {
            InitializeComponent();
            this.status = status;
        }

        public select_person_form(int id, string status)
        {
            InitializeComponent();
            this.id = id;
            this.status = status;
        }

        private void select_person_form_Load(object sender, EventArgs e)
        {
            getData();
            foreach (DataGridViewRow row in personData.Rows)
            {
                if (Convert.ToInt32(row.Cells[0].Value) == id)
                {
                    personData.Rows[row.Index].Selected = true;
                }
            }
        }

        private void getData()
        {
            personData.Rows.Clear();
            using (DepartmentEntities db = new DepartmentEntities())
            {
                var data = from person in db.person
                           select new
                           {
                               person.personNUM,
                               person.personNAME,
                               person.personPASPORT,
                               person.personIDCode,
                               person.personAddress,
                               person.personBirth
                           };
                int i = 0;
                foreach (var item in data)
                {
                    personData.Rows.Add();
                    personData.Rows[i].Cells[0].Value = item.personNUM;
                    personData.Rows[i].Cells[1].Value = item.personNAME;
                    personData.Rows[i].Cells[2].Value = item.personPASPORT;
                    personData.Rows[i].Cells[3].Value = item.personIDCode;
                    personData.Rows[i].Cells[4].Value = item.personAddress;
                    personData.Rows[i].Cells[5].Value = item.personBirth.Date.ToShortDateString();
                    i++;
                }
            }
        }

        private void ok_button_Click(object sender, EventArgs e)
        {
            if(personData.SelectedRows.Count == 1)
            {

                person temp = new person()
                {
                    personNUM = Convert.ToInt32(personData.SelectedRows[0].Cells[0].Value),
                    personNAME = Convert.ToString(personData.SelectedRows[0].Cells[1].Value),
                    personPASPORT = Convert.ToString(personData.SelectedRows[0].Cells[2].Value),
                    personIDCode = Convert.ToString(personData.SelectedRows[0].Cells[3].Value),
                    personAddress = Convert.ToString(personData.SelectedRows[0].Cells[4].Value),
                    personBirth = Convert.ToDateTime(personData.SelectedRows[0].Cells[5].Value)
                };
                if (status == "person_benefits")
                    temp_info.select_person = temp;
                else if (status == "workers")
                    temp_info.select_person_workers = temp;
                this.Close();
            }
            else
            {
                MessageBox.Show("Please select 1 item");
            }
        }

        private void cancel_button_Click(object sender, EventArgs e)
        {
            //temp_info.select_person = null;
            this.Close();
        }
    }
}

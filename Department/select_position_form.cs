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
    public partial class select_position_form : Form
    {
        private int id = new int();

        public select_position_form()
        {
            InitializeComponent();
        }

        public select_position_form(int id)
        {
            InitializeComponent();
            this.id = id;
        }

        private void select_position_form_Load(object sender, EventArgs e)
        {
            getData();
            foreach (DataGridViewRow row in positionData.Rows)
            {
                if (Convert.ToInt32(row.Cells[0].Value) == id)
                {
                    positionData.Rows[row.Index].Selected = true;
                }
            }
        }

        private void getData()
        {
            positionData.Rows.Clear();
            using (DepartmentEntities db = new DepartmentEntities())
            {
                var data = from position in db.position
                           select new
                           {
                               position.positionNUM,
                               position.positionNAME,
                               position.positionSALARY
                           };

                int i = 0;
                foreach (var item in data)
                {
                    positionData.Rows.Add();
                    positionData.Rows[i].Cells[0].Value = item.positionNUM;
                    positionData.Rows[i].Cells[1].Value = item.positionNAME;
                    positionData.Rows[i].Cells[2].Value = item.positionSALARY;
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
            if (positionData.SelectedRows.Count == 1)
            {

                position temp = new position()
                {
                    positionNUM = Convert.ToInt32(positionData.SelectedRows[0].Cells[0].Value),
                    positionNAME = Convert.ToString(positionData.SelectedRows[0].Cells[1].Value),
                    positionSALARY = Convert.ToDecimal(positionData.SelectedRows[0].Cells[2].Value)
                };
                temp_info.select_position_workers = temp;
                this.Close();
            }
            else
            {
                MessageBox.Show("Please select 1 item");
            }
        }
    }
}

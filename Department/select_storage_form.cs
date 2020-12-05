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
    public partial class select_storage_form : Form
    {
        private int id = new int();

        public select_storage_form()
        {
            InitializeComponent();
        }

        public select_storage_form(int id)
        {
            InitializeComponent();
            this.id = id;
        }

        private void select_storage_form_Load(object sender, EventArgs e)
        {
            getData();
            foreach (DataGridViewRow row in storageData.Rows)
            {
                if (Convert.ToInt32(row.Cells[0].Value) == id)
                {
                    storageData.Rows[row.Index].Selected = true;
                }
            }
        }

        private void getData()
        {
            storageData.Rows.Clear();
            using (DepartmentEntities db = new DepartmentEntities())
            {
                var data = from storage in db.storage
                           select new
                           {
                               storage.storageNUM,
                               storage.storageNAME,
                               storage.storageADDRESS
                           };
                int i = 0;
                foreach (var item in data)
                {
                    storageData.Rows.Add();
                    storageData.Rows[i].Cells[0].Value = item.storageNUM;
                    storageData.Rows[i].Cells[1].Value = item.storageNAME;
                    storageData.Rows[i].Cells[2].Value = item.storageADDRESS;
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
            if (storageData.SelectedRows.Count == 1)
            {
                using (DepartmentEntities db = new DepartmentEntities())
                {
                    int index = Convert.ToInt32(storageData.SelectedRows[0].Cells[0].Value);
                    storage temp = db.storage.FirstOrDefault(i => i.storageNUM == index);
                    temp_info.select_storage = temp;
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

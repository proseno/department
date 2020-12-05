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
    public partial class select_supplier_form : Form
    {
        private int id = new int();

        public select_supplier_form()
        {
            InitializeComponent();
        }

        public select_supplier_form(int id)
        {
            InitializeComponent();
            this.id = id;
        }

        private void select_supplier_form_Load(object sender, EventArgs e)
        {
            getData();
            foreach (DataGridViewRow row in supplierData.Rows)
            {
                if (Convert.ToInt32(row.Cells[0].Value) == id)
                {
                    supplierData.Rows[row.Index].Selected = true;
                }
            }
        }

        private void getData()
        {
            supplierData.Rows.Clear();
            using (DepartmentEntities db = new DepartmentEntities())
            {
                var data = from supplier in db.supplier
                           select new
                           {
                               supplier.supplierNUM,
                               supplier.supplierNAME,
                               supplier.supplierADDRESS,
                               supplier.supplierContacts
                           };
                int i = 0;
                foreach (var item in data)
                {
                    supplierData.Rows.Add();
                    supplierData.Rows[i].Cells[0].Value = item.supplierNUM;
                    supplierData.Rows[i].Cells[1].Value = item.supplierNAME;
                    supplierData.Rows[i].Cells[2].Value = item.supplierADDRESS;
                    supplierData.Rows[i].Cells[3].Value = item.supplierContacts;
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
            if (supplierData.SelectedRows.Count == 1)
            {
                using (DepartmentEntities db = new DepartmentEntities())
                {
                    int index = Convert.ToInt32(supplierData.SelectedRows[0].Cells[0].Value);
                    supplier temp = db.supplier.FirstOrDefault(i => i.supplierNUM == index);
                    temp_info.select_supplier = temp;
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

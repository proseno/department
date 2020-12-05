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
    public partial class supplier_search : Form
    {
        private int id;

        public supplier_search()
        {
            InitializeComponent();
            this.id = 0;
        }

        public supplier_search(int id)
        {
            InitializeComponent();
            this.id = id;
        }

        private void cancel_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void clear_all_fields()
        {
            id_textBox.Text = "";
            name_textBox.Text = "";
            address_textBox.Text = "";
            contacts_textBox.Text = "";
        }

        private void clear_button_Click(object sender, EventArgs e)
        {
            clear_all_fields();
        }

        private bool is_field_full()
        {
            if (id_textBox.Text != "")
                return true;
            if (name_textBox.Text != "")
                return true;
            if (address_textBox.Text != "")
                return true;
            if (contacts_textBox.Text != "")
                return true;
            return false;
        }

        private void search_button_Click(object sender, EventArgs e)
        {
            supplierData.Rows.Clear();
            if (is_field_full())
            {
                if(id_textBox.Text != "")
                {
                    try
                    {
                        Convert.ToInt32(id_textBox.Text);
                    }
                    catch 
                    {
                        MessageBox.Show("Id field has incorect data");
                        return;
                    }
                }

                using (DepartmentEntities db = new DepartmentEntities())
                {
                    List<supplier> data = null;
                    if(id_textBox.Text != "")
                    {
                        int id = Convert.ToInt32(id_textBox.Text);
                        if(data != null)
                        {
                            data = data.Where(i => i.supplierNUM == id).ToList();
                        }
                        else
                        {
                            data = db.supplier.Where(i => i.supplierNUM == id).ToList();
                        }
                    }
                    if(name_textBox.Text != "")
                    {
                        if(data != null)
                        {
                            data = data.Where(i => i.supplierNAME.StartsWith(name_textBox.Text)).ToList();
                        }
                        else
                        {
                            data = db.supplier.Where(i => i.supplierNAME.StartsWith(name_textBox.Text)).ToList();
                        }
                    }
                    if(address_textBox.Text != "")
                    {
                        if(data != null)
                        {
                            data = data.Where(i => i.supplierADDRESS.StartsWith(address_textBox.Text)).ToList();
                        }
                        else
                        {
                            data = db.supplier.Where(i => i.supplierADDRESS.StartsWith(address_textBox.Text)).ToList();
                        }
                    }
                    if(contacts_textBox.Text != "")
                    {
                        if(data != null)
                        {
                            data = data.Where(i => i.supplierContacts.StartsWith(contacts_textBox.Text)).ToList();
                        }
                        else
                        {
                            data = db.supplier.Where(i => i.supplierContacts.StartsWith(contacts_textBox.Text)).ToList();
                        }
                    }

                    if (data != null || data.Count != 0)
                    {
                        int j = 0;
                        foreach (var item in data)
                        {
                            supplierData.Rows.Add();
                            supplierData.Rows[j].Cells[0].Value = item.supplierNUM;
                            supplierData.Rows[j].Cells[1].Value = item.supplierNAME;
                            supplierData.Rows[j].Cells[2].Value = item.supplierADDRESS;
                            supplierData.Rows[j].Cells[3].Value = item.supplierContacts;
                            j++;
                        }
                    }
                    else
                    {
                        MessageBox.Show("There are no such records");
                    }
                }
            }
            else
            {
                MessageBox.Show("Fill at least one field");
            }
        }

        private void ok_button_Click(object sender, EventArgs e)
        {
            if (supplierData.SelectedRows.Count == 1)
            {
                if (id == 0)
                {
                    temp_info.supplier_search = new supplier()
                    {
                        supplierNUM = Convert.ToInt32(supplierData.SelectedRows[0].Cells[0].Value),
                        supplierNAME = Convert.ToString(supplierData.SelectedRows[0].Cells[1].Value),
                        supplierADDRESS = Convert.ToString(supplierData.SelectedRows[0].Cells[2].Value),
                        supplierContacts = Convert.ToString(supplierData.SelectedRows[0].Cells[3].Value)
                    };
                }
                else if(id == 1)
                {
                    temp_info.delivery_supplierNUM = Convert.ToInt32(supplierData.SelectedRows[0].Cells[0].Value);
                }
                this.Close();
            }
            else
            {
                MessageBox.Show("Select one item");
            }
        }
    }
}

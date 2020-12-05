using Microsoft.EntityFrameworkCore.Query.Internal;
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
    public partial class storage_search : Form
    {
        private int id;

        public storage_search()
        {
            InitializeComponent();
            this.id = 0;
        }

        public storage_search(int id)
        {
            InitializeComponent();
            this.id = id;
        }

        private void cancel_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void clear_button_Click(object sender, EventArgs e)
        {
            clear_all_fields();
        }

        private void clear_all_fields()
        {
            id_textBox.Text = "";
            name_textBox.Text = "";
            address_textBox.Text = "";
        }

        private void search_button_Click(object sender, EventArgs e)
        {
            storageData.Rows.Clear();
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
                    List<storage> data = null;
                    if(id_textBox.Text != "")
                    {
                        int id = Convert.ToInt32(id_textBox.Text);
                        if(data != null)
                        {
                            data = data.Where(i => i.storageNUM == id).ToList();
                        }
                        else
                        {
                            data = db.storage.Where(i => i.storageNUM == id).ToList();
                        }
                    }
                    if(name_textBox.Text != "")
                    {
                        if(data != null)
                        {
                            data = data.Where(i => i.storageNAME.StartsWith(name_textBox.Text)).ToList();
                        }
                        else
                        {
                            data = db.storage.Where(i => i.storageNAME.StartsWith(name_textBox.Text)).ToList();
                        }
                    }

                    if(address_textBox.Text != "")
                    {
                        if(data != null)
                        {
                            data = data.Where(i => i.storageADDRESS.StartsWith(address_textBox.Text)).ToList();
                        }
                        else
                        {
                            data = db.storage.Where(i => i.storageADDRESS.StartsWith(address_textBox.Text)).ToList();
                        }
                    }

                    if (data != null || data.Count != 0)
                    {
                        int j = 0;
                        foreach (var item in data)
                        {
                            storageData.Rows.Add();
                            storageData.Rows[j].Cells[0].Value = item.storageNUM;
                            storageData.Rows[j].Cells[1].Value = item.storageNAME;
                            storageData.Rows[j].Cells[2].Value = item.storageADDRESS;
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

        private bool is_field_full()
        {
            if (id_textBox.Text != "")
                return true;
            if (name_textBox.Text != "")
                return true;
            if (address_textBox.Text != "")
                return true;
            return false;
        }

        private void ok_button_Click(object sender, EventArgs e)
        {
            if (storageData.SelectedRows.Count == 1)
            {
                if (id == 0)
                {
                    temp_info.storage_search = new storage()
                    {
                        storageNUM = Convert.ToInt32(storageData.SelectedRows[0].Cells[0].Value),
                        storageNAME = Convert.ToString(storageData.SelectedRows[0].Cells[1].Value),
                        storageADDRESS = Convert.ToString(storageData.SelectedRows[0].Cells[2].Value)
                    };
                }
                else if(id == 1)
                {
                    temp_info.delivery_storageNUM = Convert.ToInt32(storageData.SelectedRows[0].Cells[0].Value);
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

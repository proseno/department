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
    public partial class cech_search : Form
    {
        private int id;
        public cech_search()
        {
            InitializeComponent();
            this.id = 0;
        }

        public cech_search(int id)
        {
            InitializeComponent();
            this.id = id;
        }

        private void clear_button_Click(object sender, EventArgs e)
        {
            clear_all_fields();
        }

        private void clear_all_fields()
        {
            id_textBox.Text = "";
            name_textBox.Text = "";
        }

        private void cancel_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void search_button_Click(object sender, EventArgs e)
        {
            cechData.Rows.Clear();
            if (is_full_field())
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
                    List<cech> data = null;
                    if(id_textBox.Text != "")
                    {
                        int id = Convert.ToInt32(id_textBox.Text);
                        if(data != null)
                        {
                            data = data.Where(i => i.cechNUM == id).ToList();
                        }
                        else
                        {
                            data = db.cech.Where(i => i.cechNUM == id).ToList();
                        }
                    }
                    if(name_textBox.Text != "")
                    {
                        if(data != null)
                        {
                            data = data.Where(i => i.cechNAME.StartsWith(name_textBox.Text)).ToList();
                        }
                        else
                        {
                            data = db.cech.Where(i => i.cechNAME.StartsWith(name_textBox.Text)).ToList();
                        }
                    }

                    if (data != null || data.Count != 0)
                    {
                        int j = 0;
                        foreach (var item in data)
                        {
                            cechData.Rows.Add();
                            cechData.Rows[j].Cells[0].Value = item.cechNUM;
                            cechData.Rows[j].Cells[1].Value = item.cechNAME;
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

        private bool is_full_field()
        {
            if (id_textBox.Text != "")
                return true;
            if (name_textBox.Text != "")
                return true;
            return false;
        }

        private void ok_button_Click(object sender, EventArgs e)
        {
            if (cechData.SelectedRows.Count == 1)
            {
                if (id == 0)
                {
                    temp_info.cech_search = new cech()
                    {
                        cechNUM = Convert.ToInt32(cechData.SelectedRows[0].Cells[0].Value),
                        cechNAME = Convert.ToString(cechData.SelectedRows[0].Cells[1].Value)
                    };
                }
                else if(id == 1)
                {
                    temp_info.workers_cechNUM = Convert.ToInt32(cechData.SelectedRows[0].Cells[0].Value);
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

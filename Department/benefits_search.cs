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
    public partial class benefits_search : Form
    {
        private int id;

        public benefits_search()
        {
            InitializeComponent();
            this.id = 0;
        }

        public benefits_search(int id)
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
            description_textBox.Text = "";
            kind_textBox.Text = "";
        }

        private void cancel_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void search_button_Click(object sender, EventArgs e)
        {
            benefitsData.Rows.Clear();
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
                    List<benefits> data = null;
                    if(id_textBox.Text != "")
                    {
                        int id = Convert.ToInt32(id_textBox.Text);
                        if(data != null)
                        {
                            data = data.Where(i => i.benefitsNUM == id).ToList();
                        }
                        else
                        {
                            data = db.benefits.Where(i => i.benefitsNUM == id).ToList();
                        }
                    }

                    if (name_textBox.Text != "")
                    {
                        if(data != null)
                        {
                            data = data.Where(i => i.benefitsNAME.StartsWith(name_textBox.Text)).ToList();
                        }
                        else
                        {
                            data = db.benefits.Where(i => i.benefitsNAME.StartsWith(name_textBox.Text)).ToList();
                        }
                    }

                    if(description_textBox.Text != "")
                    {
                        if(data != null)
                        {
                            data = data.Where(i => i.benefitsDESCRIPTION.StartsWith(description_textBox.Text)).ToList();
                        }
                        else
                        {
                            data = db.benefits.Where(i => i.benefitsDESCRIPTION.StartsWith(description_textBox.Text)).ToList();
                        }
                    }

                    if(kind_textBox.Text != "")
                    {
                        if(data != null)
                        {
                            data = data.Where(i => i.benefitsKIND.StartsWith(kind_textBox.Text)).ToList();
                        }
                        else
                        {
                            data = db.benefits.Where(i => i.benefitsKIND.StartsWith(kind_textBox.Text)).ToList();
                        }
                    }

                    if (data != null && data.Count != 0)
                    {
                        int j = 0;
                        foreach (var item in data)
                        {
                            benefitsData.Rows.Add();
                            benefitsData.Rows[j].Cells[0].Value = item.benefitsNUM;
                            benefitsData.Rows[j].Cells[1].Value = item.benefitsNAME;
                            benefitsData.Rows[j].Cells[2].Value = item.benefitsDESCRIPTION;
                            benefitsData.Rows[j].Cells[3].Value = item.benefitsKIND;
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
            if (description_textBox.Text != "")
                return true;
            if (kind_textBox.Text != "")
                return true;
            return false;
        }

        private void ok_button_Click(object sender, EventArgs e)
        {
            if (benefitsData.SelectedRows.Count == 1)
            {
                if(id == 0)
                {
                    temp_info.benefits_search = new benefits()
                    {
                        benefitsNUM = Convert.ToInt32(benefitsData.SelectedRows[0].Cells[0].Value),
                        benefitsNAME = Convert.ToString(benefitsData.SelectedRows[0].Cells[1].Value),
                        benefitsDESCRIPTION = Convert.ToString(benefitsData.SelectedRows[0].Cells[2].Value),
                        benefitsKIND = Convert.ToString(benefitsData.SelectedRows[0].Cells[3].Value)
                    };
                }
                else if (id == 1)
                {
                    temp_info.person_benefits_NUM.benefitsNUM = Convert.ToInt32(benefitsData.SelectedRows[0].Cells[0].Value);
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

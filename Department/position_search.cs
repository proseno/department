using Microsoft.EntityFrameworkCore.Query.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Department
{
    public partial class position_search : Form
    {
        private int id;

        public position_search()
        {
            InitializeComponent();
            this.id = 0;
        }

        public position_search(int id)
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
            salary_textBox.Text = "";
        }

        private void cancel_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool is_full_field()
        {
            if (id_textBox.Text != "")
                return true;
            if (name_textBox.Text != "")
                return true;
            if (salary_textBox.Text != "")
                return true;
            return false;
        }

        private void search_button_Click(object sender, EventArgs e)
        {
            positionData.Rows.Clear();

            if (is_full_field())
            {
                int id;
                decimal salary;
                if (id_textBox.Text != "")
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

                if (salary_textBox.Text != "")
                {
                    try
                    {
                        Convert.ToDecimal(salary_textBox.Text);
                    }
                    catch
                    {
                        MessageBox.Show("Salary field has incorect data");
                        return;
                    }
                }

                using (DepartmentEntities db = new DepartmentEntities())
                {
                    List<position> data = null;
                    if(id_textBox.Text != "")
                    {
                        id = Convert.ToInt32(id_textBox.Text);
                        if (data != null)
                        {
                            data = data.Where(i => i.positionNUM == id).ToList();
                        }
                        else
                        {
                            data = db.position.Where(i => i.positionNUM == id).ToList();
                        }
                    }
                    if(name_textBox.Text != "")
                    {
                        if(data != null)
                        {
                            data = data.Where(i => i.positionNAME.StartsWith(name_textBox.Text)).ToList();
                        }
                        else
                        {
                            data = db.position.Where(i => i.positionNAME.StartsWith(name_textBox.Text)).ToList();
                        }
                    }
                    if(salary_textBox.Text != "")
                    {
                        salary = Convert.ToDecimal(salary_textBox.Text);
                        if (data != null)
                        {
                            data = data.Where(i => i.positionSALARY.Equals(salary)).ToList();
                        }
                        else
                        {
                            data = db.position.Where(i => i.positionSALARY.Equals(salary)).ToList();
                        }
                    }

                    if(data != null || data.Count != 0)
                    {
                        int j = 0;
                        foreach (var item in data)
                        {
                            positionData.Rows.Add();
                            positionData.Rows[j].Cells[0].Value = item.positionNUM;
                            positionData.Rows[j].Cells[1].Value = item.positionNAME;
                            positionData.Rows[j].Cells[2].Value = item.positionSALARY;
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
            if(positionData.SelectedRows.Count == 1)
            {
                if (id == 0)
                {
                    temp_info.position_search = new position()
                    {
                        positionNUM = Convert.ToInt32(positionData.SelectedRows[0].Cells[0].Value),
                        positionNAME = Convert.ToString(positionData.SelectedRows[0].Cells[1].Value),
                        positionSALARY = Convert.ToDecimal(positionData.SelectedRows[0].Cells[2].Value)
                    };
                }else if(id == 1)
                {
                    temp_info.workers_positionNUM = Convert.ToInt32(positionData.SelectedRows[0].Cells[0].Value);
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

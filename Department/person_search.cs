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
    public partial class person_search : Form
    {
        //if id == 0 equals to person(default)
        //if id == 1 equals to person_benefits
        private int id;

        public person_search()
        {
            InitializeComponent();
            this.id = 0;
        }

        public person_search(int id)
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
            id_textBox.Text = "";
            name_textBox.Text = "";
            pasport_textBox.Text = "";
            idcode_textBox.Text = "";
            address_textBox.Text = "";
            birth_date.Value = DateTime.Now;
            on_off_button.Text = "off";
        }

        private bool is_full_field()
        {
            if (id_textBox.Text != "")
                return true;
            if (name_textBox.Text != "")
                return true;
            if (pasport_textBox.Text != "")
                return true;
            if (idcode_textBox.Text != "")
                return true;
            if (address_textBox.Text != "")
                return true;
            if (on_off_button.Text == "on")
                return true;
            return false;
        }

        private void search_button_Click(object sender, EventArgs e)
        {
            personData.Rows.Clear();
            int id;
            if (is_full_field())
            {
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
                using (DepartmentEntities db = new DepartmentEntities())
                {
                   
                    List<person> data = null;
                    if(id_textBox.Text != "")
                    {
                        id = Convert.ToInt32(id_textBox.Text);
                        if (data != null)
                        {
                            data = data.Where(i => i.personNUM == id).ToList();
                        }
                        else
                        {
                            data = db.person.Where(i => i.personNUM == id).ToList();
                        }
                    }
                    if(name_textBox.Text != "")
                    {
                        if(data != null)
                        {
                            data = data.Where(i => i.personNAME.StartsWith(name_textBox.Text)).ToList();
                        }
                        else
                        {
                            data = db.person.Where(i => i.personNAME.StartsWith(name_textBox.Text)).ToList();
                        }
                    }
                    if (pasport_textBox.Text != "")
                    {
                        if (data != null)
                        {
                            data = data.Where(i => i.personPASPORT.StartsWith(pasport_textBox.Text)).ToList();
                        }
                        else
                        {
                            data = db.person.Where(i => i.personPASPORT.StartsWith(pasport_textBox.Text)).ToList();
                        }
                    }
                    if (idcode_textBox.Text != "")
                    {
                        if (data != null)
                        {
                            data = data.Where(i => i.personIDCode.StartsWith(idcode_textBox.Text)).ToList();
                        }
                        else
                        {
                            data = db.person.Where(i => i.personIDCode.StartsWith(idcode_textBox.Text)).ToList();
                        }
                    }
                    if (address_textBox.Text != "")
                    {
                        if (data != null)
                        {
                            data = data.Where(i => i.personAddress.StartsWith(address_textBox.Text)).ToList();
                        }
                        else
                        {
                            data = db.person.Where(i => i.personAddress.StartsWith(address_textBox.Text)).ToList();
                        }
                    }
                    if (on_off_button.Text == "on")
                    {
                        if (data != null)
                        {
                            data = data.Where(i => i.personBirth.Equals(birth_date.Value)).ToList();
                        }
                        else
                        {
                            data = db.person.Where(i => i.personBirth.Equals(birth_date.Value)).ToList();
                        }
                    }
                    if(data != null && data.Count != 0)
                    {
                        int j = 0;
                        foreach (var item in data)
                        {
                            personData.Rows.Add();
                            personData.Rows[j].Cells[0].Value = item.personNUM;
                            personData.Rows[j].Cells[1].Value = item.personNAME;
                            personData.Rows[j].Cells[2].Value = item.personPASPORT;
                            personData.Rows[j].Cells[3].Value = item.personIDCode;
                            personData.Rows[j].Cells[4].Value = item.personAddress;
                            personData.Rows[j].Cells[5].Value = item.personBirth.Date.ToShortDateString();
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
            if(personData.SelectedRows.Count == 1)
            {
                if(id == 0) {
                    temp_info.person_search = new person()
                    {
                        personNUM = Convert.ToInt32(personData.SelectedRows[0].Cells[0].Value),
                        personNAME = Convert.ToString(personData.SelectedRows[0].Cells[1].Value),
                        personPASPORT = Convert.ToString(personData.SelectedRows[0].Cells[2].Value),
                        personIDCode = Convert.ToString(personData.SelectedRows[0].Cells[3].Value),
                        personAddress = Convert.ToString(personData.SelectedRows[0].Cells[4].Value),
                        personBirth = Convert.ToDateTime(personData.SelectedRows[0].Cells[5].Value)
                    };
                }
                else if(id == 1)
                {
                    temp_info.person_benefits_NUM.personNUM = Convert.ToInt32(personData.SelectedRows[0].Cells[0].Value);
                }
                else if(id == 2)
                {
                    temp_info.workers_personNUM = Convert.ToInt32(personData.SelectedRows[0].Cells[0].Value);
                }
                
                this.Close();
            }
            else
            {
                MessageBox.Show("Select one item");
            }
        }

        private void on_off_button_Click(object sender, EventArgs e)
        {
            on_off_button.Text = on_off_button.Text == "on" ? "off" : "on";
        }
    }
}

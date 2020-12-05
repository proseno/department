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
    public partial class person_benefits_search : Form
    {
        public person_benefits_search()
        {
            InitializeComponent();
            temp_info.person_benefits_NUM = new person_benefits();
            temp_info.person_benefits_NUM.personNUM = null;
            temp_info.person_benefits_NUM.benefitsNUM = null;
        }

        private void fullInfo_button_Click(object sender, EventArgs e)
        {
            if (person_benefitsData.SelectedRows.Count == 1)
            {
                fullData_person_benefits_form pb = new fullData_person_benefits_form(Convert.ToInt32(person_benefitsData.SelectedRows[0].Cells[0].Value));
                pb.ShowDialog();
            }
            else
            {
                MessageBox.Show("Select one item");
            }
        }

        private void clear_button_Click(object sender, EventArgs e)
        {
            id_textBox.Text = "";
            start_date.Value = DateTime.Now.Date;
            end_date.Value = DateTime.Now.Date;

            start_on_off_button.Text = "off";
            end_on_off_button.Text = "off";


            temp_info.person_benefits_NUM.personNUM = null;
            temp_info.person_benefits_NUM.benefitsNUM = null;
            person_button.Text = "select";
            benefits_button.Text = "select";
        }

        private void person_button_Click(object sender, EventArgs e)
        {
            //temp_info.person_benefits_search.personNUM = null;
            person_search ps = new person_search(1);
            ps.ShowDialog();
            //if (temp_info.personNUM_person_benefits >= 0)
            //{
                
            //}
        }

        private void benefits_button_Click(object sender, EventArgs e)
        {
            benefits_search bs = new benefits_search(1);
            bs.ShowDialog();
        }

        private void cancel_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void person_button_Paint(object sender, PaintEventArgs e)
        {
            if (temp_info.person_benefits_NUM == null || temp_info.person_benefits_NUM.personNUM == null)
                person_button.Text = "select";
            else
                person_button.Text = "selected";
        }

        private void benefits_button_Paint(object sender, PaintEventArgs e)
        {
            if (temp_info.person_benefits_NUM == null || temp_info.person_benefits_NUM.benefitsNUM == null)
                benefits_button.Text = "select";
            else
                benefits_button.Text = "selected";
        }

        private void start_on_off_button_Click(object sender, EventArgs e)
        {
            start_on_off_button.Text = start_on_off_button.Text == "on" ? "off" : "on";
        }

        private void end_on_off_button_Click(object sender, EventArgs e)
        {
            end_on_off_button.Text = end_on_off_button.Text == "on" ? "off" : "on";
        }

        private void search_button_Click(object sender, EventArgs e)
        {
            person_benefitsData.Rows.Clear();
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

                    var data = (from person_benefits in db.person_benefits
                                join person in db.person on person_benefits.personNUM equals person.personNUM
                                join benefits in db.benefits on person_benefits.benefitsNUM equals benefits.benefitsNUM
                                select new
                                {
                                    person.personNUM,
                                    person.personNAME,

                                    benefits.benefitsNUM,
                                    benefits.benefitsNAME,

                                    person_benefits.person_benefitsNUM,
                                    person_benefits.person_benefitsSTART,
                                    person_benefits.person_benefitsEND
                                }
                                ).ToList();

                    if (id_textBox.Text != "")
                    {
                        int id = Convert.ToInt32(id_textBox.Text);
                        if(data != null)
                        {
                            data = data.Where(i => i.person_benefitsNUM == id).ToList();
                        }
                        //else
                        //{
                        //    data = db.person_benefits.Where(i => i.person_benefitsNUM == id).ToList();
                        //}
                    }
                    if(temp_info.person_benefits_NUM.personNUM != null)
                    {
                        if(data != null)
                        {
                            data = data.Where(i => i.personNUM == temp_info.person_benefits_NUM.personNUM).ToList();
                        }
                        //else
                        //{
                        //    data = db.person_benefits.Where(i => i.personNUM == temp_info.person_benefits_NUM.personNUM).ToList();
                        //}
                    }
                    if(temp_info.person_benefits_NUM.benefitsNUM != null)
                    {
                        if(data != null)
                        {
                            data = data.Where(i => i.benefitsNUM == temp_info.person_benefits_NUM.benefitsNUM).ToList();
                        }
                        //else
                        //{
                        //    data = db.person_benefits.Where(i => i.benefitsNUM == temp_info.person_benefits_NUM.benefitsNUM).ToList();
                        //}
                    }
                    if(start_on_off_button.Text == "on")
                    {
                        if(data != null)
                        {
                            data = data.Where(i => i.person_benefitsSTART.Date.Equals(start_date.Value.Date)).ToList();
                        }
                        //else
                        //{
                        //    data = db.person_benefits.Where(i => i.person_benefitsSTART.Date.Equals(start_date.Value.Date)).ToList();
                        //}
                    }
                    if(end_on_off_button.Text == "on")
                    {
                        if (data != null)
                        {
                            data = data.Where(i => Convert.ToDateTime(i.person_benefitsEND).Date.Equals(end_date.Value.Date)).ToList();
                        }
                        //else
                        //{
                        //    data = db.person_benefits.Where(i => Convert.ToDateTime(i.person_benefitsEND).Date.Equals(end_date.Value.Date)).ToList();
                        //}
                    }
                    //check the new type of searching from database into datagrid
                    if(data.Count() != 0)//???
                    {
                        int j = 0;
                        foreach (var item in data)
                        {
                            person_benefitsData.Rows.Add();
                            person_benefitsData.Rows[j].Cells[0].Value = item.person_benefitsNUM;
                            person_benefitsData.Rows[j].Cells[1].Value = item.personNAME;
                            person_benefitsData.Rows[j].Cells[2].Value = item.benefitsNAME;
                            person_benefitsData.Rows[j].Cells[3].Value = item.person_benefitsSTART.Date.ToShortDateString();
                            person_benefitsData.Rows[j].Cells[4].Value = Convert.ToDateTime(item.person_benefitsEND).Date.ToShortDateString();
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
            if (temp_info.person_benefits_NUM.personNUM != null)
                return true;
            if (temp_info.person_benefits_NUM.benefitsNUM != null)
                return true;
            if (end_on_off_button.Text == "on")
                return true;
            if (start_on_off_button.Text == "on")
                return true;
            return false;
        }

        private void ok_button_Click(object sender, EventArgs e)
        {
            if (person_benefitsData.SelectedRows.Count == 1)
            {
                if (person_benefitsData.SelectedRows[0].Cells[4].Value.ToString() != "till now")
                {
                    using (DepartmentEntities db = new DepartmentEntities()) {
                        string pers = Convert.ToString(person_benefitsData.SelectedRows[0].Cells[1].Value);
                        string bens = Convert.ToString(person_benefitsData.SelectedRows[0].Cells[2].Value);
                        temp_info.person_benefits_search = new person_benefits()
                        {
                            person_benefitsNUM = Convert.ToInt32(person_benefitsData.SelectedRows[0].Cells[0].Value),
                            person_benefitsSTART = Convert.ToDateTime(person_benefitsData.SelectedRows[0].Cells[3].Value),
                            person_benefitsEND = Convert.ToDateTime(person_benefitsData.SelectedRows[0].Cells[4].Value),
                            personNUM = db.person.FirstOrDefault(i => i.personNAME.Equals(pers)).personNUM,
                            benefitsNUM = db.benefits.FirstOrDefault(i => i.benefitsNAME.Equals(bens)).benefitsNUM
                        };
                    }
                }
                else
                {
                    using (DepartmentEntities db = new DepartmentEntities())
                    {
                        string pers = Convert.ToString(person_benefitsData.SelectedRows[0].Cells[1].Value);
                        string bens = Convert.ToString(person_benefitsData.SelectedRows[0].Cells[2].Value);
                        temp_info.person_benefits_search = new person_benefits()
                        {
                            person_benefitsNUM = Convert.ToInt32(person_benefitsData.SelectedRows[0].Cells[0].Value),
                            person_benefitsSTART = Convert.ToDateTime(person_benefitsData.SelectedRows[0].Cells[3].Value),
                            person_benefitsEND = null,
                            personNUM = db.person.FirstOrDefault(i => i.personNAME.Equals(pers)).personNUM,
                            benefitsNUM = db.benefits.FirstOrDefault(i => i.benefitsNAME.Equals(bens)).benefitsNUM
                        };
                    }
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

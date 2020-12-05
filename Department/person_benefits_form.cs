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
    public partial class person_benefits_form : Form
    {
        //    private person select_person = null;
        //    private benefits select_benefits = null;
        private bool tillnow = false;

        private enum Status
        {
            add = 1,
            edit = 2
        }

        private Status status = new Status();

        public person_benefits_form()
        {
            InitializeComponent();
        }

        private void person_benefits_form_Load(object sender, EventArgs e)
        {
            getData();
        }

        private void getData()
        {
            person_benefitsData.Rows.Clear();
            using (DepartmentEntities db = new DepartmentEntities())
            {
                var data = from person_benefits in db.person_benefits
                           join person in db.person on person_benefits.personNUM equals person.personNUM
                           join benefits in db.benefits on person_benefits.benefitsNUM equals benefits.benefitsNUM
                           select new
                           {
                               person_benefits.person_benefitsNUM,
                               person.personNAME,
                               benefits.benefitsNAME,
                               benefits.benefitsDESCRIPTION,
                               benefits.benefitsKIND,
                               person_benefits.person_benefitsSTART,
                               person_benefits.person_benefitsEND
                           };
                int i = 0;
                foreach (var item in data)
                {
                    person_benefitsData.Rows.Add();
                    person_benefitsData.Rows[i].Cells[0].Value = item.person_benefitsNUM;
                    person_benefitsData.Rows[i].Cells[1].Value = item.personNAME;
                    person_benefitsData.Rows[i].Cells[2].Value = item.benefitsNAME;
                    person_benefitsData.Rows[i].Cells[3].Value = item.benefitsDESCRIPTION;
                    person_benefitsData.Rows[i].Cells[4].Value = item.benefitsNAME;
                    person_benefitsData.Rows[i].Cells[5].Value = item.person_benefitsSTART.Date.ToShortDateString();
                    if (item.person_benefitsEND == null)
                        person_benefitsData.Rows[i].Cells[6].Value = "till now";
                    else
                        person_benefitsData.Rows[i].Cells[6].Value = ((DateTime)item.person_benefitsEND).Date.ToShortDateString();
                    i++;
                }
            }
        }

        private void full_button_Click(object sender, EventArgs e)
        {
            if (person_benefitsData.SelectedRows.Count != 1)
            {
                MessageBox.Show("Please select one item");
            }
            else
            {
                fullData_person_benefits_form fd = new fullData_person_benefits_form(Convert.ToInt32(person_benefitsData.SelectedRows[0].Cells[0].Value));
                fd.Show();
            }
        }

        private void clear_button_Click(object sender, EventArgs e)
        {
            clear_all_fields();
        }

        private void clear_all_fields()
        {
            person_button.Text = "select";
            benefits_button.Text = "select";
            start_date.Value = DateTime.Now;
            //end_date.Value = DateTime.Now;
            temp_info.select_person = null;
            temp_info.select_benefits = null;
            tillnow = false;
        }

        private void add_button_Click(object sender, EventArgs e)
        {
            clear_all_fields();
            control_groupBox.Visible = true;
            control_groupBox.Text = "add item";
            status = Status.add;
            tillnow_button.Visible = false;
            or_label.Visible = false;
            end_label.Visible = false;
            end_date.Visible = false;
        }

        private void person_button_Click(object sender, EventArgs e)
        {
            if (temp_info.select_person != null)
            {
                person_button.Text = "selected";
                select_person_form spf = new select_person_form(temp_info.select_person.personNUM, "person_benefits");
                spf.ShowDialog();
                
            }
            else if (temp_info.select_person == null)
            {
                person_button.Text = "select";
                select_person_form spf = new select_person_form("person_benefits");
                spf.ShowDialog();
                if(temp_info.select_person != null)
                {
                    person_button.Text = "selected";
                }
            }
        }

        private void benefits_button_Click(object sender, EventArgs e)
        {
            if (temp_info.select_benefits != null)
            {
                benefits_button.Text = "selected";
                select_benefits_form sbf = new select_benefits_form(temp_info.select_benefits.benefitsNUM);
                sbf.ShowDialog();
            }
            else if (temp_info.select_benefits == null)
            {
                benefits_button.Text = "select";
                select_benefits_form sbf = new select_benefits_form();
                sbf.ShowDialog();
                if(temp_info.select_benefits != null)
                {
                    benefits_button.Text = "selected";
                }
            }
        }

        private void save_button_Click(object sender, EventArgs e)
        {
            error_label.Visible = false;
            if (are_fileds_full())
            {
                switch (status)
                {
                    case Status.add:
                        using (DepartmentEntities db = new DepartmentEntities())
                        {
                            db.person_benefits.Add(new person_benefits()
                            {
                                personNUM = Convert.ToInt32(temp_info.select_person.personNUM),
                                benefitsNUM = Convert.ToInt32(temp_info.select_benefits.benefitsNUM),
                                person_benefitsSTART = Convert.ToDateTime(start_date.Value),
                                person_benefitsEND = null
                            });
                            db.SaveChanges();
                        }
                        break;

                    case Status.edit:
                        using (DepartmentEntities db = new DepartmentEntities())
                        {
                            if (tillnow)
                            {
                                person_benefits temp = new person_benefits()
                                {
                                    person_benefitsNUM = Convert.ToInt32(person_benefitsData.SelectedRows[0].Cells[0].Value),
                                    benefitsNUM = temp_info.select_benefits.benefitsNUM,
                                    personNUM = temp_info.select_person.personNUM,
                                    person_benefitsSTART = start_date.Value,
                                    person_benefitsEND = null
                                };
                                db.Entry(temp).State = System.Data.Entity.EntityState.Modified;
                            }
                            else
                            {
                                person_benefits temp = new person_benefits()
                                {
                                    person_benefitsNUM = Convert.ToInt32(person_benefitsData.SelectedRows[0].Cells[0].Value),
                                    benefitsNUM = temp_info.select_benefits.benefitsNUM,
                                    personNUM = temp_info.select_person.personNUM,
                                    person_benefitsSTART = start_date.Value,
                                    person_benefitsEND = end_date.Value
                                };
                                db.Entry(temp).State = System.Data.Entity.EntityState.Modified;
                            }
                            
                            db.SaveChanges();
                        }
                        control_groupBox.Visible = false;
                        break;

                    default:
                        break;
                }
                clear_all_fields();
                getData();

            }
            else
            {
                error_label.Visible = true;
            }
        }

        private bool are_fileds_full()
        {
            if (temp_info.select_person == null || person_button.Text == "select")
                return false;
            if (temp_info.select_benefits == null || benefits_button.Text == "select")
                return false;
            return true;
        }

        private void delete_button_Click(object sender, EventArgs e)
        {
            clear_all_fields();
            control_groupBox.Visible = false;
            if (person_benefitsData.SelectedRows.Count > 0)
            {
                using (DepartmentEntities db = new DepartmentEntities())
                {
                    bool oldValidateOnSaveEnabled = db.Configuration.ValidateOnSaveEnabled;

                    foreach (DataGridViewRow index in person_benefitsData.SelectedRows)
                    {
                        try
                        {
                            db.Configuration.ValidateOnSaveEnabled = false;
                            person_benefits temp = new person_benefits()
                            {
                                person_benefitsNUM = Convert.ToInt32(index.Cells[0].Value)
                            };
                            db.person_benefits.Attach(temp);
                            db.Entry(temp).State = System.Data.Entity.EntityState.Deleted;

                        }
                        finally
                        {
                            db.Configuration.ValidateOnSaveEnabled = oldValidateOnSaveEnabled;
                        }
                    }
                    try
                    {
                        db.SaveChanges();
                    }
                    catch (System.Data.Entity.Infrastructure.DbUpdateException)
                    {
                        MessageBox.Show("The record has a link to another table", "Error");
                    }
                }
                getData();
            }
            else
            {
                MessageBox.Show("Select at least 1 item");
            }
        }

        private void edit_button_Click(object sender, EventArgs e)
        {
            clear_all_fields();
            if (person_benefitsData.SelectedRows.Count != 1)
            {
                MessageBox.Show("Select one item, please");
            }
            else
            {
                tillnow_button.Visible = true;
                or_label.Visible = true;
                control_groupBox.Visible = true;
                control_groupBox.Text = "edit item";
                status = Status.edit;

                DataGridViewRow row = person_benefitsData.SelectedRows[0];
                int index = Convert.ToInt32(row.Cells[0].Value);
                using (DepartmentEntities db = new DepartmentEntities())
                {
                    var ids = db.person_benefits.FirstOrDefault(i => i.person_benefitsNUM == index);

                    person pers = db.person.FirstOrDefault(i => i.personNUM == ids.personNUM);

                    benefits bens = db.benefits.FirstOrDefault(i => i.benefitsNUM == ids.benefitsNUM);

                    temp_info.select_person = pers;
                    temp_info.select_benefits = bens;
                }
                person_button.Text = "selected";
                benefits_button.Text = "selected";
                start_date.Value = Convert.ToDateTime(row.Cells[5].Value);
                end_date.Visible = true;
                end_label.Visible = true;

                if (row.Cells[6].Value == null)
                    end_date.Value = Convert.ToDateTime(row.Cells[6].Value).Date;
                else
                    end_date.Value = DateTime.Now;
            }
        }

        private void tillnow_button_Click(object sender, EventArgs e)
        {
            tillnow = tillnow ? false : true;
        }

        private void tillnow_button_Paint(object sender, PaintEventArgs e)
        {
            tillnow_button.ForeColor = tillnow ? Color.Green : Color.Red;
        }

        private void hide_button_Click(object sender, EventArgs e)
        {
            clear_all_fields();
            control_groupBox.Visible = false;
            status = new Status();
        }

        private void search_button_Click(object sender, EventArgs e)
        {
            temp_info.person_benefits_search = null;
            person_benefits_search ps = new person_benefits_search();
            ps.ShowDialog();
            if (temp_info.person_benefits_search != null)
            {
                person_benefitsData.ClearSelection();
                foreach (DataGridViewRow row in person_benefitsData.Rows)
                {
                    if (Convert.ToInt32(row.Cells[0].Value) == temp_info.person_benefits_search.person_benefitsNUM)
                    {
                        person_benefitsData.Rows[row.Index].Selected = true;
                    }
                }
            }
        }
    }
}

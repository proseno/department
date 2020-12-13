using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Migrations;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Department
{
    public partial class person_form : Form
    {
        private enum Status
        {
            add = 1,
            edit = 2
        }

        private Status editing = new Status();

        public person_form()
        {
            InitializeComponent();
        }

        private void person_form_Load(object sender, EventArgs e)
        {
            getData();
        }

        private void getData()
        {
            personData.Rows.Clear();
            using (DepartmentEntities db = new DepartmentEntities())
            {
                var persons = db.person;
                int i = 0;
                foreach (person p in persons)
                {
                    personData.Rows.Add();
                    personData.Rows[i].Cells[0].Value = p.personNUM;
                    personData.Rows[i].Cells[1].Value = p.personNAME;
                    personData.Rows[i].Cells[2].Value = p.personPASPORT;
                    personData.Rows[i].Cells[3].Value = p.personIDCode;
                    personData.Rows[i].Cells[4].Value = p.personAddress;
                    personData.Rows[i].Cells[5].Value = p.personBirth.Date.ToShortDateString();

                    i++;
                }
            }
        }

        private void add_idcode_label_Click(object sender, EventArgs e)
        {

        }

        private void add_idcode_textbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void add_button_Click(object sender, EventArgs e)
        {
            add_groupBox.Visible = true;
            clear_all_fields();
            editing = Status.add;
        }

        private void clear_button_Click(object sender, EventArgs e)
        {
            clear_all_fields();
        }

        private void clear_all_fields()
        {
            add_Name_textbox.Text = "";
            add_Pasport_textbox.Text = "";
            add_idcode_textbox.Text = "";
            add_Address_textbox.Text = "";
            add_birth_date.Value = DateTime.Now;
        }

        private void save_button_Click(object sender, EventArgs e)
        {
            error_label.Visible = false;
            if (is_add_groupBox_Empty())
            {
                switch (editing)
                {
                    case Status.add:
                        using (DepartmentEntities db = new DepartmentEntities())
                        {
                            db.person.Add(new person()
                            {
                                personNAME = add_Name_textbox.Text,
                                personPASPORT = add_Pasport_textbox.Text,
                                personIDCode = add_idcode_textbox.Text,
                                personAddress = add_Address_textbox.Text,
                                personBirth = add_birth_date.Value
                            });
                            db.SaveChanges();

                        }
                        clear_all_fields();
                        break;

                    case Status.edit:
                        
                        DataGridViewRow row = personData.SelectedRows[0];
                        person temp = new person()
                        {
                            personNUM = Convert.ToInt32(row.Cells[0].Value),
                            personNAME = Convert.ToString(row.Cells[1].Value),
                            personPASPORT = Convert.ToString(row.Cells[2].Value),
                            personIDCode = Convert.ToString(row.Cells[3].Value),
                            personAddress = Convert.ToString(row.Cells[4].Value),
                            personBirth = Convert.ToDateTime(row.Cells[5].Value)
                        };
                            
                        using (DepartmentEntities db = new DepartmentEntities())
                        {
                            //person temp2 = db.person.Find(temp);
                            temp.personNAME = add_Name_textbox.Text;
                            temp.personPASPORT = add_Pasport_textbox.Text;
                            temp.personIDCode = add_idcode_textbox.Text;
                            temp.personAddress = add_Address_textbox.Text;
                            temp.personBirth = add_birth_date.Value;
                            db.Entry(temp).State = System.Data.Entity.EntityState.Modified;
                            db.SaveChanges();
                        }
                        clear_all_fields();
                        break;

                    default:
                        break;
                }
                getData();
            }
            else
            {
                error_label.Visible = true;
            }
        }

        private bool is_add_groupBox_Empty()
        {
            if(add_Name_textbox.Text == "")
            {
                return false;
            }
            else if (add_Pasport_textbox.Text == "")
            {
                return false;
            }
            else if (add_idcode_textbox.Text == "")
            {
                return false;
            }
            else if (add_Address_textbox.Text == "")
            {
                return false;
            }
            return true;
        }

        private void delete_button_Click(object sender, EventArgs e)
        {
            //не видаляє, бо є звязок з данними з іншої таблиці
            add_groupBox.Visible = false;
            using (DepartmentEntities db = new DepartmentEntities())
            {
                bool oldValidateOnSaveEnabled = db.Configuration.ValidateOnSaveEnabled;

                foreach (DataGridViewRow index in personData.SelectedRows)
                {
                    try
                    {
                        db.Configuration.ValidateOnSaveEnabled = false;
                        person temp = new person()
                        {
                            personNUM = Convert.ToInt32(index.Cells[0].Value),
                            personNAME = Convert.ToString(index.Cells[1].Value),
                            personPASPORT = Convert.ToString(index.Cells[2].Value),
                            personIDCode = Convert.ToString(index.Cells[3].Value),
                            personAddress = Convert.ToString(index.Cells[4].Value),
                            personBirth = Convert.ToDateTime(index.Cells[5].Value)
                        };
                        db.person.Attach(temp);
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

        private void edit_button_Click(object sender, EventArgs e)
        {
           
            if (personData.SelectedRows.Count != 1)
            {
                MessageBox.Show("Select one item, please");
            }
            else {

                add_groupBox.Visible = true;
                clear_all_fields();
                add_groupBox.Text = "edit item";
                editing = Status.edit;

                DataGridViewRow row = personData.SelectedRows[0];

                add_Name_textbox.Text = Convert.ToString(row.Cells[1].Value);
                add_Pasport_textbox.Text = Convert.ToString(row.Cells[2].Value);
                add_idcode_textbox.Text = Convert.ToString(row.Cells[3].Value);
                add_Address_textbox.Text = Convert.ToString(row.Cells[4].Value);
                add_birth_date.Value = Convert.ToDateTime(row.Cells[5].Value);
            }
            

        }

        private void add_Address_textbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void hide_button_Click(object sender, EventArgs e)
        {
            clear_all_fields();
            add_groupBox.Visible = false;
            editing = new Status();
        }

        private void search_button_Click(object sender, EventArgs e)
        {
            temp_info.person_search = null;
            person_search ps = new person_search();
            ps.ShowDialog();
            if(temp_info.person_search != null)
            {
                personData.ClearSelection();
                foreach (DataGridViewRow row in personData.Rows)
                {
                    if (Convert.ToInt32(row.Cells[0].Value) == temp_info.person_search.personNUM)
                    {
                        personData.Rows[row.Index].Selected = true;
                    }
                }
            }
        }
    }
}

using Microsoft.EntityFrameworkCore.Query.SqlExpressions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Department
{
    public partial class benefits_form : Form
    {
        private enum Status
        {
            add = 1,
            edit = 2
        }

        Status status = new Status();

        public benefits_form()
        {
            InitializeComponent();
        }

        private void benefits_form_Load(object sender, EventArgs e)
        {
            
            getData();
        }

        private void getData()
        {
            benefitsData.Rows.Clear();
            using (DepartmentEntities db = new DepartmentEntities())
            {
                var benefitss = db.benefits;
                int i = 0;
                foreach (benefits item in benefitss)
                {
                    benefitsData.Rows.Add();
                    benefitsData.Rows[i].Cells[0].Value = item.benefitsNUM;
                    benefitsData.Rows[i].Cells[1].Value = item.benefitsNAME;
                    benefitsData.Rows[i].Cells[2].Value = item.benefitsDESCRIPTION;
                    benefitsData.Rows[i].Cells[3].Value = item.benefitsKIND;
                    i++;
                }
            }
        }

        private void clear_button_Click(object sender, EventArgs e)
        {
            clear_all_fields();
        }

        private void clear_all_fields()
        {
            name_textbox.Text = "";
            description_textbox.Text = "";
            kind_textbox.Text = "";
        }

        private void save_button_Click(object sender, EventArgs e)
        {
            error_label.Visible = false;
            if (are_fields_filled())
            {
                switch (status)
                {
                    case Status.add:
                        using(DepartmentEntities db = new DepartmentEntities())
                        {
                            db.Database.ExecuteSqlCommand($"INSERT INTO benefits (benefitsNAME, benefitsDESCRIPTION, benefitsKIND)" +
                                $"VALUES" +
                                $"('{name_textbox.Text}', '{description_textbox.Text}', '{kind_textbox.Text}')");
                            db.SaveChanges();
                        }
                        break;


                    case Status.edit:
                        DataGridViewRow row = benefitsData.SelectedRows[0];
                        using (DepartmentEntities db = new DepartmentEntities())
                        {
                            db.Database.ExecuteSqlCommand($"UPDATE benefits " +
                                $"SET benefitsNAME = '{name_textbox.Text}', benefitsDESCRIPTION = '{description_textbox.Text}', benefitsKIND = '{kind_textbox.Text}'" +
                                $"WHERE benefitsNUM = {row.Cells[0].Value}");
                            db.SaveChanges();
                        }
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
            clear_all_fields();
        }

        private bool are_fields_filled()
        {
            if (name_textbox.Text == "")
                return false;
            else if (description_textbox.Text == "")
                return false;
            else if (kind_textbox.Text == "")
                return false;
            return true;
        }

        private void add_button_Click(object sender, EventArgs e)
        {
            status = Status.add;
            control_groupBox.Text = "add item";
            control_groupBox.Visible = control_groupBox.Visible ? false : true;
        }

        private void edit_button_Click(object sender, EventArgs e)
        {
            if(benefitsData.SelectedRows.Count != 1)
            {
                MessageBox.Show("Select one item, please");
            }
            else
            {
                status = Status.edit;
                control_groupBox.Text = "edit item";
                control_groupBox.Visible = control_groupBox.Visible ? false : true;

                DataGridViewRow row = benefitsData.SelectedRows[0];

                name_textbox.Text = Convert.ToString(row.Cells[1].Value);
                description_textbox.Text = Convert.ToString(row.Cells[2].Value);
                kind_textbox.Text = Convert.ToString(row.Cells[3].Value);
            }
        }

        private void delete_button_Click(object sender, EventArgs e)
        {
            control_groupBox.Visible = false;
            if (benefitsData.SelectedRows.Count > 0)
            {
                using (DepartmentEntities db = new DepartmentEntities())
                {
                    bool oldValidateOnSaveEnabled = db.Configuration.ValidateOnSaveEnabled;

                    foreach (DataGridViewRow index in benefitsData.SelectedRows)
                    {
                        try
                        {
                            db.Configuration.ValidateOnSaveEnabled = false;
                            benefits temp = new benefits()
                            {
                                benefitsNUM = Convert.ToInt32(index.Cells[0].Value),
                                benefitsNAME = Convert.ToString(index.Cells[1].Value),
                                benefitsDESCRIPTION = Convert.ToString(index.Cells[2].Value),
                                benefitsKIND = Convert.ToString(index.Cells[3].Value)
                            };
                            db.benefits.Attach(temp);
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

        private void hide_button_Click(object sender, EventArgs e)
        {
            clear_all_fields();
            control_groupBox.Visible = false;
            status = new Status();
        }

        private void search_button_Click(object sender, EventArgs e)
        {
            temp_info.benefits_search = null;
            benefits_search ps = new benefits_search();
            ps.ShowDialog();
            if (temp_info.benefits_search != null)
            {
                benefitsData.ClearSelection();
                foreach (DataGridViewRow row in benefitsData.Rows)
                {
                    if (Convert.ToInt32(row.Cells[0].Value) == temp_info.benefits_search.benefitsNUM)
                    {
                        benefitsData.Rows[row.Index].Selected = true;
                    }
                }
            }
        }
    }
}

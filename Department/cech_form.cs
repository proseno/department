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
    public partial class cech_form : Form
    {
        private enum Status
        {
            add = 1,
            edit = 2
        }

        Status status = new Status();

        public cech_form()
        {
            InitializeComponent();
        }

        private void cech_form_Load(object sender, EventArgs e)
        {
            getData();
        }

        private void getData()
        {
            cechData.Rows.Clear();
            using(DepartmentEntities db = new DepartmentEntities())
            {
                int i = 0;
                var cechs = db.cech;
                foreach (var item in cechs)
                {
                    cechData.Rows.Add();
                    cechData.Rows[i].Cells[0].Value = item.cechNUM;
                    cechData.Rows[i].Cells[1].Value = item.cechNAME;
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
        }

        private void add_button_Click(object sender, EventArgs e)
        {
            control_groupBox.Visible = control_groupBox.Visible ? false : true;
            control_groupBox.Text = "add item";
            status = Status.add;
        }

        private void edit_button_Click(object sender, EventArgs e)
        {
            
            if (cechData.SelectedRows.Count != 1)
            {
                MessageBox.Show("Select one item, please");
            }
            else
            {
                control_groupBox.Visible = control_groupBox.Visible ? false : true;
                control_groupBox.Text = "edit item";
                status = Status.edit;

                DataGridViewRow row = cechData.SelectedRows[0];

                name_textbox.Text = Convert.ToString(row.Cells[1].Value);
            }
        }

        private void delete_button_Click(object sender, EventArgs e)
        {
            control_groupBox.Visible = false;
            if (cechData.SelectedRows.Count > 0)
            {
                using (DepartmentEntities db = new DepartmentEntities())
                {
                    bool oldValidateOnSaveEnabled = db.Configuration.ValidateOnSaveEnabled;

                    foreach (DataGridViewRow index in cechData.SelectedRows)
                    {
                        try
                        {
                            db.Configuration.ValidateOnSaveEnabled = false;
                            cech temp = new cech()
                            {
                                cechNUM = Convert.ToInt32(index.Cells[0].Value),
                                cechNAME = Convert.ToString(index.Cells[1].Value)
                            };
                            db.cech.Attach(temp);
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

        private void save_button_Click(object sender, EventArgs e)
        {
            error_label.Visible = false;
            if (are_fields_full())
            {
                switch (status)
                {
                    case Status.add:
                        using(DepartmentEntities db = new DepartmentEntities())
                        {
                            //db.Database.ExecuteSqlCommand($"INSERT INTO cech (cechNAME)" +
                            //    $"VALUES" +
                            //    $"('{name_textbox.Text}')");
                            db.cech.Add(new cech()
                            {
                                cechNAME = Convert.ToString(name_textbox.Text)
                            });
                            
                            db.SaveChanges();
                        }
                        break;

                    case Status.edit:
                        DataGridViewRow row = cechData.SelectedRows[0];
                        using(DepartmentEntities db = new DepartmentEntities())
                        {
                            db.Database.ExecuteSqlCommand($"UPDATE cech " +
                                $"SET cechNAME = '{name_textbox.Text.ToString()}'" +
                                $"WHERE cechNUM = {Convert.ToInt32(row.Cells[0].Value)}");
                            db.SaveChanges();
                        }
                        break;

                    default:
                        break;
                }
                getData();
                clear_all_fields();
            }
            else
            {
                error_label.Visible = true;
            }
        }

        private bool are_fields_full()
        {
            if (name_textbox.Text == "")
                return false;
            return true;
        }

        private void hide_button_Click(object sender, EventArgs e)
        {
            clear_all_fields();
            control_groupBox.Visible = false;
            status = new Status();
        }

        private void search_button_Click(object sender, EventArgs e)
        {
            temp_info.cech_search = null;
            cech_search ps = new cech_search();
            ps.ShowDialog();
            if (temp_info.cech_search != null)
            {
                cechData.ClearSelection();
                foreach (DataGridViewRow row in cechData.Rows)
                {
                    if (Convert.ToInt32(row.Cells[0].Value) == temp_info.cech_search.cechNUM)
                    {
                        cechData.Rows[row.Index].Selected = true;
                    }
                }
            }
        }
    }
}

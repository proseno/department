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
    public partial class position_form : Form
    {
        private enum Status
        {
            add = 1,
            edit = 2
        }

        Status status = new Status();

        public position_form()
        {
            InitializeComponent();
        }

        private void position_form_Load(object sender, EventArgs e)
        {
            getData();
        }

        private void getData()
        {
            positionData.Rows.Clear();
            using (DepartmentEntities db = new DepartmentEntities())
            {
                var positions = db.position;
                int i = 0;
                foreach (var item in positions)
                {
                    positionData.Rows.Add();
                    positionData.Rows[i].Cells[0].Value = item.positionNUM;
                    positionData.Rows[i].Cells[1].Value = item.positionNAME;
                    positionData.Rows[i].Cells[2].Value = item.positionSALARY;
                    i++;
                }
            }
        }

        private void add_button_Click(object sender, EventArgs e)
        {
            controls_groupBox.Text = "add new item";
            controls_groupBox.Visible = true;
            status = Status.add;
        }

        private void clear_all_fields()
        {
            name_textbox.Text = "";
            salary_numerics.Value = 0;
        }

        private void clear_button_Click(object sender, EventArgs e)
        {
            clear_all_fields(); 
        }

        private void save_button_Click(object sender, EventArgs e)
        {
            error_label.Visible = false;
            if (!are_all_fields_empty())
            {
                error_label.Visible = true;
            }
            else 
            {
                switch (status)
                {
                    case Status.add:
                        using (DepartmentEntities db = new DepartmentEntities())
                        {
                            db.Database.ExecuteSqlCommand($"INSERT INTO position (positionNAME, positionSALARY) " +
                                $"VALUES " +
                                $"('{name_textbox.Text.ToString()}', {Convert.ToDecimal(salary_numerics.Value)})");
                            db.SaveChanges();
                        }

                        break;

                    case Status.edit:
                        DataGridViewRow row = positionData.SelectedRows[0];
                        position temp = new position()
                        {
                            positionNUM = Convert.ToInt32(row.Cells[0].Value),
                            positionNAME = Convert.ToString(name_textbox.Text),
                            positionSALARY = Convert.ToDecimal(salary_numerics.Value)
                        };
                        using (DepartmentEntities db = new DepartmentEntities())
                        {
                            db.Entry(temp).State = System.Data.Entity.EntityState.Modified;
                            db.SaveChanges();
                        }

                        break;

                    default:
                        break;
                }
                getData();
                clear_all_fields();
            }
        }

        private bool are_all_fields_empty()
        {
            if (name_textbox.Text == "")
            {
                return false;
            }
            else if (salary_numerics.Value <= 0)
            {
                return false;
            }
            return true;
        }

        private void edit_button_Click(object sender, EventArgs e)
        {
            if(positionData.SelectedRows.Count != 1)
            {
                MessageBox.Show("Select one item, please");
            }
            else
            {
                controls_groupBox.Visible = true;
                controls_groupBox.Text = "edit item";
                status = Status.edit;

                DataGridViewRow row = positionData.SelectedRows[0];
                name_textbox.Text = Convert.ToString(row.Cells[1].Value);
                salary_numerics.Value = Convert.ToDecimal(row.Cells[2].Value);
            }
            
        }

        private void delete_button_Click(object sender, EventArgs e)
        {
            controls_groupBox.Visible = false;
            using (DepartmentEntities db = new DepartmentEntities())
            {
                bool oldValidateOnSaveEnabled = db.Configuration.ValidateOnSaveEnabled;

                foreach (DataGridViewRow index in positionData.SelectedRows)
                {
                    try
                    {
                        db.Configuration.ValidateOnSaveEnabled = false;
                        position temp = new position()
                        {
                            positionNUM = Convert.ToInt32(index.Cells[0].Value),
                            positionNAME = Convert.ToString(index.Cells[1].Value),
                            positionSALARY = Convert.ToDecimal(index.Cells[2].Value)
                        };
                        db.position.Attach(temp);
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

        private void hide_button_Click(object sender, EventArgs e)
        {
            clear_all_fields();
            controls_groupBox.Visible = false;
            status = new Status();
        }

        private void search_button_Click(object sender, EventArgs e)
        {
            temp_info.position_search = null;
            position_search ps = new position_search();
            ps.ShowDialog();
            if(temp_info.position_search != null)
            {
                positionData.ClearSelection();
                foreach (DataGridViewRow row in positionData.Rows)
                {
                    if (Convert.ToInt32(row.Cells[0].Value) == temp_info.position_search.positionNUM)
                    {
                        positionData.Rows[row.Index].Selected = true;
                    }
                }
            }
        }
    }
}

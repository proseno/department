using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.IsolatedStorage;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Department
{
    public partial class storage_form : Form
    {
        private enum Status
        {
            add = 1,
            edit = 2
        }

        private Status status = new Status();

        public storage_form()
        {
            InitializeComponent();
        }

        private void storage_form_Load(object sender, EventArgs e)
        {
            getData();
        }

        private void getData()
        {
            storageData.DataSource = null;
            using(DepartmentEntities db = new DepartmentEntities())
            {
                var data = from storage in db.storage
                           select new
                           {
                               storage.storageNUM,
                               storage.storageNAME,
                               storage.storageADDRESS
                           };

                storageData.DataSource = data.ToList();
                storageData.Columns[0].HeaderText = "Id";
                storageData.Columns[1].HeaderText = "Name";
                storageData.Columns[2].HeaderText = "Address";
            }
        }

        private void clear_all_fields()
        {
            name_textbox.Text = "";
            address_textbox.Text = "";
        }

        private void clear_button_Click(object sender, EventArgs e)
        {
            clear_all_fields();
        }

        private void add_button_Click(object sender, EventArgs e)
        {
            status = Status.add;
            control_groupBox.Visible = true;
            control_groupBox.Text = "add item";
        }

        private void edit_button_Click(object sender, EventArgs e)
        {
            if (storageData.SelectedRows.Count != 1)
            {
                MessageBox.Show("Select one item, please");
            }
            else
            {
                status = Status.edit;
                control_groupBox.Text = "edit item";
                control_groupBox.Visible = true;

                DataGridViewRow row = storageData.SelectedRows[0];

                name_textbox.Text = Convert.ToString(row.Cells[1].Value);
                address_textbox.Text = Convert.ToString(row.Cells[2].Value);
            }
        }

        private void delete_button_Click(object sender, EventArgs e)
        {
            control_groupBox.Visible = false;
            if (storageData.SelectedRows.Count > 0)
            {
                using (DepartmentEntities db = new DepartmentEntities())
                {
                    bool oldValidateOnSaveEnabled = db.Configuration.ValidateOnSaveEnabled;

                    foreach (DataGridViewRow index in storageData.SelectedRows)
                    {
                        try
                        {
                            db.Configuration.ValidateOnSaveEnabled = false;
                            storage temp = new storage()
                            {
                                storageNUM = Convert.ToInt32(index.Cells[0].Value),
                                storageNAME = Convert.ToString(index.Cells[1].Value),
                                storageADDRESS = Convert.ToString(index.Cells[2].Value)
                            };
                            db.storage.Attach(temp);
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
                            db.storage.Add(new storage()
                            {
                                storageNAME = Convert.ToString(name_textbox.Text),
                                storageADDRESS = Convert.ToString(address_textbox.Text)
                            });
                            db.SaveChanges();
                        }
                        break;
                    case Status.edit:
                        DataGridViewRow row = storageData.SelectedRows[0];
                        using(DepartmentEntities db = new DepartmentEntities())
                        {
                            storage temp = new storage()
                            {
                                storageNUM = Convert.ToInt32(row.Cells[0].Value),
                                storageNAME = Convert.ToString(name_textbox.Text),
                                storageADDRESS = Convert.ToString(address_textbox.Text)
                            };
                            db.Entry(temp).State = System.Data.Entity.EntityState.Modified;
                            db.SaveChanges();
                        }
                        break;
                    default:
                        break;
                }
                clear_all_fields();
                getData();
            }
            else
            {
                error_label.Visible = false;
            }
        }

        private bool are_fields_full()
        {
            if (name_textbox.Text == "")
                return false;
            if (address_textbox.Text == "")
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
            temp_info.storage_search = null;
            storage_search ps = new storage_search();
            ps.ShowDialog();
            if (temp_info.storage_search != null)
            {
                storageData.ClearSelection();
                foreach (DataGridViewRow row in storageData.Rows)
                {
                    if (Convert.ToInt32(row.Cells[0].Value) == temp_info.storage_search.storageNUM)
                    {
                        storageData.Rows[row.Index].Selected = true;
                    }
                }
            }
        }
    }
}

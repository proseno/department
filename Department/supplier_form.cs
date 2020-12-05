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
    public partial class supplier_form : Form
    {
        private enum Status
        {
            add = 1,
            edit = 2
        }

        Status status = new Status();

        public supplier_form()
        {
            InitializeComponent();
        }

        private void supplier_form_Load(object sender, EventArgs e)
        {
            getData();
        }

        private void getData()
        {
            supplierData.Rows.Clear();
            using(DepartmentEntities db = new DepartmentEntities())
            {
                int i = 0;
                var suppliers = db.supplier;
                foreach (var item in suppliers)
                {
                    supplierData.Rows.Add();
                    supplierData.Rows[i].Cells[0].Value = item.supplierNUM;
                    supplierData.Rows[i].Cells[1].Value = item.supplierNAME;
                    supplierData.Rows[i].Cells[2].Value = item.supplierADDRESS;
                    supplierData.Rows[i].Cells[3].Value = item.supplierContacts;
                    i++;
                }
            }
        }

        private void add_button_Click(object sender, EventArgs e)
        {
            control_groupBox.Visible = true;
            control_groupBox.Text = "add item";
            status = Status.add;
        }

        private void clear_button_Click(object sender, EventArgs e)
        {
            clear_all_fields();
        }

        private void clear_all_fields()
        {
            name_textbox.Text = "";
            address_textbox.Text = "";
            contacts_textbox.Text = "";
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
                            db.supplier.Add(new supplier()
                            {
                                supplierNAME = name_textbox.Text,
                                supplierADDRESS = address_textbox.Text,
                                supplierContacts = contacts_textbox.Text
                            });
                            db.SaveChanges();
                            clear_all_fields();
                        }
                        break;

                    case Status.edit:
                        DataGridViewRow row = supplierData.SelectedRows[0];
                        using(DepartmentEntities db = new DepartmentEntities())
                        {
                            db.Database.ExecuteSqlCommand($"UPDATE supplier " +
                               $"SET supplierNAME = '{name_textbox.Text.ToString()}', supplierADDRESS = '{address_textbox.Text.ToString()}', supplierContacts = '{contacts_textbox.Text.ToString()}'" +
                               $"WHERE supplierNUM = {Convert.ToInt32(row.Cells[0].Value)}");

                            db.SaveChanges();
                            clear_all_fields();
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
        }

        private bool are_fields_full()
        {
            if (name_textbox.Text == "")
                return false;
            if (address_textbox.Text == "")
                return false;
            if (contacts_textbox.Text == "")
                return false;
            return true;
        }

        private void edit_button_Click(object sender, EventArgs e)
        {
            if (supplierData.SelectedRows.Count != 1)
            {
                MessageBox.Show("Select one item, please");
            }
            else
            {
                control_groupBox.Visible = true;
                control_groupBox.Text = "edit item";
                status = Status.edit;

                DataGridViewRow row = supplierData.SelectedRows[0];

                name_textbox.Text = Convert.ToString(row.Cells[1].Value);
                address_textbox.Text = Convert.ToString(row.Cells[2].Value);
                contacts_textbox.Text = Convert.ToString(row.Cells[3].Value);
            }
        }

        private void delete_button_Click(object sender, EventArgs e)
        {
            control_groupBox.Visible = false;
            if (supplierData.SelectedRows.Count > 0)
            {
                using (DepartmentEntities db = new DepartmentEntities())
                {
                    bool oldValidateOnSaveEnabled = db.Configuration.ValidateOnSaveEnabled;

                    foreach (DataGridViewRow index in supplierData.SelectedRows)
                    {
                        try
                        {
                            db.Configuration.ValidateOnSaveEnabled = false;
                            supplier temp = new supplier()
                            {
                                supplierNUM = Convert.ToInt32(index.Cells[0].Value),
                                supplierNAME = Convert.ToString(index.Cells[1].Value),
                                supplierADDRESS = Convert.ToString(index.Cells[2].Value),
                                supplierContacts = Convert.ToString(index.Cells[3].Value)
                            };
                            db.supplier.Attach(temp);
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
            temp_info.supplier_search = null;
            supplier_search ps = new supplier_search();
            ps.ShowDialog();
            if (temp_info.supplier_search != null)
            {
                supplierData.ClearSelection();
                foreach (DataGridViewRow row in supplierData.Rows)
                {
                    if (Convert.ToInt32(row.Cells[0].Value) == temp_info.supplier_search.supplierNUM)
                    {
                        supplierData.Rows[row.Index].Selected = true;
                    }
                }
            }
        }
    }
}

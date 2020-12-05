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
    public partial class goods_form : Form
    {
        private enum Status
        {
            add = 1,
            edit = 2
        }

        Status status = new Status();

        public goods_form()
        {
            InitializeComponent();
        }

        private void goods_form_Load(object sender, EventArgs e)
        {
            getData();
        }

        private void getData()
        {
            goodsData.DataSource = null;
            using(DepartmentEntities db = new DepartmentEntities())
            {
                var data = from goods in db.goods
                           select new
                           {
                               goods.goodsNUM,
                               goods.goodsNAME,
                               goods.goodsPRICE
                           };
                   
                goodsData.DataSource = data.ToList();
                goodsData.Columns[0].HeaderText = "Id";
                goodsData.Columns[1].HeaderText = "Name";
                goodsData.Columns[2].HeaderText = "Price";
            }
        }

        private void clear_all_fields()
        {
            name_textbox.Text = "";
            price_textbox.Text = "";
        }

        private bool are_fields_full()
        {
            if (name_textbox.Text == "")
                return false;
            if (price_textbox.Text == "")
                return false;
            return true;
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
            if (goodsData.SelectedRows.Count != 1)
            {
                MessageBox.Show("Select one item, please");
            }
            else
            {
                status = Status.edit;
                control_groupBox.Text = "edit item";
                control_groupBox.Visible = control_groupBox.Visible ? false : true;

                DataGridViewRow row = goodsData.SelectedRows[0];

                name_textbox.Text = Convert.ToString(row.Cells[1].Value);
                price_textbox.Text = Convert.ToString(row.Cells[2].Value);
            }
        }

        private void save_button_Click(object sender, EventArgs e)
        {
            error_label.Visible = false;
            if (are_fields_full())
            {
                try
                {
                    Convert.ToDecimal(price_textbox.Text);
                }
                catch
                {
                    MessageBox.Show("Please, enter number in Price textbox");
                    return;
                }
                switch (status)
                {
                    case Status.add:
                        using (DepartmentEntities db = new DepartmentEntities())
                        {
                            db.goods.Add(new goods()
                            {
                                goodsNAME = Convert.ToString(name_textbox.Text),
                                goodsPRICE = Convert.ToDecimal(price_textbox.Text)
                            });
                            db.SaveChanges();

                        }
                        
                        break;

                    case Status.edit:
                        using(DepartmentEntities db = new DepartmentEntities())
                        {
                            DataGridViewRow row = goodsData.SelectedRows[0];
                            goods temp = new goods()
                            {
                                goodsNUM = Convert.ToInt32(row.Cells[0].Value),
                                goodsNAME = Convert.ToString(name_textbox.Text),
                                goodsPRICE = Convert.ToDecimal(price_textbox.Text)
                            };
                            db.Entry(temp).State = System.Data.Entity.EntityState.Modified;
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

        private void delete_button_Click(object sender, EventArgs e)
        {
            control_groupBox.Visible = false;
            if (goodsData.SelectedRows.Count > 0)
            {
                using (DepartmentEntities db = new DepartmentEntities())
                {
                    bool oldValidateOnSaveEnabled = db.Configuration.ValidateOnSaveEnabled;

                    foreach (DataGridViewRow index in goodsData.SelectedRows)
                    {
                        try
                        {
                            db.Configuration.ValidateOnSaveEnabled = false;
                            goods temp = new goods()
                            {
                                goodsNUM = Convert.ToInt32(index.Cells[0].Value),
                                goodsNAME = Convert.ToString(index.Cells[1].Value),
                                goodsPRICE = Convert.ToDecimal(index.Cells[2].Value)
                            };
                            db.goods.Attach(temp);
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
            temp_info.goods_search = null;
            goods_search ps = new goods_search();
            ps.ShowDialog();
            if (temp_info.goods_search != null)
            {
                goodsData.ClearSelection();
                foreach (DataGridViewRow row in goodsData.Rows)
                {
                    if (Convert.ToInt32(row.Cells[0].Value) == temp_info.goods_search.goodsNUM)
                    {
                        goodsData.Rows[row.Index].Selected = true;
                    }
                }
            }
        }
    }
}

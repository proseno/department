using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging.Abstractions;
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
    public partial class delivery_form : Form
    {
        private enum Status
        {
            add = 1,
            edit = 2
        }

        private Status status = new Status();

        public delivery_form()
        {
            InitializeComponent();
        }

        private void delivery_form_Load(object sender, EventArgs e)
        {
            getData();
        }

        private void getData()
        {
            deliveryData.Rows.Clear();
            using (DepartmentEntities db = new DepartmentEntities())
            {
                var data = from delivery in db.delivery
                           join workers in db.workers on delivery.workersNUM equals workers.workersNUM
                           join goods in db.goods on delivery.goodsNUM equals goods.goodsNUM
                           join supplier in db.supplier on delivery.supplierNUM equals supplier.supplierNUM
                           join storage in db.storage on delivery.storageNUM equals storage.storageNUM
                           join person in db.person on workers.personNUM equals person.personNUM
                           select new
                           {
                               delivery.deliveryNUM,
                               goods.goodsNAME,
                               delivery.goodsCOUNT,
                               person.personNAME,
                               storage.storageNAME,
                               supplier.supplierNAME,
                               delivery.deliveryDATE
                           };
                int i = 0;
                foreach (var item in data)
                {
                    deliveryData.Rows.Add();
                    deliveryData.Rows[i].Cells[0].Value = item.deliveryNUM;
                    deliveryData.Rows[i].Cells[1].Value = item.goodsNAME;
                    deliveryData.Rows[i].Cells[2].Value = item.goodsCOUNT;
                    deliveryData.Rows[i].Cells[3].Value = item.personNAME;
                    deliveryData.Rows[i].Cells[4].Value = item.storageNAME;
                    deliveryData.Rows[i].Cells[5].Value = item.supplierNAME;
                    deliveryData.Rows[i].Cells[6].Value = item.deliveryDATE.Date.ToShortDateString();
                    i++;
                }
            }
        }

        private void fullData_button_Click(object sender, EventArgs e)
        {
            if(deliveryData.SelectedRows.Count == 1)
            {
                fullData_delivery_form df = new fullData_delivery_form(Convert.ToInt32(deliveryData.SelectedRows[0].Cells[0].Value));
                df.ShowDialog();
            }
            else
            {
                MessageBox.Show("Please, select 1 item");
            }
        }

        private void clear_all_fields()
        {
            worker_button.Text = "select";
            goods_button.Text = "select";
            supplier_button.Text = "select";
            storage_button.Text = "select";

            temp_info.select_workers = null;
            temp_info.select_goods = null;
            temp_info.select_supplier = null;
            temp_info.select_storage = null;

            count_textBox.Text = "";
            date.Value = DateTime.Now;
        }

        private void clear_button_Click(object sender, EventArgs e)
        {
            clear_all_fields();
        }

        private void add_button_Click(object sender, EventArgs e)
        {
            clear_all_fields();
            status = Status.add;
            control_groupBox.Visible = true;
            control_groupBox.Text = "add item";

        }

        private void worker_button_Click(object sender, EventArgs e)
        {
            if (temp_info.select_workers != null)
            {
                worker_button.Text = "selected";
                select_worker_form spf = new select_worker_form(temp_info.select_workers.workersNUM);
                spf.ShowDialog();
            }
            else if (temp_info.select_workers == null)
            {
                worker_button.Text = "select";
                select_worker_form spf = new select_worker_form();
                spf.ShowDialog();
                if (temp_info.select_workers != null)
                {
                    worker_button.Text = "selected";
                }
            }
        }

        private void goods_button_Click(object sender, EventArgs e)
        {
            if (temp_info.select_goods != null)
            {
                goods_button.Text = "selected";
                select_goods spf = new select_goods(temp_info.select_goods.goodsNUM);
                spf.ShowDialog();
            }
            else if (temp_info.select_goods == null)
            {
                goods_button.Text = "select";
                select_goods spf = new select_goods();
                spf.ShowDialog();
                if (temp_info.select_goods != null)
                {
                    goods_button.Text = "selected";
                }
            }
        }

        private void supplier_button_Click(object sender, EventArgs e)
        {
            if (temp_info.select_supplier != null)
            {
                supplier_button.Text = "selected";
                select_supplier_form spf = new select_supplier_form(temp_info.select_supplier.supplierNUM);
                spf.ShowDialog();
            }
            else if (temp_info.select_supplier == null)
            {
                supplier_button.Text = "select";
                select_supplier_form spf = new select_supplier_form();
                spf.ShowDialog();
                if (temp_info.select_supplier != null)
                {
                    supplier_button.Text = "selected";
                }
            }
        }

        private void storage_button_Click(object sender, EventArgs e)
        {
            if (temp_info.select_storage != null)
            {
                storage_button.Text = "selected";
                select_storage_form spf = new select_storage_form(temp_info.select_storage.storageNUM);
                spf.ShowDialog();
            }
            else if (temp_info.select_storage == null)
            {
                storage_button.Text = "select";
                select_storage_form spf = new select_storage_form();
                spf.ShowDialog();
                if (temp_info.select_storage != null)
                {
                    storage_button.Text = "selected";
                }
            }
        }

        private void save_button_Click(object sender, EventArgs e)
        {
            error_label.Visible = false;
            if (are_fields_full())
            {
                try
                {
                    Convert.ToDecimal(count_textBox.Text);
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
                            db.delivery.Add(new delivery()
                            {
                                workersNUM = Convert.ToInt32(temp_info.select_workers.workersNUM),
                                goodsNUM = Convert.ToInt32(temp_info.select_goods.goodsNUM),
                                supplierNUM = Convert.ToInt32(temp_info.select_supplier.supplierNUM),
                                storageNUM = Convert.ToInt32(temp_info.select_storage.storageNUM),
                                deliveryDATE = Convert.ToDateTime(date.Value),
                                goodsCOUNT = Convert.ToDecimal(count_textBox.Text)
                            });
                            db.SaveChanges();
                        }
                        break;

                    case Status.edit:
                        using (DepartmentEntities db = new DepartmentEntities())
                        {
                            delivery temp = new delivery()
                            {
                                deliveryNUM = Convert.ToInt32(deliveryData.SelectedRows[0].Cells[0].Value),
                                workersNUM = Convert.ToInt32(temp_info.select_workers.workersNUM),
                                goodsNUM = Convert.ToInt32(temp_info.select_goods.goodsNUM),
                                supplierNUM = Convert.ToInt32(temp_info.select_supplier.supplierNUM),
                                storageNUM = Convert.ToInt32(temp_info.select_storage.storageNUM),
                                deliveryDATE = Convert.ToDateTime(date.Value),
                                goodsCOUNT = Convert.ToDecimal(count_textBox.Text)
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

        private bool are_fields_full()
        {
            if (temp_info.select_workers == null)
                return false;
            if (temp_info.select_goods == null)
                return false;
            if (temp_info.select_supplier == null)
                return false;
            if (temp_info.select_storage == null)
                return false;
            if (count_textBox.Text == "")
                return false;
            return true;
        }

        private void delete_button_Click(object sender, EventArgs e)
        {
            clear_all_fields();
            control_groupBox.Visible = false;
            if (deliveryData.SelectedRows.Count > 0)
            {
                using (DepartmentEntities db = new DepartmentEntities())
                {
                    bool oldValidateOnSaveEnabled = db.Configuration.ValidateOnSaveEnabled;

                    foreach (DataGridViewRow index in deliveryData.SelectedRows)
                    {
                        try
                        {
                            db.Configuration.ValidateOnSaveEnabled = false;
                            delivery temp = new delivery()
                            {
                                deliveryNUM = Convert.ToInt32(index.Cells[0].Value)
                            };
                            db.delivery.Attach(temp);
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
            if (deliveryData.SelectedRows.Count != 1)
            {
                MessageBox.Show("Select one item, please");
            }
            else
            {
                control_groupBox.Visible = true;
                control_groupBox.Text = "edit item";
                status = Status.edit;

                DataGridViewRow row = deliveryData.SelectedRows[0];
                int index = Convert.ToInt32(row.Cells[0].Value);
                using (DepartmentEntities db = new DepartmentEntities())
                {
                    var ids = db.delivery.FirstOrDefault(i => i.deliveryNUM == index);

                    workers pers = db.workers.FirstOrDefault(i => i.workersNUM == ids.workersNUM);

                    supplier sups = db.supplier.FirstOrDefault(i => i.supplierNUM == ids.supplierNUM);
                    storage stos = db.storage.FirstOrDefault(i => i.storageNUM == ids.storageNUM);
                    goods goos = db.goods.FirstOrDefault(i => i.goodsNUM == ids.goodsNUM);

                    temp_info.select_workers = pers;
                    temp_info.select_supplier = sups;
                    temp_info.select_storage = stos;
                    temp_info.select_goods = goos;
                   
                }
                worker_button.Text = "selected";
                goods_button.Text = "selected";
                supplier_button.Text = "selected";
                storage_button.Text = "selected";
                count_textBox.Text = Convert.ToString(row.Cells[2].Value);
                date.Value = Convert.ToDateTime(row.Cells[6].Value);
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
            temp_info.delivery_search = null;
            delivery_search ps = new delivery_search();
            ps.ShowDialog();
            if (temp_info.delivery_search != null)
            {
                deliveryData.ClearSelection();
                foreach (DataGridViewRow row in deliveryData.Rows)
                {
                    if (Convert.ToInt32(row.Cells[0].Value) == temp_info.delivery_search.deliveryNUM)
                    {
                        deliveryData.Rows[row.Index].Selected = true;
                    }
                }
            }
        }
    }
}

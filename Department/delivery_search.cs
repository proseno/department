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
    public partial class delivery_search : Form
    {
        public delivery_search()
        {
            InitializeComponent();
            temp_info.delivery_storageNUM = null;
            temp_info.delivery_supplierNUM = null;
            temp_info.delivery_goodsNUM = null;
            temp_info.delivery_search = null;
            temp_info.delivery_workerNUM = null;
        }

        private void cancel_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void clear_button_Click(object sender, EventArgs e)
        {
            clear_all_fields();
        }

        private void clear_all_fields()
        {
            id_textBox.Text = "";
            on_off_button.Text = "off";
            date.Value = DateTime.Now.Date;
            count_textBox.Text = "";

            temp_info.delivery_storageNUM = null;
            temp_info.delivery_supplierNUM = null;
            temp_info.delivery_goodsNUM = null;
            temp_info.delivery_search = null;
            temp_info.delivery_workerNUM = null;
        }

        private void fullinfo_button_Click(object sender, EventArgs e)
        {
            if (deliveryData.SelectedRows.Count == 1)
            {
                fullData_workers pb = new fullData_workers(Convert.ToInt32(deliveryData.SelectedRows[0].Cells[0].Value));
                pb.ShowDialog();
            }
            else
            {
                MessageBox.Show("Select one item");
            }
        }

        private void workers_button_Paint(object sender, PaintEventArgs e)
        {
            if (temp_info.delivery_workerNUM == null)
                workers_button.Text = "select";
            else
                workers_button.Text = "selected";
        }

        private void goods_button_Paint(object sender, PaintEventArgs e)
        {
            if (temp_info.delivery_goodsNUM == null)
                goods_button.Text = "select";
            else
                goods_button.Text = "selected";
        }

        private void supplier_button_Paint(object sender, PaintEventArgs e)
        {
            if (temp_info.delivery_supplierNUM == null)
                supplier_button.Text = "select";
            else
                supplier_button.Text = "selected";
        }

        private void storage_button_Paint(object sender, PaintEventArgs e)
        {
            if (temp_info.delivery_storageNUM == null)
                storage_button.Text = "select";
            else
                storage_button.Text = "selected";
        }

        private void on_off_button_Click(object sender, EventArgs e)
        {
            on_off_button.Text = on_off_button.Text == "on" ? "off" : "on";
        }

        private void workers_button_Click(object sender, EventArgs e)
        {
            workers_search ws = new workers_search(1);
            ws.ShowDialog();
        }

        private void goods_button_Click(object sender, EventArgs e)
        {
            goods_search gs = new goods_search(1);
            gs.ShowDialog();
        }

        private void supplier_button_Click(object sender, EventArgs e)
        {
            supplier_search ss = new supplier_search(1);
            ss.ShowDialog();
        }

        private void storage_button_Click(object sender, EventArgs e)
        {
            storage_search ss = new storage_search(1);
            ss.ShowDialog();
        }

        private void ok_button_Click(object sender, EventArgs e)
        {
            if (deliveryData.SelectedRows.Count == 1)
            {
                temp_info.delivery_search = new delivery()
                {
                    deliveryNUM = Convert.ToInt32(deliveryData.SelectedRows[0].Cells[0].Value)
                };
                this.Close();
            }
            else
            {
                MessageBox.Show("Select one item");
            }
        }

        private void search_button_Click(object sender, EventArgs e)
        {
            deliveryData.Rows.Clear();
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
                if(count_textBox.Text != "")
                {
                    try
                    {
                        Convert.ToDecimal(count_textBox.Text);
                    }
                    catch 
                    {
                        MessageBox.Show("Count field has incorect data");
                        return;
                    }
                }

                using (DepartmentEntities db = new DepartmentEntities())
                {
                    var data = (from delivery in db.delivery
                               join workers in db.workers on delivery.workersNUM equals workers.workersNUM
                               join person in db.person on workers.personNUM equals person.personNUM
                               join goods in db.goods on delivery.goodsNUM equals goods.goodsNUM
                               join supplier in db.supplier on delivery.supplierNUM equals supplier.supplierNUM
                               join storage in db.storage on delivery.storageNUM equals storage.storageNUM
                               select new
                               {
                                   delivery.deliveryNUM,
                                   workers.workersNUM,
                                   person.personNUM,
                                   goods.goodsNUM,
                                   supplier.supplierNUM,
                                   storage.storageNUM,

                                   person.personNAME,
                                   goods.goodsNAME,
                                   delivery.goodsCOUNT,
                                   supplier.supplierNAME,
                                   storage.storageNAME,
                                   delivery.deliveryDATE
                               }).ToList();

                    if(id_textBox.Text != "")
                    {
                        int id = Convert.ToInt32(id_textBox.Text);
                        if(data != null)
                        {
                            data = data.Where(i => i.deliveryNUM == id).ToList();
                        }
                    }
                    if(count_textBox.Text != "")
                    {
                        decimal count = Convert.ToDecimal(count_textBox.Text);
                        if(data != null)
                        {
                            data = data.Where(i => i.goodsCOUNT.Equals(count)).ToList();
                        }
                    }
                    if(on_off_button.Text == "on")
                    {
                        if(data != null)
                        {
                            data = data.Where(i => i.deliveryDATE.Date.Equals(date.Value.Date)).ToList();
                        }
                    }
                    if(temp_info.delivery_goodsNUM != null)
                    {
                        if(data != null)
                        {
                            data = data.Where(i => i.goodsNUM.Equals(temp_info.delivery_goodsNUM)).ToList();
                        }
                    }
                    if(temp_info.delivery_storageNUM != null)
                    {
                        if(data != null)
                        {
                            data = data.Where(i => i.storageNUM.Equals(temp_info.delivery_storageNUM)).ToList();
                        }
                    }
                    if(temp_info.delivery_supplierNUM != null)
                    {
                        if(data != null)
                        {
                            data = data.Where(i => i.supplierNUM.Equals(temp_info.delivery_supplierNUM)).ToList();
                        }
                    }
                    if(temp_info.delivery_workerNUM != null)
                    {
                        if(data != null)
                        {
                            data = data.Where(i => i.workersNUM.Equals(temp_info.delivery_workerNUM)).ToList();
                        }
                    }

                    if (data.Count() != 0)
                    {
                        int j = 0;
                        foreach (var item in data)
                        {
                            deliveryData.Rows.Add();
                            deliveryData.Rows[j].Cells[0].Value = item.deliveryNUM;
                            deliveryData.Rows[j].Cells[1].Value = item.personNAME;
                            deliveryData.Rows[j].Cells[2].Value = item.goodsNAME;
                            deliveryData.Rows[j].Cells[3].Value = item.goodsCOUNT;
                            deliveryData.Rows[j].Cells[4].Value = item.supplierNAME;
                            deliveryData.Rows[j].Cells[5].Value = item.storageNAME;
                            deliveryData.Rows[j].Cells[6].Value = item.deliveryDATE.Date.ToShortDateString();
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
            if (id_textBox.Text != "" ||
                count_textBox.Text != "" ||
                temp_info.delivery_goodsNUM != null ||
                temp_info.delivery_storageNUM != null ||
                temp_info.delivery_supplierNUM != null ||
                temp_info.delivery_workerNUM != null ||
                on_off_button.Text == "on")
                return true;
            else
                return false;
        }
    }
}

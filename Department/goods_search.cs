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
    public partial class goods_search : Form
    {
        private int id;

        public goods_search()
        {
            InitializeComponent();
            this.id = 0;
        }

        public goods_search(int id)
        {
            InitializeComponent();
            this.id = id;
        }

        private void cancel_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void clear_all_fields()
        {
            id_textBox.Text = "";
            name_textBox.Text = "";
            price_textBox.Text = "";
        }

        private void clear_button_Click(object sender, EventArgs e)
        {
            clear_all_fields();
        }

        private bool is_full_field()
        {
            if (id_textBox.Text != "")
                return true;
            if (name_textBox.Text != "")
                return true;
            if (price_textBox.Text != "")
                return true;
            return false;
        }

        private void search_button_Click(object sender, EventArgs e)
        {
            goodsData.Rows.Clear();
            if (is_full_field())
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

                if(price_textBox.Text != "")
                {
                    try
                    {
                        Convert.ToDecimal(price_textBox.Text);
                    }
                    catch 
                    {
                        MessageBox.Show("Price field has incorect data");
                        return;
                    }
                }

                using (DepartmentEntities db = new DepartmentEntities())
                {
                    List<goods> data = null;
                    if(id_textBox.Text != "")
                    {
                        int id = Convert.ToInt32(id_textBox.Text);
                        if(data != null)
                        {
                            data = data.Where(i => i.goodsNUM == id).ToList();
                        }
                        else
                        {
                            data = db.goods.Where(i => i.goodsNUM == id).ToList();
                        }
                    }

                    if(name_textBox.Text != "")
                    {
                        if(data != null)
                        {
                            data = data.Where(i => i.goodsNAME.StartsWith(name_textBox.Text)).ToList();
                        }
                        else
                        {
                            data = db.goods.Where(i => i.goodsNAME.StartsWith(name_textBox.Text)).ToList();
                        }
                    }

                    if(price_textBox.Text != "")
                    {
                        decimal price = Convert.ToDecimal(price_textBox.Text);
                        if(data != null)
                        {
                            data = data.Where(i => i.goodsPRICE == price).ToList();
                        }
                        else
                        {
                            data = db.goods.Where(i => i.goodsPRICE == price).ToList();
                        }
                    }

                    if (data != null || data.Count != 0)
                    {
                        int j = 0;
                        foreach (var item in data)
                        {
                            goodsData.Rows.Add();
                            goodsData.Rows[j].Cells[0].Value = item.goodsNUM;
                            goodsData.Rows[j].Cells[1].Value = item.goodsNAME;
                            goodsData.Rows[j].Cells[2].Value = item.goodsPRICE;
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

        private void ok_button_Click(object sender, EventArgs e)
        {

            if (goodsData.SelectedRows.Count == 1)
            {
                if (id == 0)
                {
                    temp_info.goods_search = new goods()
                    {
                        goodsNUM = Convert.ToInt32(goodsData.SelectedRows[0].Cells[0].Value),
                        goodsNAME = Convert.ToString(goodsData.SelectedRows[0].Cells[1].Value),
                        goodsPRICE = Convert.ToDecimal(goodsData.SelectedRows[0].Cells[2].Value)
                    };
                }
                else if(id == 1)
                {
                    temp_info.delivery_goodsNUM = Convert.ToInt32(goodsData.SelectedRows[0].Cells[0].Value);
                }
                this.Close();
            }
            else
            {
                MessageBox.Show("Select one item");
            }
        }
    }
}

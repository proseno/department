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
    public partial class select_goods : Form
    {
        private int id = new int();

        public select_goods()
        {
            InitializeComponent();
        }

        public select_goods(int id)
        {
            InitializeComponent();
            this.id = id;
        }

        private void select_goods_Load(object sender, EventArgs e)
        {
            getData();
            foreach (DataGridViewRow row in goodsData.Rows)
            {
                if (Convert.ToInt32(row.Cells[0].Value) == id)
                {
                    goodsData.Rows[row.Index].Selected = true;
                }
            }
        }

        private void getData()
        {
            goodsData.Rows.Clear();
            using (DepartmentEntities db = new DepartmentEntities())
            {
                var data = from goods in db.goods
                           select new
                           {
                               goods.goodsNUM,
                               goods.goodsNAME,
                               goods.goodsPRICE
                           };
                int i = 0;
                foreach (var item in data)
                {
                    goodsData.Rows.Add();
                    goodsData.Rows[i].Cells[0].Value = item.goodsNUM;
                    goodsData.Rows[i].Cells[1].Value = item.goodsNAME;
                    goodsData.Rows[i].Cells[2].Value = item.goodsPRICE;
                    i++;
                }
            }
        }

        private void cancel_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ok_button_Click(object sender, EventArgs e)
        {
            if (goodsData.SelectedRows.Count == 1)
            {
                using (DepartmentEntities db = new DepartmentEntities())
                {
                    int index = Convert.ToInt32(goodsData.SelectedRows[0].Cells[0].Value);
                    goods temp = db.goods.FirstOrDefault(i => i.goodsNUM == index);
                    temp_info.select_goods = temp;
                }
                this.Close();
            }
            else
            {
                MessageBox.Show("Please select 1 item");
            }
        }
    }
}

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
    public partial class fullData_delivery_form : Form
    {
        private int id;

        public fullData_delivery_form(int id)
        {
            InitializeComponent();
            this.id = id;
        }

        private void getData()
        {
            workersData.Rows.Clear();
            goodsData.Rows.Clear();
            supplierData.Rows.Clear();
            storageData.Rows.Clear();
            deliveryData.Rows.Clear();
            using (DepartmentEntities db = new DepartmentEntities())
            {
                var data = from delivery in db.delivery
                           join workers in db.workers on delivery.workersNUM equals workers.workersNUM
                           join person in db.person on workers.personNUM equals person.personNUM
                           join position in db.position on workers.positionNUM equals position.positionNUM
                           join cech in db.cech on workers.cechNUM equals cech.cechNUM
                           join goods in db.goods on delivery.goodsNUM equals goods.goodsNUM
                           join supplier in db.supplier on delivery.supplierNUM equals supplier.supplierNUM
                           join storage in db.storage on delivery.storageNUM equals storage.storageNUM
                           where delivery.deliveryNUM == this.id
                           select new
                           {
                               workers.workersNUM,
                               person.personNAME,
                               person.personPASPORT,
                               person.personIDCode,
                               person.personAddress,
                               person.personBirth,
                               position.positionNAME,
                               position.positionSALARY,
                               cech.cechNAME,
                               workers.workersSTART,
                               workers.workersEND,

                               goods.goodsNUM,
                               goods.goodsNAME,
                               goods.goodsPRICE,

                               supplier.supplierNUM,
                               supplier.supplierNAME,
                               supplier.supplierADDRESS,
                               supplier.supplierContacts,

                               storage.storageNUM,
                               storage.storageNAME,
                               storage.storageADDRESS,

                               delivery.deliveryNUM,
                               delivery.deliveryDATE,
                               delivery.goodsCOUNT
                           };

                int i = 0;
                workersData.Rows.Add();
                workersData.Rows[i].Cells[0].Value = data.First().workersNUM;
                workersData.Rows[i].Cells[1].Value = data.First().personNAME;
                workersData.Rows[i].Cells[2].Value = data.First().personPASPORT;
                workersData.Rows[i].Cells[3].Value = data.First().personIDCode;
                workersData.Rows[i].Cells[4].Value = data.First().personAddress;
                workersData.Rows[i].Cells[5].Value = data.First().personBirth;
                workersData.Rows[i].Cells[6].Value = data.First().positionNAME;
                workersData.Rows[i].Cells[7].Value = data.First().positionSALARY;
                workersData.Rows[i].Cells[8].Value = data.First().cechNAME;
                workersData.Rows[i].Cells[9].Value = data.First().workersSTART.Date.ToShortDateString();
                if (data.First().workersEND == null)
                    workersData.Rows[i].Cells[10].Value = "till now";
                else
                    workersData.Rows[i].Cells[10].Value = Convert.ToDateTime(data.First().workersEND).Date.ToShortDateString();

                goodsData.Rows.Add();
                goodsData.Rows[i].Cells[0].Value = data.First().goodsNUM;
                goodsData.Rows[i].Cells[1].Value = data.First().goodsNAME;
                goodsData.Rows[i].Cells[2].Value = data.First().goodsPRICE;

                supplierData.Rows.Add();
                supplierData.Rows[i].Cells[0].Value = data.First().supplierNUM;
                supplierData.Rows[i].Cells[1].Value = data.First().supplierNAME;
                supplierData.Rows[i].Cells[2].Value = data.First().supplierADDRESS;
                supplierData.Rows[i].Cells[3].Value = data.First().supplierContacts;

                storageData.Rows.Add();
                storageData.Rows[i].Cells[0].Value = data.First().storageNUM;
                storageData.Rows[i].Cells[1].Value = data.First().storageNAME;
                storageData.Rows[i].Cells[2].Value = data.First().storageADDRESS;

                deliveryData.Rows.Add();
                deliveryData.Rows[i].Cells[0].Value = data.First().deliveryNUM;
                deliveryData.Rows[i].Cells[1].Value = data.First().goodsCOUNT;
                deliveryData.Rows[i].Cells[2].Value = data.First().deliveryDATE.Date.ToShortDateString();
            }
        }

        private void fullData_delivery_form_Load(object sender, EventArgs e)
        {
            getData();
        }
    }
}

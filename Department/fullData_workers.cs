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
    public partial class fullData_workers : Form
    {
        private int id;

        public fullData_workers(int i)
        {
            InitializeComponent();
            this.id = i;
        }

        private void fullData_workers_Load(object sender, EventArgs e)
        {
            getData();
        }

        private void getData()
        {
            personData.Rows.Clear();
            positionData.Rows.Clear();
            cechData.Rows.Clear();
            workersData.Rows.Clear();
            using(DepartmentEntities db = new DepartmentEntities())
            {
                var data = from workers in db.workers
                           join person in db.person on workers.personNUM equals person.personNUM
                           join position in db.position on workers.positionNUM equals position.positionNUM
                           join cech in db.cech on workers.cechNUM equals cech.cechNUM
                           where workers.workersNUM == this.id
                           select new
                           {
                               person.personNUM,
                               person.personNAME,
                               person.personPASPORT,
                               person.personIDCode,
                               person.personAddress,
                               person.personBirth,

                               position.positionNUM,
                               position.positionNAME,
                               position.positionSALARY,

                               cech.cechNUM,
                               cech.cechNAME,

                               workers.workersNUM,
                               workers.workersSTART,
                               workers.workersEND
                           };

                int i = 0;
                personData.Rows.Add();
                personData.Rows[i].Cells[0].Value = data.First().personNUM;
                personData.Rows[i].Cells[1].Value = data.First().personNAME;
                personData.Rows[i].Cells[2].Value = data.First().personPASPORT;
                personData.Rows[i].Cells[3].Value = data.First().personIDCode;
                personData.Rows[i].Cells[4].Value = data.First().personAddress;
                personData.Rows[i].Cells[5].Value = data.First().personBirth.Date.ToShortDateString();

                positionData.Rows.Add();
                positionData.Rows[i].Cells[0].Value = data.First().positionNUM;
                positionData.Rows[i].Cells[1].Value = data.First().positionNAME;
                positionData.Rows[i].Cells[2].Value = data.First().positionSALARY;

                cechData.Rows.Add();
                cechData.Rows[i].Cells[0].Value = data.First().cechNUM;
                cechData.Rows[i].Cells[1].Value = data.First().cechNAME;

                workersData.Rows.Add();
                workersData.Rows[i].Cells[0].Value = data.First().workersNUM;
                workersData.Rows[i].Cells[1].Value = data.First().workersSTART.Date.ToShortDateString();
                if (data.First().workersEND != null)
                    workersData.Rows[i].Cells[2].Value = Convert.ToDateTime(data.First().workersEND).ToShortDateString();
                else
                    workersData.Rows[i].Cells[2].Value = "till now";
            }
        }
    }
}

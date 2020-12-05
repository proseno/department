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
    public partial class fullData_person_benefits_form : Form
    {
        private int id;
        public fullData_person_benefits_form(int i)
        {
            id = i;
            InitializeComponent();
        }

        private void fullData_person_benefits_form_Load(object sender, EventArgs e)
        {
            getData();
        }

        private void getData()
        {
            using(DepartmentEntities db = new DepartmentEntities())
            {
                personData.Rows.Clear();
                benefitsData.Rows.Clear();
                person_benefitsData.Rows.Clear();
                var data = from person_benefits in db.person_benefits
                           join person in db.person on person_benefits.personNUM equals person.personNUM
                           join benefits in db.benefits on person_benefits.benefitsNUM equals benefits.benefitsNUM
                           where person_benefits.person_benefitsNUM == id
                           select new
                           {
                               person.personNUM,
                               person.personNAME,
                               person.personPASPORT,
                               person.personIDCode,
                               person.personAddress,
                               person.personBirth,

                               benefits.benefitsNUM,
                               benefits.benefitsNAME,
                               benefits.benefitsDESCRIPTION,
                               benefits.benefitsKIND,

                               person_benefits.person_benefitsNUM,
                               person_benefits.person_benefitsSTART,
                               person_benefits.person_benefitsEND
                           };
                personData.Rows.Add();
                personData.Rows[0].Cells[0].Value = data.First().personNUM;
                personData.Rows[0].Cells[1].Value = data.First().personNAME;
                personData.Rows[0].Cells[2].Value = data.First().personPASPORT;
                personData.Rows[0].Cells[3].Value = data.First().personIDCode;
                personData.Rows[0].Cells[4].Value = data.First().personAddress;
                personData.Rows[0].Cells[5].Value = data.First().personBirth.Date.ToShortDateString();



                benefitsData.Rows.Add();
                benefitsData.Rows[0].Cells[0].Value = data.First().benefitsNUM;
                benefitsData.Rows[0].Cells[1].Value = data.First().benefitsNAME;
                benefitsData.Rows[0].Cells[2].Value = data.First().benefitsDESCRIPTION;
                benefitsData.Rows[0].Cells[3].Value = data.First().benefitsKIND;


                person_benefitsData.Rows.Add();
                person_benefitsData.Rows[0].Cells[0].Value = data.First().person_benefitsNUM;
                person_benefitsData.Rows[0].Cells[1].Value = data.First().person_benefitsSTART.Date.ToShortDateString();
                if (data.First().person_benefitsEND != null)
                {
                    person_benefitsData.Rows[0].Cells[2].Value = ((DateTime)data.First().person_benefitsEND).Date.ToShortDateString();
                }
                else
                {
                    person_benefitsData.Rows[0].Cells[2].Value = "till now";
                }
            }
        }
    }
}

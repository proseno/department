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
    public partial class workers_search : Form
    {
        private int id;

        public workers_search()
        {
            temp_info.workers_cechNUM = null;
            temp_info.workers_personNUM = null;
            temp_info.workers_positionNUM = null;
            this.id = 0;
            InitializeComponent();
        }

        public workers_search(int id)
        {
            temp_info.workers_cechNUM = null;
            temp_info.workers_personNUM = null;
            temp_info.workers_positionNUM = null;
            this.id = id;
            InitializeComponent();
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
            start_date.Value = DateTime.Now;
            end_date.Value = DateTime.Now;
            start_on_off_button.Text = "off";
            end_on_off_button.Text = "off";

            temp_info.workers_cechNUM = null;
            temp_info.workers_personNUM = null;
            temp_info.workers_positionNUM = null;
            person_button.Text = "select";
            position_button.Text = "select";
            cech_button.Text = "select";
        }

        private void start_on_off_button_Click(object sender, EventArgs e)
        {
            start_on_off_button.Text = start_on_off_button.Text == "on" ? "off" : "on";
        }

        private void end_on_off_button_Click(object sender, EventArgs e)
        {
            end_on_off_button.Text = end_on_off_button.Text == "on" ? "off" : "on";
        }

        private void person_button_Click(object sender, EventArgs e)
        {
            person_search ps = new person_search(2);
            ps.ShowDialog();
        }

        private void position_button_Click(object sender, EventArgs e)
        {
            position_search ps = new position_search(1);
            ps.ShowDialog();
        }

        private void cech_button_Click(object sender, EventArgs e)
        {
            cech_search cs = new cech_search(1);
            cs.ShowDialog();
        }

        private void person_button_Paint(object sender, PaintEventArgs e)
        {
            if (temp_info.workers_personNUM == null)
                person_button.Text = "select";
            else
                person_button.Text = "selected";
        }

        private void cech_button_Paint(object sender, PaintEventArgs e)
        {
            if (temp_info.workers_cechNUM == null)
                person_button.Text = "select";
            else
                person_button.Text = "selected";
        }

        private void position_button_Paint(object sender, PaintEventArgs e)
        {
            if (temp_info.workers_positionNUM == null)
                person_button.Text = "select";
            else
                person_button.Text = "selected";
        }

        private void search_button_Click(object sender, EventArgs e)
        {
            workersData.Rows.Clear();
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

                using (DepartmentEntities db = new DepartmentEntities())
                {
                    var data = (from workers in db.workers
                               join person in db.person on workers.personNUM equals person.personNUM
                               join position in db.position on workers.positionNUM equals position.positionNUM
                               join cech in db.cech on workers.cechNUM equals cech.cechNUM
                               select new
                               {
                                   workers.workersNUM,
                                   person.personNUM,
                                   position.positionNUM,
                                   cech.cechNUM,

                                   workers.workersSTART,
                                   workers.workersEND,

                                   person.personNAME,
                                   position.positionNAME,
                                   cech.cechNAME
                               }).ToList();

                    if(id_textBox.Text != "")
                    {
                        int id = Convert.ToInt32(id_textBox.Text);
                        if(data != null)
                        {
                            data = data.Where(i => i.workersNUM == id).ToList();
                        }
                    }
                    if(temp_info.workers_personNUM != null)
                    {
                        if(data != null)
                        {
                            data = data.Where(i => i.personNUM == temp_info.workers_personNUM).ToList();
                        }
                    }
                    if(temp_info.workers_positionNUM != null)
                    {
                        if(data != null)
                        {
                            data = data.Where(i => i.positionNUM == temp_info.workers_positionNUM).ToList();
                        }
                    }
                    if(temp_info.workers_cechNUM != null)
                    {
                        if(data != null)
                        {
                            data = data.Where(i => i.cechNUM == temp_info.workers_cechNUM).ToList();
                        }
                    }
                    if(start_on_off_button.Text == "on")
                    {
                        if(data != null)
                        {
                            data = data.Where(i => i.workersSTART.Equals(start_date.Value)).ToList();
                        }
                    }
                    if(end_on_off_button.Text == "on")
                    {
                        if(data != null)
                        {
                            data = data.Where(i => i.workersEND.Equals(end_date.Value)).ToList();
                        }
                    }

                    if (data.Count() != 0)
                    {
                        int j = 0;
                        foreach (var item in data)
                        {
                            workersData.Rows.Add();
                            workersData.Rows[j].Cells[0].Value = item.workersNUM;
                            workersData.Rows[j].Cells[1].Value = item.personNAME;
                            workersData.Rows[j].Cells[2].Value = item.positionNAME;
                            workersData.Rows[j].Cells[3].Value = item.cechNAME;
                            workersData.Rows[j].Cells[4].Value = item.workersSTART.Date.ToShortDateString();
                            if (item.workersEND != null)
                                workersData.Rows[j].Cells[5].Value = item.workersEND;
                            else
                                workersData.Rows[j].Cells[5].Value = "till now";
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
                start_on_off_button.Text == "on" ||
                end_on_off_button.Text == "on" ||
                temp_info.workers_personNUM != null ||
                temp_info.workers_positionNUM != null ||
                temp_info.workers_cechNUM != null)
                return true;
            else
                return false;
        }

        private void fullinfo_button_Click(object sender, EventArgs e)
        {
            if (workersData.SelectedRows.Count == 1)
            {
                fullData_workers pb = new fullData_workers(Convert.ToInt32(workersData.SelectedRows[0].Cells[0].Value));
                pb.ShowDialog();
            }
            else
            {
                MessageBox.Show("Select one item");
            }
        }

        private void ok_button_Click(object sender, EventArgs e)
        {
            if (workersData.SelectedRows.Count == 1)
            {
                if (id == 0)
                {
                    if (workersData.SelectedRows[0].Cells[5].Value.ToString() != "till now")
                    {
                        using (DepartmentEntities db = new DepartmentEntities())
                        {


                            temp_info.workers_search = new workers()
                            {
                                workersNUM = Convert.ToInt32(workersData.SelectedRows[0].Cells[0].Value)
                            };
                        }
                    }
                    else
                    {
                        using (DepartmentEntities db = new DepartmentEntities())
                        {
                            temp_info.workers_search = new workers()
                            {
                                workersNUM = Convert.ToInt32(workersData.SelectedRows[0].Cells[0].Value)
                            };
                        }
                    }
                }
                else if(id == 1)
                {
                    temp_info.delivery_workerNUM = Convert.ToInt32(workersData.SelectedRows[0].Cells[0].Value);
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

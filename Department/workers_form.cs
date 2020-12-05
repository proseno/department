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
    public partial class workers_form : Form
    {
        private bool tillnow = false;

        private enum Status
        {
            add = 1,
            edit = 2
        }

        private Status status = new Status();

        public workers_form()
        {
            InitializeComponent();
        }

        private void workers_form_Load(object sender, EventArgs e)
        {
            getData();
        }

        private void getData()
        {
            workersData.Rows.Clear();
            using (DepartmentEntities db = new DepartmentEntities())
            {
                var data = from workers in db.workers
                           join person in db.person on workers.personNUM equals person.personNUM
                           join position in db.position on workers.positionNUM equals position.positionNUM
                           join cech in db.cech on workers.cechNUM equals cech.cechNUM
                           select new
                           {
                               workers.workersNUM,
                               person.personNAME,
                               position.positionNAME,
                               cech.cechNAME,
                               workers.workersSTART,
                               workers.workersEND
                           };
                int i = 0;
                foreach (var item in data)
                {
                    workersData.Rows.Add();
                    workersData.Rows[i].Cells[0].Value = item.workersNUM;
                    workersData.Rows[i].Cells[1].Value = item.personNAME;
                    workersData.Rows[i].Cells[2].Value = item.positionNAME;
                    workersData.Rows[i].Cells[3].Value = item.cechNAME;
                    workersData.Rows[i].Cells[4].Value = item.workersSTART.Date.ToShortDateString();
                    if (item.workersEND == null)
                        workersData.Rows[i].Cells[5].Value = "till now";
                    else
                        workersData.Rows[i].Cells[5].Value = Convert.ToDateTime(item.workersEND).Date.ToShortDateString();
                    i++;
                }
            }
        }

        private void fullInfo_button_Click(object sender, EventArgs e)
        {
            if(workersData.SelectedRows.Count == 1)
            {
                fullData_workers fdw = new fullData_workers(Convert.ToInt32(workersData.SelectedRows[0].Cells[0].Value));
                fdw.ShowDialog();
            }
            else
            {
                MessageBox.Show("Please, select 1 item");
            }
        }

        private void delete_button_Click(object sender, EventArgs e)
        {
            clear_all_fields();
            control_groupBox.Visible = false;
            if (workersData.SelectedRows.Count > 0)
            {
                using (DepartmentEntities db = new DepartmentEntities())
                {
                    bool oldValidateOnSaveEnabled = db.Configuration.ValidateOnSaveEnabled;

                    foreach (DataGridViewRow index in workersData.SelectedRows)
                    {
                        try
                        {
                            db.Configuration.ValidateOnSaveEnabled = false;
                            workers temp = new workers()
                            {
                                workersNUM = Convert.ToInt32(index.Cells[0].Value)
                            };
                            db.workers.Attach(temp);
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

        private void clear_all_fields()
        {
            start_date.Value = DateTime.Now;
            end_date.Value = DateTime.Now;

            temp_info.select_person_workers = null;
            temp_info.select_position_workers = null;
            temp_info.select_cech_workers = null;

            person_button.Text = "select";
            position_button.Text = "select";
            cech_button.Text = "select";

            tillnow = false;
        }

        private void tillnow_button_Click(object sender, EventArgs e)
        {
            tillnow = tillnow ? false : true;
        }

        private void tillnow_button_Paint(object sender, PaintEventArgs e)
        {
            tillnow_button.ForeColor = tillnow ? Color.Green : Color.Red;
        }

        private void add_button_Click(object sender, EventArgs e)
        {
            clear_all_fields();
            control_groupBox.Visible = true;
            control_groupBox.Text = "add item";
            status = Status.add;
            end_date.Visible = false;
            end_label.Visible = false;
            or_label.Visible = false;
            tillnow_button.Visible = false;
        }

        private void clear_button_Click(object sender, EventArgs e)
        {
            clear_all_fields();
        }

        private void person_button_Click(object sender, EventArgs e)
        {
            if (temp_info.select_person_workers != null)
            {
                person_button.Text = "selected";
                select_person_form spf = new select_person_form(temp_info.select_person_workers.personNUM, "workers");
                spf.ShowDialog();
            }
            else if (temp_info.select_person_workers == null)
            {
                person_button.Text = "select";
                select_person_form spf = new select_person_form("workers");
                spf.ShowDialog();
                if (temp_info.select_person_workers != null)
                {
                    person_button.Text = "selected";
                }
            }
        }

        private void position_button_Click(object sender, EventArgs e)
        {
            if (temp_info.select_position_workers != null)
            {
                position_button.Text = "selected";
                select_position_form spf = new select_position_form(temp_info.select_position_workers.positionNUM);
                spf.ShowDialog();
            }
            else if (temp_info.select_position_workers == null)
            {
                position_button.Text = "select";
                select_position_form spf = new select_position_form();
                spf.ShowDialog();
                if (temp_info.select_position_workers != null)
                {
                    position_button.Text = "selected";
                }
            }
        }

        private void cech_button_Click(object sender, EventArgs e)
        {
            if (temp_info.select_cech_workers != null)
            {
                cech_button.Text = "selected";
                select_cech_form spf = new select_cech_form(temp_info.select_cech_workers.cechNUM);
                spf.ShowDialog();
            }
            else if (temp_info.select_cech_workers == null)
            {
                cech_button.Text = "select";
                select_cech_form spf = new select_cech_form();
                spf.ShowDialog();
                if (temp_info.select_cech_workers != null)
                {
                    cech_button.Text = "selected";
                }
            }
        }

        private void edit_button_Click(object sender, EventArgs e)
        {
            clear_all_fields();
            if (workersData.SelectedRows.Count != 1)
            {
                MessageBox.Show("Select one item, please");
            }
            else
            {
                tillnow_button.Visible = true;
                or_label.Visible = true;
                control_groupBox.Visible = true;
                control_groupBox.Text = "edit item";
                status = Status.edit;

                DataGridViewRow row = workersData.SelectedRows[0];
                int index = Convert.ToInt32(row.Cells[0].Value);
                using (DepartmentEntities db = new DepartmentEntities())
                {
                    var ids = db.workers.FirstOrDefault(i => i.workersNUM == index);

                    person pers = db.person.FirstOrDefault(i => i.personNUM == ids.personNUM);

                    position poss = db.position.FirstOrDefault(i => i.positionNUM == ids.positionNUM);

                    cech cechs = db.cech.FirstOrDefault(i => i.cechNUM == ids.cechNUM);

                    temp_info.select_person_workers = pers;
                    temp_info.select_position_workers = poss;
                    temp_info.select_cech_workers = cechs;
                }



                person_button.Text = "selected";
                position_button.Text = "selected";
                cech_button.Text = "selected";

                start_date.Value = Convert.ToDateTime(row.Cells[4].Value);
                end_date.Visible = true;
                end_label.Visible = true;
                if (row.Cells[5].Value == null)
                    end_date.Value = Convert.ToDateTime(row.Cells[5].Value).Date;
                else
                    end_date.Value = DateTime.Now;

            }
        }

        private void save_button_Click(object sender, EventArgs e)
        {
            error_label.Visible = false;
            if (are_fileds_full())
            {
                switch (status)
                {
                    case Status.add:
                        using (DepartmentEntities db = new DepartmentEntities())
                        {
                            db.workers.Add(new workers()
                            {
                                personNUM = Convert.ToInt32(temp_info.select_person_workers.personNUM),
                                positionNUM = Convert.ToInt32(temp_info.select_position_workers.positionNUM),
                                cechNUM = Convert.ToInt32(temp_info.select_cech_workers.cechNUM),
                                workersSTART = Convert.ToDateTime(start_date.Value),
                                workersEND = null
                            });
                            db.SaveChanges();
                        }
                        break;

                    case Status.edit:
                        using (DepartmentEntities db = new DepartmentEntities())
                        {
                            if (tillnow)
                            {
                                workers temp = new workers()
                                {
                                    workersNUM = Convert.ToInt32(workersData.SelectedRows[0].Cells[0].Value),
                                    personNUM = Convert.ToInt32(temp_info.select_person_workers.personNUM),
                                    positionNUM = Convert.ToInt32(temp_info.select_position_workers.positionNUM),
                                    cechNUM = Convert.ToInt32(temp_info.select_cech_workers.cechNUM),
                                    workersSTART = Convert.ToDateTime(start_date.Value),
                                    workersEND = null
                                };
                                db.Entry(temp).State = System.Data.Entity.EntityState.Modified;
                            }
                            else
                            {
                                workers temp = new workers()
                                {
                                    workersNUM = Convert.ToInt32(workersData.SelectedRows[0].Cells[0].Value),
                                    personNUM = Convert.ToInt32(temp_info.select_person_workers.personNUM),
                                    positionNUM = Convert.ToInt32(temp_info.select_position_workers.positionNUM),
                                    cechNUM = Convert.ToInt32(temp_info.select_cech_workers.cechNUM),
                                    workersSTART = Convert.ToDateTime(start_date.Value),
                                    workersEND = Convert.ToDateTime(end_date.Value)
                                };
                                db.Entry(temp).State = System.Data.Entity.EntityState.Modified;
                            }

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

        private bool are_fileds_full()
        {
            if (temp_info.select_person_workers == null)
                return false;
            if (temp_info.select_position_workers == null)
                return false;
            if (temp_info.select_cech_workers == null)
                return false;
            return true;
        }

        private void hide_button_Click(object sender, EventArgs e)
        {
            clear_all_fields();
            control_groupBox.Visible = false;
            status = new Status();
        }

        private void search_button_Click(object sender, EventArgs e)
        {
            temp_info.workers_search = null;
            workers_search ps = new workers_search();
            ps.ShowDialog();
            if (temp_info.workers_search != null)
            {
                workersData.ClearSelection();
                foreach (DataGridViewRow row in workersData.Rows)
                {
                    if (Convert.ToInt32(row.Cells[0].Value) == temp_info.workers_search.workersNUM)
                    {
                        workersData.Rows[row.Index].Selected = true;
                    }
                }
            }
        }
    }
}

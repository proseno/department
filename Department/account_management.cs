using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Department
{
    public partial class account_management : Form
    {
        private class authenticationInfo
        {
            public string Password { get; set; }
            public string Login { get; set; }
            public string Status { get; set; }
        }

        public account_management()
        {
            InitializeComponent();
        }

        private void submit_Click(object sender, EventArgs e)
        {
            if (are_fields_full())
            {
                string status;
                if (!isAdmin_checkBox.Checked)
                {
                    string tab = "tab";
                    string rep = "rep";
                    if (tables_checkList.CheckedItems.Count != 0)
                    {
                        foreach (var item in tables_checkList.CheckedItems)
                        {
                            tab += ':' + item.ToString();
                        }
                    }
                    if (reports_checkList.CheckedItems.Count != 0)
                    {
                        foreach (var item in reports_checkList.CheckedItems)
                        {
                            rep += ':' + item.ToString();
                        }
                    }

                    status = tab + '|' + rep;
                }else
                {
                    status = "1";
                }

                if (writeNewUser(status))
                {
                    clear_all_fields();
                }
                else
                {
                    return;
                }
            }
            else
            {
                MessageBox.Show("Error! Some fields are empty!");
            }
        }

        private bool writeNewUser(string status)
        {
            authenticationInfo info = new authenticationInfo()
            {
                Login = login_textBox.Text,
                Password = MD5Hash(password_textBox.Text),
                Status = status
            };
            List<authenticationInfo> list = new List<authenticationInfo>();
            using (StreamReader fileread = File.OpenText(@"info.json"))
            {
                JsonSerializer jsonSerializer = new JsonSerializer();
                list = jsonSerializer.Deserialize<List<authenticationInfo>>(new JsonTextReader(fileread));
                if(list == null)
                {
                    list = new List<authenticationInfo>();
                }
            }


            if (list.Count != 0)
            {
                foreach (var item in list)
                {
                    if (item.Login == info.Login)
                    {
                        MessageBox.Show("User with these login already exists");
                        return false;
                    }
                }
            }
            

            using (StreamWriter file = File.CreateText(@"info.json"))
            {
                JsonSerializer jsonSerializer = new JsonSerializer();
                list.Add(info);
                jsonSerializer.Serialize(file, list);
            }
            return true;
        }

        private static string MD5Hash(string info)
        {
            using (MD5 md5 = MD5.Create())
            {
                byte[] hash = md5.ComputeHash(Encoding.UTF8.GetBytes(info));
                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < hash.Length; i++)
                {
                    sb.Append(hash[i].ToString("X2"));
                }
                return sb.ToString();
            }
        }

        private bool are_fields_full()
        {
            if (login_textBox.Text == "")
                return false;
            if (password_textBox.Text == "")
                return false;
            return true;
        }

        private void clear_all_fields()
        {
            login_textBox.Text = "";
            password_textBox.Text = "";
            isAdmin_checkBox.Checked = false;
            for (int i = 0; i < tables_checkList.Items.Count; i++)
                tables_checkList.SetItemChecked(i, false);
            for (int i = 0; i < reports_checkList.Items.Count; i++)
                reports_checkList.SetItemChecked(i, false);
        }

        private void isAdmin_checkBox_CheckedChanged(object sender, EventArgs e)
        {
            if (isAdmin_checkBox.Checked)
            {
                for (int i = 0; i < tables_checkList.Items.Count; i++)
                    tables_checkList.SetItemChecked(i, true);
                for (int i = 0; i < reports_checkList.Items.Count; i++)
                    reports_checkList.SetItemChecked(i, true);

                tables_checkList.Enabled = false;
                reports_checkList.Enabled = false;
            }
            else
            {
                for (int i = 0; i < tables_checkList.Items.Count; i++)
                    tables_checkList.SetItemChecked(i, false);
                for (int i = 0; i < reports_checkList.Items.Count; i++)
                    reports_checkList.SetItemChecked(i, false);

                tables_checkList.Enabled = true;
                reports_checkList.Enabled = true;
            }
        }
    }
}

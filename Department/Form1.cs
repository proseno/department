using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.Runtime.Remoting.Messaging;

namespace Department
{
    public partial class Form1 : Form
    {
        private string status = null;
        private string login = null;
        private class authenticationInfo
        {
            public string Password { get; set; }
            public string Login { get; set; }
            public string Status { get; set; }
        }
        private static bool visible_button_switch = true;

        public Form1()
        {
            InitializeComponent();
        }

        private void visible_button_Paint(object sender, PaintEventArgs e)
        {
            visible_button.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void visible_button_Click(object sender, EventArgs e)
        {
            if (visible_button_switch == true) 
            {
                visible_button_switch = false;
                password_textBox.UseSystemPasswordChar = false;
                this.ActiveControl = password_textBox;
                visible_button.BackgroundImage = Image.FromFile("..//img//eye.png");
            }
            else if (visible_button_switch == false)
            {
                visible_button_switch = true;
                password_textBox.UseSystemPasswordChar = true;
                this.ActiveControl = password_textBox;
                
                visible_button.BackgroundImage = Image.FromFile("..//img//eye_nosee.png");
            }
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.ActiveControl = login_textBox;
            password_textBox.UseSystemPasswordChar = true;
            
        }

        private void login_textBox_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                e.Handled = e.SuppressKeyPress = true;
                this.ActiveControl = password_textBox;
            }
        }

        private void password_textBox_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                e.Handled = e.SuppressKeyPress = true;
                connect_button_Click(sender, e);
                
            }
        }

        private void connect_button_Click(object sender, EventArgs e)
        {
            if(checkAuthentication(login_textBox.Text, password_textBox.Text))
            {
                error_img.Visible = false;
                error_label.Visible = false;

                if (status != null || login != null)
                {
                    this.Hide();
                    using (admin admin = new admin(status, login))
                    {
                        admin.ShowDialog();
                    }
                    this.Show();
                }
                else
                {
                    MessageBox.Show("Error! Incorrect account data");
                }
                login_textBox.Text = "";
                password_textBox.Text = "";
                this.ActiveControl = login_textBox;
            }
            else
            {
                error_img.Visible = true;
                error_label.Visible = true;
                login_textBox.Text = "";
                password_textBox.Text = "";
                this.ActiveControl = login_textBox;
            }
        }

        private bool checkAuthentication(string login, string password)
        {
            dynamic items;
            using (StreamWriter w = File.AppendText("info.json")) { }
            using (StreamReader read = new StreamReader("info.json"))
            {
                string json = read.ReadToEnd();
                var items_from_string = JsonConvert.DeserializeObject<List<authenticationInfo>>(json);
                items = items_from_string;
            }
            
            if (items == null)
            {
                throw new Exception("Error. File has null items");
            }

            if (items.Count == 0)
            {
                throw new Exception("Error. File has " + items.Count + " items");
            }


            foreach (authenticationInfo item in items)
            {
                if(login == item.Login && MD5Hash(password) == item.Password)
                {
                    this.status = item.Status;
                    this.login = item.Login;
                    return true;
                }

            }

            return false;
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
    }
}

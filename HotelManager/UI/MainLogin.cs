using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using HotelManagerModels;
using HotelManagerBLL;
using HotelManagerCommon;
using System.IO;
namespace HotelManager
{
    public partial class MainLogin : Form
    {
        UserManager uManager = new UserManager();
        public MainLogin()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 窗体加载
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainLogin_Load(object sender, EventArgs e)
        {
            PictureOperation.SetPicture(pictureBox1,"pic/logo.jpg");
            PictureOperation.SetPicture(pictureBox2, "pic/ice.png");
            
            User user = uManager.LoginInitial();
            if (user == null)
            {
                chkSavePassword.Checked = false;
            }
            else
            {
                chkSavePassword.Checked = true;
                textBox1.Text = user.UserName;
                textBox2.Text = user.UserPass;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (chkSavePassword.Checked == false)
            {
                File.Delete("HotelManagerInfo.dll");
            }
            MainForm Main = new MainForm();
            Main.Show();
            this.Hide();
            if (chkSavePassword.Checked == true)
            {
                User user = new User();
                user.UserName = textBox1.Text;
                user.UserPass = textBox2.Text;
                user.State = true;
                uManager.LoginInfo(user.State, user);
            }
        }
        bool pcBool = false;
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            pcBool = !pcBool;
            if (pcBool == true)
            {
                textBox2.PasswordChar = new char();
            }
            else
            {
                textBox2.PasswordChar = '*';
            }
        }

        private void chkSavePassword_CheckedChanged(object sender, EventArgs e)
        {
            MessageBox.Show("请注意用户名和密码会保存在当前计算机中！");
            if (chkSavePassword.Checked == true)
            {
                string username = textBox1.Text.Trim();
                string password = textBox2.Text.Trim();
                User user = new User();
                user.UserName = username;
                user.UserPass = password;
                user.State = true;
                uManager.LoginInfo(user.State, user);
            }
        }
    }
}

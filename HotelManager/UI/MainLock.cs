using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using HotelManagerCommon;
namespace HotelManager
{
    public partial class MainLock : Form
    {
        private MainForm main;
        public MainLock(MainForm mainForm)
        {
            InitializeComponent();
            main = mainForm;
        }

        private void MainLock_Load(object sender, EventArgs e)
        {
            PictureOperation.SetPicture(pictureBox1, "pic/logo.jpg");
            PictureOperation.SetPicture(pictureBox2, "pic/ice.png");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            main.Activate();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
            this.notifyIcon1.Visible = true;
        }
    }
}

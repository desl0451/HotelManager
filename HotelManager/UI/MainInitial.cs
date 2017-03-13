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
    public partial class MainInitial : Form
    {
        public MainInitial()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Value = progressBar1.Value + 1;
            if (progressBar1.Value == 100)
            {
                timer1.Stop();
                MainLogin login = new MainLogin();
                login.Show();
                this.Hide();
            }
        }

        private void MainInitial_Load(object sender, EventArgs e)
        {
            PictureOperation.SetPicture(pictureBox1, "pic/3.jpg");
            progressBar1.Value = 1;
           
        }
    }
}

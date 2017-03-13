using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

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
            MainLogin login = new MainLogin();
            login.Show();
            this.Hide();
            timer1.Stop();
        }

        private void MainInitial_Load(object sender, EventArgs e)
        {
            this.BackgroundImage = Image.FromFile("pic/3.jpg");
        }
    }
}

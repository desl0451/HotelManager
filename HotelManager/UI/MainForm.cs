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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 房间类型管理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void tsmRoomTypeManage_Click(object sender, EventArgs e)
        {
            RoomTypeSettingForm RoomType = new RoomTypeSettingForm();
            RoomType.MdiParent = this;
            RoomType.Show();
        }
        /// <summary>
        /// 房间信息管理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsmRoomManage_Click(object sender, EventArgs e)
        {
            RoomForm Room = new RoomForm();
            Room.MdiParent = this;
            Room.Show();
        }
        /// <summary>
        /// 入住登记
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsmGuestRecord_Click(object sender, EventArgs e)
        {
            GuestInfoForm GuestInfo = new GuestInfoForm();
            GuestInfo.MdiParent = this;
            GuestInfo.Show();
        }
        /// <summary>
        /// 房间信息查看
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsmRoomStateQuery_Click(object sender, EventArgs e)
        {
            RoomInfoForm RoomInfo = new RoomInfoForm();
            RoomInfo.MdiParent = this;
            RoomInfo.Show();
        }
        /// <summary>
        /// 顾客信息查询
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsmRecordInfo_Click(object sender, EventArgs e)
        {
            RecordInfoForm RecordInfo = new RecordInfoForm();
            RecordInfo.MdiParent = this;
            RecordInfo.Show();
        }
        /// <summary>
        /// 窗体加载壁纸
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainForm_Load(object sender, EventArgs e)
        {
            this.BackgroundImage = Image.FromFile("pic/1.jpg");
            tsslTime.Text = "          " + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")+"           ";
            tsbQieHuanYongHu.Image = Image.FromFile("pic/tools/tool1.png");
        }

        private void tBiao_Tick(object sender, EventArgs e)
        {
            tsslTime.Text = "          " + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "           ";
        }
        /// <summary>
        /// 窗体关闭时提示对话框
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("您是否想退出本系统?", "操作提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Dispose();
            }
            else
            {
                e.Cancel = true;
                this.WindowState = FormWindowState.Maximized;
                this.Visible = true;
                this.notifyIcon1.Visible = true;
            }
        }
        /// <summary>
        /// 退出程序
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsmiTuiChu_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("您是否想退出本系统?", "操作提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void tsbSuoDingXiTong_Click(object sender, EventArgs e)
        {
            this.Hide();

        }
    }
}

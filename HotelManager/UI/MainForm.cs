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
            tsslTime.Text = DateTime.Now.ToLocalTime().ToString();
            tsbQieHuanYongHu.Image=PictureOperation.MaskPic("pic/tools.png",new Point[]{new Point(100,100)});
        }

        private void tBiao_Tick(object sender, EventArgs e)
        {
            tsslTime.Text = DateTime.Now.ToLocalTime().ToString();
        }
    }
}

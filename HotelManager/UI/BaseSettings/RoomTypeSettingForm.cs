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
namespace HotelManager
{
    public partial class RoomTypeSettingForm : Form
    {
        RoomTypeManager roomTypeManager = new RoomTypeManager();
        public RoomTypeSettingForm()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 窗体加载DataGridView控件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RoomTypeSettingForm_Load(object sender, EventArgs e)
        {
            dgvRoomType.DataSource = roomTypeManager.GetRoomTypeALLEx();
        }
        /// <summary>
        /// 显示下面信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvRoomType_MouseClick(object sender, MouseEventArgs e)
        {
            txtRoomType.Text = dgvRoomType.SelectedRows[0].Cells["ColTypeName"].Value.ToString();
            txtTypePrice.Text =dgvRoomType.SelectedRows[0].Cells["ColTypePrice"].Value.ToString();
        }
        /// <summary>
        /// 退出
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsmiExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /// <summary>
        /// 取消清空文本框内容
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsmiCancel_Click(object sender, EventArgs e)
        {
            txtRoomType.Text = "";
            txtTypePrice.Text = "";
        }
        /// <summary>
        /// 查询
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnFind_Click(object sender, EventArgs e)
        {
            string strTypeName = txtTypeName.Text.Trim();
            dgvRoomType.DataSource = roomTypeManager.GetByRoomTypeEx(strTypeName);
        }

       
    }
}

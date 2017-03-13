﻿using System;
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
    public partial class RoomForm : Form
    {
        RoomManager roomManager = new RoomManager();
        RoomTypeManager roomTypeManager = new RoomTypeManager();
        public RoomForm()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 查询房间信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RoomForm_Load(object sender, EventArgs e)
        {
            dgvRoomInfo.DataSource = roomManager.GetALLRoomEx();
            cmbRoomType.DataSource = roomTypeManager.GetRoomFormRoomTypeEx();
            cmbRoomType.DisplayMember = "TypeName";
            cmbRoomType.ValueMember = "TypeId";
        }
    }
}

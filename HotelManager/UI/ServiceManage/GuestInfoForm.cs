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
    public partial class GuestInfoForm : Form
    {
        RoomManager roomManager = new RoomManager();
        public GuestInfoForm()
        {
            InitializeComponent();
        }

        private void GuestInfoForm_Load(object sender, EventArgs e)
        {
            cmbRoomList.DataSource = roomManager.GetRoomByIDEx();
            cmbRoomList.DisplayMember = "RoomId";
            cmbRoomList.ValueMember = "RoomId";
        }
    }
}

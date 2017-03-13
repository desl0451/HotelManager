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
    public partial class RecordInfoForm : Form
    {
        private GuestRecordManager Grm = new GuestRecordManager();
        public RecordInfoForm()
        {
            InitializeComponent();
        }

        private void RecordInfoForm_Load(object sender, EventArgs e)
        {
            dgvRecordInfo.DataSource = Grm.GetALLGuestRecordEx();
        }
        /// <summary>
        /// 查询
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnQuery_Click(object sender, EventArgs e)
        {
            string strBeginTime = dtpBeginTime.Value.ToShortDateString();
            string strEndTime = dtpEndTime.Value.ToShortDateString();
            string strResideState = cmbResideState.Text;
            if (strResideState.Equals(""))
            {

            }
            else
            {

            }
        }
    }
}

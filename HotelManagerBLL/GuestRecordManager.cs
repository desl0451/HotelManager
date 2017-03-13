using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HotelManagerModels;
using HotelManagerDAL;
using System.Windows.Forms;
namespace HotelManagerBLL
{
    /// <summary>
    /// 
    /// </summary>
    public class GuestRecordManager
    {
        GuestRecordService grs = new GuestRecordService();
        public List<GuestRecord> GetALLGuestRecordEx()
        {
            try
            {
                return grs.GetRoomTypeALL();
            }
            catch (Exception)
            {
                MessageBox.Show("异常!");
                return null;
            }
        }
    }
}

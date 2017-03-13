using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HotelManagerDAL;
using HotelManagerModels;
using System.Windows.Forms;
namespace HotelManagerBLL
{
    public class RoomManager
    {
        /// <summary>
        /// 返回全部房间信息
        /// </summary>
        /// <returns></returns>
        public List<Room> GetALLRoomEx()
        {
            RoomService room = new RoomService();
            try
            {
                return room.GetRoomTypeALL();
            }
            catch (Exception)
            {
                MessageBox.Show("业务逻辑层房间查询全部异常");
                return null;
            }
        }
        /// <summary>
        /// 返回房间编号
        /// </summary>
        /// <returns></returns>
        public List<Room> GetRoomByIDEx()
        {
            RoomService room = new RoomService();
            try
            {
                return room.GetRoomById();
            }
            catch (Exception)
            {
                MessageBox.Show("业务逻辑层房间编号异常");
                return null;
            }
        }
    }
}

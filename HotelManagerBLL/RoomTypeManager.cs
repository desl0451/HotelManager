using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HotelManagerModels;
using HotelManagerDAL;
using System.Windows.Forms;
namespace HotelManagerBLL
{
    public class RoomTypeManager
    {
        #region 返回全部房间类型
        /// <summary>
        /// 返回全部房间类型
        /// </summary>
        /// <returns></returns>
        public List<RoomType> GetRoomTypeALLEx()
        {
            RoomTypeService rts = new RoomTypeService();
            try
            {
                return rts.GetRoomTypeALL();
            }
            catch (Exception)
            {
                MessageBox.Show("业务逻辑层查询全部异常!");
                return null;
            }
        }
        #endregion

        #region 1.BaseSettings->RoomForm->查询全部房间类型
        public List<RoomType> GetRoomFormRoomTypeEx()
        {
            RoomTypeService rts = new RoomTypeService();
            try
            {
                return rts.GetRoomTypeALL();
            }
            catch (Exception)
            {
                MessageBox.Show("业务逻辑层查询全部异常!");
                return null;
            }
        }
        #endregion

        #region 1.BaseSettings->RoomTypeSettingForm->GetByRoomType根据房间类型查询
        public List<RoomType> GetByRoomTypeEx(string RoomTypeName)
        {
            RoomTypeService rts = new RoomTypeService();
            try
            {
                return rts.GetByRoomType(RoomTypeName);
            }
            catch (Exception)
            {
                MessageBox.Show("业务逻辑层根据房间类型查询异常!");
                return null;
            }
        }
        #endregion
    }
}

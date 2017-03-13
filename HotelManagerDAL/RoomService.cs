using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HotelManagerModels;
using System.Data.SqlClient;
using System.Windows.Forms;
namespace HotelManagerDAL
{
    public class RoomService
    {

        public List<Room> GetRoomTypeALL()
        {
            List<Room> rList = new List<Room>();
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("select a.RoomID,b.TypeName,a.BedNum,a.Description,a.GuestNum,");
            sb.AppendLine("c.RoomStateName,c.RoomStateID,b.TypeID");
            sb.AppendLine("from Room as a inner join RoomType b on a.RoomTypeID=b.TypeID");
            sb.AppendLine("inner join RoomState c on a.RoomStateID=c.RoomStateID");
            try
            {
                DBHelper.connection.Open();
                SqlCommand cmd = new SqlCommand(sb.ToString(), DBHelper.connection);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Room room= new Room();
                    room.RoomId = Convert.ToInt32(dr["RoomId"].ToString());
                    room.BedNum = Convert.ToInt32(dr["BedNum"].ToString());
                    room.Description = dr["Description"].ToString();
                    room.GuestNum = Convert.ToInt32(dr["GuestNum"].ToString());
                    room.RoomStateId = Convert.ToInt32(dr["RoomStateId"].ToString());
                    room.RoomTypeId = Convert.ToInt32(dr["TypeID"].ToString());
                    room.RoomTypeName = dr["TypeName"].ToString();
                    room.RoomStateName=dr["RoomStateName"].ToString();
                    rList.Add(room);
                }
                dr.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("加载房间类型异常!");
            }
            finally
            {
                DBHelper.connection.Close();
            }

            return rList;
        }

        /// <summary>
        /// 获取房间编号
        /// </summary>
        /// <returns></returns>
        public List<Room> GetRoomById()
        {
            List<Room> rList = new List<Room>();
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("select * from Room where RoomStateId=2");
            try
            {
                DBHelper.connection.Open();
                SqlCommand cmd = new SqlCommand(sb.ToString(), DBHelper.connection);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Room room = new Room();
                    room.RoomId = Convert.ToInt32(dr["RoomId"].ToString());
                    rList.Add(room);
                }
                dr.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("加载房间类型异常!");
            }
            finally
            {
                DBHelper.connection.Close();
            }
            return rList;
        }

        #region BaseSettings->RoomForm->条件查询

        #endregion
    }
}

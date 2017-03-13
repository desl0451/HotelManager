using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using HotelManagerModels;
using System.Windows.Forms;
namespace HotelManagerDAL
{
    public class RoomTypeService
    {
        #region 1.查询全部房间类型
        /// <summary>
        /// 查询全部房间类型
        /// </summary>
        /// <returns></returns>
        public List<RoomType> GetRoomTypeALL()
        {
            List<RoomType> rList = new List<RoomType>();
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("SELECT * FROM RoomType");
            try
            {
                DBHelper.connection.Open();
                SqlCommand cmd = new SqlCommand(sb.ToString(), DBHelper.connection);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    RoomType type = new RoomType();
                    type.TypeID = Convert.ToInt32(dr["TypeId"].ToString());
                    type.TypeName = dr["TypeName"].ToString();
                    type.TypePrice = Convert.ToDouble(dr["TypePrice"].ToString());
                    rList.Add(type);
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
        #endregion

        #region 1.BaseSettings->RoomForm->查询全部房间类型
        /// <summary>
        /// 查询全部房间类型
        /// </summary>
        /// <returns></returns>
        public List<RoomType> GetRoomTypeALLEx()
        {
            List<RoomType> rList = new List<RoomType>();
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("SELECT * FROM RoomType");
            try
            {
                DBHelper.connection.Open();
                SqlCommand cmd = new SqlCommand(sb.ToString(), DBHelper.connection);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    RoomType type = new RoomType();
                    type.TypeID = Convert.ToInt32(dr["TypeId"].ToString());
                    type.TypeName = dr["TypeName"].ToString();
                    rList.Add(type);
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
        #endregion

        #region 1.BaseSettings->RoomTypeSettingForm->GetByRoomType根据房间类型查询
        public List<RoomType> GetByRoomType(string RoomTypeName)
        {
            List<RoomType> rList = new List<RoomType>();
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("select * from RoomType");
            sb.AppendLine("where TypeName like '%'+@RoomTypeName+'%'");
            SqlParameter[] param ={
                new SqlParameter("@RoomTypeName",RoomTypeName)
                                 };
            try
            {
                DBHelper.connection.Open();
                SqlCommand cmd = new SqlCommand(sb.ToString(), DBHelper.connection);
                cmd.Parameters.AddRange(param);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    RoomType roomtype = new RoomType();
                    roomtype.TypeID=Convert.ToInt32(dr["TypeID"].ToString());
                    roomtype.TypeName = dr["TypeName"].ToString();
                    roomtype.TypePrice = double.Parse(dr["TypePrice"].ToString());
                    rList.Add(roomtype);
                }
                dr.Close();
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                DBHelper.connection.Close();
            }
            return rList;
        }
        #endregion
    }
}

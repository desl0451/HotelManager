using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HotelManagerModels;
using HotelManagerDAL;
using System.Data.SqlClient;
using System.Windows.Forms;
namespace HotelManagerDAL
{
    /// <summary>
    /// 客户信息
    /// </summary>
    public class GuestRecordService
    {
        public List<GuestRecord> GetRoomTypeALL()
        {
            List<GuestRecord> rList = new List<GuestRecord>();
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("SELECT  a.GuestId,a.GuestName,a.IdentityID,a.ResideDate,a.Deposit,c.ResideName,a.LeaveDate,a.TotalMoney,b.RoomID,d.TypeName,e.RoomStateName,c.ResideId");
            sb.AppendLine("FROM  GuestRecord a INNER JOIN Room b ON a.RoomID=b.RoomID");
            sb.AppendLine("INNER JOIN ResideState c ON a.ResideID=c.ResideId");
            sb.AppendLine("INNER JOIN RoomType d ON b.RoomTypeID=d.TypeID");
            sb.AppendLine("INNER JOIN RoomState e ON b.RoomStateID=e.RoomStateID");
            try
            {
                DBHelper.connection.Open();
                SqlCommand cmd = new SqlCommand(sb.ToString(), DBHelper.connection);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    GuestRecord Record = new GuestRecord();
                    string LeaveDate = dr["LeaveDate"].ToString();
                    if (!string.IsNullOrEmpty(LeaveDate))
                    {
                        Record.LeaveDate = DateTime.Parse(LeaveDate);
                    }
                    Record.Deposit=double.Parse(dr["Deposit"].ToString());
                    Record.GuestId=Convert.ToInt32(dr["GuestId"].ToString());
                    Record.GuestName=dr["GuestName"].ToString();
                    Record.IdentityId=dr["IdentityId"].ToString();
                    Record.ResideDate=DateTime.Parse(dr["ResideDate"].ToString());
                    Record.ResideId=Convert.ToInt32(dr["ResideId"].ToString());
                    Record.RoomId=Convert.ToInt32(dr["RoomId"].ToString());
                    string TotalMoney=dr["TotalMoney"].ToString();
                    if (!string.IsNullOrEmpty(TotalMoney))
                    {
                        Record.TotalMoney = double.Parse(TotalMoney);
                    }
                    Record.ResideName = dr["ResideName"].ToString();
                    Record.RoomStateName=dr["RoomStateName"].ToString();
                    Record.TypeName=dr["TypeName"].ToString();
                    rList.Add(Record);
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
    }
}

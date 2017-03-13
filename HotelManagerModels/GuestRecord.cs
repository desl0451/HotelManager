using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HotelManagerModels
{
    public class GuestRecord
    {
        /// <summary>
        /// 顾客id
        /// </summary>
        public int GuestId { get; set; }
        /// <summary>
        /// 顾客姓名
        /// </summary>
        public string GuestName { get; set; }
        /// <summary>
        /// 身份证号
        /// </summary>
        public string IdentityId { get; set; }
        /// <summary>
        /// 房间id
        /// </summary>
        public int RoomId { get; set; }
        /// <summary>
        /// 入住状态id
        /// </summary>
        public int ResideId { get; set; }
        /// <summary>
        /// 入住日期
        /// </summary>
        public DateTime ResideDate { get; set; }
        /// <summary>
        /// 押金
        /// </summary>
        public double Deposit { get; set; }
        /// <summary>
        /// 房款
        /// </summary>
        public double TotalMoney { get; set; }
        /// <summary>
        /// 退房日期
        /// </summary>
        public DateTime LeaveDate { get; set; }
        /// <summary>
        /// 房间状态
        /// </summary>
        public string ResideName { get; set; }
        /// <summary>
        /// 房间状态
        /// </summary>
        public string RoomStateName { get; set; }
        /// <summary>
        /// 房间类型名
        /// </summary>
        public string TypeName { get; set; }

    }
}

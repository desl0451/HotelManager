using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HotelManagerModels
{
    public class Room
    {
        /// <summary>
        /// 房间ID
        /// </summary>
        public int RoomId { get; set; }
        /// <summary>
        /// 房间类型
        /// </summary>
        public int RoomTypeId { get; set; }
        /// <summary>
        /// 房间状态
        /// </summary>
        public int RoomStateId{ get; set; }
        /// <summary>
        /// 描述
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// 床位个数
        /// </summary>
        public int BedNum { get; set; }
        /// <summary>
        /// 入住顾客数量
        /// </summary>
        public int GuestNum { get; set; }

        public string RoomTypeName { get; set; }

        public string RoomStateName { get; set; }

    }
}

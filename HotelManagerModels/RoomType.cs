using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HotelManagerModels
{
    public class RoomType
    {
        /// <summary>
        /// 房间类型id
        /// </summary>
        public int TypeID { get; set; }
        /// <summary>
        /// 房间类型名
        /// </summary>
        public string TypeName { get; set; }
        /// <summary>
        /// 价格/天
        /// </summary>
        public double TypePrice { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonDemo
{
    public class GroupComboJson
    {
        /// <summary>
        /// 0-根据发团需要，本产品将在部分行程段发生团友的变化，请您谅解。拼团次数为；1-根据发团需要，本产品将在部分行程段发生团友的变化，请您谅解。拼团次数约为
        /// </summary>
        public int Radio { get; set; }
        /// <summary>
        /// 发团次数为
        /// </summary>
        public int Radio_No_0 { get; set; }
        /// <summary>
        /// 具体行程段
        /// </summary>
        public string Radio_Str { get; set; }
        /// <summary>
        /// 发团次数约为
        /// </summary>
        public int Radio_No_1 { get; set; }
        /// <summary>
        /// 本产品在游玩过程中会有当地参团的团友中途加入
        /// </summary>
        public bool Check { get; set; }
        /// <summary>
        /// 接送服务
        /// </summary>
        public PickupDeliveryService TPDPickupDelivery { get; set; }
    }
    public class PickupDeliveryService
    {
        /// <summary>
        /// 接送服务类型(0:无;1:接机;2:送机;3:接送机)
        /// </summary>
        public int PickupDeliveryServiceType { get; set; }
        /// <summary>
        /// 接机联系人
        /// </summary>
        public string PickupContactPerson { get; set; }
        /// <summary>
        /// 接机联系电话
        /// </summary>
        public string PickupContactMobile { get; set; }
        /// <summary>
        /// 接机备注
        /// </summary>
        public string PickupRemark { get; set; }
        /// <summary>
        /// 送机联系人
        /// </summary>
        public string DeliveryContactPerson { get; set; }
        /// <summary>
        /// 送机联系电话
        /// </summary>
        public string DeliveryContactMobile { get; set; }
        /// <summary>
        /// 送机备注
        /// </summary>
        public string DeliveryRemark { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YYS_Arrange.Class
{

    //御魂基类
    class EquipmentBase
    {
        /// <summary>
        /// 御魂副属性
        /// </summary>
        private EquipmentAttr[] m_equipmentAttrs;
        /// <summary>
        /// 御魂主属性
        /// </summary>
        private EquipmentAttr m_equipmentAttrBase;
        /// <summary>
        /// 出生时间戳
        /// </summary>
        private int m_bornTimestamp;
        /// <summary>
        /// 是否被弃置
        /// </summary>
        private bool m_isGarbage;
        /// <summary>
        /// 御魂类型ID
        /// </summary>
        private int m_equalID;
        /// <summary>
        /// 御魂唯一ID
        /// </summary>
        private int m_ID;
        /// <summary>
        /// 御魂等级
        /// </summary>
        private int m_level;
        /// <summary>
        /// 御魂是否被锁定
        /// </summary>
        private bool m_isLock;
        /// <summary>
        /// 御魂位置
        /// </summary>
        private int m_pos;
        /// <summary>
        /// 御魂星级
        /// </summary>
        private int m_quality;
        /// <summary>
        /// 固有属性
        /// </summary>
        private EquipmentAttr[] m_singleAttrs;
        /// <summary>
        /// 套装类型ID
        /// </summary>
        private int m_suitID;
        /// <summary>
        /// 御魂是否被装备
        /// </summary>
        private bool m_isEquip;
    }
}

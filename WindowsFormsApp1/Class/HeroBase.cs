using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YYS_Arrange.Class
{

    //式神基类
    class HeroBase
    {
        /// <summary>
        /// 式神等级
        /// </summary>
        private int m_level;
        /// <summary>
        /// 式神唯一ID
        /// </summary>
        private int m_ID;
        /// <summary>
        /// 式神ID
        /// </summary>
        private int m_heroID;
        /// <summary>
        /// 技能和技能等级
        /// </summary>
        private SkillAttr[] m_skills;
        /// <summary>
        /// 式神星级
        /// </summary>
        private int m_star;
        /// <summary>
        /// 式神稀有度
        /// </summary>
        private string m_rarity;
        /// <summary>
        /// 式神名称
        /// </summary>
        private string m_name;
        /// <summary>
        /// 式神昵称
        /// </summary>
        private string m_nickname;
        /// <summary>
        /// 基础攻击
        /// </summary>
        private double m_attackBase;
        /// <summary>
        /// 总攻击
        /// </summary>
        private double m_attackTotal;
        /// <summary>
        /// 基础生命值
        /// </summary>
        private double m_maxHPBase;
        /// <summary>
        /// 总生命值
        /// </summary>
        private double m_maxHPTotal;
        /// <summary>
        /// 基础防御
        /// </summary>
        private double m_defenseBase;
        /// <summary>
        /// 总防御
        /// </summary>
        private double m_defenseTotal;
        /// <summary>
        /// 基础速度
        /// </summary>
        private double m_speedBase;
        /// <summary>
        /// 总速度
        /// </summary>
        private double m_speedTotal;
        /// <summary>
        /// 基础暴击率
        /// </summary>
        private double m_critRateBase;
        /// <summary>
        /// 总暴击率
        /// </summary>
        private double m_critRateTotal;
        /// <summary>
        /// 基础暴击伤害
        /// </summary>
        private double m_critPowerBase;
        /// <summary>
        /// 总暴击伤害
        /// </summary>
        private double m_critPowerTotal;
        /// <summary>
        /// 效果命中
        /// </summary>
        private double m_effectHitRate;
        /// <summary>
        /// 效果抵抗
        /// </summary>
        private double m_effectResistRate;
        /// <summary>
        /// 出生时间戳
        /// </summary>
        private int m_bornTimestamp;
        /// <summary>
        /// 是否觉醒
        /// </summary>
        private bool m_isAwake;
        /// <summary>
        /// 装备御魂
        /// </summary>
        private EquipmentBase[] m_equipmentBases;
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using YYS_Arrange.Class;

namespace YYS_Arrange.Forms
{
    public partial class HeroInfoForm : Form
    {
        private string m_id;
        private HeroesItem m_herosItem;
        /// <summary>
        /// 需要传入式神的唯一ID用来检索式神信息
        /// </summary>
        /// <param name="id">式神唯一ID</param>
        public HeroInfoForm(string id)
        {
            m_id = id;
            for (int i = 0; i < GlobalData.root.data.heroes.Count; i++)
            {
                if (m_id == GlobalData.root.data.heroes[i].id)
                {
                    m_herosItem = GlobalData.root.data.heroes[i];
                }
            }
            InitializeComponent();
            SetParent();
            ShowInfo();
        }

        private void HeroInfoForm_Load(object sender, EventArgs e)
        {
            

        }
        /// <summary>
        /// 展示式神信息到界面上
        /// </summary>
        private void ShowInfo()
        {
            HeroPic.Image = (Image)Properties.Resources.ResourceManager.GetObject("_" + m_herosItem.hero_id, null);
            HeroRarityLabel.Text = m_herosItem.rarity;
            HeroNameLabel.Text = GameConfig.GetHeroName(m_herosItem.hero_id);
            HeroNickNameLabel.Text = m_herosItem.nick_name;
            //显示攻击数值
            if (m_herosItem.attrs.attack.@base == m_herosItem.attrs.attack.value)
            {
                AttackAttrLabel.Text = Tools.Data2String(m_herosItem.attrs.attack.@base, false);
            }
            else
            {
                AttackAttrLabel.Text = Tools.Data2String(m_herosItem.attrs.attack.@base, false) + "+" + Tools.Data2String(-(m_herosItem.attrs.attack.@base - m_herosItem.attrs.attack.value), false);
            }
            //显示暴击伤害数值
            if (m_herosItem.attrs.crit_power.@base == m_herosItem.attrs.crit_power.value)
            {
                CritDamageAttrLabel.Text = Tools.Data2String(m_herosItem.attrs.crit_power.@base + 1, true);
            }
            else
            {
                CritDamageAttrLabel.Text = Tools.Data2String(m_herosItem.attrs.crit_power.value + 1, true);
            }
            //显示暴击率数值
            if (m_herosItem.attrs.crit_rate.@base == m_herosItem.attrs.crit_rate.value)
            {
                CritAttrLabel.Text = Tools.Data2String(m_herosItem.attrs.crit_rate.@base, true);
            }
            else
            {
                CritAttrLabel.Text = Tools.Data2String(m_herosItem.attrs.crit_rate.@base, true) + "+" + Tools.Data2String(-(m_herosItem.attrs.crit_rate.@base - m_herosItem.attrs.crit_rate.value), true);
            }
            //显示防御数值
            if (m_herosItem.attrs.defense.@base == m_herosItem.attrs.defense.value)
            {
                DefAttrLabel.Text = Tools.Data2String(m_herosItem.attrs.defense.@base, false);
            }
            else
            {
                DefAttrLabel.Text = Tools.Data2String(m_herosItem.attrs.defense.@base, false) + "+" + Tools.Data2String(-(m_herosItem.attrs.defense.@base - m_herosItem.attrs.defense.value), false);
            }

            //显示效果抵抗数值
            EffectResistAttrLabel.Text = Tools.Data2String(m_herosItem.attrs.effect_hit_rate, true);
            //显示效果命中数值
            EffectAttrLabel.Text = Tools.Data2String(m_herosItem.attrs.effect_hit_rate, true);
            //显示速度数值
            if (m_herosItem.attrs.speed.@base == m_herosItem.attrs.speed.value)
            {
                SpeedAttrLabel.Text = Tools.Data2String(m_herosItem.attrs.speed.@base, false);
            }
            else
            {
                SpeedAttrLabel.Text = Tools.Data2String(m_herosItem.attrs.speed.@base, false) + "+" + Tools.Data2String(-(m_herosItem.attrs.speed.@base - m_herosItem.attrs.speed.value), false);
            }
            //显示生命数值
            if (m_herosItem.attrs.max_hp.@base == m_herosItem.attrs.max_hp.value)
            {
                HPAttrLabel.Text = Tools.Data2String(m_herosItem.attrs.max_hp.@base, false);
            }
            else
            {
                HPAttrLabel.Text = Tools.Data2String(m_herosItem.attrs.max_hp.@base, false) + "+" + Tools.Data2String(-(m_herosItem.attrs.max_hp.@base - m_herosItem.attrs.max_hp.value), false);
            }
            //显示攻击乘上爆伤数值
            Attack_CritDamageLabel.Text = Tools.Data2String((m_herosItem.attrs.attack.value * m_herosItem.attrs.crit_power.value), false);
            //显示生命乘上爆伤
            HP_CritDamageLabel.Text = Tools.Data2String((m_herosItem.attrs.max_hp.value * m_herosItem.attrs.crit_power.value), false);
            //显示获取日期
            BornTimeLabel.Text = "获取时间: " + Tools.Data2String(Tools.TimeStampToDateTime(m_herosItem.born).ToString());
        }

        private void SetParent()
        {
            Skill1Label.Parent = Skill1PictureBox;
            Skill2Label.Parent = Skill2PictureBox;
            //Skill3Label.Parent = Skill3PictureBox;

            //Equip1Lv.Parent = Equip_Pos1_Pic;
            //Equip2Lv.Parent = Equip_Pos2_Pic;
            //Equip3Lv.Parent = Equip_Pos3_Pic;
            //Equip4Lv.Parent = Equip_Pos4_Pic;
            //Equip5Lv.Parent = Equip_Pos5_Pic;
            //Equip6Lv.Parent = Equip_Pos6_Pic;

            //Equip_Pos1_Pic.Parent = Equip_Pos1_Pic_Bg;
            //Equip_Pos2_Pic.Parent = Equip_Pos2_Pic_Bg;
            //Equip_Pos3_Pic.Parent = Equip_Pos3_Pic_Bg;
            //Equip_Pos4_Pic.Parent = Equip_Pos4_Pic_Bg;
            //Equip_Pos5_Pic.Parent = Equip_Pos5_Pic_Bg;
            //Equip_Pos6_Pic.Parent = Equip_Pos6_Pic_Bg;
        }
    }
}

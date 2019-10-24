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
        }

        private void HeroInfoForm_Load(object sender, EventArgs e)
        {
            ShowInfo();
            SetParent();
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
        }

        private void SetParent()
        {
            Skill1Label.Parent = Skill1PictureBox;
            Skill2Label.Parent = Skill2PictureBox;
            Skill3Label.Parent = Skill3PictureBox;

            Equip1Lv.Parent = Equip_Pos1_Pic;
            Equip2Lv.Parent = Equip_Pos2_Pic;
            Equip3Lv.Parent = Equip_Pos3_Pic;
            Equip4Lv.Parent = Equip_Pos4_Pic;
            Equip5Lv.Parent = Equip_Pos5_Pic;
            Equip6Lv.Parent = Equip_Pos6_Pic;

            Equip_Pos1_Pic.Parent = Equip_Pos1_Pic_Bg;
            Equip_Pos2_Pic.Parent = Equip_Pos2_Pic_Bg;
            Equip_Pos3_Pic.Parent = Equip_Pos3_Pic_Bg;
            Equip_Pos4_Pic.Parent = Equip_Pos4_Pic_Bg;
            Equip_Pos5_Pic.Parent = Equip_Pos5_Pic_Bg;
            Equip_Pos6_Pic.Parent = Equip_Pos6_Pic_Bg;
        }
    }
}

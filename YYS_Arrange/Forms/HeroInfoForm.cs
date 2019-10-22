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
        /// 
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
            HeroPic.Image = (Image)Properties.Resources.ResourceManager.GetObject("_" + m_herosItem.hero_id, null);
            HeroRarityLabel.Text = m_herosItem.rarity;
            HeroNameLabel.Text = GameConfig.GetHeroName(m_herosItem.hero_id);
            HeroNickNameLabel.Text = m_herosItem.nick_name;

        }
    }
}

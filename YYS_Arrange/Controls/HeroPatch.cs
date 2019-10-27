using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using YYS_Arrange.Class;
using System.Windows.Forms;

namespace YYS_Arrange.Controls
{
    public partial class HeroPatch : UserControl
    {
        private int m_id;
        public HeroPatch(int id)
        {
            m_id = id;
            InitializeComponent();
        }

        private void HeroPatch_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < GlobalData.root.data.hero_book_shards.Count; i++)
            {
                if (m_id == GlobalData.root.data.hero_book_shards[i].hero_id)
                {
                    HeroPatchLabel.Text = Tools.Data2String(GlobalData.root.data.hero_book_shards[i].shards);
                    HeroNameLabel.Text = Tools.Data2String(GameConfig.GetHeroName(m_id));
                    HeroPic.Image = (Image)Properties.Resources.ResourceManager.GetObject("_" + m_id, null);
                }
            }
        }

    }
}

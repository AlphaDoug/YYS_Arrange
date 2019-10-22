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
    /// <summary>
    /// 御魂式神界面
    /// </summary>
    public partial class EquipsForm : Form
    {
        //在界面上展示的式神信息,排序生效
        List<HeroShowInfo> heroShowInfos = new List<HeroShowInfo>();
        public EquipsForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tabControl2.DrawMode = TabDrawMode.OwnerDrawFixed;//设置为用户绘制方式

            //设置下拉框默认选项
            RarityComboBox.Text = "全部";
            StarComboBox.Text = "全部";

            InitGlobalData();

            ShowBaseData();

            ShowHerosFold(string.Empty, -1, string.Empty);
        }

        private void tabControl2_DrawItem(object sender, DrawItemEventArgs e)
        {
            SolidBrush _Brush = new SolidBrush(Color.Black);//单色画刷
            RectangleF _TabTextArea = (RectangleF)tabControl2.GetTabRect(e.Index);//绘制区域
            StringFormat _sf = new StringFormat();//封装文本布局格式信息
            _sf.LineAlignment = StringAlignment.Center;
            _sf.Alignment = StringAlignment.Center;
            e.Graphics.DrawString(tabControl2.Controls[e.Index].Text, SystemInformation.MenuFont, _Brush, _TabTextArea, _sf);
        }



        /// <summary>
        /// 展示概况数据
        /// </summary>
        private void ShowBaseData()
        {

            //设置金币数量
            CoinLabel.Text = Tools.Data2String(GlobalData.root.data.currency.coin);
            //设置勾玉信息
            GouyuLabel.Text = Tools.Data2String(GlobalData.root.data.currency.jade);
            TiliLabel.Text = Tools.Data2String(GlobalData.root.data.currency.action_point);
            HunyuLabel.Text = Tools.Data2String(GlobalData.root.data.currency.s_jade);
            ShenmifuzhouLabel.Text = Tools.Data2String(GlobalData.root.data.currency.mystery_amulet);
            XianshifuzhouLabel.Text = Tools.Data2String(GlobalData.root.data.currency.ar_amulet);
            YuzhaLabel.Text = Tools.Data2String(GlobalData.root.data.currency.ofuda);
            JinyuzhaLabel.Text = Tools.Data2String(GlobalData.root.data.currency.gold_ofuda);
            DashelinpianLabel.Text = Tools.Data2String(GlobalData.root.data.currency.scale);
            DashenilinLabel.Text = Tools.Data2String(GlobalData.root.data.currency.reverse_scale);
            FengmozhihunLabel.Text = Tools.Data2String(GlobalData.root.data.currency.demon_soul);
            YulingjingzhiyaoLabel.Text = Tools.Data2String(GlobalData.root.data.currency.s_jade);
            YingbingLabel.Text = Tools.Data2String(GlobalData.root.data.currency.auto_point);
            BaiguiyexingLabel.Text = "未记录";
            ShishentiaozhanquanLabel.Text = "未记录";
            ChiquanLabel.Text = Tools.Data2String(GlobalData.root.data.currency.foolery_pass);
            RongyuLabel.Text = Tools.Data2String(GlobalData.root.data.currency.honor);
            XunzhangLabel.Text = Tools.Data2String(GlobalData.root.data.currency.medal);
            PifuquanLabel.Text = Tools.Data2String(GlobalData.root.data.currency.skin_token);
            YouqingdianLabel.Text = "未记录";
            MeiliLabel.Text = "未记录";
            SPPifuquanLabel.Text = Tools.Data2String(GlobalData.root.data.currency.sp_skin_token);

            SPLabel.Text = Tools.Data2String(GlobalData.hero_sp);
            SSRlabel.Text = Tools.Data2String(GlobalData.hero_ssr);
            SRLabel.Text = Tools.Data2String(GlobalData.hero_sr);
            RLabel.Text = Tools.Data2String(GlobalData.hero_r);
            NLabel.Text = Tools.Data2String(GlobalData.hero_n);
            SucaiLabel.Text = Tools.Data2String(GlobalData.hero_sucai);

            LiuxingLabel.Text = Tools.Data2String(GlobalData.equip_star_6);
            WuxingLabel.Text = Tools.Data2String(GlobalData.equip_star_5);
            SixingLabel.Text = Tools.Data2String(GlobalData.equip_star_4);
        }
        /// <summary>
        /// 初始化全局数据
        /// </summary>
        private void InitGlobalData()
        {
            #region 初始化各个稀有度式神数量
            for (int i = 0; i < GlobalData.root.data.heroes.Count; i++)
            {
                if (GlobalData.root.data.heroes[i].rarity == "SP")
                {
                    GlobalData.hero_sp++;
                }
                if (GlobalData.root.data.heroes[i].rarity == "SSR")
                {
                    GlobalData.hero_ssr++;
                }
                if (GlobalData.root.data.heroes[i].rarity == "SR")
                {
                    GlobalData.hero_sr++;
                }
                if (GlobalData.root.data.heroes[i].rarity == "R")
                {
                    GlobalData.hero_r++;
                }
                if (GlobalData.root.data.heroes[i].rarity == "N")
                {
                    GlobalData.hero_n++;
                }
                if (GlobalData.root.data.heroes[i].hero_id == 410 || GlobalData.root.data.heroes[i].hero_id == 411 || GlobalData.root.data.heroes[i].hero_id == 412)
                {
                    GlobalData.hero_sucai++;
                }
            }
            #endregion

            #region 初始化各个星级御魂数量
            for (int i = 0; i < GlobalData.root.data.hero_equips.Count; i++)
            {
                switch (GlobalData.root.data.hero_equips[i].quality)
                {
                    case 6:
                        GlobalData.equip_star_6++;
                        break;
                    case 5:
                        GlobalData.equip_star_5++;
                        break;
                    case 4:
                        GlobalData.equip_star_4++;
                        break;
                    default:
                        break;
                }
            }

            #endregion
        }
        /// <summary>
        /// 以折叠形式将所有式神展示到面板上
        /// </summary>
        private void ShowHerosFold(string rarity,int star, string name)
        {
            //清除面板上所有信息
            panel1.Controls.Clear();
            heroShowInfos.Clear();
            //御魂面板上,SP-SSR-SR-R-N顺序,稀有度相同的按照等级,等级相同的按照获得顺序,若两个相同类型的式神经验都是0则可以折叠显示
            HeroShowInfo heroShowInfo = new HeroShowInfo();
            int x = 0;
            int y = 0;
            int count = 0;
            //将式神信息放入list中
            for (int i = 0; i < GlobalData.root.data.heroes.Count; i++)
            {

                if (rarity != string.Empty)
                {
                    if (GlobalData.root.data.heroes[i].rarity != rarity)
                    {
                        continue;
                    }
                }

                if (star != -1)
                {
                    if (GlobalData.root.data.heroes[i].star != star)
                    {
                        continue;
                    }
                }

                if (name != string.Empty)
                {
                    if (!GameConfig.GetHeroName(GlobalData.root.data.heroes[i].hero_id).Contains(name))
                    {
                        continue;
                    }
                }
                heroShowInfo.hero_id = GlobalData.root.data.heroes[i].id;
                heroShowInfo.born = GlobalData.root.data.heroes[i].born;
                heroShowInfo.exp = GlobalData.root.data.heroes[i].exp;
                heroShowInfo.id = GlobalData.root.data.heroes[i].hero_id;
                heroShowInfo.level = GlobalData.root.data.heroes[i].level;
                heroShowInfo.name = GameConfig.GetHeroName(GlobalData.root.data.heroes[i].hero_id);
                heroShowInfo.rarity = GlobalData.root.data.heroes[i].rarity;
                heroShowInfo.star = GlobalData.root.data.heroes[i].star;
                heroShowInfo.awake = GlobalData.root.data.heroes[i].awake;
                heroShowInfo.count = 1;
                heroShowInfos.Add(heroShowInfo);

            }
            //对式神稀有度进行排序
            for (int i = 0; i < heroShowInfos.Count - 1; i++)
            {
                for (int j = i + 1; j < heroShowInfos.Count; j++)
                {
                    if (CompareAsLevel(heroShowInfos[i], heroShowInfos[j]) < 0)
                    {
                        HeroShowInfo temp = heroShowInfos[i];
                        heroShowInfos[i] = heroShowInfos[j];
                        heroShowInfos[j] = temp;
                    }
                }
            }


            for (int i = 0; i < heroShowInfos.Count; i++)
            {
                if (heroShowInfos[i].rarity == "R" || heroShowInfos[i].rarity == "N")
                {
                    continue;
                }
                HeroUserControl heroUserControl = new HeroUserControl(heroShowInfos[i]);
                x = (count % 10) * 126 + 10;
                y = (count - count % 10) / 10 * 159 + 10;
                heroUserControl.Location = new Point(x, y);
                heroUserControl.Tag = heroShowInfos[i].hero_id;
                panel1.Controls.Add(heroUserControl);

                count++;
            }
        }
        /// <summary>
        /// 比较a和b的大小,按照稀有度->等级->经验->出生日期
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns>a大返回1,a小返回-1</returns>
        private int CompareAsRarity(HeroShowInfo a,HeroShowInfo b)
        {
            if(CompareRarity(a.rarity, b.rarity) != 0)
            {
                if (CompareRarity(a.rarity, b.rarity) > 0)
                {
                    return 1;
                }
                else
                {
                    return -1;
                }
            }
            else
            {
                if (a.level != b.level)
                {
                    if (a.level > b.level)
                    {
                        return 1;
                    }
                    else
                    {
                        return -1;
                    }
                }
                else
                {
                    if (a.exp >= b.exp)
                    {
                        return 1;
                    }
                    else
                    {
                        if (a.born > b.born)
                        {
                            return 1;
                        }
                        else
                        {
                            return -1;
                        }
                        
                    }
                }
            }
        }

        /// <summary>
        /// 比较a和b的大小,按照等级->稀有度->经验->出生日期
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns>a大返回1,a小返回-1</returns>
        private int CompareAsLevel(HeroShowInfo a, HeroShowInfo b)
        {
            if (a.level != b.level)
            {
                if (a.level > b.level)
                {
                    return 1;
                }
                else
                {
                    return -1;
                }
            }
            else
            {
                if (CompareRarity(a.rarity, b.rarity) != 0)
                {
                    if (CompareRarity(a.rarity, b.rarity) > 0)
                    {
                        return 1;
                    }
                    else
                    {
                        return -1;
                    }
                }
                else
                {
                    if (a.exp >= b.exp)
                    {
                        return 1;
                    }
                    else
                    {
                        if (a.born > b.born)
                        {
                            return 1;
                        }
                        else
                        {
                            return -1;
                        }

                    }
                }
            }
        }


        private void HeroRarityPic_Click(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// 比较两个稀有度
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns>a比b稀有返回1,b比a稀有返回-1,稀有度相同返回0</returns>
        private int CompareRarity(string a,string b)
        {
            switch (a)
            {
                case "SP":
                    if (b == "SP")
                    {
                        return 0;
                    }
                    else
                    {
                        return 1;
                    }

                case "SSR":
                    if (b=="SSR")
                    {
                        return 0;
                    }
                    else if(b =="SP")
                    {
                        return -1;
                    }
                    else
                    {
                        return 1;
                    }

                case "SR":
                    if (b == "SR")
                    {
                        return 0;
                    }
                    else if (b == "SP" || b == "SSR")
                    {
                        return -1;
                    }
                    else
                    {
                        return 1;
                    }
                case "R":
                    if (b == "R")
                    {
                        return 0;
                    }
                    else if (b == "SP" || b == "SSR" || b == "SR")
                    {
                        return -1;
                    }
                    else
                    {
                        return 1;
                    }
                case "N":
                    if (b == "N")
                    {
                        return 0;
                    }
                    else
                    {
                        return -1;
                    }
                default:
                    return 0;
                   
            }
        }

        /// <summary>
        /// 下拉框选项更改
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int star = -1;
            switch (StarComboBox.SelectedIndex)
            {
                case -1:
                case 0:
                    break;
                case 1:
                    star = 6;
                    break;
                case 2:
                    star = 5;
                    break;
                case 3:
                    star = 4;
                    break;
                case 4:
                    star = 3;
                    break;
                case 5:
                    star = 2;
                    break;
                default:
                    break;
            }
            string rarity = string.Empty;
            switch (RarityComboBox.SelectedIndex)
            {
                case -1:
                case 0:
                    break;
                case 1:
                    rarity = "SP";
                    break;
                case 2:
                    rarity = "SSR";
                    break;
                case 3:
                    rarity = "SR";
                    break;
                case 4:
                    rarity = "R";
                    break;
                case 5:
                    rarity = "N";
                    break;
                default:
                    break;
            }
            string name = HeroNameSearchTextBox.Text;
            
            ShowHerosFold(rarity, star, name);
        }

    }
}

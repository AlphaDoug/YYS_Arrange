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
        public EquipsForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tabControl2.DrawMode = TabDrawMode.OwnerDrawFixed;//设置为用户绘制方式
            InitBaseData();
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
        /// 初始化概况数据
        /// </summary>
        private void InitBaseData()
        {
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
            //设置金币数量
            CoinLabel.Text = Tools.Data2String(GlobalData.root.data.currency.coin);
            //设置勾玉信息
            GouyuLabel.Text = Tools.Data2String(GlobalData.root.data.currency.jade);
            TiliLabel.Text = Tools.Data2String(GlobalData.root.data.currency.action_point);
            HunyuLabel.Text = Tools.Data2String(GlobalData.root.data.currency.s_jade);
            ShenmifuzhouLabel.Text = Tools.Data2String(GlobalData.root.data.currency.mystery_amulet);
            XianshifuzhouLabel.Text = Tools.Data2String(GlobalData.root.data.currency.ar_amulet);
            YuzhaLabel.Text = Tools.Data2String(GlobalData.root.data.currency.ofuda);
            label44.Text = Tools.Data2String(GlobalData.root.data.currency.gold_ofuda);
            DashelinpianLabel.Text = Tools.Data2String(GlobalData.root.data.currency.scale);
            label25.Text = Tools.Data2String(GlobalData.root.data.currency.reverse_scale);
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

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using YYS_Arrange.Forms;

namespace YYS_Arrange.Class
{
    public partial class HeroUserControl : UserControl
    {
        public HeroUserControl(HeroShowInfo heroShowInfo)
        {
            ShowInfo = heroShowInfo;
            InitializeComponent();
            SetParent();
            HeroShowInfo();
            foreach (Control item in Controls)
            {
                item.Click += HeroUserControl_Click;
            }
        }

        private HeroShowInfo ShowInfo;

        private  void HeroShowInfo()
        {
            if (ShowInfo.rarity == "N")
            {
                switch (ShowInfo.star)
                {
                    case 2:
                        HeroStar1.BackgroundImage = Properties.Resources.blue_goyu;
                        HeroStar2.BackgroundImage = Properties.Resources.blue_goyu;
                        HeroStar3.BackgroundImage = Properties.Resources.grey_goyu;
                        HeroStar4.BackgroundImage = Properties.Resources.grey_goyu;
                        HeroStar5.BackgroundImage = Properties.Resources.grey_goyu;
                        HeroStar6.BackgroundImage = Properties.Resources.grey_goyu;
                        break;
                    case 3:
                        HeroStar1.BackgroundImage = Properties.Resources.blue_goyu;
                        HeroStar2.BackgroundImage = Properties.Resources.blue_goyu;
                        HeroStar3.BackgroundImage = Properties.Resources.blue_goyu;
                        HeroStar4.BackgroundImage = Properties.Resources.grey_goyu;
                        HeroStar5.BackgroundImage = Properties.Resources.grey_goyu;
                        HeroStar6.BackgroundImage = Properties.Resources.grey_goyu;
                        break;

                    case 4:
                        HeroStar1.BackgroundImage = Properties.Resources.blue_goyu;
                        HeroStar2.BackgroundImage = Properties.Resources.blue_goyu;
                        HeroStar3.BackgroundImage = Properties.Resources.blue_goyu;
                        HeroStar4.BackgroundImage = Properties.Resources.blue_goyu;
                        HeroStar5.BackgroundImage = Properties.Resources.grey_goyu;
                        HeroStar6.BackgroundImage = Properties.Resources.grey_goyu;
                        break;

                    case 5:
                        HeroStar1.BackgroundImage = Properties.Resources.blue_goyu;
                        HeroStar2.BackgroundImage = Properties.Resources.blue_goyu;
                        HeroStar3.BackgroundImage = Properties.Resources.blue_goyu;
                        HeroStar4.BackgroundImage = Properties.Resources.blue_goyu;
                        HeroStar5.BackgroundImage = Properties.Resources.blue_goyu;
                        HeroStar6.BackgroundImage = Properties.Resources.grey_goyu;
                        break;

                    case 6:
                        HeroStar1.BackgroundImage = Properties.Resources.blue_goyu;
                        HeroStar2.BackgroundImage = Properties.Resources.blue_goyu;
                        HeroStar3.BackgroundImage = Properties.Resources.blue_goyu;
                        HeroStar4.BackgroundImage = Properties.Resources.blue_goyu;
                        HeroStar5.BackgroundImage = Properties.Resources.blue_goyu;
                        HeroStar6.BackgroundImage = Properties.Resources.blue_goyu;
                        break;

                    default:
                        break;
                }
            }
            else
            {
                if (ShowInfo.awake)
                {
                    switch (ShowInfo.star)
                    {
                        case 2:
                            HeroStar1.BackgroundImage = Properties.Resources.purple_goyu;
                            HeroStar2.BackgroundImage = Properties.Resources.purple_goyu;
                            HeroStar3.BackgroundImage = Properties.Resources.grey_goyu;
                            HeroStar4.BackgroundImage = Properties.Resources.grey_goyu;
                            HeroStar5.BackgroundImage = Properties.Resources.grey_goyu;
                            HeroStar6.BackgroundImage = Properties.Resources.grey_goyu;
                            break;
                        case 3:
                            HeroStar1.BackgroundImage = Properties.Resources.purple_goyu;
                            HeroStar2.BackgroundImage = Properties.Resources.purple_goyu;
                            HeroStar3.BackgroundImage = Properties.Resources.purple_goyu;
                            HeroStar4.BackgroundImage = Properties.Resources.grey_goyu;
                            HeroStar5.BackgroundImage = Properties.Resources.grey_goyu;
                            HeroStar6.BackgroundImage = Properties.Resources.grey_goyu;
                            break;

                        case 4:
                            HeroStar1.BackgroundImage = Properties.Resources.purple_goyu;
                            HeroStar2.BackgroundImage = Properties.Resources.purple_goyu;
                            HeroStar3.BackgroundImage = Properties.Resources.purple_goyu;
                            HeroStar4.BackgroundImage = Properties.Resources.purple_goyu;
                            HeroStar5.BackgroundImage = Properties.Resources.grey_goyu;
                            HeroStar6.BackgroundImage = Properties.Resources.grey_goyu;
                            break;

                        case 5:
                            HeroStar1.BackgroundImage = Properties.Resources.purple_goyu;
                            HeroStar2.BackgroundImage = Properties.Resources.purple_goyu;
                            HeroStar3.BackgroundImage = Properties.Resources.purple_goyu;
                            HeroStar4.BackgroundImage = Properties.Resources.purple_goyu;
                            HeroStar5.BackgroundImage = Properties.Resources.purple_goyu;
                            HeroStar6.BackgroundImage = Properties.Resources.grey_goyu;
                            break;

                        case 6:
                            HeroStar1.BackgroundImage = Properties.Resources.purple_goyu;
                            HeroStar2.BackgroundImage = Properties.Resources.purple_goyu;
                            HeroStar3.BackgroundImage = Properties.Resources.purple_goyu;
                            HeroStar4.BackgroundImage = Properties.Resources.purple_goyu;
                            HeroStar5.BackgroundImage = Properties.Resources.purple_goyu;
                            HeroStar6.BackgroundImage = Properties.Resources.purple_goyu;
                            break;

                        default:
                            break;
                    }
                }
                else
                {
                    switch (ShowInfo.star)
                    {
                        case 2:
                            HeroStar1.BackgroundImage = Properties.Resources.orange_goyu;
                            HeroStar2.BackgroundImage = Properties.Resources.orange_goyu;
                            HeroStar3.BackgroundImage = Properties.Resources.grey_goyu;
                            HeroStar4.BackgroundImage = Properties.Resources.grey_goyu;
                            HeroStar5.BackgroundImage = Properties.Resources.grey_goyu;
                            HeroStar6.BackgroundImage = Properties.Resources.grey_goyu;
                            break;
                        case 3:
                            HeroStar1.BackgroundImage = Properties.Resources.orange_goyu;
                            HeroStar2.BackgroundImage = Properties.Resources.orange_goyu;
                            HeroStar3.BackgroundImage = Properties.Resources.orange_goyu;
                            HeroStar4.BackgroundImage = Properties.Resources.grey_goyu;
                            HeroStar5.BackgroundImage = Properties.Resources.grey_goyu;
                            HeroStar6.BackgroundImage = Properties.Resources.grey_goyu;
                            break;

                        case 4:
                            HeroStar1.BackgroundImage = Properties.Resources.orange_goyu;
                            HeroStar2.BackgroundImage = Properties.Resources.orange_goyu;
                            HeroStar3.BackgroundImage = Properties.Resources.orange_goyu;
                            HeroStar4.BackgroundImage = Properties.Resources.orange_goyu;
                            HeroStar5.BackgroundImage = Properties.Resources.grey_goyu;
                            HeroStar6.BackgroundImage = Properties.Resources.grey_goyu;
                            break;

                        case 5:
                            HeroStar1.BackgroundImage = Properties.Resources.orange_goyu;
                            HeroStar2.BackgroundImage = Properties.Resources.orange_goyu;
                            HeroStar3.BackgroundImage = Properties.Resources.orange_goyu;
                            HeroStar4.BackgroundImage = Properties.Resources.orange_goyu;
                            HeroStar5.BackgroundImage = Properties.Resources.orange_goyu;
                            HeroStar6.BackgroundImage = Properties.Resources.grey_goyu;
                            break;

                        case 6:
                            HeroStar1.BackgroundImage = Properties.Resources.orange_goyu;
                            HeroStar2.BackgroundImage = Properties.Resources.orange_goyu;
                            HeroStar3.BackgroundImage = Properties.Resources.orange_goyu;
                            HeroStar4.BackgroundImage = Properties.Resources.orange_goyu;
                            HeroStar5.BackgroundImage = Properties.Resources.orange_goyu;
                            HeroStar6.BackgroundImage = Properties.Resources.orange_goyu;
                            break;

                        default:
                            break;
                    }
                }
            }

            HeroAwakeLabel.Visible = ShowInfo.awake;

            if (ShowInfo.level == 40)
            {
                HeroLevelLabel.Text = "满";
            }
            else
            {
                HeroLevelLabel.Text = Tools.Data2String(ShowInfo.level);
            }

            HeroRarityPic.BackgroundImage = (Image)Properties.Resources.ResourceManager.GetObject("_" + ShowInfo.id, null);

            HeroNameLabel.Text = ShowInfo.name;

            HeroNumLabel.Text = Tools.Data2String(ShowInfo.count);
        }
        /// <summary>
        /// 设置重叠控件的父控件,以便透明显示
        /// </summary>
        private void SetParent()
        {
            HeroStar1.Parent = HeroRarityPic;
            HeroStar2.Parent = HeroRarityPic;
            HeroStar3.Parent = HeroRarityPic;
            HeroStar4.Parent = HeroRarityPic;
            HeroStar5.Parent = HeroRarityPic;
            HeroStar6.Parent = HeroRarityPic;
            HeroLevelLabel.Parent = HeroRarityPic;
            HeroNumLabel.Parent = HeroRarityPic; 
        }

        private void HeroUserControl_DoubleClick(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// 点击式神打开详细信息界面
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void HeroUserControl_Click(object sender, EventArgs e)
        {

            HeroUserControl heroUserControl = sender as HeroUserControl;
            string id = heroUserControl.Tag as string;
            HeroInfoForm heroInfoForm = new HeroInfoForm(id);
            heroInfoForm.ShowDialog();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YYS_Arrange.Forms
{
    public partial class EquipsForm : Form
    {
        public EquipsForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tabControl2.DrawMode = TabDrawMode.OwnerDrawFixed;//设置为用户绘制方式
        }

        private void tabPage5_Click(object sender, EventArgs e)
        {

        }

        private void tabControl2_DrawItem(object sender, DrawItemEventArgs e)
        {
            Rectangle tabArea = tabControl1.GetTabRect(e.Index);//主要是做个转换来获得TAB项的RECTANGELF
            RectangleF tabTextArea = (RectangleF)(tabControl1.GetTabRect(e.Index));
            Graphics g = e.Graphics;
            StringFormat sf = new StringFormat();//封装文本布局信息
            sf.LineAlignment = StringAlignment.Center;
            sf.Alignment = StringAlignment.Near;
            Font font = this.tabControl1.Font;
            SolidBrush brush = new SolidBrush(Color.Black);//绘制边框的画笔
            g.DrawString(((TabControl)(sender)).TabPages[e.Index].Text, font, brush, tabTextArea, sf);
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YYS_Arrange.Forms
{
    public partial class InputUrlForm : Form
    {
        private string url;
        private string webText;
        public InputUrlForm()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 读取藏宝阁数据点击
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ReadCbgBtn_Click(object sender, EventArgs e)
        {
            url = cbgUrlText.Text;
            ReadCbgBtn.Enabled = false;
            Web.WebHandler.WebStringGet(url);
            //webText = Web.WebHandler.HttpGetString(url);
            ReadCbgBtn.Enabled = true;
            if (!string.IsNullOrEmpty(webText))
            {
                OpenUrlBtn.Visible = true;
                ReinputUrlBtn.Visible = true;
            }
            else
            {
                MessageBox.Show("链接输入错误,请检查!");
            }
        }
    }
}

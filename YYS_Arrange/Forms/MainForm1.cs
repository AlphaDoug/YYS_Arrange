using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YYS_Arrange.Forms
{
    public partial class MainForm1 : Form
    {
        public MainForm1()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 点击打开快照文件按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OpenSnapshotBtnClick(object sender, EventArgs e)
        {
            string fileName;
            OpenFileDialog file = new OpenFileDialog();
            file.Multiselect = false;
            file.ShowDialog();
            fileName = file.FileName;
            StreamReader r = new StreamReader(fileName);
            string json = r.ReadToEnd();
            List<Item> items = JsonConvert.DeserializeObject<List<Item>>(json);

        }
        /// <summary>
        /// 打开藏宝阁输入窗口
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void InputUrl_Click(object sender, EventArgs e)
        {
            var inputUrlForm = new InputUrlForm();
            inputUrlForm.ShowDialog();
        }
    }
}

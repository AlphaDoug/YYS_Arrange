using System;
using System.IO;
using System.Linq;
using System.Net.Json;
using System.Windows.Forms;
using System.Runtime.Serialization;
using YYS_Arrange.Class;

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
            if (fileName == "")
            {
                return;
            }
            StreamReader r = new StreamReader(fileName);
            string json = r.ReadToEnd();
            r.Close();
            Root root = new Root();
            root = Tools.JsonToObject(json, root) as Root;
            if (root == null)
            {
                MessageBox.Show("请选择正确的快照文件!");
                return;
            }


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

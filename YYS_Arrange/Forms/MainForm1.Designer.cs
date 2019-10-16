using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace YYS_Arrange.Forms
{
    partial class MainForm1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.OpenSnapshotBtn = new System.Windows.Forms.Button();
            this.InputUrl = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(267, 248);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // OpenSnapshotBtn
            // 
            this.OpenSnapshotBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.OpenSnapshotBtn.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.OpenSnapshotBtn.Location = new System.Drawing.Point(150, 266);
            this.OpenSnapshotBtn.Name = "OpenSnapshotBtn";
            this.OpenSnapshotBtn.Size = new System.Drawing.Size(129, 34);
            this.OpenSnapshotBtn.TabIndex = 2;
            this.OpenSnapshotBtn.Text = "打开快照文件";
            this.OpenSnapshotBtn.UseVisualStyleBackColor = true;
            this.OpenSnapshotBtn.Click += new System.EventHandler(this.OpenSnapshotBtnClick);
            // 
            // InputUrl
            // 
            this.InputUrl.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.InputUrl.Location = new System.Drawing.Point(12, 266);
            this.InputUrl.Name = "InputUrl";
            this.InputUrl.Size = new System.Drawing.Size(132, 34);
            this.InputUrl.TabIndex = 2;
            this.InputUrl.Text = "输入藏宝阁网址";
            this.InputUrl.UseVisualStyleBackColor = true;
            this.InputUrl.Click += new System.EventHandler(this.InputUrl_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox1.Location = new System.Drawing.Point(315, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(439, 288);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "最近快照";
            // 
            // MainForm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 356);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.InputUrl);
            this.Controls.Add(this.OpenSnapshotBtn);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "请选择文件或者网址";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private PictureBox pictureBox1;
        private Button OpenSnapshotBtn;
        private Button InputUrl;
        private GroupBox groupBox1;
    }
}


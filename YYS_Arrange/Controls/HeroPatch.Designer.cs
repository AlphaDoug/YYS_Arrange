namespace YYS_Arrange.Controls
{
    partial class HeroPatch
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

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.HeroPic = new System.Windows.Forms.PictureBox();
            this.HeroNameLabel = new System.Windows.Forms.Label();
            this.HeroPatchLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.HeroPic)).BeginInit();
            this.SuspendLayout();
            // 
            // HeroPic
            // 
            this.HeroPic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.HeroPic.Image = global::YYS_Arrange.Properties.Resources._202;
            this.HeroPic.Location = new System.Drawing.Point(4, 4);
            this.HeroPic.Name = "HeroPic";
            this.HeroPic.Size = new System.Drawing.Size(111, 111);
            this.HeroPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.HeroPic.TabIndex = 0;
            this.HeroPic.TabStop = false;
            // 
            // HeroNameLabel
            // 
            this.HeroNameLabel.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.HeroNameLabel.Location = new System.Drawing.Point(122, 15);
            this.HeroNameLabel.Name = "HeroNameLabel";
            this.HeroNameLabel.Size = new System.Drawing.Size(187, 35);
            this.HeroNameLabel.TabIndex = 1;
            this.HeroNameLabel.Text = "少于大条狗";
            this.HeroNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // HeroPatchLabel
            // 
            this.HeroPatchLabel.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.HeroPatchLabel.Location = new System.Drawing.Point(121, 66);
            this.HeroPatchLabel.Name = "HeroPatchLabel";
            this.HeroPatchLabel.Size = new System.Drawing.Size(187, 35);
            this.HeroPatchLabel.TabIndex = 1;
            this.HeroPatchLabel.Text = "×10";
            this.HeroPatchLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // HeroPatch
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.Controls.Add(this.HeroPatchLabel);
            this.Controls.Add(this.HeroNameLabel);
            this.Controls.Add(this.HeroPic);
            this.Name = "HeroPatch";
            this.Size = new System.Drawing.Size(312, 118);
            this.Load += new System.EventHandler(this.HeroPatch_Load);
            ((System.ComponentModel.ISupportInitialize)(this.HeroPic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox HeroPic;
        private System.Windows.Forms.Label HeroNameLabel;
        private System.Windows.Forms.Label HeroPatchLabel;
    }
}

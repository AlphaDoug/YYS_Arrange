namespace YYS_Arrange.Class
{
    partial class HeroControlPanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HeroControlPanel));
            this.HeroRarityPic = new System.Windows.Forms.PictureBox();
            this.HeroNumLabel = new System.Windows.Forms.Label();
            this.HeroNameLabel = new System.Windows.Forms.Label();
            this.HeroAwakeLabel = new System.Windows.Forms.Label();
            this.HeroLevelLabel = new System.Windows.Forms.Label();
            this.HeroStar6 = new System.Windows.Forms.PictureBox();
            this.HeroStar5 = new System.Windows.Forms.PictureBox();
            this.HeroStar4 = new System.Windows.Forms.PictureBox();
            this.HeroStar3 = new System.Windows.Forms.PictureBox();
            this.HeroStar2 = new System.Windows.Forms.PictureBox();
            this.HeroStar1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.HeroRarityPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HeroStar6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HeroStar5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HeroStar4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HeroStar3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HeroStar2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HeroStar1)).BeginInit();
            this.SuspendLayout();
            // 
            // HeroRarityPic
            // 
            this.HeroRarityPic.BackColor = System.Drawing.Color.Transparent;
            this.HeroRarityPic.BackgroundImage = global::YYS_Arrange.Properties.Resources._217;
            this.HeroRarityPic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.HeroRarityPic.Image = ((System.Drawing.Image)(resources.GetObject("HeroRarityPic.Image")));
            this.HeroRarityPic.Location = new System.Drawing.Point(5, 5);
            this.HeroRarityPic.Margin = new System.Windows.Forms.Padding(0);
            this.HeroRarityPic.Name = "HeroRarityPic";
            this.HeroRarityPic.Size = new System.Drawing.Size(100, 104);
            this.HeroRarityPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.HeroRarityPic.TabIndex = 2;
            this.HeroRarityPic.TabStop = false;
            // 
            // HeroNumLabel
            // 
            this.HeroNumLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.HeroNumLabel.AutoSize = true;
            this.HeroNumLabel.Font = new System.Drawing.Font("微软雅黑", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.HeroNumLabel.Image = global::YYS_Arrange.Properties.Resources.hero_numBg;
            this.HeroNumLabel.Location = new System.Drawing.Point(76, 6);
            this.HeroNumLabel.Margin = new System.Windows.Forms.Padding(0);
            this.HeroNumLabel.Name = "HeroNumLabel";
            this.HeroNumLabel.Size = new System.Drawing.Size(26, 16);
            this.HeroNumLabel.TabIndex = 17;
            this.HeroNumLabel.Text = "110";
            this.HeroNumLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // HeroNameLabel
            // 
            this.HeroNameLabel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.HeroNameLabel.BackColor = System.Drawing.Color.LightGray;
            this.HeroNameLabel.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.HeroNameLabel.Location = new System.Drawing.Point(5, 111);
            this.HeroNameLabel.Margin = new System.Windows.Forms.Padding(0);
            this.HeroNameLabel.Name = "HeroNameLabel";
            this.HeroNameLabel.Size = new System.Drawing.Size(100, 25);
            this.HeroNameLabel.TabIndex = 8;
            this.HeroNameLabel.Text = "炼狱茨木童子";
            this.HeroNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // HeroAwakeLabel
            // 
            this.HeroAwakeLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.HeroAwakeLabel.BackColor = System.Drawing.Color.MediumOrchid;
            this.HeroAwakeLabel.Font = new System.Drawing.Font("微软雅黑", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.HeroAwakeLabel.Location = new System.Drawing.Point(81, 57);
            this.HeroAwakeLabel.Name = "HeroAwakeLabel";
            this.HeroAwakeLabel.Size = new System.Drawing.Size(19, 30);
            this.HeroAwakeLabel.TabIndex = 15;
            this.HeroAwakeLabel.Text = "觉";
            this.HeroAwakeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // HeroLevelLabel
            // 
            this.HeroLevelLabel.AutoSize = true;
            this.HeroLevelLabel.Font = new System.Drawing.Font("微软雅黑", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.HeroLevelLabel.ForeColor = System.Drawing.Color.White;
            this.HeroLevelLabel.Image = global::YYS_Arrange.Properties.Resources.hero_levelBg;
            this.HeroLevelLabel.Location = new System.Drawing.Point(6, 6);
            this.HeroLevelLabel.Margin = new System.Windows.Forms.Padding(0);
            this.HeroLevelLabel.Name = "HeroLevelLabel";
            this.HeroLevelLabel.Size = new System.Drawing.Size(19, 16);
            this.HeroLevelLabel.TabIndex = 16;
            this.HeroLevelLabel.Text = "满";
            this.HeroLevelLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // HeroStar6
            // 
            this.HeroStar6.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.HeroStar6.BackColor = System.Drawing.Color.Transparent;
            this.HeroStar6.BackgroundImage = global::YYS_Arrange.Properties.Resources.blue_goyu;
            this.HeroStar6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.HeroStar6.Location = new System.Drawing.Point(84, 89);
            this.HeroStar6.Margin = new System.Windows.Forms.Padding(0);
            this.HeroStar6.Name = "HeroStar6";
            this.HeroStar6.Size = new System.Drawing.Size(16, 20);
            this.HeroStar6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.HeroStar6.TabIndex = 9;
            this.HeroStar6.TabStop = false;
            // 
            // HeroStar5
            // 
            this.HeroStar5.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.HeroStar5.BackgroundImage = global::YYS_Arrange.Properties.Resources.grey_goyu;
            this.HeroStar5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.HeroStar5.Location = new System.Drawing.Point(69, 89);
            this.HeroStar5.Margin = new System.Windows.Forms.Padding(0);
            this.HeroStar5.Name = "HeroStar5";
            this.HeroStar5.Size = new System.Drawing.Size(16, 20);
            this.HeroStar5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.HeroStar5.TabIndex = 10;
            this.HeroStar5.TabStop = false;
            // 
            // HeroStar4
            // 
            this.HeroStar4.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.HeroStar4.BackColor = System.Drawing.Color.Transparent;
            this.HeroStar4.BackgroundImage = global::YYS_Arrange.Properties.Resources.blue_goyu;
            this.HeroStar4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.HeroStar4.Location = new System.Drawing.Point(54, 89);
            this.HeroStar4.Margin = new System.Windows.Forms.Padding(0);
            this.HeroStar4.Name = "HeroStar4";
            this.HeroStar4.Size = new System.Drawing.Size(16, 20);
            this.HeroStar4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.HeroStar4.TabIndex = 11;
            this.HeroStar4.TabStop = false;
            // 
            // HeroStar3
            // 
            this.HeroStar3.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.HeroStar3.BackgroundImage = global::YYS_Arrange.Properties.Resources.grey_goyu;
            this.HeroStar3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.HeroStar3.Location = new System.Drawing.Point(39, 89);
            this.HeroStar3.Margin = new System.Windows.Forms.Padding(0);
            this.HeroStar3.Name = "HeroStar3";
            this.HeroStar3.Size = new System.Drawing.Size(16, 20);
            this.HeroStar3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.HeroStar3.TabIndex = 12;
            this.HeroStar3.TabStop = false;
            // 
            // HeroStar2
            // 
            this.HeroStar2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.HeroStar2.BackColor = System.Drawing.Color.Transparent;
            this.HeroStar2.BackgroundImage = global::YYS_Arrange.Properties.Resources.blue_goyu;
            this.HeroStar2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.HeroStar2.Location = new System.Drawing.Point(24, 89);
            this.HeroStar2.Margin = new System.Windows.Forms.Padding(0);
            this.HeroStar2.Name = "HeroStar2";
            this.HeroStar2.Size = new System.Drawing.Size(16, 20);
            this.HeroStar2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.HeroStar2.TabIndex = 13;
            this.HeroStar2.TabStop = false;
            // 
            // HeroStar1
            // 
            this.HeroStar1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.HeroStar1.BackgroundImage = global::YYS_Arrange.Properties.Resources.grey_goyu;
            this.HeroStar1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.HeroStar1.Location = new System.Drawing.Point(9, 89);
            this.HeroStar1.Margin = new System.Windows.Forms.Padding(0);
            this.HeroStar1.Name = "HeroStar1";
            this.HeroStar1.Size = new System.Drawing.Size(16, 20);
            this.HeroStar1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.HeroStar1.TabIndex = 14;
            this.HeroStar1.TabStop = false;
            // 
            // HeroControlPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.HeroNumLabel);
            this.Controls.Add(this.HeroNameLabel);
            this.Controls.Add(this.HeroAwakeLabel);
            this.Controls.Add(this.HeroLevelLabel);
            this.Controls.Add(this.HeroStar6);
            this.Controls.Add(this.HeroStar5);
            this.Controls.Add(this.HeroStar4);
            this.Controls.Add(this.HeroStar3);
            this.Controls.Add(this.HeroStar2);
            this.Controls.Add(this.HeroStar1);
            this.Controls.Add(this.HeroRarityPic);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "HeroControlPanel";
            this.Size = new System.Drawing.Size(110, 140);
            this.Load += new System.EventHandler(this.HeroControlPanel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.HeroRarityPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HeroStar6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HeroStar5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HeroStar4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HeroStar3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HeroStar2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HeroStar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox HeroRarityPic;
        private System.Windows.Forms.Label HeroNumLabel;
        private System.Windows.Forms.Label HeroNameLabel;
        private System.Windows.Forms.Label HeroAwakeLabel;
        private System.Windows.Forms.Label HeroLevelLabel;
        private System.Windows.Forms.PictureBox HeroStar6;
        private System.Windows.Forms.PictureBox HeroStar5;
        private System.Windows.Forms.PictureBox HeroStar4;
        private System.Windows.Forms.PictureBox HeroStar3;
        private System.Windows.Forms.PictureBox HeroStar2;
        private System.Windows.Forms.PictureBox HeroStar1;
    }
}

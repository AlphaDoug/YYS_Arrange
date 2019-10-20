namespace YYS_Arrange.Forms
{
    partial class HeroInfoForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.HeroPic = new System.Windows.Forms.PictureBox();
            this.HeroRarityLabel = new System.Windows.Forms.Label();
            this.HeroNameLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.HeroNickNameLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.HeroPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // HeroPic
            // 
            this.HeroPic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.HeroPic.Image = global::YYS_Arrange.Properties.Resources._200;
            this.HeroPic.Location = new System.Drawing.Point(12, 12);
            this.HeroPic.Name = "HeroPic";
            this.HeroPic.Size = new System.Drawing.Size(64, 64);
            this.HeroPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.HeroPic.TabIndex = 0;
            this.HeroPic.TabStop = false;
            // 
            // HeroRarityLabel
            // 
            this.HeroRarityLabel.Font = new System.Drawing.Font("微软雅黑", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.HeroRarityLabel.Location = new System.Drawing.Point(82, 12);
            this.HeroRarityLabel.Name = "HeroRarityLabel";
            this.HeroRarityLabel.Size = new System.Drawing.Size(47, 23);
            this.HeroRarityLabel.TabIndex = 1;
            this.HeroRarityLabel.Text = "SSR";
            this.HeroRarityLabel.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // HeroNameLabel
            // 
            this.HeroNameLabel.Font = new System.Drawing.Font("微软雅黑", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.HeroNameLabel.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.HeroNameLabel.Location = new System.Drawing.Point(127, 15);
            this.HeroNameLabel.Name = "HeroNameLabel";
            this.HeroNameLabel.Size = new System.Drawing.Size(113, 20);
            this.HeroNameLabel.TabIndex = 1;
            this.HeroNameLabel.Text = "桃花妖";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("微软雅黑", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.label1.Location = new System.Drawing.Point(83, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "昵称:";
            // 
            // HeroNickNameLabel
            // 
            this.HeroNickNameLabel.Font = new System.Drawing.Font("微软雅黑", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.HeroNickNameLabel.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.HeroNickNameLabel.Location = new System.Drawing.Point(127, 47);
            this.HeroNickNameLabel.Name = "HeroNickNameLabel";
            this.HeroNickNameLabel.Size = new System.Drawing.Size(113, 20);
            this.HeroNickNameLabel.TabIndex = 1;
            this.HeroNickNameLabel.Text = "昵称:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(13, 83);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(23, 23);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // HeroInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(677, 367);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.HeroNickNameLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.HeroNameLabel);
            this.Controls.Add(this.HeroRarityLabel);
            this.Controls.Add(this.HeroPic);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "HeroInfoForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HeroInfoForm";
            ((System.ComponentModel.ISupportInitialize)(this.HeroPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox HeroPic;
        private System.Windows.Forms.Label HeroRarityLabel;
        private System.Windows.Forms.Label HeroNameLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label HeroNickNameLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
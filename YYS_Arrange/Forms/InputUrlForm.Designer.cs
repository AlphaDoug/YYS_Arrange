namespace YYS_Arrange.Forms
{
    partial class InputUrlForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InputUrlForm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbgUrlText = new System.Windows.Forms.TextBox();
            this.ReadCbgBtn = new System.Windows.Forms.Button();
            this.OpenUrlBtn = new System.Windows.Forms.Button();
            this.ReinputUrlBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(24, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(451, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "打开任意藏宝阁商品详情页面，复制粘贴如下格式的整个网址: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label2.Location = new System.Drawing.Point(24, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(653, 21);
            this.label2.TabIndex = 0;
            this.label2.Text = "https://yys.cbg.163.com/cgi/mweb/equip/12/201910081801616-12-IGIBUQOPCBX1A";
            // 
            // cbgUrlText
            // 
            this.cbgUrlText.Font = new System.Drawing.Font("宋体", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbgUrlText.Location = new System.Drawing.Point(28, 95);
            this.cbgUrlText.Multiline = true;
            this.cbgUrlText.Name = "cbgUrlText";
            this.cbgUrlText.Size = new System.Drawing.Size(652, 120);
            this.cbgUrlText.TabIndex = 1;
            // 
            // ReadCbgBtn
            // 
            this.ReadCbgBtn.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ReadCbgBtn.Location = new System.Drawing.Point(528, 228);
            this.ReadCbgBtn.Name = "ReadCbgBtn";
            this.ReadCbgBtn.Size = new System.Drawing.Size(152, 34);
            this.ReadCbgBtn.TabIndex = 2;
            this.ReadCbgBtn.Text = "读取藏宝阁数据";
            this.ReadCbgBtn.UseVisualStyleBackColor = true;
            this.ReadCbgBtn.Click += new System.EventHandler(this.ReadCbgBtn_Click);
            // 
            // OpenUrlBtn
            // 
            this.OpenUrlBtn.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.OpenUrlBtn.Location = new System.Drawing.Point(457, 228);
            this.OpenUrlBtn.Name = "OpenUrlBtn";
            this.OpenUrlBtn.Size = new System.Drawing.Size(65, 34);
            this.OpenUrlBtn.TabIndex = 2;
            this.OpenUrlBtn.Text = "打开";
            this.OpenUrlBtn.UseVisualStyleBackColor = true;
            this.OpenUrlBtn.Visible = false;
            this.OpenUrlBtn.Click += new System.EventHandler(this.ReadCbgBtn_Click);
            // 
            // ReinputUrlBtn
            // 
            this.ReinputUrlBtn.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ReinputUrlBtn.Location = new System.Drawing.Point(528, 228);
            this.ReinputUrlBtn.Name = "ReinputUrlBtn";
            this.ReinputUrlBtn.Size = new System.Drawing.Size(152, 34);
            this.ReinputUrlBtn.TabIndex = 2;
            this.ReinputUrlBtn.Text = "重新输入链接";
            this.ReinputUrlBtn.UseVisualStyleBackColor = true;
            this.ReinputUrlBtn.Visible = false;
            this.ReinputUrlBtn.Click += new System.EventHandler(this.ReadCbgBtn_Click);
            // 
            // InputUrlForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(709, 274);
            this.Controls.Add(this.OpenUrlBtn);
            this.Controls.Add(this.ReinputUrlBtn);
            this.Controls.Add(this.ReadCbgBtn);
            this.Controls.Add(this.cbgUrlText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "InputUrlForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "输入藏宝阁链接";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox cbgUrlText;
        private System.Windows.Forms.Button ReadCbgBtn;
        private System.Windows.Forms.Button OpenUrlBtn;
        private System.Windows.Forms.Button ReinputUrlBtn;
    }
}
namespace BiSS.Projects.RPGen.Windows
{
    partial class WarningWindow
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WarningWindow));
			this.modernButton1 = new RsWork.UI.Controls.ModernButton();
			this.modernButton2 = new RsWork.UI.Controls.ModernButton();
			this.label1 = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.label2 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// modernButton1
			// 
			this.modernButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.modernButton1.BackColor = System.Drawing.Color.Transparent;
			this.modernButton1.BorderColor = System.Drawing.Color.Black;
			this.modernButton1.DisabledBorderColor = System.Drawing.Color.DarkGray;
			this.modernButton1.DisabledForeColor = System.Drawing.Color.DarkGray;
			this.modernButton1.FlatAppearance.BorderColor = System.Drawing.Color.Black;
			this.modernButton1.FlatAppearance.BorderSize = 2;
			this.modernButton1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.modernButton1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.modernButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.modernButton1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.modernButton1.ForeColor = System.Drawing.Color.Black;
			this.modernButton1.Location = new System.Drawing.Point(12, 201);
			this.modernButton1.Name = "modernButton1";
			this.modernButton1.Size = new System.Drawing.Size(120, 49);
			this.modernButton1.TabIndex = 0;
			this.modernButton1.Text = "确定(&Y)";
			this.modernButton1.UseVisualStyleBackColor = false;
			this.modernButton1.Click += new System.EventHandler(this.modernButton1_Click);
			// 
			// modernButton2
			// 
			this.modernButton2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.modernButton2.BackColor = System.Drawing.Color.Transparent;
			this.modernButton2.BorderColor = System.Drawing.Color.Black;
			this.modernButton2.DisabledBorderColor = System.Drawing.Color.DarkGray;
			this.modernButton2.DisabledForeColor = System.Drawing.Color.DarkGray;
			this.modernButton2.FlatAppearance.BorderColor = System.Drawing.Color.Black;
			this.modernButton2.FlatAppearance.BorderSize = 2;
			this.modernButton2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.modernButton2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.modernButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.modernButton2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.modernButton2.ForeColor = System.Drawing.Color.Black;
			this.modernButton2.Location = new System.Drawing.Point(424, 201);
			this.modernButton2.Name = "modernButton2";
			this.modernButton2.Size = new System.Drawing.Size(134, 49);
			this.modernButton2.TabIndex = 1;
			this.modernButton2.Text = "退出程序(&Y)";
			this.modernButton2.UseVisualStyleBackColor = false;
			this.modernButton2.Click += new System.EventHandler(this.modernButton2_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("微软雅黑", 53F);
			this.label1.ForeColor = System.Drawing.Color.Red;
			this.label1.Location = new System.Drawing.Point(114, 12);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(351, 92);
			this.label1.TabIndex = 2;
			this.label1.Text = "Warning!";
			this.label1.Click += new System.EventHandler(this.label1_Click);
			this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label1_MouseDown);
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(12, 12);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(96, 96);
			this.pictureBox1.TabIndex = 3;
			this.pictureBox1.TabStop = false;
			this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label1_MouseDown);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.label2.ForeColor = System.Drawing.Color.Black;
			this.label2.Location = new System.Drawing.Point(13, 115);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(517, 63);
			this.label2.TabIndex = 4;
			this.label2.Text = "本程序在Windows 8.1及更高版本的Windows上会得到最好的显示效果.\r\n如果您正在Windows XP,Vista,7或8 上使用本程序,可把系统默认" +
    "显示字\r\n体改为微软雅黑来获得更好的显示效果.";
			this.label2.Click += new System.EventHandler(this.label2_Click);
			// 
			// WarningWindow
			// 
			this.BackColor = System.Drawing.Color.Yellow;
			this.ClientSize = new System.Drawing.Size(570, 262);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.modernButton2);
			this.Controls.Add(this.modernButton1);
			this.Name = "WarningWindow";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.TopMost = true;
			this.Load += new System.EventHandler(this.WarningWindow_Load);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private RsWork.UI.Controls.ModernButton modernButton1;
        private RsWork.UI.Controls.ModernButton modernButton2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label label2;
	}
}

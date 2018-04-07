using MetroFramework.Controls;

namespace BiSS.Projects.RPGen.Windows
{
	partial class SplashWindow
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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SplashWindow));
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.button1 = new System.Windows.Forms.Button();
			this.timer = new System.Windows.Forms.Timer(this.components);
			this.bgw = new System.ComponentModel.BackgroundWorker();
			this.metroProgressSpinner1 = new MetroFramework.Controls.MetroProgressSpinner();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// title
			// 
			this.title.ForeColor = System.Drawing.Color.White;
			this.title.Location = new System.Drawing.Point(12, 9);
			this.title.Size = new System.Drawing.Size(481, 46);
			this.title.Text = "成绩报告生成器 正在启动......";
			this.title.MouseDown += new System.Windows.Forms.MouseEventHandler(this.WindowMove);
			// 
			// Context
			// 
			this.Context.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.Context.Location = new System.Drawing.Point(16, 55);
			this.Context.Size = new System.Drawing.Size(170, 21);
			this.Context.Text = "本程序仅用于竞赛用途";
			this.Context.MouseDown += new System.Windows.Forms.MouseEventHandler(this.WindowMove);
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
			this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.pictureBox1.Location = new System.Drawing.Point(96, 88);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(255, 255);
			this.pictureBox1.TabIndex = 3;
			this.pictureBox1.TabStop = false;
			this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.WindowMove);
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(0, 0);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(0, 0);
			this.button1.TabIndex = 1;
			this.button1.Text = "button1";
			this.button1.UseVisualStyleBackColor = true;
			// 
			// timer
			// 
			this.timer.Enabled = true;
			this.timer.Tick += new System.EventHandler(this.timer_Tick);
			// 
			// bgw
			// 
			this.bgw.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgw_DoWork);
			this.bgw.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgw_RunWorkerCompleted);
			// 
			// metroProgressSpinner1
			// 
			this.metroProgressSpinner1.CustomBackground = true;
			this.metroProgressSpinner1.Location = new System.Drawing.Point(381, 88);
			this.metroProgressSpinner1.Maximum = 100;
			this.metroProgressSpinner1.Name = "metroProgressSpinner1";
			this.metroProgressSpinner1.Size = new System.Drawing.Size(255, 255);
			this.metroProgressSpinner1.Speed = 9F;
			this.metroProgressSpinner1.Style = MetroFramework.MetroColorStyle.Orange;
			this.metroProgressSpinner1.TabIndex = 6;
			this.metroProgressSpinner1.Value = 30;
			// 
			// SplashWindow
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(181)))), ((int)(((byte)(226)))));
			this.ClientSize = new System.Drawing.Size(732, 375);
			this.Controls.Add(this.metroProgressSpinner1);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.pictureBox1);
			this.Name = "SplashWindow";
			this.Controls.SetChildIndex(this.title, 0);
			this.Controls.SetChildIndex(this.Context, 0);
			this.Controls.SetChildIndex(this.pictureBox1, 0);
			this.Controls.SetChildIndex(this.button1, 0);
			this.Controls.SetChildIndex(this.metroProgressSpinner1, 0);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Timer timer;
		private System.ComponentModel.BackgroundWorker bgw;
		private MetroProgressSpinner metroProgressSpinner1;
	}
}

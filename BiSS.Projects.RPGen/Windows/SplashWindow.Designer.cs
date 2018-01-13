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
			this.webBrowser1 = new System.Windows.Forms.WebBrowser();
			this.SuspendLayout();
			// 
			// title
			// 
			this.title.ForeColor = System.Drawing.Color.Black;
			this.title.Size = new System.Drawing.Size(428, 46);
			this.title.Text = "正在启动应用程序. . . . . . ";
			// 
			// Context
			// 
			this.Context.ForeColor = System.Drawing.Color.Black;
			this.Context.Size = new System.Drawing.Size(312, 21);
			this.Context.Text = "本程序由Believers in Science Studio 制作";
			// 
			// webBrowser1
			// 
			this.webBrowser1.AllowNavigation = false;
			this.webBrowser1.AllowWebBrowserDrop = false;
			this.webBrowser1.IsWebBrowserContextMenuEnabled = false;
			this.webBrowser1.Location = new System.Drawing.Point(17, 270);
			this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
			this.webBrowser1.Name = "webBrowser1";
			this.webBrowser1.ScrollBarsEnabled = false;
			this.webBrowser1.Size = new System.Drawing.Size(511, 69);
			this.webBrowser1.TabIndex = 2;
			this.webBrowser1.TabStop = false;
			this.webBrowser1.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowser1_DocumentCompleted);
			// 
			// SplashWindow
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 26F);
			this.BackColor = System.Drawing.Color.Aquamarine;
			this.ClientSize = new System.Drawing.Size(553, 351);
			this.Controls.Add(this.webBrowser1);
			this.Name = "SplashWindow";
			this.ShowInTaskbar = true;
			this.Controls.SetChildIndex(this.title, 0);
			this.Controls.SetChildIndex(this.Context, 0);
			this.Controls.SetChildIndex(this.webBrowser1, 0);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.WebBrowser webBrowser1;
	}
}

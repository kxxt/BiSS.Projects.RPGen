namespace BiSS.Projects.RPGen.Windows.Wizard
{
	partial class AppStartWindow
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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AppStartWindow));
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.metroTile5 = new MetroFramework.Controls.MetroTile();
			this.metroTile4 = new MetroFramework.Controls.MetroTile();
			this.metroTile3 = new MetroFramework.Controls.MetroTile();
			this.metroTile2 = new MetroFramework.Controls.MetroTile();
			this.metroTile1 = new MetroFramework.Controls.MetroTile();
			this.FlashTimer = new System.Windows.Forms.Timer(this.components);
			this.tableLayoutPanel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// subTitle
			// 
			this.subTitle.Location = new System.Drawing.Point(11, 36);
			this.subTitle.Size = new System.Drawing.Size(0, 21);
			this.subTitle.Text = "";
			this.subTitle.Visible = false;
			// 
			// title
			// 
			this.title.Location = new System.Drawing.Point(10, 6);
			this.title.Size = new System.Drawing.Size(0, 30);
			this.title.Text = "";
			this.title.Visible = false;
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 4;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.tableLayoutPanel1.Controls.Add(this.metroTile5, 3, 0);
			this.tableLayoutPanel1.Controls.Add(this.metroTile4, 3, 1);
			this.tableLayoutPanel1.Controls.Add(this.metroTile3, 0, 2);
			this.tableLayoutPanel1.Controls.Add(this.metroTile2, 2, 0);
			this.tableLayoutPanel1.Controls.Add(this.metroTile1, 0, 0);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(2, 2);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 3;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(695, 391);
			this.tableLayoutPanel1.TabIndex = 5;
			// 
			// metroTile5
			// 
			this.metroTile5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(0)))), ((int)(((byte)(79)))));
			this.metroTile5.CustomBackground = true;
			this.metroTile5.Dock = System.Windows.Forms.DockStyle.Fill;
			this.metroTile5.Location = new System.Drawing.Point(522, 3);
			this.metroTile5.Name = "metroTile5";
			this.metroTile5.Size = new System.Drawing.Size(170, 124);
			this.metroTile5.Style = MetroFramework.MetroColorStyle.Yellow;
			this.metroTile5.TabIndex = 4;
			this.metroTile5.Text = "使用帮助";
			this.metroTile5.TileImage = ((System.Drawing.Image)(resources.GetObject("metroTile5.TileImage")));
			this.metroTile5.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.metroTile5.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
			this.metroTile5.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
			this.metroTile5.UseTileImage = true;
			this.metroTile5.Click += new System.EventHandler(this.metroTile5_Click);
			// 
			// metroTile4
			// 
			this.metroTile4.Dock = System.Windows.Forms.DockStyle.Fill;
			this.metroTile4.Location = new System.Drawing.Point(522, 133);
			this.metroTile4.Name = "metroTile4";
			this.tableLayoutPanel1.SetRowSpan(this.metroTile4, 2);
			this.metroTile4.Size = new System.Drawing.Size(170, 255);
			this.metroTile4.Style = MetroFramework.MetroColorStyle.Pink;
			this.metroTile4.TabIndex = 3;
			this.metroTile4.Text = "检测更新";
			this.metroTile4.TileImage = ((System.Drawing.Image)(resources.GetObject("metroTile4.TileImage")));
			this.metroTile4.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.metroTile4.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
			this.metroTile4.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
			this.metroTile4.UseTileImage = true;
			this.metroTile4.Click += new System.EventHandler(this.metroTile4_Click);
			// 
			// metroTile3
			// 
			this.tableLayoutPanel1.SetColumnSpan(this.metroTile3, 3);
			this.metroTile3.Dock = System.Windows.Forms.DockStyle.Fill;
			this.metroTile3.Location = new System.Drawing.Point(3, 263);
			this.metroTile3.Name = "metroTile3";
			this.metroTile3.Size = new System.Drawing.Size(513, 125);
			this.metroTile3.Style = MetroFramework.MetroColorStyle.Purple;
			this.metroTile3.TabIndex = 2;
			this.metroTile3.Text = "用户许可协议及关于信息";
			this.metroTile3.TileImage = ((System.Drawing.Image)(resources.GetObject("metroTile3.TileImage")));
			this.metroTile3.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.metroTile3.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
			this.metroTile3.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
			this.metroTile3.UseTileImage = true;
			this.metroTile3.Click += new System.EventHandler(this.metroTile3_Click);
			// 
			// metroTile2
			// 
			this.metroTile2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.metroTile2.Location = new System.Drawing.Point(349, 3);
			this.metroTile2.Name = "metroTile2";
			this.tableLayoutPanel1.SetRowSpan(this.metroTile2, 2);
			this.metroTile2.Size = new System.Drawing.Size(167, 254);
			this.metroTile2.Style = MetroFramework.MetroColorStyle.Teal;
			this.metroTile2.TabIndex = 1;
			this.metroTile2.Text = "程序设置";
			this.metroTile2.TileImage = ((System.Drawing.Image)(resources.GetObject("metroTile2.TileImage")));
			this.metroTile2.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.metroTile2.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
			this.metroTile2.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
			this.metroTile2.UseTileImage = true;
			this.metroTile2.Click += new System.EventHandler(this.metroTile2_Click);
			// 
			// metroTile1
			// 
			this.tableLayoutPanel1.SetColumnSpan(this.metroTile1, 2);
			this.metroTile1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.metroTile1.Location = new System.Drawing.Point(3, 3);
			this.metroTile1.Name = "metroTile1";
			this.tableLayoutPanel1.SetRowSpan(this.metroTile1, 2);
			this.metroTile1.Size = new System.Drawing.Size(340, 254);
			this.metroTile1.TabIndex = 0;
			this.metroTile1.Text = "进入向导";
			this.metroTile1.TileImage = ((System.Drawing.Image)(resources.GetObject("metroTile1.TileImage")));
			this.metroTile1.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.metroTile1.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
			this.metroTile1.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
			this.metroTile1.UseTileImage = true;
			this.metroTile1.Click += new System.EventHandler(this.metroTile1_Click);
			// 
			// FlashTimer
			// 
			this.FlashTimer.Enabled = true;
			this.FlashTimer.Interval = 300;
			this.FlashTimer.Tag = "1";
			// 
			// AppStartWindow
			// 
			this.AcceptButton = this.metroTile1;
			this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
			this.ClientSize = new System.Drawing.Size(699, 395);
			this.Controls.Add(this.tableLayoutPanel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = true;
			this.Name = "AppStartWindow";
			this.Text = "成绩报告生成器";
			this.Shown += new System.EventHandler(this.AppStartWindow_Shown);
			this.Controls.SetChildIndex(this.tableLayoutPanel1, 0);
			this.Controls.SetChildIndex(this.title, 0);
			this.Controls.SetChildIndex(this.subTitle, 0);
			this.tableLayoutPanel1.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private MetroFramework.Controls.MetroTile metroTile1;
		private MetroFramework.Controls.MetroTile metroTile2;
		private MetroFramework.Controls.MetroTile metroTile3;
		private MetroFramework.Controls.MetroTile metroTile4;
		private MetroFramework.Controls.MetroTile metroTile5;
		private System.Windows.Forms.Timer FlashTimer;
	}
}
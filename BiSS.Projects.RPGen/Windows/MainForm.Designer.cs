namespace BiSS.Projects.RPGen.Windows
{
	partial class MainForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.Tile_XLS = new MetroFramework.Controls.MetroTile();
			this.metroTile1 = new MetroFramework.Controls.MetroTile();
			this.metroTile2 = new MetroFramework.Controls.MetroTile();
			this.metroTile3 = new MetroFramework.Controls.MetroTile();
			this.status_Textbox = new MetroFramework.Controls.MetroTextBox();
			this.statusTitleLabel = new MetroFramework.Controls.MetroLabel();
			this.metroTile4 = new MetroFramework.Controls.MetroTile();
			this.metroTile5 = new MetroFramework.Controls.MetroTile();
			this.metroTile6 = new MetroFramework.Controls.MetroTile();
			this.metroTile7 = new MetroFramework.Controls.MetroTile();
			this.metroTile8 = new MetroFramework.Controls.MetroTile();
			this.modernButton2 = new RsWork.UI.Controls.ModernButton();
			this.minbtn = new RsWork.UI.Controls.ModernButton();
			this.closebtn = new RsWork.UI.Controls.ModernButton();
			this.SuspendLayout();
			// 
			// Tile_XLS
			// 
			this.Tile_XLS.Location = new System.Drawing.Point(141, 63);
			this.Tile_XLS.Name = "Tile_XLS";
			this.Tile_XLS.Size = new System.Drawing.Size(297, 114);
			this.Tile_XLS.Style = MetroFramework.MetroColorStyle.Green;
			this.Tile_XLS.TabIndex = 8;
			this.Tile_XLS.Text = "填写Excel表单";
			this.Tile_XLS.Theme = MetroFramework.MetroThemeStyle.Dark;
			this.Tile_XLS.TileImage = ((System.Drawing.Image)(resources.GetObject("Tile_XLS.TileImage")));
			this.Tile_XLS.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.Tile_XLS.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
			this.Tile_XLS.UseTileImage = true;
			// 
			// metroTile1
			// 
			this.metroTile1.Location = new System.Drawing.Point(23, 183);
			this.metroTile1.Name = "metroTile1";
			this.metroTile1.Size = new System.Drawing.Size(137, 140);
			this.metroTile1.TabIndex = 9;
			this.metroTile1.Text = "程序设置";
			this.metroTile1.Theme = MetroFramework.MetroThemeStyle.Dark;
			this.metroTile1.TileImage = ((System.Drawing.Image)(resources.GetObject("metroTile1.TileImage")));
			this.metroTile1.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.metroTile1.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
			this.metroTile1.UseTileImage = true;
			// 
			// metroTile2
			// 
			this.metroTile2.Location = new System.Drawing.Point(444, 63);
			this.metroTile2.Name = "metroTile2";
			this.metroTile2.Size = new System.Drawing.Size(260, 260);
			this.metroTile2.Style = MetroFramework.MetroColorStyle.Purple;
			this.metroTile2.TabIndex = 10;
			this.metroTile2.Text = "导入成绩单";
			this.metroTile2.Theme = MetroFramework.MetroThemeStyle.Dark;
			this.metroTile2.TileImage = ((System.Drawing.Image)(resources.GetObject("metroTile2.TileImage")));
			this.metroTile2.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.metroTile2.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
			this.metroTile2.UseTileImage = true;
			// 
			// metroTile3
			// 
			this.metroTile3.Location = new System.Drawing.Point(166, 183);
			this.metroTile3.Name = "metroTile3";
			this.metroTile3.Size = new System.Drawing.Size(272, 140);
			this.metroTile3.Style = MetroFramework.MetroColorStyle.Lime;
			this.metroTile3.TabIndex = 11;
			this.metroTile3.Text = "使用帮助";
			this.metroTile3.Theme = MetroFramework.MetroThemeStyle.Dark;
			this.metroTile3.TileImage = ((System.Drawing.Image)(resources.GetObject("metroTile3.TileImage")));
			this.metroTile3.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.metroTile3.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
			this.metroTile3.UseTileImage = true;
			this.metroTile3.Click += new System.EventHandler(this.metroTile3_Click);
			// 
			// status_Textbox
			// 
			this.status_Textbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.status_Textbox.FontSize = MetroFramework.MetroTextBoxSize.Medium;
			this.status_Textbox.Location = new System.Drawing.Point(81, 653);
			this.status_Textbox.Name = "status_Textbox";
			this.status_Textbox.ReadOnly = true;
			this.status_Textbox.Size = new System.Drawing.Size(888, 25);
			this.status_Textbox.Style = MetroFramework.MetroColorStyle.Orange;
			this.status_Textbox.TabIndex = 12;
			this.status_Textbox.Text = "{$Doing_Status}";
			this.status_Textbox.Theme = MetroFramework.MetroThemeStyle.Dark;
			// 
			// statusTitleLabel
			// 
			this.statusTitleLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.statusTitleLabel.AutoSize = true;
			this.statusTitleLabel.FontSize = MetroFramework.MetroLabelSize.Tall;
			this.statusTitleLabel.Location = new System.Drawing.Point(23, 653);
			this.statusTitleLabel.Name = "statusTitleLabel";
			this.statusTitleLabel.Size = new System.Drawing.Size(52, 25);
			this.statusTitleLabel.TabIndex = 13;
			this.statusTitleLabel.Text = "状态:";
			this.statusTitleLabel.Theme = MetroFramework.MetroThemeStyle.Dark;
			this.statusTitleLabel.Click += new System.EventHandler(this.statusTitleLabel_Click);
			// 
			// metroTile4
			// 
			this.metroTile4.Location = new System.Drawing.Point(23, 329);
			this.metroTile4.Name = "metroTile4";
			this.metroTile4.Size = new System.Drawing.Size(349, 140);
			this.metroTile4.Style = MetroFramework.MetroColorStyle.Teal;
			this.metroTile4.TabIndex = 14;
			this.metroTile4.Text = "设置 输入输出 格式";
			this.metroTile4.Theme = MetroFramework.MetroThemeStyle.Dark;
			this.metroTile4.TileImage = ((System.Drawing.Image)(resources.GetObject("metroTile4.TileImage")));
			this.metroTile4.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.metroTile4.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
			this.metroTile4.UseTileImage = true;
			// 
			// metroTile5
			// 
			this.metroTile5.Location = new System.Drawing.Point(487, 475);
			this.metroTile5.Name = "metroTile5";
			this.metroTile5.Size = new System.Drawing.Size(217, 172);
			this.metroTile5.Style = MetroFramework.MetroColorStyle.Silver;
			this.metroTile5.TabIndex = 15;
			this.metroTile5.Text = "本项目 GitHub";
			this.metroTile5.Theme = MetroFramework.MetroThemeStyle.Dark;
			this.metroTile5.TileImage = ((System.Drawing.Image)(resources.GetObject("metroTile5.TileImage")));
			this.metroTile5.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.metroTile5.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
			this.metroTile5.UseTileImage = true;
			this.metroTile5.Click += new System.EventHandler(this.metroTile5_Click);
			// 
			// metroTile6
			// 
			this.metroTile6.CustomForeColor = true;
			this.metroTile6.ForeColor = System.Drawing.Color.Black;
			this.metroTile6.Location = new System.Drawing.Point(23, 475);
			this.metroTile6.Name = "metroTile6";
			this.metroTile6.Size = new System.Drawing.Size(262, 172);
			this.metroTile6.Style = MetroFramework.MetroColorStyle.White;
			this.metroTile6.TabIndex = 16;
			this.metroTile6.Text = "关于\r\nBelievers in Science Studio";
			this.metroTile6.Theme = MetroFramework.MetroThemeStyle.Dark;
			this.metroTile6.TileImage = ((System.Drawing.Image)(resources.GetObject("metroTile6.TileImage")));
			this.metroTile6.TileImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.metroTile6.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
			this.metroTile6.UseTileImage = true;
			this.metroTile6.Click += new System.EventHandler(this.metroTile6_Click);
			// 
			// metroTile7
			// 
			this.metroTile7.Location = new System.Drawing.Point(23, 63);
			this.metroTile7.Name = "metroTile7";
			this.metroTile7.Size = new System.Drawing.Size(112, 114);
			this.metroTile7.Style = MetroFramework.MetroColorStyle.Pink;
			this.metroTile7.TabIndex = 17;
			this.metroTile7.Text = "检测更新";
			this.metroTile7.Theme = MetroFramework.MetroThemeStyle.Dark;
			this.metroTile7.TileImage = ((System.Drawing.Image)(resources.GetObject("metroTile7.TileImage")));
			this.metroTile7.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.metroTile7.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
			this.metroTile7.UseTileImage = true;
			this.metroTile7.Click += new System.EventHandler(this.metroTile7_Click);
			// 
			// metroTile8
			// 
			this.metroTile8.Location = new System.Drawing.Point(291, 514);
			this.metroTile8.Name = "metroTile8";
			this.metroTile8.Size = new System.Drawing.Size(190, 133);
			this.metroTile8.Style = MetroFramework.MetroColorStyle.Orange;
			this.metroTile8.TabIndex = 18;
			this.metroTile8.Text = "作者的其他App";
			this.metroTile8.Theme = MetroFramework.MetroThemeStyle.Dark;
			this.metroTile8.TileImage = ((System.Drawing.Image)(resources.GetObject("metroTile8.TileImage")));
			this.metroTile8.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.metroTile8.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
			this.metroTile8.UseTileImage = true;
			// 
			// modernButton2
			// 
			this.modernButton2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.modernButton2.BackColor = System.Drawing.Color.Transparent;
			this.modernButton2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(73)))), ((int)(((byte)(16)))));
			this.modernButton2.DisabledBorderColor = System.Drawing.Color.DarkGray;
			this.modernButton2.DisabledForeColor = System.Drawing.Color.DarkGray;
			this.modernButton2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(73)))), ((int)(((byte)(16)))));
			this.modernButton2.FlatAppearance.BorderSize = 2;
			this.modernButton2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.modernButton2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
			this.modernButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.modernButton2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.modernButton2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(73)))), ((int)(((byte)(16)))));
			this.modernButton2.Location = new System.Drawing.Point(861, 10);
			this.modernButton2.Name = "modernButton2";
			this.modernButton2.Size = new System.Drawing.Size(32, 32);
			this.modernButton2.TabIndex = 5;
			this.modernButton2.Text = "T";
			this.modernButton2.UseVisualStyleBackColor = false;
			this.modernButton2.Click += new System.EventHandler(this.modernButton2_Click);
			// 
			// minbtn
			// 
			this.minbtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.minbtn.BackColor = System.Drawing.Color.Transparent;
			this.minbtn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(73)))), ((int)(((byte)(16)))));
			this.minbtn.DisabledBorderColor = System.Drawing.Color.DarkGray;
			this.minbtn.DisabledForeColor = System.Drawing.Color.DarkGray;
			this.minbtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(73)))), ((int)(((byte)(16)))));
			this.minbtn.FlatAppearance.BorderSize = 2;
			this.minbtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.minbtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
			this.minbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.minbtn.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.minbtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(73)))), ((int)(((byte)(16)))));
			this.minbtn.Location = new System.Drawing.Point(899, 10);
			this.minbtn.Name = "minbtn";
			this.minbtn.Size = new System.Drawing.Size(32, 32);
			this.minbtn.TabIndex = 3;
			this.minbtn.Text = "-";
			this.minbtn.UseVisualStyleBackColor = false;
			this.minbtn.Click += new System.EventHandler(this.minbtn_Click);
			// 
			// closebtn
			// 
			this.closebtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.closebtn.BackColor = System.Drawing.Color.Transparent;
			this.closebtn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(73)))), ((int)(((byte)(16)))));
			this.closebtn.DisabledBorderColor = System.Drawing.Color.DarkGray;
			this.closebtn.DisabledForeColor = System.Drawing.Color.DarkGray;
			this.closebtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(73)))), ((int)(((byte)(16)))));
			this.closebtn.FlatAppearance.BorderSize = 2;
			this.closebtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.closebtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
			this.closebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.closebtn.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.closebtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(73)))), ((int)(((byte)(16)))));
			this.closebtn.Location = new System.Drawing.Point(937, 10);
			this.closebtn.Name = "closebtn";
			this.closebtn.Size = new System.Drawing.Size(32, 32);
			this.closebtn.TabIndex = 2;
			this.closebtn.Text = "X";
			this.closebtn.UseVisualStyleBackColor = false;
			this.closebtn.Click += new System.EventHandler(this.closebtn_Click);
			// 
			// MainForm
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.ClientSize = new System.Drawing.Size(976, 701);
			this.ControlBox = false;
			this.Controls.Add(this.metroTile8);
			this.Controls.Add(this.metroTile7);
			this.Controls.Add(this.metroTile6);
			this.Controls.Add(this.metroTile5);
			this.Controls.Add(this.metroTile4);
			this.Controls.Add(this.statusTitleLabel);
			this.Controls.Add(this.status_Textbox);
			this.Controls.Add(this.metroTile3);
			this.Controls.Add(this.metroTile2);
			this.Controls.Add(this.metroTile1);
			this.Controls.Add(this.Tile_XLS);
			this.Controls.Add(this.modernButton2);
			this.Controls.Add(this.minbtn);
			this.Controls.Add(this.closebtn);
			this.Font = new System.Drawing.Font("微软雅黑 Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "MainForm";
			this.Resizable = false;
			this.ShadowType = MetroFramework.Forms.MetroForm.MetroFormShadowType.Flat;
			this.Style = MetroFramework.MetroColorStyle.Orange;
			this.Text = "Believers in Science Studio 成绩报告生成器";
			this.Theme = MetroFramework.MetroThemeStyle.Dark;
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private RsWork.UI.Controls.ModernButton closebtn;
		private RsWork.UI.Controls.ModernButton minbtn;
		private RsWork.UI.Controls.ModernButton modernButton2;
		private MetroFramework.Controls.MetroTile Tile_XLS;
		private MetroFramework.Controls.MetroTile metroTile1;
		private MetroFramework.Controls.MetroTile metroTile2;
		private MetroFramework.Controls.MetroTile metroTile3;
		private MetroFramework.Controls.MetroTextBox status_Textbox;
		private MetroFramework.Controls.MetroLabel statusTitleLabel;
		private MetroFramework.Controls.MetroTile metroTile4;
		private MetroFramework.Controls.MetroTile metroTile5;
		private MetroFramework.Controls.MetroTile metroTile6;
		private MetroFramework.Controls.MetroTile metroTile7;
		private MetroFramework.Controls.MetroTile metroTile8;
	}
}


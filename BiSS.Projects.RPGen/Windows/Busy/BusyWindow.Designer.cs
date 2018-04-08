namespace BiSS.Projects.RPGen.Windows.Busy
{
	partial class BusyWindow
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
			this.timer = new System.Windows.Forms.Timer(this.components);
			this.metroProgressSpinner2 = new MetroFramework.Controls.MetroProgressSpinner();
			this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
			this.Worker = new System.ComponentModel.BackgroundWorker();
			this.SuspendLayout();
			// 
			// timer
			// 
			this.timer.Interval = 1000;
			this.timer.Tick += new System.EventHandler(this.timer1_Tick);
			// 
			// metroProgressSpinner2
			// 
			this.metroProgressSpinner2.Location = new System.Drawing.Point(140, 65);
			this.metroProgressSpinner2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.metroProgressSpinner2.Maximum = 360;
			this.metroProgressSpinner2.Name = "metroProgressSpinner2";
			this.metroProgressSpinner2.Size = new System.Drawing.Size(295, 295);
			this.metroProgressSpinner2.Speed = 3F;
			this.metroProgressSpinner2.Style = MetroFramework.MetroColorStyle.Orange;
			this.metroProgressSpinner2.TabIndex = 1;
			this.metroProgressSpinner2.Theme = MetroFramework.MetroThemeStyle.Dark;
			this.metroProgressSpinner2.Value = 45;
			this.metroProgressSpinner2.Click += new System.EventHandler(this.metroProgressSpinner2_Click);
			// 
			// metroLabel1
			// 
			this.metroLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.metroLabel1.AutoSize = true;
			this.metroLabel1.BackColor = System.Drawing.Color.Black;
			this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
			this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
			this.metroLabel1.LabelMode = MetroFramework.Controls.MetroLabelMode.Selectable;
			this.metroLabel1.Location = new System.Drawing.Point(235, 392);
			this.metroLabel1.Name = "metroLabel1";
			this.metroLabel1.Size = new System.Drawing.Size(119, 25);
			this.metroLabel1.Style = MetroFramework.MetroColorStyle.Black;
			this.metroLabel1.TabIndex = 2;
			this.metroLabel1.Text = "正在加载中...";
			this.metroLabel1.Theme = MetroFramework.MetroThemeStyle.Dark;
			// 
			// BusyWindow
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
			this.ClientSize = new System.Drawing.Size(615, 423);
			this.ControlBox = false;
			this.Controls.Add(this.metroLabel1);
			this.Controls.Add(this.metroProgressSpinner2);
			this.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.MaximizeBox = false;
			this.Name = "BusyWindow";
			this.ShowIcon = false;
			this.Style.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
			this.Text = "正在加载中,请稍候....";
			this.Load += new System.EventHandler(this.BusyWindow_Load);
			this.Shown += new System.EventHandler(this.BusyWindow_Shown);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Timer timer;
		private MetroFramework.Controls.MetroProgressSpinner metroProgressSpinner2;
		private MetroFramework.Controls.MetroLabel metroLabel1;
		public System.ComponentModel.BackgroundWorker Worker;
	}
}
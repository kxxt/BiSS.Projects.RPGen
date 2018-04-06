namespace BiSS.Projects.RPGen.Windows.Wizard
{
	partial class DialogWindows10
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DialogWindows10));
			this.subTitle = new System.Windows.Forms.Label();
			this.title = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// subTitle
			// 
			this.subTitle.AutoSize = true;
			this.subTitle.Font = new System.Drawing.Font("微软雅黑", 12F);
			this.subTitle.ForeColor = System.Drawing.Color.Orange;
			this.subTitle.Location = new System.Drawing.Point(9, 34);
			this.subTitle.Name = "subTitle";
			this.subTitle.Size = new System.Drawing.Size(71, 21);
			this.subTitle.TabIndex = 4;
			this.subTitle.Text = "sub title";
			// 
			// title
			// 
			this.title.AutoSize = true;
			this.title.Font = new System.Drawing.Font("微软雅黑", 17F);
			this.title.Location = new System.Drawing.Point(8, 4);
			this.title.Name = "title";
			this.title.Size = new System.Drawing.Size(60, 30);
			this.title.TabIndex = 3;
			this.title.Text = "Text";
			// 
			// DialogWindows10
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
			this.ClientSize = new System.Drawing.Size(642, 204);
			this.Controls.Add(this.subTitle);
			this.Controls.Add(this.title);
			this.DoubleBuffered = true;
			this.Font = new System.Drawing.Font("微软雅黑 Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.MaximizeBox = false;
			this.Name = "DialogWindows10";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Window Title";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		public System.Windows.Forms.Label subTitle;
		public System.Windows.Forms.Label title;
	}
}
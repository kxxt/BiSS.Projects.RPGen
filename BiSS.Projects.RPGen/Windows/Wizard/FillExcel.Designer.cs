namespace BiSS.Projects.RPGen.Windows.Wizard
{
	partial class FillExcel
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
			this.sfButton1 = new Syncfusion.WinForms.Controls.SfButton();
			this.SuspendLayout();
			// 
			// subtitle
			// 
			this.subtitle.Size = new System.Drawing.Size(581, 63);
			this.subtitle.Text = "应用程序将启动 Excel , 请填写此表格 , 您可以把原成绩表中的数据复制到此表中.\r\n注意:请勿修改列标题及列的顺序 ! \r\n请在填写完成后保存文件并关闭 " +
    "Excel 窗口,返回到本程序中继续操作.";
			// 
			// title
			// 
			this.title.Size = new System.Drawing.Size(611, 30);
			this.title.Text = "在接下来的过程中,你将填写一份固定格式的Excel 成绩表单";
			// 
			// sfButton1
			// 
			this.sfButton1.AccessibleName = "Button";
			this.sfButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.sfButton1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
			this.sfButton1.Location = new System.Drawing.Point(723, 104);
			this.sfButton1.Name = "sfButton1";
			this.sfButton1.Size = new System.Drawing.Size(113, 40);
			this.sfButton1.TabIndex = 0;
			this.sfButton1.Text = "启动 Excel";
			this.sfButton1.Click += new System.EventHandler(this.sfButton1_Click);
			// 
			// FillExcel
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.ClientSize = new System.Drawing.Size(839, 149);
			this.Controls.Add(this.sfButton1);
			this.Name = "FillExcel";
			this.Text = "填写Excel";
			this.Controls.SetChildIndex(this.title, 0);
			this.Controls.SetChildIndex(this.subtitle, 0);
			this.Controls.SetChildIndex(this.sfButton1, 0);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Syncfusion.WinForms.Controls.SfButton sfButton1;
	}
}
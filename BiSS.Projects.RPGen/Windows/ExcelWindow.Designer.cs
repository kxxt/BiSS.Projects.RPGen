namespace BiSS.Projects.RPGen.Windows
{
	partial class ExcelWindow
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
			Syncfusion.Windows.Forms.Spreadsheet.SpreadsheetCopyPaste spreadsheetCopyPaste1 = new Syncfusion.Windows.Forms.Spreadsheet.SpreadsheetCopyPaste();
			Syncfusion.Windows.Forms.Spreadsheet.FormulaRangeSelectionController formulaRangeSelectionController1 = new Syncfusion.Windows.Forms.Spreadsheet.FormulaRangeSelectionController();
			this.spreadsheet1 = new Syncfusion.Windows.Forms.Spreadsheet.Spreadsheet();
			this.SuspendLayout();
			// 
			// spreadsheet1
			// 
			this.spreadsheet1.AllowCellContextMenu = false;
			this.spreadsheet1.AllowExtendRowColumnCount = true;
			this.spreadsheet1.AllowFormulaRangeSelection = true;
			this.spreadsheet1.AllowTabItemContextMenu = false;
			this.spreadsheet1.AllowZooming = true;
			spreadsheetCopyPaste1.AllowPasteOptionPopup = true;
			spreadsheetCopyPaste1.DefaultPasteOption = Syncfusion.Windows.Forms.Spreadsheet.PasteOptions.Paste;
			this.spreadsheet1.CopyPaste = spreadsheetCopyPaste1;
			this.spreadsheet1.DefaultColumnCount = 101;
			this.spreadsheet1.DefaultRowCount = 101;
			this.spreadsheet1.DisplayAlerts = true;
			this.spreadsheet1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.spreadsheet1.FileName = "Book1";
			this.spreadsheet1.FormulaBarVisibility = true;
			formulaRangeSelectionController1.AllowMouseSelection = true;
			formulaRangeSelectionController1.AllowSelectionOnEditing = true;
			this.spreadsheet1.FormulaRangeSelectionController = formulaRangeSelectionController1;
			this.spreadsheet1.IsCustomTabItemContextMenuEnabled = false;
			this.spreadsheet1.Location = new System.Drawing.Point(2, 2);
			this.spreadsheet1.Name = "spreadsheet1";
			this.spreadsheet1.SelectedTabIndex = 0;
			this.spreadsheet1.SelectedTabItem = null;
			this.spreadsheet1.ShowBusyIndicator = true;
			this.spreadsheet1.Size = new System.Drawing.Size(920, 563);
			this.spreadsheet1.TabIndex = 0;
			this.spreadsheet1.TabItemContextMenu = null;
			this.spreadsheet1.Text = "spreadsheet1";
			this.spreadsheet1.ThemeName = "Office365";
			// 
			// ExcelWindow
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(924, 567);
			this.Controls.Add(this.spreadsheet1);
			this.Name = "ExcelWindow";
			this.Text = "ExcelWindow";
			this.ResumeLayout(false);

		}

		#endregion

		public Syncfusion.Windows.Forms.Spreadsheet.Spreadsheet spreadsheet1;
	}
}
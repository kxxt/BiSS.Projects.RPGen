using System.Windows.Forms;

namespace BiSS.Projects.RPGen.Windows
{
	partial class GridWindow
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
			this.dataGridView = new System.Windows.Forms.DataGridView();
			this.SumRank = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.SumGradeRank = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.sumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.zhDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.zhRankDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.zhGradeRankDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.mDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.mRankDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.mGradeRankDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.enDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.enRankDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.enGradeRankDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.pDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.pRankDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.pGradeRankDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.cDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.cRankDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.cGradeRankDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.poDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.poRankDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.poGradeRankDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.hDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.hRankDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.hGradeRankDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.gDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.gRankDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.gGradeRankDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.bDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.bRankDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.bGradeRankDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.displayObjectBindingSource = new System.Windows.Forms.BindingSource(this.components);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.displayObjectBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// dataGridView
			// 
			this.dataGridView.AutoGenerateColumns = false;
			this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
			this.dataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
			this.dataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
			this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.sumDataGridViewTextBoxColumn,
            this.SumRank,
            this.SumGradeRank,
            this.zhDataGridViewTextBoxColumn,
            this.zhRankDataGridViewTextBoxColumn,
            this.zhGradeRankDataGridViewTextBoxColumn,
            this.mDataGridViewTextBoxColumn,
            this.mRankDataGridViewTextBoxColumn,
            this.mGradeRankDataGridViewTextBoxColumn,
            this.enDataGridViewTextBoxColumn,
            this.enRankDataGridViewTextBoxColumn,
            this.enGradeRankDataGridViewTextBoxColumn,
            this.pDataGridViewTextBoxColumn,
            this.pRankDataGridViewTextBoxColumn,
            this.pGradeRankDataGridViewTextBoxColumn,
            this.cDataGridViewTextBoxColumn,
            this.cRankDataGridViewTextBoxColumn,
            this.cGradeRankDataGridViewTextBoxColumn,
            this.poDataGridViewTextBoxColumn,
            this.poRankDataGridViewTextBoxColumn,
            this.poGradeRankDataGridViewTextBoxColumn,
            this.hDataGridViewTextBoxColumn,
            this.hRankDataGridViewTextBoxColumn,
            this.hGradeRankDataGridViewTextBoxColumn,
            this.gDataGridViewTextBoxColumn,
            this.gRankDataGridViewTextBoxColumn,
            this.gGradeRankDataGridViewTextBoxColumn,
            this.bDataGridViewTextBoxColumn,
            this.bRankDataGridViewTextBoxColumn,
            this.bGradeRankDataGridViewTextBoxColumn});
			this.dataGridView.DataSource = this.displayObjectBindingSource;
			this.dataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
			this.dataGridView.Location = new System.Drawing.Point(20, 60);
			this.dataGridView.Name = "dataGridView";
			this.dataGridView.RowTemplate.Height = 23;
			this.dataGridView.Size = new System.Drawing.Size(857, 634);
			this.dataGridView.TabIndex = 0;
			this.dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellContentClick);
			this.dataGridView.ColumnWidthChanged += new System.Windows.Forms.DataGridViewColumnEventHandler(this.dataGridView_ColumnWidthChanged);
			this.dataGridView.Paint += new System.Windows.Forms.PaintEventHandler(this.dataGridView_Paint);
			// 
			// SumRank
			// 
			this.SumRank.DataPropertyName = "SumRank";
			this.SumRank.HeaderText = "班名次";
			this.SumRank.Name = "SumRank";
			this.SumRank.Width = 76;
			// 
			// SumGradeRank
			// 
			this.SumGradeRank.DataPropertyName = "SumGradeRank";
			this.SumGradeRank.HeaderText = "级名次";
			this.SumGradeRank.Name = "SumGradeRank";
			this.SumGradeRank.Width = 76;
			// 
			// idDataGridViewTextBoxColumn
			// 
			this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
			this.idDataGridViewTextBoxColumn.HeaderText = "#";
			this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
			this.idDataGridViewTextBoxColumn.Width = 43;
			// 
			// nameDataGridViewTextBoxColumn
			// 
			this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
			this.nameDataGridViewTextBoxColumn.HeaderText = "姓名";
			this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
			this.nameDataGridViewTextBoxColumn.Width = 62;
			// 
			// sumDataGridViewTextBoxColumn
			// 
			this.sumDataGridViewTextBoxColumn.DataPropertyName = "Sum";
			this.sumDataGridViewTextBoxColumn.HeaderText = "总分";
			this.sumDataGridViewTextBoxColumn.Name = "sumDataGridViewTextBoxColumn";
			this.sumDataGridViewTextBoxColumn.ReadOnly = true;
			this.sumDataGridViewTextBoxColumn.Width = 62;
			// 
			// zhDataGridViewTextBoxColumn
			// 
			this.zhDataGridViewTextBoxColumn.DataPropertyName = "Zh";
			this.zhDataGridViewTextBoxColumn.HeaderText = "语文";
			this.zhDataGridViewTextBoxColumn.Name = "zhDataGridViewTextBoxColumn";
			this.zhDataGridViewTextBoxColumn.Width = 62;
			// 
			// zhRankDataGridViewTextBoxColumn
			// 
			this.zhRankDataGridViewTextBoxColumn.DataPropertyName = "ZhRank";
			this.zhRankDataGridViewTextBoxColumn.HeaderText = "班名次";
			this.zhRankDataGridViewTextBoxColumn.Name = "zhRankDataGridViewTextBoxColumn";
			this.zhRankDataGridViewTextBoxColumn.Width = 76;
			// 
			// zhGradeRankDataGridViewTextBoxColumn
			// 
			this.zhGradeRankDataGridViewTextBoxColumn.DataPropertyName = "ZhGradeRank";
			this.zhGradeRankDataGridViewTextBoxColumn.HeaderText = "级名次";
			this.zhGradeRankDataGridViewTextBoxColumn.Name = "zhGradeRankDataGridViewTextBoxColumn";
			this.zhGradeRankDataGridViewTextBoxColumn.Width = 76;
			// 
			// mDataGridViewTextBoxColumn
			// 
			this.mDataGridViewTextBoxColumn.DataPropertyName = "M";
			this.mDataGridViewTextBoxColumn.HeaderText = "数学";
			this.mDataGridViewTextBoxColumn.Name = "mDataGridViewTextBoxColumn";
			this.mDataGridViewTextBoxColumn.Width = 62;
			// 
			// mRankDataGridViewTextBoxColumn
			// 
			this.mRankDataGridViewTextBoxColumn.DataPropertyName = "MRank";
			this.mRankDataGridViewTextBoxColumn.HeaderText = "班名次";
			this.mRankDataGridViewTextBoxColumn.Name = "mRankDataGridViewTextBoxColumn";
			this.mRankDataGridViewTextBoxColumn.Width = 76;
			// 
			// mGradeRankDataGridViewTextBoxColumn
			// 
			this.mGradeRankDataGridViewTextBoxColumn.DataPropertyName = "MGradeRank";
			this.mGradeRankDataGridViewTextBoxColumn.HeaderText = "级名次";
			this.mGradeRankDataGridViewTextBoxColumn.Name = "mGradeRankDataGridViewTextBoxColumn";
			this.mGradeRankDataGridViewTextBoxColumn.Width = 76;
			// 
			// enDataGridViewTextBoxColumn
			// 
			this.enDataGridViewTextBoxColumn.DataPropertyName = "En";
			this.enDataGridViewTextBoxColumn.HeaderText = "英语";
			this.enDataGridViewTextBoxColumn.Name = "enDataGridViewTextBoxColumn";
			this.enDataGridViewTextBoxColumn.Width = 62;
			// 
			// enRankDataGridViewTextBoxColumn
			// 
			this.enRankDataGridViewTextBoxColumn.DataPropertyName = "EnRank";
			this.enRankDataGridViewTextBoxColumn.HeaderText = "班名次";
			this.enRankDataGridViewTextBoxColumn.Name = "enRankDataGridViewTextBoxColumn";
			this.enRankDataGridViewTextBoxColumn.Width = 76;
			// 
			// enGradeRankDataGridViewTextBoxColumn
			// 
			this.enGradeRankDataGridViewTextBoxColumn.DataPropertyName = "EnGradeRank";
			this.enGradeRankDataGridViewTextBoxColumn.HeaderText = "级名次";
			this.enGradeRankDataGridViewTextBoxColumn.Name = "enGradeRankDataGridViewTextBoxColumn";
			this.enGradeRankDataGridViewTextBoxColumn.Width = 76;
			// 
			// pDataGridViewTextBoxColumn
			// 
			this.pDataGridViewTextBoxColumn.DataPropertyName = "P";
			this.pDataGridViewTextBoxColumn.HeaderText = "物理";
			this.pDataGridViewTextBoxColumn.Name = "pDataGridViewTextBoxColumn";
			this.pDataGridViewTextBoxColumn.Width = 62;
			// 
			// pRankDataGridViewTextBoxColumn
			// 
			this.pRankDataGridViewTextBoxColumn.DataPropertyName = "PRank";
			this.pRankDataGridViewTextBoxColumn.HeaderText = "班名次";
			this.pRankDataGridViewTextBoxColumn.Name = "pRankDataGridViewTextBoxColumn";
			this.pRankDataGridViewTextBoxColumn.Width = 76;
			// 
			// pGradeRankDataGridViewTextBoxColumn
			// 
			this.pGradeRankDataGridViewTextBoxColumn.DataPropertyName = "PGradeRank";
			this.pGradeRankDataGridViewTextBoxColumn.HeaderText = "级名次";
			this.pGradeRankDataGridViewTextBoxColumn.Name = "pGradeRankDataGridViewTextBoxColumn";
			this.pGradeRankDataGridViewTextBoxColumn.Width = 76;
			// 
			// cDataGridViewTextBoxColumn
			// 
			this.cDataGridViewTextBoxColumn.DataPropertyName = "C";
			this.cDataGridViewTextBoxColumn.HeaderText = "化学";
			this.cDataGridViewTextBoxColumn.Name = "cDataGridViewTextBoxColumn";
			this.cDataGridViewTextBoxColumn.Width = 62;
			// 
			// cRankDataGridViewTextBoxColumn
			// 
			this.cRankDataGridViewTextBoxColumn.DataPropertyName = "CRank";
			this.cRankDataGridViewTextBoxColumn.HeaderText = "班名次";
			this.cRankDataGridViewTextBoxColumn.Name = "cRankDataGridViewTextBoxColumn";
			this.cRankDataGridViewTextBoxColumn.Width = 76;
			// 
			// cGradeRankDataGridViewTextBoxColumn
			// 
			this.cGradeRankDataGridViewTextBoxColumn.DataPropertyName = "CGradeRank";
			this.cGradeRankDataGridViewTextBoxColumn.HeaderText = "级名次";
			this.cGradeRankDataGridViewTextBoxColumn.Name = "cGradeRankDataGridViewTextBoxColumn";
			this.cGradeRankDataGridViewTextBoxColumn.Width = 76;
			// 
			// poDataGridViewTextBoxColumn
			// 
			this.poDataGridViewTextBoxColumn.DataPropertyName = "Po";
			this.poDataGridViewTextBoxColumn.HeaderText = "政治";
			this.poDataGridViewTextBoxColumn.Name = "poDataGridViewTextBoxColumn";
			this.poDataGridViewTextBoxColumn.Width = 62;
			// 
			// poRankDataGridViewTextBoxColumn
			// 
			this.poRankDataGridViewTextBoxColumn.DataPropertyName = "PoRank";
			this.poRankDataGridViewTextBoxColumn.HeaderText = "班名次";
			this.poRankDataGridViewTextBoxColumn.Name = "poRankDataGridViewTextBoxColumn";
			this.poRankDataGridViewTextBoxColumn.Width = 76;
			// 
			// poGradeRankDataGridViewTextBoxColumn
			// 
			this.poGradeRankDataGridViewTextBoxColumn.DataPropertyName = "PoGradeRank";
			this.poGradeRankDataGridViewTextBoxColumn.HeaderText = "级名次";
			this.poGradeRankDataGridViewTextBoxColumn.Name = "poGradeRankDataGridViewTextBoxColumn";
			this.poGradeRankDataGridViewTextBoxColumn.Width = 76;
			// 
			// hDataGridViewTextBoxColumn
			// 
			this.hDataGridViewTextBoxColumn.DataPropertyName = "H";
			this.hDataGridViewTextBoxColumn.HeaderText = "历史";
			this.hDataGridViewTextBoxColumn.Name = "hDataGridViewTextBoxColumn";
			this.hDataGridViewTextBoxColumn.Width = 62;
			// 
			// hRankDataGridViewTextBoxColumn
			// 
			this.hRankDataGridViewTextBoxColumn.DataPropertyName = "HRank";
			this.hRankDataGridViewTextBoxColumn.HeaderText = "班名次";
			this.hRankDataGridViewTextBoxColumn.Name = "hRankDataGridViewTextBoxColumn";
			this.hRankDataGridViewTextBoxColumn.Width = 76;
			// 
			// hGradeRankDataGridViewTextBoxColumn
			// 
			this.hGradeRankDataGridViewTextBoxColumn.DataPropertyName = "HGradeRank";
			this.hGradeRankDataGridViewTextBoxColumn.HeaderText = "级名次";
			this.hGradeRankDataGridViewTextBoxColumn.Name = "hGradeRankDataGridViewTextBoxColumn";
			this.hGradeRankDataGridViewTextBoxColumn.Width = 76;
			// 
			// gDataGridViewTextBoxColumn
			// 
			this.gDataGridViewTextBoxColumn.DataPropertyName = "G";
			this.gDataGridViewTextBoxColumn.HeaderText = "地理";
			this.gDataGridViewTextBoxColumn.Name = "gDataGridViewTextBoxColumn";
			this.gDataGridViewTextBoxColumn.Width = 62;
			// 
			// gRankDataGridViewTextBoxColumn
			// 
			this.gRankDataGridViewTextBoxColumn.DataPropertyName = "GRank";
			this.gRankDataGridViewTextBoxColumn.HeaderText = "班名次";
			this.gRankDataGridViewTextBoxColumn.Name = "gRankDataGridViewTextBoxColumn";
			this.gRankDataGridViewTextBoxColumn.Width = 76;
			// 
			// gGradeRankDataGridViewTextBoxColumn
			// 
			this.gGradeRankDataGridViewTextBoxColumn.DataPropertyName = "GGradeRank";
			this.gGradeRankDataGridViewTextBoxColumn.HeaderText = "级名次";
			this.gGradeRankDataGridViewTextBoxColumn.Name = "gGradeRankDataGridViewTextBoxColumn";
			this.gGradeRankDataGridViewTextBoxColumn.Width = 76;
			// 
			// bDataGridViewTextBoxColumn
			// 
			this.bDataGridViewTextBoxColumn.DataPropertyName = "B";
			this.bDataGridViewTextBoxColumn.HeaderText = "生物";
			this.bDataGridViewTextBoxColumn.Name = "bDataGridViewTextBoxColumn";
			this.bDataGridViewTextBoxColumn.Width = 62;
			// 
			// bRankDataGridViewTextBoxColumn
			// 
			this.bRankDataGridViewTextBoxColumn.DataPropertyName = "BRank";
			this.bRankDataGridViewTextBoxColumn.HeaderText = "班名次";
			this.bRankDataGridViewTextBoxColumn.Name = "bRankDataGridViewTextBoxColumn";
			this.bRankDataGridViewTextBoxColumn.Width = 76;
			// 
			// bGradeRankDataGridViewTextBoxColumn
			// 
			this.bGradeRankDataGridViewTextBoxColumn.DataPropertyName = "BGradeRank";
			this.bGradeRankDataGridViewTextBoxColumn.HeaderText = "级名次";
			this.bGradeRankDataGridViewTextBoxColumn.Name = "bGradeRankDataGridViewTextBoxColumn";
			this.bGradeRankDataGridViewTextBoxColumn.Width = 76;
			// 
			// displayObjectBindingSource
			// 
			this.displayObjectBindingSource.DataSource = typeof(BiSS.Projects.RPGen.Structure.DisplayObject);
			this.displayObjectBindingSource.CurrentChanged += new System.EventHandler(this.displayObjectBindingSource_CurrentChanged);
			// 
			// GridWindow
			// 
			this.ClientSize = new System.Drawing.Size(897, 714);
			this.Controls.Add(this.dataGridView);
			this.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.Name = "GridWindow";
			this.Style = MetroFramework.MetroColorStyle.Orange;
			this.Text = "{$Window Title}";
			this.Theme = MetroFramework.MetroThemeStyle.Dark;
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GridWindow_FormClosing);
			this.Shown += new System.EventHandler(this.GridWindow_Shown);
			this.VisibleChanged += new System.EventHandler(this.GridWindow_VisibleChanged);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.displayObjectBindingSource)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridView dataGridView;
		private BindingSource displayObjectBindingSource;
		private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn sumDataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn SumRank;
		private DataGridViewTextBoxColumn SumGradeRank;
		private DataGridViewTextBoxColumn zhDataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn zhRankDataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn zhGradeRankDataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn mDataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn mRankDataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn mGradeRankDataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn enDataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn enRankDataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn enGradeRankDataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn pDataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn pRankDataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn pGradeRankDataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn cDataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn cRankDataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn cGradeRankDataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn poDataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn poRankDataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn poGradeRankDataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn hDataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn hRankDataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn hGradeRankDataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn gDataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn gRankDataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn gGradeRankDataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn bDataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn bRankDataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn bGradeRankDataGridViewTextBoxColumn;
	}
}

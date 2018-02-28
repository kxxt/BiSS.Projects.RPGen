using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RsWork.UI.Technologies;
using Spire.Xls;

namespace BiSS.Projects.RPGen.Op
{
	public class ExcelOperator
	{
		private Workbook workBook=new Workbook();
		public ExcelOperator(string path,int sheetid)
		{
			WorkBook.LoadFromFile(path);
			WorkBook.ActiveSheetIndex = sheetid;
		}

		public bool ReadBool(int row, int col)
		{
			return WorkBook.ActiveSheet.GetBoolean(row, col);
		}
		public double ReadDouble(int row, int col)
		{
			return WorkBook.ActiveSheet.GetNumber(row, col);
		}
		public string ReadString(int row, int col)
		{
			return WorkBook.ActiveSheet.GetFormulaStringValue(row, col);
		}
		public Workbook WorkBook { get => this.workBook; set => this.workBook = value; }
	}
}

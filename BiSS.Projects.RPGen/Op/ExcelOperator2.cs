using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Syncfusion.Windows.Forms.Spreadsheet;
using Syncfusion.XlsIO;
namespace BiSS.Projects.RPGen.Op
{
	public class ExcelOperator2
	{
		private string fileName;
		private ExcelEngine excelEngine=new ExcelEngine();
		private IApplication application;
		private IWorkbook workbook;
		private IWorksheet worksheet;
		public ExcelOperator2(string name)
		{
			this.fileName = name;
			application=excelEngine.Excel;
			application.DefaultVersion = ExcelVersion.Excel2016;
			workbook = application.Workbooks.Open(File.Open(fileName, FileMode.Open), Encoding.UTF8);
			worksheet = workbook.Worksheets[1];
		}
		public ExcelOperator2(Spreadsheet ss)
		{
			this.fileName = ss.FileName;
			application = excelEngine.Excel;
			application.DefaultVersion = ExcelVersion.Excel2016;
			workbook = ss.Workbook;
			worksheet = workbook.Worksheets[1];
		}
		
		~ExcelOperator2()
		{
			workbook.Close();
			excelEngine.Dispose();
		}
	}
}

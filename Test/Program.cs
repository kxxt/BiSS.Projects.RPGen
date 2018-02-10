using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Spire.Presentation;
using Spire.Presentation.Charts;
namespace Test
{
	public class Program
	{
		static void Main(string[] args)
		{
			Presentation ppt=new Presentation();
			//ppt.SaveToFile("out.pptx",FileFormat.Pptx2010);
			ISlide s0 = ppt.Slides[0];
			
			Double[] widths = new double[] { 100, 100, 150, 100, 100 };
			Double[] heights = new double[] { 15, 15, 15, 15, 15, 15, 15, 15, 15, 15, 15, 15, 15 };
			ITable table = ppt.Slides[0].Shapes.AppendTable(ppt.SlideSize.Size.Width / 2 - 275, 90, widths, heights);

			String[,] dataStr = new String[,]{
				{"Name",    "Capital",  "Continent",    "Area", "Population"},
				{"Venezuela",   "Caracas",  "South America",    "912047",   "19700000"},
				{"Bolivia", "La Paz",   "South America",    "1098575",  "7300000"},
				{"Brazil",  "Brasilia", "South America",    "8511196",  "150400000"},
				{"Canada",  "Ottawa",   "North America",    "9976147",  "26500000"},
				{"Chile",   "Santiago", "South America",    "756943",   "13200000"},
				{"Colombia",    "Bagota",   "South America",    "1138907",  "33000000"},
				{"Cuba",    "Havana",   "North America",    "114524",   "10600000"},
				{"Ecuador", "Quito",    "South America",    "455502",   "10600000"},
				{"Paraguay",    "Asuncion","South America", "406576",   "4660000"},
				{"Peru",    "Lima", "South America",    "1285215",  "21600000"},
				{"Jamaica", "Kingston", "North America",    "11424",    "2500000"},
				{"Mexico",  "Mexico City",  "North America",    "1967180",  "88600000"}
			};

			//add data to table
			for (int i = 0; i < 13; i++)
			for (int j = 0; j < 5; j++)
			{
				//fill the table with data
				table[j, i].TextFrame.Text = dataStr[i, j];

				//set the Font
				table[j, i].TextFrame.Paragraphs[0].TextRanges[0].LatinFont = new TextFont("Arial Narrow");
			}

			//set the alignment of the first row to Center
			for (int i = 0; i < 5; i++)
			{
				table[i, 0].TextFrame.Paragraphs[0].Alignment = TextAlignmentType.Center;
			}
			
			//ITable tablet = s0.Shapes.AppendTable(ppt.SlideSize.Size.Width * 0.20f, ppt.SlideSize.Size.Height / 0.20f,
			//	new[] {300d, 300d}, new[] {200d, 200d, 200d});
			//for (int i = 0; i < 2; i++)
			//{
			//	for (int j = 0; j < 3; j++)
			//	{
			//		tablet[j, i].TextFrame.Paragraphs[0].Text = $"{i}::{j}";
			//		tablet[j, i].TextFrame.Paragraphs[0].TextRanges[0].LatinFont = new TextFont("Segoe UI SemiLight");
			//		tablet[j, i].TextFrame.Paragraphs[0].Alignment = TextAlignmentType.Center;
			//	}
			//}
			ISlide s1 = ppt.Slides.Append();
			IChart ct = s1.Shapes.AppendChart(ChartType.Area, new RectangleF(10f, 10f, 512f, 512f));
			ct.ChartStyle=ChartStyle.Style2;
			ct.ChartTitle.TextProperties.Paragraphs[0].Text = "Test";
		    ppt.SaveToFile("out.pptx", FileFormat.Pptx2010);
            ///////////////////////////////////

            try { File.Copy("tmp3.pptx", "outcharts.pptx"); }
            catch { }

		    Presentation pptx = null;
            try
            {
                pptx= new Presentation("outcharts.pptx", FileFormat.Pptx2010);
            }
            catch(Exception e) { Console.WriteLine(RsWork.Functions.Log.Logger.GetExceptionInfo(e));}

            ISlide s2 = pptx.Slides[3];
		    ITable tb =(ITable) s2.Shapes[0];
		    for (int i = 0; i < 13; i++)
		    for (int j = 0; j < 5; j++)
		    {
		        //fill the table with data
		        tb[j, i].TextFrame.Text = dataStr[i, j];

		        //set the Font
		        tb[j, i].TextFrame.Paragraphs[0].TextRanges[0].LatinFont = new TextFont("Arial Narrow");
		    }
            pptx.SaveToFile("outcharts.pptx",FileFormat.Pptx2010);
        }
	}
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BiSS.Projects.RPGen.ExcelLayout;
using BiSS.Projects.RPGen.Properties;
using Newtonsoft.Json;
using Syncfusion.Windows.Forms.Grid;
using Syncfusion.Windows.Forms.Tools;
using static BiSS.Projects.RPGen.Program;
using static BiSS.Projects.RPGen.Config.Config;

namespace BiSS.Projects.RPGen.Windows.Wizard
{
	public partial class WelcomeWindow : DialogWindows10
	{
		//private FlowLayoutPanel panel;
		//private Windows10Btn2 nextbtn,prevbtn;
		//private Label _title;
		public const int WM_NCLBUTTONDOWN = 0xA1;
		public const int HT_CAPTION = 0x2;
		[System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
		public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
		[System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
		public static extern bool ReleaseCapture();
		private void TitleLabel_MouseDown(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				//To provide the Dragging behavior of the Form when clicking and draging over the title bar control.
				ReleaseCapture();
				SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
			}
		}

		private string path;
		public WelcomeWindow()
		{
			InitializeComponent();

			//_title = new Label()
			//{
			//	Text = "欢迎使用成绩报告生成器",
			//	Location = new Point(3, 3),
			//	Size = new Size(470, 25),
			//	Font = new Font("微软雅黑", 13, FontStyle.Regular),
			//	BackColor = Color.Black,//Style.TitleBar.BackColor,
			//	ForeColor = Color.FromArgb(78, 77, 77),
			//	BorderStyle = BorderStyle.None,
			//};
			//_title.MouseDown+= TitleLabel_MouseDown;
			//panel =new FlowLayoutPanel();
			//prevbtn = new Windows10Btn2();
			//nextbtn = new Windows10Btn2();
			//panel.Size = new System.Drawing.Size(this.Width-Style.TitleBar.CloseButtonSize.Width*3, 24);
			//panel.BackColor = Style.TitleBar.BackColor;
			//panel.FlowDirection = FlowDirection.LeftToRight;
			//panel.Controls.Add(_title);
			//panel.Controls.Add(prevbtn);
			//panel.Controls.Add(nextbtn);
			//panel.MouseDown += TitleLabel_MouseDown;
			//nextbtn.Size = new System.Drawing.Size(30, 21);
			////nextbtn.Location= new Point(this.Width-Style.TitleBar.CloseButtonSize.Width*3,0); 
			//nextbtn.Text = ">";
			//nextbtn.Click += (_, __) => {NextJob(); };
			//prevbtn.Text = "<";
			//prevbtn.Click += (_, __) => { PrevJob(); };
			//prevbtn.Size = new System.Drawing.Size(30, 21);
			//this.TitleBarTextControl = panel;
			////////////////
			//if (Program.DebugEnabled)
			//{
			//	msgs.Add(new WelcomeWindowMessage("欢迎使用成绩报告生成器", "欢迎", "测试字符串\r\nHelloWorld"));
			//	msgs.Add(new WelcomeWindowMessage("测试", "欢迎", "HelloWorld,Ifdswert\r\nswrfsdfwe\r\nr235rdsfgdsr245\r\n345refgsdgwe45\r\nw25resderf\r\n23w4r5wefxvcvs\r\n23q4ewdfczxvc\r\n235fdxcvsfdgzv\r\nw44frtdzvc zsdwr\r\nstzswtdgzxvc\r\nwerszfczxvcfsde\r\nsfd1848klxsgvjw\r\n 3345sdvsfbsbdf,jksbnfjbhqw\r\nw3r478ysudifchqowrj\r\nueryguyg"));
			//}
			ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Resources));
			msgs = new List<WelcomeWindowMessage>()
			{
				new WelcomeWindowMessage("欢迎使用","欢迎使用本程序,请按照向导继续操作.",new PictureBox()
				{
					Image =(resources.GetObject("WelcomeImage") as Bitmap),
					SizeMode = PictureBoxSizeMode.Normal,
					Size = new Size(1024,1024),
					BorderStyle = BorderStyle.None,
					//Location = new Point(0,0),
					//BackgroundImageLayout =ImageLayout.Stretch,
					AutoSize = true,

				}),
				new WelcomeWindowMessage("用户许可协议","请仔细阅读以下用户许可协议 , 继续使用本程序表示您同意此协议.此协议将不再在启动时显示.", (_) =>
				{
					//if(Program.IsShowReadme)
					if(!Program.ShowReadme(true))
						return true;
					return true;
				}),
				new WelcomeWindowMessage("填写 Excel 成绩表格","在接下来的过程中,你将填写一份固定格式的Excel 成绩表单", "应用程序将启动 Excel , 请填写此表格 , 您可以把原成绩表中的数据复制到此表中.\r\n注意:请勿修改列标题及列的顺序 ! \r\n请在填写完成后保存文件并关闭 Excel 窗口,返回到本程序中继续操作.\r\n按任意键或下方按钮启动 Excel 来填写表单."),
				new WelcomeWindowMessage("填写 Excel 成绩表格","请到 Excel 窗口填写成绩表格.如果您看到这个界面并已填写完表格 , 请关闭 Excel.",_ =>
				{
					//Task.WaitAny(new Task(FillExcel));
					FillExcel();
					return true;
				}),
				new WelcomeWindowMessage("选择导出路径及格式并设置数据","请根据您的需要选择导出路径和导出格式,并对数据进行设置.\r\n注意:评级分界不接受100%以上及0%以下数字",
					_ =>
					{
						var w=new FormatWindow();
						w.FormClosed += (__, ___) => { path = w.Path;this.label1.Enabled = true; };
						w.ShowDialog();
						w.Close();
						return true;
					}),
				new WelcomeWindowMessage("保存成功!","感谢您使用本程序.",$"您的成绩报告已导出到{path}\r\n您现在可以查看或根据自己的需要修改它."),

				new WelcomeWindowMessage("END","END","ENDED"),
			};
			//var xx = (msgs[0].Context as PictureBox);
			//xx.SizeMode = PictureBoxSizeMode.Zoom;
			//MessageBox.Show($"{xx.Location}\r\n{xx.Size}\r\n{xx.Image == null}\r\n{(resources.GetObject("WelcomeImage")) == null}\r\n{(resources.GetObject("WelcomeImage") as Bitmap).Size}");
		}

		private void WelcomeWindow_KeyDown(object sender, KeyEventArgs e)
		{
			NextJob();
		}

		private void WelcomeWindow_Load(object sender, EventArgs e)
		{
			NextJob();
		}
		int cnt = 0;
		private void NextJob()
		{
			if (cnt < msgs.Count)
			{
				//MessageBox.Show($"{cnt}");
				this.label2.Text = msgs[cnt].Title;
				this.label3.Text = msgs[cnt].SubTitle;
				this.flowLayoutPanel1.Controls.Clear();
				//MessageBox.Show(msgs[cnt].Context.Text+"\r\n"+ msgs[cnt].Context.Location+"\r\n"+ msgs[cnt].Context.Size);
				this.flowLayoutPanel1.Controls.Add(msgs[cnt].Context);
				if (msgs[cnt].Context.Visible == false && (msgs[cnt].Context.Tag as String) == "ACTION")
				{
					bool r = msgs[cnt].Action(this.flowLayoutPanel1);
					if (r)
					{
						cnt++;
						NextJob();
						return;
					}

				}

				if (Program.DebugEnabled)
				{
					var aka = msgs[cnt].Context;
					//MessageBox.Show($"CTRL:{aka.GetType()}\r\nLocation:{aka.Location}\r\nSize:{aka.Size}\r\nText:{aka.Text}\r\nTag:{aka.Tag}\r\nAutoSize:{aka.AutoSize}\r\n");
				}
				cnt++;
			}
		}

		private void PrevJob()
		{
			cnt--;
		}
		private IList<WelcomeWindowMessage> msgs = new List<WelcomeWindowMessage>();

		public IList<WelcomeWindowMessage> Msgs { get => this.msgs; set => this.msgs = value; }
		public int CurrentIndex { get => this.cnt; }

		private void label1_Click(object sender, EventArgs e)
		{
			NextJob();
		}

		private void FillExcel()
		{
			label1.Enabled = false;
			//if(Program.ExcelWindow.FileName=="")
			//	Program.ExcelWindow.spreadsheet1.Open("Data\\Test\\c5.xlsx");
			//else
			//	Program.ExcelWindow.spreadsheet1.Open(Program.ExcelWindow.FileName);
			//Program.ExcelWindow.ShowDialog();
			//MessageBox.Show($"Temp\\{Program.XlsFile}");
			try
			{
				File.Copy(@"Data\Test\c5.xlsx", Application.StartupPath + $"\\Temp\\{Program.XlsFile}", true);
			}
			catch (Exception)
			{
				var dlg = new DialogWindows10();
				dlg.title.Text = "应用程序内部错误";
				dlg.subTitle.Text = "请检查以下问题是否存在,修复并重试:\r\n" +
									"1. 应用程序不完整,请重新下载应用程序.\r\n" +
									"2. 应用程序没有在文件系统上操作文件的权限,请修改权限设置.\r\n" +
									"3. 如果以上均无问题,请联系应用程序开发者.";
				return;
			}
			var xls = new Process()
			{
				StartInfo =
				{
					FileName = $"Temp\\{Program.XlsFile}",

				},
			};
			xls.Start();
			xls.WaitForExit();
			ExcelWindow ew = new ExcelWindow("检查数据");
			ew.spreadsheet1.Open($"Temp\\{Program.XlsFile}");
			MessageBox.Show("单击确定以继续...\r\n您可能需要等待一段时间...", WriteObject(ew.spreadsheet1.ActiveSheet) ?? "提示");
			Log("Loop Begin");
			//Busy.BusyWindow busy=new Busy.BusyWindow();
			//busy.Worker.DoWork += (___s___, ___args___) => {
			//	while (ew.Export() == null)
			//	{
			//		Log("Looping...");
			//		if (ew.Error.HasValue&&ew.Error.Value)
			//			break;
			//	}
			//};
			//busy.ShowDialog();

			//await Task.Run(() =>
			//{
			while (ew.Export() == null)
			{
				Log("Looping...");
				if (ew.Error.HasValue && ew.Error.Value)
					break;
			}
			//});

			//while (ew.Export() == null)
			//{
			//	Log("Looping...");
			//	if (ew.Error.HasValue&&ew.Error.Value)
			//		break;
			//}
			if (ew.Error.HasValue && !ew.Error.Value)
			{
				var data = ew.Export();
				Program.Data.X = data;
				/////////////////////
				if (Program.DebugEnabled)
				{
					string json = JsonConvert.SerializeObject(data);
					//MessageBox.Show(json);
					File.Create("test.dat").Close();
					File.AppendAllText("test.dat", json, Encoding.UTF8);
				}
				//////////////////////
				//MessageBox.Show(JsonConvert.SerializeObject(data[0]), "测试数据");

				//this.Hide();
				//var fmt = new FormatWindow();
				//fmt.FormClosed += (s, args) =>
				//{
				//	this.label1.Enabled = true;
				//	this.Close();
				//};
				//fmt.Show();
			}
			else
			{
				MessageBox.Show("Error");
				label1.Enabled = true;
				return;
			}
		}
	}

	public class WelcomeWindowMessage
	{
		private string title;
		private string subTitle;
		private Control context;
		private Func<object, bool> action;
		public WelcomeWindowMessage(string title, string subTitle, Control context)
		{
			this.title = title;
			this.subTitle = subTitle;
			this.context = context;
			context.Dock = DockStyle.Fill;

		}
		public WelcomeWindowMessage(string title, string subTitle, string context)
		{
			this.title = title;
			this.subTitle = subTitle;
			this.context = new Label()
			{
				Text = context,
				AutoSize = true,
				Dock = System.Windows.Forms.DockStyle.Fill,
				Font = new System.Drawing.Font("微软雅黑 Light", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134))),
				TextAlign = System.Drawing.ContentAlignment.MiddleLeft
			};
			this.context.Dock = DockStyle.Fill;

		}
		/// <summary>
		/// 
		/// </summary>
		/// <param name="title"></param>
		/// <param name="subTitle"></param>
		/// <param name="action">返回值表示是否进行下一任务</param>
		public WelcomeWindowMessage(string title, string subTitle, Func<object, bool> action)
		{
			this.title = title;
			this.subTitle = subTitle;
			this.context = new Control()
			{
				Visible = false,
				Tag = "ACTION"
			};
			this.Action = action;

		}
		public string Title { get => this.title; set => this.title = value; }
		public string SubTitle { get => this.subTitle; set => this.subTitle = value; }
		public Control Context { get => this.context; set => this.context = value; }
		public Func<object, bool> Action { get => this.action; set => this.action = value; }
	}
}

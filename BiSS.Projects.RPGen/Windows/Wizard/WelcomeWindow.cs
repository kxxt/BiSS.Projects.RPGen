using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BiSS.Projects.RPGen.ExcelLayout;
using BiSS.Projects.RPGen.Properties;
using Microsoft.Vbe.Interop;
using Newtonsoft.Json;
using Syncfusion.Windows.Forms.Grid;
using Syncfusion.Windows.Forms.Tools;
using static BiSS.Projects.RPGen.Program;
using static BiSS.Projects.RPGen.Config.Config;
using Application = System.Windows.Forms.Application;

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
			counter++;
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
				new WelcomeWindowMessage("填写 Excel 成绩表格","在接下来的过程中,你将填写一份固定格式的Excel 成绩表单", "应用程序将启动 Excel , 请填写此表格 , 您可以把原成绩表中的数据复制到此表中.\r\n注意:请勿修改列标题及列的顺序 ! \r\n请在填写完成后保存文件并关闭 Excel 窗口,返回到本程序中继续操作.\r\n按任意键或下方按钮启动 Excel 来填写表单.\r\n" +
										 "在下一步前 , 请确保计算机上存在能打开 Excel 2007 表格的应用程序 , 并绑定 “ *.xlsx ” 扩展名 , 建议使用 Microsoft Office Excel 2016 .\r\n[ Microsoft Office Excel 2003 不符合条件 , 请至少使用 Excel 2007 ]\r\n如果您没有安装指定程序 , 请关闭本程序 , 安装后再返回操作 ."),
				new WelcomeWindowMessage("填写 Excel 成绩表格","请到 Excel 窗口填写成绩表格.如果您看到这个界面并已填写完表格 , 请关闭 Excel.",_ =>
				{
					if (DebugEnabled)
						MessageBox.Show("INTO ACTION:\r\n[INVOKE]");
					//Task.WaitAny(new Task(FillExcel));
					bool succeeded=FillExcel();
					if (!succeeded)
					{
						label1.Enabled = true;
						RollBack();
						return false;
					}
					return true;
				}),
				new WelcomeWindowMessage("选择导出路径及格式并设置数据","请根据您的需要选择导出路径和导出格式,并对数据进行设置.\r\n注意:评级分界不接受100%以上及0%以下数字",
					_ =>
					{

						var w=new FormatWindow();

						bool ClosedByUser = true;
						w.FormClosed += (__, ___) => { this.label1.Enabled = true;
							ClosedByUser = w.ClosedByUser;
						};
						w.ShowDialog();
						if(ClosedByUser)
						{
							DialogResult r=MessageBox.Show("您是否要退出向导 ?","提示",MessageBoxButtons.YesNo,MessageBoxIcon.Information);
							//MessageBox.Show("用户取消了操作 .","提示",MessageBoxButtons.OK,MessageBoxIcon.Information);
							if(r==DialogResult.Yes)
								this.Close();
							else
							{
								w.ShowDialog();
							}
						}
							
						//w.Close();
						return true;
					}),
				new WelcomeWindowMessage("保存成功 !","感谢您使用本程序 .", pp =>
				{
					var panel = pp as FlowLayoutPanel;
					var labelx= new LinkLabel()
					{
						LinkBehavior = LinkBehavior.AlwaysUnderline,
						Text =$"您的成绩报告已导出到{path}\r\n您现在可以查看或根据自己的需要修改它.\r\n\t\t点击上方链接打开成绩报告\r\n点击 [ 点此继续 ] 或上方关闭按钮结束向导 .",
						AutoSize = true,
						Dock = System.Windows.Forms.DockStyle.Left,
						Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134))),
						TextAlign = System.Drawing.ContentAlignment.MiddleLeft,
						LinkArea=new LinkArea(10,path.Length),
						ActiveLinkColor = Color.DarkCyan,
						VisitedLinkColor = Color.BlueViolet,
						LinkColor = Color.DarkTurquoise

					};
					labelx.TabStop = false;
					labelx.LinkClicked += (__, ___) =>
					{
						try
						{
							Process.Start(path);
						}
						catch
						{
							MessageBox.Show("打开生成的成绩报告时出错 !\r\n请您前往指定目录手动打开 .","错误",MessageBoxButtons.OK,MessageBoxIcon.Error);
						}

					};
					panel.Controls.Clear();
					panel.Controls.Add(labelx);
					return false;
				}),//$"您的成绩报告已导出到{path}\r\n您现在可以查看或根据自己的需要修改它."),

				new WelcomeWindowMessage("结束","向导结束", pp =>
				{
					this.Close();
					return false;
				}),
			};
			//var xx = (msgs[0].Context as PictureBox);
			//xx.SizeMode = PictureBoxSizeMode.Zoom;
			//MessageBox.Show($"{xx.Location}\r\n{xx.Size}\r\n{xx.Image == null}\r\n{(resources.GetObject("WelcomeImage")) == null}\r\n{(resources.GetObject("WelcomeImage") as Bitmap).Size}");
		}

		private void WelcomeWindow_KeyDown(object sender, KeyEventArgs e)
		{
			if (label1.Enabled)
				NextJob();
		}

		private void WelcomeWindow_Load(object sender, EventArgs e)
		{
			ExitGuide = false;
			NextJob();
		}
		int cnt = 0;
		private void NextJob()
		{
			if (DebugEnabled)
			{

				//MessageBox.Show($"CNT:{cnt}\r\nrollBack:{rollBack}");
			}
			path = Program.OutputPath;
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
					//if (DebugEnabled)
					//MessageBox.Show("[Invoke]");
					bool r = msgs[cnt].Action(this.flowLayoutPanel1);
					this.Activate();
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

		private bool rollBack = false;
		private void RollBack()
		{
			rollBack = true;
			cnt = 2;
			NextJob();
			rollBack = false;
		}
		private void PrevJob()
		{
			cnt--;
			NextJob();
		}
		private IList<WelcomeWindowMessage> msgs = new List<WelcomeWindowMessage>();

		public IList<WelcomeWindowMessage> Msgs { get => this.msgs; set => this.msgs = value; }
		public int CurrentIndex { get => this.cnt; }

		private void label1_Click(object sender, EventArgs e)
		{
			NextJob();
		}

		private int dbg_cnt = 0;
		private static int counter = 0;
		private static int prevcounter = 0;
		private bool FillExcel()
		{
			Begin:

			label1.Enabled = false;
			//if(Program.ExcelWindow.FileName=="")
			//	Program.ExcelWindow.spreadsheet1.Open("Data\\Test\\c5.xlsx");
			//else
			//	Program.ExcelWindow.spreadsheet1.Open(Program.ExcelWindow.FileName);
			//Program.ExcelWindow.ShowDialog();
			//MessageBox.Show($"Temp\\{Program.XlsFile}");
			try
			{
				//MessageBox.Show($"{++dbg_cnt}");
				//Program.XlsFile = null;
				if (counter == prevcounter + 1)
				{
					Program.XlsFile = null;
					prevcounter++;
				}

				if (!File.Exists(CurXlsFile))
					File.Copy(@"Data\object3", CurXlsFile, true);


			}
			catch (Exception)
			{
				var dlg = new DialogWindows10();
				dlg.title.Text = "应用程序内部错误";
				dlg.subTitle.Text = "请检查以下问题是否存在,修复并重试:\r\n" +
									"1. 应用程序不完整,请重新下载应用程序.\r\n" +
									"2. 应用程序没有在文件系统上操作文件的权限,请修改权限设置.\r\n" +
									"3. 如果以上均无问题,请联系应用程序开发者.";
				return false;
			}
			var xls = new Process()
			{
				StartInfo =
				{
					FileName = CurXlsFile,

				},
			};
			xls.Start();
			xls.WaitForExit();
			ExcelWindow ew = new ExcelWindow("检查数据");
			ew.spreadsheet1.Open(CurXlsFile);
			MessageBox.Show("单击确定以继续...\r\n您可能需要等待一段时间...", WriteObject(ew.spreadsheet1.ActiveSheet) ?? "提示");
			Log("Loop Begin");
			var data = ew.Export();
			if (ExitGuide)
			{
				if (DebugEnabled)
				{
					MessageBox.Show("EXIT_GUIDE");
				}
				ExitGuide = false;
				this.Close();
				return false;
			}
			//while (ew.Export() == null)
			//{
			//	Log("Looping...");
			//	if (ew.Error.HasValue && ew.Error.Value)
			//		break;
			//	if (ew.KillingError)
			//		break;
			//}
			if (data == null)
			{

				goto Begin;
				//ShouldAutoNext = false;
				//return false;
			}
			if (ew.Error.HasValue && !ew.Error.Value && !ew.KillingError)
			{

				Program.Data.X = data;
				/////////////////////
				if (Program.DebugEnabled)
				{
					string json = JsonConvert.SerializeObject(data);
					//MessageBox.Show(json);
					File.Create("test.dat").Close();
					File.AppendAllText("test.dat", json, Encoding.UTF8);
				}

			}
			else
			{
				//MessageBox.Show("Error");
				label1.Enabled = true;
				goto Begin;
			}

			return true;
		}

		//private bool ShouldAutoNext = true;

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
				Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134))),
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

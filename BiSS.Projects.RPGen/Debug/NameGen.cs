using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Spire.Pdf.General.Render.Font.OpenTypeLookup;

namespace BiSS.Projects.RPGen.Debug
{
	public class NameGen
	{
		public static object[] CreateRegionCode(int strlength, bool isRandomCount = false)
		{
			if (isRandomCount)
			{
				Random random = new Random();
				strlength = random.Next(1, strlength + 1);
			}

			//定义一个字符串数组储存汉字编码的组成元素
			string[] rBase = new String[16] { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "a", "b", "c", "d", "e", "f" };
			Random rnd = new Random();
			//定义一个object数组用来
			object[] bytes = new object[strlength];
			/*每循环一次产生一个含两个元素的十六进制字节数组，并将其放入bject数组中
			 每个汉字有四个区位码组成
			 区位码第1位和区位码第2位作为字节数组第一个元素
			 区位码第3位和区位码第4位作为字节数组第二个元素
			*/

			for (int i = 0; i < strlength; i++)
			{
				//区位码第1位
				int r1 = rnd.Next(11, 14);
				string str_r1 = rBase[r1].Trim();
				//区位码第2位
				rnd = new Random(r1 * unchecked((int)DateTime.Now.Ticks) + i);//更换随机数发生器的种子避免产生重复值
				int r2;
				if (r1 == 13)
				{
					r2 = rnd.Next(0, 7);
				}
				else
				{
					r2 = rnd.Next(0, 16);
				}
				string str_r2 = rBase[r2].Trim();
				//区位码第3位
				rnd = new Random(r2 * unchecked((int)DateTime.Now.Ticks) + i);
				int r3 = rnd.Next(10, 16);
				string str_r3 = rBase[r3].Trim();
				//区位码第4位
				rnd = new Random(r3 * unchecked((int)DateTime.Now.Ticks) + i);
				int r4;
				if (r3 == 10)
				{
					r4 = rnd.Next(1, 16);
				}
				else if (r3 == 15)
				{
					r4 = rnd.Next(0, 15);
				}
				else
				{
					r4 = rnd.Next(0, 16);
				}
				string str_r4 = rBase[r4].Trim();
				//定义两个字节变量存储产生的随机汉字区位码
				byte byte1 = Convert.ToByte(str_r1 + str_r2, 16);
				byte byte2 = Convert.ToByte(str_r3 + str_r4, 16);
				//将两个字节变量存储在字节数组中
				byte[] str_r = new byte[] { byte1, byte2 };
				//将产生的一个汉字的字节数组放入object数组中
				bytes.SetValue(str_r, i);
			}
			return bytes;
		}
		public static string GetSurname()
		{
			Random random = new Random();
			int index = random.Next(0, surname.Count());
			return surname[index];
		}

		public static string Rand1()
		{
			//姓
			string surname = GetSurname();
			//获取GB2312编码页（表）
			Encoding gb = Encoding.GetEncoding("gb2312");
			//调用函数产生4个随机中文汉字编码
			object[] bytes = CreateRegionCode(2, true);
			//根据汉字编码的字节数组解码出中文汉字
			string name = string.Empty;
			for (int i = 0; i < bytes.Length; i++)
			{
				name += gb.GetString((byte[])Convert.ChangeType(bytes[i], typeof(byte[])));
			}
			Thread.Sleep(100);
			return name;
		}
		public static List<string> surname = new List<string>() {"赵", "钱", "孙", "李", "周", "吴", "郑", "王", "冯", "陈", "楮", "卫", "蒋", "沈", "韩", "杨",
			"朱", "秦", "尤", "许", "何", "吕", "施", "张", "孔", "曹", "严", "华", "金", "魏", "陶", "姜",
			"戚", "谢", "邹", "喻", "柏", "水", "窦", "章", "云", "苏", "潘", "葛", "奚", "范", "彭", "郎",
			"鲁", "韦", "昌", "马", "苗", "凤", "花", "方", "俞", "任", "袁", "柳", "酆", "鲍", "史", "唐",
			"费", "廉", "岑", "薛", "雷", "贺", "倪", "汤", "滕", "殷", "罗", "毕", "郝", "邬", "安", "常",
			"乐", "于", "时", "傅", "皮", "卞", "齐", "康", "伍", "余", "元", "卜", "顾", "孟", "平", "黄",
			"和", "穆", "萧", "尹", "姚", "邵", "湛", "汪", "祁", "毛", "禹", "狄", "米", "贝", "明", "臧",
			"计", "伏", "成", "戴", "谈", "宋", "茅", "庞", "熊", "纪", "舒", "屈", "项", "祝", "董", "梁",
			"杜", "阮", "蓝", "闽", "席", "季", "麻", "强", "贾", "路", "娄", "危", "江", "童", "颜", "郭",
			"梅", "盛", "林", "刁", "锺", "徐", "丘", "骆", "高", "夏", "蔡", "田", "樊", "胡", "凌", "霍",
			"虞", "万", "支", "柯", "昝", "管", "卢", "莫", "经", "房", "裘", "缪", "干", "解", "应", "宗",
			"丁", "宣", "贲", "邓", "郁", "单", "杭", "洪", "包", "诸", "左", "石", "崔", "吉", "钮", "龚",
			"程", "嵇", "邢", "滑", "裴", "陆", "荣", "翁", "荀", "羊", "於", "惠", "甄", "麹", "家", "封",
			"芮", "羿", "储", "靳", "汲", "邴", "糜", "松", "井", "段", "富", "巫", "乌", "焦", "巴", "弓",
			"牧", "隗", "山", "谷", "车", "侯", "宓", "蓬", "全", "郗", "班", "仰", "秋", "仲", "伊", "宫",
			"宁", "仇", "栾", "暴", "甘", "斜", "厉", "戎", "祖", "武", "符", "刘", "景", "詹", "束", "龙",
			"叶", "幸", "司", "韶", "郜", "黎", "蓟", "薄", "印", "宿", "白", "怀", "蒲", "邰", "从", "鄂",
			"索", "咸", "籍", "赖", "卓", "蔺", "屠", "蒙", "池", "乔", "阴", "郁", "胥", "能", "苍", "双",
			"闻", "莘", "党", "翟", "谭", "贡", "劳", "逄", "姬", "申", "扶", "堵", "冉", "宰", "郦", "雍",
			"郤", "璩", "桑", "桂", "濮", "牛", "寿", "通", "边", "扈", "燕", "冀", "郏", "浦", "尚", "农",
			"温", "别", "庄", "晏", "柴", "瞿", "阎", "充", "慕", "连", "茹", "习", "宦", "艾", "鱼", "容",
			"向", "古", "易", "慎", "戈", "廖", "庾", "终", "暨", "居", "衡", "步", "都", "耿", "满", "弘",
			"匡", "国", "文", "寇", "广", "禄", "阙", "东", "欧", "殳", "沃", "利", "蔚", "越", "夔", "隆",
			"师", "巩", "厍", "聂", "晁", "勾", "敖", "融", "冷", "訾", "辛", "阚", "那", "简", "饶", "空",
			"曾", "毋", "沙", "乜", "养", "鞠", "须", "丰", "巢", "关", "蒯", "相", "查", "后", "荆", "红",
			"游", "竺", "权", "逑", "盖", "益", "桓", "公", "仉", "督", "晋", "楚", "阎", "法", "汝", "鄢",
			"涂", "钦", "岳", "帅", "缑", "亢", "况", "后", "有", "琴", "归", "海", "墨", "哈", "谯", "笪",
			"年", "爱", "阳", "佟", "商", "牟", "佘", "佴", "伯", "赏",
			"万俟", "司马", "上官", "欧阳", "夏侯", "诸葛", "闻人", "东方", "赫连", "皇甫", "尉迟", "公羊",
			"澹台", "公冶", "宗政", "濮阳", "淳于", "单于", "太叔", "申屠", "公孙", "仲孙", "轩辕", "令狐",
			"锺离", "宇文", "长孙", "慕容", "鲜于", "闾丘", "司徒", "司空", "丌官", "司寇", "子车", "微生",
			"颛孙", "端木", "巫马", "公西", "漆雕", "乐正", "壤驷", "公良", "拓拔", "夹谷", "宰父", "谷梁",
			"段干", "百里", "东郭", "南门", "呼延", "羊舌", "梁丘", "左丘", "东门", "西门", "南宫"};
		///////////////////////////////@2
		string strLastName = "赵 钱 孙 李    周 吴 郑 王    冯    陈    褚    卫    蒋    沈    韩    杨    朱    秦    尤    许 "
		                     + "何 吕    施    张    孔    曹    严    华    金    魏    陶    姜    戚    谢    邹    喻    柏    水    窦    章 "
		                     + "云 苏    潘    葛    奚    范    彭    郎    鲁    韦    昌    马    苗    凤    花    方    俞    任    袁    柳 "
		                     + "酆 鲍    史    唐    费    廉    岑    薛    雷    贺    倪    汤    滕    殷    罗    毕    郝    邬    安    常 "
		                     + "乐 于    时    傅    皮    卞    齐    康    伍    余    元    卜    顾    孟    平    黄    和    穆    萧    尹 "
		                     + "姚 邵    湛    汪    祁    毛    禹    狄    米    贝    明    臧    计    伏    成    戴    谈    宋    茅    庞 "
		                     + "熊 纪    舒    屈    项    祝    董    粱    杜    阮    蓝    闵    席    季    麻    强    贾    路    娄    危 "
		                     + "江 童    颜    郭    梅    盛    林    刁    钟    徐    邱    骆    高    夏    蔡    田    樊    胡    凌    霍 "
		                     + "虞 万    支    柯    昝    管    卢    莫    经    房    裘    缪    干    解    应    宗    丁    宣    贲    邓 "
		                     + "郁 单    杭    洪    包    诸    左    石    崔    吉    钮    龚    程    嵇    邢    滑    裴    陆    荣    翁 "
		                     + "荀 羊    於    惠    甄    麴    家    封    芮    羿    储    靳    汲    邴    糜    松    井    段    富    巫 "
		                     + "乌 焦    巴    弓    牧    隗    山    谷    车    侯    宓    蓬    全    郗    班    仰    秋    仲    伊    宫 "
		                     + "宁 仇    栾    暴    甘    钭    厉    戎    祖    武    符    刘    景    詹    束    龙    叶    幸    司    韶 "
		                     + "郜    黎    蓟    薄    印    宿    白    怀    蒲    邰    从    鄂    索    咸    籍    赖    卓    蔺    屠    蒙 "
		                     + "池    乔    阴    欎    胥    能    苍    双    闻    莘    党    翟    谭    贡    劳    逄    姬    申    扶    堵 "
		                     + "冉    宰    郦    雍    舄    璩    桑    桂    濮    牛    寿    通    边    扈    燕    冀    郏    浦    尚    农 "
		                     + "温    别    庄    晏    柴    瞿    阎    充    慕    连    茹    习    宦    艾    鱼    容    向    古    易    慎 "
		                     + "戈    廖    庾    终    暨    居    衡    步    都    耿    满    弘    匡    国    文    寇    广    禄    阙    东 "
		                     + "殴    殳    沃    利    蔚    越    夔    隆    师    巩    厍    聂    晁    勾    敖    融    冷    訾    辛    阚 "
		                     + "那    简    饶    空    曾    毋    沙    乜    养    鞠    须    丰    巢    关    蒯    相    查    後    荆    红 "
		                     + "游    竺    权    逯    盖    益    桓    公    万俟    司马    上官    欧阳    夏侯    诸葛 "
		                     + "闻人    东方    赫连    皇甫    尉迟    公羊    澹台    公冶    宗政    濮阳 "
		                     + "淳于    单于    太叔    申屠    公孙    仲孙    轩辕    令狐    钟离    宇文 "
		                     + "长孙    慕容    鲜于    闾丘    司徒    司空    亓官    司寇    仉    督    子车 "
		                     + "颛孙    端木    巫马    公西    漆雕    乐正    壤驷    公良    拓跋    夹谷 "
		                     + "宰父    谷梁    晋    楚    闫    法    汝    鄢    涂    钦    段干    百里    东郭    南门 "
		                     + "呼延    归    海    羊舌    微生    岳    帅    缑    亢    况    后    有    琴    梁丘    左丘 "
		                     + "东门    西门    商    牟    佘    佴    伯    赏    南宫    墨    哈    谯    笪    年    爱    阳    佟 "
		                     + "第五    言    福";

		/// <summary>
		/// 姓氏列表
		/// </summary>
		string[] arrLastName = null;
		/// <summary>
		/// 生成的名字列表
		/// </summary>
		List<string> listCnNames = new List<string>();
		/// <summary>
		/// 名字字符的个数
		/// </summary>
		Random rdCharCount = new Random();
		/// <summary>
		/// 姓氏在姓氏列表中的索引
		/// </summary>
		Random rdLastNameIndex = new Random();
		/// <summary>
		/// 名字的字符对应的十进制
		/// </summary>
		Random rdFirstName = new Random();

		public NameGen()
		{
			arrLastName = strLastName.Replace(" ", " ")
				.Replace("\t", " ").Split(new char[] { ' ' });
		}
		/// <summary>
		/// 随机姓名
		/// </summary>
		/// <returns></returns>
		public string Rand2()
		{
			string name = "";
			//姓
			name += arrLastName[rdLastNameIndex.Next(0, arrLastName.Length - 1)];
			//名
			int iCharCount = rdCharCount.Next(1, 2);
			for (int iCharCountIndex = 1; iCharCountIndex <= iCharCount; iCharCountIndex++)
			{
				name += (char)rdFirstName.Next(16128, 36597);
			}
			return name;
		}
		/////////////////////////////////////////////////////////
		private string lastnames =
	"赵钱孙李周吴郑王冯陈褚卫蒋沈韩杨朱秦尤许何吕施张孔曹严华金魏陶姜戚谢邹喻柏水窦章云苏潘葛奚范彭郎鲁韦昌马苗凤花方俞任袁柳酆鲍史唐费廉岑薛雷贺倪汤滕殷罗毕郝邬安常乐于时傅皮卞齐康伍余元卜顾孟平黄和穆萧尹姚邵湛汪祁毛禹狄米贝明臧计伏成戴谈宋茅庞熊纪舒屈项祝董梁杜阮蓝闵席季麻强贾路娄危江童颜郭梅盛林刁锺徐邱骆高夏蔡田樊胡凌霍虞万支柯昝管卢莫经房裘缪干解应宗丁宣贲邓郁单杭洪包诸左石崔吉钮龚程嵇邢滑裴陆荣翁荀羊於惠甄麴家封芮羿储靳汲邴糜松井段富巫乌焦巴弓牧隗山谷车侯宓蓬全郗班仰秋仲伊宫宁仇栾暴甘钭历戎祖武符刘景詹束龙叶幸司韶郜黎蓟溥印宿白怀蒲邰从鄂索咸籍赖卓蔺屠蒙池乔阳胥能苍双闻莘党翟谭贡劳逄姬申扶堵冉宰郦雍却璩桑桂濮牛寿通边扈燕冀僪浦尚农温别庄晏柴瞿阎充慕连茹习宦艾鱼容向古易慎戈廖庾终暨居衡步都耿满弘匡国文寇广禄阙东欧殳沃利蔚越夔隆师巩厍聂晁勾敖融冷訾辛阚那简饶空曾毋沙乜养鞠须丰巢关蒯相查后荆红游竺权逮盍益桓公丛岳召有舜赏伯佴佘牟商鄢汝法闫楚晋盖逯库郏逢阴薄厉稽铁";

		private string lastnamed =
	" 万俟 司马 上官 欧阳 夏侯 诸葛 闻人 东方 赫连 皇甫 尉迟 公羊 澹台 公冶 宗政 濮阳 淳于 单于 太叔 申屠 公孙 仲孙 轩辕 令狐 钟离 宇文 长孙 慕容 司徒 司空 南宫 西门 东门 左丘 梁丘 呼延 南门 东郭 百里 谷梁 宰父 夹谷 拓跋 壤驷 乐正 漆雕 公西 巫马 端木 颛孙 子车 司寇 亓官 鲜于 锺离 闾丘 公良";

		public string GenLast()
		{
			Random r=new Random();
			if (r.Next(0, 1000) > 30)
				return lastnames[r.Next(0, lastnames.Length)].ToString();
			else
			{
				int cnt = lastnamed.Count(ch => ch == ' ') + 1;
				int tmp = r.Next(0,cnt);
				if (lastnamed[tmp] == ' ') return lastnamed[tmp++].ToString()+lastnamed[tmp];
				while (lastnamed[tmp++]!=' ')
				{
					if (tmp == lastnames.Length - 1)
					{
						tmp = 0;
						return lastnamed[tmp++].ToString() + lastnamed[tmp];
					}
				}
				return lastnamed[tmp++].ToString() + lastnamed[tmp];
			}
		}
	}

}

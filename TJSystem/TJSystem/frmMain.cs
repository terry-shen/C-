#define LOGIN
using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using MyADO;
using TJSystem.Systems;
using TJSystem.Basic;
using TJSystem.Clients;
using TJSystem.Purchase;
using TJSystem.Sales;
using TJSystem.Stock;
using TJSystem.Public;
using TJSystem.Account;
using TJSystem.Doc;
using TJSystem.Tool;

namespace TJSystem
{
	/// <summary>
	/// Form1 的摘要说明。
	/// </summary>
	public class frmMain : System.Windows.Forms.Form
	{
		

		
		private System.Windows.Forms.MainMenu mainMenu1;
		private System.Windows.Forms.StatusBar statusBar1;
		private System.Windows.Forms.TreeView treeView1;
		private System.Windows.Forms.MenuItem menuItem17;
		private System.Windows.Forms.MenuItem menuItem18;
		private System.Windows.Forms.MenuItem menuItem19;
		private System.Windows.Forms.MenuItem menuItem20;
		private System.Windows.Forms.ImageList imageList1;
		private System.Windows.Forms.ToolBar toolBar1;
		private System.Windows.Forms.ToolBarButton toolBarButton1;
		private System.Windows.Forms.ToolBarButton toolBarButton2;
		private System.Windows.Forms.ToolBarButton toolBarButton3;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Splitter splitter1;
		private System.Windows.Forms.StatusBarPanel staB1;
		private System.Windows.Forms.StatusBarPanel staB2;
		private System.Windows.Forms.StatusBarPanel staB3;
		private System.Windows.Forms.StatusBarPanel staB4;
		private System.Windows.Forms.Timer timer1;
		private System.Windows.Forms.MenuItem menuItem21;
		private System.Windows.Forms.MenuItem menuItem22;
		private System.Windows.Forms.MenuItem menuItem23;
		private System.Windows.Forms.MenuItem menuItem24;
		private System.Windows.Forms.MenuItem menuWindow;
		private System.ComponentModel.IContainer components;

		private System.Windows.Forms.ToolBarButton tbbApprove = null;
		private System.Windows.Forms.ToolBarButton tbbApproveCancel = null;

		private System.Windows.Forms.MenuItem [] menuItemAdd = new System.Windows.Forms.MenuItem [5];

		private int totalMenu = 5;
		public bool formClose = false;
		public bool frmLogout = false;
		private System.Windows.Forms.MenuItem menuItem1;
		private System.Windows.Forms.MenuItem menuItem2;
		private System.Windows.Forms.MenuItem menuItem3;
		public string formName = "";
		private System.Windows.Forms.ToolBarButton toolBarButton4;
		private System.Windows.Forms.ToolBarButton toolBarButton5;

		/*Set the MDI Client BackgroundImage*/
		private MDIbg_TypeList _mdibg_type;
		private Image _mdibg_image;
		private Image _mdibg_bgimage;  

		private MDIbg_AlignList _mdibg_align;
		private MDIbg_ValignList _mdibg_valign;

		private System.Windows.Forms.MdiClient bgMDIClient;
		private System.Windows.Forms.MenuItem menuItem4;
		private System.Windows.Forms.MenuItem menuItem5;
		private System.Windows.Forms.MenuItem menuItem6;
		private System.Windows.Forms.MenuItem menuItem7;
		/*End*/

		private bool blregd = false;

		public frmMain()
		{
			//
			// Windows 窗体设计器支持所必需的
			//
			frmLogout = false;
			InitializeComponent();
			if(TJSystem.Public.PublicStatic.CheckRegistry)
			{
				blregd = true;
			}
			InitialPrivateComponent();
			string _LoginUser = TJSystem.Public.PublicStatic.LoginUserName;
			InitialParameters(_LoginUser);
			AddRegMenu();

			if(TJSystem.Public.PublicStatic.CheckRegistry)
			{
				this.staB1.Text = "已注册";				
			}
			else
			{
				this.staB1.Text = "未注册，剩余 " + TJSystem.Public.PublicStatic.LeftDay + " 天";
			}

			this.Text += "(" + TJSystem.Public.PublicStatic.CompanyName + ")";

			this.SizeChanged += new System.EventHandler(this.MDI_Set);
			this.Load+=new EventHandler(this.MDI_Set); 
 
			TJSystem.Public.PublicStatic.CurrentMdiForm = this;
		}

		public frmMain(string _LoginUser)
		{
			//
			// Windows 窗体设计器支持所必需的
			//
			Cursor.Current = System.Windows.Forms.Cursors.Default;
			InitializeComponent();
			InitialPrivateComponent();
			InitialParameters(_LoginUser);
			AddRegMenu();

//			this.statusBar1.Text = PublicStatic.getWeekDay();
		
			//
			// TODO: 在 InitializeComponent 调用后添加任何构造函数代码
			//
		}


		private void InitialParameters(string _LoginUser)
		{
			this.staB1.Text = "Ready";
			this.staB2.Text = "当前登陆用户：" + _LoginUser;
			this.staB3.Text = System.DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss");
			this.staB4.Text = TJSystem.Public.PublicStatic.getWeekDay();
		}

		/// <summary>
		/// 清理所有正在使用的资源。
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null) 
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows 窗体设计器生成的代码
		/// <summary>
		/// 设计器支持所需的方法 - 不要使用代码编辑器修改
		/// 此方法的内容。
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(frmMain));
			this.mainMenu1 = new System.Windows.Forms.MainMenu();
			this.menuWindow = new System.Windows.Forms.MenuItem();
			this.menuItem17 = new System.Windows.Forms.MenuItem();
			this.menuItem18 = new System.Windows.Forms.MenuItem();
			this.menuItem19 = new System.Windows.Forms.MenuItem();
			this.menuItem20 = new System.Windows.Forms.MenuItem();
			this.menuItem21 = new System.Windows.Forms.MenuItem();
			this.menuItem1 = new System.Windows.Forms.MenuItem();
			this.menuItem2 = new System.Windows.Forms.MenuItem();
			this.menuItem3 = new System.Windows.Forms.MenuItem();
			this.menuItem4 = new System.Windows.Forms.MenuItem();
			this.menuItem5 = new System.Windows.Forms.MenuItem();
			this.menuItem6 = new System.Windows.Forms.MenuItem();
			this.menuItem22 = new System.Windows.Forms.MenuItem();
			this.menuItem23 = new System.Windows.Forms.MenuItem();
			this.menuItem24 = new System.Windows.Forms.MenuItem();
			this.imageList1 = new System.Windows.Forms.ImageList(this.components);
			this.statusBar1 = new System.Windows.Forms.StatusBar();
			this.staB1 = new System.Windows.Forms.StatusBarPanel();
			this.staB2 = new System.Windows.Forms.StatusBarPanel();
			this.staB3 = new System.Windows.Forms.StatusBarPanel();
			this.staB4 = new System.Windows.Forms.StatusBarPanel();
			this.treeView1 = new System.Windows.Forms.TreeView();
			this.toolBar1 = new System.Windows.Forms.ToolBar();
			this.toolBarButton1 = new System.Windows.Forms.ToolBarButton();
			this.toolBarButton2 = new System.Windows.Forms.ToolBarButton();
			this.toolBarButton4 = new System.Windows.Forms.ToolBarButton();
			this.toolBarButton5 = new System.Windows.Forms.ToolBarButton();
			this.toolBarButton3 = new System.Windows.Forms.ToolBarButton();
			this.panel2 = new System.Windows.Forms.Panel();
			this.panel1 = new System.Windows.Forms.Panel();
			this.splitter1 = new System.Windows.Forms.Splitter();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.menuItem7 = new System.Windows.Forms.MenuItem();
			((System.ComponentModel.ISupportInitialize)(this.staB1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.staB2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.staB3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.staB4)).BeginInit();
			this.panel2.SuspendLayout();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// mainMenu1
			// 
			this.mainMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					  this.menuWindow,
																					  this.menuItem1,
																					  this.menuItem4,
																					  this.menuItem22});
			// 
			// menuWindow
			// 
			this.menuWindow.Index = 0;
			this.menuWindow.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					   this.menuItem17,
																					   this.menuItem18,
																					   this.menuItem19,
																					   this.menuItem20,
																					   this.menuItem21});
			this.menuWindow.Text = "窗口";
			// 
			// menuItem17
			// 
			this.menuItem17.Index = 0;
			this.menuItem17.Text = "垂直平铺";
			this.menuItem17.Click += new System.EventHandler(this.menuItem17_Click);
			// 
			// menuItem18
			// 
			this.menuItem18.Index = 1;
			this.menuItem18.Text = "水平平铺";
			this.menuItem18.Click += new System.EventHandler(this.menuItem18_Click);
			// 
			// menuItem19
			// 
			this.menuItem19.Index = 2;
			this.menuItem19.Text = "层叠窗口";
			this.menuItem19.Click += new System.EventHandler(this.menuItem19_Click);
			// 
			// menuItem20
			// 
			this.menuItem20.Index = 3;
			this.menuItem20.Text = "最大化";
			this.menuItem20.Click += new System.EventHandler(this.menuItem20_Click);
			// 
			// menuItem21
			// 
			this.menuItem21.Index = 4;
			this.menuItem21.Text = "-";
			// 
			// menuItem1
			// 
			this.menuItem1.Index = 1;
			this.menuItem1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					  this.menuItem2,
																					  this.menuItem3});
			this.menuItem1.Text = "帮助";
			// 
			// menuItem2
			// 
			this.menuItem2.Index = 0;
			this.menuItem2.Text = "帮助手册";
			this.menuItem2.Click += new System.EventHandler(this.menuItem2_Click);
			// 
			// menuItem3
			// 
			this.menuItem3.Index = 1;
			this.menuItem3.Text = "关于 TJSystem";
			this.menuItem3.Click += new System.EventHandler(this.menuItem3_Click);
			// 
			// menuItem4
			// 
			this.menuItem4.Index = 2;
			this.menuItem4.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					  this.menuItem5,
																					  this.menuItem6,
																					  this.menuItem7});
			this.menuItem4.Text = "工具";
			// 
			// menuItem5
			// 
			this.menuItem5.Index = 0;
			this.menuItem5.Text = "单据复制";
			this.menuItem5.Click += new System.EventHandler(this.menuItem5_Click);
			// 
			// menuItem6
			// 
			this.menuItem6.Index = 1;
			this.menuItem6.Text = "更新系统时间";
			this.menuItem6.Click += new System.EventHandler(this.menuItem6_Click);
			// 
			// menuItem22
			// 
			this.menuItem22.Index = 3;
			this.menuItem22.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					   this.menuItem23,
																					   this.menuItem24});
			this.menuItem22.Text = "离开";
			// 
			// menuItem23
			// 
			this.menuItem23.Index = 0;
			this.menuItem23.Text = "关闭本页面";
			this.menuItem23.Click += new System.EventHandler(this.menuItem23_Click);
			// 
			// menuItem24
			// 
			this.menuItem24.Index = 1;
			this.menuItem24.Text = "退出系统";
			this.menuItem24.Click += new System.EventHandler(this.menuItem24_Click);
			// 
			// imageList1
			// 
			this.imageList1.ImageSize = new System.Drawing.Size(35, 35);
			this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
			// 
			// statusBar1
			// 
			this.statusBar1.Location = new System.Drawing.Point(0, 703);
			this.statusBar1.Name = "statusBar1";
			this.statusBar1.Panels.AddRange(new System.Windows.Forms.StatusBarPanel[] {
																						  this.staB1,
																						  this.staB2,
																						  this.staB3,
																						  this.staB4});
			this.statusBar1.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.statusBar1.ShowPanels = true;
			this.statusBar1.Size = new System.Drawing.Size(1016, 22);
			this.statusBar1.TabIndex = 1;
			// 
			// staB1
			// 
			this.staB1.Width = 250;
			// 
			// staB2
			// 
			this.staB2.Width = 450;
			// 
			// staB3
			// 
			this.staB3.Width = 250;
			// 
			// staB4
			// 
			this.staB4.Width = 74;
			// 
			// treeView1
			// 
			this.treeView1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.treeView1.ImageIndex = -1;
			this.treeView1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.treeView1.Location = new System.Drawing.Point(0, 0);
			this.treeView1.Name = "treeView1";
			this.treeView1.SelectedImageIndex = -1;
			this.treeView1.ShowLines = false;
			this.treeView1.ShowPlusMinus = false;
			this.treeView1.Size = new System.Drawing.Size(200, 643);
			this.treeView1.TabIndex = 2;
			this.treeView1.DoubleClick += new System.EventHandler(this.treeView1_DoubleClick);
			this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
			// 
			// toolBar1
			// 
			this.toolBar1.BackColor = System.Drawing.SystemColors.ScrollBar;
			this.toolBar1.Buttons.AddRange(new System.Windows.Forms.ToolBarButton[] {
																						this.toolBarButton1,
																						this.toolBarButton2,
																						this.toolBarButton4,
																						this.toolBarButton5,
																						this.toolBarButton3});
			this.toolBar1.ButtonSize = new System.Drawing.Size(55, 55);
			this.toolBar1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.toolBar1.DropDownArrows = true;
			this.toolBar1.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.toolBar1.ImageList = this.imageList1;
			this.toolBar1.Location = new System.Drawing.Point(0, 0);
			this.toolBar1.Name = "toolBar1";
			this.toolBar1.ShowToolTips = true;
			this.toolBar1.Size = new System.Drawing.Size(1016, 61);
			this.toolBar1.TabIndex = 0;
			this.toolBar1.ButtonClick += new System.Windows.Forms.ToolBarButtonClickEventHandler(this.toolBar1_ButtonClick);
			// 
			// toolBarButton1
			// 
			this.toolBarButton1.Text = "系统树";
			this.toolBarButton1.ToolTipText = "系统树";
			// 
			// toolBarButton2
			// 
			this.toolBarButton2.Text = "帮助";
			this.toolBarButton2.ToolTipText = "帮助";
			// 
			// toolBarButton4
			// 
			this.toolBarButton4.Text = "注销";
			// 
			// toolBarButton5
			// 
			this.toolBarButton5.Text = "全屏";
			// 
			// toolBarButton3
			// 
			this.toolBarButton3.Text = "退出";
			this.toolBarButton3.ToolTipText = "退出";
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.toolBar1);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel2.Location = new System.Drawing.Point(0, 0);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(1016, 60);
			this.panel2.TabIndex = 11;
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.treeView1);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
			this.panel1.Location = new System.Drawing.Point(0, 60);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(200, 643);
			this.panel1.TabIndex = 6;
			// 
			// splitter1
			// 
			this.splitter1.Location = new System.Drawing.Point(200, 60);
			this.splitter1.Name = "splitter1";
			this.splitter1.Size = new System.Drawing.Size(3, 643);
			this.splitter1.TabIndex = 12;
			this.splitter1.TabStop = false;
			this.splitter1.DoubleClick += new System.EventHandler(this.splitter1_DoubleClick);
			// 
			// timer1
			// 
			this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
			// 
			// menuItem7
			// 
			this.menuItem7.Index = 2;
			this.menuItem7.Text = "搜索客户单据";
			this.menuItem7.Click += new System.EventHandler(this.menuItem7_Click);
			// 
			// frmMain
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(7, 16);
			this.BackColor = System.Drawing.SystemColors.ScrollBar;
			this.ClientSize = new System.Drawing.Size(1016, 725);
			this.Controls.Add(this.splitter1);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.statusBar1);
			this.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.IsMdiContainer = true;
			this.Menu = this.mainMenu1;
			this.Name = "frmMain";
			this.Text = "TJ外贸管理软件";
			this.MdiChildActivate += new System.EventHandler(this.frmMain_MdiChildActivate);
			this.Load += new System.EventHandler(this.frmMain_Load);
			this.Validated += new System.EventHandler(this.frmMain_Validated);
			this.Activated += new System.EventHandler(this.frmMain_Activated);
			((System.ComponentModel.ISupportInitialize)(this.staB1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.staB2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.staB3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.staB4)).EndInit();
			this.panel2.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		/// <summary>
		/// 应用程序的主入口点。
		/// </summary>
		[STAThread]
		static void Main() 
		{
			Application.Run(new frmWelcome(Application.StartupPath));
//			Application.Run(new frmAbout());

			
//			Application.Run(new Form1());
//			Cursor.Current = Cursors.WaitCursor;
//			frmLogin f = new frmLogin();
//			f.ShowDialog();
//			frmw.Show();
//			if(f.EFlag)
//			{
//				return;
//			}
//			if(TJSystem.Public.PublicStatic.CheckRegistryFun())
//			{
//				frmMain frm = new frmMain();
//				frm.WindowState = System.Windows.Forms.FormWindowState.Maximized;
//				Application.Run(frm);
//			}
//			else
//			{
//				System.Data.DataTable dt ;
//				string start = "";
//				TJSystem.Classes.common.CommonXML.ReadXMLConfigure("start",ref start);
//				if(start.Trim().Equals(""))
//				{
//					start = System.DateTime.Now.ToString("yyyy-MM-dd");
//					TJSystem.Classes.common.CommonXML.UpdateXMLConfigure("start",start);
//				}
//				System.TimeSpan dtime = System.DateTime.Now - Convert.ToDateTime(start);
//				
//				System.DateTime dtstart = new DateTime(2000,1,1);
//				System.DateTime dtend = new DateTime(2000,2,1);
//				System.TimeSpan dttol = dtend - dtstart;
//				string strdt = dtime.ToString();
//				strdt = dttol.ToString();
//
//				if(dtime > dttol)
//				{
//					TJSystem.Public.PublicStatic.ShowMessage(TJSystem.Public.MessageType.Error,"未注册版本，使用到期，请购买正版注册！");
//					return;
//				}
//
//				TJSystem.Public.PublicStatic.ShowMessage(TJSystem.Public.MessageType.Exclamation,"未注册版本，还剩下 " + Convert.ToString(dttol-dtime) + " 天使用时间！");
//
//				frmMain frm = new frmMain();
//				frm.WindowState = System.Windows.Forms.FormWindowState.Maximized;
//				Application.Run(frm);
//			}
		}

		private void InitialPrivateComponent()
		{
			this.imageList1.Images.Add(System.Drawing.Image.FromFile("images\\tree.ico"));
			this.imageList1.Images.Add(System.Drawing.Image.FromFile("images\\help.ico"));
			this.imageList1.Images.Add(System.Drawing.Image.FromFile("images\\exit.ico"));
			this.imageList1.Images.Add(System.Drawing.Image.FromFile("images\\logout.ico"));
			this.imageList1.Images.Add(System.Drawing.Image.FromFile("images\\full.ico"));
			
			this.toolBarButton1.ImageIndex = 0;
			this.toolBarButton2.ImageIndex = 1;
			this.toolBarButton3.ImageIndex = 2;
			this.toolBarButton4.ImageIndex = 3;
			this.toolBarButton5.ImageIndex = 4;

			System.Text.StringBuilder sb = new System.Text.StringBuilder();

			sb.Append("select * from xf_menutree ");
			sb.Append(" where xf_currenthandle in ('070110','070150','030060','030010','040050','060060','050020','060020','060050','030020','040010'");
			sb.Append(" ,'040020','050010','030030','040030','060010','050040')");
			sb.Append(" and xf_treeicon='1'");
			if(TJSystem.Public.PublicStatic.db.GetDataTable(sb.ToString()).Rows.Count == 0)
			{
				sb.Remove(0,sb.ToString().Length);
				sb.Append("update xf_menutree set xf_treeicon='1'");
				sb.Append("where xf_currenthandle in ('070110','070150','030060','030010','040050','060060','050020','060020','060050','030020','040010'");
				sb.Append(",'040020','050010','030030','040030','060010','050040')");
				TJSystem.Public.PublicStatic.db.ExeSql(sb.ToString());

				sb.Remove(0,sb.ToString().Length);
				sb.Append("delete from p_status");
				TJSystem.Public.PublicStatic.db.ExeSql(sb.ToString());

				sb.Remove(0,sb.ToString().Length);
				sb.Append(" insert into p_status values('0','作废','account')");
				TJSystem.Public.PublicStatic.db.ExeSql(sb.ToString());
				sb.Remove(0,sb.ToString().Length);
				sb.Append(" insert into p_status values('0','作废','doc')");
				TJSystem.Public.PublicStatic.db.ExeSql(sb.ToString());
				sb.Remove(0,sb.ToString().Length);
				sb.Append(" insert into p_status values('0','作废','purchase')");
				TJSystem.Public.PublicStatic.db.ExeSql(sb.ToString());
				sb.Remove(0,sb.ToString().Length);
				sb.Append(" insert into p_status values('0','作废','sales')");
				TJSystem.Public.PublicStatic.db.ExeSql(sb.ToString());
				sb.Remove(0,sb.ToString().Length);
				sb.Append(" insert into p_status values('0','作废','stock')");
				TJSystem.Public.PublicStatic.db.ExeSql(sb.ToString());
				sb.Remove(0,sb.ToString().Length);
				sb.Append(" insert into p_status values('1','新建','account')");
				TJSystem.Public.PublicStatic.db.ExeSql(sb.ToString());
				sb.Remove(0,sb.ToString().Length);
				sb.Append(" insert into p_status values('1','新建','doc')");
				TJSystem.Public.PublicStatic.db.ExeSql(sb.ToString());
				sb.Remove(0,sb.ToString().Length);
				sb.Append(" insert into p_status values('1','新建','purchase')");
				TJSystem.Public.PublicStatic.db.ExeSql(sb.ToString());
				sb.Remove(0,sb.ToString().Length);
				sb.Append(" insert into p_status values('1','新建','sales')");
				TJSystem.Public.PublicStatic.db.ExeSql(sb.ToString());
				sb.Remove(0,sb.ToString().Length);
				sb.Append(" insert into p_status values('1','新建','stock')");
				TJSystem.Public.PublicStatic.db.ExeSql(sb.ToString());
				sb.Remove(0,sb.ToString().Length);
				sb.Append(" insert into p_status values('1','正常','basic')");
				TJSystem.Public.PublicStatic.db.ExeSql(sb.ToString());
				sb.Remove(0,sb.ToString().Length);
				sb.Append(" insert into p_status values('1','正常','clients')");
				TJSystem.Public.PublicStatic.db.ExeSql(sb.ToString());
				sb.Remove(0,sb.ToString().Length);
				sb.Append(" insert into p_status values('1','正常','item')");
				TJSystem.Public.PublicStatic.db.ExeSql(sb.ToString());
				sb.Remove(0,sb.ToString().Length);
				sb.Append(" insert into p_status values('1','正常','person')");
				TJSystem.Public.PublicStatic.db.ExeSql(sb.ToString());
				sb.Remove(0,sb.ToString().Length);
				sb.Append(" insert into p_status values('2','审核','account')");
				TJSystem.Public.PublicStatic.db.ExeSql(sb.ToString());
				sb.Remove(0,sb.ToString().Length);
				sb.Append(" insert into p_status values('2','审核','doc')");
				TJSystem.Public.PublicStatic.db.ExeSql(sb.ToString());
				sb.Remove(0,sb.ToString().Length);
				sb.Append(" insert into p_status values('2','审核','purchase')");
				TJSystem.Public.PublicStatic.db.ExeSql(sb.ToString());
				sb.Remove(0,sb.ToString().Length);
				sb.Append(" insert into p_status values('2','审核','sales')");
				TJSystem.Public.PublicStatic.db.ExeSql(sb.ToString());
				sb.Remove(0,sb.ToString().Length);
				sb.Append(" insert into p_status values('2','审核','stock')");
				TJSystem.Public.PublicStatic.db.ExeSql(sb.ToString());
				sb.Remove(0,sb.ToString().Length);
				sb.Append(" insert into p_status values('2','取消','basic')");
				TJSystem.Public.PublicStatic.db.ExeSql(sb.ToString());
				sb.Remove(0,sb.ToString().Length);
				sb.Append(" insert into p_status values('2','失效','clients')");
				TJSystem.Public.PublicStatic.db.ExeSql(sb.ToString());
				sb.Remove(0,sb.ToString().Length);
				sb.Append(" insert into p_status values('2','取消','item')");
				TJSystem.Public.PublicStatic.db.ExeSql(sb.ToString());
				sb.Remove(0,sb.ToString().Length);
				sb.Append(" insert into p_status values('2','失效','person')");
				TJSystem.Public.PublicStatic.db.ExeSql(sb.ToString());
				sb.Remove(0,sb.ToString().Length);
				sb.Append(" insert into p_status values('3','确认','account')");
				TJSystem.Public.PublicStatic.db.ExeSql(sb.ToString());
				sb.Remove(0,sb.ToString().Length);
				sb.Append(" insert into p_status values('3','确认','doc')");
				TJSystem.Public.PublicStatic.db.ExeSql(sb.ToString());
				sb.Remove(0,sb.ToString().Length);
				sb.Append(" insert into p_status values('3','确认','purchase')");
				TJSystem.Public.PublicStatic.db.ExeSql(sb.ToString());
				sb.Remove(0,sb.ToString().Length);
				sb.Append(" insert into p_status values('3','确认','sales')");
				TJSystem.Public.PublicStatic.db.ExeSql(sb.ToString());
				sb.Remove(0,sb.ToString().Length);
				sb.Append(" insert into p_status values('3','确认','stock')");
				TJSystem.Public.PublicStatic.db.ExeSql(sb.ToString());

				sb.Remove(0,sb.ToString().Length);
				sb.Append("select distinct b.name from syscolumns a");
				sb.Append(" left join sysobjects b on a.id=b.id");
				sb.Append(" where b.xtype='U' and a.name = 'status'");
				DataTable dttmp = TJSystem.Public.PublicStatic.db.GetDataTable(sb.ToString());
				for(int i = 0; i < dttmp.Rows.Count; i++)
				{
					sb.Remove(0,sb.ToString().Length);
					sb.Append(" update ");
					sb.Append(dttmp.Rows[i][0].ToString());
					sb.Append(" set status = '1' ");
					sb.Append(" where status <> '1'");
					TJSystem.Public.PublicStatic.db.ExeSql(sb.ToString());
				}
			}			
			
			sb.Remove(0,sb.ToString().Length);
			sb.Append("SELECT xf_parenthandle, xf_currenthandle, xf_handlelevel, xf_programname ");
			sb.Append("FROM xf_menutree ");
			sb.Append("where xf_handlelevel < 2 ");
//			sb.Append(" and substring(xf_currenthandle,1,3) in ('120','130','150') ");
			sb.Append("ORDER BY xf_parenthandle, xf_currenthandle");
			DataTable dt = TJSystem.Public.PublicStatic.db.GetDataTable(sb.ToString());
			DataView dv = dt.DefaultView ;
			dv.RowFilter = "xf_handlelevel=0";
			System.Windows.Forms.TreeNode tn ;
			System.Windows.Forms.ImageList imgList = new ImageList();
			imgList.ImageSize = new Size(25,25);
			imgList.Images.Add(Image.FromFile("images\\list.ico"));
			imgList.Images.Add(Image.FromFile("images\\node.ico"));
			imgList.Images.Add(Image.FromFile("images\\select.ico"));

			this.treeView1.ImageList = imgList;
			this.treeView1.SelectedImageIndex = 2;
		
			int menuIndex = 0;
			for(int i = 0 ; i < dv.Count ; i ++)
			{
				System.Windows.Forms.MenuItem menuMainItem = null;
				string str = dv[i][1].ToString();
				tn = new TreeNode(dv[i][3].ToString());
				tn.ImageIndex = 0;				
				
				if(str.Equals("010"))
				{
					if(TJSystem.Public.PublicStatic.JudgeUserRole("010"))
					{
						menuMainItem = new MenuItem("基本资料");
						this.mainMenu1.MenuItems.Add(menuIndex,menuMainItem);
						menuIndex ++;
					}
					else
					{
						continue;
					}
				}
				else if(str.Equals("020"))
				{
//					if(Public.PublicStatic.Priority > 9 || Public.PublicStatic.Priority == 2)
					if(TJSystem.Public.PublicStatic.JudgeUserRole("020"))
					{
						menuMainItem = new MenuItem("客户关系管理");
						this.mainMenu1.MenuItems.Add(menuIndex,menuMainItem);
						menuIndex ++;
					}
					else
						continue;
				}
				else if(str.Equals("030"))
				{
//					if(Public.PublicStatic.Priority > 9 || Public.PublicStatic.Priority == 3)
					if(TJSystem.Public.PublicStatic.JudgeUserRole("030"))
					{
						menuMainItem = new MenuItem("销售管理");
						this.mainMenu1.MenuItems.Add(menuIndex,menuMainItem);
						menuIndex ++;
					}
					else
						continue;
				}
				else if(str.Equals("040"))
				{
//					if(Public.PublicStatic.Priority > 9 || Public.PublicStatic.Priority == 4)
					if(TJSystem.Public.PublicStatic.JudgeUserRole("040"))
					{
						menuMainItem = new MenuItem("采购管理");
						this.mainMenu1.MenuItems.Add(menuIndex,menuMainItem);
						menuIndex ++;
					}
					else
						continue;
				}
				else if(str.Equals("050"))
				{
//					if(Public.PublicStatic.Priority > 9 || Public.PublicStatic.Priority == 5)
					if(TJSystem.Public.PublicStatic.JudgeUserRole("050"))
					{
						menuMainItem = new MenuItem("单证管理");
						this.mainMenu1.MenuItems.Add(menuIndex,menuMainItem);
						menuIndex ++;
					}
					else
						continue;
				}
				else if(str.Equals("060"))
				{
//					if(Public.PublicStatic.Priority > 9 || Public.PublicStatic.Priority == 6)
					if(TJSystem.Public.PublicStatic.JudgeUserRole("060"))
					{
						menuMainItem = new MenuItem("库存管理");
						this.mainMenu1.MenuItems.Add(menuIndex,menuMainItem);
						menuIndex ++;
					}
					else
						continue;
				}
				else if(str.Equals("070"))
				{
//					if(Public.PublicStatic.Priority > 9 || Public.PublicStatic.Priority == 7)
					if(TJSystem.Public.PublicStatic.JudgeUserRole("070"))
					{
						menuMainItem = new MenuItem("帐务处理");
						this.mainMenu1.MenuItems.Add(menuIndex,menuMainItem);
						menuIndex ++;
					}
					else
						continue;
				}
				else if(str.Equals("120"))
				{
//					if(Public.PublicStatic.Priority > 9)
					if(TJSystem.Public.PublicStatic.JudgeUserRole("120"))
					{
						menuMainItem = new MenuItem("系统维护");
						this.mainMenu1.MenuItems.Add(menuIndex,menuMainItem);
						menuIndex ++;
					}
					else
						continue;
				}
				else if(str.Equals("130"))
				{
//					if(Public.PublicStatic.Priority > 9)
					if(TJSystem.Public.PublicStatic.JudgeUserRole("130"))
					{
						menuMainItem = new MenuItem("报表查询");
						this.mainMenu1.MenuItems.Add(menuIndex,menuMainItem);
						menuIndex ++;
					}
					else
						continue;
				}
				else if(str.Equals("140"))
				{
//					menuMainItem = new MenuItem("工时系统");
					if(TJSystem.Public.PublicStatic.JudgeUserRole("140"))
					{
						menuMainItem = new MenuItem("工时系统");
						this.mainMenu1.MenuItems.Add(menuIndex,menuMainItem);
						menuIndex ++;
					}
					else
						continue;

				}
				else if(str.Equals("150"))
				{
//					menuMainItem = new MenuItem("工时系统");
					if(TJSystem.Public.PublicStatic.JudgeUserRole("150"))
					{
						menuMainItem = new MenuItem("实用工具");
						this.mainMenu1.MenuItems.Add(menuIndex,menuMainItem);
						menuIndex ++;
					}
					else
						continue;

				}
				else
				{
					menuMainItem = new MenuItem("其他");
					this.mainMenu1.MenuItems.Add(menuIndex,menuMainItem);
					menuIndex ++;
				}

				DataView tmp = dt.DefaultView;
				tmp.RowFilter = "xf_parenthandle='" + dv[i][1].ToString()+"'";
				for(int k=0; k<tmp.Count; k ++)
				{
					TreeNode ctn = new TreeNode(tmp[k][3].ToString());
					ctn.ImageIndex=1;
					tn.Nodes.Add(ctn);
					System.Windows.Forms.MenuItem miSub = new MenuItem(ctn.Text);
					miSub.Click += new EventHandler(this.Menu_Click);
					menuMainItem.MenuItems.Add(k,miSub);
				}
				this.treeView1.Nodes.Add(tn);
				dv.RowFilter = "xf_handlelevel=0";
			}

			this.timer1.Interval = 1000;
			this.timer1.Enabled = true;

			AddToolBarButton();
		}

		private void Menu_Click(object sender, System.EventArgs e)
		{
			this.shorForm(((System.Windows.Forms.MenuItem)sender).Text);
		}


		private void AddToolBarButton()
		{
			tbbApprove = new ToolBarButton();
			tbbApprove.Text = "审核";
			tbbApprove.ToolTipText = "审核";

			tbbApproveCancel = new ToolBarButton();
			tbbApproveCancel.Text = "取消审核";
			tbbApproveCancel.ToolTipText = "取消审核";

			tbbApprove.Visible = false;
			tbbApproveCancel.Visible = false;
			
//			tbbApprove.ImageIndex = 1;

			this.toolBar1.Buttons.AddRange(new System.Windows.Forms.ToolBarButton[]{tbbApprove,tbbApproveCancel});

		}

		private void DeleteToolBarButton()
		{
			
		}
		private void toolBar1_ButtonClick(object sender, System.Windows.Forms.ToolBarButtonClickEventArgs e)
		{
			switch(e.Button.Text)
			{
				case "系统树":
					ShowTreeView();
					break;
				case "帮助":
					try
					{
						Help.ShowHelpIndex(this,"Help.pdf") ;
					}
					catch(Exception ex)
					{
						MessageBox.Show(ex.Message,"Infomation",MessageBoxButtons.OK,MessageBoxIcon.Exclamation) ;
					}
					break;
				case "注销":
					if(MessageBox.Show("确认要注销？（Y）/（N）","注销",MessageBoxButtons.YesNo,MessageBoxIcon.Question)
						== System.Windows.Forms.DialogResult.Yes)
					{
						frmWelcome frm = new frmWelcome(TJSystem.Public.PublicStatic.StartupPath);
						frm.ShowDialog();
						frmLogout = true;
						TJSystem.Public.PublicStatic.LogOut = true;
						this.Close();
					}
					break;
				case "全屏":
					if(this.FormBorderStyle == System.Windows.Forms.FormBorderStyle.None)
					{
						this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
						this.TopMost = false;
					}
					else
					{
						this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
						this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
						this.TopMost = true;
					}
					break;
				case "退出":
					this.Close();
					break;
				default:
					break;
			}
		}

		private void ShowTreeView()
		{
			if(this.panel1.Visible == false)
			{
				this.panel1.Visible = true;
			}
			else
				this.panel1.Visible = false ;
		}

		private void treeView1_DoubleClick(object sender, System.EventArgs e)
		{
			if(this.MdiChildren.Length > 4)
			{
				TJSystem.Public.PublicStatic.ShowMessage(TJSystem.Public.MessageType.Information,"打开画面超过5个了，不要开这么多画面哦！ ^o^");
				return;
			}

			foreach(System.Windows.Forms.TreeNode tn in this.treeView1.Nodes)
			{
				showTreeNodeForm(tn);
			}
		}

		private void shorForm(string formname)
		{
			this.Cursor = System.Windows.Forms.Cursors.WaitCursor;
			#region 系统维护
			switch(formname)
			{
				case "公司信息维护":
				{
					if(frmSysCompany.frmCurrent == null)
					{
						frmSysCompany.frmCurrent = new frmSysCompany();
						frmSysCompany.frmCurrent.MdiParent = this;
					}
					frmSysCompany.frmCurrent.WindowState = System.Windows.Forms.FormWindowState.Maximized;
					frmSysCompany.frmCurrent.Show();
					break;
				}
				case "部门管理":
				{
					if(frmSysDepartment.frmCurrent == null)
					{
						frmSysDepartment.frmCurrent = new frmSysDepartment();
						frmSysDepartment.frmCurrent.MdiParent = this;
					}
					frmSysDepartment.frmCurrent.WindowState = System.Windows.Forms.FormWindowState.Maximized;
					frmSysDepartment.frmCurrent.Show();
					break;
				}
				case "职员管理":
				{
					if(frmSysEmployee.frmCurrent == null)
					{
						frmSysEmployee.frmCurrent = new frmSysEmployee();
						frmSysEmployee.frmCurrent.MdiParent = this;
					}
					frmSysEmployee.frmCurrent.WindowState = System.Windows.Forms.FormWindowState.Maximized;
					frmSysEmployee.frmCurrent.Show();
					break;
				}
				case "修改密码":
				{
					if(frmSysPWDChg.frmCurrent == null)
					{
						frmSysPWDChg.frmCurrent = new frmSysPWDChg();
//						frmSysPWDChg.frmCurrent.MdiParent = this;
					}
					frmSysPWDChg.frmCurrent.WindowState = System.Windows.Forms.FormWindowState.Normal;
					frmSysPWDChg.frmCurrent.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
					frmSysPWDChg.frmCurrent.TopMost = true;
					frmSysPWDChg.frmCurrent.ShowDialog();
					break;
				}
				case "用户权限设定":
				{
					if(frmSysUserMenu.frmCurrent == null)
					{
						frmSysUserMenu.frmCurrent = new frmSysUserMenu();
						frmSysUserMenu.frmCurrent.MdiParent = this;
					}
					frmSysUserMenu.frmCurrent.WindowState = System.Windows.Forms.FormWindowState.Maximized;
					frmSysUserMenu.frmCurrent.Show();
					break;
				}
				case "合同条款":
				{
					if(TJSystem.Basic.frmBasicDocTerm.frmCurrent == null)
					{
						frmBasicDocTerm.frmCurrent = new frmBasicDocTerm();
						frmBasicDocTerm.frmCurrent.MdiParent = this;
					}
					frmBasicDocTerm.frmCurrent.WindowState = System.Windows.Forms.FormWindowState.Maximized;
					frmBasicDocTerm.frmCurrent.Show();
					break;
				}
				case "站管理":
				{
					if(frmBrmProcess.frmCurrent == null)
					{
						frmBrmProcess.frmCurrent = new frmBrmProcess();
						frmBrmProcess.frmCurrent.MdiParent = this;
					}
					frmBrmProcess.frmCurrent.WindowState = System.Windows.Forms.FormWindowState.Maximized;
					frmBrmProcess.frmCurrent.Show();
					break;
				}
				case "流程管理":
				{
					if(frmBrmFlowDet.frmCurrent == null)
					{
						frmBrmFlowDet.frmCurrent = new frmBrmFlowDet();
						frmBrmFlowDet.frmCurrent.MdiParent = this;
					}
					frmBrmFlowDet.frmCurrent.WindowState = System.Windows.Forms.FormWindowState.Maximized;
					frmBrmFlowDet.frmCurrent.Show();
					break;
				}
				case "流程站管理":
				{
					if(frmBrmFlowMstr.frmCurrent == null)
					{
						frmBrmFlowMstr.frmCurrent = new frmBrmFlowMstr();
						frmBrmFlowMstr.frmCurrent.MdiParent = this;
					}
					frmBrmFlowMstr.frmCurrent.WindowState = System.Windows.Forms.FormWindowState.Maximized;
					frmBrmFlowMstr.frmCurrent.Show();
					break;
				}
				case "角色权限设置":
				{
					if(frmSysRoleRight.frmCurrent == null)
					{
						frmSysRoleRight.frmCurrent = new frmSysRoleRight();
						frmSysRoleRight.frmCurrent.MdiParent = this;
					}
					frmSysRoleRight.frmCurrent.WindowState = System.Windows.Forms.FormWindowState.Maximized;
					frmSysRoleRight.frmCurrent.Show();
					break;
				}
				default:
					break;
			}
			#endregion

			#region 基础资料
			switch(formname)
			{
				case "货品资料":
				{
					if(frmBasicItem.frmCurrent == null)
					{						
						frmBasicItem.frmCurrent = new frmBasicItem();
						frmBasicItem.frmCurrent.MdiParent = this;
					}
					frmBasicItem.frmCurrent.WindowState = System.Windows.Forms.FormWindowState.Maximized;
					frmBasicItem.frmCurrent.Show();					
					break;
				}
				case "货品属性设置":
				{
//					if(frmBasicItemProperty.frmCurrent == null)
//					{
//						frmBasicItemProperty.frmCurrent = new frmBasicItemProperty();
//						frmBasicItemProperty.frmCurrent.MdiParent = this;
//					}
//					frmBasicItemProperty.frmCurrent.WindowState = System.Windows.Forms.FormWindowState.Maximized;
//					frmBasicItemProperty.frmCurrent.Show();
					break;
				}
				case "常用参数维护":
				{
					if(frmBasicParams.frmCurrent == null)
					{
						frmBasicParams.frmCurrent = new frmBasicParams();
						frmBasicParams.frmCurrent.MdiParent = this;
					}
					frmBasicParams.frmCurrent.WindowState = System.Windows.Forms.FormWindowState.Maximized;
					frmBasicParams.frmCurrent.Show();
					break;
				}
				case "仓库设置":
				{
					if(frmBasicWhouse.frmCurrent == null)
					{
						frmBasicWhouse.frmCurrent = new frmBasicWhouse();
						frmBasicWhouse.frmCurrent.MdiParent = this;
					}
					frmBasicWhouse.frmCurrent.WindowState = System.Windows.Forms.FormWindowState.Maximized;
					frmBasicWhouse.frmCurrent.Show();
					break;
				}
				case "海关编码维护":
				{
					if(frmBasicCustomsParam.frmCurrent == null)
					{
						frmBasicCustomsParam.frmCurrent = new frmBasicCustomsParam();
						frmBasicCustomsParam.frmCurrent.MdiParent = this;
					}
					frmBasicCustomsParam.frmCurrent.WindowState = System.Windows.Forms.FormWindowState.Maximized;
					frmBasicCustomsParam.frmCurrent.Show();
					break;
				}
				default:
					break;
			}
			#endregion

			#region 客户关系管理
			switch(formname)
			{
				case "客户管理":
				{
					if(frmClientCustomers.frmCurrent == null)
					{
						frmClientCustomers.frmCurrent = new frmClientCustomers();
						frmClientCustomers.frmCurrent.MdiParent = this;
					}
					frmClientCustomers.frmCurrent.WindowState = System.Windows.Forms.FormWindowState.Maximized;
					frmClientCustomers.frmCurrent.Show();
					break;
				}
				case "供应商管理":
				{
					if(frmClientSuplier.frmCurrent == null)
					{
						frmClientSuplier.frmCurrent = new frmClientSuplier();
						frmClientSuplier.frmCurrent.MdiParent = this;
					}
					frmClientSuplier.frmCurrent.WindowState = System.Windows.Forms.FormWindowState.Maximized;
					frmClientSuplier.frmCurrent.Show();
					break;
				}
				case "运输商管理":
				{
					if(frmClientTrans.frmCurrent == null)
					{
						frmClientTrans.frmCurrent = new frmClientTrans();
						frmClientTrans.frmCurrent.MdiParent = this;
					}
					frmClientTrans.frmCurrent.WindowState = System.Windows.Forms.FormWindowState.Maximized;
					frmClientTrans.frmCurrent.Show();
					break;
				}
				default:
					break;
			}
			#endregion

			#region 销售管理
			switch(formname)
			{
				case "客户询价处理":
				{
					if(frmSaleCE.frmCurrent == null)
					{
						frmSaleCE.frmCurrent = new frmSaleCE();
						frmSaleCE.frmCurrent.MdiParent = this;
					}
					frmSaleCE.frmCurrent.WindowState = System.Windows.Forms.FormWindowState.Maximized;
					frmSaleCE.frmCurrent.Show();
					break;
				}
				case "报价单":
				{
					if(frmSaleCQ.frmCurrent == null)
					{
						frmSaleCQ.frmCurrent = new frmSaleCQ();
						frmSaleCQ.frmCurrent.MdiParent = this;
					}
					frmSaleCQ.frmCurrent.WindowState = System.Windows.Forms.FormWindowState.Maximized;
					frmSaleCQ.frmCurrent.Show();
					break;
				}
				case "销售订单":
				{
					if(frmSaleOrder.frmCurrent == null)
					{
						frmSaleOrder.frmCurrent = new frmSaleOrder();
						frmSaleOrder.frmCurrent.MdiParent = this;
					}
					frmSaleOrder.frmCurrent.WindowState = System.Windows.Forms.FormWindowState.Maximized;
					frmSaleOrder.frmCurrent.Show();
					break;
				}
//				case "出货通知":
//				{
//					if(frmSaleDG.frmCurrent == null)
//					{
//						frmSaleDG.frmCurrent = new frmSaleDG();
//						frmSaleDG.frmCurrent.MdiParent = this;
//					}
//					frmSaleDG.frmCurrent.WindowState = System.Windows.Forms.FormWindowState.Maximized;
//					frmSaleDG.frmCurrent.Show();
//					break;
//				}
//				case "送样管理":
//				{
//					if(frmSaleSR.frmCurrent == null)
//					{
//						frmSaleSR.frmCurrent = new frmSaleSR();
//						frmSaleSR.frmCurrent.MdiParent = this;
//					}
//					frmSaleSR.frmCurrent.WindowState = System.Windows.Forms.FormWindowState.Maximized;
//					frmSaleSR.frmCurrent.Show();
//					break;
//				}
				case "销售退货":
				{
					if(frmSaleSS.frmCurrent == null)
					{
						frmSaleSS.frmCurrent = new frmSaleSS();
						frmSaleSS.frmCurrent.MdiParent = this;
					}
					frmSaleSS.frmCurrent.WindowState = System.Windows.Forms.FormWindowState.Maximized;
					frmSaleSS.frmCurrent.Show();
					break;
				}
				default:
					break;
			}
			#endregion

			#region 采购管理
			switch(formname)
			{
				case "采购询价":
				{
					if(frmPurchaseSE.frmCurrent == null)
					{
						frmPurchaseSE.frmCurrent = new frmPurchaseSE();
						frmPurchaseSE.frmCurrent.MdiParent = this;
					}
					frmPurchaseSE.frmCurrent.WindowState = System.Windows.Forms.FormWindowState.Maximized;
					frmPurchaseSE.frmCurrent.Show();
					break;
				}
				case "供应商报价处理":
				{
					if(frmPurchaseSQ.frmCurrent == null)
					{
						frmPurchaseSQ.frmCurrent = new frmPurchaseSQ();
						frmPurchaseSQ.frmCurrent.MdiParent = this;
					}
					frmPurchaseSQ.frmCurrent.WindowState = System.Windows.Forms.FormWindowState.Maximized;
					frmPurchaseSQ.frmCurrent.Show();
					break;
				}
				case "采购订单":
				{
					if(frmPurchasePO.frmCurrent == null)
					{
						frmPurchasePO.frmCurrent = new frmPurchasePO();
						frmPurchasePO.frmCurrent.MdiParent = this;
					}
					frmPurchasePO.frmCurrent.WindowState = System.Windows.Forms.FormWindowState.Maximized;
					frmPurchasePO.frmCurrent.Show();
					break;
				}
//				case "收样管理":
//				{
//					if(frmPurchaseRM.frmCurrent == null)
//					{
//						frmPurchaseRM.frmCurrent = new frmPurchaseRM();
//						frmPurchaseRM.frmCurrent.MdiParent = this;
//					}
//					frmPurchaseRM.frmCurrent.WindowState = System.Windows.Forms.FormWindowState.Maximized;
//					frmPurchaseRM.frmCurrent.Show();
//					break;
//				}
				case "采购退货":
				{
					if(frmPurchaseRS.frmCurrent == null)
					{
						frmPurchaseRS.frmCurrent = new frmPurchaseRS();
						frmPurchaseRS.frmCurrent.MdiParent = this;
					}
					frmPurchaseRS.frmCurrent.WindowState = System.Windows.Forms.FormWindowState.Maximized;
					frmPurchaseRS.frmCurrent.Show();
					break;
				}
				default:
					break;
			}
			#endregion

			#region 库存管理
			switch(formname)
			{
				case "采购入库":
				{
					if(frmStockBuyIN.frmCurrent == null)
					{
						frmStockBuyIN.frmCurrent = new frmStockBuyIN();
						frmStockBuyIN.frmCurrent.MdiParent = this;
					}
					frmStockBuyIN.frmCurrent.WindowState = System.Windows.Forms.FormWindowState.Maximized;
					frmStockBuyIN.frmCurrent.Show();
					break;
				}
				case "销售出库":
				{
					if(frmStockSellOut.frmCurrent == null)
					{
						frmStockSellOut.frmCurrent = new frmStockSellOut();
						frmStockSellOut.frmCurrent.MdiParent = this;
					}
					frmStockSellOut.frmCurrent.WindowState = System.Windows.Forms.FormWindowState.Maximized;
					frmStockSellOut.frmCurrent.Show();
					break;
				}
				case "库存调整":
				{
					if(frmStockChange.frmCurrent == null)
					{
						frmStockChange.frmCurrent = new frmStockChange();
						frmStockChange.frmCurrent.MdiParent = this;
					}
					frmStockChange.frmCurrent.WindowState = System.Windows.Forms.FormWindowState.Maximized;
					frmStockChange.frmCurrent.Show();
					break;
				}
				case "盘点":
				{
					if(frmStockCycle.frmCurrent == null)
					{
						frmStockCycle.frmCurrent = new frmStockCycle();
						frmStockCycle.frmCurrent.MdiParent = this;
					}
					frmStockCycle.frmCurrent.WindowState = System.Windows.Forms.FormWindowState.Maximized;
					frmStockCycle.frmCurrent.Show();
					break;
				}
				default:
					break;
			}
			#endregion

			#region 帐务处理
			switch(formname)
			{
				case "运费付款单":
				{
					if(frmFreightBillhead.frmCurrent == null)
					{
						frmFreightBillhead.frmCurrent = new frmFreightBillhead();
						frmFreightBillhead.frmCurrent.MdiParent = this;
					}
					frmFreightBillhead.frmCurrent.WindowState = System.Windows.Forms.FormWindowState.Maximized;
					frmFreightBillhead.frmCurrent.Show();
					break;
				}
				case "付款单":
				{
					if(frmPaymentBill.frmCurrent == null)
					{
						frmPaymentBill.frmCurrent = new frmPaymentBill();
						frmPaymentBill.frmCurrent.MdiParent = this;
					}
					frmPaymentBill.frmCurrent.WindowState = System.Windows.Forms.FormWindowState.Maximized;
					frmPaymentBill.frmCurrent.Show();
					break;
				}
				case "收款单":
				{
					if(frmGatheringBill.frmCurrent == null)
					{
						frmGatheringBill.frmCurrent = new frmGatheringBill();
						frmGatheringBill.frmCurrent.MdiParent = this;
					}
					frmGatheringBill.frmCurrent.WindowState = System.Windows.Forms.FormWindowState.Maximized;
					frmGatheringBill.frmCurrent.Show();
					break;
				}
				case "付款单冲销应付单":
				{
					if(frmPaymentBillBalance.frmCurrent == null)
					{
						frmPaymentBillBalance.frmCurrent = new frmPaymentBillBalance();
						frmPaymentBillBalance.frmCurrent.MdiParent = this;
					}
					frmPaymentBillBalance.frmCurrent.WindowState = System.Windows.Forms.FormWindowState.Maximized;
					frmPaymentBillBalance.frmCurrent.Show();
					break;
				}
				case "运费付款单冲销应付运费单":
				{
					if(frmFreightPaymentBillBalance.frmCurrent == null)
					{
						frmFreightPaymentBillBalance.frmCurrent = new frmFreightPaymentBillBalance();
						frmFreightPaymentBillBalance.frmCurrent.MdiParent = this;
					}
					frmFreightPaymentBillBalance.frmCurrent.WindowState = System.Windows.Forms.FormWindowState.Maximized;
					frmFreightPaymentBillBalance.frmCurrent.Show();
					break;
				}
				case "应收/应付登账":
				{
					if(frmGatheringPaymentBill.frmCurrent == null)
					{
						frmGatheringPaymentBill.frmCurrent = new frmGatheringPaymentBill();
						frmGatheringPaymentBill.frmCurrent.MdiParent = this;
					}
					frmGatheringPaymentBill.frmCurrent.WindowState = System.Windows.Forms.FormWindowState.Maximized;
					frmGatheringPaymentBill.frmCurrent.Show();
					break;
				}
				case "收款单冲销应收单":
				{
					if(frmGatheringBillBalance.frmCurrent == null)
					{
						frmGatheringBillBalance.frmCurrent = new frmGatheringBillBalance();
						frmGatheringBillBalance.frmCurrent.MdiParent = this;
					}
					frmGatheringBillBalance.frmCurrent.WindowState = System.Windows.Forms.FormWindowState.Maximized;
					frmGatheringBillBalance.frmCurrent.Show();
					break;
				}
				case "客户索赔":
				{
					if(frmAccountCC.frmCurrent == null)
					{
						frmAccountCC.frmCurrent = new frmAccountCC();
						frmAccountCC.frmCurrent.MdiParent = this;
					}
					frmAccountCC.frmCurrent.WindowState = System.Windows.Forms.FormWindowState.Maximized;
					frmAccountCC.frmCurrent.Show();
					break;
				}
				case "收款通知单":
				{
					if(frmAccountDebit.frmCurrent == null)
					{
						frmAccountDebit.frmCurrent = new frmAccountDebit();
						frmAccountDebit.frmCurrent.MdiParent = this;
					}
					frmAccountDebit.frmCurrent.WindowState = System.Windows.Forms.FormWindowState.Maximized;
					frmAccountDebit.frmCurrent.Show();
					break;
				}
				case "罚款单":
				{
					if(frmAccountFF.frmCurrent == null)
					{
						frmAccountFF.frmCurrent = new frmAccountFF();
						frmAccountFF.frmCurrent.MdiParent = this;
					}
					frmAccountFF.frmCurrent.WindowState = System.Windows.Forms.FormWindowState.Maximized;
					frmAccountFF.frmCurrent.Show();
					break;
				}
				default:
					break;
			}
			#endregion

			#region 单证管理
			switch(formname)
			{
				case "单证管理":
				{
					if(frmSaleDoc.frmCurrent == null)
					{
						frmSaleDoc.frmCurrent = new frmSaleDoc();
						frmSaleDoc.frmCurrent.MdiParent = this;
					}
					frmSaleDoc.frmCurrent.WindowState = System.Windows.Forms.FormWindowState.Maximized;
					frmSaleDoc.frmCurrent.Show();
					break;
				}	
				case "核销单管理":
				{
					if(TJSystem.Doc.frmVrfDocv.frmCurrent == null)
					{
						TJSystem.Doc.frmVrfDocv.frmCurrent = new TJSystem.Doc.frmVrfDocv();
						TJSystem.Doc.frmVrfDocv.frmCurrent.MdiParent = this;
					}
					TJSystem.Doc.frmVrfDocv.frmCurrent.WindowState = System.Windows.Forms.FormWindowState.Maximized;
					TJSystem.Doc.frmVrfDocv.frmCurrent.Show();
					break;
				}		
				case "货物托运单":
				{
					if(TJSystem.Doc.frmAwbDoc.frmCurrent == null)
					{
						TJSystem.Doc.frmAwbDoc.frmCurrent = new TJSystem.Doc.frmAwbDoc();
						TJSystem.Doc.frmAwbDoc.frmCurrent.MdiParent = this;
					}
					TJSystem.Doc.frmAwbDoc.frmCurrent.WindowState = System.Windows.Forms.FormWindowState.Maximized;
					TJSystem.Doc.frmAwbDoc.frmCurrent.Show();
					break;
				}
				case "信用证管理":
				{
					if(TJSystem.Doc.frmLCDoc.frmCurrent == null)
					{
						TJSystem.Doc.frmLCDoc.frmCurrent = new TJSystem.Doc.frmLCDoc();
						TJSystem.Doc.frmLCDoc.frmCurrent.MdiParent = this;
					}
					TJSystem.Doc.frmLCDoc.frmCurrent.WindowState = System.Windows.Forms.FormWindowState.Maximized;
					TJSystem.Doc.frmLCDoc.frmCurrent.Show();
					break;
				}	
				case "报关单管理":
				{
					if(TJSystem.Doc.frmCustomerDoc.frmCurrent == null)
					{
						TJSystem.Doc.frmCustomerDoc.frmCurrent = new TJSystem.Doc.frmCustomerDoc();
						TJSystem.Doc.frmCustomerDoc.frmCurrent.MdiParent = this;
					}
					TJSystem.Doc.frmCustomerDoc.frmCurrent.WindowState = System.Windows.Forms.FormWindowState.Maximized;
					TJSystem.Doc.frmCustomerDoc.frmCurrent.Show();
					break;
				}		
				default:
					break;
			}
			#endregion

			#region 报表查询
			switch(formname)
			{
				case "盈亏报表":
				{
					if(TJSystem.Report.frmRptBalance.frmCurrent == null)
					{
						TJSystem.Report.frmRptBalance.frmCurrent = new TJSystem.Report.frmRptBalance();
						TJSystem.Report.frmRptBalance.frmCurrent.MdiParent = this;
					}
					TJSystem.Report.frmRptBalance.frmCurrent.WindowState = System.Windows.Forms.FormWindowState.Maximized;
					TJSystem.Report.frmRptBalance.frmCurrent.Show();
					break;
				}	
				case "销售记录":
				{
					if(TJSystem.Report.frmRptSaleHis.frmCurrent == null)
					{
						TJSystem.Report.frmRptSaleHis.frmCurrent = new TJSystem.Report.frmRptSaleHis();
						TJSystem.Report.frmRptSaleHis.frmCurrent.MdiParent = this;
					}
					TJSystem.Report.frmRptSaleHis.frmCurrent.WindowState = System.Windows.Forms.FormWindowState.Maximized;
					TJSystem.Report.frmRptSaleHis.frmCurrent.Show();
					break;
				}		
				case "采购记录":
				{
					if(TJSystem.Report.frmRptPurHis.frmCurrent == null)
					{
						TJSystem.Report.frmRptPurHis.frmCurrent = new TJSystem.Report.frmRptPurHis();
						TJSystem.Report.frmRptPurHis.frmCurrent.MdiParent = this;
					}
					TJSystem.Report.frmRptPurHis.frmCurrent.WindowState = System.Windows.Forms.FormWindowState.Maximized;
					TJSystem.Report.frmRptPurHis.frmCurrent.Show();
					break;
				}		
				case "库存查询":
				{
					if(TJSystem.Report.frmRptStockStat.frmCurrent == null)
					{
						TJSystem.Report.frmRptStockStat.frmCurrent = new TJSystem.Report.frmRptStockStat();
						TJSystem.Report.frmRptStockStat.frmCurrent.MdiParent = this;
					}
					TJSystem.Report.frmRptStockStat.frmCurrent.WindowState = System.Windows.Forms.FormWindowState.Maximized;
					TJSystem.Report.frmRptStockStat.frmCurrent.Show();
					break;
				}	
					//用户操作记录
				case "用户操作记录":
				{
					if(TJSystem.Report.frmRptOPHis.frmCurrent == null)
					{
						TJSystem.Report.frmRptOPHis.frmCurrent = new TJSystem.Report.frmRptOPHis();
						TJSystem.Report.frmRptOPHis.frmCurrent.MdiParent = this;
					}
					TJSystem.Report.frmRptOPHis.frmCurrent.WindowState = System.Windows.Forms.FormWindowState.Maximized;
					TJSystem.Report.frmRptOPHis.frmCurrent.Show();
					break;
				}	
				default:
					break;
			}
			#endregion


			#region 实用工具
			switch(formname)
			{
				case "审核中心":
				{
					if(frmToolConformCenter.frmCurrent == null)
					{
						frmToolConformCenter.frmCurrent = new frmToolConformCenter();
						frmToolConformCenter.frmCurrent.MdiParent = this;
					}
					frmToolConformCenter.frmCurrent.WindowState = System.Windows.Forms.FormWindowState.Maximized;
					frmToolConformCenter.frmCurrent.Show();
					break;
				}
				
				default:
					break;
			}
			#endregion
			this.Cursor = System.Windows.Forms.Cursors.Default ;
			#region 工时系统
			switch(formname)
			{
				case "工作日报":
				{
					if(TJSystem.WorkHis.frmWorkRpt.frmCurrent == null)
					{
						TJSystem.WorkHis.frmWorkRpt.frmCurrent = new TJSystem.WorkHis.frmWorkRpt();
						TJSystem.WorkHis.frmWorkRpt.frmCurrent.MdiParent = this;
					}
					TJSystem.WorkHis.frmWorkRpt.frmCurrent.WindowState = System.Windows.Forms.FormWindowState.Maximized;
					TJSystem.WorkHis.frmWorkRpt.frmCurrent.Show();
					break;
				}	
				
				default:
					break;
			}
			#endregion
			this.Cursor = System.Windows.Forms.Cursors.Default ;
		}

		private void showTreeNodeForm(System.Windows.Forms.TreeNode tn)
		{
			switch(tn.Text)
			{
						
				case "系统维护":
				{
					#region 系统维护
					foreach(System.Windows.Forms.TreeNode ctn in tn.Nodes)
					{
						if(ctn.IsSelected && ctn.GetNodeCount(true)==0)
						{
							shorForm(ctn.Text);
						}
					}
					break;
					#endregion
				}
				case "基础资料":
				{
					#region 基础资料
					foreach(System.Windows.Forms.TreeNode ctn in tn.Nodes)
					{
						if(ctn.IsSelected && ctn.GetNodeCount(true)==0)
						{
							shorForm(ctn.Text);
						}
					}
					break;
					#endregion
				}
				case "客户关系管理":
				{
					#region 客户关系管理
					foreach(System.Windows.Forms.TreeNode ctn in tn.Nodes)
					{
						if(ctn.IsSelected && ctn.GetNodeCount(true)==0)
						{
							shorForm(ctn.Text);
						}
					}
					break;
					#endregion
				}
				case "销售管理":
				{
					#region 销售管理
					foreach(System.Windows.Forms.TreeNode ctn in tn.Nodes)
					{
						if(ctn.IsSelected && ctn.GetNodeCount(true)==0)
						{
							shorForm(ctn.Text);
						}
					}
					break;
					#endregion
				}
				case "采购管理":
				{
					#region 采购管理
					foreach(System.Windows.Forms.TreeNode ctn in tn.Nodes)
					{
						if(ctn.IsSelected && ctn.GetNodeCount(true)==0)
						{
							shorForm(ctn.Text);
						}
					}
					break;
					#endregion
				}
				case "库存管理":
				{
					#region 库存管理
					foreach(System.Windows.Forms.TreeNode ctn in tn.Nodes)
					{
						if(ctn.IsSelected && ctn.GetNodeCount(true)==0)
						{
							shorForm(ctn.Text);
						}
					}
					break;
					#endregion
				}
					//Modify By Jack 2006/12/05 增加帐务处理
				case "帐务处理":
				{
					#region 帐务处理
					foreach(System.Windows.Forms.TreeNode ctn in tn.Nodes)
					{
						if(ctn.IsSelected && ctn.GetNodeCount(true)==0)
						{
							shorForm(ctn.Text);
						}
					}
					break;
					#endregion
				}
				case "单证管理":
				{
					#region 单证管理
					foreach(System.Windows.Forms.TreeNode ctn in tn.Nodes)
					{
						if(ctn.IsSelected && ctn.GetNodeCount(true)==0)
						{
							shorForm(ctn.Text);
						}
					}
					break;
					#endregion
				}
				case "报表查询":
				{
					#region 报表查询
					foreach(System.Windows.Forms.TreeNode ctn in tn.Nodes)
					{
						if(ctn.IsSelected && ctn.GetNodeCount(true)==0)
						{
							shorForm(ctn.Text);
						}
					}
					break;
					#endregion
				}
				case "工时系统":
				{
					#region 工时系统
					foreach(System.Windows.Forms.TreeNode ctn in tn.Nodes)
					{
						if(ctn.IsSelected && ctn.GetNodeCount(true)==0)
						{
							shorForm(ctn.Text);
						}
					}
					break;
					#endregion
				}
				case "实用工具":
				{
					#region 实用工具
					foreach(System.Windows.Forms.TreeNode ctn in tn.Nodes)
					{
						if(ctn.IsSelected && ctn.GetNodeCount(true)==0)
						{
							shorForm(ctn.Text);
						}
					}
					break;
					#endregion
				}
				default:
					break;
			}
		}

		private void splitter1_DoubleClick(object sender, System.EventArgs e)
		{
			ShowTreeView();
		}

		private void timer1_Tick(object sender, System.EventArgs e)
		{
			this.staB3.Text = System.DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss");
			this.staB4.Text = TJSystem.Public.PublicStatic.getWeekDay();
		}

		private void menuItem17_Click(object sender, System.EventArgs e)
		{
			/*
			System.Windows.Forms.Form[] frmArray = this.MdiChildren;
			if(frmArray.Length > 0)
			{
				MessageBox.Show("This are mdichildred!");
				for(int i=0 ; i < frmArray.Length; i ++)
				{
					MessageBox.Show(frmArray[i].Text);
				}
			}
			*/
			this.LayoutMdi(System.Windows.Forms.MdiLayout.TileVertical);
			
		}

		private void menuItem18_Click(object sender, System.EventArgs e)
		{
			this.LayoutMdi(System.Windows.Forms.MdiLayout.TileHorizontal);
		}

		private void menuItem19_Click(object sender, System.EventArgs e)
		{
			this.LayoutMdi(System.Windows.Forms.MdiLayout.Cascade);
		}

		private void menuItem24_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}

		private void menuItem23_Click(object sender, System.EventArgs e)
		{
			if(this.MdiChildren.Length <= 0)
			{
				MessageBox.Show("没有可以关闭的活动画面!","警告",MessageBoxButtons.OK,MessageBoxIcon.Warning);
				return;
			}
			this.ActiveMdiChild.Close();
			
		}

		private void frmMain_Load(object sender, System.EventArgs e)
		{
		
		}

		protected override void OnClosing(CancelEventArgs e)
		{			
			if(frmLogout == false)
			{
				if(MessageBox.Show("确定退出？（Y/N）","确认",MessageBoxButtons.YesNo,MessageBoxIcon.Information) == System.Windows.Forms.DialogResult.No)
				{
					e.Cancel = true;
				}
				else
				{
					string strsql = "update tj_loginout set logout_time = '";
					strsql += System.DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "' ";
					strsql += " where login_time='" + TJSystem.Public.PublicStatic.LoginTime + "'";
					strsql += " and user_id='" + TJSystem.Public.PublicStatic.LoginUser + "'";
					strsql += " and client_addr='" + System.Net.Dns.GetHostName() + "'";
					TJSystem.Public.PublicStatic.db.ExeSql(strsql);

					TJSystem.Public.PublicStatic.FormClose = true;
				}
			}
			else
			{
				string strsql = "update tj_loginout set logout_time = '";
				strsql += System.DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "' ";
				strsql += " where login_time='" + TJSystem.Public.PublicStatic.LoginTime + "'";
				strsql += " and user_id='" + TJSystem.Public.PublicStatic.LoginUser + "'";
				strsql += " and client_addr='" + System.Net.Dns.GetHostName() + "'";
				TJSystem.Public.PublicStatic.db.ExeSql(strsql);
			}
			base.OnClosing (e);
		}

		private void frmMain_MdiChildActivate(object sender, System.EventArgs e)
		{
			MenuEvent();
			if(TJSystem.Public.PublicStatic.formClose && !TJSystem.Public.PublicStatic.formName.Equals(""))
			{
				removeMenuItemByString(TJSystem.Public.PublicStatic.formName);
				TJSystem.Public.PublicStatic.formClose = false;
				TJSystem.Public.PublicStatic.formName = "";
			}
		}

		private void MenuEvent()
		{
			bool isExsist = false;
			int i = 0;
			System.Text.StringBuilder sbCaption = new System.Text.StringBuilder();
				
			
			if(this.ActiveMdiChild == null)
			{
				return;
			}
			
			foreach(System.Windows.Forms.MenuItem mi in this.menuWindow.MenuItems)
			{
				i ++;
				mi.Checked = false;
				
				if(mi.Text.Equals(ActiveMdiChild.Text))
				{
					isExsist = true;
					mi.Checked = true;
				}
			}

			for(int j = 0; j < i - 5; j ++)
			{
				if(menuItemAdd[j] == null)
				{
					continue;
				}
				removeMenuItem(menuItemAdd[j]);
			}

			if(!isExsist)
			{
				this.totalMenu += 1;
				if(i - 5 > 4)
				{
					MessageBox.Show("超过5个了!");
					return;
				}
				menuItemAdd[i-5] = new MenuItem(ActiveMdiChild.Text);
				this.menuWindow.MenuItems.AddRange(new System.Windows.Forms.MenuItem[]
													{
														menuItemAdd[i-5]
													}
					);
				menuItemAdd[i-5].Click += new EventHandler(menuItemAdd_Click);
				menuItemAdd[i-5].Checked = true;
			}
		}

		private void removeMenuItemByString(string caption)
		{
			bool formExisit = false;
			if(this.MdiChildren.Length == 0)
			{
				return;
			}
			foreach(System.Windows.Forms.MenuItem mi in this.menuWindow.MenuItems)
			{
				if(mi.Text.Equals(caption))
				{					
					this.menuWindow.MenuItems.Remove(mi);
					break;	
				}
			}		
		}

		private void removeMenuItem(System.Windows.Forms.MenuItem mi)
		{
			bool formExisit = false;
			if(this.MdiChildren.Length == 0)
			{
				return;
			}
			foreach(System.Windows.Forms.Form frm in this.MdiChildren)
			{
				if(frm.Text.Equals(mi.Text))
				{					
					formExisit = true;					
				}
			}		
			if(!formExisit)
			{
				this.menuWindow.MenuItems.Remove(mi);
				mi = null;
			}
		}

		private void menuItemAdd_Click(object sender, System.EventArgs e)
		{			
//			foreach(System.Windows.Forms.Form frm in this.MdiChildren)
			{
//				if(frm.Text.Equals(((System.Windows.Forms.MenuItem)sender).Text))
				{
//					this.shorForm(frm.Text);
					this.shorForm(((System.Windows.Forms.MenuItem)sender).Text);
					((System.Windows.Forms.MenuItem)sender).Checked = true;
				}
			}		
			removeMenuItem((System.Windows.Forms.MenuItem)sender);
		}

		private void frmMain_Activated(object sender, System.EventArgs e)
		{
		
		}

		private void frmMain_Validated(object sender, System.EventArgs e)
		{
			this.MenuEvent();
		}

		private void menuItem20_Click(object sender, System.EventArgs e)
		{
			if(this.MdiChildren.Length == 0)
				return;
			this.ActiveMdiChild.WindowState = System.Windows.Forms.FormWindowState.Maximized;
		}

		private void menuItem3_Click(object sender, System.EventArgs e)
		{
			/*
			System.Text.StringBuilder sb = new System.Text.StringBuilder();
			sb.Append("Infomation");
			sb.Append("\r\nAuthor :    Terry Shen");
			sb.Append("\r\nMail   :    nj_terry@163.com");
			sb.Append("\r\nQQ     :    43957276");
			sb.Append("\r\nTel    :    13813800492");
			sb.Append("\r\nVersion:    1.0.0");
			sb.Append("\r\n软件信息");
			sb.Append("\r\n作者     :    Terry Shen");
			sb.Append("\r\n电子邮件 :    nj_terry@163.com");
			sb.Append("\r\nQQ号码   :    43957276");
			sb.Append("\r\n联系电话 :    13813800492");
			sb.Append("\r\n版本号   :    1.0.0");
			TJSystem.Public.PublicStatic.ShowMessage(TJSystem.Public.MessageType.Information,sb.ToString());
			*/
			TJSystem.frmAbout frm = new frmAbout();
			frm.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			frm.ShowDialog();
		}

		private void menuItem2_Click(object sender, System.EventArgs e)
		{
			try
			{
				Help.ShowHelpIndex(this,"Help.pdf") ;
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.Message,"Infomation",MessageBoxButtons.OK,MessageBoxIcon.Exclamation) ;
			}
		}

		public bool ApproveEnable
		{
			set
			{
				tbbApprove.Visible = value;
			}
			get
			{
				return tbbApprove.Visible;
			}
		}

		public bool ApproveCancelEnable 
		{
			set
			{
				tbbApproveCancel.Visible = value;
			}
			get
			{
				return tbbApproveCancel.Visible;
			}
		}

		private void AddRegMenu()
		{
			if(!blregd)
			{
				System.Windows.Forms.MenuItem mi = new MenuItem("注册");
				this.menuItem1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[]
													{
														mi
													}
					);
				mi.Click += new EventHandler(mi_Click);
			}
			
			System.Windows.Forms.MenuItem miCfg = new MenuItem("数据库参数配置");
			this.menuItem1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[]
													{
														miCfg
													}
				);
			miCfg.Click += new EventHandler(miCfg_Click);
	
		}

		private void mi_Click(object sender, System.EventArgs e)
		{
			try
			{
				TJSystem.frmRegister frm = new frmRegister();
				frm.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
				frm.ShowDialog();
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.Message,"Infomation",MessageBoxButtons.OK,MessageBoxIcon.Exclamation) ;
			}
		}

		private void miCfg_Click(object sender, System.EventArgs e)
		{
			try
			{
				TJSystem.frmConfig frm = new frmConfig(false);
				frm.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
				frm.ShowDialog();
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.Message,"Infomation",MessageBoxButtons.OK,MessageBoxIcon.Exclamation) ;
			}
		}

		private void treeView1_AfterSelect(object sender, System.Windows.Forms.TreeViewEventArgs e)
		{
		
		}

		#region" 公共属性 "

		[Browsable(true),Description("背景图片呈现风格：File填充，以截取右上角或重复出现的方式填满整个工作区；Draw拉伸，一张图片拉伸后布满工作区；Logo标志，一张图片，其他属性控制具体位置。"), Category("MDI背景扩展设置")]
		public MDIbg_TypeList MDIbg_Type
		{
			get 
			{
				object obj=_mdibg_type;
				return (obj==null)?MDIbg_TypeList.File:(MDIbg_TypeList)obj;
			}
			set { _mdibg_type=value;  }
		}


		[Browsable(true),Description("MDIContainer背景图片"),Category("MDI背景扩展设置")]
		public Image MDIbg_Image
		{
			get { return _mdibg_image; }
			set { _mdibg_image=value;  }
		}


		[Browsable(true),Description("MDIContainer第二背景图片，MDIbg_Type设置为Logo时，此属性对应图片以拉伸的形式在MDIbg_Image的下一层布满工作区，若留空则由背景色替代。"), Category("MDI背景扩展设置")]
		public Image MDIbg_bgImage
		{
			get { return _mdibg_bgimage; }
			set { _mdibg_bgimage=value;  }
		}


  
		[Browsable(true),Description("MDIbg_Image的左右对齐方式，取值为Left、Center、Right，MDIbg_Type设置为Logo时有效。"), Category("MDI背景扩展设置")]
		public MDIbg_AlignList MDIbg_Align
		{
			get 
			{
				object obj=_mdibg_align;
				return (obj==null)?MDIbg_AlignList.Left:(MDIbg_AlignList)obj;
			}
			set { _mdibg_align=value;  }
		}


		[Browsable(true),Description("MDIbg_Image的上下对齐方式，取值为Top、Middle、Bottom，MDIbg_Type设置为Logo时有效。"), Category("MDI背景扩展设置")]
		public MDIbg_ValignList MDIbg_Valign
		{
			get 
			{
				object obj=_mdibg_valign;
				return (obj==null)?MDIbg_ValignList.Top:(MDIbg_ValignList)obj;
			}
			set { _mdibg_valign=value;  }
		}


		#endregion

		#region" 枚举相关 "

		//呈现风格枚举
		public enum MDIbg_TypeList:byte
		{   
			File, //File填充，多张图片重复后布满工作区     
   
			Draw, //Draw拉伸，一张图片拉伸后布满工作区
   
			Logo //Logo标志，一张图片，其他属性控制具体位置   
		}


		//图片左右对齐方式枚举
		public enum MDIbg_AlignList:byte
		{   
			Left, //居左     
   
			Center, //居中
   
			Right //居右   
		}


		//图片上下对齐方式枚举
		public enum MDIbg_ValignList:byte
		{   
			Top, //居上     
   
			Middle, //居中
   
			Bottom //居下
   
		}

		#endregion 

		private void MDI_Set(object sender, System.EventArgs e)
		{
			if(this.IsMdiContainer)
			{    
				foreach(System.Windows.Forms.Control myControl in this.Controls)
				{
					if(myControl.GetType().ToString() == "System.Windows.Forms.MdiClient")
					{
						bgMDIClient = (System.Windows.Forms.MdiClient)myControl;     
						break;
					}
				}

				System.IO.Directory.SetCurrentDirectory(TJSystem.Public.PublicStatic.StartupPath);
				_mdibg_image = System.Drawing.Image.FromFile("images\\mdibg.jpg");

				this.MDIbg_Type = MDIbg_TypeList.Draw;
				this.MDIbg_Valign = MDIbg_ValignList.Bottom;
				this.MDIbg_Align = MDIbg_AlignList.Right;
    
				if(bgMDIClient.ClientSize.Width>0&&bgMDIClient.ClientSize.Height>0&&MDIbg_Image!=null)
				{

					System.Drawing.Bitmap myImg = new Bitmap(bgMDIClient.ClientSize.Width,bgMDIClient.ClientSize.Height);   
					System.Drawing.Graphics myGraphics = System.Drawing.Graphics.FromImage(myImg); 
					myGraphics.Clear(this.BackColor);

					switch (this.MDIbg_Type)
					{
						case MDIbg_TypeList.File:
							//填充
							myImg = new Bitmap(this.MDIbg_Image);
							myGraphics = System.Drawing.Graphics.FromImage(myImg);
							myGraphics.Clear(this.BackColor);
							myGraphics.DrawImage(this.MDIbg_Image,0,0,myImg.Width+1,myImg.Height+1);
							bgMDIClient.BackgroundImage =myImg;
							myGraphics.Dispose();
							break;
						case MDIbg_TypeList.Draw:
							//拉伸             
							myGraphics.DrawImage(this.MDIbg_Image,0,0,myImg.Width+1,myImg.Height+1);
							bgMDIClient.BackgroundImage = myImg;
							myGraphics.Dispose(); 
							break;
						case MDIbg_TypeList.Logo:
							//标志       
							myGraphics.Clear(this.BackColor);
       
							if(this.MDIbg_bgImage!=null)
							{
								myGraphics.DrawImage(this.MDIbg_bgImage,0,0,myImg.Width+1,myImg.Height+1);
							}
							//定位
							int myX,myY;
						switch(this.MDIbg_Align)
						{
							case MDIbg_AlignList.Left:
								myX=0;
								break;
							case MDIbg_AlignList.Right:
								myX=myImg.Width-MDIbg_Image.Width;
								break;

							case MDIbg_AlignList.Center:
								myX=(myImg.Width-MDIbg_Image.Width)/2;
								break;
							default:
								myX=0;
								break;
						}
						switch(this.MDIbg_Valign)
						{
							case MDIbg_ValignList.Top:
								myY=0;
								break;
							case MDIbg_ValignList.Bottom:
								myY=myImg.Height -MDIbg_Image.Height;
								break;

							case MDIbg_ValignList.Middle:
								myY=(myImg.Height -MDIbg_Image.Height)/2;
								break;
							default:
								myY=0;
								break;
						}
							myGraphics.DrawImage(this.MDIbg_Image,myX,myY,this.MDIbg_Image.Width,this.MDIbg_Image.Height);
							bgMDIClient.BackgroundImage = myImg;
							myGraphics.Dispose();
							break;
						default:
							//填充
							bgMDIClient.BackgroundImage =this.MDIbg_Image;       
							break;
					}
				}
    
   
   
			}
		}

		private void menuItem5_Click(object sender, System.EventArgs e)
		{
			if(TJSystem.frmCopyForm.frmCurrent == null)
			{						
				frmCopyForm.frmCurrent = new frmCopyForm();
//				frmCopyForm.frmCurrent.MdiParent = this;
			}
//			frmConfig.frmCurrent.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			frmCopyForm.frmCurrent.ShowDialog();					
		}

		private void menuItem6_Click(object sender, System.EventArgs e)
		{
			if(TJSystem.frmUpdateSysTime.frmCurrent == null)
			{						
				frmUpdateSysTime.frmCurrent = new frmUpdateSysTime();
			}
			frmUpdateSysTime.frmCurrent.ShowDialog();		
		}

		private void menuItem7_Click(object sender, System.EventArgs e)
		{
			if(TJSystem.frmSearchCustomer.frmCurrent == null)
			{						
				frmSearchCustomer.frmCurrent = new frmSearchCustomer();
//				frmSaleCE.frmCurrent.MdiParent = this;
			}
			frmSearchCustomer.frmCurrent.Show();		
		}

		
	}
}

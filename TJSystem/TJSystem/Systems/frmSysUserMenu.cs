using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace TJSystem.Systems
{
	/// <summary>
	/// Form1 的摘要说明。
	/// </summary>
	public class frmSysUserMenu : System.Windows.Forms.Form
	{
		
		
		/// <summary>
		/// 必需的设计器变量。
		/// </summary>
		private System.ComponentModel.Container components = null;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.DataGridTableStyle dataGridTableStyle1;
		private System.Windows.Forms.DataGrid dataGrid1;
		private System.Windows.Forms.Panel panel4;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Panel panel3;
		private TJSystem.UC.PriToolBar priToolBar1;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn21;
		private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn22;
		private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn23;
		private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn24;
		private TJSystem.Classes.PriComboBox comboBox1;
		private TJSystem.Classes.PriComboBox priComboBox1;
		private System.Windows.Forms.Label label3;
		private TJSystem.Classes.PriComboBox priComboBox2;
		private System.Windows.Forms.Label label4;
		private TJSystem.Classes.PriComboBox priComboBox3;
		private System.Windows.Forms.Label label5;
		private TJSystem.Classes.PriComboBox priComboBox4;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label21;
		private TJSystem.Classes.PriTextBox priTextBox19;
		private System.Windows.Forms.Label label20;
		private TJSystem.Classes.PriTextBox priTextBox18;
		private System.Windows.Forms.Label label15;
		private TJSystem.Classes.PriTextBox priTextBox11;
		private System.Windows.Forms.Label label17;
		private TJSystem.Classes.PriTextBox priTextBox8;
		private System.Windows.Forms.DataGridTextBoxColumn employee_id;
		private System.Windows.Forms.DataGridTextBoxColumn insert_flag;
		private System.Windows.Forms.DataGridTextBoxColumn update_flag;
		private System.Windows.Forms.DataGridTextBoxColumn delete_flag;
		private System.Windows.Forms.DataGridTextBoxColumn createby;
		private System.Windows.Forms.DataGridTextBoxColumn createon;
		private System.Windows.Forms.DataGridTextBoxColumn modifyby;
		private System.Windows.Forms.DataGridTextBoxColumn modifyon;
		private System.Windows.Forms.DataGridTextBoxColumn XF_PROGRAMNAME;
		public static System.Windows.Forms.Form frmCurrent = null ;

		private string _table = null;
		private System.Windows.Forms.DataGridTextBoxColumn export_flag;
		private TJSystem.Classes.PriComboBox priComboBox5;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private TJSystem.Classes.PriComboBox priComboBox6;
		private System.Windows.Forms.DataGridTextBoxColumn confirm_flag;
		private string _PK = null;

		public frmSysUserMenu()
		{
			//
			// Windows 窗体设计器支持所必需的
			//
			InitializeComponent();			

			TJSystem.Public.PublicStatic.setBackgroundImg(this.panel1,this.panel1.GetType().ToString(),"images\\bg.gif");
			TJSystem.Public.PublicStatic.setBackgroundImg(this.panel2,this.panel1.GetType().ToString(),"");
			TJSystem.Public.PublicStatic.setBackgroundImg(this.panel3,this.panel1.GetType().ToString(),"");
			TJSystem.Public.PublicStatic.setBackgroundImg(this.panel4,this.panel1.GetType().ToString(),"");

			InitialFormData();

			System.Text.StringBuilder sb = new System.Text.StringBuilder();
			sb.Append("select a.employee_id,a.menu_id,b.XF_PROGRAMNAME as XF_PROGRAMNAME,a.insert_flag,a.update_flag, ");
			sb.Append("a.delete_flag,a.export_flag,a.confirm_flag,a.createBy,a.createon,a.modifyBy,a.modifyon ");
			sb.Append("from sys_user_menu a ");
			sb.Append("left join XF_MENUTREE b on a.menu_id=b.XF_CURRENTHANDLE and b.XF_HANDLELEVEL='1' ");
			sb.Append("order by employee_id,menu_id");
			this.InitialGrid(sb.ToString());
			//			this.textBox1.DataField = "PNO";
			priToolBar1.setCurrentForm = this;
			_table = "sys_user_menu";
			_PK = "employee_id,menu_id";
			priToolBar1.Initial(_table,_PK,sb.ToString());
			priToolBar1.BeforeButtonClickEvent += new TJSystem.UC.PriToolBar.BeforeButotnClick(this.BeforeButtonClick);
			priToolBar1.AfterButtonClickEvent += new TJSystem.UC.PriToolBar.AfterButtonClick(this.AfterButtonClick);

			this.priToolBar1.setButtonVisibleFalse();;
			this.priToolBar1.setButtonVisible("012345689");

			setDisable();
			//
			// TODO: 在 InitializeComponent 调用后添加任何构造函数代码
			//
		}

		private bool BeforeButtonClick(string sqltype)
		{
			if(sqltype.Equals("default"))
			{
				this.setDisable();
			}
			if(sqltype.Equals("insert") || sqltype.Equals("update"))
			{
				if(!checkFormValue(sqltype))
				{
					return false;
				}
			}
			return true;
		}

		/// <summary>
		/// 检查画面中的内容是否符合基本格式要求
		/// </summary>
		/// <param name="sqltype"></param>
		/// <returns></returns>
		private bool checkFormValue(string sqltype)
		{
			System.Text.StringBuilder sb = new System.Text.StringBuilder();
			sb.Append("数据验证错误：\r\n");
			
			//判断是否已经存在PK对应的记录
			if(sqltype.Equals("insert"))
			{
				if(TJSystem.Public.PublicStatic.IsExsist(_table,_PK,this.priToolBar1))
				{
					TJSystem.Public.PublicStatic.ShowMessage(TJSystem.Public.MessageType.Error,"已经存在该笔记录，请确认！");
					return false;
				}
			}

			if(sqltype.Equals("insert") || sqltype.Equals("update"))
			{
				if(this.priComboBox2.Text.Trim().Equals("") || this.priComboBox2.Text.Trim().Length > 1)
				{
					TJSystem.Public.PublicStatic.ShowMessage(TJSystem.Public.MessageType.Error,"请正确选择是否有权限新增！");
					return false;
				}
				if(this.priComboBox3.Text.Trim().Equals("") || this.priComboBox3.Text.Trim().Length > 1)
				{
					TJSystem.Public.PublicStatic.ShowMessage(TJSystem.Public.MessageType.Error,"请正确选择是否有权限修改！");
					return false;
				}
				if(this.priComboBox4.Text.Trim().Equals("") || this.priComboBox4.Text.Trim().Length > 1)
				{
					TJSystem.Public.PublicStatic.ShowMessage(TJSystem.Public.MessageType.Error,"请正确选择是否有权限删除！");
					return false;
				}
			}

			
			return true;
		}

		

		private void AfterButtonClick(string sqltype)
		{
			if(sqltype.Equals("insert"))
			{
				this.comboBox1.Enabled = true;
				this.priComboBox1.Enabled = true;
				this.priComboBox2.Enabled = true;
				this.priComboBox3.Enabled = true;
				this.priComboBox4.Enabled = true;
				this.priComboBox5.Enabled = true;
				this.priComboBox6.Enabled = true;
				this.comboBox1.Text = "";
				this.priComboBox1.Text = "";
				this.priComboBox2.Text = "";
				this.priComboBox3.Text = "";
				this.priComboBox4.Text = "";
				this.priComboBox5.Text = "";
				this.priComboBox6.Text = "";
			}
			else if(sqltype.Equals("update"))
			{
				this.comboBox1.Enabled = false;
				this.priComboBox1.Enabled = false;
				this.priComboBox2.Enabled = true;
				this.priComboBox3.Enabled = true;
				this.priComboBox4.Enabled = true;
				this.priComboBox5.Enabled = true;
				this.priComboBox6.Enabled = true;
			}
		}
		private void InitialFormData()
		{
			DataTable dtcpy = null;
			DataRow dr = null;

			string sql = "select EMPLOYEE_ID,EMPLOYEE_ID+' '+NAME_CN as NAME_CN from BASIC_EMPLOYEE order by EMPLOYEE_ID";
			DataTable dt = TJSystem.Public.PublicStatic.db.GetDataTable(sql);
			dr = dt.NewRow();
			dr[0] = "";
			dr[1] = "";
			dt.Rows.InsertAt(dr,0);
			dtcpy = dt.Copy();
			this.comboBox1.DataSource = dtcpy.DefaultView;
			this.comboBox1.ValueMember = "EMPLOYEE_ID";
			this.comboBox1.DisplayMember = "NAME_CN";

			sql = "select XF_CURRENTHANDLE,XF_CURRENTHANDLE+' '+XF_PROGRAMNAME as XF_PROGRAMNAME from XF_MENUTREE WHERE XF_HANDLELEVEL='1' order by XF_CURRENTHANDLE";
			dt = TJSystem.Public.PublicStatic.db.GetDataTable(sql);
			dr = dt.NewRow();
			dr[0] = "";
			dr[1] = "";
			dt.Rows.InsertAt(dr,0);
			dtcpy = dt.Copy();
			this.priComboBox1.DataSource = dtcpy.DefaultView;
			this.priComboBox1.ValueMember = "XF_CURRENTHANDLE";
			this.priComboBox1.DisplayMember = "XF_PROGRAMNAME";
			
			dt = new DataTable();
			dt.Columns.Add("FLAG");
			dr = dt.NewRow();
			dr[0] = "Y";
			dt.Rows.Add(dr);
			dr = dt.NewRow();
			dr[0] = "N";
			dt.Rows.Add(dr);
			dr = dt.NewRow();
			dr[0] = "";
			dt.Rows.InsertAt(dr,0);
			dtcpy = dt.Copy();
			this.priComboBox2.DataSource = dtcpy.DefaultView;
			this.priComboBox2.ValueMember = "FLAG";
			this.priComboBox2.DisplayMember = "FLAG";

			dt = new DataTable();
			dt.Columns.Add("FLAG");
			dr = dt.NewRow();
			dr[0] = "Y";
			dt.Rows.Add(dr);
			dr = dt.NewRow();
			dr[0] = "N";
			dt.Rows.Add(dr);
			dr = dt.NewRow();
			dr[0] = "";
			dt.Rows.InsertAt(dr,0);
			dtcpy = dt.Copy();
			this.priComboBox3.DataSource = dtcpy.DefaultView;
			this.priComboBox3.ValueMember = "FLAG";
			this.priComboBox3.DisplayMember = "FLAG";

			dt = new DataTable();
			dt.Columns.Add("FLAG");
			dr = dt.NewRow();
			dr[0] = "Y";
			dt.Rows.Add(dr);
			dr = dt.NewRow();
			dr[0] = "N";
			dt.Rows.Add(dr);
			dr = dt.NewRow();
			dr[0] = "";
			dt.Rows.InsertAt(dr,0);
			dtcpy = dt.Copy();
			this.priComboBox4.DataSource = dtcpy.DefaultView;
			this.priComboBox4.ValueMember = "FLAG";
			this.priComboBox4.DisplayMember = "FLAG";

			dt = new DataTable();
			dt.Columns.Add("FLAG");
			dr = dt.NewRow();
			dr[0] = "Y";
			dt.Rows.Add(dr);
			dr = dt.NewRow();
			dr[0] = "N";
			dt.Rows.Add(dr);
			dr = dt.NewRow();
			dr[0] = "";
			dt.Rows.InsertAt(dr,0);
			dtcpy = dt.Copy();
			this.priComboBox5.DataSource = dtcpy.DefaultView;
			this.priComboBox5.ValueMember = "FLAG";
			this.priComboBox5.DisplayMember = "FLAG";

			dt = new DataTable();
			dt.Columns.Add("FLAG");
			dr = dt.NewRow();
			dr[0] = "Y";
			dt.Rows.Add(dr);
			dr = dt.NewRow();
			dr[0] = "N";
			dt.Rows.Add(dr);
			dr = dt.NewRow();
			dr[0] = "";
			dt.Rows.InsertAt(dr,0);
			dtcpy = dt.Copy();
			this.priComboBox6.DataSource = dtcpy.DefaultView;
			this.priComboBox6.ValueMember = "FLAG";
			this.priComboBox6.DisplayMember = "FLAG";
		}

		private void InitialGrid(string sql)
		{		
			DataTable dt = TJSystem.Public.PublicStatic.db.GetDataTable(sql);
			dt.TableName = "sys_user_menu";
			this.dataGridTableStyle1.DataGrid.DataSource = dt.DefaultView;
		}

		/// <summary>
		/// 清理所有正在使用的资源。
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			frmCurrent = null ;
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(frmSysUserMenu));
			this.panel2 = new System.Windows.Forms.Panel();
			this.dataGrid1 = new System.Windows.Forms.DataGrid();
			this.dataGridTableStyle1 = new System.Windows.Forms.DataGridTableStyle();
			this.employee_id = new System.Windows.Forms.DataGridTextBoxColumn();
			this.XF_PROGRAMNAME = new System.Windows.Forms.DataGridTextBoxColumn();
			this.insert_flag = new System.Windows.Forms.DataGridTextBoxColumn();
			this.update_flag = new System.Windows.Forms.DataGridTextBoxColumn();
			this.delete_flag = new System.Windows.Forms.DataGridTextBoxColumn();
			this.confirm_flag = new System.Windows.Forms.DataGridTextBoxColumn();
			this.createby = new System.Windows.Forms.DataGridTextBoxColumn();
			this.createon = new System.Windows.Forms.DataGridTextBoxColumn();
			this.modifyby = new System.Windows.Forms.DataGridTextBoxColumn();
			this.modifyon = new System.Windows.Forms.DataGridTextBoxColumn();
			this.export_flag = new System.Windows.Forms.DataGridTextBoxColumn();
			this.panel4 = new System.Windows.Forms.Panel();
			this.priComboBox5 = new TJSystem.Classes.PriComboBox();
			this.label7 = new System.Windows.Forms.Label();
			this.label17 = new System.Windows.Forms.Label();
			this.priTextBox8 = new TJSystem.Classes.PriTextBox();
			this.label21 = new System.Windows.Forms.Label();
			this.priTextBox19 = new TJSystem.Classes.PriTextBox();
			this.label20 = new System.Windows.Forms.Label();
			this.priTextBox18 = new TJSystem.Classes.PriTextBox();
			this.label15 = new System.Windows.Forms.Label();
			this.priTextBox11 = new TJSystem.Classes.PriTextBox();
			this.priComboBox4 = new TJSystem.Classes.PriComboBox();
			this.label6 = new System.Windows.Forms.Label();
			this.priComboBox3 = new TJSystem.Classes.PriComboBox();
			this.label5 = new System.Windows.Forms.Label();
			this.priComboBox2 = new TJSystem.Classes.PriComboBox();
			this.label4 = new System.Windows.Forms.Label();
			this.priComboBox1 = new TJSystem.Classes.PriComboBox();
			this.label3 = new System.Windows.Forms.Label();
			this.comboBox1 = new TJSystem.Classes.PriComboBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.priComboBox6 = new TJSystem.Classes.PriComboBox();
			this.panel3 = new System.Windows.Forms.Panel();
			this.priToolBar1 = new TJSystem.UC.PriToolBar();
			this.panel1 = new System.Windows.Forms.Panel();
			this.label1 = new System.Windows.Forms.Label();
			this.dataGridTextBoxColumn21 = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumn22 = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumn23 = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumn24 = new System.Windows.Forms.DataGridTextBoxColumn();
			this.panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).BeginInit();
			this.panel4.SuspendLayout();
			this.panel3.SuspendLayout();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel2
			// 
			this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
			this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.panel2.Controls.Add(this.dataGrid1);
			this.panel2.Controls.Add(this.panel4);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel2.Location = new System.Drawing.Point(0, 48);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(792, 478);
			this.panel2.TabIndex = 11;
			// 
			// dataGrid1
			// 
			this.dataGrid1.AllowSorting = false;
			this.dataGrid1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.dataGrid1.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.dataGrid1.CaptionText = "用户权限设定";
			this.dataGrid1.CaptionVisible = false;
			this.dataGrid1.DataMember = "";
			this.dataGrid1.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.dataGrid1.Location = new System.Drawing.Point(0, 120);
			this.dataGrid1.Name = "dataGrid1";
			this.dataGrid1.ReadOnly = true;
			this.dataGrid1.Size = new System.Drawing.Size(784, 352);
			this.dataGrid1.TabIndex = 1;
			this.dataGrid1.TableStyles.AddRange(new System.Windows.Forms.DataGridTableStyle[] {
																								  this.dataGridTableStyle1});
			// 
			// dataGridTableStyle1
			// 
			this.dataGridTableStyle1.AllowSorting = false;
			this.dataGridTableStyle1.DataGrid = this.dataGrid1;
			this.dataGridTableStyle1.GridColumnStyles.AddRange(new System.Windows.Forms.DataGridColumnStyle[] {
																												  this.employee_id,
																												  this.XF_PROGRAMNAME,
																												  this.insert_flag,
																												  this.update_flag,
																												  this.delete_flag,
																												  this.confirm_flag,
																												  this.createby,
																												  this.createon,
																												  this.modifyby,
																												  this.modifyon,
																												  this.export_flag});
			this.dataGridTableStyle1.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.dataGridTableStyle1.MappingName = "sys_user_menu";
			this.dataGridTableStyle1.ReadOnly = true;
			// 
			// employee_id
			// 
			this.employee_id.Format = "";
			this.employee_id.FormatInfo = null;
			this.employee_id.HeaderText = "用户";
			this.employee_id.MappingName = "employee_id";
			this.employee_id.NullText = "";
			this.employee_id.Width = 75;
			// 
			// XF_PROGRAMNAME
			// 
			this.XF_PROGRAMNAME.Format = "";
			this.XF_PROGRAMNAME.FormatInfo = null;
			this.XF_PROGRAMNAME.HeaderText = "作业名称";
			this.XF_PROGRAMNAME.MappingName = "XF_PROGRAMNAME";
			this.XF_PROGRAMNAME.NullText = "";
			this.XF_PROGRAMNAME.Width = 75;
			// 
			// insert_flag
			// 
			this.insert_flag.Format = "";
			this.insert_flag.FormatInfo = null;
			this.insert_flag.HeaderText = "新建";
			this.insert_flag.MappingName = "insert_flag";
			this.insert_flag.NullText = "";
			this.insert_flag.Width = 75;
			// 
			// update_flag
			// 
			this.update_flag.Format = "";
			this.update_flag.FormatInfo = null;
			this.update_flag.HeaderText = "修改";
			this.update_flag.MappingName = "update_flag";
			this.update_flag.NullText = "";
			this.update_flag.Width = 75;
			// 
			// delete_flag
			// 
			this.delete_flag.Format = "";
			this.delete_flag.FormatInfo = null;
			this.delete_flag.HeaderText = "删除";
			this.delete_flag.MappingName = "delete_flag";
			this.delete_flag.NullText = "";
			this.delete_flag.Width = 75;
			// 
			// confirm_flag
			// 
			this.confirm_flag.Format = "";
			this.confirm_flag.FormatInfo = null;
			this.confirm_flag.HeaderText = "审核确认";
			this.confirm_flag.MappingName = "confirm_flag";
			this.confirm_flag.NullText = "";
			this.confirm_flag.Width = 75;
			// 
			// createby
			// 
			this.createby.Format = "";
			this.createby.FormatInfo = null;
			this.createby.HeaderText = "建立者";
			this.createby.MappingName = "createby";
			this.createby.NullText = "";
			this.createby.Width = 75;
			// 
			// createon
			// 
			this.createon.Format = "";
			this.createon.FormatInfo = null;
			this.createon.HeaderText = "建立日期";
			this.createon.MappingName = "createon";
			this.createon.NullText = "";
			this.createon.Width = 75;
			// 
			// modifyby
			// 
			this.modifyby.Format = "";
			this.modifyby.FormatInfo = null;
			this.modifyby.HeaderText = "最后修改者";
			this.modifyby.MappingName = "modifyby";
			this.modifyby.NullText = "";
			this.modifyby.Width = 75;
			// 
			// modifyon
			// 
			this.modifyon.Format = "";
			this.modifyon.FormatInfo = null;
			this.modifyon.HeaderText = "最后修改日期";
			this.modifyon.MappingName = "modifyon";
			this.modifyon.NullText = "";
			this.modifyon.Width = 75;
			// 
			// export_flag
			// 
			this.export_flag.Format = "";
			this.export_flag.FormatInfo = null;
			this.export_flag.HeaderText = "汇出Excel";
			this.export_flag.MappingName = "export_flag";
			this.export_flag.NullText = "";
			this.export_flag.Width = 75;
			// 
			// panel4
			// 
			this.panel4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel4.BackgroundImage")));
			this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.panel4.Controls.Add(this.priComboBox5);
			this.panel4.Controls.Add(this.label7);
			this.panel4.Controls.Add(this.label17);
			this.panel4.Controls.Add(this.priTextBox8);
			this.panel4.Controls.Add(this.label21);
			this.panel4.Controls.Add(this.priTextBox19);
			this.panel4.Controls.Add(this.label20);
			this.panel4.Controls.Add(this.priTextBox18);
			this.panel4.Controls.Add(this.label15);
			this.panel4.Controls.Add(this.priTextBox11);
			this.panel4.Controls.Add(this.priComboBox4);
			this.panel4.Controls.Add(this.label6);
			this.panel4.Controls.Add(this.priComboBox3);
			this.panel4.Controls.Add(this.label5);
			this.panel4.Controls.Add(this.priComboBox2);
			this.panel4.Controls.Add(this.label4);
			this.panel4.Controls.Add(this.priComboBox1);
			this.panel4.Controls.Add(this.label3);
			this.panel4.Controls.Add(this.comboBox1);
			this.panel4.Controls.Add(this.label2);
			this.panel4.Controls.Add(this.label8);
			this.panel4.Controls.Add(this.priComboBox6);
			this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel4.Location = new System.Drawing.Point(0, 0);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(788, 112);
			this.panel4.TabIndex = 0;
			// 
			// priComboBox5
			// 
			this.priComboBox5.BackColor = System.Drawing.Color.White;
			this.priComboBox5.DataField = "export_flag";
			this.priComboBox5.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.priComboBox5.Location = new System.Drawing.Point(536, 40);
			this.priComboBox5.Name = "priComboBox5";
			this.priComboBox5.Size = new System.Drawing.Size(80, 22);
			this.priComboBox5.TabIndex = 119;
			// 
			// label7
			// 
			this.label7.BackColor = System.Drawing.Color.Transparent;
			this.label7.Location = new System.Drawing.Point(456, 40);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(72, 23);
			this.label7.TabIndex = 118;
			this.label7.Text = "汇出Excel";
			this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label17
			// 
			this.label17.BackColor = System.Drawing.Color.Transparent;
			this.label17.Location = new System.Drawing.Point(384, 72);
			this.label17.Name = "label17";
			this.label17.Size = new System.Drawing.Size(80, 23);
			this.label17.TabIndex = 117;
			this.label17.Text = "最后修改者";
			this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// priTextBox8
			// 
			this.priTextBox8.BackColor = System.Drawing.Color.White;
			this.priTextBox8.DataField = "modifyBy";
			this.priTextBox8.DataType = TJSystem.Public.DataType.String;
			this.priTextBox8.Enabled = false;
			this.priTextBox8.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.priTextBox8.Location = new System.Drawing.Point(472, 72);
			this.priTextBox8.Name = "priTextBox8";
			this.priTextBox8.Size = new System.Drawing.Size(104, 23);
			this.priTextBox8.TabIndex = 116;
			this.priTextBox8.Text = "";
			// 
			// label21
			// 
			this.label21.BackColor = System.Drawing.Color.Transparent;
			this.label21.Location = new System.Drawing.Point(592, 72);
			this.label21.Name = "label21";
			this.label21.Size = new System.Drawing.Size(64, 23);
			this.label21.TabIndex = 115;
			this.label21.Text = "修改时间";
			this.label21.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// priTextBox19
			// 
			this.priTextBox19.BackColor = System.Drawing.Color.White;
			this.priTextBox19.DataField = "modifyon";
			this.priTextBox19.DataType = TJSystem.Public.DataType.String;
			this.priTextBox19.Enabled = false;
			this.priTextBox19.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.priTextBox19.Location = new System.Drawing.Point(664, 72);
			this.priTextBox19.Name = "priTextBox19";
			this.priTextBox19.Size = new System.Drawing.Size(104, 23);
			this.priTextBox19.TabIndex = 114;
			this.priTextBox19.Text = "";
			// 
			// label20
			// 
			this.label20.BackColor = System.Drawing.Color.Transparent;
			this.label20.Location = new System.Drawing.Point(184, 72);
			this.label20.Name = "label20";
			this.label20.Size = new System.Drawing.Size(64, 23);
			this.label20.TabIndex = 113;
			this.label20.Text = "创建时间";
			this.label20.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// priTextBox18
			// 
			this.priTextBox18.BackColor = System.Drawing.Color.White;
			this.priTextBox18.DataField = "createon";
			this.priTextBox18.DataType = TJSystem.Public.DataType.String;
			this.priTextBox18.Enabled = false;
			this.priTextBox18.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.priTextBox18.Location = new System.Drawing.Point(256, 72);
			this.priTextBox18.Name = "priTextBox18";
			this.priTextBox18.Size = new System.Drawing.Size(120, 23);
			this.priTextBox18.TabIndex = 112;
			this.priTextBox18.Text = "";
			// 
			// label15
			// 
			this.label15.BackColor = System.Drawing.Color.Transparent;
			this.label15.Location = new System.Drawing.Point(8, 72);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(56, 23);
			this.label15.TabIndex = 111;
			this.label15.Text = "创建者";
			this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// priTextBox11
			// 
			this.priTextBox11.BackColor = System.Drawing.Color.White;
			this.priTextBox11.DataField = "createBy";
			this.priTextBox11.DataType = TJSystem.Public.DataType.String;
			this.priTextBox11.Enabled = false;
			this.priTextBox11.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.priTextBox11.Location = new System.Drawing.Point(72, 72);
			this.priTextBox11.Name = "priTextBox11";
			this.priTextBox11.Size = new System.Drawing.Size(104, 23);
			this.priTextBox11.TabIndex = 110;
			this.priTextBox11.Text = "";
			// 
			// priComboBox4
			// 
			this.priComboBox4.BackColor = System.Drawing.Color.White;
			this.priComboBox4.DataField = "delete_flag";
			this.priComboBox4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.priComboBox4.Location = new System.Drawing.Point(368, 40);
			this.priComboBox4.Name = "priComboBox4";
			this.priComboBox4.Size = new System.Drawing.Size(80, 22);
			this.priComboBox4.TabIndex = 109;
			// 
			// label6
			// 
			this.label6.BackColor = System.Drawing.Color.Transparent;
			this.label6.Location = new System.Drawing.Point(312, 40);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(48, 23);
			this.label6.TabIndex = 108;
			this.label6.Text = "删除";
			this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// priComboBox3
			// 
			this.priComboBox3.BackColor = System.Drawing.Color.White;
			this.priComboBox3.DataField = "update_flag";
			this.priComboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.priComboBox3.Location = new System.Drawing.Point(224, 40);
			this.priComboBox3.Name = "priComboBox3";
			this.priComboBox3.Size = new System.Drawing.Size(80, 22);
			this.priComboBox3.TabIndex = 107;
			// 
			// label5
			// 
			this.label5.BackColor = System.Drawing.Color.Transparent;
			this.label5.Location = new System.Drawing.Point(176, 40);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(40, 23);
			this.label5.TabIndex = 106;
			this.label5.Text = "更新";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// priComboBox2
			// 
			this.priComboBox2.BackColor = System.Drawing.Color.White;
			this.priComboBox2.DataField = "insert_flag";
			this.priComboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.priComboBox2.Location = new System.Drawing.Point(80, 40);
			this.priComboBox2.Name = "priComboBox2";
			this.priComboBox2.Size = new System.Drawing.Size(80, 22);
			this.priComboBox2.TabIndex = 105;
			// 
			// label4
			// 
			this.label4.BackColor = System.Drawing.Color.Transparent;
			this.label4.Location = new System.Drawing.Point(32, 40);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(40, 23);
			this.label4.TabIndex = 104;
			this.label4.Text = "插入";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// priComboBox1
			// 
			this.priComboBox1.BackColor = System.Drawing.Color.White;
			this.priComboBox1.DataField = "menu_id";
			this.priComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.priComboBox1.Location = new System.Drawing.Point(472, 8);
			this.priComboBox1.Name = "priComboBox1";
			this.priComboBox1.Size = new System.Drawing.Size(304, 22);
			this.priComboBox1.TabIndex = 103;
			// 
			// label3
			// 
			this.label3.BackColor = System.Drawing.Color.Transparent;
			this.label3.Location = new System.Drawing.Point(408, 8);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(56, 23);
			this.label3.TabIndex = 102;
			this.label3.Text = "操作";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// comboBox1
			// 
			this.comboBox1.BackColor = System.Drawing.Color.White;
			this.comboBox1.DataField = "employee_id";
			this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBox1.Location = new System.Drawing.Point(72, 8);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(304, 22);
			this.comboBox1.TabIndex = 101;
			// 
			// label2
			// 
			this.label2.BackColor = System.Drawing.Color.Transparent;
			this.label2.Location = new System.Drawing.Point(16, 8);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(48, 23);
			this.label2.TabIndex = 16;
			this.label2.Text = "用户";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label8
			// 
			this.label8.BackColor = System.Drawing.Color.Transparent;
			this.label8.Location = new System.Drawing.Point(632, 40);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(40, 23);
			this.label8.TabIndex = 104;
			this.label8.Text = "审核";
			this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// priComboBox6
			// 
			this.priComboBox6.BackColor = System.Drawing.Color.White;
			this.priComboBox6.DataField = "confirm_flag";
			this.priComboBox6.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.priComboBox6.Location = new System.Drawing.Point(680, 40);
			this.priComboBox6.Name = "priComboBox6";
			this.priComboBox6.Size = new System.Drawing.Size(80, 22);
			this.priComboBox6.TabIndex = 105;
			// 
			// panel3
			// 
			this.panel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel3.BackgroundImage")));
			this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.panel3.Controls.Add(this.priToolBar1);
			this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panel3.Location = new System.Drawing.Point(0, 526);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(792, 40);
			this.panel3.TabIndex = 12;
			// 
			// priToolBar1
			// 
			this.priToolBar1.DGEnable = true;
			this.priToolBar1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.priToolBar1.Location = new System.Drawing.Point(0, -4);
			this.priToolBar1.Name = "priToolBar1";
			this.priToolBar1.setCurrentForm = null;
			this.priToolBar1.Size = new System.Drawing.Size(788, 40);
			this.priToolBar1.TabIndex = 0;
			// 
			// panel1
			// 
			this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
			this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.panel1.Controls.Add(this.label1);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(792, 48);
			this.panel1.TabIndex = 10;
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label1.Font = new System.Drawing.Font("宋体", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.label1.Location = new System.Drawing.Point(0, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(788, 44);
			this.label1.TabIndex = 0;
			this.label1.Text = "用户权限设定";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// dataGridTextBoxColumn21
			// 
			this.dataGridTextBoxColumn21.Format = "";
			this.dataGridTextBoxColumn21.FormatInfo = null;
			this.dataGridTextBoxColumn21.HeaderText = "员工姓名";
			this.dataGridTextBoxColumn21.MappingName = "";
			this.dataGridTextBoxColumn21.NullText = "";
			this.dataGridTextBoxColumn21.Width = 75;
			// 
			// dataGridTextBoxColumn22
			// 
			this.dataGridTextBoxColumn22.Format = "";
			this.dataGridTextBoxColumn22.FormatInfo = null;
			this.dataGridTextBoxColumn22.HeaderText = "性别";
			this.dataGridTextBoxColumn22.MappingName = "Gender";
			this.dataGridTextBoxColumn22.NullText = "";
			this.dataGridTextBoxColumn22.Width = 75;
			// 
			// dataGridTextBoxColumn23
			// 
			this.dataGridTextBoxColumn23.Format = "";
			this.dataGridTextBoxColumn23.FormatInfo = null;
			this.dataGridTextBoxColumn23.HeaderText = "员工编号";
			this.dataGridTextBoxColumn23.MappingName = "employee_id";
			this.dataGridTextBoxColumn23.NullText = "";
			this.dataGridTextBoxColumn23.Width = 75;
			// 
			// dataGridTextBoxColumn24
			// 
			this.dataGridTextBoxColumn24.Format = "";
			this.dataGridTextBoxColumn24.FormatInfo = null;
			this.dataGridTextBoxColumn24.HeaderText = "英文名";
			this.dataGridTextBoxColumn24.MappingName = "";
			this.dataGridTextBoxColumn24.NullText = "";
			this.dataGridTextBoxColumn24.Width = 75;
			// 
			// frmSysUserMenu
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(7, 16);
			this.BackColor = System.Drawing.SystemColors.ScrollBar;
			this.ClientSize = new System.Drawing.Size(792, 566);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel3);
			this.Controls.Add(this.panel1);
			this.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "frmSysUserMenu";
			this.Text = "用户权限设定";
			this.panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).EndInit();
			this.panel4.ResumeLayout(false);
			this.panel3.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		private void setDisable()
		{
			this.comboBox1.Enabled = false;
			this.priComboBox1.Enabled = false;
			this.priComboBox2.Enabled = false;
			this.priComboBox3.Enabled = false;
			this.priComboBox4.Enabled = false;
			this.priComboBox5.Enabled = false;
			this.priComboBox6.Enabled = false;
		}
		
		protected override void OnClosing(CancelEventArgs e)
		{			
//			if(MessageBox.Show("确定退出？（Y/N）","确认",MessageBoxButtons.YesNo,MessageBoxIcon.Information) == System.Windows.Forms.DialogResult.No)
//			{
//				e.Cancel = true;
//			}
//			else
			{
				TJSystem.Public.PublicStatic.formClose = true;
				TJSystem.Public.PublicStatic.formName = "用户权限设定";
			}
			base.OnClosing (e);
		}
	}
}

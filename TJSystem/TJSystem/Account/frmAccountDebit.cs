using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace TJSystem.Account
{
	/// <summary>
	/// Form1 的摘要说明。
	/// </summary>
	public class frmAccountDebit : System.Windows.Forms.Form
	{
		
		
		/// <summary>
		/// 必需的设计器变量。
		/// </summary>
		private System.ComponentModel.Container components = null;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.DataGridTableStyle dataGridTableStyle1;
		private System.Windows.Forms.DataGrid dataGrid1;
		private System.Windows.Forms.Panel panel4;
		private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn21;
		private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn22;
		private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn23;
		private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn24;
		private System.Windows.Forms.Panel panel3;
		private TJSystem.UC.PriToolBar priToolBar1;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.DataGridTextBoxColumn WH_CODE;
		private System.Windows.Forms.DataGridTextBoxColumn WH_NAME;
		private System.Windows.Forms.DataGridTextBoxColumn WH_DESC;
		private System.Windows.Forms.DataGridTextBoxColumn TEL;
		private System.Windows.Forms.DataGridTextBoxColumn FAX;
		private System.Windows.Forms.DataGridTextBoxColumn CITY;
		private System.Windows.Forms.DataGridTextBoxColumn ADDRESS;
		private System.Windows.Forms.DataGridTextBoxColumn EMPLOYEE_ID;
		private System.Windows.Forms.DataGridTextBoxColumn CREATEBY;
		private System.Windows.Forms.DataGridTextBoxColumn CREATEON;
		private System.Windows.Forms.DataGridTextBoxColumn MODIFYBY;
		private System.Windows.Forms.DataGridTextBoxColumn MODIFYON;
		public  static System.Windows.Forms.Form frmCurrent = null ;

		private string _table = null;
		private System.Windows.Forms.DataGridTextBoxColumn WHTYPE_NAMECN;
		private TJSystem.Classes.PriDateTimePicker priDateTimePicker3;
		private TJSystem.Classes.PriComboBox comboBox1;
		private System.Windows.Forms.Label label21;
		private TJSystem.Classes.PriTextBox priTextBox19;
		private System.Windows.Forms.Label label20;
		private TJSystem.Classes.PriTextBox priTextBox18;
		private System.Windows.Forms.Label label17;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label2;
		private TJSystem.Classes.PriTextBox priTextBox12;
		private TJSystem.Classes.PriTextBox priTextBox11;
		private TJSystem.Classes.PriTextBox priTextBox9;
		private TJSystem.Classes.PriTextBox priTextBox8;
		private TJSystem.Classes.PriTextBox priTextBox7;
		private TJSystem.Classes.PriTextBox priTextBox5;
		private TJSystem.Classes.PriTextBox textBox1;
		private System.Windows.Forms.Label label3;
		private TJSystem.Classes.PriComboBox priComboBox2;
		private System.Windows.Forms.Label label5;
		private TJSystem.Classes.PriTextBox priTextBox1;
		private System.Windows.Forms.Label label6;
		private TJSystem.Classes.PriTextBox priTextBox2;
		private TJSystem.Classes.PriTextBox priTextBox3;
		private System.Windows.Forms.Label label7;
		private TJSystem.Classes.PriComboBox priComboBox1;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Label label13;
		private TJSystem.Classes.PriTextBox priTextBox4;
		private string _PK = null;

		public frmAccountDebit()
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
			sb.Append("select a.WH_CODE,a.WH_NAME,a.WH_DESC,a.TEL,a.FAX,a.CITY,a.ADDRESS,a.EMPLOYEE_ID,a.WH_TYPE,b.whtype_namecn as WHTYPE_NAMECN,a.CREATEBY,a.CREATEON, ");
			sb.Append("a.MODIFYBY,a.MODIFYON  ");
			sb.Append("from BASIC_WHOUSE a ");
			sb.Append("left join p_whousetype b on a.wh_type = b.whtype_id ");
			sb.Append("ORDER BY a.WH_CODE");
			this.InitialGrid(sb.ToString());
			priToolBar1.setCurrentForm = this;
			_table= "BASIC_WHOUSE";
			_PK = "WH_CODE";
			priToolBar1.Initial(_table,_PK,sb.ToString());
			priToolBar1.BeforeButtonClickEvent += new TJSystem.UC.PriToolBar.BeforeButotnClick(this.BeforeButtonClick);
			priToolBar1.AfterButtonClickEvent += new TJSystem.UC.PriToolBar.AfterButtonClick(this.AfterButtonClick);

			this.priToolBar1.setButtonVisibleFalse();;
			this.priToolBar1.setButtonVisible("012345689");
			this.setDisable();
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


		private void AfterButtonClick(string sqltype)
		{
			if(sqltype.Equals("insert"))
			{
				this.textBox1.Enabled = true;
				
				this.priTextBox12.Enabled = true;
				
				this.priTextBox3.Enabled = true;
				this.priTextBox4.Enabled = true;
				this.priTextBox5.Enabled = true;
				this.priTextBox7.Enabled = true;
				
				this.priTextBox9.Enabled = true;
				this.comboBox1.Enabled = true;
				this.priComboBox1.Enabled = true;
				
				this.textBox1.Text = "";
				
				this.priTextBox12.Text = "";
				
				this.priTextBox3.Text = "";
				this.priTextBox4.Text = "";
				this.priTextBox5.Text = "";
				this.priTextBox7.Text = "";
				
				this.priTextBox9.Text = "";
				this.comboBox1.Text = "";
				this.priComboBox1.Text = "";
			}
			else if(sqltype.Equals("update"))
			{
				this.textBox1.Enabled = false;
				this.priTextBox12.Enabled = true;
				this.priTextBox3.Enabled = true;
				this.priTextBox4.Enabled = true;
				this.priTextBox5.Enabled = true;
				this.priTextBox7.Enabled = true;
				this.priTextBox9.Enabled = true;
				this.comboBox1.Enabled = true;
				this.priComboBox1.Enabled = true;
			}
		}
		private void InitialFormData()
		{
			DataTable dtcpy = null;
			DataRow dr = null;
			string sql = "select WHTYPE_ID,WHTYPE_ID+' '+WHTYPE_NAMECN as WHTYPE_NAMECN from P_WHOUSETYPE order by WHTYPE_ID";
			DataTable dt = TJSystem.Public.PublicStatic.db.GetDataTable(sql);
			dr = dt.NewRow() ;
			dr[0] = "" ;
			dr[1] = "" ;
			dt.Rows.InsertAt(dr,0) ;
			dtcpy = dt.Copy();
			this.comboBox1.DataSource = dtcpy.DefaultView;
			this.comboBox1.ValueMember = "WHTYPE_ID";
			this.comboBox1.DisplayMember = "WHTYPE_NAMECN";

			sql = "select EMPLOYEE_ID,EMPLOYEE_ID+' '+NAME_CN as NAME_CN from BASIC_EMPLOYEE order by EMPLOYEE_ID";
			dt = TJSystem.Public.PublicStatic.db.GetDataTable(sql);
			dr = dt.NewRow() ;
			dr[0] = "" ;
			dr[1] = "" ;
			dt.Rows.InsertAt(dr,0) ;
			dtcpy = dt.Copy();
			this.priComboBox1.DataSource = dtcpy.DefaultView;
			this.priComboBox1.ValueMember = "EMPLOYEE_ID";
			this.priComboBox1.DisplayMember = "NAME_CN";
		}

		private void InitialGrid(string sql)
		{		
			DataTable dt = TJSystem.Public.PublicStatic.db.GetDataTable(sql);
			dt.TableName = "BASIC_WHOUSE";
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(frmAccountDebit));
			this.panel2 = new System.Windows.Forms.Panel();
			this.dataGrid1 = new System.Windows.Forms.DataGrid();
			this.dataGridTableStyle1 = new System.Windows.Forms.DataGridTableStyle();
			this.WH_CODE = new System.Windows.Forms.DataGridTextBoxColumn();
			this.WH_NAME = new System.Windows.Forms.DataGridTextBoxColumn();
			this.WH_DESC = new System.Windows.Forms.DataGridTextBoxColumn();
			this.WHTYPE_NAMECN = new System.Windows.Forms.DataGridTextBoxColumn();
			this.TEL = new System.Windows.Forms.DataGridTextBoxColumn();
			this.FAX = new System.Windows.Forms.DataGridTextBoxColumn();
			this.CITY = new System.Windows.Forms.DataGridTextBoxColumn();
			this.ADDRESS = new System.Windows.Forms.DataGridTextBoxColumn();
			this.EMPLOYEE_ID = new System.Windows.Forms.DataGridTextBoxColumn();
			this.CREATEBY = new System.Windows.Forms.DataGridTextBoxColumn();
			this.CREATEON = new System.Windows.Forms.DataGridTextBoxColumn();
			this.MODIFYBY = new System.Windows.Forms.DataGridTextBoxColumn();
			this.MODIFYON = new System.Windows.Forms.DataGridTextBoxColumn();
			this.panel4 = new System.Windows.Forms.Panel();
			this.priDateTimePicker3 = new TJSystem.Classes.PriDateTimePicker();
			this.comboBox1 = new TJSystem.Classes.PriComboBox();
			this.label21 = new System.Windows.Forms.Label();
			this.priTextBox19 = new TJSystem.Classes.PriTextBox();
			this.label20 = new System.Windows.Forms.Label();
			this.priTextBox18 = new TJSystem.Classes.PriTextBox();
			this.label17 = new System.Windows.Forms.Label();
			this.label15 = new System.Windows.Forms.Label();
			this.label14 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.priTextBox12 = new TJSystem.Classes.PriTextBox();
			this.priTextBox11 = new TJSystem.Classes.PriTextBox();
			this.priTextBox9 = new TJSystem.Classes.PriTextBox();
			this.priTextBox8 = new TJSystem.Classes.PriTextBox();
			this.priTextBox7 = new TJSystem.Classes.PriTextBox();
			this.priTextBox5 = new TJSystem.Classes.PriTextBox();
			this.textBox1 = new TJSystem.Classes.PriTextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.priComboBox2 = new TJSystem.Classes.PriComboBox();
			this.label5 = new System.Windows.Forms.Label();
			this.priTextBox1 = new TJSystem.Classes.PriTextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.priTextBox2 = new TJSystem.Classes.PriTextBox();
			this.priTextBox3 = new TJSystem.Classes.PriTextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.priComboBox1 = new TJSystem.Classes.PriComboBox();
			this.label12 = new System.Windows.Forms.Label();
			this.label13 = new System.Windows.Forms.Label();
			this.priTextBox4 = new TJSystem.Classes.PriTextBox();
			this.dataGridTextBoxColumn21 = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumn22 = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumn23 = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumn24 = new System.Windows.Forms.DataGridTextBoxColumn();
			this.panel3 = new System.Windows.Forms.Panel();
			this.priToolBar1 = new TJSystem.UC.PriToolBar();
			this.panel1 = new System.Windows.Forms.Panel();
			this.label1 = new System.Windows.Forms.Label();
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
			this.dataGrid1.CaptionText = "仓库设置";
			this.dataGrid1.CaptionVisible = false;
			this.dataGrid1.DataMember = "";
			this.dataGrid1.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.dataGrid1.Location = new System.Drawing.Point(0, 352);
			this.dataGrid1.Name = "dataGrid1";
			this.dataGrid1.ReadOnly = true;
			this.dataGrid1.Size = new System.Drawing.Size(784, 120);
			this.dataGrid1.TabIndex = 1;
			this.dataGrid1.TableStyles.AddRange(new System.Windows.Forms.DataGridTableStyle[] {
																								  this.dataGridTableStyle1});
			this.dataGrid1.Click += new System.EventHandler(this.dataGrid1_Click);
			// 
			// dataGridTableStyle1
			// 
			this.dataGridTableStyle1.AllowSorting = false;
			this.dataGridTableStyle1.DataGrid = this.dataGrid1;
			this.dataGridTableStyle1.GridColumnStyles.AddRange(new System.Windows.Forms.DataGridColumnStyle[] {
																												  this.WH_CODE,
																												  this.WH_NAME,
																												  this.WH_DESC,
																												  this.WHTYPE_NAMECN,
																												  this.TEL,
																												  this.FAX,
																												  this.CITY,
																												  this.ADDRESS,
																												  this.EMPLOYEE_ID,
																												  this.CREATEBY,
																												  this.CREATEON,
																												  this.MODIFYBY,
																												  this.MODIFYON});
			this.dataGridTableStyle1.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.dataGridTableStyle1.MappingName = "BASIC_WHOUSE";
			this.dataGridTableStyle1.ReadOnly = true;
			// 
			// WH_CODE
			// 
			this.WH_CODE.Format = "";
			this.WH_CODE.FormatInfo = null;
			this.WH_CODE.HeaderText = "仓库编号";
			this.WH_CODE.MappingName = "WH_CODE";
			this.WH_CODE.NullText = "";
			this.WH_CODE.Width = 75;
			// 
			// WH_NAME
			// 
			this.WH_NAME.Format = "";
			this.WH_NAME.FormatInfo = null;
			this.WH_NAME.HeaderText = "仓库名称";
			this.WH_NAME.MappingName = "WH_NAME";
			this.WH_NAME.NullText = "";
			this.WH_NAME.Width = 75;
			// 
			// WH_DESC
			// 
			this.WH_DESC.Format = "";
			this.WH_DESC.FormatInfo = null;
			this.WH_DESC.HeaderText = "仓库描述";
			this.WH_DESC.MappingName = "WH_DESC";
			this.WH_DESC.NullText = "";
			this.WH_DESC.Width = 75;
			// 
			// WHTYPE_NAMECN
			// 
			this.WHTYPE_NAMECN.Format = "";
			this.WHTYPE_NAMECN.FormatInfo = null;
			this.WHTYPE_NAMECN.HeaderText = "仓库类型";
			this.WHTYPE_NAMECN.MappingName = "WHTYPE_NAMECN";
			this.WHTYPE_NAMECN.NullText = "";
			this.WHTYPE_NAMECN.Width = 75;
			// 
			// TEL
			// 
			this.TEL.Format = "";
			this.TEL.FormatInfo = null;
			this.TEL.HeaderText = "电话";
			this.TEL.MappingName = "TEL";
			this.TEL.NullText = "";
			this.TEL.Width = 75;
			// 
			// FAX
			// 
			this.FAX.Format = "";
			this.FAX.FormatInfo = null;
			this.FAX.HeaderText = "传真";
			this.FAX.MappingName = "FAX";
			this.FAX.NullText = "";
			this.FAX.Width = 75;
			// 
			// CITY
			// 
			this.CITY.Format = "";
			this.CITY.FormatInfo = null;
			this.CITY.HeaderText = "城市";
			this.CITY.MappingName = "CITY";
			this.CITY.NullText = "";
			this.CITY.Width = 75;
			// 
			// ADDRESS
			// 
			this.ADDRESS.Format = "";
			this.ADDRESS.FormatInfo = null;
			this.ADDRESS.HeaderText = "地址";
			this.ADDRESS.MappingName = "ADDRESS";
			this.ADDRESS.NullText = "";
			this.ADDRESS.Width = 75;
			// 
			// EMPLOYEE_ID
			// 
			this.EMPLOYEE_ID.Format = "";
			this.EMPLOYEE_ID.FormatInfo = null;
			this.EMPLOYEE_ID.HeaderText = "负责人";
			this.EMPLOYEE_ID.MappingName = "EMPLOYEE_ID";
			this.EMPLOYEE_ID.NullText = "";
			this.EMPLOYEE_ID.Width = 75;
			// 
			// CREATEBY
			// 
			this.CREATEBY.Format = "";
			this.CREATEBY.FormatInfo = null;
			this.CREATEBY.HeaderText = "建立者";
			this.CREATEBY.MappingName = "CREATEBY";
			this.CREATEBY.NullText = "";
			this.CREATEBY.Width = 75;
			// 
			// CREATEON
			// 
			this.CREATEON.Format = "";
			this.CREATEON.FormatInfo = null;
			this.CREATEON.HeaderText = "建立时间";
			this.CREATEON.MappingName = "CREATEON";
			this.CREATEON.NullText = "";
			this.CREATEON.Width = 75;
			// 
			// MODIFYBY
			// 
			this.MODIFYBY.Format = "";
			this.MODIFYBY.FormatInfo = null;
			this.MODIFYBY.HeaderText = "最后修改者";
			this.MODIFYBY.MappingName = "MODIFYBY";
			this.MODIFYBY.NullText = "";
			this.MODIFYBY.Width = 75;
			// 
			// MODIFYON
			// 
			this.MODIFYON.Format = "";
			this.MODIFYON.FormatInfo = null;
			this.MODIFYON.HeaderText = "最后修改时间";
			this.MODIFYON.MappingName = "MODIFYON";
			this.MODIFYON.NullText = "";
			this.MODIFYON.Width = 75;
			// 
			// panel4
			// 
			this.panel4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel4.BackgroundImage")));
			this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.panel4.Controls.Add(this.priDateTimePicker3);
			this.panel4.Controls.Add(this.comboBox1);
			this.panel4.Controls.Add(this.label21);
			this.panel4.Controls.Add(this.priTextBox19);
			this.panel4.Controls.Add(this.label20);
			this.panel4.Controls.Add(this.priTextBox18);
			this.panel4.Controls.Add(this.label17);
			this.panel4.Controls.Add(this.label15);
			this.panel4.Controls.Add(this.label14);
			this.panel4.Controls.Add(this.label11);
			this.panel4.Controls.Add(this.label10);
			this.panel4.Controls.Add(this.label9);
			this.panel4.Controls.Add(this.label8);
			this.panel4.Controls.Add(this.label4);
			this.panel4.Controls.Add(this.label2);
			this.panel4.Controls.Add(this.priTextBox12);
			this.panel4.Controls.Add(this.priTextBox11);
			this.panel4.Controls.Add(this.priTextBox9);
			this.panel4.Controls.Add(this.priTextBox8);
			this.panel4.Controls.Add(this.priTextBox7);
			this.panel4.Controls.Add(this.priTextBox5);
			this.panel4.Controls.Add(this.textBox1);
			this.panel4.Controls.Add(this.label3);
			this.panel4.Controls.Add(this.priComboBox2);
			this.panel4.Controls.Add(this.label5);
			this.panel4.Controls.Add(this.priTextBox1);
			this.panel4.Controls.Add(this.label6);
			this.panel4.Controls.Add(this.priTextBox2);
			this.panel4.Controls.Add(this.priTextBox3);
			this.panel4.Controls.Add(this.label7);
			this.panel4.Controls.Add(this.priComboBox1);
			this.panel4.Controls.Add(this.label12);
			this.panel4.Controls.Add(this.label13);
			this.panel4.Controls.Add(this.priTextBox4);
			this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel4.Location = new System.Drawing.Point(0, 0);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(788, 344);
			this.panel4.TabIndex = 0;
			// 
			// priDateTimePicker3
			// 
			this.priDateTimePicker3.CustomFormat = "yyyy-MM-dd";
			this.priDateTimePicker3.DataField = "ff_date";
			this.priDateTimePicker3.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.priDateTimePicker3.Location = new System.Drawing.Point(312, 8);
			this.priDateTimePicker3.Name = "priDateTimePicker3";
			this.priDateTimePicker3.Size = new System.Drawing.Size(120, 23);
			this.priDateTimePicker3.TabIndex = 282;
			// 
			// comboBox1
			// 
			this.comboBox1.BackColor = System.Drawing.Color.White;
			this.comboBox1.DataField = "status";
			this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBox1.Location = new System.Drawing.Point(520, 8);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(128, 22);
			this.comboBox1.TabIndex = 280;
			// 
			// label21
			// 
			this.label21.BackColor = System.Drawing.Color.Transparent;
			this.label21.Location = new System.Drawing.Point(600, 128);
			this.label21.Name = "label21";
			this.label21.Size = new System.Drawing.Size(64, 23);
			this.label21.TabIndex = 271;
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
			this.priTextBox19.Location = new System.Drawing.Point(664, 128);
			this.priTextBox19.Name = "priTextBox19";
			this.priTextBox19.Size = new System.Drawing.Size(104, 23);
			this.priTextBox19.TabIndex = 270;
			this.priTextBox19.Text = "";
			// 
			// label20
			// 
			this.label20.BackColor = System.Drawing.Color.Transparent;
			this.label20.Location = new System.Drawing.Point(224, 128);
			this.label20.Name = "label20";
			this.label20.Size = new System.Drawing.Size(64, 23);
			this.label20.TabIndex = 268;
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
			this.priTextBox18.Location = new System.Drawing.Point(304, 128);
			this.priTextBox18.Name = "priTextBox18";
			this.priTextBox18.Size = new System.Drawing.Size(96, 23);
			this.priTextBox18.TabIndex = 267;
			this.priTextBox18.Text = "";
			// 
			// label17
			// 
			this.label17.BackColor = System.Drawing.Color.Transparent;
			this.label17.Location = new System.Drawing.Point(416, 128);
			this.label17.Name = "label17";
			this.label17.Size = new System.Drawing.Size(80, 23);
			this.label17.TabIndex = 265;
			this.label17.Text = "最后修改者";
			this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label15
			// 
			this.label15.BackColor = System.Drawing.Color.Transparent;
			this.label15.Location = new System.Drawing.Point(16, 128);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(96, 23);
			this.label15.TabIndex = 264;
			this.label15.Text = "创建者";
			this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label14
			// 
			this.label14.BackColor = System.Drawing.Color.Transparent;
			this.label14.Location = new System.Drawing.Point(16, 56);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(96, 23);
			this.label14.TabIndex = 262;
			this.label14.Text = "联系电话";
			this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label11
			// 
			this.label11.BackColor = System.Drawing.Color.Transparent;
			this.label11.Location = new System.Drawing.Point(16, 32);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(96, 23);
			this.label11.TabIndex = 261;
			this.label11.Text = "客户代码";
			this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label10
			// 
			this.label10.BackColor = System.Drawing.Color.Transparent;
			this.label10.Location = new System.Drawing.Point(224, 56);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(64, 23);
			this.label10.TabIndex = 260;
			this.label10.Text = "传真";
			this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label9
			// 
			this.label9.BackColor = System.Drawing.Color.Transparent;
			this.label9.Location = new System.Drawing.Point(16, 80);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(96, 23);
			this.label9.TabIndex = 257;
			this.label9.Text = "罚款原因";
			this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label8
			// 
			this.label8.BackColor = System.Drawing.Color.Transparent;
			this.label8.Location = new System.Drawing.Point(456, 8);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(56, 23);
			this.label8.TabIndex = 254;
			this.label8.Text = "状态";
			this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label4
			// 
			this.label4.BackColor = System.Drawing.Color.Transparent;
			this.label4.Location = new System.Drawing.Point(368, 32);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(80, 23);
			this.label4.TabIndex = 253;
			this.label4.Text = "客户名称";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label2
			// 
			this.label2.BackColor = System.Drawing.Color.Transparent;
			this.label2.Location = new System.Drawing.Point(16, 8);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(96, 23);
			this.label2.TabIndex = 252;
			this.label2.Text = "罚款单号";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// priTextBox12
			// 
			this.priTextBox12.BackColor = System.Drawing.Color.White;
			this.priTextBox12.DataField = "supplier_fax";
			this.priTextBox12.DataType = TJSystem.Public.DataType.String;
			this.priTextBox12.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.priTextBox12.Location = new System.Drawing.Point(304, 56);
			this.priTextBox12.Name = "priTextBox12";
			this.priTextBox12.Size = new System.Drawing.Size(96, 23);
			this.priTextBox12.TabIndex = 275;
			this.priTextBox12.Text = "";
			// 
			// priTextBox11
			// 
			this.priTextBox11.BackColor = System.Drawing.Color.White;
			this.priTextBox11.DataField = "createBy";
			this.priTextBox11.DataType = TJSystem.Public.DataType.String;
			this.priTextBox11.Enabled = false;
			this.priTextBox11.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.priTextBox11.Location = new System.Drawing.Point(120, 128);
			this.priTextBox11.Name = "priTextBox11";
			this.priTextBox11.Size = new System.Drawing.Size(96, 23);
			this.priTextBox11.TabIndex = 250;
			this.priTextBox11.Text = "";
			// 
			// priTextBox9
			// 
			this.priTextBox9.BackColor = System.Drawing.Color.White;
			this.priTextBox9.DataField = "remark";
			this.priTextBox9.DataType = TJSystem.Public.DataType.String;
			this.priTextBox9.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.priTextBox9.Location = new System.Drawing.Point(120, 80);
			this.priTextBox9.Name = "priTextBox9";
			this.priTextBox9.Size = new System.Drawing.Size(648, 23);
			this.priTextBox9.TabIndex = 278;
			this.priTextBox9.Text = "";
			// 
			// priTextBox8
			// 
			this.priTextBox8.BackColor = System.Drawing.Color.White;
			this.priTextBox8.DataField = "modifyBy";
			this.priTextBox8.DataType = TJSystem.Public.DataType.String;
			this.priTextBox8.Enabled = false;
			this.priTextBox8.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.priTextBox8.Location = new System.Drawing.Point(496, 128);
			this.priTextBox8.Name = "priTextBox8";
			this.priTextBox8.Size = new System.Drawing.Size(96, 23);
			this.priTextBox8.TabIndex = 249;
			this.priTextBox8.Text = "";
			// 
			// priTextBox7
			// 
			this.priTextBox7.BackColor = System.Drawing.Color.White;
			this.priTextBox7.DataField = "supplier_tel";
			this.priTextBox7.DataType = TJSystem.Public.DataType.String;
			this.priTextBox7.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.priTextBox7.Location = new System.Drawing.Point(120, 56);
			this.priTextBox7.Name = "priTextBox7";
			this.priTextBox7.Size = new System.Drawing.Size(96, 23);
			this.priTextBox7.TabIndex = 273;
			this.priTextBox7.Text = "";
			// 
			// priTextBox5
			// 
			this.priTextBox5.BackColor = System.Drawing.Color.White;
			this.priTextBox5.DataField = "SUPPLIER_NAME";
			this.priTextBox5.DataType = TJSystem.Public.DataType.String;
			this.priTextBox5.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.priTextBox5.Location = new System.Drawing.Point(456, 32);
			this.priTextBox5.Name = "priTextBox5";
			this.priTextBox5.Size = new System.Drawing.Size(312, 23);
			this.priTextBox5.TabIndex = 276;
			this.priTextBox5.Text = "";
			// 
			// textBox1
			// 
			this.textBox1.BackColor = System.Drawing.Color.White;
			this.textBox1.Cursor = System.Windows.Forms.Cursors.Default;
			this.textBox1.DataField = "ff_code";
			this.textBox1.DataType = TJSystem.Public.DataType.String;
			this.textBox1.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.textBox1.Location = new System.Drawing.Point(120, 8);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(96, 23);
			this.textBox1.TabIndex = 272;
			this.textBox1.Text = "";
			// 
			// label3
			// 
			this.label3.BackColor = System.Drawing.Color.Transparent;
			this.label3.Location = new System.Drawing.Point(224, 8);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(80, 23);
			this.label3.TabIndex = 256;
			this.label3.Text = "罚款日期";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// priComboBox2
			// 
			this.priComboBox2.BackColor = System.Drawing.Color.White;
			this.priComboBox2.DataField = "SUPPLIER_ID";
			this.priComboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.priComboBox2.Location = new System.Drawing.Point(120, 32);
			this.priComboBox2.Name = "priComboBox2";
			this.priComboBox2.Size = new System.Drawing.Size(248, 22);
			this.priComboBox2.TabIndex = 281;
			// 
			// label5
			// 
			this.label5.BackColor = System.Drawing.Color.Transparent;
			this.label5.Location = new System.Drawing.Point(16, 104);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(96, 23);
			this.label5.TabIndex = 258;
			this.label5.Text = "中文备注";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// priTextBox1
			// 
			this.priTextBox1.BackColor = System.Drawing.Color.White;
			this.priTextBox1.DataField = "remark_cn";
			this.priTextBox1.DataType = TJSystem.Public.DataType.String;
			this.priTextBox1.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.priTextBox1.Location = new System.Drawing.Point(120, 104);
			this.priTextBox1.Name = "priTextBox1";
			this.priTextBox1.Size = new System.Drawing.Size(648, 23);
			this.priTextBox1.TabIndex = 277;
			this.priTextBox1.Text = "";
			// 
			// label6
			// 
			this.label6.BackColor = System.Drawing.Color.Transparent;
			this.label6.Location = new System.Drawing.Point(224, 152);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(64, 23);
			this.label6.TabIndex = 269;
			this.label6.Text = "审核日期";
			this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// priTextBox2
			// 
			this.priTextBox2.BackColor = System.Drawing.Color.White;
			this.priTextBox2.DataField = "approvedby";
			this.priTextBox2.DataType = TJSystem.Public.DataType.String;
			this.priTextBox2.Enabled = false;
			this.priTextBox2.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.priTextBox2.Location = new System.Drawing.Point(120, 152);
			this.priTextBox2.Name = "priTextBox2";
			this.priTextBox2.Size = new System.Drawing.Size(96, 23);
			this.priTextBox2.TabIndex = 251;
			this.priTextBox2.Text = "";
			// 
			// priTextBox3
			// 
			this.priTextBox3.BackColor = System.Drawing.Color.White;
			this.priTextBox3.DataField = "approvedon";
			this.priTextBox3.DataType = TJSystem.Public.DataType.String;
			this.priTextBox3.Enabled = false;
			this.priTextBox3.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.priTextBox3.Location = new System.Drawing.Point(304, 152);
			this.priTextBox3.Name = "priTextBox3";
			this.priTextBox3.Size = new System.Drawing.Size(96, 23);
			this.priTextBox3.TabIndex = 266;
			this.priTextBox3.Text = "";
			// 
			// label7
			// 
			this.label7.BackColor = System.Drawing.Color.Transparent;
			this.label7.Location = new System.Drawing.Point(16, 152);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(96, 23);
			this.label7.TabIndex = 263;
			this.label7.Text = "审核者";
			this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// priComboBox1
			// 
			this.priComboBox1.BackColor = System.Drawing.Color.White;
			this.priComboBox1.DataField = "currency";
			this.priComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.priComboBox1.Location = new System.Drawing.Point(664, 56);
			this.priComboBox1.Name = "priComboBox1";
			this.priComboBox1.Size = new System.Drawing.Size(104, 22);
			this.priComboBox1.TabIndex = 279;
			// 
			// label12
			// 
			this.label12.BackColor = System.Drawing.Color.Transparent;
			this.label12.Location = new System.Drawing.Point(600, 56);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(56, 23);
			this.label12.TabIndex = 255;
			this.label12.Text = "币种";
			this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label13
			// 
			this.label13.BackColor = System.Drawing.Color.Transparent;
			this.label13.Location = new System.Drawing.Point(416, 56);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(64, 23);
			this.label13.TabIndex = 259;
			this.label13.Text = "总金额";
			this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// priTextBox4
			// 
			this.priTextBox4.BackColor = System.Drawing.Color.White;
			this.priTextBox4.DataField = "tot_amt";
			this.priTextBox4.DataType = TJSystem.Public.DataType.String;
			this.priTextBox4.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.priTextBox4.Location = new System.Drawing.Point(496, 56);
			this.priTextBox4.Name = "priTextBox4";
			this.priTextBox4.Size = new System.Drawing.Size(96, 23);
			this.priTextBox4.TabIndex = 274;
			this.priTextBox4.Text = "";
			// 
			// dataGridTextBoxColumn21
			// 
			this.dataGridTextBoxColumn21.Format = "";
			this.dataGridTextBoxColumn21.FormatInfo = null;
			this.dataGridTextBoxColumn21.HeaderText = "性别";
			this.dataGridTextBoxColumn21.MappingName = "Gender";
			this.dataGridTextBoxColumn21.NullText = "";
			this.dataGridTextBoxColumn21.Width = 75;
			// 
			// dataGridTextBoxColumn22
			// 
			this.dataGridTextBoxColumn22.Format = "";
			this.dataGridTextBoxColumn22.FormatInfo = null;
			this.dataGridTextBoxColumn22.HeaderText = "员工姓名";
			this.dataGridTextBoxColumn22.MappingName = "";
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
			this.label1.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.label1.Location = new System.Drawing.Point(0, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(788, 44);
			this.label1.TabIndex = 0;
			this.label1.Text = "收款通知单";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// frmAccountDebit
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
			this.Name = "frmAccountDebit";
			this.Text = "收款通知单";
			this.panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).EndInit();
			this.panel4.ResumeLayout(false);
			this.panel3.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		private void dataGrid1_Click(object sender, System.EventArgs e)
		{
		
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
				
			}	
			return true;
		}


		private void setDisable()
		{
			this.textBox1.Enabled = false;
			this.priTextBox11.Enabled = false;
			this.priTextBox18.Enabled = false;
			this.priTextBox12.Enabled = false;
			this.priTextBox19.Enabled = false;
			this.priTextBox3.Enabled = false;
			this.priTextBox4.Enabled = false;
			this.priTextBox5.Enabled = false;
			this.priTextBox7.Enabled = false;
			this.priTextBox8.Enabled = false;
			this.priTextBox9.Enabled = false;
			this.comboBox1.Enabled = false;
			this.priComboBox1.Enabled = false;
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
				TJSystem.Public.PublicStatic.formName = "收款通知单";
			}
			base.OnClosing (e);
		}
	}
}

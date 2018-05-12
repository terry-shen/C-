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
	public class frmAccountCC : System.Windows.Forms.Form
	{
		
		
		/// <summary>
		/// 必需的设计器变量。
		/// </summary>
		private System.ComponentModel.Container components = null;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.DataGridTableStyle dataGridTableStyle1;
		private System.Windows.Forms.DataGrid dataGrid1;
		private System.Windows.Forms.Panel panel4;
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
		private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn21;
		private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn22;
		private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn23;
		private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn24;
		private System.Windows.Forms.Panel panel3;
		private TJSystem.UC.PriToolBar priToolBar1;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label1;
		private TJSystem.Classes.PriComboBox comboBox1;
		private System.Windows.Forms.DataGridTextBoxColumn CREATEBY;
		private System.Windows.Forms.DataGridTextBoxColumn CREATEON;
		private System.Windows.Forms.DataGridTextBoxColumn MODIFYBY;
		private System.Windows.Forms.DataGridTextBoxColumn MODIFYON;
		public  static System.Windows.Forms.Form frmCurrent = null ;

		private string _table = null;
		private TJSystem.Classes.PriDateTimePicker priDateTimePicker3;
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
		private System.Windows.Forms.DataGridTextBoxColumn cc_code;
		private System.Windows.Forms.DataGridTextBoxColumn cc_date;
		private System.Windows.Forms.DataGridTextBoxColumn status_name;
		private System.Windows.Forms.DataGridTextBoxColumn client_id;
		private System.Windows.Forms.DataGridTextBoxColumn client_name;
		private System.Windows.Forms.DataGridTextBoxColumn client_tel;
		private System.Windows.Forms.DataGridTextBoxColumn client_fax;
		private System.Windows.Forms.DataGridTextBoxColumn tot_amt;
		private System.Windows.Forms.DataGridTextBoxColumn currency_namecn;
		private System.Windows.Forms.DataGridTextBoxColumn remark;
		private System.Windows.Forms.DataGridTextBoxColumn remark_cn;
		private System.Windows.Forms.DataGridTextBoxColumn approvedby;
		private System.Windows.Forms.DataGridTextBoxColumn approvedon;
		private TJSystem.Classes.PriComboBox priComboBox3;
		private System.Windows.Forms.Label label16;
		private System.Windows.Forms.DataGridTextBoxColumn feetype_name;
		private string _statusType = null;

		public frmAccountCC()
		{
			//
			// Windows 窗体设计器支持所必需的
			//
			InitializeComponent();

			
			_statusType = "account";

			TJSystem.Public.PublicStatic.setBackgroundImg(this.panel1,this.panel1.GetType().ToString(),"images\\bg.gif");
			TJSystem.Public.PublicStatic.setBackgroundImg(this.panel2,this.panel1.GetType().ToString(),"");
			TJSystem.Public.PublicStatic.setBackgroundImg(this.panel3,this.panel1.GetType().ToString(),"");
			TJSystem.Public.PublicStatic.setBackgroundImg(this.panel4,this.panel1.GetType().ToString(),"");

			InitialFormData();

			System.Text.StringBuilder sb = new System.Text.StringBuilder();
			sb.Append("select a.cc_code,a.cc_type,d.feetype_name as feetype_name,a.cc_date,a.status,c.status_name,a.client_id,a.client_name,a.client_tel,a.client_fax,a.tot_amt,");
			sb.Append(" a.currency,b.currency_namecn,remark,remark_cn,approvedby,approvedon,createby,createon,modifyby,modifyon");
			sb.Append(" from finance_cc_master a");
			sb.Append(" left join p_currency b on a.currency=b.currency_code");
			sb.Append(" left join p_status c on a.status=c.status_id and c.status_type=");
			sb.Append("'");
			sb.Append(this._statusType);
			sb.Append("'");
			sb.Append(" left join p_feetype d on a.cc_type=d.feetype_id");
			sb.Append(" order by a.cc_code");
			this.InitialGrid(sb.ToString());
			priToolBar1.setCurrentForm = this;
			_table= "finance_cc_master";
			_PK = "cc_code";
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
				
				this.priTextBox1.Enabled = true;
				this.priTextBox12.Enabled = true;				
				this.priTextBox4.Enabled = true;
				
				this.priTextBox7.Enabled = true;				
				this.priTextBox9.Enabled = true;
				this.comboBox1.Enabled = false;
				this.priComboBox1.Enabled = true;
				this.priComboBox2.Enabled = true;
				this.priComboBox3.Enabled = true;
				this.priDateTimePicker3.Enabled = true;
				
				this.textBox1.Text = "";	
				this.priTextBox1.Text = "";
				this.priTextBox12.Text = "";			
				this.priTextBox3.Text = "";				
				this.priTextBox4.Text = "";				
				this.priTextBox7.Text = "";
				
				this.priTextBox9.Text = "";
				this.comboBox1.SelectedValue = "1";
				this.priComboBox1.Text = "";
				this.priComboBox2.Text = "";
				this.priDateTimePicker3.Value = System.DateTime.Now;
			}
			else if(sqltype.Equals("update"))
			{
				this.textBox1.Enabled = false;
				this.priTextBox1.Enabled = true;
				this.priTextBox12.Enabled = true;
				this.priTextBox4.Enabled = true;
				
				this.priTextBox7.Enabled = true;
				this.priTextBox9.Enabled = true;
				this.comboBox1.Enabled = false;
				this.priComboBox1.Enabled = true;
				this.priComboBox2.Enabled = true;
				this.priComboBox3.Enabled = true;
				this.priDateTimePicker3.Enabled = true;
			}
			this.priToolBar1.SetStatusEnable(this.priComboBox1);
		}
		private void InitialFormData()
		{
			DataTable dtcpy = null;
			DataRow dr = null;
			string sql = null;
			if(TJSystem.Public.PublicStatic.Priority > 9)
			{
				sql = "select STATUS_ID,STATUS_ID+' '+STATUS_NAME as STATUS_NAME from p_status where status_type = '" + this._statusType + "' order by STATUS_ID";
			}
			else
			{
				sql = "select STATUS_ID,STATUS_ID+' '+STATUS_NAME as STATUS_NAME from p_status where status_type = '" + this._statusType + "' and status_id='1' order by STATUS_ID";
			}
			DataTable dt = TJSystem.Public.PublicStatic.db.GetDataTable(sql);
			dr = dt.NewRow() ;
			dr[0] = "" ;
			dr[1] = "" ;
			dt.Rows.InsertAt(dr,0) ;
			dtcpy = dt.Copy();
			this.comboBox1.DataSource = dtcpy.DefaultView;
			this.comboBox1.ValueMember = "STATUS_ID";
			this.comboBox1.DisplayMember = "STATUS_NAME";

			sql = "select CURRENCY_CODE,CURRENCY_CODE+' '+CURRENCY_NAMECN as CURRENCY_NAMECN from p_currency order by CURRENCY_CODE";
			dt = TJSystem.Public.PublicStatic.db.GetDataTable(sql);
			dr = dt.NewRow() ;
			dr[0] = "" ;
			dr[1] = "" ;
			dt.Rows.InsertAt(dr,0) ;
			dtcpy = dt.Copy();
			this.priComboBox1.DataSource = dtcpy.DefaultView;
			this.priComboBox1.ValueMember = "CURRENCY_CODE";
			this.priComboBox1.DisplayMember = "CURRENCY_NAMECN";

			sql = "select CLIENT_ID,CLIENT_ID+' '+CLIENT_NAME as CLIENT_NAME from basic_client order by client_id";
			dt = TJSystem.Public.PublicStatic.db.GetDataTable(sql);
			dr = dt.NewRow() ;
			dr[0] = "" ;
			dr[1] = "" ;
			dt.Rows.InsertAt(dr,0) ;
			dtcpy = dt.Copy();
			this.priComboBox2.DataSource = dtcpy.DefaultView;
			this.priComboBox2.ValueMember = "CLIENT_ID";
			this.priComboBox2.DisplayMember = "CLIENT_NAME";			

			sql = "select feetype_id,feetype_id+' '+feetype_name as feetype_name from p_feetype order by feetype_id";
			dt = TJSystem.Public.PublicStatic.db.GetDataTable(sql);
			dr = dt.NewRow() ;
			dr[0] = "" ;
			dr[1] = "" ;
			dt.Rows.InsertAt(dr,0) ;
			dtcpy = dt.Copy();
			this.priComboBox3.DataSource = dtcpy.DefaultView;
			this.priComboBox3.ValueMember = "feetype_id";
			this.priComboBox3.DisplayMember = "feetype_name";	
		}

		private void InitialGrid(string sql)
		{		
			DataTable dt = TJSystem.Public.PublicStatic.db.GetDataTable(sql);
			dt.TableName = "finance_cc_master";
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(frmAccountCC));
			this.panel2 = new System.Windows.Forms.Panel();
			this.dataGrid1 = new System.Windows.Forms.DataGrid();
			this.dataGridTableStyle1 = new System.Windows.Forms.DataGridTableStyle();
			this.cc_code = new System.Windows.Forms.DataGridTextBoxColumn();
			this.cc_date = new System.Windows.Forms.DataGridTextBoxColumn();
			this.feetype_name = new System.Windows.Forms.DataGridTextBoxColumn();
			this.status_name = new System.Windows.Forms.DataGridTextBoxColumn();
			this.client_id = new System.Windows.Forms.DataGridTextBoxColumn();
			this.client_name = new System.Windows.Forms.DataGridTextBoxColumn();
			this.client_tel = new System.Windows.Forms.DataGridTextBoxColumn();
			this.client_fax = new System.Windows.Forms.DataGridTextBoxColumn();
			this.tot_amt = new System.Windows.Forms.DataGridTextBoxColumn();
			this.currency_namecn = new System.Windows.Forms.DataGridTextBoxColumn();
			this.remark = new System.Windows.Forms.DataGridTextBoxColumn();
			this.remark_cn = new System.Windows.Forms.DataGridTextBoxColumn();
			this.CREATEBY = new System.Windows.Forms.DataGridTextBoxColumn();
			this.CREATEON = new System.Windows.Forms.DataGridTextBoxColumn();
			this.MODIFYBY = new System.Windows.Forms.DataGridTextBoxColumn();
			this.MODIFYON = new System.Windows.Forms.DataGridTextBoxColumn();
			this.approvedby = new System.Windows.Forms.DataGridTextBoxColumn();
			this.approvedon = new System.Windows.Forms.DataGridTextBoxColumn();
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
			this.priComboBox3 = new TJSystem.Classes.PriComboBox();
			this.label16 = new System.Windows.Forms.Label();
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
			this.dataGrid1.CaptionText = "客户索赔";
			this.dataGrid1.CaptionVisible = false;
			this.dataGrid1.DataMember = "";
			this.dataGrid1.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.dataGrid1.Location = new System.Drawing.Point(0, 192);
			this.dataGrid1.Name = "dataGrid1";
			this.dataGrid1.ReadOnly = true;
			this.dataGrid1.Size = new System.Drawing.Size(784, 280);
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
																												  this.cc_code,
																												  this.cc_date,
																												  this.feetype_name,
																												  this.status_name,
																												  this.client_id,
																												  this.client_name,
																												  this.client_tel,
																												  this.client_fax,
																												  this.tot_amt,
																												  this.currency_namecn,
																												  this.remark,
																												  this.remark_cn,
																												  this.CREATEBY,
																												  this.CREATEON,
																												  this.MODIFYBY,
																												  this.MODIFYON,
																												  this.approvedby,
																												  this.approvedon});
			this.dataGridTableStyle1.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.dataGridTableStyle1.MappingName = "finance_cc_master";
			this.dataGridTableStyle1.ReadOnly = true;
			// 
			// cc_code
			// 
			this.cc_code.Format = "";
			this.cc_code.FormatInfo = null;
			this.cc_code.HeaderText = "索赔单号";
			this.cc_code.MappingName = "cc_code";
			this.cc_code.NullText = "";
			this.cc_code.Width = 75;
			// 
			// cc_date
			// 
			this.cc_date.Format = "";
			this.cc_date.FormatInfo = null;
			this.cc_date.HeaderText = "索赔日期";
			this.cc_date.MappingName = "cc_date";
			this.cc_date.NullText = "";
			this.cc_date.Width = 75;
			// 
			// feetype_name
			// 
			this.feetype_name.Format = "";
			this.feetype_name.FormatInfo = null;
			this.feetype_name.HeaderText = "单据类型";
			this.feetype_name.MappingName = "feetype_name";
			this.feetype_name.NullText = "";
			this.feetype_name.Width = 75;
			// 
			// status_name
			// 
			this.status_name.Format = "";
			this.status_name.FormatInfo = null;
			this.status_name.HeaderText = "状态";
			this.status_name.MappingName = "status_name";
			this.status_name.NullText = "";
			this.status_name.Width = 75;
			// 
			// client_id
			// 
			this.client_id.Format = "";
			this.client_id.FormatInfo = null;
			this.client_id.HeaderText = "客户编号";
			this.client_id.MappingName = "client_id";
			this.client_id.NullText = "";
			this.client_id.Width = 75;
			// 
			// client_name
			// 
			this.client_name.Format = "";
			this.client_name.FormatInfo = null;
			this.client_name.HeaderText = "客户名称";
			this.client_name.MappingName = "client_name";
			this.client_name.NullText = "";
			this.client_name.Width = 75;
			// 
			// client_tel
			// 
			this.client_tel.Format = "";
			this.client_tel.FormatInfo = null;
			this.client_tel.HeaderText = "电话";
			this.client_tel.MappingName = "client_tel";
			this.client_tel.NullText = "";
			this.client_tel.Width = 75;
			// 
			// client_fax
			// 
			this.client_fax.Format = "";
			this.client_fax.FormatInfo = null;
			this.client_fax.HeaderText = "传真";
			this.client_fax.MappingName = "client_fax";
			this.client_fax.NullText = "";
			this.client_fax.Width = 75;
			// 
			// tot_amt
			// 
			this.tot_amt.Format = "";
			this.tot_amt.FormatInfo = null;
			this.tot_amt.HeaderText = "总金额";
			this.tot_amt.MappingName = "tot_amt";
			this.tot_amt.NullText = "";
			this.tot_amt.Width = 75;
			// 
			// currency_namecn
			// 
			this.currency_namecn.Format = "";
			this.currency_namecn.FormatInfo = null;
			this.currency_namecn.HeaderText = "币种";
			this.currency_namecn.MappingName = "currency_namecn";
			this.currency_namecn.NullText = "";
			this.currency_namecn.Width = 75;
			// 
			// remark
			// 
			this.remark.Format = "";
			this.remark.FormatInfo = null;
			this.remark.HeaderText = "备注";
			this.remark.MappingName = "remark";
			this.remark.NullText = "";
			this.remark.Width = 75;
			// 
			// remark_cn
			// 
			this.remark_cn.Format = "";
			this.remark_cn.FormatInfo = null;
			this.remark_cn.HeaderText = "中文备注";
			this.remark_cn.MappingName = "remark_cn";
			this.remark_cn.NullText = "";
			this.remark_cn.Width = 75;
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
			// approvedby
			// 
			this.approvedby.Format = "";
			this.approvedby.FormatInfo = null;
			this.approvedby.HeaderText = "审核人";
			this.approvedby.MappingName = "approvedby";
			this.approvedby.NullText = "";
			this.approvedby.Width = 75;
			// 
			// approvedon
			// 
			this.approvedon.Format = "";
			this.approvedon.FormatInfo = null;
			this.approvedon.HeaderText = "审核日期";
			this.approvedon.MappingName = "approvedon";
			this.approvedon.NullText = "";
			this.approvedon.Width = 75;
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
			this.panel4.Controls.Add(this.priComboBox3);
			this.panel4.Controls.Add(this.label16);
			this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel4.Location = new System.Drawing.Point(0, 0);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(788, 184);
			this.panel4.TabIndex = 0;
			// 
			// priDateTimePicker3
			// 
			this.priDateTimePicker3.CustomFormat = "yyyy-MM-dd";
			this.priDateTimePicker3.DataField = "cc_date";
			this.priDateTimePicker3.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.priDateTimePicker3.Location = new System.Drawing.Point(288, 8);
			this.priDateTimePicker3.Name = "priDateTimePicker3";
			this.priDateTimePicker3.Size = new System.Drawing.Size(120, 22);
			this.priDateTimePicker3.TabIndex = 214;
			// 
			// comboBox1
			// 
			this.comboBox1.BackColor = System.Drawing.Color.White;
			this.comboBox1.DataField = "status";
			this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBox1.Location = new System.Drawing.Point(464, 8);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(104, 21);
			this.comboBox1.TabIndex = 110;
			// 
			// label21
			// 
			this.label21.BackColor = System.Drawing.Color.Transparent;
			this.label21.Location = new System.Drawing.Point(592, 128);
			this.label21.Name = "label21";
			this.label21.Size = new System.Drawing.Size(64, 23);
			this.label21.TabIndex = 42;
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
			this.priTextBox19.Location = new System.Drawing.Point(656, 128);
			this.priTextBox19.Name = "priTextBox19";
			this.priTextBox19.Size = new System.Drawing.Size(104, 23);
			this.priTextBox19.TabIndex = 41;
			this.priTextBox19.Text = "";
			// 
			// label20
			// 
			this.label20.BackColor = System.Drawing.Color.Transparent;
			this.label20.Location = new System.Drawing.Point(216, 128);
			this.label20.Name = "label20";
			this.label20.Size = new System.Drawing.Size(64, 23);
			this.label20.TabIndex = 40;
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
			this.priTextBox18.Location = new System.Drawing.Point(296, 128);
			this.priTextBox18.Name = "priTextBox18";
			this.priTextBox18.Size = new System.Drawing.Size(96, 23);
			this.priTextBox18.TabIndex = 39;
			this.priTextBox18.Text = "";
			// 
			// label17
			// 
			this.label17.BackColor = System.Drawing.Color.Transparent;
			this.label17.Location = new System.Drawing.Point(408, 128);
			this.label17.Name = "label17";
			this.label17.Size = new System.Drawing.Size(80, 23);
			this.label17.TabIndex = 32;
			this.label17.Text = "最后修改者";
			this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label15
			// 
			this.label15.BackColor = System.Drawing.Color.Transparent;
			this.label15.Location = new System.Drawing.Point(8, 128);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(96, 23);
			this.label15.TabIndex = 29;
			this.label15.Text = "创建者";
			this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label14
			// 
			this.label14.BackColor = System.Drawing.Color.Transparent;
			this.label14.Location = new System.Drawing.Point(8, 56);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(96, 23);
			this.label14.TabIndex = 28;
			this.label14.Text = "联系电话";
			this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label11
			// 
			this.label11.BackColor = System.Drawing.Color.Transparent;
			this.label11.ForeColor = System.Drawing.Color.Blue;
			this.label11.Location = new System.Drawing.Point(8, 32);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(96, 23);
			this.label11.TabIndex = 25;
			this.label11.Text = "客户代码";
			this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label10
			// 
			this.label10.BackColor = System.Drawing.Color.Transparent;
			this.label10.Location = new System.Drawing.Point(216, 56);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(64, 23);
			this.label10.TabIndex = 24;
			this.label10.Text = "传真";
			this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label9
			// 
			this.label9.BackColor = System.Drawing.Color.Transparent;
			this.label9.Location = new System.Drawing.Point(8, 80);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(96, 23);
			this.label9.TabIndex = 23;
			this.label9.Text = "备注";
			this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label8
			// 
			this.label8.BackColor = System.Drawing.Color.Transparent;
			this.label8.ForeColor = System.Drawing.Color.Blue;
			this.label8.Location = new System.Drawing.Point(424, 8);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(32, 23);
			this.label8.TabIndex = 22;
			this.label8.Text = "状态";
			this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label4
			// 
			this.label4.BackColor = System.Drawing.Color.Transparent;
			this.label4.Location = new System.Drawing.Point(360, 32);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(80, 23);
			this.label4.TabIndex = 18;
			this.label4.Text = "客户名称";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label2
			// 
			this.label2.BackColor = System.Drawing.Color.Transparent;
			this.label2.ForeColor = System.Drawing.Color.Blue;
			this.label2.Location = new System.Drawing.Point(8, 8);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(96, 23);
			this.label2.TabIndex = 16;
			this.label2.Text = "客户索赔单号";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// priTextBox12
			// 
			this.priTextBox12.BackColor = System.Drawing.Color.White;
			this.priTextBox12.DataField = "client_fax";
			this.priTextBox12.DataType = TJSystem.Public.DataType.String;
			this.priTextBox12.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.priTextBox12.Location = new System.Drawing.Point(296, 56);
			this.priTextBox12.Name = "priTextBox12";
			this.priTextBox12.Size = new System.Drawing.Size(96, 23);
			this.priTextBox12.TabIndex = 106;
			this.priTextBox12.Text = "";
			// 
			// priTextBox11
			// 
			this.priTextBox11.BackColor = System.Drawing.Color.White;
			this.priTextBox11.DataField = "createBy";
			this.priTextBox11.DataType = TJSystem.Public.DataType.String;
			this.priTextBox11.Enabled = false;
			this.priTextBox11.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.priTextBox11.Location = new System.Drawing.Point(112, 128);
			this.priTextBox11.Name = "priTextBox11";
			this.priTextBox11.Size = new System.Drawing.Size(96, 23);
			this.priTextBox11.TabIndex = 12;
			this.priTextBox11.Text = "";
			// 
			// priTextBox9
			// 
			this.priTextBox9.BackColor = System.Drawing.Color.White;
			this.priTextBox9.DataField = "remark";
			this.priTextBox9.DataType = TJSystem.Public.DataType.String;
			this.priTextBox9.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.priTextBox9.Location = new System.Drawing.Point(112, 80);
			this.priTextBox9.Name = "priTextBox9";
			this.priTextBox9.Size = new System.Drawing.Size(648, 23);
			this.priTextBox9.TabIndex = 109;
			this.priTextBox9.Text = "";
			// 
			// priTextBox8
			// 
			this.priTextBox8.BackColor = System.Drawing.Color.White;
			this.priTextBox8.DataField = "modifyBy";
			this.priTextBox8.DataType = TJSystem.Public.DataType.String;
			this.priTextBox8.Enabled = false;
			this.priTextBox8.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.priTextBox8.Location = new System.Drawing.Point(488, 128);
			this.priTextBox8.Name = "priTextBox8";
			this.priTextBox8.Size = new System.Drawing.Size(96, 23);
			this.priTextBox8.TabIndex = 9;
			this.priTextBox8.Text = "";
			// 
			// priTextBox7
			// 
			this.priTextBox7.BackColor = System.Drawing.Color.White;
			this.priTextBox7.DataField = "client_tel";
			this.priTextBox7.DataType = TJSystem.Public.DataType.String;
			this.priTextBox7.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.priTextBox7.Location = new System.Drawing.Point(112, 56);
			this.priTextBox7.Name = "priTextBox7";
			this.priTextBox7.Size = new System.Drawing.Size(96, 23);
			this.priTextBox7.TabIndex = 105;
			this.priTextBox7.Text = "";
			// 
			// priTextBox5
			// 
			this.priTextBox5.BackColor = System.Drawing.Color.White;
			this.priTextBox5.DataField = "client_name";
			this.priTextBox5.DataType = TJSystem.Public.DataType.String;
			this.priTextBox5.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.priTextBox5.Location = new System.Drawing.Point(448, 32);
			this.priTextBox5.Name = "priTextBox5";
			this.priTextBox5.Size = new System.Drawing.Size(312, 23);
			this.priTextBox5.TabIndex = 108;
			this.priTextBox5.Text = "";
			// 
			// textBox1
			// 
			this.textBox1.BackColor = System.Drawing.Color.White;
			this.textBox1.Cursor = System.Windows.Forms.Cursors.Default;
			this.textBox1.DataField = "cc_code";
			this.textBox1.DataType = TJSystem.Public.DataType.String;
			this.textBox1.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.textBox1.Location = new System.Drawing.Point(112, 8);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(96, 23);
			this.textBox1.TabIndex = 100;
			this.textBox1.Text = "";
			// 
			// label3
			// 
			this.label3.BackColor = System.Drawing.Color.Transparent;
			this.label3.ForeColor = System.Drawing.Color.Blue;
			this.label3.Location = new System.Drawing.Point(216, 8);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(64, 23);
			this.label3.TabIndex = 22;
			this.label3.Text = "索赔日期";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// priComboBox2
			// 
			this.priComboBox2.BackColor = System.Drawing.Color.White;
			this.priComboBox2.DataField = "client_id";
			this.priComboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.priComboBox2.Location = new System.Drawing.Point(112, 32);
			this.priComboBox2.Name = "priComboBox2";
			this.priComboBox2.Size = new System.Drawing.Size(248, 21);
			this.priComboBox2.TabIndex = 110;
			this.priComboBox2.SelectionChangeCommitted += new System.EventHandler(this.priComboBox2_SelectionChangeCommitted);
			// 
			// label5
			// 
			this.label5.BackColor = System.Drawing.Color.Transparent;
			this.label5.Location = new System.Drawing.Point(8, 104);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(96, 23);
			this.label5.TabIndex = 23;
			this.label5.Text = "中文备注";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// priTextBox1
			// 
			this.priTextBox1.BackColor = System.Drawing.Color.White;
			this.priTextBox1.DataField = "remark_cn";
			this.priTextBox1.DataType = TJSystem.Public.DataType.String;
			this.priTextBox1.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.priTextBox1.Location = new System.Drawing.Point(112, 104);
			this.priTextBox1.Name = "priTextBox1";
			this.priTextBox1.Size = new System.Drawing.Size(648, 23);
			this.priTextBox1.TabIndex = 109;
			this.priTextBox1.Text = "";
			// 
			// label6
			// 
			this.label6.BackColor = System.Drawing.Color.Transparent;
			this.label6.Location = new System.Drawing.Point(216, 152);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(64, 23);
			this.label6.TabIndex = 40;
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
			this.priTextBox2.Location = new System.Drawing.Point(112, 152);
			this.priTextBox2.Name = "priTextBox2";
			this.priTextBox2.Size = new System.Drawing.Size(96, 23);
			this.priTextBox2.TabIndex = 12;
			this.priTextBox2.Text = "";
			// 
			// priTextBox3
			// 
			this.priTextBox3.BackColor = System.Drawing.Color.White;
			this.priTextBox3.DataField = "approvedon";
			this.priTextBox3.DataType = TJSystem.Public.DataType.String;
			this.priTextBox3.Enabled = false;
			this.priTextBox3.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.priTextBox3.Location = new System.Drawing.Point(296, 152);
			this.priTextBox3.Name = "priTextBox3";
			this.priTextBox3.Size = new System.Drawing.Size(96, 23);
			this.priTextBox3.TabIndex = 39;
			this.priTextBox3.Text = "";
			// 
			// label7
			// 
			this.label7.BackColor = System.Drawing.Color.Transparent;
			this.label7.Location = new System.Drawing.Point(8, 152);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(96, 23);
			this.label7.TabIndex = 29;
			this.label7.Text = "审核者";
			this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// priComboBox1
			// 
			this.priComboBox1.BackColor = System.Drawing.Color.White;
			this.priComboBox1.DataField = "currency";
			this.priComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.priComboBox1.Location = new System.Drawing.Point(656, 56);
			this.priComboBox1.Name = "priComboBox1";
			this.priComboBox1.Size = new System.Drawing.Size(104, 21);
			this.priComboBox1.TabIndex = 110;
			// 
			// label12
			// 
			this.label12.BackColor = System.Drawing.Color.Transparent;
			this.label12.ForeColor = System.Drawing.Color.Blue;
			this.label12.Location = new System.Drawing.Point(592, 56);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(56, 23);
			this.label12.TabIndex = 22;
			this.label12.Text = "币种";
			this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label13
			// 
			this.label13.BackColor = System.Drawing.Color.Transparent;
			this.label13.ForeColor = System.Drawing.Color.Blue;
			this.label13.Location = new System.Drawing.Point(408, 56);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(64, 23);
			this.label13.TabIndex = 24;
			this.label13.Text = "总金额";
			this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// priTextBox4
			// 
			this.priTextBox4.BackColor = System.Drawing.Color.White;
			this.priTextBox4.DataField = "tot_amt";
			this.priTextBox4.DataType = TJSystem.Public.DataType.String;
			this.priTextBox4.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.priTextBox4.Location = new System.Drawing.Point(488, 56);
			this.priTextBox4.Name = "priTextBox4";
			this.priTextBox4.Size = new System.Drawing.Size(96, 23);
			this.priTextBox4.TabIndex = 106;
			this.priTextBox4.Text = "";
			// 
			// priComboBox3
			// 
			this.priComboBox3.BackColor = System.Drawing.Color.White;
			this.priComboBox3.DataField = "cc_type";
			this.priComboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.priComboBox3.Location = new System.Drawing.Point(632, 8);
			this.priComboBox3.Name = "priComboBox3";
			this.priComboBox3.Size = new System.Drawing.Size(128, 21);
			this.priComboBox3.TabIndex = 110;
			// 
			// label16
			// 
			this.label16.BackColor = System.Drawing.Color.Transparent;
			this.label16.ForeColor = System.Drawing.Color.Blue;
			this.label16.Location = new System.Drawing.Point(584, 8);
			this.label16.Name = "label16";
			this.label16.Size = new System.Drawing.Size(40, 23);
			this.label16.TabIndex = 22;
			this.label16.Text = "类型";
			this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
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
			this.label1.Font = new System.Drawing.Font("宋体", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.label1.Location = new System.Drawing.Point(0, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(788, 44);
			this.label1.TabIndex = 0;
			this.label1.Text = "客户索赔";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// frmAccountCC
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(7, 15);
			this.BackColor = System.Drawing.SystemColors.ScrollBar;
			this.ClientSize = new System.Drawing.Size(792, 566);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel3);
			this.Controls.Add(this.panel1);
			this.Font = new System.Drawing.Font("宋体", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "frmAccountCC";
			this.Text = "客户索赔";
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
			this.priTextBox1.Enabled = false;
			this.priTextBox11.Enabled = false;
			this.priTextBox18.Enabled = false;
			this.priTextBox12.Enabled = false;
			this.priTextBox19.Enabled = false;
			this.priTextBox2.Enabled = false;
			this.priTextBox3.Enabled = false;
			this.priTextBox4.Enabled = false;
			this.priTextBox5.Enabled = false;
			this.priTextBox7.Enabled = false;
			this.priTextBox8.Enabled = false;
			this.priTextBox9.Enabled = false;
			this.comboBox1.Enabled = false;
			this.priComboBox1.Enabled = false;
			this.priComboBox2.Enabled = false;
			this.priComboBox3.Enabled = false;
			this.priDateTimePicker3.Enabled = false;
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
				TJSystem.Public.PublicStatic.formName = "客户索赔";
			}
			base.OnClosing (e);
		}

		private void priComboBox2_SelectionChangeCommitted(object sender, System.EventArgs e)
		{
			string sql = "select CLIENT_ID,CLIENT_NAME from basic_client where CLIENT_ID='" + priComboBox2.SelectedValue.ToString() + "'";
			DataTable dt = TJSystem.Public.PublicStatic.db.GetDataTable(sql);
			if(dt.Rows.Count != 1)
			{
				this.priTextBox5.Text= "";
				return;
			}
			this.priTextBox5.Text=dt.Rows[0][1].ToString();
		}
	}
}

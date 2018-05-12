using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace TJSystem.Clients
{
	/// <summary>
	/// Form1 的摘要说明。
	/// </summary>
	public class frmClientTrans : System.Windows.Forms.Form
	{
		
		
		/// <summary>
		/// 必需的设计器变量。
		/// </summary>
		private System.ComponentModel.Container components = null;
		
		private System.Windows.Forms.Panel panel3;
		private TJSystem.UC.PriToolBar priToolBar1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.DataGridTableStyle dataGridTableStyle1;
		private System.Windows.Forms.DataGrid dataGrid1;
		private System.Windows.Forms.Panel panel4;
		private System.Windows.Forms.Label label32;
		private TJSystem.Classes.PriTextBox txt14;
		private System.Windows.Forms.Label label31;
		private TJSystem.Classes.PriTextBox txt12;
		private System.Windows.Forms.Label label30;
		private System.Windows.Forms.Label label29;
		private TJSystem.Classes.PriTextBox txt6;
		private System.Windows.Forms.Label label28;
		private System.Windows.Forms.Label label27;
		private System.Windows.Forms.Label label21;
		private System.Windows.Forms.Label label20;
		private System.Windows.Forms.Label label19;
		private System.Windows.Forms.Label label17;
		private System.Windows.Forms.Label label16;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private TJSystem.Classes.PriTextBox txt15;
		private TJSystem.Classes.PriTextBox txt7;
		private TJSystem.Classes.PriTextBox txt11;
		private TJSystem.Classes.PriTextBox txt5;
		private TJSystem.Classes.PriTextBox txt10;
		private TJSystem.Classes.PriTextBox txt1;
		private TJSystem.Classes.PriTextBox txt13;
		
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label1;
		
		private TJSystem.Classes.PriTextBox txt20;
		private TJSystem.Classes.PriTextBox txt18;
		private TJSystem.Classes.PriTextBox txt16;
		private TJSystem.Classes.PriTextBox txt17;
		private TJSystem.Classes.PriTextBox txt19;
		public static System.Windows.Forms.Form frmCurrent = null ;
		private TJSystem.Classes.PriComboBox priComboBox6;
		private TJSystem.Classes.PriComboBox priComboBox5;
		private TJSystem.Classes.PriComboBox priComboBox2;
		private TJSystem.Classes.PriComboBox priComboBox1;
		private TJSystem.Classes.PriComboBox comboBox1;
		private System.Windows.Forms.LinkLabel linkLabel2;
		private System.Windows.Forms.LinkLabel linkLabel1;
		private string _PK = null;
		private System.Windows.Forms.DataGridTextBoxColumn forwarder_id;
		private System.Windows.Forms.DataGridTextBoxColumn forwarder_type;
		private System.Windows.Forms.DataGridTextBoxColumn forwarder_name;
		private System.Windows.Forms.DataGridTextBoxColumn address;
		private System.Windows.Forms.DataGridTextBoxColumn Postcode;
		private System.Windows.Forms.DataGridTextBoxColumn province;
		private System.Windows.Forms.DataGridTextBoxColumn city;
		private System.Windows.Forms.DataGridTextBoxColumn tel;
		private System.Windows.Forms.DataGridTextBoxColumn fax;
		private System.Windows.Forms.DataGridTextBoxColumn Email;
		private System.Windows.Forms.DataGridTextBoxColumn Website;
		private System.Windows.Forms.DataGridTextBoxColumn Evaluation;
		private System.Windows.Forms.DataGridTextBoxColumn createBy;
		private System.Windows.Forms.DataGridTextBoxColumn createon;
		private System.Windows.Forms.DataGridTextBoxColumn modifyBy;
		private System.Windows.Forms.DataGridTextBoxColumn modifyon;
		private string _statusType = null;
		private System.Windows.Forms.DataGridTextBoxColumn grade_name;
		private System.Windows.Forms.DataGridTextBoxColumn status_name;
		private System.Windows.Forms.DataGridTextBoxColumn country_namecn;
		private System.Windows.Forms.DataGridTextBoxColumn region_namecn;
		private string _table = null;

		public frmClientTrans()
		{
			//
			// Windows 窗体设计器支持所必需的
			//
			InitializeComponent();

			

			_statusType = "clients";

			TJSystem.Public.PublicStatic.setBackgroundImg(this.panel1,this.panel1.GetType().ToString(),"images\\bg.gif");
			TJSystem.Public.PublicStatic.setBackgroundImg(this.panel2,this.panel1.GetType().ToString(),"");
			TJSystem.Public.PublicStatic.setBackgroundImg(this.panel3,this.panel1.GetType().ToString(),"");
			TJSystem.Public.PublicStatic.setBackgroundImg(this.panel4,this.panel1.GetType().ToString(),"");
			this.InitialFormData();

			System.Text.StringBuilder sb = new System.Text.StringBuilder();
			sb.Append("select a.forwarder_id,a.forwarder_type,h.type_name as type_name,a.grade,b.grade_name as grade_name,");
			sb.Append("a.status,c.status_name as status_name,a.forwarder_name,a.address,a.Postcode,");
			sb.Append("a.country,d.country_namecn as country_namecn,a.region_code,e.region_namecn as region_namecn,a.province,");
			sb.Append("a.city,a.tel,a.fax,a.Email,a.Website,a.Evaluation,a.createBy,a.createon,a.modifyBy,a.modifyon ");
			sb.Append("from basic_forwarder a ");
			sb.Append("left join p_enterprisetype h on a.forwarder_type=h.type_code ");
			sb.Append("left join p_grade b on a.grade=b.grade_id ");
			sb.Append("left join p_status c on a.status=c.status_id and status_type=");
			sb.Append("'");
			sb.Append(this._statusType);
			sb.Append("' ");
			sb.Append("left join p_country d on a.country=d.country_code ");
			sb.Append("left join p_region e on a.region_code=e.region_code ");
			sb.Append("order by a.forwarder_id");
			this.InitialGrid(sb.ToString());

			priToolBar1.setCurrentForm = this;
			_table = "basic_forwarder";
			_PK = "forwarder_id";
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

		private void InitialFormData()
		{
			DataTable dtcpy = null;
			DataRow dr = null;
			string sql = "select GRADE_ID,GRADE_ID+' '+GRADE_NAME as GRADE_NAME from p_grade order by GRADE_ID";
			DataTable dt = TJSystem.Public.PublicStatic.db.GetDataTable(sql);
			dr = dt.NewRow() ;
			dr[0] = "" ;
			dr[1] = "" ;
			dt.Rows.InsertAt(dr,0) ;
			dtcpy = dt.Copy();
			this.priComboBox2.DataSource = dtcpy.DefaultView;
			this.priComboBox2.ValueMember = "GRADE_ID";
			this.priComboBox2.DisplayMember = "GRADE_NAME";

			sql = "select STATUS_ID,STATUS_ID+' '+STATUS_NAME as STATUS_NAME from p_status where status_type = '" + this._statusType + "' order by STATUS_ID";
			dt = TJSystem.Public.PublicStatic.db.GetDataTable(sql);
			dr = dt.NewRow() ;
			dr[0] = "" ;
			dr[1] = "" ;
			dt.Rows.InsertAt(dr,0) ;
			dtcpy = dt.Copy();
			this.priComboBox1.DataSource = dtcpy.DefaultView;
			this.priComboBox1.ValueMember = "STATUS_ID";
			this.priComboBox1.DisplayMember = "STATUS_NAME";

			sql = "select COUNTRY_CODE,COUNTRY_CODE+' '+COUNTRY_NAMECN as COUNTRY_NAMECN from p_country order by COUNTRY_CODE";
			dt = TJSystem.Public.PublicStatic.db.GetDataTable(sql);
			dr = dt.NewRow() ;
			dr[0] = "" ;
			dr[1] = "" ;
			dt.Rows.InsertAt(dr,0) ;
			dtcpy = dt.Copy();
			this.priComboBox5.DataSource = dtcpy.DefaultView;
			this.priComboBox5.ValueMember = "COUNTRY_CODE";
			this.priComboBox5.DisplayMember = "COUNTRY_NAMECN";

			sql = "select REGION_CODE,REGION_CODE+' '+REGION_NAMECN as REGION_NAMECN from p_region order by REGION_CODE";
			dt = TJSystem.Public.PublicStatic.db.GetDataTable(sql);
			dr = dt.NewRow() ;
			dr[0] = "" ;
			dr[1] = "" ;
			dt.Rows.InsertAt(dr,0) ;
			dtcpy = dt.Copy();
			this.priComboBox6.DataSource = dtcpy.DefaultView;
			this.priComboBox6.ValueMember = "REGION_CODE";
			this.priComboBox6.DisplayMember = "REGION_NAMECN";
			
			sql = "select TYPE_CODE,TYPE_CODE+' '+TYPE_NAME as TYPE_NAME from p_enterprisetype order by TYPE_CODE";
			dt = TJSystem.Public.PublicStatic.db.GetDataTable(sql);
			dr = dt.NewRow() ;
			dr[0] = "" ;
			dr[1] = "" ;
			dt.Rows.InsertAt(dr,0) ;
			dtcpy = dt.Copy();
			this.comboBox1.DataSource = dtcpy.DefaultView;
			this.comboBox1.ValueMember = "TYPE_CODE";
			this.comboBox1.DisplayMember = "TYPE_NAME";
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


		private bool checkFormValue(string sqltype)
		{
			DataSet ds = new DataSet();
			System.Text.StringBuilder sb = new System.Text.StringBuilder();
			sb.Append("数据验证错误：\r\n");

			if(sqltype.Equals("insert"))
			{
				if(txt1.Text.Length > 10)
				{
					sb.Append("  数据长度超出数据库定义要求\r\n");
					TJSystem.Public.PublicStatic.ShowMessage(TJSystem.Public.MessageType.Error,sb.ToString());
					return false;
				}

				if (this.txt1.Text == "")
				{
					sb.Append("  请输入运输商编号\r\n");
					TJSystem.Public.PublicStatic.ShowMessage(TJSystem.Public.MessageType.Error,sb.ToString());
					return false;
				}
				
				if(TJSystem.Public.PublicStatic.IsExsist(_table,_PK,this.priToolBar1))
				{
					sb.Append("  这个运输商信息已经存在,请另外开立\r\n");
					TJSystem.Public.PublicStatic.ShowMessage(TJSystem.Public.MessageType.Error,sb.ToString());
					return false;
				}
			}
			return true;
		}


		private void setDisable()
		{
			this.txt1.Enabled = false;
			
			this.txt5.Enabled = false;
			this.txt6.Enabled = false;
			this.txt7.Enabled = false;
			
			this.txt10.Enabled = false;
			this.txt11.Enabled = false;
			this.txt12.Enabled = false;
			this.txt13.Enabled = false;
			this.txt14.Enabled = false;
			this.txt15.Enabled = false;
			this.txt16.Enabled = false;
			this.txt17.Enabled = false;
			this.txt18.Enabled = false;
			this.txt19.Enabled = false;
			this.txt20.Enabled = false;
			this.comboBox1.Enabled = false;
			this.priComboBox1.Enabled = false;
			this.priComboBox2.Enabled = false;
			this.priComboBox5.Enabled = false;
			this.priComboBox6.Enabled = false;

		}

		private void AfterButtonClick(string ButtonType)
		{
			if(ButtonType.Equals("insert"))
			{
				this.txt1.Enabled = true;
				
				this.txt5.Enabled = true;
				this.txt6.Enabled = true;
				this.txt7.Enabled = true;
				
				this.txt10.Enabled = true;
				this.txt11.Enabled = true;
				this.txt12.Enabled = true;
				this.txt13.Enabled = true;
				this.txt14.Enabled = true;
				this.txt15.Enabled = true;
				this.txt16.Enabled = true;
				
				this.comboBox1.Enabled = true;
				this.priComboBox1.Enabled = true;
				this.priComboBox2.Enabled = true;
				this.priComboBox5.Enabled = true;
				this.priComboBox6.Enabled = true;



				this.txt1.Text = "";
				
				this.txt5.Text = "";
				this.txt6.Text = "";
				this.txt7.Text = "";
				
				this.txt10.Text = "";
				this.txt11.Text = "";
				this.txt12.Text = "";
				this.txt13.Text = "";
				this.txt14.Text = "";
				this.txt15.Text = "";
				this.txt16.Text = "";
				
				this.comboBox1.Text = "";
				this.priComboBox1.Text = "";
				this.priComboBox2.Text = "";
				this.priComboBox5.Text = "";
				this.priComboBox6.Text = "";



			}
			else if(ButtonType.Equals("update"))
			{
				this.txt1.Enabled = false;
				
				this.txt5.Enabled = true;
				this.txt6.Enabled = true;
				this.txt7.Enabled = true;
				
				this.txt10.Enabled = true;
				this.txt11.Enabled = true;
				this.txt12.Enabled = true;
				this.txt13.Enabled = true;
				this.txt14.Enabled = true;
				this.txt15.Enabled = true;
				this.txt16.Enabled = true;
				
				this.comboBox1.Enabled = true;
				this.priComboBox1.Enabled = true;
				this.priComboBox2.Enabled = true;
				this.priComboBox5.Enabled = true;
				this.priComboBox6.Enabled = true;


			}
		}

		private void InitialGrid(string sql)
		{		
			DataTable dt = TJSystem.Public.PublicStatic.db.GetDataTable(sql);
			dt.TableName = "basic_forwarder";
			this.dataGrid1.DataSource = dt.DefaultView;
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(frmClientTrans));
			this.panel3 = new System.Windows.Forms.Panel();
			this.priToolBar1 = new TJSystem.UC.PriToolBar();
			this.panel2 = new System.Windows.Forms.Panel();
			this.dataGrid1 = new System.Windows.Forms.DataGrid();
			this.dataGridTableStyle1 = new System.Windows.Forms.DataGridTableStyle();
			this.forwarder_id = new System.Windows.Forms.DataGridTextBoxColumn();
			this.forwarder_type = new System.Windows.Forms.DataGridTextBoxColumn();
			this.grade_name = new System.Windows.Forms.DataGridTextBoxColumn();
			this.status_name = new System.Windows.Forms.DataGridTextBoxColumn();
			this.forwarder_name = new System.Windows.Forms.DataGridTextBoxColumn();
			this.address = new System.Windows.Forms.DataGridTextBoxColumn();
			this.Postcode = new System.Windows.Forms.DataGridTextBoxColumn();
			this.country_namecn = new System.Windows.Forms.DataGridTextBoxColumn();
			this.region_namecn = new System.Windows.Forms.DataGridTextBoxColumn();
			this.province = new System.Windows.Forms.DataGridTextBoxColumn();
			this.city = new System.Windows.Forms.DataGridTextBoxColumn();
			this.tel = new System.Windows.Forms.DataGridTextBoxColumn();
			this.fax = new System.Windows.Forms.DataGridTextBoxColumn();
			this.Email = new System.Windows.Forms.DataGridTextBoxColumn();
			this.Website = new System.Windows.Forms.DataGridTextBoxColumn();
			this.Evaluation = new System.Windows.Forms.DataGridTextBoxColumn();
			this.createBy = new System.Windows.Forms.DataGridTextBoxColumn();
			this.createon = new System.Windows.Forms.DataGridTextBoxColumn();
			this.modifyBy = new System.Windows.Forms.DataGridTextBoxColumn();
			this.modifyon = new System.Windows.Forms.DataGridTextBoxColumn();
			this.panel4 = new System.Windows.Forms.Panel();
			this.linkLabel1 = new System.Windows.Forms.LinkLabel();
			this.linkLabel2 = new System.Windows.Forms.LinkLabel();
			this.comboBox1 = new TJSystem.Classes.PriComboBox();
			this.priComboBox6 = new TJSystem.Classes.PriComboBox();
			this.priComboBox5 = new TJSystem.Classes.PriComboBox();
			this.priComboBox2 = new TJSystem.Classes.PriComboBox();
			this.priComboBox1 = new TJSystem.Classes.PriComboBox();
			this.label32 = new System.Windows.Forms.Label();
			this.txt14 = new TJSystem.Classes.PriTextBox();
			this.label31 = new System.Windows.Forms.Label();
			this.txt12 = new TJSystem.Classes.PriTextBox();
			this.label30 = new System.Windows.Forms.Label();
			this.label29 = new System.Windows.Forms.Label();
			this.txt6 = new TJSystem.Classes.PriTextBox();
			this.label28 = new System.Windows.Forms.Label();
			this.label27 = new System.Windows.Forms.Label();
			this.label21 = new System.Windows.Forms.Label();
			this.txt20 = new TJSystem.Classes.PriTextBox();
			this.label20 = new System.Windows.Forms.Label();
			this.txt18 = new TJSystem.Classes.PriTextBox();
			this.label19 = new System.Windows.Forms.Label();
			this.txt16 = new TJSystem.Classes.PriTextBox();
			this.label17 = new System.Windows.Forms.Label();
			this.label16 = new System.Windows.Forms.Label();
			this.label15 = new System.Windows.Forms.Label();
			this.label14 = new System.Windows.Forms.Label();
			this.label13 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.txt15 = new TJSystem.Classes.PriTextBox();
			this.txt7 = new TJSystem.Classes.PriTextBox();
			this.txt17 = new TJSystem.Classes.PriTextBox();
			this.txt11 = new TJSystem.Classes.PriTextBox();
			this.txt19 = new TJSystem.Classes.PriTextBox();
			this.txt5 = new TJSystem.Classes.PriTextBox();
			this.txt10 = new TJSystem.Classes.PriTextBox();
			this.txt1 = new TJSystem.Classes.PriTextBox();
			this.txt13 = new TJSystem.Classes.PriTextBox();
			this.panel1 = new System.Windows.Forms.Panel();
			this.label1 = new System.Windows.Forms.Label();
			this.panel3.SuspendLayout();
			this.panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).BeginInit();
			this.panel4.SuspendLayout();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
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
			this.panel3.TabIndex = 18;
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
			// panel2
			// 
			this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
			this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.panel2.Controls.Add(this.dataGrid1);
			this.panel2.Controls.Add(this.panel4);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel2.Location = new System.Drawing.Point(0, 56);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(792, 510);
			this.panel2.TabIndex = 17;
			// 
			// dataGrid1
			// 
			this.dataGrid1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.dataGrid1.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.dataGrid1.CaptionVisible = false;
			this.dataGrid1.DataMember = "";
			this.dataGrid1.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.dataGrid1.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.dataGrid1.Location = new System.Drawing.Point(8, 232);
			this.dataGrid1.Name = "dataGrid1";
			this.dataGrid1.ReadOnly = true;
			this.dataGrid1.Size = new System.Drawing.Size(776, 224);
			this.dataGrid1.TabIndex = 1;
			this.dataGrid1.TableStyles.AddRange(new System.Windows.Forms.DataGridTableStyle[] {
																								  this.dataGridTableStyle1});
			// 
			// dataGridTableStyle1
			// 
			this.dataGridTableStyle1.AllowSorting = false;
			this.dataGridTableStyle1.DataGrid = this.dataGrid1;
			this.dataGridTableStyle1.GridColumnStyles.AddRange(new System.Windows.Forms.DataGridColumnStyle[] {
																												  this.forwarder_id,
																												  this.forwarder_type,
																												  this.grade_name,
																												  this.status_name,
																												  this.forwarder_name,
																												  this.address,
																												  this.Postcode,
																												  this.country_namecn,
																												  this.region_namecn,
																												  this.province,
																												  this.city,
																												  this.tel,
																												  this.fax,
																												  this.Email,
																												  this.Website,
																												  this.Evaluation,
																												  this.createBy,
																												  this.createon,
																												  this.modifyBy,
																												  this.modifyon});
			this.dataGridTableStyle1.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.dataGridTableStyle1.MappingName = "basic_forwarder";
			this.dataGridTableStyle1.ReadOnly = true;
			// 
			// forwarder_id
			// 
			this.forwarder_id.Format = "";
			this.forwarder_id.FormatInfo = null;
			this.forwarder_id.HeaderText = "运输商代码";
			this.forwarder_id.MappingName = "forwarder_id";
			this.forwarder_id.NullText = "";
			this.forwarder_id.Width = 75;
			// 
			// forwarder_type
			// 
			this.forwarder_type.Format = "";
			this.forwarder_type.FormatInfo = null;
			this.forwarder_type.HeaderText = "运输商类型";
			this.forwarder_type.MappingName = "forwarder_type";
			this.forwarder_type.NullText = "";
			this.forwarder_type.Width = 75;
			// 
			// grade_name
			// 
			this.grade_name.Format = "";
			this.grade_name.FormatInfo = null;
			this.grade_name.HeaderText = "等级";
			this.grade_name.MappingName = "grade_name";
			this.grade_name.NullText = "";
			this.grade_name.Width = 75;
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
			// forwarder_name
			// 
			this.forwarder_name.Format = "";
			this.forwarder_name.FormatInfo = null;
			this.forwarder_name.HeaderText = "运输商名称";
			this.forwarder_name.MappingName = "forwarder_name";
			this.forwarder_name.NullText = "";
			this.forwarder_name.Width = 75;
			// 
			// address
			// 
			this.address.Format = "";
			this.address.FormatInfo = null;
			this.address.HeaderText = "地址";
			this.address.MappingName = "address";
			this.address.NullText = "";
			this.address.Width = 75;
			// 
			// Postcode
			// 
			this.Postcode.Format = "";
			this.Postcode.FormatInfo = null;
			this.Postcode.HeaderText = "邮政编码";
			this.Postcode.MappingName = "Postcode";
			this.Postcode.NullText = "";
			this.Postcode.Width = 75;
			// 
			// country_namecn
			// 
			this.country_namecn.Format = "";
			this.country_namecn.FormatInfo = null;
			this.country_namecn.HeaderText = "国家";
			this.country_namecn.MappingName = "country_namecn";
			this.country_namecn.NullText = "";
			this.country_namecn.Width = 75;
			// 
			// region_namecn
			// 
			this.region_namecn.Format = "";
			this.region_namecn.FormatInfo = null;
			this.region_namecn.HeaderText = "地区";
			this.region_namecn.MappingName = "region_namecn";
			this.region_namecn.NullText = "";
			this.region_namecn.Width = 75;
			// 
			// province
			// 
			this.province.Format = "";
			this.province.FormatInfo = null;
			this.province.HeaderText = "省份";
			this.province.MappingName = "province";
			this.province.NullText = "";
			this.province.Width = 75;
			// 
			// city
			// 
			this.city.Format = "";
			this.city.FormatInfo = null;
			this.city.HeaderText = "城市";
			this.city.MappingName = "city";
			this.city.NullText = "";
			this.city.Width = 75;
			// 
			// tel
			// 
			this.tel.Format = "";
			this.tel.FormatInfo = null;
			this.tel.HeaderText = "电话";
			this.tel.MappingName = "tel";
			this.tel.NullText = "";
			this.tel.Width = 75;
			// 
			// fax
			// 
			this.fax.Format = "";
			this.fax.FormatInfo = null;
			this.fax.HeaderText = "传真";
			this.fax.MappingName = "fax";
			this.fax.NullText = "";
			this.fax.Width = 75;
			// 
			// Email
			// 
			this.Email.Format = "";
			this.Email.FormatInfo = null;
			this.Email.HeaderText = "电子邮件";
			this.Email.MappingName = "Email";
			this.Email.NullText = "";
			this.Email.Width = 75;
			// 
			// Website
			// 
			this.Website.Format = "";
			this.Website.FormatInfo = null;
			this.Website.HeaderText = "网址";
			this.Website.MappingName = "Website";
			this.Website.NullText = "";
			this.Website.Width = 75;
			// 
			// Evaluation
			// 
			this.Evaluation.Format = "";
			this.Evaluation.FormatInfo = null;
			this.Evaluation.HeaderText = "评估";
			this.Evaluation.MappingName = "Evaluation";
			this.Evaluation.NullText = "";
			this.Evaluation.Width = 75;
			// 
			// createBy
			// 
			this.createBy.Format = "";
			this.createBy.FormatInfo = null;
			this.createBy.HeaderText = "创建者";
			this.createBy.MappingName = "createBy";
			this.createBy.NullText = "";
			this.createBy.Width = 75;
			// 
			// createon
			// 
			this.createon.Format = "";
			this.createon.FormatInfo = null;
			this.createon.HeaderText = "创建时间";
			this.createon.MappingName = "createon";
			this.createon.NullText = "";
			this.createon.Width = 75;
			// 
			// modifyBy
			// 
			this.modifyBy.Format = "";
			this.modifyBy.FormatInfo = null;
			this.modifyBy.HeaderText = "最后修改者";
			this.modifyBy.MappingName = "modifyBy";
			this.modifyBy.NullText = "";
			this.modifyBy.Width = 75;
			// 
			// modifyon
			// 
			this.modifyon.Format = "";
			this.modifyon.FormatInfo = null;
			this.modifyon.HeaderText = "最后修改时间";
			this.modifyon.MappingName = "modifyon";
			this.modifyon.NullText = "";
			this.modifyon.Width = 75;
			// 
			// panel4
			// 
			this.panel4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel4.BackgroundImage")));
			this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.panel4.Controls.Add(this.linkLabel1);
			this.panel4.Controls.Add(this.linkLabel2);
			this.panel4.Controls.Add(this.comboBox1);
			this.panel4.Controls.Add(this.priComboBox6);
			this.panel4.Controls.Add(this.priComboBox5);
			this.panel4.Controls.Add(this.priComboBox2);
			this.panel4.Controls.Add(this.priComboBox1);
			this.panel4.Controls.Add(this.label32);
			this.panel4.Controls.Add(this.txt14);
			this.panel4.Controls.Add(this.label31);
			this.panel4.Controls.Add(this.txt12);
			this.panel4.Controls.Add(this.label30);
			this.panel4.Controls.Add(this.label29);
			this.panel4.Controls.Add(this.txt6);
			this.panel4.Controls.Add(this.label28);
			this.panel4.Controls.Add(this.label27);
			this.panel4.Controls.Add(this.label21);
			this.panel4.Controls.Add(this.txt20);
			this.panel4.Controls.Add(this.label20);
			this.panel4.Controls.Add(this.txt18);
			this.panel4.Controls.Add(this.label19);
			this.panel4.Controls.Add(this.txt16);
			this.panel4.Controls.Add(this.label17);
			this.panel4.Controls.Add(this.label16);
			this.panel4.Controls.Add(this.label15);
			this.panel4.Controls.Add(this.label14);
			this.panel4.Controls.Add(this.label13);
			this.panel4.Controls.Add(this.label11);
			this.panel4.Controls.Add(this.label10);
			this.panel4.Controls.Add(this.label9);
			this.panel4.Controls.Add(this.label7);
			this.panel4.Controls.Add(this.label4);
			this.panel4.Controls.Add(this.label3);
			this.panel4.Controls.Add(this.txt15);
			this.panel4.Controls.Add(this.txt7);
			this.panel4.Controls.Add(this.txt17);
			this.panel4.Controls.Add(this.txt11);
			this.panel4.Controls.Add(this.txt19);
			this.panel4.Controls.Add(this.txt5);
			this.panel4.Controls.Add(this.txt10);
			this.panel4.Controls.Add(this.txt1);
			this.panel4.Controls.Add(this.txt13);
			this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel4.Location = new System.Drawing.Point(0, 0);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(788, 224);
			this.panel4.TabIndex = 0;
			// 
			// linkLabel1
			// 
			this.linkLabel1.BackColor = System.Drawing.Color.Transparent;
			this.linkLabel1.Location = new System.Drawing.Point(672, 64);
			this.linkLabel1.Name = "linkLabel1";
			this.linkLabel1.Size = new System.Drawing.Size(72, 23);
			this.linkLabel1.TabIndex = 158;
			this.linkLabel1.TabStop = true;
			this.linkLabel1.Text = "联系方式";
			this.linkLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
			// 
			// linkLabel2
			// 
			this.linkLabel2.BackColor = System.Drawing.Color.Transparent;
			this.linkLabel2.Location = new System.Drawing.Point(568, 64);
			this.linkLabel2.Name = "linkLabel2";
			this.linkLabel2.Size = new System.Drawing.Size(72, 23);
			this.linkLabel2.TabIndex = 157;
			this.linkLabel2.TabStop = true;
			this.linkLabel2.Text = "银行信息";
			this.linkLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
			// 
			// comboBox1
			// 
			this.comboBox1.BackColor = System.Drawing.Color.White;
			this.comboBox1.DataField = "forwarder_type";
			this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBox1.Location = new System.Drawing.Point(264, 16);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(112, 22);
			this.comboBox1.TabIndex = 156;
			// 
			// priComboBox6
			// 
			this.priComboBox6.BackColor = System.Drawing.Color.White;
			this.priComboBox6.DataField = "region_code";
			this.priComboBox6.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.priComboBox6.Location = new System.Drawing.Point(264, 88);
			this.priComboBox6.Name = "priComboBox6";
			this.priComboBox6.Size = new System.Drawing.Size(112, 22);
			this.priComboBox6.TabIndex = 155;
			// 
			// priComboBox5
			// 
			this.priComboBox5.BackColor = System.Drawing.Color.White;
			this.priComboBox5.DataField = "country";
			this.priComboBox5.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.priComboBox5.Location = new System.Drawing.Point(96, 88);
			this.priComboBox5.Name = "priComboBox5";
			this.priComboBox5.Size = new System.Drawing.Size(112, 22);
			this.priComboBox5.TabIndex = 154;
			// 
			// priComboBox2
			// 
			this.priComboBox2.BackColor = System.Drawing.Color.White;
			this.priComboBox2.DataField = "grade";
			this.priComboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.priComboBox2.Location = new System.Drawing.Point(440, 16);
			this.priComboBox2.Name = "priComboBox2";
			this.priComboBox2.Size = new System.Drawing.Size(112, 22);
			this.priComboBox2.TabIndex = 153;
			// 
			// priComboBox1
			// 
			this.priComboBox1.BackColor = System.Drawing.Color.White;
			this.priComboBox1.DataField = "status";
			this.priComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.priComboBox1.Location = new System.Drawing.Point(616, 16);
			this.priComboBox1.Name = "priComboBox1";
			this.priComboBox1.Size = new System.Drawing.Size(128, 22);
			this.priComboBox1.TabIndex = 152;
			// 
			// label32
			// 
			this.label32.BackColor = System.Drawing.Color.Transparent;
			this.label32.Location = new System.Drawing.Point(384, 112);
			this.label32.Name = "label32";
			this.label32.Size = new System.Drawing.Size(48, 23);
			this.label32.TabIndex = 136;
			this.label32.Text = "电邮";
			this.label32.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txt14
			// 
			this.txt14.BackColor = System.Drawing.Color.White;
			this.txt14.DataField = "Email";
			this.txt14.DataType = TJSystem.Public.DataType.String;
			this.txt14.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.txt14.Location = new System.Drawing.Point(440, 112);
			this.txt14.Name = "txt14";
			this.txt14.Size = new System.Drawing.Size(112, 23);
			this.txt14.TabIndex = 137;
			this.txt14.Text = "";
			// 
			// label31
			// 
			this.label31.BackColor = System.Drawing.Color.Transparent;
			this.label31.Location = new System.Drawing.Point(40, 112);
			this.label31.Name = "label31";
			this.label31.Size = new System.Drawing.Size(48, 23);
			this.label31.TabIndex = 134;
			this.label31.Text = "电话";
			this.label31.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txt12
			// 
			this.txt12.BackColor = System.Drawing.Color.White;
			this.txt12.DataField = "Tel";
			this.txt12.DataType = TJSystem.Public.DataType.String;
			this.txt12.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.txt12.Location = new System.Drawing.Point(96, 112);
			this.txt12.Name = "txt12";
			this.txt12.Size = new System.Drawing.Size(112, 23);
			this.txt12.TabIndex = 135;
			this.txt12.Text = "";
			// 
			// label30
			// 
			this.label30.BackColor = System.Drawing.Color.Transparent;
			this.label30.ForeColor = System.Drawing.Color.Blue;
			this.label30.Location = new System.Drawing.Point(208, 88);
			this.label30.Name = "label30";
			this.label30.Size = new System.Drawing.Size(48, 23);
			this.label30.TabIndex = 132;
			this.label30.Text = "地区";
			this.label30.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label29
			// 
			this.label29.BackColor = System.Drawing.Color.Transparent;
			this.label29.Location = new System.Drawing.Point(16, 64);
			this.label29.Name = "label29";
			this.label29.Size = new System.Drawing.Size(64, 23);
			this.label29.TabIndex = 130;
			this.label29.Text = "地址";
			this.label29.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txt6
			// 
			this.txt6.BackColor = System.Drawing.Color.White;
			this.txt6.DataField = "address";
			this.txt6.DataType = TJSystem.Public.DataType.String;
			this.txt6.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.txt6.Location = new System.Drawing.Point(96, 64);
			this.txt6.Name = "txt6";
			this.txt6.Size = new System.Drawing.Size(264, 23);
			this.txt6.TabIndex = 131;
			this.txt6.Text = "";
			// 
			// label28
			// 
			this.label28.BackColor = System.Drawing.Color.Transparent;
			this.label28.ForeColor = System.Drawing.Color.Blue;
			this.label28.Location = new System.Drawing.Point(392, 16);
			this.label28.Name = "label28";
			this.label28.Size = new System.Drawing.Size(40, 23);
			this.label28.TabIndex = 128;
			this.label28.Text = "等级";
			this.label28.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label27
			// 
			this.label27.BackColor = System.Drawing.Color.Transparent;
			this.label27.ForeColor = System.Drawing.Color.Blue;
			this.label27.Location = new System.Drawing.Point(208, 16);
			this.label27.Name = "label27";
			this.label27.Size = new System.Drawing.Size(56, 23);
			this.label27.TabIndex = 126;
			this.label27.Text = "类型";
			this.label27.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label21
			// 
			this.label21.BackColor = System.Drawing.Color.Transparent;
			this.label21.Location = new System.Drawing.Point(576, 192);
			this.label21.Name = "label21";
			this.label21.Size = new System.Drawing.Size(64, 23);
			this.label21.TabIndex = 42;
			this.label21.Text = "修改时间";
			this.label21.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txt20
			// 
			this.txt20.BackColor = System.Drawing.Color.White;
			this.txt20.DataField = "modifyon";
			this.txt20.DataType = TJSystem.Public.DataType.String;
			this.txt20.Enabled = false;
			this.txt20.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.txt20.Location = new System.Drawing.Point(640, 192);
			this.txt20.Name = "txt20";
			this.txt20.Size = new System.Drawing.Size(104, 23);
			this.txt20.TabIndex = 41;
			this.txt20.Text = "";
			// 
			// label20
			// 
			this.label20.BackColor = System.Drawing.Color.Transparent;
			this.label20.Location = new System.Drawing.Point(200, 192);
			this.label20.Name = "label20";
			this.label20.Size = new System.Drawing.Size(64, 23);
			this.label20.TabIndex = 40;
			this.label20.Text = "创建时间";
			this.label20.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txt18
			// 
			this.txt18.BackColor = System.Drawing.Color.White;
			this.txt18.DataField = "createon";
			this.txt18.DataType = TJSystem.Public.DataType.String;
			this.txt18.Enabled = false;
			this.txt18.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.txt18.Location = new System.Drawing.Point(280, 192);
			this.txt18.Name = "txt18";
			this.txt18.Size = new System.Drawing.Size(96, 23);
			this.txt18.TabIndex = 39;
			this.txt18.Text = "";
			// 
			// label19
			// 
			this.label19.BackColor = System.Drawing.Color.Transparent;
			this.label19.Location = new System.Drawing.Point(24, 136);
			this.label19.Name = "label19";
			this.label19.Size = new System.Drawing.Size(64, 23);
			this.label19.TabIndex = 36;
			this.label19.Text = "评估";
			this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txt16
			// 
			this.txt16.BackColor = System.Drawing.Color.White;
			this.txt16.DataField = "Evaluation";
			this.txt16.DataType = TJSystem.Public.DataType.String;
			this.txt16.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.txt16.Location = new System.Drawing.Point(96, 136);
			this.txt16.Multiline = true;
			this.txt16.Name = "txt16";
			this.txt16.Size = new System.Drawing.Size(648, 56);
			this.txt16.TabIndex = 114;
			this.txt16.Text = "";
			// 
			// label17
			// 
			this.label17.BackColor = System.Drawing.Color.Transparent;
			this.label17.Location = new System.Drawing.Point(392, 192);
			this.label17.Name = "label17";
			this.label17.Size = new System.Drawing.Size(80, 23);
			this.label17.TabIndex = 32;
			this.label17.Text = "最后修改者";
			this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label16
			// 
			this.label16.BackColor = System.Drawing.Color.Transparent;
			this.label16.Location = new System.Drawing.Point(560, 112);
			this.label16.Name = "label16";
			this.label16.Size = new System.Drawing.Size(48, 23);
			this.label16.TabIndex = 30;
			this.label16.Text = "网址";
			this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label15
			// 
			this.label15.BackColor = System.Drawing.Color.Transparent;
			this.label15.Location = new System.Drawing.Point(8, 192);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(80, 23);
			this.label15.TabIndex = 29;
			this.label15.Text = "创建者";
			this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label14
			// 
			this.label14.BackColor = System.Drawing.Color.Transparent;
			this.label14.Location = new System.Drawing.Point(8, 40);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(80, 23);
			this.label14.TabIndex = 28;
			this.label14.Text = "运输商名称";
			this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label13
			// 
			this.label13.BackColor = System.Drawing.Color.Transparent;
			this.label13.ForeColor = System.Drawing.Color.Blue;
			this.label13.Location = new System.Drawing.Point(8, 88);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(80, 23);
			this.label13.TabIndex = 27;
			this.label13.Text = "国家";
			this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label11
			// 
			this.label11.BackColor = System.Drawing.Color.Transparent;
			this.label11.ForeColor = System.Drawing.Color.Blue;
			this.label11.Location = new System.Drawing.Point(8, 16);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(80, 23);
			this.label11.TabIndex = 25;
			this.label11.Text = "运输商代码";
			this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label10
			// 
			this.label10.BackColor = System.Drawing.Color.Transparent;
			this.label10.Location = new System.Drawing.Point(368, 64);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(64, 23);
			this.label10.TabIndex = 24;
			this.label10.Text = "邮政编码";
			this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label9
			// 
			this.label9.BackColor = System.Drawing.Color.Transparent;
			this.label9.Location = new System.Drawing.Point(568, 88);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(40, 23);
			this.label9.TabIndex = 23;
			this.label9.Text = "城市";
			this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label7
			// 
			this.label7.BackColor = System.Drawing.Color.Transparent;
			this.label7.ForeColor = System.Drawing.Color.Blue;
			this.label7.Location = new System.Drawing.Point(568, 16);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(40, 23);
			this.label7.TabIndex = 21;
			this.label7.Text = "状态";
			this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label4
			// 
			this.label4.BackColor = System.Drawing.Color.Transparent;
			this.label4.Location = new System.Drawing.Point(384, 88);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(48, 23);
			this.label4.TabIndex = 18;
			this.label4.Text = "省/州";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label3
			// 
			this.label3.BackColor = System.Drawing.Color.Transparent;
			this.label3.Location = new System.Drawing.Point(208, 112);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(48, 23);
			this.label3.TabIndex = 17;
			this.label3.Text = "传真";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txt15
			// 
			this.txt15.BackColor = System.Drawing.Color.White;
			this.txt15.DataField = "Website";
			this.txt15.DataType = TJSystem.Public.DataType.String;
			this.txt15.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.txt15.Location = new System.Drawing.Point(616, 112);
			this.txt15.Name = "txt15";
			this.txt15.Size = new System.Drawing.Size(128, 23);
			this.txt15.TabIndex = 111;
			this.txt15.Text = "";
			// 
			// txt7
			// 
			this.txt7.BackColor = System.Drawing.Color.White;
			this.txt7.DataField = "postcode";
			this.txt7.DataType = TJSystem.Public.DataType.String;
			this.txt7.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.txt7.Location = new System.Drawing.Point(440, 64);
			this.txt7.Name = "txt7";
			this.txt7.Size = new System.Drawing.Size(112, 23);
			this.txt7.TabIndex = 106;
			this.txt7.Text = "";
			// 
			// txt17
			// 
			this.txt17.BackColor = System.Drawing.Color.White;
			this.txt17.DataField = "createBy";
			this.txt17.DataType = TJSystem.Public.DataType.String;
			this.txt17.Enabled = false;
			this.txt17.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.txt17.Location = new System.Drawing.Point(96, 192);
			this.txt17.Name = "txt17";
			this.txt17.Size = new System.Drawing.Size(96, 23);
			this.txt17.TabIndex = 12;
			this.txt17.Text = "";
			// 
			// txt11
			// 
			this.txt11.BackColor = System.Drawing.Color.White;
			this.txt11.DataField = "City";
			this.txt11.DataType = TJSystem.Public.DataType.String;
			this.txt11.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.txt11.Location = new System.Drawing.Point(616, 88);
			this.txt11.Name = "txt11";
			this.txt11.Size = new System.Drawing.Size(128, 23);
			this.txt11.TabIndex = 109;
			this.txt11.Text = "";
			// 
			// txt19
			// 
			this.txt19.BackColor = System.Drawing.Color.White;
			this.txt19.DataField = "modifyBy";
			this.txt19.DataType = TJSystem.Public.DataType.String;
			this.txt19.Enabled = false;
			this.txt19.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.txt19.Location = new System.Drawing.Point(472, 192);
			this.txt19.Name = "txt19";
			this.txt19.Size = new System.Drawing.Size(96, 23);
			this.txt19.TabIndex = 9;
			this.txt19.Text = "";
			// 
			// txt5
			// 
			this.txt5.BackColor = System.Drawing.Color.White;
			this.txt5.DataField = "forwarder_name";
			this.txt5.DataType = TJSystem.Public.DataType.String;
			this.txt5.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.txt5.Location = new System.Drawing.Point(96, 40);
			this.txt5.Name = "txt5";
			this.txt5.Size = new System.Drawing.Size(648, 23);
			this.txt5.TabIndex = 105;
			this.txt5.Text = "";
			// 
			// txt10
			// 
			this.txt10.BackColor = System.Drawing.Color.White;
			this.txt10.DataField = "province";
			this.txt10.DataType = TJSystem.Public.DataType.String;
			this.txt10.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.txt10.Location = new System.Drawing.Point(440, 88);
			this.txt10.Name = "txt10";
			this.txt10.Size = new System.Drawing.Size(112, 23);
			this.txt10.TabIndex = 108;
			this.txt10.Text = "";
			// 
			// txt1
			// 
			this.txt1.BackColor = System.Drawing.Color.White;
			this.txt1.DataField = "forwarder_id";
			this.txt1.DataType = TJSystem.Public.DataType.String;
			this.txt1.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.txt1.Location = new System.Drawing.Point(96, 16);
			this.txt1.Name = "txt1";
			this.txt1.Size = new System.Drawing.Size(88, 23);
			this.txt1.TabIndex = 103;
			this.txt1.Text = "";
			// 
			// txt13
			// 
			this.txt13.BackColor = System.Drawing.Color.White;
			this.txt13.DataField = "Fax";
			this.txt13.DataType = TJSystem.Public.DataType.String;
			this.txt13.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.txt13.Location = new System.Drawing.Point(264, 112);
			this.txt13.Name = "txt13";
			this.txt13.Size = new System.Drawing.Size(112, 23);
			this.txt13.TabIndex = 110;
			this.txt13.Text = "";
			// 
			// panel1
			// 
			this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
			this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.panel1.Controls.Add(this.label1);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(792, 56);
			this.panel1.TabIndex = 16;
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label1.Font = new System.Drawing.Font("宋体", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.label1.Location = new System.Drawing.Point(0, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(788, 52);
			this.label1.TabIndex = 1;
			this.label1.Text = "运输商管理";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// frmClientTrans
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(7, 16);
			this.BackColor = System.Drawing.SystemColors.ScrollBar;
			this.ClientSize = new System.Drawing.Size(792, 566);
			this.Controls.Add(this.panel3);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "frmClientTrans";
			this.Text = "运输商管理";
			this.panel3.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).EndInit();
			this.panel4.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion
		

		protected override void OnClosing(CancelEventArgs e)
		{			
//			if(MessageBox.Show("确定退出？（Y/N）","确认",MessageBoxButtons.YesNo,MessageBoxIcon.Information) == System.Windows.Forms.DialogResult.No)
//			{
//				e.Cancel = true;
//			}
//			else
			{
				TJSystem.Public.PublicStatic.formClose = true;
				TJSystem.Public.PublicStatic.formName = "运输商管理";
			}
			base.OnClosing (e);
		}

		private void linkLabel1_LinkClicked(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
		{
			if(this.txt1.Text.Trim().Equals(""))
			{
				MessageBox.Show("未选择运输商","Error",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
				return;
			}
			frmClientTransContact frm = new frmClientTransContact(this.txt1.Text);
			frm.ShowDialog();
		}

		private void linkLabel2_LinkClicked(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
		{
			if(this.txt1.Text.Trim().Equals(""))
			{
				MessageBox.Show("未选择运输商","Error",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
				return;
			}
			frmClientTransBank frm = new frmClientTransBank(this.txt1.Text);
			frm.ShowDialog();
		}
	}
}

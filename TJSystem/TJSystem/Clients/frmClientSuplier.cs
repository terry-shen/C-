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
	public class frmClientSuplier : System.Windows.Forms.Form
	{		
		/// <summary>
		/// 必需的设计器变量。
		/// </summary>
		private System.ComponentModel.Container components = null;		
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label1;		
		private System.Windows.Forms.Panel panel3;
		private TJSystem.UC.PriToolBar priToolBar1;		
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.DataGridTableStyle dataGridTableStyle1;
		private System.Windows.Forms.DataGrid dataGrid1;
		private System.Windows.Forms.Panel panel4;
		private System.Windows.Forms.Label label35;
		private TJSystem.Classes.PriTextBox txt20;
		private System.Windows.Forms.Label label34;
		private TJSystem.Classes.PriTextBox txt18;
		private System.Windows.Forms.Label label33;
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
		private System.Windows.Forms.Label label18;
		private System.Windows.Forms.Label label19;
		private TJSystem.Classes.PriTextBox txt21;
		private System.Windows.Forms.Label label17;
		private System.Windows.Forms.Label label16;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private TJSystem.Classes.PriTextBox txt15;
		private TJSystem.Classes.PriTextBox txt7;
		private TJSystem.Classes.PriTextBox txt17;
		private TJSystem.Classes.PriTextBox txt11;
		private TJSystem.Classes.PriTextBox txt5;
		private TJSystem.Classes.PriTextBox txt10;
		private TJSystem.Classes.PriTextBox txt1;
		private TJSystem.Classes.PriTextBox txt13;
		
		private TJSystem.Classes.PriTextBox txt25;
		private TJSystem.Classes.PriTextBox txt23;
		private TJSystem.Classes.PriTextBox txt22;
		private TJSystem.Classes.PriTextBox txt24;
		public static System.Windows.Forms.Form frmCurrent = null ;
		private TJSystem.Classes.PriComboBox comboBox1;
		private TJSystem.Classes.PriComboBox priComboBox1;
		private TJSystem.Classes.PriComboBox priComboBox2;
		private TJSystem.Classes.PriComboBox priComboBox3;
		private TJSystem.Classes.PriComboBox priComboBox4;
		private TJSystem.Classes.PriComboBox priComboBox5;
		private TJSystem.Classes.PriComboBox priComboBox6;
		private System.Windows.Forms.DataGridTextBoxColumn supplier_id;
		private System.Windows.Forms.DataGridTextBoxColumn supplier_name;
		private System.Windows.Forms.DataGridTextBoxColumn supplier_address;
		private System.Windows.Forms.DataGridTextBoxColumn supplier_postcode;
		private System.Windows.Forms.DataGridTextBoxColumn province;
		private System.Windows.Forms.DataGridTextBoxColumn city;
		private System.Windows.Forms.DataGridTextBoxColumn tel;
		private System.Windows.Forms.DataGridTextBoxColumn fax;
		private System.Windows.Forms.DataGridTextBoxColumn email;
		private System.Windows.Forms.DataGridTextBoxColumn supplier_website;
		private System.Windows.Forms.DataGridTextBoxColumn credit_rated;
		private System.Windows.Forms.DataGridTextBoxColumn minorder;
		private System.Windows.Forms.DataGridTextBoxColumn tax_no;
		private System.Windows.Forms.DataGridTextBoxColumn supplier_createby;
		private System.Windows.Forms.DataGridTextBoxColumn supplier_createon;
		private System.Windows.Forms.DataGridTextBoxColumn supplier_modifyby;
		private System.Windows.Forms.DataGridTextBoxColumn supplier_modifyon;
		private System.Windows.Forms.DataGridTextBoxColumn Evaluation;
		private System.Windows.Forms.DataGridTextBoxColumn grade_name;
		private System.Windows.Forms.DataGridTextBoxColumn status_name;
		private System.Windows.Forms.DataGridTextBoxColumn country_namecn;
		private System.Windows.Forms.DataGridTextBoxColumn region_namecn;
		private System.Windows.Forms.DataGridTextBoxColumn currency_namecn;
		private System.Windows.Forms.DataGridTextBoxColumn term_namecn;
		private string _PK = null;
		private string _table = null;
		private System.Windows.Forms.DataGridTextBoxColumn type_name;
		private System.Windows.Forms.LinkLabel linkLabel1;
		private System.Windows.Forms.LinkLabel linkLabel2;
		private System.Windows.Forms.LinkLabel linkLabel3;
		private System.Windows.Forms.LinkLabel linkLabel4;

		private string _statusType = null;

		public frmClientSuplier()
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

			InitialFormData();

			System.Text.StringBuilder sb = new System.Text.StringBuilder();
			sb.Append("select a.supplier_id,a.supplier_type,h.type_name as type_name,a.grade,b.grade_name as grade_name,a.status,c.status_name as status_name, ");
			sb.Append("a.supplier_name,a.address,a.Postcode,a.country,d.country_namecn as country_namecn,a.region_code,e.region_namecn as region_namecn, ");
			sb.Append("a.province,a.city,a.tel,a.fax,a.Email,a.Website,a.Currency,f.currency_namecn as currency_namecn, ");
			sb.Append("a.Credit_rated,a.minorder,a.Pay_term,g.term_namecn as term_namecn,a.Tax_no,a.Evaluation,a.createBy, ");
			sb.Append("a.createon,a.modifyBy,a.modifyon  ");
			sb.Append("from basic_supplier a ");
			sb.Append("left join p_enterprisetype h on a.supplier_type=h.type_code ");
			sb.Append("left join p_grade b on a.grade=b.grade_id ");
			sb.Append("left join p_status c on a.status=c.status_id and status_type=");
			sb.Append("'");
			sb.Append(this._statusType);
			sb.Append("'");
			sb.Append("left join p_country d on a.country=d.country_code ");
			sb.Append("left join p_region e on a.region_code=e.region_code ");
			sb.Append("left join p_currency f on a.currency=f.currency_code ");
			sb.Append("left join p_paymentterm g on a.Pay_term=g.term_code ");
			sb.Append("order by supplier_id");
			this.InitialGrid(sb.ToString());

			priToolBar1.setCurrentForm = this;
			_PK = "supplier_id";
			_table = "basic_supplier";
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

			sql = "select CURRENCY_CODE,CURRENCY_CODE+' '+CURRENCY_NAMECN as CURRENCY_NAMECN from p_currency order by CURRENCY_CODE";
			dt = TJSystem.Public.PublicStatic.db.GetDataTable(sql);
			dr = dt.NewRow() ;
			dr[0] = "" ;
			dr[1] = "" ;
			dt.Rows.InsertAt(dr,0) ;
			dtcpy = dt.Copy();
			this.priComboBox3.DataSource = dtcpy.DefaultView;
			this.priComboBox3.ValueMember = "CURRENCY_CODE";
			this.priComboBox3.DisplayMember = "CURRENCY_NAMECN";

			sql = "select TERM_CODE,TERM_CODE+' '+TERM_NAMECN as TERM_NAMECN from p_paymentterm order by TERM_CODE";
			dt = TJSystem.Public.PublicStatic.db.GetDataTable(sql);
			dr = dt.NewRow() ;
			dr[0] = "" ;
			dr[1] = "" ;
			dt.Rows.InsertAt(dr,0) ;
			dtcpy = dt.Copy();
			this.priComboBox4.DataSource = dtcpy.DefaultView;
			this.priComboBox4.ValueMember = "TERM_CODE";
			this.priComboBox4.DisplayMember = "TERM_NAMECN";

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

			if(this.txt17.Text.Trim().Equals(""))
			{
				sb.Append("  请输入信用额度是多少！\r\n");
				TJSystem.Public.PublicStatic.ShowMessage(TJSystem.Public.MessageType.Error, sb.ToString());
				return false;
			}
			else
			{
				if(!TJSystem.Public.PublicStatic.IsNumDouble(this.txt17.Text.Trim()))
				{
					sb.Append("  信用额度输入有误，只能是数字！\r\n");
					TJSystem.Public.PublicStatic.ShowMessage(TJSystem.Public.MessageType.Error, sb.ToString());
					return false;
				}
			}
			if(this.txt18.Text.Trim().Equals(""))
			{
				sb.Append("  请输入最低订货量是多少！\r\n");
				TJSystem.Public.PublicStatic.ShowMessage(TJSystem.Public.MessageType.Error, sb.ToString());
				return false;
			}
			else
			{
				if(!TJSystem.Public.PublicStatic.IsNumDouble(this.txt18.Text.Trim()))
				{
					sb.Append("  最低订货量输入有误，只能是数字！\r\n");
					TJSystem.Public.PublicStatic.ShowMessage(TJSystem.Public.MessageType.Error, sb.ToString());
					return false;
				}
			}

			if(sqltype.Equals("insert"))
			{
				if(txt1.Text.Length > 10)
				{
					sb.Append("  数据长度超出数据库定义要求\r\n");
					return false;
				}

				if (this.txt1.Text == "")
				{
					MessageBox.Show("请输入供应商代码","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
					return false;
				}
				
				if(TJSystem.Public.PublicStatic.IsExsist(_table,_PK,this.priToolBar1))
				{
					MessageBox.Show("这个供应商信息已经存在,请另外开立","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
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
			
			this.txt17.Enabled = false;
			this.txt18.Enabled = false;
			
			this.txt20.Enabled = false;
			this.txt21.Enabled = false;
			this.txt22.Enabled = false;
			this.txt23.Enabled = false;
			this.txt24.Enabled = false;
			this.txt25.Enabled = false;
			this.comboBox1.Enabled = false;
			this.priComboBox1.Enabled = false;
			this.priComboBox2.Enabled = false;
			this.priComboBox3.Enabled = false;
			this.priComboBox4.Enabled = false;
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
				
				this.txt17.Enabled = true;
				this.txt18.Enabled = true;
				
				this.txt20.Enabled = true;
				this.txt21.Enabled = true;
				
				this.comboBox1.Enabled = true;
				this.priComboBox1.Enabled = true;
				this.priComboBox2.Enabled = true;
				this.priComboBox3.Enabled = true;
				this.priComboBox4.Enabled = true;
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
				
				this.txt17.Text = "";
				this.txt18.Text = "";
				
				this.txt20.Text = "";
				this.txt21.Text = "";
				


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
				
				this.txt17.Enabled = true;
				this.txt18.Enabled = true;
				
				this.txt20.Enabled = true;
				this.txt21.Enabled = true;
				
				this.comboBox1.Enabled = true;
				this.priComboBox1.Enabled = true;
				this.priComboBox2.Enabled = true;
				this.priComboBox3.Enabled = true;
				this.priComboBox4.Enabled = true;
				this.priComboBox5.Enabled = true;
				this.priComboBox6.Enabled = true;


			}
		}

		private void InitialGrid(string sql)
		{		
			DataTable dt = TJSystem.Public.PublicStatic.db.GetDataTable(sql);
			dt.TableName = "basic_supplier";
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(frmClientSuplier));
			this.panel1 = new System.Windows.Forms.Panel();
			this.label1 = new System.Windows.Forms.Label();
			this.panel3 = new System.Windows.Forms.Panel();
			this.priToolBar1 = new TJSystem.UC.PriToolBar();
			this.panel2 = new System.Windows.Forms.Panel();
			this.dataGrid1 = new System.Windows.Forms.DataGrid();
			this.dataGridTableStyle1 = new System.Windows.Forms.DataGridTableStyle();
			this.supplier_id = new System.Windows.Forms.DataGridTextBoxColumn();
			this.type_name = new System.Windows.Forms.DataGridTextBoxColumn();
			this.grade_name = new System.Windows.Forms.DataGridTextBoxColumn();
			this.status_name = new System.Windows.Forms.DataGridTextBoxColumn();
			this.supplier_name = new System.Windows.Forms.DataGridTextBoxColumn();
			this.supplier_address = new System.Windows.Forms.DataGridTextBoxColumn();
			this.supplier_postcode = new System.Windows.Forms.DataGridTextBoxColumn();
			this.country_namecn = new System.Windows.Forms.DataGridTextBoxColumn();
			this.region_namecn = new System.Windows.Forms.DataGridTextBoxColumn();
			this.province = new System.Windows.Forms.DataGridTextBoxColumn();
			this.city = new System.Windows.Forms.DataGridTextBoxColumn();
			this.tel = new System.Windows.Forms.DataGridTextBoxColumn();
			this.fax = new System.Windows.Forms.DataGridTextBoxColumn();
			this.email = new System.Windows.Forms.DataGridTextBoxColumn();
			this.supplier_website = new System.Windows.Forms.DataGridTextBoxColumn();
			this.currency_namecn = new System.Windows.Forms.DataGridTextBoxColumn();
			this.credit_rated = new System.Windows.Forms.DataGridTextBoxColumn();
			this.minorder = new System.Windows.Forms.DataGridTextBoxColumn();
			this.term_namecn = new System.Windows.Forms.DataGridTextBoxColumn();
			this.tax_no = new System.Windows.Forms.DataGridTextBoxColumn();
			this.Evaluation = new System.Windows.Forms.DataGridTextBoxColumn();
			this.supplier_createby = new System.Windows.Forms.DataGridTextBoxColumn();
			this.supplier_createon = new System.Windows.Forms.DataGridTextBoxColumn();
			this.supplier_modifyby = new System.Windows.Forms.DataGridTextBoxColumn();
			this.supplier_modifyon = new System.Windows.Forms.DataGridTextBoxColumn();
			this.panel4 = new System.Windows.Forms.Panel();
			this.linkLabel4 = new System.Windows.Forms.LinkLabel();
			this.linkLabel3 = new System.Windows.Forms.LinkLabel();
			this.linkLabel2 = new System.Windows.Forms.LinkLabel();
			this.linkLabel1 = new System.Windows.Forms.LinkLabel();
			this.priComboBox6 = new TJSystem.Classes.PriComboBox();
			this.priComboBox5 = new TJSystem.Classes.PriComboBox();
			this.priComboBox4 = new TJSystem.Classes.PriComboBox();
			this.priComboBox3 = new TJSystem.Classes.PriComboBox();
			this.priComboBox2 = new TJSystem.Classes.PriComboBox();
			this.priComboBox1 = new TJSystem.Classes.PriComboBox();
			this.comboBox1 = new TJSystem.Classes.PriComboBox();
			this.label35 = new System.Windows.Forms.Label();
			this.txt20 = new TJSystem.Classes.PriTextBox();
			this.label34 = new System.Windows.Forms.Label();
			this.txt18 = new TJSystem.Classes.PriTextBox();
			this.label33 = new System.Windows.Forms.Label();
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
			this.txt25 = new TJSystem.Classes.PriTextBox();
			this.label20 = new System.Windows.Forms.Label();
			this.txt23 = new TJSystem.Classes.PriTextBox();
			this.label18 = new System.Windows.Forms.Label();
			this.label19 = new System.Windows.Forms.Label();
			this.txt21 = new TJSystem.Classes.PriTextBox();
			this.label17 = new System.Windows.Forms.Label();
			this.label16 = new System.Windows.Forms.Label();
			this.label15 = new System.Windows.Forms.Label();
			this.label14 = new System.Windows.Forms.Label();
			this.label13 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.txt15 = new TJSystem.Classes.PriTextBox();
			this.txt7 = new TJSystem.Classes.PriTextBox();
			this.txt22 = new TJSystem.Classes.PriTextBox();
			this.txt17 = new TJSystem.Classes.PriTextBox();
			this.txt11 = new TJSystem.Classes.PriTextBox();
			this.txt24 = new TJSystem.Classes.PriTextBox();
			this.txt5 = new TJSystem.Classes.PriTextBox();
			this.txt10 = new TJSystem.Classes.PriTextBox();
			this.txt1 = new TJSystem.Classes.PriTextBox();
			this.txt13 = new TJSystem.Classes.PriTextBox();
			this.panel1.SuspendLayout();
			this.panel3.SuspendLayout();
			this.panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).BeginInit();
			this.panel4.SuspendLayout();
			this.SuspendLayout();
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
			this.panel1.TabIndex = 13;
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
			this.label1.Text = "供应商管理";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
			this.panel3.TabIndex = 15;
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
			this.panel2.Location = new System.Drawing.Point(0, 0);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(792, 566);
			this.panel2.TabIndex = 14;
			// 
			// dataGrid1
			// 
			this.dataGrid1.AllowSorting = false;
			this.dataGrid1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.dataGrid1.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.dataGrid1.CaptionVisible = false;
			this.dataGrid1.DataMember = "";
			this.dataGrid1.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.dataGrid1.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.dataGrid1.Location = new System.Drawing.Point(8, 328);
			this.dataGrid1.Name = "dataGrid1";
			this.dataGrid1.ReadOnly = true;
			this.dataGrid1.Size = new System.Drawing.Size(776, 184);
			this.dataGrid1.TabIndex = 1;
			this.dataGrid1.TableStyles.AddRange(new System.Windows.Forms.DataGridTableStyle[] {
																								  this.dataGridTableStyle1});
			// 
			// dataGridTableStyle1
			// 
			this.dataGridTableStyle1.AllowSorting = false;
			this.dataGridTableStyle1.DataGrid = this.dataGrid1;
			this.dataGridTableStyle1.GridColumnStyles.AddRange(new System.Windows.Forms.DataGridColumnStyle[] {
																												  this.supplier_id,
																												  this.type_name,
																												  this.grade_name,
																												  this.status_name,
																												  this.supplier_name,
																												  this.supplier_address,
																												  this.supplier_postcode,
																												  this.country_namecn,
																												  this.region_namecn,
																												  this.province,
																												  this.city,
																												  this.tel,
																												  this.fax,
																												  this.email,
																												  this.supplier_website,
																												  this.currency_namecn,
																												  this.credit_rated,
																												  this.minorder,
																												  this.term_namecn,
																												  this.tax_no,
																												  this.Evaluation,
																												  this.supplier_createby,
																												  this.supplier_createon,
																												  this.supplier_modifyby,
																												  this.supplier_modifyon});
			this.dataGridTableStyle1.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.dataGridTableStyle1.MappingName = "basic_supplier";
			this.dataGridTableStyle1.ReadOnly = true;
			// 
			// supplier_id
			// 
			this.supplier_id.Format = "";
			this.supplier_id.FormatInfo = null;
			this.supplier_id.HeaderText = "供应商编号";
			this.supplier_id.MappingName = "supplier_id";
			this.supplier_id.Width = 75;
			// 
			// type_name
			// 
			this.type_name.Format = "";
			this.type_name.FormatInfo = null;
			this.type_name.HeaderText = "供应商类型";
			this.type_name.MappingName = "type_name";
			this.type_name.Width = 75;
			// 
			// grade_name
			// 
			this.grade_name.Format = "";
			this.grade_name.FormatInfo = null;
			this.grade_name.HeaderText = "供应商等级";
			this.grade_name.MappingName = "grade_name";
			this.grade_name.Width = 75;
			// 
			// status_name
			// 
			this.status_name.Format = "";
			this.status_name.FormatInfo = null;
			this.status_name.HeaderText = "状态";
			this.status_name.MappingName = "status_name";
			this.status_name.Width = 75;
			// 
			// supplier_name
			// 
			this.supplier_name.Format = "";
			this.supplier_name.FormatInfo = null;
			this.supplier_name.HeaderText = "供应商名称";
			this.supplier_name.MappingName = "supplier_name";
			this.supplier_name.Width = 75;
			// 
			// supplier_address
			// 
			this.supplier_address.Format = "";
			this.supplier_address.FormatInfo = null;
			this.supplier_address.HeaderText = "地址";
			this.supplier_address.MappingName = "address";
			this.supplier_address.Width = 75;
			// 
			// supplier_postcode
			// 
			this.supplier_postcode.Format = "";
			this.supplier_postcode.FormatInfo = null;
			this.supplier_postcode.HeaderText = "邮政编码";
			this.supplier_postcode.MappingName = "postcode";
			this.supplier_postcode.Width = 75;
			// 
			// country_namecn
			// 
			this.country_namecn.Format = "";
			this.country_namecn.FormatInfo = null;
			this.country_namecn.HeaderText = "国家";
			this.country_namecn.MappingName = "country_namecn";
			this.country_namecn.Width = 75;
			// 
			// region_namecn
			// 
			this.region_namecn.Format = "";
			this.region_namecn.FormatInfo = null;
			this.region_namecn.HeaderText = "地区";
			this.region_namecn.MappingName = "region_namecn";
			this.region_namecn.Width = 75;
			// 
			// province
			// 
			this.province.Format = "";
			this.province.FormatInfo = null;
			this.province.HeaderText = "省份";
			this.province.MappingName = "province";
			this.province.Width = 75;
			// 
			// city
			// 
			this.city.Format = "";
			this.city.FormatInfo = null;
			this.city.HeaderText = "城市";
			this.city.MappingName = "city";
			this.city.Width = 75;
			// 
			// tel
			// 
			this.tel.Format = "";
			this.tel.FormatInfo = null;
			this.tel.HeaderText = "电话";
			this.tel.MappingName = "tel";
			this.tel.Width = 75;
			// 
			// fax
			// 
			this.fax.Format = "";
			this.fax.FormatInfo = null;
			this.fax.HeaderText = "传真";
			this.fax.MappingName = "fax";
			this.fax.Width = 75;
			// 
			// email
			// 
			this.email.Format = "";
			this.email.FormatInfo = null;
			this.email.HeaderText = "电子邮件";
			this.email.MappingName = "email";
			this.email.Width = 75;
			// 
			// supplier_website
			// 
			this.supplier_website.Format = "";
			this.supplier_website.FormatInfo = null;
			this.supplier_website.HeaderText = "网址";
			this.supplier_website.MappingName = "website";
			this.supplier_website.Width = 75;
			// 
			// currency_namecn
			// 
			this.currency_namecn.Format = "";
			this.currency_namecn.FormatInfo = null;
			this.currency_namecn.HeaderText = "币种";
			this.currency_namecn.MappingName = "currency_namecn";
			this.currency_namecn.Width = 75;
			// 
			// credit_rated
			// 
			this.credit_rated.Format = "";
			this.credit_rated.FormatInfo = null;
			this.credit_rated.HeaderText = "信用额度";
			this.credit_rated.MappingName = "credit_rated";
			this.credit_rated.Width = 75;
			// 
			// minorder
			// 
			this.minorder.Format = "";
			this.minorder.FormatInfo = null;
			this.minorder.HeaderText = "最低订货量";
			this.minorder.MappingName = "minorder";
			this.minorder.Width = 75;
			// 
			// term_namecn
			// 
			this.term_namecn.Format = "";
			this.term_namecn.FormatInfo = null;
			this.term_namecn.HeaderText = "付款条款";
			this.term_namecn.MappingName = "term_namecn";
			this.term_namecn.Width = 75;
			// 
			// tax_no
			// 
			this.tax_no.Format = "";
			this.tax_no.FormatInfo = null;
			this.tax_no.HeaderText = "税号";
			this.tax_no.MappingName = "tax_no";
			this.tax_no.Width = 75;
			// 
			// Evaluation
			// 
			this.Evaluation.Format = "";
			this.Evaluation.FormatInfo = null;
			this.Evaluation.HeaderText = "评估";
			this.Evaluation.MappingName = "Evaluation";
			this.Evaluation.Width = 75;
			// 
			// supplier_createby
			// 
			this.supplier_createby.Format = "";
			this.supplier_createby.FormatInfo = null;
			this.supplier_createby.HeaderText = "建立人";
			this.supplier_createby.MappingName = "createby";
			this.supplier_createby.Width = 75;
			// 
			// supplier_createon
			// 
			this.supplier_createon.Format = "";
			this.supplier_createon.FormatInfo = null;
			this.supplier_createon.HeaderText = "建立时间";
			this.supplier_createon.MappingName = "createon";
			this.supplier_createon.Width = 75;
			// 
			// supplier_modifyby
			// 
			this.supplier_modifyby.Format = "";
			this.supplier_modifyby.FormatInfo = null;
			this.supplier_modifyby.HeaderText = "最后修改人";
			this.supplier_modifyby.MappingName = "modifyby";
			this.supplier_modifyby.Width = 75;
			// 
			// supplier_modifyon
			// 
			this.supplier_modifyon.Format = "";
			this.supplier_modifyon.FormatInfo = null;
			this.supplier_modifyon.HeaderText = "最后修改日期";
			this.supplier_modifyon.MappingName = "modifyon";
			this.supplier_modifyon.Width = 75;
			// 
			// panel4
			// 
			this.panel4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel4.BackgroundImage")));
			this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.panel4.Controls.Add(this.linkLabel4);
			this.panel4.Controls.Add(this.linkLabel3);
			this.panel4.Controls.Add(this.linkLabel2);
			this.panel4.Controls.Add(this.linkLabel1);
			this.panel4.Controls.Add(this.priComboBox6);
			this.panel4.Controls.Add(this.priComboBox5);
			this.panel4.Controls.Add(this.priComboBox4);
			this.panel4.Controls.Add(this.priComboBox3);
			this.panel4.Controls.Add(this.priComboBox2);
			this.panel4.Controls.Add(this.priComboBox1);
			this.panel4.Controls.Add(this.comboBox1);
			this.panel4.Controls.Add(this.label35);
			this.panel4.Controls.Add(this.txt20);
			this.panel4.Controls.Add(this.label34);
			this.panel4.Controls.Add(this.txt18);
			this.panel4.Controls.Add(this.label33);
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
			this.panel4.Controls.Add(this.txt25);
			this.panel4.Controls.Add(this.label20);
			this.panel4.Controls.Add(this.txt23);
			this.panel4.Controls.Add(this.label18);
			this.panel4.Controls.Add(this.label19);
			this.panel4.Controls.Add(this.txt21);
			this.panel4.Controls.Add(this.label17);
			this.panel4.Controls.Add(this.label16);
			this.panel4.Controls.Add(this.label15);
			this.panel4.Controls.Add(this.label14);
			this.panel4.Controls.Add(this.label13);
			this.panel4.Controls.Add(this.label11);
			this.panel4.Controls.Add(this.label10);
			this.panel4.Controls.Add(this.label9);
			this.panel4.Controls.Add(this.label7);
			this.panel4.Controls.Add(this.label5);
			this.panel4.Controls.Add(this.label4);
			this.panel4.Controls.Add(this.label3);
			this.panel4.Controls.Add(this.txt15);
			this.panel4.Controls.Add(this.txt7);
			this.panel4.Controls.Add(this.txt22);
			this.panel4.Controls.Add(this.txt17);
			this.panel4.Controls.Add(this.txt11);
			this.panel4.Controls.Add(this.txt24);
			this.panel4.Controls.Add(this.txt5);
			this.panel4.Controls.Add(this.txt10);
			this.panel4.Controls.Add(this.txt1);
			this.panel4.Controls.Add(this.txt13);
			this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel4.Location = new System.Drawing.Point(0, 0);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(788, 328);
			this.panel4.TabIndex = 0;
			// 
			// linkLabel4
			// 
			this.linkLabel4.BackColor = System.Drawing.Color.Transparent;
			this.linkLabel4.Location = new System.Drawing.Point(656, 80);
			this.linkLabel4.Name = "linkLabel4";
			this.linkLabel4.Size = new System.Drawing.Size(64, 23);
			this.linkLabel4.TabIndex = 154;
			this.linkLabel4.TabStop = true;
			this.linkLabel4.Text = "货品细项";
			this.linkLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.linkLabel4.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel4_LinkClicked);
			// 
			// linkLabel3
			// 
			this.linkLabel3.BackColor = System.Drawing.Color.Transparent;
			this.linkLabel3.Location = new System.Drawing.Point(584, 80);
			this.linkLabel3.Name = "linkLabel3";
			this.linkLabel3.Size = new System.Drawing.Size(64, 23);
			this.linkLabel3.TabIndex = 153;
			this.linkLabel3.TabStop = true;
			this.linkLabel3.Text = "货品分类";
			this.linkLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.linkLabel3.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel3_LinkClicked);
			// 
			// linkLabel2
			// 
			this.linkLabel2.BackColor = System.Drawing.Color.Transparent;
			this.linkLabel2.Location = new System.Drawing.Point(512, 80);
			this.linkLabel2.Name = "linkLabel2";
			this.linkLabel2.Size = new System.Drawing.Size(64, 23);
			this.linkLabel2.TabIndex = 152;
			this.linkLabel2.TabStop = true;
			this.linkLabel2.Text = "联系方式";
			this.linkLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
			// 
			// linkLabel1
			// 
			this.linkLabel1.BackColor = System.Drawing.Color.Transparent;
			this.linkLabel1.Location = new System.Drawing.Point(408, 80);
			this.linkLabel1.Name = "linkLabel1";
			this.linkLabel1.Size = new System.Drawing.Size(96, 23);
			this.linkLabel1.TabIndex = 151;
			this.linkLabel1.TabStop = true;
			this.linkLabel1.Text = "银行信息";
			this.linkLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
			// 
			// priComboBox6
			// 
			this.priComboBox6.BackColor = System.Drawing.Color.White;
			this.priComboBox6.DataField = "region_code";
			this.priComboBox6.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.priComboBox6.Location = new System.Drawing.Point(264, 128);
			this.priComboBox6.Name = "priComboBox6";
			this.priComboBox6.Size = new System.Drawing.Size(112, 22);
			this.priComboBox6.TabIndex = 150;
			// 
			// priComboBox5
			// 
			this.priComboBox5.BackColor = System.Drawing.Color.White;
			this.priComboBox5.DataField = "country";
			this.priComboBox5.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.priComboBox5.Location = new System.Drawing.Point(96, 128);
			this.priComboBox5.Name = "priComboBox5";
			this.priComboBox5.Size = new System.Drawing.Size(112, 22);
			this.priComboBox5.TabIndex = 149;
			// 
			// priComboBox4
			// 
			this.priComboBox4.BackColor = System.Drawing.Color.White;
			this.priComboBox4.DataField = "Pay_term";
			this.priComboBox4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.priComboBox4.Location = new System.Drawing.Point(624, 176);
			this.priComboBox4.Name = "priComboBox4";
			this.priComboBox4.Size = new System.Drawing.Size(112, 22);
			this.priComboBox4.TabIndex = 148;
			// 
			// priComboBox3
			// 
			this.priComboBox3.BackColor = System.Drawing.Color.White;
			this.priComboBox3.DataField = "Currency";
			this.priComboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.priComboBox3.Location = new System.Drawing.Point(96, 176);
			this.priComboBox3.Name = "priComboBox3";
			this.priComboBox3.Size = new System.Drawing.Size(112, 22);
			this.priComboBox3.TabIndex = 147;
			// 
			// priComboBox2
			// 
			this.priComboBox2.BackColor = System.Drawing.Color.White;
			this.priComboBox2.DataField = "grade";
			this.priComboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.priComboBox2.Location = new System.Drawing.Point(440, 56);
			this.priComboBox2.Name = "priComboBox2";
			this.priComboBox2.Size = new System.Drawing.Size(112, 22);
			this.priComboBox2.TabIndex = 146;
			// 
			// priComboBox1
			// 
			this.priComboBox1.BackColor = System.Drawing.Color.White;
			this.priComboBox1.DataField = "status";
			this.priComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.priComboBox1.Location = new System.Drawing.Point(616, 56);
			this.priComboBox1.Name = "priComboBox1";
			this.priComboBox1.Size = new System.Drawing.Size(128, 22);
			this.priComboBox1.TabIndex = 145;
			// 
			// comboBox1
			// 
			this.comboBox1.BackColor = System.Drawing.Color.White;
			this.comboBox1.DataField = "supplier_type";
			this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBox1.Location = new System.Drawing.Point(272, 56);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(104, 22);
			this.comboBox1.TabIndex = 144;
			// 
			// label35
			// 
			this.label35.BackColor = System.Drawing.Color.Transparent;
			this.label35.Location = new System.Drawing.Point(24, 200);
			this.label35.Name = "label35";
			this.label35.Size = new System.Drawing.Size(64, 23);
			this.label35.TabIndex = 142;
			this.label35.Text = "税号";
			this.label35.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txt20
			// 
			this.txt20.BackColor = System.Drawing.Color.White;
			this.txt20.DataField = "Tax_no";
			this.txt20.DataType = TJSystem.Public.DataType.String;
			this.txt20.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.txt20.Location = new System.Drawing.Point(96, 200);
			this.txt20.Name = "txt20";
			this.txt20.Size = new System.Drawing.Size(648, 23);
			this.txt20.TabIndex = 143;
			this.txt20.Text = "";
			// 
			// label34
			// 
			this.label34.BackColor = System.Drawing.Color.Transparent;
			this.label34.ForeColor = System.Drawing.Color.Blue;
			this.label34.Location = new System.Drawing.Point(384, 176);
			this.label34.Name = "label34";
			this.label34.Size = new System.Drawing.Size(80, 23);
			this.label34.TabIndex = 140;
			this.label34.Text = "最低订货量";
			this.label34.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txt18
			// 
			this.txt18.BackColor = System.Drawing.Color.White;
			this.txt18.DataField = "minorder";
			this.txt18.DataType = TJSystem.Public.DataType.String;
			this.txt18.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.txt18.Location = new System.Drawing.Point(472, 176);
			this.txt18.Name = "txt18";
			this.txt18.Size = new System.Drawing.Size(88, 23);
			this.txt18.TabIndex = 141;
			this.txt18.Text = "";
			// 
			// label33
			// 
			this.label33.BackColor = System.Drawing.Color.Transparent;
			this.label33.ForeColor = System.Drawing.Color.Blue;
			this.label33.Location = new System.Drawing.Point(48, 176);
			this.label33.Name = "label33";
			this.label33.Size = new System.Drawing.Size(40, 23);
			this.label33.TabIndex = 138;
			this.label33.Text = "币种";
			this.label33.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label32
			// 
			this.label32.BackColor = System.Drawing.Color.Transparent;
			this.label32.Location = new System.Drawing.Point(376, 152);
			this.label32.Name = "label32";
			this.label32.Size = new System.Drawing.Size(64, 23);
			this.label32.TabIndex = 136;
			this.label32.Text = "电子邮件";
			this.label32.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txt14
			// 
			this.txt14.BackColor = System.Drawing.Color.White;
			this.txt14.DataField = "Email";
			this.txt14.DataType = TJSystem.Public.DataType.String;
			this.txt14.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.txt14.Location = new System.Drawing.Point(440, 152);
			this.txt14.Name = "txt14";
			this.txt14.Size = new System.Drawing.Size(112, 23);
			this.txt14.TabIndex = 137;
			this.txt14.Text = "";
			// 
			// label31
			// 
			this.label31.BackColor = System.Drawing.Color.Transparent;
			this.label31.Location = new System.Drawing.Point(40, 152);
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
			this.txt12.Location = new System.Drawing.Point(96, 152);
			this.txt12.Name = "txt12";
			this.txt12.Size = new System.Drawing.Size(112, 23);
			this.txt12.TabIndex = 135;
			this.txt12.Text = "";
			// 
			// label30
			// 
			this.label30.BackColor = System.Drawing.Color.Transparent;
			this.label30.ForeColor = System.Drawing.Color.Blue;
			this.label30.Location = new System.Drawing.Point(208, 128);
			this.label30.Name = "label30";
			this.label30.Size = new System.Drawing.Size(48, 23);
			this.label30.TabIndex = 132;
			this.label30.Text = "地区";
			this.label30.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label29
			// 
			this.label29.BackColor = System.Drawing.Color.Transparent;
			this.label29.Location = new System.Drawing.Point(16, 104);
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
			this.txt6.Location = new System.Drawing.Point(96, 104);
			this.txt6.Name = "txt6";
			this.txt6.Size = new System.Drawing.Size(264, 23);
			this.txt6.TabIndex = 131;
			this.txt6.Text = "";
			// 
			// label28
			// 
			this.label28.BackColor = System.Drawing.Color.Transparent;
			this.label28.ForeColor = System.Drawing.Color.Blue;
			this.label28.Location = new System.Drawing.Point(392, 56);
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
			this.label27.Location = new System.Drawing.Point(200, 56);
			this.label27.Name = "label27";
			this.label27.Size = new System.Drawing.Size(64, 23);
			this.label27.TabIndex = 126;
			this.label27.Text = "类型";
			this.label27.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label21
			// 
			this.label21.BackColor = System.Drawing.Color.Transparent;
			this.label21.Location = new System.Drawing.Point(576, 296);
			this.label21.Name = "label21";
			this.label21.Size = new System.Drawing.Size(64, 23);
			this.label21.TabIndex = 42;
			this.label21.Text = "修改时间";
			this.label21.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txt25
			// 
			this.txt25.BackColor = System.Drawing.Color.White;
			this.txt25.DataField = "modifyon";
			this.txt25.DataType = TJSystem.Public.DataType.String;
			this.txt25.Enabled = false;
			this.txt25.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.txt25.Location = new System.Drawing.Point(640, 296);
			this.txt25.Name = "txt25";
			this.txt25.Size = new System.Drawing.Size(104, 23);
			this.txt25.TabIndex = 41;
			this.txt25.Text = "";
			// 
			// label20
			// 
			this.label20.BackColor = System.Drawing.Color.Transparent;
			this.label20.Location = new System.Drawing.Point(200, 296);
			this.label20.Name = "label20";
			this.label20.Size = new System.Drawing.Size(64, 23);
			this.label20.TabIndex = 40;
			this.label20.Text = "创建时间";
			this.label20.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txt23
			// 
			this.txt23.BackColor = System.Drawing.Color.White;
			this.txt23.DataField = "createon";
			this.txt23.DataType = TJSystem.Public.DataType.String;
			this.txt23.Enabled = false;
			this.txt23.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.txt23.Location = new System.Drawing.Point(280, 296);
			this.txt23.Name = "txt23";
			this.txt23.Size = new System.Drawing.Size(96, 23);
			this.txt23.TabIndex = 39;
			this.txt23.Text = "";
			// 
			// label18
			// 
			this.label18.BackColor = System.Drawing.Color.Transparent;
			this.label18.ForeColor = System.Drawing.Color.Blue;
			this.label18.Location = new System.Drawing.Point(560, 176);
			this.label18.Name = "label18";
			this.label18.Size = new System.Drawing.Size(64, 23);
			this.label18.TabIndex = 37;
			this.label18.Text = "付款条款";
			this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label19
			// 
			this.label19.BackColor = System.Drawing.Color.Transparent;
			this.label19.Location = new System.Drawing.Point(24, 224);
			this.label19.Name = "label19";
			this.label19.Size = new System.Drawing.Size(64, 23);
			this.label19.TabIndex = 36;
			this.label19.Text = "评估";
			this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txt21
			// 
			this.txt21.BackColor = System.Drawing.Color.White;
			this.txt21.DataField = "Evaluation";
			this.txt21.DataType = TJSystem.Public.DataType.String;
			this.txt21.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.txt21.Location = new System.Drawing.Point(96, 224);
			this.txt21.Multiline = true;
			this.txt21.Name = "txt21";
			this.txt21.Size = new System.Drawing.Size(648, 56);
			this.txt21.TabIndex = 114;
			this.txt21.Text = "";
			// 
			// label17
			// 
			this.label17.BackColor = System.Drawing.Color.Transparent;
			this.label17.Location = new System.Drawing.Point(392, 296);
			this.label17.Name = "label17";
			this.label17.Size = new System.Drawing.Size(80, 23);
			this.label17.TabIndex = 32;
			this.label17.Text = "最后修改者";
			this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label16
			// 
			this.label16.BackColor = System.Drawing.Color.Transparent;
			this.label16.Location = new System.Drawing.Point(560, 152);
			this.label16.Name = "label16";
			this.label16.Size = new System.Drawing.Size(48, 23);
			this.label16.TabIndex = 30;
			this.label16.Text = "网址";
			this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label15
			// 
			this.label15.BackColor = System.Drawing.Color.Transparent;
			this.label15.Location = new System.Drawing.Point(8, 296);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(80, 23);
			this.label15.TabIndex = 29;
			this.label15.Text = "创建者";
			this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label14
			// 
			this.label14.BackColor = System.Drawing.Color.Transparent;
			this.label14.Location = new System.Drawing.Point(8, 80);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(80, 23);
			this.label14.TabIndex = 28;
			this.label14.Text = "供应商名称";
			this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label13
			// 
			this.label13.BackColor = System.Drawing.Color.Transparent;
			this.label13.ForeColor = System.Drawing.Color.Blue;
			this.label13.Location = new System.Drawing.Point(8, 128);
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
			this.label11.Location = new System.Drawing.Point(8, 56);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(80, 23);
			this.label11.TabIndex = 25;
			this.label11.Text = "供应商代码";
			this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label10
			// 
			this.label10.BackColor = System.Drawing.Color.Transparent;
			this.label10.Location = new System.Drawing.Point(368, 104);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(64, 23);
			this.label10.TabIndex = 24;
			this.label10.Text = "邮政编码";
			this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label9
			// 
			this.label9.BackColor = System.Drawing.Color.Transparent;
			this.label9.Location = new System.Drawing.Point(568, 128);
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
			this.label7.Location = new System.Drawing.Point(568, 56);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(40, 23);
			this.label7.TabIndex = 21;
			this.label7.Text = "状态";
			this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label5
			// 
			this.label5.BackColor = System.Drawing.Color.Transparent;
			this.label5.ForeColor = System.Drawing.Color.Blue;
			this.label5.Location = new System.Drawing.Point(192, 176);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(80, 23);
			this.label5.TabIndex = 19;
			this.label5.Text = "信用额度";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label4
			// 
			this.label4.BackColor = System.Drawing.Color.Transparent;
			this.label4.ForeColor = System.Drawing.Color.Blue;
			this.label4.Location = new System.Drawing.Point(384, 128);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(48, 23);
			this.label4.TabIndex = 18;
			this.label4.Text = "省/州";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label3
			// 
			this.label3.BackColor = System.Drawing.Color.Transparent;
			this.label3.Location = new System.Drawing.Point(208, 152);
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
			this.txt15.Location = new System.Drawing.Point(616, 152);
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
			this.txt7.Location = new System.Drawing.Point(440, 104);
			this.txt7.Name = "txt7";
			this.txt7.Size = new System.Drawing.Size(192, 23);
			this.txt7.TabIndex = 106;
			this.txt7.Text = "";
			// 
			// txt22
			// 
			this.txt22.BackColor = System.Drawing.Color.White;
			this.txt22.DataField = "createBy";
			this.txt22.DataType = TJSystem.Public.DataType.String;
			this.txt22.Enabled = false;
			this.txt22.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.txt22.Location = new System.Drawing.Point(96, 296);
			this.txt22.Name = "txt22";
			this.txt22.Size = new System.Drawing.Size(96, 23);
			this.txt22.TabIndex = 12;
			this.txt22.Text = "";
			// 
			// txt17
			// 
			this.txt17.BackColor = System.Drawing.Color.White;
			this.txt17.DataField = "Credit_Rated";
			this.txt17.DataType = TJSystem.Public.DataType.String;
			this.txt17.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.txt17.Location = new System.Drawing.Point(280, 176);
			this.txt17.Name = "txt17";
			this.txt17.Size = new System.Drawing.Size(96, 23);
			this.txt17.TabIndex = 112;
			this.txt17.Text = "";
			// 
			// txt11
			// 
			this.txt11.BackColor = System.Drawing.Color.White;
			this.txt11.DataField = "City";
			this.txt11.DataType = TJSystem.Public.DataType.String;
			this.txt11.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.txt11.Location = new System.Drawing.Point(616, 128);
			this.txt11.Name = "txt11";
			this.txt11.Size = new System.Drawing.Size(128, 23);
			this.txt11.TabIndex = 109;
			this.txt11.Text = "";
			// 
			// txt24
			// 
			this.txt24.BackColor = System.Drawing.Color.White;
			this.txt24.DataField = "modifyBy";
			this.txt24.DataType = TJSystem.Public.DataType.String;
			this.txt24.Enabled = false;
			this.txt24.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.txt24.Location = new System.Drawing.Point(472, 296);
			this.txt24.Name = "txt24";
			this.txt24.Size = new System.Drawing.Size(96, 23);
			this.txt24.TabIndex = 9;
			this.txt24.Text = "";
			// 
			// txt5
			// 
			this.txt5.BackColor = System.Drawing.Color.White;
			this.txt5.DataField = "supplier_name";
			this.txt5.DataType = TJSystem.Public.DataType.String;
			this.txt5.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.txt5.Location = new System.Drawing.Point(96, 80);
			this.txt5.Name = "txt5";
			this.txt5.Size = new System.Drawing.Size(280, 23);
			this.txt5.TabIndex = 105;
			this.txt5.Text = "";
			// 
			// txt10
			// 
			this.txt10.BackColor = System.Drawing.Color.White;
			this.txt10.DataField = "province";
			this.txt10.DataType = TJSystem.Public.DataType.String;
			this.txt10.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.txt10.Location = new System.Drawing.Point(440, 128);
			this.txt10.Name = "txt10";
			this.txt10.Size = new System.Drawing.Size(112, 23);
			this.txt10.TabIndex = 108;
			this.txt10.Text = "";
			// 
			// txt1
			// 
			this.txt1.BackColor = System.Drawing.Color.White;
			this.txt1.DataField = "supplier_id";
			this.txt1.DataType = TJSystem.Public.DataType.String;
			this.txt1.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.txt1.Location = new System.Drawing.Point(96, 56);
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
			this.txt13.Location = new System.Drawing.Point(264, 152);
			this.txt13.Name = "txt13";
			this.txt13.Size = new System.Drawing.Size(112, 23);
			this.txt13.TabIndex = 110;
			this.txt13.Text = "";
			// 
			// frmClientSuplier
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(7, 16);
			this.BackColor = System.Drawing.SystemColors.ScrollBar;
			this.ClientSize = new System.Drawing.Size(792, 566);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.panel3);
			this.Controls.Add(this.panel2);
			this.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "frmClientSuplier";
			this.Text = "供应商管理";
			this.panel1.ResumeLayout(false);
			this.panel3.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).EndInit();
			this.panel4.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		private void linkLabel1_LinkClicked(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
		{
			if(this.txt1.Text.Trim().Equals(""))
			{
				MessageBox.Show("未选择供应商","Error",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
				return;
			}
			frmClientSuplierBank frm = new frmClientSuplierBank(this.txt1.Text);
			frm.ShowDialog();
		}

		private void linkLabel2_LinkClicked(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
		{
			if(this.txt1.Text.Trim().Equals(""))
			{
				MessageBox.Show("未选择供应商","Error",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
				return;
			}
			frmClientSuplierContact frm = new frmClientSuplierContact(this.txt1.Text);
			frm.ShowDialog();
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
				TJSystem.Public.PublicStatic.formName = "供应商管理";
			}
			 base.OnClosing (e);
		}

		private void linkLabel3_LinkClicked(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
		{
			if(this.txt1.Text.Trim().Equals(""))
			{
				MessageBox.Show("未选择供应商","Error",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
				return;
			}
			frmClientSuplierItemType frm = new frmClientSuplierItemType(this.txt1.Text);
			frm.ShowDialog();
		}

		private void linkLabel4_LinkClicked(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
		{
			if(this.txt1.Text.Trim().Equals(""))
			{
				MessageBox.Show("未选择供应商","Error",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
				return;
			}
			frmClientSuplierItem frm = new frmClientSuplierItem(this.txt1.Text);
			frm.ShowDialog();
		}



		
	}
}

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
	public class frmClientCustomers : System.Windows.Forms.Form
	{
		
		
		/// <summary>
		/// 必需的设计器变量。

		/// </summary>
		private System.ComponentModel.Container components = null;
		private System.Windows.Forms.Panel panel1;
		
		private System.Windows.Forms.Panel panel3;
		private TJSystem.UC.PriToolBar priToolBar1;
		
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.DataGridTableStyle dataGridTableStyle1;
		private System.Windows.Forms.DataGrid dataGrid1;
		private System.Windows.Forms.Panel panel4;
		private System.Windows.Forms.Label label21;
		private System.Windows.Forms.Label label20;
		private System.Windows.Forms.Label label18;
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
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private TJSystem.Classes.PriTextBox txt7;
		
		private System.Windows.Forms.DataGridTextBoxColumn company_name_cn;
		private System.Windows.Forms.DataGridTextBoxColumn postcode;
		private System.Windows.Forms.DataGridTextBoxColumn email1;
		private System.Windows.Forms.Label label22;
		private System.Windows.Forms.Label label26;
		private System.Windows.Forms.Label label27;
		private System.Windows.Forms.Label label28;
		private System.Windows.Forms.Label label29;
		private System.Windows.Forms.Label label30;
		private System.Windows.Forms.Label label31;
		private System.Windows.Forms.Label label32;
		private System.Windows.Forms.Label label33;
		private System.Windows.Forms.Label label34;
		private System.Windows.Forms.Label label35;
		private TJSystem.Classes.PriTextBox txt6;
		private TJSystem.Classes.PriTextBox txt5;
		private TJSystem.Classes.PriTextBox txt24;
		private TJSystem.Classes.PriTextBox txt23;
		private TJSystem.Classes.PriTextBox txt28;
		private TJSystem.Classes.PriTextBox txt26;
		private TJSystem.Classes.PriTextBox txt21;
		private TJSystem.Classes.PriTextBox txt22;
		private TJSystem.Classes.PriTextBox txt25;
		private TJSystem.Classes.PriTextBox txt27;
		private System.Windows.Forms.Label label1;
		private TJSystem.Classes.PriTextBox txt20;
		private TJSystem.Classes.PriTextBox txt18;
		private TJSystem.Classes.PriTextBox txt16;
		private TJSystem.Classes.PriTextBox txt14;
		private TJSystem.Classes.PriTextBox txt9;
		private TJSystem.Classes.PriTextBox txt15;
		private TJSystem.Classes.PriTextBox txt17;
		private TJSystem.Classes.PriTextBox txt10;
		private TJSystem.Classes.PriTextBox txt1;
		private TJSystem.Classes.PriTextBox txt13;
		public static System.Windows.Forms.Form frmCurrent = null ;
		private System.Windows.Forms.DataGridTextBoxColumn client_id;
		private System.Windows.Forms.DataGridTextBoxColumn client_name;
		private System.Windows.Forms.DataGridTextBoxColumn clientaddress;
		private System.Windows.Forms.DataGridTextBoxColumn clientpostcode;
		private TJSystem.Classes.PriComboBox priComboBox1;
		private TJSystem.Classes.PriComboBox priComboBox2;
		private TJSystem.Classes.PriComboBox comboBox1;
		private TJSystem.Classes.PriComboBox priComboBox3;
		private TJSystem.Classes.PriComboBox priComboBox5;
		private TJSystem.Classes.PriComboBox priComboBox6;
		private TJSystem.Classes.PriComboBox priComboBox4;
		private System.Windows.Forms.LinkLabel linkLabel2;
		private string _PK = null;
		private string _table = null;
		private System.Windows.Forms.DataGridTextBoxColumn type_name;
		private System.Windows.Forms.DataGridTextBoxColumn grade_name;
		private System.Windows.Forms.DataGridTextBoxColumn status_name;
		private System.Windows.Forms.DataGridTextBoxColumn country_namecn;
		private System.Windows.Forms.DataGridTextBoxColumn region_namecn;
		private System.Windows.Forms.DataGridTextBoxColumn province;
		private System.Windows.Forms.DataGridTextBoxColumn city;
		private System.Windows.Forms.DataGridTextBoxColumn tel;
		private System.Windows.Forms.DataGridTextBoxColumn fax;
		private System.Windows.Forms.DataGridTextBoxColumn Email;
		private System.Windows.Forms.DataGridTextBoxColumn cWebsite;
		private System.Windows.Forms.DataGridTextBoxColumn currency_namecn;
		private System.Windows.Forms.DataGridTextBoxColumn Credit_rated;
		private System.Windows.Forms.DataGridTextBoxColumn minorder;
		private System.Windows.Forms.DataGridTextBoxColumn Bank;
		private System.Windows.Forms.DataGridTextBoxColumn Account;
		private System.Windows.Forms.DataGridTextBoxColumn ccreateBy;
		private System.Windows.Forms.DataGridTextBoxColumn ccreateon;
		private System.Windows.Forms.DataGridTextBoxColumn cmodifyBy;
		private System.Windows.Forms.DataGridTextBoxColumn cmodifyon;
		private System.Windows.Forms.DataGridTextBoxColumn client_sort1;
		private System.Windows.Forms.DataGridTextBoxColumn client_sort2;
		private System.Windows.Forms.DataGridTextBoxColumn description;
		private System.Windows.Forms.DataGridTextBoxColumn Financial_Status;
		private string _statusType = null;

		public frmClientCustomers()
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
			sb.Append("select a.client_id,a.client_type,h.type_name as type_name,a.grade,b.grade_name as grade_name,");
			sb.Append("a.status,c.status_name as status_name,a.client_name,a.address,a.Postcode,a.country,d.country_namecn as country_namecn,");
			sb.Append("a.region_code,e.region_namecn as region_namecn,a.province,a.city,a.tel,a.fax,a.Email,a.Website,");
			sb.Append("a.Currency,f.currency_namecn as currency_namecn,a.Credit_rated,a.minorder,");
			sb.Append("a.Bank,a.Account,a.Financial_Status,a.createBy,a.createon,a.modifyBy,a.modifyon,a.client_comefrom,g.description as description,");
			sb.Append("a.client_sort1,a.client_sort2 ");
			sb.Append("from basic_client a ");
			sb.Append("left join p_enterprisetype h on a.client_type=h.type_code ");
			sb.Append("left join p_grade b on a.grade=b.grade_id ");
			sb.Append("left join p_status c on a.status=c.status_id and status_type=");
			sb.Append("'");
			sb.Append(this._statusType);
			sb.Append("' ");
			sb.Append("left join p_country d on a.country=d.country_code ");
			sb.Append("left join p_region e on a.region_code=e.region_code ");
			sb.Append("left join p_currency f on a.currency=f.currency_code ");
			sb.Append("left join p_clientfrom g on a.client_comefrom=g.from_id ");
			sb.Append("order by a.client_id");
			this.InitialGrid(sb.ToString());

			priToolBar1.setCurrentForm = this;
			
			_PK = "client_id";
			_table = "basic_client";
			priToolBar1.Initial(_table,_PK,sb.ToString());
			priToolBar1.BeforeButtonClickEvent += new TJSystem.UC.PriToolBar.BeforeButotnClick(this.BeforeButtonClick);
			priToolBar1.AfterButtonClickEvent += new TJSystem.UC.PriToolBar.AfterButtonClick(this.AfterButtonClick);

			priToolBar1.setButtonVisibleFalse();
			priToolBar1.setButtonVisible("012345689");
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

			sql = "select FROM_ID,FROM_ID+' '+DESCRIPTION as DESCRIPTION from p_clientfrom order by FROM_ID";
			dt = TJSystem.Public.PublicStatic.db.GetDataTable(sql);
			dr = dt.NewRow() ;
			dr[0] = "" ;
			dr[1] = "" ;
			dt.Rows.InsertAt(dr,0) ;
			dtcpy = dt.Copy();
			this.priComboBox4.DataSource = dtcpy.DefaultView;
			this.priComboBox4.ValueMember = "FROM_ID";
			this.priComboBox4.DisplayMember = "DESCRIPTION";

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
			System.Text.StringBuilder sb = new System.Text.StringBuilder();
			sb.Append("数据验证错误：\r\n");
			if(sqltype.Equals("default"))
			{
				this.setDisable();
			}
			if(sqltype.Equals("insert"))
			{
				if(!checkFormValue(sqltype,sb))
				{
//					MessageBox.Show(sb.ToString(),"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
					return false;
				}
			}
			return true;
		}


		private bool checkFormValue(string sqltype,System.Text.StringBuilder sb)
		{			
			if(sqltype.Equals("insert")
				|| sqltype.Equals("update"))
			{
				if(sqltype.Equals("insert"))
				{
					if(txt1.Text.Length > 10)
					{
						sb.Append("  数据长度超出数据库定义要求\r\n");
						return false;
					}

					if (this.txt1.Text == "")
					{
						MessageBox.Show("请输入客户代码","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
						return false;
					}
				
					if(TJSystem.Public.PublicStatic.IsExsist(this._table,this._PK,this.priToolBar1))
					{
						MessageBox.Show("这个客户信息已经存在,请另外开立","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
						return false;
					}

				}

				if(this.comboBox1.SelectedValue == null)
				{
					TJSystem.Public.PublicStatic.ShowMessage(TJSystem.Public.MessageType.Exclamation,"必须选择客户类型！");
					return false;
				}

				if(this.priComboBox1.SelectedValue == null)
				{
					TJSystem.Public.PublicStatic.ShowMessage(TJSystem.Public.MessageType.Exclamation,"必须选择客户状态！");
					return false;
				}
				if(this.priComboBox2.SelectedValue == null)
				{
					TJSystem.Public.PublicStatic.ShowMessage(TJSystem.Public.MessageType.Exclamation,"必须选择客户等级！");
					return false;
				}
				if(this.priComboBox3.SelectedValue == null)
				{
					TJSystem.Public.PublicStatic.ShowMessage(TJSystem.Public.MessageType.Exclamation,"必须选择币种！");
					return false;
				}
				if(this.priComboBox4.SelectedValue == null)
				{
					TJSystem.Public.PublicStatic.ShowMessage(TJSystem.Public.MessageType.Exclamation,"必须选择客户来源！");
					return false;
				}
				if(this.priComboBox5.SelectedValue == null)
				{
					TJSystem.Public.PublicStatic.ShowMessage(TJSystem.Public.MessageType.Exclamation,"必须选择国家！");
					return false;
				}
				if(this.priComboBox6.SelectedValue == null)
				{
					TJSystem.Public.PublicStatic.ShowMessage(TJSystem.Public.MessageType.Exclamation,"必须选择客户地区！");
					return false;
				}
				if(!TJSystem.Public.PublicStatic.IsNumDouble(this.txt20.Text.Trim()))
				{
					TJSystem.Public.PublicStatic.ShowMessage(TJSystem.Public.MessageType.Exclamation,"信用额度必须是数字！");
					return false;
				}
				if(!TJSystem.Public.PublicStatic.IsNumDouble(this.txt21.Text.Trim()))
				{
					TJSystem.Public.PublicStatic.ShowMessage(TJSystem.Public.MessageType.Exclamation,"最小订货量必须是数字！");
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
			
			this.txt9.Enabled = false;
			this.txt10.Enabled = false;
			
			this.txt13.Enabled = false;
			this.txt14.Enabled = false;
			this.txt15.Enabled = false;
			this.txt16.Enabled = false;
			this.txt17.Enabled = false;
			this.txt18.Enabled = false;
			
			this.txt20.Enabled = false;
			this.txt21.Enabled = false;
			this.txt22.Enabled = false;
			this.txt23.Enabled = false;
			this.txt24.Enabled = false;
			this.txt25.Enabled = false;
			this.txt26.Enabled = false;
			this.txt27.Enabled = false;
			this.txt28.Enabled = false;

			this.priComboBox1.Enabled = false;
			this.priComboBox2.Enabled = false;
			this.priComboBox3.Enabled = false;
			this.priComboBox4.Enabled = false;
			this.priComboBox5.Enabled = false;
			this.priComboBox6.Enabled = false;
			this.comboBox1.Enabled = false;
		}

		private void AfterButtonClick(string ButtonType)
		{
			if(ButtonType.Equals("insert"))
			{
				this.txt1.Enabled = true;
				
				this.txt5.Enabled = true;
				this.txt6.Enabled = true;
				this.txt7.Enabled = true;
				
				this.txt9.Enabled = true;
				this.txt10.Enabled = true;
				
				this.txt13.Enabled = true;
				this.txt14.Enabled = true;
				this.txt15.Enabled = true;
				this.txt16.Enabled = true;
				this.txt17.Enabled = true;
				this.txt18.Enabled = true;
				
				this.txt20.Enabled = true;
				this.txt21.Enabled = true;
				this.txt22.Enabled = true;
				this.txt23.Enabled = true;
				this.txt24.Enabled = true;
				
				this.priComboBox1.Enabled = true;
				this.priComboBox2.Enabled = true;
				this.priComboBox3.Enabled = true;
				this.priComboBox4.Enabled = true;
				this.priComboBox5.Enabled = true;
				this.priComboBox6.Enabled = true;
				this.comboBox1.Enabled = true;

				this.txt1.Text = "";
				
				this.txt5.Text = "";
				this.txt6.Text = "";
				this.txt7.Text = "";
				
				this.txt9.Text = "";
				this.txt10.Text = "";
				
				this.txt13.Text = "";
				this.txt14.Text = "";
				this.txt15.Text = "";
				this.txt16.Text = "";
				this.txt17.Text = "";
				this.txt18.Text = "";
				
				this.txt20.Text = "";
				this.txt21.Text = "";
				this.txt22.Text = "";
				this.txt23.Text = "";
				this.txt24.Text = "";
				
				this.priComboBox1.Text = "";
				this.priComboBox2.Text = "";
				this.priComboBox3.Text = "";
				this.priComboBox4.Text = "";
				this.priComboBox5.Text = "";
				this.priComboBox6.Text = "";
				this.comboBox1.Text = "";

			}
			else if(ButtonType.Equals("update"))
			{
				this.txt1.Enabled = false;
				
				this.txt5.Enabled = true;
				this.txt6.Enabled = true;
				this.txt7.Enabled = true;
				
				this.txt9.Enabled = true;
				this.txt10.Enabled = true;
				
				this.txt13.Enabled = true;
				this.txt14.Enabled = true;
				this.txt15.Enabled = true;
				this.txt16.Enabled = true;
				this.txt17.Enabled = true;
				this.txt18.Enabled = true;
				
				this.txt20.Enabled = true;
				this.txt21.Enabled = true;
				this.txt22.Enabled = true;
				this.txt23.Enabled = true;
				this.txt24.Enabled = true;
				
				this.priComboBox1.Enabled = true;
				this.priComboBox2.Enabled = true;
				this.priComboBox3.Enabled = true;
				this.priComboBox4.Enabled = true;
				this.priComboBox5.Enabled = true;
				this.priComboBox6.Enabled = true;
				this.comboBox1.Enabled = true;

			}
		}

		private void InitialGrid(string sql)
		{		
			DataTable dt = TJSystem.Public.PublicStatic.db.GetDataTable(sql);
			dt.TableName = "basic_client";
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(frmClientCustomers));
			this.panel1 = new System.Windows.Forms.Panel();
			this.label1 = new System.Windows.Forms.Label();
			this.panel3 = new System.Windows.Forms.Panel();
			this.priToolBar1 = new TJSystem.UC.PriToolBar();
			this.panel2 = new System.Windows.Forms.Panel();
			this.dataGrid1 = new System.Windows.Forms.DataGrid();
			this.dataGridTableStyle1 = new System.Windows.Forms.DataGridTableStyle();
			this.client_id = new System.Windows.Forms.DataGridTextBoxColumn();
			this.client_name = new System.Windows.Forms.DataGridTextBoxColumn();
			this.type_name = new System.Windows.Forms.DataGridTextBoxColumn();
			this.grade_name = new System.Windows.Forms.DataGridTextBoxColumn();
			this.status_name = new System.Windows.Forms.DataGridTextBoxColumn();
			this.description = new System.Windows.Forms.DataGridTextBoxColumn();
			this.clientaddress = new System.Windows.Forms.DataGridTextBoxColumn();
			this.clientpostcode = new System.Windows.Forms.DataGridTextBoxColumn();
			this.country_namecn = new System.Windows.Forms.DataGridTextBoxColumn();
			this.region_namecn = new System.Windows.Forms.DataGridTextBoxColumn();
			this.province = new System.Windows.Forms.DataGridTextBoxColumn();
			this.city = new System.Windows.Forms.DataGridTextBoxColumn();
			this.tel = new System.Windows.Forms.DataGridTextBoxColumn();
			this.fax = new System.Windows.Forms.DataGridTextBoxColumn();
			this.Email = new System.Windows.Forms.DataGridTextBoxColumn();
			this.cWebsite = new System.Windows.Forms.DataGridTextBoxColumn();
			this.currency_namecn = new System.Windows.Forms.DataGridTextBoxColumn();
			this.Credit_rated = new System.Windows.Forms.DataGridTextBoxColumn();
			this.minorder = new System.Windows.Forms.DataGridTextBoxColumn();
			this.Bank = new System.Windows.Forms.DataGridTextBoxColumn();
			this.Account = new System.Windows.Forms.DataGridTextBoxColumn();
			this.Financial_Status = new System.Windows.Forms.DataGridTextBoxColumn();
			this.client_sort1 = new System.Windows.Forms.DataGridTextBoxColumn();
			this.client_sort2 = new System.Windows.Forms.DataGridTextBoxColumn();
			this.ccreateBy = new System.Windows.Forms.DataGridTextBoxColumn();
			this.ccreateon = new System.Windows.Forms.DataGridTextBoxColumn();
			this.cmodifyBy = new System.Windows.Forms.DataGridTextBoxColumn();
			this.cmodifyon = new System.Windows.Forms.DataGridTextBoxColumn();
			this.panel4 = new System.Windows.Forms.Panel();
			this.linkLabel2 = new System.Windows.Forms.LinkLabel();
			this.priComboBox4 = new TJSystem.Classes.PriComboBox();
			this.priComboBox6 = new TJSystem.Classes.PriComboBox();
			this.priComboBox5 = new TJSystem.Classes.PriComboBox();
			this.priComboBox3 = new TJSystem.Classes.PriComboBox();
			this.comboBox1 = new TJSystem.Classes.PriComboBox();
			this.priComboBox2 = new TJSystem.Classes.PriComboBox();
			this.priComboBox1 = new TJSystem.Classes.PriComboBox();
			this.label35 = new System.Windows.Forms.Label();
			this.txt20 = new TJSystem.Classes.PriTextBox();
			this.label34 = new System.Windows.Forms.Label();
			this.txt18 = new TJSystem.Classes.PriTextBox();
			this.label33 = new System.Windows.Forms.Label();
			this.txt16 = new TJSystem.Classes.PriTextBox();
			this.label32 = new System.Windows.Forms.Label();
			this.txt14 = new TJSystem.Classes.PriTextBox();
			this.label31 = new System.Windows.Forms.Label();
			this.label30 = new System.Windows.Forms.Label();
			this.txt9 = new TJSystem.Classes.PriTextBox();
			this.label29 = new System.Windows.Forms.Label();
			this.txt6 = new TJSystem.Classes.PriTextBox();
			this.label28 = new System.Windows.Forms.Label();
			this.label27 = new System.Windows.Forms.Label();
			this.txt24 = new TJSystem.Classes.PriTextBox();
			this.label26 = new System.Windows.Forms.Label();
			this.txt23 = new TJSystem.Classes.PriTextBox();
			this.label22 = new System.Windows.Forms.Label();
			this.label21 = new System.Windows.Forms.Label();
			this.txt28 = new TJSystem.Classes.PriTextBox();
			this.label20 = new System.Windows.Forms.Label();
			this.txt26 = new TJSystem.Classes.PriTextBox();
			this.label18 = new System.Windows.Forms.Label();
			this.label19 = new System.Windows.Forms.Label();
			this.txt21 = new TJSystem.Classes.PriTextBox();
			this.label17 = new System.Windows.Forms.Label();
			this.txt22 = new TJSystem.Classes.PriTextBox();
			this.label16 = new System.Windows.Forms.Label();
			this.label15 = new System.Windows.Forms.Label();
			this.label14 = new System.Windows.Forms.Label();
			this.label13 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.txt15 = new TJSystem.Classes.PriTextBox();
			this.txt7 = new TJSystem.Classes.PriTextBox();
			this.txt25 = new TJSystem.Classes.PriTextBox();
			this.txt17 = new TJSystem.Classes.PriTextBox();
			this.txt27 = new TJSystem.Classes.PriTextBox();
			this.txt5 = new TJSystem.Classes.PriTextBox();
			this.txt10 = new TJSystem.Classes.PriTextBox();
			this.txt1 = new TJSystem.Classes.PriTextBox();
			this.txt13 = new TJSystem.Classes.PriTextBox();
			this.company_name_cn = new System.Windows.Forms.DataGridTextBoxColumn();
			this.postcode = new System.Windows.Forms.DataGridTextBoxColumn();
			this.email1 = new System.Windows.Forms.DataGridTextBoxColumn();
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
			this.panel1.TabIndex = 10;
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
			this.label1.Text = "客户管理";
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
			this.panel2.TabIndex = 11;
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
			this.dataGrid1.Location = new System.Drawing.Point(8, 352);
			this.dataGrid1.Name = "dataGrid1";
			this.dataGrid1.ReadOnly = true;
			this.dataGrid1.Size = new System.Drawing.Size(768, 168);
			this.dataGrid1.TabIndex = 1;
			this.dataGrid1.TableStyles.AddRange(new System.Windows.Forms.DataGridTableStyle[] {
																								  this.dataGridTableStyle1});
			// 
			// dataGridTableStyle1
			// 
			this.dataGridTableStyle1.AllowSorting = false;
			this.dataGridTableStyle1.DataGrid = this.dataGrid1;
			this.dataGridTableStyle1.GridColumnStyles.AddRange(new System.Windows.Forms.DataGridColumnStyle[] {
																												  this.client_id,
																												  this.client_name,
																												  this.type_name,
																												  this.grade_name,
																												  this.status_name,
																												  this.description,
																												  this.clientaddress,
																												  this.clientpostcode,
																												  this.country_namecn,
																												  this.region_namecn,
																												  this.province,
																												  this.city,
																												  this.tel,
																												  this.fax,
																												  this.Email,
																												  this.cWebsite,
																												  this.currency_namecn,
																												  this.Credit_rated,
																												  this.minorder,
																												  this.Bank,
																												  this.Account,
																												  this.Financial_Status,
																												  this.client_sort1,
																												  this.client_sort2,
																												  this.ccreateBy,
																												  this.ccreateon,
																												  this.cmodifyBy,
																												  this.cmodifyon});
			this.dataGridTableStyle1.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.dataGridTableStyle1.MappingName = "basic_client";
			this.dataGridTableStyle1.ReadOnly = true;
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
			// type_name
			// 
			this.type_name.Format = "";
			this.type_name.FormatInfo = null;
			this.type_name.HeaderText = "客户类型";
			this.type_name.MappingName = "type_name";
			this.type_name.NullText = "";
			this.type_name.Width = 75;
			// 
			// grade_name
			// 
			this.grade_name.Format = "";
			this.grade_name.FormatInfo = null;
			this.grade_name.HeaderText = "客户等级";
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
			// description
			// 
			this.description.Format = "";
			this.description.FormatInfo = null;
			this.description.HeaderText = "客户来源";
			this.description.MappingName = "description";
			this.description.NullText = "";
			this.description.Width = 75;
			// 
			// clientaddress
			// 
			this.clientaddress.Format = "";
			this.clientaddress.FormatInfo = null;
			this.clientaddress.HeaderText = "地址";
			this.clientaddress.MappingName = "address";
			this.clientaddress.NullText = "";
			this.clientaddress.Width = 75;
			// 
			// clientpostcode
			// 
			this.clientpostcode.Format = "";
			this.clientpostcode.FormatInfo = null;
			this.clientpostcode.HeaderText = "邮编";
			this.clientpostcode.MappingName = "Postcode";
			this.clientpostcode.NullText = "";
			this.clientpostcode.Width = 75;
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
			// cWebsite
			// 
			this.cWebsite.Format = "";
			this.cWebsite.FormatInfo = null;
			this.cWebsite.HeaderText = "网站";
			this.cWebsite.MappingName = "Website";
			this.cWebsite.NullText = "";
			this.cWebsite.Width = 75;
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
			// Credit_rated
			// 
			this.Credit_rated.Format = "";
			this.Credit_rated.FormatInfo = null;
			this.Credit_rated.HeaderText = "信用额度";
			this.Credit_rated.MappingName = "Credit_rated";
			this.Credit_rated.NullText = "";
			this.Credit_rated.Width = 75;
			// 
			// minorder
			// 
			this.minorder.Format = "";
			this.minorder.FormatInfo = null;
			this.minorder.HeaderText = "最低订货量";
			this.minorder.MappingName = "minorder";
			this.minorder.NullText = "";
			this.minorder.Width = 75;
			// 
			// Bank
			// 
			this.Bank.Format = "";
			this.Bank.FormatInfo = null;
			this.Bank.HeaderText = "银行";
			this.Bank.MappingName = "Bank";
			this.Bank.NullText = "";
			this.Bank.Width = 75;
			// 
			// Account
			// 
			this.Account.Format = "";
			this.Account.FormatInfo = null;
			this.Account.HeaderText = "账号";
			this.Account.MappingName = "Account";
			this.Account.NullText = "";
			this.Account.Width = 75;
			// 
			// Financial_Status
			// 
			this.Financial_Status.Format = "";
			this.Financial_Status.FormatInfo = null;
			this.Financial_Status.HeaderText = "信用评估";
			this.Financial_Status.MappingName = "Financial_Status";
			this.Financial_Status.Width = 75;
			// 
			// client_sort1
			// 
			this.client_sort1.Format = "";
			this.client_sort1.FormatInfo = null;
			this.client_sort1.HeaderText = "大类";
			this.client_sort1.MappingName = "client_sort1";
			this.client_sort1.NullText = "";
			this.client_sort1.Width = 75;
			// 
			// client_sort2
			// 
			this.client_sort2.Format = "";
			this.client_sort2.FormatInfo = null;
			this.client_sort2.HeaderText = "小类";
			this.client_sort2.MappingName = "client_sort2";
			this.client_sort2.NullText = "";
			this.client_sort2.Width = 75;
			// 
			// ccreateBy
			// 
			this.ccreateBy.Format = "";
			this.ccreateBy.FormatInfo = null;
			this.ccreateBy.HeaderText = "创建者";
			this.ccreateBy.MappingName = "createBy";
			this.ccreateBy.NullText = "";
			this.ccreateBy.Width = 75;
			// 
			// ccreateon
			// 
			this.ccreateon.Format = "";
			this.ccreateon.FormatInfo = null;
			this.ccreateon.HeaderText = "创建时间";
			this.ccreateon.MappingName = "createon";
			this.ccreateon.NullText = "";
			this.ccreateon.Width = 75;
			// 
			// cmodifyBy
			// 
			this.cmodifyBy.Format = "";
			this.cmodifyBy.FormatInfo = null;
			this.cmodifyBy.HeaderText = "最后修改人";
			this.cmodifyBy.MappingName = "modifyBy";
			this.cmodifyBy.NullText = "";
			this.cmodifyBy.Width = 75;
			// 
			// cmodifyon
			// 
			this.cmodifyon.Format = "";
			this.cmodifyon.FormatInfo = null;
			this.cmodifyon.HeaderText = "最后修改时间";
			this.cmodifyon.MappingName = "modifyon";
			this.cmodifyon.NullText = "";
			this.cmodifyon.Width = 75;
			// 
			// panel4
			// 
			this.panel4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel4.BackgroundImage")));
			this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.panel4.Controls.Add(this.linkLabel2);
			this.panel4.Controls.Add(this.priComboBox4);
			this.panel4.Controls.Add(this.priComboBox6);
			this.panel4.Controls.Add(this.priComboBox5);
			this.panel4.Controls.Add(this.priComboBox3);
			this.panel4.Controls.Add(this.comboBox1);
			this.panel4.Controls.Add(this.priComboBox2);
			this.panel4.Controls.Add(this.priComboBox1);
			this.panel4.Controls.Add(this.label35);
			this.panel4.Controls.Add(this.txt20);
			this.panel4.Controls.Add(this.label34);
			this.panel4.Controls.Add(this.txt18);
			this.panel4.Controls.Add(this.label33);
			this.panel4.Controls.Add(this.txt16);
			this.panel4.Controls.Add(this.label32);
			this.panel4.Controls.Add(this.txt14);
			this.panel4.Controls.Add(this.label31);
			this.panel4.Controls.Add(this.label30);
			this.panel4.Controls.Add(this.txt9);
			this.panel4.Controls.Add(this.label29);
			this.panel4.Controls.Add(this.txt6);
			this.panel4.Controls.Add(this.label28);
			this.panel4.Controls.Add(this.label27);
			this.panel4.Controls.Add(this.txt24);
			this.panel4.Controls.Add(this.label26);
			this.panel4.Controls.Add(this.txt23);
			this.panel4.Controls.Add(this.label22);
			this.panel4.Controls.Add(this.label21);
			this.panel4.Controls.Add(this.txt28);
			this.panel4.Controls.Add(this.label20);
			this.panel4.Controls.Add(this.txt26);
			this.panel4.Controls.Add(this.label18);
			this.panel4.Controls.Add(this.label19);
			this.panel4.Controls.Add(this.txt21);
			this.panel4.Controls.Add(this.label17);
			this.panel4.Controls.Add(this.txt22);
			this.panel4.Controls.Add(this.label16);
			this.panel4.Controls.Add(this.label15);
			this.panel4.Controls.Add(this.label14);
			this.panel4.Controls.Add(this.label13);
			this.panel4.Controls.Add(this.label11);
			this.panel4.Controls.Add(this.label10);
			this.panel4.Controls.Add(this.label9);
			this.panel4.Controls.Add(this.label7);
			this.panel4.Controls.Add(this.label6);
			this.panel4.Controls.Add(this.label5);
			this.panel4.Controls.Add(this.label4);
			this.panel4.Controls.Add(this.label3);
			this.panel4.Controls.Add(this.txt15);
			this.panel4.Controls.Add(this.txt7);
			this.panel4.Controls.Add(this.txt25);
			this.panel4.Controls.Add(this.txt17);
			this.panel4.Controls.Add(this.txt27);
			this.panel4.Controls.Add(this.txt5);
			this.panel4.Controls.Add(this.txt10);
			this.panel4.Controls.Add(this.txt1);
			this.panel4.Controls.Add(this.txt13);
			this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel4.Location = new System.Drawing.Point(0, 0);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(788, 344);
			this.panel4.TabIndex = 0;
			// 
			// linkLabel2
			// 
			this.linkLabel2.BackColor = System.Drawing.Color.Transparent;
			this.linkLabel2.Location = new System.Drawing.Point(560, 104);
			this.linkLabel2.Name = "linkLabel2";
			this.linkLabel2.Size = new System.Drawing.Size(72, 23);
			this.linkLabel2.TabIndex = 153;
			this.linkLabel2.TabStop = true;
			this.linkLabel2.Text = "联系方式";
			this.linkLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
			// 
			// priComboBox4
			// 
			this.priComboBox4.BackColor = System.Drawing.Color.White;
			this.priComboBox4.DataField = "Client_comefrom";
			this.priComboBox4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.priComboBox4.Location = new System.Drawing.Point(640, 80);
			this.priComboBox4.Name = "priComboBox4";
			this.priComboBox4.Size = new System.Drawing.Size(104, 22);
			this.priComboBox4.TabIndex = 152;
			// 
			// priComboBox6
			// 
			this.priComboBox6.BackColor = System.Drawing.Color.White;
			this.priComboBox6.DataField = "region_code";
			this.priComboBox6.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.priComboBox6.Location = new System.Drawing.Point(264, 128);
			this.priComboBox6.Name = "priComboBox6";
			this.priComboBox6.Size = new System.Drawing.Size(112, 22);
			this.priComboBox6.TabIndex = 151;
			// 
			// priComboBox5
			// 
			this.priComboBox5.BackColor = System.Drawing.Color.White;
			this.priComboBox5.DataField = "country";
			this.priComboBox5.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.priComboBox5.Location = new System.Drawing.Point(96, 128);
			this.priComboBox5.Name = "priComboBox5";
			this.priComboBox5.Size = new System.Drawing.Size(112, 22);
			this.priComboBox5.TabIndex = 150;
			// 
			// priComboBox3
			// 
			this.priComboBox3.BackColor = System.Drawing.Color.White;
			this.priComboBox3.DataField = "Currency";
			this.priComboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.priComboBox3.Location = new System.Drawing.Point(96, 176);
			this.priComboBox3.Name = "priComboBox3";
			this.priComboBox3.Size = new System.Drawing.Size(112, 22);
			this.priComboBox3.TabIndex = 149;
			// 
			// comboBox1
			// 
			this.comboBox1.BackColor = System.Drawing.Color.White;
			this.comboBox1.DataField = "client_type";
			this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBox1.Location = new System.Drawing.Point(264, 56);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(104, 22);
			this.comboBox1.TabIndex = 148;
			// 
			// priComboBox2
			// 
			this.priComboBox2.BackColor = System.Drawing.Color.White;
			this.priComboBox2.DataField = "grade";
			this.priComboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.priComboBox2.Location = new System.Drawing.Point(440, 56);
			this.priComboBox2.Name = "priComboBox2";
			this.priComboBox2.Size = new System.Drawing.Size(112, 22);
			this.priComboBox2.TabIndex = 147;
			// 
			// priComboBox1
			// 
			this.priComboBox1.BackColor = System.Drawing.Color.White;
			this.priComboBox1.DataField = "status";
			this.priComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.priComboBox1.Location = new System.Drawing.Point(640, 56);
			this.priComboBox1.Name = "priComboBox1";
			this.priComboBox1.Size = new System.Drawing.Size(104, 22);
			this.priComboBox1.TabIndex = 146;
			// 
			// label35
			// 
			this.label35.BackColor = System.Drawing.Color.Transparent;
			this.label35.ForeColor = System.Drawing.Color.Blue;
			this.label35.Location = new System.Drawing.Point(224, 176);
			this.label35.Name = "label35";
			this.label35.Size = new System.Drawing.Size(64, 23);
			this.label35.TabIndex = 142;
			this.label35.Text = "信用额度";
			this.label35.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txt20
			// 
			this.txt20.BackColor = System.Drawing.Color.White;
			this.txt20.DataField = "Credit_Rated";
			this.txt20.DataType = TJSystem.Public.DataType.String;
			this.txt20.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.txt20.Location = new System.Drawing.Point(296, 176);
			this.txt20.Name = "txt20";
			this.txt20.Size = new System.Drawing.Size(128, 23);
			this.txt20.TabIndex = 143;
			this.txt20.Text = "";
			// 
			// label34
			// 
			this.label34.BackColor = System.Drawing.Color.Transparent;
			this.label34.Location = new System.Drawing.Point(576, 152);
			this.label34.Name = "label34";
			this.label34.Size = new System.Drawing.Size(48, 23);
			this.label34.TabIndex = 140;
			this.label34.Text = "网址";
			this.label34.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txt18
			// 
			this.txt18.BackColor = System.Drawing.Color.White;
			this.txt18.DataField = "WebSite";
			this.txt18.DataType = TJSystem.Public.DataType.String;
			this.txt18.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.txt18.Location = new System.Drawing.Point(632, 152);
			this.txt18.Name = "txt18";
			this.txt18.Size = new System.Drawing.Size(88, 23);
			this.txt18.TabIndex = 141;
			this.txt18.Text = "";
			// 
			// label33
			// 
			this.label33.BackColor = System.Drawing.Color.Transparent;
			this.label33.Location = new System.Drawing.Point(208, 152);
			this.label33.Name = "label33";
			this.label33.Size = new System.Drawing.Size(40, 23);
			this.label33.TabIndex = 138;
			this.label33.Text = "传真";
			this.label33.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txt16
			// 
			this.txt16.BackColor = System.Drawing.Color.White;
			this.txt16.DataField = "fax";
			this.txt16.DataType = TJSystem.Public.DataType.String;
			this.txt16.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.txt16.Location = new System.Drawing.Point(264, 152);
			this.txt16.Name = "txt16";
			this.txt16.Size = new System.Drawing.Size(112, 23);
			this.txt16.TabIndex = 139;
			this.txt16.Text = "";
			// 
			// label32
			// 
			this.label32.BackColor = System.Drawing.Color.Transparent;
			this.label32.Location = new System.Drawing.Point(584, 128);
			this.label32.Name = "label32";
			this.label32.Size = new System.Drawing.Size(48, 23);
			this.label32.TabIndex = 136;
			this.label32.Text = "城市";
			this.label32.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txt14
			// 
			this.txt14.BackColor = System.Drawing.Color.White;
			this.txt14.DataField = "city";
			this.txt14.DataType = TJSystem.Public.DataType.String;
			this.txt14.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.txt14.Location = new System.Drawing.Point(640, 128);
			this.txt14.Name = "txt14";
			this.txt14.Size = new System.Drawing.Size(104, 23);
			this.txt14.TabIndex = 137;
			this.txt14.Text = "";
			// 
			// label31
			// 
			this.label31.BackColor = System.Drawing.Color.Transparent;
			this.label31.ForeColor = System.Drawing.Color.Blue;
			this.label31.Location = new System.Drawing.Point(200, 128);
			this.label31.Name = "label31";
			this.label31.Size = new System.Drawing.Size(48, 23);
			this.label31.TabIndex = 134;
			this.label31.Text = "地区";
			this.label31.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label30
			// 
			this.label30.BackColor = System.Drawing.Color.Transparent;
			this.label30.Location = new System.Drawing.Point(40, 104);
			this.label30.Name = "label30";
			this.label30.Size = new System.Drawing.Size(48, 23);
			this.label30.TabIndex = 132;
			this.label30.Text = "地址";
			this.label30.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txt9
			// 
			this.txt9.BackColor = System.Drawing.Color.White;
			this.txt9.DataField = "Address";
			this.txt9.DataType = TJSystem.Public.DataType.String;
			this.txt9.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.txt9.Location = new System.Drawing.Point(96, 104);
			this.txt9.Name = "txt9";
			this.txt9.Size = new System.Drawing.Size(272, 23);
			this.txt9.TabIndex = 133;
			this.txt9.Text = "";
			// 
			// label29
			// 
			this.label29.BackColor = System.Drawing.Color.Transparent;
			this.label29.Location = new System.Drawing.Point(208, 80);
			this.label29.Name = "label29";
			this.label29.Size = new System.Drawing.Size(40, 23);
			this.label29.TabIndex = 130;
			this.label29.Text = "大类";
			this.label29.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txt6
			// 
			this.txt6.BackColor = System.Drawing.Color.White;
			this.txt6.DataField = "Client_Sort1";
			this.txt6.DataType = TJSystem.Public.DataType.String;
			this.txt6.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.txt6.Location = new System.Drawing.Point(264, 80);
			this.txt6.Name = "txt6";
			this.txt6.Size = new System.Drawing.Size(104, 23);
			this.txt6.TabIndex = 131;
			this.txt6.Text = "";
			// 
			// label28
			// 
			this.label28.BackColor = System.Drawing.Color.Transparent;
			this.label28.ForeColor = System.Drawing.Color.Blue;
			this.label28.Location = new System.Drawing.Point(384, 56);
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
			this.label27.Text = "客户类型";
			this.label27.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txt24
			// 
			this.txt24.BackColor = System.Drawing.Color.White;
			this.txt24.DataField = "Financial_Status";
			this.txt24.DataType = TJSystem.Public.DataType.String;
			this.txt24.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.txt24.Location = new System.Drawing.Point(96, 224);
			this.txt24.Multiline = true;
			this.txt24.Name = "txt24";
			this.txt24.Size = new System.Drawing.Size(648, 64);
			this.txt24.TabIndex = 125;
			this.txt24.Text = "";
			// 
			// label26
			// 
			this.label26.BackColor = System.Drawing.Color.Transparent;
			this.label26.Location = new System.Drawing.Point(8, 224);
			this.label26.Name = "label26";
			this.label26.Size = new System.Drawing.Size(80, 23);
			this.label26.TabIndex = 124;
			this.label26.Text = "信用评估";
			this.label26.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txt23
			// 
			this.txt23.BackColor = System.Drawing.Color.White;
			this.txt23.DataField = "account";
			this.txt23.DataType = TJSystem.Public.DataType.String;
			this.txt23.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.txt23.Location = new System.Drawing.Point(440, 200);
			this.txt23.Multiline = true;
			this.txt23.Name = "txt23";
			this.txt23.Size = new System.Drawing.Size(304, 24);
			this.txt23.TabIndex = 117;
			this.txt23.Text = "";
			// 
			// label22
			// 
			this.label22.BackColor = System.Drawing.Color.Transparent;
			this.label22.Location = new System.Drawing.Point(352, 200);
			this.label22.Name = "label22";
			this.label22.Size = new System.Drawing.Size(80, 23);
			this.label22.TabIndex = 116;
			this.label22.Text = "帐号";
			this.label22.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
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
			// txt28
			// 
			this.txt28.BackColor = System.Drawing.Color.White;
			this.txt28.DataField = "modifyon";
			this.txt28.DataType = TJSystem.Public.DataType.String;
			this.txt28.Enabled = false;
			this.txt28.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.txt28.Location = new System.Drawing.Point(640, 296);
			this.txt28.Name = "txt28";
			this.txt28.Size = new System.Drawing.Size(104, 23);
			this.txt28.TabIndex = 41;
			this.txt28.Text = "";
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
			// txt26
			// 
			this.txt26.BackColor = System.Drawing.Color.White;
			this.txt26.DataField = "createon";
			this.txt26.DataType = TJSystem.Public.DataType.String;
			this.txt26.Enabled = false;
			this.txt26.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.txt26.Location = new System.Drawing.Point(280, 296);
			this.txt26.Name = "txt26";
			this.txt26.Size = new System.Drawing.Size(96, 23);
			this.txt26.TabIndex = 39;
			this.txt26.Text = "";
			// 
			// label18
			// 
			this.label18.BackColor = System.Drawing.Color.Transparent;
			this.label18.ForeColor = System.Drawing.Color.Blue;
			this.label18.Location = new System.Drawing.Point(8, 176);
			this.label18.Name = "label18";
			this.label18.Size = new System.Drawing.Size(80, 23);
			this.label18.TabIndex = 37;
			this.label18.Text = "币种";
			this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label19
			// 
			this.label19.BackColor = System.Drawing.Color.Transparent;
			this.label19.ForeColor = System.Drawing.Color.Blue;
			this.label19.Location = new System.Drawing.Point(432, 176);
			this.label19.Name = "label19";
			this.label19.Size = new System.Drawing.Size(64, 23);
			this.label19.TabIndex = 36;
			this.label19.Text = "最低订货";
			this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txt21
			// 
			this.txt21.BackColor = System.Drawing.Color.White;
			this.txt21.DataField = "minOrder";
			this.txt21.DataType = TJSystem.Public.DataType.String;
			this.txt21.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.txt21.Location = new System.Drawing.Point(504, 176);
			this.txt21.Name = "txt21";
			this.txt21.Size = new System.Drawing.Size(240, 23);
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
			// txt22
			// 
			this.txt22.BackColor = System.Drawing.Color.White;
			this.txt22.DataField = "bank";
			this.txt22.DataType = TJSystem.Public.DataType.String;
			this.txt22.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.txt22.Location = new System.Drawing.Point(96, 200);
			this.txt22.Multiline = true;
			this.txt22.Name = "txt22";
			this.txt22.Size = new System.Drawing.Size(240, 24);
			this.txt22.TabIndex = 115;
			this.txt22.Text = "";
			// 
			// label16
			// 
			this.label16.BackColor = System.Drawing.Color.Transparent;
			this.label16.Location = new System.Drawing.Point(8, 152);
			this.label16.Name = "label16";
			this.label16.Size = new System.Drawing.Size(80, 23);
			this.label16.TabIndex = 30;
			this.label16.Text = "电话";
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
			this.label14.Text = "客户名称";
			this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label13
			// 
			this.label13.BackColor = System.Drawing.Color.Transparent;
			this.label13.ForeColor = System.Drawing.Color.Blue;
			this.label13.Location = new System.Drawing.Point(560, 80);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(72, 23);
			this.label13.TabIndex = 27;
			this.label13.Text = "客户来源";
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
			this.label11.Text = "客户代码";
			this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label10
			// 
			this.label10.BackColor = System.Drawing.Color.Transparent;
			this.label10.Location = new System.Drawing.Point(392, 80);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(40, 23);
			this.label10.TabIndex = 24;
			this.label10.Text = "小类";
			this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label9
			// 
			this.label9.BackColor = System.Drawing.Color.Transparent;
			this.label9.ForeColor = System.Drawing.Color.Blue;
			this.label9.Location = new System.Drawing.Point(8, 128);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(80, 23);
			this.label9.TabIndex = 23;
			this.label9.Text = "国家";
			this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label7
			// 
			this.label7.BackColor = System.Drawing.Color.Transparent;
			this.label7.ForeColor = System.Drawing.Color.Blue;
			this.label7.Location = new System.Drawing.Point(592, 56);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(40, 23);
			this.label7.TabIndex = 21;
			this.label7.Text = "状态";
			this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label6
			// 
			this.label6.BackColor = System.Drawing.Color.Transparent;
			this.label6.Location = new System.Drawing.Point(8, 200);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(80, 23);
			this.label6.TabIndex = 20;
			this.label6.Text = "银行";
			this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label5
			// 
			this.label5.BackColor = System.Drawing.Color.Transparent;
			this.label5.Location = new System.Drawing.Point(384, 152);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(48, 23);
			this.label5.TabIndex = 19;
			this.label5.Text = "电邮";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label4
			// 
			this.label4.BackColor = System.Drawing.Color.Transparent;
			this.label4.Location = new System.Drawing.Point(368, 104);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(64, 23);
			this.label4.TabIndex = 18;
			this.label4.Text = "邮政编码";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label3
			// 
			this.label3.BackColor = System.Drawing.Color.Transparent;
			this.label3.Location = new System.Drawing.Point(384, 128);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(48, 23);
			this.label3.TabIndex = 17;
			this.label3.Text = "省/州";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txt15
			// 
			this.txt15.BackColor = System.Drawing.Color.White;
			this.txt15.DataField = "tel";
			this.txt15.DataType = TJSystem.Public.DataType.String;
			this.txt15.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.txt15.Location = new System.Drawing.Point(96, 152);
			this.txt15.Name = "txt15";
			this.txt15.Size = new System.Drawing.Size(88, 23);
			this.txt15.TabIndex = 111;
			this.txt15.Text = "";
			// 
			// txt7
			// 
			this.txt7.BackColor = System.Drawing.Color.White;
			this.txt7.DataField = "Client_Sort2";
			this.txt7.DataType = TJSystem.Public.DataType.String;
			this.txt7.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.txt7.Location = new System.Drawing.Point(440, 80);
			this.txt7.Name = "txt7";
			this.txt7.Size = new System.Drawing.Size(112, 23);
			this.txt7.TabIndex = 106;
			this.txt7.Text = "";
			// 
			// txt25
			// 
			this.txt25.BackColor = System.Drawing.Color.White;
			this.txt25.DataField = "createBy";
			this.txt25.DataType = TJSystem.Public.DataType.String;
			this.txt25.Enabled = false;
			this.txt25.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.txt25.Location = new System.Drawing.Point(96, 296);
			this.txt25.Name = "txt25";
			this.txt25.Size = new System.Drawing.Size(96, 23);
			this.txt25.TabIndex = 12;
			this.txt25.Text = "";
			// 
			// txt17
			// 
			this.txt17.BackColor = System.Drawing.Color.White;
			this.txt17.DataField = "Email";
			this.txt17.DataType = TJSystem.Public.DataType.String;
			this.txt17.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.txt17.Location = new System.Drawing.Point(440, 152);
			this.txt17.Name = "txt17";
			this.txt17.Size = new System.Drawing.Size(112, 23);
			this.txt17.TabIndex = 112;
			this.txt17.Text = "";
			// 
			// txt27
			// 
			this.txt27.BackColor = System.Drawing.Color.White;
			this.txt27.DataField = "modifyBy";
			this.txt27.DataType = TJSystem.Public.DataType.String;
			this.txt27.Enabled = false;
			this.txt27.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.txt27.Location = new System.Drawing.Point(472, 296);
			this.txt27.Name = "txt27";
			this.txt27.Size = new System.Drawing.Size(96, 23);
			this.txt27.TabIndex = 9;
			this.txt27.Text = "";
			// 
			// txt5
			// 
			this.txt5.BackColor = System.Drawing.Color.White;
			this.txt5.DataField = "Client_name";
			this.txt5.DataType = TJSystem.Public.DataType.String;
			this.txt5.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.txt5.Location = new System.Drawing.Point(96, 80);
			this.txt5.Name = "txt5";
			this.txt5.Size = new System.Drawing.Size(88, 23);
			this.txt5.TabIndex = 105;
			this.txt5.Text = "";
			// 
			// txt10
			// 
			this.txt10.BackColor = System.Drawing.Color.White;
			this.txt10.DataField = "PostCode";
			this.txt10.DataType = TJSystem.Public.DataType.String;
			this.txt10.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.txt10.Location = new System.Drawing.Point(440, 104);
			this.txt10.Name = "txt10";
			this.txt10.Size = new System.Drawing.Size(104, 23);
			this.txt10.TabIndex = 108;
			this.txt10.Text = "";
			// 
			// txt1
			// 
			this.txt1.BackColor = System.Drawing.Color.White;
			this.txt1.DataField = "Client_id";
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
			this.txt13.DataField = "province";
			this.txt13.DataType = TJSystem.Public.DataType.String;
			this.txt13.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.txt13.Location = new System.Drawing.Point(440, 128);
			this.txt13.Name = "txt13";
			this.txt13.Size = new System.Drawing.Size(112, 23);
			this.txt13.TabIndex = 110;
			this.txt13.Text = "";
			this.txt13.TextChanged += new System.EventHandler(this.txt11_TextChanged);
			// 
			// company_name_cn
			// 
			this.company_name_cn.Format = "";
			this.company_name_cn.FormatInfo = null;
			this.company_name_cn.HeaderText = "中文名称";
			this.company_name_cn.MappingName = "company_name_cn";
			this.company_name_cn.NullText = "";
			this.company_name_cn.Width = 75;
			// 
			// postcode
			// 
			this.postcode.Format = "";
			this.postcode.FormatInfo = null;
			this.postcode.HeaderText = "邮政编码";
			this.postcode.MappingName = "postcode";
			this.postcode.NullText = "";
			this.postcode.Width = 75;
			// 
			// email1
			// 
			this.email1.Format = "";
			this.email1.FormatInfo = null;
			this.email1.HeaderText = "电子邮件1";
			this.email1.MappingName = "email1";
			this.email1.NullText = "";
			this.email1.Width = 75;
			// 
			// frmClientCustomers
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
			this.Name = "frmClientCustomers";
			this.Text = "客户管理";
			this.panel1.ResumeLayout(false);
			this.panel3.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).EndInit();
			this.panel4.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		private void txt11_TextChanged(object sender, System.EventArgs e)
		{
		
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
				TJSystem.Public.PublicStatic.formName = "客户管理";
			}
			base.OnClosing (e);
		}

		private void linkLabel2_LinkClicked(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
		{
			if(this.txt1.Text.Trim().Equals(""))
			{
				MessageBox.Show("未选择客户代码","Error",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
				return;
			}
			frmClientCustomersContact frm = new frmClientCustomersContact(this.txt1.Text);
			frm.ShowDialog();
		}
		
	}
}

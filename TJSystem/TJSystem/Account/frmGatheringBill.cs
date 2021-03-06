using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace TJSystem.Account
{
	/// <summary>
	/// </summary>
	public class frmGatheringBill : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Panel panel3;
		private TJSystem.UC.PriToolBar priToolBar1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label1;
		/// <summary>
		/// </summary>
		private System.ComponentModel.Container components = null;
		public static System.Windows.Forms.Form frmCurrent = null ;

		private string _statusType = null;
		private string _table = null;
		private System.Windows.Forms.Label label10;
		private TJSystem.Classes.PriTextBox priTextBox8;
		private TJSystem.Classes.PriTextBox priTextBox7;
		private System.Windows.Forms.LinkLabel linkLabel1;
		private TJSystem.Classes.PriTextBox priTextBox6;
		private TJSystem.Classes.PriTextBox priTextBox4;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label2;
		private TJSystem.Classes.PriTextBox priTextBox1;
		private TJSystem.Classes.PriComboBox priComboBox4;
		private TJSystem.Classes.PriComboBox priComboBox3;
		private TJSystem.Classes.PriComboBox priComboBox5;
		private TJSystem.Classes.PriDateTimePicker dateTimePicker1;
		private TJSystem.Classes.PriComboBox priComboBox2;
		private TJSystem.Classes.PriComboBox priComboBox1;
		private TJSystem.Classes.PriTextBox priTextBox2;
		private System.Windows.Forms.Label label25;
		private TJSystem.Classes.PriComboBox comboBox1;
		private TJSystem.Classes.PriTextBox priTextBox21;
		private TJSystem.Classes.PriTextBox priTextBox20;
		private System.Windows.Forms.Label label22;
		private System.Windows.Forms.Label label21;
		private TJSystem.Classes.PriTextBox priTextBox19;
		private TJSystem.Classes.PriTextBox priTextBox18;
		private System.Windows.Forms.Label label20;
		private System.Windows.Forms.Label label19;
		private TJSystem.Classes.PriTextBox priTextBox16;
		private TJSystem.Classes.PriTextBox priTextBox15;
		private System.Windows.Forms.Label label18;
		private System.Windows.Forms.Label label17;
		private System.Windows.Forms.Label label16;
		private System.Windows.Forms.Label label15;
		private TJSystem.Classes.PriTextBox priTextBox13;
		private TJSystem.Classes.PriTextBox priTextBox12;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.Label label23;
		private TJSystem.Classes.PriTextBox priTextBox11;
		private TJSystem.Classes.PriTextBox priTextBox10;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.DataGrid dataGrid1;
		private System.Windows.Forms.DataGridTableStyle dataGridTableStyle1;
		private System.Windows.Forms.Panel panel4;
		private System.Windows.Forms.DataGridTextBoxColumn ga_code;
		private System.Windows.Forms.DataGridTextBoxColumn ga_date;
		private System.Windows.Forms.DataGridTextBoxColumn Status;
		private System.Windows.Forms.DataGridTextBoxColumn Client_id;
		private System.Windows.Forms.DataGridTextBoxColumn Client_name;
		private System.Windows.Forms.DataGridTextBoxColumn currency;
		private System.Windows.Forms.DataGridTextBoxColumn Amount;
		private System.Windows.Forms.DataGridTextBoxColumn exchange;
		private System.Windows.Forms.DataGridTextBoxColumn Bank;
		private System.Windows.Forms.DataGridTextBoxColumn Account;
		private System.Windows.Forms.DataGridTextBoxColumn bank_number;
		private System.Windows.Forms.DataGridTextBoxColumn paymode_id;
		private System.Windows.Forms.DataGridTextBoxColumn payer;
		private System.Windows.Forms.DataGridTextBoxColumn remark;
		private System.Windows.Forms.DataGridTextBoxColumn cashier;
		private System.Windows.Forms.DataGridTextBoxColumn lister;
		private System.Windows.Forms.DataGridTextBoxColumn accounter;
		private System.Windows.Forms.DataGridTextBoxColumn director;
		private System.Windows.Forms.DataGridTextBoxColumn createOn;
		private System.Windows.Forms.DataGridTextBoxColumn createBy;
		private System.Windows.Forms.DataGridTextBoxColumn modifyOn;
		private System.Windows.Forms.DataGridTextBoxColumn modifyBy;
		private string _PK = null;


		public frmGatheringBill()
		{
			InitializeComponent();

			InitializeGridStyle();

			

			_statusType = "account";

			TJSystem.Public.PublicStatic.setBackgroundImg(this.panel1,this.panel1.GetType().ToString(),"images\\bg.gif");
			TJSystem.Public.PublicStatic.setBackgroundImg(this.panel2,this.panel1.GetType().ToString(),"");
			TJSystem.Public.PublicStatic.setBackgroundImg(this.panel3,this.panel1.GetType().ToString(),"");
			TJSystem.Public.PublicStatic.setBackgroundImg(this.panel4,this.panel1.GetType().ToString(),"");

			InitialFormData();

			System.Text.StringBuilder sb = new System.Text.StringBuilder();
			sb.Append("select ga_code,doc_no,ga_date,Status,Client_id,Client_name,Bank,Account,bank_number,paymode_id,exchange,Currency,Amount,");
			sb.Append("payyee,lister,cashier,accounter,director,remark,CreateOn,CreateBy,modifyOn,modifyBy  from finance_gathering");
			sb.Append(" order by ga_code");
			this.InitialGrid(sb.ToString());

			priToolBar1.setCurrentForm = this;
			_table = "finance_gathering";
			_PK = "ga_code";
			priToolBar1.Initial(_table,_PK,sb.ToString());
			priToolBar1.BeforeButtonClickEvent += new TJSystem.UC.PriToolBar.BeforeButotnClick(this.BeforeButtonClick);
			priToolBar1.AfterButtonClickEvent += new TJSystem.UC.PriToolBar.AfterButtonClick(this.AfterButtonClick);

			this.priToolBar1.setButtonVisibleFalse();;
			this.priToolBar1.setButtonVisible("012345689");
			setDisable();
		}

		#region GridIntial
		private void InitializeGridStyle()
		{
			this.ga_code = new System.Windows.Forms.DataGridTextBoxColumn();
			this.ga_date = new System.Windows.Forms.DataGridTextBoxColumn();
			this.Status = new System.Windows.Forms.DataGridTextBoxColumn();
			this.Client_id = new System.Windows.Forms.DataGridTextBoxColumn();
			this.Client_name = new System.Windows.Forms.DataGridTextBoxColumn();
			this.currency = new System.Windows.Forms.DataGridTextBoxColumn();
			this.Amount = new System.Windows.Forms.DataGridTextBoxColumn();
			this.exchange = new System.Windows.Forms.DataGridTextBoxColumn();
			this.Bank = new System.Windows.Forms.DataGridTextBoxColumn();
			this.Account = new System.Windows.Forms.DataGridTextBoxColumn();
			this.bank_number = new System.Windows.Forms.DataGridTextBoxColumn();
			this.paymode_id = new System.Windows.Forms.DataGridTextBoxColumn();
			this.payer = new System.Windows.Forms.DataGridTextBoxColumn();
			this.remark = new System.Windows.Forms.DataGridTextBoxColumn();
			this.cashier = new System.Windows.Forms.DataGridTextBoxColumn();
			this.lister = new System.Windows.Forms.DataGridTextBoxColumn();
			this.accounter = new System.Windows.Forms.DataGridTextBoxColumn();
			this.director = new System.Windows.Forms.DataGridTextBoxColumn();
			this.createOn = new System.Windows.Forms.DataGridTextBoxColumn();
			this.createBy = new System.Windows.Forms.DataGridTextBoxColumn();
			this.modifyOn = new System.Windows.Forms.DataGridTextBoxColumn();
			this.modifyBy = new System.Windows.Forms.DataGridTextBoxColumn();

			#region SETTING
			// 
			// ga_code
			// 
			this.ga_code.Alignment = System.Windows.Forms.HorizontalAlignment.Center;
			this.ga_code.Format = "";
			this.ga_code.FormatInfo = null;
			this.ga_code.HeaderText = "付款单号";
			this.ga_code.MappingName = "ga_code";
			this.ga_code.Width = 75;
			// 
			// ga_date
			// 
			this.ga_date.Alignment = System.Windows.Forms.HorizontalAlignment.Center;
			this.ga_date.Format = "";
			this.ga_date.FormatInfo = null;
			this.ga_date.HeaderText = "收款日期";
			this.ga_date.MappingName = "ga_date";
			this.ga_date.Width = 75;
			// 
			// Status
			// 
			this.Status.Alignment = System.Windows.Forms.HorizontalAlignment.Center;
			this.Status.Format = "";
			this.Status.FormatInfo = null;
			this.Status.HeaderText = "状态";
			this.Status.MappingName = "Status";
			this.Status.Width = 75;
			// 
			// Client_id
			// 
			this.Client_id.Alignment = System.Windows.Forms.HorizontalAlignment.Center;
			this.Client_id.Format = "";
			this.Client_id.FormatInfo = null;
			this.Client_id.HeaderText = "供应商号码";
			this.Client_id.MappingName = "Client_id";
			this.Client_id.Width = 75;
			// 
			// Client_name
			// 
			this.Client_name.Alignment = System.Windows.Forms.HorizontalAlignment.Center;
			this.Client_name.Format = "";
			this.Client_name.FormatInfo = null;
			this.Client_name.HeaderText = "供应商名称";
			this.Client_name.MappingName = "Client_name";
			this.Client_name.Width = 75;
			// 
			// currency
			// 
			this.currency.Alignment = System.Windows.Forms.HorizontalAlignment.Center;
			this.currency.Format = "";
			this.currency.FormatInfo = null;
			this.currency.HeaderText = "币种";
			this.currency.MappingName = "currency";
			this.currency.Width = 75;
			// 
			// Amount
			// 
			this.Amount.Alignment = System.Windows.Forms.HorizontalAlignment.Center;
			this.Amount.Format = "";
			this.Amount.FormatInfo = null;
			this.Amount.HeaderText = "总金额";
			this.Amount.MappingName = "Amount";
			this.Amount.Width = 75;
			// 
			// exchange
			// 
			this.exchange.Alignment = System.Windows.Forms.HorizontalAlignment.Center;
			this.exchange.Format = "";
			this.exchange.FormatInfo = null;
			this.exchange.HeaderText = "汇率";
			this.exchange.MappingName = "exchange";
			this.exchange.Width = 75;
			// 
			// Bank
			// 
			this.Bank.Alignment = System.Windows.Forms.HorizontalAlignment.Center;
			this.Bank.Format = "";
			this.Bank.FormatInfo = null;
			this.Bank.HeaderText = "银行";
			this.Bank.MappingName = "Bank";
			this.Bank.Width = 75;
			// 
			// Account
			// 
			this.Account.Alignment = System.Windows.Forms.HorizontalAlignment.Center;
			this.Account.Format = "";
			this.Account.FormatInfo = null;
			this.Account.HeaderText = "帐号";
			this.Account.MappingName = "Account";
			this.Account.Width = 75;
			// 
			// bank_number
			// 
			this.bank_number.Alignment = System.Windows.Forms.HorizontalAlignment.Center;
			this.bank_number.Format = "";
			this.bank_number.FormatInfo = null;
			this.bank_number.HeaderText = "银行流水号";
			this.bank_number.MappingName = "bank_number";
			this.bank_number.Width = 75;
			// 
			// paymode_id
			// 
			this.paymode_id.Alignment = System.Windows.Forms.HorizontalAlignment.Center;
			this.paymode_id.Format = "";
			this.paymode_id.FormatInfo = null;
			this.paymode_id.HeaderText = "收款方式";
			this.paymode_id.MappingName = "paymode_id";
			this.paymode_id.Width = 75;
			// 
			// payer
			// 
			this.payer.Alignment = System.Windows.Forms.HorizontalAlignment.Center;
			this.payer.Format = "";
			this.payer.FormatInfo = null;
			this.payer.HeaderText = "收款人";
			this.payer.MappingName = "payer";
			this.payer.Width = 75;
			// 
			// remark
			// 
			this.remark.Alignment = System.Windows.Forms.HorizontalAlignment.Center;
			this.remark.Format = "";
			this.remark.FormatInfo = null;
			this.remark.HeaderText = "备注";
			this.remark.MappingName = "remark";
			this.remark.Width = 75;
			// 
			// cashier
			// 
			this.cashier.Alignment = System.Windows.Forms.HorizontalAlignment.Center;
			this.cashier.Format = "";
			this.cashier.FormatInfo = null;
			this.cashier.HeaderText = "出纳";
			this.cashier.MappingName = "cashier";
			this.cashier.Width = 75;
			// 
			// lister
			// 
			this.lister.Alignment = System.Windows.Forms.HorizontalAlignment.Center;
			this.lister.Format = "";
			this.lister.FormatInfo = null;
			this.lister.HeaderText = "制表";
			this.lister.MappingName = "lister";
			this.lister.Width = 75;
			// 
			// accounter
			// 
			this.accounter.Alignment = System.Windows.Forms.HorizontalAlignment.Center;
			this.accounter.Format = "";
			this.accounter.FormatInfo = null;
			this.accounter.HeaderText = "会计";
			this.accounter.MappingName = "accounter";
			this.accounter.Width = 75;
			// 
			// director
			// 
			this.director.Alignment = System.Windows.Forms.HorizontalAlignment.Center;
			this.director.Format = "";
			this.director.FormatInfo = null;
			this.director.HeaderText = "主管";
			this.director.MappingName = "director";
			this.director.Width = 75;
			// 
			// createOn
			// 
			this.createOn.Alignment = System.Windows.Forms.HorizontalAlignment.Center;
			this.createOn.Format = "";
			this.createOn.FormatInfo = null;
			this.createOn.HeaderText = "创建日期";
			this.createOn.MappingName = "createOn";
			this.createOn.Width = 75;
			// 
			// createBy
			// 
			this.createBy.Alignment = System.Windows.Forms.HorizontalAlignment.Center;
			this.createBy.Format = "";
			this.createBy.FormatInfo = null;
			this.createBy.HeaderText = "创建者";
			this.createBy.MappingName = "createBy";
			this.createBy.Width = 75;
			// 
			// modifyOn
			// 
			this.modifyOn.Alignment = System.Windows.Forms.HorizontalAlignment.Center;
			this.modifyOn.Format = "";
			this.modifyOn.FormatInfo = null;
			this.modifyOn.HeaderText = "最后修改时间";
			this.modifyOn.MappingName = "modifyOn";
			this.modifyOn.Width = 75;
			// 
			// modifyBy
			// 
			this.modifyBy.Alignment = System.Windows.Forms.HorizontalAlignment.Center;
			this.modifyBy.Format = "";
			this.modifyBy.FormatInfo = null;
			this.modifyBy.HeaderText = "最后修改人";
			this.modifyBy.MappingName = "modifyBy";
			this.modifyBy.Width = 75;
			#endregion
			this.dataGridTableStyle1.GridColumnStyles.AddRange(new System.Windows.Forms.DataGridColumnStyle[] {
																												  this.ga_code,
																												  this.ga_date,
																												  this.Status,
																												  this.Client_id,
																												  this.Client_name,
																												  this.currency,
																												  this.Amount,
																												  this.exchange,
																												  this.Bank,
																												  this.Account,
																												  this.bank_number,
																												  this.paymode_id,
																												  this.payer,
																												  this.remark,
																												  this.cashier,
																												  this.lister,
																												  this.accounter,
																												  this.director,
																												  this.createOn,
																												  this.createBy,
																												  this.modifyOn,
																												  this.modifyBy});
		}
		#endregion

		private void setDisable()
		{
			this.priComboBox1.Enabled = false;
			this.priComboBox2.Enabled = false;
			this.comboBox1.Enabled = false;
			this.priTextBox1.Enabled = false;
			this.priTextBox10.Enabled = false;
			this.priTextBox11.Enabled = false;
			this.priTextBox12.Enabled = false;
			this.priTextBox13.Enabled = false;
			this.priTextBox15.Enabled = false;
			this.priTextBox16.Enabled = false;
			this.priComboBox5.Enabled = false;
			this.priTextBox18.Enabled = false;
			this.priTextBox19.Enabled = false;
			this.priTextBox20.Enabled = false;
			this.priTextBox21.Enabled = false;
			
			this.priTextBox2.Enabled = false;
			this.priTextBox4.Enabled = false;
			this.priComboBox3.Enabled = false;
			this.priComboBox4.Enabled = false;
			this.priTextBox6.Enabled = false;
			this.priTextBox7.Enabled = false;
			this.priTextBox8.Enabled = false;			
			this.dateTimePicker1.Enabled = false;
			
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
			System.Text.StringBuilder sb = new System.Text.StringBuilder();
			sb.Append("数据验证错误：\r\n");

			if(sqltype.Equals("insert"))
			{
				if(TJSystem.Public.PublicStatic.IsExsist(_table,_PK,this.priToolBar1))
				{
					sb.Append("  系统中已存在该收款单，请重新命名收款单编号");
					TJSystem.Public.PublicStatic.ShowMessage(TJSystem.Public.MessageType.Error,sb.ToString());
					return false;
				}
			}

			if(sqltype.Equals("insert"))
			{
				
			}	
			return true;
		}

		private void AfterButtonClick(string sqltype)
		{
			if(sqltype.Equals("insert"))
			{
				this.priComboBox1.Enabled = true;
				this.priComboBox2.Enabled = true;
				this.comboBox1.Enabled = true;
				this.priTextBox1.Enabled = true;
				
				this.priTextBox11.Enabled = true;
				this.priTextBox12.Enabled = true;				
				this.priTextBox15.Enabled = true;
				this.priComboBox5.Enabled = true;
				this.priTextBox18.Enabled = true;				
				this.priTextBox20.Enabled = true;		
				this.priTextBox2.Enabled = true;
				this.priComboBox3.Enabled = true;
				this.priComboBox4.Enabled = true;
				this.priTextBox6.Enabled = true;
				this.priTextBox7.Enabled = true;
				this.dateTimePicker1.Enabled = true;
				
				this.priComboBox1.Text = "";
				this.priComboBox2.Text = "";
				this.comboBox1.Text = "";
				this.priTextBox1.Text = "";
				this.priTextBox10.Text = "";
				this.priTextBox11.Text = "";
				this.priTextBox12.Text = "";				
				this.priTextBox15.Text = "";
				this.priTextBox16.Text = "";
				this.priComboBox5.Text = "";
				this.priTextBox18.Text = "";				
				this.priTextBox20.Text = "";
				this.priTextBox2.Text = "";
				this.priTextBox4.Text = "";
				this.priComboBox3.Text = "";
				this.priTextBox6.Text = "";
				this.priTextBox7.Text = "";
				this.dateTimePicker1.Value = System.DateTime.Now;
			}
			else if(sqltype.Equals("update"))
			{
				this.priComboBox1.Enabled = true;
				this.priComboBox2.Enabled = true;
				this.comboBox1.Enabled = true;
				this.priTextBox1.Enabled = false;
				
				this.priTextBox11.Enabled = true;
				this.priTextBox12.Enabled = true;				
				this.priTextBox15.Enabled = true;
				this.priComboBox5.Enabled = true;
				this.priTextBox18.Enabled = true;				
				this.priTextBox20.Enabled = true;	
				this.priTextBox2.Enabled = true;
				this.priComboBox3.Enabled = true;
				this.priComboBox4.Enabled = true;
				this.priTextBox6.Enabled = true;
				this.priTextBox7.Enabled = true;
				this.dateTimePicker1.Enabled = true;
			}
		}

		private void InitialFormData()
		{
			DataTable dtcpy = null;
			DataRow dr = null;
			string sql = "select CLIENT_ID,CLIENT_ID+' '+CLIENT_NAME as CLIENT_NAME from basic_client order by Client_id";
			DataTable dt = TJSystem.Public.PublicStatic.db.GetDataTable(sql);
			dr = dt.NewRow() ;
			dr[0] = "" ;
			dr[1] = "" ;
			dt.Rows.InsertAt(dr,0) ;
			dtcpy = dt.Copy();
			this.comboBox1.DataSource = dtcpy.DefaultView;
			this.comboBox1.ValueMember = "CLIENT_ID";
			this.comboBox1.DisplayMember = "CLIENT_NAME";

			sql = "select STATUS_ID,STATUS_NAME from p_status where status_type='" + this._statusType + "' order by status_id";
			dt = TJSystem.Public.PublicStatic.db.GetDataTable(sql);
			dr = dt.NewRow() ;
			dr[0] = "" ;
			dr[1] = "" ;
			dt.Rows.InsertAt(dr,0) ;
			dtcpy = dt.Copy();
			this.priComboBox1.DataSource = dtcpy.DefaultView;
			this.priComboBox1.ValueMember = "STATUS_ID";
			this.priComboBox1.DisplayMember = "STATUS_NAME";

			sql = "select CURRENCY_CODE,CURRENCY_CODE+' '+CURRENCY_NAMECN as CURRENCY_NAMECN from p_currency order by CURRENCY_CODE";
			dt = TJSystem.Public.PublicStatic.db.GetDataTable(sql);
			dr = dt.NewRow() ;
			dr[0] = "" ;
			dr[1] = "" ;
			dt.Rows.InsertAt(dr,0) ;
			dtcpy = dt.Copy();
			this.priComboBox2.DataSource = dtcpy.DefaultView;
			this.priComboBox2.ValueMember = "CURRENCY_CODE";
			this.priComboBox2.DisplayMember = "CURRENCY_NAMECN";

			sql = "select BANK_ID,BANK_ID+' '+BANK_NAME as BANK_NAME from basic_company_bank where company_id='" + TJSystem.Public.PublicStatic.CompanyID + "' order by bank_id";
			dt = TJSystem.Public.PublicStatic.db.GetDataTable(sql);
			dr = dt.NewRow() ;
			dr[0] = "" ;
			dr[1] = "" ;
			dt.Rows.InsertAt(dr,0) ;
			dtcpy = dt.Copy();
			this.priComboBox3.DataSource = dtcpy.DefaultView;
			this.priComboBox3.ValueMember = "BANK_ID";
			this.priComboBox3.DisplayMember = "BANK_NAME";

			sql = "select paymode_id,paymode_id+' '+Paymode_Name_cn as Paymode_Name_cn from p_paymode order by paymode_id";
			dt = TJSystem.Public.PublicStatic.db.GetDataTable(sql);
			dr = dt.NewRow() ;
			dr[0] = "" ;
			dr[1] = "" ;
			dt.Rows.InsertAt(dr,0) ;
			dtcpy = dt.Copy();
			this.priComboBox5.DataSource = dtcpy.DefaultView;
			this.priComboBox5.ValueMember = "paymode_id";
			this.priComboBox5.DisplayMember = "Paymode_Name_cn";

			sql = "select a.doc_no,a.doc_no+' '+b.feetype_name+' '+crm_id+'('+remark+')' as doc_desc ";
			sql += " from finance_doc a";
			sql += " left join p_feetype b on a.doc_type=b.feetype_id ";
			sql += " where a.payrec_type='R'";
			sql += " order by a.doc_no";
			dt = TJSystem.Public.PublicStatic.db.GetDataTable(sql);
			dr = dt.NewRow() ;
			dr[0] = "" ;
			dr[1] = "" ;
			dt.Rows.InsertAt(dr,0) ;
			dtcpy = dt.Copy();
			this.priComboBox4.DataSource = dtcpy.DefaultView;
			this.priComboBox4.ValueMember = "doc_no";
			this.priComboBox4.DisplayMember = "doc_desc";
		}

		private void InitialGrid(string sql)
		{		
			DataTable dt = TJSystem.Public.PublicStatic.db.GetDataTable(sql);
			dt.TableName = "finance_gathering";
			this.dataGridTableStyle1.DataGrid.DataSource = dt.DefaultView;
		}

		/// <summary>

		/// </summary>
		protected override void Dispose( bool disposing )
		{
			frmCurrent = null ;
			if( disposing )
			{
				if(components != null)
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
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
				TJSystem.Public.PublicStatic.formName = "收款单";
			}
			base.OnClosing (e);
		}

		#region Windows Form 
		/// <summary>
		
		/// </summary>
		private void InitializeComponent()
		{
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(frmGatheringBill));
			this.panel3 = new System.Windows.Forms.Panel();
			this.priToolBar1 = new TJSystem.UC.PriToolBar();
			this.panel2 = new System.Windows.Forms.Panel();
			this.panel4 = new System.Windows.Forms.Panel();
			this.priTextBox20 = new TJSystem.Classes.PriTextBox();
			this.label20 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.label13 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.priTextBox2 = new TJSystem.Classes.PriTextBox();
			this.label21 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.priComboBox5 = new TJSystem.Classes.PriComboBox();
			this.priComboBox2 = new TJSystem.Classes.PriComboBox();
			this.priComboBox1 = new TJSystem.Classes.PriComboBox();
			this.priTextBox19 = new TJSystem.Classes.PriTextBox();
			this.priTextBox13 = new TJSystem.Classes.PriTextBox();
			this.label11 = new System.Windows.Forms.Label();
			this.priTextBox7 = new TJSystem.Classes.PriTextBox();
			this.label18 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.priTextBox18 = new TJSystem.Classes.PriTextBox();
			this.priTextBox11 = new TJSystem.Classes.PriTextBox();
			this.priTextBox16 = new TJSystem.Classes.PriTextBox();
			this.comboBox1 = new TJSystem.Classes.PriComboBox();
			this.dateTimePicker1 = new TJSystem.Classes.PriDateTimePicker();
			this.label25 = new System.Windows.Forms.Label();
			this.priComboBox4 = new TJSystem.Classes.PriComboBox();
			this.priTextBox8 = new TJSystem.Classes.PriTextBox();
			this.priComboBox3 = new TJSystem.Classes.PriComboBox();
			this.label16 = new System.Windows.Forms.Label();
			this.label22 = new System.Windows.Forms.Label();
			this.label15 = new System.Windows.Forms.Label();
			this.priTextBox21 = new TJSystem.Classes.PriTextBox();
			this.label14 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.label19 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.priTextBox15 = new TJSystem.Classes.PriTextBox();
			this.label23 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.priTextBox12 = new TJSystem.Classes.PriTextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.priTextBox1 = new TJSystem.Classes.PriTextBox();
			this.label12 = new System.Windows.Forms.Label();
			this.priTextBox10 = new TJSystem.Classes.PriTextBox();
			this.linkLabel1 = new System.Windows.Forms.LinkLabel();
			this.priTextBox4 = new TJSystem.Classes.PriTextBox();
			this.label17 = new System.Windows.Forms.Label();
			this.priTextBox6 = new TJSystem.Classes.PriTextBox();
			this.dataGrid1 = new System.Windows.Forms.DataGrid();
			this.dataGridTableStyle1 = new System.Windows.Forms.DataGridTableStyle();
			this.panel1 = new System.Windows.Forms.Panel();
			this.label1 = new System.Windows.Forms.Label();
			this.panel3.SuspendLayout();
			this.panel2.SuspendLayout();
			this.panel4.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).BeginInit();
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
			this.panel3.TabIndex = 21;
			// 
			// priToolBar1
			// 
			this.priToolBar1.DGEnable = true;
			this.priToolBar1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.priToolBar1.Location = new System.Drawing.Point(0, -2);
			this.priToolBar1.Name = "priToolBar1";
			this.priToolBar1.setCurrentForm = null;
			this.priToolBar1.Size = new System.Drawing.Size(788, 38);
			this.priToolBar1.TabIndex = 0;
			// 
			// panel2
			// 
			this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
			this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.panel2.Controls.Add(this.panel4);
			this.panel2.Controls.Add(this.dataGrid1);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel2.Location = new System.Drawing.Point(0, 45);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(792, 521);
			this.panel2.TabIndex = 20;
			// 
			// panel4
			// 
			this.panel4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel4.BackgroundImage")));
			this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.panel4.Controls.Add(this.priTextBox20);
			this.panel4.Controls.Add(this.label20);
			this.panel4.Controls.Add(this.label9);
			this.panel4.Controls.Add(this.label13);
			this.panel4.Controls.Add(this.label7);
			this.panel4.Controls.Add(this.priTextBox2);
			this.panel4.Controls.Add(this.label21);
			this.panel4.Controls.Add(this.label6);
			this.panel4.Controls.Add(this.label8);
			this.panel4.Controls.Add(this.priComboBox5);
			this.panel4.Controls.Add(this.priComboBox2);
			this.panel4.Controls.Add(this.priComboBox1);
			this.panel4.Controls.Add(this.priTextBox19);
			this.panel4.Controls.Add(this.priTextBox13);
			this.panel4.Controls.Add(this.label11);
			this.panel4.Controls.Add(this.priTextBox7);
			this.panel4.Controls.Add(this.label18);
			this.panel4.Controls.Add(this.label4);
			this.panel4.Controls.Add(this.priTextBox18);
			this.panel4.Controls.Add(this.priTextBox11);
			this.panel4.Controls.Add(this.priTextBox16);
			this.panel4.Controls.Add(this.comboBox1);
			this.panel4.Controls.Add(this.dateTimePicker1);
			this.panel4.Controls.Add(this.label25);
			this.panel4.Controls.Add(this.priComboBox4);
			this.panel4.Controls.Add(this.priTextBox8);
			this.panel4.Controls.Add(this.priComboBox3);
			this.panel4.Controls.Add(this.label16);
			this.panel4.Controls.Add(this.label22);
			this.panel4.Controls.Add(this.label15);
			this.panel4.Controls.Add(this.priTextBox21);
			this.panel4.Controls.Add(this.label14);
			this.panel4.Controls.Add(this.label10);
			this.panel4.Controls.Add(this.label19);
			this.panel4.Controls.Add(this.label2);
			this.panel4.Controls.Add(this.priTextBox15);
			this.panel4.Controls.Add(this.label23);
			this.panel4.Controls.Add(this.label3);
			this.panel4.Controls.Add(this.priTextBox12);
			this.panel4.Controls.Add(this.label5);
			this.panel4.Controls.Add(this.priTextBox1);
			this.panel4.Controls.Add(this.label12);
			this.panel4.Controls.Add(this.priTextBox10);
			this.panel4.Controls.Add(this.linkLabel1);
			this.panel4.Controls.Add(this.priTextBox4);
			this.panel4.Controls.Add(this.label17);
			this.panel4.Controls.Add(this.priTextBox6);
			this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel4.Font = new System.Drawing.Font("宋体", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.panel4.Location = new System.Drawing.Point(0, 0);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(788, 240);
			this.panel4.TabIndex = 0;
			// 
			// priTextBox20
			// 
			this.priTextBox20.BackColor = System.Drawing.Color.White;
			this.priTextBox20.DataField = "payyee";
			this.priTextBox20.DataType = TJSystem.Public.DataType.String;
			this.priTextBox20.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.priTextBox20.Location = new System.Drawing.Point(488, 120);
			this.priTextBox20.Name = "priTextBox20";
			this.priTextBox20.Size = new System.Drawing.Size(120, 23);
			this.priTextBox20.TabIndex = 135;
			this.priTextBox20.Text = "";
			// 
			// label20
			// 
			this.label20.AutoSize = true;
			this.label20.BackColor = System.Drawing.Color.Transparent;
			this.label20.Location = new System.Drawing.Point(368, 208);
			this.label20.Name = "label20";
			this.label20.Size = new System.Drawing.Size(85, 18);
			this.label20.TabIndex = 130;
			this.label20.Text = "最后修改时间";
			this.label20.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.BackColor = System.Drawing.Color.Transparent;
			this.label9.Location = new System.Drawing.Point(24, 208);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(58, 18);
			this.label9.TabIndex = 104;
			this.label9.Text = "创建日期";
			this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label13
			// 
			this.label13.AutoSize = true;
			this.label13.BackColor = System.Drawing.Color.Transparent;
			this.label13.Location = new System.Drawing.Point(616, 69);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(32, 18);
			this.label13.TabIndex = 117;
			this.label13.Text = "会计";
			this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.BackColor = System.Drawing.Color.Transparent;
			this.label7.Location = new System.Drawing.Point(48, 152);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(32, 18);
			this.label7.TabIndex = 102;
			this.label7.Text = "备注";
			this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// priTextBox2
			// 
			this.priTextBox2.BackColor = System.Drawing.Color.White;
			this.priTextBox2.DataField = "lister";
			this.priTextBox2.DataType = TJSystem.Public.DataType.String;
			this.priTextBox2.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.priTextBox2.Location = new System.Drawing.Point(656, 120);
			this.priTextBox2.Name = "priTextBox2";
			this.priTextBox2.Size = new System.Drawing.Size(112, 23);
			this.priTextBox2.TabIndex = 140;
			this.priTextBox2.Text = "";
			// 
			// label21
			// 
			this.label21.AutoSize = true;
			this.label21.BackColor = System.Drawing.Color.Transparent;
			this.label21.Location = new System.Drawing.Point(440, 120);
			this.label21.Name = "label21";
			this.label21.Size = new System.Drawing.Size(45, 18);
			this.label21.TabIndex = 133;
			this.label21.Text = "收款人";
			this.label21.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.BackColor = System.Drawing.Color.Transparent;
			this.label6.Location = new System.Drawing.Point(8, 120);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(72, 18);
			this.label6.TabIndex = 29;
			this.label6.Text = "银行流水号";
			this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.BackColor = System.Drawing.Color.Transparent;
			this.label8.Location = new System.Drawing.Point(440, 69);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(32, 18);
			this.label8.TabIndex = 103;
			this.label8.Text = "出纳";
			this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// priComboBox5
			// 
			this.priComboBox5.BackColor = System.Drawing.Color.White;
			this.priComboBox5.DataField = "paymode_id";
			this.priComboBox5.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.priComboBox5.ItemHeight = 13;
			this.priComboBox5.Location = new System.Drawing.Point(304, 120);
			this.priComboBox5.Name = "priComboBox5";
			this.priComboBox5.Size = new System.Drawing.Size(120, 21);
			this.priComboBox5.TabIndex = 183;
			// 
			// priComboBox2
			// 
			this.priComboBox2.BackColor = System.Drawing.Color.White;
			this.priComboBox2.DataField = "Currency";
			this.priComboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.priComboBox2.ItemHeight = 13;
			this.priComboBox2.Location = new System.Drawing.Point(88, 66);
			this.priComboBox2.Name = "priComboBox2";
			this.priComboBox2.Size = new System.Drawing.Size(136, 21);
			this.priComboBox2.TabIndex = 143;
			// 
			// priComboBox1
			// 
			this.priComboBox1.BackColor = System.Drawing.Color.White;
			this.priComboBox1.DataField = "Status";
			this.priComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.priComboBox1.ItemHeight = 13;
			this.priComboBox1.Location = new System.Drawing.Point(480, 16);
			this.priComboBox1.Name = "priComboBox1";
			this.priComboBox1.Size = new System.Drawing.Size(128, 21);
			this.priComboBox1.TabIndex = 142;
			// 
			// priTextBox19
			// 
			this.priTextBox19.BackColor = System.Drawing.Color.White;
			this.priTextBox19.DataField = "modifyOn";
			this.priTextBox19.DataType = TJSystem.Public.DataType.String;
			this.priTextBox19.Enabled = false;
			this.priTextBox19.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.priTextBox19.Location = new System.Drawing.Point(456, 208);
			this.priTextBox19.Name = "priTextBox19";
			this.priTextBox19.Size = new System.Drawing.Size(112, 23);
			this.priTextBox19.TabIndex = 132;
			this.priTextBox19.Text = "";
			// 
			// priTextBox13
			// 
			this.priTextBox13.BackColor = System.Drawing.Color.White;
			this.priTextBox13.DataField = "CreateBy";
			this.priTextBox13.DataType = TJSystem.Public.DataType.String;
			this.priTextBox13.Enabled = false;
			this.priTextBox13.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.priTextBox13.Location = new System.Drawing.Point(264, 208);
			this.priTextBox13.Name = "priTextBox13";
			this.priTextBox13.Size = new System.Drawing.Size(96, 23);
			this.priTextBox13.TabIndex = 120;
			this.priTextBox13.Text = "";
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.BackColor = System.Drawing.Color.Transparent;
			this.label11.Location = new System.Drawing.Point(232, 40);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(58, 18);
			this.label11.TabIndex = 112;
			this.label11.Text = "客户名称";
			this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// priTextBox7
			// 
			this.priTextBox7.BackColor = System.Drawing.Color.White;
			this.priTextBox7.DataField = "cashier";
			this.priTextBox7.DataType = TJSystem.Public.DataType.String;
			this.priTextBox7.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.priTextBox7.Location = new System.Drawing.Point(480, 64);
			this.priTextBox7.Name = "priTextBox7";
			this.priTextBox7.Size = new System.Drawing.Size(120, 23);
			this.priTextBox7.TabIndex = 109;
			this.priTextBox7.Text = "";
			// 
			// label18
			// 
			this.label18.AutoSize = true;
			this.label18.BackColor = System.Drawing.Color.Transparent;
			this.label18.Location = new System.Drawing.Point(240, 120);
			this.label18.Name = "label18";
			this.label18.Size = new System.Drawing.Size(58, 18);
			this.label18.TabIndex = 124;
			this.label18.Text = "收款方式";
			this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.BackColor = System.Drawing.Color.Transparent;
			this.label4.ForeColor = System.Drawing.Color.Blue;
			this.label4.Location = new System.Drawing.Point(48, 69);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(32, 18);
			this.label4.TabIndex = 28;
			this.label4.Text = "币种";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// priTextBox18
			// 
			this.priTextBox18.BackColor = System.Drawing.Color.White;
			this.priTextBox18.DataField = "director";
			this.priTextBox18.DataType = TJSystem.Public.DataType.String;
			this.priTextBox18.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.priTextBox18.Location = new System.Drawing.Point(656, 176);
			this.priTextBox18.Name = "priTextBox18";
			this.priTextBox18.Size = new System.Drawing.Size(112, 23);
			this.priTextBox18.TabIndex = 131;
			this.priTextBox18.Text = "";
			// 
			// priTextBox11
			// 
			this.priTextBox11.BackColor = System.Drawing.Color.White;
			this.priTextBox11.DataField = "Amount";
			this.priTextBox11.DataType = TJSystem.Public.DataType.String;
			this.priTextBox11.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.priTextBox11.Location = new System.Drawing.Point(296, 64);
			this.priTextBox11.Name = "priTextBox11";
			this.priTextBox11.Size = new System.Drawing.Size(136, 23);
			this.priTextBox11.TabIndex = 116;
			this.priTextBox11.Text = "";
			// 
			// priTextBox16
			// 
			this.priTextBox16.BackColor = System.Drawing.Color.White;
			this.priTextBox16.DataField = "Account";
			this.priTextBox16.DataType = TJSystem.Public.DataType.String;
			this.priTextBox16.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.priTextBox16.Location = new System.Drawing.Point(344, 96);
			this.priTextBox16.Name = "priTextBox16";
			this.priTextBox16.Size = new System.Drawing.Size(264, 23);
			this.priTextBox16.TabIndex = 127;
			this.priTextBox16.Text = "";
			// 
			// comboBox1
			// 
			this.comboBox1.BackColor = System.Drawing.Color.White;
			this.comboBox1.DataField = "Client_id";
			this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBox1.ItemHeight = 13;
			this.comboBox1.Location = new System.Drawing.Point(88, 40);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(136, 21);
			this.comboBox1.TabIndex = 137;
			this.comboBox1.SelectionChangeCommitted += new System.EventHandler(this.comboBox1_SelectionChangeCommitted);
			// 
			// dateTimePicker1
			// 
			this.dateTimePicker1.CustomFormat = "yyyy-MM-dd";
			this.dateTimePicker1.DataField = "ga_date";
			this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dateTimePicker1.Location = new System.Drawing.Point(296, 16);
			this.dateTimePicker1.Name = "dateTimePicker1";
			this.dateTimePicker1.Size = new System.Drawing.Size(136, 22);
			this.dateTimePicker1.TabIndex = 144;
			this.dateTimePicker1.Value = new System.DateTime(2007, 2, 4, 16, 42, 7, 859);
			// 
			// label25
			// 
			this.label25.AutoSize = true;
			this.label25.BackColor = System.Drawing.Color.Transparent;
			this.label25.Location = new System.Drawing.Point(616, 120);
			this.label25.Name = "label25";
			this.label25.Size = new System.Drawing.Size(32, 18);
			this.label25.TabIndex = 139;
			this.label25.Text = "制表";
			this.label25.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// priComboBox4
			// 
			this.priComboBox4.BackColor = System.Drawing.Color.White;
			this.priComboBox4.DataField = "doc_no";
			this.priComboBox4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.priComboBox4.ItemHeight = 13;
			this.priComboBox4.Location = new System.Drawing.Point(88, 176);
			this.priComboBox4.Name = "priComboBox4";
			this.priComboBox4.Size = new System.Drawing.Size(520, 21);
			this.priComboBox4.TabIndex = 142;
			// 
			// priTextBox8
			// 
			this.priTextBox8.BackColor = System.Drawing.Color.White;
			this.priTextBox8.DataField = "CreateOn";
			this.priTextBox8.DataType = TJSystem.Public.DataType.String;
			this.priTextBox8.Enabled = false;
			this.priTextBox8.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.priTextBox8.Location = new System.Drawing.Point(88, 208);
			this.priTextBox8.Name = "priTextBox8";
			this.priTextBox8.Size = new System.Drawing.Size(120, 23);
			this.priTextBox8.TabIndex = 110;
			this.priTextBox8.Text = "";
			// 
			// priComboBox3
			// 
			this.priComboBox3.BackColor = System.Drawing.Color.White;
			this.priComboBox3.DataField = "bank_number";
			this.priComboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.priComboBox3.ItemHeight = 13;
			this.priComboBox3.Location = new System.Drawing.Point(88, 120);
			this.priComboBox3.Name = "priComboBox3";
			this.priComboBox3.Size = new System.Drawing.Size(152, 21);
			this.priComboBox3.TabIndex = 184;
			this.priComboBox3.SelectionChangeCommitted += new System.EventHandler(this.priComboBox3_SelectionChangeCommitted);
			// 
			// label16
			// 
			this.label16.AutoSize = true;
			this.label16.BackColor = System.Drawing.Color.Transparent;
			this.label16.ForeColor = System.Drawing.Color.Blue;
			this.label16.Location = new System.Drawing.Point(616, 96);
			this.label16.Name = "label16";
			this.label16.Size = new System.Drawing.Size(32, 18);
			this.label16.TabIndex = 122;
			this.label16.Text = "汇率";
			this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label22
			// 
			this.label22.AutoSize = true;
			this.label22.BackColor = System.Drawing.Color.Transparent;
			this.label22.Location = new System.Drawing.Point(576, 208);
			this.label22.Name = "label22";
			this.label22.Size = new System.Drawing.Size(72, 18);
			this.label22.TabIndex = 134;
			this.label22.Text = "最后修改人";
			this.label22.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label15
			// 
			this.label15.AutoSize = true;
			this.label15.BackColor = System.Drawing.Color.Transparent;
			this.label15.ForeColor = System.Drawing.Color.Blue;
			this.label15.Location = new System.Drawing.Point(440, 16);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(32, 18);
			this.label15.TabIndex = 121;
			this.label15.Text = "状态";
			this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// priTextBox21
			// 
			this.priTextBox21.BackColor = System.Drawing.Color.White;
			this.priTextBox21.DataField = "modifyBy";
			this.priTextBox21.DataType = TJSystem.Public.DataType.String;
			this.priTextBox21.Enabled = false;
			this.priTextBox21.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.priTextBox21.Location = new System.Drawing.Point(648, 208);
			this.priTextBox21.Name = "priTextBox21";
			this.priTextBox21.Size = new System.Drawing.Size(120, 23);
			this.priTextBox21.TabIndex = 136;
			this.priTextBox21.Text = "";
			// 
			// label14
			// 
			this.label14.AutoSize = true;
			this.label14.BackColor = System.Drawing.Color.Transparent;
			this.label14.Location = new System.Drawing.Point(216, 208);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(45, 18);
			this.label14.TabIndex = 118;
			this.label14.Text = "创建者";
			this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.label14.Click += new System.EventHandler(this.label14_Click);
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.BackColor = System.Drawing.Color.Transparent;
			this.label10.ForeColor = System.Drawing.Color.Blue;
			this.label10.Location = new System.Drawing.Point(232, 16);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(58, 18);
			this.label10.TabIndex = 111;
			this.label10.Text = "收款日期";
			this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label19
			// 
			this.label19.AutoSize = true;
			this.label19.BackColor = System.Drawing.Color.Transparent;
			this.label19.Location = new System.Drawing.Point(624, 176);
			this.label19.Name = "label19";
			this.label19.Size = new System.Drawing.Size(32, 18);
			this.label19.TabIndex = 129;
			this.label19.Text = "主管";
			this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.BackColor = System.Drawing.Color.Transparent;
			this.label2.ForeColor = System.Drawing.Color.Blue;
			this.label2.Location = new System.Drawing.Point(24, 16);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(58, 18);
			this.label2.TabIndex = 16;
			this.label2.Text = "收款单号";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// priTextBox15
			// 
			this.priTextBox15.BackColor = System.Drawing.Color.White;
			this.priTextBox15.DataField = "exchange";
			this.priTextBox15.DataType = TJSystem.Public.DataType.String;
			this.priTextBox15.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.priTextBox15.Location = new System.Drawing.Point(656, 96);
			this.priTextBox15.Name = "priTextBox15";
			this.priTextBox15.Size = new System.Drawing.Size(112, 23);
			this.priTextBox15.TabIndex = 126;
			this.priTextBox15.Text = "";
			// 
			// label23
			// 
			this.label23.AutoSize = true;
			this.label23.BackColor = System.Drawing.Color.Transparent;
			this.label23.ForeColor = System.Drawing.Color.Blue;
			this.label23.Location = new System.Drawing.Point(24, 176);
			this.label23.Name = "label23";
			this.label23.Size = new System.Drawing.Size(58, 18);
			this.label23.TabIndex = 121;
			this.label23.Text = "应收单据";
			this.label23.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.BackColor = System.Drawing.Color.Transparent;
			this.label3.ForeColor = System.Drawing.Color.Blue;
			this.label3.Location = new System.Drawing.Point(24, 40);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(58, 18);
			this.label3.TabIndex = 25;
			this.label3.Text = "客户号码";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// priTextBox12
			// 
			this.priTextBox12.BackColor = System.Drawing.Color.White;
			this.priTextBox12.DataField = "accounter";
			this.priTextBox12.DataType = TJSystem.Public.DataType.String;
			this.priTextBox12.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.priTextBox12.Location = new System.Drawing.Point(656, 64);
			this.priTextBox12.Name = "priTextBox12";
			this.priTextBox12.Size = new System.Drawing.Size(112, 23);
			this.priTextBox12.TabIndex = 119;
			this.priTextBox12.Text = "";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.BackColor = System.Drawing.Color.Transparent;
			this.label5.Location = new System.Drawing.Point(48, 96);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(32, 18);
			this.label5.TabIndex = 23;
			this.label5.Text = "银行";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// priTextBox1
			// 
			this.priTextBox1.BackColor = System.Drawing.Color.White;
			this.priTextBox1.DataField = "ga_code";
			this.priTextBox1.DataType = TJSystem.Public.DataType.String;
			this.priTextBox1.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.priTextBox1.Location = new System.Drawing.Point(88, 16);
			this.priTextBox1.Name = "priTextBox1";
			this.priTextBox1.Size = new System.Drawing.Size(136, 23);
			this.priTextBox1.TabIndex = 100;
			this.priTextBox1.Text = "";
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.BackColor = System.Drawing.Color.Transparent;
			this.label12.ForeColor = System.Drawing.Color.Blue;
			this.label12.Location = new System.Drawing.Point(240, 69);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(45, 18);
			this.label12.TabIndex = 113;
			this.label12.Text = "总金额";
			this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// priTextBox10
			// 
			this.priTextBox10.BackColor = System.Drawing.Color.White;
			this.priTextBox10.DataField = "Client_name";
			this.priTextBox10.DataType = TJSystem.Public.DataType.String;
			this.priTextBox10.Enabled = false;
			this.priTextBox10.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.priTextBox10.Location = new System.Drawing.Point(296, 40);
			this.priTextBox10.Name = "priTextBox10";
			this.priTextBox10.Size = new System.Drawing.Size(312, 23);
			this.priTextBox10.TabIndex = 115;
			this.priTextBox10.Text = "";
			// 
			// linkLabel1
			// 
			this.linkLabel1.BackColor = System.Drawing.Color.Transparent;
			this.linkLabel1.Location = new System.Drawing.Point(640, 8);
			this.linkLabel1.Name = "linkLabel1";
			this.linkLabel1.Size = new System.Drawing.Size(100, 24);
			this.linkLabel1.TabIndex = 185;
			this.linkLabel1.TabStop = true;
			this.linkLabel1.Text = "收款明细";
			this.linkLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
			// 
			// priTextBox4
			// 
			this.priTextBox4.BackColor = System.Drawing.Color.White;
			this.priTextBox4.DataField = "Bank";
			this.priTextBox4.DataType = TJSystem.Public.DataType.String;
			this.priTextBox4.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.priTextBox4.Location = new System.Drawing.Point(88, 96);
			this.priTextBox4.Name = "priTextBox4";
			this.priTextBox4.Size = new System.Drawing.Size(208, 23);
			this.priTextBox4.TabIndex = 106;
			this.priTextBox4.Text = "";
			// 
			// label17
			// 
			this.label17.AutoSize = true;
			this.label17.BackColor = System.Drawing.Color.Transparent;
			this.label17.Location = new System.Drawing.Point(304, 96);
			this.label17.Name = "label17";
			this.label17.Size = new System.Drawing.Size(32, 18);
			this.label17.TabIndex = 123;
			this.label17.Text = "帐号";
			this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// priTextBox6
			// 
			this.priTextBox6.BackColor = System.Drawing.Color.White;
			this.priTextBox6.DataField = "remark";
			this.priTextBox6.DataType = TJSystem.Public.DataType.String;
			this.priTextBox6.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.priTextBox6.Location = new System.Drawing.Point(88, 152);
			this.priTextBox6.Name = "priTextBox6";
			this.priTextBox6.Size = new System.Drawing.Size(680, 23);
			this.priTextBox6.TabIndex = 108;
			this.priTextBox6.Text = "";
			// 
			// dataGrid1
			// 
			this.dataGrid1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.dataGrid1.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.dataGrid1.CaptionVisible = false;
			this.dataGrid1.DataMember = "";
			this.dataGrid1.Font = new System.Drawing.Font("宋体", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.dataGrid1.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.dataGrid1.Location = new System.Drawing.Point(0, 248);
			this.dataGrid1.Name = "dataGrid1";
			this.dataGrid1.ReadOnly = true;
			this.dataGrid1.Size = new System.Drawing.Size(792, 232);
			this.dataGrid1.TabIndex = 141;
			this.dataGrid1.TableStyles.AddRange(new System.Windows.Forms.DataGridTableStyle[] {
																								  this.dataGridTableStyle1});
			// 
			// dataGridTableStyle1
			// 
			this.dataGridTableStyle1.DataGrid = this.dataGrid1;
			this.dataGridTableStyle1.HeaderFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.dataGridTableStyle1.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.dataGridTableStyle1.MappingName = "finance_gathering";
			// 
			// panel1
			// 
			this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
			this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.panel1.Controls.Add(this.label1);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(792, 45);
			this.panel1.TabIndex = 19;
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label1.Font = new System.Drawing.Font("宋体", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.label1.Location = new System.Drawing.Point(0, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(788, 41);
			this.label1.TabIndex = 0;
			this.label1.Text = "收款单";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// frmGatheringBill
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(7, 15);
			this.ClientSize = new System.Drawing.Size(792, 566);
			this.Controls.Add(this.panel3);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.Font = new System.Drawing.Font("宋体", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.Name = "frmGatheringBill";
			this.Text = "收款单";
			this.panel3.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			this.panel4.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).EndInit();
			this.panel1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		private void comboBox1_SelectionChangeCommitted(object sender, System.EventArgs e)
		{
			string sql = "select CLIENT_ID,CLIENT_NAME from basic_client where CLIENT_ID='" + comboBox1.SelectedValue.ToString() + "'";
			DataTable dt = TJSystem.Public.PublicStatic.db.GetDataTable(sql);
			if(dt.Rows.Count != 1)
			{
				this.priTextBox10.Text= "";
//				this.priTextBox4.Text = "";
//				this.priTextBox16.Text = "";
				return;
			}
			this.priTextBox10.Text=dt.Rows[0][1].ToString();
//			this.priTextBox4.Text = dt.Rows[0][2].ToString();
//			this.priTextBox16.Text = dt.Rows[0][3].ToString();
		}

		private void label14_Click(object sender, System.EventArgs e)
		{
		
		}

		private void priComboBox3_SelectionChangeCommitted(object sender, System.EventArgs e)
		{
			DataTable dt = null;
			string sql = "select bank_name,account from basic_company_bank where company_id='" + TJSystem.Public.PublicStatic.CompanyID + "' and bank_id='" + this.priComboBox3.SelectedValue.ToString() + "'";
			dt = TJSystem.Public.PublicStatic.db.GetDataTable(sql);
			if(dt.Rows.Count == 1)
			{
				this.priTextBox16.Text = dt.Rows[0]["account"].ToString();
				this.priTextBox4.Text = dt.Rows[0]["bank_name"].ToString();
			}
			else
			{
				this.priTextBox16.Text = "";
				this.priTextBox4.Text = "";
			}
		}

		private void linkLabel1_LinkClicked(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
		{
			if(this.priTextBox1.Text.Trim().Equals(""))
			{
				TJSystem.Public.PublicStatic.ShowMessage(TJSystem.Public.MessageType.Exclamation,"请先选择收款单号!");
				return;
			}
			frmGatheringBillDetail frm = new frmGatheringBillDetail(this.priTextBox1.Text.Trim());
			frm.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			frm.ShowDialog();
		}
	}
}

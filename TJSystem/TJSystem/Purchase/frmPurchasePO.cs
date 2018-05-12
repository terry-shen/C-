using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace TJSystem.Purchase
{
	/// <summary>
	/// Form1 的摘要说明。
	/// </summary>
	public class frmPurchasePO : System.Windows.Forms.Form
	{
		
		
		/// <summary>
		/// 必需的设计器变量。
		/// </summary>
		private System.ComponentModel.Container components = null;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.DataGridTextBoxColumn website;
		private System.Windows.Forms.DataGridTextBoxColumn fax2;
		private System.Windows.Forms.DataGridTextBoxColumn tel2;
		private System.Windows.Forms.DataGridTextBoxColumn tel1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.DataGrid dataGrid1;
		private System.Windows.Forms.Panel panel4;
		private System.Windows.Forms.Label label28;
		private System.Windows.Forms.Label label29;
		private System.Windows.Forms.Label label34;
		private System.Windows.Forms.Label label32;
		private System.Windows.Forms.Label label25;
		private System.Windows.Forms.Label label16;
		private System.Windows.Forms.Label label23;
		private System.Windows.Forms.Label label24;
		private System.Windows.Forms.Label label18;
		private System.Windows.Forms.Label label19;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label21;
		private System.Windows.Forms.Label label20;
		private System.Windows.Forms.Label label17;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label2;
		private TJSystem.Classes.PriTextBox txt1;
		private System.Windows.Forms.DataGridTextBoxColumn address;
		private System.Windows.Forms.DataGridTextBoxColumn company_name;
		private System.Windows.Forms.DataGridTextBoxColumn corporation;
		private System.Windows.Forms.DataGridTextBoxColumn postcode;
		private System.Windows.Forms.DataGridTextBoxColumn company_id;
		private System.Windows.Forms.DataGridTextBoxColumn company_name_cn;
		private System.Windows.Forms.DataGridTextBoxColumn email1;
		private System.Windows.Forms.DataGridTextBoxColumn email2;
		private System.Windows.Forms.DataGridTextBoxColumn address_cn;
		private System.Windows.Forms.DataGridTextBoxColumn resume;
		private System.Windows.Forms.Panel panel3;
		private TJSystem.UC.PriToolBar priToolBar1;
		private System.Windows.Forms.DataGridTextBoxColumn gen_manager;
		private System.Windows.Forms.DataGridTextBoxColumn fax1;
		public static System.Windows.Forms.Form frmCurrent = null ;
		private TJSystem.Classes.PriTextBox txt10;
		private TJSystem.Classes.PriTextBox txt9;
		private TJSystem.Classes.PriTextBox txt8;
		private TJSystem.Classes.PriTextBox txt7;
		private TJSystem.Classes.PriTextBox txt6;
		private TJSystem.Classes.PriTextBox txt5;
		private TJSystem.Classes.PriTextBox txt4;
		private TJSystem.Classes.PriComboBox priComboBox1;
		private TJSystem.Classes.PriComboBox priComboBox6;
		private TJSystem.Classes.PriComboBox priComboBox4;
		private TJSystem.Classes.PriComboBox priComboBox5;
		private TJSystem.Classes.PriComboBox priComboBox2;
		private TJSystem.Classes.PriTextBox txt14;
		private TJSystem.Classes.PriTextBox txt13;
		private TJSystem.Classes.PriTextBox txt16;
		private TJSystem.Classes.PriTextBox txt12;
		private TJSystem.Classes.PriTextBox txt11;
		private TJSystem.Classes.PriTextBox txt15;
		private string _PK;
		private string _table;
		private TJSystem.Classes.PriComboBox priComboBox3;
		private System.Windows.Forms.LinkLabel linkLabel1;
		private System.Windows.Forms.DataGridTableStyle dataGridTableStyle1;
		private System.Windows.Forms.DataGridTextBoxColumn po_code;
		private System.Windows.Forms.DataGridTextBoxColumn po_date;
		private System.Windows.Forms.DataGridTextBoxColumn deliveryDate;
		private System.Windows.Forms.DataGridTextBoxColumn supplier_id;
		private System.Windows.Forms.DataGridTextBoxColumn contact_id;
		private System.Windows.Forms.DataGridTextBoxColumn contact_name;
		private System.Windows.Forms.DataGridTextBoxColumn supp_account;
		private System.Windows.Forms.DataGridTextBoxColumn supplier_name;
		private System.Windows.Forms.DataGridTextBoxColumn amount;
		private System.Windows.Forms.DataGridTextBoxColumn discountType;
		private System.Windows.Forms.DataGridTextBoxColumn discount;
		private System.Windows.Forms.DataGridTextBoxColumn remark;
		public static int Count = 0;
		private System.Windows.Forms.Label label6;
		private TJSystem.Classes.PriTextBox priTextBox2;
		private System.Windows.Forms.Label label13;
		private TJSystem.Classes.PriTextBox priTextBox4;
		private System.Windows.Forms.DataGridTextBoxColumn InsideAmount;
		private System.Windows.Forms.DataGridTextBoxColumn InsideFreight;
		private System.Windows.Forms.DataGridTextBoxColumn createby;
		private System.Windows.Forms.DataGridTextBoxColumn createon;
		private System.Windows.Forms.DataGridTextBoxColumn modifyby;
		private System.Windows.Forms.DataGridTextBoxColumn modifyon;
		private System.Windows.Forms.DataGridTextBoxColumn approvedby;
		private System.Windows.Forms.DataGridTextBoxColumn approvedon;
		private TJSystem.Classes.PriDateTimePicker priDateTimePicker3;
		private TJSystem.Classes.PriDateTimePicker priDateTimePicker1;
		private System.Windows.Forms.DataGridTextBoxColumn status_name;
		private System.Windows.Forms.DataGridTextBoxColumn paymentAccount_name;
		private System.Windows.Forms.DataGridTextBoxColumn paymentType_name;
		private System.Windows.Forms.DataGridTextBoxColumn currency_name;
		private string _statusType = null;

		private string _PKSubValue = null;

		public frmPurchasePO()
		{
			//
			// Windows 窗体设计器支持所必需的
			//
			InitializeComponent();

			

			_statusType = "purchase";

			TJSystem.Public.PublicStatic.setBackgroundImg(this.panel1,this.panel1.GetType().ToString(),"images\\bg.gif");
			TJSystem.Public.PublicStatic.setBackgroundImg(this.panel2,this.panel1.GetType().ToString(),"");
			TJSystem.Public.PublicStatic.setBackgroundImg(this.panel3,this.panel1.GetType().ToString(),"");
			TJSystem.Public.PublicStatic.setBackgroundImg(this.panel4,this.panel1.GetType().ToString(),"");

			InitialFormData();
			System.Text.StringBuilder sb = new System.Text.StringBuilder();
			sb.Append("select a.po_code,a.po_date ,a.status,b.status_name as status_name,a.deliveryDate,a.supplier_id,");
			sb.Append(" a.contact_id ,a.contact_name,a.supp_account,a.supplier_name,a.paymentAccount,c.Term_namecn as paymentAccount_name,");
			sb.Append(" a.paymentType,d.paymode_name_cn as paymentType_name,");
			sb.Append(" a.currency,e.currency_namecn as currency_name,a.amount,a.taxdiscount,a.InsideAmount,a.manageAmount,a.InsideFreight,");
			sb.Append(" a.discountType,a.discount,a.remark,a.createBy,a.createon,a.approvedBy,a.approvedon,a.modifyBy,a.modifyon,");
			sb.Append(" a.confirmedBy,a.confirmedon ");
			sb.Append("from purchase_po_master a");
			sb.Append(" left join p_status b ");
			sb.Append("on a.status = b.status_id and b.status_type = '"+_statusType+"' ");
			sb.Append("left join p_paymentTerm c ");
			sb.Append("on a.paymentAccount = c.term_code ");
			sb.Append("left join p_paymode d ");
			sb.Append("on a.paymentType = d.paymode_id ");
			sb.Append("left join p_currency e ");
			sb.Append("on a.currency = e.currency_code ");
			sb.Append(" order by a.po_code");

			this.InitialGrid(sb.ToString());

			priToolBar1.setCurrentForm = this;
			_PK = "po_code,supplier_id";
			_table = "purchase_po_master";
			priToolBar1.Initial("purchase_po_master",_PK,sb.ToString());
			priToolBar1.BeforeButtonClickEvent += new TJSystem.UC.PriToolBar.BeforeButotnClick(this.BeforeButtonClick);
			priToolBar1.AfterButtonClickEvent += new TJSystem.UC.PriToolBar.AfterButtonClick(this.AfterButtonClick);

			this.priToolBar1.setButtonVisibleFalse();;
			this.priToolBar1.setButtonVisible("012345689");
			setDisable();

			//
			// TODO: 在 InitializeComponent 调用后添加任何构造函数代码
			//
		}

		/// <summary>
		/// 
		/// </summary>
		private void InitialFormData()
		{
			DataTable dtcpy = null;
			DataRow dr = null;
			//状态
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
			this.priComboBox1.DataSource = dtcpy.DefaultView;
			this.priComboBox1.ValueMember = "STATUS_ID";
			this.priComboBox1.DisplayMember = "STATUS_NAME";


			//供应商
			sql = "select SUPPLIER_ID,SUPPLIER_ID+' '+SUPPLIER_NAME as SUPPLIER_NAME from basic_supplier order by SUPPLIER_ID";
			dt = TJSystem.Public.PublicStatic.db.GetDataTable(sql);
			dr = dt.NewRow() ;
			dr[0] = "" ;
			dr[1] = "" ;
			dt.Rows.InsertAt(dr,0) ;
			dtcpy = dt.Copy();
			this.priComboBox2.DataSource = dtcpy.DefaultView;
			this.priComboBox2.ValueMember = "SUPPLIER_ID";
			this.priComboBox2.DisplayMember = "SUPPLIER_NAME";


			//付款条款
			sql = "select Term_code,Term_code+' '+Term_namecn as Term_namecn from p_paymentTerm order by Term_code";
			dt = TJSystem.Public.PublicStatic.db.GetDataTable(sql);
			dr = dt.NewRow() ;
			dr[0] = "" ;
			dr[1] = "" ;
			dt.Rows.InsertAt(dr,0) ;
			dtcpy = dt.Copy();
			this.priComboBox4.DataSource = dtcpy.DefaultView;
			this.priComboBox4.ValueMember = "Term_code";
			this.priComboBox4.DisplayMember = "Term_namecn";

			//付款方式
			sql = "select paymode_id,paymode_id+' '+paymode_name_cn as paymode_name_cn from p_paymode order by paymode_id";
			dt = TJSystem.Public.PublicStatic.db.GetDataTable(sql);
			dr = dt.NewRow() ;
			dr[0] = "" ;
			dr[1] = "" ;
			dt.Rows.InsertAt(dr,0) ;
			dtcpy = dt.Copy();
			this.priComboBox5.DataSource = dtcpy.DefaultView;
			this.priComboBox5.ValueMember = "paymode_id";
			this.priComboBox5.DisplayMember = "paymode_name_cn";

			//币种
			sql = "select Currency_Code,Currency_Code+' '+Currency_nameCn as Currency_nameCn from p_Currency order by Currency_Code";
			dt = TJSystem.Public.PublicStatic.db.GetDataTable(sql);
			dr = dt.NewRow() ;
			dr[0] = "" ;
			dr[1] = "" ;
			dt.Rows.InsertAt(dr,0) ;
			dtcpy = dt.Copy();
			this.priComboBox6.DataSource = dtcpy.DefaultView;
			this.priComboBox6.ValueMember = "Currency_Code";
			this.priComboBox6.DisplayMember = "Currency_nameCn";

			sql = "select  a.supplier_name as supplier_name, b.contact_id, b.contact_id +' '+b.contact_name as contact_name  from basic_supplier a join basic_supplier_contact b on a.supplier_id = b.supplier_id";
			dt = TJSystem.Public.PublicStatic.db.GetDataTable(sql);			
			dr= dt.NewRow();
			dr[0] = "";
			dr[1] = "";
			dr[2] = "";
			dt.Rows.InsertAt(dr,0);
			dtcpy =dt.Copy();
			this.priComboBox3.DataSource = dtcpy.DefaultView;
			this.priComboBox3.ValueMember = "contact_id";
			this.priComboBox3.DisplayMember = "contact_name";

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
    				return false;
				}
			}
			return true;
		}


		private bool checkFormValue(string sqltype,System.Text.StringBuilder sb)
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
					MessageBox.Show("请输入采购单号","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
					return false;
				}

				if(TJSystem.Public.PublicStatic.IsExsist(this._table,this._PK,this.priToolBar1))
				{
					MessageBox.Show("这张采购单已经存在,请另外开立","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
					return false;
				}
			}

			if (this.priComboBox2.SelectedIndex.Equals(-1))
			{
				MessageBox.Show("供应商代码不能为空","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
				return false;
			}

            //CHECK输入值的属性
            // add by chenchong
            if (this.txt7.Text.Equals(""))
            {
                TJSystem.Public.PublicStatic.ShowMessage(TJSystem.Public.MessageType.Error, "请填写总金额！");
                return false;
            }

            if (!TJSystem.Public.PublicStatic.IsNumDouble(this.txt7.Text.Trim()))
            {
                TJSystem.Public.PublicStatic.ShowMessage(TJSystem.Public.MessageType.Error, "总金额必须为数字！");
                return false;
            }

            if (!TJSystem.Public.PublicStatic.IsNumDouble(this.txt9.Text.Trim()))
            {
                TJSystem.Public.PublicStatic.ShowMessage(TJSystem.Public.MessageType.Error, "折扣必须为数字！");
                return false;
            }

			if(sqltype.Equals("insert"))
			{
				/*
				int ret = 0;
				PublicStatic.Classes.common.CommonSubTableHandle csth = new PublicStatic.Classes.common.CommonSubTableHandle();
				csth.TableName = "purchase_po_detail";
				csth.PrimaryKeyField = "po_code";
				csth.PrimaryKeyValue = _PKSubValue;
				csth.PrimaryKeyNewValue = this.txt1.Text;
				ret = csth.SubTableInsert();
				if (ret == 100)
				{
					TJSystem.Public.PublicStatic.ShowMessage(TJSystem.Public.MessageType.Information,"原报价单中无货品资料！");
					return true;
				}
				
				if (ret >0)
				{
					TJSystem.Public.PublicStatic.ShowMessage(TJSystem.Public.MessageType.Exclamation,"新报价单中的货品资料插入有问题，请进入明细单确认！");
					return true;
				}	
				*/			
			}
			return true;
		}


		private void setDisable()
		{
			this.txt1.Enabled = false;
			this.priDateTimePicker3.Enabled = false;
			this.priDateTimePicker1.Enabled = false;
			this.txt4.Enabled = false;
			this.txt5.Enabled = false;
			this.txt6.Enabled = false;
			this.txt7.Enabled = false;
			this.txt8.Enabled = false;
			this.txt9.Enabled = false;
			this.txt10.Enabled = false;
			this.txt11.Enabled = false;
			this.txt12.Enabled = false;
			this.txt13.Enabled = false;
			this.txt14.Enabled = false;
			this.txt15.Enabled = false;
			this.txt16.Enabled = false;
			

			this.priComboBox1.Enabled = false;
			this.priComboBox2.Enabled = false;
			this.priComboBox3.Enabled = false;
			this.priComboBox4.Enabled = false;
			this.priComboBox5.Enabled = false;
			this.priComboBox6.Enabled = false;
		}

		private void AfterButtonClick(string ButtonType)
		{			
			if(ButtonType.Equals("copy"))
			{
				this._PKSubValue = this.txt1.Text;
			}
			if(ButtonType.Equals("insert"))
			{
				this.txt1.Enabled = true;
				this.priDateTimePicker3.Enabled = true;
				this.priDateTimePicker1.Enabled = true;
				
				this.txt7.Enabled = true;
				this.txt8.Enabled = true;
				this.txt9.Enabled = true;
				this.txt10.Enabled = true;
				this.priComboBox1.Enabled = false;
				this.priComboBox2.Enabled = true;
				this.priComboBox4.Enabled = true;
				this.priComboBox5.Enabled = true;
				this.priComboBox6.Enabled = true;

				this.txt1.Text = "";
				this.priDateTimePicker3.Value = System.DateTime.Now;
				this.priDateTimePicker1.Value = System.DateTime.Now;
				this.txt4.Text = "";
				this.txt6.Text = "";
				this.txt7.Text = "";
				this.txt8.Text = "";
				this.txt9.Text = "";
				this.txt10.Text = "";
				this.txt11.Text = "";
				this.txt13.Text = "";
				this.txt14.Text = "";
				this.txt15.Text = "";
				this.txt16.Text = "";
				this.priComboBox1.SelectedValue = "1";
				

			}
			else if(ButtonType.Equals("update"))
			{
				this.txt1.Enabled = false;
				this.priDateTimePicker3.Enabled = true;
				this.priDateTimePicker1.Enabled = true;
				
				this.txt7.Enabled = true;
				this.txt8.Enabled = true;
				this.txt9.Enabled = true;
				this.txt10.Enabled = true;
				this.priComboBox1.Enabled = false;
				this.priComboBox2.Enabled = true;
				this.priComboBox4.Enabled = true;
				this.priComboBox5.Enabled = true;
				this.priComboBox6.Enabled = true;

			}

			this.priToolBar1.SetStatusEnable(this.priComboBox1);
		}

		private void InitialGrid(string sql)
		{		
			DataTable dt = TJSystem.Public.PublicStatic.db.GetDataTable(sql);
			dt.TableName = "purchase_po_master";
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(frmPurchasePO));
			this.panel1 = new System.Windows.Forms.Panel();
			this.label1 = new System.Windows.Forms.Label();
			this.website = new System.Windows.Forms.DataGridTextBoxColumn();
			this.fax2 = new System.Windows.Forms.DataGridTextBoxColumn();
			this.tel2 = new System.Windows.Forms.DataGridTextBoxColumn();
			this.tel1 = new System.Windows.Forms.DataGridTextBoxColumn();
			this.panel2 = new System.Windows.Forms.Panel();
			this.dataGrid1 = new System.Windows.Forms.DataGrid();
			this.dataGridTableStyle1 = new System.Windows.Forms.DataGridTableStyle();
			this.po_code = new System.Windows.Forms.DataGridTextBoxColumn();
			this.po_date = new System.Windows.Forms.DataGridTextBoxColumn();
			this.status_name = new System.Windows.Forms.DataGridTextBoxColumn();
			this.deliveryDate = new System.Windows.Forms.DataGridTextBoxColumn();
			this.supplier_id = new System.Windows.Forms.DataGridTextBoxColumn();
			this.contact_id = new System.Windows.Forms.DataGridTextBoxColumn();
			this.contact_name = new System.Windows.Forms.DataGridTextBoxColumn();
			this.supp_account = new System.Windows.Forms.DataGridTextBoxColumn();
			this.supplier_name = new System.Windows.Forms.DataGridTextBoxColumn();
			this.paymentAccount_name = new System.Windows.Forms.DataGridTextBoxColumn();
			this.paymentType_name = new System.Windows.Forms.DataGridTextBoxColumn();
			this.currency_name = new System.Windows.Forms.DataGridTextBoxColumn();
			this.amount = new System.Windows.Forms.DataGridTextBoxColumn();
			this.InsideAmount = new System.Windows.Forms.DataGridTextBoxColumn();
			this.InsideFreight = new System.Windows.Forms.DataGridTextBoxColumn();
			this.discountType = new System.Windows.Forms.DataGridTextBoxColumn();
			this.discount = new System.Windows.Forms.DataGridTextBoxColumn();
			this.remark = new System.Windows.Forms.DataGridTextBoxColumn();
			this.createby = new System.Windows.Forms.DataGridTextBoxColumn();
			this.createon = new System.Windows.Forms.DataGridTextBoxColumn();
			this.modifyby = new System.Windows.Forms.DataGridTextBoxColumn();
			this.modifyon = new System.Windows.Forms.DataGridTextBoxColumn();
			this.approvedby = new System.Windows.Forms.DataGridTextBoxColumn();
			this.approvedon = new System.Windows.Forms.DataGridTextBoxColumn();
			this.panel4 = new System.Windows.Forms.Panel();
			this.priDateTimePicker3 = new TJSystem.Classes.PriDateTimePicker();
			this.label13 = new System.Windows.Forms.Label();
			this.priTextBox4 = new TJSystem.Classes.PriTextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.priTextBox2 = new TJSystem.Classes.PriTextBox();
			this.linkLabel1 = new System.Windows.Forms.LinkLabel();
			this.priComboBox2 = new TJSystem.Classes.PriComboBox();
			this.priComboBox5 = new TJSystem.Classes.PriComboBox();
			this.priComboBox4 = new TJSystem.Classes.PriComboBox();
			this.priComboBox3 = new TJSystem.Classes.PriComboBox();
			this.priComboBox1 = new TJSystem.Classes.PriComboBox();
			this.priComboBox6 = new TJSystem.Classes.PriComboBox();
			this.label28 = new System.Windows.Forms.Label();
			this.txt14 = new TJSystem.Classes.PriTextBox();
			this.label29 = new System.Windows.Forms.Label();
			this.txt13 = new TJSystem.Classes.PriTextBox();
			this.label34 = new System.Windows.Forms.Label();
			this.label32 = new System.Windows.Forms.Label();
			this.txt10 = new TJSystem.Classes.PriTextBox();
			this.label25 = new System.Windows.Forms.Label();
			this.txt9 = new TJSystem.Classes.PriTextBox();
			this.label16 = new System.Windows.Forms.Label();
			this.txt8 = new TJSystem.Classes.PriTextBox();
			this.label23 = new System.Windows.Forms.Label();
			this.label24 = new System.Windows.Forms.Label();
			this.txt7 = new TJSystem.Classes.PriTextBox();
			this.label18 = new System.Windows.Forms.Label();
			this.label19 = new System.Windows.Forms.Label();
			this.txt6 = new TJSystem.Classes.PriTextBox();
			this.label9 = new System.Windows.Forms.Label();
			this.txt5 = new TJSystem.Classes.PriTextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.txt4 = new TJSystem.Classes.PriTextBox();
			this.label21 = new System.Windows.Forms.Label();
			this.txt16 = new TJSystem.Classes.PriTextBox();
			this.label20 = new System.Windows.Forms.Label();
			this.txt12 = new TJSystem.Classes.PriTextBox();
			this.label17 = new System.Windows.Forms.Label();
			this.label15 = new System.Windows.Forms.Label();
			this.label12 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.txt11 = new TJSystem.Classes.PriTextBox();
			this.txt15 = new TJSystem.Classes.PriTextBox();
			this.txt1 = new TJSystem.Classes.PriTextBox();
			this.priDateTimePicker1 = new TJSystem.Classes.PriDateTimePicker();
			this.address = new System.Windows.Forms.DataGridTextBoxColumn();
			this.company_name = new System.Windows.Forms.DataGridTextBoxColumn();
			this.corporation = new System.Windows.Forms.DataGridTextBoxColumn();
			this.postcode = new System.Windows.Forms.DataGridTextBoxColumn();
			this.company_id = new System.Windows.Forms.DataGridTextBoxColumn();
			this.company_name_cn = new System.Windows.Forms.DataGridTextBoxColumn();
			this.email1 = new System.Windows.Forms.DataGridTextBoxColumn();
			this.email2 = new System.Windows.Forms.DataGridTextBoxColumn();
			this.address_cn = new System.Windows.Forms.DataGridTextBoxColumn();
			this.resume = new System.Windows.Forms.DataGridTextBoxColumn();
			this.panel3 = new System.Windows.Forms.Panel();
			this.priToolBar1 = new TJSystem.UC.PriToolBar();
			this.gen_manager = new System.Windows.Forms.DataGridTextBoxColumn();
			this.fax1 = new System.Windows.Forms.DataGridTextBoxColumn();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).BeginInit();
			this.panel4.SuspendLayout();
			this.panel3.SuspendLayout();
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
			this.panel1.Size = new System.Drawing.Size(792, 48);
			this.panel1.TabIndex = 19;
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
			this.label1.Text = "采购订单";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// website
			// 
			this.website.Format = "";
			this.website.FormatInfo = null;
			this.website.HeaderText = "公司网站";
			this.website.MappingName = "website";
			this.website.NullText = "";
			this.website.Width = 75;
			// 
			// fax2
			// 
			this.fax2.Format = "";
			this.fax2.FormatInfo = null;
			this.fax2.HeaderText = "传真2";
			this.fax2.MappingName = "fax2";
			this.fax2.NullText = "";
			this.fax2.Width = 75;
			// 
			// tel2
			// 
			this.tel2.Format = "";
			this.tel2.FormatInfo = null;
			this.tel2.HeaderText = "电话2";
			this.tel2.MappingName = "tel2";
			this.tel2.NullText = "";
			this.tel2.Width = 75;
			// 
			// tel1
			// 
			this.tel1.Format = "";
			this.tel1.FormatInfo = null;
			this.tel1.HeaderText = "电话1";
			this.tel1.MappingName = "tel1";
			this.tel1.NullText = "";
			this.tel1.Width = 75;
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
			this.panel2.Size = new System.Drawing.Size(792, 526);
			this.panel2.TabIndex = 20;
			// 
			// dataGrid1
			// 
			this.dataGrid1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.dataGrid1.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.dataGrid1.CaptionBackColor = System.Drawing.SystemColors.AppWorkspace;
			this.dataGrid1.CaptionText = "订单列表";
			this.dataGrid1.CaptionVisible = false;
			this.dataGrid1.DataMember = "";
			this.dataGrid1.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.dataGrid1.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.dataGrid1.Location = new System.Drawing.Point(0, 256);
			this.dataGrid1.Name = "dataGrid1";
			this.dataGrid1.ReadOnly = true;
			this.dataGrid1.Size = new System.Drawing.Size(784, 264);
			this.dataGrid1.TabIndex = 1;
			this.dataGrid1.TableStyles.AddRange(new System.Windows.Forms.DataGridTableStyle[] {
																								  this.dataGridTableStyle1});
			// 
			// dataGridTableStyle1
			// 
			this.dataGridTableStyle1.DataGrid = this.dataGrid1;
			this.dataGridTableStyle1.GridColumnStyles.AddRange(new System.Windows.Forms.DataGridColumnStyle[] {
																												  this.po_code,
																												  this.po_date,
																												  this.status_name,
																												  this.deliveryDate,
																												  this.supplier_id,
																												  this.contact_id,
																												  this.contact_name,
																												  this.supp_account,
																												  this.supplier_name,
																												  this.paymentAccount_name,
																												  this.paymentType_name,
																												  this.currency_name,
																												  this.amount,
																												  this.InsideAmount,
																												  this.InsideFreight,
																												  this.discountType,
																												  this.discount,
																												  this.remark,
																												  this.createby,
																												  this.createon,
																												  this.modifyby,
																												  this.modifyon,
																												  this.approvedby,
																												  this.approvedon});
			this.dataGridTableStyle1.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.dataGridTableStyle1.MappingName = "purchase_po_master";
			// 
			// po_code
			// 
			this.po_code.Format = "";
			this.po_code.FormatInfo = null;
			this.po_code.HeaderText = "采购单号";
			this.po_code.MappingName = "po_code";
			this.po_code.NullText = "";
			this.po_code.Width = 75;
			// 
			// po_date
			// 
			this.po_date.Format = "";
			this.po_date.FormatInfo = null;
			this.po_date.HeaderText = "日期";
			this.po_date.MappingName = "po_date";
			this.po_date.NullText = "";
			this.po_date.Width = 75;
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
			// deliveryDate
			// 
			this.deliveryDate.Format = "";
			this.deliveryDate.FormatInfo = null;
			this.deliveryDate.HeaderText = "交货期";
			this.deliveryDate.MappingName = "deliveryDate";
			this.deliveryDate.NullText = "";
			this.deliveryDate.Width = 75;
			// 
			// supplier_id
			// 
			this.supplier_id.Format = "";
			this.supplier_id.FormatInfo = null;
			this.supplier_id.HeaderText = "供应商";
			this.supplier_id.MappingName = "supplier_id";
			this.supplier_id.NullText = "";
			this.supplier_id.Width = 75;
			// 
			// contact_id
			// 
			this.contact_id.Format = "";
			this.contact_id.FormatInfo = null;
			this.contact_id.HeaderText = "联系人";
			this.contact_id.MappingName = "contact_id";
			this.contact_id.NullText = "";
			this.contact_id.Width = 75;
			// 
			// contact_name
			// 
			this.contact_name.Format = "";
			this.contact_name.FormatInfo = null;
			this.contact_name.HeaderText = "联系人姓名";
			this.contact_name.MappingName = "contact_name";
			this.contact_name.NullText = "";
			this.contact_name.Width = 75;
			// 
			// supp_account
			// 
			this.supp_account.Format = "";
			this.supp_account.FormatInfo = null;
			this.supp_account.HeaderText = "供应商帐号";
			this.supp_account.MappingName = "supp_account";
			this.supp_account.NullText = "";
			this.supp_account.Width = 75;
			// 
			// supplier_name
			// 
			this.supplier_name.Format = "";
			this.supplier_name.FormatInfo = null;
			this.supplier_name.HeaderText = "供应商名称";
			this.supplier_name.MappingName = "supplier_name";
			this.supplier_name.NullText = "";
			this.supplier_name.Width = 75;
			// 
			// paymentAccount_name
			// 
			this.paymentAccount_name.Format = "";
			this.paymentAccount_name.FormatInfo = null;
			this.paymentAccount_name.HeaderText = "付款条款";
			this.paymentAccount_name.MappingName = "paymentAccount_name";
			this.paymentAccount_name.NullText = "";
			this.paymentAccount_name.Width = 75;
			// 
			// paymentType_name
			// 
			this.paymentType_name.Format = "";
			this.paymentType_name.FormatInfo = null;
			this.paymentType_name.HeaderText = "付款方式";
			this.paymentType_name.MappingName = "paymentType_name";
			this.paymentType_name.NullText = "";
			this.paymentType_name.Width = 75;
			// 
			// currency_name
			// 
			this.currency_name.Format = "";
			this.currency_name.FormatInfo = null;
			this.currency_name.HeaderText = "币种";
			this.currency_name.MappingName = "currency_name";
			this.currency_name.NullText = "";
			this.currency_name.Width = 75;
			// 
			// amount
			// 
			this.amount.Format = "";
			this.amount.FormatInfo = null;
			this.amount.HeaderText = "总金额";
			this.amount.MappingName = "amount";
			this.amount.NullText = "";
			this.amount.Width = 75;
			// 
			// InsideAmount
			// 
			this.InsideAmount.Format = "";
			this.InsideAmount.FormatInfo = null;
			this.InsideAmount.HeaderText = "国内费用";
			this.InsideAmount.MappingName = "InsideAmount";
			this.InsideAmount.NullText = "";
			this.InsideAmount.Width = 75;
			// 
			// InsideFreight
			// 
			this.InsideFreight.Format = "";
			this.InsideFreight.FormatInfo = null;
			this.InsideFreight.HeaderText = "国内运费";
			this.InsideFreight.MappingName = "InsideFreight";
			this.InsideFreight.NullText = "";
			this.InsideFreight.Width = 75;
			// 
			// discountType
			// 
			this.discountType.Format = "";
			this.discountType.FormatInfo = null;
			this.discountType.HeaderText = "折扣类型";
			this.discountType.MappingName = "discountType";
			this.discountType.NullText = "";
			this.discountType.Width = 75;
			// 
			// discount
			// 
			this.discount.Format = "";
			this.discount.FormatInfo = null;
			this.discount.HeaderText = "折扣";
			this.discount.MappingName = "discount";
			this.discount.NullText = "";
			this.discount.Width = 75;
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
			// createby
			// 
			this.createby.Format = "";
			this.createby.FormatInfo = null;
			this.createby.HeaderText = "创建者";
			this.createby.MappingName = "createby";
			this.createby.NullText = "";
			this.createby.Width = 75;
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
			// modifyby
			// 
			this.modifyby.Format = "";
			this.modifyby.FormatInfo = null;
			this.modifyby.HeaderText = "最后修改人";
			this.modifyby.MappingName = "modifyby";
			this.modifyby.NullText = "";
			this.modifyby.Width = 75;
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
			this.approvedon.HeaderText = "审核时间";
			this.approvedon.MappingName = "approvedon";
			this.approvedon.NullText = "";
			this.approvedon.Width = 75;
			// 
			// panel4
			// 
			this.panel4.BackColor = System.Drawing.SystemColors.ScrollBar;
			this.panel4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel4.BackgroundImage")));
			this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.panel4.Controls.Add(this.priDateTimePicker3);
			this.panel4.Controls.Add(this.label13);
			this.panel4.Controls.Add(this.priTextBox4);
			this.panel4.Controls.Add(this.label6);
			this.panel4.Controls.Add(this.priTextBox2);
			this.panel4.Controls.Add(this.linkLabel1);
			this.panel4.Controls.Add(this.priComboBox2);
			this.panel4.Controls.Add(this.priComboBox5);
			this.panel4.Controls.Add(this.priComboBox4);
			this.panel4.Controls.Add(this.priComboBox3);
			this.panel4.Controls.Add(this.priComboBox1);
			this.panel4.Controls.Add(this.priComboBox6);
			this.panel4.Controls.Add(this.label28);
			this.panel4.Controls.Add(this.txt14);
			this.panel4.Controls.Add(this.label29);
			this.panel4.Controls.Add(this.txt13);
			this.panel4.Controls.Add(this.label34);
			this.panel4.Controls.Add(this.label32);
			this.panel4.Controls.Add(this.txt10);
			this.panel4.Controls.Add(this.label25);
			this.panel4.Controls.Add(this.txt9);
			this.panel4.Controls.Add(this.label16);
			this.panel4.Controls.Add(this.txt8);
			this.panel4.Controls.Add(this.label23);
			this.panel4.Controls.Add(this.label24);
			this.panel4.Controls.Add(this.txt7);
			this.panel4.Controls.Add(this.label18);
			this.panel4.Controls.Add(this.label19);
			this.panel4.Controls.Add(this.txt6);
			this.panel4.Controls.Add(this.label9);
			this.panel4.Controls.Add(this.txt5);
			this.panel4.Controls.Add(this.label5);
			this.panel4.Controls.Add(this.label3);
			this.panel4.Controls.Add(this.txt4);
			this.panel4.Controls.Add(this.label21);
			this.panel4.Controls.Add(this.txt16);
			this.panel4.Controls.Add(this.label20);
			this.panel4.Controls.Add(this.txt12);
			this.panel4.Controls.Add(this.label17);
			this.panel4.Controls.Add(this.label15);
			this.panel4.Controls.Add(this.label12);
			this.panel4.Controls.Add(this.label11);
			this.panel4.Controls.Add(this.label8);
			this.panel4.Controls.Add(this.label7);
			this.panel4.Controls.Add(this.label2);
			this.panel4.Controls.Add(this.txt11);
			this.panel4.Controls.Add(this.txt15);
			this.panel4.Controls.Add(this.txt1);
			this.panel4.Controls.Add(this.priDateTimePicker1);
			this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel4.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.panel4.Location = new System.Drawing.Point(0, 0);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(788, 248);
			this.panel4.TabIndex = 0;
			// 
			// priDateTimePicker3
			// 
			this.priDateTimePicker3.CustomFormat = "yyyy-MM-dd";
			this.priDateTimePicker3.DataField = "po_date";
			this.priDateTimePicker3.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.priDateTimePicker3.Location = new System.Drawing.Point(272, 48);
			this.priDateTimePicker3.Name = "priDateTimePicker3";
			this.priDateTimePicker3.Size = new System.Drawing.Size(112, 23);
			this.priDateTimePicker3.TabIndex = 214;
			// 
			// label13
			// 
			this.label13.BackColor = System.Drawing.Color.Transparent;
			this.label13.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.label13.ForeColor = System.Drawing.Color.Blue;
			this.label13.Location = new System.Drawing.Point(200, 168);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(72, 23);
			this.label13.TabIndex = 203;
			this.label13.Text = "国内运费";
			this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// priTextBox4
			// 
			this.priTextBox4.BackColor = System.Drawing.Color.Yellow;
			this.priTextBox4.DataField = "InsideFreight";
			this.priTextBox4.DataType = TJSystem.Public.DataType.String;
			this.priTextBox4.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.priTextBox4.Location = new System.Drawing.Point(272, 168);
			this.priTextBox4.Name = "priTextBox4";
			this.priTextBox4.Size = new System.Drawing.Size(104, 23);
			this.priTextBox4.TabIndex = 204;
			this.priTextBox4.Text = "";
			// 
			// label6
			// 
			this.label6.BackColor = System.Drawing.Color.Transparent;
			this.label6.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.label6.ForeColor = System.Drawing.Color.Blue;
			this.label6.Location = new System.Drawing.Point(16, 168);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(72, 23);
			this.label6.TabIndex = 199;
			this.label6.Text = "国内费用";
			this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// priTextBox2
			// 
			this.priTextBox2.BackColor = System.Drawing.Color.Yellow;
			this.priTextBox2.DataField = "InsideAmount";
			this.priTextBox2.DataType = TJSystem.Public.DataType.String;
			this.priTextBox2.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.priTextBox2.Location = new System.Drawing.Point(96, 168);
			this.priTextBox2.Name = "priTextBox2";
			this.priTextBox2.Size = new System.Drawing.Size(104, 23);
			this.priTextBox2.TabIndex = 200;
			this.priTextBox2.Text = "";
			// 
			// linkLabel1
			// 
			this.linkLabel1.AutoSize = true;
			this.linkLabel1.BackColor = System.Drawing.Color.Transparent;
			this.linkLabel1.Location = new System.Drawing.Point(56, 224);
			this.linkLabel1.Name = "linkLabel1";
			this.linkLabel1.Size = new System.Drawing.Size(63, 19);
			this.linkLabel1.TabIndex = 196;
			this.linkLabel1.TabStop = true;
			this.linkLabel1.Text = "采购明细";
			this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
			// 
			// priComboBox2
			// 
			this.priComboBox2.BackColor = System.Drawing.Color.White;
			this.priComboBox2.DataField = "supplier_id";
			this.priComboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.priComboBox2.Location = new System.Drawing.Point(96, 72);
			this.priComboBox2.Name = "priComboBox2";
			this.priComboBox2.Size = new System.Drawing.Size(104, 22);
			this.priComboBox2.TabIndex = 195;
			this.priComboBox2.SelectionChangeCommitted += new System.EventHandler(this.priComboBox2_SelectionChangeCommitted);
			// 
			// priComboBox5
			// 
			this.priComboBox5.BackColor = System.Drawing.Color.White;
			this.priComboBox5.DataField = "paymentType";
			this.priComboBox5.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.priComboBox5.Location = new System.Drawing.Point(504, 96);
			this.priComboBox5.Name = "priComboBox5";
			this.priComboBox5.Size = new System.Drawing.Size(136, 22);
			this.priComboBox5.TabIndex = 194;
			// 
			// priComboBox4
			// 
			this.priComboBox4.BackColor = System.Drawing.Color.White;
			this.priComboBox4.DataField = "paymentAccount";
			this.priComboBox4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.priComboBox4.Location = new System.Drawing.Point(272, 96);
			this.priComboBox4.Name = "priComboBox4";
			this.priComboBox4.Size = new System.Drawing.Size(144, 22);
			this.priComboBox4.TabIndex = 193;
			// 
			// priComboBox3
			// 
			this.priComboBox3.BackColor = System.Drawing.Color.White;
			this.priComboBox3.DataField = "Contact_id";
			this.priComboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.priComboBox3.Location = new System.Drawing.Point(272, 72);
			this.priComboBox3.Name = "priComboBox3";
			this.priComboBox3.Size = new System.Drawing.Size(120, 22);
			this.priComboBox3.TabIndex = 192;
			this.priComboBox3.SelectionChangeCommitted += new System.EventHandler(this.priComboBox3_SelectionChangeCommitted);
			// 
			// priComboBox1
			// 
			this.priComboBox1.BackColor = System.Drawing.Color.White;
			this.priComboBox1.DataField = "status";
			this.priComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.priComboBox1.Location = new System.Drawing.Point(448, 48);
			this.priComboBox1.Name = "priComboBox1";
			this.priComboBox1.Size = new System.Drawing.Size(120, 22);
			this.priComboBox1.TabIndex = 179;
			this.priComboBox1.SelectionChangeCommitted += new System.EventHandler(this.priComboBox1_SelectionChangeCommitted);
			// 
			// priComboBox6
			// 
			this.priComboBox6.BackColor = System.Drawing.Color.White;
			this.priComboBox6.DataField = "currency";
			this.priComboBox6.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.priComboBox6.Location = new System.Drawing.Point(96, 120);
			this.priComboBox6.Name = "priComboBox6";
			this.priComboBox6.Size = new System.Drawing.Size(104, 22);
			this.priComboBox6.TabIndex = 178;
			// 
			// label28
			// 
			this.label28.BackColor = System.Drawing.Color.Transparent;
			this.label28.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.label28.Location = new System.Drawing.Point(560, 192);
			this.label28.Name = "label28";
			this.label28.Size = new System.Drawing.Size(64, 23);
			this.label28.TabIndex = 172;
			this.label28.Text = "审核时间";
			this.label28.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txt14
			// 
			this.txt14.BackColor = System.Drawing.Color.White;
			this.txt14.DataField = "approvedon";
			this.txt14.DataType = TJSystem.Public.DataType.String;
			this.txt14.Enabled = false;
			this.txt14.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.txt14.Location = new System.Drawing.Point(632, 192);
			this.txt14.Name = "txt14";
			this.txt14.Size = new System.Drawing.Size(128, 23);
			this.txt14.TabIndex = 171;
			this.txt14.Text = "";
			// 
			// label29
			// 
			this.label29.BackColor = System.Drawing.Color.Transparent;
			this.label29.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.label29.Location = new System.Drawing.Point(376, 192);
			this.label29.Name = "label29";
			this.label29.Size = new System.Drawing.Size(48, 23);
			this.label29.TabIndex = 170;
			this.label29.Text = "审核者";
			this.label29.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txt13
			// 
			this.txt13.BackColor = System.Drawing.Color.White;
			this.txt13.DataField = "approvedBy";
			this.txt13.DataType = TJSystem.Public.DataType.String;
			this.txt13.Enabled = false;
			this.txt13.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.txt13.Location = new System.Drawing.Point(432, 192);
			this.txt13.Name = "txt13";
			this.txt13.Size = new System.Drawing.Size(120, 23);
			this.txt13.TabIndex = 169;
			this.txt13.Text = "";
			// 
			// label34
			// 
			this.label34.BackColor = System.Drawing.Color.Transparent;
			this.label34.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.label34.ForeColor = System.Drawing.Color.Blue;
			this.label34.Location = new System.Drawing.Point(432, 96);
			this.label34.Name = "label34";
			this.label34.Size = new System.Drawing.Size(64, 23);
			this.label34.TabIndex = 166;
			this.label34.Text = "付款方式";
			this.label34.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label32
			// 
			this.label32.BackColor = System.Drawing.Color.Transparent;
			this.label32.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.label32.Location = new System.Drawing.Point(56, 144);
			this.label32.Name = "label32";
			this.label32.Size = new System.Drawing.Size(40, 23);
			this.label32.TabIndex = 156;
			this.label32.Text = "备注";
			this.label32.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txt10
			// 
			this.txt10.BackColor = System.Drawing.Color.White;
			this.txt10.DataField = "remark";
			this.txt10.DataType = TJSystem.Public.DataType.String;
			this.txt10.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.txt10.Location = new System.Drawing.Point(96, 144);
			this.txt10.Name = "txt10";
			this.txt10.Size = new System.Drawing.Size(664, 23);
			this.txt10.TabIndex = 157;
			this.txt10.Text = "";
			// 
			// label25
			// 
			this.label25.BackColor = System.Drawing.Color.Transparent;
			this.label25.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.label25.ForeColor = System.Drawing.Color.Blue;
			this.label25.Location = new System.Drawing.Point(584, 120);
			this.label25.Name = "label25";
			this.label25.Size = new System.Drawing.Size(40, 23);
			this.label25.TabIndex = 136;
			this.label25.Text = "折扣";
			this.label25.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txt9
			// 
			this.txt9.BackColor = System.Drawing.Color.Yellow;
			this.txt9.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txt9.DataField = "discount";
			this.txt9.DataType = TJSystem.Public.DataType.String;
			this.txt9.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.txt9.Location = new System.Drawing.Point(632, 120);
			this.txt9.Name = "txt9";
			this.txt9.Size = new System.Drawing.Size(128, 23);
			this.txt9.TabIndex = 137;
			this.txt9.Text = "";
			// 
			// label16
			// 
			this.label16.BackColor = System.Drawing.Color.Transparent;
			this.label16.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.label16.ForeColor = System.Drawing.Color.Blue;
			this.label16.Location = new System.Drawing.Point(376, 120);
			this.label16.Name = "label16";
			this.label16.Size = new System.Drawing.Size(64, 23);
			this.label16.TabIndex = 134;
			this.label16.Text = "折扣类型";
			this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txt8
			// 
			this.txt8.BackColor = System.Drawing.Color.White;
			this.txt8.Cursor = System.Windows.Forms.Cursors.Arrow;
			this.txt8.DataField = "discountType";
			this.txt8.DataType = TJSystem.Public.DataType.String;
			this.txt8.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.txt8.Location = new System.Drawing.Point(448, 120);
			this.txt8.Name = "txt8";
			this.txt8.Size = new System.Drawing.Size(120, 23);
			this.txt8.TabIndex = 135;
			this.txt8.Text = "";
			// 
			// label23
			// 
			this.label23.BackColor = System.Drawing.Color.Transparent;
			this.label23.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.label23.ForeColor = System.Drawing.Color.Blue;
			this.label23.Location = new System.Drawing.Point(8, 120);
			this.label23.Name = "label23";
			this.label23.Size = new System.Drawing.Size(80, 23);
			this.label23.TabIndex = 131;
			this.label23.Text = "币种";
			this.label23.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label24
			// 
			this.label24.BackColor = System.Drawing.Color.Transparent;
			this.label24.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.label24.ForeColor = System.Drawing.Color.Blue;
			this.label24.Location = new System.Drawing.Point(200, 120);
			this.label24.Name = "label24";
			this.label24.Size = new System.Drawing.Size(56, 23);
			this.label24.TabIndex = 130;
			this.label24.Text = "总金额";
			this.label24.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txt7
			// 
			this.txt7.BackColor = System.Drawing.Color.Yellow;
			this.txt7.DataField = "amount";
			this.txt7.DataType = TJSystem.Public.DataType.String;
			this.txt7.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.txt7.Location = new System.Drawing.Point(264, 120);
			this.txt7.Name = "txt7";
			this.txt7.Size = new System.Drawing.Size(112, 23);
			this.txt7.TabIndex = 133;
			this.txt7.Text = "";
			// 
			// label18
			// 
			this.label18.BackColor = System.Drawing.Color.Transparent;
			this.label18.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.label18.Location = new System.Drawing.Point(208, 96);
			this.label18.Name = "label18";
			this.label18.Size = new System.Drawing.Size(64, 23);
			this.label18.TabIndex = 126;
			this.label18.Text = "付款条款";
			this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label19
			// 
			this.label19.BackColor = System.Drawing.Color.Transparent;
			this.label19.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.label19.Location = new System.Drawing.Point(8, 96);
			this.label19.Name = "label19";
			this.label19.Size = new System.Drawing.Size(80, 23);
			this.label19.TabIndex = 123;
			this.label19.Text = "名称";
			this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txt6
			// 
			this.txt6.BackColor = System.Drawing.Color.White;
			this.txt6.DataField = "supplier_name";
			this.txt6.DataType = TJSystem.Public.DataType.String;
			this.txt6.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.txt6.Location = new System.Drawing.Point(96, 96);
			this.txt6.Name = "txt6";
			this.txt6.Size = new System.Drawing.Size(104, 23);
			this.txt6.TabIndex = 124;
			this.txt6.Text = "";
			// 
			// label9
			// 
			this.label9.BackColor = System.Drawing.Color.Transparent;
			this.label9.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.label9.Location = new System.Drawing.Point(576, 72);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(80, 23);
			this.label9.TabIndex = 120;
			this.label9.Text = "供应商帐号";
			this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txt5
			// 
			this.txt5.BackColor = System.Drawing.Color.White;
			this.txt5.DataField = "supp_account";
			this.txt5.DataType = TJSystem.Public.DataType.String;
			this.txt5.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.txt5.Location = new System.Drawing.Point(656, 72);
			this.txt5.Name = "txt5";
			this.txt5.Size = new System.Drawing.Size(104, 23);
			this.txt5.TabIndex = 121;
			this.txt5.Text = "";
			// 
			// label5
			// 
			this.label5.BackColor = System.Drawing.Color.Transparent;
			this.label5.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.label5.ForeColor = System.Drawing.Color.Blue;
			this.label5.Location = new System.Drawing.Point(384, 48);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(48, 23);
			this.label5.TabIndex = 118;
			this.label5.Text = "状态";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label3
			// 
			this.label3.BackColor = System.Drawing.Color.Transparent;
			this.label3.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.label3.Location = new System.Drawing.Point(392, 72);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(40, 23);
			this.label3.TabIndex = 116;
			this.label3.Text = "姓名";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txt4
			// 
			this.txt4.BackColor = System.Drawing.Color.White;
			this.txt4.DataField = "contact_name";
			this.txt4.DataType = TJSystem.Public.DataType.String;
			this.txt4.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.txt4.Location = new System.Drawing.Point(448, 72);
			this.txt4.Name = "txt4";
			this.txt4.Size = new System.Drawing.Size(120, 23);
			this.txt4.TabIndex = 117;
			this.txt4.Text = "";
			// 
			// label21
			// 
			this.label21.BackColor = System.Drawing.Color.Transparent;
			this.label21.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.label21.Location = new System.Drawing.Point(208, 192);
			this.label21.Name = "label21";
			this.label21.Size = new System.Drawing.Size(64, 23);
			this.label21.TabIndex = 42;
			this.label21.Text = "修改时间";
			this.label21.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txt16
			// 
			this.txt16.BackColor = System.Drawing.Color.White;
			this.txt16.DataField = "modifyon";
			this.txt16.DataType = TJSystem.Public.DataType.String;
			this.txt16.Enabled = false;
			this.txt16.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.txt16.Location = new System.Drawing.Point(272, 192);
			this.txt16.Name = "txt16";
			this.txt16.Size = new System.Drawing.Size(104, 23);
			this.txt16.TabIndex = 41;
			this.txt16.Text = "";
			// 
			// label20
			// 
			this.label20.BackColor = System.Drawing.Color.Transparent;
			this.label20.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.label20.Location = new System.Drawing.Point(560, 168);
			this.label20.Name = "label20";
			this.label20.Size = new System.Drawing.Size(64, 23);
			this.label20.TabIndex = 40;
			this.label20.Text = "创建时间";
			this.label20.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txt12
			// 
			this.txt12.BackColor = System.Drawing.Color.White;
			this.txt12.DataField = "createon";
			this.txt12.DataType = TJSystem.Public.DataType.String;
			this.txt12.Enabled = false;
			this.txt12.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.txt12.Location = new System.Drawing.Point(632, 168);
			this.txt12.Name = "txt12";
			this.txt12.Size = new System.Drawing.Size(128, 23);
			this.txt12.TabIndex = 39;
			this.txt12.Text = "";
			// 
			// label17
			// 
			this.label17.BackColor = System.Drawing.Color.Transparent;
			this.label17.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.label17.Location = new System.Drawing.Point(8, 192);
			this.label17.Name = "label17";
			this.label17.Size = new System.Drawing.Size(80, 23);
			this.label17.TabIndex = 32;
			this.label17.Text = "最后修改者";
			this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label15
			// 
			this.label15.BackColor = System.Drawing.Color.Transparent;
			this.label15.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.label15.Location = new System.Drawing.Point(376, 168);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(56, 23);
			this.label15.TabIndex = 29;
			this.label15.Text = "创建者";
			this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label12
			// 
			this.label12.BackColor = System.Drawing.Color.Transparent;
			this.label12.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.label12.Location = new System.Drawing.Point(576, 48);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(48, 23);
			this.label12.TabIndex = 26;
			this.label12.Text = "交货期";
			this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label11
			// 
			this.label11.BackColor = System.Drawing.Color.Transparent;
			this.label11.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.label11.ForeColor = System.Drawing.Color.Blue;
			this.label11.Location = new System.Drawing.Point(8, 72);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(80, 23);
			this.label11.TabIndex = 25;
			this.label11.Text = "供应商";
			this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label8
			// 
			this.label8.BackColor = System.Drawing.Color.Transparent;
			this.label8.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.label8.ForeColor = System.Drawing.Color.Blue;
			this.label8.Location = new System.Drawing.Point(208, 48);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(40, 23);
			this.label8.TabIndex = 22;
			this.label8.Text = "日期";
			this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label7
			// 
			this.label7.BackColor = System.Drawing.Color.Transparent;
			this.label7.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.label7.Location = new System.Drawing.Point(216, 72);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(48, 23);
			this.label7.TabIndex = 21;
			this.label7.Text = "联系人";
			this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label2
			// 
			this.label2.BackColor = System.Drawing.Color.Transparent;
			this.label2.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.label2.ForeColor = System.Drawing.Color.Blue;
			this.label2.Location = new System.Drawing.Point(8, 48);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(80, 23);
			this.label2.TabIndex = 16;
			this.label2.Text = "采购单号";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txt11
			// 
			this.txt11.BackColor = System.Drawing.Color.White;
			this.txt11.DataField = "createBy";
			this.txt11.DataType = TJSystem.Public.DataType.String;
			this.txt11.Enabled = false;
			this.txt11.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.txt11.Location = new System.Drawing.Point(432, 168);
			this.txt11.Name = "txt11";
			this.txt11.Size = new System.Drawing.Size(120, 23);
			this.txt11.TabIndex = 12;
			this.txt11.Text = "";
			// 
			// txt15
			// 
			this.txt15.BackColor = System.Drawing.Color.White;
			this.txt15.DataField = "modifyBy";
			this.txt15.DataType = TJSystem.Public.DataType.String;
			this.txt15.Enabled = false;
			this.txt15.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.txt15.Location = new System.Drawing.Point(96, 192);
			this.txt15.Name = "txt15";
			this.txt15.Size = new System.Drawing.Size(104, 23);
			this.txt15.TabIndex = 9;
			this.txt15.Text = "";
			// 
			// txt1
			// 
			this.txt1.BackColor = System.Drawing.Color.White;
			this.txt1.DataField = "po_code";
			this.txt1.DataType = TJSystem.Public.DataType.String;
			this.txt1.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.txt1.Location = new System.Drawing.Point(96, 48);
			this.txt1.Name = "txt1";
			this.txt1.Size = new System.Drawing.Size(104, 23);
			this.txt1.TabIndex = 100;
			this.txt1.Text = "";
			// 
			// priDateTimePicker1
			// 
			this.priDateTimePicker1.CustomFormat = "yyyy-MM-dd";
			this.priDateTimePicker1.DataField = "deliveryDate";
			this.priDateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.priDateTimePicker1.Location = new System.Drawing.Point(648, 48);
			this.priDateTimePicker1.Name = "priDateTimePicker1";
			this.priDateTimePicker1.Size = new System.Drawing.Size(112, 23);
			this.priDateTimePicker1.TabIndex = 214;
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
			// company_name
			// 
			this.company_name.Format = "";
			this.company_name.FormatInfo = null;
			this.company_name.HeaderText = "公司名称";
			this.company_name.MappingName = "company_name";
			this.company_name.NullText = "";
			this.company_name.Width = 75;
			// 
			// corporation
			// 
			this.corporation.Format = "";
			this.corporation.FormatInfo = null;
			this.corporation.HeaderText = "公司法人";
			this.corporation.MappingName = "corporation";
			this.corporation.NullText = "";
			this.corporation.Width = 75;
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
			// company_id
			// 
			this.company_id.Format = "";
			this.company_id.FormatInfo = null;
			this.company_id.HeaderText = "公司编号";
			this.company_id.MappingName = "company_id";
			this.company_id.NullText = "";
			this.company_id.Width = 75;
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
			// email1
			// 
			this.email1.Format = "";
			this.email1.FormatInfo = null;
			this.email1.HeaderText = "电子邮件1";
			this.email1.MappingName = "email1";
			this.email1.NullText = "";
			this.email1.Width = 75;
			// 
			// email2
			// 
			this.email2.Format = "";
			this.email2.FormatInfo = null;
			this.email2.HeaderText = "电子邮件2";
			this.email2.MappingName = "email2";
			this.email2.NullText = "";
			this.email2.Width = 75;
			// 
			// address_cn
			// 
			this.address_cn.Format = "";
			this.address_cn.FormatInfo = null;
			this.address_cn.HeaderText = "中文地址";
			this.address_cn.MappingName = "address_cn";
			this.address_cn.NullText = "";
			this.address_cn.Width = 75;
			// 
			// resume
			// 
			this.resume.Format = "";
			this.resume.FormatInfo = null;
			this.resume.HeaderText = "公司描述";
			this.resume.MappingName = "resume";
			this.resume.NullText = "";
			this.resume.Width = 75;
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
			this.priToolBar1.Location = new System.Drawing.Point(0, -4);
			this.priToolBar1.Name = "priToolBar1";
			this.priToolBar1.setCurrentForm = null;
			this.priToolBar1.Size = new System.Drawing.Size(788, 40);
			this.priToolBar1.TabIndex = 0;
			// 
			// gen_manager
			// 
			this.gen_manager.Format = "";
			this.gen_manager.FormatInfo = null;
			this.gen_manager.HeaderText = "总经理";
			this.gen_manager.MappingName = "gen_manager";
			this.gen_manager.NullText = "";
			this.gen_manager.Width = 75;
			// 
			// fax1
			// 
			this.fax1.Format = "";
			this.fax1.FormatInfo = null;
			this.fax1.HeaderText = "传真1";
			this.fax1.MappingName = "fax1";
			this.fax1.NullText = "";
			this.fax1.Width = 75;
			// 
			// frmPurchasePO
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(7, 16);
			this.BackColor = System.Drawing.SystemColors.ScrollBar;
			this.ClientSize = new System.Drawing.Size(792, 566);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel3);
			this.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "frmPurchasePO";
			this.Text = "采购订单";
			this.panel1.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).EndInit();
			this.panel4.ResumeLayout(false);
			this.panel3.ResumeLayout(false);
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
				TJSystem.Public.PublicStatic.formName = "采购订单";
			}
			base.OnClosing (e);
		}

		private void priComboBox2_SelectionChangeCommitted(object sender, System.EventArgs e)
		{
			string sql = "select  a.supplier_name as supplier_name, b.contact_id, b.contact_id +' '+b.contact_name as contact_name  from basic_supplier a join basic_supplier_contact b on a.supplier_id = b.supplier_id and a.supplier_id = '"+ this.priComboBox2.SelectedValue +"'";
			DataTable dt = TJSystem.Public.PublicStatic.db.GetDataTable(sql);
			DataTable dtcpy = null;
			DataRow dr = null;
			dr= dt.NewRow();
			dr[0] = "";
			dr[1] = "";
			dr[2] = "";
			dt.Rows.InsertAt(dr,0);
			dtcpy =dt.Copy();
			this.priComboBox3.DataSource = dtcpy.DefaultView;
			this.priComboBox3.ValueMember = "contact_id";
			this.priComboBox3.DisplayMember = "contact_name";
			this.priComboBox3.Enabled = true;
			sql = "select a.supplier_name as supplier_name,c.Account as Account from basic_supplier a join basic_supplier_bank c on a.supplier_id = c.supplier_id where a.supplier_id = '"+ this.priComboBox2.SelectedValue +"'";
			dt = TJSystem.Public.PublicStatic.db.GetDataTable(sql);
			if(!dt.Rows.Count.Equals(0))
			{
				this.txt5.Text = dt.Rows[0]["Account"].ToString();
				this.txt6.Text = dt.Rows[0]["supplier_name"].ToString();
			}
		}

		private void priComboBox3_SelectionChangeCommitted(object sender, System.EventArgs e)
		{
			string sql = "select contact_name from basic_supplier_contact where supplier_id = '"+ this.priComboBox2.SelectedValue +"' and contact_id = '"+ this.priComboBox3.SelectedValue +"'";
			DataTable dt = TJSystem.Public.PublicStatic.db.GetDataTable(sql);
			if (dt.Rows.Count == 0)
			{
				return;
			}
			this.txt4.Text = dt.Rows[0]["contact_name"].ToString();
		}

		private void linkLabel1_LinkClicked(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
		{
//			if(Count< 1)
			{
				if (this.txt1.Text.ToString().Trim() == "" )
				{
					TJSystem.Public.PublicStatic.ShowMessage(TJSystem.Public.MessageType.Exclamation,"请选择一张采购单单号");
					return;
				}
				else
				{
					frmPurchasePODetail frmPODetail = new frmPurchasePODetail(this.txt1.Text.ToString().Trim());
					frmPODetail.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
					frmPODetail.ShowDialog();
					Count += 1;
				}			
				
			}
		}

		private void priComboBox1_SelectionChangeCommitted(object sender, System.EventArgs e)
		{
			TJSystem.Public.PublicStatic.SetApprovedInfo(this.priComboBox1,this.txt13,this.txt14);
		}
	}
}

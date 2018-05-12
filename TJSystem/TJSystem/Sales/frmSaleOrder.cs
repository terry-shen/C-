using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace TJSystem.Sales
{
	/// <summary>
	/// Form1 的摘要说明。
	/// </summary>
	public class frmSaleOrder : System.Windows.Forms.Form
	{
		
		
		/// <summary>
		/// 必需的设计器变量。
		/// </summary>
		private System.ComponentModel.Container components = null;
		private System.Windows.Forms.DataGridTextBoxColumn fax1;
		private System.Windows.Forms.DataGridTextBoxColumn email2;
		private System.Windows.Forms.DataGridTextBoxColumn address_cn;
		private System.Windows.Forms.DataGridTextBoxColumn company_name;
		private System.Windows.Forms.DataGridTextBoxColumn company_name_cn;
		private System.Windows.Forms.DataGridTextBoxColumn email1;
		private System.Windows.Forms.DataGridTextBoxColumn tel1;
		private System.Windows.Forms.DataGridTextBoxColumn resume;
		private System.Windows.Forms.DataGridTextBoxColumn gen_manager;
		private System.Windows.Forms.Panel panel3;
		private TJSystem.UC.PriToolBar priToolBar1;
		private System.Windows.Forms.DataGridTextBoxColumn postcode;
		
		private System.Windows.Forms.DataGridTextBoxColumn address;
		private System.Windows.Forms.DataGridTextBoxColumn corporation;
		private System.Windows.Forms.DataGridTextBoxColumn company_id;		
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.DataGrid dataGrid1;
		private System.Windows.Forms.Panel panel4;
		private System.Windows.Forms.Label label32;
		private System.Windows.Forms.Label label27;
		private System.Windows.Forms.Label label26;
		private System.Windows.Forms.Label label25;
		private System.Windows.Forms.Label label16;
		private System.Windows.Forms.Label label23;
		private System.Windows.Forms.Label label24;
		private System.Windows.Forms.Label label18;
		private System.Windows.Forms.Label label19;
		private System.Windows.Forms.Label label9;
		private TJSystem.Classes.PriTextBox txt8;
		private System.Windows.Forms.Label label5;
		private TJSystem.Classes.PriTextBox txt3;
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
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.DataGridTextBoxColumn fax2;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.DataGridTextBoxColumn website;
		private System.Windows.Forms.DataGridTextBoxColumn tel2;
		private System.Windows.Forms.Label label22;
		private System.Windows.Forms.Label label34;
		private System.Windows.Forms.Label label35;
		private System.Windows.Forms.Label label28;
		private System.Windows.Forms.Label label29;
		private TJSystem.Classes.PriTextBox txt25;
		private TJSystem.Classes.PriTextBox txt17;
		private TJSystem.Classes.PriTextBox txt16;
		private TJSystem.Classes.PriTextBox txt15;
		private TJSystem.Classes.PriTextBox txt11;
		private TJSystem.Classes.PriTextBox txt31;
		private TJSystem.Classes.PriTextBox txt27;
		private TJSystem.Classes.PriTextBox txt26;
		private TJSystem.Classes.PriTextBox txt30;
		private TJSystem.Classes.PriTextBox txt13;
		private TJSystem.Classes.PriTextBox txt12;
		private TJSystem.Classes.PriTextBox txt29;
		private TJSystem.Classes.PriTextBox txt28;
		private TJSystem.Classes.PriTextBox txt6;
		public static System.Windows.Forms.Form frmCurrent = null ;
		private TJSystem.Classes.PriComboBox priComboBox2;
		private TJSystem.Classes.PriComboBox priComboBox3;
		private TJSystem.Classes.PriComboBox priComboBox4;
		private TJSystem.Classes.PriComboBox priComboBox5;
		private TJSystem.Classes.PriComboBox priComboBox6;
		private TJSystem.Classes.PriComboBox priComboBox7;
		private TJSystem.Classes.PriComboBox priComboBox8;
		private TJSystem.Classes.PriComboBox priComboBox9;
		private TJSystem.Classes.PriComboBox priComboBox10;
		public string _PK;
		private System.Windows.Forms.LinkLabel lk_detail;
		private System.Windows.Forms.LinkLabel linkLabel1;
		private TJSystem.Classes.PriTextBox priTextBox1;
		private TJSystem.Classes.PriComboBox priComboBox11;
		private System.Windows.Forms.DataGridTableStyle dataGridTableStyle1;
		private System.Windows.Forms.DataGridTextBoxColumn so_code;
		private System.Windows.Forms.DataGridTextBoxColumn so_date;
		private System.Windows.Forms.DataGridTextBoxColumn client_orderNo;
		private System.Windows.Forms.DataGridTextBoxColumn client_id;
		private System.Windows.Forms.DataGridTextBoxColumn client_name;
		private System.Windows.Forms.DataGridTextBoxColumn contact_name;
		private System.Windows.Forms.DataGridTextBoxColumn discounttype;
		private System.Windows.Forms.DataGridTextBoxColumn discount;
		private System.Windows.Forms.DataGridTextBoxColumn settlementtype;
		private System.Windows.Forms.DataGridTextBoxColumn fobamount;
		private System.Windows.Forms.DataGridTextBoxColumn brightcommision;
		private System.Windows.Forms.DataGridTextBoxColumn darkcommision;
		private System.Windows.Forms.DataGridTextBoxColumn deliverydate;
		private System.Windows.Forms.DataGridTextBoxColumn destination;
		private System.Windows.Forms.DataGridTextBoxColumn remark;
		private System.Windows.Forms.DataGridTextBoxColumn priceterm;
		private System.Windows.Forms.DataGridTextBoxColumn priceterm_dest;
		private string _statusType = null;
		private string _table = null;
		private TJSystem.Classes.PriDateTimePicker priDateTimePicker3;
		private System.Windows.Forms.LinkLabel linkLabel2;
		private System.Windows.Forms.Label label14;
		private TJSystem.Classes.PriTextBox priTextBox2;
		private System.Windows.Forms.DataGridTextBoxColumn amount;
		private TJSystem.Classes.PriDateTimePicker priDateTimePicker1;
		private System.Windows.Forms.Label label30;
		private TJSystem.Classes.PriTextBox priTextBox3;
		private System.Windows.Forms.DataGridTextBoxColumn insurance;
		private System.Windows.Forms.DataGridTextBoxColumn freightamount;
		private System.Windows.Forms.DataGridTextBoxColumn createby;
		private System.Windows.Forms.DataGridTextBoxColumn createon;
		private System.Windows.Forms.DataGridTextBoxColumn modifyby;
		private System.Windows.Forms.DataGridTextBoxColumn modifyon;
		private System.Windows.Forms.DataGridTextBoxColumn approvedby;
		private System.Windows.Forms.DataGridTextBoxColumn approvedon;
		private System.Windows.Forms.DataGridTextBoxColumn currency_name;
		private System.Windows.Forms.DataGridTextBoxColumn transType_name;
		private System.Windows.Forms.DataGridTextBoxColumn arriveregion_name;
		private System.Windows.Forms.DataGridTextBoxColumn Port_departure_name;
		private System.Windows.Forms.DataGridTextBoxColumn arrivecountry_name;
		private System.Windows.Forms.DataGridTextBoxColumn destport_name;
		private System.Windows.Forms.LinkLabel linkLabel3;
		private TJSystem.Classes.PriComboBox priComboBox12;
		private System.Windows.Forms.Label label33;
		private TJSystem.Classes.PriComboBox priComboBox13;
		private System.Windows.Forms.Label label36;
		private System.Windows.Forms.LinkLabel linkLabel4;
		private System.Windows.Forms.Label label37;
		private TJSystem.Classes.PriTextBox priTextBox5;
		private System.Windows.Forms.DataGridTextBoxColumn bargainon;
		private TJSystem.Classes.PriTextBox priTextBox6;
		public static int Count = 0;
		private System.Windows.Forms.CheckBox checkBox1;
		private TJSystem.Classes.PriComboBox priComboBox1;
		private System.Windows.Forms.DataGridTextBoxColumn status_name;
		private string menu_id = null;

		private string _PKSubValue = null;

		public frmSaleOrder()
		{
			this.menu_id = "";
			//
			// Windows 窗体设计器支持所必需的
			//
			InitializeComponent();

			SetCurrentMenuID();
			

			_statusType = "sales";
			TJSystem.Public.PublicStatic.setBackgroundImg(this.panel1,this.panel1.GetType().ToString(),"images\\bg.gif");
			TJSystem.Public.PublicStatic.setBackgroundImg(this.panel2,this.panel1.GetType().ToString(),"");
			TJSystem.Public.PublicStatic.setBackgroundImg(this.panel3,this.panel1.GetType().ToString(),"");
			TJSystem.Public.PublicStatic.setBackgroundImg(this.panel4,this.panel1.GetType().ToString(),"");

			InitialFormData();
			System.Text.StringBuilder sb = new System.Text.StringBuilder();
			sb.Append("select a.so_code,a.so_date,a.client_orderNo,a.client_id,a.client_name,a.Contact_id,");
			sb.Append(" a.Contact_name,a.Currency,c.Currency_namecn as Currency_name,a.priceTerm,a.priceTerm_dest,");
			sb.Append(" a.discountType,a.discount,a.settlementType,a.amount,a.fobamount,a.insurance,a.freightamount,");
			sb.Append(" a.brightcommision,a.darkcommision,a.deliverydate,a.transType,d.trans_namecn as transType_name,a.arriveregion,e.region_namecn as arriveregion_name,");
			sb.Append(" a.arrivecountry,g.country_namecn as arrivecountry_name,a.Port_departure,f.port_namecn as Port_departure_name,a.destport,h.port_namecn as destport_name,a.destination,a.marks,");
			sb.Append(" a.remark,a.saleTerm_ID,a.saleConf_ID,a.createBy,a.createon,a.approvedBy,a.approvedon,a.modifyBy,a.modifyon,a.confirmedBy,a.confirmedon,a.bargainon, ");
			sb.Append(" a.status,b.status_name as status_name,a.visible_flag");
			sb.Append(" from sale_so_master a");
			sb.Append(" left join p_status b");
			sb.Append(" on a.status = b.status_id and b.status_type = '"+_statusType+"'");
			sb.Append(" left join p_currency c");
			sb.Append(" on a.Currency = c.Currency_code");
			sb.Append(" left join p_transtype d");
			sb.Append(" on a.transType = d.trans_code");
			sb.Append(" left join p_region e");
			sb.Append(" on a.arriveregion = e.region_code ");
			sb.Append(" left join p_port f");
			sb.Append(" on a.Port_departure = f.port_code");
			sb.Append(" left join p_country g");
			sb.Append(" on a.arrivecountry = g.country_code");
			sb.Append(" left join p_port h");
			sb.Append(" on a.destport = h.port_code");
			sb.Append(" where a.visible_flag<>'N'");
			sb.Append(" and a.status in ('1','2')");
			sb.Append(" order by a.so_code");
			this.InitialGrid(sb.ToString());

			priToolBar1.setCurrentForm = this;
			_PK = "so_code";
			_table = "sale_so_master";
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

		public frmSaleOrder(string customid)
		{
			this.menu_id = "";
			//
			// Windows 窗体设计器支持所必需的
			//
			InitializeComponent();

			SetCurrentMenuID();
			

			_statusType = "sales";
			TJSystem.Public.PublicStatic.setBackgroundImg(this.panel1,this.panel1.GetType().ToString(),"images\\bg.gif");
			TJSystem.Public.PublicStatic.setBackgroundImg(this.panel2,this.panel1.GetType().ToString(),"");
			TJSystem.Public.PublicStatic.setBackgroundImg(this.panel3,this.panel1.GetType().ToString(),"");
			TJSystem.Public.PublicStatic.setBackgroundImg(this.panel4,this.panel1.GetType().ToString(),"");

			InitialFormData();
			System.Text.StringBuilder sb = new System.Text.StringBuilder();
			sb.Append("select a.so_code,a.so_date,a.client_orderNo,a.client_id,a.client_name,a.Contact_id,");
			sb.Append(" a.Contact_name,a.Currency,c.Currency_namecn as Currency_name,a.priceTerm,a.priceTerm_dest,");
			sb.Append(" a.discountType,a.discount,a.settlementType,a.amount,a.fobamount,a.insurance,a.freightamount,");
			sb.Append(" a.brightcommision,a.darkcommision,a.deliverydate,a.transType,d.trans_namecn as transType_name,a.arriveregion,e.region_namecn as arriveregion_name,");
			sb.Append(" a.arrivecountry,g.country_namecn as arrivecountry_name,a.Port_departure,f.port_namecn as Port_departure_name,a.destport,h.port_namecn as destport_name,a.destination,a.marks,");
			sb.Append(" a.remark,a.saleTerm_ID,a.saleConf_ID,a.createBy,a.createon,a.approvedBy,a.approvedon,a.modifyBy,a.modifyon,a.confirmedBy,a.confirmedon,a.bargainon, ");
			sb.Append(" a.status,b.status_name as status_name,a.visible_flag");
			sb.Append(" from sale_so_master a");
			sb.Append(" left join p_status b");
			sb.Append(" on a.status = b.status_id and b.status_type = '"+_statusType+"'");
			sb.Append(" left join p_currency c");
			sb.Append(" on a.Currency = c.Currency_code");
			sb.Append(" left join p_transtype d");
			sb.Append(" on a.transType = d.trans_code");
			sb.Append(" left join p_region e");
			sb.Append(" on a.arriveregion = e.region_code ");
			sb.Append(" left join p_port f");
			sb.Append(" on a.Port_departure = f.port_code");
			sb.Append(" left join p_country g");
			sb.Append(" on a.arrivecountry = g.country_code");
			sb.Append(" left join p_port h");
			sb.Append(" on a.destport = h.port_code");
			sb.Append(" where a.client_id=");
			sb.Append("'");
			sb.Append(customid);
			sb.Append("'");
			sb.Append(" order by a.so_code");
			this.InitialGrid(sb.ToString());

			priToolBar1.setCurrentForm = this;
			_PK = "so_code";
			_table = "sale_so_master";
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
			string sql = "select Client_id,Client_id +' '+ Client_name as Client_name from basic_client order by Client_id";
			DataTable dt = TJSystem.Public.PublicStatic.db.GetDataTable(sql);
			dr = dt.NewRow() ;
			dr[0] = "" ;
			dr[1] = "" ;
			dt.Rows.InsertAt(dr,0) ;
			dtcpy = dt.Copy();
			this.priComboBox2.DataSource = dtcpy.DefaultView;
			this.priComboBox2.ValueMember = "Client_id";
			this.priComboBox2.DisplayMember = "Client_name";

			//状态
			if(TJSystem.Public.PublicStatic.Priority > 9)
			{
				sql = "select STATUS_ID,STATUS_ID+' '+STATUS_NAME as STATUS_NAME from p_status where status_type = '" + this._statusType + "' order by STATUS_ID";
			}
			else
			{
				sql = "select STATUS_ID,STATUS_ID+' '+STATUS_NAME as STATUS_NAME from p_status where status_type = '" + this._statusType + "' and status_id='1' order by STATUS_ID";
			}
			dt = TJSystem.Public.PublicStatic.db.GetDataTable(sql);
			dr = dt.NewRow() ;
			dr[0] = "" ;
			dr[1] = "" ;
			dt.Rows.InsertAt(dr,0) ;
			dtcpy = dt.Copy();
			this.priComboBox1.DataSource = dtcpy.DefaultView;
			this.priComboBox1.ValueMember = "STATUS_ID";
			this.priComboBox1.DisplayMember = "STATUS_NAME";
			
			/*
			sql = "select FLOW_ID,FLOW_ID+' '+FLOW_NAME as FLOW_NAME from brm_flow_det order by flow_id";
			dt = TJSystem.Public.PublicStatic.db.GetDataTable(sql);
			dr = dt.NewRow() ;
			dr[0] = "" ;
			dr[1] = "" ;
			dt.Rows.InsertAt(dr,0) ;
			dtcpy = dt.Copy();
			this.priComboBox14.DataSource = dtcpy.DefaultView;
			this.priComboBox14.ValueMember = "FLOW_ID";
			this.priComboBox14.DisplayMember = "FLOW_NAME";

			
			if(this.priComboBox14.SelectedValue.ToString().Equals(""))
			{
				sql = "select PROC_NO as SEQ_NO,PROC_NO+' '+PROC_NAME as PROC_NAME from brm_process order by proc_no";
			}
			else
			{
				sql = "select a.SEQ_NO,ltrim(str(a.SEQ_NO))+' '+a.PROC_NO+' '+b.proc_name as PROC_NAME from brm_flow_mstr a ";
				sql += " left join brm_process b  on a.proc_no=b.proc_no";
				sql += " where a.flow_id='" + priComboBox14.SelectedValue.ToString() + "'";
				sql += " order by a.seq_no";
			}
			dt = TJSystem.Public.PublicStatic.db.GetDataTable(sql);
			dr = dt.NewRow() ;
			dtcpy = dt.Copy();
			this.priComboBox1.DataSource = dtcpy.DefaultView;
			this.priComboBox1.ValueMember = "SEQ_NO";
			this.priComboBox1.DisplayMember = "PROC_NAME";
			*/

			sql = "select Currency_Code,Currency_Code+' '+Currency_nameCn as Currency_nameCn from p_Currency order by Currency_Code";
			dt = TJSystem.Public.PublicStatic.db.GetDataTable(sql);
			dr = dt.NewRow() ;
			dr[0] = "" ;
			dr[1] = "" ;
			dt.Rows.InsertAt(dr,0) ;
			dtcpy = dt.Copy();
			this.priComboBox3.DataSource = dtcpy.DefaultView;
			this.priComboBox3.ValueMember = "Currency_Code";
			this.priComboBox3.DisplayMember = "Currency_nameCn";

			sql = "select Term_Code,Term_Code +' '+Term_namecn as Term_namecn from p_priceTerm order by Term_Code";
			dt = TJSystem.Public.PublicStatic.db.GetDataTable(sql);
			dr = dt.NewRow() ;
			dr[0] = "" ;
			dr[1] = "" ;
			dt.Rows.InsertAt(dr,0) ;
			dtcpy = dt.Copy();
			this.priComboBox4.DataSource = dtcpy.DefaultView;
			this.priComboBox4.ValueMember = "Term_Code";
			this.priComboBox4.DisplayMember = "Term_namecn";

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

			sql = "select trans_code,trans_code+' '+trans_namecn as trans_namecn from p_transtype order by trans_code";
			dt = TJSystem.Public.PublicStatic.db.GetDataTable(sql);
			dr = dt.NewRow() ;
			dr[0] = "" ;
			dr[1] = "" ;
			dt.Rows.InsertAt(dr,0) ;
			dtcpy = dt.Copy();
			this.priComboBox6.DataSource = dtcpy.DefaultView;
			this.priComboBox6.ValueMember = "trans_code";
			this.priComboBox6.DisplayMember = "trans_namecn";

			sql = "select region_code,region_code+' '+region_namecn as region_namecn from p_region order by region_code";
			dt = TJSystem.Public.PublicStatic.db.GetDataTable(sql);
			dr = dt.NewRow() ;
			dr[0] = "" ;
			dr[1] = "" ;
			dt.Rows.InsertAt(dr,0) ;
			dtcpy = dt.Copy();
			this.priComboBox7.DataSource = dtcpy.DefaultView;
			this.priComboBox7.ValueMember = "region_code";
			this.priComboBox7.DisplayMember = "region_namecn";


			sql = "select port_code,port_code+' '+port_namecn as port_namecn from p_port order by port_code";
			dt = TJSystem.Public.PublicStatic.db.GetDataTable(sql);
			dr = dt.NewRow() ;
			dr[0] = "" ;
			dr[1] = "" ;
			dt.Rows.InsertAt(dr,0) ;
			dtcpy = dt.Copy();
			this.priComboBox8.DataSource = dtcpy.DefaultView;
			this.priComboBox8.ValueMember = "port_code";
			this.priComboBox8.DisplayMember = "port_namecn";


			sql = "select country_code,country_code+' '+country_namecn as country_namecn from p_country order by country_code";
			dt = TJSystem.Public.PublicStatic.db.GetDataTable(sql);
			dr = dt.NewRow() ;
			dr[0] = "" ;
			dr[1] = "" ;
			dt.Rows.InsertAt(dr,0) ;
			dtcpy = dt.Copy();
			this.priComboBox9.DataSource = dtcpy.DefaultView;
			this.priComboBox9.ValueMember = "country_code";
			this.priComboBox9.DisplayMember = "country_namecn";

			sql = "select port_code,port_code+' '+port_namecn as port_namecn from p_port order by port_code";
			dt = TJSystem.Public.PublicStatic.db.GetDataTable(sql);
			dr = dt.NewRow() ;
			dr[0] = "" ;
			dr[1] = "" ;
			dt.Rows.InsertAt(dr,0) ;
			dtcpy = dt.Copy();
			this.priComboBox10.DataSource = dtcpy.DefaultView;
			this.priComboBox10.ValueMember = "port_code";
			this.priComboBox10.DisplayMember = "port_namecn";

			sql = "select  a.client_name as client_name, b.contact_id, b.contact_id +' '+b.contact_name as contact_name  from basic_client a join basic_client_contact b on a.client_id = b.client_id and a.client_id = '"+ this.priComboBox2.SelectedValue +"'";
			dt = TJSystem.Public.PublicStatic.db.GetDataTable(sql);
			dr = dt.NewRow();
			dr[0] = "";
			dr[1] = "";
			dt.Rows.InsertAt(dr,0);
			dtcpy = dt.Copy();
			this.priComboBox11.DataSource = dtcpy.DefaultView;
			this.priComboBox11.ValueMember = "contact_id";
			this.priComboBox11.DisplayMember = "contact_name";

			sql = "select term_id,term_id+' '+term_name as term_name from BASIC_docterm order by term_id";
			dt = TJSystem.Public.PublicStatic.db.GetDataTable(sql);
			dr = dt.NewRow() ;
			dr[0] = "" ;
			dr[1] = "" ;
			dt.Rows.InsertAt(dr,0) ;
			dtcpy = dt.Copy();
			this.priComboBox12.DataSource = dtcpy.DefaultView;
			this.priComboBox12.ValueMember = "term_id";
			this.priComboBox12.DisplayMember = "term_name";

			sql = "select term_id,term_id+' '+term_name as term_name from BASIC_docterm order by term_id";
			dt = TJSystem.Public.PublicStatic.db.GetDataTable(sql);
			dr = dt.NewRow() ;
			dr[0] = "" ;
			dr[1] = "" ;
			dt.Rows.InsertAt(dr,0) ;
			dtcpy = dt.Copy();
			this.priComboBox13.DataSource = dtcpy.DefaultView;
			this.priComboBox13.ValueMember = "term_id";
			this.priComboBox13.DisplayMember = "term_name";
		}

		private void SetCurrentMenuID()
		{
			string sql = "select xf_currenthandle from xf_menutree where xf_programname='" + this.Text + "'";
			System.Data.DataTable dt = TJSystem.Public.PublicStatic.db.GetDataTable(sql);
			if(dt.Rows.Count == 1)
			{
				this.menu_id = dt.Rows[0][0].ToString();
			}
		}

		private bool BeforeButtonClick(string sqltype)
		{
			System.Text.StringBuilder sb = new System.Text.StringBuilder();
			sb.Append("数据验证错误：\r\n");
			if(sqltype.Equals("default"))
			{
				this.setDisable();
			}
			if(sqltype.Equals("insert")
				|| sqltype.Equals("update"))
			{
				if(!checkFormValue(sqltype,sb))
				{
					//					MessageBox.Show(sb.ToString(),"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
					return false;
				}
			}
			else if(sqltype.Equals("delete"))
			{
				/*
				if (!this.priComboBox1.SelectedValue.ToString().Equals("1")
					&& !this.priComboBox1.SelectedValue.ToString().Equals("0"))
				{
					TJSystem.Public.PublicStatic.ShowMessage(TJSystem.Public.MessageType.Exclamation, "只有处于新建和报废状态的销售单才能进行修改！");
					return false;
				}
				*/
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
					MessageBox.Show("请输入订单号","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
					return false;
				}
				if(TJSystem.Public.PublicStatic.IsExsist(this._table,this._PK,this.priToolBar1))
				{
					MessageBox.Show("这张订单已经存在,请另外开立","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
					return false;
				}
			}
				
			if (this.priComboBox2.SelectedIndex.Equals(-1))
			{
				MessageBox.Show("请输入客户代码","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
				return false;
			}

			//检查输入值的属性
			if (!TJSystem.Public.PublicStatic.IsNumDouble(this.txt15.Text))
			{
				MessageBox.Show("FOB金额必须是数字","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
				return false;
			}

			if (!TJSystem.Public.PublicStatic.IsNumDouble(this.txt16.Text))
			{
				MessageBox.Show("明佣必须是数字","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
				return false;
			}

			if (!TJSystem.Public.PublicStatic.IsNumDouble(this.txt17.Text))
			{
				MessageBox.Show("暗佣必须是数字","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
				return false;
			}	

			if(sqltype.Equals("insert"))
			{
				/*
				int ret = 0;
				PublicStatic.Classes.common.CommonSubTableHandle csth = new PublicStatic.Classes.common.CommonSubTableHandle();
				csth.TableName = "sale_so_detail";
				csth.PrimaryKeyField = "so_code";
				csth.PrimaryKeyValue = _PKSubValue;
				csth.PrimaryKeyNewValue = this.txt1.Text;
				ret = csth.SubTableInsert();
				if (ret == 100)
				{
					TJSystem.Public.PublicStatic.ShowMessage(TJSystem.Public.MessageType.Information,"原报价单中无货品资料！");
//					return true;
				}
				if (ret >0)
				{
					TJSystem.Public.PublicStatic.ShowMessage(TJSystem.Public.MessageType.Exclamation,"新报价单中的货品资料插入有问题，请进入明细单确认！");
//					return true;
				}		
				*/								
			}
			
			return true;
		}


		private bool CheckFlowProcValueble(string flow_id,string seq_no)
		{
			string sql = null;
			string pre_proc_no = null;
			string retString = null;
			System.Data.DataTable dt = null;
			sql = "select proc_no from sale_so_master where so_code = '" + this.txt1.Text.Trim() + "'";
			dt = TJSystem.Public.PublicStatic.db.GetDataTable(sql);
			if(dt.Rows.Count == 0)
			{
				TJSystem.Public.PublicStatic.ShowMessage(TJSystem.Public.MessageType.Error,"找不到该销售单的站号！");
				return false;
			}
			pre_proc_no = dt.Rows[0][0].ToString().Trim();
			sql = "select seq_no from brm_flow_mstr where flow_id = '" + flow_id + "' and proc_no='";
			sql += dt.Rows[0]["proc_no"].ToString() + "'";
			dt = TJSystem.Public.PublicStatic.db.GetDataTable(sql);
			if(dt.Rows.Count == 1)
			{
				if(TJSystem.Public.PublicStatic.CheckProcessSetting(flow_id,seq_no,pre_proc_no,this.menu_id,ref retString))
				{
					if(retString.Equals("LASTPROC"))
					{
						if(System.Windows.Forms.MessageBox.Show("当前所设站为最后一站，确认结束该销售单？","Question",System.Windows.Forms.MessageBoxButtons.YesNo,System.Windows.Forms.MessageBoxIcon.Question)
							== System.Windows.Forms.DialogResult.Yes)
						{
							return true;
						}
						else
						{
							return false;
						}
					}
					return true;
				}
				else
				{
					TJSystem.Public.PublicStatic.ShowMessage(TJSystem.Public.MessageType.Error,retString);
					return false;
				}
			}
			else
			{
				TJSystem.Public.PublicStatic.ShowMessage(TJSystem.Public.MessageType.Error,"找不到该销售单的站所对应的流程编号！");
				return false;
			}
		}

		private void setDisable()
		{
			this.txt1.Enabled = false;
			this.priDateTimePicker3.Enabled = false;
			this.txt3.Enabled = false;
			this.txt6.Enabled = false;
			this.txt8.Enabled = false;
			this.txt11.Enabled = false;
			this.txt12.Enabled = false;
			this.txt13.Enabled = false;
			this.txt15.Enabled = false;
			this.txt16.Enabled = false;
			this.txt17.Enabled = false;
			this.txt25.Enabled = false;
			this.txt26.Enabled = false;
			this.txt27.Enabled = false;
			this.txt28.Enabled = false;
			this.txt29.Enabled = false;
			this.txt30.Enabled = false;
			this.txt31.Enabled = false;
			this.priTextBox2.Enabled = false;
			this.priTextBox3.Enabled = false;
//			this.priTextBox4.Enabled = false;
			this.priTextBox5.Enabled = false;
			
			this.priComboBox1.Enabled = false;
			this.priComboBox2.Enabled = false;
			this.priComboBox3.Enabled = false;
			this.priComboBox4.Enabled = false;
			this.priComboBox5.Enabled = false;
			this.priComboBox6.Enabled = false;
			this.priComboBox7.Enabled = false;
			this.priComboBox8.Enabled = false;
			this.priComboBox9.Enabled = false;
			this.priComboBox10.Enabled = false;
			this.priComboBox11.Enabled = false;
			this.priComboBox12.Enabled = false;
			this.priComboBox13.Enabled = false;
			
			this.priDateTimePicker3.Enabled = false;
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
				this.txt3.Enabled = true;
				this.txt12.Enabled = true;
				this.txt13.Enabled = true;
				this.txt15.Enabled = true;
				this.txt16.Enabled = true;
				this.txt17.Enabled = true;
				this.txt25.Enabled = true;
				this.priTextBox2.Enabled = true;
				this.priTextBox3.Enabled = true;
//				this.priTextBox4.Enabled = true;
				this.priTextBox5.Enabled = true;
				
				this.priComboBox1.Enabled = false;
				this.priComboBox2.Enabled = true;
				this.priComboBox3.Enabled = true;
				this.priComboBox4.Enabled = true;
				this.priComboBox5.Enabled = true;
				this.priComboBox6.Enabled = true;
				this.priComboBox7.Enabled = true;
				this.priComboBox8.Enabled = true;
				this.priComboBox9.Enabled = true;
				this.priComboBox10.Enabled = true;
				this.priComboBox11.Enabled = true;
				this.priComboBox12.Enabled = true;
				this.priComboBox13.Enabled = true;
				this.txt1.Text = "";
				this.priDateTimePicker3.Value = System.DateTime.Now;
				this.txt3.Text = "";
				this.txt6.Text = "";
				this.txt8.Text = "";
				this.txt11.Text = "";
				this.txt12.Text = "";
				this.txt13.Text = "";
				this.txt15.Text = "";
				this.txt16.Text = "";
				this.txt17.Text = "";
				this.txt25.Text = "";
				this.txt26.Text = "";
				this.txt27.Text = "";
				this.txt28.Text = "";
				this.txt29.Text = "";
				this.txt30.Text = "";
				this.txt31.Text = "";
				this.priTextBox2.Text = "";
				this.priTextBox3.Text = "";
//				this.priTextBox4.Text = "";
				this.priTextBox5.Text = "";

				this.priComboBox1.SelectedValue = "1";
				this.priComboBox2.Text = "";
				this.priComboBox3.Text = "";
				this.priComboBox4.Text = "";
				this.priComboBox5.Text = "";
				this.priComboBox6.Text = "";
				this.priComboBox7.Text = "";
				this.priComboBox8.Text = "";
				this.priComboBox9.Text = "";
				this.priComboBox10.Text = "";
				this.priComboBox11.Text = "";
				this.priComboBox12.Text = "";
				this.priComboBox13.Text = "";
			}
			else if(ButtonType.Equals("update"))
			{
				/*
				if (!this.priComboBox1.SelectedValue.ToString().Equals("1"))
				{
					TJSystem.Public.PublicStatic.ShowMessage(TJSystem.Public.MessageType.Exclamation, "只有处于新建状态的销售单才能进行修改！");
					return;
				}
				*/
				//				if(!checkLastProcessSet())
				{
					this.txt1.Enabled = false;
					this.priDateTimePicker3.Enabled = true;
					this.txt3.Enabled = true;
					this.txt12.Enabled = true;
					this.txt13.Enabled = true;
					this.txt15.Enabled = true;
					this.txt16.Enabled = true;
					this.txt17.Enabled = true;
					this.txt25.Enabled = true;
					this.priTextBox2.Enabled = true;
					this.priTextBox3.Enabled = true;
//					this.priTextBox4.Enabled = true;
					this.priTextBox5.Enabled = true;

					this.priComboBox1.Enabled = false;
					this.priComboBox2.Enabled = true;
					this.priComboBox3.Enabled = true;
					this.priComboBox4.Enabled = true;
					this.priComboBox5.Enabled = true;
					this.priComboBox6.Enabled = true;
					this.priComboBox7.Enabled = true;
					this.priComboBox8.Enabled = true;
					this.priComboBox9.Enabled = true;
					this.priComboBox10.Enabled = true;
					this.priComboBox11.Enabled = true;
					this.priComboBox12.Enabled = true;
					this.priComboBox13.Enabled = true;
				}
			}
			
//			this.priToolBar1.SetStatusEnable(this.priComboBox1);
		}

		/// <summary>
		/// 检查当前所选择的站是否是当前流程的最后一站，主要用来设定用户是否可见当前单证
		/// </summary>
		/// <returns></returns>
		///
		/*
		private bool checkLastProcessSet()
		{
			DataView dv = (DataView)this.dataGrid1.DataSource;
			if(dv[this.dataGrid1.CurrentRowIndex]["flow_id"].ToString().Equals(""))
			{
				return false;
			}

			string sql = null;
			DataTable dt = null;
			sql = "select max(a.seq_no) as maxseq from brm_flow_mstr a ";
			sql += " where a.flow_id='" + dv[this.dataGrid1.CurrentRowIndex]["flow_id"].ToString() + "'";
			dt = TJSystem.Public.PublicStatic.db.GetDataTable(sql);
			if(dt.Rows.Count == 1)
			{
				if(this.priComboBox1.SelectedValue.ToString().Equals(dt.Rows[0][0].ToString()))
				{
					return true;
				}
			}

			return false;
		}
		
		*/
		private void InitialGrid(string sql)
		{		
			DataTable dt = TJSystem.Public.PublicStatic.db.GetDataTable(sql);
			dt.TableName = "sale_so_master";
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(frmSaleOrder));
			this.fax1 = new System.Windows.Forms.DataGridTextBoxColumn();
			this.email2 = new System.Windows.Forms.DataGridTextBoxColumn();
			this.address_cn = new System.Windows.Forms.DataGridTextBoxColumn();
			this.company_name = new System.Windows.Forms.DataGridTextBoxColumn();
			this.company_name_cn = new System.Windows.Forms.DataGridTextBoxColumn();
			this.email1 = new System.Windows.Forms.DataGridTextBoxColumn();
			this.tel1 = new System.Windows.Forms.DataGridTextBoxColumn();
			this.resume = new System.Windows.Forms.DataGridTextBoxColumn();
			this.gen_manager = new System.Windows.Forms.DataGridTextBoxColumn();
			this.panel3 = new System.Windows.Forms.Panel();
			this.priToolBar1 = new TJSystem.UC.PriToolBar();
			this.postcode = new System.Windows.Forms.DataGridTextBoxColumn();
			this.address = new System.Windows.Forms.DataGridTextBoxColumn();
			this.corporation = new System.Windows.Forms.DataGridTextBoxColumn();
			this.company_id = new System.Windows.Forms.DataGridTextBoxColumn();
			this.panel2 = new System.Windows.Forms.Panel();
			this.dataGrid1 = new System.Windows.Forms.DataGrid();
			this.dataGridTableStyle1 = new System.Windows.Forms.DataGridTableStyle();
			this.so_code = new System.Windows.Forms.DataGridTextBoxColumn();
			this.so_date = new System.Windows.Forms.DataGridTextBoxColumn();
			this.client_orderNo = new System.Windows.Forms.DataGridTextBoxColumn();
			this.status_name = new System.Windows.Forms.DataGridTextBoxColumn();
			this.client_id = new System.Windows.Forms.DataGridTextBoxColumn();
			this.client_name = new System.Windows.Forms.DataGridTextBoxColumn();
			this.contact_name = new System.Windows.Forms.DataGridTextBoxColumn();
			this.currency_name = new System.Windows.Forms.DataGridTextBoxColumn();
			this.priceterm = new System.Windows.Forms.DataGridTextBoxColumn();
			this.priceterm_dest = new System.Windows.Forms.DataGridTextBoxColumn();
			this.discounttype = new System.Windows.Forms.DataGridTextBoxColumn();
			this.discount = new System.Windows.Forms.DataGridTextBoxColumn();
			this.settlementtype = new System.Windows.Forms.DataGridTextBoxColumn();
			this.bargainon = new System.Windows.Forms.DataGridTextBoxColumn();
			this.amount = new System.Windows.Forms.DataGridTextBoxColumn();
			this.fobamount = new System.Windows.Forms.DataGridTextBoxColumn();
			this.freightamount = new System.Windows.Forms.DataGridTextBoxColumn();
			this.insurance = new System.Windows.Forms.DataGridTextBoxColumn();
			this.brightcommision = new System.Windows.Forms.DataGridTextBoxColumn();
			this.darkcommision = new System.Windows.Forms.DataGridTextBoxColumn();
			this.deliverydate = new System.Windows.Forms.DataGridTextBoxColumn();
			this.transType_name = new System.Windows.Forms.DataGridTextBoxColumn();
			this.arriveregion_name = new System.Windows.Forms.DataGridTextBoxColumn();
			this.Port_departure_name = new System.Windows.Forms.DataGridTextBoxColumn();
			this.arrivecountry_name = new System.Windows.Forms.DataGridTextBoxColumn();
			this.destport_name = new System.Windows.Forms.DataGridTextBoxColumn();
			this.destination = new System.Windows.Forms.DataGridTextBoxColumn();
			this.remark = new System.Windows.Forms.DataGridTextBoxColumn();
			this.createby = new System.Windows.Forms.DataGridTextBoxColumn();
			this.createon = new System.Windows.Forms.DataGridTextBoxColumn();
			this.modifyby = new System.Windows.Forms.DataGridTextBoxColumn();
			this.modifyon = new System.Windows.Forms.DataGridTextBoxColumn();
			this.approvedby = new System.Windows.Forms.DataGridTextBoxColumn();
			this.approvedon = new System.Windows.Forms.DataGridTextBoxColumn();
			this.panel4 = new System.Windows.Forms.Panel();
			this.priComboBox1 = new TJSystem.Classes.PriComboBox();
			this.checkBox1 = new System.Windows.Forms.CheckBox();
			this.priTextBox6 = new TJSystem.Classes.PriTextBox();
			this.label37 = new System.Windows.Forms.Label();
			this.priTextBox5 = new TJSystem.Classes.PriTextBox();
			this.linkLabel4 = new System.Windows.Forms.LinkLabel();
			this.priComboBox13 = new TJSystem.Classes.PriComboBox();
			this.label36 = new System.Windows.Forms.Label();
			this.priComboBox12 = new TJSystem.Classes.PriComboBox();
			this.label33 = new System.Windows.Forms.Label();
			this.linkLabel3 = new System.Windows.Forms.LinkLabel();
			this.label30 = new System.Windows.Forms.Label();
			this.priTextBox3 = new TJSystem.Classes.PriTextBox();
			this.priDateTimePicker1 = new TJSystem.Classes.PriDateTimePicker();
			this.label14 = new System.Windows.Forms.Label();
			this.priTextBox2 = new TJSystem.Classes.PriTextBox();
			this.priDateTimePicker3 = new TJSystem.Classes.PriDateTimePicker();
			this.priComboBox11 = new TJSystem.Classes.PriComboBox();
			this.priTextBox1 = new TJSystem.Classes.PriTextBox();
			this.linkLabel1 = new System.Windows.Forms.LinkLabel();
			this.priComboBox10 = new TJSystem.Classes.PriComboBox();
			this.priComboBox9 = new TJSystem.Classes.PriComboBox();
			this.priComboBox8 = new TJSystem.Classes.PriComboBox();
			this.priComboBox7 = new TJSystem.Classes.PriComboBox();
			this.priComboBox6 = new TJSystem.Classes.PriComboBox();
			this.priComboBox5 = new TJSystem.Classes.PriComboBox();
			this.priComboBox4 = new TJSystem.Classes.PriComboBox();
			this.priComboBox3 = new TJSystem.Classes.PriComboBox();
			this.priComboBox2 = new TJSystem.Classes.PriComboBox();
			this.label28 = new System.Windows.Forms.Label();
			this.txt29 = new TJSystem.Classes.PriTextBox();
			this.label29 = new System.Windows.Forms.Label();
			this.txt28 = new TJSystem.Classes.PriTextBox();
			this.label34 = new System.Windows.Forms.Label();
			this.label35 = new System.Windows.Forms.Label();
			this.txt13 = new TJSystem.Classes.PriTextBox();
			this.txt12 = new TJSystem.Classes.PriTextBox();
			this.label22 = new System.Windows.Forms.Label();
			this.label32 = new System.Windows.Forms.Label();
			this.txt25 = new TJSystem.Classes.PriTextBox();
			this.label27 = new System.Windows.Forms.Label();
			this.label26 = new System.Windows.Forms.Label();
			this.label25 = new System.Windows.Forms.Label();
			this.txt17 = new TJSystem.Classes.PriTextBox();
			this.label16 = new System.Windows.Forms.Label();
			this.txt16 = new TJSystem.Classes.PriTextBox();
			this.label23 = new System.Windows.Forms.Label();
			this.label24 = new System.Windows.Forms.Label();
			this.txt15 = new TJSystem.Classes.PriTextBox();
			this.txt11 = new TJSystem.Classes.PriTextBox();
			this.label18 = new System.Windows.Forms.Label();
			this.label19 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.txt8 = new TJSystem.Classes.PriTextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.txt3 = new TJSystem.Classes.PriTextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label21 = new System.Windows.Forms.Label();
			this.txt31 = new TJSystem.Classes.PriTextBox();
			this.label20 = new System.Windows.Forms.Label();
			this.txt27 = new TJSystem.Classes.PriTextBox();
			this.label17 = new System.Windows.Forms.Label();
			this.label15 = new System.Windows.Forms.Label();
			this.label12 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.txt6 = new TJSystem.Classes.PriTextBox();
			this.txt26 = new TJSystem.Classes.PriTextBox();
			this.txt30 = new TJSystem.Classes.PriTextBox();
			this.txt1 = new TJSystem.Classes.PriTextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.label13 = new System.Windows.Forms.Label();
			this.linkLabel2 = new System.Windows.Forms.LinkLabel();
			this.lk_detail = new System.Windows.Forms.LinkLabel();
			this.fax2 = new System.Windows.Forms.DataGridTextBoxColumn();
			this.panel1 = new System.Windows.Forms.Panel();
			this.label1 = new System.Windows.Forms.Label();
			this.website = new System.Windows.Forms.DataGridTextBoxColumn();
			this.tel2 = new System.Windows.Forms.DataGridTextBoxColumn();
			this.panel3.SuspendLayout();
			this.panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).BeginInit();
			this.panel4.SuspendLayout();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
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
			// company_name
			// 
			this.company_name.Format = "";
			this.company_name.FormatInfo = null;
			this.company_name.HeaderText = "公司名称";
			this.company_name.MappingName = "company_name";
			this.company_name.NullText = "";
			this.company_name.Width = 75;
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
			// tel1
			// 
			this.tel1.Format = "";
			this.tel1.FormatInfo = null;
			this.tel1.HeaderText = "电话1";
			this.tel1.MappingName = "tel1";
			this.tel1.NullText = "";
			this.tel1.Width = 75;
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
			// gen_manager
			// 
			this.gen_manager.Format = "";
			this.gen_manager.FormatInfo = null;
			this.gen_manager.HeaderText = "总经理";
			this.gen_manager.MappingName = "gen_manager";
			this.gen_manager.NullText = "";
			this.gen_manager.Width = 75;
			// 
			// panel3
			// 
			this.panel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel3.BackgroundImage")));
			this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.panel3.Controls.Add(this.priToolBar1);
			this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panel3.Location = new System.Drawing.Point(0, 526);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(784, 40);
			this.panel3.TabIndex = 18;
			// 
			// priToolBar1
			// 
			this.priToolBar1.DGEnable = true;
			this.priToolBar1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.priToolBar1.Location = new System.Drawing.Point(0, -4);
			this.priToolBar1.Name = "priToolBar1";
			this.priToolBar1.setCurrentForm = null;
			this.priToolBar1.Size = new System.Drawing.Size(780, 40);
			this.priToolBar1.TabIndex = 0;
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
			// address
			// 
			this.address.Format = "";
			this.address.FormatInfo = null;
			this.address.HeaderText = "地址";
			this.address.MappingName = "address";
			this.address.NullText = "";
			this.address.Width = 75;
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
			// company_id
			// 
			this.company_id.Format = "";
			this.company_id.FormatInfo = null;
			this.company_id.HeaderText = "公司编号";
			this.company_id.MappingName = "company_id";
			this.company_id.NullText = "";
			this.company_id.Width = 75;
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
			this.panel2.Size = new System.Drawing.Size(784, 518);
			this.panel2.TabIndex = 17;
			// 
			// dataGrid1
			// 
			this.dataGrid1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.dataGrid1.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.dataGrid1.CaptionBackColor = System.Drawing.SystemColors.ActiveBorder;
			this.dataGrid1.CaptionText = "销售订单";
			this.dataGrid1.CaptionVisible = false;
			this.dataGrid1.DataMember = "";
			this.dataGrid1.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.dataGrid1.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.dataGrid1.Location = new System.Drawing.Point(0, 344);
			this.dataGrid1.Name = "dataGrid1";
			this.dataGrid1.ReadOnly = true;
			this.dataGrid1.Size = new System.Drawing.Size(776, 128);
			this.dataGrid1.TabIndex = 1;
			this.dataGrid1.TableStyles.AddRange(new System.Windows.Forms.DataGridTableStyle[] {
																								  this.dataGridTableStyle1});
			this.dataGrid1.Click += new System.EventHandler(this.dataGrid1_Click);
			// 
			// dataGridTableStyle1
			// 
			this.dataGridTableStyle1.DataGrid = this.dataGrid1;
			this.dataGridTableStyle1.GridColumnStyles.AddRange(new System.Windows.Forms.DataGridColumnStyle[] {
																												  this.so_code,
																												  this.so_date,
																												  this.client_orderNo,
																												  this.status_name,
																												  this.client_id,
																												  this.client_name,
																												  this.contact_name,
																												  this.currency_name,
																												  this.priceterm,
																												  this.priceterm_dest,
																												  this.discounttype,
																												  this.discount,
																												  this.settlementtype,
																												  this.bargainon,
																												  this.amount,
																												  this.fobamount,
																												  this.freightamount,
																												  this.insurance,
																												  this.brightcommision,
																												  this.darkcommision,
																												  this.deliverydate,
																												  this.transType_name,
																												  this.arriveregion_name,
																												  this.Port_departure_name,
																												  this.arrivecountry_name,
																												  this.destport_name,
																												  this.destination,
																												  this.remark,
																												  this.createby,
																												  this.createon,
																												  this.modifyby,
																												  this.modifyon,
																												  this.approvedby,
																												  this.approvedon});
			this.dataGridTableStyle1.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.dataGridTableStyle1.MappingName = "sale_so_master";
			// 
			// so_code
			// 
			this.so_code.Format = "";
			this.so_code.FormatInfo = null;
			this.so_code.HeaderText = "订单号";
			this.so_code.MappingName = "so_code";
			this.so_code.NullText = "";
			this.so_code.Width = 75;
			// 
			// so_date
			// 
			this.so_date.Format = "";
			this.so_date.FormatInfo = null;
			this.so_date.HeaderText = "订单日期";
			this.so_date.MappingName = "so_date";
			this.so_date.NullText = "";
			this.so_date.Width = 75;
			// 
			// client_orderNo
			// 
			this.client_orderNo.Format = "";
			this.client_orderNo.FormatInfo = null;
			this.client_orderNo.HeaderText = "客户单号";
			this.client_orderNo.MappingName = "client_orderNo";
			this.client_orderNo.NullText = "";
			this.client_orderNo.Width = 75;
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
			this.client_id.HeaderText = "客户代码";
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
			// contact_name
			// 
			this.contact_name.Format = "";
			this.contact_name.FormatInfo = null;
			this.contact_name.HeaderText = "联系人";
			this.contact_name.MappingName = "contact_name";
			this.contact_name.NullText = "";
			this.contact_name.Width = 75;
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
			// priceterm
			// 
			this.priceterm.Format = "";
			this.priceterm.FormatInfo = null;
			this.priceterm.HeaderText = "价格条款";
			this.priceterm.MappingName = "priceterm";
			this.priceterm.NullText = "";
			this.priceterm.Width = 75;
			// 
			// priceterm_dest
			// 
			this.priceterm_dest.Format = "";
			this.priceterm_dest.FormatInfo = null;
			this.priceterm_dest.HeaderText = "价格条款明细";
			this.priceterm_dest.MappingName = "priceterm_dest";
			this.priceterm_dest.NullText = "";
			this.priceterm_dest.Width = 75;
			// 
			// discounttype
			// 
			this.discounttype.Format = "";
			this.discounttype.FormatInfo = null;
			this.discounttype.HeaderText = "折扣类型";
			this.discounttype.MappingName = "discounttype";
			this.discounttype.Width = 75;
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
			// settlementtype
			// 
			this.settlementtype.Format = "";
			this.settlementtype.FormatInfo = null;
			this.settlementtype.HeaderText = "结汇方式";
			this.settlementtype.MappingName = "settlementtype";
			this.settlementtype.NullText = "";
			this.settlementtype.Width = 75;
			// 
			// bargainon
			// 
			this.bargainon.Format = "";
			this.bargainon.FormatInfo = null;
			this.bargainon.HeaderText = "成交条件";
			this.bargainon.MappingName = "bargainon";
			this.bargainon.NullText = "";
			this.bargainon.Width = 75;
			// 
			// amount
			// 
			this.amount.Format = "";
			this.amount.FormatInfo = null;
			this.amount.HeaderText = "金额";
			this.amount.MappingName = "amount";
			this.amount.NullText = "";
			this.amount.Width = 75;
			// 
			// fobamount
			// 
			this.fobamount.Format = "";
			this.fobamount.FormatInfo = null;
			this.fobamount.HeaderText = "FOB金额";
			this.fobamount.MappingName = "fobamount";
			this.fobamount.NullText = "";
			this.fobamount.Width = 75;
			// 
			// freightamount
			// 
			this.freightamount.Format = "";
			this.freightamount.FormatInfo = null;
			this.freightamount.HeaderText = "运费";
			this.freightamount.MappingName = "freightamount";
			this.freightamount.NullText = "";
			this.freightamount.Width = 75;
			// 
			// insurance
			// 
			this.insurance.Format = "";
			this.insurance.FormatInfo = null;
			this.insurance.HeaderText = "保险费";
			this.insurance.MappingName = "insurance";
			this.insurance.NullText = "";
			this.insurance.Width = 75;
			// 
			// brightcommision
			// 
			this.brightcommision.Format = "";
			this.brightcommision.FormatInfo = null;
			this.brightcommision.HeaderText = "明佣";
			this.brightcommision.MappingName = "brightcommision";
			this.brightcommision.NullText = "";
			this.brightcommision.Width = 75;
			// 
			// darkcommision
			// 
			this.darkcommision.Format = "";
			this.darkcommision.FormatInfo = null;
			this.darkcommision.HeaderText = "暗佣";
			this.darkcommision.MappingName = "darkcommision";
			this.darkcommision.NullText = "";
			this.darkcommision.Width = 75;
			// 
			// deliverydate
			// 
			this.deliverydate.Format = "";
			this.deliverydate.FormatInfo = null;
			this.deliverydate.HeaderText = "交货期";
			this.deliverydate.MappingName = "deliverydate";
			this.deliverydate.NullText = "";
			this.deliverydate.Width = 75;
			// 
			// transType_name
			// 
			this.transType_name.Format = "";
			this.transType_name.FormatInfo = null;
			this.transType_name.HeaderText = "运输方式";
			this.transType_name.MappingName = "transType_name";
			this.transType_name.NullText = "";
			this.transType_name.Width = 75;
			// 
			// arriveregion_name
			// 
			this.arriveregion_name.Format = "";
			this.arriveregion_name.FormatInfo = null;
			this.arriveregion_name.HeaderText = "目的地";
			this.arriveregion_name.MappingName = "arriveregion_name";
			this.arriveregion_name.NullText = "";
			this.arriveregion_name.Width = 75;
			// 
			// Port_departure_name
			// 
			this.Port_departure_name.Format = "";
			this.Port_departure_name.FormatInfo = null;
			this.Port_departure_name.HeaderText = "起运港";
			this.Port_departure_name.MappingName = "Port_departure_name";
			this.Port_departure_name.NullText = "";
			this.Port_departure_name.Width = 75;
			// 
			// arrivecountry_name
			// 
			this.arrivecountry_name.Format = "";
			this.arrivecountry_name.FormatInfo = null;
			this.arrivecountry_name.HeaderText = "运抵国";
			this.arrivecountry_name.MappingName = "arrivecountry_name";
			this.arrivecountry_name.NullText = "";
			this.arrivecountry_name.Width = 75;
			// 
			// destport_name
			// 
			this.destport_name.Format = "";
			this.destport_name.FormatInfo = null;
			this.destport_name.HeaderText = "目的港";
			this.destport_name.MappingName = "destport_name";
			this.destport_name.NullText = "";
			this.destport_name.Width = 75;
			// 
			// destination
			// 
			this.destination.Format = "";
			this.destination.FormatInfo = null;
			this.destination.HeaderText = "唛头";
			this.destination.MappingName = "destination";
			this.destination.NullText = "";
			this.destination.Width = 75;
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
			this.approvedon.HeaderText = "审核日期";
			this.approvedon.MappingName = "approvedon";
			this.approvedon.NullText = "";
			this.approvedon.Width = 75;
			// 
			// panel4
			// 
			this.panel4.BackColor = System.Drawing.SystemColors.ScrollBar;
			this.panel4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel4.BackgroundImage")));
			this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.panel4.Controls.Add(this.priComboBox1);
			this.panel4.Controls.Add(this.checkBox1);
			this.panel4.Controls.Add(this.priTextBox6);
			this.panel4.Controls.Add(this.label37);
			this.panel4.Controls.Add(this.priTextBox5);
			this.panel4.Controls.Add(this.linkLabel4);
			this.panel4.Controls.Add(this.priComboBox13);
			this.panel4.Controls.Add(this.label36);
			this.panel4.Controls.Add(this.priComboBox12);
			this.panel4.Controls.Add(this.label33);
			this.panel4.Controls.Add(this.linkLabel3);
			this.panel4.Controls.Add(this.label30);
			this.panel4.Controls.Add(this.priTextBox3);
			this.panel4.Controls.Add(this.priDateTimePicker1);
			this.panel4.Controls.Add(this.label14);
			this.panel4.Controls.Add(this.priTextBox2);
			this.panel4.Controls.Add(this.priDateTimePicker3);
			this.panel4.Controls.Add(this.priComboBox11);
			this.panel4.Controls.Add(this.priTextBox1);
			this.panel4.Controls.Add(this.linkLabel1);
			this.panel4.Controls.Add(this.priComboBox10);
			this.panel4.Controls.Add(this.priComboBox9);
			this.panel4.Controls.Add(this.priComboBox8);
			this.panel4.Controls.Add(this.priComboBox7);
			this.panel4.Controls.Add(this.priComboBox6);
			this.panel4.Controls.Add(this.priComboBox5);
			this.panel4.Controls.Add(this.priComboBox4);
			this.panel4.Controls.Add(this.priComboBox3);
			this.panel4.Controls.Add(this.priComboBox2);
			this.panel4.Controls.Add(this.label28);
			this.panel4.Controls.Add(this.txt29);
			this.panel4.Controls.Add(this.label29);
			this.panel4.Controls.Add(this.txt28);
			this.panel4.Controls.Add(this.label34);
			this.panel4.Controls.Add(this.label35);
			this.panel4.Controls.Add(this.txt13);
			this.panel4.Controls.Add(this.txt12);
			this.panel4.Controls.Add(this.label22);
			this.panel4.Controls.Add(this.label32);
			this.panel4.Controls.Add(this.txt25);
			this.panel4.Controls.Add(this.label27);
			this.panel4.Controls.Add(this.label26);
			this.panel4.Controls.Add(this.label25);
			this.panel4.Controls.Add(this.txt17);
			this.panel4.Controls.Add(this.label16);
			this.panel4.Controls.Add(this.txt16);
			this.panel4.Controls.Add(this.label23);
			this.panel4.Controls.Add(this.label24);
			this.panel4.Controls.Add(this.txt15);
			this.panel4.Controls.Add(this.txt11);
			this.panel4.Controls.Add(this.label18);
			this.panel4.Controls.Add(this.label19);
			this.panel4.Controls.Add(this.label9);
			this.panel4.Controls.Add(this.txt8);
			this.panel4.Controls.Add(this.label5);
			this.panel4.Controls.Add(this.txt3);
			this.panel4.Controls.Add(this.label3);
			this.panel4.Controls.Add(this.label21);
			this.panel4.Controls.Add(this.txt31);
			this.panel4.Controls.Add(this.label20);
			this.panel4.Controls.Add(this.txt27);
			this.panel4.Controls.Add(this.label17);
			this.panel4.Controls.Add(this.label15);
			this.panel4.Controls.Add(this.label12);
			this.panel4.Controls.Add(this.label11);
			this.panel4.Controls.Add(this.label8);
			this.panel4.Controls.Add(this.label7);
			this.panel4.Controls.Add(this.label2);
			this.panel4.Controls.Add(this.txt6);
			this.panel4.Controls.Add(this.txt26);
			this.panel4.Controls.Add(this.txt30);
			this.panel4.Controls.Add(this.txt1);
			this.panel4.Controls.Add(this.label4);
			this.panel4.Controls.Add(this.label6);
			this.panel4.Controls.Add(this.label10);
			this.panel4.Controls.Add(this.label13);
			this.panel4.Controls.Add(this.linkLabel2);
			this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel4.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.panel4.Location = new System.Drawing.Point(0, 0);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(780, 344);
			this.panel4.TabIndex = 0;
			// 
			// priComboBox1
			// 
			this.priComboBox1.BackColor = System.Drawing.Color.White;
			this.priComboBox1.DataField = "status";
			this.priComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.priComboBox1.Location = new System.Drawing.Point(640, 8);
			this.priComboBox1.Name = "priComboBox1";
			this.priComboBox1.Size = new System.Drawing.Size(120, 22);
			this.priComboBox1.TabIndex = 233;
			// 
			// checkBox1
			// 
			this.checkBox1.BackColor = System.Drawing.Color.Transparent;
			this.checkBox1.Location = new System.Drawing.Point(656, 256);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.Size = new System.Drawing.Size(96, 24);
			this.checkBox1.TabIndex = 232;
			this.checkBox1.Text = "  显示所有";
			this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
			// 
			// priTextBox6
			// 
			this.priTextBox6.BackColor = System.Drawing.Color.White;
			this.priTextBox6.DataField = "visible_flag";
			this.priTextBox6.DataType = TJSystem.Public.DataType.String;
			this.priTextBox6.Enabled = false;
			this.priTextBox6.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.priTextBox6.Location = new System.Drawing.Point(96, 360);
			this.priTextBox6.Name = "priTextBox6";
			this.priTextBox6.Size = new System.Drawing.Size(112, 23);
			this.priTextBox6.TabIndex = 231;
			this.priTextBox6.Text = "";
			// 
			// label37
			// 
			this.label37.BackColor = System.Drawing.Color.Transparent;
			this.label37.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.label37.Location = new System.Drawing.Point(576, 128);
			this.label37.Name = "label37";
			this.label37.Size = new System.Drawing.Size(64, 23);
			this.label37.TabIndex = 227;
			this.label37.Text = "成交条件";
			this.label37.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// priTextBox5
			// 
			this.priTextBox5.BackColor = System.Drawing.Color.White;
			this.priTextBox5.DataField = "bargainon";
			this.priTextBox5.DataType = TJSystem.Public.DataType.String;
			this.priTextBox5.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.priTextBox5.Location = new System.Drawing.Point(640, 128);
			this.priTextBox5.Name = "priTextBox5";
			this.priTextBox5.Size = new System.Drawing.Size(120, 23);
			this.priTextBox5.TabIndex = 228;
			this.priTextBox5.Text = "";
			// 
			// linkLabel4
			// 
			this.linkLabel4.AutoSize = true;
			this.linkLabel4.BackColor = System.Drawing.Color.Transparent;
			this.linkLabel4.ForeColor = System.Drawing.SystemColors.ControlText;
			this.linkLabel4.Location = new System.Drawing.Point(512, 256);
			this.linkLabel4.Name = "linkLabel4";
			this.linkLabel4.Size = new System.Drawing.Size(135, 19);
			this.linkLabel4.TabIndex = 226;
			this.linkLabel4.TabStop = true;
			this.linkLabel4.Text = "Sales Confirmation";
			this.linkLabel4.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel4_LinkClicked);
			// 
			// priComboBox13
			// 
			this.priComboBox13.BackColor = System.Drawing.Color.White;
			this.priComboBox13.DataField = "saleTerm_ID";
			this.priComboBox13.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.priComboBox13.Location = new System.Drawing.Point(496, 224);
			this.priComboBox13.Name = "priComboBox13";
			this.priComboBox13.Size = new System.Drawing.Size(160, 22);
			this.priComboBox13.TabIndex = 225;
			// 
			// label36
			// 
			this.label36.AutoSize = true;
			this.label36.BackColor = System.Drawing.Color.Transparent;
			this.label36.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.label36.ForeColor = System.Drawing.Color.Blue;
			this.label36.Location = new System.Drawing.Point(400, 200);
			this.label36.Name = "label36";
			this.label36.Size = new System.Drawing.Size(94, 19);
			this.label36.TabIndex = 224;
			this.label36.Text = "Sales Confirm";
			this.label36.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// priComboBox12
			// 
			this.priComboBox12.BackColor = System.Drawing.Color.White;
			this.priComboBox12.DataField = "saleConf_ID";
			this.priComboBox12.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.priComboBox12.Location = new System.Drawing.Point(496, 200);
			this.priComboBox12.Name = "priComboBox12";
			this.priComboBox12.Size = new System.Drawing.Size(160, 22);
			this.priComboBox12.TabIndex = 223;
			// 
			// label33
			// 
			this.label33.BackColor = System.Drawing.Color.Transparent;
			this.label33.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.label33.ForeColor = System.Drawing.Color.Blue;
			this.label33.Location = new System.Drawing.Point(432, 224);
			this.label33.Name = "label33";
			this.label33.Size = new System.Drawing.Size(64, 23);
			this.label33.TabIndex = 222;
			this.label33.Text = "购销合同";
			this.label33.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// linkLabel3
			// 
			this.linkLabel3.AutoSize = true;
			this.linkLabel3.BackColor = System.Drawing.Color.Transparent;
			this.linkLabel3.ForeColor = System.Drawing.SystemColors.ControlText;
			this.linkLabel3.Location = new System.Drawing.Point(672, 184);
			this.linkLabel3.Name = "linkLabel3";
			this.linkLabel3.Size = new System.Drawing.Size(63, 19);
			this.linkLabel3.TabIndex = 221;
			this.linkLabel3.TabStop = true;
			this.linkLabel3.Text = "购销合同";
			this.linkLabel3.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel3_LinkClicked);
			// 
			// label30
			// 
			this.label30.BackColor = System.Drawing.Color.Transparent;
			this.label30.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.label30.ForeColor = System.Drawing.Color.Blue;
			this.label30.Location = new System.Drawing.Point(440, 176);
			this.label30.Name = "label30";
			this.label30.Size = new System.Drawing.Size(56, 23);
			this.label30.TabIndex = 219;
			this.label30.Text = "保险费";
			this.label30.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// priTextBox3
			// 
			this.priTextBox3.BackColor = System.Drawing.Color.Yellow;
			this.priTextBox3.DataField = "insurance";
			this.priTextBox3.DataType = TJSystem.Public.DataType.String;
			this.priTextBox3.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.priTextBox3.Location = new System.Drawing.Point(496, 176);
			this.priTextBox3.Name = "priTextBox3";
			this.priTextBox3.Size = new System.Drawing.Size(112, 23);
			this.priTextBox3.TabIndex = 220;
			this.priTextBox3.Text = "";
			// 
			// priDateTimePicker1
			// 
			this.priDateTimePicker1.CustomFormat = "yyyy-MM-dd";
			this.priDateTimePicker1.DataField = "deliverydate";
			this.priDateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.priDateTimePicker1.Location = new System.Drawing.Point(640, 104);
			this.priDateTimePicker1.Name = "priDateTimePicker1";
			this.priDateTimePicker1.Size = new System.Drawing.Size(120, 23);
			this.priDateTimePicker1.TabIndex = 216;
			// 
			// label14
			// 
			this.label14.BackColor = System.Drawing.Color.Transparent;
			this.label14.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.label14.ForeColor = System.Drawing.Color.Blue;
			this.label14.Location = new System.Drawing.Point(224, 176);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(56, 23);
			this.label14.TabIndex = 214;
			this.label14.Text = "FOB金额";
			this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// priTextBox2
			// 
			this.priTextBox2.BackColor = System.Drawing.Color.Yellow;
			this.priTextBox2.DataField = "fobamount";
			this.priTextBox2.DataType = TJSystem.Public.DataType.String;
			this.priTextBox2.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.priTextBox2.Location = new System.Drawing.Point(288, 176);
			this.priTextBox2.Name = "priTextBox2";
			this.priTextBox2.Size = new System.Drawing.Size(112, 23);
			this.priTextBox2.TabIndex = 215;
			this.priTextBox2.Text = "";
			// 
			// priDateTimePicker3
			// 
			this.priDateTimePicker3.CustomFormat = "yyyy-MM-dd";
			this.priDateTimePicker3.DataField = "so_date";
			this.priDateTimePicker3.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.priDateTimePicker3.Location = new System.Drawing.Point(288, 8);
			this.priDateTimePicker3.Name = "priDateTimePicker3";
			this.priDateTimePicker3.Size = new System.Drawing.Size(112, 23);
			this.priDateTimePicker3.TabIndex = 213;
			// 
			// priComboBox11
			// 
			this.priComboBox11.BackColor = System.Drawing.Color.White;
			this.priComboBox11.DataField = "Contact_id";
			this.priComboBox11.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.priComboBox11.Location = new System.Drawing.Point(472, 32);
			this.priComboBox11.Name = "priComboBox11";
			this.priComboBox11.Size = new System.Drawing.Size(112, 22);
			this.priComboBox11.TabIndex = 191;
			this.priComboBox11.SelectionChangeCommitted += new System.EventHandler(this.priComboBox11_SelectionChangeCommitted);
			// 
			// priTextBox1
			// 
			this.priTextBox1.BackColor = System.Drawing.Color.White;
			this.priTextBox1.DataField = "destination";
			this.priTextBox1.DataType = TJSystem.Public.DataType.String;
			this.priTextBox1.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.priTextBox1.Location = new System.Drawing.Point(96, 280);
			this.priTextBox1.Multiline = true;
			this.priTextBox1.Name = "priTextBox1";
			this.priTextBox1.Size = new System.Drawing.Size(664, 56);
			this.priTextBox1.TabIndex = 190;
			this.priTextBox1.Text = "";
			// 
			// linkLabel1
			// 
			this.linkLabel1.AutoSize = true;
			this.linkLabel1.BackColor = System.Drawing.Color.Transparent;
			this.linkLabel1.ForeColor = System.Drawing.SystemColors.ControlText;
			this.linkLabel1.Location = new System.Drawing.Point(672, 208);
			this.linkLabel1.Name = "linkLabel1";
			this.linkLabel1.Size = new System.Drawing.Size(63, 19);
			this.linkLabel1.TabIndex = 189;
			this.linkLabel1.TabStop = true;
			this.linkLabel1.Text = "销售明细";
			this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
			// 
			// priComboBox10
			// 
			this.priComboBox10.BackColor = System.Drawing.Color.White;
			this.priComboBox10.DataField = "destport";
			this.priComboBox10.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.priComboBox10.Location = new System.Drawing.Point(344, 128);
			this.priComboBox10.Name = "priComboBox10";
			this.priComboBox10.Size = new System.Drawing.Size(192, 22);
			this.priComboBox10.TabIndex = 186;
			// 
			// priComboBox9
			// 
			this.priComboBox9.BackColor = System.Drawing.Color.White;
			this.priComboBox9.DataField = "arrivecountry";
			this.priComboBox9.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.priComboBox9.Location = new System.Drawing.Point(96, 128);
			this.priComboBox9.Name = "priComboBox9";
			this.priComboBox9.Size = new System.Drawing.Size(184, 22);
			this.priComboBox9.TabIndex = 185;
			// 
			// priComboBox8
			// 
			this.priComboBox8.BackColor = System.Drawing.Color.White;
			this.priComboBox8.DataField = "Port_departure";
			this.priComboBox8.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.priComboBox8.Location = new System.Drawing.Point(456, 104);
			this.priComboBox8.Name = "priComboBox8";
			this.priComboBox8.Size = new System.Drawing.Size(128, 22);
			this.priComboBox8.TabIndex = 184;
			// 
			// priComboBox7
			// 
			this.priComboBox7.BackColor = System.Drawing.Color.White;
			this.priComboBox7.DataField = "arriveregion";
			this.priComboBox7.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.priComboBox7.Location = new System.Drawing.Point(288, 104);
			this.priComboBox7.Name = "priComboBox7";
			this.priComboBox7.Size = new System.Drawing.Size(112, 22);
			this.priComboBox7.TabIndex = 183;
			// 
			// priComboBox6
			// 
			this.priComboBox6.BackColor = System.Drawing.Color.White;
			this.priComboBox6.DataField = "transType";
			this.priComboBox6.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.priComboBox6.Location = new System.Drawing.Point(96, 104);
			this.priComboBox6.Name = "priComboBox6";
			this.priComboBox6.Size = new System.Drawing.Size(120, 22);
			this.priComboBox6.TabIndex = 182;
			// 
			// priComboBox5
			// 
			this.priComboBox5.BackColor = System.Drawing.Color.White;
			this.priComboBox5.DataField = "settlementType";
			this.priComboBox5.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.priComboBox5.Location = new System.Drawing.Point(96, 80);
			this.priComboBox5.Name = "priComboBox5";
			this.priComboBox5.Size = new System.Drawing.Size(120, 22);
			this.priComboBox5.TabIndex = 181;
			// 
			// priComboBox4
			// 
			this.priComboBox4.BackColor = System.Drawing.Color.White;
			this.priComboBox4.DataField = "priceTerm";
			this.priComboBox4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.priComboBox4.Location = new System.Drawing.Point(288, 56);
			this.priComboBox4.Name = "priComboBox4";
			this.priComboBox4.Size = new System.Drawing.Size(112, 22);
			this.priComboBox4.TabIndex = 180;
			this.priComboBox4.SelectionChangeCommitted += new System.EventHandler(this.priComboBox4_SelectionChangeCommitted);
			// 
			// priComboBox3
			// 
			this.priComboBox3.BackColor = System.Drawing.Color.White;
			this.priComboBox3.DataField = "Currency";
			this.priComboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.priComboBox3.Location = new System.Drawing.Point(96, 56);
			this.priComboBox3.Name = "priComboBox3";
			this.priComboBox3.Size = new System.Drawing.Size(120, 22);
			this.priComboBox3.TabIndex = 179;
			// 
			// priComboBox2
			// 
			this.priComboBox2.BackColor = System.Drawing.Color.White;
			this.priComboBox2.DataField = "Client_id";
			this.priComboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.priComboBox2.Location = new System.Drawing.Point(96, 32);
			this.priComboBox2.Name = "priComboBox2";
			this.priComboBox2.Size = new System.Drawing.Size(120, 22);
			this.priComboBox2.TabIndex = 178;
			this.priComboBox2.SelectionChangeCommitted += new System.EventHandler(this.priComboBox2_SelectionChangeCommitted);
			// 
			// label28
			// 
			this.label28.BackColor = System.Drawing.Color.Transparent;
			this.label28.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.label28.Location = new System.Drawing.Point(216, 248);
			this.label28.Name = "label28";
			this.label28.Size = new System.Drawing.Size(64, 23);
			this.label28.TabIndex = 172;
			this.label28.Text = "审核时间";
			this.label28.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txt29
			// 
			this.txt29.BackColor = System.Drawing.Color.White;
			this.txt29.DataField = "approvedon";
			this.txt29.DataType = TJSystem.Public.DataType.String;
			this.txt29.Enabled = false;
			this.txt29.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.txt29.Location = new System.Drawing.Point(288, 248);
			this.txt29.Name = "txt29";
			this.txt29.Size = new System.Drawing.Size(112, 23);
			this.txt29.TabIndex = 171;
			this.txt29.Text = "";
			// 
			// label29
			// 
			this.label29.BackColor = System.Drawing.Color.Transparent;
			this.label29.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.label29.Location = new System.Drawing.Point(40, 248);
			this.label29.Name = "label29";
			this.label29.Size = new System.Drawing.Size(48, 23);
			this.label29.TabIndex = 170;
			this.label29.Text = "审核者";
			this.label29.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txt28
			// 
			this.txt28.BackColor = System.Drawing.Color.White;
			this.txt28.DataField = "approvedBy";
			this.txt28.DataType = TJSystem.Public.DataType.String;
			this.txt28.Enabled = false;
			this.txt28.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.txt28.Location = new System.Drawing.Point(96, 248);
			this.txt28.Name = "txt28";
			this.txt28.Size = new System.Drawing.Size(112, 23);
			this.txt28.TabIndex = 169;
			this.txt28.Text = "";
			// 
			// label34
			// 
			this.label34.BackColor = System.Drawing.Color.Transparent;
			this.label34.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.label34.ForeColor = System.Drawing.Color.Blue;
			this.label34.Location = new System.Drawing.Point(568, 56);
			this.label34.Name = "label34";
			this.label34.Size = new System.Drawing.Size(64, 23);
			this.label34.TabIndex = 166;
			this.label34.Text = "折扣类型";
			this.label34.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label35
			// 
			this.label35.BackColor = System.Drawing.Color.Transparent;
			this.label35.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.label35.ForeColor = System.Drawing.Color.Blue;
			this.label35.Location = new System.Drawing.Point(592, 80);
			this.label35.Name = "label35";
			this.label35.Size = new System.Drawing.Size(40, 23);
			this.label35.TabIndex = 165;
			this.label35.Text = "折扣";
			this.label35.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txt13
			// 
			this.txt13.BackColor = System.Drawing.Color.Yellow;
			this.txt13.DataField = "discount";
			this.txt13.DataType = TJSystem.Public.DataType.String;
			this.txt13.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.txt13.Location = new System.Drawing.Point(640, 80);
			this.txt13.Name = "txt13";
			this.txt13.Size = new System.Drawing.Size(120, 23);
			this.txt13.TabIndex = 168;
			this.txt13.Text = "";
			// 
			// txt12
			// 
			this.txt12.BackColor = System.Drawing.Color.White;
			this.txt12.DataField = "discountType";
			this.txt12.DataType = TJSystem.Public.DataType.String;
			this.txt12.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.txt12.Location = new System.Drawing.Point(640, 56);
			this.txt12.Name = "txt12";
			this.txt12.Size = new System.Drawing.Size(120, 23);
			this.txt12.TabIndex = 167;
			this.txt12.Text = "";
			// 
			// label22
			// 
			this.label22.BackColor = System.Drawing.Color.Transparent;
			this.label22.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.label22.Location = new System.Drawing.Point(56, 280);
			this.label22.Name = "label22";
			this.label22.Size = new System.Drawing.Size(40, 23);
			this.label22.TabIndex = 163;
			this.label22.Text = "唛头";
			this.label22.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label32
			// 
			this.label32.BackColor = System.Drawing.Color.Transparent;
			this.label32.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.label32.Location = new System.Drawing.Point(48, 152);
			this.label32.Name = "label32";
			this.label32.Size = new System.Drawing.Size(40, 23);
			this.label32.TabIndex = 156;
			this.label32.Text = "备注";
			this.label32.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txt25
			// 
			this.txt25.BackColor = System.Drawing.Color.White;
			this.txt25.DataField = "remark";
			this.txt25.DataType = TJSystem.Public.DataType.String;
			this.txt25.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.txt25.Location = new System.Drawing.Point(96, 152);
			this.txt25.Name = "txt25";
			this.txt25.Size = new System.Drawing.Size(664, 23);
			this.txt25.TabIndex = 157;
			this.txt25.Text = "";
			// 
			// label27
			// 
			this.label27.BackColor = System.Drawing.Color.Transparent;
			this.label27.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.label27.ForeColor = System.Drawing.Color.Blue;
			this.label27.Location = new System.Drawing.Point(288, 128);
			this.label27.Name = "label27";
			this.label27.Size = new System.Drawing.Size(48, 23);
			this.label27.TabIndex = 148;
			this.label27.Text = "目的港";
			this.label27.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label26
			// 
			this.label26.BackColor = System.Drawing.Color.Transparent;
			this.label26.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.label26.Location = new System.Drawing.Point(592, 104);
			this.label26.Name = "label26";
			this.label26.Size = new System.Drawing.Size(48, 23);
			this.label26.TabIndex = 138;
			this.label26.Text = "交货期";
			this.label26.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label25
			// 
			this.label25.BackColor = System.Drawing.Color.Transparent;
			this.label25.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.label25.ForeColor = System.Drawing.Color.Blue;
			this.label25.Location = new System.Drawing.Point(424, 80);
			this.label25.Name = "label25";
			this.label25.Size = new System.Drawing.Size(40, 23);
			this.label25.TabIndex = 136;
			this.label25.Text = "暗佣";
			this.label25.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txt17
			// 
			this.txt17.BackColor = System.Drawing.Color.Yellow;
			this.txt17.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txt17.DataField = "darkcommision";
			this.txt17.DataType = TJSystem.Public.DataType.String;
			this.txt17.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.txt17.Location = new System.Drawing.Point(472, 80);
			this.txt17.Name = "txt17";
			this.txt17.Size = new System.Drawing.Size(112, 23);
			this.txt17.TabIndex = 137;
			this.txt17.Text = "";
			// 
			// label16
			// 
			this.label16.BackColor = System.Drawing.Color.Transparent;
			this.label16.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.label16.ForeColor = System.Drawing.Color.Blue;
			this.label16.Location = new System.Drawing.Point(240, 80);
			this.label16.Name = "label16";
			this.label16.Size = new System.Drawing.Size(40, 23);
			this.label16.TabIndex = 134;
			this.label16.Text = "明佣";
			this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txt16
			// 
			this.txt16.BackColor = System.Drawing.Color.Yellow;
			this.txt16.DataField = "brightcommision";
			this.txt16.DataType = TJSystem.Public.DataType.String;
			this.txt16.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.txt16.Location = new System.Drawing.Point(288, 80);
			this.txt16.Name = "txt16";
			this.txt16.Size = new System.Drawing.Size(112, 23);
			this.txt16.TabIndex = 135;
			this.txt16.Text = "";
			// 
			// label23
			// 
			this.label23.BackColor = System.Drawing.Color.Transparent;
			this.label23.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.label23.ForeColor = System.Drawing.Color.Blue;
			this.label23.Location = new System.Drawing.Point(8, 80);
			this.label23.Name = "label23";
			this.label23.Size = new System.Drawing.Size(80, 23);
			this.label23.TabIndex = 131;
			this.label23.Text = "结汇方式";
			this.label23.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label24
			// 
			this.label24.BackColor = System.Drawing.Color.Transparent;
			this.label24.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.label24.ForeColor = System.Drawing.Color.Blue;
			this.label24.Location = new System.Drawing.Point(32, 176);
			this.label24.Name = "label24";
			this.label24.Size = new System.Drawing.Size(56, 23);
			this.label24.TabIndex = 130;
			this.label24.Text = "金额";
			this.label24.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txt15
			// 
			this.txt15.BackColor = System.Drawing.Color.Yellow;
			this.txt15.DataField = "amount";
			this.txt15.DataType = TJSystem.Public.DataType.String;
			this.txt15.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.txt15.Location = new System.Drawing.Point(96, 176);
			this.txt15.Name = "txt15";
			this.txt15.Size = new System.Drawing.Size(112, 23);
			this.txt15.TabIndex = 133;
			this.txt15.Text = "";
			// 
			// txt11
			// 
			this.txt11.BackColor = System.Drawing.Color.White;
			this.txt11.DataField = "priceTerm_dest";
			this.txt11.DataType = TJSystem.Public.DataType.String;
			this.txt11.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.txt11.Location = new System.Drawing.Point(400, 56);
			this.txt11.Name = "txt11";
			this.txt11.Size = new System.Drawing.Size(160, 23);
			this.txt11.TabIndex = 129;
			this.txt11.Text = "";
			// 
			// label18
			// 
			this.label18.BackColor = System.Drawing.Color.Transparent;
			this.label18.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.label18.ForeColor = System.Drawing.Color.Blue;
			this.label18.Location = new System.Drawing.Point(224, 56);
			this.label18.Name = "label18";
			this.label18.Size = new System.Drawing.Size(64, 23);
			this.label18.TabIndex = 126;
			this.label18.Text = "价格条款";
			this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label19
			// 
			this.label19.BackColor = System.Drawing.Color.Transparent;
			this.label19.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.label19.ForeColor = System.Drawing.Color.Blue;
			this.label19.Location = new System.Drawing.Point(8, 56);
			this.label19.Name = "label19";
			this.label19.Size = new System.Drawing.Size(80, 23);
			this.label19.TabIndex = 123;
			this.label19.Text = "币种";
			this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label9
			// 
			this.label9.BackColor = System.Drawing.Color.Transparent;
			this.label9.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.label9.Location = new System.Drawing.Point(592, 32);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(40, 23);
			this.label9.TabIndex = 120;
			this.label9.Text = "姓名";
			this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txt8
			// 
			this.txt8.BackColor = System.Drawing.Color.White;
			this.txt8.DataField = "Contact_name";
			this.txt8.DataType = TJSystem.Public.DataType.String;
			this.txt8.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.txt8.Location = new System.Drawing.Point(640, 32);
			this.txt8.Name = "txt8";
			this.txt8.Size = new System.Drawing.Size(120, 23);
			this.txt8.TabIndex = 121;
			this.txt8.Text = "";
			// 
			// label5
			// 
			this.label5.BackColor = System.Drawing.Color.Transparent;
			this.label5.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.label5.ForeColor = System.Drawing.Color.Blue;
			this.label5.Location = new System.Drawing.Point(408, 8);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(64, 23);
			this.label5.TabIndex = 118;
			this.label5.Text = "客户单号";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txt3
			// 
			this.txt3.BackColor = System.Drawing.Color.White;
			this.txt3.DataField = "client_orderNo";
			this.txt3.DataType = TJSystem.Public.DataType.String;
			this.txt3.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.txt3.Location = new System.Drawing.Point(472, 8);
			this.txt3.Name = "txt3";
			this.txt3.Size = new System.Drawing.Size(112, 23);
			this.txt3.TabIndex = 119;
			this.txt3.Text = "";
			// 
			// label3
			// 
			this.label3.BackColor = System.Drawing.Color.Transparent;
			this.label3.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.label3.ForeColor = System.Drawing.Color.Blue;
			this.label3.Location = new System.Drawing.Point(424, 32);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(48, 23);
			this.label3.TabIndex = 116;
			this.label3.Text = "联系人";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label21
			// 
			this.label21.BackColor = System.Drawing.Color.Transparent;
			this.label21.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.label21.Location = new System.Drawing.Point(216, 224);
			this.label21.Name = "label21";
			this.label21.Size = new System.Drawing.Size(64, 23);
			this.label21.TabIndex = 42;
			this.label21.Text = "修改时间";
			this.label21.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txt31
			// 
			this.txt31.BackColor = System.Drawing.Color.White;
			this.txt31.DataField = "modifyon";
			this.txt31.DataType = TJSystem.Public.DataType.String;
			this.txt31.Enabled = false;
			this.txt31.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.txt31.Location = new System.Drawing.Point(288, 224);
			this.txt31.Name = "txt31";
			this.txt31.Size = new System.Drawing.Size(112, 23);
			this.txt31.TabIndex = 41;
			this.txt31.Text = "";
			// 
			// label20
			// 
			this.label20.BackColor = System.Drawing.Color.Transparent;
			this.label20.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.label20.Location = new System.Drawing.Point(216, 200);
			this.label20.Name = "label20";
			this.label20.Size = new System.Drawing.Size(64, 23);
			this.label20.TabIndex = 40;
			this.label20.Text = "创建时间";
			this.label20.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txt27
			// 
			this.txt27.BackColor = System.Drawing.Color.White;
			this.txt27.DataField = "createon";
			this.txt27.DataType = TJSystem.Public.DataType.String;
			this.txt27.Enabled = false;
			this.txt27.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.txt27.Location = new System.Drawing.Point(288, 200);
			this.txt27.Name = "txt27";
			this.txt27.Size = new System.Drawing.Size(112, 23);
			this.txt27.TabIndex = 39;
			this.txt27.Text = "";
			// 
			// label17
			// 
			this.label17.BackColor = System.Drawing.Color.Transparent;
			this.label17.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.label17.Location = new System.Drawing.Point(8, 224);
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
			this.label15.Location = new System.Drawing.Point(8, 200);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(80, 23);
			this.label15.TabIndex = 29;
			this.label15.Text = "创建者";
			this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label12
			// 
			this.label12.BackColor = System.Drawing.Color.Transparent;
			this.label12.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.label12.ForeColor = System.Drawing.Color.Blue;
			this.label12.Location = new System.Drawing.Point(592, 8);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(40, 23);
			this.label12.TabIndex = 26;
			this.label12.Text = "状态";
			this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label11
			// 
			this.label11.BackColor = System.Drawing.Color.Transparent;
			this.label11.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.label11.ForeColor = System.Drawing.Color.Blue;
			this.label11.Location = new System.Drawing.Point(8, 32);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(80, 23);
			this.label11.TabIndex = 25;
			this.label11.Text = "客户代码";
			this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label8
			// 
			this.label8.BackColor = System.Drawing.Color.Transparent;
			this.label8.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.label8.ForeColor = System.Drawing.Color.Blue;
			this.label8.Location = new System.Drawing.Point(240, 8);
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
			this.label7.Location = new System.Drawing.Point(216, 32);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(64, 23);
			this.label7.TabIndex = 21;
			this.label7.Text = "客户名称";
			this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label2
			// 
			this.label2.BackColor = System.Drawing.Color.Transparent;
			this.label2.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.label2.ForeColor = System.Drawing.Color.Blue;
			this.label2.Location = new System.Drawing.Point(8, 8);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(80, 23);
			this.label2.TabIndex = 16;
			this.label2.Text = "销售单号";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txt6
			// 
			this.txt6.BackColor = System.Drawing.Color.White;
			this.txt6.DataField = "client_name";
			this.txt6.DataType = TJSystem.Public.DataType.String;
			this.txt6.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.txt6.Location = new System.Drawing.Point(288, 32);
			this.txt6.Name = "txt6";
			this.txt6.Size = new System.Drawing.Size(112, 23);
			this.txt6.TabIndex = 104;
			this.txt6.Text = "";
			// 
			// txt26
			// 
			this.txt26.BackColor = System.Drawing.Color.White;
			this.txt26.DataField = "createBy";
			this.txt26.DataType = TJSystem.Public.DataType.String;
			this.txt26.Enabled = false;
			this.txt26.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.txt26.Location = new System.Drawing.Point(96, 200);
			this.txt26.Name = "txt26";
			this.txt26.Size = new System.Drawing.Size(112, 23);
			this.txt26.TabIndex = 12;
			this.txt26.Text = "";
			// 
			// txt30
			// 
			this.txt30.BackColor = System.Drawing.Color.White;
			this.txt30.DataField = "modifyBy";
			this.txt30.DataType = TJSystem.Public.DataType.String;
			this.txt30.Enabled = false;
			this.txt30.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.txt30.Location = new System.Drawing.Point(96, 224);
			this.txt30.Name = "txt30";
			this.txt30.Size = new System.Drawing.Size(112, 23);
			this.txt30.TabIndex = 9;
			this.txt30.Text = "";
			// 
			// txt1
			// 
			this.txt1.BackColor = System.Drawing.Color.White;
			this.txt1.DataField = "so_code";
			this.txt1.DataType = TJSystem.Public.DataType.String;
			this.txt1.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.txt1.Location = new System.Drawing.Point(96, 8);
			this.txt1.Name = "txt1";
			this.txt1.Size = new System.Drawing.Size(120, 23);
			this.txt1.TabIndex = 100;
			this.txt1.Text = "";
			// 
			// label4
			// 
			this.label4.BackColor = System.Drawing.Color.Transparent;
			this.label4.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.label4.ForeColor = System.Drawing.Color.Blue;
			this.label4.Location = new System.Drawing.Point(24, 128);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(64, 23);
			this.label4.TabIndex = 146;
			this.label4.Text = "运抵国";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label6
			// 
			this.label6.BackColor = System.Drawing.Color.Transparent;
			this.label6.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.label6.ForeColor = System.Drawing.Color.Blue;
			this.label6.Location = new System.Drawing.Point(408, 104);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(48, 23);
			this.label6.TabIndex = 144;
			this.label6.Text = "起运港";
			this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label10
			// 
			this.label10.BackColor = System.Drawing.Color.Transparent;
			this.label10.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.label10.ForeColor = System.Drawing.Color.Blue;
			this.label10.Location = new System.Drawing.Point(8, 104);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(80, 23);
			this.label10.TabIndex = 141;
			this.label10.Text = "运输方式";
			this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label13
			// 
			this.label13.BackColor = System.Drawing.Color.Transparent;
			this.label13.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.label13.ForeColor = System.Drawing.Color.Blue;
			this.label13.Location = new System.Drawing.Point(232, 104);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(56, 23);
			this.label13.TabIndex = 140;
			this.label13.Text = "目的地";
			this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// linkLabel2
			// 
			this.linkLabel2.AutoSize = true;
			this.linkLabel2.BackColor = System.Drawing.Color.Transparent;
			this.linkLabel2.ForeColor = System.Drawing.SystemColors.ControlText;
			this.linkLabel2.Location = new System.Drawing.Point(672, 232);
			this.linkLabel2.Name = "linkLabel2";
			this.linkLabel2.Size = new System.Drawing.Size(63, 19);
			this.linkLabel2.TabIndex = 189;
			this.linkLabel2.TabStop = true;
			this.linkLabel2.Text = "形式发票";
			this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
			// 
			// lk_detail
			// 
			this.lk_detail.Location = new System.Drawing.Point(0, 0);
			this.lk_detail.Name = "lk_detail";
			this.lk_detail.TabIndex = 0;
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
			// panel1
			// 
			this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
			this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.panel1.Controls.Add(this.label1);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(784, 48);
			this.panel1.TabIndex = 16;
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label1.Font = new System.Drawing.Font("宋体", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.label1.Location = new System.Drawing.Point(0, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(780, 44);
			this.label1.TabIndex = 0;
			this.label1.Text = "销售订单";
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
			// tel2
			// 
			this.tel2.Format = "";
			this.tel2.FormatInfo = null;
			this.tel2.HeaderText = "电话2";
			this.tel2.MappingName = "tel2";
			this.tel2.NullText = "";
			this.tel2.Width = 75;
			// 
			// frmSaleOrder
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(7, 16);
			this.BackColor = System.Drawing.SystemColors.ScrollBar;
			this.ClientSize = new System.Drawing.Size(784, 566);
			this.Controls.Add(this.panel3);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "frmSaleOrder";
			this.Text = "销售订单";
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
				TJSystem.Public.PublicStatic.formName = "销售订单";
			}
			base.OnClosing (e);
		}


		private void linkLabel1_LinkClicked(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
		{
			if(this.priComboBox2.Enabled == true)
			{
				TJSystem.Public.PublicStatic.ShowMessage(TJSystem.Public.MessageType.Exclamation,"只有当前订单处于非编辑状态才可以进行明细更改!");
				return;
			}
			if (this.txt1.Text.ToString().Trim() == "" )
			{
				TJSystem.Public.PublicStatic.ShowMessage(TJSystem.Public.MessageType.Exclamation,"请选择一张销售订单号");
				return;
			}
			else
			{
				frmSaleOrder2 frmso2 = new frmSaleOrder2(this.txt1.Text.ToString().Trim());
				frmso2.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
				frmso2.ShowDialog();
				this.txt15.Text = TJSystem.Public.PublicStatic.AmountTotal.ToString();
				Count += 1;
			}			
		}


		private void priComboBox2_SelectionChangeCommitted(object sender, System.EventArgs e)
		{
			DataRow dr = null;
			DataTable dtcpy = null;
			string sql = "select  a.client_name as client_name, b.contact_id, b.contact_id +' '+b.contact_name as contact_name  from basic_client a join basic_client_contact b on a.client_id = b.client_id and a.client_id = '"+ this.priComboBox2.SelectedValue +"'";
			DataTable dt = TJSystem.Public.PublicStatic.db.GetDataTable(sql);
			dr = dt.NewRow();
			dr[0] = "";
			dr[1] = "";
			dt.Rows.InsertAt(dr,0);
			dtcpy = dt.Copy();
			this.priComboBox11.DataSource = dtcpy.DefaultView;
			this.priComboBox11.ValueMember = "contact_id";
			this.priComboBox11.DisplayMember = "contact_name";
			this.priComboBox11.Enabled = true;
			sql = "select client_name from basic_client where client_id = '"+ this.priComboBox2.SelectedValue +"'";
			dt = TJSystem.Public.PublicStatic.db.GetDataTable(sql);
			if(dt.Rows.Count == 1)
			{
				this.txt6.Text = dt.Rows[0]["client_name"].ToString();
			}
			else
			{
				this.txt6.Text = "";
			}
		}

		private void priComboBox11_SelectionChangeCommitted(object sender, System.EventArgs e)
		{
			string sql = "select contact_name from basic_client_contact where contact_id = '"+ this.priComboBox11.SelectedValue +"'";
			DataTable dt = TJSystem.Public.PublicStatic.db.GetDataTable(sql);
			if(dt.Rows.Count == 1)
			{
				this.txt8.Text = dt.Rows[0]["contact_name"].ToString();
			}
			else
			{
				this.txt8.Text ="";
			}
			
		}

		private void priComboBox4_SelectionChangeCommitted(object sender, System.EventArgs e)
		{
			if(this.priComboBox4.SelectedValue != null)
			{
				string sql = "select Term_namecn from p_priceTerm where term_code = '"+ this.priComboBox4.SelectedValue +"'";
				DataTable dt = TJSystem.Public.PublicStatic.db.GetDataTable(sql);
				if(dt.Rows.Count == 1)
				{
					this.txt11.Text = dt.Rows[0]["Term_namecn"].ToString();
				}
				else
				{
					this.txt11.Text = "";
				}
			}
		}

		private void linkLabel2_LinkClicked(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
		{
			string strsol = null;
			if(this.txt1.Text.Trim().Equals(""))
			{
				TJSystem.Public.PublicStatic.ShowMessage(TJSystem.Public.MessageType.Exclamation,"请选择要打印的销售单号！");
				return;
			}
			strsol = txt1.Text.Trim();
						
			TJSystem.Classes.common.DocParamCommon dpcom = new TJSystem.Classes.common.DocParamCommon();
			dpcom.PKCondition = " where so_code in ('"+ strsol +"')";
			dpcom.DocSaleNO = this.txt1.Text.Trim();
			dpcom.DocDate = this.priDateTimePicker1.Value.ToString("yyyy-MM-dd");
			dpcom.DocSaleTo = this.txt6.Text.Trim();
			if(this.priComboBox8.SelectedValue == null 
				|| this.priComboBox8.Text == "")
			{
				dpcom.DocPOE = "";
			}
			else
			{
				dpcom.DocPOE = this.priComboBox8.Text.Replace(this.priComboBox8.SelectedValue.ToString(),"").Substring(1);
			}
			if(this.priComboBox7.SelectedValue == null
				|| this.priComboBox7.Text == "")
			{
				dpcom.DocPOD = "";
			}
			else
			{
				dpcom.DocPOD = this.priComboBox7.Text.Replace(this.priComboBox7.SelectedValue.ToString(),"").Substring(1);
			}
			if(this.priComboBox6.SelectedValue == null
				|| this.priComboBox6.Text == "")
			{
				dpcom.ShipperType = "";
			}
			else
			{
				dpcom.ShipperType = this.priComboBox6.Text;
			}
			if(this.priComboBox5.SelectedValue == null
				|| this.priComboBox5.Text == "")
			{
				dpcom.PayType = "";
			}
			else
			{
				dpcom.PayType = this.priComboBox5.Text.Replace(this.priComboBox5.SelectedValue.ToString(),"").Substring(1);
			}
			dpcom.Remark = txt25.Text;
			
			TJSystem.CrystalRPT.frmReport frm = new TJSystem.CrystalRPT.frmReport("形式发票",dpcom,this.dataGrid1);
			frm.ShowDialog();
		}

		private void priComboBox1_SelectionChangeCommitted(object sender, System.EventArgs e)
		{
			TJSystem.Public.PublicStatic.SetApprovedInfo(this.priComboBox1,this.txt28,this.txt29);
		}

		private void linkLabel3_LinkClicked(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
		{
			string strsol = null;
			if(this.txt1.Text.Trim().Equals(""))
			{
				TJSystem.Public.PublicStatic.ShowMessage(TJSystem.Public.MessageType.Exclamation,"请选择要打印的销售单号！");
				return;
			}
			strsol = txt1.Text.Trim();
						
			TJSystem.Classes.common.DocParamCommon dpcom = new TJSystem.Classes.common.DocParamCommon();
			dpcom.PKCondition = " where a.so_code in ('"+ strsol +"')";
			dpcom.DocSaleNO = this.txt1.Text.Trim();
			dpcom.DocDate = this.priDateTimePicker1.Value.ToString("yyyy-MM-dd");
			dpcom.DocSaleTo = this.txt6.Text.Trim();
			if(this.priComboBox8.SelectedValue == null 
				|| this.priComboBox8.Text == "")
			{
				dpcom.DocPOE = "";
			}
			else
			{
				dpcom.DocPOE = this.priComboBox8.Text.Replace(this.priComboBox8.SelectedValue.ToString(),"").Substring(1);
			}
			if(this.priComboBox7.SelectedValue == null
				|| this.priComboBox7.Text == "")
			{
				dpcom.DocPOD = "";
			}
			else
			{
				dpcom.DocPOD = this.priComboBox7.Text.Replace(this.priComboBox7.SelectedValue.ToString(),"").Substring(1);
			}
			if(this.priComboBox6.SelectedValue == null
				|| this.priComboBox6.Text == "")
			{
				dpcom.ShipperType = "";
			}
			else
			{
				dpcom.ShipperType = this.priComboBox6.Text;
			}
			if(this.priComboBox5.SelectedValue == null
				|| this.priComboBox5.Text == "")
			{
				dpcom.PayType = "";
			}
			else
			{
				dpcom.PayType = this.priComboBox5.Text.Replace(this.priComboBox5.SelectedValue.ToString(),"").Substring(1);
			}
			dpcom.Remark = txt25.Text;
			
			TJSystem.CrystalRPT.frmReport frm = new TJSystem.CrystalRPT.frmReport("购销合同",dpcom,this.dataGrid1);
			frm.ShowDialog();
		}

		private void linkLabel4_LinkClicked(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
		{
			string strsol = null;
			if(this.txt1.Text.Trim().Equals(""))
			{
				TJSystem.Public.PublicStatic.ShowMessage(TJSystem.Public.MessageType.Exclamation,"请选择要打印的销售单号！");
				return;
			}
			strsol = txt1.Text.Trim();
						
			TJSystem.Classes.common.DocParamCommon dpcom = new TJSystem.Classes.common.DocParamCommon();
			dpcom.PKCondition = " where a.so_code in ('"+ strsol +"')";
			dpcom.DocSaleNO = this.txt1.Text.Trim();
			dpcom.DocDate = this.priDateTimePicker1.Value.ToString("yyyy-MM-dd");
			dpcom.DocSaleTo = this.txt6.Text.Trim();
			if(this.priComboBox8.SelectedValue == null 
				|| this.priComboBox8.Text == "")
			{
				dpcom.DocPOE = "";
			}
			else
			{
				dpcom.DocPOE = this.priComboBox8.Text.Replace(this.priComboBox8.SelectedValue.ToString(),"").Substring(1);
			}
			if(this.priComboBox7.SelectedValue == null
				|| this.priComboBox7.Text == "")
			{
				dpcom.DocPOD = "";
			}
			else
			{
				dpcom.DocPOD = this.priComboBox7.Text.Replace(this.priComboBox7.SelectedValue.ToString(),"").Substring(1);
			}
			if(this.priComboBox6.SelectedValue == null
				|| this.priComboBox6.Text == "")
			{
				dpcom.ShipperType = "";
			}
			else
			{
				dpcom.ShipperType = this.priComboBox6.Text;
			}
			if(this.priComboBox5.SelectedValue == null
				|| this.priComboBox5.Text == "")
			{
				dpcom.PayType = "";
			}
			else
			{
				dpcom.PayType = this.priComboBox5.Text.Replace(this.priComboBox5.SelectedValue.ToString(),"").Substring(1);
			}
			dpcom.Remark = txt25.Text;
			
			TJSystem.CrystalRPT.frmReport frm = new TJSystem.CrystalRPT.frmReport("Sales Confirmation",dpcom,this.dataGrid1);
			frm.ShowDialog();
		}

		/*
		private void priComboBox14_SelectionChangeCommitted(object sender, System.EventArgs e)
		{
			string sql = null;
			DataTable dt = null;
			DataTable dtcpy = null;
			DataRow dr = null;
			sql = "select a.SEQ_NO,ltrim(str(a.SEQ_NO))+' '+a.PROC_NO+' '+b.proc_name as PROC_NAME from brm_flow_mstr a ";
			sql += " left join brm_process b  on a.proc_no=b.proc_no";
			sql += " where a.flow_id='" + priComboBox14.SelectedValue.ToString() + "'";
			sql += " order by a.seq_no";
			dt = TJSystem.Public.PublicStatic.db.GetDataTable(sql);
			dtcpy = dt.Copy();
			this.priComboBox1.DataSource = dtcpy.DefaultView;
			this.priComboBox1.ValueMember = "SEQ_NO";
			this.priComboBox1.DisplayMember = "PROC_NAME";
		}
		*/

		private void dataGrid1_Click(object sender, System.EventArgs e)
		{
			DataView dv = (DataView)this.dataGrid1.DataSource;
			if(this.dataGrid1.CurrentRowIndex == -1)
			{
				return;
			}
			/*
			if(dv[this.dataGrid1.CurrentRowIndex]["flow_id"].ToString().Equals(""))
			{
				return;
			}
			*/

			string sql = null;
			DataTable dt = null;
			DataTable dtcpy = null;
			DataRow dr = null;
			/*
			sql = "select a.SEQ_NO,ltrim(str(a.SEQ_NO))+' '+a.PROC_NO+' '+b.proc_name as PROC_NAME from brm_flow_mstr a ";
			sql += " left join brm_process b  on a.proc_no=b.proc_no";
			sql += " where a.flow_id='" + dv[this.dataGrid1.CurrentRowIndex]["flow_id"].ToString() + "'";
			sql += " order by a.seq_no";
			dt = TJSystem.Public.PublicStatic.db.GetDataTable(sql);
			dtcpy = dt.Copy();
			this.priComboBox1.DataSource = dtcpy.DefaultView;
			this.priComboBox1.ValueMember = "SEQ_NO";
			this.priComboBox1.DisplayMember = "PROC_NAME";
			*/

			if(this.priComboBox2.SelectedValue != null)
			{
				sql = "select  a.client_name as client_name, b.contact_id, b.contact_id +' '+b.contact_name as contact_name  from basic_client a join basic_client_contact b on a.client_id = b.client_id and a.client_id = '"+ this.priComboBox2.SelectedValue.ToString() +"'";
				dt = TJSystem.Public.PublicStatic.db.GetDataTable(sql);
				dr = dt.NewRow();
				dr[0] = "";
				dr[1] = "";
				dt.Rows.InsertAt(dr,0);
				dtcpy = dt.Copy();
				this.priComboBox11.DataSource = dtcpy.DefaultView;
				this.priComboBox11.ValueMember = "contact_id";
				this.priComboBox11.DisplayMember = "contact_name";
			}

		}

		private void checkBox1_CheckedChanged(object sender, System.EventArgs e)
		{
			System.Text.StringBuilder sb = new System.Text.StringBuilder();
			sb.Append("select a.so_code,a.so_date,a.client_orderNo,a.client_id,a.client_name,a.Contact_id,");
			sb.Append(" a.Contact_name,a.Currency,c.Currency_namecn as Currency_name,a.priceTerm,a.priceTerm_dest,");
			sb.Append(" a.discountType,a.discount,a.settlementType,a.amount,a.fobamount,a.insurance,a.freightamount,");
			sb.Append(" a.brightcommision,a.darkcommision,a.deliverydate,a.transType,d.trans_namecn as transType_name,a.arriveregion,e.region_namecn as arriveregion_name,");
			sb.Append(" a.arrivecountry,g.country_namecn as arrivecountry_name,a.Port_departure,f.port_namecn as Port_departure_name,a.destport,h.port_namecn as destport_name,a.destination,a.marks,");
			sb.Append(" a.remark,a.saleTerm_ID,a.saleConf_ID,a.createBy,a.createon,a.approvedBy,a.approvedon,a.modifyBy,a.modifyon,a.confirmedBy,a.confirmedon,a.bargainon, ");
			sb.Append(" a.status,b.status_name as status_name,a.visible_flag");
			sb.Append(" from sale_so_master a");
			sb.Append(" left join p_status b");
			sb.Append(" on a.status = b.status_id and b.status_type = '"+_statusType+"'");
			sb.Append(" left join p_currency c");
			sb.Append(" on a.Currency = c.Currency_code");
			sb.Append(" left join p_transtype d");
			sb.Append(" on a.transType = d.trans_code");
			sb.Append(" left join p_region e");
			sb.Append(" on a.arriveregion = e.region_code ");
			sb.Append(" left join p_port f");
			sb.Append(" on a.Port_departure = f.port_code");
			sb.Append(" left join p_country g");
			sb.Append(" on a.arrivecountry = g.country_code");
			sb.Append(" left join p_port h");
			sb.Append(" on a.destport = h.port_code");
			if(!this.checkBox1.Checked)
			{
				sb.Append(" where a.visible_flag<>'N'");
				sb.Append(" and a.status in ('1','2')");
			}
			sb.Append(" order by a.so_code");
			this.InitialGrid(sb.ToString());
			priToolBar1.Initial(_table,_PK,sb.ToString());
		}
	}
}

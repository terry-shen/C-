using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace TJSystem.Doc
{
	/// <summary>
	/// Form1 的摘要说明。
	/// </summary>
	public class frmAwbDoc : System.Windows.Forms.Form
	{		
		/// <summary>
		/// 必需的设计器变量。
		/// </summary>
		private System.ComponentModel.Container components = null;
		private System.Windows.Forms.Panel panel3;
		private TJSystem.UC.PriToolBar priToolBar1;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Panel panel4;
		private System.Windows.Forms.Label label24;
		private TJSystem.Classes.PriTextBox priTextBox20;
		private TJSystem.Classes.PriTextBox priTextBox22;
		private System.Windows.Forms.Label label28;
		private System.Windows.Forms.Label label21;
		private TJSystem.Classes.PriTextBox priTextBox17;
		private System.Windows.Forms.Label label18;
		private TJSystem.Classes.PriTextBox priTextBox14;
		private System.Windows.Forms.Label label16;
		private System.Windows.Forms.Label label17;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.Label label13;
		private TJSystem.Classes.PriTextBox priTextBox10;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private TJSystem.Classes.PriComboBox comboBox1;
		private TJSystem.Classes.PriTextBox textBox1;
		private System.Windows.Forms.DataGrid dataGrid1;
		private System.Windows.Forms.DataGridTableStyle dataGridTableStyle1;
		private System.Windows.Forms.Label label35;
		private System.Windows.Forms.Label label36;
		private System.Windows.Forms.Label label20;
		private TJSystem.Classes.PriTextBox priTextBox16;
		private System.Windows.Forms.Label label37;
		private TJSystem.Classes.PriTextBox priTextBox29;
		private TJSystem.Classes.PriComboBox priComboBox1;
		public static System.Windows.Forms.Form frmCurrent = null ;
		private string _statusType = null;
		private string _table = null;
		private string _PK = null;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label22;
		private System.Windows.Forms.Label label23;
		private System.Windows.Forms.Label label29;
		private System.Windows.Forms.Label label33;
		private System.Windows.Forms.Label label34;
		private TJSystem.Classes.PriTextBox priTextBox18;
		private System.Windows.Forms.Label label38;
		private System.Windows.Forms.Label label39;
		private TJSystem.Classes.PriTextBox priTextBox26;
		private System.Windows.Forms.Label label41;
		private System.Windows.Forms.Label label42;
		private TJSystem.Classes.PriTextBox priTextBox33;
		private TJSystem.Classes.PriTextBox priTextBox35;
		private System.Windows.Forms.Label label45;
		private TJSystem.Classes.PriTextBox priTextBox36;
		private System.Windows.Forms.Label label46;
		private TJSystem.Classes.PriDateTimePicker priDateTimePicker3;
		private TJSystem.Classes.PriComboBox priComboBox3;
		private TJSystem.Classes.PriComboBox priComboBox4;
		private TJSystem.Classes.PriComboBox priComboBox5;
		private TJSystem.Classes.PriComboBox priComboBox7;
		private TJSystem.Classes.PriComboBox priComboBox8;
		private TJSystem.Classes.PriDateTimePicker priDateTimePicker4;
		private TJSystem.Classes.PriTextBox priTextBox1;
		private TJSystem.Classes.PriTextBox priTextBox2;
		private TJSystem.Classes.PriTextBox priTextBox6;
		private TJSystem.Classes.PriTextBox priTextBox7;
		private TJSystem.Classes.PriTextBox priTextBox8;
		private TJSystem.Classes.PriComboBox priComboBox12;
		private System.Windows.Forms.DataGridTextBoxColumn allowtransport;
		private System.Windows.Forms.DataGridTextBoxColumn allowbatch;
		private System.Windows.Forms.DataGridTextBoxColumn billloading;
		private System.Windows.Forms.DataGridTextBoxColumn approvedby;
		private System.Windows.Forms.DataGridTextBoxColumn approvedon;
		private System.Windows.Forms.DataGridTextBoxColumn shipper;
		private System.Windows.Forms.DataGridTextBoxColumn lc_code;
		private System.Windows.Forms.DataGridTextBoxColumn consignee;
		private System.Windows.Forms.DataGridTextBoxColumn notifier;
		private System.Windows.Forms.DataGridTextBoxColumn createby;
		private System.Windows.Forms.DataGridTextBoxColumn createon;
		private System.Windows.Forms.DataGridTextBoxColumn modifyby;
		private System.Windows.Forms.DataGridTextBoxColumn modifyon;
		private System.Windows.Forms.DataGridTextBoxColumn port_departure_name;
		private System.Windows.Forms.DataGridTextBoxColumn COUNTRY_NAMECN;
		private System.Windows.Forms.DataGridTextBoxColumn destport_name;
		private System.Windows.Forms.DataGridTextBoxColumn port_transport_name;
		private System.Windows.Forms.DataGridTextBoxColumn STATUS_NAME;
		private System.Windows.Forms.DataGridTextBoxColumn CURRENCY_NAMECN;
		private TJSystem.Classes.PriTextBox priTextBox4;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label4;
		private TJSystem.Classes.PriTextBox priTextBox3;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label47;
		private TJSystem.Classes.PriTextBox priTextBox37;
		private System.Windows.Forms.Label label48;
		private TJSystem.Classes.PriTextBox priTextBox38;
		private System.Windows.Forms.Label label10;
		private TJSystem.Classes.PriComboBox priComboBox2;
		private System.Windows.Forms.Label label15;
		private TJSystem.Classes.PriComboBox priComboBox9;
		private TJSystem.Classes.PriTextBox priTextBox5;
		private TJSystem.Classes.PriTextBox priTextBox11;
		private System.Windows.Forms.Label label19;
		private TJSystem.Classes.PriTextBox priTextBox12;
		private System.Windows.Forms.DataGridTextBoxColumn INVOICE_NO;
		private System.Windows.Forms.DataGridTextBoxColumn AWB_DATE;
		private System.Windows.Forms.DataGridTextBoxColumn AWB_CODE;
		private System.Windows.Forms.DataGridTextBoxColumn DESTINATION;
		private System.Windows.Forms.DataGridTextBoxColumn FREIGHT_TUN;
		private System.Windows.Forms.DataGridTextBoxColumn FREIGHT_AMOUNT;
		private System.Windows.Forms.DataGridTextBoxColumn LOADINGDATE;
		private System.Windows.Forms.DataGridTextBoxColumn OCEAN_VESSEL;
		private System.Windows.Forms.DataGridTextBoxColumn FREIGHT_RATE;
		private System.Windows.Forms.DataGridTextBoxColumn PRECARRIAGEBY;
		private System.Windows.Forms.DataGridTextBoxColumn CARRIAGEBY;
		private System.Windows.Forms.DataGridTextBoxColumn ITEM_AMOUNT;
		private System.Windows.Forms.DataGridTextBoxColumn CONTACT_NAME;
		private System.Windows.Forms.DataGridTextBoxColumn FREIGHT_PAYDATE;
		private System.Windows.Forms.DataGridTextBoxColumn Awb_NAME;
		private System.Windows.Forms.DataGridTextBoxColumn pay_term_name;
		private TJSystem.Classes.PriDateTimePicker priDateTimePicker1;
		private TJSystem.Classes.PriComboBox priComboBox6;
		private System.Windows.Forms.Label label12;
		private TJSystem.Classes.XpStyleButton button1;
		private TJSystem.Classes.XpStyleButton xpStyleButton1;
		private TJSystem.Classes.XpStyleButton xpStyleButton2;

		private System.Windows.Forms.Form _form = null;

		public frmAwbDoc()
		{
			//
			// Windows 窗体设计器支持所必需的
			//
			InitializeComponent();

			
			_statusType = "doc";
			TJSystem.Public.PublicStatic.setBackgroundImg(this.panel1,this.panel1.GetType().ToString(),"images\\bg.gif");
			TJSystem.Public.PublicStatic.setBackgroundImg(this.panel2,this.panel1.GetType().ToString(),"");
			TJSystem.Public.PublicStatic.setBackgroundImg(this.panel3,this.panel1.GetType().ToString(),"");
			TJSystem.Public.PublicStatic.setBackgroundImg(this.panel4,this.panel1.GetType().ToString(),"");

			this.Cursor = System.Windows.Forms.Cursors.WaitCursor;
			InitialFormData();
			

			System.Text.StringBuilder sb = new System.Text.StringBuilder();
			sb.Append("SELECT A.AWB_CODE,A.AWB_DATE,A.INVOICE_NO,A.STATUS,B.STATUS_NAME,A.LC_CODE,A.CURRENCY,C.CURRENCY_NAMECN,A.DESTINATION, ");
			sb.Append(" A.PORT_DEPARTURE,n.PORT_NAMECN as port_departure_name,A.ARRIVECOUNTRY,e.COUNTRY_NAMECN as COUNTRY_NAMECN,");
			sb.Append(" A.DESTPORT,i.PORT_NAMECN as destport_name,A.PORT_TRANSPORT,f.PORT_NAMECN as port_transport_name,");
			sb.Append(" A.TRANSTYPE,A.BILLLOADING,A.FREIGHT_TUN,A.FREIGHT_RATE,A.FREIGHT_AMOUNT,");
			sb.Append(" A.FREIGHT_PAYDATE,A.ITEM_AMOUNT,A.LOADINGDATE,A.FREIGHT_PAYTYPE,L.PAYMODE_NAME_CN as pay_term_name,");
			sb.Append(" A.ALLOWBATCH,A.ALLOWTRANSPORT,A.SHIPPER_ID,a.loadingterm,");
			sb.Append(" A.SHIPPER,A.CONTACT_ID,A.CONTACT_NAME,A.PRECARRIAGEBY,A.CARRIAGEBY,A.OCEAN_VESSEL,A.CONSIGNEE,A.NOTIFIER,A.Awb_NAME,");
			sb.Append(" A.APPROVEDBY,A.APPROVEDON,A.CREATEBY,A.CREATEON,A.MODIFYBY,A.MODIFYON");
			sb.Append(" FROM SALE_WAYBILL_MASTER A");
			sb.Append(" LEFT JOIN P_STATUS B ON A.STATUS=B.STATUS_ID AND B.STATUS_TYPE=");
			sb.Append("'");
			sb.Append(this._statusType);
			sb.Append("' ");
			sb.Append(" LEFT JOIN P_CURRENCY C ON A.CURRENCY=C.CURRENCY_CODE");
			sb.Append(" left join p_country e on a.arrivecountry=e.COUNTRY_CODE");
			sb.Append(" left join p_port f on a.port_transport=f.PORT_CODE");
			sb.Append(" left join p_transtype h on a.transtype=h.TRANS_CODE");
			sb.Append(" left join p_port i on a.destport=i.PORT_CODE");
			sb.Append(" left join p_PAYMODE l on a.FREIGHT_PAYTYPE=l.PAYMODE_ID");
			sb.Append(" left join p_port n on a.port_departure=n.PORT_CODE");
			sb.Append(" left join p_tradechar o on a.loadingterm=o.TRADE_ID");
			sb.Append(" order by a.AWB_CODE");
			this.InitialGrid(sb.ToString());

			priToolBar1.setCurrentForm = this;
			
			_PK = "AWB_CODE";
			_table = "SALE_WAYBILL_MASTER";
			priToolBar1.Initial(_table,_PK,sb.ToString());
			priToolBar1.BeforeButtonClickEvent += new TJSystem.UC.PriToolBar.BeforeButotnClick(this.BeforeButtonClick);
			priToolBar1.AfterButtonClickEvent += new TJSystem.UC.PriToolBar.AfterButtonClick(this.AfterButtonClick);

			this.priToolBar1.setButtonVisibleFalse();;
			this.priToolBar1.setButtonVisible("012345689");

			setDisable();

			this.Cursor = System.Windows.Forms.Cursors.Default;
			//
			// TODO: 在 InitializeComponent 调用后添加任何构造函数代码
			//
		}

		public frmAwbDoc(string awblist)
		{
			//
			// Windows 窗体设计器支持所必需的
			//
			InitializeComponent();

			
			_statusType = "doc";
			TJSystem.Public.PublicStatic.setBackgroundImg(this.panel1,this.panel1.GetType().ToString(),"images\\bg.gif");
			TJSystem.Public.PublicStatic.setBackgroundImg(this.panel2,this.panel1.GetType().ToString(),"");
			TJSystem.Public.PublicStatic.setBackgroundImg(this.panel3,this.panel1.GetType().ToString(),"");
			TJSystem.Public.PublicStatic.setBackgroundImg(this.panel4,this.panel1.GetType().ToString(),"");

			this.Cursor = System.Windows.Forms.Cursors.WaitCursor;
			InitialFormData();
			

			System.Text.StringBuilder sb = new System.Text.StringBuilder();
			sb.Append("SELECT A.AWB_CODE,A.AWB_DATE,A.INVOICE_NO,A.STATUS,B.STATUS_NAME,A.LC_CODE,A.CURRENCY,C.CURRENCY_NAMECN,A.DESTINATION, ");
			sb.Append(" A.PORT_DEPARTURE,n.PORT_NAMECN as port_departure_name,A.ARRIVECOUNTRY,e.COUNTRY_NAMECN as COUNTRY_NAMECN,");
			sb.Append(" A.DESTPORT,i.PORT_NAMECN as destport_name,A.PORT_TRANSPORT,f.PORT_NAMECN as port_transport_name,");
			sb.Append(" A.TRANSTYPE,A.BILLLOADING,A.FREIGHT_TUN,A.FREIGHT_RATE,A.FREIGHT_AMOUNT,");
			sb.Append(" A.FREIGHT_PAYDATE,A.ITEM_AMOUNT,A.LOADINGDATE,A.FREIGHT_PAYTYPE,L.PAYMODE_NAME_CN as pay_term_name,");
			sb.Append(" A.ALLOWBATCH,A.ALLOWTRANSPORT,A.SHIPPER_ID,a.loadingterm,");
			sb.Append(" A.SHIPPER,A.CONTACT_ID,A.CONTACT_NAME,A.PRECARRIAGEBY,A.CARRIAGEBY,A.OCEAN_VESSEL,A.CONSIGNEE,A.NOTIFIER,A.Awb_NAME,");
			sb.Append(" A.APPROVEDBY,A.APPROVEDON,A.CREATEBY,A.CREATEON,A.MODIFYBY,A.MODIFYON");
			sb.Append(" FROM SALE_WAYBILL_MASTER A");
			sb.Append(" LEFT JOIN P_STATUS B ON A.STATUS=B.STATUS_ID AND B.STATUS_TYPE=");
			sb.Append("'");
			sb.Append(this._statusType);
			sb.Append("' ");
			sb.Append(" LEFT JOIN P_CURRENCY C ON A.CURRENCY=C.CURRENCY_CODE");
			sb.Append(" left join p_country e on a.arrivecountry=e.COUNTRY_CODE");
			sb.Append(" left join p_port f on a.port_transport=f.PORT_CODE");
			sb.Append(" left join p_transtype h on a.transtype=h.TRANS_CODE");
			sb.Append(" left join p_port i on a.destport=i.PORT_CODE");
			sb.Append(" left join p_PAYMODE l on a.FREIGHT_PAYTYPE=l.PAYMODE_ID");
			sb.Append(" left join p_port n on a.port_departure=n.PORT_CODE");
			sb.Append(" left join p_tradechar o on a.loadingterm=o.TRADE_ID");
			sb.Append(" where a.AWB_CODE in ");
			sb.Append(" (");
			sb.Append(awblist);
			sb.Append(")");
			sb.Append(" order by a.AWB_CODE");
			this.InitialGrid(sb.ToString());

			priToolBar1.setCurrentForm = this;
			
			_PK = "AWB_CODE";
			_table = "SALE_WAYBILL_MASTER";
			priToolBar1.Initial(_table,_PK,sb.ToString());
			priToolBar1.BeforeButtonClickEvent += new TJSystem.UC.PriToolBar.BeforeButotnClick(this.BeforeButtonClick);
			priToolBar1.AfterButtonClickEvent += new TJSystem.UC.PriToolBar.AfterButtonClick(this.AfterButtonClick);

			this.priToolBar1.setButtonVisibleFalse();;
			this.priToolBar1.setButtonVisible("012345689");

			setDisable();

			this.Cursor = System.Windows.Forms.Cursors.Default;
			//
			// TODO: 在 InitializeComponent 调用后添加任何构造函数代码
			//
		}

		private void InitialFormData()
		{
			DataRow dr = null;
			DataTable dt = null;
			DataTable dtcpy = null;
			string sql = null;

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
		
			sql = "SELECT FORWARDER_ID,FORWARDER_ID+' '+FORWARDER_NAME AS FORWARDER_NAME FROM BASIC_FORWARDER ORDER BY FORWARDER_ID";
			dt = TJSystem.Public.PublicStatic.db.GetDataTable(sql);
			dr = dt.NewRow() ;
			dr[0] = "" ;
			dr[1] = "" ;
			dt.Rows.InsertAt(dr,0) ;
			dtcpy = dt.Copy();
			this.priComboBox2.DataSource = dtcpy.DefaultView;
			this.priComboBox2.ValueMember = "FORWARDER_ID";
			this.priComboBox2.DisplayMember = "FORWARDER_NAME";

			sql = "select PAYMODE_ID,PAYMODE_ID+' '+PAYMODE_NAME_CN as PAYMODE_NAME from p_paymode order by PAYMODE_ID";
			dt = TJSystem.Public.PublicStatic.db.GetDataTable(sql);
			dr = dt.NewRow() ;
			dr[0] = "" ;
			dr[1] = "" ;
			dt.Rows.InsertAt(dr,0) ;
			dtcpy = dt.Copy();
			this.priComboBox3.DataSource = dtcpy.DefaultView;
			this.priComboBox3.ValueMember = "PAYMODE_ID";
			this.priComboBox3.DisplayMember = "PAYMODE_NAME";

			sql = "select COUNTRY_CODE,COUNTRY_CODE+' '+COUNTRY_NAMECN as COUNTRY_NAMECN from p_country order by COUNTRY_CODE ";
			dt = TJSystem.Public.PublicStatic.db.GetDataTable(sql);
			dr = dt.NewRow() ;
			dr[0] = "" ;
			dr[1] = "" ;
			dt.Rows.InsertAt(dr,0) ;
			dtcpy = dt.Copy();
			this.priComboBox4.DataSource = dtcpy.DefaultView;
			this.priComboBox4.ValueMember = "COUNTRY_CODE";
			this.priComboBox4.DisplayMember = "COUNTRY_NAMECN";

			sql = "select PORT_CODE,PORT_CODE+' '+PORT_NAMECN as PORT_NAMECN from p_port order by PORT_CODE ";
			dt = TJSystem.Public.PublicStatic.db.GetDataTable(sql);
			dr = dt.NewRow() ;
			dr[0] = "" ;
			dr[1] = "" ;
			dt.Rows.InsertAt(dr,0) ;
			dtcpy = dt.Copy();
			this.priComboBox5.DataSource = dtcpy.DefaultView;
			this.priComboBox5.ValueMember = "PORT_CODE";
			this.priComboBox5.DisplayMember = "PORT_NAMECN";
			
			sql = "select TRADE_DESC as TRADE_DESC from p_tradechar order by trade_id ";
			dt = TJSystem.Public.PublicStatic.db.GetDataTable(sql);
			dr = dt.NewRow() ;
			dr[0] = "" ;
			dt.Rows.InsertAt(dr,0) ;
			dtcpy = dt.Copy();
			this.priComboBox6.DataSource = dtcpy.DefaultView;
			this.priComboBox6.ValueMember = "TRADE_DESC";
			this.priComboBox6.DisplayMember = "TRADE_DESC";

			sql = "select TRANS_CODE,TRANS_CODE+' '+TRANS_NAMECN as TRANS_NAMECN from p_transtype order by TRANS_CODE ";
			dt = TJSystem.Public.PublicStatic.db.GetDataTable(sql);
			dr = dt.NewRow() ;
			dr[0] = "" ;
			dr[1] = "" ;
			dt.Rows.InsertAt(dr,0) ;
			dtcpy = dt.Copy();
			this.priComboBox7.DataSource = dtcpy.DefaultView;
			this.priComboBox7.ValueMember = "TRANS_CODE";
			this.priComboBox7.DisplayMember = "TRANS_NAMECN";

			sql = "select PORT_CODE,PORT_CODE+' '+PORT_NAMECN as PORT_NAMECN from p_port order by PORT_CODE ";
			dt = TJSystem.Public.PublicStatic.db.GetDataTable(sql);
			dr = dt.NewRow() ;
			dr[0] = "" ;
			dr[1] = "" ;
			dt.Rows.InsertAt(dr,0) ;
			dtcpy = dt.Copy();
			this.priComboBox8.DataSource = dtcpy.DefaultView;
			this.priComboBox8.ValueMember = "PORT_CODE";
			this.priComboBox8.DisplayMember = "PORT_NAMECN";

			sql = "SELECT CONTACT_ID,CONTACT_ID+' '+CONTACT_NAME AS CONTACT_NAME FROM BASIC_FORWARDER_CONTACT ORDER BY CONTACT_ID";
			dt = TJSystem.Public.PublicStatic.db.GetDataTable(sql);
			dr = dt.NewRow() ;
			dr[0] = "" ;
			dr[1] = "" ;
			dt.Rows.InsertAt(dr,0) ;
			dtcpy = dt.Copy();
			this.priComboBox9.DataSource = dtcpy.DefaultView;
			this.priComboBox9.ValueMember = "CONTACT_ID";
			this.priComboBox9.DisplayMember = "CONTACT_NAME";

			sql = "select CURRENCY_CODE,CURRENCY_CODE+' '+CURRENCY_NAMECN as CURRENCY_NAMECN from p_currency order by CURRENCY_CODE";
			dt = TJSystem.Public.PublicStatic.db.GetDataTable(sql);
			dr = dt.NewRow() ;
			dr[0] = "" ;
			dr[1] = "" ;
			dt.Rows.InsertAt(dr,0) ;
			dtcpy = dt.Copy();
			this.priComboBox12.DataSource = dtcpy.DefaultView;
			this.priComboBox12.ValueMember = "CURRENCY_CODE";
			this.priComboBox12.DisplayMember = "CURRENCY_NAMECN";

			sql = "select PORT_CODE,PORT_CODE+' '+PORT_NAMECN as PORT_NAMECN from p_port order by PORT_CODE ";
			dt = TJSystem.Public.PublicStatic.db.GetDataTable(sql);
			dr = dt.NewRow() ;
			dr[0] = "" ;
			dr[1] = "" ;
			dt.Rows.InsertAt(dr,0) ;
			dtcpy = dt.Copy();
			this.comboBox1.DataSource = dtcpy.DefaultView;
			this.comboBox1.ValueMember = "PORT_CODE";
			this.comboBox1.DisplayMember = "PORT_NAMECN";
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(frmAwbDoc));
			this.panel3 = new System.Windows.Forms.Panel();
			this.priToolBar1 = new TJSystem.UC.PriToolBar();
			this.panel1 = new System.Windows.Forms.Panel();
			this.label1 = new System.Windows.Forms.Label();
			this.panel2 = new System.Windows.Forms.Panel();
			this.panel4 = new System.Windows.Forms.Panel();
			this.priTextBox3 = new TJSystem.Classes.PriTextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.label47 = new System.Windows.Forms.Label();
			this.priTextBox37 = new TJSystem.Classes.PriTextBox();
			this.label48 = new System.Windows.Forms.Label();
			this.priTextBox38 = new TJSystem.Classes.PriTextBox();
			this.label33 = new System.Windows.Forms.Label();
			this.label29 = new System.Windows.Forms.Label();
			this.label23 = new System.Windows.Forms.Label();
			this.label22 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.priComboBox1 = new TJSystem.Classes.PriComboBox();
			this.label37 = new System.Windows.Forms.Label();
			this.priTextBox29 = new TJSystem.Classes.PriTextBox();
			this.label20 = new System.Windows.Forms.Label();
			this.priTextBox16 = new TJSystem.Classes.PriTextBox();
			this.label36 = new System.Windows.Forms.Label();
			this.label35 = new System.Windows.Forms.Label();
			this.label24 = new System.Windows.Forms.Label();
			this.priTextBox20 = new TJSystem.Classes.PriTextBox();
			this.priTextBox22 = new TJSystem.Classes.PriTextBox();
			this.label28 = new System.Windows.Forms.Label();
			this.label21 = new System.Windows.Forms.Label();
			this.priTextBox17 = new TJSystem.Classes.PriTextBox();
			this.label18 = new System.Windows.Forms.Label();
			this.priTextBox14 = new TJSystem.Classes.PriTextBox();
			this.label16 = new System.Windows.Forms.Label();
			this.label17 = new System.Windows.Forms.Label();
			this.label14 = new System.Windows.Forms.Label();
			this.label13 = new System.Windows.Forms.Label();
			this.priTextBox10 = new TJSystem.Classes.PriTextBox();
			this.label11 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.comboBox1 = new TJSystem.Classes.PriComboBox();
			this.textBox1 = new TJSystem.Classes.PriTextBox();
			this.label34 = new System.Windows.Forms.Label();
			this.priTextBox18 = new TJSystem.Classes.PriTextBox();
			this.label38 = new System.Windows.Forms.Label();
			this.label39 = new System.Windows.Forms.Label();
			this.priTextBox26 = new TJSystem.Classes.PriTextBox();
			this.label41 = new System.Windows.Forms.Label();
			this.label42 = new System.Windows.Forms.Label();
			this.priTextBox33 = new TJSystem.Classes.PriTextBox();
			this.priTextBox35 = new TJSystem.Classes.PriTextBox();
			this.label45 = new System.Windows.Forms.Label();
			this.priTextBox36 = new TJSystem.Classes.PriTextBox();
			this.label46 = new System.Windows.Forms.Label();
			this.priDateTimePicker3 = new TJSystem.Classes.PriDateTimePicker();
			this.priComboBox3 = new TJSystem.Classes.PriComboBox();
			this.priComboBox4 = new TJSystem.Classes.PriComboBox();
			this.priComboBox5 = new TJSystem.Classes.PriComboBox();
			this.priComboBox7 = new TJSystem.Classes.PriComboBox();
			this.priComboBox8 = new TJSystem.Classes.PriComboBox();
			this.priDateTimePicker4 = new TJSystem.Classes.PriDateTimePicker();
			this.priTextBox1 = new TJSystem.Classes.PriTextBox();
			this.priTextBox2 = new TJSystem.Classes.PriTextBox();
			this.priTextBox6 = new TJSystem.Classes.PriTextBox();
			this.priTextBox7 = new TJSystem.Classes.PriTextBox();
			this.priTextBox8 = new TJSystem.Classes.PriTextBox();
			this.priComboBox12 = new TJSystem.Classes.PriComboBox();
			this.priTextBox4 = new TJSystem.Classes.PriTextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.priComboBox2 = new TJSystem.Classes.PriComboBox();
			this.label15 = new System.Windows.Forms.Label();
			this.priComboBox9 = new TJSystem.Classes.PriComboBox();
			this.priTextBox5 = new TJSystem.Classes.PriTextBox();
			this.priTextBox11 = new TJSystem.Classes.PriTextBox();
			this.label19 = new System.Windows.Forms.Label();
			this.priTextBox12 = new TJSystem.Classes.PriTextBox();
			this.priDateTimePicker1 = new TJSystem.Classes.PriDateTimePicker();
			this.priComboBox6 = new TJSystem.Classes.PriComboBox();
			this.label12 = new System.Windows.Forms.Label();
			this.dataGrid1 = new System.Windows.Forms.DataGrid();
			this.dataGridTableStyle1 = new System.Windows.Forms.DataGridTableStyle();
			this.AWB_CODE = new System.Windows.Forms.DataGridTextBoxColumn();
			this.AWB_DATE = new System.Windows.Forms.DataGridTextBoxColumn();
			this.INVOICE_NO = new System.Windows.Forms.DataGridTextBoxColumn();
			this.lc_code = new System.Windows.Forms.DataGridTextBoxColumn();
			this.COUNTRY_NAMECN = new System.Windows.Forms.DataGridTextBoxColumn();
			this.DESTINATION = new System.Windows.Forms.DataGridTextBoxColumn();
			this.port_departure_name = new System.Windows.Forms.DataGridTextBoxColumn();
			this.destport_name = new System.Windows.Forms.DataGridTextBoxColumn();
			this.port_transport_name = new System.Windows.Forms.DataGridTextBoxColumn();
			this.billloading = new System.Windows.Forms.DataGridTextBoxColumn();
			this.FREIGHT_TUN = new System.Windows.Forms.DataGridTextBoxColumn();
			this.FREIGHT_RATE = new System.Windows.Forms.DataGridTextBoxColumn();
			this.FREIGHT_AMOUNT = new System.Windows.Forms.DataGridTextBoxColumn();
			this.ITEM_AMOUNT = new System.Windows.Forms.DataGridTextBoxColumn();
			this.allowtransport = new System.Windows.Forms.DataGridTextBoxColumn();
			this.allowbatch = new System.Windows.Forms.DataGridTextBoxColumn();
			this.LOADINGDATE = new System.Windows.Forms.DataGridTextBoxColumn();
			this.OCEAN_VESSEL = new System.Windows.Forms.DataGridTextBoxColumn();
			this.STATUS_NAME = new System.Windows.Forms.DataGridTextBoxColumn();
			this.CURRENCY_NAMECN = new System.Windows.Forms.DataGridTextBoxColumn();
			this.shipper = new System.Windows.Forms.DataGridTextBoxColumn();
			this.CONTACT_NAME = new System.Windows.Forms.DataGridTextBoxColumn();
			this.approvedby = new System.Windows.Forms.DataGridTextBoxColumn();
			this.approvedon = new System.Windows.Forms.DataGridTextBoxColumn();
			this.PRECARRIAGEBY = new System.Windows.Forms.DataGridTextBoxColumn();
			this.CARRIAGEBY = new System.Windows.Forms.DataGridTextBoxColumn();
			this.consignee = new System.Windows.Forms.DataGridTextBoxColumn();
			this.notifier = new System.Windows.Forms.DataGridTextBoxColumn();
			this.Awb_NAME = new System.Windows.Forms.DataGridTextBoxColumn();
			this.FREIGHT_PAYDATE = new System.Windows.Forms.DataGridTextBoxColumn();
			this.createby = new System.Windows.Forms.DataGridTextBoxColumn();
			this.createon = new System.Windows.Forms.DataGridTextBoxColumn();
			this.modifyby = new System.Windows.Forms.DataGridTextBoxColumn();
			this.modifyon = new System.Windows.Forms.DataGridTextBoxColumn();
			this.pay_term_name = new System.Windows.Forms.DataGridTextBoxColumn();
			this.button1 = new TJSystem.Classes.XpStyleButton();
			this.xpStyleButton1 = new TJSystem.Classes.XpStyleButton();
			this.xpStyleButton2 = new TJSystem.Classes.XpStyleButton();
			this.panel3.SuspendLayout();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			this.panel4.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).BeginInit();
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
			this.panel3.TabIndex = 6;
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
			this.panel1.TabIndex = 3;
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
			this.label1.Text = "货物托运单";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// panel2
			// 
			this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
			this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.panel2.Controls.Add(this.panel4);
			this.panel2.Controls.Add(this.dataGrid1);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel2.Location = new System.Drawing.Point(0, 0);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(792, 566);
			this.panel2.TabIndex = 5;
			// 
			// panel4
			// 
			this.panel4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel4.BackgroundImage")));
			this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.panel4.Controls.Add(this.xpStyleButton1);
			this.panel4.Controls.Add(this.button1);
			this.panel4.Controls.Add(this.priTextBox3);
			this.panel4.Controls.Add(this.label7);
			this.panel4.Controls.Add(this.label47);
			this.panel4.Controls.Add(this.priTextBox37);
			this.panel4.Controls.Add(this.label48);
			this.panel4.Controls.Add(this.priTextBox38);
			this.panel4.Controls.Add(this.label33);
			this.panel4.Controls.Add(this.label29);
			this.panel4.Controls.Add(this.label23);
			this.panel4.Controls.Add(this.label22);
			this.panel4.Controls.Add(this.label9);
			this.panel4.Controls.Add(this.priComboBox1);
			this.panel4.Controls.Add(this.label37);
			this.panel4.Controls.Add(this.priTextBox29);
			this.panel4.Controls.Add(this.label20);
			this.panel4.Controls.Add(this.priTextBox16);
			this.panel4.Controls.Add(this.label36);
			this.panel4.Controls.Add(this.label35);
			this.panel4.Controls.Add(this.label24);
			this.panel4.Controls.Add(this.priTextBox20);
			this.panel4.Controls.Add(this.priTextBox22);
			this.panel4.Controls.Add(this.label28);
			this.panel4.Controls.Add(this.label21);
			this.panel4.Controls.Add(this.priTextBox17);
			this.panel4.Controls.Add(this.label18);
			this.panel4.Controls.Add(this.priTextBox14);
			this.panel4.Controls.Add(this.label16);
			this.panel4.Controls.Add(this.label17);
			this.panel4.Controls.Add(this.label14);
			this.panel4.Controls.Add(this.label13);
			this.panel4.Controls.Add(this.priTextBox10);
			this.panel4.Controls.Add(this.label11);
			this.panel4.Controls.Add(this.label8);
			this.panel4.Controls.Add(this.label5);
			this.panel4.Controls.Add(this.label3);
			this.panel4.Controls.Add(this.label2);
			this.panel4.Controls.Add(this.comboBox1);
			this.panel4.Controls.Add(this.textBox1);
			this.panel4.Controls.Add(this.label34);
			this.panel4.Controls.Add(this.priTextBox18);
			this.panel4.Controls.Add(this.label38);
			this.panel4.Controls.Add(this.label39);
			this.panel4.Controls.Add(this.priTextBox26);
			this.panel4.Controls.Add(this.label41);
			this.panel4.Controls.Add(this.label42);
			this.panel4.Controls.Add(this.priTextBox33);
			this.panel4.Controls.Add(this.priTextBox35);
			this.panel4.Controls.Add(this.label45);
			this.panel4.Controls.Add(this.priTextBox36);
			this.panel4.Controls.Add(this.label46);
			this.panel4.Controls.Add(this.priDateTimePicker3);
			this.panel4.Controls.Add(this.priComboBox3);
			this.panel4.Controls.Add(this.priComboBox4);
			this.panel4.Controls.Add(this.priComboBox5);
			this.panel4.Controls.Add(this.priComboBox7);
			this.panel4.Controls.Add(this.priComboBox8);
			this.panel4.Controls.Add(this.priDateTimePicker4);
			this.panel4.Controls.Add(this.priTextBox1);
			this.panel4.Controls.Add(this.priTextBox2);
			this.panel4.Controls.Add(this.priTextBox6);
			this.panel4.Controls.Add(this.priTextBox7);
			this.panel4.Controls.Add(this.priTextBox8);
			this.panel4.Controls.Add(this.priComboBox12);
			this.panel4.Controls.Add(this.priTextBox4);
			this.panel4.Controls.Add(this.label6);
			this.panel4.Controls.Add(this.label4);
			this.panel4.Controls.Add(this.label10);
			this.panel4.Controls.Add(this.priComboBox2);
			this.panel4.Controls.Add(this.label15);
			this.panel4.Controls.Add(this.priComboBox9);
			this.panel4.Controls.Add(this.priTextBox5);
			this.panel4.Controls.Add(this.priTextBox11);
			this.panel4.Controls.Add(this.label19);
			this.panel4.Controls.Add(this.priTextBox12);
			this.panel4.Controls.Add(this.priDateTimePicker1);
			this.panel4.Controls.Add(this.priComboBox6);
			this.panel4.Controls.Add(this.label12);
			this.panel4.Controls.Add(this.xpStyleButton2);
			this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel4.Location = new System.Drawing.Point(0, 0);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(788, 448);
			this.panel4.TabIndex = 0;
			// 
			// priTextBox3
			// 
			this.priTextBox3.BackColor = System.Drawing.Color.White;
			this.priTextBox3.DataField = "DESTINATION";
			this.priTextBox3.DataType = TJSystem.Public.DataType.String;
			this.priTextBox3.Enabled = false;
			this.priTextBox3.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.priTextBox3.Location = new System.Drawing.Point(472, 320);
			this.priTextBox3.Multiline = true;
			this.priTextBox3.Name = "priTextBox3";
			this.priTextBox3.Size = new System.Drawing.Size(296, 40);
			this.priTextBox3.TabIndex = 169;
			this.priTextBox3.Text = "";
			// 
			// label7
			// 
			this.label7.BackColor = System.Drawing.Color.Transparent;
			this.label7.Location = new System.Drawing.Point(384, 320);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(80, 23);
			this.label7.TabIndex = 171;
			this.label7.Text = "目的地";
			this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label47
			// 
			this.label47.BackColor = System.Drawing.Color.Transparent;
			this.label47.Location = new System.Drawing.Point(272, 400);
			this.label47.Name = "label47";
			this.label47.Size = new System.Drawing.Size(56, 23);
			this.label47.TabIndex = 172;
			this.label47.Text = "收货人";
			this.label47.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// priTextBox37
			// 
			this.priTextBox37.BackColor = System.Drawing.Color.White;
			this.priTextBox37.DataField = "consignee";
			this.priTextBox37.DataType = TJSystem.Public.DataType.String;
			this.priTextBox37.Enabled = false;
			this.priTextBox37.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.priTextBox37.Location = new System.Drawing.Point(336, 400);
			this.priTextBox37.Multiline = true;
			this.priTextBox37.Name = "priTextBox37";
			this.priTextBox37.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.priTextBox37.Size = new System.Drawing.Size(176, 48);
			this.priTextBox37.TabIndex = 167;
			this.priTextBox37.Text = "";
			// 
			// label48
			// 
			this.label48.BackColor = System.Drawing.Color.Transparent;
			this.label48.Location = new System.Drawing.Point(528, 400);
			this.label48.Name = "label48";
			this.label48.Size = new System.Drawing.Size(56, 23);
			this.label48.TabIndex = 170;
			this.label48.Text = "通知人";
			this.label48.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// priTextBox38
			// 
			this.priTextBox38.BackColor = System.Drawing.Color.White;
			this.priTextBox38.DataField = "notifier";
			this.priTextBox38.DataType = TJSystem.Public.DataType.String;
			this.priTextBox38.Enabled = false;
			this.priTextBox38.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.priTextBox38.Location = new System.Drawing.Point(584, 400);
			this.priTextBox38.Multiline = true;
			this.priTextBox38.Name = "priTextBox38";
			this.priTextBox38.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.priTextBox38.Size = new System.Drawing.Size(184, 48);
			this.priTextBox38.TabIndex = 168;
			this.priTextBox38.Text = "";
			// 
			// label33
			// 
			this.label33.BackColor = System.Drawing.Color.DarkOrange;
			this.label33.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.label33.Location = new System.Drawing.Point(392, 120);
			this.label33.Name = "label33";
			this.label33.Size = new System.Drawing.Size(80, 23);
			this.label33.TabIndex = 165;
			this.label33.Text = "费用";
			this.label33.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label29
			// 
			this.label29.BackColor = System.Drawing.Color.DarkOrange;
			this.label29.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.label29.Location = new System.Drawing.Point(392, 48);
			this.label29.Name = "label29";
			this.label29.Size = new System.Drawing.Size(80, 23);
			this.label29.TabIndex = 164;
			this.label29.Text = "状态";
			this.label29.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label23
			// 
			this.label23.BackColor = System.Drawing.Color.DarkOrange;
			this.label23.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.label23.Location = new System.Drawing.Point(16, 48);
			this.label23.Name = "label23";
			this.label23.Size = new System.Drawing.Size(80, 23);
			this.label23.TabIndex = 163;
			this.label23.Text = "基本信息";
			this.label23.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label22
			// 
			this.label22.BackColor = System.Drawing.Color.DarkOrange;
			this.label22.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.label22.Location = new System.Drawing.Point(16, 144);
			this.label22.Name = "label22";
			this.label22.Size = new System.Drawing.Size(80, 23);
			this.label22.TabIndex = 162;
			this.label22.Text = "运输";
			this.label22.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.BackColor = System.Drawing.Color.Transparent;
			this.label9.ForeColor = System.Drawing.Color.Blue;
			this.label9.Location = new System.Drawing.Point(192, 240);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(63, 19);
			this.label9.TabIndex = 161;
			this.label9.Text = "装运日期";
			this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// priComboBox1
			// 
			this.priComboBox1.BackColor = System.Drawing.Color.White;
			this.priComboBox1.DataField = "status";
			this.priComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.priComboBox1.Location = new System.Drawing.Point(472, 72);
			this.priComboBox1.Name = "priComboBox1";
			this.priComboBox1.Size = new System.Drawing.Size(104, 22);
			this.priComboBox1.TabIndex = 154;
			this.priComboBox1.SelectionChangeCommitted += new System.EventHandler(this.priComboBox1_SelectionChangeCommitted);
			// 
			// label37
			// 
			this.label37.AutoSize = true;
			this.label37.BackColor = System.Drawing.Color.Transparent;
			this.label37.Location = new System.Drawing.Point(192, 120);
			this.label37.Name = "label37";
			this.label37.Size = new System.Drawing.Size(63, 19);
			this.label37.TabIndex = 153;
			this.label37.Text = "允许分批";
			this.label37.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// priTextBox29
			// 
			this.priTextBox29.BackColor = System.Drawing.Color.White;
			this.priTextBox29.DataField = "allowbatch";
			this.priTextBox29.DataType = TJSystem.Public.DataType.String;
			this.priTextBox29.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.priTextBox29.Location = new System.Drawing.Point(264, 120);
			this.priTextBox29.Name = "priTextBox29";
			this.priTextBox29.Size = new System.Drawing.Size(104, 23);
			this.priTextBox29.TabIndex = 152;
			this.priTextBox29.Text = "";
			// 
			// label20
			// 
			this.label20.AutoSize = true;
			this.label20.BackColor = System.Drawing.Color.Transparent;
			this.label20.ForeColor = System.Drawing.Color.Blue;
			this.label20.Location = new System.Drawing.Point(32, 264);
			this.label20.Name = "label20";
			this.label20.Size = new System.Drawing.Size(48, 19);
			this.label20.TabIndex = 151;
			this.label20.Text = "船  名";
			this.label20.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// priTextBox16
			// 
			this.priTextBox16.BackColor = System.Drawing.Color.White;
			this.priTextBox16.DataField = "CARRIAGEBY";
			this.priTextBox16.DataType = TJSystem.Public.DataType.String;
			this.priTextBox16.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.priTextBox16.Location = new System.Drawing.Point(88, 264);
			this.priTextBox16.Name = "priTextBox16";
			this.priTextBox16.Size = new System.Drawing.Size(104, 23);
			this.priTextBox16.TabIndex = 150;
			this.priTextBox16.Text = "";
			// 
			// label36
			// 
			this.label36.AutoSize = true;
			this.label36.BackColor = System.Drawing.Color.Transparent;
			this.label36.ForeColor = System.Drawing.Color.Blue;
			this.label36.Location = new System.Drawing.Point(192, 216);
			this.label36.Name = "label36";
			this.label36.Size = new System.Drawing.Size(63, 19);
			this.label36.TabIndex = 149;
			this.label36.Text = "运输方式";
			this.label36.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label35
			// 
			this.label35.AutoSize = true;
			this.label35.BackColor = System.Drawing.Color.Transparent;
			this.label35.ForeColor = System.Drawing.Color.Blue;
			this.label35.Location = new System.Drawing.Point(208, 192);
			this.label35.Name = "label35";
			this.label35.Size = new System.Drawing.Size(48, 19);
			this.label35.TabIndex = 147;
			this.label35.Text = "转运港";
			this.label35.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label24
			// 
			this.label24.BackColor = System.Drawing.Color.Transparent;
			this.label24.Location = new System.Drawing.Point(16, 216);
			this.label24.Name = "label24";
			this.label24.Size = new System.Drawing.Size(64, 23);
			this.label24.TabIndex = 124;
			this.label24.Text = "提单号";
			this.label24.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// priTextBox20
			// 
			this.priTextBox20.BackColor = System.Drawing.Color.White;
			this.priTextBox20.DataField = "billloading";
			this.priTextBox20.DataType = TJSystem.Public.DataType.String;
			this.priTextBox20.Enabled = false;
			this.priTextBox20.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.priTextBox20.Location = new System.Drawing.Point(88, 216);
			this.priTextBox20.Name = "priTextBox20";
			this.priTextBox20.Size = new System.Drawing.Size(104, 23);
			this.priTextBox20.TabIndex = 123;
			this.priTextBox20.Text = "";
			// 
			// priTextBox22
			// 
			this.priTextBox22.BackColor = System.Drawing.Color.White;
			this.priTextBox22.DataField = "OCEAN_VESSEL";
			this.priTextBox22.DataType = TJSystem.Public.DataType.String;
			this.priTextBox22.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.priTextBox22.Location = new System.Drawing.Point(24, 312);
			this.priTextBox22.Multiline = true;
			this.priTextBox22.Name = "priTextBox22";
			this.priTextBox22.Size = new System.Drawing.Size(344, 80);
			this.priTextBox22.TabIndex = 125;
			this.priTextBox22.Text = "";
			// 
			// label28
			// 
			this.label28.AutoSize = true;
			this.label28.BackColor = System.Drawing.Color.Transparent;
			this.label28.Location = new System.Drawing.Point(24, 288);
			this.label28.Name = "label28";
			this.label28.Size = new System.Drawing.Size(92, 19);
			this.label28.TabIndex = 118;
			this.label28.Text = "外轮注意事项";
			this.label28.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label21
			// 
			this.label21.AutoSize = true;
			this.label21.BackColor = System.Drawing.Color.Transparent;
			this.label21.Location = new System.Drawing.Point(584, 96);
			this.label21.Name = "label21";
			this.label21.Size = new System.Drawing.Size(63, 19);
			this.label21.TabIndex = 41;
			this.label21.Text = "审核日期";
			this.label21.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// priTextBox17
			// 
			this.priTextBox17.BackColor = System.Drawing.Color.White;
			this.priTextBox17.DataField = "approvedon";
			this.priTextBox17.DataType = TJSystem.Public.DataType.String;
			this.priTextBox17.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.priTextBox17.Location = new System.Drawing.Point(656, 96);
			this.priTextBox17.Name = "priTextBox17";
			this.priTextBox17.Size = new System.Drawing.Size(112, 23);
			this.priTextBox17.TabIndex = 40;
			this.priTextBox17.Text = "";
			// 
			// label18
			// 
			this.label18.BackColor = System.Drawing.Color.Transparent;
			this.label18.Location = new System.Drawing.Point(384, 96);
			this.label18.Name = "label18";
			this.label18.Size = new System.Drawing.Size(80, 23);
			this.label18.TabIndex = 35;
			this.label18.Text = "审核者";
			this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// priTextBox14
			// 
			this.priTextBox14.BackColor = System.Drawing.Color.White;
			this.priTextBox14.DataField = "approvedby";
			this.priTextBox14.DataType = TJSystem.Public.DataType.String;
			this.priTextBox14.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.priTextBox14.Location = new System.Drawing.Point(472, 96);
			this.priTextBox14.Name = "priTextBox14";
			this.priTextBox14.Size = new System.Drawing.Size(104, 23);
			this.priTextBox14.TabIndex = 34;
			this.priTextBox14.Text = "";
			// 
			// label16
			// 
			this.label16.BackColor = System.Drawing.Color.Transparent;
			this.label16.ForeColor = System.Drawing.Color.Blue;
			this.label16.Location = new System.Drawing.Point(400, 72);
			this.label16.Name = "label16";
			this.label16.Size = new System.Drawing.Size(64, 23);
			this.label16.TabIndex = 33;
			this.label16.Text = "状态";
			this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label17
			// 
			this.label17.AutoSize = true;
			this.label17.BackColor = System.Drawing.Color.Transparent;
			this.label17.ForeColor = System.Drawing.Color.Blue;
			this.label17.Location = new System.Drawing.Point(208, 168);
			this.label17.Name = "label17";
			this.label17.Size = new System.Drawing.Size(48, 19);
			this.label17.TabIndex = 31;
			this.label17.Text = "运抵国";
			this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label14
			// 
			this.label14.BackColor = System.Drawing.Color.Transparent;
			this.label14.ForeColor = System.Drawing.Color.Blue;
			this.label14.Location = new System.Drawing.Point(192, 72);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(64, 23);
			this.label14.TabIndex = 27;
			this.label14.Text = "发票日期";
			this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label13
			// 
			this.label13.BackColor = System.Drawing.Color.Transparent;
			this.label13.Location = new System.Drawing.Point(0, 240);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(80, 23);
			this.label13.TabIndex = 26;
			this.label13.Text = "一程船名";
			this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// priTextBox10
			// 
			this.priTextBox10.BackColor = System.Drawing.Color.White;
			this.priTextBox10.DataField = "PRECARRIAGEBY";
			this.priTextBox10.DataType = TJSystem.Public.DataType.String;
			this.priTextBox10.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.priTextBox10.Location = new System.Drawing.Point(88, 240);
			this.priTextBox10.Name = "priTextBox10";
			this.priTextBox10.Size = new System.Drawing.Size(104, 23);
			this.priTextBox10.TabIndex = 25;
			this.priTextBox10.Text = "";
			// 
			// label11
			// 
			this.label11.BackColor = System.Drawing.Color.Transparent;
			this.label11.ForeColor = System.Drawing.Color.Blue;
			this.label11.Location = new System.Drawing.Point(24, 192);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(56, 23);
			this.label11.TabIndex = 22;
			this.label11.Text = "目的港";
			this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.BackColor = System.Drawing.Color.Transparent;
			this.label8.Location = new System.Drawing.Point(16, 120);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(63, 19);
			this.label8.TabIndex = 15;
			this.label8.Text = "允许转运";
			this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label5
			// 
			this.label5.BackColor = System.Drawing.Color.Transparent;
			this.label5.ForeColor = System.Drawing.Color.Blue;
			this.label5.Location = new System.Drawing.Point(16, 168);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(64, 23);
			this.label5.TabIndex = 9;
			this.label5.Text = "起运港";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label3
			// 
			this.label3.BackColor = System.Drawing.Color.Transparent;
			this.label3.ForeColor = System.Drawing.Color.Blue;
			this.label3.Location = new System.Drawing.Point(400, 152);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(64, 23);
			this.label3.TabIndex = 7;
			this.label3.Text = "结汇方式";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label2
			// 
			this.label2.BackColor = System.Drawing.Color.Transparent;
			this.label2.ForeColor = System.Drawing.Color.Blue;
			this.label2.Location = new System.Drawing.Point(16, 72);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(64, 23);
			this.label2.TabIndex = 6;
			this.label2.Text = "托运单号";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// comboBox1
			// 
			this.comboBox1.BackColor = System.Drawing.Color.White;
			this.comboBox1.DataField = "port_departure";
			this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBox1.Location = new System.Drawing.Point(88, 168);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(104, 22);
			this.comboBox1.TabIndex = 4;
			// 
			// textBox1
			// 
			this.textBox1.BackColor = System.Drawing.Color.White;
			this.textBox1.DataField = "AWB_CODE";
			this.textBox1.DataType = TJSystem.Public.DataType.String;
			this.textBox1.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.textBox1.Location = new System.Drawing.Point(88, 72);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(104, 23);
			this.textBox1.TabIndex = 1;
			this.textBox1.Text = "";
			// 
			// label34
			// 
			this.label34.BackColor = System.Drawing.Color.Transparent;
			this.label34.Location = new System.Drawing.Point(192, 96);
			this.label34.Name = "label34";
			this.label34.Size = new System.Drawing.Size(64, 23);
			this.label34.TabIndex = 35;
			this.label34.Text = "信用证号";
			this.label34.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// priTextBox18
			// 
			this.priTextBox18.BackColor = System.Drawing.Color.White;
			this.priTextBox18.DataField = "lc_code";
			this.priTextBox18.DataType = TJSystem.Public.DataType.String;
			this.priTextBox18.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.priTextBox18.Location = new System.Drawing.Point(264, 96);
			this.priTextBox18.Name = "priTextBox18";
			this.priTextBox18.Size = new System.Drawing.Size(104, 23);
			this.priTextBox18.TabIndex = 34;
			this.priTextBox18.Text = "";
			// 
			// label38
			// 
			this.label38.AutoSize = true;
			this.label38.BackColor = System.Drawing.Color.Transparent;
			this.label38.ForeColor = System.Drawing.Color.Blue;
			this.label38.Location = new System.Drawing.Point(416, 176);
			this.label38.Name = "label38";
			this.label38.Size = new System.Drawing.Size(48, 19);
			this.label38.TabIndex = 41;
			this.label38.Text = "币  种";
			this.label38.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label39
			// 
			this.label39.BackColor = System.Drawing.Color.Transparent;
			this.label39.Location = new System.Drawing.Point(600, 200);
			this.label39.Name = "label39";
			this.label39.Size = new System.Drawing.Size(48, 23);
			this.label39.TabIndex = 119;
			this.label39.Text = "运费率";
			this.label39.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// priTextBox26
			// 
			this.priTextBox26.BackColor = System.Drawing.Color.White;
			this.priTextBox26.DataField = "FREIGHT_RATE";
			this.priTextBox26.DataType = TJSystem.Public.DataType.String;
			this.priTextBox26.Enabled = false;
			this.priTextBox26.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.priTextBox26.Location = new System.Drawing.Point(656, 200);
			this.priTextBox26.Name = "priTextBox26";
			this.priTextBox26.Size = new System.Drawing.Size(112, 23);
			this.priTextBox26.TabIndex = 117;
			this.priTextBox26.Text = "";
			// 
			// label41
			// 
			this.label41.AutoSize = true;
			this.label41.BackColor = System.Drawing.Color.Transparent;
			this.label41.Location = new System.Drawing.Point(584, 224);
			this.label41.Name = "label41";
			this.label41.Size = new System.Drawing.Size(63, 19);
			this.label41.TabIndex = 41;
			this.label41.Text = "付款期限";
			this.label41.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label42
			// 
			this.label42.BackColor = System.Drawing.Color.Transparent;
			this.label42.Location = new System.Drawing.Point(592, 176);
			this.label42.Name = "label42";
			this.label42.Size = new System.Drawing.Size(56, 23);
			this.label42.TabIndex = 35;
			this.label42.Text = "运费吨";
			this.label42.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// priTextBox33
			// 
			this.priTextBox33.BackColor = System.Drawing.Color.White;
			this.priTextBox33.DataField = "FREIGHT_TUN";
			this.priTextBox33.DataType = TJSystem.Public.DataType.String;
			this.priTextBox33.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.priTextBox33.Location = new System.Drawing.Point(656, 176);
			this.priTextBox33.Name = "priTextBox33";
			this.priTextBox33.Size = new System.Drawing.Size(112, 23);
			this.priTextBox33.TabIndex = 34;
			this.priTextBox33.Text = "";
			// 
			// priTextBox35
			// 
			this.priTextBox35.BackColor = System.Drawing.Color.White;
			this.priTextBox35.DataField = "ITEM_AMOUNT";
			this.priTextBox35.DataType = TJSystem.Public.DataType.String;
			this.priTextBox35.Enabled = false;
			this.priTextBox35.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.priTextBox35.Location = new System.Drawing.Point(472, 224);
			this.priTextBox35.Name = "priTextBox35";
			this.priTextBox35.Size = new System.Drawing.Size(112, 23);
			this.priTextBox35.TabIndex = 117;
			this.priTextBox35.Text = "";
			// 
			// label45
			// 
			this.label45.BackColor = System.Drawing.Color.Transparent;
			this.label45.Location = new System.Drawing.Point(384, 224);
			this.label45.Name = "label45";
			this.label45.Size = new System.Drawing.Size(72, 23);
			this.label45.TabIndex = 119;
			this.label45.Text = "货品总值";
			this.label45.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// priTextBox36
			// 
			this.priTextBox36.BackColor = System.Drawing.Color.White;
			this.priTextBox36.DataField = "FREIGHT_AMOUNT";
			this.priTextBox36.DataType = TJSystem.Public.DataType.String;
			this.priTextBox36.Enabled = false;
			this.priTextBox36.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.priTextBox36.Location = new System.Drawing.Point(472, 200);
			this.priTextBox36.Name = "priTextBox36";
			this.priTextBox36.Size = new System.Drawing.Size(112, 23);
			this.priTextBox36.TabIndex = 117;
			this.priTextBox36.Text = "";
			// 
			// label46
			// 
			this.label46.BackColor = System.Drawing.Color.Transparent;
			this.label46.Location = new System.Drawing.Point(392, 200);
			this.label46.Name = "label46";
			this.label46.Size = new System.Drawing.Size(64, 23);
			this.label46.TabIndex = 119;
			this.label46.Text = "运费总额";
			this.label46.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// priDateTimePicker3
			// 
			this.priDateTimePicker3.CustomFormat = "yyyy-MM-dd";
			this.priDateTimePicker3.DataField = "AWB_DATE";
			this.priDateTimePicker3.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.priDateTimePicker3.Location = new System.Drawing.Point(264, 72);
			this.priDateTimePicker3.Name = "priDateTimePicker3";
			this.priDateTimePicker3.Size = new System.Drawing.Size(104, 23);
			this.priDateTimePicker3.TabIndex = 166;
			// 
			// priComboBox3
			// 
			this.priComboBox3.BackColor = System.Drawing.Color.White;
			this.priComboBox3.DataField = "FREIGHT_PAYTYPE";
			this.priComboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.priComboBox3.Location = new System.Drawing.Point(472, 152);
			this.priComboBox3.Name = "priComboBox3";
			this.priComboBox3.Size = new System.Drawing.Size(112, 22);
			this.priComboBox3.TabIndex = 154;
			// 
			// priComboBox4
			// 
			this.priComboBox4.BackColor = System.Drawing.Color.White;
			this.priComboBox4.DataField = "arrivecountry";
			this.priComboBox4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.priComboBox4.Location = new System.Drawing.Point(264, 168);
			this.priComboBox4.Name = "priComboBox4";
			this.priComboBox4.Size = new System.Drawing.Size(104, 22);
			this.priComboBox4.TabIndex = 154;
			// 
			// priComboBox5
			// 
			this.priComboBox5.BackColor = System.Drawing.Color.White;
			this.priComboBox5.DataField = "port_transport";
			this.priComboBox5.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.priComboBox5.Location = new System.Drawing.Point(264, 192);
			this.priComboBox5.Name = "priComboBox5";
			this.priComboBox5.Size = new System.Drawing.Size(104, 22);
			this.priComboBox5.TabIndex = 154;
			// 
			// priComboBox7
			// 
			this.priComboBox7.BackColor = System.Drawing.Color.White;
			this.priComboBox7.DataField = "transtype";
			this.priComboBox7.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.priComboBox7.Location = new System.Drawing.Point(264, 216);
			this.priComboBox7.Name = "priComboBox7";
			this.priComboBox7.Size = new System.Drawing.Size(104, 22);
			this.priComboBox7.TabIndex = 154;
			// 
			// priComboBox8
			// 
			this.priComboBox8.BackColor = System.Drawing.Color.White;
			this.priComboBox8.DataField = "destport";
			this.priComboBox8.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.priComboBox8.Location = new System.Drawing.Point(88, 192);
			this.priComboBox8.Name = "priComboBox8";
			this.priComboBox8.Size = new System.Drawing.Size(104, 22);
			this.priComboBox8.TabIndex = 154;
			// 
			// priDateTimePicker4
			// 
			this.priDateTimePicker4.CustomFormat = "yyyy-MM-dd";
			this.priDateTimePicker4.DataField = "LOADINGDATE";
			this.priDateTimePicker4.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.priDateTimePicker4.Location = new System.Drawing.Point(264, 240);
			this.priDateTimePicker4.Name = "priDateTimePicker4";
			this.priDateTimePicker4.Size = new System.Drawing.Size(104, 23);
			this.priDateTimePicker4.TabIndex = 166;
			// 
			// priTextBox1
			// 
			this.priTextBox1.BackColor = System.Drawing.Color.White;
			this.priTextBox1.DataField = "allowtransport";
			this.priTextBox1.DataType = TJSystem.Public.DataType.String;
			this.priTextBox1.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.priTextBox1.Location = new System.Drawing.Point(88, 120);
			this.priTextBox1.Name = "priTextBox1";
			this.priTextBox1.Size = new System.Drawing.Size(104, 23);
			this.priTextBox1.TabIndex = 25;
			this.priTextBox1.Text = "";
			// 
			// priTextBox2
			// 
			this.priTextBox2.BackColor = System.Drawing.Color.White;
			this.priTextBox2.DataField = "createby";
			this.priTextBox2.DataType = TJSystem.Public.DataType.String;
			this.priTextBox2.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.priTextBox2.Location = new System.Drawing.Point(360, 480);
			this.priTextBox2.Name = "priTextBox2";
			this.priTextBox2.Size = new System.Drawing.Size(48, 23);
			this.priTextBox2.TabIndex = 34;
			this.priTextBox2.Text = "";
			// 
			// priTextBox6
			// 
			this.priTextBox6.BackColor = System.Drawing.Color.White;
			this.priTextBox6.DataField = "createon";
			this.priTextBox6.DataType = TJSystem.Public.DataType.String;
			this.priTextBox6.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.priTextBox6.Location = new System.Drawing.Point(408, 480);
			this.priTextBox6.Name = "priTextBox6";
			this.priTextBox6.Size = new System.Drawing.Size(32, 23);
			this.priTextBox6.TabIndex = 34;
			this.priTextBox6.Text = "";
			// 
			// priTextBox7
			// 
			this.priTextBox7.BackColor = System.Drawing.Color.White;
			this.priTextBox7.DataField = "modifyby";
			this.priTextBox7.DataType = TJSystem.Public.DataType.String;
			this.priTextBox7.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.priTextBox7.Location = new System.Drawing.Point(440, 480);
			this.priTextBox7.Name = "priTextBox7";
			this.priTextBox7.Size = new System.Drawing.Size(32, 23);
			this.priTextBox7.TabIndex = 34;
			this.priTextBox7.Text = "";
			// 
			// priTextBox8
			// 
			this.priTextBox8.BackColor = System.Drawing.Color.White;
			this.priTextBox8.DataField = "modifyon";
			this.priTextBox8.DataType = TJSystem.Public.DataType.String;
			this.priTextBox8.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.priTextBox8.Location = new System.Drawing.Point(472, 480);
			this.priTextBox8.Name = "priTextBox8";
			this.priTextBox8.Size = new System.Drawing.Size(32, 23);
			this.priTextBox8.TabIndex = 34;
			this.priTextBox8.Text = "";
			// 
			// priComboBox12
			// 
			this.priComboBox12.BackColor = System.Drawing.Color.White;
			this.priComboBox12.DataField = "currency";
			this.priComboBox12.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.priComboBox12.Location = new System.Drawing.Point(472, 176);
			this.priComboBox12.Name = "priComboBox12";
			this.priComboBox12.Size = new System.Drawing.Size(112, 22);
			this.priComboBox12.TabIndex = 154;
			// 
			// priTextBox4
			// 
			this.priTextBox4.BackColor = System.Drawing.Color.White;
			this.priTextBox4.Cursor = System.Windows.Forms.Cursors.Default;
			this.priTextBox4.DataField = "INVOICE_NO";
			this.priTextBox4.DataType = TJSystem.Public.DataType.String;
			this.priTextBox4.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.priTextBox4.Location = new System.Drawing.Point(88, 96);
			this.priTextBox4.Name = "priTextBox4";
			this.priTextBox4.Size = new System.Drawing.Size(104, 23);
			this.priTextBox4.TabIndex = 1;
			this.priTextBox4.Text = "";
			// 
			// label6
			// 
			this.label6.BackColor = System.Drawing.Color.Transparent;
			this.label6.ForeColor = System.Drawing.Color.Blue;
			this.label6.Location = new System.Drawing.Point(16, 96);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(64, 23);
			this.label6.TabIndex = 6;
			this.label6.Text = "发票号";
			this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label4
			// 
			this.label4.BackColor = System.Drawing.Color.DarkOrange;
			this.label4.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.label4.Location = new System.Drawing.Point(392, 248);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(80, 23);
			this.label4.TabIndex = 165;
			this.label4.Text = "托运";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.BackColor = System.Drawing.Color.Transparent;
			this.label10.ForeColor = System.Drawing.Color.Blue;
			this.label10.Location = new System.Drawing.Point(416, 272);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(48, 19);
			this.label10.TabIndex = 41;
			this.label10.Text = "运输商";
			this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// priComboBox2
			// 
			this.priComboBox2.BackColor = System.Drawing.Color.White;
			this.priComboBox2.DataField = "SHIPPER_ID";
			this.priComboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.priComboBox2.Location = new System.Drawing.Point(472, 272);
			this.priComboBox2.Name = "priComboBox2";
			this.priComboBox2.Size = new System.Drawing.Size(112, 22);
			this.priComboBox2.TabIndex = 154;
			this.priComboBox2.SelectionChangeCommitted += new System.EventHandler(this.priComboBox2_SelectionChangeCommitted);
			// 
			// label15
			// 
			this.label15.AutoSize = true;
			this.label15.BackColor = System.Drawing.Color.Transparent;
			this.label15.ForeColor = System.Drawing.Color.Blue;
			this.label15.Location = new System.Drawing.Point(416, 296);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(48, 19);
			this.label15.TabIndex = 41;
			this.label15.Text = "联系人";
			this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// priComboBox9
			// 
			this.priComboBox9.BackColor = System.Drawing.Color.White;
			this.priComboBox9.DataField = "CONTACT_ID";
			this.priComboBox9.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.priComboBox9.Location = new System.Drawing.Point(472, 296);
			this.priComboBox9.Name = "priComboBox9";
			this.priComboBox9.Size = new System.Drawing.Size(112, 22);
			this.priComboBox9.TabIndex = 154;
			this.priComboBox9.SelectionChangeCommitted += new System.EventHandler(this.priComboBox9_SelectionChangeCommitted);
			// 
			// priTextBox5
			// 
			this.priTextBox5.BackColor = System.Drawing.Color.White;
			this.priTextBox5.DataField = "SHIPPER";
			this.priTextBox5.DataType = TJSystem.Public.DataType.String;
			this.priTextBox5.Enabled = false;
			this.priTextBox5.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.priTextBox5.Location = new System.Drawing.Point(592, 272);
			this.priTextBox5.Name = "priTextBox5";
			this.priTextBox5.Size = new System.Drawing.Size(176, 23);
			this.priTextBox5.TabIndex = 169;
			this.priTextBox5.Text = "";
			// 
			// priTextBox11
			// 
			this.priTextBox11.BackColor = System.Drawing.Color.White;
			this.priTextBox11.DataField = "CONTACT_NAME";
			this.priTextBox11.DataType = TJSystem.Public.DataType.String;
			this.priTextBox11.Enabled = false;
			this.priTextBox11.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.priTextBox11.Location = new System.Drawing.Point(592, 296);
			this.priTextBox11.Name = "priTextBox11";
			this.priTextBox11.Size = new System.Drawing.Size(176, 23);
			this.priTextBox11.TabIndex = 169;
			this.priTextBox11.Text = "";
			// 
			// label19
			// 
			this.label19.BackColor = System.Drawing.Color.Transparent;
			this.label19.Location = new System.Drawing.Point(24, 400);
			this.label19.Name = "label19";
			this.label19.Size = new System.Drawing.Size(48, 23);
			this.label19.TabIndex = 170;
			this.label19.Text = "托运人";
			this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// priTextBox12
			// 
			this.priTextBox12.BackColor = System.Drawing.Color.White;
			this.priTextBox12.DataField = "Awb_NAME";
			this.priTextBox12.DataType = TJSystem.Public.DataType.String;
			this.priTextBox12.Enabled = false;
			this.priTextBox12.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.priTextBox12.Location = new System.Drawing.Point(80, 400);
			this.priTextBox12.Multiline = true;
			this.priTextBox12.Name = "priTextBox12";
			this.priTextBox12.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.priTextBox12.Size = new System.Drawing.Size(176, 48);
			this.priTextBox12.TabIndex = 168;
			this.priTextBox12.Text = "";
			// 
			// priDateTimePicker1
			// 
			this.priDateTimePicker1.CustomFormat = "yyyy-MM-dd";
			this.priDateTimePicker1.DataField = "FREIGHT_PAYDATE";
			this.priDateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.priDateTimePicker1.Location = new System.Drawing.Point(656, 224);
			this.priDateTimePicker1.Name = "priDateTimePicker1";
			this.priDateTimePicker1.Size = new System.Drawing.Size(112, 23);
			this.priDateTimePicker1.TabIndex = 166;
			// 
			// priComboBox6
			// 
			this.priComboBox6.BackColor = System.Drawing.Color.White;
			this.priComboBox6.DataField = "loadingterm";
			this.priComboBox6.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.priComboBox6.Location = new System.Drawing.Point(656, 152);
			this.priComboBox6.Name = "priComboBox6";
			this.priComboBox6.Size = new System.Drawing.Size(112, 22);
			this.priComboBox6.TabIndex = 154;
			// 
			// label12
			// 
			this.label12.BackColor = System.Drawing.Color.Transparent;
			this.label12.ForeColor = System.Drawing.Color.Blue;
			this.label12.Location = new System.Drawing.Point(584, 152);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(64, 23);
			this.label12.TabIndex = 7;
			this.label12.Text = "贸易性质";
			this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// dataGrid1
			// 
			this.dataGrid1.AllowSorting = false;
			this.dataGrid1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.dataGrid1.BackgroundColor = System.Drawing.SystemColors.Window;
			this.dataGrid1.CaptionText = "单证管理";
			this.dataGrid1.CaptionVisible = false;
			this.dataGrid1.DataMember = "";
			this.dataGrid1.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.dataGrid1.Location = new System.Drawing.Point(0, 456);
			this.dataGrid1.Name = "dataGrid1";
			this.dataGrid1.ReadOnly = true;
			this.dataGrid1.Size = new System.Drawing.Size(784, 64);
			this.dataGrid1.TabIndex = 0;
			this.dataGrid1.TableStyles.AddRange(new System.Windows.Forms.DataGridTableStyle[] {
																								  this.dataGridTableStyle1});
			// 
			// dataGridTableStyle1
			// 
			this.dataGridTableStyle1.AllowSorting = false;
			this.dataGridTableStyle1.DataGrid = this.dataGrid1;
			this.dataGridTableStyle1.GridColumnStyles.AddRange(new System.Windows.Forms.DataGridColumnStyle[] {
																												  this.AWB_CODE,
																												  this.AWB_DATE,
																												  this.INVOICE_NO,
																												  this.lc_code,
																												  this.COUNTRY_NAMECN,
																												  this.DESTINATION,
																												  this.port_departure_name,
																												  this.destport_name,
																												  this.port_transport_name,
																												  this.billloading,
																												  this.FREIGHT_TUN,
																												  this.FREIGHT_RATE,
																												  this.FREIGHT_AMOUNT,
																												  this.ITEM_AMOUNT,
																												  this.allowtransport,
																												  this.allowbatch,
																												  this.LOADINGDATE,
																												  this.OCEAN_VESSEL,
																												  this.STATUS_NAME,
																												  this.CURRENCY_NAMECN,
																												  this.shipper,
																												  this.CONTACT_NAME,
																												  this.approvedby,
																												  this.approvedon,
																												  this.PRECARRIAGEBY,
																												  this.CARRIAGEBY,
																												  this.consignee,
																												  this.notifier,
																												  this.Awb_NAME,
																												  this.FREIGHT_PAYDATE,
																												  this.createby,
																												  this.createon,
																												  this.modifyby,
																												  this.modifyon,
																												  this.pay_term_name});
			this.dataGridTableStyle1.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.dataGridTableStyle1.MappingName = "SALE_WAYBILL_MASTER";
			this.dataGridTableStyle1.ReadOnly = true;
			// 
			// AWB_CODE
			// 
			this.AWB_CODE.Format = "";
			this.AWB_CODE.FormatInfo = null;
			this.AWB_CODE.HeaderText = "托运单号";
			this.AWB_CODE.MappingName = "AWB_CODE";
			this.AWB_CODE.NullText = "";
			this.AWB_CODE.Width = 75;
			// 
			// AWB_DATE
			// 
			this.AWB_DATE.Format = "";
			this.AWB_DATE.FormatInfo = null;
			this.AWB_DATE.HeaderText = "托运日期";
			this.AWB_DATE.MappingName = "AWB_DATE";
			this.AWB_DATE.NullText = "";
			this.AWB_DATE.Width = 75;
			// 
			// INVOICE_NO
			// 
			this.INVOICE_NO.Format = "";
			this.INVOICE_NO.FormatInfo = null;
			this.INVOICE_NO.HeaderText = "发票号";
			this.INVOICE_NO.MappingName = "INVOICE_NO";
			this.INVOICE_NO.NullText = "";
			this.INVOICE_NO.Width = 75;
			// 
			// lc_code
			// 
			this.lc_code.Format = "";
			this.lc_code.FormatInfo = null;
			this.lc_code.HeaderText = "信用证号";
			this.lc_code.MappingName = "lc_code";
			this.lc_code.NullText = "";
			this.lc_code.Width = 75;
			// 
			// COUNTRY_NAMECN
			// 
			this.COUNTRY_NAMECN.Format = "";
			this.COUNTRY_NAMECN.FormatInfo = null;
			this.COUNTRY_NAMECN.HeaderText = "运抵国";
			this.COUNTRY_NAMECN.MappingName = "COUNTRY_NAMECN";
			this.COUNTRY_NAMECN.NullText = "";
			this.COUNTRY_NAMECN.Width = 75;
			// 
			// DESTINATION
			// 
			this.DESTINATION.Format = "";
			this.DESTINATION.FormatInfo = null;
			this.DESTINATION.HeaderText = "目的地";
			this.DESTINATION.MappingName = "DESTINATION";
			this.DESTINATION.NullText = "";
			this.DESTINATION.Width = 75;
			// 
			// port_departure_name
			// 
			this.port_departure_name.Format = "";
			this.port_departure_name.FormatInfo = null;
			this.port_departure_name.HeaderText = "起运港";
			this.port_departure_name.MappingName = "port_departure_name";
			this.port_departure_name.NullText = "";
			this.port_departure_name.Width = 75;
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
			// port_transport_name
			// 
			this.port_transport_name.Format = "";
			this.port_transport_name.FormatInfo = null;
			this.port_transport_name.HeaderText = "转运港";
			this.port_transport_name.MappingName = "port_transport_name";
			this.port_transport_name.NullText = "";
			this.port_transport_name.Width = 75;
			// 
			// billloading
			// 
			this.billloading.Format = "";
			this.billloading.FormatInfo = null;
			this.billloading.HeaderText = "提单号";
			this.billloading.MappingName = "billloading";
			this.billloading.NullText = "";
			this.billloading.Width = 75;
			// 
			// FREIGHT_TUN
			// 
			this.FREIGHT_TUN.Format = "";
			this.FREIGHT_TUN.FormatInfo = null;
			this.FREIGHT_TUN.HeaderText = "运输工具";
			this.FREIGHT_TUN.MappingName = "FREIGHT_TUN";
			this.FREIGHT_TUN.NullText = "";
			this.FREIGHT_TUN.Width = 75;
			// 
			// FREIGHT_RATE
			// 
			this.FREIGHT_RATE.Format = "";
			this.FREIGHT_RATE.FormatInfo = null;
			this.FREIGHT_RATE.HeaderText = "运费率";
			this.FREIGHT_RATE.MappingName = "FREIGHT_RATE";
			this.FREIGHT_RATE.NullText = "";
			this.FREIGHT_RATE.Width = 75;
			// 
			// FREIGHT_AMOUNT
			// 
			this.FREIGHT_AMOUNT.Format = "";
			this.FREIGHT_AMOUNT.FormatInfo = null;
			this.FREIGHT_AMOUNT.HeaderText = "运费总额";
			this.FREIGHT_AMOUNT.MappingName = "FREIGHT_AMOUNT";
			this.FREIGHT_AMOUNT.NullText = "";
			this.FREIGHT_AMOUNT.Width = 75;
			// 
			// ITEM_AMOUNT
			// 
			this.ITEM_AMOUNT.Format = "";
			this.ITEM_AMOUNT.FormatInfo = null;
			this.ITEM_AMOUNT.HeaderText = "货物总值";
			this.ITEM_AMOUNT.MappingName = "ITEM_AMOUNT";
			this.ITEM_AMOUNT.NullText = "";
			this.ITEM_AMOUNT.Width = 75;
			// 
			// allowtransport
			// 
			this.allowtransport.Format = "";
			this.allowtransport.FormatInfo = null;
			this.allowtransport.HeaderText = "允许转运";
			this.allowtransport.MappingName = "allowtransport";
			this.allowtransport.NullText = "";
			this.allowtransport.Width = 75;
			// 
			// allowbatch
			// 
			this.allowbatch.Format = "";
			this.allowbatch.FormatInfo = null;
			this.allowbatch.HeaderText = "允许分批";
			this.allowbatch.MappingName = "allowbatch";
			this.allowbatch.NullText = "";
			this.allowbatch.Width = 75;
			// 
			// LOADINGDATE
			// 
			this.LOADINGDATE.Format = "";
			this.LOADINGDATE.FormatInfo = null;
			this.LOADINGDATE.HeaderText = "装运日期";
			this.LOADINGDATE.MappingName = "LOADINGDATE";
			this.LOADINGDATE.NullText = "";
			this.LOADINGDATE.Width = 75;
			// 
			// OCEAN_VESSEL
			// 
			this.OCEAN_VESSEL.Format = "";
			this.OCEAN_VESSEL.FormatInfo = null;
			this.OCEAN_VESSEL.HeaderText = "外轮注意事项";
			this.OCEAN_VESSEL.MappingName = "OCEAN_VESSEL";
			this.OCEAN_VESSEL.NullText = "";
			this.OCEAN_VESSEL.Width = 75;
			// 
			// STATUS_NAME
			// 
			this.STATUS_NAME.Format = "";
			this.STATUS_NAME.FormatInfo = null;
			this.STATUS_NAME.HeaderText = "状态";
			this.STATUS_NAME.MappingName = "STATUS_NAME";
			this.STATUS_NAME.NullText = "";
			this.STATUS_NAME.Width = 75;
			// 
			// CURRENCY_NAMECN
			// 
			this.CURRENCY_NAMECN.Format = "";
			this.CURRENCY_NAMECN.FormatInfo = null;
			this.CURRENCY_NAMECN.HeaderText = "币种";
			this.CURRENCY_NAMECN.MappingName = "CURRENCY_NAMECN";
			this.CURRENCY_NAMECN.NullText = "";
			this.CURRENCY_NAMECN.Width = 75;
			// 
			// shipper
			// 
			this.shipper.Format = "";
			this.shipper.FormatInfo = null;
			this.shipper.HeaderText = "装船人";
			this.shipper.MappingName = "shipper";
			this.shipper.NullText = "";
			this.shipper.Width = 75;
			// 
			// CONTACT_NAME
			// 
			this.CONTACT_NAME.Format = "";
			this.CONTACT_NAME.FormatInfo = null;
			this.CONTACT_NAME.HeaderText = "联系人";
			this.CONTACT_NAME.MappingName = "CONTACT_NAME";
			this.CONTACT_NAME.NullText = "";
			this.CONTACT_NAME.Width = 75;
			// 
			// approvedby
			// 
			this.approvedby.Format = "";
			this.approvedby.FormatInfo = null;
			this.approvedby.HeaderText = "审核者";
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
			// PRECARRIAGEBY
			// 
			this.PRECARRIAGEBY.Format = "";
			this.PRECARRIAGEBY.FormatInfo = null;
			this.PRECARRIAGEBY.HeaderText = "一程船名";
			this.PRECARRIAGEBY.MappingName = "PRECARRIAGEBY";
			this.PRECARRIAGEBY.NullText = "";
			this.PRECARRIAGEBY.Width = 75;
			// 
			// CARRIAGEBY
			// 
			this.CARRIAGEBY.Format = "";
			this.CARRIAGEBY.FormatInfo = null;
			this.CARRIAGEBY.HeaderText = "船名";
			this.CARRIAGEBY.MappingName = "CARRIAGEBY";
			this.CARRIAGEBY.NullText = "";
			this.CARRIAGEBY.Width = 75;
			// 
			// consignee
			// 
			this.consignee.Format = "";
			this.consignee.FormatInfo = null;
			this.consignee.HeaderText = "收货人";
			this.consignee.MappingName = "consignee";
			this.consignee.NullText = "";
			this.consignee.Width = 75;
			// 
			// notifier
			// 
			this.notifier.Format = "";
			this.notifier.FormatInfo = null;
			this.notifier.HeaderText = "通知人";
			this.notifier.MappingName = "notifier";
			this.notifier.NullText = "";
			this.notifier.Width = 75;
			// 
			// Awb_NAME
			// 
			this.Awb_NAME.Format = "";
			this.Awb_NAME.FormatInfo = null;
			this.Awb_NAME.HeaderText = "托运人";
			this.Awb_NAME.MappingName = "Awb_NAME";
			this.Awb_NAME.NullText = "";
			this.Awb_NAME.Width = 75;
			// 
			// FREIGHT_PAYDATE
			// 
			this.FREIGHT_PAYDATE.Format = "";
			this.FREIGHT_PAYDATE.FormatInfo = null;
			this.FREIGHT_PAYDATE.HeaderText = "付款期限";
			this.FREIGHT_PAYDATE.MappingName = "FREIGHT_PAYDATE";
			this.FREIGHT_PAYDATE.NullText = "";
			this.FREIGHT_PAYDATE.Width = 75;
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
			this.createon.HeaderText = "创建日期";
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
			this.modifyon.HeaderText = "最后修改日期";
			this.modifyon.MappingName = "modifyon";
			this.modifyon.NullText = "";
			this.modifyon.Width = 75;
			// 
			// pay_term_name
			// 
			this.pay_term_name.Format = "";
			this.pay_term_name.FormatInfo = null;
			this.pay_term_name.HeaderText = "结汇方式";
			this.pay_term_name.MappingName = "pay_term_name";
			this.pay_term_name.NullText = "";
			this.pay_term_name.Width = 75;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(472, 368);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(88, 24);
			this.button1.TabIndex = 175;
			this.button1.Text = "货物明细";
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// xpStyleButton1
			// 
			this.xpStyleButton1.Location = new System.Drawing.Point(560, 368);
			this.xpStyleButton1.Name = "xpStyleButton1";
			this.xpStyleButton1.Size = new System.Drawing.Size(88, 24);
			this.xpStyleButton1.TabIndex = 176;
			this.xpStyleButton1.Text = "托运单打印";
			this.xpStyleButton1.Click += new System.EventHandler(this.xpStyleButton1_Click);
			// 
			// xpStyleButton2
			// 
			this.xpStyleButton2.Location = new System.Drawing.Point(648, 368);
			this.xpStyleButton2.Name = "xpStyleButton2";
			this.xpStyleButton2.Size = new System.Drawing.Size(88, 24);
			this.xpStyleButton2.TabIndex = 176;
			this.xpStyleButton2.Text = "盈亏表";
			this.xpStyleButton2.Click += new System.EventHandler(this.xpStyleButton2_Click);
			// 
			// frmAwbDoc
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(7, 16);
			this.BackColor = System.Drawing.SystemColors.ScrollBar;
			this.ClientSize = new System.Drawing.Size(792, 566);
			this.Controls.Add(this.panel3);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.panel2);
			this.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "frmAwbDoc";
			this.Text = "货物托运单";
			this.panel3.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			this.panel4.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

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
					sb.Append("  系统中已存在该货品，请重新命名货品ID");
					TJSystem.Public.PublicStatic.ShowMessage(TJSystem.Public.MessageType.Error,sb.ToString());
					return false;
				}
			}

			if(!TJSystem.Public.PublicStatic.IsNumDouble(this.priTextBox33.Text.Trim()))
			{
				if(TJSystem.Public.PublicStatic.IsExsist(_table,_PK,this.priToolBar1))
				{
					sb.Append("  运费吨必须是数字！");
					TJSystem.Public.PublicStatic.ShowMessage(TJSystem.Public.MessageType.Error,sb.ToString());
					return false;
				}
			}
			if(!TJSystem.Public.PublicStatic.IsNumDouble(this.priTextBox36.Text.Trim()))
			{
				if(TJSystem.Public.PublicStatic.IsExsist(_table,_PK,this.priToolBar1))
				{
					sb.Append("  运费总额必须是数字！");
					TJSystem.Public.PublicStatic.ShowMessage(TJSystem.Public.MessageType.Error,sb.ToString());
					return false;
				}
			}
			if(!TJSystem.Public.PublicStatic.IsNumDouble(this.priTextBox26.Text.Trim()))
			{
				if(TJSystem.Public.PublicStatic.IsExsist(_table,_PK,this.priToolBar1))
				{
					sb.Append("  运费率必须是数字！");
					TJSystem.Public.PublicStatic.ShowMessage(TJSystem.Public.MessageType.Error,sb.ToString());
					return false;
				}
			}
			if(!TJSystem.Public.PublicStatic.IsNumDouble(this.priTextBox35.Text.Trim()))
			{
				if(TJSystem.Public.PublicStatic.IsExsist(_table,_PK,this.priToolBar1))
				{
					sb.Append("  货品总值必须是数字！");
					TJSystem.Public.PublicStatic.ShowMessage(TJSystem.Public.MessageType.Error,sb.ToString());
					return false;
				}
			}
			return true;
		}

		private void InitialGrid(string sql)
		{		
			DataTable dt = TJSystem.Public.PublicStatic.db.GetDataTable(sql);
			dt.TableName = "SALE_WAYBILL_MASTER";
			this.dataGrid1.DataSource = dt.DefaultView;
		}

		private void AfterButtonClick(string ButtonType)
		{
			if(ButtonType.Equals("insert"))
			{
				this.textBox1.Enabled = true;
				this.priTextBox1.Enabled = true;
				this.priTextBox3.Enabled = true;
				this.priTextBox4.Enabled = true;
				this.priTextBox10.Enabled = true;
				this.priTextBox12.Enabled = true;
				
				this.priTextBox16.Enabled = true;
				
				this.priTextBox18.Enabled = true;
				
				this.priTextBox20.Enabled = true;
				this.priTextBox22.Enabled = true;
				this.priTextBox26.Enabled = true;
				this.priTextBox29.Enabled = true;

				this.priTextBox33.Enabled = true;
				this.priTextBox35.Enabled = true;
				this.priTextBox36.Enabled = true;
				this.priTextBox37.Enabled = true;
				this.priTextBox38.Enabled = true;

				this.comboBox1.Enabled = true;
				this.priComboBox1.Enabled = false;
				this.priComboBox2.Enabled = true;
				this.priComboBox3.Enabled = true;
				this.priComboBox4.Enabled = true;
				this.priComboBox5.Enabled = true;
				this.priComboBox6.Enabled = true;
				this.priComboBox7.Enabled = true;
				this.priComboBox8.Enabled = true;
				this.priComboBox9.Enabled = true;
				this.priComboBox12.Enabled = true;

				this.priDateTimePicker1.Enabled = true;
				this.priDateTimePicker3.Enabled = true;
				this.priDateTimePicker4.Enabled = true;				
				
				this.textBox1.Text = "" ;
				this.priTextBox1.Text = "";
				this.priTextBox3.Text = "";
				this.priTextBox4.Text = "";
				this.priTextBox10.Text = "";
				this.priTextBox12.Text = "";
				this.priTextBox14.Text = "";
				this.priTextBox16.Text = "";
				this.priTextBox17.Text = "";
				this.priTextBox18.Text = "";
				
				this.priTextBox20.Text = "";
				this.priTextBox22.Text = "";
				this.priTextBox26.Text = "";
				this.priTextBox29.Text = "";
				
				this.priTextBox33.Text = "";
				this.priTextBox35.Text = "";
				this.priTextBox36.Text = "";
				this.priTextBox37.Text = "";
				this.priTextBox38.Text = "";

				this.comboBox1.Text = "";
				this.priComboBox1.SelectedValue = "1";
				this.priComboBox2.Text = "";
				this.priComboBox3.Text = "";
				this.priComboBox4.Text = "";
				this.priComboBox5.Text = "";
				this.priComboBox6.Text = "";
				this.priComboBox7.Text = "";
				this.priComboBox8.Text = "";
				this.priComboBox9.Text = "";
				this.priComboBox12.Text = "";

				this.priDateTimePicker3.Value = System.DateTime.Now;
				this.priDateTimePicker4.Value = System.DateTime.Now;
				this.priDateTimePicker1.Value = System.DateTime.Now;
			}
			else if(ButtonType.Equals("update"))
			{
				this.textBox1.Enabled = false;
				this.priTextBox1.Enabled = true;
				this.priTextBox3.Enabled = true;
				
				this.priTextBox4.Enabled = true;
				this.priTextBox10.Enabled = true;
				this.priTextBox12.Enabled = true;
				
				this.priTextBox16.Enabled = true;
				
				this.priTextBox18.Enabled = true;
				
				this.priTextBox20.Enabled = true;
				this.priTextBox22.Enabled = true;
				this.priTextBox26.Enabled = true;
				this.priTextBox29.Enabled = true;
				
				this.priTextBox33.Enabled = true;
				this.priTextBox35.Enabled = true;
				this.priTextBox36.Enabled = true;
				this.priTextBox37.Enabled = true;
				this.priTextBox38.Enabled = true;

				this.comboBox1.Enabled = true;
				this.priComboBox1.Enabled = false;
				this.priComboBox2.Enabled = true;
				this.priComboBox3.Enabled = true;
				this.priComboBox4.Enabled = true;
				this.priComboBox5.Enabled = true;
				this.priComboBox6.Enabled = true;
				this.priComboBox7.Enabled = true;
				this.priComboBox8.Enabled = true;
				this.priComboBox9.Enabled = true;
				this.priComboBox12.Enabled = true;

				this.priDateTimePicker1.Enabled = true;
				this.priDateTimePicker3.Enabled = true;
				this.priDateTimePicker4.Enabled = true;
			}
			//this.priToolBar1.SetStatusEnable(this.priComboBox1);
		}

		private void setDisable()
		{
			this.textBox1.Enabled = false;
			this.priTextBox1.Enabled = false;
			this.priTextBox2.Enabled = false;
			this.priTextBox3.Enabled = false;
			this.priTextBox4.Enabled = false;
			this.priTextBox6.Enabled = false;
			this.priTextBox7.Enabled = false;
			this.priTextBox8.Enabled = false;
			this.priTextBox10.Enabled = false;
			this.priTextBox12.Enabled = false;
			this.priTextBox14.Enabled = false;
			this.priTextBox16.Enabled = false;
			this.priTextBox17.Enabled = false;
			this.priTextBox18.Enabled = false;
				
			this.priTextBox20.Enabled = false;
			this.priTextBox22.Enabled = false;
			this.priTextBox26.Enabled = false;
			this.priTextBox29.Enabled = false;
				
			this.priTextBox33.Enabled = false;
			this.priTextBox35.Enabled = false;
			this.priTextBox36.Enabled = false;
			this.priTextBox37.Enabled = false;
			this.priTextBox38.Enabled = false;

			this.comboBox1.Enabled = false;
			this.priComboBox1.Enabled = false;
			this.priComboBox2.Enabled = false;
			this.priComboBox3.Enabled = false;
			this.priComboBox4.Enabled = false;
			this.priComboBox5.Enabled = false;
			this.priComboBox6.Enabled = false;
			this.priComboBox7.Enabled = false;
			this.priComboBox8.Enabled = false;
			this.priComboBox9.Enabled = false;
			this.priComboBox12.Enabled = false;

			this.priDateTimePicker1.Enabled = false;
			this.priDateTimePicker3.Enabled = false;
			this.priDateTimePicker4.Enabled = false;			
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
				TJSystem.Public.PublicStatic.formName = "货物托运单";
			}
			base.OnClosing (e);
		}

		private void priComboBox11_SelectionChangeCommitted(object sender, System.EventArgs e)
		{
//			string sql = null;
//			System.Data.DataTable dt = null;
//			sql = "select TERM_CODE,TERM_NAMECN from p_priceterm where term_code ='" + this.priComboBox11.SelectedValue.ToString() + "'";
//			dt = TJSystem.Public.PublicStatic.db.GetDataTable(sql);
//			if(dt.Rows.Count != 1)
//			{
//				this.textBox2.Text = "";
//				return;
//			}
//			this.textBox2.Text = dt.Rows[0][1].ToString();
		}

		private void priComboBox2_SelectionChangeCommitted(object sender, System.EventArgs e)
		{

			string sql = null;
			DataTable dt = null;
			DataRow dr= null;
			DataTable dtcpy = null;
			sql = "SELECT FORWARDER_ID,FORWARDER_NAME FROM BASIC_FORWARDER where FORWARDER_ID='" + priComboBox2.SelectedValue.ToString() + "'";
			dt = TJSystem.Public.PublicStatic.db.GetDataTable(sql);
			if(dt.Rows.Count != 1)
			{
				this.priTextBox5.Text = "";
			}
			else
			{
				this.priTextBox5.Text = dt.Rows[0][1].ToString();
			}

			sql = "SELECT CONTACT_ID,CONTACT_ID+' '+CONTACT_NAME AS CONTACT_NAME FROM BASIC_FORWARDER_CONTACT WHERE FORWARDER_ID='" +  priComboBox2.SelectedValue.ToString() + "' ORDER BY CONTACT_ID";
			dt = TJSystem.Public.PublicStatic.db.GetDataTable(sql);
			dr = dt.NewRow() ;
			dr[0] = "" ;
			dr[1] = "" ;
			dt.Rows.InsertAt(dr,0) ;
			dtcpy = dt.Copy();
			this.priComboBox9.DataSource = dtcpy.DefaultView;
			this.priComboBox9.ValueMember = "CONTACT_ID";
			this.priComboBox9.DisplayMember = "CONTACT_NAME";
		}

		private void priComboBox9_SelectionChangeCommitted(object sender, System.EventArgs e)
		{
			string sql = null;
			DataTable dt = null;
			sql = "SELECT contact_id,contact_name,forwarder_id FROM BASIC_FORWARDER_CONTACT where forwarder_id='" + priComboBox2.SelectedValue.ToString() + "' and contact_id='" + priComboBox9.SelectedValue.ToString() + "'";
			dt = TJSystem.Public.PublicStatic.db.GetDataTable(sql);
			if(dt.Rows.Count != 1)
			{
				this.priTextBox11.Text = "";
			}
			else
			{
				this.priTextBox11.Text = dt.Rows[0][1].ToString();
			}
		}

		private void HuoWuDetailEvent()
		{
			if(this.textBox1.Text.Trim().Equals(""))
			{
				TJSystem.Public.PublicStatic.ShowMessage(TJSystem.Public.MessageType.Exclamation,"未选择要托运单号！");
				return;
			}
			string strsolist = this.priTextBox4.Text ;
			
			System.Text.StringBuilder sb = new System.Text.StringBuilder();
			string sql = "select so_code,invoice_no from sale_doc_master where invoice_no='" + this.priTextBox4.Text + "'";
			System.Data.DataTable dt = TJSystem.Public.PublicStatic.db.GetDataTable(sql);
			if(dt.Rows.Count != 1)
			{
				TJSystem.Public.PublicStatic.ShowMessage(TJSystem.Public.MessageType.Exclamation,"找不到该托运单对应的销售单号！");
				return;
			}
			string[] arrsolist = dt.Rows[0][0].ToString().Split(',');
			for(int i = 0; i < arrsolist.Length; i++)
			{
				sb.Append("'");
				sb.Append(arrsolist[i]);
				sb.Append("',");
			}
			strsolist = sb.ToString().Substring(0,sb.ToString().Length - 1);

			frmAwbDocDetail frm = new frmAwbDocDetail(strsolist,this.textBox1.Text);
			frm.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			frm.ShowDialog();
		}

		private void TuoYunDanPrintEvent()
		{
			System.Text.StringBuilder sb = new System.Text.StringBuilder();
			string strsol = null;
			if(this.priTextBox4.Text.Trim().Equals(""))
			{
				TJSystem.Public.PublicStatic.ShowMessage(TJSystem.Public.MessageType.Exclamation,"请选择要打印的托运单号！");
				return;
			}
			string sql = "select invoice_no,so_code from sale_doc_master where invoice_no='" + this.priTextBox4.Text.Trim() + "'"; 
			System.Data.DataTable dt = TJSystem.Public.PublicStatic.db.GetDataTable(sql);
			if(dt.Rows.Count != 1)
			{
				TJSystem.Public.PublicStatic.ShowMessage(TJSystem.Public.MessageType.Exclamation,"找不到该托运单的发票号，无法打印！");
				return;
			}

			string[] arrsolist = dt.Rows[0][1].ToString().Split(',');
			for(int i = 0; i < arrsolist.Length; i++)
			{
				sb.Append("'");
				sb.Append(arrsolist[i]);
				sb.Append("',");
			}
			strsol = sb.ToString().Substring(0,sb.ToString().Length - 1);
						
			TJSystem.Classes.common.DocParamCommon dpcom = new TJSystem.Classes.common.DocParamCommon();
			dpcom.PKCondition = " where so_code in ("+ strsol +")";
			dpcom.DocNO = this.textBox1.Text;
			dpcom.DocLCNO = this.priTextBox18.Text;
			dpcom.Shipper = this.priTextBox5.Text;
			dpcom.DocPOE = this.comboBox1.Text;
			dpcom.DocPOD = this.priTextBox3.Text;
			dpcom.ShipperType = this.priComboBox7.Text;
			dpcom.TransDate = this.priDateTimePicker4.Value.ToString("yyyy-MM-dd");
			dpcom.DocDate = this.priDateTimePicker3.Value.ToString("yyyy-MM-dd");
			dpcom.ValueT = this.priTextBox35.Text;
			dpcom.Quantity = this.priTextBox33.Text;
			dpcom.DocSaleNO = this.priTextBox4.Text;
			dpcom.DocSaleTo = this.priTextBox37.Text;

			
			TJSystem.CrystalRPT.frmReport frm = new TJSystem.CrystalRPT.frmReport("托运单打印",dpcom,this.dataGrid1);
			frm.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			frm.ShowDialog();
		}

		private void priComboBox1_SelectionChangeCommitted(object sender, System.EventArgs e)
		{
			TJSystem.Public.PublicStatic.SetApprovedInfo(this.priComboBox1,this.priTextBox14,this.priTextBox17);
		}

		private void YingKuiBiaoEvent()
		{
			System.Text.StringBuilder sb = new System.Text.StringBuilder();
			string strsol = null;
			if(this.priTextBox4.Text.Trim().Equals(""))
			{
				TJSystem.Public.PublicStatic.ShowMessage(TJSystem.Public.MessageType.Exclamation,"请选择要打印的托运单号！");
				return;
			}
			string sql = "select invoice_no,so_code from sale_doc_master where invoice_no='" + this.priTextBox4.Text.Trim() + "'"; 
			System.Data.DataTable dt = TJSystem.Public.PublicStatic.db.GetDataTable(sql);
			if(dt.Rows.Count != 1)
			{
				TJSystem.Public.PublicStatic.ShowMessage(TJSystem.Public.MessageType.Exclamation,"找不到该托运单的发票号，无法打印！");
				return;
			}

			string[] arrsolist = dt.Rows[0][1].ToString().Split(',');
			for(int i = 0; i < arrsolist.Length; i++)
			{
				sb.Append("'");
				sb.Append(arrsolist[i]);
				sb.Append("',");
			}
			strsol = sb.ToString().Substring(0,sb.ToString().Length - 1);
						
			TJSystem.Classes.common.DocParamCommon dpcom = new TJSystem.Classes.common.DocParamCommon();
			dpcom.PKCondition = " where a.so_code in ("+ strsol +")";
			dpcom.DocNO = this.textBox1.Text;
			dpcom.DocSaleNO = strsol;
			dpcom.Quantity = this.priTextBox36.Text.Trim();//运费金额
			dpcom.ValueT = this.priComboBox12.SelectedValue.ToString();//货币类型
						
			TJSystem.CrystalRPT.frmReport frm = new TJSystem.CrystalRPT.frmReport("盈亏表",dpcom,this.dataGrid1);
			frm.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			frm.ShowDialog();
		}

		private void button1_Click(object sender, System.EventArgs e)
		{
			this.HuoWuDetailEvent();
		}

		private void xpStyleButton1_Click(object sender, System.EventArgs e)
		{
			this.TuoYunDanPrintEvent();
		}

		private void xpStyleButton2_Click(object sender, System.EventArgs e)
		{
			this.YingKuiBiaoEvent();
		}

//		private void priComboBox10_SelectionChangeCommitted(object sender, System.EventArgs e)
//		{
//			string sql = null;
//			System.Data.DataTable dt = null;
//			sql = "select CLIENT_ID,CLIENT_NAME from basic_client where CLIENT_ID ='" + this.priComboBox10.SelectedValue.ToString() + "'";
//			dt = TJSystem.Public.PublicStatic.db.GetDataTable(sql);
//			if(dt.Rows.Count != 1)
//			{
//				this.priTextBox35.Text = "";
//				return;
//			}
//			this.priTextBox35.Text = dt.Rows[0][1].ToString();
//		}

		

		public System.Windows.Forms.Form setParentForm
		{
			set
			{
				_form = value;
			}
			get
			{
				return _form;
			}
		}
		
	}
}

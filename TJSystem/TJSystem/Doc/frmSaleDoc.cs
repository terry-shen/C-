using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.IO;
using System.Data.SqlClient;

namespace TJSystem.Doc
{
	/// <summary>
	/// Form1 的摘要说明。
	/// </summary>
	public class frmSaleDoc : System.Windows.Forms.Form
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
		private TJSystem.Classes.PriTextBox priTextBox25;
		private TJSystem.Classes.PriTextBox priTextBox4;
		private System.Windows.Forms.Label label24;
		private TJSystem.Classes.PriTextBox priTextBox20;
		private System.Windows.Forms.Label label25;
		private TJSystem.Classes.PriTextBox priTextBox21;
		private System.Windows.Forms.Label label26;
		private TJSystem.Classes.PriTextBox priTextBox22;
		private System.Windows.Forms.Label label27;
		private System.Windows.Forms.Label label28;
		private TJSystem.Classes.PriTextBox priTextBox23;
		private System.Windows.Forms.Label label21;
		private TJSystem.Classes.PriTextBox priTextBox17;
		private System.Windows.Forms.Label label19;
		private TJSystem.Classes.PriTextBox priTextBox15;
		private System.Windows.Forms.Label label18;
		private TJSystem.Classes.PriTextBox priTextBox14;
		private System.Windows.Forms.Label label16;
		private System.Windows.Forms.Label label17;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.Label label13;
		private TJSystem.Classes.PriTextBox priTextBox10;
		private System.Windows.Forms.Label label12;
		private TJSystem.Classes.PriTextBox priTextBox9;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private TJSystem.Classes.PriComboBox comboBox1;
		private TJSystem.Classes.PriTextBox textBox1;
		private TJSystem.Classes.PriTextBox priTextBox3;
		private System.Windows.Forms.DataGrid dataGrid1;
		private System.Windows.Forms.DataGridTableStyle dataGridTableStyle1;
		private System.Windows.Forms.Label label32;
		private System.Windows.Forms.Label label35;
		private System.Windows.Forms.Label label36;
		private System.Windows.Forms.Label label37;
		private TJSystem.Classes.PriTextBox priTextBox29;
		private TJSystem.Classes.PriComboBox priComboBox1;
		private System.Windows.Forms.LinkLabel linkLabel3;
		private System.Windows.Forms.LinkLabel linkLabel4;
		public static System.Windows.Forms.Form frmCurrent = null ;
		private string _statusType = null;
		private string _table = null;
		private string _PK = null;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label22;
		private System.Windows.Forms.Label label23;
		private System.Windows.Forms.Label label29;
		private System.Windows.Forms.Label label31;
		private System.Windows.Forms.Label label33;
		private System.Windows.Forms.Label label34;
		private TJSystem.Classes.PriTextBox priTextBox18;
		private System.Windows.Forms.Label label38;
		private System.Windows.Forms.Label label39;
		private TJSystem.Classes.PriTextBox priTextBox26;
		private TJSystem.Classes.PriTextBox priTextBox30;
		private System.Windows.Forms.Label label40;
		private System.Windows.Forms.Label label41;
		private System.Windows.Forms.Label label42;
		private TJSystem.Classes.PriTextBox priTextBox33;
		private System.Windows.Forms.Label label43;
		private System.Windows.Forms.Label label44;
		private TJSystem.Classes.PriTextBox priTextBox35;
		private System.Windows.Forms.Label label45;
		private TJSystem.Classes.PriTextBox priTextBox36;
		private System.Windows.Forms.Label label46;
		private System.Windows.Forms.LinkLabel linkLabel2;
		private TJSystem.Classes.PriTextBox priTextBox11;
		private TJSystem.Classes.PriDateTimePicker priDateTimePicker1;
		private TJSystem.Classes.PriDateTimePicker priDateTimePicker2;
		private TJSystem.Classes.PriDateTimePicker priDateTimePicker3;
		private TJSystem.Classes.PriComboBox priComboBox2;
		private TJSystem.Classes.PriComboBox priComboBox3;
		private TJSystem.Classes.PriComboBox priComboBox4;
		private TJSystem.Classes.PriComboBox priComboBox5;
		private TJSystem.Classes.PriComboBox priComboBox7;
		private TJSystem.Classes.PriComboBox priComboBox8;
		private TJSystem.Classes.PriDateTimePicker priDateTimePicker4;
		private TJSystem.Classes.PriTextBox priTextBox1;
		private TJSystem.Classes.PriComboBox priComboBox9;
		private TJSystem.Classes.PriComboBox priComboBox10;
		private TJSystem.Classes.PriComboBox priComboBox11;
		private TJSystem.Classes.PriTextBox priTextBox2;
		private TJSystem.Classes.PriTextBox priTextBox6;
		private TJSystem.Classes.PriTextBox priTextBox7;
		private TJSystem.Classes.PriTextBox priTextBox8;
		private TJSystem.Classes.PriDateTimePicker priDateTimePicker5;
		private TJSystem.Classes.PriComboBox priComboBox12;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.DataGridTextBoxColumn invoice_no;
		private System.Windows.Forms.DataGridTextBoxColumn invoice_date;
		private System.Windows.Forms.DataGridTextBoxColumn so_code;
		private System.Windows.Forms.DataGridTextBoxColumn role_code;
		private System.Windows.Forms.DataGridTextBoxColumn licence_no;
		private System.Windows.Forms.DataGridTextBoxColumn imposetaxfree;
		private System.Windows.Forms.DataGridTextBoxColumn putonrecordno;
		private System.Windows.Forms.DataGridTextBoxColumn sanctifiedno;
		private System.Windows.Forms.DataGridTextBoxColumn client_orderno;
		private System.Windows.Forms.DataGridTextBoxColumn transtools;
		private System.Windows.Forms.DataGridTextBoxColumn freight;
		private System.Windows.Forms.DataGridTextBoxColumn allowtransport;
		private System.Windows.Forms.DataGridTextBoxColumn allowbatch;
		private System.Windows.Forms.DataGridTextBoxColumn billloading;
		private System.Windows.Forms.DataGridTextBoxColumn deliverydate;
		private System.Windows.Forms.DataGridTextBoxColumn oceangoingvessel_notice;
		private System.Windows.Forms.DataGridTextBoxColumn approvedby;
		private System.Windows.Forms.DataGridTextBoxColumn approvedon;
		private System.Windows.Forms.DataGridTextBoxColumn company_name;
		private System.Windows.Forms.DataGridTextBoxColumn shipper;
		private System.Windows.Forms.DataGridTextBoxColumn exportdate;
		private System.Windows.Forms.DataGridTextBoxColumn declaredate;
		private System.Windows.Forms.DataGridTextBoxColumn lc_code;
		private System.Windows.Forms.DataGridTextBoxColumn bank;
		private System.Windows.Forms.DataGridTextBoxColumn lc_date;
		private System.Windows.Forms.DataGridTextBoxColumn validity;
		private System.Windows.Forms.DataGridTextBoxColumn priceterm_dest;
		private System.Windows.Forms.DataGridTextBoxColumn client_id;
		private System.Windows.Forms.DataGridTextBoxColumn client_name;
		private System.Windows.Forms.DataGridTextBoxColumn proposer;
		private System.Windows.Forms.DataGridTextBoxColumn consignee;
		private System.Windows.Forms.DataGridTextBoxColumn notifier;
		private System.Windows.Forms.DataGridTextBoxColumn createby;
		private System.Windows.Forms.DataGridTextBoxColumn createon;
		private System.Windows.Forms.DataGridTextBoxColumn modifyby;
		private System.Windows.Forms.DataGridTextBoxColumn modifyon;
		private System.Windows.Forms.DataGridTextBoxColumn PAYMODE_NAME_CN;
		private System.Windows.Forms.DataGridTextBoxColumn TRADE_DESC;
		private System.Windows.Forms.DataGridTextBoxColumn priceterm_name;
		private System.Windows.Forms.DataGridTextBoxColumn port_departure_name;
		private System.Windows.Forms.DataGridTextBoxColumn COUNTRY_NAMECN;
		private System.Windows.Forms.DataGridTextBoxColumn destport_name;
		private System.Windows.Forms.DataGridTextBoxColumn port_transport_name;
		private System.Windows.Forms.DataGridTextBoxColumn TRANS_NAMECN;
		private System.Windows.Forms.DataGridTextBoxColumn STATUS_NAME;
		private System.Windows.Forms.DataGridTextBoxColumn CURRENCY_NAMECN;
		private System.Windows.Forms.DataGridTextBoxColumn pay_term_name;
		private TJSystem.Classes.PriTextBox priTextBox5;
		private System.Windows.Forms.LinkLabel linkLabel8;
		private System.Windows.Forms.Label label30;
		private TJSystem.Classes.PriTextBox priTextBox12;
		private System.Windows.Forms.DataGridTextBoxColumn pack_qty;
		private TJSystem.Classes.PriTextBox priTextBox13;
		private System.Windows.Forms.Label label49;
		private System.Windows.Forms.DataGridTextBoxColumn MaiTou;
		private System.Windows.Forms.PictureBox pictureBox1;
		private TJSystem.Classes.XpStyleButton button1;
		private TJSystem.Classes.XpStyleButton xpStyleButton1;
		private TJSystem.Classes.XpStyleButton xpStyleButton2;
		private TJSystem.Classes.XpStyleButton xpStyleButton3;

		private System.Windows.Forms.Form _form = null;

		public frmSaleDoc()
		{
			//
			// Windows 窗体设计器支持所必需的
			//
			InitializeComponent();

			

			_statusType = "sales";
			TJSystem.Public.PublicStatic.setBackgroundImg(this.panel1,this.panel1.GetType().ToString(),"images\\bg.gif");
			TJSystem.Public.PublicStatic.setBackgroundImg(this.panel2,this.panel1.GetType().ToString(),"");
			TJSystem.Public.PublicStatic.setBackgroundImg(this.panel3,this.panel1.GetType().ToString(),"");
			TJSystem.Public.PublicStatic.setBackgroundImg(this.panel4,this.panel1.GetType().ToString(),"");

			this.Cursor = System.Windows.Forms.Cursors.WaitCursor;
			InitialFormData();
			

			System.Text.StringBuilder sb = new System.Text.StringBuilder();
			sb.Append("select a.maitou,a.pack_qty,a.invoice_no,a.invoice_date,a.status,c.STATUS_NAME as STATUS_NAME,a.client_id,a.client_name,a.putonrecordno,a.exportdate,a.declaredate, ");
			sb.Append(" a.sanctifiedno,a.settlementtype,d.PAYMODE_NAME_CN as PAYMODE_NAME_CN,a.imposetaxfree,a.so_code,a.client_orderno,a.licence_no,a.vrf_code,");
			sb.Append(" a.lc_code,a.bank,a.lc_date,a.validity,a.deliverydate,a.pay_term,j.TERM_NAMECN as pay_term_name,a.trade_character,b.TRADE_DESC as TRADE_DESC,");
			sb.Append(" a.currency,m.CURRENCY_NAMECN as CURRENCY_NAMECN,a.priceterm,l.TERM_NAMECN as priceterm_name,");
			sb.Append(" a.port_departure,n.PORT_NAMECN as port_departure_name,a.arrivecountry,e.COUNTRY_NAMECN as COUNTRY_NAMECN,a.destport,i.PORT_NAMECN as destport_name ,");
			sb.Append(" a.port_transport,f.PORT_NAMECN as port_transport_name,a.transtype,h.TRANS_NAMECN as TRANS_NAMECN,a.transtools,a.billloading,");
			sb.Append(" a.freight,a.allowbatch,a.allowtransport,a.oceangoingvessel_notice,a.company_name,a.shipper,a.proposer,");
			sb.Append(" a.consignee,a.notifier,a.approvedby,a.approvedon,a.createby,a.createon,a.modifyby,a.modifyon,a.role_code,a.priceterm_dest");
			sb.Append(" from sale_doc_master a");
			sb.Append(" left join p_tradechar b on a.trade_character=b.TRADE_ID");
			sb.Append(" left join p_status c on a.status=c.STATUS_ID and c.status_type=");
			sb.Append("'");
			sb.Append(this._statusType);
			sb.Append("' ");
			sb.Append(" left join p_paymode d on a.settlementtype = d.PAYMODE_ID");
			sb.Append(" left join p_country e on a.arrivecountry=e.COUNTRY_CODE");
			sb.Append(" left join p_port f on a.port_transport=f.PORT_CODE");
			sb.Append(" left join p_transtype h on a.transtype=h.TRANS_CODE");
			sb.Append(" left join p_port i on a.destport=i.PORT_CODE");
			sb.Append(" left join p_paymentterm j on a.pay_term=j.TERM_CODE");
			sb.Append(" left join p_priceterm l on a.priceterm=l.TERM_CODE");
			sb.Append(" left join p_currency m on a.currency=m.CURRENCY_CODE");
			sb.Append(" left join p_port n on a.port_departure=n.PORT_CODE");
			sb.Append(" order by a.invoice_no");
			this.InitialGrid(sb.ToString());

			priToolBar1.setCurrentForm = this;
			
			_PK = "invoice_no";
			_table = "sale_doc_master";
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

		public frmSaleDoc(string invoicenolist)
		{
			//
			// Windows 窗体设计器支持所必需的
			//
			InitializeComponent();

			

			_statusType = "sales";
			TJSystem.Public.PublicStatic.setBackgroundImg(this.panel1,this.panel1.GetType().ToString(),"images\\bg.gif");
			TJSystem.Public.PublicStatic.setBackgroundImg(this.panel2,this.panel1.GetType().ToString(),"");
			TJSystem.Public.PublicStatic.setBackgroundImg(this.panel3,this.panel1.GetType().ToString(),"");
			TJSystem.Public.PublicStatic.setBackgroundImg(this.panel4,this.panel1.GetType().ToString(),"");

			this.Cursor = System.Windows.Forms.Cursors.WaitCursor;
			InitialFormData();
			

			System.Text.StringBuilder sb = new System.Text.StringBuilder();
			sb.Append("select a.maitou,a.pack_qty,a.invoice_no,a.invoice_date,a.status,c.STATUS_NAME as STATUS_NAME,a.client_id,a.client_name,a.putonrecordno,a.exportdate,a.declaredate, ");
			sb.Append(" a.sanctifiedno,a.settlementtype,d.PAYMODE_NAME_CN as PAYMODE_NAME_CN,a.imposetaxfree,a.so_code,a.client_orderno,a.licence_no,a.vrf_code,");
			sb.Append(" a.lc_code,a.bank,a.lc_date,a.validity,a.deliverydate,a.pay_term,j.TERM_NAMECN as pay_term_name,a.trade_character,b.TRADE_DESC as TRADE_DESC,");
			sb.Append(" a.currency,m.CURRENCY_NAMECN as CURRENCY_NAMECN,a.priceterm,l.TERM_NAMECN as priceterm_name,");
			sb.Append(" a.port_departure,n.PORT_NAMECN as port_departure_name,a.arrivecountry,e.COUNTRY_NAMECN as COUNTRY_NAMECN,a.destport,i.PORT_NAMECN as destport_name ,");
			sb.Append(" a.port_transport,f.PORT_NAMECN as port_transport_name,a.transtype,h.TRANS_NAMECN as TRANS_NAMECN,a.transtools,a.billloading,");
			sb.Append(" a.freight,a.allowbatch,a.allowtransport,a.oceangoingvessel_notice,a.company_name,a.shipper,a.proposer,");
			sb.Append(" a.consignee,a.notifier,a.approvedby,a.approvedon,a.createby,a.createon,a.modifyby,a.modifyon,a.role_code,a.priceterm_dest");
			sb.Append(" from sale_doc_master a");
			sb.Append(" left join p_tradechar b on a.trade_character=b.TRADE_ID");
			sb.Append(" left join p_status c on a.status=c.STATUS_ID and c.status_type=");
			sb.Append("'");
			sb.Append(this._statusType);
			sb.Append("' ");
			sb.Append(" left join p_paymode d on a.settlementtype = d.PAYMODE_ID");
			sb.Append(" left join p_country e on a.arrivecountry=e.COUNTRY_CODE");
			sb.Append(" left join p_port f on a.port_transport=f.PORT_CODE");
			sb.Append(" left join p_transtype h on a.transtype=h.TRANS_CODE");
			sb.Append(" left join p_port i on a.destport=i.PORT_CODE");
			sb.Append(" left join p_paymentterm j on a.pay_term=j.TERM_CODE");
			sb.Append(" left join p_priceterm l on a.priceterm=l.TERM_CODE");
			sb.Append(" left join p_currency m on a.currency=m.CURRENCY_CODE");
			sb.Append(" left join p_port n on a.port_departure=n.PORT_CODE");
			sb.Append(" where a.invoice_no in ");
			sb.Append(" (");
			sb.Append(invoicenolist);
			sb.Append(")");
			sb.Append(" order by a.invoice_no");
			this.InitialGrid(sb.ToString());

			priToolBar1.setCurrentForm = this;
			
			_PK = "invoice_no";
			_table = "sale_doc_master";
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
			string sql = "select TRADE_ID,TRADE_ID+' '+TRADE_DESC as TRADE_DESC from p_tradechar order by trade_id ";
			dt = TJSystem.Public.PublicStatic.db.GetDataTable(sql);
			dr = dt.NewRow() ;
			dr[0] = "" ;
			dr[1] = "" ;
			dt.Rows.InsertAt(dr,0) ;
			dtcpy = dt.Copy();
			this.priComboBox2.DataSource = dtcpy.DefaultView;
			this.priComboBox2.ValueMember = "TRADE_ID";
			this.priComboBox2.DisplayMember = "TRADE_DESC";

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

			sql = "select TERM_CODE,TERM_CODE+' '+TERM_NAMECN as TERM_NAMECN from p_paymentterm order by TERM_CODE ";
			dt = TJSystem.Public.PublicStatic.db.GetDataTable(sql);
			dr = dt.NewRow() ;
			dr[0] = "" ;
			dr[1] = "" ;
			dt.Rows.InsertAt(dr,0) ;
			dtcpy = dt.Copy();
			this.priComboBox9.DataSource = dtcpy.DefaultView;
			this.priComboBox9.ValueMember = "TERM_CODE";
			this.priComboBox9.DisplayMember = "TERM_NAMECN";

			sql = "select CLIENT_ID,CLIENT_ID+' '+CLIENT_NAME as CLIENT_NAME from basic_client order by CLIENT_ID ";
			dt = TJSystem.Public.PublicStatic.db.GetDataTable(sql);
			dr = dt.NewRow() ;
			dr[0] = "" ;
			dr[1] = "" ;
			dt.Rows.InsertAt(dr,0) ;
			dtcpy = dt.Copy();
			this.priComboBox10.DataSource = dtcpy.DefaultView;
			this.priComboBox10.ValueMember = "CLIENT_ID";
			this.priComboBox10.DisplayMember = "CLIENT_NAME";

			sql = "select TERM_CODE,TERM_CODE+' '+TERM_NAMECN as TERM_NAMECN from p_priceterm order by TERM_CODE ";
			dt = TJSystem.Public.PublicStatic.db.GetDataTable(sql);
			dr = dt.NewRow() ;
			dr[0] = "" ;
			dr[1] = "" ;
			dt.Rows.InsertAt(dr,0) ;
			dtcpy = dt.Copy();
			this.priComboBox11.DataSource = dtcpy.DefaultView;
			this.priComboBox11.ValueMember = "TERM_CODE";
			this.priComboBox11.DisplayMember = "TERM_NAMECN";

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

			sql = "select * from sale_doc_master";
			dt = TJSystem.Public.PublicStatic.db.GetDataTable(sql);
			if (dt.Columns.Count != 53)
			{
				sql = "ALTER TABLE sale_doc_master ADD	MaiTouImg image NULL";
				TJSystem.Public.PublicStatic.db.ExeSql(sql);
			}
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(frmSaleDoc));
			this.panel3 = new System.Windows.Forms.Panel();
			this.priToolBar1 = new TJSystem.UC.PriToolBar();
			this.panel1 = new System.Windows.Forms.Panel();
			this.label1 = new System.Windows.Forms.Label();
			this.panel2 = new System.Windows.Forms.Panel();
			this.panel4 = new System.Windows.Forms.Panel();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.priTextBox12 = new TJSystem.Classes.PriTextBox();
			this.label30 = new System.Windows.Forms.Label();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.label33 = new System.Windows.Forms.Label();
			this.label29 = new System.Windows.Forms.Label();
			this.label23 = new System.Windows.Forms.Label();
			this.label22 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.linkLabel4 = new System.Windows.Forms.LinkLabel();
			this.linkLabel3 = new System.Windows.Forms.LinkLabel();
			this.priComboBox1 = new TJSystem.Classes.PriComboBox();
			this.label37 = new System.Windows.Forms.Label();
			this.priTextBox29 = new TJSystem.Classes.PriTextBox();
			this.label36 = new System.Windows.Forms.Label();
			this.label35 = new System.Windows.Forms.Label();
			this.label32 = new System.Windows.Forms.Label();
			this.priTextBox25 = new TJSystem.Classes.PriTextBox();
			this.priTextBox4 = new TJSystem.Classes.PriTextBox();
			this.label24 = new System.Windows.Forms.Label();
			this.priTextBox20 = new TJSystem.Classes.PriTextBox();
			this.label25 = new System.Windows.Forms.Label();
			this.priTextBox21 = new TJSystem.Classes.PriTextBox();
			this.label26 = new System.Windows.Forms.Label();
			this.priTextBox22 = new TJSystem.Classes.PriTextBox();
			this.label27 = new System.Windows.Forms.Label();
			this.label28 = new System.Windows.Forms.Label();
			this.priTextBox23 = new TJSystem.Classes.PriTextBox();
			this.label21 = new System.Windows.Forms.Label();
			this.priTextBox17 = new TJSystem.Classes.PriTextBox();
			this.label19 = new System.Windows.Forms.Label();
			this.priTextBox15 = new TJSystem.Classes.PriTextBox();
			this.label18 = new System.Windows.Forms.Label();
			this.priTextBox14 = new TJSystem.Classes.PriTextBox();
			this.label16 = new System.Windows.Forms.Label();
			this.label17 = new System.Windows.Forms.Label();
			this.label15 = new System.Windows.Forms.Label();
			this.priTextBox11 = new TJSystem.Classes.PriTextBox();
			this.label14 = new System.Windows.Forms.Label();
			this.label13 = new System.Windows.Forms.Label();
			this.priTextBox10 = new TJSystem.Classes.PriTextBox();
			this.label12 = new System.Windows.Forms.Label();
			this.priTextBox9 = new TJSystem.Classes.PriTextBox();
			this.label11 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.comboBox1 = new TJSystem.Classes.PriComboBox();
			this.textBox1 = new TJSystem.Classes.PriTextBox();
			this.priTextBox3 = new TJSystem.Classes.PriTextBox();
			this.label31 = new System.Windows.Forms.Label();
			this.label34 = new System.Windows.Forms.Label();
			this.priTextBox18 = new TJSystem.Classes.PriTextBox();
			this.label38 = new System.Windows.Forms.Label();
			this.label39 = new System.Windows.Forms.Label();
			this.priTextBox26 = new TJSystem.Classes.PriTextBox();
			this.priTextBox30 = new TJSystem.Classes.PriTextBox();
			this.label40 = new System.Windows.Forms.Label();
			this.label41 = new System.Windows.Forms.Label();
			this.label42 = new System.Windows.Forms.Label();
			this.priTextBox33 = new TJSystem.Classes.PriTextBox();
			this.label43 = new System.Windows.Forms.Label();
			this.label44 = new System.Windows.Forms.Label();
			this.priTextBox35 = new TJSystem.Classes.PriTextBox();
			this.label45 = new System.Windows.Forms.Label();
			this.priTextBox36 = new TJSystem.Classes.PriTextBox();
			this.label46 = new System.Windows.Forms.Label();
			this.linkLabel2 = new System.Windows.Forms.LinkLabel();
			this.priDateTimePicker1 = new TJSystem.Classes.PriDateTimePicker();
			this.priDateTimePicker2 = new TJSystem.Classes.PriDateTimePicker();
			this.priDateTimePicker3 = new TJSystem.Classes.PriDateTimePicker();
			this.priComboBox2 = new TJSystem.Classes.PriComboBox();
			this.priComboBox3 = new TJSystem.Classes.PriComboBox();
			this.priComboBox4 = new TJSystem.Classes.PriComboBox();
			this.priComboBox5 = new TJSystem.Classes.PriComboBox();
			this.priComboBox7 = new TJSystem.Classes.PriComboBox();
			this.priComboBox8 = new TJSystem.Classes.PriComboBox();
			this.priDateTimePicker4 = new TJSystem.Classes.PriDateTimePicker();
			this.priTextBox1 = new TJSystem.Classes.PriTextBox();
			this.priComboBox9 = new TJSystem.Classes.PriComboBox();
			this.priComboBox10 = new TJSystem.Classes.PriComboBox();
			this.priComboBox11 = new TJSystem.Classes.PriComboBox();
			this.priTextBox2 = new TJSystem.Classes.PriTextBox();
			this.priTextBox6 = new TJSystem.Classes.PriTextBox();
			this.priTextBox7 = new TJSystem.Classes.PriTextBox();
			this.priTextBox8 = new TJSystem.Classes.PriTextBox();
			this.priDateTimePicker5 = new TJSystem.Classes.PriDateTimePicker();
			this.priComboBox12 = new TJSystem.Classes.PriComboBox();
			this.priTextBox5 = new TJSystem.Classes.PriTextBox();
			this.linkLabel8 = new System.Windows.Forms.LinkLabel();
			this.priTextBox13 = new TJSystem.Classes.PriTextBox();
			this.label49 = new System.Windows.Forms.Label();
			this.dataGrid1 = new System.Windows.Forms.DataGrid();
			this.dataGridTableStyle1 = new System.Windows.Forms.DataGridTableStyle();
			this.invoice_no = new System.Windows.Forms.DataGridTextBoxColumn();
			this.invoice_date = new System.Windows.Forms.DataGridTextBoxColumn();
			this.PAYMODE_NAME_CN = new System.Windows.Forms.DataGridTextBoxColumn();
			this.so_code = new System.Windows.Forms.DataGridTextBoxColumn();
			this.role_code = new System.Windows.Forms.DataGridTextBoxColumn();
			this.licence_no = new System.Windows.Forms.DataGridTextBoxColumn();
			this.imposetaxfree = new System.Windows.Forms.DataGridTextBoxColumn();
			this.TRADE_DESC = new System.Windows.Forms.DataGridTextBoxColumn();
			this.putonrecordno = new System.Windows.Forms.DataGridTextBoxColumn();
			this.pack_qty = new System.Windows.Forms.DataGridTextBoxColumn();
			this.sanctifiedno = new System.Windows.Forms.DataGridTextBoxColumn();
			this.priceterm_name = new System.Windows.Forms.DataGridTextBoxColumn();
			this.port_departure_name = new System.Windows.Forms.DataGridTextBoxColumn();
			this.COUNTRY_NAMECN = new System.Windows.Forms.DataGridTextBoxColumn();
			this.destport_name = new System.Windows.Forms.DataGridTextBoxColumn();
			this.port_transport_name = new System.Windows.Forms.DataGridTextBoxColumn();
			this.client_orderno = new System.Windows.Forms.DataGridTextBoxColumn();
			this.TRANS_NAMECN = new System.Windows.Forms.DataGridTextBoxColumn();
			this.transtools = new System.Windows.Forms.DataGridTextBoxColumn();
			this.freight = new System.Windows.Forms.DataGridTextBoxColumn();
			this.allowtransport = new System.Windows.Forms.DataGridTextBoxColumn();
			this.MaiTou = new System.Windows.Forms.DataGridTextBoxColumn();
			this.allowbatch = new System.Windows.Forms.DataGridTextBoxColumn();
			this.billloading = new System.Windows.Forms.DataGridTextBoxColumn();
			this.deliverydate = new System.Windows.Forms.DataGridTextBoxColumn();
			this.oceangoingvessel_notice = new System.Windows.Forms.DataGridTextBoxColumn();
			this.STATUS_NAME = new System.Windows.Forms.DataGridTextBoxColumn();
			this.approvedby = new System.Windows.Forms.DataGridTextBoxColumn();
			this.approvedon = new System.Windows.Forms.DataGridTextBoxColumn();
			this.company_name = new System.Windows.Forms.DataGridTextBoxColumn();
			this.shipper = new System.Windows.Forms.DataGridTextBoxColumn();
			this.exportdate = new System.Windows.Forms.DataGridTextBoxColumn();
			this.declaredate = new System.Windows.Forms.DataGridTextBoxColumn();
			this.lc_code = new System.Windows.Forms.DataGridTextBoxColumn();
			this.CURRENCY_NAMECN = new System.Windows.Forms.DataGridTextBoxColumn();
			this.bank = new System.Windows.Forms.DataGridTextBoxColumn();
			this.lc_date = new System.Windows.Forms.DataGridTextBoxColumn();
			this.validity = new System.Windows.Forms.DataGridTextBoxColumn();
			this.priceterm_dest = new System.Windows.Forms.DataGridTextBoxColumn();
			this.pay_term_name = new System.Windows.Forms.DataGridTextBoxColumn();
			this.client_id = new System.Windows.Forms.DataGridTextBoxColumn();
			this.client_name = new System.Windows.Forms.DataGridTextBoxColumn();
			this.proposer = new System.Windows.Forms.DataGridTextBoxColumn();
			this.consignee = new System.Windows.Forms.DataGridTextBoxColumn();
			this.notifier = new System.Windows.Forms.DataGridTextBoxColumn();
			this.createby = new System.Windows.Forms.DataGridTextBoxColumn();
			this.createon = new System.Windows.Forms.DataGridTextBoxColumn();
			this.modifyby = new System.Windows.Forms.DataGridTextBoxColumn();
			this.modifyon = new System.Windows.Forms.DataGridTextBoxColumn();
			this.button1 = new TJSystem.Classes.XpStyleButton();
			this.xpStyleButton1 = new TJSystem.Classes.XpStyleButton();
			this.xpStyleButton2 = new TJSystem.Classes.XpStyleButton();
			this.xpStyleButton3 = new TJSystem.Classes.XpStyleButton();
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
			this.label1.Text = "单证管理";
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
			this.panel4.Controls.Add(this.xpStyleButton3);
			this.panel4.Controls.Add(this.xpStyleButton2);
			this.panel4.Controls.Add(this.xpStyleButton1);
			this.panel4.Controls.Add(this.button1);
			this.panel4.Controls.Add(this.pictureBox1);
			this.panel4.Controls.Add(this.priTextBox12);
			this.panel4.Controls.Add(this.label30);
			this.panel4.Controls.Add(this.textBox2);
			this.panel4.Controls.Add(this.label33);
			this.panel4.Controls.Add(this.label29);
			this.panel4.Controls.Add(this.label23);
			this.panel4.Controls.Add(this.label22);
			this.panel4.Controls.Add(this.label9);
			this.panel4.Controls.Add(this.linkLabel4);
			this.panel4.Controls.Add(this.linkLabel3);
			this.panel4.Controls.Add(this.priComboBox1);
			this.panel4.Controls.Add(this.label37);
			this.panel4.Controls.Add(this.priTextBox29);
			this.panel4.Controls.Add(this.label36);
			this.panel4.Controls.Add(this.label35);
			this.panel4.Controls.Add(this.label32);
			this.panel4.Controls.Add(this.priTextBox25);
			this.panel4.Controls.Add(this.priTextBox4);
			this.panel4.Controls.Add(this.label24);
			this.panel4.Controls.Add(this.priTextBox20);
			this.panel4.Controls.Add(this.label25);
			this.panel4.Controls.Add(this.priTextBox21);
			this.panel4.Controls.Add(this.label26);
			this.panel4.Controls.Add(this.priTextBox22);
			this.panel4.Controls.Add(this.label27);
			this.panel4.Controls.Add(this.label28);
			this.panel4.Controls.Add(this.priTextBox23);
			this.panel4.Controls.Add(this.label21);
			this.panel4.Controls.Add(this.priTextBox17);
			this.panel4.Controls.Add(this.label19);
			this.panel4.Controls.Add(this.priTextBox15);
			this.panel4.Controls.Add(this.label18);
			this.panel4.Controls.Add(this.priTextBox14);
			this.panel4.Controls.Add(this.label16);
			this.panel4.Controls.Add(this.label17);
			this.panel4.Controls.Add(this.label15);
			this.panel4.Controls.Add(this.priTextBox11);
			this.panel4.Controls.Add(this.label14);
			this.panel4.Controls.Add(this.label13);
			this.panel4.Controls.Add(this.priTextBox10);
			this.panel4.Controls.Add(this.label12);
			this.panel4.Controls.Add(this.priTextBox9);
			this.panel4.Controls.Add(this.label11);
			this.panel4.Controls.Add(this.label10);
			this.panel4.Controls.Add(this.label6);
			this.panel4.Controls.Add(this.label7);
			this.panel4.Controls.Add(this.label8);
			this.panel4.Controls.Add(this.label5);
			this.panel4.Controls.Add(this.label4);
			this.panel4.Controls.Add(this.label3);
			this.panel4.Controls.Add(this.label2);
			this.panel4.Controls.Add(this.comboBox1);
			this.panel4.Controls.Add(this.textBox1);
			this.panel4.Controls.Add(this.priTextBox3);
			this.panel4.Controls.Add(this.label31);
			this.panel4.Controls.Add(this.label34);
			this.panel4.Controls.Add(this.priTextBox18);
			this.panel4.Controls.Add(this.label38);
			this.panel4.Controls.Add(this.label39);
			this.panel4.Controls.Add(this.priTextBox26);
			this.panel4.Controls.Add(this.priTextBox30);
			this.panel4.Controls.Add(this.label40);
			this.panel4.Controls.Add(this.label41);
			this.panel4.Controls.Add(this.label42);
			this.panel4.Controls.Add(this.priTextBox33);
			this.panel4.Controls.Add(this.label43);
			this.panel4.Controls.Add(this.label44);
			this.panel4.Controls.Add(this.priTextBox35);
			this.panel4.Controls.Add(this.label45);
			this.panel4.Controls.Add(this.priTextBox36);
			this.panel4.Controls.Add(this.label46);
			this.panel4.Controls.Add(this.linkLabel2);
			this.panel4.Controls.Add(this.priDateTimePicker1);
			this.panel4.Controls.Add(this.priDateTimePicker2);
			this.panel4.Controls.Add(this.priDateTimePicker3);
			this.panel4.Controls.Add(this.priComboBox2);
			this.panel4.Controls.Add(this.priComboBox3);
			this.panel4.Controls.Add(this.priComboBox4);
			this.panel4.Controls.Add(this.priComboBox5);
			this.panel4.Controls.Add(this.priComboBox7);
			this.panel4.Controls.Add(this.priComboBox8);
			this.panel4.Controls.Add(this.priDateTimePicker4);
			this.panel4.Controls.Add(this.priTextBox1);
			this.panel4.Controls.Add(this.priComboBox9);
			this.panel4.Controls.Add(this.priComboBox10);
			this.panel4.Controls.Add(this.priComboBox11);
			this.panel4.Controls.Add(this.priTextBox2);
			this.panel4.Controls.Add(this.priTextBox6);
			this.panel4.Controls.Add(this.priTextBox7);
			this.panel4.Controls.Add(this.priTextBox8);
			this.panel4.Controls.Add(this.priDateTimePicker5);
			this.panel4.Controls.Add(this.priComboBox12);
			this.panel4.Controls.Add(this.priTextBox5);
			this.panel4.Controls.Add(this.linkLabel8);
			this.panel4.Controls.Add(this.priTextBox13);
			this.panel4.Controls.Add(this.label49);
			this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel4.Location = new System.Drawing.Point(0, 0);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(788, 464);
			this.panel4.TabIndex = 0;
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
			this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pictureBox1.Location = new System.Drawing.Point(472, 344);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(296, 112);
			this.pictureBox1.TabIndex = 173;
			this.pictureBox1.TabStop = false;
			this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
			this.pictureBox1.DoubleClick += new System.EventHandler(this.pictureBox1_DoubleClick);
			// 
			// priTextBox12
			// 
			this.priTextBox12.BackColor = System.Drawing.Color.White;
			this.priTextBox12.DataField = "pack_qty";
			this.priTextBox12.DataType = TJSystem.Public.DataType.String;
			this.priTextBox12.Enabled = false;
			this.priTextBox12.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.priTextBox12.Location = new System.Drawing.Point(688, 144);
			this.priTextBox12.Name = "priTextBox12";
			this.priTextBox12.Size = new System.Drawing.Size(80, 23);
			this.priTextBox12.TabIndex = 172;
			this.priTextBox12.Text = "";
			// 
			// label30
			// 
			this.label30.BackColor = System.Drawing.Color.Transparent;
			this.label30.Location = new System.Drawing.Point(632, 144);
			this.label30.Name = "label30";
			this.label30.Size = new System.Drawing.Size(40, 23);
			this.label30.TabIndex = 171;
			this.label30.Text = "箱数";
			this.label30.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(200, 192);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(168, 23);
			this.textBox2.TabIndex = 167;
			this.textBox2.Text = "";
			// 
			// label33
			// 
			this.label33.BackColor = System.Drawing.Color.DarkOrange;
			this.label33.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.label33.Location = new System.Drawing.Point(392, 192);
			this.label33.Name = "label33";
			this.label33.Size = new System.Drawing.Size(80, 23);
			this.label33.TabIndex = 165;
			this.label33.Text = "信用证";
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
			this.label23.Text = "合同信息";
			this.label23.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label22
			// 
			this.label22.BackColor = System.Drawing.Color.DarkOrange;
			this.label22.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.label22.Location = new System.Drawing.Point(16, 216);
			this.label22.Name = "label22";
			this.label22.Size = new System.Drawing.Size(80, 23);
			this.label22.TabIndex = 162;
			this.label22.Text = "海关编码";
			this.label22.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.BackColor = System.Drawing.Color.Transparent;
			this.label9.ForeColor = System.Drawing.Color.Blue;
			this.label9.Location = new System.Drawing.Point(192, 336);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(63, 19);
			this.label9.TabIndex = 161;
			this.label9.Text = "装运日期";
			this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// linkLabel4
			// 
			this.linkLabel4.AutoSize = true;
			this.linkLabel4.BackColor = System.Drawing.Color.Transparent;
			this.linkLabel4.Location = new System.Drawing.Point(240, 216);
			this.linkLabel4.Name = "linkLabel4";
			this.linkLabel4.Size = new System.Drawing.Size(48, 19);
			this.linkLabel4.TabIndex = 158;
			this.linkLabel4.TabStop = true;
			this.linkLabel4.Text = "产地证";
			this.linkLabel4.Visible = false;
			// 
			// linkLabel3
			// 
			this.linkLabel3.AutoSize = true;
			this.linkLabel3.BackColor = System.Drawing.Color.Transparent;
			this.linkLabel3.Location = new System.Drawing.Point(168, 216);
			this.linkLabel3.Name = "linkLabel3";
			this.linkLabel3.Size = new System.Drawing.Size(63, 19);
			this.linkLabel3.TabIndex = 157;
			this.linkLabel3.TabStop = true;
			this.linkLabel3.Text = "单证条款";
			this.linkLabel3.Visible = false;
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
			this.label37.Location = new System.Drawing.Point(192, 312);
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
			this.priTextBox29.Location = new System.Drawing.Point(264, 312);
			this.priTextBox29.Name = "priTextBox29";
			this.priTextBox29.Size = new System.Drawing.Size(104, 23);
			this.priTextBox29.TabIndex = 152;
			this.priTextBox29.Text = "";
			// 
			// label36
			// 
			this.label36.AutoSize = true;
			this.label36.BackColor = System.Drawing.Color.Transparent;
			this.label36.ForeColor = System.Drawing.Color.Blue;
			this.label36.Location = new System.Drawing.Point(192, 288);
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
			this.label35.Location = new System.Drawing.Point(208, 264);
			this.label35.Name = "label35";
			this.label35.Size = new System.Drawing.Size(48, 19);
			this.label35.TabIndex = 147;
			this.label35.Text = "转运港";
			this.label35.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label32
			// 
			this.label32.AutoSize = true;
			this.label32.BackColor = System.Drawing.Color.Transparent;
			this.label32.ForeColor = System.Drawing.Color.Blue;
			this.label32.Location = new System.Drawing.Point(192, 144);
			this.label32.Name = "label32";
			this.label32.Size = new System.Drawing.Size(63, 19);
			this.label32.TabIndex = 138;
			this.label32.Text = "贸易性质";
			this.label32.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// priTextBox25
			// 
			this.priTextBox25.BackColor = System.Drawing.Color.White;
			this.priTextBox25.DataField = "putonrecordno";
			this.priTextBox25.DataType = TJSystem.Public.DataType.String;
			this.priTextBox25.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.priTextBox25.Location = new System.Drawing.Point(88, 168);
			this.priTextBox25.Name = "priTextBox25";
			this.priTextBox25.Size = new System.Drawing.Size(104, 23);
			this.priTextBox25.TabIndex = 128;
			this.priTextBox25.Text = "";
			// 
			// priTextBox4
			// 
			this.priTextBox4.BackColor = System.Drawing.Color.White;
			this.priTextBox4.DataField = "imposetaxfree";
			this.priTextBox4.DataType = TJSystem.Public.DataType.String;
			this.priTextBox4.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.priTextBox4.Location = new System.Drawing.Point(88, 144);
			this.priTextBox4.Name = "priTextBox4";
			this.priTextBox4.Size = new System.Drawing.Size(104, 23);
			this.priTextBox4.TabIndex = 127;
			this.priTextBox4.Text = "";
			// 
			// label24
			// 
			this.label24.BackColor = System.Drawing.Color.Transparent;
			this.label24.Location = new System.Drawing.Point(16, 360);
			this.label24.Name = "label24";
			this.label24.Size = new System.Drawing.Size(64, 23);
			this.label24.TabIndex = 124;
			this.label24.Text = "运单号";
			this.label24.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// priTextBox20
			// 
			this.priTextBox20.BackColor = System.Drawing.Color.White;
			this.priTextBox20.DataField = "billloading";
			this.priTextBox20.DataType = TJSystem.Public.DataType.String;
			this.priTextBox20.Enabled = false;
			this.priTextBox20.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.priTextBox20.Location = new System.Drawing.Point(88, 360);
			this.priTextBox20.Name = "priTextBox20";
			this.priTextBox20.Size = new System.Drawing.Size(104, 23);
			this.priTextBox20.TabIndex = 123;
			this.priTextBox20.Text = "";
			// 
			// label25
			// 
			this.label25.BackColor = System.Drawing.Color.Transparent;
			this.label25.Location = new System.Drawing.Point(400, 144);
			this.label25.Name = "label25";
			this.label25.Size = new System.Drawing.Size(64, 23);
			this.label25.TabIndex = 122;
			this.label25.Text = "装船人";
			this.label25.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// priTextBox21
			// 
			this.priTextBox21.BackColor = System.Drawing.Color.White;
			this.priTextBox21.DataField = "shipper";
			this.priTextBox21.DataType = TJSystem.Public.DataType.String;
			this.priTextBox21.Enabled = false;
			this.priTextBox21.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.priTextBox21.Location = new System.Drawing.Point(472, 144);
			this.priTextBox21.Name = "priTextBox21";
			this.priTextBox21.Size = new System.Drawing.Size(152, 23);
			this.priTextBox21.TabIndex = 121;
			this.priTextBox21.Text = "";
			// 
			// label26
			// 
			this.label26.BackColor = System.Drawing.Color.Transparent;
			this.label26.ForeColor = System.Drawing.Color.Blue;
			this.label26.Location = new System.Drawing.Point(384, 168);
			this.label26.Name = "label26";
			this.label26.Size = new System.Drawing.Size(80, 23);
			this.label26.TabIndex = 120;
			this.label26.Text = "出口日期";
			this.label26.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// priTextBox22
			// 
			this.priTextBox22.BackColor = System.Drawing.Color.White;
			this.priTextBox22.DataField = "oceangoingvessel_notice";
			this.priTextBox22.DataType = TJSystem.Public.DataType.String;
			this.priTextBox22.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.priTextBox22.Location = new System.Drawing.Point(24, 408);
			this.priTextBox22.Multiline = true;
			this.priTextBox22.Name = "priTextBox22";
			this.priTextBox22.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.priTextBox22.Size = new System.Drawing.Size(232, 48);
			this.priTextBox22.TabIndex = 125;
			this.priTextBox22.Text = "";
			// 
			// label27
			// 
			this.label27.BackColor = System.Drawing.Color.Transparent;
			this.label27.Location = new System.Drawing.Point(384, 120);
			this.label27.Name = "label27";
			this.label27.Size = new System.Drawing.Size(80, 23);
			this.label27.TabIndex = 119;
			this.label27.Text = "经营单位";
			this.label27.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label28
			// 
			this.label28.AutoSize = true;
			this.label28.BackColor = System.Drawing.Color.Transparent;
			this.label28.Location = new System.Drawing.Point(24, 384);
			this.label28.Name = "label28";
			this.label28.Size = new System.Drawing.Size(92, 19);
			this.label28.TabIndex = 118;
			this.label28.Text = "外轮注意事项";
			this.label28.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// priTextBox23
			// 
			this.priTextBox23.BackColor = System.Drawing.Color.White;
			this.priTextBox23.DataField = "company_name";
			this.priTextBox23.DataType = TJSystem.Public.DataType.String;
			this.priTextBox23.Enabled = false;
			this.priTextBox23.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.priTextBox23.Location = new System.Drawing.Point(472, 120);
			this.priTextBox23.Name = "priTextBox23";
			this.priTextBox23.Size = new System.Drawing.Size(296, 23);
			this.priTextBox23.TabIndex = 117;
			this.priTextBox23.Text = "";
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
			// label19
			// 
			this.label19.BackColor = System.Drawing.Color.Transparent;
			this.label19.Location = new System.Drawing.Point(192, 168);
			this.label19.Name = "label19";
			this.label19.Size = new System.Drawing.Size(64, 23);
			this.label19.TabIndex = 39;
			this.label19.Text = "批准文号";
			this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// priTextBox15
			// 
			this.priTextBox15.BackColor = System.Drawing.Color.White;
			this.priTextBox15.DataField = "sanctifiedno";
			this.priTextBox15.DataType = TJSystem.Public.DataType.String;
			this.priTextBox15.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.priTextBox15.Location = new System.Drawing.Point(264, 168);
			this.priTextBox15.Name = "priTextBox15";
			this.priTextBox15.Size = new System.Drawing.Size(104, 23);
			this.priTextBox15.TabIndex = 38;
			this.priTextBox15.Text = "";
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
			this.label17.Location = new System.Drawing.Point(208, 240);
			this.label17.Name = "label17";
			this.label17.Size = new System.Drawing.Size(48, 19);
			this.label17.TabIndex = 31;
			this.label17.Text = "运抵国";
			this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label15
			// 
			this.label15.AutoSize = true;
			this.label15.BackColor = System.Drawing.Color.Transparent;
			this.label15.Location = new System.Drawing.Point(192, 120);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(63, 19);
			this.label15.TabIndex = 29;
			this.label15.Text = "许可证号";
			this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// priTextBox11
			// 
			this.priTextBox11.BackColor = System.Drawing.Color.White;
			this.priTextBox11.DataField = "licence_no";
			this.priTextBox11.DataType = TJSystem.Public.DataType.String;
			this.priTextBox11.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.priTextBox11.Location = new System.Drawing.Point(264, 120);
			this.priTextBox11.Name = "priTextBox11";
			this.priTextBox11.Size = new System.Drawing.Size(104, 23);
			this.priTextBox11.TabIndex = 28;
			this.priTextBox11.Text = "";
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
			this.label13.Location = new System.Drawing.Point(0, 312);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(80, 23);
			this.label13.TabIndex = 26;
			this.label13.Text = "运输工具";
			this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// priTextBox10
			// 
			this.priTextBox10.BackColor = System.Drawing.Color.White;
			this.priTextBox10.DataField = "transtools";
			this.priTextBox10.DataType = TJSystem.Public.DataType.String;
			this.priTextBox10.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.priTextBox10.Location = new System.Drawing.Point(88, 312);
			this.priTextBox10.Name = "priTextBox10";
			this.priTextBox10.Size = new System.Drawing.Size(104, 23);
			this.priTextBox10.TabIndex = 25;
			this.priTextBox10.Text = "";
			// 
			// label12
			// 
			this.label12.BackColor = System.Drawing.Color.Transparent;
			this.label12.Location = new System.Drawing.Point(24, 288);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(56, 23);
			this.label12.TabIndex = 24;
			this.label12.Text = "提单号";
			this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// priTextBox9
			// 
			this.priTextBox9.BackColor = System.Drawing.Color.White;
			this.priTextBox9.DataField = "client_orderno";
			this.priTextBox9.DataType = TJSystem.Public.DataType.String;
			this.priTextBox9.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.priTextBox9.Location = new System.Drawing.Point(88, 288);
			this.priTextBox9.Name = "priTextBox9";
			this.priTextBox9.Size = new System.Drawing.Size(104, 23);
			this.priTextBox9.TabIndex = 23;
			this.priTextBox9.Text = "";
			// 
			// label11
			// 
			this.label11.BackColor = System.Drawing.Color.Transparent;
			this.label11.ForeColor = System.Drawing.Color.Blue;
			this.label11.Location = new System.Drawing.Point(24, 264);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(56, 23);
			this.label11.TabIndex = 22;
			this.label11.Text = "目的港";
			this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label10
			// 
			this.label10.BackColor = System.Drawing.Color.Transparent;
			this.label10.ForeColor = System.Drawing.Color.Blue;
			this.label10.Location = new System.Drawing.Point(0, 192);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(80, 23);
			this.label10.TabIndex = 20;
			this.label10.Text = "价格条款";
			this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label6
			// 
			this.label6.BackColor = System.Drawing.Color.Transparent;
			this.label6.Location = new System.Drawing.Point(16, 168);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(64, 23);
			this.label6.TabIndex = 17;
			this.label6.Text = "备案号";
			this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label7
			// 
			this.label7.BackColor = System.Drawing.Color.Transparent;
			this.label7.Location = new System.Drawing.Point(8, 144);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(72, 23);
			this.label7.TabIndex = 16;
			this.label7.Text = "征免性质";
			this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.BackColor = System.Drawing.Color.Transparent;
			this.label8.Location = new System.Drawing.Point(16, 336);
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
			this.label5.Location = new System.Drawing.Point(16, 240);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(64, 23);
			this.label5.TabIndex = 9;
			this.label5.Text = "起运港";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label4
			// 
			this.label4.BackColor = System.Drawing.Color.Transparent;
			this.label4.Location = new System.Drawing.Point(8, 120);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(72, 23);
			this.label4.TabIndex = 8;
			this.label4.Text = "核销单号";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label3
			// 
			this.label3.BackColor = System.Drawing.Color.Transparent;
			this.label3.ForeColor = System.Drawing.Color.Blue;
			this.label3.Location = new System.Drawing.Point(16, 96);
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
			this.label2.Text = "发票号";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// comboBox1
			// 
			this.comboBox1.BackColor = System.Drawing.Color.White;
			this.comboBox1.DataField = "port_departure";
			this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBox1.Location = new System.Drawing.Point(88, 240);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(104, 22);
			this.comboBox1.TabIndex = 4;
			// 
			// textBox1
			// 
			this.textBox1.BackColor = System.Drawing.Color.White;
			this.textBox1.DataField = "invoice_no";
			this.textBox1.DataType = TJSystem.Public.DataType.String;
			this.textBox1.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.textBox1.Location = new System.Drawing.Point(88, 72);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(104, 23);
			this.textBox1.TabIndex = 1;
			this.textBox1.Text = "";
			this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
			// 
			// priTextBox3
			// 
			this.priTextBox3.BackColor = System.Drawing.Color.White;
			this.priTextBox3.DataField = "role_code";
			this.priTextBox3.DataType = TJSystem.Public.DataType.String;
			this.priTextBox3.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.priTextBox3.Location = new System.Drawing.Point(88, 120);
			this.priTextBox3.Name = "priTextBox3";
			this.priTextBox3.Size = new System.Drawing.Size(104, 23);
			this.priTextBox3.TabIndex = 3;
			this.priTextBox3.Text = "";
			// 
			// label31
			// 
			this.label31.AutoSize = true;
			this.label31.BackColor = System.Drawing.Color.Transparent;
			this.label31.ForeColor = System.Drawing.Color.Blue;
			this.label31.Location = new System.Drawing.Point(584, 168);
			this.label31.Name = "label31";
			this.label31.Size = new System.Drawing.Size(63, 19);
			this.label31.TabIndex = 41;
			this.label31.Text = "申报日期";
			this.label31.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label34
			// 
			this.label34.BackColor = System.Drawing.Color.Transparent;
			this.label34.Location = new System.Drawing.Point(384, 216);
			this.label34.Name = "label34";
			this.label34.Size = new System.Drawing.Size(80, 23);
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
			this.priTextBox18.Location = new System.Drawing.Point(472, 216);
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
			this.label38.Location = new System.Drawing.Point(600, 216);
			this.label38.Name = "label38";
			this.label38.Size = new System.Drawing.Size(48, 19);
			this.label38.TabIndex = 41;
			this.label38.Text = "币  种";
			this.label38.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label39
			// 
			this.label39.BackColor = System.Drawing.Color.Transparent;
			this.label39.Location = new System.Drawing.Point(384, 240);
			this.label39.Name = "label39";
			this.label39.Size = new System.Drawing.Size(80, 23);
			this.label39.TabIndex = 119;
			this.label39.Text = "开证银行";
			this.label39.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// priTextBox26
			// 
			this.priTextBox26.BackColor = System.Drawing.Color.White;
			this.priTextBox26.DataField = "bank";
			this.priTextBox26.DataType = TJSystem.Public.DataType.String;
			this.priTextBox26.Enabled = false;
			this.priTextBox26.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.priTextBox26.Location = new System.Drawing.Point(472, 240);
			this.priTextBox26.Name = "priTextBox26";
			this.priTextBox26.Size = new System.Drawing.Size(296, 23);
			this.priTextBox26.TabIndex = 117;
			this.priTextBox26.Text = "";
			// 
			// priTextBox30
			// 
			this.priTextBox30.BackColor = System.Drawing.Color.White;
			this.priTextBox30.DataField = "validity";
			this.priTextBox30.DataType = TJSystem.Public.DataType.String;
			this.priTextBox30.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.priTextBox30.Location = new System.Drawing.Point(656, 264);
			this.priTextBox30.Name = "priTextBox30";
			this.priTextBox30.Size = new System.Drawing.Size(112, 23);
			this.priTextBox30.TabIndex = 40;
			this.priTextBox30.Text = "";
			// 
			// label40
			// 
			this.label40.BackColor = System.Drawing.Color.Transparent;
			this.label40.ForeColor = System.Drawing.Color.Blue;
			this.label40.Location = new System.Drawing.Point(384, 264);
			this.label40.Name = "label40";
			this.label40.Size = new System.Drawing.Size(80, 23);
			this.label40.TabIndex = 35;
			this.label40.Text = "开证日期";
			this.label40.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label41
			// 
			this.label41.AutoSize = true;
			this.label41.BackColor = System.Drawing.Color.Transparent;
			this.label41.Location = new System.Drawing.Point(600, 264);
			this.label41.Name = "label41";
			this.label41.Size = new System.Drawing.Size(48, 19);
			this.label41.TabIndex = 41;
			this.label41.Text = "有效期";
			this.label41.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label42
			// 
			this.label42.BackColor = System.Drawing.Color.Transparent;
			this.label42.Location = new System.Drawing.Point(591, 72);
			this.label42.Name = "label42";
			this.label42.Size = new System.Drawing.Size(56, 23);
			this.label42.TabIndex = 35;
			this.label42.Text = "交货期";
			this.label42.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// priTextBox33
			// 
			this.priTextBox33.BackColor = System.Drawing.Color.White;
			this.priTextBox33.DataField = "priceterm_dest";
			this.priTextBox33.DataType = TJSystem.Public.DataType.String;
			this.priTextBox33.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.priTextBox33.Location = new System.Drawing.Point(648, 72);
			this.priTextBox33.Name = "priTextBox33";
			this.priTextBox33.Size = new System.Drawing.Size(120, 23);
			this.priTextBox33.TabIndex = 34;
			this.priTextBox33.Text = "";
			// 
			// label43
			// 
			this.label43.AutoSize = true;
			this.label43.BackColor = System.Drawing.Color.Transparent;
			this.label43.ForeColor = System.Drawing.Color.Blue;
			this.label43.Location = new System.Drawing.Point(584, 288);
			this.label43.Name = "label43";
			this.label43.Size = new System.Drawing.Size(63, 19);
			this.label43.TabIndex = 41;
			this.label43.Text = "付款条款";
			this.label43.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label44
			// 
			this.label44.BackColor = System.Drawing.Color.Transparent;
			this.label44.ForeColor = System.Drawing.Color.Blue;
			this.label44.Location = new System.Drawing.Point(384, 312);
			this.label44.Name = "label44";
			this.label44.Size = new System.Drawing.Size(80, 23);
			this.label44.TabIndex = 119;
			this.label44.Text = "客户代码";
			this.label44.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// priTextBox35
			// 
			this.priTextBox35.BackColor = System.Drawing.Color.White;
			this.priTextBox35.DataField = "client_name";
			this.priTextBox35.DataType = TJSystem.Public.DataType.String;
			this.priTextBox35.Enabled = false;
			this.priTextBox35.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.priTextBox35.Location = new System.Drawing.Point(656, 312);
			this.priTextBox35.Name = "priTextBox35";
			this.priTextBox35.Size = new System.Drawing.Size(112, 23);
			this.priTextBox35.TabIndex = 117;
			this.priTextBox35.Text = "";
			// 
			// label45
			// 
			this.label45.BackColor = System.Drawing.Color.Transparent;
			this.label45.Location = new System.Drawing.Point(584, 312);
			this.label45.Name = "label45";
			this.label45.Size = new System.Drawing.Size(64, 23);
			this.label45.TabIndex = 119;
			this.label45.Text = "客户名称";
			this.label45.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// priTextBox36
			// 
			this.priTextBox36.BackColor = System.Drawing.Color.White;
			this.priTextBox36.DataField = "proposer";
			this.priTextBox36.DataType = TJSystem.Public.DataType.String;
			this.priTextBox36.Enabled = false;
			this.priTextBox36.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.priTextBox36.Location = new System.Drawing.Point(472, 288);
			this.priTextBox36.Name = "priTextBox36";
			this.priTextBox36.Size = new System.Drawing.Size(104, 23);
			this.priTextBox36.TabIndex = 117;
			this.priTextBox36.Text = "";
			// 
			// label46
			// 
			this.label46.BackColor = System.Drawing.Color.Transparent;
			this.label46.Location = new System.Drawing.Point(384, 288);
			this.label46.Name = "label46";
			this.label46.Size = new System.Drawing.Size(80, 23);
			this.label46.TabIndex = 119;
			this.label46.Text = "申请人";
			this.label46.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// linkLabel2
			// 
			this.linkLabel2.AutoSize = true;
			this.linkLabel2.BackColor = System.Drawing.Color.Transparent;
			this.linkLabel2.Location = new System.Drawing.Point(104, 216);
			this.linkLabel2.Name = "linkLabel2";
			this.linkLabel2.Size = new System.Drawing.Size(63, 19);
			this.linkLabel2.TabIndex = 158;
			this.linkLabel2.TabStop = true;
			this.linkLabel2.Text = "委托报关";
			this.linkLabel2.Visible = false;
			// 
			// priDateTimePicker1
			// 
			this.priDateTimePicker1.CustomFormat = "yyyy-MM-dd";
			this.priDateTimePicker1.DataField = "exportdate";
			this.priDateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.priDateTimePicker1.Location = new System.Drawing.Point(472, 168);
			this.priDateTimePicker1.Name = "priDateTimePicker1";
			this.priDateTimePicker1.Size = new System.Drawing.Size(104, 23);
			this.priDateTimePicker1.TabIndex = 166;
			// 
			// priDateTimePicker2
			// 
			this.priDateTimePicker2.CustomFormat = "yyyy-MM-dd";
			this.priDateTimePicker2.DataField = "declaredate";
			this.priDateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.priDateTimePicker2.Location = new System.Drawing.Point(656, 168);
			this.priDateTimePicker2.Name = "priDateTimePicker2";
			this.priDateTimePicker2.Size = new System.Drawing.Size(112, 23);
			this.priDateTimePicker2.TabIndex = 166;
			// 
			// priDateTimePicker3
			// 
			this.priDateTimePicker3.CustomFormat = "yyyy-MM-dd";
			this.priDateTimePicker3.DataField = "invoice_date";
			this.priDateTimePicker3.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.priDateTimePicker3.Location = new System.Drawing.Point(264, 72);
			this.priDateTimePicker3.Name = "priDateTimePicker3";
			this.priDateTimePicker3.Size = new System.Drawing.Size(104, 23);
			this.priDateTimePicker3.TabIndex = 166;
			// 
			// priComboBox2
			// 
			this.priComboBox2.BackColor = System.Drawing.Color.White;
			this.priComboBox2.DataField = "trade_character";
			this.priComboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.priComboBox2.Location = new System.Drawing.Point(264, 144);
			this.priComboBox2.Name = "priComboBox2";
			this.priComboBox2.Size = new System.Drawing.Size(104, 22);
			this.priComboBox2.TabIndex = 154;
			// 
			// priComboBox3
			// 
			this.priComboBox3.BackColor = System.Drawing.Color.White;
			this.priComboBox3.DataField = "settlementtype";
			this.priComboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.priComboBox3.Location = new System.Drawing.Point(88, 96);
			this.priComboBox3.Name = "priComboBox3";
			this.priComboBox3.Size = new System.Drawing.Size(104, 22);
			this.priComboBox3.TabIndex = 154;
			// 
			// priComboBox4
			// 
			this.priComboBox4.BackColor = System.Drawing.Color.White;
			this.priComboBox4.DataField = "arrivecountry";
			this.priComboBox4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.priComboBox4.Location = new System.Drawing.Point(264, 240);
			this.priComboBox4.Name = "priComboBox4";
			this.priComboBox4.Size = new System.Drawing.Size(104, 22);
			this.priComboBox4.TabIndex = 154;
			// 
			// priComboBox5
			// 
			this.priComboBox5.BackColor = System.Drawing.Color.White;
			this.priComboBox5.DataField = "port_transport";
			this.priComboBox5.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.priComboBox5.Location = new System.Drawing.Point(264, 264);
			this.priComboBox5.Name = "priComboBox5";
			this.priComboBox5.Size = new System.Drawing.Size(104, 22);
			this.priComboBox5.TabIndex = 154;
			// 
			// priComboBox7
			// 
			this.priComboBox7.BackColor = System.Drawing.Color.White;
			this.priComboBox7.DataField = "transtype";
			this.priComboBox7.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.priComboBox7.Location = new System.Drawing.Point(264, 288);
			this.priComboBox7.Name = "priComboBox7";
			this.priComboBox7.Size = new System.Drawing.Size(104, 22);
			this.priComboBox7.TabIndex = 154;
			// 
			// priComboBox8
			// 
			this.priComboBox8.BackColor = System.Drawing.Color.White;
			this.priComboBox8.DataField = "destport";
			this.priComboBox8.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.priComboBox8.Location = new System.Drawing.Point(88, 264);
			this.priComboBox8.Name = "priComboBox8";
			this.priComboBox8.Size = new System.Drawing.Size(104, 22);
			this.priComboBox8.TabIndex = 154;
			// 
			// priDateTimePicker4
			// 
			this.priDateTimePicker4.CustomFormat = "yyyy-MM-dd";
			this.priDateTimePicker4.DataField = "deliverydate";
			this.priDateTimePicker4.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.priDateTimePicker4.Location = new System.Drawing.Point(264, 336);
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
			this.priTextBox1.Location = new System.Drawing.Point(88, 336);
			this.priTextBox1.Name = "priTextBox1";
			this.priTextBox1.Size = new System.Drawing.Size(104, 23);
			this.priTextBox1.TabIndex = 25;
			this.priTextBox1.Text = "";
			// 
			// priComboBox9
			// 
			this.priComboBox9.BackColor = System.Drawing.Color.White;
			this.priComboBox9.DataField = "pay_term";
			this.priComboBox9.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.priComboBox9.Location = new System.Drawing.Point(656, 288);
			this.priComboBox9.Name = "priComboBox9";
			this.priComboBox9.Size = new System.Drawing.Size(112, 22);
			this.priComboBox9.TabIndex = 154;
			// 
			// priComboBox10
			// 
			this.priComboBox10.BackColor = System.Drawing.Color.White;
			this.priComboBox10.DataField = "client_id";
			this.priComboBox10.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.priComboBox10.Location = new System.Drawing.Point(472, 312);
			this.priComboBox10.Name = "priComboBox10";
			this.priComboBox10.Size = new System.Drawing.Size(104, 22);
			this.priComboBox10.TabIndex = 154;
			this.priComboBox10.SelectionChangeCommitted += new System.EventHandler(this.priComboBox10_SelectionChangeCommitted);
			// 
			// priComboBox11
			// 
			this.priComboBox11.BackColor = System.Drawing.Color.White;
			this.priComboBox11.DataField = "priceterm";
			this.priComboBox11.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.priComboBox11.Location = new System.Drawing.Point(88, 192);
			this.priComboBox11.Name = "priComboBox11";
			this.priComboBox11.Size = new System.Drawing.Size(104, 22);
			this.priComboBox11.TabIndex = 154;
			this.priComboBox11.SelectionChangeCommitted += new System.EventHandler(this.priComboBox11_SelectionChangeCommitted);
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
			// priDateTimePicker5
			// 
			this.priDateTimePicker5.CustomFormat = "yyyy-MM-dd";
			this.priDateTimePicker5.DataField = "lc_date";
			this.priDateTimePicker5.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.priDateTimePicker5.Location = new System.Drawing.Point(472, 264);
			this.priDateTimePicker5.Name = "priDateTimePicker5";
			this.priDateTimePicker5.Size = new System.Drawing.Size(104, 23);
			this.priDateTimePicker5.TabIndex = 166;
			// 
			// priComboBox12
			// 
			this.priComboBox12.BackColor = System.Drawing.Color.White;
			this.priComboBox12.DataField = "currency";
			this.priComboBox12.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.priComboBox12.Location = new System.Drawing.Point(656, 216);
			this.priComboBox12.Name = "priComboBox12";
			this.priComboBox12.Size = new System.Drawing.Size(112, 22);
			this.priComboBox12.TabIndex = 154;
			// 
			// priTextBox5
			// 
			this.priTextBox5.BackColor = System.Drawing.Color.White;
			this.priTextBox5.DataField = "so_code";
			this.priTextBox5.DataType = TJSystem.Public.DataType.String;
			this.priTextBox5.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.priTextBox5.Location = new System.Drawing.Point(264, 96);
			this.priTextBox5.Name = "priTextBox5";
			this.priTextBox5.Size = new System.Drawing.Size(104, 23);
			this.priTextBox5.TabIndex = 28;
			this.priTextBox5.Text = "";
			// 
			// linkLabel8
			// 
			this.linkLabel8.AutoSize = true;
			this.linkLabel8.BackColor = System.Drawing.Color.Transparent;
			this.linkLabel8.Location = new System.Drawing.Point(192, 96);
			this.linkLabel8.Name = "linkLabel8";
			this.linkLabel8.Size = new System.Drawing.Size(63, 19);
			this.linkLabel8.TabIndex = 155;
			this.linkLabel8.TabStop = true;
			this.linkLabel8.Text = "销售单号";
			this.linkLabel8.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel8_LinkClicked);
			// 
			// priTextBox13
			// 
			this.priTextBox13.BackColor = System.Drawing.Color.White;
			this.priTextBox13.DataField = "MaiTou";
			this.priTextBox13.DataType = TJSystem.Public.DataType.String;
			this.priTextBox13.Enabled = false;
			this.priTextBox13.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.priTextBox13.Location = new System.Drawing.Point(24, 480);
			this.priTextBox13.Multiline = true;
			this.priTextBox13.Name = "priTextBox13";
			this.priTextBox13.Size = new System.Drawing.Size(296, 16);
			this.priTextBox13.TabIndex = 172;
			this.priTextBox13.Text = "";
			// 
			// label49
			// 
			this.label49.BackColor = System.Drawing.Color.Transparent;
			this.label49.Location = new System.Drawing.Point(424, 344);
			this.label49.Name = "label49";
			this.label49.Size = new System.Drawing.Size(40, 23);
			this.label49.TabIndex = 171;
			this.label49.Text = "唛头";
			this.label49.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
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
			this.dataGrid1.Location = new System.Drawing.Point(0, 472);
			this.dataGrid1.Name = "dataGrid1";
			this.dataGrid1.ReadOnly = true;
			this.dataGrid1.Size = new System.Drawing.Size(784, 48);
			this.dataGrid1.TabIndex = 0;
			this.dataGrid1.TableStyles.AddRange(new System.Windows.Forms.DataGridTableStyle[] {
																								  this.dataGridTableStyle1});
			// 
			// dataGridTableStyle1
			// 
			this.dataGridTableStyle1.AllowSorting = false;
			this.dataGridTableStyle1.DataGrid = this.dataGrid1;
			this.dataGridTableStyle1.GridColumnStyles.AddRange(new System.Windows.Forms.DataGridColumnStyle[] {
																												  this.invoice_no,
																												  this.invoice_date,
																												  this.PAYMODE_NAME_CN,
																												  this.so_code,
																												  this.role_code,
																												  this.licence_no,
																												  this.imposetaxfree,
																												  this.TRADE_DESC,
																												  this.putonrecordno,
																												  this.pack_qty,
																												  this.sanctifiedno,
																												  this.priceterm_name,
																												  this.port_departure_name,
																												  this.COUNTRY_NAMECN,
																												  this.destport_name,
																												  this.port_transport_name,
																												  this.client_orderno,
																												  this.TRANS_NAMECN,
																												  this.transtools,
																												  this.freight,
																												  this.allowtransport,
																												  this.MaiTou,
																												  this.allowbatch,
																												  this.billloading,
																												  this.deliverydate,
																												  this.oceangoingvessel_notice,
																												  this.STATUS_NAME,
																												  this.approvedby,
																												  this.approvedon,
																												  this.company_name,
																												  this.shipper,
																												  this.exportdate,
																												  this.declaredate,
																												  this.lc_code,
																												  this.CURRENCY_NAMECN,
																												  this.bank,
																												  this.lc_date,
																												  this.validity,
																												  this.priceterm_dest,
																												  this.pay_term_name,
																												  this.client_id,
																												  this.client_name,
																												  this.proposer,
																												  this.consignee,
																												  this.notifier,
																												  this.createby,
																												  this.createon,
																												  this.modifyby,
																												  this.modifyon});
			this.dataGridTableStyle1.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.dataGridTableStyle1.MappingName = "sale_doc_master";
			this.dataGridTableStyle1.ReadOnly = true;
			// 
			// invoice_no
			// 
			this.invoice_no.Format = "";
			this.invoice_no.FormatInfo = null;
			this.invoice_no.HeaderText = "发票号";
			this.invoice_no.MappingName = "invoice_no";
			this.invoice_no.NullText = "";
			this.invoice_no.Width = 75;
			// 
			// invoice_date
			// 
			this.invoice_date.Format = "";
			this.invoice_date.FormatInfo = null;
			this.invoice_date.HeaderText = "发票日期";
			this.invoice_date.MappingName = "invoice_date";
			this.invoice_date.NullText = "";
			this.invoice_date.Width = 75;
			// 
			// PAYMODE_NAME_CN
			// 
			this.PAYMODE_NAME_CN.Format = "";
			this.PAYMODE_NAME_CN.FormatInfo = null;
			this.PAYMODE_NAME_CN.HeaderText = "结汇方式";
			this.PAYMODE_NAME_CN.MappingName = "PAYMODE_NAME_CN";
			this.PAYMODE_NAME_CN.NullText = "";
			this.PAYMODE_NAME_CN.Width = 75;
			// 
			// so_code
			// 
			this.so_code.Format = "";
			this.so_code.FormatInfo = null;
			this.so_code.HeaderText = "销售单号";
			this.so_code.MappingName = "so_code";
			this.so_code.NullText = "";
			this.so_code.Width = 75;
			// 
			// role_code
			// 
			this.role_code.Format = "";
			this.role_code.FormatInfo = null;
			this.role_code.HeaderText = "核销单号";
			this.role_code.MappingName = "role_code";
			this.role_code.NullText = "";
			this.role_code.Width = 75;
			// 
			// licence_no
			// 
			this.licence_no.Format = "";
			this.licence_no.FormatInfo = null;
			this.licence_no.HeaderText = "许可证号";
			this.licence_no.MappingName = "licence_no";
			this.licence_no.NullText = "";
			this.licence_no.Width = 75;
			// 
			// imposetaxfree
			// 
			this.imposetaxfree.Format = "";
			this.imposetaxfree.FormatInfo = null;
			this.imposetaxfree.HeaderText = "征免性质";
			this.imposetaxfree.MappingName = "imposetaxfree";
			this.imposetaxfree.NullText = "";
			this.imposetaxfree.Width = 75;
			// 
			// TRADE_DESC
			// 
			this.TRADE_DESC.Format = "";
			this.TRADE_DESC.FormatInfo = null;
			this.TRADE_DESC.HeaderText = "贸易性质";
			this.TRADE_DESC.MappingName = "TRADE_DESC";
			this.TRADE_DESC.NullText = "";
			this.TRADE_DESC.Width = 75;
			// 
			// putonrecordno
			// 
			this.putonrecordno.Format = "";
			this.putonrecordno.FormatInfo = null;
			this.putonrecordno.HeaderText = "备案号";
			this.putonrecordno.MappingName = "putonrecordno";
			this.putonrecordno.NullText = "";
			this.putonrecordno.Width = 75;
			// 
			// pack_qty
			// 
			this.pack_qty.Format = "";
			this.pack_qty.FormatInfo = null;
			this.pack_qty.HeaderText = "箱数";
			this.pack_qty.MappingName = "pack_qty";
			this.pack_qty.NullText = "";
			this.pack_qty.Width = 75;
			// 
			// sanctifiedno
			// 
			this.sanctifiedno.Format = "";
			this.sanctifiedno.FormatInfo = null;
			this.sanctifiedno.HeaderText = "批准文号";
			this.sanctifiedno.MappingName = "sanctifiedno";
			this.sanctifiedno.NullText = "";
			this.sanctifiedno.Width = 75;
			// 
			// priceterm_name
			// 
			this.priceterm_name.Format = "";
			this.priceterm_name.FormatInfo = null;
			this.priceterm_name.HeaderText = "价格条款";
			this.priceterm_name.MappingName = "priceterm_name";
			this.priceterm_name.NullText = "";
			this.priceterm_name.Width = 75;
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
			// COUNTRY_NAMECN
			// 
			this.COUNTRY_NAMECN.Format = "";
			this.COUNTRY_NAMECN.FormatInfo = null;
			this.COUNTRY_NAMECN.HeaderText = "运抵国";
			this.COUNTRY_NAMECN.MappingName = "COUNTRY_NAMECN";
			this.COUNTRY_NAMECN.NullText = "";
			this.COUNTRY_NAMECN.Width = 75;
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
			// client_orderno
			// 
			this.client_orderno.Format = "";
			this.client_orderno.FormatInfo = null;
			this.client_orderno.HeaderText = "提单号";
			this.client_orderno.MappingName = "client_orderno";
			this.client_orderno.NullText = "";
			this.client_orderno.Width = 75;
			// 
			// TRANS_NAMECN
			// 
			this.TRANS_NAMECN.Format = "";
			this.TRANS_NAMECN.FormatInfo = null;
			this.TRANS_NAMECN.HeaderText = "运输方式";
			this.TRANS_NAMECN.MappingName = "TRANS_NAMECN";
			this.TRANS_NAMECN.NullText = "";
			this.TRANS_NAMECN.Width = 75;
			// 
			// transtools
			// 
			this.transtools.Format = "";
			this.transtools.FormatInfo = null;
			this.transtools.HeaderText = "运输工具";
			this.transtools.MappingName = "transtools";
			this.transtools.NullText = "";
			this.transtools.Width = 75;
			// 
			// freight
			// 
			this.freight.Format = "";
			this.freight.FormatInfo = null;
			this.freight.HeaderText = "运费";
			this.freight.MappingName = "freight";
			this.freight.NullText = "";
			this.freight.Width = 75;
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
			// MaiTou
			// 
			this.MaiTou.Format = "";
			this.MaiTou.FormatInfo = null;
			this.MaiTou.HeaderText = "唛头";
			this.MaiTou.MappingName = "MaiTou";
			this.MaiTou.NullText = "";
			this.MaiTou.Width = 75;
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
			// billloading
			// 
			this.billloading.Format = "";
			this.billloading.FormatInfo = null;
			this.billloading.HeaderText = "运单号";
			this.billloading.MappingName = "billloading";
			this.billloading.NullText = "";
			this.billloading.Width = 75;
			// 
			// deliverydate
			// 
			this.deliverydate.Format = "";
			this.deliverydate.FormatInfo = null;
			this.deliverydate.HeaderText = "装运日期";
			this.deliverydate.MappingName = "deliverydate";
			this.deliverydate.NullText = "";
			this.deliverydate.Width = 75;
			// 
			// oceangoingvessel_notice
			// 
			this.oceangoingvessel_notice.Format = "";
			this.oceangoingvessel_notice.FormatInfo = null;
			this.oceangoingvessel_notice.HeaderText = "外轮注意事项";
			this.oceangoingvessel_notice.MappingName = "oceangoingvessel_notice";
			this.oceangoingvessel_notice.NullText = "";
			this.oceangoingvessel_notice.Width = 75;
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
			// company_name
			// 
			this.company_name.Format = "";
			this.company_name.FormatInfo = null;
			this.company_name.HeaderText = "经营单位";
			this.company_name.MappingName = "company_name";
			this.company_name.NullText = "";
			this.company_name.Width = 75;
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
			// exportdate
			// 
			this.exportdate.Format = "";
			this.exportdate.FormatInfo = null;
			this.exportdate.HeaderText = "出口日期";
			this.exportdate.MappingName = "exportdate";
			this.exportdate.NullText = "";
			this.exportdate.Width = 75;
			// 
			// declaredate
			// 
			this.declaredate.Format = "";
			this.declaredate.FormatInfo = null;
			this.declaredate.HeaderText = "申报日期";
			this.declaredate.MappingName = "declaredate";
			this.declaredate.NullText = "";
			this.declaredate.Width = 75;
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
			// CURRENCY_NAMECN
			// 
			this.CURRENCY_NAMECN.Format = "";
			this.CURRENCY_NAMECN.FormatInfo = null;
			this.CURRENCY_NAMECN.HeaderText = "币种";
			this.CURRENCY_NAMECN.MappingName = "CURRENCY_NAMECN";
			this.CURRENCY_NAMECN.NullText = "";
			this.CURRENCY_NAMECN.Width = 75;
			// 
			// bank
			// 
			this.bank.Format = "";
			this.bank.FormatInfo = null;
			this.bank.HeaderText = "开证银行";
			this.bank.MappingName = "bank";
			this.bank.NullText = "";
			this.bank.Width = 75;
			// 
			// lc_date
			// 
			this.lc_date.Format = "";
			this.lc_date.FormatInfo = null;
			this.lc_date.HeaderText = "开证日期";
			this.lc_date.MappingName = "lc_date";
			this.lc_date.NullText = "";
			this.lc_date.Width = 75;
			// 
			// validity
			// 
			this.validity.Format = "";
			this.validity.FormatInfo = null;
			this.validity.HeaderText = "有效期";
			this.validity.MappingName = "validity";
			this.validity.NullText = "";
			this.validity.Width = 75;
			// 
			// priceterm_dest
			// 
			this.priceterm_dest.Format = "";
			this.priceterm_dest.FormatInfo = null;
			this.priceterm_dest.HeaderText = "交货期";
			this.priceterm_dest.MappingName = "priceterm_dest";
			this.priceterm_dest.NullText = "";
			this.priceterm_dest.Width = 75;
			// 
			// pay_term_name
			// 
			this.pay_term_name.Format = "";
			this.pay_term_name.FormatInfo = null;
			this.pay_term_name.HeaderText = "付款条款";
			this.pay_term_name.MappingName = "pay_term_name";
			this.pay_term_name.NullText = "";
			this.pay_term_name.Width = 75;
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
			// proposer
			// 
			this.proposer.Format = "";
			this.proposer.FormatInfo = null;
			this.proposer.HeaderText = "申请人";
			this.proposer.MappingName = "proposer";
			this.proposer.NullText = "";
			this.proposer.Width = 75;
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
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(264, 408);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(88, 24);
			this.button1.TabIndex = 176;
			this.button1.Text = "发票";
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// xpStyleButton1
			// 
			this.xpStyleButton1.Location = new System.Drawing.Point(352, 408);
			this.xpStyleButton1.Name = "xpStyleButton1";
			this.xpStyleButton1.Size = new System.Drawing.Size(104, 24);
			this.xpStyleButton1.TabIndex = 177;
			this.xpStyleButton1.Text = "报关单";
			this.xpStyleButton1.Click += new System.EventHandler(this.xpStyleButton1_Click);
			// 
			// xpStyleButton2
			// 
			this.xpStyleButton2.Location = new System.Drawing.Point(264, 432);
			this.xpStyleButton2.Name = "xpStyleButton2";
			this.xpStyleButton2.Size = new System.Drawing.Size(88, 24);
			this.xpStyleButton2.TabIndex = 178;
			this.xpStyleButton2.Text = "装箱单";
			this.xpStyleButton2.Click += new System.EventHandler(this.xpStyleButton2_Click);
			// 
			// xpStyleButton3
			// 
			this.xpStyleButton3.Location = new System.Drawing.Point(352, 432);
			this.xpStyleButton3.Name = "xpStyleButton3";
			this.xpStyleButton3.Size = new System.Drawing.Size(104, 24);
			this.xpStyleButton3.TabIndex = 179;
			this.xpStyleButton3.Text = "外销出仓通知单";
			this.xpStyleButton3.Click += new System.EventHandler(this.xpStyleButton3_Click);
			// 
			// frmSaleDoc
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
			this.Name = "frmSaleDoc";
			this.Text = "单证管理";
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

			/*
			if(!TJSystem.Public.PublicStatic.IsNumDouble(this.priTextBox16.Text.Trim()))
			{
				sb.Append("  运费必须是数字");
				TJSystem.Public.PublicStatic.ShowMessage(TJSystem.Public.MessageType.Error,sb.ToString());
				return false;
			}
			*/
			if(!TJSystem.Public.PublicStatic.IsNumDouble(this.priTextBox12.Text.Trim()))
			{
				sb.Append("  箱数必须是数字");
				TJSystem.Public.PublicStatic.ShowMessage(TJSystem.Public.MessageType.Error,sb.ToString());
				return false;
			}
			return true;
		}

		private void InitialGrid(string sql)
		{		
			DataTable dt = TJSystem.Public.PublicStatic.db.GetDataTable(sql);
			dt.TableName = "sale_doc_master";
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
				this.priTextBox9.Enabled = true;

				this.priTextBox10.Enabled = true;
				this.priTextBox11.Enabled = true;
				this.priTextBox12.Enabled = true;
				this.priTextBox13.Enabled = true;
				this.priTextBox14.Enabled = true;
				this.priTextBox15.Enabled = true;
//				this.priTextBox16.Enabled = true;
				this.priTextBox17.Enabled = true;
				this.priTextBox18.Enabled = true;
				
				this.priTextBox20.Enabled = true;
				this.priTextBox21.Enabled = true;
				this.priTextBox22.Enabled = true;
				this.priTextBox23.Enabled = true;
				this.priTextBox25.Enabled = true;
				this.priTextBox26.Enabled = true;
				this.priTextBox29.Enabled = true;
				
				this.priTextBox30.Enabled = true;
				this.priTextBox33.Enabled = true;
				
				this.priTextBox36.Enabled = true;
//				this.priTextBox37.Enabled = true;
//				this.priTextBox38.Enabled = true;

				this.comboBox1.Enabled = true;
				this.priComboBox1.Enabled = false;
				this.priComboBox2.Enabled = true;
				this.priComboBox3.Enabled = true;
				this.priComboBox4.Enabled = true;
				this.priComboBox5.Enabled = true;
				this.priComboBox7.Enabled = true;
				this.priComboBox8.Enabled = true;
				this.priComboBox9.Enabled = true;
				this.priComboBox10.Enabled = true;
				this.priComboBox11.Enabled = true;
				this.priComboBox12.Enabled = true;

				this.priDateTimePicker1.Enabled = true;
				this.priDateTimePicker2.Enabled = true;
				this.priDateTimePicker3.Enabled = true;
				this.priDateTimePicker4.Enabled = true;
				this.priDateTimePicker5.Enabled = true;	
				
				
				this.textBox1.Text = "" ;
				this.priTextBox1.Text = "";
				
				this.priTextBox3.Text = "";
				this.priTextBox4.Text = "";
				this.priTextBox5.Text = "";
				this.priTextBox9.Text = "";

				this.priTextBox10.Text = "";
				this.priTextBox11.Text = "";
				this.priTextBox12.Text = "";
				this.priTextBox13.Text = "";
				this.priTextBox14.Text = "";
				this.priTextBox15.Text = "";
//				this.priTextBox16.Text = "";
				this.priTextBox17.Text = "";
				this.priTextBox18.Text = "";
				
				this.priTextBox20.Text = "";
				this.priTextBox21.Text = "";
				this.priTextBox22.Text = "";
				this.priTextBox23.Text = "";
				this.priTextBox25.Text = "";
				this.priTextBox26.Text = "";
				this.priTextBox29.Text = "";
				
				this.priTextBox30.Text = "";
				this.priTextBox33.Text = "";
				
				this.priTextBox36.Text = "";
//				this.priTextBox37.Text = "";
//				this.priTextBox38.Text = "";

				this.comboBox1.Text = "";
				this.priComboBox1.SelectedValue = "1";
				this.priComboBox2.Text = "";
				this.priComboBox3.Text = "";
				this.priComboBox4.Text = "";
				this.priComboBox5.Text = "";
				this.priComboBox7.Text = "";
				this.priComboBox8.Text = "";
				this.priComboBox9.Text = "";
				this.priComboBox10.Text = "";
				this.priComboBox11.Text = "";
				this.priComboBox12.Text = "";

				this.priDateTimePicker1.Value = System.DateTime.Now;
				this.priDateTimePicker2.Value = System.DateTime.Now;
				this.priDateTimePicker3.Value = System.DateTime.Now;
				this.priDateTimePicker4.Value = System.DateTime.Now;
				this.priDateTimePicker5.Value = System.DateTime.Now;	
				
			}
			else if(ButtonType.Equals("update"))
			{
				this.textBox1.Enabled = false;
				this.priTextBox1.Enabled = true;
				
				this.priTextBox3.Enabled = true;
				this.priTextBox4.Enabled = true;
				this.priTextBox9.Enabled = true;

				this.priTextBox10.Enabled = true;
				this.priTextBox11.Enabled = true;
				this.priTextBox12.Enabled = true;
				this.priTextBox13.Enabled = true;
				this.priTextBox14.Enabled = true;
				this.priTextBox15.Enabled = true;
//				this.priTextBox16.Enabled = true;
				this.priTextBox17.Enabled = true;
				this.priTextBox18.Enabled = true;
				
				this.priTextBox20.Enabled = true;
				this.priTextBox21.Enabled = true;
				this.priTextBox22.Enabled = true;
				this.priTextBox23.Enabled = true;
				this.priTextBox25.Enabled = true;
				this.priTextBox26.Enabled = true;
				this.priTextBox29.Enabled = true;
				
				this.priTextBox30.Enabled = true;
				this.priTextBox33.Enabled = true;
				
				this.priTextBox36.Enabled = true;
//				this.priTextBox37.Enabled = true;
//				this.priTextBox38.Enabled = true;

				this.comboBox1.Enabled = true;
				this.priComboBox1.Enabled = false;
				this.priComboBox2.Enabled = true;
				this.priComboBox3.Enabled = true;
				this.priComboBox4.Enabled = true;
				this.priComboBox5.Enabled = true;
				this.priComboBox7.Enabled = true;
				this.priComboBox8.Enabled = true;
				this.priComboBox9.Enabled = true;
				this.priComboBox10.Enabled = true;
				this.priComboBox11.Enabled = true;
				this.priComboBox12.Enabled = true;

				this.priDateTimePicker1.Enabled = true;
				this.priDateTimePicker2.Enabled = true;
				this.priDateTimePicker3.Enabled = true;
				this.priDateTimePicker4.Enabled = true;
				this.priDateTimePicker5.Enabled = true;	
					
			}

			//this.priToolBar1.SetStatusEnable(this.priComboBox1);
		}

		private void setDisable()
		{
			this.textBox1.Enabled = false;
			this.textBox2.Enabled = false;
			this.priTextBox1.Enabled = false;
			this.priTextBox2.Enabled = false;
			this.priTextBox3.Enabled = false;
			this.priTextBox4.Enabled = false;
			this.priTextBox5.Enabled = false;
			this.priTextBox6.Enabled = false;
			this.priTextBox7.Enabled = false;
			this.priTextBox8.Enabled = false;
			this.priTextBox9.Enabled = false;

			this.priTextBox10.Enabled = false;
			this.priTextBox11.Enabled = false;
			this.priTextBox12.Enabled = false;
			this.priTextBox13.Enabled = false;
			this.priTextBox14.Enabled = false;
			this.priTextBox15.Enabled = false;
//			this.priTextBox16.Enabled = false;
			this.priTextBox17.Enabled = false;
			this.priTextBox18.Enabled = false;
				
			this.priTextBox20.Enabled = false;
			this.priTextBox21.Enabled = false;
			this.priTextBox22.Enabled = false;
			this.priTextBox23.Enabled = false;
			this.priTextBox25.Enabled = false;
			this.priTextBox26.Enabled = false;
			this.priTextBox29.Enabled = false;
				
			this.priTextBox30.Enabled = false;
			this.priTextBox33.Enabled = false;
			this.priTextBox35.Enabled = false;
			this.priTextBox36.Enabled = false;
//			this.priTextBox37.Enabled = false;
//			this.priTextBox38.Enabled = false;

			this.comboBox1.Enabled = false;
			this.priComboBox1.Enabled = false;
			this.priComboBox2.Enabled = false;
			this.priComboBox3.Enabled = false;
			this.priComboBox4.Enabled = false;
			this.priComboBox5.Enabled = false;
			this.priComboBox7.Enabled = false;
			this.priComboBox8.Enabled = false;
			this.priComboBox9.Enabled = false;
			this.priComboBox10.Enabled = false;
			this.priComboBox11.Enabled = false;
			this.priComboBox12.Enabled = false;

			this.priDateTimePicker1.Enabled = false;
			this.priDateTimePicker2.Enabled = false;
			this.priDateTimePicker3.Enabled = false;
			this.priDateTimePicker4.Enabled = false;
			this.priDateTimePicker5.Enabled = false;			
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
				TJSystem.Public.PublicStatic.formName = "单证管理";
			}
			base.OnClosing (e);
		}

		private void priComboBox11_SelectionChangeCommitted(object sender, System.EventArgs e)
		{
			string sql = null;
			System.Data.DataTable dt = null;
			sql = "select TERM_CODE,TERM_NAMECN from p_priceterm where term_code ='" + this.priComboBox11.SelectedValue.ToString() + "'";
			dt = TJSystem.Public.PublicStatic.db.GetDataTable(sql);
			if(dt.Rows.Count != 1)
			{
				this.textBox2.Text = "";
				return;
			}
			this.textBox2.Text = dt.Rows[0][1].ToString();
		}

		private void priComboBox10_SelectionChangeCommitted(object sender, System.EventArgs e)
		{
			string sql = null;
			System.Data.DataTable dt = null;
			sql = "select CLIENT_ID,CLIENT_NAME from basic_client where CLIENT_ID ='" + this.priComboBox10.SelectedValue.ToString() + "'";
			dt = TJSystem.Public.PublicStatic.db.GetDataTable(sql);
			if(dt.Rows.Count != 1)
			{
				this.priTextBox35.Text = "";
				return;
			}
			this.priTextBox35.Text = dt.Rows[0][1].ToString();
		}

		private void PaPiaoEvent()
		{
			System.Text.StringBuilder sb = new System.Text.StringBuilder();
			string strsol = null;
			
			if(this.textBox1.Text.Trim().Equals(""))
			{
				TJSystem.Public.PublicStatic.ShowMessage(TJSystem.Public.MessageType.Exclamation,"请选择要生成发票的单证号！");
				return;
			}
			TJSystem.Classes.common.DocParamCommon dpcom = new TJSystem.Classes.common.DocParamCommon();
			dpcom.DocNO = this.textBox1.Text ;
			dpcom.DocDate = this.priDateTimePicker3.Value.ToString();
			dpcom.DocSaleNO = this.priTextBox5.Text;
			string [] strsolist = dpcom.DocSaleNO.Split(',');
			for(int i = 0; i < strsolist.Length; i ++)
			{
				sb.Append("'");
				sb.Append(strsolist[i]);
				sb.Append("'");
				sb.Append(",");
			}
			strsol = sb.ToString().Substring(0,sb.ToString().Length - 1);

			dpcom.DocLCNO = this.priTextBox3.Text ;
			if(this.comboBox1.SelectedValue.ToString().Equals(""))
			{
				dpcom.DocPOE = this.comboBox1.SelectedValue.ToString();
			}
			else
			{
				dpcom.DocPOE = this.comboBox1.Text.Replace(this.comboBox1.SelectedValue.ToString(),"").Trim();
			}
			if(this.comboBox1.SelectedValue.ToString().Equals(""))
			{
				dpcom.DocPOD = this.priComboBox8.SelectedValue.ToString();
			}
			else
			{
				dpcom.DocPOD = this.priComboBox8.Text.Replace(this.priComboBox8.SelectedValue.ToString(),"").Trim();
			}
			dpcom.DocSaleTo = this.priTextBox35.Text;
			dpcom.PKCondition = "where a.so_code in (" + strsol + ")";
			TJSystem.CrystalRPT.frmReport frm = new TJSystem.CrystalRPT.frmReport("发票",dpcom);
			frm.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			frm.Show();
		}

		private void linkLabel8_LinkClicked(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
		{
			frmSaleOrderList.frmCurrent = new frmSaleOrderList();
			frmSaleOrderList.frmCurrent.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			frmSaleOrderList.frmCurrent.ShowDialog();

			this.priTextBox5.Text = TJSystem.Public.PublicStatic.SOList;
		}

		private void WaiXiaoChuCangDanEvent()
		{
			System.Text.StringBuilder sb = new System.Text.StringBuilder();
			string strsol = null;
			if(this.textBox1.Text.Trim().Equals(""))
			{
				TJSystem.Public.PublicStatic.ShowMessage(TJSystem.Public.MessageType.Exclamation,"请选择要打印的发票单号！");
				return;
			}
			string sql = "select invoice_no,so_code from sale_doc_master where invoice_no='" + this.textBox1.Text.Trim() + "'"; 
			System.Data.DataTable dt = TJSystem.Public.PublicStatic.db.GetDataTable(sql);
			if(dt.Rows.Count != 1)
			{
				TJSystem.Public.PublicStatic.ShowMessage(TJSystem.Public.MessageType.Exclamation,"找不到该发票号的订单记录，无法打印！");
				return;
			}
			if(dt.Rows[0][1].ToString().Trim().Equals(""))
			{
				TJSystem.Public.PublicStatic.ShowMessage(TJSystem.Public.MessageType.Exclamation,"找不到该发票号的订单记录，无法打印！");
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
			dpcom.DocDate = this.priDateTimePicker3.Value.ToString("yyyy/MM/dd");
			dpcom.DocLCNO = this.priTextBox18.Text;
			dpcom.DocSaleNO = this.priTextBox5.Text;
			
			TJSystem.CrystalRPT.frmReport frm = new TJSystem.CrystalRPT.frmReport("外销出仓单",dpcom,this.dataGrid1);
			frm.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			frm.ShowDialog();
		}

		private void ZhuangXiangDanEvent()
		{
			System.Text.StringBuilder sb = new System.Text.StringBuilder();
			string strsol = null;
			if(this.textBox1.Text.Trim().Equals(""))
			{
				TJSystem.Public.PublicStatic.ShowMessage(TJSystem.Public.MessageType.Exclamation,"请选择要打印的发票单号！");
				return;
			}
			string sql = "select invoice_no,so_code from sale_doc_master where invoice_no='" + this.textBox1.Text.Trim() + "'"; 
			System.Data.DataTable dt = TJSystem.Public.PublicStatic.db.GetDataTable(sql);
			if(dt.Rows.Count != 1)
			{
				TJSystem.Public.PublicStatic.ShowMessage(TJSystem.Public.MessageType.Exclamation,"找不到该发票号的订单记录，无法打印！");
				return;
			}
			if(dt.Rows[0][1].ToString().Trim().Equals(""))
			{
				TJSystem.Public.PublicStatic.ShowMessage(TJSystem.Public.MessageType.Exclamation,"找不到该发票号的订单记录，无法打印！");
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
			dpcom.DocSaleTo = this.priTextBox35.Text;
			dpcom.DocDate = this.priDateTimePicker3.Value.ToString("yyyy/MM/dd");
			dpcom.MaiTou = this.priTextBox13.Text;
			
			TJSystem.CrystalRPT.frmReport frm = new TJSystem.CrystalRPT.frmReport("装箱单",dpcom,this.dataGrid1);
			frm.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			frm.ShowDialog();
		}

		private void priComboBox1_SelectionChangeCommitted(object sender, System.EventArgs e)
		{
			TJSystem.Public.PublicStatic.SetApprovedInfo(this.priComboBox1,this.priTextBox14,this.priTextBox17);
		}

		private void pictureBox1_DoubleClick(object sender, System.EventArgs e)
		{
			if (MessageBox.Show("是否确认导入唛头图片资料？","导入图片",MessageBoxButtons.YesNo,MessageBoxIcon.Question)
				== System.Windows.Forms.DialogResult.No)
			{
				return;
			}

			System.Windows.Forms.OpenFileDialog frm = new OpenFileDialog();
			frm.Filter = "JPEG图片(*.jpg)|*.jpg|BMP图片(*.bmp)|*.bmp";
			frm.ShowDialog();
			this.pictureBox1.Image = null;
			if(!frm.FileName.Equals(""))
			{
				this.pictureBox1.Image = Image.FromFile(frm.FileName);
				this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			}
			else
			{
				return;
			}

			if (this.textBox1.Text.Trim().Equals(""))
			{
				TJSystem.Public.PublicStatic.ShowMessage(TJSystem.Public.MessageType.Error,"当前单证号为空，请选中需要更新的单证！");
				return;
			}
			if (TJSystem.Public.PublicStatic.IsExsist(this._table,this._PK,this.priToolBar1))
			{
				InsertImage(frm.FileName);
			}
		}

		private void InsertImage(string filename)
		{
			try 
			{ 
//				if(!checkFormValue())
//				{
//					return ;
//				}
				CreateProc();
				System.IO.FileInfo fs = new System.IO.FileInfo(filename); 
				string sql = null;
				if (!fs.Exists) 
				{ 
					MessageBox.Show("无效的文件名!"); 
					return; 
				} 
				//创建一字节数组,用来存储图像文件.(数组的长度是图像文件的长度) 
				byte[] Content=new byte[fs.Length]; 
				//打开文件并用他初始化一个文件流对象 
				FileStream ImageFileStream=fs.OpenRead(); 
				//将文件内容写入字节数组 
				ImageFileStream.Read(Content,0,Content.Length); 
				//关闭文件流 
				//MessageBox.Show("读取完毕!"); 

//				sql = "update sale_doc_master set maitouimg=";
//				sql += Content;
//				sql += " where invoice_no='";
//				sql += this.textBox1.Text.Trim();
//				sql += "'";
//
//				TJSystem.Public.PublicStatic.db.ExeSql(sql);

				//连接数据库 
				SqlConnection conn=new SqlConnection(); 
				conn.ConnectionString=TJSystem.Public.PublicStatic.ConnectionString;

				SqlCommand cmd=new SqlCommand("UpdateImageForSaleDoc",conn); 
				cmd.CommandType=CommandType.StoredProcedure; 

				cmd.Parameters.Add("@invoice_no",SqlDbType.VarChar); 
				cmd.Parameters["@invoice_no"].Value=this.textBox1.Text.Trim();				
				cmd.Parameters.Add("@UpdateImage",SqlDbType.Image); 
				cmd.Parameters["@UpdateImage"].Value=Content; 

				if(MessageBox.Show("确定要新增该图片？（Y/N）","新增",MessageBoxButtons.YesNo,MessageBoxIcon.Question)
					== System.Windows.Forms.DialogResult.Yes)
				{
					conn.Open(); 
					cmd.ExecuteNonQuery(); 
					conn.Close(); 
				}

				ImageFileStream.Close(); 
				TJSystem.Public.PublicStatic.ShowMessage(TJSystem.Public.MessageType.Information,"图片更新成功！");
//				GetImgTable();
			} 
			catch (Exception ex) 
			{ 
				MessageBox.Show(ex.Message); 
			} 


		}

		private void CreateProc()
		{
			string sql = "select name from sysobjects where name = 'UpdateImageForSaleDoc'";
			DataTable dttmp = TJSystem.Public.PublicStatic.db.GetDataTable(sql);
			if(dttmp.Rows.Count == 0)
			{
				System.Text.StringBuilder sb = new System.Text.StringBuilder();
				sb.Append(" CREATE PROCEDURE UpdateImageForSaleDoc ");
				sb.Append(" ( ");
				sb.Append(" @invoice_no varchar(50),");
				sb.Append(" @UpdateImage Image");
				sb.Append(" ) ");
				sb.Append(" As");
				sb.Append(" update sale_doc_master set maitouimg=");
				sb.Append(" @UpdateImage where invoice_no=@invoice_no");
				sb.Append("");

				TJSystem.Public.PublicStatic.db.ExeSql(sb.ToString());
			}
			else
			{
				return;
			}
		}

		private void textBox1_TextChanged(object sender, System.EventArgs e)
		{
			if(this.textBox1.Text.Trim().Equals(""))
			{
				return;
			}
			if(!TJSystem.Public.PublicStatic.IsExsist(this._table,this._PK,this.priToolBar1))
			{
				return;
			}
			ShowImage(this.textBox1.Text.Trim());
		}

		private void ShowImage(string invoice)
		{
			DataTable dt = null;
			string strSql="select maitouimg from sale_doc_master where invoice_no='";
			strSql += invoice;
			strSql += "'";
			this.pictureBox1.Image = null;
			dt = TJSystem.Public.PublicStatic.db.GetDataTable(strSql);
			if(dt != null)
			{
				if(1 == dt.Rows.Count)
				{
					object obj = dt.Rows[0]["maitouimg"];
					if (obj == System.DBNull.Value)
					{
						return;
					}
					try
					{
						MemoryStream ms=new MemoryStream((byte[])dt.Rows[0]["maitouimg"]); 
						Image image = Image.FromStream(ms,true); 

						this.pictureBox1.Image=image;  
						this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
					}
					catch(System.Exception ex)
					{
						return;
					}
				}
			}
		}

		private void pictureBox1_Click(object sender, System.EventArgs e)
		{
		
		}

		private void BaoGuanDanEvent()
		{
			System.Text.StringBuilder sb = new System.Text.StringBuilder();
			string strsol = null;
			if(this.textBox1.Text.Trim().Equals(""))
			{
				TJSystem.Public.PublicStatic.ShowMessage(TJSystem.Public.MessageType.Exclamation,"请选择要打印的发票单号！");
				return;
			}
			string sql = "select invoice_no,so_code from sale_doc_master where invoice_no='" + this.textBox1.Text.Trim() + "'"; 
			System.Data.DataTable dt = TJSystem.Public.PublicStatic.db.GetDataTable(sql);
			if(dt.Rows.Count != 1)
			{
				TJSystem.Public.PublicStatic.ShowMessage(TJSystem.Public.MessageType.Exclamation,"找不到该发票号的订单记录，无法打印！");
				return;
			}
			if(dt.Rows[0][1].ToString().Trim().Equals(""))
			{
				TJSystem.Public.PublicStatic.ShowMessage(TJSystem.Public.MessageType.Exclamation,"找不到该发票号的销售记录，无法打印！");
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
			
			TJSystem.CrystalRPT.frmReport frm = new TJSystem.CrystalRPT.frmReport("报关单",dpcom,this.dataGrid1);
			frm.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			frm.ShowDialog();
		}

		private void button1_Click(object sender, System.EventArgs e)
		{
			this.PaPiaoEvent();
		}

		private void xpStyleButton1_Click(object sender, System.EventArgs e)
		{
			this.BaoGuanDanEvent();
		}

		private void xpStyleButton2_Click(object sender, System.EventArgs e)
		{
			this.ZhuangXiangDanEvent();
		}

		private void xpStyleButton3_Click(object sender, System.EventArgs e)
		{
			this.WaiXiaoChuCangDanEvent();
		}


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

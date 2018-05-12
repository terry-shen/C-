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
	public class frmLCDoc : System.Windows.Forms.Form
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
		private System.Windows.Forms.Label label25;
		private TJSystem.Classes.PriTextBox priTextBox21;
		private System.Windows.Forms.Label label21;
		private TJSystem.Classes.PriTextBox priTextBox17;
		private System.Windows.Forms.Label label18;
		private TJSystem.Classes.PriTextBox priTextBox14;
		private System.Windows.Forms.Label label17;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label2;
		private TJSystem.Classes.PriComboBox comboBox1;
		private TJSystem.Classes.PriTextBox textBox1;
		private System.Windows.Forms.DataGrid dataGrid1;
		private System.Windows.Forms.DataGridTableStyle dataGridTableStyle1;
		private TJSystem.Classes.PriComboBox priComboBox6;
		private System.Windows.Forms.Label label30;
		private System.Windows.Forms.Label label35;
		private System.Windows.Forms.Label label20;
		private TJSystem.Classes.PriTextBox priTextBox16;
		private System.Windows.Forms.Label label37;
		private TJSystem.Classes.PriTextBox priTextBox29;
		public static System.Windows.Forms.Form frmCurrent = null ;
		private string _statusType = null;
		private string _table = null;
		private string _PK = null;
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
		private System.Windows.Forms.Label label47;
		private TJSystem.Classes.PriTextBox priTextBox37;
		private System.Windows.Forms.Label label48;
		private TJSystem.Classes.PriTextBox priTextBox38;
		private TJSystem.Classes.PriDateTimePicker priDateTimePicker3;
		private TJSystem.Classes.PriComboBox priComboBox4;
		private TJSystem.Classes.PriComboBox priComboBox5;
		private TJSystem.Classes.PriComboBox priComboBox8;
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
		private System.Windows.Forms.DataGridTextBoxColumn so_code;
		private System.Windows.Forms.DataGridTextBoxColumn allowtransport;
		private System.Windows.Forms.DataGridTextBoxColumn allowbatch;
		private System.Windows.Forms.DataGridTextBoxColumn deliverydate;
		private System.Windows.Forms.DataGridTextBoxColumn approvedby;
		private System.Windows.Forms.DataGridTextBoxColumn approvedon;
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
		private System.Windows.Forms.DataGridTextBoxColumn port_departure_name;
		private System.Windows.Forms.DataGridTextBoxColumn COUNTRY_NAMECN;
		private System.Windows.Forms.DataGridTextBoxColumn destport_name;
		private System.Windows.Forms.DataGridTextBoxColumn port_transport_name;
		private System.Windows.Forms.DataGridTextBoxColumn STATUS_NAME;
		private System.Windows.Forms.DataGridTextBoxColumn CURRENCY_NAMECN;
		private System.Windows.Forms.DataGridTextBoxColumn pay_term_name;
		private System.Windows.Forms.Label label16;
		private TJSystem.Classes.PriComboBox priComboBox1;
		private System.Windows.Forms.Label label3;
		private TJSystem.Classes.PriTextBox priTextBox3;
		private System.Windows.Forms.DataGridTextBoxColumn REC_DATE;
		private System.Windows.Forms.DataGridTextBoxColumn CLIENT_SOCODE;
		private System.Windows.Forms.DataGridTextBoxColumn AMOUNT;

		private System.Windows.Forms.Form _form = null;

		public frmLCDoc()
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
			sb.Append("SELECT A.LC_CODE,A.LC_DATE,A.REC_DATE,A.STATUS,B.STATUS_NAME,A.CURRENCY,C.CURRENCY_NAMECN,A.AMOUNT,A.BANK,A.VALIDITY,");
			sb.Append(" A.SO_CODE,A.CLIENT_SOCODE,A.CLIENT_ID,A.CLIENT_NAME,A.PROPOSER,A.NOTIFIER,A.CONSIGNEE,A.BENEFICIARY,");
			sb.Append(" A.SHIPPER,A.PAY_TERM,j.TERM_NAMECN as pay_term_name,A.PRICETERM,l.TERM_NAMECN as priceterm_name,A.priceterm_dest,");
			sb.Append(" A.PORT_DEPARTURE,n.PORT_NAMECN as port_departure_name,");
			sb.Append(" A.ARRIVECOUNTRY,e.COUNTRY_NAMECN as COUNTRY_NAMECN,A.DESTPORT,i.PORT_NAMECN as destport_name,");
			sb.Append(" A.PORT_TRANSPORT,f.PORT_NAMECN as port_transport_name,A.DELIVERYDATE,A.ALLOWBATCH,A.ALLOWTRANSPORT,");
			sb.Append(" A.INVOICETERM,A.PACKINGTERM,A.ADDONTERM,A.APPROVEDBY,A.APPROVEDON,A.CREATEBY,A.CREATEON,A.MODIFYBY,A.MODIFYON");
			sb.Append(" FROM SALE_LETTEROFCREDIT A");
			sb.Append(" LEFT JOIN P_STATUS B ON A.STATUS=B.STATUS_ID AND B.STATUS_TYPE=");
			sb.Append("'");
			sb.Append(this._statusType);
			sb.Append("' ");
			sb.Append(" LEFT JOIN P_CURRENCY C ON A.CURRENCY=C.CURRENCY_CODE");
			sb.Append(" left join p_country e on a.arrivecountry=e.COUNTRY_CODE");
			sb.Append(" left join p_port f on a.port_transport=f.PORT_CODE");
			sb.Append(" left join p_port i on a.destport=i.PORT_CODE");
			sb.Append(" left join p_paymentterm j on a.pay_term=j.TERM_CODE");
			sb.Append(" left join p_priceterm l on a.priceterm=l.TERM_CODE");
			sb.Append(" left join p_port n on a.port_departure=n.PORT_CODE");
			sb.Append(" ORDER BY A.LC_CODE");
			this.InitialGrid(sb.ToString());

			priToolBar1.setCurrentForm = this;
			
			_PK = "LC_CODE";
			_table = "SALE_LETTEROFCREDIT";
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

			sql = "select SO_CODE,SO_CODE+' '+substring(so_date,1,10)+' '+CLIENT_NAME as SO_OBJECT from sale_so_master order by so_code";
			dt = TJSystem.Public.PublicStatic.db.GetDataTable(sql);
			dr = dt.NewRow() ;
			dr[0] = "" ;
			dr[1] = "" ;
			dt.Rows.InsertAt(dr,0) ;
			dtcpy = dt.Copy();
			this.priComboBox6.DataSource = dtcpy.DefaultView;
			this.priComboBox6.ValueMember = "SO_CODE";
			this.priComboBox6.DisplayMember = "SO_OBJECT";			

			
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(frmLCDoc));
			this.panel3 = new System.Windows.Forms.Panel();
			this.priToolBar1 = new TJSystem.UC.PriToolBar();
			this.panel1 = new System.Windows.Forms.Panel();
			this.label1 = new System.Windows.Forms.Label();
			this.panel2 = new System.Windows.Forms.Panel();
			this.panel4 = new System.Windows.Forms.Panel();
			this.priComboBox1 = new TJSystem.Classes.PriComboBox();
			this.label37 = new System.Windows.Forms.Label();
			this.priTextBox29 = new TJSystem.Classes.PriTextBox();
			this.label20 = new System.Windows.Forms.Label();
			this.priTextBox16 = new TJSystem.Classes.PriTextBox();
			this.label35 = new System.Windows.Forms.Label();
			this.priComboBox6 = new TJSystem.Classes.PriComboBox();
			this.label30 = new System.Windows.Forms.Label();
			this.label25 = new System.Windows.Forms.Label();
			this.priTextBox21 = new TJSystem.Classes.PriTextBox();
			this.label21 = new System.Windows.Forms.Label();
			this.priTextBox17 = new TJSystem.Classes.PriTextBox();
			this.label18 = new System.Windows.Forms.Label();
			this.priTextBox14 = new TJSystem.Classes.PriTextBox();
			this.label16 = new System.Windows.Forms.Label();
			this.label17 = new System.Windows.Forms.Label();
			this.label14 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.comboBox1 = new TJSystem.Classes.PriComboBox();
			this.textBox1 = new TJSystem.Classes.PriTextBox();
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
			this.label47 = new System.Windows.Forms.Label();
			this.priTextBox37 = new TJSystem.Classes.PriTextBox();
			this.label48 = new System.Windows.Forms.Label();
			this.priTextBox38 = new TJSystem.Classes.PriTextBox();
			this.priDateTimePicker3 = new TJSystem.Classes.PriDateTimePicker();
			this.priComboBox4 = new TJSystem.Classes.PriComboBox();
			this.priComboBox5 = new TJSystem.Classes.PriComboBox();
			this.priComboBox8 = new TJSystem.Classes.PriComboBox();
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
			this.label3 = new System.Windows.Forms.Label();
			this.priTextBox3 = new TJSystem.Classes.PriTextBox();
			this.dataGrid1 = new System.Windows.Forms.DataGrid();
			this.dataGridTableStyle1 = new System.Windows.Forms.DataGridTableStyle();
			this.lc_code = new System.Windows.Forms.DataGridTextBoxColumn();
			this.lc_date = new System.Windows.Forms.DataGridTextBoxColumn();
			this.REC_DATE = new System.Windows.Forms.DataGridTextBoxColumn();
			this.so_code = new System.Windows.Forms.DataGridTextBoxColumn();
			this.port_departure_name = new System.Windows.Forms.DataGridTextBoxColumn();
			this.COUNTRY_NAMECN = new System.Windows.Forms.DataGridTextBoxColumn();
			this.destport_name = new System.Windows.Forms.DataGridTextBoxColumn();
			this.port_transport_name = new System.Windows.Forms.DataGridTextBoxColumn();
			this.CLIENT_SOCODE = new System.Windows.Forms.DataGridTextBoxColumn();
			this.AMOUNT = new System.Windows.Forms.DataGridTextBoxColumn();
			this.allowtransport = new System.Windows.Forms.DataGridTextBoxColumn();
			this.allowbatch = new System.Windows.Forms.DataGridTextBoxColumn();
			this.deliverydate = new System.Windows.Forms.DataGridTextBoxColumn();
			this.STATUS_NAME = new System.Windows.Forms.DataGridTextBoxColumn();
			this.approvedby = new System.Windows.Forms.DataGridTextBoxColumn();
			this.approvedon = new System.Windows.Forms.DataGridTextBoxColumn();
			this.CURRENCY_NAMECN = new System.Windows.Forms.DataGridTextBoxColumn();
			this.bank = new System.Windows.Forms.DataGridTextBoxColumn();
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
			this.label1.Text = "信用证管理";
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
			this.panel4.Controls.Add(this.priComboBox1);
			this.panel4.Controls.Add(this.label37);
			this.panel4.Controls.Add(this.priTextBox29);
			this.panel4.Controls.Add(this.label20);
			this.panel4.Controls.Add(this.priTextBox16);
			this.panel4.Controls.Add(this.label35);
			this.panel4.Controls.Add(this.priComboBox6);
			this.panel4.Controls.Add(this.label30);
			this.panel4.Controls.Add(this.label25);
			this.panel4.Controls.Add(this.priTextBox21);
			this.panel4.Controls.Add(this.label21);
			this.panel4.Controls.Add(this.priTextBox17);
			this.panel4.Controls.Add(this.label18);
			this.panel4.Controls.Add(this.priTextBox14);
			this.panel4.Controls.Add(this.label16);
			this.panel4.Controls.Add(this.label17);
			this.panel4.Controls.Add(this.label14);
			this.panel4.Controls.Add(this.label11);
			this.panel4.Controls.Add(this.label10);
			this.panel4.Controls.Add(this.label8);
			this.panel4.Controls.Add(this.label5);
			this.panel4.Controls.Add(this.label2);
			this.panel4.Controls.Add(this.comboBox1);
			this.panel4.Controls.Add(this.textBox1);
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
			this.panel4.Controls.Add(this.label47);
			this.panel4.Controls.Add(this.priTextBox37);
			this.panel4.Controls.Add(this.label48);
			this.panel4.Controls.Add(this.priTextBox38);
			this.panel4.Controls.Add(this.priDateTimePicker3);
			this.panel4.Controls.Add(this.priComboBox4);
			this.panel4.Controls.Add(this.priComboBox5);
			this.panel4.Controls.Add(this.priComboBox8);
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
			this.panel4.Controls.Add(this.label3);
			this.panel4.Controls.Add(this.priTextBox3);
			this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel4.Location = new System.Drawing.Point(0, 0);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(788, 280);
			this.panel4.TabIndex = 0;
			// 
			// priComboBox1
			// 
			this.priComboBox1.BackColor = System.Drawing.Color.White;
			this.priComboBox1.DataField = "status";
			this.priComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.priComboBox1.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.priComboBox1.ItemHeight = 14;
			this.priComboBox1.Location = new System.Drawing.Point(656, 152);
			this.priComboBox1.Name = "priComboBox1";
			this.priComboBox1.Size = new System.Drawing.Size(112, 22);
			this.priComboBox1.TabIndex = 154;
			this.priComboBox1.SelectionChangeCommitted += new System.EventHandler(this.priComboBox1_SelectionChangeCommitted);
			// 
			// label37
			// 
			this.label37.AutoSize = true;
			this.label37.BackColor = System.Drawing.Color.Transparent;
			this.label37.Location = new System.Drawing.Point(192, 200);
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
			this.priTextBox29.Location = new System.Drawing.Point(264, 200);
			this.priTextBox29.Name = "priTextBox29";
			this.priTextBox29.Size = new System.Drawing.Size(120, 23);
			this.priTextBox29.TabIndex = 152;
			this.priTextBox29.Text = "";
			// 
			// label20
			// 
			this.label20.AutoSize = true;
			this.label20.BackColor = System.Drawing.Color.Transparent;
			this.label20.ForeColor = System.Drawing.Color.Blue;
			this.label20.Location = new System.Drawing.Point(600, 128);
			this.label20.Name = "label20";
			this.label20.Size = new System.Drawing.Size(48, 19);
			this.label20.TabIndex = 151;
			this.label20.Text = "总金额";
			this.label20.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// priTextBox16
			// 
			this.priTextBox16.BackColor = System.Drawing.Color.White;
			this.priTextBox16.DataField = "AMOUNT";
			this.priTextBox16.DataType = TJSystem.Public.DataType.String;
			this.priTextBox16.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.priTextBox16.Location = new System.Drawing.Point(656, 128);
			this.priTextBox16.Name = "priTextBox16";
			this.priTextBox16.Size = new System.Drawing.Size(112, 23);
			this.priTextBox16.TabIndex = 150;
			this.priTextBox16.Text = "";
			// 
			// label35
			// 
			this.label35.AutoSize = true;
			this.label35.BackColor = System.Drawing.Color.Transparent;
			this.label35.ForeColor = System.Drawing.Color.Blue;
			this.label35.Location = new System.Drawing.Point(600, 176);
			this.label35.Name = "label35";
			this.label35.Size = new System.Drawing.Size(48, 19);
			this.label35.TabIndex = 147;
			this.label35.Text = "转运港";
			this.label35.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// priComboBox6
			// 
			this.priComboBox6.BackColor = System.Drawing.Color.White;
			this.priComboBox6.DataField = "so_code";
			this.priComboBox6.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.priComboBox6.Items.AddRange(new object[] {
															  "外包装决定",
															  "内包装决定"});
			this.priComboBox6.Location = new System.Drawing.Point(88, 128);
			this.priComboBox6.Name = "priComboBox6";
			this.priComboBox6.Size = new System.Drawing.Size(112, 22);
			this.priComboBox6.TabIndex = 135;
			// 
			// label30
			// 
			this.label30.BackColor = System.Drawing.Color.Transparent;
			this.label30.ForeColor = System.Drawing.Color.Blue;
			this.label30.Location = new System.Drawing.Point(16, 128);
			this.label30.Name = "label30";
			this.label30.Size = new System.Drawing.Size(64, 23);
			this.label30.TabIndex = 134;
			this.label30.Text = "销售单号";
			this.label30.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label25
			// 
			this.label25.BackColor = System.Drawing.Color.Transparent;
			this.label25.Location = new System.Drawing.Point(16, 224);
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
			this.priTextBox21.Location = new System.Drawing.Point(88, 224);
			this.priTextBox21.Name = "priTextBox21";
			this.priTextBox21.Size = new System.Drawing.Size(296, 23);
			this.priTextBox21.TabIndex = 121;
			this.priTextBox21.Text = "";
			// 
			// label21
			// 
			this.label21.AutoSize = true;
			this.label21.BackColor = System.Drawing.Color.Transparent;
			this.label21.Location = new System.Drawing.Point(584, 80);
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
			this.priTextBox17.Location = new System.Drawing.Point(656, 80);
			this.priTextBox17.Name = "priTextBox17";
			this.priTextBox17.Size = new System.Drawing.Size(112, 23);
			this.priTextBox17.TabIndex = 40;
			this.priTextBox17.Text = "";
			// 
			// label18
			// 
			this.label18.BackColor = System.Drawing.Color.Transparent;
			this.label18.Location = new System.Drawing.Point(384, 80);
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
			this.priTextBox14.Location = new System.Drawing.Point(472, 80);
			this.priTextBox14.Name = "priTextBox14";
			this.priTextBox14.Size = new System.Drawing.Size(112, 23);
			this.priTextBox14.TabIndex = 34;
			this.priTextBox14.Text = "";
			// 
			// label16
			// 
			this.label16.BackColor = System.Drawing.Color.Transparent;
			this.label16.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.label16.ForeColor = System.Drawing.Color.Blue;
			this.label16.Location = new System.Drawing.Point(584, 152);
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
			this.label17.Location = new System.Drawing.Point(208, 176);
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
			this.label14.Location = new System.Drawing.Point(192, 56);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(64, 23);
			this.label14.TabIndex = 27;
			this.label14.Text = "开证日期";
			this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label11
			// 
			this.label11.BackColor = System.Drawing.Color.Transparent;
			this.label11.ForeColor = System.Drawing.Color.Blue;
			this.label11.Location = new System.Drawing.Point(408, 176);
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
			this.label10.Location = new System.Drawing.Point(200, 152);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(64, 23);
			this.label10.TabIndex = 20;
			this.label10.Text = "价格条款";
			this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.BackColor = System.Drawing.Color.Transparent;
			this.label8.Location = new System.Drawing.Point(16, 200);
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
			this.label5.Location = new System.Drawing.Point(16, 176);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(64, 23);
			this.label5.TabIndex = 9;
			this.label5.Text = "起运港";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label2
			// 
			this.label2.BackColor = System.Drawing.Color.Transparent;
			this.label2.ForeColor = System.Drawing.Color.Blue;
			this.label2.Location = new System.Drawing.Point(16, 56);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(64, 23);
			this.label2.TabIndex = 6;
			this.label2.Text = "信用证号";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// comboBox1
			// 
			this.comboBox1.BackColor = System.Drawing.Color.White;
			this.comboBox1.DataField = "port_departure";
			this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBox1.Location = new System.Drawing.Point(88, 176);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(112, 22);
			this.comboBox1.TabIndex = 4;
			// 
			// textBox1
			// 
			this.textBox1.BackColor = System.Drawing.Color.White;
			this.textBox1.DataField = "LC_CODE";
			this.textBox1.DataType = TJSystem.Public.DataType.String;
			this.textBox1.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.textBox1.Location = new System.Drawing.Point(88, 56);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(104, 23);
			this.textBox1.TabIndex = 1;
			this.textBox1.Text = "";
			// 
			// label34
			// 
			this.label34.BackColor = System.Drawing.Color.Transparent;
			this.label34.Location = new System.Drawing.Point(216, 128);
			this.label34.Name = "label34";
			this.label34.Size = new System.Drawing.Size(80, 23);
			this.label34.TabIndex = 35;
			this.label34.Text = "客户合同号";
			this.label34.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// priTextBox18
			// 
			this.priTextBox18.BackColor = System.Drawing.Color.White;
			this.priTextBox18.DataField = "CLIENT_SOCODE";
			this.priTextBox18.DataType = TJSystem.Public.DataType.String;
			this.priTextBox18.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.priTextBox18.Location = new System.Drawing.Point(296, 128);
			this.priTextBox18.Name = "priTextBox18";
			this.priTextBox18.Size = new System.Drawing.Size(112, 23);
			this.priTextBox18.TabIndex = 34;
			this.priTextBox18.Text = "";
			// 
			// label38
			// 
			this.label38.AutoSize = true;
			this.label38.BackColor = System.Drawing.Color.Transparent;
			this.label38.ForeColor = System.Drawing.Color.Blue;
			this.label38.Location = new System.Drawing.Point(416, 128);
			this.label38.Name = "label38";
			this.label38.Size = new System.Drawing.Size(48, 19);
			this.label38.TabIndex = 41;
			this.label38.Text = "币  种";
			this.label38.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label39
			// 
			this.label39.BackColor = System.Drawing.Color.Transparent;
			this.label39.Location = new System.Drawing.Point(0, 80);
			this.label39.Name = "label39";
			this.label39.Size = new System.Drawing.Size(80, 23);
			this.label39.TabIndex = 119;
			this.label39.Text = "银行";
			this.label39.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// priTextBox26
			// 
			this.priTextBox26.BackColor = System.Drawing.Color.White;
			this.priTextBox26.DataField = "bank";
			this.priTextBox26.DataType = TJSystem.Public.DataType.String;
			this.priTextBox26.Enabled = false;
			this.priTextBox26.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.priTextBox26.Location = new System.Drawing.Point(88, 80);
			this.priTextBox26.Name = "priTextBox26";
			this.priTextBox26.Size = new System.Drawing.Size(280, 23);
			this.priTextBox26.TabIndex = 117;
			this.priTextBox26.Text = "";
			// 
			// priTextBox30
			// 
			this.priTextBox30.BackColor = System.Drawing.Color.White;
			this.priTextBox30.DataField = "validity";
			this.priTextBox30.DataType = TJSystem.Public.DataType.String;
			this.priTextBox30.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.priTextBox30.Location = new System.Drawing.Point(656, 56);
			this.priTextBox30.Name = "priTextBox30";
			this.priTextBox30.Size = new System.Drawing.Size(112, 23);
			this.priTextBox30.TabIndex = 40;
			this.priTextBox30.Text = "";
			// 
			// label40
			// 
			this.label40.BackColor = System.Drawing.Color.Transparent;
			this.label40.ForeColor = System.Drawing.Color.Blue;
			this.label40.Location = new System.Drawing.Point(384, 56);
			this.label40.Name = "label40";
			this.label40.Size = new System.Drawing.Size(80, 23);
			this.label40.TabIndex = 35;
			this.label40.Text = "收证日期";
			this.label40.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label41
			// 
			this.label41.AutoSize = true;
			this.label41.BackColor = System.Drawing.Color.Transparent;
			this.label41.Location = new System.Drawing.Point(600, 56);
			this.label41.Name = "label41";
			this.label41.Size = new System.Drawing.Size(48, 19);
			this.label41.TabIndex = 41;
			this.label41.Text = "有效期";
			this.label41.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label42
			// 
			this.label42.BackColor = System.Drawing.Color.Transparent;
			this.label42.Location = new System.Drawing.Point(384, 152);
			this.label42.Name = "label42";
			this.label42.Size = new System.Drawing.Size(80, 23);
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
			this.priTextBox33.Location = new System.Drawing.Point(472, 152);
			this.priTextBox33.Name = "priTextBox33";
			this.priTextBox33.Size = new System.Drawing.Size(112, 23);
			this.priTextBox33.TabIndex = 34;
			this.priTextBox33.Text = "";
			// 
			// label43
			// 
			this.label43.AutoSize = true;
			this.label43.BackColor = System.Drawing.Color.Transparent;
			this.label43.ForeColor = System.Drawing.Color.Blue;
			this.label43.Location = new System.Drawing.Point(16, 152);
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
			this.label44.Location = new System.Drawing.Point(0, 104);
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
			this.priTextBox35.Location = new System.Drawing.Point(296, 104);
			this.priTextBox35.Name = "priTextBox35";
			this.priTextBox35.Size = new System.Drawing.Size(472, 23);
			this.priTextBox35.TabIndex = 117;
			this.priTextBox35.Text = "";
			// 
			// label45
			// 
			this.label45.BackColor = System.Drawing.Color.Transparent;
			this.label45.Location = new System.Drawing.Point(216, 104);
			this.label45.Name = "label45";
			this.label45.Size = new System.Drawing.Size(80, 23);
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
			this.priTextBox36.Location = new System.Drawing.Point(472, 200);
			this.priTextBox36.Name = "priTextBox36";
			this.priTextBox36.Size = new System.Drawing.Size(296, 23);
			this.priTextBox36.TabIndex = 117;
			this.priTextBox36.Text = "";
			// 
			// label46
			// 
			this.label46.BackColor = System.Drawing.Color.Transparent;
			this.label46.Location = new System.Drawing.Point(384, 200);
			this.label46.Name = "label46";
			this.label46.Size = new System.Drawing.Size(80, 23);
			this.label46.TabIndex = 119;
			this.label46.Text = "申请人";
			this.label46.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label47
			// 
			this.label47.BackColor = System.Drawing.Color.Transparent;
			this.label47.Location = new System.Drawing.Point(384, 224);
			this.label47.Name = "label47";
			this.label47.Size = new System.Drawing.Size(80, 23);
			this.label47.TabIndex = 119;
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
			this.priTextBox37.Location = new System.Drawing.Point(472, 224);
			this.priTextBox37.Name = "priTextBox37";
			this.priTextBox37.Size = new System.Drawing.Size(296, 23);
			this.priTextBox37.TabIndex = 117;
			this.priTextBox37.Text = "";
			// 
			// label48
			// 
			this.label48.BackColor = System.Drawing.Color.Transparent;
			this.label48.Location = new System.Drawing.Point(384, 248);
			this.label48.Name = "label48";
			this.label48.Size = new System.Drawing.Size(80, 23);
			this.label48.TabIndex = 119;
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
			this.priTextBox38.Location = new System.Drawing.Point(472, 248);
			this.priTextBox38.Name = "priTextBox38";
			this.priTextBox38.Size = new System.Drawing.Size(296, 23);
			this.priTextBox38.TabIndex = 117;
			this.priTextBox38.Text = "";
			// 
			// priDateTimePicker3
			// 
			this.priDateTimePicker3.CustomFormat = "yyyy-MM-dd";
			this.priDateTimePicker3.DataField = "LC_DATE";
			this.priDateTimePicker3.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.priDateTimePicker3.Location = new System.Drawing.Point(264, 56);
			this.priDateTimePicker3.Name = "priDateTimePicker3";
			this.priDateTimePicker3.Size = new System.Drawing.Size(104, 23);
			this.priDateTimePicker3.TabIndex = 166;
			// 
			// priComboBox4
			// 
			this.priComboBox4.BackColor = System.Drawing.Color.White;
			this.priComboBox4.DataField = "arrivecountry";
			this.priComboBox4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.priComboBox4.Location = new System.Drawing.Point(264, 176);
			this.priComboBox4.Name = "priComboBox4";
			this.priComboBox4.Size = new System.Drawing.Size(120, 22);
			this.priComboBox4.TabIndex = 154;
			// 
			// priComboBox5
			// 
			this.priComboBox5.BackColor = System.Drawing.Color.White;
			this.priComboBox5.DataField = "port_transport";
			this.priComboBox5.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.priComboBox5.Location = new System.Drawing.Point(656, 176);
			this.priComboBox5.Name = "priComboBox5";
			this.priComboBox5.Size = new System.Drawing.Size(112, 22);
			this.priComboBox5.TabIndex = 154;
			// 
			// priComboBox8
			// 
			this.priComboBox8.BackColor = System.Drawing.Color.White;
			this.priComboBox8.DataField = "destport";
			this.priComboBox8.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.priComboBox8.Location = new System.Drawing.Point(472, 176);
			this.priComboBox8.Name = "priComboBox8";
			this.priComboBox8.Size = new System.Drawing.Size(112, 22);
			this.priComboBox8.TabIndex = 154;
			// 
			// priTextBox1
			// 
			this.priTextBox1.BackColor = System.Drawing.Color.White;
			this.priTextBox1.DataField = "allowtransport";
			this.priTextBox1.DataType = TJSystem.Public.DataType.String;
			this.priTextBox1.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.priTextBox1.Location = new System.Drawing.Point(88, 200);
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
			this.priComboBox9.Location = new System.Drawing.Point(88, 152);
			this.priComboBox9.Name = "priComboBox9";
			this.priComboBox9.Size = new System.Drawing.Size(112, 22);
			this.priComboBox9.TabIndex = 154;
			// 
			// priComboBox10
			// 
			this.priComboBox10.BackColor = System.Drawing.Color.White;
			this.priComboBox10.DataField = "client_id";
			this.priComboBox10.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.priComboBox10.Location = new System.Drawing.Point(88, 104);
			this.priComboBox10.Name = "priComboBox10";
			this.priComboBox10.Size = new System.Drawing.Size(112, 22);
			this.priComboBox10.TabIndex = 154;
			this.priComboBox10.SelectionChangeCommitted += new System.EventHandler(this.priComboBox10_SelectionChangeCommitted);
			// 
			// priComboBox11
			// 
			this.priComboBox11.BackColor = System.Drawing.Color.White;
			this.priComboBox11.DataField = "priceterm";
			this.priComboBox11.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.priComboBox11.Location = new System.Drawing.Point(264, 152);
			this.priComboBox11.Name = "priComboBox11";
			this.priComboBox11.Size = new System.Drawing.Size(120, 22);
			this.priComboBox11.TabIndex = 154;
			// 
			// priTextBox2
			// 
			this.priTextBox2.BackColor = System.Drawing.Color.White;
			this.priTextBox2.DataField = "createby";
			this.priTextBox2.DataType = TJSystem.Public.DataType.String;
			this.priTextBox2.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.priTextBox2.Location = new System.Drawing.Point(384, 336);
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
			this.priTextBox6.Location = new System.Drawing.Point(432, 336);
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
			this.priTextBox7.Location = new System.Drawing.Point(464, 336);
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
			this.priTextBox8.Location = new System.Drawing.Point(496, 336);
			this.priTextBox8.Name = "priTextBox8";
			this.priTextBox8.Size = new System.Drawing.Size(32, 23);
			this.priTextBox8.TabIndex = 34;
			this.priTextBox8.Text = "";
			// 
			// priDateTimePicker5
			// 
			this.priDateTimePicker5.CustomFormat = "yyyy-MM-dd";
			this.priDateTimePicker5.DataField = "REC_DATE";
			this.priDateTimePicker5.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.priDateTimePicker5.Location = new System.Drawing.Point(472, 56);
			this.priDateTimePicker5.Name = "priDateTimePicker5";
			this.priDateTimePicker5.Size = new System.Drawing.Size(112, 23);
			this.priDateTimePicker5.TabIndex = 166;
			// 
			// priComboBox12
			// 
			this.priComboBox12.BackColor = System.Drawing.Color.White;
			this.priComboBox12.DataField = "currency";
			this.priComboBox12.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.priComboBox12.Location = new System.Drawing.Point(472, 128);
			this.priComboBox12.Name = "priComboBox12";
			this.priComboBox12.Size = new System.Drawing.Size(112, 22);
			this.priComboBox12.TabIndex = 154;
			// 
			// label3
			// 
			this.label3.BackColor = System.Drawing.Color.Transparent;
			this.label3.Location = new System.Drawing.Point(0, 248);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(80, 23);
			this.label3.TabIndex = 119;
			this.label3.Text = "受益人";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// priTextBox3
			// 
			this.priTextBox3.BackColor = System.Drawing.Color.White;
			this.priTextBox3.DataField = "BENEFICIARY";
			this.priTextBox3.DataType = TJSystem.Public.DataType.String;
			this.priTextBox3.Enabled = false;
			this.priTextBox3.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.priTextBox3.Location = new System.Drawing.Point(88, 248);
			this.priTextBox3.Name = "priTextBox3";
			this.priTextBox3.Size = new System.Drawing.Size(296, 23);
			this.priTextBox3.TabIndex = 117;
			this.priTextBox3.Text = "";
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
			this.dataGrid1.Location = new System.Drawing.Point(0, 280);
			this.dataGrid1.Name = "dataGrid1";
			this.dataGrid1.ReadOnly = true;
			this.dataGrid1.Size = new System.Drawing.Size(784, 240);
			this.dataGrid1.TabIndex = 0;
			this.dataGrid1.TableStyles.AddRange(new System.Windows.Forms.DataGridTableStyle[] {
																								  this.dataGridTableStyle1});
			// 
			// dataGridTableStyle1
			// 
			this.dataGridTableStyle1.AllowSorting = false;
			this.dataGridTableStyle1.DataGrid = this.dataGrid1;
			this.dataGridTableStyle1.GridColumnStyles.AddRange(new System.Windows.Forms.DataGridColumnStyle[] {
																												  this.lc_code,
																												  this.lc_date,
																												  this.REC_DATE,
																												  this.so_code,
																												  this.port_departure_name,
																												  this.COUNTRY_NAMECN,
																												  this.destport_name,
																												  this.port_transport_name,
																												  this.CLIENT_SOCODE,
																												  this.AMOUNT,
																												  this.allowtransport,
																												  this.allowbatch,
																												  this.deliverydate,
																												  this.STATUS_NAME,
																												  this.approvedby,
																												  this.approvedon,
																												  this.CURRENCY_NAMECN,
																												  this.bank,
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
			this.dataGridTableStyle1.MappingName = "SALE_LETTEROFCREDIT";
			this.dataGridTableStyle1.ReadOnly = true;
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
			// lc_date
			// 
			this.lc_date.Format = "";
			this.lc_date.FormatInfo = null;
			this.lc_date.HeaderText = "开证日期";
			this.lc_date.MappingName = "lc_date";
			this.lc_date.NullText = "";
			this.lc_date.Width = 75;
			// 
			// REC_DATE
			// 
			this.REC_DATE.Format = "";
			this.REC_DATE.FormatInfo = null;
			this.REC_DATE.HeaderText = "收证日期";
			this.REC_DATE.MappingName = "REC_DATE";
			this.REC_DATE.NullText = "";
			this.REC_DATE.Width = 75;
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
			// CLIENT_SOCODE
			// 
			this.CLIENT_SOCODE.Format = "";
			this.CLIENT_SOCODE.FormatInfo = null;
			this.CLIENT_SOCODE.HeaderText = "客户合同号";
			this.CLIENT_SOCODE.MappingName = "CLIENT_SOCODE";
			this.CLIENT_SOCODE.NullText = "";
			this.CLIENT_SOCODE.Width = 75;
			// 
			// AMOUNT
			// 
			this.AMOUNT.Format = "";
			this.AMOUNT.FormatInfo = null;
			this.AMOUNT.HeaderText = "总金额";
			this.AMOUNT.MappingName = "AMOUNT";
			this.AMOUNT.NullText = "";
			this.AMOUNT.Width = 75;
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
			// deliverydate
			// 
			this.deliverydate.Format = "";
			this.deliverydate.FormatInfo = null;
			this.deliverydate.HeaderText = "装运日期";
			this.deliverydate.MappingName = "deliverydate";
			this.deliverydate.NullText = "";
			this.deliverydate.Width = 75;
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
			// frmLCDoc
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
			this.Name = "frmLCDoc";
			this.Text = "信用证管理";
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
					sb.Append("  系统中已存在该信用证号，请重新命名！");
					TJSystem.Public.PublicStatic.ShowMessage(TJSystem.Public.MessageType.Error,sb.ToString());
					return false;
				}
			}

			if(!TJSystem.Public.PublicStatic.IsNumDouble(this.priTextBox16.Text.Trim()))
			{
				sb.Append("  总金额必须是数字");
				TJSystem.Public.PublicStatic.ShowMessage(TJSystem.Public.MessageType.Error,sb.ToString());
				return false;
			}
			return true;
		}

		private void InitialGrid(string sql)
		{		
			DataTable dt = TJSystem.Public.PublicStatic.db.GetDataTable(sql);
			dt.TableName = "SALE_LETTEROFCREDIT";
			this.dataGrid1.DataSource = dt.DefaultView;
		}

		private void AfterButtonClick(string ButtonType)
		{
			if(ButtonType.Equals("insert"))
			{
				this.textBox1.Enabled = true;
				this.priTextBox1.Enabled = true;
				
				this.priTextBox3.Enabled = true;
				
				this.priTextBox14.Enabled = true;
				this.priTextBox16.Enabled = true;
				this.priTextBox17.Enabled = true;
				this.priTextBox18.Enabled = true;
				this.priTextBox21.Enabled = true;
				this.priTextBox26.Enabled = true;
				this.priTextBox29.Enabled = true;
				
				this.priTextBox30.Enabled = true;
				this.priTextBox33.Enabled = true;
				
				this.priTextBox36.Enabled = true;
				this.priTextBox37.Enabled = true;
				this.priTextBox38.Enabled = true;

				this.comboBox1.Enabled = true;
				this.priComboBox1.Enabled = false;
				this.priComboBox4.Enabled = true;
				this.priComboBox5.Enabled = true;
				this.priComboBox6.Enabled = true;
				this.priComboBox8.Enabled = true;
				this.priComboBox9.Enabled = true;
				this.priComboBox10.Enabled = true;
				this.priComboBox11.Enabled = true;
				this.priComboBox12.Enabled = true;

				this.priDateTimePicker3.Enabled = true;
				this.priDateTimePicker5.Enabled = true;	
				
				
				this.textBox1.Text = "" ;
				this.priTextBox1.Text = "";
				
				this.priTextBox3.Text = "";
				this.priTextBox14.Text = "";
				this.priTextBox16.Text = "";
				this.priTextBox17.Text = "";
				this.priTextBox18.Text = "";
				
				this.priTextBox21.Text = "";
				this.priTextBox26.Text = "";
				this.priTextBox29.Text = "";
				
				this.priTextBox30.Text = "";
				this.priTextBox33.Text = "";
				
				this.priTextBox36.Text = "";
				this.priTextBox37.Text = "";
				this.priTextBox38.Text = "";

				this.comboBox1.Text = "";
				this.priComboBox1.SelectedValue = "1";
				this.priComboBox4.Text = "";
				this.priComboBox5.Text = "";
				this.priComboBox6.Text = "";
				this.priComboBox8.Text = "";
				this.priComboBox9.Text = "";
				this.priComboBox10.Text = "";
				this.priComboBox11.Text = "";
				this.priComboBox12.Text = "";
				this.priDateTimePicker3.Value = System.DateTime.Now;
				this.priDateTimePicker5.Value = System.DateTime.Now;	
				
			}
			else if(ButtonType.Equals("update"))
			{
				this.textBox1.Enabled = false;
				this.priTextBox1.Enabled = true;
				
				this.priTextBox3.Enabled = true;
				this.priTextBox14.Enabled = true;
				this.priTextBox16.Enabled = true;
				this.priTextBox17.Enabled = true;
				this.priTextBox18.Enabled = true;
				this.priTextBox21.Enabled = true;
				this.priTextBox26.Enabled = true;
				this.priTextBox29.Enabled = true;
				
				this.priTextBox30.Enabled = true;
				this.priTextBox33.Enabled = true;
				
				this.priTextBox36.Enabled = true;
				this.priTextBox37.Enabled = true;
				this.priTextBox38.Enabled = true;

				this.comboBox1.Enabled = true;
				this.priComboBox1.Enabled = false;
				this.priComboBox4.Enabled = true;
				this.priComboBox5.Enabled = true;
				this.priComboBox6.Enabled = true;
				this.priComboBox8.Enabled = true;
				this.priComboBox9.Enabled = true;
				this.priComboBox10.Enabled = true;
				this.priComboBox11.Enabled = true;
				this.priComboBox12.Enabled = true;

				this.priDateTimePicker3.Enabled = true;
				this.priDateTimePicker5.Enabled = true;	
					
			}
			//this.priToolBar1.SetStatusEnable(this.priComboBox1);
		}

		private void setDisable()
		{
			this.textBox1.Enabled = false;
			this.priTextBox1.Enabled = false;
			this.priTextBox2.Enabled = false;
			this.priTextBox3.Enabled = false;
			this.priTextBox6.Enabled = false;
			this.priTextBox7.Enabled = false;
			this.priTextBox8.Enabled = false;
			this.priTextBox16.Enabled = false;
			this.priTextBox17.Enabled = false;
			this.priTextBox18.Enabled = false;
			this.priTextBox21.Enabled = false;
			this.priTextBox26.Enabled = false;
			this.priTextBox29.Enabled = false;
				
			this.priTextBox30.Enabled = false;
			this.priTextBox33.Enabled = false;
			this.priTextBox35.Enabled = false;
			this.priTextBox36.Enabled = false;
			this.priTextBox37.Enabled = false;
			this.priTextBox38.Enabled = false;

			this.comboBox1.Enabled = false;
			this.priComboBox1.Enabled = false;
			this.priComboBox4.Enabled = false;
			this.priComboBox5.Enabled = false;
			this.priComboBox6.Enabled = false;
			this.priComboBox8.Enabled = false;
			this.priComboBox9.Enabled = false;
			this.priComboBox10.Enabled = false;
			this.priComboBox11.Enabled = false;
			this.priComboBox12.Enabled = false;

			this.priDateTimePicker3.Enabled = false;
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
				TJSystem.Public.PublicStatic.formName = "信用证管理";
			}
			base.OnClosing (e);
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

		private void priComboBox1_SelectionChangeCommitted(object sender, System.EventArgs e)
		{
			TJSystem.Public.PublicStatic.SetApprovedInfo(this.priComboBox1,this.priTextBox14,this.priTextBox17);
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

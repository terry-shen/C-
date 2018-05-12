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
	public class frmSaleOrderList : System.Windows.Forms.Form
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
		private System.Windows.Forms.DataGridTextBoxColumn createby;
		private System.Windows.Forms.DataGridTextBoxColumn resume;
		private System.Windows.Forms.DataGridTextBoxColumn gen_manager;
		private System.Windows.Forms.DataGridTextBoxColumn postcode;
		private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn2;
		private System.Windows.Forms.DataGridTextBoxColumn address;
		private System.Windows.Forms.DataGridTextBoxColumn corporation;
		private System.Windows.Forms.DataGridTextBoxColumn company_id;
		private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn1;
		private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn4;
		private System.Windows.Forms.DataGridTextBoxColumn modifyon;
		private System.Windows.Forms.DataGridTextBoxColumn createon;
		private System.Windows.Forms.DataGridTextBoxColumn modifyby;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.DataGrid dataGrid1;
		private System.Windows.Forms.DataGridTextBoxColumn fax2;
		private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn3;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.DataGridTextBoxColumn website;
		private System.Windows.Forms.DataGridTextBoxColumn tel2;
		public static System.Windows.Forms.Form frmCurrent = null ;
		public string _PK;
		private System.Windows.Forms.LinkLabel lk_detail;
		private System.Windows.Forms.DataGridTableStyle dataGridTableStyle1;
		private System.Windows.Forms.DataGridTextBoxColumn so_code;
		private System.Windows.Forms.DataGridTextBoxColumn so_date;
		private System.Windows.Forms.DataGridTextBoxColumn client_orderNo;
		private System.Windows.Forms.DataGridTextBoxColumn status;
		private System.Windows.Forms.DataGridTextBoxColumn client_id;
		private System.Windows.Forms.DataGridTextBoxColumn client_name;
		private System.Windows.Forms.DataGridTextBoxColumn contact_id;
		private System.Windows.Forms.DataGridTextBoxColumn contact_name;
		private System.Windows.Forms.DataGridTextBoxColumn currency;
		private System.Windows.Forms.DataGridTextBoxColumn discounttype;
		private System.Windows.Forms.DataGridTextBoxColumn discount;
		private System.Windows.Forms.DataGridTextBoxColumn settlementtype;
		private System.Windows.Forms.DataGridTextBoxColumn fobamount;
		private System.Windows.Forms.DataGridTextBoxColumn brightcommision;
		private System.Windows.Forms.DataGridTextBoxColumn darkcommision;
		private System.Windows.Forms.DataGridTextBoxColumn deliverydate;
		private System.Windows.Forms.DataGridTextBoxColumn transType;
		private System.Windows.Forms.DataGridTextBoxColumn arriveregion;
		private System.Windows.Forms.DataGridTextBoxColumn Port_departure;
		private System.Windows.Forms.DataGridTextBoxColumn arrivecountry;
		private System.Windows.Forms.DataGridTextBoxColumn destport;
		private System.Windows.Forms.DataGridTextBoxColumn destination;
		private System.Windows.Forms.DataGridTextBoxColumn remark;
		private System.Windows.Forms.DataGridTextBoxColumn priceterm;
		private System.Windows.Forms.DataGridTextBoxColumn priceterm_dest;
		private string _statusType = null;
		private System.Windows.Forms.DataGridBoolColumn selected;
		private TJSystem.Classes.XpStyleButton button1;
		public static int Count = 0;
		public frmSaleOrderList()
		{
			//
			// Windows 窗体设计器支持所必需的
			//
			InitializeComponent();

			
			_statusType = "sales";
			TJSystem.Public.PublicStatic.setBackgroundImg(this.panel1,this.panel1.GetType().ToString(),"images\\bg.gif");
			TJSystem.Public.PublicStatic.setBackgroundImg(this.panel2,this.panel1.GetType().ToString(),"");

			System.Text.StringBuilder sb = new System.Text.StringBuilder();
			sb.Append("select 'N' as selected,a.so_code,a.so_date,a.client_orderNo,b.status_name as status,a.client_id,a.client_name,a.Contact_id,a.Contact_name,c.Currency_namecn as Currency,a.priceTerm,a.priceTerm_dest,");
			sb.Append("a.discountType,a.discount,a.settlementType,a.fobamount,a.brightcommision,a.darkcommision,a.deliverydate,d.trans_namecn as transType,e.region_namecn as arriveregion,g.country_namecn as arrivecountry,f.port_namecn as Port_departure,h.port_namecn as destport,a.destination,a.marks,a.remark,a.createBy,a.createon,a.approvedBy,a.approvedon,a.modifyBy,a.modifyon,a.confirmedBy,a.confirmedon ");
			sb.Append("from sale_so_master a");
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
			sb.Append(" order by a.so_code");
			this.InitialGrid(sb.ToString());

			
			_PK = "cq_code";
			
			
			// TODO: 在 InitializeComponent 调用后添加任何构造函数代码
			//
		}

		
		private void InitialGrid(string sql)
		{		
			DataTable dt = TJSystem.Public.PublicStatic.db.GetDataTable(sql);
			dt.TableName = "sale_so_master";
			this.dataGrid1.DataSource = dt.DefaultView;
		}

//		private void InitialGrid1(string sql)
//		{		
//			DataTable dt = TJSystem.Public.PublicStatic.db.GetDataTable(sql);
//			dt.TableName = "sale_so_deatil";
//			this.dataGrid2.DataSource = dt.DefaultView;
//		}

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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(frmSaleOrderList));
			this.fax1 = new System.Windows.Forms.DataGridTextBoxColumn();
			this.email2 = new System.Windows.Forms.DataGridTextBoxColumn();
			this.address_cn = new System.Windows.Forms.DataGridTextBoxColumn();
			this.company_name = new System.Windows.Forms.DataGridTextBoxColumn();
			this.company_name_cn = new System.Windows.Forms.DataGridTextBoxColumn();
			this.email1 = new System.Windows.Forms.DataGridTextBoxColumn();
			this.tel1 = new System.Windows.Forms.DataGridTextBoxColumn();
			this.createby = new System.Windows.Forms.DataGridTextBoxColumn();
			this.resume = new System.Windows.Forms.DataGridTextBoxColumn();
			this.gen_manager = new System.Windows.Forms.DataGridTextBoxColumn();
			this.postcode = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumn2 = new System.Windows.Forms.DataGridTextBoxColumn();
			this.address = new System.Windows.Forms.DataGridTextBoxColumn();
			this.corporation = new System.Windows.Forms.DataGridTextBoxColumn();
			this.company_id = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumn1 = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumn4 = new System.Windows.Forms.DataGridTextBoxColumn();
			this.modifyon = new System.Windows.Forms.DataGridTextBoxColumn();
			this.createon = new System.Windows.Forms.DataGridTextBoxColumn();
			this.modifyby = new System.Windows.Forms.DataGridTextBoxColumn();
			this.panel2 = new System.Windows.Forms.Panel();
			this.button1 = new TJSystem.Classes.XpStyleButton();
			this.dataGrid1 = new System.Windows.Forms.DataGrid();
			this.dataGridTableStyle1 = new System.Windows.Forms.DataGridTableStyle();
			this.selected = new System.Windows.Forms.DataGridBoolColumn();
			this.so_code = new System.Windows.Forms.DataGridTextBoxColumn();
			this.so_date = new System.Windows.Forms.DataGridTextBoxColumn();
			this.client_orderNo = new System.Windows.Forms.DataGridTextBoxColumn();
			this.status = new System.Windows.Forms.DataGridTextBoxColumn();
			this.client_id = new System.Windows.Forms.DataGridTextBoxColumn();
			this.client_name = new System.Windows.Forms.DataGridTextBoxColumn();
			this.contact_id = new System.Windows.Forms.DataGridTextBoxColumn();
			this.contact_name = new System.Windows.Forms.DataGridTextBoxColumn();
			this.currency = new System.Windows.Forms.DataGridTextBoxColumn();
			this.priceterm = new System.Windows.Forms.DataGridTextBoxColumn();
			this.priceterm_dest = new System.Windows.Forms.DataGridTextBoxColumn();
			this.discounttype = new System.Windows.Forms.DataGridTextBoxColumn();
			this.discount = new System.Windows.Forms.DataGridTextBoxColumn();
			this.settlementtype = new System.Windows.Forms.DataGridTextBoxColumn();
			this.fobamount = new System.Windows.Forms.DataGridTextBoxColumn();
			this.brightcommision = new System.Windows.Forms.DataGridTextBoxColumn();
			this.darkcommision = new System.Windows.Forms.DataGridTextBoxColumn();
			this.deliverydate = new System.Windows.Forms.DataGridTextBoxColumn();
			this.transType = new System.Windows.Forms.DataGridTextBoxColumn();
			this.arriveregion = new System.Windows.Forms.DataGridTextBoxColumn();
			this.Port_departure = new System.Windows.Forms.DataGridTextBoxColumn();
			this.arrivecountry = new System.Windows.Forms.DataGridTextBoxColumn();
			this.destport = new System.Windows.Forms.DataGridTextBoxColumn();
			this.destination = new System.Windows.Forms.DataGridTextBoxColumn();
			this.remark = new System.Windows.Forms.DataGridTextBoxColumn();
			this.lk_detail = new System.Windows.Forms.LinkLabel();
			this.fax2 = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumn3 = new System.Windows.Forms.DataGridTextBoxColumn();
			this.panel1 = new System.Windows.Forms.Panel();
			this.label1 = new System.Windows.Forms.Label();
			this.website = new System.Windows.Forms.DataGridTextBoxColumn();
			this.tel2 = new System.Windows.Forms.DataGridTextBoxColumn();
			this.panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).BeginInit();
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
			// createby
			// 
			this.createby.Format = "";
			this.createby.FormatInfo = null;
			this.createby.HeaderText = "建立者";
			this.createby.MappingName = "createby";
			this.createby.NullText = "";
			this.createby.Width = 75;
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
			// postcode
			// 
			this.postcode.Format = "";
			this.postcode.FormatInfo = null;
			this.postcode.HeaderText = "邮政编码";
			this.postcode.MappingName = "postcode";
			this.postcode.NullText = "";
			this.postcode.Width = 75;
			// 
			// dataGridTextBoxColumn2
			// 
			this.dataGridTextBoxColumn2.Format = "";
			this.dataGridTextBoxColumn2.FormatInfo = null;
			this.dataGridTextBoxColumn2.HeaderText = "员工姓名";
			this.dataGridTextBoxColumn2.MappingName = "";
			this.dataGridTextBoxColumn2.NullText = "";
			this.dataGridTextBoxColumn2.Width = 75;
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
			// dataGridTextBoxColumn1
			// 
			this.dataGridTextBoxColumn1.Format = "";
			this.dataGridTextBoxColumn1.FormatInfo = null;
			this.dataGridTextBoxColumn1.HeaderText = "员工编号";
			this.dataGridTextBoxColumn1.MappingName = "employee_id";
			this.dataGridTextBoxColumn1.NullText = "";
			this.dataGridTextBoxColumn1.Width = 75;
			// 
			// dataGridTextBoxColumn4
			// 
			this.dataGridTextBoxColumn4.Format = "";
			this.dataGridTextBoxColumn4.FormatInfo = null;
			this.dataGridTextBoxColumn4.HeaderText = "性别";
			this.dataGridTextBoxColumn4.MappingName = "Gender";
			this.dataGridTextBoxColumn4.NullText = "";
			this.dataGridTextBoxColumn4.Width = 75;
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
			// createon
			// 
			this.createon.Format = "";
			this.createon.FormatInfo = null;
			this.createon.HeaderText = "建立时间";
			this.createon.MappingName = "createon";
			this.createon.NullText = "";
			this.createon.Width = 75;
			// 
			// modifyby
			// 
			this.modifyby.Format = "";
			this.modifyby.FormatInfo = null;
			this.modifyby.HeaderText = "最后修改者";
			this.modifyby.MappingName = "modifyby";
			this.modifyby.NullText = "";
			this.modifyby.Width = 75;
			// 
			// panel2
			// 
			this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
			this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.panel2.Controls.Add(this.button1);
			this.panel2.Controls.Add(this.dataGrid1);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel2.Location = new System.Drawing.Point(0, 48);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(784, 518);
			this.panel2.TabIndex = 17;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(8, 472);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(88, 32);
			this.button1.TabIndex = 2;
			this.button1.Text = "确定";
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// dataGrid1
			// 
			this.dataGrid1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.dataGrid1.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.dataGrid1.CaptionBackColor = System.Drawing.SystemColors.ActiveBorder;
			this.dataGrid1.CaptionText = "销售订单";
			this.dataGrid1.DataMember = "";
			this.dataGrid1.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.dataGrid1.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.dataGrid1.Location = new System.Drawing.Point(0, 0);
			this.dataGrid1.Name = "dataGrid1";
			this.dataGrid1.Size = new System.Drawing.Size(776, 456);
			this.dataGrid1.TabIndex = 1;
			this.dataGrid1.TableStyles.AddRange(new System.Windows.Forms.DataGridTableStyle[] {
																								  this.dataGridTableStyle1});
			// 
			// dataGridTableStyle1
			// 
			this.dataGridTableStyle1.DataGrid = this.dataGrid1;
			this.dataGridTableStyle1.GridColumnStyles.AddRange(new System.Windows.Forms.DataGridColumnStyle[] {
																												  this.selected,
																												  this.so_code,
																												  this.so_date,
																												  this.client_orderNo,
																												  this.status,
																												  this.client_id,
																												  this.client_name,
																												  this.contact_id,
																												  this.contact_name,
																												  this.currency,
																												  this.priceterm,
																												  this.priceterm_dest,
																												  this.discounttype,
																												  this.discount,
																												  this.settlementtype,
																												  this.fobamount,
																												  this.brightcommision,
																												  this.darkcommision,
																												  this.deliverydate,
																												  this.transType,
																												  this.arriveregion,
																												  this.Port_departure,
																												  this.arrivecountry,
																												  this.destport,
																												  this.destination,
																												  this.remark});
			this.dataGridTableStyle1.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.dataGridTableStyle1.MappingName = "sale_so_master";
			// 
			// selected
			// 
			this.selected.FalseValue = "N";
			this.selected.HeaderText = "选择";
			this.selected.MappingName = "selected";
			this.selected.NullText = "";
			this.selected.NullValue = ((object)(resources.GetObject("selected.NullValue")));
			this.selected.TrueValue = "Y";
			this.selected.Width = 75;
			// 
			// so_code
			// 
			this.so_code.Format = "";
			this.so_code.FormatInfo = null;
			this.so_code.HeaderText = "订单号";
			this.so_code.MappingName = "so_code";
			this.so_code.NullText = "";
			this.so_code.ReadOnly = true;
			this.so_code.Width = 75;
			// 
			// so_date
			// 
			this.so_date.Format = "";
			this.so_date.FormatInfo = null;
			this.so_date.HeaderText = "订单日期";
			this.so_date.MappingName = "so_date";
			this.so_date.NullText = "";
			this.so_date.ReadOnly = true;
			this.so_date.Width = 75;
			// 
			// client_orderNo
			// 
			this.client_orderNo.Format = "";
			this.client_orderNo.FormatInfo = null;
			this.client_orderNo.HeaderText = "客户单号";
			this.client_orderNo.MappingName = "client_orderNo";
			this.client_orderNo.NullText = "";
			this.client_orderNo.ReadOnly = true;
			this.client_orderNo.Width = 75;
			// 
			// status
			// 
			this.status.Format = "";
			this.status.FormatInfo = null;
			this.status.HeaderText = "状态";
			this.status.MappingName = "status";
			this.status.NullText = "";
			this.status.ReadOnly = true;
			this.status.Width = 75;
			// 
			// client_id
			// 
			this.client_id.Format = "";
			this.client_id.FormatInfo = null;
			this.client_id.HeaderText = "客户代码";
			this.client_id.MappingName = "client_id";
			this.client_id.NullText = "";
			this.client_id.ReadOnly = true;
			this.client_id.Width = 75;
			// 
			// client_name
			// 
			this.client_name.Format = "";
			this.client_name.FormatInfo = null;
			this.client_name.HeaderText = "客户名称";
			this.client_name.MappingName = "client_name";
			this.client_name.NullText = "";
			this.client_name.ReadOnly = true;
			this.client_name.Width = 75;
			// 
			// contact_id
			// 
			this.contact_id.Format = "";
			this.contact_id.FormatInfo = null;
			this.contact_id.HeaderText = "联系人代码";
			this.contact_id.MappingName = "contact_id";
			this.contact_id.NullText = "";
			this.contact_id.ReadOnly = true;
			this.contact_id.Width = 75;
			// 
			// contact_name
			// 
			this.contact_name.Format = "";
			this.contact_name.FormatInfo = null;
			this.contact_name.HeaderText = "联系人";
			this.contact_name.MappingName = "contact_name";
			this.contact_name.NullText = "";
			this.contact_name.ReadOnly = true;
			this.contact_name.Width = 75;
			// 
			// currency
			// 
			this.currency.Format = "";
			this.currency.FormatInfo = null;
			this.currency.HeaderText = "币种";
			this.currency.MappingName = "currency";
			this.currency.NullText = "";
			this.currency.ReadOnly = true;
			this.currency.Width = 75;
			// 
			// priceterm
			// 
			this.priceterm.Format = "";
			this.priceterm.FormatInfo = null;
			this.priceterm.HeaderText = "价格条款";
			this.priceterm.MappingName = "priceterm";
			this.priceterm.NullText = "";
			this.priceterm.ReadOnly = true;
			this.priceterm.Width = 75;
			// 
			// priceterm_dest
			// 
			this.priceterm_dest.Format = "";
			this.priceterm_dest.FormatInfo = null;
			this.priceterm_dest.HeaderText = "价格条款明细";
			this.priceterm_dest.MappingName = "priceterm_dest";
			this.priceterm_dest.NullText = "";
			this.priceterm_dest.ReadOnly = true;
			this.priceterm_dest.Width = 75;
			// 
			// discounttype
			// 
			this.discounttype.Format = "";
			this.discounttype.FormatInfo = null;
			this.discounttype.HeaderText = "折扣类型";
			this.discounttype.MappingName = "discounttype";
			this.discounttype.ReadOnly = true;
			this.discounttype.Width = 75;
			// 
			// discount
			// 
			this.discount.Format = "";
			this.discount.FormatInfo = null;
			this.discount.HeaderText = "折扣";
			this.discount.MappingName = "discount";
			this.discount.NullText = "";
			this.discount.ReadOnly = true;
			this.discount.Width = 75;
			// 
			// settlementtype
			// 
			this.settlementtype.Format = "";
			this.settlementtype.FormatInfo = null;
			this.settlementtype.HeaderText = "结汇方式";
			this.settlementtype.MappingName = "settlementtype";
			this.settlementtype.NullText = "";
			this.settlementtype.ReadOnly = true;
			this.settlementtype.Width = 75;
			// 
			// fobamount
			// 
			this.fobamount.Format = "";
			this.fobamount.FormatInfo = null;
			this.fobamount.HeaderText = "FOB金额";
			this.fobamount.MappingName = "fobamount";
			this.fobamount.NullText = "";
			this.fobamount.ReadOnly = true;
			this.fobamount.Width = 75;
			// 
			// brightcommision
			// 
			this.brightcommision.Format = "";
			this.brightcommision.FormatInfo = null;
			this.brightcommision.HeaderText = "明佣";
			this.brightcommision.MappingName = "brightcommision";
			this.brightcommision.NullText = "";
			this.brightcommision.ReadOnly = true;
			this.brightcommision.Width = 75;
			// 
			// darkcommision
			// 
			this.darkcommision.Format = "";
			this.darkcommision.FormatInfo = null;
			this.darkcommision.HeaderText = "暗佣";
			this.darkcommision.MappingName = "darkcommision";
			this.darkcommision.NullText = "";
			this.darkcommision.ReadOnly = true;
			this.darkcommision.Width = 75;
			// 
			// deliverydate
			// 
			this.deliverydate.Format = "";
			this.deliverydate.FormatInfo = null;
			this.deliverydate.HeaderText = "交货期";
			this.deliverydate.MappingName = "deliverydate";
			this.deliverydate.NullText = "";
			this.deliverydate.ReadOnly = true;
			this.deliverydate.Width = 75;
			// 
			// transType
			// 
			this.transType.Format = "";
			this.transType.FormatInfo = null;
			this.transType.HeaderText = "运输方式";
			this.transType.MappingName = "transType";
			this.transType.NullText = "";
			this.transType.ReadOnly = true;
			this.transType.Width = 75;
			// 
			// arriveregion
			// 
			this.arriveregion.Format = "";
			this.arriveregion.FormatInfo = null;
			this.arriveregion.HeaderText = "目的地";
			this.arriveregion.MappingName = "arriveregion";
			this.arriveregion.NullText = "";
			this.arriveregion.ReadOnly = true;
			this.arriveregion.Width = 75;
			// 
			// Port_departure
			// 
			this.Port_departure.Format = "";
			this.Port_departure.FormatInfo = null;
			this.Port_departure.HeaderText = "起运港";
			this.Port_departure.MappingName = "Port_departure";
			this.Port_departure.NullText = "";
			this.Port_departure.ReadOnly = true;
			this.Port_departure.Width = 75;
			// 
			// arrivecountry
			// 
			this.arrivecountry.Format = "";
			this.arrivecountry.FormatInfo = null;
			this.arrivecountry.HeaderText = "运抵国";
			this.arrivecountry.MappingName = "arrivecountry";
			this.arrivecountry.NullText = "";
			this.arrivecountry.ReadOnly = true;
			this.arrivecountry.Width = 75;
			// 
			// destport
			// 
			this.destport.Format = "";
			this.destport.FormatInfo = null;
			this.destport.HeaderText = "目的港";
			this.destport.MappingName = "destport";
			this.destport.NullText = "";
			this.destport.ReadOnly = true;
			this.destport.Width = 75;
			// 
			// destination
			// 
			this.destination.Format = "";
			this.destination.FormatInfo = null;
			this.destination.HeaderText = "唛头";
			this.destination.MappingName = "destination";
			this.destination.NullText = "";
			this.destination.ReadOnly = true;
			this.destination.Width = 75;
			// 
			// remark
			// 
			this.remark.Format = "";
			this.remark.FormatInfo = null;
			this.remark.HeaderText = "备注";
			this.remark.MappingName = "remark";
			this.remark.NullText = "";
			this.remark.ReadOnly = true;
			this.remark.Width = 75;
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
			// dataGridTextBoxColumn3
			// 
			this.dataGridTextBoxColumn3.Format = "";
			this.dataGridTextBoxColumn3.FormatInfo = null;
			this.dataGridTextBoxColumn3.HeaderText = "英文名";
			this.dataGridTextBoxColumn3.MappingName = "";
			this.dataGridTextBoxColumn3.NullText = "";
			this.dataGridTextBoxColumn3.Width = 75;
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
			// frmSaleOrderList
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(7, 16);
			this.BackColor = System.Drawing.SystemColors.ScrollBar;
			this.ClientSize = new System.Drawing.Size(784, 566);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "frmSaleOrderList";
			this.Text = "销售订单";
			this.panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).EndInit();
			this.panel1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion


		private void button1_Click(object sender, System.EventArgs e)
		{
			System.Text.StringBuilder sb = new System.Text.StringBuilder();
			System.Data.DataView dv = (System.Data.DataView)this.dataGrid1.DataSource;
			for(int i = 0; i < dv.Count; i ++)
			{
				if(dv[i][0].ToString().Equals("Y"))
				{
					sb.Append(dv[i][1].ToString());
					sb.Append(",");
				}
			}

			string column = "";
			if(sb.ToString().Length > 0)
			{
				column = sb.ToString().Substring(0,sb.ToString().Length-1);
			}

			TJSystem.Public.PublicStatic.SOList = column;

			this.Close();
		}
	}
}

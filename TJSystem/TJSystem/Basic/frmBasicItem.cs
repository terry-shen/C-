using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace TJSystem.Basic
{
	/// <summary>
	/// Form1 的摘要说明。
	/// </summary>
	public class frmBasicItem : System.Windows.Forms.Form
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
		private TJSystem.Classes.PriComboBox priComboBox2;
		private System.Windows.Forms.Label label29;
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
		private TJSystem.Classes.PriTextBox priTextBox24;
		private System.Windows.Forms.Label label21;
		private TJSystem.Classes.PriTextBox priTextBox17;
		private System.Windows.Forms.Label label19;
		private TJSystem.Classes.PriTextBox priTextBox15;
		private System.Windows.Forms.Label label18;
		private TJSystem.Classes.PriTextBox priTextBox14;
		private System.Windows.Forms.Label label16;
		private System.Windows.Forms.Label label17;
		private TJSystem.Classes.PriTextBox priTextBox13;
		private System.Windows.Forms.Label label15;
		private TJSystem.Classes.PriTextBox priTextBox11;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.Label label13;
		private TJSystem.Classes.PriTextBox priTextBox10;
		private System.Windows.Forms.Label label12;
		private TJSystem.Classes.PriTextBox priTextBox9;
		private System.Windows.Forms.Label label11;
		private TJSystem.Classes.PriTextBox priTextBox8;
		private System.Windows.Forms.Label label10;
		private TJSystem.Classes.PriTextBox priTextBox7;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private TJSystem.Classes.PriComboBox comboBox1;
		private TJSystem.Classes.PriTextBox textBox1;
		private TJSystem.Classes.PriTextBox priTextBox2;
		private TJSystem.Classes.PriTextBox priTextBox3;
		private System.Windows.Forms.DataGrid dataGrid1;
		private System.Windows.Forms.DataGridTableStyle dataGridTableStyle1;
		private TJSystem.Classes.PriComboBox priComboBox3;
		private TJSystem.Classes.PriComboBox priComboBox4;
		private TJSystem.Classes.PriComboBox priComboBox5;
		private TJSystem.Classes.PriComboBox priComboBox6;
		private System.Windows.Forms.Label label30;
		private TJSystem.Classes.PriComboBox priComboBox7;
		private TJSystem.Classes.PriComboBox priComboBox8;
		private System.Windows.Forms.Label label31;
		private System.Windows.Forms.Label label32;
		private TJSystem.Classes.PriTextBox priTextBox1;
		private System.Windows.Forms.Label label33;
		private TJSystem.Classes.PriTextBox priTextBox5;
		private TJSystem.Classes.PriTextBox priTextBox6;
		private System.Windows.Forms.Label label34;
		private TJSystem.Classes.PriTextBox priTextBox26;
		private System.Windows.Forms.Label label35;
		private TJSystem.Classes.PriTextBox priTextBox27;
		private System.Windows.Forms.Label label36;
		private TJSystem.Classes.PriTextBox priTextBox28;
		private System.Windows.Forms.Label label20;
		private TJSystem.Classes.PriTextBox priTextBox16;
		private System.Windows.Forms.Label label37;
		private TJSystem.Classes.PriTextBox priTextBox29;
		private TJSystem.Classes.PriComboBox priComboBox1;
		private System.Windows.Forms.LinkLabel linkLabel1;
		private System.Windows.Forms.LinkLabel linkLabel2;
		private System.Windows.Forms.LinkLabel linkLabel3;
		private System.Windows.Forms.LinkLabel linkLabel4;
		public static System.Windows.Forms.Form frmCurrent = null ;
		private string _statusType = null;
		private string _table = null;
		private string _PK = null;
		private System.Windows.Forms.DataGridTextBoxColumn item_code;
		private System.Windows.Forms.DataGridTextBoxColumn item_name;
		private System.Windows.Forms.DataGridTextBoxColumn item_name_cn;
		private System.Windows.Forms.DataGridTextBoxColumn item_desc;
		private System.Windows.Forms.DataGridTextBoxColumn item_desc_cn;
		private System.Windows.Forms.DataGridTextBoxColumn hs_name;
		private System.Windows.Forms.DataGridTextBoxColumn hs_code;
		private System.Windows.Forms.DataGridTextBoxColumn typenamecn;
		private System.Windows.Forms.DataGridTextBoxColumn sale_currency_name;
		private System.Windows.Forms.DataGridTextBoxColumn saleprice;
		private System.Windows.Forms.DataGridTextBoxColumn purchaseprice;
		private System.Windows.Forms.DataGridTextBoxColumn pur_currency_name;
		private System.Windows.Forms.DataGridTextBoxColumn minorder;
		private System.Windows.Forms.DataGridTextBoxColumn remark;
		private System.Windows.Forms.DataGridTextBoxColumn status_name;
		private System.Windows.Forms.DataGridTextBoxColumn unit_name_cn;
		private System.Windows.Forms.DataGridTextBoxColumn packingtype;
		private System.Windows.Forms.DataGridTextBoxColumn outsidepack;
		private System.Windows.Forms.DataGridTextBoxColumn PACK_METHOD_NAME;
		private System.Windows.Forms.DataGridTextBoxColumn PACK_NAMECN;
		private System.Windows.Forms.DataGridTextBoxColumn insidepack;
		private System.Windows.Forms.DataGridTextBoxColumn netweight;
		private System.Windows.Forms.DataGridTextBoxColumn grossweight;
		private System.Windows.Forms.DataGridTextBoxColumn length;
		private System.Windows.Forms.DataGridTextBoxColumn width;
		private System.Windows.Forms.DataGridTextBoxColumn height;
		private System.Windows.Forms.DataGridTextBoxColumn culboxby;
		private System.Windows.Forms.DataGridTextBoxColumn packrate20;
		private System.Windows.Forms.DataGridTextBoxColumn packrate40;
		private System.Windows.Forms.DataGridTextBoxColumn packrate40hq;
		private System.Windows.Forms.DataGridTextBoxColumn property1;
		private System.Windows.Forms.DataGridTextBoxColumn property2;
		private System.Windows.Forms.DataGridTextBoxColumn createby;
		private System.Windows.Forms.DataGridTextBoxColumn createon;
		private System.Windows.Forms.DataGridTextBoxColumn modifyby;
		private System.Windows.Forms.DataGridTextBoxColumn modifyon;
		private System.Windows.Forms.DataGridTextBoxColumn volumn;
		private System.Windows.Forms.LinkLabel linkLabel5;
		private System.Windows.Forms.LinkLabel linkLabel6;
		private System.Windows.Forms.LinkLabel linkLabel7;
		private System.Windows.Forms.LinkLabel linkLabel8;

		private System.Windows.Forms.Form _form = null;
#if false
		private string mSQL = null;
#endif
		public frmBasicItem()
		{
			//
			// Windows 窗体设计器支持所必需的
			//
			InitializeComponent();
			


			_statusType = "basic";

			TJSystem.Public.PublicStatic.setBackgroundImg(this.panel1,this.panel1.GetType().ToString(),"images\\bg.gif");
			TJSystem.Public.PublicStatic.setBackgroundImg(this.panel2,this.panel1.GetType().ToString(),"");
			TJSystem.Public.PublicStatic.setBackgroundImg(this.panel3,this.panel1.GetType().ToString(),"");
			TJSystem.Public.PublicStatic.setBackgroundImg(this.panel4,this.panel1.GetType().ToString(),"");

			this.Cursor = System.Windows.Forms.Cursors.WaitCursor;
			InitialFormData();
			

			System.Text.StringBuilder sb = new System.Text.StringBuilder();
			sb.Append("select a.item_code,a.item_name,a.item_name_cn,a.item_desc,a.item_desc_cn,a.hs_code,a.hs_code+' '+b.item_name as hs_name, ");
			sb.Append(" a.item_type,c.typenamecn as typenamecn,a.currency,d.currency_namecn as sale_currency_name,a.saleprice,");
			sb.Append(" a.pur_currency,e.currency_namecn as pur_currency_name,a.purchaseprice,a.minorder,a.remark,");
			sb.Append(" a.status,i.status_name,a.unit,f.unit_name_cn,a.packingtype,a.outsidepack,a.outsiepacktype,g.PACK_METHOD_NAME,");
			sb.Append(" a.insidepack,a.insidepacktype,h.PACK_NAMECN,a.netweight,a.grossweight,a.length,a.width,a.height,a.volumn,");
			sb.Append(" a.culboxby,a.packrate20,a.packrate40,a.packrate40,a.packrate40hq,a.picture,");
			sb.Append(" a.property1,a.property2,a.createby,a.createon,a.modifyby,a.modifyon");
			sb.Append(" from basic_item a");
			sb.Append(" left join p_hscode b on a.hs_code=b.hs_code");
			sb.Append(" left join p_status i on a.status=i.status_id and i.status_type=");
			sb.Append("'");
			sb.Append(this._statusType);
			sb.Append("' ");
			sb.Append(" left join p_itemtype c on a.item_type=c.itemtype");
			sb.Append(" left join p_currency d on a.currency=d.currency_code");
			sb.Append(" left join p_currency e on a.pur_currency=e.currency_code");
			sb.Append(" left join p_unit f on a.unit=f.unit_id");
			sb.Append(" left join p_packmethod g on a.outsiepacktype=g.pack_method_id");
			sb.Append(" left join p_packtype h on a.insidepacktype=h.pack_code");
			sb.Append(" order by a.item_code");
			this.InitialGrid(sb.ToString());

			priToolBar1.setCurrentForm = this;
			
			_PK = "item_code";
			_table = "basic_item";
			priToolBar1.Initial(_table,_PK,sb.ToString());
			priToolBar1.BeforeButtonClickEvent += new TJSystem.UC.PriToolBar.BeforeButotnClick(this.BeforeButtonClick);
			priToolBar1.AfterButtonClickEvent += new TJSystem.UC.PriToolBar.AfterButtonClick(this.AfterButtonClick);

#if false
			/* 增加搜索功能 */
			mSQL = sb.ToString();
			priToolBar1.SearchButtonClickEvent += new TJSystem.UC.PriToolBar.SearchButtonClick(this.SearchButtonClickEvent);
#endif
			this.priToolBar1.setButtonVisibleFalse();;
			this.priToolBar1.setButtonVisible("012345689");
			setDisable();

			this.Cursor = System.Windows.Forms.Cursors.Default;

			//
			// TODO: 在 InitializeComponent 调用后添加任何构造函数代码
			//
		}

#if false
		private bool SearchButtonClickEvent(string strKey)
		{
			System.Data.DataTable dt = TJSystem.Public.PublicStatic.db.GetDataTable(mSQL);
			System.Data.DataView dv = dt.DefaultView;
			if(!strKey.Equals(""))
			{
				dv.RowFilter = "item_code='" + strKey + "' or item_name='" + strKey + "'";	
			}			
			this.dataGrid1.DataSource = dv;
			return true;
		}
#endif
		private void InitialFormData()
		{
			DataTable dtcpy = null;
			DataRow dr = null;
			string sql = null;
			DataTable dt = null;
//			sql = "select GRADE_ID,GRADE_ID+' '+GRADE_NAME as GRADE_NAME from p_grade order by GRADE_ID";
//			DataTable dt = TJSystem.Public.PublicStatic.db.GetDataTable(sql);
//			dr = dt.NewRow() ;
//			dr[0] = "" ;
//			dr[1] = "" ;
//			dt.Rows.InsertAt(dr,0) ;
//			dtcpy = dt.Copy();
//			this.priComboBox2.DataSource = dtcpy.DefaultView;
//			this.priComboBox2.ValueMember = "GRADE_ID";
//			this.priComboBox2.DisplayMember = "GRADE_NAME";

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

			sql = "select UNIT_ID,UNIT_ID+' '+UNIT_NAME_CN as UNIT_NAME_CN from p_unit order by unit_id ";
			dt = TJSystem.Public.PublicStatic.db.GetDataTable(sql);
			dr = dt.NewRow() ;
			dr[0] = "" ;
			dr[1] = "" ;
			dt.Rows.InsertAt(dr,0) ;
			dtcpy = dt.Copy();
			this.priComboBox2.DataSource = dtcpy.DefaultView;
			this.priComboBox2.ValueMember = "UNIT_ID";
			this.priComboBox2.DisplayMember = "UNIT_NAME_CN";

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

			sql = "select CURRENCY_CODE,CURRENCY_CODE+' '+CURRENCY_NAMECN as CURRENCY_NAMECN from p_currency order by CURRENCY_CODE";
			dt = TJSystem.Public.PublicStatic.db.GetDataTable(sql);
			dr = dt.NewRow() ;
			dr[0] = "" ;
			dr[1] = "" ;
			dt.Rows.InsertAt(dr,0) ;
			dtcpy = dt.Copy();
			this.priComboBox4.DataSource = dtcpy.DefaultView;
			this.priComboBox4.ValueMember = "CURRENCY_CODE";
			this.priComboBox4.DisplayMember = "CURRENCY_NAMECN";

//			sql = "select PACK_METHOD_ID,PACK_METHOD_ID+' '+PACK_METHOD_NAME as PACK_METHOD_NAME from p_packmethod order by pack_method_id";
//			dt = TJSystem.Public.PublicStatic.db.GetDataTable(sql);
//			dr = dt.NewRow() ;
//			dr[0] = "" ;
//			dr[1] = "" ;
//			dt.Rows.InsertAt(dr,0) ;
//			dtcpy = dt.Copy();
//			this.priComboBox7.DataSource = dtcpy.DefaultView;
//			this.priComboBox7.ValueMember = "PACK_METHOD_ID";
//			this.priComboBox7.DisplayMember = "PACK_METHOD_NAME";
			sql = "select PACK_CODE,PACK_CODE+' '+PACK_NAMECN as PACK_NAMECN from p_packtype order by pack_code ";
			dt = TJSystem.Public.PublicStatic.db.GetDataTable(sql);
			dr = dt.NewRow() ;
			dr[0] = "" ;
			dr[1] = "" ;
			dt.Rows.InsertAt(dr,0) ;
			dtcpy = dt.Copy();
			this.priComboBox7.DataSource = dtcpy.DefaultView;
			this.priComboBox7.ValueMember = "PACK_CODE";
			this.priComboBox7.DisplayMember = "PACK_NAMECN";

			sql = "select PACK_CODE,PACK_CODE+' '+PACK_NAMECN as PACK_NAMECN from p_packtype order by pack_code ";
			dt = TJSystem.Public.PublicStatic.db.GetDataTable(sql);
			dr = dt.NewRow() ;
			dr[0] = "" ;
			dr[1] = "" ;
			dt.Rows.InsertAt(dr,0) ;
			dtcpy = dt.Copy();
			this.priComboBox8.DataSource = dtcpy.DefaultView;
			this.priComboBox8.ValueMember = "PACK_CODE";
			this.priComboBox8.DisplayMember = "PACK_NAMECN";

			sql = "select ITEMTYPE,ITEMTYPE+' '+TYPENAMECN as TYPENAMECN from p_itemtype order by ITEMTYPE";
			dt = TJSystem.Public.PublicStatic.db.GetDataTable(sql);
			dr = dt.NewRow() ;
			dr[0] = "" ;
			dr[1] = "" ;
			dt.Rows.InsertAt(dr,0) ;
			dtcpy = dt.Copy();
			this.comboBox1.DataSource = dtcpy.DefaultView;
			this.comboBox1.ValueMember = "ITEMTYPE";
			this.comboBox1.DisplayMember = "TYPENAMECN";

			dt = new DataTable();
			DataColumn dc = new DataColumn("packingby");
			dt.Columns.Add(dc);
			dc = new DataColumn("packingbyname");
			dt.Columns.Add(dc);
			dr = dt.NewRow();
			dr[0] = "";
			dt.Rows.Add(dr);
			dr = dt.NewRow();
			dr[0] = "单一包装";
			dt.Rows.Add(dr);
			dr = dt.NewRow();
			dr[0] = "套装";
			dt.Rows.Add(dr);
			dtcpy = dt.Copy();
			this.priComboBox5.DataSource = dtcpy.DefaultView;
			this.priComboBox5.ValueMember = "packingby";
			this.priComboBox5.DisplayMember = "packingby";
			
			dt = new DataTable();
			dc = new DataColumn("culby");
			dt.Columns.Add(dc);
			dr = dt.NewRow();
			dr[0] = "";
			dt.Rows.Add(dr);
			dr = dt.NewRow();
			dr[0] = "内包装决定";
			dt.Rows.Add(dr);
			dr = dt.NewRow();
			dr[0] = "外包装决定";
			dt.Rows.Add(dr);
			dtcpy = dt.Copy();
			this.priComboBox6.DataSource = dtcpy.DefaultView;
			this.priComboBox6.ValueMember = "culby";
			this.priComboBox6.DisplayMember = "culby";
		}

		public frmBasicItem(TJSystem.frmMain frmMain)
		{
			//
			// Windows 窗体设计器支持所必需的
			//
			InitializeComponent();

			frmMain.ApproveCancelEnable = false;
			frmMain.ApproveEnable = false;

			//
			// TODO: 在 InitializeComponent 调用后添加任何构造函数代码
			//
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(frmBasicItem));
			this.panel3 = new System.Windows.Forms.Panel();
			this.priToolBar1 = new TJSystem.UC.PriToolBar();
			this.panel1 = new System.Windows.Forms.Panel();
			this.label1 = new System.Windows.Forms.Label();
			this.panel2 = new System.Windows.Forms.Panel();
			this.panel4 = new System.Windows.Forms.Panel();
			this.linkLabel7 = new System.Windows.Forms.LinkLabel();
			this.linkLabel6 = new System.Windows.Forms.LinkLabel();
			this.linkLabel5 = new System.Windows.Forms.LinkLabel();
			this.linkLabel4 = new System.Windows.Forms.LinkLabel();
			this.linkLabel3 = new System.Windows.Forms.LinkLabel();
			this.linkLabel2 = new System.Windows.Forms.LinkLabel();
			this.linkLabel1 = new System.Windows.Forms.LinkLabel();
			this.priComboBox1 = new TJSystem.Classes.PriComboBox();
			this.label37 = new System.Windows.Forms.Label();
			this.priTextBox29 = new TJSystem.Classes.PriTextBox();
			this.label20 = new System.Windows.Forms.Label();
			this.priTextBox16 = new TJSystem.Classes.PriTextBox();
			this.label36 = new System.Windows.Forms.Label();
			this.priTextBox28 = new TJSystem.Classes.PriTextBox();
			this.label35 = new System.Windows.Forms.Label();
			this.priTextBox27 = new TJSystem.Classes.PriTextBox();
			this.priTextBox26 = new TJSystem.Classes.PriTextBox();
			this.label34 = new System.Windows.Forms.Label();
			this.priTextBox6 = new TJSystem.Classes.PriTextBox();
			this.label33 = new System.Windows.Forms.Label();
			this.priTextBox5 = new TJSystem.Classes.PriTextBox();
			this.priComboBox8 = new TJSystem.Classes.PriComboBox();
			this.label31 = new System.Windows.Forms.Label();
			this.label32 = new System.Windows.Forms.Label();
			this.priTextBox1 = new TJSystem.Classes.PriTextBox();
			this.priComboBox7 = new TJSystem.Classes.PriComboBox();
			this.priComboBox6 = new TJSystem.Classes.PriComboBox();
			this.label30 = new System.Windows.Forms.Label();
			this.priComboBox5 = new TJSystem.Classes.PriComboBox();
			this.priComboBox4 = new TJSystem.Classes.PriComboBox();
			this.priComboBox3 = new TJSystem.Classes.PriComboBox();
			this.priComboBox2 = new TJSystem.Classes.PriComboBox();
			this.label29 = new System.Windows.Forms.Label();
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
			this.priTextBox24 = new TJSystem.Classes.PriTextBox();
			this.label21 = new System.Windows.Forms.Label();
			this.priTextBox17 = new TJSystem.Classes.PriTextBox();
			this.label19 = new System.Windows.Forms.Label();
			this.priTextBox15 = new TJSystem.Classes.PriTextBox();
			this.label18 = new System.Windows.Forms.Label();
			this.priTextBox14 = new TJSystem.Classes.PriTextBox();
			this.label16 = new System.Windows.Forms.Label();
			this.label17 = new System.Windows.Forms.Label();
			this.priTextBox13 = new TJSystem.Classes.PriTextBox();
			this.label15 = new System.Windows.Forms.Label();
			this.priTextBox11 = new TJSystem.Classes.PriTextBox();
			this.label14 = new System.Windows.Forms.Label();
			this.label13 = new System.Windows.Forms.Label();
			this.priTextBox10 = new TJSystem.Classes.PriTextBox();
			this.label12 = new System.Windows.Forms.Label();
			this.priTextBox9 = new TJSystem.Classes.PriTextBox();
			this.label11 = new System.Windows.Forms.Label();
			this.priTextBox8 = new TJSystem.Classes.PriTextBox();
			this.label10 = new System.Windows.Forms.Label();
			this.priTextBox7 = new TJSystem.Classes.PriTextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.comboBox1 = new TJSystem.Classes.PriComboBox();
			this.textBox1 = new TJSystem.Classes.PriTextBox();
			this.priTextBox2 = new TJSystem.Classes.PriTextBox();
			this.priTextBox3 = new TJSystem.Classes.PriTextBox();
			this.dataGrid1 = new System.Windows.Forms.DataGrid();
			this.dataGridTableStyle1 = new System.Windows.Forms.DataGridTableStyle();
			this.item_code = new System.Windows.Forms.DataGridTextBoxColumn();
			this.item_name = new System.Windows.Forms.DataGridTextBoxColumn();
			this.item_name_cn = new System.Windows.Forms.DataGridTextBoxColumn();
			this.item_desc = new System.Windows.Forms.DataGridTextBoxColumn();
			this.item_desc_cn = new System.Windows.Forms.DataGridTextBoxColumn();
			this.hs_code = new System.Windows.Forms.DataGridTextBoxColumn();
			this.hs_name = new System.Windows.Forms.DataGridTextBoxColumn();
			this.typenamecn = new System.Windows.Forms.DataGridTextBoxColumn();
			this.saleprice = new System.Windows.Forms.DataGridTextBoxColumn();
			this.sale_currency_name = new System.Windows.Forms.DataGridTextBoxColumn();
			this.purchaseprice = new System.Windows.Forms.DataGridTextBoxColumn();
			this.pur_currency_name = new System.Windows.Forms.DataGridTextBoxColumn();
			this.minorder = new System.Windows.Forms.DataGridTextBoxColumn();
			this.remark = new System.Windows.Forms.DataGridTextBoxColumn();
			this.status_name = new System.Windows.Forms.DataGridTextBoxColumn();
			this.unit_name_cn = new System.Windows.Forms.DataGridTextBoxColumn();
			this.packingtype = new System.Windows.Forms.DataGridTextBoxColumn();
			this.culboxby = new System.Windows.Forms.DataGridTextBoxColumn();
			this.PACK_METHOD_NAME = new System.Windows.Forms.DataGridTextBoxColumn();
			this.outsidepack = new System.Windows.Forms.DataGridTextBoxColumn();
			this.PACK_NAMECN = new System.Windows.Forms.DataGridTextBoxColumn();
			this.insidepack = new System.Windows.Forms.DataGridTextBoxColumn();
			this.netweight = new System.Windows.Forms.DataGridTextBoxColumn();
			this.grossweight = new System.Windows.Forms.DataGridTextBoxColumn();
			this.length = new System.Windows.Forms.DataGridTextBoxColumn();
			this.width = new System.Windows.Forms.DataGridTextBoxColumn();
			this.height = new System.Windows.Forms.DataGridTextBoxColumn();
			this.volumn = new System.Windows.Forms.DataGridTextBoxColumn();
			this.packrate20 = new System.Windows.Forms.DataGridTextBoxColumn();
			this.packrate40 = new System.Windows.Forms.DataGridTextBoxColumn();
			this.packrate40hq = new System.Windows.Forms.DataGridTextBoxColumn();
			this.property1 = new System.Windows.Forms.DataGridTextBoxColumn();
			this.property2 = new System.Windows.Forms.DataGridTextBoxColumn();
			this.createby = new System.Windows.Forms.DataGridTextBoxColumn();
			this.createon = new System.Windows.Forms.DataGridTextBoxColumn();
			this.modifyby = new System.Windows.Forms.DataGridTextBoxColumn();
			this.modifyon = new System.Windows.Forms.DataGridTextBoxColumn();
			this.linkLabel8 = new System.Windows.Forms.LinkLabel();
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
			this.label1.Text = "货品资料维护";
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
			this.panel4.Controls.Add(this.linkLabel8);
			this.panel4.Controls.Add(this.linkLabel7);
			this.panel4.Controls.Add(this.linkLabel6);
			this.panel4.Controls.Add(this.linkLabel5);
			this.panel4.Controls.Add(this.linkLabel4);
			this.panel4.Controls.Add(this.linkLabel3);
			this.panel4.Controls.Add(this.linkLabel2);
			this.panel4.Controls.Add(this.linkLabel1);
			this.panel4.Controls.Add(this.priComboBox1);
			this.panel4.Controls.Add(this.label37);
			this.panel4.Controls.Add(this.priTextBox29);
			this.panel4.Controls.Add(this.label20);
			this.panel4.Controls.Add(this.priTextBox16);
			this.panel4.Controls.Add(this.label36);
			this.panel4.Controls.Add(this.priTextBox28);
			this.panel4.Controls.Add(this.label35);
			this.panel4.Controls.Add(this.priTextBox27);
			this.panel4.Controls.Add(this.priTextBox26);
			this.panel4.Controls.Add(this.label34);
			this.panel4.Controls.Add(this.priTextBox6);
			this.panel4.Controls.Add(this.label33);
			this.panel4.Controls.Add(this.priTextBox5);
			this.panel4.Controls.Add(this.priComboBox8);
			this.panel4.Controls.Add(this.label31);
			this.panel4.Controls.Add(this.label32);
			this.panel4.Controls.Add(this.priTextBox1);
			this.panel4.Controls.Add(this.priComboBox7);
			this.panel4.Controls.Add(this.priComboBox6);
			this.panel4.Controls.Add(this.label30);
			this.panel4.Controls.Add(this.priComboBox5);
			this.panel4.Controls.Add(this.priComboBox4);
			this.panel4.Controls.Add(this.priComboBox3);
			this.panel4.Controls.Add(this.priComboBox2);
			this.panel4.Controls.Add(this.label29);
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
			this.panel4.Controls.Add(this.priTextBox24);
			this.panel4.Controls.Add(this.label21);
			this.panel4.Controls.Add(this.priTextBox17);
			this.panel4.Controls.Add(this.label19);
			this.panel4.Controls.Add(this.priTextBox15);
			this.panel4.Controls.Add(this.label18);
			this.panel4.Controls.Add(this.priTextBox14);
			this.panel4.Controls.Add(this.label16);
			this.panel4.Controls.Add(this.label17);
			this.panel4.Controls.Add(this.priTextBox13);
			this.panel4.Controls.Add(this.label15);
			this.panel4.Controls.Add(this.priTextBox11);
			this.panel4.Controls.Add(this.label14);
			this.panel4.Controls.Add(this.label13);
			this.panel4.Controls.Add(this.priTextBox10);
			this.panel4.Controls.Add(this.label12);
			this.panel4.Controls.Add(this.priTextBox9);
			this.panel4.Controls.Add(this.label11);
			this.panel4.Controls.Add(this.priTextBox8);
			this.panel4.Controls.Add(this.label10);
			this.panel4.Controls.Add(this.priTextBox7);
			this.panel4.Controls.Add(this.label6);
			this.panel4.Controls.Add(this.label7);
			this.panel4.Controls.Add(this.label8);
			this.panel4.Controls.Add(this.label9);
			this.panel4.Controls.Add(this.label5);
			this.panel4.Controls.Add(this.label4);
			this.panel4.Controls.Add(this.label3);
			this.panel4.Controls.Add(this.label2);
			this.panel4.Controls.Add(this.comboBox1);
			this.panel4.Controls.Add(this.textBox1);
			this.panel4.Controls.Add(this.priTextBox2);
			this.panel4.Controls.Add(this.priTextBox3);
			this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel4.Location = new System.Drawing.Point(0, 0);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(788, 360);
			this.panel4.TabIndex = 0;
			// 
			// linkLabel7
			// 
			this.linkLabel7.BackColor = System.Drawing.Color.Transparent;
			this.linkLabel7.Location = new System.Drawing.Point(552, 304);
			this.linkLabel7.Name = "linkLabel7";
			this.linkLabel7.Size = new System.Drawing.Size(88, 23);
			this.linkLabel7.TabIndex = 161;
			this.linkLabel7.TabStop = true;
			this.linkLabel7.Text = "货品包装";
			this.linkLabel7.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel7_LinkClicked);
			// 
			// linkLabel6
			// 
			this.linkLabel6.BackColor = System.Drawing.Color.Transparent;
			this.linkLabel6.Location = new System.Drawing.Point(664, 280);
			this.linkLabel6.Name = "linkLabel6";
			this.linkLabel6.Size = new System.Drawing.Size(88, 23);
			this.linkLabel6.TabIndex = 160;
			this.linkLabel6.TabStop = true;
			this.linkLabel6.Text = "销售价格";
			this.linkLabel6.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel6_LinkClicked);
			// 
			// linkLabel5
			// 
			this.linkLabel5.BackColor = System.Drawing.Color.Transparent;
			this.linkLabel5.Location = new System.Drawing.Point(552, 280);
			this.linkLabel5.Name = "linkLabel5";
			this.linkLabel5.Size = new System.Drawing.Size(88, 23);
			this.linkLabel5.TabIndex = 159;
			this.linkLabel5.TabStop = true;
			this.linkLabel5.Text = "货品图片";
			this.linkLabel5.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel5_LinkClicked);
			// 
			// linkLabel4
			// 
			this.linkLabel4.BackColor = System.Drawing.Color.Transparent;
			this.linkLabel4.Location = new System.Drawing.Point(664, 256);
			this.linkLabel4.Name = "linkLabel4";
			this.linkLabel4.Size = new System.Drawing.Size(88, 23);
			this.linkLabel4.TabIndex = 158;
			this.linkLabel4.TabStop = true;
			this.linkLabel4.Text = "采购记录";
			this.linkLabel4.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel4_LinkClicked);
			// 
			// linkLabel3
			// 
			this.linkLabel3.BackColor = System.Drawing.Color.Transparent;
			this.linkLabel3.Location = new System.Drawing.Point(552, 256);
			this.linkLabel3.Name = "linkLabel3";
			this.linkLabel3.Size = new System.Drawing.Size(88, 23);
			this.linkLabel3.TabIndex = 157;
			this.linkLabel3.TabStop = true;
			this.linkLabel3.Text = "销售记录";
			this.linkLabel3.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel3_LinkClicked);
			// 
			// linkLabel2
			// 
			this.linkLabel2.BackColor = System.Drawing.Color.Transparent;
			this.linkLabel2.Location = new System.Drawing.Point(664, 232);
			this.linkLabel2.Name = "linkLabel2";
			this.linkLabel2.Size = new System.Drawing.Size(88, 23);
			this.linkLabel2.TabIndex = 156;
			this.linkLabel2.TabStop = true;
			this.linkLabel2.Text = "供应商资料";
			this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
			// 
			// linkLabel1
			// 
			this.linkLabel1.BackColor = System.Drawing.Color.Transparent;
			this.linkLabel1.Location = new System.Drawing.Point(552, 232);
			this.linkLabel1.Name = "linkLabel1";
			this.linkLabel1.Size = new System.Drawing.Size(88, 23);
			this.linkLabel1.TabIndex = 155;
			this.linkLabel1.TabStop = true;
			this.linkLabel1.Text = "客人货号";
			this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
			// 
			// priComboBox1
			// 
			this.priComboBox1.BackColor = System.Drawing.Color.White;
			this.priComboBox1.DataField = "status";
			this.priComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.priComboBox1.Location = new System.Drawing.Point(616, 56);
			this.priComboBox1.Name = "priComboBox1";
			this.priComboBox1.Size = new System.Drawing.Size(136, 22);
			this.priComboBox1.TabIndex = 154;
			// 
			// label37
			// 
			this.label37.BackColor = System.Drawing.Color.Transparent;
			this.label37.ForeColor = System.Drawing.Color.Blue;
			this.label37.Location = new System.Drawing.Point(272, 296);
			this.label37.Name = "label37";
			this.label37.Size = new System.Drawing.Size(80, 23);
			this.label37.TabIndex = 153;
			this.label37.Text = "45\'装箱率";
			this.label37.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// priTextBox29
			// 
			this.priTextBox29.BackColor = System.Drawing.Color.White;
			this.priTextBox29.DataField = "packrate40hq";
			this.priTextBox29.DataType = TJSystem.Public.DataType.String;
			this.priTextBox29.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.priTextBox29.Location = new System.Drawing.Point(360, 296);
			this.priTextBox29.Name = "priTextBox29";
			this.priTextBox29.Size = new System.Drawing.Size(152, 23);
			this.priTextBox29.TabIndex = 152;
			this.priTextBox29.Text = "";
			// 
			// label20
			// 
			this.label20.BackColor = System.Drawing.Color.Transparent;
			this.label20.ForeColor = System.Drawing.Color.Blue;
			this.label20.Location = new System.Drawing.Point(272, 272);
			this.label20.Name = "label20";
			this.label20.Size = new System.Drawing.Size(80, 23);
			this.label20.TabIndex = 151;
			this.label20.Text = "40\'装箱率";
			this.label20.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// priTextBox16
			// 
			this.priTextBox16.BackColor = System.Drawing.Color.White;
			this.priTextBox16.DataField = "packrate40";
			this.priTextBox16.DataType = TJSystem.Public.DataType.String;
			this.priTextBox16.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.priTextBox16.Location = new System.Drawing.Point(360, 272);
			this.priTextBox16.Name = "priTextBox16";
			this.priTextBox16.Size = new System.Drawing.Size(152, 23);
			this.priTextBox16.TabIndex = 150;
			this.priTextBox16.Text = "";
			// 
			// label36
			// 
			this.label36.BackColor = System.Drawing.Color.Transparent;
			this.label36.ForeColor = System.Drawing.Color.Blue;
			this.label36.Location = new System.Drawing.Point(272, 248);
			this.label36.Name = "label36";
			this.label36.Size = new System.Drawing.Size(80, 23);
			this.label36.TabIndex = 149;
			this.label36.Text = "20\'装箱率";
			this.label36.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// priTextBox28
			// 
			this.priTextBox28.BackColor = System.Drawing.Color.White;
			this.priTextBox28.DataField = "packrate20";
			this.priTextBox28.DataType = TJSystem.Public.DataType.String;
			this.priTextBox28.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.priTextBox28.Location = new System.Drawing.Point(360, 248);
			this.priTextBox28.Name = "priTextBox28";
			this.priTextBox28.Size = new System.Drawing.Size(152, 23);
			this.priTextBox28.TabIndex = 148;
			this.priTextBox28.Text = "";
			// 
			// label35
			// 
			this.label35.BackColor = System.Drawing.Color.Transparent;
			this.label35.ForeColor = System.Drawing.Color.Blue;
			this.label35.Location = new System.Drawing.Point(288, 224);
			this.label35.Name = "label35";
			this.label35.Size = new System.Drawing.Size(64, 23);
			this.label35.TabIndex = 147;
			this.label35.Text = "体积(M3)";
			this.label35.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// priTextBox27
			// 
			this.priTextBox27.BackColor = System.Drawing.Color.White;
			this.priTextBox27.DataField = "volumn";
			this.priTextBox27.DataType = TJSystem.Public.DataType.String;
			this.priTextBox27.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.priTextBox27.Location = new System.Drawing.Point(360, 224);
			this.priTextBox27.Name = "priTextBox27";
			this.priTextBox27.Size = new System.Drawing.Size(152, 23);
			this.priTextBox27.TabIndex = 146;
			this.priTextBox27.Text = "";
			// 
			// priTextBox26
			// 
			this.priTextBox26.BackColor = System.Drawing.Color.White;
			this.priTextBox26.DataField = "height";
			this.priTextBox26.DataType = TJSystem.Public.DataType.String;
			this.priTextBox26.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.priTextBox26.Location = new System.Drawing.Point(472, 200);
			this.priTextBox26.Name = "priTextBox26";
			this.priTextBox26.Size = new System.Drawing.Size(40, 23);
			this.priTextBox26.TabIndex = 145;
			this.priTextBox26.Text = "";
			// 
			// label34
			// 
			this.label34.AutoSize = true;
			this.label34.BackColor = System.Drawing.Color.Transparent;
			this.label34.Location = new System.Drawing.Point(456, 200);
			this.label34.Name = "label34";
			this.label34.Size = new System.Drawing.Size(12, 19);
			this.label34.TabIndex = 144;
			this.label34.Text = "*";
			this.label34.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// priTextBox6
			// 
			this.priTextBox6.BackColor = System.Drawing.Color.White;
			this.priTextBox6.DataField = "width";
			this.priTextBox6.DataType = TJSystem.Public.DataType.String;
			this.priTextBox6.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.priTextBox6.Location = new System.Drawing.Point(416, 200);
			this.priTextBox6.Name = "priTextBox6";
			this.priTextBox6.Size = new System.Drawing.Size(40, 23);
			this.priTextBox6.TabIndex = 143;
			this.priTextBox6.Text = "";
			// 
			// label33
			// 
			this.label33.BackColor = System.Drawing.Color.Transparent;
			this.label33.ForeColor = System.Drawing.Color.Blue;
			this.label33.Location = new System.Drawing.Point(288, 176);
			this.label33.Name = "label33";
			this.label33.Size = new System.Drawing.Size(64, 23);
			this.label33.TabIndex = 142;
			this.label33.Text = "毛重(KG)";
			this.label33.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// priTextBox5
			// 
			this.priTextBox5.BackColor = System.Drawing.Color.White;
			this.priTextBox5.DataField = "grossweight";
			this.priTextBox5.DataType = TJSystem.Public.DataType.String;
			this.priTextBox5.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.priTextBox5.Location = new System.Drawing.Point(360, 176);
			this.priTextBox5.Name = "priTextBox5";
			this.priTextBox5.Size = new System.Drawing.Size(152, 23);
			this.priTextBox5.TabIndex = 141;
			this.priTextBox5.Text = "";
			// 
			// priComboBox8
			// 
			this.priComboBox8.BackColor = System.Drawing.Color.White;
			this.priComboBox8.DataField = "insidepacktype";
			this.priComboBox8.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.priComboBox8.Location = new System.Drawing.Point(448, 128);
			this.priComboBox8.Name = "priComboBox8";
			this.priComboBox8.Size = new System.Drawing.Size(64, 22);
			this.priComboBox8.TabIndex = 140;
			// 
			// label31
			// 
			this.label31.BackColor = System.Drawing.Color.Transparent;
			this.label31.Location = new System.Drawing.Point(432, 128);
			this.label31.Name = "label31";
			this.label31.Size = new System.Drawing.Size(16, 23);
			this.label31.TabIndex = 139;
			this.label31.Text = "/";
			this.label31.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label32
			// 
			this.label32.BackColor = System.Drawing.Color.Transparent;
			this.label32.ForeColor = System.Drawing.Color.Blue;
			this.label32.Location = new System.Drawing.Point(296, 128);
			this.label32.Name = "label32";
			this.label32.Size = new System.Drawing.Size(56, 23);
			this.label32.TabIndex = 138;
			this.label32.Text = "内包装";
			this.label32.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// priTextBox1
			// 
			this.priTextBox1.BackColor = System.Drawing.Color.White;
			this.priTextBox1.DataField = "insidepack";
			this.priTextBox1.DataType = TJSystem.Public.DataType.String;
			this.priTextBox1.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.priTextBox1.Location = new System.Drawing.Point(360, 128);
			this.priTextBox1.Name = "priTextBox1";
			this.priTextBox1.Size = new System.Drawing.Size(72, 23);
			this.priTextBox1.TabIndex = 137;
			this.priTextBox1.Text = "";
			// 
			// priComboBox7
			// 
			this.priComboBox7.BackColor = System.Drawing.Color.White;
			this.priComboBox7.DataField = "outsiepacktype";
			this.priComboBox7.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.priComboBox7.Location = new System.Drawing.Point(448, 104);
			this.priComboBox7.Name = "priComboBox7";
			this.priComboBox7.Size = new System.Drawing.Size(64, 22);
			this.priComboBox7.TabIndex = 136;
			// 
			// priComboBox6
			// 
			this.priComboBox6.BackColor = System.Drawing.Color.White;
			this.priComboBox6.DataField = "culboxby";
			this.priComboBox6.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.priComboBox6.Items.AddRange(new object[] {
															  "外包装决定",
															  "内包装决定"});
			this.priComboBox6.Location = new System.Drawing.Point(360, 80);
			this.priComboBox6.Name = "priComboBox6";
			this.priComboBox6.Size = new System.Drawing.Size(152, 22);
			this.priComboBox6.TabIndex = 135;
			// 
			// label30
			// 
			this.label30.BackColor = System.Drawing.Color.Transparent;
			this.label30.ForeColor = System.Drawing.Color.Blue;
			this.label30.Location = new System.Drawing.Point(288, 80);
			this.label30.Name = "label30";
			this.label30.Size = new System.Drawing.Size(64, 23);
			this.label30.TabIndex = 134;
			this.label30.Text = "箱数计算";
			this.label30.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// priComboBox5
			// 
			this.priComboBox5.BackColor = System.Drawing.Color.White;
			this.priComboBox5.DataField = "packingtype";
			this.priComboBox5.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.priComboBox5.Items.AddRange(new object[] {
															  "单一包装",
															  "套装"});
			this.priComboBox5.Location = new System.Drawing.Point(360, 56);
			this.priComboBox5.Name = "priComboBox5";
			this.priComboBox5.Size = new System.Drawing.Size(152, 22);
			this.priComboBox5.TabIndex = 133;
			// 
			// priComboBox4
			// 
			this.priComboBox4.BackColor = System.Drawing.Color.White;
			this.priComboBox4.DataField = "pur_currency";
			this.priComboBox4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.priComboBox4.Location = new System.Drawing.Point(176, 248);
			this.priComboBox4.Name = "priComboBox4";
			this.priComboBox4.Size = new System.Drawing.Size(72, 22);
			this.priComboBox4.TabIndex = 132;
			// 
			// priComboBox3
			// 
			this.priComboBox3.BackColor = System.Drawing.Color.White;
			this.priComboBox3.DataField = "currency";
			this.priComboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.priComboBox3.Location = new System.Drawing.Point(176, 224);
			this.priComboBox3.Name = "priComboBox3";
			this.priComboBox3.Size = new System.Drawing.Size(72, 22);
			this.priComboBox3.TabIndex = 131;
			// 
			// priComboBox2
			// 
			this.priComboBox2.BackColor = System.Drawing.Color.White;
			this.priComboBox2.DataField = "unit";
			this.priComboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.priComboBox2.Location = new System.Drawing.Point(88, 296);
			this.priComboBox2.Name = "priComboBox2";
			this.priComboBox2.Size = new System.Drawing.Size(160, 22);
			this.priComboBox2.TabIndex = 130;
			// 
			// label29
			// 
			this.label29.BackColor = System.Drawing.Color.Transparent;
			this.label29.Location = new System.Drawing.Point(432, 104);
			this.label29.Name = "label29";
			this.label29.Size = new System.Drawing.Size(16, 23);
			this.label29.TabIndex = 129;
			this.label29.Text = "/";
			this.label29.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// priTextBox25
			// 
			this.priTextBox25.BackColor = System.Drawing.Color.White;
			this.priTextBox25.DataField = "item_desc_cn";
			this.priTextBox25.DataType = TJSystem.Public.DataType.String;
			this.priTextBox25.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.priTextBox25.Location = new System.Drawing.Point(88, 152);
			this.priTextBox25.Name = "priTextBox25";
			this.priTextBox25.Size = new System.Drawing.Size(160, 23);
			this.priTextBox25.TabIndex = 128;
			this.priTextBox25.Text = "";
			// 
			// priTextBox4
			// 
			this.priTextBox4.BackColor = System.Drawing.Color.White;
			this.priTextBox4.DataField = "item_desc";
			this.priTextBox4.DataType = TJSystem.Public.DataType.String;
			this.priTextBox4.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.priTextBox4.Location = new System.Drawing.Point(88, 128);
			this.priTextBox4.Name = "priTextBox4";
			this.priTextBox4.Size = new System.Drawing.Size(160, 23);
			this.priTextBox4.TabIndex = 127;
			this.priTextBox4.Text = "";
			// 
			// label24
			// 
			this.label24.BackColor = System.Drawing.Color.Transparent;
			this.label24.Location = new System.Drawing.Point(544, 200);
			this.label24.Name = "label24";
			this.label24.Size = new System.Drawing.Size(64, 23);
			this.label24.TabIndex = 124;
			this.label24.Text = "修改时间";
			this.label24.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// priTextBox20
			// 
			this.priTextBox20.BackColor = System.Drawing.Color.White;
			this.priTextBox20.DataField = "modifyon";
			this.priTextBox20.DataType = TJSystem.Public.DataType.String;
			this.priTextBox20.Enabled = false;
			this.priTextBox20.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.priTextBox20.Location = new System.Drawing.Point(616, 200);
			this.priTextBox20.Name = "priTextBox20";
			this.priTextBox20.Size = new System.Drawing.Size(136, 23);
			this.priTextBox20.TabIndex = 123;
			this.priTextBox20.Text = "";
			// 
			// label25
			// 
			this.label25.BackColor = System.Drawing.Color.Transparent;
			this.label25.Location = new System.Drawing.Point(544, 152);
			this.label25.Name = "label25";
			this.label25.Size = new System.Drawing.Size(64, 23);
			this.label25.TabIndex = 122;
			this.label25.Text = "创建时间";
			this.label25.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// priTextBox21
			// 
			this.priTextBox21.BackColor = System.Drawing.Color.White;
			this.priTextBox21.DataField = "createon";
			this.priTextBox21.DataType = TJSystem.Public.DataType.String;
			this.priTextBox21.Enabled = false;
			this.priTextBox21.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.priTextBox21.Location = new System.Drawing.Point(616, 152);
			this.priTextBox21.Name = "priTextBox21";
			this.priTextBox21.Size = new System.Drawing.Size(136, 23);
			this.priTextBox21.TabIndex = 121;
			this.priTextBox21.Text = "";
			// 
			// label26
			// 
			this.label26.BackColor = System.Drawing.Color.Transparent;
			this.label26.Location = new System.Drawing.Point(528, 176);
			this.label26.Name = "label26";
			this.label26.Size = new System.Drawing.Size(80, 23);
			this.label26.TabIndex = 120;
			this.label26.Text = "最后修改者";
			this.label26.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// priTextBox22
			// 
			this.priTextBox22.BackColor = System.Drawing.Color.White;
			this.priTextBox22.DataField = "remark";
			this.priTextBox22.DataType = TJSystem.Public.DataType.String;
			this.priTextBox22.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.priTextBox22.Location = new System.Drawing.Point(88, 328);
			this.priTextBox22.Name = "priTextBox22";
			this.priTextBox22.Size = new System.Drawing.Size(672, 23);
			this.priTextBox22.TabIndex = 125;
			this.priTextBox22.Text = "";
			// 
			// label27
			// 
			this.label27.BackColor = System.Drawing.Color.Transparent;
			this.label27.Location = new System.Drawing.Point(528, 128);
			this.label27.Name = "label27";
			this.label27.Size = new System.Drawing.Size(80, 23);
			this.label27.TabIndex = 119;
			this.label27.Text = "创建者";
			this.label27.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label28
			// 
			this.label28.BackColor = System.Drawing.Color.Transparent;
			this.label28.Location = new System.Drawing.Point(8, 328);
			this.label28.Name = "label28";
			this.label28.Size = new System.Drawing.Size(80, 23);
			this.label28.TabIndex = 118;
			this.label28.Text = "备注";
			this.label28.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// priTextBox23
			// 
			this.priTextBox23.BackColor = System.Drawing.Color.White;
			this.priTextBox23.DataField = "createBy";
			this.priTextBox23.DataType = TJSystem.Public.DataType.String;
			this.priTextBox23.Enabled = false;
			this.priTextBox23.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.priTextBox23.Location = new System.Drawing.Point(616, 128);
			this.priTextBox23.Name = "priTextBox23";
			this.priTextBox23.Size = new System.Drawing.Size(136, 23);
			this.priTextBox23.TabIndex = 117;
			this.priTextBox23.Text = "";
			// 
			// priTextBox24
			// 
			this.priTextBox24.BackColor = System.Drawing.Color.White;
			this.priTextBox24.DataField = "modifyBy";
			this.priTextBox24.DataType = TJSystem.Public.DataType.String;
			this.priTextBox24.Enabled = false;
			this.priTextBox24.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.priTextBox24.Location = new System.Drawing.Point(616, 176);
			this.priTextBox24.Name = "priTextBox24";
			this.priTextBox24.Size = new System.Drawing.Size(136, 23);
			this.priTextBox24.TabIndex = 116;
			this.priTextBox24.Text = "";
			// 
			// label21
			// 
			this.label21.BackColor = System.Drawing.Color.Transparent;
			this.label21.Location = new System.Drawing.Point(544, 104);
			this.label21.Name = "label21";
			this.label21.Size = new System.Drawing.Size(64, 23);
			this.label21.TabIndex = 41;
			this.label21.Text = "原产地";
			this.label21.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// priTextBox17
			// 
			this.priTextBox17.BackColor = System.Drawing.Color.White;
			this.priTextBox17.DataField = "property2";
			this.priTextBox17.DataType = TJSystem.Public.DataType.String;
			this.priTextBox17.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.priTextBox17.Location = new System.Drawing.Point(616, 104);
			this.priTextBox17.Name = "priTextBox17";
			this.priTextBox17.Size = new System.Drawing.Size(136, 23);
			this.priTextBox17.TabIndex = 40;
			this.priTextBox17.Text = "";
			// 
			// label19
			// 
			this.label19.BackColor = System.Drawing.Color.Transparent;
			this.label19.ForeColor = System.Drawing.Color.Blue;
			this.label19.Location = new System.Drawing.Point(288, 152);
			this.label19.Name = "label19";
			this.label19.Size = new System.Drawing.Size(64, 23);
			this.label19.TabIndex = 39;
			this.label19.Text = "净重(KG)";
			this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// priTextBox15
			// 
			this.priTextBox15.BackColor = System.Drawing.Color.White;
			this.priTextBox15.DataField = "netweight";
			this.priTextBox15.DataType = TJSystem.Public.DataType.String;
			this.priTextBox15.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.priTextBox15.Location = new System.Drawing.Point(360, 152);
			this.priTextBox15.Name = "priTextBox15";
			this.priTextBox15.Size = new System.Drawing.Size(152, 23);
			this.priTextBox15.TabIndex = 38;
			this.priTextBox15.Text = "";
			// 
			// label18
			// 
			this.label18.BackColor = System.Drawing.Color.Transparent;
			this.label18.Location = new System.Drawing.Point(528, 80);
			this.label18.Name = "label18";
			this.label18.Size = new System.Drawing.Size(80, 23);
			this.label18.TabIndex = 35;
			this.label18.Text = "原长编码";
			this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// priTextBox14
			// 
			this.priTextBox14.BackColor = System.Drawing.Color.White;
			this.priTextBox14.DataField = "property1";
			this.priTextBox14.DataType = TJSystem.Public.DataType.String;
			this.priTextBox14.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.priTextBox14.Location = new System.Drawing.Point(616, 80);
			this.priTextBox14.Name = "priTextBox14";
			this.priTextBox14.Size = new System.Drawing.Size(136, 23);
			this.priTextBox14.TabIndex = 34;
			this.priTextBox14.Text = "";
			// 
			// label16
			// 
			this.label16.BackColor = System.Drawing.Color.Transparent;
			this.label16.ForeColor = System.Drawing.Color.Blue;
			this.label16.Location = new System.Drawing.Point(544, 56);
			this.label16.Name = "label16";
			this.label16.Size = new System.Drawing.Size(64, 23);
			this.label16.TabIndex = 33;
			this.label16.Text = "货品状态";
			this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label17
			// 
			this.label17.BackColor = System.Drawing.Color.Transparent;
			this.label17.ForeColor = System.Drawing.Color.Blue;
			this.label17.Location = new System.Drawing.Point(288, 200);
			this.label17.Name = "label17";
			this.label17.Size = new System.Drawing.Size(64, 23);
			this.label17.TabIndex = 31;
			this.label17.Text = "尺寸(cm)";
			this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// priTextBox13
			// 
			this.priTextBox13.BackColor = System.Drawing.Color.White;
			this.priTextBox13.DataField = "length";
			this.priTextBox13.DataType = TJSystem.Public.DataType.String;
			this.priTextBox13.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.priTextBox13.Location = new System.Drawing.Point(360, 200);
			this.priTextBox13.Name = "priTextBox13";
			this.priTextBox13.Size = new System.Drawing.Size(40, 23);
			this.priTextBox13.TabIndex = 30;
			this.priTextBox13.Text = "";
			// 
			// label15
			// 
			this.label15.BackColor = System.Drawing.Color.Transparent;
			this.label15.ForeColor = System.Drawing.Color.Blue;
			this.label15.Location = new System.Drawing.Point(296, 104);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(56, 23);
			this.label15.TabIndex = 29;
			this.label15.Text = "外包装";
			this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// priTextBox11
			// 
			this.priTextBox11.BackColor = System.Drawing.Color.White;
			this.priTextBox11.DataField = "outsidepack";
			this.priTextBox11.DataType = TJSystem.Public.DataType.String;
			this.priTextBox11.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.priTextBox11.Location = new System.Drawing.Point(360, 104);
			this.priTextBox11.Name = "priTextBox11";
			this.priTextBox11.Size = new System.Drawing.Size(72, 23);
			this.priTextBox11.TabIndex = 28;
			this.priTextBox11.Text = "";
			// 
			// label14
			// 
			this.label14.BackColor = System.Drawing.Color.Transparent;
			this.label14.ForeColor = System.Drawing.Color.Blue;
			this.label14.Location = new System.Drawing.Point(288, 56);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(64, 23);
			this.label14.TabIndex = 27;
			this.label14.Text = "包装方式";
			this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label13
			// 
			this.label13.BackColor = System.Drawing.Color.Transparent;
			this.label13.ForeColor = System.Drawing.Color.Blue;
			this.label13.Location = new System.Drawing.Point(0, 272);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(80, 23);
			this.label13.TabIndex = 26;
			this.label13.Text = "最小订货量";
			this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// priTextBox10
			// 
			this.priTextBox10.BackColor = System.Drawing.Color.White;
			this.priTextBox10.DataField = "minorder";
			this.priTextBox10.DataType = TJSystem.Public.DataType.String;
			this.priTextBox10.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.priTextBox10.Location = new System.Drawing.Point(88, 272);
			this.priTextBox10.Name = "priTextBox10";
			this.priTextBox10.Size = new System.Drawing.Size(160, 23);
			this.priTextBox10.TabIndex = 25;
			this.priTextBox10.Text = "";
			// 
			// label12
			// 
			this.label12.BackColor = System.Drawing.Color.Transparent;
			this.label12.ForeColor = System.Drawing.Color.Blue;
			this.label12.Location = new System.Drawing.Point(24, 248);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(56, 23);
			this.label12.TabIndex = 24;
			this.label12.Text = "采购价";
			this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// priTextBox9
			// 
			this.priTextBox9.BackColor = System.Drawing.Color.White;
			this.priTextBox9.DataField = "purchaseprice";
			this.priTextBox9.DataType = TJSystem.Public.DataType.String;
			this.priTextBox9.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.priTextBox9.Location = new System.Drawing.Point(88, 248);
			this.priTextBox9.Name = "priTextBox9";
			this.priTextBox9.Size = new System.Drawing.Size(88, 23);
			this.priTextBox9.TabIndex = 23;
			this.priTextBox9.Text = "";
			// 
			// label11
			// 
			this.label11.BackColor = System.Drawing.Color.Transparent;
			this.label11.ForeColor = System.Drawing.Color.Blue;
			this.label11.Location = new System.Drawing.Point(24, 224);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(56, 23);
			this.label11.TabIndex = 22;
			this.label11.Text = "销售价";
			this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// priTextBox8
			// 
			this.priTextBox8.BackColor = System.Drawing.Color.White;
			this.priTextBox8.DataField = "saleprice";
			this.priTextBox8.DataType = TJSystem.Public.DataType.String;
			this.priTextBox8.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.priTextBox8.Location = new System.Drawing.Point(88, 224);
			this.priTextBox8.Name = "priTextBox8";
			this.priTextBox8.Size = new System.Drawing.Size(88, 23);
			this.priTextBox8.TabIndex = 21;
			this.priTextBox8.Text = "";
			// 
			// label10
			// 
			this.label10.BackColor = System.Drawing.Color.Transparent;
			this.label10.Location = new System.Drawing.Point(0, 176);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(80, 23);
			this.label10.TabIndex = 20;
			this.label10.Text = "海关编码";
			this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// priTextBox7
			// 
			this.priTextBox7.BackColor = System.Drawing.Color.White;
			this.priTextBox7.DataField = "hs_code";
			this.priTextBox7.DataType = TJSystem.Public.DataType.String;
			this.priTextBox7.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.priTextBox7.Location = new System.Drawing.Point(88, 176);
			this.priTextBox7.Name = "priTextBox7";
			this.priTextBox7.Size = new System.Drawing.Size(160, 23);
			this.priTextBox7.TabIndex = 19;
			this.priTextBox7.Text = "";
			// 
			// label6
			// 
			this.label6.BackColor = System.Drawing.Color.Transparent;
			this.label6.Location = new System.Drawing.Point(16, 152);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(64, 23);
			this.label6.TabIndex = 17;
			this.label6.Text = "中文规格";
			this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label7
			// 
			this.label7.BackColor = System.Drawing.Color.Transparent;
			this.label7.Location = new System.Drawing.Point(8, 128);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(72, 23);
			this.label7.TabIndex = 16;
			this.label7.Text = "英文规格";
			this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label8
			// 
			this.label8.BackColor = System.Drawing.Color.Transparent;
			this.label8.ForeColor = System.Drawing.Color.Blue;
			this.label8.Location = new System.Drawing.Point(24, 296);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(56, 23);
			this.label8.TabIndex = 15;
			this.label8.Text = "单位";
			this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.BackColor = System.Drawing.Color.Transparent;
			this.label9.Location = new System.Drawing.Point(400, 200);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(12, 19);
			this.label9.TabIndex = 14;
			this.label9.Text = "*";
			this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label5
			// 
			this.label5.BackColor = System.Drawing.Color.Transparent;
			this.label5.ForeColor = System.Drawing.Color.Blue;
			this.label5.Location = new System.Drawing.Point(16, 200);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(64, 23);
			this.label5.TabIndex = 9;
			this.label5.Text = "货品大类";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label4
			// 
			this.label4.BackColor = System.Drawing.Color.Transparent;
			this.label4.Location = new System.Drawing.Point(8, 104);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(72, 23);
			this.label4.TabIndex = 8;
			this.label4.Text = "中文名称";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label3
			// 
			this.label3.BackColor = System.Drawing.Color.Transparent;
			this.label3.Location = new System.Drawing.Point(16, 80);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(64, 23);
			this.label3.TabIndex = 7;
			this.label3.Text = "英文名称";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label2
			// 
			this.label2.BackColor = System.Drawing.Color.Transparent;
			this.label2.ForeColor = System.Drawing.Color.Blue;
			this.label2.Location = new System.Drawing.Point(16, 56);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(64, 23);
			this.label2.TabIndex = 6;
			this.label2.Text = "货品编号";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// comboBox1
			// 
			this.comboBox1.BackColor = System.Drawing.Color.White;
			this.comboBox1.DataField = "item_type";
			this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBox1.Location = new System.Drawing.Point(88, 200);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(160, 22);
			this.comboBox1.TabIndex = 4;
			// 
			// textBox1
			// 
			this.textBox1.BackColor = System.Drawing.Color.White;
			this.textBox1.DataField = "item_code";
			this.textBox1.DataType = TJSystem.Public.DataType.String;
			this.textBox1.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.textBox1.Location = new System.Drawing.Point(88, 56);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(160, 23);
			this.textBox1.TabIndex = 1;
			this.textBox1.Text = "";
			// 
			// priTextBox2
			// 
			this.priTextBox2.BackColor = System.Drawing.Color.White;
			this.priTextBox2.DataField = "item_name";
			this.priTextBox2.DataType = TJSystem.Public.DataType.String;
			this.priTextBox2.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.priTextBox2.Location = new System.Drawing.Point(88, 80);
			this.priTextBox2.Name = "priTextBox2";
			this.priTextBox2.Size = new System.Drawing.Size(160, 23);
			this.priTextBox2.TabIndex = 2;
			this.priTextBox2.Text = "";
			// 
			// priTextBox3
			// 
			this.priTextBox3.BackColor = System.Drawing.Color.White;
			this.priTextBox3.DataField = "item_name_cn";
			this.priTextBox3.DataType = TJSystem.Public.DataType.String;
			this.priTextBox3.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.priTextBox3.Location = new System.Drawing.Point(88, 104);
			this.priTextBox3.Name = "priTextBox3";
			this.priTextBox3.Size = new System.Drawing.Size(160, 23);
			this.priTextBox3.TabIndex = 3;
			this.priTextBox3.Text = "";
			// 
			// dataGrid1
			// 
			this.dataGrid1.AllowSorting = false;
			this.dataGrid1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.dataGrid1.BackgroundColor = System.Drawing.SystemColors.Window;
			this.dataGrid1.CaptionText = "货品资料维护";
			this.dataGrid1.CaptionVisible = false;
			this.dataGrid1.DataMember = "";
			this.dataGrid1.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.dataGrid1.Location = new System.Drawing.Point(0, 368);
			this.dataGrid1.Name = "dataGrid1";
			this.dataGrid1.ReadOnly = true;
			this.dataGrid1.Size = new System.Drawing.Size(784, 152);
			this.dataGrid1.TabIndex = 0;
			this.dataGrid1.TableStyles.AddRange(new System.Windows.Forms.DataGridTableStyle[] {
																								  this.dataGridTableStyle1});
			// 
			// dataGridTableStyle1
			// 
			this.dataGridTableStyle1.AllowSorting = false;
			this.dataGridTableStyle1.DataGrid = this.dataGrid1;
			this.dataGridTableStyle1.GridColumnStyles.AddRange(new System.Windows.Forms.DataGridColumnStyle[] {
																												  this.item_code,
																												  this.item_name,
																												  this.item_name_cn,
																												  this.item_desc,
																												  this.item_desc_cn,
																												  this.hs_code,
																												  this.hs_name,
																												  this.typenamecn,
																												  this.saleprice,
																												  this.sale_currency_name,
																												  this.purchaseprice,
																												  this.pur_currency_name,
																												  this.minorder,
																												  this.remark,
																												  this.status_name,
																												  this.unit_name_cn,
																												  this.packingtype,
																												  this.culboxby,
																												  this.PACK_METHOD_NAME,
																												  this.outsidepack,
																												  this.PACK_NAMECN,
																												  this.insidepack,
																												  this.netweight,
																												  this.grossweight,
																												  this.length,
																												  this.width,
																												  this.height,
																												  this.volumn,
																												  this.packrate20,
																												  this.packrate40,
																												  this.packrate40hq,
																												  this.property1,
																												  this.property2,
																												  this.createby,
																												  this.createon,
																												  this.modifyby,
																												  this.modifyon});
			this.dataGridTableStyle1.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.dataGridTableStyle1.MappingName = "basic_item";
			this.dataGridTableStyle1.ReadOnly = true;
			// 
			// item_code
			// 
			this.item_code.Format = "";
			this.item_code.FormatInfo = null;
			this.item_code.HeaderText = "货品编号";
			this.item_code.MappingName = "item_code";
			this.item_code.NullText = "";
			this.item_code.Width = 75;
			// 
			// item_name
			// 
			this.item_name.Format = "";
			this.item_name.FormatInfo = null;
			this.item_name.HeaderText = "英文名";
			this.item_name.MappingName = "item_name";
			this.item_name.NullText = "";
			this.item_name.Width = 75;
			// 
			// item_name_cn
			// 
			this.item_name_cn.Format = "";
			this.item_name_cn.FormatInfo = null;
			this.item_name_cn.HeaderText = "中文名";
			this.item_name_cn.MappingName = "item_name_cn";
			this.item_name_cn.NullText = "";
			this.item_name_cn.Width = 75;
			// 
			// item_desc
			// 
			this.item_desc.Format = "";
			this.item_desc.FormatInfo = null;
			this.item_desc.HeaderText = "英文规格";
			this.item_desc.MappingName = "item_desc";
			this.item_desc.NullText = "";
			this.item_desc.Width = 75;
			// 
			// item_desc_cn
			// 
			this.item_desc_cn.Format = "";
			this.item_desc_cn.FormatInfo = null;
			this.item_desc_cn.HeaderText = "中文规格";
			this.item_desc_cn.MappingName = "item_desc_cn";
			this.item_desc_cn.NullText = "";
			this.item_desc_cn.Width = 75;
			// 
			// hs_code
			// 
			this.hs_code.Format = "";
			this.hs_code.FormatInfo = null;
			this.hs_code.HeaderText = "海关编号";
			this.hs_code.MappingName = "hs_code";
			this.hs_code.NullText = "";
			this.hs_code.Width = 75;
			// 
			// hs_name
			// 
			this.hs_name.Format = "";
			this.hs_name.FormatInfo = null;
			this.hs_name.HeaderText = "海关名称";
			this.hs_name.MappingName = "hs_name";
			this.hs_name.NullText = "";
			this.hs_name.Width = 75;
			// 
			// typenamecn
			// 
			this.typenamecn.Format = "";
			this.typenamecn.FormatInfo = null;
			this.typenamecn.HeaderText = "货品大类";
			this.typenamecn.MappingName = "typenamecn";
			this.typenamecn.NullText = "";
			this.typenamecn.Width = 75;
			// 
			// saleprice
			// 
			this.saleprice.Format = "";
			this.saleprice.FormatInfo = null;
			this.saleprice.HeaderText = "销售价格";
			this.saleprice.MappingName = "saleprice";
			this.saleprice.NullText = "";
			this.saleprice.Width = 75;
			// 
			// sale_currency_name
			// 
			this.sale_currency_name.Format = "";
			this.sale_currency_name.FormatInfo = null;
			this.sale_currency_name.HeaderText = "销售币种";
			this.sale_currency_name.MappingName = "sale_currency_name";
			this.sale_currency_name.NullText = "";
			this.sale_currency_name.Width = 75;
			// 
			// purchaseprice
			// 
			this.purchaseprice.Format = "";
			this.purchaseprice.FormatInfo = null;
			this.purchaseprice.HeaderText = "采购价格";
			this.purchaseprice.MappingName = "purchaseprice";
			this.purchaseprice.NullText = "";
			this.purchaseprice.Width = 75;
			// 
			// pur_currency_name
			// 
			this.pur_currency_name.Format = "";
			this.pur_currency_name.FormatInfo = null;
			this.pur_currency_name.HeaderText = "采购币种";
			this.pur_currency_name.MappingName = "pur_currency_name";
			this.pur_currency_name.NullText = "";
			this.pur_currency_name.Width = 75;
			// 
			// minorder
			// 
			this.minorder.Format = "";
			this.minorder.FormatInfo = null;
			this.minorder.HeaderText = "最小订货量";
			this.minorder.MappingName = "minorder";
			this.minorder.NullText = "";
			this.minorder.Width = 75;
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
			// status_name
			// 
			this.status_name.Format = "";
			this.status_name.FormatInfo = null;
			this.status_name.HeaderText = "货品状态";
			this.status_name.MappingName = "status_name";
			this.status_name.NullText = "";
			this.status_name.Width = 75;
			// 
			// unit_name_cn
			// 
			this.unit_name_cn.Format = "";
			this.unit_name_cn.FormatInfo = null;
			this.unit_name_cn.HeaderText = "单位";
			this.unit_name_cn.MappingName = "unit_name_cn";
			this.unit_name_cn.NullText = "";
			this.unit_name_cn.Width = 75;
			// 
			// packingtype
			// 
			this.packingtype.Format = "";
			this.packingtype.FormatInfo = null;
			this.packingtype.HeaderText = "包装方式";
			this.packingtype.MappingName = "packingtype";
			this.packingtype.NullText = "";
			this.packingtype.Width = 75;
			// 
			// culboxby
			// 
			this.culboxby.Format = "";
			this.culboxby.FormatInfo = null;
			this.culboxby.HeaderText = "箱数计算方式";
			this.culboxby.MappingName = "culboxby";
			this.culboxby.NullText = "";
			this.culboxby.Width = 75;
			// 
			// PACK_METHOD_NAME
			// 
			this.PACK_METHOD_NAME.Format = "";
			this.PACK_METHOD_NAME.FormatInfo = null;
			this.PACK_METHOD_NAME.HeaderText = "外包装种类";
			this.PACK_METHOD_NAME.MappingName = "PACK_METHOD_NAME";
			this.PACK_METHOD_NAME.NullText = "";
			this.PACK_METHOD_NAME.Width = 75;
			// 
			// outsidepack
			// 
			this.outsidepack.Format = "";
			this.outsidepack.FormatInfo = null;
			this.outsidepack.HeaderText = "外包装数量";
			this.outsidepack.MappingName = "outsidepack";
			this.outsidepack.NullText = "";
			this.outsidepack.Width = 75;
			// 
			// PACK_NAMECN
			// 
			this.PACK_NAMECN.Format = "";
			this.PACK_NAMECN.FormatInfo = null;
			this.PACK_NAMECN.HeaderText = "内包装种类";
			this.PACK_NAMECN.MappingName = "PACK_NAMECN";
			this.PACK_NAMECN.NullText = "";
			this.PACK_NAMECN.Width = 75;
			// 
			// insidepack
			// 
			this.insidepack.Format = "";
			this.insidepack.FormatInfo = null;
			this.insidepack.HeaderText = "内包装数量";
			this.insidepack.MappingName = "insidepack";
			this.insidepack.NullText = "";
			this.insidepack.Width = 75;
			// 
			// netweight
			// 
			this.netweight.Format = "";
			this.netweight.FormatInfo = null;
			this.netweight.HeaderText = "净重";
			this.netweight.MappingName = "netweight";
			this.netweight.NullText = "";
			this.netweight.Width = 75;
			// 
			// grossweight
			// 
			this.grossweight.Format = "";
			this.grossweight.FormatInfo = null;
			this.grossweight.HeaderText = "毛重";
			this.grossweight.MappingName = "grossweight";
			this.grossweight.NullText = "";
			this.grossweight.Width = 75;
			// 
			// length
			// 
			this.length.Format = "";
			this.length.FormatInfo = null;
			this.length.HeaderText = "长";
			this.length.MappingName = "length";
			this.length.NullText = "";
			this.length.Width = 75;
			// 
			// width
			// 
			this.width.Format = "";
			this.width.FormatInfo = null;
			this.width.HeaderText = "宽";
			this.width.MappingName = "width";
			this.width.NullText = "";
			this.width.Width = 75;
			// 
			// height
			// 
			this.height.Format = "";
			this.height.FormatInfo = null;
			this.height.HeaderText = "高";
			this.height.MappingName = "height";
			this.height.NullText = "";
			this.height.Width = 75;
			// 
			// volumn
			// 
			this.volumn.Format = "";
			this.volumn.FormatInfo = null;
			this.volumn.HeaderText = "体积";
			this.volumn.MappingName = "volumn";
			this.volumn.Width = 75;
			// 
			// packrate20
			// 
			this.packrate20.Format = "";
			this.packrate20.FormatInfo = null;
			this.packrate20.HeaderText = "20\'装箱率";
			this.packrate20.MappingName = "packrate20";
			this.packrate20.NullText = "";
			this.packrate20.Width = 75;
			// 
			// packrate40
			// 
			this.packrate40.Format = "";
			this.packrate40.FormatInfo = null;
			this.packrate40.HeaderText = "40\'装箱率";
			this.packrate40.MappingName = "packrate40";
			this.packrate40.NullText = "";
			this.packrate40.Width = 75;
			// 
			// packrate40hq
			// 
			this.packrate40hq.Format = "";
			this.packrate40hq.FormatInfo = null;
			this.packrate40hq.HeaderText = "45\'装箱率";
			this.packrate40hq.MappingName = "packrate40hq";
			this.packrate40hq.NullText = "";
			this.packrate40hq.Width = 75;
			// 
			// property1
			// 
			this.property1.Format = "";
			this.property1.FormatInfo = null;
			this.property1.HeaderText = "源厂编码";
			this.property1.MappingName = "property1";
			this.property1.NullText = "";
			this.property1.Width = 75;
			// 
			// property2
			// 
			this.property2.Format = "";
			this.property2.FormatInfo = null;
			this.property2.HeaderText = "原产地";
			this.property2.MappingName = "property2";
			this.property2.NullText = "";
			this.property2.Width = 75;
			// 
			// createby
			// 
			this.createby.Format = "";
			this.createby.FormatInfo = null;
			this.createby.HeaderText = "创建人";
			this.createby.MappingName = "createby";
			this.createby.NullText = "";
			this.createby.Width = 75;
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
			// linkLabel8
			// 
			this.linkLabel8.BackColor = System.Drawing.Color.Transparent;
			this.linkLabel8.Location = new System.Drawing.Point(664, 304);
			this.linkLabel8.Name = "linkLabel8";
			this.linkLabel8.Size = new System.Drawing.Size(88, 23);
			this.linkLabel8.TabIndex = 162;
			this.linkLabel8.TabStop = true;
			this.linkLabel8.Text = "货品原料";
			this.linkLabel8.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel8_LinkClicked);
			// 
			// frmBasicItem
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
			this.Name = "frmBasicItem";
			this.Text = "货品资料";
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
				if(this.textBox1.Text.Trim().Equals(""))
				{
					sb.Append("  货品编码必须填写！");
					TJSystem.Public.PublicStatic.ShowMessage(TJSystem.Public.MessageType.Error,sb.ToString());
					return false;
				}
				if(TJSystem.Public.PublicStatic.IsExsist(_table,_PK,this.priToolBar1))
				{
					sb.Append("  系统中已存在该货品，请重新命名货品ID");
					TJSystem.Public.PublicStatic.ShowMessage(TJSystem.Public.MessageType.Error,sb.ToString());
					return false;
				}
			}

			if(!TJSystem.Public.PublicStatic.IsNumDouble(priTextBox15.Text.Trim()))
			{
				sb.Append("  净重必须是数字！");
				TJSystem.Public.PublicStatic.ShowMessage(TJSystem.Public.MessageType.Error,sb.ToString());
				return false;
			}

			if(!TJSystem.Public.PublicStatic.IsNumDouble(priTextBox5.Text.Trim()))
			{
				sb.Append("  毛重必须是数字！");
				TJSystem.Public.PublicStatic.ShowMessage(TJSystem.Public.MessageType.Error,sb.ToString());
				return false;
			}

			if(!TJSystem.Public.PublicStatic.IsNumDouble(priTextBox26.Text.Trim())
				|| !TJSystem.Public.PublicStatic.IsNumDouble(priTextBox6.Text.Trim())
				|| !TJSystem.Public.PublicStatic.IsNumDouble(priTextBox13.Text.Trim()))
			{
				sb.Append("  尺寸必须是数字！");
				TJSystem.Public.PublicStatic.ShowMessage(TJSystem.Public.MessageType.Error,sb.ToString());
				return false;
			}

			if(!TJSystem.Public.PublicStatic.IsNumDouble(priTextBox8.Text.Trim()))
			{
				sb.Append("  销售价必须是数字！");
				TJSystem.Public.PublicStatic.ShowMessage(TJSystem.Public.MessageType.Error,sb.ToString());
				return false;
			}
			if(!TJSystem.Public.PublicStatic.IsNumDouble(priTextBox9.Text.Trim()))
			{
				sb.Append("  采购价必须是数字！");
				TJSystem.Public.PublicStatic.ShowMessage(TJSystem.Public.MessageType.Error,sb.ToString());
				return false;
			}

			if(!TJSystem.Public.PublicStatic.IsNumDouble(priTextBox10.Text.Trim()))
			{
				sb.Append("  最小订货量必须是数字！");
				TJSystem.Public.PublicStatic.ShowMessage(TJSystem.Public.MessageType.Error,sb.ToString());
				return false;
			}

			if(!TJSystem.Public.PublicStatic.IsNumDouble(priTextBox27.Text.Trim()))
			{
				sb.Append("  体积必须是数字！");
				TJSystem.Public.PublicStatic.ShowMessage(TJSystem.Public.MessageType.Error,sb.ToString());
				return false;
			}

			if(!TJSystem.Public.PublicStatic.IsNumDouble(priTextBox28.Text.Trim()))
			{
				sb.Append("  20'装箱率必须是数字！");
				TJSystem.Public.PublicStatic.ShowMessage(TJSystem.Public.MessageType.Error,sb.ToString());
				return false;
			}

			if(!TJSystem.Public.PublicStatic.IsNumDouble(priTextBox16.Text.Trim()))
			{
				sb.Append("  40'装箱率必须是数字！");
				TJSystem.Public.PublicStatic.ShowMessage(TJSystem.Public.MessageType.Error,sb.ToString());
				return false;
			}

			if(!TJSystem.Public.PublicStatic.IsNumDouble(priTextBox29.Text.Trim()))
			{
				sb.Append("  45'装箱率必须是数字！");
				TJSystem.Public.PublicStatic.ShowMessage(TJSystem.Public.MessageType.Error,sb.ToString());
				return false;
			}

			if(!TJSystem.Public.PublicStatic.IsNumDouble(priTextBox11.Text.Trim()))
			{
				sb.Append("  内包装数必须是数字！");
				TJSystem.Public.PublicStatic.ShowMessage(TJSystem.Public.MessageType.Error,sb.ToString());
				return false;
			}

			if(!TJSystem.Public.PublicStatic.IsNumDouble(priTextBox1.Text.Trim()))
			{
				sb.Append("  外包装数必须是数字！");
				TJSystem.Public.PublicStatic.ShowMessage(TJSystem.Public.MessageType.Error,sb.ToString());
				return false;
			}

			if(!TJSystem.Public.PublicStatic.IsNumDouble(priTextBox28.Text.Trim()))
			{
				sb.Append("  20'装箱率必须是数字！");
				TJSystem.Public.PublicStatic.ShowMessage(TJSystem.Public.MessageType.Error,sb.ToString());
				return false;
			}

			if(!TJSystem.Public.PublicStatic.IsNumDouble(priTextBox29.Text.Trim()))
			{
				sb.Append("  45'装箱率必须是数字！");
				TJSystem.Public.PublicStatic.ShowMessage(TJSystem.Public.MessageType.Error,sb.ToString());
				return false;
			}

			if(!TJSystem.Public.PublicStatic.IsNumDouble(priTextBox16.Text.Trim()))
			{
				sb.Append("  40'装箱率必须是数字！");
				TJSystem.Public.PublicStatic.ShowMessage(TJSystem.Public.MessageType.Error,sb.ToString());
				return false;
			}

			if(this.comboBox1.SelectedValue == null)
			{
				sb.Append("  必须选择货品大类！");
				TJSystem.Public.PublicStatic.ShowMessage(TJSystem.Public.MessageType.Error,sb.ToString());
				return false;
			}
//			if(this.priComboBox5.SelectedValue == null)
//			{
//				sb.Append("  必须选择包装方式！");
//				TJSystem.Public.PublicStatic.ShowMessage(TJSystem.Public.MessageType.Error,sb.ToString());
//				return false;
//			}
//			if(this.priComboBox6.SelectedValue == null)
//			{
//				sb.Append("  必须选择箱数计算方式！");
//				TJSystem.Public.PublicStatic.ShowMessage(TJSystem.Public.MessageType.Error,sb.ToString());
//				return false;
//			}
			if(this.priComboBox7.SelectedValue == null)
			{
				sb.Append("  必须选择外包装类型！");
				TJSystem.Public.PublicStatic.ShowMessage(TJSystem.Public.MessageType.Error,sb.ToString());
				return false;
			}
			if(this.priComboBox8.SelectedValue == null)
			{
				sb.Append("  必须选择内包装类型！");
				TJSystem.Public.PublicStatic.ShowMessage(TJSystem.Public.MessageType.Error,sb.ToString());
				return false;
			}
			if(this.priComboBox3.SelectedValue == null)
			{
				sb.Append("  必须选择售价货币类型！");
				TJSystem.Public.PublicStatic.ShowMessage(TJSystem.Public.MessageType.Error,sb.ToString());
				return false;
			}
			if(this.priComboBox4.SelectedValue == null)
			{
				sb.Append("  必须选择采购价货币类型！");
				TJSystem.Public.PublicStatic.ShowMessage(TJSystem.Public.MessageType.Error,sb.ToString());
				return false;
			}
			if(this.priComboBox2.SelectedValue == null)
			{
				sb.Append("  必须选择货品单位！");
				TJSystem.Public.PublicStatic.ShowMessage(TJSystem.Public.MessageType.Error,sb.ToString());
				return false;
			}
			if(this.priComboBox1.SelectedValue == null)
			{
				sb.Append("  必须选择货品状态！");
				TJSystem.Public.PublicStatic.ShowMessage(TJSystem.Public.MessageType.Error,sb.ToString());
				return false;
			}
			
			return true;
		}

		private void InitialGrid(string sql)
		{		
			DataTable dt = TJSystem.Public.PublicStatic.db.GetDataTable(sql);
			dt.TableName = "basic_item";
			this.dataGrid1.DataSource = dt.DefaultView;
		}

		private void AfterButtonClick(string ButtonType)
		{
			if(ButtonType.Equals("insert"))
			{
				this.textBox1.Enabled = true;
				this.priTextBox1.Enabled = true;
				this.priTextBox10.Enabled = true;
				this.priTextBox11.Enabled = true;
				this.priTextBox13.Enabled = true;
				this.priTextBox14.Enabled = true;
				this.priTextBox15.Enabled = true;
				this.priTextBox16.Enabled = true;
				this.priTextBox17.Enabled = true;
				this.priTextBox2.Enabled = true;
				this.priTextBox20.Enabled = true;
				this.priTextBox21.Enabled = true;
				this.priTextBox22.Enabled = true;
				this.priTextBox23.Enabled = true;
				this.priTextBox24.Enabled = true;
				this.priTextBox25.Enabled = true;
				this.priTextBox26.Enabled = true;
				this.priTextBox27.Enabled = true;
				this.priTextBox28.Enabled = true;
				this.priTextBox29.Enabled = true;
				this.priTextBox3.Enabled = true;
				this.priTextBox4.Enabled = true;
				this.priTextBox5.Enabled = true;
				this.priTextBox6.Enabled = true;
				this.priTextBox7.Enabled = true;
				this.priTextBox8.Enabled = true;
				this.priTextBox9.Enabled = true;

				this.comboBox1.Enabled = true;
				this.priComboBox1.Enabled = true;
				this.priComboBox2.Enabled = true;
				this.priComboBox3.Enabled = true;			
				this.priComboBox4.Enabled = true;
				this.priComboBox5.Enabled = true;
				this.priComboBox6.Enabled = true;
				this.priComboBox7.Enabled = true;
				this.priComboBox8.Enabled = true;
				
				this.textBox1.Text = "";
				this.priTextBox1.Text = "";
				this.priTextBox10.Text = "";
				this.priTextBox11.Text = "";
				this.priTextBox13.Text = "";
				this.priTextBox14.Text = "";
				this.priTextBox15.Text = "";
				this.priTextBox16.Text = "";
				this.priTextBox17.Text = "";
				this.priTextBox2.Text = "";
				this.priTextBox20.Text = "";
				this.priTextBox21.Text = "";
				this.priTextBox22.Text = "";
				this.priTextBox23.Text = "";
				this.priTextBox24.Text = "";
				this.priTextBox25.Text = "";
				this.priTextBox26.Text = "";
				this.priTextBox27.Text = "";
				this.priTextBox28.Text = "";
				this.priTextBox29.Text = "";
				this.priTextBox3.Text = "";
				this.priTextBox4.Text = "";
				this.priTextBox5.Text = "";
				this.priTextBox6.Text = "";
				this.priTextBox7.Text = "";
				this.priTextBox8.Text = "";
				this.priTextBox9.Text = "";

				this.comboBox1.Text = "";
				this.priComboBox1.Text = "";
				this.priComboBox2.Text = "";
				this.priComboBox3.Text = "";			
				this.priComboBox4.Text = "";
				this.priComboBox5.Text = "";
				this.priComboBox6.Text = "";
				this.priComboBox7.Text = "";
				this.priComboBox8.Text = "";				
			}
			else if(ButtonType.Equals("update"))
			{
				this.textBox1.Enabled = false;
				this.priTextBox1.Enabled = true;
				this.priTextBox10.Enabled = true;
				this.priTextBox11.Enabled = true;
				this.priTextBox13.Enabled = true;
				this.priTextBox14.Enabled = true;
				this.priTextBox15.Enabled = true;
				this.priTextBox16.Enabled = true;
				this.priTextBox17.Enabled = true;
				this.priTextBox2.Enabled = true;
				this.priTextBox20.Enabled = true;
				this.priTextBox21.Enabled = true;
				this.priTextBox22.Enabled = true;
				this.priTextBox23.Enabled = true;
				this.priTextBox24.Enabled = true;
				this.priTextBox25.Enabled = true;
				this.priTextBox26.Enabled = true;
				this.priTextBox27.Enabled = true;
				this.priTextBox28.Enabled = true;
				this.priTextBox29.Enabled = true;
				this.priTextBox3.Enabled = true;
				this.priTextBox4.Enabled = true;
				this.priTextBox5.Enabled = true;
				this.priTextBox6.Enabled = true;
				this.priTextBox7.Enabled = true;
				this.priTextBox8.Enabled = true;
				this.priTextBox9.Enabled = true;

				this.comboBox1.Enabled = true;
				this.priComboBox1.Enabled = true;
				this.priComboBox2.Enabled = true;
				this.priComboBox3.Enabled = true;			
				this.priComboBox4.Enabled = true;
				this.priComboBox5.Enabled = true;
				this.priComboBox6.Enabled = true;
				this.priComboBox7.Enabled = true;
				this.priComboBox8.Enabled = true;				
			}
		}

		private void setDisable()
		{
			this.textBox1.Enabled = false;
			this.priTextBox1.Enabled = false;
			this.priTextBox10.Enabled = false;
			this.priTextBox11.Enabled = false;
			this.priTextBox13.Enabled = false;
			this.priTextBox14.Enabled = false;
			this.priTextBox15.Enabled = false;
			this.priTextBox16.Enabled = false;
			this.priTextBox17.Enabled = false;
			this.priTextBox2.Enabled = false;
			this.priTextBox20.Enabled = false;
			this.priTextBox21.Enabled = false;
			this.priTextBox22.Enabled = false;
			this.priTextBox23.Enabled = false;
			this.priTextBox24.Enabled = false;
			this.priTextBox25.Enabled = false;
			this.priTextBox26.Enabled = false;
			this.priTextBox27.Enabled = false;
			this.priTextBox28.Enabled = false;
			this.priTextBox29.Enabled = false;
			this.priTextBox3.Enabled = false;
			this.priTextBox4.Enabled = false;
			this.priTextBox5.Enabled = false;
			this.priTextBox6.Enabled = false;
			this.priTextBox7.Enabled = false;
			this.priTextBox8.Enabled = false;
			this.priTextBox9.Enabled = false;

			this.comboBox1.Enabled = false;
			this.priComboBox1.Enabled = false;
			this.priComboBox2.Enabled = false;
			this.priComboBox3.Enabled = false;			
			this.priComboBox4.Enabled = false;
			this.priComboBox5.Enabled = false;
			this.priComboBox6.Enabled = false;
			this.priComboBox7.Enabled = false;
			this.priComboBox8.Enabled = false;	
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
				TJSystem.Public.PublicStatic.formName = "货品资料";
			}
			base.OnClosing (e);
		}

		private void linkLabel1_LinkClicked(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
		{
			if(this.textBox1.Text.Trim().Equals(""))
			{
				MessageBox.Show("未选择货品编号","Error",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
				return;
			}
			frmBasicItemClientCode frm = new frmBasicItemClientCode(this.textBox1.Text);
			frm.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			frm.ShowDialog();
		}

		private void linkLabel2_LinkClicked(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
		{
			if(this.textBox1.Text.Trim().Equals(""))
			{
				MessageBox.Show("未选择货品编号","Error",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
				return;
			}
			frmBasicItemSupplier frm = new frmBasicItemSupplier(this.textBox1.Text);
			frm.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			frm.ShowDialog();
		}

		private void linkLabel3_LinkClicked(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
		{
			
			if(this.textBox1.Text.Trim().Equals(""))
			{
				MessageBox.Show("未选择货品编号","Error",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
				return;
			}
			frmBasicItemSaleHis frm = new frmBasicItemSaleHis(this.textBox1.Text);
			frm.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			frm.ShowDialog();
		}

		private void linkLabel4_LinkClicked(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
		{
			if(this.textBox1.Text.Trim().Equals(""))
			{
				MessageBox.Show("未选择货品编号","Error",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
				return;
			}
			frmBasicItemPurHis frm = new frmBasicItemPurHis(this.textBox1.Text);
			frm.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			frm.ShowDialog();
		}

		private void linkLabel5_LinkClicked(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
		{
			if(this.textBox1.Text.Trim().Equals(""))
			{
				TJSystem.Public.PublicStatic.ShowMessage(TJSystem.Public.MessageType.Exclamation,"请先选择货品编号!");
				return;
			}
			frmBasicItemPic frm = new frmBasicItemPic(this.textBox1.Text.Trim());
			frm.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			frm.ShowDialog();
		}

		private void linkLabel6_LinkClicked(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
		{
			if(this.textBox1.Text.Trim().Equals(""))
			{
				TJSystem.Public.PublicStatic.ShowMessage(TJSystem.Public.MessageType.Exclamation,"请先选择货品编号!");
				return;
			}
			frmBasicItemPrice frm = new frmBasicItemPrice(this.textBox1.Text.Trim());
			frm.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			frm.ShowDialog();
		}

		private void linkLabel7_LinkClicked(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
		{
			if(this.textBox1.Text.Trim().Equals(""))
			{
				TJSystem.Public.PublicStatic.ShowMessage(TJSystem.Public.MessageType.Exclamation,"请先选择货品编号!");
				return;
			}
			frmBasicItemPack frm = new frmBasicItemPack(this.textBox1.Text.Trim());
			frm.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			frm.ShowDialog();
		}

		private void linkLabel8_LinkClicked(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
		{
			if(this.textBox1.Text.Trim().Equals(""))
			{
				TJSystem.Public.PublicStatic.ShowMessage(TJSystem.Public.MessageType.Exclamation,"请先选择货品编号!");
				return;
			}
			frmBasicItemProperty frm = new frmBasicItemProperty(this.textBox1.Text.Trim());
			frm.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			frm.ShowDialog();
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

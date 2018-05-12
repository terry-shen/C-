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
	public class frmSaleCQ : System.Windows.Forms.Form
	{
		
		
		/// <summary>
		/// 必需的设计器变量。
		/// </summary>
		private System.ComponentModel.Container components = null;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.DataGrid dataGrid1;
		private System.Windows.Forms.DataGridTextBoxColumn fax1;
		private System.Windows.Forms.DataGridTextBoxColumn email1;
		private System.Windows.Forms.DataGridTextBoxColumn company_id;
		private System.Windows.Forms.DataGridTextBoxColumn corporation;
		private System.Windows.Forms.DataGridTextBoxColumn address;
		private System.Windows.Forms.Panel panel3;
		private TJSystem.UC.PriToolBar priToolBar1;
		private System.Windows.Forms.DataGridTextBoxColumn company_name_cn;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.DataGridTextBoxColumn website;
		private System.Windows.Forms.DataGridTextBoxColumn tel2;
		private System.Windows.Forms.DataGridTextBoxColumn fax2;
		private System.Windows.Forms.DataGridTextBoxColumn company_name;
		private System.Windows.Forms.DataGridTextBoxColumn postcode;
		private System.Windows.Forms.DataGridTextBoxColumn email2;
		private System.Windows.Forms.DataGridTextBoxColumn resume;
		private System.Windows.Forms.DataGridTextBoxColumn address_cn;
		private System.Windows.Forms.DataGridTextBoxColumn gen_manager;
		private System.Windows.Forms.DataGridTextBoxColumn tel1;
		private System.Windows.Forms.Label label32;
		private System.Windows.Forms.Label label23;
		private System.Windows.Forms.Label label18;
		private System.Windows.Forms.Label label19;
		private System.Windows.Forms.Label label22;
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
		private System.Windows.Forms.Panel panel4;
		public static System.Windows.Forms.Form frmCurrent = null ;

		public string _PK;
        private string _table = null;
		private TJSystem.Classes.PriComboBox priComboBox4;
		private TJSystem.Classes.PriComboBox priComboBox5;
		private TJSystem.Classes.PriComboBox priComboBox3;
		private TJSystem.Classes.PriComboBox priComboBox2;
		private TJSystem.Classes.PriComboBox priComboBox1;
		private TJSystem.Classes.PriComboBox priComboBox10;
		public static int Count = 0;
		private TJSystem.Classes.PriComboBox priComboBox11;
		private TJSystem.Classes.PriTextBox txt6;
		private TJSystem.Classes.PriTextBox txt15;
		private TJSystem.Classes.PriTextBox txt5;
		private TJSystem.Classes.PriTextBox txt4;
		private TJSystem.Classes.PriTextBox txt19;
		private TJSystem.Classes.PriTextBox txt17;
		private TJSystem.Classes.PriTextBox txt3;
		private TJSystem.Classes.PriTextBox txt16;
		private TJSystem.Classes.PriTextBox txt18;
		private System.Windows.Forms.LinkLabel linkLabel1;
		private System.Windows.Forms.DataGridTableStyle dataGridTableStyle1;
		private System.Windows.Forms.DataGridTextBoxColumn cq_code;
		private System.Windows.Forms.DataGridTextBoxColumn cq_date;
		private System.Windows.Forms.DataGridTextBoxColumn client_id;
		private System.Windows.Forms.DataGridTextBoxColumn client_name;
		private System.Windows.Forms.DataGridTextBoxColumn contact_id;
		private System.Windows.Forms.DataGridTextBoxColumn contact_name;
		private System.Windows.Forms.DataGridTextBoxColumn forward_id;
		private System.Windows.Forms.DataGridTextBoxColumn forward_name;
		private System.Windows.Forms.DataGridTextBoxColumn priceterm;
		private System.Windows.Forms.DataGridTextBoxColumn priceterm_dest;
		private System.Windows.Forms.DataGridTextBoxColumn remark;
		private System.Windows.Forms.DataGridTextBoxColumn createby;
		private System.Windows.Forms.DataGridTextBoxColumn createon;
		private System.Windows.Forms.DataGridTextBoxColumn modifyby;
		private System.Windows.Forms.DataGridTextBoxColumn modifyon;
		private TJSystem.Classes.PriDateTimePicker priDateTimePicker3;
		private System.Windows.Forms.DataGridTextBoxColumn Currency_namecn;
		private System.Windows.Forms.DataGridTextBoxColumn status_name;
		private System.Windows.Forms.DataGridTextBoxColumn tank_code_name;
		private System.Windows.Forms.LinkLabel linkLabel2;
		private System.Windows.Forms.LinkLabel linkLabel3;
		private System.Windows.Forms.LinkLabel linkLabel4;
		private string _statusType = null;

		private string _PKSubValue = null;

		private Image image = null;
		public frmSaleCQ()
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

			InitialFormData();
			System.Text.StringBuilder sb = new System.Text.StringBuilder();
			sb.Append("select a.cq_code,a.cq_date,a.Currency,c.Currency_namecn as Currency_namecn,a.status,b.status_name as Status_name,");
			sb.Append(" a.client_id,a.client_name,a.Contact_id,a.Contact_name,a.forward_id,a.forward_name,a.priceTerm,a.priceTerm_dest,");
			sb.Append("a.tank_code,d.tank_name as tank_code_name,a.Port_departure,e.port_namecn as Port_departure_name,a.destport,f.port_namecn as destport_name,a.destination,g.port_namecn as destination_name,");
			sb.Append(" a.arrivecountry,i.country_namecn as arrivecountry_name,a.carriagefee,a.mixfee,a.insuranceRate,a.commisionRate,a.otherfee,a.discountType,");
			sb.Append(" a.discount,a.fobamount,a.remark,a.createBy,a.createon,a.modifyBy,a.modifyon ");
			sb.Append("from sale_cq_master a");
			sb.Append(" left join p_status b");
			sb.Append(" on a.status = b.status_id and b.status_type = '"+_statusType+"'");
			sb.Append(" left join p_currency c");
			sb.Append(" on a.Currency = c.Currency_code");
			sb.Append(" left join p_tank d");
			sb.Append(" on a.tank_code = d.tank_code");
			sb.Append(" left join p_port e");
			sb.Append(" on a.Port_departure = e.port_code");
			sb.Append(" left join p_port f");
			sb.Append(" on a.destport = f.port_code");
			sb.Append(" left join p_port g");
			sb.Append(" on a.destination = g.port_code");
//			sb.Append(" left join p_region h");
//			sb.Append(" on a.arriveregion = h.region_code ");
			sb.Append(" left join p_country i");
			sb.Append(" on a.arrivecountry = i.country_code");
			sb.Append(" order by cq_code ");

			this.InitialGrid(sb.ToString());

			priToolBar1.setCurrentForm = this;
			_PK = "cq_code";
            _table = "sale_cq_master";
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

		public frmSaleCQ(string customid)
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

			InitialFormData();
			System.Text.StringBuilder sb = new System.Text.StringBuilder();
			sb.Append("select a.cq_code,a.cq_date,a.Currency,c.Currency_namecn as Currency_namecn,a.status,b.status_name as Status_name,");
			sb.Append(" a.client_id,a.client_name,a.Contact_id,a.Contact_name,a.forward_id,a.forward_name,a.priceTerm,a.priceTerm_dest,");
			sb.Append("a.tank_code,d.tank_name as tank_code_name,a.Port_departure,e.port_namecn as Port_departure_name,a.destport,f.port_namecn as destport_name,a.destination,g.port_namecn as destination_name,");
			sb.Append(" a.arrivecountry,i.country_namecn as arrivecountry_name,a.carriagefee,a.mixfee,a.insuranceRate,a.commisionRate,a.otherfee,a.discountType,");
			sb.Append(" a.discount,a.fobamount,a.remark,a.createBy,a.createon,a.modifyBy,a.modifyon ");
			sb.Append("from sale_cq_master a");
			sb.Append(" left join p_status b");
			sb.Append(" on a.status = b.status_id and b.status_type = '"+_statusType+"'");
			sb.Append(" left join p_currency c");
			sb.Append(" on a.Currency = c.Currency_code");
			sb.Append(" left join p_tank d");
			sb.Append(" on a.tank_code = d.tank_code");
			sb.Append(" left join p_port e");
			sb.Append(" on a.Port_departure = e.port_code");
			sb.Append(" left join p_port f");
			sb.Append(" on a.destport = f.port_code");
			sb.Append(" left join p_port g");
			sb.Append(" on a.destination = g.port_code");
			sb.Append(" left join p_country i");
			sb.Append(" on a.arrivecountry = i.country_code");
			sb.Append(" where a.client_id=");
			sb.Append("'");
			sb.Append(customid);
			sb.Append("'");
			sb.Append(" order by cq_code ");

			this.InitialGrid(sb.ToString());

			priToolBar1.setCurrentForm = this;
			_PK = "cq_code";
			_table = "sale_cq_master";
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
			this.priComboBox1.DataSource = dtcpy.DefaultView;
			this.priComboBox1.ValueMember = "Client_id";
			this.priComboBox1.DisplayMember = "Client_name";


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
			this.priComboBox10.DataSource = dtcpy.DefaultView;
			this.priComboBox10.ValueMember = "STATUS_ID";
			this.priComboBox10.DisplayMember = "STATUS_NAME";

			sql = "select Currency_Code,Currency_Code+' '+Currency_nameCn as Currency_nameCn from p_Currency order by Currency_Code";
			dt = TJSystem.Public.PublicStatic.db.GetDataTable(sql);
			dr = dt.NewRow() ;
			dr[0] = "" ;
			dr[1] = "" ;
			dt.Rows.InsertAt(dr,0) ;
			dtcpy = dt.Copy();
			this.priComboBox11.DataSource = dtcpy.DefaultView;
			this.priComboBox11.ValueMember = "Currency_Code";
			this.priComboBox11.DisplayMember = "Currency_nameCn";

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

			//货柜类型
			sql = "select tank_code,tank_code+' '+tank_name as tank_name from p_tank order by tank_code";
			dt = TJSystem.Public.PublicStatic.db.GetDataTable(sql);
			dr = dt.NewRow() ;
			dr[0] = "" ;
			dr[1] = "" ;
			dt.Rows.InsertAt(dr,0) ;
			dtcpy = dt.Copy();
			this.priComboBox5.DataSource = dtcpy.DefaultView;
			this.priComboBox5.ValueMember = "tank_code";
			this.priComboBox5.DisplayMember = "tank_name";


			//起运港
#if false
			sql = "select port_code,port_code+' '+port_namecn as port_namecn from p_port order by port_code";
			dt = TJSystem.Public.PublicStatic.db.GetDataTable(sql);
			dr = dt.NewRow() ;
			dr[0] = "" ;
			dr[1] = "" ;
			dt.Rows.InsertAt(dr,0) ;
			dtcpy = dt.Copy();
			this.priComboBox6.DataSource = dtcpy.DefaultView;
			this.priComboBox6.ValueMember = "port_code";
			this.priComboBox6.DisplayMember = "port_namecn";

			//运抵港
			sql = "select port_code,port_code+' '+port_namecn as port_namecn from p_port order by port_code";
			dt = TJSystem.Public.PublicStatic.db.GetDataTable(sql);
			dr = dt.NewRow() ;
			dr[0] = "" ;
			dr[1] = "" ;
			dt.Rows.InsertAt(dr,0) ;
			dtcpy = dt.Copy();
			this.priComboBox7.DataSource = dtcpy.DefaultView;
			this.priComboBox7.ValueMember = "port_code";
			this.priComboBox7.DisplayMember = "port_namecn";

			//目的港
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
#endif
			//运输商
			sql = "select FORWARDER_ID,FORWARDER_ID+' '+FORWARDER_NAME as FORWARDER_NAME from basic_forwarder order by FORWARDER_ID";
			dt = TJSystem.Public.PublicStatic.db.GetDataTable(sql);
			dr = dt.NewRow() ;
			dr[0] = "" ;
			dr[1] = "" ;
			dt.Rows.InsertAt(dr,0) ;
			dtcpy = dt.Copy();
			this.priComboBox3.DataSource = dtcpy.DefaultView;
			this.priComboBox3.ValueMember = "FORWARDER_ID";
			this.priComboBox3.DisplayMember = "FORWARDER_NAME";

#if false
			//目的地
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
#endif
			sql = "select  a.client_name as client_name, b.contact_id, b.contact_id +' '+b.contact_name as contact_name  from basic_client a join basic_client_contact b on a.client_id = b.client_id ";
			dt = TJSystem.Public.PublicStatic.db.GetDataTable(sql);
			
			dr = dt.NewRow();
			dr[0] = "";
			dr[1] = "";
			dt.Rows.InsertAt(dr,0);
			dtcpy = dt.Copy();
			this.priComboBox2.DataSource = dtcpy.DefaultView;
			this.priComboBox2.ValueMember = "contact_id";
			this.priComboBox2.DisplayMember = "contact_name";
//			sql = "select port_code,port_code+' '+port_namecn as port_namecn from p_port order by port_code";
//			dt = TJSystem.Public.PublicStatic.db.GetDataTable(sql);
//			this.priComboBox10.DataSource = dt.DefaultView;
//			this.priComboBox10.ValueMember = "port_code";
//			this.priComboBox10.DisplayMember = "port_namecn";
		}

		private bool BeforeButtonClick(string sqltype)
		{
			System.Text.StringBuilder sb = new System.Text.StringBuilder();
			sb.Append("数据验证错误：\r\n");
			if(sqltype.Equals("default"))
			{
				this.setDisable();
			}
			if(sqltype.Equals("insert") || sqltype.Equals("updata"))
			{
				if(!checkFormValue(sqltype))
				{
//					MessageBox.Show(sb.ToString(),"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
					return false;
				}
			}
			return true;
		}


        private bool checkFormValue(string sqltype)
        {			
            if(sqltype.Equals("insert"))
            {
                if (this.txt1.Text == "")
                {
                    MessageBox.Show("请输入报价单号","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    return false;
                }
			
                if(TJSystem.Public.PublicStatic.IsExsist(this._table,this._PK,this.priToolBar1))
                {
                    MessageBox.Show("这张报价单已经存在,请另外开立","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    return false;
                }
            }

            //check输入值的属性
            if(this.priComboBox11.SelectedValue == null)
            {
                TJSystem.Public.PublicStatic.ShowMessage(TJSystem.Public.MessageType.Exclamation,"必须选择货币类型！");
                return false;
            }
            if(this.priComboBox10.SelectedValue == null)
            {
                TJSystem.Public.PublicStatic.ShowMessage(TJSystem.Public.MessageType.Exclamation,"必须选择报价单状态！");
                return false;
            }
            if(this.priComboBox1.SelectedValue == null)
            {
                TJSystem.Public.PublicStatic.ShowMessage(TJSystem.Public.MessageType.Exclamation,"必须选择客户代码！");
                return false;
            }
            if(this.priComboBox2.SelectedValue == null)
            {
                TJSystem.Public.PublicStatic.ShowMessage(TJSystem.Public.MessageType.Exclamation,"必须选择联系人！");
                return false;
            }
            if(this.priComboBox3.SelectedValue == null)
            {
                TJSystem.Public.PublicStatic.ShowMessage(TJSystem.Public.MessageType.Exclamation,"必须选择运输商！");
                return false;
            }
            if(this.priComboBox4.SelectedValue == null)
            {
                TJSystem.Public.PublicStatic.ShowMessage(TJSystem.Public.MessageType.Exclamation,"必须选择价格条款！");
                return false;
            }
            if(this.priComboBox5.SelectedValue == null)
            {
                TJSystem.Public.PublicStatic.ShowMessage(TJSystem.Public.MessageType.Exclamation,"必须选择货柜类型！");
                return false;
            }
#if false
            if(this.priComboBox6.SelectedValue == null)
            {
                TJSystem.Public.PublicStatic.ShowMessage(TJSystem.Public.MessageType.Exclamation,"必须选择起运港！");
                return false;
            }
            if(this.priComboBox7.SelectedValue == null)
            {
                TJSystem.Public.PublicStatic.ShowMessage(TJSystem.Public.MessageType.Exclamation,"必须选择运抵港！");
                return false;
            }
            if(this.priComboBox8.SelectedValue == null)
            {
                TJSystem.Public.PublicStatic.ShowMessage(TJSystem.Public.MessageType.Exclamation,"必须选择目的港！");
                return false;
            }
            if(!TJSystem.Public.PublicStatic.IsNumDouble(this.txt7.Text.Trim()))
            {
                TJSystem.Public.PublicStatic.ShowMessage(TJSystem.Public.MessageType.Error,"运费必须是数字！");
                return false;
            }
            if(!TJSystem.Public.PublicStatic.IsNumDouble(this.txt8.Text.Trim()))
            {
                TJSystem.Public.PublicStatic.ShowMessage(TJSystem.Public.MessageType.Error,"杂费必须是数字！");
                return false;
            }
            if(!TJSystem.Public.PublicStatic.IsNumDouble(this.txt11.Text.Trim()))
            {
                TJSystem.Public.PublicStatic.ShowMessage(TJSystem.Public.MessageType.Error,"其它费用必须是数字！");
                return false;
            }
            if(this.priComboBox9.SelectedValue == null)
            {
                TJSystem.Public.PublicStatic.ShowMessage(TJSystem.Public.MessageType.Exclamation,"必须选择目的地！");
                return false;
            }
//            if(!TJSystem.Public.PublicStatic.IsNumDouble(this.txt12.Text.Trim()))
//            {
//                TJSystem.Public.PublicStatic.ShowMessage(TJSystem.Public.MessageType.Error,"折扣类型必须是数字！");
//                return false;
//            }
            if(!TJSystem.Public.PublicStatic.IsNumDouble(this.txt13.Text.Trim()))
            {
                TJSystem.Public.PublicStatic.ShowMessage(TJSystem.Public.MessageType.Error,"折扣必须是数字！");
                return false;
            }
            if(!TJSystem.Public.PublicStatic.IsNumDouble(this.txt14.Text.Trim()))
            {
                TJSystem.Public.PublicStatic.ShowMessage(TJSystem.Public.MessageType.Error,"FOB金额必须是数字！");
                return false;
            }
            if(!TJSystem.Public.PublicStatic.IsNumDouble(this.txt9.Text.Trim()))
            {
                TJSystem.Public.PublicStatic.ShowMessage(TJSystem.Public.MessageType.Error,"保险费率必须是数字！");
                return false;
            }
            if(!TJSystem.Public.PublicStatic.IsNumDouble(this.txt10.Text.Trim()))
            {
                TJSystem.Public.PublicStatic.ShowMessage(TJSystem.Public.MessageType.Error,"佣金费率必须是数字！");
                return false;
            }	
#endif

			if(sqltype.Equals("insert"))
			{
				/*
				int ret = 0;
				PublicStatic.Classes.common.CommonSubTableHandle csth = new PublicStatic.Classes.common.CommonSubTableHandle();
				csth.TableName = "sale_cq_deatil";
				csth.PrimaryKeyField = "cq_code";
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
			this.txt3.Enabled = false;
			this.txt4.Enabled = false;
			this.txt5.Enabled = false;
			this.txt6.Enabled = false;
#if false
			this.txt7.Enabled = false;
			this.txt8.Enabled = false;
			this.txt9.Enabled = false;
			this.txt10.Enabled = false;
			this.txt11.Enabled = false;
			this.txt12.Enabled = false;
			this.txt13.Enabled = false;
			this.txt14.Enabled = false;
#endif
			this.txt15.Enabled = false;
			this.txt16.Enabled = false;
			this.txt17.Enabled = false;
			this.txt18.Enabled = false;
			this.txt19.Enabled = false;
			this.priComboBox1.Enabled = false;
			this.priComboBox2.Enabled = false;
			this.priComboBox3.Enabled = false;
			this.priComboBox4.Enabled = false;
			this.priComboBox5.Enabled = false;
#if false
			this.priComboBox6.Enabled = false;
			this.priComboBox7.Enabled = false;
			this.priComboBox8.Enabled = false;
			this.priComboBox9.Enabled = false;
#endif
			this.priComboBox10.Enabled = false;
			this.priComboBox11.Enabled = false;
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
//				this.txt3.Enabled = true;
//				this.txt4.Enabled = true;
//				this.txt5.Enabled = true;
//				this.txt6.Enabled = true;
#if false
				this.txt7.Enabled = true;
				this.txt8.Enabled = true;
				this.txt9.Enabled = true;
				this.txt10.Enabled = true;
				this.txt11.Enabled = true;
				this.txt12.Enabled = true;
				this.txt13.Enabled = true;
				this.txt14.Enabled = true;
#endif
				this.txt15.Enabled = true;
				this.priComboBox1.Enabled = true;
				this.priComboBox2.Enabled = true;
				this.priComboBox3.Enabled = true;
				this.priComboBox4.Enabled = true;
				this.priComboBox5.Enabled = true;
#if false
				this.priComboBox6.Enabled = true;
				this.priComboBox7.Enabled = true;
				this.priComboBox8.Enabled = true;
				this.priComboBox9.Enabled = true;
#endif
				this.priComboBox10.Enabled = false;
				this.priComboBox11.Enabled = true;
				this.txt1.Text = "";
				this.priDateTimePicker3.Value = System.DateTime.Now;
				this.txt3.Text = "";
				this.txt4.Text = "";
				this.txt5.Text = "";
				this.txt6.Text = "";
#if false
				this.txt7.Text = "";
				this.txt8.Text = "";
				this.txt9.Text = "";
				this.txt10.Text = "";
				this.txt11.Text = "";
				this.txt12.Text = "";
				this.txt13.Text = "";
				this.txt14.Text = "";
#endif
				this.txt15.Text = "";
				this.txt16.Text = "";
				this.txt17.Text = "";
				this.txt18.Text = "";
				this.txt19.Text = "";
				this.priComboBox10.SelectedValue = "1";
			}
			else if(ButtonType.Equals("update"))
			{
				this.txt1.Enabled = true;
				this.priDateTimePicker3.Enabled = true;
//				this.txt3.Enabled = true;
//				this.txt4.Enabled = true;
//				this.txt5.Enabled = true;
//				this.txt6.Enabled = true;
#if false
				this.txt7.Enabled = true;
				this.txt8.Enabled = true;
				this.txt9.Enabled = true;
				this.txt10.Enabled = true;
				this.txt11.Enabled = true;
				this.txt12.Enabled = true;
				this.txt13.Enabled = true;
				this.txt14.Enabled = true;
#endif
				this.txt15.Enabled = true;
				this.priComboBox1.Enabled = true;
				this.priComboBox2.Enabled = true;
				this.priComboBox3.Enabled = true;
				this.priComboBox4.Enabled = true;
				this.priComboBox5.Enabled = true;
#if false
				this.priComboBox6.Enabled = true;
				this.priComboBox7.Enabled = true;
				this.priComboBox8.Enabled = true;
				this.priComboBox9.Enabled = true;
#endif
				this.priComboBox10.Enabled = false;
				this.priComboBox11.Enabled = true;
			}
		}

		private void InitialGrid(string sql)
		{		
			DataTable dt = TJSystem.Public.PublicStatic.db.GetDataTable(sql);
			dt.TableName = "sale_cq_master";
			this.dataGrid1.DataSource = dt.DefaultView;
		}

//		private void InitialGrid1(string sql)
//		{		
//			DataTable dt = TJSystem.Public.PublicStatic.db.GetDataTable(sql);
//			dt.TableName = "sale_cq_deatil";
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(frmSaleCQ));
			this.panel2 = new System.Windows.Forms.Panel();
			this.dataGrid1 = new System.Windows.Forms.DataGrid();
			this.dataGridTableStyle1 = new System.Windows.Forms.DataGridTableStyle();
			this.cq_code = new System.Windows.Forms.DataGridTextBoxColumn();
			this.cq_date = new System.Windows.Forms.DataGridTextBoxColumn();
			this.Currency_namecn = new System.Windows.Forms.DataGridTextBoxColumn();
			this.status_name = new System.Windows.Forms.DataGridTextBoxColumn();
			this.client_id = new System.Windows.Forms.DataGridTextBoxColumn();
			this.client_name = new System.Windows.Forms.DataGridTextBoxColumn();
			this.contact_id = new System.Windows.Forms.DataGridTextBoxColumn();
			this.contact_name = new System.Windows.Forms.DataGridTextBoxColumn();
			this.forward_id = new System.Windows.Forms.DataGridTextBoxColumn();
			this.forward_name = new System.Windows.Forms.DataGridTextBoxColumn();
			this.priceterm = new System.Windows.Forms.DataGridTextBoxColumn();
			this.priceterm_dest = new System.Windows.Forms.DataGridTextBoxColumn();
			this.tank_code_name = new System.Windows.Forms.DataGridTextBoxColumn();
			this.remark = new System.Windows.Forms.DataGridTextBoxColumn();
			this.createby = new System.Windows.Forms.DataGridTextBoxColumn();
			this.createon = new System.Windows.Forms.DataGridTextBoxColumn();
			this.modifyby = new System.Windows.Forms.DataGridTextBoxColumn();
			this.modifyon = new System.Windows.Forms.DataGridTextBoxColumn();
			this.panel4 = new System.Windows.Forms.Panel();
			this.linkLabel3 = new System.Windows.Forms.LinkLabel();
			this.linkLabel2 = new System.Windows.Forms.LinkLabel();
			this.priDateTimePicker3 = new TJSystem.Classes.PriDateTimePicker();
			this.linkLabel1 = new System.Windows.Forms.LinkLabel();
			this.priComboBox11 = new TJSystem.Classes.PriComboBox();
			this.priComboBox10 = new TJSystem.Classes.PriComboBox();
			this.priComboBox5 = new TJSystem.Classes.PriComboBox();
			this.priComboBox4 = new TJSystem.Classes.PriComboBox();
			this.txt6 = new TJSystem.Classes.PriTextBox();
			this.priComboBox3 = new TJSystem.Classes.PriComboBox();
			this.priComboBox2 = new TJSystem.Classes.PriComboBox();
			this.priComboBox1 = new TJSystem.Classes.PriComboBox();
			this.label32 = new System.Windows.Forms.Label();
			this.txt15 = new TJSystem.Classes.PriTextBox();
			this.label23 = new System.Windows.Forms.Label();
			this.label18 = new System.Windows.Forms.Label();
			this.label19 = new System.Windows.Forms.Label();
			this.label22 = new System.Windows.Forms.Label();
			this.txt5 = new TJSystem.Classes.PriTextBox();
			this.label9 = new System.Windows.Forms.Label();
			this.txt4 = new TJSystem.Classes.PriTextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label21 = new System.Windows.Forms.Label();
			this.txt19 = new TJSystem.Classes.PriTextBox();
			this.label20 = new System.Windows.Forms.Label();
			this.txt17 = new TJSystem.Classes.PriTextBox();
			this.label17 = new System.Windows.Forms.Label();
			this.label15 = new System.Windows.Forms.Label();
			this.label12 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.txt3 = new TJSystem.Classes.PriTextBox();
			this.txt16 = new TJSystem.Classes.PriTextBox();
			this.txt18 = new TJSystem.Classes.PriTextBox();
			this.txt1 = new TJSystem.Classes.PriTextBox();
			this.fax1 = new System.Windows.Forms.DataGridTextBoxColumn();
			this.email1 = new System.Windows.Forms.DataGridTextBoxColumn();
			this.company_id = new System.Windows.Forms.DataGridTextBoxColumn();
			this.corporation = new System.Windows.Forms.DataGridTextBoxColumn();
			this.address = new System.Windows.Forms.DataGridTextBoxColumn();
			this.panel3 = new System.Windows.Forms.Panel();
			this.priToolBar1 = new TJSystem.UC.PriToolBar();
			this.company_name_cn = new System.Windows.Forms.DataGridTextBoxColumn();
			this.panel1 = new System.Windows.Forms.Panel();
			this.label1 = new System.Windows.Forms.Label();
			this.website = new System.Windows.Forms.DataGridTextBoxColumn();
			this.tel2 = new System.Windows.Forms.DataGridTextBoxColumn();
			this.fax2 = new System.Windows.Forms.DataGridTextBoxColumn();
			this.company_name = new System.Windows.Forms.DataGridTextBoxColumn();
			this.postcode = new System.Windows.Forms.DataGridTextBoxColumn();
			this.email2 = new System.Windows.Forms.DataGridTextBoxColumn();
			this.resume = new System.Windows.Forms.DataGridTextBoxColumn();
			this.address_cn = new System.Windows.Forms.DataGridTextBoxColumn();
			this.gen_manager = new System.Windows.Forms.DataGridTextBoxColumn();
			this.tel1 = new System.Windows.Forms.DataGridTextBoxColumn();
			this.linkLabel4 = new System.Windows.Forms.LinkLabel();
			this.panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).BeginInit();
			this.panel4.SuspendLayout();
			this.panel3.SuspendLayout();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
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
			this.panel2.Size = new System.Drawing.Size(784, 478);
			this.panel2.TabIndex = 14;
			// 
			// dataGrid1
			// 
			this.dataGrid1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.dataGrid1.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.dataGrid1.CaptionBackColor = System.Drawing.SystemColors.ControlDark;
			this.dataGrid1.CaptionText = "报价单";
			this.dataGrid1.DataMember = "";
			this.dataGrid1.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.dataGrid1.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.dataGrid1.Location = new System.Drawing.Point(0, 168);
			this.dataGrid1.Name = "dataGrid1";
			this.dataGrid1.ReadOnly = true;
			this.dataGrid1.Size = new System.Drawing.Size(776, 304);
			this.dataGrid1.TabIndex = 1;
			this.dataGrid1.TableStyles.AddRange(new System.Windows.Forms.DataGridTableStyle[] {
																								  this.dataGridTableStyle1});
			this.dataGrid1.Navigate += new System.Windows.Forms.NavigateEventHandler(this.dataGrid1_Navigate);
			// 
			// dataGridTableStyle1
			// 
			this.dataGridTableStyle1.DataGrid = this.dataGrid1;
			this.dataGridTableStyle1.GridColumnStyles.AddRange(new System.Windows.Forms.DataGridColumnStyle[] {
																												  this.cq_code,
																												  this.cq_date,
																												  this.Currency_namecn,
																												  this.status_name,
																												  this.client_id,
																												  this.client_name,
																												  this.contact_id,
																												  this.contact_name,
																												  this.forward_id,
																												  this.forward_name,
																												  this.priceterm,
																												  this.priceterm_dest,
																												  this.tank_code_name,
																												  this.remark,
																												  this.createby,
																												  this.createon,
																												  this.modifyby,
																												  this.modifyon});
			this.dataGridTableStyle1.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.dataGridTableStyle1.MappingName = "sale_cq_master";
			// 
			// cq_code
			// 
			this.cq_code.Format = "";
			this.cq_code.FormatInfo = null;
			this.cq_code.HeaderText = "报价单号";
			this.cq_code.MappingName = "cq_code";
			this.cq_code.NullText = "";
			this.cq_code.Width = 75;
			// 
			// cq_date
			// 
			this.cq_date.Format = "";
			this.cq_date.FormatInfo = null;
			this.cq_date.HeaderText = "报价时间";
			this.cq_date.MappingName = "cq_date";
			this.cq_date.NullText = "";
			this.cq_date.Width = 75;
			// 
			// Currency_namecn
			// 
			this.Currency_namecn.Format = "";
			this.Currency_namecn.FormatInfo = null;
			this.Currency_namecn.HeaderText = "币种";
			this.Currency_namecn.MappingName = "Currency_namecn";
			this.Currency_namecn.NullText = "";
			this.Currency_namecn.Width = 75;
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
			this.contact_name.HeaderText = "联系人名称";
			this.contact_name.MappingName = "contact_name";
			this.contact_name.NullText = "";
			this.contact_name.Width = 75;
			// 
			// forward_id
			// 
			this.forward_id.Format = "";
			this.forward_id.FormatInfo = null;
			this.forward_id.HeaderText = "运输商";
			this.forward_id.MappingName = "forward_id";
			this.forward_id.NullText = "";
			this.forward_id.Width = 75;
			// 
			// forward_name
			// 
			this.forward_name.Format = "";
			this.forward_name.FormatInfo = null;
			this.forward_name.HeaderText = "运输商名称";
			this.forward_name.MappingName = "forward_name";
			this.forward_name.NullText = "";
			this.forward_name.Width = 75;
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
			// tank_code_name
			// 
			this.tank_code_name.Format = "";
			this.tank_code_name.FormatInfo = null;
			this.tank_code_name.HeaderText = "货柜类型";
			this.tank_code_name.MappingName = "tank_code_name";
			this.tank_code_name.NullText = "";
			this.tank_code_name.Width = 75;
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
			this.createby.HeaderText = "创建人";
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
			// panel4
			// 
			this.panel4.BackColor = System.Drawing.SystemColors.ScrollBar;
			this.panel4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel4.BackgroundImage")));
			this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.panel4.Controls.Add(this.linkLabel4);
			this.panel4.Controls.Add(this.linkLabel3);
			this.panel4.Controls.Add(this.linkLabel2);
			this.panel4.Controls.Add(this.priDateTimePicker3);
			this.panel4.Controls.Add(this.linkLabel1);
			this.panel4.Controls.Add(this.priComboBox11);
			this.panel4.Controls.Add(this.priComboBox10);
			this.panel4.Controls.Add(this.priComboBox5);
			this.panel4.Controls.Add(this.priComboBox4);
			this.panel4.Controls.Add(this.txt6);
			this.panel4.Controls.Add(this.priComboBox3);
			this.panel4.Controls.Add(this.priComboBox2);
			this.panel4.Controls.Add(this.priComboBox1);
			this.panel4.Controls.Add(this.label32);
			this.panel4.Controls.Add(this.txt15);
			this.panel4.Controls.Add(this.label23);
			this.panel4.Controls.Add(this.label18);
			this.panel4.Controls.Add(this.label19);
			this.panel4.Controls.Add(this.label22);
			this.panel4.Controls.Add(this.txt5);
			this.panel4.Controls.Add(this.label9);
			this.panel4.Controls.Add(this.txt4);
			this.panel4.Controls.Add(this.label5);
			this.panel4.Controls.Add(this.label3);
			this.panel4.Controls.Add(this.label21);
			this.panel4.Controls.Add(this.txt19);
			this.panel4.Controls.Add(this.label20);
			this.panel4.Controls.Add(this.txt17);
			this.panel4.Controls.Add(this.label17);
			this.panel4.Controls.Add(this.label15);
			this.panel4.Controls.Add(this.label12);
			this.panel4.Controls.Add(this.label11);
			this.panel4.Controls.Add(this.label8);
			this.panel4.Controls.Add(this.label7);
			this.panel4.Controls.Add(this.label2);
			this.panel4.Controls.Add(this.txt3);
			this.panel4.Controls.Add(this.txt16);
			this.panel4.Controls.Add(this.txt18);
			this.panel4.Controls.Add(this.txt1);
			this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel4.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.panel4.Location = new System.Drawing.Point(0, 0);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(780, 160);
			this.panel4.TabIndex = 0;
			// 
			// linkLabel3
			// 
			this.linkLabel3.AutoSize = true;
			this.linkLabel3.BackColor = System.Drawing.Color.Transparent;
			this.linkLabel3.Location = new System.Drawing.Point(120, 136);
			this.linkLabel3.Name = "linkLabel3";
			this.linkLabel3.Size = new System.Drawing.Size(70, 19);
			this.linkLabel3.TabIndex = 216;
			this.linkLabel3.TabStop = true;
			this.linkLabel3.Text = "QUOTATION";
			this.linkLabel3.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel3_LinkClicked);
			// 
			// linkLabel2
			// 
			this.linkLabel2.AutoSize = true;
			this.linkLabel2.BackColor = System.Drawing.Color.Transparent;
			this.linkLabel2.Location = new System.Drawing.Point(656, 144);
			this.linkLabel2.Name = "linkLabel2";
			this.linkLabel2.Size = new System.Drawing.Size(85, 19);
			this.linkLabel2.TabIndex = 215;
			this.linkLabel2.TabStop = true;
			this.linkLabel2.Text = "Offer Sheet";
			this.linkLabel2.Visible = false;
			this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
			// 
			// priDateTimePicker3
			// 
			this.priDateTimePicker3.CustomFormat = "yyyy-MM-dd";
			this.priDateTimePicker3.DataField = "cq_date";
			this.priDateTimePicker3.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.priDateTimePicker3.Location = new System.Drawing.Point(288, 8);
			this.priDateTimePicker3.Name = "priDateTimePicker3";
			this.priDateTimePicker3.Size = new System.Drawing.Size(128, 23);
			this.priDateTimePicker3.TabIndex = 214;
			// 
			// linkLabel1
			// 
			this.linkLabel1.AutoSize = true;
			this.linkLabel1.BackColor = System.Drawing.Color.Transparent;
			this.linkLabel1.Location = new System.Drawing.Point(48, 136);
			this.linkLabel1.Name = "linkLabel1";
			this.linkLabel1.Size = new System.Drawing.Size(63, 19);
			this.linkLabel1.TabIndex = 203;
			this.linkLabel1.TabStop = true;
			this.linkLabel1.Text = "报价明细";
			this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
			// 
			// priComboBox11
			// 
			this.priComboBox11.BackColor = System.Drawing.Color.White;
			this.priComboBox11.DataField = "Currency";
			this.priComboBox11.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.priComboBox11.Location = new System.Drawing.Point(480, 8);
			this.priComboBox11.Name = "priComboBox11";
			this.priComboBox11.Size = new System.Drawing.Size(104, 22);
			this.priComboBox11.TabIndex = 202;
			// 
			// priComboBox10
			// 
			this.priComboBox10.BackColor = System.Drawing.Color.White;
			this.priComboBox10.DataField = "status";
			this.priComboBox10.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.priComboBox10.Location = new System.Drawing.Point(648, 8);
			this.priComboBox10.Name = "priComboBox10";
			this.priComboBox10.Size = new System.Drawing.Size(120, 22);
			this.priComboBox10.TabIndex = 201;
			// 
			// priComboBox5
			// 
			this.priComboBox5.BackColor = System.Drawing.Color.White;
			this.priComboBox5.DataField = "tank_code";
			this.priComboBox5.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.priComboBox5.Location = new System.Drawing.Point(96, 80);
			this.priComboBox5.Name = "priComboBox5";
			this.priComboBox5.Size = new System.Drawing.Size(120, 22);
			this.priComboBox5.TabIndex = 196;
			// 
			// priComboBox4
			// 
			this.priComboBox4.BackColor = System.Drawing.Color.White;
			this.priComboBox4.DataField = "priceTerm";
			this.priComboBox4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.priComboBox4.Location = new System.Drawing.Point(480, 56);
			this.priComboBox4.Name = "priComboBox4";
			this.priComboBox4.Size = new System.Drawing.Size(104, 22);
			this.priComboBox4.TabIndex = 195;
			this.priComboBox4.SelectionChangeCommitted += new System.EventHandler(this.priComboBox4_SelectionChangeCommitted);
			// 
			// txt6
			// 
			this.txt6.BackColor = System.Drawing.Color.White;
			this.txt6.DataField = "priceTerm_dest";
			this.txt6.DataType = TJSystem.Public.DataType.String;
			this.txt6.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.txt6.Location = new System.Drawing.Point(584, 56);
			this.txt6.Name = "txt6";
			this.txt6.Size = new System.Drawing.Size(184, 23);
			this.txt6.TabIndex = 194;
			this.txt6.Text = "";
			// 
			// priComboBox3
			// 
			this.priComboBox3.BackColor = System.Drawing.Color.White;
			this.priComboBox3.DataField = "forward_id";
			this.priComboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.priComboBox3.Location = new System.Drawing.Point(96, 56);
			this.priComboBox3.Name = "priComboBox3";
			this.priComboBox3.Size = new System.Drawing.Size(120, 22);
			this.priComboBox3.TabIndex = 193;
			this.priComboBox3.SelectionChangeCommitted += new System.EventHandler(this.priComboBox3_SelectionChangeCommitted);
			// 
			// priComboBox2
			// 
			this.priComboBox2.BackColor = System.Drawing.Color.White;
			this.priComboBox2.DataField = "Contact_id";
			this.priComboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.priComboBox2.Location = new System.Drawing.Point(480, 32);
			this.priComboBox2.Name = "priComboBox2";
			this.priComboBox2.Size = new System.Drawing.Size(104, 22);
			this.priComboBox2.TabIndex = 192;
			this.priComboBox2.SelectionChangeCommitted += new System.EventHandler(this.priComboBox2_SelectionChangeCommitted);
			// 
			// priComboBox1
			// 
			this.priComboBox1.BackColor = System.Drawing.Color.White;
			this.priComboBox1.DataField = "Client_id";
			this.priComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.priComboBox1.Location = new System.Drawing.Point(96, 32);
			this.priComboBox1.Name = "priComboBox1";
			this.priComboBox1.Size = new System.Drawing.Size(120, 22);
			this.priComboBox1.TabIndex = 179;
			this.priComboBox1.SelectionChangeCommitted += new System.EventHandler(this.priComboBox1_SelectionChangeCommitted);
			// 
			// label32
			// 
			this.label32.BackColor = System.Drawing.Color.Transparent;
			this.label32.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.label32.Location = new System.Drawing.Point(224, 80);
			this.label32.Name = "label32";
			this.label32.Size = new System.Drawing.Size(64, 23);
			this.label32.TabIndex = 156;
			this.label32.Text = "备注";
			this.label32.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txt15
			// 
			this.txt15.BackColor = System.Drawing.Color.White;
			this.txt15.DataField = "remark";
			this.txt15.DataType = TJSystem.Public.DataType.String;
			this.txt15.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.txt15.Location = new System.Drawing.Point(288, 80);
			this.txt15.Name = "txt15";
			this.txt15.Size = new System.Drawing.Size(480, 23);
			this.txt15.TabIndex = 157;
			this.txt15.Text = "";
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
			this.label23.Text = "货柜类型";
			this.label23.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label18
			// 
			this.label18.BackColor = System.Drawing.Color.Transparent;
			this.label18.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.label18.ForeColor = System.Drawing.Color.Blue;
			this.label18.Location = new System.Drawing.Point(416, 56);
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
			this.label19.Text = "运输商";
			this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label22
			// 
			this.label22.BackColor = System.Drawing.Color.Transparent;
			this.label22.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.label22.Location = new System.Drawing.Point(248, 56);
			this.label22.Name = "label22";
			this.label22.Size = new System.Drawing.Size(40, 23);
			this.label22.TabIndex = 122;
			this.label22.Text = "名称";
			this.label22.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txt5
			// 
			this.txt5.BackColor = System.Drawing.Color.White;
			this.txt5.DataField = "forward_name";
			this.txt5.DataType = TJSystem.Public.DataType.String;
			this.txt5.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.txt5.Location = new System.Drawing.Point(288, 56);
			this.txt5.Name = "txt5";
			this.txt5.Size = new System.Drawing.Size(128, 23);
			this.txt5.TabIndex = 125;
			this.txt5.Text = "";
			// 
			// label9
			// 
			this.label9.BackColor = System.Drawing.Color.Transparent;
			this.label9.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.label9.Location = new System.Drawing.Point(600, 32);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(40, 23);
			this.label9.TabIndex = 120;
			this.label9.Text = "姓名";
			this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txt4
			// 
			this.txt4.BackColor = System.Drawing.Color.White;
			this.txt4.DataField = "Contact_name";
			this.txt4.DataType = TJSystem.Public.DataType.String;
			this.txt4.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.txt4.Location = new System.Drawing.Point(648, 32);
			this.txt4.Name = "txt4";
			this.txt4.Size = new System.Drawing.Size(120, 23);
			this.txt4.TabIndex = 121;
			this.txt4.Text = "";
			// 
			// label5
			// 
			this.label5.BackColor = System.Drawing.Color.Transparent;
			this.label5.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.label5.ForeColor = System.Drawing.Color.Blue;
			this.label5.Location = new System.Drawing.Point(424, 8);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(56, 23);
			this.label5.TabIndex = 118;
			this.label5.Text = "币种";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label3
			// 
			this.label3.BackColor = System.Drawing.Color.Transparent;
			this.label3.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.label3.ForeColor = System.Drawing.Color.Blue;
			this.label3.Location = new System.Drawing.Point(432, 32);
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
			this.label21.Location = new System.Drawing.Point(584, 104);
			this.label21.Name = "label21";
			this.label21.Size = new System.Drawing.Size(64, 23);
			this.label21.TabIndex = 42;
			this.label21.Text = "修改时间";
			this.label21.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txt19
			// 
			this.txt19.BackColor = System.Drawing.Color.White;
			this.txt19.DataField = "modifyon";
			this.txt19.DataType = TJSystem.Public.DataType.String;
			this.txt19.Enabled = false;
			this.txt19.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.txt19.Location = new System.Drawing.Point(656, 104);
			this.txt19.Name = "txt19";
			this.txt19.Size = new System.Drawing.Size(112, 23);
			this.txt19.TabIndex = 41;
			this.txt19.Text = "";
			// 
			// label20
			// 
			this.label20.BackColor = System.Drawing.Color.Transparent;
			this.label20.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.label20.Location = new System.Drawing.Point(208, 104);
			this.label20.Name = "label20";
			this.label20.Size = new System.Drawing.Size(64, 23);
			this.label20.TabIndex = 40;
			this.label20.Text = "创建时间";
			this.label20.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txt17
			// 
			this.txt17.BackColor = System.Drawing.Color.White;
			this.txt17.DataField = "createon";
			this.txt17.DataType = TJSystem.Public.DataType.String;
			this.txt17.Enabled = false;
			this.txt17.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.txt17.Location = new System.Drawing.Point(280, 104);
			this.txt17.Name = "txt17";
			this.txt17.Size = new System.Drawing.Size(104, 23);
			this.txt17.TabIndex = 39;
			this.txt17.Text = "";
			// 
			// label17
			// 
			this.label17.BackColor = System.Drawing.Color.Transparent;
			this.label17.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.label17.Location = new System.Drawing.Point(392, 104);
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
			this.label15.Location = new System.Drawing.Point(8, 104);
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
			this.label12.Location = new System.Drawing.Point(600, 8);
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
			this.label8.Location = new System.Drawing.Point(248, 8);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(40, 23);
			this.label8.TabIndex = 22;
			this.label8.Text = "日期";
			this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.BackColor = System.Drawing.Color.Transparent;
			this.label7.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.label7.Location = new System.Drawing.Point(224, 32);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(63, 19);
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
			this.label2.Text = "流水号";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txt3
			// 
			this.txt3.BackColor = System.Drawing.Color.White;
			this.txt3.DataField = "client_name";
			this.txt3.DataType = TJSystem.Public.DataType.String;
			this.txt3.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.txt3.Location = new System.Drawing.Point(288, 32);
			this.txt3.Name = "txt3";
			this.txt3.Size = new System.Drawing.Size(128, 23);
			this.txt3.TabIndex = 104;
			this.txt3.Text = "";
			// 
			// txt16
			// 
			this.txt16.BackColor = System.Drawing.Color.White;
			this.txt16.DataField = "createBy";
			this.txt16.DataType = TJSystem.Public.DataType.String;
			this.txt16.Enabled = false;
			this.txt16.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.txt16.Location = new System.Drawing.Point(96, 104);
			this.txt16.Name = "txt16";
			this.txt16.Size = new System.Drawing.Size(104, 23);
			this.txt16.TabIndex = 12;
			this.txt16.Text = "";
			// 
			// txt18
			// 
			this.txt18.BackColor = System.Drawing.Color.White;
			this.txt18.DataField = "modifyBy";
			this.txt18.DataType = TJSystem.Public.DataType.String;
			this.txt18.Enabled = false;
			this.txt18.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.txt18.Location = new System.Drawing.Point(472, 104);
			this.txt18.Name = "txt18";
			this.txt18.Size = new System.Drawing.Size(104, 23);
			this.txt18.TabIndex = 9;
			this.txt18.Text = "";
			// 
			// txt1
			// 
			this.txt1.BackColor = System.Drawing.Color.White;
			this.txt1.DataField = "cq_code";
			this.txt1.DataType = TJSystem.Public.DataType.String;
			this.txt1.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.txt1.Location = new System.Drawing.Point(96, 8);
			this.txt1.Name = "txt1";
			this.txt1.Size = new System.Drawing.Size(120, 23);
			this.txt1.TabIndex = 100;
			this.txt1.Text = "";
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
			// email1
			// 
			this.email1.Format = "";
			this.email1.FormatInfo = null;
			this.email1.HeaderText = "电子邮件1";
			this.email1.MappingName = "email1";
			this.email1.NullText = "";
			this.email1.Width = 75;
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
			// corporation
			// 
			this.corporation.Format = "";
			this.corporation.FormatInfo = null;
			this.corporation.HeaderText = "公司法人";
			this.corporation.MappingName = "corporation";
			this.corporation.NullText = "";
			this.corporation.Width = 75;
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
			// panel3
			// 
			this.panel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel3.BackgroundImage")));
			this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.panel3.Controls.Add(this.priToolBar1);
			this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panel3.Location = new System.Drawing.Point(0, 526);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(784, 40);
			this.panel3.TabIndex = 15;
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
			// company_name_cn
			// 
			this.company_name_cn.Format = "";
			this.company_name_cn.FormatInfo = null;
			this.company_name_cn.HeaderText = "中文名称";
			this.company_name_cn.MappingName = "company_name_cn";
			this.company_name_cn.NullText = "";
			this.company_name_cn.Width = 75;
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
			this.panel1.TabIndex = 13;
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
			this.label1.Text = "报价单";
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
			// fax2
			// 
			this.fax2.Format = "";
			this.fax2.FormatInfo = null;
			this.fax2.HeaderText = "传真2";
			this.fax2.MappingName = "fax2";
			this.fax2.NullText = "";
			this.fax2.Width = 75;
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
			// postcode
			// 
			this.postcode.Format = "";
			this.postcode.FormatInfo = null;
			this.postcode.HeaderText = "邮政编码";
			this.postcode.MappingName = "postcode";
			this.postcode.NullText = "";
			this.postcode.Width = 75;
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
			// resume
			// 
			this.resume.Format = "";
			this.resume.FormatInfo = null;
			this.resume.HeaderText = "公司描述";
			this.resume.MappingName = "resume";
			this.resume.NullText = "";
			this.resume.Width = 75;
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
			// gen_manager
			// 
			this.gen_manager.Format = "";
			this.gen_manager.FormatInfo = null;
			this.gen_manager.HeaderText = "总经理";
			this.gen_manager.MappingName = "gen_manager";
			this.gen_manager.NullText = "";
			this.gen_manager.Width = 75;
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
			// linkLabel4
			// 
			this.linkLabel4.AutoSize = true;
			this.linkLabel4.BackColor = System.Drawing.Color.Transparent;
			this.linkLabel4.Location = new System.Drawing.Point(200, 136);
			this.linkLabel4.Name = "linkLabel4";
			this.linkLabel4.Size = new System.Drawing.Size(99, 19);
			this.linkLabel4.TabIndex = 217;
			this.linkLabel4.TabStop = true;
			this.linkLabel4.Text = "OFFER REQUEST";
			this.linkLabel4.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel4_LinkClicked);
			// 
			// frmSaleCQ
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(7, 16);
			this.BackColor = System.Drawing.SystemColors.ScrollBar;
			this.ClientSize = new System.Drawing.Size(784, 566);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel3);
			this.Controls.Add(this.panel1);
			this.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "frmSaleCQ";
			this.Text = "报价单";
			this.panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).EndInit();
			this.panel4.ResumeLayout(false);
			this.panel3.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

//		private void btn_addCQ_Click(object sender, System.EventArgs e)
//		{
//			if(Count < 1)
//			{
//				frmAddCQItem frmAddItem1 = new frmAddCQItem();
//				frmAddItem1.Show();
//				frmAddItem1.Left = 220;
//				frmAddItem1.Top = 290;
//				Count += 1;
//			}
//		}



//		private void dataGrid1_Click(object sender, System.EventArgs e)
//		{
//			System.Text.StringBuilder sb = new System.Text.StringBuilder();
//			sb.Append("select cq_code,seq_no,ce_code,ce_seqno,item_code,client_itemcode,item_name,item_name_cn,item_desc,item_desc_cn,minorder,item_Qty,unit,");
//			sb.Append("unit_price,deliveryDate,remark,pack_qty,OutsiePackType,quoterate,deliveryDays ");
//			sb.Append("from sale_cq_deatil ");
//			sb.Append("where cq_code = '"+ this.dataGrid1[this.dataGrid1.CurrentCell.RowNumber,0] +"'");
//			sb.Append("order by cq_code");
//			this.InitialGrid1(sb.ToString());
//		}

		protected override void OnClosing(CancelEventArgs e)
		{			
//			if(MessageBox.Show("确定退出？（Y/N）","确认",MessageBoxButtons.YesNo,MessageBoxIcon.Information) == System.Windows.Forms.DialogResult.No)
//			{
//				e.Cancel = true;
//			}
//			else
			{
				TJSystem.Public.PublicStatic.formClose = true;
				TJSystem.Public.PublicStatic.formName = "报价单";
			}
			base.OnClosing (e);
		}

		private void linkLabel1_LinkClicked(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
		{
//			if(Count< 1)
			{
				if (this.txt1.Text.ToString().Trim() == "" )
				{
					TJSystem.Public.PublicStatic.ShowMessage(TJSystem.Public.MessageType.Exclamation,"请选择一张报价单单号");
					return;
				}
				else
				{
					frmCQDetail frmCQ = new frmCQDetail(this.txt1.Text.ToString().Trim());
					frmCQ.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
					frmCQ.ShowDialog();
//					frmCQ.Left = 220;
//					frmCQ.Top = 290;
#if false
					this.txt14.Text = TJSystem.Public.PublicStatic.AmountTotal.ToString();
#endif
					Count += 1;
				}			
				
			}
		}

		private void priComboBox1_SelectionChangeCommitted(object sender, System.EventArgs e)
		{
			string sql = "select  a.client_name as client_name, b.contact_id, b.contact_id +' '+b.contact_name as contact_name  from basic_client a join basic_client_contact b on a.client_id = b.client_id and a.client_id = '"+ this.priComboBox1.SelectedValue +"'";
			DataTable dt = TJSystem.Public.PublicStatic.db.GetDataTable(sql);
			DataTable dtcpy = null;
			DataRow dr = null;
			dr = dt.NewRow();
			dr[0] = "";
			dr[1] = "";
			dt.Rows.InsertAt(dr,0);
			dtcpy = dt.Copy();
			this.priComboBox2.DataSource = dtcpy.DefaultView;
			this.priComboBox2.ValueMember = "contact_id";
			this.priComboBox2.DisplayMember = "contact_name";
			
			sql = "select client_name from basic_client where client_id = '"+ this.priComboBox1.SelectedValue +"'";
			dt = TJSystem.Public.PublicStatic.db.GetDataTable(sql);
			if(dt.Rows.Count == 1)
				this.txt3.Text = dt.Rows[0]["client_name"].ToString();
			else
				this.txt3.Text = "";
		}

		private void priComboBox2_SelectionChangeCommitted(object sender, System.EventArgs e)
		{
			string sql = "select contact_name from basic_client_contact where contact_id = '"+ this.priComboBox2.SelectedValue +"'";
			DataTable dt = TJSystem.Public.PublicStatic.db.GetDataTable(sql);
			
			if(dt.Rows.Count == 1)
				this.txt4.Text = dt.Rows[0]["contact_name"].ToString();
			else
				this.txt4.Text = "";
		}

		private void priComboBox3_SelectionChangeCommitted(object sender, System.EventArgs e)
		{
			string sql = "select forwarder_name from basic_forwarder where forwarder_id = '"+ this.priComboBox3.SelectedValue +"'";
			DataTable dt = TJSystem.Public.PublicStatic.db.GetDataTable(sql);
			if(dt.Rows.Count == 1)
				this.txt5.Text = dt.Rows[0]["forwarder_name"].ToString();
			else
				this.txt5.Text = "";
		}

		private void priComboBox4_SelectionChangeCommitted(object sender, System.EventArgs e)
		{
			string sql = "select Term_namecn from p_priceTerm where term_code = '"+ this.priComboBox4.SelectedValue +"'";
			DataTable dt = TJSystem.Public.PublicStatic.db.GetDataTable(sql);
			if(dt.Rows.Count == 1)
				this.txt6.Text = dt.Rows[0]["Term_namecn"].ToString();
			else
				this.txt6.Text = "";
		}

		private void linkLabel2_LinkClicked(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
		{
			string strsol = null;
			if(this.txt1.Text.Trim().Equals(""))
			{
				TJSystem.Public.PublicStatic.ShowMessage(TJSystem.Public.MessageType.Exclamation,"请选择要打印的报价单号！");
				return;
			}
			strsol = txt1.Text.Trim();
						
			TJSystem.Classes.common.DocParamCommon dpcom = new TJSystem.Classes.common.DocParamCommon();
			dpcom.DocSaleNO = this.txt1.Text.Trim();
						
			TJSystem.CrystalRPT.frmReport frm = new TJSystem.CrystalRPT.frmReport("OFFER SHEET",dpcom,this.dataGrid1);
			frm.ShowDialog();
		}

		private void dataGrid1_Navigate(object sender, System.Windows.Forms.NavigateEventArgs ne)
		{
		
		}

		private void linkLabel3_LinkClicked(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
		{
			string strsol = null;
			if(this.txt1.Text.Trim().Equals(""))
			{
				TJSystem.Public.PublicStatic.ShowMessage(TJSystem.Public.MessageType.Exclamation,"请选择要打印的报价单号！");
				return;
			}
			strsol = txt1.Text.Trim();
						
			TJSystem.Classes.common.DocParamCommon dpcom = new TJSystem.Classes.common.DocParamCommon();
			dpcom.DocSaleNO = this.txt1.Text.Trim();
						
			TJSystem.CrystalRPT.frmReport frm = new TJSystem.CrystalRPT.frmReport("QUOTATION",dpcom,this.dataGrid1);
			frm.ShowDialog();
		}

		private string getColumnChar(int Number)
		{
			short shSrc = Convert.ToInt16(Convert.ToString(Number)) ;
			char chSrc = 'A' ;
			string strPri = "";
			string strExt = "";
			string strDest = null;
			if(shSrc > 26)
			{
				if(shSrc/26 > 8)
				{
					strDest = "系统不支持" + Number.ToString() + "个栏位的Excel表格汇出！";
					return strDest ;
				}
				strPri = NumToStr(Convert.ToInt16(Convert.ToString(shSrc/Convert.ToInt16(Convert.ToString(26)))));
			}
			if(shSrc%26 == 0)
			{
				strExt = "Z";
			}
			else
			{
				strExt = NumToStr(Convert.ToInt16(Convert.ToString(shSrc%Convert.ToInt16(Convert.ToString(26)))));
			}

			strDest = strPri + strExt ;
			return strDest ;

		}

		private string NumToStr(short Number)
		{
			char chSrc = 'A';
			
			short shDest = Convert.ToInt16(Convert.ToString((short)chSrc + Number - Convert.ToInt16(Convert.ToString(1))));

			char chDest = (char)shDest ;

			string strDest = chDest.ToString();
			return strDest;
		}

		private void linkLabel4_LinkClicked(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
		{
			System.Data.DataTable dt = null;
			System.Text.StringBuilder sb = new System.Text.StringBuilder();
			string cq_code = null;
			if(this.txt1.Text.Trim().Equals(""))
			{
				TJSystem.Public.PublicStatic.ShowMessage(TJSystem.Public.MessageType.Exclamation,"请选择要打印的报价单号！");
				return;
			}
			cq_code = txt1.Text.Trim();
			System.Windows.Forms.MessageBox.Show("货品图片保存路径在C:\\ItemPic\\","Infomation",MessageBoxButtons.OK,MessageBoxIcon.Information);

//			PublicStatic.UC.frmKeyWord frm = new PublicStatic.UC.frmKeyWord();
//			frm.ShowDialog();
			
			sb.Remove(0,sb.Length);
			sb.Append("select ");
//			sb.Append(" ' ' as 'Picture of the product',");
			sb.Append(" c.picture as 'Picture of the product',");
			sb.Append(" b.item_code as 'Item number',b.item_name as 'Name of the product',b.item_desc as 'Description of the product',");
			sb.Append(" ltrim(str(b.insidepack,20,0))+' '+d.unit_name+' into '+f.pack_name as 'Packing details (type, pcs/ctn)',");
			sb.Append(" ltrim(str(b.length,20,2))+'*'+ltrim(str(b.width,20,2))+'*'+ltrim(str(b.height,20,2))+'cm' as 'Measure of the ctn', ");
			sb.Append(" ltrim(str(b.minorder,20,0)) as 'Minimal Order Quantity (MOQ) (pcs)',");
			sb.Append(" ltrim(str(b.grossweight,20,2)) as 'G.W. kgs',");
			sb.Append(" ltrim(str(b.netweight,20,2)) as 'N.W. kgs', ");
			sb.Append(" b.packrate20 as 'QTY / 20 (pcs)',");
			sb.Append(" b.packrate40 as 'QTY / 40HQ (pcs)',");
			sb.Append(" a.unit_price as 'FOB: PRICE RMB/PC(含17%税)',");
			sb.Append(" e.cq_date as 'Delivery date',");
			sb.Append(" ' ' as 'CE certificate',");
			sb.Append(" ' ' as 'ROHS',");
			sb.Append(" 'KL-EXPORTING CO.,LTD.' as 'Company',");
			sb.Append(" 'Leon' as 'Contact person',");
			sb.Append(" 'TEL:0086-25-86425205;FAX:0086-25-84868727' as 'Contact data (tel, fax, e-mail, website):'");
			sb.Append(" from sale_cq_deatil a ");
			sb.Append(" left join basic_item b on a.item_code=b.item_code ");
			sb.Append(" left join p_packtype f on b.insidepacktype=f.pack_code");
			sb.Append(" left join basic_item_image c on c.item_code=b.item_code and c.seq_no='100' ");
			sb.Append(" left join p_unit d on b.unit=d.unit_id");
			sb.Append(" left join sale_cq_master e on a.cq_code=e.cq_code ");
			sb.Append(" where a.cq_code=");
			sb.Append("'");
			sb.Append(cq_code);
			sb.Append("'");
			sb.Append(" order by a.item_code desc");

			dt = TJSystem.Public.PublicStatic.db.GetDataTable(sb.ToString());
			try
			{
				object	missing = System.Reflection.Missing.Value;
				Excel.Application myExcel = new Excel.ApplicationClass();
				if(null == myExcel)
				{
					MessageBox.Show("Excel can't be started!","Excel Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
					return;
				}

				myExcel.Visible = true ;

				Excel.Workbooks workBooks = myExcel.Workbooks;
				Excel._Workbook _workBook = workBooks.Add(Excel.XlWBATemplate.xlWBATWorksheet);
				Excel.Sheets workSheets = _workBook.Worksheets;
				Excel._Worksheet _workSheet = (Excel._Worksheet)workSheets.get_Item(1);
				if(null == _workSheet)
				{
					MessageBox.Show("Excel Sheet can't be created!","Sheet Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
					return;
				}

				Excel.Range range1 = null;

				string nCells = "QUOTATION LIST";
				Object[] args1 = new Object[1];
				args1[0] = nCells;

				range1 = _workSheet.get_Range("A1:" + getColumnChar(dt.Columns.Count) + "1",System.Reflection.Missing.Value);
				range1.Select();

				range1.Font.Size = 20;
				range1.Font.Bold = true;
				range1.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
				range1.VerticalAlignment   = Excel.XlVAlign.xlVAlignCenter;
				range1.RowHeight = 39;
				range1.WrapText = true;
				range1.Orientation = 0;
				range1.AddIndent = false;
				range1.ShrinkToFit = false;
				range1.MergeCells  = false;
				range1.Merge(Type.Missing);
//				range1.Interior.ColorIndex = 17;
				range1.Font.Name = "Arial";

				range1.GetType().InvokeMember("Value",System.Reflection.BindingFlags.SetProperty,null,range1,args1);
				range1.BorderAround(Excel.XlLineStyle.xlContinuous,Excel.XlBorderWeight.xlThin,Excel.XlColorIndex.xlColorIndexAutomatic,null);
			
			
				for(int j = 0; j < dt.Columns.Count; j ++)
				{
					string str = null;
					str = getColumnChar(j+1) ;
				
					args1[0] = dt.Columns[j].ColumnName;//this._dg.TableStyles[0].GridColumnStyles[j].HeaderText;
				
					range1 = _workSheet.get_Range(str+Convert.ToString(2),System.Reflection.Missing.Value);
					range1.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
					range1.VerticalAlignment   = Excel.XlVAlign.xlVAlignCenter;
					range1.Font.Size = 8;
					range1.RowHeight = 56;
					range1.WrapText = true;
					range1.Font.Bold = true;
					range1.ShrinkToFit = false;
					range1.ColumnWidth = 7;
					range1.Font.Name = "Arial";
					if (j == 0 || j == 1 || j == 2 || j == 3 || j == 17)
					{
						range1.ColumnWidth = 20;
					}
					if (j == 11)
					{
//						range1.Interior.ColorIndex = 3;
						range1.Font.ColorIndex = 3;
					}
//					range1.Font.ColorIndex = Convert.ToInt16(TJSystem.Public.PublicStatic.SearchKey);

					range1.GetType().InvokeMember("Value",System.Reflection.BindingFlags.SetProperty,null,range1,args1);
					range1.BorderAround(Excel.XlLineStyle.xlContinuous,Excel.XlBorderWeight.xlThin,Excel.XlColorIndex.xlColorIndexAutomatic,null);
				}
			
				for(int i=0; i < dt.Rows.Count ; i ++)
				{
					string str = null;
				

					for(int j = 0; j < dt.Columns.Count; j ++)
					{
						str = getColumnChar(j+1) ;
						if (j == 0)
						{
							System.IO.MemoryStream ms=new System.IO.MemoryStream((byte[])dt.Rows[i][j]); 
							Image image = Image.FromStream(ms,true); 
							this.image = image;
							
							if (!System.IO.Directory.Exists("C:\\ItemPic"))
							{
								System.IO.Directory.CreateDirectory("C:\\ItemPic");
							}
							image.Save("C:\\ItemPic\\" + dt.Rows[i][j+1].ToString() + ".jpg");
							/*
							System.Threading.Thread thread = new System.Threading.Thread(new System.Threading.ThreadStart(this.SaveImage));
							thread.Start();
							Excel.Pictures pics = (Excel.Pictures)_workSheet.Pictures(System.Reflection.Missing.Value);
							while(true)
							{
								if (System.IO.File.Exists(@"C:\tmp.jpg"))
								{
									break;
								}
							}							
							pics.Insert(@"C:\tmp", System.Reflection.Missing.Value);	
							*/
							args1[0] = "";
							
							range1 = _workSheet.get_Range(str+Convert.ToString(i+3),System.Reflection.Missing.Value);
							range1.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
							range1.VerticalAlignment   = Excel.XlVAlign.xlVAlignCenter;
							range1.RowHeight = 70;

							range1.GetType().InvokeMember("Value",System.Reflection.BindingFlags.SetProperty,null,range1,args1);
							range1.BorderAround(Excel.XlLineStyle.xlContinuous,Excel.XlBorderWeight.xlThin,Excel.XlColorIndex.xlColorIndexAutomatic,null);
							continue;
						}
					
						args1[0] = dt.Rows[i][j].ToString();
						range1 = _workSheet.get_Range(str+Convert.ToString(i+3),System.Reflection.Missing.Value);
						range1.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
						range1.VerticalAlignment   = Excel.XlVAlign.xlVAlignCenter;
						range1.RowHeight = 70;
						range1.WrapText = true;
						range1.Font.Name = "Arial";

						range1.GetType().InvokeMember("Value",System.Reflection.BindingFlags.SetProperty,null,range1,args1);
						range1.BorderAround(Excel.XlLineStyle.xlContinuous,Excel.XlBorderWeight.xlThin,Excel.XlColorIndex.xlColorIndexAutomatic,null);
					}
				}
			}
			catch(System.Runtime.InteropServices.COMException ex)
			{
				MessageBox.Show("数据汇出失败 - " + ex.Message,"Error",System.Windows.Forms.MessageBoxButtons.OK,System.Windows.Forms.MessageBoxIcon.Error);
			}
			catch(System.Reflection.TargetInvocationException ex)
			{
				MessageBox.Show("数据汇出失败 - " + ex.Message,"Error",System.Windows.Forms.MessageBoxButtons.OK,System.Windows.Forms.MessageBoxIcon.Error);
			}
		}

		private void SaveImage()
		{
			if (this.image != null)
			{
				image.Save(@"C:\tmp.jpg");
			}
		}
	}
}

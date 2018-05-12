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
	public class frmSaleSS : System.Windows.Forms.Form
	{
		
		
		/// <summary>
		/// 必需的设计器变量。
		/// </summary>
		private System.ComponentModel.Container components = null;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.DataGridTextBoxColumn tel2;
		private System.Windows.Forms.DataGridTextBoxColumn website;
		private System.Windows.Forms.DataGridTextBoxColumn fax2;
		private System.Windows.Forms.DataGridTextBoxColumn email2;
		private System.Windows.Forms.DataGridTextBoxColumn address_cn;
		private System.Windows.Forms.DataGridTextBoxColumn fax1;
		private System.Windows.Forms.DataGridTextBoxColumn company_name;
		private System.Windows.Forms.DataGridTextBoxColumn company_name_cn;
		private System.Windows.Forms.DataGridTextBoxColumn corporation;
		private System.Windows.Forms.DataGridTextBoxColumn company_id;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Panel panel4;
		private System.Windows.Forms.Label label28;
		private System.Windows.Forms.Label label29;
		private System.Windows.Forms.Label label18;
		private System.Windows.Forms.Label label19;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label21;
		private System.Windows.Forms.Label label20;
		private System.Windows.Forms.Label label17;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label2;
		private TJSystem.Classes.PriTextBox txt1;
		private System.Windows.Forms.DataGridTextBoxColumn address;
		private System.Windows.Forms.DataGridTextBoxColumn resume;
		private System.Windows.Forms.DataGridTextBoxColumn email1;
		private System.Windows.Forms.DataGridTextBoxColumn tel1;
		private System.Windows.Forms.DataGridTextBoxColumn postcode;
		private System.Windows.Forms.DataGridTextBoxColumn gen_manager;
		private System.Windows.Forms.Panel panel3;
		private TJSystem.UC.PriToolBar priToolBar1;
		private System.Windows.Forms.Label label6;
		public static System.Windows.Forms.Form frmCurrent = null ;
		private System.Windows.Forms.Label label1;
		private TJSystem.Classes.PriComboBox priComboBox1;
		private TJSystem.Classes.PriComboBox priComboBox2;
		private TJSystem.Classes.PriComboBox priComboBox3;
		private TJSystem.Classes.PriComboBox priComboBox4;
		private TJSystem.Classes.PriTextBox txt8;
		private TJSystem.Classes.PriTextBox txt7;
		private TJSystem.Classes.PriTextBox txt4;
		private TJSystem.Classes.PriTextBox txt10;
		private TJSystem.Classes.PriTextBox txt6;
		private TJSystem.Classes.PriTextBox txt3;
		private TJSystem.Classes.PriTextBox txt5;
		private TJSystem.Classes.PriTextBox txt9;
		private TJSystem.Classes.PriComboBox priComboBox5;
		public string _PK;
        private string _table = null;
		private string _statusType = null;
		private System.Windows.Forms.LinkLabel linkLabel1;
		private System.Windows.Forms.DataGrid dataGrid1;
		private System.Windows.Forms.DataGridTableStyle dataGridTableStyle1;
		private System.Windows.Forms.DataGridTextBoxColumn ss_code;
		private System.Windows.Forms.DataGridTextBoxColumn ss_date;
		private System.Windows.Forms.DataGridTextBoxColumn client_id;
		private System.Windows.Forms.DataGridTextBoxColumn client_name;
		private System.Windows.Forms.DataGridTextBoxColumn contact_id;
		private System.Windows.Forms.DataGridTextBoxColumn contact_name;
		private System.Windows.Forms.DataGridTextBoxColumn createby;
		private System.Windows.Forms.DataGridTextBoxColumn createon;
		private System.Windows.Forms.DataGridTextBoxColumn modifyby;
		private System.Windows.Forms.DataGridTextBoxColumn modifyon;
		private System.Windows.Forms.DataGridTextBoxColumn approvedby;
		private System.Windows.Forms.DataGridTextBoxColumn approvedon;
		private TJSystem.Classes.PriDateTimePicker priDateTimePicker3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.DataGridTextBoxColumn status_name;
		private System.Windows.Forms.DataGridTextBoxColumn currency_namecn;
		private System.Windows.Forms.DataGridTextBoxColumn wh_name;
		public static int Count = 0;

		private string _PKSubValue = null;

		public frmSaleSS()
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
			sb.Append("select a.ss_code,a.ss_date,a.status,b.status_name as status_name,a.client_id,a.client_name,a.contact_id,a.contact_name,a.Currency,c.Currency_namecn as Currency_namecn,a.wh_code,d.wh_name,");
			sb.Append("a.createby,a.createon,a.modifyby,a.modifyon,a.approvedby,a.approvedon ");
			sb.Append("from sale_ss_master a");
			sb.Append(" left join p_status b");
			sb.Append(" on a.status = b.status_id and b.status_type = '"+_statusType+"'");
			sb.Append(" left join p_currency c");
			sb.Append(" on a.Currency = c.Currency_code");
			sb.Append(" left join basic_whouse d on d.wh_code=a.wh_code");
			sb.Append(" order by ss_code");
			this.InitialGrid(sb.ToString());

			priToolBar1.setCurrentForm = this;
			_PK = "ss_code";
            _table = "sale_ss_master";
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
			//客户
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

			//币种
			sql = "select Currency_Code,Currency_Code+' '+Currency_nameCn as Currency_nameCn from p_Currency order by Currency_Code";
			dt = TJSystem.Public.PublicStatic.db.GetDataTable(sql);
			dr = dt.NewRow() ;
			dr[0] = "" ;
			dr[1] = "" ;
			dt.Rows.InsertAt(dr,0) ;
			dtcpy = dt.Copy();
			this.priComboBox4.DataSource = dtcpy.DefaultView;
			this.priComboBox4.ValueMember = "Currency_Code";
			this.priComboBox4.DisplayMember = "Currency_nameCn";

			//仓库
			sql = "select wh_code,wh_code+' '+wh_name as wh_name from basic_whouse order by wh_code";
			dt = TJSystem.Public.PublicStatic.db.GetDataTable(sql);
			dr = dt.NewRow() ;
			dr[0] = "" ;
			dr[1] = "" ;
			dt.Rows.InsertAt(dr,0) ;
			dtcpy = dt.Copy();
			this.priComboBox5.DataSource = dtcpy.DefaultView;
			this.priComboBox5.ValueMember = "wh_code";
			this.priComboBox5.DisplayMember = "wh_name";

			sql = "select  a.client_name as client_name, b.contact_id, b.contact_id +' '+b.contact_name as contact_name  from basic_client a join basic_client_contact b on a.client_id = b.client_id ";
			dt = TJSystem.Public.PublicStatic.db.GetDataTable(sql);			
			dr = dt.NewRow();
			dr[0] = "";
			dr[1] = "";
			dr[2] = "";
			dt.Rows.InsertAt(dr,0);
			dtcpy = dt.Copy();
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
                    MessageBox.Show("请输入退货单号","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    return false;
                }

                if(TJSystem.Public.PublicStatic.IsExsist(this._table,this._PK,this.priToolBar1))
                {
                    MessageBox.Show("这张退货单已经存在,请另外开立","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    return false;
                }
            }

            if(this.priComboBox1.SelectedValue == null)
            {
                TJSystem.Public.PublicStatic.ShowMessage(TJSystem.Public.MessageType.Exclamation,"必须选择退货单状态！");
                return false;
            }
            if(this.priComboBox2.SelectedValue == null)
            {
                TJSystem.Public.PublicStatic.ShowMessage(TJSystem.Public.MessageType.Exclamation,"必须选择客户代码！");
                return false;
            }
            if(this.priComboBox3.SelectedValue == null)
            {
                TJSystem.Public.PublicStatic.ShowMessage(TJSystem.Public.MessageType.Exclamation,"必须选择联系人！");
                return false;
            }
            if(this.priComboBox5.SelectedValue == null)
            {
                TJSystem.Public.PublicStatic.ShowMessage(TJSystem.Public.MessageType.Exclamation,"必须选择仓库！");
                return false;
            }	

			if(sqltype.Equals("insert"))
			{
				/*
				int ret = 0;
				PublicStatic.Classes.common.CommonSubTableHandle csth = new PublicStatic.Classes.common.CommonSubTableHandle();
				csth.TableName = "sale_ss_detail";
				csth.PrimaryKeyField = "ss_code";
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
			this.txt7.Enabled = false;
			this.txt8.Enabled = false;
			this.txt9.Enabled = false;
			this.txt10.Enabled = false;
			this.priComboBox1.Enabled = false;
			this.priComboBox2.Enabled = false;
			this.priComboBox3.Enabled = false;
			this.priComboBox4.Enabled = false;
			this.priComboBox5.Enabled = false;
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
			
				this.priComboBox1.Enabled = false;
				this.priComboBox2.Enabled = true;
				this.priComboBox4.Enabled = true;
				this.priComboBox5.Enabled = true;

				this.txt1.Text = "";
				this.priDateTimePicker3.Value = System.DateTime.Now;
				this.txt3.Text = "";
				this.txt4.Text = "";
				this.txt5.Text = "";
				this.txt6.Text = "";
				this.txt7.Text = "";
				this.txt8.Text = "";
				this.txt9.Text = "";
				this.txt10.Text = "";
				
				this.priComboBox1.SelectedValue = "1";
				this.priComboBox2.Text = "";
				this.priComboBox3.Text = "";
				this.priComboBox4.Text = "";
				this.priComboBox5.Text = "";
			}
			else if(ButtonType.Equals("update"))
			{
				this.txt1.Enabled = false;
				this.priDateTimePicker3.Enabled = true;
				this.priComboBox1.Enabled = false;
				this.priComboBox2.Enabled = true;
				this.priComboBox4.Enabled = true;
				this.priComboBox5.Enabled = true;

			}
			this.priToolBar1.SetStatusEnable(this.priComboBox1);
		}

		private void InitialGrid(string sql)
		{		
			DataTable dt = TJSystem.Public.PublicStatic.db.GetDataTable(sql);
			dt.TableName = "sale_ss_master";
			this.dataGrid1.DataSource = dt.DefaultView;
		}

//		private void InitialGrid1(string sql)
//		{		
//			DataTable dt = TJSystem.Public.PublicStatic.db.GetDataTable(sql);
//			dt.TableName = "sale_ss_detail";
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(frmSaleSS));
			this.panel1 = new System.Windows.Forms.Panel();
			this.label1 = new System.Windows.Forms.Label();
			this.tel2 = new System.Windows.Forms.DataGridTextBoxColumn();
			this.website = new System.Windows.Forms.DataGridTextBoxColumn();
			this.fax2 = new System.Windows.Forms.DataGridTextBoxColumn();
			this.email2 = new System.Windows.Forms.DataGridTextBoxColumn();
			this.address_cn = new System.Windows.Forms.DataGridTextBoxColumn();
			this.fax1 = new System.Windows.Forms.DataGridTextBoxColumn();
			this.company_name = new System.Windows.Forms.DataGridTextBoxColumn();
			this.company_name_cn = new System.Windows.Forms.DataGridTextBoxColumn();
			this.corporation = new System.Windows.Forms.DataGridTextBoxColumn();
			this.company_id = new System.Windows.Forms.DataGridTextBoxColumn();
			this.panel2 = new System.Windows.Forms.Panel();
			this.panel4 = new System.Windows.Forms.Panel();
			this.priDateTimePicker3 = new TJSystem.Classes.PriDateTimePicker();
			this.linkLabel1 = new System.Windows.Forms.LinkLabel();
			this.priComboBox5 = new TJSystem.Classes.PriComboBox();
			this.priComboBox4 = new TJSystem.Classes.PriComboBox();
			this.priComboBox3 = new TJSystem.Classes.PriComboBox();
			this.priComboBox2 = new TJSystem.Classes.PriComboBox();
			this.priComboBox1 = new TJSystem.Classes.PriComboBox();
			this.label6 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label28 = new System.Windows.Forms.Label();
			this.txt8 = new TJSystem.Classes.PriTextBox();
			this.label29 = new System.Windows.Forms.Label();
			this.txt7 = new TJSystem.Classes.PriTextBox();
			this.label18 = new System.Windows.Forms.Label();
			this.txt4 = new TJSystem.Classes.PriTextBox();
			this.label19 = new System.Windows.Forms.Label();
			this.label21 = new System.Windows.Forms.Label();
			this.txt10 = new TJSystem.Classes.PriTextBox();
			this.label20 = new System.Windows.Forms.Label();
			this.txt6 = new TJSystem.Classes.PriTextBox();
			this.label17 = new System.Windows.Forms.Label();
			this.label15 = new System.Windows.Forms.Label();
			this.label12 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.txt3 = new TJSystem.Classes.PriTextBox();
			this.txt5 = new TJSystem.Classes.PriTextBox();
			this.txt9 = new TJSystem.Classes.PriTextBox();
			this.txt1 = new TJSystem.Classes.PriTextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.dataGrid1 = new System.Windows.Forms.DataGrid();
			this.dataGridTableStyle1 = new System.Windows.Forms.DataGridTableStyle();
			this.ss_code = new System.Windows.Forms.DataGridTextBoxColumn();
			this.ss_date = new System.Windows.Forms.DataGridTextBoxColumn();
			this.status_name = new System.Windows.Forms.DataGridTextBoxColumn();
			this.client_id = new System.Windows.Forms.DataGridTextBoxColumn();
			this.client_name = new System.Windows.Forms.DataGridTextBoxColumn();
			this.contact_id = new System.Windows.Forms.DataGridTextBoxColumn();
			this.contact_name = new System.Windows.Forms.DataGridTextBoxColumn();
			this.currency_namecn = new System.Windows.Forms.DataGridTextBoxColumn();
			this.wh_name = new System.Windows.Forms.DataGridTextBoxColumn();
			this.createby = new System.Windows.Forms.DataGridTextBoxColumn();
			this.createon = new System.Windows.Forms.DataGridTextBoxColumn();
			this.modifyby = new System.Windows.Forms.DataGridTextBoxColumn();
			this.modifyon = new System.Windows.Forms.DataGridTextBoxColumn();
			this.approvedby = new System.Windows.Forms.DataGridTextBoxColumn();
			this.approvedon = new System.Windows.Forms.DataGridTextBoxColumn();
			this.address = new System.Windows.Forms.DataGridTextBoxColumn();
			this.resume = new System.Windows.Forms.DataGridTextBoxColumn();
			this.email1 = new System.Windows.Forms.DataGridTextBoxColumn();
			this.tel1 = new System.Windows.Forms.DataGridTextBoxColumn();
			this.postcode = new System.Windows.Forms.DataGridTextBoxColumn();
			this.gen_manager = new System.Windows.Forms.DataGridTextBoxColumn();
			this.panel3 = new System.Windows.Forms.Panel();
			this.priToolBar1 = new TJSystem.UC.PriToolBar();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			this.panel4.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).BeginInit();
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
			this.panel1.Size = new System.Drawing.Size(768, 56);
			this.panel1.TabIndex = 19;
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label1.Font = new System.Drawing.Font("宋体", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.label1.Location = new System.Drawing.Point(0, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(764, 52);
			this.label1.TabIndex = 0;
			this.label1.Text = "销售退貨";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
			// fax1
			// 
			this.fax1.Format = "";
			this.fax1.FormatInfo = null;
			this.fax1.HeaderText = "传真1";
			this.fax1.MappingName = "fax1";
			this.fax1.NullText = "";
			this.fax1.Width = 75;
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
			this.panel2.Controls.Add(this.panel4);
			this.panel2.Controls.Add(this.dataGrid1);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel2.Location = new System.Drawing.Point(0, 0);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(768, 534);
			this.panel2.TabIndex = 20;
			// 
			// panel4
			// 
			this.panel4.BackColor = System.Drawing.SystemColors.ScrollBar;
			this.panel4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel4.BackgroundImage")));
			this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.panel4.Controls.Add(this.priDateTimePicker3);
			this.panel4.Controls.Add(this.linkLabel1);
			this.panel4.Controls.Add(this.priComboBox5);
			this.panel4.Controls.Add(this.priComboBox4);
			this.panel4.Controls.Add(this.priComboBox3);
			this.panel4.Controls.Add(this.priComboBox2);
			this.panel4.Controls.Add(this.priComboBox1);
			this.panel4.Controls.Add(this.label6);
			this.panel4.Controls.Add(this.label3);
			this.panel4.Controls.Add(this.label28);
			this.panel4.Controls.Add(this.txt8);
			this.panel4.Controls.Add(this.label29);
			this.panel4.Controls.Add(this.txt7);
			this.panel4.Controls.Add(this.label18);
			this.panel4.Controls.Add(this.txt4);
			this.panel4.Controls.Add(this.label19);
			this.panel4.Controls.Add(this.label21);
			this.panel4.Controls.Add(this.txt10);
			this.panel4.Controls.Add(this.label20);
			this.panel4.Controls.Add(this.txt6);
			this.panel4.Controls.Add(this.label17);
			this.panel4.Controls.Add(this.label15);
			this.panel4.Controls.Add(this.label12);
			this.panel4.Controls.Add(this.label11);
			this.panel4.Controls.Add(this.label8);
			this.panel4.Controls.Add(this.label2);
			this.panel4.Controls.Add(this.txt3);
			this.panel4.Controls.Add(this.txt5);
			this.panel4.Controls.Add(this.txt9);
			this.panel4.Controls.Add(this.txt1);
			this.panel4.Controls.Add(this.label4);
			this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel4.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.panel4.Location = new System.Drawing.Point(0, 0);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(764, 248);
			this.panel4.TabIndex = 0;
			// 
			// priDateTimePicker3
			// 
			this.priDateTimePicker3.CustomFormat = "yyyy-MM-dd";
			this.priDateTimePicker3.DataField = "ss_date";
			this.priDateTimePicker3.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.priDateTimePicker3.Location = new System.Drawing.Point(320, 64);
			this.priDateTimePicker3.Name = "priDateTimePicker3";
			this.priDateTimePicker3.Size = new System.Drawing.Size(168, 23);
			this.priDateTimePicker3.TabIndex = 214;
			// 
			// linkLabel1
			// 
			this.linkLabel1.AutoSize = true;
			this.linkLabel1.BackColor = System.Drawing.Color.Transparent;
			this.linkLabel1.Location = new System.Drawing.Point(32, 224);
			this.linkLabel1.Name = "linkLabel1";
			this.linkLabel1.Size = new System.Drawing.Size(63, 19);
			this.linkLabel1.TabIndex = 197;
			this.linkLabel1.TabStop = true;
			this.linkLabel1.Text = "退货明细";
			this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
			// 
			// priComboBox5
			// 
			this.priComboBox5.BackColor = System.Drawing.Color.White;
			this.priComboBox5.DataField = "wh_code";
			this.priComboBox5.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.priComboBox5.Location = new System.Drawing.Point(96, 136);
			this.priComboBox5.Name = "priComboBox5";
			this.priComboBox5.Size = new System.Drawing.Size(144, 22);
			this.priComboBox5.TabIndex = 196;
			// 
			// priComboBox4
			// 
			this.priComboBox4.BackColor = System.Drawing.Color.White;
			this.priComboBox4.DataField = "Currency";
			this.priComboBox4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.priComboBox4.Location = new System.Drawing.Point(536, 112);
			this.priComboBox4.Name = "priComboBox4";
			this.priComboBox4.Size = new System.Drawing.Size(144, 22);
			this.priComboBox4.TabIndex = 194;
			// 
			// priComboBox3
			// 
			this.priComboBox3.BackColor = System.Drawing.Color.White;
			this.priComboBox3.DataField = "Contact_id";
			this.priComboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.priComboBox3.Location = new System.Drawing.Point(96, 112);
			this.priComboBox3.Name = "priComboBox3";
			this.priComboBox3.Size = new System.Drawing.Size(144, 22);
			this.priComboBox3.TabIndex = 193;
			this.priComboBox3.SelectionChangeCommitted += new System.EventHandler(this.priComboBox3_SelectionChangeCommitted);
			// 
			// priComboBox2
			// 
			this.priComboBox2.BackColor = System.Drawing.Color.White;
			this.priComboBox2.DataField = "Client_id";
			this.priComboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.priComboBox2.Location = new System.Drawing.Point(96, 88);
			this.priComboBox2.Name = "priComboBox2";
			this.priComboBox2.Size = new System.Drawing.Size(144, 22);
			this.priComboBox2.TabIndex = 184;
			this.priComboBox2.SelectionChangeCommitted += new System.EventHandler(this.priComboBox2_SelectionChangeCommitted);
			// 
			// priComboBox1
			// 
			this.priComboBox1.BackColor = System.Drawing.Color.White;
			this.priComboBox1.DataField = "status";
			this.priComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.priComboBox1.Location = new System.Drawing.Point(536, 64);
			this.priComboBox1.Name = "priComboBox1";
			this.priComboBox1.Size = new System.Drawing.Size(144, 22);
			this.priComboBox1.TabIndex = 183;
			this.priComboBox1.SelectionChangeCommitted += new System.EventHandler(this.priComboBox1_SelectionChangeCommitted);
			// 
			// label6
			// 
			this.label6.BackColor = System.Drawing.Color.Transparent;
			this.label6.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.label6.ForeColor = System.Drawing.Color.Blue;
			this.label6.Location = new System.Drawing.Point(40, 136);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(40, 23);
			this.label6.TabIndex = 180;
			this.label6.Text = "仓库";
			this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label3
			// 
			this.label3.BackColor = System.Drawing.Color.Transparent;
			this.label3.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.label3.Location = new System.Drawing.Point(248, 88);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(64, 23);
			this.label3.TabIndex = 177;
			this.label3.Text = "客户名称";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label28
			// 
			this.label28.BackColor = System.Drawing.Color.Transparent;
			this.label28.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.label28.Location = new System.Drawing.Point(536, 168);
			this.label28.Name = "label28";
			this.label28.Size = new System.Drawing.Size(64, 23);
			this.label28.TabIndex = 172;
			this.label28.Text = "审核时间";
			this.label28.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txt8
			// 
			this.txt8.BackColor = System.Drawing.Color.White;
			this.txt8.DataField = "approvedon";
			this.txt8.DataType = TJSystem.Public.DataType.String;
			this.txt8.Enabled = false;
			this.txt8.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.txt8.Location = new System.Drawing.Point(600, 168);
			this.txt8.Name = "txt8";
			this.txt8.Size = new System.Drawing.Size(104, 23);
			this.txt8.TabIndex = 171;
			this.txt8.Text = "";
			// 
			// label29
			// 
			this.label29.BackColor = System.Drawing.Color.Transparent;
			this.label29.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.label29.Location = new System.Drawing.Point(376, 168);
			this.label29.Name = "label29";
			this.label29.Size = new System.Drawing.Size(48, 23);
			this.label29.TabIndex = 170;
			this.label29.Text = "审核者";
			this.label29.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txt7
			// 
			this.txt7.BackColor = System.Drawing.Color.White;
			this.txt7.DataField = "approvedBy";
			this.txt7.DataType = TJSystem.Public.DataType.String;
			this.txt7.Enabled = false;
			this.txt7.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.txt7.Location = new System.Drawing.Point(432, 168);
			this.txt7.Name = "txt7";
			this.txt7.Size = new System.Drawing.Size(96, 23);
			this.txt7.TabIndex = 169;
			this.txt7.Text = "";
			// 
			// label18
			// 
			this.label18.BackColor = System.Drawing.Color.Transparent;
			this.label18.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.label18.Location = new System.Drawing.Point(240, 112);
			this.label18.Name = "label18";
			this.label18.Size = new System.Drawing.Size(80, 23);
			this.label18.TabIndex = 126;
			this.label18.Text = "联系人姓名";
			this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txt4
			// 
			this.txt4.BackColor = System.Drawing.Color.White;
			this.txt4.DataField = "Contact_name";
			this.txt4.DataType = TJSystem.Public.DataType.String;
			this.txt4.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.txt4.Location = new System.Drawing.Point(320, 112);
			this.txt4.Name = "txt4";
			this.txt4.Size = new System.Drawing.Size(168, 23);
			this.txt4.TabIndex = 127;
			this.txt4.Text = "";
			// 
			// label19
			// 
			this.label19.BackColor = System.Drawing.Color.Transparent;
			this.label19.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.label19.ForeColor = System.Drawing.Color.Blue;
			this.label19.Location = new System.Drawing.Point(8, 112);
			this.label19.Name = "label19";
			this.label19.Size = new System.Drawing.Size(80, 23);
			this.label19.TabIndex = 123;
			this.label19.Text = "联系人";
			this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label21
			// 
			this.label21.BackColor = System.Drawing.Color.Transparent;
			this.label21.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.label21.Location = new System.Drawing.Point(200, 192);
			this.label21.Name = "label21";
			this.label21.Size = new System.Drawing.Size(64, 23);
			this.label21.TabIndex = 42;
			this.label21.Text = "修改时间";
			this.label21.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txt10
			// 
			this.txt10.BackColor = System.Drawing.Color.White;
			this.txt10.DataField = "modifyon";
			this.txt10.DataType = TJSystem.Public.DataType.String;
			this.txt10.Enabled = false;
			this.txt10.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.txt10.Location = new System.Drawing.Point(264, 192);
			this.txt10.Name = "txt10";
			this.txt10.Size = new System.Drawing.Size(104, 23);
			this.txt10.TabIndex = 41;
			this.txt10.Text = "";
			// 
			// label20
			// 
			this.label20.BackColor = System.Drawing.Color.Transparent;
			this.label20.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.label20.Location = new System.Drawing.Point(200, 168);
			this.label20.Name = "label20";
			this.label20.Size = new System.Drawing.Size(64, 23);
			this.label20.TabIndex = 40;
			this.label20.Text = "创建时间";
			this.label20.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txt6
			// 
			this.txt6.BackColor = System.Drawing.Color.White;
			this.txt6.DataField = "createon";
			this.txt6.DataType = TJSystem.Public.DataType.String;
			this.txt6.Enabled = false;
			this.txt6.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.txt6.Location = new System.Drawing.Point(264, 168);
			this.txt6.Name = "txt6";
			this.txt6.Size = new System.Drawing.Size(104, 23);
			this.txt6.TabIndex = 39;
			this.txt6.Text = "";
			// 
			// label17
			// 
			this.label17.BackColor = System.Drawing.Color.Transparent;
			this.label17.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.label17.Location = new System.Drawing.Point(16, 192);
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
			this.label15.Location = new System.Drawing.Point(8, 168);
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
			this.label12.Location = new System.Drawing.Point(488, 64);
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
			this.label11.Location = new System.Drawing.Point(8, 88);
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
			this.label8.Location = new System.Drawing.Point(272, 64);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(40, 23);
			this.label8.TabIndex = 22;
			this.label8.Text = "日期";
			this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label2
			// 
			this.label2.BackColor = System.Drawing.Color.Transparent;
			this.label2.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.label2.ForeColor = System.Drawing.Color.Blue;
			this.label2.Location = new System.Drawing.Point(8, 64);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(80, 23);
			this.label2.TabIndex = 16;
			this.label2.Text = "销售退货号";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txt3
			// 
			this.txt3.BackColor = System.Drawing.Color.White;
			this.txt3.DataField = "client_name";
			this.txt3.DataType = TJSystem.Public.DataType.String;
			this.txt3.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.txt3.Location = new System.Drawing.Point(320, 88);
			this.txt3.Name = "txt3";
			this.txt3.Size = new System.Drawing.Size(168, 23);
			this.txt3.TabIndex = 104;
			this.txt3.Text = "";
			// 
			// txt5
			// 
			this.txt5.BackColor = System.Drawing.Color.White;
			this.txt5.DataField = "createBy";
			this.txt5.DataType = TJSystem.Public.DataType.String;
			this.txt5.Enabled = false;
			this.txt5.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.txt5.Location = new System.Drawing.Point(96, 168);
			this.txt5.Name = "txt5";
			this.txt5.Size = new System.Drawing.Size(96, 23);
			this.txt5.TabIndex = 12;
			this.txt5.Text = "";
			// 
			// txt9
			// 
			this.txt9.BackColor = System.Drawing.Color.White;
			this.txt9.DataField = "modifyBy";
			this.txt9.DataType = TJSystem.Public.DataType.String;
			this.txt9.Enabled = false;
			this.txt9.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.txt9.Location = new System.Drawing.Point(96, 192);
			this.txt9.Name = "txt9";
			this.txt9.Size = new System.Drawing.Size(96, 23);
			this.txt9.TabIndex = 9;
			this.txt9.Text = "";
			// 
			// txt1
			// 
			this.txt1.BackColor = System.Drawing.Color.White;
			this.txt1.DataField = "ss_code";
			this.txt1.DataType = TJSystem.Public.DataType.String;
			this.txt1.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.txt1.Location = new System.Drawing.Point(96, 64);
			this.txt1.Name = "txt1";
			this.txt1.Size = new System.Drawing.Size(144, 23);
			this.txt1.TabIndex = 100;
			this.txt1.Text = "";
			// 
			// label4
			// 
			this.label4.BackColor = System.Drawing.Color.Transparent;
			this.label4.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.label4.ForeColor = System.Drawing.Color.Blue;
			this.label4.Location = new System.Drawing.Point(488, 112);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(40, 23);
			this.label4.TabIndex = 26;
			this.label4.Text = "币种";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// dataGrid1
			// 
			this.dataGrid1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.dataGrid1.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.dataGrid1.CaptionBackColor = System.Drawing.SystemColors.ActiveBorder;
			this.dataGrid1.CaptionText = "销售退货";
			this.dataGrid1.DataMember = "";
			this.dataGrid1.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.dataGrid1.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.dataGrid1.Location = new System.Drawing.Point(0, 248);
			this.dataGrid1.Name = "dataGrid1";
			this.dataGrid1.ReadOnly = true;
			this.dataGrid1.Size = new System.Drawing.Size(760, 280);
			this.dataGrid1.TabIndex = 198;
			this.dataGrid1.TableStyles.AddRange(new System.Windows.Forms.DataGridTableStyle[] {
																								  this.dataGridTableStyle1});
			// 
			// dataGridTableStyle1
			// 
			this.dataGridTableStyle1.DataGrid = this.dataGrid1;
			this.dataGridTableStyle1.GridColumnStyles.AddRange(new System.Windows.Forms.DataGridColumnStyle[] {
																												  this.ss_code,
																												  this.ss_date,
																												  this.status_name,
																												  this.client_id,
																												  this.client_name,
																												  this.contact_id,
																												  this.contact_name,
																												  this.currency_namecn,
																												  this.wh_name,
																												  this.createby,
																												  this.createon,
																												  this.modifyby,
																												  this.modifyon,
																												  this.approvedby,
																												  this.approvedon});
			this.dataGridTableStyle1.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.dataGridTableStyle1.MappingName = "sale_ss_master";
			// 
			// ss_code
			// 
			this.ss_code.Format = "";
			this.ss_code.FormatInfo = null;
			this.ss_code.HeaderText = "销售退货号";
			this.ss_code.MappingName = "ss_code";
			this.ss_code.NullText = "";
			this.ss_code.Width = 75;
			// 
			// ss_date
			// 
			this.ss_date.Format = "";
			this.ss_date.FormatInfo = null;
			this.ss_date.HeaderText = "退货日期";
			this.ss_date.MappingName = "ss_date";
			this.ss_date.NullText = "";
			this.ss_date.Width = 75;
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
			this.contact_id.HeaderText = "联系人代码";
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
			// currency_namecn
			// 
			this.currency_namecn.Format = "";
			this.currency_namecn.FormatInfo = null;
			this.currency_namecn.HeaderText = "币种";
			this.currency_namecn.MappingName = "currency_namecn";
			this.currency_namecn.NullText = "";
			this.currency_namecn.Width = 75;
			// 
			// wh_name
			// 
			this.wh_name.Format = "";
			this.wh_name.FormatInfo = null;
			this.wh_name.HeaderText = "仓库";
			this.wh_name.MappingName = "wh_name";
			this.wh_name.NullText = "";
			this.wh_name.Width = 75;
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
			// address
			// 
			this.address.Format = "";
			this.address.FormatInfo = null;
			this.address.HeaderText = "地址";
			this.address.MappingName = "address";
			this.address.NullText = "";
			this.address.Width = 75;
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
			// postcode
			// 
			this.postcode.Format = "";
			this.postcode.FormatInfo = null;
			this.postcode.HeaderText = "邮政编码";
			this.postcode.MappingName = "postcode";
			this.postcode.NullText = "";
			this.postcode.Width = 75;
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
			this.panel3.Location = new System.Drawing.Point(0, 534);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(768, 40);
			this.panel3.TabIndex = 21;
			// 
			// priToolBar1
			// 
			this.priToolBar1.DGEnable = true;
			this.priToolBar1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.priToolBar1.Location = new System.Drawing.Point(0, -4);
			this.priToolBar1.Name = "priToolBar1";
			this.priToolBar1.setCurrentForm = null;
			this.priToolBar1.Size = new System.Drawing.Size(764, 40);
			this.priToolBar1.TabIndex = 0;
			// 
			// frmSaleSS
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(7, 16);
			this.BackColor = System.Drawing.SystemColors.ScrollBar;
			this.ClientSize = new System.Drawing.Size(768, 574);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel3);
			this.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "frmSaleSS";
			this.Text = "销售退货";
			this.panel1.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			this.panel4.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).EndInit();
			this.panel3.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

//		private void dataGrid1_Click(object sender, System.EventArgs e)
//		{
//			System.Text.StringBuilder sb = new System.Text.StringBuilder();
//			sb.Append("select ss_code,seq_no,item_code,client_itemcode,item_name,item_name_cn,item_desc,item_desc_cn,item_qty,unit,remark ");
//			sb.Append("from sale_ss_detail ");
//			sb.Append("where ss_code = '"+ this.dataGrid1[this.dataGrid1.CurrentCell.RowNumber,0] +"'");
//			sb.Append("order by ss_code");
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
				TJSystem.Public.PublicStatic.formName = "销售退货";
			}
			base.OnClosing (e);
		}

		private void priComboBox2_SelectionChangeCommitted(object sender, System.EventArgs e)
		{
			string sql = "select  a.client_name as client_name, b.contact_id, b.contact_id +' '+b.contact_name as contact_name  from basic_client a join basic_client_contact b on a.client_id = b.client_id and a.client_id = '"+ this.priComboBox2.SelectedValue +"'";
			DataTable dt = TJSystem.Public.PublicStatic.db.GetDataTable(sql);
			DataRow dr = null;
			DataTable dtcpy = null;
			dr = dt.NewRow();
			dr[0] = "";
			dr[1] = "";
			dr[2] = "";
			dt.Rows.InsertAt(dr,0);
			dtcpy = dt.Copy();
			this.priComboBox3.DataSource = dtcpy.DefaultView;
			this.priComboBox3.ValueMember = "contact_id";
			this.priComboBox3.DisplayMember = "contact_name";
			this.priComboBox3.Enabled = true;
			sql = "select client_name from basic_client where client_id = '"+ this.priComboBox2.SelectedValue +"'";
			dt = TJSystem.Public.PublicStatic.db.GetDataTable(sql);
			if (dt.Rows.Count > 0)
			{
				this.txt3.Text = dt.Rows[0]["client_name"].ToString();
			}
			else
			{
				this.txt3.Text = "";
			}
		}

		private void priComboBox3_SelectionChangeCommitted(object sender, System.EventArgs e)
		{
			string sql = "select contact_name from basic_client_contact where contact_id = '"+ this.priComboBox3.SelectedValue +"'";
			DataTable dt = TJSystem.Public.PublicStatic.db.GetDataTable(sql);
			if (dt.Rows.Count > 0)
			{
				this.txt4.Text = dt.Rows[0]["contact_name"].ToString();
			}
			else
			{
				this.txt4.Text = "";
			}
		}

		private void linkLabel1_LinkClicked(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
		{
//			if(Count< 1)
			{
				if (this.txt1.Text.ToString().Trim() == "" )
				{
					TJSystem.Public.PublicStatic.ShowMessage(TJSystem.Public.MessageType.Exclamation,"请选择一张退货单号");
					return;
				}
				else
				{
					frmSSDetail frmssDel = new frmSSDetail(this.txt1.Text.ToString().Trim());
					frmssDel.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
					frmssDel.ShowDialog();
					Count += 1;
				}			
				
			}
		}

		private void priComboBox1_SelectionChangeCommitted(object sender, System.EventArgs e)
		{
			TJSystem.Public.PublicStatic.SetApprovedInfo(this.priComboBox1,this.txt7,this.txt8);
		}

	
	}
}

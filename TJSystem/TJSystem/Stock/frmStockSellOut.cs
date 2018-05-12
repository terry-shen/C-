using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace TJSystem.Stock
{
	/// <summary>
	/// Form1 的摘要说明。
	/// </summary>
	public class frmStockSellOut : System.Windows.Forms.Form
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
		private System.Windows.Forms.DataGrid dataGrid1;
		private System.Windows.Forms.Panel panel4;
		private System.Windows.Forms.Label label28;
		private System.Windows.Forms.Label label29;
		private System.Windows.Forms.Label label34;
		private System.Windows.Forms.Label label32;
		private System.Windows.Forms.Label label16;
		private System.Windows.Forms.Label label23;
		private System.Windows.Forms.Label label24;
		private System.Windows.Forms.Label label18;
		private System.Windows.Forms.Label label19;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label21;
		private System.Windows.Forms.Label label20;
		private System.Windows.Forms.Label label17;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label2;
		private TJSystem.Classes.PriTextBox txt1;
		
		private TJSystem.Classes.PriTextBox txt14;
		private TJSystem.Classes.PriTextBox txt12;
		private TJSystem.Classes.PriTextBox txt11;
		private TJSystem.Classes.PriTextBox txt5;
		private TJSystem.Classes.PriTextBox txt18;
		private TJSystem.Classes.PriTextBox txt20;
		private TJSystem.Classes.PriTextBox txt16;
		private TJSystem.Classes.PriTextBox txt15;
		private TJSystem.Classes.PriTextBox txt19;
		public static System.Windows.Forms.Form frmCurrent = null ;
		private TJSystem.Classes.PriComboBox comboBox1;
		private TJSystem.Classes.PriComboBox priComboBox1;
		private TJSystem.Classes.PriComboBox priComboBox3;
		private TJSystem.Classes.PriComboBox priComboBox2;
		private TJSystem.Classes.PriComboBox priComboBox4;
		private string _PK;
		private string _table = null;
		private System.Windows.Forms.DataGridTableStyle dataGridTableStyle1;
		private System.Windows.Forms.DataGridTextBoxColumn status_name;
		private System.Windows.Forms.DataGridTextBoxColumn currency_namecn;
		private System.Windows.Forms.DataGridTextBoxColumn trans_namecn;
		private System.Windows.Forms.DataGridTextBoxColumn marks;
		private System.Windows.Forms.DataGridTextBoxColumn remark;
		private System.Windows.Forms.DataGridTextBoxColumn createBy;
		private System.Windows.Forms.DataGridTextBoxColumn createon;
		private System.Windows.Forms.DataGridTextBoxColumn approvedon;
		private System.Windows.Forms.DataGridTextBoxColumn modifyBy;
		private System.Windows.Forms.DataGridTextBoxColumn modifyon;
		private System.Windows.Forms.LinkLabel linkLabel2;
		private TJSystem.Classes.PriComboBox priComboBox8;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label9;
		private TJSystem.Classes.PriTextBox priTextBox1;
		private System.Windows.Forms.Label label10;
		private TJSystem.Classes.PriTextBox priTextBox2;
		private TJSystem.Classes.PriComboBox priComboBox6;
		private TJSystem.Classes.PriDateTimePicker priDateTimePicker3;
		private System.Windows.Forms.DataGridTextBoxColumn client_id;
		private System.Windows.Forms.DataGridTextBoxColumn client_name;
		private System.Windows.Forms.DataGridTextBoxColumn forwarder_id;
		private System.Windows.Forms.DataGridTextBoxColumn forwarder_name;
		private System.Windows.Forms.DataGridTextBoxColumn wh_name;
		private System.Windows.Forms.DataGridTextBoxColumn destination;
		private System.Windows.Forms.DataGridTextBoxColumn approvedby;
		private TJSystem.Classes.PriTextBox priTextBox3;
		private string _statusType = null;
		private TJSystem.Classes.PriTextBox priTextBox4;
		private System.Windows.Forms.DataGridTextBoxColumn stock_code;
		private System.Windows.Forms.DataGridTextBoxColumn stock_date;
		private System.Windows.Forms.DataGridTextBoxColumn contact_id;
		private System.Windows.Forms.DataGridTextBoxColumn contact_name;
		private string _eventtype = null;

		public frmStockSellOut()
		{
			//
			// Windows 窗体设计器支持所必需的
			//
			InitializeComponent();

			_statusType = "stock";
			_eventtype = "SELL";
			

			TJSystem.Public.PublicStatic.setBackgroundImg(this.panel1,this.panel1.GetType().ToString(),"images\\bg.gif");
			TJSystem.Public.PublicStatic.setBackgroundImg(this.panel2,this.panel1.GetType().ToString(),"");
			TJSystem.Public.PublicStatic.setBackgroundImg(this.panel3,this.panel1.GetType().ToString(),"");
			TJSystem.Public.PublicStatic.setBackgroundImg(this.panel4,this.panel1.GetType().ToString(),"");

			InitialFormData();
			System.Text.StringBuilder sb = new System.Text.StringBuilder();
			sb.Append("select a.stock_code,a.stock_date,a.event_type,a.status,c.status_name,a.wh_code,d.wh_name,a.client_id,a.client_name,a.forwarder_id,a.forwarder_name,a.contact_id,");
			sb.Append(" a.contact_name,a.destination,a.transtype,b.trans_namecn,a.marks,a.remark,a.approvedby,a.approvedon,a.createby,a.createon,");
			sb.Append(" a.modifyby,a.modifyon,a.currency,e.currency_namecn");
			sb.Append(" from wip_stock_mstr a");
			sb.Append(" left join p_transtype b on a.transtype=b.trans_code");
			sb.Append(" left join p_status c on a.status=c.status_id and status_type=");
			sb.Append("'");
			sb.Append(_statusType);
			sb.Append("'" );
			sb.Append(" left join basic_whouse d on a.wh_code=d.wh_code");
			sb.Append(" left join p_currency e on a.currency=e.currency_code");
			sb.Append(" where 1=1");
			sb.Append(" and a.event_type=");
			sb.Append("'");
			sb.Append(this._eventtype);
			sb.Append("'");
			sb.Append(" order by a.stock_code");

			this.InitialGrid(sb.ToString());

			priToolBar1.setCurrentForm = this;
			_PK = "stock_code,event_type";
			_table = "wip_stock_mstr";
			priToolBar1.Initial(_table,_PK,sb.ToString());
			priToolBar1.BeforeButtonClickEvent += new TJSystem.UC.PriToolBar.BeforeButotnClick(this.BeforeButtonClick);
			priToolBar1.AfterButtonClickEvent += new TJSystem.UC.PriToolBar.AfterButtonClick(this.AfterButtonClick);

			this.priToolBar1.setButtonVisibleFalse();;
			this.priToolBar1.setButtonVisible("012345689");
			this.priToolBar1.SetStatusEnable(this.priComboBox1);
			
			setDisable();

			//
			// TODO: 在 InitializeComponent 调用后添加任何构造函数代码
			//
		}

		private void InitialFormData()
		{
			DataTable dtcpy = null;
			DataRow dr = null;
			string sql = "select WH_CODE,WH_CODE+' '+WH_NAME as WH_NAME from basic_whouse order by wh_code";
			DataTable dt = TJSystem.Public.PublicStatic.db.GetDataTable(sql);
			dr = dt.NewRow() ;
			dr[0] = "" ;
			dr[1] = "" ;
			dt.Rows.InsertAt(dr,0) ;
			dtcpy = dt.Copy();
			this.priComboBox2.DataSource = dtcpy.DefaultView;
			this.priComboBox2.ValueMember = "WH_CODE";
			this.priComboBox2.DisplayMember = "WH_NAME";

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
			

			sql = "select TRANS_CODE,TRANS_CODE+' '+TRANS_NAMECN as TRANS_NAMECN from p_transtype order by trans_code";
			dt = TJSystem.Public.PublicStatic.db.GetDataTable(sql);
			dr = dt.NewRow() ;
			dr[0] = "" ;
			dr[1] = "" ;
			dt.Rows.InsertAt(dr,0) ;
			dtcpy = dt.Copy();
			this.priComboBox4.DataSource = dtcpy.DefaultView;
			this.priComboBox4.ValueMember = "TRANS_CODE";
			this.priComboBox4.DisplayMember = "TRANS_NAMECN";

			
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

			sql = "select FORWARDER_ID,FORWARDER_ID+' '+FORWARDER_NAME as FORWARDER_NAME from basic_forwarder order by FORWARDER_ID";
			dt = TJSystem.Public.PublicStatic.db.GetDataTable(sql);
			dr = dt.NewRow() ;
			dr[0] = "" ;
			dr[1] = "" ;
			dt.Rows.InsertAt(dr,0) ;
			dtcpy = dt.Copy();
			this.priComboBox8.DataSource = dtcpy.DefaultView;
			this.priComboBox8.ValueMember = "FORWARDER_ID";
			this.priComboBox8.DisplayMember = "FORWARDER_NAME";

			sql = "select CLIENT_ID,CLIENT_ID+' '+CLIENT_NAME as CLIENT_NAME from basic_client order by client_id";
			dt = TJSystem.Public.PublicStatic.db.GetDataTable(sql);
			dr = dt.NewRow() ;
			dr[0] = "" ;
			dr[1] = "" ;
			dt.Rows.InsertAt(dr,0) ;
			dtcpy = dt.Copy();
			this.comboBox1.DataSource = dtcpy.DefaultView;
			this.comboBox1.ValueMember = "CLIENT_ID";
			this.comboBox1.DisplayMember = "CLIENT_NAME";

			sql = "select CONTACT_ID,CONTACT_ID+' '+CONTACT_NAME as CONTACT_NAME from basic_forwarder_contact";
			dt = TJSystem.Public.PublicStatic.db.GetDataTable(sql);
			dr = dt.NewRow() ;
			dr[0] = "" ;
			dr[1] = "" ;
			dt.Rows.InsertAt(dr,0) ;
			dtcpy = dt.Copy();
			this.priComboBox6.DataSource = dtcpy.DefaultView;
			this.priComboBox6.ValueMember = "CONTACT_ID";
			this.priComboBox6.DisplayMember = "CONTACT_NAME";
		}


		private bool BeforeButtonClick(string sqltype)
		{
			if(sqltype.Equals("default"))
			{
				this.setDisable();
			}
			if(sqltype.Equals("insert"))
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
			if(sqltype.Equals("insert"))
			{
				if(txt1.Text.Length > 10)
				{
					TJSystem.Public.PublicStatic.ShowMessage(TJSystem.Public.MessageType.Exclamation,"数据长度超出数据库定义要求");
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
				this.priToolBar1.SetStatusEnable(this.priComboBox1);
			}	
			return true;
		}


		private void setDisable()
		{
			this.txt1.Enabled = false;						
			this.txt5.Enabled = false;						
			this.txt11.Enabled = false;
			this.txt12.Enabled = false;			
			this.txt14.Enabled = false;
			this.txt15.Enabled = false;
			this.txt16.Enabled = false;			
			this.txt18.Enabled = false;
			this.txt19.Enabled = false;
			this.txt20.Enabled = false;
			this.priTextBox1.Enabled = false;
			this.priTextBox2.Enabled = false;
			this.priTextBox3.Enabled = false;
			this.priComboBox1.Enabled = false;
			this.priComboBox2.Enabled = false;
			this.priComboBox3.Enabled = false;
			this.priComboBox4.Enabled = false;
			this.priComboBox8.Enabled = false;
			this.priComboBox6.Enabled = false;
			this.priDateTimePicker3.Enabled = false;
			this.comboBox1.Enabled = false;
		}

		private void AfterButtonClick(string ButtonType)
		{
			if(ButtonType.Equals("insert"))
			{
				this.txt1.Enabled = true;			
				
				this.txt11.Enabled = true;
				this.txt12.Enabled = true;				
				this.txt14.Enabled = true;
				
				this.priComboBox1.Enabled = false;
				this.priComboBox2.Enabled = true;
				this.priComboBox3.Enabled = true;
				this.priComboBox4.Enabled = true;
				this.priComboBox8.Enabled = true;
				this.priComboBox6.Enabled = true;
				this.priDateTimePicker3.Enabled = true;
				this.comboBox1.Enabled = true;

				this.txt1.Text = "";
				this.txt5.Text = "";				
				this.txt11.Text = "";
				this.txt12.Text = "";				
				this.txt14.Text = "";
				
				this.priTextBox1.Text = "";
				this.priTextBox2.Text = "";
				
				this.priComboBox1.SelectedValue = "1";
				this.priComboBox2.Text = "";
				this.priComboBox3.Text = "";
				this.priComboBox4.Text = "";
				this.priComboBox8.Text = "";
				this.priComboBox6.Text = "";
				this.comboBox1.Text = "";
				this.priDateTimePicker3.Value = System.DateTime.Now;
			}
			else if(ButtonType.Equals("update"))
			{
				this.txt1.Enabled = false;			
				
				this.txt11.Enabled = true;
				this.txt12.Enabled = true;				
				this.txt14.Enabled = true;
				
				this.priComboBox1.Enabled = false;
				this.priComboBox2.Enabled = true;
				this.priComboBox3.Enabled = true;
				this.priComboBox4.Enabled = true;
				this.priComboBox8.Enabled = true;
				this.priComboBox6.Enabled = true;
				this.priDateTimePicker3.Enabled = true;
				this.comboBox1.Enabled = true;

			}
			this.priToolBar1.SetStatusEnable(this.priComboBox1);
		}



		private void InitialGrid(string sql)
		{		
			DataTable dt = TJSystem.Public.PublicStatic.db.GetDataTable(sql);
			dt.TableName = "wip_stock_mstr";
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(frmStockSellOut));
			this.panel3 = new System.Windows.Forms.Panel();
			this.priToolBar1 = new TJSystem.UC.PriToolBar();
			this.panel1 = new System.Windows.Forms.Panel();
			this.label1 = new System.Windows.Forms.Label();
			this.panel2 = new System.Windows.Forms.Panel();
			this.dataGrid1 = new System.Windows.Forms.DataGrid();
			this.dataGridTableStyle1 = new System.Windows.Forms.DataGridTableStyle();
			this.stock_code = new System.Windows.Forms.DataGridTextBoxColumn();
			this.stock_date = new System.Windows.Forms.DataGridTextBoxColumn();
			this.status_name = new System.Windows.Forms.DataGridTextBoxColumn();
			this.wh_name = new System.Windows.Forms.DataGridTextBoxColumn();
			this.client_id = new System.Windows.Forms.DataGridTextBoxColumn();
			this.client_name = new System.Windows.Forms.DataGridTextBoxColumn();
			this.forwarder_id = new System.Windows.Forms.DataGridTextBoxColumn();
			this.forwarder_name = new System.Windows.Forms.DataGridTextBoxColumn();
			this.contact_id = new System.Windows.Forms.DataGridTextBoxColumn();
			this.contact_name = new System.Windows.Forms.DataGridTextBoxColumn();
			this.destination = new System.Windows.Forms.DataGridTextBoxColumn();
			this.trans_namecn = new System.Windows.Forms.DataGridTextBoxColumn();
			this.currency_namecn = new System.Windows.Forms.DataGridTextBoxColumn();
			this.marks = new System.Windows.Forms.DataGridTextBoxColumn();
			this.remark = new System.Windows.Forms.DataGridTextBoxColumn();
			this.approvedby = new System.Windows.Forms.DataGridTextBoxColumn();
			this.approvedon = new System.Windows.Forms.DataGridTextBoxColumn();
			this.createBy = new System.Windows.Forms.DataGridTextBoxColumn();
			this.createon = new System.Windows.Forms.DataGridTextBoxColumn();
			this.modifyBy = new System.Windows.Forms.DataGridTextBoxColumn();
			this.modifyon = new System.Windows.Forms.DataGridTextBoxColumn();
			this.panel4 = new System.Windows.Forms.Panel();
			this.priTextBox4 = new TJSystem.Classes.PriTextBox();
			this.priDateTimePicker3 = new TJSystem.Classes.PriDateTimePicker();
			this.linkLabel2 = new System.Windows.Forms.LinkLabel();
			this.priComboBox4 = new TJSystem.Classes.PriComboBox();
			this.priComboBox2 = new TJSystem.Classes.PriComboBox();
			this.priComboBox3 = new TJSystem.Classes.PriComboBox();
			this.priComboBox1 = new TJSystem.Classes.PriComboBox();
			this.comboBox1 = new TJSystem.Classes.PriComboBox();
			this.label28 = new System.Windows.Forms.Label();
			this.txt18 = new TJSystem.Classes.PriTextBox();
			this.label29 = new System.Windows.Forms.Label();
			this.label34 = new System.Windows.Forms.Label();
			this.label32 = new System.Windows.Forms.Label();
			this.txt14 = new TJSystem.Classes.PriTextBox();
			this.label16 = new System.Windows.Forms.Label();
			this.txt12 = new TJSystem.Classes.PriTextBox();
			this.label23 = new System.Windows.Forms.Label();
			this.label24 = new System.Windows.Forms.Label();
			this.txt11 = new TJSystem.Classes.PriTextBox();
			this.label18 = new System.Windows.Forms.Label();
			this.label19 = new System.Windows.Forms.Label();
			this.txt5 = new TJSystem.Classes.PriTextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label21 = new System.Windows.Forms.Label();
			this.txt20 = new TJSystem.Classes.PriTextBox();
			this.label20 = new System.Windows.Forms.Label();
			this.txt16 = new TJSystem.Classes.PriTextBox();
			this.label17 = new System.Windows.Forms.Label();
			this.label15 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.txt15 = new TJSystem.Classes.PriTextBox();
			this.txt19 = new TJSystem.Classes.PriTextBox();
			this.txt1 = new TJSystem.Classes.PriTextBox();
			this.priComboBox8 = new TJSystem.Classes.PriComboBox();
			this.label6 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.priTextBox1 = new TJSystem.Classes.PriTextBox();
			this.label10 = new System.Windows.Forms.Label();
			this.priTextBox2 = new TJSystem.Classes.PriTextBox();
			this.priComboBox6 = new TJSystem.Classes.PriComboBox();
			this.priTextBox3 = new TJSystem.Classes.PriTextBox();
			this.panel3.SuspendLayout();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).BeginInit();
			this.panel4.SuspendLayout();
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
			this.panel3.TabIndex = 24;
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
			this.panel1.TabIndex = 22;
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
			this.label1.Text = "销售出库";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
			this.panel2.Size = new System.Drawing.Size(792, 566);
			this.panel2.TabIndex = 23;
			// 
			// dataGrid1
			// 
			this.dataGrid1.AllowSorting = false;
			this.dataGrid1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.dataGrid1.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.dataGrid1.CaptionBackColor = System.Drawing.SystemColors.AppWorkspace;
			this.dataGrid1.CaptionText = "入库单列表";
			this.dataGrid1.CaptionVisible = false;
			this.dataGrid1.DataMember = "";
			this.dataGrid1.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.dataGrid1.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.dataGrid1.Location = new System.Drawing.Point(0, 272);
			this.dataGrid1.Name = "dataGrid1";
			this.dataGrid1.ReadOnly = true;
			this.dataGrid1.Size = new System.Drawing.Size(792, 248);
			this.dataGrid1.TabIndex = 1;
			this.dataGrid1.TableStyles.AddRange(new System.Windows.Forms.DataGridTableStyle[] {
																								  this.dataGridTableStyle1});
			this.dataGrid1.Click += new System.EventHandler(this.dataGrid1_Click);
			// 
			// dataGridTableStyle1
			// 
			this.dataGridTableStyle1.DataGrid = this.dataGrid1;
			this.dataGridTableStyle1.GridColumnStyles.AddRange(new System.Windows.Forms.DataGridColumnStyle[] {
																												  this.stock_code,
																												  this.stock_date,
																												  this.status_name,
																												  this.wh_name,
																												  this.client_id,
																												  this.client_name,
																												  this.forwarder_id,
																												  this.forwarder_name,
																												  this.contact_id,
																												  this.contact_name,
																												  this.destination,
																												  this.trans_namecn,
																												  this.currency_namecn,
																												  this.marks,
																												  this.remark,
																												  this.approvedby,
																												  this.approvedon,
																												  this.createBy,
																												  this.createon,
																												  this.modifyBy,
																												  this.modifyon});
			this.dataGridTableStyle1.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.dataGridTableStyle1.MappingName = "wip_stock_mstr";
			// 
			// stock_code
			// 
			this.stock_code.Format = "";
			this.stock_code.FormatInfo = null;
			this.stock_code.HeaderText = "出库单号";
			this.stock_code.MappingName = "stock_code";
			this.stock_code.NullText = "";
			this.stock_code.Width = 75;
			// 
			// stock_date
			// 
			this.stock_date.Format = "";
			this.stock_date.FormatInfo = null;
			this.stock_date.HeaderText = "出库日期";
			this.stock_date.MappingName = "stock_date";
			this.stock_date.NullText = "";
			this.stock_date.Width = 75;
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
			// wh_name
			// 
			this.wh_name.Format = "";
			this.wh_name.FormatInfo = null;
			this.wh_name.HeaderText = "仓库";
			this.wh_name.MappingName = "wh_name";
			this.wh_name.NullText = "";
			this.wh_name.Width = 75;
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
			this.client_name.HeaderText = "名称";
			this.client_name.MappingName = "client_name";
			this.client_name.NullText = "";
			this.client_name.Width = 75;
			// 
			// forwarder_id
			// 
			this.forwarder_id.Format = "";
			this.forwarder_id.FormatInfo = null;
			this.forwarder_id.HeaderText = "运输商编号";
			this.forwarder_id.MappingName = "forwarder_id";
			this.forwarder_id.NullText = "";
			this.forwarder_id.Width = 75;
			// 
			// forwarder_name
			// 
			this.forwarder_name.Format = "";
			this.forwarder_name.FormatInfo = null;
			this.forwarder_name.HeaderText = "运输商名称";
			this.forwarder_name.MappingName = "forwarder_name";
			this.forwarder_name.NullText = "";
			this.forwarder_name.Width = 75;
			// 
			// contact_id
			// 
			this.contact_id.Format = "";
			this.contact_id.FormatInfo = null;
			this.contact_id.HeaderText = "联系人编号";
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
			// destination
			// 
			this.destination.Format = "";
			this.destination.FormatInfo = null;
			this.destination.HeaderText = "目的地";
			this.destination.MappingName = "destination";
			this.destination.NullText = "";
			this.destination.Width = 75;
			// 
			// trans_namecn
			// 
			this.trans_namecn.Format = "";
			this.trans_namecn.FormatInfo = null;
			this.trans_namecn.HeaderText = "运输类型";
			this.trans_namecn.MappingName = "trans_namecn";
			this.trans_namecn.NullText = "";
			this.trans_namecn.Width = 75;
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
			// marks
			// 
			this.marks.Format = "";
			this.marks.FormatInfo = null;
			this.marks.HeaderText = "噱头";
			this.marks.MappingName = "marks";
			this.marks.NullText = "";
			this.marks.Width = 75;
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
			// createBy
			// 
			this.createBy.Format = "";
			this.createBy.FormatInfo = null;
			this.createBy.HeaderText = "创建者";
			this.createBy.MappingName = "createBy";
			this.createBy.NullText = "";
			this.createBy.Width = 75;
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
			// modifyBy
			// 
			this.modifyBy.Format = "";
			this.modifyBy.FormatInfo = null;
			this.modifyBy.HeaderText = "最后修改人";
			this.modifyBy.MappingName = "modifyBy";
			this.modifyBy.NullText = "";
			this.modifyBy.Width = 75;
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
			this.panel4.Controls.Add(this.priTextBox4);
			this.panel4.Controls.Add(this.priDateTimePicker3);
			this.panel4.Controls.Add(this.linkLabel2);
			this.panel4.Controls.Add(this.priComboBox4);
			this.panel4.Controls.Add(this.priComboBox2);
			this.panel4.Controls.Add(this.priComboBox3);
			this.panel4.Controls.Add(this.priComboBox1);
			this.panel4.Controls.Add(this.comboBox1);
			this.panel4.Controls.Add(this.label28);
			this.panel4.Controls.Add(this.txt18);
			this.panel4.Controls.Add(this.label29);
			this.panel4.Controls.Add(this.label34);
			this.panel4.Controls.Add(this.label32);
			this.panel4.Controls.Add(this.txt14);
			this.panel4.Controls.Add(this.label16);
			this.panel4.Controls.Add(this.txt12);
			this.panel4.Controls.Add(this.label23);
			this.panel4.Controls.Add(this.label24);
			this.panel4.Controls.Add(this.txt11);
			this.panel4.Controls.Add(this.label18);
			this.panel4.Controls.Add(this.label19);
			this.panel4.Controls.Add(this.txt5);
			this.panel4.Controls.Add(this.label5);
			this.panel4.Controls.Add(this.label21);
			this.panel4.Controls.Add(this.txt20);
			this.panel4.Controls.Add(this.label20);
			this.panel4.Controls.Add(this.txt16);
			this.panel4.Controls.Add(this.label17);
			this.panel4.Controls.Add(this.label15);
			this.panel4.Controls.Add(this.label11);
			this.panel4.Controls.Add(this.label8);
			this.panel4.Controls.Add(this.label7);
			this.panel4.Controls.Add(this.label2);
			this.panel4.Controls.Add(this.txt15);
			this.panel4.Controls.Add(this.txt19);
			this.panel4.Controls.Add(this.txt1);
			this.panel4.Controls.Add(this.priComboBox8);
			this.panel4.Controls.Add(this.label6);
			this.panel4.Controls.Add(this.label9);
			this.panel4.Controls.Add(this.priTextBox1);
			this.panel4.Controls.Add(this.label10);
			this.panel4.Controls.Add(this.priTextBox2);
			this.panel4.Controls.Add(this.priComboBox6);
			this.panel4.Controls.Add(this.priTextBox3);
			this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel4.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.panel4.Location = new System.Drawing.Point(0, 0);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(788, 272);
			this.panel4.TabIndex = 0;
			this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
			// 
			// priTextBox4
			// 
			this.priTextBox4.BackColor = System.Drawing.Color.White;
			this.priTextBox4.DataField = "event_type";
			this.priTextBox4.DataType = TJSystem.Public.DataType.String;
			this.priTextBox4.Enabled = false;
			this.priTextBox4.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.priTextBox4.Location = new System.Drawing.Point(96, 288);
			this.priTextBox4.Name = "priTextBox4";
			this.priTextBox4.Size = new System.Drawing.Size(104, 23);
			this.priTextBox4.TabIndex = 218;
			this.priTextBox4.Text = "SELL";
			// 
			// priDateTimePicker3
			// 
			this.priDateTimePicker3.CustomFormat = "yyyy-MM-dd";
			this.priDateTimePicker3.DataField = "stock_date";
			this.priDateTimePicker3.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.priDateTimePicker3.Location = new System.Drawing.Point(352, 48);
			this.priDateTimePicker3.Name = "priDateTimePicker3";
			this.priDateTimePicker3.Size = new System.Drawing.Size(144, 23);
			this.priDateTimePicker3.TabIndex = 215;
			// 
			// linkLabel2
			// 
			this.linkLabel2.BackColor = System.Drawing.Color.Transparent;
			this.linkLabel2.Location = new System.Drawing.Point(376, 240);
			this.linkLabel2.Name = "linkLabel2";
			this.linkLabel2.Size = new System.Drawing.Size(72, 23);
			this.linkLabel2.TabIndex = 178;
			this.linkLabel2.TabStop = true;
			this.linkLabel2.Text = "出库细项";
			this.linkLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
			// 
			// priComboBox4
			// 
			this.priComboBox4.BackColor = System.Drawing.Color.White;
			this.priComboBox4.DataField = "transType";
			this.priComboBox4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.priComboBox4.Location = new System.Drawing.Point(352, 72);
			this.priComboBox4.Name = "priComboBox4";
			this.priComboBox4.Size = new System.Drawing.Size(144, 22);
			this.priComboBox4.TabIndex = 177;
			// 
			// priComboBox2
			// 
			this.priComboBox2.BackColor = System.Drawing.Color.White;
			this.priComboBox2.DataField = "WH_code";
			this.priComboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.priComboBox2.Location = new System.Drawing.Point(96, 72);
			this.priComboBox2.Name = "priComboBox2";
			this.priComboBox2.Size = new System.Drawing.Size(168, 22);
			this.priComboBox2.TabIndex = 176;
			// 
			// priComboBox3
			// 
			this.priComboBox3.BackColor = System.Drawing.Color.White;
			this.priComboBox3.DataField = "Currency";
			this.priComboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.priComboBox3.Location = new System.Drawing.Point(584, 144);
			this.priComboBox3.Name = "priComboBox3";
			this.priComboBox3.Size = new System.Drawing.Size(136, 22);
			this.priComboBox3.TabIndex = 175;
			// 
			// priComboBox1
			// 
			this.priComboBox1.BackColor = System.Drawing.Color.White;
			this.priComboBox1.DataField = "status";
			this.priComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.priComboBox1.Location = new System.Drawing.Point(584, 48);
			this.priComboBox1.Name = "priComboBox1";
			this.priComboBox1.Size = new System.Drawing.Size(136, 22);
			this.priComboBox1.TabIndex = 174;
			this.priComboBox1.SelectionChangeCommitted += new System.EventHandler(this.priComboBox1_SelectionChangeCommitted);
			// 
			// comboBox1
			// 
			this.comboBox1.BackColor = System.Drawing.Color.White;
			this.comboBox1.DataField = "client_id";
			this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBox1.Location = new System.Drawing.Point(96, 96);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(168, 22);
			this.comboBox1.TabIndex = 173;
			this.comboBox1.SelectionChangeCommitted += new System.EventHandler(this.comboBox1_SelectionChangeCommitted);
			// 
			// label28
			// 
			this.label28.BackColor = System.Drawing.Color.Transparent;
			this.label28.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.label28.Location = new System.Drawing.Point(544, 216);
			this.label28.Name = "label28";
			this.label28.Size = new System.Drawing.Size(64, 23);
			this.label28.TabIndex = 172;
			this.label28.Text = "审核时间";
			this.label28.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txt18
			// 
			this.txt18.BackColor = System.Drawing.Color.White;
			this.txt18.DataField = "approvedon";
			this.txt18.DataType = TJSystem.Public.DataType.String;
			this.txt18.Enabled = false;
			this.txt18.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.txt18.Location = new System.Drawing.Point(616, 216);
			this.txt18.Name = "txt18";
			this.txt18.Size = new System.Drawing.Size(104, 23);
			this.txt18.TabIndex = 171;
			this.txt18.Text = "";
			// 
			// label29
			// 
			this.label29.BackColor = System.Drawing.Color.Transparent;
			this.label29.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.label29.Location = new System.Drawing.Point(376, 216);
			this.label29.Name = "label29";
			this.label29.Size = new System.Drawing.Size(48, 23);
			this.label29.TabIndex = 170;
			this.label29.Text = "审核者";
			this.label29.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label34
			// 
			this.label34.BackColor = System.Drawing.Color.Transparent;
			this.label34.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.label34.ForeColor = System.Drawing.Color.Blue;
			this.label34.Location = new System.Drawing.Point(280, 72);
			this.label34.Name = "label34";
			this.label34.Size = new System.Drawing.Size(64, 23);
			this.label34.TabIndex = 166;
			this.label34.Text = "运输方式";
			this.label34.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label32
			// 
			this.label32.BackColor = System.Drawing.Color.Transparent;
			this.label32.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.label32.Location = new System.Drawing.Point(56, 192);
			this.label32.Name = "label32";
			this.label32.Size = new System.Drawing.Size(40, 23);
			this.label32.TabIndex = 156;
			this.label32.Text = "备注";
			this.label32.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txt14
			// 
			this.txt14.BackColor = System.Drawing.Color.White;
			this.txt14.DataField = "remark";
			this.txt14.DataType = TJSystem.Public.DataType.String;
			this.txt14.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.txt14.Location = new System.Drawing.Point(96, 192);
			this.txt14.Name = "txt14";
			this.txt14.Size = new System.Drawing.Size(624, 23);
			this.txt14.TabIndex = 157;
			this.txt14.Text = "";
			// 
			// label16
			// 
			this.label16.BackColor = System.Drawing.Color.Transparent;
			this.label16.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.label16.Location = new System.Drawing.Point(24, 168);
			this.label16.Name = "label16";
			this.label16.Size = new System.Drawing.Size(64, 23);
			this.label16.TabIndex = 134;
			this.label16.Text = "目的地";
			this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txt12
			// 
			this.txt12.BackColor = System.Drawing.Color.White;
			this.txt12.Cursor = System.Windows.Forms.Cursors.Arrow;
			this.txt12.DataField = "destination";
			this.txt12.DataType = TJSystem.Public.DataType.String;
			this.txt12.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.txt12.Location = new System.Drawing.Point(96, 168);
			this.txt12.Name = "txt12";
			this.txt12.Size = new System.Drawing.Size(624, 23);
			this.txt12.TabIndex = 135;
			this.txt12.Text = "";
			// 
			// label23
			// 
			this.label23.BackColor = System.Drawing.Color.Transparent;
			this.label23.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.label23.Location = new System.Drawing.Point(528, 144);
			this.label23.Name = "label23";
			this.label23.Size = new System.Drawing.Size(48, 23);
			this.label23.TabIndex = 131;
			this.label23.Text = "币种";
			this.label23.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label24
			// 
			this.label24.BackColor = System.Drawing.Color.Transparent;
			this.label24.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.label24.Location = new System.Drawing.Point(520, 72);
			this.label24.Name = "label24";
			this.label24.Size = new System.Drawing.Size(56, 23);
			this.label24.TabIndex = 130;
			this.label24.Text = "唛头";
			this.label24.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txt11
			// 
			this.txt11.BackColor = System.Drawing.Color.White;
			this.txt11.DataField = "marks";
			this.txt11.DataType = TJSystem.Public.DataType.String;
			this.txt11.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.txt11.Location = new System.Drawing.Point(584, 72);
			this.txt11.Name = "txt11";
			this.txt11.Size = new System.Drawing.Size(136, 23);
			this.txt11.TabIndex = 133;
			this.txt11.Text = "";
			// 
			// label18
			// 
			this.label18.BackColor = System.Drawing.Color.Transparent;
			this.label18.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.label18.ForeColor = System.Drawing.Color.Blue;
			this.label18.Location = new System.Drawing.Point(24, 72);
			this.label18.Name = "label18";
			this.label18.Size = new System.Drawing.Size(64, 23);
			this.label18.TabIndex = 126;
			this.label18.Text = "仓库代码";
			this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label19
			// 
			this.label19.BackColor = System.Drawing.Color.Transparent;
			this.label19.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.label19.Location = new System.Drawing.Point(296, 96);
			this.label19.Name = "label19";
			this.label19.Size = new System.Drawing.Size(48, 23);
			this.label19.TabIndex = 123;
			this.label19.Text = "名称";
			this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txt5
			// 
			this.txt5.BackColor = System.Drawing.Color.White;
			this.txt5.DataField = "client_name";
			this.txt5.DataType = TJSystem.Public.DataType.String;
			this.txt5.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.txt5.Location = new System.Drawing.Point(352, 96);
			this.txt5.Name = "txt5";
			this.txt5.Size = new System.Drawing.Size(368, 23);
			this.txt5.TabIndex = 124;
			this.txt5.Text = "";
			// 
			// label5
			// 
			this.label5.BackColor = System.Drawing.Color.Transparent;
			this.label5.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.label5.ForeColor = System.Drawing.Color.Blue;
			this.label5.Location = new System.Drawing.Point(528, 48);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(48, 23);
			this.label5.TabIndex = 118;
			this.label5.Text = "状态";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label21
			// 
			this.label21.BackColor = System.Drawing.Color.Transparent;
			this.label21.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.label21.Location = new System.Drawing.Point(200, 240);
			this.label21.Name = "label21";
			this.label21.Size = new System.Drawing.Size(64, 23);
			this.label21.TabIndex = 42;
			this.label21.Text = "修改时间";
			this.label21.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txt20
			// 
			this.txt20.BackColor = System.Drawing.Color.White;
			this.txt20.DataField = "modifyon";
			this.txt20.DataType = TJSystem.Public.DataType.String;
			this.txt20.Enabled = false;
			this.txt20.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.txt20.Location = new System.Drawing.Point(264, 240);
			this.txt20.Name = "txt20";
			this.txt20.Size = new System.Drawing.Size(104, 23);
			this.txt20.TabIndex = 41;
			this.txt20.Text = "";
			// 
			// label20
			// 
			this.label20.BackColor = System.Drawing.Color.Transparent;
			this.label20.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.label20.Location = new System.Drawing.Point(200, 216);
			this.label20.Name = "label20";
			this.label20.Size = new System.Drawing.Size(64, 23);
			this.label20.TabIndex = 40;
			this.label20.Text = "创建时间";
			this.label20.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txt16
			// 
			this.txt16.BackColor = System.Drawing.Color.White;
			this.txt16.DataField = "createon";
			this.txt16.DataType = TJSystem.Public.DataType.String;
			this.txt16.Enabled = false;
			this.txt16.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.txt16.Location = new System.Drawing.Point(264, 216);
			this.txt16.Name = "txt16";
			this.txt16.Size = new System.Drawing.Size(104, 23);
			this.txt16.TabIndex = 39;
			this.txt16.Text = "";
			// 
			// label17
			// 
			this.label17.BackColor = System.Drawing.Color.Transparent;
			this.label17.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.label17.Location = new System.Drawing.Point(16, 240);
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
			this.label15.Location = new System.Drawing.Point(8, 216);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(80, 23);
			this.label15.TabIndex = 29;
			this.label15.Text = "创建者";
			this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label11
			// 
			this.label11.BackColor = System.Drawing.Color.Transparent;
			this.label11.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.label11.ForeColor = System.Drawing.Color.Blue;
			this.label11.Location = new System.Drawing.Point(8, 96);
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
			this.label8.Location = new System.Drawing.Point(280, 48);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(64, 23);
			this.label8.TabIndex = 22;
			this.label8.Text = "出库日期";
			this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label7
			// 
			this.label7.BackColor = System.Drawing.Color.Transparent;
			this.label7.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.label7.ForeColor = System.Drawing.Color.Blue;
			this.label7.Location = new System.Drawing.Point(40, 144);
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
			this.label2.Text = "出库单号";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txt15
			// 
			this.txt15.BackColor = System.Drawing.Color.White;
			this.txt15.DataField = "createBy";
			this.txt15.DataType = TJSystem.Public.DataType.String;
			this.txt15.Enabled = false;
			this.txt15.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.txt15.Location = new System.Drawing.Point(96, 216);
			this.txt15.Name = "txt15";
			this.txt15.Size = new System.Drawing.Size(96, 23);
			this.txt15.TabIndex = 12;
			this.txt15.Text = "";
			// 
			// txt19
			// 
			this.txt19.BackColor = System.Drawing.Color.White;
			this.txt19.DataField = "modifyBy";
			this.txt19.DataType = TJSystem.Public.DataType.String;
			this.txt19.Enabled = false;
			this.txt19.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.txt19.Location = new System.Drawing.Point(96, 240);
			this.txt19.Name = "txt19";
			this.txt19.Size = new System.Drawing.Size(96, 23);
			this.txt19.TabIndex = 9;
			this.txt19.Text = "";
			// 
			// txt1
			// 
			this.txt1.BackColor = System.Drawing.Color.White;
			this.txt1.DataField = "stock_code";
			this.txt1.DataType = TJSystem.Public.DataType.String;
			this.txt1.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.txt1.Location = new System.Drawing.Point(96, 48);
			this.txt1.Name = "txt1";
			this.txt1.Size = new System.Drawing.Size(168, 23);
			this.txt1.TabIndex = 100;
			this.txt1.Text = "";
			// 
			// priComboBox8
			// 
			this.priComboBox8.BackColor = System.Drawing.Color.White;
			this.priComboBox8.DataField = "forwarder_id";
			this.priComboBox8.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.priComboBox8.Location = new System.Drawing.Point(96, 120);
			this.priComboBox8.Name = "priComboBox8";
			this.priComboBox8.Size = new System.Drawing.Size(168, 22);
			this.priComboBox8.TabIndex = 173;
			this.priComboBox8.SelectionChangeCommitted += new System.EventHandler(this.priComboBox8_SelectionChangeCommitted);
			// 
			// label6
			// 
			this.label6.BackColor = System.Drawing.Color.Transparent;
			this.label6.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.label6.ForeColor = System.Drawing.Color.Blue;
			this.label6.Location = new System.Drawing.Point(8, 120);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(80, 23);
			this.label6.TabIndex = 25;
			this.label6.Text = "运输商";
			this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label9
			// 
			this.label9.BackColor = System.Drawing.Color.Transparent;
			this.label9.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.label9.Location = new System.Drawing.Point(296, 120);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(48, 23);
			this.label9.TabIndex = 123;
			this.label9.Text = "名称";
			this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// priTextBox1
			// 
			this.priTextBox1.BackColor = System.Drawing.Color.White;
			this.priTextBox1.DataField = "forwarder_name";
			this.priTextBox1.DataType = TJSystem.Public.DataType.String;
			this.priTextBox1.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.priTextBox1.Location = new System.Drawing.Point(352, 120);
			this.priTextBox1.Name = "priTextBox1";
			this.priTextBox1.Size = new System.Drawing.Size(368, 23);
			this.priTextBox1.TabIndex = 124;
			this.priTextBox1.Text = "";
			// 
			// label10
			// 
			this.label10.BackColor = System.Drawing.Color.Transparent;
			this.label10.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.label10.Location = new System.Drawing.Point(296, 144);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(48, 23);
			this.label10.TabIndex = 21;
			this.label10.Text = "姓名";
			this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// priTextBox2
			// 
			this.priTextBox2.BackColor = System.Drawing.Color.White;
			this.priTextBox2.DataField = "contact_name";
			this.priTextBox2.DataType = TJSystem.Public.DataType.String;
			this.priTextBox2.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.priTextBox2.Location = new System.Drawing.Point(352, 144);
			this.priTextBox2.Name = "priTextBox2";
			this.priTextBox2.Size = new System.Drawing.Size(160, 23);
			this.priTextBox2.TabIndex = 104;
			this.priTextBox2.Text = "";
			// 
			// priComboBox6
			// 
			this.priComboBox6.BackColor = System.Drawing.Color.White;
			this.priComboBox6.DataField = "contact_id";
			this.priComboBox6.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.priComboBox6.Location = new System.Drawing.Point(96, 144);
			this.priComboBox6.Name = "priComboBox6";
			this.priComboBox6.Size = new System.Drawing.Size(168, 22);
			this.priComboBox6.TabIndex = 173;
			this.priComboBox6.SelectionChangeCommitted += new System.EventHandler(this.priComboBox6_SelectionChangeCommitted);
			// 
			// priTextBox3
			// 
			this.priTextBox3.BackColor = System.Drawing.Color.White;
			this.priTextBox3.DataField = "approvedBy";
			this.priTextBox3.DataType = TJSystem.Public.DataType.String;
			this.priTextBox3.Enabled = false;
			this.priTextBox3.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.priTextBox3.Location = new System.Drawing.Point(432, 216);
			this.priTextBox3.Name = "priTextBox3";
			this.priTextBox3.Size = new System.Drawing.Size(104, 23);
			this.priTextBox3.TabIndex = 41;
			this.priTextBox3.Text = "";
			// 
			// frmStockSellOut
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
			this.Name = "frmStockSellOut";
			this.Text = "销售出库";
			this.panel3.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).EndInit();
			this.panel4.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		private void dataGrid1_Click(object sender, System.EventArgs e)
		{
			
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
				TJSystem.Public.PublicStatic.formName = "销售出库";
			}
			base.OnClosing (e);
		}

		private void comboBox1_SelectionChangeCommitted(object sender, System.EventArgs e)
		{
			string sql = "select CLIENT_ID,CLIENT_NAME from basic_client  where CLIENT_ID='" +  comboBox1.SelectedValue.ToString() + "'";
			DataTable dt = TJSystem.Public.PublicStatic.db.GetDataTable(sql);
			if(dt.Rows.Count != 1)
			{
				this.txt5.Text = "";
				return;
			}
			this.txt5.Text = dt.Rows[0][1].ToString();
		}

		private void linkLabel2_LinkClicked(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
		{
			if(this.txt1.Text.Trim().Equals(""))
			{
				MessageBox.Show("未选择出库单号","Error",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
				return;
			}
			frmStockSellOutList frm = new frmStockSellOutList(this.txt1.Text);
			frm.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			frm.ShowDialog();
		}

		private void panel4_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
		{
		
		}

		private void priComboBox8_SelectionChangeCommitted(object sender, System.EventArgs e)
		{
			priComboBox6.Enabled = true;
			System.Data.DataRow dr = null;
			System.Data.DataTable dtcpy = null;
			string sql = "select forwarder_id,CONTACT_ID,CONTACT_ID+' '+CONTACT_NAME as CONTACT_NAME from basic_forwarder_contact";
			sql += " where forwarder_id = '" + priComboBox8.SelectedValue.ToString() + "'";
			System.Data.DataTable dt = TJSystem.Public.PublicStatic.db.GetDataTable(sql);
			dr = dt.NewRow() ;
			dr[0] = "" ;
			dr[1] = "" ;
			dt.Rows.InsertAt(dr,0) ;
			dtcpy = dt.Copy();
			this.priComboBox6.DataSource = dtcpy.DefaultView;
			this.priComboBox6.ValueMember = "CONTACT_ID";
			this.priComboBox6.DisplayMember = "CONTACT_NAME";

			sql = "select forwarder_id,forwarder_name from basic_forwarder where forwarder_id='" +  priComboBox8.SelectedValue.ToString() + "'";
			dt = TJSystem.Public.PublicStatic.db.GetDataTable(sql);
			if(dt.Rows.Count != 1)
			{
				this.priTextBox1.Text = "";
				return;
			}
			this.priTextBox1.Text = dt.Rows[0][1].ToString();
		}

		private void priComboBox6_SelectionChangeCommitted(object sender, System.EventArgs e)
		{
			string sql = "select forwarder_id,CONTACT_ID,CONTACT_ID+' '+CONTACT_NAME as CONTACT_NAME from basic_forwarder_contact";
			sql += " where forwarder_id = '" + this.priComboBox8.SelectedValue.ToString() + "' and CONTACT_ID='" + priComboBox6.SelectedValue.ToString() + "'";
			DataTable dt = TJSystem.Public.PublicStatic.db.GetDataTable(sql);
			if(dt.Rows.Count != 1)
			{
				this.priTextBox2.Text = "";
				return;
			}
			this.priTextBox2.Text = dt.Rows[0][1].ToString();
		}

		private void priComboBox1_SelectionChangeCommitted(object sender, System.EventArgs e)
		{
			TJSystem.Public.PublicStatic.SetApprovedInfo(this.priComboBox1,this.priTextBox3,this.txt18);
		}
		
	}
}

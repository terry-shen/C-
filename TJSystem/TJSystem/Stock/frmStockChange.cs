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
	public class frmStockChange : System.Windows.Forms.Form
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
		private System.Windows.Forms.Label label32;
		private System.Windows.Forms.Label label16;
		private System.Windows.Forms.Label label18;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label21;
		private System.Windows.Forms.Label label20;
		private System.Windows.Forms.Label label17;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label2;
		private TJSystem.Classes.PriTextBox txt1;
		
		private TJSystem.Classes.PriTextBox txt14;
		private TJSystem.Classes.PriTextBox txt12;
		private TJSystem.Classes.PriTextBox txt18;
		private TJSystem.Classes.PriTextBox txt20;
		private TJSystem.Classes.PriTextBox txt16;
		private TJSystem.Classes.PriTextBox txt15;
		private TJSystem.Classes.PriTextBox txt19;
		public static System.Windows.Forms.Form frmCurrent = null ;
		private TJSystem.Classes.PriComboBox priComboBox1;
		private TJSystem.Classes.PriComboBox priComboBox2;
		private string _PK;
		private string _table = null;
		private System.Windows.Forms.DataGridTableStyle dataGridTableStyle1;
		private System.Windows.Forms.DataGridTextBoxColumn status_name;
		private System.Windows.Forms.DataGridTextBoxColumn remark;
		private System.Windows.Forms.DataGridTextBoxColumn createBy;
		private System.Windows.Forms.DataGridTextBoxColumn createon;
		private System.Windows.Forms.DataGridTextBoxColumn approvedon;
		private System.Windows.Forms.DataGridTextBoxColumn modifyBy;
		private System.Windows.Forms.DataGridTextBoxColumn modifyon;
		private System.Windows.Forms.LinkLabel linkLabel2;
		private TJSystem.Classes.PriDateTimePicker priDateTimePicker3;
		private TJSystem.Classes.PriTextBox priTextBox1;
		private System.Windows.Forms.DataGridTextBoxColumn wh_name;
		private System.Windows.Forms.DataGridTextBoxColumn reason;
		private System.Windows.Forms.DataGridTextBoxColumn approvedby;
		private System.Windows.Forms.LinkLabel linkLabel1;
		private System.Windows.Forms.DataGridTextBoxColumn stock_code;
		private System.Windows.Forms.DataGridTextBoxColumn stock_date;
		private string _statusType = null;
		private TJSystem.Classes.PriTextBox priTextBox2;
		private string _eventtype = null;

		public frmStockChange()
		{
			//
			// Windows 窗体设计器支持所必需的
			//
			InitializeComponent();

			_statusType = "stock";
			_eventtype = "MOVE";
			

			TJSystem.Public.PublicStatic.setBackgroundImg(this.panel1,this.panel1.GetType().ToString(),"images\\bg.gif");
			TJSystem.Public.PublicStatic.setBackgroundImg(this.panel2,this.panel1.GetType().ToString(),"");
			TJSystem.Public.PublicStatic.setBackgroundImg(this.panel3,this.panel1.GetType().ToString(),"");
			TJSystem.Public.PublicStatic.setBackgroundImg(this.panel4,this.panel1.GetType().ToString(),"");

			InitialFormData();
			System.Text.StringBuilder sb = new System.Text.StringBuilder();
			sb.Append("select a.stock_code,a.stock_date,a.event_type,a.status,c.status_name,a.wh_code,b.wh_name,a.reason,a.remark,a.approvedby,a.approvedon,");
			sb.Append(" a.createby, a.createon,a.modifyby,a.modifyon");
			sb.Append("  from wip_stock_mstr a");
			sb.Append(" left join basic_whouse b on a.wh_code=b.wh_code");            
			sb.Append(" left join p_status c on a.status=c.status_id and c.status_type=");
			sb.Append("'");
			sb.Append(_statusType);
			sb.Append("'" );		
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
			}	
			return true;
		}


		private void setDisable()
		{
			this.txt1.Enabled = false;
			this.txt12.Enabled = false;
			this.txt14.Enabled = false;
			this.txt15.Enabled = false;
			this.txt16.Enabled = false;			
			this.txt18.Enabled = false;
			this.txt19.Enabled = false;
			this.txt20.Enabled = false;
			this.priComboBox1.Enabled = false;
			this.priComboBox2.Enabled = false;
			this.priTextBox1.Enabled = false;
			this.priDateTimePicker3.Enabled = false;
		}

		private void AfterButtonClick(string ButtonType)
		{
			if(ButtonType.Equals("insert"))
			{
				this.txt1.Enabled = true;				
				this.txt12.Enabled = true;				
				this.txt14.Enabled = true;
				this.priComboBox1.Enabled = false;
				this.priComboBox2.Enabled = true;
				this.priDateTimePicker3.Enabled = true;

				this.txt1.Text = "";	
				this.txt12.Text = "";
				this.txt14.Text = "";
				this.priComboBox1.SelectedValue = "1";
				this.priComboBox2.Text = "";
				this.priDateTimePicker3.Value = System.DateTime.Now;
			}
			else if(ButtonType.Equals("update"))
			{
				this.txt1.Enabled = false;
				this.txt12.Enabled = true;
				this.txt14.Enabled = true;
				this.priComboBox1.Enabled = false;
				this.priComboBox2.Enabled = true;
				this.priDateTimePicker3.Enabled = true;
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(frmStockChange));
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
			this.reason = new System.Windows.Forms.DataGridTextBoxColumn();
			this.remark = new System.Windows.Forms.DataGridTextBoxColumn();
			this.approvedby = new System.Windows.Forms.DataGridTextBoxColumn();
			this.approvedon = new System.Windows.Forms.DataGridTextBoxColumn();
			this.createBy = new System.Windows.Forms.DataGridTextBoxColumn();
			this.createon = new System.Windows.Forms.DataGridTextBoxColumn();
			this.modifyBy = new System.Windows.Forms.DataGridTextBoxColumn();
			this.modifyon = new System.Windows.Forms.DataGridTextBoxColumn();
			this.panel4 = new System.Windows.Forms.Panel();
			this.priTextBox2 = new TJSystem.Classes.PriTextBox();
			this.linkLabel1 = new System.Windows.Forms.LinkLabel();
			this.priDateTimePicker3 = new TJSystem.Classes.PriDateTimePicker();
			this.linkLabel2 = new System.Windows.Forms.LinkLabel();
			this.priComboBox2 = new TJSystem.Classes.PriComboBox();
			this.priComboBox1 = new TJSystem.Classes.PriComboBox();
			this.label28 = new System.Windows.Forms.Label();
			this.txt18 = new TJSystem.Classes.PriTextBox();
			this.label29 = new System.Windows.Forms.Label();
			this.label32 = new System.Windows.Forms.Label();
			this.txt14 = new TJSystem.Classes.PriTextBox();
			this.label16 = new System.Windows.Forms.Label();
			this.txt12 = new TJSystem.Classes.PriTextBox();
			this.label18 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label21 = new System.Windows.Forms.Label();
			this.txt20 = new TJSystem.Classes.PriTextBox();
			this.label20 = new System.Windows.Forms.Label();
			this.txt16 = new TJSystem.Classes.PriTextBox();
			this.label17 = new System.Windows.Forms.Label();
			this.label15 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.txt15 = new TJSystem.Classes.PriTextBox();
			this.txt19 = new TJSystem.Classes.PriTextBox();
			this.txt1 = new TJSystem.Classes.PriTextBox();
			this.priTextBox1 = new TJSystem.Classes.PriTextBox();
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
			this.label1.Text = "库存调整";
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
			this.dataGrid1.CaptionText = "库存调整";
			this.dataGrid1.CaptionVisible = false;
			this.dataGrid1.DataMember = "";
			this.dataGrid1.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.dataGrid1.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.dataGrid1.Location = new System.Drawing.Point(0, 176);
			this.dataGrid1.Name = "dataGrid1";
			this.dataGrid1.ReadOnly = true;
			this.dataGrid1.Size = new System.Drawing.Size(792, 344);
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
																												  this.reason,
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
			this.stock_code.HeaderText = "调整单号";
			this.stock_code.MappingName = "stock_code";
			this.stock_code.NullText = "";
			this.stock_code.Width = 75;
			// 
			// stock_date
			// 
			this.stock_date.Format = "";
			this.stock_date.FormatInfo = null;
			this.stock_date.HeaderText = "调整日期";
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
			// reason
			// 
			this.reason.Format = "";
			this.reason.FormatInfo = null;
			this.reason.HeaderText = "原因";
			this.reason.MappingName = "reason";
			this.reason.NullText = "";
			this.reason.Width = 75;
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
			this.panel4.Controls.Add(this.priTextBox2);
			this.panel4.Controls.Add(this.linkLabel1);
			this.panel4.Controls.Add(this.priDateTimePicker3);
			this.panel4.Controls.Add(this.linkLabel2);
			this.panel4.Controls.Add(this.priComboBox2);
			this.panel4.Controls.Add(this.priComboBox1);
			this.panel4.Controls.Add(this.label28);
			this.panel4.Controls.Add(this.txt18);
			this.panel4.Controls.Add(this.label29);
			this.panel4.Controls.Add(this.label32);
			this.panel4.Controls.Add(this.txt14);
			this.panel4.Controls.Add(this.label16);
			this.panel4.Controls.Add(this.txt12);
			this.panel4.Controls.Add(this.label18);
			this.panel4.Controls.Add(this.label5);
			this.panel4.Controls.Add(this.label21);
			this.panel4.Controls.Add(this.txt20);
			this.panel4.Controls.Add(this.label20);
			this.panel4.Controls.Add(this.txt16);
			this.panel4.Controls.Add(this.label17);
			this.panel4.Controls.Add(this.label15);
			this.panel4.Controls.Add(this.label8);
			this.panel4.Controls.Add(this.label2);
			this.panel4.Controls.Add(this.txt15);
			this.panel4.Controls.Add(this.txt19);
			this.panel4.Controls.Add(this.txt1);
			this.panel4.Controls.Add(this.priTextBox1);
			this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel4.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.panel4.Location = new System.Drawing.Point(0, 0);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(788, 176);
			this.panel4.TabIndex = 0;
			// 
			// priTextBox2
			// 
			this.priTextBox2.BackColor = System.Drawing.Color.White;
			this.priTextBox2.DataField = "event_type";
			this.priTextBox2.DataType = TJSystem.Public.DataType.String;
			this.priTextBox2.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.priTextBox2.Location = new System.Drawing.Point(96, 192);
			this.priTextBox2.Name = "priTextBox2";
			this.priTextBox2.Size = new System.Drawing.Size(112, 23);
			this.priTextBox2.TabIndex = 218;
			this.priTextBox2.Text = "MOVE";
			// 
			// linkLabel1
			// 
			this.linkLabel1.BackColor = System.Drawing.Color.Transparent;
			this.linkLabel1.Location = new System.Drawing.Point(648, 48);
			this.linkLabel1.Name = "linkLabel1";
			this.linkLabel1.Size = new System.Drawing.Size(72, 23);
			this.linkLabel1.TabIndex = 217;
			this.linkLabel1.TabStop = true;
			this.linkLabel1.Text = "调整出库";
			this.linkLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
			// 
			// priDateTimePicker3
			// 
			this.priDateTimePicker3.CustomFormat = "yyyy-MM-dd";
			this.priDateTimePicker3.DataField = "stock_date";
			this.priDateTimePicker3.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.priDateTimePicker3.Location = new System.Drawing.Point(272, 48);
			this.priDateTimePicker3.Name = "priDateTimePicker3";
			this.priDateTimePicker3.Size = new System.Drawing.Size(112, 23);
			this.priDateTimePicker3.TabIndex = 216;
			// 
			// linkLabel2
			// 
			this.linkLabel2.BackColor = System.Drawing.Color.Transparent;
			this.linkLabel2.Location = new System.Drawing.Point(560, 48);
			this.linkLabel2.Name = "linkLabel2";
			this.linkLabel2.Size = new System.Drawing.Size(72, 23);
			this.linkLabel2.TabIndex = 178;
			this.linkLabel2.TabStop = true;
			this.linkLabel2.Text = "调整入库";
			this.linkLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
			// 
			// priComboBox2
			// 
			this.priComboBox2.BackColor = System.Drawing.Color.White;
			this.priComboBox2.DataField = "WH_code";
			this.priComboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.priComboBox2.Location = new System.Drawing.Point(96, 72);
			this.priComboBox2.Name = "priComboBox2";
			this.priComboBox2.Size = new System.Drawing.Size(112, 22);
			this.priComboBox2.TabIndex = 176;
			// 
			// priComboBox1
			// 
			this.priComboBox1.BackColor = System.Drawing.Color.White;
			this.priComboBox1.DataField = "status";
			this.priComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.priComboBox1.Location = new System.Drawing.Point(448, 48);
			this.priComboBox1.Name = "priComboBox1";
			this.priComboBox1.Size = new System.Drawing.Size(104, 22);
			this.priComboBox1.TabIndex = 174;
			this.priComboBox1.SelectionChangeCommitted += new System.EventHandler(this.priComboBox1_SelectionChangeCommitted);
			// 
			// label28
			// 
			this.label28.BackColor = System.Drawing.Color.Transparent;
			this.label28.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.label28.Location = new System.Drawing.Point(536, 120);
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
			this.txt18.Location = new System.Drawing.Point(600, 120);
			this.txt18.Name = "txt18";
			this.txt18.Size = new System.Drawing.Size(104, 23);
			this.txt18.TabIndex = 171;
			this.txt18.Text = "";
			// 
			// label29
			// 
			this.label29.BackColor = System.Drawing.Color.Transparent;
			this.label29.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.label29.Location = new System.Drawing.Point(376, 120);
			this.label29.Name = "label29";
			this.label29.Size = new System.Drawing.Size(48, 23);
			this.label29.TabIndex = 170;
			this.label29.Text = "审核者";
			this.label29.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label32
			// 
			this.label32.BackColor = System.Drawing.Color.Transparent;
			this.label32.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.label32.Location = new System.Drawing.Point(48, 96);
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
			this.txt14.Location = new System.Drawing.Point(96, 96);
			this.txt14.Name = "txt14";
			this.txt14.Size = new System.Drawing.Size(624, 23);
			this.txt14.TabIndex = 157;
			this.txt14.Text = "";
			// 
			// label16
			// 
			this.label16.BackColor = System.Drawing.Color.Transparent;
			this.label16.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.label16.Location = new System.Drawing.Point(208, 72);
			this.label16.Name = "label16";
			this.label16.Size = new System.Drawing.Size(64, 23);
			this.label16.TabIndex = 134;
			this.label16.Text = "原因";
			this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txt12
			// 
			this.txt12.BackColor = System.Drawing.Color.White;
			this.txt12.Cursor = System.Windows.Forms.Cursors.Cross;
			this.txt12.DataField = "reason";
			this.txt12.DataType = TJSystem.Public.DataType.String;
			this.txt12.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.txt12.Location = new System.Drawing.Point(272, 72);
			this.txt12.Name = "txt12";
			this.txt12.Size = new System.Drawing.Size(448, 23);
			this.txt12.TabIndex = 135;
			this.txt12.Text = "";
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
			// label21
			// 
			this.label21.BackColor = System.Drawing.Color.Transparent;
			this.label21.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.label21.Location = new System.Drawing.Point(200, 144);
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
			this.txt20.Location = new System.Drawing.Point(264, 144);
			this.txt20.Name = "txt20";
			this.txt20.Size = new System.Drawing.Size(104, 23);
			this.txt20.TabIndex = 41;
			this.txt20.Text = "";
			// 
			// label20
			// 
			this.label20.BackColor = System.Drawing.Color.Transparent;
			this.label20.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.label20.Location = new System.Drawing.Point(200, 120);
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
			this.txt16.Location = new System.Drawing.Point(264, 120);
			this.txt16.Name = "txt16";
			this.txt16.Size = new System.Drawing.Size(104, 23);
			this.txt16.TabIndex = 39;
			this.txt16.Text = "";
			// 
			// label17
			// 
			this.label17.BackColor = System.Drawing.Color.Transparent;
			this.label17.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.label17.Location = new System.Drawing.Point(16, 144);
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
			this.label15.Location = new System.Drawing.Point(8, 120);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(80, 23);
			this.label15.TabIndex = 29;
			this.label15.Text = "创建者";
			this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label8
			// 
			this.label8.BackColor = System.Drawing.Color.Transparent;
			this.label8.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.label8.ForeColor = System.Drawing.Color.Blue;
			this.label8.Location = new System.Drawing.Point(208, 48);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(64, 23);
			this.label8.TabIndex = 22;
			this.label8.Text = "调整日期";
			this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
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
			this.label2.Text = "调整单号";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txt15
			// 
			this.txt15.BackColor = System.Drawing.Color.White;
			this.txt15.DataField = "createBy";
			this.txt15.DataType = TJSystem.Public.DataType.String;
			this.txt15.Enabled = false;
			this.txt15.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.txt15.Location = new System.Drawing.Point(96, 120);
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
			this.txt19.Location = new System.Drawing.Point(96, 144);
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
			this.txt1.Size = new System.Drawing.Size(112, 23);
			this.txt1.TabIndex = 100;
			this.txt1.Text = "";
			// 
			// priTextBox1
			// 
			this.priTextBox1.BackColor = System.Drawing.Color.White;
			this.priTextBox1.DataField = "approvedBy";
			this.priTextBox1.DataType = TJSystem.Public.DataType.String;
			this.priTextBox1.Enabled = false;
			this.priTextBox1.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.priTextBox1.Location = new System.Drawing.Point(424, 120);
			this.priTextBox1.Name = "priTextBox1";
			this.priTextBox1.Size = new System.Drawing.Size(104, 23);
			this.priTextBox1.TabIndex = 41;
			this.priTextBox1.Text = "";
			// 
			// frmStockChange
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
			this.Name = "frmStockChange";
			this.Text = "库存调整";
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
				TJSystem.Public.PublicStatic.formName = "库存调整";
			}
			base.OnClosing (e);
		}

		

		private void linkLabel2_LinkClicked(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
		{
			if(this.txt1.Text.Trim().Equals(""))
			{
				MessageBox.Show("未选择调整单号","Error",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
				return;
			}
			frmStockChangeINList frm = new frmStockChangeINList(this.txt1.Text);
			frm.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			frm.ShowDialog();
		}

		private void linkLabel1_LinkClicked(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
		{
			if(this.txt1.Text.Trim().Equals(""))
			{
				MessageBox.Show("未选择调整单号","Error",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
				return;
			}
			frmStockChangeOutList frm = new frmStockChangeOutList(this.txt1.Text);
			frm.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			frm.ShowDialog();
			
		}

		private void priComboBox1_SelectionChangeCommitted(object sender, System.EventArgs e)
		{
			TJSystem.Public.PublicStatic.SetApprovedInfo(this.priComboBox1,this.priTextBox1,this.txt18);
		}
		
	}
}

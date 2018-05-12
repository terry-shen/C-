using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace TJSystem.Account
{
	/// <summary>
	
	/// </summary>
	public class frmGatheringPaymentBill : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Panel panel3;
		private TJSystem.UC.PriToolBar priToolBar1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.DataGridTableStyle dataGridTableStyle1;
		private System.Windows.Forms.DataGrid dataGrid1;
		private System.Windows.Forms.Panel panel4;
		private TJSystem.Classes.PriTextBox priTextBox9;
		private System.Windows.Forms.Label label22;
		private TJSystem.Classes.PriTextBox priTextBox8;
		private System.Windows.Forms.Label label20;
		private TJSystem.Classes.PriTextBox priTextBox4;
		private System.Windows.Forms.Label label14;
		private TJSystem.Classes.PriTextBox priTextBox5;
		private TJSystem.Classes.PriTextBox priTextBox3;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Label label2;
		private TJSystem.Classes.PriTextBox priTextBox1;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private TJSystem.Classes.PriTextBox priTextBox11;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label8;
		private TJSystem.Classes.PriTextBox priTextBox13;
		private System.Windows.Forms.Label label10;
		private TJSystem.Classes.PriTextBox priTextBox14;
		private System.Windows.Forms.Label label11;
		/// <summary>
	
		/// </summary>
		private System.ComponentModel.Container components = null;
		private System.Windows.Forms.DataGridTextBoxColumn doc_no;
		private System.Windows.Forms.DataGridTextBoxColumn Amount;
		private System.Windows.Forms.DataGridTextBoxColumn crm_id;
		private System.Windows.Forms.DataGridTextBoxColumn voucher_no;
		private System.Windows.Forms.DataGridTextBoxColumn remark;
		private System.Windows.Forms.DataGridTextBoxColumn CreateBy;
		private System.Windows.Forms.DataGridTextBoxColumn CreateOn;
		private System.Windows.Forms.DataGridTextBoxColumn modifyOn;
		private System.Windows.Forms.DataGridTextBoxColumn modifyBy;
		private TJSystem.Classes.PriComboBox comboBox1;
		private TJSystem.Classes.PriComboBox priComboBox2;
		private TJSystem.Classes.PriComboBox priComboBox1;
		public static System.Windows.Forms.Form frmCurrent = null;
		private string _statusType = null;
		private string _table = null;
		private TJSystem.Classes.PriComboBox priComboBox3;
		private System.Windows.Forms.DataGridTextBoxColumn CURRENCY_NAMECN;
		private System.Windows.Forms.DataGridTextBoxColumn STATUS_NAME;
		private System.Windows.Forms.DataGridTextBoxColumn bearing_desc;
		private System.Windows.Forms.DataGridTextBoxColumn payrec_type_desc;
		private TJSystem.Classes.PriComboBox priComboBox4;
		private System.Windows.Forms.DataGridTextBoxColumn feetype_name;
		private string _PK = null;

		public frmGatheringPaymentBill()
		{
			_statusType = "account";
			InitializeComponent();

			

			InitialFormData();
			TJSystem.Public.PublicStatic.setBackgroundImg(this.panel1,this.panel1.GetType().ToString(),"images\\bg.gif");
			TJSystem.Public.PublicStatic.setBackgroundImg(this.panel2,this.panel1.GetType().ToString(),"");
			TJSystem.Public.PublicStatic.setBackgroundImg(this.panel3,this.panel1.GetType().ToString(),"");
			TJSystem.Public.PublicStatic.setBackgroundImg(this.panel4,this.panel1.GetType().ToString(),"");

			System.Text.StringBuilder sb = new System.Text.StringBuilder();
			sb.Append("select a.doc_type,d.feetype_name as feetype_name,a.payrec_type,a.bearing,");
			sb.Append(" case when a.payrec_type='P' then '付款' when a.payrec_type='R' then '收款' else '' end as payrec_type_desc,");
			sb.Append(" case when a.bearing='P' then '逆向（付）' when a.bearing='R' then '正向（收）' else '' end as bearing_desc,");
			sb.Append(" a.doc_no,a.Currency,c.CURRENCY_NAMECN as CURRENCY_NAMECN,a.Amount,a.Status,b.STATUS_NAME as STATUS_NAME,");
			sb.Append(" a.crm_type,a.crm_id,a.voucher_no,a.remark,CreateOn,CreateBy,modifyOn,modifyBy  ");
			sb.Append(" from finance_doc a");
			sb.Append(" left join p_status b on a.status=b.status_id and b.status_type=");
			sb.Append("'");
			sb.Append(this._statusType);
			sb.Append("'"); //'account'
			sb.Append(" left join p_currency c on a.Currency=c.CURRENCY_CODE");
			sb.Append(" left join p_feetype d on a.doc_type=d.feetype_id");
			sb.Append(" order by a.doc_no");
			this.InitialGrid(sb.ToString());
			_table = "finance_doc";
			_PK = "payrec_type,doc_no";
			priToolBar1.setCurrentForm = this;
			priToolBar1.Initial(_table,_PK,sb.ToString());
			priToolBar1.BeforeButtonClickEvent += new TJSystem.UC.PriToolBar.BeforeButotnClick(this.BeforeButtonClick);
			priToolBar1.AfterButtonClickEvent += new TJSystem.UC.PriToolBar.AfterButtonClick(this.AfterButtonClick);

			this.priToolBar1.setButtonVisibleFalse();;
			this.priToolBar1.setButtonVisible("012345689");
			setDisable();
		}
		
		private void setDisable()
		{
			this.priComboBox1.Enabled = false;
			this.priComboBox2.Enabled = false;
			this.priComboBox3.Enabled = false;
			this.priComboBox4.Enabled = false;
			this.comboBox1.Enabled = false;
			this.priTextBox1.Enabled = false;
			this.priTextBox11.Enabled = false;
			this.priTextBox13.Enabled = false;
			this.priTextBox14.Enabled = false;
			this.priTextBox3.Enabled = false;
			this.priTextBox4.Enabled = false;
			this.priTextBox5.Enabled = false;
			this.priTextBox8.Enabled = false;
			this.priTextBox9.Enabled = false;
		}

		private void InitialFormData()
		{
			DataTable dtcpy = null;
			DataRow dr = null;
			String sql = "select CURRENCY_CODE,CURRENCY_CODE+' '+CURRENCY_NAMECN as CURRENCY_NAMECN from p_currency order by CURRENCY_CODE";
			DataTable dt = TJSystem.Public.PublicStatic.db.GetDataTable(sql);
			dr = dt.NewRow() ;
			dr[0] = "" ;
			dr[1] = "" ;
			dt.Rows.InsertAt(dr,0) ;
			dtcpy = dt.Copy();
			this.priComboBox2.DataSource = dtcpy.DefaultView;
			this.priComboBox2.ValueMember = "CURRENCY_CODE";
			this.priComboBox2.DisplayMember = "CURRENCY_NAMECN";

			sql = "select STATUS_ID,STATUS_ID+' '+STATUS_NAME as STATUS_NAME from p_status where status_type = '" + this._statusType + "' order by STATUS_ID";
			dt = TJSystem.Public.PublicStatic.db.GetDataTable(sql);
			dr = dt.NewRow() ;
			dr[0] = "" ;
			dr[1] = "" ;
			dt.Rows.InsertAt(dr,0) ;
			dtcpy = dt.Copy();
			this.comboBox1.DataSource = dtcpy.DefaultView;
			this.comboBox1.ValueMember = "STATUS_ID";
			this.comboBox1.DisplayMember = "STATUS_NAME";

			sql = "select feetype_id,feetype_id+' '+feetype_name as feetype_name from p_feetype order by feetype_id";
			dt = TJSystem.Public.PublicStatic.db.GetDataTable(sql);
			dr = dt.NewRow() ;
			dr[0] = "" ;
			dr[1] = "" ;
			dt.Rows.InsertAt(dr,0) ;
			dtcpy = dt.Copy();
			this.priComboBox4.DataSource = dtcpy.DefaultView;
			this.priComboBox4.ValueMember = "feetype_id";
			this.priComboBox4.DisplayMember = "feetype_name";

			dt = new DataTable();
			dt.Columns.Add("PAYID");
			dt.Columns.Add("PAYNAME");
			dr = dt.NewRow() ;
			dr[0] = "P" ;
			dr[1] = "付款" ;
			dt.Rows.InsertAt(dr,0) ;
			dr = dt.NewRow() ;
			dr[0] = "R" ;
			dr[1] = "收款" ;
			dt.Rows.InsertAt(dr,0) ;
			dr = dt.NewRow() ;
			dr[0] = "" ;
			dr[1] = "" ;
			dt.Rows.InsertAt(dr,0) ;
			dtcpy = dt.Copy();
			this.priComboBox1.DataSource = dtcpy.DefaultView;
			this.priComboBox1.ValueMember = "PAYID";
			this.priComboBox1.DisplayMember = "PAYNAME";
			
			dt = new DataTable();
			dt.Columns.Add("PAYID");
			dt.Columns.Add("PAYNAME");
			dr = dt.NewRow() ;
			dr[0] = "P" ;
			dr[1] = "逆向（付）" ;
			dt.Rows.InsertAt(dr,0) ;
			dr = dt.NewRow() ;
			dr[0] = "R" ;
			dr[1] = "正向（收）" ;
			dt.Rows.InsertAt(dr,0) ;
			dr = dt.NewRow() ;
			dr[0] = "" ;
			dr[1] = "" ;
			dt.Rows.InsertAt(dr,0) ;
			dtcpy = dt.Copy();
			this.priComboBox3.DataSource = dtcpy.DefaultView;
			this.priComboBox3.ValueMember = "PAYID";
			this.priComboBox3.DisplayMember = "PAYNAME";

		}

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
					sb.Append("  系统中已存在该单据，请重新命名单据");
					TJSystem.Public.PublicStatic.ShowMessage(TJSystem.Public.MessageType.Error,sb.ToString());
					return false;
				}
			}

			if(sqltype.Equals("insert"))
			{
				
			}	
			return true;
		}

		private void AfterButtonClick(string sqltype)
		{
			if(sqltype.Equals("insert"))
			{
				this.priComboBox1.Enabled = true;
				this.priComboBox2.Enabled = true;
				this.priComboBox3.Enabled = true;
				this.priComboBox4.Enabled = true;
				this.comboBox1.Enabled = true;
				this.priTextBox1.Enabled = true;
				this.priTextBox11.Enabled = true;
				this.priTextBox13.Enabled = true;
				this.priTextBox14.Enabled = true;
				this.priTextBox3.Enabled = true;
				
				this.priComboBox1.Text = "";
				this.priComboBox2.Text = "";
				this.priComboBox3.Text = "";
				this.comboBox1.Text = "";
				this.priTextBox1.Text = "";
				this.priTextBox11.Text = "";
				this.priTextBox13.Text = "";
				this.priTextBox14.Text = "";
				this.priTextBox3.Text = "";
				
			}
			else if(sqltype.Equals("update"))
			{
				this.priComboBox1.Enabled = true;
				this.priComboBox2.Enabled = true;
				this.priComboBox3.Enabled = true;
				this.priComboBox4.Enabled = true;
				this.comboBox1.Enabled = true;
				this.priTextBox1.Enabled = false;
				this.priTextBox11.Enabled = true;
				this.priTextBox13.Enabled = true;
				this.priTextBox14.Enabled = true;
				this.priTextBox3.Enabled = true;
				
			}
		}

		private void InitialGrid(string sql)
		{		
			DataTable dt = TJSystem.Public.PublicStatic.db.GetDataTable(sql);
			dt.TableName = "finance_doc";
			this.dataGridTableStyle1.DataGrid.DataSource = dt.DefaultView;
		}

		/// <summary>
	
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			frmCurrent = null ;
			if( disposing )
			{
				if(components != null)
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
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
				TJSystem.Public.PublicStatic.formName = "应收/应付登账";
			}
			base.OnClosing (e);
		}
		#region Windows Form 
		/// <summary>
		
		/// </summary>
		private void InitializeComponent()
		{
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(frmGatheringPaymentBill));
			this.panel3 = new System.Windows.Forms.Panel();
			this.priToolBar1 = new TJSystem.UC.PriToolBar();
			this.panel2 = new System.Windows.Forms.Panel();
			this.dataGrid1 = new System.Windows.Forms.DataGrid();
			this.dataGridTableStyle1 = new System.Windows.Forms.DataGridTableStyle();
			this.doc_no = new System.Windows.Forms.DataGridTextBoxColumn();
			this.feetype_name = new System.Windows.Forms.DataGridTextBoxColumn();
			this.STATUS_NAME = new System.Windows.Forms.DataGridTextBoxColumn();
			this.CURRENCY_NAMECN = new System.Windows.Forms.DataGridTextBoxColumn();
			this.Amount = new System.Windows.Forms.DataGridTextBoxColumn();
			this.bearing_desc = new System.Windows.Forms.DataGridTextBoxColumn();
			this.payrec_type_desc = new System.Windows.Forms.DataGridTextBoxColumn();
			this.crm_id = new System.Windows.Forms.DataGridTextBoxColumn();
			this.voucher_no = new System.Windows.Forms.DataGridTextBoxColumn();
			this.remark = new System.Windows.Forms.DataGridTextBoxColumn();
			this.CreateBy = new System.Windows.Forms.DataGridTextBoxColumn();
			this.CreateOn = new System.Windows.Forms.DataGridTextBoxColumn();
			this.modifyOn = new System.Windows.Forms.DataGridTextBoxColumn();
			this.modifyBy = new System.Windows.Forms.DataGridTextBoxColumn();
			this.panel4 = new System.Windows.Forms.Panel();
			this.priComboBox2 = new TJSystem.Classes.PriComboBox();
			this.comboBox1 = new TJSystem.Classes.PriComboBox();
			this.priTextBox14 = new TJSystem.Classes.PriTextBox();
			this.label11 = new System.Windows.Forms.Label();
			this.priTextBox13 = new TJSystem.Classes.PriTextBox();
			this.label10 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.priTextBox11 = new TJSystem.Classes.PriTextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.priTextBox9 = new TJSystem.Classes.PriTextBox();
			this.label22 = new System.Windows.Forms.Label();
			this.priTextBox8 = new TJSystem.Classes.PriTextBox();
			this.label20 = new System.Windows.Forms.Label();
			this.priTextBox4 = new TJSystem.Classes.PriTextBox();
			this.label14 = new System.Windows.Forms.Label();
			this.priTextBox5 = new TJSystem.Classes.PriTextBox();
			this.priTextBox3 = new TJSystem.Classes.PriTextBox();
			this.label9 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label12 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.priTextBox1 = new TJSystem.Classes.PriTextBox();
			this.priComboBox1 = new TJSystem.Classes.PriComboBox();
			this.priComboBox3 = new TJSystem.Classes.PriComboBox();
			this.priComboBox4 = new TJSystem.Classes.PriComboBox();
			this.panel1 = new System.Windows.Forms.Panel();
			this.label1 = new System.Windows.Forms.Label();
			this.panel3.SuspendLayout();
			this.panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).BeginInit();
			this.panel4.SuspendLayout();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel3
			// 
			this.panel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel3.BackgroundImage")));
			this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.panel3.Controls.Add(this.priToolBar1);
			this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panel3.Location = new System.Drawing.Point(0, 529);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(792, 37);
			this.panel3.TabIndex = 24;
			// 
			// priToolBar1
			// 
			this.priToolBar1.DGEnable = true;
			this.priToolBar1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.priToolBar1.Location = new System.Drawing.Point(0, -5);
			this.priToolBar1.Name = "priToolBar1";
			this.priToolBar1.setCurrentForm = null;
			this.priToolBar1.Size = new System.Drawing.Size(788, 38);
			this.priToolBar1.TabIndex = 0;
			// 
			// panel2
			// 
			this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
			this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.panel2.Controls.Add(this.dataGrid1);
			this.panel2.Controls.Add(this.panel4);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel2.Location = new System.Drawing.Point(0, 45);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(792, 521);
			this.panel2.TabIndex = 23;
			// 
			// dataGrid1
			// 
			this.dataGrid1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.dataGrid1.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.dataGrid1.CaptionVisible = false;
			this.dataGrid1.DataMember = "";
			this.dataGrid1.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.dataGrid1.Location = new System.Drawing.Point(0, 152);
			this.dataGrid1.Name = "dataGrid1";
			this.dataGrid1.ReadOnly = true;
			this.dataGrid1.Size = new System.Drawing.Size(783, 328);
			this.dataGrid1.TabIndex = 1;
			this.dataGrid1.TableStyles.AddRange(new System.Windows.Forms.DataGridTableStyle[] {
																								  this.dataGridTableStyle1});
			// 
			// dataGridTableStyle1
			// 
			this.dataGridTableStyle1.AllowSorting = false;
			this.dataGridTableStyle1.DataGrid = this.dataGrid1;
			this.dataGridTableStyle1.GridColumnStyles.AddRange(new System.Windows.Forms.DataGridColumnStyle[] {
																												  this.doc_no,
																												  this.feetype_name,
																												  this.STATUS_NAME,
																												  this.CURRENCY_NAMECN,
																												  this.Amount,
																												  this.bearing_desc,
																												  this.payrec_type_desc,
																												  this.crm_id,
																												  this.voucher_no,
																												  this.remark,
																												  this.CreateBy,
																												  this.CreateOn,
																												  this.modifyOn,
																												  this.modifyBy});
			this.dataGridTableStyle1.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.dataGridTableStyle1.MappingName = "finance_doc";
			this.dataGridTableStyle1.ReadOnly = true;
			// 
			// doc_no
			// 
			this.doc_no.Alignment = System.Windows.Forms.HorizontalAlignment.Center;
			this.doc_no.Format = "";
			this.doc_no.FormatInfo = null;
			this.doc_no.HeaderText = "单据编号";
			this.doc_no.MappingName = "doc_no";
			this.doc_no.Width = 75;
			// 
			// feetype_name
			// 
			this.feetype_name.Alignment = System.Windows.Forms.HorizontalAlignment.Center;
			this.feetype_name.Format = "";
			this.feetype_name.FormatInfo = null;
			this.feetype_name.HeaderText = "单据类型";
			this.feetype_name.MappingName = "feetype_name";
			this.feetype_name.Width = 75;
			// 
			// STATUS_NAME
			// 
			this.STATUS_NAME.Alignment = System.Windows.Forms.HorizontalAlignment.Center;
			this.STATUS_NAME.Format = "";
			this.STATUS_NAME.FormatInfo = null;
			this.STATUS_NAME.HeaderText = "状态";
			this.STATUS_NAME.MappingName = "STATUS_NAME";
			this.STATUS_NAME.Width = 75;
			// 
			// CURRENCY_NAMECN
			// 
			this.CURRENCY_NAMECN.Alignment = System.Windows.Forms.HorizontalAlignment.Center;
			this.CURRENCY_NAMECN.Format = "";
			this.CURRENCY_NAMECN.FormatInfo = null;
			this.CURRENCY_NAMECN.HeaderText = "币种";
			this.CURRENCY_NAMECN.MappingName = "CURRENCY_NAMECN";
			this.CURRENCY_NAMECN.Width = 75;
			// 
			// Amount
			// 
			this.Amount.Alignment = System.Windows.Forms.HorizontalAlignment.Center;
			this.Amount.Format = "";
			this.Amount.FormatInfo = null;
			this.Amount.HeaderText = "总金额";
			this.Amount.MappingName = "Amount";
			this.Amount.Width = 75;
			// 
			// bearing_desc
			// 
			this.bearing_desc.Alignment = System.Windows.Forms.HorizontalAlignment.Center;
			this.bearing_desc.Format = "";
			this.bearing_desc.FormatInfo = null;
			this.bearing_desc.HeaderText = "冲销方向";
			this.bearing_desc.MappingName = "bearing_desc";
			this.bearing_desc.Width = 75;
			// 
			// payrec_type_desc
			// 
			this.payrec_type_desc.Alignment = System.Windows.Forms.HorizontalAlignment.Center;
			this.payrec_type_desc.Format = "";
			this.payrec_type_desc.FormatInfo = null;
			this.payrec_type_desc.HeaderText = "收付类型";
			this.payrec_type_desc.MappingName = "payrec_type_desc";
			this.payrec_type_desc.Width = 75;
			// 
			// crm_id
			// 
			this.crm_id.Alignment = System.Windows.Forms.HorizontalAlignment.Center;
			this.crm_id.Format = "";
			this.crm_id.FormatInfo = null;
			this.crm_id.HeaderText = "收付对象ID";
			this.crm_id.MappingName = "crm_id";
			this.crm_id.Width = 75;
			// 
			// voucher_no
			// 
			this.voucher_no.Alignment = System.Windows.Forms.HorizontalAlignment.Center;
			this.voucher_no.Format = "";
			this.voucher_no.FormatInfo = null;
			this.voucher_no.HeaderText = "收付对象";
			this.voucher_no.MappingName = "voucher_no";
			this.voucher_no.Width = 75;
			// 
			// remark
			// 
			this.remark.Alignment = System.Windows.Forms.HorizontalAlignment.Center;
			this.remark.Format = "";
			this.remark.FormatInfo = null;
			this.remark.HeaderText = "备注";
			this.remark.MappingName = "remark";
			this.remark.Width = 75;
			// 
			// CreateBy
			// 
			this.CreateBy.Alignment = System.Windows.Forms.HorizontalAlignment.Center;
			this.CreateBy.Format = "";
			this.CreateBy.FormatInfo = null;
			this.CreateBy.HeaderText = "创建者";
			this.CreateBy.MappingName = "CreateBy";
			this.CreateBy.Width = 75;
			// 
			// CreateOn
			// 
			this.CreateOn.Alignment = System.Windows.Forms.HorizontalAlignment.Center;
			this.CreateOn.Format = "";
			this.CreateOn.FormatInfo = null;
			this.CreateOn.HeaderText = "创建时间";
			this.CreateOn.MappingName = "CreateOn";
			this.CreateOn.Width = 75;
			// 
			// modifyOn
			// 
			this.modifyOn.Alignment = System.Windows.Forms.HorizontalAlignment.Center;
			this.modifyOn.Format = "";
			this.modifyOn.FormatInfo = null;
			this.modifyOn.HeaderText = "最后修改时间";
			this.modifyOn.MappingName = "modifyOn";
			this.modifyOn.Width = 75;
			// 
			// modifyBy
			// 
			this.modifyBy.Alignment = System.Windows.Forms.HorizontalAlignment.Center;
			this.modifyBy.Format = "";
			this.modifyBy.FormatInfo = null;
			this.modifyBy.HeaderText = "最后修改人";
			this.modifyBy.MappingName = "modifyBy";
			this.modifyBy.Width = 75;
			// 
			// panel4
			// 
			this.panel4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel4.BackgroundImage")));
			this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.panel4.Controls.Add(this.priComboBox2);
			this.panel4.Controls.Add(this.comboBox1);
			this.panel4.Controls.Add(this.priTextBox14);
			this.panel4.Controls.Add(this.label11);
			this.panel4.Controls.Add(this.priTextBox13);
			this.panel4.Controls.Add(this.label10);
			this.panel4.Controls.Add(this.label8);
			this.panel4.Controls.Add(this.label6);
			this.panel4.Controls.Add(this.priTextBox11);
			this.panel4.Controls.Add(this.label3);
			this.panel4.Controls.Add(this.label5);
			this.panel4.Controls.Add(this.label4);
			this.panel4.Controls.Add(this.priTextBox9);
			this.panel4.Controls.Add(this.label22);
			this.panel4.Controls.Add(this.priTextBox8);
			this.panel4.Controls.Add(this.label20);
			this.panel4.Controls.Add(this.priTextBox4);
			this.panel4.Controls.Add(this.label14);
			this.panel4.Controls.Add(this.priTextBox5);
			this.panel4.Controls.Add(this.priTextBox3);
			this.panel4.Controls.Add(this.label9);
			this.panel4.Controls.Add(this.label7);
			this.panel4.Controls.Add(this.label12);
			this.panel4.Controls.Add(this.label2);
			this.panel4.Controls.Add(this.priTextBox1);
			this.panel4.Controls.Add(this.priComboBox1);
			this.panel4.Controls.Add(this.priComboBox3);
			this.panel4.Controls.Add(this.priComboBox4);
			this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel4.Location = new System.Drawing.Point(0, 0);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(788, 144);
			this.panel4.TabIndex = 0;
			// 
			// priComboBox2
			// 
			this.priComboBox2.BackColor = System.Drawing.Color.White;
			this.priComboBox2.DataField = "Currency";
			this.priComboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.priComboBox2.Location = new System.Drawing.Point(80, 40);
			this.priComboBox2.Name = "priComboBox2";
			this.priComboBox2.Size = new System.Drawing.Size(136, 21);
			this.priComboBox2.TabIndex = 168;
			// 
			// comboBox1
			// 
			this.comboBox1.BackColor = System.Drawing.Color.White;
			this.comboBox1.DataField = "Status";
			this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBox1.Location = new System.Drawing.Point(520, 15);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(160, 21);
			this.comboBox1.TabIndex = 167;
			// 
			// priTextBox14
			// 
			this.priTextBox14.BackColor = System.Drawing.Color.White;
			this.priTextBox14.DataField = "crm_id";
			this.priTextBox14.DataType = TJSystem.Public.DataType.String;
			this.priTextBox14.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.priTextBox14.Location = new System.Drawing.Point(520, 64);
			this.priTextBox14.Name = "priTextBox14";
			this.priTextBox14.Size = new System.Drawing.Size(160, 23);
			this.priTextBox14.TabIndex = 166;
			this.priTextBox14.Text = "";
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.BackColor = System.Drawing.Color.Transparent;
			this.label11.ForeColor = System.Drawing.SystemColors.Desktop;
			this.label11.Location = new System.Drawing.Point(448, 64);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(72, 18);
			this.label11.TabIndex = 165;
			this.label11.Text = "收付对象ID";
			this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// priTextBox13
			// 
			this.priTextBox13.BackColor = System.Drawing.Color.White;
			this.priTextBox13.DataField = "voucher_no";
			this.priTextBox13.DataType = TJSystem.Public.DataType.String;
			this.priTextBox13.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.priTextBox13.Location = new System.Drawing.Point(296, 64);
			this.priTextBox13.Name = "priTextBox13";
			this.priTextBox13.Size = new System.Drawing.Size(144, 23);
			this.priTextBox13.TabIndex = 164;
			this.priTextBox13.Text = "";
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.BackColor = System.Drawing.Color.Transparent;
			this.label10.ForeColor = System.Drawing.SystemColors.Desktop;
			this.label10.Location = new System.Drawing.Point(232, 64);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(58, 18);
			this.label10.TabIndex = 163;
			this.label10.Text = "收付对象";
			this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.BackColor = System.Drawing.Color.Transparent;
			this.label8.ForeColor = System.Drawing.Color.Blue;
			this.label8.Location = new System.Drawing.Point(16, 72);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(58, 18);
			this.label8.TabIndex = 161;
			this.label8.Text = "收付类型";
			this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.BackColor = System.Drawing.Color.Transparent;
			this.label6.ForeColor = System.Drawing.Color.Blue;
			this.label6.Location = new System.Drawing.Point(456, 40);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(58, 18);
			this.label6.TabIndex = 159;
			this.label6.Text = "冲销方向";
			this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// priTextBox11
			// 
			this.priTextBox11.BackColor = System.Drawing.Color.White;
			this.priTextBox11.DataField = "Amount";
			this.priTextBox11.DataType = TJSystem.Public.DataType.String;
			this.priTextBox11.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.priTextBox11.Location = new System.Drawing.Point(296, 40);
			this.priTextBox11.Name = "priTextBox11";
			this.priTextBox11.Size = new System.Drawing.Size(144, 23);
			this.priTextBox11.TabIndex = 158;
			this.priTextBox11.Text = "";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.BackColor = System.Drawing.Color.Transparent;
			this.label3.ForeColor = System.Drawing.Color.Blue;
			this.label3.Location = new System.Drawing.Point(240, 45);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(45, 18);
			this.label3.TabIndex = 157;
			this.label3.Text = "总金额";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.BackColor = System.Drawing.Color.Transparent;
			this.label5.ForeColor = System.Drawing.Color.Blue;
			this.label5.Location = new System.Drawing.Point(488, 18);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(32, 18);
			this.label5.TabIndex = 155;
			this.label5.Text = "状态";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.BackColor = System.Drawing.Color.Transparent;
			this.label4.ForeColor = System.Drawing.Color.Blue;
			this.label4.Location = new System.Drawing.Point(232, 18);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(58, 18);
			this.label4.TabIndex = 154;
			this.label4.Text = "单据类型";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// priTextBox9
			// 
			this.priTextBox9.BackColor = System.Drawing.Color.White;
			this.priTextBox9.DataField = "modifyBy";
			this.priTextBox9.DataType = TJSystem.Public.DataType.String;
			this.priTextBox9.Enabled = false;
			this.priTextBox9.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.priTextBox9.Location = new System.Drawing.Point(432, 112);
			this.priTextBox9.Name = "priTextBox9";
			this.priTextBox9.Size = new System.Drawing.Size(112, 23);
			this.priTextBox9.TabIndex = 153;
			this.priTextBox9.Text = "";
			// 
			// label22
			// 
			this.label22.AutoSize = true;
			this.label22.BackColor = System.Drawing.Color.Transparent;
			this.label22.Location = new System.Drawing.Point(360, 112);
			this.label22.Name = "label22";
			this.label22.Size = new System.Drawing.Size(72, 18);
			this.label22.TabIndex = 152;
			this.label22.Text = "最后修改人";
			this.label22.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// priTextBox8
			// 
			this.priTextBox8.BackColor = System.Drawing.Color.White;
			this.priTextBox8.DataField = "modifyOn";
			this.priTextBox8.DataType = TJSystem.Public.DataType.String;
			this.priTextBox8.Enabled = false;
			this.priTextBox8.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.priTextBox8.Location = new System.Drawing.Point(632, 112);
			this.priTextBox8.Name = "priTextBox8";
			this.priTextBox8.Size = new System.Drawing.Size(112, 23);
			this.priTextBox8.TabIndex = 151;
			this.priTextBox8.Text = "";
			// 
			// label20
			// 
			this.label20.AutoSize = true;
			this.label20.BackColor = System.Drawing.Color.Transparent;
			this.label20.Location = new System.Drawing.Point(544, 120);
			this.label20.Name = "label20";
			this.label20.Size = new System.Drawing.Size(85, 18);
			this.label20.TabIndex = 150;
			this.label20.Text = "最后修改时间";
			this.label20.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// priTextBox4
			// 
			this.priTextBox4.BackColor = System.Drawing.Color.White;
			this.priTextBox4.DataField = "CreateBy";
			this.priTextBox4.DataType = TJSystem.Public.DataType.String;
			this.priTextBox4.Enabled = false;
			this.priTextBox4.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.priTextBox4.Location = new System.Drawing.Point(80, 112);
			this.priTextBox4.Name = "priTextBox4";
			this.priTextBox4.Size = new System.Drawing.Size(104, 23);
			this.priTextBox4.TabIndex = 149;
			this.priTextBox4.Text = "";
			// 
			// label14
			// 
			this.label14.AutoSize = true;
			this.label14.BackColor = System.Drawing.Color.Transparent;
			this.label14.Location = new System.Drawing.Point(28, 118);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(45, 18);
			this.label14.TabIndex = 148;
			this.label14.Text = "创建者";
			this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// priTextBox5
			// 
			this.priTextBox5.BackColor = System.Drawing.Color.White;
			this.priTextBox5.DataField = "CreateOn";
			this.priTextBox5.DataType = TJSystem.Public.DataType.String;
			this.priTextBox5.Enabled = false;
			this.priTextBox5.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.priTextBox5.Location = new System.Drawing.Point(256, 112);
			this.priTextBox5.Name = "priTextBox5";
			this.priTextBox5.Size = new System.Drawing.Size(104, 23);
			this.priTextBox5.TabIndex = 147;
			this.priTextBox5.Text = "";
			// 
			// priTextBox3
			// 
			this.priTextBox3.BackColor = System.Drawing.Color.White;
			this.priTextBox3.DataField = "remark";
			this.priTextBox3.DataType = TJSystem.Public.DataType.String;
			this.priTextBox3.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.priTextBox3.Location = new System.Drawing.Point(80, 88);
			this.priTextBox3.Name = "priTextBox3";
			this.priTextBox3.Size = new System.Drawing.Size(600, 23);
			this.priTextBox3.TabIndex = 146;
			this.priTextBox3.Text = "";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.BackColor = System.Drawing.Color.Transparent;
			this.label9.Location = new System.Drawing.Point(192, 118);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(58, 18);
			this.label9.TabIndex = 145;
			this.label9.Text = "创建日期";
			this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.BackColor = System.Drawing.Color.Transparent;
			this.label7.Location = new System.Drawing.Point(41, 96);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(32, 18);
			this.label7.TabIndex = 144;
			this.label7.Text = "备注";
			this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.BackColor = System.Drawing.Color.Transparent;
			this.label12.ForeColor = System.Drawing.Color.Blue;
			this.label12.Location = new System.Drawing.Point(41, 40);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(32, 18);
			this.label12.TabIndex = 142;
			this.label12.Text = "币种";
			this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.BackColor = System.Drawing.Color.Transparent;
			this.label2.ForeColor = System.Drawing.Color.Blue;
			this.label2.Location = new System.Drawing.Point(16, 18);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(58, 18);
			this.label2.TabIndex = 115;
			this.label2.Text = "单据编号";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// priTextBox1
			// 
			this.priTextBox1.BackColor = System.Drawing.Color.White;
			this.priTextBox1.DataField = "doc_no";
			this.priTextBox1.DataType = TJSystem.Public.DataType.String;
			this.priTextBox1.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.priTextBox1.Location = new System.Drawing.Point(80, 12);
			this.priTextBox1.Name = "priTextBox1";
			this.priTextBox1.Size = new System.Drawing.Size(136, 23);
			this.priTextBox1.TabIndex = 116;
			this.priTextBox1.Text = "";
			// 
			// priComboBox1
			// 
			this.priComboBox1.BackColor = System.Drawing.Color.White;
			this.priComboBox1.DataField = "payrec_type";
			this.priComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.priComboBox1.Location = new System.Drawing.Point(80, 64);
			this.priComboBox1.Name = "priComboBox1";
			this.priComboBox1.Size = new System.Drawing.Size(136, 21);
			this.priComboBox1.TabIndex = 168;
			// 
			// priComboBox3
			// 
			this.priComboBox3.BackColor = System.Drawing.Color.White;
			this.priComboBox3.DataField = "bearing";
			this.priComboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.priComboBox3.Location = new System.Drawing.Point(520, 40);
			this.priComboBox3.Name = "priComboBox3";
			this.priComboBox3.Size = new System.Drawing.Size(160, 21);
			this.priComboBox3.TabIndex = 167;
			// 
			// priComboBox4
			// 
			this.priComboBox4.BackColor = System.Drawing.Color.White;
			this.priComboBox4.DataField = "doc_type";
			this.priComboBox4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.priComboBox4.Location = new System.Drawing.Point(296, 16);
			this.priComboBox4.Name = "priComboBox4";
			this.priComboBox4.Size = new System.Drawing.Size(144, 21);
			this.priComboBox4.TabIndex = 168;
			// 
			// panel1
			// 
			this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
			this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.panel1.Controls.Add(this.label1);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(792, 45);
			this.panel1.TabIndex = 22;
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label1.Font = new System.Drawing.Font("宋体", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.label1.Location = new System.Drawing.Point(0, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(788, 41);
			this.label1.TabIndex = 0;
			this.label1.Text = "应收应付单据设置";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// frmGatheringPaymentBill
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(7, 15);
			this.ClientSize = new System.Drawing.Size(792, 566);
			this.Controls.Add(this.panel3);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.Font = new System.Drawing.Font("宋体", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.Name = "frmGatheringPaymentBill";
			this.Text = "应收/应付登账";
			this.panel3.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).EndInit();
			this.panel4.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion
	}
}

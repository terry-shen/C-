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
	public class frmCEDetail : System.Windows.Forms.Form
	{
		
		
		/// <summary>
		/// 必需的设计器变量。
		/// </summary>
		private System.ComponentModel.Container components = null;
		private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn4;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.DataGrid dataGrid1;
		private System.Windows.Forms.Panel panel4;
		private System.Windows.Forms.DataGridTextBoxColumn email2;
		private System.Windows.Forms.DataGridTextBoxColumn tel1;
		private System.Windows.Forms.DataGridTextBoxColumn address_cn;
		private System.Windows.Forms.DataGridTextBoxColumn postcode;
		private System.Windows.Forms.DataGridTextBoxColumn company_id;
		private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn3;
		private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn1;
		private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn2;
		private System.Windows.Forms.DataGridTextBoxColumn fax1;
		private System.Windows.Forms.DataGridTextBoxColumn corporation;
		private System.Windows.Forms.DataGridTextBoxColumn email1;
		private System.Windows.Forms.DataGridTextBoxColumn address;
		private System.Windows.Forms.DataGridTextBoxColumn modifyon;
		private System.Windows.Forms.Panel panel3;
		private TJSystem.UC.PriToolBar priToolBar1;
		private System.Windows.Forms.DataGridTextBoxColumn tel2;
		private System.Windows.Forms.DataGridTextBoxColumn website;
		private System.Windows.Forms.DataGridTextBoxColumn resume;
		private System.Windows.Forms.DataGridTextBoxColumn gen_manager;
		private System.Windows.Forms.DataGridTextBoxColumn company_name;
		private System.Windows.Forms.DataGridTextBoxColumn company_name_cn;
		private System.Windows.Forms.DataGridTextBoxColumn fax2;
		private System.Windows.Forms.DataGridTextBoxColumn createon;
		private System.Windows.Forms.DataGridTextBoxColumn modifyby;
		private System.Windows.Forms.DataGridTextBoxColumn createby;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label1;
		public static System.Windows.Forms.Form frmCurrent = null ;

		private string _PK = "";
		private System.Windows.Forms.DataGrid dataGrid2;
		private System.Windows.Forms.DataGrid dataGrid3;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.Label label4;
		private TJSystem.Classes.PriTextBox txt4;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Label label14;
		private TJSystem.Classes.PriTextBox txt6;
		private TJSystem.Classes.PriComboBox priComboBox2;
		private System.Windows.Forms.Label label32;
		private System.Windows.Forms.Label label9;
		private TJSystem.Classes.PriTextBox txt5;
		private System.Windows.Forms.Label label3;
		private TJSystem.Classes.PriTextBox txt2;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label2;
		private TJSystem.Classes.PriTextBox txt3;
		private TJSystem.Classes.PriTextBox txt1;
		private TJSystem.Classes.PriComboBox priComboBox1;
		private string _Sale_CE_Code = null;
		public static int Count = 0;
		private TJSystem.Classes.PriTextBox txt8;
		private TJSystem.Classes.PriTextBox txt7;
		private TJSystem.Classes.PriTextBox txt9;
		private System.Windows.Forms.DataGridTableStyle dataGridTableStyle1;
		private System.Windows.Forms.DataGridTextBoxColumn ce_code;
		private System.Windows.Forms.DataGridTextBoxColumn seq_no;
		private System.Windows.Forms.DataGridTextBoxColumn item_code;
		private System.Windows.Forms.DataGridTextBoxColumn client_itemcode;
		private System.Windows.Forms.DataGridTextBoxColumn item_name;
		private System.Windows.Forms.DataGridTextBoxColumn item_name_cn;
		private System.Windows.Forms.DataGridTextBoxColumn item_desc;
		private System.Windows.Forms.DataGridTextBoxColumn item_desc_cn;
		private System.Windows.Forms.DataGridTextBoxColumn item_qty;
		private System.Windows.Forms.DataGridTextBoxColumn remark;
		private string _statusType = null;
		private System.Windows.Forms.DataGridTextBoxColumn unit_name_cn;
		private string _table = null;

		public frmCEDetail(string sale_CE_code)
		{
			//
			// Windows 窗体设计器支持所必需的
			//
			InitializeComponent();

			_statusType = "sales";
			this._Sale_CE_Code = sale_CE_code;
			this.txt1.Text = _Sale_CE_Code;

			
			InitialFormData();
			
			TJSystem.Public.PublicStatic.setBackgroundImg(this.panel1,this.panel1.GetType().ToString(),"images\\bg.gif");
			TJSystem.Public.PublicStatic.setBackgroundImg(this.panel2,this.panel1.GetType().ToString(),"");
			TJSystem.Public.PublicStatic.setBackgroundImg(this.panel3,this.panel1.GetType().ToString(),"");
			TJSystem.Public.PublicStatic.setBackgroundImg(this.panel4,this.panel1.GetType().ToString(),"");

			System.Text.StringBuilder sb = new System.Text.StringBuilder();
			sb.Append("select a.ce_code,a.seq_no,a.item_code,a.client_itemcode,a.item_name,a.item_name_cn,a.item_desc,a.item_desc_cn,a.item_qty,a.unit,b.unit_name_cn as unit_name_cn,");
			sb.Append("a.remark ");
			sb.Append("from sale_ce_detail a ");
			sb.Append("left join p_unit b ");
			sb.Append("on a.unit = b.unit_id ");
			sb.Append(" where ce_code = '"+ this.txt1.Text.ToString().Trim() +"'");
			sb.Append(" order by ce_code,seq_no");
			this.InitialGrid(sb.ToString());

			priToolBar1.setCurrentForm = this;
			_table = "sale_ce_detail";
			_PK = "ce_code,seq_no";
			priToolBar1.Initial(_table,_PK,sb.ToString());
			priToolBar1.BeforeButtonClickEvent += new TJSystem.UC.PriToolBar.BeforeButotnClick(this.BeforeButtonClick);
			priToolBar1.AfterButtonClickEvent += new TJSystem.UC.PriToolBar.AfterButtonClick(this.AfterButtonClick);
			priToolBar1.InitialFormDataWithDataGridEvent += new TJSystem.UC.PriToolBar.InitialFormDataWithDataGrid(this.InitialFormDataWithDataGridFunc);

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
			//货品编号
			string sql = "select item_code,item_code+' '+item_name_cn as item_namecn from basic_item order by item_code";
			DataTable dt = TJSystem.Public.PublicStatic.db.GetDataTable(sql);
			dr = dt.NewRow() ;
			dr[0] = "" ;
			dr[1] = "" ;
			dt.Rows.InsertAt(dr,0) ;
			dtcpy = dt.Copy();
			this.priComboBox1.DataSource = dtcpy.DefaultView;
			this.priComboBox1.ValueMember = "item_code";
			this.priComboBox1.DisplayMember = "item_namecn";
		
//			//外包类型
//			sql = "select pack_code,pack_code+' '+pack_namecn as pack_namecn from p_packtype order by pack_code";
//			dt = TJSystem.Public.PublicStatic.db.GetDataTable(sql);
//			this.priComboBox4.DataSource = dt.DefaultView;
//			this.priComboBox4.ValueMember = "pack_code";
//			this.priComboBox4.DisplayMember = "pack_namecn";

		}

		private bool BeforeButtonClick(string sqltype)
		{
			System.Text.StringBuilder sb = new System.Text.StringBuilder();
			sb.Append("数据验证错误：\r\n");
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
            if(sqltype.Equals("insert"))
            {
                if (this.txt1.Text == "" )
                {
                    MessageBox.Show("请输入询价单号","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    return false;
                }
			
                if(TJSystem.Public.PublicStatic.IsExsist(this._table,this._PK,this.priToolBar1))
                {
                    MessageBox.Show("这张询价单已经存在,请另外开立","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    return false;
                }
				if (!TJSystem.Public.PublicStatic.IsNumDouble(this.txt2.Text))
				{
					TJSystem.Public.PublicStatic.ShowMessage(TJSystem.Public.MessageType.Error, "货品序号必须是数字！");
					return false;
				}
            }

            //check输入值的属性
            
            if(this.priComboBox1.SelectedValue == null)
            {
                TJSystem.Public.PublicStatic.ShowMessage(TJSystem.Public.MessageType.Exclamation,"必须选择货品编号！");
                return false;
            }
            if(this.priComboBox2.SelectedValue == null)
            {
                TJSystem.Public.PublicStatic.ShowMessage(TJSystem.Public.MessageType.Exclamation,"必须选择客人货号！");
                return false;
            }
            if (this.txt7.Text.Equals(""))
            {
                TJSystem.Public.PublicStatic.ShowMessage(TJSystem.Public.MessageType.Error, "请填写询价数量！");
                return false;
            }
            if(!TJSystem.Public.PublicStatic.IsNumDouble(this.txt7.Text.Trim()))
            {
                TJSystem.Public.PublicStatic.ShowMessage(TJSystem.Public.MessageType.Error,"询价数量必须是数字！");
                return false;
            }
			return true;
		}


		private void setDisable()
		{
			this.txt1.Enabled = false;
			this.txt2.Enabled = false;
			this.txt3.Enabled = false;
			this.txt4.Enabled = false;
			this.txt5.Enabled = false;
			this.txt6.Enabled = false;
			this.txt7.Enabled = false;
			this.txt8.Enabled = false;
			this.txt9.Enabled = false;
			this.priComboBox1.Enabled = false;
			this.priComboBox2.Enabled = false;
		}

		private void AfterButtonClick(string ButtonType)
		{
			if(ButtonType.Equals("insert"))
			{
                // del by chenchong
//				string sql = "select max(seq_no) as seq_no from sale_ce_detail where ce_code = '"+ _Sale_CE_Code +"'";
//				DataTable dt = TJSystem.Public.PublicStatic.db.GetDataTable(sql);
//				if(dt.Rows[0]["seq_no"].ToString().Trim()=="")
//				{
//					this.txt2.Text = "1";
//				}
//				else
//				{
//					this.txt2.Text = Convert.ToString(Convert.ToInt32(dt.Rows[0]["seq_no"].ToString().Trim()) + 1);
//				}
                // end del

//				this.txt1.Enabled = true;
//				this.txt2.Enabled = true;
//				this.txt3.Enabled = true;
//				this.txt4.Enabled = true;
//				this.txt5.Enabled = true;
//				this.txt6.Enabled = true;
//				this.txt8.Enabled = true;
				this.txt9.Enabled = true;
                this.txt2.Enabled = true;  // add by chenchong
				this.txt7.Enabled = true;
				this.priComboBox1.Enabled = true;

//				this.txt1.Text = "";
				this.txt2.Text = "";  // add by chenchong
				this.txt3.Text = "";
				this.txt4.Text = "";
				this.txt5.Text = "";
				this.txt6.Text = "";
				this.txt7.Text = "";
				this.txt8.Text = "";
				this.txt9.Text = "";
			
			}
			else if(ButtonType.Equals("update"))
			{
//				this.txt3.Enabled = true;
//				this.txt4.Enabled = true;
//				this.txt5.Enabled = true;
//				this.txt6.Enabled = true;
//				this.txt8.Enabled = true;
				this.txt9.Enabled = true;
				this.priComboBox1.Enabled = true;
				this.txt7.Enabled = true;
				
			
			}
			
		}

		private void InitialGrid(string sql)
		{		
			DataTable dt = TJSystem.Public.PublicStatic.db.GetDataTable(sql);
			dt.TableName = "sale_ce_detail";
			this.dataGrid1.DataSource = dt.DefaultView;
		}

//		private void InitialGrid1(string sql)
//		{		
//			DataTable dt = TJSystem.Public.PublicStatic.db.GetDataTable(sql);
//			dt.TableName = "sale_ce_detail";
//			this.dataGrid4.DataSource = dt.DefaultView;
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(frmCEDetail));
			this.dataGridTextBoxColumn4 = new System.Windows.Forms.DataGridTextBoxColumn();
			this.panel2 = new System.Windows.Forms.Panel();
			this.dataGrid1 = new System.Windows.Forms.DataGrid();
			this.dataGridTableStyle1 = new System.Windows.Forms.DataGridTableStyle();
			this.ce_code = new System.Windows.Forms.DataGridTextBoxColumn();
			this.seq_no = new System.Windows.Forms.DataGridTextBoxColumn();
			this.item_code = new System.Windows.Forms.DataGridTextBoxColumn();
			this.client_itemcode = new System.Windows.Forms.DataGridTextBoxColumn();
			this.item_name = new System.Windows.Forms.DataGridTextBoxColumn();
			this.item_name_cn = new System.Windows.Forms.DataGridTextBoxColumn();
			this.item_desc = new System.Windows.Forms.DataGridTextBoxColumn();
			this.item_desc_cn = new System.Windows.Forms.DataGridTextBoxColumn();
			this.item_qty = new System.Windows.Forms.DataGridTextBoxColumn();
			this.unit_name_cn = new System.Windows.Forms.DataGridTextBoxColumn();
			this.remark = new System.Windows.Forms.DataGridTextBoxColumn();
			this.panel4 = new System.Windows.Forms.Panel();
			this.priComboBox1 = new TJSystem.Classes.PriComboBox();
			this.label13 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.txt4 = new TJSystem.Classes.PriTextBox();
			this.txt8 = new TJSystem.Classes.PriTextBox();
			this.label12 = new System.Windows.Forms.Label();
			this.txt7 = new TJSystem.Classes.PriTextBox();
			this.label14 = new System.Windows.Forms.Label();
			this.txt6 = new TJSystem.Classes.PriTextBox();
			this.priComboBox2 = new TJSystem.Classes.PriComboBox();
			this.label32 = new System.Windows.Forms.Label();
			this.txt9 = new TJSystem.Classes.PriTextBox();
			this.label9 = new System.Windows.Forms.Label();
			this.txt5 = new TJSystem.Classes.PriTextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.txt2 = new TJSystem.Classes.PriTextBox();
			this.label11 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.txt3 = new TJSystem.Classes.PriTextBox();
			this.txt1 = new TJSystem.Classes.PriTextBox();
			this.dataGrid3 = new System.Windows.Forms.DataGrid();
			this.dataGrid2 = new System.Windows.Forms.DataGrid();
			this.email2 = new System.Windows.Forms.DataGridTextBoxColumn();
			this.tel1 = new System.Windows.Forms.DataGridTextBoxColumn();
			this.address_cn = new System.Windows.Forms.DataGridTextBoxColumn();
			this.postcode = new System.Windows.Forms.DataGridTextBoxColumn();
			this.company_id = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumn3 = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumn1 = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumn2 = new System.Windows.Forms.DataGridTextBoxColumn();
			this.fax1 = new System.Windows.Forms.DataGridTextBoxColumn();
			this.corporation = new System.Windows.Forms.DataGridTextBoxColumn();
			this.email1 = new System.Windows.Forms.DataGridTextBoxColumn();
			this.address = new System.Windows.Forms.DataGridTextBoxColumn();
			this.modifyon = new System.Windows.Forms.DataGridTextBoxColumn();
			this.panel3 = new System.Windows.Forms.Panel();
			this.priToolBar1 = new TJSystem.UC.PriToolBar();
			this.tel2 = new System.Windows.Forms.DataGridTextBoxColumn();
			this.website = new System.Windows.Forms.DataGridTextBoxColumn();
			this.resume = new System.Windows.Forms.DataGridTextBoxColumn();
			this.gen_manager = new System.Windows.Forms.DataGridTextBoxColumn();
			this.company_name = new System.Windows.Forms.DataGridTextBoxColumn();
			this.company_name_cn = new System.Windows.Forms.DataGridTextBoxColumn();
			this.fax2 = new System.Windows.Forms.DataGridTextBoxColumn();
			this.createon = new System.Windows.Forms.DataGridTextBoxColumn();
			this.modifyby = new System.Windows.Forms.DataGridTextBoxColumn();
			this.createby = new System.Windows.Forms.DataGridTextBoxColumn();
			this.panel1 = new System.Windows.Forms.Panel();
			this.label1 = new System.Windows.Forms.Label();
			this.panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).BeginInit();
			this.panel4.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGrid3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGrid2)).BeginInit();
			this.panel3.SuspendLayout();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
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
			// panel2
			// 
			this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
			this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.panel2.Controls.Add(this.dataGrid1);
			this.panel2.Controls.Add(this.panel4);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel2.Location = new System.Drawing.Point(0, 48);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(776, 406);
			this.panel2.TabIndex = 11;
			// 
			// dataGrid1
			// 
			this.dataGrid1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.dataGrid1.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.dataGrid1.CaptionBackColor = System.Drawing.SystemColors.ActiveBorder;
			this.dataGrid1.CaptionText = "客户询价明细";
			this.dataGrid1.CaptionVisible = false;
			this.dataGrid1.DataMember = "";
			this.dataGrid1.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.dataGrid1.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.dataGrid1.Location = new System.Drawing.Point(0, 136);
			this.dataGrid1.Name = "dataGrid1";
			this.dataGrid1.ReadOnly = true;
			this.dataGrid1.Size = new System.Drawing.Size(768, 264);
			this.dataGrid1.TabIndex = 1;
			this.dataGrid1.TableStyles.AddRange(new System.Windows.Forms.DataGridTableStyle[] {
																								  this.dataGridTableStyle1});
			this.dataGrid1.Click += new System.EventHandler(this.dataGrid1_Click);
			// 
			// dataGridTableStyle1
			// 
			this.dataGridTableStyle1.DataGrid = this.dataGrid1;
			this.dataGridTableStyle1.GridColumnStyles.AddRange(new System.Windows.Forms.DataGridColumnStyle[] {
																												  this.ce_code,
																												  this.seq_no,
																												  this.item_code,
																												  this.client_itemcode,
																												  this.item_name,
																												  this.item_name_cn,
																												  this.item_desc,
																												  this.item_desc_cn,
																												  this.item_qty,
																												  this.unit_name_cn,
																												  this.remark});
			this.dataGridTableStyle1.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.dataGridTableStyle1.MappingName = "sale_ce_detail";
			// 
			// ce_code
			// 
			this.ce_code.Format = "";
			this.ce_code.FormatInfo = null;
			this.ce_code.HeaderText = "报价单号";
			this.ce_code.MappingName = "ce_code";
			this.ce_code.NullText = "";
			this.ce_code.Width = 75;
			// 
			// seq_no
			// 
			this.seq_no.Format = "";
			this.seq_no.FormatInfo = null;
			this.seq_no.HeaderText = "货号序号";
			this.seq_no.MappingName = "seq_no";
			this.seq_no.NullText = "";
			this.seq_no.Width = 75;
			// 
			// item_code
			// 
			this.item_code.Format = "";
			this.item_code.FormatInfo = null;
			this.item_code.HeaderText = "货号编号";
			this.item_code.MappingName = "item_code";
			this.item_code.NullText = "";
			this.item_code.Width = 75;
			// 
			// client_itemcode
			// 
			this.client_itemcode.Format = "";
			this.client_itemcode.FormatInfo = null;
			this.client_itemcode.HeaderText = "客户编号";
			this.client_itemcode.MappingName = "client_itemcode";
			this.client_itemcode.NullText = "";
			this.client_itemcode.Width = 75;
			// 
			// item_name
			// 
			this.item_name.Format = "";
			this.item_name.FormatInfo = null;
			this.item_name.HeaderText = "货品名称";
			this.item_name.MappingName = "item_name";
			this.item_name.NullText = "";
			this.item_name.Width = 75;
			// 
			// item_name_cn
			// 
			this.item_name_cn.Format = "";
			this.item_name_cn.FormatInfo = null;
			this.item_name_cn.HeaderText = "货品中文名称";
			this.item_name_cn.MappingName = "item_name_cn";
			this.item_name_cn.NullText = "";
			this.item_name_cn.Width = 75;
			// 
			// item_desc
			// 
			this.item_desc.Format = "";
			this.item_desc.FormatInfo = null;
			this.item_desc.HeaderText = "货品规格";
			this.item_desc.MappingName = "item_desc";
			this.item_desc.NullText = "";
			this.item_desc.Width = 75;
			// 
			// item_desc_cn
			// 
			this.item_desc_cn.Format = "";
			this.item_desc_cn.FormatInfo = null;
			this.item_desc_cn.HeaderText = "货品中文规格";
			this.item_desc_cn.MappingName = "item_desc_cn";
			this.item_desc_cn.NullText = "";
			this.item_desc_cn.Width = 75;
			// 
			// item_qty
			// 
			this.item_qty.Format = "";
			this.item_qty.FormatInfo = null;
			this.item_qty.HeaderText = "询价数量";
			this.item_qty.MappingName = "item_qty";
			this.item_qty.NullText = "";
			this.item_qty.Width = 75;
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
			// remark
			// 
			this.remark.Format = "";
			this.remark.FormatInfo = null;
			this.remark.HeaderText = "备注";
			this.remark.MappingName = "remark";
			this.remark.NullText = "";
			this.remark.Width = 75;
			// 
			// panel4
			// 
			this.panel4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel4.BackgroundImage")));
			this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.panel4.Controls.Add(this.priComboBox1);
			this.panel4.Controls.Add(this.label13);
			this.panel4.Controls.Add(this.label4);
			this.panel4.Controls.Add(this.txt4);
			this.panel4.Controls.Add(this.txt8);
			this.panel4.Controls.Add(this.label12);
			this.panel4.Controls.Add(this.txt7);
			this.panel4.Controls.Add(this.label14);
			this.panel4.Controls.Add(this.txt6);
			this.panel4.Controls.Add(this.priComboBox2);
			this.panel4.Controls.Add(this.label32);
			this.panel4.Controls.Add(this.txt9);
			this.panel4.Controls.Add(this.label9);
			this.panel4.Controls.Add(this.txt5);
			this.panel4.Controls.Add(this.label3);
			this.panel4.Controls.Add(this.txt2);
			this.panel4.Controls.Add(this.label11);
			this.panel4.Controls.Add(this.label8);
			this.panel4.Controls.Add(this.label7);
			this.panel4.Controls.Add(this.label2);
			this.panel4.Controls.Add(this.txt3);
			this.panel4.Controls.Add(this.txt1);
			this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel4.Location = new System.Drawing.Point(0, 0);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(772, 136);
			this.panel4.TabIndex = 0;
			// 
			// priComboBox1
			// 
			this.priComboBox1.BackColor = System.Drawing.Color.White;
			this.priComboBox1.DataField = "item_code";
			this.priComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.priComboBox1.Location = new System.Drawing.Point(592, 8);
			this.priComboBox1.Name = "priComboBox1";
			this.priComboBox1.Size = new System.Drawing.Size(160, 22);
			this.priComboBox1.TabIndex = 244;
			this.priComboBox1.SelectionChangeCommitted += new System.EventHandler(this.priComboBox1_SelectionChangeCommitted);
			// 
			// label13
			// 
			this.label13.BackColor = System.Drawing.Color.Transparent;
			this.label13.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.label13.ForeColor = System.Drawing.Color.Blue;
			this.label13.Location = new System.Drawing.Point(520, 8);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(64, 23);
			this.label13.TabIndex = 243;
			this.label13.Text = "货品编号";
			this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label4
			// 
			this.label4.BackColor = System.Drawing.Color.Transparent;
			this.label4.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.label4.Location = new System.Drawing.Point(488, 32);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(96, 23);
			this.label4.TabIndex = 239;
			this.label4.Text = "货物中文名称";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txt4
			// 
			this.txt4.BackColor = System.Drawing.Color.White;
			this.txt4.DataField = "item_name_cn";
			this.txt4.DataType = TJSystem.Public.DataType.String;
			this.txt4.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.txt4.Location = new System.Drawing.Point(592, 32);
			this.txt4.Name = "txt4";
			this.txt4.Size = new System.Drawing.Size(160, 23);
			this.txt4.TabIndex = 240;
			this.txt4.Text = "";
			// 
			// txt8
			// 
			this.txt8.BackColor = System.Drawing.Color.White;
			this.txt8.DataField = "unit";
			this.txt8.DataType = TJSystem.Public.DataType.String;
			this.txt8.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.txt8.Location = new System.Drawing.Point(352, 80);
			this.txt8.Name = "txt8";
			this.txt8.Size = new System.Drawing.Size(136, 23);
			this.txt8.TabIndex = 236;
			this.txt8.Text = "";
			// 
			// label12
			// 
			this.label12.BackColor = System.Drawing.Color.Transparent;
			this.label12.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.label12.ForeColor = System.Drawing.Color.Blue;
			this.label12.Location = new System.Drawing.Point(280, 80);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(64, 23);
			this.label12.TabIndex = 234;
			this.label12.Text = "单位";
			this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txt7
			// 
			this.txt7.BackColor = System.Drawing.Color.Yellow;
			this.txt7.DataField = "item_qty";
			this.txt7.DataType = TJSystem.Public.DataType.String;
			this.txt7.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.txt7.Location = new System.Drawing.Point(120, 80);
			this.txt7.Name = "txt7";
			this.txt7.Size = new System.Drawing.Size(160, 23);
			this.txt7.TabIndex = 235;
			this.txt7.Text = "";
			// 
			// label14
			// 
			this.label14.BackColor = System.Drawing.Color.Transparent;
			this.label14.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.label14.ForeColor = System.Drawing.Color.Blue;
			this.label14.Location = new System.Drawing.Point(48, 80);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(64, 23);
			this.label14.TabIndex = 233;
			this.label14.Text = "询价数量";
			this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txt6
			// 
			this.txt6.BackColor = System.Drawing.Color.White;
			this.txt6.DataField = "item_desc_cn";
			this.txt6.DataType = TJSystem.Public.DataType.String;
			this.txt6.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.txt6.Location = new System.Drawing.Point(352, 56);
			this.txt6.Name = "txt6";
			this.txt6.Size = new System.Drawing.Size(136, 23);
			this.txt6.TabIndex = 230;
			this.txt6.Text = "";
			// 
			// priComboBox2
			// 
			this.priComboBox2.BackColor = System.Drawing.Color.White;
			this.priComboBox2.DataField = "client_itemcode";
			this.priComboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.priComboBox2.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.priComboBox2.ItemHeight = 14;
			this.priComboBox2.Location = new System.Drawing.Point(120, 32);
			this.priComboBox2.Name = "priComboBox2";
			this.priComboBox2.Size = new System.Drawing.Size(160, 22);
			this.priComboBox2.TabIndex = 229;
			// 
			// label32
			// 
			this.label32.BackColor = System.Drawing.Color.Transparent;
			this.label32.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.label32.Location = new System.Drawing.Point(64, 104);
			this.label32.Name = "label32";
			this.label32.Size = new System.Drawing.Size(40, 23);
			this.label32.TabIndex = 226;
			this.label32.Text = "备注";
			this.label32.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txt9
			// 
			this.txt9.BackColor = System.Drawing.Color.White;
			this.txt9.DataField = "remark";
			this.txt9.DataType = TJSystem.Public.DataType.String;
			this.txt9.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.txt9.Location = new System.Drawing.Point(120, 104);
			this.txt9.Name = "txt9";
			this.txt9.Size = new System.Drawing.Size(616, 23);
			this.txt9.TabIndex = 227;
			this.txt9.Text = "";
			// 
			// label9
			// 
			this.label9.BackColor = System.Drawing.Color.Transparent;
			this.label9.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.label9.Location = new System.Drawing.Point(280, 56);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(64, 23);
			this.label9.TabIndex = 219;
			this.label9.Text = "中文规格";
			this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txt5
			// 
			this.txt5.BackColor = System.Drawing.Color.White;
			this.txt5.DataField = "item_desc";
			this.txt5.DataType = TJSystem.Public.DataType.String;
			this.txt5.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.txt5.Location = new System.Drawing.Point(120, 56);
			this.txt5.Name = "txt5";
			this.txt5.Size = new System.Drawing.Size(160, 23);
			this.txt5.TabIndex = 220;
			this.txt5.Text = "";
			// 
			// label3
			// 
			this.label3.BackColor = System.Drawing.Color.Transparent;
			this.label3.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.label3.Location = new System.Drawing.Point(48, 56);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(64, 23);
			this.label3.TabIndex = 217;
			this.label3.Text = "英文规格";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txt2
			// 
			this.txt2.BackColor = System.Drawing.Color.White;
			this.txt2.DataField = "seq_no";
			this.txt2.DataType = TJSystem.Public.DataType.String;
			this.txt2.Enabled = false;
			this.txt2.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.txt2.Location = new System.Drawing.Point(352, 8);
			this.txt2.Name = "txt2";
			this.txt2.Size = new System.Drawing.Size(136, 23);
			this.txt2.TabIndex = 215;
			this.txt2.Text = "";
			// 
			// label11
			// 
			this.label11.BackColor = System.Drawing.Color.Transparent;
			this.label11.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.label11.ForeColor = System.Drawing.Color.Blue;
			this.label11.Location = new System.Drawing.Point(32, 32);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(80, 23);
			this.label11.TabIndex = 213;
			this.label11.Text = "客人货号";
			this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label8
			// 
			this.label8.BackColor = System.Drawing.Color.Transparent;
			this.label8.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.label8.ForeColor = System.Drawing.Color.Blue;
			this.label8.Location = new System.Drawing.Point(288, 8);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(64, 23);
			this.label8.TabIndex = 212;
			this.label8.Text = "货品序号";
			this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label7
			// 
			this.label7.BackColor = System.Drawing.Color.Transparent;
			this.label7.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.label7.Location = new System.Drawing.Point(280, 32);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(64, 23);
			this.label7.TabIndex = 211;
			this.label7.Text = "货物名称";
			this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label2
			// 
			this.label2.BackColor = System.Drawing.Color.Transparent;
			this.label2.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.label2.ForeColor = System.Drawing.Color.Blue;
			this.label2.Location = new System.Drawing.Point(32, 8);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(80, 23);
			this.label2.TabIndex = 210;
			this.label2.Text = "报价单号";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txt3
			// 
			this.txt3.BackColor = System.Drawing.Color.White;
			this.txt3.DataField = "item_name";
			this.txt3.DataType = TJSystem.Public.DataType.String;
			this.txt3.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.txt3.Location = new System.Drawing.Point(352, 32);
			this.txt3.Name = "txt3";
			this.txt3.Size = new System.Drawing.Size(136, 23);
			this.txt3.TabIndex = 216;
			this.txt3.Text = "";
			// 
			// txt1
			// 
			this.txt1.BackColor = System.Drawing.Color.White;
			this.txt1.DataField = "ce_code";
			this.txt1.DataType = TJSystem.Public.DataType.String;
			this.txt1.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.txt1.Location = new System.Drawing.Point(120, 8);
			this.txt1.Name = "txt1";
			this.txt1.Size = new System.Drawing.Size(160, 23);
			this.txt1.TabIndex = 214;
			this.txt1.Text = "";
			// 
			// dataGrid3
			// 
			this.dataGrid3.DataMember = "";
			this.dataGrid3.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.dataGrid3.Location = new System.Drawing.Point(0, 0);
			this.dataGrid3.Name = "dataGrid3";
			this.dataGrid3.TabIndex = 0;
			// 
			// dataGrid2
			// 
			this.dataGrid2.DataMember = "";
			this.dataGrid2.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.dataGrid2.Location = new System.Drawing.Point(0, 0);
			this.dataGrid2.Name = "dataGrid2";
			this.dataGrid2.TabIndex = 0;
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
			// tel1
			// 
			this.tel1.Format = "";
			this.tel1.FormatInfo = null;
			this.tel1.HeaderText = "电话1";
			this.tel1.MappingName = "tel1";
			this.tel1.NullText = "";
			this.tel1.Width = 75;
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
			// postcode
			// 
			this.postcode.Format = "";
			this.postcode.FormatInfo = null;
			this.postcode.HeaderText = "邮政编码";
			this.postcode.MappingName = "postcode";
			this.postcode.NullText = "";
			this.postcode.Width = 75;
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
			// dataGridTextBoxColumn3
			// 
			this.dataGridTextBoxColumn3.Format = "";
			this.dataGridTextBoxColumn3.FormatInfo = null;
			this.dataGridTextBoxColumn3.HeaderText = "英文名";
			this.dataGridTextBoxColumn3.MappingName = "";
			this.dataGridTextBoxColumn3.NullText = "";
			this.dataGridTextBoxColumn3.Width = 75;
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
			// dataGridTextBoxColumn2
			// 
			this.dataGridTextBoxColumn2.Format = "";
			this.dataGridTextBoxColumn2.FormatInfo = null;
			this.dataGridTextBoxColumn2.HeaderText = "员工姓名";
			this.dataGridTextBoxColumn2.MappingName = "";
			this.dataGridTextBoxColumn2.NullText = "";
			this.dataGridTextBoxColumn2.Width = 75;
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
			// corporation
			// 
			this.corporation.Format = "";
			this.corporation.FormatInfo = null;
			this.corporation.HeaderText = "公司法人";
			this.corporation.MappingName = "corporation";
			this.corporation.NullText = "";
			this.corporation.Width = 75;
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
			// address
			// 
			this.address.Format = "";
			this.address.FormatInfo = null;
			this.address.HeaderText = "地址";
			this.address.MappingName = "address";
			this.address.NullText = "";
			this.address.Width = 75;
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
			// panel3
			// 
			this.panel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel3.BackgroundImage")));
			this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.panel3.Controls.Add(this.priToolBar1);
			this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panel3.Location = new System.Drawing.Point(0, 454);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(776, 40);
			this.panel3.TabIndex = 12;
			// 
			// priToolBar1
			// 
			this.priToolBar1.DGEnable = true;
			this.priToolBar1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.priToolBar1.Location = new System.Drawing.Point(0, -4);
			this.priToolBar1.Name = "priToolBar1";
			this.priToolBar1.setCurrentForm = null;
			this.priToolBar1.Size = new System.Drawing.Size(772, 40);
			this.priToolBar1.TabIndex = 0;
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
			// fax2
			// 
			this.fax2.Format = "";
			this.fax2.FormatInfo = null;
			this.fax2.HeaderText = "传真2";
			this.fax2.MappingName = "fax2";
			this.fax2.NullText = "";
			this.fax2.Width = 75;
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
			// createby
			// 
			this.createby.Format = "";
			this.createby.FormatInfo = null;
			this.createby.HeaderText = "建立者";
			this.createby.MappingName = "createby";
			this.createby.NullText = "";
			this.createby.Width = 75;
			// 
			// panel1
			// 
			this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
			this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.panel1.Controls.Add(this.label1);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(776, 48);
			this.panel1.TabIndex = 10;
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label1.Font = new System.Drawing.Font("宋体", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.label1.Location = new System.Drawing.Point(0, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(772, 44);
			this.label1.TabIndex = 0;
			this.label1.Text = "询价明细";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// frmCEDetail
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(7, 16);
			this.BackColor = System.Drawing.SystemColors.ScrollBar;
			this.ClientSize = new System.Drawing.Size(776, 494);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel3);
			this.Controls.Add(this.panel1);
			this.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "frmCEDetail";
			this.ShowInTaskbar = false;
			this.Text = "客户询价处理";
			this.Closed += new System.EventHandler(this.frmCEDetail_Closed);
			this.panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).EndInit();
			this.panel4.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGrid3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGrid2)).EndInit();
			this.panel3.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion


		private void dataGrid1_Click(object sender, System.EventArgs e)
		{
			System.Text.StringBuilder sb = new System.Text.StringBuilder();
			sb.Append("select ce_code,item_code,client_itemcode,item_name_cn,item_desc,item_desc_cn,isQuote,unit,");
			sb.Append("item_qty,seq_no,remark,item_name ");
			sb.Append("from sale_ce_detail ");
			sb.Append("where ce_code = '"+ this.dataGrid1[this.dataGrid1.CurrentCell.RowNumber,0] +"'");
			sb.Append("order by ce_code");
//			this.InitialGrid1(sb.ToString());
			
		}



		protected override void OnClosing(CancelEventArgs e)
		{			
//			if(MessageBox.Show("确定退出？（Y/N）","确认",MessageBoxButtons.YesNo,MessageBoxIcon.Information) == System.Windows.Forms.DialogResult.No)
//			{
//				e.Cancel = true;
//			}
			base.OnClosing (e);
		}


		private void frmCEDetail_Closed(object sender, System.EventArgs e)
		{
			frmSaleCE.Count = 0;
		}

		private void priComboBox1_SelectionChangeCommitted(object sender, System.EventArgs e)
		{
			string sql = "select a.client_itemcode as client_itemcode,a.client_itemcode +' '+c.client_name as client_name from basic_clientItemCode a join basic_item b on a.item_code = b.item_code join basic_client c on c.client_id = a.client_id  where b.item_code = '"+ this.priComboBox1.SelectedValue +"' ";
			DataTable dt = TJSystem.Public.PublicStatic.db.GetDataTable(sql);
			DataTable dtcpy = null;
			DataRow dr = null;
			dr = dt.NewRow();
			dr[0] = "";
			dr[1] = "";
			dt.Rows.InsertAt(dr,0);
			dtcpy = dt.Copy();
			this.priComboBox2.DataSource = dtcpy.DefaultView;
			this.priComboBox2.ValueMember = "client_itemcode";
			this.priComboBox2.DisplayMember = "client_name";
			this.priComboBox2.Enabled = true;

			sql = "select a.item_name,a.item_name_cn,a.item_desc,a.item_desc_cn,a.minorder,a.unit,b.unit_name_cn as unit_name_cn,a.saleprice,a.remark from basic_item a left join p_unit b on a.unit = b.unit_id where a.item_code = '"+ this.priComboBox1.SelectedValue +"'";
			dt = TJSystem.Public.PublicStatic.db.GetDataTable(sql);
			if(dt.Rows.Count == 0)
			{
				return;
			}
			this.txt3.Text = dt.Rows[0]["item_name"].ToString().Trim();
			this.txt4.Text = dt.Rows[0]["item_name_cn"].ToString().Trim();
			this.txt5.Text = dt.Rows[0]["item_desc"].ToString().Trim();
			this.txt6.Text = dt.Rows[0]["item_desc_cn"].ToString().Trim();
			
			this.txt8.Text = dt.Rows[0]["unit"].ToString().Trim();
			this.txt9.Text = dt.Rows[0]["remark"].ToString().Trim();
		}

		private void InitialFormDataWithDataGridFunc()
		{
			string sql = null;
			DataTable dt = null;
			DataRow dr = null;
			DataTable dtcpy = null;
			if(((System.Data.DataView)this.dataGrid1.DataSource).Count == 0)
			{
				return;
			}
			
			if(priComboBox1.SelectedValue == null)
			{
				return;
			}
			sql = "select a.client_itemcode as client_itemcode,a.client_itemcode +' '+c.client_name as client_name from basic_clientItemCode a join basic_item b on a.item_code = b.item_code join basic_client c on c.client_id = a.client_id  where b.item_code = '"+ this.priComboBox1.SelectedValue +"' ";
			dt = TJSystem.Public.PublicStatic.db.GetDataTable(sql);
			if(dt.Rows.Count == 0)
			{
				return;
			}
			dr = dt.NewRow();
			dr[0] = "";
			dr[1] = "";
			dt.Rows.InsertAt(dr,0);
			dtcpy = dt.Copy();
			this.priComboBox2.DataSource = dtcpy.DefaultView;
			this.priComboBox2.ValueMember = "client_itemcode";
			this.priComboBox2.DisplayMember = "client_name";
			this.priComboBox2.SelectedValue = ((System.Data.DataView)this.dataGrid1.DataSource)[this.dataGrid1.CurrentRowIndex]["client_itemcode"].ToString();
		}
		
	}
}

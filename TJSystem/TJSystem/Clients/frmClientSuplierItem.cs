using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace TJSystem.Clients
{
	/// <summary>
	/// Form1 的摘要说明。
	/// </summary>
	public class frmClientSuplierItem : System.Windows.Forms.Form
	{
		
		
		/// <summary>
		/// 必需的设计器变量。
		/// </summary>
		private System.ComponentModel.Container components = null;
		private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn2;
		private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn3;
		private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn1;
		private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn4;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.DataGridTableStyle dataGridTableStyle1;
		private System.Windows.Forms.DataGrid dataGrid1;
		private System.Windows.Forms.Panel panel4;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label2;
		private TJSystem.Classes.PriTextBox priTextBox13;
		private TJSystem.Classes.PriTextBox priTextBox12;
		private TJSystem.Classes.PriTextBox priTextBox9;
		private TJSystem.Classes.PriTextBox priTextBox7;
		private TJSystem.Classes.PriTextBox priTextBox5;
		private TJSystem.Classes.PriTextBox priTextBox4;
		private TJSystem.Classes.PriTextBox priTextBox3;
		private System.Windows.Forms.Panel panel3;
		private TJSystem.UC.PriToolBar priToolBar1;
		private TJSystem.Classes.PriTextBox priTextBox1;
		public static System.Windows.Forms.Form frmCurrent = null ;

		private string _table = null;
		private System.Windows.Forms.Label label5;
		private TJSystem.Classes.PriTextBox priTextBox2;
		private TJSystem.Classes.PriComboBox priComboBox1;
		private string _PK = null;
		private System.Windows.Forms.Label label1;
		private TJSystem.Classes.PriTextBox priTextBox6;
		private System.Windows.Forms.DataGridTextBoxColumn seq_no;
		private System.Windows.Forms.DataGridTextBoxColumn item_code;
		private System.Windows.Forms.DataGridTextBoxColumn item_name;
		private System.Windows.Forms.DataGridTextBoxColumn item_name_cn;
		private System.Windows.Forms.DataGridTextBoxColumn item_desc;
		private System.Windows.Forms.DataGridTextBoxColumn item_desc_cn;
		private System.Windows.Forms.DataGridTextBoxColumn minorder;
		private System.Windows.Forms.DataGridTextBoxColumn unit_name_cn;
		private System.Windows.Forms.DataGridTextBoxColumn ref_price;
		private System.Windows.Forms.DataGridTextBoxColumn sale_price;
		private System.Windows.Forms.DataGridTextBoxColumn remark;
		private TJSystem.Classes.PriTextBox priTextBox8;
		private string _supplier = null;

		public frmClientSuplierItem(string supplier)
		{
			//
			// Windows 窗体设计器支持所必需的
			//
			InitializeComponent();
			

			TJSystem.Public.PublicStatic.setBackgroundImg(this.panel2,this.panel2.GetType().ToString(),"");
			TJSystem.Public.PublicStatic.setBackgroundImg(this.panel3,this.panel2.GetType().ToString(),"");
			TJSystem.Public.PublicStatic.setBackgroundImg(this.panel4,this.panel2.GetType().ToString(),"");


			_supplier = supplier;
			this.priTextBox1.Text = supplier;

			if(!InitialFormData())
			{
				return;
			}
			System.Text.StringBuilder sb = new System.Text.StringBuilder();
			sb.Append("select a.supplier_id,a.seq_no,a.item_code,a.item_name,a.item_name_cn,a.item_desc,a.item_desc_cn,");
			sb.Append(" a.minorder,a.unit,b.unit_name_cn as unit_name_cn,a.ref_price,a.sale_price,a.remark ");
			sb.Append(" from basic_suppitemlist a");
			sb.Append(" left join p_unit b on a.unit=b.unit_id");
			sb.Append(" where a.supplier_id='");
			sb.Append(supplier);
			sb.Append("' order by a.seq_no");
			this.InitialGrid(sb.ToString());
			//			this.textBox1.DataField = "PNO";
			priToolBar1.setCurrentForm = this;
			_table = "basic_suppitemlist";
			_PK = "supplier_id,seq_no";
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

		private bool InitialFormData()
		{
			DataTable dt = null;
			
			System.Text.StringBuilder sb = new System.Text.StringBuilder();
			sb.Append("select d.ITEM_CODE,d.ITEM_CODE+' '+d.ITEM_NAME_CN as ITEM_NAME_CN from basic_item d ");
			sb.Append(" where d.item_type in");
			sb.Append(" (");
			sb.Append(" select a.item_type from basic_supplier_itemsort a");
			sb.Append(" left join p_itemtype b on a.item_type=b.itemtype");
			sb.Append(" where a.supplier_id=");
			sb.Append("'");
			sb.Append(_supplier);
			sb.Append("'");
			sb.Append(" and a.status='1'");
			sb.Append(")");
			dt = TJSystem.Public.PublicStatic.db.GetDataTable(sb.ToString());
			if(dt.Rows.Count == 0)
			{
				TJSystem.Public.PublicStatic.ShowMessage(TJSystem.Public.MessageType.Exclamation,"当前供应商所提供的商品分类中没有货品可以提供，请先添加商品分类!");
				return false;
			}
			this.priComboBox1.DataSource = dt.DefaultView;
			this.priComboBox1.ValueMember = "ITEM_CODE";
			this.priComboBox1.DisplayMember = "ITEM_NAME_CN";			

			return true;
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

		private void AfterButtonClick(string sqltype)
		{
			if(sqltype.Equals("insert"))
			{			
				this.priComboBox1.Enabled = true;
				this.priTextBox2.Enabled = true;
				
				this.priTextBox5.Enabled = true;
				this.priTextBox6.Enabled = true;
				this.priTextBox12.Enabled = true;
				this.priTextBox9.Enabled = true;
			
				this.priComboBox1.Text = "";
				this.priTextBox2.Text = "";
				this.priTextBox5.Text = "";
				this.priTextBox6.Text = "";
				this.priTextBox9.Text = "";
				this.priTextBox12.Text = "";
			}
			else if(sqltype.Equals("update"))
			{
				
				this.priTextBox5.Enabled = true;
				this.priTextBox6.Enabled = true;
				this.priTextBox12.Enabled = true;
				this.priTextBox9.Enabled = true;
			}
		}

		private void InitialGrid(string sql)
		{		
			DataTable dt = TJSystem.Public.PublicStatic.db.GetDataTable(sql);
			dt.TableName = "basic_suppitemlist";
			this.dataGridTableStyle1.DataGrid.DataSource = dt.DefaultView;
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(frmClientSuplierItem));
			this.dataGridTextBoxColumn2 = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumn3 = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumn1 = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumn4 = new System.Windows.Forms.DataGridTextBoxColumn();
			this.panel2 = new System.Windows.Forms.Panel();
			this.dataGrid1 = new System.Windows.Forms.DataGrid();
			this.dataGridTableStyle1 = new System.Windows.Forms.DataGridTableStyle();
			this.seq_no = new System.Windows.Forms.DataGridTextBoxColumn();
			this.item_code = new System.Windows.Forms.DataGridTextBoxColumn();
			this.item_name = new System.Windows.Forms.DataGridTextBoxColumn();
			this.item_name_cn = new System.Windows.Forms.DataGridTextBoxColumn();
			this.item_desc = new System.Windows.Forms.DataGridTextBoxColumn();
			this.item_desc_cn = new System.Windows.Forms.DataGridTextBoxColumn();
			this.minorder = new System.Windows.Forms.DataGridTextBoxColumn();
			this.unit_name_cn = new System.Windows.Forms.DataGridTextBoxColumn();
			this.ref_price = new System.Windows.Forms.DataGridTextBoxColumn();
			this.sale_price = new System.Windows.Forms.DataGridTextBoxColumn();
			this.remark = new System.Windows.Forms.DataGridTextBoxColumn();
			this.panel4 = new System.Windows.Forms.Panel();
			this.priTextBox8 = new TJSystem.Classes.PriTextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.priTextBox6 = new TJSystem.Classes.PriTextBox();
			this.priComboBox1 = new TJSystem.Classes.PriComboBox();
			this.label5 = new System.Windows.Forms.Label();
			this.priTextBox2 = new TJSystem.Classes.PriTextBox();
			this.priTextBox1 = new TJSystem.Classes.PriTextBox();
			this.label14 = new System.Windows.Forms.Label();
			this.label13 = new System.Windows.Forms.Label();
			this.label12 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.priTextBox13 = new TJSystem.Classes.PriTextBox();
			this.priTextBox12 = new TJSystem.Classes.PriTextBox();
			this.priTextBox9 = new TJSystem.Classes.PriTextBox();
			this.priTextBox7 = new TJSystem.Classes.PriTextBox();
			this.priTextBox5 = new TJSystem.Classes.PriTextBox();
			this.priTextBox4 = new TJSystem.Classes.PriTextBox();
			this.priTextBox3 = new TJSystem.Classes.PriTextBox();
			this.panel3 = new System.Windows.Forms.Panel();
			this.priToolBar1 = new TJSystem.UC.PriToolBar();
			this.panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).BeginInit();
			this.panel4.SuspendLayout();
			this.panel3.SuspendLayout();
			this.SuspendLayout();
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
			this.panel2.Location = new System.Drawing.Point(0, 0);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(584, 422);
			this.panel2.TabIndex = 8;
			// 
			// dataGrid1
			// 
			this.dataGrid1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.dataGrid1.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.dataGrid1.CaptionText = "公司银行账号信息";
			this.dataGrid1.CaptionVisible = false;
			this.dataGrid1.DataMember = "";
			this.dataGrid1.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.dataGrid1.Location = new System.Drawing.Point(0, 176);
			this.dataGrid1.Name = "dataGrid1";
			this.dataGrid1.ReadOnly = true;
			this.dataGrid1.Size = new System.Drawing.Size(576, 232);
			this.dataGrid1.TabIndex = 1;
			this.dataGrid1.TableStyles.AddRange(new System.Windows.Forms.DataGridTableStyle[] {
																								  this.dataGridTableStyle1});
			// 
			// dataGridTableStyle1
			// 
			this.dataGridTableStyle1.AllowSorting = false;
			this.dataGridTableStyle1.DataGrid = this.dataGrid1;
			this.dataGridTableStyle1.GridColumnStyles.AddRange(new System.Windows.Forms.DataGridColumnStyle[] {
																												  this.seq_no,
																												  this.item_code,
																												  this.item_name,
																												  this.item_name_cn,
																												  this.item_desc,
																												  this.item_desc_cn,
																												  this.minorder,
																												  this.unit_name_cn,
																												  this.ref_price,
																												  this.sale_price,
																												  this.remark});
			this.dataGridTableStyle1.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.dataGridTableStyle1.MappingName = "basic_suppitemlist";
			this.dataGridTableStyle1.ReadOnly = true;
			// 
			// seq_no
			// 
			this.seq_no.Format = "";
			this.seq_no.FormatInfo = null;
			this.seq_no.HeaderText = "编号";
			this.seq_no.MappingName = "seq_no";
			this.seq_no.NullText = "";
			this.seq_no.Width = 75;
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
			this.item_name.HeaderText = "货品名称";
			this.item_name.MappingName = "item_name";
			this.item_name.NullText = "";
			this.item_name.Width = 75;
			// 
			// item_name_cn
			// 
			this.item_name_cn.Format = "";
			this.item_name_cn.FormatInfo = null;
			this.item_name_cn.HeaderText = "中文名称";
			this.item_name_cn.MappingName = "item_name_cn";
			this.item_name_cn.NullText = "";
			this.item_name_cn.Width = 75;
			// 
			// item_desc
			// 
			this.item_desc.Format = "";
			this.item_desc.FormatInfo = null;
			this.item_desc.HeaderText = "货品描述";
			this.item_desc.MappingName = "item_desc";
			this.item_desc.NullText = "";
			this.item_desc.Width = 75;
			// 
			// item_desc_cn
			// 
			this.item_desc_cn.Format = "";
			this.item_desc_cn.FormatInfo = null;
			this.item_desc_cn.HeaderText = "中文描述";
			this.item_desc_cn.MappingName = "item_desc_cn";
			this.item_desc_cn.NullText = "";
			this.item_desc_cn.Width = 75;
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
			// unit_name_cn
			// 
			this.unit_name_cn.Format = "";
			this.unit_name_cn.FormatInfo = null;
			this.unit_name_cn.HeaderText = "单位";
			this.unit_name_cn.MappingName = "unit_name_cn";
			this.unit_name_cn.NullText = "";
			this.unit_name_cn.Width = 75;
			// 
			// ref_price
			// 
			this.ref_price.Format = "";
			this.ref_price.FormatInfo = null;
			this.ref_price.HeaderText = "采购价格";
			this.ref_price.MappingName = "ref_price";
			this.ref_price.NullText = "";
			this.ref_price.Width = 75;
			// 
			// sale_price
			// 
			this.sale_price.Format = "";
			this.sale_price.FormatInfo = null;
			this.sale_price.HeaderText = "销售价格";
			this.sale_price.MappingName = "sale_price";
			this.sale_price.NullText = "";
			this.sale_price.Width = 75;
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
			this.panel4.Controls.Add(this.priTextBox8);
			this.panel4.Controls.Add(this.label1);
			this.panel4.Controls.Add(this.priTextBox6);
			this.panel4.Controls.Add(this.priComboBox1);
			this.panel4.Controls.Add(this.label5);
			this.panel4.Controls.Add(this.priTextBox2);
			this.panel4.Controls.Add(this.priTextBox1);
			this.panel4.Controls.Add(this.label14);
			this.panel4.Controls.Add(this.label13);
			this.panel4.Controls.Add(this.label12);
			this.panel4.Controls.Add(this.label11);
			this.panel4.Controls.Add(this.label10);
			this.panel4.Controls.Add(this.label9);
			this.panel4.Controls.Add(this.label7);
			this.panel4.Controls.Add(this.label4);
			this.panel4.Controls.Add(this.label2);
			this.panel4.Controls.Add(this.priTextBox13);
			this.panel4.Controls.Add(this.priTextBox12);
			this.panel4.Controls.Add(this.priTextBox9);
			this.panel4.Controls.Add(this.priTextBox7);
			this.panel4.Controls.Add(this.priTextBox5);
			this.panel4.Controls.Add(this.priTextBox4);
			this.panel4.Controls.Add(this.priTextBox3);
			this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel4.Location = new System.Drawing.Point(0, 0);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(580, 168);
			this.panel4.TabIndex = 0;
			// 
			// priTextBox8
			// 
			this.priTextBox8.BackColor = System.Drawing.Color.White;
			this.priTextBox8.DataField = "unit";
			this.priTextBox8.DataType = TJSystem.Public.DataType.String;
			this.priTextBox8.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.priTextBox8.ForeColor = System.Drawing.Color.Black;
			this.priTextBox8.Location = new System.Drawing.Point(96, 104);
			this.priTextBox8.Name = "priTextBox8";
			this.priTextBox8.Size = new System.Drawing.Size(120, 23);
			this.priTextBox8.TabIndex = 153;
			this.priTextBox8.Text = "";
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Location = new System.Drawing.Point(24, 136);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(64, 23);
			this.label1.TabIndex = 152;
			this.label1.Text = "备注";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// priTextBox6
			// 
			this.priTextBox6.BackColor = System.Drawing.Color.White;
			this.priTextBox6.DataField = "remark";
			this.priTextBox6.DataType = TJSystem.Public.DataType.String;
			this.priTextBox6.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.priTextBox6.ForeColor = System.Drawing.Color.Black;
			this.priTextBox6.Location = new System.Drawing.Point(96, 136);
			this.priTextBox6.Name = "priTextBox6";
			this.priTextBox6.Size = new System.Drawing.Size(472, 23);
			this.priTextBox6.TabIndex = 151;
			this.priTextBox6.Text = "";
			// 
			// priComboBox1
			// 
			this.priComboBox1.BackColor = System.Drawing.Color.White;
			this.priComboBox1.DataField = "item_code";
			this.priComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.priComboBox1.Location = new System.Drawing.Point(288, 8);
			this.priComboBox1.Name = "priComboBox1";
			this.priComboBox1.Size = new System.Drawing.Size(120, 22);
			this.priComboBox1.TabIndex = 149;
			this.priComboBox1.SelectionChangeCommitted += new System.EventHandler(this.priComboBox1_SelectionChangeCommitted);
			// 
			// label5
			// 
			this.label5.BackColor = System.Drawing.Color.Transparent;
			this.label5.ForeColor = System.Drawing.Color.Blue;
			this.label5.Location = new System.Drawing.Point(8, 8);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(80, 23);
			this.label5.TabIndex = 52;
			this.label5.Text = "货品序号";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// priTextBox2
			// 
			this.priTextBox2.BackColor = System.Drawing.Color.White;
			this.priTextBox2.DataField = "seq_no";
			this.priTextBox2.DataType = TJSystem.Public.DataType.String;
			this.priTextBox2.Enabled = false;
			this.priTextBox2.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.priTextBox2.ForeColor = System.Drawing.Color.Black;
			this.priTextBox2.Location = new System.Drawing.Point(96, 8);
			this.priTextBox2.Name = "priTextBox2";
			this.priTextBox2.Size = new System.Drawing.Size(80, 23);
			this.priTextBox2.TabIndex = 51;
			this.priTextBox2.Text = "";
			// 
			// priTextBox1
			// 
			this.priTextBox1.DataField = "supplier_id";
			this.priTextBox1.DataType = TJSystem.Public.DataType.String;
			this.priTextBox1.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.priTextBox1.Location = new System.Drawing.Point(424, 8);
			this.priTextBox1.Name = "priTextBox1";
			this.priTextBox1.Size = new System.Drawing.Size(128, 23);
			this.priTextBox1.TabIndex = 29;
			this.priTextBox1.Text = "";
			// 
			// label14
			// 
			this.label14.BackColor = System.Drawing.Color.Transparent;
			this.label14.Location = new System.Drawing.Point(224, 72);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(64, 23);
			this.label14.TabIndex = 28;
			this.label14.Text = "中文描述";
			this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label13
			// 
			this.label13.BackColor = System.Drawing.Color.Transparent;
			this.label13.ForeColor = System.Drawing.Color.Blue;
			this.label13.Location = new System.Drawing.Point(8, 104);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(80, 23);
			this.label13.TabIndex = 27;
			this.label13.Text = "单位";
			this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label12
			// 
			this.label12.BackColor = System.Drawing.Color.Transparent;
			this.label12.Location = new System.Drawing.Point(8, 40);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(80, 23);
			this.label12.TabIndex = 26;
			this.label12.Text = "货品名称";
			this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label11
			// 
			this.label11.BackColor = System.Drawing.Color.Transparent;
			this.label11.Location = new System.Drawing.Point(224, 40);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(64, 23);
			this.label11.TabIndex = 25;
			this.label11.Text = "中文名称";
			this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label10
			// 
			this.label10.BackColor = System.Drawing.Color.Transparent;
			this.label10.ForeColor = System.Drawing.Color.Blue;
			this.label10.Location = new System.Drawing.Point(416, 40);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(80, 23);
			this.label10.TabIndex = 24;
			this.label10.Text = "最小订货量";
			this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label9
			// 
			this.label9.BackColor = System.Drawing.Color.Transparent;
			this.label9.ForeColor = System.Drawing.Color.Blue;
			this.label9.Location = new System.Drawing.Point(224, 104);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(64, 23);
			this.label9.TabIndex = 23;
			this.label9.Text = "采购价格";
			this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label7
			// 
			this.label7.BackColor = System.Drawing.Color.Transparent;
			this.label7.Location = new System.Drawing.Point(8, 72);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(80, 23);
			this.label7.TabIndex = 21;
			this.label7.Text = "货品描述";
			this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label4
			// 
			this.label4.BackColor = System.Drawing.Color.Transparent;
			this.label4.ForeColor = System.Drawing.Color.Blue;
			this.label4.Location = new System.Drawing.Point(392, 104);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(72, 23);
			this.label4.TabIndex = 18;
			this.label4.Text = "销售价格";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label2
			// 
			this.label2.BackColor = System.Drawing.Color.Transparent;
			this.label2.ForeColor = System.Drawing.Color.Blue;
			this.label2.Location = new System.Drawing.Point(224, 8);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(64, 23);
			this.label2.TabIndex = 16;
			this.label2.Text = "货品代码";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// priTextBox13
			// 
			this.priTextBox13.BackColor = System.Drawing.Color.White;
			this.priTextBox13.DataField = "item_desc";
			this.priTextBox13.DataType = TJSystem.Public.DataType.String;
			this.priTextBox13.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.priTextBox13.ForeColor = System.Drawing.Color.Black;
			this.priTextBox13.Location = new System.Drawing.Point(96, 72);
			this.priTextBox13.Name = "priTextBox13";
			this.priTextBox13.Size = new System.Drawing.Size(120, 23);
			this.priTextBox13.TabIndex = 14;
			this.priTextBox13.Text = "";
			// 
			// priTextBox12
			// 
			this.priTextBox12.BackColor = System.Drawing.Color.White;
			this.priTextBox12.DataField = "minorder";
			this.priTextBox12.DataType = TJSystem.Public.DataType.String;
			this.priTextBox12.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.priTextBox12.ForeColor = System.Drawing.Color.Black;
			this.priTextBox12.Location = new System.Drawing.Point(504, 40);
			this.priTextBox12.Name = "priTextBox12";
			this.priTextBox12.Size = new System.Drawing.Size(64, 23);
			this.priTextBox12.TabIndex = 13;
			this.priTextBox12.Text = "";
			// 
			// priTextBox9
			// 
			this.priTextBox9.BackColor = System.Drawing.Color.White;
			this.priTextBox9.DataField = "ref_price";
			this.priTextBox9.DataType = TJSystem.Public.DataType.String;
			this.priTextBox9.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.priTextBox9.ForeColor = System.Drawing.Color.Black;
			this.priTextBox9.Location = new System.Drawing.Point(288, 104);
			this.priTextBox9.Name = "priTextBox9";
			this.priTextBox9.Size = new System.Drawing.Size(80, 23);
			this.priTextBox9.TabIndex = 10;
			this.priTextBox9.Text = "";
			// 
			// priTextBox7
			// 
			this.priTextBox7.BackColor = System.Drawing.Color.White;
			this.priTextBox7.DataField = "item_desc_cn";
			this.priTextBox7.DataType = TJSystem.Public.DataType.String;
			this.priTextBox7.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.priTextBox7.ForeColor = System.Drawing.Color.Black;
			this.priTextBox7.Location = new System.Drawing.Point(288, 72);
			this.priTextBox7.Name = "priTextBox7";
			this.priTextBox7.Size = new System.Drawing.Size(280, 23);
			this.priTextBox7.TabIndex = 8;
			this.priTextBox7.Text = "";
			// 
			// priTextBox5
			// 
			this.priTextBox5.BackColor = System.Drawing.Color.White;
			this.priTextBox5.DataField = "sale_price";
			this.priTextBox5.DataType = TJSystem.Public.DataType.String;
			this.priTextBox5.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.priTextBox5.ForeColor = System.Drawing.Color.Black;
			this.priTextBox5.Location = new System.Drawing.Point(472, 104);
			this.priTextBox5.Name = "priTextBox5";
			this.priTextBox5.Size = new System.Drawing.Size(96, 23);
			this.priTextBox5.TabIndex = 6;
			this.priTextBox5.Text = "";
			// 
			// priTextBox4
			// 
			this.priTextBox4.BackColor = System.Drawing.Color.White;
			this.priTextBox4.DataField = "item_name_cn";
			this.priTextBox4.DataType = TJSystem.Public.DataType.String;
			this.priTextBox4.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.priTextBox4.ForeColor = System.Drawing.Color.Black;
			this.priTextBox4.Location = new System.Drawing.Point(288, 40);
			this.priTextBox4.Name = "priTextBox4";
			this.priTextBox4.Size = new System.Drawing.Size(120, 23);
			this.priTextBox4.TabIndex = 5;
			this.priTextBox4.Text = "";
			// 
			// priTextBox3
			// 
			this.priTextBox3.BackColor = System.Drawing.Color.White;
			this.priTextBox3.DataField = "item_name";
			this.priTextBox3.DataType = TJSystem.Public.DataType.String;
			this.priTextBox3.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.priTextBox3.ForeColor = System.Drawing.Color.Black;
			this.priTextBox3.Location = new System.Drawing.Point(96, 40);
			this.priTextBox3.Name = "priTextBox3";
			this.priTextBox3.Size = new System.Drawing.Size(120, 23);
			this.priTextBox3.TabIndex = 3;
			this.priTextBox3.Text = "";
			// 
			// panel3
			// 
			this.panel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel3.BackgroundImage")));
			this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.panel3.Controls.Add(this.priToolBar1);
			this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panel3.Location = new System.Drawing.Point(0, 422);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(584, 40);
			this.panel3.TabIndex = 9;
			// 
			// priToolBar1
			// 
			this.priToolBar1.DGEnable = true;
			this.priToolBar1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.priToolBar1.Location = new System.Drawing.Point(0, -4);
			this.priToolBar1.Name = "priToolBar1";
			this.priToolBar1.setCurrentForm = null;
			this.priToolBar1.Size = new System.Drawing.Size(580, 40);
			this.priToolBar1.TabIndex = 0;
			// 
			// frmClientSuplierItem
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(7, 16);
			this.BackColor = System.Drawing.SystemColors.ScrollBar;
			this.ClientSize = new System.Drawing.Size(584, 462);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel3);
			this.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "frmClientSuplierItem";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "供应商管理";
			this.panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).EndInit();
			this.panel4.ResumeLayout(false);
			this.panel3.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		private void setDisable()
		{
			
			this.priTextBox1.Enabled = false;
			this.priTextBox12.Enabled = false;
			this.priTextBox13.Enabled = false;
			this.priTextBox2.Enabled = false;
			this.priTextBox3.Enabled = false;
			this.priTextBox4.Enabled = false;
			this.priTextBox5.Enabled = false;
			this.priTextBox6.Enabled = false;
			this.priTextBox7.Enabled = false;
			this.priTextBox8.Enabled = false;
			this.priTextBox9.Enabled = false;
			this.priComboBox1.Enabled = false;
		}

		/// <summary>
		/// 检查画面中的内容是否符合基本格式要求
		/// </summary>
		/// <param name="sqltype"></param>
		/// <returns></returns>
		private bool checkFormValue(string sqltype)
		{
			System.Text.StringBuilder sb = new System.Text.StringBuilder();
			sb.Append("数据验证错误：\r\n");
			
			//判断是否已经存在PK对应的记录
			if(sqltype.Equals("insert"))
			{
				if(TJSystem.Public.PublicStatic.IsExsist(_table,_PK,this.priToolBar1))
				{
					TJSystem.Public.PublicStatic.ShowMessage(TJSystem.Public.MessageType.Error,"已经存在该笔记录，请确认！");
					return false;
				}
				if(!TJSystem.Public.PublicStatic.IsNumDouble(this.priTextBox2.Text.Trim()))
				{
					TJSystem.Public.PublicStatic.ShowMessage(TJSystem.Public.MessageType.Error,"货品序号必须是数字，请确认！");
					return false;
				}
			}

			if(sqltype.Equals("insert") || sqltype.Equals("update"))
			{
				
			}	
			return true;
		}
		
		protected override void OnClosing(CancelEventArgs e)
		{			
//			if(MessageBox.Show("确定退出？（Y/N）","确认",MessageBoxButtons.YesNo,MessageBoxIcon.Information) == System.Windows.Forms.DialogResult.No)
//			{
//				e.Cancel = true;
//			}
			base.OnClosing (e);
		}

		private void priComboBox1_SelectionChangeCommitted(object sender, System.EventArgs e)
		{
			System.Text.StringBuilder sb = new System.Text.StringBuilder();
			sb.Append("select a.item_code,a.item_name,a.item_name_cn,a.item_desc,a.item_desc_cn,a.unit from basic_item a ");
			sb.Append(" where a.item_code =");
			sb.Append("'");
			sb.Append(this.priComboBox1.SelectedValue.ToString());
			sb.Append("'");

			System.Data.DataTable dt = new DataTable();
			dt = TJSystem.Public.PublicStatic.db.GetDataTable(sb.ToString());

			if(dt.Rows.Count != 1)
			{
				TJSystem.Public.PublicStatic.ShowMessage(TJSystem.Public.MessageType.Error,"商品编码不唯一，请联系系统管理员确认！");
				return;
			}

			this.priTextBox3.Text = dt.Rows[0]["item_name"].ToString();
			this.priTextBox4.Text = dt.Rows[0]["item_name_cn"].ToString();
			this.priTextBox13.Text = dt.Rows[0]["item_desc"].ToString();
			this.priTextBox7.Text = dt.Rows[0]["item_desc_cn"].ToString();
			this.priTextBox8.Text = dt.Rows[0]["unit"].ToString();
		}
	}
}

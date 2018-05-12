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
	public class frmBasicItemPack : System.Windows.Forms.Form
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
		private System.Windows.Forms.Panel panel3;
		private TJSystem.UC.PriToolBar priToolBar1;
		public static System.Windows.Forms.Form frmCurrent = null ;

		private string _table = null;
		private TJSystem.Classes.PriComboBox priComboBox2;
		private TJSystem.Classes.PriTextBox txt1;
		private string _PK = null;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.DataGridTextBoxColumn item_code;
		private System.Windows.Forms.Label label2;
		private TJSystem.Classes.PriTextBox priTextBox3;
		private System.Windows.Forms.Label label4;
		private TJSystem.Classes.PriTextBox priTextBox4;
		private TJSystem.Classes.PriTextBox priTextBox5;
		private System.Windows.Forms.Label label7;
		private TJSystem.Classes.PriTextBox priTextBox6;
		private System.Windows.Forms.Label label8;
		private TJSystem.Classes.PriTextBox priTextBox7;
		private System.Windows.Forms.Label label9;
		private TJSystem.Classes.PriTextBox priTextBox8;
		private System.Windows.Forms.Label label10;
		private TJSystem.Classes.PriTextBox priTextBox9;
		private System.Windows.Forms.Label label11;
		private TJSystem.Classes.PriTextBox priTextBox12;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.Label label6;
		private TJSystem.Classes.PriComboBox priComboBox1;
		private System.Windows.Forms.Label label15;
		private TJSystem.Classes.PriComboBox priComboBox3;
		private System.Windows.Forms.Label label16;
		private TJSystem.Classes.PriTextBox priTextBox13;
		private System.Windows.Forms.Label label17;
		private TJSystem.Classes.PriTextBox priTextBox14;
		private System.Windows.Forms.DataGridTextBoxColumn seq_no;
		private System.Windows.Forms.DataGridTextBoxColumn pack_code;
		private System.Windows.Forms.DataGridTextBoxColumn description;
		private System.Windows.Forms.DataGridTextBoxColumn qtyprepack;
		private System.Windows.Forms.DataGridTextBoxColumn unit_name_cn;
		private System.Windows.Forms.DataGridTextBoxColumn pack_namecn;
		private System.Windows.Forms.DataGridTextBoxColumn length;
		private System.Windows.Forms.DataGridTextBoxColumn width;
		private System.Windows.Forms.DataGridTextBoxColumn height;
		private System.Windows.Forms.DataGridTextBoxColumn volumn;
		private System.Windows.Forms.DataGridTextBoxColumn grossweight;
		private System.Windows.Forms.DataGridTextBoxColumn netweight;
		private System.Windows.Forms.DataGridTextBoxColumn remark;
		private string _statusType = null;

		public frmBasicItemPack(string itemcode)
		{
			//
			// Windows 窗体设计器支持所必需的
			//
			InitializeComponent();

			_statusType = "";

			this.txt1.Text = itemcode;
			InitialFormData();

			System.Text.StringBuilder sb = new System.Text.StringBuilder();
			sb.Append("select a.item_code,a.seq_no,a.pack_code,a.description,a.qtyprepack,a.unit,a.outsiepacktype,a.length,a.width,a.height,a.volumn,");
			sb.Append(" a.grossweight,a.netweight,a.remark,b.unit_name_cn,c.pack_namecn");
			sb.Append("  from basic_item_packing a");
			sb.Append(" left join p_unit b on a.unit=b.unit_id");
			sb.Append(" left join p_packtype c on c.pack_code=a.outsiepacktype");
			sb.Append(" where a.item_code=");
			sb.Append("'");
			sb.Append(itemcode);
			sb.Append("'");
			
			sb.Append(" order by a.item_code,a.seq_no");
			
			priToolBar1.setCurrentForm = this;
			_table = "basic_item_packing";
			_PK = "item_code,seq_no";

			this.InitialGrid(sb.ToString());
			priToolBar1.Initial(_table,_PK,sb.ToString());
			priToolBar1.BeforeButtonClickEvent += new TJSystem.UC.PriToolBar.BeforeButotnClick(this.BeforeButtonClick);
			priToolBar1.AfterButtonClickEvent += new TJSystem.UC.PriToolBar.AfterButtonClick(this.AfterButtonClick);
			priToolBar1.setButtonVisibleFalse();
			priToolBar1.setButtonVisible("01234569");

			setDisable();
			//
			// TODO: 在 InitializeComponent 调用后添加任何构造函数代码
			//
		}
		private void InitialFormData()
		{
			DataTable dtcpy = null;
			DataRow dr = null;
			string sql = null;
			DataTable dt = null;

			sql = "select UNIT_ID,UNIT_ID+' '+UNIT_NAME_CN as UNIT_NAME_CN from p_unit order by unit_id ";
			dt = TJSystem.Public.PublicStatic.db.GetDataTable(sql);
			dr = dt.NewRow() ;
			dr[0] = "" ;
			dr[1] = "" ;
			dt.Rows.InsertAt(dr,0) ;
			dtcpy = dt.Copy();
			this.priComboBox1.DataSource = dtcpy.DefaultView;
			this.priComboBox1.ValueMember = "UNIT_ID";
			this.priComboBox1.DisplayMember = "UNIT_NAME_CN";

			sql = "select PACK_CODE,PACK_CODE+' '+PACK_NAMECN as PACK_NAMECN from p_packtype order by pack_code ";
			dt = TJSystem.Public.PublicStatic.db.GetDataTable(sql);
			dr = dt.NewRow() ;
			dr[0] = "" ;
			dr[1] = "" ;
			dt.Rows.InsertAt(dr,0) ;
			dtcpy = dt.Copy();
			this.priComboBox3.DataSource = dtcpy.DefaultView;
			this.priComboBox3.ValueMember = "PACK_CODE";
			this.priComboBox3.DisplayMember = "PACK_NAMECN";
	
			dt = new DataTable();
//			System.Data.DataColumn dc = new DataColumn("SEQ");
			dt.Columns.Add("SEQ");
			dt.Columns.Add("DESC");
			dr = dt.NewRow();
			dr["SEQ"] = "1";
			dr["DESC"] = "1 货品";
			dt.Rows.Add(dr);
			dr = dt.NewRow();
			dr["SEQ"] = "2";
			dr["DESC"] = "2 内包装";
			dt.Rows.Add(dr);
			dr = dt.NewRow();
			dr["SEQ"] = "3";
			dr["DESC"] = "3 外包装";
			dt.Rows.Add(dr);
			dtcpy = dt.Copy();
			this.priComboBox2.DataSource = dtcpy.DefaultView;
			this.priComboBox2.ValueMember = "SEQ";
			this.priComboBox2.DisplayMember = "DESC";
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
				this.priComboBox2.Enabled = true;
				this.priComboBox1.Enabled = true;
				this.priComboBox3.Enabled = true;
				this.priTextBox12.Enabled = true;
				this.priTextBox13.Enabled = true;
				this.priTextBox14.Enabled = true;
				this.priTextBox3.Enabled = true;
				this.priTextBox5.Enabled = true;
				this.priTextBox6.Enabled = true;
				this.priTextBox7.Enabled = true;
				this.priTextBox8.Enabled  = true;
				this.priTextBox9.Enabled = true;

				this.priComboBox2.Text = "";
				this.priComboBox1.Text = "";
				this.priComboBox3.Text = "";
				this.priTextBox12.Text = "";
				this.priTextBox13.Text = "";
				this.priTextBox14.Text = "";
				this.priTextBox3.Text = "";
				this.priTextBox5.Text = "";
				this.priTextBox6.Text = "";
				this.priTextBox7.Text = "";
				this.priTextBox8.Text  = "";
				this.priTextBox9.Text = "";
			}
			else if(sqltype.Equals("update"))
			{
				this.priComboBox2.Enabled = true;
				this.priComboBox1.Enabled = true;
				this.priComboBox3.Enabled = true;
				this.priTextBox12.Enabled = true;
				this.priTextBox13.Enabled = true;
				this.priTextBox14.Enabled = true;
				this.priTextBox3.Enabled = true;
				this.priTextBox5.Enabled = true;
				this.priTextBox6.Enabled = true;
				this.priTextBox7.Enabled = true;
				this.priTextBox8.Enabled  = true;
				this.priTextBox9.Enabled = true;
			}
		}

		private void InitialGrid(string sql)
		{		
			DataTable dt = TJSystem.Public.PublicStatic.db.GetDataTable(sql);
			dt.TableName = _table;
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(frmBasicItemPack));
			this.dataGridTextBoxColumn2 = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumn3 = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumn1 = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumn4 = new System.Windows.Forms.DataGridTextBoxColumn();
			this.panel2 = new System.Windows.Forms.Panel();
			this.dataGrid1 = new System.Windows.Forms.DataGrid();
			this.dataGridTableStyle1 = new System.Windows.Forms.DataGridTableStyle();
			this.item_code = new System.Windows.Forms.DataGridTextBoxColumn();
			this.seq_no = new System.Windows.Forms.DataGridTextBoxColumn();
			this.pack_code = new System.Windows.Forms.DataGridTextBoxColumn();
			this.panel4 = new System.Windows.Forms.Panel();
			this.txt1 = new TJSystem.Classes.PriTextBox();
			this.priComboBox2 = new TJSystem.Classes.PriComboBox();
			this.label3 = new System.Windows.Forms.Label();
			this.panel3 = new System.Windows.Forms.Panel();
			this.priToolBar1 = new TJSystem.UC.PriToolBar();
			this.label2 = new System.Windows.Forms.Label();
			this.priTextBox3 = new TJSystem.Classes.PriTextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.priTextBox4 = new TJSystem.Classes.PriTextBox();
			this.priTextBox5 = new TJSystem.Classes.PriTextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.priTextBox6 = new TJSystem.Classes.PriTextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.priTextBox7 = new TJSystem.Classes.PriTextBox();
			this.label9 = new System.Windows.Forms.Label();
			this.priTextBox8 = new TJSystem.Classes.PriTextBox();
			this.label10 = new System.Windows.Forms.Label();
			this.priTextBox9 = new TJSystem.Classes.PriTextBox();
			this.label11 = new System.Windows.Forms.Label();
			this.priTextBox12 = new TJSystem.Classes.PriTextBox();
			this.label14 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.priComboBox1 = new TJSystem.Classes.PriComboBox();
			this.label15 = new System.Windows.Forms.Label();
			this.priComboBox3 = new TJSystem.Classes.PriComboBox();
			this.label16 = new System.Windows.Forms.Label();
			this.priTextBox13 = new TJSystem.Classes.PriTextBox();
			this.label17 = new System.Windows.Forms.Label();
			this.priTextBox14 = new TJSystem.Classes.PriTextBox();
			this.description = new System.Windows.Forms.DataGridTextBoxColumn();
			this.qtyprepack = new System.Windows.Forms.DataGridTextBoxColumn();
			this.unit_name_cn = new System.Windows.Forms.DataGridTextBoxColumn();
			this.pack_namecn = new System.Windows.Forms.DataGridTextBoxColumn();
			this.length = new System.Windows.Forms.DataGridTextBoxColumn();
			this.width = new System.Windows.Forms.DataGridTextBoxColumn();
			this.height = new System.Windows.Forms.DataGridTextBoxColumn();
			this.volumn = new System.Windows.Forms.DataGridTextBoxColumn();
			this.grossweight = new System.Windows.Forms.DataGridTextBoxColumn();
			this.netweight = new System.Windows.Forms.DataGridTextBoxColumn();
			this.remark = new System.Windows.Forms.DataGridTextBoxColumn();
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
			this.panel2.Size = new System.Drawing.Size(746, 400);
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
			this.dataGrid1.Size = new System.Drawing.Size(738, 208);
			this.dataGrid1.TabIndex = 1;
			this.dataGrid1.TableStyles.AddRange(new System.Windows.Forms.DataGridTableStyle[] {
																								  this.dataGridTableStyle1});
			// 
			// dataGridTableStyle1
			// 
			this.dataGridTableStyle1.AllowSorting = false;
			this.dataGridTableStyle1.DataGrid = this.dataGrid1;
			this.dataGridTableStyle1.GridColumnStyles.AddRange(new System.Windows.Forms.DataGridColumnStyle[] {
																												  this.item_code,
																												  this.seq_no,
																												  this.pack_code,
																												  this.description,
																												  this.qtyprepack,
																												  this.unit_name_cn,
																												  this.pack_namecn,
																												  this.length,
																												  this.width,
																												  this.height,
																												  this.volumn,
																												  this.grossweight,
																												  this.netweight,
																												  this.remark});
			this.dataGridTableStyle1.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.dataGridTableStyle1.MappingName = "basic_item_packing";
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
			// seq_no
			// 
			this.seq_no.Format = "";
			this.seq_no.FormatInfo = null;
			this.seq_no.HeaderText = "类型编号";
			this.seq_no.MappingName = "seq_no";
			this.seq_no.NullText = "";
			this.seq_no.Width = 75;
			// 
			// pack_code
			// 
			this.pack_code.Format = "";
			this.pack_code.FormatInfo = null;
			this.pack_code.HeaderText = "类型";
			this.pack_code.MappingName = "pack_code";
			this.pack_code.NullText = "";
			this.pack_code.Width = 75;
			// 
			// panel4
			// 
			this.panel4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel4.BackgroundImage")));
			this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.panel4.Controls.Add(this.priTextBox14);
			this.panel4.Controls.Add(this.label17);
			this.panel4.Controls.Add(this.priTextBox13);
			this.panel4.Controls.Add(this.label16);
			this.panel4.Controls.Add(this.label15);
			this.panel4.Controls.Add(this.priComboBox3);
			this.panel4.Controls.Add(this.label6);
			this.panel4.Controls.Add(this.priComboBox1);
			this.panel4.Controls.Add(this.priTextBox9);
			this.panel4.Controls.Add(this.label11);
			this.panel4.Controls.Add(this.priTextBox12);
			this.panel4.Controls.Add(this.label14);
			this.panel4.Controls.Add(this.priTextBox8);
			this.panel4.Controls.Add(this.label10);
			this.panel4.Controls.Add(this.priTextBox7);
			this.panel4.Controls.Add(this.label9);
			this.panel4.Controls.Add(this.priTextBox6);
			this.panel4.Controls.Add(this.label8);
			this.panel4.Controls.Add(this.priTextBox5);
			this.panel4.Controls.Add(this.label7);
			this.panel4.Controls.Add(this.priTextBox4);
			this.panel4.Controls.Add(this.priTextBox3);
			this.panel4.Controls.Add(this.label4);
			this.panel4.Controls.Add(this.label2);
			this.panel4.Controls.Add(this.txt1);
			this.panel4.Controls.Add(this.priComboBox2);
			this.panel4.Controls.Add(this.label3);
			this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel4.Location = new System.Drawing.Point(0, 0);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(742, 168);
			this.panel4.TabIndex = 0;
			// 
			// txt1
			// 
			this.txt1.DataField = "item_code";
			this.txt1.DataType = TJSystem.Public.DataType.String;
			this.txt1.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.txt1.Location = new System.Drawing.Point(88, 8);
			this.txt1.Name = "txt1";
			this.txt1.Size = new System.Drawing.Size(168, 23);
			this.txt1.TabIndex = 148;
			this.txt1.Text = "";
			// 
			// priComboBox2
			// 
			this.priComboBox2.BackColor = System.Drawing.Color.White;
			this.priComboBox2.DataField = "seq_no";
			this.priComboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.priComboBox2.Location = new System.Drawing.Point(336, 8);
			this.priComboBox2.Name = "priComboBox2";
			this.priComboBox2.Size = new System.Drawing.Size(112, 22);
			this.priComboBox2.TabIndex = 147;
			this.priComboBox2.SelectedIndexChanged += new System.EventHandler(this.priComboBox2_SelectedIndexChanged);
			// 
			// label3
			// 
			this.label3.BackColor = System.Drawing.Color.Transparent;
			this.label3.Location = new System.Drawing.Point(8, 8);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(80, 23);
			this.label3.TabIndex = 150;
			this.label3.Text = "货品编号";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// panel3
			// 
			this.panel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel3.BackgroundImage")));
			this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.panel3.Controls.Add(this.priToolBar1);
			this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panel3.Location = new System.Drawing.Point(0, 400);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(746, 40);
			this.panel3.TabIndex = 9;
			// 
			// priToolBar1
			// 
			this.priToolBar1.DGEnable = true;
			this.priToolBar1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.priToolBar1.Location = new System.Drawing.Point(0, -4);
			this.priToolBar1.Name = "priToolBar1";
			this.priToolBar1.setCurrentForm = null;
			this.priToolBar1.Size = new System.Drawing.Size(742, 40);
			this.priToolBar1.TabIndex = 0;
			// 
			// label2
			// 
			this.label2.BackColor = System.Drawing.Color.Transparent;
			this.label2.Location = new System.Drawing.Point(272, 8);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(64, 23);
			this.label2.TabIndex = 152;
			this.label2.Text = "类型";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// priTextBox3
			// 
			this.priTextBox3.BackColor = System.Drawing.Color.Yellow;
			this.priTextBox3.DataField = "volumn";
			this.priTextBox3.DataType = TJSystem.Public.DataType.String;
			this.priTextBox3.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.priTextBox3.Location = new System.Drawing.Point(584, 56);
			this.priTextBox3.Name = "priTextBox3";
			this.priTextBox3.Size = new System.Drawing.Size(152, 23);
			this.priTextBox3.TabIndex = 153;
			this.priTextBox3.Text = "";
			// 
			// label4
			// 
			this.label4.BackColor = System.Drawing.Color.Transparent;
			this.label4.Location = new System.Drawing.Point(520, 56);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(64, 23);
			this.label4.TabIndex = 154;
			this.label4.Text = "体积(M3)";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// priTextBox4
			// 
			this.priTextBox4.DataField = "pack_code";
			this.priTextBox4.DataType = TJSystem.Public.DataType.String;
			this.priTextBox4.Enabled = false;
			this.priTextBox4.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.priTextBox4.Location = new System.Drawing.Point(448, 8);
			this.priTextBox4.Name = "priTextBox4";
			this.priTextBox4.Size = new System.Drawing.Size(168, 23);
			this.priTextBox4.TabIndex = 155;
			this.priTextBox4.Text = "";
			// 
			// priTextBox5
			// 
			this.priTextBox5.DataField = "description";
			this.priTextBox5.DataType = TJSystem.Public.DataType.String;
			this.priTextBox5.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.priTextBox5.Location = new System.Drawing.Point(88, 32);
			this.priTextBox5.Name = "priTextBox5";
			this.priTextBox5.Size = new System.Drawing.Size(168, 23);
			this.priTextBox5.TabIndex = 157;
			this.priTextBox5.Text = "";
			// 
			// label7
			// 
			this.label7.BackColor = System.Drawing.Color.Transparent;
			this.label7.Location = new System.Drawing.Point(8, 32);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(80, 23);
			this.label7.TabIndex = 158;
			this.label7.Text = "描述";
			this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// priTextBox6
			// 
			this.priTextBox6.BackColor = System.Drawing.Color.Yellow;
			this.priTextBox6.DataField = "qtyprepack";
			this.priTextBox6.DataType = TJSystem.Public.DataType.String;
			this.priTextBox6.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.priTextBox6.Location = new System.Drawing.Point(336, 32);
			this.priTextBox6.Name = "priTextBox6";
			this.priTextBox6.Size = new System.Drawing.Size(176, 23);
			this.priTextBox6.TabIndex = 159;
			this.priTextBox6.Text = "";
			// 
			// label8
			// 
			this.label8.BackColor = System.Drawing.Color.Transparent;
			this.label8.Location = new System.Drawing.Point(264, 32);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(72, 23);
			this.label8.TabIndex = 160;
			this.label8.Text = "包装数量";
			this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// priTextBox7
			// 
			this.priTextBox7.BackColor = System.Drawing.Color.Yellow;
			this.priTextBox7.DataField = "length";
			this.priTextBox7.DataType = TJSystem.Public.DataType.String;
			this.priTextBox7.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.priTextBox7.Location = new System.Drawing.Point(336, 56);
			this.priTextBox7.Name = "priTextBox7";
			this.priTextBox7.Size = new System.Drawing.Size(48, 23);
			this.priTextBox7.TabIndex = 161;
			this.priTextBox7.Text = "";
			this.priTextBox7.TextChanged += new System.EventHandler(this.priTextBox7_TextChanged);
			// 
			// label9
			// 
			this.label9.BackColor = System.Drawing.Color.Transparent;
			this.label9.Location = new System.Drawing.Point(264, 56);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(72, 23);
			this.label9.TabIndex = 162;
			this.label9.Text = "尺寸(cm)";
			this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// priTextBox8
			// 
			this.priTextBox8.BackColor = System.Drawing.Color.Yellow;
			this.priTextBox8.DataField = "grossweight";
			this.priTextBox8.DataType = TJSystem.Public.DataType.String;
			this.priTextBox8.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.priTextBox8.Location = new System.Drawing.Point(88, 80);
			this.priTextBox8.Name = "priTextBox8";
			this.priTextBox8.Size = new System.Drawing.Size(168, 23);
			this.priTextBox8.TabIndex = 163;
			this.priTextBox8.Text = "";
			// 
			// label10
			// 
			this.label10.BackColor = System.Drawing.Color.Transparent;
			this.label10.Location = new System.Drawing.Point(8, 80);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(80, 23);
			this.label10.TabIndex = 164;
			this.label10.Text = "毛重";
			this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// priTextBox9
			// 
			this.priTextBox9.DataField = "remark";
			this.priTextBox9.DataType = TJSystem.Public.DataType.String;
			this.priTextBox9.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.priTextBox9.Location = new System.Drawing.Point(88, 104);
			this.priTextBox9.Multiline = true;
			this.priTextBox9.Name = "priTextBox9";
			this.priTextBox9.Size = new System.Drawing.Size(648, 56);
			this.priTextBox9.TabIndex = 171;
			this.priTextBox9.Text = "";
			// 
			// label11
			// 
			this.label11.BackColor = System.Drawing.Color.Transparent;
			this.label11.Location = new System.Drawing.Point(8, 104);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(80, 23);
			this.label11.TabIndex = 172;
			this.label11.Text = "备注";
			this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// priTextBox12
			// 
			this.priTextBox12.BackColor = System.Drawing.Color.Yellow;
			this.priTextBox12.DataField = "netweight";
			this.priTextBox12.DataType = TJSystem.Public.DataType.String;
			this.priTextBox12.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.priTextBox12.Location = new System.Drawing.Point(336, 80);
			this.priTextBox12.Name = "priTextBox12";
			this.priTextBox12.Size = new System.Drawing.Size(168, 23);
			this.priTextBox12.TabIndex = 165;
			this.priTextBox12.Text = "";
			// 
			// label14
			// 
			this.label14.BackColor = System.Drawing.Color.Transparent;
			this.label14.Location = new System.Drawing.Point(256, 80);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(80, 23);
			this.label14.TabIndex = 166;
			this.label14.Text = "净重";
			this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label6
			// 
			this.label6.BackColor = System.Drawing.Color.Transparent;
			this.label6.Location = new System.Drawing.Point(536, 32);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(48, 23);
			this.label6.TabIndex = 174;
			this.label6.Text = "单位";
			this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// priComboBox1
			// 
			this.priComboBox1.BackColor = System.Drawing.Color.White;
			this.priComboBox1.DataField = "unit";
			this.priComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.priComboBox1.Location = new System.Drawing.Point(584, 32);
			this.priComboBox1.Name = "priComboBox1";
			this.priComboBox1.Size = new System.Drawing.Size(152, 22);
			this.priComboBox1.TabIndex = 173;
			// 
			// label15
			// 
			this.label15.BackColor = System.Drawing.Color.Transparent;
			this.label15.Location = new System.Drawing.Point(24, 56);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(64, 23);
			this.label15.TabIndex = 176;
			this.label15.Text = "包装类型";
			this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// priComboBox3
			// 
			this.priComboBox3.BackColor = System.Drawing.Color.White;
			this.priComboBox3.DataField = "outsiepacktype";
			this.priComboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.priComboBox3.Location = new System.Drawing.Point(88, 56);
			this.priComboBox3.Name = "priComboBox3";
			this.priComboBox3.Size = new System.Drawing.Size(168, 22);
			this.priComboBox3.TabIndex = 175;
			// 
			// label16
			// 
			this.label16.BackColor = System.Drawing.Color.Transparent;
			this.label16.Location = new System.Drawing.Point(384, 56);
			this.label16.Name = "label16";
			this.label16.Size = new System.Drawing.Size(16, 23);
			this.label16.TabIndex = 177;
			this.label16.Text = "*";
			this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// priTextBox13
			// 
			this.priTextBox13.BackColor = System.Drawing.Color.Yellow;
			this.priTextBox13.DataField = "width";
			this.priTextBox13.DataType = TJSystem.Public.DataType.String;
			this.priTextBox13.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.priTextBox13.Location = new System.Drawing.Point(400, 56);
			this.priTextBox13.Name = "priTextBox13";
			this.priTextBox13.Size = new System.Drawing.Size(48, 23);
			this.priTextBox13.TabIndex = 178;
			this.priTextBox13.Text = "";
			// 
			// label17
			// 
			this.label17.BackColor = System.Drawing.Color.Transparent;
			this.label17.Location = new System.Drawing.Point(448, 56);
			this.label17.Name = "label17";
			this.label17.Size = new System.Drawing.Size(16, 23);
			this.label17.TabIndex = 179;
			this.label17.Text = "*";
			this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// priTextBox14
			// 
			this.priTextBox14.BackColor = System.Drawing.Color.Yellow;
			this.priTextBox14.DataField = "height";
			this.priTextBox14.DataType = TJSystem.Public.DataType.String;
			this.priTextBox14.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.priTextBox14.Location = new System.Drawing.Point(464, 56);
			this.priTextBox14.Name = "priTextBox14";
			this.priTextBox14.Size = new System.Drawing.Size(48, 23);
			this.priTextBox14.TabIndex = 180;
			this.priTextBox14.Text = "";
			// 
			// description
			// 
			this.description.Format = "";
			this.description.FormatInfo = null;
			this.description.HeaderText = "描述";
			this.description.MappingName = "description";
			this.description.NullText = "";
			this.description.Width = 75;
			// 
			// qtyprepack
			// 
			this.qtyprepack.Format = "";
			this.qtyprepack.FormatInfo = null;
			this.qtyprepack.HeaderText = "包装数量";
			this.qtyprepack.MappingName = "qtyprepack";
			this.qtyprepack.NullText = "";
			this.qtyprepack.Width = 75;
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
			// pack_namecn
			// 
			this.pack_namecn.Format = "";
			this.pack_namecn.FormatInfo = null;
			this.pack_namecn.HeaderText = "包装类型";
			this.pack_namecn.MappingName = "pack_namecn";
			this.pack_namecn.NullText = "";
			this.pack_namecn.Width = 75;
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
			this.volumn.NullText = "";
			this.volumn.Width = 75;
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
			// netweight
			// 
			this.netweight.Format = "";
			this.netweight.FormatInfo = null;
			this.netweight.HeaderText = "净重";
			this.netweight.MappingName = "netweight";
			this.netweight.NullText = "";
			this.netweight.Width = 75;
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
			// frmBasicItemPack
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(7, 16);
			this.BackColor = System.Drawing.SystemColors.ScrollBar;
			this.ClientSize = new System.Drawing.Size(746, 440);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel3);
			this.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "frmBasicItemPack";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "货品资料";
			this.panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).EndInit();
			this.panel4.ResumeLayout(false);
			this.panel3.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		private void setDisable()
		{
			this.priComboBox2.Enabled = false;
			this.priComboBox1.Enabled = false;
			this.priComboBox3.Enabled = false;
			this.priTextBox12.Enabled = false;
			this.priTextBox13.Enabled = false;
			this.priTextBox14.Enabled = false;
			this.priTextBox3.Enabled = false;
			this.priTextBox4.Enabled = false;
			this.priTextBox5.Enabled = false;
			this.priTextBox6.Enabled = false;
			this.priTextBox7.Enabled = false;
			this.priTextBox8.Enabled  = false;
			this.priTextBox9.Enabled = false;
			this.txt1.Enabled = false;
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
					TJSystem.Public.PublicStatic.ShowMessage(TJSystem.Public.MessageType.Error,"已经存在该笔记录，请确认");
					return false;
				}
				if(this.priComboBox2.SelectedValue == null)
				{
					TJSystem.Public.PublicStatic.ShowMessage(TJSystem.Public.MessageType.Error,"必须选择类型");
					return false;
				}
			}
			if (!TJSystem.Public.PublicStatic.IsNumDouble(this.priTextBox3.Text.Trim())
				|| !TJSystem.Public.PublicStatic.IsNumDouble(this.priTextBox6.Text.Trim())
				|| !TJSystem.Public.PublicStatic.IsNumDouble(this.priTextBox7.Text.Trim())
				|| !TJSystem.Public.PublicStatic.IsNumDouble(this.priTextBox8.Text.Trim())
				|| !TJSystem.Public.PublicStatic.IsNumDouble(this.priTextBox12.Text.Trim())
				|| !TJSystem.Public.PublicStatic.IsNumDouble(this.priTextBox13.Text.Trim())
				|| !TJSystem.Public.PublicStatic.IsNumDouble(this.priTextBox14.Text.Trim()))
			{
				TJSystem.Public.PublicStatic.ShowMessage(TJSystem.Public.MessageType.Error,"请检查画面中黄色框内都是数字！");
				return false;
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

		private void priComboBox2_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			if(this.priComboBox2.SelectedValue.ToString().Equals("1"))
			{
				this.priTextBox4.Text = "货品";
			}
			else if(this.priComboBox2.SelectedValue.ToString().Equals("2"))
			{
				this.priTextBox4.Text = "内包装";
			}
			else if(this.priComboBox2.SelectedValue.ToString().Equals("3"))
			{
				this.priTextBox4.Text = "外包装";
			}
			else
			{
				this.priTextBox4.Text = "";
			}
		}

		private void priTextBox7_TextChanged(object sender, System.EventArgs e)
		{
		
		}
	}
}

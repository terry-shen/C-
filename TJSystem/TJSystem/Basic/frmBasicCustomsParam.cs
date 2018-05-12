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
	public class frmBasicCustomsParam : System.Windows.Forms.Form
	{		
		/// <summary>
		/// 必需的设计器变量。
		/// </summary>
		private System.ComponentModel.Container components = null;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn21;
		private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn22;
		private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn23;
		private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn24;
		private System.Windows.Forms.TreeView treeView1;
		private System.Windows.Forms.Splitter splitter1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Panel panel4;
		private System.Windows.Forms.DataGrid dataGrid1;
		private System.Windows.Forms.Panel panel3;
		private TJSystem.UC.PriToolBar priToolBar2;
		private TJSystem.Classes.PriTextBox txt3;
		private TJSystem.Classes.PriTextBox txt2;
		private TJSystem.Classes.PriTextBox txt1;
		private System.Windows.Forms.DataGridTableStyle dgsty1;
		public static System.Windows.Forms.Form frmCurrent = null ;
		System.Windows.Forms.DataGridTextBoxColumn dgtbc1 = new DataGridTextBoxColumn();
		System.Windows.Forms.DataGridTextBoxColumn dgtbc2 = new DataGridTextBoxColumn();
		System.Windows.Forms.DataGridTextBoxColumn dgtbc3 = new DataGridTextBoxColumn();
		System.Windows.Forms.DataGridTextBoxColumn dgtbc4 = new DataGridTextBoxColumn();
		System.Windows.Forms.DataGridTextBoxColumn dgtbc5 = new DataGridTextBoxColumn();
		System.Windows.Forms.DataGridTextBoxColumn dgtbc6 = new DataGridTextBoxColumn();
		private TJSystem.Classes.PriComboBox combo4;
		private TJSystem.Classes.PriTextBox txt5;
		private TJSystem.Classes.PriTextBox txt6;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label11;
		private TJSystem.Classes.PriTextBox priTextBox1;
		private TJSystem.Classes.PriTextBox priTextBox2;
		private TJSystem.Classes.PriTextBox priTextBox3;
		private TJSystem.Classes.PriTextBox priTextBox4;
		private TJSystem.Classes.PriTextBox priTextBox5;
		private System.Windows.Forms.DataGridTextBoxColumn hs_code;
		private System.Windows.Forms.DataGridTextBoxColumn item_name;
		private System.Windows.Forms.DataGridTextBoxColumn backtaxrate;
		private System.Windows.Forms.DataGridTextBoxColumn comtaxrate;
		private System.Windows.Forms.DataGridTextBoxColumn exptaxrate;
		private System.Windows.Forms.DataGridTextBoxColumn consumetaxrate;
		private System.Windows.Forms.DataGridTextBoxColumn addtaxrate;
		private System.Windows.Forms.DataGridTextBoxColumn remark;
		private System.Windows.Forms.DataGridTextBoxColumn watchcert;
		private System.Windows.Forms.DataGridTextBoxColumn unit_name_cn;
		private string _PK = null;
		private string _table = null;

		public frmBasicCustomsParam()
		{
			//
			// Windows 窗体设计器支持所必需的
			//
			InitializeComponent();

			

			InitialPrivateComponent();


			setVisibleFalse();

			this.priToolBar2.setCurrentForm = this;
//			_PK = " ";
//			priToolBar2.Initial("basic_company",_PK,"");
//			priToolBar2.BeforeButtonClickEvent += new TJSystem.UC.PriToolBar.BeforeButotnClick(this.BeforeButtonClick);
//			priToolBar2.AfterButtonClickEvent += new TJSystem.UC.PriToolBar.AfterButtonClick(this.AfterButtonClick);
			setDisable();
			this.priToolBar2.setButtonVisibleFalse();;
			this.priToolBar2.setButtonVisible("012345689");

			//
			// TODO: 在 InitializeComponent 调用后添加任何构造函数代码
			//
		}

		private bool BeforeButtonClick(string sqltype)
		{
			if(sqltype.Equals("default"))
			{
				this.setDisable();
			}
			if(sqltype.Equals("insert") || sqltype.Equals("update"))
			{
				if(!setParentHSCode(sqltype))
				{
					return false;
				}
				if(!checkFormValue(sqltype))
				{
					return false;
				}
			}

			return true;
		}

		private void setDisable()
		{
			this.txt1.Enabled = false;
			this.txt2.Enabled = false;
			this.txt3.Enabled = false;
			this.txt5.Enabled = false;
			this.txt6.Enabled = false;
			this.priTextBox1.Enabled = false;
			this.priTextBox2.Enabled = false;
			this.priTextBox3.Enabled = false;
			this.priTextBox4.Enabled = false;
			this.priTextBox5.Enabled = false;
			this.combo4.Enabled = false;
		}

		private bool setParentHSCode(string sqltype)
		{
			string str = this.txt1.Text.Trim() ;
			if(sqltype.Equals("update"))
			{
				return true;
			}

			System.Text.StringBuilder sb = new System.Text.StringBuilder();
			
			if(str.Length != 2 && str.Length != 8 && str.Length != 9 && str.Length != 10 && str.Length != 11)
			{
				sb.Append("数据验证错误：\r\n");
				sb.Append("  海关编码长度只能是4、8、9、10、11，请确认你的海关编码长度\r\n");
				TJSystem.Public.PublicStatic.ShowMessage(TJSystem.Public.MessageType.Error,sb.ToString());
				return false;
			}
			if(str.Length < 4)
			{
				this.priTextBox5.Text = "";
			}
			else if(str.Length == 4)
			{
				this.priTextBox5.Text = str.Substring(0,2);
				sb.Append("select 1 from ");
				sb.Append(_table);
				sb.Append(" where ");
				sb.Append(_PK);
				sb.Append("=");
				sb.Append("'");
				sb.Append(this.priTextBox5.Text);
				sb.Append("'");
				if(TJSystem.Public.PublicStatic.db.GetDataTable(sb.ToString()).Rows.Count == 0)
				{
					sb.Remove(0,sb.Length);
					sb.Append("数据验证错误：\r\n");
					sb.Append("  数据库中不存在该海关编码的上级编码，请确认海关编码没有问题\r\n");
					TJSystem.Public.PublicStatic.ShowMessage(TJSystem.Public.MessageType.Error,sb.ToString());
					return false;
				}
			}
			else if(str.Length == 8)
			{
				this.priTextBox5.Text = str.Substring(0,4);
				sb.Append("select 1 from ");
				sb.Append(_table);
				sb.Append(" where ");
				sb.Append(_PK);
				sb.Append("=");
				sb.Append("'");
				sb.Append(this.priTextBox5.Text);
				sb.Append("'");
				if(TJSystem.Public.PublicStatic.db.GetDataTable(sb.ToString()).Rows.Count == 0)
				{
					sb.Remove(0,sb.Length);
					sb.Append("数据验证错误：\r\n");
					sb.Append("  数据库中不存在该海关编码的上级编码，请确认海关编码没有问题\r\n");
					TJSystem.Public.PublicStatic.ShowMessage(TJSystem.Public.MessageType.Error,sb.ToString());
					return false;
				}
			}
			else if(str.Length > 8 && str.Length <= 10)
			{
				this.priTextBox5.Text = str.Substring(0,8);
				sb.Append("select 1 from ");
				sb.Append(_table);
				sb.Append(" where ");
				sb.Append(_PK);
				sb.Append("=");
				sb.Append("'");
				sb.Append(this.priTextBox5.Text);
				sb.Append("'");
				if(TJSystem.Public.PublicStatic.db.GetDataTable(sb.ToString()).Rows.Count == 0)
				{
					sb.Remove(0,sb.Length);
					sb.Append("数据验证错误：\r\n");
					sb.Append("  数据库中不存在该海关编码的上级编码，请确认海关编码没有问题\r\n");
					TJSystem.Public.PublicStatic.ShowMessage(TJSystem.Public.MessageType.Error,sb.ToString());
					return false;
				}
			}
			return true;
		}

		private bool checkFormValue(string sqlType)
		{
			bool checkResult = false;
			System.Text.StringBuilder sb = new System.Text.StringBuilder();
			sb.Append("数据验证错误：\r\n");
			if(sqlType.Equals("insert"))
			{
				if(TJSystem.Public.PublicStatic.IsExsist(_table,_PK,this.priToolBar2))
				{
					sb.Append("  数据库中已存在该海关编号，请确认\r\n");
					TJSystem.Public.PublicStatic.ShowMessage(TJSystem.Public.MessageType.Error,sb.ToString());
					return false ;
				}
			}
			if(this.txt2.Text.Trim().Equals("") || this.txt3.Text.Trim().Equals("")
				|| this.txt6.Text.Trim().Equals("") || this.priTextBox1.Text.Trim().Equals("")
				|| this.priTextBox2.Text.Trim().Equals(""))
			{
				sb.Append("  请检查各种税率有没有填写完整，没有税率的直接填写 0 \r\n");
				TJSystem.Public.PublicStatic.ShowMessage(TJSystem.Public.MessageType.Error,sb.ToString());
				checkResult = false;
				return checkResult;
			}
			if(!TJSystem.Public.PublicStatic.IsNumDouble(this.txt2.Text.Trim())
				|| !TJSystem.Public.PublicStatic.IsNumDouble(this.txt2.Text.Trim())
				|| !TJSystem.Public.PublicStatic.IsNumDouble(this.txt2.Text.Trim())
				|| !TJSystem.Public.PublicStatic.IsNumDouble(this.txt2.Text.Trim())
				|| !TJSystem.Public.PublicStatic.IsNumDouble(this.txt2.Text.Trim())
				|| !TJSystem.Public.PublicStatic.IsNumDouble(this.txt2.Text.Trim()))
			{
				sb.Append("  税率栏位出现了非数字字符，请检查核实\r\n");
				TJSystem.Public.PublicStatic.ShowMessage(TJSystem.Public.MessageType.Error,sb.ToString());
				checkResult = false;
				return checkResult;
			}
			if(this.combo4.SelectedValue == null)
			{
				sb.Append("  请选择单位，如果无法确定单位或无法确定单位，请选择 000 这个空单位\r\n");
				TJSystem.Public.PublicStatic.ShowMessage(TJSystem.Public.MessageType.Error,sb.ToString());
				checkResult = false;
				return checkResult;
			}

			checkResult = true;
			return checkResult;
		}

		private void AfterButtonClick(string ButtonType)
		{
			if(ButtonType.Equals("insert"))
			{
				this.txt1.Enabled = true;
				this.txt2.Enabled = true;
				this.txt3.Enabled = true;
				this.txt5.Enabled = true;
				this.txt6.Enabled = true;
				this.priTextBox1.Enabled = true;
				this.priTextBox2.Enabled = true;
				this.priTextBox3.Enabled = true;
				this.priTextBox4.Enabled = true;
				this.combo4.Enabled = true;

				this.txt1.Text = "";
				this.txt2.Text = "";
				this.txt3.Text = "";
				this.txt5.Text = "";
				this.txt6.Text = "";
				this.priTextBox1.Text = "";
				this.priTextBox2.Text = "";
				this.priTextBox3.Text = "";
				this.priTextBox4.Text = "";
				this.combo4.Text = "";
			}
			else if(ButtonType.Equals("update"))
			{				
				this.txt2.Enabled = true;
				this.txt3.Enabled = true;
				this.txt5.Enabled = true;
				this.txt6.Enabled = true;
				this.priTextBox1.Enabled = true;
				this.priTextBox2.Enabled = true;
				this.priTextBox3.Enabled = true;
				this.priTextBox4.Enabled = true;
				this.combo4.Enabled = true;
			}
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(frmBasicCustomsParam));
			this.panel1 = new System.Windows.Forms.Panel();
			this.label1 = new System.Windows.Forms.Label();
			this.dataGridTextBoxColumn21 = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumn22 = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumn23 = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumn24 = new System.Windows.Forms.DataGridTextBoxColumn();
			this.treeView1 = new System.Windows.Forms.TreeView();
			this.splitter1 = new System.Windows.Forms.Splitter();
			this.panel2 = new System.Windows.Forms.Panel();
			this.panel3 = new System.Windows.Forms.Panel();
			this.priToolBar2 = new TJSystem.UC.PriToolBar();
			this.dataGrid1 = new System.Windows.Forms.DataGrid();
			this.dgsty1 = new System.Windows.Forms.DataGridTableStyle();
			this.hs_code = new System.Windows.Forms.DataGridTextBoxColumn();
			this.item_name = new System.Windows.Forms.DataGridTextBoxColumn();
			this.unit_name_cn = new System.Windows.Forms.DataGridTextBoxColumn();
			this.backtaxrate = new System.Windows.Forms.DataGridTextBoxColumn();
			this.comtaxrate = new System.Windows.Forms.DataGridTextBoxColumn();
			this.exptaxrate = new System.Windows.Forms.DataGridTextBoxColumn();
			this.consumetaxrate = new System.Windows.Forms.DataGridTextBoxColumn();
			this.addtaxrate = new System.Windows.Forms.DataGridTextBoxColumn();
			this.remark = new System.Windows.Forms.DataGridTextBoxColumn();
			this.watchcert = new System.Windows.Forms.DataGridTextBoxColumn();
			this.panel4 = new System.Windows.Forms.Panel();
			this.priTextBox5 = new TJSystem.Classes.PriTextBox();
			this.priTextBox4 = new TJSystem.Classes.PriTextBox();
			this.priTextBox3 = new TJSystem.Classes.PriTextBox();
			this.priTextBox2 = new TJSystem.Classes.PriTextBox();
			this.priTextBox1 = new TJSystem.Classes.PriTextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.txt6 = new TJSystem.Classes.PriTextBox();
			this.txt5 = new TJSystem.Classes.PriTextBox();
			this.combo4 = new TJSystem.Classes.PriComboBox();
			this.txt3 = new TJSystem.Classes.PriTextBox();
			this.txt2 = new TJSystem.Classes.PriTextBox();
			this.txt1 = new TJSystem.Classes.PriTextBox();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			this.panel3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).BeginInit();
			this.panel4.SuspendLayout();
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
			this.panel1.Size = new System.Drawing.Size(792, 66);
			this.panel1.TabIndex = 10;
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label1.Font = new System.Drawing.Font("宋体", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.label1.Location = new System.Drawing.Point(0, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(788, 62);
			this.label1.TabIndex = 0;
			this.label1.Text = "海关编码维护";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// dataGridTextBoxColumn21
			// 
			this.dataGridTextBoxColumn21.Format = "";
			this.dataGridTextBoxColumn21.FormatInfo = null;
			this.dataGridTextBoxColumn21.HeaderText = "员工编号";
			this.dataGridTextBoxColumn21.MappingName = "employee_id";
			this.dataGridTextBoxColumn21.NullText = "";
			this.dataGridTextBoxColumn21.Width = 75;
			// 
			// dataGridTextBoxColumn22
			// 
			this.dataGridTextBoxColumn22.Format = "";
			this.dataGridTextBoxColumn22.FormatInfo = null;
			this.dataGridTextBoxColumn22.HeaderText = "性别";
			this.dataGridTextBoxColumn22.MappingName = "Gender";
			this.dataGridTextBoxColumn22.NullText = "";
			this.dataGridTextBoxColumn22.Width = 75;
			// 
			// dataGridTextBoxColumn23
			// 
			this.dataGridTextBoxColumn23.Format = "";
			this.dataGridTextBoxColumn23.FormatInfo = null;
			this.dataGridTextBoxColumn23.HeaderText = "员工姓名";
			this.dataGridTextBoxColumn23.MappingName = "";
			this.dataGridTextBoxColumn23.NullText = "";
			this.dataGridTextBoxColumn23.Width = 75;
			// 
			// dataGridTextBoxColumn24
			// 
			this.dataGridTextBoxColumn24.Format = "";
			this.dataGridTextBoxColumn24.FormatInfo = null;
			this.dataGridTextBoxColumn24.HeaderText = "英文名";
			this.dataGridTextBoxColumn24.MappingName = "";
			this.dataGridTextBoxColumn24.NullText = "";
			this.dataGridTextBoxColumn24.Width = 75;
			// 
			// treeView1
			// 
			this.treeView1.Dock = System.Windows.Forms.DockStyle.Left;
			this.treeView1.ImageIndex = -1;
			this.treeView1.Location = new System.Drawing.Point(0, 66);
			this.treeView1.Name = "treeView1";
			this.treeView1.SelectedImageIndex = -1;
			this.treeView1.Size = new System.Drawing.Size(192, 500);
			this.treeView1.TabIndex = 11;
			this.treeView1.DoubleClick += new System.EventHandler(this.treeView1_DoubleClick);
			// 
			// splitter1
			// 
			this.splitter1.Location = new System.Drawing.Point(192, 66);
			this.splitter1.Name = "splitter1";
			this.splitter1.Size = new System.Drawing.Size(3, 500);
			this.splitter1.TabIndex = 13;
			this.splitter1.TabStop = false;
			// 
			// panel2
			// 
			this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
			this.panel2.Controls.Add(this.panel3);
			this.panel2.Controls.Add(this.dataGrid1);
			this.panel2.Controls.Add(this.panel4);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel2.Location = new System.Drawing.Point(195, 66);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(597, 500);
			this.panel2.TabIndex = 14;
			// 
			// panel3
			// 
			this.panel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel3.BackgroundImage")));
			this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.panel3.Controls.Add(this.priToolBar2);
			this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panel3.Location = new System.Drawing.Point(0, 460);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(597, 40);
			this.panel3.TabIndex = 10;
			// 
			// priToolBar2
			// 
			this.priToolBar2.DGEnable = true;
			this.priToolBar2.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.priToolBar2.Location = new System.Drawing.Point(0, -4);
			this.priToolBar2.Name = "priToolBar2";
			this.priToolBar2.setCurrentForm = null;
			this.priToolBar2.Size = new System.Drawing.Size(593, 40);
			this.priToolBar2.TabIndex = 1;
			// 
			// dataGrid1
			// 
			this.dataGrid1.AllowSorting = false;
			this.dataGrid1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.dataGrid1.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.dataGrid1.CaptionVisible = false;
			this.dataGrid1.DataMember = "";
			this.dataGrid1.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.dataGrid1.Location = new System.Drawing.Point(0, 176);
			this.dataGrid1.Name = "dataGrid1";
			this.dataGrid1.ReadOnly = true;
			this.dataGrid1.Size = new System.Drawing.Size(597, 280);
			this.dataGrid1.TabIndex = 2;
			this.dataGrid1.TableStyles.AddRange(new System.Windows.Forms.DataGridTableStyle[] {
																								  this.dgsty1});
			// 
			// dgsty1
			// 
			this.dgsty1.AllowSorting = false;
			this.dgsty1.DataGrid = this.dataGrid1;
			this.dgsty1.GridColumnStyles.AddRange(new System.Windows.Forms.DataGridColumnStyle[] {
																									 this.hs_code,
																									 this.item_name,
																									 this.unit_name_cn,
																									 this.backtaxrate,
																									 this.comtaxrate,
																									 this.exptaxrate,
																									 this.consumetaxrate,
																									 this.addtaxrate,
																									 this.remark,
																									 this.watchcert});
			this.dgsty1.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.dgsty1.MappingName = "p_hscode";
			// 
			// hs_code
			// 
			this.hs_code.Format = "";
			this.hs_code.FormatInfo = null;
			this.hs_code.HeaderText = "海关编码";
			this.hs_code.MappingName = "hs_code";
			this.hs_code.NullText = "";
			this.hs_code.Width = 75;
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
			// unit_name_cn
			// 
			this.unit_name_cn.Format = "";
			this.unit_name_cn.FormatInfo = null;
			this.unit_name_cn.HeaderText = "单位";
			this.unit_name_cn.MappingName = "unit_name_cn";
			this.unit_name_cn.NullText = "";
			this.unit_name_cn.Width = 75;
			// 
			// backtaxrate
			// 
			this.backtaxrate.Format = "";
			this.backtaxrate.FormatInfo = null;
			this.backtaxrate.HeaderText = "优惠税率";
			this.backtaxrate.MappingName = "backtaxrate";
			this.backtaxrate.NullText = "";
			this.backtaxrate.Width = 75;
			// 
			// comtaxrate
			// 
			this.comtaxrate.Format = "";
			this.comtaxrate.FormatInfo = null;
			this.comtaxrate.HeaderText = "普通税率";
			this.comtaxrate.MappingName = "comtaxrate";
			this.comtaxrate.NullText = "";
			this.comtaxrate.Width = 75;
			// 
			// exptaxrate
			// 
			this.exptaxrate.Format = "";
			this.exptaxrate.FormatInfo = null;
			this.exptaxrate.HeaderText = "出口税率";
			this.exptaxrate.MappingName = "exptaxrate";
			this.exptaxrate.NullText = "";
			this.exptaxrate.Width = 75;
			// 
			// consumetaxrate
			// 
			this.consumetaxrate.Format = "";
			this.consumetaxrate.FormatInfo = null;
			this.consumetaxrate.HeaderText = "消费税率";
			this.consumetaxrate.MappingName = "consumetaxrate";
			this.consumetaxrate.NullText = "";
			this.consumetaxrate.Width = 75;
			// 
			// addtaxrate
			// 
			this.addtaxrate.Format = "";
			this.addtaxrate.FormatInfo = null;
			this.addtaxrate.HeaderText = "增值税率";
			this.addtaxrate.MappingName = "addtaxrate";
			this.addtaxrate.NullText = "";
			this.addtaxrate.Width = 75;
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
			// watchcert
			// 
			this.watchcert.Format = "";
			this.watchcert.FormatInfo = null;
			this.watchcert.HeaderText = "监管代码";
			this.watchcert.MappingName = "watchcert";
			this.watchcert.NullText = "";
			this.watchcert.Width = 75;
			// 
			// panel4
			// 
			this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.panel4.BackColor = System.Drawing.Color.Transparent;
			this.panel4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel4.BackgroundImage")));
			this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.panel4.Controls.Add(this.priTextBox5);
			this.panel4.Controls.Add(this.priTextBox4);
			this.panel4.Controls.Add(this.priTextBox3);
			this.panel4.Controls.Add(this.priTextBox2);
			this.panel4.Controls.Add(this.priTextBox1);
			this.panel4.Controls.Add(this.label4);
			this.panel4.Controls.Add(this.label5);
			this.panel4.Controls.Add(this.label2);
			this.panel4.Controls.Add(this.label3);
			this.panel4.Controls.Add(this.label6);
			this.panel4.Controls.Add(this.label7);
			this.panel4.Controls.Add(this.label8);
			this.panel4.Controls.Add(this.label9);
			this.panel4.Controls.Add(this.label10);
			this.panel4.Controls.Add(this.label11);
			this.panel4.Controls.Add(this.txt6);
			this.panel4.Controls.Add(this.txt5);
			this.panel4.Controls.Add(this.combo4);
			this.panel4.Controls.Add(this.txt3);
			this.panel4.Controls.Add(this.txt2);
			this.panel4.Controls.Add(this.txt1);
			this.panel4.Location = new System.Drawing.Point(0, 0);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(597, 168);
			this.panel4.TabIndex = 1;
			// 
			// priTextBox5
			// 
			this.priTextBox5.BackColor = System.Drawing.Color.White;
			this.priTextBox5.DataField = "parent_hs_code";
			this.priTextBox5.DataType = TJSystem.Public.DataType.String;
			this.priTextBox5.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.priTextBox5.Location = new System.Drawing.Point(480, 104);
			this.priTextBox5.Name = "priTextBox5";
			this.priTextBox5.Size = new System.Drawing.Size(104, 23);
			this.priTextBox5.TabIndex = 139;
			this.priTextBox5.Text = "";
			this.priTextBox5.Visible = false;
			// 
			// priTextBox4
			// 
			this.priTextBox4.BackColor = System.Drawing.Color.White;
			this.priTextBox4.DataField = "remark";
			this.priTextBox4.DataType = TJSystem.Public.DataType.String;
			this.priTextBox4.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.priTextBox4.Location = new System.Drawing.Point(96, 136);
			this.priTextBox4.Name = "priTextBox4";
			this.priTextBox4.Size = new System.Drawing.Size(488, 23);
			this.priTextBox4.TabIndex = 138;
			this.priTextBox4.Text = "";
			// 
			// priTextBox3
			// 
			this.priTextBox3.BackColor = System.Drawing.Color.White;
			this.priTextBox3.DataField = "watchcert";
			this.priTextBox3.DataType = TJSystem.Public.DataType.String;
			this.priTextBox3.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.priTextBox3.Location = new System.Drawing.Point(96, 104);
			this.priTextBox3.Name = "priTextBox3";
			this.priTextBox3.Size = new System.Drawing.Size(368, 23);
			this.priTextBox3.TabIndex = 137;
			this.priTextBox3.Text = "";
			// 
			// priTextBox2
			// 
			this.priTextBox2.BackColor = System.Drawing.Color.White;
			this.priTextBox2.DataField = "consumetaxrate";
			this.priTextBox2.DataType = TJSystem.Public.DataType.String;
			this.priTextBox2.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.priTextBox2.Location = new System.Drawing.Point(464, 72);
			this.priTextBox2.Name = "priTextBox2";
			this.priTextBox2.Size = new System.Drawing.Size(120, 23);
			this.priTextBox2.TabIndex = 136;
			this.priTextBox2.Text = "";
			// 
			// priTextBox1
			// 
			this.priTextBox1.BackColor = System.Drawing.Color.White;
			this.priTextBox1.DataField = "addtaxrate";
			this.priTextBox1.DataType = TJSystem.Public.DataType.String;
			this.priTextBox1.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.priTextBox1.Location = new System.Drawing.Point(280, 72);
			this.priTextBox1.Name = "priTextBox1";
			this.priTextBox1.Size = new System.Drawing.Size(104, 23);
			this.priTextBox1.TabIndex = 135;
			this.priTextBox1.Text = "";
			// 
			// label4
			// 
			this.label4.BackColor = System.Drawing.Color.Transparent;
			this.label4.Location = new System.Drawing.Point(8, 136);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(80, 23);
			this.label4.TabIndex = 134;
			this.label4.Text = "备注";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label5
			// 
			this.label5.BackColor = System.Drawing.Color.Transparent;
			this.label5.Location = new System.Drawing.Point(8, 104);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(80, 23);
			this.label5.TabIndex = 133;
			this.label5.Text = "监管代码";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label2
			// 
			this.label2.BackColor = System.Drawing.Color.Transparent;
			this.label2.Location = new System.Drawing.Point(208, 72);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(64, 23);
			this.label2.TabIndex = 132;
			this.label2.Text = "增值税率";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label3
			// 
			this.label3.BackColor = System.Drawing.Color.Transparent;
			this.label3.Location = new System.Drawing.Point(392, 72);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(64, 23);
			this.label3.TabIndex = 131;
			this.label3.Text = "消费税率";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label6
			// 
			this.label6.BackColor = System.Drawing.Color.Transparent;
			this.label6.Location = new System.Drawing.Point(208, 40);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(64, 23);
			this.label6.TabIndex = 130;
			this.label6.Text = "优惠税率";
			this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label7
			// 
			this.label7.BackColor = System.Drawing.Color.Transparent;
			this.label7.Location = new System.Drawing.Point(208, 8);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(64, 23);
			this.label7.TabIndex = 129;
			this.label7.Text = "货品名称";
			this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label8
			// 
			this.label8.BackColor = System.Drawing.Color.Transparent;
			this.label8.ForeColor = System.Drawing.Color.Blue;
			this.label8.Location = new System.Drawing.Point(8, 40);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(80, 23);
			this.label8.TabIndex = 128;
			this.label8.Text = "单位";
			this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label9
			// 
			this.label9.BackColor = System.Drawing.Color.Transparent;
			this.label9.Location = new System.Drawing.Point(8, 72);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(80, 23);
			this.label9.TabIndex = 127;
			this.label9.Text = "出口税率";
			this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label10
			// 
			this.label10.BackColor = System.Drawing.Color.Transparent;
			this.label10.Location = new System.Drawing.Point(392, 40);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(64, 23);
			this.label10.TabIndex = 126;
			this.label10.Text = "普通税率";
			this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label11
			// 
			this.label11.BackColor = System.Drawing.Color.Transparent;
			this.label11.ForeColor = System.Drawing.Color.Blue;
			this.label11.Location = new System.Drawing.Point(8, 8);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(80, 23);
			this.label11.TabIndex = 125;
			this.label11.Text = "海关编码";
			this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.label11.DoubleClick += new System.EventHandler(this.label11_DoubleClick);
			// 
			// txt6
			// 
			this.txt6.BackColor = System.Drawing.Color.White;
			this.txt6.DataField = "backtaxrate";
			this.txt6.DataType = TJSystem.Public.DataType.String;
			this.txt6.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.txt6.Location = new System.Drawing.Point(280, 40);
			this.txt6.Name = "txt6";
			this.txt6.Size = new System.Drawing.Size(104, 23);
			this.txt6.TabIndex = 117;
			this.txt6.Text = "";
			// 
			// txt5
			// 
			this.txt5.BackColor = System.Drawing.Color.White;
			this.txt5.DataField = "item_name";
			this.txt5.DataType = TJSystem.Public.DataType.String;
			this.txt5.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.txt5.Location = new System.Drawing.Point(280, 8);
			this.txt5.Name = "txt5";
			this.txt5.Size = new System.Drawing.Size(304, 23);
			this.txt5.TabIndex = 114;
			this.txt5.Text = "";
			// 
			// combo4
			// 
			this.combo4.BackColor = System.Drawing.Color.White;
			this.combo4.DataField = "unit";
			this.combo4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.combo4.Location = new System.Drawing.Point(96, 40);
			this.combo4.Name = "combo4";
			this.combo4.Size = new System.Drawing.Size(104, 22);
			this.combo4.TabIndex = 112;
			// 
			// txt3
			// 
			this.txt3.BackColor = System.Drawing.Color.White;
			this.txt3.DataField = "comtaxrate";
			this.txt3.DataType = TJSystem.Public.DataType.String;
			this.txt3.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.txt3.Location = new System.Drawing.Point(464, 40);
			this.txt3.Name = "txt3";
			this.txt3.Size = new System.Drawing.Size(120, 23);
			this.txt3.TabIndex = 106;
			this.txt3.Text = "";
			// 
			// txt2
			// 
			this.txt2.BackColor = System.Drawing.Color.White;
			this.txt2.DataField = "exptaxrate";
			this.txt2.DataType = TJSystem.Public.DataType.String;
			this.txt2.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.txt2.Location = new System.Drawing.Point(96, 72);
			this.txt2.Name = "txt2";
			this.txt2.Size = new System.Drawing.Size(104, 23);
			this.txt2.TabIndex = 104;
			this.txt2.Text = "";
			// 
			// txt1
			// 
			this.txt1.BackColor = System.Drawing.Color.White;
			this.txt1.DataField = "hs_code";
			this.txt1.DataType = TJSystem.Public.DataType.String;
			this.txt1.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.txt1.Location = new System.Drawing.Point(96, 8);
			this.txt1.Name = "txt1";
			this.txt1.Size = new System.Drawing.Size(104, 23);
			this.txt1.TabIndex = 102;
			this.txt1.Text = "";
			// 
			// frmBasicCustomsParam
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(7, 16);
			this.BackColor = System.Drawing.SystemColors.ScrollBar;
			this.ClientSize = new System.Drawing.Size(792, 566);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.splitter1);
			this.Controls.Add(this.treeView1);
			this.Controls.Add(this.panel1);
			this.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "frmBasicCustomsParam";
			this.Text = "海关编码维护";
			this.panel1.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			this.panel3.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).EndInit();
			this.panel4.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion


		private void InitialPrivateComponent()
		{
			System.Text.StringBuilder sb = new System.Text.StringBuilder();
			sb.Append("SELECT parent_hs_code,parent_hs_code+' '+item_name as parent_hs_name, hs_code,hs_code+' '+item_name as hs_name ");
			sb.Append("FROM p_hscode ");
			sb.Append("ORDER BY hs_code");
			DataTable dt = TJSystem.Public.PublicStatic.db.GetDataTable(sb.ToString());
			DataTable dtcpy = null;
			DataRow dr = null;
			DataView dv = dt.DefaultView ;
			DataView dvParent = null;
			DataView dvSub = null;
			
			TJSystem.Classes.PriTreeNode tnParent = null;
			TJSystem.Classes.PriTreeNode tnSubP = null;
			TJSystem.Classes.PriTreeNode tnSub = null;
			TJSystem.Classes.PriTreeNode tn ;
			System.Windows.Forms.ImageList imgList = new ImageList();
			imgList.ImageSize = new Size(25,25);
			imgList.Images.Add(Image.FromFile("images\\list.ico"));
			imgList.Images.Add(Image.FromFile("images\\node.ico"));
			imgList.Images.Add(Image.FromFile("images\\select.ico"));

			tnParent = new TJSystem.Classes.PriTreeNode("海关商品");
			tnParent.ImageIndex = 1;
			

			dvParent = dv.Table.Copy().DefaultView;
			dvParent.RowFilter = "len(hs_code) < 4";
			
			this.treeView1.ImageList = imgList;
			this.treeView1.SelectedImageIndex = 2;

			for(int i = 0 ; i < dvParent.Count ; i ++)
			{
				tnSubP = new TJSystem.Classes.PriTreeNode(dvParent[i][3].ToString());
				tnSubP.ImageIndex = 1;
				tnSubP.DataField = dvParent[i][2].ToString().Trim();

				//				dvSub = dv.Table.Copy().DefaultView;
				//				dvSub.RowFilter = "parent_hs_code='" + dvParent[i][2].ToString().Trim() + "'";
				//				for(int j = 0; j < dvSub.Count; j++)
				//				{
				//					tnSub = new TJSystem.Classes.PriTreeNode(dvSub[j][3].ToString());
				//					tnSub.DataField = dvSub[j][2].ToString().Trim();
				//					tnSub.ImageIndex = 1;
				//
				//					tnSubP.Nodes.Add(tnSub);
				//				}

				tnParent.Nodes.Add(tnSubP);
			}
			this.treeView1.Nodes.Add(tnParent);
			tnParent.Expand();


			string sql = "select UNIT_ID,UNIT_ID+' '+UNIT_NAME_CN as UNIT_NAME_CN from p_unit order by UNIT_ID";
			dt = TJSystem.Public.PublicStatic.db.GetDataTable(sql);
			dr = dt.NewRow();
			dr[0] = "";
			dr[1] = "";
			dt.Rows.InsertAt(dr,0);
			dtcpy = dt.Copy();
			this.combo4.DataSource = dtcpy.DefaultView;
			this.combo4.ValueMember = "UNIT_ID";
			this.combo4.DisplayMember = "UNIT_NAME_CN";

		}

		private void treeView1_DoubleClick(object sender, System.EventArgs e)
		{
			System.Windows.Forms.DataGridTableStyle dgstyle = null;
						
			System.Text.StringBuilder sb = new System.Text.StringBuilder();
			
			setVisibleFalse();
			int counts= this.treeView1.Nodes.Count ;

			foreach(TJSystem.Classes.PriTreeNode tnSubP in this.treeView1.Nodes)
			{
				foreach(TJSystem.Classes.PriTreeNode tn in tnSubP.Nodes)
				{
					counts= tn.Nodes.Count ;
					if(tn.IsSelected && tn.GetNodeCount(true)==0)
					{
						this.dataGrid1.CaptionText = tn.Text.Trim();
						sb.Append("select a.parent_hs_code,a.hs_code,a.item_name,a.unit,b.unit_name_cn as unit_name_cn,a.backtaxrate,a.comtaxrate,a.exptaxrate,");
						sb.Append("a.consumetaxrate,a.addtaxrate,a.remark,a.watchcert ");
						sb.Append("from p_hscode a ");
						sb.Append("left join p_unit b on a.unit=b.unit_id ");
						sb.Append("where substring(a.hs_code ,1,2)='");
						sb.Append(tn.Text.Substring(0,3).Trim());
						sb.Append("' ");
						sb.Append("order by a.hs_code");
					}
				}
			}
			if(this.dgsty1 == null && sb.ToString().Length > 0)
			{
				return;
			}
			this.InitialGrid(sb.ToString(),dgsty1);
			priToolBar2.setCurrentForm = this;
			_PK = this.txt1.DataField;
			_table = dgsty1.MappingName;
			priToolBar2.Initial(_table,_PK,sb.ToString());
			priToolBar2.BeforeButtonClickEvent += new TJSystem.UC.PriToolBar.BeforeButotnClick(this.BeforeButtonClick);
			priToolBar2.AfterButtonClickEvent += new TJSystem.UC.PriToolBar.AfterButtonClick(this.AfterButtonClick);
		}
		
		private void InitialGrid(string sql,System.Windows.Forms.DataGridTableStyle dgstyle)
		{		
			DataTable dt = TJSystem.Public.PublicStatic.db.GetDataTable(sql);
			dt.TableName = "p_hscode";
			this.dataGrid1.DataSource = dt.DefaultView;
		}


		private void setVisibleFalse()
		{
			
		}

		private void InitialPriComboBox(TJSystem.Classes.PriComboBox combobox,string sql,string valuemember,string displaymember)
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
				TJSystem.Public.PublicStatic.formName = "海关编码维护";
			}
			base.OnClosing (e);
		}

		private void label11_DoubleClick(object sender, System.EventArgs e)
		{
			if(this.priTextBox5.Visible == false)
			{
				this.priTextBox5.Visible = true;
			}
			else
			{
				this.priTextBox5.Enabled = false;
			}
		}
	}
}

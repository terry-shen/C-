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
	public class frmBasicParams : System.Windows.Forms.Form
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
		private System.Windows.Forms.Label lbl4;
		private TJSystem.Classes.PriTextBox txt4;
		private System.Windows.Forms.Label lbl3;
		private TJSystem.Classes.PriTextBox txt3;
		private System.Windows.Forms.Label lbl2;
		private TJSystem.Classes.PriTextBox txt2;
		private System.Windows.Forms.Label lbl1;
		private TJSystem.Classes.PriTextBox txt1;
		private System.Windows.Forms.DataGridTableStyle dgsty1;
		public static System.Windows.Forms.Form frmCurrent = null ;
		System.Windows.Forms.DataGridTextBoxColumn dgtbc1 = new DataGridTextBoxColumn();
		System.Windows.Forms.DataGridTextBoxColumn dgtbc2 = new DataGridTextBoxColumn();
		System.Windows.Forms.DataGridTextBoxColumn dgtbc3 = new DataGridTextBoxColumn();
		System.Windows.Forms.DataGridTextBoxColumn dgtbc4 = new DataGridTextBoxColumn();
		System.Windows.Forms.DataGridTextBoxColumn dgtbc5 = new DataGridTextBoxColumn();
		System.Windows.Forms.DataGridTextBoxColumn dgtbc6 = new DataGridTextBoxColumn();
		private TJSystem.Classes.PriComboBox combo2;
		private TJSystem.Classes.PriComboBox combo1;
		private TJSystem.Classes.PriComboBox combo3;
		private TJSystem.Classes.PriComboBox combo4;
		private TJSystem.Classes.PriComboBox combo5;
		private System.Windows.Forms.Label lbl5;
		private TJSystem.Classes.PriTextBox txt5;
		private TJSystem.Classes.PriComboBox combo6;
		private TJSystem.Classes.PriTextBox txt6;
		private System.Windows.Forms.Label lbl6;
		private string _PK = "";

		public frmBasicParams()
		{
			//
			// Windows 窗体设计器支持所必需的
			//
			InitializeComponent();

			

			TJSystem.Public.PublicStatic.setBackgroundImg(this.panel1,this.panel1.GetType().ToString(),"images\\bg.gif");
			TJSystem.Public.PublicStatic.setBackgroundImg(this.panel2,this.panel1.GetType().ToString(),"");
			TJSystem.Public.PublicStatic.setBackgroundImg(this.panel3,this.panel1.GetType().ToString(),"");
			TJSystem.Public.PublicStatic.setBackgroundImg(this.panel4,this.panel1.GetType().ToString(),"");

			InitialPrivateComponent();
			setVisibleFalse();

			this.priToolBar2.setCurrentForm = this;
			_PK = " ";
			priToolBar2.Initial("basic_company",_PK,"");
			priToolBar2.BeforeButtonClickEvent += new TJSystem.UC.PriToolBar.BeforeButotnClick(this.BeforeButtonClick);
			priToolBar2.AfterButtonClickEvent += new TJSystem.UC.PriToolBar.AfterButtonClick(this.AfterButtonClick);
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
			this.combo1.Enabled = false;
			this.combo2.Enabled = false;
			this.combo3.Enabled = false;
			this.combo4.Enabled = false;
			this.combo5.Enabled = false;
			this.combo6.Enabled = false;
		}

		private void AfterButtonClick(string ButtonType)
		{
			if(ButtonType.Equals("insert"))
			{
				this.txt1.Enabled = true;
				this.txt2.Enabled = true;
				this.txt3.Enabled = true;
				this.txt4.Enabled = true;
				this.txt5.Enabled = true;
				this.txt6.Enabled = true;
				this.combo1.Enabled = true;
				this.combo2.Enabled = true;
				this.combo3.Enabled = true;
				this.combo4.Enabled = true;
				this.combo5.Enabled = true;
				this.combo6.Enabled = true;
			}
			else if(ButtonType.Equals("update"))
			{
				this.txt1.Enabled = false;
				this.txt2.Enabled = true;
				this.txt3.Enabled = true;
				this.txt4.Enabled = true;
				this.txt5.Enabled = true;
				this.txt6.Enabled = true;
				this.combo1.Enabled = false;
				this.combo2.Enabled = true;
				this.combo3.Enabled = true;
				this.combo4.Enabled = true;
				this.combo5.Enabled = true;
				this.combo6.Enabled = true;
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(frmBasicParams));
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
			this.panel4 = new System.Windows.Forms.Panel();
			this.combo6 = new TJSystem.Classes.PriComboBox();
			this.lbl6 = new System.Windows.Forms.Label();
			this.txt6 = new TJSystem.Classes.PriTextBox();
			this.combo5 = new TJSystem.Classes.PriComboBox();
			this.lbl5 = new System.Windows.Forms.Label();
			this.txt5 = new TJSystem.Classes.PriTextBox();
			this.combo4 = new TJSystem.Classes.PriComboBox();
			this.combo3 = new TJSystem.Classes.PriComboBox();
			this.combo1 = new TJSystem.Classes.PriComboBox();
			this.combo2 = new TJSystem.Classes.PriComboBox();
			this.lbl4 = new System.Windows.Forms.Label();
			this.txt4 = new TJSystem.Classes.PriTextBox();
			this.lbl3 = new System.Windows.Forms.Label();
			this.txt3 = new TJSystem.Classes.PriTextBox();
			this.lbl2 = new System.Windows.Forms.Label();
			this.txt2 = new TJSystem.Classes.PriTextBox();
			this.lbl1 = new System.Windows.Forms.Label();
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
			this.label1.Text = "常用参数维护";
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
			this.dataGrid1.Size = new System.Drawing.Size(597, 304);
			this.dataGrid1.TabIndex = 2;
			this.dataGrid1.TableStyles.AddRange(new System.Windows.Forms.DataGridTableStyle[] {
																								  this.dgsty1});
			// 
			// dgsty1
			// 
			this.dgsty1.DataGrid = this.dataGrid1;
			this.dgsty1.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.dgsty1.MappingName = "";
			// 
			// panel4
			// 
			this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.panel4.BackColor = System.Drawing.Color.White;
			this.panel4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel4.BackgroundImage")));
			this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.panel4.Controls.Add(this.combo6);
			this.panel4.Controls.Add(this.lbl6);
			this.panel4.Controls.Add(this.txt6);
			this.panel4.Controls.Add(this.combo5);
			this.panel4.Controls.Add(this.lbl5);
			this.panel4.Controls.Add(this.txt5);
			this.panel4.Controls.Add(this.combo4);
			this.panel4.Controls.Add(this.combo3);
			this.panel4.Controls.Add(this.combo1);
			this.panel4.Controls.Add(this.combo2);
			this.panel4.Controls.Add(this.lbl4);
			this.panel4.Controls.Add(this.txt4);
			this.panel4.Controls.Add(this.lbl3);
			this.panel4.Controls.Add(this.txt3);
			this.panel4.Controls.Add(this.lbl2);
			this.panel4.Controls.Add(this.txt2);
			this.panel4.Controls.Add(this.lbl1);
			this.panel4.Controls.Add(this.txt1);
			this.panel4.Location = new System.Drawing.Point(0, 0);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(597, 152);
			this.panel4.TabIndex = 1;
			// 
			// combo6
			// 
			this.combo6.BackColor = System.Drawing.Color.White;
			this.combo6.DataField = "";
			this.combo6.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.combo6.Location = new System.Drawing.Point(376, 48);
			this.combo6.Name = "combo6";
			this.combo6.Size = new System.Drawing.Size(184, 22);
			this.combo6.TabIndex = 118;
			// 
			// lbl6
			// 
			this.lbl6.BackColor = System.Drawing.Color.Transparent;
			this.lbl6.Location = new System.Drawing.Point(312, 48);
			this.lbl6.Name = "lbl6";
			this.lbl6.Size = new System.Drawing.Size(64, 23);
			this.lbl6.TabIndex = 116;
			this.lbl6.Text = "货币符号";
			this.lbl6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txt6
			// 
			this.txt6.BackColor = System.Drawing.Color.White;
			this.txt6.DataField = "symbol";
			this.txt6.DataType = TJSystem.Public.DataType.String;
			this.txt6.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.txt6.Location = new System.Drawing.Point(376, 48);
			this.txt6.Name = "txt6";
			this.txt6.Size = new System.Drawing.Size(184, 23);
			this.txt6.TabIndex = 117;
			this.txt6.Text = "";
			// 
			// combo5
			// 
			this.combo5.BackColor = System.Drawing.Color.White;
			this.combo5.DataField = "";
			this.combo5.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.combo5.Location = new System.Drawing.Point(376, 16);
			this.combo5.Name = "combo5";
			this.combo5.Size = new System.Drawing.Size(184, 22);
			this.combo5.TabIndex = 115;
			// 
			// lbl5
			// 
			this.lbl5.BackColor = System.Drawing.Color.Transparent;
			this.lbl5.Location = new System.Drawing.Point(312, 16);
			this.lbl5.Name = "lbl5";
			this.lbl5.Size = new System.Drawing.Size(64, 23);
			this.lbl5.TabIndex = 113;
			this.lbl5.Text = "货币符号";
			this.lbl5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txt5
			// 
			this.txt5.BackColor = System.Drawing.Color.White;
			this.txt5.DataField = "symbol";
			this.txt5.DataType = TJSystem.Public.DataType.String;
			this.txt5.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.txt5.Location = new System.Drawing.Point(376, 16);
			this.txt5.Name = "txt5";
			this.txt5.Size = new System.Drawing.Size(184, 23);
			this.txt5.TabIndex = 114;
			this.txt5.Text = "";
			// 
			// combo4
			// 
			this.combo4.BackColor = System.Drawing.Color.White;
			this.combo4.DataField = "";
			this.combo4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.combo4.Location = new System.Drawing.Point(96, 112);
			this.combo4.Name = "combo4";
			this.combo4.Size = new System.Drawing.Size(184, 22);
			this.combo4.TabIndex = 112;
			// 
			// combo3
			// 
			this.combo3.BackColor = System.Drawing.Color.White;
			this.combo3.DataField = "";
			this.combo3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.combo3.Location = new System.Drawing.Point(96, 80);
			this.combo3.Name = "combo3";
			this.combo3.Size = new System.Drawing.Size(184, 22);
			this.combo3.TabIndex = 111;
			// 
			// combo1
			// 
			this.combo1.BackColor = System.Drawing.Color.White;
			this.combo1.DataField = "";
			this.combo1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.combo1.Location = new System.Drawing.Point(96, 16);
			this.combo1.Name = "combo1";
			this.combo1.Size = new System.Drawing.Size(184, 22);
			this.combo1.TabIndex = 110;
			// 
			// combo2
			// 
			this.combo2.BackColor = System.Drawing.Color.White;
			this.combo2.DataField = "";
			this.combo2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.combo2.Location = new System.Drawing.Point(96, 48);
			this.combo2.Name = "combo2";
			this.combo2.Size = new System.Drawing.Size(184, 22);
			this.combo2.TabIndex = 109;
			// 
			// lbl4
			// 
			this.lbl4.BackColor = System.Drawing.Color.Transparent;
			this.lbl4.Location = new System.Drawing.Point(8, 112);
			this.lbl4.Name = "lbl4";
			this.lbl4.Size = new System.Drawing.Size(80, 23);
			this.lbl4.TabIndex = 107;
			this.lbl4.Text = "货币符号";
			this.lbl4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txt4
			// 
			this.txt4.BackColor = System.Drawing.Color.White;
			this.txt4.DataField = "symbol";
			this.txt4.DataType = TJSystem.Public.DataType.String;
			this.txt4.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.txt4.Location = new System.Drawing.Point(96, 112);
			this.txt4.Name = "txt4";
			this.txt4.Size = new System.Drawing.Size(184, 23);
			this.txt4.TabIndex = 108;
			this.txt4.Text = "";
			// 
			// lbl3
			// 
			this.lbl3.BackColor = System.Drawing.Color.Transparent;
			this.lbl3.Location = new System.Drawing.Point(8, 80);
			this.lbl3.Name = "lbl3";
			this.lbl3.Size = new System.Drawing.Size(80, 23);
			this.lbl3.TabIndex = 105;
			this.lbl3.Text = "中文名称";
			this.lbl3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txt3
			// 
			this.txt3.BackColor = System.Drawing.Color.White;
			this.txt3.DataField = "currency_namecn";
			this.txt3.DataType = TJSystem.Public.DataType.String;
			this.txt3.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.txt3.Location = new System.Drawing.Point(96, 80);
			this.txt3.Name = "txt3";
			this.txt3.Size = new System.Drawing.Size(184, 23);
			this.txt3.TabIndex = 106;
			this.txt3.Text = "";
			// 
			// lbl2
			// 
			this.lbl2.BackColor = System.Drawing.Color.Transparent;
			this.lbl2.Location = new System.Drawing.Point(8, 48);
			this.lbl2.Name = "lbl2";
			this.lbl2.Size = new System.Drawing.Size(80, 23);
			this.lbl2.TabIndex = 103;
			this.lbl2.Text = "英文名称";
			this.lbl2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txt2
			// 
			this.txt2.BackColor = System.Drawing.Color.White;
			this.txt2.DataField = "currency_name";
			this.txt2.DataType = TJSystem.Public.DataType.String;
			this.txt2.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.txt2.Location = new System.Drawing.Point(96, 48);
			this.txt2.Name = "txt2";
			this.txt2.Size = new System.Drawing.Size(184, 23);
			this.txt2.TabIndex = 104;
			this.txt2.Text = "";
			// 
			// lbl1
			// 
			this.lbl1.BackColor = System.Drawing.Color.Transparent;
			this.lbl1.ForeColor = System.Drawing.Color.Blue;
			this.lbl1.Location = new System.Drawing.Point(8, 16);
			this.lbl1.Name = "lbl1";
			this.lbl1.Size = new System.Drawing.Size(80, 23);
			this.lbl1.TabIndex = 101;
			this.lbl1.Text = "货币代码";
			this.lbl1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txt1
			// 
			this.txt1.BackColor = System.Drawing.Color.White;
			this.txt1.DataField = "currency_code";
			this.txt1.DataType = TJSystem.Public.DataType.String;
			this.txt1.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.txt1.Location = new System.Drawing.Point(96, 16);
			this.txt1.Name = "txt1";
			this.txt1.Size = new System.Drawing.Size(184, 23);
			this.txt1.TabIndex = 102;
			this.txt1.Text = "";
			// 
			// frmBasicParams
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
			this.Name = "frmBasicParams";
			this.Text = "常用参数维护";
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
			sb.Append("SELECT sn, dwname, dwdesc ");
			sb.Append("FROM xf_parm ");
			sb.Append("ORDER BY sn");
			DataTable dt = TJSystem.Public.PublicStatic.db.GetDataTable(sb.ToString());
			DataView dv = dt.DefaultView ;
			System.Windows.Forms.TreeNode tn ;
			System.Windows.Forms.ImageList imgList = new ImageList();
			imgList.ImageSize = new Size(25,25);
			imgList.Images.Add(Image.FromFile("images\\list.ico"));
			imgList.Images.Add(Image.FromFile("images\\node.ico"));
			imgList.Images.Add(Image.FromFile("images\\select.ico"));

			this.treeView1.ImageList = imgList;
			this.treeView1.SelectedImageIndex = 2;

			for(int i = 0 ; i < dv.Count ; i ++)
			{
				string str = dv[i][1].ToString();
				tn = new TreeNode(dv[i][2].ToString());
				tn.ImageIndex = 1;
				this.treeView1.Nodes.Add(tn);
			}
		}

		private void treeView1_DoubleClick(object sender, System.EventArgs e)
		{
			System.Windows.Forms.DataGridTableStyle dgstyle = null;
						
			_PK = "";
			System.Text.StringBuilder sb = new System.Text.StringBuilder();
			sb.Append("select ");
			setVisibleFalse();
			dgtbc1 = new DataGridTextBoxColumn();
			dgtbc2 = new DataGridTextBoxColumn();
			dgtbc3 = new DataGridTextBoxColumn();
			dgtbc4 = new DataGridTextBoxColumn();
			foreach(System.Windows.Forms.TreeNode tn in this.treeView1.Nodes)
			{
				if(tn.IsSelected && tn.GetNodeCount(true)==0)
				{
					this.dataGrid1.CaptionText = tn.Text;
					switch(tn.Text)
					{
						case "币种":
						{							
							this.lbl1.Visible = true;
							this.lbl2.Visible = true;
							this.lbl3.Visible = true;
							this.lbl4.Visible = true;
							this.txt1.Visible = true;
							this.txt2.Visible = true;
							this.txt3.Visible = true;
							this.txt4.Visible = true;
							#region 币种	
							this.dgsty1.GridColumnStyles.Clear();
							this.dgsty1.GridColumnStyles.Add(dgtbc1);
							this.dgsty1.GridColumnStyles.Add(dgtbc2);
							this.dgsty1.GridColumnStyles.Add(dgtbc3);
							this.dgsty1.GridColumnStyles.Add(dgtbc4);

							this.lbl1.Text = "货币代码";
							this.lbl2.Text = "英文名称";
							this.lbl3.Text = "中文名称";
							this.lbl4.Text = "货币符号";
							this.txt1.DataField = "currency_code";
							this.txt2.DataField = "currency_name";
							this.txt3.DataField = "currency_namecn";
							this.txt4.DataField = "symbol";
							this.dgsty1.MappingName = "p_currency";
							this.dgtbc1.MappingName = "currency_code";
							this.dgtbc1.HeaderText = "货币代码";
							this.dgtbc2.MappingName = "currency_name";
							this.dgtbc2.HeaderText = "英文名称";
							dgtbc3.MappingName = "currency_namecn";
							dgtbc3.HeaderText = "中文名称";
							dgtbc4.MappingName = "symbol";
							dgtbc4.HeaderText = "货币符号";
							

							dgstyle = this.dgsty1;
							sb.Append(this.txt1.DataField);
							sb.Append(",");
							sb.Append(this.txt2.DataField);
							sb.Append(",");
							sb.Append(this.txt3.DataField);
							sb.Append(",");
							sb.Append(this.txt4.DataField);
							sb.Append(" from ");
							sb.Append(dgstyle.MappingName);
							sb.Append(" order by ");
							sb.Append(this.txt1.DataField);
							break;
							#endregion						
						}
						case "货币兑换率":
						{
							this.lbl1.Visible = true;
							this.lbl2.Visible = true;
							this.lbl3.Visible = true;
							this.lbl4.Visible = true;
							this.txt1.Visible = true;
							this.combo2.Visible = true;
							this.combo3.Visible = true;
							this.txt4.Visible = true;
							string sql = "select CURRENCY_CODE,CURRENCY_CODE + ' ' + CURRENCY_NAMECN as CURRENCY_NAMECN from p_currency order by currency_code";
							this.InitialPriComboBox(this.combo2,sql,"CURRENCY_CODE","CURRENCY_NAMECN");
							this.InitialPriComboBox(this.combo3,sql,"CURRENCY_CODE","CURRENCY_NAMECN");
							this.dgsty1.GridColumnStyles.Clear();
							this.dgsty1.GridColumnStyles.Add(dgtbc1);
							this.dgsty1.GridColumnStyles.Add(dgtbc2);
							this.dgsty1.GridColumnStyles.Add(dgtbc3);
							this.dgsty1.GridColumnStyles.Add(dgtbc4);
							#region 货币兑换率						
							this.lbl1.Text = "编号";
							this.lbl2.Text = "原货币";
							this.lbl3.Text = "目标货币";
							this.lbl4.Text = "兑换率";
							this.txt1.DataField = "seq_no";
							this.combo2.DataField = "sourcecurrency";
							this.combo3.DataField = "destcurrency";
							this.txt4.DataField = "exchangerate";
							this.dgsty1.MappingName = "p_currencyexchange";
							this.dgtbc1.MappingName = "seq_no";
							this.dgtbc1.HeaderText = "编号";
							this.dgtbc2.MappingName = "sourcecurrency";
							this.dgtbc2.HeaderText = "原货币";
							dgtbc3.MappingName = "destcurrency";
							dgtbc3.HeaderText = "目标货币";
							dgtbc4.MappingName = "exchangerate";
							dgtbc4.HeaderText = "兑换率";
							dgstyle = this.dgsty1;
							sb.Append(this.txt1.DataField);
							sb.Append(",");
							sb.Append(this.combo2.DataField);
							sb.Append(",");
							sb.Append(this.combo3.DataField);
							sb.Append(",");
							sb.Append(this.txt4.DataField);
							sb.Append(" from ");
							sb.Append(dgstyle.MappingName);
							sb.Append(" order by ");
							sb.Append(this.txt1.DataField);
							break;
							#endregion						
						}
						case "单位":
						{
							this.lbl1.Visible = true;
							this.lbl2.Visible = true;
							this.lbl3.Visible = true;
							this.lbl4.Visible = true;
							this.txt1.Visible = true;
							this.txt2.Visible = true;
							this.txt3.Visible = true;
							this.txt4.Visible = true;
							this.dgsty1.GridColumnStyles.Clear();
							this.dgsty1.GridColumnStyles.Add(dgtbc1);
							this.dgsty1.GridColumnStyles.Add(dgtbc2);
							this.dgsty1.GridColumnStyles.Add(dgtbc3);
							this.dgsty1.GridColumnStyles.Add(dgtbc4);
							#region 单位						
							this.lbl1.Text = "编号";
							this.lbl2.Text = "单位英文名";
							this.lbl3.Text = "单位中文名";
							this.lbl4.Text = "备注";
							this.txt1.DataField = "unit_id";
							this.txt2.DataField = "unit_name";
							this.txt3.DataField = "unit_name_cn";
							this.txt4.DataField = "mark";
							this.dgsty1.MappingName = "p_unit";
							this.dgtbc1.MappingName = "unit_id";
							this.dgtbc1.HeaderText = "编号";
							this.dgtbc2.MappingName = "unit_name";
							this.dgtbc2.HeaderText = "单位英文名";
							dgtbc3.MappingName = "unit_name_cn";
							dgtbc3.HeaderText = "单位中文名";
							dgtbc4.MappingName = "mark";
							dgtbc4.HeaderText = "备注";
							dgstyle = this.dgsty1;
							sb.Append(this.txt1.DataField);
							sb.Append(",");
							sb.Append(this.txt2.DataField);
							sb.Append(",");
							sb.Append(this.txt3.DataField);
							sb.Append(",");
							sb.Append(this.txt4.DataField);
							sb.Append(" from ");
							sb.Append(dgstyle.MappingName);
							sb.Append(" order by ");
							sb.Append(this.txt1.DataField);
							break;
							#endregion						
						}
						case "国家":
						{
							this.lbl1.Visible = true;
							this.lbl2.Visible = true;
							this.lbl3.Visible = true;
							this.lbl4.Visible = true;
							this.txt1.Visible = true;
							this.txt2.Visible = true;
							this.txt3.Visible = true;
							this.txt4.Visible = true;
							this.dgsty1.GridColumnStyles.Clear();
							this.dgsty1.GridColumnStyles.Add(dgtbc1);
							this.dgsty1.GridColumnStyles.Add(dgtbc2);
							this.dgsty1.GridColumnStyles.Add(dgtbc3);
							this.dgsty1.GridColumnStyles.Add(dgtbc4);
							#region 国家						
							this.lbl1.Text = "国家编号";
							this.lbl2.Text = "简写";
							this.lbl3.Text = "英文名";
							this.lbl4.Text = "中文名";
							this.txt1.DataField = "country_code";
							this.txt2.DataField = "simplename";
							this.txt3.DataField = "country_name";
							this.txt4.DataField = "country_namecn";
							this.dgsty1.MappingName = "p_country";
							this.dgtbc1.MappingName = "country_code";
							this.dgtbc1.HeaderText = "国家编号";
							this.dgtbc2.MappingName = "simplename";
							this.dgtbc2.HeaderText = "简写";
							dgtbc3.MappingName = "country_name";
							dgtbc3.HeaderText = "英文名";
							dgtbc4.MappingName = "country_namecn";
							dgtbc4.HeaderText = "中文名";
							dgstyle = this.dgsty1;
							sb.Append(this.txt1.DataField);
							sb.Append(",");
							sb.Append(this.txt2.DataField);
							sb.Append(",");
							sb.Append(this.txt3.DataField);
							sb.Append(",");
							sb.Append(this.txt4.DataField);
							sb.Append(" from ");
							sb.Append(dgstyle.MappingName);
							sb.Append(" order by ");
							sb.Append(this.txt1.DataField);
							break;
							#endregion						
						}
						case "地区":
						{
							this.lbl1.Visible = true;
							this.lbl2.Visible = true;
							this.lbl3.Visible = true;
							this.lbl4.Visible = true;
							this.lbl5.Visible = true;
							this.txt1.Visible = true;
							this.combo2.Visible = true;
							string sql = "select COUNTRY_CODE,COUNTRY_CODE + ' ' + COUNTRY_NAMECN as COUNTRY_NAMECN from p_COUNTRY order by COUNTRY_CODE";
							this.InitialPriComboBox(this.combo2,sql,"COUNTRY_CODE","COUNTRY_NAMECN");
							this.txt3.Visible = true;
							this.txt4.Visible = true;
							this.txt5.Visible = true;
							this.dgsty1.GridColumnStyles.Clear();
							this.dgsty1.GridColumnStyles.Add(dgtbc1);
							this.dgsty1.GridColumnStyles.Add(dgtbc2);
							this.dgsty1.GridColumnStyles.Add(dgtbc3);
							this.dgsty1.GridColumnStyles.Add(dgtbc4);
							this.dgsty1.GridColumnStyles.Add(dgtbc5);
							#region 地区						
							this.lbl1.Text = "地区编号";
							this.lbl2.Text = "国家编号";
							this.lbl3.Text = "地区简写";
							this.lbl4.Text = "地区名称";
							this.lbl5.Text = "中文名称";
							this.txt1.DataField = "region_code";
							this.combo2.DataField = "country_code";
							this.txt3.DataField = "simplename";
							this.txt4.DataField = "region_name";
							this.txt5.DataField = "region_namecn";
							this.dgsty1.MappingName = "p_region";
							this.dgtbc1.MappingName = "region_code";
							this.dgtbc1.HeaderText = "地区编号";
							this.dgtbc2.MappingName = "country_code";
							this.dgtbc2.HeaderText = "国家编号";
							dgtbc3.MappingName = "simplename";
							dgtbc3.HeaderText = "地区简写";
							dgtbc4.MappingName = "region_name";
							dgtbc4.HeaderText = "地区名称";
							dgtbc5.MappingName = "region_namecn";
							dgtbc5.HeaderText = "中文名称";
							dgstyle = this.dgsty1;
							sb.Append(this.txt1.DataField);
							sb.Append(",");
							sb.Append(this.combo2.DataField);
							sb.Append(",");
							sb.Append(this.txt3.DataField);
							sb.Append(",");
							sb.Append(this.txt4.DataField);
							sb.Append(",");
							sb.Append(this.txt5.DataField);
							sb.Append(" from ");
							sb.Append(dgstyle.MappingName);
							sb.Append(" order by ");
							sb.Append(this.txt1.DataField);
							break;
							#endregion						
						}
						case "港口":
						{
							this.lbl1.Visible = true;
							this.lbl2.Visible = true;
							this.lbl3.Visible = true;
							this.lbl4.Visible = true;
							this.txt1.Visible = true;
							this.combo2.Visible = true;
							string sql = "select COUNTRY_CODE,COUNTRY_CODE + ' ' + COUNTRY_NAMECN as COUNTRY_NAMECN from p_COUNTRY order by COUNTRY_CODE";
							this.InitialPriComboBox(this.combo2,sql,"COUNTRY_CODE","COUNTRY_NAMECN");
							this.txt3.Visible = true;
							this.txt4.Visible = true;
							this.dgsty1.GridColumnStyles.Clear();
							this.dgsty1.GridColumnStyles.Add(dgtbc1);
							this.dgsty1.GridColumnStyles.Add(dgtbc2);
							this.dgsty1.GridColumnStyles.Add(dgtbc3);
							this.dgsty1.GridColumnStyles.Add(dgtbc4);
							#region 港口						
							this.lbl1.Text = "港口编号";
							this.lbl2.Text = "国家编号";
							this.lbl3.Text = "港口英文名";
							this.lbl4.Text = "港口中文名";
							this.txt1.DataField = "port_code";
							this.combo2.DataField = "country_code";
							this.txt3.DataField = "port_name";
							this.txt4.DataField = "port_namecn";
							this.dgsty1.MappingName = "p_port";
							this.dgtbc1.MappingName = "port_code";
							this.dgtbc1.HeaderText = "港口编号";
							this.dgtbc2.MappingName = "country_code";
							this.dgtbc2.HeaderText = "国家编号";
							dgtbc3.MappingName = "port_name";
							dgtbc3.HeaderText = "港口英文名";
							dgtbc4.MappingName = "port_namecn";
							dgtbc4.HeaderText = "港口中文名";
							dgstyle = this.dgsty1;
							sb.Append(this.txt1.DataField);
							sb.Append(",");
							sb.Append(this.combo2.DataField);
							sb.Append(",");
							sb.Append(this.txt3.DataField);
							sb.Append(",");
							sb.Append(this.txt4.DataField);
							sb.Append(" from ");
							sb.Append(dgstyle.MappingName);
							sb.Append(" order by ");
							sb.Append(this.txt1.DataField);
							break;
							#endregion						
						}
						case "包装方式":
						{
							this.lbl1.Visible = true;
							this.lbl2.Visible = true;
							this.txt1.Visible = true;
							this.txt2.Visible = true;
							this.dgsty1.GridColumnStyles.Clear();
							this.dgsty1.GridColumnStyles.Add(dgtbc1);
							this.dgsty1.GridColumnStyles.Add(dgtbc2);
							#region 包装方式						
							this.lbl1.Text = "编号";
							this.lbl2.Text = "名称";
							this.txt1.DataField = "pack_method_id";
							this.txt2.DataField = "pack_method_name";
							this.txt3.DataField = "";
							this.txt4.DataField = "";
							this.dgsty1.MappingName = "p_packmethod";
							this.dgtbc1.MappingName = "pack_method_id";
							this.dgtbc1.HeaderText = "编号";
							this.dgtbc2.MappingName = "pack_method_name";
							this.dgtbc2.HeaderText = "名称";
							dgstyle = dgsty1;
							sb.Append(this.txt1.DataField);
							sb.Append(",");
							sb.Append(this.txt2.DataField);
							sb.Append(" from ");
							sb.Append(dgstyle.MappingName);
							sb.Append(" order by ");
							sb.Append(this.txt1.DataField);
							break;
							#endregion						
						}
						case "包装类型":
						{
							this.lbl1.Visible = true;
							this.lbl2.Visible = true;
							this.lbl3.Visible = true;
							this.txt1.Visible = true;
							this.txt2.Visible = true;
							this.txt3.Visible = true;
							this.dgsty1.GridColumnStyles.Clear();
							this.dgsty1.GridColumnStyles.Add(dgtbc1);
							this.dgsty1.GridColumnStyles.Add(dgtbc2);
							this.dgsty1.GridColumnStyles.Add(dgtbc3);
							#region 包装类型						
							this.lbl1.Text = "编号";
							this.lbl2.Text = "名称";
							this.lbl2.Text = "中文名";
							this.txt1.DataField = "pack_code";
							this.txt2.DataField = "pack_name";
							this.txt3.DataField = "pack_namecn";
							this.dgsty1.MappingName = "p_packtype";
							this.dgtbc1.MappingName = "pack_code";
							this.dgtbc1.HeaderText = "编号";
							this.dgtbc2.MappingName = "pack_name";
							this.dgtbc2.HeaderText = "名称";
							this.dgtbc3.MappingName = "pack_namecn";
							this.dgtbc3.HeaderText = "中文名";
							dgstyle = dgsty1;
							sb.Append(this.txt1.DataField);
							sb.Append(",");
							sb.Append(this.txt2.DataField);
							sb.Append(",");
							sb.Append(this.txt3.DataField);
							sb.Append(" from ");
							sb.Append(dgstyle.MappingName);
							sb.Append(" order by ");
							sb.Append(this.txt1.DataField);
							break;
							#endregion						
						}
						case "价格条款":
						{
							this.lbl1.Visible = true;
							this.lbl2.Visible = true;
							this.lbl3.Visible = true;
							this.txt1.Visible = true;
							this.txt2.Visible = true;
							this.txt3.Visible = true;
							this.dgsty1.GridColumnStyles.Clear();
							this.dgsty1.GridColumnStyles.Add(dgtbc1);
							this.dgsty1.GridColumnStyles.Add(dgtbc2);
							this.dgsty1.GridColumnStyles.Add(dgtbc3);
							#region 价格条款						
							this.lbl1.Text = "条款编号";
							this.lbl2.Text = "条款名称";
							this.lbl2.Text = "中文名";
							this.txt1.DataField = "term_code";
							this.txt2.DataField = "term_name";
							this.txt3.DataField = "term_namecn";
							this.dgsty1.MappingName = "p_priceterm";
							this.dgtbc1.MappingName = "term_code";
							this.dgtbc1.HeaderText = "条款编号";
							this.dgtbc2.MappingName = "term_name";
							this.dgtbc2.HeaderText = "条款名称";
							this.dgtbc3.MappingName = "term_namecn";
							this.dgtbc3.HeaderText = "中文名";
							dgstyle = dgsty1;
							sb.Append(this.txt1.DataField);
							sb.Append(",");
							sb.Append(this.txt2.DataField);
							sb.Append(",");
							sb.Append(this.txt3.DataField);
							sb.Append(" from ");
							sb.Append(dgstyle.MappingName);
							sb.Append(" order by ");
							sb.Append(this.txt1.DataField);
							break;
							#endregion						
						}
						case "仓库类型":
						{
							this.lbl1.Visible = true;
							this.lbl2.Visible = true;
							this.lbl3.Visible = true;
							this.txt1.Visible = true;
							this.txt2.Visible = true;
							this.txt3.Visible = true;
							this.dgsty1.GridColumnStyles.Clear();
							this.dgsty1.GridColumnStyles.Add(dgtbc1);
							this.dgsty1.GridColumnStyles.Add(dgtbc2);
							this.dgsty1.GridColumnStyles.Add(dgtbc3);
							#region 仓库类型						
							this.lbl1.Text = "类型编号";
							this.lbl2.Text = "类型名称";
							this.lbl2.Text = "中文名";
							this.txt1.DataField = "whtype_id";
							this.txt2.DataField = "whtype_name";
							this.txt3.DataField = "whtype_namecn";
							this.dgsty1.MappingName = "p_whousetype";
							this.dgtbc1.MappingName = "whtype_id";
							this.dgtbc1.HeaderText = "条款编号";
							this.dgtbc2.MappingName = "whtype_name";
							this.dgtbc2.HeaderText = "条款名称";
							this.dgtbc3.MappingName = "whtype_namecn";
							this.dgtbc3.HeaderText = "中文名";
							dgstyle = dgsty1;
							sb.Append(this.txt1.DataField);
							sb.Append(",");
							sb.Append(this.txt2.DataField);
							sb.Append(",");
							sb.Append(this.txt3.DataField);
							sb.Append(" from ");
							sb.Append(dgstyle.MappingName);
							sb.Append(" order by ");
							sb.Append(this.txt1.DataField);
							break;
							#endregion						
						}
						case "付款条款":
						{
							this.lbl1.Visible = true;
							this.lbl2.Visible = true;
							this.lbl3.Visible = true;
							this.txt1.Visible = true;
							this.txt2.Visible = true;
							this.txt3.Visible = true;
							this.dgsty1.GridColumnStyles.Clear();
							this.dgsty1.GridColumnStyles.Add(dgtbc1);
							this.dgsty1.GridColumnStyles.Add(dgtbc2);
							this.dgsty1.GridColumnStyles.Add(dgtbc3);
							#region 价格条款						
							this.lbl1.Text = "条款编号";
							this.lbl2.Text = "条款名称";
							this.lbl2.Text = "中文名";
							this.txt1.DataField = "term_code";
							this.txt2.DataField = "term_name";
							this.txt3.DataField = "term_namecn";
							this.dgsty1.MappingName = "p_paymentterm";
							this.dgtbc1.MappingName = "term_code";
							this.dgtbc1.HeaderText = "条款编号";
							this.dgtbc2.MappingName = "term_name";
							this.dgtbc2.HeaderText = "条款名称";
							this.dgtbc3.MappingName = "term_namecn";
							this.dgtbc3.HeaderText = "中文名";
							dgstyle = dgsty1;
							sb.Append(this.txt1.DataField);
							sb.Append(",");
							sb.Append(this.txt2.DataField);
							sb.Append(",");
							sb.Append(this.txt3.DataField);
							sb.Append(" from ");
							sb.Append(dgstyle.MappingName);
							sb.Append(" order by ");
							sb.Append(this.txt1.DataField);
							break;
							#endregion						
						}
						case "结汇(付款)方式":
						{
							this.lbl1.Visible = true;
							this.lbl2.Visible = true;
							this.lbl3.Visible = true;
							this.lbl4.Visible = true;
							this.txt1.Visible = true;
							this.txt2.Visible = true;
							this.txt3.Visible = true;
							this.txt4.Visible = true;
							this.dgsty1.GridColumnStyles.Clear();
							this.dgsty1.GridColumnStyles.Add(dgtbc1);
							this.dgsty1.GridColumnStyles.Add(dgtbc2);
							this.dgsty1.GridColumnStyles.Add(dgtbc3);
							this.dgsty1.GridColumnStyles.Add(dgtbc4);
							#region 结汇(付款)方式						
							this.lbl1.Text = "编号";
							this.lbl2.Text = "英文名";
							this.lbl3.Text = "中文名";
							this.lbl4.Text = "备注";
							this.txt1.DataField = "paymode_id";
							this.txt2.DataField = "paymode_name";
							this.txt3.DataField = "paymode_name_cn";
							this.txt4.DataField = "paymode_desc";
							this.dgsty1.MappingName = "p_paymode";
							this.dgtbc1.MappingName = "paymode_id";
							this.dgtbc1.HeaderText = "编号";
							this.dgtbc2.MappingName = "paymode_name";
							this.dgtbc2.HeaderText = "英文名";
							dgtbc3.MappingName = "paymode_name_cn";
							dgtbc3.HeaderText = "中文名";
							dgtbc4.MappingName = "paymode_desc";
							dgtbc4.HeaderText = "备注";
							dgstyle = this.dgsty1;
							sb.Append(this.txt1.DataField);
							sb.Append(",");
							sb.Append(this.txt2.DataField);
							sb.Append(",");
							sb.Append(this.txt3.DataField);
							sb.Append(",");
							sb.Append(this.txt4.DataField);
							sb.Append(" from ");
							sb.Append(dgstyle.MappingName);
							sb.Append(" order by ");
							sb.Append(this.txt1.DataField);
							break;
							#endregion						
						}
						case "企业类型":
						{
							this.lbl1.Visible = true;
							this.lbl2.Visible = true;
							this.txt1.Visible = true;
							this.txt2.Visible = true;
							this.dgsty1.GridColumnStyles.Clear();
							this.dgsty1.GridColumnStyles.Add(dgtbc1);
							this.dgsty1.GridColumnStyles.Add(dgtbc2);
							#region 企业类型
							this.lbl1.Text = "编号";
							this.lbl2.Text = "名称";
							this.txt1.DataField = "type_code";
							this.txt2.DataField = "type_name";
							this.txt3.DataField = "";
							this.txt4.DataField = "";
							this.dgsty1.MappingName = "p_enterprisetype";
							this.dgtbc1.MappingName = "type_code";
							this.dgtbc1.HeaderText = "编号";
							this.dgtbc2.MappingName = "type_name";
							this.dgtbc2.HeaderText = "名称";
							dgstyle = dgsty1;
							sb.Append(this.txt1.DataField);
							sb.Append(",");
							sb.Append(this.txt2.DataField);
							sb.Append(" from ");
							sb.Append(dgstyle.MappingName);
							sb.Append(" order by ");
							sb.Append(this.txt1.DataField);
							break;
							#endregion						
						}
						case "运输方式":
						{
							this.lbl1.Visible = true;
							this.lbl2.Visible = true;
							this.lbl3.Visible = true;
							this.txt1.Visible = true;
							this.txt2.Visible = true;
							this.txt3.Visible = true;
							this.dgsty1.GridColumnStyles.Clear();
							this.dgsty1.GridColumnStyles.Add(dgtbc1);
							this.dgsty1.GridColumnStyles.Add(dgtbc2);
							this.dgsty1.GridColumnStyles.Add(dgtbc3);
							#region 运输方式						
							this.lbl1.Text = "编号";
							this.lbl2.Text = "运输方式";
							this.lbl2.Text = "中文名";
							this.txt1.DataField = "trans_code";
							this.txt2.DataField = "trans_name";
							this.txt3.DataField = "trans_namecn";
							this.dgsty1.MappingName = "p_transtype";
							this.dgtbc1.MappingName = "trans_code";
							this.dgtbc1.HeaderText = "编号";
							this.dgtbc2.MappingName = "trans_name";
							this.dgtbc2.HeaderText = "运输方式";
							this.dgtbc3.MappingName = "trans_namecn";
							this.dgtbc3.HeaderText = "中文名";
							dgstyle = dgsty1;
							sb.Append(this.txt1.DataField);
							sb.Append(",");
							sb.Append(this.txt2.DataField);
							sb.Append(",");
							sb.Append(this.txt3.DataField);
							sb.Append(" from ");
							sb.Append(dgstyle.MappingName);
							sb.Append(" order by ");
							sb.Append(this.txt1.DataField);
							break;
							#endregion						
						}
						case "货柜类型":
						{
							this.lbl1.Visible = true;
							this.lbl2.Visible = true;
							this.lbl3.Visible = true;
							this.lbl4.Visible = true;
							this.txt1.Visible = true;
							this.txt2.Visible = true;
							this.txt3.Visible = true;
							this.txt3.DataType = TJSystem.Public.DataType.Number;
							this.txt4.Visible = true;
							this.txt4.DataType = TJSystem.Public.DataType.Number;
							this.dgsty1.GridColumnStyles.Clear();
							this.dgsty1.GridColumnStyles.Add(dgtbc1);
							this.dgsty1.GridColumnStyles.Add(dgtbc2);
							this.dgsty1.GridColumnStyles.Add(dgtbc3);
							this.dgsty1.GridColumnStyles.Add(dgtbc4);
							#region 货柜类型						
							this.lbl1.Text = "货柜编号";
							this.lbl2.Text = "货柜名";
							this.lbl3.Text = "Volumn";
							this.lbl4.Text = "重量";
							this.txt1.DataField = "tank_code";
							this.txt2.DataField = "tank_name";
							this.txt3.DataField = "volumn";
							this.txt4.DataField = "weight";
							this.dgsty1.MappingName = "p_tank";
							this.dgtbc1.MappingName = "tank_code";
							this.dgtbc1.HeaderText = "货柜编号";
							this.dgtbc2.MappingName = "tank_name";
							this.dgtbc2.HeaderText = "货柜名";
							dgtbc3.MappingName = "volumn";
							dgtbc3.HeaderText = "volumn";
							dgtbc4.MappingName = "weight";
							dgtbc4.HeaderText = "重量";
							dgstyle = this.dgsty1;
							sb.Append(this.txt1.DataField);
							sb.Append(",");
							sb.Append(this.txt2.DataField);
							sb.Append(",");
							sb.Append(this.txt3.DataField);
							sb.Append(",");
							sb.Append(this.txt4.DataField);
							sb.Append(" from ");
							sb.Append(dgstyle.MappingName);
							sb.Append(" order by ");
							sb.Append(this.txt1.DataField);
							break;
							#endregion						
						}
						case "商品分类":
						{
							this.lbl1.Visible = true;
							this.lbl2.Visible = true;
							this.lbl3.Visible = true;
							this.lbl4.Visible = true;
							this.txt1.Visible = true;
							this.txt2.Visible = true;
							this.txt3.Visible = true;
							this.txt4.Visible = true;
							this.dgsty1.GridColumnStyles.Clear();
							this.dgsty1.GridColumnStyles.Add(dgtbc1);
							this.dgsty1.GridColumnStyles.Add(dgtbc2);
							this.dgsty1.GridColumnStyles.Add(dgtbc3);
							this.dgsty1.GridColumnStyles.Add(dgtbc4);
							#region 商品分类						
							this.lbl1.Text = "编号";
							this.lbl2.Text = "商品名";
							this.lbl3.Text = "中文名";
							this.lbl4.Text = "所属类别";
							this.txt1.DataField = "itemtype";
							this.txt2.DataField = "typename";
							this.txt3.DataField = "typenamecn";
							this.txt4.DataField = "parentitemtype";
							this.dgsty1.MappingName = "p_itemtype";
							this.dgtbc1.MappingName = "itemtype";
							this.dgtbc1.HeaderText = "编号";
							this.dgtbc2.MappingName = "typename";
							this.dgtbc2.HeaderText = "商品名";
							dgtbc3.MappingName = "typenamecn";
							dgtbc3.HeaderText = "中文名";
							dgtbc4.MappingName = "parentitemtype";
							dgtbc4.HeaderText = "所属类别";
							dgstyle = this.dgsty1;
							sb.Append(this.txt1.DataField);
							sb.Append(",");
							sb.Append(this.txt2.DataField);
							sb.Append(",");
							sb.Append(this.txt3.DataField);
							sb.Append(",");
							sb.Append(this.txt4.DataField);
							sb.Append(" from ");
							sb.Append(dgstyle.MappingName);
							sb.Append(" order by ");
							sb.Append(this.txt1.DataField);
							break;
							#endregion						
						}
						case "保险条款":
						{
							this.lbl1.Visible = true;
							this.lbl2.Visible = true;
							this.lbl3.Visible = true;
							this.txt1.Visible = true;
							this.txt2.Visible = true;
							this.txt3.Visible = true;
							this.dgsty1.GridColumnStyles.Clear();
							this.dgsty1.GridColumnStyles.Add(dgtbc1);
							this.dgsty1.GridColumnStyles.Add(dgtbc2);
							this.dgsty1.GridColumnStyles.Add(dgtbc3);
							#region 保险条款						
							this.lbl1.Text = "编号";
							this.lbl2.Text = "描述";
							this.lbl2.Text = "中文描述";
							this.txt1.DataField = "term_code";
							this.txt2.DataField = "term_desc";
							this.txt3.DataField = "term_desccn";
							this.dgsty1.MappingName = "p_insuranceterm";
							this.dgtbc1.MappingName = "term_code";
							this.dgtbc1.HeaderText = "编号";
							this.dgtbc2.MappingName = "term_desc";
							this.dgtbc2.HeaderText = "描述";
							this.dgtbc3.MappingName = "term_desccn";
							this.dgtbc3.HeaderText = "中文描述";
							dgstyle = dgsty1;
							sb.Append(this.txt1.DataField);
							sb.Append(",");
							sb.Append(this.txt2.DataField);
							sb.Append(",");
							sb.Append(this.txt3.DataField);
							sb.Append(" from ");
							sb.Append(dgstyle.MappingName);
							sb.Append(" order by ");
							sb.Append(this.txt1.DataField);
							break;
							#endregion						
						}
						case "职位":
						{
							if(TJSystem.Public.PublicStatic.Priority < 10)
							{
								continue;
							}
							
							this.lbl1.Visible = true;
							this.lbl2.Visible = true;
							this.txt1.Visible = true;
							this.txt2.Visible = true;
							this.dgsty1.GridColumnStyles.Clear();
							this.dgsty1.GridColumnStyles.Add(dgtbc1);
							this.dgsty1.GridColumnStyles.Add(dgtbc2);
							#region 职位
							this.lbl1.Text = "编号";
							this.lbl2.Text = "职位名称";
							this.txt1.DataField = "position_id";
							this.txt2.DataField = "position_name";
							this.dgsty1.MappingName = "p_position";
							this.dgtbc1.MappingName = "position_id";
							this.dgtbc1.HeaderText = "编号";
							this.dgtbc2.MappingName = "position_name";
							this.dgtbc2.HeaderText = "职位名称";
							dgstyle = dgsty1;
							sb.Append(this.txt1.DataField);
							sb.Append(",");
							sb.Append(this.txt2.DataField);
							sb.Append(" from ");
							sb.Append(dgstyle.MappingName);
							sb.Append(" order by ");
							sb.Append(this.txt1.DataField);
							break;
							#endregion						
						}
						case "库存调整原因":
						{
							this.lbl1.Visible = true;
							this.lbl2.Visible = true;
							this.txt1.Visible = true;
							this.txt2.Visible = true;
							this.dgsty1.GridColumnStyles.Clear();
							this.dgsty1.GridColumnStyles.Add(dgtbc1);
							this.dgsty1.GridColumnStyles.Add(dgtbc2);
							#region 库存调整原因
							this.lbl1.Text = "编号";
							this.lbl2.Text = "原因描述";
							this.txt1.DataField = "reason_id";
							this.txt2.DataField = "reason_content";
							this.dgsty1.MappingName = "p_sa_reason";
							this.dgtbc1.MappingName = "reason_id";
							this.dgtbc1.HeaderText = "编号";
							this.dgtbc2.MappingName = "reason_content";
							this.dgtbc2.HeaderText = "职位名称";
							dgstyle = dgsty1;
							sb.Append(this.txt1.DataField);
							sb.Append(",");
							sb.Append(this.txt2.DataField);
							sb.Append(" from ");
							sb.Append(dgstyle.MappingName);
							sb.Append(" order by ");
							sb.Append(this.txt1.DataField);
							break;
							#endregion						
						}
						case "货品海关编码":
						{
							if(frmBasicCustomsParam.frmCurrent == null)
							{
								frmBasicCustomsParam.frmCurrent = new frmBasicCustomsParam();
								frmBasicCustomsParam.frmCurrent.MdiParent = this.MdiParent;
							}
							frmBasicCustomsParam.frmCurrent.WindowState = System.Windows.Forms.FormWindowState.Maximized;
							frmBasicCustomsParam.frmCurrent.Show();
							break;
						}
						case "贸易性质":
						{
							this.lbl1.Visible = true;
							this.lbl2.Visible = true;
							this.txt1.Visible = true;
							this.txt2.Visible = true;
							this.dgsty1.GridColumnStyles.Clear();
							this.dgsty1.GridColumnStyles.Add(dgtbc1);
							this.dgsty1.GridColumnStyles.Add(dgtbc2);
							#region 贸易性质
							this.lbl1.Text = "贸易编号";
							this.lbl2.Text = "贸易名称";
							this.txt1.DataField = "trade_id";
							this.txt2.DataField = "trade_desc";
							this.dgsty1.MappingName = "p_tradechar";
							this.dgtbc1.MappingName = "trade_id";
							this.dgtbc1.HeaderText = "贸易编号";
							this.dgtbc2.MappingName = "trade_desc";
							this.dgtbc2.HeaderText = "贸易名称";
							dgstyle = dgsty1;
							sb.Append(this.txt1.DataField);
							sb.Append(",");
							sb.Append(this.txt2.DataField);
							sb.Append(" from ");
							sb.Append(dgstyle.MappingName);
							sb.Append(" order by ");
							sb.Append(this.txt1.DataField);
							break;
							#endregion						
						}
						case "客户来源":
						{
							this.lbl1.Visible = true;
							this.lbl2.Visible = true;
							this.txt1.Visible = true;
							this.txt2.Visible = true;
							this.dgsty1.GridColumnStyles.Clear();
							this.dgsty1.GridColumnStyles.Add(dgtbc1);
							this.dgsty1.GridColumnStyles.Add(dgtbc2);
							#region 客户来源
							this.lbl1.Text = "编号";
							this.lbl2.Text = "描述";
							this.txt1.DataField = "from_id";
							this.txt2.DataField = "description";
							this.dgsty1.MappingName = "p_clientfrom";
							this.dgtbc1.MappingName = "from_id";
							this.dgtbc1.HeaderText = "编号";
							this.dgtbc2.MappingName = "description";
							this.dgtbc2.HeaderText = "描述";
							dgstyle = dgsty1;
							sb.Append(this.txt1.DataField);
							sb.Append(",");
							sb.Append(this.txt2.DataField);
							sb.Append(" from ");
							sb.Append(dgstyle.MappingName);
							sb.Append(" order by ");
							sb.Append(this.txt1.DataField);
							break;
							#endregion						
						}
						case "海关监管证件代码":
						{
							this.lbl1.Visible = true;
							this.lbl2.Visible = true;
							this.lbl3.Visible = true;
							this.lbl4.Visible = true;
							this.txt1.Visible = true;
							this.txt2.Visible = true;
							this.txt3.Visible = true;
							this.txt4.Visible = true;
							this.dgsty1.GridColumnStyles.Clear();
							this.dgsty1.GridColumnStyles.Add(dgtbc1);
							this.dgsty1.GridColumnStyles.Add(dgtbc2);
							this.dgsty1.GridColumnStyles.Add(dgtbc3);
							this.dgsty1.GridColumnStyles.Add(dgtbc4);
							#region 海关监管证件代码						
							this.lbl1.Text = "编号";
							this.lbl2.Text = "证件ID";
							this.lbl3.Text = "证件名称";
							this.lbl4.Text = "描述";
							this.txt1.DataField = "seq_no";
							this.txt2.DataField = "wc_id";
							this.txt3.DataField = "wc_name";
							this.txt4.DataField = "wc_desc";
							this.dgsty1.MappingName = "p_watchcert";
							this.dgtbc1.MappingName = "seq_no";
							this.dgtbc1.HeaderText = "编号";
							this.dgtbc2.MappingName = "wc_id";
							this.dgtbc2.HeaderText = "证件ID";
							dgtbc3.MappingName = "wc_name";
							dgtbc3.HeaderText = "证件名称";
							dgtbc4.MappingName = "wc_desc";
							dgtbc4.HeaderText = "描述";
							dgstyle = this.dgsty1;
							sb.Append(this.txt1.DataField);
							sb.Append(",");
							sb.Append(this.txt2.DataField);
							sb.Append(",");
							sb.Append(this.txt3.DataField);
							sb.Append(",");
							sb.Append(this.txt4.DataField);
							sb.Append(" from ");
							sb.Append(dgstyle.MappingName);
							sb.Append(" order by ");
							sb.Append(this.txt1.DataField);
							break;
							#endregion		
						}
						case "费用类型":
						{
							this.lbl1.Visible = true;
							this.lbl2.Visible = true;
							this.lbl3.Visible = true;
							this.lbl4.Visible = true;							
							this.txt1.Visible = true;
							this.txt2.Visible = true;
							this.txt3.Visible = true;
							this.txt4.Visible = true;							
							this.dgsty1.GridColumnStyles.Clear();
							this.dgsty1.GridColumnStyles.Add(dgtbc1);
							this.dgsty1.GridColumnStyles.Add(dgtbc2);
							this.dgsty1.GridColumnStyles.Add(dgtbc3);
							this.dgsty1.GridColumnStyles.Add(dgtbc4);
							#region 费用类型						
							this.lbl1.Text = "类型编号";
							this.lbl2.Text = "类型名称";
							this.lbl3.Text = "所属类别";
							this.lbl4.Text = "Profit Loss";
							this.txt1.DataField = "feetype_id";
							this.txt2.DataField = "feetype_name";
							this.txt3.DataField = "feetype_type";
							this.txt4.DataField = "feetype_profit_loss";
							this.dgsty1.MappingName = "p_feetype";
							this.dgtbc1.MappingName = "feetype_id";
							this.dgtbc1.HeaderText = "类型编号";
							this.dgtbc2.MappingName = "feetype_name";
							this.dgtbc2.HeaderText = "类型名称";
							dgtbc3.MappingName = "feetype_type";
							dgtbc3.HeaderText = "所属类别";
							dgtbc4.MappingName = "feetype_profit_loss";
							dgtbc4.HeaderText = "Profit Loss";
							dgstyle = this.dgsty1;
							sb.Append(this.txt1.DataField);
							sb.Append(",");
							sb.Append(this.txt2.DataField);
							sb.Append(",");
							sb.Append(this.txt3.DataField);
							sb.Append(",");
							sb.Append(this.txt4.DataField);
							sb.Append(" from ");
							sb.Append(dgstyle.MappingName);
							sb.Append(" order by ");
							sb.Append(this.txt1.DataField);
							break;
							#endregion		
						}
						case "联系方式":
						{
							this.lbl1.Visible = true;
							this.lbl2.Visible = true;
							this.txt1.Visible = true;
							this.txt2.Visible = true;
							this.dgsty1.GridColumnStyles.Clear();
							this.dgsty1.GridColumnStyles.Add(dgtbc1);
							this.dgsty1.GridColumnStyles.Add(dgtbc2);
							#region 联系方式
							this.lbl1.Text = "编号";
							this.lbl2.Text = "名称";
							this.txt1.DataField = "contacttype_id";
							this.txt2.DataField = "contacttype";
							this.dgsty1.MappingName = "p_contacttype";
							this.dgtbc1.MappingName = "contacttype_id";
							this.dgtbc1.HeaderText = "编号";
							this.dgtbc2.MappingName = "contacttype";
							this.dgtbc2.HeaderText = "名称";
							dgstyle = dgsty1;
							sb.Append(this.txt1.DataField);
							sb.Append(",");
							sb.Append(this.txt2.DataField);
							sb.Append(" from ");
							sb.Append(dgstyle.MappingName);
							sb.Append(" order by ");
							sb.Append(this.txt1.DataField);
							break;
							#endregion						
						}
						case "联系目的":
						{
							this.lbl1.Visible = true;
							this.lbl2.Visible = true;
							this.txt1.Visible = true;
							this.txt2.Visible = true;
							this.dgsty1.GridColumnStyles.Clear();
							this.dgsty1.GridColumnStyles.Add(dgtbc1);
							this.dgsty1.GridColumnStyles.Add(dgtbc2);
							#region 联系目的
							this.lbl1.Text = "编号";
							this.lbl2.Text = "名称";
							this.txt1.DataField = "contactpurpose_id";
							this.txt2.DataField = "contact_purpose";
							this.dgsty1.MappingName = "p_contactpurpose";
							this.dgtbc1.MappingName = "contactpurpose_id";
							this.dgtbc1.HeaderText = "编号";
							this.dgtbc2.MappingName = "contact_purpose";
							this.dgtbc2.HeaderText = "名称";
							dgstyle = dgsty1;
							sb.Append(this.txt1.DataField);
							sb.Append(",");
							sb.Append(this.txt2.DataField);
							sb.Append(" from ");
							sb.Append(dgstyle.MappingName);
							sb.Append(" order by ");
							sb.Append(this.txt1.DataField);
							break;
							#endregion						
						}
						case "客户分类":
						{
							this.lbl1.Visible = true;
							this.lbl2.Visible = true;
							this.lbl3.Visible = true;
							this.txt1.Visible = true;
							this.txt2.Visible = true;
							this.txt3.Visible = true;
//							string sql = "select SORT_ID,SORT_ID+' '+SORT_DESC AS SORT_DESC FROM P_CLIENTSORT ORDER BY SORT_ID";
//							this.InitialPriComboBox(this.combo3,sql,"SORT_ID","SORT_DESC");
							this.dgsty1.GridColumnStyles.Clear();
							this.dgsty1.GridColumnStyles.Add(dgtbc1);
							this.dgsty1.GridColumnStyles.Add(dgtbc2);
							this.dgsty1.GridColumnStyles.Add(dgtbc3);
							#region 客户分类						
							this.lbl1.Text = "编号";
							this.lbl2.Text = "描述";
							this.lbl2.Text = "中文描述";
							this.txt1.DataField = "SORT_ID";
							this.txt2.DataField = "SORT_DESC";
							this.txt3.DataField = "sort_parentid";
							this.dgsty1.MappingName = "p_clientsort";
							this.dgtbc1.MappingName = "SORT_ID";
							this.dgtbc1.HeaderText = "编号";
							this.dgtbc2.MappingName = "SORT_DESC";
							this.dgtbc2.HeaderText = "描述";
							this.dgtbc3.MappingName = "sort_parentid";
							this.dgtbc3.HeaderText = "所属类别";
							dgstyle = dgsty1;
							sb.Append(this.txt1.DataField);
							sb.Append(",");
							sb.Append(this.txt2.DataField);
							sb.Append(",");
							sb.Append(this.txt3.DataField);
							sb.Append(" from ");
							sb.Append(dgstyle.MappingName);
							sb.Append(" order by ");
							sb.Append(this.txt1.DataField);
							break;
							#endregion						
						}
						case "状态":
						{		
							if(TJSystem.Public.PublicStatic.Priority < 10)
							{
								continue;
							}
							this.lbl1.Visible = true;
							this.lbl2.Visible = true;
							this.txt1.Visible = true;
							this.txt2.Visible = true;
							this.txt3.Visible = true;
							this.lbl3.Visible = true;
							#region 状态	
							this.dgsty1.GridColumnStyles.Clear();
							this.dgsty1.GridColumnStyles.Add(dgtbc1);
							this.dgsty1.GridColumnStyles.Add(dgtbc2);
							this.dgsty1.GridColumnStyles.Add(dgtbc3);

							this.lbl1.Text = "状态代码";
							this.lbl2.Text = "状态名称";
							this.lbl3.Text = "状态类型";
							
							this.txt1.DataField = "status_id";
							this.txt2.DataField = "status_name";
							this.txt3.DataField = "status_type";

							_PK = "status_id,status_type";
							
							this.dgsty1.MappingName = "p_status";
							this.dgtbc1.MappingName = "status_id";
							this.dgtbc1.HeaderText = "状态代码";
							this.dgtbc2.MappingName = "status_name";
							this.dgtbc2.HeaderText = "状态名称";
							this.dgtbc3.MappingName = "status_type";
							this.dgtbc3.HeaderText = "状态类型";
							
							dgstyle = this.dgsty1;
							sb.Append(this.txt1.DataField);
							sb.Append(",");
							sb.Append(this.txt2.DataField);
							sb.Append(",");
							sb.Append(this.txt3.DataField);
														
							sb.Append(" from ");
							sb.Append(dgstyle.MappingName);
							sb.Append(" order by ");
							sb.Append(this.txt3.DataField);
							sb.Append(",");
							sb.Append(this.txt1.DataField);
							break;
							#endregion						
						}
						case "企业等级":
						{							
							this.lbl1.Visible = true;
							this.lbl2.Visible = true;
							this.txt1.Visible = true;
							this.txt2.Visible = true;
							#region 企业等级	
							this.dgsty1.GridColumnStyles.Clear();
							this.dgsty1.GridColumnStyles.Add(dgtbc1);
							this.dgsty1.GridColumnStyles.Add(dgtbc2);

							this.lbl1.Text = "等级代码";
							this.lbl2.Text = "等级名称";
							
							this.txt1.DataField = "grade_id";
							this.txt2.DataField = "grade_name";
							
							this.dgsty1.MappingName = "p_grade";
							this.dgtbc1.MappingName = "grade_id";
							this.dgtbc1.HeaderText = "等级代码";
							this.dgtbc2.MappingName = "grade_name";
							this.dgtbc2.HeaderText = "等级名称";
							
							dgstyle = this.dgsty1;
							sb.Append(this.txt1.DataField);
							sb.Append(",");
							sb.Append(this.txt2.DataField);
														
							sb.Append(" from ");
							sb.Append(dgstyle.MappingName);
							sb.Append(" order by ");
							sb.Append(this.txt1.DataField);
							break;
							#endregion						
						}
						default:
							break;
					}	
				}
			}
			if(dgstyle == null)
			{
				return;
			}
			this.InitialGrid(sb.ToString(),dgstyle);
			priToolBar2.setCurrentForm = this;
			if(_PK.Equals(""))
			{
				_PK = this.txt1.DataField;
			}
			priToolBar2.Initial(dgstyle.MappingName,_PK,sb.ToString());
			priToolBar2.BeforeButtonClickEvent += new TJSystem.UC.PriToolBar.BeforeButotnClick(this.BeforeButtonClick);
			priToolBar2.AfterButtonClickEvent += new TJSystem.UC.PriToolBar.AfterButtonClick(this.AfterButtonClick);
		}
		
		private void InitialGrid(string sql,System.Windows.Forms.DataGridTableStyle dgstyle)
		{		
			DataTable dt = TJSystem.Public.PublicStatic.db.GetDataTable(sql);
			dt.TableName = dgstyle.MappingName;
			dgstyle.DataGrid.DataSource = dt.DefaultView;
		}


		private void setVisibleFalse()
		{
			this.lbl1.Visible = false;
			this.lbl2.Visible = false;
			this.lbl3.Visible = false;
			this.lbl4.Visible = false;
			this.lbl5.Visible = false;
			this.lbl6.Visible = false;
			this.txt1.Visible = false;
			this.txt1.DataType = TJSystem.Public.DataType.String;
			this.txt2.Visible = false;
			this.txt2.DataType = TJSystem.Public.DataType.String;
			this.txt3.Visible = false;
			this.txt3.DataType = TJSystem.Public.DataType.String;
			this.txt4.Visible = false;
			this.txt4.DataType = TJSystem.Public.DataType.String;
			this.txt5.Visible = false;
			this.txt5.DataType = TJSystem.Public.DataType.String;
			this.txt6.Visible = false;
			this.txt6.DataType = TJSystem.Public.DataType.String;
			this.combo1.Visible = false;
			this.combo2.Visible = false;
			this.combo3.Visible = false;
			this.combo3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.combo4.Visible = false;
			this.combo5.Visible = false;
			this.combo6.Visible = false;
		}

		private void InitialPriComboBox(TJSystem.Classes.PriComboBox combobox,string sql,string valuemember,string displaymember)
		{
			DataTable dt = TJSystem.Public.PublicStatic.db.GetDataTable(sql);
//			DataRow dr = dt.NewRow();
//			dr[0]=" ";
//			dr[1]=" ";
//			dt.Rows.InsertAt(dr,0);
			combobox.DataSource = dt.DefaultView;
			combobox.ValueMember = valuemember;
			combobox.DisplayMember = displaymember;			
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
				TJSystem.Public.PublicStatic.formName = "常用参数维护";
			}
			base.OnClosing (e);
		}
	}
}

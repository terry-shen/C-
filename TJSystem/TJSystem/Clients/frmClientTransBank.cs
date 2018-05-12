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
	public class frmClientTransBank : System.Windows.Forms.Form
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
		private TJSystem.Classes.PriTextBox priTextBox6;
		private TJSystem.Classes.PriTextBox priTextBox5;
		private TJSystem.Classes.PriTextBox priTextBox4;
		private TJSystem.Classes.PriTextBox textBox1;
		private TJSystem.Classes.PriTextBox priTextBox3;
		private System.Windows.Forms.Panel panel3;
		private TJSystem.UC.PriToolBar priToolBar1;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.DataGridTextBoxColumn bank_id;
		private System.Windows.Forms.DataGridTextBoxColumn bank_name;
		private System.Windows.Forms.DataGridTextBoxColumn account;
		private System.Windows.Forms.DataGridTextBoxColumn country;
		private System.Windows.Forms.DataGridTextBoxColumn province;
		private System.Windows.Forms.DataGridTextBoxColumn city;
		private System.Windows.Forms.DataGridTextBoxColumn postcode;
		private System.Windows.Forms.DataGridTextBoxColumn address;
		private System.Windows.Forms.DataGridTextBoxColumn swift_code;
		private System.Windows.Forms.Label label3;
		
		public static System.Windows.Forms.Form frmCurrent = null ;

		private string _table = null;
		private System.Windows.Forms.Label label5;
		private TJSystem.Classes.PriTextBox priTextBox1;
		private string _PK = null;

		public frmClientTransBank(string forward_id)
		{
			//
			// Windows 窗体设计器支持所必需的
			//
			InitializeComponent();

			

			TJSystem.Public.PublicStatic.setBackgroundImg(this.panel1,this.panel1.GetType().ToString(),"images\\bg.gif");
			TJSystem.Public.PublicStatic.setBackgroundImg(this.panel2,this.panel1.GetType().ToString(),"");
			TJSystem.Public.PublicStatic.setBackgroundImg(this.panel3,this.panel1.GetType().ToString(),"");
			TJSystem.Public.PublicStatic.setBackgroundImg(this.panel4,this.panel1.GetType().ToString(),"");

			this.priTextBox1.Text = forward_id;
			System.Text.StringBuilder sb = new System.Text.StringBuilder();
			sb.Append("select forward_id,bank_id,bank_name,account,country,province,city,postcode,address,swift_code ");
			sb.Append("from basic_forwarder_bank ");
			sb.Append("where forward_id='");
			sb.Append(forward_id);
			sb.Append("' order by bank_id");
			this.InitialGrid(sb.ToString());
			//			this.textBox1.DataField = "PNO";
			priToolBar1.setCurrentForm = this;
			_table = "basic_forwarder_bank";
			_PK = "forward_id,bank_id";
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
				this.textBox1.Enabled = true;
				
				this.priTextBox12.Enabled = true;
				this.priTextBox13.Enabled = true;
				this.priTextBox3.Enabled = true;
				this.priTextBox4.Enabled = true;
				this.priTextBox5.Enabled = true;
				this.priTextBox6.Enabled = true;
				this.priTextBox7.Enabled = true;
				this.priTextBox9.Enabled = true;

				this.textBox1.Text = "";
				
				this.priTextBox12.Text = "";
				this.priTextBox13.Text = "";
				this.priTextBox3.Text = "";
				this.priTextBox4.Text = "";
				this.priTextBox5.Text = "";
				this.priTextBox6.Text = "";
				this.priTextBox7.Text = "";
				this.priTextBox9.Text = "";
			}
			else if(sqltype.Equals("update"))
			{
				this.textBox1.Enabled = false;
				
				this.priTextBox12.Enabled = true;
				this.priTextBox13.Enabled = true;
				this.priTextBox3.Enabled = true;
				this.priTextBox4.Enabled = true;
				this.priTextBox5.Enabled = true;
				this.priTextBox6.Enabled = true;
				this.priTextBox7.Enabled = true;
				this.priTextBox9.Enabled = true;
			}
		}

		private void InitialGrid(string sql)
		{		
			DataTable dt = TJSystem.Public.PublicStatic.db.GetDataTable(sql);
			dt.TableName = "basic_forwarder_bank";
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(frmClientTransBank));
			this.dataGridTextBoxColumn2 = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumn3 = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumn1 = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumn4 = new System.Windows.Forms.DataGridTextBoxColumn();
			this.panel2 = new System.Windows.Forms.Panel();
			this.dataGrid1 = new System.Windows.Forms.DataGrid();
			this.dataGridTableStyle1 = new System.Windows.Forms.DataGridTableStyle();
			this.bank_id = new System.Windows.Forms.DataGridTextBoxColumn();
			this.bank_name = new System.Windows.Forms.DataGridTextBoxColumn();
			this.account = new System.Windows.Forms.DataGridTextBoxColumn();
			this.country = new System.Windows.Forms.DataGridTextBoxColumn();
			this.province = new System.Windows.Forms.DataGridTextBoxColumn();
			this.city = new System.Windows.Forms.DataGridTextBoxColumn();
			this.postcode = new System.Windows.Forms.DataGridTextBoxColumn();
			this.address = new System.Windows.Forms.DataGridTextBoxColumn();
			this.swift_code = new System.Windows.Forms.DataGridTextBoxColumn();
			this.panel4 = new System.Windows.Forms.Panel();
			this.label5 = new System.Windows.Forms.Label();
			this.priTextBox1 = new TJSystem.Classes.PriTextBox();
			this.label3 = new System.Windows.Forms.Label();
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
			this.priTextBox6 = new TJSystem.Classes.PriTextBox();
			this.priTextBox5 = new TJSystem.Classes.PriTextBox();
			this.priTextBox4 = new TJSystem.Classes.PriTextBox();
			this.textBox1 = new TJSystem.Classes.PriTextBox();
			this.priTextBox3 = new TJSystem.Classes.PriTextBox();
			this.panel3 = new System.Windows.Forms.Panel();
			this.priToolBar1 = new TJSystem.UC.PriToolBar();
			this.panel1 = new System.Windows.Forms.Panel();
			this.label1 = new System.Windows.Forms.Label();
			this.panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).BeginInit();
			this.panel4.SuspendLayout();
			this.panel3.SuspendLayout();
			this.panel1.SuspendLayout();
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
			this.panel2.Location = new System.Drawing.Point(0, 48);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(584, 374);
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
			this.dataGrid1.Location = new System.Drawing.Point(0, 168);
			this.dataGrid1.Name = "dataGrid1";
			this.dataGrid1.ReadOnly = true;
			this.dataGrid1.Size = new System.Drawing.Size(576, 192);
			this.dataGrid1.TabIndex = 1;
			this.dataGrid1.TableStyles.AddRange(new System.Windows.Forms.DataGridTableStyle[] {
																								  this.dataGridTableStyle1});
			// 
			// dataGridTableStyle1
			// 
			this.dataGridTableStyle1.AllowSorting = false;
			this.dataGridTableStyle1.DataGrid = this.dataGrid1;
			this.dataGridTableStyle1.GridColumnStyles.AddRange(new System.Windows.Forms.DataGridColumnStyle[] {
																												  this.bank_id,
																												  this.bank_name,
																												  this.account,
																												  this.country,
																												  this.province,
																												  this.city,
																												  this.postcode,
																												  this.address,
																												  this.swift_code});
			this.dataGridTableStyle1.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.dataGridTableStyle1.MappingName = "basic_forwarder_bank";
			this.dataGridTableStyle1.ReadOnly = true;
			// 
			// bank_id
			// 
			this.bank_id.Format = "";
			this.bank_id.FormatInfo = null;
			this.bank_id.HeaderText = "银行编号";
			this.bank_id.MappingName = "bank_id";
			this.bank_id.NullText = "";
			this.bank_id.Width = 75;
			// 
			// bank_name
			// 
			this.bank_name.Format = "";
			this.bank_name.FormatInfo = null;
			this.bank_name.HeaderText = "银行名称";
			this.bank_name.MappingName = "bank_name";
			this.bank_name.NullText = "";
			this.bank_name.Width = 75;
			// 
			// account
			// 
			this.account.Format = "";
			this.account.FormatInfo = null;
			this.account.HeaderText = "银行账号";
			this.account.MappingName = "account";
			this.account.NullText = "";
			this.account.Width = 75;
			// 
			// country
			// 
			this.country.Format = "";
			this.country.FormatInfo = null;
			this.country.HeaderText = "国家";
			this.country.MappingName = "country";
			this.country.NullText = "";
			this.country.Width = 75;
			// 
			// province
			// 
			this.province.Format = "";
			this.province.FormatInfo = null;
			this.province.HeaderText = "省份";
			this.province.MappingName = "province";
			this.province.NullText = "";
			this.province.Width = 75;
			// 
			// city
			// 
			this.city.Format = "";
			this.city.FormatInfo = null;
			this.city.HeaderText = "城市";
			this.city.MappingName = "city";
			this.city.NullText = "";
			this.city.Width = 75;
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
			// address
			// 
			this.address.Format = "";
			this.address.FormatInfo = null;
			this.address.HeaderText = "地址";
			this.address.MappingName = "address";
			this.address.NullText = "";
			this.address.Width = 75;
			// 
			// swift_code
			// 
			this.swift_code.Format = "";
			this.swift_code.FormatInfo = null;
			this.swift_code.HeaderText = "Swift Code";
			this.swift_code.MappingName = "swift_code";
			this.swift_code.NullText = "";
			this.swift_code.Width = 75;
			// 
			// panel4
			// 
			this.panel4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel4.BackgroundImage")));
			this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.panel4.Controls.Add(this.label5);
			this.panel4.Controls.Add(this.priTextBox1);
			this.panel4.Controls.Add(this.label3);
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
			this.panel4.Controls.Add(this.priTextBox6);
			this.panel4.Controls.Add(this.priTextBox5);
			this.panel4.Controls.Add(this.priTextBox4);
			this.panel4.Controls.Add(this.textBox1);
			this.panel4.Controls.Add(this.priTextBox3);
			this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel4.Location = new System.Drawing.Point(0, 0);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(580, 168);
			this.panel4.TabIndex = 0;
			// 
			// label5
			// 
			this.label5.BackColor = System.Drawing.Color.Transparent;
			this.label5.ForeColor = System.Drawing.Color.Blue;
			this.label5.Location = new System.Drawing.Point(8, 8);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(80, 23);
			this.label5.TabIndex = 52;
			this.label5.Text = "公司代码";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// priTextBox1
			// 
			this.priTextBox1.BackColor = System.Drawing.Color.White;
			this.priTextBox1.DataField = "forward_id";
			this.priTextBox1.DataType = TJSystem.Public.DataType.String;
			this.priTextBox1.Enabled = false;
			this.priTextBox1.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.priTextBox1.ForeColor = System.Drawing.Color.Black;
			this.priTextBox1.Location = new System.Drawing.Point(96, 8);
			this.priTextBox1.Name = "priTextBox1";
			this.priTextBox1.Size = new System.Drawing.Size(168, 23);
			this.priTextBox1.TabIndex = 51;
			this.priTextBox1.Text = "";
			// 
			// label3
			// 
			this.label3.BackColor = System.Drawing.Color.Transparent;
			this.label3.Location = new System.Drawing.Point(576, 88);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(72, 23);
			this.label3.TabIndex = 30;
			this.label3.Text = "公司编号";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.label3.Visible = false;
			// 
			// label14
			// 
			this.label14.BackColor = System.Drawing.Color.Transparent;
			this.label14.Location = new System.Drawing.Point(216, 72);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(40, 23);
			this.label14.TabIndex = 28;
			this.label14.Text = "省份";
			this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label13
			// 
			this.label13.BackColor = System.Drawing.Color.Transparent;
			this.label13.Location = new System.Drawing.Point(8, 104);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(80, 23);
			this.label13.TabIndex = 27;
			this.label13.Text = "邮政编码";
			this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label12
			// 
			this.label12.BackColor = System.Drawing.Color.Transparent;
			this.label12.Location = new System.Drawing.Point(8, 40);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(80, 23);
			this.label12.TabIndex = 26;
			this.label12.Text = "银行名称";
			this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label11
			// 
			this.label11.BackColor = System.Drawing.Color.Transparent;
			this.label11.Location = new System.Drawing.Point(288, 40);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(80, 23);
			this.label11.TabIndex = 25;
			this.label11.Text = "银行账号";
			this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label10
			// 
			this.label10.BackColor = System.Drawing.Color.Transparent;
			this.label10.Location = new System.Drawing.Point(376, 72);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(64, 23);
			this.label10.TabIndex = 24;
			this.label10.Text = "市";
			this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label9
			// 
			this.label9.BackColor = System.Drawing.Color.Transparent;
			this.label9.Location = new System.Drawing.Point(288, 104);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(80, 23);
			this.label9.TabIndex = 23;
			this.label9.Text = "Swift Code";
			this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label7
			// 
			this.label7.BackColor = System.Drawing.Color.Transparent;
			this.label7.Location = new System.Drawing.Point(8, 72);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(80, 23);
			this.label7.TabIndex = 21;
			this.label7.Text = "国家";
			this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label4
			// 
			this.label4.BackColor = System.Drawing.Color.Transparent;
			this.label4.Location = new System.Drawing.Point(40, 136);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(48, 23);
			this.label4.TabIndex = 18;
			this.label4.Text = "地址";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label2
			// 
			this.label2.BackColor = System.Drawing.Color.Transparent;
			this.label2.Location = new System.Drawing.Point(288, 8);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(80, 23);
			this.label2.TabIndex = 16;
			this.label2.Text = "银行代码";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// priTextBox13
			// 
			this.priTextBox13.BackColor = System.Drawing.Color.White;
			this.priTextBox13.DataField = "country";
			this.priTextBox13.DataType = TJSystem.Public.DataType.String;
			this.priTextBox13.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.priTextBox13.ForeColor = System.Drawing.Color.Black;
			this.priTextBox13.Location = new System.Drawing.Point(96, 72);
			this.priTextBox13.Name = "priTextBox13";
			this.priTextBox13.Size = new System.Drawing.Size(104, 23);
			this.priTextBox13.TabIndex = 14;
			this.priTextBox13.Text = "";
			// 
			// priTextBox12
			// 
			this.priTextBox12.BackColor = System.Drawing.Color.White;
			this.priTextBox12.DataField = "city";
			this.priTextBox12.DataType = TJSystem.Public.DataType.String;
			this.priTextBox12.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.priTextBox12.ForeColor = System.Drawing.Color.Black;
			this.priTextBox12.Location = new System.Drawing.Point(448, 72);
			this.priTextBox12.Name = "priTextBox12";
			this.priTextBox12.Size = new System.Drawing.Size(104, 23);
			this.priTextBox12.TabIndex = 13;
			this.priTextBox12.Text = "";
			// 
			// priTextBox9
			// 
			this.priTextBox9.BackColor = System.Drawing.Color.White;
			this.priTextBox9.DataField = "swift_code";
			this.priTextBox9.DataType = TJSystem.Public.DataType.String;
			this.priTextBox9.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.priTextBox9.ForeColor = System.Drawing.Color.Black;
			this.priTextBox9.Location = new System.Drawing.Point(376, 104);
			this.priTextBox9.Name = "priTextBox9";
			this.priTextBox9.Size = new System.Drawing.Size(176, 23);
			this.priTextBox9.TabIndex = 10;
			this.priTextBox9.Text = "";
			// 
			// priTextBox7
			// 
			this.priTextBox7.BackColor = System.Drawing.Color.White;
			this.priTextBox7.DataField = "province";
			this.priTextBox7.DataType = TJSystem.Public.DataType.String;
			this.priTextBox7.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.priTextBox7.ForeColor = System.Drawing.Color.Black;
			this.priTextBox7.Location = new System.Drawing.Point(264, 72);
			this.priTextBox7.Name = "priTextBox7";
			this.priTextBox7.Size = new System.Drawing.Size(104, 23);
			this.priTextBox7.TabIndex = 8;
			this.priTextBox7.Text = "";
			// 
			// priTextBox6
			// 
			this.priTextBox6.BackColor = System.Drawing.Color.White;
			this.priTextBox6.DataField = "postcode";
			this.priTextBox6.DataType = TJSystem.Public.DataType.String;
			this.priTextBox6.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.priTextBox6.ForeColor = System.Drawing.Color.Black;
			this.priTextBox6.Location = new System.Drawing.Point(96, 104);
			this.priTextBox6.Name = "priTextBox6";
			this.priTextBox6.Size = new System.Drawing.Size(104, 23);
			this.priTextBox6.TabIndex = 7;
			this.priTextBox6.Text = "";
			// 
			// priTextBox5
			// 
			this.priTextBox5.BackColor = System.Drawing.Color.White;
			this.priTextBox5.DataField = "address";
			this.priTextBox5.DataType = TJSystem.Public.DataType.String;
			this.priTextBox5.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.priTextBox5.ForeColor = System.Drawing.Color.Black;
			this.priTextBox5.Location = new System.Drawing.Point(96, 136);
			this.priTextBox5.Name = "priTextBox5";
			this.priTextBox5.Size = new System.Drawing.Size(288, 23);
			this.priTextBox5.TabIndex = 6;
			this.priTextBox5.Text = "";
			// 
			// priTextBox4
			// 
			this.priTextBox4.BackColor = System.Drawing.Color.White;
			this.priTextBox4.DataField = "account";
			this.priTextBox4.DataType = TJSystem.Public.DataType.String;
			this.priTextBox4.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.priTextBox4.ForeColor = System.Drawing.Color.Black;
			this.priTextBox4.Location = new System.Drawing.Point(376, 40);
			this.priTextBox4.Name = "priTextBox4";
			this.priTextBox4.Size = new System.Drawing.Size(176, 23);
			this.priTextBox4.TabIndex = 5;
			this.priTextBox4.Text = "";
			// 
			// textBox1
			// 
			this.textBox1.BackColor = System.Drawing.Color.White;
			this.textBox1.DataField = "bank_id";
			this.textBox1.DataType = TJSystem.Public.DataType.String;
			this.textBox1.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.textBox1.ForeColor = System.Drawing.Color.Black;
			this.textBox1.Location = new System.Drawing.Point(376, 8);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(176, 23);
			this.textBox1.TabIndex = 1;
			this.textBox1.Text = "";
			// 
			// priTextBox3
			// 
			this.priTextBox3.BackColor = System.Drawing.Color.White;
			this.priTextBox3.DataField = "bank_name";
			this.priTextBox3.DataType = TJSystem.Public.DataType.String;
			this.priTextBox3.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.priTextBox3.ForeColor = System.Drawing.Color.Black;
			this.priTextBox3.Location = new System.Drawing.Point(96, 40);
			this.priTextBox3.Name = "priTextBox3";
			this.priTextBox3.Size = new System.Drawing.Size(168, 23);
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
			// panel1
			// 
			this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
			this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.panel1.Controls.Add(this.label1);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(584, 48);
			this.panel1.TabIndex = 7;
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label1.Font = new System.Drawing.Font("宋体", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.label1.Location = new System.Drawing.Point(0, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(580, 44);
			this.label1.TabIndex = 0;
			this.label1.Text = "供应商银行账号信息";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// frmClientTransBank
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(7, 16);
			this.BackColor = System.Drawing.SystemColors.ScrollBar;
			this.ClientSize = new System.Drawing.Size(584, 462);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel3);
			this.Controls.Add(this.panel1);
			this.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "frmClientTransBank";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "供应商管理";
			this.panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).EndInit();
			this.panel4.ResumeLayout(false);
			this.panel3.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		private void setDisable()
		{
			this.textBox1.Enabled = false;
			this.priTextBox1.Enabled = false;
			this.priTextBox12.Enabled = false;
			this.priTextBox13.Enabled = false;
			this.priTextBox3.Enabled = false;
			this.priTextBox4.Enabled = false;
			this.priTextBox5.Enabled = false;
			this.priTextBox6.Enabled = false;
			this.priTextBox7.Enabled = false;
			this.priTextBox9.Enabled = false;
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
	}
}

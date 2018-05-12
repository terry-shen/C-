using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace TJSystem.Doc
{
	/// <summary>
	/// Form1 的摘要说明。
	/// </summary>
	public class frmCustomerDoc : System.Windows.Forms.Form
	{		
		/// <summary>
		/// 必需的设计器变量。
		/// </summary>
		private System.ComponentModel.Container components = null;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Panel panel4;
		private TJSystem.Classes.PriTextBox priTextBox25;
		private TJSystem.Classes.PriTextBox priTextBox4;
		private System.Windows.Forms.Label label24;
		private TJSystem.Classes.PriTextBox priTextBox20;
		private System.Windows.Forms.Label label25;
		private TJSystem.Classes.PriTextBox priTextBox21;
		private System.Windows.Forms.Label label26;
		private System.Windows.Forms.Label label27;
		private TJSystem.Classes.PriTextBox priTextBox23;
		private System.Windows.Forms.Label label21;
		private TJSystem.Classes.PriTextBox priTextBox17;
		private System.Windows.Forms.Label label19;
		private TJSystem.Classes.PriTextBox priTextBox15;
		private TJSystem.Classes.PriTextBox priTextBox14;
		private System.Windows.Forms.Label label16;
		private System.Windows.Forms.Label label17;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.Label label13;
		private TJSystem.Classes.PriTextBox priTextBox10;
		private System.Windows.Forms.Label label12;
		private TJSystem.Classes.PriTextBox priTextBox9;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private TJSystem.Classes.PriTextBox priTextBox3;
		private System.Windows.Forms.DataGrid dataGrid1;
		private System.Windows.Forms.DataGridTableStyle dataGridTableStyle1;
		private System.Windows.Forms.Label label32;
		private System.Windows.Forms.Label label35;
		private System.Windows.Forms.Label label36;
		private System.Windows.Forms.Label label20;
		private TJSystem.Classes.PriTextBox priTextBox16;
		private TJSystem.Classes.PriTextBox priTextBox29;
		public static System.Windows.Forms.Form frmCurrent = null ;
		private string _statusType = null;
		private string _table = null;
		private string _PK = null;
		private System.Windows.Forms.Label label31;
		private System.Windows.Forms.Label label34;
		private TJSystem.Classes.PriTextBox priTextBox18;
		private TJSystem.Classes.PriTextBox priTextBox26;
		private TJSystem.Classes.PriTextBox priTextBox30;
		private System.Windows.Forms.Label label41;
		private System.Windows.Forms.Label label42;
		private TJSystem.Classes.PriTextBox priTextBox33;
		private System.Windows.Forms.Label label43;
		private System.Windows.Forms.Label label44;
		private TJSystem.Classes.PriTextBox priTextBox35;
		private System.Windows.Forms.Label label45;
		private TJSystem.Classes.PriTextBox priTextBox11;
		private TJSystem.Classes.PriTextBox priTextBox1;
		private System.Windows.Forms.TextBox textBox2;
		private TJSystem.Classes.PriTextBox priTextBox13;
		private System.Windows.Forms.Label label49;
		private TJSystem.Classes.PriComboBox priComboBox6;
		private TJSystem.Classes.PriTextBox priTextBox12;
		private TJSystem.Classes.PriTextBox priTextBox19;
		private TJSystem.Classes.PriTextBox priTextBox22;
		private TJSystem.Classes.PriTextBox priTextBox24;
		private TJSystem.Classes.PriTextBox priTextBox27;
		private TJSystem.Classes.PriTextBox priTextBox28;
		private System.Windows.Forms.Label label4;
		private TJSystem.Classes.PriTextBox priTextBox31;
		private System.Windows.Forms.Label label14;
		private TJSystem.Classes.PriTextBox priTextBox32;
		private TJSystem.Classes.PriTextBox priTextBox34;
		private TJSystem.Classes.PriTextBox priTextBox36;
		private System.Windows.Forms.Label label18;
		private System.Windows.Forms.Label label8;
		private TJSystem.Classes.PriTextBox priTextBox5;
		private TJSystem.Classes.XpStyleButton xpStyleButton5;
		private TJSystem.Classes.XpStyleButton button2;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.DataGridTextBoxColumn seq_no;
		private System.Windows.Forms.DataGridTextBoxColumn item_code;
		private System.Windows.Forms.DataGridTextBoxColumn item_name;
		private System.Windows.Forms.DataGridTextBoxColumn item_desc;
		private System.Windows.Forms.DataGridTextBoxColumn item_qty;
		private System.Windows.Forms.DataGridTextBoxColumn unit_name;
		private System.Windows.Forms.DataGridTextBoxColumn currency_name;
		private System.Windows.Forms.DataGridTextBoxColumn unit_price;
		private System.Windows.Forms.DataGridTextBoxColumn total_price;

		private System.Windows.Forms.Form _form = null;

		public frmCustomerDoc()
		{
			//
			// Windows 窗体设计器支持所必需的
			//
			InitializeComponent();

			TJSystem.Public.PublicStatic.setBackgroundImg(this.panel1,this.panel1.GetType().ToString(),"images\\bg.gif");
			TJSystem.Public.PublicStatic.setBackgroundImg(this.panel2,this.panel2.GetType().ToString(),"");
			TJSystem.Public.PublicStatic.setBackgroundImg(this.panel4,this.panel4.GetType().ToString(),"");

			InitialFormData();

			this.Cursor = System.Windows.Forms.Cursors.WaitCursor;
			
			setDisable();

			this.Cursor = System.Windows.Forms.Cursors.Default;
			//
			// TODO: 在 InitializeComponent 调用后添加任何构造函数代码
			//
		}

		private void InitialFormData()
		{
			DataRow dr = null;
			DataTable dt = null;
			DataTable dtcpy = null;
			string sql = null;
			
			sql = "select INVOICE_NO,INVOICE_NO+' '+CLIENT_NAME+' '+INVOICE_DATE as INVOICE_DESC from sale_doc_master order by INVOICE_NO ";
			dt = TJSystem.Public.PublicStatic.db.GetDataTable(sql);
			dr = dt.NewRow() ;
			dr[0] = "" ;
			dr[1] = "" ;
			dt.Rows.InsertAt(dr,0) ;
			dtcpy = dt.Copy();
			this.priComboBox6.DataSource = dtcpy.DefaultView;
			this.priComboBox6.ValueMember = "INVOICE_NO";
			this.priComboBox6.DisplayMember = "INVOICE_DESC";
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(frmCustomerDoc));
			this.panel1 = new System.Windows.Forms.Panel();
			this.label1 = new System.Windows.Forms.Label();
			this.panel2 = new System.Windows.Forms.Panel();
			this.panel3 = new System.Windows.Forms.Panel();
			this.xpStyleButton5 = new TJSystem.Classes.XpStyleButton();
			this.button2 = new TJSystem.Classes.XpStyleButton();
			this.panel4 = new System.Windows.Forms.Panel();
			this.label8 = new System.Windows.Forms.Label();
			this.priComboBox6 = new TJSystem.Classes.PriComboBox();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.priTextBox29 = new TJSystem.Classes.PriTextBox();
			this.label20 = new System.Windows.Forms.Label();
			this.priTextBox16 = new TJSystem.Classes.PriTextBox();
			this.label36 = new System.Windows.Forms.Label();
			this.label35 = new System.Windows.Forms.Label();
			this.label32 = new System.Windows.Forms.Label();
			this.priTextBox25 = new TJSystem.Classes.PriTextBox();
			this.priTextBox4 = new TJSystem.Classes.PriTextBox();
			this.label24 = new System.Windows.Forms.Label();
			this.priTextBox20 = new TJSystem.Classes.PriTextBox();
			this.label25 = new System.Windows.Forms.Label();
			this.priTextBox21 = new TJSystem.Classes.PriTextBox();
			this.label26 = new System.Windows.Forms.Label();
			this.label27 = new System.Windows.Forms.Label();
			this.priTextBox23 = new TJSystem.Classes.PriTextBox();
			this.label21 = new System.Windows.Forms.Label();
			this.priTextBox17 = new TJSystem.Classes.PriTextBox();
			this.label19 = new System.Windows.Forms.Label();
			this.priTextBox15 = new TJSystem.Classes.PriTextBox();
			this.priTextBox14 = new TJSystem.Classes.PriTextBox();
			this.label16 = new System.Windows.Forms.Label();
			this.label17 = new System.Windows.Forms.Label();
			this.label15 = new System.Windows.Forms.Label();
			this.priTextBox11 = new TJSystem.Classes.PriTextBox();
			this.label13 = new System.Windows.Forms.Label();
			this.priTextBox10 = new TJSystem.Classes.PriTextBox();
			this.label12 = new System.Windows.Forms.Label();
			this.priTextBox9 = new TJSystem.Classes.PriTextBox();
			this.label11 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.priTextBox3 = new TJSystem.Classes.PriTextBox();
			this.label31 = new System.Windows.Forms.Label();
			this.label34 = new System.Windows.Forms.Label();
			this.priTextBox18 = new TJSystem.Classes.PriTextBox();
			this.priTextBox26 = new TJSystem.Classes.PriTextBox();
			this.priTextBox30 = new TJSystem.Classes.PriTextBox();
			this.label41 = new System.Windows.Forms.Label();
			this.label42 = new System.Windows.Forms.Label();
			this.priTextBox33 = new TJSystem.Classes.PriTextBox();
			this.label43 = new System.Windows.Forms.Label();
			this.label44 = new System.Windows.Forms.Label();
			this.priTextBox35 = new TJSystem.Classes.PriTextBox();
			this.label45 = new System.Windows.Forms.Label();
			this.priTextBox1 = new TJSystem.Classes.PriTextBox();
			this.priTextBox13 = new TJSystem.Classes.PriTextBox();
			this.label49 = new System.Windows.Forms.Label();
			this.priTextBox12 = new TJSystem.Classes.PriTextBox();
			this.priTextBox19 = new TJSystem.Classes.PriTextBox();
			this.priTextBox22 = new TJSystem.Classes.PriTextBox();
			this.priTextBox24 = new TJSystem.Classes.PriTextBox();
			this.priTextBox27 = new TJSystem.Classes.PriTextBox();
			this.priTextBox28 = new TJSystem.Classes.PriTextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.priTextBox31 = new TJSystem.Classes.PriTextBox();
			this.label14 = new System.Windows.Forms.Label();
			this.priTextBox32 = new TJSystem.Classes.PriTextBox();
			this.priTextBox34 = new TJSystem.Classes.PriTextBox();
			this.priTextBox36 = new TJSystem.Classes.PriTextBox();
			this.label18 = new System.Windows.Forms.Label();
			this.priTextBox5 = new TJSystem.Classes.PriTextBox();
			this.dataGrid1 = new System.Windows.Forms.DataGrid();
			this.dataGridTableStyle1 = new System.Windows.Forms.DataGridTableStyle();
			this.seq_no = new System.Windows.Forms.DataGridTextBoxColumn();
			this.item_code = new System.Windows.Forms.DataGridTextBoxColumn();
			this.item_name = new System.Windows.Forms.DataGridTextBoxColumn();
			this.item_desc = new System.Windows.Forms.DataGridTextBoxColumn();
			this.item_qty = new System.Windows.Forms.DataGridTextBoxColumn();
			this.unit_name = new System.Windows.Forms.DataGridTextBoxColumn();
			this.unit_price = new System.Windows.Forms.DataGridTextBoxColumn();
			this.total_price = new System.Windows.Forms.DataGridTextBoxColumn();
			this.currency_name = new System.Windows.Forms.DataGridTextBoxColumn();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			this.panel3.SuspendLayout();
			this.panel4.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).BeginInit();
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
			this.panel1.Size = new System.Drawing.Size(792, 48);
			this.panel1.TabIndex = 3;
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
			this.label1.Text = "报关单打印";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// panel2
			// 
			this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
			this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.panel2.Controls.Add(this.panel3);
			this.panel2.Controls.Add(this.panel4);
			this.panel2.Controls.Add(this.dataGrid1);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel2.Location = new System.Drawing.Point(0, 0);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(792, 566);
			this.panel2.TabIndex = 5;
			// 
			// panel3
			// 
			this.panel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel3.BackgroundImage")));
			this.panel3.Controls.Add(this.xpStyleButton5);
			this.panel3.Controls.Add(this.button2);
			this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panel3.Location = new System.Drawing.Point(0, 514);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(788, 48);
			this.panel3.TabIndex = 13;
			// 
			// xpStyleButton5
			// 
			this.xpStyleButton5.Location = new System.Drawing.Point(120, 8);
			this.xpStyleButton5.Name = "xpStyleButton5";
			this.xpStyleButton5.Size = new System.Drawing.Size(72, 32);
			this.xpStyleButton5.TabIndex = 12;
			this.xpStyleButton5.Text = "修改";
			this.xpStyleButton5.Click += new System.EventHandler(this.xpStyleButton5_Click);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(16, 8);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(72, 32);
			this.button2.TabIndex = 11;
			this.button2.Text = "打印";
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// panel4
			// 
			this.panel4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel4.BackgroundImage")));
			this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.panel4.Controls.Add(this.label8);
			this.panel4.Controls.Add(this.priComboBox6);
			this.panel4.Controls.Add(this.textBox2);
			this.panel4.Controls.Add(this.priTextBox29);
			this.panel4.Controls.Add(this.label20);
			this.panel4.Controls.Add(this.priTextBox16);
			this.panel4.Controls.Add(this.label36);
			this.panel4.Controls.Add(this.label35);
			this.panel4.Controls.Add(this.label32);
			this.panel4.Controls.Add(this.priTextBox25);
			this.panel4.Controls.Add(this.priTextBox4);
			this.panel4.Controls.Add(this.label24);
			this.panel4.Controls.Add(this.priTextBox20);
			this.panel4.Controls.Add(this.label25);
			this.panel4.Controls.Add(this.priTextBox21);
			this.panel4.Controls.Add(this.label26);
			this.panel4.Controls.Add(this.label27);
			this.panel4.Controls.Add(this.priTextBox23);
			this.panel4.Controls.Add(this.label21);
			this.panel4.Controls.Add(this.priTextBox17);
			this.panel4.Controls.Add(this.label19);
			this.panel4.Controls.Add(this.priTextBox15);
			this.panel4.Controls.Add(this.priTextBox14);
			this.panel4.Controls.Add(this.label16);
			this.panel4.Controls.Add(this.label17);
			this.panel4.Controls.Add(this.label15);
			this.panel4.Controls.Add(this.priTextBox11);
			this.panel4.Controls.Add(this.label13);
			this.panel4.Controls.Add(this.priTextBox10);
			this.panel4.Controls.Add(this.label12);
			this.panel4.Controls.Add(this.priTextBox9);
			this.panel4.Controls.Add(this.label11);
			this.panel4.Controls.Add(this.label10);
			this.panel4.Controls.Add(this.label6);
			this.panel4.Controls.Add(this.label7);
			this.panel4.Controls.Add(this.label5);
			this.panel4.Controls.Add(this.label3);
			this.panel4.Controls.Add(this.label2);
			this.panel4.Controls.Add(this.priTextBox3);
			this.panel4.Controls.Add(this.label31);
			this.panel4.Controls.Add(this.label34);
			this.panel4.Controls.Add(this.priTextBox18);
			this.panel4.Controls.Add(this.priTextBox26);
			this.panel4.Controls.Add(this.priTextBox30);
			this.panel4.Controls.Add(this.label41);
			this.panel4.Controls.Add(this.label42);
			this.panel4.Controls.Add(this.priTextBox33);
			this.panel4.Controls.Add(this.label43);
			this.panel4.Controls.Add(this.label44);
			this.panel4.Controls.Add(this.priTextBox35);
			this.panel4.Controls.Add(this.label45);
			this.panel4.Controls.Add(this.priTextBox1);
			this.panel4.Controls.Add(this.priTextBox13);
			this.panel4.Controls.Add(this.label49);
			this.panel4.Controls.Add(this.priTextBox12);
			this.panel4.Controls.Add(this.priTextBox19);
			this.panel4.Controls.Add(this.priTextBox22);
			this.panel4.Controls.Add(this.priTextBox24);
			this.panel4.Controls.Add(this.priTextBox27);
			this.panel4.Controls.Add(this.priTextBox28);
			this.panel4.Controls.Add(this.label4);
			this.panel4.Controls.Add(this.priTextBox31);
			this.panel4.Controls.Add(this.label14);
			this.panel4.Controls.Add(this.priTextBox32);
			this.panel4.Controls.Add(this.priTextBox34);
			this.panel4.Controls.Add(this.priTextBox36);
			this.panel4.Controls.Add(this.label18);
			this.panel4.Controls.Add(this.priTextBox5);
			this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel4.Location = new System.Drawing.Point(0, 0);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(788, 384);
			this.panel4.TabIndex = 0;
			// 
			// label8
			// 
			this.label8.BackColor = System.Drawing.Color.Transparent;
			this.label8.ForeColor = System.Drawing.Color.Blue;
			this.label8.Location = new System.Drawing.Point(440, 328);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(88, 23);
			this.label8.TabIndex = 174;
			this.label8.Text = "合同协议号";
			this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// priComboBox6
			// 
			this.priComboBox6.BackColor = System.Drawing.Color.White;
			this.priComboBox6.DataField = "invoice_no";
			this.priComboBox6.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.priComboBox6.Location = new System.Drawing.Point(88, 56);
			this.priComboBox6.Name = "priComboBox6";
			this.priComboBox6.Size = new System.Drawing.Size(296, 22);
			this.priComboBox6.TabIndex = 173;
			this.priComboBox6.SelectionChangeCommitted += new System.EventHandler(this.priComboBox6_SelectionChangeCommitted);
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(480, 104);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(104, 23);
			this.textBox2.TabIndex = 167;
			this.textBox2.Text = "";
			// 
			// priTextBox29
			// 
			this.priTextBox29.BackColor = System.Drawing.Color.White;
			this.priTextBox29.DataField = "allowbatch";
			this.priTextBox29.DataType = TJSystem.Public.DataType.String;
			this.priTextBox29.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.priTextBox29.Location = new System.Drawing.Point(328, 328);
			this.priTextBox29.Name = "priTextBox29";
			this.priTextBox29.Size = new System.Drawing.Size(104, 23);
			this.priTextBox29.TabIndex = 152;
			this.priTextBox29.Text = "";
			// 
			// label20
			// 
			this.label20.AutoSize = true;
			this.label20.BackColor = System.Drawing.Color.Transparent;
			this.label20.ForeColor = System.Drawing.Color.Blue;
			this.label20.Location = new System.Drawing.Point(600, 176);
			this.label20.Name = "label20";
			this.label20.Size = new System.Drawing.Size(48, 19);
			this.label20.TabIndex = 151;
			this.label20.Text = "运  费";
			this.label20.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// priTextBox16
			// 
			this.priTextBox16.BackColor = System.Drawing.Color.White;
			this.priTextBox16.DataField = "freight";
			this.priTextBox16.DataType = TJSystem.Public.DataType.String;
			this.priTextBox16.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.priTextBox16.Location = new System.Drawing.Point(656, 176);
			this.priTextBox16.Name = "priTextBox16";
			this.priTextBox16.Size = new System.Drawing.Size(120, 23);
			this.priTextBox16.TabIndex = 150;
			this.priTextBox16.Text = "";
			// 
			// label36
			// 
			this.label36.AutoSize = true;
			this.label36.BackColor = System.Drawing.Color.Transparent;
			this.label36.ForeColor = System.Drawing.Color.Blue;
			this.label36.Location = new System.Drawing.Point(408, 104);
			this.label36.Name = "label36";
			this.label36.Size = new System.Drawing.Size(63, 19);
			this.label36.TabIndex = 149;
			this.label36.Text = "运输方式";
			this.label36.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label35
			// 
			this.label35.AutoSize = true;
			this.label35.BackColor = System.Drawing.Color.Transparent;
			this.label35.ForeColor = System.Drawing.Color.Blue;
			this.label35.Location = new System.Drawing.Point(16, 248);
			this.label35.Name = "label35";
			this.label35.Size = new System.Drawing.Size(63, 19);
			this.label35.TabIndex = 147;
			this.label35.Text = "随附单据";
			this.label35.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label32
			// 
			this.label32.AutoSize = true;
			this.label32.BackColor = System.Drawing.Color.Transparent;
			this.label32.ForeColor = System.Drawing.Color.Blue;
			this.label32.Location = new System.Drawing.Point(408, 128);
			this.label32.Name = "label32";
			this.label32.Size = new System.Drawing.Size(63, 19);
			this.label32.TabIndex = 138;
			this.label32.Text = "贸易方式";
			this.label32.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// priTextBox25
			// 
			this.priTextBox25.BackColor = System.Drawing.Color.White;
			this.priTextBox25.DataField = "putonrecordno";
			this.priTextBox25.DataType = TJSystem.Public.DataType.String;
			this.priTextBox25.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.priTextBox25.Location = new System.Drawing.Point(272, 80);
			this.priTextBox25.Name = "priTextBox25";
			this.priTextBox25.Size = new System.Drawing.Size(112, 23);
			this.priTextBox25.TabIndex = 128;
			this.priTextBox25.Text = "";
			// 
			// priTextBox4
			// 
			this.priTextBox4.BackColor = System.Drawing.Color.White;
			this.priTextBox4.DataField = "imposetaxfree";
			this.priTextBox4.DataType = TJSystem.Public.DataType.String;
			this.priTextBox4.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.priTextBox4.Location = new System.Drawing.Point(656, 128);
			this.priTextBox4.Name = "priTextBox4";
			this.priTextBox4.Size = new System.Drawing.Size(120, 23);
			this.priTextBox4.TabIndex = 127;
			this.priTextBox4.Text = "";
			// 
			// label24
			// 
			this.label24.BackColor = System.Drawing.Color.Transparent;
			this.label24.Location = new System.Drawing.Point(16, 360);
			this.label24.Name = "label24";
			this.label24.Size = new System.Drawing.Size(64, 23);
			this.label24.TabIndex = 124;
			this.label24.Text = "单位地址";
			this.label24.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// priTextBox20
			// 
			this.priTextBox20.BackColor = System.Drawing.Color.White;
			this.priTextBox20.DataField = "billloading";
			this.priTextBox20.DataType = TJSystem.Public.DataType.String;
			this.priTextBox20.Enabled = false;
			this.priTextBox20.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.priTextBox20.Location = new System.Drawing.Point(88, 352);
			this.priTextBox20.Name = "priTextBox20";
			this.priTextBox20.Size = new System.Drawing.Size(688, 23);
			this.priTextBox20.TabIndex = 123;
			this.priTextBox20.Text = "";
			// 
			// label25
			// 
			this.label25.BackColor = System.Drawing.Color.Transparent;
			this.label25.Location = new System.Drawing.Point(16, 152);
			this.label25.Name = "label25";
			this.label25.Size = new System.Drawing.Size(64, 23);
			this.label25.TabIndex = 122;
			this.label25.Text = "结汇方式";
			this.label25.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// priTextBox21
			// 
			this.priTextBox21.BackColor = System.Drawing.Color.White;
			this.priTextBox21.DataField = "shipper";
			this.priTextBox21.DataType = TJSystem.Public.DataType.String;
			this.priTextBox21.Enabled = false;
			this.priTextBox21.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.priTextBox21.Location = new System.Drawing.Point(88, 152);
			this.priTextBox21.Name = "priTextBox21";
			this.priTextBox21.Size = new System.Drawing.Size(112, 23);
			this.priTextBox21.TabIndex = 121;
			this.priTextBox21.Text = "";
			// 
			// label26
			// 
			this.label26.BackColor = System.Drawing.Color.Transparent;
			this.label26.ForeColor = System.Drawing.Color.Blue;
			this.label26.Location = new System.Drawing.Point(392, 80);
			this.label26.Name = "label26";
			this.label26.Size = new System.Drawing.Size(80, 23);
			this.label26.TabIndex = 120;
			this.label26.Text = "出口日期";
			this.label26.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label27
			// 
			this.label27.BackColor = System.Drawing.Color.Transparent;
			this.label27.Location = new System.Drawing.Point(0, 104);
			this.label27.Name = "label27";
			this.label27.Size = new System.Drawing.Size(80, 23);
			this.label27.TabIndex = 119;
			this.label27.Text = "经营单位";
			this.label27.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// priTextBox23
			// 
			this.priTextBox23.BackColor = System.Drawing.Color.White;
			this.priTextBox23.DataField = "company_name";
			this.priTextBox23.DataType = TJSystem.Public.DataType.String;
			this.priTextBox23.Enabled = false;
			this.priTextBox23.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.priTextBox23.Location = new System.Drawing.Point(88, 104);
			this.priTextBox23.Name = "priTextBox23";
			this.priTextBox23.Size = new System.Drawing.Size(296, 23);
			this.priTextBox23.TabIndex = 117;
			this.priTextBox23.Text = "";
			// 
			// label21
			// 
			this.label21.AutoSize = true;
			this.label21.BackColor = System.Drawing.Color.Transparent;
			this.label21.Location = new System.Drawing.Point(0, 176);
			this.label21.Name = "label21";
			this.label21.Size = new System.Drawing.Size(77, 19);
			this.label21.TabIndex = 41;
			this.label21.Text = "境内货源地";
			this.label21.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// priTextBox17
			// 
			this.priTextBox17.BackColor = System.Drawing.Color.White;
			this.priTextBox17.DataField = "approvedon";
			this.priTextBox17.DataType = TJSystem.Public.DataType.String;
			this.priTextBox17.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.priTextBox17.Location = new System.Drawing.Point(656, 152);
			this.priTextBox17.Name = "priTextBox17";
			this.priTextBox17.Size = new System.Drawing.Size(120, 23);
			this.priTextBox17.TabIndex = 40;
			this.priTextBox17.Text = "";
			// 
			// label19
			// 
			this.label19.BackColor = System.Drawing.Color.Transparent;
			this.label19.Location = new System.Drawing.Point(216, 176);
			this.label19.Name = "label19";
			this.label19.Size = new System.Drawing.Size(64, 23);
			this.label19.TabIndex = 39;
			this.label19.Text = "批准文号";
			this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// priTextBox15
			// 
			this.priTextBox15.BackColor = System.Drawing.Color.White;
			this.priTextBox15.DataField = "sanctifiedno";
			this.priTextBox15.DataType = TJSystem.Public.DataType.String;
			this.priTextBox15.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.priTextBox15.Location = new System.Drawing.Point(280, 128);
			this.priTextBox15.Name = "priTextBox15";
			this.priTextBox15.Size = new System.Drawing.Size(104, 23);
			this.priTextBox15.TabIndex = 38;
			this.priTextBox15.Text = "";
			// 
			// priTextBox14
			// 
			this.priTextBox14.BackColor = System.Drawing.Color.White;
			this.priTextBox14.DataField = "approvedby";
			this.priTextBox14.DataType = TJSystem.Public.DataType.String;
			this.priTextBox14.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.priTextBox14.Location = new System.Drawing.Point(480, 152);
			this.priTextBox14.Name = "priTextBox14";
			this.priTextBox14.Size = new System.Drawing.Size(104, 23);
			this.priTextBox14.TabIndex = 34;
			this.priTextBox14.Text = "";
			// 
			// label16
			// 
			this.label16.BackColor = System.Drawing.Color.Transparent;
			this.label16.ForeColor = System.Drawing.Color.Blue;
			this.label16.Location = new System.Drawing.Point(16, 80);
			this.label16.Name = "label16";
			this.label16.Size = new System.Drawing.Size(64, 23);
			this.label16.TabIndex = 33;
			this.label16.Text = "出口口岸";
			this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label17
			// 
			this.label17.AutoSize = true;
			this.label17.BackColor = System.Drawing.Color.Transparent;
			this.label17.ForeColor = System.Drawing.Color.Blue;
			this.label17.Location = new System.Drawing.Point(424, 152);
			this.label17.Name = "label17";
			this.label17.Size = new System.Drawing.Size(48, 19);
			this.label17.TabIndex = 31;
			this.label17.Text = "运抵国";
			this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label15
			// 
			this.label15.AutoSize = true;
			this.label15.BackColor = System.Drawing.Color.Transparent;
			this.label15.Location = new System.Drawing.Point(216, 152);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(63, 19);
			this.label15.TabIndex = 29;
			this.label15.Text = "许可证号";
			this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// priTextBox11
			// 
			this.priTextBox11.BackColor = System.Drawing.Color.White;
			this.priTextBox11.DataField = "licence_no";
			this.priTextBox11.DataType = TJSystem.Public.DataType.String;
			this.priTextBox11.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.priTextBox11.Location = new System.Drawing.Point(280, 152);
			this.priTextBox11.Name = "priTextBox11";
			this.priTextBox11.Size = new System.Drawing.Size(104, 23);
			this.priTextBox11.TabIndex = 28;
			this.priTextBox11.Text = "";
			// 
			// label13
			// 
			this.label13.BackColor = System.Drawing.Color.Transparent;
			this.label13.Location = new System.Drawing.Point(592, 104);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(64, 23);
			this.label13.TabIndex = 26;
			this.label13.Text = "运输工具";
			this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// priTextBox10
			// 
			this.priTextBox10.BackColor = System.Drawing.Color.White;
			this.priTextBox10.DataField = "transtools";
			this.priTextBox10.DataType = TJSystem.Public.DataType.String;
			this.priTextBox10.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.priTextBox10.Location = new System.Drawing.Point(656, 104);
			this.priTextBox10.Name = "priTextBox10";
			this.priTextBox10.Size = new System.Drawing.Size(120, 23);
			this.priTextBox10.TabIndex = 25;
			this.priTextBox10.Text = "";
			// 
			// label12
			// 
			this.label12.BackColor = System.Drawing.Color.Transparent;
			this.label12.Location = new System.Drawing.Point(8, 128);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(72, 23);
			this.label12.TabIndex = 24;
			this.label12.Text = "提运单号";
			this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// priTextBox9
			// 
			this.priTextBox9.BackColor = System.Drawing.Color.White;
			this.priTextBox9.DataField = "client_orderno";
			this.priTextBox9.DataType = TJSystem.Public.DataType.String;
			this.priTextBox9.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.priTextBox9.Location = new System.Drawing.Point(88, 128);
			this.priTextBox9.Name = "priTextBox9";
			this.priTextBox9.Size = new System.Drawing.Size(112, 23);
			this.priTextBox9.TabIndex = 23;
			this.priTextBox9.Text = "";
			// 
			// label11
			// 
			this.label11.BackColor = System.Drawing.Color.Transparent;
			this.label11.ForeColor = System.Drawing.Color.Blue;
			this.label11.Location = new System.Drawing.Point(592, 152);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(56, 23);
			this.label11.TabIndex = 22;
			this.label11.Text = "指运港";
			this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label10
			// 
			this.label10.BackColor = System.Drawing.Color.Transparent;
			this.label10.ForeColor = System.Drawing.Color.Blue;
			this.label10.Location = new System.Drawing.Point(408, 176);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(64, 23);
			this.label10.TabIndex = 20;
			this.label10.Text = "成交方式";
			this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label6
			// 
			this.label6.BackColor = System.Drawing.Color.Transparent;
			this.label6.Location = new System.Drawing.Point(200, 80);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(64, 23);
			this.label6.TabIndex = 17;
			this.label6.Text = "备案号";
			this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label7
			// 
			this.label7.BackColor = System.Drawing.Color.Transparent;
			this.label7.Location = new System.Drawing.Point(584, 128);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(72, 23);
			this.label7.TabIndex = 16;
			this.label7.Text = "征免性质";
			this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label5
			// 
			this.label5.BackColor = System.Drawing.Color.Transparent;
			this.label5.ForeColor = System.Drawing.Color.Blue;
			this.label5.Location = new System.Drawing.Point(16, 224);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(64, 23);
			this.label5.TabIndex = 9;
			this.label5.Text = "毛重";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label3
			// 
			this.label3.BackColor = System.Drawing.Color.Transparent;
			this.label3.ForeColor = System.Drawing.Color.Blue;
			this.label3.Location = new System.Drawing.Point(216, 128);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(64, 18);
			this.label3.TabIndex = 7;
			this.label3.Text = "发货单位";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label2
			// 
			this.label2.BackColor = System.Drawing.Color.Transparent;
			this.label2.ForeColor = System.Drawing.Color.Blue;
			this.label2.Location = new System.Drawing.Point(8, 56);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(72, 23);
			this.label2.TabIndex = 6;
			this.label2.Text = "发票号";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// priTextBox3
			// 
			this.priTextBox3.BackColor = System.Drawing.Color.White;
			this.priTextBox3.DataField = "role_code";
			this.priTextBox3.DataType = TJSystem.Public.DataType.String;
			this.priTextBox3.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.priTextBox3.Location = new System.Drawing.Point(88, 80);
			this.priTextBox3.Name = "priTextBox3";
			this.priTextBox3.Size = new System.Drawing.Size(104, 23);
			this.priTextBox3.TabIndex = 3;
			this.priTextBox3.Text = "";
			// 
			// label31
			// 
			this.label31.AutoSize = true;
			this.label31.BackColor = System.Drawing.Color.Transparent;
			this.label31.ForeColor = System.Drawing.Color.Blue;
			this.label31.Location = new System.Drawing.Point(592, 80);
			this.label31.Name = "label31";
			this.label31.Size = new System.Drawing.Size(63, 19);
			this.label31.TabIndex = 41;
			this.label31.Text = "申报日期";
			this.label31.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label34
			// 
			this.label34.BackColor = System.Drawing.Color.Transparent;
			this.label34.Location = new System.Drawing.Point(392, 224);
			this.label34.Name = "label34";
			this.label34.Size = new System.Drawing.Size(80, 23);
			this.label34.TabIndex = 35;
			this.label34.Text = "集装箱号";
			this.label34.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// priTextBox18
			// 
			this.priTextBox18.BackColor = System.Drawing.Color.White;
			this.priTextBox18.DataField = "lc_code";
			this.priTextBox18.DataType = TJSystem.Public.DataType.String;
			this.priTextBox18.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.priTextBox18.Location = new System.Drawing.Point(480, 224);
			this.priTextBox18.Name = "priTextBox18";
			this.priTextBox18.Size = new System.Drawing.Size(296, 23);
			this.priTextBox18.TabIndex = 34;
			this.priTextBox18.Text = "";
			// 
			// priTextBox26
			// 
			this.priTextBox26.BackColor = System.Drawing.Color.White;
			this.priTextBox26.DataField = "bank";
			this.priTextBox26.DataType = TJSystem.Public.DataType.String;
			this.priTextBox26.Enabled = false;
			this.priTextBox26.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.priTextBox26.Location = new System.Drawing.Point(88, 272);
			this.priTextBox26.Multiline = true;
			this.priTextBox26.Name = "priTextBox26";
			this.priTextBox26.Size = new System.Drawing.Size(688, 56);
			this.priTextBox26.TabIndex = 117;
			this.priTextBox26.Text = "";
			// 
			// priTextBox30
			// 
			this.priTextBox30.BackColor = System.Drawing.Color.White;
			this.priTextBox30.DataField = "validity";
			this.priTextBox30.DataType = TJSystem.Public.DataType.String;
			this.priTextBox30.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.priTextBox30.Location = new System.Drawing.Point(480, 248);
			this.priTextBox30.Name = "priTextBox30";
			this.priTextBox30.Size = new System.Drawing.Size(296, 23);
			this.priTextBox30.TabIndex = 40;
			this.priTextBox30.Text = "";
			// 
			// label41
			// 
			this.label41.AutoSize = true;
			this.label41.BackColor = System.Drawing.Color.Transparent;
			this.label41.Location = new System.Drawing.Point(408, 248);
			this.label41.Name = "label41";
			this.label41.Size = new System.Drawing.Size(63, 19);
			this.label41.TabIndex = 41;
			this.label41.Text = "生产厂家";
			this.label41.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label42
			// 
			this.label42.BackColor = System.Drawing.Color.Transparent;
			this.label42.Location = new System.Drawing.Point(408, 200);
			this.label42.Name = "label42";
			this.label42.Size = new System.Drawing.Size(64, 23);
			this.label42.TabIndex = 35;
			this.label42.Text = "件数";
			this.label42.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// priTextBox33
			// 
			this.priTextBox33.BackColor = System.Drawing.Color.White;
			this.priTextBox33.DataField = "priceterm_dest";
			this.priTextBox33.DataType = TJSystem.Public.DataType.String;
			this.priTextBox33.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.priTextBox33.Location = new System.Drawing.Point(480, 200);
			this.priTextBox33.Name = "priTextBox33";
			this.priTextBox33.Size = new System.Drawing.Size(104, 23);
			this.priTextBox33.TabIndex = 34;
			this.priTextBox33.Text = "";
			// 
			// label43
			// 
			this.label43.BackColor = System.Drawing.Color.Transparent;
			this.label43.ForeColor = System.Drawing.Color.Blue;
			this.label43.Location = new System.Drawing.Point(24, 272);
			this.label43.Name = "label43";
			this.label43.Size = new System.Drawing.Size(48, 48);
			this.label43.TabIndex = 41;
			this.label43.Text = "标记唛码及备注";
			this.label43.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label44
			// 
			this.label44.BackColor = System.Drawing.Color.Transparent;
			this.label44.ForeColor = System.Drawing.Color.Blue;
			this.label44.Location = new System.Drawing.Point(16, 328);
			this.label44.Name = "label44";
			this.label44.Size = new System.Drawing.Size(64, 23);
			this.label44.TabIndex = 119;
			this.label44.Text = "电话";
			this.label44.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// priTextBox35
			// 
			this.priTextBox35.BackColor = System.Drawing.Color.White;
			this.priTextBox35.DataField = "client_name";
			this.priTextBox35.DataType = TJSystem.Public.DataType.String;
			this.priTextBox35.Enabled = false;
			this.priTextBox35.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.priTextBox35.Location = new System.Drawing.Point(88, 328);
			this.priTextBox35.Name = "priTextBox35";
			this.priTextBox35.Size = new System.Drawing.Size(144, 23);
			this.priTextBox35.TabIndex = 117;
			this.priTextBox35.Text = "";
			// 
			// label45
			// 
			this.label45.BackColor = System.Drawing.Color.Transparent;
			this.label45.Location = new System.Drawing.Point(240, 328);
			this.label45.Name = "label45";
			this.label45.Size = new System.Drawing.Size(80, 23);
			this.label45.TabIndex = 119;
			this.label45.Text = "填表日期";
			this.label45.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// priTextBox1
			// 
			this.priTextBox1.BackColor = System.Drawing.Color.White;
			this.priTextBox1.DataField = "allowtransport";
			this.priTextBox1.DataType = TJSystem.Public.DataType.String;
			this.priTextBox1.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.priTextBox1.Location = new System.Drawing.Point(88, 248);
			this.priTextBox1.Name = "priTextBox1";
			this.priTextBox1.Size = new System.Drawing.Size(296, 23);
			this.priTextBox1.TabIndex = 25;
			this.priTextBox1.Text = "";
			// 
			// priTextBox13
			// 
			this.priTextBox13.BackColor = System.Drawing.Color.White;
			this.priTextBox13.DataField = "MaiTou";
			this.priTextBox13.DataType = TJSystem.Public.DataType.String;
			this.priTextBox13.Enabled = false;
			this.priTextBox13.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.priTextBox13.Location = new System.Drawing.Point(656, 200);
			this.priTextBox13.Name = "priTextBox13";
			this.priTextBox13.Size = new System.Drawing.Size(120, 23);
			this.priTextBox13.TabIndex = 172;
			this.priTextBox13.Text = "";
			// 
			// label49
			// 
			this.label49.BackColor = System.Drawing.Color.Transparent;
			this.label49.Location = new System.Drawing.Point(584, 200);
			this.label49.Name = "label49";
			this.label49.Size = new System.Drawing.Size(64, 23);
			this.label49.TabIndex = 171;
			this.label49.Text = "包装种类";
			this.label49.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// priTextBox12
			// 
			this.priTextBox12.BackColor = System.Drawing.Color.White;
			this.priTextBox12.DataField = "putonrecordno";
			this.priTextBox12.DataType = TJSystem.Public.DataType.String;
			this.priTextBox12.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.priTextBox12.Location = new System.Drawing.Point(480, 80);
			this.priTextBox12.Name = "priTextBox12";
			this.priTextBox12.Size = new System.Drawing.Size(104, 23);
			this.priTextBox12.TabIndex = 128;
			this.priTextBox12.Text = "";
			// 
			// priTextBox19
			// 
			this.priTextBox19.BackColor = System.Drawing.Color.White;
			this.priTextBox19.DataField = "putonrecordno";
			this.priTextBox19.DataType = TJSystem.Public.DataType.String;
			this.priTextBox19.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.priTextBox19.Location = new System.Drawing.Point(656, 80);
			this.priTextBox19.Name = "priTextBox19";
			this.priTextBox19.Size = new System.Drawing.Size(120, 23);
			this.priTextBox19.TabIndex = 128;
			this.priTextBox19.Text = "";
			// 
			// priTextBox22
			// 
			this.priTextBox22.BackColor = System.Drawing.Color.White;
			this.priTextBox22.DataField = "approvedby";
			this.priTextBox22.DataType = TJSystem.Public.DataType.String;
			this.priTextBox22.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.priTextBox22.Location = new System.Drawing.Point(480, 128);
			this.priTextBox22.Name = "priTextBox22";
			this.priTextBox22.Size = new System.Drawing.Size(104, 23);
			this.priTextBox22.TabIndex = 34;
			this.priTextBox22.Text = "";
			// 
			// priTextBox24
			// 
			this.priTextBox24.BackColor = System.Drawing.Color.White;
			this.priTextBox24.DataField = "shipper";
			this.priTextBox24.DataType = TJSystem.Public.DataType.String;
			this.priTextBox24.Enabled = false;
			this.priTextBox24.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.priTextBox24.Location = new System.Drawing.Point(88, 176);
			this.priTextBox24.Name = "priTextBox24";
			this.priTextBox24.Size = new System.Drawing.Size(112, 23);
			this.priTextBox24.TabIndex = 121;
			this.priTextBox24.Text = "";
			// 
			// priTextBox27
			// 
			this.priTextBox27.BackColor = System.Drawing.Color.White;
			this.priTextBox27.DataField = "licence_no";
			this.priTextBox27.DataType = TJSystem.Public.DataType.String;
			this.priTextBox27.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.priTextBox27.Location = new System.Drawing.Point(280, 176);
			this.priTextBox27.Name = "priTextBox27";
			this.priTextBox27.Size = new System.Drawing.Size(104, 23);
			this.priTextBox27.TabIndex = 28;
			this.priTextBox27.Text = "";
			// 
			// priTextBox28
			// 
			this.priTextBox28.BackColor = System.Drawing.Color.White;
			this.priTextBox28.DataField = "approvedby";
			this.priTextBox28.DataType = TJSystem.Public.DataType.String;
			this.priTextBox28.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.priTextBox28.Location = new System.Drawing.Point(480, 176);
			this.priTextBox28.Name = "priTextBox28";
			this.priTextBox28.Size = new System.Drawing.Size(104, 23);
			this.priTextBox28.TabIndex = 34;
			this.priTextBox28.Text = "";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.BackColor = System.Drawing.Color.Transparent;
			this.label4.ForeColor = System.Drawing.Color.Blue;
			this.label4.Location = new System.Drawing.Point(32, 200);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(48, 19);
			this.label4.TabIndex = 151;
			this.label4.Text = "保  费";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// priTextBox31
			// 
			this.priTextBox31.BackColor = System.Drawing.Color.White;
			this.priTextBox31.DataField = "freight";
			this.priTextBox31.DataType = TJSystem.Public.DataType.String;
			this.priTextBox31.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.priTextBox31.Location = new System.Drawing.Point(88, 200);
			this.priTextBox31.Name = "priTextBox31";
			this.priTextBox31.Size = new System.Drawing.Size(104, 23);
			this.priTextBox31.TabIndex = 150;
			this.priTextBox31.Text = "";
			// 
			// label14
			// 
			this.label14.AutoSize = true;
			this.label14.BackColor = System.Drawing.Color.Transparent;
			this.label14.ForeColor = System.Drawing.Color.Blue;
			this.label14.Location = new System.Drawing.Point(224, 200);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(48, 19);
			this.label14.TabIndex = 151;
			this.label14.Text = "杂  费";
			this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// priTextBox32
			// 
			this.priTextBox32.BackColor = System.Drawing.Color.White;
			this.priTextBox32.DataField = "freight";
			this.priTextBox32.DataType = TJSystem.Public.DataType.String;
			this.priTextBox32.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.priTextBox32.Location = new System.Drawing.Point(280, 200);
			this.priTextBox32.Name = "priTextBox32";
			this.priTextBox32.Size = new System.Drawing.Size(104, 23);
			this.priTextBox32.TabIndex = 150;
			this.priTextBox32.Text = "";
			// 
			// priTextBox34
			// 
			this.priTextBox34.BackColor = System.Drawing.Color.White;
			this.priTextBox34.DataField = "allowtransport";
			this.priTextBox34.DataType = TJSystem.Public.DataType.String;
			this.priTextBox34.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.priTextBox34.Location = new System.Drawing.Point(88, 224);
			this.priTextBox34.Name = "priTextBox34";
			this.priTextBox34.Size = new System.Drawing.Size(104, 23);
			this.priTextBox34.TabIndex = 25;
			this.priTextBox34.Text = "";
			// 
			// priTextBox36
			// 
			this.priTextBox36.BackColor = System.Drawing.Color.White;
			this.priTextBox36.DataField = "allowtransport";
			this.priTextBox36.DataType = TJSystem.Public.DataType.String;
			this.priTextBox36.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.priTextBox36.Location = new System.Drawing.Point(280, 224);
			this.priTextBox36.Name = "priTextBox36";
			this.priTextBox36.Size = new System.Drawing.Size(104, 23);
			this.priTextBox36.TabIndex = 25;
			this.priTextBox36.Text = "";
			// 
			// label18
			// 
			this.label18.BackColor = System.Drawing.Color.Transparent;
			this.label18.ForeColor = System.Drawing.Color.Blue;
			this.label18.Location = new System.Drawing.Point(208, 224);
			this.label18.Name = "label18";
			this.label18.Size = new System.Drawing.Size(64, 23);
			this.label18.TabIndex = 9;
			this.label18.Text = "净重";
			this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// priTextBox5
			// 
			this.priTextBox5.BackColor = System.Drawing.Color.White;
			this.priTextBox5.DataField = "client_name";
			this.priTextBox5.DataType = TJSystem.Public.DataType.String;
			this.priTextBox5.Enabled = false;
			this.priTextBox5.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.priTextBox5.Location = new System.Drawing.Point(536, 328);
			this.priTextBox5.Name = "priTextBox5";
			this.priTextBox5.Size = new System.Drawing.Size(144, 23);
			this.priTextBox5.TabIndex = 117;
			this.priTextBox5.Text = "";
			// 
			// dataGrid1
			// 
			this.dataGrid1.AllowSorting = false;
			this.dataGrid1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.dataGrid1.BackgroundColor = System.Drawing.SystemColors.Window;
			this.dataGrid1.CaptionText = "单证管理";
			this.dataGrid1.CaptionVisible = false;
			this.dataGrid1.DataMember = "";
			this.dataGrid1.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.dataGrid1.Location = new System.Drawing.Point(0, 392);
			this.dataGrid1.Name = "dataGrid1";
			this.dataGrid1.ReadOnly = true;
			this.dataGrid1.Size = new System.Drawing.Size(784, 112);
			this.dataGrid1.TabIndex = 0;
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
																												  this.item_desc,
																												  this.item_qty,
																												  this.unit_name,
																												  this.unit_price,
																												  this.total_price,
																												  this.currency_name});
			this.dataGridTableStyle1.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.dataGridTableStyle1.MappingName = "SALE_DETAIL";
			this.dataGridTableStyle1.ReadOnly = true;
			// 
			// seq_no
			// 
			this.seq_no.Format = "";
			this.seq_no.FormatInfo = null;
			this.seq_no.HeaderText = "项号";
			this.seq_no.MappingName = "seq_no";
			this.seq_no.NullText = "";
			this.seq_no.Width = 75;
			// 
			// item_code
			// 
			this.item_code.Format = "";
			this.item_code.FormatInfo = null;
			this.item_code.HeaderText = "商品编号";
			this.item_code.MappingName = "item_code";
			this.item_code.NullText = "";
			this.item_code.Width = 75;
			// 
			// item_name
			// 
			this.item_name.Format = "";
			this.item_name.FormatInfo = null;
			this.item_name.HeaderText = "商品名称";
			this.item_name.MappingName = "item_name";
			this.item_name.NullText = "";
			this.item_name.Width = 75;
			// 
			// item_desc
			// 
			this.item_desc.Format = "";
			this.item_desc.FormatInfo = null;
			this.item_desc.HeaderText = "商品规格";
			this.item_desc.MappingName = "item_desc";
			this.item_desc.NullText = "";
			this.item_desc.Width = 75;
			// 
			// item_qty
			// 
			this.item_qty.Format = "";
			this.item_qty.FormatInfo = null;
			this.item_qty.HeaderText = "数量";
			this.item_qty.MappingName = "item_qty";
			this.item_qty.NullText = "";
			this.item_qty.Width = 75;
			// 
			// unit_name
			// 
			this.unit_name.Format = "";
			this.unit_name.FormatInfo = null;
			this.unit_name.HeaderText = "单位";
			this.unit_name.MappingName = "unit_name";
			this.unit_name.NullText = "";
			this.unit_name.Width = 75;
			// 
			// unit_price
			// 
			this.unit_price.Format = "";
			this.unit_price.FormatInfo = null;
			this.unit_price.HeaderText = "单价";
			this.unit_price.MappingName = "unit_price";
			this.unit_price.NullText = "";
			this.unit_price.Width = 75;
			// 
			// total_price
			// 
			this.total_price.Format = "";
			this.total_price.FormatInfo = null;
			this.total_price.HeaderText = "总价";
			this.total_price.MappingName = "total_price";
			this.total_price.NullText = "";
			this.total_price.Width = 75;
			// 
			// currency_name
			// 
			this.currency_name.Format = "";
			this.currency_name.FormatInfo = null;
			this.currency_name.HeaderText = "币种";
			this.currency_name.MappingName = "currency_name";
			this.currency_name.NullText = "";
			this.currency_name.Width = 75;
			// 
			// frmCustomerDoc
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(7, 16);
			this.BackColor = System.Drawing.SystemColors.ScrollBar;
			this.ClientSize = new System.Drawing.Size(792, 566);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.panel2);
			this.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "frmCustomerDoc";
			this.Text = "报关单管理";
			this.panel1.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			this.panel3.ResumeLayout(false);
			this.panel4.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		
		private void setDisable()
		{
			this.textBox2.Enabled = false;
			this.priTextBox1.Enabled = false;
			this.priTextBox3.Enabled = false;
			this.priTextBox4.Enabled = false;
			this.priTextBox5.Enabled = false;
			this.priTextBox9.Enabled = false;

			this.priTextBox10.Enabled = false;
			this.priTextBox11.Enabled = false;
			this.priTextBox12.Enabled = false;
			this.priTextBox13.Enabled = false;
			this.priTextBox14.Enabled = false;
			this.priTextBox15.Enabled = false;
			this.priTextBox16.Enabled = false;
			this.priTextBox17.Enabled = false;
			this.priTextBox18.Enabled = false;
			this.priTextBox19.Enabled = false;
				
			this.priTextBox20.Enabled = false;
			this.priTextBox21.Enabled = false;
			this.priTextBox22.Enabled = false;
			this.priTextBox23.Enabled = false;
			this.priTextBox25.Enabled = false;
			this.priTextBox26.Enabled = false;
			this.priTextBox27.Enabled = false;
			this.priTextBox28.Enabled = false;
			this.priTextBox29.Enabled = false;
				
			this.priTextBox30.Enabled = false;
			this.priTextBox31.Enabled = false;
			this.priTextBox32.Enabled = false;
			this.priTextBox33.Enabled = false;
			this.priTextBox34.Enabled = false;
			this.priTextBox35.Enabled = false;
			this.priTextBox36.Enabled = false;
		}

		private void setTextBoxValueDefault()
		{
			this.textBox2.Text = "" ;
			this.priTextBox1.Text = "";
			this.priTextBox3.Text = "";
			this.priTextBox4.Text = "";
			this.priTextBox5.Text = "";
			this.priTextBox9.Text = "";

			this.priTextBox10.Text = "";
			this.priTextBox11.Text = "";
			this.priTextBox12.Text = "";
			this.priTextBox13.Text = "";
			this.priTextBox14.Text = "";
			this.priTextBox15.Text = "";
			this.priTextBox16.Text = "";
			this.priTextBox17.Text = "";
			this.priTextBox18.Text = "";
			this.priTextBox19.Text = "";
				
			this.priTextBox20.Text = "";
			this.priTextBox21.Text = "";
			this.priTextBox22.Text = "";
			this.priTextBox23.Text = "";
			this.priTextBox25.Text = "";
			this.priTextBox26.Text = "";
			this.priTextBox27.Text = "";
			this.priTextBox28.Text = "";
			this.priTextBox29.Text = "";
				
			this.priTextBox30.Text = "";
			this.priTextBox31.Text = "";
			this.priTextBox32.Text = "";
			this.priTextBox33.Text = "";
			this.priTextBox34.Text = "";
			this.priTextBox35.Text = "";
			this.priTextBox36.Text = "";
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
				TJSystem.Public.PublicStatic.formName = "报关单管理";
			}
			base.OnClosing (e);
		}

		private void xpStyleButton5_Click(object sender, System.EventArgs e)
		{
			if(xpStyleButton5.Text.Equals("锁定"))
			{
				if(MessageBox.Show("确定修改内容不再修改了？（Y/N）","确认",MessageBoxButtons.YesNo,MessageBoxIcon.Question)
					== System.Windows.Forms.DialogResult.No)
				{
					return;
				}

				this.setDisable();
				xpStyleButton5.Text = "修改";
				return;
			}
			
			this.textBox2.Enabled = true;
			this.priTextBox1.Enabled = true;
			this.priTextBox3.Enabled = true;
			this.priTextBox4.Enabled = true;
			this.priTextBox5.Enabled = true;
			this.priTextBox9.Enabled = true;

			this.priTextBox10.Enabled = true;
			this.priTextBox11.Enabled = true;
			this.priTextBox12.Enabled = true;
			this.priTextBox13.Enabled = true;
			this.priTextBox14.Enabled = true;
			this.priTextBox15.Enabled = true;
			this.priTextBox16.Enabled = true;
			this.priTextBox17.Enabled = true;
			this.priTextBox18.Enabled = true;
			this.priTextBox19.Enabled = true;
				
			this.priTextBox20.Enabled = true;
			this.priTextBox21.Enabled = true;
			this.priTextBox22.Enabled = true;
			this.priTextBox23.Enabled = true;
			this.priTextBox25.Enabled = true;
			this.priTextBox26.Enabled = true;
			this.priTextBox27.Enabled = true;
			this.priTextBox28.Enabled = true;
			this.priTextBox29.Enabled = true;
				
			this.priTextBox30.Enabled = true;
			this.priTextBox31.Enabled = true;
			this.priTextBox32.Enabled = true;
			this.priTextBox33.Enabled = true;
			this.priTextBox34.Enabled = true;
			this.priTextBox35.Enabled = true;
			this.priTextBox36.Enabled = true;

			xpStyleButton5.Text = "锁定";
		}

		private void button2_Click(object sender, System.EventArgs e)
		{
			if(xpStyleButton5.Text.Equals("锁定"))
			{
				TJSystem.Public.PublicStatic.ShowMessage(TJSystem.Public.MessageType.Exclamation,"请确认修改内容并将所有控件设为锁定状态！");
				return;
			}
		}

		private void priComboBox6_SelectionChangeCommitted(object sender, System.EventArgs e)
		{
			DataTable dt = null;
			System.Text.StringBuilder sb = new System.Text.StringBuilder();
			string strtmp = null;
			if(this.priComboBox6.SelectedValue.ToString().Equals(""))
			{
				setTextBoxValueDefault();
				return;
			}

			sb.Append("select a.port_departure,a.putonrecordno,a.exportdate,a.declaredate,a.transtype,transtools,billloading,a.trade_character,");
			sb.Append(" a.settlementtype,a.priceterm,a.licence_no,arrivecountry,destport,a.so_code,");
			sb.Append(" b.port_name as port_departure_name,c.port_name as destport_name,d.country_name as arrivecountry_name,");
			sb.Append(" e.trade_desc as trade_character_name,g.paymode_name as settlementtype_name,f.term_name as priceterm_name,");
			sb.Append(" h.trans_name as transtype_name");
			sb.Append(" from sale_doc_master a");
			sb.Append(" left join p_port b on a.port_departure=b.port_code");
			sb.Append(" left join p_port c on a.destport=c.port_code");
			sb.Append(" left join p_country d on a.arrivecountry=d.country_code");
			sb.Append(" left join p_tradechar e on a.trade_character=e.trade_id");
			sb.Append(" left join p_priceterm f on a.priceterm=f.term_code");
			sb.Append(" left join p_paymode g on a.settlementtype=g.paymode_id");
			sb.Append(" left join p_transtype h on a.transtype=h.trans_code");

			sb.Append(" where a.invoice_no =");
			sb.Append("'");
			sb.Append(this.priComboBox6.SelectedValue.ToString());
			sb.Append("'");

			dt = TJSystem.Public.PublicStatic.db.GetDataTable(sb.ToString());
			if(dt.Rows.Count != 1)
			{
				TJSystem.Public.PublicStatic.ShowMessage(TJSystem.Public.MessageType.Error,"严重错误，请联系软件开发者 - 发票号不唯一！");
				return;
			}

			priTextBox3.Text = dt.Rows[0]["port_departure_name"].ToString();
			priTextBox25.Text = dt.Rows[0]["putonrecordno"].ToString();
			priTextBox12.Text = dt.Rows[0]["exportdate"].ToString();
			priTextBox19.Text = dt.Rows[0]["declaredate"].ToString();
			textBox2.Text = dt.Rows[0]["transtype"].ToString();
			priTextBox10.Text = dt.Rows[0]["transtools"].ToString();
			priTextBox9.Text = dt.Rows[0]["billloading"].ToString();
			priTextBox22.Text = dt.Rows[0]["trade_character_name"].ToString();
			priTextBox21.Text = dt.Rows[0]["settlementtype_name"].ToString();
			priTextBox11.Text = dt.Rows[0]["licence_no"].ToString();
			priTextBox14.Text = dt.Rows[0]["arrivecountry_name"].ToString();
			priTextBox17.Text = dt.Rows[0]["destport_name"].ToString();
			priTextBox5.Text = dt.Rows[0]["so_code"].ToString();
			priTextBox28.Text = dt.Rows[0]["transtype_name"].ToString();

			strtmp = TJSystem.Public.PublicStatic.CombineStringForSqlCondition(priTextBox5.Text.Split(','));
			sb.Remove(0,sb.ToString().Length);
			sb.Append("select a.seq_no,a.item_code,a.item_name,a.item_desc,a.item_qty,a.unit,a.unit_price,b.currency,");
			sb.Append(" c.unit_name,d.currency_name,a.unit_price*a.item_qty as total_price");
			sb.Append(" from sale_so_detail a");
			sb.Append(" left join basic_item b on a.item_code=b.item_code");
			sb.Append(" left join p_unit c on a.unit=c.unit_id");
			sb.Append(" left join p_currency d on b.currency=d.currency_code");

			sb.Append(" where a.so_code in (");
			sb.Append(strtmp);
			sb.Append(")");
			sb.Append(" order by a.so_code,a.seq_no");
			dt = TJSystem.Public.PublicStatic.db.GetDataTable(sb.ToString());
			dt.TableName = "SALE_DETAIL";
			this.dataGrid1.DataSource = dt.DefaultView;
			
		}

		
//		private void linkLabel7_LinkClicked(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
//		{
//			System.Text.StringBuilder sb = new System.Text.StringBuilder();
//			string strsol = null;
//			
//			if(this.textBox1.Text.Trim().Equals(""))
//			{
//				TJSystem.Public.PublicStatic.ShowMessage(TJSystem.Public.MessageType.Exclamation,"请选择要生成发票的单证号！");
//				return;
//			}
//			TJSystem.Classes.common.DocParamCommon dpcom = new TJSystem.Classes.common.DocParamCommon();
//			dpcom.DocNO = this.textBox1.Text ;
//			dpcom.DocDate = this.priDateTimePicker3.Value.ToString();
//			dpcom.DocSaleNO = this.priTextBox5.Text;
//			string [] strsolist = dpcom.DocSaleNO.Split(',');
//			for(int i = 0; i < strsolist.Length; i ++)
//			{
//				sb.Append("'");
//				sb.Append(strsolist[i]);
//				sb.Append("'");
//				sb.Append(",");
//			}
//			strsol = sb.ToString().Substring(0,sb.ToString().Length - 1);
//
//			dpcom.DocLCNO = this.priTextBox3.Text ;
//			if(this.comboBox1.SelectedValue.ToString().Equals(""))
//			{
//				dpcom.DocPOE = this.comboBox1.SelectedValue.ToString();
//			}
//			else
//			{
//				dpcom.DocPOE = this.comboBox1.Text.Replace(this.comboBox1.SelectedValue.ToString(),"").Trim();
//			}
//			if(this.comboBox1.SelectedValue.ToString().Equals(""))
//			{
//				dpcom.DocPOD = this.priComboBox8.SelectedValue.ToString();
//			}
//			else
//			{
//				dpcom.DocPOD = this.priComboBox8.Text.Replace(this.priComboBox8.SelectedValue.ToString(),"").Trim();
//			}
//			dpcom.DocSaleTo = this.priTextBox35.Text;
//			dpcom.PKCondition = "where so_code in (" + strsol + ")";
//			TJSystem.CrystalRPT.frmReport frm = new TJSystem.CrystalRPT.frmReport("发票",dpcom);
//			frm.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
//			frm.Show();
//		}		
	}
}

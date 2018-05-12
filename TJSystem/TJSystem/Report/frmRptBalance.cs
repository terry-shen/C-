using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace TJSystem.Report
{
	/// <summary>
	/// frmRptBalance 的摘要说明。
	/// </summary>
	public class frmRptBalance : System.Windows.Forms.Form
	{
		/// <summary>
		/// 必需的设计器变量。
		/// </summary>
		private System.ComponentModel.Container components = null;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label12;
		private TJSystem.Classes.PriTextBox txt3;
		private System.Windows.Forms.Label label1;
		private TJSystem.Classes.PriTextBox priTextBox1;
		private System.Windows.Forms.Label label3;
		private TJSystem.Classes.PriTextBox priTextBox2;
		private System.Windows.Forms.Label label4;
		private TJSystem.Classes.PriTextBox priTextBox3;
		private System.Windows.Forms.Label label5;
		private TJSystem.Classes.PriTextBox priTextBox4;
		private System.Windows.Forms.Label label6;
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
		private TJSystem.Classes.PriTextBox priTextBox10;
		private System.Windows.Forms.Label label13;
		private TJSystem.Classes.PriTextBox priTextBox11;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Label label15;
		private TJSystem.Classes.PriTextBox priTextBox13;
		private System.Windows.Forms.Label label16;
		private TJSystem.Classes.PriTextBox priTextBox14;
		private System.Windows.Forms.Label label17;
		private TJSystem.Classes.PriTextBox priTextBox15;
		private System.Windows.Forms.Label label25;
		private TJSystem.Classes.PriTextBox priTextBox23;
		private System.Windows.Forms.Label label26;
		private TJSystem.Classes.PriTextBox priTextBox24;
		private TJSystem.Classes.PriTextBox priTextBox25;
		private System.Windows.Forms.Label label27;
		private TJSystem.Classes.PriTextBox priTextBox26;
		private System.Windows.Forms.Label label28;
		private TJSystem.Classes.PriTextBox priTextBox27;
		private System.Windows.Forms.Label label29;
		private TJSystem.Classes.PriTextBox priTextBox28;
		private System.Windows.Forms.Label label30;
		private TJSystem.Classes.PriTextBox priTextBox29;
		private System.Windows.Forms.Label label31;
		private System.Windows.Forms.GroupBox groupBox3;
		private TJSystem.Classes.PriTextBox priTextBox33;
		private TJSystem.Classes.PriTextBox priTextBox34;
		private System.Windows.Forms.GroupBox groupBox4;
		private TJSystem.Classes.XpStyleButton button1;
		private TJSystem.Classes.XpStyleButton xpStyleButton1;
		private System.Windows.Forms.Label label37;
		private System.Windows.Forms.Label label38;
		private System.Windows.Forms.GroupBox groupBox5;
		private System.Windows.Forms.Label label34;
		private TJSystem.Classes.PriTextBox priTextBox32;
		private TJSystem.Classes.PriTextBox priTextBox12;
		private System.Windows.Forms.Label label14;
		private TJSystem.Classes.PriTextBox priTextBox16;
		private System.Windows.Forms.Label label18;
		private TJSystem.Classes.PriTextBox priTextBox17;
		private System.Windows.Forms.Label label19;
		private TJSystem.Classes.PriTextBox priTextBox18;
		private System.Windows.Forms.Label label20;
		private TJSystem.Classes.PriTextBox priTextBox19;
		private System.Windows.Forms.Label label21;
		private TJSystem.Classes.PriTextBox priTextBox20;
		private System.Windows.Forms.Label label22;
		private TJSystem.Classes.PriTextBox priTextBox21;
		private System.Windows.Forms.Label label23;
		private TJSystem.Classes.PriTextBox priTextBox22;
		private System.Windows.Forms.Label label24;
		private TJSystem.Classes.PriTextBox priTextBox30;
		private System.Windows.Forms.Label label33;
		private System.Windows.Forms.GroupBox groupBox6;
		private System.Windows.Forms.Label label35;
		private TJSystem.Classes.PriComboBox priComboBox1;
		public static System.Windows.Forms.Form frmCurrent = null;
		private TJSystem.Classes.common.DocParamCommon dpcom = null;

		public frmRptBalance()
		{
			//
			// Windows 窗体设计器支持所必需的
			//
			InitializeComponent();

			this.BackgroundImage = Image.FromFile("images\\bg.jpg");
			this.groupBox1.BackgroundImage = Image.FromFile("images\\bg.jpg");
			this.groupBox2.BackgroundImage = Image.FromFile("images\\bg.jpg");
			this.groupBox3.BackgroundImage = Image.FromFile("images\\bg.jpg");
			this.groupBox4.BackgroundImage = Image.FromFile("images\\bg.jpg");
			this.groupBox5.BackgroundImage = Image.FromFile("images\\bg.jpg");
			this.groupBox6.BackgroundImage = Image.FromFile("images\\bg.jpg");
			
			
			InitialFormData();

			//
			// TODO: 在 InitializeComponent 调用后添加任何构造函数代码
			//
		}

		/// <summary>
		/// 清理所有正在使用的资源。
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

		private void InitialFormData()
		{
			DataTable dtcpy = null;
			DataRow dr = null;
			//状态
			string sql = null;
			sql = "select SO_CODE from sale_so_master order by so_date desc ";
			DataTable dt = TJSystem.Public.PublicStatic.db.GetDataTable(sql);
			dr = dt.NewRow() ;
			dr[0] = "" ;			
			dt.Rows.InsertAt(dr,0) ;
			dtcpy = dt.Copy();
			this.priComboBox1.DataSource = dtcpy.DefaultView;
			this.priComboBox1.ValueMember = "SO_CODE";
			this.priComboBox1.DisplayMember = "SO_CODE";
		}

		#region Windows 窗体设计器生成的代码
		/// <summary>
		/// 设计器支持所需的方法 - 不要使用代码编辑器修改
		/// 此方法的内容。
		/// </summary>
		private void InitializeComponent()
		{
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.label13 = new System.Windows.Forms.Label();
			this.priTextBox11 = new TJSystem.Classes.PriTextBox();
			this.label11 = new System.Windows.Forms.Label();
			this.priTextBox10 = new TJSystem.Classes.PriTextBox();
			this.label10 = new System.Windows.Forms.Label();
			this.priTextBox9 = new TJSystem.Classes.PriTextBox();
			this.label9 = new System.Windows.Forms.Label();
			this.priTextBox8 = new TJSystem.Classes.PriTextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.priTextBox7 = new TJSystem.Classes.PriTextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.priTextBox6 = new TJSystem.Classes.PriTextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.priTextBox5 = new TJSystem.Classes.PriTextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.priTextBox4 = new TJSystem.Classes.PriTextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.priTextBox3 = new TJSystem.Classes.PriTextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.priTextBox2 = new TJSystem.Classes.PriTextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.priTextBox1 = new TJSystem.Classes.PriTextBox();
			this.label12 = new System.Windows.Forms.Label();
			this.txt3 = new TJSystem.Classes.PriTextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.priComboBox1 = new TJSystem.Classes.PriComboBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.priTextBox25 = new TJSystem.Classes.PriTextBox();
			this.label27 = new System.Windows.Forms.Label();
			this.priTextBox26 = new TJSystem.Classes.PriTextBox();
			this.label28 = new System.Windows.Forms.Label();
			this.priTextBox27 = new TJSystem.Classes.PriTextBox();
			this.label29 = new System.Windows.Forms.Label();
			this.priTextBox28 = new TJSystem.Classes.PriTextBox();
			this.label30 = new System.Windows.Forms.Label();
			this.priTextBox29 = new TJSystem.Classes.PriTextBox();
			this.label31 = new System.Windows.Forms.Label();
			this.priTextBox24 = new TJSystem.Classes.PriTextBox();
			this.label15 = new System.Windows.Forms.Label();
			this.priTextBox13 = new TJSystem.Classes.PriTextBox();
			this.label16 = new System.Windows.Forms.Label();
			this.priTextBox14 = new TJSystem.Classes.PriTextBox();
			this.label17 = new System.Windows.Forms.Label();
			this.priTextBox15 = new TJSystem.Classes.PriTextBox();
			this.label25 = new System.Windows.Forms.Label();
			this.priTextBox23 = new TJSystem.Classes.PriTextBox();
			this.label26 = new System.Windows.Forms.Label();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.label38 = new System.Windows.Forms.Label();
			this.label37 = new System.Windows.Forms.Label();
			this.priTextBox34 = new TJSystem.Classes.PriTextBox();
			this.priTextBox33 = new TJSystem.Classes.PriTextBox();
			this.groupBox4 = new System.Windows.Forms.GroupBox();
			this.xpStyleButton1 = new TJSystem.Classes.XpStyleButton();
			this.button1 = new TJSystem.Classes.XpStyleButton();
			this.groupBox5 = new System.Windows.Forms.GroupBox();
			this.label34 = new System.Windows.Forms.Label();
			this.priTextBox32 = new TJSystem.Classes.PriTextBox();
			this.priTextBox12 = new TJSystem.Classes.PriTextBox();
			this.label14 = new System.Windows.Forms.Label();
			this.priTextBox16 = new TJSystem.Classes.PriTextBox();
			this.label18 = new System.Windows.Forms.Label();
			this.priTextBox17 = new TJSystem.Classes.PriTextBox();
			this.label19 = new System.Windows.Forms.Label();
			this.priTextBox18 = new TJSystem.Classes.PriTextBox();
			this.label20 = new System.Windows.Forms.Label();
			this.priTextBox19 = new TJSystem.Classes.PriTextBox();
			this.label21 = new System.Windows.Forms.Label();
			this.priTextBox20 = new TJSystem.Classes.PriTextBox();
			this.label22 = new System.Windows.Forms.Label();
			this.priTextBox21 = new TJSystem.Classes.PriTextBox();
			this.label23 = new System.Windows.Forms.Label();
			this.priTextBox22 = new TJSystem.Classes.PriTextBox();
			this.label24 = new System.Windows.Forms.Label();
			this.priTextBox30 = new TJSystem.Classes.PriTextBox();
			this.label33 = new System.Windows.Forms.Label();
			this.groupBox6 = new System.Windows.Forms.GroupBox();
			this.label35 = new System.Windows.Forms.Label();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.groupBox3.SuspendLayout();
			this.groupBox4.SuspendLayout();
			this.groupBox5.SuspendLayout();
			this.groupBox6.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.label13);
			this.groupBox1.Controls.Add(this.priTextBox11);
			this.groupBox1.Controls.Add(this.label11);
			this.groupBox1.Controls.Add(this.priTextBox10);
			this.groupBox1.Controls.Add(this.label10);
			this.groupBox1.Controls.Add(this.priTextBox9);
			this.groupBox1.Controls.Add(this.label9);
			this.groupBox1.Controls.Add(this.priTextBox8);
			this.groupBox1.Controls.Add(this.label8);
			this.groupBox1.Controls.Add(this.priTextBox7);
			this.groupBox1.Controls.Add(this.label7);
			this.groupBox1.Controls.Add(this.priTextBox6);
			this.groupBox1.Controls.Add(this.label6);
			this.groupBox1.Controls.Add(this.priTextBox5);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.priTextBox4);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.priTextBox3);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.priTextBox2);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.priTextBox1);
			this.groupBox1.Controls.Add(this.label12);
			this.groupBox1.Controls.Add(this.txt3);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.priComboBox1);
			this.groupBox1.Font = new System.Drawing.Font("宋体", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.groupBox1.Location = new System.Drawing.Point(8, 64);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(768, 176);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			// 
			// label13
			// 
			this.label13.BackColor = System.Drawing.Color.Transparent;
			this.label13.Font = new System.Drawing.Font("宋体", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.label13.Location = new System.Drawing.Point(256, 120);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(48, 23);
			this.label13.TabIndex = 244;
			this.label13.Text = "业务员";
			this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// priTextBox11
			// 
			this.priTextBox11.BackColor = System.Drawing.Color.White;
			this.priTextBox11.DataField = "deliveryDate";
			this.priTextBox11.DataType = TJSystem.Public.DataType.String;
			this.priTextBox11.Enabled = false;
			this.priTextBox11.Font = new System.Drawing.Font("宋体", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.priTextBox11.Location = new System.Drawing.Point(312, 120);
			this.priTextBox11.Name = "priTextBox11";
			this.priTextBox11.Size = new System.Drawing.Size(120, 22);
			this.priTextBox11.TabIndex = 245;
			this.priTextBox11.Text = "";
			// 
			// label11
			// 
			this.label11.BackColor = System.Drawing.Color.Transparent;
			this.label11.Font = new System.Drawing.Font("宋体", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.label11.Location = new System.Drawing.Point(24, 120);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(80, 23);
			this.label11.TabIndex = 242;
			this.label11.Text = "收汇方式";
			this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// priTextBox10
			// 
			this.priTextBox10.BackColor = System.Drawing.Color.White;
			this.priTextBox10.DataField = "deliveryDate";
			this.priTextBox10.DataType = TJSystem.Public.DataType.String;
			this.priTextBox10.Enabled = false;
			this.priTextBox10.Font = new System.Drawing.Font("宋体", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.priTextBox10.Location = new System.Drawing.Point(112, 120);
			this.priTextBox10.Name = "priTextBox10";
			this.priTextBox10.Size = new System.Drawing.Size(120, 22);
			this.priTextBox10.TabIndex = 243;
			this.priTextBox10.Text = "";
			// 
			// label10
			// 
			this.label10.BackColor = System.Drawing.Color.Transparent;
			this.label10.Font = new System.Drawing.Font("宋体", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.label10.Location = new System.Drawing.Point(32, 96);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(72, 23);
			this.label10.TabIndex = 240;
			this.label10.Text = "客户名称";
			this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// priTextBox9
			// 
			this.priTextBox9.BackColor = System.Drawing.Color.White;
			this.priTextBox9.DataField = "deliveryDate";
			this.priTextBox9.DataType = TJSystem.Public.DataType.String;
			this.priTextBox9.Enabled = false;
			this.priTextBox9.Font = new System.Drawing.Font("宋体", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.priTextBox9.Location = new System.Drawing.Point(112, 96);
			this.priTextBox9.Name = "priTextBox9";
			this.priTextBox9.Size = new System.Drawing.Size(120, 22);
			this.priTextBox9.TabIndex = 241;
			this.priTextBox9.Text = "";
			// 
			// label9
			// 
			this.label9.BackColor = System.Drawing.Color.Transparent;
			this.label9.Font = new System.Drawing.Font("宋体", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.label9.Location = new System.Drawing.Point(32, 72);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(72, 23);
			this.label9.TabIndex = 238;
			this.label9.Text = "商品名称";
			this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// priTextBox8
			// 
			this.priTextBox8.BackColor = System.Drawing.Color.White;
			this.priTextBox8.DataField = "deliveryDate";
			this.priTextBox8.DataType = TJSystem.Public.DataType.String;
			this.priTextBox8.Enabled = false;
			this.priTextBox8.Font = new System.Drawing.Font("宋体", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.priTextBox8.Location = new System.Drawing.Point(112, 72);
			this.priTextBox8.Name = "priTextBox8";
			this.priTextBox8.Size = new System.Drawing.Size(120, 22);
			this.priTextBox8.TabIndex = 239;
			this.priTextBox8.Text = "";
			// 
			// label8
			// 
			this.label8.BackColor = System.Drawing.Color.Transparent;
			this.label8.Font = new System.Drawing.Font("宋体", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.label8.Location = new System.Drawing.Point(472, 144);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(48, 23);
			this.label8.TabIndex = 236;
			this.label8.Text = "运编号";
			this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// priTextBox7
			// 
			this.priTextBox7.BackColor = System.Drawing.Color.White;
			this.priTextBox7.DataField = "deliveryDate";
			this.priTextBox7.DataType = TJSystem.Public.DataType.String;
			this.priTextBox7.Enabled = false;
			this.priTextBox7.Font = new System.Drawing.Font("宋体", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.priTextBox7.Location = new System.Drawing.Point(528, 144);
			this.priTextBox7.Name = "priTextBox7";
			this.priTextBox7.Size = new System.Drawing.Size(208, 22);
			this.priTextBox7.TabIndex = 237;
			this.priTextBox7.Text = "";
			// 
			// label7
			// 
			this.label7.BackColor = System.Drawing.Color.Transparent;
			this.label7.Font = new System.Drawing.Font("宋体", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.label7.Location = new System.Drawing.Point(448, 120);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(80, 23);
			this.label7.TabIndex = 234;
			this.label7.Text = "预计收汇日";
			this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// priTextBox6
			// 
			this.priTextBox6.BackColor = System.Drawing.Color.White;
			this.priTextBox6.DataField = "deliveryDate";
			this.priTextBox6.DataType = TJSystem.Public.DataType.String;
			this.priTextBox6.Enabled = false;
			this.priTextBox6.Font = new System.Drawing.Font("宋体", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.priTextBox6.Location = new System.Drawing.Point(528, 120);
			this.priTextBox6.Name = "priTextBox6";
			this.priTextBox6.Size = new System.Drawing.Size(120, 22);
			this.priTextBox6.TabIndex = 235;
			this.priTextBox6.Text = "";
			// 
			// label6
			// 
			this.label6.BackColor = System.Drawing.Color.Transparent;
			this.label6.Font = new System.Drawing.Font("宋体", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.label6.Location = new System.Drawing.Point(456, 96);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(72, 23);
			this.label6.TabIndex = 232;
			this.label6.Text = "出运日期";
			this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// priTextBox5
			// 
			this.priTextBox5.BackColor = System.Drawing.Color.White;
			this.priTextBox5.DataField = "deliveryDate";
			this.priTextBox5.DataType = TJSystem.Public.DataType.String;
			this.priTextBox5.Enabled = false;
			this.priTextBox5.Font = new System.Drawing.Font("宋体", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.priTextBox5.Location = new System.Drawing.Point(528, 96);
			this.priTextBox5.Name = "priTextBox5";
			this.priTextBox5.Size = new System.Drawing.Size(120, 22);
			this.priTextBox5.TabIndex = 233;
			this.priTextBox5.Text = "";
			// 
			// label5
			// 
			this.label5.BackColor = System.Drawing.Color.Transparent;
			this.label5.Font = new System.Drawing.Font("宋体", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.label5.Location = new System.Drawing.Point(456, 72);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(72, 23);
			this.label5.TabIndex = 230;
			this.label5.Text = "价格条款";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// priTextBox4
			// 
			this.priTextBox4.BackColor = System.Drawing.Color.White;
			this.priTextBox4.DataField = "deliveryDate";
			this.priTextBox4.DataType = TJSystem.Public.DataType.String;
			this.priTextBox4.Enabled = false;
			this.priTextBox4.Font = new System.Drawing.Font("宋体", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.priTextBox4.Location = new System.Drawing.Point(528, 72);
			this.priTextBox4.Name = "priTextBox4";
			this.priTextBox4.Size = new System.Drawing.Size(208, 22);
			this.priTextBox4.TabIndex = 231;
			this.priTextBox4.Text = "";
			// 
			// label4
			// 
			this.label4.BackColor = System.Drawing.Color.Transparent;
			this.label4.Font = new System.Drawing.Font("宋体", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.label4.Location = new System.Drawing.Point(456, 48);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(72, 23);
			this.label4.TabIndex = 228;
			this.label4.Text = "目的港";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// priTextBox3
			// 
			this.priTextBox3.BackColor = System.Drawing.Color.White;
			this.priTextBox3.DataField = "deliveryDate";
			this.priTextBox3.DataType = TJSystem.Public.DataType.String;
			this.priTextBox3.Enabled = false;
			this.priTextBox3.Font = new System.Drawing.Font("宋体", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.priTextBox3.Location = new System.Drawing.Point(528, 48);
			this.priTextBox3.Name = "priTextBox3";
			this.priTextBox3.Size = new System.Drawing.Size(208, 22);
			this.priTextBox3.TabIndex = 229;
			this.priTextBox3.Text = "";
			// 
			// label3
			// 
			this.label3.BackColor = System.Drawing.Color.Transparent;
			this.label3.Font = new System.Drawing.Font("宋体", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.label3.Location = new System.Drawing.Point(456, 24);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(72, 23);
			this.label3.TabIndex = 226;
			this.label3.Text = "出口口岸";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// priTextBox2
			// 
			this.priTextBox2.BackColor = System.Drawing.Color.White;
			this.priTextBox2.DataField = "deliveryDate";
			this.priTextBox2.DataType = TJSystem.Public.DataType.String;
			this.priTextBox2.Enabled = false;
			this.priTextBox2.Font = new System.Drawing.Font("宋体", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.priTextBox2.Location = new System.Drawing.Point(528, 24);
			this.priTextBox2.Name = "priTextBox2";
			this.priTextBox2.Size = new System.Drawing.Size(208, 22);
			this.priTextBox2.TabIndex = 227;
			this.priTextBox2.Text = "";
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Font = new System.Drawing.Font("宋体", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.label1.Location = new System.Drawing.Point(240, 24);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(64, 23);
			this.label1.TabIndex = 224;
			this.label1.Text = "贸易国别";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// priTextBox1
			// 
			this.priTextBox1.BackColor = System.Drawing.Color.White;
			this.priTextBox1.DataField = "deliveryDate";
			this.priTextBox1.DataType = TJSystem.Public.DataType.String;
			this.priTextBox1.Enabled = false;
			this.priTextBox1.Font = new System.Drawing.Font("宋体", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.priTextBox1.Location = new System.Drawing.Point(312, 24);
			this.priTextBox1.Name = "priTextBox1";
			this.priTextBox1.Size = new System.Drawing.Size(120, 22);
			this.priTextBox1.TabIndex = 225;
			this.priTextBox1.Text = "";
			// 
			// label12
			// 
			this.label12.BackColor = System.Drawing.Color.Transparent;
			this.label12.Font = new System.Drawing.Font("宋体", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.label12.Location = new System.Drawing.Point(24, 48);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(80, 23);
			this.label12.TabIndex = 222;
			this.label12.Text = "采购单号";
			this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txt3
			// 
			this.txt3.BackColor = System.Drawing.Color.White;
			this.txt3.DataField = "deliveryDate";
			this.txt3.DataType = TJSystem.Public.DataType.String;
			this.txt3.Enabled = false;
			this.txt3.Font = new System.Drawing.Font("宋体", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.txt3.Location = new System.Drawing.Point(112, 48);
			this.txt3.Name = "txt3";
			this.txt3.Size = new System.Drawing.Size(120, 22);
			this.txt3.TabIndex = 223;
			this.txt3.Text = "";
			// 
			// label2
			// 
			this.label2.BackColor = System.Drawing.Color.Transparent;
			this.label2.Font = new System.Drawing.Font("宋体", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.label2.ForeColor = System.Drawing.Color.Blue;
			this.label2.Location = new System.Drawing.Point(24, 24);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(80, 23);
			this.label2.TabIndex = 221;
			this.label2.Text = "销售订单号";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// priComboBox1
			// 
			this.priComboBox1.BackColor = System.Drawing.Color.White;
			this.priComboBox1.DataField = "Contact_id";
			this.priComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.priComboBox1.Font = new System.Drawing.Font("宋体", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.priComboBox1.Location = new System.Drawing.Point(112, 24);
			this.priComboBox1.Name = "priComboBox1";
			this.priComboBox1.Size = new System.Drawing.Size(120, 21);
			this.priComboBox1.TabIndex = 220;
			this.priComboBox1.SelectionChangeCommitted += new System.EventHandler(this.priComboBox1_SelectionChangeCommitted);
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.priTextBox25);
			this.groupBox2.Controls.Add(this.label27);
			this.groupBox2.Controls.Add(this.priTextBox26);
			this.groupBox2.Controls.Add(this.label28);
			this.groupBox2.Controls.Add(this.priTextBox27);
			this.groupBox2.Controls.Add(this.label29);
			this.groupBox2.Controls.Add(this.priTextBox28);
			this.groupBox2.Controls.Add(this.label30);
			this.groupBox2.Controls.Add(this.priTextBox29);
			this.groupBox2.Controls.Add(this.label31);
			this.groupBox2.Controls.Add(this.priTextBox24);
			this.groupBox2.Controls.Add(this.label15);
			this.groupBox2.Controls.Add(this.priTextBox13);
			this.groupBox2.Controls.Add(this.label16);
			this.groupBox2.Controls.Add(this.priTextBox14);
			this.groupBox2.Controls.Add(this.label17);
			this.groupBox2.Controls.Add(this.priTextBox15);
			this.groupBox2.Controls.Add(this.label25);
			this.groupBox2.Controls.Add(this.priTextBox23);
			this.groupBox2.Controls.Add(this.label26);
			this.groupBox2.Font = new System.Drawing.Font("宋体", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.groupBox2.Location = new System.Drawing.Point(8, 248);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(224, 280);
			this.groupBox2.TabIndex = 1;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "出口销售收入";
			// 
			// priTextBox25
			// 
			this.priTextBox25.BackColor = System.Drawing.Color.White;
			this.priTextBox25.DataField = "deliveryDate";
			this.priTextBox25.DataType = TJSystem.Public.DataType.String;
			this.priTextBox25.Enabled = false;
			this.priTextBox25.Font = new System.Drawing.Font("宋体", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.priTextBox25.Location = new System.Drawing.Point(96, 144);
			this.priTextBox25.Name = "priTextBox25";
			this.priTextBox25.Size = new System.Drawing.Size(120, 22);
			this.priTextBox25.TabIndex = 256;
			this.priTextBox25.Text = "";
			// 
			// label27
			// 
			this.label27.BackColor = System.Drawing.Color.Transparent;
			this.label27.Font = new System.Drawing.Font("宋体", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.label27.Location = new System.Drawing.Point(16, 240);
			this.label27.Name = "label27";
			this.label27.Size = new System.Drawing.Size(72, 23);
			this.label27.TabIndex = 254;
			this.label27.Text = "销售收入";
			this.label27.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// priTextBox26
			// 
			this.priTextBox26.BackColor = System.Drawing.Color.White;
			this.priTextBox26.DataField = "deliveryDate";
			this.priTextBox26.DataType = TJSystem.Public.DataType.String;
			this.priTextBox26.Enabled = false;
			this.priTextBox26.Font = new System.Drawing.Font("宋体", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.priTextBox26.Location = new System.Drawing.Point(96, 240);
			this.priTextBox26.Name = "priTextBox26";
			this.priTextBox26.Size = new System.Drawing.Size(120, 22);
			this.priTextBox26.TabIndex = 255;
			this.priTextBox26.Text = "";
			// 
			// label28
			// 
			this.label28.BackColor = System.Drawing.Color.Transparent;
			this.label28.Font = new System.Drawing.Font("宋体", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.label28.Location = new System.Drawing.Point(16, 216);
			this.label28.Name = "label28";
			this.label28.Size = new System.Drawing.Size(72, 23);
			this.label28.TabIndex = 252;
			this.label28.Text = "FOB收入";
			this.label28.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// priTextBox27
			// 
			this.priTextBox27.BackColor = System.Drawing.Color.White;
			this.priTextBox27.DataField = "deliveryDate";
			this.priTextBox27.DataType = TJSystem.Public.DataType.String;
			this.priTextBox27.Enabled = false;
			this.priTextBox27.Font = new System.Drawing.Font("宋体", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.priTextBox27.Location = new System.Drawing.Point(96, 216);
			this.priTextBox27.Name = "priTextBox27";
			this.priTextBox27.Size = new System.Drawing.Size(120, 22);
			this.priTextBox27.TabIndex = 253;
			this.priTextBox27.Text = "";
			// 
			// label29
			// 
			this.label29.BackColor = System.Drawing.Color.Transparent;
			this.label29.Font = new System.Drawing.Font("宋体", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.label29.Location = new System.Drawing.Point(8, 192);
			this.label29.Name = "label29";
			this.label29.Size = new System.Drawing.Size(80, 23);
			this.label29.TabIndex = 250;
			this.label29.Text = "美元汇率";
			this.label29.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// priTextBox28
			// 
			this.priTextBox28.BackColor = System.Drawing.Color.White;
			this.priTextBox28.DataField = "deliveryDate";
			this.priTextBox28.DataType = TJSystem.Public.DataType.String;
			this.priTextBox28.Enabled = false;
			this.priTextBox28.Font = new System.Drawing.Font("宋体", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.priTextBox28.Location = new System.Drawing.Point(96, 192);
			this.priTextBox28.Name = "priTextBox28";
			this.priTextBox28.Size = new System.Drawing.Size(120, 22);
			this.priTextBox28.TabIndex = 251;
			this.priTextBox28.Text = "";
			// 
			// label30
			// 
			this.label30.BackColor = System.Drawing.Color.Transparent;
			this.label30.Font = new System.Drawing.Font("宋体", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.label30.Location = new System.Drawing.Point(8, 168);
			this.label30.Name = "label30";
			this.label30.Size = new System.Drawing.Size(80, 23);
			this.label30.TabIndex = 248;
			this.label30.Text = "其它费用";
			this.label30.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// priTextBox29
			// 
			this.priTextBox29.BackColor = System.Drawing.Color.White;
			this.priTextBox29.DataField = "deliveryDate";
			this.priTextBox29.DataType = TJSystem.Public.DataType.String;
			this.priTextBox29.Enabled = false;
			this.priTextBox29.Font = new System.Drawing.Font("宋体", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.priTextBox29.Location = new System.Drawing.Point(96, 168);
			this.priTextBox29.Name = "priTextBox29";
			this.priTextBox29.Size = new System.Drawing.Size(120, 22);
			this.priTextBox29.TabIndex = 249;
			this.priTextBox29.Text = "";
			// 
			// label31
			// 
			this.label31.BackColor = System.Drawing.Color.Transparent;
			this.label31.Font = new System.Drawing.Font("宋体", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.label31.ForeColor = System.Drawing.SystemColors.ControlText;
			this.label31.Location = new System.Drawing.Point(8, 144);
			this.label31.Name = "label31";
			this.label31.Size = new System.Drawing.Size(80, 23);
			this.label31.TabIndex = 247;
			this.label31.Text = "佣金折扣";
			this.label31.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// priTextBox24
			// 
			this.priTextBox24.BackColor = System.Drawing.Color.White;
			this.priTextBox24.DataField = "deliveryDate";
			this.priTextBox24.DataType = TJSystem.Public.DataType.String;
			this.priTextBox24.Enabled = false;
			this.priTextBox24.Font = new System.Drawing.Font("宋体", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.priTextBox24.Location = new System.Drawing.Point(96, 24);
			this.priTextBox24.Name = "priTextBox24";
			this.priTextBox24.Size = new System.Drawing.Size(120, 22);
			this.priTextBox24.TabIndex = 246;
			this.priTextBox24.Text = "";
			// 
			// label15
			// 
			this.label15.BackColor = System.Drawing.Color.Transparent;
			this.label15.Font = new System.Drawing.Font("宋体", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.label15.Location = new System.Drawing.Point(40, 120);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(48, 23);
			this.label15.TabIndex = 242;
			this.label15.Text = "保险费";
			this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// priTextBox13
			// 
			this.priTextBox13.BackColor = System.Drawing.Color.White;
			this.priTextBox13.DataField = "deliveryDate";
			this.priTextBox13.DataType = TJSystem.Public.DataType.String;
			this.priTextBox13.Enabled = false;
			this.priTextBox13.Font = new System.Drawing.Font("宋体", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.priTextBox13.Location = new System.Drawing.Point(96, 120);
			this.priTextBox13.Name = "priTextBox13";
			this.priTextBox13.Size = new System.Drawing.Size(120, 22);
			this.priTextBox13.TabIndex = 243;
			this.priTextBox13.Text = "";
			// 
			// label16
			// 
			this.label16.BackColor = System.Drawing.Color.Transparent;
			this.label16.Font = new System.Drawing.Font("宋体", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.label16.Location = new System.Drawing.Point(16, 96);
			this.label16.Name = "label16";
			this.label16.Size = new System.Drawing.Size(72, 23);
			this.label16.TabIndex = 240;
			this.label16.Text = "运费";
			this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// priTextBox14
			// 
			this.priTextBox14.BackColor = System.Drawing.Color.White;
			this.priTextBox14.DataField = "deliveryDate";
			this.priTextBox14.DataType = TJSystem.Public.DataType.String;
			this.priTextBox14.Enabled = false;
			this.priTextBox14.Font = new System.Drawing.Font("宋体", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.priTextBox14.Location = new System.Drawing.Point(96, 96);
			this.priTextBox14.Name = "priTextBox14";
			this.priTextBox14.Size = new System.Drawing.Size(120, 22);
			this.priTextBox14.TabIndex = 241;
			this.priTextBox14.Text = "";
			// 
			// label17
			// 
			this.label17.BackColor = System.Drawing.Color.Transparent;
			this.label17.Font = new System.Drawing.Font("宋体", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.label17.Location = new System.Drawing.Point(8, 72);
			this.label17.Name = "label17";
			this.label17.Size = new System.Drawing.Size(80, 23);
			this.label17.TabIndex = 238;
			this.label17.Text = "出口金额";
			this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// priTextBox15
			// 
			this.priTextBox15.BackColor = System.Drawing.Color.White;
			this.priTextBox15.DataField = "deliveryDate";
			this.priTextBox15.DataType = TJSystem.Public.DataType.String;
			this.priTextBox15.Enabled = false;
			this.priTextBox15.Font = new System.Drawing.Font("宋体", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.priTextBox15.Location = new System.Drawing.Point(96, 72);
			this.priTextBox15.Name = "priTextBox15";
			this.priTextBox15.Size = new System.Drawing.Size(120, 22);
			this.priTextBox15.TabIndex = 239;
			this.priTextBox15.Text = "";
			// 
			// label25
			// 
			this.label25.BackColor = System.Drawing.Color.Transparent;
			this.label25.Font = new System.Drawing.Font("宋体", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.label25.Location = new System.Drawing.Point(0, 48);
			this.label25.Name = "label25";
			this.label25.Size = new System.Drawing.Size(88, 23);
			this.label25.TabIndex = 222;
			this.label25.Text = "人民币汇率";
			this.label25.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// priTextBox23
			// 
			this.priTextBox23.BackColor = System.Drawing.Color.White;
			this.priTextBox23.DataField = "deliveryDate";
			this.priTextBox23.DataType = TJSystem.Public.DataType.String;
			this.priTextBox23.Enabled = false;
			this.priTextBox23.Font = new System.Drawing.Font("宋体", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.priTextBox23.Location = new System.Drawing.Point(96, 48);
			this.priTextBox23.Name = "priTextBox23";
			this.priTextBox23.Size = new System.Drawing.Size(120, 22);
			this.priTextBox23.TabIndex = 223;
			this.priTextBox23.Text = "";
			// 
			// label26
			// 
			this.label26.BackColor = System.Drawing.Color.Transparent;
			this.label26.Font = new System.Drawing.Font("宋体", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.label26.ForeColor = System.Drawing.SystemColors.ControlText;
			this.label26.Location = new System.Drawing.Point(8, 24);
			this.label26.Name = "label26";
			this.label26.Size = new System.Drawing.Size(80, 23);
			this.label26.TabIndex = 221;
			this.label26.Text = "出口币别";
			this.label26.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.label38);
			this.groupBox3.Controls.Add(this.label37);
			this.groupBox3.Controls.Add(this.priTextBox34);
			this.groupBox3.Controls.Add(this.priTextBox33);
			this.groupBox3.Font = new System.Drawing.Font("宋体", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.groupBox3.Location = new System.Drawing.Point(504, 256);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(272, 152);
			this.groupBox3.TabIndex = 2;
			this.groupBox3.TabStop = false;
			// 
			// label38
			// 
			this.label38.AutoSize = true;
			this.label38.BackColor = System.Drawing.Color.Transparent;
			this.label38.Font = new System.Drawing.Font("宋体", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.label38.Location = new System.Drawing.Point(24, 56);
			this.label38.Name = "label38";
			this.label38.Size = new System.Drawing.Size(32, 18);
			this.label38.TabIndex = 272;
			this.label38.Text = "备注";
			this.label38.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label37
			// 
			this.label37.AutoSize = true;
			this.label37.BackColor = System.Drawing.Color.Transparent;
			this.label37.Font = new System.Drawing.Font("宋体", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.label37.Location = new System.Drawing.Point(8, 24);
			this.label37.Name = "label37";
			this.label37.Size = new System.Drawing.Size(58, 18);
			this.label37.TabIndex = 271;
			this.label37.Text = "审批状态";
			this.label37.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// priTextBox34
			// 
			this.priTextBox34.BackColor = System.Drawing.Color.White;
			this.priTextBox34.DataField = "deliveryDate";
			this.priTextBox34.DataType = TJSystem.Public.DataType.String;
			this.priTextBox34.Enabled = false;
			this.priTextBox34.Font = new System.Drawing.Font("宋体", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.priTextBox34.Location = new System.Drawing.Point(72, 48);
			this.priTextBox34.Multiline = true;
			this.priTextBox34.Name = "priTextBox34";
			this.priTextBox34.Size = new System.Drawing.Size(184, 88);
			this.priTextBox34.TabIndex = 270;
			this.priTextBox34.Text = "";
			// 
			// priTextBox33
			// 
			this.priTextBox33.BackColor = System.Drawing.Color.White;
			this.priTextBox33.DataField = "deliveryDate";
			this.priTextBox33.DataType = TJSystem.Public.DataType.String;
			this.priTextBox33.Enabled = false;
			this.priTextBox33.Font = new System.Drawing.Font("宋体", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.priTextBox33.Location = new System.Drawing.Point(72, 24);
			this.priTextBox33.Name = "priTextBox33";
			this.priTextBox33.Size = new System.Drawing.Size(184, 22);
			this.priTextBox33.TabIndex = 268;
			this.priTextBox33.Text = "";
			// 
			// groupBox4
			// 
			this.groupBox4.Controls.Add(this.xpStyleButton1);
			this.groupBox4.Controls.Add(this.button1);
			this.groupBox4.Font = new System.Drawing.Font("宋体", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.groupBox4.Location = new System.Drawing.Point(504, 416);
			this.groupBox4.Name = "groupBox4";
			this.groupBox4.Size = new System.Drawing.Size(272, 112);
			this.groupBox4.TabIndex = 3;
			this.groupBox4.TabStop = false;
			// 
			// xpStyleButton1
			// 
			this.xpStyleButton1.Font = new System.Drawing.Font("宋体", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.xpStyleButton1.Location = new System.Drawing.Point(72, 64);
			this.xpStyleButton1.Name = "xpStyleButton1";
			this.xpStyleButton1.Size = new System.Drawing.Size(128, 32);
			this.xpStyleButton1.TabIndex = 1;
			this.xpStyleButton1.Text = "结束查询";
			this.xpStyleButton1.Click += new System.EventHandler(this.xpStyleButton1_Click);
			// 
			// button1
			// 
			this.button1.Font = new System.Drawing.Font("宋体", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.button1.Location = new System.Drawing.Point(72, 24);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(128, 32);
			this.button1.TabIndex = 0;
			this.button1.Text = "生成报表";
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// groupBox5
			// 
			this.groupBox5.Controls.Add(this.label34);
			this.groupBox5.Controls.Add(this.priTextBox32);
			this.groupBox5.Controls.Add(this.priTextBox12);
			this.groupBox5.Controls.Add(this.label14);
			this.groupBox5.Controls.Add(this.priTextBox16);
			this.groupBox5.Controls.Add(this.label18);
			this.groupBox5.Controls.Add(this.priTextBox17);
			this.groupBox5.Controls.Add(this.label19);
			this.groupBox5.Controls.Add(this.priTextBox18);
			this.groupBox5.Controls.Add(this.label20);
			this.groupBox5.Controls.Add(this.priTextBox19);
			this.groupBox5.Controls.Add(this.label21);
			this.groupBox5.Controls.Add(this.priTextBox20);
			this.groupBox5.Controls.Add(this.label22);
			this.groupBox5.Controls.Add(this.priTextBox21);
			this.groupBox5.Controls.Add(this.label23);
			this.groupBox5.Controls.Add(this.priTextBox22);
			this.groupBox5.Controls.Add(this.label24);
			this.groupBox5.Controls.Add(this.priTextBox30);
			this.groupBox5.Controls.Add(this.label33);
			this.groupBox5.Font = new System.Drawing.Font("宋体", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.groupBox5.ForeColor = System.Drawing.SystemColors.ControlText;
			this.groupBox5.Location = new System.Drawing.Point(240, 248);
			this.groupBox5.Name = "groupBox5";
			this.groupBox5.Size = new System.Drawing.Size(256, 280);
			this.groupBox5.TabIndex = 4;
			this.groupBox5.TabStop = false;
			this.groupBox5.Text = "出口国内成本";
			this.groupBox5.Enter += new System.EventHandler(this.groupBox5_Enter);
			// 
			// label34
			// 
			this.label34.BackColor = System.Drawing.Color.Transparent;
			this.label34.Font = new System.Drawing.Font("宋体", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.label34.Location = new System.Drawing.Point(8, 240);
			this.label34.Name = "label34";
			this.label34.Size = new System.Drawing.Size(104, 23);
			this.label34.TabIndex = 299;
			this.label34.Text = "税后换汇成本";
			this.label34.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// priTextBox32
			// 
			this.priTextBox32.BackColor = System.Drawing.Color.White;
			this.priTextBox32.DataField = "deliveryDate";
			this.priTextBox32.DataType = TJSystem.Public.DataType.String;
			this.priTextBox32.Enabled = false;
			this.priTextBox32.Font = new System.Drawing.Font("宋体", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.priTextBox32.Location = new System.Drawing.Point(120, 240);
			this.priTextBox32.Name = "priTextBox32";
			this.priTextBox32.Size = new System.Drawing.Size(120, 22);
			this.priTextBox32.TabIndex = 300;
			this.priTextBox32.Text = "";
			// 
			// priTextBox12
			// 
			this.priTextBox12.BackColor = System.Drawing.Color.White;
			this.priTextBox12.DataField = "deliveryDate";
			this.priTextBox12.DataType = TJSystem.Public.DataType.String;
			this.priTextBox12.Enabled = false;
			this.priTextBox12.Font = new System.Drawing.Font("宋体", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.priTextBox12.Location = new System.Drawing.Point(120, 120);
			this.priTextBox12.Name = "priTextBox12";
			this.priTextBox12.Size = new System.Drawing.Size(120, 22);
			this.priTextBox12.TabIndex = 298;
			this.priTextBox12.Text = "";
			// 
			// label14
			// 
			this.label14.BackColor = System.Drawing.Color.Transparent;
			this.label14.Font = new System.Drawing.Font("宋体", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.label14.Location = new System.Drawing.Point(8, 216);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(104, 23);
			this.label14.TabIndex = 296;
			this.label14.Text = "税前换汇成本";
			this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// priTextBox16
			// 
			this.priTextBox16.BackColor = System.Drawing.Color.White;
			this.priTextBox16.DataField = "deliveryDate";
			this.priTextBox16.DataType = TJSystem.Public.DataType.String;
			this.priTextBox16.Enabled = false;
			this.priTextBox16.Font = new System.Drawing.Font("宋体", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.priTextBox16.Location = new System.Drawing.Point(120, 216);
			this.priTextBox16.Name = "priTextBox16";
			this.priTextBox16.Size = new System.Drawing.Size(120, 22);
			this.priTextBox16.TabIndex = 297;
			this.priTextBox16.Text = "";
			// 
			// label18
			// 
			this.label18.BackColor = System.Drawing.Color.Transparent;
			this.label18.Font = new System.Drawing.Font("宋体", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.label18.Location = new System.Drawing.Point(64, 192);
			this.label18.Name = "label18";
			this.label18.Size = new System.Drawing.Size(48, 23);
			this.label18.TabIndex = 294;
			this.label18.Text = "盈亏额";
			this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// priTextBox17
			// 
			this.priTextBox17.BackColor = System.Drawing.Color.White;
			this.priTextBox17.DataField = "deliveryDate";
			this.priTextBox17.DataType = TJSystem.Public.DataType.String;
			this.priTextBox17.Enabled = false;
			this.priTextBox17.Font = new System.Drawing.Font("宋体", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.priTextBox17.Location = new System.Drawing.Point(120, 192);
			this.priTextBox17.Name = "priTextBox17";
			this.priTextBox17.Size = new System.Drawing.Size(120, 22);
			this.priTextBox17.TabIndex = 295;
			this.priTextBox17.Text = "";
			// 
			// label19
			// 
			this.label19.BackColor = System.Drawing.Color.Transparent;
			this.label19.Font = new System.Drawing.Font("宋体", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.label19.Location = new System.Drawing.Point(32, 168);
			this.label19.Name = "label19";
			this.label19.Size = new System.Drawing.Size(80, 23);
			this.label19.TabIndex = 292;
			this.label19.Text = "成本合计";
			this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// priTextBox18
			// 
			this.priTextBox18.BackColor = System.Drawing.Color.White;
			this.priTextBox18.DataField = "deliveryDate";
			this.priTextBox18.DataType = TJSystem.Public.DataType.String;
			this.priTextBox18.Enabled = false;
			this.priTextBox18.Font = new System.Drawing.Font("宋体", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.priTextBox18.Location = new System.Drawing.Point(120, 168);
			this.priTextBox18.Name = "priTextBox18";
			this.priTextBox18.Size = new System.Drawing.Size(120, 22);
			this.priTextBox18.TabIndex = 293;
			this.priTextBox18.Text = "";
			// 
			// label20
			// 
			this.label20.BackColor = System.Drawing.Color.Transparent;
			this.label20.Font = new System.Drawing.Font("宋体", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.label20.Location = new System.Drawing.Point(0, 144);
			this.label20.Name = "label20";
			this.label20.Size = new System.Drawing.Size(112, 23);
			this.label20.TabIndex = 290;
			this.label20.Text = "国内其他费用";
			this.label20.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// priTextBox19
			// 
			this.priTextBox19.BackColor = System.Drawing.Color.White;
			this.priTextBox19.DataField = "deliveryDate";
			this.priTextBox19.DataType = TJSystem.Public.DataType.String;
			this.priTextBox19.Enabled = false;
			this.priTextBox19.Font = new System.Drawing.Font("宋体", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.priTextBox19.Location = new System.Drawing.Point(120, 144);
			this.priTextBox19.Name = "priTextBox19";
			this.priTextBox19.Size = new System.Drawing.Size(120, 22);
			this.priTextBox19.TabIndex = 291;
			this.priTextBox19.Text = "";
			// 
			// label21
			// 
			this.label21.BackColor = System.Drawing.Color.Transparent;
			this.label21.Font = new System.Drawing.Font("宋体", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.label21.ForeColor = System.Drawing.SystemColors.ControlText;
			this.label21.Location = new System.Drawing.Point(32, 120);
			this.label21.Name = "label21";
			this.label21.Size = new System.Drawing.Size(80, 23);
			this.label21.TabIndex = 289;
			this.label21.Text = "国内运费";
			this.label21.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// priTextBox20
			// 
			this.priTextBox20.BackColor = System.Drawing.Color.White;
			this.priTextBox20.DataField = "deliveryDate";
			this.priTextBox20.DataType = TJSystem.Public.DataType.String;
			this.priTextBox20.Enabled = false;
			this.priTextBox20.Font = new System.Drawing.Font("宋体", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.priTextBox20.Location = new System.Drawing.Point(120, 24);
			this.priTextBox20.Name = "priTextBox20";
			this.priTextBox20.Size = new System.Drawing.Size(120, 22);
			this.priTextBox20.TabIndex = 288;
			this.priTextBox20.Text = "";
			// 
			// label22
			// 
			this.label22.BackColor = System.Drawing.Color.Transparent;
			this.label22.Font = new System.Drawing.Font("宋体", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.label22.Location = new System.Drawing.Point(24, 96);
			this.label22.Name = "label22";
			this.label22.Size = new System.Drawing.Size(88, 23);
			this.label22.TabIndex = 286;
			this.label22.Text = "管理费";
			this.label22.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// priTextBox21
			// 
			this.priTextBox21.BackColor = System.Drawing.Color.White;
			this.priTextBox21.DataField = "deliveryDate";
			this.priTextBox21.DataType = TJSystem.Public.DataType.String;
			this.priTextBox21.Enabled = false;
			this.priTextBox21.Font = new System.Drawing.Font("宋体", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.priTextBox21.Location = new System.Drawing.Point(120, 96);
			this.priTextBox21.Name = "priTextBox21";
			this.priTextBox21.Size = new System.Drawing.Size(120, 22);
			this.priTextBox21.TabIndex = 287;
			this.priTextBox21.Text = "";
			// 
			// label23
			// 
			this.label23.BackColor = System.Drawing.Color.Transparent;
			this.label23.Font = new System.Drawing.Font("宋体", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.label23.Location = new System.Drawing.Point(32, 72);
			this.label23.Name = "label23";
			this.label23.Size = new System.Drawing.Size(80, 23);
			this.label23.TabIndex = 284;
			this.label23.Text = "国内费用";
			this.label23.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// priTextBox22
			// 
			this.priTextBox22.BackColor = System.Drawing.Color.White;
			this.priTextBox22.DataField = "deliveryDate";
			this.priTextBox22.DataType = TJSystem.Public.DataType.String;
			this.priTextBox22.Enabled = false;
			this.priTextBox22.Font = new System.Drawing.Font("宋体", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.priTextBox22.Location = new System.Drawing.Point(120, 72);
			this.priTextBox22.Name = "priTextBox22";
			this.priTextBox22.Size = new System.Drawing.Size(120, 22);
			this.priTextBox22.TabIndex = 285;
			this.priTextBox22.Text = "";
			// 
			// label24
			// 
			this.label24.BackColor = System.Drawing.Color.Transparent;
			this.label24.Font = new System.Drawing.Font("宋体", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.label24.Location = new System.Drawing.Point(16, 48);
			this.label24.Name = "label24";
			this.label24.Size = new System.Drawing.Size(96, 23);
			this.label24.TabIndex = 282;
			this.label24.Text = "出口退税金额";
			this.label24.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// priTextBox30
			// 
			this.priTextBox30.BackColor = System.Drawing.Color.White;
			this.priTextBox30.DataField = "deliveryDate";
			this.priTextBox30.DataType = TJSystem.Public.DataType.String;
			this.priTextBox30.Enabled = false;
			this.priTextBox30.Font = new System.Drawing.Font("宋体", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.priTextBox30.Location = new System.Drawing.Point(120, 48);
			this.priTextBox30.Name = "priTextBox30";
			this.priTextBox30.Size = new System.Drawing.Size(120, 22);
			this.priTextBox30.TabIndex = 283;
			this.priTextBox30.Text = "";
			// 
			// label33
			// 
			this.label33.BackColor = System.Drawing.Color.Transparent;
			this.label33.Font = new System.Drawing.Font("宋体", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.label33.ForeColor = System.Drawing.SystemColors.ControlText;
			this.label33.Location = new System.Drawing.Point(8, 24);
			this.label33.Name = "label33";
			this.label33.Size = new System.Drawing.Size(104, 23);
			this.label33.TabIndex = 279;
			this.label33.Text = "收购合同金额";
			this.label33.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// groupBox6
			// 
			this.groupBox6.Controls.Add(this.label35);
			this.groupBox6.Font = new System.Drawing.Font("宋体", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.groupBox6.Location = new System.Drawing.Point(8, 8);
			this.groupBox6.Name = "groupBox6";
			this.groupBox6.Size = new System.Drawing.Size(768, 56);
			this.groupBox6.TabIndex = 5;
			this.groupBox6.TabStop = false;
			// 
			// label35
			// 
			this.label35.BackColor = System.Drawing.Color.Transparent;
			this.label35.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label35.Font = new System.Drawing.Font("宋体", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.label35.Location = new System.Drawing.Point(3, 18);
			this.label35.Name = "label35";
			this.label35.Size = new System.Drawing.Size(762, 35);
			this.label35.TabIndex = 231;
			this.label35.Text = "盈亏预计报表";
			this.label35.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// frmRptBalance
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(7, 15);
			this.ClientSize = new System.Drawing.Size(792, 566);
			this.Controls.Add(this.groupBox6);
			this.Controls.Add(this.groupBox5);
			this.Controls.Add(this.groupBox4);
			this.Controls.Add(this.groupBox3);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Font = new System.Drawing.Font("宋体", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.Name = "frmRptBalance";
			this.Text = "盈亏报表";
			this.groupBox1.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			this.groupBox3.ResumeLayout(false);
			this.groupBox4.ResumeLayout(false);
			this.groupBox5.ResumeLayout(false);
			this.groupBox6.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		private void groupBox5_Enter(object sender, System.EventArgs e)
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
				TJSystem.Public.PublicStatic.formName = "盈亏报表";
			}
			base.OnClosing (e);
		}

		private void priComboBox1_SelectionChangeCommitted(object sender, System.EventArgs e)
		{
			System.Text.StringBuilder sb = new System.Text.StringBuilder();
			System.Data.DataTable dtso = null;
			string so_code = this.priComboBox1.SelectedValue.ToString().Trim();
			if(so_code.Equals(""))
			{
				return;
			}

			string sql = "select amount,taxdiscount,InsideAmount,manageAmount,InsideFreight,status from purchase_po_master  where po_code='" + so_code + "'";
			System.Data.DataTable dtpo = TJSystem.Public.PublicStatic.db.GetDataTable(sql);
			if(dtpo.Rows.Count != 1)
			{
				TJSystem.Public.PublicStatic.ShowMessage(TJSystem.Public.MessageType.Exclamation,"找不到该销售单对应的采购单号，请确认该销售单有效！");
				return;
			}
			this.txt3.Text = so_code;

			

			sb.Append("select a.client_name,a.arrivecountry as arrivecountry_id,d.country_namecn as arrivecountry,");
			sb.Append(" a.port_departure as port_departure_id,b.port_namecn as port_departure,");
			sb.Append(" a.destport as destport_id,c.port_namecn as destport,a.priceTerm_dest,a.deliverydate,");
			sb.Append(" a.settlementType,a.currency,a.amount,a.fobamount,a.freightamount,a.insurance,a.brightcommision,");
			sb.Append(" a.darkcommision,a.status as status_id,e.status_name as status,a.remark  ");
			sb.Append(" from sale_so_master a");
			sb.Append(" left join p_port b on b.port_code=a.port_departure");
			sb.Append(" left join p_port c on c.port_code=a.destport");
			sb.Append(" left join p_country d on d.country_code=a.arrivecountry");
			sb.Append(" left join p_status e on e.status_id=a.status and e.status_type='sales'");
			sb.Append(" where a.so_code=");
			sb.Append("'");
			sb.Append(so_code);
			sb.Append("'");

			dtso = TJSystem.Public.PublicStatic.db.GetDataTable(sb.ToString());
			if(dtso.Rows.Count != 1)
			{
				TJSystem.Public.PublicStatic.ShowMessage(TJSystem.Public.MessageType.Exclamation,"找不到该销售单号，请确认该销售单有效！");
				return;
			}
			if(!dtpo.Rows[0]["status"].ToString().Equals(dtso.Rows[0]["status_id"].ToString()))
			{
				TJSystem.Public.PublicStatic.ShowMessage(TJSystem.Public.MessageType.Exclamation,"销售单和采购单审核状态不一致，请确认两张单据已经经过主管审核！");
				return;
			}

			this.priTextBox20.Text = dtpo.Rows[0]["amount"].ToString();
			this.priTextBox30.Text = dtpo.Rows[0]["taxdiscount"].ToString();
			this.priTextBox22.Text = dtpo.Rows[0]["InsideAmount"].ToString();
			this.priTextBox21.Text = dtpo.Rows[0]["manageAmount"].ToString();
			this.priTextBox12.Text = dtpo.Rows[0]["InsideFreight"].ToString();

			this.priTextBox9.Text = dtso.Rows[0]["client_name"].ToString();
			this.priTextBox1.Text = dtso.Rows[0]["arrivecountry"].ToString();
			this.priTextBox2.Text = dtso.Rows[0]["port_departure"].ToString();
			this.priTextBox3.Text = dtso.Rows[0]["destport"].ToString();
			this.priTextBox4.Text = dtso.Rows[0]["priceTerm_dest"].ToString();
			this.priTextBox5.Text = dtso.Rows[0]["deliverydate"].ToString();
			this.priTextBox10.Text = dtso.Rows[0]["settlementType"].ToString();
			this.priTextBox25.Text = dtso.Rows[0]["currency"].ToString();
			this.priTextBox15.Text = dtso.Rows[0]["amount"].ToString();
			this.priTextBox27.Text = dtso.Rows[0]["fobamount"].ToString();
			this.priTextBox14.Text = dtso.Rows[0]["freightamount"].ToString();
			this.priTextBox13.Text = dtso.Rows[0]["insurance"].ToString();
			this.priTextBox25.Text = dtso.Rows[0]["brightcommision"].ToString();
			this.priTextBox29.Text = dtso.Rows[0]["darkcommision"].ToString();
			this.priTextBox33.Text = dtso.Rows[0]["status"].ToString();
			this.priTextBox34.Text = dtso.Rows[0]["remark"].ToString();

			this.priTextBox11.Text = TJSystem.Public.PublicStatic.LoginUserName;

			double soTotal = 0;
			if(!priTextBox15.Text.Trim().Equals(""))
			{
				soTotal += Convert.ToDouble(priTextBox15.Text);
			}
			else
			{
				priTextBox15.Text = "0";
			}
			if(!priTextBox27.Text.Trim().Equals(""))
			{
				soTotal += Convert.ToDouble(priTextBox27.Text);
			}
			else
			{
				priTextBox27.Text = "0";
			}
			if(!priTextBox14.Text.Trim().Equals(""))
			{
				soTotal += Convert.ToDouble(priTextBox14.Text);
			}
			else
			{
				priTextBox14.Text = "0";
			}
			if(!priTextBox13.Text.Trim().Equals(""))
			{
				soTotal += Convert.ToDouble(priTextBox13.Text);
			}
			else
			{
				priTextBox13.Text = "0";
			}
			if(!priTextBox25.Text.Trim().Equals(""))
			{
				soTotal += Convert.ToDouble(priTextBox25.Text);
			}
			else
			{
				priTextBox25.Text = "0";
			}
			if(!priTextBox29.Text.Trim().Equals(""))
			{
				soTotal += Convert.ToDouble(priTextBox29.Text);
			}
			else
			{
				priTextBox29.Text = "0";
			}
			this.priTextBox26.Text = soTotal.ToString();

			double poTotal = 0;
			if(!priTextBox20.Text.Trim().Equals(""))
			{
				poTotal += Convert.ToDouble(priTextBox20.Text);
			}
			else
			{
				priTextBox20.Text = "0";
			}
			if(!priTextBox30.Text.Trim().Equals(""))
			{
				poTotal += Convert.ToDouble(priTextBox30.Text);
			}
			else
			{
				priTextBox30.Text = "0";
			}
			if(!priTextBox22.Text.Trim().Equals(""))
			{
				poTotal += Convert.ToDouble(priTextBox22.Text);
			}
			else
			{
				priTextBox22.Text = "0";
			}
			if(!priTextBox21.Text.Trim().Equals(""))
			{
				poTotal += Convert.ToDouble(priTextBox21.Text);
			}
			else
			{
				priTextBox21.Text = "0";
			}
			if(!priTextBox12.Text.Trim().Equals(""))
			{
				poTotal += Convert.ToDouble(priTextBox12.Text);
			}
			else
			{
				priTextBox12.Text = "0";
			}
			this.priTextBox18.Text = poTotal.ToString();

			this.priTextBox17.Text = Convert.ToString(soTotal - poTotal);

			sb.Remove(0,sb.ToString().Length);
			sb.Append("delete from sale_balance");
			TJSystem.Public.PublicStatic.db.ExeSql(sb.ToString());

			sb.Remove(0,sb.ToString().Length);
			sb.Append("insert into sale_balance");
			sb.Append("  (po_amount,po_taxdiscount,po_insideamount,po_manageamount,po_insidefreight,client_name,arrivecountry,");
			sb.Append(" port_departure,destport,priceterm_dest,deliverydate,settlementtype,currency,sale_amount,sale_fobamount,");
			sb.Append(" sale_freightamount,sale_insurance,sale_brightcommision,sale_darkcommision,status,remark,so_code)");
			sb.Append(" values (");
			sb.Append("'");
			sb.Append(priTextBox20.Text);
			sb.Append("',");
			sb.Append("'");
			sb.Append(priTextBox30.Text);
			sb.Append("',");
			sb.Append("'");
			sb.Append(priTextBox22.Text);
			sb.Append("',");
			sb.Append("'");
			sb.Append(priTextBox21.Text);
			sb.Append("',");
			sb.Append("'");
			sb.Append(priTextBox12.Text);
			sb.Append("',");
			sb.Append("'");
			sb.Append(priTextBox9.Text);
			sb.Append("',");
			sb.Append("'");
			sb.Append(priTextBox1.Text);
			sb.Append("',");
			sb.Append("'");
			sb.Append(priTextBox2.Text);
			sb.Append("',");
			sb.Append("'");
			sb.Append(priTextBox3.Text);
			sb.Append("',");
			sb.Append("'");
			sb.Append(priTextBox4.Text);
			sb.Append("',");
			sb.Append("'");
			sb.Append(priTextBox5.Text);
			sb.Append("',");
			sb.Append("'");
			sb.Append(priTextBox10.Text);
			sb.Append("',");
			sb.Append("'");
			sb.Append(priTextBox25.Text);
			sb.Append("',");
			sb.Append("'");
			sb.Append(priTextBox15.Text);
			sb.Append("',");
			sb.Append("'");
			sb.Append(priTextBox27.Text);
			sb.Append("',");
			sb.Append("'");
			sb.Append(priTextBox14.Text);
			sb.Append("',");
			sb.Append("'");
			sb.Append(priTextBox13.Text);
			sb.Append("',");
			sb.Append("'");
			sb.Append(priTextBox25.Text);
			sb.Append("',");
			sb.Append("'");
			sb.Append(priTextBox29.Text);
			sb.Append("',");
			sb.Append("'");
			sb.Append(priTextBox33.Text);
			sb.Append("',");
			sb.Append("'");
			sb.Append(priTextBox34.Text);
			sb.Append("',");
			sb.Append("'");
			sb.Append(txt3.Text);
			sb.Append("')");
			TJSystem.Public.PublicStatic.db.ExeSql(sb.ToString());
		}

		private void xpStyleButton1_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}

		private void button1_Click(object sender, System.EventArgs e)
		{
			TJSystem.CrystalRPT.frmReport frm = new TJSystem.CrystalRPT.frmReport("盈亏报表",dpcom);
			frm.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			frm.Show();
		}

	}
}

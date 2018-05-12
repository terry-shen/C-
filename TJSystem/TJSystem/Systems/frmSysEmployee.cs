using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace TJSystem.Systems
{
	/// <summary>
	/// Form1 的摘要说明。
	/// </summary>
	public class frmSysEmployee : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Panel panel4;
		private System.Windows.Forms.DataGrid dataGrid1;
		private TJSystem.Classes.PriTextBox textBox1 ;
		
		/// <summary>
		/// 必需的设计器变量。
		/// </summary>
		private System.ComponentModel.Container components = null;
		private TJSystem.UC.PriToolBar priToolBar1;
		private TJSystem.Classes.PriTextBox priTextBox1;
		private TJSystem.Classes.PriTextBox priTextBox2;
		private TJSystem.Classes.PriTextBox priTextBox3;
		private System.Windows.Forms.DataGridTableStyle dataGridTableStyle1;
		private System.Windows.Forms.DataGridTextBoxColumn employee_id;
		private System.Windows.Forms.DataGridTextBoxColumn name;
		private System.Windows.Forms.DataGridTextBoxColumn name_cn;
		private TJSystem.Classes.PriComboBox comboBox1;
		private System.Windows.Forms.DataGridTextBoxColumn Gender;
		private System.Windows.Forms.DataGridTextBoxColumn modifyon;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label9;
		private TJSystem.Classes.PriTextBox priTextBox6;
		private System.Windows.Forms.Label label10;
		private TJSystem.Classes.PriTextBox priTextBox7;
		private System.Windows.Forms.Label label11;
		private TJSystem.Classes.PriTextBox priTextBox8;
		private System.Windows.Forms.Label label12;
		private TJSystem.Classes.PriTextBox priTextBox9;
		private System.Windows.Forms.Label label13;
		private TJSystem.Classes.PriTextBox priTextBox10;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.Label label15;
		private TJSystem.Classes.PriTextBox priTextBox11;
		private System.Windows.Forms.Label label16;
		private TJSystem.Classes.PriTextBox priTextBox12;
		private System.Windows.Forms.Label label17;
		private TJSystem.Classes.PriTextBox priTextBox13;
		private System.Windows.Forms.Label label18;
		private TJSystem.Classes.PriTextBox priTextBox14;
		private System.Windows.Forms.Label label19;
		private TJSystem.Classes.PriTextBox priTextBox15;
		private System.Windows.Forms.Label label20;
		private TJSystem.Classes.PriTextBox priTextBox16;
		private System.Windows.Forms.Label label21;
		private TJSystem.Classes.PriTextBox priTextBox17;
		private System.Windows.Forms.Label label22;
		private TJSystem.Classes.PriTextBox priTextBox18;
		private System.Windows.Forms.Label label23;
		private TJSystem.Classes.PriTextBox priTextBox19;
		private System.Windows.Forms.Label label24;
		private TJSystem.Classes.PriTextBox priTextBox20;
		private System.Windows.Forms.Label label25;
		private TJSystem.Classes.PriTextBox priTextBox21;
		private System.Windows.Forms.Label label26;
		private TJSystem.Classes.PriTextBox priTextBox22;
		private System.Windows.Forms.Label label27;
		private System.Windows.Forms.Label label28;
		private TJSystem.Classes.PriTextBox priTextBox23;
		private TJSystem.Classes.PriTextBox priTextBox24;
		private TJSystem.Classes.PriComboBox priComboBox1;
		private System.Windows.Forms.DataGridTextBoxColumn password;
		private System.Windows.Forms.DataGridTextBoxColumn idcardno;
		private System.Windows.Forms.DataGridTextBoxColumn idaddress;
		private System.Windows.Forms.DataGridTextBoxColumn tel;
		private System.Windows.Forms.DataGridTextBoxColumn mobile;
		private System.Windows.Forms.DataGridTextBoxColumn email;
		private System.Windows.Forms.DataGridTextBoxColumn address;
		private System.Windows.Forms.DataGridTextBoxColumn postcode;
		private System.Windows.Forms.DataGridTextBoxColumn educate_level;
		private System.Windows.Forms.DataGridTextBoxColumn educate_school;
		private System.Windows.Forms.DataGridTextBoxColumn cert;
		private System.Windows.Forms.DataGridTextBoxColumn bank;
		private System.Windows.Forms.DataGridTextBoxColumn account;
		private System.Windows.Forms.DataGridTextBoxColumn start_date;
		private System.Windows.Forms.DataGridTextBoxColumn end_date;
		private System.Windows.Forms.DataGridTextBoxColumn createby;
		private System.Windows.Forms.DataGridTextBoxColumn createon;
		private System.Windows.Forms.DataGridTextBoxColumn modifyby;
		private System.Windows.Forms.DataGridTextBoxColumn remark;
		private System.Windows.Forms.DataGridTextBoxColumn shake_down;
		private TJSystem.Classes.PriTextBox priTextBox4;
		private TJSystem.Classes.PriTextBox priTextBox25;
		private System.Windows.Forms.DataGridTextBoxColumn dept_name;
		private System.Windows.Forms.Label label29;
		private TJSystem.Classes.PriComboBox priComboBox2;
		private System.Windows.Forms.DataGridTextBoxColumn position_name;
		public static System.Windows.Forms.Form frmCurrent = null ;
		private string strPK = null;
		private string strTable = null;

		public frmSysEmployee()
		{
			//
			// Windows 窗体设计器支持所必需的
			//
			InitializeComponent();
			

			TJSystem.Public.PublicStatic.setBackgroundImg(this.panel1,this.panel1.GetType().ToString(),"images\\bg.gif");
			TJSystem.Public.PublicStatic.setBackgroundImg(this.panel2,this.panel1.GetType().ToString(),"");
			TJSystem.Public.PublicStatic.setBackgroundImg(this.panel3,this.panel1.GetType().ToString(),"");
			TJSystem.Public.PublicStatic.setBackgroundImg(this.panel4,this.panel1.GetType().ToString(),"");

			InitialFormData();

//			this.textBox1.DataField = "PNO";
			System.Text.StringBuilder sb = new System.Text.StringBuilder();
			
			sb.Append("select a.employee_id,a.gender,a.name,a.name_cn,a.password,a.dept_id as dept_id,b.dept_name as dept_name,a.position,c.position_name as position_name,a.idcardno,");
			sb.Append("a.idaddress,a.tel,a.mobile,a.email,a.address,a.postcode,a.educate_level,a.educate_school,a.cert,a.remark,");
			sb.Append("a.createby,a.createon,a.modifyby,a.modifyon,a.bank,a.account,a.start_date,a.end_date,a.shake_down");
			sb.Append(" from basic_employee a ");
			sb.Append(" left join basic_department b on a.dept_id = b.dept_id ");
			sb.Append(" left join p_position c on a.position = c.position_id ");
			sb.Append(" order by employee_id");
			this.InitialGrid(sb.ToString());
			priToolBar1.setCurrentForm = this;
			strPK = "employee_id";
			strTable = "basic_employee";
			priToolBar1.Initial(strTable,strPK,sb.ToString());

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
			string sql = "select DEPT_ID,DEPT_ID+' '+DEPT_NAME as DEPT_NAME from basic_department order by DEPT_ID";
			DataTable dt = TJSystem.Public.PublicStatic.db.GetDataTable(sql);
			dr = dt.NewRow() ;
			dr[0] = "" ;
			dr[1] = "" ;
			dt.Rows.InsertAt(dr,0) ;
			dtcpy = dt.Copy();
			this.priComboBox1.DataSource = dtcpy.DefaultView;
			this.priComboBox1.ValueMember = "DEPT_ID";
			this.priComboBox1.DisplayMember = "DEPT_NAME";

			sql = "select POSITION_ID,POSITION_ID+' '+POSITION_NAME as POSITION_NAME from p_position order by POSITION_ID";
			dt = TJSystem.Public.PublicStatic.db.GetDataTable(sql);
			dr = dt.NewRow() ;
			dr[0] = "" ;
			dr[1] = "" ;
			dt.Rows.InsertAt(dr,0) ;
			dtcpy = dt.Copy();
			this.priComboBox2.DataSource = dtcpy.DefaultView;
			this.priComboBox2.ValueMember = "POSITION_ID";
			this.priComboBox2.DisplayMember = "POSITION_NAME";
		}


		private void InitialGrid(string sql)
		{			
			DataTable dt = TJSystem.Public.PublicStatic.db.GetDataTable(sql);
			dt.TableName = "basic_employee";
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(frmSysEmployee));
			this.panel1 = new System.Windows.Forms.Panel();
			this.label1 = new System.Windows.Forms.Label();
			this.panel2 = new System.Windows.Forms.Panel();
			this.panel4 = new System.Windows.Forms.Panel();
			this.priComboBox2 = new TJSystem.Classes.PriComboBox();
			this.label29 = new System.Windows.Forms.Label();
			this.priTextBox25 = new TJSystem.Classes.PriTextBox();
			this.priTextBox4 = new TJSystem.Classes.PriTextBox();
			this.priComboBox1 = new TJSystem.Classes.PriComboBox();
			this.label24 = new System.Windows.Forms.Label();
			this.priTextBox20 = new TJSystem.Classes.PriTextBox();
			this.label25 = new System.Windows.Forms.Label();
			this.priTextBox21 = new TJSystem.Classes.PriTextBox();
			this.label26 = new System.Windows.Forms.Label();
			this.priTextBox22 = new TJSystem.Classes.PriTextBox();
			this.label27 = new System.Windows.Forms.Label();
			this.label28 = new System.Windows.Forms.Label();
			this.priTextBox23 = new TJSystem.Classes.PriTextBox();
			this.priTextBox24 = new TJSystem.Classes.PriTextBox();
			this.label22 = new System.Windows.Forms.Label();
			this.priTextBox18 = new TJSystem.Classes.PriTextBox();
			this.label23 = new System.Windows.Forms.Label();
			this.priTextBox19 = new TJSystem.Classes.PriTextBox();
			this.label21 = new System.Windows.Forms.Label();
			this.priTextBox17 = new TJSystem.Classes.PriTextBox();
			this.label19 = new System.Windows.Forms.Label();
			this.priTextBox15 = new TJSystem.Classes.PriTextBox();
			this.label20 = new System.Windows.Forms.Label();
			this.priTextBox16 = new TJSystem.Classes.PriTextBox();
			this.label18 = new System.Windows.Forms.Label();
			this.priTextBox14 = new TJSystem.Classes.PriTextBox();
			this.label16 = new System.Windows.Forms.Label();
			this.priTextBox12 = new TJSystem.Classes.PriTextBox();
			this.label17 = new System.Windows.Forms.Label();
			this.priTextBox13 = new TJSystem.Classes.PriTextBox();
			this.label15 = new System.Windows.Forms.Label();
			this.priTextBox11 = new TJSystem.Classes.PriTextBox();
			this.label14 = new System.Windows.Forms.Label();
			this.label13 = new System.Windows.Forms.Label();
			this.priTextBox10 = new TJSystem.Classes.PriTextBox();
			this.label12 = new System.Windows.Forms.Label();
			this.priTextBox9 = new TJSystem.Classes.PriTextBox();
			this.label11 = new System.Windows.Forms.Label();
			this.priTextBox8 = new TJSystem.Classes.PriTextBox();
			this.label10 = new System.Windows.Forms.Label();
			this.priTextBox7 = new TJSystem.Classes.PriTextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.priTextBox6 = new TJSystem.Classes.PriTextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.comboBox1 = new TJSystem.Classes.PriComboBox();
			this.textBox1 = new TJSystem.Classes.PriTextBox();
			this.priTextBox2 = new TJSystem.Classes.PriTextBox();
			this.priTextBox3 = new TJSystem.Classes.PriTextBox();
			this.dataGrid1 = new System.Windows.Forms.DataGrid();
			this.dataGridTableStyle1 = new System.Windows.Forms.DataGridTableStyle();
			this.employee_id = new System.Windows.Forms.DataGridTextBoxColumn();
			this.name = new System.Windows.Forms.DataGridTextBoxColumn();
			this.name_cn = new System.Windows.Forms.DataGridTextBoxColumn();
			this.Gender = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dept_name = new System.Windows.Forms.DataGridTextBoxColumn();
			this.position_name = new System.Windows.Forms.DataGridTextBoxColumn();
			this.start_date = new System.Windows.Forms.DataGridTextBoxColumn();
			this.end_date = new System.Windows.Forms.DataGridTextBoxColumn();
			this.idcardno = new System.Windows.Forms.DataGridTextBoxColumn();
			this.password = new System.Windows.Forms.DataGridTextBoxColumn();
			this.idaddress = new System.Windows.Forms.DataGridTextBoxColumn();
			this.tel = new System.Windows.Forms.DataGridTextBoxColumn();
			this.shake_down = new System.Windows.Forms.DataGridTextBoxColumn();
			this.mobile = new System.Windows.Forms.DataGridTextBoxColumn();
			this.email = new System.Windows.Forms.DataGridTextBoxColumn();
			this.postcode = new System.Windows.Forms.DataGridTextBoxColumn();
			this.address = new System.Windows.Forms.DataGridTextBoxColumn();
			this.educate_level = new System.Windows.Forms.DataGridTextBoxColumn();
			this.educate_school = new System.Windows.Forms.DataGridTextBoxColumn();
			this.cert = new System.Windows.Forms.DataGridTextBoxColumn();
			this.bank = new System.Windows.Forms.DataGridTextBoxColumn();
			this.account = new System.Windows.Forms.DataGridTextBoxColumn();
			this.remark = new System.Windows.Forms.DataGridTextBoxColumn();
			this.createby = new System.Windows.Forms.DataGridTextBoxColumn();
			this.createon = new System.Windows.Forms.DataGridTextBoxColumn();
			this.modifyby = new System.Windows.Forms.DataGridTextBoxColumn();
			this.modifyon = new System.Windows.Forms.DataGridTextBoxColumn();
			this.priTextBox1 = new TJSystem.Classes.PriTextBox();
			this.panel3 = new System.Windows.Forms.Panel();
			this.priToolBar1 = new TJSystem.UC.PriToolBar();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			this.panel4.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).BeginInit();
			this.panel3.SuspendLayout();
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
			this.panel1.TabIndex = 0;
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
			this.label1.Text = "职员管理";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// panel2
			// 
			this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
			this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.panel2.Controls.Add(this.panel4);
			this.panel2.Controls.Add(this.dataGrid1);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel2.Location = new System.Drawing.Point(0, 48);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(792, 518);
			this.panel2.TabIndex = 1;
			// 
			// panel4
			// 
			this.panel4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel4.BackgroundImage")));
			this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.panel4.Controls.Add(this.priComboBox2);
			this.panel4.Controls.Add(this.label29);
			this.panel4.Controls.Add(this.priTextBox25);
			this.panel4.Controls.Add(this.priTextBox4);
			this.panel4.Controls.Add(this.priComboBox1);
			this.panel4.Controls.Add(this.label24);
			this.panel4.Controls.Add(this.priTextBox20);
			this.panel4.Controls.Add(this.label25);
			this.panel4.Controls.Add(this.priTextBox21);
			this.panel4.Controls.Add(this.label26);
			this.panel4.Controls.Add(this.priTextBox22);
			this.panel4.Controls.Add(this.label27);
			this.panel4.Controls.Add(this.label28);
			this.panel4.Controls.Add(this.priTextBox23);
			this.panel4.Controls.Add(this.priTextBox24);
			this.panel4.Controls.Add(this.label22);
			this.panel4.Controls.Add(this.priTextBox18);
			this.panel4.Controls.Add(this.label23);
			this.panel4.Controls.Add(this.priTextBox19);
			this.panel4.Controls.Add(this.label21);
			this.panel4.Controls.Add(this.priTextBox17);
			this.panel4.Controls.Add(this.label19);
			this.panel4.Controls.Add(this.priTextBox15);
			this.panel4.Controls.Add(this.label20);
			this.panel4.Controls.Add(this.priTextBox16);
			this.panel4.Controls.Add(this.label18);
			this.panel4.Controls.Add(this.priTextBox14);
			this.panel4.Controls.Add(this.label16);
			this.panel4.Controls.Add(this.priTextBox12);
			this.panel4.Controls.Add(this.label17);
			this.panel4.Controls.Add(this.priTextBox13);
			this.panel4.Controls.Add(this.label15);
			this.panel4.Controls.Add(this.priTextBox11);
			this.panel4.Controls.Add(this.label14);
			this.panel4.Controls.Add(this.label13);
			this.panel4.Controls.Add(this.priTextBox10);
			this.panel4.Controls.Add(this.label12);
			this.panel4.Controls.Add(this.priTextBox9);
			this.panel4.Controls.Add(this.label11);
			this.panel4.Controls.Add(this.priTextBox8);
			this.panel4.Controls.Add(this.label10);
			this.panel4.Controls.Add(this.priTextBox7);
			this.panel4.Controls.Add(this.label6);
			this.panel4.Controls.Add(this.label7);
			this.panel4.Controls.Add(this.label8);
			this.panel4.Controls.Add(this.label9);
			this.panel4.Controls.Add(this.priTextBox6);
			this.panel4.Controls.Add(this.label5);
			this.panel4.Controls.Add(this.label4);
			this.panel4.Controls.Add(this.label3);
			this.panel4.Controls.Add(this.label2);
			this.panel4.Controls.Add(this.comboBox1);
			this.panel4.Controls.Add(this.textBox1);
			this.panel4.Controls.Add(this.priTextBox2);
			this.panel4.Controls.Add(this.priTextBox3);
			this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel4.Location = new System.Drawing.Point(0, 0);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(788, 320);
			this.panel4.TabIndex = 0;
			// 
			// priComboBox2
			// 
			this.priComboBox2.BackColor = System.Drawing.Color.White;
			this.priComboBox2.DataField = "position";
			this.priComboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.priComboBox2.Location = new System.Drawing.Point(264, 34);
			this.priComboBox2.Name = "priComboBox2";
			this.priComboBox2.Size = new System.Drawing.Size(112, 22);
			this.priComboBox2.TabIndex = 130;
			// 
			// label29
			// 
			this.label29.BackColor = System.Drawing.Color.Transparent;
			this.label29.Location = new System.Drawing.Point(552, 64);
			this.label29.Name = "label29";
			this.label29.Size = new System.Drawing.Size(24, 23);
			this.label29.TabIndex = 129;
			this.label29.Text = "月";
			this.label29.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// priTextBox25
			// 
			this.priTextBox25.BackColor = System.Drawing.Color.White;
			this.priTextBox25.DataField = "end_date";
			this.priTextBox25.DataType = TJSystem.Public.DataType.String;
			this.priTextBox25.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.priTextBox25.Location = new System.Drawing.Point(656, 35);
			this.priTextBox25.Name = "priTextBox25";
			this.priTextBox25.Size = new System.Drawing.Size(104, 23);
			this.priTextBox25.TabIndex = 128;
			this.priTextBox25.Text = "";
			// 
			// priTextBox4
			// 
			this.priTextBox4.BackColor = System.Drawing.Color.White;
			this.priTextBox4.DataField = "start_date";
			this.priTextBox4.DataType = TJSystem.Public.DataType.String;
			this.priTextBox4.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.priTextBox4.Location = new System.Drawing.Point(472, 35);
			this.priTextBox4.Name = "priTextBox4";
			this.priTextBox4.Size = new System.Drawing.Size(104, 23);
			this.priTextBox4.TabIndex = 127;
			this.priTextBox4.Text = "";
			// 
			// priComboBox1
			// 
			this.priComboBox1.BackColor = System.Drawing.Color.White;
			this.priComboBox1.DataField = "dept_id";
			this.priComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.priComboBox1.Location = new System.Drawing.Point(88, 35);
			this.priComboBox1.Name = "priComboBox1";
			this.priComboBox1.Size = new System.Drawing.Size(104, 22);
			this.priComboBox1.TabIndex = 126;
			// 
			// label24
			// 
			this.label24.BackColor = System.Drawing.Color.Transparent;
			this.label24.Location = new System.Drawing.Point(584, 283);
			this.label24.Name = "label24";
			this.label24.Size = new System.Drawing.Size(64, 23);
			this.label24.TabIndex = 124;
			this.label24.Text = "修改时间";
			this.label24.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// priTextBox20
			// 
			this.priTextBox20.BackColor = System.Drawing.Color.White;
			this.priTextBox20.DataField = "modifyon";
			this.priTextBox20.DataType = TJSystem.Public.DataType.String;
			this.priTextBox20.Enabled = false;
			this.priTextBox20.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.priTextBox20.Location = new System.Drawing.Point(656, 283);
			this.priTextBox20.Name = "priTextBox20";
			this.priTextBox20.Size = new System.Drawing.Size(104, 23);
			this.priTextBox20.TabIndex = 123;
			this.priTextBox20.Text = "";
			// 
			// label25
			// 
			this.label25.BackColor = System.Drawing.Color.Transparent;
			this.label25.Location = new System.Drawing.Point(208, 283);
			this.label25.Name = "label25";
			this.label25.Size = new System.Drawing.Size(64, 23);
			this.label25.TabIndex = 122;
			this.label25.Text = "创建时间";
			this.label25.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// priTextBox21
			// 
			this.priTextBox21.BackColor = System.Drawing.Color.White;
			this.priTextBox21.DataField = "createon";
			this.priTextBox21.DataType = TJSystem.Public.DataType.String;
			this.priTextBox21.Enabled = false;
			this.priTextBox21.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.priTextBox21.Location = new System.Drawing.Point(280, 283);
			this.priTextBox21.Name = "priTextBox21";
			this.priTextBox21.Size = new System.Drawing.Size(96, 23);
			this.priTextBox21.TabIndex = 121;
			this.priTextBox21.Text = "";
			// 
			// label26
			// 
			this.label26.BackColor = System.Drawing.Color.Transparent;
			this.label26.Location = new System.Drawing.Point(392, 283);
			this.label26.Name = "label26";
			this.label26.Size = new System.Drawing.Size(80, 23);
			this.label26.TabIndex = 120;
			this.label26.Text = "最后修改者";
			this.label26.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// priTextBox22
			// 
			this.priTextBox22.BackColor = System.Drawing.Color.White;
			this.priTextBox22.DataField = "remark";
			this.priTextBox22.DataType = TJSystem.Public.DataType.String;
			this.priTextBox22.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.priTextBox22.Location = new System.Drawing.Point(88, 224);
			this.priTextBox22.Multiline = true;
			this.priTextBox22.Name = "priTextBox22";
			this.priTextBox22.Size = new System.Drawing.Size(672, 56);
			this.priTextBox22.TabIndex = 125;
			this.priTextBox22.Text = "";
			// 
			// label27
			// 
			this.label27.BackColor = System.Drawing.Color.Transparent;
			this.label27.Location = new System.Drawing.Point(0, 283);
			this.label27.Name = "label27";
			this.label27.Size = new System.Drawing.Size(80, 23);
			this.label27.TabIndex = 119;
			this.label27.Text = "创建者";
			this.label27.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label28
			// 
			this.label28.BackColor = System.Drawing.Color.Transparent;
			this.label28.Location = new System.Drawing.Point(0, 224);
			this.label28.Name = "label28";
			this.label28.Size = new System.Drawing.Size(80, 23);
			this.label28.TabIndex = 118;
			this.label28.Text = "工作描述";
			this.label28.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// priTextBox23
			// 
			this.priTextBox23.BackColor = System.Drawing.Color.White;
			this.priTextBox23.DataField = "createBy";
			this.priTextBox23.DataType = TJSystem.Public.DataType.String;
			this.priTextBox23.Enabled = false;
			this.priTextBox23.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.priTextBox23.Location = new System.Drawing.Point(88, 283);
			this.priTextBox23.Name = "priTextBox23";
			this.priTextBox23.Size = new System.Drawing.Size(96, 23);
			this.priTextBox23.TabIndex = 117;
			this.priTextBox23.Text = "";
			// 
			// priTextBox24
			// 
			this.priTextBox24.BackColor = System.Drawing.Color.White;
			this.priTextBox24.DataField = "modifyBy";
			this.priTextBox24.DataType = TJSystem.Public.DataType.String;
			this.priTextBox24.Enabled = false;
			this.priTextBox24.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.priTextBox24.Location = new System.Drawing.Point(480, 283);
			this.priTextBox24.Name = "priTextBox24";
			this.priTextBox24.Size = new System.Drawing.Size(96, 23);
			this.priTextBox24.TabIndex = 116;
			this.priTextBox24.Text = "";
			// 
			// label22
			// 
			this.label22.BackColor = System.Drawing.Color.Transparent;
			this.label22.Location = new System.Drawing.Point(408, 197);
			this.label22.Name = "label22";
			this.label22.Size = new System.Drawing.Size(56, 23);
			this.label22.TabIndex = 45;
			this.label22.Text = "账号";
			this.label22.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// priTextBox18
			// 
			this.priTextBox18.BackColor = System.Drawing.Color.White;
			this.priTextBox18.DataField = "account";
			this.priTextBox18.DataType = TJSystem.Public.DataType.String;
			this.priTextBox18.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.priTextBox18.Location = new System.Drawing.Point(472, 197);
			this.priTextBox18.Name = "priTextBox18";
			this.priTextBox18.Size = new System.Drawing.Size(288, 23);
			this.priTextBox18.TabIndex = 44;
			this.priTextBox18.Text = "";
			// 
			// label23
			// 
			this.label23.BackColor = System.Drawing.Color.Transparent;
			this.label23.Location = new System.Drawing.Point(16, 197);
			this.label23.Name = "label23";
			this.label23.Size = new System.Drawing.Size(64, 23);
			this.label23.TabIndex = 43;
			this.label23.Text = "开户行";
			this.label23.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// priTextBox19
			// 
			this.priTextBox19.BackColor = System.Drawing.Color.White;
			this.priTextBox19.DataField = "bank";
			this.priTextBox19.DataType = TJSystem.Public.DataType.String;
			this.priTextBox19.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.priTextBox19.Location = new System.Drawing.Point(88, 197);
			this.priTextBox19.Name = "priTextBox19";
			this.priTextBox19.Size = new System.Drawing.Size(288, 23);
			this.priTextBox19.TabIndex = 42;
			this.priTextBox19.Text = "";
			// 
			// label21
			// 
			this.label21.BackColor = System.Drawing.Color.Transparent;
			this.label21.Location = new System.Drawing.Point(480, 170);
			this.label21.Name = "label21";
			this.label21.Size = new System.Drawing.Size(64, 23);
			this.label21.TabIndex = 41;
			this.label21.Text = "毕业院校";
			this.label21.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// priTextBox17
			// 
			this.priTextBox17.BackColor = System.Drawing.Color.White;
			this.priTextBox17.DataField = "educate_school";
			this.priTextBox17.DataType = TJSystem.Public.DataType.String;
			this.priTextBox17.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.priTextBox17.Location = new System.Drawing.Point(552, 170);
			this.priTextBox17.Name = "priTextBox17";
			this.priTextBox17.Size = new System.Drawing.Size(208, 23);
			this.priTextBox17.TabIndex = 40;
			this.priTextBox17.Text = "";
			// 
			// label19
			// 
			this.label19.BackColor = System.Drawing.Color.Transparent;
			this.label19.Location = new System.Drawing.Point(200, 170);
			this.label19.Name = "label19";
			this.label19.Size = new System.Drawing.Size(56, 23);
			this.label19.TabIndex = 39;
			this.label19.Text = "证书";
			this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// priTextBox15
			// 
			this.priTextBox15.BackColor = System.Drawing.Color.White;
			this.priTextBox15.DataField = "cert";
			this.priTextBox15.DataType = TJSystem.Public.DataType.String;
			this.priTextBox15.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.priTextBox15.Location = new System.Drawing.Point(264, 170);
			this.priTextBox15.Name = "priTextBox15";
			this.priTextBox15.Size = new System.Drawing.Size(208, 23);
			this.priTextBox15.TabIndex = 38;
			this.priTextBox15.Text = "";
			// 
			// label20
			// 
			this.label20.BackColor = System.Drawing.Color.Transparent;
			this.label20.Location = new System.Drawing.Point(16, 170);
			this.label20.Name = "label20";
			this.label20.Size = new System.Drawing.Size(64, 23);
			this.label20.TabIndex = 37;
			this.label20.Text = "教育水平";
			this.label20.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// priTextBox16
			// 
			this.priTextBox16.BackColor = System.Drawing.Color.White;
			this.priTextBox16.DataField = "educate_level";
			this.priTextBox16.DataType = TJSystem.Public.DataType.String;
			this.priTextBox16.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.priTextBox16.Location = new System.Drawing.Point(88, 170);
			this.priTextBox16.Name = "priTextBox16";
			this.priTextBox16.Size = new System.Drawing.Size(96, 23);
			this.priTextBox16.TabIndex = 36;
			this.priTextBox16.Text = "";
			// 
			// label18
			// 
			this.label18.BackColor = System.Drawing.Color.Transparent;
			this.label18.Location = new System.Drawing.Point(0, 143);
			this.label18.Name = "label18";
			this.label18.Size = new System.Drawing.Size(80, 23);
			this.label18.TabIndex = 35;
			this.label18.Text = "家庭地址";
			this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// priTextBox14
			// 
			this.priTextBox14.BackColor = System.Drawing.Color.White;
			this.priTextBox14.DataField = "address";
			this.priTextBox14.DataType = TJSystem.Public.DataType.String;
			this.priTextBox14.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.priTextBox14.Location = new System.Drawing.Point(88, 143);
			this.priTextBox14.Name = "priTextBox14";
			this.priTextBox14.Size = new System.Drawing.Size(672, 23);
			this.priTextBox14.TabIndex = 34;
			this.priTextBox14.Text = "";
			// 
			// label16
			// 
			this.label16.BackColor = System.Drawing.Color.Transparent;
			this.label16.Location = new System.Drawing.Point(584, 116);
			this.label16.Name = "label16";
			this.label16.Size = new System.Drawing.Size(64, 23);
			this.label16.TabIndex = 33;
			this.label16.Text = "邮政编码";
			this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// priTextBox12
			// 
			this.priTextBox12.BackColor = System.Drawing.Color.White;
			this.priTextBox12.DataField = "postcode";
			this.priTextBox12.DataType = TJSystem.Public.DataType.String;
			this.priTextBox12.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.priTextBox12.Location = new System.Drawing.Point(656, 116);
			this.priTextBox12.Name = "priTextBox12";
			this.priTextBox12.Size = new System.Drawing.Size(104, 23);
			this.priTextBox12.TabIndex = 32;
			this.priTextBox12.Text = "";
			// 
			// label17
			// 
			this.label17.BackColor = System.Drawing.Color.Transparent;
			this.label17.Location = new System.Drawing.Point(400, 116);
			this.label17.Name = "label17";
			this.label17.Size = new System.Drawing.Size(64, 23);
			this.label17.TabIndex = 31;
			this.label17.Text = "电子邮件";
			this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// priTextBox13
			// 
			this.priTextBox13.BackColor = System.Drawing.Color.White;
			this.priTextBox13.DataField = "email";
			this.priTextBox13.DataType = TJSystem.Public.DataType.String;
			this.priTextBox13.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.priTextBox13.Location = new System.Drawing.Point(472, 116);
			this.priTextBox13.Name = "priTextBox13";
			this.priTextBox13.Size = new System.Drawing.Size(96, 23);
			this.priTextBox13.TabIndex = 30;
			this.priTextBox13.Text = "";
			// 
			// label15
			// 
			this.label15.BackColor = System.Drawing.Color.Transparent;
			this.label15.Location = new System.Drawing.Point(200, 116);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(56, 23);
			this.label15.TabIndex = 29;
			this.label15.Text = "手机";
			this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// priTextBox11
			// 
			this.priTextBox11.BackColor = System.Drawing.Color.White;
			this.priTextBox11.DataField = "mobile";
			this.priTextBox11.DataType = TJSystem.Public.DataType.String;
			this.priTextBox11.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.priTextBox11.Location = new System.Drawing.Point(264, 116);
			this.priTextBox11.Name = "priTextBox11";
			this.priTextBox11.Size = new System.Drawing.Size(112, 23);
			this.priTextBox11.TabIndex = 28;
			this.priTextBox11.Text = "";
			this.priTextBox11.TextChanged += new System.EventHandler(this.priTextBox11_TextChanged);
			// 
			// label14
			// 
			this.label14.BackColor = System.Drawing.Color.Transparent;
			this.label14.Location = new System.Drawing.Point(16, 116);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(64, 23);
			this.label14.TabIndex = 27;
			this.label14.Text = "电话";
			this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label13
			// 
			this.label13.BackColor = System.Drawing.Color.Transparent;
			this.label13.Location = new System.Drawing.Point(0, 89);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(80, 23);
			this.label13.TabIndex = 26;
			this.label13.Text = "身份证地址";
			this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// priTextBox10
			// 
			this.priTextBox10.BackColor = System.Drawing.Color.White;
			this.priTextBox10.DataField = "idaddress";
			this.priTextBox10.DataType = TJSystem.Public.DataType.String;
			this.priTextBox10.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.priTextBox10.Location = new System.Drawing.Point(88, 89);
			this.priTextBox10.Name = "priTextBox10";
			this.priTextBox10.Size = new System.Drawing.Size(672, 23);
			this.priTextBox10.TabIndex = 25;
			this.priTextBox10.Text = "";
			// 
			// label12
			// 
			this.label12.BackColor = System.Drawing.Color.Transparent;
			this.label12.Location = new System.Drawing.Point(592, 62);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(56, 23);
			this.label12.TabIndex = 24;
			this.label12.Text = "密码";
			this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// priTextBox9
			// 
			this.priTextBox9.BackColor = System.Drawing.Color.White;
			this.priTextBox9.DataField = "password";
			this.priTextBox9.DataType = TJSystem.Public.DataType.String;
			this.priTextBox9.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.priTextBox9.Location = new System.Drawing.Point(656, 62);
			this.priTextBox9.Name = "priTextBox9";
			this.priTextBox9.PasswordChar = '*';
			this.priTextBox9.Size = new System.Drawing.Size(104, 23);
			this.priTextBox9.TabIndex = 23;
			this.priTextBox9.Text = "";
			// 
			// label11
			// 
			this.label11.BackColor = System.Drawing.Color.Transparent;
			this.label11.Location = new System.Drawing.Point(408, 62);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(56, 23);
			this.label11.TabIndex = 22;
			this.label11.Text = "试用期";
			this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// priTextBox8
			// 
			this.priTextBox8.BackColor = System.Drawing.Color.White;
			this.priTextBox8.DataField = "shake_down";
			this.priTextBox8.DataType = TJSystem.Public.DataType.Number;
			this.priTextBox8.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.priTextBox8.Location = new System.Drawing.Point(472, 62);
			this.priTextBox8.Name = "priTextBox8";
			this.priTextBox8.Size = new System.Drawing.Size(72, 23);
			this.priTextBox8.TabIndex = 21;
			this.priTextBox8.Text = "";
			// 
			// label10
			// 
			this.label10.BackColor = System.Drawing.Color.Transparent;
			this.label10.Location = new System.Drawing.Point(0, 62);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(80, 23);
			this.label10.TabIndex = 20;
			this.label10.Text = "身份证号码";
			this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// priTextBox7
			// 
			this.priTextBox7.BackColor = System.Drawing.Color.White;
			this.priTextBox7.DataField = "idcardno";
			this.priTextBox7.DataType = TJSystem.Public.DataType.String;
			this.priTextBox7.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.priTextBox7.Location = new System.Drawing.Point(88, 62);
			this.priTextBox7.Name = "priTextBox7";
			this.priTextBox7.Size = new System.Drawing.Size(288, 23);
			this.priTextBox7.TabIndex = 19;
			this.priTextBox7.Text = "";
			// 
			// label6
			// 
			this.label6.BackColor = System.Drawing.Color.Transparent;
			this.label6.Location = new System.Drawing.Point(584, 35);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(64, 23);
			this.label6.TabIndex = 17;
			this.label6.Text = "离职日期";
			this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label7
			// 
			this.label7.BackColor = System.Drawing.Color.Transparent;
			this.label7.Location = new System.Drawing.Point(392, 35);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(72, 23);
			this.label7.TabIndex = 16;
			this.label7.Text = "就职日期";
			this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.label7.Click += new System.EventHandler(this.label7_Click);
			// 
			// label8
			// 
			this.label8.BackColor = System.Drawing.Color.Transparent;
			this.label8.ForeColor = System.Drawing.Color.Blue;
			this.label8.Location = new System.Drawing.Point(200, 35);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(56, 23);
			this.label8.TabIndex = 15;
			this.label8.Text = "职位";
			this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label9
			// 
			this.label9.BackColor = System.Drawing.Color.Transparent;
			this.label9.ForeColor = System.Drawing.Color.Blue;
			this.label9.Location = new System.Drawing.Point(16, 35);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(64, 23);
			this.label9.TabIndex = 14;
			this.label9.Text = "所属部门";
			this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// priTextBox6
			// 
			this.priTextBox6.BackColor = System.Drawing.Color.White;
			this.priTextBox6.DataField = "tel";
			this.priTextBox6.DataType = TJSystem.Public.DataType.String;
			this.priTextBox6.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.priTextBox6.Location = new System.Drawing.Point(88, 116);
			this.priTextBox6.Name = "priTextBox6";
			this.priTextBox6.Size = new System.Drawing.Size(96, 23);
			this.priTextBox6.TabIndex = 12;
			this.priTextBox6.Text = "";
			// 
			// label5
			// 
			this.label5.BackColor = System.Drawing.Color.Transparent;
			this.label5.ForeColor = System.Drawing.Color.Blue;
			this.label5.Location = new System.Drawing.Point(584, 8);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(64, 23);
			this.label5.TabIndex = 9;
			this.label5.Text = "性别";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label4
			// 
			this.label4.BackColor = System.Drawing.Color.Transparent;
			this.label4.Location = new System.Drawing.Point(408, 8);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(56, 23);
			this.label4.TabIndex = 8;
			this.label4.Text = "中文名";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label3
			// 
			this.label3.BackColor = System.Drawing.Color.Transparent;
			this.label3.Location = new System.Drawing.Point(200, 8);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(56, 23);
			this.label3.TabIndex = 7;
			this.label3.Text = "英文名";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label2
			// 
			this.label2.BackColor = System.Drawing.Color.Transparent;
			this.label2.ForeColor = System.Drawing.Color.Blue;
			this.label2.Location = new System.Drawing.Point(16, 8);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(64, 23);
			this.label2.TabIndex = 6;
			this.label2.Text = "职员代码";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// comboBox1
			// 
			this.comboBox1.BackColor = System.Drawing.Color.White;
			this.comboBox1.DataField = "Gender";
			this.comboBox1.Items.AddRange(new object[] {
														   "男",
														   "女"});
			this.comboBox1.Location = new System.Drawing.Point(656, 8);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(80, 22);
			this.comboBox1.TabIndex = 4;
			// 
			// textBox1
			// 
			this.textBox1.BackColor = System.Drawing.Color.White;
			this.textBox1.DataField = "employee_id";
			this.textBox1.DataType = TJSystem.Public.DataType.String;
			this.textBox1.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.textBox1.Location = new System.Drawing.Point(88, 8);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(104, 23);
			this.textBox1.TabIndex = 1;
			this.textBox1.Text = "";
			// 
			// priTextBox2
			// 
			this.priTextBox2.BackColor = System.Drawing.Color.White;
			this.priTextBox2.DataField = "name";
			this.priTextBox2.DataType = TJSystem.Public.DataType.String;
			this.priTextBox2.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.priTextBox2.Location = new System.Drawing.Point(264, 8);
			this.priTextBox2.Name = "priTextBox2";
			this.priTextBox2.Size = new System.Drawing.Size(112, 23);
			this.priTextBox2.TabIndex = 2;
			this.priTextBox2.Text = "";
			// 
			// priTextBox3
			// 
			this.priTextBox3.BackColor = System.Drawing.Color.White;
			this.priTextBox3.DataField = "name_cn";
			this.priTextBox3.DataType = TJSystem.Public.DataType.String;
			this.priTextBox3.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.priTextBox3.Location = new System.Drawing.Point(472, 8);
			this.priTextBox3.Name = "priTextBox3";
			this.priTextBox3.Size = new System.Drawing.Size(104, 23);
			this.priTextBox3.TabIndex = 3;
			this.priTextBox3.Text = "";
			// 
			// dataGrid1
			// 
			this.dataGrid1.AllowSorting = false;
			this.dataGrid1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.dataGrid1.BackgroundColor = System.Drawing.SystemColors.Window;
			this.dataGrid1.CaptionText = "职员管理";
			this.dataGrid1.CaptionVisible = false;
			this.dataGrid1.DataMember = "";
			this.dataGrid1.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.dataGrid1.Location = new System.Drawing.Point(0, 328);
			this.dataGrid1.Name = "dataGrid1";
			this.dataGrid1.ReadOnly = true;
			this.dataGrid1.Size = new System.Drawing.Size(784, 144);
			this.dataGrid1.TabIndex = 0;
			this.dataGrid1.TableStyles.AddRange(new System.Windows.Forms.DataGridTableStyle[] {
																								  this.dataGridTableStyle1});
			// 
			// dataGridTableStyle1
			// 
			this.dataGridTableStyle1.AllowSorting = false;
			this.dataGridTableStyle1.DataGrid = this.dataGrid1;
			this.dataGridTableStyle1.GridColumnStyles.AddRange(new System.Windows.Forms.DataGridColumnStyle[] {
																												  this.employee_id,
																												  this.name,
																												  this.name_cn,
																												  this.Gender,
																												  this.dept_name,
																												  this.position_name,
																												  this.start_date,
																												  this.end_date,
																												  this.idcardno,
																												  this.password,
																												  this.idaddress,
																												  this.tel,
																												  this.shake_down,
																												  this.mobile,
																												  this.email,
																												  this.postcode,
																												  this.address,
																												  this.educate_level,
																												  this.educate_school,
																												  this.cert,
																												  this.bank,
																												  this.account,
																												  this.remark,
																												  this.createby,
																												  this.createon,
																												  this.modifyby,
																												  this.modifyon});
			this.dataGridTableStyle1.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.dataGridTableStyle1.MappingName = "basic_employee";
			this.dataGridTableStyle1.ReadOnly = true;
			// 
			// employee_id
			// 
			this.employee_id.Format = "";
			this.employee_id.FormatInfo = null;
			this.employee_id.HeaderText = "员工编号";
			this.employee_id.MappingName = "employee_id";
			this.employee_id.NullText = "";
			this.employee_id.Width = 75;
			// 
			// name
			// 
			this.name.Format = "";
			this.name.FormatInfo = null;
			this.name.HeaderText = "英文名";
			this.name.MappingName = "name";
			this.name.NullText = "";
			this.name.Width = 75;
			// 
			// name_cn
			// 
			this.name_cn.Format = "";
			this.name_cn.FormatInfo = null;
			this.name_cn.HeaderText = "员工姓名";
			this.name_cn.MappingName = "name_cn";
			this.name_cn.NullText = "";
			this.name_cn.Width = 75;
			// 
			// Gender
			// 
			this.Gender.Format = "";
			this.Gender.FormatInfo = null;
			this.Gender.HeaderText = "性别";
			this.Gender.MappingName = "Gender";
			this.Gender.NullText = "";
			this.Gender.Width = 75;
			// 
			// dept_name
			// 
			this.dept_name.Format = "";
			this.dept_name.FormatInfo = null;
			this.dept_name.HeaderText = "所属部门";
			this.dept_name.MappingName = "dept_name";
			this.dept_name.NullText = "";
			this.dept_name.Width = 75;
			// 
			// position_name
			// 
			this.position_name.Format = "";
			this.position_name.FormatInfo = null;
			this.position_name.HeaderText = "职位";
			this.position_name.MappingName = "position_name";
			this.position_name.NullText = "";
			this.position_name.Width = 75;
			// 
			// start_date
			// 
			this.start_date.Format = "";
			this.start_date.FormatInfo = null;
			this.start_date.HeaderText = "到职日期";
			this.start_date.MappingName = "start_date";
			this.start_date.NullText = "";
			this.start_date.Width = 75;
			// 
			// end_date
			// 
			this.end_date.Format = "";
			this.end_date.FormatInfo = null;
			this.end_date.HeaderText = "离职日期";
			this.end_date.MappingName = "end_date";
			this.end_date.NullText = "";
			this.end_date.Width = 75;
			// 
			// idcardno
			// 
			this.idcardno.Format = "";
			this.idcardno.FormatInfo = null;
			this.idcardno.HeaderText = "身份证号码";
			this.idcardno.MappingName = "idcardno";
			this.idcardno.NullText = "";
			this.idcardno.Width = 75;
			// 
			// password
			// 
			this.password.Format = "";
			this.password.FormatInfo = null;
			this.password.HeaderText = "密码";
			this.password.MappingName = "password";
			this.password.NullText = "";
			this.password.Width = 75;
			// 
			// idaddress
			// 
			this.idaddress.Format = "";
			this.idaddress.FormatInfo = null;
			this.idaddress.HeaderText = "身份证地址";
			this.idaddress.MappingName = "idaddress";
			this.idaddress.NullText = "";
			this.idaddress.Width = 75;
			// 
			// tel
			// 
			this.tel.Format = "";
			this.tel.FormatInfo = null;
			this.tel.HeaderText = "电话";
			this.tel.MappingName = "tel";
			this.tel.NullText = "";
			this.tel.Width = 75;
			// 
			// shake_down
			// 
			this.shake_down.Format = "";
			this.shake_down.FormatInfo = null;
			this.shake_down.HeaderText = "试用期";
			this.shake_down.MappingName = "shake_down";
			this.shake_down.NullText = "";
			this.shake_down.Width = 75;
			// 
			// mobile
			// 
			this.mobile.Format = "";
			this.mobile.FormatInfo = null;
			this.mobile.HeaderText = "手机";
			this.mobile.MappingName = "mobile";
			this.mobile.NullText = "";
			this.mobile.Width = 75;
			// 
			// email
			// 
			this.email.Format = "";
			this.email.FormatInfo = null;
			this.email.HeaderText = "电子邮件";
			this.email.MappingName = "email";
			this.email.NullText = "";
			this.email.Width = 75;
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
			this.address.HeaderText = "家庭住址";
			this.address.MappingName = "address";
			this.address.NullText = "";
			this.address.Width = 75;
			// 
			// educate_level
			// 
			this.educate_level.Format = "";
			this.educate_level.FormatInfo = null;
			this.educate_level.HeaderText = "学历水平";
			this.educate_level.MappingName = "educate_level";
			this.educate_level.NullText = "";
			this.educate_level.Width = 75;
			// 
			// educate_school
			// 
			this.educate_school.Format = "";
			this.educate_school.FormatInfo = null;
			this.educate_school.HeaderText = "毕业院校";
			this.educate_school.MappingName = "educate_school";
			this.educate_school.NullText = "";
			this.educate_school.Width = 75;
			// 
			// cert
			// 
			this.cert.Format = "";
			this.cert.FormatInfo = null;
			this.cert.HeaderText = "证书";
			this.cert.MappingName = "cert";
			this.cert.NullText = "";
			this.cert.Width = 75;
			// 
			// bank
			// 
			this.bank.Format = "";
			this.bank.FormatInfo = null;
			this.bank.HeaderText = "开户行";
			this.bank.MappingName = "bank";
			this.bank.NullText = "";
			this.bank.Width = 75;
			// 
			// account
			// 
			this.account.Format = "";
			this.account.FormatInfo = null;
			this.account.HeaderText = "账号";
			this.account.MappingName = "account";
			this.account.NullText = "";
			this.account.Width = 75;
			// 
			// remark
			// 
			this.remark.Format = "";
			this.remark.FormatInfo = null;
			this.remark.HeaderText = "个人描述";
			this.remark.MappingName = "remark";
			this.remark.NullText = "";
			this.remark.Width = 75;
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
			// modifyon
			// 
			this.modifyon.Format = "";
			this.modifyon.FormatInfo = null;
			this.modifyon.HeaderText = "最后修改时间";
			this.modifyon.MappingName = "modifyon";
			this.modifyon.NullText = "";
			this.modifyon.Width = 75;
			// 
			// priTextBox1
			// 
			this.priTextBox1.DataField = "";
			this.priTextBox1.DataType = TJSystem.Public.DataType.String;
			this.priTextBox1.Location = new System.Drawing.Point(0, 0);
			this.priTextBox1.Name = "priTextBox1";
			this.priTextBox1.TabIndex = 0;
			this.priTextBox1.Text = "";
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
			this.panel3.TabIndex = 2;
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
			// frmSysEmployee
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(7, 16);
			this.BackColor = System.Drawing.SystemColors.ScrollBar;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.ClientSize = new System.Drawing.Size(792, 566);
			this.Controls.Add(this.panel3);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "frmSysEmployee";
			this.Text = "职员管理";
			this.panel1.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			this.panel4.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).EndInit();
			this.panel3.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		private void label7_Click(object sender, System.EventArgs e)
		{
		
		}

		private void priTextBox11_TextChanged(object sender, System.EventArgs e)
		{
		
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
				if(TJSystem.Public.PublicStatic.IsExsist(this.strTable,this.strPK,this.priToolBar1))
				{
					TJSystem.Public.PublicStatic.ShowMessage(TJSystem.Public.MessageType.Error,"已经存在该笔记录，请确认！");
					return false;
				}
			}

			if(sqltype.Equals("insert") || sqltype.Equals("update"))
			{
				if(this.priTextBox8.Text.Trim().Length == 0)
				{
					sb.Append("  请输入试用期是多久！\r\n");
					TJSystem.Public.PublicStatic.ShowMessage(TJSystem.Public.MessageType.Error, sb.ToString());
					return false;
				}
				else
				{
					if(!TJSystem.Public.PublicStatic.IsNumDouble(this.priTextBox8.Text.Trim()))
					{
						sb.Append("  试用期时间输入不正确！\r\n");
						TJSystem.Public.PublicStatic.ShowMessage(TJSystem.Public.MessageType.Error, sb.ToString());
						return false;
					}
				}
			}	
			return true;
		}

		private void AfterButtonClick(string ButtonType)
		{
			if(ButtonType.Equals("insert"))
			{
				this.priTextBox1.Enabled = true;
				this.priTextBox2.Enabled = true;
				this.priTextBox3.Enabled = true;
				this.priTextBox4.Enabled = true;
				this.priTextBox6.Enabled = true;
				this.priTextBox7.Enabled = true;
				this.priTextBox8.Enabled = true;
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
				this.priTextBox24.Enabled = true;
				this.priTextBox25.Enabled = true;
				this.comboBox1.Enabled = true;
				this.priComboBox1.Enabled = true;
				this.priComboBox2.Enabled = true;
				this.priTextBox1.Text = "";
				this.priTextBox2.Text = "";
				this.priTextBox3.Text = "";
				this.priTextBox4.Text = "";
				this.priTextBox6.Text = "";
				this.priTextBox7.Text = "";
				this.priTextBox8.Text = "";
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
				this.priTextBox24.Text = "";
				this.priTextBox25.Text = "";
				this.comboBox1.Text = "";
				this.priComboBox1.Text = "";
				this.priComboBox2.Text = "";
			}
			else if(ButtonType.Equals("update"))
			{
				this.priTextBox1.Enabled = false;
				this.priTextBox2.Enabled = true;
				this.priTextBox3.Enabled = true;
				this.priTextBox4.Enabled = true;
				this.priTextBox6.Enabled = true;
				this.priTextBox7.Enabled = true;
				this.priTextBox8.Enabled = true;
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
				this.priTextBox24.Enabled = true;
				this.priTextBox25.Enabled = true;
				this.comboBox1.Enabled = true;
				this.priComboBox1.Enabled = true;
				this.priComboBox2.Enabled = true;
			}
		}

		private void setDisable()
		{
			this.priTextBox1.Enabled = false;
			this.priTextBox2.Enabled = false;
			this.priTextBox3.Enabled = false;
			this.priTextBox4.Enabled = false;
			this.priTextBox6.Enabled = false;
			this.priTextBox7.Enabled = false;
			this.priTextBox8.Enabled = false;
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
			this.priTextBox24.Enabled = false;
			this.priTextBox25.Enabled = false;
			this.comboBox1.Enabled = false;
			this.priComboBox1.Enabled = false;
			this.priComboBox2.Enabled = false;
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
				TJSystem.Public.PublicStatic.formName = "职员管理";
			}
			base.OnClosing (e);
		}
	}
}

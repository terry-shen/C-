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
	public class frmRptOPHis : System.Windows.Forms.Form
	{
		/// <summary>
		/// 必需的设计器变量。
		/// </summary>
		private System.ComponentModel.Container components = null;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.DataGrid dataGrid1;
		private System.Windows.Forms.Panel panel4;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.DataGridTableStyle dataGridTableStyle1;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn1;
		private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn2;
		private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn3;
		private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn4;
		private TJSystem.Classes.PriDateTimePicker priDateTimePicker3;
		private TJSystem.Classes.PriDateTimePicker priDateTimePicker1;
		private System.Windows.Forms.Label label3;
		private TJSystem.Classes.PriComboBox priComboBox3;
		private TJSystem.Classes.PriComboBox priComboBox1;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label7;
		private TJSystem.Classes.XpStyleButton button1;
		private TJSystem.Classes.XpStyleButton button2;
		public static System.Windows.Forms.Form frmCurrent = null;
		private System.Windows.Forms.DataGridTextBoxColumn trans_id;
		private System.Windows.Forms.DataGridTextBoxColumn trans_type;
		private System.Windows.Forms.DataGridTextBoxColumn name_cn;
		private System.Windows.Forms.DataGridTextBoxColumn trans_PK;
		private System.Windows.Forms.DataGridTextBoxColumn taskmain;
		private System.Windows.Forms.DataGridTextBoxColumn op_sql;
		private TJSystem.Classes.PriComboBox priComboBox2;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.DataGridTextBoxColumn task_name_cn;
		private TJSystem.Classes.XpStyleButton xpStyleButton1;

		private string _statusType = null;

		public frmRptOPHis()
		{
			//
			// Windows 窗体设计器支持所必需的
			//
			InitializeComponent();
			_statusType = "sales";

			InitialFormData();
			

			TJSystem.Public.PublicStatic.setBackgroundImg(this.panel1,this.panel1.GetType().ToString(),"images\\bg.gif");
			TJSystem.Public.PublicStatic.setBackgroundImg(this.panel2,this.panel1.GetType().ToString(),"");
			TJSystem.Public.PublicStatic.setBackgroundImg(this.panel4,this.panel1.GetType().ToString(),"");

			//
			// TODO: 在 InitializeComponent 调用后添加任何构造函数代码
			//
		}

		private void InitialFormData()
		{
			DataTable dtcpy = null;
			DataRow dr = null;
			string sql = "select EMPLOYEE_ID,employee_id+' '+name_cn as NAME_CN from basic_employee order by employee_id";
			DataTable dt = TJSystem.Public.PublicStatic.db.GetDataTable(sql);
			dr = dt.NewRow() ;
			dr[0] = "ALL" ;
			dr[1] = "ALL" ;
			dt.Rows.InsertAt(dr,0) ;
			dtcpy = dt.Copy();
			this.priComboBox3.DataSource = dtcpy.DefaultView;
			this.priComboBox3.ValueMember = "EMPLOYEE_ID";
			this.priComboBox3.DisplayMember = "NAME_CN";

			sql = "select XF_CURRENTHANDLE,XF_CURRENTHANDLE+' '+XF_PROGRAMNAME as XF_PROGRAMNAME from XF_MENUTREE WHERE XF_HANDLELEVEL='1' order by XF_CURRENTHANDLE";
			dt = TJSystem.Public.PublicStatic.db.GetDataTable(sql);
			dr = dt.NewRow();
			dr[0] = "";
			dr[1] = "";
			dt.Rows.InsertAt(dr,0);
			dtcpy = dt.Copy();
			this.priComboBox2.DataSource = dtcpy.DefaultView;
			this.priComboBox2.ValueMember = "XF_CURRENTHANDLE";
			this.priComboBox2.DisplayMember = "XF_PROGRAMNAME";

			dt = new DataTable();
			dt.Columns.Add("OP_ID");
			dt.Columns.Add("OP_NAME");
			dr = dt.NewRow() ;
			dr[0] = "INSERT" ;
			dr[1] = "插入" ;
			dt.Rows.Add(dr) ;
			dr = dt.NewRow() ;
			dr[0] = "UPDATE" ;
			dr[1] = "修改" ;
			dt.Rows.Add(dr) ;
			dr = dt.NewRow() ;
			dr[0] = "DELETE" ;
			dr[1] = "删除" ;
			dt.Rows.Add(dr) ;
			dr = dt.NewRow() ;
			dr[0] = "ALL" ;
			dr[1] = "ALL" ;
			dt.Rows.InsertAt(dr,0) ;
			dtcpy = dt.Copy();
			this.priComboBox1.DataSource = dtcpy.DefaultView;
			this.priComboBox1.ValueMember = "OP_ID";
			this.priComboBox1.DisplayMember = "OP_NAME";

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

		#region Windows 窗体设计器生成的代码
		/// <summary>
		/// 设计器支持所需的方法 - 不要使用代码编辑器修改
		/// 此方法的内容。
		/// </summary>
		private void InitializeComponent()
		{
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(frmRptOPHis));
			this.panel2 = new System.Windows.Forms.Panel();
			this.dataGrid1 = new System.Windows.Forms.DataGrid();
			this.dataGridTableStyle1 = new System.Windows.Forms.DataGridTableStyle();
			this.trans_id = new System.Windows.Forms.DataGridTextBoxColumn();
			this.task_name_cn = new System.Windows.Forms.DataGridTextBoxColumn();
			this.trans_type = new System.Windows.Forms.DataGridTextBoxColumn();
			this.name_cn = new System.Windows.Forms.DataGridTextBoxColumn();
			this.trans_PK = new System.Windows.Forms.DataGridTextBoxColumn();
			this.taskmain = new System.Windows.Forms.DataGridTextBoxColumn();
			this.op_sql = new System.Windows.Forms.DataGridTextBoxColumn();
			this.panel4 = new System.Windows.Forms.Panel();
			this.priComboBox2 = new TJSystem.Classes.PriComboBox();
			this.label4 = new System.Windows.Forms.Label();
			this.button2 = new TJSystem.Classes.XpStyleButton();
			this.priComboBox3 = new TJSystem.Classes.PriComboBox();
			this.priComboBox1 = new TJSystem.Classes.PriComboBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.priDateTimePicker3 = new TJSystem.Classes.PriDateTimePicker();
			this.label2 = new System.Windows.Forms.Label();
			this.priDateTimePicker1 = new TJSystem.Classes.PriDateTimePicker();
			this.button1 = new TJSystem.Classes.XpStyleButton();
			this.xpStyleButton1 = new TJSystem.Classes.XpStyleButton();
			this.panel1 = new System.Windows.Forms.Panel();
			this.label1 = new System.Windows.Forms.Label();
			this.dataGridTextBoxColumn1 = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumn2 = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumn3 = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumn4 = new System.Windows.Forms.DataGridTextBoxColumn();
			this.panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).BeginInit();
			this.panel4.SuspendLayout();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
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
			this.panel2.Size = new System.Drawing.Size(792, 518);
			this.panel2.TabIndex = 11;
			// 
			// dataGrid1
			// 
			this.dataGrid1.AllowSorting = false;
			this.dataGrid1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.dataGrid1.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.dataGrid1.CaptionText = "销售历史记录";
			this.dataGrid1.CaptionVisible = false;
			this.dataGrid1.DataMember = "";
			this.dataGrid1.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.dataGrid1.Location = new System.Drawing.Point(0, 96);
			this.dataGrid1.Name = "dataGrid1";
			this.dataGrid1.ReadOnly = true;
			this.dataGrid1.Size = new System.Drawing.Size(784, 416);
			this.dataGrid1.TabIndex = 1;
			this.dataGrid1.TableStyles.AddRange(new System.Windows.Forms.DataGridTableStyle[] {
																								  this.dataGridTableStyle1});
			// 
			// dataGridTableStyle1
			// 
			this.dataGridTableStyle1.AllowSorting = false;
			this.dataGridTableStyle1.DataGrid = this.dataGrid1;
			this.dataGridTableStyle1.GridColumnStyles.AddRange(new System.Windows.Forms.DataGridColumnStyle[] {
																												  this.trans_id,
																												  this.task_name_cn,
																												  this.trans_type,
																												  this.name_cn,
																												  this.trans_PK,
																												  this.taskmain,
																												  this.op_sql});
			this.dataGridTableStyle1.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.dataGridTableStyle1.MappingName = "xf_transition";
			this.dataGridTableStyle1.ReadOnly = true;
			// 
			// trans_id
			// 
			this.trans_id.Format = "";
			this.trans_id.FormatInfo = null;
			this.trans_id.HeaderText = "操作时间";
			this.trans_id.MappingName = "trans_id";
			this.trans_id.NullText = "";
			this.trans_id.Width = 150;
			// 
			// task_name_cn
			// 
			this.task_name_cn.Format = "";
			this.task_name_cn.FormatInfo = null;
			this.task_name_cn.HeaderText = "作业名称";
			this.task_name_cn.MappingName = "task_name_cn";
			this.task_name_cn.NullText = "";
			this.task_name_cn.Width = 75;
			// 
			// trans_type
			// 
			this.trans_type.Format = "";
			this.trans_type.FormatInfo = null;
			this.trans_type.HeaderText = "操作类型";
			this.trans_type.MappingName = "trans_type";
			this.trans_type.NullText = "";
			this.trans_type.Width = 75;
			// 
			// name_cn
			// 
			this.name_cn.Format = "";
			this.name_cn.FormatInfo = null;
			this.name_cn.HeaderText = "操作者";
			this.name_cn.MappingName = "name_cn";
			this.name_cn.NullText = "";
			this.name_cn.Width = 150;
			// 
			// trans_PK
			// 
			this.trans_PK.Format = "";
			this.trans_PK.FormatInfo = null;
			this.trans_PK.HeaderText = "操作关键字";
			this.trans_PK.MappingName = "trans_PK";
			this.trans_PK.NullText = "";
			this.trans_PK.Width = 75;
			// 
			// taskmain
			// 
			this.taskmain.Format = "";
			this.taskmain.FormatInfo = null;
			this.taskmain.HeaderText = "操作对象";
			this.taskmain.MappingName = "taskmain";
			this.taskmain.NullText = "";
			this.taskmain.Width = 75;
			// 
			// op_sql
			// 
			this.op_sql.Format = "";
			this.op_sql.FormatInfo = null;
			this.op_sql.HeaderText = "操作内容";
			this.op_sql.MappingName = "op_sql";
			this.op_sql.NullText = "";
			this.op_sql.Width = 150;
			// 
			// panel4
			// 
			this.panel4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel4.BackgroundImage")));
			this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.panel4.Controls.Add(this.priComboBox2);
			this.panel4.Controls.Add(this.label4);
			this.panel4.Controls.Add(this.button2);
			this.panel4.Controls.Add(this.priComboBox3);
			this.panel4.Controls.Add(this.priComboBox1);
			this.panel4.Controls.Add(this.label5);
			this.panel4.Controls.Add(this.label7);
			this.panel4.Controls.Add(this.label3);
			this.panel4.Controls.Add(this.priDateTimePicker3);
			this.panel4.Controls.Add(this.label2);
			this.panel4.Controls.Add(this.priDateTimePicker1);
			this.panel4.Controls.Add(this.button1);
			this.panel4.Controls.Add(this.xpStyleButton1);
			this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel4.Location = new System.Drawing.Point(0, 0);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(788, 96);
			this.panel4.TabIndex = 0;
			// 
			// priComboBox2
			// 
			this.priComboBox2.BackColor = System.Drawing.Color.White;
			this.priComboBox2.DataField = "status";
			this.priComboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.priComboBox2.Location = new System.Drawing.Point(104, 64);
			this.priComboBox2.Name = "priComboBox2";
			this.priComboBox2.Size = new System.Drawing.Size(328, 21);
			this.priComboBox2.TabIndex = 222;
			// 
			// label4
			// 
			this.label4.BackColor = System.Drawing.Color.Transparent;
			this.label4.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.label4.ForeColor = System.Drawing.Color.Blue;
			this.label4.Location = new System.Drawing.Point(16, 64);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(72, 23);
			this.label4.TabIndex = 221;
			this.label4.Text = "作业名称";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(568, 56);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(75, 32);
			this.button2.TabIndex = 220;
			this.button2.Text = "打印";
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// priComboBox3
			// 
			this.priComboBox3.BackColor = System.Drawing.Color.White;
			this.priComboBox3.DataField = "Contact_id";
			this.priComboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.priComboBox3.Location = new System.Drawing.Point(104, 40);
			this.priComboBox3.Name = "priComboBox3";
			this.priComboBox3.Size = new System.Drawing.Size(120, 21);
			this.priComboBox3.TabIndex = 219;
			// 
			// priComboBox1
			// 
			this.priComboBox1.BackColor = System.Drawing.Color.White;
			this.priComboBox1.DataField = "status";
			this.priComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.priComboBox1.Location = new System.Drawing.Point(312, 40);
			this.priComboBox1.Name = "priComboBox1";
			this.priComboBox1.Size = new System.Drawing.Size(120, 21);
			this.priComboBox1.TabIndex = 218;
			// 
			// label5
			// 
			this.label5.BackColor = System.Drawing.Color.Transparent;
			this.label5.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.label5.ForeColor = System.Drawing.Color.Blue;
			this.label5.Location = new System.Drawing.Point(256, 40);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(48, 23);
			this.label5.TabIndex = 217;
			this.label5.Text = "状态";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label7
			// 
			this.label7.BackColor = System.Drawing.Color.Transparent;
			this.label7.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.label7.Location = new System.Drawing.Point(16, 40);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(80, 23);
			this.label7.TabIndex = 216;
			this.label7.Text = "销售人员";
			this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label3
			// 
			this.label3.BackColor = System.Drawing.Color.Transparent;
			this.label3.ForeColor = System.Drawing.Color.Blue;
			this.label3.Location = new System.Drawing.Point(240, 16);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(64, 23);
			this.label3.TabIndex = 215;
			this.label3.Text = "结束日期";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// priDateTimePicker3
			// 
			this.priDateTimePicker3.CustomFormat = "yyyy-MM-dd";
			this.priDateTimePicker3.DataField = "so_date";
			this.priDateTimePicker3.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.priDateTimePicker3.Location = new System.Drawing.Point(104, 16);
			this.priDateTimePicker3.Name = "priDateTimePicker3";
			this.priDateTimePicker3.Size = new System.Drawing.Size(120, 22);
			this.priDateTimePicker3.TabIndex = 214;
			// 
			// label2
			// 
			this.label2.BackColor = System.Drawing.Color.Transparent;
			this.label2.ForeColor = System.Drawing.Color.Blue;
			this.label2.Location = new System.Drawing.Point(16, 16);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(80, 23);
			this.label2.TabIndex = 16;
			this.label2.Text = "起始日期";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// priDateTimePicker1
			// 
			this.priDateTimePicker1.CustomFormat = "yyyy-MM-dd";
			this.priDateTimePicker1.DataField = "so_date";
			this.priDateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.priDateTimePicker1.Location = new System.Drawing.Point(312, 16);
			this.priDateTimePicker1.Name = "priDateTimePicker1";
			this.priDateTimePicker1.Size = new System.Drawing.Size(120, 22);
			this.priDateTimePicker1.TabIndex = 214;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(472, 56);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 32);
			this.button1.TabIndex = 1;
			this.button1.Text = "查询";
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// xpStyleButton1
			// 
			this.xpStyleButton1.Location = new System.Drawing.Point(664, 56);
			this.xpStyleButton1.Name = "xpStyleButton1";
			this.xpStyleButton1.Size = new System.Drawing.Size(75, 32);
			this.xpStyleButton1.TabIndex = 1;
			this.xpStyleButton1.Text = "清除记录";
			this.xpStyleButton1.Click += new System.EventHandler(this.xpStyleButton1_Click);
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
			this.panel1.TabIndex = 10;
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
			this.label1.Text = "用户操作记录";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
			// dataGridTextBoxColumn3
			// 
			this.dataGridTextBoxColumn3.Format = "";
			this.dataGridTextBoxColumn3.FormatInfo = null;
			this.dataGridTextBoxColumn3.HeaderText = "英文名";
			this.dataGridTextBoxColumn3.MappingName = "";
			this.dataGridTextBoxColumn3.NullText = "";
			this.dataGridTextBoxColumn3.Width = 75;
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
			// frmRptOPHis
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(7, 15);
			this.ClientSize = new System.Drawing.Size(792, 566);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.Font = new System.Drawing.Font("宋体", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.Name = "frmRptOPHis";
			this.Text = "用户操作记录";
			this.panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).EndInit();
			this.panel4.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		private void button1_Click(object sender, System.EventArgs e)
		{
			System.Text.StringBuilder sb = new System.Text.StringBuilder();
			System.Text.StringBuilder sbcondition = new System.Text.StringBuilder();
			System.Data.DataTable dt = null;
			sbcondition.Append(" where 1=1");

			sbcondition.Append(" and a.trans_id >= ");
			sbcondition.Append("'");
			sbcondition.Append(this.priDateTimePicker3.Value.ToString("yyyy-MM-dd HH:mm:ss"));
			sbcondition.Append("'");

			sbcondition.Append(" and a.trans_id <= ");
			sbcondition.Append("'");
			sbcondition.Append(this.priDateTimePicker1.Value.ToString("yyyy-MM-dd HH:mm:ss"));
			sbcondition.Append("'");


			if(!this.priComboBox3.SelectedValue.ToString().Equals("ALL"))
			{
				sbcondition.Append(" and a.user_id=");
				sbcondition.Append("'");
				sbcondition.Append(this.priComboBox3.SelectedValue.ToString());
				sbcondition.Append("'");
			}
			sb.Append("select a.trans_id,a.table_name,c.task_name_cn,a.trans_type,a.user_id,b.name_cn,a.trans_PK,a.taskmain,a.op_sql  ");
			sb.Append(" from xf_transition a");
			sb.Append(" left join basic_employee b on a.user_id=b.employee_id");
			sb.Append(" left join p_tabletask c on a.table_name=c.table_name");
			sb.Append(sbcondition.ToString());
			sb.Append(" order by a.trans_id desc ");

			dt = TJSystem.Public.PublicStatic.db.GetDataTable(sb.ToString());
			dt.TableName = "xf_transition";
			this.dataGrid1.DataSource = dt.DefaultView;
		}

		private void button2_Click(object sender, System.EventArgs e)
		{
			TJSystem.Public.PublicStatic.COMExcel(this.dataGrid1);
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
				TJSystem.Public.PublicStatic.formName = "用户操作记录";
			}
			base.OnClosing (e);
		}

		private void xpStyleButton1_Click(object sender, System.EventArgs e)
		{
			System.Text.StringBuilder sb = new System.Text.StringBuilder();
			System.Text.StringBuilder sbcondition = new System.Text.StringBuilder();
			System.Data.DataTable dt = null;
			sbcondition.Append(" where 1=1");

			sbcondition.Append(" and trans_id >= ");
			sbcondition.Append("'");
			sbcondition.Append(this.priDateTimePicker3.Value.ToString("yyyy-MM-dd HH:mm:ss"));
			sbcondition.Append("'");

			sbcondition.Append(" and trans_id <= ");
			sbcondition.Append("'");
			sbcondition.Append(this.priDateTimePicker1.Value.ToString("yyyy-MM-dd HH:mm:ss"));
			sbcondition.Append("'");


			if(!this.priComboBox3.SelectedValue.ToString().Equals("ALL"))
			{
				sbcondition.Append(" and user_id=");
				sbcondition.Append("'");
				sbcondition.Append(this.priComboBox3.SelectedValue.ToString());
				sbcondition.Append("'");
			}
			sb.Append("delete  ");
			sb.Append(" from xf_transition ");
			
			sb.Append(sbcondition.ToString());

			if(MessageBox.Show("确定删除？","Info",MessageBoxButtons.YesNo,MessageBoxIcon.Question)
				== System.Windows.Forms.DialogResult.Yes)
			{
				TJSystem.Public.PublicStatic.db.ExeSql(sb.ToString());
				TJSystem.Public.PublicStatic.ShowMessage(TJSystem.Public.MessageType.Information,"记录清除成功！");
			}

//			dt = TJSystem.Public.PublicStatic.db.GetDataTable(sb.ToString());
//			dt.TableName = "xf_transition";
//			this.dataGrid1.DataSource = dt.DefaultView;
		}

	}
}

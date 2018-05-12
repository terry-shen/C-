using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace TJSystem.WorkHis
{
	/// <summary>
	/// Form1 的摘要说明。
	/// </summary>
	public class frmWorkRpt : System.Windows.Forms.Form
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
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Panel panel3;
		private TJSystem.UC.PriToolBar priToolBar1;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label1;
		public static System.Windows.Forms.Form frmCurrent = null ;
		private TJSystem.Classes.PriTextBox txt3;
		private TJSystem.Classes.PriTextBox txt1;
		private TJSystem.Classes.PriTextBox txt2;
		private TJSystem.Classes.PriDateTimePicker priDateTimePicker3;
		private TJSystem.Classes.PriDateTimePicker priDateTimePicker1;
		private System.Windows.Forms.Label label3;
		private TJSystem.Classes.PriTextBox priTextBox1;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private TJSystem.Classes.PriTextBox priTextBox2;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label9;
		private TJSystem.Classes.PriTextBox priTextBox3;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label13;
		private TJSystem.Classes.PriTextBox priTextBox4;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.Label label15;
		private TJSystem.Classes.XpStyleButton button2;
		private TJSystem.Classes.PriTextBox priTextBox6;

		private string _table = "";
		private TJSystem.Classes.PriComboBox priComboBox8;
		private System.Windows.Forms.DataGridTextBoxColumn start_time;
		private System.Windows.Forms.DataGridTextBoxColumn end_time;
		private System.Windows.Forms.DataGridTextBoxColumn items;
		private System.Windows.Forms.DataGridTextBoxColumn item_desc;
		private System.Windows.Forms.DataGridTextBoxColumn pj_code;
		private System.Windows.Forms.DataGridTextBoxColumn pre_content;
		private System.Windows.Forms.DataGridTextBoxColumn wk_hours;
		private System.Windows.Forms.DataGridTextBoxColumn wk_rate;
		private System.Windows.Forms.DataGridTextBoxColumn total_rate;
		private System.Windows.Forms.DataGridTextBoxColumn emp_id;
		private System.Windows.Forms.DataGridTextBoxColumn emp_name;
		private string _PK = "";

		public frmWorkRpt()
		{
			//
			// Windows 窗体设计器支持所必需的
			//
			InitializeComponent();

			InitialFormData();
			

			TJSystem.Public.PublicStatic.setBackgroundImg(this.panel1,this.panel1.GetType().ToString(),"images\\bg.gif");
			TJSystem.Public.PublicStatic.setBackgroundImg(this.panel2,this.panel1.GetType().ToString(),"");
			TJSystem.Public.PublicStatic.setBackgroundImg(this.panel3,this.panel1.GetType().ToString(),"");
			TJSystem.Public.PublicStatic.setBackgroundImg(this.panel4,this.panel1.GetType().ToString(),"");
			System.Text.StringBuilder sb = new System.Text.StringBuilder();
			sb.Append("select start_time,end_time,items,item_desc,pj_code,pre_content,wk_hours,wk_rate,total_rate,");
			sb.Append(" emp_id,emp_name from tj_workreport ");
			sb.Append(" where start_time >=");
			sb.Append("'");
			sb.Append(this.priDateTimePicker3.Value.ToString("yyyy-MM-dd HH:mm:ss"));
			sb.Append("'");
			sb.Append(" and end_time <=");
			sb.Append("'");
			sb.Append(this.priDateTimePicker1.Value.ToString("yyyy-MM-dd HH:mm:ss"));
			sb.Append("'");
			sb.Append(" and emp_id=");
			sb.Append("'");
			sb.Append(TJSystem.Public.PublicStatic.LoginUser);
			sb.Append("'");
			sb.Append(" order by start_time,items");
			
			priToolBar1.setCurrentForm = this;
			_PK = "start_time,items,emp_id";
			_table = "tj_workreport";
			this.InitialGrid(sb.ToString());
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

		private void InitialFormData()
		{
			this.priDateTimePicker3.Value = new DateTime(System.DateTime.Now.Year,System.DateTime.Now.Month,System.DateTime.Now.Day,8,30,0);
			this.priDateTimePicker1.Value = new DateTime(System.DateTime.Now.Year,System.DateTime.Now.Month,System.DateTime.Now.Day,17,30,0);
			this.priTextBox6.Text = TJSystem.Public.PublicStatic.LoginUserName;

			DataTable dtcpy = null;
			DataRow dr = null;
			string sql = "select EMPLOYEE_ID,EMPLOYEE_ID+' '+NAME_CN as NAME_CN from basic_employee ORDER BY EMPLOYEE_ID";
			DataTable dt = TJSystem.Public.PublicStatic.db.GetDataTable(sql);
			dr = dt.NewRow() ;
			dr[0] = "ALL" ;
			dr[1] = "ALL" ;
			dt.Rows.InsertAt(dr,0) ;
			dtcpy = dt.Copy();
			this.priComboBox8.DataSource = dtcpy.DefaultView;
			this.priComboBox8.ValueMember = "EMPLOYEE_ID";
			this.priComboBox8.DisplayMember = "NAME_CN";

			if(TJSystem.Public.PublicStatic.Priority == 100)
			{
				this.priComboBox8.Enabled = true;
				this.priComboBox8.SelectedValue = TJSystem.Public.PublicStatic.LoginUser;
			}
			else
			{
				this.priComboBox8.Enabled = false;
				this.priComboBox8.SelectedValue = TJSystem.Public.PublicStatic.LoginUser;
			}
		}

		private bool BeforeButtonClick(string sqltype)
		{
			
			if(sqltype.Equals("default"))
			{
				this.setDisable();
			}
			if(sqltype.Equals("insert"))
			{
				if(!checkFormValue(sqltype))
				{
//					MessageBox.Show(sb.ToString(),"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
					return false;
				}
			}
			return true;
		}

		/// <summary>
		/// 检查画面中的内容是否符合基本格式要求
		/// </summary>
		/// <param name="sqltype"></param>
		/// <param name="sb"></param>
		/// <returns></returns>
		private bool checkFormValue(string sqltype)
		{
			System.Text.StringBuilder sb = new System.Text.StringBuilder();
			sb.Append("数据验证错误：\r\n");
			if(sqltype.Equals("insert") || sqltype.Equals("update"))
			{
				if(sqltype.Equals("insert"))
				{
					if(TJSystem.Public.PublicStatic.IsExsist(this._table,this._PK,this.priToolBar1))
					{
						sb.Append("  数据库中已存在该记录，请确认该工作项真的未被记录！\r\n");
						TJSystem.Public.PublicStatic.ShowMessage(TJSystem.Public.MessageType.Exclamation,sb.ToString());
						return false;
					}
				}

				if(!TJSystem.Public.PublicStatic.IsNumDouble(this.txt2.Text.Trim()))
				{
					sb.Append("  工时必须填写数字！\r\n");
					TJSystem.Public.PublicStatic.ShowMessage(TJSystem.Public.MessageType.Exclamation,sb.ToString());
					return false;
				}
				if(!TJSystem.Public.PublicStatic.IsNumDouble(this.priTextBox2.Text.Trim()))
				{
					sb.Append("  完成进度必须填写数字！\r\n");
					TJSystem.Public.PublicStatic.ShowMessage(TJSystem.Public.MessageType.Exclamation,sb.ToString());
					return false;
				}
				if(!TJSystem.Public.PublicStatic.IsNumDouble(this.priTextBox3.Text.Trim()))
				{
					sb.Append("  累计进度必须填写数字！\r\n");
					TJSystem.Public.PublicStatic.ShowMessage(TJSystem.Public.MessageType.Exclamation,sb.ToString());
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
			this.priTextBox1.Enabled = false;
			this.priTextBox2.Enabled = false;
			this.priTextBox3.Enabled = false;
			this.priTextBox4.Enabled = false;
//			this.priDateTimePicker1.Enabled = false;
//			this.priDateTimePicker3.Enabled = false;			
		}

		private void AfterButtonClick(string ButtonType)
		{
			if(ButtonType.Equals("insert"))
			{
				this.txt1.Enabled = true;
				this.txt2.Enabled = true;
				this.txt3.Enabled = true;
				this.priTextBox1.Enabled = true;
				this.priTextBox2.Enabled = true;
				this.priTextBox3.Enabled = true;
				this.priTextBox4.Enabled = true;
				this.priDateTimePicker1.Enabled = true;
				this.priDateTimePicker3.Enabled = true;
				
				this.txt1.Text = "";
				this.txt2.Text = "";
				this.txt3.Text = "";
				
			}
			else if(ButtonType.Equals("update"))
			{
				this.txt3.Enabled = false;
				this.txt2.Enabled = true;
				this.txt1.Enabled = true;
				this.priTextBox1.Enabled = true;
				this.priTextBox2.Enabled = true;
				this.priTextBox3.Enabled = true;
				this.priTextBox4.Enabled = true;				
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(frmWorkRpt));
			this.dataGridTextBoxColumn2 = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumn3 = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumn1 = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumn4 = new System.Windows.Forms.DataGridTextBoxColumn();
			this.panel2 = new System.Windows.Forms.Panel();
			this.dataGrid1 = new System.Windows.Forms.DataGrid();
			this.dataGridTableStyle1 = new System.Windows.Forms.DataGridTableStyle();
			this.emp_id = new System.Windows.Forms.DataGridTextBoxColumn();
			this.emp_name = new System.Windows.Forms.DataGridTextBoxColumn();
			this.start_time = new System.Windows.Forms.DataGridTextBoxColumn();
			this.end_time = new System.Windows.Forms.DataGridTextBoxColumn();
			this.pj_code = new System.Windows.Forms.DataGridTextBoxColumn();
			this.items = new System.Windows.Forms.DataGridTextBoxColumn();
			this.item_desc = new System.Windows.Forms.DataGridTextBoxColumn();
			this.wk_hours = new System.Windows.Forms.DataGridTextBoxColumn();
			this.wk_rate = new System.Windows.Forms.DataGridTextBoxColumn();
			this.total_rate = new System.Windows.Forms.DataGridTextBoxColumn();
			this.pre_content = new System.Windows.Forms.DataGridTextBoxColumn();
			this.panel4 = new System.Windows.Forms.Panel();
			this.priComboBox8 = new TJSystem.Classes.PriComboBox();
			this.button2 = new TJSystem.Classes.XpStyleButton();
			this.label13 = new System.Windows.Forms.Label();
			this.priDateTimePicker3 = new TJSystem.Classes.PriDateTimePicker();
			this.txt3 = new TJSystem.Classes.PriTextBox();
			this.label12 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.txt1 = new TJSystem.Classes.PriTextBox();
			this.txt2 = new TJSystem.Classes.PriTextBox();
			this.priDateTimePicker1 = new TJSystem.Classes.PriDateTimePicker();
			this.label3 = new System.Windows.Forms.Label();
			this.priTextBox1 = new TJSystem.Classes.PriTextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.priTextBox2 = new TJSystem.Classes.PriTextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.priTextBox3 = new TJSystem.Classes.PriTextBox();
			this.label10 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.priTextBox4 = new TJSystem.Classes.PriTextBox();
			this.label14 = new System.Windows.Forms.Label();
			this.label15 = new System.Windows.Forms.Label();
			this.priTextBox6 = new TJSystem.Classes.PriTextBox();
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
			this.panel2.Size = new System.Drawing.Size(792, 478);
			this.panel2.TabIndex = 8;
			this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
			// 
			// dataGrid1
			// 
			this.dataGrid1.AllowSorting = false;
			this.dataGrid1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.dataGrid1.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.dataGrid1.CaptionText = "工作内容";
			this.dataGrid1.CaptionVisible = false;
			this.dataGrid1.DataMember = "";
			this.dataGrid1.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.dataGrid1.Location = new System.Drawing.Point(0, 248);
			this.dataGrid1.Name = "dataGrid1";
			this.dataGrid1.ReadOnly = true;
			this.dataGrid1.Size = new System.Drawing.Size(784, 224);
			this.dataGrid1.TabIndex = 1;
			this.dataGrid1.TableStyles.AddRange(new System.Windows.Forms.DataGridTableStyle[] {
																								  this.dataGridTableStyle1});
			// 
			// dataGridTableStyle1
			// 
			this.dataGridTableStyle1.AllowSorting = false;
			this.dataGridTableStyle1.DataGrid = this.dataGrid1;
			this.dataGridTableStyle1.GridColumnStyles.AddRange(new System.Windows.Forms.DataGridColumnStyle[] {
																												  this.emp_id,
																												  this.emp_name,
																												  this.start_time,
																												  this.end_time,
																												  this.pj_code,
																												  this.items,
																												  this.item_desc,
																												  this.wk_hours,
																												  this.wk_rate,
																												  this.total_rate,
																												  this.pre_content});
			this.dataGridTableStyle1.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.dataGridTableStyle1.MappingName = "tj_workreport";
			this.dataGridTableStyle1.ReadOnly = true;
			// 
			// emp_id
			// 
			this.emp_id.Format = "";
			this.emp_id.FormatInfo = null;
			this.emp_id.HeaderText = "记录人";
			this.emp_id.MappingName = "emp_id";
			this.emp_id.NullText = "";
			this.emp_id.Width = 75;
			// 
			// emp_name
			// 
			this.emp_name.Format = "";
			this.emp_name.FormatInfo = null;
			this.emp_name.HeaderText = "记录人名字";
			this.emp_name.MappingName = "emp_name";
			this.emp_name.NullText = "";
			this.emp_name.Width = 75;
			// 
			// start_time
			// 
			this.start_time.Format = "";
			this.start_time.FormatInfo = null;
			this.start_time.HeaderText = "开始时间";
			this.start_time.MappingName = "start_time";
			this.start_time.NullText = "";
			this.start_time.Width = 150;
			// 
			// end_time
			// 
			this.end_time.Format = "";
			this.end_time.FormatInfo = null;
			this.end_time.HeaderText = "结束时间";
			this.end_time.MappingName = "end_time";
			this.end_time.NullText = "";
			this.end_time.Width = 150;
			// 
			// pj_code
			// 
			this.pj_code.Format = "";
			this.pj_code.FormatInfo = null;
			this.pj_code.HeaderText = "项目代号";
			this.pj_code.MappingName = "pj_code";
			this.pj_code.NullText = "";
			this.pj_code.Width = 75;
			// 
			// items
			// 
			this.items.Format = "";
			this.items.FormatInfo = null;
			this.items.HeaderText = "工作事项";
			this.items.MappingName = "items";
			this.items.NullText = "";
			this.items.Width = 150;
			// 
			// item_desc
			// 
			this.item_desc.Format = "";
			this.item_desc.FormatInfo = null;
			this.item_desc.HeaderText = "内容描述";
			this.item_desc.MappingName = "item_desc";
			this.item_desc.NullText = "";
			this.item_desc.Width = 250;
			// 
			// wk_hours
			// 
			this.wk_hours.Format = "";
			this.wk_hours.FormatInfo = null;
			this.wk_hours.HeaderText = "工时";
			this.wk_hours.MappingName = "wk_hours";
			this.wk_hours.NullText = "";
			this.wk_hours.Width = 75;
			// 
			// wk_rate
			// 
			this.wk_rate.Format = "";
			this.wk_rate.FormatInfo = null;
			this.wk_rate.HeaderText = "完成进度";
			this.wk_rate.MappingName = "wk_rate";
			this.wk_rate.NullText = "";
			this.wk_rate.Width = 75;
			// 
			// total_rate
			// 
			this.total_rate.Format = "";
			this.total_rate.FormatInfo = null;
			this.total_rate.HeaderText = "累计完成进度";
			this.total_rate.MappingName = "total_rate";
			this.total_rate.NullText = "";
			this.total_rate.Width = 75;
			// 
			// pre_content
			// 
			this.pre_content.Format = "";
			this.pre_content.FormatInfo = null;
			this.pre_content.HeaderText = "预计工作内容";
			this.pre_content.MappingName = "pre_content";
			this.pre_content.NullText = "";
			this.pre_content.Width = 150;
			// 
			// panel4
			// 
			this.panel4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel4.BackgroundImage")));
			this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.panel4.Controls.Add(this.priComboBox8);
			this.panel4.Controls.Add(this.button2);
			this.panel4.Controls.Add(this.label13);
			this.panel4.Controls.Add(this.priDateTimePicker3);
			this.panel4.Controls.Add(this.txt3);
			this.panel4.Controls.Add(this.label12);
			this.panel4.Controls.Add(this.label8);
			this.panel4.Controls.Add(this.label2);
			this.panel4.Controls.Add(this.txt1);
			this.panel4.Controls.Add(this.txt2);
			this.panel4.Controls.Add(this.priDateTimePicker1);
			this.panel4.Controls.Add(this.label3);
			this.panel4.Controls.Add(this.priTextBox1);
			this.panel4.Controls.Add(this.label4);
			this.panel4.Controls.Add(this.label5);
			this.panel4.Controls.Add(this.label6);
			this.panel4.Controls.Add(this.priTextBox2);
			this.panel4.Controls.Add(this.label7);
			this.panel4.Controls.Add(this.label9);
			this.panel4.Controls.Add(this.priTextBox3);
			this.panel4.Controls.Add(this.label10);
			this.panel4.Controls.Add(this.label11);
			this.panel4.Controls.Add(this.priTextBox4);
			this.panel4.Controls.Add(this.label14);
			this.panel4.Controls.Add(this.label15);
			this.panel4.Controls.Add(this.priTextBox6);
			this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel4.Location = new System.Drawing.Point(0, 0);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(788, 248);
			this.panel4.TabIndex = 0;
			// 
			// priComboBox8
			// 
			this.priComboBox8.BackColor = System.Drawing.Color.White;
			this.priComboBox8.DataField = "emp_id";
			this.priComboBox8.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.priComboBox8.Location = new System.Drawing.Point(96, 216);
			this.priComboBox8.Name = "priComboBox8";
			this.priComboBox8.Size = new System.Drawing.Size(96, 22);
			this.priComboBox8.TabIndex = 217;
			this.priComboBox8.SelectionChangeCommitted += new System.EventHandler(this.priComboBox8_SelectionChangeCommitted);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(456, 208);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(88, 32);
			this.button2.TabIndex = 216;
			this.button2.Text = "查询";
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// label13
			// 
			this.label13.BackColor = System.Drawing.Color.Transparent;
			this.label13.Font = new System.Drawing.Font("宋体", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.label13.ForeColor = System.Drawing.Color.SlateBlue;
			this.label13.Location = new System.Drawing.Point(560, 152);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(216, 56);
			this.label13.TabIndex = 215;
			this.label13.Text = "此处填写次日或下阶段预计需要完成的工作内容，若不清楚可不用填写！";
			// 
			// priDateTimePicker3
			// 
			this.priDateTimePicker3.CustomFormat = "yyyy-MM-dd HH:mm:ss";
			this.priDateTimePicker3.DataField = "start_time";
			this.priDateTimePicker3.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.priDateTimePicker3.Location = new System.Drawing.Point(96, 8);
			this.priDateTimePicker3.Name = "priDateTimePicker3";
			this.priDateTimePicker3.Size = new System.Drawing.Size(168, 23);
			this.priDateTimePicker3.TabIndex = 214;
			// 
			// txt3
			// 
			this.txt3.BackColor = System.Drawing.Color.White;
			this.txt3.DataField = "items";
			this.txt3.DataType = TJSystem.Public.DataType.String;
			this.txt3.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.txt3.Location = new System.Drawing.Point(96, 32);
			this.txt3.Name = "txt3";
			this.txt3.Size = new System.Drawing.Size(448, 23);
			this.txt3.TabIndex = 102;
			this.txt3.Text = "";
			// 
			// label12
			// 
			this.label12.BackColor = System.Drawing.Color.Transparent;
			this.label12.ForeColor = System.Drawing.Color.Blue;
			this.label12.Location = new System.Drawing.Point(288, 8);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(80, 23);
			this.label12.TabIndex = 26;
			this.label12.Text = "结束时间";
			this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label8
			// 
			this.label8.BackColor = System.Drawing.Color.Transparent;
			this.label8.Location = new System.Drawing.Point(8, 32);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(80, 23);
			this.label8.TabIndex = 22;
			this.label8.Text = "工作事项";
			this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.label8.Click += new System.EventHandler(this.label8_Click);
			// 
			// label2
			// 
			this.label2.BackColor = System.Drawing.Color.Transparent;
			this.label2.ForeColor = System.Drawing.Color.Blue;
			this.label2.Location = new System.Drawing.Point(8, 8);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(80, 23);
			this.label2.TabIndex = 16;
			this.label2.Text = "开始时间";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txt1
			// 
			this.txt1.BackColor = System.Drawing.Color.White;
			this.txt1.DataField = "pre_content";
			this.txt1.DataType = TJSystem.Public.DataType.String;
			this.txt1.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.txt1.Location = new System.Drawing.Point(560, 32);
			this.txt1.Multiline = true;
			this.txt1.Name = "txt1";
			this.txt1.Size = new System.Drawing.Size(216, 112);
			this.txt1.TabIndex = 100;
			this.txt1.Text = "";
			// 
			// txt2
			// 
			this.txt2.BackColor = System.Drawing.Color.White;
			this.txt2.DataField = "wk_hours";
			this.txt2.DataType = TJSystem.Public.DataType.String;
			this.txt2.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.txt2.Location = new System.Drawing.Point(96, 144);
			this.txt2.Name = "txt2";
			this.txt2.Size = new System.Drawing.Size(112, 23);
			this.txt2.TabIndex = 101;
			this.txt2.Text = "";
			// 
			// priDateTimePicker1
			// 
			this.priDateTimePicker1.CustomFormat = "yyyy-MM-dd HH:mm:ss";
			this.priDateTimePicker1.DataField = "end_time";
			this.priDateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.priDateTimePicker1.Location = new System.Drawing.Point(376, 8);
			this.priDateTimePicker1.Name = "priDateTimePicker1";
			this.priDateTimePicker1.Size = new System.Drawing.Size(168, 23);
			this.priDateTimePicker1.TabIndex = 214;
			// 
			// label3
			// 
			this.label3.BackColor = System.Drawing.Color.Transparent;
			this.label3.Location = new System.Drawing.Point(8, 56);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(80, 23);
			this.label3.TabIndex = 22;
			this.label3.Text = "内容描述";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// priTextBox1
			// 
			this.priTextBox1.BackColor = System.Drawing.Color.White;
			this.priTextBox1.DataField = "item_desc";
			this.priTextBox1.DataType = TJSystem.Public.DataType.String;
			this.priTextBox1.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.priTextBox1.Location = new System.Drawing.Point(96, 56);
			this.priTextBox1.Multiline = true;
			this.priTextBox1.Name = "priTextBox1";
			this.priTextBox1.Size = new System.Drawing.Size(448, 88);
			this.priTextBox1.TabIndex = 102;
			this.priTextBox1.Text = "";
			// 
			// label4
			// 
			this.label4.BackColor = System.Drawing.Color.Transparent;
			this.label4.Location = new System.Drawing.Point(8, 144);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(80, 23);
			this.label4.TabIndex = 22;
			this.label4.Text = "工时";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label5
			// 
			this.label5.BackColor = System.Drawing.Color.Transparent;
			this.label5.Location = new System.Drawing.Point(208, 144);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(40, 23);
			this.label5.TabIndex = 22;
			this.label5.Text = "小时";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label6
			// 
			this.label6.BackColor = System.Drawing.Color.Transparent;
			this.label6.Location = new System.Drawing.Point(208, 168);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(40, 23);
			this.label6.TabIndex = 22;
			this.label6.Text = "%";
			this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// priTextBox2
			// 
			this.priTextBox2.BackColor = System.Drawing.Color.White;
			this.priTextBox2.DataField = "wk_rate";
			this.priTextBox2.DataType = TJSystem.Public.DataType.String;
			this.priTextBox2.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.priTextBox2.Location = new System.Drawing.Point(96, 168);
			this.priTextBox2.Name = "priTextBox2";
			this.priTextBox2.Size = new System.Drawing.Size(120, 23);
			this.priTextBox2.TabIndex = 101;
			this.priTextBox2.Text = "";
			// 
			// label7
			// 
			this.label7.BackColor = System.Drawing.Color.Transparent;
			this.label7.Location = new System.Drawing.Point(8, 168);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(80, 23);
			this.label7.TabIndex = 22;
			this.label7.Text = "完成进度";
			this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label9
			// 
			this.label9.BackColor = System.Drawing.Color.Transparent;
			this.label9.Location = new System.Drawing.Point(208, 192);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(40, 23);
			this.label9.TabIndex = 22;
			this.label9.Text = "%";
			this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// priTextBox3
			// 
			this.priTextBox3.BackColor = System.Drawing.Color.White;
			this.priTextBox3.DataField = "total_rate";
			this.priTextBox3.DataType = TJSystem.Public.DataType.String;
			this.priTextBox3.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.priTextBox3.Location = new System.Drawing.Point(96, 192);
			this.priTextBox3.Name = "priTextBox3";
			this.priTextBox3.Size = new System.Drawing.Size(120, 23);
			this.priTextBox3.TabIndex = 101;
			this.priTextBox3.Text = "";
			// 
			// label10
			// 
			this.label10.BackColor = System.Drawing.Color.Transparent;
			this.label10.Location = new System.Drawing.Point(8, 192);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(80, 23);
			this.label10.TabIndex = 22;
			this.label10.Text = "累计进度";
			this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label11
			// 
			this.label11.BackColor = System.Drawing.Color.Transparent;
			this.label11.Location = new System.Drawing.Point(552, 8);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(104, 23);
			this.label11.TabIndex = 22;
			this.label11.Text = "预计工作内容";
			this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// priTextBox4
			// 
			this.priTextBox4.BackColor = System.Drawing.Color.White;
			this.priTextBox4.DataField = "pj_code";
			this.priTextBox4.DataType = TJSystem.Public.DataType.String;
			this.priTextBox4.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.priTextBox4.Location = new System.Drawing.Point(424, 144);
			this.priTextBox4.Name = "priTextBox4";
			this.priTextBox4.Size = new System.Drawing.Size(120, 23);
			this.priTextBox4.TabIndex = 101;
			this.priTextBox4.Text = "";
			// 
			// label14
			// 
			this.label14.BackColor = System.Drawing.Color.Transparent;
			this.label14.Location = new System.Drawing.Point(336, 144);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(80, 23);
			this.label14.TabIndex = 22;
			this.label14.Text = "项目代号";
			this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label15
			// 
			this.label15.BackColor = System.Drawing.Color.Transparent;
			this.label15.Location = new System.Drawing.Point(8, 216);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(80, 23);
			this.label15.TabIndex = 22;
			this.label15.Text = "记录人";
			this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// priTextBox6
			// 
			this.priTextBox6.BackColor = System.Drawing.Color.White;
			this.priTextBox6.DataField = "emp_name";
			this.priTextBox6.DataType = TJSystem.Public.DataType.String;
			this.priTextBox6.Enabled = false;
			this.priTextBox6.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.priTextBox6.Location = new System.Drawing.Point(192, 216);
			this.priTextBox6.Name = "priTextBox6";
			this.priTextBox6.Size = new System.Drawing.Size(144, 23);
			this.priTextBox6.TabIndex = 101;
			this.priTextBox6.Text = "";
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
			this.panel3.TabIndex = 9;
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
			// panel1
			// 
			this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
			this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.panel1.Controls.Add(this.label1);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(792, 48);
			this.panel1.TabIndex = 7;
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
			this.label1.Text = "工作日报";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// frmWorkRpt
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(7, 16);
			this.BackColor = System.Drawing.SystemColors.ScrollBar;
			this.ClientSize = new System.Drawing.Size(792, 566);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel3);
			this.Controls.Add(this.panel1);
			this.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "frmWorkRpt";
			this.Text = "工作日报";
			this.panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).EndInit();
			this.panel4.ResumeLayout(false);
			this.panel3.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		
		
		protected override void OnClosing(CancelEventArgs e)
		{			
//			if(MessageBox.Show("确定退出？（Y/N）","确认",MessageBoxButtons.YesNo,MessageBoxIcon.Information) == System.Windows.Forms.DialogResult.No)
//			{
//				e.Cancel = true;
//			}
//			else
			{
				TJSystem.Public.PublicStatic.formClose = true;
				TJSystem.Public.PublicStatic.formName = "工作日报";
			}
			base.OnClosing (e);
		}

		private void label8_Click(object sender, System.EventArgs e)
		{
		
		}

		private void panel2_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
		{
		
		}

		private void priComboBox8_SelectionChangeCommitted(object sender, System.EventArgs e)
		{			
			string sql = "select EMPLOYEE_ID,NAME_CN from basic_employee where employee_id = '" + this.priComboBox8.SelectedValue.ToString() + "'";
			DataTable dt = TJSystem.Public.PublicStatic.db.GetDataTable(sql);
			if(dt.Rows.Count == 1)
			{
				this.priTextBox6.Text = dt.Rows[0][1].ToString();
			}
			else
			{
				this.priTextBox6.Text = "";
			}
		
		}

		private void button2_Click(object sender, System.EventArgs e)
		{
			System.Text.StringBuilder sb = new System.Text.StringBuilder();
			sb.Append("select start_time,end_time,items,item_desc,pj_code,pre_content,wk_hours,wk_rate,total_rate,");
			sb.Append(" emp_id,emp_name from tj_workreport ");
			sb.Append(" where start_time >=");
			sb.Append("'");
			sb.Append(this.priDateTimePicker3.Value.ToString("yyyy-MM-dd HH:mm:ss"));
			sb.Append("'");
			sb.Append(" and end_time <=");
			sb.Append("'");
			sb.Append(this.priDateTimePicker1.Value.ToString("yyyy-MM-dd HH:mm:ss"));
			sb.Append("'");
			if(this.priComboBox8.SelectedValue != null)
			{
				if(!this.priComboBox8.SelectedValue.ToString().ToUpper().Equals("ALL"))
				{
					sb.Append(" and emp_id=");
					sb.Append("'");
					sb.Append(this.priComboBox8.SelectedValue.ToString());
					sb.Append("'");
				}
			}
			sb.Append(" order by start_time,items");
			DataTable dt = TJSystem.Public.PublicStatic.db.GetDataTable(sb.ToString());
			dt.TableName = "tj_workreport";
			this.dataGrid1.DataSource = dt.DefaultView;
		}
	}
}

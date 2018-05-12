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
	public class frmRptStockStat : System.Windows.Forms.Form
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
		private System.Windows.Forms.DataGridTextBoxColumn so_date;
		private System.Windows.Forms.DataGridTextBoxColumn so_code;
		private System.Windows.Forms.DataGridTextBoxColumn client_name;
		private System.Windows.Forms.DataGridTextBoxColumn amount;
		private System.Windows.Forms.DataGridTextBoxColumn createby;
		private System.Windows.Forms.DataGridTextBoxColumn fobamount;
		private System.Windows.Forms.DataGridTextBoxColumn client_orderno;
		private System.Windows.Forms.DataGridTextBoxColumn status_name;
		private System.Windows.Forms.RadioButton radioButton1;
		private System.Windows.Forms.RadioButton radioButton2;
		private System.Windows.Forms.RadioButton radioButton3;

		private string _statusType = null;

		public frmRptStockStat()
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

			sql = "select STATUS_ID,STATUS_ID+' '+STATUS_NAME as STATUS_NAME from p_status where status_type = '" + this._statusType + "' order by STATUS_ID";
			dt = TJSystem.Public.PublicStatic.db.GetDataTable(sql);
			dr = dt.NewRow() ;
			dr[0] = "ALL" ;
			dr[1] = "ALL" ;
			dt.Rows.InsertAt(dr,0) ;
			dtcpy = dt.Copy();
			this.priComboBox1.DataSource = dtcpy.DefaultView;
			this.priComboBox1.ValueMember = "STATUS_ID";
			this.priComboBox1.DisplayMember = "STATUS_NAME";

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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(frmRptStockStat));
			this.panel2 = new System.Windows.Forms.Panel();
			this.dataGrid1 = new System.Windows.Forms.DataGrid();
			this.dataGridTableStyle1 = new System.Windows.Forms.DataGridTableStyle();
			this.so_date = new System.Windows.Forms.DataGridTextBoxColumn();
			this.so_code = new System.Windows.Forms.DataGridTextBoxColumn();
			this.client_orderno = new System.Windows.Forms.DataGridTextBoxColumn();
			this.client_name = new System.Windows.Forms.DataGridTextBoxColumn();
			this.amount = new System.Windows.Forms.DataGridTextBoxColumn();
			this.fobamount = new System.Windows.Forms.DataGridTextBoxColumn();
			this.createby = new System.Windows.Forms.DataGridTextBoxColumn();
			this.status_name = new System.Windows.Forms.DataGridTextBoxColumn();
			this.panel4 = new System.Windows.Forms.Panel();
			this.radioButton3 = new System.Windows.Forms.RadioButton();
			this.radioButton2 = new System.Windows.Forms.RadioButton();
			this.radioButton1 = new System.Windows.Forms.RadioButton();
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
			this.dataGrid1.Location = new System.Drawing.Point(0, 112);
			this.dataGrid1.Name = "dataGrid1";
			this.dataGrid1.ReadOnly = true;
			this.dataGrid1.Size = new System.Drawing.Size(784, 400);
			this.dataGrid1.TabIndex = 1;
			this.dataGrid1.TableStyles.AddRange(new System.Windows.Forms.DataGridTableStyle[] {
																								  this.dataGridTableStyle1});
			// 
			// dataGridTableStyle1
			// 
			this.dataGridTableStyle1.AllowSorting = false;
			this.dataGridTableStyle1.DataGrid = this.dataGrid1;
			this.dataGridTableStyle1.GridColumnStyles.AddRange(new System.Windows.Forms.DataGridColumnStyle[] {
																												  this.so_date,
																												  this.so_code,
																												  this.client_orderno,
																												  this.client_name,
																												  this.amount,
																												  this.fobamount,
																												  this.createby,
																												  this.status_name});
			this.dataGridTableStyle1.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.dataGridTableStyle1.MappingName = "sale_so_master";
			this.dataGridTableStyle1.ReadOnly = true;
			// 
			// so_date
			// 
			this.so_date.Format = "";
			this.so_date.FormatInfo = null;
			this.so_date.HeaderText = "订单开立日期";
			this.so_date.MappingName = "so_date";
			this.so_date.NullText = "";
			this.so_date.Width = 150;
			// 
			// so_code
			// 
			this.so_code.Format = "";
			this.so_code.FormatInfo = null;
			this.so_code.HeaderText = "定单号";
			this.so_code.MappingName = "so_code";
			this.so_code.NullText = "";
			this.so_code.Width = 75;
			// 
			// client_orderno
			// 
			this.client_orderno.Format = "";
			this.client_orderno.FormatInfo = null;
			this.client_orderno.HeaderText = "客户合同号";
			this.client_orderno.MappingName = "client_orderno";
			this.client_orderno.NullText = "";
			this.client_orderno.Width = 75;
			// 
			// client_name
			// 
			this.client_name.Format = "";
			this.client_name.FormatInfo = null;
			this.client_name.HeaderText = "客户";
			this.client_name.MappingName = "client_name";
			this.client_name.NullText = "";
			this.client_name.Width = 150;
			// 
			// amount
			// 
			this.amount.Format = "";
			this.amount.FormatInfo = null;
			this.amount.HeaderText = "总金额";
			this.amount.MappingName = "amount";
			this.amount.NullText = "";
			this.amount.Width = 75;
			// 
			// fobamount
			// 
			this.fobamount.Format = "";
			this.fobamount.FormatInfo = null;
			this.fobamount.HeaderText = "FON金额";
			this.fobamount.MappingName = "fobamount";
			this.fobamount.NullText = "";
			this.fobamount.Width = 75;
			// 
			// createby
			// 
			this.createby.Format = "";
			this.createby.FormatInfo = null;
			this.createby.HeaderText = "订单开立人";
			this.createby.MappingName = "createby";
			this.createby.NullText = "";
			this.createby.Width = 150;
			// 
			// status_name
			// 
			this.status_name.Format = "";
			this.status_name.FormatInfo = null;
			this.status_name.HeaderText = "状态";
			this.status_name.MappingName = "status_name";
			this.status_name.NullText = "";
			this.status_name.Width = 75;
			// 
			// panel4
			// 
			this.panel4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel4.BackgroundImage")));
			this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.panel4.Controls.Add(this.radioButton3);
			this.panel4.Controls.Add(this.radioButton2);
			this.panel4.Controls.Add(this.radioButton1);
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
			this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel4.Location = new System.Drawing.Point(0, 0);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(788, 104);
			this.panel4.TabIndex = 0;
			// 
			// radioButton3
			// 
			this.radioButton3.BackColor = System.Drawing.Color.Transparent;
			this.radioButton3.Location = new System.Drawing.Point(168, 72);
			this.radioButton3.Name = "radioButton3";
			this.radioButton3.Size = new System.Drawing.Size(56, 24);
			this.radioButton3.TabIndex = 223;
			this.radioButton3.Text = "冲抵";
			// 
			// radioButton2
			// 
			this.radioButton2.BackColor = System.Drawing.Color.Transparent;
			this.radioButton2.Location = new System.Drawing.Point(104, 72);
			this.radioButton2.Name = "radioButton2";
			this.radioButton2.Size = new System.Drawing.Size(56, 24);
			this.radioButton2.TabIndex = 222;
			this.radioButton2.Text = "出库";
			// 
			// radioButton1
			// 
			this.radioButton1.BackColor = System.Drawing.Color.Transparent;
			this.radioButton1.Checked = true;
			this.radioButton1.Location = new System.Drawing.Point(40, 72);
			this.radioButton1.Name = "radioButton1";
			this.radioButton1.Size = new System.Drawing.Size(64, 24);
			this.radioButton1.TabIndex = 221;
			this.radioButton1.TabStop = true;
			this.radioButton1.Text = "入库";
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(600, 64);
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
			this.label7.Text = "出入库人员";
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
			this.button1.Location = new System.Drawing.Point(504, 64);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 32);
			this.button1.TabIndex = 1;
			this.button1.Text = "查询";
			this.button1.Click += new System.EventHandler(this.button1_Click);
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
			this.label1.Text = "库存查询";
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
			// frmRptStockStat
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(7, 15);
			this.ClientSize = new System.Drawing.Size(792, 566);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.Font = new System.Drawing.Font("宋体", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.Name = "frmRptStockStat";
			this.Text = "库存查询";
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

			if(this.radioButton2.Checked)
			{
				sbcondition.Append(" and b.to_date >= ");
				sbcondition.Append("'");
				sbcondition.Append(this.priDateTimePicker3.Value.ToString("yyyy-MM-dd"));
				sbcondition.Append("'");

				sbcondition.Append(" and b.to_date <= ");
				sbcondition.Append("'");
				sbcondition.Append(this.priDateTimePicker1.Value.ToString("yyyy-MM-dd"));
				sbcondition.Append("'");
			}
			else if(this.radioButton1.Checked)
			{
				sbcondition.Append(" and b.to_date >= ");
				sbcondition.Append("'");
				sbcondition.Append(this.priDateTimePicker3.Value.ToString("yyyy-MM-dd"));
				sbcondition.Append("'");

				sbcondition.Append(" and b.to_date <= ");
				sbcondition.Append("'");
				sbcondition.Append(this.priDateTimePicker1.Value.ToString("yyyy-MM-dd"));
				sbcondition.Append("'");
			}

			if(!this.priComboBox1.SelectedValue.ToString().Equals("ALL"))
			{
				sbcondition.Append(" and b.status=");
				sbcondition.Append("'");
				sbcondition.Append(this.priComboBox1.SelectedValue.ToString());
				sbcondition.Append("'");
			}
			if(!this.priComboBox3.SelectedValue.ToString().Equals("ALL"))
			{
				sbcondition.Append(" and b.createby=");
				sbcondition.Append("'");
				sbcondition.Append(this.priComboBox3.SelectedValue.ToString());
				sbcondition.Append("'");
			}
			sb.Append("select c.status_name,b.createby,b.to_date,a.to_code,a.so_code,a.item_name,a.item_desc,a.item_qty,a.pack_qty");
			sb.Append(" from stock_to_detail a");
			sb.Append(" left join stock_to_master b on a.to_code=b.to_code");
			sb.Append(" left join p_status c on b.status=c.status_id and c.status_type=");
			sb.Append("'");
			sb.Append(this._statusType);
			sb.Append("'");
			sb.Append(sbcondition.ToString());
			sb.Append(" order by b.to_date");

			dt = TJSystem.Public.PublicStatic.db.GetDataTable(sb.ToString());
			dt.TableName = "stock_to_detail";
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
				TJSystem.Public.PublicStatic.formName = "库存查询";
			}
			base.OnClosing (e);
		}

	}
}

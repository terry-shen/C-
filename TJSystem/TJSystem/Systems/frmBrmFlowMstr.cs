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
	public class frmBrmFlowMstr : System.Windows.Forms.Form
	{
		
		
		/// <summary>
		/// 必需的设计器变量。

		/// </summary>
		private System.ComponentModel.Container components = null;
		private System.Windows.Forms.Panel panel3;
		private TJSystem.UC.PriToolBar priToolBar1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Panel panel4;
		private TJSystem.Classes.PriTextBox textBox1;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn1;
		private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn2;
		private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn3;
		private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn4;
		private System.Windows.Forms.DataGrid dataGrid1;
		private System.Windows.Forms.DataGridTableStyle dataGridTableStyle1;
		private System.Windows.Forms.DataGridTextBoxColumn createBy;
		private TJSystem.Classes.PriTextBox priTextBox8;
		private TJSystem.Classes.PriTextBox priTextBox11;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.Label label17;
		public static System.Windows.Forms.Form frmCurrent = null ;

		private string _table = null;
		private System.Windows.Forms.DataGridTextBoxColumn createon;
		private System.Windows.Forms.Label label3;
		private TJSystem.Classes.PriTextBox priTextBox1;
		private System.Windows.Forms.Label label4;
		private TJSystem.Classes.PriTextBox priTextBox2;
		private System.Windows.Forms.DataGridTextBoxColumn modifyBy;
		private System.Windows.Forms.DataGridTextBoxColumn flow_id;
		private System.Windows.Forms.DataGridTextBoxColumn flow_name;
		private System.Windows.Forms.DataGridTextBoxColumn modifyon;
		private TJSystem.Classes.PriComboBox priComboBox2;
		private System.Windows.Forms.Label label5;
		private TJSystem.Classes.PriComboBox priComboBox1;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label8;
		private TJSystem.Classes.PriComboBox priComboBox3;
		private System.Windows.Forms.DataGridTextBoxColumn proc_no;
		private System.Windows.Forms.DataGridTextBoxColumn proc_name;
		private System.Windows.Forms.DataGridTextBoxColumn seq_no;
		private System.Windows.Forms.DataGridTextBoxColumn FLAG_DESC;
		private string _PK = null;

		public frmBrmFlowMstr()
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

			System.Text.StringBuilder sb = new System.Text.StringBuilder();
			sb.Append("select a.flow_id,b.flow_name,a.proc_no,c.proc_name,a.seq_no,a.modifyby,a.modifyon,a.createby,a.createon,");
			sb.Append(" a.priority,case when a.priority='0' then '正常' else '关闭' end as FLAG_DESC ");
			sb.Append(" from brm_flow_mstr a");
			sb.Append(" left join brm_flow_det b on a.flow_id=b.flow_id");
			sb.Append(" left join brm_process c on a.proc_no=c.proc_no");
			
			priToolBar1.setCurrentForm = this;
			_table = "brm_flow_mstr";
			_PK = "flow_id,seq_no";
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
				this.priComboBox1.Enabled = true;
				this.priComboBox2.Enabled = true;
				this.priComboBox3.Enabled = true;
			}
			else if(sqltype.Equals("update"))
			{
				this.priComboBox1.Enabled = true;
				this.priComboBox2.Enabled = false;
				this.priComboBox3.Enabled = true;
			}

		}

		private void InitialFormData()
		{
			DataTable dtcpy = null;
			DataRow dr = null;
			string sql = "select FLOW_ID,FLOW_ID+' '+FLOW_NAME AS FLOW_NAME from brm_flow_det order by flow_id";
			DataTable dt = TJSystem.Public.PublicStatic.db.GetDataTable(sql);
//			dr = dt.NewRow() ;
//			dr[0] = "" ;
//			dr[1] = "" ;
//			dt.Rows.InsertAt(dr,0) ;
			dtcpy = dt.Copy();
			this.priComboBox2.DataSource = dtcpy.DefaultView;
			this.priComboBox2.ValueMember = "FLOW_ID";
			this.priComboBox2.DisplayMember = "FLOW_NAME";

			sql = "select PROC_NO,PROC_NO+' '+PROC_NAME AS PROC_NAME from brm_process ORDER BY PROC_NO";
			dt = TJSystem.Public.PublicStatic.db.GetDataTable(sql);
//			dr = dt.NewRow() ;
//			dr[0] = "" ;
//			dr[1] = "" ;
//			dt.Rows.InsertAt(dr,0) ;
			dtcpy = dt.Copy();
			this.priComboBox1.DataSource = dtcpy.DefaultView;
			this.priComboBox1.ValueMember = "PROC_NO";
			this.priComboBox1.DisplayMember = "PROC_NAME";

			dt = new DataTable();
			dt.Columns.Add("FLAG_ID");
			dt.Columns.Add("FLAG_DESC");
			dr = dt.NewRow();
			dr[0] = "0";
			dr[1] = "正常";
			dt.Rows.Add(dr);
			dr = dt.NewRow();
			dr[0] = "1";
			dr[1] = "关闭";
			dt.Rows.Add(dr);
			dtcpy = dt.Copy();
			this.priComboBox3.DataSource = dtcpy.DefaultView;
			this.priComboBox3.ValueMember = "FLAG_ID";
			this.priComboBox3.DisplayMember = "FLAG_DESC";
		}

		private void InitialGrid(string sql)
		{		
			DataTable dt = TJSystem.Public.PublicStatic.db.GetDataTable(sql);
			dt.TableName = this._table;
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(frmBrmFlowMstr));
			this.panel3 = new System.Windows.Forms.Panel();
			this.priToolBar1 = new TJSystem.UC.PriToolBar();
			this.panel2 = new System.Windows.Forms.Panel();
			this.dataGrid1 = new System.Windows.Forms.DataGrid();
			this.dataGridTableStyle1 = new System.Windows.Forms.DataGridTableStyle();
			this.flow_id = new System.Windows.Forms.DataGridTextBoxColumn();
			this.flow_name = new System.Windows.Forms.DataGridTextBoxColumn();
			this.seq_no = new System.Windows.Forms.DataGridTextBoxColumn();
			this.proc_no = new System.Windows.Forms.DataGridTextBoxColumn();
			this.proc_name = new System.Windows.Forms.DataGridTextBoxColumn();
			this.FLAG_DESC = new System.Windows.Forms.DataGridTextBoxColumn();
			this.createBy = new System.Windows.Forms.DataGridTextBoxColumn();
			this.createon = new System.Windows.Forms.DataGridTextBoxColumn();
			this.modifyBy = new System.Windows.Forms.DataGridTextBoxColumn();
			this.modifyon = new System.Windows.Forms.DataGridTextBoxColumn();
			this.panel4 = new System.Windows.Forms.Panel();
			this.priComboBox3 = new TJSystem.Classes.PriComboBox();
			this.label5 = new System.Windows.Forms.Label();
			this.priComboBox2 = new TJSystem.Classes.PriComboBox();
			this.label4 = new System.Windows.Forms.Label();
			this.priTextBox2 = new TJSystem.Classes.PriTextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.priTextBox1 = new TJSystem.Classes.PriTextBox();
			this.label17 = new System.Windows.Forms.Label();
			this.label15 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.priTextBox11 = new TJSystem.Classes.PriTextBox();
			this.priTextBox8 = new TJSystem.Classes.PriTextBox();
			this.textBox1 = new TJSystem.Classes.PriTextBox();
			this.priComboBox1 = new TJSystem.Classes.PriComboBox();
			this.label6 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.label1 = new System.Windows.Forms.Label();
			this.dataGridTextBoxColumn1 = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumn2 = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumn3 = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumn4 = new System.Windows.Forms.DataGridTextBoxColumn();
			this.panel3.SuspendLayout();
			this.panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).BeginInit();
			this.panel4.SuspendLayout();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
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
			this.panel3.TabIndex = 6;
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
			this.panel2.TabIndex = 5;
			// 
			// dataGrid1
			// 
			this.dataGrid1.AllowSorting = false;
			this.dataGrid1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.dataGrid1.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.dataGrid1.CaptionText = "流程管理";
			this.dataGrid1.CaptionVisible = false;
			this.dataGrid1.DataMember = "";
			this.dataGrid1.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.dataGrid1.Location = new System.Drawing.Point(0, 152);
			this.dataGrid1.Name = "dataGrid1";
			this.dataGrid1.ReadOnly = true;
			this.dataGrid1.Size = new System.Drawing.Size(784, 312);
			this.dataGrid1.TabIndex = 1;
			this.dataGrid1.TableStyles.AddRange(new System.Windows.Forms.DataGridTableStyle[] {
																								  this.dataGridTableStyle1});
			// 
			// dataGridTableStyle1
			// 
			this.dataGridTableStyle1.AllowSorting = false;
			this.dataGridTableStyle1.DataGrid = this.dataGrid1;
			this.dataGridTableStyle1.GridColumnStyles.AddRange(new System.Windows.Forms.DataGridColumnStyle[] {
																												  this.flow_id,
																												  this.flow_name,
																												  this.seq_no,
																												  this.proc_no,
																												  this.proc_name,
																												  this.FLAG_DESC,
																												  this.createBy,
																												  this.createon,
																												  this.modifyBy,
																												  this.modifyon});
			this.dataGridTableStyle1.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.dataGridTableStyle1.MappingName = "brm_flow_mstr";
			this.dataGridTableStyle1.ReadOnly = true;
			// 
			// flow_id
			// 
			this.flow_id.Format = "";
			this.flow_id.FormatInfo = null;
			this.flow_id.HeaderText = "流程编号";
			this.flow_id.MappingName = "flow_id";
			this.flow_id.NullText = "";
			this.flow_id.Width = 75;
			// 
			// flow_name
			// 
			this.flow_name.Format = "";
			this.flow_name.FormatInfo = null;
			this.flow_name.HeaderText = "流程名称";
			this.flow_name.MappingName = "flow_name";
			this.flow_name.NullText = "";
			this.flow_name.Width = 75;
			// 
			// seq_no
			// 
			this.seq_no.Format = "";
			this.seq_no.FormatInfo = null;
			this.seq_no.HeaderText = "序号";
			this.seq_no.MappingName = "seq_no";
			this.seq_no.NullText = "";
			this.seq_no.Width = 75;
			// 
			// proc_no
			// 
			this.proc_no.Format = "";
			this.proc_no.FormatInfo = null;
			this.proc_no.HeaderText = "站编号";
			this.proc_no.MappingName = "proc_no";
			this.proc_no.NullText = "";
			this.proc_no.Width = 75;
			// 
			// proc_name
			// 
			this.proc_name.Format = "";
			this.proc_name.FormatInfo = null;
			this.proc_name.HeaderText = "站名称";
			this.proc_name.MappingName = "proc_name";
			this.proc_name.NullText = "";
			this.proc_name.Width = 75;
			// 
			// FLAG_DESC
			// 
			this.FLAG_DESC.Format = "";
			this.FLAG_DESC.FormatInfo = null;
			this.FLAG_DESC.HeaderText = "标志位";
			this.FLAG_DESC.MappingName = "FLAG_DESC";
			this.FLAG_DESC.NullText = "";
			this.FLAG_DESC.Width = 75;
			// 
			// createBy
			// 
			this.createBy.Format = "";
			this.createBy.FormatInfo = null;
			this.createBy.HeaderText = "创建者";
			this.createBy.MappingName = "createBy";
			this.createBy.NullText = "";
			this.createBy.Width = 75;
			// 
			// createon
			// 
			this.createon.Format = "";
			this.createon.FormatInfo = null;
			this.createon.HeaderText = "创建时间";
			this.createon.MappingName = "createon";
			this.createon.NullText = "";
			this.createon.Width = 75;
			// 
			// modifyBy
			// 
			this.modifyBy.Format = "";
			this.modifyBy.FormatInfo = null;
			this.modifyBy.HeaderText = "最后修改时间";
			this.modifyBy.MappingName = "modifyBy";
			this.modifyBy.NullText = "";
			this.modifyBy.Width = 75;
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
			// panel4
			// 
			this.panel4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel4.BackgroundImage")));
			this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.panel4.Controls.Add(this.priComboBox3);
			this.panel4.Controls.Add(this.label5);
			this.panel4.Controls.Add(this.priComboBox2);
			this.panel4.Controls.Add(this.label4);
			this.panel4.Controls.Add(this.priTextBox2);
			this.panel4.Controls.Add(this.label3);
			this.panel4.Controls.Add(this.priTextBox1);
			this.panel4.Controls.Add(this.label17);
			this.panel4.Controls.Add(this.label15);
			this.panel4.Controls.Add(this.label2);
			this.panel4.Controls.Add(this.priTextBox11);
			this.panel4.Controls.Add(this.priTextBox8);
			this.panel4.Controls.Add(this.textBox1);
			this.panel4.Controls.Add(this.priComboBox1);
			this.panel4.Controls.Add(this.label6);
			this.panel4.Controls.Add(this.label8);
			this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel4.Location = new System.Drawing.Point(0, 0);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(788, 144);
			this.panel4.TabIndex = 0;
			// 
			// priComboBox3
			// 
			this.priComboBox3.BackColor = System.Drawing.Color.White;
			this.priComboBox3.DataField = "priority";
			this.priComboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.priComboBox3.Location = new System.Drawing.Point(352, 64);
			this.priComboBox3.Name = "priComboBox3";
			this.priComboBox3.Size = new System.Drawing.Size(120, 22);
			this.priComboBox3.TabIndex = 181;
			// 
			// label5
			// 
			this.label5.BackColor = System.Drawing.Color.Transparent;
			this.label5.ForeColor = System.Drawing.Color.Blue;
			this.label5.Location = new System.Drawing.Point(40, 16);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(80, 23);
			this.label5.TabIndex = 180;
			this.label5.Text = "流程编号";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// priComboBox2
			// 
			this.priComboBox2.BackColor = System.Drawing.Color.White;
			this.priComboBox2.DataField = "flow_id";
			this.priComboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.priComboBox2.Location = new System.Drawing.Point(128, 16);
			this.priComboBox2.Name = "priComboBox2";
			this.priComboBox2.Size = new System.Drawing.Size(344, 22);
			this.priComboBox2.TabIndex = 179;
			// 
			// label4
			// 
			this.label4.BackColor = System.Drawing.Color.Transparent;
			this.label4.Location = new System.Drawing.Point(336, 112);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(96, 23);
			this.label4.TabIndex = 36;
			this.label4.Text = "最后修改时间";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// priTextBox2
			// 
			this.priTextBox2.BackColor = System.Drawing.Color.White;
			this.priTextBox2.DataField = "modifyon";
			this.priTextBox2.DataType = TJSystem.Public.DataType.String;
			this.priTextBox2.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.priTextBox2.Location = new System.Drawing.Point(440, 112);
			this.priTextBox2.Name = "priTextBox2";
			this.priTextBox2.Size = new System.Drawing.Size(192, 23);
			this.priTextBox2.TabIndex = 35;
			this.priTextBox2.Text = "";
			// 
			// label3
			// 
			this.label3.BackColor = System.Drawing.Color.Transparent;
			this.label3.Location = new System.Drawing.Point(352, 88);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(80, 23);
			this.label3.TabIndex = 34;
			this.label3.Text = "创建时间";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// priTextBox1
			// 
			this.priTextBox1.BackColor = System.Drawing.Color.White;
			this.priTextBox1.DataField = "createon";
			this.priTextBox1.DataType = TJSystem.Public.DataType.String;
			this.priTextBox1.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.priTextBox1.Location = new System.Drawing.Point(440, 88);
			this.priTextBox1.Name = "priTextBox1";
			this.priTextBox1.Size = new System.Drawing.Size(192, 23);
			this.priTextBox1.TabIndex = 33;
			this.priTextBox1.Text = "";
			// 
			// label17
			// 
			this.label17.BackColor = System.Drawing.Color.Transparent;
			this.label17.Location = new System.Drawing.Point(40, 112);
			this.label17.Name = "label17";
			this.label17.Size = new System.Drawing.Size(80, 23);
			this.label17.TabIndex = 32;
			this.label17.Text = "最后修改者";
			this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label15
			// 
			this.label15.BackColor = System.Drawing.Color.Transparent;
			this.label15.Location = new System.Drawing.Point(40, 88);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(80, 23);
			this.label15.TabIndex = 29;
			this.label15.Text = "创建者";
			this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label2
			// 
			this.label2.BackColor = System.Drawing.Color.Transparent;
			this.label2.ForeColor = System.Drawing.Color.Blue;
			this.label2.Location = new System.Drawing.Point(40, 64);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(80, 23);
			this.label2.TabIndex = 16;
			this.label2.Text = "序号";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// priTextBox11
			// 
			this.priTextBox11.BackColor = System.Drawing.Color.White;
			this.priTextBox11.DataField = "createBy";
			this.priTextBox11.DataType = TJSystem.Public.DataType.String;
			this.priTextBox11.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.priTextBox11.Location = new System.Drawing.Point(128, 88);
			this.priTextBox11.Name = "priTextBox11";
			this.priTextBox11.Size = new System.Drawing.Size(200, 23);
			this.priTextBox11.TabIndex = 12;
			this.priTextBox11.Text = "";
			// 
			// priTextBox8
			// 
			this.priTextBox8.BackColor = System.Drawing.Color.White;
			this.priTextBox8.DataField = "modifyBy";
			this.priTextBox8.DataType = TJSystem.Public.DataType.String;
			this.priTextBox8.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.priTextBox8.Location = new System.Drawing.Point(128, 112);
			this.priTextBox8.Name = "priTextBox8";
			this.priTextBox8.Size = new System.Drawing.Size(200, 23);
			this.priTextBox8.TabIndex = 9;
			this.priTextBox8.Text = "";
			// 
			// textBox1
			// 
			this.textBox1.BackColor = System.Drawing.Color.White;
			this.textBox1.DataField = "seq_no";
			this.textBox1.DataType = TJSystem.Public.DataType.String;
			this.textBox1.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.textBox1.Location = new System.Drawing.Point(128, 64);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(120, 23);
			this.textBox1.TabIndex = 1;
			this.textBox1.Text = "";
			// 
			// priComboBox1
			// 
			this.priComboBox1.BackColor = System.Drawing.Color.White;
			this.priComboBox1.DataField = "proc_no";
			this.priComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.priComboBox1.Location = new System.Drawing.Point(128, 40);
			this.priComboBox1.Name = "priComboBox1";
			this.priComboBox1.Size = new System.Drawing.Size(344, 22);
			this.priComboBox1.TabIndex = 179;
			// 
			// label6
			// 
			this.label6.BackColor = System.Drawing.Color.Transparent;
			this.label6.ForeColor = System.Drawing.Color.Blue;
			this.label6.Location = new System.Drawing.Point(40, 40);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(80, 23);
			this.label6.TabIndex = 180;
			this.label6.Text = "站编号";
			this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label8
			// 
			this.label8.BackColor = System.Drawing.Color.Transparent;
			this.label8.ForeColor = System.Drawing.SystemColors.ControlText;
			this.label8.Location = new System.Drawing.Point(264, 64);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(80, 23);
			this.label8.TabIndex = 16;
			this.label8.Text = "标志位";
			this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
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
			this.panel1.TabIndex = 4;
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
			this.label1.Text = "流程管理";
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
			// frmBrmFlowMstr
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(7, 16);
			this.BackColor = System.Drawing.SystemColors.ScrollBar;
			this.ClientSize = new System.Drawing.Size(792, 566);
			this.Controls.Add(this.panel3);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "frmBrmFlowMstr";
			this.Text = "流程管理";
			this.Load += new System.EventHandler(this.frmBrmFlowDet_Load);
			this.panel3.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).EndInit();
			this.panel4.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		private void setDisable()
		{
			this.textBox1.Enabled = false;
			this.priTextBox1.Enabled = false;
			this.priTextBox2.Enabled = false;
			this.priTextBox8.Enabled = false;
			this.priTextBox11.Enabled = false;
			this.priComboBox1.Enabled = false;
			this.priComboBox2.Enabled = false;
			this.priComboBox3.Enabled = false;
		}

		/// <summary>
		/// 检查画面中的内容是否符合基本格式要求

		/// </summary>
		/// <param name="sqltype"></param>
		/// <returns></returns>
		private bool checkFormValue(string sqltype)
		{
			if(sqltype.Equals("insert"))
			{
				System.Text.StringBuilder sb = new System.Text.StringBuilder();
				DataTable dt = null;
				sb.Append("select seq_no from brm_flow_mstr where flow_id=");
				sb.Append("'");
				sb.Append(this.priComboBox2.SelectedValue.ToString());
				sb.Append("'");
				dt = TJSystem.Public.PublicStatic.db.GetDataTable(sb.ToString());
				if(dt.Rows.Count == 0)
				{
					this.textBox1.Text = "1";
				}
				else
				{
					this.textBox1.Text = Convert.ToString(dt.Rows.Count + 1);
				}

				if(TJSystem.Public.PublicStatic.IsExsist(_table,_PK,this.priToolBar1))
				{
					TJSystem.Public.PublicStatic.ShowMessage(TJSystem.Public.MessageType.Error,"已经存在该笔记录，请确认！");
					return false;
				}
			}

			return true;
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
				TJSystem.Public.PublicStatic.formName = "流程管理";
			}
			base.OnClosing (e);
		}

		private void frmBrmFlowDet_Load(object sender, System.EventArgs e)
		{
		
		}
		
	}
}

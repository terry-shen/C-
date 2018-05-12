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
	public class frmBrmFlowMstr1 : System.Windows.Forms.Form
	{
		
		
		/// <summary>
		/// 必需的设计器变量。

		/// </summary>
		private System.ComponentModel.Container components = null;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label1;
		public static System.Windows.Forms.Form frmCurrent = null ;

		private string _table = null;
		private TJSystem.Classes.XpStyleButton button1;
		private TJSystem.Classes.XpStyleButton xpStyleButton1;
		private TJSystem.Classes.XpStyleButton xpStyleButton2;
		private TJSystem.Classes.XpStyleButton xpStyleButton3;
		private System.Windows.Forms.DataGrid dataGrid1;
		private System.Windows.Forms.DataGrid dataGrid2;
		private System.Windows.Forms.DataGrid dataGrid3;
		private System.Windows.Forms.DataGridTableStyle dataGridTableStyle1;
		private System.Windows.Forms.DataGridTextBoxColumn flow_id;
		private System.Windows.Forms.DataGridTextBoxColumn flow_name;
		private System.Windows.Forms.DataGridTableStyle dataGridTableStyle2;
		private System.Windows.Forms.DataGridTextBoxColumn seq_no;
		private System.Windows.Forms.DataGridTextBoxColumn proc_no;
		private System.Windows.Forms.DataGridTableStyle dataGridTableStyle3;
		private System.Windows.Forms.DataGridTextBoxColumn proc_no_pro;
		private System.Windows.Forms.DataGridTextBoxColumn proc_name;
		private string _PK = null;
		private System.Windows.Forms.DataGridTextBoxColumn proc_name_mstr;
		private System.Data.DataView mdvProc = null;

		public frmBrmFlowMstr1()
		{
			//
			// Windows 窗体设计器支持所必需的

			//
			InitializeComponent();
			

			TJSystem.Public.PublicStatic.setBackgroundImg(this.panel1,this.panel1.GetType().ToString(),"images\\bg.gif");
			TJSystem.Public.PublicStatic.setBackgroundImg(this.panel2,this.panel1.GetType().ToString(),"");
			InitialFormData();

			
		}

		
		private void InitialFormData()
		{
			DataTable dt = null;
			DataView dv = null;
			DataView dvmstr = null;
			int mstrcount = 0;
			string filter = null;
			string sql = "select flow_id,flow_name from brm_flow_det order by flow_id";
			dt = TJSystem.Public.PublicStatic.db.GetDataTable(sql);
			dt.TableName = "brm_flow_det";
			this.dataGrid1.DataSource = dt.DefaultView ;

			if(dt.Rows.Count > 0)
			{
				sql = "select a.seq_no,a.proc_no,b.proc_name from brm_flow_mstr a left join brm_process b on a.proc_no=b.proc_no where a.flow_id='" + dt.Rows[0][0].ToString() + "' order by a.seq_no";
				dt = TJSystem.Public.PublicStatic.db.GetDataTable(sql);
				dt.TableName = "brm_flow_mstr";
				this.dataGrid2.DataSource = dt.DefaultView;
			}
			else
			{
				sql = "select a.seq_no,a.proc_no,b.proc_name from brm_flow_mstr a left join brm_process b on a.proc_no=b.proc_no order by a.seq_no";
				dt = TJSystem.Public.PublicStatic.db.GetDataTable(sql);
				dt.TableName = "brm_flow_mstr";
				this.dataGrid2.DataSource = dt.DefaultView;
			}
			mstrcount = dt.Rows.Count;

			sql = "select proc_no,proc_name from brm_process order by proc_no";
			dt = TJSystem.Public.PublicStatic.db.GetDataTable(sql);
			dt.TableName = "brm_process";
			dv = dt.DefaultView;
			if(mstrcount > 0)
			{
				dvmstr = (System.Data.DataView)this.dataGrid2.DataSource;
				for(int i = 0; i < mstrcount; i++)
				{
					if(i == 0)
					{
						filter = "proc_no <>'" + dvmstr[i]["proc_no"].ToString() + "' ";
					}
					filter += " and proc_no<>'" + dvmstr[i]["proc_no"].ToString() + "' ";
				}
			}
			dv.RowFilter = filter;
			this.dataGrid3.DataSource = dv;
			mdvProc = dt.DefaultView;
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(frmBrmFlowMstr1));
			this.panel2 = new System.Windows.Forms.Panel();
			this.dataGrid3 = new System.Windows.Forms.DataGrid();
			this.dataGridTableStyle3 = new System.Windows.Forms.DataGridTableStyle();
			this.proc_no_pro = new System.Windows.Forms.DataGridTextBoxColumn();
			this.proc_name = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGrid2 = new System.Windows.Forms.DataGrid();
			this.dataGridTableStyle2 = new System.Windows.Forms.DataGridTableStyle();
			this.seq_no = new System.Windows.Forms.DataGridTextBoxColumn();
			this.proc_no = new System.Windows.Forms.DataGridTextBoxColumn();
			this.proc_name_mstr = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGrid1 = new System.Windows.Forms.DataGrid();
			this.dataGridTableStyle1 = new System.Windows.Forms.DataGridTableStyle();
			this.flow_id = new System.Windows.Forms.DataGridTextBoxColumn();
			this.flow_name = new System.Windows.Forms.DataGridTextBoxColumn();
			this.xpStyleButton3 = new TJSystem.Classes.XpStyleButton();
			this.xpStyleButton2 = new TJSystem.Classes.XpStyleButton();
			this.xpStyleButton1 = new TJSystem.Classes.XpStyleButton();
			this.button1 = new TJSystem.Classes.XpStyleButton();
			this.panel1 = new System.Windows.Forms.Panel();
			this.label1 = new System.Windows.Forms.Label();
			this.panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGrid3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGrid2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).BeginInit();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel2
			// 
			this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
			this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.panel2.Controls.Add(this.dataGrid3);
			this.panel2.Controls.Add(this.dataGrid2);
			this.panel2.Controls.Add(this.dataGrid1);
			this.panel2.Controls.Add(this.xpStyleButton3);
			this.panel2.Controls.Add(this.xpStyleButton2);
			this.panel2.Controls.Add(this.xpStyleButton1);
			this.panel2.Controls.Add(this.button1);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel2.Location = new System.Drawing.Point(0, 48);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(792, 518);
			this.panel2.TabIndex = 5;
			// 
			// dataGrid3
			// 
			this.dataGrid3.BackgroundColor = System.Drawing.Color.White;
			this.dataGrid3.CaptionVisible = false;
			this.dataGrid3.DataMember = "";
			this.dataGrid3.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.dataGrid3.Location = new System.Drawing.Point(544, 8);
			this.dataGrid3.Name = "dataGrid3";
			this.dataGrid3.ReadOnly = true;
			this.dataGrid3.Size = new System.Drawing.Size(240, 400);
			this.dataGrid3.TabIndex = 10;
			this.dataGrid3.TableStyles.AddRange(new System.Windows.Forms.DataGridTableStyle[] {
																								  this.dataGridTableStyle3});
			// 
			// dataGridTableStyle3
			// 
			this.dataGridTableStyle3.AllowSorting = false;
			this.dataGridTableStyle3.DataGrid = this.dataGrid3;
			this.dataGridTableStyle3.GridColumnStyles.AddRange(new System.Windows.Forms.DataGridColumnStyle[] {
																												  this.proc_no_pro,
																												  this.proc_name});
			this.dataGridTableStyle3.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.dataGridTableStyle3.MappingName = "brm_process";
			this.dataGridTableStyle3.ReadOnly = true;
			// 
			// proc_no_pro
			// 
			this.proc_no_pro.Format = "";
			this.proc_no_pro.FormatInfo = null;
			this.proc_no_pro.HeaderText = "站编号";
			this.proc_no_pro.MappingName = "proc_no";
			this.proc_no_pro.NullText = "";
			this.proc_no_pro.Width = 75;
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
			// dataGrid2
			// 
			this.dataGrid2.BackgroundColor = System.Drawing.Color.White;
			this.dataGrid2.CaptionVisible = false;
			this.dataGrid2.DataMember = "";
			this.dataGrid2.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.dataGrid2.Location = new System.Drawing.Point(224, 8);
			this.dataGrid2.Name = "dataGrid2";
			this.dataGrid2.ReadOnly = true;
			this.dataGrid2.Size = new System.Drawing.Size(248, 400);
			this.dataGrid2.TabIndex = 9;
			this.dataGrid2.TableStyles.AddRange(new System.Windows.Forms.DataGridTableStyle[] {
																								  this.dataGridTableStyle2});
			// 
			// dataGridTableStyle2
			// 
			this.dataGridTableStyle2.AllowSorting = false;
			this.dataGridTableStyle2.DataGrid = this.dataGrid2;
			this.dataGridTableStyle2.GridColumnStyles.AddRange(new System.Windows.Forms.DataGridColumnStyle[] {
																												  this.seq_no,
																												  this.proc_no,
																												  this.proc_name_mstr});
			this.dataGridTableStyle2.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.dataGridTableStyle2.MappingName = "brm_flow_mstr";
			this.dataGridTableStyle2.ReadOnly = true;
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
			// proc_name_mstr
			// 
			this.proc_name_mstr.Format = "";
			this.proc_name_mstr.FormatInfo = null;
			this.proc_name_mstr.HeaderText = "站名称";
			this.proc_name_mstr.MappingName = "proc_name";
			this.proc_name_mstr.NullText = "";
			this.proc_name_mstr.Width = 75;
			// 
			// dataGrid1
			// 
			this.dataGrid1.BackgroundColor = System.Drawing.Color.White;
			this.dataGrid1.CaptionVisible = false;
			this.dataGrid1.DataMember = "";
			this.dataGrid1.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.dataGrid1.Location = new System.Drawing.Point(8, 8);
			this.dataGrid1.Name = "dataGrid1";
			this.dataGrid1.ReadOnly = true;
			this.dataGrid1.Size = new System.Drawing.Size(208, 400);
			this.dataGrid1.TabIndex = 8;
			this.dataGrid1.TableStyles.AddRange(new System.Windows.Forms.DataGridTableStyle[] {
																								  this.dataGridTableStyle1});
			this.dataGrid1.Click += new System.EventHandler(this.dataGrid1_Click);
			// 
			// dataGridTableStyle1
			// 
			this.dataGridTableStyle1.AllowSorting = false;
			this.dataGridTableStyle1.DataGrid = this.dataGrid1;
			this.dataGridTableStyle1.GridColumnStyles.AddRange(new System.Windows.Forms.DataGridColumnStyle[] {
																												  this.flow_id,
																												  this.flow_name});
			this.dataGridTableStyle1.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.dataGridTableStyle1.MappingName = "brm_flow_det";
			this.dataGridTableStyle1.ReadOnly = true;
			// 
			// flow_id
			// 
			this.flow_id.Format = "";
			this.flow_id.FormatInfo = null;
			this.flow_id.HeaderText = "流程号";
			this.flow_id.MappingName = "flow_id";
			this.flow_id.NullText = "";
			this.flow_id.Width = 75;
			// 
			// flow_name
			// 
			this.flow_name.Format = "";
			this.flow_name.FormatInfo = null;
			this.flow_name.HeaderText = "流程号";
			this.flow_name.MappingName = "flow_name";
			this.flow_name.NullText = "";
			this.flow_name.Width = 75;
			// 
			// xpStyleButton3
			// 
			this.xpStyleButton3.Enabled = false;
			this.xpStyleButton3.Font = new System.Drawing.Font("宋体", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.xpStyleButton3.Location = new System.Drawing.Point(384, 448);
			this.xpStyleButton3.Name = "xpStyleButton3";
			this.xpStyleButton3.Size = new System.Drawing.Size(112, 40);
			this.xpStyleButton3.TabIndex = 7;
			this.xpStyleButton3.Text = "保存";
			this.xpStyleButton3.Click += new System.EventHandler(this.xpStyleButton3_Click);
			// 
			// xpStyleButton2
			// 
			this.xpStyleButton2.Font = new System.Drawing.Font("宋体", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.xpStyleButton2.Location = new System.Drawing.Point(200, 448);
			this.xpStyleButton2.Name = "xpStyleButton2";
			this.xpStyleButton2.Size = new System.Drawing.Size(112, 40);
			this.xpStyleButton2.TabIndex = 6;
			this.xpStyleButton2.Text = "修改";
			this.xpStyleButton2.Click += new System.EventHandler(this.xpStyleButton2_Click);
			// 
			// xpStyleButton1
			// 
			this.xpStyleButton1.Enabled = false;
			this.xpStyleButton1.Font = new System.Drawing.Font("宋体", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.xpStyleButton1.Location = new System.Drawing.Point(480, 160);
			this.xpStyleButton1.Name = "xpStyleButton1";
			this.xpStyleButton1.Size = new System.Drawing.Size(56, 40);
			this.xpStyleButton1.TabIndex = 5;
			this.xpStyleButton1.Text = "<-";
			this.xpStyleButton1.Click += new System.EventHandler(this.xpStyleButton1_Click);
			// 
			// button1
			// 
			this.button1.Enabled = false;
			this.button1.Font = new System.Drawing.Font("宋体", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.button1.Location = new System.Drawing.Point(480, 240);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(56, 40);
			this.button1.TabIndex = 3;
			this.button1.Text = "->";
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
			this.label1.Text = "流程站管理";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// frmBrmFlowMstr1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(7, 16);
			this.BackColor = System.Drawing.SystemColors.ScrollBar;
			this.ClientSize = new System.Drawing.Size(792, 566);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "frmBrmFlowMstr1";
			this.Text = "流程站管理";
			this.panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGrid3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGrid2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).EndInit();
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
				TJSystem.Public.PublicStatic.formName = "流程站管理";
			}
			base.OnClosing (e);
		}

		private void button1_Click(object sender, System.EventArgs e)
		{
			int icurrowproc = 0;
			string tmpproc = null;
			string sql = null;
			DataTable dt = null;
			DataRow dr = null;
			DataView dvProc = null;
			DataView dvMstr = null;
			DataTable dtProc = ((System.Data.DataView)this.dataGrid3.DataSource).Table.Clone();
			DataTable dtMstr = ((System.Data.DataView)this.dataGrid2.DataSource).Table.Clone();
			DataView dv = null;
			sql = "select proc_no,proc_name from brm_process order by proc_no";
			dt = TJSystem.Public.PublicStatic.db.GetDataTable(sql);
			dt.TableName = "brm_process";
			dv = dt.DefaultView;

			icurrowproc = this.dataGrid2.CurrentRowIndex;
			if(icurrowproc < 0)
				return;
			dvProc = (System.Data.DataView)this.dataGrid3.DataSource;
			dvMstr = (System.Data.DataView)this.dataGrid2.DataSource;
			tmpproc = dvMstr[icurrowproc]["proc_no"].ToString();
			dvMstr.RowFilter = "proc_no <>'" + dvMstr[icurrowproc]["proc_no"].ToString() + "'";
			
			for(int i = 0; i < dvMstr.Count ; i++)
			{
				dr = dtMstr.NewRow();
				dr[0] = dvMstr[i][0].ToString();
				dr[1] = dvMstr[i][1].ToString();
				dr[2] = dvMstr[i][2].ToString();
				dtMstr.Rows.Add(dr);
			}
			this.dataGrid2.DataSource = dtMstr.DefaultView;

			for(int i = 0; i < dvProc.Count ; i++)
			{
				dr = dtProc.NewRow();
				dr[0] = dvProc[i][0].ToString();
				dv.RowFilter = "proc_no='" + dr[0].ToString() + "'";
				if(dv.Count == 1)
				{
					dr[1] = dv[0][1].ToString();
				}
				else
				{
//					return;
				}
				dtProc.Rows.Add(dr);
			}
			dr = dtProc.NewRow();
			dr[0] = tmpproc;
			dv.RowFilter = "proc_no='" + dr[0].ToString() + "'";
			if(dv.Count == 1)
			{
				dr[1] = dv[0][1].ToString();
			}
			else
			{
				return;
			}
			dtProc.Rows.Add(dr);
			this.dataGrid3.DataSource = dtProc.DefaultView;
		}

		private void xpStyleButton1_Click(object sender, System.EventArgs e)
		{
			int icurrowproc = 0;
			string tmpproc = null;
			string tmpprocname = null;
			DataRow dr = null;
			DataView dvProc = null;
			DataView dvMstr = null;
			DataTable dtProc = ((System.Data.DataView)this.dataGrid3.DataSource).Table.Clone();
			DataTable dtMstr = ((System.Data.DataView)this.dataGrid2.DataSource).Table.Clone();

			icurrowproc = this.dataGrid3.CurrentRowIndex;
			if(icurrowproc < 0)
				return;
			dvProc = (System.Data.DataView)this.dataGrid3.DataSource;
			dvMstr = (System.Data.DataView)this.dataGrid2.DataSource;
			tmpproc = dvProc[icurrowproc]["proc_no"].ToString();
			tmpprocname = dvProc[icurrowproc]["proc_name"].ToString();
//			dvProc.RowFilter = "proc_no <>'" + dvProc[icurrowproc]["proc_no"].ToString() + "'";
			
			for(int i = 0; i < dvProc.Count ; i++)
			{				
				dr = dtProc.NewRow();
				dr[0] = dvProc[i][0].ToString();
				dr[1] = dvProc[i][1].ToString();
				if(dr[0].ToString().Equals(tmpproc))
					continue;
				dtProc.Rows.Add(dr);
			}
			this.dataGrid3.DataSource = dtProc.DefaultView;

			for(int i = 0; i < dvMstr.Count ; i++)
			{
				dr = dtMstr.NewRow();
				dr[0] = dvMstr[i][0].ToString();
				dr[1] = dvMstr[i][1].ToString();
				dr[2] = dvMstr[i][2].ToString();
				dtMstr.Rows.Add(dr);
			}
			dr = dtMstr.NewRow();
			dr[0] = Convert.ToString(dtMstr.Rows.Count + 1);
			dr[1] = tmpproc;
			dr[2] = tmpprocname;
			dtMstr.Rows.Add(dr);
			this.dataGrid2.DataSource = dtMstr.DefaultView;
		}

		private void dataGrid1_Click(object sender, System.EventArgs e)
		{
			string sql = null;
			string filter = null;
			DataTable dt = null;
			DataView dvmstr = null;
			int mstrcount = 0;
			DataView dv = (System.Data.DataView)this.dataGrid1.DataSource;

			if(dataGrid1.CurrentRowIndex >= 0)
			{
				sql = "select a.seq_no,a.proc_no,b.proc_name from brm_flow_mstr a left join brm_process b on a.proc_no=b.proc_no where a.flow_id='" + dv[this.dataGrid1.CurrentRowIndex][0].ToString() + "' order by a.seq_no";
				dt = TJSystem.Public.PublicStatic.db.GetDataTable(sql);
				dt.TableName = "brm_flow_mstr";
				this.dataGrid2.DataSource = dt.DefaultView;
			}
			else
			{
				sql = "select a.seq_no,a.proc_no,b.proc_name from brm_flow_mstr a left join brm_process b on a.proc_no=b.proc_no order by a.seq_no";
				dt = TJSystem.Public.PublicStatic.db.GetDataTable(sql);
				dt.TableName = "brm_flow_mstr";
				this.dataGrid2.DataSource = dt.DefaultView;
			}
			mstrcount =  dt.Rows.Count;

			dv = this.mdvProc;
			if(mstrcount > 0)
			{
				dvmstr = (System.Data.DataView)this.dataGrid2.DataSource;
				for(int i = 0; i < mstrcount; i++)
				{
					if(i == 0)
					{
						filter = "proc_no <>'" + dvmstr[i]["proc_no"].ToString() + "' ";
					}
					filter += " and proc_no<>'" + dvmstr[i]["proc_no"].ToString() + "' ";
				}
			}
			dv.RowFilter = filter;
			this.dataGrid3.DataSource = dv;
		}

		private void xpStyleButton3_Click(object sender, System.EventArgs e)
		{
			string flowid = null;
			string sql = null;
			DataView dv = null;
			MyADO.DBOperator db = MyADO.DBOperatorFactory.GetDBOperator(TJSystem.Public.PublicStatic.ConnectionString,MyADO.DBEnum.SQLServer);
			if(dataGrid1.CurrentRowIndex < 0)
			{
				return;
			}
			flowid = ((System.Data.DataView)this.dataGrid1.DataSource)[dataGrid1.CurrentRowIndex][0].ToString();
			dv = (System.Data.DataView)this.dataGrid2.DataSource;
			if(dv.Count == 0)
			{
//				return;
			}

			try
			{
				db.Open();
//				TJSystem.Public.PublicStatic.
				db.BeginTrans();

				sql = "delete from brm_flow_mstr where flow_id='" + flowid + "'";
//				TJSystem.Public.PublicStatic.
				db.ExeSql(sql);
				
				for(int i = 0; i < dv.Count; i++)
				{
					sql = "insert into brm_flow_mstr(flow_id,seq_no,proc_no,modifyby,modifyon) values ('";
					sql += flowid + "','";
					sql += dv[i][0].ToString() + "','";
					sql += dv[i][1].ToString() + "','";
					sql += TJSystem.Public.PublicStatic.LoginUser + "','";
					sql += System.DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss") + "')";

//					TJSystem.Public.PublicStatic.
					db.ExeSql(sql);
				}
//				TJSystem.Public.PublicStatic.
				db.CommitTrans();
				db.Close();
				TJSystem.Public.PublicStatic.ShowMessage(TJSystem.Public.MessageType.Information,"流程与站匹配成功！");
				return;
			}
			catch(System.Exception ex)
			{
//				TJSystem.Public.PublicStatic.
				db.RollbackTrans();
				db.Close();
				return;
			}
		}

		private void xpStyleButton2_Click(object sender, System.EventArgs e)
		{
			if(this.xpStyleButton2.Text.Equals("修改"))
			{
				this.button1.Enabled = true;
				this.xpStyleButton1.Enabled = true;
				this.xpStyleButton2.Text = "锁定";
				this.xpStyleButton3.Enabled = true;
			}
			else
			{
				this.button1.Enabled = false;
				this.xpStyleButton1.Enabled = false;
				this.xpStyleButton2.Text = "修改";
				this.xpStyleButton3.Enabled = false;
			}
		}
		
	}
}

using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace TJSystem.Tool
{
	/// <summary>
	/// Form1 的摘要说明。

	/// </summary>
	public class frmToolConformCenter : System.Windows.Forms.Form
	{
		
		
		/// <summary>
		/// 必需的设计器变量。

		/// </summary>
		private System.ComponentModel.Container components = null;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Panel panel1;
		public static System.Windows.Forms.Form frmCurrent = null ;

		private System.Windows.Forms.GroupBox groupBox1;
		private TJSystem.Classes.PriComboBox comboBox1;
		private System.Windows.Forms.Label label8;
		private TJSystem.Classes.XpStyleButton btnOK;
		private TJSystem.Classes.XpStyleButton xpStyleButton1;
		private System.Windows.Forms.RadioButton radioButton1;
		private System.Windows.Forms.RadioButton radioButton3;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.DataGrid dataGrid1;
		private string _table = null;
		private string _tableName = null;
		private string _PK = null;
		private string _sql = null;
		private TJSystem.Classes.XpStyleButton xpStyleButton2;
		private TJSystem.Classes.XpStyleButton xpStyleButton3;
		private TJSystem.Classes.XpStyleButton xpStyleButton4;
		private TJSystem.Classes.XpStyleButton xpStyleButton5;
		private System.Windows.Forms.RadioButton radioButton2;
		private System.Windows.Forms.RadioButton radioButton4;
		private System.Windows.Forms.Label label2;
		private byte bConfirm = 0;

		public frmToolConformCenter()
		{
			//
			// Windows 窗体设计器支持所必需的

			//
			InitializeComponent();
			

			TJSystem.Public.PublicStatic.setBackgroundImg(this.panel1,this.panel1.GetType().ToString(),"images\\bg.gif");
			TJSystem.Public.PublicStatic.setBackgroundImg(this.panel2,this.panel1.GetType().ToString(),"");
			
			InitialFormData();

			System.Text.StringBuilder sb = new System.Text.StringBuilder();
			
			//
			// TODO: 在 InitializeComponent 调用后添加任何构造函数代码

			//
		}

		
		
		private void InitialFormData()
		{
			DataTable dtcpy = null;
			DataRow dr = null;
			string sql = "select xf_currenthandle as HANDLE_ID,xf_currenthandle + ' ' + xf_programname as HANDLE_NAME from xf_menutree where xf_treeicon = '1' order by xf_currenthandle";
			DataTable dt = TJSystem.Public.PublicStatic.db.GetDataTable(sql);
			dr = dt.NewRow() ;
			dr[0] = "" ;
			dr[1] = "" ;
			dt.Rows.InsertAt(dr,0) ;
			dtcpy = dt.Copy();
			this.comboBox1.DataSource = dtcpy.DefaultView;
			this.comboBox1.ValueMember = "HANDLE_ID";
			this.comboBox1.DisplayMember = "HANDLE_NAME";
			
		}

		private void InitialGrid(string sql)
		{		
			DataTable dt = TJSystem.Public.PublicStatic.db.GetDataTable(sql);
			dt.TableName = this._table;
//			this.dataGridTableStyle1.DataGrid.DataSource = dt.DefaultView;
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(frmToolConformCenter));
			this.panel2 = new System.Windows.Forms.Panel();
			this.dataGrid1 = new System.Windows.Forms.DataGrid();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.radioButton1 = new System.Windows.Forms.RadioButton();
			this.btnOK = new TJSystem.Classes.XpStyleButton();
			this.comboBox1 = new TJSystem.Classes.PriComboBox();
			this.label8 = new System.Windows.Forms.Label();
			this.xpStyleButton1 = new TJSystem.Classes.XpStyleButton();
			this.radioButton3 = new System.Windows.Forms.RadioButton();
			this.xpStyleButton2 = new TJSystem.Classes.XpStyleButton();
			this.xpStyleButton3 = new TJSystem.Classes.XpStyleButton();
			this.xpStyleButton4 = new TJSystem.Classes.XpStyleButton();
			this.xpStyleButton5 = new TJSystem.Classes.XpStyleButton();
			this.radioButton2 = new System.Windows.Forms.RadioButton();
			this.radioButton4 = new System.Windows.Forms.RadioButton();
			this.panel1 = new System.Windows.Forms.Panel();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).BeginInit();
			this.groupBox1.SuspendLayout();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel2
			// 
			this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
			this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.panel2.Controls.Add(this.dataGrid1);
			this.panel2.Controls.Add(this.groupBox1);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel2.Location = new System.Drawing.Point(0, 48);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(792, 518);
			this.panel2.TabIndex = 5;
			// 
			// dataGrid1
			// 
			this.dataGrid1.CaptionVisible = false;
			this.dataGrid1.DataMember = "";
			this.dataGrid1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dataGrid1.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.dataGrid1.Location = new System.Drawing.Point(0, 104);
			this.dataGrid1.Name = "dataGrid1";
			this.dataGrid1.ReadOnly = true;
			this.dataGrid1.Size = new System.Drawing.Size(788, 410);
			this.dataGrid1.TabIndex = 1;
			// 
			// groupBox1
			// 
			this.groupBox1.BackColor = System.Drawing.Color.Transparent;
			this.groupBox1.Controls.Add(this.radioButton1);
			this.groupBox1.Controls.Add(this.btnOK);
			this.groupBox1.Controls.Add(this.comboBox1);
			this.groupBox1.Controls.Add(this.label8);
			this.groupBox1.Controls.Add(this.xpStyleButton1);
			this.groupBox1.Controls.Add(this.radioButton3);
			this.groupBox1.Controls.Add(this.xpStyleButton2);
			this.groupBox1.Controls.Add(this.xpStyleButton3);
			this.groupBox1.Controls.Add(this.xpStyleButton4);
			this.groupBox1.Controls.Add(this.xpStyleButton5);
			this.groupBox1.Controls.Add(this.radioButton2);
			this.groupBox1.Controls.Add(this.radioButton4);
			this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
			this.groupBox1.Location = new System.Drawing.Point(0, 0);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(788, 104);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			// 
			// radioButton1
			// 
			this.radioButton1.Checked = true;
			this.radioButton1.Location = new System.Drawing.Point(440, 24);
			this.radioButton1.Name = "radioButton1";
			this.radioButton1.Size = new System.Drawing.Size(72, 24);
			this.radioButton1.TabIndex = 37;
			this.radioButton1.TabStop = true;
			this.radioButton1.Text = "未审核";
			this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
			// 
			// btnOK
			// 
			this.btnOK.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(192)), ((System.Byte)(192)), ((System.Byte)(255)));
			this.btnOK.Location = new System.Drawing.Point(104, 64);
			this.btnOK.Name = "btnOK";
			this.btnOK.Size = new System.Drawing.Size(88, 24);
			this.btnOK.TabIndex = 36;
			this.btnOK.Text = "打开";
			this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
			// 
			// comboBox1
			// 
			this.comboBox1.BackColor = System.Drawing.Color.White;
			this.comboBox1.DataField = "company_id";
			this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBox1.Location = new System.Drawing.Point(104, 24);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(304, 22);
			this.comboBox1.TabIndex = 35;
			// 
			// label8
			// 
			this.label8.BackColor = System.Drawing.Color.Transparent;
			this.label8.ForeColor = System.Drawing.Color.Blue;
			this.label8.Location = new System.Drawing.Point(16, 24);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(80, 23);
			this.label8.TabIndex = 34;
			this.label8.Text = "单据类型";
			this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// xpStyleButton1
			// 
			this.xpStyleButton1.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(192)), ((System.Byte)(192)), ((System.Byte)(255)));
			this.xpStyleButton1.Location = new System.Drawing.Point(200, 64);
			this.xpStyleButton1.Name = "xpStyleButton1";
			this.xpStyleButton1.Size = new System.Drawing.Size(96, 24);
			this.xpStyleButton1.TabIndex = 36;
			this.xpStyleButton1.Text = "审核";
			this.xpStyleButton1.Click += new System.EventHandler(this.xpStyleButton1_Click);
			// 
			// radioButton3
			// 
			this.radioButton3.Location = new System.Drawing.Point(512, 24);
			this.radioButton3.Name = "radioButton3";
			this.radioButton3.Size = new System.Drawing.Size(72, 24);
			this.radioButton3.TabIndex = 37;
			this.radioButton3.Text = "已审核";
			this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
			// 
			// xpStyleButton2
			// 
			this.xpStyleButton2.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(192)), ((System.Byte)(192)), ((System.Byte)(255)));
			this.xpStyleButton2.Location = new System.Drawing.Point(304, 64);
			this.xpStyleButton2.Name = "xpStyleButton2";
			this.xpStyleButton2.Size = new System.Drawing.Size(88, 24);
			this.xpStyleButton2.TabIndex = 36;
			this.xpStyleButton2.Text = "取消审核";
			this.xpStyleButton2.Click += new System.EventHandler(this.xpStyleButton2_Click);
			// 
			// xpStyleButton3
			// 
			this.xpStyleButton3.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(192)), ((System.Byte)(192)), ((System.Byte)(255)));
			this.xpStyleButton3.Location = new System.Drawing.Point(400, 64);
			this.xpStyleButton3.Name = "xpStyleButton3";
			this.xpStyleButton3.Size = new System.Drawing.Size(88, 24);
			this.xpStyleButton3.TabIndex = 36;
			this.xpStyleButton3.Text = "确认关闭";
			this.xpStyleButton3.Click += new System.EventHandler(this.xpStyleButton3_Click);
			// 
			// xpStyleButton4
			// 
			this.xpStyleButton4.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(192)), ((System.Byte)(192)), ((System.Byte)(255)));
			this.xpStyleButton4.Location = new System.Drawing.Point(496, 64);
			this.xpStyleButton4.Name = "xpStyleButton4";
			this.xpStyleButton4.Size = new System.Drawing.Size(88, 24);
			this.xpStyleButton4.TabIndex = 36;
			this.xpStyleButton4.Text = "取消确认";
			this.xpStyleButton4.Click += new System.EventHandler(this.xpStyleButton4_Click);
			// 
			// xpStyleButton5
			// 
			this.xpStyleButton5.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(192)), ((System.Byte)(192)), ((System.Byte)(255)));
			this.xpStyleButton5.Location = new System.Drawing.Point(592, 64);
			this.xpStyleButton5.Name = "xpStyleButton5";
			this.xpStyleButton5.Size = new System.Drawing.Size(88, 24);
			this.xpStyleButton5.TabIndex = 36;
			this.xpStyleButton5.Text = "作废处理";
			this.xpStyleButton5.Click += new System.EventHandler(this.xpStyleButton5_Click);
			// 
			// radioButton2
			// 
			this.radioButton2.Location = new System.Drawing.Point(592, 24);
			this.radioButton2.Name = "radioButton2";
			this.radioButton2.Size = new System.Drawing.Size(56, 24);
			this.radioButton2.TabIndex = 37;
			this.radioButton2.Text = "确认";
			this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
			// 
			// radioButton4
			// 
			this.radioButton4.Location = new System.Drawing.Point(664, 24);
			this.radioButton4.Name = "radioButton4";
			this.radioButton4.Size = new System.Drawing.Size(80, 24);
			this.radioButton4.TabIndex = 37;
			this.radioButton4.Text = "作废";
			this.radioButton4.CheckedChanged += new System.EventHandler(this.radioButton4_CheckedChanged);
			// 
			// panel1
			// 
			this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
			this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.panel1.Controls.Add(this.label2);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(792, 48);
			this.panel1.TabIndex = 4;
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(0, 0);
			this.label1.Name = "label1";
			this.label1.TabIndex = 0;
			// 
			// label2
			// 
			this.label2.BackColor = System.Drawing.Color.Transparent;
			this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label2.Font = new System.Drawing.Font("宋体", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.label2.Location = new System.Drawing.Point(0, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(788, 44);
			this.label2.TabIndex = 0;
			this.label2.Text = "审核中心";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// frmToolConformCenter
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(7, 16);
			this.BackColor = System.Drawing.SystemColors.ScrollBar;
			this.ClientSize = new System.Drawing.Size(792, 566);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "frmToolConformCenter";
			this.Text = "审核中心";
			this.panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		

		/// <summary>
		/// 检查画面中的内容是否符合基本格式要求
		
		protected override void OnClosing(CancelEventArgs e)
		{			
//			if(MessageBox.Show("确定退出？（Y/N）","确认",MessageBoxButtons.YesNo,MessageBoxIcon.Information) == System.Windows.Forms.DialogResult.No)
//			{
//				e.Cancel = true;
//			}
//			else
			{
				TJSystem.Public.PublicStatic.formClose = true;
				TJSystem.Public.PublicStatic.formName = "审核中心";
			}
			base.OnClosing (e);
		}

		private void btnOK_Click(object sender, System.EventArgs e)
		{
			string strHandleID = this.comboBox1.SelectedValue.ToString();
			switch(strHandleID)
			{
				case "030010":
					FillDataGridSaleCE();
					FillDataGrid();
					break;
				case "030020":
					FillDataGridSaleCQ();
					FillDataGrid();
					break;
				case "030030":
					FillDataGridSaleCO();
					FillDataGrid();
					break;
				case "030060":
					FillDataGridSaleSS();
					FillDataGrid();
					break;
				case "040010":
					FillDataGridPurchaseSE();
					FillDataGrid();
					break;
				case "040020":
					FillDataGridPurchaseSQ();
					FillDataGrid();
					break;
				case "040030":
					FillDataGridPurchasePO();
					FillDataGrid();
					break;
				case "040050":
					FillDataGridPurchaseRS();
					FillDataGrid();
					break;
				case "050010":
					FillDataGridDocSale();
					FillDataGrid();
					break;
				case "050020":
					FillDataGridWayBill();
					FillDataGrid();
					break;
				case "050040":
					FillDataGridDocLC();
					FillDataGrid();
					break;
				case "060010":
					FillDataGridStockIn();
					FillDataGrid();
					break;
				case "060020":
					FillDataGridStockOut();
					FillDataGrid();
					break;
				case "060050":
					FillDataGridStockCHG();
					FillDataGrid();
					break;
				case "060060":
					FillDataGridStockCycle();
					FillDataGrid();
					break;
				case "070110":
					FillDataGridAccountCC();
					FillDataGrid();
					break;
				case "070150":
					FillDataGridAccountFF();
					FillDataGrid();
					break;
				default:
					break;
			}
		}

		private void FillDataGrid()
		{
			DataTable dt = null;
			dt = TJSystem.Public.PublicStatic.db.GetDataTable(_sql);
			this.dataGrid1.DataSource = dt.DefaultView;
		}

		private void FillDataGridSaleCE()
		{			
			_table = "sale_ce_master";
			_PK = "ce_code";
			_tableName = "客户询价单";
			System.Text.StringBuilder sb = new System.Text.StringBuilder();
			
			sb.Append("select ce_code as '询价单号',client_name as '客户名称',contact_name as '客户联系人',");
			sb.Append(" client_cecode as '客户单号',");
			sb.Append(" case when status='1' then '新建' when status='2' then '审核' when status='3' then '确认' when status='0' then '作废' end as '当前状态',");
			sb.Append(" ce_date as '询价日期',createby as '受理人',");
			sb.Append(" createon as '受理日期',remark as '备注', ");
			sb.Append(" approvedby as '审核人',approvedon as '审核日期' ");
			sb.Append(" from sale_ce_master");
			if(this.bConfirm == 0)
			{
				sb.Append(" where status='1' ");
			}
			else if(this.bConfirm == 1)
			{
				sb.Append(" where status='2'");
			}
			else if(this.bConfirm == 2)
			{
				sb.Append(" where status='3'");
			}
			else if(this.bConfirm == 10)
			{
				sb.Append(" where status='0'");
			}
			sb.Append(" order by ce_code ");
			
			this._sql = sb.ToString();
		}

		private void FillDataGridSaleCQ()
		{
			_table = "sale_cq_master";
			_PK = "cq_code";
			_tableName = "报价单";
			System.Text.StringBuilder sb = new System.Text.StringBuilder();
			
			sb.Append("select cq_code as '报价单号',client_name as '客户名称',contact_name as '客户联系人',");
			sb.Append(" case when status='1' then '新建' when status='2' then '审核' when status='3' then '确认' when status='0' then '作废' end as '当前状态',");
			sb.Append(" cq_date as '日期',createby as '受理人',");
			sb.Append(" createon as '受理日期',remark as '备注', ");
			sb.Append(" approvedby as '审核人',approvedon as '审核日期' ");
			sb.Append(" from sale_cq_master");
			if(this.bConfirm == 0)
			{
				sb.Append(" where status='1' ");
			}
			else if(this.bConfirm == 1)
			{
				sb.Append(" where status='2'");
			}
			else if(this.bConfirm == 2)
			{
				sb.Append(" where status='3'");
			}
			else if(this.bConfirm == 10)
			{
				sb.Append(" where status='0'");
			}
			sb.Append(" order by cq_code ");
			
			this._sql = sb.ToString();
		}

		private void FillDataGridSaleCO()
		{
			_table = "sale_so_master";
			_PK = "so_code";
			_tableName = "销售单";
			System.Text.StringBuilder sb = new System.Text.StringBuilder();
			
			sb.Append("select so_code as '销售单号',client_name as '客户名称',contact_name as '客户联系人',");
			sb.Append(" client_orderno as '客户单号',");
			sb.Append(" case when status='1' then '新建' when status='2' then '审核' when status='3' then '确认' when status='0' then '作废' end as '当前状态',");
			sb.Append(" so_date as '日期',createby as '受理人',");
			sb.Append(" createon as '受理日期',remark as '备注', ");
			sb.Append(" approvedby as '审核人',approvedon as '审核日期' ");
			sb.Append(" from sale_so_master");
			if(this.bConfirm == 0)
			{
				sb.Append(" where status='1' ");
			}
			else if(this.bConfirm == 1)
			{
				sb.Append(" where status='2'");
			}
			else if(this.bConfirm == 2)
			{
				sb.Append(" where status='3'");
			}
			else if(this.bConfirm == 10)
			{
				sb.Append(" where status='0'");
			}
			sb.Append(" order by so_code ");
			
			this._sql = sb.ToString();
		}

		private void FillDataGridSaleSS()
		{
			_table = "sale_ss_master";
			_PK = "ss_code";
			_tableName = "退货单";
			System.Text.StringBuilder sb = new System.Text.StringBuilder();
			
			sb.Append("select ss_code as '退货单号',client_name as '客户名称',contact_name as '客户联系人',");
			sb.Append(" case when status='1' then '新建' when status='2' then '审核' when status='3' then '确认' when status='0' then '作废' end as '当前状态',");
			sb.Append(" ss_date as '日期',createby as '受理人',");
			sb.Append(" createon as '受理日期',remark as '备注', ");
			sb.Append(" approvedby as '审核人',approvedon as '审核日期' ");
			sb.Append(" from sale_ss_master");
			if(this.bConfirm == 0)
			{
				sb.Append(" where status='1' ");
			}
			else if(this.bConfirm == 1)
			{
				sb.Append(" where status='2'");
			}
			else if(this.bConfirm == 2)
			{
				sb.Append(" where status='3'");
			}
			else if(this.bConfirm == 10)
			{
				sb.Append(" where status='0'");
			}
			sb.Append(" order by ss_code ");
			
			this._sql = sb.ToString();
		}

		private void FillDataGridPurchaseSE()
		{
			_table = "purchase_se_master";
			_PK = "se_code";
			_tableName = "采购询价单";
			System.Text.StringBuilder sb = new System.Text.StringBuilder();
			
			sb.Append("select se_code as '询价单号',supplier_name as '供应商名称',contact_name as '供应商联系人',");
			sb.Append(" case when status='1' then '新建' when status='2' then '审核' when status='3' then '确认' when status='0' then '作废' end as '当前状态',");
			sb.Append(" se_date as '询价日期',createby as '受理人',");
			sb.Append(" createon as '受理日期',remark as '备注', ");
			sb.Append(" approvedby as '审核人',approvedon as '审核日期' ");
			sb.Append(" from purchase_se_master");
			if(this.bConfirm == 0)
			{
				sb.Append(" where status='1' ");
			}
			else if(this.bConfirm == 1)
			{
				sb.Append(" where status='2'");
			}
			else if(this.bConfirm == 2)
			{
				sb.Append(" where status='3'");
			}
			else if(this.bConfirm == 10)
			{
				sb.Append(" where status='0'");
			}
			sb.Append(" order by se_code ");
			
			this._sql = sb.ToString();
		}

		private void FillDataGridPurchaseSQ()
		{
			_table = "purchase_sq_master";
			_PK = "sq_code";
			_tableName = "供应商报价单";
			System.Text.StringBuilder sb = new System.Text.StringBuilder();
			
			sb.Append("select sq_code as '供应商报价单号',supplier_name as '供应商名称',contact_name as '供应商联系人',");
			sb.Append(" supplier_sqcode as '供应商单号',");
			sb.Append(" case when status='1' then '新建' when status='2' then '审核' when status='3' then '确认' when status='0' then '作废' end as '当前状态',");
			sb.Append(" sq_date as '日期',createby as '受理人',");
			sb.Append(" createon as '受理日期',remark as '备注', ");
			sb.Append(" approvedby as '审核人',approvedon as '审核日期' ");
			sb.Append(" from purchase_sq_master");
			
			if(this.bConfirm == 0)
			{
				sb.Append(" where status='1' ");
			}
			else if(this.bConfirm == 1)
			{
				sb.Append(" where status='2'");
			}
			else if(this.bConfirm == 2)
			{
				sb.Append(" where status='3'");
			}
			else if(this.bConfirm == 10)
			{
				sb.Append(" where status='0'");
			}
			sb.Append(" order by sq_code ");
			
			this._sql = sb.ToString();
		}

		private void FillDataGridPurchasePO()
		{
			_table = "purchase_po_master";
			_PK = "po_code";
			_tableName = "采购订单";
			System.Text.StringBuilder sb = new System.Text.StringBuilder();

			sb.Append("select po_code as '采购单号',supplier_name as '供应商名称',contact_name as '供应商联系人',");
			sb.Append(" case when status='1' then '新建' when status='2' then '审核' when status='3' then '确认' when status='0' then '作废' end as '当前状态',");
			sb.Append(" po_date as '日期',createby as '受理人',");
			sb.Append(" createon as '受理日期',remark as '备注', ");
			sb.Append(" approvedby as '审核人',approvedon as '审核日期' ");
			sb.Append(" from purchase_po_master");
			
			
			if(this.bConfirm == 0)
			{
				sb.Append(" where status='1' ");
			}
			else if(this.bConfirm == 1)
			{
				sb.Append(" where status='2'");
			}
			else if(this.bConfirm == 2)
			{
				sb.Append(" where status='3'");
			}
			else if(this.bConfirm == 10)
			{
				sb.Append(" where status='0'");
			}
			sb.Append(" order by po_code ");
			
			this._sql = sb.ToString();
		}

		private void FillDataGridPurchaseRS()
		{
			_table = "purchase_rs_master";
			_PK = "rs_code";
			_tableName = "客户询价单";
			System.Text.StringBuilder sb = new System.Text.StringBuilder();

			sb.Append("select rs_code as '采购单号',supplier_name as '供应商名称',contact_name as '供应商联系人',");
			sb.Append(" case when status='1' then '新建' when status='2' then '审核' when status='3' then '确认' when status='0' then '作废' end as '当前状态',");
			sb.Append(" rs_date as '日期',createby as '受理人',");
			sb.Append(" createon as '受理日期',remark as '备注', ");
			sb.Append(" approvedby as '审核人',approvedon as '审核日期' ");
			sb.Append(" from purchase_rs_master");			
			
			if(this.bConfirm == 0)
			{
				sb.Append(" where status='1' ");
			}
			else if(this.bConfirm == 1)
			{
				sb.Append(" where status='2'");
			}
			else if(this.bConfirm == 2)
			{
				sb.Append(" where status='3'");
			}
			else if(this.bConfirm == 10)
			{
				sb.Append(" where status='0'");
			}
			sb.Append(" order by rs_code ");
			
			this._sql = sb.ToString();
		}
		
		private void FillDataGridDocSale()
		{
			_table = "sale_doc_master";
			_PK = "invoice_no";
			_tableName = "单证";
			System.Text.StringBuilder sb = new System.Text.StringBuilder();

			sb.Append("select invoice_no as '发票号',client_name as '客户名称',");
			sb.Append(" so_code as '销售单号',putonrecordno as '备案号',");
			sb.Append(" case when status='1' then '新建' when status='2' then '审核' when status='3' then '确认' when status='0' then '作废' end as '当前状态',");
			sb.Append(" invoice_date as '日期',createby as '受理人',");
			sb.Append(" createon as '受理日期', ");
			sb.Append(" approvedby as '审核人',approvedon as '审核日期' ");
			sb.Append(" from sale_doc_master");			
			
			if(this.bConfirm == 0)
			{
				sb.Append(" where status='1' ");
			}
			else if(this.bConfirm == 1)
			{
				sb.Append(" where status='2'");
			}
			else if(this.bConfirm == 2)
			{
				sb.Append(" where status='3'");
			}
			else if(this.bConfirm == 10)
			{
				sb.Append(" where status='0'");
			}
			sb.Append(" order by invoice_no ");
			
			this._sql = sb.ToString();
		}

		private void FillDataGridWayBill()
		{
			_table = "SALE_WAYBILL_MASTER";
			_PK = "awb_code";
			_tableName = "货物托运单";
			System.Text.StringBuilder sb = new System.Text.StringBuilder();
			
			sb.Append("select awb_code as '托运单号',loadingdate as '装运日期',transtype as '运输方式',");
			sb.Append(" invoice_no as '发票号',lc_code as '信用证号',");
			sb.Append(" freight_amount as '运费总额',item_amount as '货品总值',");
			sb.Append(" case when status='1' then '新建' when status='2' then '审核' when status='3' then '确认' when status='0' then '作废' end as '当前状态',");
			sb.Append(" awb_date as '日期',createby as '受理人',");
			sb.Append(" createon as '受理日期', ");
			sb.Append(" approvedby as '审核人',approvedon as '审核日期' ");
			sb.Append(" from SALE_WAYBILL_MASTER");			
			
			if(this.bConfirm == 0)
			{
				sb.Append(" where status='1' ");
			}
			else if(this.bConfirm == 1)
			{
				sb.Append(" where status='2'");
			}
			else if(this.bConfirm == 2)
			{
				sb.Append(" where status='3'");
			}
			else if(this.bConfirm == 10)
			{
				sb.Append(" where status='0'");
			}
			sb.Append(" order by awb_code ");
			
			this._sql = sb.ToString();
		}

		private void FillDataGridDocLC()
		{
			_table = "SALE_LETTEROFCREDIT";
			_PK = "lc_code";
			_tableName = "信用证";
			System.Text.StringBuilder sb = new System.Text.StringBuilder();
			
			sb.Append("select lc_code as '信用证号',client_name as '客户名称',lc_date as '开证日期',rec_date as '收证日期',");
			sb.Append(" amount as '总金额',so_code as '销售单号',");
			sb.Append(" case when status='1' then '新建' when status='2' then '审核' when status='3' then '确认' when status='0' then '作废' end as '当前状态',");
			sb.Append(" createby as '受理人',");
			sb.Append(" createon as '受理日期', ");
			sb.Append(" approvedby as '审核人',approvedon as '审核日期' ");
			sb.Append(" from SALE_LETTEROFCREDIT");			
			
			if(this.bConfirm == 0)
			{
				sb.Append(" where status='1' ");
			}
			else if(this.bConfirm == 1)
			{
				sb.Append(" where status='2'");
			}
			else if(this.bConfirm == 2)
			{
				sb.Append(" where status='3'");
			}
			else if(this.bConfirm == 10)
			{
				sb.Append(" where status='0'");
			}
			sb.Append(" order by lc_code ");
			
			this._sql = sb.ToString();
		}

		private void FillDataGridStockIn()
		{
			_table = "wip_stock_mstr";
			_PK = "stock_code";
			_tableName = "采购入库";
			System.Text.StringBuilder sb = new System.Text.StringBuilder();
			
			sb.Append("select stock_code as '入库单号',supplier_name as '供应商名称',stock_date as '入库日期',contact_name as '联系人',");
			sb.Append(" wh_code as '仓库编号',");
			sb.Append(" case when status='1' then '新建' when status='2' then '审核' when status='3' then '确认' when status='0' then '作废' end as '当前状态',");
			sb.Append(" createby as '受理人',");
			sb.Append(" createon as '受理日期', ");
			sb.Append(" approvedby as '审核人',approvedon as '审核日期' ");
			sb.Append(" from wip_stock_mstr");			
			
			if(this.bConfirm == 0)
			{
				sb.Append(" where status='1' ");
			}
			else if(this.bConfirm == 1)
			{
				sb.Append(" where status='2'");
			}
			else if(this.bConfirm == 2)
			{
				sb.Append(" where status='3'");
			}
			else if(this.bConfirm == 10)
			{
				sb.Append(" where status='0'");
			}
			sb.Append(" and event_type = 'BUY'");
			sb.Append(" order by stock_code ");
			
			this._sql = sb.ToString();
		}

		private void FillDataGridStockOut()
		{
			_table = "wip_stock_mstr";
			_PK = "stock_code";
			_tableName = "销售出库";
			System.Text.StringBuilder sb = new System.Text.StringBuilder();
			
			sb.Append("select stock_code as '出库单号',client_name as '供应商名称',stock_date as '入库日期',contact_name as '联系人',");
			sb.Append(" wh_code as '仓库编号',forwarder_name as '运输商',");
			sb.Append(" case when status='1' then '新建' when status='2' then '审核' when status='3' then '确认' when status='0' then '作废' end as '当前状态',");
			sb.Append(" createby as '受理人',");
			sb.Append(" createon as '受理日期', ");
			sb.Append(" approvedby as '审核人',approvedon as '审核日期' ");
			sb.Append(" from wip_stock_mstr");			
			
			if(this.bConfirm == 0)
			{
				sb.Append(" where status='1' ");
			}
			else if(this.bConfirm == 1)
			{
				sb.Append(" where status='2'");
			}
			else if(this.bConfirm == 2)
			{
				sb.Append(" where status='3'");
			}
			else if(this.bConfirm == 10)
			{
				sb.Append(" where status='0'");
			}
			sb.Append(" and event_type = 'SELL'");
			sb.Append(" order by stock_code ");
			
			this._sql = sb.ToString();
		}

		private void FillDataGridStockCHG()
		{
			_table = "wip_stock_mstr";
			_PK = "stock_code";
			_tableName = "库存调整";
			System.Text.StringBuilder sb = new System.Text.StringBuilder();
			
			sb.Append("select stock_code as '调整单号',stock_date as '调整日期',reason as '调整原因',");
			sb.Append(" wh_code as '仓库编号',");
			sb.Append(" case when status='1' then '新建' when status='2' then '审核' when status='3' then '确认' when status='0' then '作废' end as '当前状态',");
			sb.Append(" createby as '受理人',");
			sb.Append(" createon as '受理日期', ");
			sb.Append(" approvedby as '审核人',approvedon as '审核日期' ");
			sb.Append(" from wip_stock_mstr");	
			
			if(this.bConfirm == 0)
			{
				sb.Append(" where status='1' ");
			}
			else if(this.bConfirm == 1)
			{
				sb.Append(" where status='2'");
			}
			else if(this.bConfirm == 2)
			{
				sb.Append(" where status='3'");
			}
			else if(this.bConfirm == 10)
			{
				sb.Append(" where status='0'");
			}
			sb.Append(" and event_type = 'MOVE'");
			sb.Append(" order by stock_code ");
			
			this._sql = sb.ToString();
		}

		private void FillDataGridStockCycle()
		{
			_table = "wip_stock_cycle_mstr";
			_PK = "it_code";
			_tableName = "库存盘点";
			System.Text.StringBuilder sb = new System.Text.StringBuilder();
			
			sb.Append("select it_code as '盘点单号',it_date as '调整日期',");
			sb.Append(" wh_code as '仓库编号',");
			sb.Append(" case when status='1' then '新建' when status='2' then '审核' when status='3' then '确认' when status='0' then '作废' end as '当前状态',");
			sb.Append(" createby as '受理人',");
			sb.Append(" createon as '受理日期', ");
			sb.Append(" approvedby as '审核人',approvedon as '审核日期' ");
			sb.Append(" from wip_stock_cycle_mstr");	

			if(this.bConfirm == 0)
			{
				sb.Append(" where status='1' ");
			}
			else if(this.bConfirm == 1)
			{
				sb.Append(" where status='2'");
			}
			else if(this.bConfirm == 2)
			{
				sb.Append(" where status='3'");
			}
			else if(this.bConfirm == 10)
			{
				sb.Append(" where status='0'");
			}
			sb.Append(" order by it_code ");
			
			this._sql = sb.ToString();
		}

		private void FillDataGridAccountCC()
		{
			_table = "finance_cc_master";
			_PK = "cc_code";
			_tableName = "客户索赔单";
			System.Text.StringBuilder sb = new System.Text.StringBuilder();
			
			sb.Append("select cc_code as '索赔单号',client_name as '客户名称',tot_amt as '索赔金额',");
			sb.Append(" case when status='1' then '新建' when status='2' then '审核' when status='3' then '确认' when status='0' then '作废' end as '当前状态',");
			sb.Append(" remark as '备注',");
			sb.Append(" cc_date as '日期',createby as '受理人',");
			sb.Append(" createon as '受理日期',remark as '备注', ");
			sb.Append(" approvedby as '审核人',approvedon as '审核日期' ");
			sb.Append(" from finance_cc_master");	
			
			if(this.bConfirm == 0)
			{
				sb.Append(" where status='1' ");
			}
			else if(this.bConfirm == 1)
			{
				sb.Append(" where status='2'");
			}
			else if(this.bConfirm == 2)
			{
				sb.Append(" where status='3'");
			}
			else if(this.bConfirm == 10)
			{
				sb.Append(" where status='0'");
			}
			sb.Append(" order by cc_code ");
			
			this._sql = sb.ToString();
		}

		private void FillDataGridAccountFF()
		{
			_table = "finance_ff_master";
			_PK = "ff_code";
			_tableName = "罚款单";
			System.Text.StringBuilder sb = new System.Text.StringBuilder();
			
			sb.Append("select ff_code as '罚款单号',supplier_name as '供应商名称',tot_amt as '罚款金额',");
			sb.Append(" case when status='1' then '新建' when status='2' then '审核' when status='3' then '确认' when status='0' then '作废' end as '当前状态',");
			sb.Append(" remark as '罚款原因',");
			sb.Append(" ff_date as '日期',createby as '受理人',");
			sb.Append(" createon as '受理日期',remark as '备注', ");
			sb.Append(" approvedby as '审核人',approvedon as '审核日期' ");
			sb.Append(" from finance_ff_master");	
			
			if(this.bConfirm == 0)
			{
				sb.Append(" where status='1' ");
			}
			else if(this.bConfirm == 1)
			{
				sb.Append(" where status='2'");
			}
			else if(this.bConfirm == 2)
			{
				sb.Append(" where status='3'");
			}
			else if(this.bConfirm == 10)
			{
				sb.Append(" where status='0'");
			}
			sb.Append(" order by ff_code ");
			
			this._sql = sb.ToString();
		}

		private void xpStyleButton1_Click(object sender, System.EventArgs e)
		{
			string PKValue = null;
			if(this.dataGrid1.CurrentRowIndex < 0)
			{
				TJSystem.Public.PublicStatic.ShowMessage(TJSystem.Public.MessageType.Information,"请先选中需要审核的单据！！！");
				return;
			}

			PKValue = ((System.Data.DataView)this.dataGrid1.DataSource)[this.dataGrid1.CurrentRowIndex][0].ToString().Trim();

			if(!CheckCurrentDocStatus(PKValue,"1"))
			{
				TJSystem.Public.PublicStatic.ShowMessage(TJSystem.Public.MessageType.Information,"当前单据状态不为新建状态，无法进行审核，请确认！！！");
				return;
			}
			this.UpdateDataGrid(PKValue,"2");			
		}

		private bool CheckCurrentDocStatus(string PKValue,string status)
		{
			System.Data.DataTable dt = null;

			System.Text.StringBuilder sb = new System.Text.StringBuilder();
			sb.Append("select status from ");
			sb.Append(this._table);
			sb.Append(" where ");
			sb.Append(this._PK);
			sb.Append("='");
			sb.Append(PKValue);
			sb.Append("'");
			sb.Append(" and status='");
			sb.Append(status);
			sb.Append("'");

			dt = TJSystem.Public.PublicStatic.db.GetDataTable(sb.ToString());

			if(dt.Rows.Count != 1)
			{
				return false;
			}

			return true;
		}

		private void UpdateDataGrid(string PKValue,string status)
		{
			System.Text.StringBuilder sb = new System.Text.StringBuilder();
			sb.Append("update ");
			sb.Append(this._table);
			sb.Append(" set status = '");
			sb.Append(status);
			sb.Append("',");
			sb.Append(" approvedby='");
			sb.Append(TJSystem.Public.PublicStatic.LoginUserName);
			sb.Append("',approvedon='");
			sb.Append(System.DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
			sb.Append("'");
			sb.Append(" where ");
			sb.Append(this._PK);
			sb.Append("='");
			sb.Append(PKValue);
			sb.Append("'");

			if(System.Windows.Forms.MessageBox.Show("确定要更新该"+this._tableName+"？","Question",System.Windows.Forms.MessageBoxButtons.YesNo,System.Windows.Forms.MessageBoxIcon.Question)
				== System.Windows.Forms.DialogResult.No)
			{
				return;
			}

			TJSystem.Public.PublicStatic.db.ExeSql(sb.ToString());

			FillDataGrid();
		}

		private void UpdateDataGridSaleCE()
		{

		}
		
		#region 删除内容
		private void UpdateDataGridSaleCQ()
		{
			_table = "sale_cq_master";
			_PK = "";
		}

		private void UpdateDataGridSaleCO()
		{
			_table = "sale_so_master";
			_PK = "";
		}

		private void UpdateDataGridSaleSS()
		{
			_table = "sale_ss_master";
			_PK = "";
		}

		private void UpdateDataGridPurchaseSE()
		{
			_table = "purchase_se_master";
			_PK = "";
		}

		private void UpdateDataGridPurchaseSQ()
		{
			_table = "purchase_sq_master";
			_PK = "";
		}

		private void UpdateDataGridPurchasePO()
		{
			_table = "purchase_po_master";
			_PK = "";
		}

		private void UpdateDataGridPurchaseRS()
		{
			_table = "purchase_rs_master";
			_PK = "";
		}
		
		private void UpdateDataGridDocSale()
		{
			_table = "sale_doc_master";
			_PK = "";
		}

		private void UpdateDataGridWayBill()
		{
			_table = "SALE_WAYBILL_MASTER";
			_PK = "";
		}

		private void UpdateDataGridDocLC()
		{
			_table = "SALE_LETTEROFCREDIT";
			_PK = "";
		}

		private void UpdateDataGridStockIn()
		{
			_table = "wip_stock_mstr";
			_PK = "";
		}

		private void UpdateDataGridStockOut()
		{
			_table = "wip_stock_mstr";
			_PK = "";
		}

		private void UpdateDataGridStockCHG()
		{
			_table = "wip_stock_mstr";
			_PK = "";
		}

		private void UpdateDataGridStockCycle()
		{
			_table = "wip_stock_cycle_mstr";
			_PK = "";
		}

		private void UpdateDataGridAccountCC()
		{
			_table = "finance_cc_master";
			_PK = "";
		}

		private void UpdateDataGridAccountFF()
		{
			_table = "finance_ff_master";
			_PK = "";
		}
		#endregion

		private void radioButton3_CheckedChanged(object sender, System.EventArgs e)
		{
			this.bConfirm = 1;
		}

		private void radioButton1_CheckedChanged(object sender, System.EventArgs e)
		{
			this.bConfirm = 0;
		}

		private void xpStyleButton2_Click(object sender, System.EventArgs e)
		{
			string PKValue = null;
			if(this.dataGrid1.CurrentRowIndex < 0)
			{
				TJSystem.Public.PublicStatic.ShowMessage(TJSystem.Public.MessageType.Information,"请先选中需要取消审核的单据！！！");
				return;
			}

			PKValue = ((System.Data.DataView)this.dataGrid1.DataSource)[this.dataGrid1.CurrentRowIndex][0].ToString().Trim();
			if(!CheckCurrentDocStatus(PKValue,"2"))
			{
				TJSystem.Public.PublicStatic.ShowMessage(TJSystem.Public.MessageType.Information,"当前单据状态不为审核状态，无法取消审核，请确认！！！");
				return;
			}
			this.UpdateDataGrid(PKValue,"1");		
		}

		private void xpStyleButton3_Click(object sender, System.EventArgs e)
		{
			string PKValue = null;
			if(this.dataGrid1.CurrentRowIndex < 0)
			{
				TJSystem.Public.PublicStatic.ShowMessage(TJSystem.Public.MessageType.Information,"请先选中需要确认的单据！！！");
				return;
			}

			PKValue = ((System.Data.DataView)this.dataGrid1.DataSource)[this.dataGrid1.CurrentRowIndex][0].ToString().Trim();
			if(!CheckCurrentDocStatus(PKValue,"2"))
			{
				TJSystem.Public.PublicStatic.ShowMessage(TJSystem.Public.MessageType.Information,"当前单据状态不为审核状态，无法进行确认关闭，请确认！！！");
				return;
			}
			this.UpdateDataGrid(PKValue,"3");		
		}

		private void xpStyleButton4_Click(object sender, System.EventArgs e)
		{
			string PKValue = null;
			if(this.dataGrid1.CurrentRowIndex < 0)
			{
				TJSystem.Public.PublicStatic.ShowMessage(TJSystem.Public.MessageType.Information,"请先选中需要取消确认的单据！！！");
				return;
			}

			PKValue = ((System.Data.DataView)this.dataGrid1.DataSource)[this.dataGrid1.CurrentRowIndex][0].ToString().Trim();
			if(!CheckCurrentDocStatus(PKValue,"3"))
			{
				TJSystem.Public.PublicStatic.ShowMessage(TJSystem.Public.MessageType.Information,"当前单据状态不为确认关闭状态，无法取消确认，请确认！！！");
				return;
			}
			this.UpdateDataGrid(PKValue,"2");		
		}

		private void xpStyleButton5_Click(object sender, System.EventArgs e)
		{
			string PKValue = null;
			if(this.dataGrid1.CurrentRowIndex < 0)
			{
				TJSystem.Public.PublicStatic.ShowMessage(TJSystem.Public.MessageType.Information,"请先选中需要作废的单据！！！");
				return;
			}

			PKValue = ((System.Data.DataView)this.dataGrid1.DataSource)[this.dataGrid1.CurrentRowIndex][0].ToString().Trim();
			if(System.Windows.Forms.MessageBox.Show("确定要作废该"+this._tableName+"？作废后将无法进行恢复该单据数据！！！","Question",System.Windows.Forms.MessageBoxButtons.YesNo,System.Windows.Forms.MessageBoxIcon.Question)
				== System.Windows.Forms.DialogResult.No)
			{
				return;
			}
			this.UpdateDataGrid(PKValue,"0");	
		}

		private void radioButton2_CheckedChanged(object sender, System.EventArgs e)
		{
			this.bConfirm = 2;
		}

		private void radioButton4_CheckedChanged(object sender, System.EventArgs e)
		{
			this.bConfirm = 10;
		}
	}
}

using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace TJSystem.Account
{
	/// <summary>
	/// Form1 的摘要说明。
	/// </summary>
	public class frmPaymentBillDetail : System.Windows.Forms.Form
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
		private System.Windows.Forms.Panel panel3;
		private TJSystem.UC.PriToolBar priToolBar1;
		public static System.Windows.Forms.Form frmCurrent = null ;

		private string _table = null;
		private TJSystem.Classes.PriTextBox txt1;
		private string _PK = null;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label4;
		private TJSystem.Classes.PriTextBox priTextBox3;
		private TJSystem.Classes.PriTextBox priTextBox2;
		private System.Windows.Forms.DataGridTextBoxColumn seq_no;
		private System.Windows.Forms.Label label5;
		private TJSystem.Classes.PriTextBox priTextBox4;
		private TJSystem.Classes.PriComboBox priComboBox2;
		private System.Windows.Forms.DataGridTextBoxColumn pa_code;
		private System.Windows.Forms.DataGridTextBoxColumn ref_code;
		private System.Windows.Forms.DataGridTextBoxColumn amount;
		private System.Windows.Forms.DataGridTextBoxColumn remark;
		private string _statusType = null;

		public frmPaymentBillDetail(string pa_code)
		{
			//
			// Windows 窗体设计器支持所必需的
			//
			InitializeComponent();

			_statusType = "";

			this.txt1.Text = pa_code;
			InitialFormData();

			System.Text.StringBuilder sb = new System.Text.StringBuilder();
			sb.Append("select pa_code,seq_no,ref_code,amount,remark  ");
			sb.Append(" from finance_payment_detail a");
			sb.Append(" where a.pa_code=");
			sb.Append("'");
			sb.Append(pa_code);
			sb.Append("'");
			
			sb.Append(" order by a.seq_no");
			this.InitialGrid(sb.ToString());
			//			this.textBox1.DataField = "PNO";
			priToolBar1.setCurrentForm = this;
			_table = "finance_payment_detail";
			_PK = "pa_code,seq_no";
			priToolBar1.Initial(_table,_PK,sb.ToString());
			priToolBar1.BeforeButtonClickEvent += new TJSystem.UC.PriToolBar.BeforeButotnClick(this.BeforeButtonClick);
			priToolBar1.AfterButtonClickEvent += new TJSystem.UC.PriToolBar.AfterButtonClick(this.AfterButtonClick);
			priToolBar1.setButtonVisibleFalse();
			priToolBar1.setButtonVisible("01234569");

			setDisable();
			//
			// TODO: 在 InitializeComponent 调用后添加任何构造函数代码
			//
		}
		private void InitialFormData()
		{
			string sql = null;
			System.Data.DataTable dt = null;
			System.Data.DataTable dtcpy = null;
			DataRow dr = null;
			sql = "select po_code,po_code + ' ' + po_date as po_desc from purchase_po_master where status > 0 order by po_code";
			dt = TJSystem.Public.PublicStatic.db.GetDataTable(sql);
			dr = dt.NewRow() ;
			dr[0] = "" ;
			dr[1] = "" ;
			dt.Rows.InsertAt(dr,0) ;
			dtcpy = dt.Copy();
			this.priComboBox2.DataSource = dtcpy.DefaultView;
			this.priComboBox2.ValueMember = "po_code";
			this.priComboBox2.DisplayMember = "po_desc";
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
				this.priComboBox2.Enabled = true;
				this.priTextBox2.Enabled = true;
				this.priTextBox3.Enabled = true;
				this.priTextBox4.Enabled = true;

				this.priTextBox4.Text = "";
				this.priComboBox2.Text = "";
				this.priTextBox2.Text = "";
				this.priTextBox3.Text = "";
			}
			else if(sqltype.Equals("update"))
			{
				this.priComboBox2.Enabled = true;
				this.priTextBox2.Enabled = false;
				this.priTextBox3.Enabled = true;
				this.priTextBox4.Enabled = true;
			}
		}

		private void InitialGrid(string sql)
		{		
			DataTable dt = TJSystem.Public.PublicStatic.db.GetDataTable(sql);
			dt.TableName = "finance_payment_detail";
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(frmPaymentBillDetail));
			this.dataGridTextBoxColumn2 = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumn3 = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumn1 = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumn4 = new System.Windows.Forms.DataGridTextBoxColumn();
			this.panel2 = new System.Windows.Forms.Panel();
			this.dataGrid1 = new System.Windows.Forms.DataGrid();
			this.dataGridTableStyle1 = new System.Windows.Forms.DataGridTableStyle();
			this.pa_code = new System.Windows.Forms.DataGridTextBoxColumn();
			this.seq_no = new System.Windows.Forms.DataGridTextBoxColumn();
			this.ref_code = new System.Windows.Forms.DataGridTextBoxColumn();
			this.amount = new System.Windows.Forms.DataGridTextBoxColumn();
			this.remark = new System.Windows.Forms.DataGridTextBoxColumn();
			this.panel4 = new System.Windows.Forms.Panel();
			this.priComboBox2 = new TJSystem.Classes.PriComboBox();
			this.priTextBox2 = new TJSystem.Classes.PriTextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.priTextBox3 = new TJSystem.Classes.PriTextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.txt1 = new TJSystem.Classes.PriTextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.priTextBox4 = new TJSystem.Classes.PriTextBox();
			this.panel3 = new System.Windows.Forms.Panel();
			this.priToolBar1 = new TJSystem.UC.PriToolBar();
			this.panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).BeginInit();
			this.panel4.SuspendLayout();
			this.panel3.SuspendLayout();
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
			this.panel2.Location = new System.Drawing.Point(0, 0);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(530, 430);
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
			this.dataGrid1.Location = new System.Drawing.Point(0, 152);
			this.dataGrid1.Name = "dataGrid1";
			this.dataGrid1.ReadOnly = true;
			this.dataGrid1.Size = new System.Drawing.Size(522, 264);
			this.dataGrid1.TabIndex = 1;
			this.dataGrid1.TableStyles.AddRange(new System.Windows.Forms.DataGridTableStyle[] {
																								  this.dataGridTableStyle1});
			// 
			// dataGridTableStyle1
			// 
			this.dataGridTableStyle1.AllowSorting = false;
			this.dataGridTableStyle1.DataGrid = this.dataGrid1;
			this.dataGridTableStyle1.GridColumnStyles.AddRange(new System.Windows.Forms.DataGridColumnStyle[] {
																												  this.pa_code,
																												  this.seq_no,
																												  this.ref_code,
																												  this.amount,
																												  this.remark});
			this.dataGridTableStyle1.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.dataGridTableStyle1.MappingName = "finance_payment_detail";
			this.dataGridTableStyle1.ReadOnly = true;
			// 
			// pa_code
			// 
			this.pa_code.Format = "";
			this.pa_code.FormatInfo = null;
			this.pa_code.HeaderText = "付款单号";
			this.pa_code.MappingName = "pa_code";
			this.pa_code.NullText = "";
			this.pa_code.Width = 75;
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
			// ref_code
			// 
			this.ref_code.Format = "";
			this.ref_code.FormatInfo = null;
			this.ref_code.HeaderText = "采购单号";
			this.ref_code.MappingName = "ref_code";
			this.ref_code.NullText = "";
			this.ref_code.Width = 75;
			// 
			// amount
			// 
			this.amount.Format = "";
			this.amount.FormatInfo = null;
			this.amount.HeaderText = "金额";
			this.amount.MappingName = "amount";
			this.amount.NullText = "";
			this.amount.Width = 75;
			// 
			// remark
			// 
			this.remark.Format = "";
			this.remark.FormatInfo = null;
			this.remark.HeaderText = "备注";
			this.remark.MappingName = "remark";
			this.remark.NullText = "";
			this.remark.Width = 75;
			// 
			// panel4
			// 
			this.panel4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel4.BackgroundImage")));
			this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.panel4.Controls.Add(this.priComboBox2);
			this.panel4.Controls.Add(this.priTextBox2);
			this.panel4.Controls.Add(this.label4);
			this.panel4.Controls.Add(this.priTextBox3);
			this.panel4.Controls.Add(this.label2);
			this.panel4.Controls.Add(this.label1);
			this.panel4.Controls.Add(this.txt1);
			this.panel4.Controls.Add(this.label3);
			this.panel4.Controls.Add(this.label5);
			this.panel4.Controls.Add(this.priTextBox4);
			this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel4.Location = new System.Drawing.Point(0, 0);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(526, 144);
			this.panel4.TabIndex = 0;
			// 
			// priComboBox2
			// 
			this.priComboBox2.BackColor = System.Drawing.Color.White;
			this.priComboBox2.DataField = "ref_code";
			this.priComboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.priComboBox2.Location = new System.Drawing.Point(112, 32);
			this.priComboBox2.Name = "priComboBox2";
			this.priComboBox2.Size = new System.Drawing.Size(248, 22);
			this.priComboBox2.TabIndex = 158;
			// 
			// priTextBox2
			// 
			this.priTextBox2.BackColor = System.Drawing.Color.Yellow;
			this.priTextBox2.DataField = "seq_no";
			this.priTextBox2.DataType = TJSystem.Public.DataType.String;
			this.priTextBox2.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.priTextBox2.Location = new System.Drawing.Point(352, 8);
			this.priTextBox2.Name = "priTextBox2";
			this.priTextBox2.Size = new System.Drawing.Size(144, 23);
			this.priTextBox2.TabIndex = 157;
			this.priTextBox2.Text = "";
			// 
			// label4
			// 
			this.label4.BackColor = System.Drawing.Color.Transparent;
			this.label4.Location = new System.Drawing.Point(24, 56);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(80, 23);
			this.label4.TabIndex = 154;
			this.label4.Text = "金额";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// priTextBox3
			// 
			this.priTextBox3.BackColor = System.Drawing.Color.Yellow;
			this.priTextBox3.DataField = "Amount";
			this.priTextBox3.DataType = TJSystem.Public.DataType.String;
			this.priTextBox3.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.priTextBox3.Location = new System.Drawing.Point(112, 56);
			this.priTextBox3.Name = "priTextBox3";
			this.priTextBox3.Size = new System.Drawing.Size(144, 23);
			this.priTextBox3.TabIndex = 153;
			this.priTextBox3.Text = "";
			// 
			// label2
			// 
			this.label2.BackColor = System.Drawing.Color.Transparent;
			this.label2.Location = new System.Drawing.Point(8, 32);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(96, 23);
			this.label2.TabIndex = 152;
			this.label2.Text = "采购单号";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Location = new System.Drawing.Point(304, 8);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(40, 23);
			this.label1.TabIndex = 150;
			this.label1.Text = "序号";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txt1
			// 
			this.txt1.DataField = "pa_code";
			this.txt1.DataType = TJSystem.Public.DataType.String;
			this.txt1.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.txt1.Location = new System.Drawing.Point(112, 8);
			this.txt1.Name = "txt1";
			this.txt1.Size = new System.Drawing.Size(144, 23);
			this.txt1.TabIndex = 148;
			this.txt1.Text = "";
			// 
			// label3
			// 
			this.label3.BackColor = System.Drawing.Color.Transparent;
			this.label3.Location = new System.Drawing.Point(24, 8);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(80, 23);
			this.label3.TabIndex = 150;
			this.label3.Text = "付款单号";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label5
			// 
			this.label5.BackColor = System.Drawing.Color.Transparent;
			this.label5.Location = new System.Drawing.Point(8, 80);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(96, 23);
			this.label5.TabIndex = 152;
			this.label5.Text = "备注";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// priTextBox4
			// 
			this.priTextBox4.BackColor = System.Drawing.Color.White;
			this.priTextBox4.DataField = "remark";
			this.priTextBox4.DataType = TJSystem.Public.DataType.String;
			this.priTextBox4.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.priTextBox4.Location = new System.Drawing.Point(112, 80);
			this.priTextBox4.Multiline = true;
			this.priTextBox4.Name = "priTextBox4";
			this.priTextBox4.Size = new System.Drawing.Size(384, 56);
			this.priTextBox4.TabIndex = 151;
			this.priTextBox4.Text = "";
			// 
			// panel3
			// 
			this.panel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel3.BackgroundImage")));
			this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.panel3.Controls.Add(this.priToolBar1);
			this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panel3.Location = new System.Drawing.Point(0, 430);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(530, 40);
			this.panel3.TabIndex = 9;
			// 
			// priToolBar1
			// 
			this.priToolBar1.DGEnable = true;
			this.priToolBar1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.priToolBar1.Location = new System.Drawing.Point(0, -4);
			this.priToolBar1.Name = "priToolBar1";
			this.priToolBar1.setCurrentForm = null;
			this.priToolBar1.Size = new System.Drawing.Size(526, 40);
			this.priToolBar1.TabIndex = 0;
			// 
			// frmPaymentBillDetail
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(7, 16);
			this.BackColor = System.Drawing.SystemColors.ScrollBar;
			this.ClientSize = new System.Drawing.Size(530, 470);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel3);
			this.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "frmPaymentBillDetail";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "货品资料";
			this.panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).EndInit();
			this.panel4.ResumeLayout(false);
			this.panel3.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		private void setDisable()
		{
			this.priComboBox2.Enabled = false;
			this.priTextBox2.Enabled = false;
			this.priTextBox3.Enabled = false;
			this.priTextBox4.Enabled = false;
			this.txt1.Enabled = false;
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

			if(!TJSystem.Public.PublicStatic.IsNumDouble(priTextBox2.Text.Trim()))
			{
				sb.Append("  序号必须是数字！");
				TJSystem.Public.PublicStatic.ShowMessage(TJSystem.Public.MessageType.Error,sb.ToString());
				return false;
			}

			if(!TJSystem.Public.PublicStatic.IsNumDouble(priTextBox3.Text.Trim()))
			{
				sb.Append("  金额必须是数字！");
				TJSystem.Public.PublicStatic.ShowMessage(TJSystem.Public.MessageType.Error,sb.ToString());
				return false;
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

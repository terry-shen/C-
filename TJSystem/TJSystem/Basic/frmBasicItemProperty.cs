using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace TJSystem.Basic
{
	/// <summary>
	/// Form1 的摘要说明。
	/// </summary>
	public class frmBasicItemProperty : System.Windows.Forms.Form
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
		private System.Windows.Forms.Label label5;
		private TJSystem.Classes.PriTextBox txt1;
		private string _PK = null;
		private TJSystem.Classes.PriTextBox priTextBox2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label3;
		private TJSystem.Classes.PriTextBox priTextBox1;
		private System.Windows.Forms.DataGridTextBoxColumn property_id;
		private System.Windows.Forms.DataGridTextBoxColumn seq_no;
		private System.Windows.Forms.DataGridTextBoxColumn property_value;
		private string _statusType = null;

		public frmBasicItemProperty(string itemcode)
		{
			//
			// Windows 窗体设计器支持所必需的
			//
			InitializeComponent();

			_statusType = "";

			this.txt1.Text = itemcode;
			InitialFormData();

			System.Text.StringBuilder sb = new System.Text.StringBuilder();
			sb.Append("select property_id,seq_no,property_value from basic_item_property_value  ");
			sb.Append("where property_id=");
			sb.Append("'");
			sb.Append(itemcode);
			sb.Append("'");
			
			sb.Append(" order by property_id,seq_no");
			
			//			this.textBox1.DataField = "PNO";
			priToolBar1.setCurrentForm = this;
			_table = "basic_item_property_value";
			_PK = "property_id,seq_no";

			
			this.InitialGrid(sb.ToString());
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
//				this.priComboBox2.Enabled = true;
				this.priTextBox2.Enabled = true;
				this.priTextBox1.Enabled = true;

//				this.priComboBox2.Text = "";
				this.priTextBox1.Text = "";
				this.priTextBox2.Text = "";
			}
			else if(sqltype.Equals("update"))
			{
				this.priTextBox2.Enabled = true;
				this.priTextBox1.Enabled = true;
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(frmBasicItemProperty));
			this.dataGridTextBoxColumn2 = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumn3 = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumn1 = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumn4 = new System.Windows.Forms.DataGridTextBoxColumn();
			this.panel2 = new System.Windows.Forms.Panel();
			this.dataGrid1 = new System.Windows.Forms.DataGrid();
			this.dataGridTableStyle1 = new System.Windows.Forms.DataGridTableStyle();
			this.property_id = new System.Windows.Forms.DataGridTextBoxColumn();
			this.seq_no = new System.Windows.Forms.DataGridTextBoxColumn();
			this.property_value = new System.Windows.Forms.DataGridTextBoxColumn();
			this.panel4 = new System.Windows.Forms.Panel();
			this.priTextBox1 = new TJSystem.Classes.PriTextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.priTextBox2 = new TJSystem.Classes.PriTextBox();
			this.txt1 = new TJSystem.Classes.PriTextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
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
			this.panel2.Size = new System.Drawing.Size(384, 430);
			this.panel2.TabIndex = 8;
			// 
			// dataGrid1
			// 
			this.dataGrid1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.dataGrid1.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.dataGrid1.CaptionVisible = false;
			this.dataGrid1.DataMember = "";
			this.dataGrid1.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.dataGrid1.Location = new System.Drawing.Point(0, 96);
			this.dataGrid1.Name = "dataGrid1";
			this.dataGrid1.ReadOnly = true;
			this.dataGrid1.Size = new System.Drawing.Size(376, 320);
			this.dataGrid1.TabIndex = 1;
			this.dataGrid1.TableStyles.AddRange(new System.Windows.Forms.DataGridTableStyle[] {
																								  this.dataGridTableStyle1});
			// 
			// dataGridTableStyle1
			// 
			this.dataGridTableStyle1.AllowSorting = false;
			this.dataGridTableStyle1.DataGrid = this.dataGrid1;
			this.dataGridTableStyle1.GridColumnStyles.AddRange(new System.Windows.Forms.DataGridColumnStyle[] {
																												  this.property_id,
																												  this.seq_no,
																												  this.property_value});
			this.dataGridTableStyle1.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.dataGridTableStyle1.MappingName = "basic_item_property_value";
			this.dataGridTableStyle1.ReadOnly = true;
			// 
			// property_id
			// 
			this.property_id.Format = "";
			this.property_id.FormatInfo = null;
			this.property_id.HeaderText = "货品编号";
			this.property_id.MappingName = "property_id";
			this.property_id.NullText = "";
			this.property_id.Width = 75;
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
			// property_value
			// 
			this.property_value.Format = "";
			this.property_value.FormatInfo = null;
			this.property_value.HeaderText = "原料";
			this.property_value.MappingName = "property_value";
			this.property_value.NullText = "";
			this.property_value.Width = 75;
			// 
			// panel4
			// 
			this.panel4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel4.BackgroundImage")));
			this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.panel4.Controls.Add(this.priTextBox1);
			this.panel4.Controls.Add(this.label1);
			this.panel4.Controls.Add(this.priTextBox2);
			this.panel4.Controls.Add(this.txt1);
			this.panel4.Controls.Add(this.label5);
			this.panel4.Controls.Add(this.label3);
			this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel4.Location = new System.Drawing.Point(0, 0);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(380, 88);
			this.panel4.TabIndex = 0;
			// 
			// priTextBox1
			// 
			this.priTextBox1.BackColor = System.Drawing.Color.Yellow;
			this.priTextBox1.DataField = "seq_no";
			this.priTextBox1.DataType = TJSystem.Public.DataType.String;
			this.priTextBox1.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.priTextBox1.Location = new System.Drawing.Point(104, 32);
			this.priTextBox1.Name = "priTextBox1";
			this.priTextBox1.Size = new System.Drawing.Size(168, 23);
			this.priTextBox1.TabIndex = 151;
			this.priTextBox1.Text = "";
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Location = new System.Drawing.Point(16, 56);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(80, 23);
			this.label1.TabIndex = 150;
			this.label1.Text = "原料";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// priTextBox2
			// 
			this.priTextBox2.DataField = "property_value";
			this.priTextBox2.DataType = TJSystem.Public.DataType.String;
			this.priTextBox2.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.priTextBox2.Location = new System.Drawing.Point(104, 56);
			this.priTextBox2.Name = "priTextBox2";
			this.priTextBox2.Size = new System.Drawing.Size(256, 23);
			this.priTextBox2.TabIndex = 149;
			this.priTextBox2.Text = "";
			// 
			// txt1
			// 
			this.txt1.DataField = "property_id";
			this.txt1.DataType = TJSystem.Public.DataType.String;
			this.txt1.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.txt1.Location = new System.Drawing.Point(104, 8);
			this.txt1.Name = "txt1";
			this.txt1.Size = new System.Drawing.Size(256, 23);
			this.txt1.TabIndex = 148;
			this.txt1.Text = "";
			// 
			// label5
			// 
			this.label5.BackColor = System.Drawing.Color.Transparent;
			this.label5.ForeColor = System.Drawing.Color.Blue;
			this.label5.Location = new System.Drawing.Point(16, 32);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(80, 23);
			this.label5.TabIndex = 52;
			this.label5.Text = "序号";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label3
			// 
			this.label3.BackColor = System.Drawing.Color.Transparent;
			this.label3.Location = new System.Drawing.Point(16, 8);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(80, 23);
			this.label3.TabIndex = 150;
			this.label3.Text = "货品编号";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// panel3
			// 
			this.panel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel3.BackgroundImage")));
			this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.panel3.Controls.Add(this.priToolBar1);
			this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panel3.Location = new System.Drawing.Point(0, 430);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(384, 40);
			this.panel3.TabIndex = 9;
			// 
			// priToolBar1
			// 
			this.priToolBar1.DGEnable = true;
			this.priToolBar1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.priToolBar1.Location = new System.Drawing.Point(0, -4);
			this.priToolBar1.Name = "priToolBar1";
			this.priToolBar1.setCurrentForm = null;
			this.priToolBar1.Size = new System.Drawing.Size(380, 40);
			this.priToolBar1.TabIndex = 0;
			// 
			// frmBasicItemProperty
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(7, 16);
			this.BackColor = System.Drawing.SystemColors.ScrollBar;
			this.ClientSize = new System.Drawing.Size(384, 470);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel3);
			this.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "frmBasicItemProperty";
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
//			this.priComboBox2.Enabled = false;
			this.priTextBox2.Enabled = false;
			this.priTextBox1.Enabled = false;
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

			if(this.priTextBox2.Text.Trim().Equals(""))
			{
				TJSystem.Public.PublicStatic.ShowMessage(TJSystem.Public.MessageType.Error,"必须填写原料名称");
				return false;
			}
			if (!TJSystem.Public.PublicStatic.IsNumDouble(this.priTextBox1.Text.Trim()))
			{
				TJSystem.Public.PublicStatic.ShowMessage(TJSystem.Public.MessageType.Error,"请确认序号为数字，不是其他值");
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

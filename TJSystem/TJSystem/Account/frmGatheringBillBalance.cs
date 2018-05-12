using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace TJSystem.Account
{
	/// <summary>
	/// </summary>
	public class frmGatheringBillBalance : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Panel panel3;
		private TJSystem.UC.PriToolBar priToolBar1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.DataGridTableStyle dataGridTableStyle1;
		private System.Windows.Forms.DataGrid dataGrid1;
		private System.Windows.Forms.Panel panel4;
		private TJSystem.Classes.PriTextBox priTextBox9;
		private System.Windows.Forms.Label label22;
		private TJSystem.Classes.PriTextBox priTextBox8;
		private System.Windows.Forms.Label label20;
		private TJSystem.Classes.PriTextBox priTextBox4;
		private System.Windows.Forms.Label label14;
		private TJSystem.Classes.PriTextBox priTextBox5;
		private TJSystem.Classes.PriTextBox priTextBox3;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label7;
		private TJSystem.Classes.PriTextBox priTextBox7;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label2;
		private TJSystem.Classes.PriTextBox priTextBox1;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label1;
		private TJSystem.Classes.PriComboBox comboBox1;
		private TJSystem.Classes.PriTextBox priTextBox2;
		private System.Windows.Forms.Label label11;
		/// <summary>

		/// </summary>
		private System.ComponentModel.Container components = null;
		private TJSystem.Classes.PriDateTimePicker dateTimePicker1;
		public static System.Windows.Forms.Form frmCurrent = null;

		public frmGatheringBillBalance()
		{
			InitializeComponent();

			

			TJSystem.Public.PublicStatic.setBackgroundImg(this.panel1,this.panel1.GetType().ToString(),"images\\bg.gif");
			TJSystem.Public.PublicStatic.setBackgroundImg(this.panel2,this.panel1.GetType().ToString(),"");
			TJSystem.Public.PublicStatic.setBackgroundImg(this.panel3,this.panel1.GetType().ToString(),"");
			TJSystem.Public.PublicStatic.setBackgroundImg(this.panel4,this.panel1.GetType().ToString(),"");

			InitialFormData();

			System.Text.StringBuilder sb = new System.Text.StringBuilder();
			sb.Append("select pba_code,pba_date,supplier_id,supplier_name,Currency,");
			sb.Append("remark,CreateOn,CreateBy,modifyOn,modifyBy");
			sb.Append(" from finance_rba_master");
			sb.Append(" order by pba_code");
			this.InitialGrid(sb.ToString());
			priToolBar1.setCurrentForm = this;
			priToolBar1.Initial("finance_rba_master","pba_code",sb.ToString());
			priToolBar1.BeforeButtonClickEvent += new TJSystem.UC.PriToolBar.BeforeButotnClick(this.BeforeButtonClick);
			priToolBar1.AfterButtonClickEvent += new TJSystem.UC.PriToolBar.AfterButtonClick(this.AfterButtonClick);
			this.priToolBar1.setButtonVisibleFalse();;
			this.priToolBar1.setButtonVisible("012345689");

		}

		private bool BeforeButtonClick(string ButtonType)
		{
			return true;
		}

		private void AfterButtonClick(string sqltype)
		{
		}

		private void InitialFormData()
		{
			string sql = "select supplier_id,supplier_id+' '+supplier_name as supplier_namecn from basic_supplier order by supplier_id";
			DataTable dt = TJSystem.Public.PublicStatic.db.GetDataTable(sql);
			this.comboBox1.DataSource = dt.DefaultView;
			this.comboBox1.ValueMember = "supplier_id";
			this.comboBox1.DisplayMember = "supplier_id";
		}

		private void InitialGrid(string sql)
		{		
			DataTable dt = TJSystem.Public.PublicStatic.db.GetDataTable(sql);
			dt.TableName = "finance_rba_master";
			this.dataGridTableStyle1.DataGrid.DataSource = dt.DefaultView;
		}

		/// <summary>

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
		protected override void OnClosing(CancelEventArgs e)
		{			
//			if(MessageBox.Show("确定退出？（Y/N）","确认",MessageBoxButtons.YesNo,MessageBoxIcon.Information) == System.Windows.Forms.DialogResult.No)
//			{
//				e.Cancel = true;
//			}
//			else
			{
				TJSystem.Public.PublicStatic.formClose = true;
				TJSystem.Public.PublicStatic.formName = "收款单冲销应收单";
			}
			base.OnClosing (e);
		}
		#region Windows Form 
		/// <summary>

		/// </summary>
		private void InitializeComponent()
		{
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(frmGatheringBillBalance));
			this.panel3 = new System.Windows.Forms.Panel();
			this.priToolBar1 = new TJSystem.UC.PriToolBar();
			this.panel2 = new System.Windows.Forms.Panel();
			this.dataGrid1 = new System.Windows.Forms.DataGrid();
			this.dataGridTableStyle1 = new System.Windows.Forms.DataGridTableStyle();
			this.panel4 = new System.Windows.Forms.Panel();
			this.dateTimePicker1 = new TJSystem.Classes.PriDateTimePicker();
			this.priTextBox9 = new TJSystem.Classes.PriTextBox();
			this.label22 = new System.Windows.Forms.Label();
			this.priTextBox8 = new TJSystem.Classes.PriTextBox();
			this.label20 = new System.Windows.Forms.Label();
			this.priTextBox4 = new TJSystem.Classes.PriTextBox();
			this.label14 = new System.Windows.Forms.Label();
			this.priTextBox5 = new TJSystem.Classes.PriTextBox();
			this.priTextBox3 = new TJSystem.Classes.PriTextBox();
			this.label9 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.priTextBox7 = new TJSystem.Classes.PriTextBox();
			this.label12 = new System.Windows.Forms.Label();
			this.comboBox1 = new TJSystem.Classes.PriComboBox();
			this.priTextBox2 = new TJSystem.Classes.PriTextBox();
			this.label11 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.priTextBox1 = new TJSystem.Classes.PriTextBox();
			this.panel1 = new System.Windows.Forms.Panel();
			this.label1 = new System.Windows.Forms.Label();
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
			this.panel3.Location = new System.Drawing.Point(0, 529);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(792, 37);
			this.panel3.TabIndex = 24;
			// 
			// priToolBar1
			// 
			this.priToolBar1.DGEnable = true;
			this.priToolBar1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.priToolBar1.Location = new System.Drawing.Point(0, -5);
			this.priToolBar1.Name = "priToolBar1";
			this.priToolBar1.setCurrentForm = null;
			this.priToolBar1.Size = new System.Drawing.Size(788, 38);
			this.priToolBar1.TabIndex = 0;
			// 
			// panel2
			// 
			this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
			this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.panel2.Controls.Add(this.dataGrid1);
			this.panel2.Controls.Add(this.panel4);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel2.Location = new System.Drawing.Point(0, 45);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(792, 521);
			this.panel2.TabIndex = 23;
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
			this.dataGrid1.Location = new System.Drawing.Point(0, 176);
			this.dataGrid1.Name = "dataGrid1";
			this.dataGrid1.ReadOnly = true;
			this.dataGrid1.Size = new System.Drawing.Size(783, 304);
			this.dataGrid1.TabIndex = 1;
			this.dataGrid1.TableStyles.AddRange(new System.Windows.Forms.DataGridTableStyle[] {
																								  this.dataGridTableStyle1});
			// 
			// dataGridTableStyle1
			// 
			this.dataGridTableStyle1.AllowSorting = false;
			this.dataGridTableStyle1.DataGrid = this.dataGrid1;
			this.dataGridTableStyle1.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.dataGridTableStyle1.MappingName = "finance_pba_master";
			this.dataGridTableStyle1.ReadOnly = true;
			// 
			// panel4
			// 
			this.panel4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel4.BackgroundImage")));
			this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.panel4.Controls.Add(this.dateTimePicker1);
			this.panel4.Controls.Add(this.priTextBox9);
			this.panel4.Controls.Add(this.label22);
			this.panel4.Controls.Add(this.priTextBox8);
			this.panel4.Controls.Add(this.label20);
			this.panel4.Controls.Add(this.priTextBox4);
			this.panel4.Controls.Add(this.label14);
			this.panel4.Controls.Add(this.priTextBox5);
			this.panel4.Controls.Add(this.priTextBox3);
			this.panel4.Controls.Add(this.label9);
			this.panel4.Controls.Add(this.label7);
			this.panel4.Controls.Add(this.priTextBox7);
			this.panel4.Controls.Add(this.label12);
			this.panel4.Controls.Add(this.comboBox1);
			this.panel4.Controls.Add(this.priTextBox2);
			this.panel4.Controls.Add(this.label11);
			this.panel4.Controls.Add(this.label3);
			this.panel4.Controls.Add(this.label10);
			this.panel4.Controls.Add(this.label2);
			this.panel4.Controls.Add(this.priTextBox1);
			this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel4.Location = new System.Drawing.Point(0, 0);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(788, 168);
			this.panel4.TabIndex = 0;
			// 
			// dateTimePicker1
			// 
			this.dateTimePicker1.CustomFormat = "yyyy-MM-dd";
			this.dateTimePicker1.DataField = "rba_date";
			this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dateTimePicker1.Location = new System.Drawing.Point(368, 15);
			this.dateTimePicker1.Name = "dateTimePicker1";
			this.dateTimePicker1.Size = new System.Drawing.Size(144, 22);
			this.dateTimePicker1.TabIndex = 154;
			this.dateTimePicker1.Value = new System.DateTime(2007, 2, 4, 16, 42, 7, 859);
			// 
			// priTextBox9
			// 
			this.priTextBox9.BackColor = System.Drawing.SystemColors.InactiveBorder;
			this.priTextBox9.DataField = "modifyBy";
			this.priTextBox9.DataType = TJSystem.Public.DataType.String;
			this.priTextBox9.Enabled = false;
			this.priTextBox9.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.priTextBox9.Location = new System.Drawing.Point(368, 136);
			this.priTextBox9.Name = "priTextBox9";
			this.priTextBox9.Size = new System.Drawing.Size(144, 23);
			this.priTextBox9.TabIndex = 153;
			this.priTextBox9.Text = "";
			// 
			// label22
			// 
			this.label22.BackColor = System.Drawing.Color.Transparent;
			this.label22.Location = new System.Drawing.Point(269, 136);
			this.label22.Name = "label22";
			this.label22.Size = new System.Drawing.Size(96, 22);
			this.label22.TabIndex = 152;
			this.label22.Text = "最后修改人";
			this.label22.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.label22.Click += new System.EventHandler(this.label22_Click);
			// 
			// priTextBox8
			// 
			this.priTextBox8.BackColor = System.Drawing.SystemColors.InactiveBorder;
			this.priTextBox8.DataField = "modifyOn";
			this.priTextBox8.DataType = TJSystem.Public.DataType.String;
			this.priTextBox8.Enabled = false;
			this.priTextBox8.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.priTextBox8.Location = new System.Drawing.Point(368, 112);
			this.priTextBox8.Name = "priTextBox8";
			this.priTextBox8.Size = new System.Drawing.Size(144, 23);
			this.priTextBox8.TabIndex = 151;
			this.priTextBox8.Text = "";
			// 
			// label20
			// 
			this.label20.BackColor = System.Drawing.Color.Transparent;
			this.label20.Location = new System.Drawing.Point(260, 112);
			this.label20.Name = "label20";
			this.label20.Size = new System.Drawing.Size(105, 21);
			this.label20.TabIndex = 150;
			this.label20.Text = "最后修改时间";
			this.label20.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// priTextBox4
			// 
			this.priTextBox4.BackColor = System.Drawing.SystemColors.InactiveBorder;
			this.priTextBox4.DataField = "CreateBy";
			this.priTextBox4.DataType = TJSystem.Public.DataType.String;
			this.priTextBox4.Enabled = false;
			this.priTextBox4.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.priTextBox4.Location = new System.Drawing.Point(112, 112);
			this.priTextBox4.Name = "priTextBox4";
			this.priTextBox4.Size = new System.Drawing.Size(144, 23);
			this.priTextBox4.TabIndex = 149;
			this.priTextBox4.Text = "";
			// 
			// label14
			// 
			this.label14.BackColor = System.Drawing.Color.Transparent;
			this.label14.Location = new System.Drawing.Point(27, 112);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(77, 21);
			this.label14.TabIndex = 148;
			this.label14.Text = "创建者";
			this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// priTextBox5
			// 
			this.priTextBox5.BackColor = System.Drawing.SystemColors.InactiveBorder;
			this.priTextBox5.DataField = "CreateOn";
			this.priTextBox5.DataType = TJSystem.Public.DataType.String;
			this.priTextBox5.Enabled = false;
			this.priTextBox5.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.priTextBox5.Location = new System.Drawing.Point(112, 136);
			this.priTextBox5.Name = "priTextBox5";
			this.priTextBox5.Size = new System.Drawing.Size(144, 23);
			this.priTextBox5.TabIndex = 147;
			this.priTextBox5.Text = "";
			// 
			// priTextBox3
			// 
			this.priTextBox3.DataField = "remark";
			this.priTextBox3.DataType = TJSystem.Public.DataType.String;
			this.priTextBox3.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.priTextBox3.Location = new System.Drawing.Point(112, 88);
			this.priTextBox3.Name = "priTextBox3";
			this.priTextBox3.Size = new System.Drawing.Size(403, 23);
			this.priTextBox3.TabIndex = 146;
			this.priTextBox3.Text = "";
			// 
			// label9
			// 
			this.label9.BackColor = System.Drawing.Color.Transparent;
			this.label9.Location = new System.Drawing.Point(8, 136);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(96, 22);
			this.label9.TabIndex = 145;
			this.label9.Text = "创建日期";
			this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label7
			// 
			this.label7.BackColor = System.Drawing.Color.Transparent;
			this.label7.Location = new System.Drawing.Point(8, 88);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(96, 22);
			this.label7.TabIndex = 144;
			this.label7.Text = "备注";
			this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// priTextBox7
			// 
			this.priTextBox7.DataField = "Currency";
			this.priTextBox7.DataType = TJSystem.Public.DataType.String;
			this.priTextBox7.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.priTextBox7.Location = new System.Drawing.Point(368, 40);
			this.priTextBox7.Name = "priTextBox7";
			this.priTextBox7.Size = new System.Drawing.Size(144, 23);
			this.priTextBox7.TabIndex = 143;
			this.priTextBox7.Text = "RMB";
			// 
			// label12
			// 
			this.label12.BackColor = System.Drawing.Color.Transparent;
			this.label12.Location = new System.Drawing.Point(288, 40);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(77, 21);
			this.label12.TabIndex = 142;
			this.label12.Text = "货币";
			this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// comboBox1
			// 
			this.comboBox1.DataField = "Client_id";
			this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBox1.ItemHeight = 13;
			this.comboBox1.Location = new System.Drawing.Point(112, 40);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(144, 21);
			this.comboBox1.TabIndex = 141;
			// 
			// priTextBox2
			// 
			this.priTextBox2.BackColor = System.Drawing.SystemColors.InactiveBorder;
			this.priTextBox2.DataField = "Client_name";
			this.priTextBox2.DataType = TJSystem.Public.DataType.String;
			this.priTextBox2.Enabled = false;
			this.priTextBox2.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.priTextBox2.Location = new System.Drawing.Point(112, 64);
			this.priTextBox2.Name = "priTextBox2";
			this.priTextBox2.Size = new System.Drawing.Size(403, 23);
			this.priTextBox2.TabIndex = 140;
			this.priTextBox2.Text = "";
			// 
			// label11
			// 
			this.label11.BackColor = System.Drawing.Color.Transparent;
			this.label11.Location = new System.Drawing.Point(8, 64);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(96, 21);
			this.label11.TabIndex = 139;
			this.label11.Text = "客户名称";
			this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label3
			// 
			this.label3.BackColor = System.Drawing.Color.Transparent;
			this.label3.ForeColor = System.Drawing.Color.Blue;
			this.label3.Location = new System.Drawing.Point(8, 40);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(96, 21);
			this.label3.TabIndex = 138;
			this.label3.Text = "客户号码";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label10
			// 
			this.label10.BackColor = System.Drawing.Color.Transparent;
			this.label10.Location = new System.Drawing.Point(288, 15);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(77, 21);
			this.label10.TabIndex = 117;
			this.label10.Text = "冲销日期";
			this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label2
			// 
			this.label2.BackColor = System.Drawing.Color.Transparent;
			this.label2.ForeColor = System.Drawing.Color.Blue;
			this.label2.Location = new System.Drawing.Point(8, 15);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(96, 21);
			this.label2.TabIndex = 115;
			this.label2.Text = "冲销编号";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// priTextBox1
			// 
			this.priTextBox1.DataField = "rba_code";
			this.priTextBox1.DataType = TJSystem.Public.DataType.String;
			this.priTextBox1.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.priTextBox1.Location = new System.Drawing.Point(112, 15);
			this.priTextBox1.Name = "priTextBox1";
			this.priTextBox1.Size = new System.Drawing.Size(144, 23);
			this.priTextBox1.TabIndex = 116;
			this.priTextBox1.Text = "";
			// 
			// panel1
			// 
			this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
			this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.panel1.Controls.Add(this.label1);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(792, 45);
			this.panel1.TabIndex = 22;
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label1.Font = new System.Drawing.Font("宋体", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.label1.Location = new System.Drawing.Point(0, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(788, 41);
			this.label1.TabIndex = 0;
			this.label1.Text = "收款单冲销应收单";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// frmGatheringBillBalance
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(7, 15);
			this.ClientSize = new System.Drawing.Size(792, 566);
			this.Controls.Add(this.panel3);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.Font = new System.Drawing.Font("宋体", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.Name = "frmGatheringBillBalance";
			this.Text = "收款单冲销应收单";
			this.panel3.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).EndInit();
			this.panel4.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		private void label22_Click(object sender, System.EventArgs e)
		{
		
		}
	}
}

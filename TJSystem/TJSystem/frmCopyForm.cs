using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace TJSystem
{
	/// <summary>
	/// frmCopyForm 的摘要说明。
	/// </summary>
	public class frmCopyForm : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.ComboBox comboBox2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.CheckBox checkBox1;
		private System.Windows.Forms.CheckBox checkBox2;
		private System.Windows.Forms.CheckBox checkBox3;
		private System.Windows.Forms.CheckBox checkBox5;
		private System.Windows.Forms.CheckBox checkBox6;
		private System.Windows.Forms.CheckBox checkBox7;
		private System.Windows.Forms.CheckBox checkBox9;
		private System.Windows.Forms.CheckBox checkBox10;
		private System.Windows.Forms.Button button1;
		/// <summary>
		/// 必需的设计器变量。
		/// </summary>
		private System.ComponentModel.Container components = null;
		private System.Windows.Forms.GroupBox groupBox1;

		public static System.Windows.Forms.Form frmCurrent = null ;

		public frmCopyForm()
		{
			//
			// Windows 窗体设计器支持所必需的
			//
			InitializeComponent();

			InitialTypeComboBox();

			//
			// TODO: 在 InitializeComponent 调用后添加任何构造函数代码
			//
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

		protected override void OnClosing(CancelEventArgs e)
		{			
			frmCurrent = null ;
			TJSystem.Public.PublicStatic.formClose = true;
			TJSystem.Public.PublicStatic.formName = "单据复制";
			base.OnClosing (e);
		}

		#region Windows 窗体设计器生成的代码
		/// <summary>
		/// 设计器支持所需的方法 - 不要使用代码编辑器修改
		/// 此方法的内容。
		/// </summary>
		private void InitializeComponent()
		{
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(frmCopyForm));
			this.panel1 = new System.Windows.Forms.Panel();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.comboBox2 = new System.Windows.Forms.ComboBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.checkBox1 = new System.Windows.Forms.CheckBox();
			this.checkBox2 = new System.Windows.Forms.CheckBox();
			this.checkBox3 = new System.Windows.Forms.CheckBox();
			this.checkBox5 = new System.Windows.Forms.CheckBox();
			this.checkBox6 = new System.Windows.Forms.CheckBox();
			this.checkBox7 = new System.Windows.Forms.CheckBox();
			this.checkBox9 = new System.Windows.Forms.CheckBox();
			this.checkBox10 = new System.Windows.Forms.CheckBox();
			this.button1 = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.panel1.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
			this.panel1.Controls.Add(this.label1);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(450, 48);
			this.panel1.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label1.Font = new System.Drawing.Font("宋体", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.label1.Location = new System.Drawing.Point(0, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(450, 48);
			this.label1.TabIndex = 0;
			this.label1.Text = "单据复制";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label2
			// 
			this.label2.BackColor = System.Drawing.Color.Transparent;
			this.label2.Location = new System.Drawing.Point(24, 72);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(72, 23);
			this.label2.TabIndex = 1;
			this.label2.Text = "源单号";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// comboBox1
			// 
			this.comboBox1.Items.AddRange(new object[] {
														   "采购询价单",
														   "供应商报价单",
														   "采购订单",
														   "客户询价单",
														   "报价单",
														   "销售订单"});
			this.comboBox1.Location = new System.Drawing.Point(96, 72);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(144, 20);
			this.comboBox1.TabIndex = 2;
			this.comboBox1.SelectionChangeCommitted += new System.EventHandler(this.comboBox1_SelectionChangeCommitted);
			// 
			// comboBox2
			// 
			this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBox2.Location = new System.Drawing.Point(256, 72);
			this.comboBox2.Name = "comboBox2";
			this.comboBox2.Size = new System.Drawing.Size(168, 20);
			this.comboBox2.TabIndex = 3;
			// 
			// label3
			// 
			this.label3.BackColor = System.Drawing.Color.Transparent;
			this.label3.Location = new System.Drawing.Point(504, 400);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(128, 23);
			this.label3.TabIndex = 4;
			this.label3.Text = "生成以下单据";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label4
			// 
			this.label4.BackColor = System.Drawing.Color.Transparent;
			this.label4.Location = new System.Drawing.Point(24, 96);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(72, 23);
			this.label4.TabIndex = 1;
			this.label4.Text = "新单号";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(96, 96);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(144, 21);
			this.textBox1.TabIndex = 5;
			this.textBox1.Text = "";
			// 
			// checkBox1
			// 
			this.checkBox1.BackColor = System.Drawing.Color.Transparent;
			this.checkBox1.Location = new System.Drawing.Point(8, 32);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.Size = new System.Drawing.Size(136, 24);
			this.checkBox1.TabIndex = 6;
			this.checkBox1.Text = "采购询价单";
			// 
			// checkBox2
			// 
			this.checkBox2.BackColor = System.Drawing.Color.Transparent;
			this.checkBox2.Location = new System.Drawing.Point(8, 56);
			this.checkBox2.Name = "checkBox2";
			this.checkBox2.Size = new System.Drawing.Size(136, 24);
			this.checkBox2.TabIndex = 6;
			this.checkBox2.Text = "供应商报价单";
			// 
			// checkBox3
			// 
			this.checkBox3.BackColor = System.Drawing.Color.Transparent;
			this.checkBox3.Location = new System.Drawing.Point(8, 80);
			this.checkBox3.Name = "checkBox3";
			this.checkBox3.Size = new System.Drawing.Size(136, 24);
			this.checkBox3.TabIndex = 6;
			this.checkBox3.Text = "采购订单";
			// 
			// checkBox5
			// 
			this.checkBox5.BackColor = System.Drawing.Color.Transparent;
			this.checkBox5.Location = new System.Drawing.Point(144, 32);
			this.checkBox5.Name = "checkBox5";
			this.checkBox5.Size = new System.Drawing.Size(136, 24);
			this.checkBox5.TabIndex = 6;
			this.checkBox5.Text = "客户询价单";
			// 
			// checkBox6
			// 
			this.checkBox6.BackColor = System.Drawing.Color.Transparent;
			this.checkBox6.Location = new System.Drawing.Point(144, 56);
			this.checkBox6.Name = "checkBox6";
			this.checkBox6.Size = new System.Drawing.Size(136, 24);
			this.checkBox6.TabIndex = 6;
			this.checkBox6.Text = "报价单";
			// 
			// checkBox7
			// 
			this.checkBox7.BackColor = System.Drawing.Color.Transparent;
			this.checkBox7.Location = new System.Drawing.Point(144, 80);
			this.checkBox7.Name = "checkBox7";
			this.checkBox7.Size = new System.Drawing.Size(136, 24);
			this.checkBox7.TabIndex = 6;
			this.checkBox7.Text = "销售订单";
			// 
			// checkBox9
			// 
			this.checkBox9.BackColor = System.Drawing.Color.Transparent;
			this.checkBox9.Location = new System.Drawing.Point(280, 32);
			this.checkBox9.Name = "checkBox9";
			this.checkBox9.Size = new System.Drawing.Size(96, 24);
			this.checkBox9.TabIndex = 6;
			this.checkBox9.Text = "单证";
			// 
			// checkBox10
			// 
			this.checkBox10.BackColor = System.Drawing.Color.Transparent;
			this.checkBox10.Location = new System.Drawing.Point(280, 56);
			this.checkBox10.Name = "checkBox10";
			this.checkBox10.Size = new System.Drawing.Size(96, 24);
			this.checkBox10.TabIndex = 6;
			this.checkBox10.Text = "货物托运单";
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(128, 256);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(200, 32);
			this.button1.TabIndex = 7;
			this.button1.Text = "确认";
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// groupBox1
			// 
			this.groupBox1.BackColor = System.Drawing.Color.Transparent;
			this.groupBox1.Controls.Add(this.checkBox5);
			this.groupBox1.Controls.Add(this.checkBox6);
			this.groupBox1.Controls.Add(this.checkBox7);
			this.groupBox1.Controls.Add(this.checkBox9);
			this.groupBox1.Controls.Add(this.checkBox3);
			this.groupBox1.Controls.Add(this.checkBox10);
			this.groupBox1.Controls.Add(this.checkBox1);
			this.groupBox1.Controls.Add(this.checkBox2);
			this.groupBox1.Location = new System.Drawing.Point(24, 128);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(408, 112);
			this.groupBox1.TabIndex = 8;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "生成以下单据";
			// 
			// frmCopyForm
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.ClientSize = new System.Drawing.Size(450, 304);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.comboBox2);
			this.Controls.Add(this.comboBox1);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.label4);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frmCopyForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "单据复制";
			this.panel1.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		private void button1_Click(object sender, System.EventArgs e)
		{
			PublicStatic.Classes.common.CommonSubTableHandle csth = new PublicStatic.Classes.common.CommonSubTableHandle();
//			TJSystem.Public.PublicStatic.ShowMessage(TJSystem.Public.MessageType.Information,"该功能尚未实现，请等待最新版本！");
			int ret = 0;
			if (this.comboBox2.SelectedValue.ToString().Equals(""))
			{
				ShowErrInfo(10,"");
				return;
			}
			if (this.textBox1.Text.Trim().Equals(""))
			{
				ShowErrInfo(11,"");
				return;
			}
			if(this.checkBox1.Checked)//采购询价单
			{
				csth.TableName = "purchase_se_master";
				csth.PrimaryKeyField = "se_code";
				csth.PrimaryKeyValue = this.comboBox2.SelectedValue.ToString();;
				csth.PrimaryKeyNewValue = this.textBox1.Text.Trim();
				ret = csth.SubTableInsert();
				ShowErrInfo(ret,"采购询价明细单");
				csth.TableName = "purchase_se_detail";
				csth.PrimaryKeyField = "se_code";
				csth.PrimaryKeyValue = this.comboBox2.SelectedValue.ToString();;
				csth.PrimaryKeyNewValue = this.textBox1.Text.Trim();
				ret = csth.SubTableInsert();
				ShowErrInfo(ret,"采购询价单");
			}
			if(this.checkBox2.Checked)//供应商报价单
			{
				csth.TableName = "purchase_sq_master";
				csth.PrimaryKeyField = "sq_code";
				csth.PrimaryKeyValue = this.comboBox2.SelectedValue.ToString();;
				csth.PrimaryKeyNewValue = this.textBox1.Text.Trim();
				ret = csth.SubTableInsert();
				ShowErrInfo(ret,"供应商报价单");
				csth.TableName = "purchase_sq_detail";
				csth.PrimaryKeyField = "sq_code";
				csth.PrimaryKeyValue = this.comboBox2.SelectedValue.ToString();;
				csth.PrimaryKeyNewValue = this.textBox1.Text.Trim();
				ret = csth.SubTableInsert();
				ShowErrInfo(ret,"供应商报价明细单");
			}
			if(this.checkBox3.Checked)//采购订单
			{
				csth.TableName = "purchase_po_master";
				csth.PrimaryKeyField = "po_code";
				csth.PrimaryKeyValue = this.comboBox2.SelectedValue.ToString();;
				csth.PrimaryKeyNewValue = this.textBox1.Text.Trim();
				ret = csth.SubTableInsert();
				ShowErrInfo(ret,"采购订单");
				csth.TableName = "purchase_po_detail";
				csth.PrimaryKeyField = "po_code";
				csth.PrimaryKeyValue = this.comboBox2.SelectedValue.ToString();;
				csth.PrimaryKeyNewValue = this.textBox1.Text.Trim();
				ret = csth.SubTableInsert();
				ShowErrInfo(ret,"采购订单明细");
			}
			if(this.checkBox5.Checked)//客户询价单
			{
				csth.TableName = "sale_ce_master";
				csth.PrimaryKeyField = "ce_code";
				csth.PrimaryKeyValue = this.comboBox2.SelectedValue.ToString();;
				csth.PrimaryKeyNewValue = this.textBox1.Text.Trim();
				ret = csth.SubTableInsert();
				ShowErrInfo(ret,"客户询价单");
				csth.TableName = "sale_ce_deatil";
				csth.PrimaryKeyField = "ce_code";
				csth.PrimaryKeyValue = this.comboBox2.SelectedValue.ToString();;
				csth.PrimaryKeyNewValue = this.textBox1.Text.Trim();
				ret = csth.SubTableInsert();
				ShowErrInfo(ret,"客户询价明细单");
			}
			if(this.checkBox6.Checked)//报价单
			{
				csth.TableName = "sale_cq_master";
				csth.PrimaryKeyField = "cq_code";
				csth.PrimaryKeyValue = this.comboBox2.SelectedValue.ToString();;
				csth.PrimaryKeyNewValue = this.textBox1.Text.Trim();
				ret = csth.SubTableInsert();
				ShowErrInfo(ret,"销售报价单");
				csth.TableName = "sale_cq_deatil";
				csth.PrimaryKeyField = "cq_code";
				csth.PrimaryKeyValue = this.comboBox2.SelectedValue.ToString();;
				csth.PrimaryKeyNewValue = this.textBox1.Text.Trim();
				ret = csth.SubTableInsert();
				ShowErrInfo(ret,"销售报价明细单");
			}
			if(this.checkBox7.Checked)//销售订单
			{
				csth.TableName = "sale_so_master";
				csth.PrimaryKeyField = "so_code";
				csth.PrimaryKeyValue = this.comboBox2.SelectedValue.ToString();
				csth.PrimaryKeyNewValue = this.textBox1.Text.Trim();
				ret = csth.SubTableInsert();
				ShowErrInfo(ret,"销售订单");
				csth.TableName = "sale_so_detail";
				csth.PrimaryKeyField = "so_code";
				csth.PrimaryKeyValue = this.comboBox2.SelectedValue.ToString();;
				csth.PrimaryKeyNewValue = this.textBox1.Text.Trim();
				ret = csth.SubTableInsert();
				ShowErrInfo(ret,"销售明细单");
			}
			if (this.checkBox9.Checked)//单证
			{
				csth.TableName = "sale_doc_master";
				csth.PrimaryKeyField = "so_code";
				csth.PrimaryKeyValue = this.comboBox2.SelectedValue.ToString();
				csth.PrimaryKeyNewValue = this.textBox1.Text;
				csth.PrimaryKeyPField = "invoice_no";
				csth.PrimaryKeyPValue = this.comboBox2.SelectedValue.ToString();
				csth.PrimaryKeyPNewValue = this.textBox1.Text;
				ret = csth.ConectTableInsert();
				ShowErrInfo(ret,"单证");
			}
			if (this.checkBox10.Checked)//货物托运单
			{
				csth.TableName = "SALE_WAYBILL_MASTER";
				csth.PrimaryKeyField = "INVOICE_NO";
				csth.PrimaryKeyValue = this.comboBox2.SelectedValue.ToString();
				csth.PrimaryKeyNewValue = this.textBox1.Text;
				csth.PrimaryKeyPField = "AWB_CODE";
				csth.PrimaryKeyPValue = this.comboBox2.SelectedValue.ToString();
				csth.PrimaryKeyPNewValue = this.textBox1.Text;
				ret = csth.ConectTableInsert();
				ShowErrInfo(ret,"货物托运单");
			}

			this.Close();
		}

		private void ShowErrInfo(int err,string doc)
		{
			string msg = null;
			switch(err)
			{
				case 0:
					msg = doc + "复制成功，请确认";
					break;
				case 100:
					msg = "原单据无对应的" + doc +"资料";
					break;
				case 200:
					msg = "新单据中已经存在该" + doc + "号，无法添加相同的单号，请核实";
					break;
				case 10:
					msg = "未来选中需要复制的单号";
					break;
				case 11:
					msg = "未指定需要复制的目的单号，请确认新单号输入框中有单号内容";
					break;
				default:
					msg = "新单据添加失败，请转到对应的功能界面核实";
					break;
			}

			if(err == 0)
			{
				TJSystem.Public.PublicStatic.ShowMessage(TJSystem.Public.MessageType.Information,msg);
				return;
			}
			TJSystem.Public.PublicStatic.ShowMessage(TJSystem.Public.MessageType.Exclamation,msg);
		}

		private void InitialTypeComboBox()
		{
			System.Data.DataRow dr = null;
			System.Data.DataTable dt = null;
			System.Data.DataTable dtcpy = null;
			
			dt = new System.Data.DataTable("DISPLAY");
			dt.Columns.Add("VALUE");
			dt.Columns.Add("DISPLAY");
			dr = dt.NewRow() ;
			dr[0] = "1" ;
			dr[1] = "采购询价单" ;
			dt.Rows.InsertAt(dr,0) ;
			dr = dt.NewRow() ;
			dr[0] = "2" ;
			dr[1] = "供应商报价单" ;
			dt.Rows.InsertAt(dr,0) ;
			dr = dt.NewRow() ;
			dr[0] = "3" ;
			dr[1] = "采购订单" ;
			dt.Rows.InsertAt(dr,0) ;
			dr = dt.NewRow() ;
			dr[0] = "4" ;
			dr[1] = "客户询价单" ;
			dt.Rows.InsertAt(dr,0) ;
			dr = dt.NewRow() ;
			dr[0] = "5" ;
			dr[1] = "报价单" ;
			dt.Rows.InsertAt(dr,0) ;
			dr = dt.NewRow() ;
			dr[0] = "6" ;
			dr[1] = "销售订单" ;
			dt.Rows.InsertAt(dr,0) ;
			dr = dt.NewRow() ;
			dr[0] = "0" ;
			dr[1] = "" ;
			dt.Rows.InsertAt(dr,0) ;
			dtcpy = dt.Copy();
			this.comboBox1.DataSource = dtcpy.DefaultView;
			this.comboBox1.ValueMember = "VALUE";
			this.comboBox1.DisplayMember = "DISPLAY";
		}

		private void comboBox1_SelectionChangeCommitted(object sender, System.EventArgs e)
		{
			string table = null;
			string Key = null;
			switch(this.comboBox1.SelectedValue.ToString())
			{
				case "1":
					table = "purchase_se_master";
					Key = "se_code";
					break;
				case "2":
					table = "purchase_sq_master";
					Key = "sq_code";
					break;
				case "3":
					table = "purchase_po_master";
					Key = "po_code";
					break;
				case "4":
					table = "sale_ce_master";
					Key = "ce_code";
					break;
				case "5":
					table = "sale_cq_master";
					Key = "cq_code";
					break;
				case "6":
					table = "sale_so_master";
					Key = "so_code";
					break;
				default:
					break;
			}

			InitialNoComboBox(table,Key);
		}

		private void InitialNoComboBox(string table,string Key)
		{
			System.Data.DataRow dr = null;
			System.Data.DataTable dt = null;
			System.Data.DataTable dtcpy = null;
			string sql = null;
			if (table == null || Key == null)
			{
				return;
			}
			sql += "select ";
			sql += Key;
			sql += " as ValueMember,";
			sql += Key;
			sql += " as DisplayMember from ";
			sql += table;
			sql += " order by ";
			sql += Key;
			dt = TJSystem.Public.PublicStatic.db.GetDataTable(sql);
			dr = dt.NewRow() ;
			dr[0] = "" ;
			dr[1] = "" ;
			dt.Rows.InsertAt(dr,0) ;
			dtcpy = dt.Copy();
			this.comboBox2.DataSource = dtcpy.DefaultView;
			this.comboBox2.ValueMember = "ValueMember";
			this.comboBox2.DisplayMember = "DisplayMember";
		}

	}
}

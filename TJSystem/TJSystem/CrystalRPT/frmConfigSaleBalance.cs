using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace TJSystem.CrystalRPT
{
	/// <summary>
	/// frmConfigSaleBalance 的摘要说明。
	/// </summary>
	public class frmConfigSaleBalance : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.TextBox textBox4;
		private System.Windows.Forms.TextBox textBox5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox textBox6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox textBox7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.TextBox textBox8;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.TextBox textBox9;
		private System.Windows.Forms.TextBox textBox10;
		private System.Windows.Forms.Button button1;
		/// <summary>
		/// 必需的设计器变量。
		/// </summary>
		private System.ComponentModel.Container components = null;
		private System.Windows.Forms.TextBox textBox11;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.TextBox textBox12;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.TextBox textBox13;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.ComboBox comboBox2;
		private System.Windows.Forms.ComboBox comboBox3;
		private System.Windows.Forms.ComboBox comboBox4;
		private System.Windows.Forms.ComboBox comboBox5;
		private System.Windows.Forms.ComboBox comboBox6;
		private System.Windows.Forms.ComboBox comboBox7;
		private System.Windows.Forms.ComboBox comboBox8;
		private System.Windows.Forms.ComboBox comboBox9;
		private System.Windows.Forms.ComboBox comboBox10;
		private System.Windows.Forms.ComboBox comboBox11;

		string _pacode = null;
		private System.Windows.Forms.TextBox textBox14;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.Label label16;
		private System.Windows.Forms.Label label17;
		private System.Windows.Forms.TextBox textBox15;

		TJSystem.CrystalRPT.CommonConfig cfg = null;

		public frmConfigSaleBalance(string pacode)
		{
			//
			// Windows 窗体设计器支持所必需的
			//
			InitializeComponent();

			_pacode = pacode;
			InitialFormData();

			//
			// TODO: 在 InitializeComponent 调用后添加任何构造函数代码
			//
		}

		public frmConfigSaleBalance(TJSystem.CrystalRPT.CommonConfig cfg)
		{
			//
			// Windows 窗体设计器支持所必需的
			//
			InitializeComponent();

			this.cfg = cfg;
			_pacode = cfg.sbSaleNo;
			InitialFormData();
			//
			// TODO: 在 InitializeComponent 调用后添加任何构造函数代码
			//
		}

		private void InitialFormData()
		{
			string sql = null;
			System.Data.DataTable dt = null;
			System.Data.DataTable dtcpy = null;
			System.Data.DataTable[] dtV = new System.Data.DataTable[11];
			System.Data.DataRow dr = null;
			sql = "select ltrim(str(amount,20,2)) as pa,pa_code+' '+ltrim(str(amount,20,2))+' '+remark as pa_desc from finance_payment_detail ";
			sql += " where ref_code in (" + this._pacode + ")";
			sql += " order by amount";
			dt = TJSystem.Public.PublicStatic.db.GetDataTable(sql);
			dr = dt.NewRow() ;
			dr[0] = "0" ;
			dr[1] = "" ;
			dt.Rows.InsertAt(dr,0) ;
			dtcpy = dt.Copy();

			for (int i = 0; i < 11; i++)
			{
				dtV[i] = dtcpy.Copy();
			}
			this.comboBox1.DataSource = dtV[0].DefaultView;
			this.comboBox1.ValueMember = "pa";
			this.comboBox1.DisplayMember = "pa_desc";	

			this.comboBox2.DataSource = dtV[1].DefaultView;
			this.comboBox2.ValueMember = "pa";
			this.comboBox2.DisplayMember = "pa_desc";	

			this.comboBox3.DataSource = dtV[2].DefaultView;
			this.comboBox3.ValueMember = "pa";
			this.comboBox3.DisplayMember = "pa_desc";	

			sql = "select";
			sql += " ltrim(str(sum(a.amount*a.exchange),20,2)) as pa,' RMB'+' '+a.term as pa_desc ";
			sql += " from finance_payawb a";
			sql += " where term in (" + this._pacode + ")";
			sql += " group by ' RMB'+' '+a.term";
//			sql = "select ltrim(str(amount,20,2)) as pa,pa_code+' '+ltrim(str(amount,20,2))+' '+pa_date as pa_desc from finance_payawb ";			
			sql += " order by pa desc";
			dt = TJSystem.Public.PublicStatic.db.GetDataTable(sql);
			dtcpy = dt.Clone();
			for (int i = 0; i < dt.Rows.Count; i++)
			{
				dr = dtcpy.NewRow() ;
				dr[0] = dt.Rows[i]["pa"].ToString() ;
				dr[1] = dt.Rows[i]["pa"].ToString() + " " + dt.Rows[i]["pa_desc"].ToString() ;
				dtcpy.Rows.InsertAt(dr,0) ;
			}
			dr = dtcpy.NewRow() ;
			dr[0] = "0" ;
			dr[1] = "" ;
			dtcpy.Rows.InsertAt(dr,0) ;
//			dtcpy = dt.Copy();
			this.comboBox4.DataSource = dtcpy.DefaultView;
			this.comboBox4.ValueMember = "pa";
			this.comboBox4.DisplayMember = "pa_desc";	

			dtV[6] = dtcpy.Copy();

			this.comboBox5.DataSource = dtV[4].DefaultView;
			this.comboBox5.ValueMember = "pa";
			this.comboBox5.DisplayMember = "pa_desc";	

			this.comboBox6.DataSource = dtV[5].DefaultView;
			this.comboBox6.ValueMember = "pa";
			this.comboBox6.DisplayMember = "pa_desc";	

			this.comboBox7.DataSource = dtV[6].DefaultView;
			this.comboBox7.ValueMember = "pa";
			this.comboBox7.DisplayMember = "pa_desc";	

			this.comboBox8.DataSource = dtV[7].DefaultView;
			this.comboBox8.ValueMember = "pa";
			this.comboBox8.DisplayMember = "pa_desc";	

			this.comboBox9.DataSource = dtV[8].DefaultView;
			this.comboBox9.ValueMember = "pa";
			this.comboBox9.DisplayMember = "pa_desc";	

			this.comboBox10.DataSource = dtV[9].DefaultView;
			this.comboBox10.ValueMember = "pa";
			this.comboBox10.DisplayMember = "pa_desc";	

			this.comboBox11.DataSource = dtV[10].DefaultView;
			this.comboBox11.ValueMember = "pa";
			this.comboBox11.DisplayMember = "pa_desc";	

			this.textBox7.Text = this.cfg.gnyzf.ToString("f2");
			this.textBox12.Text = this.cfg.myfl.ToString("f2");
		
		}

		/// <summary>
		/// 清理所有正在使用的资源。
		/// </summary>
		protected override void Dispose( bool disposing )
		{
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(frmConfigSaleBalance));
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.textBox4 = new System.Windows.Forms.TextBox();
			this.textBox5 = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.textBox6 = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.textBox7 = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.textBox8 = new System.Windows.Forms.TextBox();
			this.label9 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.textBox9 = new System.Windows.Forms.TextBox();
			this.textBox10 = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.textBox11 = new System.Windows.Forms.TextBox();
			this.label12 = new System.Windows.Forms.Label();
			this.textBox12 = new System.Windows.Forms.TextBox();
			this.label13 = new System.Windows.Forms.Label();
			this.textBox13 = new System.Windows.Forms.TextBox();
			this.label14 = new System.Windows.Forms.Label();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.comboBox2 = new System.Windows.Forms.ComboBox();
			this.comboBox3 = new System.Windows.Forms.ComboBox();
			this.comboBox4 = new System.Windows.Forms.ComboBox();
			this.comboBox5 = new System.Windows.Forms.ComboBox();
			this.comboBox6 = new System.Windows.Forms.ComboBox();
			this.comboBox7 = new System.Windows.Forms.ComboBox();
			this.comboBox8 = new System.Windows.Forms.ComboBox();
			this.comboBox9 = new System.Windows.Forms.ComboBox();
			this.comboBox10 = new System.Windows.Forms.ComboBox();
			this.comboBox11 = new System.Windows.Forms.ComboBox();
			this.textBox14 = new System.Windows.Forms.TextBox();
			this.label15 = new System.Windows.Forms.Label();
			this.label16 = new System.Windows.Forms.Label();
			this.label17 = new System.Windows.Forms.Label();
			this.textBox15 = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.Honeydew;
			this.label1.Dock = System.Windows.Forms.DockStyle.Top;
			this.label1.Font = new System.Drawing.Font("宋体", 20F);
			this.label1.Location = new System.Drawing.Point(0, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(504, 48);
			this.label1.TabIndex = 0;
			this.label1.Text = "费用调整";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label2
			// 
			this.label2.BackColor = System.Drawing.Color.Transparent;
			this.label2.Location = new System.Drawing.Point(24, 64);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(64, 23);
			this.label2.TabIndex = 1;
			this.label2.Text = "外商佣金";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label3
			// 
			this.label3.BackColor = System.Drawing.Color.Transparent;
			this.label3.Location = new System.Drawing.Point(32, 112);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(56, 23);
			this.label3.TabIndex = 1;
			this.label3.Text = "保险金";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label4
			// 
			this.label4.BackColor = System.Drawing.Color.Transparent;
			this.label4.Location = new System.Drawing.Point(256, 88);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(72, 23);
			this.label4.TabIndex = 1;
			this.label4.Text = "银行手续费";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label5
			// 
			this.label5.BackColor = System.Drawing.Color.Transparent;
			this.label5.Location = new System.Drawing.Point(520, 320);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(72, 23);
			this.label5.TabIndex = 1;
			this.label5.Text = "国外运杂费";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(96, 88);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(120, 21);
			this.textBox1.TabIndex = 2;
			this.textBox1.Text = "";
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(96, 136);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(120, 21);
			this.textBox2.TabIndex = 2;
			this.textBox2.Text = "";
			// 
			// textBox3
			// 
			this.textBox3.Location = new System.Drawing.Point(336, 112);
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new System.Drawing.Size(120, 21);
			this.textBox3.TabIndex = 2;
			this.textBox3.Text = "";
			// 
			// textBox4
			// 
			this.textBox4.Location = new System.Drawing.Point(600, 344);
			this.textBox4.Name = "textBox4";
			this.textBox4.Size = new System.Drawing.Size(120, 21);
			this.textBox4.TabIndex = 2;
			this.textBox4.Text = "0";
			// 
			// textBox5
			// 
			this.textBox5.Location = new System.Drawing.Point(336, 160);
			this.textBox5.Name = "textBox5";
			this.textBox5.Size = new System.Drawing.Size(120, 21);
			this.textBox5.TabIndex = 2;
			this.textBox5.Text = "";
			// 
			// label6
			// 
			this.label6.BackColor = System.Drawing.Color.Transparent;
			this.label6.Location = new System.Drawing.Point(256, 136);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(72, 23);
			this.label6.TabIndex = 1;
			this.label6.Text = "其他国外费";
			this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// textBox6
			// 
			this.textBox6.Location = new System.Drawing.Point(600, 88);
			this.textBox6.Name = "textBox6";
			this.textBox6.Size = new System.Drawing.Size(120, 21);
			this.textBox6.TabIndex = 2;
			this.textBox6.Text = "0";
			this.textBox6.Visible = false;
			// 
			// label7
			// 
			this.label7.BackColor = System.Drawing.Color.Transparent;
			this.label7.Location = new System.Drawing.Point(536, 160);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(56, 23);
			this.label7.TabIndex = 1;
			this.label7.Text = "其他费用";
			this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.label7.Visible = false;
			// 
			// textBox7
			// 
			this.textBox7.Location = new System.Drawing.Point(336, 64);
			this.textBox7.Name = "textBox7";
			this.textBox7.Size = new System.Drawing.Size(120, 21);
			this.textBox7.TabIndex = 2;
			this.textBox7.Text = "";
			// 
			// label8
			// 
			this.label8.BackColor = System.Drawing.Color.Transparent;
			this.label8.Location = new System.Drawing.Point(528, 64);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(64, 23);
			this.label8.TabIndex = 1;
			this.label8.Text = "经营费用";
			this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.label8.Visible = false;
			// 
			// textBox8
			// 
			this.textBox8.Location = new System.Drawing.Point(600, 184);
			this.textBox8.Name = "textBox8";
			this.textBox8.Size = new System.Drawing.Size(120, 21);
			this.textBox8.TabIndex = 2;
			this.textBox8.Text = "0";
			this.textBox8.Visible = false;
			// 
			// label9
			// 
			this.label9.BackColor = System.Drawing.Color.Transparent;
			this.label9.Location = new System.Drawing.Point(520, 256);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(72, 23);
			this.label9.TabIndex = 1;
			this.label9.Text = "公司管理费";
			this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.label9.Visible = false;
			// 
			// label10
			// 
			this.label10.BackColor = System.Drawing.Color.Transparent;
			this.label10.Location = new System.Drawing.Point(512, 208);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(80, 23);
			this.label10.TabIndex = 1;
			this.label10.Text = "退税利息/月";
			this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.label10.Visible = false;
			// 
			// label11
			// 
			this.label11.BackColor = System.Drawing.Color.Transparent;
			this.label11.Location = new System.Drawing.Point(256, 64);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(72, 23);
			this.label11.TabIndex = 1;
			this.label11.Text = "国内运杂费";
			this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// textBox9
			// 
			this.textBox9.Location = new System.Drawing.Point(600, 232);
			this.textBox9.Name = "textBox9";
			this.textBox9.Size = new System.Drawing.Size(120, 21);
			this.textBox9.TabIndex = 2;
			this.textBox9.Text = "0";
			this.textBox9.Visible = false;
			// 
			// textBox10
			// 
			this.textBox10.Location = new System.Drawing.Point(600, 280);
			this.textBox10.Name = "textBox10";
			this.textBox10.Size = new System.Drawing.Size(120, 21);
			this.textBox10.TabIndex = 2;
			this.textBox10.Text = "0";
			this.textBox10.Visible = false;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(208, 248);
			this.button1.Name = "button1";
			this.button1.TabIndex = 3;
			this.button1.Text = "确定";
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// textBox11
			// 
			this.textBox11.Location = new System.Drawing.Point(600, 136);
			this.textBox11.Name = "textBox11";
			this.textBox11.Size = new System.Drawing.Size(120, 21);
			this.textBox11.TabIndex = 2;
			this.textBox11.Text = "0";
			// 
			// label12
			// 
			this.label12.BackColor = System.Drawing.Color.Transparent;
			this.label12.Location = new System.Drawing.Point(528, 112);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(64, 23);
			this.label12.TabIndex = 1;
			this.label12.Text = "换汇成本";
			this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// textBox12
			// 
			this.textBox12.Location = new System.Drawing.Point(96, 160);
			this.textBox12.Name = "textBox12";
			this.textBox12.Size = new System.Drawing.Size(120, 21);
			this.textBox12.TabIndex = 2;
			this.textBox12.Text = "";
			// 
			// label13
			// 
			this.label13.BackColor = System.Drawing.Color.Transparent;
			this.label13.Location = new System.Drawing.Point(24, 160);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(64, 23);
			this.label13.TabIndex = 1;
			this.label13.Text = "货币费率";
			this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// textBox13
			// 
			this.textBox13.Location = new System.Drawing.Point(96, 184);
			this.textBox13.Name = "textBox13";
			this.textBox13.Size = new System.Drawing.Size(120, 21);
			this.textBox13.TabIndex = 2;
			this.textBox13.Text = "是";
			// 
			// label14
			// 
			this.label14.BackColor = System.Drawing.Color.Transparent;
			this.label14.Location = new System.Drawing.Point(32, 184);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(56, 23);
			this.label14.TabIndex = 1;
			this.label14.Text = "信保";
			this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// comboBox1
			// 
			this.comboBox1.Location = new System.Drawing.Point(96, 64);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(152, 20);
			this.comboBox1.TabIndex = 4;
			this.comboBox1.Text = "comboBox1";
			this.comboBox1.SelectionChangeCommitted += new System.EventHandler(this.comboBox_SelectionChangeCommitted);
			// 
			// comboBox2
			// 
			this.comboBox2.Location = new System.Drawing.Point(600, 64);
			this.comboBox2.Name = "comboBox2";
			this.comboBox2.Size = new System.Drawing.Size(152, 20);
			this.comboBox2.TabIndex = 4;
			this.comboBox2.Text = "comboBox1";
			this.comboBox2.Visible = false;
			this.comboBox2.SelectionChangeCommitted += new System.EventHandler(this.comboBox_SelectionChangeCommitted);
			// 
			// comboBox3
			// 
			this.comboBox3.Location = new System.Drawing.Point(96, 112);
			this.comboBox3.Name = "comboBox3";
			this.comboBox3.Size = new System.Drawing.Size(152, 20);
			this.comboBox3.TabIndex = 4;
			this.comboBox3.Text = "comboBox1";
			this.comboBox3.SelectionChangeCommitted += new System.EventHandler(this.comboBox_SelectionChangeCommitted);
			// 
			// comboBox4
			// 
			this.comboBox4.Location = new System.Drawing.Point(592, 376);
			this.comboBox4.Name = "comboBox4";
			this.comboBox4.Size = new System.Drawing.Size(152, 20);
			this.comboBox4.TabIndex = 4;
			this.comboBox4.Text = "comboBox1";
			this.comboBox4.SelectionChangeCommitted += new System.EventHandler(this.comboBox_SelectionChangeCommitted);
			// 
			// comboBox5
			// 
			this.comboBox5.Location = new System.Drawing.Point(336, 88);
			this.comboBox5.Name = "comboBox5";
			this.comboBox5.Size = new System.Drawing.Size(152, 20);
			this.comboBox5.TabIndex = 4;
			this.comboBox5.Text = "comboBox1";
			this.comboBox5.SelectionChangeCommitted += new System.EventHandler(this.comboBox_SelectionChangeCommitted);
			// 
			// comboBox6
			// 
			this.comboBox6.Location = new System.Drawing.Point(600, 160);
			this.comboBox6.Name = "comboBox6";
			this.comboBox6.Size = new System.Drawing.Size(152, 20);
			this.comboBox6.TabIndex = 4;
			this.comboBox6.Text = "comboBox1";
			this.comboBox6.Visible = false;
			this.comboBox6.SelectionChangeCommitted += new System.EventHandler(this.comboBox_SelectionChangeCommitted);
			// 
			// comboBox7
			// 
			this.comboBox7.Location = new System.Drawing.Point(600, 320);
			this.comboBox7.Name = "comboBox7";
			this.comboBox7.Size = new System.Drawing.Size(152, 20);
			this.comboBox7.TabIndex = 4;
			this.comboBox7.Text = "comboBox1";
			this.comboBox7.SelectionChangeCommitted += new System.EventHandler(this.comboBox_SelectionChangeCommitted);
			// 
			// comboBox8
			// 
			this.comboBox8.Location = new System.Drawing.Point(600, 208);
			this.comboBox8.Name = "comboBox8";
			this.comboBox8.Size = new System.Drawing.Size(152, 20);
			this.comboBox8.TabIndex = 4;
			this.comboBox8.Text = "comboBox1";
			this.comboBox8.Visible = false;
			this.comboBox8.SelectionChangeCommitted += new System.EventHandler(this.comboBox_SelectionChangeCommitted);
			// 
			// comboBox9
			// 
			this.comboBox9.Location = new System.Drawing.Point(336, 136);
			this.comboBox9.Name = "comboBox9";
			this.comboBox9.Size = new System.Drawing.Size(152, 20);
			this.comboBox9.TabIndex = 4;
			this.comboBox9.Text = "comboBox1";
			this.comboBox9.SelectionChangeCommitted += new System.EventHandler(this.comboBox_SelectionChangeCommitted);
			// 
			// comboBox10
			// 
			this.comboBox10.Location = new System.Drawing.Point(600, 256);
			this.comboBox10.Name = "comboBox10";
			this.comboBox10.Size = new System.Drawing.Size(152, 20);
			this.comboBox10.TabIndex = 4;
			this.comboBox10.Text = "comboBox1";
			this.comboBox10.Visible = false;
			this.comboBox10.SelectionChangeCommitted += new System.EventHandler(this.comboBox_SelectionChangeCommitted);
			// 
			// comboBox11
			// 
			this.comboBox11.Location = new System.Drawing.Point(600, 112);
			this.comboBox11.Name = "comboBox11";
			this.comboBox11.Size = new System.Drawing.Size(152, 20);
			this.comboBox11.TabIndex = 4;
			this.comboBox11.Text = "comboBox1";
			this.comboBox11.SelectionChangeCommitted += new System.EventHandler(this.comboBox_SelectionChangeCommitted);
			// 
			// textBox14
			// 
			this.textBox14.Location = new System.Drawing.Point(336, 184);
			this.textBox14.Name = "textBox14";
			this.textBox14.Size = new System.Drawing.Size(120, 21);
			this.textBox14.TabIndex = 6;
			this.textBox14.Text = "0";
			// 
			// label15
			// 
			this.label15.BackColor = System.Drawing.Color.Transparent;
			this.label15.Location = new System.Drawing.Point(248, 184);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(80, 23);
			this.label15.TabIndex = 5;
			this.label15.Text = "退税率/款";
			this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label16
			// 
			this.label16.BackColor = System.Drawing.Color.Transparent;
			this.label16.Location = new System.Drawing.Point(464, 64);
			this.label16.Name = "label16";
			this.label16.Size = new System.Drawing.Size(32, 23);
			this.label16.TabIndex = 1;
			this.label16.Text = "RMB";
			this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label17
			// 
			this.label17.BackColor = System.Drawing.Color.Transparent;
			this.label17.Location = new System.Drawing.Point(24, 208);
			this.label17.Name = "label17";
			this.label17.Size = new System.Drawing.Size(64, 23);
			this.label17.TabIndex = 1;
			this.label17.Text = "单证费用";
			this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// textBox15
			// 
			this.textBox15.Location = new System.Drawing.Point(96, 208);
			this.textBox15.Name = "textBox15";
			this.textBox15.Size = new System.Drawing.Size(120, 21);
			this.textBox15.TabIndex = 2;
			this.textBox15.Text = "";
			// 
			// frmConfigSaleBalance
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.ClientSize = new System.Drawing.Size(504, 286);
			this.Controls.Add(this.textBox14);
			this.Controls.Add(this.label15);
			this.Controls.Add(this.comboBox1);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.textBox3);
			this.Controls.Add(this.textBox4);
			this.Controls.Add(this.textBox5);
			this.Controls.Add(this.textBox6);
			this.Controls.Add(this.textBox7);
			this.Controls.Add(this.textBox8);
			this.Controls.Add(this.textBox9);
			this.Controls.Add(this.textBox10);
			this.Controls.Add(this.textBox11);
			this.Controls.Add(this.textBox12);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.label11);
			this.Controls.Add(this.label12);
			this.Controls.Add(this.label13);
			this.Controls.Add(this.textBox13);
			this.Controls.Add(this.label14);
			this.Controls.Add(this.comboBox2);
			this.Controls.Add(this.comboBox3);
			this.Controls.Add(this.comboBox4);
			this.Controls.Add(this.comboBox5);
			this.Controls.Add(this.comboBox6);
			this.Controls.Add(this.comboBox7);
			this.Controls.Add(this.comboBox8);
			this.Controls.Add(this.comboBox9);
			this.Controls.Add(this.comboBox10);
			this.Controls.Add(this.comboBox11);
			this.Controls.Add(this.label16);
			this.Controls.Add(this.label17);
			this.Controls.Add(this.textBox15);
			this.Name = "frmConfigSaleBalance";
			this.Text = "费用调整";
			this.ResumeLayout(false);

		}
		#endregion

		private void button1_Click(object sender, System.EventArgs e)
		{
			bool flag = true;
			if(!TJSystem.Public.PublicStatic.IsNumDouble(this.textBox1.Text.Trim()))
			{
				flag = false;
				this.textBox1.Text = "0";
			}
			if(!TJSystem.Public.PublicStatic.IsNumDouble(this.textBox2.Text.Trim()))
			{
				flag = false;
				this.textBox2.Text = "0";
			}
			if(!TJSystem.Public.PublicStatic.IsNumDouble(this.textBox3.Text.Trim()))
			{
				flag = false;
				this.textBox3.Text = "0";
			}
			if(!TJSystem.Public.PublicStatic.IsNumDouble(this.textBox4.Text.Trim()))
			{
				flag = false;
				this.textBox4.Text = "0";
			}
			if(!TJSystem.Public.PublicStatic.IsNumDouble(this.textBox5.Text.Trim()))
			{
				flag = false;
				this.textBox5.Text = "0";
			}
			if(!TJSystem.Public.PublicStatic.IsNumDouble(this.textBox6.Text.Trim()))
			{
				flag = false;
				this.textBox6.Text = "0";
			}
			if(!TJSystem.Public.PublicStatic.IsNumDouble(this.textBox7.Text.Trim()))
			{
				flag = false;
				this.textBox7.Text = "0";
			}
			if(!TJSystem.Public.PublicStatic.IsNumDouble(this.textBox8.Text.Trim()))
			{
				flag = false;
				this.textBox8.Text = "0";
			}
			if(!TJSystem.Public.PublicStatic.IsNumDouble(this.textBox9.Text.Trim()))
			{
				flag = false;
				this.textBox9.Text = "0";
			}
			if(!TJSystem.Public.PublicStatic.IsNumDouble(this.textBox10.Text.Trim()))
			{
				flag = false;
				this.textBox10.Text = "0";
			}
			if(!TJSystem.Public.PublicStatic.IsNumDouble(this.textBox11.Text.Trim()))
			{
				flag = false;
				this.textBox11.Text = "0";
			}
			if(!TJSystem.Public.PublicStatic.IsNumDouble(this.textBox12.Text.Trim()))
			{
				flag = false;
				this.textBox12.Text = "1";
			}

			if(!TJSystem.Public.PublicStatic.IsNumDouble(this.textBox14.Text.Trim()))
			{
				flag = false;
				this.textBox14.Text = "0";
			}
			if(!TJSystem.Public.PublicStatic.IsNumDouble(this.textBox15.Text.Trim()))
			{
				flag = false;
				this.textBox15.Text = "0";
			}

			if (!flag)
			{
				MessageBox.Show("请保证各栏位填写的都是数字！！！","提醒",MessageBoxButtons.OK,MessageBoxIcon.Error);
				return;
			}
			cfg.wsyj = Convert.ToDouble(this.textBox1.Text.Trim());
			cfg.bxj = Convert.ToDouble(this.textBox2.Text.Trim());
			cfg.yhsxf = Convert.ToDouble(this.textBox3.Text.Trim());
			cfg.gwyzf = Convert.ToDouble(this.textBox4.Text.Trim());
			cfg.qtgwf = Convert.ToDouble(this.textBox5.Text.Trim());
			cfg.jyfy = Convert.ToDouble(this.textBox6.Text.Trim());
			cfg.gnyzf = Convert.ToDouble(this.textBox7.Text.Trim());
			cfg.qtfy = Convert.ToDouble(this.textBox8.Text.Trim());
			cfg.tslx = Convert.ToDouble(this.textBox9.Text.Trim());
			cfg.gsglf = Convert.ToDouble(this.textBox10.Text.Trim());
			cfg.hhcb = Convert.ToDouble(this.textBox11.Text.Trim());
			cfg.myfl = Convert.ToDouble(this.textBox12.Text.Trim());
			cfg.tslk = Convert.ToDouble(this.textBox14.Text.Trim());
			cfg.xb = this.textBox13.Text.Trim();
			cfg.dzfy = Convert.ToDouble(this.textBox15.Text.Trim());

			this.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.Close();
		}

		private void comboBox_SelectionChangeCommitted(object sender, System.EventArgs e)
		{
			string comboName = ((System.Windows.Forms.ComboBox)sender).Name;
			switch(comboName)
			{
				case "comboBox1":
					this.textBox1.Text = this.comboBox1.SelectedValue.ToString();
					break;
				case "comboBox2":
					this.textBox6.Text = this.comboBox2.SelectedValue.ToString();
					break;
				case "comboBox3":
					this.textBox2.Text = this.comboBox3.SelectedValue.ToString();
					break;
				case "comboBox4":
					this.textBox7.Text = this.comboBox4.SelectedValue.ToString();
					break;
				case "comboBox5":
					this.textBox3.Text = this.comboBox5.SelectedValue.ToString();
					break;
				case "comboBox6":
					this.textBox8.Text = this.comboBox6.SelectedValue.ToString();
					break;
				case "comboBox7":
					this.textBox4.Text = this.comboBox7.SelectedValue.ToString();
					break;
				case "comboBox8":
					this.textBox9.Text = this.comboBox8.SelectedValue.ToString();
					break;
				case "comboBox9":
					this.textBox5.Text = this.comboBox9.SelectedValue.ToString();
					break;
				case "comboBox10":
					this.textBox10.Text = this.comboBox10.SelectedValue.ToString();
					break;
				case "comboBox11":
					this.textBox11.Text = this.comboBox11.SelectedValue.ToString();
					break;
				default:
					break;
			}
		}
	}
}

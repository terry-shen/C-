using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace TJSystem.CrystalRPT
{
	/// <summary>
	/// frmConfigBaoGuanDan 的摘要说明。
	/// </summary>
	public class frmConfigBaoGuanDan : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.TextBox textBox4;
		private System.Windows.Forms.TextBox textBox5;
		private System.Windows.Forms.TextBox textBox6;
		private System.Windows.Forms.TextBox textBox7;
		private System.Windows.Forms.Button button1;
		/// <summary>
		/// 必需的设计器变量。
		/// </summary>
		private System.ComponentModel.Container components = null;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.TextBox textBox8;

		TJSystem.CrystalRPT.CommonConfig cfg = null;

		public frmConfigBaoGuanDan(TJSystem.CrystalRPT.CommonConfig cfg)
		{
			//
			// Windows 窗体设计器支持所必需的
			//
			InitializeComponent();

			this.cfg = cfg;
			//
			// TODO: 在 InitializeComponent 调用后添加任何构造函数代码
			//
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(frmConfigBaoGuanDan));
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.textBox4 = new System.Windows.Forms.TextBox();
			this.textBox5 = new System.Windows.Forms.TextBox();
			this.textBox6 = new System.Windows.Forms.TextBox();
			this.textBox7 = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.label8 = new System.Windows.Forms.Label();
			this.textBox8 = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Location = new System.Drawing.Point(16, 32);
			this.label1.Name = "label1";
			this.label1.TabIndex = 0;
			this.label1.Text = "经营单位编号";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label2
			// 
			this.label2.BackColor = System.Drawing.Color.Transparent;
			this.label2.Location = new System.Drawing.Point(16, 56);
			this.label2.Name = "label2";
			this.label2.TabIndex = 0;
			this.label2.Text = "发货单位编号";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label3
			// 
			this.label3.BackColor = System.Drawing.Color.Transparent;
			this.label3.Location = new System.Drawing.Point(16, 80);
			this.label3.Name = "label3";
			this.label3.TabIndex = 0;
			this.label3.Text = "包装种类";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label4
			// 
			this.label4.BackColor = System.Drawing.Color.Transparent;
			this.label4.Location = new System.Drawing.Point(16, 104);
			this.label4.Name = "label4";
			this.label4.TabIndex = 0;
			this.label4.Text = "随附单据";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label5
			// 
			this.label5.BackColor = System.Drawing.Color.Transparent;
			this.label5.Location = new System.Drawing.Point(16, 128);
			this.label5.Name = "label5";
			this.label5.TabIndex = 0;
			this.label5.Text = "单位地址";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label6
			// 
			this.label6.BackColor = System.Drawing.Color.Transparent;
			this.label6.Location = new System.Drawing.Point(16, 152);
			this.label6.Name = "label6";
			this.label6.TabIndex = 0;
			this.label6.Text = "申报日期";
			this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label7
			// 
			this.label7.BackColor = System.Drawing.Color.Transparent;
			this.label7.Location = new System.Drawing.Point(16, 176);
			this.label7.Name = "label7";
			this.label7.TabIndex = 0;
			this.label7.Text = "填制日期";
			this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(120, 32);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(192, 21);
			this.textBox1.TabIndex = 1;
			this.textBox1.Text = "3204832112882";
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(120, 56);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(192, 21);
			this.textBox2.TabIndex = 1;
			this.textBox2.Text = "320400788883127";
			// 
			// textBox3
			// 
			this.textBox3.Location = new System.Drawing.Point(120, 80);
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new System.Drawing.Size(192, 21);
			this.textBox3.TabIndex = 1;
			this.textBox3.Text = "CTNS";
			// 
			// textBox4
			// 
			this.textBox4.Location = new System.Drawing.Point(120, 104);
			this.textBox4.Name = "textBox4";
			this.textBox4.Size = new System.Drawing.Size(192, 21);
			this.textBox4.TabIndex = 1;
			this.textBox4.Text = "INC,P/L";
			// 
			// textBox5
			// 
			this.textBox5.Location = new System.Drawing.Point(120, 128);
			this.textBox5.Name = "textBox5";
			this.textBox5.Size = new System.Drawing.Size(192, 21);
			this.textBox5.TabIndex = 1;
			this.textBox5.Text = "常州市武进区雪堰镇雪城路";
			// 
			// textBox6
			// 
			this.textBox6.Location = new System.Drawing.Point(120, 152);
			this.textBox6.Name = "textBox6";
			this.textBox6.Size = new System.Drawing.Size(192, 21);
			this.textBox6.TabIndex = 1;
			this.textBox6.Text = "";
			// 
			// textBox7
			// 
			this.textBox7.Location = new System.Drawing.Point(120, 176);
			this.textBox7.Name = "textBox7";
			this.textBox7.Size = new System.Drawing.Size(192, 21);
			this.textBox7.TabIndex = 1;
			this.textBox7.Text = "";
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(128, 240);
			this.button1.Name = "button1";
			this.button1.TabIndex = 2;
			this.button1.Text = "确定";
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// label8
			// 
			this.label8.BackColor = System.Drawing.Color.Transparent;
			this.label8.Location = new System.Drawing.Point(16, 200);
			this.label8.Name = "label8";
			this.label8.TabIndex = 0;
			this.label8.Text = "境内货源地";
			this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// textBox8
			// 
			this.textBox8.Location = new System.Drawing.Point(120, 200);
			this.textBox8.Name = "textBox8";
			this.textBox8.Size = new System.Drawing.Size(192, 21);
			this.textBox8.TabIndex = 1;
			this.textBox8.Text = "";
			// 
			// frmConfigBaoGuanDan
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.ClientSize = new System.Drawing.Size(344, 278);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.textBox3);
			this.Controls.Add(this.textBox4);
			this.Controls.Add(this.textBox5);
			this.Controls.Add(this.textBox6);
			this.Controls.Add(this.textBox7);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.textBox8);
			this.Name = "frmConfigBaoGuanDan";
			this.Text = "数据添加";
			this.ResumeLayout(false);

		}
		#endregion

		private void button1_Click(object sender, System.EventArgs e)
		{
			cfg.bgdjydwbh = this.textBox1.Text.Trim();
			cfg.bgdfhdwbh = this.textBox2.Text.Trim();
			cfg.bgdbzzl = this.textBox3.Text.Trim();
			cfg.bgdsfdj = this.textBox4.Text.Trim();
			cfg.bgddwdz = this.textBox5.Text.Trim();
			cfg.bgdsbrq = this.textBox6.Text.Trim();
			cfg.bgdtzrq = this.textBox7.Text.Trim();
			cfg.bgdjnhyd = this.textBox8.Text.Trim();
			this.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.Close();
		}
	}
}

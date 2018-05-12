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
	public class frmConfigOfferSheet : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.TextBox textBox4;
		private System.Windows.Forms.Button button1;
		/// <summary>
		/// 必需的设计器变量。
		/// </summary>
		private System.ComponentModel.Container components = null;

		TJSystem.CrystalRPT.CommonConfig cfg = null;

		public frmConfigOfferSheet(TJSystem.CrystalRPT.CommonConfig cfg)
		{
			//
			// Windows 窗体设计器支持所必需的
			//
			InitializeComponent();
			this.textBox2.Text = "30% deposit\r\nthe balance against B/L faxing";

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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(frmConfigOfferSheet));
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.textBox4 = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Location = new System.Drawing.Point(24, 16);
			this.label1.Name = "label1";
			this.label1.TabIndex = 0;
			this.label1.Text = "APPROVAL";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label2
			// 
			this.label2.BackColor = System.Drawing.Color.Transparent;
			this.label2.Location = new System.Drawing.Point(24, 72);
			this.label2.Name = "label2";
			this.label2.TabIndex = 0;
			this.label2.Text = "TERM OF PAYMENT";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label3
			// 
			this.label3.BackColor = System.Drawing.Color.Transparent;
			this.label3.Location = new System.Drawing.Point(24, 144);
			this.label3.Name = "label3";
			this.label3.TabIndex = 0;
			this.label3.Text = "DELIVERY TIME";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label4
			// 
			this.label4.BackColor = System.Drawing.Color.Transparent;
			this.label4.Location = new System.Drawing.Point(0, 176);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(128, 23);
			this.label4.TabIndex = 0;
			this.label4.Text = "THE TERM OF VALIDITY";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(136, 16);
			this.textBox1.Multiline = true;
			this.textBox1.Name = "textBox1";
			this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.textBox1.Size = new System.Drawing.Size(192, 56);
			this.textBox1.TabIndex = 1;
			this.textBox1.Text = "CE";
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(136, 72);
			this.textBox2.Multiline = true;
			this.textBox2.Name = "textBox2";
			this.textBox2.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.textBox2.Size = new System.Drawing.Size(192, 72);
			this.textBox2.TabIndex = 1;
			this.textBox2.Text = "30% deposit";
			// 
			// textBox3
			// 
			this.textBox3.Location = new System.Drawing.Point(136, 144);
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new System.Drawing.Size(192, 21);
			this.textBox3.TabIndex = 1;
			this.textBox3.Text = "20days after order confirmed";
			// 
			// textBox4
			// 
			this.textBox4.Location = new System.Drawing.Point(136, 176);
			this.textBox4.Name = "textBox4";
			this.textBox4.Size = new System.Drawing.Size(192, 21);
			this.textBox4.TabIndex = 1;
			this.textBox4.Text = "15days";
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(128, 216);
			this.button1.Name = "button1";
			this.button1.TabIndex = 2;
			this.button1.Text = "确定";
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// frmConfigOfferSheet
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.ClientSize = new System.Drawing.Size(344, 262);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.textBox3);
			this.Controls.Add(this.textBox4);
			this.Name = "frmConfigOfferSheet";
			this.Text = "数据添加";
			this.Load += new System.EventHandler(this.frmConfigOfferSheet_Load);
			this.ResumeLayout(false);

		}
		#endregion

		private void button1_Click(object sender, System.EventArgs e)
		{
			cfg.osapproval = this.textBox1.Text.Trim();
			cfg.ospayment = this.textBox2.Text.Trim();
			cfg.osdeliver = this.textBox3.Text.Trim();
			cfg.osvalidity = this.textBox4.Text.Trim();
			
			this.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.Close();
		}

		private void frmConfigOfferSheet_Load(object sender, System.EventArgs e)
		{
		
		}
	}
}

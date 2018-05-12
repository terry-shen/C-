using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace TJSystem
{
	/// <summary>
	/// frmConfig 的摘要说明。
	/// </summary>
	public class frmConfig : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox textBox4;
		private TJSystem.Classes.XpStyleButton button2;
		/// <summary>
		/// 必需的设计器变量。
		/// </summary>
		private System.ComponentModel.Container components = null;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox textBox5;
		private bool m_enabled = false;

		public frmConfig()
		{
			//
			// Windows 窗体设计器支持所必需的
			//
			InitializeComponent();
			m_enabled = true;

			string tmp = null;
			TJSystem.Classes.common.CommonXML.ReadXMLConfigure("station",ref tmp);
			this.textBox1.Text = tmp;
			TJSystem.Classes.common.CommonXML.ReadXMLConfigure("catalog",ref tmp);
			this.textBox2.Text = tmp;
			TJSystem.Classes.common.CommonXML.ReadXMLConfigure("user",ref tmp);
			this.textBox3.Text = tmp;
			TJSystem.Classes.common.CommonXML.ReadXMLConfigure("pass",ref tmp);
			this.textBox4.Text = tmp;
			TJSystem.Classes.common.CommonXML.ReadXMLConfigure("company",ref tmp);
			this.textBox5.Text = tmp;

			//
			// TODO: 在 InitializeComponent 调用后添加任何构造函数代码
			//
		}

		public frmConfig(bool enabled)
		{
			//
			// Windows 窗体设计器支持所必需的
			//
			InitializeComponent();

			string tmp = null;
			TJSystem.Classes.common.CommonXML.ReadXMLConfigure("station",ref tmp);
			this.textBox1.Text = tmp;
			TJSystem.Classes.common.CommonXML.ReadXMLConfigure("catalog",ref tmp);
			this.textBox2.Text = tmp;
			TJSystem.Classes.common.CommonXML.ReadXMLConfigure("user",ref tmp);
			this.textBox3.Text = tmp;
			TJSystem.Classes.common.CommonXML.ReadXMLConfigure("pass",ref tmp);
			this.textBox4.Text = tmp;

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
			this.panel1 = new System.Windows.Forms.Panel();
			this.label1 = new System.Windows.Forms.Label();
			this.panel2 = new System.Windows.Forms.Panel();
			this.button2 = new TJSystem.Classes.XpStyleButton();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.textBox4 = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.textBox5 = new System.Windows.Forms.TextBox();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.panel1.Controls.Add(this.label1);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(386, 56);
			this.panel1.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label1.Font = new System.Drawing.Font("宋体", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.label1.Location = new System.Drawing.Point(0, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(382, 52);
			this.label1.TabIndex = 0;
			this.label1.Text = "系统参数配置";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// panel2
			// 
			this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.panel2.Controls.Add(this.button2);
			this.panel2.Controls.Add(this.textBox1);
			this.panel2.Controls.Add(this.label2);
			this.panel2.Controls.Add(this.label3);
			this.panel2.Controls.Add(this.textBox2);
			this.panel2.Controls.Add(this.textBox3);
			this.panel2.Controls.Add(this.label4);
			this.panel2.Controls.Add(this.label5);
			this.panel2.Controls.Add(this.textBox4);
			this.panel2.Controls.Add(this.label6);
			this.panel2.Controls.Add(this.textBox5);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel2.Location = new System.Drawing.Point(0, 56);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(386, 240);
			this.panel2.TabIndex = 1;
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(160, 192);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(64, 32);
			this.button2.TabIndex = 217;
			this.button2.Text = "确定";
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(120, 24);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(200, 21);
			this.textBox1.TabIndex = 1;
			this.textBox1.Text = "";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(32, 24);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(80, 23);
			this.label2.TabIndex = 0;
			this.label2.Text = "服务器";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(32, 56);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(80, 23);
			this.label3.TabIndex = 0;
			this.label3.Text = "数据库";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(120, 56);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(200, 21);
			this.textBox2.TabIndex = 1;
			this.textBox2.Text = "";
			// 
			// textBox3
			// 
			this.textBox3.Location = new System.Drawing.Point(120, 88);
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new System.Drawing.Size(200, 21);
			this.textBox3.TabIndex = 1;
			this.textBox3.Text = "";
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(16, 88);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(96, 23);
			this.label4.TabIndex = 0;
			this.label4.Text = "数据库账号";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(32, 120);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(80, 23);
			this.label5.TabIndex = 0;
			this.label5.Text = "数据库密码";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// textBox4
			// 
			this.textBox4.Location = new System.Drawing.Point(120, 120);
			this.textBox4.Name = "textBox4";
			this.textBox4.PasswordChar = '*';
			this.textBox4.Size = new System.Drawing.Size(200, 21);
			this.textBox4.TabIndex = 1;
			this.textBox4.Text = "";
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(32, 152);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(80, 23);
			this.label6.TabIndex = 0;
			this.label6.Text = "公司名称";
			this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// textBox5
			// 
			this.textBox5.Location = new System.Drawing.Point(120, 152);
			this.textBox5.Name = "textBox5";
			this.textBox5.Size = new System.Drawing.Size(200, 21);
			this.textBox5.TabIndex = 1;
			this.textBox5.Text = "";
			// 
			// frmConfig
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(386, 296);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.Name = "frmConfig";
			this.ShowInTaskbar = false;
			this.Text = "系统参数配置";
			this.panel1.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		private void button2_Click(object sender, System.EventArgs e)
		{
			if(this.m_enabled == false)
			{
				TJSystem.Public.PublicStatic.ShowMessage(TJSystem.Public.MessageType.Exclamation,"当前状态只能查看数据库参数配置，无法进行修改！");
				return;
			}
			string strpass = null;
			strpass = TJSystem.Classes.common.CommonSecurity.Encrypt3DES(this.textBox4.Text.Trim(),"hello");
			TJSystem.Classes.common.CommonXML.UpdateXMLConfigure("station",this.textBox1.Text.Trim());
			TJSystem.Classes.common.CommonXML.UpdateXMLConfigure("catalog",this.textBox2.Text.Trim());
			TJSystem.Classes.common.CommonXML.UpdateXMLConfigure("user",this.textBox3.Text.Trim());
			TJSystem.Classes.common.CommonXML.UpdateXMLConfigure("pass",strpass);
			TJSystem.Classes.common.CommonXML.UpdateXMLConfigure("company",this.textBox5.Text.Trim());
			TJSystem.Classes.common.CommonXML.UpdateXMLConfigure("configured","Y");
			this.Close();
		}
	}
}

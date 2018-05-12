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
	public class frmSysPWDChg : System.Windows.Forms.Form
	{
		
		
		/// <summary>
		/// 必需的设计器变量。
		/// </summary>
		private System.ComponentModel.Container components = null;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.Label label2;
		private TJSystem.Classes.XpStyleButton button1;
		private System.Windows.Forms.Label label3;
		private TJSystem.Classes.XpStyleButton button2;
		private TJSystem.Classes.XpStyleButton button3;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.Panel panel1;
		public static System.Windows.Forms.Form frmCurrent = null ;

		public frmSysPWDChg()
		{
			//
			// Windows 窗体设计器支持所必需的
			//
			InitializeComponent();
			TJSystem.Public.PublicStatic.setBackgroundImg(this,this.GetType().BaseType.ToString(),"");


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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(frmSysPWDChg));
			this.label1 = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.button1 = new TJSystem.Classes.XpStyleButton();
			this.label3 = new System.Windows.Forms.Label();
			this.button2 = new TJSystem.Classes.XpStyleButton();
			this.button3 = new TJSystem.Classes.XpStyleButton();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.panel1 = new System.Windows.Forms.Panel();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Location = new System.Drawing.Point(-16, 64);
			this.label1.Name = "label1";
			this.label1.TabIndex = 0;
			this.label1.Text = "新密码";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// textBox1
			// 
			this.textBox1.BackColor = System.Drawing.Color.White;
			this.textBox1.Location = new System.Drawing.Point(104, 64);
			this.textBox1.Name = "textBox1";
			this.textBox1.PasswordChar = '*';
			this.textBox1.Size = new System.Drawing.Size(136, 23);
			this.textBox1.TabIndex = 1;
			this.textBox1.Text = "";
			// 
			// textBox2
			// 
			this.textBox2.BackColor = System.Drawing.Color.White;
			this.textBox2.Location = new System.Drawing.Point(104, 96);
			this.textBox2.Name = "textBox2";
			this.textBox2.PasswordChar = '*';
			this.textBox2.Size = new System.Drawing.Size(136, 23);
			this.textBox2.TabIndex = 3;
			this.textBox2.Text = "";
			// 
			// label2
			// 
			this.label2.BackColor = System.Drawing.Color.Transparent;
			this.label2.Location = new System.Drawing.Point(-16, 96);
			this.label2.Name = "label2";
			this.label2.TabIndex = 2;
			this.label2.Text = "新密码";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.label2.DoubleClick += new System.EventHandler(this.label2_DoubleClick);
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(96, 144);
			this.button1.Name = "button1";
			this.button1.TabIndex = 4;
			this.button1.Text = "确认";
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// label3
			// 
			this.label3.BackColor = System.Drawing.Color.Transparent;
			this.label3.Dock = System.Windows.Forms.DockStyle.Top;
			this.label3.Font = new System.Drawing.Font("宋体", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.label3.Location = new System.Drawing.Point(0, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(310, 56);
			this.label3.TabIndex = 5;
			this.label3.Text = "修改密码";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(240, 176);
			this.button2.Name = "button2";
			this.button2.TabIndex = 6;
			this.button2.Text = "解密";
			this.button2.Visible = false;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(240, 152);
			this.button3.Name = "button3";
			this.button3.TabIndex = 7;
			this.button3.Text = "加密";
			this.button3.Visible = false;
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// textBox3
			// 
			this.textBox3.Location = new System.Drawing.Point(112, 176);
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new System.Drawing.Size(136, 23);
			this.textBox3.TabIndex = 8;
			this.textBox3.Text = "";
			this.textBox3.Visible = false;
			// 
			// panel1
			// 
			this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
			this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.panel1.Controls.Add(this.label3);
			this.panel1.Controls.Add(this.button2);
			this.panel1.Controls.Add(this.button3);
			this.panel1.Controls.Add(this.button1);
			this.panel1.Controls.Add(this.textBox3);
			this.panel1.Controls.Add(this.textBox2);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.textBox1);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(314, 200);
			this.panel1.TabIndex = 9;
			// 
			// frmSysPWDChg
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(7, 16);
			this.BackColor = System.Drawing.SystemColors.ScrollBar;
			this.ClientSize = new System.Drawing.Size(314, 200);
			this.Controls.Add(this.panel1);
			this.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "frmSysPWDChg";
			this.ShowInTaskbar = false;
			this.Text = "修改密码";
			this.panel1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		private void button1_Click(object sender, System.EventArgs e)
		{
			if(this.textBox1.Text.Trim().Equals("")
				|| this.textBox2.Text.Trim().Equals(""))
			{
				TJSystem.Public.PublicStatic.ShowMessage(TJSystem.Public.MessageType.Exclamation,"密码不能为空，密码修改失败！");
				return;
			}
			if(!this.textBox1.Text.Equals(this.textBox2.Text))
			{
				MessageBox.Show("密码两次输入不一致！","错误",MessageBoxButtons.OK,MessageBoxIcon.Warning);
				return;
			}
			string sql = "update basic_employee set password='" + TJSystem.Classes.common.CommonSecurity.Encrypt3DES(this.textBox1.Text,"hello") + "' where employee_id='" + TJSystem.Public.PublicStatic.LoginUser + "'";
			if(MessageBox.Show("确定修改密码？（Y/N）","Information",MessageBoxButtons.YesNo,MessageBoxIcon.Information)
				== System.Windows.Forms.DialogResult.Yes)
			{
				TJSystem.Public.PublicStatic.db.ExeSql(sql);
				MessageBox.Show("密码修改成功！","Information",MessageBoxButtons.OK,MessageBoxIcon.Information);
				
				this.textBox1.Text = "";
				this.textBox2.Text = "";
				this.Close();
			}

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
				TJSystem.Public.PublicStatic.formName = "修改密码";
			}
			base.OnClosing (e);
		}

		private void button3_Click(object sender, System.EventArgs e)
		{
			string dest = TJSystem.Classes.common.CommonSecurity.Encrypt3DES(this.textBox3.Text,"hello");
			this.textBox3.Text = dest;
		}

		private void button2_Click(object sender, System.EventArgs e)
		{
			try
			{
				string dest = TJSystem.Classes.common.CommonSecurity.Decrypt3DES(this.textBox3.Text,"hello");
				this.textBox3.Text = dest;
			}
			catch(System.Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
		}

		private void label2_DoubleClick(object sender, System.EventArgs e)
		{
			if(this.button2.Visible == false || this.button3.Visible == false)
			{
				this.button3.Visible = true;
				this.button2.Visible = true;
				this.textBox3.Visible = true;
			}
			else
			{
				this.button3.Visible = false;
				this.button2.Visible = false;
				this.textBox3.Visible = false;
			}
		}
		
	}
}

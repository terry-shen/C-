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
	public class frmUpdateSysTime : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label3;
		private System.ComponentModel.IContainer components;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox textBox4;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox textBox5;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox textBox6;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Timer timer1;
		private System.Windows.Forms.CheckBox checkBox1;

		public static System.Windows.Forms.Form frmCurrent = null ;

		public frmUpdateSysTime()
		{
			//
			// Windows 窗体设计器支持所必需的
			//
			InitializeComponent();

			InitialFormDateTime();

			//
			// TODO: 在 InitializeComponent 调用后添加任何构造函数代码
			//
		}

		private void InitialFormDateTime()
		{
			this.textBox1.Text = System.DateTime.Now.Year.ToString();
			this.textBox2.Text = System.DateTime.Now.Month.ToString();
			this.textBox3.Text = System.DateTime.Now.Day.ToString();
			this.textBox4.Text = System.DateTime.Now.Hour.ToString();
			this.textBox5.Text = System.DateTime.Now.Minute.ToString();
			this.textBox6.Text = System.DateTime.Now.Second.ToString();
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
			TJSystem.Public.PublicStatic.formName = "更新系统时间";
			base.OnClosing (e);
		}

		#region Windows 窗体设计器生成的代码
		/// <summary>
		/// 设计器支持所需的方法 - 不要使用代码编辑器修改
		/// 此方法的内容。
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(frmUpdateSysTime));
			this.panel1 = new System.Windows.Forms.Panel();
			this.label1 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.button2 = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.textBox4 = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.textBox5 = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.textBox6 = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.checkBox1 = new System.Windows.Forms.CheckBox();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
			this.panel1.Controls.Add(this.label1);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(418, 32);
			this.panel1.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label1.Font = new System.Drawing.Font("宋体", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.label1.Location = new System.Drawing.Point(0, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(418, 32);
			this.label1.TabIndex = 0;
			this.label1.Text = "设置系统时间";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(288, 120);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(80, 24);
			this.button2.TabIndex = 7;
			this.button2.Text = "确认更新";
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// label2
			// 
			this.label2.BackColor = System.Drawing.Color.Transparent;
			this.label2.Location = new System.Drawing.Point(144, 48);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(16, 23);
			this.label2.TabIndex = 8;
			this.label2.Text = "年";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(56, 48);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(88, 21);
			this.textBox1.TabIndex = 9;
			this.textBox1.Text = "";
			this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(168, 48);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(88, 21);
			this.textBox2.TabIndex = 9;
			this.textBox2.Text = "";
			this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// label4
			// 
			this.label4.BackColor = System.Drawing.Color.Transparent;
			this.label4.Location = new System.Drawing.Point(256, 48);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(16, 23);
			this.label4.TabIndex = 8;
			this.label4.Text = "月";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// textBox3
			// 
			this.textBox3.Location = new System.Drawing.Point(280, 48);
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new System.Drawing.Size(88, 21);
			this.textBox3.TabIndex = 9;
			this.textBox3.Text = "";
			this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// label5
			// 
			this.label5.BackColor = System.Drawing.Color.Transparent;
			this.label5.Location = new System.Drawing.Point(368, 48);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(16, 23);
			this.label5.TabIndex = 8;
			this.label5.Text = "日";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// textBox4
			// 
			this.textBox4.Location = new System.Drawing.Point(56, 80);
			this.textBox4.Name = "textBox4";
			this.textBox4.Size = new System.Drawing.Size(88, 21);
			this.textBox4.TabIndex = 9;
			this.textBox4.Text = "";
			this.textBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// label6
			// 
			this.label6.BackColor = System.Drawing.Color.Transparent;
			this.label6.Location = new System.Drawing.Point(256, 80);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(16, 23);
			this.label6.TabIndex = 8;
			this.label6.Text = "分";
			this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// textBox5
			// 
			this.textBox5.Location = new System.Drawing.Point(168, 80);
			this.textBox5.Name = "textBox5";
			this.textBox5.Size = new System.Drawing.Size(88, 21);
			this.textBox5.TabIndex = 9;
			this.textBox5.Text = "";
			this.textBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// label7
			// 
			this.label7.BackColor = System.Drawing.Color.Transparent;
			this.label7.Location = new System.Drawing.Point(368, 80);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(16, 23);
			this.label7.TabIndex = 8;
			this.label7.Text = "秒";
			this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// textBox6
			// 
			this.textBox6.Location = new System.Drawing.Point(280, 80);
			this.textBox6.Name = "textBox6";
			this.textBox6.Size = new System.Drawing.Size(88, 21);
			this.textBox6.TabIndex = 9;
			this.textBox6.Text = "";
			this.textBox6.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// label8
			// 
			this.label8.BackColor = System.Drawing.Color.Transparent;
			this.label8.Location = new System.Drawing.Point(144, 80);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(16, 23);
			this.label8.TabIndex = 8;
			this.label8.Text = "时";
			this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// timer1
			// 
			this.timer1.Interval = 1000;
			this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
			// 
			// checkBox1
			// 
			this.checkBox1.BackColor = System.Drawing.Color.Transparent;
			this.checkBox1.Location = new System.Drawing.Point(48, 120);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.TabIndex = 10;
			this.checkBox1.Text = "自动刷新时间";
			this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
			// 
			// frmUpdateSysTime
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.ClientSize = new System.Drawing.Size(418, 160);
			this.Controls.Add(this.checkBox1);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.textBox3);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.textBox4);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.textBox5);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.textBox6);
			this.Controls.Add(this.label8);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frmUpdateSysTime";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "更新系统时间";
			this.panel1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		
		private void button2_Click(object sender, System.EventArgs e)
		{
			int ret = 0;
			if(!TJSystem.Public.PublicStatic.IsNumeric(this.textBox1.Text.Trim())
				|| !TJSystem.Public.PublicStatic.IsNumeric(this.textBox2.Text.Trim())
				|| !TJSystem.Public.PublicStatic.IsNumeric(this.textBox3.Text.Trim())
				|| !TJSystem.Public.PublicStatic.IsNumeric(this.textBox4.Text.Trim())
				|| !TJSystem.Public.PublicStatic.IsNumeric(this.textBox5.Text.Trim())
				|| !TJSystem.Public.PublicStatic.IsNumeric(this.textBox6.Text.Trim()))
			{
				TJSystem.Public.PublicStatic.ShowMessage(TJSystem.Public.MessageType.Exclamation,"请确保所填入的年月日/时分秒均为数字！");
				return;
			}
			PublicStatic.Classes.common.CommonSysControl csc = new PublicStatic.Classes.common.CommonSysControl();
			PublicStatic.Classes.common.SystemTime sysT = new PublicStatic.Classes.common.SystemTime();
			sysT.wYear = System.Convert.ToInt16(this.textBox1.Text.Trim());
			sysT.wMonth = System.Convert.ToInt16(this.textBox2.Text.Trim());
			sysT.wDay = System.Convert.ToInt16(this.textBox3.Text.Trim());
			sysT.wHour = System.Convert.ToInt16(this.textBox4.Text.Trim());
			sysT.wMinute = System.Convert.ToInt16(this.textBox5.Text.Trim());
			sysT.wSecond = System.Convert.ToInt16(this.textBox6.Text.Trim());

			if(MessageBox.Show("您要更新当前的系统时间为："+sysT.wYear.ToString()+"/"+sysT.wMonth.ToString()+"/"+sysT.wDay.ToString()+" "+sysT.wHour.ToString()+":"+sysT.wMinute.ToString()+":"+sysT.wSecond.ToString(),
				"确认更新",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
			{
				ret = csc.SetLocalTime(sysT);
				if (ret != 1)
				{
					TJSystem.Public.PublicStatic.ShowMessage(TJSystem.Public.MessageType.Error,"系统时间更新失败，请确保所填入的年月日/时分秒均为有效值？");
					return;
				}
				this.Close();
			}
		}

		private void timer1_Tick(object sender, System.EventArgs e)
		{
			this.textBox4.Text = System.DateTime.Now.Hour.ToString();
			this.textBox5.Text = System.DateTime.Now.Minute.ToString();
			this.textBox6.Text = System.DateTime.Now.Second.ToString();
		}

		private void checkBox1_CheckedChanged(object sender, System.EventArgs e)
		{
			if(this.checkBox1.Checked)
			{
				this.timer1.Enabled = true;
			}
			else
			{
				this.timer1.Enabled = false;
			}
		}
	}
}

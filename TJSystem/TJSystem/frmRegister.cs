#define DEBUG
using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace TJSystem
{
	/// <summary>
	/// frmRegister 的摘要说明。
	/// </summary>
	public class frmRegister : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.Button button2;
		/// <summary>
		/// 必需的设计器变量。
		/// </summary>
		private System.ComponentModel.Container components = null;

		public frmRegister()
		{
			//
			// Windows 窗体设计器支持所必需的
			//
			InitializeComponent();

#if DEBUG
			this.button2.Visible = true;
#else
			this.button2.Visible = false;
#endif
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
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.button2 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("宋体", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.label1.Location = new System.Drawing.Point(88, 8);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 40);
			this.label1.TabIndex = 0;
			this.label1.Text = "注册";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(0, 64);
			this.label2.Name = "label2";
			this.label2.TabIndex = 0;
			this.label2.Text = "注册公司名";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(0, 104);
			this.label3.Name = "label3";
			this.label3.TabIndex = 0;
			this.label3.Text = "注册码";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(104, 152);
			this.button1.Name = "button1";
			this.button1.TabIndex = 1;
			this.button1.Text = "注册";
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(112, 64);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(152, 21);
			this.textBox1.TabIndex = 2;
			this.textBox1.Text = "";
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(112, 104);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(152, 21);
			this.textBox2.TabIndex = 2;
			this.textBox2.Text = "";
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(16, 152);
			this.button2.Name = "button2";
			this.button2.TabIndex = 1;
			this.button2.Text = "计算";
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// frmRegister
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(288, 206);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.button2);
			this.Name = "frmRegister";
			this.Text = "frmRegister";
			this.ResumeLayout(false);

		}
		#endregion

		private void button1_Click(object sender, System.EventArgs e)
		{
			string strreg = null;
			string strcmpname = null;
			string strcmpid = null;
			string strenscmpname = null;
			string strenscmpid = null;
			char [] cstrlencmpname = null;
			System.Text.StringBuilder sbs = new System.Text.StringBuilder();
			strcmpname = TJSystem.Public.PublicStatic.CompanyName;
			strcmpid = TJSystem.Public.PublicStatic.CompanyID;
			strenscmpname = TJSystem.Classes.common.CommonSecurity.Encrypt3DES(strcmpname,"hello");
			cstrlencmpname = strenscmpname.ToCharArray();
			for(int i = 0; i < cstrlencmpname.Length; i++)
			{
				sbs.Append(System.Convert.ToInt32(cstrlencmpname[i]).ToString());
			}
			strreg = sbs.ToString();

			/*
			char[] tmpchar = strreg.ToCharArray();
			string strtmp = null;
			System.Text.StringBuilder sbtmp = new System.Text.StringBuilder();
			System.Text.StringBuilder sbdest = new System.Text.StringBuilder();
			char tmp = (char)10 ;
			for(int i = 0; i < tmpchar.Length; i++)
			{
				sbtmp.Append(tmpchar[i].ToString());
				if(System.Convert.ToInt32(sbtmp.ToString()) < 20)
				{
					continue;
				}
				sbdest.Append(Convert.ToChar(Convert.ToInt32(sbtmp.ToString())).ToString());
				sbtmp.Remove(0,sbtmp.Length);
			}

			string strdestreg = sbdest.ToString();
			*/

			System.Text.StringBuilder sb = new System.Text.StringBuilder();
			/*
			if(!this.textBox1.Text.Trim().Equals(TJSystem.Public.PublicStatic.CompanyID))
			{
				TJSystem.Public.PublicStatic.ShowMessage(TJSystem.Public.MessageType.Error,"该公司目前没有授权使用本系统，请购买正版！");
				return;
			}
			*/
			if(!this.textBox1.Text.Trim().Equals(TJSystem.Public.PublicStatic.CompanyName))
			{
				TJSystem.Public.PublicStatic.ShowMessage(TJSystem.Public.MessageType.Error,"该公司目前没有授权使用本系统，请购买正版！");
				return;
			}
			/*
			strreg = TJSystem.Classes.common.CommonSecurity.Encrypt3DES(TJSystem.Public.PublicStatic.CompanyID,"hello");
			*/
			if(!this.textBox2.Text.Trim().Equals(strreg))
			{
				TJSystem.Public.PublicStatic.ShowMessage(TJSystem.Public.MessageType.Error,"注册码有误，注册失败，请输入正确的注册码！");
				return;
			}
			
			sb.Append("delete from xf_reg");
			TJSystem.Public.PublicStatic.db.ExeSql(sb.ToString());
			sb.Remove(0,sb.Length);

			sb.Append("insert into xf_reg values (");
			sb.Append("'");
			sb.Append(System.DateTime.Now.ToString("yyyy-MM-dd"));
			sb.Append("',");
			sb.Append("'");
			sb.Append(System.DateTime.Now.ToString("yyyy-MM-dd"));
			sb.Append("',");
			sb.Append("'");
			sb.Append(strreg);
			sb.Append("',");
			sb.Append("'");
			sb.Append("100");
			sb.Append("',");
			sb.Append("'");
			sb.Append(TJSystem.Public.PublicStatic.CompanyName);
			sb.Append("',");
			sb.Append("'");
			sb.Append(TJSystem.Public.PublicStatic.CompanyID);
			sb.Append("',");
			sb.Append("'");
			sb.Append("Y");
			sb.Append("')");

			TJSystem.Public.PublicStatic.db.ExeSql(sb.ToString());

			TJSystem.Public.PublicStatic.ShowMessage(TJSystem.Public.MessageType.Information,"注册成功，欢迎使用本工作室软件系统！");

			this.Close();
	
		}

		private void button2_Click(object sender, System.EventArgs e)
		{
			string strreg = null;
			string strcmpname = null;
			string strcmpid = null;
			string strenscmpname = null;
			char [] cstrlencmpname = null;
			System.Text.StringBuilder sbs = new System.Text.StringBuilder();
			strcmpname = TJSystem.Public.PublicStatic.CompanyName;
			strcmpid = TJSystem.Public.PublicStatic.CompanyID;
			strenscmpname = TJSystem.Classes.common.CommonSecurity.Encrypt3DES(strcmpname,"hello");
			cstrlencmpname = strenscmpname.ToCharArray();
			for(int i = 0; i < cstrlencmpname.Length; i++)
			{
				sbs.Append(System.Convert.ToInt32(cstrlencmpname[i]).ToString());
			}
			strreg = sbs.ToString();

			this.textBox2.Text = strreg;
		}
	}
}

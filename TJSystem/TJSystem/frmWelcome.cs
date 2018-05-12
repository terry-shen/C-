using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace TJSystem
{
	/// <summary>
	/// frmWelcome 的摘要说明。
	/// </summary>
	public class frmWelcome : System.Windows.Forms.Form
	{
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Timer timer1;
		private System.ComponentModel.IContainer components;
		public System.Windows.Forms.Timer timer2;
		private bool _close = true;
		private bool _hide = true;
		private System.Windows.Forms.Timer timer3;
		frmLogin f = null;

		public frmWelcome(string startPath)
		{
			if(!this.CheckConfigured())
			{
				frmConfig fcfg = new frmConfig();
				fcfg.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
				fcfg.ShowDialog();
			}

			TJSystem.Public.PublicStatic.AppDirectory = startPath;
			//
			// Windows 窗体设计器支持所必需的
			f = new frmLogin(startPath);
			
			//
			InitializeComponent();

			this.timer1.Enabled = false;
			if(TJSystem.Public.PublicStatic.LogOut)
			{
				this.timer1.Enabled = true;
				TJSystem.Public.PublicStatic.LogOut = false;
			}
			this.pictureBox1.Image = Image.FromFile("images\\welcome.jpg");

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

		public bool FormClose
		{
			get
			{
				return _close;
			}
			set
			{
				_close = value;
			}
		}

		public bool FormHide
		{
			get
			{
				return _hide;
			}
			set
			{
				_hide = value;
			}
		}

		#region Windows 窗体设计器生成的代码
		/// <summary>
		/// 设计器支持所需的方法 - 不要使用代码编辑器修改
		/// 此方法的内容。
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.timer2 = new System.Windows.Forms.Timer(this.components);
			this.timer3 = new System.Windows.Forms.Timer(this.components);
			this.SuspendLayout();
			// 
			// pictureBox1
			// 
			this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pictureBox1.Location = new System.Drawing.Point(0, 0);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(624, 424);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
			// 
			// timer1
			// 
			this.timer1.Interval = 1000;
			this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
			// 
			// timer2
			// 
			this.timer2.Enabled = true;
			this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
			// 
			// timer3
			// 
			this.timer3.Enabled = true;
			this.timer3.Interval = 1000;
			this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
			// 
			// frmWelcome
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(624, 424);
			this.Controls.Add(this.pictureBox1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "frmWelcome";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.TopMost = true;
			this.ResumeLayout(false);

		}
		#endregion

		private void timer1_Tick(object sender, System.EventArgs e)
		{
			if(_hide)
			{
				this.Hide();
			}
			this.timer1.Enabled = false;
			Cursor.Current = Cursors.WaitCursor;
			
			f.ShowDialog();
			
			if(f.EFlag)
			{
				return;
			}
			if(TJSystem.Public.PublicStatic.CheckRegistryFun())
			{
				frmMain frm = new frmMain();
				frm.WindowState = System.Windows.Forms.FormWindowState.Maximized;
				frm.Show();
			}
			else
			{
				System.Data.DataTable dt ;
				string start = "";
				string sql = "select start_date,end_date,reg_code,company_id,left_date from xf_reg";
				dt = TJSystem.Public.PublicStatic.db.GetDataTable(sql);

				if(dt.Rows.Count == 1)
				{
					start = dt.Rows[0][0].ToString();
				}

				
				if(start.Trim().Equals(""))
				{
					System.Text.StringBuilder sb = new System.Text.StringBuilder();
					start = System.DateTime.Now.ToString("yyyy-MM-dd");
					TJSystem.Classes.common.CommonXML.UpdateXMLConfigure("start",start);

					sb.Append("delete from xf_reg");
					TJSystem.Public.PublicStatic.db.ExeSql(sb.ToString());
					sb.Remove(0,sb.Length);

					sb.Append("insert into xf_reg values (");
					sb.Append("'");
					sb.Append(TJSystem.Classes.common.CommonSecurity.Encrypt3DES(start,"hello"));
					sb.Append("',");
					sb.Append("'");
					sb.Append(TJSystem.Classes.common.CommonSecurity.Encrypt3DES(start,"hello"));
					sb.Append("',");
					sb.Append("'");
					sb.Append("nokey");
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

					//TJSystem.Public.PublicStatic.db.ExeSql(sb.ToString());
				}
				else
				{
//					start = TJSystem.Classes.common.CommonSecurity.Decrypt3DES(start,"hello");
				}

				start = "2007-11-30";

				System.TimeSpan dtime = System.DateTime.Now - Convert.ToDateTime(start);
				
				System.DateTime dtstart = new DateTime(2000,1,1);
				System.DateTime dtend = new DateTime(2000,2,1);
				System.TimeSpan dttol = dtend - dtstart;
				string strdt = dtime.ToString();
				strdt = dttol.ToString();

				/*
				if(dtime > dttol)
				{
					TJSystem.Public.PublicStatic.ShowMessage(TJSystem.Public.MessageType.Error,"未注册版本，使用到期，请购买正版注册！");
					this.timer3.Enabled = true;
					TJSystem.Public.PublicStatic.FormClose = true;
					return;
				}
				*/
				

//				TJSystem.Public.PublicStatic.ShowMessage(TJSystem.Public.MessageType.Exclamation,"未注册版本，还剩下 " + Convert.ToString(dttol-dtime) + " 天使用时间！");
				TJSystem.Public.PublicStatic.LeftDay = Convert.ToString(dttol-dtime);

				frmMain frm = new frmMain();
				frm.WindowState = System.Windows.Forms.FormWindowState.Maximized;
				frm.Show();
			}
		}

		private void timer2_Tick(object sender, System.EventArgs e)
		{
			this.timer2.Enabled = false;
			this.Width -= 10;
			this.Height -= 8;
			if(this.Width < 10)
			{
				this.timer2.Enabled = false;
			}
		}

		private void timer3_Tick(object sender, System.EventArgs e)
		{
			if(TJSystem.Public.PublicStatic.FormClose)
			{
				this.Close();
			}
		}

		private void pictureBox1_Click(object sender, System.EventArgs e)
		{
			this.timer1.Enabled = true;
		}

		private bool CheckConfigured()
		{
			string config = null;
			TJSystem.Classes.common.CommonXML.ReadXMLConfigure("configured",ref config);
			if(config.Trim().ToUpper().Equals("Y"))
			{
				return true;
			}

			return false;
		}
	}
}

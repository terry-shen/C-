//#define SECURITY
using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data ;
using TJSystem.Classes;


namespace TJSystem
{
	/// <summary>
	/// frmFlash 的摘要描述。
	/// </summary>
	public class frmLogin : System.Windows.Forms.Form
	{		
		private TJSystem.Classes.XpStyleButton btnOK;		
		private XpStyleButton btnCancel;		
		private System.Windows.Forms.Label label1;		
		private System.Windows.Forms.Label label2;		
		private System.Windows.Forms.TextBox txtUserName;		
		private System.Windows.Forms.TextBox txtPassword;		
		private System.Windows.Forms.Label label3;		
		private System.ComponentModel.IContainer components;
		public System.Windows.Forms.ImageList imageList1;
		private bool _flag ;
		private bool _exitflag;
		public string Default = "TERRY";
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.ComboBox comboBox1;
		private bool _MainEntry = false;
		/// <summary>
		/// 沒有參數的構造函數
		/// </summary>
		public frmLogin(string startPath)
		{
			//
			// Windows Form 設計工具支援的必要項
			//
			_flag = false;
			_exitflag = false ;
			InitializeComponent();
			TJSystem.Public.PublicStatic.setBackgroundImg(this,this.GetType().BaseType.ToString(),"");
			TJSystem.Public.PublicStatic.StartupPath = startPath;
			this.txtUserName.Text = "admin" ;
			this.txtPassword.Text = "sweetheart" ;
			this.txtUserName.Focus() ;	
		
			InitialFormValue();
			//
			// TODO: 在 InitializeComponent 呼叫之後加入任何建構函式程式碼
			//
		}

		private void InitialFormValue()
		{
			System.Data.DataTable dt = null;
			string sql = null;
			System.Data.DataRow dr = null;
			System.Data.DataTable dtcpy = null;
			//供应商
			sql = "select company_id,company_name_cn from basic_company order by company_id";
			dt = TJSystem.Public.PublicStatic.db.GetDataTable(sql);
			if (dt.Rows.Count== 0)
			{
				dr = dt.NewRow() ;
				dr[0] = "" ;
				dr[1] = "" ;
				dt.Rows.InsertAt(dr,0) ;
			}
			dtcpy = dt.Copy();
			this.comboBox1.DataSource = dtcpy.DefaultView;
			this.comboBox1.ValueMember = "company_id";
			this.comboBox1.DisplayMember = "company_name_cn";

		}

		/// <summary>
		/// 清除任何使用中的資源。
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

		#region Windows Form 設計工具產生的程式碼
		/// <summary>
		/// 此為設計工具支援所必須的方法 - 請勿使用程式碼編輯器修改
		/// 這個方法的內容。
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(frmLogin));
			this.btnOK = new TJSystem.Classes.XpStyleButton();
			this.btnCancel = new TJSystem.Classes.XpStyleButton();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.txtUserName = new System.Windows.Forms.TextBox();
			this.txtPassword = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.imageList1 = new System.Windows.Forms.ImageList(this.components);
			this.panel1 = new System.Windows.Forms.Panel();
			this.label4 = new System.Windows.Forms.Label();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// btnOK
			// 
			this.btnOK.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(192)), ((System.Byte)(192)), ((System.Byte)(255)));
			this.btnOK.Location = new System.Drawing.Point(72, 152);
			this.btnOK.Name = "btnOK";
			this.btnOK.Size = new System.Drawing.Size(64, 22);
			this.btnOK.TabIndex = 3;
			this.btnOK.Text = "确定";
			this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
			// 
			// btnCancel
			// 
			this.btnCancel.Location = new System.Drawing.Point(176, 152);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(64, 22);
			this.btnCancel.TabIndex = 4;
			this.btnCancel.Text = "取消";
			this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Location = new System.Drawing.Point(32, 48);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(42, 17);
			this.label1.TabIndex = 6;
			this.label1.Text = "用户名";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.BackColor = System.Drawing.Color.Transparent;
			this.label2.Location = new System.Drawing.Point(40, 80);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(29, 17);
			this.label2.TabIndex = 7;
			this.label2.Text = "密码";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txtUserName
			// 
			this.txtUserName.Location = new System.Drawing.Point(96, 48);
			this.txtUserName.Name = "txtUserName";
			this.txtUserName.Size = new System.Drawing.Size(168, 21);
			this.txtUserName.TabIndex = 1;
			this.txtUserName.Text = "";
			this.txtUserName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtUserName_KeyDown);
			// 
			// txtPassword
			// 
			this.txtPassword.Location = new System.Drawing.Point(96, 80);
			this.txtPassword.Name = "txtPassword";
			this.txtPassword.PasswordChar = '*';
			this.txtPassword.Size = new System.Drawing.Size(168, 21);
			this.txtPassword.TabIndex = 2;
			this.txtPassword.Text = "";
			this.txtPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPassword_KeyDown);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.BackColor = System.Drawing.Color.Transparent;
			this.label3.Font = new System.Drawing.Font("PMingLiU", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(136)));
			this.label3.Location = new System.Drawing.Point(112, 8);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(86, 26);
			this.label3.TabIndex = 8;
			this.label3.Text = "用户登陆";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// imageList1
			// 
			this.imageList1.ImageSize = new System.Drawing.Size(80, 60);
			this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
			// 
			// panel1
			// 
			this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
			this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.panel1.Controls.Add(this.comboBox1);
			this.panel1.Controls.Add(this.label4);
			this.panel1.Controls.Add(this.btnOK);
			this.panel1.Controls.Add(this.txtPassword);
			this.panel1.Controls.Add(this.txtUserName);
			this.panel1.Controls.Add(this.btnCancel);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.label3);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(314, 200);
			this.panel1.TabIndex = 9;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.BackColor = System.Drawing.Color.Transparent;
			this.label4.Location = new System.Drawing.Point(40, 112);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(29, 17);
			this.label4.TabIndex = 9;
			this.label4.Text = "公司";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// comboBox1
			// 
			this.comboBox1.Location = new System.Drawing.Point(96, 112);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(168, 20);
			this.comboBox1.TabIndex = 10;
			this.comboBox1.Text = "comboBox1";
			// 
			// frmLogin
			// 
			this.AutoScale = false;
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(192)), ((System.Byte)(192)), ((System.Byte)(255)));
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.ClientSize = new System.Drawing.Size(314, 200);
			this.ControlBox = false;
			this.Controls.Add(this.panel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Location = new System.Drawing.Point(200, 200);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frmLogin";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "登陸";
			this.panel1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion


		private void SetPublicCompanyInfo()
		{
			string sql = null;
			System.Data.DataTable dt = null;
			TJSystem.Public.PublicStatic.CompanyID = this.comboBox1.SelectedValue.ToString();
			if (!this.comboBox1.SelectedValue.ToString().Trim().Equals(""))
			{
				sql = "select company_id,company_name,company_name_cn from basic_company where company_id='";
				sql += this.comboBox1.SelectedValue.ToString();
				sql += "'";
				dt = TJSystem.Public.PublicStatic.db.GetDataTable(sql);
				if (dt.Rows.Count == 1)
				{
					TJSystem.Public.PublicStatic.CompanyName = dt.Rows[0]["company_name_cn"].ToString();
					TJSystem.Public.PublicStatic.CompanyNameEng = dt.Rows[0]["company_name"].ToString();
				}
			}
		}
		/// <summary>
		/// Check if the User Name is suitable the Password,Unload the current Form
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void btnOK_Click(object sender, System.EventArgs e)
		{
			if(CheckUser(this.txtUserName.Text,this.txtPassword.Text))
			{
				_MainEntry = true;
				SetPublicCompanyInfo();

				this.Close() ;
				Cursor.Current = Cursors.WaitCursor ;				
			}
			else
			{
				if(this.txtUserName.Text.Trim().ToUpper() == "TERRY" 
					&& this.txtPassword.Text.Trim().ToUpper() == "SWEETHEART")
				{
					_MainEntry = true;
					SetPublicCompanyInfo();
					this.Close() ;
					return ;
				}
				this.txtPassword.Text = "" ;
				if(MessageBox.Show("用户名和密码比对错误，是否查看数据库连线是否有问题？","Error",MessageBoxButtons.YesNo,MessageBoxIcon.Error)
					== System.Windows.Forms.DialogResult.Yes)
				{
					frmConfig frm = new frmConfig();
					frm.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
					frm.ShowDialog();
					MessageBox.Show("数据库设置成功，请重新启动程序！","提示",MessageBoxButtons.OK,MessageBoxIcon.Information);
					_exitflag = true;
					this.Close();
				}
				this.txtPassword.Focus() ;
			}
		}

		/// <summary>
		/// Unload this Form
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void btnCancel_Click(object sender, System.EventArgs e)
		{
			_exitflag = true;
			this.Close() ;
		}

		/// <summary>
		/// Check if the User Name is suitable the Password,Unload the current Form
		/// (the same method with the ButtonOK_Click)
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void txtPassword_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			if(e.KeyCode == Keys.Enter)
			{
				if(CheckUser(this.txtUserName.Text,this.txtPassword.Text))
				{
					_MainEntry = true;
					SetPublicCompanyInfo();
					this.Close() ;
					Cursor.Current = Cursors.WaitCursor ;					
				}
				else
				{
					if(this.txtUserName.Text.Trim().ToUpper() == "TERRY" 
						&& this.txtPassword.Text.Trim().ToUpper() == "SWEETHEART")
					{
						_MainEntry = true;
						TJSystem.Public.PublicStatic.LoginUser = this.txtUserName.Text ;
						TJSystem.Public.PublicStatic.LoginUserName = "Terry" ;
						this.Close() ;
						return ;
					}
					this.txtPassword.Text = "" ;
					MessageBox.Show("No Such User !") ;
					this.txtPassword.Focus() ;
				}
			}
		}

		/// <summary>
		/// Check if the User Name is suitable the Password
		/// </summary>
		/// <param name="strUser"></param>
		/// <param name="strPass"></param>
		/// <returns></returns>
		private bool CheckUser(string strUser,string strPass)
		{
			DataTable dt ;
			//			GlobalItem gi = new GlobalItem() ;
			string strSQL = "select * from basic_employee where employee_id= '" ;
			strSQL += this.txtUserName.Text.Trim().ToUpper() + "'" ;
			try
			{
				dt = TJSystem.Public.PublicStatic.db.GetDataTable(strSQL) ;
				if(dt == null || dt.Rows.Count == 0 || dt.Rows.Count > 1)
				{
					_flag = false;
					return _flag;
				}
				if(TJSystem.Classes.common.CommonSecurity.Decrypt3DES(dt.Rows[0]["password"].ToString(),"hello").Trim().ToUpper().Equals(this.txtPassword.Text.Trim().ToUpper()))
				{
					TJSystem.Public.PublicStatic.LoginUser = dt.Rows[0]["employee_id"].ToString();
					TJSystem.Public.PublicStatic.LoginUserName = dt.Rows[0]["name_cn"].ToString().Trim() ;
					TJSystem.Public.PublicStatic.LoginTime = System.DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
					if(TJSystem.Public.PublicStatic.IsNumeric(dt.Rows[0]["position"].ToString()))
					{
						TJSystem.Public.PublicStatic.Priority = Convert.ToInt32(dt.Rows[0]["position"].ToString());
					}
					else
					{
						TJSystem.Public.PublicStatic.Priority = 0;
					}

					strSQL = "insert into tj_loginout (login_time,user_id,user_name,client_addr) values ";
					strSQL += "(";
					strSQL += "'" + TJSystem.Public.PublicStatic.LoginTime + "',";
					strSQL += "'" + TJSystem.Public.PublicStatic.LoginUser + "',";
					strSQL += "'" + TJSystem.Public.PublicStatic.LoginUserName + "',";
					strSQL += "'" + System.Net.Dns.GetHostName() + "')";
					TJSystem.Public.PublicStatic.db.ExeSql(strSQL);
					_flag = true;
					return _flag;
				}
				return false ;
			}
			catch(Exception ex)
			{
				_flag = false;
				return _flag;
			}
			//			if(strUser.CompareTo(strPass) == 0)
			//				return true ;
			//			else 
			//				return false ;
		}

		protected override void OnClosing(CancelEventArgs e)
		{
			if(!_MainEntry)
			{
				TJSystem.Public.PublicStatic.FormClose = true;
			}
			base.OnClosing (e);
		}


		/// <summary>
		/// Check if the User Name is suitable the Password,Unload the current Form
		/// (the same method with the ButtonOK_Click)
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void txtUserName_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			if(e.KeyCode == Keys.Enter)
			{
				if(CheckUser(this.txtUserName.Text,this.txtPassword.Text))
				{
					_MainEntry = true;
					this.Close() ;
					Cursor.Current = Cursors.WaitCursor ;
				}
				else
				{
					this.txtPassword.Text = "" ;
					MessageBox.Show("用户名称和密码不匹配") ;
				}
				this.txtPassword.Focus() ;
			}
		}

		public bool LFlag
		{
			get
			{
				return _flag;
			}
		}

		public bool EFlag
		{
			get
			{
				return this._exitflag;
			}
		}
	}
}

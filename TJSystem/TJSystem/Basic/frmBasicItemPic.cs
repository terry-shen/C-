using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;
using System.Data;

namespace TJSystem.Basic
{
	/// <summary>
	/// frmBasicItemPic 的摘要说明。
	/// </summary>
	public class frmBasicItemPic : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel panel2;
		private TJSystem.Classes.XpStyleButton button2;
		private TJSystem.Classes.XpStyleButton xpStyleButton2;
		private string _picfile = "";
		private string _itemcode = null;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox textBox4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox textBox5;
		private TJSystem.Classes.XpStyleButton xpStyleButton1;
		private TJSystem.Classes.XpStyleButton xpStyleButton3;
		private TJSystem.Classes.XpStyleButton xpStyleButton4;

		private int imgIndex = 0;
		private DataTable dt = null;
		private string strsql = "";
		private TJSystem.Classes.XpStyleButton xpStyleButton5;
		private System.Windows.Forms.Panel panel4;
		private System.Windows.Forms.PictureBox pictureBox1;
		
		/// <summary>
		/// 必需的设计器变量。
		/// </summary>
		private System.ComponentModel.Container components = null;

		public frmBasicItemPic(string item_code)
		{
			//
			// Windows 窗体设计器支持所必需的
			//
			InitializeComponent();

			_itemcode = item_code;
//			string strDestbk = @TJSystem.Public.PublicStatic.StartupPath+"\\picbk\\" + this._itemcode + ".jpg" ;
//			string strDest = @TJSystem.Public.PublicStatic.StartupPath+"\\pic\\" + this._itemcode + ".jpg" ;
//			if(System.IO.File.Exists(strDestbk))
//			{
//				System.IO.File.Copy(strDestbk,strDest,true);
//				System.IO.File.Delete(strDestbk);
//				this.pictureBox1.Image = Image.FromFile(strDest);
//			}
//			else if(System.IO.File.Exists(strDest))
//			{				
//				this.pictureBox1.Image = Image.FromFile(strDest);
//			}

			CreateProc();

			TJSystem.Public.PublicStatic.setBackgroundImg(this.panel1,this.panel1.GetType().ToString(),"images\\bg.gif");
			TJSystem.Public.PublicStatic.setBackgroundImg(this.panel2,this.panel2.GetType().ToString(),"");
			TJSystem.Public.PublicStatic.setBackgroundImg(this.panel3,this.panel3.GetType().ToString(),"");

			textBox1.Text = item_code;
			string strSql="select item_code,seq_no,description,picture,remark,remark1 from basic_item_image where item_code='";
			strSql += this.textBox1.Text.Trim();
			strSql += "'";

			strsql = strSql ;

			this.textBox1.Text = item_code;
			GetImgTable();
			this.ShowImage();

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
			this.panel3 = new System.Windows.Forms.Panel();
			this.label5 = new System.Windows.Forms.Label();
			this.textBox5 = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.textBox4 = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.panel2 = new System.Windows.Forms.Panel();
			this.xpStyleButton5 = new TJSystem.Classes.XpStyleButton();
			this.xpStyleButton4 = new TJSystem.Classes.XpStyleButton();
			this.xpStyleButton3 = new TJSystem.Classes.XpStyleButton();
			this.xpStyleButton1 = new TJSystem.Classes.XpStyleButton();
			this.xpStyleButton2 = new TJSystem.Classes.XpStyleButton();
			this.button2 = new TJSystem.Classes.XpStyleButton();
			this.panel4 = new System.Windows.Forms.Panel();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.panel1.SuspendLayout();
			this.panel3.SuspendLayout();
			this.panel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.pictureBox1);
			this.panel1.Controls.Add(this.panel3);
			this.panel1.Controls.Add(this.panel2);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(648, 502);
			this.panel1.TabIndex = 1;
			// 
			// panel3
			// 
			this.panel3.Controls.Add(this.label5);
			this.panel3.Controls.Add(this.textBox5);
			this.panel3.Controls.Add(this.label4);
			this.panel3.Controls.Add(this.textBox4);
			this.panel3.Controls.Add(this.label3);
			this.panel3.Controls.Add(this.textBox3);
			this.panel3.Controls.Add(this.label2);
			this.panel3.Controls.Add(this.textBox2);
			this.panel3.Controls.Add(this.label1);
			this.panel3.Controls.Add(this.textBox1);
			this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel3.Location = new System.Drawing.Point(0, 0);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(648, 152);
			this.panel3.TabIndex = 3;
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(8, 104);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(72, 23);
			this.label5.TabIndex = 9;
			this.label5.Text = "货品备注 2";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// textBox5
			// 
			this.textBox5.BackColor = System.Drawing.Color.White;
			this.textBox5.Enabled = false;
			this.textBox5.Location = new System.Drawing.Point(88, 104);
			this.textBox5.Multiline = true;
			this.textBox5.Name = "textBox5";
			this.textBox5.Size = new System.Drawing.Size(544, 40);
			this.textBox5.TabIndex = 8;
			this.textBox5.Text = "";
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(320, 40);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(72, 23);
			this.label4.TabIndex = 7;
			this.label4.Text = "货品备注 1";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// textBox4
			// 
			this.textBox4.BackColor = System.Drawing.Color.White;
			this.textBox4.Enabled = false;
			this.textBox4.Location = new System.Drawing.Point(400, 40);
			this.textBox4.Multiline = true;
			this.textBox4.Name = "textBox4";
			this.textBox4.Size = new System.Drawing.Size(232, 64);
			this.textBox4.TabIndex = 6;
			this.textBox4.Text = "";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(8, 40);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(72, 23);
			this.label3.TabIndex = 5;
			this.label3.Text = "货品描述";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// textBox3
			// 
			this.textBox3.BackColor = System.Drawing.Color.White;
			this.textBox3.Enabled = false;
			this.textBox3.Location = new System.Drawing.Point(88, 40);
			this.textBox3.Multiline = true;
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new System.Drawing.Size(232, 64);
			this.textBox3.TabIndex = 4;
			this.textBox3.Text = "";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(216, 16);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(72, 23);
			this.label2.TabIndex = 3;
			this.label2.Text = "序号";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// textBox2
			// 
			this.textBox2.BackColor = System.Drawing.Color.White;
			this.textBox2.Enabled = false;
			this.textBox2.Location = new System.Drawing.Point(296, 16);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(120, 21);
			this.textBox2.TabIndex = 2;
			this.textBox2.Text = "";
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(8, 16);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(72, 23);
			this.label1.TabIndex = 1;
			this.label1.Text = "货品编号";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// textBox1
			// 
			this.textBox1.BackColor = System.Drawing.Color.White;
			this.textBox1.Enabled = false;
			this.textBox1.Location = new System.Drawing.Point(88, 16);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(120, 21);
			this.textBox1.TabIndex = 0;
			this.textBox1.Text = "";
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.xpStyleButton5);
			this.panel2.Controls.Add(this.xpStyleButton4);
			this.panel2.Controls.Add(this.xpStyleButton3);
			this.panel2.Controls.Add(this.xpStyleButton1);
			this.panel2.Controls.Add(this.xpStyleButton2);
			this.panel2.Controls.Add(this.button2);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panel2.Location = new System.Drawing.Point(0, 454);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(648, 48);
			this.panel2.TabIndex = 2;
			// 
			// xpStyleButton5
			// 
			this.xpStyleButton5.Location = new System.Drawing.Point(336, 8);
			this.xpStyleButton5.Name = "xpStyleButton5";
			this.xpStyleButton5.Size = new System.Drawing.Size(72, 32);
			this.xpStyleButton5.TabIndex = 10;
			this.xpStyleButton5.Text = "编辑";
			this.xpStyleButton5.Click += new System.EventHandler(this.xpStyleButton5_Click);
			// 
			// xpStyleButton4
			// 
			this.xpStyleButton4.Location = new System.Drawing.Point(416, 8);
			this.xpStyleButton4.Name = "xpStyleButton4";
			this.xpStyleButton4.Size = new System.Drawing.Size(72, 32);
			this.xpStyleButton4.TabIndex = 9;
			this.xpStyleButton4.Text = "关闭";
			this.xpStyleButton4.Click += new System.EventHandler(this.xpStyleButton4_Click);
			// 
			// xpStyleButton3
			// 
			this.xpStyleButton3.Location = new System.Drawing.Point(256, 8);
			this.xpStyleButton3.Name = "xpStyleButton3";
			this.xpStyleButton3.Size = new System.Drawing.Size(72, 32);
			this.xpStyleButton3.TabIndex = 8;
			this.xpStyleButton3.Text = "下一张";
			this.xpStyleButton3.Click += new System.EventHandler(this.xpStyleButton3_Click);
			// 
			// xpStyleButton1
			// 
			this.xpStyleButton1.Location = new System.Drawing.Point(176, 8);
			this.xpStyleButton1.Name = "xpStyleButton1";
			this.xpStyleButton1.Size = new System.Drawing.Size(72, 32);
			this.xpStyleButton1.TabIndex = 7;
			this.xpStyleButton1.Text = "删除";
			this.xpStyleButton1.Click += new System.EventHandler(this.xpStyleButton1_Click_1);
			// 
			// xpStyleButton2
			// 
			this.xpStyleButton2.Location = new System.Drawing.Point(96, 8);
			this.xpStyleButton2.Name = "xpStyleButton2";
			this.xpStyleButton2.Size = new System.Drawing.Size(72, 32);
			this.xpStyleButton2.TabIndex = 6;
			this.xpStyleButton2.Text = "保存";
			this.xpStyleButton2.Click += new System.EventHandler(this.xpStyleButton2_Click);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(16, 8);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(72, 32);
			this.button2.TabIndex = 4;
			this.button2.Text = "新增";
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// panel4
			// 
			this.panel4.Location = new System.Drawing.Point(0, 0);
			this.panel4.Name = "panel4";
			this.panel4.TabIndex = 0;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pictureBox1.Location = new System.Drawing.Point(0, 152);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(648, 302);
			this.pictureBox1.TabIndex = 4;
			this.pictureBox1.TabStop = false;
			// 
			// frmBasicItemPic
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(648, 502);
			this.Controls.Add(this.panel1);
			this.Name = "frmBasicItemPic";
			this.Text = "货品图片";
			this.panel1.ResumeLayout(false);
			this.panel3.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		private void CreateProc()
		{
			string sql = "select name from sysobjects where name = 'UpdateImage'";
			DataTable dttmp = TJSystem.Public.PublicStatic.db.GetDataTable(sql);
			if(dttmp.Rows.Count == 0)
			{
				System.Text.StringBuilder sb = new System.Text.StringBuilder();
				sb.Append(" CREATE PROCEDURE UpdateImage ");
				sb.Append(" ( ");
				sb.Append(" @Itemcode varchar(50),");
				sb.Append(" @Seq int,");
				sb.Append(" @desc varchar(254),");
				sb.Append(" @UpdateImage Image,");
				sb.Append(" @rmk varchar(254),");
				sb.Append(" @rmk1 varchar(254)");
				sb.Append(" ) ");
				sb.Append(" As");
				sb.Append(" insert Into basic_item_image(item_code,seq_no,description,picture,remark,remark1) ");
				sb.Append(" values(@Itemcode,@Seq,@desc,@UpdateImage,@rmk,@rmk1) ");
				sb.Append("");

				TJSystem.Public.PublicStatic.db.ExeSql(sb.ToString());
			}
			else
			{
				return;
			}
		}

		private void button2_Click(object sender, System.EventArgs e)
		{
			System.Windows.Forms.OpenFileDialog frm = new OpenFileDialog();
			frm.Filter = "JPEG图片(*.jpg)|*.jpg|GIF图片(*.gif)|*.gif";
			frm.ShowDialog();
			this.pictureBox1.Image = null;
			if(!frm.FileName.Equals(""))
			{
				this.pictureBox1.Image = Image.FromFile(frm.FileName);
				_picfile = frm.FileName ;
				this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
			}

			
		}

		private void GetImgTable()
		{
			dt = TJSystem.Public.PublicStatic.db.GetDataTable(this.strsql);

			if(dt.Rows.Count > 0)
			{
				imgIndex = 0;
			}
			else
			{
				dt = null;
			}

		}

		private void ShowImage()
		{
			if(dt != null)
			{
				if(imgIndex < dt.Rows.Count)
				{
					MemoryStream ms=new MemoryStream((byte[])this.dt.Rows[imgIndex]["picture"]); 
					Image image = Image.FromStream(ms,true); 

					this.pictureBox1.Image=image;  
					this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;

					this.textBox2.Text = dt.Rows[imgIndex]["seq_no"].ToString();
					this.textBox3.Text = dt.Rows[imgIndex]["description"].ToString();
					this.textBox4.Text = dt.Rows[imgIndex]["remark"].ToString();
					this.textBox5.Text = dt.Rows[imgIndex]["remark1"].ToString();
				}
			}
		}


		private void InsertImage(string filename)
		{
			try 
			{ 
				if(!checkFormValue())
				{
					return ;
				}

				System.IO.FileInfo fs = new System.IO.FileInfo(filename); 
				if (!fs.Exists) 
				{ 
					MessageBox.Show("无效的文件名!"); 
					return; 
				} 
				//创建一字节数组,用来存储图像文件.(数组的长度是图像文件的长度) 
				byte[] Content=new byte[fs.Length]; 
				//打开文件并用他初始化一个文件流对象 
				FileStream ImageFileStream=fs.OpenRead(); 
				//将文件内容写入字节数组 
				ImageFileStream.Read(Content,0,Content.Length); 
				//关闭文件流 
				//MessageBox.Show("读取完毕!"); 

				//连接数据库 
				SqlConnection conn=new SqlConnection(); 
				conn.ConnectionString=TJSystem.Public.PublicStatic.ConnectionString;

				SqlCommand cmd=new SqlCommand("UpdateImage",conn); 
				cmd.CommandType=CommandType.StoredProcedure; 

				cmd.Parameters.Add("@Itemcode",SqlDbType.VarChar); 
				cmd.Parameters["@Itemcode"].Value=this.textBox1.Text;
				cmd.Parameters.Add("@Seq",SqlDbType.Int); 
				cmd.Parameters["@Seq"].Value=Convert.ToInt32(this.textBox2.Text.Trim());
				cmd.Parameters.Add("@desc",SqlDbType.VarChar); 
				cmd.Parameters["@desc"].Value=this.textBox3.Text;
				cmd.Parameters.Add("@UpdateImage",SqlDbType.Image); 
				cmd.Parameters["@UpdateImage"].Value=Content; 
				cmd.Parameters.Add("@rmk",SqlDbType.VarChar); 
				cmd.Parameters["@rmk"].Value=this.textBox4.Text;
				cmd.Parameters.Add("@rmk1",SqlDbType.VarChar); 
				cmd.Parameters["@rmk1"].Value=this.textBox5.Text;

//				System.Data.SqlClient.SqlParameter [] sqlparams = new SqlParameter[6];
//				sqlparams[0] = new SqlParameter("@Itemcode",SqlDbType.VarChar);
//				sqlparams[0].Value = this.textBox1.Text;
//				sqlparams[1] = new SqlParameter("@Itemcode",SqlDbType.VarChar);
//				sqlparams[1].Value = Convert.ToInt32(this.textBox2.Text.Trim());
//				sqlparams[2] = new SqlParameter("@Itemcode",SqlDbType.VarChar);
//				sqlparams[2].Value = this.textBox3.Text;
//				sqlparams[3] = new SqlParameter("@Itemcode",SqlDbType.VarChar);
//				sqlparams[3].Value = Content;
//				sqlparams[4] = new SqlParameter("@Itemcode",SqlDbType.VarChar);
//				sqlparams[4].Value = this.textBox4.Text;
//				sqlparams[5] = new SqlParameter("@Itemcode",SqlDbType.VarChar);
//				sqlparams[5].Value = this.textBox5.Text;

				if(MessageBox.Show("确定要新增该图片？（Y/N）","新增",MessageBoxButtons.YesNo,MessageBoxIcon.Question)
					== System.Windows.Forms.DialogResult.Yes)
				{
					conn.Open(); 
					cmd.ExecuteNonQuery(); 
					conn.Close(); 
//					TJSystem.Public.PublicStatic.db.ExeProcedure("UpdateImage",sqlparams);
				}

				ImageFileStream.Close(); 
				TJSystem.Public.PublicStatic.ShowMessage(TJSystem.Public.MessageType.Information,"图片插入成功！");
				GetImgTable();
			} 
			catch (Exception ex) 
			{ 
				MessageBox.Show(ex.Message); 
			} 


		}

		private bool checkFormValue()
		{
			if(!TJSystem.Public.PublicStatic.IsNumDouble(this.textBox2.Text.Trim()))
			{
				TJSystem.Public.PublicStatic.ShowMessage(TJSystem.Public.MessageType.Exclamation,"货品序号必须是数字！");
				return false;
			}

			if(this.pictureBox1.Image == null)
			{
				TJSystem.Public.PublicStatic.ShowMessage(TJSystem.Public.MessageType.Exclamation,"尚未载入货品图片资料！");
				return false;
			}
			string sql = "select item_code from basic_item_image where item_code='";
			sql += this.textBox1.Text;
			sql += "' and seq_no =";
			sql += Convert.ToInt32(this.textBox2.Text.Trim());

			DataTable dttmp = TJSystem.Public.PublicStatic.db.GetDataTable(sql);
			if(dttmp.Rows.Count > 0)
			{
				TJSystem.Public.PublicStatic.ShowMessage(TJSystem.Public.MessageType.Exclamation,"已存在该图片资料，若想修改，请将原来的图片先删除！");
				return false;
			}
			return true;
		}

		private void xpStyleButton2_Click(object sender, System.EventArgs e)
		{
			if(!_picfile.Equals(""))
			{
				this.InsertImage(_picfile);
			}
		}

		private void xpStyleButton1_Click(object sender, System.EventArgs e)
		{
			
		}

		private void xpStyleButton4_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}

		private void xpStyleButton3_Click(object sender, System.EventArgs e)
		{
			if(dt == null)
				return;

			if(this.imgIndex < dt.Rows.Count)
			{
				if(this.imgIndex == dt.Rows.Count - 1)
				{
					this.imgIndex = 0;
				}
				else
				{
					this.imgIndex ++;
				}
				
				this.ShowImage();
			}
		}

		private void xpStyleButton5_Click(object sender, System.EventArgs e)
		{
			if(this.xpStyleButton5.Text.Equals("编辑"))
			{
				this.xpStyleButton5.Text = "锁定";
				this.textBox2.Enabled = true;
				this.textBox3.Enabled = true;
				this.textBox4.Enabled = true;
				this.textBox5.Enabled = true;
			}
			else
			{
				this.xpStyleButton5.Text = "编辑";
				this.textBox2.Enabled = false;
				this.textBox3.Enabled = false;
				this.textBox4.Enabled = false;
				this.textBox5.Enabled = false;
			}
		}

		private void xpStyleButton1_Click_1(object sender, System.EventArgs e)
		{
			if(!TJSystem.Public.PublicStatic.IsNumDouble(this.textBox2.Text.Trim()))
			{
				TJSystem.Public.PublicStatic.ShowMessage(TJSystem.Public.MessageType.Exclamation,"货品序号必须是数字！");
				return ;
			}

			if(this.pictureBox1.Image == null)
			{
				TJSystem.Public.PublicStatic.ShowMessage(TJSystem.Public.MessageType.Exclamation,"尚未载入货品图片资料！");
				return ;
			}

			string sql = "delete from basic_item_image where item_code='";
			sql += this.textBox1.Text;
			sql += "' and seq_no =";
			sql += Convert.ToInt32(this.textBox2.Text.Trim());

			if(MessageBox.Show("确定要删除该图片？（Y/N）","删除",MessageBoxButtons.YesNo,MessageBoxIcon.Question)
				== System.Windows.Forms.DialogResult.Yes)
			{
				TJSystem.Public.PublicStatic.db.ExeSql(sql);

				GetImgTable();
				this.ShowImage();
			}
		}

		private void pictureBox1_DoubleClick(object sender, System.EventArgs e)
		{
			if(this.panel3.Visible)
			{
				this.panel3.Visible = false;
			}
			else
			{
				this.panel3.Visible = true;
			}
			if(this.panel2.Visible)
			{
				this.panel2.Visible = false;
			}
			else
			{
				this.panel2.Visible = true;
			}
		}
	}
}

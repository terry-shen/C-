using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using TJSystem.Sales;
using TJSystem.Doc;

namespace TJSystem
{
	/// <summary>
	/// frmCopyForm ��ժҪ˵����
	/// </summary>
	public class frmSearchCustomer : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button button1;
		/// <summary>
		/// ����������������
		/// </summary>
		private System.ComponentModel.Container components = null;

		public static System.Windows.Forms.Form frmCurrent = null ;

		public frmSearchCustomer()
		{
			//
			// Windows ���������֧���������
			//
			InitializeComponent();
			InitialFormData();

			//
			// TODO: �� InitializeComponent ���ú�����κι��캯������
			//
		}

		/// <summary>
		/// ������������ʹ�õ���Դ��
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
			base.OnClosing (e);
		}

		private void InitialFormData()
		{
			DataTable dtcpy = null;
			DataRow dr = null;
			string sql = "select Client_id,Client_id +' '+ Client_name as Client_name from basic_client order by Client_id";
			DataTable dt = TJSystem.Public.PublicStatic.db.GetDataTable(sql);
			dr = dt.NewRow() ;
			dr[0] = "" ;
			dr[1] = "" ;
			dt.Rows.InsertAt(dr,0) ;
			dtcpy = dt.Copy();
			this.comboBox1.DataSource = dtcpy.DefaultView;
			this.comboBox1.ValueMember = "Client_id";
			this.comboBox1.DisplayMember = "Client_name";
		}

		#region Windows ������������ɵĴ���
		/// <summary>
		/// �����֧������ķ��� - ��Ҫʹ�ô���༭���޸�
		/// �˷��������ݡ�
		/// </summary>
		private void InitializeComponent()
		{
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(frmSearchCustomer));
			this.panel1 = new System.Windows.Forms.Panel();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.label3 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
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
			this.panel1.Size = new System.Drawing.Size(458, 32);
			this.panel1.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label1.Font = new System.Drawing.Font("����", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.label1.Location = new System.Drawing.Point(0, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(458, 32);
			this.label1.TabIndex = 0;
			this.label1.Text = "������������";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label2
			// 
			this.label2.BackColor = System.Drawing.Color.Transparent;
			this.label2.Location = new System.Drawing.Point(24, 56);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(72, 23);
			this.label2.TabIndex = 1;
			this.label2.Text = "�ͻ�";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// comboBox1
			// 
			this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBox1.Location = new System.Drawing.Point(104, 56);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(328, 20);
			this.comboBox1.TabIndex = 2;
			// 
			// label3
			// 
			this.label3.BackColor = System.Drawing.Color.Transparent;
			this.label3.Location = new System.Drawing.Point(504, 400);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(128, 23);
			this.label3.TabIndex = 4;
			this.label3.Text = "�������µ���";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(168, 96);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(104, 24);
			this.button1.TabIndex = 7;
			this.button1.Text = "ȷ��";
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// frmSearchCustomer
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.ClientSize = new System.Drawing.Size(458, 144);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.comboBox1);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.panel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frmSearchCustomer";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "������������";
			this.TopMost = true;
			this.panel1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		private void button1_Click(object sender, System.EventArgs e)
		{
			string customid = null;
			string formname = null;
			string sql = null;
			DataTable dt = null;
			DataTable dtTmp = null;
			if(this.comboBox1.SelectedValue.ToString().Equals(""))
			{
				TJSystem.Public.PublicStatic.ShowMessage(TJSystem.Public.MessageType.Information,
					"��ѡ��ͻ����ƣ�����");
				return;
			}
			customid = this.comboBox1.SelectedValue.ToString().Trim();
			formname = "�ͻ�ѯ�۵�";
			sql = "select * from sale_ce_master where Client_id = '" + customid + "'";
			dt = TJSystem.Public.PublicStatic.db.GetDataTable(sql);
			if(dt.Rows.Count > 0)
			{
				if(System.Windows.Forms.MessageBox.Show("�ÿͻ��пͻ�ѯ�ۼ�¼���Ƿ�򿪲쿴��","Found",MessageBoxButtons.YesNo,MessageBoxIcon.Question)
					== System.Windows.Forms.DialogResult.Yes)
				{
					if(frmSaleCE.frmCurrent == null)
					{
						frmSaleCE.frmCurrent = new frmSaleCE(customid);
						frmSaleCE.frmCurrent.MdiParent = TJSystem.Public.PublicStatic.CurrentMdiForm;
					}
					else
					{
//						TJSystem.Public.PublicStatic.formClose = true;
//						TJSystem.Public.PublicStatic.formName = "�ͻ�ѯ�۵�";
						frmSaleCE.frmCurrent.Close();
						
						frmSaleCE.frmCurrent = new frmSaleCE(customid);
						frmSaleCE.frmCurrent.MdiParent = TJSystem.Public.PublicStatic.CurrentMdiForm;
					}
					frmSaleCE.frmCurrent.WindowState = System.Windows.Forms.FormWindowState.Maximized;
					frmSaleCE.frmCurrent.Show();
				}
			}

			formname = "���۵�";
			sql = "select * from sale_cq_master where Client_id = '" + customid + "'";
			dt = TJSystem.Public.PublicStatic.db.GetDataTable(sql);
			if(dt.Rows.Count > 0)
			{
				this.TopMost = false;
				if(System.Windows.Forms.MessageBox.Show("�ÿͻ��б��ۼ�¼���Ƿ�򿪲쿴��","Found",MessageBoxButtons.YesNo,MessageBoxIcon.Question)
					== System.Windows.Forms.DialogResult.Yes)
				{
					if(frmSaleCQ.frmCurrent == null)
					{
						frmSaleCQ.frmCurrent = new frmSaleCQ(customid);
						frmSaleCQ.frmCurrent.MdiParent = TJSystem.Public.PublicStatic.CurrentMdiForm;
					}
					else
					{
//						TJSystem.Public.PublicStatic.formClose = true;
//						TJSystem.Public.PublicStatic.formName = "���۵�";
						frmSaleCQ.frmCurrent.Close();
						
						frmSaleCQ.frmCurrent = new frmSaleCQ(customid);
						frmSaleCQ.frmCurrent.MdiParent = TJSystem.Public.PublicStatic.CurrentMdiForm;
					}
					frmSaleCQ.frmCurrent.WindowState = System.Windows.Forms.FormWindowState.Maximized;
					frmSaleCQ.frmCurrent.Show();
				}
				this.TopMost = true;
			}

			formname = "���۶���";
			sql = "select * from sale_so_master where Client_id = '" + customid + "'";
			dt = TJSystem.Public.PublicStatic.db.GetDataTable(sql);
			if(dt.Rows.Count > 0)
			{
				System.Text.StringBuilder sb = new System.Text.StringBuilder();
				this.TopMost = false;
				if(System.Windows.Forms.MessageBox.Show("�ÿͻ������ۼ�¼���Ƿ�򿪲쿴��","Found",MessageBoxButtons.YesNo,MessageBoxIcon.Question)
					== System.Windows.Forms.DialogResult.Yes)
				{
					if(frmSaleOrder.frmCurrent == null)
					{
						frmSaleOrder.frmCurrent = new frmSaleOrder(customid);
						frmSaleOrder.frmCurrent.MdiParent = TJSystem.Public.PublicStatic.CurrentMdiForm;
					}
					else
					{
//						TJSystem.Public.PublicStatic.formClose = true;
//						TJSystem.Public.PublicStatic.formName = "���۶���";
						frmSaleOrder.frmCurrent.Close();
						
						frmSaleOrder.frmCurrent = new frmSaleOrder(customid);
						frmSaleOrder.frmCurrent.MdiParent = TJSystem.Public.PublicStatic.CurrentMdiForm;
					}
					frmSaleOrder.frmCurrent.WindowState = System.Windows.Forms.FormWindowState.Maximized;
					frmSaleOrder.frmCurrent.Show();
				}
				this.TopMost = true;

				for (int i = 0; i < dt.Rows.Count; i++)
				{
					sb.Append("'");
					sb.Append(dt.Rows[i]["so_code"].ToString());
					sb.Append("'");
					sb.Append(",");
				}
				sql = "select * from sale_doc_master where invoice_no in (" + sb.ToString().Substring(0,sb.Length-1) + ")";
				dtTmp = TJSystem.Public.PublicStatic.db.GetDataTable(sql);
				if(dtTmp.Rows.Count > 0)
				{
					this.TopMost = false;
					if(System.Windows.Forms.MessageBox.Show("�ÿͻ��е�֤��¼���Ƿ�򿪲쿴��","Found",MessageBoxButtons.YesNo,MessageBoxIcon.Question)
						== System.Windows.Forms.DialogResult.Yes)
					{
						if(frmSaleDoc.frmCurrent == null)
						{
							frmSaleDoc.frmCurrent = new frmSaleDoc(sb.ToString().Substring(0,sb.Length-1));
							frmSaleDoc.frmCurrent.MdiParent = TJSystem.Public.PublicStatic.CurrentMdiForm;
						}
						else
						{
//							TJSystem.Public.PublicStatic.formClose = true;
//							TJSystem.Public.PublicStatic.formName = "��֤����";
							frmSaleDoc.frmCurrent.Close();
							
							frmSaleDoc.frmCurrent = new frmSaleDoc(sb.ToString().Substring(0,sb.Length-1));
							frmSaleDoc.frmCurrent.MdiParent = TJSystem.Public.PublicStatic.CurrentMdiForm;
						}
						frmSaleDoc.frmCurrent.WindowState = System.Windows.Forms.FormWindowState.Maximized;
						frmSaleDoc.frmCurrent.Show();
					}
					this.TopMost = true;
				}//SALE_WAYBILL_MASTER

				sql = "select * from SALE_WAYBILL_MASTER where AWB_CODE in (" + sb.ToString().Substring(0,sb.Length-1) + ")";
				dtTmp = TJSystem.Public.PublicStatic.db.GetDataTable(sql);
				if(dtTmp.Rows.Count > 0)
				{
					this.TopMost = false;
					if(System.Windows.Forms.MessageBox.Show("�ÿͻ��л������˼�¼���Ƿ�򿪲쿴��","Found",MessageBoxButtons.YesNo,MessageBoxIcon.Question)
						== System.Windows.Forms.DialogResult.Yes)
					{
						if(frmAwbDoc.frmCurrent == null)
						{
							frmAwbDoc.frmCurrent = new frmAwbDoc(sb.ToString().Substring(0,sb.Length-1));
							frmAwbDoc.frmCurrent.MdiParent = TJSystem.Public.PublicStatic.CurrentMdiForm;
						}
						else
						{
//							TJSystem.Public.PublicStatic.formClose = true;
//							TJSystem.Public.PublicStatic.formName = "�������˵�";
							frmAwbDoc.frmCurrent.Close();
							
							frmAwbDoc.frmCurrent = new frmAwbDoc(sb.ToString().Substring(0,sb.Length-1));
							frmAwbDoc.frmCurrent.MdiParent = TJSystem.Public.PublicStatic.CurrentMdiForm;
						}
						frmAwbDoc.frmCurrent.WindowState = System.Windows.Forms.FormWindowState.Maximized;
						frmAwbDoc.frmCurrent.Show();
					}
					this.TopMost = true;
				}
			}
		}

		
	}
}

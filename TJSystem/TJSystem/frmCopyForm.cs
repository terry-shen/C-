using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace TJSystem
{
	/// <summary>
	/// frmCopyForm ��ժҪ˵����
	/// </summary>
	public class frmCopyForm : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.ComboBox comboBox2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.CheckBox checkBox1;
		private System.Windows.Forms.CheckBox checkBox2;
		private System.Windows.Forms.CheckBox checkBox3;
		private System.Windows.Forms.CheckBox checkBox5;
		private System.Windows.Forms.CheckBox checkBox6;
		private System.Windows.Forms.CheckBox checkBox7;
		private System.Windows.Forms.CheckBox checkBox9;
		private System.Windows.Forms.CheckBox checkBox10;
		private System.Windows.Forms.Button button1;
		/// <summary>
		/// ����������������
		/// </summary>
		private System.ComponentModel.Container components = null;
		private System.Windows.Forms.GroupBox groupBox1;

		public static System.Windows.Forms.Form frmCurrent = null ;

		public frmCopyForm()
		{
			//
			// Windows ���������֧���������
			//
			InitializeComponent();

			InitialTypeComboBox();

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
			TJSystem.Public.PublicStatic.formClose = true;
			TJSystem.Public.PublicStatic.formName = "���ݸ���";
			base.OnClosing (e);
		}

		#region Windows ������������ɵĴ���
		/// <summary>
		/// �����֧������ķ��� - ��Ҫʹ�ô���༭���޸�
		/// �˷��������ݡ�
		/// </summary>
		private void InitializeComponent()
		{
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(frmCopyForm));
			this.panel1 = new System.Windows.Forms.Panel();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.comboBox2 = new System.Windows.Forms.ComboBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.checkBox1 = new System.Windows.Forms.CheckBox();
			this.checkBox2 = new System.Windows.Forms.CheckBox();
			this.checkBox3 = new System.Windows.Forms.CheckBox();
			this.checkBox5 = new System.Windows.Forms.CheckBox();
			this.checkBox6 = new System.Windows.Forms.CheckBox();
			this.checkBox7 = new System.Windows.Forms.CheckBox();
			this.checkBox9 = new System.Windows.Forms.CheckBox();
			this.checkBox10 = new System.Windows.Forms.CheckBox();
			this.button1 = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.panel1.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
			this.panel1.Controls.Add(this.label1);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(450, 48);
			this.panel1.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label1.Font = new System.Drawing.Font("����", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.label1.Location = new System.Drawing.Point(0, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(450, 48);
			this.label1.TabIndex = 0;
			this.label1.Text = "���ݸ���";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label2
			// 
			this.label2.BackColor = System.Drawing.Color.Transparent;
			this.label2.Location = new System.Drawing.Point(24, 72);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(72, 23);
			this.label2.TabIndex = 1;
			this.label2.Text = "Դ����";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// comboBox1
			// 
			this.comboBox1.Items.AddRange(new object[] {
														   "�ɹ�ѯ�۵�",
														   "��Ӧ�̱��۵�",
														   "�ɹ�����",
														   "�ͻ�ѯ�۵�",
														   "���۵�",
														   "���۶���"});
			this.comboBox1.Location = new System.Drawing.Point(96, 72);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(144, 20);
			this.comboBox1.TabIndex = 2;
			this.comboBox1.SelectionChangeCommitted += new System.EventHandler(this.comboBox1_SelectionChangeCommitted);
			// 
			// comboBox2
			// 
			this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBox2.Location = new System.Drawing.Point(256, 72);
			this.comboBox2.Name = "comboBox2";
			this.comboBox2.Size = new System.Drawing.Size(168, 20);
			this.comboBox2.TabIndex = 3;
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
			// label4
			// 
			this.label4.BackColor = System.Drawing.Color.Transparent;
			this.label4.Location = new System.Drawing.Point(24, 96);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(72, 23);
			this.label4.TabIndex = 1;
			this.label4.Text = "�µ���";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(96, 96);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(144, 21);
			this.textBox1.TabIndex = 5;
			this.textBox1.Text = "";
			// 
			// checkBox1
			// 
			this.checkBox1.BackColor = System.Drawing.Color.Transparent;
			this.checkBox1.Location = new System.Drawing.Point(8, 32);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.Size = new System.Drawing.Size(136, 24);
			this.checkBox1.TabIndex = 6;
			this.checkBox1.Text = "�ɹ�ѯ�۵�";
			// 
			// checkBox2
			// 
			this.checkBox2.BackColor = System.Drawing.Color.Transparent;
			this.checkBox2.Location = new System.Drawing.Point(8, 56);
			this.checkBox2.Name = "checkBox2";
			this.checkBox2.Size = new System.Drawing.Size(136, 24);
			this.checkBox2.TabIndex = 6;
			this.checkBox2.Text = "��Ӧ�̱��۵�";
			// 
			// checkBox3
			// 
			this.checkBox3.BackColor = System.Drawing.Color.Transparent;
			this.checkBox3.Location = new System.Drawing.Point(8, 80);
			this.checkBox3.Name = "checkBox3";
			this.checkBox3.Size = new System.Drawing.Size(136, 24);
			this.checkBox3.TabIndex = 6;
			this.checkBox3.Text = "�ɹ�����";
			// 
			// checkBox5
			// 
			this.checkBox5.BackColor = System.Drawing.Color.Transparent;
			this.checkBox5.Location = new System.Drawing.Point(144, 32);
			this.checkBox5.Name = "checkBox5";
			this.checkBox5.Size = new System.Drawing.Size(136, 24);
			this.checkBox5.TabIndex = 6;
			this.checkBox5.Text = "�ͻ�ѯ�۵�";
			// 
			// checkBox6
			// 
			this.checkBox6.BackColor = System.Drawing.Color.Transparent;
			this.checkBox6.Location = new System.Drawing.Point(144, 56);
			this.checkBox6.Name = "checkBox6";
			this.checkBox6.Size = new System.Drawing.Size(136, 24);
			this.checkBox6.TabIndex = 6;
			this.checkBox6.Text = "���۵�";
			// 
			// checkBox7
			// 
			this.checkBox7.BackColor = System.Drawing.Color.Transparent;
			this.checkBox7.Location = new System.Drawing.Point(144, 80);
			this.checkBox7.Name = "checkBox7";
			this.checkBox7.Size = new System.Drawing.Size(136, 24);
			this.checkBox7.TabIndex = 6;
			this.checkBox7.Text = "���۶���";
			// 
			// checkBox9
			// 
			this.checkBox9.BackColor = System.Drawing.Color.Transparent;
			this.checkBox9.Location = new System.Drawing.Point(280, 32);
			this.checkBox9.Name = "checkBox9";
			this.checkBox9.Size = new System.Drawing.Size(96, 24);
			this.checkBox9.TabIndex = 6;
			this.checkBox9.Text = "��֤";
			// 
			// checkBox10
			// 
			this.checkBox10.BackColor = System.Drawing.Color.Transparent;
			this.checkBox10.Location = new System.Drawing.Point(280, 56);
			this.checkBox10.Name = "checkBox10";
			this.checkBox10.Size = new System.Drawing.Size(96, 24);
			this.checkBox10.TabIndex = 6;
			this.checkBox10.Text = "�������˵�";
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(128, 256);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(200, 32);
			this.button1.TabIndex = 7;
			this.button1.Text = "ȷ��";
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// groupBox1
			// 
			this.groupBox1.BackColor = System.Drawing.Color.Transparent;
			this.groupBox1.Controls.Add(this.checkBox5);
			this.groupBox1.Controls.Add(this.checkBox6);
			this.groupBox1.Controls.Add(this.checkBox7);
			this.groupBox1.Controls.Add(this.checkBox9);
			this.groupBox1.Controls.Add(this.checkBox3);
			this.groupBox1.Controls.Add(this.checkBox10);
			this.groupBox1.Controls.Add(this.checkBox1);
			this.groupBox1.Controls.Add(this.checkBox2);
			this.groupBox1.Location = new System.Drawing.Point(24, 128);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(408, 112);
			this.groupBox1.TabIndex = 8;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "�������µ���";
			// 
			// frmCopyForm
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.ClientSize = new System.Drawing.Size(450, 304);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.comboBox2);
			this.Controls.Add(this.comboBox1);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.label4);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frmCopyForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "���ݸ���";
			this.panel1.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		private void button1_Click(object sender, System.EventArgs e)
		{
			PublicStatic.Classes.common.CommonSubTableHandle csth = new PublicStatic.Classes.common.CommonSubTableHandle();
//			TJSystem.Public.PublicStatic.ShowMessage(TJSystem.Public.MessageType.Information,"�ù�����δʵ�֣���ȴ����°汾��");
			int ret = 0;
			if (this.comboBox2.SelectedValue.ToString().Equals(""))
			{
				ShowErrInfo(10,"");
				return;
			}
			if (this.textBox1.Text.Trim().Equals(""))
			{
				ShowErrInfo(11,"");
				return;
			}
			if(this.checkBox1.Checked)//�ɹ�ѯ�۵�
			{
				csth.TableName = "purchase_se_master";
				csth.PrimaryKeyField = "se_code";
				csth.PrimaryKeyValue = this.comboBox2.SelectedValue.ToString();;
				csth.PrimaryKeyNewValue = this.textBox1.Text.Trim();
				ret = csth.SubTableInsert();
				ShowErrInfo(ret,"�ɹ�ѯ����ϸ��");
				csth.TableName = "purchase_se_detail";
				csth.PrimaryKeyField = "se_code";
				csth.PrimaryKeyValue = this.comboBox2.SelectedValue.ToString();;
				csth.PrimaryKeyNewValue = this.textBox1.Text.Trim();
				ret = csth.SubTableInsert();
				ShowErrInfo(ret,"�ɹ�ѯ�۵�");
			}
			if(this.checkBox2.Checked)//��Ӧ�̱��۵�
			{
				csth.TableName = "purchase_sq_master";
				csth.PrimaryKeyField = "sq_code";
				csth.PrimaryKeyValue = this.comboBox2.SelectedValue.ToString();;
				csth.PrimaryKeyNewValue = this.textBox1.Text.Trim();
				ret = csth.SubTableInsert();
				ShowErrInfo(ret,"��Ӧ�̱��۵�");
				csth.TableName = "purchase_sq_detail";
				csth.PrimaryKeyField = "sq_code";
				csth.PrimaryKeyValue = this.comboBox2.SelectedValue.ToString();;
				csth.PrimaryKeyNewValue = this.textBox1.Text.Trim();
				ret = csth.SubTableInsert();
				ShowErrInfo(ret,"��Ӧ�̱�����ϸ��");
			}
			if(this.checkBox3.Checked)//�ɹ�����
			{
				csth.TableName = "purchase_po_master";
				csth.PrimaryKeyField = "po_code";
				csth.PrimaryKeyValue = this.comboBox2.SelectedValue.ToString();;
				csth.PrimaryKeyNewValue = this.textBox1.Text.Trim();
				ret = csth.SubTableInsert();
				ShowErrInfo(ret,"�ɹ�����");
				csth.TableName = "purchase_po_detail";
				csth.PrimaryKeyField = "po_code";
				csth.PrimaryKeyValue = this.comboBox2.SelectedValue.ToString();;
				csth.PrimaryKeyNewValue = this.textBox1.Text.Trim();
				ret = csth.SubTableInsert();
				ShowErrInfo(ret,"�ɹ�������ϸ");
			}
			if(this.checkBox5.Checked)//�ͻ�ѯ�۵�
			{
				csth.TableName = "sale_ce_master";
				csth.PrimaryKeyField = "ce_code";
				csth.PrimaryKeyValue = this.comboBox2.SelectedValue.ToString();;
				csth.PrimaryKeyNewValue = this.textBox1.Text.Trim();
				ret = csth.SubTableInsert();
				ShowErrInfo(ret,"�ͻ�ѯ�۵�");
				csth.TableName = "sale_ce_deatil";
				csth.PrimaryKeyField = "ce_code";
				csth.PrimaryKeyValue = this.comboBox2.SelectedValue.ToString();;
				csth.PrimaryKeyNewValue = this.textBox1.Text.Trim();
				ret = csth.SubTableInsert();
				ShowErrInfo(ret,"�ͻ�ѯ����ϸ��");
			}
			if(this.checkBox6.Checked)//���۵�
			{
				csth.TableName = "sale_cq_master";
				csth.PrimaryKeyField = "cq_code";
				csth.PrimaryKeyValue = this.comboBox2.SelectedValue.ToString();;
				csth.PrimaryKeyNewValue = this.textBox1.Text.Trim();
				ret = csth.SubTableInsert();
				ShowErrInfo(ret,"���۱��۵�");
				csth.TableName = "sale_cq_deatil";
				csth.PrimaryKeyField = "cq_code";
				csth.PrimaryKeyValue = this.comboBox2.SelectedValue.ToString();;
				csth.PrimaryKeyNewValue = this.textBox1.Text.Trim();
				ret = csth.SubTableInsert();
				ShowErrInfo(ret,"���۱�����ϸ��");
			}
			if(this.checkBox7.Checked)//���۶���
			{
				csth.TableName = "sale_so_master";
				csth.PrimaryKeyField = "so_code";
				csth.PrimaryKeyValue = this.comboBox2.SelectedValue.ToString();
				csth.PrimaryKeyNewValue = this.textBox1.Text.Trim();
				ret = csth.SubTableInsert();
				ShowErrInfo(ret,"���۶���");
				csth.TableName = "sale_so_detail";
				csth.PrimaryKeyField = "so_code";
				csth.PrimaryKeyValue = this.comboBox2.SelectedValue.ToString();;
				csth.PrimaryKeyNewValue = this.textBox1.Text.Trim();
				ret = csth.SubTableInsert();
				ShowErrInfo(ret,"������ϸ��");
			}
			if (this.checkBox9.Checked)//��֤
			{
				csth.TableName = "sale_doc_master";
				csth.PrimaryKeyField = "so_code";
				csth.PrimaryKeyValue = this.comboBox2.SelectedValue.ToString();
				csth.PrimaryKeyNewValue = this.textBox1.Text;
				csth.PrimaryKeyPField = "invoice_no";
				csth.PrimaryKeyPValue = this.comboBox2.SelectedValue.ToString();
				csth.PrimaryKeyPNewValue = this.textBox1.Text;
				ret = csth.ConectTableInsert();
				ShowErrInfo(ret,"��֤");
			}
			if (this.checkBox10.Checked)//�������˵�
			{
				csth.TableName = "SALE_WAYBILL_MASTER";
				csth.PrimaryKeyField = "INVOICE_NO";
				csth.PrimaryKeyValue = this.comboBox2.SelectedValue.ToString();
				csth.PrimaryKeyNewValue = this.textBox1.Text;
				csth.PrimaryKeyPField = "AWB_CODE";
				csth.PrimaryKeyPValue = this.comboBox2.SelectedValue.ToString();
				csth.PrimaryKeyPNewValue = this.textBox1.Text;
				ret = csth.ConectTableInsert();
				ShowErrInfo(ret,"�������˵�");
			}

			this.Close();
		}

		private void ShowErrInfo(int err,string doc)
		{
			string msg = null;
			switch(err)
			{
				case 0:
					msg = doc + "���Ƴɹ�����ȷ��";
					break;
				case 100:
					msg = "ԭ�����޶�Ӧ��" + doc +"����";
					break;
				case 200:
					msg = "�µ������Ѿ����ڸ�" + doc + "�ţ��޷������ͬ�ĵ��ţ����ʵ";
					break;
				case 10:
					msg = "δ��ѡ����Ҫ���Ƶĵ���";
					break;
				case 11:
					msg = "δָ����Ҫ���Ƶ�Ŀ�ĵ��ţ���ȷ���µ�����������е�������";
					break;
				default:
					msg = "�µ������ʧ�ܣ���ת����Ӧ�Ĺ��ܽ����ʵ";
					break;
			}

			if(err == 0)
			{
				TJSystem.Public.PublicStatic.ShowMessage(TJSystem.Public.MessageType.Information,msg);
				return;
			}
			TJSystem.Public.PublicStatic.ShowMessage(TJSystem.Public.MessageType.Exclamation,msg);
		}

		private void InitialTypeComboBox()
		{
			System.Data.DataRow dr = null;
			System.Data.DataTable dt = null;
			System.Data.DataTable dtcpy = null;
			
			dt = new System.Data.DataTable("DISPLAY");
			dt.Columns.Add("VALUE");
			dt.Columns.Add("DISPLAY");
			dr = dt.NewRow() ;
			dr[0] = "1" ;
			dr[1] = "�ɹ�ѯ�۵�" ;
			dt.Rows.InsertAt(dr,0) ;
			dr = dt.NewRow() ;
			dr[0] = "2" ;
			dr[1] = "��Ӧ�̱��۵�" ;
			dt.Rows.InsertAt(dr,0) ;
			dr = dt.NewRow() ;
			dr[0] = "3" ;
			dr[1] = "�ɹ�����" ;
			dt.Rows.InsertAt(dr,0) ;
			dr = dt.NewRow() ;
			dr[0] = "4" ;
			dr[1] = "�ͻ�ѯ�۵�" ;
			dt.Rows.InsertAt(dr,0) ;
			dr = dt.NewRow() ;
			dr[0] = "5" ;
			dr[1] = "���۵�" ;
			dt.Rows.InsertAt(dr,0) ;
			dr = dt.NewRow() ;
			dr[0] = "6" ;
			dr[1] = "���۶���" ;
			dt.Rows.InsertAt(dr,0) ;
			dr = dt.NewRow() ;
			dr[0] = "0" ;
			dr[1] = "" ;
			dt.Rows.InsertAt(dr,0) ;
			dtcpy = dt.Copy();
			this.comboBox1.DataSource = dtcpy.DefaultView;
			this.comboBox1.ValueMember = "VALUE";
			this.comboBox1.DisplayMember = "DISPLAY";
		}

		private void comboBox1_SelectionChangeCommitted(object sender, System.EventArgs e)
		{
			string table = null;
			string Key = null;
			switch(this.comboBox1.SelectedValue.ToString())
			{
				case "1":
					table = "purchase_se_master";
					Key = "se_code";
					break;
				case "2":
					table = "purchase_sq_master";
					Key = "sq_code";
					break;
				case "3":
					table = "purchase_po_master";
					Key = "po_code";
					break;
				case "4":
					table = "sale_ce_master";
					Key = "ce_code";
					break;
				case "5":
					table = "sale_cq_master";
					Key = "cq_code";
					break;
				case "6":
					table = "sale_so_master";
					Key = "so_code";
					break;
				default:
					break;
			}

			InitialNoComboBox(table,Key);
		}

		private void InitialNoComboBox(string table,string Key)
		{
			System.Data.DataRow dr = null;
			System.Data.DataTable dt = null;
			System.Data.DataTable dtcpy = null;
			string sql = null;
			if (table == null || Key == null)
			{
				return;
			}
			sql += "select ";
			sql += Key;
			sql += " as ValueMember,";
			sql += Key;
			sql += " as DisplayMember from ";
			sql += table;
			sql += " order by ";
			sql += Key;
			dt = TJSystem.Public.PublicStatic.db.GetDataTable(sql);
			dr = dt.NewRow() ;
			dr[0] = "" ;
			dr[1] = "" ;
			dt.Rows.InsertAt(dr,0) ;
			dtcpy = dt.Copy();
			this.comboBox2.DataSource = dtcpy.DefaultView;
			this.comboBox2.ValueMember = "ValueMember";
			this.comboBox2.DisplayMember = "DisplayMember";
		}

	}
}

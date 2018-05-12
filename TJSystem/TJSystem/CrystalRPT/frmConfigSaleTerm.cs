using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace TJSystem.CrystalRPT
{
	/// <summary>
	/// frmConfigSaleTerm ��ժҪ˵����
	/// </summary>
	public class frmConfigSaleTerm : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label label1;
		/// <summary>
		/// ����������������
		/// </summary>
		private System.ComponentModel.Container components = null;
		private System.Windows.Forms.Label label2;
		private TJSystem.CrystalRPT.CommonConfig cfg = null;

		public frmConfigSaleTerm(TJSystem.CrystalRPT.CommonConfig cfg)
		{
			//
			// Windows ���������֧���������
			//
			InitializeComponent();
			this.cfg = cfg;

			//
			// TODO: �� InitializeComponent ���ú�����κι��캯������
			//
		}

		/// <summary>
		/// ������������ʹ�õ���Դ��
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

		#region Windows ������������ɵĴ���
		/// <summary>
		/// �����֧������ķ��� - ��Ҫʹ�ô���༭���޸�
		/// �˷��������ݡ�
		/// </summary>
		private void InitializeComponent()
		{
			this.button1 = new System.Windows.Forms.Button();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(112, 104);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(96, 23);
			this.button1.TabIndex = 0;
			this.button1.Text = "ȷ��";
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(80, 64);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(184, 21);
			this.textBox1.TabIndex = 1;
			this.textBox1.Text = "";
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(16, 64);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(56, 23);
			this.label1.TabIndex = 2;
			this.label1.Text = "�ҷ�";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("����", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.label2.Location = new System.Drawing.Point(80, 16);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(184, 23);
			this.label2.TabIndex = 2;
			this.label2.Text = "����";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// frmConfigSaleTerm
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(314, 152);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.label2);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Name = "frmConfigSaleTerm";
			this.Text = "Config";
			this.ResumeLayout(false);

		}
		#endregion

		private void button1_Click(object sender, System.EventArgs e)
		{
			cfg.CfgSaleTermBuyFrom = this.textBox1.Text.Trim();
			this.Close();
		}
	}
}

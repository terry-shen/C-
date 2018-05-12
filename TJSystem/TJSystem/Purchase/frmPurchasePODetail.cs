using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace TJSystem.Purchase
{
	/// <summary>
	/// Form1 的摘要说明。
	/// </summary>
	public class frmPurchasePODetail : System.Windows.Forms.Form
	{
		
		
		/// <summary>
		/// 必需的设计器变量。
		/// </summary>
		private System.ComponentModel.Container components = null;
		private System.Windows.Forms.DataGridTextBoxColumn fax1;
		private System.Windows.Forms.DataGridTextBoxColumn email2;
		private System.Windows.Forms.DataGridTextBoxColumn address_cn;
		private System.Windows.Forms.DataGridTextBoxColumn company_name;
		private System.Windows.Forms.DataGridTextBoxColumn company_name_cn;
		private System.Windows.Forms.DataGridTextBoxColumn email1;
		private System.Windows.Forms.DataGridTextBoxColumn tel1;
		private System.Windows.Forms.DataGridTextBoxColumn createby;
		private System.Windows.Forms.DataGridTextBoxColumn resume;
		private System.Windows.Forms.DataGridTextBoxColumn gen_manager;
		private System.Windows.Forms.Panel panel3;
		private TJSystem.UC.PriToolBar priToolBar1;
		private System.Windows.Forms.DataGridTextBoxColumn postcode;
		private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn2;
		private System.Windows.Forms.DataGridTextBoxColumn address;
		private System.Windows.Forms.DataGridTextBoxColumn corporation;
		private System.Windows.Forms.DataGridTextBoxColumn company_id;
		private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn1;
		private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn4;
		private System.Windows.Forms.DataGridTextBoxColumn modifyon;
		private System.Windows.Forms.DataGridTextBoxColumn createon;
		private System.Windows.Forms.DataGridTextBoxColumn modifyby;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.DataGrid dataGrid1;
		private System.Windows.Forms.Panel panel4;
		private System.Windows.Forms.Label label32;
		private System.Windows.Forms.Label label16;
		private System.Windows.Forms.Label label18;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label3;
		private TJSystem.Classes.PriTextBox txt2;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label2;
		private TJSystem.Classes.PriTextBox txt1;
		private System.Windows.Forms.DataGridTextBoxColumn fax2;
		private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn3;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.DataGridTextBoxColumn website;
		private System.Windows.Forms.DataGridTextBoxColumn tel2;
		public static System.Windows.Forms.Form frmCurrent = null ;
		private TJSystem.Classes.PriComboBox priComboBox1;
		public string _PK;
		private System.Windows.Forms.LinkLabel lk_detail;
		private System.Windows.Forms.DataGridTableStyle dataGridTableStyle1;
		private System.Windows.Forms.DataGridTextBoxColumn remark;
		private string _statusType = null;
		public static int Count = 0;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.Label label17;
		private System.Windows.Forms.Label label4;
		private TJSystem.Classes.PriTextBox txt4;
		private TJSystem.Classes.PriTextBox txt6;
		private TJSystem.Classes.PriTextBox txt5;
		private TJSystem.Classes.PriTextBox txt3;
		private System.Windows.Forms.DataGridTextBoxColumn seq_no;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.DataGridTextBoxColumn item_code;
		private System.Windows.Forms.DataGridTextBoxColumn item_name;
		private System.Windows.Forms.DataGridTextBoxColumn item_name_cn;
		private System.Windows.Forms.DataGridTextBoxColumn item_desc;
		private System.Windows.Forms.DataGridTextBoxColumn item_desc_cn;
		private System.Windows.Forms.DataGridTextBoxColumn item_qty;
		private System.Windows.Forms.DataGridTextBoxColumn unit_price;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label19;
		private System.Windows.Forms.Label label20;
		private System.Windows.Forms.Label label21;
		private System.Windows.Forms.Label label22;
		private TJSystem.Classes.PriComboBox priComboBox5;
		private TJSystem.Classes.PriComboBox priComboBox2;
		private TJSystem.Classes.PriTextBox txt9;
		private TJSystem.Classes.PriTextBox txt8;
		private TJSystem.Classes.PriTextBox txt7;
		private TJSystem.Classes.PriTextBox txt15;
		private TJSystem.Classes.PriTextBox txt10;
		private TJSystem.Classes.PriTextBox txt11;
		private TJSystem.Classes.PriTextBox txt12;
		private TJSystem.Classes.PriTextBox txt13;
		private TJSystem.Classes.PriComboBox priComboBox4;
		private TJSystem.Classes.PriComboBox priComboBox6;
		private TJSystem.Classes.PriComboBox priComboBox3;
		private TJSystem.Classes.PriTextBox txt16;
		private System.Windows.Forms.DataGridTextBoxColumn po_code;
		private System.Windows.Forms.DataGridTextBoxColumn discountPer;
		private System.Windows.Forms.DataGridTextBoxColumn Amount;
		private System.Windows.Forms.DataGridTextBoxColumn taxRate;
		private System.Windows.Forms.DataGridTextBoxColumn fact_amount;
		private System.Windows.Forms.DataGridTextBoxColumn deliveryDate;
		private System.Windows.Forms.DataGridTextBoxColumn client_orderno;
		private TJSystem.Classes.PriDateTimePicker priDateTimePicker3;
		private System.Windows.Forms.DataGridTextBoxColumn paymentType_name;
		private System.Windows.Forms.DataGridTextBoxColumn pack_type_name;
		private System.Windows.Forms.DataGridTextBoxColumn outsiePackType_name;
		private System.Windows.Forms.DataGridTextBoxColumn insidePackType_name;
		private System.Windows.Forms.DataGridTextBoxColumn unit;
		private System.Windows.Forms.DataGridTextBoxColumn sq_code;
		private string _Purchase_PO_Code = null;
		public frmPurchasePODetail(string purchase_PO_code)
		{
			//
			// Windows 窗体设计器支持所必需的
			//
			InitializeComponent();
			this._Purchase_PO_Code = purchase_PO_code;
			this.txt1.Text = _Purchase_PO_Code;

			

			_statusType = "purchase";

			InitialFormData();

			System.Text.StringBuilder sb = new System.Text.StringBuilder();
			sb.Append("select a.po_code,a.sq_code,a.seq_no,a.so_code,a.item_code,a.item_name,a.item_name_cn,a.item_desc,a.item_desc_cn, a.paymentType,c.paymode_name_cn as paymentType_name,a.item_Qty,b.unit_name_cn as unit,");
			sb.Append("a.unit_price,a.unit,a.discountPer,a.Amount,a.taxRate,a.fact_amount,a.pack_type,d.pack_method_name as pack_type_name,a.deliverydate,a.outsiePackType,e.pack_namecn as outsiePackType_name, a.insidePackType,f.pack_namecn as insidePackType_name,a.client_orderNo,a.remark ");
			sb.Append("from purchase_po_detail a ");
			sb.Append("left join p_unit b ");
			sb.Append("on a.unit = b.unit_id ");
			sb.Append("left join p_paymode c ");
			sb.Append("on a.paymentType = c.paymode_id ");
			sb.Append("left join p_packmethod d ");
			sb.Append(" on a.pack_type = d.pack_method_id ");
			sb.Append(" left join p_packType e ");
			sb.Append(" on a.outsiePackType = e.pack_code ");
			sb.Append(" left join p_packType f ");
			sb.Append(" on a.insidePackType = f.pack_code ");
			sb.Append("where po_code = '"+ this.txt1.Text +"'");
			sb.Append("order by po_code,seq_no");
			this.InitialGrid(sb.ToString());

			priToolBar1.setCurrentForm = this;
			_PK = "po_code,seq_no";
			priToolBar1.Initial("purchase_po_detail",_PK,sb.ToString());

			priToolBar1.BeforeButtonClickEvent += new TJSystem.UC.PriToolBar.BeforeButotnClick(this.BeforeButtonClick);
			priToolBar1.AfterButtonClickEvent += new TJSystem.UC.PriToolBar.AfterButtonClick(this.AfterButtonClick);

			this.priToolBar1.setButtonVisibleFalse();;
			this.priToolBar1.setButtonVisible("012345689");
			setDisable();
			//
			// TODO: 在 InitializeComponent 调用后添加任何构造函数代码
			//
		}

		private void InitialFormData()
		{
			DataTable dtcpy = null;
			DataRow dr = null;
			//销售订单
			string sql = "select sq_code,sq_code+' '+supplier_name as supplier_name from purchase_sq_master order by sq_code";
			DataTable dt = TJSystem.Public.PublicStatic.db.GetDataTable(sql);
			dr = dt.NewRow() ;
			dr[0] = "" ;
			dr[1] = "" ;
			dt.Rows.InsertAt(dr,0) ;
			dtcpy = dt.Copy();
			this.priComboBox1.DataSource = dtcpy.DefaultView;
			this.priComboBox1.ValueMember = "sq_code";
			this.priComboBox1.DisplayMember = "supplier_name";

			//货品编号
			sql = "select item_code,item_code+' '+item_name_cn as item_namecn from basic_item order by item_code";
		    dt = TJSystem.Public.PublicStatic.db.GetDataTable(sql);
			dr = dt.NewRow() ;
			dr[0] = "" ;
			dr[1] = "" ;
			dt.Rows.InsertAt(dr,0) ;
			dtcpy = dt.Copy();
			this.priComboBox2.DataSource = dtcpy.DefaultView;
			this.priComboBox2.ValueMember = "item_code";
			this.priComboBox2.DisplayMember = "item_namecn";

			//付款方式
			sql = "select paymode_id,paymode_id+' '+paymode_name_cn as paymode_name_cn from p_paymode order by paymode_id";
			dt = TJSystem.Public.PublicStatic.db.GetDataTable(sql);
			dr = dt.NewRow() ;
			dr[0] = "" ;
			dr[1] = "" ;
			dt.Rows.InsertAt(dr,0) ;
			dtcpy = dt.Copy();
			this.priComboBox3.DataSource = dtcpy.DefaultView;
			this.priComboBox3.ValueMember = "paymode_id";
			this.priComboBox3.DisplayMember = "paymode_name_cn";

			//包装方式
			sql = "select pack_method_id,pack_method_id+' '+pack_method_name as pack_method_name from p_packmethod order by pack_method_id";
			dt = TJSystem.Public.PublicStatic.db.GetDataTable(sql);
			dr = dt.NewRow() ;
			dr[0] = "" ;
			dr[1] = "" ;
			dt.Rows.InsertAt(dr,0) ;
			dtcpy = dt.Copy();
			this.priComboBox4.DataSource = dtcpy.DefaultView;
			this.priComboBox4.ValueMember = "pack_method_id";
			this.priComboBox4.DisplayMember = "pack_method_name";

			//外包类型
			sql = "select pack_code,pack_code+' '+pack_namecn as pack_namecn from p_packtype order by pack_code";
			dt = TJSystem.Public.PublicStatic.db.GetDataTable(sql);
			dr = dt.NewRow() ;
			dr[0] = "" ;
			dr[1] = "" ;
			dt.Rows.InsertAt(dr,0) ;
			dtcpy = dt.Copy();
			this.priComboBox5.DataSource = dtcpy.DefaultView;
			this.priComboBox5.ValueMember = "pack_code";
			this.priComboBox5.DisplayMember = "pack_namecn";


			//外包类型
			sql = "select pack_code,pack_code+' '+pack_namecn as pack_namecn from p_packtype order by pack_code";
			dt = TJSystem.Public.PublicStatic.db.GetDataTable(sql);
			dr = dt.NewRow() ;
			dr[0] = "" ;
			dr[1] = "" ;
			dt.Rows.InsertAt(dr,0) ;
			dtcpy = dt.Copy();
			this.priComboBox6.DataSource = dtcpy.DefaultView;
			this.priComboBox6.ValueMember = "pack_code";
			this.priComboBox6.DisplayMember = "pack_namecn";
		}

		private bool BeforeButtonClick(string sqltype)
		{
			System.Text.StringBuilder sb = new System.Text.StringBuilder();
			sb.Append("数据验证错误：\r\n");
			if(sqltype.Equals("default"))
			{
				this.setDisable();
			}
			if(sqltype.Equals("insert"))
			{
				if(!checkFormValue(sqltype,sb))
				{
					//MessageBox.Show(sb.ToString(),"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);// del by chenchong
					return false;
				}
			}
			return true;
		}


		private bool checkFormValue(string sqltype,System.Text.StringBuilder sb)
		{
			DataSet ds = new DataSet();
			System.Text.StringBuilder sb1 = new System.Text.StringBuilder();
			sb1.Append("select po_code from purchase_po_detail ");
			sb1.Append("where po_code = '"+ this.txt1.Text.ToString().Trim() +"'");
			sb1.Append(" and item_code = '"+this.priComboBox2.SelectedValue.ToString().Trim()+"'");
			ds = TJSystem.Public.PublicStatic.db.GetDataSet(sb1.ToString());

			if(sqltype.Equals("insert"))
			{
				if(txt1.Text.Length > 10)
				{
					sb.Append("  数据长度超出数据库定义要求\r\n");
					return false;
				}

				if (this.txt1.Text == "")
				{
					MessageBox.Show("请输入采购订单号","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
					return false;
				}
				
				if(ds.Tables[0].Rows.Count.Equals(1))
				{
					MessageBox.Show("这个货品已经输入","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
					return false;
				}

                //CHECK输入值的属性
                // add by chenchong
                if (!TJSystem.Public.PublicStatic.IsNumeric(this.txt2.Text))
                {
                    MessageBox.Show("货品序号必须为整数","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    return false;
                }

                if (this.txt7.Text.Equals(""))
                {
                    TJSystem.Public.PublicStatic.ShowMessage(TJSystem.Public.MessageType.Error, "请填写订单数量！");
                    return false;
                }

                if (!TJSystem.Public.PublicStatic.IsNumDouble(this.txt7.Text.Trim()))
                {
                    TJSystem.Public.PublicStatic.ShowMessage(TJSystem.Public.MessageType.Error, "订单数量必须为数字！");
                    return false;
                }

                if (this.txt11.Text.Equals(""))
                {
                    TJSystem.Public.PublicStatic.ShowMessage(TJSystem.Public.MessageType.Error, "请填写总金额！");
                    return false;
                }

                if (!TJSystem.Public.PublicStatic.IsNumDouble(this.txt11.Text.Trim()))
                {
                    TJSystem.Public.PublicStatic.ShowMessage(TJSystem.Public.MessageType.Error, "总金额必须为数字！");
                    return false;
                }

                if (!TJSystem.Public.PublicStatic.IsNumDouble(this.txt12.Text.Trim()))
                {
                    TJSystem.Public.PublicStatic.ShowMessage(TJSystem.Public.MessageType.Error, "税率必须为数字！");
                    return false;
                }

                if (this.txt15.Text.Equals(""))
                {
                    TJSystem.Public.PublicStatic.ShowMessage(TJSystem.Public.MessageType.Error, "请填写客户订单号！");
                    return false;
                }

                if (!TJSystem.Public.PublicStatic.IsNumDouble(this.txt15.Text.Trim()))
                {
                    TJSystem.Public.PublicStatic.ShowMessage(TJSystem.Public.MessageType.Error, "客户订单号必须为数字！");
                    return false;
                }
                // add end
			}	
			return true;
		}


		private void setDisable()
		{
			this.txt1.Enabled = false;
			this.txt2.Enabled = false;
			this.txt3.Enabled = false;
			this.txt4.Enabled = false;
			this.txt5.Enabled = false;
			this.txt6.Enabled = false;
			this.txt7.Enabled = false;
			this.txt8.Enabled = false;
			this.txt9.Enabled = false;
			this.txt10.Enabled = false;
			this.txt11.Enabled = false;
			this.txt12.Enabled = false;
			this.txt13.Enabled = false;
			this.priDateTimePicker3.Enabled = false;
			this.txt15.Enabled = false;
			this.txt16.Enabled = false;
			this.priComboBox1.Enabled = false;
			this.priComboBox2.Enabled = false;
			this.priComboBox3.Enabled = false;
			this.priComboBox4.Enabled = false;
			this.priComboBox5.Enabled = false;
			this.priComboBox6.Enabled = false;
		}

		private void AfterButtonClick(string ButtonType)
		{
			if(ButtonType.Equals("insert"))
			{
                // del by chenchong
//				string sql = "select max(seq_no) as seq_no from purchase_po_detail where po_code = '"+ _Purchase_PO_Code +"'";
//				DataTable dt = TJSystem.Public.PublicStatic.db.GetDataTable(sql);
//				if(dt.Rows[0]["seq_no"].ToString().Trim()=="")
//				{
//					this.txt2.Text = "1";
//				}
//				else
//				{
//					this.txt2.Text = Convert.ToString(Convert.ToInt32(dt.Rows[0]["seq_no"].ToString().Trim()) + 1);
//				}
                // del end

                this.txt2.Enabled = true;  // add by chenchong
				this.txt7.Enabled = true;
				this.txt9.Enabled = true;
				this.txt10.Enabled = true;
				this.txt11.Enabled = true;
				this.txt12.Enabled = true;
				this.txt13.Enabled = true;
				this.priDateTimePicker3.Enabled = true;
				this.txt15.Enabled = true;
				this.priComboBox1.Enabled = true;
				this.priComboBox2.Enabled = true;
				this.priComboBox3.Enabled = true;
				this.priComboBox4.Enabled = true;
				this.priComboBox5.Enabled = true;
				this.priComboBox6.Enabled = true;

                this.txt2.Text = "";  // add by chenchong
				this.txt3.Text = "";
				this.txt4.Text = "";
				this.txt5.Text = "";
				this.txt6.Text = "";
				this.txt7.Text = "0";
				this.txt8.Text = "";
				this.txt9.Text = "0";
				this.txt10.Text = "0";
				this.txt11.Text = "0";
				this.txt12.Text = "0";
				this.txt13.Text = "0";
				this.priDateTimePicker3.Value = System.DateTime.Now;
				this.txt15.Text = "";
				this.txt16.Text = "";
			}
			else if(ButtonType.Equals("update"))
			{
				this.txt1.Enabled = false;
				this.txt2.Enabled = false;
				this.txt7.Enabled = true;
				this.txt9.Enabled = true;
				this.txt10.Enabled = true;
				this.txt11.Enabled = true;
				this.txt12.Enabled = true;
				this.txt13.Enabled = true;
				this.priDateTimePicker3.Enabled = true;
				this.txt15.Enabled = true;
				this.priComboBox1.Enabled = true;
				this.priComboBox2.Enabled = true;
				this.priComboBox3.Enabled = true;
				this.priComboBox4.Enabled = true;
				this.priComboBox5.Enabled = true;
				this.priComboBox6.Enabled = true;

				if(this.txt7.Text.Trim().Equals(""))
				{
					this.txt7.Text = "0";
				}
				if(this.txt9.Text.Trim().Equals(""))
				{
					this.txt9.Text = "0";
				}
				if(this.txt10.Text.Trim().Equals(""))
				{
					this.txt10.Text = "0";
				}
				if(this.txt11.Text.Trim().Equals(""))
				{
					this.txt11.Text = "0";
				}
				if(this.txt12.Text.Trim().Equals(""))
				{
					this.txt12.Text = "0";
				}
				if(this.txt13.Text.Trim().Equals(""))
				{
					this.txt13.Text = "0";
				}

			}
		}

		private void InitialGrid(string sql)
		{		
			DataTable dt = TJSystem.Public.PublicStatic.db.GetDataTable(sql);
			dt.TableName = "purchase_po_detail";
			this.dataGrid1.DataSource = dt.DefaultView;
		}

//		private void InitialGrid1(string sql)
//		{		
//			DataTable dt = TJSystem.Public.PublicStatic.db.GetDataTable(sql);
//			dt.TableName = "sale_so_deatil";
//			this.dataGrid2.DataSource = dt.DefaultView;
//		}

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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(frmPurchasePODetail));
			this.fax1 = new System.Windows.Forms.DataGridTextBoxColumn();
			this.email2 = new System.Windows.Forms.DataGridTextBoxColumn();
			this.address_cn = new System.Windows.Forms.DataGridTextBoxColumn();
			this.company_name = new System.Windows.Forms.DataGridTextBoxColumn();
			this.company_name_cn = new System.Windows.Forms.DataGridTextBoxColumn();
			this.email1 = new System.Windows.Forms.DataGridTextBoxColumn();
			this.tel1 = new System.Windows.Forms.DataGridTextBoxColumn();
			this.createby = new System.Windows.Forms.DataGridTextBoxColumn();
			this.resume = new System.Windows.Forms.DataGridTextBoxColumn();
			this.gen_manager = new System.Windows.Forms.DataGridTextBoxColumn();
			this.panel3 = new System.Windows.Forms.Panel();
			this.priToolBar1 = new TJSystem.UC.PriToolBar();
			this.postcode = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumn2 = new System.Windows.Forms.DataGridTextBoxColumn();
			this.address = new System.Windows.Forms.DataGridTextBoxColumn();
			this.corporation = new System.Windows.Forms.DataGridTextBoxColumn();
			this.company_id = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumn1 = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumn4 = new System.Windows.Forms.DataGridTextBoxColumn();
			this.modifyon = new System.Windows.Forms.DataGridTextBoxColumn();
			this.createon = new System.Windows.Forms.DataGridTextBoxColumn();
			this.modifyby = new System.Windows.Forms.DataGridTextBoxColumn();
			this.panel2 = new System.Windows.Forms.Panel();
			this.dataGrid1 = new System.Windows.Forms.DataGrid();
			this.dataGridTableStyle1 = new System.Windows.Forms.DataGridTableStyle();
			this.po_code = new System.Windows.Forms.DataGridTextBoxColumn();
			this.seq_no = new System.Windows.Forms.DataGridTextBoxColumn();
			this.sq_code = new System.Windows.Forms.DataGridTextBoxColumn();
			this.item_code = new System.Windows.Forms.DataGridTextBoxColumn();
			this.item_name = new System.Windows.Forms.DataGridTextBoxColumn();
			this.item_name_cn = new System.Windows.Forms.DataGridTextBoxColumn();
			this.item_desc = new System.Windows.Forms.DataGridTextBoxColumn();
			this.item_desc_cn = new System.Windows.Forms.DataGridTextBoxColumn();
			this.paymentType_name = new System.Windows.Forms.DataGridTextBoxColumn();
			this.item_qty = new System.Windows.Forms.DataGridTextBoxColumn();
			this.unit = new System.Windows.Forms.DataGridTextBoxColumn();
			this.unit_price = new System.Windows.Forms.DataGridTextBoxColumn();
			this.discountPer = new System.Windows.Forms.DataGridTextBoxColumn();
			this.Amount = new System.Windows.Forms.DataGridTextBoxColumn();
			this.taxRate = new System.Windows.Forms.DataGridTextBoxColumn();
			this.fact_amount = new System.Windows.Forms.DataGridTextBoxColumn();
			this.pack_type_name = new System.Windows.Forms.DataGridTextBoxColumn();
			this.deliveryDate = new System.Windows.Forms.DataGridTextBoxColumn();
			this.outsiePackType_name = new System.Windows.Forms.DataGridTextBoxColumn();
			this.insidePackType_name = new System.Windows.Forms.DataGridTextBoxColumn();
			this.client_orderno = new System.Windows.Forms.DataGridTextBoxColumn();
			this.remark = new System.Windows.Forms.DataGridTextBoxColumn();
			this.panel4 = new System.Windows.Forms.Panel();
			this.priDateTimePicker3 = new TJSystem.Classes.PriDateTimePicker();
			this.priComboBox3 = new TJSystem.Classes.PriComboBox();
			this.priComboBox6 = new TJSystem.Classes.PriComboBox();
			this.label22 = new System.Windows.Forms.Label();
			this.priComboBox4 = new TJSystem.Classes.PriComboBox();
			this.label21 = new System.Windows.Forms.Label();
			this.txt13 = new TJSystem.Classes.PriTextBox();
			this.label20 = new System.Windows.Forms.Label();
			this.txt12 = new TJSystem.Classes.PriTextBox();
			this.label19 = new System.Windows.Forms.Label();
			this.txt11 = new TJSystem.Classes.PriTextBox();
			this.label11 = new System.Windows.Forms.Label();
			this.txt10 = new TJSystem.Classes.PriTextBox();
			this.label10 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.priComboBox5 = new TJSystem.Classes.PriComboBox();
			this.priComboBox2 = new TJSystem.Classes.PriComboBox();
			this.label13 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.txt4 = new TJSystem.Classes.PriTextBox();
			this.txt9 = new TJSystem.Classes.PriTextBox();
			this.label17 = new System.Windows.Forms.Label();
			this.txt8 = new TJSystem.Classes.PriTextBox();
			this.label12 = new System.Windows.Forms.Label();
			this.txt7 = new TJSystem.Classes.PriTextBox();
			this.label14 = new System.Windows.Forms.Label();
			this.label15 = new System.Windows.Forms.Label();
			this.txt15 = new TJSystem.Classes.PriTextBox();
			this.txt6 = new TJSystem.Classes.PriTextBox();
			this.priComboBox1 = new TJSystem.Classes.PriComboBox();
			this.label32 = new System.Windows.Forms.Label();
			this.txt16 = new TJSystem.Classes.PriTextBox();
			this.label16 = new System.Windows.Forms.Label();
			this.label18 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.txt5 = new TJSystem.Classes.PriTextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.txt2 = new TJSystem.Classes.PriTextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.txt3 = new TJSystem.Classes.PriTextBox();
			this.txt1 = new TJSystem.Classes.PriTextBox();
			this.lk_detail = new System.Windows.Forms.LinkLabel();
			this.fax2 = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumn3 = new System.Windows.Forms.DataGridTextBoxColumn();
			this.panel1 = new System.Windows.Forms.Panel();
			this.label1 = new System.Windows.Forms.Label();
			this.website = new System.Windows.Forms.DataGridTextBoxColumn();
			this.tel2 = new System.Windows.Forms.DataGridTextBoxColumn();
			this.panel3.SuspendLayout();
			this.panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).BeginInit();
			this.panel4.SuspendLayout();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// fax1
			// 
			this.fax1.Format = "";
			this.fax1.FormatInfo = null;
			this.fax1.HeaderText = "传真1";
			this.fax1.MappingName = "fax1";
			this.fax1.NullText = "";
			this.fax1.Width = 75;
			// 
			// email2
			// 
			this.email2.Format = "";
			this.email2.FormatInfo = null;
			this.email2.HeaderText = "电子邮件2";
			this.email2.MappingName = "email2";
			this.email2.NullText = "";
			this.email2.Width = 75;
			// 
			// address_cn
			// 
			this.address_cn.Format = "";
			this.address_cn.FormatInfo = null;
			this.address_cn.HeaderText = "中文地址";
			this.address_cn.MappingName = "address_cn";
			this.address_cn.NullText = "";
			this.address_cn.Width = 75;
			// 
			// company_name
			// 
			this.company_name.Format = "";
			this.company_name.FormatInfo = null;
			this.company_name.HeaderText = "公司名称";
			this.company_name.MappingName = "company_name";
			this.company_name.NullText = "";
			this.company_name.Width = 75;
			// 
			// company_name_cn
			// 
			this.company_name_cn.Format = "";
			this.company_name_cn.FormatInfo = null;
			this.company_name_cn.HeaderText = "中文名称";
			this.company_name_cn.MappingName = "company_name_cn";
			this.company_name_cn.NullText = "";
			this.company_name_cn.Width = 75;
			// 
			// email1
			// 
			this.email1.Format = "";
			this.email1.FormatInfo = null;
			this.email1.HeaderText = "电子邮件1";
			this.email1.MappingName = "email1";
			this.email1.NullText = "";
			this.email1.Width = 75;
			// 
			// tel1
			// 
			this.tel1.Format = "";
			this.tel1.FormatInfo = null;
			this.tel1.HeaderText = "电话1";
			this.tel1.MappingName = "tel1";
			this.tel1.NullText = "";
			this.tel1.Width = 75;
			// 
			// createby
			// 
			this.createby.Format = "";
			this.createby.FormatInfo = null;
			this.createby.HeaderText = "建立者";
			this.createby.MappingName = "createby";
			this.createby.NullText = "";
			this.createby.Width = 75;
			// 
			// resume
			// 
			this.resume.Format = "";
			this.resume.FormatInfo = null;
			this.resume.HeaderText = "公司描述";
			this.resume.MappingName = "resume";
			this.resume.NullText = "";
			this.resume.Width = 75;
			// 
			// gen_manager
			// 
			this.gen_manager.Format = "";
			this.gen_manager.FormatInfo = null;
			this.gen_manager.HeaderText = "总经理";
			this.gen_manager.MappingName = "gen_manager";
			this.gen_manager.NullText = "";
			this.gen_manager.Width = 75;
			// 
			// panel3
			// 
			this.panel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel3.BackgroundImage")));
			this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.panel3.Controls.Add(this.priToolBar1);
			this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panel3.Location = new System.Drawing.Point(0, 526);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(784, 40);
			this.panel3.TabIndex = 18;
			// 
			// priToolBar1
			// 
			this.priToolBar1.DGEnable = true;
			this.priToolBar1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.priToolBar1.Location = new System.Drawing.Point(0, -4);
			this.priToolBar1.Name = "priToolBar1";
			this.priToolBar1.setCurrentForm = null;
			this.priToolBar1.Size = new System.Drawing.Size(780, 40);
			this.priToolBar1.TabIndex = 0;
			// 
			// postcode
			// 
			this.postcode.Format = "";
			this.postcode.FormatInfo = null;
			this.postcode.HeaderText = "邮政编码";
			this.postcode.MappingName = "postcode";
			this.postcode.NullText = "";
			this.postcode.Width = 75;
			// 
			// dataGridTextBoxColumn2
			// 
			this.dataGridTextBoxColumn2.Format = "";
			this.dataGridTextBoxColumn2.FormatInfo = null;
			this.dataGridTextBoxColumn2.HeaderText = "员工姓名";
			this.dataGridTextBoxColumn2.MappingName = "";
			this.dataGridTextBoxColumn2.NullText = "";
			this.dataGridTextBoxColumn2.Width = 75;
			// 
			// address
			// 
			this.address.Format = "";
			this.address.FormatInfo = null;
			this.address.HeaderText = "地址";
			this.address.MappingName = "address";
			this.address.NullText = "";
			this.address.Width = 75;
			// 
			// corporation
			// 
			this.corporation.Format = "";
			this.corporation.FormatInfo = null;
			this.corporation.HeaderText = "公司法人";
			this.corporation.MappingName = "corporation";
			this.corporation.NullText = "";
			this.corporation.Width = 75;
			// 
			// company_id
			// 
			this.company_id.Format = "";
			this.company_id.FormatInfo = null;
			this.company_id.HeaderText = "公司编号";
			this.company_id.MappingName = "company_id";
			this.company_id.NullText = "";
			this.company_id.Width = 75;
			// 
			// dataGridTextBoxColumn1
			// 
			this.dataGridTextBoxColumn1.Format = "";
			this.dataGridTextBoxColumn1.FormatInfo = null;
			this.dataGridTextBoxColumn1.HeaderText = "员工编号";
			this.dataGridTextBoxColumn1.MappingName = "employee_id";
			this.dataGridTextBoxColumn1.NullText = "";
			this.dataGridTextBoxColumn1.Width = 75;
			// 
			// dataGridTextBoxColumn4
			// 
			this.dataGridTextBoxColumn4.Format = "";
			this.dataGridTextBoxColumn4.FormatInfo = null;
			this.dataGridTextBoxColumn4.HeaderText = "性别";
			this.dataGridTextBoxColumn4.MappingName = "Gender";
			this.dataGridTextBoxColumn4.NullText = "";
			this.dataGridTextBoxColumn4.Width = 75;
			// 
			// modifyon
			// 
			this.modifyon.Format = "";
			this.modifyon.FormatInfo = null;
			this.modifyon.HeaderText = "最后修改时间";
			this.modifyon.MappingName = "modifyon";
			this.modifyon.NullText = "";
			this.modifyon.Width = 75;
			// 
			// createon
			// 
			this.createon.Format = "";
			this.createon.FormatInfo = null;
			this.createon.HeaderText = "建立时间";
			this.createon.MappingName = "createon";
			this.createon.NullText = "";
			this.createon.Width = 75;
			// 
			// modifyby
			// 
			this.modifyby.Format = "";
			this.modifyby.FormatInfo = null;
			this.modifyby.HeaderText = "最后修改者";
			this.modifyby.MappingName = "modifyby";
			this.modifyby.NullText = "";
			this.modifyby.Width = 75;
			// 
			// panel2
			// 
			this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
			this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.panel2.Controls.Add(this.dataGrid1);
			this.panel2.Controls.Add(this.panel4);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel2.Location = new System.Drawing.Point(0, 48);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(784, 518);
			this.panel2.TabIndex = 17;
			// 
			// dataGrid1
			// 
			this.dataGrid1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.dataGrid1.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.dataGrid1.CaptionBackColor = System.Drawing.SystemColors.ActiveBorder;
			this.dataGrid1.CaptionText = "采购订单明细";
			this.dataGrid1.DataMember = "";
			this.dataGrid1.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.dataGrid1.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.dataGrid1.Location = new System.Drawing.Point(0, 232);
			this.dataGrid1.Name = "dataGrid1";
			this.dataGrid1.ReadOnly = true;
			this.dataGrid1.Size = new System.Drawing.Size(776, 240);
			this.dataGrid1.TabIndex = 1;
			this.dataGrid1.TableStyles.AddRange(new System.Windows.Forms.DataGridTableStyle[] {
																								  this.dataGridTableStyle1});
			// 
			// dataGridTableStyle1
			// 
			this.dataGridTableStyle1.DataGrid = this.dataGrid1;
			this.dataGridTableStyle1.GridColumnStyles.AddRange(new System.Windows.Forms.DataGridColumnStyle[] {
																												  this.po_code,
																												  this.seq_no,
																												  this.sq_code,
																												  this.item_code,
																												  this.item_name,
																												  this.item_name_cn,
																												  this.item_desc,
																												  this.item_desc_cn,
																												  this.paymentType_name,
																												  this.item_qty,
																												  this.unit,
																												  this.unit_price,
																												  this.discountPer,
																												  this.Amount,
																												  this.taxRate,
																												  this.fact_amount,
																												  this.pack_type_name,
																												  this.deliveryDate,
																												  this.outsiePackType_name,
																												  this.insidePackType_name,
																												  this.client_orderno,
																												  this.remark});
			this.dataGridTableStyle1.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.dataGridTableStyle1.MappingName = "purchase_po_detail";
			// 
			// po_code
			// 
			this.po_code.Format = "";
			this.po_code.FormatInfo = null;
			this.po_code.HeaderText = "采购订单号";
			this.po_code.MappingName = "po_code";
			this.po_code.NullText = "";
			this.po_code.Width = 75;
			// 
			// seq_no
			// 
			this.seq_no.Format = "";
			this.seq_no.FormatInfo = null;
			this.seq_no.HeaderText = "货品序号";
			this.seq_no.MappingName = "seq_no";
			this.seq_no.NullText = "";
			this.seq_no.Width = 75;
			// 
			// sq_code
			// 
			this.sq_code.Format = "";
			this.sq_code.FormatInfo = null;
			this.sq_code.HeaderText = "报价单号";
			this.sq_code.MappingName = "sq_code";
			this.sq_code.NullText = "";
			this.sq_code.Width = 75;
			// 
			// item_code
			// 
			this.item_code.Format = "";
			this.item_code.FormatInfo = null;
			this.item_code.HeaderText = "货品编号";
			this.item_code.MappingName = "item_code";
			this.item_code.NullText = "";
			this.item_code.Width = 75;
			// 
			// item_name
			// 
			this.item_name.Format = "";
			this.item_name.FormatInfo = null;
			this.item_name.HeaderText = "货物名称";
			this.item_name.MappingName = "item_name";
			this.item_name.NullText = "";
			this.item_name.Width = 75;
			// 
			// item_name_cn
			// 
			this.item_name_cn.Format = "";
			this.item_name_cn.FormatInfo = null;
			this.item_name_cn.HeaderText = "货物中文名称";
			this.item_name_cn.MappingName = "item_name_cn";
			this.item_name_cn.NullText = "";
			this.item_name_cn.Width = 75;
			// 
			// item_desc
			// 
			this.item_desc.Format = "";
			this.item_desc.FormatInfo = null;
			this.item_desc.HeaderText = "货物规格";
			this.item_desc.MappingName = "item_desc";
			this.item_desc.NullText = "";
			this.item_desc.Width = 75;
			// 
			// item_desc_cn
			// 
			this.item_desc_cn.Format = "";
			this.item_desc_cn.FormatInfo = null;
			this.item_desc_cn.HeaderText = "货物中文规格";
			this.item_desc_cn.MappingName = "item_desc_cn";
			this.item_desc_cn.NullText = "";
			this.item_desc_cn.Width = 75;
			// 
			// paymentType_name
			// 
			this.paymentType_name.Format = "";
			this.paymentType_name.FormatInfo = null;
			this.paymentType_name.HeaderText = "付款类型";
			this.paymentType_name.MappingName = "paymentType_name";
			this.paymentType_name.NullText = "";
			this.paymentType_name.Width = 75;
			// 
			// item_qty
			// 
			this.item_qty.Format = "";
			this.item_qty.FormatInfo = null;
			this.item_qty.HeaderText = "订货数量";
			this.item_qty.MappingName = "item_qty";
			this.item_qty.NullText = "";
			this.item_qty.Width = 75;
			// 
			// unit
			// 
			this.unit.Format = "";
			this.unit.FormatInfo = null;
			this.unit.HeaderText = "单位";
			this.unit.MappingName = "unit";
			this.unit.NullText = "";
			this.unit.Width = 75;
			// 
			// unit_price
			// 
			this.unit_price.Format = "";
			this.unit_price.FormatInfo = null;
			this.unit_price.HeaderText = "单位价格";
			this.unit_price.MappingName = "unit_price";
			this.unit_price.NullText = "";
			this.unit_price.Width = 75;
			// 
			// discountPer
			// 
			this.discountPer.Format = "";
			this.discountPer.FormatInfo = null;
			this.discountPer.HeaderText = "单位价格折扣";
			this.discountPer.MappingName = "discountPer";
			this.discountPer.NullText = "";
			this.discountPer.Width = 75;
			// 
			// Amount
			// 
			this.Amount.Format = "";
			this.Amount.FormatInfo = null;
			this.Amount.HeaderText = "总金额";
			this.Amount.MappingName = "Amount";
			this.Amount.Width = 75;
			// 
			// taxRate
			// 
			this.taxRate.Format = "";
			this.taxRate.FormatInfo = null;
			this.taxRate.HeaderText = "税率";
			this.taxRate.MappingName = "taxRate";
			this.taxRate.Width = 75;
			// 
			// fact_amount
			// 
			this.fact_amount.Format = "";
			this.fact_amount.FormatInfo = null;
			this.fact_amount.HeaderText = "实际缴税金额";
			this.fact_amount.MappingName = "fact_amount";
			this.fact_amount.NullText = "";
			this.fact_amount.Width = 75;
			// 
			// pack_type_name
			// 
			this.pack_type_name.Format = "";
			this.pack_type_name.FormatInfo = null;
			this.pack_type_name.HeaderText = "包装方式";
			this.pack_type_name.MappingName = "pack_type_name";
			this.pack_type_name.NullText = "";
			this.pack_type_name.Width = 75;
			// 
			// deliveryDate
			// 
			this.deliveryDate.Format = "";
			this.deliveryDate.FormatInfo = null;
			this.deliveryDate.HeaderText = "送货日期";
			this.deliveryDate.MappingName = "deliveryDate";
			this.deliveryDate.NullText = "";
			this.deliveryDate.Width = 75;
			// 
			// outsiePackType_name
			// 
			this.outsiePackType_name.Format = "";
			this.outsiePackType_name.FormatInfo = null;
			this.outsiePackType_name.HeaderText = "外包类型";
			this.outsiePackType_name.MappingName = "outsiePackType_name";
			this.outsiePackType_name.NullText = "";
			this.outsiePackType_name.Width = 75;
			// 
			// insidePackType_name
			// 
			this.insidePackType_name.Format = "";
			this.insidePackType_name.FormatInfo = null;
			this.insidePackType_name.HeaderText = "内包类型";
			this.insidePackType_name.MappingName = "insidePackType_name";
			this.insidePackType_name.NullText = "";
			this.insidePackType_name.Width = 75;
			// 
			// client_orderno
			// 
			this.client_orderno.Format = "";
			this.client_orderno.FormatInfo = null;
			this.client_orderno.HeaderText = "客户订单号";
			this.client_orderno.MappingName = "client_orderno";
			this.client_orderno.NullText = "";
			this.client_orderno.Width = 75;
			// 
			// remark
			// 
			this.remark.Format = "";
			this.remark.FormatInfo = null;
			this.remark.HeaderText = "备注";
			this.remark.MappingName = "remark";
			this.remark.NullText = "";
			this.remark.Width = 75;
			// 
			// panel4
			// 
			this.panel4.BackColor = System.Drawing.SystemColors.ScrollBar;
			this.panel4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel4.BackgroundImage")));
			this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.panel4.Controls.Add(this.priDateTimePicker3);
			this.panel4.Controls.Add(this.priComboBox3);
			this.panel4.Controls.Add(this.priComboBox6);
			this.panel4.Controls.Add(this.label22);
			this.panel4.Controls.Add(this.priComboBox4);
			this.panel4.Controls.Add(this.label21);
			this.panel4.Controls.Add(this.txt13);
			this.panel4.Controls.Add(this.label20);
			this.panel4.Controls.Add(this.txt12);
			this.panel4.Controls.Add(this.label19);
			this.panel4.Controls.Add(this.txt11);
			this.panel4.Controls.Add(this.label11);
			this.panel4.Controls.Add(this.txt10);
			this.panel4.Controls.Add(this.label10);
			this.panel4.Controls.Add(this.label6);
			this.panel4.Controls.Add(this.priComboBox5);
			this.panel4.Controls.Add(this.priComboBox2);
			this.panel4.Controls.Add(this.label13);
			this.panel4.Controls.Add(this.label4);
			this.panel4.Controls.Add(this.txt4);
			this.panel4.Controls.Add(this.txt9);
			this.panel4.Controls.Add(this.label17);
			this.panel4.Controls.Add(this.txt8);
			this.panel4.Controls.Add(this.label12);
			this.panel4.Controls.Add(this.txt7);
			this.panel4.Controls.Add(this.label14);
			this.panel4.Controls.Add(this.label15);
			this.panel4.Controls.Add(this.txt15);
			this.panel4.Controls.Add(this.txt6);
			this.panel4.Controls.Add(this.priComboBox1);
			this.panel4.Controls.Add(this.label32);
			this.panel4.Controls.Add(this.txt16);
			this.panel4.Controls.Add(this.label16);
			this.panel4.Controls.Add(this.label18);
			this.panel4.Controls.Add(this.label9);
			this.panel4.Controls.Add(this.txt5);
			this.panel4.Controls.Add(this.label5);
			this.panel4.Controls.Add(this.label3);
			this.panel4.Controls.Add(this.txt2);
			this.panel4.Controls.Add(this.label8);
			this.panel4.Controls.Add(this.label7);
			this.panel4.Controls.Add(this.label2);
			this.panel4.Controls.Add(this.txt3);
			this.panel4.Controls.Add(this.txt1);
			this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel4.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.panel4.Location = new System.Drawing.Point(0, 0);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(780, 232);
			this.panel4.TabIndex = 0;
			// 
			// priDateTimePicker3
			// 
			this.priDateTimePicker3.CustomFormat = "yyyy-MM-dd";
			this.priDateTimePicker3.DataField = "deliverydate";
			this.priDateTimePicker3.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.priDateTimePicker3.Location = new System.Drawing.Point(568, 128);
			this.priDateTimePicker3.Name = "priDateTimePicker3";
			this.priDateTimePicker3.Size = new System.Drawing.Size(144, 23);
			this.priDateTimePicker3.TabIndex = 225;
			// 
			// priComboBox3
			// 
			this.priComboBox3.BackColor = System.Drawing.Color.White;
			this.priComboBox3.DataField = "paymentType";
			this.priComboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.priComboBox3.Location = new System.Drawing.Point(568, 56);
			this.priComboBox3.Name = "priComboBox3";
			this.priComboBox3.Size = new System.Drawing.Size(144, 22);
			this.priComboBox3.TabIndex = 224;
			// 
			// priComboBox6
			// 
			this.priComboBox6.BackColor = System.Drawing.Color.White;
			this.priComboBox6.DataField = "insidePackType";
			this.priComboBox6.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.priComboBox6.Location = new System.Drawing.Point(328, 152);
			this.priComboBox6.Name = "priComboBox6";
			this.priComboBox6.Size = new System.Drawing.Size(136, 22);
			this.priComboBox6.TabIndex = 223;
			// 
			// label22
			// 
			this.label22.BackColor = System.Drawing.Color.Transparent;
			this.label22.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.label22.ForeColor = System.Drawing.Color.Blue;
			this.label22.Location = new System.Drawing.Point(264, 152);
			this.label22.Name = "label22";
			this.label22.Size = new System.Drawing.Size(64, 23);
			this.label22.TabIndex = 222;
			this.label22.Text = "内包类型";
			this.label22.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// priComboBox4
			// 
			this.priComboBox4.BackColor = System.Drawing.Color.White;
			this.priComboBox4.DataField = "pack_type";
			this.priComboBox4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.priComboBox4.Location = new System.Drawing.Point(328, 128);
			this.priComboBox4.Name = "priComboBox4";
			this.priComboBox4.Size = new System.Drawing.Size(136, 22);
			this.priComboBox4.TabIndex = 221;
			// 
			// label21
			// 
			this.label21.BackColor = System.Drawing.Color.Transparent;
			this.label21.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.label21.ForeColor = System.Drawing.Color.Blue;
			this.label21.Location = new System.Drawing.Point(264, 128);
			this.label21.Name = "label21";
			this.label21.Size = new System.Drawing.Size(64, 23);
			this.label21.TabIndex = 220;
			this.label21.Text = "包装方式";
			this.label21.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txt13
			// 
			this.txt13.BackColor = System.Drawing.Color.Yellow;
			this.txt13.DataField = "fact_amount";
			this.txt13.DataType = TJSystem.Public.DataType.String;
			this.txt13.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.txt13.Location = new System.Drawing.Point(568, 104);
			this.txt13.Name = "txt13";
			this.txt13.Size = new System.Drawing.Size(144, 23);
			this.txt13.TabIndex = 219;
			this.txt13.Text = "";
			// 
			// label20
			// 
			this.label20.BackColor = System.Drawing.Color.Transparent;
			this.label20.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.label20.ForeColor = System.Drawing.Color.Blue;
			this.label20.Location = new System.Drawing.Point(472, 104);
			this.label20.Name = "label20";
			this.label20.Size = new System.Drawing.Size(96, 23);
			this.label20.TabIndex = 218;
			this.label20.Text = "实际缴税金额";
			this.label20.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txt12
			// 
			this.txt12.BackColor = System.Drawing.Color.Yellow;
			this.txt12.DataField = "taxRate";
			this.txt12.DataType = TJSystem.Public.DataType.String;
			this.txt12.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.txt12.Location = new System.Drawing.Point(328, 104);
			this.txt12.Name = "txt12";
			this.txt12.Size = new System.Drawing.Size(136, 23);
			this.txt12.TabIndex = 217;
			this.txt12.Text = "";
			// 
			// label19
			// 
			this.label19.BackColor = System.Drawing.Color.Transparent;
			this.label19.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.label19.Location = new System.Drawing.Point(264, 104);
			this.label19.Name = "label19";
			this.label19.Size = new System.Drawing.Size(64, 23);
			this.label19.TabIndex = 216;
			this.label19.Text = "税率";
			this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txt11
			// 
			this.txt11.BackColor = System.Drawing.Color.Yellow;
			this.txt11.DataField = "Amount";
			this.txt11.DataType = TJSystem.Public.DataType.String;
			this.txt11.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.txt11.Location = new System.Drawing.Point(96, 128);
			this.txt11.Name = "txt11";
			this.txt11.Size = new System.Drawing.Size(160, 23);
			this.txt11.TabIndex = 215;
			this.txt11.Text = "";
			// 
			// label11
			// 
			this.label11.BackColor = System.Drawing.Color.Transparent;
			this.label11.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.label11.Location = new System.Drawing.Point(32, 128);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(64, 23);
			this.label11.TabIndex = 214;
			this.label11.Text = "总金额";
			this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txt10
			// 
			this.txt10.BackColor = System.Drawing.Color.Yellow;
			this.txt10.DataField = "discountPer";
			this.txt10.DataType = TJSystem.Public.DataType.String;
			this.txt10.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.txt10.Location = new System.Drawing.Point(96, 104);
			this.txt10.Name = "txt10";
			this.txt10.Size = new System.Drawing.Size(160, 23);
			this.txt10.TabIndex = 213;
			this.txt10.Text = "";
			// 
			// label10
			// 
			this.label10.BackColor = System.Drawing.Color.Transparent;
			this.label10.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.label10.ForeColor = System.Drawing.Color.Blue;
			this.label10.Location = new System.Drawing.Point(-8, 104);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(96, 23);
			this.label10.TabIndex = 212;
			this.label10.Text = "单位价格折扣";
			this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label6
			// 
			this.label6.BackColor = System.Drawing.Color.Transparent;
			this.label6.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.label6.ForeColor = System.Drawing.Color.Blue;
			this.label6.Location = new System.Drawing.Point(496, 56);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(64, 23);
			this.label6.TabIndex = 210;
			this.label6.Text = "付款方式";
			this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// priComboBox5
			// 
			this.priComboBox5.BackColor = System.Drawing.Color.White;
			this.priComboBox5.DataField = "outsiePackType";
			this.priComboBox5.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.priComboBox5.Location = new System.Drawing.Point(96, 152);
			this.priComboBox5.Name = "priComboBox5";
			this.priComboBox5.Size = new System.Drawing.Size(160, 22);
			this.priComboBox5.TabIndex = 209;
			// 
			// priComboBox2
			// 
			this.priComboBox2.BackColor = System.Drawing.Color.White;
			this.priComboBox2.DataField = "item_code";
			this.priComboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.priComboBox2.Location = new System.Drawing.Point(96, 32);
			this.priComboBox2.Name = "priComboBox2";
			this.priComboBox2.Size = new System.Drawing.Size(160, 22);
			this.priComboBox2.TabIndex = 208;
			this.priComboBox2.SelectionChangeCommitted += new System.EventHandler(this.priComboBox2_SelectionChangeCommitted);
			// 
			// label13
			// 
			this.label13.BackColor = System.Drawing.Color.Transparent;
			this.label13.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.label13.ForeColor = System.Drawing.Color.Blue;
			this.label13.Location = new System.Drawing.Point(24, 32);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(64, 23);
			this.label13.TabIndex = 207;
			this.label13.Text = "货品编号";
			this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label4
			// 
			this.label4.BackColor = System.Drawing.Color.Transparent;
			this.label4.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.label4.Location = new System.Drawing.Point(472, 32);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(96, 23);
			this.label4.TabIndex = 203;
			this.label4.Text = "货物中文名称";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txt4
			// 
			this.txt4.BackColor = System.Drawing.Color.White;
			this.txt4.DataField = "item_name_cn";
			this.txt4.DataType = TJSystem.Public.DataType.String;
			this.txt4.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.txt4.Location = new System.Drawing.Point(568, 32);
			this.txt4.Name = "txt4";
			this.txt4.Size = new System.Drawing.Size(144, 23);
			this.txt4.TabIndex = 204;
			this.txt4.Text = "";
			// 
			// txt9
			// 
			this.txt9.BackColor = System.Drawing.Color.Yellow;
			this.txt9.DataField = "unit_price";
			this.txt9.DataType = TJSystem.Public.DataType.String;
			this.txt9.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.txt9.Location = new System.Drawing.Point(328, 80);
			this.txt9.Name = "txt9";
			this.txt9.Size = new System.Drawing.Size(136, 23);
			this.txt9.TabIndex = 200;
			this.txt9.Text = "";
			// 
			// label17
			// 
			this.label17.BackColor = System.Drawing.Color.Transparent;
			this.label17.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.label17.ForeColor = System.Drawing.Color.Blue;
			this.label17.Location = new System.Drawing.Point(264, 80);
			this.label17.Name = "label17";
			this.label17.Size = new System.Drawing.Size(64, 23);
			this.label17.TabIndex = 199;
			this.label17.Text = "单位价格";
			this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txt8
			// 
			this.txt8.BackColor = System.Drawing.Color.White;
			this.txt8.DataField = "unit";
			this.txt8.DataType = TJSystem.Public.DataType.String;
			this.txt8.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.txt8.Location = new System.Drawing.Point(568, 80);
			this.txt8.Name = "txt8";
			this.txt8.Size = new System.Drawing.Size(144, 23);
			this.txt8.TabIndex = 198;
			this.txt8.Text = "";
			// 
			// label12
			// 
			this.label12.BackColor = System.Drawing.Color.Transparent;
			this.label12.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.label12.ForeColor = System.Drawing.Color.Blue;
			this.label12.Location = new System.Drawing.Point(520, 80);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(40, 23);
			this.label12.TabIndex = 196;
			this.label12.Text = "单位";
			this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txt7
			// 
			this.txt7.BackColor = System.Drawing.Color.Yellow;
			this.txt7.DataField = "item_qty";
			this.txt7.DataType = TJSystem.Public.DataType.String;
			this.txt7.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.txt7.Location = new System.Drawing.Point(96, 80);
			this.txt7.Name = "txt7";
			this.txt7.Size = new System.Drawing.Size(160, 23);
			this.txt7.TabIndex = 197;
			this.txt7.Text = "";
			this.txt7.Validated += new System.EventHandler(this.txt7_Validated);
			// 
			// label14
			// 
			this.label14.BackColor = System.Drawing.Color.Transparent;
			this.label14.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.label14.ForeColor = System.Drawing.Color.Blue;
			this.label14.Location = new System.Drawing.Point(24, 80);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(64, 23);
			this.label14.TabIndex = 195;
			this.label14.Text = "订单数量";
			this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label15
			// 
			this.label15.BackColor = System.Drawing.Color.Transparent;
			this.label15.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.label15.ForeColor = System.Drawing.Color.Blue;
			this.label15.Location = new System.Drawing.Point(0, 176);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(96, 23);
			this.label15.TabIndex = 193;
			this.label15.Text = "客户订单号";
			this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txt15
			// 
			this.txt15.BackColor = System.Drawing.Color.White;
			this.txt15.DataField = "client_orderNo";
			this.txt15.DataType = TJSystem.Public.DataType.String;
			this.txt15.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.txt15.Location = new System.Drawing.Point(96, 176);
			this.txt15.Name = "txt15";
			this.txt15.Size = new System.Drawing.Size(160, 23);
			this.txt15.TabIndex = 194;
			this.txt15.Text = "";
			// 
			// txt6
			// 
			this.txt6.BackColor = System.Drawing.Color.White;
			this.txt6.DataField = "item_desc_cn";
			this.txt6.DataType = TJSystem.Public.DataType.String;
			this.txt6.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.txt6.Location = new System.Drawing.Point(328, 56);
			this.txt6.Name = "txt6";
			this.txt6.Size = new System.Drawing.Size(136, 23);
			this.txt6.TabIndex = 192;
			this.txt6.Text = "";
			// 
			// priComboBox1
			// 
			this.priComboBox1.BackColor = System.Drawing.Color.White;
			this.priComboBox1.DataField = "sq_code";
			this.priComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.priComboBox1.Location = new System.Drawing.Point(568, 8);
			this.priComboBox1.Name = "priComboBox1";
			this.priComboBox1.Size = new System.Drawing.Size(144, 22);
			this.priComboBox1.TabIndex = 177;
			this.priComboBox1.SelectionChangeCommitted += new System.EventHandler(this.priComboBox1_SelectionChangeCommitted);
			// 
			// label32
			// 
			this.label32.BackColor = System.Drawing.Color.Transparent;
			this.label32.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.label32.Location = new System.Drawing.Point(48, 200);
			this.label32.Name = "label32";
			this.label32.Size = new System.Drawing.Size(40, 23);
			this.label32.TabIndex = 156;
			this.label32.Text = "备注";
			this.label32.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txt16
			// 
			this.txt16.BackColor = System.Drawing.Color.White;
			this.txt16.DataField = "remark";
			this.txt16.DataType = TJSystem.Public.DataType.String;
			this.txt16.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.txt16.Location = new System.Drawing.Point(96, 200);
			this.txt16.Name = "txt16";
			this.txt16.Size = new System.Drawing.Size(616, 23);
			this.txt16.TabIndex = 157;
			this.txt16.Text = "";
			// 
			// label16
			// 
			this.label16.BackColor = System.Drawing.Color.Transparent;
			this.label16.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.label16.ForeColor = System.Drawing.Color.Blue;
			this.label16.Location = new System.Drawing.Point(8, 152);
			this.label16.Name = "label16";
			this.label16.Size = new System.Drawing.Size(88, 23);
			this.label16.TabIndex = 134;
			this.label16.Text = "外包类型";
			this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label18
			// 
			this.label18.BackColor = System.Drawing.Color.Transparent;
			this.label18.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.label18.ForeColor = System.Drawing.Color.Blue;
			this.label18.Location = new System.Drawing.Point(496, 128);
			this.label18.Name = "label18";
			this.label18.Size = new System.Drawing.Size(64, 23);
			this.label18.TabIndex = 126;
			this.label18.Text = "送货日期";
			this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label9
			// 
			this.label9.BackColor = System.Drawing.Color.Transparent;
			this.label9.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.label9.Location = new System.Drawing.Point(256, 56);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(64, 23);
			this.label9.TabIndex = 120;
			this.label9.Text = "中文规格";
			this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txt5
			// 
			this.txt5.BackColor = System.Drawing.Color.White;
			this.txt5.DataField = "item_desc";
			this.txt5.DataType = TJSystem.Public.DataType.String;
			this.txt5.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.txt5.Location = new System.Drawing.Point(96, 56);
			this.txt5.Name = "txt5";
			this.txt5.Size = new System.Drawing.Size(160, 23);
			this.txt5.TabIndex = 121;
			this.txt5.Text = "";
			// 
			// label5
			// 
			this.label5.BackColor = System.Drawing.Color.Transparent;
			this.label5.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.label5.ForeColor = System.Drawing.Color.Blue;
			this.label5.Location = new System.Drawing.Point(496, 8);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(64, 23);
			this.label5.TabIndex = 118;
			this.label5.Text = "报价单号";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label3
			// 
			this.label3.BackColor = System.Drawing.Color.Transparent;
			this.label3.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.label3.Location = new System.Drawing.Point(24, 56);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(64, 23);
			this.label3.TabIndex = 116;
			this.label3.Text = "英文规格";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txt2
			// 
			this.txt2.BackColor = System.Drawing.Color.White;
			this.txt2.DataField = "seq_no";
			this.txt2.DataType = TJSystem.Public.DataType.String;
			this.txt2.Enabled = false;
			this.txt2.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.txt2.Location = new System.Drawing.Point(328, 8);
			this.txt2.Name = "txt2";
			this.txt2.Size = new System.Drawing.Size(136, 23);
			this.txt2.TabIndex = 102;
			this.txt2.Text = "";
			// 
			// label8
			// 
			this.label8.BackColor = System.Drawing.Color.Transparent;
			this.label8.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.label8.ForeColor = System.Drawing.Color.Blue;
			this.label8.Location = new System.Drawing.Point(264, 8);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(64, 23);
			this.label8.TabIndex = 22;
			this.label8.Text = "货品序号";
			this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label7
			// 
			this.label7.BackColor = System.Drawing.Color.Transparent;
			this.label7.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.label7.Location = new System.Drawing.Point(264, 32);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(64, 23);
			this.label7.TabIndex = 21;
			this.label7.Text = "货物名称";
			this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label2
			// 
			this.label2.BackColor = System.Drawing.Color.Transparent;
			this.label2.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.label2.ForeColor = System.Drawing.Color.Blue;
			this.label2.Location = new System.Drawing.Point(8, 8);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(80, 23);
			this.label2.TabIndex = 16;
			this.label2.Text = "采购订单号";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txt3
			// 
			this.txt3.BackColor = System.Drawing.Color.White;
			this.txt3.DataField = "item_name";
			this.txt3.DataType = TJSystem.Public.DataType.String;
			this.txt3.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.txt3.Location = new System.Drawing.Point(328, 32);
			this.txt3.Name = "txt3";
			this.txt3.Size = new System.Drawing.Size(136, 23);
			this.txt3.TabIndex = 104;
			this.txt3.Text = "";
			// 
			// txt1
			// 
			this.txt1.BackColor = System.Drawing.Color.White;
			this.txt1.DataField = "po_code";
			this.txt1.DataType = TJSystem.Public.DataType.String;
			this.txt1.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.txt1.Location = new System.Drawing.Point(96, 8);
			this.txt1.Name = "txt1";
			this.txt1.Size = new System.Drawing.Size(160, 23);
			this.txt1.TabIndex = 100;
			this.txt1.Text = "";
			// 
			// lk_detail
			// 
			this.lk_detail.Location = new System.Drawing.Point(0, 0);
			this.lk_detail.Name = "lk_detail";
			this.lk_detail.TabIndex = 0;
			// 
			// fax2
			// 
			this.fax2.Format = "";
			this.fax2.FormatInfo = null;
			this.fax2.HeaderText = "传真2";
			this.fax2.MappingName = "fax2";
			this.fax2.NullText = "";
			this.fax2.Width = 75;
			// 
			// dataGridTextBoxColumn3
			// 
			this.dataGridTextBoxColumn3.Format = "";
			this.dataGridTextBoxColumn3.FormatInfo = null;
			this.dataGridTextBoxColumn3.HeaderText = "英文名";
			this.dataGridTextBoxColumn3.MappingName = "";
			this.dataGridTextBoxColumn3.NullText = "";
			this.dataGridTextBoxColumn3.Width = 75;
			// 
			// panel1
			// 
			this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
			this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.panel1.Controls.Add(this.label1);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(784, 48);
			this.panel1.TabIndex = 16;
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label1.Font = new System.Drawing.Font("宋体", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.label1.Location = new System.Drawing.Point(0, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(780, 44);
			this.label1.TabIndex = 0;
			this.label1.Text = "采购单明细";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// website
			// 
			this.website.Format = "";
			this.website.FormatInfo = null;
			this.website.HeaderText = "公司网站";
			this.website.MappingName = "website";
			this.website.NullText = "";
			this.website.Width = 75;
			// 
			// tel2
			// 
			this.tel2.Format = "";
			this.tel2.FormatInfo = null;
			this.tel2.HeaderText = "电话2";
			this.tel2.MappingName = "tel2";
			this.tel2.NullText = "";
			this.tel2.Width = 75;
			// 
			// frmPurchasePODetail
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(7, 16);
			this.BackColor = System.Drawing.SystemColors.ScrollBar;
			this.ClientSize = new System.Drawing.Size(784, 566);
			this.Controls.Add(this.panel3);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "frmPurchasePODetail";
			this.ShowInTaskbar = false;
			this.Text = "采购订单";
			this.Closed += new System.EventHandler(this.frmPurchasePODetail_Closed);
			this.panel3.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).EndInit();
			this.panel4.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion



//		private void dataGrid1_Click(object sender, System.EventArgs e)
//		{
//			System.Text.StringBuilder sb = new System.Text.StringBuilder();
//			sb.Append("select so_code,seq_no,item_code,client_itemcode,item_name,item_name_cn,item_desc,item_desc_cn,minorder,item_Qty,unit,");
//			sb.Append("unit_price,discountType,discount,discountAmount,deliverydate,outsidePack,insidePack,remark,cq_code ");
//			sb.Append("from sale_so_detail ");
//			sb.Append("where so_code = '"+ this.dataGrid1[this.dataGrid1.CurrentCell.RowNumber,0] +"'");
//			sb.Append("order by so_code");
//			//this.InitialGrid1(sb.ToString());
//		}
		
		protected override void OnClosing(CancelEventArgs e)
		{			
//			if(MessageBox.Show("确定退出？（Y/N）","确认",MessageBoxButtons.YesNo,MessageBoxIcon.Information) == System.Windows.Forms.DialogResult.No)
//			{
//				e.Cancel = true;
//			}

			string sql = "select sum(item_qty*unit_price) as totalamount from purchase_po_detail where po_code='" + this.txt1.Text + "'";
			DataTable dt = TJSystem.Public.PublicStatic.db.GetDataTable(sql);
			if(dt.Rows.Count == 1)
			{
				if(TJSystem.Public.PublicStatic.IsNumDouble(dt.Rows[0][0].ToString()))
				{
					TJSystem.Public.PublicStatic.AmountTotal = Convert.ToDouble(dt.Rows[0][0].ToString());
				}
			}
			else
			{
				TJSystem.Public.PublicStatic.AmountTotal = 0;
			}
			base.OnClosing (e);
		}



		private void priComboBox2_SelectionChangeCommitted(object sender, System.EventArgs e)
		{
		    string sql = "select a.item_name,a.item_name_cn,a.item_desc,a.item_desc_cn,a.minorder,a.unit,b.unit_name_cn as unit_name_cn,a.saleprice,a.remark from basic_item a left join p_unit b on a.unit = b.unit_id where a.item_code = '"+ this.priComboBox2.SelectedValue +"'";
			DataTable dt = TJSystem.Public.PublicStatic.db.GetDataTable(sql);
			if(dt.Rows.Count == 1)
			{
				this.txt3.Text = dt.Rows[0]["item_name"].ToString().Trim();
				this.txt4.Text = dt.Rows[0]["item_name_cn"].ToString().Trim();
				this.txt5.Text = dt.Rows[0]["item_desc"].ToString().Trim();
				this.txt6.Text = dt.Rows[0]["item_desc_cn"].ToString().Trim();
				this.txt8.Text = dt.Rows[0]["unit"].ToString().Trim();
//				this.txt9.Text = dt.Rows[0]["saleprice"].ToString().Trim();
				this.txt16.Text = dt.Rows[0]["remark"].ToString().Trim();
			}
			else
			{
				this.txt3.Text = "";
				this.txt4.Text = "";
				this.txt5.Text = "";
				this.txt6.Text = "";
				this.txt8.Text = "";
				this.txt9.Text = "";
				this.txt16.Text = "";
			}
		}

		private void frmPurchasePODetail_Closed(object sender, System.EventArgs e)
		{
			frmPurchasePO.Count = 0;
		}

		private void txt7_Validated(object sender, System.EventArgs e)
		{
			if(TJSystem.Public.PublicStatic.IsNumDouble(this.txt7.Text.Trim())
				&& TJSystem.Public.PublicStatic.IsNumDouble(this.txt9.Text.Trim()))
			{
				this.txt11.Text = Convert.ToString(Convert.ToDouble(this.txt7.Text.Trim()) * Convert.ToDouble(this.txt9.Text.Trim()));
			}
			else
			{
				this.txt11.Text = "0";
			}
		}

		private void priComboBox1_SelectionChangeCommitted(object sender, System.EventArgs e)
		{
			DataTable dt = null;
			DataTable dttmp = null;
			string sql = null;
			if(this.priComboBox1.SelectedValue == null)
			{
				TJSystem.Public.PublicStatic.ShowMessage(TJSystem.Public.MessageType.Exclamation,"报价单不存在，无法导入销售明细！");
				return;
			}

			System.Text.StringBuilder sb = new System.Text.StringBuilder();
			sb.Append("select a.sq_code,a.seq_no,a.item_code,b.item_name,b.item_name_cn,b.item_desc,b.item_desc_cn,");
			sb.Append(" b.minorder,b.unit,b.outsiepacktype,b.insidepacktype from purchase_sq_detail a");
			sb.Append(" left join basic_item b on a.item_code=b.item_code");
			sb.Append(" where a.sq_code=");
			sb.Append("'");
			sb.Append(this.priComboBox1.SelectedValue.ToString().Trim());
			sb.Append("'");
			sb.Append(" order by a.seq_no");

			dt = TJSystem.Public.PublicStatic.db.GetDataTable(sb.ToString());
			if(dt.Rows.Count == 0)
			{
				TJSystem.Public.PublicStatic.ShowMessage(TJSystem.Public.MessageType.Exclamation,"该报价单无报价货品！");
				return;
			}

			if(MessageBox.Show("是否需要导入该报价单的货品资料？","确认导入",MessageBoxButtons.YesNo,MessageBoxIcon.Question)
				== System.Windows.Forms.DialogResult.No)
			{
				return;
			}

			MyADO.DBOperator db = MyADO.DBOperatorFactory.GetDBOperator(TJSystem.Public.PublicStatic.ConnectionString, MyADO.DBEnum.SQLServer);
			
			sql = "select case when max(seq_no) is null then 0 else max(seq_no) end as counts from purchase_po_detail where so_code='" + this.txt1.Text + "'";
			dttmp = db.GetDataTable(sql);
			db.Open();
			try
			{				
				int icount = 0;
				db.BeginTrans();
				sql = "delete from v where so_code='" + this.txt1.Text + "' and cq_code='" + this.priComboBox1.SelectedValue.ToString() + "'";;
				db.ExeSql(sql);
				for(int i = 0; i < dt.Rows.Count ; i++)
				{
					sb.Remove(0,sb.ToString().Length);
					sb.Append(" insert into purchase_po_detail(po_code,seq_no,sq_code,item_code,item_name,item_name_cn,item_desc,item_desc_cn,unit,outsiepacktype,insidepacktype) values (");
					sb.Append("'");
					sb.Append(this.txt1.Text.Trim());
					sb.Append("','");
					sb.Append(Convert.ToString(Convert.ToInt32(dttmp.Rows[0][0].ToString()) + i+1));
					sb.Append("','");
					sb.Append(dt.Rows[i]["sq_code"].ToString());
					sb.Append("','");
					sb.Append(dt.Rows[i]["item_code"].ToString());
					sb.Append("','");
					sb.Append(dt.Rows[i]["item_name"].ToString());
					sb.Append("','");
					sb.Append(dt.Rows[i]["item_name_cn"].ToString());
					sb.Append("','");
					sb.Append(dt.Rows[i]["item_desc"].ToString());
					sb.Append("','");
					sb.Append(dt.Rows[i]["item_desc_cn"].ToString());
					sb.Append("','");
					sb.Append(dt.Rows[i]["unit"].ToString());
					sb.Append("','");
					sb.Append(dt.Rows[i]["outsiepacktype"].ToString());
					sb.Append("','");
					sb.Append(dt.Rows[i]["insidepacktype"].ToString());
					sb.Append("')");

					if(db.ExeSql(sb.ToString(),true))
					{
						icount ++;
					}
				}
				db.CommitTrans();
				TJSystem.Public.PublicStatic.ShowMessage(TJSystem.Public.MessageType.Information, "共导入"+icount.ToString()+"笔货品资料！");
			}
			catch(Exception ex)
			{
				db.RollbackTrans();
				TJSystem.Public.PublicStatic.ShowMessage(TJSystem.Public.MessageType.Error, ex.ToString() + " - priComboBox1_SelectionChangeCommitted");
				return;
			}
		}

}
}

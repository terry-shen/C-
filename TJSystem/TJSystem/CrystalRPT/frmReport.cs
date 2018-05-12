using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace TJSystem.CrystalRPT
{
	/// <summary>
	/// frmReport 的摘要说明。
	/// </summary>
	public class frmReport : System.Windows.Forms.Form
	{
		private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
		/// <summary>
		/// 必需的设计器变量。
		/// </summary>
		private System.ComponentModel.Container components = null;
		private string _condition = null;
		private TJSystem.Classes.common.DocParamCommon dpcom = null;
		private System.Windows.Forms.DataGrid _dg = null;
		private string company_eng = "CHANGZHOU LU SHI IMPORTS&EXPORTS CO.,LTD";
		private string address = "NO.195 XUECHENG RD,XUEYAN TOWN,CHANGZHOU CITY,JIANGSU PROVINCE";

		public frmReport()
		{
			//
			// Windows 窗体设计器支持所必需的
			//
			InitializeComponent();

			//
			// TODO: 在 InitializeComponent 调用后添加任何构造函数代码
			//
		}

		public frmReport(string rptType, TJSystem.Classes.common.DocParamCommon dpcom)
		{
			//
			// Windows 窗体设计器支持所必需的
			//
			this.dpcom = dpcom;
			InitializeComponent();

			this.Text = rptType ;

			InitialCrystalReport(rptType);

			//
			// TODO: 在 InitializeComponent 调用后添加任何构造函数代码
			//
		}

		public frmReport(string rptType, TJSystem.Classes.common.DocParamCommon dpcom, System.Windows.Forms.DataGrid dg)
		{
			//
			// Windows 窗体设计器支持所必需的
			//
			this.dpcom = dpcom;
			InitializeComponent();
			_dg = dg;

			this.Text = rptType ;

			InitialCrystalReport(rptType);
			

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
			this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
			this.SuspendLayout();
			// 
			// crystalReportViewer1
			// 
			this.crystalReportViewer1.ActiveViewIndex = -1;
			this.crystalReportViewer1.DisplayGroupTree = false;
			this.crystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.crystalReportViewer1.Location = new System.Drawing.Point(0, 0);
			this.crystalReportViewer1.Name = "crystalReportViewer1";
			this.crystalReportViewer1.ReportSource = null;
			this.crystalReportViewer1.Size = new System.Drawing.Size(792, 566);
			this.crystalReportViewer1.TabIndex = 0;
			// 
			// frmReport
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(792, 566);
			this.Controls.Add(this.crystalReportViewer1);
			this.Name = "frmReport";
			this.ShowInTaskbar = false;
			this.ResumeLayout(false);

		}
		#endregion


		private void InitialCrystalReport(string rptType)
		{
			switch(rptType)
			{
				case "发票":
				{
					ConstructSaleRpt();
					break;
				}
				case "货物托运单":
				{
					ConstructAWBRpt();
					break;
				}
				case "外销出仓单":
				{
					ConstructSaleOutRpt();
					break;
				}
				case "形式发票":
				{
					ConstructSaleFormRpt();
					break;
				}
				case "托运单打印":
				{
					ConstructAWBShipRpt();
					break;
				}
				case "装箱单":
				{
					ConstructSalePackRpt();
					break;
				}
				case "盈亏表":
				{
					ConstructSaleBalance();
					break;
				}
				case "盈亏报表":
				{
					ConstructSaleBalanceRpt();
					break;
				}
				case "购销合同":
				{
					ConstructSaleTermRpt();
					break;
				}
				case "Sales Confirmation":
				{
					ConstructSaleConfirmRpt();
					break;
				}
				case "报关单":
				{
					ConstrctBaoGuanDanRpt();
					break;
				}
				case "OFFER SHEET":
				{
					ConstructOfferSheetRpt();
					break;
				}
				case "QUOTATION":
				{
					ConstructQuotationRpt();
					break;
				}
				default:
				{
					break;
				}
			}
		}

		public string PKCondition
		{
			get
			{
				return _condition;
			}
		}

		private void ConstructSaleRpt()
		{
			double dbltotal = 0;
			double dbpackltotal = 0;
			double dblamount = 0;
			string eng = null;
			string num = null;
			string strall = null;
			TJSystem.CrystalRPT.crstSODetail clrpt = new TJSystem.CrystalRPT.crstSODetail() ;
			System.Text.StringBuilder sb = new System.Text.StringBuilder();
			sb.Append("select d.port_name as DESTPORTNAME,d.port_name as DEPARTURENAME,ltrim(str(a.pack_qty,20,0)) as pack_qty,a.seq_no,a.item_code,a.item_name,ltrim(str(a.unit_price,20,2)) as unit_price,");
			sb.Append("case when a.item_qty is null then '0' else ltrim(str(a.item_qty,20,0)) end as item_qty,");
			sb.Append("case when a.unit_price*a.item_qty is null then '0' else  ltrim(str(a.unit_price*a.item_qty,20,2)) end as price_total");
			sb.Append(" from sale_so_detail a");
			sb.Append(" left join sale_so_master b on a.so_code=b.so_code");
			sb.Append(" left join p_port c on b.destport=c.port_code");
			sb.Append(" left join p_port d on b.port_departure=d.port_code ");
			sb.Append(this.dpcom.PKCondition); 
			sb.Append(" order by a.seq_no desc");
			
			TJSystem.Data.dsDoc ds = new TJSystem.Data.dsDoc() ;
			System.Data.DataTable dt = null;
			dt = TJSystem.Public.PublicStatic.db.GetDataTable(sb.ToString());

			ds.Tables["SODetail"].Clear();
			System.Data.DataRow dr = null;

			for(int i = 0 ; i < dt.Rows.Count ; i ++)
			{
				dr = ds.Tables["SODetail"].NewRow();
				dr[0] = dt.Rows[i]["seq_no"].ToString();
				dr[1] = dt.Rows[i]["item_code"].ToString();
				dr[2] = dt.Rows[i]["item_name"].ToString();
				if (Convert.ToDouble(dt.Rows[i]["unit_price"].ToString()) < 1)
				{
					dr[3] = "0" + dt.Rows[i]["unit_price"].ToString();
				}
				else
				{
					dr[3] = dt.Rows[i]["unit_price"].ToString();
				}
				dr[4] = dt.Rows[i]["item_qty"].ToString();
				dr[5] = dt.Rows[i]["price_total"].ToString();
//				ds.Tables["SODetail"].ImportRow(dt.Rows[i]) ;
				ds.Tables["SODetail"].Rows.InsertAt(dr,0);
				dbltotal += Convert.ToDouble(dt.Rows[i]["item_qty"].ToString());
				dbpackltotal += Convert.ToDouble(dt.Rows[i]["pack_qty"].ToString());
				dblamount += Convert.ToDouble(dt.Rows[i]["price_total"].ToString());
			}
			ds.Tables["SODetail"].EndInit() ;
			ds.Tables["SODetail"].EndLoadData() ;
			
			clrpt.SetDataSource(ds) ;

			if(dt.Rows.Count > 0)
			{
				((CrystalDecisions.CrystalReports.Engine.TextObject)clrpt.ReportDefinition.ReportObjects["Text20"]).Text = "FOB " + dt.Rows[0]["DESTPORTNAME"].ToString().ToUpper();
			}
		
			((CrystalDecisions.CrystalReports.Engine.TextObject)clrpt.ReportDefinition.ReportObjects["DOCNO"]).Text = dpcom.DocNO ;
			((CrystalDecisions.CrystalReports.Engine.TextObject)clrpt.ReportDefinition.ReportObjects["DOCDATE"]).Text = Convert.ToDateTime(dpcom.DocDate).ToString("yyyy-MM-dd");
			((CrystalDecisions.CrystalReports.Engine.TextObject)clrpt.ReportDefinition.ReportObjects["CLIENTNAME"]).Text = dpcom.DocSaleTo ;
			((CrystalDecisions.CrystalReports.Engine.TextObject)clrpt.ReportDefinition.ReportObjects["Text16"]).Text = dbltotal.ToString() + " pcs";
			((CrystalDecisions.CrystalReports.Engine.TextObject)clrpt.ReportDefinition.ReportObjects["Text18"]).Text = "USD " + dblamount.ToString("f2");
			strall = "SAY TOTAL PACKED IN ";
			num = dbpackltotal.ToString("f2");
			eng = new PublicStatic.Public.Number2English().NumberToString(dbpackltotal);
			strall += eng.ToUpper();
			strall += " (";
			strall += num;
			strall += ")";
			strall += " CARTONS ONLY.";
			((CrystalDecisions.CrystalReports.Engine.TextObject)clrpt.ReportDefinition.ReportObjects["Text3"]).Text = strall;
						
			((CrystalDecisions.CrystalReports.Engine.TextObject)clrpt.ReportDefinition.ReportObjects["COMPANY"]).Text = TJSystem.Public.PublicStatic.CompanyName;
			
			sb.Remove(0,sb.ToString().Length);
			sb.Append("select company_name,address from basic_company where company_id =");
			sb.Append("'");
			sb.Append(TJSystem.Public.PublicStatic.CompanyID);
			sb.Append("'");
			dt = TJSystem.Public.PublicStatic.db.GetDataTable(sb.ToString());
			if (dt.Rows.Count > 0)
			{
//				((CrystalDecisions.CrystalReports.Engine.TextObject)clrpt.ReportDefinition.ReportObjects["Text10"]).Text = dt.Rows[0]["company_name"].ToString().Trim();
//				((CrystalDecisions.CrystalReports.Engine.TextObject)clrpt.ReportDefinition.ReportObjects["Text12"]).Text = dt.Rows[0]["address"].ToString().Trim();
			}
			else
			{
//				((CrystalDecisions.CrystalReports.Engine.TextObject)clrpt.ReportDefinition.ReportObjects["Text10"]).Text = company_eng;
//				((CrystalDecisions.CrystalReports.Engine.TextObject)clrpt.ReportDefinition.ReportObjects["Text12"]).Text = this.address;
			}

			this.crystalReportViewer1.ReportSource = clrpt ;
		}

		private void ConstructAWBRpt()
		{
			System.Text.StringBuilder sb = new System.Text.StringBuilder();
			string hs_code = "";
			string sql = null;
			int iHS = 0;
			System.Data.DataTable dtImg = null;
			sb.Append("select e.port_name as DESTPORTNAME,ltrim(str(a.pack_qty,20,0)) as pack_qty,a.so_code,a.item_code as item_code,ltrim(str(b.grossweight,20,2)) as item_weight,ltrim(str(b.netweight,20,2)) as gross_weight,");
			sb.Append(" a.item_code+' '+a.item_name as item_name,ltrim(str(a.item_qty,20,0)) as item_qty,ltrim(str(a.unit_price,20,2)) as unit_price,");
			sb.Append(" ltrim(str(a.item_qty*a.unit_price,20,2)) as total_price,b.hs_code,a.pack_qty*b.length*b.width*b.height/1000000 as volumns");
			sb.Append(" from sale_so_detail a");
			sb.Append(" left join basic_item b on a.item_code=b.item_code ");
			sb.Append(" left join sale_so_master c on a.so_code=c.so_code ");
			sb.Append(" left join p_port d on c.destport=d.port_code ");
			sb.Append(" left join p_port e on c.port_departure=e.port_code ");
			sb.Append( this.dpcom.PKCondition);
			sb.Append(" order by item_code desc");			
			
			TJSystem.CrystalRPT.crstAWBDetail clrpt = new TJSystem.CrystalRPT.crstAWBDetail() ;

			PublicStatic.Data.dsAwbWithImg ds = new PublicStatic.Data.dsAwbWithImg();
			System.Data.DataTable dt = null;
			System.Data.DataRow dr = null;
			dt = TJSystem.Public.PublicStatic.db.GetDataTable(sb.ToString());
			double dblqty = 0;
			double dblwei = 0;
			double dblgro = 0;
			double dblprice = 0;
			double dblvolumns = 0;
			double dblpack = 0;
			sql = "select maitouimg from sale_doc_master where invoice_no='" + dpcom.DocLCNO + "'";
			dtImg = TJSystem.Public.PublicStatic.db.GetDataTable(sql);

			ds.Tables["AWBDetail"].Clear();

			for(int i = 0 ; i < dt.Rows.Count ; i ++)
			{
				dr = ds.Tables["AWBDetail"].NewRow();
				dr[0] = dt.Rows[i]["item_name"].ToString();
				dr[1] = dt.Rows[i]["pack_qty"].ToString();
				dr[2] = dt.Rows[i]["item_qty"].ToString();
				dr[3] = dt.Rows[i]["item_weight"].ToString();
				dr[4] = dt.Rows[i]["gross_weight"].ToString();
				dr[5] = dt.Rows[i]["unit_price"].ToString();
				dr[6] = "US$" + dt.Rows[i]["total_price"].ToString();
				dr[7] = dtImg.Rows[0]["maitouimg"];
				dblpack += Convert.ToDouble(dr[1].ToString());
				dblqty += Convert.ToDouble(dr[2].ToString());
				dblwei += Convert.ToDouble(dr[3].ToString()) * Convert.ToDouble(dt.Rows[i]["pack_qty"].ToString());
				dblgro += Convert.ToDouble(dr[4].ToString()) * Convert.ToDouble(dt.Rows[i]["pack_qty"].ToString());
				dblprice += Convert.ToDouble(dt.Rows[i]["total_price"].ToString());
				dblvolumns += Convert.ToDouble(dt.Rows[i]["volumns"].ToString());
				if(!dt.Rows[i]["hs_code"].ToString().Trim().Equals(""))
				{
					if (iHS < 6)
					{
						hs_code = dt.Rows[i]["hs_code"].ToString();
						if (!hs_code.Trim().Equals(""))
						{
							if (iHS == 0)
							{
								((CrystalDecisions.CrystalReports.Engine.TextObject)clrpt.ReportDefinition.ReportObjects["Text116"]).Text = hs_code;
								iHS ++;
							}
							else if (iHS == 1)
							{
								((CrystalDecisions.CrystalReports.Engine.TextObject)clrpt.ReportDefinition.ReportObjects["Text126"]).Text = hs_code;
								iHS ++;
							}
							else if (iHS == 2)
							{
								((CrystalDecisions.CrystalReports.Engine.TextObject)clrpt.ReportDefinition.ReportObjects["Text127"]).Text = hs_code;
								iHS ++;
							}
							else if (iHS == 3)
							{
								((CrystalDecisions.CrystalReports.Engine.TextObject)clrpt.ReportDefinition.ReportObjects["Text128"]).Text = hs_code;
								iHS ++;
							}
							else if (iHS == 4)
							{
								((CrystalDecisions.CrystalReports.Engine.TextObject)clrpt.ReportDefinition.ReportObjects["Text129"]).Text = hs_code;
								iHS ++;
							}
							else if (iHS == 5)
							{
								((CrystalDecisions.CrystalReports.Engine.TextObject)clrpt.ReportDefinition.ReportObjects["Text130"]).Text = hs_code;
								iHS ++;
							}
						}
					}
//					hs_code += dt.Rows[i]["hs_code"].ToString() + "\r\n";
				}
				ds.Tables["AWBDetail"].Rows.InsertAt(dr,0) ;
			}
			ds.Tables["AWBDetail"].EndInit() ;
			ds.Tables["AWBDetail"].EndLoadData() ;

			if (dt.Rows.Count < 6)
			{
				clrpt.Section10.Height = (6 - dt.Rows.Count) * 300;
			}
			if (dt.Rows.Count > 0)
			{
				((CrystalDecisions.CrystalReports.Engine.TextObject)clrpt.ReportDefinition.ReportObjects["Text124"]).Text = "FOB " + dt.Rows[0]["DESTPORTNAME"].ToString().ToUpper();
			}

			((CrystalDecisions.CrystalReports.Engine.TextObject)clrpt.ReportDefinition.ReportObjects["Text118"]).Text = dblqty.ToString();
			((CrystalDecisions.CrystalReports.Engine.TextObject)clrpt.ReportDefinition.ReportObjects["Text119"]).Text = dblwei.ToString("f2");
			((CrystalDecisions.CrystalReports.Engine.TextObject)clrpt.ReportDefinition.ReportObjects["Text120"]).Text = dblgro.ToString("f2");
			((CrystalDecisions.CrystalReports.Engine.TextObject)clrpt.ReportDefinition.ReportObjects["Text121"]).Text = "US$" + dblprice.ToString("f2");
			((CrystalDecisions.CrystalReports.Engine.TextObject)clrpt.ReportDefinition.ReportObjects["Text133"]).Text = dblpack.ToString();

			int dd = ds.Tables["AWBDetail"].Rows.Count;
			
			clrpt.SetDataSource(ds) ;
//			clrpt.Section4.Height = 400;
//			clrpt.Section3.Height = 400;
			
//			if (dtImg.Rows.Count == 1)
//			{
				
//				TJSystem.CrystalRPT.cystImg rptImg ;
//				CrystalDecisions.CrystalReports.Engine.SubreportObject rptobj = (CrystalDecisions.CrystalReports.Engine.SubreportObject)clrpt.ReportDefinition.ReportObjects["Subreport2"];//new cystImg();
//				System.Data.DataRow drT = null;
//				PublicStatic.Data.dsImg imgds = new PublicStatic.Data.dsImg();
//				imgds.Tables["IMGCONS"].Clear();
//
//				drT = imgds.Tables["IMGCONS"].NewRow();
//				System.IO.MemoryStream ms=new System.IO.MemoryStream((byte[])dtImg.Rows[0]["maitouimg"]); 
//				byte[] Content = new byte[ms.Length];
//				ms.Read(Content,0,(int)ms.Length);
//
//				drT[0] = Content;
//			
//				imgds.Tables["IMGCONS"].Rows.InsertAt(drT,0) ;
//
//				imgds.Tables["IMGCONS"].EndInit() ;
//				imgds.Tables["IMGCONS"].EndLoadData() ;
//				rptobj.OpenSubreport(rptobj.SubreportName);
//				
//				clrpt.OpenSubreport(rptobj.SubreportName);
				
//			}


			sb.Remove(0,sb.ToString().Length);
			sb.Append("select a.LOADINGDATE,a.AWB_CODE,a.awb_date,a.lc_code,a.INVOICE_NO,a.SHIPPER_ID,f.bank_name,f.account,a.SHIPPER,a.createby,");
			sb.Append(" a.FREIGHT_AMOUNT,");
			sb.Append(" b.client_id,b.client_name,g.bank,g.account as clientaccount,a.allowtransport,a.allowbatch,");
			sb.Append(" i.trans_name as transtype,a.port_departure,c.port_name as port_departure_name,");
			sb.Append("  a.destport,d.port_name as destport_name,a.FREIGHT_AMOUNT,a.consignee,");
			sb.Append(" a.notifier,a.ITEM_AMOUNT ,a.INVOICE_NO,b.so_code,b.licence_no,b.MaiTou,a.OCEAN_VESSEL,a.arrivecountry,e.country_name as country_namecn,");
			sb.Append(" h.client_name as lc_client_name,h.lc_date,h.amount as lc_amount,h.rec_date as lc_rec_date,h.validity as lc_validity");
			sb.Append(" from SALE_WAYBILL_MASTER a");
			sb.Append(" left join sale_doc_master b on a.INVOICE_NO=b.INVOICE_NO");
			sb.Append(" left join p_port c on a.port_departure = c.port_code");
			sb.Append(" left join p_port d on a.destport = d.port_code");
			sb.Append(" left join p_country e on e.country_code=a.arrivecountry");
			sb.Append(" left join basic_forwarder_bank f on f.forward_id=a.SHIPPER_ID");
			sb.Append(" left join basic_client g on g.client_id=b.client_id");
			sb.Append(" left join SALE_LETTEROFCREDIT h on h.lc_code=a.lc_code");
			sb.Append(" left join p_transtype i on a.transtype=i.trans_code");
			sb.Append(" where a.awb_code=");
			sb.Append("'");
			sb.Append(dpcom.DocNO);
			sb.Append("'");

			dt = TJSystem.Public.PublicStatic.db.GetDataTable(sb.ToString());
			if(dt.Rows.Count > 0)
			{		
				((CrystalDecisions.CrystalReports.Engine.TextObject)clrpt.ReportDefinition.ReportObjects["Text13"]).Text = dt.Rows[0]["awb_date"].ToString();
				((CrystalDecisions.CrystalReports.Engine.TextObject)clrpt.ReportDefinition.ReportObjects["Text42"]).Text = dt.Rows[0]["bank_name"].ToString();
				((CrystalDecisions.CrystalReports.Engine.TextObject)clrpt.ReportDefinition.ReportObjects["Text43"]).Text = TJSystem.Public.PublicStatic.CompanyName;
				((CrystalDecisions.CrystalReports.Engine.TextObject)clrpt.ReportDefinition.ReportObjects["Text44"]).Text = dt.Rows[0]["lc_client_name"].ToString();
				((CrystalDecisions.CrystalReports.Engine.TextObject)clrpt.ReportDefinition.ReportObjects["Text45"]).Text = dt.Rows[0]["consignee"].ToString();
				((CrystalDecisions.CrystalReports.Engine.TextObject)clrpt.ReportDefinition.ReportObjects["Text46"]).Text = dt.Rows[0]["notifier"].ToString();
				((CrystalDecisions.CrystalReports.Engine.TextObject)clrpt.ReportDefinition.ReportObjects["Text33"]).Text = dt.Rows[0]["account"].ToString();
				((CrystalDecisions.CrystalReports.Engine.TextObject)clrpt.ReportDefinition.ReportObjects["Text34"]).Text = dt.Rows[0]["AWB_CODE"].ToString();

				((CrystalDecisions.CrystalReports.Engine.TextObject)clrpt.ReportDefinition.ReportObjects["Text35"]).Text = dt.Rows[0]["so_code"].ToString();
				((CrystalDecisions.CrystalReports.Engine.TextObject)clrpt.ReportDefinition.ReportObjects["Text36"]).Text = dt.Rows[0]["licence_no"].ToString();
				((CrystalDecisions.CrystalReports.Engine.TextObject)clrpt.ReportDefinition.ReportObjects["Text37"]).Text = dt.Rows[0]["transtype"].ToString();
				((CrystalDecisions.CrystalReports.Engine.TextObject)clrpt.ReportDefinition.ReportObjects["Text38"]).Text = dt.Rows[0]["port_departure_name"].ToString().ToUpper();
				((CrystalDecisions.CrystalReports.Engine.TextObject)clrpt.ReportDefinition.ReportObjects["Text39"]).Text = dt.Rows[0]["destport_name"].ToString();
				((CrystalDecisions.CrystalReports.Engine.TextObject)clrpt.ReportDefinition.ReportObjects["Text40"]).Text = dt.Rows[0]["lc_code"].ToString();
				((CrystalDecisions.CrystalReports.Engine.TextObject)clrpt.ReportDefinition.ReportObjects["Text41"]).Text = dt.Rows[0]["lc_amount"].ToString();
				((CrystalDecisions.CrystalReports.Engine.TextObject)clrpt.ReportDefinition.ReportObjects["Text15"]).Text = dt.Rows[0]["lc_date"].ToString();

				((CrystalDecisions.CrystalReports.Engine.TextObject)clrpt.ReportDefinition.ReportObjects["Text64"]).Text = dt.Rows[0]["country_namecn"].ToString();
				((CrystalDecisions.CrystalReports.Engine.TextObject)clrpt.ReportDefinition.ReportObjects["Text67"]).Text = dpcom.PayType;
				((CrystalDecisions.CrystalReports.Engine.TextObject)clrpt.ReportDefinition.ReportObjects["Text62"]).Text = dpcom.ShipperType;
				((CrystalDecisions.CrystalReports.Engine.TextObject)clrpt.ReportDefinition.ReportObjects["Text65"]).Text = dt.Rows[0]["LOADINGDATE"].ToString();
				((CrystalDecisions.CrystalReports.Engine.TextObject)clrpt.ReportDefinition.ReportObjects["Text68"]).Text = dt.Rows[0]["allowbatch"].ToString();
				((CrystalDecisions.CrystalReports.Engine.TextObject)clrpt.ReportDefinition.ReportObjects["Text63"]).Text = dt.Rows[0]["lc_rec_date"].ToString();
				((CrystalDecisions.CrystalReports.Engine.TextObject)clrpt.ReportDefinition.ReportObjects["Text66"]).Text = dt.Rows[0]["lc_validity"].ToString();
				((CrystalDecisions.CrystalReports.Engine.TextObject)clrpt.ReportDefinition.ReportObjects["Text69"]).Text = dt.Rows[0]["allowtransport"].ToString();
				((CrystalDecisions.CrystalReports.Engine.TextObject)clrpt.ReportDefinition.ReportObjects["Text32"]).Text = dt.Rows[0]["MaiTou"].ToString();

				((CrystalDecisions.CrystalReports.Engine.TextObject)clrpt.ReportDefinition.ReportObjects["Text59"]).Text = dpcom.Remark;//"FREIGHT COLLECT";// + dt.Rows[0]["FREIGHT_AMOUNT"].ToString();
				((CrystalDecisions.CrystalReports.Engine.TextObject)clrpt.ReportDefinition.ReportObjects["Text60"]).Text = "";
				((CrystalDecisions.CrystalReports.Engine.TextObject)clrpt.ReportDefinition.ReportObjects["Text61"]).Text = "";
				((CrystalDecisions.CrystalReports.Engine.TextObject)clrpt.ReportDefinition.ReportObjects["Text88"]).Text = "";
				((CrystalDecisions.CrystalReports.Engine.TextObject)clrpt.ReportDefinition.ReportObjects["Text103"]).Text = dt.Rows[0]["OCEAN_VESSEL"].ToString();
				((CrystalDecisions.CrystalReports.Engine.TextObject)clrpt.ReportDefinition.ReportObjects["Text104"]).Text = "";

				((CrystalDecisions.CrystalReports.Engine.TextObject)clrpt.ReportDefinition.ReportObjects["Text97"]).Text = "";
				((CrystalDecisions.CrystalReports.Engine.TextObject)clrpt.ReportDefinition.ReportObjects["Text98"]).Text = "";
				((CrystalDecisions.CrystalReports.Engine.TextObject)clrpt.ReportDefinition.ReportObjects["Text99"]).Text = "";
				((CrystalDecisions.CrystalReports.Engine.TextObject)clrpt.ReportDefinition.ReportObjects["Text100"]).Text = "";
				((CrystalDecisions.CrystalReports.Engine.TextObject)clrpt.ReportDefinition.ReportObjects["Text101"]).Text = "";
				((CrystalDecisions.CrystalReports.Engine.TextObject)clrpt.ReportDefinition.ReportObjects["Text102"]).Text = dt.Rows[0]["country_namecn"].ToString();

			}
			((CrystalDecisions.CrystalReports.Engine.TextObject)clrpt.ReportDefinition.ReportObjects["Text9"]).Text = TJSystem.Public.PublicStatic.CompanyName;
			((CrystalDecisions.CrystalReports.Engine.TextObject)clrpt.ReportDefinition.ReportObjects["Text11"]).Text = TJSystem.Public.PublicStatic.LoginUserName;
//			((CrystalDecisions.CrystalReports.Engine.TextObject)clrpt.ReportDefinition.ReportObjects["Text116"]).Text = hs_code;
			((CrystalDecisions.CrystalReports.Engine.TextObject)clrpt.ReportDefinition.ReportObjects["Text88"]).Text = dblvolumns.ToString("f2") + " CBM";
			
			sb.Remove(0,sb.ToString().Length);
			sb.Append("select company_name,address from basic_company where company_id =");
			sb.Append("'");
			sb.Append(TJSystem.Public.PublicStatic.CompanyID);
			sb.Append("'");
			dt = TJSystem.Public.PublicStatic.db.GetDataTable(sb.ToString());
			if (dt.Rows.Count > 0)
			{
				((CrystalDecisions.CrystalReports.Engine.TextObject)clrpt.ReportDefinition.ReportObjects["Text122"]).Text = dt.Rows[0]["company_name"].ToString().Trim();
				((CrystalDecisions.CrystalReports.Engine.TextObject)clrpt.ReportDefinition.ReportObjects["Text123"]).Text = dt.Rows[0]["address"].ToString().Trim();
			}
			else
			{
				((CrystalDecisions.CrystalReports.Engine.TextObject)clrpt.ReportDefinition.ReportObjects["Text122"]).Text = company_eng;
				((CrystalDecisions.CrystalReports.Engine.TextObject)clrpt.ReportDefinition.ReportObjects["Text123"]).Text = this.address;
			}

			this.crystalReportViewer1.ReportSource = clrpt ;
		}

		private void ConstructAWBShipRpt()
		{
			System.Text.StringBuilder sb = new System.Text.StringBuilder();
			sb.Append("select item_code,item_name+' '+item_desc as item_name,ltrim(str(item_qty,20,0)) as item_qty,item_qty as unit_price,item_qty as price_total");
			sb.Append(" from sale_so_detail ");
			sb.Append( this.dpcom.PKCondition);
			sb.Append(" order by item_code desc");

			TJSystem.CrystalRPT.crstAWBShipper clrpt = new TJSystem.CrystalRPT.crstAWBShipper() ;
						
			TJSystem.Data.dsSaleForm ds = new TJSystem.Data.dsSaleForm() ;
			System.Data.DataTable dt = null;
			System.Data.DataRow dr = null;
			dt = TJSystem.Public.PublicStatic.db.GetDataTable(sb.ToString());

			ds.Tables["DataConstructor"].Clear();

			for(int i = 0 ; i < dt.Rows.Count ; i ++)
			{
				dr = ds.Tables["DataConstructor"].NewRow();
				dr[0] = dt.Rows[i]["item_name"].ToString();
				dr[1] = dt.Rows[i]["item_qty"].ToString();
				dr[2] = dt.Rows[i]["unit_price"].ToString();
				dr[3] = dt.Rows[i]["price_total"].ToString();
				
				ds.Tables["DataConstructor"].Rows.InsertAt(dr,0) ;
			}
			ds.Tables["DataConstructor"].EndInit() ;
			ds.Tables["DataConstructor"].EndLoadData() ;

			int dd = ds.Tables["DataConstructor"].Rows.Count;
			
			clrpt.SetDataSource(ds) ;
		
			((CrystalDecisions.CrystalReports.Engine.TextObject)clrpt.ReportDefinition.ReportObjects["Text5"]).Text = dpcom.Shipper ;
			((CrystalDecisions.CrystalReports.Engine.TextObject)clrpt.ReportDefinition.ReportObjects["Text7"]).Text = dpcom.DocSaleTo ;
			((CrystalDecisions.CrystalReports.Engine.TextObject)clrpt.ReportDefinition.ReportObjects["Text9"]).Text = dpcom.DocDate ;
			((CrystalDecisions.CrystalReports.Engine.TextObject)clrpt.ReportDefinition.ReportObjects["Text11"]).Text = dpcom.DocNO ;
			((CrystalDecisions.CrystalReports.Engine.TextObject)clrpt.ReportDefinition.ReportObjects["Text16"]).Text = dpcom.DocLCNO ;
			((CrystalDecisions.CrystalReports.Engine.TextObject)clrpt.ReportDefinition.ReportObjects["Text18"]).Text = dpcom.ValueT ;
			((CrystalDecisions.CrystalReports.Engine.TextObject)clrpt.ReportDefinition.ReportObjects["Text24"]).Text = "" ;
			((CrystalDecisions.CrystalReports.Engine.TextObject)clrpt.ReportDefinition.ReportObjects["Text28"]).Text = dpcom.DocPOE;
			((CrystalDecisions.CrystalReports.Engine.TextObject)clrpt.ReportDefinition.ReportObjects["Text30"]).Text = dpcom.Shipper ;
			((CrystalDecisions.CrystalReports.Engine.TextObject)clrpt.ReportDefinition.ReportObjects["Text33"]).Text = dpcom.Quantity ;
			((CrystalDecisions.CrystalReports.Engine.TextObject)clrpt.ReportDefinition.ReportObjects["Text34"]).Text = dpcom.ShipperType ;
			((CrystalDecisions.CrystalReports.Engine.TextObject)clrpt.ReportDefinition.ReportObjects["Text35"]).Text = dpcom.TransDate ;
			((CrystalDecisions.CrystalReports.Engine.TextObject)clrpt.ReportDefinition.ReportObjects["Text36"]).Text = dpcom.DocPOD ;
			
			this.crystalReportViewer1.ReportSource = clrpt ;
		}


		private void ConstructSaleOutRpt()
		{
			System.Text.StringBuilder sb = new System.Text.StringBuilder();
			sb.Append(" select ltrim(str(a.pack_qty,20,0)) as pack_qty,a.so_code,a.item_code as item_code,b.grossweight as gross_weight,b.netweight as net_weight,");
			sb.Append(" b.item_code as item_name,b.item_name as item_desc,ltrim(str(a.item_qty,20,0)) as item_qty,");
			sb.Append(" ltrim(str(b.length,20,2))+'*'+ltrim(str(b.width,20,2))+'*'+ltrim(str(b.height,20,2))+'cm' as item_volumn,c.unit_name as unit");
			sb.Append(" from sale_so_detail a");
			sb.Append(" left join basic_item b on a.item_code=b.item_code ");
			sb.Append(" left join p_unit c on b.unit=c.unit_id");
			sb.Append( this.dpcom.PKCondition);
			sb.Append(" order by a.item_code desc");

			TJSystem.CrystalRPT.crstInvoiceOut clrpt = new TJSystem.CrystalRPT.crstInvoiceOut() ;
					
			PublicStatic.Data.dsInvoceOutNew ds = new PublicStatic.Data.dsInvoceOutNew();
			System.Data.DataTable dt = null;
			System.Data.DataRow dr = null;
			dt = TJSystem.Public.PublicStatic.db.GetDataTable(sb.ToString());

			ds.Tables["DataConstruct"].Clear();

			for(int i = 0 ; i < dt.Rows.Count ; i ++)
			{
				dr = ds.Tables["DataConstruct"].NewRow();
				dr[0] = dt.Rows[i]["item_name"].ToString();
				dr[1] = dt.Rows[i]["item_desc"].ToString();
				dr[2] = dt.Rows[i]["pack_qty"].ToString();				
				dr[3] = dt.Rows[i]["item_volumn"].ToString();
				dr[4] = dt.Rows[i]["gross_weight"].ToString();
				dr[5] = dt.Rows[i]["net_weight"].ToString();
				dr[6] = dt.Rows[i]["item_qty"].ToString();
				dr[7] = dt.Rows[i]["unit"].ToString();
				ds.Tables["DataConstruct"].Rows.InsertAt(dr,0) ;
			}
			ds.Tables["DataConstruct"].EndInit() ;
			ds.Tables["DataConstruct"].EndLoadData() ;
			clrpt.Section4.Height = 7500 - (350 * dt.Rows.Count);

			int dd = ds.Tables["DataConstruct"].Rows.Count;

			sb.Remove(0,sb.ToString().Length);
			sb.Append("select sum(a.pack_qty) as pack_qty,ltrim(str(sum(a.pack_qty*b.grossweight),20,2)) as gross_weight, ");
			sb.Append(" ltrim(str(sum(b.netweight*a.pack_qty),20,2)) as net_weight,");
			sb.Append(" ltrim(str(sum(a.item_qty))) as item_qty, ");
			sb.Append(" ltrim(str(sum(a.pack_qty*b.length*b.width*b.height/1000000),20,2)) as volumns");
			sb.Append(" from sale_so_detail a ");
			sb.Append(" left join basic_item b on a.item_code=b.item_code ");
			sb.Append(this.dpcom.PKCondition);

			dt = TJSystem.Public.PublicStatic.db.GetDataTable(sb.ToString());
			
			clrpt.SetDataSource(ds) ;

			if(dt.Rows.Count == 1)
			{
				((CrystalDecisions.CrystalReports.Engine.TextObject)clrpt.ReportDefinition.ReportObjects["Text21"]).Text = Convert.ToDouble(dt.Rows[0]["pack_qty"].ToString()).ToString() ;
				((CrystalDecisions.CrystalReports.Engine.TextObject)clrpt.ReportDefinition.ReportObjects["Text15"]).Text = Convert.ToDouble(dt.Rows[0]["item_qty"].ToString()).ToString() ;
				((CrystalDecisions.CrystalReports.Engine.TextObject)clrpt.ReportDefinition.ReportObjects["Text23"]).Text = Convert.ToDouble(dt.Rows[0]["gross_weight"].ToString()).ToString("f2") ;
				((CrystalDecisions.CrystalReports.Engine.TextObject)clrpt.ReportDefinition.ReportObjects["Text24"]).Text = Convert.ToDouble(dt.Rows[0]["net_weight"].ToString()).ToString("f2") ;
				((CrystalDecisions.CrystalReports.Engine.TextObject)clrpt.ReportDefinition.ReportObjects["Text22"]).Text = Convert.ToDouble(dt.Rows[0]["volumns"].ToString()).ToString("f2") + " CBM";
			}
		
			((CrystalDecisions.CrystalReports.Engine.TextObject)clrpt.ReportDefinition.ReportObjects["Text13"]).Text = dpcom.DocNO ;
			((CrystalDecisions.CrystalReports.Engine.TextObject)clrpt.ReportDefinition.ReportObjects["Text14"]).Text = dpcom.DocSaleNO ;
			((CrystalDecisions.CrystalReports.Engine.TextObject)clrpt.ReportDefinition.ReportObjects["Text17"]).Text = dpcom.DocLCNO ;
			((CrystalDecisions.CrystalReports.Engine.TextObject)clrpt.ReportDefinition.ReportObjects["Text11"]).Text = dpcom.DocDate ;
			((CrystalDecisions.CrystalReports.Engine.TextObject)clrpt.ReportDefinition.ReportObjects["Text8"]).Text = TJSystem.Public.PublicStatic.CompanyName;
			((CrystalDecisions.CrystalReports.Engine.TextObject)clrpt.ReportDefinition.ReportObjects["Text31"]).Text = TJSystem.Public.PublicStatic.LoginUserName;
			
			this.crystalReportViewer1.ReportSource = clrpt ;
		}

		private void ConstructSaleFormRpt()
		{
			System.Text.StringBuilder sb = new System.Text.StringBuilder();
			sb.Append("select item_code,item_name + item_desc as item_name,item_qty,unit_price as unit_price,ltrim(str(item_qty*unit_price,20,2)) as price_total from sale_so_detail");
			sb.Append( this.dpcom.PKCondition);
			sb.Append(" order by item_code desc");

			TJSystem.CrystalRPT.crstSaleForm clrpt = new TJSystem.CrystalRPT.crstSaleForm() ;
						
			TJSystem.Data.dsSaleForm ds = new TJSystem.Data.dsSaleForm() ;
			System.Data.DataTable dt = null;
			System.Data.DataRow dr = null;
			dt = TJSystem.Public.PublicStatic.db.GetDataTable(sb.ToString());

			ds.Tables["DataConstructor"].Clear();

			double dblqty = 0;
			double dblprice = 0;
			for(int i = 0 ; i < dt.Rows.Count ; i ++)
			{
				dr = ds.Tables["DataConstructor"].NewRow();
				dr[0] = dt.Rows[i]["item_name"].ToString();				
				dr[1] = dt.Rows[i]["item_qty"].ToString();
				dr[2] = "US$" + dt.Rows[i]["unit_price"].ToString();
				dr[3] = "US$" + dt.Rows[i]["price_total"].ToString();
				ds.Tables["DataConstructor"].Rows.InsertAt(dr,0) ;
				if(TJSystem.Public.PublicStatic.IsNumDouble(dt.Rows[i]["item_qty"].ToString()))
				{
					dblqty += Convert.ToDouble(dt.Rows[i]["item_qty"].ToString());
				}
				else
				{
					dblqty += 0;
				}
				if(TJSystem.Public.PublicStatic.IsNumDouble(dt.Rows[i]["price_total"].ToString()))
				{
					dblprice += Convert.ToDouble(dt.Rows[i]["price_total"].ToString());
				}
				else
				{
					dblprice += 0;
				}
			}
			ds.Tables["DataConstructor"].EndInit() ;
			ds.Tables["DataConstructor"].EndLoadData() ;

			int dd = ds.Tables["DataConstructor"].Rows.Count;
			
			clrpt.SetDataSource(ds) ;

			sb.Remove(0,sb.Length);
			sb.Append("select a.settlementType,a.port_departure,c.port_name as PORT_FROM,a.transtype,");
			sb.Append(" a.arrivecountry,d.country_name,a.so_date,e.trans_name,b.paymode_name");
			sb.Append(" from sale_so_master a");
			sb.Append(" left join p_paymode b on a.settlementType=b.paymode_id");
			sb.Append(" left join p_port c on c.port_code=a.port_departure");
			sb.Append(" left join p_country d on d.country_code=a.arrivecountry");
			sb.Append(" left join p_transtype e on e.trans_code=a.transtype");
			sb.Append(" where a.so_code=");
			sb.Append("'");
			sb.Append(dpcom.DocSaleNO);
			sb.Append("'");
			dt = TJSystem.Public.PublicStatic.db.GetDataTable(sb.ToString());
			if (dt.Rows.Count == 1)
			{						
				((CrystalDecisions.CrystalReports.Engine.TextObject)clrpt.ReportDefinition.ReportObjects["Text37"]).Text = "FOB " + dt.Rows[0]["PORT_FROM"].ToString() ;
				((CrystalDecisions.CrystalReports.Engine.TextObject)clrpt.ReportDefinition.ReportObjects["Text18"]).Text = dt.Rows[0]["PORT_FROM"].ToString() ;
				((CrystalDecisions.CrystalReports.Engine.TextObject)clrpt.ReportDefinition.ReportObjects["Text23"]).Text = dt.Rows[0]["country_name"].ToString() ;
				((CrystalDecisions.CrystalReports.Engine.TextObject)clrpt.ReportDefinition.ReportObjects["Text24"]).Text = dt.Rows[0]["trans_name"].ToString() ;
				((CrystalDecisions.CrystalReports.Engine.TextObject)clrpt.ReportDefinition.ReportObjects["Text22"]).Text = dt.Rows[0]["paymode_name"].ToString() ;
			}
			((CrystalDecisions.CrystalReports.Engine.TextObject)clrpt.ReportDefinition.ReportObjects["Text9"]).Text = dpcom.DocSaleNO ;
			((CrystalDecisions.CrystalReports.Engine.TextObject)clrpt.ReportDefinition.ReportObjects["Text11"]).Text = dpcom.DocDate ;
			((CrystalDecisions.CrystalReports.Engine.TextObject)clrpt.ReportDefinition.ReportObjects["Text13"]).Text = dpcom.DocSaleTo ;
			((CrystalDecisions.CrystalReports.Engine.TextObject)clrpt.ReportDefinition.ReportObjects["Text30"]).Text = dpcom.Remark ;
			((CrystalDecisions.CrystalReports.Engine.TextObject)clrpt.ReportDefinition.ReportObjects["Text32"]).Text = dpcom.DocSaleTo ;
			((CrystalDecisions.CrystalReports.Engine.TextObject)clrpt.ReportDefinition.ReportObjects["Text27"]).Text = dblqty.ToString() + "pcs";
			((CrystalDecisions.CrystalReports.Engine.TextObject)clrpt.ReportDefinition.ReportObjects["Text29"]).Text = "USD " + dblprice.ToString("f2") ;
//			((CrystalDecisions.CrystalReports.Engine.TextObject)clrpt.ReportDefinition.ReportObjects["Text5"]).Text = TJSystem.Public.PublicStatic.CompanyName;
			
			this.crystalReportViewer1.ReportSource = clrpt ;
		}

		private void ConstructSaleTermRpt()
		{
			System.Text.StringBuilder sb = new System.Text.StringBuilder();
			sb.Append("select b.unit_name_cn as item_unit,a.item_code,a.item_name + '\r\n ' + a.item_desc as item_desc,e.purchaseprice as item_pricev,ltrim(str(a.item_qty,20,0)) as item_qty,'￥' + ltrim(str(e.purchaseprice,20,2)) as item_price,");
			sb.Append(" a.item_qty*e.purchaseprice as item_priceTv,'￥' + ltrim(str(a.item_qty*e.purchaseprice,20,2)) as item_priceT,d.term_desc,a.unit_price ");
			sb.Append(" from sale_so_detail a");
			sb.Append(" left join p_unit b on a.unit=b.unit_id");
			sb.Append(" left join sale_so_master c on a.so_code=c.so_code");
			sb.Append(" left join basic_docterm d on c.saleterm_id=d.term_id");
			sb.Append(" left join basic_item e on e.item_code=a.item_code");
			sb.Append( this.dpcom.PKCondition);
			sb.Append(" order by a.item_code desc");

			TJSystem.CrystalRPT.CommonConfig cfg = new CommonConfig();
			TJSystem.CrystalRPT.frmConfigSaleTerm frm = new frmConfigSaleTerm(cfg);
			frm.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			frm.ShowDialog();
            	
			TJSystem.CrystalRPT.crstSaleTerm clrpt = new TJSystem.CrystalRPT.crstSaleTerm() ;
						
			TJSystem.Data.dsSaleTerm ds = new TJSystem.Data.dsSaleTerm() ;
			System.Data.DataTable dt = null;
			System.Data.DataRow dr = null;
			dt = TJSystem.Public.PublicStatic.db.GetDataTable(sb.ToString());

			ds.Tables["DataConstructor"].Clear();

			double dblqty = 0;
			double dblprice = 0;
			for(int i = 0 ; i < dt.Rows.Count ; i ++)
			{
				dr = ds.Tables["DataConstructor"].NewRow();
				dr[0] = dt.Rows[i]["item_code"].ToString();				
				dr[1] = dt.Rows[i]["item_desc"].ToString();
				dr[2] = dt.Rows[i]["item_unit"].ToString();
				dr[3] = dt.Rows[i]["item_qty"].ToString();
				dr[4] = dt.Rows[i]["item_price"].ToString();
				dr[5] = dt.Rows[i]["item_priceT"].ToString();
				dr[6] = dt.Rows[i]["term_desc"].ToString();
				ds.Tables["DataConstructor"].Rows.InsertAt(dr,0) ;
				if(TJSystem.Public.PublicStatic.IsNumDouble(dr[3].ToString()))
				{
					dblqty += Convert.ToDouble(dr[3].ToString());
				}
				else
				{
					dblqty += 0;
				}
				if(TJSystem.Public.PublicStatic.IsNumDouble(dt.Rows[i]["item_priceTv"].ToString()))
				{
					dblprice += Convert.ToDouble(dt.Rows[i]["item_priceTv"].ToString());
				}
				else
				{
					dblprice +=  0;
				}
			}
			ds.Tables["DataConstructor"].EndInit() ;
			ds.Tables["DataConstructor"].EndLoadData() ;

			int dd = ds.Tables["DataConstructor"].Rows.Count;
			if (dt.Rows.Count < 6)
			{
				clrpt.Section4.Height = (350 * 6) - 350 * dt.Rows.Count + 405;
			}
			clrpt.SetDataSource(ds) ;

			string sql = "select b.term_desc from sale_so_master a left join basic_docterm b on a.saleTerm_ID=b.term_id where a.so_code='";
			sql += dpcom.DocSaleNO;
			sql += "'";
			System.Data.DataTable dttmp = TJSystem.Public.PublicStatic.db.GetDataTable(sql);
			if(dttmp.Rows.Count == 1)
			{
//				((CrystalDecisions.CrystalReports.Engine.TextObject)clrpt.ReportDefinition.ReportObjects["Text28"]).Text = dttmp.Rows[0][0].ToString() ;
			}
		
			((CrystalDecisions.CrystalReports.Engine.TextObject)clrpt.ReportDefinition.ReportObjects["Text16"]).Text = dpcom.DocSaleNO ;
			((CrystalDecisions.CrystalReports.Engine.TextObject)clrpt.ReportDefinition.ReportObjects["Text17"]).Text = dpcom.DocSaleNO ;
			((CrystalDecisions.CrystalReports.Engine.TextObject)clrpt.ReportDefinition.ReportObjects["Text14"]).Text = TJSystem.Public.PublicStatic.CompanyName;
			((CrystalDecisions.CrystalReports.Engine.TextObject)clrpt.ReportDefinition.ReportObjects["Text15"]).Text = cfg.CfgSaleTermBuyFrom;//dpcom.DocSaleTo ;
			((CrystalDecisions.CrystalReports.Engine.TextObject)clrpt.ReportDefinition.ReportObjects["Text29"]).Text = Convert.ToDateTime(dpcom.DocDate).ToLongDateString();
			((CrystalDecisions.CrystalReports.Engine.TextObject)clrpt.ReportDefinition.ReportObjects["Text19"]).Text = dblqty.ToString() ;
			((CrystalDecisions.CrystalReports.Engine.TextObject)clrpt.ReportDefinition.ReportObjects["Text20"]).Text ="￥" + dblprice.ToString("f2") ;
			((CrystalDecisions.CrystalReports.Engine.TextObject)clrpt.ReportDefinition.ReportObjects["Text28"]).Text = TJSystem.Public.PublicStatic.DaXieMoney(dblprice,true) ;

			this.crystalReportViewer1.ReportSource = clrpt ;
		}

		private void ConstructSaleConfirmRpt()
		{
			System.Text.StringBuilder sb = new System.Text.StringBuilder();
			sb.Append("select e.port_name as DESTPORTNAME,b.unit_name_cn as item_unit,a.item_code,a.item_name + '\r\n ' + a.item_desc as item_desc,ltrim(str(a.item_qty)) as item_qty,");
			sb.Append(" 'US$' + ltrim(str(a.unit_price,20,2)) as item_price,");
			sb.Append(" a.item_qty*a.unit_price as item_priceTv,'US$' + ltrim(str(a.item_qty*a.unit_price,20,2)) as item_priceT,d.term_desc ");
			sb.Append(" from sale_so_detail a");
			sb.Append(" left join p_unit b on a.unit=b.unit_id");
			sb.Append(" left join sale_so_master c on a.so_code=c.so_code");
			sb.Append(" left join basic_docterm d on c.saleconf_id=d.term_id");
			sb.Append(" left join p_port f on c.destport=f.port_code ");
			sb.Append(" left join p_port e on c.port_departure=e.port_code ");
			sb.Append( this.dpcom.PKCondition);
			sb.Append(" order by item_code desc");

			TJSystem.CrystalRPT.crstSaleConfirm2 clrpt = new TJSystem.CrystalRPT.crstSaleConfirm2() ;
						
			TJSystem.Data.dsSaleTerm ds = new TJSystem.Data.dsSaleTerm() ;
			System.Data.DataTable dt = null;
			System.Data.DataRow dr = null;
			dt = TJSystem.Public.PublicStatic.db.GetDataTable(sb.ToString());

			ds.Tables["DataConstructor"].Clear();

			double dblqty = 0;
			double dblprice = 0;
			for(int i = 0 ; i < dt.Rows.Count ; i ++)
			{
				dr = ds.Tables["DataConstructor"].NewRow();
				dr[0] = dt.Rows[i]["item_code"].ToString();				
				dr[1] = dt.Rows[i]["item_desc"].ToString();
				dr[2] = dt.Rows[i]["item_unit"].ToString();
				dr[3] = dt.Rows[i]["item_qty"].ToString();
				dr[4] = dt.Rows[i]["item_price"].ToString();
				dr[5] = dt.Rows[i]["item_priceT"].ToString();
				dr[6] = dt.Rows[i]["term_desc"].ToString();
				ds.Tables["DataConstructor"].Rows.InsertAt(dr,0) ;
				if(TJSystem.Public.PublicStatic.IsNumDouble(dr[3].ToString()))
				{
					dblqty += Convert.ToDouble(dr[3].ToString());
				}
				else
				{
					dblqty += 0;
				}
				if(TJSystem.Public.PublicStatic.IsNumDouble(dt.Rows[i]["item_priceTv"].ToString()))
				{
					dblprice += Convert.ToDouble(dt.Rows[i]["item_priceTv"].ToString());
				}
				else
				{
					dblprice += 0;
				}
			}
			ds.Tables["DataConstructor"].EndInit() ;
			ds.Tables["DataConstructor"].EndLoadData() ;

			int dd = ds.Tables["DataConstructor"].Rows.Count;
			
			clrpt.SetDataSource(ds) ;
			if (dt.Rows.Count > 0)
			{
				((CrystalDecisions.CrystalReports.Engine.TextObject)clrpt.ReportDefinition.ReportObjects["Text28"]).Text = "FOB " + dt.Rows[0]["DESTPORTNAME"].ToString();
			}
			
			((CrystalDecisions.CrystalReports.Engine.TextObject)clrpt.ReportDefinition.ReportObjects["Text19"]).Text = dblqty.ToString();
			((CrystalDecisions.CrystalReports.Engine.TextObject)clrpt.ReportDefinition.ReportObjects["Text20"]).Text = "US$ " + dblprice.ToString("f2");
			((CrystalDecisions.CrystalReports.Engine.TextObject)clrpt.ReportDefinition.ReportObjects["Text16"]).Text = dpcom.DocSaleNO ;
//			((CrystalDecisions.CrystalReports.Engine.TextObject)clrpt.ReportDefinition.ReportObjects["Text17"]).Text = dpcom.DocSaleNO ;
			((CrystalDecisions.CrystalReports.Engine.TextObject)clrpt.ReportDefinition.ReportObjects["Text35"]).Text = TJSystem.Public.PublicStatic.CompanyName;
			
			sb.Remove(0,sb.ToString().Length);
			sb.Append(" select b.term_desc,a.client_id,a.deliverydate,a.remark,");
			sb.Append(" c.address,c.tel,c.fax,c.email,c.client_name,");
			sb.Append(" d.country_name,e.paymode_name,f.port_name");
			sb.Append(" from sale_so_master a ");
			sb.Append(" left join basic_docterm b on a.saleConf_ID=b.term_id");
			sb.Append(" left join basic_client c on a.client_id=c.client_id");
			sb.Append(" left join p_country d on a.arrivecountry=d.country_code");
			sb.Append(" left join p_paymode e on e.paymode_id=a.settlementtype");
			sb.Append(" left join p_port f on f.port_code=a.port_departure");
			sb.Append(" where a.so_code=");
			sb.Append("'");
			sb.Append(dpcom.DocSaleNO);
			sb.Append("'");

			System.Data.DataTable dtclient = TJSystem.Public.PublicStatic.db.GetDataTable(sb.ToString());
			if(dtclient.Rows.Count == 1)
			{
				string buyer = "";
				string str = dtclient.Rows[0]["term_desc"].ToString();
//				((CrystalDecisions.CrystalReports.Engine.TextObject)clrpt.ReportDefinition.ReportObjects["Text28"]).Text = str;
				((CrystalDecisions.CrystalReports.Engine.TextObject)clrpt.ReportDefinition.ReportObjects["Text30"]).Text = dtclient.Rows[0]["deliverydate"].ToString();
				((CrystalDecisions.CrystalReports.Engine.TextObject)clrpt.ReportDefinition.ReportObjects["Text49"]).Text = dtclient.Rows[0]["remark"].ToString();
				((CrystalDecisions.CrystalReports.Engine.TextObject)clrpt.ReportDefinition.ReportObjects["Text45"]).Text = dtclient.Rows[0]["address"].ToString();
				buyer += dtclient.Rows[0]["tel"].ToString();
				buyer += ";  Buyer's Fax:";
				buyer += dtclient.Rows[0]["fax"].ToString();
				buyer += ";  E-mail:";
				buyer += dtclient.Rows[0]["email"].ToString();
				((CrystalDecisions.CrystalReports.Engine.TextObject)clrpt.ReportDefinition.ReportObjects["Text42"]).Text = buyer;
//				((CrystalDecisions.CrystalReports.Engine.TextObject)clrpt.ReportDefinition.ReportObjects["Text42"]).Text = dtclient.Rows[0]["tel"].ToString();
				((CrystalDecisions.CrystalReports.Engine.TextObject)clrpt.ReportDefinition.ReportObjects["Text43"]).Text = dtclient.Rows[0]["fax"].ToString();
				((CrystalDecisions.CrystalReports.Engine.TextObject)clrpt.ReportDefinition.ReportObjects["Text44"]).Text = dtclient.Rows[0]["email"].ToString();
				((CrystalDecisions.CrystalReports.Engine.TextObject)clrpt.ReportDefinition.ReportObjects["Text37"]).Text = dtclient.Rows[0]["client_name"].ToString();
				((CrystalDecisions.CrystalReports.Engine.TextObject)clrpt.ReportDefinition.ReportObjects["Text33"]).Text = dtclient.Rows[0]["country_name"].ToString();
				((CrystalDecisions.CrystalReports.Engine.TextObject)clrpt.ReportDefinition.ReportObjects["Text34"]).Text = dtclient.Rows[0]["paymode_name"].ToString();
				((CrystalDecisions.CrystalReports.Engine.TextObject)clrpt.ReportDefinition.ReportObjects["Text32"]).Text = dtclient.Rows[0]["port_name"].ToString();
			}

			sb.Remove(0,sb.ToString().Length);
			sb.Append(" select address,tel1,fax1,email1 from basic_company ");
			sb.Append(" where company_id=");
			sb.Append("'");
			sb.Append(TJSystem.Public.PublicStatic.CompanyID);
			sb.Append("'");

			System.Data.DataTable dtcmp = TJSystem.Public.PublicStatic.db.GetDataTable(sb.ToString());
			if(dtcmp.Rows.Count == 1)
			{
				string company = "";
				company += dtcmp.Rows[0]["tel1"].ToString();
				company += ";  Fax:";
				company += dtcmp.Rows[0]["fax1"].ToString();
				company += ";  E-mail:";
				company += dtcmp.Rows[0]["email1"].ToString();
				((CrystalDecisions.CrystalReports.Engine.TextObject)clrpt.ReportDefinition.ReportObjects["Text14"]).Text = dtcmp.Rows[0]["address"].ToString();
				((CrystalDecisions.CrystalReports.Engine.TextObject)clrpt.ReportDefinition.ReportObjects["Text15"]).Text = company;
//				((CrystalDecisions.CrystalReports.Engine.TextObject)clrpt.ReportDefinition.ReportObjects["Text15"]).Text = dtcmp.Rows[0]["tel1"].ToString();
//				((CrystalDecisions.CrystalReports.Engine.TextObject)clrpt.ReportDefinition.ReportObjects["Text17"]).Text = dtcmp.Rows[0]["fax1"].ToString();
//				((CrystalDecisions.CrystalReports.Engine.TextObject)clrpt.ReportDefinition.ReportObjects["Text37"]).Text = dtcmp.Rows[0]["email1"].ToString();
			}

			this.crystalReportViewer1.ReportSource = clrpt ;
		}

		private void ConstructSalePackRpt()
		{
			string eng = null;
			string strall = null;
			double packqty = 0;
			System.Text.StringBuilder sb = new System.Text.StringBuilder();
			sb.Append("select ltrim(str(a.pack_qty,20,0)) as pack_qty,a.so_code,a.item_code as item_code,ltrim(str(b.grossweight,20,2)) as gross_weight,");
			sb.Append(" ltrim(str(b.netweight,20,2)) as net_weight,a.item_code+' '+b.item_name as item_desc,ltrim(str(a.item_qty,20,0)) as item_qty,");
			sb.Append(" ltrim(str(b.length,20,2))+'*'+ltrim(str(b.width,200,2))+'*'+ltrim(str(b.height,20,2)) + 'cm' as volumns");
			sb.Append(" from sale_so_detail a");
			sb.Append(" left join basic_item b on a.item_code=b.item_code");
			sb.Append( this.dpcom.PKCondition);
			sb.Append(" order by item_code desc");

			TJSystem.CrystalRPT.crstSOPack clrpt = new TJSystem.CrystalRPT.crstSOPack() ;
						
			TJSystem.Data.dsSalePackage ds = new TJSystem.Data.dsSalePackage() ;
			System.Data.DataTable dt = null;
			System.Data.DataRow dr = null;
			dt = TJSystem.Public.PublicStatic.db.GetDataTable(sb.ToString());

			ds.Tables["DataConstructor"].Clear();

			for(int i = 0 ; i < dt.Rows.Count ; i ++)
			{
				dr = ds.Tables["DataConstructor"].NewRow();
				dr[0] = dt.Rows[i]["pack_qty"].ToString();				
				dr[1] = dt.Rows[i]["item_desc"].ToString();
				dr[2] = dt.Rows[i]["item_qty"].ToString();
				dr[3] = dt.Rows[i]["gross_weight"].ToString();
				dr[4] = dt.Rows[i]["net_weight"].ToString();
				dr[5] = dt.Rows[i]["volumns"].ToString();
				ds.Tables["DataConstructor"].Rows.InsertAt(dr,0) ;
			}
			ds.Tables["DataConstructor"].EndInit() ;
			ds.Tables["DataConstructor"].EndLoadData() ;

			int dd = ds.Tables["DataConstructor"].Rows.Count;

			sb.Remove(0,sb.ToString().Length);
			sb.Append("select ltrim(str(sum(a.pack_qty),20,0)) as pack_qty,ltrim(str(sum(a.pack_qty*b.grossweight),20,2)) as gross_weight, ");
			sb.Append(" ltrim(str(sum(b.netweight*a.pack_qty),20,2)) as net_weight,");
			sb.Append(" ltrim(str(sum(a.item_qty),20,0)) as item_qty, ");
			sb.Append(" ltrim(str(sum(a.pack_qty*b.length*b.width*b.height/1000000),20,2)) as volumns");
			sb.Append(" from sale_so_detail a ");
			sb.Append(" left join basic_item b on a.item_code=b.item_code ");
			sb.Append(this.dpcom.PKCondition);

			dt = TJSystem.Public.PublicStatic.db.GetDataTable(sb.ToString());
			
			
			clrpt.SetDataSource(ds) ;
		
			if(dt.Rows.Count == 1)
			{
				((CrystalDecisions.CrystalReports.Engine.TextObject)clrpt.ReportDefinition.ReportObjects["Text25"]).Text = dt.Rows[0]["pack_qty"].ToString() ;
				((CrystalDecisions.CrystalReports.Engine.TextObject)clrpt.ReportDefinition.ReportObjects["Text18"]).Text = dt.Rows[0]["item_qty"].ToString() ;
				((CrystalDecisions.CrystalReports.Engine.TextObject)clrpt.ReportDefinition.ReportObjects["Text19"]).Text = dt.Rows[0]["gross_weight"].ToString() ;
				((CrystalDecisions.CrystalReports.Engine.TextObject)clrpt.ReportDefinition.ReportObjects["Text20"]).Text = dt.Rows[0]["net_weight"].ToString() ;
				((CrystalDecisions.CrystalReports.Engine.TextObject)clrpt.ReportDefinition.ReportObjects["Text21"]).Text = dt.Rows[0]["volumns"].ToString() + " CBM";
				strall = "SAY TOTAL PACKED IN ";
				packqty = Convert.ToDouble(dt.Rows[0]["pack_qty"].ToString().Trim());
				strall += new PublicStatic.Public.Number2English().NumberToString(packqty).ToUpper();
				strall += "(";
				strall += packqty.ToString();
				strall += ") CARTONS ONLY.";
				((CrystalDecisions.CrystalReports.Engine.TextObject)clrpt.ReportDefinition.ReportObjects["Text23"]).Text = strall;
			}

			((CrystalDecisions.CrystalReports.Engine.TextObject)clrpt.ReportDefinition.ReportObjects["Text11"]).Text = this.dpcom.DocNO;
			((CrystalDecisions.CrystalReports.Engine.TextObject)clrpt.ReportDefinition.ReportObjects["Text13"]).Text = this.dpcom.DocDate;
			((CrystalDecisions.CrystalReports.Engine.TextObject)clrpt.ReportDefinition.ReportObjects["Text15"]).Text = this.dpcom.DocSaleTo;
			((CrystalDecisions.CrystalReports.Engine.TextObject)clrpt.ReportDefinition.ReportObjects["Text17"]).Text = this.dpcom.MaiTou;
			((CrystalDecisions.CrystalReports.Engine.TextObject)clrpt.ReportDefinition.ReportObjects["Text7"]).Text = TJSystem.Public.PublicStatic.CompanyName;
			((CrystalDecisions.CrystalReports.Engine.TextObject)clrpt.ReportDefinition.ReportObjects["Text17"]).Text = this.dpcom.DocNO;

			sb.Remove(0,sb.ToString().Length);
			sb.Append("select company_name,address from basic_company where company_id =");
			sb.Append("'");
			sb.Append(TJSystem.Public.PublicStatic.CompanyID);
			sb.Append("'");
			dt = TJSystem.Public.PublicStatic.db.GetDataTable(sb.ToString());
			if (dt.Rows.Count > 0)
			{
				((CrystalDecisions.CrystalReports.Engine.TextObject)clrpt.ReportDefinition.ReportObjects["Text27"]).Text = dt.Rows[0]["company_name"].ToString().Trim();
				((CrystalDecisions.CrystalReports.Engine.TextObject)clrpt.ReportDefinition.ReportObjects["Text28"]).Text = dt.Rows[0]["address"].ToString().Trim();
			}
			else
			{
				((CrystalDecisions.CrystalReports.Engine.TextObject)clrpt.ReportDefinition.ReportObjects["Text27"]).Text = company_eng;
				((CrystalDecisions.CrystalReports.Engine.TextObject)clrpt.ReportDefinition.ReportObjects["Text28"]).Text = this.address;
			}

			this.crystalReportViewer1.ReportSource = clrpt ;
		}

		private void ConstructSaleBalanceRpt()
		{
			System.Text.StringBuilder sb = new System.Text.StringBuilder();
			sb.Append(" select po_amount,po_taxdiscount,po_insideamount,po_manageamount,po_insidefreight,client_name,arrivecountry,");
			sb.Append(" port_departure,destport,priceterm_dest,deliverydate,settlementtype,currency,sale_amount,sale_fobamount,");
			sb.Append(" sale_freightamount,sale_insurance,sale_brightcommision,sale_darkcommision,status,remark,so_code from sale_balance ");

			System.Data.DataTable dt = TJSystem.Public.PublicStatic.db.GetDataTable(sb.ToString());

			TJSystem.CrystalRPT.crstBalance clrpt = new TJSystem.CrystalRPT.crstBalance() ;
			((CrystalDecisions.CrystalReports.Engine.TextObject)clrpt.ReportDefinition.ReportObjects["Text1"]).Text = TJSystem.Public.PublicStatic.CompanyName;
			((CrystalDecisions.CrystalReports.Engine.TextObject)clrpt.ReportDefinition.ReportObjects["Text12"]).Text = dt.Rows[0]["so_code"].ToString();
			((CrystalDecisions.CrystalReports.Engine.TextObject)clrpt.ReportDefinition.ReportObjects["Text13"]).Text = dt.Rows[0]["so_code"].ToString();
			((CrystalDecisions.CrystalReports.Engine.TextObject)clrpt.ReportDefinition.ReportObjects["Text14"]).Text = dt.Rows[0]["client_name"].ToString();
			((CrystalDecisions.CrystalReports.Engine.TextObject)clrpt.ReportDefinition.ReportObjects["Text15"]).Text = dt.Rows[0]["arrivecountry"].ToString();
			((CrystalDecisions.CrystalReports.Engine.TextObject)clrpt.ReportDefinition.ReportObjects["Text16"]).Text = dt.Rows[0]["priceterm_dest"].ToString();
			((CrystalDecisions.CrystalReports.Engine.TextObject)clrpt.ReportDefinition.ReportObjects["Text17"]).Text = dt.Rows[0]["port_departure"].ToString();
			((CrystalDecisions.CrystalReports.Engine.TextObject)clrpt.ReportDefinition.ReportObjects["Text18"]).Text = dt.Rows[0]["deliverydate"].ToString();
			((CrystalDecisions.CrystalReports.Engine.TextObject)clrpt.ReportDefinition.ReportObjects["Text19"]).Text = dt.Rows[0]["destport"].ToString();
			((CrystalDecisions.CrystalReports.Engine.TextObject)clrpt.ReportDefinition.ReportObjects["Text20"]).Text = dt.Rows[0]["settlementtype"].ToString();
			((CrystalDecisions.CrystalReports.Engine.TextObject)clrpt.ReportDefinition.ReportObjects["Text37"]).Text = dt.Rows[0]["currency"].ToString();
			((CrystalDecisions.CrystalReports.Engine.TextObject)clrpt.ReportDefinition.ReportObjects["Text38"]).Text = "";
			((CrystalDecisions.CrystalReports.Engine.TextObject)clrpt.ReportDefinition.ReportObjects["Text39"]).Text = dt.Rows[0]["sale_freightamount"].ToString();
			((CrystalDecisions.CrystalReports.Engine.TextObject)clrpt.ReportDefinition.ReportObjects["Text40"]).Text = dt.Rows[0]["sale_insurance"].ToString();
			((CrystalDecisions.CrystalReports.Engine.TextObject)clrpt.ReportDefinition.ReportObjects["Text41"]).Text = dt.Rows[0]["sale_brightcommision"].ToString();
			((CrystalDecisions.CrystalReports.Engine.TextObject)clrpt.ReportDefinition.ReportObjects["Text42"]).Text = dt.Rows[0]["sale_darkcommision"].ToString();
			((CrystalDecisions.CrystalReports.Engine.TextObject)clrpt.ReportDefinition.ReportObjects["Text43"]).Text = dt.Rows[0]["sale_fobamount"].ToString();
			((CrystalDecisions.CrystalReports.Engine.TextObject)clrpt.ReportDefinition.ReportObjects["Text54"]).Text = dt.Rows[0]["sale_amount"].ToString();
			((CrystalDecisions.CrystalReports.Engine.TextObject)clrpt.ReportDefinition.ReportObjects["Text44"]).Text = dt.Rows[0]["po_amount"].ToString();
			((CrystalDecisions.CrystalReports.Engine.TextObject)clrpt.ReportDefinition.ReportObjects["Text46"]).Text = dt.Rows[0]["po_taxdiscount"].ToString();
			((CrystalDecisions.CrystalReports.Engine.TextObject)clrpt.ReportDefinition.ReportObjects["Text48"]).Text = dt.Rows[0]["po_insideamount"].ToString();
			((CrystalDecisions.CrystalReports.Engine.TextObject)clrpt.ReportDefinition.ReportObjects["Text49"]).Text = dt.Rows[0]["po_manageamount"].ToString();
			((CrystalDecisions.CrystalReports.Engine.TextObject)clrpt.ReportDefinition.ReportObjects["Text50"]).Text = dt.Rows[0]["po_insidefreight"].ToString();
			((CrystalDecisions.CrystalReports.Engine.TextObject)clrpt.ReportDefinition.ReportObjects["Text68"]).Text = dt.Rows[0]["remark"].ToString();
			
			this.crystalReportViewer1.ReportSource = clrpt ;
		}

		private void ConstructSaleBalance()
		{
			string eng = null;
			string strall = null;
			double packqty = 0;
			double qty = 0;
			double volumnV = 0;
			double totalprice = 0;
			double pay = 0;
			double dbljsr = 0;
			double dbljyfy = 0;
			double dblqtfy = 0;
			double dblgsglfy = 0;
			double dbltslxy = 0;
			double dblhhcb = 0;
			string currencySrc = null;
			string freightAmount = null;
			System.Data.DataSet dsSub = null;

			
			TJSystem.CrystalRPT.crstSaleBalanceSupplier clrptsupp = new TJSystem.CrystalRPT.crstSaleBalanceSupplier() ;
			dsSub = ConstructSaleBalanceSupplier(clrptsupp);
			

			System.Text.StringBuilder sb = new System.Text.StringBuilder();
			sb.Append("select ltrim(str(a.pack_qty,20,0)) as pack_qty,a.so_code,a.unit_price as unit_price,ltrim(str(b.grossweight,20,2)) as gross_weight,");
			sb.Append(" ltrim(str(b.netweight,20,2)) as net_weight,b.item_name as item_desc,b.item_name_cn as item_name_cn,ltrim(str(a.item_qty,20,0)) as item_qty,");
			sb.Append(" ltrim(str(b.length,20,2))+'*'+ltrim(str(b.width,200,2))+'*'+ltrim(str(b.height,20,2)) + 'CM' as volumns,");
			sb.Append(" ltrim(str(a.pack_qty*b.length*b.width*b.height/1000000,20,2)) as volumnsT,");
			sb.Append(" ltrim(str(a.item_qty*a.unit_price,20,2)) as price_total");
			sb.Append(" from sale_so_detail a");
			sb.Append(" left join basic_item b on a.item_code=b.item_code");
			sb.Append( this.dpcom.PKCondition);
			sb.Append(" order by a.item_code desc");
			freightAmount = this.dpcom.Quantity;
			currencySrc = this.dpcom.ValueT;

			TJSystem.CrystalRPT.crstSaleBalance clrpt = new TJSystem.CrystalRPT.crstSaleBalance() ;
						
			PublicStatic.Data.dsBalance ds = new PublicStatic.Data.dsBalance() ;
			System.Data.DataTable dt = null;
			System.Data.DataRow dr = null;
			dt = TJSystem.Public.PublicStatic.db.GetDataTable(sb.ToString());

			ds.Tables["DataConstructor"].Clear();
			double dblTmpQty = 0;
			double dblTmpAmount = 0;
			double dblPackQty = 0;
			double dblVolumnTotal = 0;

			for(int i = 0 ; i < dt.Rows.Count ; i ++)
			{
				if (i == dt.Rows.Count - 1)
				{
					dblTmpQty += Convert.ToDouble(dt.Rows[i]["item_qty"].ToString());
					dblTmpAmount += Convert.ToDouble(dt.Rows[i]["price_total"].ToString());
					dblPackQty += Convert.ToDouble(dt.Rows[i]["pack_qty"].ToString());
					dblVolumnTotal += Convert.ToDouble(dt.Rows[i]["volumnsT"].ToString());
				}
				else
				{
					if (dt.Rows[i]["item_name_cn"].ToString().Trim().Equals(dt.Rows[i+1]["item_name_cn"].ToString().Trim()))
					{
						dblTmpQty += Convert.ToDouble(dt.Rows[i]["item_qty"].ToString());
						dblTmpAmount += Convert.ToDouble(dt.Rows[i]["price_total"].ToString());
						dblPackQty += Convert.ToDouble(dt.Rows[i]["pack_qty"].ToString());
						dblVolumnTotal += Convert.ToDouble(dt.Rows[i]["volumnsT"].ToString());

						continue;
					}
					else
					{
						dblTmpQty += Convert.ToDouble(dt.Rows[i]["item_qty"].ToString());
						dblTmpAmount += Convert.ToDouble(dt.Rows[i]["price_total"].ToString());
						dblPackQty += Convert.ToDouble(dt.Rows[i]["pack_qty"].ToString());
						dblVolumnTotal += Convert.ToDouble(dt.Rows[i]["volumnsT"].ToString());
					}
				}
				dr = ds.Tables["DataConstructor"].NewRow();
				dr[0] = dt.Rows[i]["item_desc"].ToString();		
		
//				dr[1] = dt.Rows[i]["item_qty"].ToString();
//				dr[2] = "$" + dt.Rows[i]["unit_price"].ToString();
//				dr[3] = dt.Rows[i]["price_total"].ToString();
//				dr[4] = dt.Rows[i]["pack_qty"].ToString();
				dr[1] = dblTmpQty.ToString();
				dr[2] = "$" + Convert.ToDouble(dblTmpAmount/dblTmpQty).ToString("f2");
				dr[3] = dblTmpAmount.ToString();
				dr[4] = dblPackQty.ToString();

				dr[5] = dt.Rows[i]["gross_weight"].ToString()+"kgs/"+ dt.Rows[i]["net_weight"].ToString()+"kgs";
				dr[6] = dt.Rows[i]["volumns"].ToString();

//				dr[7] = dt.Rows[i]["volumnsT"].ToString() + "CBM";
				dr[7] = dblVolumnTotal.ToString("f2") + "CBM";

				ds.Tables["DataConstructor"].Rows.InsertAt(dr,0) ;

//				qty += Convert.ToDouble(dt.Rows[i]["item_qty"].ToString());
//				packqty +=  Convert.ToDouble(dt.Rows[i]["pack_qty"].ToString());
//				volumnV += Convert.ToDouble(dt.Rows[i]["volumnsT"].ToString());
//				totalprice += Convert.ToDouble(dt.Rows[i]["price_total"].ToString());
				qty += dblTmpQty;
				packqty +=  dblPackQty;
				volumnV += dblVolumnTotal;
				totalprice += dblTmpAmount;

				dblTmpQty = 0;
				dblTmpAmount = 0;
				dblPackQty = 0;
				dblVolumnTotal = 0;
			}
			ds.Tables["DataConstructor"].EndInit() ;
			ds.Tables["DataConstructor"].EndLoadData() ;

			int dd = ds.Tables["DataConstructor"].Rows.Count;

//			sb.Remove(0,sb.ToString().Length);
//			sb.Append("select ltrim(str(sum(a.pack_qty),20,0)) as pack_qty,ltrim(str(sum(a.pack_qty*b.grossweight),20,2)) as gross_weight, ");
//			sb.Append(" ltrim(str(sum(b.netweight*a.pack_qty),20,2)) as net_weight,");
//			sb.Append(" ltrim(str(sum(a.item_qty),20,0)) as item_qty, ");
//			sb.Append(" ltrim(str(sum(a.pack_qty*b.length*b.width*b.height/1000000),20,2)) as volumns");
//			sb.Append(" from sale_so_detail a ");
//			sb.Append(" left join basic_item b on a.item_code=b.item_code ");
//			sb.Append(this.dpcom.PKCondition);
//
//			dt = TJSystem.Public.PublicStatic.db.GetDataTable(sb.ToString());
			
			((CrystalDecisions.CrystalReports.Engine.TextObject)clrpt.ReportDefinition.ReportObjects["Text141"]).Text = this.dpcom.DocNO;
			((CrystalDecisions.CrystalReports.Engine.TextObject)clrpt.ReportDefinition.ReportObjects["Text147"]).Text = packqty.ToString();
			((CrystalDecisions.CrystalReports.Engine.TextObject)clrpt.ReportDefinition.ReportObjects["Text148"]).Text = "$" + totalprice.ToString();
			((CrystalDecisions.CrystalReports.Engine.TextObject)clrpt.ReportDefinition.ReportObjects["Text149"]).Text = packqty.ToString();
			((CrystalDecisions.CrystalReports.Engine.TextObject)clrpt.ReportDefinition.ReportObjects["Text150"]).Text = volumnV.ToString() + "CBM";
			((CrystalDecisions.CrystalReports.Engine.TextObject)clrpt.ReportDefinition.ReportObjects["Text121"]).Text =  "$" + totalprice.ToString();
			
			clrpt.OpenSubreport("Flags").SetDataSource(dsSub);

			
			clrpt.SetDataSource(ds) ;

			
						
			sb.Remove(0,sb.Length);
			sb.Append("select a.invoice_no,c.client_name,c.tel,c.fax,b.deliverydate,d.port_name as departure,");
			sb.Append(" e.port_name as dest,a.freight_paytype,a.lc_code,a.destination,f.trans_namecn as trans,");
			sb.Append(" b.priceterm,g.forwarder_name as fwd_name,h.contact_name,h.tel as contact_tel,a.billloading,a.FREIGHT_AMOUNT");
			sb.Append(" from SALE_WAYBILL_MASTER a");
			sb.Append(" left join sale_doc_master b on a.invoice_no=b.invoice_no");
			sb.Append(" left join basic_client c on b.client_id=c.client_id");
			sb.Append(" left join p_port d on d.port_code=a.port_departure");
			sb.Append(" left join p_port e on e.port_code=a.destport");
			sb.Append(" left join p_transtype f on f.trans_code=a.transtype");
			sb.Append(" left join basic_forwarder g on g.forwarder_id=a.shipper_id");
			sb.Append(" left join basic_forwarder_contact h on h.forwarder_id=g.forwarder_id and a.contact_id=h.contact_id");
			sb.Append(" where a.awb_code=");
			sb.Append("'");
			sb.Append(dpcom.DocNO);
			sb.Append("'");
			dt = TJSystem.Public.PublicStatic.db.GetDataTable(sb.ToString());
			if (dt.Rows.Count == 1)
			{
				((CrystalDecisions.CrystalReports.Engine.TextObject)clrpt.ReportDefinition.ReportObjects["Text18"]).Text =  dt.Rows[0]["invoice_no"].ToString();
				((CrystalDecisions.CrystalReports.Engine.TextObject)clrpt.ReportDefinition.ReportObjects["Text19"]).Text =  dt.Rows[0]["deliverydate"].ToString();
				((CrystalDecisions.CrystalReports.Engine.TextObject)clrpt.ReportDefinition.ReportObjects["Text20"]).Text =  dt.Rows[0]["departure"].ToString();
				((CrystalDecisions.CrystalReports.Engine.TextObject)clrpt.ReportDefinition.ReportObjects["Text21"]).Text =  dt.Rows[0]["dest"].ToString();
				((CrystalDecisions.CrystalReports.Engine.TextObject)clrpt.ReportDefinition.ReportObjects["Text22"]).Text =  dt.Rows[0]["destination"].ToString();
				((CrystalDecisions.CrystalReports.Engine.TextObject)clrpt.ReportDefinition.ReportObjects["Text23"]).Text =  dt.Rows[0]["priceterm"].ToString();
				((CrystalDecisions.CrystalReports.Engine.TextObject)clrpt.ReportDefinition.ReportObjects["Text24"]).Text =  dt.Rows[0]["client_name"].ToString();
				((CrystalDecisions.CrystalReports.Engine.TextObject)clrpt.ReportDefinition.ReportObjects["Text25"]).Text =  dt.Rows[0]["tel"].ToString();
				((CrystalDecisions.CrystalReports.Engine.TextObject)clrpt.ReportDefinition.ReportObjects["Text140"]).Text =  dt.Rows[0]["fax"].ToString();
				((CrystalDecisions.CrystalReports.Engine.TextObject)clrpt.ReportDefinition.ReportObjects["Text32"]).Text =  dt.Rows[0]["freight_paytype"].ToString();
				((CrystalDecisions.CrystalReports.Engine.TextObject)clrpt.ReportDefinition.ReportObjects["Text38"]).Text =  dt.Rows[0]["lc_code"].ToString();
				((CrystalDecisions.CrystalReports.Engine.TextObject)clrpt.ReportDefinition.ReportObjects["Text33"]).Text =  dt.Rows[0]["trans"].ToString();
				((CrystalDecisions.CrystalReports.Engine.TextObject)clrpt.ReportDefinition.ReportObjects["Text52"]).Text =  dt.Rows[0]["fwd_name"].ToString();
				((CrystalDecisions.CrystalReports.Engine.TextObject)clrpt.ReportDefinition.ReportObjects["Text53"]).Text =  dt.Rows[0]["contact_name"].ToString();
				((CrystalDecisions.CrystalReports.Engine.TextObject)clrpt.ReportDefinition.ReportObjects["Text54"]).Text =  dt.Rows[0]["contact_tel"].ToString();
				((CrystalDecisions.CrystalReports.Engine.TextObject)clrpt.ReportDefinition.ReportObjects["Text64"]).Text =  dt.Rows[0]["billloading"].ToString();
				((CrystalDecisions.CrystalReports.Engine.TextObject)clrpt.ReportDefinition.ReportObjects["Text134"]).Text =  dt.Rows[0]["FREIGHT_AMOUNT"].ToString();
			}

			sb.Remove(0,sb.ToString().Length);
			sb.Append(" select a.amount,a.po_code,a.supplier_id,b.supplier_name,c.contact_name");
			sb.Append(" from purchase_po_master a");
			sb.Append(" left join basic_supplier b on b.supplier_id=a.supplier_id");
			sb.Append(" left join basic_supplier_contact c on c.supplier_id=b.supplier_id and c.contact_id=a.contact_id");
			sb.Append(" where a.po_code in ");
			sb.Append("(");
			sb.Append(dpcom.DocSaleNO);
			sb.Append(")");
			dt = TJSystem.Public.PublicStatic.db.GetDataTable(sb.ToString());
			if (dt.Rows.Count > 0)
			{
				((CrystalDecisions.CrystalReports.Engine.TextObject)clrpt.ReportDefinition.ReportObjects["Text85"]).Text =  dt.Rows[0]["supplier_name"].ToString();
				((CrystalDecisions.CrystalReports.Engine.TextObject)clrpt.ReportDefinition.ReportObjects["Text86"]).Text =  dt.Rows[0]["contact_name"].ToString();
				((CrystalDecisions.CrystalReports.Engine.TextObject)clrpt.ReportDefinition.ReportObjects["Text88"]).Text =  dt.Rows[0]["amount"].ToString();
				((CrystalDecisions.CrystalReports.Engine.TextObject)clrpt.ReportDefinition.ReportObjects["Text91"]).Text =  dt.Rows[0]["po_code"].ToString();
				for (int i = 0; i < dt.Rows.Count; i++)
				{
					pay += Convert.ToDouble(dt.Rows[i]["amount"].ToString());
				}
			}
			else
			{
				MessageBox.Show("找不到采购记录，请确保有该采购单记录：" + dpcom.DocSaleNO,"提醒",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
			}
			TJSystem.CrystalRPT.CommonConfig cfg = new CommonConfig();
			cfg.sbSaleNo = dpcom.DocSaleNO;
			if (!TJSystem.Public.PublicStatic.IsNumDouble(freightAmount))
			{
				freightAmount = "0";
			}
			cfg.gnyzf = TJSystem.Public.PublicStatic.CurrencyExchangeBySrcDst(currencySrc,"001")*Convert.ToDouble(freightAmount);
			cfg.myfl = TJSystem.Public.PublicStatic.CurrencyExchangeBySrcDst(currencySrc,"001");
			frmConfigSaleBalance frm = new frmConfigSaleBalance(cfg);
			frm.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			if (System.Windows.Forms.DialogResult.OK != frm.ShowDialog())
			{
//				this.Close();
			}
			
			double dblgwfy = 0;
			double dbljlr = 0;
			((CrystalDecisions.CrystalReports.Engine.TextObject)clrpt.ReportDefinition.ReportObjects["Text35"]).Text =  cfg.xb;
			((CrystalDecisions.CrystalReports.Engine.TextObject)clrpt.ReportDefinition.ReportObjects["Text122"]).Text =  "$" + cfg.wsyj.ToString();
			((CrystalDecisions.CrystalReports.Engine.TextObject)clrpt.ReportDefinition.ReportObjects["Text123"]).Text =  "$" + cfg.bxj.ToString();
			((CrystalDecisions.CrystalReports.Engine.TextObject)clrpt.ReportDefinition.ReportObjects["Text124"]).Text =  "$" + cfg.yhsxf.ToString();
			((CrystalDecisions.CrystalReports.Engine.TextObject)clrpt.ReportDefinition.ReportObjects["Text125"]).Text =  "$" + cfg.gwyzf.ToString();
			((CrystalDecisions.CrystalReports.Engine.TextObject)clrpt.ReportDefinition.ReportObjects["Text126"]).Text =  "$" + cfg.qtgwf.ToString();
			dblgwfy = totalprice - cfg.wsyj - cfg.bxj - cfg.yhsxf - cfg.gwyzf - cfg.qtgwf;
			dbljlr = dblgwfy * cfg.myfl - cfg.gnyzf + pay/1.17*0.13 - pay - cfg.qtfy - cfg.tslx - cfg.gsglf - cfg.jyfy - cfg.dzfy;
			((CrystalDecisions.CrystalReports.Engine.TextObject)clrpt.ReportDefinition.ReportObjects["Text127"]).Text =  "￥" + Convert.ToDouble(cfg.myfl * dblgwfy).ToString("f2");
			dbljsr = Convert.ToDouble(cfg.myfl * dblgwfy);
			dbljyfy = dblqtfy = dblgsglfy = dbljsr * 0.1;
			dblhhcb = pay/totalprice;
			dbltslxy = pay * 0.1;
			((CrystalDecisions.CrystalReports.Engine.TextObject)clrpt.ReportDefinition.ReportObjects["Text128"]).Text =  dblhhcb.ToString("f2");//cfg.hhcb.ToString();
			((CrystalDecisions.CrystalReports.Engine.TextObject)clrpt.ReportDefinition.ReportObjects["Text133"]).Text =  "￥" + cfg.tslk;//Convert.ToDouble(pay/1.17*0.13).ToString("f2");
			((CrystalDecisions.CrystalReports.Engine.TextObject)clrpt.ReportDefinition.ReportObjects["Text134"]).Text =  "￥" + cfg.gnyzf.ToString();
			((CrystalDecisions.CrystalReports.Engine.TextObject)clrpt.ReportDefinition.ReportObjects["Text135"]).Text =  "￥" + dblqtfy.ToString("f2");//cfg.qtfy.ToString();
			((CrystalDecisions.CrystalReports.Engine.TextObject)clrpt.ReportDefinition.ReportObjects["Text136"]).Text =  "￥" + dbltslxy.ToString("f2");//cfg.tslx.ToString();
			((CrystalDecisions.CrystalReports.Engine.TextObject)clrpt.ReportDefinition.ReportObjects["Text137"]).Text =  "￥" + dblgsglfy.ToString("f2");//cfg.gsglf.ToString();
			((CrystalDecisions.CrystalReports.Engine.TextObject)clrpt.ReportDefinition.ReportObjects["Text139"]).Text =  "￥" + dbljyfy.ToString("f2");//cfg.jyfy.ToString();
			((CrystalDecisions.CrystalReports.Engine.TextObject)clrpt.ReportDefinition.ReportObjects["Text129"]).Text =  "￥" + pay.ToString();
			((CrystalDecisions.CrystalReports.Engine.TextObject)clrpt.ReportDefinition.ReportObjects["Text138"]).Text =  "￥" + dbljlr.ToString("f2");
			((CrystalDecisions.CrystalReports.Engine.TextObject)clrpt.ReportDefinition.ReportObjects["Text131"]).Text =  "￥" + cfg.dzfy.ToString("f2");

			this.crystalReportViewer1.ReportSource = clrpt ;
		}

		private System.Data.DataSet ConstructSaleBalanceSupplier(TJSystem.CrystalRPT.crstSaleBalanceSupplier clrpt)
		{
//			TJSystem.CrystalRPT.crstSaleBalanceSupplier clrpt = new TJSystem.CrystalRPT.crstSaleBalanceSupplier() ;
			System.Text.StringBuilder sb = new System.Text.StringBuilder();
						
			PublicStatic.Data.dsSaleBalanceSupplier ds = new PublicStatic.Data.dsSaleBalanceSupplier() ;
			System.Data.DataTable dt = null;
			System.Data.DataRow dr = null;
			
			sb.Remove(0,sb.ToString().Length);
			sb.Append(" select a.amount,a.po_code,a.supplier_id,b.supplier_name,c.contact_name,a.po_date");
			sb.Append(" from purchase_po_master a");
			sb.Append(" left join basic_supplier b on b.supplier_id=a.supplier_id");
			sb.Append(" left join basic_supplier_contact c on c.supplier_id=b.supplier_id and c.contact_id=a.contact_id");
			sb.Append(" where a.po_code in ");
			sb.Append("(");
			sb.Append(dpcom.DocSaleNO);
			sb.Append(")");
			dt = TJSystem.Public.PublicStatic.db.GetDataTable(sb.ToString());

			ds.Tables["DataConstructorSupp"].Clear();

			for(int i = 0 ; i < dt.Rows.Count ; i ++)
			{
				dr = ds.Tables["DataConstructorSupp"].NewRow();
				dr[0] = dt.Rows[i]["supplier_name"].ToString();
				dr[1] = dt.Rows[i]["contact_name"].ToString();
				dr[2] = "";
				dr[3] = dt.Rows[i]["amount"].ToString();
				dr[4] = dt.Rows[i]["po_date"].ToString();
				dr[5] = dt.Rows[i]["po_code"].ToString();

				ds.Tables["DataConstructorSupp"].Rows.InsertAt(dr,0) ;
			}

			ds.Tables["DataConstructorSupp"].EndInit() ;
			ds.Tables["DataConstructorSupp"].EndLoadData() ;

			clrpt.SetDataSource(ds) ;

			return ds;
		}

		private void ConstrctBaoGuanDanRpt()
		{
			double gross_wei = 0;
			double net_wei = 0;
			double dblitemqty = 0;
			string tmp = "";
			double dblTmpQty = 0;
			double dblTmpAmount = 0;
			double dblTmpAva = 0;
			string strTmpName = "";
			int index = 0;
			System.Text.StringBuilder sb = new System.Text.StringBuilder();
			sb.Append("select b.hs_code,b.item_name_cn as item_name,a.pack_qty,ltrim(str(a.item_qty,20,0)) as item_qty,d.country_name,a.unit_price,");
			sb.Append(" a.unit_price*a.item_qty as tota_price,e.currency_name,f.unit_name,");
			sb.Append(" b.grossweight*a.pack_qty as gross_weight,b.netweight*a.pack_qty as net_weight");
			sb.Append(" from sale_so_detail a");
			sb.Append(" left join basic_item b on a.item_code=b.item_code");
			sb.Append(" left join sale_so_master c on c.so_code=a.so_code");
			sb.Append(" left join p_country d on d.country_code=c.arrivecountry");
			sb.Append(" left join p_currency e on e.currency_code=b.currency");
			sb.Append(" left join p_unit f on f.unit_id=a.unit");
			sb.Append( this.dpcom.PKCondition);
			sb.Append(" order by a.item_code desc");

			TJSystem.CrystalRPT.crstBaoGuanDan clrpt = new TJSystem.CrystalRPT.crstBaoGuanDan() ;
						
			PublicStatic.Data.dsBaoGuanDan ds = new PublicStatic.Data.dsBaoGuanDan() ;
			System.Data.DataTable dt = null;
			System.Data.DataRow dr = null;
			System.Data.DataRow drTmp = null;
			dt = TJSystem.Public.PublicStatic.db.GetDataTable(sb.ToString());

			ds.Tables["DataConstruct"].Clear();

			for(int i = 0 ; i < dt.Rows.Count ; i ++)
			{
//				dr = ds.Tables["DataConstruct"].NewRow();
//				dr[0] = Convert.ToString(dt.Rows.Count - i);
				tmp = dt.Rows[i]["hs_code"].ToString();
				if (tmp.Length < 10)
				{
					for(int j = tmp.Length; j < 12; j ++)
					{
						tmp += " ";
					}
				}
//				dr[1] = tmp + " " + dt.Rows[i]["item_name"].ToString();
				if (i == dt.Rows.Count - 1)
				{
					dblTmpQty += Convert.ToDouble(dt.Rows[i]["item_qty"].ToString());
					dblTmpAmount += Convert.ToDouble(dt.Rows[i]["tota_price"].ToString());

					gross_wei += Convert.ToDouble(dt.Rows[i]["gross_weight"].ToString());
					net_wei +=  Convert.ToDouble(dt.Rows[i]["net_weight"].ToString());
					dblitemqty +=  Convert.ToDouble(dt.Rows[i]["pack_qty"].ToString());
				}
				else
				{
					if (dt.Rows[i]["item_name"].ToString().Trim().Equals(dt.Rows[i+1]["item_name"].ToString().Trim()))
					{
						dblTmpQty += Convert.ToDouble(dt.Rows[i]["item_qty"].ToString());
						dblTmpAmount += Convert.ToDouble(dt.Rows[i]["tota_price"].ToString());

						gross_wei += Convert.ToDouble(dt.Rows[i]["gross_weight"].ToString());
						net_wei +=  Convert.ToDouble(dt.Rows[i]["net_weight"].ToString());
						dblitemqty +=  Convert.ToDouble(dt.Rows[i]["pack_qty"].ToString());

						continue;
					}
					else
					{
						dblTmpQty += Convert.ToDouble(dt.Rows[i]["item_qty"].ToString());
						dblTmpAmount += Convert.ToDouble(dt.Rows[i]["tota_price"].ToString());

						gross_wei += Convert.ToDouble(dt.Rows[i]["gross_weight"].ToString());
						net_wei +=  Convert.ToDouble(dt.Rows[i]["net_weight"].ToString());
						dblitemqty +=  Convert.ToDouble(dt.Rows[i]["pack_qty"].ToString());
					}
				}
				dr = ds.Tables["DataConstruct"].NewRow();
				dr[1] = tmp + " " + dt.Rows[i]["item_name"].ToString();

				index ++;
				dblTmpAva = dblTmpAmount / dblTmpQty;
				dr[0] = index.ToString();
				dr[2] = dblTmpQty.ToString("f0") + dt.Rows[i]["unit_name"].ToString();//dt.Rows[i]["item_qty"].ToString() + dt.Rows[i]["unit_name"].ToString();
				dr[3] = dt.Rows[i]["country_name"].ToString();
				dr[4] = dblTmpAva.ToString("f2");//dt.Rows[i]["unit_price"].ToString();
				dr[5] = dblTmpAmount.ToString("f2");//dt.Rows[i]["tota_price"].ToString();
				dr[6] = dt.Rows[i]["currency_name"].ToString();
				ds.Tables["DataConstruct"].Rows.InsertAt(dr,index) ;
				dblTmpAmount = 0;
				dblTmpQty = 0;
//				gross_wei += Convert.ToDouble(dt.Rows[i]["gross_weight"].ToString());
//				net_wei +=  Convert.ToDouble(dt.Rows[i]["net_weight"].ToString());
//				dblitemqty +=  Convert.ToDouble(dt.Rows[i]["pack_qty"].ToString());
			}
			ds.Tables["DataConstruct"].EndInit() ;
			ds.Tables["DataConstruct"].EndLoadData() ;

			int dd = ds.Tables["DataConstruct"].Rows.Count;
//			if(index <= 6)
//			{
//				clrpt.Section4.Height = 6000 - (index * 600);	
//			}
//			else
//			{
				clrpt.Section4.Height = 6000 - (index * 600);	
//			}
						
			clrpt.SetDataSource(ds) ;

			CommonConfig cfg = new CommonConfig();
			frmConfigBaoGuanDan frm = new frmConfigBaoGuanDan(cfg);
			frm.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			frm.ShowDialog();
			((CrystalDecisions.CrystalReports.Engine.TextObject)clrpt.ReportDefinition.ReportObjects["Text25"]).Text =  cfg.bgdjydwbh;
			((CrystalDecisions.CrystalReports.Engine.TextObject)clrpt.ReportDefinition.ReportObjects["Text24"]).Text =  cfg.bgdfhdwbh;
			((CrystalDecisions.CrystalReports.Engine.TextObject)clrpt.ReportDefinition.ReportObjects["Text13"]).Text =  cfg.bgdbzzl;
			((CrystalDecisions.CrystalReports.Engine.TextObject)clrpt.ReportDefinition.ReportObjects["Text16"]).Text =  cfg.bgdsfdj;
			((CrystalDecisions.CrystalReports.Engine.TextObject)clrpt.ReportDefinition.ReportObjects["Text26"]).Text =  cfg.bgddwdz;
			((CrystalDecisions.CrystalReports.Engine.TextObject)clrpt.ReportDefinition.ReportObjects["Text3"]).Text =  cfg.bgdsbrq;
			((CrystalDecisions.CrystalReports.Engine.TextObject)clrpt.ReportDefinition.ReportObjects["Text27"]).Text =  cfg.bgdtzrq;
			((CrystalDecisions.CrystalReports.Engine.TextObject)clrpt.ReportDefinition.ReportObjects["Text9"]).Text =  cfg.bgdjnhyd;

			((CrystalDecisions.CrystalReports.Engine.TextObject)clrpt.ReportDefinition.ReportObjects["Text14"]).Text =  gross_wei.ToString("f2");
			((CrystalDecisions.CrystalReports.Engine.TextObject)clrpt.ReportDefinition.ReportObjects["Text15"]).Text =  net_wei.ToString("f2");
			((CrystalDecisions.CrystalReports.Engine.TextObject)clrpt.ReportDefinition.ReportObjects["Text12"]).Text =  dblitemqty.ToString();

			((CrystalDecisions.CrystalReports.Engine.TextObject)clrpt.ReportDefinition.ReportObjects["Text2"]).Text =  TJSystem.Public.PublicStatic.CompanyName;

			sb.Remove(0,sb.Length);
			sb.Append(" select a.invoice_no,a.transtype,a.priceterm,b.trade_desc,c.trans_name,a.settlementtype,");
			sb.Append(" e.country_name,f.port_name,g.port_name as departure");
			sb.Append(" from sale_doc_master a");
			sb.Append(" left join p_tradechar b on b.trade_id=a.trade_character");
			sb.Append(" left join p_transtype c on c.trans_code=a.transtype");
			sb.Append(" left join p_paymode d on d.paymode_id=a.settlementtype");
			sb.Append(" left join p_country e on e.country_code=a.arrivecountry");
			sb.Append(" left join p_port f on f.port_code=a.destport");
			sb.Append(" left join p_port g on g.port_code=a.port_departure");
			sb.Append(" where a.invoice_no=");
			sb.Append("'");
			sb.Append(dpcom.DocNO);
			sb.Append("'");
			dt = TJSystem.Public.PublicStatic.db.GetDataTable(sb.ToString());
			if (dt.Rows.Count == 1)
			{
				((CrystalDecisions.CrystalReports.Engine.TextObject)clrpt.ReportDefinition.ReportObjects["Text11"]).Text =  dt.Rows[0]["invoice_no"].ToString();
				((CrystalDecisions.CrystalReports.Engine.TextObject)clrpt.ReportDefinition.ReportObjects["Text4"]).Text =  dt.Rows[0]["trans_name"].ToString();
				((CrystalDecisions.CrystalReports.Engine.TextObject)clrpt.ReportDefinition.ReportObjects["Text10"]).Text =  dt.Rows[0]["priceterm"].ToString();
				((CrystalDecisions.CrystalReports.Engine.TextObject)clrpt.ReportDefinition.ReportObjects["Text5"]).Text =  dt.Rows[0]["trade_desc"].ToString();
				((CrystalDecisions.CrystalReports.Engine.TextObject)clrpt.ReportDefinition.ReportObjects["Text6"]).Text =  dt.Rows[0]["settlementtype"].ToString();
				((CrystalDecisions.CrystalReports.Engine.TextObject)clrpt.ReportDefinition.ReportObjects["Text7"]).Text =  dt.Rows[0]["country_name"].ToString();
				((CrystalDecisions.CrystalReports.Engine.TextObject)clrpt.ReportDefinition.ReportObjects["Text8"]).Text =  dt.Rows[0]["port_name"].ToString();
				((CrystalDecisions.CrystalReports.Engine.TextObject)clrpt.ReportDefinition.ReportObjects["Text1"]).Text =  dt.Rows[0]["departure"].ToString();
			}

			sb.Remove(0,sb.Length);
			sb.Append("select tel1 from basic_company where company_id=");
			sb.Append("'");
			sb.Append(TJSystem.Public.PublicStatic.CompanyID);
			sb.Append("'");
			dt = TJSystem.Public.PublicStatic.db.GetDataTable(sb.ToString());
			if (dt.Rows.Count == 1)
			{
				((CrystalDecisions.CrystalReports.Engine.TextObject)clrpt.ReportDefinition.ReportObjects["Text17"]).Text =  dt.Rows[0]["tel1"].ToString();
			}
			else
			{
				((CrystalDecisions.CrystalReports.Engine.TextObject)clrpt.ReportDefinition.ReportObjects["Text17"]).Text =  "0086-025-84868727";
			}
//			sb.Append("select a.invoice_no,c.client_name,c.tel,c.fax,b.deliverydate,d.port_name as departure,");
//			sb.Append(" e.port_name as dest,a.freight_paytype,a.lc_code,a.destination,f.trans_namecn as trans,");
//			sb.Append(" b.priceterm,g.forwarder_name as fwd_name,h.contact_name,h.tel as contact_tel,a.billloading,a.FREIGHT_AMOUNT");
//			sb.Append(" from SALE_WAYBILL_MASTER a");
//			sb.Append(" left join sale_doc_master b on a.invoice_no=b.invoice_no");
//			sb.Append(" left join basic_client c on b.client_id=c.client_id");
//			sb.Append(" left join p_port d on d.port_code=a.port_departure");
//			sb.Append(" left join p_port e on e.port_code=a.destport");
//			sb.Append(" left join p_transtype f on f.trans_code=a.transtype");
//			sb.Append(" left join basic_forwarder g on g.forwarder_id=a.shipper_id");
//			sb.Append(" left join basic_forwarder_contact h on h.forwarder_id=g.forwarder_id and a.contact_id=h.contact_id");
//			sb.Append(" where a.awb_code=");
//			sb.Append("'");
//			sb.Append(dpcom.DocNO);
//			sb.Append("'");
//			dt = TJSystem.Public.PublicStatic.db.GetDataTable(sb.ToString());
//			if (dt.Rows.Count == 1)
//			{
//				((CrystalDecisions.CrystalReports.Engine.TextObject)clrpt.ReportDefinition.ReportObjects["Text18"]).Text =  dt.Rows[0]["invoice_no"].ToString();
//				((CrystalDecisions.CrystalReports.Engine.TextObject)clrpt.ReportDefinition.ReportObjects["Text19"]).Text =  dt.Rows[0]["deliverydate"].ToString();
//				((CrystalDecisions.CrystalReports.Engine.TextObject)clrpt.ReportDefinition.ReportObjects["Text20"]).Text =  dt.Rows[0]["departure"].ToString();
//				((CrystalDecisions.CrystalReports.Engine.TextObject)clrpt.ReportDefinition.ReportObjects["Text21"]).Text =  dt.Rows[0]["dest"].ToString();
//				((CrystalDecisions.CrystalReports.Engine.TextObject)clrpt.ReportDefinition.ReportObjects["Text22"]).Text =  dt.Rows[0]["destination"].ToString();
//				((CrystalDecisions.CrystalReports.Engine.TextObject)clrpt.ReportDefinition.ReportObjects["Text23"]).Text =  dt.Rows[0]["priceterm"].ToString();
//				((CrystalDecisions.CrystalReports.Engine.TextObject)clrpt.ReportDefinition.ReportObjects["Text24"]).Text =  dt.Rows[0]["client_name"].ToString();
//				((CrystalDecisions.CrystalReports.Engine.TextObject)clrpt.ReportDefinition.ReportObjects["Text25"]).Text =  dt.Rows[0]["tel"].ToString();
//				((CrystalDecisions.CrystalReports.Engine.TextObject)clrpt.ReportDefinition.ReportObjects["Text140"]).Text =  dt.Rows[0]["fax"].ToString();
//				((CrystalDecisions.CrystalReports.Engine.TextObject)clrpt.ReportDefinition.ReportObjects["Text32"]).Text =  dt.Rows[0]["freight_paytype"].ToString();
//				((CrystalDecisions.CrystalReports.Engine.TextObject)clrpt.ReportDefinition.ReportObjects["Text38"]).Text =  dt.Rows[0]["lc_code"].ToString();
//				((CrystalDecisions.CrystalReports.Engine.TextObject)clrpt.ReportDefinition.ReportObjects["Text33"]).Text =  dt.Rows[0]["trans"].ToString();
//				((CrystalDecisions.CrystalReports.Engine.TextObject)clrpt.ReportDefinition.ReportObjects["Text52"]).Text =  dt.Rows[0]["fwd_name"].ToString();
//				((CrystalDecisions.CrystalReports.Engine.TextObject)clrpt.ReportDefinition.ReportObjects["Text53"]).Text =  dt.Rows[0]["contact_name"].ToString();
//				((CrystalDecisions.CrystalReports.Engine.TextObject)clrpt.ReportDefinition.ReportObjects["Text54"]).Text =  dt.Rows[0]["contact_tel"].ToString();
//				((CrystalDecisions.CrystalReports.Engine.TextObject)clrpt.ReportDefinition.ReportObjects["Text64"]).Text =  dt.Rows[0]["billloading"].ToString();
//				((CrystalDecisions.CrystalReports.Engine.TextObject)clrpt.ReportDefinition.ReportObjects["Text134"]).Text =  dt.Rows[0]["FREIGHT_AMOUNT"].ToString();
//			}

			
			this.crystalReportViewer1.ReportSource = clrpt ;
		}

		private void ConstructOfferSheetRpt()
		{
			string cq_code = this.dpcom.DocSaleNO;
			System.Data.DataTable dtTmp = null;
			System.Data.DataTable dt = null;
			System.Data.DataTable dtmst = null;
			PublicStatic.Public.Number2English ne = new PublicStatic.Public.Number2English();

			TJSystem.CrystalRPT.CommonConfig cfg = new CommonConfig();
			TJSystem.CrystalRPT.frmConfigOfferSheet frm = new frmConfigOfferSheet(cfg);
			frm.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			frm.ShowDialog();

			System.Text.StringBuilder sb = new System.Text.StringBuilder();
			
			sb.Remove(0,sb.Length);
			sb.Append("select a.cq_code,b.item_code,b.item_name,' ' as item_size,' ' as item_material,' ' as item_approval,' ' as pay_ment,");
			sb.Append(" b.saleprice,d.currency_name,b.insidepack,b.outsidepack,");
			sb.Append(" ltrim(str(b.length,20,2))+'X'+ltrim(str(b.width,20,2))+'X'+ltrim(str(b.height,20,2)) as vol,");
			sb.Append(" ' ' as innerwei,' ' as outwei,ltrim(str(b.grossweight)) as gross,ltrim(str(b.netweight)) as net,");
			sb.Append(" b.packrate20,ltrim(str(b.minorder,20,0)) as minorder,c.picture,e.client_name,f.port_name as fobport,");
			sb.Append(" g.unit_name+'/'+h.pack_name as unit_name");
//			sb.Append(" from sale_cq_deatil a");
			sb.Append(" from sale_so_detail a");
			sb.Append(" left join basic_item b on a.item_code=b.item_code");
			sb.Append(" left join basic_item_image c on c.item_code=b.item_code and c.seq_no='100'");
			sb.Append(" left join p_currency d on d.currency_code=b.currency");
			sb.Append(" left join sale_cq_master e on a.cq_code=e.cq_code");
			sb.Append(" left join p_port f on f.port_code=e.port_departure");
			sb.Append(" left join p_unit g on g.unit_id=b.unit");
			sb.Append(" left join p_packtype h on h.pack_code=b.insidepacktype");
//			sb.Append(" where a.cq_code=");
			sb.Append(" where a.so_code=");
			sb.Append("'");
			sb.Append(cq_code);
			sb.Append("'");
			sb.Append(" order by a.item_code desc");

			dt = TJSystem.Public.PublicStatic.db.GetDataTable(sb.ToString());

			TJSystem.CrystalRPT.crstOfferSheet clrpt = new TJSystem.CrystalRPT.crstOfferSheet() ;

			if (dt.Rows.Count == 1)
			{
//				clrpt.Section6.Height = 5530;
			}
			sb.Remove(0,sb.Length);
			sb.Append("select a.port_departure,b.port_name,c.client_name,c.tel,c.fax,c.address,c.email");
//			sb.Append(" from sale_cq_master a");
			sb.Append(" from sale_so_master a");
			sb.Append(" left join p_port b on a.port_departure=b.port_code");
			sb.Append(" left join basic_client c on a.client_id=c.client_id");
//			sb.Append(" where a.cq_code=");
			sb.Append(" where a.so_code=");
			sb.Append("'");
			sb.Append(cq_code);
			sb.Append("'");
			dtmst = TJSystem.Public.PublicStatic.db.GetDataTable(sb.ToString());
			if (dtmst.Rows.Count == 1)
			{
				((CrystalDecisions.CrystalReports.Engine.TextObject)clrpt.ReportDefinition.ReportObjects["Text2"]).Text =  "TO " + dtmst.Rows[0]["client_name"].ToString();
				((CrystalDecisions.CrystalReports.Engine.TextObject)clrpt.ReportDefinition.ReportObjects["Text54"]).Text = dtmst.Rows[0]["tel"].ToString();
				((CrystalDecisions.CrystalReports.Engine.TextObject)clrpt.ReportDefinition.ReportObjects["Text55"]).Text = dtmst.Rows[0]["fax"].ToString();
				((CrystalDecisions.CrystalReports.Engine.TextObject)clrpt.ReportDefinition.ReportObjects["Text56"]).Text = dtmst.Rows[0]["email"].ToString();
				((CrystalDecisions.CrystalReports.Engine.TextObject)clrpt.ReportDefinition.ReportObjects["Text57"]).Text = dtmst.Rows[0]["address"].ToString();
			}
						
			PublicStatic.Data.dsOfferSheet ds = new PublicStatic.Data.dsOfferSheet() ;
			System.Data.DataRow dr = null;

			ds.Tables["DataConstruct"].Clear();

			for(int i = 0 ; i < dt.Rows.Count ; i ++)
			{
				dr = ds.Tables["DataConstruct"].NewRow();

				System.Text.StringBuilder sbTmp = new System.Text.StringBuilder();
				sbTmp.Append("select ltrim(str(a.seq_no,20,0)) as seq_no,ltrim(str(a.qtyprepack,20,0)) as qtyprepack,");
				sbTmp.Append(" ltrim(str(a.length,20,2))+'*'+ltrim(str(a.width,20,2))+'*'+ltrim(str(a.height,20,2)) as psize,");
				sbTmp.Append(" a.netweight,a.grossweight");
//				sbTmp.Append(" b.unit_name,c.pack_name");
				sbTmp.Append(" from basic_item_packing a");
//				sbTmp.Append(" left join p_unit b on a.unit=b.unit_id");
//				sbTmp.Append(" left join p_packtype c on a.outsiepacktype=c.pack_code");
				sbTmp.Append(" where item_code=");
				sbTmp.Append("'");
				sbTmp.Append(dt.Rows[i]["item_code"].ToString());
				sbTmp.Append("'");
				sbTmp.Append(" order by a.seq_no");
				dtTmp = TJSystem.Public.PublicStatic.db.GetDataTable(sbTmp.ToString());
				if (dtTmp.Rows.Count > 0)
				{
					for(int j = 0; j < dtTmp.Rows.Count; j++)
					{
						if(dtTmp.Rows[j]["seq_no"].ToString().Equals("1"))
						{
							//货品
							dr[2] = dtTmp.Rows[j]["psize"].ToString() + "CM";
						}
						else if(dtTmp.Rows[j]["seq_no"].ToString().Equals("2"))
						{
							//内包装
//							dr[7] = ne.NumberToString(Convert.ToDouble(dtTmp.Rows[j]["qtyprepack"].ToString())) + dtTmp.Rows[j]["unit_name"].ToString() + " into " + dtTmp.Rows[j]["pack_name"].ToString();//" pcs into color box ";//"PCS/Inner box";
							dr[7] = dtTmp.Rows[j]["qtyprepack"].ToString() + dt.Rows[i]["unit_name"].ToString();//"PCS/Inner box";
							dr[8] = dtTmp.Rows[j]["psize"].ToString() + "CM";
							dr[9] = "N.W./G.W.:" + dtTmp.Rows[j]["netweight"].ToString() + "/" + dtTmp.Rows[j]["grossweight"].ToString() + "Kgs";
						}
						else if(dtTmp.Rows[j]["seq_no"].ToString().Equals("3"))
						{
							//外包装
							dr[10] = dtTmp.Rows[j]["qtyprepack"].ToString() + dt.Rows[i]["unit_name"].ToString();//"PCS/CTN";
							dr[11] = dtTmp.Rows[j]["psize"].ToString() + "CM";
							dr[12] = "N.W./G.W.:" + dtTmp.Rows[j]["netweight"].ToString() + "/" + dtTmp.Rows[j]["grossweight"].ToString() + "Kgs";
						}
						else
						{
						}
					}
				}		
				sbTmp.Remove(0,sbTmp.Length);
				sbTmp.Append("select a.seq_no,a.property_id,a.property_value from basic_item_property_value a");
				sbTmp.Append(" where a.property_id=");
				sbTmp.Append("'");
				sbTmp.Append(dt.Rows[i]["item_code"].ToString());
				sbTmp.Append("'");
				sbTmp.Append(" order by a.seq_no");
				dtTmp = TJSystem.Public.PublicStatic.db.GetDataTable(sbTmp.ToString());
				if (dtTmp.Rows.Count > 0)
				{
					string tmpstr = "";
					for(int j = 0; j < dtTmp.Rows.Count; j++)
					{
						tmpstr += dtTmp.Rows[j]["property_value"].ToString() + "\r\n";
					}
					dr[3] = tmpstr;
				}
				dr[0] = dt.Rows[i]["item_code"].ToString();
				dr[1] = dt.Rows[i]["item_name"].ToString();
//				dr[2] = dt.Rows[i]["item_size"].ToString();
//				dr[3] = dt.Rows[i]["item_material"].ToString();
//				dr[4] = dt.Rows[i]["item_approval"].ToString();
				dr[4] = cfg.osapproval;
//				dr[5] = dt.Rows[i]["pay_ment"].ToString
				dr[5] = cfg.ospayment;
				dr[6] = "USD " + dt.Rows[i]["saleprice"].ToString() + "/PC";
//				dr[7] = dt.Rows[i]["insidepack"].ToString();
//				dr[8] = "";
//				dr[9] = "";
//				dr[10] = dt.Rows[i]["outsidepack"].ToString();
//				dr[11] = "";
//				dr[12] = "";
				dr[13] = dt.Rows[i]["packrate20"].ToString() + "PCS";
				dr[14] = dt.Rows[i]["minorder"].ToString() + "PCS";
//				dr[15] = "20days after order confirmed";
				dr[15] = cfg.osdeliver;
//				dr[16] = "15days";
				dr[16] = cfg.osvalidity;
				dr[17] = "FOB " + dtmst.Rows[0]["port_name"].ToString().ToUpper();//NINGBO";
				dr[18] = dt.Rows[i]["picture"];
				ds.Tables["DataConstruct"].Rows.InsertAt(dr,0) ;
			}
			ds.Tables["DataConstruct"].EndInit() ;
			ds.Tables["DataConstruct"].EndLoadData() ;

			clrpt.SetDataSource(ds) ;

			this.crystalReportViewer1.ReportSource = clrpt ;
		}

		private void ConstructQuotationRpt()
		{
			string cq_code = this.dpcom.DocSaleNO;
			System.Data.DataTable dtTmp = null;
			System.Data.DataTable dt = null;

//			TJSystem.CrystalRPT.CommonConfig cfg = new CommonConfig();
//			TJSystem.CrystalRPT.frmConfigOfferSheet frm = new frmConfigOfferSheet(cfg);
//			frm.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
//			frm.ShowDialog();

			CommonConfig cfg = new CommonConfig();
			frmConfigQuotation frm = new frmConfigQuotation(cfg);
			frm.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			frm.ShowDialog();

			System.Text.StringBuilder sb = new System.Text.StringBuilder();
			
			sb.Remove(0,sb.Length);
			sb.Append("select a.cq_code,b.item_code,b.item_name,b.item_desc,b.remark,' ' as item_size,' ' as item_material,' ' as item_approval,' ' as pay_ment,");
			sb.Append(" b.saleprice,d.currency_name,b.insidepack,b.outsidepack,");
			sb.Append(" ltrim(str(b.length,20,2))+'X'+ltrim(str(b.width,20,2))+'X'+ltrim(str(b.height,20,2)) as vol,");
			sb.Append(" ' ' as innerwei,' ' as outwei,ltrim(str(b.grossweight)) as gross,ltrim(str(b.netweight)) as net,");
			sb.Append(" b.packrate20,ltrim(str(b.minorder,20,0)) as minorder,a.pack_qty,c.picture,e.client_name,f.port_name as fobport,e.currency");
			sb.Append(" from sale_cq_deatil a");
//			sb.Append(" from sale_so_detail a");
			sb.Append(" left join basic_item b on a.item_code=b.item_code");
			sb.Append(" left join basic_item_image c on c.item_code=b.item_code and c.seq_no='100'");
			sb.Append(" left join p_currency d on d.currency_code=b.currency");
			sb.Append(" left join sale_cq_master e on a.cq_code=e.cq_code");
			sb.Append(" left join p_port f on f.port_code=e.port_departure");
			sb.Append(" where a.cq_code=");
//			sb.Append(" where a.so_code=");
			sb.Append("'");
			sb.Append(cq_code);
			sb.Append("'");
			sb.Append(" order by a.item_code desc");

			dt = TJSystem.Public.PublicStatic.db.GetDataTable(sb.ToString());

			TJSystem.CrystalRPT.crstQuotation clrpt = new TJSystem.CrystalRPT.crstQuotation() ;

			if (dt.Rows.Count == 1)
			{
//				clrpt.Section6.Height = 5530;
			}
			
			PublicStatic.Data.dsQuotation ds = new PublicStatic.Data.dsQuotation() ;
			System.Data.DataRow dr = null;

			ds.Tables["DataConstruct"].Clear();

			for(int i = 0 ; i < dt.Rows.Count ; i ++)
			{
				dr = ds.Tables["DataConstruct"].NewRow();
				PublicStatic.Public.Number2English ne = new PublicStatic.Public.Number2English();

				System.Text.StringBuilder sbTmp = new System.Text.StringBuilder();
				sbTmp.Append("select ltrim(str(a.seq_no,20,0)) as seq_no,ltrim(str(a.qtyprepack,20,0)) as qtyprepack,");
				sbTmp.Append(" ltrim(str(a.length,20,2))+'*'+ltrim(str(a.width,20,2))+'*'+ltrim(str(a.height,20,2)) as psize,");
				sbTmp.Append(" a.netweight,a.grossweight,");
				sbTmp.Append(" b.unit_name,c.pack_name");
				sbTmp.Append(" from basic_item_packing a");
				sbTmp.Append(" left join p_unit b on a.unit=b.unit_id");
				sbTmp.Append(" left join p_packtype c on a.outsiepacktype=c.pack_code");
				sbTmp.Append(" where item_code=");
				sbTmp.Append("'");
				sbTmp.Append(dt.Rows[i]["item_code"].ToString());
				sbTmp.Append("'");
				sbTmp.Append(" order by a.seq_no");
				dtTmp = TJSystem.Public.PublicStatic.db.GetDataTable(sbTmp.ToString());
				if (dtTmp.Rows.Count > 0)
				{
					for(int j = 0; j < dtTmp.Rows.Count; j++)
					{
						if(dtTmp.Rows[j]["seq_no"].ToString().Equals("1"))
						{
							//货品
							//							dr[2] = dtTmp.Rows[j]["psize"].ToString() + "CM";
						}
						else if(dtTmp.Rows[j]["seq_no"].ToString().Equals("2"))
						{
							//内包装
							dr[2] = ne.NumberToString(Convert.ToDouble(dtTmp.Rows[j]["qtyprepack"].ToString())) + dtTmp.Rows[j]["unit_name"].ToString() + " into " + dtTmp.Rows[j]["pack_name"].ToString();//" pcs into color box ";//"PCS/Inner box";
							dr[3] = dtTmp.Rows[j]["psize"].ToString() + "CM";
							dr[6] = "N.W.:" + dtTmp.Rows[j]["netweight"].ToString() + "KGS  G.W.:" + dtTmp.Rows[j]["grossweight"].ToString() + "KGS";
						}
						else if(dtTmp.Rows[j]["seq_no"].ToString().Equals("3"))
						{
							//外包装
							//							dr[10] = dtTmp.Rows[j]["qtyprepack"].ToString() + "PCS/CTN";
							dr[4] = dtTmp.Rows[j]["psize"].ToString() + "CM";
							//							dr[12] = "N.W./G.W.:" + dtTmp.Rows[j]["netweight"].ToString() + "/" + dtTmp.Rows[j]["grossweight"].ToString() + "Kgs";
						}
						else
						{
						}
					}
				}
				if (dr[2] == null || dr[2].ToString().Equals(""))
				{
					dr[2] = cfg.quotationPCK;
				}
				if (dr[3] == null || dr[3].ToString().Equals(""))
				{
					dr[3] = cfg.quotationBOXSize;
				}
				if (dr[4] == null || dr[4].ToString().Equals(""))
				{
					dr[4] = cfg.quotationCTNSize;
				}
				if (dr[6] == null || dr[6].ToString().Equals(""))
				{
					dr[6] = "N.W.:" + dt.Rows[i]["net"].ToString() + "KGS  G.W.:" + dt.Rows[i]["gross"].ToString() + "KGS";
				}
				
				dr[0] = dt.Rows[i]["item_code"].ToString();
				dr[1] = dt.Rows[i]["item_name"].ToString();
//				dr[2] = "one pc into color box ";
				dr[5] = dt.Rows[i]["pack_qty"].ToString();
//				dr[7] = "USD " + dt.Rows[i]["saleprice"].ToString();//"/PC";
				dr[7] = TJSystem.Public.PublicStatic.getCurrencyName(dt.Rows[i]["currency"].ToString()) + " " + dt.Rows[i]["saleprice"].ToString();//"/PC";
				dr[8] = dt.Rows[i]["item_desc"].ToString();
//				dr[9] = dt.Rows[i]["remark"].ToString();
				dr[9] = "30% deposit,balance against B/L faxing";
				dr[10] = dt.Rows[i]["picture"];
				ds.Tables["DataConstruct"].Rows.InsertAt(dr,0) ;
			}
			ds.Tables["DataConstruct"].EndInit() ;
			ds.Tables["DataConstruct"].EndLoadData() ;

			clrpt.SetDataSource(ds) ;

			this.crystalReportViewer1.ReportSource = clrpt ;
		}

	}
}

using System;

namespace TJSystem.CrystalRPT
{
	/// <summary>
	/// CommonConfig 的摘要说明。
	/// </summary>
	public class CommonConfig
	{
		#region SaleTerm
		public string CfgSaleTermBuyFrom = "";
		#endregion

		#region SaleBalance
		public double wsyj = 0;
		public double bxj = 0;
		public double yhsxf = 0;
		public double gwyzf = 0;
		public double qtgwf = 0;
		public double hhcb = 0;
		public double dzfy = 0;

		public double jyfy = 0;
		public double gnyzf = 0;
		public double qtfy = 0;
		public double tslx = 0;
		public double gsglf = 0;
		public double myfl = 0;
		public double tslk = 0;
		public string xb = "";
		public string sbSaleNo = "";
		#endregion

		#region BaoGuanDan
		public string bgdjydwbh = "";
		public string bgdfhdwbh = "";
		public string bgdbzzl = "";
		public string bgdsfdj = "";
		public string bgddwdz = "";
		public string bgdsbrq = "";
		public string bgdtzrq = "";
		public string bgdjnhyd = "";
		#endregion

		#region OfferSheet
		public string osapproval = "";
		public string ospayment = "";
		public string osdeliver = "";
		public string osvalidity = "";
		#endregion

		#region QUOTATION
		public string quotationCTNSize = "";
		public string quotationPCK = "";
		public string quotationBOXSize = "";
		#endregion
		public CommonConfig()
		{
			//
			// TODO: 在此处添加构造函数逻辑
			//
		}
	}
}

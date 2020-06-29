
using System;
namespace Common.Model
{
	/// <summary>
	/// MouldingBom_Model:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class MouldingBom_Model
	{
		public MouldingBom_Model()
		{}
		#region Model
		private string _partnumber;
		private string _matpart01;
		private string _matpart02;
		private string _customer;
		private string _model;
		private string _jigno;
		private decimal? _cavitycount;
		private decimal? _partsweight;
		private decimal? _cycletime;
		private decimal? _blockcount;
		private decimal? _unitcount;
		private string _machineid;
		private string _username;
		private DateTime? _datetime;
		private string _remarks;
        private string _partnumberall;
        /// <summary>
        /// 
        /// </summary>
        public string partNumber
		{
			set{ _partnumber=value;}
			get{return _partnumber;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string matPart01
		{
			set{ _matpart01=value;}
			get{return _matpart01;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string matPart02
		{
			set{ _matpart02=value;}
			get{return _matpart02;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string customer
		{
			set{ _customer=value;}
			get{return _customer;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string model
		{
			set{ _model=value;}
			get{return _model;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string jigNo
		{
			set{ _jigno=value;}
			get{return _jigno;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? cavityCount
		{
			set{ _cavitycount=value;}
			get{return _cavitycount;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? partsWeight
		{
			set{ _partsweight=value;}
			get{return _partsweight;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? cycleTime
		{
			set{ _cycletime=value;}
			get{return _cycletime;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? blockCount
		{
			set{ _blockcount=value;}
			get{return _blockcount;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? unitCount
		{
			set{ _unitcount=value;}
			get{return _unitcount;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string machineID
		{
			set{ _machineid=value;}
			get{return _machineid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string userName
		{
			set{ _username=value;}
			get{return _username;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? dateTime
		{
			set{ _datetime=value;}
			get{return _datetime;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string remarks
		{
			set{ _remarks=value;}
			get{return _remarks;}
		}

        public string partnumberall
        {
            set { _partnumberall = value; }
            get { return _partnumberall; }
        }
        #endregion Model

    }
}


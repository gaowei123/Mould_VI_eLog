
using System;
namespace Common.Model
{
	/// <summary>
	/// MouldingViDefectHistory_Model:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class MouldingViDefectHistory_Model
	{
		public MouldingViDefectHistory_Model()
		{}
		#region Model
		private int _id;
		private string _trackingid;
		private string _machineid;
		private DateTime? _datetime;
		private string _partnumber;
		private string _jigno;
		private string _model;
		private decimal? _cavitycount;
		private string _username;
		private string _userid;
		private DateTime? _starttime;
		private DateTime? _stoptime;
		private DateTime? _day;
		private string _shift;
		private string _status;
		private string _matpart01;
		private string _matpart02;
		private string _matlot01;
		private string _matlot02;
		private string _defectcodeid;
		private string _defectcode;
		private decimal? _rejectqty;
		private string _rejectqtyhour01;
		private string _rejectqtyhour02;
		private string _rejectqtyhour03;
		private string _rejectqtyhour04;
		private string _rejectqtyhour05;
		private string _rejectqtyhour06;
		private string _rejectqtyhour07;
		private string _rejectqtyhour08;
		private string _rejectqtyhour09;
		private string _rejectqtyhour10;
		private string _rejectqtyhour11;
		private string _rejectqtyhour12;
		private DateTime? _lastupdatedtime;
		private string _remarks;
        private decimal? _QCNGQTY;
        private string _Material_MHCheck;
        private DateTime? _Material_MHCheckTime;
        private string _Material_Opcheck;
        private DateTime? _Material_OpCheckTime;
        private string _Material_LeaderCheck;
        private DateTime? _Material_LeaderCheckTime;
        private string _LeaderCheck;
        private DateTime? _LeaderCheckTime;
        private string _SupervisorCheck;
        private DateTime? _SupervisorCheckTime;
        private string _partnumberall;
        /// <summary>
        /// 
        /// </summary>
        public int id
		{
			set{ _id=value;}
			get{return _id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string trackingID
		{
			set{ _trackingid=value;}
			get{return _trackingid;}
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
		public DateTime? dateTime
		{
			set{ _datetime=value;}
			get{return _datetime;}
		}
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
		public string jigNo
		{
			set{ _jigno=value;}
			get{return _jigno;}
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
		public decimal? cavityCount
		{
			set{ _cavitycount=value;}
			get{return _cavitycount;}
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
		public string userID
		{
			set{ _userid=value;}
			get{return _userid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? startTime
		{
			set{ _starttime=value;}
			get{return _starttime;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? stopTime
		{
			set{ _stoptime=value;}
			get{return _stoptime;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? day
		{
			set{ _day=value;}
			get{return _day;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string shift
		{
			set{ _shift=value;}
			get{return _shift;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string status
		{
			set{ _status=value;}
			get{return _status;}
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
		public string matLot01
		{
			set{ _matlot01=value;}
			get{return _matlot01;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string matLot02
		{
			set{ _matlot02=value;}
			get{return _matlot02;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string defectCodeID
		{
			set{ _defectcodeid=value;}
			get{return _defectcodeid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string defectCode
		{
			set{ _defectcode=value;}
			get{return _defectcode;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? rejectQty
		{
			set{ _rejectqty=value;}
			get{return _rejectqty;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string rejectQtyHour01
		{
			set{ _rejectqtyhour01=value;}
			get{return _rejectqtyhour01;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string rejectQtyHour02
		{
			set{ _rejectqtyhour02=value;}
			get{return _rejectqtyhour02;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string rejectQtyHour03
		{
			set{ _rejectqtyhour03=value;}
			get{return _rejectqtyhour03;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string rejectQtyHour04
		{
			set{ _rejectqtyhour04=value;}
			get{return _rejectqtyhour04;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string rejectQtyHour05
		{
			set{ _rejectqtyhour05=value;}
			get{return _rejectqtyhour05;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string rejectQtyHour06
		{
			set{ _rejectqtyhour06=value;}
			get{return _rejectqtyhour06;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string rejectQtyHour07
		{
			set{ _rejectqtyhour07=value;}
			get{return _rejectqtyhour07;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string rejectQtyHour08
		{
			set{ _rejectqtyhour08=value;}
			get{return _rejectqtyhour08;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string rejectQtyHour09
		{
			set{ _rejectqtyhour09=value;}
			get{return _rejectqtyhour09;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string rejectQtyHour10
		{
			set{ _rejectqtyhour10=value;}
			get{return _rejectqtyhour10;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string rejectQtyHour11
		{
			set{ _rejectqtyhour11=value;}
			get{return _rejectqtyhour11;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string rejectQtyHour12
		{
			set{ _rejectqtyhour12=value;}
			get{return _rejectqtyhour12;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? lastUpdatedTime
		{
			set{ _lastupdatedtime=value;}
			get{return _lastupdatedtime;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string remarks
		{
			set{ _remarks=value;}
			get{return _remarks;}
		}

        public decimal? QCNGQTY
        {
            set { _QCNGQTY = value; }
            get { return _QCNGQTY; }
        }

        public string Material_MHCheck
        {
            set { _Material_MHCheck = value; }
            get { return _Material_MHCheck; }
        }

        public DateTime? Material_MHCheckTime
        {
            set { _Material_MHCheckTime = value; }
            get { return _Material_MHCheckTime; }
        }

        public string Material_Opcheck
        {
            set { _Material_Opcheck = value; }
            get { return _Material_Opcheck; }
        }

        public DateTime? Material_OpCheckTime
        {
            set { _Material_OpCheckTime = value; }
            get { return _Material_OpCheckTime; }
        }

        public string Material_LeaderCheck
        {
            set { _Material_LeaderCheck = value; }
            get { return _Material_LeaderCheck; }
        }

        public DateTime? Material_LeaderCheckTime
        {
            set { _Material_LeaderCheckTime = value; }
            get { return _Material_LeaderCheckTime; }
        }

        public string LeaderCheck
        {
            set { _LeaderCheck = value; }
            get { return _LeaderCheck; }
        }

        public DateTime? LeaderCheckTime
        {
            set { _LeaderCheckTime = value; }
            get { return _LeaderCheckTime; }
        }

        public string SupervisorCheck
        {
            set { _SupervisorCheck = value; }
            get { return _SupervisorCheck; }
        }

        public DateTime? SupervisorCheckTime
        {
            set { _SupervisorCheckTime = value; }
            get { return _SupervisorCheckTime; }
        }
        public string partnumberall
        {
            set { _partnumberall = value; }
            get { return _partnumberall; }
        }
        #endregion Model

    }
}


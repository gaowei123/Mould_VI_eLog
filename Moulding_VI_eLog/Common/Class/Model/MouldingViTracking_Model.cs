
using System;
namespace Common.Model
{
	/// <summary>
	/// MouldingViTracking_Model:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class MouldingViTracking_Model
	{
		public MouldingViTracking_Model()
		{}
		#region Model
		private int _id;
		private string _machineid;
		private DateTime? _datetime;
		private string _partnumber;
		private string _jigno;
		private string _model;
		private decimal? _cavitycount;
		
		private decimal? _cycletime;
		private decimal? _targetqty;
		private string _username;
		private string _userid;
		private decimal? _acountreading;
		private decimal? _rejectqty;
        private decimal? _QCNGQTY;
        private decimal? _acceptqty;
		private DateTime? _starttime;
		private DateTime? _stoptime;
		private DateTime? _day;
		private string _shift;
		private string _status;
		private string _matpart01;
		private string _matpart02;
		private string _matlot01;
		private string _matlot02;
		private string _opsign01;
		private string _opsign02;
		private string _opsign03;
		private string _opsign04;
		private string _opsign05;
		private string _opsign06;
		private string _opsign07;
		private string _opsign08;
		private string _opsign09;
		private string _opsign10;
		private string _opsign11;
		private string _opsign12;
		private string _qasign01;
		private string _qasign02;
		private string _qasign03;
		private string _qasign04;
		private string _qasign05;
		private string _qasign06;
		private string _qasign07;
		private string _qasign08;
		private string _qasign09;
		private string _qasign10;
		private string _qasign11;
		private string _qasign12;
		private string _customer;
		private DateTime? _lastupdatedtime;
		private string _trackingid;
		private string _remarks;
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
        private decimal? _partsweight;
        private decimal? _parts2Weight;
        private decimal? _lastQty;
        private string _OkAccumulation;
        private string _refField01;
        private string _refField02;
        private string _refField03;
        private string _refField04;
        private string _refField05;
        /// <summary>
        /// 
        /// </summary>
        ///
        public string refField05
        {
            set { _refField05 = value; }
            get { return _refField05; }
        }
        public string refField04
        {
            set { _refField04 = value; }
            get { return _refField04; }
        }
        public string refField03
        {
            set { _refField03 = value; }
            get { return _refField03; }
        }
        public string refField02
        {
            set { _refField02 = value; }
            get { return _refField02; }
        }
        public string refField01
        {
            set { _refField01 = value; }
            get { return _refField01; }
        }
        public string OkAccumulation
        {
            set { _OkAccumulation = value; }
            get { return _OkAccumulation; }
        }
        public decimal? parts2Weight
        {
            set { _parts2Weight = value; }
            get { return _parts2Weight; }
        }

        public decimal? lastQty
        {
            set { _lastQty = value; }
            get { return _lastQty; }
        }
        public int id
		{
			set{ _id=value;}
			get{return _id;}
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
		public decimal? targetQty
		{
			set{ _targetqty=value;}
			get{return _targetqty;}
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
		public decimal? acountReading
		{
			set{ _acountreading=value;}
			get{return _acountreading;}
		}
        /// <summary>
        /// 
        /// </summary>
        public decimal? QCNGQTY
        {
            set { _QCNGQTY = value; }
            get { return _QCNGQTY; }
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
		public decimal? acceptQty
		{
			set{ _acceptqty=value;}
			get{return _acceptqty;}
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
		public string opSign01
		{
			set{ _opsign01=value;}
			get{return _opsign01;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string opSign02
		{
			set{ _opsign02=value;}
			get{return _opsign02;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string opSign03
		{
			set{ _opsign03=value;}
			get{return _opsign03;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string opSign04
		{
			set{ _opsign04=value;}
			get{return _opsign04;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string opSign05
		{
			set{ _opsign05=value;}
			get{return _opsign05;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string opSign06
		{
			set{ _opsign06=value;}
			get{return _opsign06;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string opSign07
		{
			set{ _opsign07=value;}
			get{return _opsign07;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string opSign08
		{
			set{ _opsign08=value;}
			get{return _opsign08;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string opSign09
		{
			set{ _opsign09=value;}
			get{return _opsign09;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string opSign10
		{
			set{ _opsign10=value;}
			get{return _opsign10;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string opSign11
		{
			set{ _opsign11=value;}
			get{return _opsign11;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string opSign12
		{
			set{ _opsign12=value;}
			get{return _opsign12;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string qaSign01
		{
			set{ _qasign01=value;}
			get{return _qasign01;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string qaSign02
		{
			set{ _qasign02=value;}
			get{return _qasign02;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string qaSign03
		{
			set{ _qasign03=value;}
			get{return _qasign03;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string qaSign04
		{
			set{ _qasign04=value;}
			get{return _qasign04;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string qaSign05
		{
			set{ _qasign05=value;}
			get{return _qasign05;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string qaSign06
		{
			set{ _qasign06=value;}
			get{return _qasign06;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string qaSign07
		{
			set{ _qasign07=value;}
			get{return _qasign07;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string qaSign08
		{
			set{ _qasign08=value;}
			get{return _qasign08;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string qaSign09
		{
			set{ _qasign09=value;}
			get{return _qasign09;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string qaSign10
		{
			set{ _qasign10=value;}
			get{return _qasign10;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string qaSign11
		{
			set{ _qasign11=value;}
			get{return _qasign11;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string qaSign12
		{
			set{ _qasign12=value;}
			get{return _qasign12;}
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
		public DateTime? lastUpdatedTime
		{
			set{ _lastupdatedtime=value;}
			get{return _lastupdatedtime;}
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
		public string remarks
		{
			set{ _remarks=value;}
			get{return _remarks;}
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

        #region MyRegion
        public static class StatusList
        {
            public static string Start = "Start";
            public static string OnGoing = "OnGoing";
            public static string End = "End";

            public static string Running = "Running";
            public static string MaterialTesting = "Material_Testing";
            public static string MouldTesting = "Mould_Testing";

        }
        #endregion
    }
}


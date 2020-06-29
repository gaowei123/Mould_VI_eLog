using System;
namespace Common.Model
{
    /// <summary>
    /// MouldingMoldLife:实体类(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Serializable]
    public partial class MouldingMoldLife
    {
        public MouldingMoldLife()
        { }
        #region Model
        private string _moldID;
        private string _machineid;
        private string _partnumberall;
        private decimal? _mouldLife;
        private decimal? _accumulate;
        private decimal? _clean1qty;
        private DateTime? _clean1time;
        private string _clean1timeby;
        private decimal? _clean2qty;
        private DateTime? _clean2time;
        private string _clean2timeby;
        private decimal? _clean3qty;
        private DateTime? _clean3time;
        private string _clean3timeby;
        private decimal? _clean4qty;
        private DateTime? _clean4time;
        private string _clean4timeby;
        private decimal? _clean5qty;
        private DateTime? _clean5time;
        private string _clean5timeby;
        private decimal? _changeqty;
        private DateTime? _changetime;
        private string _changeby;
        private DateTime? _createtime;
        private DateTime? _updatedtime;
        /// <summary>
        /// 
        /// </summary>
        /// 
        public string MoldID
        {
            set { _moldID = value; }
            get { return _moldID; }
        }
        public string MachineID
        {
            set { _machineid = value; }
            get { return _machineid; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string PartNumberAll
        {
            set { _partnumberall = value; }
            get { return _partnumberall; }
        }

        public decimal? MouldLife
        {
            set { _mouldLife = value; }
            get { return _mouldLife; }
        }
        public decimal? Accumulate
        {
            set { _accumulate = value; }
            get { return _accumulate; }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal? Clean1Qty
        {
            set { _clean1qty = value; }
            get { return _clean1qty; }
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime? Clean1Time
        {
            set { _clean1time = value; }
            get { return _clean1time; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Clean1TimeBy
        {
            set { _clean1timeby = value; }
            get { return _clean1timeby; }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal? Clean2Qty
        {
            set { _clean2qty = value; }
            get { return _clean2qty; }
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime? Clean2Time
        {
            set { _clean2time = value; }
            get { return _clean2time; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Clean2TimeBy
        {
            set { _clean2timeby = value; }
            get { return _clean2timeby; }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal? Clean3Qty
        {
            set { _clean3qty = value; }
            get { return _clean3qty; }
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime? Clean3Time
        {
            set { _clean3time = value; }
            get { return _clean3time; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Clean3TimeBy
        {
            set { _clean3timeby = value; }
            get { return _clean3timeby; }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal? Clean4Qty
        {
            set { _clean4qty = value; }
            get { return _clean4qty; }
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime? Clean4Time
        {
            set { _clean4time = value; }
            get { return _clean4time; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Clean4TimeBy
        {
            set { _clean4timeby = value; }
            get { return _clean4timeby; }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal? Clean5Qty
        {
            set { _clean5qty = value; }
            get { return _clean5qty; }
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime? Clean5Time
        {
            set { _clean5time = value; }
            get { return _clean5time; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Clean5TimeBy
        {
            set { _clean5timeby = value; }
            get { return _clean5timeby; }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal? ChangeQty
        {
            set { _changeqty = value; }
            get { return _changeqty; }
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime? ChangeTime
        {
            set { _changetime = value; }
            get { return _changetime; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string ChangeBy
        {
            set { _changeby = value; }
            get { return _changeby; }
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime? CreateTime
        {
            set { _createtime = value; }
            get { return _createtime; }
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime? UpdatedTime
        {
            set { _updatedtime = value; }
            get { return _updatedtime; }
        }
        #endregion Model

    }
}



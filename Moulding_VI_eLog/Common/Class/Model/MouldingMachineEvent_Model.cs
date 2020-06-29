using System;
namespace Common.Model
{
    /// <summary>
    /// MouldingMachineEvent_Model:实体类(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Serializable]
    public partial class MouldingMachineEvent_Model
    {
        public MouldingMachineEvent_Model()
        { }
        #region Model
        private string _machineid;
        private string _pqmmachineid;
        private string _event_type;
        private string _error_code;
        private string _error_name;
        private DateTime? _event_time;
        private string _remarks;
        /// <summary>
        /// 
        /// </summary>
        public string MachineID
        {
            set { _machineid = value; }
            get { return _machineid; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string PQMmachineID
        {
            set { _pqmmachineid = value; }
            get { return _pqmmachineid; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Event_Type
        {
            set { _event_type = value; }
            get { return _event_type; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string error_code
        {
            set { _error_code = value; }
            get { return _error_code; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string error_name
        {
            set { _error_name = value; }
            get { return _error_name; }
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime? event_time
        {
            set { _event_time = value; }
            get { return _event_time; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string remarks
        {
            set { _remarks = value; }
            get { return _remarks; }
        }
        #endregion Model

    }
}


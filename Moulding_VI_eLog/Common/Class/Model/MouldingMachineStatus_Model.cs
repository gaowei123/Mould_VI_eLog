using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Common.Model
{
    public partial class MouldingMachineStatus_Model
    {
        public MouldingMachineStatus_Model()
        { }
        private string _machineid;
        private DateTime? _day;
        private string _shift;
        private string _machinestatus;
        private string _oeestatus;
        private DateTime? _starttime;
        private DateTime? _endtime;
        private string _username;
        private string _partno;
        private string _userid;
        private string _remark;

        public string machineID
        {
            set { _machineid = value; }
            get { return _machineid; }
        }

        public DateTime? day
        {
            set { _day = value; }
            get { return _day; }
        }

        public string shift
        {
            set { _shift = value; }
            get { return _shift; }
        }

        public string machinestatus
        {
            set { _machinestatus = value; }
            get { return _machinestatus; }
        }

        public string oeestatus
        {
            set { _oeestatus = value; }
            get { return _oeestatus; }
        }

        public DateTime? starttime
        {
            set { _starttime = value; }
            get { return _starttime; }
        }

        public DateTime? endtime
        {
            set { _endtime = value; }
            get { return _endtime; }
        }

        public string username
        {
            set { _username = value; }
            get { return _username; }
        }

        public string partno
        {
            set { _partno = value; }
            get { return _partno; }
        }

        public string userid
        {
            set { _userid = value; }
            get { return _userid; }
        }

        public string remark
        {
            set { _remark = value; }
            get { return _remark; }
        }
    }
}

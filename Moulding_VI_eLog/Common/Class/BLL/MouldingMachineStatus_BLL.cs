using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Common.Model;
using System.Data;
using System.Data.SqlClient;

namespace Common.BLL
{
     public class MouldingMachineStatus_BLL
    {
        private readonly Common.DAL.MouldingMachineStatus_DAL dal = new Common.DAL.MouldingMachineStatus_DAL();
        public MouldingMachineStatus_BLL()
        { }

        public bool endtimesearchandupdate(MouldingMachineStatus_Model _model)
        {
            MouldingMachineStatus_Model objmachine = new MouldingMachineStatus_Model();
            DataSet ds = dal.endtimesearchandupdate(_model);
            if (ds == null || ds.Tables.Count == 0 || ds.Tables[0].Rows.Count == 0)
            {
                return false;
            }
            else
            {
                return dal.update(ds.Tables[0].Rows[0]["MachineID"].ToString(),_model.starttime);               
            }
        }

        public SqlCommand add(MouldingMachineStatus_Model _model)
        {
            return dal.add(_model);
        }

    }
}

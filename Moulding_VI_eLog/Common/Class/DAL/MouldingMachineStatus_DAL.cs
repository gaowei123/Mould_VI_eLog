using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Common.Model;
using System.Data;
using System.Data.SqlClient;

namespace Common.DAL
{
    public class MouldingMachineStatus_DAL
    {
        public MouldingMachineStatus_DAL()
        { }

        public DataSet endtimesearchandupdate(MouldingMachineStatus_Model _model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  MachineID,Day,Shif,MachineStatus,OEEStatus,StartTime,EndTime,PartNo,UserID,Remark  ");
            strSql.Append(" FROM MouldingMachineStatus ");
            strSql.Append(" where  MachineID = " + _model.machineID );
            strSql.Append(" and EndTime is NULL order by StartTime ");
            return DBHelp.SqlDB.Query(strSql.ToString());
        }

        public SqlCommand add(MouldingMachineStatus_Model _model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into MouldingMachineStatus(");
            strSql.Append("MachineID,Day,Shif,MachineStatus,OEEStatus,StartTime,EndTime,PartNo,UserID,Remark) ");
            strSql.Append(" values (");
            strSql.Append("@MachineID,@Day,@Shif,@MachineStatus,@OEEStatus,@StartTime,@EndTime,@PartNo,@UserID,@Remark)");
            SqlParameter[] parameters = {
                    new SqlParameter("@MachineID", SqlDbType.VarChar,50),
                    new SqlParameter("@Day", SqlDbType.DateTime2,8),
                    new SqlParameter("@Shif", SqlDbType.VarChar,50),   
                    new SqlParameter("@MachineStatus", SqlDbType.VarChar,50),
                    new SqlParameter("@OEEStatus", SqlDbType.VarChar,50),
                    new SqlParameter("@StartTime", SqlDbType.DateTime2,8),
                    new SqlParameter("@EndTime", SqlDbType.DateTime2,8),
                    new SqlParameter("@PartNo", SqlDbType.VarChar,50),
                    new SqlParameter("@UserID", SqlDbType.VarChar,50),
                    new SqlParameter("@Remark", SqlDbType.VarChar,50)};
            parameters[0].Value = _model.machineID == null ? (object)DBNull.Value : _model.machineID;
            parameters[1].Value = _model.day == null ? (object)DBNull.Value : _model.day;
            parameters[2].Value = _model.shift == null ? (object)DBNull.Value : _model.shift;
            parameters[3].Value = _model.machinestatus == null ? (object)DBNull.Value : _model.machinestatus;
            parameters[4].Value = _model.oeestatus == null ? (object)DBNull.Value : _model.oeestatus;
            parameters[5].Value = _model.starttime == null ? (object)DBNull.Value : _model.starttime;
            parameters[6].Value = _model.endtime == null ? (object)DBNull.Value : _model.endtime;
            parameters[7].Value = _model.partno == null ? (object)DBNull.Value : _model.partno;
            parameters[8].Value = _model.userid == null ? (object)DBNull.Value : _model.userid;
            parameters[9].Value = _model.remark == null ? (object)DBNull.Value : _model.remark;
            return DBHelp.SqlDB.generateCommand(strSql.ToString(), parameters);
        }

        public bool update(string sMachineID, DateTime? sEndtime)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update MouldingMachineStatus set ");
            strSql.Append(" EndTime=@EndTime ");
            strSql.Append(" where ");
            strSql.Append(" MachineID=@MachineID ");
            strSql.Append(" and EndTime is null ");
            SqlParameter[] parameters = {
                    new SqlParameter("@EndTime", SqlDbType.DateTime2,8),
                    new SqlParameter("@machineID", SqlDbType.VarChar,50) };
            parameters[0].Value = sEndtime == null ? (object)DBNull.Value : sEndtime;
            parameters[1].Value = sMachineID == null ? (object)DBNull.Value : sMachineID;
            int rows = DBHelp.SqlDB.ExecuteSql(strSql.ToString(), parameters);
            if (rows > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}

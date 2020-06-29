using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using DBHelp;
namespace Common.DAL
{
    /// <summary>
    /// 数据访问类:MouldingMachineEvent_DAL
    /// </summary>
    public class MouldingMachineEvent_DAL
    {
        public MouldingMachineEvent_DAL()
        { }
        #region  Method

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public DataSet Exists(string MachineID, string PQMmachineID, string Event_Type, string error_code, string error_name, DateTime? event_time, string remarks)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from MouldingMachineEvent");
            strSql.Append(" where ");
            SqlParameter[] parameters = {
};

            return DBHelp.SqlDB.Query(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public void Add(Common.Model.MouldingMachineEvent_Model model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into MouldingMachineEvent(");
            strSql.Append("MachineID,PQMmachineID,Event_Type,error_code,error_name,event_time,remarks)");
            strSql.Append(" values (");
            strSql.Append("@MachineID,@PQMmachineID,@Event_Type,@error_code,@error_name,@event_time,@remarks)");
            SqlParameter[] parameters = {
                    new SqlParameter("@MachineID", SqlDbType.VarChar,50),
                    new SqlParameter("@PQMmachineID", SqlDbType.VarChar,50),
                    new SqlParameter("@Event_Type", SqlDbType.VarChar,50),
                    new SqlParameter("@error_code", SqlDbType.VarChar,50),
                    new SqlParameter("@error_name", SqlDbType.VarChar,50),
                    new SqlParameter("@event_time", SqlDbType.DateTime2,8),
                    new SqlParameter("@remarks", SqlDbType.VarChar,50)};
            DBHelp.Reports.LogFile.DebugLog("AUTOCODE", "NameSpace:Common.DAL", "Class:MouldingMachineEvent_DAL", "Function:		public void Add(Common.Model.MouldingMachineEvent_Model model)" + "TableName:MouldingMachineEvent", ";MachineID = " + model.MachineID.ToString() + ";PQMmachineID = " + model.PQMmachineID.ToString() + ";Event_Type = " + model.Event_Type.ToString() + ";error_code = " + model.error_code.ToString() + ";error_name = " + model.error_name.ToString() + ";event_time = " + model.event_time.ToString() + ";remarks = " + model.remarks.ToString() + "");
            parameters[0].Value = model.MachineID;
            parameters[1].Value = model.PQMmachineID;
            parameters[2].Value = model.Event_Type;
            parameters[3].Value = model.error_code;
            parameters[4].Value = model.error_name;
            parameters[5].Value = model.event_time;
            parameters[6].Value = model.remarks;

            DBHelp.SqlDB.ExecuteSql(strSql.ToString(), parameters);
        }
        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(Common.Model.MouldingMachineEvent_Model model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update MouldingMachineEvent set ");
            strSql.Append("MachineID=@MachineID,");
            strSql.Append("PQMmachineID=@PQMmachineID,");
            strSql.Append("Event_Type=@Event_Type,");
            strSql.Append("error_code=@error_code,");
            strSql.Append("error_name=@error_name,");
            strSql.Append("event_time=@event_time,");
            strSql.Append("remarks=@remarks");
            strSql.Append(" where ");
            SqlParameter[] parameters = {
                    new SqlParameter("@MachineID", SqlDbType.VarChar,50),
                    new SqlParameter("@PQMmachineID", SqlDbType.VarChar,50),
                    new SqlParameter("@Event_Type", SqlDbType.VarChar,50),
                    new SqlParameter("@error_code", SqlDbType.VarChar,50),
                    new SqlParameter("@error_name", SqlDbType.VarChar,50),
                    new SqlParameter("@event_time", SqlDbType.DateTime2,8),
                    new SqlParameter("@remarks", SqlDbType.VarChar,50)};
            parameters[0].Value = model.MachineID;
            parameters[1].Value = model.PQMmachineID;
            parameters[2].Value = model.Event_Type;
            parameters[3].Value = model.error_code;
            parameters[4].Value = model.error_name;
            parameters[5].Value = model.event_time;
            parameters[6].Value = model.remarks;

            DBHelp.Reports.LogFile.DebugLog("AUTOCODE", "NameSpace:Common.DAL", "Class:MouldingMachineEvent_DAL", "Function:		public bool Update(Common.Model.MouldingMachineEvent_Model model)" + "TableName:MouldingMachineEvent", ";MachineID = " + model.MachineID.ToString() + ";PQMmachineID = " + model.PQMmachineID.ToString() + ";Event_Type = " + model.Event_Type.ToString() + ";error_code = " + model.error_code.ToString() + ";error_name = " + model.error_name.ToString() + ";event_time = " + model.event_time.ToString() + ";remarks = " + model.remarks.ToString() + "");
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

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool Delete(string MachineID, string PQMmachineID, string Event_Type, string error_code, string error_name, DateTime? event_time, string remarks)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from MouldingMachineEvent ");
            strSql.Append(" where ");
            SqlParameter[] parameters = {
};

            DBHelp.Reports.LogFile.DebugLog("AUTOCODE", "NameSpace:Common.DAL", "Class:MouldingMachineEvent_DAL", "Function:		public bool Delete(string MachineID,string PQMmachineID,string Event_Type,string error_code,string error_name,DateTime? event_time,string remarks)" + "TableName:MouldingMachineEvent", "");
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


        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public Common.Model.MouldingMachineEvent_Model GetModel(string MachineID, string PQMmachineID, string Event_Type, string error_code, string error_name, DateTime? event_time, string remarks)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 MachineID,PQMmachineID,Event_Type,error_code,error_name,event_time,remarks from MouldingMachineEvent ");
            strSql.Append(" where ");
            SqlParameter[] parameters = {
};

            DBHelp.Reports.LogFile.DebugLog("AUTOCODE", "NameSpace:Common.DAL", "Class:MouldingMachineEvent_DAL", "Function:		public Common.Model.MouldingMachineEvent_Model GetModel(string MachineID,string PQMmachineID,string Event_Type,string error_code,string error_name,DateTime? event_time,string remarks)" + "TableName:MouldingMachineEvent", "");
            Common.Model.MouldingMachineEvent_Model model = new Common.Model.MouldingMachineEvent_Model();
            DataSet ds = DBHelp.SqlDB.Query(strSql.ToString(), parameters);
            if (ds.Tables[0].Rows.Count > 0)
            {
                model.MachineID = ds.Tables[0].Rows[0]["MachineID"].ToString();
                model.PQMmachineID = ds.Tables[0].Rows[0]["PQMmachineID"].ToString();
                model.Event_Type = ds.Tables[0].Rows[0]["Event_Type"].ToString();
                model.error_code = ds.Tables[0].Rows[0]["error_code"].ToString();
                model.error_name = ds.Tables[0].Rows[0]["error_name"].ToString();
                if (ds.Tables[0].Rows[0]["event_time"].ToString() != "")
                {
                    model.event_time = DateTime.Parse(ds.Tables[0].Rows[0]["event_time"].ToString());
                }
                model.remarks = ds.Tables[0].Rows[0]["remarks"].ToString();
                return model;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetList(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select MachineID,PQMmachineID,Event_Type,error_code,error_name,event_time,remarks ");
            strSql.Append(" FROM MouldingMachineEvent ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return DBHelp.SqlDB.Query(strSql.ToString());
        }

        /// <summary>
        /// 获得前几行数据
        /// </summary>
        public DataSet GetList(int Top, string strWhere, string filedOrder)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select ");
            if (Top > 0)
            {
                strSql.Append(" top " + Top.ToString());
            }
            strSql.Append(" MachineID,PQMmachineID,Event_Type,error_code,error_name,event_time,remarks ");
            strSql.Append(" FROM MouldingMachineEvent ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            strSql.Append(" order by " + filedOrder);
            return DBHelp.SqlDB.Query(strSql.ToString());
        }

        /*
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public DataSet GetList(int PageSize,int PageIndex,string strWhere)
		{
			SqlParameter[] parameters = {
					new SqlParameter("@tblName", SqlDbType.VarChar, 255),
					new SqlParameter("@fldName", SqlDbType.VarChar, 255),
					new SqlParameter("@PageSize", SqlDbType.Int),
					new SqlParameter("@PageIndex", SqlDbType.Int),
					new SqlParameter("@IsReCount", SqlDbType.Bit),
					new SqlParameter("@OrderType", SqlDbType.Bit),
					new SqlParameter("@strWhere", SqlDbType.VarChar,1000),
					};
			parameters[0].Value = "MouldingMachineEvent";
			parameters[1].Value = "";
			parameters[2].Value = PageSize;
			parameters[3].Value = PageIndex;
			parameters[4].Value = 0;
			parameters[5].Value = 0;
			parameters[6].Value = strWhere;	
			return DBHelp.SqlDB.RunProcedure("UP_GetRecordByPage",parameters,"ds");
		}*/

        #endregion  Method
    }
}


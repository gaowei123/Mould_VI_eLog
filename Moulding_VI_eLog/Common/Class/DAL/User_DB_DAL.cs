using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace Common.DAL
{
    public class User_DB_DAL
    {
        public Common.Model.User_DB_Model GetModel(string sUserID)
        {
            //该表无主键信息，请自定义主键/条件字段
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 USER_ID,USER_NAME,PASSWORD,USER_GROUP,UPDATED_TIME,UPDATED_BY,DEPARTMENT,FINGER_TEMPLATE,SHIFT,FINGER_TEMPLATE_1 from User_DB ");
            strSql.Append(" where ");
            strSql.Append(" USER_ID=@USER_ID ");
            SqlParameter[] parameters = {
                    new SqlParameter("@USER_ID", SqlDbType.VarChar,50)};

            parameters[0].Value = sUserID;

            DBHelp.Reports.LogFile.DebugLog("AUTOCODE", "NameSpace:Common.DAL", "Class:User_DB_DAL", "Function:		public Common.Model.User_DB_Model GetModel()" + "TableName:User_DB", "");
            Common.Model.User_DB_Model model = new Common.Model.User_DB_Model();
            DataSet ds = DBHelp.SqlDB.Query(strSql.ToString(), parameters);
            if (ds.Tables[0].Rows.Count > 0)
            {
                model.userID = ds.Tables[0].Rows[0]["USER_ID"].ToString();
                model.userName = ds.Tables[0].Rows[0]["USER_NAME"].ToString();
                model.Password = ds.Tables[0].Rows[0]["PASSWORD"].ToString();
                model.User_group = ds.Tables[0].Rows[0]["USER_GROUP"].ToString();
                if (ds.Tables[0].Rows[0]["UPDATED_TIME"].ToString() != "")
                {
                    model.Updated_time = DateTime.Parse(ds.Tables[0].Rows[0]["UPDATED_TIME"].ToString());
                }
                model.Updated_By = ds.Tables[0].Rows[0]["UPDATED_BY"].ToString();
                model.Department = ds.Tables[0].Rows[0]["DEPARTMENT"].ToString();
                model.Finger_Template= ds.Tables[0].Rows[0]["FINGER_TEMPLATE"].ToString();
                model.Shift = ds.Tables[0].Rows[0]["SHIFT"].ToString();
                model.Finger_Template_1 = ds.Tables[0].Rows[0]["FINGER_TEMPLATE_1"].ToString();
                return model;
            }
            else
            {
                return null;
            }
        }

        public bool CheckIDPassword(string sID,string sPassword)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append(" select USER_ID,USER_NAME,PASSWORD,USER_GROUP,UPDATED_TIME,UPDATED_BY,DEPARTMENT,FINGER_TEMPLATE,SHIFT,FINGER_TEMPLATE_1 from User_DB ");
            strSql.Append(" where ");
            strSql.Append(" USER_ID=@USER_ID ");
            strSql.Append(" and PASSWORD=@PASSWORD ");
            SqlParameter[] parameters = {
                    new SqlParameter("@USER_ID", SqlDbType.VarChar,50),
                    new SqlParameter("@PASSWORD", SqlDbType.VarChar,50)};

            parameters[0].Value = sID;
            parameters[1].Value = sPassword;
            DataSet ds = DBHelp.SqlDB.Query(strSql.ToString(), parameters);
            if (ds.Tables[0].Rows.Count > 0)
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

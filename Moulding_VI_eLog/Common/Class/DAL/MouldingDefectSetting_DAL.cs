
using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using DBHelp;
namespace Common.DAL
{
	/// <summary>
	/// 数据访问类:MouldingDefectSetting_DAL
	/// </summary>
	public class MouldingDefectSetting_DAL
	{
		public MouldingDefectSetting_DAL()
		{}
		#region  Method



		/// <summary>
		/// 增加一条数据
		/// </summary>
		public void Add(Common.Model.MouldingDefectSetting_Model model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into MouldingDefectSetting(");
			strSql.Append("defectCodeID,defectCode,defectDescription,partNumber,model,jigNo,machineID,userName,dateTime,remarks)");
			strSql.Append(" values (");
			strSql.Append("@defectCodeID,@defectCode,@defectDescription,@partNumber,@model,@jigNo,@machineID,@userName,@dateTime,@remarks)");
			SqlParameter[] parameters = {
					new SqlParameter("@defectCodeID", SqlDbType.VarChar,50),
					new SqlParameter("@defectCode", SqlDbType.VarChar,50),
					new SqlParameter("@defectDescription", SqlDbType.VarChar,200),
					new SqlParameter("@partNumber", SqlDbType.VarChar,50),
					new SqlParameter("@model", SqlDbType.VarChar,50),
					new SqlParameter("@jigNo", SqlDbType.VarChar,50),
					new SqlParameter("@machineID", SqlDbType.VarChar,8),
					new SqlParameter("@userName", SqlDbType.VarChar,50),
					new SqlParameter("@dateTime", SqlDbType.SmallDateTime),
					new SqlParameter("@remarks", SqlDbType.VarChar,500)};
			 DBHelp.Reports.LogFile.DebugLog("AUTOCODE","NameSpace:Common.DAL" , "Class:MouldingDefectSetting_DAL" , "Function:		public void Add(Common.Model.MouldingDefectSetting_Model model)"  + "TableName:MouldingDefectSetting" , ";defectCodeID = "+ (model.defectCodeID == null ? "" : model.defectCodeID.ToString() ) + ";defectCode = "+ (model.defectCode == null ? "" : model.defectCode.ToString() ) + ";defectDescription = "+ (model.defectDescription == null ? "" : model.defectDescription.ToString() ) + ";partNumber = "+ (model.partNumber == null ? "" : model.partNumber.ToString() ) + ";model = "+ (model.model == null ? "" : model.model.ToString() ) + ";jigNo = "+ (model.jigNo == null ? "" : model.jigNo.ToString() ) + ";machineID = "+ (model.machineID == null ? "" : model.machineID.ToString() ) + ";userName = "+ (model.userName == null ? "" : model.userName.ToString() ) + ";dateTime = "+ (model.dateTime == null ? "" : model.dateTime.ToString() ) + ";remarks = "+ (model.remarks == null ? "" : model.remarks.ToString() ) + "");
			parameters[0].Value = model.defectCodeID == null ? (object)DBNull.Value : model.defectCodeID ;
			parameters[1].Value = model.defectCode == null ? (object)DBNull.Value : model.defectCode ;
			parameters[2].Value = model.defectDescription == null ? (object)DBNull.Value : model.defectDescription ;
			parameters[3].Value = model.partNumber == null ? (object)DBNull.Value : model.partNumber ;
			parameters[4].Value = model.model == null ? (object)DBNull.Value : model.model ;
			parameters[5].Value = model.jigNo == null ? (object)DBNull.Value : model.jigNo ;
			parameters[6].Value = model.machineID == null ? (object)DBNull.Value : model.machineID ;
			parameters[7].Value = model.userName == null ? (object)DBNull.Value : model.userName ;
			parameters[8].Value = model.dateTime == null ? (object)DBNull.Value : model.dateTime ;
			parameters[9].Value = model.remarks == null ? (object)DBNull.Value : model.remarks ;

			DBHelp.SqlDB.ExecuteSql(strSql.ToString(),parameters);
		}

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public SqlCommand AddCommand(Common.Model.MouldingDefectSetting_Model model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into MouldingDefectSetting(");
			strSql.Append("defectCodeID,defectCode,defectDescription,partNumber,model,jigNo,machineID,userName,dateTime,remarks)");
			strSql.Append(" values (");
			strSql.Append("@defectCodeID,@defectCode,@defectDescription,@partNumber,@model,@jigNo,@machineID,@userName,@dateTime,@remarks)");
			SqlParameter[] parameters = {
					new SqlParameter("@defectCodeID", SqlDbType.VarChar,50),
					new SqlParameter("@defectCode", SqlDbType.VarChar,50),
					new SqlParameter("@defectDescription", SqlDbType.VarChar,200),
					new SqlParameter("@partNumber", SqlDbType.VarChar,50),
					new SqlParameter("@model", SqlDbType.VarChar,50),
					new SqlParameter("@jigNo", SqlDbType.VarChar,50),
					new SqlParameter("@machineID", SqlDbType.VarChar,8),
					new SqlParameter("@userName", SqlDbType.VarChar,50),
					new SqlParameter("@dateTime", SqlDbType.SmallDateTime),
					new SqlParameter("@remarks", SqlDbType.VarChar,500)};
			 DBHelp.Reports.LogFile.DebugLog("AUTOCODE","NameSpace:Common.DAL" , "Class:MouldingDefectSetting_DAL" , "Function:		public SqlCommand AddCommand(Common.Model.MouldingDefectSetting_Model model)"  + "TableName:MouldingDefectSetting" , ";defectCodeID = "+ (model.defectCodeID == null ? "" : model.defectCodeID.ToString()) + ";defectCode = "+ (model.defectCode == null ? "" : model.defectCode.ToString()) + ";defectDescription = "+ (model.defectDescription == null ? "" : model.defectDescription.ToString()) + ";partNumber = "+ (model.partNumber == null ? "" : model.partNumber.ToString()) + ";model = "+ (model.model == null ? "" : model.model.ToString()) + ";jigNo = "+ (model.jigNo == null ? "" : model.jigNo.ToString()) + ";machineID = "+ (model.machineID == null ? "" : model.machineID.ToString()) + ";userName = "+ (model.userName == null ? "" : model.userName.ToString()) + ";dateTime = "+ (model.dateTime == null ? "" : model.dateTime.ToString()) + ";remarks = "+ (model.remarks == null ? "" : model.remarks.ToString()) + "");
			parameters[0].Value = model.defectCodeID == null ? (object)DBNull.Value : model.defectCodeID ;
			parameters[1].Value = model.defectCode == null ? (object)DBNull.Value : model.defectCode ;
			parameters[2].Value = model.defectDescription == null ? (object)DBNull.Value : model.defectDescription ;
			parameters[3].Value = model.partNumber == null ? (object)DBNull.Value : model.partNumber ;
			parameters[4].Value = model.model == null ? (object)DBNull.Value : model.model ;
			parameters[5].Value = model.jigNo == null ? (object)DBNull.Value : model.jigNo ;
			parameters[6].Value = model.machineID == null ? (object)DBNull.Value : model.machineID ;
			parameters[7].Value = model.userName == null ? (object)DBNull.Value : model.userName ;
			parameters[8].Value = model.dateTime == null ? (object)DBNull.Value : model.dateTime ;
			parameters[9].Value = model.remarks == null ? (object)DBNull.Value : model.remarks ;

			 return DBHelp.SqlDB.generateCommand(strSql.ToString(),parameters);
		}
		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(Common.Model.MouldingDefectSetting_Model model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update MouldingDefectSetting set ");
			strSql.Append("defectCodeID=@defectCodeID,");
			strSql.Append("defectCode=@defectCode,");
			strSql.Append("defectDescription=@defectDescription,");
			strSql.Append("partNumber=@partNumber,");
			strSql.Append("model=@model,");
			strSql.Append("jigNo=@jigNo,");
			strSql.Append("machineID=@machineID,");
			strSql.Append("userName=@userName,");
			strSql.Append("dateTime=@dateTime,");
			strSql.Append("remarks=@remarks");
			strSql.Append(" where ");
			SqlParameter[] parameters = {
					new SqlParameter("@defectCodeID", SqlDbType.VarChar,50),
					new SqlParameter("@defectCode", SqlDbType.VarChar,50),
					new SqlParameter("@defectDescription", SqlDbType.VarChar,200),
					new SqlParameter("@partNumber", SqlDbType.VarChar,50),
					new SqlParameter("@model", SqlDbType.VarChar,50),
					new SqlParameter("@jigNo", SqlDbType.VarChar,50),
					new SqlParameter("@machineID", SqlDbType.VarChar,8),
					new SqlParameter("@userName", SqlDbType.VarChar,50),
					new SqlParameter("@dateTime", SqlDbType.SmallDateTime),
					new SqlParameter("@remarks", SqlDbType.VarChar,500)};
			parameters[0].Value = model.defectCodeID == null ? (object)DBNull.Value : model.defectCodeID ;
			parameters[1].Value = model.defectCode == null ? (object)DBNull.Value : model.defectCode ;
			parameters[2].Value = model.defectDescription == null ? (object)DBNull.Value : model.defectDescription ;
			parameters[3].Value = model.partNumber == null ? (object)DBNull.Value : model.partNumber ;
			parameters[4].Value = model.model == null ? (object)DBNull.Value : model.model ;
			parameters[5].Value = model.jigNo == null ? (object)DBNull.Value : model.jigNo ;
			parameters[6].Value = model.machineID == null ? (object)DBNull.Value : model.machineID ;
			parameters[7].Value = model.userName == null ? (object)DBNull.Value : model.userName ;
			parameters[8].Value = model.dateTime == null ? (object)DBNull.Value : model.dateTime ;
			parameters[9].Value = model.remarks == null ? (object)DBNull.Value : model.remarks ;

			 DBHelp.Reports.LogFile.DebugLog("AUTOCODE","NameSpace:Common.DAL" , "Class:MouldingDefectSetting_DAL" , "Function:		public bool Update(Common.Model.MouldingDefectSetting_Model model)"  + "TableName:MouldingDefectSetting" , ";defectCodeID = "+ (model.defectCodeID == null ? "" : model.defectCodeID.ToString() ) + ";defectCode = "+ (model.defectCode == null ? "" : model.defectCode.ToString() ) + ";defectDescription = "+ (model.defectDescription == null ? "" : model.defectDescription.ToString() ) + ";partNumber = "+ (model.partNumber == null ? "" : model.partNumber.ToString() ) + ";model = "+ (model.model == null ? "" : model.model.ToString() ) + ";jigNo = "+ (model.jigNo == null ? "" : model.jigNo.ToString() ) + ";machineID = "+ (model.machineID == null ? "" : model.machineID.ToString() ) + ";userName = "+ (model.userName == null ? "" : model.userName.ToString() ) + ";dateTime = "+ (model.dateTime == null ? "" : model.dateTime.ToString() ) + ";remarks = "+ (model.remarks == null ? "" : model.remarks.ToString() ) + "");
			int rows=DBHelp.SqlDB.ExecuteSql(strSql.ToString(),parameters);
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
		/// 更新一条数据
		/// </summary>
		public SqlCommand UpdateCommand(Common.Model.MouldingDefectSetting_Model model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update MouldingDefectSetting set ");
			strSql.Append("defectCodeID=@defectCodeID,");
			strSql.Append("defectCode=@defectCode,");
			strSql.Append("defectDescription=@defectDescription,");
			strSql.Append("partNumber=@partNumber,");
			strSql.Append("model=@model,");
			strSql.Append("jigNo=@jigNo,");
			strSql.Append("machineID=@machineID,");
			strSql.Append("userName=@userName,");
			strSql.Append("dateTime=@dateTime,");
			strSql.Append("remarks=@remarks");
			strSql.Append(" where ");
			SqlParameter[] parameters = {
					new SqlParameter("@defectCodeID", SqlDbType.VarChar,50),
					new SqlParameter("@defectCode", SqlDbType.VarChar,50),
					new SqlParameter("@defectDescription", SqlDbType.VarChar,200),
					new SqlParameter("@partNumber", SqlDbType.VarChar,50),
					new SqlParameter("@model", SqlDbType.VarChar,50),
					new SqlParameter("@jigNo", SqlDbType.VarChar,50),
					new SqlParameter("@machineID", SqlDbType.VarChar,8),
					new SqlParameter("@userName", SqlDbType.VarChar,50),
					new SqlParameter("@dateTime", SqlDbType.SmallDateTime),
					new SqlParameter("@remarks", SqlDbType.VarChar,500)};
			parameters[0].Value = model.defectCodeID == null ? (object)DBNull.Value : model.defectCodeID ;
			parameters[1].Value = model.defectCode == null ? (object)DBNull.Value : model.defectCode ;
			parameters[2].Value = model.defectDescription == null ? (object)DBNull.Value : model.defectDescription ;
			parameters[3].Value = model.partNumber == null ? (object)DBNull.Value : model.partNumber ;
			parameters[4].Value = model.model == null ? (object)DBNull.Value : model.model ;
			parameters[5].Value = model.jigNo == null ? (object)DBNull.Value : model.jigNo ;
			parameters[6].Value = model.machineID == null ? (object)DBNull.Value : model.machineID ;
			parameters[7].Value = model.userName == null ? (object)DBNull.Value : model.userName ;
			parameters[8].Value = model.dateTime == null ? (object)DBNull.Value : model.dateTime ;
			parameters[9].Value = model.remarks == null ? (object)DBNull.Value : model.remarks ;

			 DBHelp.Reports.LogFile.DebugLog("AUTOCODE","NameSpace:Common.DAL" , "Class:MouldingDefectSetting_DAL" , "Function:		public SqlCommand UpdateCommand(Common.Model.MouldingDefectSetting_Model model)"  + "TableName:MouldingDefectSetting" , ";defectCodeID = "+ (model.defectCodeID == null ? "" : model.defectCodeID.ToString()) + ";defectCode = "+ (model.defectCode == null ? "" : model.defectCode.ToString()) + ";defectDescription = "+ (model.defectDescription == null ? "" : model.defectDescription.ToString()) + ";partNumber = "+ (model.partNumber == null ? "" : model.partNumber.ToString()) + ";model = "+ (model.model == null ? "" : model.model.ToString()) + ";jigNo = "+ (model.jigNo == null ? "" : model.jigNo.ToString()) + ";machineID = "+ (model.machineID == null ? "" : model.machineID.ToString()) + ";userName = "+ (model.userName == null ? "" : model.userName.ToString()) + ";dateTime = "+ (model.dateTime == null ? "" : model.dateTime.ToString()) + ";remarks = "+ (model.remarks == null ? "" : model.remarks.ToString()) + "");
			return DBHelp.SqlDB.generateCommand(strSql.ToString(),parameters);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete()
		{
			//该表无主键信息，请自定义主键/条件字段
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from MouldingDefectSetting ");
			strSql.Append(" where ");
			SqlParameter[] parameters = {
};

			 DBHelp.Reports.LogFile.DebugLog("AUTOCODE","NameSpace:Common.DAL" , "Class:MouldingDefectSetting_DAL" , "Function:		public bool Delete()"  + "TableName:MouldingDefectSetting" , "");
			int rows=DBHelp.SqlDB.ExecuteSql(strSql.ToString(),parameters);
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
		public SqlCommand DeleteCommand()
		{
			//该表无主键信息，请自定义主键/条件字段
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from MouldingDefectSetting ");
			strSql.Append(" where ");
			SqlParameter[] parameters = {
};

			 DBHelp.Reports.LogFile.DebugLog("AUTOCODE","NameSpace:Common.DAL" , "Class:MouldingDefectSetting_DAL" , "Function:		public SqlCommand DeleteCommand()"  + "TableName:MouldingDefectSetting" , "");
			return DBHelp.SqlDB.generateCommand(strSql.ToString(),parameters);
		}
		/// <summary>
		/// 删除一条数据
		/// </summary>
		public SqlCommand DeleteAllCommand( )
		{
			//该表无主键信息，请自定义主键/条件字段
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from MouldingDefectSetting ");
			 DBHelp.Reports.LogFile.DebugLog("AUTOCODE","NameSpace:Common.DAL" , "Class:MouldingDefectSetting_DAL" , "Function:		public SqlCommand DeleteAllCommand( )"  + "TableName:MouldingDefectSetting" , "");
			return DBHelp.SqlDB.generateCommand(strSql.ToString(), new SqlParameter[0]);
		}


		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public Common.Model.MouldingDefectSetting_Model GetModel()
		{
			//该表无主键信息，请自定义主键/条件字段
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 defectCodeID,defectCode,defectDescription,partNumber,model,jigNo,machineID,userName,dateTime,remarks from MouldingDefectSetting ");
			strSql.Append(" where ");
			SqlParameter[] parameters = {
};

			 DBHelp.Reports.LogFile.DebugLog("AUTOCODE","NameSpace:Common.DAL" , "Class:MouldingDefectSetting_DAL" , "Function:		public Common.Model.MouldingDefectSetting_Model GetModel()"  + "TableName:MouldingDefectSetting" , "");
			Common.Model.MouldingDefectSetting_Model model=new Common.Model.MouldingDefectSetting_Model();
			DataSet ds=DBHelp.SqlDB.Query(strSql.ToString(),parameters);
			if(ds.Tables[0].Rows.Count>0)
			{
				model.defectCodeID=ds.Tables[0].Rows[0]["defectCodeID"].ToString();
				model.defectCode=ds.Tables[0].Rows[0]["defectCode"].ToString();
				model.defectDescription=ds.Tables[0].Rows[0]["defectDescription"].ToString();
				model.partNumber=ds.Tables[0].Rows[0]["partNumber"].ToString();
				model.model=ds.Tables[0].Rows[0]["model"].ToString();
				model.jigNo=ds.Tables[0].Rows[0]["jigNo"].ToString();
				model.machineID=ds.Tables[0].Rows[0]["machineID"].ToString();
				model.userName=ds.Tables[0].Rows[0]["userName"].ToString();
				if(ds.Tables[0].Rows[0]["dateTime"].ToString()!="")
				{
					model.dateTime=DateTime.Parse(ds.Tables[0].Rows[0]["dateTime"].ToString());
				}
				model.remarks=ds.Tables[0].Rows[0]["remarks"].ToString();
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
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select defectCodeID,defectCode,defectDescription,partNumber,model,jigNo,machineID,userName,dateTime,remarks ");
			strSql.Append(" FROM MouldingDefectSetting ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			return DBHelp.SqlDB.Query(strSql.ToString());
		}

		/// <summary>
		/// 获得前几行数据
		/// </summary>
		public DataSet GetList(int Top,string strWhere,string filedOrder)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select ");
			if(Top>0)
			{
				strSql.Append(" top "+Top.ToString());
			}
			strSql.Append(" defectCodeID,defectCode,defectDescription,partNumber,model,jigNo,machineID,userName,dateTime,remarks ");
			strSql.Append(" FROM MouldingDefectSetting ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
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
			parameters[0].Value = "MouldingDefectSetting";
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


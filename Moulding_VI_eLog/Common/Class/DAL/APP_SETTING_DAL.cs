
using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using DBHelp;
namespace Common.DAL
{
	/// <summary>
	/// 数据访问类:APP_SETTING_DAL
	/// </summary>
	public class APP_SETTING_DAL
	{
		public APP_SETTING_DAL()
		{}
		#region  Method

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public DataSet Exists(string ITEM,string TYPE)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from APP_SETTING");
			strSql.Append(" where ITEM=@ITEM and TYPE=@TYPE ");
			SqlParameter[] parameters = {
					new SqlParameter("@ITEM", SqlDbType.VarChar,-1),
					new SqlParameter("@TYPE", SqlDbType.VarChar,-1)};
			parameters[0].Value = ITEM == null ? (object)DBNull.Value : ITEM;
			parameters[1].Value = TYPE == null ? (object)DBNull.Value : TYPE;

			return DBHelp.SqlDB.Query(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public void Add(Common.Model.APP_SETTING_Model model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into APP_SETTING(");
			strSql.Append("ITEM,VALUE,VOID,REMARK,DEPARTMENT,PROCESS,UPDATED_TIME,UPDATED_USER,TYPE)");
			strSql.Append(" values (");
			strSql.Append("@ITEM,@VALUE,@VOID,@REMARK,@DEPARTMENT,@PROCESS,@UPDATED_TIME,@UPDATED_USER,@TYPE)");
			SqlParameter[] parameters = {
					new SqlParameter("@ITEM", SqlDbType.VarChar,50),
					new SqlParameter("@VALUE", SqlDbType.VarChar,2000),
					new SqlParameter("@VOID", SqlDbType.VarChar,1),
					new SqlParameter("@REMARK", SqlDbType.VarChar,100),
					new SqlParameter("@DEPARTMENT", SqlDbType.VarChar,10),
					new SqlParameter("@PROCESS", SqlDbType.VarChar,10),
					new SqlParameter("@UPDATED_TIME", SqlDbType.DateTime2,8),
					new SqlParameter("@UPDATED_USER", SqlDbType.VarChar,30),
					new SqlParameter("@TYPE", SqlDbType.VarChar,30)};
			 DBHelp.Reports.LogFile.DebugLog("AUTOCODE","NameSpace:Common.DAL" , "Class:APP_SETTING_DAL" , "Function:		public void Add(Common.Model.APP_SETTING_Model model)"  + "TableName:APP_SETTING" , ";ITEM = "+ (model.ITEM == null ? "" : model.ITEM.ToString() ) + ";VALUE = "+ (model.VALUE == null ? "" : model.VALUE.ToString() ) + ";VOID = "+ (model.VOID == null ? "" : model.VOID.ToString() ) + ";REMARK = "+ (model.REMARK == null ? "" : model.REMARK.ToString() ) + ";DEPARTMENT = "+ (model.DEPARTMENT == null ? "" : model.DEPARTMENT.ToString() ) + ";PROCESS = "+ (model.PROCESS == null ? "" : model.PROCESS.ToString() ) + ";UPDATED_TIME = "+ (model.UPDATED_TIME == null ? "" : model.UPDATED_TIME.ToString() ) + ";UPDATED_USER = "+ (model.UPDATED_USER == null ? "" : model.UPDATED_USER.ToString() ) + ";TYPE = "+ (model.TYPE == null ? "" : model.TYPE.ToString() ) + "");
			parameters[0].Value = model.ITEM == null ? (object)DBNull.Value : model.ITEM ;
			parameters[1].Value = model.VALUE == null ? (object)DBNull.Value : model.VALUE ;
			parameters[2].Value = model.VOID == null ? (object)DBNull.Value : model.VOID ;
			parameters[3].Value = model.REMARK == null ? (object)DBNull.Value : model.REMARK ;
			parameters[4].Value = model.DEPARTMENT == null ? (object)DBNull.Value : model.DEPARTMENT ;
			parameters[5].Value = model.PROCESS == null ? (object)DBNull.Value : model.PROCESS ;
			parameters[6].Value = model.UPDATED_TIME == null ? (object)DBNull.Value : model.UPDATED_TIME ;
			parameters[7].Value = model.UPDATED_USER == null ? (object)DBNull.Value : model.UPDATED_USER ;
			parameters[8].Value = model.TYPE == null ? (object)DBNull.Value : model.TYPE ;

			DBHelp.SqlDB.ExecuteSql(strSql.ToString(),parameters);
		}

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public SqlCommand AddCommand(Common.Model.APP_SETTING_Model model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into APP_SETTING(");
			strSql.Append("ITEM,VALUE,VOID,REMARK,DEPARTMENT,PROCESS,UPDATED_TIME,UPDATED_USER,TYPE)");
			strSql.Append(" values (");
			strSql.Append("@ITEM,@VALUE,@VOID,@REMARK,@DEPARTMENT,@PROCESS,@UPDATED_TIME,@UPDATED_USER,@TYPE)");
			SqlParameter[] parameters = {
					new SqlParameter("@ITEM", SqlDbType.VarChar,50),
					new SqlParameter("@VALUE", SqlDbType.VarChar,2000),
					new SqlParameter("@VOID", SqlDbType.VarChar,1),
					new SqlParameter("@REMARK", SqlDbType.VarChar,100),
					new SqlParameter("@DEPARTMENT", SqlDbType.VarChar,10),
					new SqlParameter("@PROCESS", SqlDbType.VarChar,10),
					new SqlParameter("@UPDATED_TIME", SqlDbType.DateTime2,8),
					new SqlParameter("@UPDATED_USER", SqlDbType.VarChar,30),
					new SqlParameter("@TYPE", SqlDbType.VarChar,30)};
			 DBHelp.Reports.LogFile.DebugLog("AUTOCODE","NameSpace:Common.DAL" , "Class:APP_SETTING_DAL" , "Function:		public SqlCommand AddCommand(Common.Model.APP_SETTING_Model model)"  + "TableName:APP_SETTING" , ";ITEM = "+ (model.ITEM == null ? "" : model.ITEM.ToString()) + ";VALUE = "+ (model.VALUE == null ? "" : model.VALUE.ToString()) + ";VOID = "+ (model.VOID == null ? "" : model.VOID.ToString()) + ";REMARK = "+ (model.REMARK == null ? "" : model.REMARK.ToString()) + ";DEPARTMENT = "+ (model.DEPARTMENT == null ? "" : model.DEPARTMENT.ToString()) + ";PROCESS = "+ (model.PROCESS == null ? "" : model.PROCESS.ToString()) + ";UPDATED_TIME = "+ (model.UPDATED_TIME == null ? "" : model.UPDATED_TIME.ToString()) + ";UPDATED_USER = "+ (model.UPDATED_USER == null ? "" : model.UPDATED_USER.ToString()) + ";TYPE = "+ (model.TYPE == null ? "" : model.TYPE.ToString()) + "");
			parameters[0].Value = model.ITEM == null ? (object)DBNull.Value : model.ITEM ;
			parameters[1].Value = model.VALUE == null ? (object)DBNull.Value : model.VALUE ;
			parameters[2].Value = model.VOID == null ? (object)DBNull.Value : model.VOID ;
			parameters[3].Value = model.REMARK == null ? (object)DBNull.Value : model.REMARK ;
			parameters[4].Value = model.DEPARTMENT == null ? (object)DBNull.Value : model.DEPARTMENT ;
			parameters[5].Value = model.PROCESS == null ? (object)DBNull.Value : model.PROCESS ;
			parameters[6].Value = model.UPDATED_TIME == null ? (object)DBNull.Value : model.UPDATED_TIME ;
			parameters[7].Value = model.UPDATED_USER == null ? (object)DBNull.Value : model.UPDATED_USER ;
			parameters[8].Value = model.TYPE == null ? (object)DBNull.Value : model.TYPE ;

			 return DBHelp.SqlDB.generateCommand(strSql.ToString(),parameters);
		}
		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(Common.Model.APP_SETTING_Model model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update APP_SETTING set ");
			strSql.Append("VALUE=@VALUE,");
			strSql.Append("VOID=@VOID,");
			strSql.Append("REMARK=@REMARK,");
			strSql.Append("DEPARTMENT=@DEPARTMENT,");
			strSql.Append("PROCESS=@PROCESS,");
			strSql.Append("UPDATED_TIME=@UPDATED_TIME,");
			strSql.Append("UPDATED_USER=@UPDATED_USER");
			strSql.Append(" where ITEM=@ITEM and TYPE=@TYPE ");
			SqlParameter[] parameters = {
					new SqlParameter("@ITEM", SqlDbType.VarChar,50),
					new SqlParameter("@VALUE", SqlDbType.VarChar,2000),
					new SqlParameter("@VOID", SqlDbType.VarChar,1),
					new SqlParameter("@REMARK", SqlDbType.VarChar,100),
					new SqlParameter("@DEPARTMENT", SqlDbType.VarChar,10),
					new SqlParameter("@PROCESS", SqlDbType.VarChar,10),
					new SqlParameter("@UPDATED_TIME", SqlDbType.DateTime2,8),
					new SqlParameter("@UPDATED_USER", SqlDbType.VarChar,30),
					new SqlParameter("@TYPE", SqlDbType.VarChar,30)};
			parameters[0].Value = model.ITEM == null ? (object)DBNull.Value : model.ITEM ;
			parameters[1].Value = model.VALUE == null ? (object)DBNull.Value : model.VALUE ;
			parameters[2].Value = model.VOID == null ? (object)DBNull.Value : model.VOID ;
			parameters[3].Value = model.REMARK == null ? (object)DBNull.Value : model.REMARK ;
			parameters[4].Value = model.DEPARTMENT == null ? (object)DBNull.Value : model.DEPARTMENT ;
			parameters[5].Value = model.PROCESS == null ? (object)DBNull.Value : model.PROCESS ;
			parameters[6].Value = model.UPDATED_TIME == null ? (object)DBNull.Value : model.UPDATED_TIME ;
			parameters[7].Value = model.UPDATED_USER == null ? (object)DBNull.Value : model.UPDATED_USER ;
			parameters[8].Value = model.TYPE == null ? (object)DBNull.Value : model.TYPE ;

			 DBHelp.Reports.LogFile.DebugLog("AUTOCODE","NameSpace:Common.DAL" , "Class:APP_SETTING_DAL" , "Function:		public bool Update(Common.Model.APP_SETTING_Model model)"  + "TableName:APP_SETTING" , ";ITEM = "+ (model.ITEM == null ? "" : model.ITEM.ToString() ) + ";VALUE = "+ (model.VALUE == null ? "" : model.VALUE.ToString() ) + ";VOID = "+ (model.VOID == null ? "" : model.VOID.ToString() ) + ";REMARK = "+ (model.REMARK == null ? "" : model.REMARK.ToString() ) + ";DEPARTMENT = "+ (model.DEPARTMENT == null ? "" : model.DEPARTMENT.ToString() ) + ";PROCESS = "+ (model.PROCESS == null ? "" : model.PROCESS.ToString() ) + ";UPDATED_TIME = "+ (model.UPDATED_TIME == null ? "" : model.UPDATED_TIME.ToString() ) + ";UPDATED_USER = "+ (model.UPDATED_USER == null ? "" : model.UPDATED_USER.ToString() ) + ";TYPE = "+ (model.TYPE == null ? "" : model.TYPE.ToString() ) + "");
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
		public SqlCommand UpdateCommand(Common.Model.APP_SETTING_Model model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update APP_SETTING set ");
			strSql.Append("VALUE=@VALUE,");
			strSql.Append("VOID=@VOID,");
			strSql.Append("REMARK=@REMARK,");
			strSql.Append("DEPARTMENT=@DEPARTMENT,");
			strSql.Append("PROCESS=@PROCESS,");
			strSql.Append("UPDATED_TIME=@UPDATED_TIME,");
			strSql.Append("UPDATED_USER=@UPDATED_USER");
			strSql.Append(" where ITEM=@ITEM and TYPE=@TYPE ");
			SqlParameter[] parameters = {
					new SqlParameter("@ITEM", SqlDbType.VarChar,50),
					new SqlParameter("@VALUE", SqlDbType.VarChar,2000),
					new SqlParameter("@VOID", SqlDbType.VarChar,1),
					new SqlParameter("@REMARK", SqlDbType.VarChar,100),
					new SqlParameter("@DEPARTMENT", SqlDbType.VarChar,10),
					new SqlParameter("@PROCESS", SqlDbType.VarChar,10),
					new SqlParameter("@UPDATED_TIME", SqlDbType.DateTime2,8),
					new SqlParameter("@UPDATED_USER", SqlDbType.VarChar,30),
					new SqlParameter("@TYPE", SqlDbType.VarChar,30)};
			parameters[0].Value = model.ITEM == null ? (object)DBNull.Value : model.ITEM ;
			parameters[1].Value = model.VALUE == null ? (object)DBNull.Value : model.VALUE ;
			parameters[2].Value = model.VOID == null ? (object)DBNull.Value : model.VOID ;
			parameters[3].Value = model.REMARK == null ? (object)DBNull.Value : model.REMARK ;
			parameters[4].Value = model.DEPARTMENT == null ? (object)DBNull.Value : model.DEPARTMENT ;
			parameters[5].Value = model.PROCESS == null ? (object)DBNull.Value : model.PROCESS ;
			parameters[6].Value = model.UPDATED_TIME == null ? (object)DBNull.Value : model.UPDATED_TIME ;
			parameters[7].Value = model.UPDATED_USER == null ? (object)DBNull.Value : model.UPDATED_USER ;
			parameters[8].Value = model.TYPE == null ? (object)DBNull.Value : model.TYPE ;

			 DBHelp.Reports.LogFile.DebugLog("AUTOCODE","NameSpace:Common.DAL" , "Class:APP_SETTING_DAL" , "Function:		public SqlCommand UpdateCommand(Common.Model.APP_SETTING_Model model)"  + "TableName:APP_SETTING" , ";ITEM = "+ (model.ITEM == null ? "" : model.ITEM.ToString()) + ";VALUE = "+ (model.VALUE == null ? "" : model.VALUE.ToString()) + ";VOID = "+ (model.VOID == null ? "" : model.VOID.ToString()) + ";REMARK = "+ (model.REMARK == null ? "" : model.REMARK.ToString()) + ";DEPARTMENT = "+ (model.DEPARTMENT == null ? "" : model.DEPARTMENT.ToString()) + ";PROCESS = "+ (model.PROCESS == null ? "" : model.PROCESS.ToString()) + ";UPDATED_TIME = "+ (model.UPDATED_TIME == null ? "" : model.UPDATED_TIME.ToString()) + ";UPDATED_USER = "+ (model.UPDATED_USER == null ? "" : model.UPDATED_USER.ToString()) + ";TYPE = "+ (model.TYPE == null ? "" : model.TYPE.ToString()) + "");
			return DBHelp.SqlDB.generateCommand(strSql.ToString(),parameters);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(string ITEM,string TYPE)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from APP_SETTING ");
			strSql.Append(" where ITEM=@ITEM and TYPE=@TYPE ");
			SqlParameter[] parameters = {
					new SqlParameter("@ITEM", SqlDbType.VarChar,-1),
					new SqlParameter("@TYPE", SqlDbType.VarChar,-1)};
			parameters[0].Value = ITEM == null ? (object)DBNull.Value : ITEM;
			parameters[1].Value = TYPE == null ? (object)DBNull.Value : TYPE;

			 DBHelp.Reports.LogFile.DebugLog("AUTOCODE","NameSpace:Common.DAL" , "Class:APP_SETTING_DAL" , "Function:		public bool Delete(string ITEM,string TYPE)"  + "TableName:APP_SETTING" , ";ITEM = "+ ITEM == null ? "" : ITEM.ToString() + ";TYPE = "+ TYPE == null ? "" : TYPE.ToString() + "");
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
		public SqlCommand DeleteCommand(string ITEM,string TYPE)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from APP_SETTING ");
			strSql.Append(" where ITEM=@ITEM and TYPE=@TYPE ");
			SqlParameter[] parameters = {
					new SqlParameter("@ITEM", SqlDbType.VarChar,-1),
					new SqlParameter("@TYPE", SqlDbType.VarChar,-1)};
			parameters[0].Value = ITEM == null ? (object)DBNull.Value : ITEM;
			parameters[1].Value = TYPE == null ? (object)DBNull.Value : TYPE;

			 DBHelp.Reports.LogFile.DebugLog("AUTOCODE","NameSpace:Common.DAL" , "Class:APP_SETTING_DAL" , "Function:		public SqlCommand DeleteCommand(string ITEM,string TYPE)"  + "TableName:APP_SETTING" , ";ITEM = "+ ITEM == null ? "" : ITEM.ToString() + ";TYPE = "+ TYPE == null ? "" : TYPE.ToString() + "");
			return DBHelp.SqlDB.generateCommand(strSql.ToString(),parameters);
		}
		/// <summary>
		/// 删除一条数据
		/// </summary>
		public SqlCommand DeleteAllCommand( )
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from APP_SETTING ");
			 DBHelp.Reports.LogFile.DebugLog("AUTOCODE","NameSpace:Common.DAL" , "Class:APP_SETTING_DAL" , "Function:		public SqlCommand DeleteAllCommand( )"  + "TableName:APP_SETTING" , "");
			return DBHelp.SqlDB.generateCommand(strSql.ToString(), new SqlParameter[0]);
		}


		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public Common.Model.APP_SETTING_Model GetModel(string ITEM,string TYPE)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 ITEM,VALUE,VOID,REMARK,DEPARTMENT,PROCESS,UPDATED_TIME,UPDATED_USER,TYPE from APP_SETTING ");
			strSql.Append(" where ITEM=@ITEM and TYPE=@TYPE ");
			SqlParameter[] parameters = {
					new SqlParameter("@ITEM", SqlDbType.VarChar,-1),
					new SqlParameter("@TYPE", SqlDbType.VarChar,-1)};
			parameters[0].Value = ITEM == null ? (object)DBNull.Value : ITEM;
			parameters[1].Value = TYPE == null ? (object)DBNull.Value : TYPE;

			 DBHelp.Reports.LogFile.DebugLog("AUTOCODE","NameSpace:Common.DAL" , "Class:APP_SETTING_DAL" , "Function:		public Common.Model.APP_SETTING_Model GetModel(string ITEM,string TYPE)"  + "TableName:APP_SETTING" , ";ITEM = "+ ITEM == null ? "" : ITEM.ToString() + ";TYPE = "+ TYPE == null ? "" : TYPE.ToString() + "");
			Common.Model.APP_SETTING_Model model=new Common.Model.APP_SETTING_Model();
			DataSet ds=DBHelp.SqlDB.Query(strSql.ToString(),parameters);
			if(ds.Tables[0].Rows.Count>0)
			{
				model.ITEM=ds.Tables[0].Rows[0]["ITEM"].ToString();
				model.VALUE=ds.Tables[0].Rows[0]["VALUE"].ToString();
				model.VOID=ds.Tables[0].Rows[0]["VOID"].ToString();
				model.REMARK=ds.Tables[0].Rows[0]["REMARK"].ToString();
				model.DEPARTMENT=ds.Tables[0].Rows[0]["DEPARTMENT"].ToString();
				model.PROCESS=ds.Tables[0].Rows[0]["PROCESS"].ToString();
				if(ds.Tables[0].Rows[0]["UPDATED_TIME"].ToString()!="")
				{
					model.UPDATED_TIME=DateTime.Parse(ds.Tables[0].Rows[0]["UPDATED_TIME"].ToString());
				}
				model.UPDATED_USER=ds.Tables[0].Rows[0]["UPDATED_USER"].ToString();
				model.TYPE=ds.Tables[0].Rows[0]["TYPE"].ToString();
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
			strSql.Append("select ITEM,VALUE,VOID,REMARK,DEPARTMENT,PROCESS,UPDATED_TIME,UPDATED_USER,TYPE ");
			strSql.Append(" FROM APP_SETTING ");
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
			strSql.Append(" ITEM,VALUE,VOID,REMARK,DEPARTMENT,PROCESS,UPDATED_TIME,UPDATED_USER,TYPE ");
			strSql.Append(" FROM APP_SETTING ");
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
			parameters[0].Value = "APP_SETTING";
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


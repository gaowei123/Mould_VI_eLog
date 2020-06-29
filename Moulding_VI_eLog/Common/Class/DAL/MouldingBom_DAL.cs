
using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using DBHelp;
namespace Common.DAL
{
	/// <summary>
	/// 数据访问类:MouldingBom_DAL
	/// </summary>
	public class MouldingBom_DAL
	{
		public MouldingBom_DAL()
		{}
		#region  Method



		/// <summary>
		/// 增加一条数据
		/// </summary>
		public void Add(Common.Model.MouldingBom_Model model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into MouldingBom(");
			strSql.Append("partNumber,matPart01,matPart02,customer,model,jigNo,cavityCount,partsWeight,cycleTime,blockCount,unitCount,machineID,userName,dateTime,remarks,partNumberAll)");
			strSql.Append(" values (");
			strSql.Append("@partNumber,@matPart01,@matPart02,@customer,@model,@jigNo,@cavityCount,@partsWeight,@cycleTime,@blockCount,@unitCount,@machineID,@userName,@dateTime,@remarks,@partNumberAll)");
			SqlParameter[] parameters = {
					new SqlParameter("@partNumber", SqlDbType.VarChar,50),
					new SqlParameter("@matPart01", SqlDbType.VarChar,50),
					new SqlParameter("@matPart02", SqlDbType.VarChar,50),
					new SqlParameter("@customer", SqlDbType.VarChar,50),
					new SqlParameter("@model", SqlDbType.VarChar,50),
					new SqlParameter("@jigNo", SqlDbType.VarChar,50),
					new SqlParameter("@cavityCount", SqlDbType.Decimal,9),
					new SqlParameter("@partsWeight", SqlDbType.Decimal,9),
					new SqlParameter("@cycleTime", SqlDbType.Decimal,9),
					new SqlParameter("@blockCount", SqlDbType.Int,4),
					new SqlParameter("@unitCount", SqlDbType.Int,4),
					new SqlParameter("@machineID", SqlDbType.VarChar,8),
					new SqlParameter("@userName", SqlDbType.VarChar,50),
					new SqlParameter("@dateTime", SqlDbType.SmallDateTime),
					new SqlParameter("@remarks", SqlDbType.VarChar,500),
                    new SqlParameter("@partNumberAll", SqlDbType.VarChar,500)};
			 DBHelp.Reports.LogFile.DebugLog("AUTOCODE","NameSpace:Common.DAL" , "Class:MouldingBom_DAL" , "Function:		public void Add(Common.Model.MouldingBom_Model model)"  + "TableName:MouldingBom" , ";partNumber = "+ (model.partNumber == null ? "" : model.partNumber.ToString() ) + ";matPart01 = "+ (model.matPart01 == null ? "" : model.matPart01.ToString() ) + ";matPart02 = "+ (model.matPart02 == null ? "" : model.matPart02.ToString() ) + ";customer = "+ (model.customer == null ? "" : model.customer.ToString() ) + ";model = "+ (model.model == null ? "" : model.model.ToString() ) + ";jigNo = "+ (model.jigNo == null ? "" : model.jigNo.ToString() ) + ";cavityCount = "+ (model.cavityCount == null ? "" : model.cavityCount.ToString() ) + ";partsWeight = "+ (model.partsWeight == null ? "" : model.partsWeight.ToString() ) + ";cycleTime = "+ (model.cycleTime == null ? "" : model.cycleTime.ToString() ) + ";blockCount = "+ (model.blockCount == null ? "" : model.blockCount.ToString() ) + ";unitCount = "+ (model.unitCount == null ? "" : model.unitCount.ToString() ) + ";machineID = "+ (model.machineID == null ? "" : model.machineID.ToString() ) + ";userName = "+ (model.userName == null ? "" : model.userName.ToString() ) + ";dateTime = "+ (model.dateTime == null ? "" : model.dateTime.ToString() ) + ";remarks = "+ (model.remarks == null ? "" : model.remarks.ToString() ) + "");
			parameters[0].Value = model.partNumber == null ? (object)DBNull.Value : model.partNumber ;
			parameters[1].Value = model.matPart01 == null ? (object)DBNull.Value : model.matPart01 ;
			parameters[2].Value = model.matPart02 == null ? (object)DBNull.Value : model.matPart02 ;
			parameters[3].Value = model.customer == null ? (object)DBNull.Value : model.customer ;
			parameters[4].Value = model.model == null ? (object)DBNull.Value : model.model ;
			parameters[5].Value = model.jigNo == null ? (object)DBNull.Value : model.jigNo ;
			parameters[6].Value = model.cavityCount == null ? (object)DBNull.Value : model.cavityCount ;
			parameters[7].Value = model.partsWeight == null ? (object)DBNull.Value : model.partsWeight ;
			parameters[8].Value = model.cycleTime == null ? (object)DBNull.Value : model.cycleTime ;
			parameters[9].Value = model.blockCount == null ? (object)DBNull.Value : model.blockCount ;
			parameters[10].Value = model.unitCount == null ? (object)DBNull.Value : model.unitCount ;
			parameters[11].Value = model.machineID == null ? (object)DBNull.Value : model.machineID ;
			parameters[12].Value = model.userName == null ? (object)DBNull.Value : model.userName ;
			parameters[13].Value = model.dateTime == null ? (object)DBNull.Value : model.dateTime ;
			parameters[14].Value = model.remarks == null ? (object)DBNull.Value : model.remarks;
            parameters[15].Value = model.partnumberall == null ? (object)DBNull.Value : model.partnumberall;

            DBHelp.SqlDB.ExecuteSql(strSql.ToString(),parameters);
		}

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public SqlCommand AddCommand(Common.Model.MouldingBom_Model model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into MouldingBom(");
			strSql.Append("partNumber,matPart01,matPart02,customer,model,jigNo,cavityCount,partsWeight,cycleTime,blockCount,unitCount,machineID,userName,dateTime,remarks,partNumberAll)");
			strSql.Append(" values (");
			strSql.Append("@partNumber,@matPart01,@matPart02,@customer,@model,@jigNo,@cavityCount,@partsWeight,@cycleTime,@blockCount,@unitCount,@machineID,@userName,@dateTime,@remarks,@partNumberAll)");
			SqlParameter[] parameters = {
					new SqlParameter("@partNumber", SqlDbType.VarChar,50),
					new SqlParameter("@matPart01", SqlDbType.VarChar,50),
					new SqlParameter("@matPart02", SqlDbType.VarChar,50),
					new SqlParameter("@customer", SqlDbType.VarChar,50),
					new SqlParameter("@model", SqlDbType.VarChar,50),
					new SqlParameter("@jigNo", SqlDbType.VarChar,50),
					new SqlParameter("@cavityCount", SqlDbType.Decimal,9),
					new SqlParameter("@partsWeight", SqlDbType.Decimal,9),
					new SqlParameter("@cycleTime", SqlDbType.Decimal,9),
					new SqlParameter("@blockCount", SqlDbType.Int,4),
					new SqlParameter("@unitCount", SqlDbType.Int,4),
					new SqlParameter("@machineID", SqlDbType.VarChar,8),
					new SqlParameter("@userName", SqlDbType.VarChar,50),
					new SqlParameter("@dateTime", SqlDbType.SmallDateTime),
                    new SqlParameter("@remarks", SqlDbType.VarChar,500),
                    new SqlParameter("@partNumberAll", SqlDbType.VarChar,500)};
            DBHelp.Reports.LogFile.DebugLog("AUTOCODE","NameSpace:Common.DAL" , "Class:MouldingBom_DAL" , "Function:		public SqlCommand AddCommand(Common.Model.MouldingBom_Model model)"  + "TableName:MouldingBom" , ";partNumber = "+ (model.partNumber == null ? "" : model.partNumber.ToString()) + ";matPart01 = "+ (model.matPart01 == null ? "" : model.matPart01.ToString()) + ";matPart02 = "+ (model.matPart02 == null ? "" : model.matPart02.ToString()) + ";customer = "+ (model.customer == null ? "" : model.customer.ToString()) + ";model = "+ (model.model == null ? "" : model.model.ToString()) + ";jigNo = "+ (model.jigNo == null ? "" : model.jigNo.ToString()) + ";cavityCount = "+ (model.cavityCount == null ? "" : model.cavityCount.ToString()) + ";partsWeight = "+ (model.partsWeight == null ? "" : model.partsWeight.ToString()) + ";cycleTime = "+ (model.cycleTime == null ? "" : model.cycleTime.ToString()) + ";blockCount = "+ (model.blockCount == null ? "" : model.blockCount.ToString()) + ";unitCount = "+ (model.unitCount == null ? "" : model.unitCount.ToString()) + ";machineID = "+ (model.machineID == null ? "" : model.machineID.ToString()) + ";userName = "+ (model.userName == null ? "" : model.userName.ToString()) + ";dateTime = "+ (model.dateTime == null ? "" : model.dateTime.ToString()) + ";remarks = "+ (model.remarks == null ? "" : model.remarks.ToString()) + "");
			parameters[0].Value = model.partNumber == null ? (object)DBNull.Value : model.partNumber ;
			parameters[1].Value = model.matPart01 == null ? (object)DBNull.Value : model.matPart01 ;
			parameters[2].Value = model.matPart02 == null ? (object)DBNull.Value : model.matPart02 ;
			parameters[3].Value = model.customer == null ? (object)DBNull.Value : model.customer ;
			parameters[4].Value = model.model == null ? (object)DBNull.Value : model.model ;
			parameters[5].Value = model.jigNo == null ? (object)DBNull.Value : model.jigNo ;
			parameters[6].Value = model.cavityCount == null ? (object)DBNull.Value : model.cavityCount ;
			parameters[7].Value = model.partsWeight == null ? (object)DBNull.Value : model.partsWeight ;
			parameters[8].Value = model.cycleTime == null ? (object)DBNull.Value : model.cycleTime ;
			parameters[9].Value = model.blockCount == null ? (object)DBNull.Value : model.blockCount ;
			parameters[10].Value = model.unitCount == null ? (object)DBNull.Value : model.unitCount ;
			parameters[11].Value = model.machineID == null ? (object)DBNull.Value : model.machineID ;
			parameters[12].Value = model.userName == null ? (object)DBNull.Value : model.userName ;
			parameters[13].Value = model.dateTime == null ? (object)DBNull.Value : model.dateTime ;
			parameters[14].Value = model.remarks == null ? (object)DBNull.Value : model.remarks ;
            parameters[15].Value = model.partnumberall == null ? (object)DBNull.Value : model.partnumberall;

            return DBHelp.SqlDB.generateCommand(strSql.ToString(),parameters);
		}
		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(Common.Model.MouldingBom_Model model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update MouldingBom set ");
			strSql.Append("partNumber=@partNumber,");
			strSql.Append("matPart01=@matPart01,");
			strSql.Append("matPart02=@matPart02,");
			strSql.Append("customer=@customer,");
			strSql.Append("model=@model,");
			strSql.Append("jigNo=@jigNo,");
			strSql.Append("cavityCount=@cavityCount,");
			strSql.Append("partsWeight=@partsWeight,");
			strSql.Append("cycleTime=@cycleTime,");
			strSql.Append("blockCount=@blockCount,");
			strSql.Append("unitCount=@unitCount,");
			strSql.Append("machineID=@machineID,");
			strSql.Append("userName=@userName,");
			strSql.Append("dateTime=@dateTime,");
			strSql.Append("remarks=@remarks");
            strSql.Append("partNumberAll=@partNumberAll");
            strSql.Append(" where ");
			SqlParameter[] parameters = {
					new SqlParameter("@partNumber", SqlDbType.VarChar,50),
					new SqlParameter("@matPart01", SqlDbType.VarChar,50),
					new SqlParameter("@matPart02", SqlDbType.VarChar,50),
					new SqlParameter("@customer", SqlDbType.VarChar,50),
					new SqlParameter("@model", SqlDbType.VarChar,50),
					new SqlParameter("@jigNo", SqlDbType.VarChar,50),
					new SqlParameter("@cavityCount", SqlDbType.Decimal,9),
					new SqlParameter("@partsWeight", SqlDbType.Decimal,9),
					new SqlParameter("@cycleTime", SqlDbType.Decimal,9),
					new SqlParameter("@blockCount", SqlDbType.Int,4),
					new SqlParameter("@unitCount", SqlDbType.Int,4),
					new SqlParameter("@machineID", SqlDbType.VarChar,8),
					new SqlParameter("@userName", SqlDbType.VarChar,50),
					new SqlParameter("@dateTime", SqlDbType.SmallDateTime),
                    new SqlParameter("@remarks", SqlDbType.VarChar,500),
                    new SqlParameter("@partNumberAll", SqlDbType.VarChar,500)};
            parameters[0].Value = model.partNumber == null ? (object)DBNull.Value : model.partNumber ;
			parameters[1].Value = model.matPart01 == null ? (object)DBNull.Value : model.matPart01 ;
			parameters[2].Value = model.matPart02 == null ? (object)DBNull.Value : model.matPart02 ;
			parameters[3].Value = model.customer == null ? (object)DBNull.Value : model.customer ;
			parameters[4].Value = model.model == null ? (object)DBNull.Value : model.model ;
			parameters[5].Value = model.jigNo == null ? (object)DBNull.Value : model.jigNo ;
			parameters[6].Value = model.cavityCount == null ? (object)DBNull.Value : model.cavityCount ;
			parameters[7].Value = model.partsWeight == null ? (object)DBNull.Value : model.partsWeight ;
			parameters[8].Value = model.cycleTime == null ? (object)DBNull.Value : model.cycleTime ;
			parameters[9].Value = model.blockCount == null ? (object)DBNull.Value : model.blockCount ;
			parameters[10].Value = model.unitCount == null ? (object)DBNull.Value : model.unitCount ;
			parameters[11].Value = model.machineID == null ? (object)DBNull.Value : model.machineID ;
			parameters[12].Value = model.userName == null ? (object)DBNull.Value : model.userName ;
			parameters[13].Value = model.dateTime == null ? (object)DBNull.Value : model.dateTime;
            parameters[14].Value = model.remarks == null ? (object)DBNull.Value : model.remarks;
            parameters[15].Value = model.partnumberall == null ? (object)DBNull.Value : model.partnumberall;

            DBHelp.Reports.LogFile.DebugLog("AUTOCODE","NameSpace:Common.DAL" , "Class:MouldingBom_DAL" , "Function:		public bool Update(Common.Model.MouldingBom_Model model)"  + "TableName:MouldingBom" , ";partNumber = "+ (model.partNumber == null ? "" : model.partNumber.ToString() ) + ";matPart01 = "+ (model.matPart01 == null ? "" : model.matPart01.ToString() ) + ";matPart02 = "+ (model.matPart02 == null ? "" : model.matPart02.ToString() ) + ";customer = "+ (model.customer == null ? "" : model.customer.ToString() ) + ";model = "+ (model.model == null ? "" : model.model.ToString() ) + ";jigNo = "+ (model.jigNo == null ? "" : model.jigNo.ToString() ) + ";cavityCount = "+ (model.cavityCount == null ? "" : model.cavityCount.ToString() ) + ";partsWeight = "+ (model.partsWeight == null ? "" : model.partsWeight.ToString() ) + ";cycleTime = "+ (model.cycleTime == null ? "" : model.cycleTime.ToString() ) + ";blockCount = "+ (model.blockCount == null ? "" : model.blockCount.ToString() ) + ";unitCount = "+ (model.unitCount == null ? "" : model.unitCount.ToString() ) + ";machineID = "+ (model.machineID == null ? "" : model.machineID.ToString() ) + ";userName = "+ (model.userName == null ? "" : model.userName.ToString() ) + ";dateTime = "+ (model.dateTime == null ? "" : model.dateTime.ToString() ) + ";remarks = "+ (model.remarks == null ? "" : model.remarks.ToString() ) + "");
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
		public SqlCommand UpdateCommand(Common.Model.MouldingBom_Model model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update MouldingBom set ");
			strSql.Append("partNumber=@partNumber,");
			strSql.Append("matPart01=@matPart01,");
			strSql.Append("matPart02=@matPart02,");
			strSql.Append("customer=@customer,");
			strSql.Append("model=@model,");
			strSql.Append("jigNo=@jigNo,");
			strSql.Append("cavityCount=@cavityCount,");
			strSql.Append("partsWeight=@partsWeight,");
			strSql.Append("cycleTime=@cycleTime,");
			strSql.Append("blockCount=@blockCount,");
			strSql.Append("unitCount=@unitCount,");
			strSql.Append("machineID=@machineID,");
			strSql.Append("userName=@userName,");
			strSql.Append("dateTime=@dateTime,");
            strSql.Append("remarks=@remarks");
            strSql.Append("partNumberAll=@partNumberAll");
            strSql.Append(" where ");
			SqlParameter[] parameters = {
					new SqlParameter("@partNumber", SqlDbType.VarChar,50),
					new SqlParameter("@matPart01", SqlDbType.VarChar,50),
					new SqlParameter("@matPart02", SqlDbType.VarChar,50),
					new SqlParameter("@customer", SqlDbType.VarChar,50),
					new SqlParameter("@model", SqlDbType.VarChar,50),
					new SqlParameter("@jigNo", SqlDbType.VarChar,50),
					new SqlParameter("@cavityCount", SqlDbType.Decimal,9),
					new SqlParameter("@partsWeight", SqlDbType.Decimal,9),
					new SqlParameter("@cycleTime", SqlDbType.Decimal,9),
					new SqlParameter("@blockCount", SqlDbType.Int,4),
					new SqlParameter("@unitCount", SqlDbType.Int,4),
					new SqlParameter("@machineID", SqlDbType.VarChar,8),
					new SqlParameter("@userName", SqlDbType.VarChar,50),
					new SqlParameter("@dateTime", SqlDbType.SmallDateTime),
                    new SqlParameter("@remarks", SqlDbType.VarChar,500),
                    new SqlParameter("@partNumberAll", SqlDbType.VarChar,500)};
            parameters[0].Value = model.partNumber == null ? (object)DBNull.Value : model.partNumber ;
			parameters[1].Value = model.matPart01 == null ? (object)DBNull.Value : model.matPart01 ;
			parameters[2].Value = model.matPart02 == null ? (object)DBNull.Value : model.matPart02 ;
			parameters[3].Value = model.customer == null ? (object)DBNull.Value : model.customer ;
			parameters[4].Value = model.model == null ? (object)DBNull.Value : model.model ;
			parameters[5].Value = model.jigNo == null ? (object)DBNull.Value : model.jigNo ;
			parameters[6].Value = model.cavityCount == null ? (object)DBNull.Value : model.cavityCount ;
			parameters[7].Value = model.partsWeight == null ? (object)DBNull.Value : model.partsWeight ;
			parameters[8].Value = model.cycleTime == null ? (object)DBNull.Value : model.cycleTime ;
			parameters[9].Value = model.blockCount == null ? (object)DBNull.Value : model.blockCount ;
			parameters[10].Value = model.unitCount == null ? (object)DBNull.Value : model.unitCount ;
			parameters[11].Value = model.machineID == null ? (object)DBNull.Value : model.machineID ;
			parameters[12].Value = model.userName == null ? (object)DBNull.Value : model.userName ;
			parameters[13].Value = model.dateTime == null ? (object)DBNull.Value : model.dateTime ;
			parameters[14].Value = model.remarks == null ? (object)DBNull.Value : model.remarks;
            parameters[15].Value = model.partnumberall == null ? (object)DBNull.Value : model.partnumberall;

            DBHelp.Reports.LogFile.DebugLog("AUTOCODE","NameSpace:Common.DAL" , "Class:MouldingBom_DAL" , "Function:		public SqlCommand UpdateCommand(Common.Model.MouldingBom_Model model)"  + "TableName:MouldingBom" , ";partNumber = "+ (model.partNumber == null ? "" : model.partNumber.ToString()) + ";matPart01 = "+ (model.matPart01 == null ? "" : model.matPart01.ToString()) + ";matPart02 = "+ (model.matPart02 == null ? "" : model.matPart02.ToString()) + ";customer = "+ (model.customer == null ? "" : model.customer.ToString()) + ";model = "+ (model.model == null ? "" : model.model.ToString()) + ";jigNo = "+ (model.jigNo == null ? "" : model.jigNo.ToString()) + ";cavityCount = "+ (model.cavityCount == null ? "" : model.cavityCount.ToString()) + ";partsWeight = "+ (model.partsWeight == null ? "" : model.partsWeight.ToString()) + ";cycleTime = "+ (model.cycleTime == null ? "" : model.cycleTime.ToString()) + ";blockCount = "+ (model.blockCount == null ? "" : model.blockCount.ToString()) + ";unitCount = "+ (model.unitCount == null ? "" : model.unitCount.ToString()) + ";machineID = "+ (model.machineID == null ? "" : model.machineID.ToString()) + ";userName = "+ (model.userName == null ? "" : model.userName.ToString()) + ";dateTime = "+ (model.dateTime == null ? "" : model.dateTime.ToString()) + ";remarks = "+ (model.remarks == null ? "" : model.remarks.ToString()) + "");
			return DBHelp.SqlDB.generateCommand(strSql.ToString(),parameters);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete()
		{
			//该表无主键信息，请自定义主键/条件字段
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from MouldingBom ");
			strSql.Append(" where ");
			SqlParameter[] parameters = {
};

			 DBHelp.Reports.LogFile.DebugLog("AUTOCODE","NameSpace:Common.DAL" , "Class:MouldingBom_DAL" , "Function:		public bool Delete()"  + "TableName:MouldingBom" , "");
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
			strSql.Append("delete from MouldingBom ");
			strSql.Append(" where ");
			SqlParameter[] parameters = {
};

			 DBHelp.Reports.LogFile.DebugLog("AUTOCODE","NameSpace:Common.DAL" , "Class:MouldingBom_DAL" , "Function:		public SqlCommand DeleteCommand()"  + "TableName:MouldingBom" , "");
			return DBHelp.SqlDB.generateCommand(strSql.ToString(),parameters);
		}
		/// <summary>
		/// 删除一条数据
		/// </summary>
		public SqlCommand DeleteAllCommand( )
		{
			//该表无主键信息，请自定义主键/条件字段
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from MouldingBom ");
			 DBHelp.Reports.LogFile.DebugLog("AUTOCODE","NameSpace:Common.DAL" , "Class:MouldingBom_DAL" , "Function:		public SqlCommand DeleteAllCommand( )"  + "TableName:MouldingBom" , "");
			return DBHelp.SqlDB.generateCommand(strSql.ToString(), new SqlParameter[0]);
		}


		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public Common.Model.MouldingBom_Model GetModel()
		{
			//该表无主键信息，请自定义主键/条件字段
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 partNumber,matPart01,matPart02,customer,model,jigNo,cavityCount,partsWeight,cycleTime,blockCount,unitCount,machineID,userName,dateTime,remarks,partNumberAll from MouldingBom ");
			strSql.Append(" where ");
			SqlParameter[] parameters = {
};

			 DBHelp.Reports.LogFile.DebugLog("AUTOCODE","NameSpace:Common.DAL" , "Class:MouldingBom_DAL" , "Function:		public Common.Model.MouldingBom_Model GetModel()"  + "TableName:MouldingBom" , "");
			Common.Model.MouldingBom_Model model=new Common.Model.MouldingBom_Model();
			DataSet ds=DBHelp.SqlDB.Query(strSql.ToString(),parameters);
			if(ds.Tables[0].Rows.Count>0)
			{
				model.partNumber=ds.Tables[0].Rows[0]["partNumber"].ToString();
				model.matPart01=ds.Tables[0].Rows[0]["matPart01"].ToString();
				model.matPart02=ds.Tables[0].Rows[0]["matPart02"].ToString();
				model.customer=ds.Tables[0].Rows[0]["customer"].ToString();
				model.model=ds.Tables[0].Rows[0]["model"].ToString();
				model.jigNo=ds.Tables[0].Rows[0]["jigNo"].ToString();
				if(ds.Tables[0].Rows[0]["cavityCount"].ToString()!="")
				{
					model.cavityCount=decimal.Parse(ds.Tables[0].Rows[0]["cavityCount"].ToString());
				}
				if(ds.Tables[0].Rows[0]["partsWeight"].ToString()!="")
				{
					model.partsWeight=decimal.Parse(ds.Tables[0].Rows[0]["partsWeight"].ToString());
				}
				if(ds.Tables[0].Rows[0]["cycleTime"].ToString()!="")
				{
					model.cycleTime=decimal.Parse(ds.Tables[0].Rows[0]["cycleTime"].ToString());
				}
				if(ds.Tables[0].Rows[0]["blockCount"].ToString()!="")
				{
					model.blockCount=int.Parse(ds.Tables[0].Rows[0]["blockCount"].ToString());
				}
				if(ds.Tables[0].Rows[0]["unitCount"].ToString()!="")
				{
					model.unitCount=int.Parse(ds.Tables[0].Rows[0]["unitCount"].ToString());
				}
				model.machineID=ds.Tables[0].Rows[0]["machineID"].ToString();
				model.userName=ds.Tables[0].Rows[0]["userName"].ToString();
				if(ds.Tables[0].Rows[0]["dateTime"].ToString()!="")
				{
					model.dateTime=DateTime.Parse(ds.Tables[0].Rows[0]["dateTime"].ToString());
				}
				model.remarks=ds.Tables[0].Rows[0]["remarks"].ToString();
                model.partnumberall = ds.Tables[0].Rows[0]["partNumberAll"].ToString();
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
			strSql.Append("select partNumber,matPart01,matPart02,customer,model,jigNo,cavityCount,partsWeight,cycleTime,blockCount,unitCount,machineID,userName,dateTime,remarks,partNumberAll ");
			strSql.Append(" FROM MouldingBom ");
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
			strSql.Append(" partNumber,matPart01,matPart02,customer,model,jigNo,cavityCount,partsWeight,cycleTime,blockCount,unitCount,machineID,userName,dateTime,remarks,partNumberAll ");
			strSql.Append(" FROM MouldingBom ");
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
			parameters[0].Value = "MouldingBom";
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


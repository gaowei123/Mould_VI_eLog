using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using DBHelp;
using Common.Model;

namespace Common.DAL
{
	/// <summary>
	/// 数据访问类:MouldingViTracking_DAL
	/// </summary>
	public class MouldingViTracking_DAL
	{
		public MouldingViTracking_DAL()
		{}
		#region  Method

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public DataSet Exists()
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from MouldingViTracking");
			strSql.Append(" where ");
			SqlParameter[] parameters = {
};

			return DBHelp.SqlDB.Query(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(Common.Model.MouldingViTracking_Model model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into MouldingViTracking(");
			strSql.Append("machineID,dateTime,partNumber,jigNo,model,cavityCount,partsWeight,cycleTime,targetQty,userName,userID,acountReading,rejectQty,acceptQty,startTime,stopTime,day,shift,status,matPart01,matPart02,matLot01,matLot02,opSign01,opSign02,opSign03,opSign04,opSign05,opSign06,opSign07,opSign08,opSign09,opSign10,opSign11,opSign12,qaSign01,qaSign02,qaSign03,qaSign04,qaSign05,qaSign06,qaSign07,qaSign08,qaSign09,qaSign10,qaSign11,qaSign12,customer,lastUpdatedTime,trackingID,remarks,QCNGQTY,Material_MHCheck,Material_MHCheckTime,Material_Opcheck,Material_OpCheckTime,Material_LeaderCheck,Material_LeaderCheckTime,LeaderCheck,LeaderCheckTime,SupervisorCheck,SupervisorCheckTime,partNumberAll,parts2Weight,lastQty,OkAccumulation)");
			strSql.Append(" values (");
			strSql.Append("@machineID,@dateTime,@partNumber,@jigNo,@model,@cavityCount,@partsWeight,@cycleTime,@targetQty,@userName,@userID,@acountReading,@rejectQty,@acceptQty,@startTime,@stopTime,@day,@shift,@status,@matPart01,@matPart02,@matLot01,@matLot02,@opSign01,@opSign02,@opSign03,@opSign04,@opSign05,@opSign06,@opSign07,@opSign08,@opSign09,@opSign10,@opSign11,@opSign12,@qaSign01,@qaSign02,@qaSign03,@qaSign04,@qaSign05,@qaSign06,@qaSign07,@qaSign08,@qaSign09,@qaSign10,@qaSign11,@qaSign12,@customer,@lastUpdatedTime,@trackingID,@remarks,@QCNGQTY,@Material_MHCheck,@Material_MHCheckTime,@Material_Opcheck,@Material_OpCheckTime,@Material_LeaderCheck,@Material_LeaderCheckTime,@LeaderCheck,@LeaderCheckTime,@SupervisorCheck,@SupervisorCheckTime,@partNumberAll,@parts2Weight,@lastQty,@OkAccumulation)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@machineID", SqlDbType.VarChar,8),
					new SqlParameter("@dateTime", SqlDbType.DateTime2,8),
					new SqlParameter("@partNumber", SqlDbType.VarChar,50),
					new SqlParameter("@jigNo", SqlDbType.VarChar,50),
					new SqlParameter("@model", SqlDbType.VarChar,50),
					new SqlParameter("@cavityCount", SqlDbType.Decimal,9),
					new SqlParameter("@partsWeight", SqlDbType.Decimal,9),
					new SqlParameter("@cycleTime", SqlDbType.Decimal,9),
					new SqlParameter("@targetQty", SqlDbType.Decimal,9),
					new SqlParameter("@userName", SqlDbType.VarChar,50),
					new SqlParameter("@userID", SqlDbType.VarChar,50),
					new SqlParameter("@acountReading", SqlDbType.Decimal,9),
					new SqlParameter("@rejectQty", SqlDbType.Decimal,9),
					new SqlParameter("@acceptQty", SqlDbType.Decimal,9),
					new SqlParameter("@startTime", SqlDbType.DateTime2,8),
					new SqlParameter("@stopTime", SqlDbType.DateTime2,8),
					new SqlParameter("@day", SqlDbType.DateTime2,8),
					new SqlParameter("@shift", SqlDbType.VarChar,50),
					new SqlParameter("@status", SqlDbType.VarChar,50),
					new SqlParameter("@matPart01", SqlDbType.VarChar,50),
					new SqlParameter("@matPart02", SqlDbType.VarChar,50),
					new SqlParameter("@matLot01", SqlDbType.VarChar,50),
					new SqlParameter("@matLot02", SqlDbType.VarChar,50),
					new SqlParameter("@opSign01", SqlDbType.VarChar,50),
					new SqlParameter("@opSign02", SqlDbType.VarChar,50),
					new SqlParameter("@opSign03", SqlDbType.VarChar,50),
					new SqlParameter("@opSign04", SqlDbType.VarChar,50),
					new SqlParameter("@opSign05", SqlDbType.VarChar,50),
					new SqlParameter("@opSign06", SqlDbType.VarChar,50),
					new SqlParameter("@opSign07", SqlDbType.VarChar,50),
					new SqlParameter("@opSign08", SqlDbType.VarChar,50),
					new SqlParameter("@opSign09", SqlDbType.VarChar,50),
					new SqlParameter("@opSign10", SqlDbType.VarChar,50),
					new SqlParameter("@opSign11", SqlDbType.VarChar,50),
					new SqlParameter("@opSign12", SqlDbType.VarChar,50),
					new SqlParameter("@qaSign01", SqlDbType.VarChar,50),
					new SqlParameter("@qaSign02", SqlDbType.VarChar,50),
					new SqlParameter("@qaSign03", SqlDbType.VarChar,50),
					new SqlParameter("@qaSign04", SqlDbType.VarChar,50),
					new SqlParameter("@qaSign05", SqlDbType.VarChar,50),
					new SqlParameter("@qaSign06", SqlDbType.VarChar,50),
					new SqlParameter("@qaSign07", SqlDbType.VarChar,50),
					new SqlParameter("@qaSign08", SqlDbType.VarChar,50),
					new SqlParameter("@qaSign09", SqlDbType.VarChar,50),
					new SqlParameter("@qaSign10", SqlDbType.VarChar,50),
					new SqlParameter("@qaSign11", SqlDbType.VarChar,50),
					new SqlParameter("@qaSign12", SqlDbType.VarChar,50),
					new SqlParameter("@customer", SqlDbType.VarChar,50),
					new SqlParameter("@lastUpdatedTime", SqlDbType.DateTime2,8),
					new SqlParameter("@trackingID", SqlDbType.VarChar,50),
                    new SqlParameter("@remarks", SqlDbType.VarChar,500),
                    new SqlParameter("@QCNGQTY", SqlDbType.Decimal,9),
                    new SqlParameter("@Material_MHCheck", SqlDbType.VarChar,50),
                    new SqlParameter("@Material_MHCheckTime", SqlDbType.DateTime2,8),
                    new SqlParameter("@Material_Opcheck", SqlDbType.VarChar,50),
                    new SqlParameter("@Material_OpCheckTime", SqlDbType.DateTime2,8),
                    new SqlParameter("@Material_LeaderCheck", SqlDbType.VarChar,50),
                    new SqlParameter("@Material_LeaderCheckTime", SqlDbType.DateTime2,8),
                    new SqlParameter("@LeaderCheck", SqlDbType.VarChar,50),
                    new SqlParameter("@LeaderCheckTime", SqlDbType.DateTime2,8),
                    new SqlParameter("@SupervisorCheck", SqlDbType.VarChar,50),
                    new SqlParameter("@SupervisorCheckTime", SqlDbType.DateTime2,8),
                    new SqlParameter("@partNumberAll", SqlDbType.VarChar,500),
                    new SqlParameter("@parts2Weight", SqlDbType.Decimal,9),
                    new SqlParameter("@lastQty", SqlDbType.Decimal,9)  ,
                    new SqlParameter("@OkAccumulation", SqlDbType.VarChar,50)};
            DBHelp.Reports.LogFile.DebugLog("AUTOCODE","NameSpace:Common.DAL" , "Class:MouldingViTracking_DAL" , "Function:		public int Add(Common.Model.MouldingViTracking_Model model)"  + "TableName:MouldingViTracking" , ";machineID = "+ (model.machineID == null ? "" : model.machineID.ToString() ) + ";dateTime = "+ (model.dateTime == null ? "" : model.dateTime.ToString() ) + ";partNumber = "+ (model.partNumber == null ? "" : model.partNumber.ToString() ) + ";jigNo = "+ (model.jigNo == null ? "" : model.jigNo.ToString() ) + ";model = "+ (model.model == null ? "" : model.model.ToString() ) + ";cavityCount = "+ (model.cavityCount == null ? "" : model.cavityCount.ToString() ) + ";partsWeight = "+ (model.partsWeight == null ? "" : model.partsWeight.ToString() ) + ";cycleTime = "+ (model.cycleTime == null ? "" : model.cycleTime.ToString() ) + ";targetQty = "+ (model.targetQty == null ? "" : model.targetQty.ToString() ) + ";userName = "+ (model.userName == null ? "" : model.userName.ToString() ) + ";userID = "+ (model.userID == null ? "" : model.userID.ToString() ) + ";acountReading = "+ (model.acountReading == null ? "" : model.acountReading.ToString() ) + ";rejectQty = "+ (model.rejectQty == null ? "" : model.rejectQty.ToString() ) + ";acceptQty = "+ (model.acceptQty == null ? "" : model.acceptQty.ToString() ) + ";startTime = "+ (model.startTime == null ? "" : model.startTime.ToString() ) + ";stopTime = "+ (model.stopTime == null ? "" : model.stopTime.ToString() ) + ";day = "+ (model.day == null ? "" : model.day.ToString() ) + ";shift = "+ (model.shift == null ? "" : model.shift.ToString() ) + ";status = "+ (model.status == null ? "" : model.status.ToString() ) + ";matPart01 = "+ (model.matPart01 == null ? "" : model.matPart01.ToString() ) + ";matPart02 = "+ (model.matPart02 == null ? "" : model.matPart02.ToString() ) + ";matLot01 = "+ (model.matLot01 == null ? "" : model.matLot01.ToString() ) + ";matLot02 = "+ (model.matLot02 == null ? "" : model.matLot02.ToString() ) + ";opSign01 = "+ (model.opSign01 == null ? "" : model.opSign01.ToString() ) + ";opSign02 = "+ (model.opSign02 == null ? "" : model.opSign02.ToString() ) + ";opSign03 = "+ (model.opSign03 == null ? "" : model.opSign03.ToString() ) + ";opSign04 = "+ (model.opSign04 == null ? "" : model.opSign04.ToString() ) + ";opSign05 = "+ (model.opSign05 == null ? "" : model.opSign05.ToString() ) + ";opSign06 = "+ (model.opSign06 == null ? "" : model.opSign06.ToString() ) + ";opSign07 = "+ (model.opSign07 == null ? "" : model.opSign07.ToString() ) + ";opSign08 = "+ (model.opSign08 == null ? "" : model.opSign08.ToString() ) + ";opSign09 = "+ (model.opSign09 == null ? "" : model.opSign09.ToString() ) + ";opSign10 = "+ (model.opSign10 == null ? "" : model.opSign10.ToString() ) + ";opSign11 = "+ (model.opSign11 == null ? "" : model.opSign11.ToString() ) + ";opSign12 = "+ (model.opSign12 == null ? "" : model.opSign12.ToString() ) + ";qaSign01 = "+ (model.qaSign01 == null ? "" : model.qaSign01.ToString() ) + ";qaSign02 = "+ (model.qaSign02 == null ? "" : model.qaSign02.ToString() ) + ";qaSign03 = "+ (model.qaSign03 == null ? "" : model.qaSign03.ToString() ) + ";qaSign04 = "+ (model.qaSign04 == null ? "" : model.qaSign04.ToString() ) + ";qaSign05 = "+ (model.qaSign05 == null ? "" : model.qaSign05.ToString() ) + ";qaSign06 = "+ (model.qaSign06 == null ? "" : model.qaSign06.ToString() ) + ";qaSign07 = "+ (model.qaSign07 == null ? "" : model.qaSign07.ToString() ) + ";qaSign08 = "+ (model.qaSign08 == null ? "" : model.qaSign08.ToString() ) + ";qaSign09 = "+ (model.qaSign09 == null ? "" : model.qaSign09.ToString() ) + ";qaSign10 = "+ (model.qaSign10 == null ? "" : model.qaSign10.ToString() ) + ";qaSign11 = "+ (model.qaSign11 == null ? "" : model.qaSign11.ToString() ) + ";qaSign12 = "+ (model.qaSign12 == null ? "" : model.qaSign12.ToString() ) + ";customer = "+ (model.customer == null ? "" : model.customer.ToString() ) + ";lastUpdatedTime = "+ (model.lastUpdatedTime == null ? "" : model.lastUpdatedTime.ToString() ) + ";trackingID = "+ (model.trackingID == null ? "" : model.trackingID.ToString() ) + ";remarks = "+ (model.remarks == null ? "" : model.remarks.ToString() ) + "");
			parameters[0].Value = model.machineID == null ? (object)DBNull.Value : model.machineID ;
			parameters[1].Value = model.dateTime == null ? (object)DBNull.Value : model.dateTime ;
			parameters[2].Value = model.partNumber == null ? (object)DBNull.Value : model.partNumber ;
			parameters[3].Value = model.jigNo == null ? (object)DBNull.Value : model.jigNo ;
			parameters[4].Value = model.model == null ? (object)DBNull.Value : model.model ;
			parameters[5].Value = model.cavityCount == null ? (object)DBNull.Value : model.cavityCount ;
			parameters[6].Value = model.partsWeight == null ? (object)DBNull.Value : model.partsWeight ;
			parameters[7].Value = model.cycleTime == null ? (object)DBNull.Value : model.cycleTime ;
			parameters[8].Value = model.targetQty == null ? (object)DBNull.Value : model.targetQty ;
			parameters[9].Value = model.userName == null ? (object)DBNull.Value : model.userName ;
			parameters[10].Value = model.userID == null ? (object)DBNull.Value : model.userID ;
			parameters[11].Value = model.acountReading == null ? (object)DBNull.Value : model.acountReading ;
			parameters[12].Value = model.rejectQty == null ? (object)DBNull.Value : model.rejectQty ;
			parameters[13].Value = model.acceptQty == null ? (object)DBNull.Value : model.acceptQty ;
			parameters[14].Value = model.startTime == null ? (object)DBNull.Value : model.startTime ;
			parameters[15].Value = model.stopTime == null ? (object)DBNull.Value : model.stopTime ;
			parameters[16].Value = model.day == null ? (object)DBNull.Value : model.day ;
			parameters[17].Value = model.shift == null ? (object)DBNull.Value : model.shift ;
			parameters[18].Value = model.status == null ? (object)DBNull.Value : model.status ;
			parameters[19].Value = model.matPart01 == null ? (object)DBNull.Value : model.matPart01 ;
			parameters[20].Value = model.matPart02 == null ? (object)DBNull.Value : model.matPart02 ;
			parameters[21].Value = model.matLot01 == null ? (object)DBNull.Value : model.matLot01 ;
			parameters[22].Value = model.matLot02 == null ? (object)DBNull.Value : model.matLot02 ;
			parameters[23].Value = model.opSign01 == null ? (object)DBNull.Value : model.opSign01 ;
			parameters[24].Value = model.opSign02 == null ? (object)DBNull.Value : model.opSign02 ;
			parameters[25].Value = model.opSign03 == null ? (object)DBNull.Value : model.opSign03 ;
			parameters[26].Value = model.opSign04 == null ? (object)DBNull.Value : model.opSign04 ;
			parameters[27].Value = model.opSign05 == null ? (object)DBNull.Value : model.opSign05 ;
			parameters[28].Value = model.opSign06 == null ? (object)DBNull.Value : model.opSign06 ;
			parameters[29].Value = model.opSign07 == null ? (object)DBNull.Value : model.opSign07 ;
			parameters[30].Value = model.opSign08 == null ? (object)DBNull.Value : model.opSign08 ;
			parameters[31].Value = model.opSign09 == null ? (object)DBNull.Value : model.opSign09 ;
			parameters[32].Value = model.opSign10 == null ? (object)DBNull.Value : model.opSign10 ;
			parameters[33].Value = model.opSign11 == null ? (object)DBNull.Value : model.opSign11 ;
			parameters[34].Value = model.opSign12 == null ? (object)DBNull.Value : model.opSign12 ;
			parameters[35].Value = model.qaSign01 == null ? (object)DBNull.Value : model.qaSign01 ;
			parameters[36].Value = model.qaSign02 == null ? (object)DBNull.Value : model.qaSign02 ;
			parameters[37].Value = model.qaSign03 == null ? (object)DBNull.Value : model.qaSign03 ;
			parameters[38].Value = model.qaSign04 == null ? (object)DBNull.Value : model.qaSign04 ;
			parameters[39].Value = model.qaSign05 == null ? (object)DBNull.Value : model.qaSign05 ;
			parameters[40].Value = model.qaSign06 == null ? (object)DBNull.Value : model.qaSign06 ;
			parameters[41].Value = model.qaSign07 == null ? (object)DBNull.Value : model.qaSign07 ;
			parameters[42].Value = model.qaSign08 == null ? (object)DBNull.Value : model.qaSign08 ;
			parameters[43].Value = model.qaSign09 == null ? (object)DBNull.Value : model.qaSign09 ;
			parameters[44].Value = model.qaSign10 == null ? (object)DBNull.Value : model.qaSign10 ;
			parameters[45].Value = model.qaSign11 == null ? (object)DBNull.Value : model.qaSign11 ;
			parameters[46].Value = model.qaSign12 == null ? (object)DBNull.Value : model.qaSign12 ;
			parameters[47].Value = model.customer == null ? (object)DBNull.Value : model.customer ;
			parameters[48].Value = model.lastUpdatedTime == null ? (object)DBNull.Value : model.lastUpdatedTime ;
			parameters[49].Value = model.trackingID == null ? (object)DBNull.Value : model.trackingID ;
			parameters[50].Value = model.remarks == null ? (object)DBNull.Value : model.remarks ;
            parameters[51].Value = model.QCNGQTY == null ? (object)DBNull.Value : model.QCNGQTY;
            parameters[52].Value = model.Material_MHCheck == null ? (object)DBNull.Value : model.Material_MHCheck;
            parameters[53].Value = model.Material_MHCheckTime == null ? (object)DBNull.Value : model.Material_MHCheckTime;
            parameters[54].Value = model.Material_Opcheck == null ? (object)DBNull.Value : model.Material_Opcheck;
            parameters[55].Value = model.Material_OpCheckTime == null ? (object)DBNull.Value : model.Material_OpCheckTime;
            parameters[56].Value = model.Material_LeaderCheck == null ? (object)DBNull.Value : model.Material_LeaderCheck;
            parameters[57].Value = model.Material_LeaderCheckTime == null ? (object)DBNull.Value : model.Material_LeaderCheckTime;
            parameters[58].Value = model.LeaderCheck == null ? (object)DBNull.Value : model.LeaderCheck;
            parameters[59].Value = model.LeaderCheckTime == null ? (object)DBNull.Value : model.LeaderCheckTime;
            parameters[60].Value = model.SupervisorCheck == null ? (object)DBNull.Value : model.SupervisorCheck;
            parameters[61].Value = model.SupervisorCheckTime == null ? (object)DBNull.Value : model.SupervisorCheckTime;
            parameters[62].Value = model.partnumberall == null ? (object)DBNull.Value : model.partnumberall;
            parameters[63].Value = model.parts2Weight == null ? (object)DBNull.Value : model.parts2Weight;
            parameters[64].Value = model.lastQty == null ? (object)DBNull.Value : model.lastQty;
            parameters[65].Value = model.OkAccumulation == null ? (object)DBNull.Value : model.OkAccumulation;

            return DBHelp.SqlDB.ExecuteSql (strSql.ToString(),parameters);
			 
		}
        public bool Update(Common.Model.MouldingViTracking_Model model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update MouldingViTracking set ");
            strSql.Append("machineID=@machineID,");
            strSql.Append("dateTime=@dateTime,");
            strSql.Append("partNumber=@partNumber,");
            strSql.Append("jigNo=@jigNo,");
            strSql.Append("model=@model,");
            strSql.Append("cavityCount=@cavityCount,");
            strSql.Append("partsWeight=@partsWeight,");
            strSql.Append("cycleTime=@cycleTime,");
            strSql.Append("targetQty=@targetQty,");
            strSql.Append("userName=@userName,");
            strSql.Append("userID=@userID,");
            strSql.Append("acountReading=@acountReading,");
            strSql.Append("rejectQty=@rejectQty,");
            strSql.Append("acceptQty=@acceptQty,");
            strSql.Append("startTime=@startTime,");
            strSql.Append("stopTime=@stopTime,");
            strSql.Append("day=@day,");
            strSql.Append("shift=@shift,");
            strSql.Append("status=@status,");
            strSql.Append("matPart01=@matPart01,");
            strSql.Append("matPart02=@matPart02,");
            strSql.Append("matLot01=@matLot01,");
            strSql.Append("matLot02=@matLot02,");
            strSql.Append("opSign01=@opSign01,");
            strSql.Append("opSign02=@opSign02,");
            strSql.Append("opSign03=@opSign03,");
            strSql.Append("opSign04=@opSign04,");
            strSql.Append("opSign05=@opSign05,");
            strSql.Append("opSign06=@opSign06,");
            strSql.Append("opSign07=@opSign07,");
            strSql.Append("opSign08=@opSign08,");
            strSql.Append("opSign09=@opSign09,");
            strSql.Append("opSign10=@opSign10,");
            strSql.Append("opSign11=@opSign11,");
            strSql.Append("opSign12=@opSign12,");
            strSql.Append("qaSign01=@qaSign01,");
            strSql.Append("qaSign02=@qaSign02,");
            strSql.Append("qaSign03=@qaSign03,");
            strSql.Append("qaSign04=@qaSign04,");
            strSql.Append("qaSign05=@qaSign05,");
            strSql.Append("qaSign06=@qaSign06,");
            strSql.Append("qaSign07=@qaSign07,");
            strSql.Append("qaSign08=@qaSign08,");
            strSql.Append("qaSign09=@qaSign09,");
            strSql.Append("qaSign10=@qaSign10,");
            strSql.Append("qaSign11=@qaSign11,");
            strSql.Append("qaSign12=@qaSign12,");
            strSql.Append("customer=@customer,");
            strSql.Append("lastUpdatedTime=@lastUpdatedTime,");
            strSql.Append("trackingID=@trackingID,");
            strSql.Append("remarks=@remarks,");
            strSql.Append("QCNGQTY=@QCNGQTY,");
            strSql.Append("Material_MHCheck=@Material_MHCheck,");
            strSql.Append("Material_MHCheckTime=@Material_MHCheckTime,");
            strSql.Append("Material_Opcheck=@Material_Opcheck,");
            strSql.Append("Material_OpCheckTime=@Material_OpCheckTime,");
            strSql.Append("Material_LeaderCheck=@Material_LeaderCheck,");
            strSql.Append("Material_LeaderCheckTime=@Material_LeaderCheckTime,");
            strSql.Append("LeaderCheck=@LeaderCheck,");
            strSql.Append("LeaderCheckTime=@LeaderCheckTime,");
            strSql.Append("SupervisorCheck=@SupervisorCheck,");
            strSql.Append("SupervisorCheckTime=@SupervisorCheckTime,");
            strSql.Append("partNumberAll=@partNumberAll,");
            strSql.Append("parts2Weight=@parts2Weight,");
            strSql.Append("lastQty=@lastQty,");
            strSql.Append("OkAccumulation=@OkAccumulation");
            strSql.Append(" where id=@id");
            SqlParameter[] parameters = {
                    new SqlParameter("@id", SqlDbType.Int,4),
                    new SqlParameter("@machineID", SqlDbType.VarChar,8),
                    new SqlParameter("@dateTime", SqlDbType.DateTime2,8),
                    new SqlParameter("@partNumber", SqlDbType.VarChar,50),
                    new SqlParameter("@jigNo", SqlDbType.VarChar,50),
                    new SqlParameter("@model", SqlDbType.VarChar,50),
                    new SqlParameter("@cavityCount", SqlDbType.Decimal,9),
                    new SqlParameter("@partsWeight", SqlDbType.Decimal,9),
                    new SqlParameter("@cycleTime", SqlDbType.Decimal,9),
                    new SqlParameter("@targetQty", SqlDbType.Decimal,9),
                    new SqlParameter("@userName", SqlDbType.VarChar,50),
                    new SqlParameter("@userID", SqlDbType.VarChar,50),
                    new SqlParameter("@acountReading", SqlDbType.Decimal,9),
                    new SqlParameter("@rejectQty", SqlDbType.Decimal,9),
                    new SqlParameter("@acceptQty", SqlDbType.Decimal,9),
                    new SqlParameter("@startTime", SqlDbType.DateTime2,8),
                    new SqlParameter("@stopTime", SqlDbType.DateTime2,8),
                    new SqlParameter("@day", SqlDbType.DateTime2,8),
                    new SqlParameter("@shift", SqlDbType.VarChar,50),
                    new SqlParameter("@status", SqlDbType.VarChar,50),
                    new SqlParameter("@matPart01", SqlDbType.VarChar,50),
                    new SqlParameter("@matPart02", SqlDbType.VarChar,50),
                    new SqlParameter("@matLot01", SqlDbType.VarChar,50),
                    new SqlParameter("@matLot02", SqlDbType.VarChar,50),
                    new SqlParameter("@opSign01", SqlDbType.VarChar,50),
                    new SqlParameter("@opSign02", SqlDbType.VarChar,50),
                    new SqlParameter("@opSign03", SqlDbType.VarChar,50),
                    new SqlParameter("@opSign04", SqlDbType.VarChar,50),
                    new SqlParameter("@opSign05", SqlDbType.VarChar,50),
                    new SqlParameter("@opSign06", SqlDbType.VarChar,50),
                    new SqlParameter("@opSign07", SqlDbType.VarChar,50),
                    new SqlParameter("@opSign08", SqlDbType.VarChar,50),
                    new SqlParameter("@opSign09", SqlDbType.VarChar,50),
                    new SqlParameter("@opSign10", SqlDbType.VarChar,50),
                    new SqlParameter("@opSign11", SqlDbType.VarChar,50),
                    new SqlParameter("@opSign12", SqlDbType.VarChar,50),
                    new SqlParameter("@qaSign01", SqlDbType.VarChar,50),
                    new SqlParameter("@qaSign02", SqlDbType.VarChar,50),
                    new SqlParameter("@qaSign03", SqlDbType.VarChar,50),
                    new SqlParameter("@qaSign04", SqlDbType.VarChar,50),
                    new SqlParameter("@qaSign05", SqlDbType.VarChar,50),
                    new SqlParameter("@qaSign06", SqlDbType.VarChar,50),
                    new SqlParameter("@qaSign07", SqlDbType.VarChar,50),
                    new SqlParameter("@qaSign08", SqlDbType.VarChar,50),
                    new SqlParameter("@qaSign09", SqlDbType.VarChar,50),
                    new SqlParameter("@qaSign10", SqlDbType.VarChar,50),
                    new SqlParameter("@qaSign11", SqlDbType.VarChar,50),
                    new SqlParameter("@qaSign12", SqlDbType.VarChar,50),
                    new SqlParameter("@customer", SqlDbType.VarChar,50),
                    new SqlParameter("@lastUpdatedTime", SqlDbType.DateTime2,8),
                    new SqlParameter("@trackingID", SqlDbType.VarChar,50),
                    new SqlParameter("@remarks", SqlDbType.VarChar,500),
                    new SqlParameter("@QCNGQTY", SqlDbType.Decimal, 9),
                    new SqlParameter("@Material_MHCheck", SqlDbType.VarChar, 50),
                    new SqlParameter("@Material_MHCheckTime", SqlDbType.DateTime2, 8),
                    new SqlParameter("@Material_Opcheck", SqlDbType.VarChar, 50),
                    new SqlParameter("@Material_OpCheckTime", SqlDbType.DateTime2, 8),
                    new SqlParameter("@Material_LeaderCheck", SqlDbType.VarChar, 50),
                    new SqlParameter("@Material_LeaderCheckTime", SqlDbType.DateTime2, 8),
                    new SqlParameter("@LeaderCheck", SqlDbType.VarChar, 50),
                    new SqlParameter("@LeaderCheckTime", SqlDbType.DateTime2, 8),
                    new SqlParameter("@SupervisorCheck", SqlDbType.VarChar, 50),
                    new SqlParameter("@SupervisorCheckTime", SqlDbType.DateTime2,8),
                    new SqlParameter("@partNumberAll", SqlDbType.VarChar,500),
                    new SqlParameter("@parts2Weight", SqlDbType.Decimal,9),
                    new SqlParameter("@lastQty", SqlDbType.Decimal,9)  ,
                    new SqlParameter("@OkAccumulation", SqlDbType.VarChar,50)};
            parameters[0].Value = model.id == null ? (object)DBNull.Value : model.id;
            parameters[1].Value = model.machineID == null ? (object)DBNull.Value : model.machineID;
            parameters[2].Value = model.dateTime == null ? (object)DBNull.Value : model.dateTime;
            parameters[3].Value = model.partNumber == null ? (object)DBNull.Value : model.partNumber;
            parameters[4].Value = model.jigNo == null ? (object)DBNull.Value : model.jigNo;
            parameters[5].Value = model.model == null ? (object)DBNull.Value : model.model;
            parameters[6].Value = model.cavityCount == null ? (object)DBNull.Value : model.cavityCount;
            parameters[7].Value = model.partsWeight == null ? (object)DBNull.Value : model.partsWeight;
            parameters[8].Value = model.cycleTime == null ? (object)DBNull.Value : model.cycleTime;
            parameters[9].Value = model.targetQty == null ? (object)DBNull.Value : model.targetQty;
            parameters[10].Value = model.userName == null ? (object)DBNull.Value : model.userName;
            parameters[11].Value = model.userID == null ? (object)DBNull.Value : model.userID;
            parameters[12].Value = model.acountReading == null ? (object)DBNull.Value : model.acountReading;
            parameters[13].Value = model.rejectQty == null ? (object)DBNull.Value : model.rejectQty;
            parameters[14].Value = model.acceptQty == null ? (object)DBNull.Value : model.acceptQty;
            parameters[15].Value = model.startTime == null ? (object)DBNull.Value : model.startTime;
            parameters[16].Value = model.stopTime == null ? (object)DBNull.Value : model.stopTime;
            parameters[17].Value = model.day == null ? (object)DBNull.Value : model.day;
            parameters[18].Value = model.shift == null ? (object)DBNull.Value : model.shift;
            parameters[19].Value = model.status == null ? (object)DBNull.Value : model.status;
            parameters[20].Value = model.matPart01 == null ? (object)DBNull.Value : model.matPart01;
            parameters[21].Value = model.matPart02 == null ? (object)DBNull.Value : model.matPart02;
            parameters[22].Value = model.matLot01 == null ? (object)DBNull.Value : model.matLot01;
            parameters[23].Value = model.matLot02 == null ? (object)DBNull.Value : model.matLot02;
            parameters[24].Value = model.opSign01 == null ? (object)DBNull.Value : model.opSign01;
            parameters[25].Value = model.opSign02 == null ? (object)DBNull.Value : model.opSign02;
            parameters[26].Value = model.opSign03 == null ? (object)DBNull.Value : model.opSign03;
            parameters[27].Value = model.opSign04 == null ? (object)DBNull.Value : model.opSign04;
            parameters[28].Value = model.opSign05 == null ? (object)DBNull.Value : model.opSign05;
            parameters[29].Value = model.opSign06 == null ? (object)DBNull.Value : model.opSign06;
            parameters[30].Value = model.opSign07 == null ? (object)DBNull.Value : model.opSign07;
            parameters[31].Value = model.opSign08 == null ? (object)DBNull.Value : model.opSign08;
            parameters[32].Value = model.opSign09 == null ? (object)DBNull.Value : model.opSign09;
            parameters[33].Value = model.opSign10 == null ? (object)DBNull.Value : model.opSign10;
            parameters[34].Value = model.opSign11 == null ? (object)DBNull.Value : model.opSign11;
            parameters[35].Value = model.opSign12 == null ? (object)DBNull.Value : model.opSign12;
            parameters[36].Value = model.qaSign01 == null ? (object)DBNull.Value : model.qaSign01;
            parameters[37].Value = model.qaSign02 == null ? (object)DBNull.Value : model.qaSign02;
            parameters[38].Value = model.qaSign03 == null ? (object)DBNull.Value : model.qaSign03;
            parameters[39].Value = model.qaSign04 == null ? (object)DBNull.Value : model.qaSign04;
            parameters[40].Value = model.qaSign05 == null ? (object)DBNull.Value : model.qaSign05;
            parameters[41].Value = model.qaSign06 == null ? (object)DBNull.Value : model.qaSign06;
            parameters[42].Value = model.qaSign07 == null ? (object)DBNull.Value : model.qaSign07;
            parameters[43].Value = model.qaSign08 == null ? (object)DBNull.Value : model.qaSign08;
            parameters[44].Value = model.qaSign09 == null ? (object)DBNull.Value : model.qaSign09;
            parameters[45].Value = model.qaSign10 == null ? (object)DBNull.Value : model.qaSign10;
            parameters[46].Value = model.qaSign11 == null ? (object)DBNull.Value : model.qaSign11;
            parameters[47].Value = model.qaSign12 == null ? (object)DBNull.Value : model.qaSign12;
            parameters[48].Value = model.customer == null ? (object)DBNull.Value : model.customer;
            parameters[49].Value = model.lastUpdatedTime == null ? (object)DBNull.Value : model.lastUpdatedTime;
            parameters[50].Value = model.trackingID == null ? (object)DBNull.Value : model.trackingID;
            parameters[51].Value = model.remarks == null ? (object)DBNull.Value : model.remarks;
            parameters[52].Value = model.QCNGQTY == null ? (object)DBNull.Value : model.QCNGQTY;
            parameters[53].Value = model.Material_MHCheck == null ? (object)DBNull.Value : model.Material_MHCheck;
            parameters[54].Value = model.Material_MHCheckTime == null ? (object)DBNull.Value : model.Material_MHCheckTime;
            parameters[55].Value = model.Material_Opcheck == null ? (object)DBNull.Value : model.Material_Opcheck;
            parameters[56].Value = model.Material_OpCheckTime == null ? (object)DBNull.Value : model.Material_OpCheckTime;
            parameters[57].Value = model.Material_LeaderCheck == null ? (object)DBNull.Value : model.Material_LeaderCheck;
            parameters[58].Value = model.Material_LeaderCheckTime == null ? (object)DBNull.Value : model.Material_LeaderCheckTime;
            parameters[59].Value = model.LeaderCheck == null ? (object)DBNull.Value : model.LeaderCheck;
            parameters[60].Value = model.LeaderCheckTime == null ? (object)DBNull.Value : model.LeaderCheckTime;
            parameters[61].Value = model.SupervisorCheck == null ? (object)DBNull.Value : model.SupervisorCheck;
            parameters[62].Value = model.SupervisorCheckTime == null ? (object)DBNull.Value : model.SupervisorCheckTime;
            parameters[63].Value = model.partnumberall == null ? (object)DBNull.Value : model.partnumberall;
            parameters[64].Value = model.parts2Weight == null ? (object)DBNull.Value : model.parts2Weight;
            parameters[65].Value = model.lastQty == null ? (object)DBNull.Value : model.lastQty;
            parameters[66].Value = model.OkAccumulation == null ? (object)DBNull.Value : model.OkAccumulation;

            DBHelp.Reports.LogFile.DebugLog("AUTOCODE", "NameSpace:Common.DAL", "Class:MouldingViTracking_DAL", "Function:		public bool Update(Common.Model.MouldingViTracking_Model model)" + "TableName:MouldingViTracking", ";id = " + (model.id == null ? "" : model.id.ToString()) + ";machineID = " + (model.machineID == null ? "" : model.machineID.ToString()) + ";dateTime = " + (model.dateTime == null ? "" : model.dateTime.ToString()) + ";partNumber = " + (model.partNumber == null ? "" : model.partNumber.ToString()) + ";jigNo = " + (model.jigNo == null ? "" : model.jigNo.ToString()) + ";model = " + (model.model == null ? "" : model.model.ToString()) + ";cavityCount = " + (model.cavityCount == null ? "" : model.cavityCount.ToString()) + ";partsWeight = " + (model.partsWeight == null ? "" : model.partsWeight.ToString()) + ";cycleTime = " + (model.cycleTime == null ? "" : model.cycleTime.ToString()) + ";targetQty = " + (model.targetQty == null ? "" : model.targetQty.ToString()) + ";userName = " + (model.userName == null ? "" : model.userName.ToString()) + ";userID = " + (model.userID == null ? "" : model.userID.ToString()) + ";acountReading = " + (model.acountReading == null ? "" : model.acountReading.ToString()) + ";rejectQty = " + (model.rejectQty == null ? "" : model.rejectQty.ToString()) + ";acceptQty = " + (model.acceptQty == null ? "" : model.acceptQty.ToString()) + ";startTime = " + (model.startTime == null ? "" : model.startTime.ToString()) + ";stopTime = " + (model.stopTime == null ? "" : model.stopTime.ToString()) + ";day = " + (model.day == null ? "" : model.day.ToString()) + ";shift = " + (model.shift == null ? "" : model.shift.ToString()) + ";status = " + (model.status == null ? "" : model.status.ToString()) + ";matPart01 = " + (model.matPart01 == null ? "" : model.matPart01.ToString()) + ";matPart02 = " + (model.matPart02 == null ? "" : model.matPart02.ToString()) + ";matLot01 = " + (model.matLot01 == null ? "" : model.matLot01.ToString()) + ";matLot02 = " + (model.matLot02 == null ? "" : model.matLot02.ToString()) + ";opSign01 = " + (model.opSign01 == null ? "" : model.opSign01.ToString()) + ";opSign02 = " + (model.opSign02 == null ? "" : model.opSign02.ToString()) + ";opSign03 = " + (model.opSign03 == null ? "" : model.opSign03.ToString()) + ";opSign04 = " + (model.opSign04 == null ? "" : model.opSign04.ToString()) + ";opSign05 = " + (model.opSign05 == null ? "" : model.opSign05.ToString()) + ";opSign06 = " + (model.opSign06 == null ? "" : model.opSign06.ToString()) + ";opSign07 = " + (model.opSign07 == null ? "" : model.opSign07.ToString()) + ";opSign08 = " + (model.opSign08 == null ? "" : model.opSign08.ToString()) + ";opSign09 = " + (model.opSign09 == null ? "" : model.opSign09.ToString()) + ";opSign10 = " + (model.opSign10 == null ? "" : model.opSign10.ToString()) + ";opSign11 = " + (model.opSign11 == null ? "" : model.opSign11.ToString()) + ";opSign12 = " + (model.opSign12 == null ? "" : model.opSign12.ToString()) + ";qaSign01 = " + (model.qaSign01 == null ? "" : model.qaSign01.ToString()) + ";qaSign02 = " + (model.qaSign02 == null ? "" : model.qaSign02.ToString()) + ";qaSign03 = " + (model.qaSign03 == null ? "" : model.qaSign03.ToString()) + ";qaSign04 = " + (model.qaSign04 == null ? "" : model.qaSign04.ToString()) + ";qaSign05 = " + (model.qaSign05 == null ? "" : model.qaSign05.ToString()) + ";qaSign06 = " + (model.qaSign06 == null ? "" : model.qaSign06.ToString()) + ";qaSign07 = " + (model.qaSign07 == null ? "" : model.qaSign07.ToString()) + ";qaSign08 = " + (model.qaSign08 == null ? "" : model.qaSign08.ToString()) + ";qaSign09 = " + (model.qaSign09 == null ? "" : model.qaSign09.ToString()) + ";qaSign10 = " + (model.qaSign10 == null ? "" : model.qaSign10.ToString()) + ";qaSign11 = " + (model.qaSign11 == null ? "" : model.qaSign11.ToString()) + ";qaSign12 = " + (model.qaSign12 == null ? "" : model.qaSign12.ToString()) + ";customer = " + (model.customer == null ? "" : model.customer.ToString()) + ";lastUpdatedTime = " + (model.lastUpdatedTime == null ? "" : model.lastUpdatedTime.ToString()) + ";trackingID = " + (model.trackingID == null ? "" : model.trackingID.ToString()) + ";remarks = " + (model.remarks == null ? "" : model.remarks.ToString()) + "");
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
        public SqlCommand UpdateCommand_old(Common.Model.MouldingViTracking_Model model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update MouldingViTracking set ");
            strSql.Append("machineID=@machineID,");
            strSql.Append("dateTime=@dateTime,");
            //strSql.Append("partNumber=@partNumber,");
            strSql.Append("jigNo=@jigNo,");
            strSql.Append("model=@model,");
            strSql.Append("cavityCount=@cavityCount,");
            strSql.Append("partsWeight=@partsWeight,");
            strSql.Append("cycleTime=@cycleTime,");
            strSql.Append("targetQty=@targetQty,");
            strSql.Append("userName=@userName,");
            strSql.Append("userID=@userID,");
            strSql.Append("acountReading=@acountReading,");
            strSql.Append("rejectQty=@rejectQty,");
            strSql.Append("acceptQty=@acceptQty,");
            strSql.Append("startTime=@startTime,");
            strSql.Append("stopTime=@stopTime,");
            strSql.Append("day=@day,");
            strSql.Append("shift=@shift,");
            strSql.Append("status=@status,");
            strSql.Append("matPart01=@matPart01,");
            strSql.Append("matPart02=@matPart02,");
            strSql.Append("matLot01=@matLot01,");
            strSql.Append("matLot02=@matLot02,");
            strSql.Append("opSign01=@opSign01,");
            strSql.Append("opSign02=@opSign02,");
            strSql.Append("opSign03=@opSign03,");
            strSql.Append("opSign04=@opSign04,");
            strSql.Append("opSign05=@opSign05,");
            strSql.Append("opSign06=@opSign06,");
            strSql.Append("opSign07=@opSign07,");
            strSql.Append("opSign08=@opSign08,");
            strSql.Append("opSign09=@opSign09,");
            strSql.Append("opSign10=@opSign10,");
            strSql.Append("opSign11=@opSign11,");
            strSql.Append("opSign12=@opSign12,");
            strSql.Append("qaSign01=@qaSign01,");
            strSql.Append("qaSign02=@qaSign02,");
            strSql.Append("qaSign03=@qaSign03,");
            strSql.Append("qaSign04=@qaSign04,");
            strSql.Append("qaSign05=@qaSign05,");
            strSql.Append("qaSign06=@qaSign06,");
            strSql.Append("qaSign07=@qaSign07,");
            strSql.Append("qaSign08=@qaSign08,");
            strSql.Append("qaSign09=@qaSign09,");
            strSql.Append("qaSign10=@qaSign10,");
            strSql.Append("qaSign11=@qaSign11,");
            strSql.Append("qaSign12=@qaSign12,");
            strSql.Append("customer=@customer,");
            strSql.Append("lastUpdatedTime=@lastUpdatedTime,");
            //strSql.Append("trackingID=@trackingID,");
            strSql.Append("remarks=@remarks,");
            strSql.Append("QCNGQTY=@QCNGQTY,");
            strSql.Append("Material_MHCheck=@Material_MHCheck,");
            strSql.Append("Material_MHCheckTime=@Material_MHCheckTime,");
            strSql.Append("Material_Opcheck=@Material_Opcheck,");
            strSql.Append("Material_OpCheckTime=@Material_OpCheckTime,");
            strSql.Append("Material_LeaderCheck=@Material_LeaderCheck,");
            strSql.Append("Material_LeaderCheckTime=@Material_LeaderCheckTime,");
            strSql.Append("LeaderCheck=@LeaderCheck,");
            strSql.Append("LeaderCheckTime=@LeaderCheckTime,");
            strSql.Append("SupervisorCheck=@SupervisorCheck,");
            strSql.Append("SupervisorCheckTime=@SupervisorCheckTime,");
            strSql.Append("partNumberAll=@partNumberAll,");
            strSql.Append("parts2Weight=@parts2Weight,");
            strSql.Append("lastQty=@lastQty,");
            strSql.Append("OkAccumulation=@OkAccumulation");
            strSql.Append(" where  partNumberAll=@partNumberAll ");
            strSql.Append(" and day=@day ");
            strSql.Append(" and shift=@shift ");
            strSql.Append(" and machineID=@machineID ");
            SqlParameter[] parameters = {
                    new SqlParameter("@id", SqlDbType.Int,4),
                    new SqlParameter("@machineID", SqlDbType.VarChar,8),
                    new SqlParameter("@dateTime", SqlDbType.DateTime2,8),
                    new SqlParameter("@partNumber", SqlDbType.VarChar,50),
                    new SqlParameter("@jigNo", SqlDbType.VarChar,50),
                    new SqlParameter("@model", SqlDbType.VarChar,50),
                    new SqlParameter("@cavityCount", SqlDbType.Decimal,9),
                    new SqlParameter("@partsWeight", SqlDbType.Decimal,9),
                    new SqlParameter("@cycleTime", SqlDbType.Decimal,9),
                    new SqlParameter("@targetQty", SqlDbType.Decimal,9),
                    new SqlParameter("@userName", SqlDbType.VarChar,50),
                    new SqlParameter("@userID", SqlDbType.VarChar,50),
                    new SqlParameter("@acountReading", SqlDbType.Decimal,9),
                    new SqlParameter("@rejectQty", SqlDbType.Decimal,9),
                    new SqlParameter("@acceptQty", SqlDbType.Decimal,9),
                    new SqlParameter("@startTime", SqlDbType.DateTime2,8),
                    new SqlParameter("@stopTime", SqlDbType.DateTime2,8),
                    new SqlParameter("@day", SqlDbType.DateTime2,8),
                    new SqlParameter("@shift", SqlDbType.VarChar,50),
                    new SqlParameter("@status", SqlDbType.VarChar,50),
                    new SqlParameter("@matPart01", SqlDbType.VarChar,50),
                    new SqlParameter("@matPart02", SqlDbType.VarChar,50),
                    new SqlParameter("@matLot01", SqlDbType.VarChar,50),
                    new SqlParameter("@matLot02", SqlDbType.VarChar,50),
                    new SqlParameter("@opSign01", SqlDbType.VarChar,50),
                    new SqlParameter("@opSign02", SqlDbType.VarChar,50),
                    new SqlParameter("@opSign03", SqlDbType.VarChar,50),
                    new SqlParameter("@opSign04", SqlDbType.VarChar,50),
                    new SqlParameter("@opSign05", SqlDbType.VarChar,50),
                    new SqlParameter("@opSign06", SqlDbType.VarChar,50),
                    new SqlParameter("@opSign07", SqlDbType.VarChar,50),
                    new SqlParameter("@opSign08", SqlDbType.VarChar,50),
                    new SqlParameter("@opSign09", SqlDbType.VarChar,50),
                    new SqlParameter("@opSign10", SqlDbType.VarChar,50),
                    new SqlParameter("@opSign11", SqlDbType.VarChar,50),
                    new SqlParameter("@opSign12", SqlDbType.VarChar,50),
                    new SqlParameter("@qaSign01", SqlDbType.VarChar,50),
                    new SqlParameter("@qaSign02", SqlDbType.VarChar,50),
                    new SqlParameter("@qaSign03", SqlDbType.VarChar,50),
                    new SqlParameter("@qaSign04", SqlDbType.VarChar,50),
                    new SqlParameter("@qaSign05", SqlDbType.VarChar,50),
                    new SqlParameter("@qaSign06", SqlDbType.VarChar,50),
                    new SqlParameter("@qaSign07", SqlDbType.VarChar,50),
                    new SqlParameter("@qaSign08", SqlDbType.VarChar,50),
                    new SqlParameter("@qaSign09", SqlDbType.VarChar,50),
                    new SqlParameter("@qaSign10", SqlDbType.VarChar,50),
                    new SqlParameter("@qaSign11", SqlDbType.VarChar,50),
                    new SqlParameter("@qaSign12", SqlDbType.VarChar,50),
                    new SqlParameter("@customer", SqlDbType.VarChar,50),
                    new SqlParameter("@lastUpdatedTime", SqlDbType.DateTime2,8),
                    new SqlParameter("@trackingID", SqlDbType.VarChar,50),
                    new SqlParameter("@remarks", SqlDbType.VarChar,500),
                    new SqlParameter("@QCNGQTY", SqlDbType.Decimal, 9),
                    new SqlParameter("@Material_MHCheck", SqlDbType.VarChar, 50),
                    new SqlParameter("@Material_MHCheckTime", SqlDbType.DateTime2, 8),
                    new SqlParameter("@Material_Opcheck", SqlDbType.VarChar, 50),
                    new SqlParameter("@Material_OpCheckTime", SqlDbType.DateTime2, 8),
                    new SqlParameter("@Material_LeaderCheck", SqlDbType.VarChar, 50),
                    new SqlParameter("@Material_LeaderCheckTime", SqlDbType.DateTime2, 8),
                    new SqlParameter("@LeaderCheck", SqlDbType.VarChar, 50),
                    new SqlParameter("@LeaderCheckTime", SqlDbType.DateTime2, 8),
                    new SqlParameter("@SupervisorCheck", SqlDbType.VarChar, 50),
                    new SqlParameter("@SupervisorCheckTime", SqlDbType.DateTime2,8),
                    new SqlParameter("@partNumberAll", SqlDbType.VarChar,500),
                    new SqlParameter("@parts2Weight", SqlDbType.Decimal,9),
                    new SqlParameter("@lastQty", SqlDbType.Decimal,9)  ,
                    new SqlParameter("@OkAccumulation", SqlDbType.VarChar,50)};
            parameters[0].Value = model.id == null ? (object)DBNull.Value : model.id;
            parameters[1].Value = model.machineID == null ? (object)DBNull.Value : model.machineID;
            parameters[2].Value = model.dateTime == null ? (object)DBNull.Value : model.dateTime;
            parameters[3].Value = model.partNumber == null ? (object)DBNull.Value : model.partNumber;
            parameters[4].Value = model.jigNo == null ? (object)DBNull.Value : model.jigNo;
            parameters[5].Value = model.model == null ? (object)DBNull.Value : model.model;
            parameters[6].Value = model.cavityCount == null ? (object)DBNull.Value : model.cavityCount;
            parameters[7].Value = model.partsWeight == null ? (object)DBNull.Value : model.partsWeight;
            parameters[8].Value = model.cycleTime == null ? (object)DBNull.Value : model.cycleTime;
            parameters[9].Value = model.targetQty == null ? (object)DBNull.Value : model.targetQty;
            parameters[10].Value = model.userName == null ? (object)DBNull.Value : model.userName;
            parameters[11].Value = model.userID == null ? (object)DBNull.Value : model.userID;
            parameters[12].Value = model.acountReading == null ? (object)DBNull.Value : model.acountReading;
            parameters[13].Value = model.rejectQty == null ? (object)DBNull.Value : model.rejectQty;
            parameters[14].Value = model.acceptQty == null ? (object)DBNull.Value : model.acceptQty;
            parameters[15].Value = model.startTime == null ? (object)DBNull.Value : model.startTime;
            parameters[16].Value = model.stopTime == null ? (object)DBNull.Value : model.stopTime;
            parameters[17].Value = model.day == null ? (object)DBNull.Value : model.day;
            parameters[18].Value = model.shift == null ? (object)DBNull.Value : model.shift;
            parameters[19].Value = model.status == null ? (object)DBNull.Value : model.status;
            parameters[20].Value = model.matPart01 == null ? (object)DBNull.Value : model.matPart01;
            parameters[21].Value = model.matPart02 == null ? (object)DBNull.Value : model.matPart02;
            parameters[22].Value = model.matLot01 == null ? (object)DBNull.Value : model.matLot01;
            parameters[23].Value = model.matLot02 == null ? (object)DBNull.Value : model.matLot02;
            parameters[24].Value = model.opSign01 == null ? (object)DBNull.Value : model.opSign01;
            parameters[25].Value = model.opSign02 == null ? (object)DBNull.Value : model.opSign02;
            parameters[26].Value = model.opSign03 == null ? (object)DBNull.Value : model.opSign03;
            parameters[27].Value = model.opSign04 == null ? (object)DBNull.Value : model.opSign04;
            parameters[28].Value = model.opSign05 == null ? (object)DBNull.Value : model.opSign05;
            parameters[29].Value = model.opSign06 == null ? (object)DBNull.Value : model.opSign06;
            parameters[30].Value = model.opSign07 == null ? (object)DBNull.Value : model.opSign07;
            parameters[31].Value = model.opSign08 == null ? (object)DBNull.Value : model.opSign08;
            parameters[32].Value = model.opSign09 == null ? (object)DBNull.Value : model.opSign09;
            parameters[33].Value = model.opSign10 == null ? (object)DBNull.Value : model.opSign10;
            parameters[34].Value = model.opSign11 == null ? (object)DBNull.Value : model.opSign11;
            parameters[35].Value = model.opSign12 == null ? (object)DBNull.Value : model.opSign12;
            parameters[36].Value = model.qaSign01 == null ? (object)DBNull.Value : model.qaSign01;
            parameters[37].Value = model.qaSign02 == null ? (object)DBNull.Value : model.qaSign02;
            parameters[38].Value = model.qaSign03 == null ? (object)DBNull.Value : model.qaSign03;
            parameters[39].Value = model.qaSign04 == null ? (object)DBNull.Value : model.qaSign04;
            parameters[40].Value = model.qaSign05 == null ? (object)DBNull.Value : model.qaSign05;
            parameters[41].Value = model.qaSign06 == null ? (object)DBNull.Value : model.qaSign06;
            parameters[42].Value = model.qaSign07 == null ? (object)DBNull.Value : model.qaSign07;
            parameters[43].Value = model.qaSign08 == null ? (object)DBNull.Value : model.qaSign08;
            parameters[44].Value = model.qaSign09 == null ? (object)DBNull.Value : model.qaSign09;
            parameters[45].Value = model.qaSign10 == null ? (object)DBNull.Value : model.qaSign10;
            parameters[46].Value = model.qaSign11 == null ? (object)DBNull.Value : model.qaSign11;
            parameters[47].Value = model.qaSign12 == null ? (object)DBNull.Value : model.qaSign12;
            parameters[48].Value = model.customer == null ? (object)DBNull.Value : model.customer;
            parameters[49].Value = model.lastUpdatedTime == null ? (object)DBNull.Value : model.lastUpdatedTime;
            parameters[50].Value = model.trackingID == null ? (object)DBNull.Value : model.trackingID;
            parameters[51].Value = model.remarks == null ? (object)DBNull.Value : model.remarks;
            parameters[52].Value = model.QCNGQTY == null ? (object)DBNull.Value : model.QCNGQTY;
            parameters[53].Value = model.Material_MHCheck == null ? (object)DBNull.Value : model.Material_MHCheck;
            parameters[54].Value = model.Material_MHCheckTime == null ? (object)DBNull.Value : model.Material_MHCheckTime;
            parameters[55].Value = model.Material_Opcheck == null ? (object)DBNull.Value : model.Material_Opcheck;
            parameters[56].Value = model.Material_OpCheckTime == null ? (object)DBNull.Value : model.Material_OpCheckTime;
            parameters[57].Value = model.Material_LeaderCheck == null ? (object)DBNull.Value : model.Material_LeaderCheck;
            parameters[58].Value = model.Material_LeaderCheckTime == null ? (object)DBNull.Value : model.Material_LeaderCheckTime;
            parameters[59].Value = model.LeaderCheck == null ? (object)DBNull.Value : model.LeaderCheck;
            parameters[60].Value = model.LeaderCheckTime == null ? (object)DBNull.Value : model.LeaderCheckTime;
            parameters[61].Value = model.SupervisorCheck == null ? (object)DBNull.Value : model.SupervisorCheck;
            parameters[62].Value = model.SupervisorCheckTime == null ? (object)DBNull.Value : model.SupervisorCheckTime;
            parameters[63].Value = model.partnumberall == null ? (object)DBNull.Value : model.partnumberall;
            parameters[64].Value = model.parts2Weight == null ? (object)DBNull.Value : model.parts2Weight;
            parameters[65].Value = model.lastQty == null ? (object)DBNull.Value : model.lastQty;
            parameters[66].Value = model.OkAccumulation == null ? (object)DBNull.Value : model.OkAccumulation;
            DBHelp.Reports.LogFile.DebugLog("AUTOCODE", "NameSpace:Common.DAL", "Class:MouldingViTracking_DAL", "Function:		public SqlCommand UpdateCommand(Common.Model.MouldingViTracking_Model model)" + "TableName:MouldingViTracking", ";id = " + (model.id == null ? "" : model.id.ToString()) + ";machineID = " + (model.machineID == null ? "" : model.machineID.ToString()) + ";dateTime = " + (model.dateTime == null ? "" : model.dateTime.ToString()) + ";partNumber = " + (model.partNumber == null ? "" : model.partNumber.ToString()) + ";jigNo = " + (model.jigNo == null ? "" : model.jigNo.ToString()) + ";model = " + (model.model == null ? "" : model.model.ToString()) + ";cavityCount = " + (model.cavityCount == null ? "" : model.cavityCount.ToString()) + ";partsWeight = " + (model.partsWeight == null ? "" : model.partsWeight.ToString()) + ";cycleTime = " + (model.cycleTime == null ? "" : model.cycleTime.ToString()) + ";targetQty = " + (model.targetQty == null ? "" : model.targetQty.ToString()) + ";userName = " + (model.userName == null ? "" : model.userName.ToString()) + ";userID = " + (model.userID == null ? "" : model.userID.ToString()) + ";acountReading = " + (model.acountReading == null ? "" : model.acountReading.ToString()) + ";rejectQty = " + (model.rejectQty == null ? "" : model.rejectQty.ToString()) + ";acceptQty = " + (model.acceptQty == null ? "" : model.acceptQty.ToString()) + ";startTime = " + (model.startTime == null ? "" : model.startTime.ToString()) + ";stopTime = " + (model.stopTime == null ? "" : model.stopTime.ToString()) + ";day = " + (model.day == null ? "" : model.day.ToString()) + ";shift = " + (model.shift == null ? "" : model.shift.ToString()) + ";status = " + (model.status == null ? "" : model.status.ToString()) + ";matPart01 = " + (model.matPart01 == null ? "" : model.matPart01.ToString()) + ";matPart02 = " + (model.matPart02 == null ? "" : model.matPart02.ToString()) + ";matLot01 = " + (model.matLot01 == null ? "" : model.matLot01.ToString()) + ";matLot02 = " + (model.matLot02 == null ? "" : model.matLot02.ToString()) + ";opSign01 = " + (model.opSign01 == null ? "" : model.opSign01.ToString()) + ";opSign02 = " + (model.opSign02 == null ? "" : model.opSign02.ToString()) + ";opSign03 = " + (model.opSign03 == null ? "" : model.opSign03.ToString()) + ";opSign04 = " + (model.opSign04 == null ? "" : model.opSign04.ToString()) + ";opSign05 = " + (model.opSign05 == null ? "" : model.opSign05.ToString()) + ";opSign06 = " + (model.opSign06 == null ? "" : model.opSign06.ToString()) + ";opSign07 = " + (model.opSign07 == null ? "" : model.opSign07.ToString()) + ";opSign08 = " + (model.opSign08 == null ? "" : model.opSign08.ToString()) + ";opSign09 = " + (model.opSign09 == null ? "" : model.opSign09.ToString()) + ";opSign10 = " + (model.opSign10 == null ? "" : model.opSign10.ToString()) + ";opSign11 = " + (model.opSign11 == null ? "" : model.opSign11.ToString()) + ";opSign12 = " + (model.opSign12 == null ? "" : model.opSign12.ToString()) + ";qaSign01 = " + (model.qaSign01 == null ? "" : model.qaSign01.ToString()) + ";qaSign02 = " + (model.qaSign02 == null ? "" : model.qaSign02.ToString()) + ";qaSign03 = " + (model.qaSign03 == null ? "" : model.qaSign03.ToString()) + ";qaSign04 = " + (model.qaSign04 == null ? "" : model.qaSign04.ToString()) + ";qaSign05 = " + (model.qaSign05 == null ? "" : model.qaSign05.ToString()) + ";qaSign06 = " + (model.qaSign06 == null ? "" : model.qaSign06.ToString()) + ";qaSign07 = " + (model.qaSign07 == null ? "" : model.qaSign07.ToString()) + ";qaSign08 = " + (model.qaSign08 == null ? "" : model.qaSign08.ToString()) + ";qaSign09 = " + (model.qaSign09 == null ? "" : model.qaSign09.ToString()) + ";qaSign10 = " + (model.qaSign10 == null ? "" : model.qaSign10.ToString()) + ";qaSign11 = " + (model.qaSign11 == null ? "" : model.qaSign11.ToString()) + ";qaSign12 = " + (model.qaSign12 == null ? "" : model.qaSign12.ToString()) + ";customer = " + (model.customer == null ? "" : model.customer.ToString()) + ";lastUpdatedTime = " + (model.lastUpdatedTime == null ? "" : model.lastUpdatedTime.ToString()) + ";trackingID = " + (model.trackingID == null ? "" : model.trackingID.ToString()) + ";remarks = " + (model.remarks == null ? "" : model.remarks.ToString()) + "");
            return DBHelp.SqlDB.generateCommand(strSql.ToString(), parameters);
        }




        public SqlCommand AddCommand(Common.Model.MouldingViTracking_Model model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into MouldingViTracking(");
			strSql.Append("machineID,dateTime,partNumber,jigNo,model,cavityCount,partsWeight,cycleTime,targetQty,userName,userID,acountReading,rejectQty,acceptQty,startTime,stopTime,day,shift,status,matPart01,matPart02,matLot01,matLot02,opSign01,opSign02,opSign03,opSign04,opSign05,opSign06,opSign07,opSign08,opSign09,opSign10,opSign11,opSign12,qaSign01,qaSign02,qaSign03,qaSign04,qaSign05,qaSign06,qaSign07,qaSign08,qaSign09,qaSign10,qaSign11,qaSign12,customer,lastUpdatedTime,trackingID,remarks,QCNGQTY,Material_MHCheck,Material_MHCheckTime,Material_Opcheck,Material_OpCheckTime,Material_LeaderCheck,Material_LeaderCheckTime,LeaderCheck,LeaderCheckTime,SupervisorCheck,SupervisorCheckTime,partNumberAll,parts2Weight,lastQty,OkAccumulation)");
			strSql.Append(" values (");
			strSql.Append("@machineID,@dateTime,@partNumber,@jigNo,@model,@cavityCount,@partsWeight,@cycleTime,@targetQty,@userName,@userID,@acountReading,@rejectQty,@acceptQty,@startTime,@stopTime,@day,@shift,@status,@matPart01,@matPart02,@matLot01,@matLot02,@opSign01,@opSign02,@opSign03,@opSign04,@opSign05,@opSign06,@opSign07,@opSign08,@opSign09,@opSign10,@opSign11,@opSign12,@qaSign01,@qaSign02,@qaSign03,@qaSign04,@qaSign05,@qaSign06,@qaSign07,@qaSign08,@qaSign09,@qaSign10,@qaSign11,@qaSign12,@customer,@lastUpdatedTime,@trackingID,@remarks,@QCNGQTY,@Material_MHCheck,@Material_MHCheckTime,@Material_Opcheck,@Material_OpCheckTime,@Material_LeaderCheck,@Material_LeaderCheckTime,@LeaderCheck,@LeaderCheckTime,@SupervisorCheck,@SupervisorCheckTime,@partNumberAll,@parts2Weight,@lastQty,@OkAccumulation)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@machineID", SqlDbType.VarChar,8),
					new SqlParameter("@dateTime", SqlDbType.DateTime2,8),
					new SqlParameter("@partNumber", SqlDbType.VarChar,50),
					new SqlParameter("@jigNo", SqlDbType.VarChar,50),
					new SqlParameter("@model", SqlDbType.VarChar,50),
					new SqlParameter("@cavityCount", SqlDbType.Decimal,9),
					new SqlParameter("@partsWeight", SqlDbType.Decimal,9),
					new SqlParameter("@cycleTime", SqlDbType.Decimal,9),
					new SqlParameter("@targetQty", SqlDbType.Decimal,9),
					new SqlParameter("@userName", SqlDbType.VarChar,50),
					new SqlParameter("@userID", SqlDbType.VarChar,50),
					new SqlParameter("@acountReading", SqlDbType.Decimal,9),
					new SqlParameter("@rejectQty", SqlDbType.Decimal,9),
					new SqlParameter("@acceptQty", SqlDbType.Decimal,9),
					new SqlParameter("@startTime", SqlDbType.DateTime2,8),
					new SqlParameter("@stopTime", SqlDbType.DateTime2,8),
					new SqlParameter("@day", SqlDbType.DateTime2,8),
					new SqlParameter("@shift", SqlDbType.VarChar,50),
					new SqlParameter("@status", SqlDbType.VarChar,50),
					new SqlParameter("@matPart01", SqlDbType.VarChar,50),
					new SqlParameter("@matPart02", SqlDbType.VarChar,50),
					new SqlParameter("@matLot01", SqlDbType.VarChar,50),
					new SqlParameter("@matLot02", SqlDbType.VarChar,50),
					new SqlParameter("@opSign01", SqlDbType.VarChar,50),
					new SqlParameter("@opSign02", SqlDbType.VarChar,50),
					new SqlParameter("@opSign03", SqlDbType.VarChar,50),
					new SqlParameter("@opSign04", SqlDbType.VarChar,50),
					new SqlParameter("@opSign05", SqlDbType.VarChar,50),
					new SqlParameter("@opSign06", SqlDbType.VarChar,50),
					new SqlParameter("@opSign07", SqlDbType.VarChar,50),
					new SqlParameter("@opSign08", SqlDbType.VarChar,50),
					new SqlParameter("@opSign09", SqlDbType.VarChar,50),
					new SqlParameter("@opSign10", SqlDbType.VarChar,50),
					new SqlParameter("@opSign11", SqlDbType.VarChar,50),
					new SqlParameter("@opSign12", SqlDbType.VarChar,50),
					new SqlParameter("@qaSign01", SqlDbType.VarChar,50),
					new SqlParameter("@qaSign02", SqlDbType.VarChar,50),
					new SqlParameter("@qaSign03", SqlDbType.VarChar,50),
					new SqlParameter("@qaSign04", SqlDbType.VarChar,50),
					new SqlParameter("@qaSign05", SqlDbType.VarChar,50),
					new SqlParameter("@qaSign06", SqlDbType.VarChar,50),
					new SqlParameter("@qaSign07", SqlDbType.VarChar,50),
					new SqlParameter("@qaSign08", SqlDbType.VarChar,50),
					new SqlParameter("@qaSign09", SqlDbType.VarChar,50),
					new SqlParameter("@qaSign10", SqlDbType.VarChar,50),
					new SqlParameter("@qaSign11", SqlDbType.VarChar,50),
					new SqlParameter("@qaSign12", SqlDbType.VarChar,50),
					new SqlParameter("@customer", SqlDbType.VarChar,50),
					new SqlParameter("@lastUpdatedTime", SqlDbType.DateTime2,8),
					new SqlParameter("@trackingID", SqlDbType.VarChar,50),
                    new SqlParameter("@remarks", SqlDbType.VarChar,500),
                    new SqlParameter("@QCNGQTY", SqlDbType.Decimal,9),
                    new SqlParameter("@Material_MHCheck", SqlDbType.VarChar,50),
                    new SqlParameter("@Material_MHCheckTime", SqlDbType.DateTime2,8),
                    new SqlParameter("@Material_Opcheck", SqlDbType.VarChar,50),
                    new SqlParameter("@Material_OpCheckTime", SqlDbType.DateTime2,8),
                    new SqlParameter("@Material_LeaderCheck", SqlDbType.VarChar,50),
                    new SqlParameter("@Material_LeaderCheckTime", SqlDbType.DateTime2,8),
                    new SqlParameter("@LeaderCheck", SqlDbType.VarChar,50),
                    new SqlParameter("@LeaderCheckTime", SqlDbType.DateTime2,8),
                    new SqlParameter("@SupervisorCheck", SqlDbType.VarChar,50),
                    new SqlParameter("@SupervisorCheckTime", SqlDbType.DateTime2,8),
                    new SqlParameter("@partNumberAll", SqlDbType.VarChar,500),
                    new SqlParameter("@parts2Weight", SqlDbType.Decimal,9),
                    new SqlParameter("@lastQty", SqlDbType.Decimal,9)  ,
                    new SqlParameter("@OkAccumulation", SqlDbType.VarChar,50)};
            DBHelp.Reports.LogFile.DebugLog("AUTOCODE","NameSpace:Common.DAL" , "Class:MouldingViTracking_DAL" , "Function:		public SqlCommand AddCommand(Common.Model.MouldingViTracking_Model model)"  + "TableName:MouldingViTracking" , ";machineID = "+ (model.machineID == null ? "" : model.machineID.ToString()) + ";dateTime = "+ (model.dateTime == null ? "" : model.dateTime.ToString()) + ";partNumber = "+ (model.partNumber == null ? "" : model.partNumber.ToString()) + ";jigNo = "+ (model.jigNo == null ? "" : model.jigNo.ToString()) + ";model = "+ (model.model == null ? "" : model.model.ToString()) + ";cavityCount = "+ (model.cavityCount == null ? "" : model.cavityCount.ToString()) + ";partsWeight = "+ (model.partsWeight == null ? "" : model.partsWeight.ToString()) + ";cycleTime = "+ (model.cycleTime == null ? "" : model.cycleTime.ToString()) + ";targetQty = "+ (model.targetQty == null ? "" : model.targetQty.ToString()) + ";userName = "+ (model.userName == null ? "" : model.userName.ToString()) + ";userID = "+ (model.userID == null ? "" : model.userID.ToString()) + ";acountReading = "+ (model.acountReading == null ? "" : model.acountReading.ToString()) + ";rejectQty = "+ (model.rejectQty == null ? "" : model.rejectQty.ToString()) + ";acceptQty = "+ (model.acceptQty == null ? "" : model.acceptQty.ToString()) + ";startTime = "+ (model.startTime == null ? "" : model.startTime.ToString()) + ";stopTime = "+ (model.stopTime == null ? "" : model.stopTime.ToString()) + ";day = "+ (model.day == null ? "" : model.day.ToString()) + ";shift = "+ (model.shift == null ? "" : model.shift.ToString()) + ";status = "+ (model.status == null ? "" : model.status.ToString()) + ";matPart01 = "+ (model.matPart01 == null ? "" : model.matPart01.ToString()) + ";matPart02 = "+ (model.matPart02 == null ? "" : model.matPart02.ToString()) + ";matLot01 = "+ (model.matLot01 == null ? "" : model.matLot01.ToString()) + ";matLot02 = "+ (model.matLot02 == null ? "" : model.matLot02.ToString()) + ";opSign01 = "+ (model.opSign01 == null ? "" : model.opSign01.ToString()) + ";opSign02 = "+ (model.opSign02 == null ? "" : model.opSign02.ToString()) + ";opSign03 = "+ (model.opSign03 == null ? "" : model.opSign03.ToString()) + ";opSign04 = "+ (model.opSign04 == null ? "" : model.opSign04.ToString()) + ";opSign05 = "+ (model.opSign05 == null ? "" : model.opSign05.ToString()) + ";opSign06 = "+ (model.opSign06 == null ? "" : model.opSign06.ToString()) + ";opSign07 = "+ (model.opSign07 == null ? "" : model.opSign07.ToString()) + ";opSign08 = "+ (model.opSign08 == null ? "" : model.opSign08.ToString()) + ";opSign09 = "+ (model.opSign09 == null ? "" : model.opSign09.ToString()) + ";opSign10 = "+ (model.opSign10 == null ? "" : model.opSign10.ToString()) + ";opSign11 = "+ (model.opSign11 == null ? "" : model.opSign11.ToString()) + ";opSign12 = "+ (model.opSign12 == null ? "" : model.opSign12.ToString()) + ";qaSign01 = "+ (model.qaSign01 == null ? "" : model.qaSign01.ToString()) + ";qaSign02 = "+ (model.qaSign02 == null ? "" : model.qaSign02.ToString()) + ";qaSign03 = "+ (model.qaSign03 == null ? "" : model.qaSign03.ToString()) + ";qaSign04 = "+ (model.qaSign04 == null ? "" : model.qaSign04.ToString()) + ";qaSign05 = "+ (model.qaSign05 == null ? "" : model.qaSign05.ToString()) + ";qaSign06 = "+ (model.qaSign06 == null ? "" : model.qaSign06.ToString()) + ";qaSign07 = "+ (model.qaSign07 == null ? "" : model.qaSign07.ToString()) + ";qaSign08 = "+ (model.qaSign08 == null ? "" : model.qaSign08.ToString()) + ";qaSign09 = "+ (model.qaSign09 == null ? "" : model.qaSign09.ToString()) + ";qaSign10 = "+ (model.qaSign10 == null ? "" : model.qaSign10.ToString()) + ";qaSign11 = "+ (model.qaSign11 == null ? "" : model.qaSign11.ToString()) + ";qaSign12 = "+ (model.qaSign12 == null ? "" : model.qaSign12.ToString()) + ";customer = "+ (model.customer == null ? "" : model.customer.ToString()) + ";lastUpdatedTime = "+ (model.lastUpdatedTime == null ? "" : model.lastUpdatedTime.ToString()) + ";trackingID = "+ (model.trackingID == null ? "" : model.trackingID.ToString()) + ";remarks = "+ (model.remarks == null ? "" : model.remarks.ToString()) + "");
			parameters[0].Value = model.machineID == null ? (object)DBNull.Value : model.machineID ;
			parameters[1].Value = model.dateTime == null ? (object)DBNull.Value : model.dateTime ;
			parameters[2].Value = model.partNumber == null ? (object)DBNull.Value : model.partNumber ;
			parameters[3].Value = model.jigNo == null ? (object)DBNull.Value : model.jigNo ;
			parameters[4].Value = model.model == null ? (object)DBNull.Value : model.model ;
			parameters[5].Value = model.cavityCount == null ? (object)DBNull.Value : model.cavityCount ;
			parameters[6].Value = model.partsWeight == null ? (object)DBNull.Value : model.partsWeight ;
			parameters[7].Value = model.cycleTime == null ? (object)DBNull.Value : model.cycleTime ;
			parameters[8].Value = model.targetQty == null ? (object)DBNull.Value : model.targetQty ;
			parameters[9].Value = model.userName == null ? (object)DBNull.Value : model.userName ;
			parameters[10].Value = model.userID == null ? (object)DBNull.Value : model.userID ;
			parameters[11].Value = model.acountReading == null ? (object)DBNull.Value : model.acountReading ;
			parameters[12].Value = model.rejectQty == null ? (object)DBNull.Value : model.rejectQty ;
			parameters[13].Value = model.acceptQty == null ? (object)DBNull.Value : model.acceptQty ;
			parameters[14].Value = model.startTime == null ? (object)DBNull.Value : model.startTime ;
			parameters[15].Value = model.stopTime == null ? (object)DBNull.Value : model.stopTime ;
			parameters[16].Value = model.day == null ? (object)DBNull.Value : model.day ;
			parameters[17].Value = model.shift == null ? (object)DBNull.Value : model.shift ;
			parameters[18].Value = model.status == null ? (object)DBNull.Value : model.status ;
			parameters[19].Value = model.matPart01 == null ? (object)DBNull.Value : model.matPart01 ;
			parameters[20].Value = model.matPart02 == null ? (object)DBNull.Value : model.matPart02 ;
			parameters[21].Value = model.matLot01 == null ? (object)DBNull.Value : model.matLot01 ;
			parameters[22].Value = model.matLot02 == null ? (object)DBNull.Value : model.matLot02 ;
			parameters[23].Value = model.opSign01 == null ? (object)DBNull.Value : model.opSign01 ;
			parameters[24].Value = model.opSign02 == null ? (object)DBNull.Value : model.opSign02 ;
			parameters[25].Value = model.opSign03 == null ? (object)DBNull.Value : model.opSign03 ;
			parameters[26].Value = model.opSign04 == null ? (object)DBNull.Value : model.opSign04 ;
			parameters[27].Value = model.opSign05 == null ? (object)DBNull.Value : model.opSign05 ;
			parameters[28].Value = model.opSign06 == null ? (object)DBNull.Value : model.opSign06 ;
			parameters[29].Value = model.opSign07 == null ? (object)DBNull.Value : model.opSign07 ;
			parameters[30].Value = model.opSign08 == null ? (object)DBNull.Value : model.opSign08 ;
			parameters[31].Value = model.opSign09 == null ? (object)DBNull.Value : model.opSign09 ;
			parameters[32].Value = model.opSign10 == null ? (object)DBNull.Value : model.opSign10 ;
			parameters[33].Value = model.opSign11 == null ? (object)DBNull.Value : model.opSign11 ;
			parameters[34].Value = model.opSign12 == null ? (object)DBNull.Value : model.opSign12 ;
			parameters[35].Value = model.qaSign01 == null ? (object)DBNull.Value : model.qaSign01 ;
			parameters[36].Value = model.qaSign02 == null ? (object)DBNull.Value : model.qaSign02 ;
			parameters[37].Value = model.qaSign03 == null ? (object)DBNull.Value : model.qaSign03 ;
			parameters[38].Value = model.qaSign04 == null ? (object)DBNull.Value : model.qaSign04 ;
			parameters[39].Value = model.qaSign05 == null ? (object)DBNull.Value : model.qaSign05 ;
			parameters[40].Value = model.qaSign06 == null ? (object)DBNull.Value : model.qaSign06 ;
			parameters[41].Value = model.qaSign07 == null ? (object)DBNull.Value : model.qaSign07 ;
			parameters[42].Value = model.qaSign08 == null ? (object)DBNull.Value : model.qaSign08 ;
			parameters[43].Value = model.qaSign09 == null ? (object)DBNull.Value : model.qaSign09 ;
			parameters[44].Value = model.qaSign10 == null ? (object)DBNull.Value : model.qaSign10 ;
			parameters[45].Value = model.qaSign11 == null ? (object)DBNull.Value : model.qaSign11 ;
			parameters[46].Value = model.qaSign12 == null ? (object)DBNull.Value : model.qaSign12 ;
			parameters[47].Value = model.customer == null ? (object)DBNull.Value : model.customer ;
			parameters[48].Value = model.lastUpdatedTime == null ? (object)DBNull.Value : model.lastUpdatedTime ;
			parameters[49].Value = model.trackingID == null ? (object)DBNull.Value : model.trackingID ;
			parameters[50].Value = model.remarks == null ? (object)DBNull.Value : model.remarks ;
            parameters[51].Value = model.QCNGQTY == null ? (object)DBNull.Value : model.QCNGQTY;
            parameters[52].Value = model.Material_MHCheck == null ? (object)DBNull.Value : model.Material_MHCheck;
            parameters[53].Value = model.Material_MHCheckTime == null ? (object)DBNull.Value : model.Material_MHCheckTime;
            parameters[54].Value = model.Material_Opcheck == null ? (object)DBNull.Value : model.Material_Opcheck;
            parameters[55].Value = model.Material_OpCheckTime == null ? (object)DBNull.Value : model.Material_OpCheckTime;
            parameters[56].Value = model.Material_LeaderCheck == null ? (object)DBNull.Value : model.Material_LeaderCheck;
            parameters[57].Value = model.Material_LeaderCheckTime == null ? (object)DBNull.Value : model.Material_LeaderCheckTime;
            parameters[58].Value = model.LeaderCheck == null ? (object)DBNull.Value : model.LeaderCheck;
            parameters[59].Value = model.LeaderCheckTime == null ? (object)DBNull.Value : model.LeaderCheckTime;
            parameters[60].Value = model.SupervisorCheck == null ? (object)DBNull.Value : model.SupervisorCheck;
            parameters[61].Value = model.SupervisorCheckTime == null ? (object)DBNull.Value : model.SupervisorCheckTime;
            parameters[62].Value = model.partnumberall == null ? (object)DBNull.Value : model.partnumberall;
            parameters[63].Value = model.parts2Weight == null ? (object)DBNull.Value : model.parts2Weight;
            parameters[64].Value = model.lastQty == null ? (object)DBNull.Value : model.lastQty;
            parameters[65].Value = model.OkAccumulation == null ? (object)DBNull.Value : model.OkAccumulation;

            return DBHelp.SqlDB.generateCommand(strSql.ToString(),parameters);
		}
	
		public SqlCommand UpdateCommand(Common.Model.MouldingViTracking_Model model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update MouldingViTracking set ");
			strSql.Append("machineID=@machineID,");
			strSql.Append("dateTime=@dateTime,");
			//strSql.Append("partNumber=@partNumber,");
			strSql.Append("jigNo=@jigNo,");
			strSql.Append("model=@model,");
			strSql.Append("cavityCount=@cavityCount,");
			strSql.Append("partsWeight=@partsWeight,");
			strSql.Append("cycleTime=@cycleTime,");
			strSql.Append("targetQty=@targetQty,");
			strSql.Append("userName=@userName,");
			strSql.Append("userID=@userID,");
			strSql.Append("acountReading=@acountReading,");
			//strSql.Append("rejectQty=@rejectQty,");
			strSql.Append("acceptQty=@acceptQty,");
			strSql.Append("startTime=@startTime,");
			strSql.Append("stopTime=@stopTime,");
			strSql.Append("day=@day,");
			strSql.Append("shift=@shift,");
			strSql.Append("status=@status,");
			strSql.Append("matPart01=@matPart01,");
			strSql.Append("matPart02=@matPart02,");
			strSql.Append("matLot01=@matLot01,");
			strSql.Append("matLot02=@matLot02,");
			strSql.Append("opSign01=@opSign01,");
			strSql.Append("opSign02=@opSign02,");
			strSql.Append("opSign03=@opSign03,");
			strSql.Append("opSign04=@opSign04,");
			strSql.Append("opSign05=@opSign05,");
			strSql.Append("opSign06=@opSign06,");
			strSql.Append("opSign07=@opSign07,");
			strSql.Append("opSign08=@opSign08,");
			strSql.Append("opSign09=@opSign09,");
			strSql.Append("opSign10=@opSign10,");
			strSql.Append("opSign11=@opSign11,");
			strSql.Append("opSign12=@opSign12,");
			strSql.Append("qaSign01=@qaSign01,");
			strSql.Append("qaSign02=@qaSign02,");
			strSql.Append("qaSign03=@qaSign03,");
			strSql.Append("qaSign04=@qaSign04,");
			strSql.Append("qaSign05=@qaSign05,");
			strSql.Append("qaSign06=@qaSign06,");
			strSql.Append("qaSign07=@qaSign07,");
			strSql.Append("qaSign08=@qaSign08,");
			strSql.Append("qaSign09=@qaSign09,");
			strSql.Append("qaSign10=@qaSign10,");
			strSql.Append("qaSign11=@qaSign11,");
			strSql.Append("qaSign12=@qaSign12,");
			strSql.Append("customer=@customer,");
			strSql.Append("lastUpdatedTime=@lastUpdatedTime,");
			//strSql.Append("trackingID=@trackingID,");
            strSql.Append("remarks=@remarks,");
            strSql.Append("QCNGQTY=@QCNGQTY,");
            strSql.Append("Material_MHCheck=@Material_MHCheck,");
            strSql.Append("Material_MHCheckTime=@Material_MHCheckTime,");
            strSql.Append("Material_Opcheck=@Material_Opcheck,");
            strSql.Append("Material_OpCheckTime=@Material_OpCheckTime,");
            strSql.Append("Material_LeaderCheck=@Material_LeaderCheck,");
            strSql.Append("Material_LeaderCheckTime=@Material_LeaderCheckTime,");
            strSql.Append("LeaderCheck=@LeaderCheck,");
            strSql.Append("LeaderCheckTime=@LeaderCheckTime,");
            strSql.Append("SupervisorCheck=@SupervisorCheck,");
            strSql.Append("SupervisorCheckTime=@SupervisorCheckTime,");
            strSql.Append("partNumberAll=@partNumberAll,");
            strSql.Append("parts2Weight=@parts2Weight,");
            strSql.Append("lastQty=@lastQty,");
            strSql.Append("OkAccumulation=@OkAccumulation");
            strSql.Append(" where  partNumberAll=@partNumberAll ");
            strSql.Append(" and day=@day ");
            strSql.Append(" and shift=@shift ");
            strSql.Append(" and machineID=@machineID ");
            //2018/12/04 by datetime
            strSql.Append(" and startTime=@startTime ");
            SqlParameter[] parameters = {
					new SqlParameter("@id", SqlDbType.Int,4),
					new SqlParameter("@machineID", SqlDbType.VarChar,8),
					new SqlParameter("@dateTime", SqlDbType.DateTime2,8),
					new SqlParameter("@partNumber", SqlDbType.VarChar,50),
					new SqlParameter("@jigNo", SqlDbType.VarChar,50),
					new SqlParameter("@model", SqlDbType.VarChar,50),
					new SqlParameter("@cavityCount", SqlDbType.Decimal,9),
					new SqlParameter("@partsWeight", SqlDbType.Decimal,9),
					new SqlParameter("@cycleTime", SqlDbType.Decimal,9),
					new SqlParameter("@targetQty", SqlDbType.Decimal,9),
					new SqlParameter("@userName", SqlDbType.VarChar,50),
					new SqlParameter("@userID", SqlDbType.VarChar,50),
					new SqlParameter("@acountReading", SqlDbType.Decimal,9),
					new SqlParameter("@rejectQty", SqlDbType.Decimal,9),
					new SqlParameter("@acceptQty", SqlDbType.Decimal,9),
					new SqlParameter("@startTime", SqlDbType.DateTime2,8),
					new SqlParameter("@stopTime", SqlDbType.DateTime2,8),
					new SqlParameter("@day", SqlDbType.DateTime2,8),
					new SqlParameter("@shift", SqlDbType.VarChar,50),
					new SqlParameter("@status", SqlDbType.VarChar,50),
					new SqlParameter("@matPart01", SqlDbType.VarChar,50),
					new SqlParameter("@matPart02", SqlDbType.VarChar,50),
					new SqlParameter("@matLot01", SqlDbType.VarChar,50),
					new SqlParameter("@matLot02", SqlDbType.VarChar,50),
					new SqlParameter("@opSign01", SqlDbType.VarChar,50),
					new SqlParameter("@opSign02", SqlDbType.VarChar,50),
					new SqlParameter("@opSign03", SqlDbType.VarChar,50),
					new SqlParameter("@opSign04", SqlDbType.VarChar,50),
					new SqlParameter("@opSign05", SqlDbType.VarChar,50),
					new SqlParameter("@opSign06", SqlDbType.VarChar,50),
					new SqlParameter("@opSign07", SqlDbType.VarChar,50),
					new SqlParameter("@opSign08", SqlDbType.VarChar,50),
					new SqlParameter("@opSign09", SqlDbType.VarChar,50),
					new SqlParameter("@opSign10", SqlDbType.VarChar,50),
					new SqlParameter("@opSign11", SqlDbType.VarChar,50),
					new SqlParameter("@opSign12", SqlDbType.VarChar,50),
					new SqlParameter("@qaSign01", SqlDbType.VarChar,50),
					new SqlParameter("@qaSign02", SqlDbType.VarChar,50),
					new SqlParameter("@qaSign03", SqlDbType.VarChar,50),
					new SqlParameter("@qaSign04", SqlDbType.VarChar,50),
					new SqlParameter("@qaSign05", SqlDbType.VarChar,50),
					new SqlParameter("@qaSign06", SqlDbType.VarChar,50),
					new SqlParameter("@qaSign07", SqlDbType.VarChar,50),
					new SqlParameter("@qaSign08", SqlDbType.VarChar,50),
					new SqlParameter("@qaSign09", SqlDbType.VarChar,50),
					new SqlParameter("@qaSign10", SqlDbType.VarChar,50),
					new SqlParameter("@qaSign11", SqlDbType.VarChar,50),
					new SqlParameter("@qaSign12", SqlDbType.VarChar,50),
					new SqlParameter("@customer", SqlDbType.VarChar,50),
					new SqlParameter("@lastUpdatedTime", SqlDbType.DateTime2,8),
					new SqlParameter("@trackingID", SqlDbType.VarChar,50),
                    new SqlParameter("@remarks", SqlDbType.VarChar,500),
                    new SqlParameter("@QCNGQTY", SqlDbType.Decimal, 9),
                    new SqlParameter("@Material_MHCheck", SqlDbType.VarChar, 50),
                    new SqlParameter("@Material_MHCheckTime", SqlDbType.DateTime2, 8),
                    new SqlParameter("@Material_Opcheck", SqlDbType.VarChar, 50),
                    new SqlParameter("@Material_OpCheckTime", SqlDbType.DateTime2, 8),
                    new SqlParameter("@Material_LeaderCheck", SqlDbType.VarChar, 50),
                    new SqlParameter("@Material_LeaderCheckTime", SqlDbType.DateTime2, 8),
                    new SqlParameter("@LeaderCheck", SqlDbType.VarChar, 50),
                    new SqlParameter("@LeaderCheckTime", SqlDbType.DateTime2, 8),
                    new SqlParameter("@SupervisorCheck", SqlDbType.VarChar, 50),
                    new SqlParameter("@SupervisorCheckTime", SqlDbType.DateTime2,8),
                    new SqlParameter("@partNumberAll", SqlDbType.VarChar,500),
                    new SqlParameter("@parts2Weight", SqlDbType.Decimal,9),
                    new SqlParameter("@lastQty", SqlDbType.Decimal,9) ,
                    new SqlParameter("@OkAccumulation", SqlDbType.VarChar,50)};
            parameters[0].Value = model.id == null ? (object)DBNull.Value : model.id ;
			parameters[1].Value = model.machineID == null ? (object)DBNull.Value : model.machineID ;
			parameters[2].Value = model.dateTime == null ? (object)DBNull.Value : model.dateTime ;
			parameters[3].Value = model.partNumber == null ? (object)DBNull.Value : model.partNumber ;
			parameters[4].Value = model.jigNo == null ? (object)DBNull.Value : model.jigNo ;
			parameters[5].Value = model.model == null ? (object)DBNull.Value : model.model ;
			parameters[6].Value = model.cavityCount == null ? (object)DBNull.Value : model.cavityCount ;
			parameters[7].Value = model.partsWeight == null ? (object)DBNull.Value : model.partsWeight ;
			parameters[8].Value = model.cycleTime == null ? (object)DBNull.Value : model.cycleTime ;
			parameters[9].Value = model.targetQty == null ? (object)DBNull.Value : model.targetQty ;
			parameters[10].Value = model.userName == null ? (object)DBNull.Value : model.userName ;
			parameters[11].Value = model.userID == null ? (object)DBNull.Value : model.userID ;
			parameters[12].Value = model.acountReading == null ? (object)DBNull.Value : model.acountReading ;
			parameters[13].Value = model.rejectQty == null ? (object)DBNull.Value : model.rejectQty ;
			parameters[14].Value = model.acceptQty == null ? (object)DBNull.Value : model.acceptQty ;
			parameters[15].Value = model.startTime == null ? (object)DBNull.Value : model.startTime ;
			parameters[16].Value = model.stopTime == null ? (object)DBNull.Value : model.stopTime ;
			parameters[17].Value = model.day == null ? (object)DBNull.Value : model.day ;
			parameters[18].Value = model.shift == null ? (object)DBNull.Value : model.shift ;
			parameters[19].Value = model.status == null ? (object)DBNull.Value : model.status ;
			parameters[20].Value = model.matPart01 == null ? (object)DBNull.Value : model.matPart01 ;
			parameters[21].Value = model.matPart02 == null ? (object)DBNull.Value : model.matPart02 ;
			parameters[22].Value = model.matLot01 == null ? (object)DBNull.Value : model.matLot01 ;
			parameters[23].Value = model.matLot02 == null ? (object)DBNull.Value : model.matLot02 ;
			parameters[24].Value = model.opSign01 == null ? (object)DBNull.Value : model.opSign01 ;
			parameters[25].Value = model.opSign02 == null ? (object)DBNull.Value : model.opSign02 ;
			parameters[26].Value = model.opSign03 == null ? (object)DBNull.Value : model.opSign03 ;
			parameters[27].Value = model.opSign04 == null ? (object)DBNull.Value : model.opSign04 ;
			parameters[28].Value = model.opSign05 == null ? (object)DBNull.Value : model.opSign05 ;
			parameters[29].Value = model.opSign06 == null ? (object)DBNull.Value : model.opSign06 ;
			parameters[30].Value = model.opSign07 == null ? (object)DBNull.Value : model.opSign07 ;
			parameters[31].Value = model.opSign08 == null ? (object)DBNull.Value : model.opSign08 ;
			parameters[32].Value = model.opSign09 == null ? (object)DBNull.Value : model.opSign09 ;
			parameters[33].Value = model.opSign10 == null ? (object)DBNull.Value : model.opSign10 ;
			parameters[34].Value = model.opSign11 == null ? (object)DBNull.Value : model.opSign11 ;
			parameters[35].Value = model.opSign12 == null ? (object)DBNull.Value : model.opSign12 ;
			parameters[36].Value = model.qaSign01 == null ? (object)DBNull.Value : model.qaSign01 ;
			parameters[37].Value = model.qaSign02 == null ? (object)DBNull.Value : model.qaSign02 ;
			parameters[38].Value = model.qaSign03 == null ? (object)DBNull.Value : model.qaSign03 ;
			parameters[39].Value = model.qaSign04 == null ? (object)DBNull.Value : model.qaSign04 ;
			parameters[40].Value = model.qaSign05 == null ? (object)DBNull.Value : model.qaSign05 ;
			parameters[41].Value = model.qaSign06 == null ? (object)DBNull.Value : model.qaSign06 ;
			parameters[42].Value = model.qaSign07 == null ? (object)DBNull.Value : model.qaSign07 ;
			parameters[43].Value = model.qaSign08 == null ? (object)DBNull.Value : model.qaSign08 ;
			parameters[44].Value = model.qaSign09 == null ? (object)DBNull.Value : model.qaSign09 ;
			parameters[45].Value = model.qaSign10 == null ? (object)DBNull.Value : model.qaSign10 ;
			parameters[46].Value = model.qaSign11 == null ? (object)DBNull.Value : model.qaSign11 ;
			parameters[47].Value = model.qaSign12 == null ? (object)DBNull.Value : model.qaSign12 ;
			parameters[48].Value = model.customer == null ? (object)DBNull.Value : model.customer ;
			parameters[49].Value = model.lastUpdatedTime == null ? (object)DBNull.Value : model.lastUpdatedTime ;
			parameters[50].Value = model.trackingID == null ? (object)DBNull.Value : model.trackingID ;
            parameters[51].Value = model.remarks == null ? (object)DBNull.Value : model.remarks;
            parameters[52].Value = model.QCNGQTY == null ? (object)DBNull.Value : model.QCNGQTY;
            parameters[53].Value = model.Material_MHCheck == null ? (object)DBNull.Value : model.Material_MHCheck;
            parameters[54].Value = model.Material_MHCheckTime == null ? (object)DBNull.Value : model.Material_MHCheckTime;
            parameters[55].Value = model.Material_Opcheck == null ? (object)DBNull.Value : model.Material_Opcheck;
            parameters[56].Value = model.Material_OpCheckTime == null ? (object)DBNull.Value : model.Material_OpCheckTime;
            parameters[57].Value = model.Material_LeaderCheck == null ? (object)DBNull.Value : model.Material_LeaderCheck;
            parameters[58].Value = model.Material_LeaderCheckTime == null ? (object)DBNull.Value : model.Material_LeaderCheckTime;
            parameters[59].Value = model.LeaderCheck == null ? (object)DBNull.Value : model.LeaderCheck;
            parameters[60].Value = model.LeaderCheckTime == null ? (object)DBNull.Value : model.LeaderCheckTime;
            parameters[61].Value = model.SupervisorCheck == null ? (object)DBNull.Value : model.SupervisorCheck;
            parameters[62].Value = model.SupervisorCheckTime == null ? (object)DBNull.Value : model.SupervisorCheckTime;
            parameters[63].Value = model.partnumberall == null ? (object)DBNull.Value : model.partnumberall;
            parameters[64].Value = model.parts2Weight == null ? (object)DBNull.Value : model.parts2Weight;
            parameters[65].Value = model.lastQty == null ? (object)DBNull.Value : model.lastQty;
            parameters[66].Value = model.OkAccumulation == null ? (object)DBNull.Value : model.OkAccumulation;

            DBHelp.Reports.LogFile.DebugLog("AUTOCODE","NameSpace:Common.DAL" , "Class:MouldingViTracking_DAL" , "Function:		public SqlCommand UpdateCommand(Common.Model.MouldingViTracking_Model model)"  + "TableName:MouldingViTracking" , ";id = "+ (model.id == null ? "" : model.id.ToString()) + ";machineID = "+ (model.machineID == null ? "" : model.machineID.ToString()) + ";dateTime = "+ (model.dateTime == null ? "" : model.dateTime.ToString()) + ";partNumber = "+ (model.partNumber == null ? "" : model.partNumber.ToString()) + ";jigNo = "+ (model.jigNo == null ? "" : model.jigNo.ToString()) + ";model = "+ (model.model == null ? "" : model.model.ToString()) + ";cavityCount = "+ (model.cavityCount == null ? "" : model.cavityCount.ToString()) + ";partsWeight = "+ (model.partsWeight == null ? "" : model.partsWeight.ToString()) + ";cycleTime = "+ (model.cycleTime == null ? "" : model.cycleTime.ToString()) + ";targetQty = "+ (model.targetQty == null ? "" : model.targetQty.ToString()) + ";userName = "+ (model.userName == null ? "" : model.userName.ToString()) + ";userID = "+ (model.userID == null ? "" : model.userID.ToString()) + ";acountReading = "+ (model.acountReading == null ? "" : model.acountReading.ToString()) + ";rejectQty = "+ (model.rejectQty == null ? "" : model.rejectQty.ToString()) + ";acceptQty = "+ (model.acceptQty == null ? "" : model.acceptQty.ToString()) + ";startTime = "+ (model.startTime == null ? "" : model.startTime.ToString()) + ";stopTime = "+ (model.stopTime == null ? "" : model.stopTime.ToString()) + ";day = "+ (model.day == null ? "" : model.day.ToString()) + ";shift = "+ (model.shift == null ? "" : model.shift.ToString()) + ";status = "+ (model.status == null ? "" : model.status.ToString()) + ";matPart01 = "+ (model.matPart01 == null ? "" : model.matPart01.ToString()) + ";matPart02 = "+ (model.matPart02 == null ? "" : model.matPart02.ToString()) + ";matLot01 = "+ (model.matLot01 == null ? "" : model.matLot01.ToString()) + ";matLot02 = "+ (model.matLot02 == null ? "" : model.matLot02.ToString()) + ";opSign01 = "+ (model.opSign01 == null ? "" : model.opSign01.ToString()) + ";opSign02 = "+ (model.opSign02 == null ? "" : model.opSign02.ToString()) + ";opSign03 = "+ (model.opSign03 == null ? "" : model.opSign03.ToString()) + ";opSign04 = "+ (model.opSign04 == null ? "" : model.opSign04.ToString()) + ";opSign05 = "+ (model.opSign05 == null ? "" : model.opSign05.ToString()) + ";opSign06 = "+ (model.opSign06 == null ? "" : model.opSign06.ToString()) + ";opSign07 = "+ (model.opSign07 == null ? "" : model.opSign07.ToString()) + ";opSign08 = "+ (model.opSign08 == null ? "" : model.opSign08.ToString()) + ";opSign09 = "+ (model.opSign09 == null ? "" : model.opSign09.ToString()) + ";opSign10 = "+ (model.opSign10 == null ? "" : model.opSign10.ToString()) + ";opSign11 = "+ (model.opSign11 == null ? "" : model.opSign11.ToString()) + ";opSign12 = "+ (model.opSign12 == null ? "" : model.opSign12.ToString()) + ";qaSign01 = "+ (model.qaSign01 == null ? "" : model.qaSign01.ToString()) + ";qaSign02 = "+ (model.qaSign02 == null ? "" : model.qaSign02.ToString()) + ";qaSign03 = "+ (model.qaSign03 == null ? "" : model.qaSign03.ToString()) + ";qaSign04 = "+ (model.qaSign04 == null ? "" : model.qaSign04.ToString()) + ";qaSign05 = "+ (model.qaSign05 == null ? "" : model.qaSign05.ToString()) + ";qaSign06 = "+ (model.qaSign06 == null ? "" : model.qaSign06.ToString()) + ";qaSign07 = "+ (model.qaSign07 == null ? "" : model.qaSign07.ToString()) + ";qaSign08 = "+ (model.qaSign08 == null ? "" : model.qaSign08.ToString()) + ";qaSign09 = "+ (model.qaSign09 == null ? "" : model.qaSign09.ToString()) + ";qaSign10 = "+ (model.qaSign10 == null ? "" : model.qaSign10.ToString()) + ";qaSign11 = "+ (model.qaSign11 == null ? "" : model.qaSign11.ToString()) + ";qaSign12 = "+ (model.qaSign12 == null ? "" : model.qaSign12.ToString()) + ";customer = "+ (model.customer == null ? "" : model.customer.ToString()) + ";lastUpdatedTime = "+ (model.lastUpdatedTime == null ? "" : model.lastUpdatedTime.ToString()) + ";trackingID = "+ (model.trackingID == null ? "" : model.trackingID.ToString()) + ";remarks = "+ (model.remarks == null ? "" : model.remarks.ToString()) + "");

            return DBHelp.SqlDB.generateCommand(strSql.ToString(),parameters);
		}

        public SqlCommand UpdateCommandbypartnumber(Common.Model.MouldingViTracking_Model model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update MouldingViTracking set ");
            strSql.Append("machineID=@machineID,");
            strSql.Append("dateTime=@dateTime,");
            strSql.Append("partNumber=@partNumber,");
            strSql.Append("jigNo=@jigNo,");
            strSql.Append("model=@model,");
            strSql.Append("cavityCount=@cavityCount,");
            strSql.Append("partsWeight=@partsWeight,");
            strSql.Append("cycleTime=@cycleTime,");
            strSql.Append("targetQty=@targetQty,");
            strSql.Append("userName=@userName,");
            strSql.Append("userID=@userID,");
            strSql.Append("acountReading=@acountReading,");
            strSql.Append("rejectQty=@rejectQty,");
            strSql.Append("acceptQty=@acceptQty,");
            strSql.Append("startTime=@startTime,");
            strSql.Append("stopTime=@stopTime,");
            strSql.Append("day=@day,");
            strSql.Append("shift=@shift,");
            strSql.Append("status=@status,");
            strSql.Append("matPart01=@matPart01,");
            strSql.Append("matPart02=@matPart02,");
            strSql.Append("matLot01=@matLot01,");
            strSql.Append("matLot02=@matLot02,");
            strSql.Append("opSign01=@opSign01,");
            strSql.Append("opSign02=@opSign02,");
            strSql.Append("opSign03=@opSign03,");
            strSql.Append("opSign04=@opSign04,");
            strSql.Append("opSign05=@opSign05,");
            strSql.Append("opSign06=@opSign06,");
            strSql.Append("opSign07=@opSign07,");
            strSql.Append("opSign08=@opSign08,");
            strSql.Append("opSign09=@opSign09,");
            strSql.Append("opSign10=@opSign10,");
            strSql.Append("opSign11=@opSign11,");
            strSql.Append("opSign12=@opSign12,");
            strSql.Append("qaSign01=@qaSign01,");
            strSql.Append("qaSign02=@qaSign02,");
            strSql.Append("qaSign03=@qaSign03,");
            strSql.Append("qaSign04=@qaSign04,");
            strSql.Append("qaSign05=@qaSign05,");
            strSql.Append("qaSign06=@qaSign06,");
            strSql.Append("qaSign07=@qaSign07,");
            strSql.Append("qaSign08=@qaSign08,");
            strSql.Append("qaSign09=@qaSign09,");
            strSql.Append("qaSign10=@qaSign10,");
            strSql.Append("qaSign11=@qaSign11,");
            strSql.Append("qaSign12=@qaSign12,");
            strSql.Append("customer=@customer,");
            strSql.Append("lastUpdatedTime=@lastUpdatedTime,");
            strSql.Append("trackingID=@trackingID,");
            strSql.Append("remarks=@remarks,");
            strSql.Append("QCNGQTY=@QCNGQTY,");
            strSql.Append("Material_MHCheck=@Material_MHCheck,");
            strSql.Append("Material_MHCheckTime=@Material_MHCheckTime,");
            strSql.Append("Material_Opcheck=@Material_Opcheck,");
            strSql.Append("Material_OpCheckTime=@Material_OpCheckTime,");
            strSql.Append("Material_LeaderCheck=@Material_LeaderCheck,");
            strSql.Append("Material_LeaderCheckTime=@Material_LeaderCheckTime,");
            strSql.Append("LeaderCheck=@LeaderCheck,");
            strSql.Append("LeaderCheckTime=@LeaderCheckTime,");
            strSql.Append("SupervisorCheck=@SupervisorCheck,");
            strSql.Append("SupervisorCheckTime=@SupervisorCheckTime,");
            strSql.Append("partNumberAll=@partNumberAll,");
            strSql.Append("parts2Weight=@parts2Weight,");
            strSql.Append("lastQty=@lastQty,");
            strSql.Append("OkAccumulation=@OkAccumulation");
            strSql.Append(" where  partNumberAll=@partNumberAll ");
            strSql.Append(" and day=@day ");
            strSql.Append(" and shift=@shift ");
            strSql.Append(" and partNumber=@partNumber ");
            strSql.Append(" and machineID=@machineID ");
            //2018/12/03 by datetime
            strSql.Append(" and dateTime=@dateTime ");
            SqlParameter[] parameters = {
                    new SqlParameter("@id", SqlDbType.Int,4),
                    new SqlParameter("@machineID", SqlDbType.VarChar,8),
                    new SqlParameter("@dateTime", SqlDbType.DateTime2,8),
                    new SqlParameter("@partNumber", SqlDbType.VarChar,50),
                    new SqlParameter("@jigNo", SqlDbType.VarChar,50),
                    new SqlParameter("@model", SqlDbType.VarChar,50),
                    new SqlParameter("@cavityCount", SqlDbType.Decimal,9),
                    new SqlParameter("@partsWeight", SqlDbType.Decimal,9),
                    new SqlParameter("@cycleTime", SqlDbType.Decimal,9),
                    new SqlParameter("@targetQty", SqlDbType.Decimal,9),
                    new SqlParameter("@userName", SqlDbType.VarChar,50),
                    new SqlParameter("@userID", SqlDbType.VarChar,50),
                    new SqlParameter("@acountReading", SqlDbType.Decimal,9),
                    new SqlParameter("@rejectQty", SqlDbType.Decimal,9),
                    new SqlParameter("@acceptQty", SqlDbType.Decimal,9),
                    new SqlParameter("@startTime", SqlDbType.DateTime2,8),
                    new SqlParameter("@stopTime", SqlDbType.DateTime2,8),
                    new SqlParameter("@day", SqlDbType.DateTime2,8),
                    new SqlParameter("@shift", SqlDbType.VarChar,50),
                    new SqlParameter("@status", SqlDbType.VarChar,50),
                    new SqlParameter("@matPart01", SqlDbType.VarChar,50),
                    new SqlParameter("@matPart02", SqlDbType.VarChar,50),
                    new SqlParameter("@matLot01", SqlDbType.VarChar,50),
                    new SqlParameter("@matLot02", SqlDbType.VarChar,50),
                    new SqlParameter("@opSign01", SqlDbType.VarChar,50),
                    new SqlParameter("@opSign02", SqlDbType.VarChar,50),
                    new SqlParameter("@opSign03", SqlDbType.VarChar,50),
                    new SqlParameter("@opSign04", SqlDbType.VarChar,50),
                    new SqlParameter("@opSign05", SqlDbType.VarChar,50),
                    new SqlParameter("@opSign06", SqlDbType.VarChar,50),
                    new SqlParameter("@opSign07", SqlDbType.VarChar,50),
                    new SqlParameter("@opSign08", SqlDbType.VarChar,50),
                    new SqlParameter("@opSign09", SqlDbType.VarChar,50),
                    new SqlParameter("@opSign10", SqlDbType.VarChar,50),
                    new SqlParameter("@opSign11", SqlDbType.VarChar,50),
                    new SqlParameter("@opSign12", SqlDbType.VarChar,50),
                    new SqlParameter("@qaSign01", SqlDbType.VarChar,50),
                    new SqlParameter("@qaSign02", SqlDbType.VarChar,50),
                    new SqlParameter("@qaSign03", SqlDbType.VarChar,50),
                    new SqlParameter("@qaSign04", SqlDbType.VarChar,50),
                    new SqlParameter("@qaSign05", SqlDbType.VarChar,50),
                    new SqlParameter("@qaSign06", SqlDbType.VarChar,50),
                    new SqlParameter("@qaSign07", SqlDbType.VarChar,50),
                    new SqlParameter("@qaSign08", SqlDbType.VarChar,50),
                    new SqlParameter("@qaSign09", SqlDbType.VarChar,50),
                    new SqlParameter("@qaSign10", SqlDbType.VarChar,50),
                    new SqlParameter("@qaSign11", SqlDbType.VarChar,50),
                    new SqlParameter("@qaSign12", SqlDbType.VarChar,50),
                    new SqlParameter("@customer", SqlDbType.VarChar,50),
                    new SqlParameter("@lastUpdatedTime", SqlDbType.DateTime2,8),
                    new SqlParameter("@trackingID", SqlDbType.VarChar,50),
                    new SqlParameter("@remarks", SqlDbType.VarChar,500),
                    new SqlParameter("@QCNGQTY", SqlDbType.Decimal, 9),
                    new SqlParameter("@Material_MHCheck", SqlDbType.VarChar, 50),
                    new SqlParameter("@Material_MHCheckTime", SqlDbType.DateTime2, 8),
                    new SqlParameter("@Material_Opcheck", SqlDbType.VarChar, 50),
                    new SqlParameter("@Material_OpCheckTime", SqlDbType.DateTime2, 8),
                    new SqlParameter("@Material_LeaderCheck", SqlDbType.VarChar, 50),
                    new SqlParameter("@Material_LeaderCheckTime", SqlDbType.DateTime2, 8),
                    new SqlParameter("@LeaderCheck", SqlDbType.VarChar, 50),
                    new SqlParameter("@LeaderCheckTime", SqlDbType.DateTime2, 8),
                    new SqlParameter("@SupervisorCheck", SqlDbType.VarChar, 50),
                    new SqlParameter("@SupervisorCheckTime", SqlDbType.DateTime2,8),
                    new SqlParameter("@partNumberAll", SqlDbType.VarChar,500),
                    new SqlParameter("@parts2Weight", SqlDbType.Decimal,9),
                    new SqlParameter("@lastQty", SqlDbType.Decimal,9) ,
                    new SqlParameter("@OkAccumulation", SqlDbType.VarChar,50)};
            parameters[0].Value = model.id == null ? (object)DBNull.Value : model.id;
            parameters[1].Value = model.machineID == null ? (object)DBNull.Value : model.machineID;
            parameters[2].Value = model.dateTime == null ? (object)DBNull.Value : model.dateTime;
            parameters[3].Value = model.partNumber == null ? (object)DBNull.Value : model.partNumber;
            parameters[4].Value = model.jigNo == null ? (object)DBNull.Value : model.jigNo;
            parameters[5].Value = model.model == null ? (object)DBNull.Value : model.model;
            parameters[6].Value = model.cavityCount == null ? (object)DBNull.Value : model.cavityCount;
            parameters[7].Value = model.partsWeight == null ? (object)DBNull.Value : model.partsWeight;
            parameters[8].Value = model.cycleTime == null ? (object)DBNull.Value : model.cycleTime;
            parameters[9].Value = model.targetQty == null ? (object)DBNull.Value : model.targetQty;
            parameters[10].Value = model.userName == null ? (object)DBNull.Value : model.userName;
            parameters[11].Value = model.userID == null ? (object)DBNull.Value : model.userID;
            parameters[12].Value = model.acountReading == null ? (object)DBNull.Value : model.acountReading;
            parameters[13].Value = model.rejectQty == null ? (object)DBNull.Value : model.rejectQty;
            parameters[14].Value = model.acceptQty == null ? (object)DBNull.Value : model.acceptQty;
            parameters[15].Value = model.startTime == null ? (object)DBNull.Value : model.startTime;
            parameters[16].Value = model.stopTime == null ? (object)DBNull.Value : model.stopTime;
            parameters[17].Value = model.day == null ? (object)DBNull.Value : model.day;
            parameters[18].Value = model.shift == null ? (object)DBNull.Value : model.shift;
            parameters[19].Value = model.status == null ? (object)DBNull.Value : model.status;
            parameters[20].Value = model.matPart01 == null ? (object)DBNull.Value : model.matPart01;
            parameters[21].Value = model.matPart02 == null ? (object)DBNull.Value : model.matPart02;
            parameters[22].Value = model.matLot01 == null ? (object)DBNull.Value : model.matLot01;
            parameters[23].Value = model.matLot02 == null ? (object)DBNull.Value : model.matLot02;
            parameters[24].Value = model.opSign01 == null ? (object)DBNull.Value : model.opSign01;
            parameters[25].Value = model.opSign02 == null ? (object)DBNull.Value : model.opSign02;
            parameters[26].Value = model.opSign03 == null ? (object)DBNull.Value : model.opSign03;
            parameters[27].Value = model.opSign04 == null ? (object)DBNull.Value : model.opSign04;
            parameters[28].Value = model.opSign05 == null ? (object)DBNull.Value : model.opSign05;
            parameters[29].Value = model.opSign06 == null ? (object)DBNull.Value : model.opSign06;
            parameters[30].Value = model.opSign07 == null ? (object)DBNull.Value : model.opSign07;
            parameters[31].Value = model.opSign08 == null ? (object)DBNull.Value : model.opSign08;
            parameters[32].Value = model.opSign09 == null ? (object)DBNull.Value : model.opSign09;
            parameters[33].Value = model.opSign10 == null ? (object)DBNull.Value : model.opSign10;
            parameters[34].Value = model.opSign11 == null ? (object)DBNull.Value : model.opSign11;
            parameters[35].Value = model.opSign12 == null ? (object)DBNull.Value : model.opSign12;
            parameters[36].Value = model.qaSign01 == null ? (object)DBNull.Value : model.qaSign01;
            parameters[37].Value = model.qaSign02 == null ? (object)DBNull.Value : model.qaSign02;
            parameters[38].Value = model.qaSign03 == null ? (object)DBNull.Value : model.qaSign03;
            parameters[39].Value = model.qaSign04 == null ? (object)DBNull.Value : model.qaSign04;
            parameters[40].Value = model.qaSign05 == null ? (object)DBNull.Value : model.qaSign05;
            parameters[41].Value = model.qaSign06 == null ? (object)DBNull.Value : model.qaSign06;
            parameters[42].Value = model.qaSign07 == null ? (object)DBNull.Value : model.qaSign07;
            parameters[43].Value = model.qaSign08 == null ? (object)DBNull.Value : model.qaSign08;
            parameters[44].Value = model.qaSign09 == null ? (object)DBNull.Value : model.qaSign09;
            parameters[45].Value = model.qaSign10 == null ? (object)DBNull.Value : model.qaSign10;
            parameters[46].Value = model.qaSign11 == null ? (object)DBNull.Value : model.qaSign11;
            parameters[47].Value = model.qaSign12 == null ? (object)DBNull.Value : model.qaSign12;
            parameters[48].Value = model.customer == null ? (object)DBNull.Value : model.customer;
            parameters[49].Value = model.lastUpdatedTime == null ? (object)DBNull.Value : model.lastUpdatedTime;
            parameters[50].Value = model.trackingID == null ? (object)DBNull.Value : model.trackingID;
            parameters[51].Value = model.remarks == null ? (object)DBNull.Value : model.remarks;
            parameters[52].Value = model.QCNGQTY == null ? (object)DBNull.Value : model.QCNGQTY;
            parameters[53].Value = model.Material_MHCheck == null ? (object)DBNull.Value : model.Material_MHCheck;
            parameters[54].Value = model.Material_MHCheckTime == null ? (object)DBNull.Value : model.Material_MHCheckTime;
            parameters[55].Value = model.Material_Opcheck == null ? (object)DBNull.Value : model.Material_Opcheck;
            parameters[56].Value = model.Material_OpCheckTime == null ? (object)DBNull.Value : model.Material_OpCheckTime;
            parameters[57].Value = model.Material_LeaderCheck == null ? (object)DBNull.Value : model.Material_LeaderCheck;
            parameters[58].Value = model.Material_LeaderCheckTime == null ? (object)DBNull.Value : model.Material_LeaderCheckTime;
            parameters[59].Value = model.LeaderCheck == null ? (object)DBNull.Value : model.LeaderCheck;
            parameters[60].Value = model.LeaderCheckTime == null ? (object)DBNull.Value : model.LeaderCheckTime;
            parameters[61].Value = model.SupervisorCheck == null ? (object)DBNull.Value : model.SupervisorCheck;
            parameters[62].Value = model.SupervisorCheckTime == null ? (object)DBNull.Value : model.SupervisorCheckTime;
            parameters[63].Value = model.partnumberall == null ? (object)DBNull.Value : model.partnumberall;
            parameters[64].Value = model.parts2Weight == null ? (object)DBNull.Value : model.parts2Weight;
            parameters[65].Value = model.lastQty == null ? (object)DBNull.Value : model.lastQty;
            parameters[66].Value = model.OkAccumulation == null ? (object)DBNull.Value : model.OkAccumulation;
            DBHelp.Reports.LogFile.DebugLog("AUTOCODE", "NameSpace:Common.DAL", "Class:MouldingViTracking_DAL", "Function:		public SqlCommand UpdateCommand(Common.Model.MouldingViTracking_Model model)" + "TableName:MouldingViTracking", ";id = " + (model.id == null ? "" : model.id.ToString()) + ";machineID = " + (model.machineID == null ? "" : model.machineID.ToString()) + ";dateTime = " + (model.dateTime == null ? "" : model.dateTime.ToString()) + ";partNumber = " + (model.partNumber == null ? "" : model.partNumber.ToString()) + ";jigNo = " + (model.jigNo == null ? "" : model.jigNo.ToString()) + ";model = " + (model.model == null ? "" : model.model.ToString()) + ";cavityCount = " + (model.cavityCount == null ? "" : model.cavityCount.ToString()) + ";partsWeight = " + (model.partsWeight == null ? "" : model.partsWeight.ToString()) + ";cycleTime = " + (model.cycleTime == null ? "" : model.cycleTime.ToString()) + ";targetQty = " + (model.targetQty == null ? "" : model.targetQty.ToString()) + ";userName = " + (model.userName == null ? "" : model.userName.ToString()) + ";userID = " + (model.userID == null ? "" : model.userID.ToString()) + ";acountReading = " + (model.acountReading == null ? "" : model.acountReading.ToString()) + ";rejectQty = " + (model.rejectQty == null ? "" : model.rejectQty.ToString()) + ";acceptQty = " + (model.acceptQty == null ? "" : model.acceptQty.ToString()) + ";startTime = " + (model.startTime == null ? "" : model.startTime.ToString()) + ";stopTime = " + (model.stopTime == null ? "" : model.stopTime.ToString()) + ";day = " + (model.day == null ? "" : model.day.ToString()) + ";shift = " + (model.shift == null ? "" : model.shift.ToString()) + ";status = " + (model.status == null ? "" : model.status.ToString()) + ";matPart01 = " + (model.matPart01 == null ? "" : model.matPart01.ToString()) + ";matPart02 = " + (model.matPart02 == null ? "" : model.matPart02.ToString()) + ";matLot01 = " + (model.matLot01 == null ? "" : model.matLot01.ToString()) + ";matLot02 = " + (model.matLot02 == null ? "" : model.matLot02.ToString()) + ";opSign01 = " + (model.opSign01 == null ? "" : model.opSign01.ToString()) + ";opSign02 = " + (model.opSign02 == null ? "" : model.opSign02.ToString()) + ";opSign03 = " + (model.opSign03 == null ? "" : model.opSign03.ToString()) + ";opSign04 = " + (model.opSign04 == null ? "" : model.opSign04.ToString()) + ";opSign05 = " + (model.opSign05 == null ? "" : model.opSign05.ToString()) + ";opSign06 = " + (model.opSign06 == null ? "" : model.opSign06.ToString()) + ";opSign07 = " + (model.opSign07 == null ? "" : model.opSign07.ToString()) + ";opSign08 = " + (model.opSign08 == null ? "" : model.opSign08.ToString()) + ";opSign09 = " + (model.opSign09 == null ? "" : model.opSign09.ToString()) + ";opSign10 = " + (model.opSign10 == null ? "" : model.opSign10.ToString()) + ";opSign11 = " + (model.opSign11 == null ? "" : model.opSign11.ToString()) + ";opSign12 = " + (model.opSign12 == null ? "" : model.opSign12.ToString()) + ";qaSign01 = " + (model.qaSign01 == null ? "" : model.qaSign01.ToString()) + ";qaSign02 = " + (model.qaSign02 == null ? "" : model.qaSign02.ToString()) + ";qaSign03 = " + (model.qaSign03 == null ? "" : model.qaSign03.ToString()) + ";qaSign04 = " + (model.qaSign04 == null ? "" : model.qaSign04.ToString()) + ";qaSign05 = " + (model.qaSign05 == null ? "" : model.qaSign05.ToString()) + ";qaSign06 = " + (model.qaSign06 == null ? "" : model.qaSign06.ToString()) + ";qaSign07 = " + (model.qaSign07 == null ? "" : model.qaSign07.ToString()) + ";qaSign08 = " + (model.qaSign08 == null ? "" : model.qaSign08.ToString()) + ";qaSign09 = " + (model.qaSign09 == null ? "" : model.qaSign09.ToString()) + ";qaSign10 = " + (model.qaSign10 == null ? "" : model.qaSign10.ToString()) + ";qaSign11 = " + (model.qaSign11 == null ? "" : model.qaSign11.ToString()) + ";qaSign12 = " + (model.qaSign12 == null ? "" : model.qaSign12.ToString()) + ";customer = " + (model.customer == null ? "" : model.customer.ToString()) + ";lastUpdatedTime = " + (model.lastUpdatedTime == null ? "" : model.lastUpdatedTime.ToString()) + ";trackingID = " + (model.trackingID == null ? "" : model.trackingID.ToString()) + ";remarks = " + (model.remarks == null ? "" : model.remarks.ToString()) + "");
            return DBHelp.SqlDB.generateCommand(strSql.ToString(), parameters);
        }
        
        public SqlCommand UpdateCommandbyTrackingID(Common.Model.MouldingViTracking_Model model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update MouldingViTracking set ");
            strSql.Append("machineID=@machineID,");
            strSql.Append("dateTime=@dateTime,");
            strSql.Append("partNumber=@partNumber,");
            strSql.Append("jigNo=@jigNo,");
            strSql.Append("model=@model,");
            strSql.Append("cavityCount=@cavityCount,");
            strSql.Append("partsWeight=@partsWeight,");
            strSql.Append("cycleTime=@cycleTime,");
            strSql.Append("targetQty=@targetQty,");
            strSql.Append("userName=@userName,");
            strSql.Append("userID=@userID,");
            strSql.Append("acountReading=@acountReading,");
            strSql.Append("rejectQty=@rejectQty,");
            strSql.Append("acceptQty=@acceptQty,");
            strSql.Append("startTime=@startTime,");
            strSql.Append("stopTime=@stopTime,");
            strSql.Append("day=@day,");
            strSql.Append("shift=@shift,");
            strSql.Append("status=@status,");
            strSql.Append("matPart01=@matPart01,");
            strSql.Append("matPart02=@matPart02,");
            strSql.Append("matLot01=@matLot01,");
            strSql.Append("matLot02=@matLot02,");
            strSql.Append("opSign01=@opSign01,");
            strSql.Append("opSign02=@opSign02,");
            strSql.Append("opSign03=@opSign03,");
            strSql.Append("opSign04=@opSign04,");
            strSql.Append("opSign05=@opSign05,");
            strSql.Append("opSign06=@opSign06,");
            strSql.Append("opSign07=@opSign07,");
            strSql.Append("opSign08=@opSign08,");
            strSql.Append("opSign09=@opSign09,");
            strSql.Append("opSign10=@opSign10,");
            strSql.Append("opSign11=@opSign11,");
            strSql.Append("opSign12=@opSign12,");
            strSql.Append("qaSign01=@qaSign01,");
            strSql.Append("qaSign02=@qaSign02,");
            strSql.Append("qaSign03=@qaSign03,");
            strSql.Append("qaSign04=@qaSign04,");
            strSql.Append("qaSign05=@qaSign05,");
            strSql.Append("qaSign06=@qaSign06,");
            strSql.Append("qaSign07=@qaSign07,");
            strSql.Append("qaSign08=@qaSign08,");
            strSql.Append("qaSign09=@qaSign09,");
            strSql.Append("qaSign10=@qaSign10,");
            strSql.Append("qaSign11=@qaSign11,");
            strSql.Append("qaSign12=@qaSign12,");
            strSql.Append("customer=@customer,");
            strSql.Append("lastUpdatedTime=@lastUpdatedTime,");
            //strSql.Append("trackingID=@trackingID,");
            strSql.Append("remarks=@remarks,");
            strSql.Append("QCNGQTY=@QCNGQTY,");
            strSql.Append("Material_MHCheck=@Material_MHCheck,");
            strSql.Append("Material_MHCheckTime=@Material_MHCheckTime,");
            strSql.Append("Material_Opcheck=@Material_Opcheck,");
            strSql.Append("Material_OpCheckTime=@Material_OpCheckTime,");
            strSql.Append("Material_LeaderCheck=@Material_LeaderCheck,");
            strSql.Append("Material_LeaderCheckTime=@Material_LeaderCheckTime,");
            strSql.Append("LeaderCheck=@LeaderCheck,");
            strSql.Append("LeaderCheckTime=@LeaderCheckTime,");
            strSql.Append("SupervisorCheck=@SupervisorCheck,");
            strSql.Append("SupervisorCheckTime=@SupervisorCheckTime,");
            strSql.Append("partNumberAll=@partNumberAll,");
            strSql.Append("parts2Weight=@parts2Weight,");
            strSql.Append("lastQty=@lastQty,");
            strSql.Append("OkAccumulation=@OkAccumulation");
            strSql.Append(" where  trackingID=@trackingID ");
            SqlParameter[] parameters = {
                    new SqlParameter("@id", SqlDbType.Int,4),
                    new SqlParameter("@machineID", SqlDbType.VarChar,8),
                    new SqlParameter("@dateTime", SqlDbType.DateTime2,8),
                    new SqlParameter("@partNumber", SqlDbType.VarChar,50),
                    new SqlParameter("@jigNo", SqlDbType.VarChar,50),
                    new SqlParameter("@model", SqlDbType.VarChar,50),
                    new SqlParameter("@cavityCount", SqlDbType.Decimal,9),
                    new SqlParameter("@partsWeight", SqlDbType.Decimal,9),
                    new SqlParameter("@cycleTime", SqlDbType.Decimal,9),
                    new SqlParameter("@targetQty", SqlDbType.Decimal,9),
                    new SqlParameter("@userName", SqlDbType.VarChar,50),
                    new SqlParameter("@userID", SqlDbType.VarChar,50),
                    new SqlParameter("@acountReading", SqlDbType.Decimal,9),
                    new SqlParameter("@rejectQty", SqlDbType.Decimal,9),
                    new SqlParameter("@acceptQty", SqlDbType.Decimal,9),
                    new SqlParameter("@startTime", SqlDbType.DateTime2,8),
                    new SqlParameter("@stopTime", SqlDbType.DateTime2,8),
                    new SqlParameter("@day", SqlDbType.DateTime2,8),
                    new SqlParameter("@shift", SqlDbType.VarChar,50),
                    new SqlParameter("@status", SqlDbType.VarChar,50),
                    new SqlParameter("@matPart01", SqlDbType.VarChar,50),
                    new SqlParameter("@matPart02", SqlDbType.VarChar,50),
                    new SqlParameter("@matLot01", SqlDbType.VarChar,50),
                    new SqlParameter("@matLot02", SqlDbType.VarChar,50),
                    new SqlParameter("@opSign01", SqlDbType.VarChar,50),
                    new SqlParameter("@opSign02", SqlDbType.VarChar,50),
                    new SqlParameter("@opSign03", SqlDbType.VarChar,50),
                    new SqlParameter("@opSign04", SqlDbType.VarChar,50),
                    new SqlParameter("@opSign05", SqlDbType.VarChar,50),
                    new SqlParameter("@opSign06", SqlDbType.VarChar,50),
                    new SqlParameter("@opSign07", SqlDbType.VarChar,50),
                    new SqlParameter("@opSign08", SqlDbType.VarChar,50),
                    new SqlParameter("@opSign09", SqlDbType.VarChar,50),
                    new SqlParameter("@opSign10", SqlDbType.VarChar,50),
                    new SqlParameter("@opSign11", SqlDbType.VarChar,50),
                    new SqlParameter("@opSign12", SqlDbType.VarChar,50),
                    new SqlParameter("@qaSign01", SqlDbType.VarChar,50),
                    new SqlParameter("@qaSign02", SqlDbType.VarChar,50),
                    new SqlParameter("@qaSign03", SqlDbType.VarChar,50),
                    new SqlParameter("@qaSign04", SqlDbType.VarChar,50),
                    new SqlParameter("@qaSign05", SqlDbType.VarChar,50),
                    new SqlParameter("@qaSign06", SqlDbType.VarChar,50),
                    new SqlParameter("@qaSign07", SqlDbType.VarChar,50),
                    new SqlParameter("@qaSign08", SqlDbType.VarChar,50),
                    new SqlParameter("@qaSign09", SqlDbType.VarChar,50),
                    new SqlParameter("@qaSign10", SqlDbType.VarChar,50),
                    new SqlParameter("@qaSign11", SqlDbType.VarChar,50),
                    new SqlParameter("@qaSign12", SqlDbType.VarChar,50),
                    new SqlParameter("@customer", SqlDbType.VarChar,50),
                    new SqlParameter("@lastUpdatedTime", SqlDbType.DateTime2,8),
                    new SqlParameter("@trackingID", SqlDbType.VarChar,50),
                    new SqlParameter("@remarks", SqlDbType.VarChar,500),
                    new SqlParameter("@QCNGQTY", SqlDbType.Decimal, 9),
                    new SqlParameter("@Material_MHCheck", SqlDbType.VarChar, 50),
                    new SqlParameter("@Material_MHCheckTime", SqlDbType.DateTime2, 8),
                    new SqlParameter("@Material_Opcheck", SqlDbType.VarChar, 50),
                    new SqlParameter("@Material_OpCheckTime", SqlDbType.DateTime2, 8),
                    new SqlParameter("@Material_LeaderCheck", SqlDbType.VarChar, 50),
                    new SqlParameter("@Material_LeaderCheckTime", SqlDbType.DateTime2, 8),
                    new SqlParameter("@LeaderCheck", SqlDbType.VarChar, 50),
                    new SqlParameter("@LeaderCheckTime", SqlDbType.DateTime2, 8),
                    new SqlParameter("@SupervisorCheck", SqlDbType.VarChar, 50),
                    new SqlParameter("@SupervisorCheckTime", SqlDbType.DateTime2,8),
                    new SqlParameter("@partNumberAll", SqlDbType.VarChar,500),
                    new SqlParameter("@parts2Weight", SqlDbType.Decimal,9),
                    new SqlParameter("@lastQty", SqlDbType.Decimal,9),
                    new SqlParameter("@OkAccumulation", SqlDbType.VarChar,50)};
            parameters[0].Value = model.id == null ? (object)DBNull.Value : model.id;
            parameters[1].Value = model.machineID == null ? (object)DBNull.Value : model.machineID;
            parameters[2].Value = model.dateTime == null ? (object)DBNull.Value : model.dateTime;
            parameters[3].Value = model.partNumber == null ? (object)DBNull.Value : model.partNumber;
            parameters[4].Value = model.jigNo == null ? (object)DBNull.Value : model.jigNo;
            parameters[5].Value = model.model == null ? (object)DBNull.Value : model.model;
            parameters[6].Value = model.cavityCount == null ? (object)DBNull.Value : model.cavityCount;
            parameters[7].Value = model.partsWeight == null ? (object)DBNull.Value : model.partsWeight;
            parameters[8].Value = model.cycleTime == null ? (object)DBNull.Value : model.cycleTime;
            parameters[9].Value = model.targetQty == null ? (object)DBNull.Value : model.targetQty;
            parameters[10].Value = model.userName == null ? (object)DBNull.Value : model.userName;
            parameters[11].Value = model.userID == null ? (object)DBNull.Value : model.userID;
            parameters[12].Value = model.acountReading == null ? (object)DBNull.Value : model.acountReading;
            parameters[13].Value = model.rejectQty == null ? (object)DBNull.Value : model.rejectQty;
            parameters[14].Value = model.acceptQty == null ? (object)DBNull.Value : model.acceptQty;
            parameters[15].Value = model.startTime == null ? (object)DBNull.Value : model.startTime;
            parameters[16].Value = model.stopTime == null ? (object)DBNull.Value : model.stopTime;
            parameters[17].Value = model.day == null ? (object)DBNull.Value : model.day;
            parameters[18].Value = model.shift == null ? (object)DBNull.Value : model.shift;
            parameters[19].Value = model.status == null ? (object)DBNull.Value : model.status;
            parameters[20].Value = model.matPart01 == null ? (object)DBNull.Value : model.matPart01;
            parameters[21].Value = model.matPart02 == null ? (object)DBNull.Value : model.matPart02;
            parameters[22].Value = model.matLot01 == null ? (object)DBNull.Value : model.matLot01;
            parameters[23].Value = model.matLot02 == null ? (object)DBNull.Value : model.matLot02;
            parameters[24].Value = model.opSign01 == null ? (object)DBNull.Value : model.opSign01;
            parameters[25].Value = model.opSign02 == null ? (object)DBNull.Value : model.opSign02;
            parameters[26].Value = model.opSign03 == null ? (object)DBNull.Value : model.opSign03;
            parameters[27].Value = model.opSign04 == null ? (object)DBNull.Value : model.opSign04;
            parameters[28].Value = model.opSign05 == null ? (object)DBNull.Value : model.opSign05;
            parameters[29].Value = model.opSign06 == null ? (object)DBNull.Value : model.opSign06;
            parameters[30].Value = model.opSign07 == null ? (object)DBNull.Value : model.opSign07;
            parameters[31].Value = model.opSign08 == null ? (object)DBNull.Value : model.opSign08;
            parameters[32].Value = model.opSign09 == null ? (object)DBNull.Value : model.opSign09;
            parameters[33].Value = model.opSign10 == null ? (object)DBNull.Value : model.opSign10;
            parameters[34].Value = model.opSign11 == null ? (object)DBNull.Value : model.opSign11;
            parameters[35].Value = model.opSign12 == null ? (object)DBNull.Value : model.opSign12;
            parameters[36].Value = model.qaSign01 == null ? (object)DBNull.Value : model.qaSign01;
            parameters[37].Value = model.qaSign02 == null ? (object)DBNull.Value : model.qaSign02;
            parameters[38].Value = model.qaSign03 == null ? (object)DBNull.Value : model.qaSign03;
            parameters[39].Value = model.qaSign04 == null ? (object)DBNull.Value : model.qaSign04;
            parameters[40].Value = model.qaSign05 == null ? (object)DBNull.Value : model.qaSign05;
            parameters[41].Value = model.qaSign06 == null ? (object)DBNull.Value : model.qaSign06;
            parameters[42].Value = model.qaSign07 == null ? (object)DBNull.Value : model.qaSign07;
            parameters[43].Value = model.qaSign08 == null ? (object)DBNull.Value : model.qaSign08;
            parameters[44].Value = model.qaSign09 == null ? (object)DBNull.Value : model.qaSign09;
            parameters[45].Value = model.qaSign10 == null ? (object)DBNull.Value : model.qaSign10;
            parameters[46].Value = model.qaSign11 == null ? (object)DBNull.Value : model.qaSign11;
            parameters[47].Value = model.qaSign12 == null ? (object)DBNull.Value : model.qaSign12;
            parameters[48].Value = model.customer == null ? (object)DBNull.Value : model.customer;
            parameters[49].Value = model.lastUpdatedTime == null ? (object)DBNull.Value : model.lastUpdatedTime;
            parameters[50].Value = model.trackingID == null ? (object)DBNull.Value : model.trackingID;
            parameters[51].Value = model.remarks == null ? (object)DBNull.Value : model.remarks;
            parameters[52].Value = model.QCNGQTY == null ? (object)DBNull.Value : model.QCNGQTY;
            parameters[53].Value = model.Material_MHCheck == null ? (object)DBNull.Value : model.Material_MHCheck;
            parameters[54].Value = model.Material_MHCheckTime == null ? (object)DBNull.Value : model.Material_MHCheckTime;
            parameters[55].Value = model.Material_Opcheck == null ? (object)DBNull.Value : model.Material_Opcheck;
            parameters[56].Value = model.Material_OpCheckTime == null ? (object)DBNull.Value : model.Material_OpCheckTime;
            parameters[57].Value = model.Material_LeaderCheck == null ? (object)DBNull.Value : model.Material_LeaderCheck;
            parameters[58].Value = model.Material_LeaderCheckTime == null ? (object)DBNull.Value : model.Material_LeaderCheckTime;
            parameters[59].Value = model.LeaderCheck == null ? (object)DBNull.Value : model.LeaderCheck;
            parameters[60].Value = model.LeaderCheckTime == null ? (object)DBNull.Value : model.LeaderCheckTime;
            parameters[61].Value = model.SupervisorCheck == null ? (object)DBNull.Value : model.SupervisorCheck;
            parameters[62].Value = model.SupervisorCheckTime == null ? (object)DBNull.Value : model.SupervisorCheckTime;
            parameters[63].Value = model.partnumberall == null ? (object)DBNull.Value : model.partnumberall;
            parameters[64].Value = model.parts2Weight == null ? (object)DBNull.Value : model.parts2Weight;
            parameters[65].Value = model.lastQty == null ? (object)DBNull.Value : model.lastQty;
            parameters[66].Value = model.OkAccumulation == null ? (object)DBNull.Value : model.OkAccumulation;
            DBHelp.Reports.LogFile.DebugLog("AUTOCODE", "NameSpace:Common.DAL", "Class:MouldingViTracking_DAL", "Function:		public SqlCommand UpdateCommand(Common.Model.MouldingViTracking_Model model)" + "TableName:MouldingViTracking", ";id = " + (model.id == null ? "" : model.id.ToString()) + ";machineID = " + (model.machineID == null ? "" : model.machineID.ToString()) + ";dateTime = " + (model.dateTime == null ? "" : model.dateTime.ToString()) + ";partNumber = " + (model.partNumber == null ? "" : model.partNumber.ToString()) + ";jigNo = " + (model.jigNo == null ? "" : model.jigNo.ToString()) + ";model = " + (model.model == null ? "" : model.model.ToString()) + ";cavityCount = " + (model.cavityCount == null ? "" : model.cavityCount.ToString()) + ";partsWeight = " + (model.partsWeight == null ? "" : model.partsWeight.ToString()) + ";cycleTime = " + (model.cycleTime == null ? "" : model.cycleTime.ToString()) + ";targetQty = " + (model.targetQty == null ? "" : model.targetQty.ToString()) + ";userName = " + (model.userName == null ? "" : model.userName.ToString()) + ";userID = " + (model.userID == null ? "" : model.userID.ToString()) + ";acountReading = " + (model.acountReading == null ? "" : model.acountReading.ToString()) + ";rejectQty = " + (model.rejectQty == null ? "" : model.rejectQty.ToString()) + ";acceptQty = " + (model.acceptQty == null ? "" : model.acceptQty.ToString()) + ";startTime = " + (model.startTime == null ? "" : model.startTime.ToString()) + ";stopTime = " + (model.stopTime == null ? "" : model.stopTime.ToString()) + ";day = " + (model.day == null ? "" : model.day.ToString()) + ";shift = " + (model.shift == null ? "" : model.shift.ToString()) + ";status = " + (model.status == null ? "" : model.status.ToString()) + ";matPart01 = " + (model.matPart01 == null ? "" : model.matPart01.ToString()) + ";matPart02 = " + (model.matPart02 == null ? "" : model.matPart02.ToString()) + ";matLot01 = " + (model.matLot01 == null ? "" : model.matLot01.ToString()) + ";matLot02 = " + (model.matLot02 == null ? "" : model.matLot02.ToString()) + ";opSign01 = " + (model.opSign01 == null ? "" : model.opSign01.ToString()) + ";opSign02 = " + (model.opSign02 == null ? "" : model.opSign02.ToString()) + ";opSign03 = " + (model.opSign03 == null ? "" : model.opSign03.ToString()) + ";opSign04 = " + (model.opSign04 == null ? "" : model.opSign04.ToString()) + ";opSign05 = " + (model.opSign05 == null ? "" : model.opSign05.ToString()) + ";opSign06 = " + (model.opSign06 == null ? "" : model.opSign06.ToString()) + ";opSign07 = " + (model.opSign07 == null ? "" : model.opSign07.ToString()) + ";opSign08 = " + (model.opSign08 == null ? "" : model.opSign08.ToString()) + ";opSign09 = " + (model.opSign09 == null ? "" : model.opSign09.ToString()) + ";opSign10 = " + (model.opSign10 == null ? "" : model.opSign10.ToString()) + ";opSign11 = " + (model.opSign11 == null ? "" : model.opSign11.ToString()) + ";opSign12 = " + (model.opSign12 == null ? "" : model.opSign12.ToString()) + ";qaSign01 = " + (model.qaSign01 == null ? "" : model.qaSign01.ToString()) + ";qaSign02 = " + (model.qaSign02 == null ? "" : model.qaSign02.ToString()) + ";qaSign03 = " + (model.qaSign03 == null ? "" : model.qaSign03.ToString()) + ";qaSign04 = " + (model.qaSign04 == null ? "" : model.qaSign04.ToString()) + ";qaSign05 = " + (model.qaSign05 == null ? "" : model.qaSign05.ToString()) + ";qaSign06 = " + (model.qaSign06 == null ? "" : model.qaSign06.ToString()) + ";qaSign07 = " + (model.qaSign07 == null ? "" : model.qaSign07.ToString()) + ";qaSign08 = " + (model.qaSign08 == null ? "" : model.qaSign08.ToString()) + ";qaSign09 = " + (model.qaSign09 == null ? "" : model.qaSign09.ToString()) + ";qaSign10 = " + (model.qaSign10 == null ? "" : model.qaSign10.ToString()) + ";qaSign11 = " + (model.qaSign11 == null ? "" : model.qaSign11.ToString()) + ";qaSign12 = " + (model.qaSign12 == null ? "" : model.qaSign12.ToString()) + ";customer = " + (model.customer == null ? "" : model.customer.ToString()) + ";lastUpdatedTime = " + (model.lastUpdatedTime == null ? "" : model.lastUpdatedTime.ToString()) + ";trackingID = " + (model.trackingID == null ? "" : model.trackingID.ToString()) + ";remarks = " + (model.remarks == null ? "" : model.remarks.ToString()) + "");
            return DBHelp.SqlDB.generateCommand(strSql.ToString(), parameters);
        }












        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool Delete(int id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from MouldingViTracking ");
			strSql.Append(" where id=@id");
            SqlParameter[] parameters = {
                    new SqlParameter("@id", SqlDbType.Int,4)
            };
			parameters[0].Value = id;

			 DBHelp.Reports.LogFile.DebugLog("AUTOCODE","NameSpace:Common.DAL" , "Class:MouldingViTracking_DAL" , "Function:		public bool Delete(int id)"  + "TableName:MouldingViTracking" , "");
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
		public bool DeleteList(string idlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from MouldingViTracking ");
			strSql.Append(" where id in ("+idlist + ")  ");
			int rows=DBHelp.SqlDB.ExecuteSql(strSql.ToString());
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
		public SqlCommand DeleteCommand(int id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from MouldingViTracking ");
			strSql.Append(" where id=@id");
			SqlParameter[] parameters = {
					new SqlParameter("@id", SqlDbType.Int,4)
};
			parameters[0].Value = id;

			 DBHelp.Reports.LogFile.DebugLog("AUTOCODE","NameSpace:Common.DAL" , "Class:MouldingViTracking_DAL" , "Function:		public SqlCommand DeleteCommand(int id)"  + "TableName:MouldingViTracking" , "");
			return DBHelp.SqlDB.generateCommand(strSql.ToString(),parameters);
		}
		/// <summary>
		/// 删除一条数据
		/// </summary>
		public SqlCommand DeleteAllCommand( )
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from MouldingViTracking ");
			 DBHelp.Reports.LogFile.DebugLog("AUTOCODE","NameSpace:Common.DAL" , "Class:MouldingViTracking_DAL" , "Function:		public SqlCommand DeleteAllCommand( )"  + "TableName:MouldingViTracking" , "");
			return DBHelp.SqlDB.generateCommand(strSql.ToString(), new SqlParameter[0]);
		}


		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public Common.Model.MouldingViTracking_Model GetModel(int id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 id,machineID,dateTime,partNumber,jigNo,model,cavityCount,partsWeight,cycleTime,targetQty,userName,userID,acountReading,rejectQty,acceptQty,startTime,stopTime,day,shift,status,matPart01,matPart02,matLot01,matLot02,opSign01,opSign02,opSign03,opSign04,opSign05,opSign06,opSign07,opSign08,opSign09,opSign10,opSign11,opSign12,qaSign01,qaSign02,qaSign03,qaSign04,qaSign05,qaSign06,qaSign07,qaSign08,qaSign09,qaSign10,qaSign11,qaSign12,customer,lastUpdatedTime,trackingID,remarks,QCNGQTY,Material_MHCheck,Material_MHCheckTime,Material_Opcheck,Material_OpCheckTime,Material_LeaderCheck,Material_LeaderCheckTime,LeaderCheck,LeaderCheckTime,SupervisorCheck,SupervisorCheckTime,partNumberAll,parts2Weight,lastQty from MouldingViTracking ");
			strSql.Append(" where id=@id");
			SqlParameter[] parameters = {
					new SqlParameter("@id", SqlDbType.Int,4)
};
			parameters[0].Value = id;

			 DBHelp.Reports.LogFile.DebugLog("AUTOCODE","NameSpace:Common.DAL" , "Class:MouldingViTracking_DAL" , "Function:		public Common.Model.MouldingViTracking_Model GetModel(int id)"  + "TableName:MouldingViTracking" , "");
			Common.Model.MouldingViTracking_Model model=new Common.Model.MouldingViTracking_Model();
			DataSet ds=DBHelp.SqlDB.Query(strSql.ToString(),parameters);
			if(ds.Tables[0].Rows.Count>0)
			{
				if(ds.Tables[0].Rows[0]["id"].ToString()!="")
				{
					model.id=int.Parse(ds.Tables[0].Rows[0]["id"].ToString());
				}
				model.machineID=ds.Tables[0].Rows[0]["machineID"].ToString();
				if(ds.Tables[0].Rows[0]["dateTime"].ToString()!="")
				{
					model.dateTime=DateTime.Parse(ds.Tables[0].Rows[0]["dateTime"].ToString());
				}
				model.partNumber=ds.Tables[0].Rows[0]["partNumber"].ToString();
				model.jigNo=ds.Tables[0].Rows[0]["jigNo"].ToString();
				model.model=ds.Tables[0].Rows[0]["model"].ToString();
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
				if(ds.Tables[0].Rows[0]["targetQty"].ToString()!="")
				{
					model.targetQty=decimal.Parse(ds.Tables[0].Rows[0]["targetQty"].ToString());
				}
				model.userName=ds.Tables[0].Rows[0]["userName"].ToString();
				model.userID=ds.Tables[0].Rows[0]["userID"].ToString();
				if(ds.Tables[0].Rows[0]["acountReading"].ToString()!="")
				{
					model.acountReading=decimal.Parse(ds.Tables[0].Rows[0]["acountReading"].ToString());
				}
				if(ds.Tables[0].Rows[0]["rejectQty"].ToString()!="")
				{
					model.rejectQty=decimal.Parse(ds.Tables[0].Rows[0]["rejectQty"].ToString());
				}
                if (ds.Tables[0].Rows[0]["QCNGQTY"].ToString() != "")
                {
                    model.QCNGQTY = decimal.Parse(ds.Tables[0].Rows[0]["QCNGQTY"].ToString());
                }
                if (ds.Tables[0].Rows[0]["acceptQty"].ToString()!="")
				{
					model.acceptQty=decimal.Parse(ds.Tables[0].Rows[0]["acceptQty"].ToString());
				}
				if(ds.Tables[0].Rows[0]["startTime"].ToString()!="")
				{
					model.startTime=DateTime.Parse(ds.Tables[0].Rows[0]["startTime"].ToString());
				}
				if(ds.Tables[0].Rows[0]["stopTime"].ToString()!="")
				{
					model.stopTime=DateTime.Parse(ds.Tables[0].Rows[0]["stopTime"].ToString());
				}
				if(ds.Tables[0].Rows[0]["day"].ToString()!="")
				{
					model.day=DateTime.Parse(ds.Tables[0].Rows[0]["day"].ToString());
				}
				model.shift=ds.Tables[0].Rows[0]["shift"].ToString();
				model.status=ds.Tables[0].Rows[0]["status"].ToString();
				model.matPart01=ds.Tables[0].Rows[0]["matPart01"].ToString();
				model.matPart02=ds.Tables[0].Rows[0]["matPart02"].ToString();
				model.matLot01=ds.Tables[0].Rows[0]["matLot01"].ToString();
				model.matLot02=ds.Tables[0].Rows[0]["matLot02"].ToString();
				model.opSign01=ds.Tables[0].Rows[0]["opSign01"].ToString();
				model.opSign02=ds.Tables[0].Rows[0]["opSign02"].ToString();
				model.opSign03=ds.Tables[0].Rows[0]["opSign03"].ToString();
				model.opSign04=ds.Tables[0].Rows[0]["opSign04"].ToString();
				model.opSign05=ds.Tables[0].Rows[0]["opSign05"].ToString();
				model.opSign06=ds.Tables[0].Rows[0]["opSign06"].ToString();
				model.opSign07=ds.Tables[0].Rows[0]["opSign07"].ToString();
				model.opSign08=ds.Tables[0].Rows[0]["opSign08"].ToString();
				model.opSign09=ds.Tables[0].Rows[0]["opSign09"].ToString();
				model.opSign10=ds.Tables[0].Rows[0]["opSign10"].ToString();
				model.opSign11=ds.Tables[0].Rows[0]["opSign11"].ToString();
				model.opSign12=ds.Tables[0].Rows[0]["opSign12"].ToString();
				model.qaSign01=ds.Tables[0].Rows[0]["qaSign01"].ToString();
				model.qaSign02=ds.Tables[0].Rows[0]["qaSign02"].ToString();
				model.qaSign03=ds.Tables[0].Rows[0]["qaSign03"].ToString();
				model.qaSign04=ds.Tables[0].Rows[0]["qaSign04"].ToString();
				model.qaSign05=ds.Tables[0].Rows[0]["qaSign05"].ToString();
				model.qaSign06=ds.Tables[0].Rows[0]["qaSign06"].ToString();
				model.qaSign07=ds.Tables[0].Rows[0]["qaSign07"].ToString();
				model.qaSign08=ds.Tables[0].Rows[0]["qaSign08"].ToString();
				model.qaSign09=ds.Tables[0].Rows[0]["qaSign09"].ToString();
				model.qaSign10=ds.Tables[0].Rows[0]["qaSign10"].ToString();
				model.qaSign11=ds.Tables[0].Rows[0]["qaSign11"].ToString();
				model.qaSign12=ds.Tables[0].Rows[0]["qaSign12"].ToString();
				model.customer=ds.Tables[0].Rows[0]["customer"].ToString();
				if(ds.Tables[0].Rows[0]["lastUpdatedTime"].ToString()!="")
				{
					model.lastUpdatedTime=DateTime.Parse(ds.Tables[0].Rows[0]["lastUpdatedTime"].ToString());
				}
				model.trackingID=ds.Tables[0].Rows[0]["trackingID"].ToString();
				model.remarks=ds.Tables[0].Rows[0]["remarks"].ToString();
                model.Material_MHCheck = ds.Tables[0].Rows[0]["Material_MHCheck"].ToString();
                if (ds.Tables[0].Rows[0]["Material_MHCheckTime"].ToString() != "")
                {
                    model.Material_MHCheckTime = DateTime.Parse(ds.Tables[0].Rows[0]["Material_MHCheckTime"].ToString());
                }
                model.Material_Opcheck = ds.Tables[0].Rows[0]["Material_Opcheck"].ToString();
                if (ds.Tables[0].Rows[0]["Material_OpCheckTime"].ToString() != "")
                {
                    model.Material_OpCheckTime = DateTime.Parse(ds.Tables[0].Rows[0]["Material_OpCheckTime"].ToString());
                }
                model.Material_LeaderCheck = ds.Tables[0].Rows[0]["Material_LeaderCheck"].ToString();
                if (ds.Tables[0].Rows[0]["Material_LeaderCheckTime"].ToString() != "")
                {
                    model.Material_LeaderCheckTime = DateTime.Parse(ds.Tables[0].Rows[0]["Material_LeaderCheckTime"].ToString());
                }
                model.LeaderCheck = ds.Tables[0].Rows[0]["LeaderCheck"].ToString();
                if (ds.Tables[0].Rows[0]["LeaderCheckTime"].ToString() != "")
                {
                    model.LeaderCheckTime = DateTime.Parse(ds.Tables[0].Rows[0]["LeaderCheckTime"].ToString());
                }
                model.SupervisorCheck = ds.Tables[0].Rows[0]["SupervisorCheck"].ToString();
                if (ds.Tables[0].Rows[0]["SupervisorCheckTime"].ToString() != "")
                {
                    model.SupervisorCheckTime = DateTime.Parse(ds.Tables[0].Rows[0]["SupervisorCheckTime"].ToString());
                }
                model.SupervisorCheck = ds.Tables[0].Rows[0]["partNumberAll"].ToString();
                if (ds.Tables[0].Rows[0]["parts2Weight"].ToString() != "")
                {
                    model.parts2Weight = decimal.Parse(ds.Tables[0].Rows[0]["parts2Weight"].ToString());
                }
                if (ds.Tables[0].Rows[0]["lastQty"].ToString() != "")
                {
                    model.lastQty = decimal.Parse(ds.Tables[0].Rows[0]["lastQty"].ToString());
                }
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
			strSql.Append("select id,machineID,dateTime,partNumber,jigNo,model,cavityCount,partsWeight,cycleTime,targetQty,userName,userID,isnull(acountReading,0) as acountReading,rejectQty,isnull(acceptQty,0) as acceptQty,startTime,stopTime,day,shift,status,matPart01,matPart02,matLot01,matLot02,opSign01,opSign02,opSign03,opSign04,opSign05,opSign06,opSign07,opSign08,opSign09,opSign10,opSign11,opSign12,qaSign01,qaSign02,qaSign03,qaSign04,qaSign05,qaSign06,qaSign07,qaSign08,qaSign09,qaSign10,qaSign11,qaSign12,customer,lastUpdatedTime,trackingID,remarks,QCNGQTY,Material_MHCheck,Material_MHCheckTime,Material_Opcheck,Material_OpCheckTime,Material_LeaderCheck,Material_LeaderCheckTime,LeaderCheck,LeaderCheckTime,SupervisorCheck,SupervisorCheckTime,partNumberAll,parts2Weight,isnull(lastQty,0) as lastQty,OkAccumulation ");
			strSql.Append(" FROM MouldingViTracking ");
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
			strSql.Append(" id,machineID,dateTime,partNumber,jigNo,model,cavityCount,partsWeight,cycleTime,targetQty,userName,userID,acountReading,rejectQty,acceptQty,startTime,stopTime,day,shift,status,matPart01,matPart02,matLot01,matLot02,opSign01,opSign02,opSign03,opSign04,opSign05,opSign06,opSign07,opSign08,opSign09,opSign10,opSign11,opSign12,qaSign01,qaSign02,qaSign03,qaSign04,qaSign05,qaSign06,qaSign07,qaSign08,qaSign09,qaSign10,qaSign11,qaSign12,customer,lastUpdatedTime,trackingID,remarks,QCNGQTY,Material_MHCheck,Material_MHCheckTime,Material_Opcheck,Material_OpCheckTime,Material_LeaderCheck,Material_LeaderCheckTime,LeaderCheck,LeaderCheckTime,SupervisorCheck,SupervisorCheckTime,partNumberAll,parts2Weight,lastQty,OkAccumulation ");
			strSql.Append(" FROM MouldingViTracking ");
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
			parameters[0].Value = "MouldingViTracking";
			parameters[1].Value = "";
			parameters[2].Value = PageSize;
			parameters[3].Value = PageIndex;
			parameters[4].Value = 0;
			parameters[5].Value = 0;
			parameters[6].Value = strWhere;	
			return DBHelp.SqlDB.RunProcedure("UP_GetRecordByPage",parameters,"ds");
		}*/

        #endregion  Method

        #region MyRegion
        internal DataSet GetModel_ByDayShiftPartMachine(DateTime curDay, string curShift, string partNumber, string machineID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 id,machineID,dateTime,partNumber,jigNo,model,cavityCount,partsWeight,cycleTime,targetQty,userName,userID,acountReading,rejectQty,acceptQty,startTime,stopTime,day,shift,status,matPart01,matPart02,matLot01,matLot02,opSign01,opSign02,opSign03,opSign04,opSign05,opSign06,opSign07,opSign08,opSign09,opSign10,opSign11,opSign12,qaSign01,qaSign02,qaSign03,qaSign04,qaSign05,qaSign06,qaSign07,qaSign08,qaSign09,qaSign10,qaSign11,qaSign12,customer,lastUpdatedTime,trackingID,remarks,QCNGQTY,Material_MHCheck,Material_MHCheckTime,Material_Opcheck,Material_OpCheckTime,Material_LeaderCheck,Material_LeaderCheckTime,LeaderCheck,LeaderCheckTime,SupervisorCheck,SupervisorCheckTime,partNumberAll,parts2Weight,lastQty,OkAccumulation from MouldingViTracking ");
            strSql.Append(" where Day=@Day and Shift=@hift and PartNumber = @PartNumber and MachineID = @MachineID");
            //2018 12 04 same data just status different
            strSql.Append(" order by dateTime desc  ");

            SqlParameter[] parameters = {
                    new SqlParameter("@Day", SqlDbType.DateTime),
                    new SqlParameter("@hift", SqlDbType.VarChar, -1),
                    new SqlParameter("@PartNumber", SqlDbType.VarChar , -1 ),
                    new SqlParameter("@MachineID", SqlDbType.VarChar , -1 ),
            };
            parameters[0].Value = curDay;
            parameters[1].Value = curShift;
            parameters[2].Value = partNumber;
            parameters[3].Value = machineID;

            DBHelp.Reports.LogFile.DebugLog("AUTOCODE", "NameSpace:Common.DAL", "Class:MouldingViTracking_DAL", "Function:		public DataSet GetModel_ByDayShiftPart(DateTime curDay, string curShift, string partNumber , string machineID)" + "TableName:MouldingViTracking", "");
            Common.Model.MouldingViTracking_Model model = new Common.Model.MouldingViTracking_Model();
            DataSet ds = DBHelp.SqlDB.Query(strSql.ToString(), parameters);

            return ds;

        }

        internal DataSet GetModel_ByDayShiftAllPartMachine(DateTime curDay, string curShift, string AllpartNumber, string machineID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select top 1  id,machineID,dateTime,partNumber,jigNo,model,cavityCount,partsWeight,cycleTime,targetQty,userName,userID,isnull(acountReading,0) as acountReading,rejectQty,isnull(acceptQty,0) as acceptQty,startTime,stopTime,day,shift,status,matPart01,matPart02,matLot01,matLot02,opSign01,opSign02,opSign03,opSign04,opSign05,opSign06,opSign07,opSign08,opSign09,opSign10,opSign11,opSign12,qaSign01,qaSign02,qaSign03,qaSign04,qaSign05,qaSign06,qaSign07,qaSign08,qaSign09,qaSign10,qaSign11,qaSign12,customer,lastUpdatedTime,trackingID,remarks,QCNGQTY,Material_MHCheck,Material_MHCheckTime,Material_Opcheck,Material_OpCheckTime,Material_LeaderCheck,Material_LeaderCheckTime,LeaderCheck,LeaderCheckTime,SupervisorCheck,SupervisorCheckTime,partNumberAll,parts2Weight,isnull(lastQty,0) as lastQty,OkAccumulation from MouldingViTracking ");
            strSql.Append(" where Day=@Day and Shift=@hift and partNumber = @partNumber and MachineID = @MachineID");
            //2018 12 04 same data just status different
            strSql.Append(" order by dateTime desc  ");

            SqlParameter[] parameters = {
                    new SqlParameter("@Day", SqlDbType.DateTime),
                    new SqlParameter("@hift", SqlDbType.VarChar, -1),
                    new SqlParameter("@PartNumber", SqlDbType.VarChar , -1 ),
                    new SqlParameter("@MachineID", SqlDbType.VarChar , -1 ),
            };
            parameters[0].Value = curDay;
            parameters[1].Value = curShift;
            parameters[2].Value = AllpartNumber;
            parameters[3].Value = machineID;

            DBHelp.Reports.LogFile.DebugLog("AUTOCODE", "NameSpace:Common.DAL", "Class:MouldingViTracking_DAL", "Function:		public DataSet GetModel_ByDayShiftPart(DateTime curDay, string curShift, string partNumber , string machineID)" + "TableName:MouldingViTracking", "");
            Common.Model.MouldingViTracking_Model model = new Common.Model.MouldingViTracking_Model();
            DataSet ds = DBHelp.SqlDB.Query(strSql.ToString(), parameters);

            return ds;

        }

        internal DataSet GetModel_ByMachine(string machineID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 id,machineID,dateTime,partNumber,jigNo,model,cavityCount,partsWeight,cycleTime,targetQty,userName,userID,acountReading,rejectQty,acceptQty,startTime,stopTime,day,shift,status,matPart01,matPart02,matLot01,matLot02,opSign01,opSign02,opSign03,opSign04,opSign05,opSign06,opSign07,opSign08,opSign09,opSign10,opSign11,opSign12,qaSign01,qaSign02,qaSign03,qaSign04,qaSign05,qaSign06,qaSign07,qaSign08,qaSign09,qaSign10,qaSign11,qaSign12,customer,lastUpdatedTime,trackingID,remarks,QCNGQTY,Material_MHCheck,Material_MHCheckTime,Material_Opcheck,Material_OpCheckTime,Material_LeaderCheck,Material_LeaderCheckTime,LeaderCheck,LeaderCheckTime,SupervisorCheck,SupervisorCheckTime,partNumberAll,parts2Weight,lastQty,OkAccumulation from MouldingViTracking ");
            strSql.Append(" where  MachineID = @MachineID order by lastUpdatedTime desc");
            SqlParameter[] parameters = {
                    new SqlParameter("@MachineID", SqlDbType.VarChar , -1 ),
            };
            parameters[0].Value = machineID;

            DBHelp.Reports.LogFile.DebugLog("AUTOCODE", "NameSpace:Common.DAL", "Class:MouldingViTracking_DAL", "Function:		public DataSet GetModel_ByDayShiftPart(DateTime curDay, string curShift, string partNumber , string machineID)" + "TableName:MouldingViTracking", "");
            Common.Model.MouldingViTracking_Model model = new Common.Model.MouldingViTracking_Model();
            DataSet ds = DBHelp.SqlDB.Query(strSql.ToString(), parameters);

            return ds;

        }

        internal DataSet GetModel_ByDayShiftAllPartMachine_old(DateTime curDay, string curShift, string AllpartNumber, string machineID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 id,machineID,dateTime,partNumber,jigNo,model,cavityCount,partsWeight,cycleTime,targetQty,userName,userID,acountReading,rejectQty,acceptQty,startTime,stopTime,day,shift,status,matPart01,matPart02,matLot01,matLot02,opSign01,opSign02,opSign03,opSign04,opSign05,opSign06,opSign07,opSign08,opSign09,opSign10,opSign11,opSign12,qaSign01,qaSign02,qaSign03,qaSign04,qaSign05,qaSign06,qaSign07,qaSign08,qaSign09,qaSign10,qaSign11,qaSign12,customer,lastUpdatedTime,trackingID,remarks,QCNGQTY,Material_MHCheck,Material_MHCheckTime,Material_Opcheck,Material_OpCheckTime,Material_LeaderCheck,Material_LeaderCheckTime,LeaderCheck,LeaderCheckTime,SupervisorCheck,SupervisorCheckTime,partNumberAll,parts2Weight,lastQty,OkAccumulation from MouldingViTracking ");
            strSql.Append(" where Day=@Day and Shift=@hift and PartNumber = @PartNumber and MachineID = @MachineID");
            SqlParameter[] parameters = {
                    new SqlParameter("@Day", SqlDbType.DateTime),
                    new SqlParameter("@hift", SqlDbType.VarChar, -1),
                    new SqlParameter("@PartNumber", SqlDbType.VarChar , -1 ),
                    new SqlParameter("@MachineID", SqlDbType.VarChar , -1 ),
            };
            parameters[0].Value = curDay;
            parameters[1].Value = curShift;
            parameters[2].Value = AllpartNumber;
            parameters[3].Value = machineID;

            DBHelp.Reports.LogFile.DebugLog("AUTOCODE", "NameSpace:Common.DAL", "Class:MouldingViTracking_DAL", "Function:		public DataSet GetModel_ByDayShiftPart(DateTime curDay, string curShift, string partNumber , string machineID)" + "TableName:MouldingViTracking", "");
            Common.Model.MouldingViTracking_Model model = new Common.Model.MouldingViTracking_Model();
            DataSet ds = DBHelp.SqlDB.Query(strSql.ToString(), parameters);

            return ds;

        }

        #endregion
    }
}


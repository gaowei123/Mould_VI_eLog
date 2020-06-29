
using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using DBHelp;
using Common.Model;

namespace Common.DAL
{
	/// <summary>
	/// 数据访问类:MouldingViDefectTracking_DAL
	/// </summary>
	public class MouldingViDefectTracking_DAL
	{
		public MouldingViDefectTracking_DAL()
		{}
		#region  Method



		/// <summary>
		/// 增加一条数据
		/// </summary>
		public void Add(Common.Model.MouldingViDefectTracking_Model model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into MouldingViDefectTracking(");
			strSql.Append("id,trackingID,machineID,dateTime,partNumber,jigNo,model,cavityCount,userName,userID,startTime,stopTime,day,shift,status,matPart01,matPart02,matLot01,matLot02,defectCodeID,defectCode,rejectQty,rejectQtyHour01,rejectQtyHour02,rejectQtyHour03,rejectQtyHour04,rejectQtyHour05,rejectQtyHour06,rejectQtyHour07,rejectQtyHour08,rejectQtyHour09,rejectQtyHour10,rejectQtyHour11,rejectQtyHour12,lastUpdatedTime,remarks,QCNGQTY,Material_MHCheck,Material_MHCheckTime,Material_Opcheck,Material_OpCheckTime,Material_LeaderCheck,Material_LeaderCheckTime,LeaderCheck,LeaderCheckTime,SupervisorCheck,SupervisorCheckTime,partNumberAll)");
			strSql.Append(" values (");
			strSql.Append("@id,@trackingID,@machineID,@dateTime,@partNumber,@jigNo,@model,@cavityCount,@userName,@userID,@startTime,@stopTime,@day,@shift,@status,@matPart01,@matPart02,@matLot01,@matLot02,@defectCodeID,@defectCode,@rejectQty,@rejectQtyHour01,@rejectQtyHour02,@rejectQtyHour03,@rejectQtyHour04,@rejectQtyHour05,@rejectQtyHour06,@rejectQtyHour07,@rejectQtyHour08,@rejectQtyHour09,@rejectQtyHour10,@rejectQtyHour11,@rejectQtyHour12,@lastUpdatedTime,@remarks,@QCNGQTY,@Material_MHCheck,@Material_MHCheckTime,@Material_Opcheck,@Material_OpCheckTime,@Material_LeaderCheck,@Material_LeaderCheckTime,@LeaderCheck,@LeaderCheckTime,@SupervisorCheck,@SupervisorCheckTime,@partNumberAll)");
			SqlParameter[] parameters = {
					new SqlParameter("@id", SqlDbType.Int,4),
					new SqlParameter("@trackingID", SqlDbType.VarChar,50),
					new SqlParameter("@machineID", SqlDbType.VarChar,8),
					new SqlParameter("@dateTime", SqlDbType.DateTime2,8),
					new SqlParameter("@partNumber", SqlDbType.VarChar,50),
					new SqlParameter("@jigNo", SqlDbType.VarChar,50),
					new SqlParameter("@model", SqlDbType.VarChar,50),
					new SqlParameter("@cavityCount", SqlDbType.Decimal,9),
					new SqlParameter("@userName", SqlDbType.VarChar,50),
					new SqlParameter("@userID", SqlDbType.VarChar,50),
					new SqlParameter("@startTime", SqlDbType.DateTime2,8),
					new SqlParameter("@stopTime", SqlDbType.DateTime2,8),
					new SqlParameter("@day", SqlDbType.DateTime2,8),
					new SqlParameter("@shift", SqlDbType.VarChar,50),
					new SqlParameter("@status", SqlDbType.VarChar,50),
					new SqlParameter("@matPart01", SqlDbType.VarChar,50),
					new SqlParameter("@matPart02", SqlDbType.VarChar,50),
					new SqlParameter("@matLot01", SqlDbType.VarChar,50),
					new SqlParameter("@matLot02", SqlDbType.VarChar,50),
					new SqlParameter("@defectCodeID", SqlDbType.VarChar,50),
					new SqlParameter("@defectCode", SqlDbType.VarChar,50),
					new SqlParameter("@rejectQty", SqlDbType.Decimal,9),
					new SqlParameter("@rejectQtyHour01", SqlDbType.VarChar,50),
					new SqlParameter("@rejectQtyHour02", SqlDbType.VarChar,50),
					new SqlParameter("@rejectQtyHour03", SqlDbType.VarChar,50),
					new SqlParameter("@rejectQtyHour04", SqlDbType.VarChar,50),
					new SqlParameter("@rejectQtyHour05", SqlDbType.VarChar,50),
					new SqlParameter("@rejectQtyHour06", SqlDbType.VarChar,50),
					new SqlParameter("@rejectQtyHour07", SqlDbType.VarChar,50),
					new SqlParameter("@rejectQtyHour08", SqlDbType.VarChar,50),
					new SqlParameter("@rejectQtyHour09", SqlDbType.VarChar,50),
					new SqlParameter("@rejectQtyHour10", SqlDbType.VarChar,50),
					new SqlParameter("@rejectQtyHour11", SqlDbType.VarChar,50),
					new SqlParameter("@rejectQtyHour12", SqlDbType.VarChar,50),
					new SqlParameter("@lastUpdatedTime", SqlDbType.DateTime2,8),
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
                    new SqlParameter("@partNumberAll", SqlDbType.VarChar,500)};
            DBHelp.Reports.LogFile.DebugLog("AUTOCODE","NameSpace:Common.DAL" , "Class:MouldingViDefectTracking_DAL" , "Function:		public void Add(Common.Model.MouldingViDefectTracking_Model model)"  + "TableName:MouldingViDefectTracking" , ";id = "+ (model.id == null ? "" : model.id.ToString() ) + ";trackingID = "+ (model.trackingID == null ? "" : model.trackingID.ToString() ) + ";machineID = "+ (model.machineID == null ? "" : model.machineID.ToString() ) + ";dateTime = "+ (model.dateTime == null ? "" : model.dateTime.ToString() ) + ";partNumber = "+ (model.partNumber == null ? "" : model.partNumber.ToString() ) + ";jigNo = "+ (model.jigNo == null ? "" : model.jigNo.ToString() ) + ";model = "+ (model.model == null ? "" : model.model.ToString() ) + ";cavityCount = "+ (model.cavityCount == null ? "" : model.cavityCount.ToString() ) + ";userName = "+ (model.userName == null ? "" : model.userName.ToString() ) + ";userID = "+ (model.userID == null ? "" : model.userID.ToString() ) + ";startTime = "+ (model.startTime == null ? "" : model.startTime.ToString() ) + ";stopTime = "+ (model.stopTime == null ? "" : model.stopTime.ToString() ) + ";day = "+ (model.day == null ? "" : model.day.ToString() ) + ";shift = "+ (model.shift == null ? "" : model.shift.ToString() ) + ";status = "+ (model.status == null ? "" : model.status.ToString() ) + ";matPart01 = "+ (model.matPart01 == null ? "" : model.matPart01.ToString() ) + ";matPart02 = "+ (model.matPart02 == null ? "" : model.matPart02.ToString() ) + ";matLot01 = "+ (model.matLot01 == null ? "" : model.matLot01.ToString() ) + ";matLot02 = "+ (model.matLot02 == null ? "" : model.matLot02.ToString() ) + ";defectCodeID = "+ (model.defectCodeID == null ? "" : model.defectCodeID.ToString() ) + ";defectCode = "+ (model.defectCode == null ? "" : model.defectCode.ToString() ) + ";rejectQty = "+ (model.rejectQty == null ? "" : model.rejectQty.ToString() ) + ";rejectQtyHour01 = "+ (model.rejectQtyHour01 == null ? "" : model.rejectQtyHour01.ToString() ) + ";rejectQtyHour02 = "+ (model.rejectQtyHour02 == null ? "" : model.rejectQtyHour02.ToString() ) + ";rejectQtyHour03 = "+ (model.rejectQtyHour03 == null ? "" : model.rejectQtyHour03.ToString() ) + ";rejectQtyHour04 = "+ (model.rejectQtyHour04 == null ? "" : model.rejectQtyHour04.ToString() ) + ";rejectQtyHour05 = "+ (model.rejectQtyHour05 == null ? "" : model.rejectQtyHour05.ToString() ) + ";rejectQtyHour06 = "+ (model.rejectQtyHour06 == null ? "" : model.rejectQtyHour06.ToString() ) + ";rejectQtyHour07 = "+ (model.rejectQtyHour07 == null ? "" : model.rejectQtyHour07.ToString() ) + ";rejectQtyHour08 = "+ (model.rejectQtyHour08 == null ? "" : model.rejectQtyHour08.ToString() ) + ";rejectQtyHour09 = "+ (model.rejectQtyHour09 == null ? "" : model.rejectQtyHour09.ToString() ) + ";rejectQtyHour10 = "+ (model.rejectQtyHour10 == null ? "" : model.rejectQtyHour10.ToString() ) + ";rejectQtyHour11 = "+ (model.rejectQtyHour11 == null ? "" : model.rejectQtyHour11.ToString() ) + ";rejectQtyHour12 = "+ (model.rejectQtyHour12 == null ? "" : model.rejectQtyHour12.ToString() ) + ";lastUpdatedTime = "+ (model.lastUpdatedTime == null ? "" : model.lastUpdatedTime.ToString() ) + ";remarks = "+ (model.remarks == null ? "" : model.remarks.ToString() ) + "");
			parameters[0].Value = model.id == null ? (object)DBNull.Value : model.id ;
			parameters[1].Value = model.trackingID == null ? (object)DBNull.Value : model.trackingID ;
			parameters[2].Value = model.machineID == null ? (object)DBNull.Value : model.machineID ;
			parameters[3].Value = model.dateTime == null ? (object)DBNull.Value : model.dateTime ;
			parameters[4].Value = model.partNumber == null ? (object)DBNull.Value : model.partNumber ;
			parameters[5].Value = model.jigNo == null ? (object)DBNull.Value : model.jigNo ;
			parameters[6].Value = model.model == null ? (object)DBNull.Value : model.model ;
			parameters[7].Value = model.cavityCount == null ? (object)DBNull.Value : model.cavityCount ;
			parameters[8].Value = model.userName == null ? (object)DBNull.Value : model.userName ;
			parameters[9].Value = model.userID == null ? (object)DBNull.Value : model.userID ;
			parameters[10].Value = model.startTime == null ? (object)DBNull.Value : model.startTime ;
			parameters[11].Value = model.stopTime == null ? (object)DBNull.Value : model.stopTime ;
			parameters[12].Value = model.day == null ? (object)DBNull.Value : model.day ;
			parameters[13].Value = model.shift == null ? (object)DBNull.Value : model.shift ;
			parameters[14].Value = model.status == null ? (object)DBNull.Value : model.status ;
			parameters[15].Value = model.matPart01 == null ? (object)DBNull.Value : model.matPart01 ;
			parameters[16].Value = model.matPart02 == null ? (object)DBNull.Value : model.matPart02 ;
			parameters[17].Value = model.matLot01 == null ? (object)DBNull.Value : model.matLot01 ;
			parameters[18].Value = model.matLot02 == null ? (object)DBNull.Value : model.matLot02 ;
			parameters[19].Value = model.defectCodeID == null ? (object)DBNull.Value : model.defectCodeID ;
			parameters[20].Value = model.defectCode == null ? (object)DBNull.Value : model.defectCode ;
			parameters[21].Value = model.rejectQty == null ? (object)DBNull.Value : model.rejectQty ;
			parameters[22].Value = model.rejectQtyHour01 == null ? (object)DBNull.Value : model.rejectQtyHour01 ;
			parameters[23].Value = model.rejectQtyHour02 == null ? (object)DBNull.Value : model.rejectQtyHour02 ;
			parameters[24].Value = model.rejectQtyHour03 == null ? (object)DBNull.Value : model.rejectQtyHour03 ;
			parameters[25].Value = model.rejectQtyHour04 == null ? (object)DBNull.Value : model.rejectQtyHour04 ;
			parameters[26].Value = model.rejectQtyHour05 == null ? (object)DBNull.Value : model.rejectQtyHour05 ;
			parameters[27].Value = model.rejectQtyHour06 == null ? (object)DBNull.Value : model.rejectQtyHour06 ;
			parameters[28].Value = model.rejectQtyHour07 == null ? (object)DBNull.Value : model.rejectQtyHour07 ;
			parameters[29].Value = model.rejectQtyHour08 == null ? (object)DBNull.Value : model.rejectQtyHour08 ;
			parameters[30].Value = model.rejectQtyHour09 == null ? (object)DBNull.Value : model.rejectQtyHour09 ;
			parameters[31].Value = model.rejectQtyHour10 == null ? (object)DBNull.Value : model.rejectQtyHour10 ;
			parameters[32].Value = model.rejectQtyHour11 == null ? (object)DBNull.Value : model.rejectQtyHour11 ;
			parameters[33].Value = model.rejectQtyHour12 == null ? (object)DBNull.Value : model.rejectQtyHour12 ;
			parameters[34].Value = model.lastUpdatedTime == null ? (object)DBNull.Value : model.lastUpdatedTime ;
			parameters[35].Value = model.remarks == null ? (object)DBNull.Value : model.remarks ;
            parameters[36].Value = model.QCNGQTY == null ? (object)DBNull.Value : model.QCNGQTY;
            parameters[37].Value = model.Material_MHCheck == null ? (object)DBNull.Value : model.Material_MHCheck;
            parameters[38].Value = model.Material_MHCheckTime == null ? (object)DBNull.Value : model.Material_MHCheckTime;
            parameters[39].Value = model.Material_Opcheck == null ? (object)DBNull.Value : model.Material_Opcheck;
            parameters[40].Value = model.Material_OpCheckTime == null ? (object)DBNull.Value : model.Material_OpCheckTime;
            parameters[41].Value = model.Material_LeaderCheck == null ? (object)DBNull.Value : model.Material_LeaderCheck;
            parameters[42].Value = model.Material_LeaderCheckTime == null ? (object)DBNull.Value : model.Material_LeaderCheckTime;
            parameters[43].Value = model.LeaderCheck == null ? (object)DBNull.Value : model.LeaderCheck;
            parameters[44].Value = model.LeaderCheckTime == null ? (object)DBNull.Value : model.LeaderCheckTime;
            parameters[45].Value = model.SupervisorCheck == null ? (object)DBNull.Value : model.SupervisorCheck;
            parameters[46].Value = model.SupervisorCheckTime == null ? (object)DBNull.Value : model.SupervisorCheckTime;
            parameters[47].Value = model.partnumberall == null ? (object)DBNull.Value : model.partnumberall;

            DBHelp.SqlDB.ExecuteSql(strSql.ToString(),parameters);
		}
        public bool Update(Common.Model.MouldingViDefectTracking_Model model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update MouldingViDefectTracking set ");
            strSql.Append("id=@id,");
            //strSql.Append("trackingID=@trackingID,");
            strSql.Append("machineID=@machineID,");
            strSql.Append("dateTime=@dateTime,");
            strSql.Append("partNumber=@partNumber,");
            strSql.Append("jigNo=@jigNo,");
            strSql.Append("model=@model,");
            strSql.Append("cavityCount=@cavityCount,");
            strSql.Append("userName=@userName,");
            strSql.Append("userID=@userID,");
            strSql.Append("startTime=@startTime,");
            strSql.Append("stopTime=@stopTime,");
            strSql.Append("day=@day,");
            strSql.Append("shift=@shift,");
            strSql.Append("status=@status,");
            strSql.Append("matPart01=@matPart01,");
            strSql.Append("matPart02=@matPart02,");
            strSql.Append("matLot01=@matLot01,");
            strSql.Append("matLot02=@matLot02,");
            strSql.Append("defectCodeID=@defectCodeID,");
            strSql.Append("defectCode=@defectCode,");
            strSql.Append("rejectQty=@rejectQty,");
            strSql.Append("rejectQtyHour01=@rejectQtyHour01,");
            strSql.Append("rejectQtyHour02=@rejectQtyHour02,");
            strSql.Append("rejectQtyHour03=@rejectQtyHour03,");
            strSql.Append("rejectQtyHour04=@rejectQtyHour04,");
            strSql.Append("rejectQtyHour05=@rejectQtyHour05,");
            strSql.Append("rejectQtyHour06=@rejectQtyHour06,");
            strSql.Append("rejectQtyHour07=@rejectQtyHour07,");
            strSql.Append("rejectQtyHour08=@rejectQtyHour08,");
            strSql.Append("rejectQtyHour09=@rejectQtyHour09,");
            strSql.Append("rejectQtyHour10=@rejectQtyHour10,");
            strSql.Append("rejectQtyHour11=@rejectQtyHour11,");
            strSql.Append("rejectQtyHour12=@rejectQtyHour12,");
            strSql.Append("lastUpdatedTime=@lastUpdatedTime,");
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
            strSql.Append("partNumberAll=@partNumberAll");
            strSql.Append(" where  trackingID = @trackingID ");
            SqlParameter[] parameters = {
                    new SqlParameter("@id", SqlDbType.Int,4),
                    new SqlParameter("@trackingID", SqlDbType.VarChar,50),
                    new SqlParameter("@machineID", SqlDbType.VarChar,8),
                    new SqlParameter("@dateTime", SqlDbType.DateTime2,8),
                    new SqlParameter("@partNumber", SqlDbType.VarChar,50),
                    new SqlParameter("@jigNo", SqlDbType.VarChar,50),
                    new SqlParameter("@model", SqlDbType.VarChar,50),
                    new SqlParameter("@cavityCount", SqlDbType.Decimal,9),
                    new SqlParameter("@userName", SqlDbType.VarChar,50),
                    new SqlParameter("@userID", SqlDbType.VarChar,50),
                    new SqlParameter("@startTime", SqlDbType.DateTime2,8),
                    new SqlParameter("@stopTime", SqlDbType.DateTime2,8),
                    new SqlParameter("@day", SqlDbType.DateTime2,8),
                    new SqlParameter("@shift", SqlDbType.VarChar,50),
                    new SqlParameter("@status", SqlDbType.VarChar,50),
                    new SqlParameter("@matPart01", SqlDbType.VarChar,50),
                    new SqlParameter("@matPart02", SqlDbType.VarChar,50),
                    new SqlParameter("@matLot01", SqlDbType.VarChar,50),
                    new SqlParameter("@matLot02", SqlDbType.VarChar,50),
                    new SqlParameter("@defectCodeID", SqlDbType.VarChar,50),
                    new SqlParameter("@defectCode", SqlDbType.VarChar,50),
                    new SqlParameter("@rejectQty", SqlDbType.Decimal,9),
                    new SqlParameter("@rejectQtyHour01", SqlDbType.VarChar,50),
                    new SqlParameter("@rejectQtyHour02", SqlDbType.VarChar,50),
                    new SqlParameter("@rejectQtyHour03", SqlDbType.VarChar,50),
                    new SqlParameter("@rejectQtyHour04", SqlDbType.VarChar,50),
                    new SqlParameter("@rejectQtyHour05", SqlDbType.VarChar,50),
                    new SqlParameter("@rejectQtyHour06", SqlDbType.VarChar,50),
                    new SqlParameter("@rejectQtyHour07", SqlDbType.VarChar,50),
                    new SqlParameter("@rejectQtyHour08", SqlDbType.VarChar,50),
                    new SqlParameter("@rejectQtyHour09", SqlDbType.VarChar,50),
                    new SqlParameter("@rejectQtyHour10", SqlDbType.VarChar,50),
                    new SqlParameter("@rejectQtyHour11", SqlDbType.VarChar,50),
                    new SqlParameter("@rejectQtyHour12", SqlDbType.VarChar,50),
                    new SqlParameter("@lastUpdatedTime", SqlDbType.DateTime2,8),
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
                    new SqlParameter("@partNumberAll", SqlDbType.VarChar,500)};
            parameters[0].Value = model.id == null ? (object)DBNull.Value : model.id;
            parameters[1].Value = model.trackingID == null ? (object)DBNull.Value : model.trackingID;
            parameters[2].Value = model.machineID == null ? (object)DBNull.Value : model.machineID;
            parameters[3].Value = model.dateTime == null ? (object)DBNull.Value : model.dateTime;
            parameters[4].Value = model.partNumber == null ? (object)DBNull.Value : model.partNumber;
            parameters[5].Value = model.jigNo == null ? (object)DBNull.Value : model.jigNo;
            parameters[6].Value = model.model == null ? (object)DBNull.Value : model.model;
            parameters[7].Value = model.cavityCount == null ? (object)DBNull.Value : model.cavityCount;
            parameters[8].Value = model.userName == null ? (object)DBNull.Value : model.userName;
            parameters[9].Value = model.userID == null ? (object)DBNull.Value : model.userID;
            parameters[10].Value = model.startTime == null ? (object)DBNull.Value : model.startTime;
            parameters[11].Value = model.stopTime == null ? (object)DBNull.Value : model.stopTime;
            parameters[12].Value = model.day == null ? (object)DBNull.Value : model.day;
            parameters[13].Value = model.shift == null ? (object)DBNull.Value : model.shift;
            parameters[14].Value = model.status == null ? (object)DBNull.Value : model.status;
            parameters[15].Value = model.matPart01 == null ? (object)DBNull.Value : model.matPart01;
            parameters[16].Value = model.matPart02 == null ? (object)DBNull.Value : model.matPart02;
            parameters[17].Value = model.matLot01 == null ? (object)DBNull.Value : model.matLot01;
            parameters[18].Value = model.matLot02 == null ? (object)DBNull.Value : model.matLot02;
            parameters[19].Value = model.defectCodeID == null ? (object)DBNull.Value : model.defectCodeID;
            parameters[20].Value = model.defectCode == null ? (object)DBNull.Value : model.defectCode;
            parameters[21].Value = model.rejectQty == null ? (object)DBNull.Value : model.rejectQty;
            parameters[22].Value = model.rejectQtyHour01 == null ? (object)DBNull.Value : model.rejectQtyHour01;
            parameters[23].Value = model.rejectQtyHour02 == null ? (object)DBNull.Value : model.rejectQtyHour02;
            parameters[24].Value = model.rejectQtyHour03 == null ? (object)DBNull.Value : model.rejectQtyHour03;
            parameters[25].Value = model.rejectQtyHour04 == null ? (object)DBNull.Value : model.rejectQtyHour04;
            parameters[26].Value = model.rejectQtyHour05 == null ? (object)DBNull.Value : model.rejectQtyHour05;
            parameters[27].Value = model.rejectQtyHour06 == null ? (object)DBNull.Value : model.rejectQtyHour06;
            parameters[28].Value = model.rejectQtyHour07 == null ? (object)DBNull.Value : model.rejectQtyHour07;
            parameters[29].Value = model.rejectQtyHour08 == null ? (object)DBNull.Value : model.rejectQtyHour08;
            parameters[30].Value = model.rejectQtyHour09 == null ? (object)DBNull.Value : model.rejectQtyHour09;
            parameters[31].Value = model.rejectQtyHour10 == null ? (object)DBNull.Value : model.rejectQtyHour10;
            parameters[32].Value = model.rejectQtyHour11 == null ? (object)DBNull.Value : model.rejectQtyHour11;
            parameters[33].Value = model.rejectQtyHour12 == null ? (object)DBNull.Value : model.rejectQtyHour12;
            parameters[34].Value = model.lastUpdatedTime == null ? (object)DBNull.Value : model.lastUpdatedTime;
            parameters[35].Value = model.remarks == null ? (object)DBNull.Value : model.remarks;
            parameters[36].Value = model.QCNGQTY == null ? (object)DBNull.Value : model.QCNGQTY;
            parameters[37].Value = model.Material_MHCheck == null ? (object)DBNull.Value : model.Material_MHCheck;
            parameters[38].Value = model.Material_MHCheckTime == null ? (object)DBNull.Value : model.Material_MHCheckTime;
            parameters[39].Value = model.Material_Opcheck == null ? (object)DBNull.Value : model.Material_Opcheck;
            parameters[40].Value = model.Material_OpCheckTime == null ? (object)DBNull.Value : model.Material_OpCheckTime;
            parameters[41].Value = model.Material_LeaderCheck == null ? (object)DBNull.Value : model.Material_LeaderCheck;
            parameters[42].Value = model.Material_LeaderCheckTime == null ? (object)DBNull.Value : model.Material_LeaderCheckTime;
            parameters[43].Value = model.LeaderCheck == null ? (object)DBNull.Value : model.LeaderCheck;
            parameters[44].Value = model.LeaderCheckTime == null ? (object)DBNull.Value : model.LeaderCheckTime;
            parameters[45].Value = model.SupervisorCheck == null ? (object)DBNull.Value : model.SupervisorCheck;
            parameters[46].Value = model.SupervisorCheckTime == null ? (object)DBNull.Value : model.SupervisorCheckTime;
            parameters[47].Value = model.partnumberall == null ? (object)DBNull.Value : model.partnumberall;
            DBHelp.Reports.LogFile.DebugLog("AUTOCODE", "NameSpace:Common.DAL", "Class:MouldingViDefectTracking_DAL", "Function:		public bool Update(Common.Model.MouldingViDefectTracking_Model model)" + "TableName:MouldingViDefectTracking", ";id = " + (model.id == null ? "" : model.id.ToString()) + ";trackingID = " + (model.trackingID == null ? "" : model.trackingID.ToString()) + ";machineID = " + (model.machineID == null ? "" : model.machineID.ToString()) + ";dateTime = " + (model.dateTime == null ? "" : model.dateTime.ToString()) + ";partNumber = " + (model.partNumber == null ? "" : model.partNumber.ToString()) + ";jigNo = " + (model.jigNo == null ? "" : model.jigNo.ToString()) + ";model = " + (model.model == null ? "" : model.model.ToString()) + ";cavityCount = " + (model.cavityCount == null ? "" : model.cavityCount.ToString()) + ";userName = " + (model.userName == null ? "" : model.userName.ToString()) + ";userID = " + (model.userID == null ? "" : model.userID.ToString()) + ";startTime = " + (model.startTime == null ? "" : model.startTime.ToString()) + ";stopTime = " + (model.stopTime == null ? "" : model.stopTime.ToString()) + ";day = " + (model.day == null ? "" : model.day.ToString()) + ";shift = " + (model.shift == null ? "" : model.shift.ToString()) + ";status = " + (model.status == null ? "" : model.status.ToString()) + ";matPart01 = " + (model.matPart01 == null ? "" : model.matPart01.ToString()) + ";matPart02 = " + (model.matPart02 == null ? "" : model.matPart02.ToString()) + ";matLot01 = " + (model.matLot01 == null ? "" : model.matLot01.ToString()) + ";matLot02 = " + (model.matLot02 == null ? "" : model.matLot02.ToString()) + ";defectCodeID = " + (model.defectCodeID == null ? "" : model.defectCodeID.ToString()) + ";defectCode = " + (model.defectCode == null ? "" : model.defectCode.ToString()) + ";rejectQty = " + (model.rejectQty == null ? "" : model.rejectQty.ToString()) + ";rejectQtyHour01 = " + (model.rejectQtyHour01 == null ? "" : model.rejectQtyHour01.ToString()) + ";rejectQtyHour02 = " + (model.rejectQtyHour02 == null ? "" : model.rejectQtyHour02.ToString()) + ";rejectQtyHour03 = " + (model.rejectQtyHour03 == null ? "" : model.rejectQtyHour03.ToString()) + ";rejectQtyHour04 = " + (model.rejectQtyHour04 == null ? "" : model.rejectQtyHour04.ToString()) + ";rejectQtyHour05 = " + (model.rejectQtyHour05 == null ? "" : model.rejectQtyHour05.ToString()) + ";rejectQtyHour06 = " + (model.rejectQtyHour06 == null ? "" : model.rejectQtyHour06.ToString()) + ";rejectQtyHour07 = " + (model.rejectQtyHour07 == null ? "" : model.rejectQtyHour07.ToString()) + ";rejectQtyHour08 = " + (model.rejectQtyHour08 == null ? "" : model.rejectQtyHour08.ToString()) + ";rejectQtyHour09 = " + (model.rejectQtyHour09 == null ? "" : model.rejectQtyHour09.ToString()) + ";rejectQtyHour10 = " + (model.rejectQtyHour10 == null ? "" : model.rejectQtyHour10.ToString()) + ";rejectQtyHour11 = " + (model.rejectQtyHour11 == null ? "" : model.rejectQtyHour11.ToString()) + ";rejectQtyHour12 = " + (model.rejectQtyHour12 == null ? "" : model.rejectQtyHour12.ToString()) + ";lastUpdatedTime = " + (model.lastUpdatedTime == null ? "" : model.lastUpdatedTime.ToString()) + ";remarks = " + (model.remarks == null ? "" : model.remarks.ToString()) + "");
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
        public SqlCommand UpdateCommand(Common.Model.MouldingViDefectTracking_Model model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update MouldingViDefectTracking set ");
            strSql.Append("id=@id,");
            //strSql.Append("trackingID=@trackingID,");
            strSql.Append("machineID=@machineID,");
            strSql.Append("dateTime=@dateTime,");
            strSql.Append("partNumber=@partNumber,");
            strSql.Append("jigNo=@jigNo,");
            strSql.Append("model=@model,");
            strSql.Append("cavityCount=@cavityCount,");
            strSql.Append("userName=@userName,");
            strSql.Append("userID=@userID,");
            strSql.Append("startTime=@startTime,");
            strSql.Append("stopTime=@stopTime,");
            strSql.Append("day=@day,");
            strSql.Append("shift=@shift,");
            strSql.Append("status=@status,");
            strSql.Append("matPart01=@matPart01,");
            strSql.Append("matPart02=@matPart02,");
            strSql.Append("matLot01=@matLot01,");
            strSql.Append("matLot02=@matLot02,");
            //strSql.Append("defectCodeID=@defectCodeID,");
            strSql.Append("defectCode=@defectCode,");
            strSql.Append("rejectQty=@rejectQty,");
            strSql.Append("rejectQtyHour01=@rejectQtyHour01,");
            strSql.Append("rejectQtyHour02=@rejectQtyHour02,");
            strSql.Append("rejectQtyHour03=@rejectQtyHour03,");
            strSql.Append("rejectQtyHour04=@rejectQtyHour04,");
            strSql.Append("rejectQtyHour05=@rejectQtyHour05,");
            strSql.Append("rejectQtyHour06=@rejectQtyHour06,");
            strSql.Append("rejectQtyHour07=@rejectQtyHour07,");
            strSql.Append("rejectQtyHour08=@rejectQtyHour08,");
            strSql.Append("rejectQtyHour09=@rejectQtyHour09,");
            strSql.Append("rejectQtyHour10=@rejectQtyHour10,");
            strSql.Append("rejectQtyHour11=@rejectQtyHour11,");
            strSql.Append("rejectQtyHour12=@rejectQtyHour12,");
            strSql.Append("lastUpdatedTime=@lastUpdatedTime,");
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
            strSql.Append("partNumberAll=@partNumberAll");
            strSql.Append(" where trackingID=@trackingID and defectCodeID=@defectCodeID ");
            SqlParameter[] parameters = {
                    new SqlParameter("@id", SqlDbType.Int,4),
                    new SqlParameter("@trackingID", SqlDbType.VarChar,50),
                    new SqlParameter("@machineID", SqlDbType.VarChar,8),
                    new SqlParameter("@dateTime", SqlDbType.DateTime2,8),
                    new SqlParameter("@partNumber", SqlDbType.VarChar,50),
                    new SqlParameter("@jigNo", SqlDbType.VarChar,50),
                    new SqlParameter("@model", SqlDbType.VarChar,50),
                    new SqlParameter("@cavityCount", SqlDbType.Decimal,9),
                    new SqlParameter("@userName", SqlDbType.VarChar,50),
                    new SqlParameter("@userID", SqlDbType.VarChar,50),
                    new SqlParameter("@startTime", SqlDbType.DateTime2,8),
                    new SqlParameter("@stopTime", SqlDbType.DateTime2,8),
                    new SqlParameter("@day", SqlDbType.DateTime2,8),
                    new SqlParameter("@shift", SqlDbType.VarChar,50),
                    new SqlParameter("@status", SqlDbType.VarChar,50),
                    new SqlParameter("@matPart01", SqlDbType.VarChar,50),
                    new SqlParameter("@matPart02", SqlDbType.VarChar,50),
                    new SqlParameter("@matLot01", SqlDbType.VarChar,50),
                    new SqlParameter("@matLot02", SqlDbType.VarChar,50),
                    new SqlParameter("@defectCodeID", SqlDbType.VarChar,50),
                    new SqlParameter("@defectCode", SqlDbType.VarChar,50),
                    new SqlParameter("@rejectQty", SqlDbType.Decimal,9),
                    new SqlParameter("@rejectQtyHour01", SqlDbType.VarChar,50),
                    new SqlParameter("@rejectQtyHour02", SqlDbType.VarChar,50),
                    new SqlParameter("@rejectQtyHour03", SqlDbType.VarChar,50),
                    new SqlParameter("@rejectQtyHour04", SqlDbType.VarChar,50),
                    new SqlParameter("@rejectQtyHour05", SqlDbType.VarChar,50),
                    new SqlParameter("@rejectQtyHour06", SqlDbType.VarChar,50),
                    new SqlParameter("@rejectQtyHour07", SqlDbType.VarChar,50),
                    new SqlParameter("@rejectQtyHour08", SqlDbType.VarChar,50),
                    new SqlParameter("@rejectQtyHour09", SqlDbType.VarChar,50),
                    new SqlParameter("@rejectQtyHour10", SqlDbType.VarChar,50),
                    new SqlParameter("@rejectQtyHour11", SqlDbType.VarChar,50),
                    new SqlParameter("@rejectQtyHour12", SqlDbType.VarChar,50),
                    new SqlParameter("@lastUpdatedTime", SqlDbType.DateTime2,8),
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
                    new SqlParameter("@partNumberAll", SqlDbType.VarChar,500)};
            parameters[0].Value = model.id == null ? (object)DBNull.Value : model.id;
            parameters[1].Value = model.trackingID == null ? (object)DBNull.Value : model.trackingID;
            parameters[2].Value = model.machineID == null ? (object)DBNull.Value : model.machineID;
            parameters[3].Value = model.dateTime == null ? (object)DBNull.Value : model.dateTime;
            parameters[4].Value = model.partNumber == null ? (object)DBNull.Value : model.partNumber;
            parameters[5].Value = model.jigNo == null ? (object)DBNull.Value : model.jigNo;
            parameters[6].Value = model.model == null ? (object)DBNull.Value : model.model;
            parameters[7].Value = model.cavityCount == null ? (object)DBNull.Value : model.cavityCount;
            parameters[8].Value = model.userName == null ? (object)DBNull.Value : model.userName;
            parameters[9].Value = model.userID == null ? (object)DBNull.Value : model.userID;
            parameters[10].Value = model.startTime == null ? (object)DBNull.Value : model.startTime;
            parameters[11].Value = model.stopTime == null ? (object)DBNull.Value : model.stopTime;
            parameters[12].Value = model.day == null ? (object)DBNull.Value : model.day;
            parameters[13].Value = model.shift == null ? (object)DBNull.Value : model.shift;
            parameters[14].Value = model.status == null ? (object)DBNull.Value : model.status;
            parameters[15].Value = model.matPart01 == null ? (object)DBNull.Value : model.matPart01;
            parameters[16].Value = model.matPart02 == null ? (object)DBNull.Value : model.matPart02;
            parameters[17].Value = model.matLot01 == null ? (object)DBNull.Value : model.matLot01;
            parameters[18].Value = model.matLot02 == null ? (object)DBNull.Value : model.matLot02;
            parameters[19].Value = model.defectCodeID == null ? (object)DBNull.Value : model.defectCodeID;
            parameters[20].Value = model.defectCode == null ? (object)DBNull.Value : model.defectCode;
            parameters[21].Value = model.rejectQty == null ? (object)DBNull.Value : model.rejectQty;
            parameters[22].Value = model.rejectQtyHour01 == null ? (object)DBNull.Value : model.rejectQtyHour01;
            parameters[23].Value = model.rejectQtyHour02 == null ? (object)DBNull.Value : model.rejectQtyHour02;
            parameters[24].Value = model.rejectQtyHour03 == null ? (object)DBNull.Value : model.rejectQtyHour03;
            parameters[25].Value = model.rejectQtyHour04 == null ? (object)DBNull.Value : model.rejectQtyHour04;
            parameters[26].Value = model.rejectQtyHour05 == null ? (object)DBNull.Value : model.rejectQtyHour05;
            parameters[27].Value = model.rejectQtyHour06 == null ? (object)DBNull.Value : model.rejectQtyHour06;
            parameters[28].Value = model.rejectQtyHour07 == null ? (object)DBNull.Value : model.rejectQtyHour07;
            parameters[29].Value = model.rejectQtyHour08 == null ? (object)DBNull.Value : model.rejectQtyHour08;
            parameters[30].Value = model.rejectQtyHour09 == null ? (object)DBNull.Value : model.rejectQtyHour09;
            parameters[31].Value = model.rejectQtyHour10 == null ? (object)DBNull.Value : model.rejectQtyHour10;
            parameters[32].Value = model.rejectQtyHour11 == null ? (object)DBNull.Value : model.rejectQtyHour11;
            parameters[33].Value = model.rejectQtyHour12 == null ? (object)DBNull.Value : model.rejectQtyHour12;
            parameters[34].Value = model.lastUpdatedTime == null ? (object)DBNull.Value : model.lastUpdatedTime;
            parameters[35].Value = model.remarks == null ? (object)DBNull.Value : model.remarks;
            parameters[36].Value = model.QCNGQTY == null ? (object)DBNull.Value : model.QCNGQTY;
            parameters[37].Value = model.Material_MHCheck == null ? (object)DBNull.Value : model.Material_MHCheck;
            parameters[38].Value = model.Material_MHCheckTime == null ? (object)DBNull.Value : model.Material_MHCheckTime;
            parameters[39].Value = model.Material_Opcheck == null ? (object)DBNull.Value : model.Material_Opcheck;
            parameters[40].Value = model.Material_OpCheckTime == null ? (object)DBNull.Value : model.Material_OpCheckTime;
            parameters[41].Value = model.Material_LeaderCheck == null ? (object)DBNull.Value : model.Material_LeaderCheck;
            parameters[42].Value = model.Material_LeaderCheckTime == null ? (object)DBNull.Value : model.Material_LeaderCheckTime;
            parameters[43].Value = model.LeaderCheck == null ? (object)DBNull.Value : model.LeaderCheck;
            parameters[44].Value = model.LeaderCheckTime == null ? (object)DBNull.Value : model.LeaderCheckTime;
            parameters[45].Value = model.SupervisorCheck == null ? (object)DBNull.Value : model.SupervisorCheck;
            parameters[46].Value = model.SupervisorCheckTime == null ? (object)DBNull.Value : model.SupervisorCheckTime;
            parameters[47].Value = model.partnumberall == null ? (object)DBNull.Value : model.partnumberall;
            DBHelp.Reports.LogFile.DebugLog("AUTOCODE", "NameSpace:Common.DAL", "Class:MouldingViDefectTracking_DAL", "Function:		public SqlCommand UpdateCommand(Common.Model.MouldingViDefectTracking_Model model)" + "TableName:MouldingViDefectTracking", ";id = " + (model.id == null ? "" : model.id.ToString()) + ";trackingID = " + (model.trackingID == null ? "" : model.trackingID.ToString()) + ";machineID = " + (model.machineID == null ? "" : model.machineID.ToString()) + ";dateTime = " + (model.dateTime == null ? "" : model.dateTime.ToString()) + ";partNumber = " + (model.partNumber == null ? "" : model.partNumber.ToString()) + ";jigNo = " + (model.jigNo == null ? "" : model.jigNo.ToString()) + ";model = " + (model.model == null ? "" : model.model.ToString()) + ";cavityCount = " + (model.cavityCount == null ? "" : model.cavityCount.ToString()) + ";userName = " + (model.userName == null ? "" : model.userName.ToString()) + ";userID = " + (model.userID == null ? "" : model.userID.ToString()) + ";startTime = " + (model.startTime == null ? "" : model.startTime.ToString()) + ";stopTime = " + (model.stopTime == null ? "" : model.stopTime.ToString()) + ";day = " + (model.day == null ? "" : model.day.ToString()) + ";shift = " + (model.shift == null ? "" : model.shift.ToString()) + ";status = " + (model.status == null ? "" : model.status.ToString()) + ";matPart01 = " + (model.matPart01 == null ? "" : model.matPart01.ToString()) + ";matPart02 = " + (model.matPart02 == null ? "" : model.matPart02.ToString()) + ";matLot01 = " + (model.matLot01 == null ? "" : model.matLot01.ToString()) + ";matLot02 = " + (model.matLot02 == null ? "" : model.matLot02.ToString()) + ";defectCodeID = " + (model.defectCodeID == null ? "" : model.defectCodeID.ToString()) + ";defectCode = " + (model.defectCode == null ? "" : model.defectCode.ToString()) + ";rejectQty = " + (model.rejectQty == null ? "" : model.rejectQty.ToString()) + ";rejectQtyHour01 = " + (model.rejectQtyHour01 == null ? "" : model.rejectQtyHour01.ToString()) + ";rejectQtyHour02 = " + (model.rejectQtyHour02 == null ? "" : model.rejectQtyHour02.ToString()) + ";rejectQtyHour03 = " + (model.rejectQtyHour03 == null ? "" : model.rejectQtyHour03.ToString()) + ";rejectQtyHour04 = " + (model.rejectQtyHour04 == null ? "" : model.rejectQtyHour04.ToString()) + ";rejectQtyHour05 = " + (model.rejectQtyHour05 == null ? "" : model.rejectQtyHour05.ToString()) + ";rejectQtyHour06 = " + (model.rejectQtyHour06 == null ? "" : model.rejectQtyHour06.ToString()) + ";rejectQtyHour07 = " + (model.rejectQtyHour07 == null ? "" : model.rejectQtyHour07.ToString()) + ";rejectQtyHour08 = " + (model.rejectQtyHour08 == null ? "" : model.rejectQtyHour08.ToString()) + ";rejectQtyHour09 = " + (model.rejectQtyHour09 == null ? "" : model.rejectQtyHour09.ToString()) + ";rejectQtyHour10 = " + (model.rejectQtyHour10 == null ? "" : model.rejectQtyHour10.ToString()) + ";rejectQtyHour11 = " + (model.rejectQtyHour11 == null ? "" : model.rejectQtyHour11.ToString()) + ";rejectQtyHour12 = " + (model.rejectQtyHour12 == null ? "" : model.rejectQtyHour12.ToString()) + ";lastUpdatedTime = " + (model.lastUpdatedTime == null ? "" : model.lastUpdatedTime.ToString()) + ";remarks = " + (model.remarks == null ? "" : model.remarks.ToString()) + "");
            return DBHelp.SqlDB.generateCommand(strSql.ToString(), parameters);
        }







        public SqlCommand AddCommand(Common.Model.MouldingViDefectTracking_Model model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into MouldingViDefectTracking(");
			strSql.Append("id,trackingID,machineID,dateTime,partNumber,jigNo,model,cavityCount,userName,userID,startTime,stopTime,day,shift,status,matPart01,matPart02,matLot01,matLot02,defectCodeID,defectCode,rejectQty,rejectQtyHour01,rejectQtyHour02,rejectQtyHour03,rejectQtyHour04,rejectQtyHour05,rejectQtyHour06,rejectQtyHour07,rejectQtyHour08,rejectQtyHour09,rejectQtyHour10,rejectQtyHour11,rejectQtyHour12,lastUpdatedTime,remarks,QCNGQTY,Material_MHCheck,Material_MHCheckTime,Material_Opcheck,Material_OpCheckTime,Material_LeaderCheck,Material_LeaderCheckTime,LeaderCheck,LeaderCheckTime,SupervisorCheck,SupervisorCheckTime,partNumberAll)");
			strSql.Append(" values (");
			strSql.Append("@id,@trackingID,@machineID,@dateTime,@partNumber,@jigNo,@model,@cavityCount,@userName,@userID,@startTime,@stopTime,@day,@shift,@status,@matPart01,@matPart02,@matLot01,@matLot02,@defectCodeID,@defectCode,@rejectQty,@rejectQtyHour01,@rejectQtyHour02,@rejectQtyHour03,@rejectQtyHour04,@rejectQtyHour05,@rejectQtyHour06,@rejectQtyHour07,@rejectQtyHour08,@rejectQtyHour09,@rejectQtyHour10,@rejectQtyHour11,@rejectQtyHour12,@lastUpdatedTime,@remarks,@QCNGQTY,@Material_MHCheck,@Material_MHCheckTime,@Material_Opcheck,@Material_OpCheckTime,@Material_LeaderCheck,@Material_LeaderCheckTime,@LeaderCheck,@LeaderCheckTime,@SupervisorCheck,@SupervisorCheckTime,@partNumberAll)");
			SqlParameter[] parameters = {
					new SqlParameter("@id", SqlDbType.Int,4),
					new SqlParameter("@trackingID", SqlDbType.VarChar,50),
					new SqlParameter("@machineID", SqlDbType.VarChar,8),
					new SqlParameter("@dateTime", SqlDbType.DateTime2,8),
					new SqlParameter("@partNumber", SqlDbType.VarChar,50),
					new SqlParameter("@jigNo", SqlDbType.VarChar,50),
					new SqlParameter("@model", SqlDbType.VarChar,50),
					new SqlParameter("@cavityCount", SqlDbType.Decimal,9),
					new SqlParameter("@userName", SqlDbType.VarChar,50),
					new SqlParameter("@userID", SqlDbType.VarChar,50),
					new SqlParameter("@startTime", SqlDbType.DateTime2,8),
					new SqlParameter("@stopTime", SqlDbType.DateTime2,8),
					new SqlParameter("@day", SqlDbType.DateTime2,8),
					new SqlParameter("@shift", SqlDbType.VarChar,50),
					new SqlParameter("@status", SqlDbType.VarChar,50),
					new SqlParameter("@matPart01", SqlDbType.VarChar,50),
					new SqlParameter("@matPart02", SqlDbType.VarChar,50),
					new SqlParameter("@matLot01", SqlDbType.VarChar,50),
					new SqlParameter("@matLot02", SqlDbType.VarChar,50),
					new SqlParameter("@defectCodeID", SqlDbType.VarChar,50),
					new SqlParameter("@defectCode", SqlDbType.VarChar,50),
					new SqlParameter("@rejectQty", SqlDbType.Decimal,9),
					new SqlParameter("@rejectQtyHour01", SqlDbType.VarChar,50),
					new SqlParameter("@rejectQtyHour02", SqlDbType.VarChar,50),
					new SqlParameter("@rejectQtyHour03", SqlDbType.VarChar,50),
					new SqlParameter("@rejectQtyHour04", SqlDbType.VarChar,50),
					new SqlParameter("@rejectQtyHour05", SqlDbType.VarChar,50),
					new SqlParameter("@rejectQtyHour06", SqlDbType.VarChar,50),
					new SqlParameter("@rejectQtyHour07", SqlDbType.VarChar,50),
					new SqlParameter("@rejectQtyHour08", SqlDbType.VarChar,50),
					new SqlParameter("@rejectQtyHour09", SqlDbType.VarChar,50),
					new SqlParameter("@rejectQtyHour10", SqlDbType.VarChar,50),
					new SqlParameter("@rejectQtyHour11", SqlDbType.VarChar,50),
					new SqlParameter("@rejectQtyHour12", SqlDbType.VarChar,50),
					new SqlParameter("@lastUpdatedTime", SqlDbType.DateTime2,8),
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
                    new SqlParameter("@partNumberAll", SqlDbType.VarChar,500)};
            DBHelp.Reports.LogFile.DebugLog("AUTOCODE","NameSpace:Common.DAL" , "Class:MouldingViDefectTracking_DAL" , "Function:		public SqlCommand AddCommand(Common.Model.MouldingViDefectTracking_Model model)"  + "TableName:MouldingViDefectTracking" , ";id = "+ (model.id == null ? "" : model.id.ToString()) + ";trackingID = "+ (model.trackingID == null ? "" : model.trackingID.ToString()) + ";machineID = "+ (model.machineID == null ? "" : model.machineID.ToString()) + ";dateTime = "+ (model.dateTime == null ? "" : model.dateTime.ToString()) + ";partNumber = "+ (model.partNumber == null ? "" : model.partNumber.ToString()) + ";jigNo = "+ (model.jigNo == null ? "" : model.jigNo.ToString()) + ";model = "+ (model.model == null ? "" : model.model.ToString()) + ";cavityCount = "+ (model.cavityCount == null ? "" : model.cavityCount.ToString()) + ";userName = "+ (model.userName == null ? "" : model.userName.ToString()) + ";userID = "+ (model.userID == null ? "" : model.userID.ToString()) + ";startTime = "+ (model.startTime == null ? "" : model.startTime.ToString()) + ";stopTime = "+ (model.stopTime == null ? "" : model.stopTime.ToString()) + ";day = "+ (model.day == null ? "" : model.day.ToString()) + ";shift = "+ (model.shift == null ? "" : model.shift.ToString()) + ";status = "+ (model.status == null ? "" : model.status.ToString()) + ";matPart01 = "+ (model.matPart01 == null ? "" : model.matPart01.ToString()) + ";matPart02 = "+ (model.matPart02 == null ? "" : model.matPart02.ToString()) + ";matLot01 = "+ (model.matLot01 == null ? "" : model.matLot01.ToString()) + ";matLot02 = "+ (model.matLot02 == null ? "" : model.matLot02.ToString()) + ";defectCodeID = "+ (model.defectCodeID == null ? "" : model.defectCodeID.ToString()) + ";defectCode = "+ (model.defectCode == null ? "" : model.defectCode.ToString()) + ";rejectQty = "+ (model.rejectQty == null ? "" : model.rejectQty.ToString()) + ";rejectQtyHour01 = "+ (model.rejectQtyHour01 == null ? "" : model.rejectQtyHour01.ToString()) + ";rejectQtyHour02 = "+ (model.rejectQtyHour02 == null ? "" : model.rejectQtyHour02.ToString()) + ";rejectQtyHour03 = "+ (model.rejectQtyHour03 == null ? "" : model.rejectQtyHour03.ToString()) + ";rejectQtyHour04 = "+ (model.rejectQtyHour04 == null ? "" : model.rejectQtyHour04.ToString()) + ";rejectQtyHour05 = "+ (model.rejectQtyHour05 == null ? "" : model.rejectQtyHour05.ToString()) + ";rejectQtyHour06 = "+ (model.rejectQtyHour06 == null ? "" : model.rejectQtyHour06.ToString()) + ";rejectQtyHour07 = "+ (model.rejectQtyHour07 == null ? "" : model.rejectQtyHour07.ToString()) + ";rejectQtyHour08 = "+ (model.rejectQtyHour08 == null ? "" : model.rejectQtyHour08.ToString()) + ";rejectQtyHour09 = "+ (model.rejectQtyHour09 == null ? "" : model.rejectQtyHour09.ToString()) + ";rejectQtyHour10 = "+ (model.rejectQtyHour10 == null ? "" : model.rejectQtyHour10.ToString()) + ";rejectQtyHour11 = "+ (model.rejectQtyHour11 == null ? "" : model.rejectQtyHour11.ToString()) + ";rejectQtyHour12 = "+ (model.rejectQtyHour12 == null ? "" : model.rejectQtyHour12.ToString()) + ";lastUpdatedTime = "+ (model.lastUpdatedTime == null ? "" : model.lastUpdatedTime.ToString()) + ";remarks = "+ (model.remarks == null ? "" : model.remarks.ToString()) + "");
			parameters[0].Value = model.id == null ? (object)DBNull.Value : model.id ;
			parameters[1].Value = model.trackingID == null ? (object)DBNull.Value : model.trackingID ;
			parameters[2].Value = model.machineID == null ? (object)DBNull.Value : model.machineID ;
			parameters[3].Value = model.dateTime == null ? (object)DBNull.Value : model.dateTime ;
			parameters[4].Value = model.partNumber == null ? (object)DBNull.Value : model.partNumber ;
			parameters[5].Value = model.jigNo == null ? (object)DBNull.Value : model.jigNo ;
			parameters[6].Value = model.model == null ? (object)DBNull.Value : model.model ;
			parameters[7].Value = model.cavityCount == null ? (object)DBNull.Value : model.cavityCount ;
			parameters[8].Value = model.userName == null ? (object)DBNull.Value : model.userName ;
			parameters[9].Value = model.userID == null ? (object)DBNull.Value : model.userID ;
			parameters[10].Value = model.startTime == null ? (object)DBNull.Value : model.startTime ;
			parameters[11].Value = model.stopTime == null ? (object)DBNull.Value : model.stopTime ;
			parameters[12].Value = model.day == null ? (object)DBNull.Value : model.day ;
			parameters[13].Value = model.shift == null ? (object)DBNull.Value : model.shift ;
			parameters[14].Value = model.status == null ? (object)DBNull.Value : model.status ;
			parameters[15].Value = model.matPart01 == null ? (object)DBNull.Value : model.matPart01 ;
			parameters[16].Value = model.matPart02 == null ? (object)DBNull.Value : model.matPart02 ;
			parameters[17].Value = model.matLot01 == null ? (object)DBNull.Value : model.matLot01 ;
			parameters[18].Value = model.matLot02 == null ? (object)DBNull.Value : model.matLot02 ;
			parameters[19].Value = model.defectCodeID == null ? (object)DBNull.Value : model.defectCodeID ;
			parameters[20].Value = model.defectCode == null ? (object)DBNull.Value : model.defectCode ;
			parameters[21].Value = model.rejectQty == null ? (object)DBNull.Value : model.rejectQty ;
			parameters[22].Value = model.rejectQtyHour01 == null ? (object)DBNull.Value : model.rejectQtyHour01 ;
			parameters[23].Value = model.rejectQtyHour02 == null ? (object)DBNull.Value : model.rejectQtyHour02 ;
			parameters[24].Value = model.rejectQtyHour03 == null ? (object)DBNull.Value : model.rejectQtyHour03 ;
			parameters[25].Value = model.rejectQtyHour04 == null ? (object)DBNull.Value : model.rejectQtyHour04 ;
			parameters[26].Value = model.rejectQtyHour05 == null ? (object)DBNull.Value : model.rejectQtyHour05 ;
			parameters[27].Value = model.rejectQtyHour06 == null ? (object)DBNull.Value : model.rejectQtyHour06 ;
			parameters[28].Value = model.rejectQtyHour07 == null ? (object)DBNull.Value : model.rejectQtyHour07 ;
			parameters[29].Value = model.rejectQtyHour08 == null ? (object)DBNull.Value : model.rejectQtyHour08 ;
			parameters[30].Value = model.rejectQtyHour09 == null ? (object)DBNull.Value : model.rejectQtyHour09 ;
			parameters[31].Value = model.rejectQtyHour10 == null ? (object)DBNull.Value : model.rejectQtyHour10 ;
			parameters[32].Value = model.rejectQtyHour11 == null ? (object)DBNull.Value : model.rejectQtyHour11 ;
			parameters[33].Value = model.rejectQtyHour12 == null ? (object)DBNull.Value : model.rejectQtyHour12 ;
			parameters[34].Value = model.lastUpdatedTime == null ? (object)DBNull.Value : model.lastUpdatedTime ;
			parameters[35].Value = model.remarks == null ? (object)DBNull.Value : model.remarks ;
            parameters[36].Value = model.QCNGQTY == null ? (object)DBNull.Value : model.QCNGQTY;
            parameters[37].Value = model.Material_MHCheck == null ? (object)DBNull.Value : model.Material_MHCheck;
            parameters[38].Value = model.Material_MHCheckTime == null ? (object)DBNull.Value : model.Material_MHCheckTime;
            parameters[39].Value = model.Material_Opcheck == null ? (object)DBNull.Value : model.Material_Opcheck;
            parameters[40].Value = model.Material_OpCheckTime == null ? (object)DBNull.Value : model.Material_OpCheckTime;
            parameters[41].Value = model.Material_LeaderCheck == null ? (object)DBNull.Value : model.Material_LeaderCheck;
            parameters[42].Value = model.Material_LeaderCheckTime == null ? (object)DBNull.Value : model.Material_LeaderCheckTime;
            parameters[43].Value = model.LeaderCheck == null ? (object)DBNull.Value : model.LeaderCheck;
            parameters[44].Value = model.LeaderCheckTime == null ? (object)DBNull.Value : model.LeaderCheckTime;
            parameters[45].Value = model.SupervisorCheck == null ? (object)DBNull.Value : model.SupervisorCheck;
            parameters[46].Value = model.SupervisorCheckTime == null ? (object)DBNull.Value : model.SupervisorCheckTime;
            parameters[47].Value = model.partnumberall == null ? (object)DBNull.Value : model.partnumberall;
            return DBHelp.SqlDB.generateCommand(strSql.ToString(),parameters);
		}
        
        public SqlCommand UpdateCommandbypartNubmer(Common.Model.MouldingViDefectTracking_Model model,string sPartNumber)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update MouldingViDefectTracking set ");
            strSql.Append("id=@id,");
            //strSql.Append("trackingID=@trackingID,");
            strSql.Append("machineID=@machineID,");
            strSql.Append("dateTime=@dateTime,");
            strSql.Append("partNumber=@partNumber,");
            strSql.Append("jigNo=@jigNo,");
            strSql.Append("model=@model,");
            strSql.Append("cavityCount=@cavityCount,");
            strSql.Append("userName=@userName,");
            strSql.Append("userID=@userID,");
            strSql.Append("startTime=@startTime,");
            strSql.Append("stopTime=@stopTime,");
            strSql.Append("day=@day,");
            strSql.Append("shift=@shift,");
            strSql.Append("status=@status,");
            strSql.Append("matPart01=@matPart01,");
            strSql.Append("matPart02=@matPart02,");
            strSql.Append("matLot01=@matLot01,");
            strSql.Append("matLot02=@matLot02,");
            //strSql.Append("defectCodeID=@defectCodeID,");
            strSql.Append("defectCode=@defectCode,");
            strSql.Append("rejectQty=@rejectQty,");
            strSql.Append("rejectQtyHour01=@rejectQtyHour01,");
            strSql.Append("rejectQtyHour02=@rejectQtyHour02,");
            strSql.Append("rejectQtyHour03=@rejectQtyHour03,");
            strSql.Append("rejectQtyHour04=@rejectQtyHour04,");
            strSql.Append("rejectQtyHour05=@rejectQtyHour05,");
            strSql.Append("rejectQtyHour06=@rejectQtyHour06,");
            strSql.Append("rejectQtyHour07=@rejectQtyHour07,");
            strSql.Append("rejectQtyHour08=@rejectQtyHour08,");
            strSql.Append("rejectQtyHour09=@rejectQtyHour09,");
            strSql.Append("rejectQtyHour10=@rejectQtyHour10,");
            strSql.Append("rejectQtyHour11=@rejectQtyHour11,");
            strSql.Append("rejectQtyHour12=@rejectQtyHour12,");
            strSql.Append("lastUpdatedTime=@lastUpdatedTime,");
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
            strSql.Append("partNumberAll=@partNumberAll");
            strSql.Append(" where partNumber=@partNumber and defectCodeID=@defectCodeID ");
            strSql.Append(" and partNumberAll=@partNumberAll ");
            strSql.Append(" and day=@day ");
            strSql.Append(" and shift=@shift ");
            strSql.Append(" and machineID=@machineID ");
            SqlParameter[] parameters = {
                    new SqlParameter("@id", SqlDbType.Int,4),
                    new SqlParameter("@trackingID", SqlDbType.VarChar,50),
                    new SqlParameter("@machineID", SqlDbType.VarChar,8),
                    new SqlParameter("@dateTime", SqlDbType.DateTime2,8),
                    new SqlParameter("@partNumber", SqlDbType.VarChar,50),
                    new SqlParameter("@jigNo", SqlDbType.VarChar,50),
                    new SqlParameter("@model", SqlDbType.VarChar,50),
                    new SqlParameter("@cavityCount", SqlDbType.Decimal,9),
                    new SqlParameter("@userName", SqlDbType.VarChar,50),
                    new SqlParameter("@userID", SqlDbType.VarChar,50),
                    new SqlParameter("@startTime", SqlDbType.DateTime2,8),
                    new SqlParameter("@stopTime", SqlDbType.DateTime2,8),
                    new SqlParameter("@day", SqlDbType.DateTime2,8),
                    new SqlParameter("@shift", SqlDbType.VarChar,50),
                    new SqlParameter("@status", SqlDbType.VarChar,50),
                    new SqlParameter("@matPart01", SqlDbType.VarChar,50),
                    new SqlParameter("@matPart02", SqlDbType.VarChar,50),
                    new SqlParameter("@matLot01", SqlDbType.VarChar,50),
                    new SqlParameter("@matLot02", SqlDbType.VarChar,50),
                    new SqlParameter("@defectCodeID", SqlDbType.VarChar,50),
                    new SqlParameter("@defectCode", SqlDbType.VarChar,50),
                    new SqlParameter("@rejectQty", SqlDbType.Decimal,9),
                    new SqlParameter("@rejectQtyHour01", SqlDbType.VarChar,50),
                    new SqlParameter("@rejectQtyHour02", SqlDbType.VarChar,50),
                    new SqlParameter("@rejectQtyHour03", SqlDbType.VarChar,50),
                    new SqlParameter("@rejectQtyHour04", SqlDbType.VarChar,50),
                    new SqlParameter("@rejectQtyHour05", SqlDbType.VarChar,50),
                    new SqlParameter("@rejectQtyHour06", SqlDbType.VarChar,50),
                    new SqlParameter("@rejectQtyHour07", SqlDbType.VarChar,50),
                    new SqlParameter("@rejectQtyHour08", SqlDbType.VarChar,50),
                    new SqlParameter("@rejectQtyHour09", SqlDbType.VarChar,50),
                    new SqlParameter("@rejectQtyHour10", SqlDbType.VarChar,50),
                    new SqlParameter("@rejectQtyHour11", SqlDbType.VarChar,50),
                    new SqlParameter("@rejectQtyHour12", SqlDbType.VarChar,50),
                    new SqlParameter("@lastUpdatedTime", SqlDbType.DateTime2,8),
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
                    new SqlParameter("@partNumberAll", SqlDbType.VarChar,500)};
            parameters[0].Value = model.id == null ? (object)DBNull.Value : model.id;
            parameters[1].Value = model.trackingID == null ? (object)DBNull.Value : model.trackingID;
            parameters[2].Value = model.machineID == null ? (object)DBNull.Value : model.machineID;
            parameters[3].Value = model.dateTime == null ? (object)DBNull.Value : model.dateTime;
            parameters[4].Value = sPartNumber == null ? (object)DBNull.Value : sPartNumber;
            parameters[5].Value = model.jigNo == null ? (object)DBNull.Value : model.jigNo;
            parameters[6].Value = model.model == null ? (object)DBNull.Value : model.model;
            parameters[7].Value = model.cavityCount == null ? (object)DBNull.Value : model.cavityCount;
            parameters[8].Value = model.userName == null ? (object)DBNull.Value : model.userName;
            parameters[9].Value = model.userID == null ? (object)DBNull.Value : model.userID;
            parameters[10].Value = model.startTime == null ? (object)DBNull.Value : model.startTime;
            parameters[11].Value = model.stopTime == null ? (object)DBNull.Value : model.stopTime;
            parameters[12].Value = model.day == null ? (object)DBNull.Value : model.day;
            parameters[13].Value = model.shift == null ? (object)DBNull.Value : model.shift;
            parameters[14].Value = model.status == null ? (object)DBNull.Value : model.status;
            parameters[15].Value = model.matPart01 == null ? (object)DBNull.Value : model.matPart01;
            parameters[16].Value = model.matPart02 == null ? (object)DBNull.Value : model.matPart02;
            parameters[17].Value = model.matLot01 == null ? (object)DBNull.Value : model.matLot01;
            parameters[18].Value = model.matLot02 == null ? (object)DBNull.Value : model.matLot02;
            parameters[19].Value = model.defectCodeID == null ? (object)DBNull.Value : model.defectCodeID;
            parameters[20].Value = model.defectCode == null ? (object)DBNull.Value : model.defectCode;
            parameters[21].Value = model.rejectQty == null ? (object)DBNull.Value : model.rejectQty;
            parameters[22].Value = model.rejectQtyHour01 == null ? (object)DBNull.Value : model.rejectQtyHour01;
            parameters[23].Value = model.rejectQtyHour02 == null ? (object)DBNull.Value : model.rejectQtyHour02;
            parameters[24].Value = model.rejectQtyHour03 == null ? (object)DBNull.Value : model.rejectQtyHour03;
            parameters[25].Value = model.rejectQtyHour04 == null ? (object)DBNull.Value : model.rejectQtyHour04;
            parameters[26].Value = model.rejectQtyHour05 == null ? (object)DBNull.Value : model.rejectQtyHour05;
            parameters[27].Value = model.rejectQtyHour06 == null ? (object)DBNull.Value : model.rejectQtyHour06;
            parameters[28].Value = model.rejectQtyHour07 == null ? (object)DBNull.Value : model.rejectQtyHour07;
            parameters[29].Value = model.rejectQtyHour08 == null ? (object)DBNull.Value : model.rejectQtyHour08;
            parameters[30].Value = model.rejectQtyHour09 == null ? (object)DBNull.Value : model.rejectQtyHour09;
            parameters[31].Value = model.rejectQtyHour10 == null ? (object)DBNull.Value : model.rejectQtyHour10;
            parameters[32].Value = model.rejectQtyHour11 == null ? (object)DBNull.Value : model.rejectQtyHour11;
            parameters[33].Value = model.rejectQtyHour12 == null ? (object)DBNull.Value : model.rejectQtyHour12;
            parameters[34].Value = model.lastUpdatedTime == null ? (object)DBNull.Value : model.lastUpdatedTime;
            parameters[35].Value = model.remarks == null ? (object)DBNull.Value : model.remarks;
            parameters[36].Value = model.QCNGQTY == null ? (object)DBNull.Value : model.QCNGQTY;
            parameters[37].Value = model.Material_MHCheck == null ? (object)DBNull.Value : model.Material_MHCheck;
            parameters[38].Value = model.Material_MHCheckTime == null ? (object)DBNull.Value : model.Material_MHCheckTime;
            parameters[39].Value = model.Material_Opcheck == null ? (object)DBNull.Value : model.Material_Opcheck;
            parameters[40].Value = model.Material_OpCheckTime == null ? (object)DBNull.Value : model.Material_OpCheckTime;
            parameters[41].Value = model.Material_LeaderCheck == null ? (object)DBNull.Value : model.Material_LeaderCheck;
            parameters[42].Value = model.Material_LeaderCheckTime == null ? (object)DBNull.Value : model.Material_LeaderCheckTime;
            parameters[43].Value = model.LeaderCheck == null ? (object)DBNull.Value : model.LeaderCheck;
            parameters[44].Value = model.LeaderCheckTime == null ? (object)DBNull.Value : model.LeaderCheckTime;
            parameters[45].Value = model.SupervisorCheck == null ? (object)DBNull.Value : model.SupervisorCheck;
            parameters[46].Value = model.SupervisorCheckTime == null ? (object)DBNull.Value : model.SupervisorCheckTime;
            parameters[47].Value = model.partnumberall == null ? (object)DBNull.Value : model.partnumberall;
            DBHelp.Reports.LogFile.DebugLog("AUTOCODE", "NameSpace:Common.DAL", "Class:MouldingViDefectTracking_DAL", "Function:		public SqlCommand UpdateCommand(Common.Model.MouldingViDefectTracking_Model model)" + "TableName:MouldingViDefectTracking", ";id = " + (model.id == null ? "" : model.id.ToString()) + ";trackingID = " + (model.trackingID == null ? "" : model.trackingID.ToString()) + ";machineID = " + (model.machineID == null ? "" : model.machineID.ToString()) + ";dateTime = " + (model.dateTime == null ? "" : model.dateTime.ToString()) + ";partNumber = " + (model.partNumber == null ? "" : model.partNumber.ToString()) + ";jigNo = " + (model.jigNo == null ? "" : model.jigNo.ToString()) + ";model = " + (model.model == null ? "" : model.model.ToString()) + ";cavityCount = " + (model.cavityCount == null ? "" : model.cavityCount.ToString()) + ";userName = " + (model.userName == null ? "" : model.userName.ToString()) + ";userID = " + (model.userID == null ? "" : model.userID.ToString()) + ";startTime = " + (model.startTime == null ? "" : model.startTime.ToString()) + ";stopTime = " + (model.stopTime == null ? "" : model.stopTime.ToString()) + ";day = " + (model.day == null ? "" : model.day.ToString()) + ";shift = " + (model.shift == null ? "" : model.shift.ToString()) + ";status = " + (model.status == null ? "" : model.status.ToString()) + ";matPart01 = " + (model.matPart01 == null ? "" : model.matPart01.ToString()) + ";matPart02 = " + (model.matPart02 == null ? "" : model.matPart02.ToString()) + ";matLot01 = " + (model.matLot01 == null ? "" : model.matLot01.ToString()) + ";matLot02 = " + (model.matLot02 == null ? "" : model.matLot02.ToString()) + ";defectCodeID = " + (model.defectCodeID == null ? "" : model.defectCodeID.ToString()) + ";defectCode = " + (model.defectCode == null ? "" : model.defectCode.ToString()) + ";rejectQty = " + (model.rejectQty == null ? "" : model.rejectQty.ToString()) + ";rejectQtyHour01 = " + (model.rejectQtyHour01 == null ? "" : model.rejectQtyHour01.ToString()) + ";rejectQtyHour02 = " + (model.rejectQtyHour02 == null ? "" : model.rejectQtyHour02.ToString()) + ";rejectQtyHour03 = " + (model.rejectQtyHour03 == null ? "" : model.rejectQtyHour03.ToString()) + ";rejectQtyHour04 = " + (model.rejectQtyHour04 == null ? "" : model.rejectQtyHour04.ToString()) + ";rejectQtyHour05 = " + (model.rejectQtyHour05 == null ? "" : model.rejectQtyHour05.ToString()) + ";rejectQtyHour06 = " + (model.rejectQtyHour06 == null ? "" : model.rejectQtyHour06.ToString()) + ";rejectQtyHour07 = " + (model.rejectQtyHour07 == null ? "" : model.rejectQtyHour07.ToString()) + ";rejectQtyHour08 = " + (model.rejectQtyHour08 == null ? "" : model.rejectQtyHour08.ToString()) + ";rejectQtyHour09 = " + (model.rejectQtyHour09 == null ? "" : model.rejectQtyHour09.ToString()) + ";rejectQtyHour10 = " + (model.rejectQtyHour10 == null ? "" : model.rejectQtyHour10.ToString()) + ";rejectQtyHour11 = " + (model.rejectQtyHour11 == null ? "" : model.rejectQtyHour11.ToString()) + ";rejectQtyHour12 = " + (model.rejectQtyHour12 == null ? "" : model.rejectQtyHour12.ToString()) + ";lastUpdatedTime = " + (model.lastUpdatedTime == null ? "" : model.lastUpdatedTime.ToString()) + ";remarks = " + (model.remarks == null ? "" : model.remarks.ToString()) + "");
            return DBHelp.SqlDB.generateCommand(strSql.ToString(), parameters);
        }

        public SqlCommand UpdatebyDayMachineShifPartNumberAll(Common.Model.MouldingViTracking_Model model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update MouldingViDefectTracking set ");
            strSql.Append("userName=@userName,");
            strSql.Append("userID=@userID,");
            strSql.Append("startTime=@startTime,");
            strSql.Append("matLot01=@matLot01,");
            strSql.Append("matLot02=@matLot02,");
            strSql.Append("lastUpdatedTime=@lastUpdatedTime");
            strSql.Append(" where  ");
            strSql.Append("  partNumberAll=@partNumberAll ");
            strSql.Append(" and day=@day ");
            strSql.Append(" and shift=@shift ");
            strSql.Append(" and machineID=@machineID ");
            SqlParameter[] parameters = {
                    new SqlParameter("@userName", SqlDbType.VarChar,50),
                    new SqlParameter("@userID", SqlDbType.VarChar,50),
                    new SqlParameter("@startTime", SqlDbType.DateTime2,8),
                    new SqlParameter("@matLot01", SqlDbType.VarChar,50),
                    new SqlParameter("@matLot02", SqlDbType.VarChar,50),
                    new SqlParameter("@lastUpdatedTime", SqlDbType.DateTime2,8),
                    new SqlParameter("@partNumberAll", SqlDbType.VarChar,500),
                    new SqlParameter("@day", SqlDbType.DateTime2,8),
                    new SqlParameter("@shift", SqlDbType.VarChar,50),
                     new SqlParameter("@machineID", SqlDbType.VarChar,8)};
            parameters[0].Value = model.userName == null ? (object)DBNull.Value : model.userName;
            parameters[1].Value = model.userID == null ? (object)DBNull.Value : model.userID;
            parameters[2].Value = model.startTime == null ? (object)DBNull.Value : model.startTime;
            parameters[3].Value = model.matLot01 == null ? (object)DBNull.Value : model.matLot01;
            parameters[4].Value = model.matLot02 == null ? (object)DBNull.Value : model.matLot02;
            parameters[5].Value = model.lastUpdatedTime == null ? (object)DBNull.Value : model.lastUpdatedTime;
            parameters[6].Value = model.partnumberall == null ? (object)DBNull.Value : model.partnumberall;
            parameters[7].Value = model.day == null ? (object)DBNull.Value : model.day;
            parameters[8].Value = model.shift == null ? (object)DBNull.Value : model.shift;
            parameters[9].Value = model.machineID == null ? (object)DBNull.Value : model.machineID;
            DBHelp.Reports.LogFile.DebugLog("AUTOCODE", "NameSpace:Common.DAL", "Class:MouldingViDefectTracking_DAL", "Function:		public bool UpdatebyDayMachineShifPartNumberAll(Common.Model.MouldingViTracking_Model model)" + "TableName:MouldingViDefectTracking", "");
            return DBHelp.SqlDB.generateCommand(strSql.ToString(), parameters);
        }









        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool Delete()
		{
			//该表无主键信息，请自定义主键/条件字段
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from MouldingViDefectTracking ");
			strSql.Append(" where ");
			SqlParameter[] parameters = {
};

			 DBHelp.Reports.LogFile.DebugLog("AUTOCODE","NameSpace:Common.DAL" , "Class:MouldingViDefectTracking_DAL" , "Function:		public bool Delete()"  + "TableName:MouldingViDefectTracking" , "");
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
			strSql.Append("delete from MouldingViDefectTracking ");
			strSql.Append(" where ");
			SqlParameter[] parameters = {
};

			 DBHelp.Reports.LogFile.DebugLog("AUTOCODE","NameSpace:Common.DAL" , "Class:MouldingViDefectTracking_DAL" , "Function:		public SqlCommand DeleteCommand()"  + "TableName:MouldingViDefectTracking" , "");
			return DBHelp.SqlDB.generateCommand(strSql.ToString(),parameters);
		}
		/// <summary>
		/// 删除一条数据
		/// </summary>
		public SqlCommand DeleteAllCommand( )
		{
			//该表无主键信息，请自定义主键/条件字段
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from MouldingViDefectTracking ");
			 DBHelp.Reports.LogFile.DebugLog("AUTOCODE","NameSpace:Common.DAL" , "Class:MouldingViDefectTracking_DAL" , "Function:		public SqlCommand DeleteAllCommand( )"  + "TableName:MouldingViDefectTracking" , "");
			return DBHelp.SqlDB.generateCommand(strSql.ToString(), new SqlParameter[0]);
		}


		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public Common.Model.MouldingViDefectTracking_Model GetModel()
		{
			//该表无主键信息，请自定义主键/条件字段
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 id,trackingID,machineID,dateTime,partNumber,jigNo,model,cavityCount,userName,userID,startTime,stopTime,day,shift,status,matPart01,matPart02,matLot01,matLot02,defectCodeID,defectCode,rejectQty,rejectQtyHour01,rejectQtyHour02,rejectQtyHour03,rejectQtyHour04,rejectQtyHour05,rejectQtyHour06,rejectQtyHour07,rejectQtyHour08,rejectQtyHour09,rejectQtyHour10,rejectQtyHour11,rejectQtyHour12,lastUpdatedTime,remarks,QCNGQTY,Material_MHCheck,Material_MHCheckTime,Material_Opcheck,Material_OpCheckTime,Material_LeaderCheck,Material_LeaderCheckTime,LeaderCheck,LeaderCheckTime,SupervisorCheck,SupervisorCheckTime,partNumberAll from MouldingViDefectTracking ");
			strSql.Append(" where ");
			SqlParameter[] parameters = {
};

			 DBHelp.Reports.LogFile.DebugLog("AUTOCODE","NameSpace:Common.DAL" , "Class:MouldingViDefectTracking_DAL" , "Function:		public Common.Model.MouldingViDefectTracking_Model GetModel()"  + "TableName:MouldingViDefectTracking" , "");
			Common.Model.MouldingViDefectTracking_Model model=new Common.Model.MouldingViDefectTracking_Model();
			DataSet ds=DBHelp.SqlDB.Query(strSql.ToString(),parameters);
			if(ds.Tables[0].Rows.Count>0)
			{
				if(ds.Tables[0].Rows[0]["id"].ToString()!="")
				{
					model.id=int.Parse(ds.Tables[0].Rows[0]["id"].ToString());
				}
				model.trackingID=ds.Tables[0].Rows[0]["trackingID"].ToString();
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
				model.userName=ds.Tables[0].Rows[0]["userName"].ToString();
				model.userID=ds.Tables[0].Rows[0]["userID"].ToString();
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
				model.defectCodeID=ds.Tables[0].Rows[0]["defectCodeID"].ToString();
				model.defectCode=ds.Tables[0].Rows[0]["defectCode"].ToString();
				if(ds.Tables[0].Rows[0]["rejectQty"].ToString()!="")
				{
					model.rejectQty=decimal.Parse(ds.Tables[0].Rows[0]["rejectQty"].ToString());
				}
				model.rejectQtyHour01=ds.Tables[0].Rows[0]["rejectQtyHour01"].ToString();
				model.rejectQtyHour02=ds.Tables[0].Rows[0]["rejectQtyHour02"].ToString();
				model.rejectQtyHour03=ds.Tables[0].Rows[0]["rejectQtyHour03"].ToString();
				model.rejectQtyHour04=ds.Tables[0].Rows[0]["rejectQtyHour04"].ToString();
				model.rejectQtyHour05=ds.Tables[0].Rows[0]["rejectQtyHour05"].ToString();
				model.rejectQtyHour06=ds.Tables[0].Rows[0]["rejectQtyHour06"].ToString();
				model.rejectQtyHour07=ds.Tables[0].Rows[0]["rejectQtyHour07"].ToString();
				model.rejectQtyHour08=ds.Tables[0].Rows[0]["rejectQtyHour08"].ToString();
				model.rejectQtyHour09=ds.Tables[0].Rows[0]["rejectQtyHour09"].ToString();
				model.rejectQtyHour10=ds.Tables[0].Rows[0]["rejectQtyHour10"].ToString();
				model.rejectQtyHour11=ds.Tables[0].Rows[0]["rejectQtyHour11"].ToString();
				model.rejectQtyHour12=ds.Tables[0].Rows[0]["rejectQtyHour12"].ToString();
				if(ds.Tables[0].Rows[0]["lastUpdatedTime"].ToString()!="")
				{
					model.lastUpdatedTime=DateTime.Parse(ds.Tables[0].Rows[0]["lastUpdatedTime"].ToString());
				}
				model.remarks=ds.Tables[0].Rows[0]["remarks"].ToString();
                if (ds.Tables[0].Rows[0]["QCNGQTY"].ToString() != "")
                {
                    model.QCNGQTY = decimal.Parse(ds.Tables[0].Rows[0]["QCNGQTY"].ToString());
                }
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
			strSql.Append("select id,trackingID,machineID,dateTime,partNumber,jigNo,model,cavityCount,userName,userID,startTime,stopTime,day,shift,status,matPart01,matPart02,matLot01,matLot02,defectCodeID,defectCode,rejectQty,rejectQtyHour01,rejectQtyHour02,rejectQtyHour03,rejectQtyHour04,rejectQtyHour05,rejectQtyHour06,rejectQtyHour07,rejectQtyHour08,rejectQtyHour09,rejectQtyHour10,rejectQtyHour11,rejectQtyHour12,lastUpdatedTime,remarks,QCNGQTY,Material_MHCheck,Material_MHCheckTime,Material_Opcheck,Material_OpCheckTime,Material_LeaderCheck,Material_LeaderCheckTime,LeaderCheck,LeaderCheckTime,SupervisorCheck,SupervisorCheckTime,partNumberAll  ");
			strSql.Append(" FROM MouldingViDefectTracking ");
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
			strSql.Append(" id,trackingID,machineID,dateTime,partNumber,jigNo,model,cavityCount,userName,userID,startTime,stopTime,day,shift,status,matPart01,matPart02,matLot01,matLot02,defectCodeID,defectCode,rejectQty,rejectQtyHour01,rejectQtyHour02,rejectQtyHour03,rejectQtyHour04,rejectQtyHour05,rejectQtyHour06,rejectQtyHour07,rejectQtyHour08,rejectQtyHour09,rejectQtyHour10,rejectQtyHour11,rejectQtyHour12,lastUpdatedTime,remarks,QCNGQTY,Material_MHCheck,Material_MHCheckTime,Material_Opcheck,Material_OpCheckTime,Material_LeaderCheck,Material_LeaderCheckTime,LeaderCheck,LeaderCheckTime,SupervisorCheck,SupervisorCheckTime,partNumberAll  ");
			strSql.Append(" FROM MouldingViDefectTracking ");
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
			parameters[0].Value = "MouldingViDefectTracking";
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
        
        internal MouldingViDefectTracking_Model GetModel_ByDayShiftPartMachine_New(DateTime curDay, string curShift, string spartNumberAll, string machineID)
        //internal DataSet  GetModel_ByDayShiftPartMachine_New(DateTime curDay, string curShift, string spartNumberAll, string machineID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select   id,trackingID,machineID,dateTime,partNumber,jigNo,model,cavityCount,userName,userID,startTime,stopTime,day,shift,status,matPart01,matPart02,matLot01,matLot02,defectCodeID,defectCode,rejectQty,rejectQtyHour01,rejectQtyHour02,rejectQtyHour03,rejectQtyHour04,rejectQtyHour05,rejectQtyHour06,rejectQtyHour07,rejectQtyHour08,rejectQtyHour09,rejectQtyHour10,rejectQtyHour11,rejectQtyHour12,lastUpdatedTime,remarks,QCNGQTY,Material_MHCheck,Material_MHCheckTime,Material_Opcheck,Material_OpCheckTime,Material_LeaderCheck,Material_LeaderCheckTime,LeaderCheck,LeaderCheckTime,SupervisorCheck,SupervisorCheckTime,partNumberAll  from MouldingViDefectTracking ");
            strSql.Append(" where   Day =@Day and Shift=@hift and partNumber = @partNumber  and MachineID = @MachineID");
            SqlParameter[] parameters = {
                    new SqlParameter("@Day", SqlDbType.DateTime),
                    new SqlParameter("@hift", SqlDbType.VarChar, -1),
                    new SqlParameter("@PartNumber", SqlDbType.VarChar , -1 ),
                    new SqlParameter("@MachineID", SqlDbType.VarChar , -1 ),
            };
            parameters[0].Value = curDay;
            parameters[1].Value = curShift;
            parameters[2].Value = spartNumberAll;
            parameters[3].Value = machineID; 

            DBHelp.Reports.LogFile.DebugLog("AUTOCODE", "NameSpace:Common.DAL", "Class:MouldingViDefectTracking_DAL", "Function:		public DataSet GetModel_ByDayShiftPart(DateTime curDay, string curShift, string partNumber, string machineID))" + "TableName:MouldingViTracking", "");
            Common.Model.MouldingViDefectTracking_Model model = new Common.Model.MouldingViDefectTracking_Model();
            DataSet ds = DBHelp.SqlDB.Query(strSql.ToString(), parameters);
            if (ds.Tables[0].Rows.Count > 0)
            {
                if (ds.Tables[0].Rows[0]["id"].ToString() != "")
                {
                    model.id = int.Parse(ds.Tables[0].Rows[0]["id"].ToString());
                }
                model.trackingID = ds.Tables[0].Rows[0]["trackingID"].ToString();
                model.machineID = ds.Tables[0].Rows[0]["machineID"].ToString();
                if (ds.Tables[0].Rows[0]["dateTime"].ToString() != "")
                {
                    model.dateTime = DateTime.Parse(ds.Tables[0].Rows[0]["dateTime"].ToString());
                }
                model.partNumber = ds.Tables[0].Rows[0]["partNumber"].ToString();
                model.jigNo = ds.Tables[0].Rows[0]["jigNo"].ToString();
                model.model = ds.Tables[0].Rows[0]["model"].ToString();
                if (ds.Tables[0].Rows[0]["cavityCount"].ToString() != "")
                {
                    model.cavityCount = decimal.Parse(ds.Tables[0].Rows[0]["cavityCount"].ToString());
                }
                model.userName = ds.Tables[0].Rows[0]["userName"].ToString();
                model.userID = ds.Tables[0].Rows[0]["userID"].ToString();
                if (ds.Tables[0].Rows[0]["startTime"].ToString() != "")
                {
                    model.startTime = DateTime.Parse(ds.Tables[0].Rows[0]["startTime"].ToString());
                }
                if (ds.Tables[0].Rows[0]["stopTime"].ToString() != "")
                {
                    model.stopTime = DateTime.Parse(ds.Tables[0].Rows[0]["stopTime"].ToString());
                }
                if (ds.Tables[0].Rows[0]["day"].ToString() != "")
                {
                    model.day = DateTime.Parse(ds.Tables[0].Rows[0]["day"].ToString());
                }
                model.shift = ds.Tables[0].Rows[0]["shift"].ToString();
                model.status = ds.Tables[0].Rows[0]["status"].ToString();
                model.matPart01 = ds.Tables[0].Rows[0]["matPart01"].ToString();
                model.matPart02 = ds.Tables[0].Rows[0]["matPart02"].ToString();
                model.matLot01 = ds.Tables[0].Rows[0]["matLot01"].ToString();
                model.matLot02 = ds.Tables[0].Rows[0]["matLot02"].ToString();
                model.defectCodeID = ds.Tables[0].Rows[0]["defectCodeID"].ToString();
                model.defectCode = ds.Tables[0].Rows[0]["defectCode"].ToString();
                if (ds.Tables[0].Rows[0]["rejectQty"].ToString() != "")
                {
                    model.rejectQty = decimal.Parse(ds.Tables[0].Rows[0]["rejectQty"].ToString());
                }
                model.rejectQtyHour01 = ds.Tables[0].Rows[0]["rejectQtyHour01"].ToString();
                model.rejectQtyHour02 = ds.Tables[0].Rows[0]["rejectQtyHour02"].ToString();
                model.rejectQtyHour03 = ds.Tables[0].Rows[0]["rejectQtyHour03"].ToString();
                model.rejectQtyHour04 = ds.Tables[0].Rows[0]["rejectQtyHour04"].ToString();
                model.rejectQtyHour05 = ds.Tables[0].Rows[0]["rejectQtyHour05"].ToString();
                model.rejectQtyHour06 = ds.Tables[0].Rows[0]["rejectQtyHour06"].ToString();
                model.rejectQtyHour07 = ds.Tables[0].Rows[0]["rejectQtyHour07"].ToString();
                model.rejectQtyHour08 = ds.Tables[0].Rows[0]["rejectQtyHour08"].ToString();
                model.rejectQtyHour09 = ds.Tables[0].Rows[0]["rejectQtyHour09"].ToString();
                model.rejectQtyHour10 = ds.Tables[0].Rows[0]["rejectQtyHour10"].ToString();
                model.rejectQtyHour11 = ds.Tables[0].Rows[0]["rejectQtyHour11"].ToString();
                model.rejectQtyHour12 = ds.Tables[0].Rows[0]["rejectQtyHour12"].ToString();
                if (ds.Tables[0].Rows[0]["lastUpdatedTime"].ToString() != "")
                {
                    model.lastUpdatedTime = DateTime.Parse(ds.Tables[0].Rows[0]["lastUpdatedTime"].ToString());
                }
                model.remarks = ds.Tables[0].Rows[0]["remarks"].ToString();
                if (ds.Tables[0].Rows[0]["QCNGQTY"].ToString() != "")
                {
                    model.QCNGQTY = decimal.Parse(ds.Tables[0].Rows[0]["QCNGQTY"].ToString());
                }
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
                return model;
            }
            else
            {
                return null;
            }
        }

        internal DataSet GetModel_ByDayShiftPartMachine(DateTime curDay, string curShift, string partNumber, string machineID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select   id,trackingID,machineID,dateTime,partNumber,jigNo,model,cavityCount,userName,userID,startTime,stopTime,day,shift,status,matPart01,matPart02,matLot01,matLot02,defectCodeID,defectCode,rejectQty,rejectQtyHour01,rejectQtyHour02,rejectQtyHour03,rejectQtyHour04,rejectQtyHour05,rejectQtyHour06,rejectQtyHour07,rejectQtyHour08,rejectQtyHour09,rejectQtyHour10,rejectQtyHour11,rejectQtyHour12,lastUpdatedTime,remarks,QCNGQTY,Material_MHCheck,Material_MHCheckTime,Material_Opcheck,Material_OpCheckTime,Material_LeaderCheck,Material_LeaderCheckTime,LeaderCheck,LeaderCheckTime,SupervisorCheck,SupervisorCheckTime,partNumberAll  from MouldingViDefectTracking ");
            strSql.Append(" where   Day =@Day and Shift=@hift and PartNumber = @PartNumber  and MachineID = @MachineID");
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

            DBHelp.Reports.LogFile.DebugLog("AUTOCODE", "NameSpace:Common.DAL", "Class:MouldingViDefectTracking_DAL", "Function:		public DataSet GetModel_ByDayShiftPart(DateTime curDay, string curShift, string partNumber, string machineID))" + "TableName:MouldingViTracking", "");
            Common.Model.MouldingViTracking_Model model = new Common.Model.MouldingViTracking_Model();
            DataSet ds = DBHelp.SqlDB.Query(strSql.ToString(), parameters);

            return ds;
        }

        internal MouldingViDefectTracking_Model GetModel_ByDayShiftPartMachineForDefectTracking(DateTime? curDay, string curShift, string partNumber, string machineID,string defectcode, MouldingViDefectTracking_Model objViDef)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select TOP 1  id,trackingID,machineID,dateTime,partNumber,jigNo,model,cavityCount,userName,userID,startTime,stopTime,day,shift,status,matPart01,matPart02,matLot01,matLot02,defectCodeID,defectCode,rejectQty,rejectQtyHour01,rejectQtyHour02,rejectQtyHour03,rejectQtyHour04,rejectQtyHour05,rejectQtyHour06,rejectQtyHour07,rejectQtyHour08,rejectQtyHour09,rejectQtyHour10,rejectQtyHour11,rejectQtyHour12,lastUpdatedTime,remarks,QCNGQTY,Material_MHCheck,Material_MHCheckTime,Material_Opcheck,Material_OpCheckTime,Material_LeaderCheck,Material_LeaderCheckTime,LeaderCheck,LeaderCheckTime,SupervisorCheck,SupervisorCheckTime,partNumberAll  from MouldingViDefectTracking ");
            strSql.Append(" where   Day =@Day and Shift=@hift and PartNumber = @PartNumber  and MachineID = @MachineID and defectCode=@defectCode");
            //2018 12 04 same data just status different
            strSql.Append(" order by dateTime desc  ");
            SqlParameter[] parameters = {
                    new SqlParameter("@Day", SqlDbType.DateTime),
                    new SqlParameter("@hift", SqlDbType.VarChar, -1),
                    new SqlParameter("@PartNumber", SqlDbType.VarChar , -1 ),
                    new SqlParameter("@MachineID", SqlDbType.VarChar , -1 ),
                    new SqlParameter("@defectCode", SqlDbType.VarChar , -1 ),
            };
            parameters[0].Value = curDay;
            parameters[1].Value = curShift;
            parameters[2].Value = partNumber;
            parameters[3].Value = machineID;
            parameters[4].Value = defectcode;

            DBHelp.Reports.LogFile.DebugLog("AUTOCODE", "NameSpace:Common.DAL", "Class:MouldingViDefectTracking_DAL", "Function:		public DataSet GetModel_ByDayShiftPart(DateTime curDay, string curShift, string partNumber, string machineID))" + "TableName:MouldingViTracking", "");
            Common.Model.MouldingViDefectTracking_Model model = new Common.Model.MouldingViDefectTracking_Model();
            DataSet ds = DBHelp.SqlDB.Query(strSql.ToString(), parameters);
            if (ds.Tables[0].Rows.Count > 0)
            {
                if (ds.Tables[0].Rows[0]["id"].ToString() != "")
                {
                    model.id = int.Parse(ds.Tables[0].Rows[0]["id"].ToString());
                }
                model.trackingID = ds.Tables[0].Rows[0]["trackingID"].ToString();
                model.machineID = ds.Tables[0].Rows[0]["machineID"].ToString();
                if (ds.Tables[0].Rows[0]["dateTime"].ToString() != "")
                {
                    model.dateTime = DateTime.Parse(ds.Tables[0].Rows[0]["dateTime"].ToString());
                }
                model.partNumber = ds.Tables[0].Rows[0]["partNumber"].ToString();
                model.jigNo = ds.Tables[0].Rows[0]["jigNo"].ToString();
                model.model = ds.Tables[0].Rows[0]["model"].ToString();
                if (ds.Tables[0].Rows[0]["cavityCount"].ToString() != "")
                {
                    model.cavityCount = decimal.Parse(ds.Tables[0].Rows[0]["cavityCount"].ToString());
                }
                model.userName = ds.Tables[0].Rows[0]["userName"].ToString();
                model.userID = ds.Tables[0].Rows[0]["userID"].ToString();
                if (ds.Tables[0].Rows[0]["startTime"].ToString() != "")
                {
                    model.startTime = DateTime.Parse(ds.Tables[0].Rows[0]["startTime"].ToString());
                }
                if (ds.Tables[0].Rows[0]["stopTime"].ToString() != "")
                {
                    model.stopTime = objViDef.stopTime;
                }
                if (ds.Tables[0].Rows[0]["day"].ToString() != "")
                {
                    model.day = DateTime.Parse(ds.Tables[0].Rows[0]["day"].ToString());
                }
                model.shift = ds.Tables[0].Rows[0]["shift"].ToString();
                model.status = ds.Tables[0].Rows[0]["status"].ToString();
                model.matPart01 = ds.Tables[0].Rows[0]["matPart01"].ToString();
                model.matPart02 = ds.Tables[0].Rows[0]["matPart02"].ToString();
                model.matLot01 = ds.Tables[0].Rows[0]["matLot01"].ToString();
                model.matLot02 = ds.Tables[0].Rows[0]["matLot02"].ToString();
                model.defectCodeID = ds.Tables[0].Rows[0]["defectCodeID"].ToString();
                model.defectCode = ds.Tables[0].Rows[0]["defectCode"].ToString();
                //if (ds.Tables[0].Rows[0]["rejectQty"].ToString() != "")
                //{
                //    model.rejectQty = objViDef.rejectQty;
                //}
                //model.rejectQtyHour01 = objViDef.rejectQtyHour01;
                //model.rejectQtyHour02 = objViDef.rejectQtyHour02;
                //model.rejectQtyHour03 = objViDef.rejectQtyHour03;
                //model.rejectQtyHour04 = objViDef.rejectQtyHour04;
                //model.rejectQtyHour05 = objViDef.rejectQtyHour05;
                //model.rejectQtyHour06 = objViDef.rejectQtyHour06;
                //model.rejectQtyHour07 = objViDef.rejectQtyHour07;
                //model.rejectQtyHour08 = objViDef.rejectQtyHour08;
                //model.rejectQtyHour09 = objViDef.rejectQtyHour09;
                //model.rejectQtyHour10 = objViDef.rejectQtyHour10;
                //model.rejectQtyHour11 = objViDef.rejectQtyHour11;
                //model.rejectQtyHour12 = objViDef.rejectQtyHour12;
                //if (ds.Tables[0].Rows[0]["lastUpdatedTime"].ToString() != "")
                //{
                //    model.lastUpdatedTime = objViDef.lastUpdatedTime;
                //}

                if (ds.Tables[0].Rows[0]["rejectQty"].ToString() != "")
                {
                    model.rejectQty = decimal.Parse(ds.Tables[0].Rows[0]["rejectQty"].ToString());
                }
                model.rejectQtyHour01 = ds.Tables[0].Rows[0]["rejectQtyHour01"].ToString();
                model.rejectQtyHour02 = ds.Tables[0].Rows[0]["rejectQtyHour02"].ToString();
                model.rejectQtyHour03 = ds.Tables[0].Rows[0]["rejectQtyHour03"].ToString();
                model.rejectQtyHour04 = ds.Tables[0].Rows[0]["rejectQtyHour04"].ToString();
                model.rejectQtyHour05 = ds.Tables[0].Rows[0]["rejectQtyHour05"].ToString();
                model.rejectQtyHour06 = ds.Tables[0].Rows[0]["rejectQtyHour06"].ToString();
                model.rejectQtyHour07 = ds.Tables[0].Rows[0]["rejectQtyHour07"].ToString();
                model.rejectQtyHour08 = ds.Tables[0].Rows[0]["rejectQtyHour08"].ToString();
                model.rejectQtyHour09 = ds.Tables[0].Rows[0]["rejectQtyHour09"].ToString();
                model.rejectQtyHour10 = ds.Tables[0].Rows[0]["rejectQtyHour10"].ToString();
                model.rejectQtyHour11 = ds.Tables[0].Rows[0]["rejectQtyHour11"].ToString();
                model.rejectQtyHour12 = ds.Tables[0].Rows[0]["rejectQtyHour12"].ToString();
                if (ds.Tables[0].Rows[0]["lastUpdatedTime"].ToString() != "")
                {
                    model.lastUpdatedTime = DateTime.Parse(ds.Tables[0].Rows[0]["lastUpdatedTime"].ToString());
                }

                model.remarks = ds.Tables[0].Rows[0]["remarks"].ToString();
                if (ds.Tables[0].Rows[0]["QCNGQTY"].ToString() != "")
                {
                    model.QCNGQTY = decimal.Parse(ds.Tables[0].Rows[0]["QCNGQTY"].ToString());
                }
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
                model.partnumberall = ds.Tables[0].Rows[0]["partNumberAll"].ToString();
                return model;
            }
            else
            {
                return null;
            }
        }


        internal DataSet GetModel_ByDayShiftPartMachineDefCode(DateTime curDay, string curShift, string partNumber, string defectCode, string machineID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 id,trackingID,machineID,dateTime,partNumber,jigNo,model,cavityCount,userName,userID,startTime,stopTime,day,shift,status,matPart01,matPart02,matLot01,matLot02,defectCodeID,defectCode,rejectQty,rejectQtyHour01,rejectQtyHour02,rejectQtyHour03,rejectQtyHour04,rejectQtyHour05,rejectQtyHour06,rejectQtyHour07,rejectQtyHour08,rejectQtyHour09,rejectQtyHour10,rejectQtyHour11,rejectQtyHour12,lastUpdatedTime,remarks,QCNGQTY,Material_MHCheck,Material_MHCheckTime,Material_Opcheck,Material_OpCheckTime,Material_LeaderCheck,Material_LeaderCheckTime,LeaderCheck,LeaderCheckTime,SupervisorCheck,SupervisorCheckTime,partNumberAll  from MouldingViDefectTracking ");
            strSql.Append(" where   Day =@Day and Shift=@hift and PartNumber = @PartNumber and defectCode = @defectCode   and MachineID = @MachineID");
 
            SqlParameter[] parameters = {
                    new SqlParameter("@Day", SqlDbType.DateTime),
                    new SqlParameter("@hift", SqlDbType.VarChar, -1),
                    new SqlParameter("@PartNumber", SqlDbType.VarChar , -1 ),
                    new SqlParameter("@defectCode", SqlDbType.VarChar , -1 ),
                    new SqlParameter("@MachineID", SqlDbType.VarChar , -1 ),
            };
            parameters[0].Value = curDay;
            parameters[1].Value = curShift;
            parameters[2].Value = partNumber;
            parameters[3].Value = defectCode;
            parameters[4].Value = machineID;
            DBHelp.Reports.LogFile.DebugLog("AUTOCODE", "NameSpace:Common.DAL", "Class:MouldingViDefectTracking_DAL", "Function:		public DataSet GetModel_ByDayShiftPartDefCode(DateTime curDay, string curShift, string partNumber, string machineID))" + "TableName:MouldingViTracking", "");
            Common.Model.MouldingViTracking_Model model = new Common.Model.MouldingViTracking_Model();
            DataSet ds = DBHelp.SqlDB.Query(strSql.ToString(), parameters);

            return ds;
        }
        #endregion
    }
}


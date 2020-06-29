using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using DBHelp;
namespace Common.DAL
{
    /// <summary>
    /// 数据访问类:MouldingPqm_DAL
    /// </summary>
    public class MouldingPqm_DAL
    {
        public MouldingPqm_DAL()
        { }
        #region  Method

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public DataSet Exists(string machineID, DateTime? updatedTime, decimal totalQTY, decimal tempature11, decimal tempature12, decimal tempature13, decimal tempature14, decimal tempature15, decimal tempature21, decimal tempature22, decimal tempature23, decimal tempature24, decimal tempature25, string status1, string status2, string partNumber, string matPart01, string matPart02, string customer, string model, string jigNo, decimal cavityCount, decimal partsWeight, decimal cycleTime, int blockCount, int unitCount, string userName, string remarks, string refField01, string refField02, string refField03, string refField04, string refField05, string refField06, string refField07, string refField08, string refField09, string refField10, string refField11, string refField12, string refField13, string refField14, string refField15, string refField16, string refField17, string refField18, string refField19, string refField20)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from MouldingPqm");
            strSql.Append(" where ");
            SqlParameter[] parameters = {
};

            return DBHelp.SqlDB.Query(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public void Add(Common.Model.MouldingPqm_Model model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into MouldingPqm(");
            strSql.Append("machineID,updatedTime,totalQTY,tempature11,tempature12,tempature13,tempature14,tempature15,tempature21,tempature22,tempature23,tempature24,tempature25,status1,status2,partNumber,matPart01,matPart02,customer,model,jigNo,cavityCount,partsWeight,cycleTime,blockCount,unitCount,userName,remarks,refField01,refField02,refField03,refField04,refField05,refField06,refField07,refField08,refField09,refField10,refField11,refField12,refField13,refField14,refField15,refField16,refField17,refField18,refField19,refField20)");
            strSql.Append(" values (");
            strSql.Append("@machineID,@updatedTime,@totalQTY,@tempature11,@tempature12,@tempature13,@tempature14,@tempature15,@tempature21,@tempature22,@tempature23,@tempature24,@tempature25,@status1,@status2,@partNumber,@matPart01,@matPart02,@customer,@model,@jigNo,@cavityCount,@partsWeight,@cycleTime,@blockCount,@unitCount,@userName,@remarks,@refField01,@refField02,@refField03,@refField04,@refField05,@refField06,@refField07,@refField08,@refField09,@refField10,@refField11,@refField12,@refField13,@refField14,@refField15,@refField16,@refField17,@refField18,@refField19,@refField20)");
            SqlParameter[] parameters = {
                    new SqlParameter("@machineID", SqlDbType.VarChar,8),
                    new SqlParameter("@updatedTime", SqlDbType.DateTime2,8),
                    new SqlParameter("@totalQTY", SqlDbType.Decimal,9),
                    new SqlParameter("@tempature11", SqlDbType.Decimal,9),
                    new SqlParameter("@tempature12", SqlDbType.Decimal,9),
                    new SqlParameter("@tempature13", SqlDbType.Decimal,9),
                    new SqlParameter("@tempature14", SqlDbType.Decimal,9),
                    new SqlParameter("@tempature15", SqlDbType.Decimal,9),
                    new SqlParameter("@tempature21", SqlDbType.Decimal,9),
                    new SqlParameter("@tempature22", SqlDbType.Decimal,9),
                    new SqlParameter("@tempature23", SqlDbType.Decimal,9),
                    new SqlParameter("@tempature24", SqlDbType.Decimal,9),
                    new SqlParameter("@tempature25", SqlDbType.Decimal,9),
                    new SqlParameter("@status1", SqlDbType.VarChar,50),
                    new SqlParameter("@status2", SqlDbType.VarChar,50),
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
                    new SqlParameter("@userName", SqlDbType.VarChar,50),
                    new SqlParameter("@remarks", SqlDbType.VarChar,500),
                    new SqlParameter("@refField01", SqlDbType.VarChar,50),
                    new SqlParameter("@refField02", SqlDbType.VarChar,50),
                    new SqlParameter("@refField03", SqlDbType.VarChar,50),
                    new SqlParameter("@refField04", SqlDbType.VarChar,50),
                    new SqlParameter("@refField05", SqlDbType.VarChar,50),
                    new SqlParameter("@refField06", SqlDbType.VarChar,50),
                    new SqlParameter("@refField07", SqlDbType.VarChar,50),
                    new SqlParameter("@refField08", SqlDbType.VarChar,50),
                    new SqlParameter("@refField09", SqlDbType.VarChar,50),
                    new SqlParameter("@refField10", SqlDbType.VarChar,50),
                    new SqlParameter("@refField11", SqlDbType.VarChar,50),
                    new SqlParameter("@refField12", SqlDbType.VarChar,50),
                    new SqlParameter("@refField13", SqlDbType.VarChar,50),
                    new SqlParameter("@refField14", SqlDbType.VarChar,50),
                    new SqlParameter("@refField15", SqlDbType.VarChar,50),
                    new SqlParameter("@refField16", SqlDbType.VarChar,100),
                    new SqlParameter("@refField17", SqlDbType.VarChar,100),
                    new SqlParameter("@refField18", SqlDbType.VarChar,200),
                    new SqlParameter("@refField19", SqlDbType.VarChar,200),
                    new SqlParameter("@refField20", SqlDbType.VarChar,500)};
            DBHelp.Reports.LogFile.DebugLog("AUTOCODE", "NameSpace:Common.DAL", "Class:MouldingPqm_DAL", "Function:		public void Add(Common.Model.MouldingPqm_Model model)" + "TableName:MouldingPqm", ";machineID = " + model.machineID.ToString() + ";updatedTime = " + model.updatedTime.ToString() + ";totalQTY = " + model.totalQTY.ToString() + ";tempature11 = " + model.tempature11.ToString() + ";tempature12 = " + model.tempature12.ToString() + ";tempature13 = " + model.tempature13.ToString() + ";tempature14 = " + model.tempature14.ToString() + ";tempature15 = " + model.tempature15.ToString() + ";tempature21 = " + model.tempature21.ToString() + ";tempature22 = " + model.tempature22.ToString() + ";tempature23 = " + model.tempature23.ToString() + ";tempature24 = " + model.tempature24.ToString() + ";tempature25 = " + model.tempature25.ToString() + ";status1 = " + model.status1.ToString() + ";status2 = " + model.status2.ToString() + ";partNumber = " + model.partNumber.ToString() + ";matPart01 = " + model.matPart01.ToString() + ";matPart02 = " + model.matPart02.ToString() + ";customer = " + model.customer.ToString() + ";model = " + model.model.ToString() + ";jigNo = " + model.jigNo.ToString() + ";cavityCount = " + model.cavityCount.ToString() + ";partsWeight = " + model.partsWeight.ToString() + ";cycleTime = " + model.cycleTime.ToString() + ";blockCount = " + model.blockCount.ToString() + ";unitCount = " + model.unitCount.ToString() + ";userName = " + model.userName.ToString() + ";remarks = " + model.remarks.ToString() + ";refField01 = " + model.refField01.ToString() + ";refField02 = " + model.refField02.ToString() + ";refField03 = " + model.refField03.ToString() + ";refField04 = " + model.refField04.ToString() + ";refField05 = " + model.refField05.ToString() + ";refField06 = " + model.refField06.ToString() + ";refField07 = " + model.refField07.ToString() + ";refField08 = " + model.refField08.ToString() + ";refField09 = " + model.refField09.ToString() + ";refField10 = " + model.refField10.ToString() + ";refField11 = " + model.refField11.ToString() + ";refField12 = " + model.refField12.ToString() + ";refField13 = " + model.refField13.ToString() + ";refField14 = " + model.refField14.ToString() + ";refField15 = " + model.refField15.ToString() + ";refField16 = " + model.refField16.ToString() + ";refField17 = " + model.refField17.ToString() + ";refField18 = " + model.refField18.ToString() + ";refField19 = " + model.refField19.ToString() + ";refField20 = " + model.refField20.ToString() + "");
            parameters[0].Value = model.machineID;
            parameters[1].Value = model.updatedTime;
            parameters[2].Value = model.totalQTY;
            parameters[3].Value = model.tempature11;
            parameters[4].Value = model.tempature12;
            parameters[5].Value = model.tempature13;
            parameters[6].Value = model.tempature14;
            parameters[7].Value = model.tempature15;
            parameters[8].Value = model.tempature21;
            parameters[9].Value = model.tempature22;
            parameters[10].Value = model.tempature23;
            parameters[11].Value = model.tempature24;
            parameters[12].Value = model.tempature25;
            parameters[13].Value = model.status1;
            parameters[14].Value = model.status2;
            parameters[15].Value = model.partNumber;
            parameters[16].Value = model.matPart01;
            parameters[17].Value = model.matPart02;
            parameters[18].Value = model.customer;
            parameters[19].Value = model.model;
            parameters[20].Value = model.jigNo;
            parameters[21].Value = model.cavityCount;
            parameters[22].Value = model.partsWeight;
            parameters[23].Value = model.cycleTime;
            parameters[24].Value = model.blockCount;
            parameters[25].Value = model.unitCount;
            parameters[26].Value = model.userName;
            parameters[27].Value = model.remarks;
            parameters[28].Value = model.refField01;
            parameters[29].Value = model.refField02;
            parameters[30].Value = model.refField03;
            parameters[31].Value = model.refField04;
            parameters[32].Value = model.refField05;
            parameters[33].Value = model.refField06;
            parameters[34].Value = model.refField07;
            parameters[35].Value = model.refField08;
            parameters[36].Value = model.refField09;
            parameters[37].Value = model.refField10;
            parameters[38].Value = model.refField11;
            parameters[39].Value = model.refField12;
            parameters[40].Value = model.refField13;
            parameters[41].Value = model.refField14;
            parameters[42].Value = model.refField15;
            parameters[43].Value = model.refField16;
            parameters[44].Value = model.refField17;
            parameters[45].Value = model.refField18;
            parameters[46].Value = model.refField19;
            parameters[47].Value = model.refField20;

            DBHelp.SqlDB.ExecuteSql(strSql.ToString(), parameters);
        }
        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(Common.Model.MouldingPqm_Model model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update MouldingPqm set ");
            strSql.Append("machineID=@machineID,");
            strSql.Append("updatedTime=@updatedTime,");
            strSql.Append("totalQTY=@totalQTY,");
            strSql.Append("tempature11=@tempature11,");
            strSql.Append("tempature12=@tempature12,");
            strSql.Append("tempature13=@tempature13,");
            strSql.Append("tempature14=@tempature14,");
            strSql.Append("tempature15=@tempature15,");
            strSql.Append("tempature21=@tempature21,");
            strSql.Append("tempature22=@tempature22,");
            strSql.Append("tempature23=@tempature23,");
            strSql.Append("tempature24=@tempature24,");
            strSql.Append("tempature25=@tempature25,");
            strSql.Append("status1=@status1,");
            strSql.Append("status2=@status2,");
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
            strSql.Append("userName=@userName,");
            strSql.Append("remarks=@remarks,");
            strSql.Append("refField01=@refField01,");
            strSql.Append("refField02=@refField02,");
            strSql.Append("refField03=@refField03,");
            strSql.Append("refField04=@refField04,");
            strSql.Append("refField05=@refField05,");
            strSql.Append("refField06=@refField06,");
            strSql.Append("refField07=@refField07,");
            strSql.Append("refField08=@refField08,");
            strSql.Append("refField09=@refField09,");
            strSql.Append("refField10=@refField10,");
            strSql.Append("refField11=@refField11,");
            strSql.Append("refField12=@refField12,");
            strSql.Append("refField13=@refField13,");
            strSql.Append("refField14=@refField14,");
            strSql.Append("refField15=@refField15,");
            strSql.Append("refField16=@refField16,");
            strSql.Append("refField17=@refField17,");
            strSql.Append("refField18=@refField18,");
            strSql.Append("refField19=@refField19,");
            strSql.Append("refField20=@refField20");
            strSql.Append(" where ");
            SqlParameter[] parameters = {
                    new SqlParameter("@machineID", SqlDbType.VarChar,8),
                    new SqlParameter("@updatedTime", SqlDbType.DateTime2,8),
                    new SqlParameter("@totalQTY", SqlDbType.Decimal,9),
                    new SqlParameter("@tempature11", SqlDbType.Decimal,9),
                    new SqlParameter("@tempature12", SqlDbType.Decimal,9),
                    new SqlParameter("@tempature13", SqlDbType.Decimal,9),
                    new SqlParameter("@tempature14", SqlDbType.Decimal,9),
                    new SqlParameter("@tempature15", SqlDbType.Decimal,9),
                    new SqlParameter("@tempature21", SqlDbType.Decimal,9),
                    new SqlParameter("@tempature22", SqlDbType.Decimal,9),
                    new SqlParameter("@tempature23", SqlDbType.Decimal,9),
                    new SqlParameter("@tempature24", SqlDbType.Decimal,9),
                    new SqlParameter("@tempature25", SqlDbType.Decimal,9),
                    new SqlParameter("@status1", SqlDbType.VarChar,50),
                    new SqlParameter("@status2", SqlDbType.VarChar,50),
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
                    new SqlParameter("@userName", SqlDbType.VarChar,50),
                    new SqlParameter("@remarks", SqlDbType.VarChar,500),
                    new SqlParameter("@refField01", SqlDbType.VarChar,50),
                    new SqlParameter("@refField02", SqlDbType.VarChar,50),
                    new SqlParameter("@refField03", SqlDbType.VarChar,50),
                    new SqlParameter("@refField04", SqlDbType.VarChar,50),
                    new SqlParameter("@refField05", SqlDbType.VarChar,50),
                    new SqlParameter("@refField06", SqlDbType.VarChar,50),
                    new SqlParameter("@refField07", SqlDbType.VarChar,50),
                    new SqlParameter("@refField08", SqlDbType.VarChar,50),
                    new SqlParameter("@refField09", SqlDbType.VarChar,50),
                    new SqlParameter("@refField10", SqlDbType.VarChar,50),
                    new SqlParameter("@refField11", SqlDbType.VarChar,50),
                    new SqlParameter("@refField12", SqlDbType.VarChar,50),
                    new SqlParameter("@refField13", SqlDbType.VarChar,50),
                    new SqlParameter("@refField14", SqlDbType.VarChar,50),
                    new SqlParameter("@refField15", SqlDbType.VarChar,50),
                    new SqlParameter("@refField16", SqlDbType.VarChar,100),
                    new SqlParameter("@refField17", SqlDbType.VarChar,100),
                    new SqlParameter("@refField18", SqlDbType.VarChar,200),
                    new SqlParameter("@refField19", SqlDbType.VarChar,200),
                    new SqlParameter("@refField20", SqlDbType.VarChar,500)};
            parameters[0].Value = model.machineID;
            parameters[1].Value = model.updatedTime;
            parameters[2].Value = model.totalQTY;
            parameters[3].Value = model.tempature11;
            parameters[4].Value = model.tempature12;
            parameters[5].Value = model.tempature13;
            parameters[6].Value = model.tempature14;
            parameters[7].Value = model.tempature15;
            parameters[8].Value = model.tempature21;
            parameters[9].Value = model.tempature22;
            parameters[10].Value = model.tempature23;
            parameters[11].Value = model.tempature24;
            parameters[12].Value = model.tempature25;
            parameters[13].Value = model.status1;
            parameters[14].Value = model.status2;
            parameters[15].Value = model.partNumber;
            parameters[16].Value = model.matPart01;
            parameters[17].Value = model.matPart02;
            parameters[18].Value = model.customer;
            parameters[19].Value = model.model;
            parameters[20].Value = model.jigNo;
            parameters[21].Value = model.cavityCount;
            parameters[22].Value = model.partsWeight;
            parameters[23].Value = model.cycleTime;
            parameters[24].Value = model.blockCount;
            parameters[25].Value = model.unitCount;
            parameters[26].Value = model.userName;
            parameters[27].Value = model.remarks;
            parameters[28].Value = model.refField01;
            parameters[29].Value = model.refField02;
            parameters[30].Value = model.refField03;
            parameters[31].Value = model.refField04;
            parameters[32].Value = model.refField05;
            parameters[33].Value = model.refField06;
            parameters[34].Value = model.refField07;
            parameters[35].Value = model.refField08;
            parameters[36].Value = model.refField09;
            parameters[37].Value = model.refField10;
            parameters[38].Value = model.refField11;
            parameters[39].Value = model.refField12;
            parameters[40].Value = model.refField13;
            parameters[41].Value = model.refField14;
            parameters[42].Value = model.refField15;
            parameters[43].Value = model.refField16;
            parameters[44].Value = model.refField17;
            parameters[45].Value = model.refField18;
            parameters[46].Value = model.refField19;
            parameters[47].Value = model.refField20;

            DBHelp.Reports.LogFile.DebugLog("AUTOCODE", "NameSpace:Common.DAL", "Class:MouldingPqm_DAL", "Function:		public bool Update(Common.Model.MouldingPqm_Model model)" + "TableName:MouldingPqm", ";machineID = " + model.machineID.ToString() + ";updatedTime = " + model.updatedTime.ToString() + ";totalQTY = " + model.totalQTY.ToString() + ";tempature11 = " + model.tempature11.ToString() + ";tempature12 = " + model.tempature12.ToString() + ";tempature13 = " + model.tempature13.ToString() + ";tempature14 = " + model.tempature14.ToString() + ";tempature15 = " + model.tempature15.ToString() + ";tempature21 = " + model.tempature21.ToString() + ";tempature22 = " + model.tempature22.ToString() + ";tempature23 = " + model.tempature23.ToString() + ";tempature24 = " + model.tempature24.ToString() + ";tempature25 = " + model.tempature25.ToString() + ";status1 = " + model.status1.ToString() + ";status2 = " + model.status2.ToString() + ";partNumber = " + model.partNumber.ToString() + ";matPart01 = " + model.matPart01.ToString() + ";matPart02 = " + model.matPart02.ToString() + ";customer = " + model.customer.ToString() + ";model = " + model.model.ToString() + ";jigNo = " + model.jigNo.ToString() + ";cavityCount = " + model.cavityCount.ToString() + ";partsWeight = " + model.partsWeight.ToString() + ";cycleTime = " + model.cycleTime.ToString() + ";blockCount = " + model.blockCount.ToString() + ";unitCount = " + model.unitCount.ToString() + ";userName = " + model.userName.ToString() + ";remarks = " + model.remarks.ToString() + ";refField01 = " + model.refField01.ToString() + ";refField02 = " + model.refField02.ToString() + ";refField03 = " + model.refField03.ToString() + ";refField04 = " + model.refField04.ToString() + ";refField05 = " + model.refField05.ToString() + ";refField06 = " + model.refField06.ToString() + ";refField07 = " + model.refField07.ToString() + ";refField08 = " + model.refField08.ToString() + ";refField09 = " + model.refField09.ToString() + ";refField10 = " + model.refField10.ToString() + ";refField11 = " + model.refField11.ToString() + ";refField12 = " + model.refField12.ToString() + ";refField13 = " + model.refField13.ToString() + ";refField14 = " + model.refField14.ToString() + ";refField15 = " + model.refField15.ToString() + ";refField16 = " + model.refField16.ToString() + ";refField17 = " + model.refField17.ToString() + ";refField18 = " + model.refField18.ToString() + ";refField19 = " + model.refField19.ToString() + ";refField20 = " + model.refField20.ToString() + "");
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

        public SqlCommand UpdateCommand(Common.Model.MouldingPqm_Model model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update MouldingPqm set ");
            strSql.Append("machineID=@machineID,");
            strSql.Append("updatedTime=@updatedTime,");
            strSql.Append("totalQTY=@totalQTY,");
            strSql.Append("tempature11=@tempature11,");
            strSql.Append("tempature12=@tempature12,");
            strSql.Append("tempature13=@tempature13,");
            strSql.Append("tempature14=@tempature14,");
            strSql.Append("tempature15=@tempature15,");
            strSql.Append("tempature21=@tempature21,");
            strSql.Append("tempature22=@tempature22,");
            strSql.Append("tempature23=@tempature23,");
            strSql.Append("tempature24=@tempature24,");
            strSql.Append("tempature25=@tempature25,");
            strSql.Append("status1=@status1,");
            strSql.Append("status2=@status2,");
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
            strSql.Append("userName=@userName,");
            strSql.Append("remarks=@remarks,");
            strSql.Append("refField01=@refField01,");
            strSql.Append("refField02=@refField02,");
            strSql.Append("refField03=@refField03,");
            strSql.Append("refField04=@refField04,");
            strSql.Append("refField05=@refField05,");
            strSql.Append("refField06=@refField06,");
            strSql.Append("refField07=@refField07,");
            strSql.Append("refField08=@refField08,");
            strSql.Append("refField09=@refField09,");
            strSql.Append("refField10=@refField10,");
            strSql.Append("refField11=@refField11,");
            strSql.Append("refField12=@refField12,");
            strSql.Append("refField13=@refField13,");
            strSql.Append("refField14=@refField14,");
            strSql.Append("refField15=@refField15,");
            strSql.Append("refField16=@refField16,");
            strSql.Append("refField17=@refField17,");
            strSql.Append("refField18=@refField18,");
            strSql.Append("refField19=@refField19,");
            strSql.Append("refField20=@refField20");
            strSql.Append(" where ");
            strSql.Append("machineID=@machineID");
            SqlParameter[] parameters = {
                    new SqlParameter("@machineID", SqlDbType.VarChar,8),
                    new SqlParameter("@updatedTime", SqlDbType.DateTime2,8),
                    new SqlParameter("@totalQTY", SqlDbType.Decimal,9),
                    new SqlParameter("@tempature11", SqlDbType.Decimal,9),
                    new SqlParameter("@tempature12", SqlDbType.Decimal,9),
                    new SqlParameter("@tempature13", SqlDbType.Decimal,9),
                    new SqlParameter("@tempature14", SqlDbType.Decimal,9),
                    new SqlParameter("@tempature15", SqlDbType.Decimal,9),
                    new SqlParameter("@tempature21", SqlDbType.Decimal,9),
                    new SqlParameter("@tempature22", SqlDbType.Decimal,9),
                    new SqlParameter("@tempature23", SqlDbType.Decimal,9),
                    new SqlParameter("@tempature24", SqlDbType.Decimal,9),
                    new SqlParameter("@tempature25", SqlDbType.Decimal,9),
                    new SqlParameter("@status1", SqlDbType.VarChar,50),
                    new SqlParameter("@status2", SqlDbType.VarChar,50),
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
                    new SqlParameter("@userName", SqlDbType.VarChar,50),
                    new SqlParameter("@remarks", SqlDbType.VarChar,500),
                    new SqlParameter("@refField01", SqlDbType.VarChar,50),
                    new SqlParameter("@refField02", SqlDbType.VarChar,50),
                    new SqlParameter("@refField03", SqlDbType.VarChar,50),
                    new SqlParameter("@refField04", SqlDbType.VarChar,50),
                    new SqlParameter("@refField05", SqlDbType.VarChar,50),
                    new SqlParameter("@refField06", SqlDbType.VarChar,50),
                    new SqlParameter("@refField07", SqlDbType.VarChar,50),
                    new SqlParameter("@refField08", SqlDbType.VarChar,50),
                    new SqlParameter("@refField09", SqlDbType.VarChar,50),
                    new SqlParameter("@refField10", SqlDbType.VarChar,50),
                    new SqlParameter("@refField11", SqlDbType.VarChar,50),
                    new SqlParameter("@refField12", SqlDbType.VarChar,50),
                    new SqlParameter("@refField13", SqlDbType.VarChar,50),
                    new SqlParameter("@refField14", SqlDbType.VarChar,50),
                    new SqlParameter("@refField15", SqlDbType.VarChar,50),
                    new SqlParameter("@refField16", SqlDbType.VarChar,100),
                    new SqlParameter("@refField17", SqlDbType.VarChar,100),
                    new SqlParameter("@refField18", SqlDbType.VarChar,200),
                    new SqlParameter("@refField19", SqlDbType.VarChar,200),
                    new SqlParameter("@refField20", SqlDbType.VarChar,500)};
            parameters[0].Value = model.machineID;
            parameters[1].Value = model.updatedTime;
            parameters[2].Value = model.totalQTY;
            parameters[3].Value = model.tempature11;
            parameters[4].Value = model.tempature12;
            parameters[5].Value = model.tempature13;
            parameters[6].Value = model.tempature14;
            parameters[7].Value = model.tempature15;
            parameters[8].Value = model.tempature21;
            parameters[9].Value = model.tempature22;
            parameters[10].Value = model.tempature23;
            parameters[11].Value = model.tempature24;
            parameters[12].Value = model.tempature25;
            parameters[13].Value = model.status1;
            parameters[14].Value = model.status2;
            parameters[15].Value = model.partNumber;
            parameters[16].Value = model.matPart01;
            parameters[17].Value = model.matPart02;
            parameters[18].Value = model.customer;
            parameters[19].Value = model.model;
            parameters[20].Value = model.jigNo;
            parameters[21].Value = model.cavityCount;
            parameters[22].Value = model.partsWeight;
            parameters[23].Value = model.cycleTime;
            parameters[24].Value = model.blockCount;
            parameters[25].Value = model.unitCount;
            parameters[26].Value = model.userName;
            parameters[27].Value = model.remarks;
            parameters[28].Value = model.refField01;
            parameters[29].Value = model.refField02;
            parameters[30].Value = model.refField03;
            parameters[31].Value = model.refField04;
            parameters[32].Value = model.refField05;
            parameters[33].Value = model.refField06;
            parameters[34].Value = model.refField07;
            parameters[35].Value = model.refField08;
            parameters[36].Value = model.refField09;
            parameters[37].Value = model.refField10;
            parameters[38].Value = model.refField11;
            parameters[39].Value = model.refField12;
            parameters[40].Value = model.refField13;
            parameters[41].Value = model.refField14;
            parameters[42].Value = model.refField15;
            parameters[43].Value = model.refField16;
            parameters[44].Value = model.refField17;
            parameters[45].Value = model.refField18;
            parameters[46].Value = model.refField19;
            parameters[47].Value = model.refField20;

            DBHelp.Reports.LogFile.DebugLog("AUTOCODE", "NameSpace:Common.DAL", "Class:MouldingPqm_DAL", "Function:		public SqlCommand UpdateCommand(Common.Model.MouldingPqm_Model model)" + "TableName:MouldingPqm", ";machineID = " + (model.machineID == null ? "" : model.machineID.ToString()) + ";updatedTime = " + (model.updatedTime == null ? "" : model.updatedTime.ToString()) + ";totalQTY = " + (model.totalQTY == null ? "" : model.totalQTY.ToString()) + ";tempature11 = " + (model.tempature11 == null ? "" : model.tempature11.ToString()) + ";tempature12 = " + (model.tempature12 == null ? "" : model.tempature12.ToString()) + ";tempature13 = " + (model.tempature13 == null ? "" : model.tempature13.ToString()) + ";tempature14 = " + (model.tempature14 == null ? "" : model.tempature14.ToString()) + ";tempature21 = " + (model.tempature21 == null ? "" : model.tempature21.ToString()) + ";tempature22 = " + (model.tempature22 == null ? "" : model.tempature22.ToString()) + ";tempature23 = " + (model.tempature23 == null ? "" : model.tempature23.ToString()) + ";tempature24 = " + (model.tempature24 == null ? "" : model.tempature24.ToString()) + ";status1 = " + (model.status1 == null ? "" : model.status1.ToString()) + ";status2 = " + (model.status2 == null ? "" : model.status2.ToString()) + ";partNumber = " + (model.partNumber == null ? "" : model.partNumber.ToString()) + ";matPart01 = " + (model.matPart01 == null ? "" : model.matPart01.ToString()) + ";matPart02 = " + (model.matPart02 == null ? "" : model.matPart02.ToString()) + ";customer = " + (model.customer == null ? "" : model.customer.ToString()) + ";model = " + (model.model == null ? "" : model.model.ToString()) + ";jigNo = " + (model.jigNo == null ? "" : model.jigNo.ToString()) + ";cavityCount = " + (model.cavityCount == null ? "" : model.cavityCount.ToString()) + ";partsWeight = " + (model.partsWeight == null ? "" : model.partsWeight.ToString()) + ";cycleTime = " + (model.cycleTime == null ? "" : model.cycleTime.ToString()) + ";blockCount = " + (model.blockCount == null ? "" : model.blockCount.ToString()) + ";unitCount = " + (model.unitCount == null ? "" : model.unitCount.ToString()) + ";userName = " + (model.userName == null ? "" : model.userName.ToString()) + ";remarks = " + (model.remarks == null ? "" : model.remarks.ToString()) + ";refField01 = " + (model.refField01 == null ? "" : model.refField01.ToString()) + ";refField02 = " + (model.refField02 == null ? "" : model.refField02.ToString()) + ";refField03 = " + (model.refField03 == null ? "" : model.refField03.ToString()) + ";refField04 = " + (model.refField04 == null ? "" : model.refField04.ToString()) + ";refField05 = " + (model.refField05 == null ? "" : model.refField05.ToString()) + ";refField06 = " + (model.refField06 == null ? "" : model.refField06.ToString()) + ";refField07 = " + (model.refField07 == null ? "" : model.refField07.ToString()) + ";refField08 = " + (model.refField08 == null ? "" : model.refField08.ToString()) + ";refField09 = " + (model.refField09 == null ? "" : model.refField09.ToString()) + ";refField10 = " + (model.refField10 == null ? "" : model.refField10.ToString()) + ";refField11 = " + (model.refField11 == null ? "" : model.refField11.ToString()) + ";refField12 = " + (model.refField12 == null ? "" : model.refField12.ToString()) + ";refField13 = " + (model.refField13 == null ? "" : model.refField13.ToString()) + ";refField14 = " + (model.refField14 == null ? "" : model.refField14.ToString()) + ";refField15 = " + (model.refField15 == null ? "" : model.refField15.ToString()) + ";refField16 = " + (model.refField16 == null ? "" : model.refField16.ToString()) + ";refField17 = " + (model.refField17 == null ? "" : model.refField17.ToString()) + ";refField18 = " + (model.refField18 == null ? "" : model.refField18.ToString()) + ";refField19 = " + (model.refField19 == null ? "" : model.refField19.ToString()) + ";refField20 = " + (model.refField20 == null ? "" : model.refField20.ToString()) + "");
            return DBHelp.SqlDB.generateCommand(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool Delete(string machineID, DateTime? updatedTime, decimal totalQTY, decimal tempature11, decimal tempature12, decimal tempature13, decimal tempature14, decimal tempature15, decimal tempature21, decimal tempature22, decimal tempature23, decimal tempature24, decimal tempature25, string status1, string status2, string partNumber, string matPart01, string matPart02, string customer, string model, string jigNo, decimal cavityCount, decimal partsWeight, decimal cycleTime, int blockCount, int unitCount, string userName, string remarks, string refField01, string refField02, string refField03, string refField04, string refField05, string refField06, string refField07, string refField08, string refField09, string refField10, string refField11, string refField12, string refField13, string refField14, string refField15, string refField16, string refField17, string refField18, string refField19, string refField20)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from MouldingPqm ");
            strSql.Append(" where ");
            SqlParameter[] parameters = {
};

            DBHelp.Reports.LogFile.DebugLog("AUTOCODE", "NameSpace:Common.DAL", "Class:MouldingPqm_DAL", "Function:		public bool Delete(string machineID,DateTime? updatedTime,decimal totalQTY,decimal tempature11,decimal tempature12,decimal tempature13,decimal tempature14,decimal tempature15,decimal tempature21,decimal tempature22,decimal tempature23,decimal tempature24,decimal tempature25,string status1,string status2,string partNumber,string matPart01,string matPart02,string customer,string model,string jigNo,decimal cavityCount,decimal partsWeight,decimal cycleTime,int blockCount,int unitCount,string userName,string remarks,string refField01,string refField02,string refField03,string refField04,string refField05,string refField06,string refField07,string refField08,string refField09,string refField10,string refField11,string refField12,string refField13,string refField14,string refField15,string refField16,string refField17,string refField18,string refField19,string refField20)" + "TableName:MouldingPqm", "");
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
        public Common.Model.MouldingPqm_Model GetModel(string machineID, DateTime? updatedTime, decimal totalQTY, decimal tempature11, decimal tempature12, decimal tempature13, decimal tempature14, decimal tempature15, decimal tempature21, decimal tempature22, decimal tempature23, decimal tempature24, decimal tempature25, string status1, string status2, string partNumber, string matPart01, string matPart02, string customer, string model, string jigNo, decimal cavityCount, decimal partsWeight, decimal cycleTime, int blockCount, int unitCount, string userName, string remarks, string refField01, string refField02, string refField03, string refField04, string refField05, string refField06, string refField07, string refField08, string refField09, string refField10, string refField11, string refField12, string refField13, string refField14, string refField15, string refField16, string refField17, string refField18, string refField19, string refField20)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 machineID,updatedTime,totalQTY,tempature11,tempature12,tempature13,tempature14,tempature15,tempature21,tempature22,tempature23,tempature24,tempature25,status1,status2,partNumber,matPart01,matPart02,customer,model,jigNo,cavityCount,partsWeight,cycleTime,blockCount,unitCount,userName,remarks,refField01,refField02,refField03,refField04,refField05,refField06,refField07,refField08,refField09,refField10,refField11,refField12,refField13,refField14,refField15,refField16,refField17,refField18,refField19,refField20 from MouldingPqm ");
            strSql.Append(" where ");
            SqlParameter[] parameters = {
};

            DBHelp.Reports.LogFile.DebugLog("AUTOCODE", "NameSpace:Common.DAL", "Class:MouldingPqm_DAL", "Function:		public Common.Model.MouldingPqm_Model GetModel(string machineID,DateTime? updatedTime,decimal totalQTY,decimal tempature11,decimal tempature12,decimal tempature13,decimal tempature14,decimal tempature15,decimal tempature21,decimal tempature22,decimal tempature23,decimal tempature24,decimal tempature25,string status1,string status2,string partNumber,string matPart01,string matPart02,string customer,string model,string jigNo,decimal cavityCount,decimal partsWeight,decimal cycleTime,int blockCount,int unitCount,string userName,string remarks,string refField01,string refField02,string refField03,string refField04,string refField05,string refField06,string refField07,string refField08,string refField09,string refField10,string refField11,string refField12,string refField13,string refField14,string refField15,string refField16,string refField17,string refField18,string refField19,string refField20)" + "TableName:MouldingPqm", "");
            Common.Model.MouldingPqm_Model _model = new Common.Model.MouldingPqm_Model();
            DataSet ds = DBHelp.SqlDB.Query(strSql.ToString(), parameters);
            if (ds.Tables[0].Rows.Count > 0)
            {
                _model.machineID = ds.Tables[0].Rows[0]["machineID"].ToString();
                if (ds.Tables[0].Rows[0]["updatedTime"].ToString() != "")
                {
                    _model.updatedTime = DateTime.Parse(ds.Tables[0].Rows[0]["updatedTime"].ToString());
                }
                if (ds.Tables[0].Rows[0]["totalQTY"].ToString() != "")
                {
                    _model.totalQTY = decimal.Parse(ds.Tables[0].Rows[0]["totalQTY"].ToString());
                }
                if (ds.Tables[0].Rows[0]["tempature11"].ToString() != "")
                {
                    _model.tempature11 = decimal.Parse(ds.Tables[0].Rows[0]["tempature11"].ToString());
                }
                if (ds.Tables[0].Rows[0]["tempature12"].ToString() != "")
                {
                    _model.tempature12 = decimal.Parse(ds.Tables[0].Rows[0]["tempature12"].ToString());
                }
                if (ds.Tables[0].Rows[0]["tempature13"].ToString() != "")
                {
                    _model.tempature13 = decimal.Parse(ds.Tables[0].Rows[0]["tempature13"].ToString());
                }
                if (ds.Tables[0].Rows[0]["tempature14"].ToString() != "")
                {
                    _model.tempature14 = decimal.Parse(ds.Tables[0].Rows[0]["tempature14"].ToString());
                }
                if (ds.Tables[0].Rows[0]["tempature15"].ToString() != "")
                {
                    _model.tempature15 = decimal.Parse(ds.Tables[0].Rows[0]["tempature15"].ToString());
                }
                if (ds.Tables[0].Rows[0]["tempature21"].ToString() != "")
                {
                    _model.tempature21 = decimal.Parse(ds.Tables[0].Rows[0]["tempature21"].ToString());
                }
                if (ds.Tables[0].Rows[0]["tempature22"].ToString() != "")
                {
                    _model.tempature22 = decimal.Parse(ds.Tables[0].Rows[0]["tempature22"].ToString());
                }
                if (ds.Tables[0].Rows[0]["tempature23"].ToString() != "")
                {
                    _model.tempature23 = decimal.Parse(ds.Tables[0].Rows[0]["tempature23"].ToString());
                }
                if (ds.Tables[0].Rows[0]["tempature24"].ToString() != "")
                {
                    _model.tempature24 = decimal.Parse(ds.Tables[0].Rows[0]["tempature24"].ToString());
                }
                if (ds.Tables[0].Rows[0]["tempature25"].ToString() != "")
                {
                    _model.tempature25 = decimal.Parse(ds.Tables[0].Rows[0]["tempature25"].ToString());
                }
                _model.status1 = ds.Tables[0].Rows[0]["status1"].ToString();
                _model.status2 = ds.Tables[0].Rows[0]["status2"].ToString();
                _model.partNumber = ds.Tables[0].Rows[0]["partNumber"].ToString();
                _model.matPart01 = ds.Tables[0].Rows[0]["matPart01"].ToString();
                _model.matPart02 = ds.Tables[0].Rows[0]["matPart02"].ToString();
                _model.customer = ds.Tables[0].Rows[0]["customer"].ToString();
                _model.model = ds.Tables[0].Rows[0]["model"].ToString();
                _model.jigNo = ds.Tables[0].Rows[0]["jigNo"].ToString();
                if (ds.Tables[0].Rows[0]["cavityCount"].ToString() != "")
                {
                    _model.cavityCount = decimal.Parse(ds.Tables[0].Rows[0]["cavityCount"].ToString());
                }
                if (ds.Tables[0].Rows[0]["partsWeight"].ToString() != "")
                {
                    _model.partsWeight = decimal.Parse(ds.Tables[0].Rows[0]["partsWeight"].ToString());
                }
                if (ds.Tables[0].Rows[0]["cycleTime"].ToString() != "")
                {
                    _model.cycleTime = decimal.Parse(ds.Tables[0].Rows[0]["cycleTime"].ToString());
                }
                if (ds.Tables[0].Rows[0]["blockCount"].ToString() != "")
                {
                    _model.blockCount = int.Parse(ds.Tables[0].Rows[0]["blockCount"].ToString());
                }
                if (ds.Tables[0].Rows[0]["unitCount"].ToString() != "")
                {
                    _model.unitCount = int.Parse(ds.Tables[0].Rows[0]["unitCount"].ToString());
                }
                _model.userName = ds.Tables[0].Rows[0]["userName"].ToString();
                _model.remarks = ds.Tables[0].Rows[0]["remarks"].ToString();
                _model.refField01 = ds.Tables[0].Rows[0]["refField01"].ToString();
                _model.refField02 = ds.Tables[0].Rows[0]["refField02"].ToString();
                _model.refField03 = ds.Tables[0].Rows[0]["refField03"].ToString();
                _model.refField04 = ds.Tables[0].Rows[0]["refField04"].ToString();
                _model.refField05 = ds.Tables[0].Rows[0]["refField05"].ToString();
                _model.refField06 = ds.Tables[0].Rows[0]["refField06"].ToString();
                _model.refField07 = ds.Tables[0].Rows[0]["refField07"].ToString();
                _model.refField08 = ds.Tables[0].Rows[0]["refField08"].ToString();
                _model.refField09 = ds.Tables[0].Rows[0]["refField09"].ToString();
                _model.refField10 = ds.Tables[0].Rows[0]["refField10"].ToString();
                _model.refField11 = ds.Tables[0].Rows[0]["refField11"].ToString();
                _model.refField12 = ds.Tables[0].Rows[0]["refField12"].ToString();
                _model.refField13 = ds.Tables[0].Rows[0]["refField13"].ToString();
                _model.refField14 = ds.Tables[0].Rows[0]["refField14"].ToString();
                _model.refField15 = ds.Tables[0].Rows[0]["refField15"].ToString();
                _model.refField16 = ds.Tables[0].Rows[0]["refField16"].ToString();
                _model.refField17 = ds.Tables[0].Rows[0]["refField17"].ToString();
                _model.refField18 = ds.Tables[0].Rows[0]["refField18"].ToString();
                _model.refField19 = ds.Tables[0].Rows[0]["refField19"].ToString();
                _model.refField20 = ds.Tables[0].Rows[0]["refField20"].ToString();
                return _model;
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
            strSql.Append("select machineID,updatedTime,totalQTY,tempature11,tempature12,tempature13,tempature14,tempature15,tempature21,tempature22,tempature23,tempature24,tempature25,status1,status2,partNumber,matPart01,matPart02,customer,model,jigNo,cavityCount,partsWeight,cycleTime,blockCount,unitCount,userName,remarks,refField01,refField02,refField03,refField04,refField05,refField06,refField07,refField08,refField09,refField10,refField11,refField12,refField13,refField14,refField15,refField16,refField17,refField18,refField19,refField20 ");
            strSql.Append(" FROM MouldingPqm ");
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
            strSql.Append(" machineID,updatedTime,totalQTY,tempature11,tempature12,tempature13,tempature14,tempature15,tempature21,tempature22,tempature23,tempature24,tempature25,status1,status2,partNumber,matPart01,matPart02,customer,model,jigNo,cavityCount,partsWeight,cycleTime,blockCount,unitCount,userName,remarks,refField01,refField02,refField03,refField04,refField05,refField06,refField07,refField08,refField09,refField10,refField11,refField12,refField13,refField14,refField15,refField16,refField17,refField18,refField19,refField20 ");
            strSql.Append(" FROM MouldingPqm ");
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
			parameters[0].Value = "MouldingPqm";
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


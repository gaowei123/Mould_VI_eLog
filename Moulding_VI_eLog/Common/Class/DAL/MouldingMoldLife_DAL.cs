using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using DBHelp;
namespace Common.DAL
{
    public class MouldingMoldLife_DAL
    {
        public MouldingMoldLife_DAL()
        { }


        public bool Update(Common.Model.MouldingMoldLife model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update MouldingMoldLife set ");
            //strSql.Append("MoldID=@MoldID,");
            //strSql.Append("PartNumberAll=@PartNumberAll,");
            strSql.Append("Accumulate=@Accumulate,");
            strSql.Append("Clean1Qty=@Clean1Qty,");
            strSql.Append("UpdatedTime=@UpdatedTime,");
            strSql.Append("MachineID=@MachineID");
            strSql.Append(" where  PartNumberAll=@PartNumberAll ");
            SqlParameter[] parameters = {
                    new SqlParameter("@Accumulate", SqlDbType.Int),
                    new SqlParameter("@Clean1Qty", SqlDbType.Int),
                    new SqlParameter("@PartNumberAll",  SqlDbType.VarChar),
                    new SqlParameter("@UpdatedTime",  SqlDbType.DateTime),
                    new SqlParameter("@MachineID",  SqlDbType.VarChar)};
            parameters[0].Value = model.Accumulate;
            parameters[1].Value = model.Clean1Qty;
            parameters[2].Value = model.PartNumberAll;
            parameters[3].Value = model.UpdatedTime;
            parameters[4].Value = model.MachineID;
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

        public Common.Model.MouldingMoldLife GetModel( string PartNumberAll)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT  [MoldID],[MachineID],[PartNumberAll],MouldLife,[Accumulate],[Clean1Qty],[Clean1Time],[Clean1TimeBy],[Clean2Qty],[Clean2Time],[Clean2TimeBy],[Clean3Qty],[Clean3Time],[Clean3TimeBy],[Clean4Qty],[Clean4Time],[Clean4TimeBy] ,[Clean5Qty] ,[Clean5Time]  ,[Clean5TimeBy]    ,[ChangeQty] ,[ChangeTime]  ,[ChangeBy] ,[CreateTime],[UpdatedTime] FROM MouldingMoldLife");
            strSql.Append(" where PartNumberAll=@PartNumberAll");
            SqlParameter[] parameters = {
                    new SqlParameter("@PartNumberAll",  SqlDbType.VarChar)
};
            parameters[0].Value = PartNumberAll;

            Common.Model.MouldingMoldLife model = new Common.Model.MouldingMoldLife();
            DataSet ds = DBHelp.SqlDB.Query(strSql.ToString(), parameters);
            if (ds.Tables[0].Rows.Count > 0)
            {

                model.MoldID = ds.Tables[0].Rows[0]["MoldID"].ToString();
                model.PartNumberAll = ds.Tables[0].Rows[0]["PartNumberAll"].ToString();
                model.Accumulate = decimal.Parse(ds.Tables[0].Rows[0]["Accumulate"].ToString());
                model.Clean1Qty = decimal.Parse(ds.Tables[0].Rows[0]["Clean1Qty"].ToString());

                model.MouldLife = decimal.Parse(ds.Tables[0].Rows[0]["MouldLife"].ToString());
            }
            return model;
        }

        public bool Add(Common.Model.MouldingMoldLife model)
        {
            StringBuilder strSql = new StringBuilder();

            strSql.Append(" insert into MouldingMoldLife ");
            strSql.Append(" ( MoldID, MachineID,PartNumberAll,MouldLife ,Accumulate,Clean1Qty,Clean1Time,Clean1TimeBy,Clean2Qty,Clean2Time,Clean2TimeBy,Clean3Qty,Clean3Time,Clean3TimeBy,Clean4Qty,Clean4Time,Clean4TimeBy,Clean5Qty,Clean5Time,Clean5TimeBy,ChangeQty,ChangeTime,ChangeBy,CreateTime,UpdatedTime) ");
            strSql.Append(" values ");
            strSql.Append(" (@MoldID, @MachineID,@PartNumberAll,@MouldLife, @Accumulate,@Clean1Qty,@Clean1Time,@Clean1TimeBy,@Clean2Qty,@Clean2Time,@Clean2TimeBy,@Clean3Qty,@Clean3Time,@Clean3TimeBy,@Clean4Qty,@Clean4Time,@Clean4TimeBy,@Clean5Qty,@Clean5Time,@Clean5TimeBy,@ChangeQty,@ChangeTime,@ChangeBy,@CreateTime,@UpdatedTime) ");


            SqlParameter[] parameters = {
                new SqlParameter("@MachineID", SqlDbType.VarChar),
                new SqlParameter("@PartNumberAll", SqlDbType.VarChar),
                new SqlParameter("@Accumulate", SqlDbType.Int),
                new SqlParameter("@Clean1Qty", SqlDbType.Int),
                new SqlParameter("@Clean1Time", SqlDbType.DateTime),
                new SqlParameter("@Clean1TimeBy", SqlDbType.VarChar),
                new SqlParameter("@Clean2Qty", SqlDbType.Int),
                new SqlParameter("@Clean2Time", SqlDbType.DateTime),
                new SqlParameter("@Clean2TimeBy", SqlDbType.VarChar),
                new SqlParameter("@Clean3Qty", SqlDbType.Int),
                new SqlParameter("@Clean3Time", SqlDbType.DateTime),
                new SqlParameter("@Clean3TimeBy", SqlDbType.VarChar),
                new SqlParameter("@Clean4Qty", SqlDbType.Int),
                new SqlParameter("@Clean4Time", SqlDbType.DateTime),
                new SqlParameter("@Clean4TimeBy", SqlDbType.VarChar),
                new SqlParameter("@Clean5Qty", SqlDbType.Int),
                new SqlParameter("@Clean5Time", SqlDbType.DateTime),
                new SqlParameter("@Clean5TimeBy", SqlDbType.VarChar),
                new SqlParameter("@ChangeQty", SqlDbType.Int),
                new SqlParameter("@ChangeTime", SqlDbType.DateTime),
                new SqlParameter("@ChangeBy", SqlDbType.VarChar),
                new SqlParameter("@CreateTime", SqlDbType.DateTime),
                new SqlParameter("@UpdatedTime", SqlDbType.DateTime),
                new SqlParameter("@MoldID",SqlDbType.VarChar),
                new SqlParameter("@MouldLife",SqlDbType.Int)
            };

            parameters[0].Value = model.MachineID == null ? (object)DBNull.Value : model.MachineID;
            parameters[1].Value = model.PartNumberAll == null ? (object)DBNull.Value : model.PartNumberAll;
            parameters[2].Value = model.Accumulate == null ? (object)DBNull.Value : model.Accumulate;
            parameters[3].Value = model.Clean1Qty == null ? (object)DBNull.Value : model.Clean1Qty;
            parameters[4].Value = model.Clean1Time == null ? (object)DBNull.Value : model.Clean1Time;
            parameters[5].Value = model.Clean1TimeBy == null ? (object)DBNull.Value : model.Clean1TimeBy;
            parameters[6].Value = model.Clean2Qty == null ? (object)DBNull.Value : model.Clean2Qty;
            parameters[7].Value = model.Clean2Time == null ? (object)DBNull.Value : model.Clean2Time;
            parameters[8].Value = model.Clean2TimeBy == null ? (object)DBNull.Value : model.Clean2TimeBy;
            parameters[9].Value = model.Clean3Qty == null ? (object)DBNull.Value : model.Clean3Qty;
            parameters[10].Value = model.Clean3Time == null ? (object)DBNull.Value : model.Clean3Time;
            parameters[11].Value = model.Clean3TimeBy == null ? (object)DBNull.Value : model.Clean3TimeBy;
            parameters[12].Value = model.Clean4Qty == null ? (object)DBNull.Value : model.Clean4Qty;
            parameters[13].Value = model.Clean4Time == null ? (object)DBNull.Value : model.Clean4Time;
            parameters[14].Value = model.Clean4TimeBy == null ? (object)DBNull.Value : model.Clean4TimeBy;
            parameters[15].Value = model.Clean5Qty == null ? (object)DBNull.Value : model.Clean5Qty;
            parameters[16].Value = model.Clean5Time == null ? (object)DBNull.Value : model.Clean5Time;
            parameters[17].Value = model.Clean5TimeBy == null ? (object)DBNull.Value : model.Clean5TimeBy;
            parameters[18].Value = model.ChangeQty == null ? (object)DBNull.Value : model.ChangeQty;
            parameters[19].Value = model.ChangeTime == null ? (object)DBNull.Value : model.ChangeTime;
            parameters[20].Value = model.ChangeBy == null ? (object)DBNull.Value : model.ChangeBy;
            parameters[21].Value = DateTime.Now;
            parameters[22].Value = DateTime.Now;
            parameters[23].Value = model.MoldID == null ? (object)DBNull.Value : model.MoldID;
            parameters[24].Value = model.MouldLife == null ? (object)DBNull.Value : model.MouldLife;

            //return DBHelp.SqlDB.generateCommand(strSql.ToString(), parameters);
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

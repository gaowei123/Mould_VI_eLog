using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;
namespace DBHelp
{
    public class SqlDB
    {
      
        public static int ExecuteSql(string strSql, SqlParameter[] parameters)
        {
            SqlConnection cn = new SqlConnection();

            try
            {
                cn = Connection.SqlServer.SqlConn;

                SqlCommand cmd = new SqlCommand(strSql, cn);

                foreach (SqlParameter par in parameters)
                {
                    cmd.Parameters.Add(par);
                }

                cn.Open();
                int i = cmd.ExecuteNonQuery();
                return i;
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                cn.Close();
            }

        }
        public static int ExecuteSql(string strSql)
        {
            SqlConnection cn = new SqlConnection();

            try
            {
                cn = Connection.SqlServer.SqlConn;

                SqlCommand cmd = new SqlCommand(strSql, cn);

              
                cn.Open();
                int i = cmd.ExecuteNonQuery();
                return i;
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                cn.Close();
            }

        }
        public static System.Data.DataSet Query(string strSql)
        {
            try
            {
                DataSet ds = new DataSet();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = strSql;

                ds.Tables.Add(GetData(cmd, Connection.SqlServer.SqlConn));
                return ds;
            }
            catch (Exception e)
            {

                throw e;
            }
        }

        public static System.Data.DataSet  Query(string strSql , SqlParameter[] parameters)
        {
            try
            { 
                DataSet ds = new DataSet();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = strSql;
                foreach (SqlParameter par in parameters)
                {
                    if (par != null)  //2017 02 13 remove null parameter
                    {
                        cmd.Parameters.Add(par);
                    }
                }

                ds.Tables.Add(GetData(cmd, Connection.SqlServer.SqlConn));
                return ds;
            }
            catch (Exception e)
            {

                throw e;
            }
        }

        //2017 02 28
        public static SqlCommand generateCommand(string strSql, SqlParameter[] spParameters)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = strSql;
            foreach (SqlParameter par in spParameters)
            {
                if (par != null)  //2017 02 13 remove null parameter
                {
                    cmd.Parameters.Add(par);
                }
            }
            return cmd;
        }

        //2017 02 28
        public static System.Data.DataSet Query(string strSql, SqlConnection cn)
        {
            try
            {
                DataSet ds = new DataSet();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = strSql;

                ds.Tables.Add(GetData(cmd, cn));
                return ds;
            }
            catch (Exception e)
            {

                throw e;
            }
        }

        //2017 02 28
        public static System.Data.DataSet Query(string strSql, SqlParameter[] parameters, SqlConnection cn)
        {
            try
            {
                DataSet ds = new DataSet();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = strSql;
                foreach (SqlParameter par in parameters)
                {
                    if (par != null)  //2017 02 13 remove null parameter
                    {
                        Reports.LogFile.Log("Oracle", "[Query][Parameters Info]" + "[Para " + par.ParameterName.ToString() + " = " +  (par.Value == null?"": par.Value.ToString())  + "]");
                        cmd.Parameters.Add(par);
                    }
                }

                ds.Tables.Add(GetData(cmd, cn));
                return ds;
            }
            catch (Exception e)
            {

                throw e;
            }
        }


        public static System.Data.DataTable GetData(SqlCommand cmd)
        {
            return  GetData(cmd, Connection.SqlServer.SqlConn);
        }
        public static System.Data.DataTable GetData(SqlCommand cmd, SqlConnection cn)
        {
            
            cmd.Connection = cn;
            DataTable dt = new DataTable();
            try
            {
                cn.Open();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                cn.Close();
            }
            return dt;
        }
     
        public static bool SetData(SqlCommand cmd, SqlConnection cn)
        {
            cmd.Connection = cn;
            try
            {
                cn.Open();
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    return true;
                }
                return false;
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                cn.Close();
            }

        }

        public static bool SetData_Rollback(List<SqlCommand> cmdlist)
        {
            return SetData_Rollback(cmdlist, Connection.SqlServer.SqlConn);
        }

        

        public static bool SetData_Rollback(List<SqlCommand> cmdlist, SqlConnection cn)
        {
            bool flag = true;
            cn.Open();
            SqlTransaction tran = cn.BeginTransaction("test");
            tran.Save("start");
            try
            {
                
                 for (int i = 0; i <= cmdlist.Count - 1; i++)
                {
                    SqlCommand cmd = cmdlist[i];
                    cmd.Connection = cn;
                    cmd.Transaction = tran;

                    string log1 = "[" + cmd.CommandText.ToString() + "]";
                    foreach (SqlParameter sqlPara in cmd.Parameters)
                    {
                        try
                        {
                            log1 += "[Para " + sqlPara.ParameterName.ToString() + " = " + sqlPara.Value.ToString() + "]";
                            Reports.LogFile.Log("Oracle", "[SetData_Rollback][Parameters Info]" + "[Para " + sqlPara.ParameterName.ToString() + " = " + sqlPara.Value.ToString() + "]");
                        }
                        catch (Exception EX)
                        {
                            Reports.LogFile.Log("Oracle", "[SetData_Rollback][Parameters Info]" + EX.ToString());
                        }
                    }
                    Reports.LogFile.Log("Oracle", "[SetData_Rollback][cmd Info]" + log1);

                    if (cmd.ExecuteNonQuery() < 0)
                    {
                        Reports.LogFile.Log("Oracle", "[SetData_Rollback][cmd.ExecuteNonQuery() < 0]");
                        tran.Rollback("start");
                        tran.Dispose();
                        tran = null;
                        flag = false;
                        break;
                    }
                    else
                    {
                        cmd.Parameters.Clear();
                    }
                }
                if (flag)
                {
                    tran.Commit();
                }
                return flag;
            }
            catch (Exception ex)
            {
                Reports.LogFile.Log("Oracle", "[SetData_Rollback][ex=" + ex.ToString());

                tran.Rollback("start");
                return false;
            }
            finally
            {
                cn.Close();
            }
        }


    }
}

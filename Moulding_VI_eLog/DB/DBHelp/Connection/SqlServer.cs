using System;
using System.Collections.Generic;
using System.Text;
using System.Configuration;
namespace DBHelp.Connection
{
    public class SqlServer
    {
        public static System.Data.SqlClient.SqlConnection SqlConn
        {
            get
            {
                //本地配置 

                return new System.Data.SqlClient.SqlConnection(System.Configuration.ConfigurationManager.AppSettings["SQL_ConnStr"].ToString());
                //@"Data Source=WLJ\UBCTDB;Initial Catalog=PXXX-VISHAY-LMMS;User ID=sa;Password=Ab123456");



            }

        }
        public static System.Data.SqlClient.SqlConnection SqlConn_OutSource1
        {
            get
            {
                //本地配置  
                return new System.Data.SqlClient.SqlConnection(System.Configuration.ConfigurationManager.AppSettings["SQL_ConnStr_OutSource1"].ToString());
                //@"Data Source=WLJ\UBCTDB;Initial Catalog=PXXX-VISHAY-LMMS;User ID=sa;Password=Ab123456");  
            }

        }
        public static System.Data.SqlClient.SqlConnection SqlConn_OutSource2
        {
            get
            {
                //本地配置  
                return new System.Data.SqlClient.SqlConnection(System.Configuration.ConfigurationManager.AppSettings["SQL_ConnStr_OutSource2"].ToString());
                //@"Data Source=WLJ\UBCTDB;Initial Catalog=PXXX-VISHAY-LMMS;User ID=sa;Password=Ab123456");  
            }

        }

    }
}

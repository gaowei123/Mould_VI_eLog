using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;

namespace AlertEmailFor_Review.Database
{
    public class Connection
    {
        public static SqlConnection Server
        {
            get
            {
                // YP Xia's PC.
                //return new System.Data.SqlClient.SqlConnection(@"Data Source=DESKTOP-BS114EV\SQLEXPRESS;Initial Catalog=UMS;Persist Security Info=True;User ID=sa;Password=sa0");

                // Server PC
                //return new System.Data.SqlClient.SqlConnection(@"Data Source=119.10.27.123;Initial Catalog=UMS;Persist Security Info=True;User ID=sa;Password=XINnet123!@#");

                // Design-4 PC
              // return new System.Data.SqlClient.SqlConnection(@"Data Source=DESKTOP-TOM4L2D\SQLEXPRESS;Initial Catalog=UMS;Persist Security Info=True;User ID=test;Password=1234");
              return new System.Data.SqlClient.SqlConnection(@"Data Source=47.91.159.36;Initial Catalog=UMS;Persist Security Info=True; User ID =sa; Password = Ab123456");
                // HP 's PC.
                //return new System.Data.SqlClient.SqlConnection(@"Data Source=HP\SQLEXPRESS;Initial Catalog=UMS;Integrated Security=True");

                // Faez 's PC.
                //return new System.Data.SqlClient.SqlConnection(@"Data Source=MFAEZUDDIN-PC\SQLEXPRESS2008;Initial Catalog=UMS;Persist Security Info=True;User ID=sa;Password=sa0");

                // Design 2 's PC.
                //return new System.Data.SqlClient.SqlConnection(@"Data Source=design2-PC\SQLEXPRESS;Initial Catalog=UMS;Persist Security Info=True;User ID=test;Password=test");
            }
        }
    }
}

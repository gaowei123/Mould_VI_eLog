using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Data;

namespace Common.Reports
{
   public class CSVHelper
    {
        static public bool Export(
                                ref DataTable dt, 
                                string sCsvFileName)
        {
            if (dt.Rows.Count <= 0) return false;

            bool bSuccess = false;
            
            int i = 0;
            int j = 0;
            string sLine = "";
            StreamWriter file = null;

            try
            {
                #region Write to file

                file = new StreamWriter(sCsvFileName);

                #region Write the column names.

                sLine = "";

                for (i = 0; i < dt.Columns.Count; i++)
                {
                    sLine += ((i == 0) ? "" : ", ") + dt.Columns[i].ColumnName;
                }

                file.WriteLine(sLine);

                #endregion

                #region Write all rows.

                for (i = 0; i < dt.Rows.Count; i++)
                {
                    sLine = "";

                    for (j = 0; j < dt.Columns.Count; j++)
                    {
                        sLine += ((j == 0) ? "" : ", ") + dt.Rows[i][j].ToString();
                    }

                    file.WriteLine(sLine);
                }

                file.Close();

                #endregion

                bSuccess = true;

                #endregion
            }
            catch (Exception ex)
            {
                bSuccess = false;
                throw ex;
            }

            return bSuccess;
        }
    }
}
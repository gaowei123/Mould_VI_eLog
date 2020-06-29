using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Common.Reports
{
    public class LogFile
    {
        public static void Log(string ARS_ID,string msg)
        {
            try
            {
                string datePatt = @"yyyyMMdd";
                string path = "";
                string file = "";


                #region File.
                //path = ".\\Log\\"; //Test Mode
                path="D:\\ARS_WHS_Log\\"; //Production Mode

                if (!Directory.Exists(path))
                {
                    System.IO.Directory.CreateDirectory(path);
                }

                file = path + ARS_ID + "(" + DateTime.Now.ToString(datePatt) + ").txt";

                #endregion

                StreamWriter tw = File.AppendText(file);

                // Write a line of text to the file.
                tw.WriteLine(DateTime.Now.ToString("yyyyMMdd HH:mm:ss tt -- ") + msg);

                // Close the stream.
                tw.Flush();
                tw.Dispose();
                tw.Close();
            }
            catch(Exception ee)
            {
                //throw ee;
            }
        }
    }
}

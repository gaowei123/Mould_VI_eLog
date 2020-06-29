using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Win32;
using System.Data;
using System.Windows;
using System.IO;
using System.Data.OleDb;

namespace VI_eLog
{
    class ExportCSV
    {
        #region Writing a DataTable to a CSV file

        public static void WriteDataTable(DataTable sourceTable)
        {
             try
                {
                    SaveFileDialog sfd = new SaveFileDialog()
                    {
                        DefaultExt = "csv",
                        Filter = "CSV Files (*.csv)|*.csv|All files (*.*)|*.*",
                        FilterIndex = 1
                    };

                    if (sfd.ShowDialog() == true)
                    {
                        TextWriter writer = File.CreateText(sfd.FileName);

                        string[] items = null;
                        List<string> headerValues = new List<string>();

                        foreach (DataColumn column in sourceTable.Columns)
                            headerValues.Add(QuoteValue(column.ColumnName));

                        writer.WriteLine(String.Join(",", headerValues.ToArray()));

                        foreach (DataRow row in sourceTable.Rows)
                        {
                            items = row.ItemArray.Select(o => QuoteValue(o.ToString())).ToArray();
                            writer.WriteLine(String.Join(",", items));
                        }

                        writer.Flush();
                        writer.Close();

                       MessageBox.Show("The file been saved as .csv");
                    }
                }
             catch(Exception e)
             {
                MessageBox.Show(e.Message, e.HelpLink, MessageBoxButton.OK, MessageBoxImage.Warning);
             }
        }

        private static string QuoteValue(string value)
        {
            return String.Concat("\"", value.Replace("\"", "\"\""), "\"");
        }

        #endregion

        #region Writing a CSV file to DataTable

        public static OleDbDataAdapter ImportCsvfileToDataTable(String filename)
        {
            OleDbDataAdapter DataAdapter = new OleDbDataAdapter();

            try
            {
                OleDbConnection Connection = new OleDbConnection("Provider=Microsoft.Jet.OleDb.4.0; Data Source = '" +
                           System.IO.Path.GetDirectoryName(filename) + "'; Extended Properties = \"Text;HDR=YES;FMT=Delimited\"");

                Connection.Open();

                DataAdapter = new OleDbDataAdapter("SELECT * FROM [" + System.IO.Path.GetFileName(filename) + "]", Connection);

                Connection.Close();
            }
            catch(Exception e)
            {
               MessageBox.Show(e.Message, e.HelpLink, MessageBoxButton.OK, MessageBoxImage.Warning);
            }
            return DataAdapter;
        }

        #endregion
    }
}

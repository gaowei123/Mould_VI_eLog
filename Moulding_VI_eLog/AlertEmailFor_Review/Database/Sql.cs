using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Windows;
using System.IO;
using System.Data;

namespace AlertEmailFor_Review.Database
{
    public class Sql
    {
        static SqlConnection connect = Connection.Server;

        public static Boolean CheckConnection()
        {
            Boolean connection = false;

            try
            {
                connect.Open();

                if (connect.State == ConnectionState.Open)
                    connection = true;

              
            }
            catch (Exception ex)
            {
               // throw ex;
                MessageBox.Show("Unable connect to server. Please check your network connection.");
            }
            finally
            {
                connect.Close();
            }

            return connection;
        } // use for check the validity

        public static void Update(string SqlStatement)
        {           
            try
            {
                connect.Open();

                SqlCommand Command = new SqlCommand(SqlStatement, connect);
                Command.ExecuteNonQuery();
            }

            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                connect.Close();
            }
        } // use for add, update and delete SQL statement

        public static String ReadSelectedColumn(string SqlStatement, string ColumnName)
        {
            string TextColumn = null;

            try
            {
                connect.Open();
                using (SqlCommand comm = new SqlCommand("SET ARITHABORT ON", connect))
                {
                    comm.ExecuteNonQuery();
                }
                SqlCommand Command = new SqlCommand(SqlStatement, connect);
                SqlDataReader Reader = Command.ExecuteReader();

                if (Reader.Read())
                {
                    TextColumn = Reader[ColumnName].ToString();
                }   
            }

            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                connect.Close();
            }

            return TextColumn;
        } // use for read text column from Sql Statement

        public static String ReadSQLCommand(string SqlStatement)
        {
            string TextColumn = null;

            try
            {
                connect.Open();
                using (SqlCommand comm = new SqlCommand("SET ARITHABORT ON", connect))
                {
                    comm.ExecuteNonQuery();
                }

                SqlCommand Command = new SqlCommand(SqlStatement, connect);
                SqlDataReader Reader = Command.ExecuteReader();

                while (Reader.Read())
                {
                    TextColumn = Reader[0].ToString();
                }

                Reader.Close();
                //if (Reader.Read())
                //{
                //    TextColumn = Reader[0].ToString();
                //}
            }

            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                connect.Close();
            }

            return TextColumn;
        } // use for read text column from Sql Statement

        public static List<String> ReadSQLRow(string SqlStatement,string columnName)
        {
            string TextColumn = null;
            List<string> Row = new List<string>();

            try
            {
                connect.Open();

                SqlCommand Command = new SqlCommand(SqlStatement, connect);
                SqlDataReader Reader = Command.ExecuteReader();

                while (Reader.Read())
                {
                    TextColumn = Reader[columnName].ToString();
                    Row.Add(TextColumn);
                }
            }

            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                connect.Close();
            }

            return Row;
        } // use for read text column from Sql Statement

        public static Boolean CheckValidity(string SqlStatement)
        {
            Boolean Verified = false;

            try
            {
                connect.Open();
                SqlStatement = "SELECT * FROM[UMS].[dbo].[User_List] where[Badge_ID] = 'S0005' and[User_Password] = '164019'";

                SqlCommand Command = new SqlCommand(SqlStatement, connect);
                SqlDataReader Reader = Command.ExecuteReader();

                if (Reader.Read())
                    Verified = true;
            }

            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                connect.Close();
            }

            return Verified;
        } // use for check the validity 

     

        public static SqlDataAdapter TableUpdate(string SqlStatement)
        {
             SqlDataAdapter Adapter = null;
            //SqlDataReader adapter = null;
            try
            {
                connect.Open();
                using (SqlCommand comm = new SqlCommand("SET ARITHABORT ON", connect))
                {
                    comm.ExecuteNonQuery();
                }
                SqlCommand Command = new SqlCommand(SqlStatement, connect);
                Adapter = new SqlDataAdapter(Command);
               // adapter = Command.ExecuteReader();


            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                connect.Close();
            }

            return Adapter;
        } // use for fill data into table_grid

        public static void UpdateImage(byte[] ImageData, string DatabaseName, string ColumnFilename, string Condition)
        {
            try
            {
                connect.Open();

                if (ImageData != null)
                    {
                        SqlCommand Command = new SqlCommand("Update " + DatabaseName + " set " + ColumnFilename + " = @Images where " + Condition, connect);

                        SqlParameter Parameter = new SqlParameter();

                        Parameter.ParameterName = "@Images";
                        Parameter.SqlDbType = SqlDbType.VarBinary;
                        Parameter.Size = 3000000;
                        Parameter.Value = ImageData;

                        Command.Parameters.Add(Parameter);
                        Command.ExecuteNonQuery();
                    }
            }

            catch (Exception ex)
            {
                throw ex;
            }

            finally
            {
                connect.Close();
            }
        } // use for updating image

        public static void StoringFile(Microsoft.Win32.OpenFileDialog FilePath, string DatabaseName, string ColumnFilename, string ColumnFilename2, string ColumnExtname, string Condition)
        {
            byte[] file;
            byte[] file2;

          
            using (var stream = new FileStream(FilePath.FileNames[0], FileMode.Open, FileAccess.Read))
            {
                using (var reader = new BinaryReader(stream))
                {
                    file = reader.ReadBytes((int)stream.Length);
                }
            }

            using (var stream = new FileStream(FilePath.FileNames[1], FileMode.Open, FileAccess.Read))
            {
                using (var reader = new BinaryReader(stream))
                {
                    file2 = reader.ReadBytes((int)stream.Length);
                }
            }
            string a = "Update " + DatabaseName + " set " + ColumnFilename + " = @File, " + ColumnExtname + " = '" + Path.GetExtension(FilePath.FileName) + "' where " + Condition;
            string b = "Update " + DatabaseName + " set " + ColumnFilename + " = @File " + ","
+ ColumnFilename2 + " = @File1 " + " where " + Condition;
            try
            {
                connect.Open();

                SqlCommand Command = new SqlCommand("Update " + DatabaseName + " set " + ColumnFilename + " = @File " + ","
+ ColumnFilename2 + " = @File1 "  +" where " + Condition, connect);

                Command.Parameters.Add("@File", System.Data.SqlDbType.VarBinary, file.Length).Value = file;
                Command.Parameters.Add("@File1", System.Data.SqlDbType.VarBinary, file2.Length).Value = file2;

                Command.ExecuteNonQuery();
            }

            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                connect.Close();
            }
        } // use for fill updating any file

        public static void RetriveFile(string DatabaseName, string FileColumnName, string FileColumnName1, string Condition, string FileName, string FileExt)
        {
            Microsoft.Win32.SaveFileDialog SaveFile = new Microsoft.Win32.SaveFileDialog();
            Microsoft.Win32.SaveFileDialog SaveFile1 = new Microsoft.Win32.SaveFileDialog();

            SaveFile.Title = "Please select the name and folder to download the documents";
            SaveFile.FileName = FileName + ".DWG";

            SaveFile1.Title = "Please select the name and folder to download the documents";
            SaveFile1.FileName = FileName + ".PDF";


            Nullable<bool> result = SaveFile.ShowDialog();

            #region Attachement DWG
            if (result == true)
            {
                try
                {
                    connect.Open();

                    SqlCommand Command = new SqlCommand("Select " + FileColumnName + " From " + DatabaseName + " where " + Condition, connect);
                    SqlDataReader Reader = Command.ExecuteReader();

                    if (Reader.Read())
                    {
                        var blob = new Byte[(Reader.GetBytes(0, 0, null, 0, int.MaxValue))];
                        Reader.GetBytes(0, 0, blob, 0, blob.Length);

                        using (var fs = new FileStream(SaveFile.FileName, FileMode.Create, FileAccess.Write))
                        {
                            fs.Write(blob, 0, blob.Length);
                            System.Diagnostics.Process.Start(SaveFile.FileName);
                        }
                    }



                }
                catch (Exception ex)
                {
                    throw ex;
                }
                finally
                {
                    connect.Close();
                }
            }
            #endregion

            Nullable<bool> result1 = SaveFile1.ShowDialog();

            #region Attachement PDF
            if (result == true)
            {
                try
                {
                    connect.Open();
                    SqlCommand Command1 = new SqlCommand("Select " + FileColumnName1 + " From " + DatabaseName + " where " + Condition, connect);
                    SqlDataReader Reader1 = Command1.ExecuteReader();

                    if (Reader1.Read())
                    {
                        var blob1 = new Byte[(Reader1.GetBytes(0, 0, null, 0, int.MaxValue))];
                        Reader1.GetBytes(0, 0, blob1, 0, blob1.Length);

                        using (var fs = new FileStream(SaveFile1.FileName, FileMode.Create, FileAccess.Write))
                        {
                            fs.Write(blob1, 0, blob1.Length);
                            System.Diagnostics.Process.Start(SaveFile1.FileName);
                        }
                    }
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                finally
                {
                    connect.Close();
                }
            }
            #endregion


        } // use for retrived any file
    }
}

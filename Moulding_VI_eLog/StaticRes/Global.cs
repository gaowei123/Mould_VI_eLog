using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Automation.BDaq;
using System.Net;
using System.Windows.Media;

namespace StaticRes
{
    public class Global
    {
        public static System.Windows.ResourceDictionary CurrentLanguageRes = new System.Windows.ResourceDictionary();

        public static Common.Model.User_DB_Model Current_User = new Common.Model.User_DB_Model();

        public static Common.Model.User_DB_Model Current_User_Cancel = new Common.Model.User_DB_Model();

        public static string APP_ID = ID4.MS_MOULD;
        public static string MachineID = System.Configuration.ConfigurationSettings.AppSettings["MachineID"].ToString();
        public static string MouldCharst = System.Configuration.ConfigurationSettings.AppSettings["ModelCharst"].ToString();
        public static decimal CleanQty = decimal.Parse(System.Configuration.ConfigurationSettings.AppSettings["Clean"].ToString());
       
        public static DateTime CurDay = getDay(DateTime.Now);
        public static string CurShift = getShift(DateTime.Now);
        public static DateTime PreDay = getDay(DateTime.Now);
        public static string PreShift = getShift(DateTime.Now);
        public static string MachineStatus = "";
        public static string OeeStatus = "";
        public static DateTime machinetime = getDay(DateTime.Now);
        public static string Falg_User = string.Empty;
        public static string Falg_UserGroup = string.Empty;
        public static string OtherMachine = "8";
        public static string JigNo = "";
        public static bool _isUsingObjCurVi = false;
        public static string Status = "";

        public static string generateUniqueID(string sType)
        {
            string sID = ""; 
            sID = Guid.NewGuid().ToString(); 
            return sID; 
        }

        public static string getShift(DateTime now)
        {
            if (now.Hour >= 8 && now.Hour < 20)
            {
                return StaticRes.Global.ShiftValue.Day;
            }
            else
            {
                return StaticRes.Global.ShiftValue.Night;
            }
        }
        public static DateTime getDay(DateTime now)
        {
            if (now.Hour >= 8 )
            {
                return now.Date;
            }
            else
            {
                return now.AddDays(-1).Date;
            }
        }
        public static class ShiftValue
        {
            public static string Day = "Day";
            public static string Night = "Night";
        }

        public static class ReportType
        {
            public const string InventoryHistory = "Inventory History";
         }

        public static class Department
        {
            public const string Supervisor = "Supervisor";
            public const string Engineer = "Engineer";
            public const string Operator = "Operator";
            public const string Leader = "Leader";
            public const string MH = "MH";
            public const string IPQC = "IPQC";
            public const string Admin = "Admin";
        }

        public static class ID4
        {
            public const string MS_MOULD = "MOJLD";
            public const string MS_LASER = "LASER";
            public const string MS_PQC = "PQC";
        }

        public static class ButtonStaus
        {
            public static bool LoginOut = true;
            public static bool Running = true;
            public static bool MaterialTesting = true;
            public static bool MouldTesting = true;
            public static bool ChangeModel = true;
            public static bool BreakTime = true;
            public static bool NoOperator = true;
            public static bool NoMaterial = true;
            public static bool Adjustment = true;
            public static bool ShutDown = true;
            public static bool No_Schedule = true;
            public static bool MachineBreak = true;
            public static bool DamageMould = true;
        }

        public static class oee
        {
            public const string Operating = "Operating";
            public const string Adjustment = "Adjustment";
            public const string No_Schedule = "No_Schedule";
            public const string Testing = "Testing";
            public const string Break_Down = "Break_Down";
            public const string Shut_Down = "Shut_Down";
            public const string ChangeModel = "Change_Model";
        }

        public static class MachineSttaus
        {
            public const string Running = "Running";
            public const string MaterialTesting = "Material Testing";
            public const string MouldTesting = "Mould Testing";
            public const string ChangeModel = "Change Model";
            public const string BreakTime = "Break Time";
            public const string NoOperator = "No Operator";
            public const string NoMaterial = "No Material";
            public const string ShutDown = "ShutDown";
            public const string Adjustment = "Adjustment";
            public const string No_Schedule = "No_Schedule";
            public const string MachineBreak = "MachineBreak";
            public const string DamageMould = "DamageMould";
        }

        public static class Version
        {
            public const int VersionNumber = 1;
            public const int RevisionNumber = 1;
            public const string Date = "2018.11.16";

            public static string GetInfo()
            {
                string info = " Version " + VersionNumber.ToString() +
                              " Revision " + RevisionNumber.ToString() +
                              " (" + Date + ")";
                return info;
            }
        }
         public static class System_Setting
        {
            #region label Print
            public static string Printer_COM_Port = "COM1";
            public static int Printer_BaudRate = 9600;
            public static int Printer_DataBits = 8;
            public static int Printer_ReceivedBytesThreshold = 0;
            #endregion
            #region Scanner
            public static string Scanner_COM_Port = "COM2";
            public static int Scanner_BaudRate = 9600;
            public static int Scanner_DataBits = 8;
            public static int Scanner_ReceivedBytesThreshold = 0;
            #endregion
             
        }

        public static class Time_Frequency
        {
            public const string Daily = "Daily";
            public const string Weekly = "Weekly";
            public const string Monthly = "Monthly";
        }

        public static class COM_Port
        {
            public static System.IO.Ports.SerialPort Scanner = new System.IO.Ports.SerialPort();
            public static System.IO.Ports.SerialPort Printer = new System.IO.Ports.SerialPort();
        }
         
  
        public class SystemConfig
        {
            #region Mould

            public static double dCtrlWidth = 235;
            public static double dCtrlHeight = 83;
            public static double dGapWidth = 10;
            public static double dGapHeight = 5.5;
            public static double dDefectCodeFontSize = 18;
            public static double dTotalQtyFontSize = 20;
            public static Brush DefectButtonBgColor = new SolidColorBrush(Colors.CornflowerBlue);//StaticRes.ColorBrushes.Linear_Blue;
            public static Brush DefectButtonFontColor= new SolidColorBrush(Colors.White);

            public static void IniSystemSetting()
            {
                Common.BLL.APP_SETTING_BLL bSysBLL = new Common.BLL.APP_SETTING_BLL();
                List<Common.Model.APP_SETTING_Model> lSystemSetting = new List<Common.Model.APP_SETTING_Model>();
                lSystemSetting = bSysBLL.GetModelList("");
        
            }
            #endregion
 
        }
    }
}

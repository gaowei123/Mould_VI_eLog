using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;
using System.Threading;

namespace SBMS.Common
{
    public class Print
    {
        public static void SBMS(string Part_ID, string Machine_ID)
        {
            try
            {
                // Read the file as one string.
                if (Machine_ID.Length > 0)
                    Machine_ID = "(" + Machine_ID + ")";
                string sFilename = string.Empty;
                string sMessage = string.Empty;
                sFilename = System.AppDomain.CurrentDomain.SetupInformation.ApplicationBase + "123.txt";
                System.IO.StreamReader myFile = new System.IO.StreamReader(sFilename);
                sMessage = myFile.ReadToEnd();
                myFile.Close();

                sMessage = sMessage.Replace("67890", Part_ID);
                sMessage = sMessage.Replace("12345BWB123", Part_ID + " " + Machine_ID);
                //sValue1 = sValue;
                //sValue1 = sValue1.Insert(2, "&D");
                //sMessage = sMessage.Replace("B3&D33333333333", sValue1);
                sMessage = sMessage.Trim();

                int iLen = sMessage.IndexOf("E1");
                sMessage = sMessage.PadLeft(iLen + 2);
                sMessage += "\r\n\0";

                // Output it to the barcode printer.
                System.IO.Ports.SerialPort Printer = new System.IO.Ports.SerialPort();
                Printer.BaudRate = 9600;
                Printer.StopBits = System.IO.Ports.StopBits.One;
                Printer.DataBits = 8;
                Printer.PortName = "COM2";
                if (!Printer.IsOpen)
                    Printer.Open();
                Printer.Write(sMessage);
                if (Printer.IsOpen)
                    Printer.Close();
            }
            catch(Exception ee)
            {
                throw ee;
            }
        }
    }
}

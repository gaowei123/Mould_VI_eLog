using AlertEmailFor_Review.Database;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Net;
using System.Net.Mail;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;


namespace AlertEmailFor_Review
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            EmailFirstReview();
            EmailSecondreview();
            EmailPOApproval();
            EmailWaitingQuotationApproval("PENANG");
            EmailWaitingQuotationApproval("SHANGHAI");
            this.Close();
        }

        public void EmailWaitingQuotationApproval(string PurchaseSite)
        {
            string email = "";
            string name = "";

            string sql = "Select * from [UMS].[dbo].[BOM_List] where Approve_Reject2='Approved' and Supply_Approve_Reject <> 'Stock in list'";

                sql += " and Supply_Approve_Reject ='Waiting for Quotation Approval' and Purchaser='"+PurchaseSite+"'";

            string a = Database.Sql.ReadSQLCommand(sql);

            if(PurchaseSite=="SHANGHAI")
            {
                 email = "susan@ubct.com.my";
                 name = "SUSAN";
            }
            else
            {
                email = "ml.lee@ubct.com.my";
                name = "MAY LIN";
            }
          //  email = "laykim.yeoh@ubct.com.my";
            if (a != null)
            {               
                try
                {
                    SmtpClient client = new SmtpClient();
                    client.Port = 2525;
                    client.Host = "mail.ubct.com.my";
                    client.EnableSsl = true;
                    client.Timeout = 10000;
                    client.DeliveryMethod = SmtpDeliveryMethod.Network;
                    client.UseDefaultCredentials = false;
                    client.Credentials = new System.Net.NetworkCredential("ums@ubct.com.my", "Abc1234567890");

                    MailMessage mm = new MailMessage();
                    mm.From = new MailAddress("ums@ubct.com.my");
                    mm.To.Add(email);
                    mm.CC.Add("ums@ubct.com.my");
                    mm.BodyEncoding = UTF8Encoding.UTF8;
                    mm.DeliveryNotificationOptions = DeliveryNotificationOptions.OnFailure;
                    mm.IsBodyHtml = true;
                    mm.Subject = "Pending Waiting For Quotation Approval as of " + DateTime.Now.ToString("yyyy-MM-dd");

                    mm.Body = "<html><head></head><body><P>Hi " + name + ",<br><br>  The below PR is waiting for your Quotation Approval. <br>" +
                        "If you did not respond within 24 hour, this email will be escalate to next level. </P>" +
                                    "<table border = 2>" +
                                    "<tr>" +
                                           "<td width = 100> PR Number</td>" +
                                           "<td width = 100> Project Number </td>" +
                                          "<td width = 300> Description </td>" +
                                             "<td width = 100> Requester </td>" +
                                             "<td width = 100> Requester Date </td>" +
                                             "<td width = 100> Date For You </td>" +
                                              "<td width = 300> Apply Remark </td></tr>" +
                                             GetPRDetail("Waiting for Quotation Approval", name,PurchaseSite) +

                         "</table></body>" +
                                                  "</html> ";
                    ServicePointManager.ServerCertificateValidationCallback =
                    delegate (object s, X509Certificate certificate,
                    X509Chain chain, SslPolicyErrors sslPolicyErrors)
                    { return true; };

                    client.Send(mm);
                    Log("Successfully send Waiting Quotaion Approval reminder email to "+name);

                    string expirePR = CheckPRApprovalResponseTime("Waiting for Quotation Approval", name, PurchaseSite);

                    if (expirePR != "")
                    {
                        FirstEscalate(expirePR, email, name, "Waiting for Quotation Approval", "Waiting for Quotation Approval");
                    }

                }

                catch
                {
                    Log("Unsuccessfully send Waiting Quotaion Approval reminder email to " + name);
                }
            }
        }

        public void EmailFirstReview()
        {
            //Loop all the first reviewer
            List<string> firstReviewName = new List<string>();
            string email = "";

            firstReviewName = GetName("Waiting for first review", "First_Approval");
            //Get each reviewer email

            foreach(string name in firstReviewName)
            {
                email = GetEmailAddress(name);
                SendAlertEmail(email,"First Level Design Review", "Waiting for first review",name);
            }
        }

        public void EmailSecondreview()
        {
            //Loop all the first reviewer
            List<string> secondReviewName = new List<string>();
            string email = "";

            secondReviewName = GetName("Waiting for second review", "Second_Approval");
            //Get each reviewer email

            foreach (string name in secondReviewName)
            {
                email = GetEmailAddress(name);
                SendAlertEmail(email, "Second Level Design Review", "Waiting for second review", name);
            }
        }

        public void EmailPOApproval()
        {
            string sql = "SELECT * FROM [UMS].[dbo].[PO_List] where (Close_Status = '-' OR Close_Status = 'No Close') AND Approve_Reject ='Waiting for PO Approval'";

            string a = Database.Sql.ReadSQLCommand(sql);

            if (a != null)
            {
                string email = "hawke@ubct.com.my";

                //email = "laykim.yeoh@ubct.com.my";
                string name = "HAWKE";
                try
                {
                    SmtpClient client = new SmtpClient();
                    client.Port = 2525;
                    client.Host = "mail.ubct.com.my";
                    client.EnableSsl = true;
                    client.Timeout = 10000;
                    client.DeliveryMethod = SmtpDeliveryMethod.Network;
                    client.UseDefaultCredentials = false;
                    client.Credentials = new System.Net.NetworkCredential("ums@ubct.com.my", "Abc1234567890");

                    MailMessage mm = new MailMessage();
                    mm.From = new MailAddress("ums@ubct.com.my");
                    mm.To.Add(email);
                    mm.CC.Add("ums@ubct.com.my");
                    mm.BodyEncoding = UTF8Encoding.UTF8;
                    mm.DeliveryNotificationOptions = DeliveryNotificationOptions.OnFailure;
                    mm.IsBodyHtml = true;
                    mm.Subject = "Pending PO Approval as of " + DateTime.Now.ToString("yyyy-MM-dd");

                    mm.Body = "<html><head></head><body><P>Hi " + name + ",<br><br>  The below PO is waiting for your approval. <br>"+
                        "If you did not respond within 24 hour, this email will be escalate to next level. </P>" +
                               "<table border = 2>" +
                               "<tr>" +
                                      "<td width = 100> PO Number</td>" +
                                      "<td width = 100> Project Number </td>" +
                                     "<td width = 300> Vendor Address </td>" +
                                     "<td width = 100> Sum Price </td>" +
                                        "<td width = 100> Requester </td>" +
                                        "<td width = 100> Requester Date </td>"+
                                        "<td width = 300> Apply Remark </td></tr>" +

                                        GetPODetail() +

                    "</table></body>" +
                                             "</html> ";
                    ServicePointManager.ServerCertificateValidationCallback =
                    delegate (object s, X509Certificate certificate,
                    X509Chain chain, SslPolicyErrors sslPolicyErrors)
                    { return true; };

                    client.Send(mm);
                    Log("Successfully send PO reminder email" );

                    string expirePO = CheckPOApprovalResponseTime(name);

                    if (expirePO != "")
                    {
                       SecondEscalte( email, name, "Waiting for PO Approval", expirePO);
                    }

                }

                catch
                {
                    Log("Fail to send PO reminder email" );
                }
            }
        }

        private void SendAlertEmail(string email, string approvalLevel, string status, string name)
        {
           // email = "laykim.yeoh@ubct.com.my";
            string Emailstatus = "fail";
        //    for (int i = 0; i < 3; i++)
        //    {
                if (Emailstatus == "fail")
                {
                    try
                    {
                        SmtpClient client = new SmtpClient();
                        client.Port = 2525;
                        client.Host = "mail.ubct.com.my";
                        client.EnableSsl = true;
                        client.Timeout = 10000;
                        client.DeliveryMethod = SmtpDeliveryMethod.Network;
                        client.UseDefaultCredentials = false;
                        client.Credentials = new System.Net.NetworkCredential(email, "Abc1234567890");

                        MailMessage mm = new MailMessage();
                        mm.From = new MailAddress("ums@ubct.com.my");
                        mm.To.Add(email);
                        mm.CC.Add("ums@ubct.com.my");

                        mm.BodyEncoding = UTF8Encoding.UTF8;
                        mm.DeliveryNotificationOptions = DeliveryNotificationOptions.OnFailure;
                        mm.IsBodyHtml = true;
                        mm.Subject = "Pending Approval for " + approvalLevel + " as of " + DateTime.Now.ToString("yyyy-MM-dd");

                        mm.Body = "<html><head></head><body><P>Hi " + name + ",<br><br>  The below PR is waiting for your approval. <br>" +
                        "If you did not respond within 24 hour, this email will be escalate to next level. </P>" +
                                   "<table border = 2>" +
                                   "<tr>" +
                                          "<td width = 100> PR Number</td>" +
                                          "<td width = 100> Project Number </td>" +
                                         "<td width = 300> Description </td>" +
                                            "<td width = 100> Requester </td>" +
                                            "<td width = 100> Requester Date </td>" +
                                             "<td width = 100> Date For You </td>"+
                                              "<td width = 300> Apply Remark </td></tr>" +
                                            GetPRDetail(status, name,"") +

                        "</table></body>" +
                                                 "</html> ";
                        ServicePointManager.ServerCertificateValidationCallback =
                        delegate (object s, X509Certificate certificate,
                        X509Chain chain, SslPolicyErrors sslPolicyErrors)
                        { return true; };

                        client.Send(mm);
                        Log("Successfully send " + approvalLevel + "to " + name);
                        Emailstatus = "pass";

                       string expirePR = CheckPRApprovalResponseTime(status,name,"");

                        if(expirePR!="")
                        {
                            FirstEscalate(expirePR,email,name,status, approvalLevel);
                        }
                    }
                    catch
                    {
                        Log("Fail to send " + approvalLevel + "to " + name);
                        Emailstatus = "fail";
                    }
                }
            //}
        }

        private string CheckPRApprovalResponseTime(string status, string name,string purchaser)
        { 
            string a = GetPRDetail(status, name, purchaser);
            a= a.Replace("<td>", "");
            a = a.Replace("</td>", ";");
            a = a.Replace("</tr>","");
            a = a.Replace("<tr>", "");
            string[] AllPRDetail = a.Split(';');
            int nn = 0;
            string GetexpirePR = "";
            int j = (AllPRDetail.Length-1) / 7;

            if (j != 0)
            {
                if (status == "Waiting for first review")
                {
                    nn = 5;
                }
                else if (status == "Waiting for second review")
                {
                    nn = 5;
                }
                else if (status == "Waiting for Quotation Approval")
                {
                    nn = 5;
                }

                for (int k= nn; k < AllPRDetail.Length; k++)
                {
                    DateTime now = DateTime.Now;
                    string dd = AllPRDetail[k].ToString();
                    DateTime reqeustTime = DateTime.Parse((AllPRDetail[k].ToString()));

                    TimeSpan waitTime = now.Subtract(reqeustTime);

                    if (waitTime.TotalMinutes >= 1440.00)
                    {
                        string PR_No = (AllPRDetail[k - 5].ToString().Trim());
                        string Proj_No = (AllPRDetail[k - 4].ToString());
                        string Description = (AllPRDetail[k - 3].ToString());
                        string Requester = (AllPRDetail[k - 2].ToString());
                        string RequesterDate = (AllPRDetail[k-1].ToString());
                        string DateForYou = (AllPRDetail[k].ToString());
                        string Requester_Remark = (AllPRDetail[k+1].ToString());

                        GetexpirePR += GetEachPRlist(PR_No, Proj_No, Description, Requester, RequesterDate, DateForYou, Requester_Remark);
                    }

                    k += 6;
                }
            }

            return GetexpirePR;
        }

        private string CheckPOApprovalResponseTime(string name)
        {
            string a = GetPODetail();
            a = a.Replace("<td>", "");
            a = a.Replace("</td>", ";");
            a = a.Replace("</tr>", "");
            a = a.Replace("<tr>", "");
            string[] AllPRDetail = a.Split(';');
            string GetexpirePO = "";
            int j = (AllPRDetail.Length - 1) / 7;

            if (j != 0)
            {

                for (int k = 5; k < AllPRDetail.Length; k++)
                {
                    DateTime now = DateTime.Now;
                    string dd = AllPRDetail[k].ToString();
                    DateTime reqeustTime = DateTime.Parse((AllPRDetail[k].ToString()));

                    TimeSpan waitTime = now.Subtract(reqeustTime);

                    if (waitTime.TotalMinutes >= 1440.00)
                    {
                        string PONO = (AllPRDetail[k - 5].ToString().Trim());
                        string Proj_No = (AllPRDetail[k - 4].ToString());
                        string VendorAddress = (AllPRDetail[k - 3].ToString());
                        string ItemsumPrice = (AllPRDetail[k-2].ToString());
                        string Request_Date = (AllPRDetail[k].ToString());
                        string  Requester = (AllPRDetail[k - 1].ToString());
                        string apply_remark = (AllPRDetail[k + 1].ToString());

                        GetexpirePO += GetEachPOlist(PONO, Proj_No, VendorAddress, ItemsumPrice, Requester, Request_Date, apply_remark);
                    }

                    k += 6;
                }
            }

            return GetexpirePO;
        }

        private string GetEmailAddress(string name)
        {
            string email = "";
            if (Database.Sql.CheckConnection() == false)
            {
                return null;
            }
            string sql = "Select * from [UMS].[dbo].[User_List] where Name='"+name+"'";

            email = Database.Sql.ReadSelectedColumn(sql, "Email");

            return email;
        }

        private List<string> GetName(string status,string approvalLevel)
        {
            if (Database.Sql.CheckConnection() == false)
            {
                return null;
            }

            List<string> name = new List<string>();
            string sql = "Select DISTINCT "+ approvalLevel+" from [UMS].[dbo].[BOM_List] where";
 
                if (status == "Waiting for first review")
                {
                    sql += "[Approve_Reject1] ='Waiting for first Approval'";
                }
                else if (status == "Waiting for second review")
                {
                    sql += "[Approve_Reject1] ='Approved' and [Approve_Reject2] !='Approved' AND [Approve_Reject2] !='Rejected'";
                }
             

            name = Database.Sql.ReadSQLRow(sql, approvalLevel);

            return name;
            }

        private string GetPRDetail(string status,string name,string purchaser_site)
        {
            string tr = "";
            if (Database.Sql.CheckConnection() == false)
                return null;

            string sql = "Select * from [UMS].[dbo].[BOM_List] where";

            if (status == "Waiting for first review")
            {
                sql += "[Approve_Reject1] ='Waiting for first Approval' AND [First_Approval]='" + name + "'";
            }
            else if (status == "Waiting for second review")
            {
                sql += "[Approve_Reject1] ='Approved' and [Approve_Reject2] !='Approved' AND [Approve_Reject2] !='Rejected' AND [Second_Approval]='" + name + "'";
            }
            else if (status == "Waiting for Quotation Approval")
            {
                sql += "[Supply_Approve_Reject] ='"+ status + "' AND [Purchaser]='" + purchaser_site + "'";
            }

           DataTable DataTable = new DataTable();

            DataTable.BeginLoadData();

            SqlConnection connect = Connection.Server;
            connect.Open();
            SqlCommand Command = new SqlCommand(sql, connect);

            SqlDataReader reader = Command.ExecuteReader();

            DataTable.Load(reader);

            DataTable.EndLoadData();
            reader.Close();
            connect.Close();

            DataRow[] DataRow1 = DataTable.Select();


            foreach (DataRow DR in DataRow1)
            {
                string PRNO = DR[0].ToString();
                string Proj_No = DR[1].ToString();
                string Description = DR[7].ToString();
                string Requester = DR[15].ToString();
                string Request_Date = DR[16].ToString();
                string Requester_Remark = DR["Requester_Remark"].ToString();
                string DateForYou = "";

                if (status == "Waiting for first review")
                {
                    DateForYou = DR[16].ToString();
                }
                else if (status == "Waiting for second review")
                {
                    DateForYou = DR[19].ToString();
                }
                else if (status == "Waiting for Quotation Approval")
                {
                    DateForYou = DR[39].ToString();
                }


                tr += GetEachPRlist(PRNO, Proj_No, Description, Requester, Request_Date, DateForYou, Requester_Remark);
            }

            return tr;
        }

        private string GetPODetail()
        {
            if (Database.Sql.CheckConnection() == false)
                return null;

            string tr = "";
            DataTable DataTable = new DataTable();
            try
            {
                string sql = "SELECT * FROM [UMS].[dbo].[PO_List] where (Close_Status = '-' OR Close_Status = 'No Close') AND Approve_Reject ='Waiting for PO Approval'";

                Database.Sql.TableUpdate(sql).Fill(DataTable);

                DataRow[] DataRow1 = DataTable.Select();


                foreach (DataRow DR in DataRow1)
                {
                    string PONO = DR[0].ToString();
                    string Proj_No = DR[21].ToString();
                    string VendorAddress = DR[2].ToString();
                    string ItemsumPrice = DR[6].ToString();
                    string Requester = DR[9].ToString();
                    string Request_Date = DR[10].ToString();
                    string Apply_Remark = DR["Apply_Remark"].ToString();

                    tr += GetEachPOlist(PONO, Proj_No, VendorAddress, ItemsumPrice, Requester, Request_Date, Apply_Remark);
                }


            }
            catch
            {

            }
            return tr;
        }

        private string GetEachPRlist(string PR_No, string Proj_No, string Description, string Requester, string RequesterDate,string DateForYou,string Requester_Remark)
        {
            string getEachPRlist = "";
            getEachPRlist = " <tr>" +
                                " <td>" + PR_No + "</td>" +
                                "<td>" + Proj_No + "</td>" +
                                "<td>" + Description + "</td>" +
                                 "<td>" + Requester + "</td>" +
                                "<td>" + RequesterDate + "</td>" +
                                "<td>" + DateForYou + "</td>" +
                                 "<td>" + Requester_Remark + "</td>" +
                             "</tr>";

            return getEachPRlist;
        }

        private string GetEachPOlist(string pONO, string proj_No, string vendorAddress, string SumPrice, string requester, string request_Date,string Apply_Remark)
        {
            string getEachPOlist = "";
            getEachPOlist = " <tr>" +
                                " <td>" + pONO + "</td>" +
                                "<td>" + proj_No + "</td>" +
                                "<td>" + vendorAddress + "</td>" +
                                 "<td>" + SumPrice + "</td>" +
                                 "<td>" + requester + "</td>" +
                                "<td>" + request_Date + "</td>" +
                                   "<td>" + Apply_Remark + "</td>" +
                             "</tr>";

            return getEachPOlist;
        }

        private void Log(string msg)
        {
            try
            {
                string datePatt = @"yyyyMMdd";
                string path = "";
                string file = "";


                #region File.
              //  path = ".\\Log\\"; //Test Mode
                path= "D:\\Projects\\AlertEmail\\LOG"; 
                //Production Mode

                if (!Directory.Exists(path))
                {
                    System.IO.Directory.CreateDirectory(path);
                }

                file = path + DateTime.Now.ToString(datePatt) + ".txt";

                #endregion

                StreamWriter tw = File.AppendText(file);

                // Write a line of text to the file.
                tw.WriteLine(DateTime.Now.ToString("yyyyMMdd HH:mm:ss tt -- ") + msg);

                // Close the stream.
                tw.Flush();
                tw.Close();
            }
            catch
            {
                ; // .
            }
        }

        private void FirstEscalate(string expirePR,string email, string name, string statusaaaa,string approvalLevel)
        {
            string Emailstatus = "fail";
            string BCemail = "bc.tan@ubct.com.my";
            string HawkeEmail = "hawke@ubct.com.my";

           // BCemail = "laykim.yeoh@ubct.com.my";
           // HawkeEmail = "laykim.yeoh@ubct.com.my";
          //  for (int i = 0; i < 3; i++)
        //    {
                if (Emailstatus == "fail")
                {
                    try
                    {
                        SmtpClient client = new SmtpClient();
                        client.Port = 2525;
                        client.Host = "mail.ubct.com.my";
                        client.EnableSsl = true;
                        client.Timeout = 10000;
                        client.DeliveryMethod = SmtpDeliveryMethod.Network;
                        client.UseDefaultCredentials = false;
                        client.Credentials = new System.Net.NetworkCredential(email, "Abc1234567890");

                        MailMessage mm = new MailMessage();
                        mm.From = new MailAddress("ums@ubct.com.my");
                        mm.To.Add(email);
                        mm.To.Add(BCemail);
                        mm.To.Add(HawkeEmail);
                        mm.CC.Add("ums@ubct.com.my");

                        mm.BodyEncoding = UTF8Encoding.UTF8;
                        mm.DeliveryNotificationOptions = DeliveryNotificationOptions.OnFailure;
                        mm.IsBodyHtml = true;
                        mm.Subject = "ESCALATE PENDING APPROVAL for " + approvalLevel + " as of " + DateTime.Now.ToString("yyyy-MM-dd");

                        mm.Body = "<html><head></head><body><P>Hi BC & Hawke,<br><br>  The below PR is waiting for "+name+" approval. <br>" +
                        "He/She did not respond to the approval after 24 hour. </P>" +
                                   "<table border = 2>" +
                                   "<tr>" +
                                          "<td width = 100> PR Number</td>" +
                                          "<td width = 100> Project Number </td>" +
                                         "<td width = 300> Description </td>" +
                                            "<td width = 100> Requester </td>" +
                                            "<td width = 100> Requester Date </td>" +
                                            "<td width = 100> Date For Him/Her </td>"+
                                             "<td width = 300> Apply Remark</td></tr>" +
                                           expirePR +

                        "</table></body>" +
                                                 "</html> ";
                        ServicePointManager.ServerCertificateValidationCallback =
                        delegate (object s, X509Certificate certificate,
                        X509Chain chain, SslPolicyErrors sslPolicyErrors)
                        { return true; };

                        client.Send(mm);
                        Log("Successfully send " + approvalLevel + "to " + name);
                        Emailstatus = "pass";
                    }
                    catch
                    {
                        Log("Fail to send " + approvalLevel + "to " + name);
                        Emailstatus = "fail";
                    }
              //  }
            }
        }

        private void SecondEscalte(string email,string name, string approvalLevel ,string expirePO)
        {
            string Emailstatus = "fail";
            string BCemail = "bc.tan@ubct.com.my";
            //string HawkeEmail = "hawke@ubct.com.my";

            // BCemail = "laykim.yeoh@ubct.com.my";

         //   for (int i = 0; i < 3; i++)
      //      {
                if (Emailstatus == "fail")
                {
                    try
                    {
                        SmtpClient client = new SmtpClient();
                        client.Port = 2525;
                        client.Host = "mail.ubct.com.my";
                        client.EnableSsl = true;
                        client.Timeout = 10000;
                        client.DeliveryMethod = SmtpDeliveryMethod.Network;
                        client.UseDefaultCredentials = false;
                        client.Credentials = new System.Net.NetworkCredential(email, "Abc1234567890");

                        MailMessage mm = new MailMessage();
                        mm.From = new MailAddress("ums@ubct.com.my");
                        mm.To.Add(email);
                        mm.To.Add(BCemail);
                        mm.CC.Add("ums@ubct.com.my");

                        mm.BodyEncoding = UTF8Encoding.UTF8;
                        mm.DeliveryNotificationOptions = DeliveryNotificationOptions.OnFailure;
                        mm.IsBodyHtml = true;
                        mm.Subject = "ESCALATE PENDING APPROVAL for " + approvalLevel + " as of " + DateTime.Now.ToString("yyyy-MM-dd");

                        mm.Body = "<html><head></head><body><P>Hi BC,<br><br>  The below PO is waiting for " + name + " approval. <br>" +
                        "He/She did not respond to the approval after 24 hour. </P>" +
                                   "<table border = 2>" +
                                   "<tr>" +
                                         "<td width = 100> PO Number</td>" +
                                      "<td width = 100> Project Number </td>" +
                                     "<td width = 300> Vendor Address </td>" +
                                     "<td width = 100> Sum Price </td>" +
                                        "<td width = 100> Requester </td>" +
                                        "<td width = 100> Requester Date </td>" +
                                        "<td width = 300> Apply Remark </td></tr>" +
                                           expirePO +

                        "</table></body>" +
                                                 "</html> ";
                        ServicePointManager.ServerCertificateValidationCallback =
                        delegate (object s, X509Certificate certificate,
                        X509Chain chain, SslPolicyErrors sslPolicyErrors)
                        { return true; };

                        client.Send(mm);
                        Log("Successfully send " + approvalLevel + "to " + name);
                        Emailstatus = "pass";
                    }
                    catch
                    {
                        Log("Fail to send " + approvalLevel + "to " + name);
                        Emailstatus = "fail";
                    }
              //  }
            }
        }

        
    }
}

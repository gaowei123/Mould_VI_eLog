using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.IO;
using System.Threading;
using System.Data;

namespace VI_eLog.Views
{
    /// <summary>
    /// Login.xaml 的交互逻辑
    /// </summary>
    public partial class Login : Window
    {
        #region ****** 外部消息扩展 ******
        public delegate void BackMaskEventHandler();
        private BackMaskEventHandler backClick;
        public event BackMaskEventHandler BackClick
        {
            add
            {
                backClick += value;
            }
            remove
            {
                backClick -= value;
            }
        }

        public delegate void HDClickEventHandler();
        private event HDClickEventHandler LoginSuccessful;
        public event HDClickEventHandler HDClick
        {
            add
            {
                LoginSuccessful += value;
            }
            remove
            {
                LoginSuccessful -= value;
            }
        }
        #endregion

        private delegate void ReadCom();
        private delegate void XError(string Error_Message);
        private delegate void Complete(string Finger_Template, bool succesful, string User_ID);


        public Login()
        {
            this.InitializeComponent();
            try
            {
                Resources.MergedDictionaries.Add(StaticRes.Global.CurrentLanguageRes);
                this.txt_userID.Background = StaticRes.ColorBrushes.Linear_Green;
                this.txt_Password.Background = StaticRes.ColorBrushes.Linear_Green;
                //kb.CurrentTextBox = null;
                //kb.CurrentPasswordBox = this.txt_userID;
                InitComPort();
                User_ID_Validate();
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void Display_CaptureFingerBmp()
        {
            try
            {

            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void KeyBoard_EnterClick()
        {

        }
        

        private void txt_userID_KeyDown(object sender, System.Windows.Input.KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                try
                {
                    User_ID_Validate();
                }
                catch (Exception ee)
                {
                    MessageBox.Show(ee.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
        }

        private void User_ID_Validate()
        {
            try
            {

            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void btn_login_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            Password_Validate();
        }

        private void Password_Validate()
        {
            try
            {
                Common.Model.User_DB_Model _bModel = new Common.Model.User_DB_Model();
                Common.BLL.User_DB_BLL _bUser = new Common.BLL.User_DB_BLL();
                if (_bUser.CheckIDPassword(txt_userID.Password.ToString(), txt_Password.Password.ToString()))
                {
                    StaticRes.Global.Falg_User = txt_userID.Password.ToString();
                    _bModel = _bUser.Validate_User(txt_userID.Password.ToString(), txt_Password.Password.ToString());
                    StaticRes.Global.Falg_UserGroup = _bModel.User_group;
                    LoginSuccessful();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("User ID or Password not match！", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void btn_cancel_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            try
            {
                this.Close();
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void kb_EnterClick()
        {
            User_ID_Validate();
        }

        #region Handle Scanner
        private System.IO.Ports.SerialPort Handle_Scanner = new System.IO.Ports.SerialPort();

        private void InitComPort()
        {
            //try
            //{
            //    if (Handle_Scanner.IsOpen)
            //        Handle_Scanner.Close();
            //    Handle_Scanner.BaudRate = StaticRes.Global.System_Setting.Handle_Scanner_BaudRate;
            //    Handle_Scanner.StopBits = System.IO.Ports.StopBits.One;
            //    Handle_Scanner.DataBits = StaticRes.Global.System_Setting.Handle_Scanner_DataBits;
            //    Handle_Scanner.PortName = StaticRes.Global.System_Setting.Handle_Scanner_COM_Port;

            //    if (!Handle_Scanner.IsOpen)
            //        Handle_Scanner.Open();

            //    Handle_Scanner.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(Scanner_DataReceived);
            //}
            //catch (Exception ee)
            //{
            //    MessageBox.Show(ee.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            //    Common.Reports.LogFile.Log("Error: " + ee.Message + " when Initial handle scanner port in login page ");
            //}
        }

        private void CloseComPort()
        {
            //try
            //{
            //    Handle_Scanner.DataReceived -= new System.IO.Ports.SerialDataReceivedEventHandler(Scanner_DataReceived);

            //    if (Handle_Scanner.IsOpen)
            //        Handle_Scanner.Close();
            //}
            //catch (Exception ee)
            //{
            //    MessageBox.Show(ee.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            //    Common.Reports.LogFile.Log("Error: " + ee.Message + " when close handle scanner port in login page ");
            //}
        }

        void Scanner_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {

        }

        void DoReadCom()
        {

        }
        #endregion

        #region Thread Return
        void fp_RegisterError(string Error_Message)
        {
            this.Dispatcher.Invoke(new XError(DoError), new object[1] { Error_Message });
        }
        private void DoError(string Error_Message)
        {
            try
            {
            }
            catch
            {
            }
        }

        void fp_RegisterComplete(string Finger_Template, bool succesful, string User_ID)
        {
            this.Dispatcher.Invoke(new Complete(DoComplete), new object[3] { Finger_Template, true, User_ID });
        }
        private void DoComplete(string Register_Finger_Template, bool Successful, string User)
        {
            try
            {

                this.Close();
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void kb_UndoClick()
        {
        }
        #endregion

        private void txt_Password_KeyDown(object sender, KeyEventArgs e)
        {

        }
    }
}
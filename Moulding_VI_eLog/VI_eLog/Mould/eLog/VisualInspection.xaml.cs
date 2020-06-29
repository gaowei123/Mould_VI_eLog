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
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Data;
using System.Net.Mail;
using System.Net;
using System.Security.Cryptography.X509Certificates;
using System.Net.Security;
using System.Windows.Threading;
using Common.Model;
using System.Diagnostics;
using Microsoft.VisualBasic;

namespace VI_eLog.Mould.eLog
{
    public partial class VisualInspection : UserControl
    {
        public string _alertMsg = "";
        private Common.Model.MouldingViTracking_Model _objCurVi = new MouldingViTracking_Model();
        private Common.Model.MouldingMachineStatus_Model _objMachine = new MouldingMachineStatus_Model();
        private int _Number = 0;
        bool _flag = true;
        private bool _lightHigh = true;
        decimal? _PQMCal = 0;
        private DateTime _EventTime = System.DateTime.Now;

        DispatcherTimer timerTick = new DispatcherTimer();

        public VisualInspection()
        {
            InitializeComponent();
            //2018 09 11 by lijia
            iniDropDownList();

            

            refreshController();

            iniTabControl();

            //refreshController();

            //2018 09 11 by lijia
            funPendingLogOutController();
            //inmachine();
            #region Timer Tick 
            timerTick.Tick += new EventHandler(Timer);
            timerTick.Interval = TimeSpan.FromSeconds(60);
            timerTick.Start();
            #endregion
            
        }

       

        
        void Timer(object sender, EventArgs e)
        { 
            if (StaticRes.Global.CurDay != StaticRes.Global.PreDay || StaticRes.Global.CurShift != StaticRes.Global.PreShift)
            {
                _alertMsg = "";
                StaticRes.Global.PreDay = StaticRes.Global.getDay(DateTime.Now);
                StaticRes.Global.PreShift = StaticRes.Global.getShift(DateTime.Now);
                _alertMsg = "Shift Changed. System Auto LogOut!";
                StaticRes.Global.Current_User = new Common.Model.User_DB_Model();  //auto log out
                refreshController();
                LoginOut();
                funPendingLogOutController();
                ChangeShift();
            }
          


            //refleash current VI tracking
            if (!StaticRes.Global._isUsingObjCurVi)
            {
                _objCurVi = refreshVidata(StaticRes.Global.CurDay, StaticRes.Global.CurShift, (_objCurVi == null || _objCurVi.partNumber == null ? "" : _objCurVi.partNumber), StaticRes.Global.MachineID);

                //op each hour check if not check after 50 made button change colour 2018/9/13
                CheckEachHour();

                //2hour leader check
                LeaderCheck();
            }


            //Show "Mould Life End" / "Mould Needs Maintenance" Message
            if (_objCurVi != null && !string.IsNullOrEmpty(_objCurVi.partnumberall))
            {
                Common.BLL.MouldingMoldLife_BLL moldLifeBLL = new Common.BLL.MouldingMoldLife_BLL();
                Common.Model.MouldingMoldLife moldLifeModel = moldLifeBLL.GetModel(_objCurVi.partnumberall);
                
                if (moldLifeModel.Accumulate >= moldLifeModel.MouldLife)
                {
                    remindOn(true);
                }
                else if (moldLifeModel.Clean1Qty >= StaticRes.Global.CleanQty)
                {
                    remindOn(false);
                }
            }

            



            //set Major Info
            setMajorInfo(false);
        }


       #region "DropDownList setting "  //2018 09 11 by lijia
        private void setCustomerList(List<Common.Model.MouldingBom_Model> objMoldBomList, string CurValue)
        {
            cbxCustomer.Items.Clear();
            cbxCustomer.Items.Add("");
            foreach (Common.Model.MouldingBom_Model objBom in objMoldBomList)
            {
                if (this.cbxCustomer.Items.IndexOf(objBom.customer) < 0)
                {
                    cbxCustomer.Items.Add(objBom.customer);
                } 
            }

            if (CurValue.Trim().Length == 0)
            {
                cbxCustomer.SelectedIndex = 0;
            }
            else
            {
                cbxCustomer.SelectedIndex = cbxCustomer.Items.IndexOf(CurValue) > 0 ? cbxCustomer.Items.IndexOf(CurValue) : 0;
            }
        }
        private void inmachine()
        {
            StaticRes.Global.MachineStatus = StaticRes.Global.MachineSttaus.No_Schedule;
            StaticRes.Global.OeeStatus = StaticRes.Global.oee.No_Schedule;
            if (updatemachine(false))
            {

            }

        }
        private void setModelList(List<Common.Model.MouldingBom_Model> objMoldBomList, string CurValue)
        {
            cbxModel.Items.Clear();
            cbxModel.Items.Add("");
            foreach (Common.Model.MouldingBom_Model objBom in objMoldBomList)
            {
                if (this.cbxModel.Items.IndexOf(objBom.model) < 0)
                {
                    cbxModel.Items.Add(objBom.model);
                }

            }
            if (CurValue.Trim().Length == 0)
            {
                cbxModel.SelectedIndex = 0;
            }
            else
            {
                cbxModel.SelectedIndex = cbxModel.Items.IndexOf(CurValue) > 0 ? cbxModel.Items.IndexOf(CurValue) : 0;
            }
        }
        private void setPartNumberAllList(List<Common.Model.MouldingBom_Model> objMoldBomList, string CurValue)
        {
            cbxPartNo.Items.Clear();
            cbxPartNo.Items.Add("");
            foreach (Common.Model.MouldingBom_Model objBom in objMoldBomList)
            {
                if (this.cbxPartNo.Items.IndexOf(objBom.partnumberall) < 0)
                {
                    cbxPartNo.Items.Add(objBom.partnumberall);
                }

            }
            if (CurValue.Trim().Length == 0)
            {
                cbxPartNo.SelectedIndex = 0;
            }
            else
            {
                cbxPartNo.SelectedIndex = cbxPartNo.Items.IndexOf(CurValue) > 0 ? cbxPartNo.Items.IndexOf(CurValue) : 0;
            }
        }
        private void setMatPart01List(List<Common.Model.MouldingBom_Model> objMoldBomList, string CurValue)
        {
            cbxMat1Part.Items.Clear();
            cbxMat1Part.Items.Add("");
            foreach (Common.Model.MouldingBom_Model objBom in objMoldBomList)
            {
                if (this.cbxMat1Part.Items.IndexOf(objBom.matPart01) < 0)
                {
                    cbxMat1Part.Items.Add(objBom.matPart01);
                }

            }
            if (CurValue.Trim().Length == 0)
            {
                cbxMat1Part.SelectedIndex = 0;
            }
            else
            {
                cbxMat1Part.SelectedIndex = cbxMat1Part.Items.IndexOf(CurValue) > 0 ? cbxMat1Part.Items.IndexOf(CurValue) : 0;
            }
        }
        private void setMatPart02List(List<Common.Model.MouldingBom_Model> objMoldBomList, string CurValue)
        {
            cbxMat2Part.Items.Clear();
            cbxMat2Part.Items.Add("");
            foreach (Common.Model.MouldingBom_Model objBom in objMoldBomList)
            {
                if (this.cbxMat2Part.Items.IndexOf(objBom.matPart02) < 0)
                {
                    cbxMat2Part.Items.Add(objBom.matPart02);
                }

            }
            if (CurValue.Trim().Length == 0)
            {
                cbxMat2Part.SelectedIndex = 0;
            }
            else
            {
                cbxMat2Part.SelectedIndex = cbxPartNo.Items.IndexOf(CurValue) > 0 ? cbxMat2Part.Items.IndexOf(CurValue) : 0;
            }
        }
        private List<Common.Model.MouldingBom_Model> getDropDownList(string ListItem, string sCustomer, string sModel, string sPartNoAll)
        {
            Common.BLL.MouldingBom_BLL bllMoldBom = new Common.BLL.MouldingBom_BLL();
            List<Common.Model.MouldingBom_Model> objMoldBomList = new List<Common.Model.MouldingBom_Model>();
            objMoldBomList = bllMoldBom.getDistinctList(sCustomer, sModel, sPartNoAll);
            return objMoldBomList;
        }
        private void iniDropDownList()
        {
            List<Common.Model.MouldingBom_Model> objMoldBomList = new List<Common.Model.MouldingBom_Model>();
            objMoldBomList = getDropDownList("", "", "", "");
            setCustomerList(objMoldBomList, "");
            setModelList(objMoldBomList, "");
            setPartNumberAllList(objMoldBomList, "");
            setMatPart01List(objMoldBomList, "");
            setMatPart02List(objMoldBomList, "");
        }
        private void cbx_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            try
            {
                string sCustomer = cbxCustomer.SelectedValue.ToString();
                string sModel = cbxModel.SelectedValue.ToString();
                string sPartNumberAll = cbxPartNo.SelectedValue.ToString();

                List<Common.Model.MouldingBom_Model> objMoldBomList = new List<Common.Model.MouldingBom_Model>();

                if (((ComboBox)sender).Name.Contains("Customer"))
                {
                    objMoldBomList = getDropDownList("", sCustomer, "", ""); 
                    //  setCustomerList(objMoldBomList, sCustomer);
                    setModelList(objMoldBomList, sModel);
                    setPartNumberAllList(objMoldBomList, sPartNumberAll);
                }
                else if (((ComboBox)sender).Name.Contains("Model"))
                {
                    objMoldBomList = getDropDownList("", sCustomer, sModel, "");  
                    setPartNumberAllList(objMoldBomList, sPartNumberAll);

                }
                else if (((ComboBox)sender).Name.Contains("PartNo"))
                {
                }
                objMoldBomList = getDropDownList("", sCustomer, sModel, sPartNumberAll);

                setMatPart01List(objMoldBomList, "");
                setMatPart02List(objMoldBomList, "");
            }
            catch (Exception)
            {


            }
        }
       #endregion 

        private void setMajorInfo(bool isAlarm)
        {
            if(isAlarm)
            {
                this.lblMajorInfo.Foreground = new SolidColorBrush( Colors.Red);
                this.lblMajorInfo.Content = _alertMsg;
            }
            else
            {
                this.lblMajorInfo.Foreground = new SolidColorBrush(Colors.DarkBlue);
                this.lblMajorInfo.Content = "Total QTY : " + (this.tbkTotalQty.Text.Trim() == "" ? "0":  this.tbkTotalQty.Text.Trim() ) .PadRight(10,char.Parse(" "))
                     + "Pass QTY : " + (this.tbkPassQty.Text.Trim() == "" ? "0" : this.tbkPassQty.Text.Trim()).PadRight(10, char.Parse(" "))
                     + "Fail QTY : " + (this.tbkFailQty.Text.Trim() == "" ? "0" : this.tbkFailQty.Text.Trim()).PadRight(10, char.Parse(" "));
            }
        }

        #region change button colour
        private void CheckEachHour()
        {
            DateTime dTime = DateTime.Now;
            _objCurVi = refreshVidata(StaticRes.Global.CurDay, StaticRes.Global.CurShift, (_objCurVi == null || _objCurVi.partNumber == null ? "" : _objCurVi.partNumber), StaticRes.Global.MachineID);
            if (_objCurVi == null)
            {
                //_alertMsg = "Please Submit Correct Part No first!";
                //MessageBox.Show(_alertMsg);
            }
            else
            {

                int iHour = dTime.Hour;
                int iMinutes = dTime.Minute;
                if (iMinutes <= 5)
                {
                    _lightHigh = true;
                    this.btnOpHourlyCheck.Background = new SolidColorBrush(Colors.CornflowerBlue);
                    return;
                }
                if (!_lightHigh)
                {
                    if (iHour > 12)
                    {
                        iHour = iHour - 12;
                    }
                    switch (iHour)
                    {
                        case (1):
                            {
                                if (_objCurVi.opSign01.Length != 0)
                                {
                                    _lightHigh = false;
                                    break;
                                }
                                else
                                {
                                    _lightHigh = true;
                                    break;
                                }
                            }
                        case (2):
                            {
                                if (_objCurVi.opSign02.Length != 0)
                                {
                                    _lightHigh = false;
                                    break;
                                }
                                else
                                {
                                    _lightHigh = true;
                                    break;
                                }
                            }

                        case (3):
                            {
                                if (_objCurVi.opSign03.Length != 0)
                                {
                                    _lightHigh = false;
                                    break;
                                }
                                else
                                {
                                    _lightHigh = true;
                                    break;
                                }
                            }

                        case (4):
                            {
                                if (_objCurVi.opSign04.Length != 0)
                                {
                                    _lightHigh = false;
                                    break;
                                }
                                else
                                {
                                    _lightHigh = true;
                                    break;
                                }
                            }

                        case (5):
                            {
                                if (_objCurVi.opSign05.Length != 0)
                                {
                                    _lightHigh = false;
                                    break;
                                }
                                else
                                {
                                    _lightHigh = true;
                                    break;
                                }
                            }

                        case (6):
                            {
                                if (_objCurVi.opSign06.Length != 0)
                                {
                                    _lightHigh = false;
                                    break;
                                }
                                else
                                {
                                    _lightHigh = true;
                                    break;
                                }
                            }
                        case (7):
                            {
                                if (_objCurVi.opSign07.Length != 0)
                                {
                                    _lightHigh = false;
                                    break;
                                }
                                else
                                {
                                    _lightHigh = true;
                                    break;
                                }
                            }
                        case (8):
                            {
                                if (_objCurVi.opSign08.Length != 0)
                                {
                                    _lightHigh = false;
                                    break;
                                }
                                else
                                {
                                    _lightHigh = true;
                                    break;
                                }
                            }
                        case (9):
                            {
                                if (_objCurVi.opSign09.Length != 0)
                                {
                                    _lightHigh = false;
                                    break;
                                }
                                else
                                {
                                    _lightHigh = true;
                                    break;
                                }
                            }
                        case (10):
                            {
                                if (_objCurVi.opSign10.Length != 0)
                                {
                                    _lightHigh = false;
                                    break;
                                }
                                else
                                {
                                    _lightHigh = true;
                                    break;
                                }
                            }
                        case (11):
                            {
                                if (_objCurVi.opSign11.Length != 0)
                                {
                                    _lightHigh = false;
                                    break;
                                }
                                else
                                {
                                    _lightHigh = true;
                                    break;
                                }
                            }
                        case (12):
                            {
                                if (_objCurVi.opSign12.Length != 0)
                                {
                                    _lightHigh = false;
                                    break;
                                }
                                else
                                {
                                    _lightHigh = true;
                                    break;
                                }
                            }
                    }
                }
                if (iMinutes >= 50 && _lightHigh == true)
                {
                    this.btnOpHourlyCheck.Background = new SolidColorBrush(Colors.Orange);
                }
            }
        }

        private void LeaderCheck()
        {
            DateTime dTime = DateTime.Now;
            _objCurVi = refreshVidata(StaticRes.Global.CurDay, StaticRes.Global.CurShift, (_objCurVi == null || _objCurVi.partNumber == null ? "" : _objCurVi.partNumber), StaticRes.Global.MachineID);
            if (_objCurVi == null)
            {
                //_alertMsg = "Please Submit Correct Part No first!";
                //MessageBox.Show(_alertMsg);
            }
            else
            {
                int iHour = dTime.Hour;
                int iMinutes = dTime.Minute;
                if (iHour > 12)
                {
                    iHour = iHour - 12;
                }
                if (_objCurVi.LeaderCheckTime != null)
                {
                    if (_objCurVi.LeaderCheckTime.Value.AddHours(1).AddMinutes(50) < dTime)
                    {
                        this.btnleaderChcek.Background = new SolidColorBrush(Colors.Orange);
                    }
                }
                else
                {
                    if(_objCurVi.startTime.Value.AddHours(1).AddMinutes(50) < dTime)
                    {
                        this.btnleaderChcek.Background = new SolidColorBrush(Colors.Orange);
                    }
                }
            
            }
        }
        #endregion 
        private void refreshController()
        {
            lblTitle.Content = " Machine " + StaticRes.Global.MachineID.PadLeft(2, char.Parse("0")) + "   " + StaticRes.Global.CurDay.ToString("yyyy-MM-dd") + " " + StaticRes.Global.CurShift + " Shift";
            _objMachine.machineID = StaticRes.Global.MachineID;
            _objMachine.day = StaticRes.Global.CurDay;
            _objMachine.shift = StaticRes.Global.CurShift;
            if (_objMachine.machineID == StaticRes.Global.OtherMachine)
            {
                _Number = 1;
            }
            //if (StaticRes.Global.Current_User != null && StaticRes.Global.Current_User.userID != null && StaticRes.Global.Current_User.userID !="" )
            if (StaticRes.Global.Current_User != null || StaticRes.Global.Current_User.userID != null || StaticRes.Global.Current_User.userID != "")
            {
                funPendingLogOutCotroller(); 
            }
            else
            {
                funPendingLogInCotroller();
            }
            setMajorInfo(false);
        }
       
        private void btnSignOut_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Change User Sing out ？", "", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                LoginOut();
                funPendingLogOutController();
                setBtn();
            }
            else
            {
                return;
            }
        }

        private void setBtn()
        {
            StaticRes.Global.ButtonStaus.Running = true;
            StaticRes.Global.ButtonStaus.MaterialTesting = true;
            StaticRes.Global.ButtonStaus.MouldTesting = true;
            StaticRes.Global.ButtonStaus.ChangeModel = true;
            StaticRes.Global.ButtonStaus.BreakTime = true;
            StaticRes.Global.ButtonStaus.NoMaterial = true;
            StaticRes.Global.ButtonStaus.NoOperator = true;
            StaticRes.Global.ButtonStaus.Adjustment = true;
            StaticRes.Global.ButtonStaus.ShutDown = true;
            StaticRes.Global.ButtonStaus.No_Schedule = true;
            StaticRes.Global.ButtonStaus.MachineBreak = true;
            StaticRes.Global.ButtonStaus.DamageMould = true;
            this.BtnRunning.Background = Brushes.CornflowerBlue;
            this.BtnMaterial_Testing.Background = Brushes.CornflowerBlue;
            this.BtnMould_Testing.Background = Brushes.CornflowerBlue;
            this.BtnModel.Background = Brushes.CornflowerBlue;
            this.BtnBreak_Time.Background = Brushes.CornflowerBlue;
            this.BtnNo_Material.Background = Brushes.CornflowerBlue;

            this.BtnNo_Operatoer.Background = Brushes.CornflowerBlue;
            this.BtnAdjustment.Background = Brushes.CornflowerBlue;
            this.BtnShut_Down.Background = Brushes.CornflowerBlue;
            this.BtnNoSchedule.Background = Brushes.CornflowerBlue;
            this.BtnMachineBreak.Background = Brushes.CornflowerBlue;
            this.BtnDamageMould.Background = Brushes.CornflowerBlue;
        }


        private void LoginOut()
        {
            try
            {
                int _flag = _Number;
                bool _sStatus = false;
                decimal? Total = 0;
                if (_objMachine.machineID == StaticRes.Global.OtherMachine)
                {
                    _flag--;
                }
                Common.BLL.MouldingViTracking_BLL bllVi = new Common.BLL.MouldingViTracking_BLL();
                Common.Model.MouldingViTracking_Model objCurVi = new Common.Model.MouldingViTracking_Model();
                List<System.Data.SqlClient.SqlCommand> lSqlCmd = new List<System.Data.SqlClient.SqlCommand>();
                for (int i = 0; i < _flag; i++)
                {
                    _sStatus = true;
                    string[] sAPartNo = cbxPartNo.SelectedValue.ToString().Split(',');
                    objCurVi = bllVi.GetModel_ByDayShiftAllPartMachine(StaticRes.Global.CurDay, StaticRes.Global.CurShift, sAPartNo[i], StaticRes.Global.MachineID);
                    if (objCurVi != null)
                    {
                        
                        Common.BLL.MouldingPqm_BLL _PqmBll = new Common.BLL.MouldingPqm_BLL();
                        string swhere = "machineID = 'MC0" + StaticRes.Global.MachineID + "'";
                        DataSet dt = _PqmBll.GetList(swhere);
                        this.tbkCycleTime.Text = int.Parse(dt.Tables[0].Rows[0]["cycleTime"].ToString()).ToString();
                        this.tbkTotalQty.Text = ((int.Parse(dt.Tables[0].Rows[0]["totalQTY"].ToString())) * objCurVi.cavityCount).ToString();
                        this.tbkPassQty.Text = ((int.Parse(dt.Tables[0].Rows[0]["totalQTY"].ToString()) * objCurVi.cavityCount) - objCurVi.rejectQty - objCurVi.QCNGQTY).ToString();
                        decimal? oldacountReading = objCurVi.acountReading;
                        Total = oldacountReading;
                        objCurVi.cycleTime = int.Parse(this.tbkCycleTime.Text);
                        objCurVi.lastUpdatedTime = System.DateTime.Now;
                        objCurVi.acountReading = int.Parse(this.tbkTotalQty.Text) - objCurVi.lastQty;
                        objCurVi.acceptQty = (objCurVi.acountReading - objCurVi.rejectQty - objCurVi.QCNGQTY);
                        if (objCurVi.acountReading < 0)
                        {
                            objCurVi.lastQty = -_PQMCal;
                            objCurVi.acountReading = int.Parse(this.tbkTotalQty.Text) - objCurVi.lastQty;
                            objCurVi.acceptQty = (objCurVi.acountReading - objCurVi.rejectQty - objCurVi.QCNGQTY);
                            //_PQMCal = objCurVi.acountReading;
                        }
                        else if ((objCurVi.acountReading - oldacountReading) < 0)
                        {
                            objCurVi.lastQty = -_PQMCal;
                            objCurVi.acountReading = int.Parse(this.tbkTotalQty.Text) - objCurVi.lastQty;
                            objCurVi.acceptQty = (objCurVi.acountReading - objCurVi.rejectQty - objCurVi.QCNGQTY);
                            //_PQMCal = objCurVi.acountReading;
                        }
                        else
                        {
                            //_PQMCal = objCurVi.acountReading;
                        }
                        objCurVi.lastUpdatedTime = System.DateTime.Now;
                        Total = (objCurVi.acountReading - Total) / objCurVi.cavityCount;
                        lSqlCmd.Add(bllVi.UpdateCommandbypartnumber(objCurVi));

                    }
                    else
                    {
                        _sStatus = false;
                    }
                }
                if (objCurVi != null)
                {
                    _PQMCal = objCurVi.acountReading;
                }
                DBHelp.SqlDB.SetData_Rollback(lSqlCmd);
                if (_sStatus)
                {
                    Common.Model.MouldingMoldLife modellife = new Common.Model.MouldingMoldLife();
                    Common.BLL.MouldingMoldLife_BLL blllife = new Common.BLL.MouldingMoldLife_BLL();
                    try
                    {
                        if (!MouldCharst(cbxPartNo.SelectedValue.ToString()))
                        {
                            modellife = blllife.GetModel(cbxPartNo.SelectedValue.ToString());
                            if (modellife.PartNumberAll != null)
                            {
                                modellife.Accumulate = modellife.Accumulate + Total;
                                modellife.Clean1Qty = modellife.Clean1Qty + Total;
                                modellife.UpdatedTime = DateTime.Now;
                                modellife.MachineID = "";
                                if (!blllife.Update(modellife))
                                {
                                    DBHelp.Reports.LogFile.DebugLog("Error", "RefreshVidata modellife", "Visuallnspection", "", "when update modellife");
                                    
                                }
                                else
                                {
                                    DBHelp.Reports.LogFile.DebugLog("ModelLife", "RefreshVidata modellife", "Visuallnspection", "", "MachineID : " + modellife.MachineID + " PartNumberAll: " + modellife.PartNumberAll + " Accumulate: " + modellife.Accumulate + " Clean1Qty : " + modellife.Clean1Qty + " ");
                                }
                            }
                            else
                            {
                                modellife.MoldID = cbxPartNo.SelectedValue.ToString();
                                modellife.PartNumberAll = cbxPartNo.SelectedValue.ToString();
                                modellife.Accumulate = 0;
                                modellife.Clean1Qty = 0;
                                if (!blllife.Add(modellife))
                                {
                                    DBHelp.Reports.LogFile.DebugLog("Error", "RefreshVidata modellife", "Visuallnspection", "", "when add modellife");
                                    
                                }
                                else
                                {
                                    DBHelp.Reports.LogFile.DebugLog("ModelLife", "RefreshVidata modellife", "Visuallnspection", "", "MachineID : " + modellife.MachineID + " PartNumberAll: " + modellife.PartNumberAll + " Accumulate: " + modellife.Accumulate + " Clean1Qty : " + modellife.Clean1Qty + " ");
                                }
                            }
                        }
                        else
                        {
                            string sMold = cbxPartNo.SelectedValue.ToString().Substring(0,cbxPartNo.SelectedValue.ToString().LastIndexOf(' '));
                            modellife = blllife.GetModel(sMold);
                            if (modellife.PartNumberAll != null)
                            {
                                modellife.Accumulate = modellife.Accumulate + Total;
                                modellife.Clean1Qty = modellife.Clean1Qty + Total;
                                modellife.UpdatedTime = DateTime.Now;
                                modellife.MachineID = "";
                                if (!blllife.Update(modellife))
                                {
                                    DBHelp.Reports.LogFile.DebugLog("Error", "RefreshVidata modellife", "Visuallnspection", "", "when update modellife");
                                    
                                }
                                else
                                {
                                    DBHelp.Reports.LogFile.DebugLog("ModelLife", "RefreshVidata modellife", "Visuallnspection", "", "MachineID : " + modellife.MachineID + " PartNumberAll: " + modellife.PartNumberAll + " Accumulate: " + modellife.Accumulate + " Clean1Qty : " + modellife.Clean1Qty + " ");
                                }
                            }
                            else
                            {
                                modellife.MoldID = sMold;
                                modellife.PartNumberAll = sMold;
                                modellife.Accumulate = 0;
                                modellife.Clean1Qty = 0;
                                if (!blllife.Add(modellife))
                                {
                                    DBHelp.Reports.LogFile.DebugLog("Error", "RefreshVidata modellife", "Visuallnspection", "", "when add modellife");
                                    
                                }
                                else
                                {
                                    DBHelp.Reports.LogFile.DebugLog("ModelLife", "RefreshVidata modellife", "Visuallnspection", "", "MachineID : " + modellife.MachineID + " PartNumberAll: " + modellife.PartNumberAll + " Accumulate: " + modellife.Accumulate + " Clean1Qty : " + modellife.Clean1Qty + " ");
                                }
                            }
                        }                       
                    }
                    catch (Exception ee)
                    {
                        DBHelp.Reports.LogFile.DebugLog("Error", "RefreshVidata modellife", "Visuallnspection", "", ee.ToString());
                    }
                }
                StaticRes.Global.Current_User.userID = "";
                this.btnSubmit.IsEnabled = true;
                if (StaticRes.Global.MachineID != "8")
                {
                    _Number = 0;
                }
                else
                {
                    _Number = 1;
                }
                StaticRes.Global._isUsingObjCurVi = true;
                //funPendingLogOutController();
            }
            catch (Exception ee)
            {

            }
        }

        private void ChangeShift()
        {
            //2018/12/04 when change shift machine status into No Operator
            if (StaticRes.Global.MachineStatus == StaticRes.Global.MachineSttaus.Running)
            {
                StaticRes.Global.MachineStatus = StaticRes.Global.MachineSttaus.NoOperator;
                StaticRes.Global.OeeStatus = StaticRes.Global.oee.No_Schedule;
                _objMachine.starttime = System.DateTime.Now;
                if (updatemachine(false))
                {
                    StaticRes.Global.ButtonStaus.Running = true;
                    StaticRes.Global.ButtonStaus.MaterialTesting = true;
                    StaticRes.Global.ButtonStaus.MouldTesting = true;
                    StaticRes.Global.ButtonStaus.ChangeModel = true;
                    StaticRes.Global.ButtonStaus.BreakTime = true;
                    StaticRes.Global.ButtonStaus.NoMaterial = true;
                    StaticRes.Global.ButtonStaus.NoOperator = true;
                    StaticRes.Global.ButtonStaus.Adjustment = true;
                    StaticRes.Global.ButtonStaus.ShutDown = true;
                    StaticRes.Global.ButtonStaus.No_Schedule = true;
                    StaticRes.Global.ButtonStaus.MachineBreak = true;
                    StaticRes.Global.ButtonStaus.DamageMould = true;
                    this.BtnRunning.Background = Brushes.CornflowerBlue;
                    this.BtnMaterial_Testing.Background = Brushes.CornflowerBlue;
                    this.BtnMould_Testing.Background = Brushes.CornflowerBlue;
                    this.BtnModel.Background = Brushes.CornflowerBlue;
                    this.BtnBreak_Time.Background = Brushes.CornflowerBlue;
                    this.BtnNo_Material.Background = Brushes.CornflowerBlue;
                    this.BtnNo_Operatoer.Background = Brushes.CornflowerBlue;
                    this.BtnAdjustment.Background = Brushes.CornflowerBlue;
                    this.BtnShut_Down.Background = Brushes.CornflowerBlue;
                    this.BtnNoSchedule.Background = Brushes.CornflowerBlue;
                    this.BtnMachineBreak.Background = Brushes.CornflowerBlue;
                    this.BtnDamageMould.Background = Brushes.CornflowerBlue;
                }
            }
            else //change shift get last shift machine status
            {
                _objMachine.starttime = System.DateTime.Now;
                if (updatemachine(false))
                {
                    StaticRes.Global.ButtonStaus.Running = true;
                    StaticRes.Global.ButtonStaus.MaterialTesting = true;
                    StaticRes.Global.ButtonStaus.MouldTesting = true;
                    StaticRes.Global.ButtonStaus.ChangeModel = true;
                    StaticRes.Global.ButtonStaus.BreakTime = true;
                    StaticRes.Global.ButtonStaus.NoMaterial = true;
                    StaticRes.Global.ButtonStaus.NoOperator = true;
                    StaticRes.Global.ButtonStaus.Adjustment = true;
                    StaticRes.Global.ButtonStaus.ShutDown = true;
                    StaticRes.Global.ButtonStaus.No_Schedule = true;
                    StaticRes.Global.ButtonStaus.MachineBreak = true;
                    StaticRes.Global.ButtonStaus.DamageMould = true;
                    this.BtnRunning.Background = Brushes.CornflowerBlue;
                    this.BtnMaterial_Testing.Background = Brushes.CornflowerBlue;
                    this.BtnMould_Testing.Background = Brushes.CornflowerBlue;
                    this.BtnModel.Background = Brushes.CornflowerBlue;
                    this.BtnBreak_Time.Background = Brushes.CornflowerBlue;
                    this.BtnNo_Material.Background = Brushes.CornflowerBlue;
                    this.BtnNo_Operatoer.Background = Brushes.CornflowerBlue;
                    this.BtnAdjustment.Background = Brushes.CornflowerBlue;
                    this.BtnShut_Down.Background = Brushes.CornflowerBlue;
                    this.BtnNoSchedule.Background = Brushes.CornflowerBlue;
                    this.BtnMachineBreak.Background = Brushes.CornflowerBlue;
                    this.BtnDamageMould.Background = Brushes.CornflowerBlue;
                }
            }
        }


        private void SetStatusButton()
        {
            this.cbxCustomer.IsEnabled = true;
            this.cbxModel.IsEnabled = true;
            this.cbxPartNo.IsEnabled = true;
            this.cbxMat1Part.IsEnabled = true;
            this.txtMat1Batch.IsEnabled = true;
            this.cbxMat2Part.IsEnabled = true;
            this.txtMat2Batch.IsEnabled = true;
            this.tbkJigNo.IsEnabled = true;
            this.tbkCycleTime.IsEnabled = true;
            this.tbkCavityCount.IsEnabled = true;
            this.tbkTargetQty.IsEnabled = true;
            this.tbkPassQty.IsEnabled = true;
            this.tbkFailQty.IsEnabled = true;
            this.tbkQCFailQty.IsEnabled = true;
            this.tbkTotalQty.IsEnabled = true;



            _objMachine.starttime = System.DateTime.Now;
                if (updatemachine(false))
                {
                    StaticRes.Global.ButtonStaus.Running = true;
                    StaticRes.Global.ButtonStaus.MaterialTesting = true;
                    StaticRes.Global.ButtonStaus.MouldTesting = true;
                    StaticRes.Global.ButtonStaus.ChangeModel = true;
                    StaticRes.Global.ButtonStaus.BreakTime = true;
                    StaticRes.Global.ButtonStaus.NoMaterial = true;
                    StaticRes.Global.ButtonStaus.NoOperator = true;
                    StaticRes.Global.ButtonStaus.Adjustment = true;
                    StaticRes.Global.ButtonStaus.ShutDown = true;
                    StaticRes.Global.ButtonStaus.No_Schedule = true;
                    StaticRes.Global.ButtonStaus.MachineBreak = true;
                    StaticRes.Global.ButtonStaus.DamageMould = true;
                    this.BtnRunning.Background = Brushes.CornflowerBlue;
                    this.BtnMaterial_Testing.Background = Brushes.CornflowerBlue;
                    this.BtnMould_Testing.Background = Brushes.CornflowerBlue;
                    this.BtnModel.Background = Brushes.CornflowerBlue;
                    this.BtnBreak_Time.Background = Brushes.CornflowerBlue;
                    this.BtnNo_Material.Background = Brushes.CornflowerBlue;
                    this.BtnNo_Operatoer.Background = Brushes.CornflowerBlue;
                    this.BtnAdjustment.Background = Brushes.CornflowerBlue;
                    this.BtnShut_Down.Background = Brushes.CornflowerBlue;
                    this.BtnNoSchedule.Background = Brushes.CornflowerBlue;
                    this.BtnMachineBreak.Background = Brushes.CornflowerBlue;
                    this.BtnDamageMould.Background = Brushes.CornflowerBlue;                
                }
        }

        private void btnSignIn_Click(object sender, RoutedEventArgs e)
        {

            funPendingLogInCotroller();
  
        }

        private void funPendingLogOutController()
        {
            iniTabControl();
            _flag = true;
            StaticRes.Global.Current_User = new Common.Model.User_DB_Model(); 
            this.txtUserID.IsEnabled = true;
            this.txtUserID.Text = ""; // StaticRes.Global.Current_User.userID;
            this.txtUserName.Content = "";
            this.txtPassword.Password = "";
            this.txtUserName.IsEnabled = true;
            this.txtPassword.IsEnabled = true;
            this.btnSignIn.IsEnabled = true;
            this.btnSignOut.IsEnabled = false;
            this.tcDefect.IsEnabled = false;

            this.BtnRunning.IsEnabled = false;
            this.BtnMaterial_Testing.IsEnabled = false;
            this.BtnMould_Testing.IsEnabled = false;
            this.BtnModel.IsEnabled = false;
            this.BtnBreak_Time.IsEnabled = false;
            this.BtnNo_Operatoer.IsEnabled = false;
            this.BtnNo_Material.IsEnabled = false;
            this.btnOpHourlyCheck.IsEnabled = false;
            this.BtnShut_Down.IsEnabled = false;
            this.BtnAdjustment.IsEnabled = false;
            this.BtnNoSchedule.IsEnabled = false;
            this.BtnMachineBreak.IsEnabled = false;
            this.BtnDamageMould.IsEnabled = false;

            _objCurVi = null;
            #region
            if (StaticRes.Global.MachineID == StaticRes.Global.OtherMachine)
            {
                Label_Name.Text = "";
                txtSerialNo01.Text = "0";
                txtSerialNo02.Text = "0";
                txtSerialNo03.Text = "0";
                txtSerialNo04.Text = "0";
                txtSerialNo05.Text = "0";
                txtSerialNo06.Text = "0";
                txtSerialNo07.Text = "0";
                txtSerialNo08.Text = "0";
                txtSerialNo09.Text = "0";
                txtSerialNo10.Text = "0";
                txtSerialNo11.Text = "0";
                txtSerialNo12.Text = "0";
                txtSerialNo13.Text = "0";
                txtUsageQty01.Text = "0";
                txtUsageQty02.Text = "0";
                txtUsageQty03.Text = "0";
                txtUsageQty04.Text = "0";
                txtUsageQty05.Text = "0";
                txtUsageQty06.Text = "0";
                txtUsageQty07.Text = "0";
                txtUsageQty08.Text = "0";
                txtUsageQty09.Text = "0";
                txtUsageQty10.Text = "0";
                txtUsageQty11.Text = "0";
                txtUsageQty12.Text = "0";
                txtRejectQty06.Text = "0";
                txtRejectQty07.Text = "0";
                txtRejectQty08.Text = "0";
                txtRejectQty09.Text = "0";
                txtRejectQty10.Text = "0";
                txtRejectQty11.Text = "0";
                txtRejectQty12.Text = "0";
                txtRejectQty01.Text = "0";
                txtRejectQty02.Text = "0";
                txtRejectQty03.Text = "0";
                txtRejectQty04.Text = "0";
                txtRejectQty05.Text = "0";
                txtAcceptQty01.Text = "0";
                txtAcceptQty02.Text = "0";
                txtAcceptQty03.Text = "0";
                txtAcceptQty04.Text = "0";
                txtAcceptQty05.Text = "0";
                txtAcceptQty06.Text = "0";
                txtAcceptQty07.Text = "0";
                txtAcceptQty08.Text = "0";
                txtAcceptQty09.Text = "0";
                txtAcceptQty10.Text = "0";
                txtAcceptQty11.Text = "0";
                txtAcceptQty12.Text = "0";
            }
            #endregion
            iniViDate();

        }

        private void funPendingLogInCotroller()
        {
            if (UserIDnPasswordValidation())
            {
                this.txtUserName.Content = User.userName.ToString();
                Common.BLL.MouldingViTracking_BLL bllVi = new Common.BLL.MouldingViTracking_BLL();
                Common.Model.MouldingViTracking_Model objCurVi = new Common.Model.MouldingViTracking_Model();
                objCurVi = bllVi.GetModel_ByMachine(StaticRes.Global.MachineID);
                this.txtUserID.IsEnabled = false;
                this.txtUserName.IsEnabled = false;
                this.txtPassword.IsEnabled = false;

                this.btnSignIn.IsEnabled = false;
                this.btnSignOut.IsEnabled = true;
                this.tcDefect.IsEnabled = true;

                this.BtnRunning.IsEnabled = true;
                this.BtnMaterial_Testing.IsEnabled = true;
                this.BtnMould_Testing.IsEnabled = true;
                this.BtnModel.IsEnabled = true;
                this.BtnBreak_Time.IsEnabled = true;
                this.BtnNo_Operatoer.IsEnabled = true;
                this.BtnNo_Material.IsEnabled = true;
                this.btnOpHourlyCheck.IsEnabled = true;
                this.BtnShut_Down.IsEnabled = true;
                this.BtnAdjustment.IsEnabled = true;
                this.BtnNoSchedule.IsEnabled = true;
                this.BtnMachineBreak.IsEnabled = true;
                this.BtnDamageMould.IsEnabled = true;

                this.cbxCustomer.IsEnabled = true;
                this.cbxModel.IsEnabled = true;
                this.cbxPartNo.IsEnabled = true;
                this.cbxMat1Part.IsEnabled = true;
                this.txtMat1Batch.IsEnabled = true;
                this.cbxMat2Part.IsEnabled = true;
                this.txtMat2Batch.IsEnabled = true;
                this.tbkJigNo.IsEnabled = true;
                this.tbkCycleTime.IsEnabled = true;
                this.tbkCavityCount.IsEnabled = true;
                this.tbkTargetQty.IsEnabled = true;
                this.tbkPassQty.IsEnabled = true;
                this.tbkFailQty.IsEnabled = true;
                this.tbkQCFailQty.IsEnabled = true;
                this.tbkTotalQty.IsEnabled = true;
                if (objCurVi != null)
                {
                    this.cbxCustomer.Text = objCurVi.customer;
                    this.cbxModel.Text = objCurVi.model;
                    this.cbxPartNo.Text = objCurVi.partnumberall;
                    this.cbxMat1Part.Text = objCurVi.matPart01;
                    this.txtMat1Batch.Text = objCurVi.matLot01;
                    this.cbxMat2Part.Text = objCurVi.matPart02;
                    this.txtMat2Batch.Text = objCurVi.matLot02;
                }
            }
            else
            {
                MessageBox.Show("ID and Password is not match");
            }
        }

        private Common.Model.User_DB_Model User = new User_DB_Model();
        private Common.BLL.User_DB_BLL _userManagement_BLL = new Common.BLL.User_DB_BLL();
        private bool UserIDnPasswordValidation()
        {
            User = _userManagement_BLL.Validate_User(this.txtUserID.Text, this.txtPassword.Password);
            if (User == null)
            {
                return false;
            }
            else
            {
                StaticRes.Global.Current_User = User;
                return true;
            }
        }
        private void funPendingLogOutCotroller()
        {   
            this.txtUserID.IsEnabled = true;
             StaticRes.Global.Current_User.userID = this.txtUserID.Text ;
            this.btnSignIn.IsEnabled = true;
            this.btnSignOut.IsEnabled = true;
            this.tcDefect.IsEnabled = true;
            
        }


        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            double ww = this.GridT1.Width;
            double hh = this.GridT1.Height;
        } 
       
        private void btnSubmit_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Common.Model.MouldingMoldLife modellife = new Common.Model.MouldingMoldLife();
                Common.BLL.MouldingMoldLife_BLL blllife = new Common.BLL.MouldingMoldLife_BLL();
                if (!MouldCharst(cbxPartNo.SelectedValue.ToString()))
                {
                    modellife = blllife.GetModel(cbxPartNo.SelectedValue.ToString());
                    if (modellife.PartNumberAll != null )
                    {
                        if (modellife.Clean1Qty > StaticRes.Global.CleanQty)
                        {
                            MessageBox.Show("" + cbxPartNo.SelectedValue.ToString() + "This Model Charst need clean!");
                            DBHelp.Reports.LogFile.DebugLog("ModelCharst", "btnSubmit_Click", "Visuallnspection this Model Charst need clean :", "", cbxPartNo.SelectedValue.ToString() + "Shots is :" + modellife.Clean1Qty.ToString());
                        }
                    }
                }
                else
                {
                    string sMold = cbxPartNo.SelectedValue.ToString().Substring(0, cbxPartNo.SelectedValue.ToString().LastIndexOf(' '));
                    modellife = blllife.GetModel(sMold);
                    if (modellife.PartNumberAll != null)
                    {
                        if (modellife.Clean1Qty > StaticRes.Global.CleanQty)
                        {
                            MessageBox.Show("" + cbxPartNo.SelectedValue.ToString() + "This Model Charst need clean!");
                            DBHelp.Reports.LogFile.DebugLog("ModelCharst", "btnSubmit_Click", "Visuallnspection this Model Charst need clean :", "", cbxPartNo.SelectedValue.ToString() + "Shots is :" + modellife.Clean1Qty.ToString());
                        }
                    }
                }

                StaticRes.Global._isUsingObjCurVi = true;
                bool _updateCheck = true;
                List<System.Data.SqlClient.SqlCommand> sqlCommandList = new List<System.Data.SqlClient.SqlCommand>();
                //2018/12/04 just 3 status can sumbit
                if (StaticRes.Global.ButtonStaus.Running == false ||
                StaticRes.Global.ButtonStaus.MaterialTesting == false ||
                StaticRes.Global.ButtonStaus.MouldTesting == false )
                {
                    //validation
                    DateTime dtime = DateTime.Now;
                    string sPartNo = cbxPartNo.SelectedValue.ToString();

                    if (sPartNo.Length > 0)
                    {
                        Common.BLL.MouldingBom_BLL bllBom = new Common.BLL.MouldingBom_BLL();
                        List<Common.Model.MouldingBom_Model> objAllBom_List = new List<Common.Model.MouldingBom_Model>();
                        //objBom_List = bllBom.getModelListByPartNo(sPartNo);
                        objAllBom_List = bllBom.getAllPartNoListByPartNo(sPartNo);
                        if (objAllBom_List.Count == 0)
                        {
                            MessageBox.Show("Can not find this PartNo from BOM table!");
                            return;
                        }
                        else
                        {
                            //Common.BLL.MouldingViDefectTracking_BLL bllViDef = new Common.BLL.MouldingViDefectTracking_BLL();
                            //List<Common.Model.MouldingViDefectTracking_Model> objCurViDef = new List<Common.Model.MouldingViDefectTracking_Model>();
                            for (int i = 0; i < objAllBom_List.Count; i++)
                            {
                                string[] sAPartNo = sPartNo.Split(',');
                                
                                List<Common.Model.MouldingBom_Model> objBom_List = new List<Common.Model.MouldingBom_Model>();
                                objBom_List = bllBom.getModelListByPartNo(sAPartNo[i]);
                                if (!MaterialPartValidation(objBom_List[0], cbxMat1Part.SelectedValue.ToString(), cbxMat2Part.SelectedValue.ToString()))
                                {
                                    MessageBox.Show("Material information is not match with BOM setting");
                                    return;
                                }
                                else
                                {
                                    //material loy check after three people agree
                                    //if (!MaterialBatchValidation(cbxMat1Part.SelectedValue.ToString(), cbxMat2Part.SelectedValue.ToString(), txtMat1Batch.Text.Trim(), txtMat2Batch.Text.Trim()))
                                    //{
                                    //    MessageBox.Show("Please input Material Batch No!");
                                    //    return;
                                    //}
                                    //else
                                    {
                                        _Number++;

                                        //load Defect Tab
                                        iniDevControl(objBom_List);

                                        ////set Tab01 information including BOM information  
                                        #region "old logic"
                                        //tbkCavityCount.Text = objBom_List[0].cavityCount.ToString();
                                        //tbkCustomer.Text = objBom_List[0].customer.ToString();
                                        //tbkCycleTime.Text = objBom_List[0].cycleTime.ToString();
                                        //tbkJigNo.Text = objBom_List[0].jigNo.ToString();
                                        //tbkModel.Text = objBom_List[0].model.ToString();
                                        //tbkMaterialWeight.Text = objBom_List[0].cavityCount.ToString();
                                        //tbkTargetQty .Text =  ((objBom_List[0].cycleTime != null && objBom_List[0].cycleTime > 0) ? (12 * 3600) / objBom_List[0].cycleTime : 0 ).ToString() ;

                                        ////getExisting Data 
                                        //Common.BLL.MouldingViTracking_BLL bllVi = new Common.BLL.MouldingViTracking_BLL();
                                        //Common.Model.MouldingViTracking_Model objCurVi = new Common.Model.MouldingViTracking_Model();
                                        //objCurVi = bllVi.GetModel_ByDayShiftPartMachine(StaticRes.Global.CurDay, StaticRes.Global.CurShift, objBom_List[0].partNumber, StaticRes.Global.MachineID);
                                        //if (objCurVi == null)
                                        //{
                                        //    //insert new shift data.
                                        //    generateViData(StaticRes.Global.MachineID
                                        //        , StaticRes.Global.CurDay
                                        //        , StaticRes.Global.CurShift
                                        //        , txtMat1Batch.Text.Trim()
                                        //        , txtMat2Batch.Text.Trim()
                                        //        , Common.Model.MouldingViTracking_Model.StatusList.Start
                                        //        , StaticRes.Global.Current_User
                                        //        , objBom_List);
                                        //}
                                        //if (objCurVi == null)
                                        //{
                                        //    tbkFailQty.Text = "0";
                                        //    tbkPassQty.Text = "0";
                                        //    tbkTotalQty.Text = getTotalQTYfromPQM(StaticRes.Global.MachineID).ToString();
                                        //}
                                        //else
                                        //{
                                        //    tbkFailQty.Text = objCurVi.rejectQty.ToString();
                                        //    tbkTotalQty.Text = getTotalQTYfromPQM(StaticRes.Global.MachineID).ToString();
                                        //    tbkPassQty.Text = objCurVi.acceptQty.ToString();//(int.Parse(tbkTotalQty.Text) - objCurVi.rejectQty).ToString();
                                        //}
                                        #endregion

                                        StaticRes.Global._isUsingObjCurVi = true;
                                        _objCurVi = refreshVidata(StaticRes.Global.CurDay, StaticRes.Global.CurShift, objBom_List[0].partNumber, StaticRes.Global.MachineID);
                                        if (_objCurVi == null)
                                        {
                                            //insert new shift data.
                                            generateViData(StaticRes.Global.MachineID
                                                , StaticRes.Global.CurDay
                                                , StaticRes.Global.CurShift
                                                , txtMat1Batch.Text.Trim()
                                                , txtMat2Batch.Text.Trim()
                                                , StaticRes.Global.Status
                                                , StaticRes.Global.Current_User
                                                , objBom_List
                                                , dtime);
                                            //_flag = false;
                                            //get VI Tracking data after refresh
                                            _objCurVi = refreshVidata(StaticRes.Global.CurDay, StaticRes.Global.CurShift, objBom_List[0].partNumber, StaticRes.Global.MachineID);
                                        }
                                        else if (_objCurVi.status != StaticRes.Global.Status)
                                        {
                                            //insert new shift data.
                                            generateViData(StaticRes.Global.MachineID
                                                , StaticRes.Global.CurDay
                                                , StaticRes.Global.CurShift
                                                , txtMat1Batch.Text.Trim()
                                                , txtMat2Batch.Text.Trim()
                                                , StaticRes.Global.Status
                                                , StaticRes.Global.Current_User
                                                , objBom_List
                                                , dtime);
                                            //_flag = false;
                                            //get VI Tracking data after refresh
                                            _objCurVi = refreshVidata(StaticRes.Global.CurDay, StaticRes.Global.CurShift, objBom_List[0].partNumber, StaticRes.Global.MachineID);
                                        }
                                        else
                                        {
                                            if (_updateCheck)
                                            {
                                                if (_objCurVi.userID != txtUserID.Text.Trim() || _objCurVi.matLot01 != txtMat1Batch.Text.Trim() || _objCurVi.matLot02 != txtMat2Batch.Text.Trim())
                                                {
                                                    _objCurVi.userID = txtUserID.Text.Trim();
                                                    _objCurVi.userName = txtUserName.Content.ToString();
                                                    _objCurVi.matLot01 = txtMat1Batch.Text.Trim();
                                                    _objCurVi.matLot02 = txtMat2Batch.Text.Trim();
                                                    _objCurVi.lastUpdatedTime = System.DateTime.Now;
                                                    Common.BLL.MouldingViTracking_BLL bllTracking = new Common.BLL.MouldingViTracking_BLL();
                                                    sqlCommandList.Add(bllTracking.UpdateCommand(_objCurVi));

                                                    Common.BLL.MouldingViHistory_BLL bllHistory = new Common.BLL.MouldingViHistory_BLL();
                                                    sqlCommandList.Add(bllHistory.AddCommand(bllHistory.CopyObj(_objCurVi)));

                                                    Common.BLL.MouldingViDefectTracking_BLL bllVITracking = new Common.BLL.MouldingViDefectTracking_BLL();
                                                    sqlCommandList.Add(bllVITracking.UpdatebyDayMachineShifPartNumberAll(_objCurVi));
                                                    _updateCheck = false;
                                                }
                                                if (StaticRes.Global.MachineID == StaticRes.Global.OtherMachine)
                                                {
                                                    getLable();
                                                }
                                            }
                                        }
                                        //set Tab Material Data
                                        Common.BLL.MouldingViDefectTracking_BLL bllViDef = new Common.BLL.MouldingViDefectTracking_BLL();
                                        List<Common.Model.MouldingViDefectTracking_Model> objCurViDef = new List<Common.Model.MouldingViDefectTracking_Model>();
                                        objCurViDef = bllViDef.GetModelList_ByDayShiftPartMachine(StaticRes.Global.CurDay, StaticRes.Global.CurShift, objBom_List[0].partNumber, StaticRes.Global.MachineID);
                                        refreshDefData(objCurViDef, objBom_List);
                                        //this.cbxCustomer.IsEnabled = false;
                                        //this.cbxModel.IsEnabled = false;
                                        //this.cbxPartNo.IsEnabled = false;
                                        //this.cbxMat1Part.IsEnabled = false;
                                        //this.txtMat1Batch.IsEnabled = false;
                                        //this.cbxMat2Part.IsEnabled = false;
                                        //this.txtMat2Batch.IsEnabled = false;
                                        //this.tbkJigNo.IsEnabled = false;
                                        //this.tbkCycleTime.IsEnabled = false;
                                        //this.tbkCavityCount.IsEnabled = false;
                                        //this.tbkTargetQty.IsEnabled = false;
                                        //this.tbkPassQty.IsEnabled = false;
                                        //this.tbkFailQty.IsEnabled = false;
                                        //this.tbkQCFailQty.IsEnabled = false;
                                        //this.tbkTotalQty.IsEnabled = false;
                                        //this.btnSubmit.IsEnabled = false;
                                        //StaticRes.Global._isUsingObjCurVi = false;
                                        //objCurViDef.Add(bllViDef.GetModelList_ByDayShiftPartMachine_New(StaticRes.Global.CurDay, StaticRes.Global.CurShift, objBom_List[0].partNumber, StaticRes.Global.MachineID));
                                    }

                                    setMajorInfo(false);
                                }
                            }
                            if (!_updateCheck)
                            {
                                if (DBHelp.SqlDB.SetData_Rollback(sqlCommandList))
                                {
                                    MessageBox.Show("Update Tracking successful !");
                                }
                                else
                                {
                                    MessageBox.Show("Update Tracking failed !");
                                }
                            }
                            //refreshDefData(objCurViDef, null);
                            this.cbxCustomer.IsEnabled = false;
                            this.cbxModel.IsEnabled = false;
                            this.cbxPartNo.IsEnabled = false;
                            this.cbxMat1Part.IsEnabled = false;
                            //this.txtMat1Batch.IsEnabled = false;
                            this.cbxMat2Part.IsEnabled = false;
                            //this.txtMat2Batch.IsEnabled = false;
                            this.tbkJigNo.IsEnabled = false;
                            this.tbkCycleTime.IsEnabled = false;
                            this.tbkCavityCount.IsEnabled = false;
                            this.tbkTargetQty.IsEnabled = false;
                            this.tbkPassQty.IsEnabled = false;
                            this.tbkFailQty.IsEnabled = false;
                            this.tbkQCFailQty.IsEnabled = false;
                            this.tbkTotalQty.IsEnabled = false;
                            this.btnSubmit.IsEnabled = false;

                            this.btnMaterCheck.IsEnabled = true;
                            this.btnOPMaterCheck.IsEnabled = true;
                            this.btnleaderMaterCheck.IsEnabled = true;
                            this.btnOpHourlyCheck.IsEnabled = true;
                            this.btnIpqcChcek.IsEnabled = true;
                            this.btnSupervisorCheck.IsEnabled = true;
                            this.btnleaderChcek.IsEnabled = true;
                            this.btnMaterCheckWeight.IsEnabled = true;
                            //setMajorInfo(false);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please input JigNo!");
                    }
                }
                else
                {
                    MessageBox.Show("Please check current machine status!");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
            finally
            {
                StaticRes.Global._isUsingObjCurVi = false;
            }
           
        }
        private bool MaterialPartValidation(Common.Model.MouldingBom_Model objBom, string Mat1Part, string Mat2Part)
        {
            bool result = false;
            if (objBom.matPart01 == Mat1Part.Trim() && objBom.matPart02 == Mat2Part.Trim())
            { result = true; }
            else if (objBom.matPart01 == Mat2Part.Trim() && objBom.matPart02 == Mat1Part.Trim())
            { result = true; }
            else
            {
                result = false;
            }
            return result;

        }
        private bool MaterialBatchValidation(string Mat1Part, string Mat2Part, string Mat1Batch, string Mat2Batch)
        {
            bool result = false;
            //batch check after material check
            //if (Mat1Part.Trim().Length > 0 && Mat1Batch.Length == 0)
            if (Mat1Part.Trim().Length > 0 && Mat1Batch.Length == 0)
            { result = false; }
            //else if (Mat2Part.Trim().Length > 0 && Mat2Batch.Length == 0)
            else if (Mat2Part.Trim().Length > 0 && Mat2Batch.Length == 0)
            { result = false; }
            else
            {
                result = true;
            }
            return result;
        }

        private bool MaterialBatchValidationForMH(string Mat1Part, string Mat2Part, string Mat1Batch, string Mat2Batch)
        {
            bool result = false;
            //batch check after material check
            if (Mat1Part.Trim().Length > 0 && Mat1Batch.Length == 0)

            { result = false; }
            else if (Mat2Part.Trim().Length > 0 && Mat2Batch.Length == 0)

            { result = false; }
            else
            {
                result = true;
            }
            return result;
        }

        private bool generateViData(string machineID, DateTime curDay, string curShift,string mat1Batch, string mat2Batch, string trackingStatus,  User_DB_Model current_User, List<MouldingBom_Model> objBom_List, DateTime dtime)
        {
           
            List<System.Data.SqlClient.SqlCommand> sqlCommandList = new List<System.Data.SqlClient.SqlCommand>();
            bool result = false;
            string sTrackingID = StaticRes.Global.generateUniqueID(machineID);
            //DateTime dtime = DateTime.Now;
            //if (_flag)
            {
                Common.BLL.MouldingViTracking_BLL bllVi = new Common.BLL.MouldingViTracking_BLL();
                Common.Model.MouldingViTracking_Model objVi = new MouldingViTracking_Model();

                //2018 09 12 check last PQM QTY
                decimal? _beforeQTY = SelectBeforePart(machineID, objBom_List, dtime);
                decimal? _accumulateQTY = SelectBeforeacountReading(machineID, objBom_List, dtime);
                decimal? OkaccumulateQTY = SelectBeforeacountReadingOK(machineID, objBom_List, dtime);

                objVi.acceptQty = 0;
                objVi.acountReading = 0;
                objVi.cavityCount = objBom_List[0].cavityCount;
                objVi.customer = objBom_List[0].customer;
                objVi.cycleTime = objBom_List[0].cycleTime;
                objVi.dateTime = dtime;
                objVi.day = curDay;
                //objVi.id = 0; auto generated by database 
                //objVi.jigNo = objBom_List[0].jigNo;
                if (_flag)
                {
                    int count = 0;
                    string[] jigNo = objBom_List[0].jigNo.Split('/');
                    foreach (string aa in jigNo)
                    {
                        count++;
                    }
                    if (count > 1)
                    {
                        if (MessageBox.Show("Select jigNo Yes:" + jigNo[0] + ";No:" + jigNo[1] + "？", "", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
                        {
                            //objVi.jigNo = jigNo[0];
                            StaticRes.Global.JigNo = jigNo[0];
                        }
                        else
                        {
                            //objVi.jigNo = jigNo[1];
                            StaticRes.Global.JigNo = jigNo[1];
                        }
                    }
                    else
                    {
                        StaticRes.Global.JigNo = jigNo[0];
                    }
                    _flag = false;
                }
                objVi.jigNo = StaticRes.Global.JigNo;
                objVi.lastUpdatedTime = dtime;
                objVi.machineID = machineID;
                objVi.matPart01 = objBom_List[0].matPart01;
                if (objVi.matPart01.Trim().Length > 0)
                {
                    objVi.matLot01 = mat1Batch;
                }
                objVi.matPart02 = objBom_List[0].matPart02;
                if (objVi.matPart02.Trim().Length > 0)
                {
                    objVi.matLot02 = mat2Batch;
                }
                objVi.model = objBom_List[0].model;
                objVi.opSign01 = "";
                objVi.opSign02 = "";
                objVi.opSign03 = "";
                objVi.opSign04 = "";
                objVi.opSign05 = "";
                objVi.opSign06 = "";
                objVi.opSign07 = "";
                objVi.opSign08 = "";
                objVi.opSign09 = "";
                objVi.opSign10 = "";
                objVi.opSign11 = "";
                objVi.opSign12 = "";
                objVi.partNumber = objBom_List[0].partNumber;
                objVi.partsWeight = objBom_List[0].partsWeight;
                objVi.qaSign01 = "";
                objVi.qaSign02 = "";
                objVi.qaSign03 = "";
                objVi.qaSign04 = "";
                objVi.qaSign05 = "";
                objVi.qaSign06 = "";
                objVi.qaSign07 = "";
                objVi.qaSign08 = "";
                objVi.qaSign09 = "";
                objVi.qaSign10 = "";
                objVi.qaSign11 = "";
                objVi.qaSign12 = "";
                objVi.rejectQty = 0;
                objVi.QCNGQTY = 0;
                objVi.remarks = _accumulateQTY.ToString(); //input 0 Accumulate QTY
                //objVi.remarks = _beforeQTY.ToString(); 
                objVi.shift = curShift;
                objVi.startTime = dtime;
                objVi.status = trackingStatus;
                objVi.stopTime = null;
                objVi.targetQty = (objVi.cycleTime != null && objVi.cycleTime > 0) ? (12 * 3600) / objVi.cycleTime : 0;
                objVi.trackingID = sTrackingID;
                objVi.userID = current_User.userID;
                objVi.userName = current_User.userName;
                objVi.partnumberall = objBom_List[0].partnumberall;
                objVi.partsWeight = 0;
                objVi.parts2Weight = 0;
                objVi.lastQty = _beforeQTY * objVi.cavityCount;
                objVi.OkAccumulation = OkaccumulateQTY.ToString();
                sqlCommandList.Add(bllVi.AddCommand(objVi));
            }
            Common.BLL.MouldingViDefectTracking_BLL bllViDef = new Common.BLL.MouldingViDefectTracking_BLL();
            Common.Model.MouldingViDefectTracking_Model objDef = new MouldingViDefectTracking_Model();

            for (int i = 0; i < objBom_List.Count; i++)
            {
                Common.BLL.MouldingDefectSetting_BLL bllMouldDefSetting = new Common.BLL.MouldingDefectSetting_BLL();  
                List<Common.Model.MouldingDefectSetting_Model> objMouldDefSet_List = new List<Common.Model.MouldingDefectSetting_Model>();
                objMouldDefSet_List = bllMouldDefSetting.GetListByModelPartJig(objBom_List[i].model,objBom_List[i].partNumber,objBom_List[i].jigNo);
                //objMouldDefSet_List = bllMouldDefSetting.GetListByModelPartJig();
                foreach (Common.Model.MouldingDefectSetting_Model objDefSet in objMouldDefSet_List)
                {
                    objDef = new MouldingViDefectTracking_Model();
                     
                    objDef.cavityCount = objBom_List[0].cavityCount; 
                    objDef.dateTime = dtime; 
                    objDef.day = curDay;
                    objDef.defectCode = objDefSet.defectCode;
                    objDef.defectCodeID = objDefSet.defectCodeID;
                    //objVi.id = 0; auto generated by database 
                    //objDef.jigNo = objBom_List[0].jigNo;
                    objDef.jigNo = StaticRes.Global.JigNo;

                    objDef.lastUpdatedTime = dtime;
                    objDef.machineID = machineID;
                    objDef.matPart01 = objBom_List[0].matPart01;
                    if (objDef.matPart01.Trim().Length > 0)
                    {
                        objDef.matLot01 = mat1Batch;
                    }
                    objDef.matPart02 = objBom_List[0].matPart02;
                    if (objDef.matPart02.Trim().Length > 0)
                    {
                        objDef.matLot02 = mat2Batch;
                    }
                    objDef.model = objBom_List[i].model;
                    objDef.partNumber = objBom_List[0].partNumber;
                    objDef.rejectQty = 0;
                    objDef.rejectQtyHour01 = "";
                    objDef.rejectQtyHour02 = "";
                    objDef.rejectQtyHour03 = "";
                    objDef.rejectQtyHour04 = "";
                    objDef.rejectQtyHour05 = "";
                    objDef.rejectQtyHour06 = "";
                    objDef.rejectQtyHour07 = "";
                    objDef.rejectQtyHour08 = "";
                    objDef.rejectQtyHour09 = "";
                    objDef.rejectQtyHour10 = "";
                    objDef.rejectQtyHour11 = "";
                    objDef.rejectQtyHour12 = ""; 
                    objDef.remarks = "";
                    objDef.shift = curShift;
                    objDef.startTime = dtime;
                    objDef.status = trackingStatus;
                    objDef.stopTime = null;
                    objDef.trackingID = sTrackingID;
                    objDef.userID = current_User.userID;
                    objDef.userName = current_User.userName;

                    objDef.partnumberall = objBom_List[0].partnumberall;
                    sqlCommandList.Add(bllViDef.AddCommand(objDef));
                }
            }

            result = DBHelp.SqlDB.SetData_Rollback(sqlCommandList);

            return result;
        }

        public decimal? SelectBeforePart(string machineID, List<MouldingBom_Model> objBom_List,DateTime Tdate)
        {
            decimal? _Orgin = 0;
            Common.BLL.MouldingViTracking_BLL bllVi = new Common.BLL.MouldingViTracking_BLL();
            Common.Model.MouldingViTracking_Model objVi = new MouldingViTracking_Model();
            List<MouldingViTracking_Model> objTrackingList = new List<MouldingViTracking_Model>();
            
            objTrackingList  = bllVi.GetModelList(" machineId = '"+ machineID +"' order by datetime desc ");
            foreach(MouldingViTracking_Model _track in objTrackingList)
            {
                //if (_track.partnumberall == objBom_List[0].partnumberall)
                {
                    if (Tdate.ToString() == _track.dateTime.ToString() && _track.partnumberall == objBom_List[0].partnumberall)
                    {
                        _Orgin =_track.lastQty;
                        break;
                    }
                    else
                    {
                        _Orgin = (_track.lastQty + _track.acountReading) / _track.cavityCount;
                        break;
                    }
                }
                //else
                //{
                //    _Orgin = 0;
                //    break;
                //}
            }
            return _Orgin;
        }


        public decimal? SelectBeforeacountReading(string machineID, List<MouldingBom_Model> objBom_List, DateTime Tdate)
        {
            decimal? _Orgin = 0;
            Common.BLL.MouldingViTracking_BLL bllVi = new Common.BLL.MouldingViTracking_BLL();
            Common.Model.MouldingViTracking_Model objVi = new MouldingViTracking_Model();
            List<MouldingViTracking_Model> objTrackingList = new List<MouldingViTracking_Model>();

            objTrackingList = bllVi.GetModelList(" machineId = '" + machineID + "' order by datetime desc ");
            foreach (MouldingViTracking_Model _track in objTrackingList)
            {
                if (_track.partnumberall == objBom_List[0].partnumberall)
                {
                    if (_track.remarks.Length == 0)
                    {
                        _track.remarks = "0";
                    }

                    if (Tdate.ToString() == _track.dateTime.ToString())
                    {
                        _Orgin = decimal.Parse(_track.remarks);
                        break;
                    }
                    else
                    {
                        _Orgin = decimal.Parse(_track.remarks) + _track.acountReading;
                        break;
                    }
                }
                else
                {
                    _Orgin = 0;
                    break;
                }
            }
            return _Orgin;
        }
        public decimal? SelectBeforeacountReadingOK(string machineID, List<MouldingBom_Model> objBom_List, DateTime Tdate)
        {
            decimal? _Orgin = 0;
            Common.BLL.MouldingViTracking_BLL bllVi = new Common.BLL.MouldingViTracking_BLL();
            Common.Model.MouldingViTracking_Model objVi = new MouldingViTracking_Model();
            List<MouldingViTracking_Model> objTrackingList = new List<MouldingViTracking_Model>();

            objTrackingList = bllVi.GetModelList(" machineId = '" + machineID + "' order by datetime desc ");
            foreach (MouldingViTracking_Model _track in objTrackingList)
            {
                if (_track.partnumberall == objBom_List[0].partnumberall)
                {
                    if (_track.remarks.Length == 0)
                    {
                        _track.OkAccumulation = "0";
                    }
                    if (_track.OkAccumulation.Length == 0)
                    {
                        _track.OkAccumulation = "0";
                    }
                    if (Tdate.ToString() == _track.dateTime.ToString())
                    {
                        _Orgin = decimal.Parse(_track.OkAccumulation);
                        break;
                    }
                    else
                    {
                        _Orgin = decimal.Parse(_track.OkAccumulation) + _track.acceptQty;
                        break;
                    }
                }
                else
                {
                    _Orgin = 0;
                    break;
                }
            }
            return _Orgin;
        }
        private void iniTabControl()
        {
            while (tcDefect.Items.Count >= _Number+2)
            {
                tcDefect.Items.RemoveAt(_Number+1);
            }
            this.tcDefect.Background = new ImageBrush { ImageSource = new BitmapImage(new Uri("pack://application:,,,/Resources/Mainpage/Background.jpg")) };

        }

        private bool iniViDate()
        {
            tbkCavityCount.Text = "";
            cbxCustomer.SelectedIndex = 0;
            tbkCycleTime.Text = "";
            tbkJigNo.Text = "";
            cbxModel.SelectedIndex = 0;
            tbkTargetQty.Text = "";
            tbkFailQty.Text = "";
            tbkTotalQty.Text = "";
            tbkPassQty.Text = "";
            cbxPartNo.SelectedIndex = 0;
            cbxMat1Part.SelectedIndex = 0;
            txtMat1Batch.Text = "";
            cbxMat2Part.SelectedIndex = 0;
            txtMat2Batch.Text = "";
            tbkQCFailQty.Text = "";
            txt_opcheck.Text = "";
            txt_MHcheck.Text = "";
            txt_leadercheck.Text = "";
            this.cbxCustomer.IsEnabled = false;
            this.cbxModel.IsEnabled = false;
            this.cbxPartNo.IsEnabled = false;
            this.cbxMat1Part.IsEnabled = false;
            this.txtMat1Batch.IsEnabled = false;
            this.cbxMat2Part.IsEnabled = false;
            this.txtMat2Batch.IsEnabled = false;
            this.tbkJigNo.IsEnabled = false;
            this.tbkCycleTime.IsEnabled = false;
            this.tbkCavityCount.IsEnabled = false;
            this.tbkTargetQty.IsEnabled = false;
            this.tbkPassQty.IsEnabled = false;
            this.tbkFailQty.IsEnabled = false;
            this.tbkQCFailQty.IsEnabled = false;
            this.tbkTotalQty.IsEnabled = false;
            return true;
        }
        private void refreshVidata()
        {
             refreshVidata(StaticRes.Global.CurDay, StaticRes.Global.CurShift, (_objCurVi == null || _objCurVi.partNumber == null ? "" : _objCurVi.partNumber), StaticRes.Global.MachineID);
             
        }
        private Common.Model.MouldingViTracking_Model refreshVidata(DateTime  CurDay, string CurShift, string PartNumberAll, string MachineID)
        {
            try
            {

                #region Update  VI Tracking
                //getExisting Data 
                int _rejectQty = 0;
                int _flag = _Number;
                decimal? total = 0;
                Common.BLL.MouldingViTracking_BLL bllVi = new Common.BLL.MouldingViTracking_BLL();
                Common.Model.MouldingViTracking_Model objCurVi = new Common.Model.MouldingViTracking_Model();
                List<System.Data.SqlClient.SqlCommand> lSqlCmd = new List<System.Data.SqlClient.SqlCommand>();
                if (_objMachine.machineID == StaticRes.Global.OtherMachine)
                {
                    _flag--;
                }
                if (_flag == 0)
                {
                    objCurVi = bllVi.GetModel_ByDayShiftPartMachine(CurDay, CurShift, PartNumberAll, MachineID);
                }
                else
                {
                    for (int i = 0; i < _flag; i++)
                    {
                        string[] sAPartNo = cbxPartNo.SelectedValue.ToString().Split(',');
                        objCurVi = bllVi.GetModel_ByDayShiftAllPartMachine(CurDay, CurShift, sAPartNo[i], MachineID);
                        if (objCurVi != null)
                        {
                            Common.BLL.MouldingPqm_BLL _PqmBll = new Common.BLL.MouldingPqm_BLL();
                            string swhere = "machineID = 'MC0" + StaticRes.Global.MachineID + "'";
                            DataSet dt = _PqmBll.GetList(swhere);

                            this.tbkCycleTime.Text = int.Parse(dt.Tables[0].Rows[0]["cycleTime"].ToString()).ToString();
                            objCurVi.cycleTime = int.Parse(this.tbkCycleTime.Text);

                            //pqm获取的total qty * cavityCount,  即total pcs 数量
                            this.tbkTotalQty.Text = ((int.Parse(dt.Tables[0].Rows[0]["totalQTY"].ToString())) * objCurVi.cavityCount).ToString();
                            this.tbkPassQty.Text = ((int.Parse(dt.Tables[0].Rows[0]["totalQTY"].ToString()) * objCurVi.cavityCount) - objCurVi.rejectQty - objCurVi.QCNGQTY).ToString();


                            decimal? oldacountReading = objCurVi.acountReading;
                            objCurVi.lastUpdatedTime = System.DateTime.Now;
                            objCurVi.acountReading = int.Parse(this.tbkTotalQty.Text) - objCurVi.lastQty;
                            objCurVi.acceptQty = (objCurVi.acountReading - objCurVi.rejectQty - objCurVi.QCNGQTY);
                            if (objCurVi.acountReading < 0)
                            {
                                objCurVi.lastQty = -_PQMCal;
                                objCurVi.acountReading = int.Parse(this.tbkTotalQty.Text) - objCurVi.lastQty;
                                objCurVi.acceptQty = (objCurVi.acountReading - objCurVi.rejectQty - objCurVi.QCNGQTY);
                                //_PQMCal = objCurVi.acountReading;
                            }
                            else if ((objCurVi.acountReading - oldacountReading) < 0)
                            {
                                objCurVi.lastQty = -_PQMCal;
                                objCurVi.acountReading = int.Parse(this.tbkTotalQty.Text) - objCurVi.lastQty;
                                objCurVi.acceptQty = (objCurVi.acountReading - objCurVi.rejectQty - objCurVi.QCNGQTY);
                                //_PQMCal = objCurVi.acountReading;
                            }
                            else
                            {
                                //_PQMCal = objCurVi.acountReading;
                            }
                            total = (objCurVi.acountReading - oldacountReading)/ objCurVi.cavityCount;
                            lSqlCmd.Add(bllVi.UpdateCommandbypartnumber(objCurVi));

                            if (int.Parse(objCurVi.rejectQty.ToString()) >= _rejectQty)
                            {
                                _rejectQty = int.Parse(objCurVi.rejectQty.ToString());
                            }
                        }
                    }
                    if (objCurVi != null)
                    {
                        _PQMCal = objCurVi.acountReading;
                    }
                }

                DBHelp.SqlDB.SetData_Rollback(lSqlCmd);
                #endregion


                #region Update  mould life

                Common.Model.MouldingMoldLife modellife = new Common.Model.MouldingMoldLife();
                Common.BLL.MouldingMoldLife_BLL blllife = new Common.BLL.MouldingMoldLife_BLL();
                try
                {
                    if (PartNumberAll.Length != 0)
                    {
                        if (!MouldCharst(cbxPartNo.SelectedValue.ToString()))
                        {
                            modellife = blllife.GetModel(cbxPartNo.SelectedValue.ToString());
                            if (modellife != null)
                            {
                                modellife.Accumulate = modellife.Accumulate + total;
                                modellife.Clean1Qty = modellife.Clean1Qty + total;
                                modellife.UpdatedTime = DateTime.Now;
                                modellife.MachineID = StaticRes.Global.MachineID;
                                
                                if (!blllife.Update(modellife))
                                {
                                    DBHelp.Reports.LogFile.DebugLog("Error", "RefreshVidata modellife", "Visuallnspection", "", "when update modellife");
                                    return null;
                                }
                                else
                                {
                                    DBHelp.Reports.LogFile.DebugLog("ModelLife", "RefreshVidata modellife", "Visuallnspection", "", "MachineID : " + modellife.MachineID + " PartNumberAll: " + modellife.PartNumberAll + " Accumulate: " + modellife.Accumulate + " Clean1Qty : " + modellife.Clean1Qty + " ");
                                }
                            }
                            else
                            {
                                modellife.MoldID = cbxPartNo.SelectedValue.ToString();
                                modellife.PartNumberAll = cbxPartNo.SelectedValue.ToString();
                                modellife.Accumulate = 0;
                                modellife.Clean1Qty = 0;
                                modellife.MouldLife = 500000; //默认定死500000,可在dashboard中修改.
                                if (!blllife.Add(modellife))
                                {
                                    DBHelp.Reports.LogFile.DebugLog("Error", "RefreshVidata modellife", "Visuallnspection", "", "when add modellife");
                                    return null;
                                }
                                else
                                {
                                    DBHelp.Reports.LogFile.DebugLog("ModelLife", "RefreshVidata modellife", "Visuallnspection", "", "MachineID : " + modellife.MachineID + " PartNumberAll: " + modellife.PartNumberAll + " Accumulate: " + modellife.Accumulate + " Clean1Qty : " + modellife.Clean1Qty + " ");
                                }
                            }
                        }
                        else
                        {
                            string sMold = cbxPartNo.SelectedValue.ToString().Substring(0,cbxPartNo.SelectedValue.ToString().LastIndexOf(' '));
                            modellife = blllife.GetModel(sMold);
                            if (modellife != null)
                            {
                                modellife.Accumulate = modellife.Accumulate + total;
                                modellife.Clean1Qty = modellife.Clean1Qty + total;
                                modellife.UpdatedTime = DateTime.Now;
                                modellife.MachineID = StaticRes.Global.MachineID;
                                
                                if (!blllife.Update(modellife))
                                {
                                    DBHelp.Reports.LogFile.DebugLog("Error", "RefreshVidata modellife", "Visuallnspection", "", "when update modellife");
                                    return null;
                                }
                                else
                                {
                                    DBHelp.Reports.LogFile.DebugLog("ModelLife", "RefreshVidata modellife", "Visuallnspection", "", "MachineID : " + modellife.MachineID + " PartNumberAll: " + modellife.PartNumberAll + " Accumulate: " + modellife.Accumulate + " Clean1Qty : " + modellife.Clean1Qty + " ");
                                }
                            }
                            else
                            {
                                modellife.MoldID = sMold;
                                modellife.PartNumberAll = sMold;
                                modellife.Accumulate = 0;
                                modellife.Clean1Qty = 0;
                                modellife.MouldLife = 500000;//默认定死500000,可在dashboard中修改.
                                if (!blllife.Add(modellife))
                                {
                                    DBHelp.Reports.LogFile.DebugLog("Error", "RefreshVidata modellife", "Visuallnspection", "", "when add modellife");
                                    return null;
                                }
                                else
                                {
                                    DBHelp.Reports.LogFile.DebugLog("ModelLife", "RefreshVidata modellife", "Visuallnspection", "", "MachineID : " + modellife.MachineID + " PartNumberAll: " + modellife.PartNumberAll + " Accumulate: " + modellife.Accumulate + " Clean1Qty : " + modellife.Clean1Qty + " ");
                                }
                            }
                        }
                    }
                }
                catch (Exception ee)
                {
                    DBHelp.Reports.LogFile.DebugLog("Error", "RefreshVidata modellife", "Visuallnspection", "", ee.ToString());
                    return null;
                }
                #endregion


                #region Reset UI Value
                if (objCurVi == null)
                {
                    this.lblMaterialWeight.Foreground = new SolidColorBrush(Colors.DarkBlue);
                    this.lblMaterialWeight.Content = "1st Weight : " + "0 " + "2nd Weight : " + "0";
                }
                else
                {                    
                    //blllife.Update(objCurVi.machineID, objCurVi.partnumberall, (objCurVi.acountReading + decimal.Parse(objCurVi.remarks)).ToString());
                    tbkCavityCount.Text = objCurVi.cavityCount.ToString();
                    cbxCustomer.SelectedIndex =cbxCustomer.Items.IndexOf( objCurVi.customer.ToString());
                    tbkCycleTime.Text = objCurVi.cycleTime.ToString();
                    //TimeSpan ts = DateTime.Now - DateTime.Parse(objCurVi.dateTime.ToString());
                    //if (ts.TotalSeconds > 10)
                    //{
                    //    tbkCycleTime.Text = (double.Parse(objCurVi.acountReading.ToString()) / ts.TotalSeconds).ToString();
                    //}
                    tbkJigNo.Text = objCurVi.jigNo.ToString();
                    cbxModel.SelectedIndex = cbxModel.Items.IndexOf(objCurVi.model.ToString());
                    tbkTargetQty.Text = (objCurVi.targetQty * objCurVi.cavityCount).ToString();
                    //tbkFailQty.Text = objCurVi.rejectQty.ToString();
                    tbkFailQty.Text = _rejectQty.ToString();
                    tbkTotalQty.Text = objCurVi.acountReading.ToString();
                    tbkPassQty.Text = (objCurVi.acountReading - _rejectQty - objCurVi.QCNGQTY).ToString();//(int.Parse(tbkTotalQty.Text) - objCurVi.rejectQty).ToString();
                    if(int.Parse(tbkPassQty.Text) < 0 )
                    {
                        tbkPassQty.Text = "0";
                    }
                    tbkQCFailQty.Text = objCurVi.QCNGQTY.ToString();
                    txt_MHcheck.Text = objCurVi.Material_MHCheck.ToString();
                    txt_opcheck.Text = objCurVi.Material_Opcheck.ToString();
                    txt_leadercheck.Text = objCurVi.Material_LeaderCheck.ToString();
                    this.txt_MHcheck.IsEnabled = false;
                    this.txt_opcheck.IsEnabled = false;
                    this.txt_leadercheck.IsEnabled = false;
                    this.lblMaterialWeight.Foreground = new SolidColorBrush(Colors.DarkBlue);
                    this.lblMaterialWeight.Content = "1st : " + (objCurVi.partsWeight.ToString() == null ? "0" : objCurVi.partsWeight.ToString())
                         + " 2nd : " + (objCurVi.parts2Weight.ToString() == null ? "0" : objCurVi.parts2Weight.ToString());
                    setMajorInfo(false);
                }
                #endregion 

                return objCurVi;
            }
            catch (Exception ee)
            {
                DBHelp.Reports.LogFile.DebugLog("Error", "RefreshVidata", "Visuallnspection", "", ee.ToString());
                return null;
            }
        }

        public bool MouldCharst(string sPartNumber)
        {
            string[] eachMouldCharst = StaticRes.Global.MouldCharst.Split('|');
            foreach (string mouldCharts in eachMouldCharst)
            {
                if(sPartNumber == mouldCharts)
                {
                    return true; 
                }
            }
            return false;
        }

        private void iniDevControl(List<Common.Model.MouldingBom_Model> objBom_List)
        {
            iniTabControl();

            for (int i = 0; i < objBom_List.Count; i++)
            {
                TabItem ti = new TabItem();
                ti.Name = "Material_" + i.ToString().PadLeft(2, char.Parse("0"));
                ti.Header = objBom_List[i].partNumber;

                Grid gd = new Grid();
                gd.Name = "GridT" + i.ToString().PadLeft(2, char.Parse("0"));

                WrapPanel wp = new WrapPanel();
                wp.Name = "WrapPanal" + i.ToString().PadLeft(2, char.Parse("0"));
                wp.Margin = new Thickness(0, 0, 0, 0);
                gd.Children.Add(wp);

                double dCtrlWidth = StaticRes.Global.SystemConfig.dCtrlWidth;
                double dCtrlHeight = StaticRes.Global.SystemConfig.dCtrlHeight;
                double dGapWidth = StaticRes.Global.SystemConfig.dGapWidth;
                double dGapHeight = StaticRes.Global.SystemConfig.dGapHeight;
                double dDefectCodeFontSize = StaticRes.Global.SystemConfig.dDefectCodeFontSize;
                double dTotalQtyFontSize = StaticRes.Global.SystemConfig.dTotalQtyFontSize;
                Brush bDefectButtonBgColor = StaticRes.Global.SystemConfig.DefectButtonBgColor;
                Brush bDefectButtonFontColor = StaticRes.Global.SystemConfig.DefectButtonFontColor;

                Common.BLL.MouldingDefectSetting_BLL bllMouldDefSetting = new Common.BLL.MouldingDefectSetting_BLL();
                List<Common.Model.MouldingDefectSetting_Model> objMouldDefSet_List = new List<Common.Model.MouldingDefectSetting_Model>();
                objMouldDefSet_List = bllMouldDefSetting.GetListByModelPartJig(objBom_List[i].model, objBom_List[i].partNumber, objBom_List[i].jigNo);
                // objMouldDefSet_List = bllMouldDefSetting.GetListByModelPartJig(); 

                foreach (Common.Model.MouldingDefectSetting_Model objDefSet in objMouldDefSet_List)
                {
                    UserController.DefectController defCtrl1 = new UserController.DefectController();
                    defCtrl1.Name = "btnDef_" + objDefSet.defectCodeID + "_"  + objBom_List[i].partNumber.Replace("-", "ubct123").Replace(" ","ubct1680");
                    defCtrl1.DefectButtonText = objDefSet.defectCode +" "+ objDefSet.defectDescription;
                    //defCtrl1.DefectButtonText = objDefSet.defectCode ;
                    defCtrl1.Margin = new Thickness(dGapWidth, dGapHeight, 0, 0);
                    defCtrl1.VerticalAlignment = VerticalAlignment.Top;
                    defCtrl1.HorizontalAlignment = HorizontalAlignment.Left;
                    defCtrl1.TotalQtyFontSize = dTotalQtyFontSize;
                    defCtrl1.DefectButtonFontSize = dDefectCodeFontSize;
                    defCtrl1.DefectButtonBgColor = bDefectButtonBgColor;
                    defCtrl1.DefectButtonFontColor = bDefectButtonFontColor;
                    defCtrl1.Width = dCtrlWidth;
                    defCtrl1.Height = dCtrlHeight;
                    defCtrl1.HDClick += new UserController.DefectController.HDClickEventHandler(refreshVidata);
                    wp.Children.Add(defCtrl1);
                }

                #region "Testing"
                //iColCnt = 0;
                //iRowCnt = 0; 
                //UserController.DefectController defCtrl1 = new UserController.DefectController();
                //defCtrl1.DefectButtonText = "Black Point1";
                //// defCtrl1.Margin = new Thickness(10 + dCtrlWidth * iColCnt + dGapWidth * iColCnt, 20  + dCtrlHeight * iRowCnt + dGapHeight * iRowCnt, 0, 0);
                //defCtrl1.Margin = new Thickness(10  , 20  , 0, 0);
                //defCtrl1.VerticalAlignment = VerticalAlignment.Top;
                //defCtrl1.HorizontalAlignment = HorizontalAlignment.Left; 
                //defCtrl1.DefectButtonBgColor = new SolidColorBrush(Colors.Green);
                //defCtrl1.DefectButtonFontColor = new SolidColorBrush(Colors.White);
                //defCtrl1.Width = dCtrlWidth;
                //defCtrl1.Height = dCtrlHeight;
                //wp.Children.Add(defCtrl1);



                //iColCnt = 1;
                //iRowCnt = 0;
                //UserController.DefectController defCtrl2 = new UserController.DefectController();
                //defCtrl2.DefectButtonText = "White Point1";
                //// defCtrl2.Margin = new Thickness(10 + dCtrlWidth * iColCnt + dGapWidth * iColCnt, 20 + dCtrlHeight * iRowCnt + dGapHeight * iRowCnt, 0, 0);
                //defCtrl2.Margin = new Thickness(10, 20, 0, 0);
                //defCtrl2.VerticalAlignment = VerticalAlignment.Top;
                //defCtrl2.HorizontalAlignment = HorizontalAlignment.Left;
                //defCtrl2.DefectButtonBgColor = new SolidColorBrush(Colors.Green);
                //defCtrl2.DefectButtonFontColor = new SolidColorBrush(Colors.White);
                //defCtrl2.Width = dCtrlWidth;
                //defCtrl2.Height = dCtrlHeight;
                //wp.Children.Add(defCtrl2);


                //iColCnt = 2;
                //iRowCnt = 0;
                //UserController.DefectController defCtrl3 = new UserController.DefectController();
                //defCtrl3.DefectButtonText = "greed Point1";
                //// defCtrl3.Margin = new Thickness(10 + dCtrlWidth * iColCnt + dGapWidth * iColCnt, 20 + dCtrlHeight * iRowCnt + dGapHeight * iRowCnt, 0, 0);
                //defCtrl3.Margin = new Thickness(10, 20, 0, 0);
                //defCtrl3.VerticalAlignment = VerticalAlignment.Top;
                //defCtrl3.HorizontalAlignment = HorizontalAlignment.Left;
                //defCtrl3.DefectButtonBgColor = new SolidColorBrush(Colors.Green);
                //defCtrl3.DefectButtonFontColor = new SolidColorBrush(Colors.White);
                //defCtrl3.Width = dCtrlWidth;
                //defCtrl3.Height = dCtrlHeight;
                //wp.Children.Add(defCtrl3);



                //iColCnt = 0;
                //iRowCnt = 1;
                //UserController.DefectController defCtrl4 = new UserController.DefectController();
                //defCtrl4.DefectButtonText = "Black Point1";
                //// defCtrl4.Margin = new Thickness(10 + dCtrlWidth * iColCnt + dGapWidth * iColCnt, 20 + dCtrlHeight * iRowCnt + dGapHeight * iRowCnt, 0, 0);
                //defCtrl4.Margin = new Thickness(10, 20, 0, 0);
                //defCtrl4.VerticalAlignment = VerticalAlignment.Top;
                //defCtrl4.HorizontalAlignment = HorizontalAlignment.Left;
                //defCtrl4.DefectButtonBgColor = new SolidColorBrush(Colors.Green);
                //defCtrl4.DefectButtonFontColor = new SolidColorBrush(Colors.White);
                //defCtrl4.Width = dCtrlWidth;
                //defCtrl4.Height = dCtrlHeight;
                //wp.Children.Add(defCtrl4);



                //iColCnt = 1;
                //iRowCnt = 1;
                //UserController.DefectController defCtrl5 = new UserController.DefectController();
                //defCtrl5.DefectButtonText = "White Point1";
                //// defCtrl5.Margin = new Thickness(10 + dCtrlWidth * iColCnt + dGapWidth * iColCnt, 20 + dCtrlHeight * iRowCnt + dGapHeight * iRowCnt, 0, 0);
                //defCtrl5.Margin = new Thickness(10, 20, 0, 0);
                //defCtrl5.VerticalAlignment = VerticalAlignment.Top;
                //defCtrl5.HorizontalAlignment = HorizontalAlignment.Left;
                //defCtrl5.DefectButtonBgColor = new SolidColorBrush(Colors.Green);
                //defCtrl5.DefectButtonFontColor = new SolidColorBrush(Colors.White);
                //defCtrl5.Width = dCtrlWidth;
                //defCtrl5.Height = dCtrlHeight;
                //wp.Children.Add(defCtrl5);


                //iColCnt = 2;
                //iRowCnt = 1;
                //UserController.DefectController defCtrl6 = new UserController.DefectController();
                //defCtrl6.DefectButtonText = "greed Point1";
                //// defCtrl6.Margin = new Thickness(10 + dCtrlWidth * iColCnt + dGapWidth * iColCnt, 20 + dCtrlHeight * iRowCnt + dGapHeight * iRowCnt, 0, 0);
                //defCtrl6.Margin = new Thickness(10, 20, 0, 0);
                //defCtrl6.VerticalAlignment = VerticalAlignment.Top;
                //defCtrl6.HorizontalAlignment = HorizontalAlignment.Left;
                //defCtrl6.DefectButtonBgColor = new SolidColorBrush(Colors.Green);
                //defCtrl6.DefectButtonFontColor = new SolidColorBrush(Colors.White);
                //defCtrl6.Width = dCtrlWidth;
                //defCtrl6.Height = dCtrlHeight;
                //wp.Children.Add(defCtrl6); 
                #endregion
                ti.Content = gd;

                tcDefect.Items.Add(ti);
            }
        }
        private bool refreshDefData(List<Common.Model.MouldingViDefectTracking_Model> objViDef_List, List<Common.Model.MouldingBom_Model> objBom_List)
        {
            bool result = false;
            if (objViDef_List.Count == 0)
            {
                //abnormal ocap
            }
            else
            {
                TabItem ti = new TabItem();
                Grid gd = new Grid();
                WrapPanel wp = new WrapPanel();
                UserController.DefectController defCtrl1 = new UserController.DefectController();

                for (int i = _Number; i < this.tcDefect.Items.Count; i++)
                {
                    ti = new TabItem();
                    ti = (TabItem)this.tcDefect.Items[i];

                    gd = new Grid();
                    gd = (Grid)ti.Content;

                    wp = new WrapPanel();
                    wp = (WrapPanel)gd.Children[0];

                    foreach (object objCtrol in wp.Children)
                    { 
                        defCtrl1 = new UserController.DefectController();
                        defCtrl1 = (UserController.DefectController)objCtrol;
                        foreach (Common.Model.MouldingViDefectTracking_Model objVidef in objViDef_List)
                        {
                            string[] _defCtrName = defCtrl1.Name.Split('_');
                            if (_defCtrName[1] == objVidef.defectCodeID)
                            {
                                defCtrl1.ViDefect = objVidef;
                                defCtrl1.refreshShiftData();
                                break;
                            }
                        }
                    }
                }
            }

            return result;
        }

        #region PQM 
        private int getTotalQTYfromPQM(string MachineID)
        {
            return 0;
        }
        #endregion

        private void btnOpHourlyCheck_Click(object sender, RoutedEventArgs e)
        {
            DateTime dTime = DateTime.Now;
            StaticRes.Global._isUsingObjCurVi = true;
            _objCurVi = refreshVidata(StaticRes.Global.CurDay, StaticRes.Global.CurShift, (_objCurVi == null || _objCurVi.partNumber == null ? "" : _objCurVi.partNumber), StaticRes.Global.MachineID);
            if (_objCurVi == null)
            {
                _alertMsg = "Please Submit Correct Part No first!";
                MessageBox.Show(_alertMsg);
            }
            else
            {

                int iHour = dTime.Hour;
                if (iHour > 12)
                {
                    iHour = iHour - 12;
                }
                switch (iHour)
                {
                    case (1):
                        {
                            _objCurVi.opSign01 = dTime.ToString("HH:mm:ss") + "|" + StaticRes.Global.Current_User.userID;
                            _lightHigh = false;
                            this.btnOpHourlyCheck.Background = new SolidColorBrush(Colors.CornflowerBlue);
                            break;
                        }
                    case (2):
                        {
                            _objCurVi.opSign02 = dTime.ToString("HH:mm:ss") + "|" + StaticRes.Global.Current_User.userID;
                            _lightHigh = false;
                            this.btnOpHourlyCheck.Background = new SolidColorBrush(Colors.CornflowerBlue);
                            break;
                        }

                    case (3):
                        {
                            _objCurVi.opSign03 = dTime.ToString("HH:mm:ss") + "|" + StaticRes.Global.Current_User.userID;
                            _lightHigh = false;
                            this.btnOpHourlyCheck.Background = new SolidColorBrush(Colors.CornflowerBlue);
                            break;
                        }

                    case (4):
                        {
                            _objCurVi.opSign04 = dTime.ToString("HH:mm:ss") + "|" + StaticRes.Global.Current_User.userID;
                            _lightHigh = false;
                            this.btnOpHourlyCheck.Background = new SolidColorBrush(Colors.CornflowerBlue);
                            break;
                        }

                    case (5):
                        {
                            _objCurVi.opSign05 = dTime.ToString("HH:mm:ss") + "|" + StaticRes.Global.Current_User.userID;
                            _lightHigh = false;
                            this.btnOpHourlyCheck.Background = new SolidColorBrush(Colors.CornflowerBlue);
                            break;
                        }

                    case (6):
                        {
                            _objCurVi.opSign06 = dTime.ToString("HH:mm:ss") + "|" + StaticRes.Global.Current_User.userID;
                            _lightHigh = false;
                            this.btnOpHourlyCheck.Background = new SolidColorBrush(Colors.CornflowerBlue);
                            break;
                        }
                    case (7):
                        {
                            _objCurVi.opSign07 = dTime.ToString("HH:mm:ss") + "|" + StaticRes.Global.Current_User.userID;
                            _lightHigh = false;
                            this.btnOpHourlyCheck.Background = new SolidColorBrush(Colors.CornflowerBlue);
                            break;
                        }
                    case (8):
                        {
                            _objCurVi.opSign08 = dTime.ToString("HH:mm:ss") + "|" + StaticRes.Global.Current_User.userID;
                            _lightHigh = false;
                            this.btnOpHourlyCheck.Background = new SolidColorBrush(Colors.CornflowerBlue);
                            break;
                        }
                    case (9):
                        {
                            _objCurVi.opSign09 = dTime.ToString("HH:mm:ss") + "|" + StaticRes.Global.Current_User.userID;
                            _lightHigh = false;
                            this.btnOpHourlyCheck.Background = new SolidColorBrush(Colors.CornflowerBlue);
                            break;
                        }
                    case (10):
                        {
                            _objCurVi.opSign10 = dTime.ToString("HH:mm:ss") + "|" + StaticRes.Global.Current_User.userID;
                            _lightHigh = false;
                            this.btnOpHourlyCheck.Background = new SolidColorBrush(Colors.CornflowerBlue);
                            break;
                        }
                    case (11):
                        {
                            _objCurVi.opSign11 = dTime.ToString("HH:mm:ss") + "|" + StaticRes.Global.Current_User.userID;
                            _lightHigh = false;
                            this.btnOpHourlyCheck.Background = new SolidColorBrush(Colors.CornflowerBlue);
                            break;
                        }
                    case (12):
                        {
                            _objCurVi.opSign12 = dTime.ToString("HH:mm:ss") + "|" + StaticRes.Global.Current_User.userID;
                            _lightHigh = false;
                            this.btnOpHourlyCheck.Background = new SolidColorBrush(Colors.CornflowerBlue);
                            break;
                        }
                    case (0):
                        {
                            _objCurVi.opSign12 = dTime.ToString("HH:mm:ss") + "|" + StaticRes.Global.Current_User.userID;
                            _lightHigh = false;
                            this.btnOpHourlyCheck.Background = new SolidColorBrush(Colors.CornflowerBlue);
                            break;
                        }
                }
                _objCurVi.lastUpdatedTime = dTime;
                List<System.Data.SqlClient.SqlCommand> lSqlCmd = new List<System.Data.SqlClient.SqlCommand>();

                Common.BLL.MouldingViTracking_BLL bllVi = new Common.BLL.MouldingViTracking_BLL();
                lSqlCmd.Add(bllVi.UpdateCommand(_objCurVi));

                Common.BLL.MouldingViHistory_BLL bllViHis = new Common.BLL.MouldingViHistory_BLL();
                lSqlCmd.Add(bllViHis.AddCommand(bllViHis.CopyObj(_objCurVi)));

                if (DBHelp.SqlDB.SetData_Rollback(lSqlCmd))  //by ID
                {
                    MessageBox.Show("Hourly Check Record Updated!");
                }
                else
                {
                    MessageBox.Show("Hourly Check Update Database Failed!");
                }

            }

            StaticRes.Global._isUsingObjCurVi = false;
        }

        private void btnIpqcChcek_Click(object sender, RoutedEventArgs e)
        {
            
            StaticRes.Global._isUsingObjCurVi = true;
            _objCurVi = refreshVidata(StaticRes.Global.CurDay, StaticRes.Global.CurShift, (_objCurVi == null || _objCurVi.partNumber == null ? "" : _objCurVi.partNumber), StaticRes.Global.MachineID);
            if (_objCurVi == null)
            {
                _alertMsg = "Please Submit Correct Part No first!";
                MessageBox.Show(_alertMsg);
            }
            else
            {
                try
                {
                    Views.Login x = new Views.Login();
                    x.HDClick += new Views.Login.HDClickEventHandler(QC_Check);
                    x.BackClick += new Views.Login.BackMaskEventHandler(CloseMask);
                    x.ShowDialog();
                }
                catch (Exception ee)
                {
                    System.Windows.MessageBox.Show(ee.Message);
                }
            }

            StaticRes.Global._isUsingObjCurVi = false;
        }

        void QC_Check()
        {            
            try
            {
                if (StaticRes.Global.Falg_UserGroup == StaticRes.Global.Department.IPQC || StaticRes.Global.Falg_UserGroup == StaticRes.Global.Department.Admin)
                {
                    DateTime dTime = DateTime.Now;
                    int iHour = dTime.Hour;
                    if (iHour > 12)
                    {
                        iHour = iHour - 12;
                    }
                    switch (iHour)
                    {
                        case (1):
                            {
                                _objCurVi.qaSign01 = dTime.ToString("HH:mm:ss") + "|" + StaticRes.Global.Falg_User;
                                _objCurVi.QCNGQTY = _objCurVi.QCNGQTY + int.Parse(txtQCCOUNT.Text);
                                break;
                            }
                        case (2):
                            {
                                _objCurVi.qaSign02 = dTime.ToString("HH:mm:ss") + "|" + StaticRes.Global.Falg_User;
                                _objCurVi.QCNGQTY = _objCurVi.QCNGQTY + int.Parse(txtQCCOUNT.Text);
                                break;
                            }

                        case (3):
                            {
                                _objCurVi.qaSign03 = dTime.ToString("HH:mm:ss") + "|" + StaticRes.Global.Falg_User;
                                _objCurVi.QCNGQTY = _objCurVi.QCNGQTY + int.Parse(txtQCCOUNT.Text);
                                break;
                            }

                        case (4):
                            {
                                _objCurVi.qaSign04 = dTime.ToString("HH:mm:ss") + "|" + StaticRes.Global.Falg_User;
                                _objCurVi.QCNGQTY = _objCurVi.QCNGQTY + int.Parse(txtQCCOUNT.Text);
                                break;
                            }

                        case (5):
                            {
                                _objCurVi.qaSign05 = dTime.ToString("HH:mm:ss") + "|" + StaticRes.Global.Falg_User;
                                _objCurVi.QCNGQTY = _objCurVi.QCNGQTY + int.Parse(txtQCCOUNT.Text);
                                break;
                            }

                        case (6):
                            {
                                _objCurVi.qaSign06 = dTime.ToString("HH:mm:ss") + "|" + StaticRes.Global.Falg_User;
                                _objCurVi.QCNGQTY = _objCurVi.QCNGQTY + int.Parse(txtQCCOUNT.Text);
                                break;
                            }
                        case (7):
                            {
                                _objCurVi.qaSign07 = dTime.ToString("HH:mm:ss") + "|" + StaticRes.Global.Falg_User;
                                _objCurVi.QCNGQTY = _objCurVi.QCNGQTY + int.Parse(txtQCCOUNT.Text);
                                break;
                            }
                        case (8):
                            {
                                _objCurVi.qaSign08 = dTime.ToString("HH:mm:ss") + "|" + StaticRes.Global.Falg_User;
                                _objCurVi.QCNGQTY = _objCurVi.QCNGQTY + int.Parse(txtQCCOUNT.Text);
                                break;
                            }
                        case (9):
                            {
                                _objCurVi.qaSign09 = dTime.ToString("HH:mm:ss") + "|" + StaticRes.Global.Falg_User;
                                _objCurVi.QCNGQTY = _objCurVi.QCNGQTY + int.Parse(txtQCCOUNT.Text);
                                break;
                            }
                        case (10):
                            {
                                _objCurVi.qaSign10 = dTime.ToString("HH:mm:ss") + "|" + StaticRes.Global.Falg_User;
                                _objCurVi.QCNGQTY = _objCurVi.QCNGQTY + int.Parse(txtQCCOUNT.Text);
                                break;
                            }
                        case (11):
                            {
                                _objCurVi.qaSign11 = dTime.ToString("HH:mm:ss") + "|" + StaticRes.Global.Falg_User;
                                _objCurVi.QCNGQTY = _objCurVi.QCNGQTY + int.Parse(txtQCCOUNT.Text);
                                break;
                            }
                        case (12):
                            {
                                _objCurVi.qaSign12 = dTime.ToString("HH:mm:ss") + "|" + StaticRes.Global.Falg_User;
                                _objCurVi.QCNGQTY = _objCurVi.QCNGQTY + int.Parse(txtQCCOUNT.Text);
                                break;
                            }
                        case (0):
                            {
                                _objCurVi.qaSign12 = dTime.ToString("HH:mm:ss") + "|" + StaticRes.Global.Falg_User;
                                _objCurVi.QCNGQTY = _objCurVi.QCNGQTY + int.Parse(txtQCCOUNT.Text);
                                break;
                            }

                    }
                    _objCurVi.lastUpdatedTime = dTime;
                    List<System.Data.SqlClient.SqlCommand> lSqlCmd = new List<System.Data.SqlClient.SqlCommand>();

                    Common.BLL.MouldingViTracking_BLL bllVi = new Common.BLL.MouldingViTracking_BLL();
                    lSqlCmd.Add(bllVi.UpdateCommand(_objCurVi));

                    Common.BLL.MouldingViHistory_BLL bllViHis = new Common.BLL.MouldingViHistory_BLL();
                    lSqlCmd.Add(bllViHis.AddCommand(bllViHis.CopyObj(_objCurVi)));

                    if (DBHelp.SqlDB.SetData_Rollback(lSqlCmd))  //by ID
                    {
                        StaticRes.Global._isUsingObjCurVi = false;
                        txtQCCOUNT.Text = "0";

                        //2018 09 11 by lijia: refresh the main GUI 
                        _objCurVi = refreshVidata(StaticRes.Global.CurDay, StaticRes.Global.CurShift, (_objCurVi == null || _objCurVi.partNumber == null ? "" : _objCurVi.partNumber), StaticRes.Global.MachineID);

                        MessageBox.Show("QA Check Record Updated!");
                    }
                    else
                    {
                        StaticRes.Global._isUsingObjCurVi = false;
                        MessageBox.Show("QA Check Update Database Failed!");
                    }
                }
                else
                {
                    MessageBox.Show("You haven't access into it!");
                    return;
                }
            }
            catch (Exception ee)
            {
                System.Windows.MessageBox.Show(ee.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
        private void CloseMask()
        {
        }

        private void btnReduceChcek_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (int.Parse(this.txtQCCOUNT.Text) > 0)
                {
                    this.txtQCCOUNT.Text = (int.Parse(this.txtQCCOUNT.Text) - 1).ToString();
                }
            }
            catch (Exception ee)
            {
                MessageBox.Show("QA Reject Number less than 0!");
            }
        }

        private void btnaddChcek_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (int.Parse(this.txtQCCOUNT.Text) >= 0)
                {
                    this.txtQCCOUNT.Text = (int.Parse(this.txtQCCOUNT.Text) + 1).ToString();
                }
            }
            catch (Exception ee)
            {
                MessageBox.Show("QA Reject Number is not Int DataType!");
            }
        }



        #region Machine Status Button Fucntion
        
        private void btnRunning_Click(object sender, RoutedEventArgs e)
        {
            if (StaticRes.Global.ButtonStaus.Running)
            {
                if (MessageBox.Show("Change machine status into Running？", "", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
                {
                    StaticRes.Global.MachineStatus = StaticRes.Global.MachineSttaus.Running;
                    StaticRes.Global.OeeStatus = StaticRes.Global.oee.Operating;
                    _objMachine.remark = null;
                    if (updatemachine(false))
                    {
                        StaticRes.Global.ButtonStaus.Running = false;
                        StaticRes.Global.ButtonStaus.MaterialTesting = true;
                        StaticRes.Global.ButtonStaus.MouldTesting = true;
                        StaticRes.Global.ButtonStaus.ChangeModel = true;
                        StaticRes.Global.ButtonStaus.BreakTime = true;
                        StaticRes.Global.ButtonStaus.NoMaterial = true;
                        StaticRes.Global.ButtonStaus.NoOperator = true;
                        StaticRes.Global.ButtonStaus.Adjustment = true;
                        StaticRes.Global.ButtonStaus.ShutDown = true;
                        StaticRes.Global.ButtonStaus.No_Schedule = true;
                        StaticRes.Global.ButtonStaus.MachineBreak = true;
                        StaticRes.Global.ButtonStaus.DamageMould = true;
                        this.BtnRunning.Background = Brushes.Purple;
                        this.BtnMaterial_Testing.Background = Brushes.CornflowerBlue;
                        this.BtnMould_Testing.Background = Brushes.CornflowerBlue;
                        this.BtnModel.Background = Brushes.CornflowerBlue;
                        this.BtnBreak_Time.Background = Brushes.CornflowerBlue;
                        this.BtnNo_Material.Background = Brushes.CornflowerBlue;
                        this.BtnNo_Operatoer.Background = Brushes.CornflowerBlue;
                        this.BtnAdjustment.Background = Brushes.CornflowerBlue; 
                        this.BtnShut_Down.Background = Brushes.CornflowerBlue;
                        this.BtnNoSchedule.Background = Brushes.CornflowerBlue;
                        this.BtnMachineBreak.Background = Brushes.CornflowerBlue;
                        this.BtnDamageMould.Background = Brushes.CornflowerBlue;

                        //2018/12/04 add Testing or Running
                        if (StaticRes.Global.Status != Common.Model.MouldingViTracking_Model.StatusList.Running)
                        {
                            _objCurVi = refreshVidata(StaticRes.Global.CurDay, StaticRes.Global.CurShift, (_objCurVi == null || _objCurVi.partNumber == null ? "" : _objCurVi.partNumber), StaticRes.Global.MachineID);

                            StaticRes.Global.Status = Common.Model.MouldingViTracking_Model.StatusList.Running;
                            this.btnSubmit.IsEnabled = true;
                            if (StaticRes.Global.MachineID != "8")
                            {
                                _Number = 0;
                            }
                            else
                            {
                                _Number = 1;
                            }
                            iniTabControl();

                            tbkCavityCount.Text = "";
                            tbkCycleTime.Text = "";
                            tbkJigNo.Text = "";
                            tbkTargetQty.Text = "";
                            tbkFailQty.Text = "";
                            tbkTotalQty.Text = "";
                            tbkPassQty.Text = "";
                            tbkQCFailQty.Text = "";
                            txt_opcheck.Text = "";
                            txt_MHcheck.Text = "";
                            txt_leadercheck.Text = "";
                            _objCurVi = null;
                            setMajorInfo(false);
                        }
                    }
                }
                else
                {
                    return;
                }
            }
        }

        private void btnAdjustment_Click(object sender, RoutedEventArgs e)
        {
            UserController.McStopMessageBox mcStopBox = new UserController.McStopMessageBox(_objMachine, StaticRes.Global.MachineSttaus.Adjustment);

            this.gdMcStopReason.Children.Clear();
            this.gdMcStopReason.Children.Add(mcStopBox);
            this.gdMcStopReason.Visibility = Visibility.Visible;

            mcStopBox.SetReasonCompleteEvent += McStopBox_SetReasonCompleteEvent;
            
        }

        private void btnMaterialTest_Click(object sender, RoutedEventArgs e)
        {
            UserController.McStopMessageBox mcStopBox = new UserController.McStopMessageBox(_objMachine, StaticRes.Global.MachineSttaus.MaterialTesting);

            this.gdMcStopReason.Children.Clear();
            this.gdMcStopReason.Children.Add(mcStopBox);
            this.gdMcStopReason.Visibility = Visibility.Visible;

            mcStopBox.SetReasonCompleteEvent += McStopBox_SetReasonCompleteEvent;
        }

        private void btnMouldTest_Click(object sender, RoutedEventArgs e)
        {
            UserController.McStopMessageBox mcStopBox = new UserController.McStopMessageBox(_objMachine, StaticRes.Global.MachineSttaus.MouldTesting);

            this.gdMcStopReason.Children.Clear();
            this.gdMcStopReason.Children.Add(mcStopBox);
            this.gdMcStopReason.Visibility = Visibility.Visible;

            mcStopBox.SetReasonCompleteEvent += McStopBox_SetReasonCompleteEvent;
        }

        private void btnChangeMould_Click(object sender, RoutedEventArgs e)
        {
            if (StaticRes.Global.ButtonStaus.ChangeModel)
            {
                try
                {
                    Views.Login x = new Views.Login();
                    x.HDClick += new Views.Login.HDClickEventHandler(ChangeMould);
                    x.BackClick += new Views.Login.BackMaskEventHandler(CloseMask);
                    x.ShowDialog();
                }
                catch (Exception ee)
                {
                    System.Windows.MessageBox.Show(ee.Message);
                }
            }
        }

        void ChangeMould()
        {
            try
            {
                StaticRes.Global.MachineStatus = StaticRes.Global.MachineSttaus.ChangeModel;
                StaticRes.Global.OeeStatus = StaticRes.Global.oee.ChangeModel;
                _objMachine.remark = null;
                if (updatemachine(true))
                {
                    StaticRes.Global.ButtonStaus.Running = true;
                    StaticRes.Global.ButtonStaus.MaterialTesting = true;
                    StaticRes.Global.ButtonStaus.MouldTesting = true;
                    StaticRes.Global.ButtonStaus.ChangeModel = false;
                    StaticRes.Global.ButtonStaus.BreakTime = true;
                    StaticRes.Global.ButtonStaus.NoMaterial = true;
                    StaticRes.Global.ButtonStaus.NoOperator = true;
                    StaticRes.Global.ButtonStaus.ShutDown = true;
                    StaticRes.Global.ButtonStaus.Adjustment = true;
                    StaticRes.Global.ButtonStaus.No_Schedule = true;
                    StaticRes.Global.ButtonStaus.MachineBreak = true;
                    StaticRes.Global.ButtonStaus.DamageMould = true;
                    this.BtnRunning.Background = Brushes.CornflowerBlue;
                    this.BtnMaterial_Testing.Background = Brushes.CornflowerBlue;
                    this.BtnMould_Testing.Background = Brushes.CornflowerBlue;
                    this.BtnModel.Background = Brushes.Purple;
                    this.BtnBreak_Time.Background = Brushes.CornflowerBlue;
                    this.BtnNo_Material.Background = Brushes.CornflowerBlue;
                    this.BtnNo_Operatoer.Background = Brushes.CornflowerBlue;
                    this.BtnShut_Down.Background = Brushes.CornflowerBlue;
                    this.BtnAdjustment.Background = Brushes.CornflowerBlue;
                    this.BtnNoSchedule.Background = Brushes.CornflowerBlue;
                    this.BtnMachineBreak.Background = Brushes.CornflowerBlue;
                    this.BtnDamageMould.Background = Brushes.CornflowerBlue;
                }
            }
            catch (Exception ee)
            {
                System.Windows.MessageBox.Show(ee.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
        
        private void btnBreakTime_Click(object sender, RoutedEventArgs e)
        {
            if (StaticRes.Global.ButtonStaus.BreakTime)
            {
                if (MessageBox.Show("Change machine status into Break Time ？", "", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
                {
                    _objMachine.remark = "Meal";
                    StaticRes.Global.MachineStatus = StaticRes.Global.MachineSttaus.BreakTime;
                    StaticRes.Global.OeeStatus = StaticRes.Global.oee.Shut_Down;
                    if (updatemachine(false))
                    {
                        StaticRes.Global.ButtonStaus.Running = true;
                        StaticRes.Global.ButtonStaus.MaterialTesting = true;
                        StaticRes.Global.ButtonStaus.MouldTesting = true;
                        StaticRes.Global.ButtonStaus.ChangeModel = true;
                        StaticRes.Global.ButtonStaus.BreakTime = false;
                        StaticRes.Global.ButtonStaus.NoMaterial = true;
                        StaticRes.Global.ButtonStaus.NoOperator = true;
                        StaticRes.Global.ButtonStaus.ShutDown = true;
                        StaticRes.Global.ButtonStaus.Adjustment = true;
                        StaticRes.Global.ButtonStaus.No_Schedule = true;
                        StaticRes.Global.ButtonStaus.MachineBreak = true;
                        StaticRes.Global.ButtonStaus.DamageMould = true;
                        this.BtnRunning.Background = Brushes.CornflowerBlue;
                        this.BtnMaterial_Testing.Background = Brushes.CornflowerBlue;
                        this.BtnMould_Testing.Background = Brushes.CornflowerBlue;
                        this.BtnModel.Background = Brushes.CornflowerBlue;
                        this.BtnBreak_Time.Background = Brushes.Purple;
                        this.BtnNo_Material.Background = Brushes.CornflowerBlue;
                        this.BtnNo_Operatoer.Background = Brushes.CornflowerBlue;
                        this.BtnShut_Down.Background = Brushes.CornflowerBlue;
                        this.BtnAdjustment.Background = Brushes.CornflowerBlue;
                        this.BtnNoSchedule.Background = Brushes.CornflowerBlue;
                        this.BtnMachineBreak.Background = Brushes.CornflowerBlue;
                        this.BtnDamageMould.Background = Brushes.CornflowerBlue;
                    }
                }
                else
                {
                    return;
                }
            }
        }

        private void btnNoOperator_Click(object sender, RoutedEventArgs e)
        {
            if (StaticRes.Global.ButtonStaus.NoOperator)
            {
                if (MessageBox.Show("Change machine status into No Operator ？", "", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
                {
                    _objMachine.remark = "No Operator";
                    StaticRes.Global.MachineStatus = StaticRes.Global.MachineSttaus.NoOperator;
                    StaticRes.Global.OeeStatus = StaticRes.Global.oee.Shut_Down;
                    if (updatemachine(false))
                    {
                        StaticRes.Global.ButtonStaus.Running = true;
                        StaticRes.Global.ButtonStaus.MaterialTesting = true;
                        StaticRes.Global.ButtonStaus.MouldTesting = true;
                        StaticRes.Global.ButtonStaus.ChangeModel = true;
                        StaticRes.Global.ButtonStaus.BreakTime = true;
                        StaticRes.Global.ButtonStaus.NoMaterial = true;
                        StaticRes.Global.ButtonStaus.NoOperator = false;
                        StaticRes.Global.ButtonStaus.ShutDown = true;
                        StaticRes.Global.ButtonStaus.Adjustment = true;
                        StaticRes.Global.ButtonStaus.No_Schedule = true;
                        StaticRes.Global.ButtonStaus.MachineBreak = true;
                        StaticRes.Global.ButtonStaus.DamageMould = true;
                        this.BtnRunning.Background = Brushes.CornflowerBlue;
                        this.BtnMaterial_Testing.Background = Brushes.CornflowerBlue;
                        this.BtnMould_Testing.Background = Brushes.CornflowerBlue;
                        this.BtnModel.Background = Brushes.CornflowerBlue;
                        this.BtnBreak_Time.Background = Brushes.CornflowerBlue;
                        this.BtnNo_Material.Background = Brushes.CornflowerBlue;
                        this.BtnNo_Operatoer.Background = Brushes.Purple;
                        this.BtnShut_Down.Background = Brushes.CornflowerBlue;
                        this.BtnAdjustment.Background = Brushes.CornflowerBlue;
                        this.BtnNoSchedule.Background = Brushes.CornflowerBlue;
                        this.BtnMachineBreak.Background = Brushes.CornflowerBlue;
                        this.BtnDamageMould.Background = Brushes.CornflowerBlue;
                    }
                }
                else
                {
                    return;
                }
            }
        }

        private void btnNoMaterial_Click(object sender, RoutedEventArgs e)
        {
            UserController.McStopMessageBox mcStopBox = new UserController.McStopMessageBox(_objMachine, StaticRes.Global.MachineSttaus.NoMaterial);

            this.gdMcStopReason.Children.Clear();
            this.gdMcStopReason.Children.Add(mcStopBox);
            this.gdMcStopReason.Visibility = Visibility.Visible;
            
            mcStopBox.SetReasonCompleteEvent += McStopBox_SetReasonCompleteEvent;
        }
        
        private void BtnNo_MachineBreak_Click(object sender, RoutedEventArgs e)
        {
            UserController.McStopMessageBox mcStopBox = new UserController.McStopMessageBox(_objMachine, StaticRes.Global.MachineSttaus.MachineBreak);

            this.gdMcStopReason.Children.Clear();
            this.gdMcStopReason.Children.Add(mcStopBox);
            this.gdMcStopReason.Visibility = Visibility.Visible;

            mcStopBox.SetReasonCompleteEvent += McStopBox_SetReasonCompleteEvent;
        }

        private void btnDamageMould_Click(object sender, RoutedEventArgs e)
        {
            UserController.McStopMessageBox mcStopBox = new UserController.McStopMessageBox(_objMachine, StaticRes.Global.MachineSttaus.DamageMould);

            this.gdMcStopReason.Children.Clear();
            this.gdMcStopReason.Children.Add(mcStopBox);
            this.gdMcStopReason.Visibility = Visibility.Visible;

            mcStopBox.SetReasonCompleteEvent += McStopBox_SetReasonCompleteEvent;
        }

        private void btnNoSchedule_Click(object sender, RoutedEventArgs e)
        {
            if (StaticRes.Global.ButtonStaus.No_Schedule)
            {
                if (MessageBox.Show("Change machine status into No Schedule ？", "", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
                {
                    _objMachine.remark = "No Schedule";
                    StaticRes.Global.MachineStatus = StaticRes.Global.MachineSttaus.No_Schedule;
                    StaticRes.Global.OeeStatus = StaticRes.Global.oee.No_Schedule;
                    if (updatemachine(false))
                    {
                        StaticRes.Global.ButtonStaus.Running = true;
                        StaticRes.Global.ButtonStaus.MaterialTesting = true;
                        StaticRes.Global.ButtonStaus.MouldTesting = true;
                        StaticRes.Global.ButtonStaus.ChangeModel = true;
                        StaticRes.Global.ButtonStaus.BreakTime = true;
                        StaticRes.Global.ButtonStaus.NoMaterial = true;
                        StaticRes.Global.ButtonStaus.NoOperator = true;
                        StaticRes.Global.ButtonStaus.ShutDown = true;
                        StaticRes.Global.ButtonStaus.Adjustment = true;
                        StaticRes.Global.ButtonStaus.No_Schedule = false;
                        StaticRes.Global.ButtonStaus.MachineBreak = true;
                        StaticRes.Global.ButtonStaus.DamageMould = true;
                        this.BtnRunning.Background = Brushes.CornflowerBlue;
                        this.BtnMaterial_Testing.Background = Brushes.CornflowerBlue;
                        this.BtnMould_Testing.Background = Brushes.CornflowerBlue;
                        this.BtnModel.Background = Brushes.CornflowerBlue;
                        this.BtnBreak_Time.Background = Brushes.CornflowerBlue;
                        this.BtnNo_Material.Background = Brushes.CornflowerBlue;
                        this.BtnNo_Operatoer.Background = Brushes.CornflowerBlue;
                        this.BtnShut_Down.Background = Brushes.CornflowerBlue;
                        this.BtnAdjustment.Background = Brushes.CornflowerBlue;
                        this.BtnNoSchedule.Background = Brushes.Purple;
                        this.BtnMachineBreak.Background = Brushes.CornflowerBlue;
                        this.BtnDamageMould.Background = Brushes.CornflowerBlue;
                    }
                }
                else
                {
                    return;
                }
            }
        }

        private void McStopBox_SetReasonCompleteEvent(bool result, string sMcStatus)
        {
            if (result)
            {
                switch (sMcStatus)
                {
                    case StaticRes.Global.MachineSttaus.Adjustment:
                        #region adjustment
                        {
                            StaticRes.Global.ButtonStaus.Running = true;
                            StaticRes.Global.ButtonStaus.MaterialTesting = true;
                            StaticRes.Global.ButtonStaus.MouldTesting = true;
                            StaticRes.Global.ButtonStaus.ChangeModel = true;
                            StaticRes.Global.ButtonStaus.BreakTime = true;
                            StaticRes.Global.ButtonStaus.NoMaterial = true;
                            StaticRes.Global.ButtonStaus.NoOperator = true;
                            StaticRes.Global.ButtonStaus.ShutDown = true;
                            StaticRes.Global.ButtonStaus.Adjustment = false;
                            StaticRes.Global.ButtonStaus.No_Schedule = true;
                            StaticRes.Global.ButtonStaus.MachineBreak = true;
                            StaticRes.Global.ButtonStaus.DamageMould = true;
                            this.BtnRunning.Background = Brushes.CornflowerBlue;
                            this.BtnMaterial_Testing.Background = Brushes.CornflowerBlue;
                            this.BtnMould_Testing.Background = Brushes.CornflowerBlue;
                            this.BtnModel.Background = Brushes.CornflowerBlue;
                            this.BtnBreak_Time.Background = Brushes.CornflowerBlue;
                            this.BtnNo_Material.Background = Brushes.CornflowerBlue;
                            this.BtnNo_Operatoer.Background = Brushes.CornflowerBlue;
                            this.BtnShut_Down.Background = Brushes.CornflowerBlue;
                            this.BtnAdjustment.Background = Brushes.Purple;
                            this.BtnNoSchedule.Background = Brushes.CornflowerBlue;
                            this.BtnMachineBreak.Background = Brushes.CornflowerBlue;
                            this.BtnDamageMould.Background = Brushes.CornflowerBlue;
                        }
                        #endregion
                        break;

                    case StaticRes.Global.MachineSttaus.MaterialTesting:
                        #region material testing
                        {
                            StaticRes.Global.ButtonStaus.Running = true;
                            StaticRes.Global.ButtonStaus.MaterialTesting = false;
                            StaticRes.Global.ButtonStaus.MouldTesting = true;
                            StaticRes.Global.ButtonStaus.ChangeModel = true;
                            StaticRes.Global.ButtonStaus.BreakTime = true;
                            StaticRes.Global.ButtonStaus.NoMaterial = true;
                            StaticRes.Global.ButtonStaus.NoOperator = true;
                            StaticRes.Global.ButtonStaus.ShutDown = true;
                            StaticRes.Global.ButtonStaus.Adjustment = true;
                            StaticRes.Global.ButtonStaus.No_Schedule = true;
                            StaticRes.Global.ButtonStaus.MachineBreak = true;
                            StaticRes.Global.ButtonStaus.DamageMould = true;
                            this.BtnRunning.Background = Brushes.CornflowerBlue;
                            this.BtnMaterial_Testing.Background = Brushes.Purple;
                            this.BtnMould_Testing.Background = Brushes.CornflowerBlue;
                            this.BtnModel.Background = Brushes.CornflowerBlue;
                            this.BtnBreak_Time.Background = Brushes.CornflowerBlue;
                            this.BtnNo_Material.Background = Brushes.CornflowerBlue;
                            this.BtnNo_Operatoer.Background = Brushes.CornflowerBlue;
                            this.BtnShut_Down.Background = Brushes.CornflowerBlue;
                            this.BtnAdjustment.Background = Brushes.CornflowerBlue;
                            this.BtnNoSchedule.Background = Brushes.CornflowerBlue;
                            this.BtnMachineBreak.Background = Brushes.CornflowerBlue;
                            this.BtnDamageMould.Background = Brushes.CornflowerBlue;

                            //2018/12/04 add Testing or Running
                            if (StaticRes.Global.Status != Common.Model.MouldingViTracking_Model.StatusList.MaterialTesting)
                            {
                                _objCurVi = refreshVidata(StaticRes.Global.CurDay, StaticRes.Global.CurShift, (_objCurVi == null || _objCurVi.partNumber == null ? "" : _objCurVi.partNumber), StaticRes.Global.MachineID);

                                StaticRes.Global.Status = Common.Model.MouldingViTracking_Model.StatusList.MaterialTesting;
                                this.btnSubmit.IsEnabled = true;
                                if (StaticRes.Global.MachineID != "8")
                                {
                                    _Number = 0;
                                }
                                else
                                {
                                    _Number = 1;
                                }
                                iniTabControl();

                                tbkCavityCount.Text = "";
                                tbkCycleTime.Text = "";
                                tbkJigNo.Text = "";
                                tbkTargetQty.Text = "";
                                tbkFailQty.Text = "";
                                tbkTotalQty.Text = "";
                                tbkPassQty.Text = "";
                                tbkQCFailQty.Text = "";
                                txt_opcheck.Text = "";
                                txt_MHcheck.Text = "";
                                txt_leadercheck.Text = "";
                                _objCurVi = null;
                                setMajorInfo(false);
                            }
                        }
                        #endregion
                        break;

                    case StaticRes.Global.MachineSttaus.MouldTesting:
                        #region mould testing
                        {
                            StaticRes.Global.ButtonStaus.Running = true;
                            StaticRes.Global.ButtonStaus.MaterialTesting = true;
                            StaticRes.Global.ButtonStaus.MouldTesting = false;
                            StaticRes.Global.ButtonStaus.ChangeModel = true;
                            StaticRes.Global.ButtonStaus.BreakTime = true;
                            StaticRes.Global.ButtonStaus.NoMaterial = true;
                            StaticRes.Global.ButtonStaus.NoOperator = true;
                            StaticRes.Global.ButtonStaus.ShutDown = true;
                            StaticRes.Global.ButtonStaus.Adjustment = true;
                            StaticRes.Global.ButtonStaus.No_Schedule = true;
                            StaticRes.Global.ButtonStaus.MachineBreak = true;
                            StaticRes.Global.ButtonStaus.DamageMould = true;
                            this.BtnRunning.Background = Brushes.CornflowerBlue;
                            this.BtnMaterial_Testing.Background = Brushes.CornflowerBlue;
                            this.BtnMould_Testing.Background = Brushes.Purple;
                            this.BtnModel.Background = Brushes.CornflowerBlue;
                            this.BtnBreak_Time.Background = Brushes.CornflowerBlue;
                            this.BtnNo_Material.Background = Brushes.CornflowerBlue;
                            this.BtnNo_Operatoer.Background = Brushes.CornflowerBlue;
                            this.BtnShut_Down.Background = Brushes.CornflowerBlue;
                            this.BtnAdjustment.Background = Brushes.CornflowerBlue;
                            this.BtnNoSchedule.Background = Brushes.CornflowerBlue;
                            this.BtnMachineBreak.Background = Brushes.CornflowerBlue;
                            this.BtnDamageMould.Background = Brushes.CornflowerBlue;

                            //2018/12/04 add Testing or Running
                            if (StaticRes.Global.Status != Common.Model.MouldingViTracking_Model.StatusList.MouldTesting)
                            {
                                _objCurVi = refreshVidata(StaticRes.Global.CurDay, StaticRes.Global.CurShift, (_objCurVi == null || _objCurVi.partNumber == null ? "" : _objCurVi.partNumber), StaticRes.Global.MachineID);

                                StaticRes.Global.Status = Common.Model.MouldingViTracking_Model.StatusList.MouldTesting;
                                this.btnSubmit.IsEnabled = true;
                                if (StaticRes.Global.MachineID != "8")
                                {
                                    _Number = 0;
                                }
                                else
                                {
                                    _Number = 1;
                                }
                                iniTabControl();
                                tbkCavityCount.Text = "";
                                tbkCycleTime.Text = "";
                                tbkJigNo.Text = "";
                                tbkTargetQty.Text = "";
                                tbkFailQty.Text = "";
                                tbkTotalQty.Text = "";
                                tbkPassQty.Text = "";
                                tbkQCFailQty.Text = "";
                                txt_opcheck.Text = "";
                                txt_MHcheck.Text = "";
                                txt_leadercheck.Text = "";
                                _objCurVi = null;
                                setMajorInfo(false);
                            }
                        }
                        #endregion
                        break;

                    case StaticRes.Global.MachineSttaus.NoMaterial:
                        #region no material 
                        {
                            StaticRes.Global.ButtonStaus.Running = true;
                            StaticRes.Global.ButtonStaus.MaterialTesting = true;
                            StaticRes.Global.ButtonStaus.MouldTesting = true;
                            StaticRes.Global.ButtonStaus.ChangeModel = true;
                            StaticRes.Global.ButtonStaus.BreakTime = true;
                            StaticRes.Global.ButtonStaus.NoMaterial = false;
                            StaticRes.Global.ButtonStaus.NoOperator = true;
                            StaticRes.Global.ButtonStaus.ShutDown = true;
                            StaticRes.Global.ButtonStaus.Adjustment = true;
                            StaticRes.Global.ButtonStaus.No_Schedule = true;
                            StaticRes.Global.ButtonStaus.MachineBreak = true;
                            StaticRes.Global.ButtonStaus.DamageMould = true;
                            this.BtnRunning.Background = Brushes.CornflowerBlue;
                            this.BtnMaterial_Testing.Background = Brushes.CornflowerBlue;
                            this.BtnMould_Testing.Background = Brushes.CornflowerBlue;
                            this.BtnModel.Background = Brushes.CornflowerBlue;
                            this.BtnBreak_Time.Background = Brushes.CornflowerBlue;
                            this.BtnNo_Material.Background = Brushes.Purple;
                            this.BtnNo_Operatoer.Background = Brushes.CornflowerBlue;
                            this.BtnShut_Down.Background = Brushes.CornflowerBlue;
                            this.BtnAdjustment.Background = Brushes.CornflowerBlue;
                            this.BtnNoSchedule.Background = Brushes.CornflowerBlue;
                            this.BtnMachineBreak.Background = Brushes.CornflowerBlue;
                            this.BtnDamageMould.Background = Brushes.CornflowerBlue;
                        }
                        #endregion 
                        break;

                    case StaticRes.Global.MachineSttaus.MachineBreak:
                        #region machine break
                        {
                            StaticRes.Global.ButtonStaus.Running = true;
                            StaticRes.Global.ButtonStaus.MaterialTesting = true;
                            StaticRes.Global.ButtonStaus.MouldTesting = true;
                            StaticRes.Global.ButtonStaus.ChangeModel = true;
                            StaticRes.Global.ButtonStaus.BreakTime = true;
                            StaticRes.Global.ButtonStaus.NoMaterial = true;
                            StaticRes.Global.ButtonStaus.NoOperator = true;
                            StaticRes.Global.ButtonStaus.ShutDown = true;
                            StaticRes.Global.ButtonStaus.Adjustment = true;
                            StaticRes.Global.ButtonStaus.No_Schedule = true;
                            StaticRes.Global.ButtonStaus.MachineBreak = false;
                            StaticRes.Global.ButtonStaus.DamageMould = true;
                            this.BtnRunning.Background = Brushes.CornflowerBlue;
                            this.BtnMaterial_Testing.Background = Brushes.CornflowerBlue;
                            this.BtnMould_Testing.Background = Brushes.CornflowerBlue;
                            this.BtnModel.Background = Brushes.CornflowerBlue;
                            this.BtnBreak_Time.Background = Brushes.CornflowerBlue;
                            this.BtnNo_Material.Background = Brushes.CornflowerBlue;
                            this.BtnNo_Operatoer.Background = Brushes.CornflowerBlue;
                            this.BtnShut_Down.Background = Brushes.CornflowerBlue;
                            this.BtnAdjustment.Background = Brushes.CornflowerBlue;
                            this.BtnNoSchedule.Background = Brushes.CornflowerBlue;
                            this.BtnMachineBreak.Background = Brushes.Purple;
                            this.BtnDamageMould.Background = Brushes.CornflowerBlue;
                        }
                        #endregion
                        break;

                    case StaticRes.Global.MachineSttaus.DamageMould:
                        #region mould damage
                        {
                            StaticRes.Global.ButtonStaus.Running = true;
                            StaticRes.Global.ButtonStaus.MaterialTesting = true;
                            StaticRes.Global.ButtonStaus.MouldTesting = true;
                            StaticRes.Global.ButtonStaus.ChangeModel = true;
                            StaticRes.Global.ButtonStaus.BreakTime = true;
                            StaticRes.Global.ButtonStaus.NoMaterial = true;
                            StaticRes.Global.ButtonStaus.NoOperator = true;
                            StaticRes.Global.ButtonStaus.ShutDown = true;
                            StaticRes.Global.ButtonStaus.Adjustment = true;
                            StaticRes.Global.ButtonStaus.No_Schedule = true;
                            StaticRes.Global.ButtonStaus.MachineBreak = true;
                            StaticRes.Global.ButtonStaus.DamageMould = false;
                            this.BtnRunning.Background = Brushes.CornflowerBlue;
                            this.BtnMaterial_Testing.Background = Brushes.CornflowerBlue;
                            this.BtnMould_Testing.Background = Brushes.CornflowerBlue;
                            this.BtnModel.Background = Brushes.CornflowerBlue;
                            this.BtnBreak_Time.Background = Brushes.CornflowerBlue;
                            this.BtnNo_Material.Background = Brushes.CornflowerBlue;
                            this.BtnNo_Operatoer.Background = Brushes.CornflowerBlue;
                            this.BtnShut_Down.Background = Brushes.CornflowerBlue;
                            this.BtnAdjustment.Background = Brushes.CornflowerBlue;
                            this.BtnNoSchedule.Background = Brushes.CornflowerBlue;
                            this.BtnMachineBreak.Background = Brushes.CornflowerBlue;
                            this.BtnDamageMould.Background = Brushes.Purple;
                        }
                        #endregion
                        break;

                    default:
                        break;
                }
            }

            this.gdMcStopReason.Visibility = Visibility.Collapsed;
        }

        public bool updatemachine(bool _MachineStatus)
        {
            _objMachine.machinestatus = StaticRes.Global.MachineStatus;
            _objMachine.oeestatus = StaticRes.Global.OeeStatus;

            _objMachine.starttime = System.DateTime.Now;
            if (_objCurVi != null)
            {
                _objMachine.partno = _objCurVi.partNumber;
            }
            else
            {
                _objMachine.partno = null;
            }
            if (StaticRes.Global.Current_User != null)
            {
                _objMachine.userid = StaticRes.Global.Current_User.userID;
                _objMachine.username = StaticRes.Global.Current_User.userName;
                if (_MachineStatus)
                {
                    _objMachine.userid = StaticRes.Global.Falg_User;
                }
            }
            else
            {
                _objMachine.userid = null;
                _objMachine.username = null;
            }
            Common.BLL.MouldingMachineStatus_BLL _bMachine = new Common.BLL.MouldingMachineStatus_BLL();
            _bMachine.endtimesearchandupdate(_objMachine);

            List<System.Data.SqlClient.SqlCommand> lSqlCmd = new List<System.Data.SqlClient.SqlCommand>();

            lSqlCmd.Add(_bMachine.add(_objMachine));
            _objMachine.userid = null;
            if (DBHelp.SqlDB.SetData_Rollback(lSqlCmd))  //by ID
            {
                //MessageBox.Show("Machine Status Record Updated!");
            }
            else
            {
                //MessageBox.Show("Machine Status Update Database Failed!");
            }
            return true;
        }


        #endregion





        private void btnOpenkeyBoard_Click(object sender, RoutedEventArgs e)
        {
            //try
            //{
            //    Process.Start(@"C:\windows\system32\osk.exe");
            //}
            //catch (Exception)
            //{
            //    return ;
            //}
            if (StaticRes.Global.ButtonStaus.ShutDown)
            {
                if (MessageBox.Show("Change machine status into WeekEnd/P.H ？", "", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
                {
                    _objMachine.remark = null;
                    StaticRes.Global.MachineStatus = StaticRes.Global.MachineSttaus.ShutDown;
                    StaticRes.Global.OeeStatus = StaticRes.Global.oee.Shut_Down;
                    if (updatemachine(false))
                    {
                        StaticRes.Global.ButtonStaus.Running = true;
                        StaticRes.Global.ButtonStaus.MaterialTesting = true;
                        StaticRes.Global.ButtonStaus.MouldTesting = true;
                        StaticRes.Global.ButtonStaus.ChangeModel = true;
                        StaticRes.Global.ButtonStaus.BreakTime = true;
                        StaticRes.Global.ButtonStaus.NoMaterial = true;
                        StaticRes.Global.ButtonStaus.NoOperator = true;
                        StaticRes.Global.ButtonStaus.ShutDown = false;
                        StaticRes.Global.ButtonStaus.Adjustment = true;
                        StaticRes.Global.ButtonStaus.No_Schedule = true;
                        StaticRes.Global.ButtonStaus.MachineBreak = true;
                        StaticRes.Global.ButtonStaus.DamageMould = true;
                        this.BtnRunning.Background = Brushes.CornflowerBlue;
                        this.BtnMaterial_Testing.Background = Brushes.CornflowerBlue;
                        this.BtnMould_Testing.Background = Brushes.CornflowerBlue;
                        this.BtnModel.Background = Brushes.CornflowerBlue;
                        this.BtnBreak_Time.Background = Brushes.CornflowerBlue;
                        this.BtnNo_Material.Background = Brushes.CornflowerBlue;
                        this.BtnNo_Operatoer.Background = Brushes.CornflowerBlue;
                        this.BtnShut_Down.Background = Brushes.Purple;
                        this.BtnAdjustment.Background = Brushes.CornflowerBlue;
                        this.BtnNoSchedule.Background = Brushes.CornflowerBlue;
                        this.BtnMachineBreak.Background = Brushes.CornflowerBlue;
                        this.BtnDamageMould.Background = Brushes.CornflowerBlue;
                    }
                }
                else
                {
                    return;
                }
            }

        }

        private void btnLeaderCheck_Click(object sender, RoutedEventArgs e)
        {
            StaticRes.Global._isUsingObjCurVi = true;
            _objCurVi = refreshVidata(StaticRes.Global.CurDay, StaticRes.Global.CurShift, (_objCurVi == null || _objCurVi.partNumber == null ? "" : _objCurVi.partNumber), StaticRes.Global.MachineID);
            if (_objCurVi == null)
            {
                _alertMsg = "Please Submit Correct Part No first!";
                MessageBox.Show(_alertMsg);
            }
            else
            {
                try
                {
                    Views.Login x = new Views.Login();
                    x.HDClick += new Views.Login.HDClickEventHandler(Leader_Check);
                    x.BackClick += new Views.Login.BackMaskEventHandler(CloseMask);
                    x.ShowDialog();
                }
                catch (Exception ee)
                {
                    System.Windows.MessageBox.Show(ee.Message);
                }
            }

            StaticRes.Global._isUsingObjCurVi = false;
        }

        void Leader_Check()
        {
            try
            {
                if (StaticRes.Global.Falg_UserGroup == StaticRes.Global.Department.Supervisor || StaticRes.Global.Falg_UserGroup == StaticRes.Global.Department.Leader || StaticRes.Global.Falg_UserGroup == StaticRes.Global.Department.Admin)
                {
                    DateTime dTime = System.DateTime.Now;
                    _objCurVi.lastUpdatedTime = dTime;
                    _objCurVi.LeaderCheck = StaticRes.Global.Falg_User;
                    _objCurVi.LeaderCheckTime = dTime;
                    List<System.Data.SqlClient.SqlCommand> lSqlCmd = new List<System.Data.SqlClient.SqlCommand>();

                    Common.BLL.MouldingViTracking_BLL bllVi = new Common.BLL.MouldingViTracking_BLL();
                    lSqlCmd.Add(bllVi.UpdateCommand(_objCurVi));

                    Common.BLL.MouldingViHistory_BLL bllViHis = new Common.BLL.MouldingViHistory_BLL();
                    lSqlCmd.Add(bllViHis.AddCommand(bllViHis.CopyObj(_objCurVi)));

                    if (DBHelp.SqlDB.SetData_Rollback(lSqlCmd))  //by ID
                    {
                        MessageBox.Show("leader Check Record Updated!");
                        this.btnleaderChcek.Background = new SolidColorBrush(Colors.CornflowerBlue);
                    }
                    else
                    {
                        MessageBox.Show("Leader Check Update Database Failed!");
                    }
                }
                else
                {
                    MessageBox.Show("You haven't access into it!");
                    return;
                }
            }
            catch (Exception ee)
            {
                System.Windows.MessageBox.Show(ee.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void btnSupervisorCheck_Click(object sender, RoutedEventArgs e)
        {
            StaticRes.Global._isUsingObjCurVi = true;
            _objCurVi = refreshVidata(StaticRes.Global.CurDay, StaticRes.Global.CurShift, (_objCurVi == null || _objCurVi.partNumber == null ? "" : _objCurVi.partNumber), StaticRes.Global.MachineID);
            if (_objCurVi == null)
            {
                _alertMsg = "Please Submit Correct Part No first!";
                MessageBox.Show(_alertMsg);
            }
            else
            {
                try
                {
                    Views.Login x = new Views.Login();
                    x.HDClick += new Views.Login.HDClickEventHandler(Supervisor_Check);
                    x.BackClick += new Views.Login.BackMaskEventHandler(CloseMask);
                    x.ShowDialog();
                }
                catch (Exception ee)
                {
                    System.Windows.MessageBox.Show(ee.Message);
                }
            }

            StaticRes.Global._isUsingObjCurVi = false;
        }

        void Supervisor_Check()
        {
            try
            {
                if (StaticRes.Global.Falg_UserGroup == StaticRes.Global.Department.Supervisor || StaticRes.Global.Falg_UserGroup == StaticRes.Global.Department.Admin)
                {
                    DateTime dTime = System.DateTime.Now;
                    _objCurVi.lastUpdatedTime = dTime;
                    _objCurVi.SupervisorCheck = StaticRes.Global.Falg_User;
                    _objCurVi.SupervisorCheckTime = dTime;
                    List<System.Data.SqlClient.SqlCommand> lSqlCmd = new List<System.Data.SqlClient.SqlCommand>();

                    Common.BLL.MouldingViTracking_BLL bllVi = new Common.BLL.MouldingViTracking_BLL();
                    lSqlCmd.Add(bllVi.UpdateCommand(_objCurVi));

                    Common.BLL.MouldingViHistory_BLL bllViHis = new Common.BLL.MouldingViHistory_BLL();
                    lSqlCmd.Add(bllViHis.AddCommand(bllViHis.CopyObj(_objCurVi)));

                    if (DBHelp.SqlDB.SetData_Rollback(lSqlCmd))  //by ID
                    {
                        MessageBox.Show("Supervisor Check Record Updated!");
                    }
                    else
                    {
                        MessageBox.Show("Supervisor Check Update Database Failed!");
                    }
                }
                else
                {
                    MessageBox.Show("You haven't access into it!");
                    return;
                }
            }
            catch (Exception ee)
            {
                System.Windows.MessageBox.Show(ee.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void btnMaterCheck_Click(object sender, RoutedEventArgs e)
        {
            StaticRes.Global._isUsingObjCurVi = true;
            _objCurVi = refreshVidata(StaticRes.Global.CurDay, StaticRes.Global.CurShift, (_objCurVi == null || _objCurVi.partNumber == null ? "" : _objCurVi.partNumber), StaticRes.Global.MachineID);
            if (_objCurVi == null)
            {
                _alertMsg = "Please Submit Correct Part No first!";
                MessageBox.Show(_alertMsg);
            }
            else
            {
                try
                {
                    Views.Login x = new Views.Login();
                    x.HDClick += new Views.Login.HDClickEventHandler(Mater_Check);
                    x.BackClick += new Views.Login.BackMaskEventHandler(CloseMask);
                    x.ShowDialog();
                }
                catch (Exception ee)
                {
                    System.Windows.MessageBox.Show(ee.Message);
                }
            }

            StaticRes.Global._isUsingObjCurVi = false;
        }

        void Mater_Check()
        {
            try
            {
                if (StaticRes.Global.Falg_UserGroup == StaticRes.Global.Department.MH || StaticRes.Global.Falg_UserGroup == StaticRes.Global.Department.Supervisor || StaticRes.Global.Falg_UserGroup == StaticRes.Global.Department.Admin)
                {
                    if (!MaterialBatchValidationForMH(cbxMat1Part.SelectedValue.ToString(), cbxMat2Part.SelectedValue.ToString(), txtMat1Batch.Text.Trim(), txtMat2Batch.Text.Trim()))
                    {
                        MessageBox.Show("Please input Material Batch No!");
                        return;
                    }

                    DateTime dTime = System.DateTime.Now;
                    _objCurVi.lastUpdatedTime = dTime;
                    _objCurVi.Material_MHCheck = StaticRes.Global.Falg_User;
                    _objCurVi.Material_MHCheckTime = dTime;
                    this.txt_MHcheck.Text = StaticRes.Global.Falg_User;
                    this.txt_MHcheck.IsEnabled = false;
                    List<System.Data.SqlClient.SqlCommand> lSqlCmd = new List<System.Data.SqlClient.SqlCommand>();
                    _objCurVi.matLot01 = txtMat1Batch.Text.Trim();
                    _objCurVi.matLot02 = txtMat2Batch.Text.Trim();

                    Common.BLL.MouldingViTracking_BLL bllVi = new Common.BLL.MouldingViTracking_BLL();
                    lSqlCmd.Add(bllVi.UpdateCommand(_objCurVi));

                    Common.BLL.MouldingViHistory_BLL bllViHis = new Common.BLL.MouldingViHistory_BLL();
                    lSqlCmd.Add(bllViHis.AddCommand(bllViHis.CopyObj(_objCurVi)));

                    if (DBHelp.SqlDB.SetData_Rollback(lSqlCmd))  //by ID
                    {
                        MessageBox.Show("MH Check Record Updated!");
                    }
                    else
                    {
                        MessageBox.Show("MH Check Update Database Failed!");
                    }

                    if (txt_MHcheck.Text.Length > 0 && txt_opcheck.Text.Length > 0 && txt_leadercheck.Text.Length > 0)
                    {
                        txtMat1Batch.IsEnabled = false;
                        txtMat2Batch.IsEnabled = false;
                    }
                }
                else
                {
                    MessageBox.Show("You haven't access into it!");
                    return;
                }
            }
            catch (Exception ee)
            {
                System.Windows.MessageBox.Show(ee.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void btnOpMaterCheck_Click(object sender, RoutedEventArgs e)
        {
            StaticRes.Global._isUsingObjCurVi = true;
            _objCurVi = refreshVidata(StaticRes.Global.CurDay, StaticRes.Global.CurShift, (_objCurVi == null || _objCurVi.partNumber == null ? "" : _objCurVi.partNumber), StaticRes.Global.MachineID);
            if (_objCurVi == null)
            {
                _alertMsg = "Please Submit Correct Part No first!";
                MessageBox.Show(_alertMsg);
            }
            else
            {
                try
                {
                    OpMater_Check();
                }
                catch (Exception ee)
                {
                    System.Windows.MessageBox.Show(ee.Message);
                }
            }

            StaticRes.Global._isUsingObjCurVi = false;
        }

        void OpMater_Check()
        {
            try
            {
                DateTime dTime = System.DateTime.Now;
                _objCurVi.lastUpdatedTime = dTime;
                _objCurVi.Material_Opcheck = StaticRes.Global.Current_User.userID;
                _objCurVi.Material_OpCheckTime = dTime;
                this.txt_opcheck.Text = StaticRes.Global.Current_User.userID;
                this.txt_opcheck.IsEnabled = false;
                List<System.Data.SqlClient.SqlCommand> lSqlCmd = new List<System.Data.SqlClient.SqlCommand>();

                Common.BLL.MouldingViTracking_BLL bllVi = new Common.BLL.MouldingViTracking_BLL();
                lSqlCmd.Add(bllVi.UpdateCommand(_objCurVi));

                Common.BLL.MouldingViHistory_BLL bllViHis = new Common.BLL.MouldingViHistory_BLL();
                lSqlCmd.Add(bllViHis.AddCommand(bllViHis.CopyObj(_objCurVi)));

                if (DBHelp.SqlDB.SetData_Rollback(lSqlCmd))  //by ID
                {
                    MessageBox.Show("OpMater Check Record Updated!");
                }
                else
                {
                    MessageBox.Show("OpMater Check Update Database Failed!");
                }
                if (txt_MHcheck.Text.Length > 0 && txt_opcheck.Text.Length > 0 && txt_leadercheck.Text.Length > 0)
                {
                    txtMat1Batch.IsEnabled = false;
                    txtMat2Batch.IsEnabled = false;
                }
            }
            catch (Exception ee)
            {
                System.Windows.MessageBox.Show(ee.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void btnleaderMaterCheck_Click(object sender, RoutedEventArgs e)
        {
            StaticRes.Global._isUsingObjCurVi = true;
            _objCurVi = refreshVidata(StaticRes.Global.CurDay, StaticRes.Global.CurShift, (_objCurVi == null || _objCurVi.partNumber == null ? "" : _objCurVi.partNumber), StaticRes.Global.MachineID);
            if (_objCurVi == null)
            {
                _alertMsg = "Please Submit Correct Part No first!";
                MessageBox.Show(_alertMsg);
            }
            else
            {
                try
                {
                    Views.Login x = new Views.Login();
                    x.HDClick += new Views.Login.HDClickEventHandler(LeaderMater_Check);
                    x.BackClick += new Views.Login.BackMaskEventHandler(CloseMask);
                    x.ShowDialog();
                }
                catch (Exception ee)
                {
                    System.Windows.MessageBox.Show(ee.Message);
                }
            }

            StaticRes.Global._isUsingObjCurVi = false;
        }

        void LeaderMater_Check()
        {
            try
            {
                if (StaticRes.Global.Falg_UserGroup == StaticRes.Global.Department.Leader || StaticRes.Global.Falg_UserGroup == StaticRes.Global.Department.Supervisor || StaticRes.Global.Falg_UserGroup == StaticRes.Global.Department.Admin)
                {
                    DateTime dTime = System.DateTime.Now;
                    _objCurVi.lastUpdatedTime = dTime;
                    _objCurVi.Material_LeaderCheck = StaticRes.Global.Falg_User;
                    _objCurVi.Material_LeaderCheckTime = dTime;
                    this.txt_leadercheck.Text = StaticRes.Global.Falg_User;
                    this.txt_leadercheck.IsEnabled = false;
                    List<System.Data.SqlClient.SqlCommand> lSqlCmd = new List<System.Data.SqlClient.SqlCommand>();

                    Common.BLL.MouldingViTracking_BLL bllVi = new Common.BLL.MouldingViTracking_BLL();
                    lSqlCmd.Add(bllVi.UpdateCommand(_objCurVi));

                    Common.BLL.MouldingViHistory_BLL bllViHis = new Common.BLL.MouldingViHistory_BLL();
                    lSqlCmd.Add(bllViHis.AddCommand(bllViHis.CopyObj(_objCurVi)));

                    if (DBHelp.SqlDB.SetData_Rollback(lSqlCmd))  //by ID
                    {
                        MessageBox.Show("LeaderMater Check Record Updated!");
                    }
                    else
                    {
                        MessageBox.Show("LeaderMater Check Update Database Failed!");
                    }
                    if (txt_MHcheck.Text.Length > 0 && txt_opcheck.Text.Length > 0 && txt_leadercheck.Text.Length > 0)
                    {
                        txtMat1Batch.IsEnabled = false;
                        txtMat2Batch.IsEnabled = false;
                    }
                }
                else
                {
                    MessageBox.Show("You haven't access into it!");
                    return;
                }
            }
            catch (Exception ee)
            {
                System.Windows.MessageBox.Show(ee.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        Common.BLL.MouldingLabel_BLL bllLabel = new Common.BLL.MouldingLabel_BLL();
        Common.Model.MouldingLabel_Model ModLabel = new Common.Model.MouldingLabel_Model();
        private void BtnRejectCheck_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                DateTime dTime = DateTime.Now;
                int iHour = dTime.Hour;
                if (iHour > 12)
                {
                    iHour = iHour - 12;
                }
                switch (iHour)
                {
                    case (1):
                        {
                            txtRejectQty06.Text = (int.Parse(txtRejectQty06.Text.ToString()) + 1).ToString();
                            ModLabel.RejectQTY01 = decimal.Parse(txtRejectQty06.Text);
                            break;
                        }
                    case (2):
                        {
                            txtRejectQty07.Text = (int.Parse(txtRejectQty07.Text.ToString()) + 1).ToString();
                            ModLabel.RejectQTY02 = decimal.Parse(txtRejectQty07.Text);
                            break;
                        }

                    case (3):
                        {
                            txtRejectQty08.Text = (int.Parse(txtRejectQty08.Text.ToString()) + 1).ToString();
                            ModLabel.RejectQTY03 = decimal.Parse(txtRejectQty08.Text);
                            break;
                        }

                    case (4):
                        {
                            txtRejectQty09.Text = (int.Parse(txtRejectQty09.Text.ToString()) + 1).ToString();
                            ModLabel.RejectQTY04 = decimal.Parse(txtRejectQty09.Text);
                            break;
                        }

                    case (5):
                        {
                            txtRejectQty10.Text = (int.Parse(txtRejectQty10.Text.ToString()) + 1).ToString();
                            ModLabel.RejectQTY05 = decimal.Parse(txtRejectQty10.Text);
                            break;
                        }

                    case (6):
                        {
                            txtRejectQty11.Text = (int.Parse(txtRejectQty11.Text.ToString()) + 1).ToString();
                            ModLabel.RejectQTY06 = decimal.Parse(txtRejectQty11.Text);
                            break;
                        }
                    case (7):
                        {
                            txtRejectQty12.Text = (int.Parse(txtRejectQty12.Text.ToString()) + 1).ToString();
                            ModLabel.RejectQTY07 = decimal.Parse(txtRejectQty12.Text);
                            break;
                        }
                    case (8):
                        {
                            txtRejectQty01.Text = (int.Parse(txtRejectQty01.Text.ToString()) + 1).ToString();
                            ModLabel.RejectQTY08 = decimal.Parse(txtRejectQty01.Text);
                            break;
                        }
                    case (9):
                        {
                            txtRejectQty02.Text = (int.Parse(txtRejectQty02.Text.ToString()) + 1).ToString();
                            ModLabel.RejectQTY09 = decimal.Parse(txtRejectQty02.Text);
                            break;
                        }
                    case (10):
                        {
                            txtRejectQty03.Text = (int.Parse(txtRejectQty03.Text.ToString()) + 1).ToString();
                            ModLabel.RejectQTY10 = decimal.Parse(txtRejectQty03.Text);
                            break;
                        }
                    case (11):
                        {
                            txtRejectQty04.Text = (int.Parse(txtRejectQty04.Text.ToString()) + 1).ToString();
                            ModLabel.RejectQTY11 = decimal.Parse(txtRejectQty04.Text);
                            break;
                        }
                    case (12):
                        {
                            txtRejectQty05.Text = (int.Parse(txtRejectQty05.Text.ToString()) + 1).ToString();
                            ModLabel.RejectQTY12 = decimal.Parse(txtRejectQty05.Text);
                            break;
                        }
                    case (0):
                        {
                            txtRejectQty05.Text = (int.Parse(txtRejectQty05.Text.ToString()) + 1).ToString();
                            ModLabel.RejectQTY12 = decimal.Parse(txtRejectQty05.Text);
                            break;
                        }
                }
                bllLabel.Update(ModLabel);
            }
            catch (Exception ee)
            {
                System.Windows.MessageBox.Show(ee.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }


        private void getLable()
        {
            try
            {
                ModLabel = bllLabel.GetModel_ByTrackingID(_objCurVi.trackingID);
                if (ModLabel != null)
                {
                    Label_Name.Text = ModLabel.SerialNo;
                    txtSerialNo01.Text = ModLabel.SerialNo08.ToString();
                    txtSerialNo02.Text = ModLabel.SerialNo09.ToString();
                    txtSerialNo03.Text = ModLabel.SerialNo10.ToString();
                    txtSerialNo04.Text = ModLabel.SerialNo11.ToString();
                    txtSerialNo05.Text = ModLabel.SerialNo12.ToString();
                    txtSerialNo06.Text = ModLabel.SerialNo01.ToString();
                    txtSerialNo07.Text = ModLabel.SerialNo02.ToString();
                    txtSerialNo08.Text = ModLabel.SerialNo03.ToString();
                    txtSerialNo09.Text = ModLabel.SerialNo04.ToString();
                    txtSerialNo10.Text = ModLabel.SerialNo05.ToString();
                    txtSerialNo11.Text = ModLabel.SerialNo06.ToString();
                    txtSerialNo12.Text = ModLabel.SerialNo07.ToString();
                    txtSerialNo13.Text = ModLabel.SerialNoEnd.ToString();
                    txtUsageQty01.Text = ModLabel.UsageQTY08.ToString();
                    txtUsageQty02.Text = ModLabel.UsageQTY09.ToString();
                    txtUsageQty03.Text = ModLabel.UsageQTY10.ToString();
                    txtUsageQty04.Text = ModLabel.UsageQTY11.ToString();
                    txtUsageQty05.Text = ModLabel.UsageQTY12.ToString();
                    txtUsageQty06.Text = ModLabel.UsageQTY01.ToString();
                    txtUsageQty07.Text = ModLabel.UsageQTY02.ToString();
                    txtUsageQty08.Text = ModLabel.UsageQTY03.ToString();
                    txtUsageQty09.Text = ModLabel.UsageQTY04.ToString();
                    txtUsageQty10.Text = ModLabel.UsageQTY05.ToString();
                    txtUsageQty11.Text = ModLabel.UsageQTY06.ToString();
                    txtUsageQty12.Text = ModLabel.UsageQTY07.ToString();
                    txtRejectQty06.Text = ModLabel.RejectQTY01.ToString();
                    txtRejectQty07.Text = ModLabel.RejectQTY02.ToString();
                    txtRejectQty08.Text = ModLabel.RejectQTY03.ToString();
                    txtRejectQty09.Text = ModLabel.RejectQTY04.ToString();
                    txtRejectQty10.Text = ModLabel.RejectQTY05.ToString();
                    txtRejectQty11.Text = ModLabel.RejectQTY06.ToString();
                    txtRejectQty12.Text = ModLabel.RejectQTY07.ToString();
                    txtRejectQty01.Text = ModLabel.RejectQTY08.ToString();
                    txtRejectQty02.Text = ModLabel.RejectQTY09.ToString();
                    txtRejectQty03.Text = ModLabel.RejectQTY10.ToString();
                    txtRejectQty04.Text = ModLabel.RejectQTY11.ToString();
                    txtRejectQty05.Text = ModLabel.RejectQTY12.ToString();
                    txtAcceptQty01.Text = (ModLabel.UsageQTY08 - ModLabel.RejectQTY08).ToString();
                    txtAcceptQty02.Text = (ModLabel.UsageQTY09 - ModLabel.RejectQTY09).ToString();
                    txtAcceptQty03.Text = (ModLabel.UsageQTY10 - ModLabel.RejectQTY10).ToString();
                    txtAcceptQty04.Text = (ModLabel.UsageQTY11 - ModLabel.RejectQTY11).ToString();
                    txtAcceptQty05.Text = (ModLabel.UsageQTY12 - ModLabel.RejectQTY12).ToString();
                    txtAcceptQty06.Text = (ModLabel.UsageQTY01 - ModLabel.RejectQTY01).ToString();
                    txtAcceptQty07.Text = (ModLabel.UsageQTY02 - ModLabel.RejectQTY02).ToString();
                    txtAcceptQty08.Text = (ModLabel.UsageQTY03 - ModLabel.RejectQTY03).ToString();
                    txtAcceptQty09.Text = (ModLabel.UsageQTY04 - ModLabel.RejectQTY04).ToString();
                    txtAcceptQty10.Text = (ModLabel.UsageQTY05 - ModLabel.RejectQTY05).ToString();
                    txtAcceptQty11.Text = (ModLabel.UsageQTY06 - ModLabel.RejectQTY06).ToString();
                    txtAcceptQty12.Text = (ModLabel.UsageQTY07 - ModLabel.RejectQTY07).ToString();
                }
                else
                {
                    Label_Name.Text = "";
                    txtSerialNo01.Text = "0";
                    txtSerialNo02.Text = "0";
                    txtSerialNo03.Text = "0";
                    txtSerialNo04.Text = "0";
                    txtSerialNo05.Text = "0";
                    txtSerialNo06.Text = "0";
                    txtSerialNo07.Text = "0";
                    txtSerialNo08.Text = "0";
                    txtSerialNo09.Text = "0";
                    txtSerialNo10.Text = "0";
                    txtSerialNo11.Text = "0";
                    txtSerialNo12.Text = "0";
                    txtSerialNo13.Text = "0";
                    txtUsageQty01.Text = "0";
                    txtUsageQty02.Text = "0";
                    txtUsageQty03.Text = "0";
                    txtUsageQty04.Text = "0";
                    txtUsageQty05.Text = "0";
                    txtUsageQty06.Text = "0";
                    txtUsageQty07.Text = "0";
                    txtUsageQty08.Text = "0";
                    txtUsageQty09.Text = "0";
                    txtUsageQty10.Text = "0";
                    txtUsageQty11.Text = "0";
                    txtUsageQty12.Text = "0";
                    txtRejectQty06.Text = "0";
                    txtRejectQty07.Text = "0";
                    txtRejectQty08.Text = "0";
                    txtRejectQty09.Text = "0";
                    txtRejectQty10.Text = "0";
                    txtRejectQty11.Text = "0";
                    txtRejectQty12.Text = "0";
                    txtRejectQty01.Text = "0";
                    txtRejectQty02.Text = "0";
                    txtRejectQty03.Text = "0";
                    txtRejectQty04.Text = "0";
                    txtRejectQty05.Text = "0";
                    txtAcceptQty01.Text = "0";
                    txtAcceptQty02.Text = "0";
                    txtAcceptQty03.Text = "0";
                    txtAcceptQty04.Text = "0";
                    txtAcceptQty05.Text = "0";
                    txtAcceptQty06.Text = "0";
                    txtAcceptQty07.Text = "0";
                    txtAcceptQty08.Text = "0";
                    txtAcceptQty09.Text = "0";
                    txtAcceptQty10.Text = "0";
                    txtAcceptQty11.Text = "0";
                    txtAcceptQty12.Text = "0";
                }
            }
            catch (Exception ee)
            {
                System.Windows.MessageBox.Show(ee.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }


        private void btnComfireCheck_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (bllLabel.ExistsbytrackingID(_objCurVi.trackingID))
                {
                    if (int.Parse(txtSerialNo01.Text) != 0)
                    {
                        ModLabel.SerialNo08 = decimal.Parse(txtSerialNo01.Text);
                    }
                    if (int.Parse(txtSerialNo02.Text) != 0)
                    {
                        ModLabel.SerialNo09 = decimal.Parse(txtSerialNo02.Text);
                        ModLabel.UsageQTY08 = decimal.Parse(txtSerialNo02.Text) - decimal.Parse(txtSerialNo01.Text);
                        decimal? accepty08 = ModLabel.UsageQTY08 - decimal.Parse(txtRejectQty01.Text);
                        txtUsageQty01.Text = ModLabel.UsageQTY08.ToString();
                        txtAcceptQty01.Text = accepty08.ToString();
                    }
                    if (int.Parse(txtSerialNo03.Text) != 0)
                    {
                        ModLabel.SerialNo10 = decimal.Parse(txtSerialNo03.Text);
                        ModLabel.UsageQTY09 = decimal.Parse(txtSerialNo03.Text) - decimal.Parse(txtSerialNo02.Text);
                        decimal? accepty09 = ModLabel.UsageQTY09 - decimal.Parse(txtRejectQty02.Text);
                        txtUsageQty02.Text = ModLabel.UsageQTY09.ToString();
                        txtAcceptQty02.Text = accepty09.ToString();
                    }
                    if (int.Parse(txtSerialNo04.Text) != 0)
                    {
                        ModLabel.SerialNo11 = decimal.Parse(txtSerialNo04.Text);
                        ModLabel.UsageQTY10 = decimal.Parse(txtSerialNo04.Text) - decimal.Parse(txtSerialNo03.Text);
                        decimal? accepty10 = ModLabel.UsageQTY10 - decimal.Parse(txtRejectQty03.Text);
                        txtUsageQty03.Text = ModLabel.UsageQTY10.ToString();
                        txtAcceptQty03.Text = accepty10.ToString();
                    }
                    if (int.Parse(txtSerialNo05.Text) != 0)
                    {
                        ModLabel.SerialNo12 = decimal.Parse(txtSerialNo05.Text);
                        ModLabel.UsageQTY11 = decimal.Parse(txtSerialNo05.Text) - decimal.Parse(txtSerialNo04.Text);
                        decimal? accepty11 = ModLabel.UsageQTY11 - decimal.Parse(txtRejectQty04.Text);
                        txtUsageQty04.Text = ModLabel.UsageQTY11.ToString();
                        txtAcceptQty04.Text = accepty11.ToString();
                    }
                    if (int.Parse(txtSerialNo06.Text) != 0)
                    {
                        ModLabel.SerialNo01 = decimal.Parse(txtSerialNo06.Text);
                        ModLabel.UsageQTY12 = decimal.Parse(txtSerialNo06.Text) - decimal.Parse(txtSerialNo05.Text);
                        decimal? accepty12 = ModLabel.UsageQTY12 - decimal.Parse(txtRejectQty05.Text);
                        txtUsageQty05.Text = ModLabel.UsageQTY12.ToString();
                        txtAcceptQty05.Text = accepty12.ToString();
                    }
                    if (int.Parse(txtSerialNo07.Text) != 0)
                    {
                        ModLabel.SerialNo02 = decimal.Parse(txtSerialNo07.Text);
                        ModLabel.UsageQTY01 = decimal.Parse(txtSerialNo07.Text) - decimal.Parse(txtSerialNo06.Text);
                        decimal? accepty01 = ModLabel.UsageQTY01 - decimal.Parse(txtRejectQty06.Text);
                        txtUsageQty06.Text = ModLabel.UsageQTY01.ToString();
                        txtAcceptQty06.Text = accepty01.ToString();
                    }
                    if (int.Parse(txtSerialNo08.Text) != 0)
                    {
                        ModLabel.SerialNo03 = decimal.Parse(txtSerialNo08.Text);
                        ModLabel.UsageQTY02 = decimal.Parse(txtSerialNo08.Text) - decimal.Parse(txtSerialNo07.Text);
                        decimal? accepty02 = ModLabel.UsageQTY02 - decimal.Parse(txtRejectQty07.Text);
                        txtUsageQty07.Text = ModLabel.UsageQTY02.ToString();
                        txtAcceptQty07.Text = accepty02.ToString();
                    }
                    if (int.Parse(txtSerialNo09.Text) != 0)
                    {
                        ModLabel.SerialNo04 = decimal.Parse(txtSerialNo09.Text);
                        ModLabel.UsageQTY03 = decimal.Parse(txtSerialNo09.Text) - decimal.Parse(txtSerialNo08.Text);
                        decimal? accepty03 = ModLabel.UsageQTY03 - decimal.Parse(txtRejectQty08.Text);
                        txtUsageQty08.Text = ModLabel.UsageQTY03.ToString();
                        txtAcceptQty08.Text = accepty03.ToString();
                    }
                    if (int.Parse(txtSerialNo10.Text) != 0)
                    {
                        ModLabel.SerialNo05 = decimal.Parse(txtSerialNo10.Text);
                        ModLabel.UsageQTY04 = decimal.Parse(txtSerialNo10.Text) - decimal.Parse(txtSerialNo09.Text);
                        decimal? accepty04 = ModLabel.UsageQTY04 - decimal.Parse(txtRejectQty09.Text);
                        txtUsageQty09.Text = ModLabel.UsageQTY04.ToString();
                        txtAcceptQty09.Text = accepty04.ToString();
                    }
                    if (int.Parse(txtSerialNo11.Text) != 0)
                    {
                        ModLabel.SerialNo06 = decimal.Parse(txtSerialNo11.Text);
                        ModLabel.UsageQTY05 = decimal.Parse(txtSerialNo11.Text) - decimal.Parse(txtSerialNo10.Text);
                        decimal? accepty05 = ModLabel.UsageQTY05 - decimal.Parse(txtRejectQty10.Text);
                        txtUsageQty10.Text = ModLabel.UsageQTY05.ToString();
                        txtAcceptQty10.Text = accepty05.ToString();
                    }
                    if (int.Parse(txtSerialNo12.Text) != 0)
                    {
                        ModLabel.SerialNo07 = decimal.Parse(txtSerialNo12.Text);
                        ModLabel.UsageQTY06 = decimal.Parse(txtSerialNo12.Text) - decimal.Parse(txtSerialNo11.Text);
                        decimal? accepty06 = ModLabel.UsageQTY06 - decimal.Parse(txtRejectQty11.Text);
                        txtUsageQty11.Text = ModLabel.UsageQTY06.ToString();
                        txtAcceptQty11.Text = accepty06.ToString();
                    }
                    if (int.Parse(txtSerialNo13.Text) != 0)
                    {
                        ModLabel.SerialNoEnd = decimal.Parse(txtSerialNo13.Text);
                        ModLabel.UsageQTY07 = decimal.Parse(txtSerialNo13.Text) - decimal.Parse(txtSerialNo12.Text);
                        decimal? accepty07 = ModLabel.UsageQTY07 - decimal.Parse(txtRejectQty12.Text);
                        txtUsageQty12.Text = ModLabel.UsageQTY07.ToString();
                        txtAcceptQty12.Text = accepty07.ToString();
                    }
                    bllLabel.Update(ModLabel);
                }
                else
                {
                    ModLabel = new Common.Model.MouldingLabel_Model();
                    ModLabel.trackingID = _objCurVi.trackingID;
                    ModLabel.machineID = this.txtUserName_Copy.Content.ToString();
                    ModLabel.SerialNo = Label_Name.Text.ToString();
                    bllLabel.Add(ModLabel);
                }
            }
            catch (Exception ee)
            {
                System.Windows.MessageBox.Show(ee.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void btnMHCheckWeight_Click(object sender, RoutedEventArgs e)
        {
            StaticRes.Global._isUsingObjCurVi = true;
            _objCurVi = refreshVidata(StaticRes.Global.CurDay, StaticRes.Global.CurShift, (_objCurVi == null || _objCurVi.partNumber == null ? "" : _objCurVi.partNumber), StaticRes.Global.MachineID);
            if (_objCurVi == null)
            {
                _alertMsg = "Please Submit Correct Part No first!";
                MessageBox.Show(_alertMsg);
            }
            else
            {
                if (this.txt_Lot1check.Text.Length > 0 || this.txt_Lot2check.Text.Length > 0)
                {
                    try
                    {
                        Views.Login x = new Views.Login();
                        x.HDClick += new Views.Login.HDClickEventHandler(WeightPut);
                        x.BackClick += new Views.Login.BackMaskEventHandler(CloseMask);
                        x.ShowDialog();
                    }
                    catch (Exception ee)
                    {
                        System.Windows.MessageBox.Show(ee.Message);
                    }
                }
                else
                {
                    MessageBox.Show("Please input each material weight");
                }
            }

            StaticRes.Global._isUsingObjCurVi = false;
        }

        void WeightPut()
        {
            try
            {
                if (StaticRes.Global.Falg_UserGroup == StaticRes.Global.Department.MH || 
                    StaticRes.Global.Falg_UserGroup == StaticRes.Global.Department.Supervisor || 
                    StaticRes.Global.Falg_UserGroup == StaticRes.Global.Department.Admin)
                {
                    DateTime dTime = System.DateTime.Now;
                    _objCurVi.lastUpdatedTime = dTime;
                    _objCurVi.partsWeight = _objCurVi.partsWeight + decimal.Parse(this.txt_Lot1check.Text);
                    _objCurVi.parts2Weight = _objCurVi.parts2Weight + decimal.Parse(this.txt_Lot2check.Text);

                    List<System.Data.SqlClient.SqlCommand> lSqlCmd = new List<System.Data.SqlClient.SqlCommand>();

                    Common.BLL.MouldingViTracking_BLL bllVi = new Common.BLL.MouldingViTracking_BLL();
                    lSqlCmd.Add(bllVi.UpdateCommand(_objCurVi));

                    Common.BLL.MouldingViHistory_BLL bllViHis = new Common.BLL.MouldingViHistory_BLL();
                    lSqlCmd.Add(bllViHis.AddCommand(bllViHis.CopyObj(_objCurVi)));

                    if (DBHelp.SqlDB.SetData_Rollback(lSqlCmd))  //by ID
                    {
                        MessageBox.Show("Material weight add successful!");
                        this.txt_Lot1check.Text = "";
                        this.txt_Lot2check.Text = "";
                        this.lblMaterialWeight.Foreground = new SolidColorBrush(Colors.DarkBlue);
                        this.lblMaterialWeight.Content = "1st : " + (_objCurVi.partsWeight.ToString() == null ? "0" : _objCurVi.partsWeight.ToString())
                             + " 2nd : " + (_objCurVi.parts2Weight.ToString() == null ? "0" : _objCurVi.parts2Weight.ToString());
                    }
                    else
                    {
                        MessageBox.Show("Material weight add  Failed!");
                    }
                }
                else
                {
                    MessageBox.Show("You haven't access into it!");
                    return;
                }
            }
            catch (Exception ee)
            {
                System.Windows.MessageBox.Show(ee.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void btnAck_Click(object sender, RoutedEventArgs e)
        {
            remindOff();
        }

        private void remindOff()
        {
            _EventTime = System.DateTime.Now;
            this.spNewRequestRemind.Visibility = Visibility.Collapsed;
            this.btnAck.Visibility = Visibility.Collapsed;
            this.lblNewRequestRemind.Visibility = Visibility.Collapsed;
        }

        private void remindOn(bool sStatus)
        {
            this.spNewRequestRemind.Visibility = Visibility.Visible;
            this.btnAck.Visibility = Visibility.Visible;
            this.lblNewRequestRemind.Visibility = Visibility.Visible;
            
            if (sStatus)
            {
                //this.lblNewRequestRemind.Content = "These has new Alarm! Please Check!";
                this.lblNewRequestRemind.Content = "Mould Life End!";
            }
            else
            {
                //this.lblNewRequestRemind.Content = "Model Charst need clean! Please Check!";
                this.lblNewRequestRemind.Content = "Mould Needs To Do Maintenance!";
            }
        }

        private void btnEnd_Click(object sender, RoutedEventArgs e)
        {
            StaticRes.Global._isUsingObjCurVi = true;
            _objCurVi = refreshVidata(StaticRes.Global.CurDay, StaticRes.Global.CurShift, (_objCurVi == null || _objCurVi.partNumber == null ? "" : _objCurVi.partNumber), StaticRes.Global.MachineID);
            if (_objCurVi == null)
            {
                _alertMsg = "Please Submit Correct Part No first!";
                MessageBox.Show(_alertMsg);
            }
            else
            {

                Common.Model.MouldingMoldLife modellife = new Common.Model.MouldingMoldLife();
                Common.BLL.MouldingMoldLife_BLL blllife = new Common.BLL.MouldingMoldLife_BLL();
                if (!MouldCharst(cbxPartNo.SelectedValue.ToString()))
                {
                    modellife = blllife.GetModel(cbxPartNo.SelectedValue.ToString());
                    if (modellife.PartNumberAll != null)
                    {
                        if (modellife.Clean1Qty > StaticRes.Global.CleanQty)
                        {
                            MessageBox.Show("" + cbxPartNo.SelectedValue.ToString() + "This Model Charst need clean!");
                            DBHelp.Reports.LogFile.DebugLog("ModelCharst", "btnSubmit_Click", "Visuallnspection this Model Charst need clean :", "", cbxPartNo.SelectedValue.ToString() + "Shots is :" + modellife.Clean1Qty.ToString());
                        }
                    }
                }
                else
                {
                    string sMold = cbxPartNo.SelectedValue.ToString().Substring(0, cbxPartNo.SelectedValue.ToString().LastIndexOf(' '));
                    modellife = blllife.GetModel(sMold);
                    if (modellife.PartNumberAll != null)
                    {
                        if (modellife.Clean1Qty > StaticRes.Global.CleanQty)
                        {
                            MessageBox.Show("" + cbxPartNo.SelectedValue.ToString() + "This Model Charst need clean!");
                            DBHelp.Reports.LogFile.DebugLog("ModelCharst", "btnSubmit_Click", "Visuallnspection this Model Charst need clean :", "", cbxPartNo.SelectedValue.ToString() + "Shots is :" + modellife.Clean1Qty.ToString());
                        }
                    }
                }
                DateTime dTime = DateTime.Now;
                //_objCurVi.status = "End";
                _objCurVi.stopTime = dTime;
                List<System.Data.SqlClient.SqlCommand> lSqlCmd = new List<System.Data.SqlClient.SqlCommand>();

                Common.BLL.MouldingViTracking_BLL bllVi = new Common.BLL.MouldingViTracking_BLL();
                lSqlCmd.Add(bllVi.UpdateCommand(_objCurVi));

                Common.BLL.MouldingViHistory_BLL bllViHis = new Common.BLL.MouldingViHistory_BLL();
                lSqlCmd.Add(bllViHis.AddCommand(bllViHis.CopyObj(_objCurVi)));
                if (DBHelp.SqlDB.SetData_Rollback(lSqlCmd))  //by ID
                {
                    MessageBox.Show(" Successful!");
                }
                else
                {
                    MessageBox.Show(" Failed!");
                }
                LoginOut();
        

                this.btnSubmit.IsEnabled = true;
                if (StaticRes.Global.MachineID != "8")
                {
                    _Number = 0;
                }
                else
                {
                    _Number = 1;
                }
                iniTabControl();

                tbkCavityCount.Text = "";
                tbkCycleTime.Text = "";
                tbkJigNo.Text = "";
                tbkTargetQty.Text = "";
                tbkFailQty.Text = "";
                tbkTotalQty.Text = "";
                tbkPassQty.Text = "";
                tbkQCFailQty.Text = "";
                txt_opcheck.Text = "";
                txt_MHcheck.Text = "";
                txt_leadercheck.Text = "";
                _objCurVi = null;
                setMajorInfo(false);
                SetStatusButton();
                StaticRes.Global._isUsingObjCurVi = false;
            }
        }

      
        private void btnSignIn_Copy_Click(object sender, RoutedEventArgs e)
        {
            if(UserIDnPasswordValidationlabel())
            {
                this.Reject_Label.IsEnabled = true;
                this.Comfire.IsEnabled = true;
            }
            else
            {

            }
        }

        private void btnSignOut_Copy_Click(object sender, RoutedEventArgs e)
        {
            this.txtUserID_Copy.Text = "";
            this.txtPassword_Copy.Password = "";
            this.txtUserName_Copy.Content = "";
            this.Reject_Label.IsEnabled = false;
            this.Comfire.IsEnabled = false;
        }

        private bool UserIDnPasswordValidationlabel()
        {
            Common.Model.User_DB_Model CUser = new User_DB_Model();
            Common.BLL.User_DB_BLL _CuserManagement_BLL = new Common.BLL.User_DB_BLL();
            CUser = _CuserManagement_BLL.Validate_User(this.txtUserID_Copy.Text, this.txtPassword_Copy.Password);
            if (CUser == null)
            {
                return false;
            }
            else
            {
                this.txtUserName_Copy.Content = CUser.userName;
                return true;
            }
        }

        
    }
}

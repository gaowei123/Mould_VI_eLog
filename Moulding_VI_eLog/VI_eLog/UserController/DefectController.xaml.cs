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

namespace VI_eLog.UserController
{
    /// <summary>
    /// UserControl1.xaml 的交互逻辑
    /// </summary>
    public partial class DefectController : UserControl
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
        private event HDClickEventHandler EventSuccessful;
        public event HDClickEventHandler HDClick
        {
            add
            {
                EventSuccessful += value;
            }
            remove
            {
                EventSuccessful -= value;
            }
        }
        #endregion

        #region "Property"
        private Common.Model.MouldingViDefectTracking_Model _viDefect = new Common.Model.MouldingViDefectTracking_Model();
        public Common.Model.MouldingViDefectTracking_Model ViDefect
        {
            get
            { return _viDefect; }
            set
            {
                _viDefect = value;
            }
        }

        #region Hourly Header
        private Brush _hourlyHeaderBgColor;
        public Brush HourlyHeaderBgColor
        {
            get
            { return _hourlyHeaderBgColor; }
            set {
                _hourlyHeaderBgColor = value;
                this.lbl01.Background = value;
                this.lbl02.Background = value;
                this.lbl03.Background = value;
                this.lbl04.Background = value;
                this.lbl05.Background = value;
                this.lbl06.Background = value;
                this.lbl07.Background = value;
                this.lbl08.Background = value;
                this.lbl09.Background = value;
                this.lbl10.Background = value;
                this.lbl11.Background = value;
                this.lbl12.Background = value; 
            }
        }

        private Brush _hourlyHeaderFontColor;
        public Brush HourlyHeaderFontColor
        {
            get
            { return _hourlyHeaderFontColor; }
            set
            {
                _hourlyHeaderFontColor = value;
                this.lbl01.Foreground = value;
                this.lbl02.Foreground = value;
                this.lbl03.Foreground = value;
                this.lbl04.Foreground = value;
                this.lbl05.Foreground = value;
                this.lbl06.Foreground = value;
                this.lbl07.Foreground = value;
                this.lbl08.Foreground = value;
                this.lbl09.Foreground = value;
                this.lbl10.Foreground = value;
                this.lbl11.Foreground = value;
                this.lbl12.Foreground = value;
            }
        }

        private double _hourlyHeaderFontSize;
        public double HourlyHeaderFontSize
        {
            get
            { return _hourlyHeaderFontSize; }
            set
            {
                _hourlyHeaderFontSize = value;
                this.lbl01.FontSize = value;
                this.lbl02.FontSize = value;
                this.lbl03.FontSize = value;
                this.lbl04.FontSize = value;
                this.lbl05.FontSize = value;
                this.lbl06.FontSize = value;
                this.lbl07.FontSize = value;
                this.lbl08.FontSize = value;
                this.lbl09.FontSize = value;
                this.lbl10.FontSize = value;
                this.lbl11.FontSize = value;
                this.lbl12.FontSize = value;
            }
        }
        #endregion

        #region Hourly QTY
        private Brush _hourlyQtyBgColor;
        public Brush HourlyQtyBgColor
        {
            get
            { return _hourlyQtyBgColor; }
            set
            {
                _hourlyQtyBgColor = value;
                this.txtQty01.Background = value;
                this.txtQty02.Background = value;
                this.txtQty03.Background = value;
                this.txtQty04.Background = value;
                this.txtQty05.Background = value;
                this.txtQty06.Background = value;
                this.txtQty07.Background = value;
                this.txtQty08.Background = value;
                this.txtQty09.Background = value;
                this.txtQty10.Background = value;
                this.txtQty11.Background = value;
                this.txtQty12.Background = value;
            }
        }

        private Brush _hourlyQtyFontColor;
        public Brush HourlyQtyFontColor
        {
            get
            { return _hourlyQtyFontColor; }
            set
            {
                _hourlyQtyFontColor = value;
                this.txtQty01.Foreground = value;
                this.txtQty02.Foreground = value;
                this.txtQty03.Foreground = value;
                this.txtQty04.Foreground = value;
                this.txtQty05.Foreground = value;
                this.txtQty06.Foreground = value;
                this.txtQty07.Foreground = value;
                this.txtQty08.Foreground = value;
                this.txtQty09.Foreground = value;
                this.txtQty10.Foreground = value;
                this.txtQty11.Foreground = value;
                this.txtQty12.Foreground = value;
            }
        }

        private double _hourlyQtyFontSize;
        public double HourlyQtyFontSize
        {
            get
            { return _hourlyQtyFontSize; }
            set
            {
                _hourlyQtyFontSize = value;
                this.txtQty01.FontSize = value;
                this.txtQty02.FontSize = value;
                this.txtQty03.FontSize = value;
                this.txtQty04.FontSize = value;
                this.txtQty05.FontSize = value;
                this.txtQty06.FontSize = value;
                this.txtQty07.FontSize = value;
                this.txtQty08.FontSize = value;
                this.txtQty09.FontSize = value;
                this.txtQty10.FontSize = value;
                this.txtQty11.FontSize = value;
                this.txtQty12.FontSize = value;
            }
        }


        private int _defectQTY01;
        public int DefectQTY01
        {
            get
            { return _defectQTY01; }
            set
            {
                _defectQTY01 = value;
                this.txtQty01.Text = value.ToString();

            }
        }

        private int _defectQTY02;
        public int DefectQTY02
        {
            get
            { return _defectQTY02; }
            set
            {
                _defectQTY02 = value;
                this.txtQty02.Text = value.ToString();
            }
        }

        private int _defectQTY03;
        public int DefectQTY03
        {
            get
            { return _defectQTY03; }
            set
            {
                _defectQTY03 = value;
                this.txtQty03.Text = value.ToString();
            }
        }

        private int _defectQTY04;
        public int DefectQTY04
        {
            get
            { return _defectQTY04; }
            set
            {
                _defectQTY04 = value;
                this.txtQty04.Text = value.ToString();
            }
        }

        private int _defectQTY05;
        public int DefectQTY05
        {
            get
            { return _defectQTY05; }
            set
            {
                _defectQTY05 = value;
                this.txtQty05.Text = value.ToString();
            }
        }

        private int _defectQTY06;
        public int DefectQTY06
        {
            get
            { return _defectQTY06; }
            set
            {
                _defectQTY06 = value;
                this.txtQty06.Text = value.ToString();
            }
        }

        private int _defectQTY07;
        public int DefectQTY07
        {
            get
            { return _defectQTY07; }
            set
            {
                _defectQTY07 = value;
                this.txtQty07.Text = value.ToString();
            }
        }

        private int _defectQTY08;
        public int DefectQTY08
        {
            get
            { return _defectQTY08; }
            set
            {
                _defectQTY08 = value;
                this.txtQty08.Text = value.ToString();
            }
        }

        private int _defectQTY09;
        public int DefectQTY09
        {
            get
            { return _defectQTY09; }
            set
            {
                _defectQTY09 = value;
                this.txtQty09.Text = value.ToString();
            }
        }
        private int _defectQTY10;
        public int DefectQTY10
        {
            get
            { return _defectQTY10; }
            set
            {
                _defectQTY10 = value;
                this.txtQty10.Text = value.ToString();
            }
        }
        private int _defectQTY11;
        public int DefectQTY11
        {
            get
            { return _defectQTY11; }
            set
            {
                _defectQTY11 = value;
                this.txtQty11.Text = value.ToString();
            }
        }
        private int _defectQTY12;
        public int DefectQTY12
        {
            get
            { return _defectQTY12; }
            set
            {
                _defectQTY12 = value;
                this.txtQty12.Text = value.ToString();
            }
        }

        private int _Count;
        public int Count
        {
            get
            { return _Count; }
            set
            {
                _Count = 0;
            }
        }
        #endregion

        #region Defect Button
        private Brush _defectButtonBgColor;
        public Brush DefectButtonBgColor
        {
            get
            { return _defectButtonBgColor; }
            set
            {
                _defectButtonBgColor = value;
                this.btnDefectCode.Background = value;
            }
        }

        private Brush _defectButtonFontColor;
        public Brush DefectButtonFontColor
        {
            get
            { return _defectButtonFontColor; }
            set
            {
                _defectButtonFontColor = value;
                this.btnDefectCode.Foreground = value;
            }
        }

        private double _defectButtonFontSize;
        public double DefectButtonFontSize
        { 
            get
            { return _defectButtonFontSize; }
            set { _defectButtonFontSize = value;
                this.btnDefectCode.FontSize = value; 
            }
        }

        private string _defectButtonText;
        public string DefectButtonText
        {
            get
            { return _defectButtonText; }
            set
            {
                _defectButtonText = value;
                this.btnDefectCode.Content  = value;
            }
        }
        #endregion

        #region Total QTY
        private Brush _totalQtyBgColor;
        public Brush TotalQtyBgColor
        {
            get
            { return _totalQtyBgColor; }
            set
            {
                _totalQtyBgColor = value;
                this.txtDefectQty.Background = value;
            }
        }

        private Brush _totalQtyFontColor;
        public Brush TotalQtyFontColor
        {
            get
            { return _totalQtyFontColor; }
            set
            {
                _totalQtyFontColor = value;
                this.txtDefectQty.Foreground = value;
            }
        }

        private double _totalQtyFontSize;
        public double TotalQtyFontSize
        {
            get
            { return _totalQtyFontSize; }
            set
            {
                _totalQtyFontSize = value;
                this.txtDefectQty.FontSize = value;
            }
        }

        private int _totalDefectQTY;
        public int TotalDefectQTY
        {
            get
            { return _totalDefectQTY; }
            set
            {
                _totalDefectQTY = value;
                this.txtDefectQty.Text = value.ToString();
            }
        }
        #endregion

        #endregion  

        public DefectController()
        {
            InitializeComponent();
        }

        private void btnDefectCode_Click(object sender, RoutedEventArgs e)
        {
            DateTime dtime = DateTime.Now;
            try
            {
                StaticRes.Global._isUsingObjCurVi = true;
                //update TotalQTY & Controller
                //_totalDefectQTY++;
                this.txtDefectQty.Text = (decimal.Parse(this.txtDefectQty.Text)+1).ToString();
                //this.txtDefectQty.Text = _totalDefectQTY.ToString();
                //_viDefect.rejectQty = decimal.Parse( _totalDefectQTY.ToString());
                _viDefect.rejectQty = decimal.Parse(this.txtDefectQty.Text.ToString());
                //update hourlyQTY & Controller
                int iHour = dtime.Hour;
                if (iHour>12 )
                {
                    iHour = iHour - 12;
                }
                AddOneCount_Hourly(iHour);

                //update database
                UpdateDatabase(  _viDefect);
            }
            catch (Exception ex)
            {
                StaticRes.Global._isUsingObjCurVi = false;
                throw;
            }

            EventSuccessful();

        }

        public bool ReduceOneCount_Hourly(int iHour)
        {
            #region updateController
            bool result = false;
            switch (iHour)
            {
                case (1):
                    {
                        if (_defectQTY01 != 0)
                        {
                            _defectQTY01--;
                            txtQty01.Text = _defectQTY01.ToString();
                            _viDefect.rejectQtyHour01 = _defectQTY01.ToString();
                            _Count--;
                            result = true;
                        }
                        else if(_defectQTY12 > 0)
                        {
                            _defectQTY12--;
                            txtQty12.Text = _defectQTY12.ToString();
                            _viDefect.rejectQtyHour12 = _defectQTY12.ToString();
                            _Count--;
                            result = true;
                        }
                        break;
                    }
                case (2):
                    {
                        if (_defectQTY02 != 0)
                        {
                            _defectQTY02--;
                            txtQty02.Text = _defectQTY02.ToString();
                            _viDefect.rejectQtyHour02 = _defectQTY02.ToString();
                            _Count--;
                            result = true;
                        }
                        else if(_defectQTY01 > 0)
                        {
                            _defectQTY01--;
                            txtQty01.Text = _defectQTY01.ToString();
                            _viDefect.rejectQtyHour01 = _defectQTY01.ToString();
                            _Count--;
                            result = true;
                        }
                        break;
                    }

                case (3):
                    {
                        if (_defectQTY03 != 0)
                        {
                            _defectQTY03--;
                            txtQty03.Text = _defectQTY03.ToString();
                            _viDefect.rejectQtyHour03 = _defectQTY03.ToString();
                            _Count--;
                            result = true;
                        }
                        else if(_defectQTY02 > 0)
                        {
                            _defectQTY02--;
                            txtQty02.Text = _defectQTY02.ToString();
                            _viDefect.rejectQtyHour02 = _defectQTY02.ToString();
                            _Count--;
                            result = true;
                        }
                        break;
                    }

                case (4):
                    {
                        if (_defectQTY04 != 0)
                        {
                            _defectQTY04--;
                            txtQty04.Text = _defectQTY04.ToString();
                            _viDefect.rejectQtyHour04 = _defectQTY04.ToString();
                            _Count--;
                            result = true;
                        }
                        else if(_defectQTY03 > 0)
                        {
                            _defectQTY03--;
                            txtQty03.Text = _defectQTY03.ToString();
                            _viDefect.rejectQtyHour03 = _defectQTY03.ToString();
                            _Count--;
                            result = true;
                        }
                        break;
                    }

                case (5):
                    {
                        if (_defectQTY05 != 0)
                        {
                            _defectQTY05--;
                            txtQty05.Text = _defectQTY05.ToString();
                            _viDefect.rejectQtyHour05 = _defectQTY05.ToString();
                            _Count--;
                            result = true;
                        }
                        else if (_defectQTY04 > 0)
                        {
                            _defectQTY04--;
                            txtQty04.Text = _defectQTY04.ToString();
                            _viDefect.rejectQtyHour04 = _defectQTY04.ToString();
                            _Count--;
                            result = true;
                        }
                        break;
                    }

                case (6):
                    {
                        if (_defectQTY06 != 0)
                        {
                            _defectQTY06--;
                            txtQty06.Text = _defectQTY06.ToString();
                            _viDefect.rejectQtyHour06 = _defectQTY06.ToString();
                            _Count--;
                            result = true;
                        }
                        else if (_defectQTY05 > 0)
                        {
                            _defectQTY05--;
                            txtQty05.Text = _defectQTY05.ToString();
                            _viDefect.rejectQtyHour05 = _defectQTY05.ToString();
                            _Count--;
                            result = true;
                        }
                        break;
                    }
                case (7):
                    {
                        if (_defectQTY07 != 0)
                        {
                            _defectQTY07--;
                            txtQty07.Text = _defectQTY07.ToString();
                            _viDefect.rejectQtyHour07 = _defectQTY07.ToString();
                            _Count--;
                            result = true;
                        }
                        else if(_defectQTY06 > 0)
                        {
                            _defectQTY06--;
                            txtQty06.Text = _defectQTY06.ToString();
                            _viDefect.rejectQtyHour06 = _defectQTY06.ToString();
                            _Count--;
                            result = true;
                        }
                        break;
                    }
                case (8):
                    {
                        if (_defectQTY08 != 0)
                        {
                            _defectQTY08--;
                            txtQty08.Text = _defectQTY08.ToString();
                            _viDefect.rejectQtyHour08 = _defectQTY08.ToString();
                            _Count--;
                            result = true;
                        }
                        else if(_defectQTY07 > 0)
                        {
                            _defectQTY07--;
                            txtQty07.Text = _defectQTY07.ToString();
                            _viDefect.rejectQtyHour07 = _defectQTY07.ToString();
                            _Count--;
                            result = true;
                        }
                        break;
                    }
                case (9):
                    {
                        if (_defectQTY09 != 0)
                        {
                            _defectQTY09--;
                            txtQty09.Text = _defectQTY09.ToString();
                            _viDefect.rejectQtyHour09 = _defectQTY09.ToString();
                            _Count--;
                            result = true;
                        }
                        else if(_defectQTY07 > 0)
                        {
                            _defectQTY08--;
                            txtQty08.Text = _defectQTY08.ToString();
                            _viDefect.rejectQtyHour08 = _defectQTY08.ToString();
                            _Count--;
                            result = true;
                        }
                        break;
                    }
                case (10):
                    {
                        if (_defectQTY10 != 0)
                        {
                            _defectQTY10--;
                            txtQty10.Text = _defectQTY10.ToString();
                            _viDefect.rejectQtyHour10 = _defectQTY10.ToString();
                            _Count--;
                            result = true;
                        }
                        else if (_defectQTY09 > 0)
                        {
                            _defectQTY09--;
                            txtQty09.Text = _defectQTY09.ToString();
                            _viDefect.rejectQtyHour09 = _defectQTY09.ToString();
                            _Count--;
                            result = true;
                        }
                        break;
                    }
                case (11):
                    {
                        if (_defectQTY11 != 0)
                        {
                            _defectQTY11--;
                            txtQty11.Text = _defectQTY11.ToString();
                            _viDefect.rejectQtyHour11 = _defectQTY11.ToString();
                            _Count--;
                            result = true;
                        }
                        else if(_defectQTY10 > 0)
                        {
                            _defectQTY10--;
                            txtQty10.Text = _defectQTY10.ToString();
                            _viDefect.rejectQtyHour10 = _defectQTY10.ToString();
                            _Count--;
                            result = true;
                        }
                        break;
                    }
                case (12):
                    {
                        if (_defectQTY12 != 0)
                        {
                            _defectQTY12--;
                            txtQty12.Text = _defectQTY12.ToString();
                            _viDefect.rejectQtyHour12 = _defectQTY12.ToString();
                            _Count--;
                            result = true;
                        }
                        else if (_defectQTY11 > 0)
                        {
                            _defectQTY11--;
                            txtQty11.Text = _defectQTY11.ToString();
                            _viDefect.rejectQtyHour11 = _defectQTY11.ToString();
                            _Count--;
                            result = true;
                        }
                        break;
                    }
            }
            return result;
            #endregion 
        }

        public void AddOneCount_Hourly(int iHour)
        {
            #region updateController
            switch (iHour)
            {
                case (1):
                    {
                        _defectQTY01++;
                        txtQty01.Text = _defectQTY01.ToString();
                        _viDefect.rejectQtyHour01 = _defectQTY01.ToString();
                        break;
                    }
                case (2):
                    {
                        _defectQTY02++;
                        txtQty02.Text = _defectQTY02.ToString(); 
                        _viDefect.rejectQtyHour02 = _defectQTY02.ToString();
                        break;
                    }

                case (3):
                    {
                        _defectQTY03++;
                        txtQty03.Text = _defectQTY03.ToString();
                        _viDefect.rejectQtyHour03 = _defectQTY03.ToString();
                        break;
                    }

                case (4):
                    {
                        _defectQTY04++;
                        txtQty04.Text = _defectQTY04.ToString();
                        _viDefect.rejectQtyHour04 = _defectQTY04.ToString();
                        break;
                    }

                case (5):
                    {
                        _defectQTY05++;
                        txtQty05.Text = _defectQTY05.ToString();
                        _viDefect.rejectQtyHour05 = _defectQTY05.ToString();
                        break;
                    }

                case (6):
                    {
                        _defectQTY06++;
                        txtQty06.Text = _defectQTY06.ToString();
                        _viDefect.rejectQtyHour06 = _defectQTY06.ToString();
                        break;
                    }
                case (7):
                    {
                        _defectQTY07++;
                        txtQty07.Text = _defectQTY07.ToString();
                        _viDefect.rejectQtyHour07 = _defectQTY07.ToString();
                        break;
                    }
                case (8):
                    {
                        _defectQTY08++;
                        txtQty08.Text = _defectQTY08.ToString();
                        _viDefect.rejectQtyHour08 = _defectQTY08.ToString();
                        break;
                    }
                case (9):
                    {
                        _defectQTY09++;
                        txtQty09.Text = _defectQTY09.ToString();
                        _viDefect.rejectQtyHour09 = _defectQTY09.ToString();
                        break;
                    }
                case (10):
                    {
                        _defectQTY10++;
                        txtQty10.Text = _defectQTY10.ToString();
                        _viDefect.rejectQtyHour10 = _defectQTY10.ToString();
                        break;
                    }
                case (11):
                    {
                        _defectQTY11++;
                        txtQty11.Text = _defectQTY11.ToString();
                        _viDefect.rejectQtyHour11 = _defectQTY11.ToString();
                        break;
                    }
                case (12):
                    {
                        _defectQTY12++;
                        txtQty12.Text = _defectQTY12.ToString();
                        _viDefect.rejectQtyHour12 = _defectQTY12.ToString();
                        break;
                    }
            }
            #endregion 
        }

        private bool UpdateDatabase(Common.Model.MouldingViDefectTracking_Model objViDef)
        {
            bool result = false;
            try
            {
                string txt = this.Name.Replace("ubct123", "-").Replace("ubct1680"," "); ;
                string[] _partNumber = txt.Split('_');

                DateTime dTime = DateTime.Now;
                List<System.Data.SqlClient.SqlCommand> lSqlCmd = new List<System.Data.SqlClient.SqlCommand>();
                //database update
                Common.BLL.MouldingViDefectTracking_BLL bllViDef = new Common.BLL.MouldingViDefectTracking_BLL();
                objViDef.lastUpdatedTime = dTime;
                objViDef.stopTime = dTime;
                lSqlCmd.Add(bllViDef.UpdateCommandbypartNubmer(objViDef,_partNumber[2].ToString())); // by trackingID + DefectCodeID
                objViDef = bllViDef.GetModelList_ByDayShiftPartMachineForDefectTracking(objViDef.day,objViDef.shift, _partNumber[2].ToString(),objViDef.machineID,objViDef.defectCode, objViDef);
                Common.BLL.MouldingViDefectHistory_BLL bllViDefHis = new Common.BLL.MouldingViDefectHistory_BLL();
                lSqlCmd.Add(bllViDefHis.AddCommand(bllViDefHis.CopyObj(objViDef)));


                int TotalRejQty = bllViDef.getTotalRejQty_By_TrackingID(objViDef.trackingID) + 1;  // must add 1 bucause the defect record is not updated 

                Common.BLL.MouldingViTracking_BLL bllViTrk = new Common.BLL.MouldingViTracking_BLL();
                Common.Model.MouldingViTracking_Model objViTck = new Common.Model.MouldingViTracking_Model();
                objViTck = bllViTrk.GetModel_ByTrackingID(objViDef.trackingID);
                if (objViTck == null)
                {
                    return false;
                } 
                objViTck.lastUpdatedTime = dTime;
                objViTck.rejectQty = TotalRejQty;
                objViTck.acceptQty = objViTck.acceptQty - 1;
                lSqlCmd.Add(bllViTrk.UpdateCommandbyTrackingID(objViTck)); //note: update data base on ID

                Common.BLL.MouldingViHistory_BLL bllViHis = new Common.BLL.MouldingViHistory_BLL();
                lSqlCmd.Add(bllViHis.AddCommand(bllViHis.CopyObj(objViTck)));

                result= DBHelp.SqlDB.SetData_Rollback(lSqlCmd);
                StaticRes.Global._isUsingObjCurVi = false;
            }
            catch (Exception ex)
            {
                StaticRes.Global._isUsingObjCurVi = false;
                throw;
            }
            return result;
        }

        private bool UpdateDatabasebyChange(Common.Model.MouldingViDefectTracking_Model objViDef)
        {
            bool result = false;
            try
            {
                string txt = this.Name.Replace("ubct123", "-").Replace("ubct1680", " "); ;
                string[] _partNumber = txt.Split('_');

                DateTime dTime = DateTime.Now;
                List<System.Data.SqlClient.SqlCommand> lSqlCmd = new List<System.Data.SqlClient.SqlCommand>();
                //database update
                Common.BLL.MouldingViDefectTracking_BLL bllViDef = new Common.BLL.MouldingViDefectTracking_BLL();
                objViDef.lastUpdatedTime = dTime;
                objViDef.stopTime = dTime;
                lSqlCmd.Add(bllViDef.UpdateCommandbypartNubmer(objViDef, _partNumber[2].ToString())); // by trackingID + DefectCodeID
                objViDef = bllViDef.GetModelList_ByDayShiftPartMachineForDefectTracking(objViDef.day, objViDef.shift, _partNumber[2].ToString(), objViDef.machineID, objViDef.defectCode, objViDef);
                Common.BLL.MouldingViDefectHistory_BLL bllViDefHis = new Common.BLL.MouldingViDefectHistory_BLL();
                lSqlCmd.Add(bllViDefHis.AddCommand(bllViDefHis.CopyObj(objViDef)));


                int TotalRejQty = bllViDef.getTotalRejQty_By_TrackingID(objViDef.trackingID) + _Count;  // must add 1 bucause the defect record is not updated 

                Common.BLL.MouldingViTracking_BLL bllViTrk = new Common.BLL.MouldingViTracking_BLL();
                Common.Model.MouldingViTracking_Model objViTck = new Common.Model.MouldingViTracking_Model();
                objViTck = bllViTrk.GetModel_ByTrackingID(objViDef.trackingID);
                if (objViTck == null)
                {
                    return false;
                }
                objViTck.lastUpdatedTime = dTime;
                objViTck.rejectQty = TotalRejQty;
                objViTck.acceptQty = objViTck.acceptQty - _Count;
                lSqlCmd.Add(bllViTrk.UpdateCommandbyTrackingID(objViTck)); //note: update data base on ID

                Common.BLL.MouldingViHistory_BLL bllViHis = new Common.BLL.MouldingViHistory_BLL();
                lSqlCmd.Add(bllViHis.AddCommand(bllViHis.CopyObj(objViTck)));

                result = DBHelp.SqlDB.SetData_Rollback(lSqlCmd);
                _Count = 0;
                StaticRes.Global._isUsingObjCurVi = false;
            }
            catch (Exception ex)
            {
                StaticRes.Global._isUsingObjCurVi = false;
                throw;
            }
            return result;
        }

        private void btnUp_Click(object sender, RoutedEventArgs e)
        {
            try
            {

                int iHour = DateTime.Now.Hour;
                if (iHour > 12)
                {
                    iHour = iHour - 12;
                }
                if (ReduceOneCount_Hourly(iHour))
                {
                    //update TotalQTY & Controller
                    //_totalDefectQTY++;
                    this.txtDefectQty.Text = (decimal.Parse(this.txtDefectQty.Text) - 1).ToString();
                    //this.txtDefectQty.Text = _totalDefectQTY.ToString();
                    //_viDefect.rejectQty = decimal.Parse( _totalDefectQTY.ToString());
                    _viDefect.rejectQty = decimal.Parse(this.txtDefectQty.Text.ToString());
                }
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        private void btnDown_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                //update TotalQTY & Controller
                //_totalDefectQTY++;
                this.txtDefectQty.Text = (decimal.Parse(this.txtDefectQty.Text) + 1).ToString();
                //this.txtDefectQty.Text = _totalDefectQTY.ToString();
                //_viDefect.rejectQty = decimal.Parse( _totalDefectQTY.ToString());
                _viDefect.rejectQty = decimal.Parse(this.txtDefectQty.Text.ToString());
                int iHour = DateTime.Now.Hour;
                if (iHour > 12)
                {
                    iHour = iHour - 12;
                }
                AddOneCount_Hourly(iHour);
                _Count++;
            }
            catch(Exception ex)
            {

                throw;
            }
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Views.Login x = new Views.Login();
                x.HDClick += new Views.Login.HDClickEventHandler(changeSave);
                x.BackClick += new Views.Login.BackMaskEventHandler(CloseMask);
                x.ShowDialog();
            }
            catch (Exception ee)
            {
                System.Windows.MessageBox.Show(ee.Message);
            }
        }

        public void changeSave()
        {
            try
            {
                if (StaticRes.Global.Falg_UserGroup == StaticRes.Global.Department.Supervisor || StaticRes.Global.Falg_UserGroup == StaticRes.Global.Department.Leader || StaticRes.Global.Falg_UserGroup == StaticRes.Global.Department.Admin)
                {
                    StaticRes.Global._isUsingObjCurVi = true;
                    //update database
                    UpdateDatabasebyChange(_viDefect);
                }
                else
                {
                    MessageBox.Show("You haven't access into it!");
                    return;
                }
                EventSuccessful();
            }
            catch(Exception ee)
            {
                throw; 
            }
        }

        private void CloseMask()
        {
        }
        public bool refreshShiftData()
        {
            return refreshShiftData(_viDefect);
        }
        public bool refreshShiftData(Common.Model.MouldingViDefectTracking_Model objViDef)
        {
            bool result = false;
            try
            {
                string txt = this.Name.Replace("ubct123", "-").Replace("ubct1680"," "); 
                string[] _partNumber = txt.Split('_');

                Common.BLL.MouldingViDefectTracking_BLL bllViDef = new Common.BLL.MouldingViDefectTracking_BLL();
                Common.Model.MouldingViDefectTracking_Model _flagobjViDef = new Common.Model.MouldingViDefectTracking_Model();
                _flagobjViDef = bllViDef.GetModelList_ByDayShiftPartMachineForDefectTracking(objViDef.day, objViDef.shift, _partNumber[2].ToString(), objViDef.machineID, objViDef.defectCode, objViDef);
                this.DefectQTY01 = int.Parse((_flagobjViDef.rejectQtyHour01 == null || _flagobjViDef.rejectQtyHour01 == "") ? "0" : _flagobjViDef.rejectQtyHour01);
                this.DefectQTY02 = int.Parse((_flagobjViDef.rejectQtyHour02 == null || _flagobjViDef.rejectQtyHour02 == "") ? "0" : _flagobjViDef.rejectQtyHour02);
                this.DefectQTY03 = int.Parse((_flagobjViDef.rejectQtyHour03 == null || _flagobjViDef.rejectQtyHour03 == "") ? "0" : _flagobjViDef.rejectQtyHour03);
                this.DefectQTY04 = int.Parse((_flagobjViDef.rejectQtyHour04 == null || _flagobjViDef.rejectQtyHour04 == "") ? "0" : _flagobjViDef.rejectQtyHour04);
                this.DefectQTY05 = int.Parse((_flagobjViDef.rejectQtyHour05 == null || _flagobjViDef.rejectQtyHour05 == "") ? "0" : _flagobjViDef.rejectQtyHour05);
                this.DefectQTY06 = int.Parse((_flagobjViDef.rejectQtyHour06 == null || _flagobjViDef.rejectQtyHour06 == "") ? "0" : _flagobjViDef.rejectQtyHour06);
                this.DefectQTY07 = int.Parse((_flagobjViDef.rejectQtyHour07 == null || _flagobjViDef.rejectQtyHour07 == "") ? "0" : _flagobjViDef.rejectQtyHour07);
                this.DefectQTY08 = int.Parse((_flagobjViDef.rejectQtyHour08 == null || _flagobjViDef.rejectQtyHour08 == "") ? "0" : _flagobjViDef.rejectQtyHour08);
                this.DefectQTY09 = int.Parse((_flagobjViDef.rejectQtyHour09 == null || _flagobjViDef.rejectQtyHour09 == "") ? "0" : _flagobjViDef.rejectQtyHour09);
                this.DefectQTY10 = int.Parse((_flagobjViDef.rejectQtyHour10 == null || _flagobjViDef.rejectQtyHour10 == "") ? "0" : _flagobjViDef.rejectQtyHour10);
                this.DefectQTY11 = int.Parse((_flagobjViDef.rejectQtyHour11 == null || _flagobjViDef.rejectQtyHour11 == "") ? "0" : _flagobjViDef.rejectQtyHour11);
                this.DefectQTY12 = int.Parse((_flagobjViDef.rejectQtyHour12 == null || _flagobjViDef.rejectQtyHour12 == "") ? "0" : _flagobjViDef.rejectQtyHour12);
                //this.DefectQTY01 = int.Parse((objViDef.rejectQtyHour01 == null || objViDef.rejectQtyHour01 == "") ? "0" : objViDef.rejectQtyHour01);
                //this.DefectQTY02 = int.Parse((objViDef.rejectQtyHour02 == null || objViDef.rejectQtyHour02 == "") ? "0" : objViDef.rejectQtyHour02);
                //this.DefectQTY03 = int.Parse((objViDef.rejectQtyHour03 == null || objViDef.rejectQtyHour03 == "") ? "0" : objViDef.rejectQtyHour03);
                //this.DefectQTY04 = int.Parse((objViDef.rejectQtyHour04 == null || objViDef.rejectQtyHour04 == "") ? "0" : objViDef.rejectQtyHour04);
                //this.DefectQTY05 = int.Parse((objViDef.rejectQtyHour05 == null || objViDef.rejectQtyHour05 == "") ? "0" : objViDef.rejectQtyHour05);
                //this.DefectQTY06 = int.Parse((objViDef.rejectQtyHour06 == null || objViDef.rejectQtyHour06 == "") ? "0" : objViDef.rejectQtyHour06);
                //this.DefectQTY07 = int.Parse((objViDef.rejectQtyHour07 == null || objViDef.rejectQtyHour07 == "") ? "0" : objViDef.rejectQtyHour07);
                //this.DefectQTY08 = int.Parse((objViDef.rejectQtyHour08 == null || objViDef.rejectQtyHour08 == "") ? "0" : objViDef.rejectQtyHour08);
                //this.DefectQTY09 = int.Parse((objViDef.rejectQtyHour09 == null || objViDef.rejectQtyHour09 == "") ? "0" : objViDef.rejectQtyHour09);
                //this.DefectQTY10 = int.Parse((objViDef.rejectQtyHour10 == null || objViDef.rejectQtyHour10 == "") ? "0" : objViDef.rejectQtyHour10);
                //this.DefectQTY11 = int.Parse((objViDef.rejectQtyHour11 == null || objViDef.rejectQtyHour11 == "") ? "0" : objViDef.rejectQtyHour11);
                //this.DefectQTY12 = int.Parse((objViDef.rejectQtyHour12 == null || objViDef.rejectQtyHour12 == "") ? "0" : objViDef.rejectQtyHour12);
                this.txtDefectQty.Text = _flagobjViDef.rejectQty.ToString();
                //this.TotalDefectQTY = int.Parse(_flagobjViDef.rejectQty.ToString());
                //this.TotalDefectQTY = int.Parse(objViDef.rejectQty.ToString());

            }
            catch (Exception ex)
            {
                throw;
            }
            return result;
        }

        //public bool getShiftData()
        //{
        //    bool result = false;
        //    try
        //    {
        //        Common.BLL.MouldingViDefectTracking_BLL bllViDef = new Common.BLL.MouldingViDefectTracking_BLL();
        //        Common.BLL.MouldingViTracking_BLL bllVi = new Common.BLL.MouldingViTracking_BLL();

        //    }
        //    catch (Exception ex)
        //    {

        //        throw;
        //    }
        //    return result;
        //}
    }
}

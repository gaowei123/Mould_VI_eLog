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
   


    public delegate void SetReasonComplete(bool result, string sMcStatus);

    public partial class McStopMessageBox : UserControl
    {

        public event SetReasonComplete SetReasonCompleteEvent;


        private struct Reason
        {
            public int ID { get; set; }
            public string Name { get; set; }
        }

        private Common.Model.MouldingMachineStatus_Model _objMachine = new Common.Model.MouldingMachineStatus_Model();
        

        public McStopMessageBox()
        {
            InitializeComponent();

            //setCbbReason();
            //this.btnSubmit.IsEnabled = false;
            //this.btnCanel.IsEnabled = false;
            //this.cbbReason.IsEnabled = false;
        }
        
        public McStopMessageBox(Common.Model.MouldingMachineStatus_Model model, string sMcStatus)
        {
            InitializeComponent();


          
          
            _objMachine = model;

            //隐藏的一个textbox框, 只用来记录下mcStatus
            this.txtMcStatus.Text = sMcStatus;

            setCbbReason(sMcStatus);


            string status = sMcStatus == StaticRes.Global.MachineSttaus.NoMaterial ? "M/C Stop" : sMcStatus;
            this.txtMessageBlock.Text = "Change machine status to "+ status + ", Please choose reason !";
            this.txtMessageBlock.IsEnabled = false;
            
            this.btnSubmit.IsEnabled = true;
            this.btnCanel.IsEnabled = true;
            this.txtReason.IsEnabled = this.cbbReason.Text == "Others" ? true : false;



            this.Visibility = Visibility.Visible;
        }




        private void cbbReason_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string selectedVaule = ((Reason)this.cbbReason.SelectedItem).Name;
            if (selectedVaule == "Others")
            {
                this.txtReason.IsEnabled = true;
                this.txtReason.Focus();
            }
            else
            {
                this.txtReason.IsEnabled = false;
                this.txtReason.Text = "";
            }
        }
        
        private void btnSubmit_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string sReason = "";
                if (((Reason)this.cbbReason.SelectedItem).Name.ToUpper() == "OTHERS")
                    sReason = this.txtReason.Text.Trim();
                else
                    sReason = ((Reason)this.cbbReason.SelectedItem).Name;


                if (sReason == "")
                {
                    if (MessageBox.Show("Are you sure to set reason null?", "Warning", MessageBoxButton.YesNo, MessageBoxImage.Warning) == MessageBoxResult.No)
                        return;
                }

                _objMachine.remark = sReason;

                switch (this.txtMcStatus.Text)
                {
                    case StaticRes.Global.MachineSttaus.Adjustment:
                        if (StaticRes.Global.ButtonStaus.Adjustment)
                        {
                            StaticRes.Global.MachineStatus = StaticRes.Global.MachineSttaus.Adjustment;
                            StaticRes.Global.OeeStatus = StaticRes.Global.oee.Adjustment;
                        }
                        break;

                    case StaticRes.Global.MachineSttaus.MaterialTesting:
                        if (StaticRes.Global.ButtonStaus.MaterialTesting)
                        {
                            StaticRes.Global.MachineStatus = StaticRes.Global.MachineSttaus.MaterialTesting;
                            StaticRes.Global.OeeStatus = StaticRes.Global.oee.Testing;
                        }
                        break;

                    case StaticRes.Global.MachineSttaus.MouldTesting:
                        if (StaticRes.Global.ButtonStaus.MouldTesting)
                        {
                            StaticRes.Global.MachineStatus = StaticRes.Global.MachineSttaus.MouldTesting;
                            StaticRes.Global.OeeStatus = StaticRes.Global.oee.Testing;
                        }
                        break;

                    case StaticRes.Global.MachineSttaus.NoMaterial:
                        if (StaticRes.Global.ButtonStaus.NoMaterial)
                        {
                            StaticRes.Global.MachineStatus = StaticRes.Global.MachineSttaus.NoMaterial;
                            StaticRes.Global.OeeStatus = StaticRes.Global.oee.Shut_Down;
                        }
                        break;

                    case StaticRes.Global.MachineSttaus.MachineBreak:
                        if (StaticRes.Global.ButtonStaus.MachineBreak)
                        {
                            StaticRes.Global.MachineStatus = StaticRes.Global.MachineSttaus.NoMaterial;
                            StaticRes.Global.OeeStatus = StaticRes.Global.oee.Shut_Down;
                        }
                        break;

                    case StaticRes.Global.MachineSttaus.DamageMould:
                        if (StaticRes.Global.ButtonStaus.DamageMould)
                        {
                            StaticRes.Global.MachineStatus = StaticRes.Global.MachineSttaus.DamageMould;
                            StaticRes.Global.OeeStatus = StaticRes.Global.oee.Break_Down;
                        }
                        break;
                        
                    default:
                        break;
                }


                if (!updatemachine(false))
                    SetReasonCompleteEvent(false, this.txtMcStatus.Text);
                else
                    SetReasonCompleteEvent(true, this.txtMcStatus.Text);

            }
            catch (Exception ee)
            {
                DBHelp.Reports.LogFile.Log("McStopMessageBox", "btnSubmit_Click Exception:" + ee.ToString());
            }
        }

        private void btnCanel_Click(object sender, RoutedEventArgs e)
        {
            ResetUI();
            SetReasonCompleteEvent(false, this.txtMcStatus.Text);
        }




        public bool updatemachine(bool _MachineStatus)
        {
            _objMachine.machinestatus = StaticRes.Global.MachineStatus;
            _objMachine.oeestatus = StaticRes.Global.OeeStatus;

            _objMachine.starttime = System.DateTime.Now;
            _objMachine.partno = null;
           
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
            if (!DBHelp.SqlDB.SetData_Rollback(lSqlCmd))  //by ID
            {
                MessageBox.Show("Machine status updated fail!");
                return false;
            }
            else
            {
                return true;
            }
        }

       


        void setCbbReason(string sMcStatus)
        {
            this.cbbReason.Items.Clear();

            List<Reason> listReason = new List<Reason>();
            

            switch (sMcStatus)
            {
                case StaticRes.Global.MachineSttaus.Adjustment:
                    {
                        listReason.Add(new Reason { ID = 0, Name = "" });
                        listReason.Add(new Reason { ID = 1, Name = "Drag" });
                        listReason.Add(new Reason { ID = 2, Name = "Flow Line" });
                        listReason.Add(new Reason { ID = 3, Name = "Sink Mark" });
                        listReason.Add(new Reason { ID = 4, Name = "Short Shot" });
                        listReason.Add(new Reason { ID = 5, Name = "Weld Line" });
                        listReason.Add(new Reason { ID = 6, Name = "Others" });
                    }
                    break;

                case StaticRes.Global.MachineSttaus.MaterialTesting:
                    listReason.Add(new Reason { ID = 0, Name = "Others" });
                    break;

                case StaticRes.Global.MachineSttaus.MouldTesting:
                    listReason.Add(new Reason { ID = 0, Name = "Others" });
                    break;

                case StaticRes.Global.MachineSttaus.NoMaterial:
                    {
                        listReason.Add(new Reason { ID = 0, Name = "" });
                        listReason.Add(new Reason { ID = 1, Name = "No Packing Materials" });
                        listReason.Add(new Reason { ID = 2, Name = "No Resin Materials" });
                        listReason.Add(new Reason { ID = 3, Name = "Production Completed" });
                        listReason.Add(new Reason { ID = 4, Name = "Morning Assembly" });
                        listReason.Add(new Reason { ID = 5, Name = "No Overtime" });
                        listReason.Add(new Reason { ID = 6, Name = "Others" });
                    }
                    break;

                case StaticRes.Global.MachineSttaus.MachineBreak:
                    {
                        listReason.Add(new Reason { ID = 0, Name = "" });
                        listReason.Add(new Reason { ID = 1, Name = "Hopper Dryer Breakdown" });
                        listReason.Add(new Reason { ID = 2, Name = "Inj. Machine Breakdown" });
                        listReason.Add(new Reason { ID = 3, Name = "Robot Arm Breakdown" });
                        listReason.Add(new Reason { ID = 4, Name = "MTC Breakdown" });
                        listReason.Add(new Reason { ID = 5, Name = "Stacker Breakdown" });
                        listReason.Add(new Reason { ID = 6, Name = "Version Checker Breakdown" });
                        listReason.Add(new Reason { ID = 7, Name = "Others" });
                    }
                    break;

                case StaticRes.Global.MachineSttaus.DamageMould:
                    listReason.Add(new Reason { ID = 0, Name = "Others" });
                    break;

                default:
                    listReason.Add(new Reason { ID = 0, Name = "Others" });
                break;
            }
       
            this.cbbReason.ItemsSource = listReason;
            this.cbbReason.SelectedIndex = 0;
        }


        void ResetUI()
        {
            this.cbbReason.SelectedIndex = 0;
            this.txtReason.Text = "";
        }
        
    }
}

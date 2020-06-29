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
using System.Windows.Threading;
using System.IO;
using System.Drawing.Imaging;  

namespace VI_eLog
{
    public partial class MainWindow : Window
    {
        DispatcherTimer timerTick = new DispatcherTimer();
         
        public MainWindow()
        {
            InitializeComponent();
            InitMainWindow("");
        }
        public MainWindow(string SqlStatement_User_Login)
        {
            InitializeComponent();
            InitMainWindow(SqlStatement_User_Login);
        }
        public void InitMainWindow(string SqlStatement_User_Login)
        {
            label_SystemVersion.Content = "Version: "+" 1.0.4.190828"; //Properties.Resources.Version.Split(new[] { '\r', '\n' }).FirstOrDefault();
            System.Data.DataTable DataTable = new System.Data.DataTable();

            #region Load User Profile
            try
            {
               
             
                //currentUser = new ObjectModule.User(DataTable);

               //  label_IDName.Content = "Welcome, Admin1";//+ User.USER_NAME; ;
            }
            catch
            {
                //this.image_profile.Source = null;

                //currentUser = null;

                //label_IDName.Content = "Welcome, Admin2"  ;
            }
           

            #endregion

            #region Timer Tick

            timerTick.Tick += new EventHandler(Timer);
            timerTick.Interval = TimeSpan.FromSeconds(1);
            timerTick.Start();

            #endregion
             

            //2018 02 23 by Wei LJ for auto display the AR List of login user.
            System.Windows.Controls.MenuItem menuItem = new MenuItem();
            menuItem.Header = "Visual Inspection";
            MenuItem_Click(menuItem,  new RoutedEventArgs());

        }

        void Timer(object sender, EventArgs e)
        {
            StaticRes.Global.CurDay = StaticRes.Global.getDay(DateTime.Now);
            StaticRes.Global.CurShift = StaticRes.Global.getShift(DateTime.Now);
        }

        void MouseEventArgs(object sender, MouseEventArgs e)
        {
            
        }

        void call_Loginpage()
        { 
            this.Close();
        }

        private void Button_EditProfile_Click(object sender, RoutedEventArgs e)
        {
            //Edit_Profile x = new Edit_Profile(this, User.USER_ID, blob);
            //x.Show();
            MessageBox.Show("Under Development!");
        } 

        private void Button_Logout_Click(object sender, RoutedEventArgs e)
        {
            ////if (Database.Sql.CheckConnection() == true)
            {
                if (MessageBox.Show("Are you sure want to logout ?",
                          "Log out confirmation", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
                {
                    // Database.Sql.Update(Database.Statements.User_Logout(User.USER_ID));
                    call_Loginpage();
                }
            }
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            MainGrid.Children.Clear();

            ////if (Database.Sql.CheckConnection())
            {
                switch (((System.Windows.Controls.MenuItem)sender).Header.ToString())
                {
                    #region Project Management
                    case "Visual Inspection":
                        VI_eLog.Mould.eLog.VisualInspection VI = new Mould.eLog.VisualInspection();
                        MainGrid.Children.Add(VI);
                        break;
                    #endregion
                        
                }
            }
        }

        private void Window_Closed(object sender, EventArgs e)
        {
            App.Current.Shutdown();
        }

       

        
    }
}

﻿#pragma checksum "..\..\..\LoginPage.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "F1F828477230D4C4176AFF6B02CF5A125830300D"
//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms.Integration;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;


namespace VI_eLog {
    
    
    /// <summary>
    /// LoginPage
    /// </summary>
    public partial class LoginPage : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 20 "..\..\..\LoginPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Button_Login;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\..\LoginPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Button_Exit;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\..\LoginPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image Image_Username;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\..\LoginPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image Image_Password;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\..\LoginPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label label_SystemVersion;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\..\LoginPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TextBox_Username;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\..\LoginPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.PasswordBox PasswordBox_Userpassword;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\..\LoginPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image CompanyLogo;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/VI_eLog;component/loginpage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\LoginPage.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            
            #line 4 "..\..\..\LoginPage.xaml"
            ((VI_eLog.LoginPage)(target)).MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.WindowMouseLeftButtonDown);
            
            #line default
            #line hidden
            return;
            case 2:
            this.Button_Login = ((System.Windows.Controls.Button)(target));
            
            #line 20 "..\..\..\LoginPage.xaml"
            this.Button_Login.Click += new System.Windows.RoutedEventHandler(this.Button_Login_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.Button_Exit = ((System.Windows.Controls.Button)(target));
            
            #line 21 "..\..\..\LoginPage.xaml"
            this.Button_Exit.Click += new System.Windows.RoutedEventHandler(this.Button_Exit_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.Image_Username = ((System.Windows.Controls.Image)(target));
            return;
            case 5:
            this.Image_Password = ((System.Windows.Controls.Image)(target));
            return;
            case 6:
            this.label_SystemVersion = ((System.Windows.Controls.Label)(target));
            return;
            case 7:
            this.TextBox_Username = ((System.Windows.Controls.TextBox)(target));
            
            #line 25 "..\..\..\LoginPage.xaml"
            this.TextBox_Username.PreviewKeyDown += new System.Windows.Input.KeyEventHandler(this.EnterClicked);
            
            #line default
            #line hidden
            return;
            case 8:
            this.PasswordBox_Userpassword = ((System.Windows.Controls.PasswordBox)(target));
            
            #line 26 "..\..\..\LoginPage.xaml"
            this.PasswordBox_Userpassword.PreviewKeyDown += new System.Windows.Input.KeyEventHandler(this.EnterClicked);
            
            #line default
            #line hidden
            return;
            case 9:
            this.CompanyLogo = ((System.Windows.Controls.Image)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}


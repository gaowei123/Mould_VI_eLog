﻿#pragma checksum "..\..\..\..\..\..\Departments\Project Management\AR2\Close_AR2.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "A55FE2D3E1E5AFE0F4A94BF38173259BFB9E6C42"
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


namespace VI_eLog.Departments.Project_Management.AR {
    
    
    /// <summary>
    /// Close_AR2
    /// </summary>
    public partial class Close_AR2 : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 9 "..\..\..\..\..\..\Departments\Project Management\AR2\Close_AR2.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid Mask_Add;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\..\..\..\..\Departments\Project Management\AR2\Close_AR2.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lb_title;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\..\..\..\..\Departments\Project Management\AR2\Close_AR2.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_Submit;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\..\..\..\..\Departments\Project Management\AR2\Close_AR2.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_close;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\..\..\..\..\Departments\Project Management\AR2\Close_AR2.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txt_Description;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\..\..\..\..\Departments\Project Management\AR2\Close_AR2.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txt_ARid;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\..\..\..\..\Departments\Project Management\AR2\Close_AR2.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txt_Remark;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\..\..\..\..\Departments\Project Management\AR2\Close_AR2.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txt_Action;
        
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
            System.Uri resourceLocater = new System.Uri("/VI_eLog;component/departments/project%20management/ar2/close_ar2.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\..\..\Departments\Project Management\AR2\Close_AR2.xaml"
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
            
            #line 7 "..\..\..\..\..\..\Departments\Project Management\AR2\Close_AR2.xaml"
            ((VI_eLog.Departments.Project_Management.AR.Close_AR2)(target)).MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.Window_MouseLeftButtonDown);
            
            #line default
            #line hidden
            return;
            case 2:
            this.Mask_Add = ((System.Windows.Controls.Grid)(target));
            return;
            case 3:
            this.lb_title = ((System.Windows.Controls.Label)(target));
            return;
            case 4:
            this.btn_Submit = ((System.Windows.Controls.Button)(target));
            
            #line 23 "..\..\..\..\..\..\Departments\Project Management\AR2\Close_AR2.xaml"
            this.btn_Submit.Click += new System.Windows.RoutedEventHandler(this.btn_confirm_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.btn_close = ((System.Windows.Controls.Button)(target));
            
            #line 24 "..\..\..\..\..\..\Departments\Project Management\AR2\Close_AR2.xaml"
            this.btn_close.Click += new System.Windows.RoutedEventHandler(this.btn_close_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.txt_Description = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.txt_ARid = ((System.Windows.Controls.TextBox)(target));
            return;
            case 8:
            this.txt_Remark = ((System.Windows.Controls.TextBox)(target));
            return;
            case 9:
            this.txt_Action = ((System.Windows.Controls.TextBox)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

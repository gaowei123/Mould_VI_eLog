﻿#pragma checksum "..\..\..\..\..\..\Departments\Purchasing\PO\manageItemsAdd.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "62CD67502C658861299014B87394AFFC1B734799"
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


namespace VI_eLog.Departments.Purchasing.PO {
    
    
    /// <summary>
    /// manageItemsAdd
    /// </summary>
    public partial class manageItemsAdd : System.Windows.Window, System.Windows.Markup.IComponentConnector, System.Windows.Markup.IStyleConnector {
        
        
        #line 16 "..\..\..\..\..\..\Departments\Purchasing\PO\manageItemsAdd.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lb_title;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\..\..\..\..\Departments\Purchasing\PO\manageItemsAdd.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_confirm;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\..\..\..\..\Departments\Purchasing\PO\manageItemsAdd.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_close;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\..\..\..\..\Departments\Purchasing\PO\manageItemsAdd.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid dataGridBomItems;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\..\..\..\..\Departments\Purchasing\PO\manageItemsAdd.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox SelectAll_CheckBox;
        
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
            System.Uri resourceLocater = new System.Uri("/VI_eLog;component/departments/purchasing/po/manageitemsadd.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\..\..\Departments\Purchasing\PO\manageItemsAdd.xaml"
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
            
            #line 7 "..\..\..\..\..\..\Departments\Purchasing\PO\manageItemsAdd.xaml"
            ((VI_eLog.Departments.Purchasing.PO.manageItemsAdd)(target)).MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.Window_MouseLeftButtonDown);
            
            #line default
            #line hidden
            return;
            case 2:
            this.lb_title = ((System.Windows.Controls.Label)(target));
            return;
            case 3:
            this.btn_confirm = ((System.Windows.Controls.Button)(target));
            
            #line 22 "..\..\..\..\..\..\Departments\Purchasing\PO\manageItemsAdd.xaml"
            this.btn_confirm.Click += new System.Windows.RoutedEventHandler(this.btn_confirm_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.btn_close = ((System.Windows.Controls.Button)(target));
            
            #line 23 "..\..\..\..\..\..\Departments\Purchasing\PO\manageItemsAdd.xaml"
            this.btn_close.Click += new System.Windows.RoutedEventHandler(this.btn_close_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.dataGridBomItems = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 7:
            this.SelectAll_CheckBox = ((System.Windows.Controls.CheckBox)(target));
            
            #line 33 "..\..\..\..\..\..\Departments\Purchasing\PO\manageItemsAdd.xaml"
            this.SelectAll_CheckBox.Checked += new System.Windows.RoutedEventHandler(this.SelectAll_CheckBox_Checked);
            
            #line default
            #line hidden
            
            #line 33 "..\..\..\..\..\..\Departments\Purchasing\PO\manageItemsAdd.xaml"
            this.SelectAll_CheckBox.Initialized += new System.EventHandler(this.SelectAll_CheckBox_Initialized);
            
            #line default
            #line hidden
            
            #line 33 "..\..\..\..\..\..\Departments\Purchasing\PO\manageItemsAdd.xaml"
            this.SelectAll_CheckBox.Unchecked += new System.Windows.RoutedEventHandler(this.SelectAll_CheckBox_Unchecked);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        void System.Windows.Markup.IStyleConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 6:
            
            #line 29 "..\..\..\..\..\..\Departments\Purchasing\PO\manageItemsAdd.xaml"
            ((System.Windows.Controls.CheckBox)(target)).Checked += new System.Windows.RoutedEventHandler(this.chkDiscontinue_Checked);
            
            #line default
            #line hidden
            
            #line 29 "..\..\..\..\..\..\Departments\Purchasing\PO\manageItemsAdd.xaml"
            ((System.Windows.Controls.CheckBox)(target)).Unchecked += new System.Windows.RoutedEventHandler(this.chkDiscontinue_Checked);
            
            #line default
            #line hidden
            break;
            }
        }
    }
}

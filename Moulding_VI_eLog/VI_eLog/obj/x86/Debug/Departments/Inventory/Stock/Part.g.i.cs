﻿#pragma checksum "..\..\..\..\..\..\Departments\Inventory\Stock\Part.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0648E2B99058920AA2076CE6D5E478358ABD62A0"
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


namespace VI_eLog.Departments.Inventory.Stock {
    
    
    /// <summary>
    /// Part
    /// </summary>
    public partial class Part : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 14 "..\..\..\..\..\..\Departments\Inventory\Stock\Part.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label Description;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\..\..\..\..\Departments\Inventory\Stock\Part.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label PR_No;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\..\..\..\..\Departments\Inventory\Stock\Part.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_take;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\..\..\..\..\Departments\Inventory\Stock\Part.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label UBCT_No;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\..\..\..\..\Departments\Inventory\Stock\Part.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label Brand;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\..\..\..\..\Departments\Inventory\Stock\Part.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label Stock_Qty;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\..\..\..\..\Departments\Inventory\Stock\Part.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_transfer;
        
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
            System.Uri resourceLocater = new System.Uri("/VI_eLog;component/departments/inventory/stock/part.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\..\..\Departments\Inventory\Stock\Part.xaml"
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
            this.Description = ((System.Windows.Controls.Label)(target));
            return;
            case 2:
            this.PR_No = ((System.Windows.Controls.Label)(target));
            return;
            case 3:
            this.btn_take = ((System.Windows.Controls.Button)(target));
            
            #line 16 "..\..\..\..\..\..\Departments\Inventory\Stock\Part.xaml"
            this.btn_take.Click += new System.Windows.RoutedEventHandler(this.btn_take_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.UBCT_No = ((System.Windows.Controls.Label)(target));
            return;
            case 5:
            this.Brand = ((System.Windows.Controls.Label)(target));
            return;
            case 6:
            this.Stock_Qty = ((System.Windows.Controls.Label)(target));
            return;
            case 7:
            this.btn_transfer = ((System.Windows.Controls.Button)(target));
            
            #line 20 "..\..\..\..\..\..\Departments\Inventory\Stock\Part.xaml"
            this.btn_transfer.Click += new System.Windows.RoutedEventHandler(this.btn_transfer_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}


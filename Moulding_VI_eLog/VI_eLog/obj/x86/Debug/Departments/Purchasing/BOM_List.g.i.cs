﻿#pragma checksum "..\..\..\..\..\Departments\Purchasing\BOM_List.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "505FD9E940136CD484A15A8891B25B61C757EFEF"
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


namespace VI_eLog.Departments.Purchasing {
    
    
    /// <summary>
    /// BOM_List
    /// </summary>
    public partial class BOM_List : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 11 "..\..\..\..\..\Departments\Purchasing\BOM_List.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label Label_ProjectNumber;
        
        #line default
        #line hidden
        
        
        #line 12 "..\..\..\..\..\Departments\Purchasing\BOM_List.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox textBox_Search;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\..\..\..\Departments\Purchasing\BOM_List.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cb_Parts;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\..\..\..\Departments\Purchasing\BOM_List.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cb_Projects;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\..\..\..\Departments\Purchasing\BOM_List.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button button_Export;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\..\..\..\Departments\Purchasing\BOM_List.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid dataGrid_BOM_List;
        
        #line default
        #line hidden
        
        
        #line 104 "..\..\..\..\..\Departments\Purchasing\BOM_List.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label label_TotalBOM;
        
        #line default
        #line hidden
        
        
        #line 105 "..\..\..\..\..\Departments\Purchasing\BOM_List.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label label_Price;
        
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
            System.Uri resourceLocater = new System.Uri("/VI_eLog;component/departments/purchasing/bom_list.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\..\Departments\Purchasing\BOM_List.xaml"
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
            this.Label_ProjectNumber = ((System.Windows.Controls.Label)(target));
            return;
            case 2:
            this.textBox_Search = ((System.Windows.Controls.TextBox)(target));
            
            #line 12 "..\..\..\..\..\Departments\Purchasing\BOM_List.xaml"
            this.textBox_Search.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.textBox_FilePath_TextChanged);
            
            #line default
            #line hidden
            return;
            case 3:
            this.cb_Parts = ((System.Windows.Controls.ComboBox)(target));
            
            #line 14 "..\..\..\..\..\Departments\Purchasing\BOM_List.xaml"
            this.cb_Parts.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.cb_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 4:
            this.cb_Projects = ((System.Windows.Controls.ComboBox)(target));
            
            #line 21 "..\..\..\..\..\Departments\Purchasing\BOM_List.xaml"
            this.cb_Projects.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.cb_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 5:
            this.button_Export = ((System.Windows.Controls.Button)(target));
            
            #line 23 "..\..\..\..\..\Departments\Purchasing\BOM_List.xaml"
            this.button_Export.Click += new System.Windows.RoutedEventHandler(this.button_Export_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.dataGrid_BOM_List = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 7:
            this.label_TotalBOM = ((System.Windows.Controls.Label)(target));
            return;
            case 8:
            this.label_Price = ((System.Windows.Controls.Label)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}


﻿#pragma checksum "..\..\ControlTowerWindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "F099A2419BFABD173BACA2AFC494EDA7EFD69944"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using AssignmentCourse2Task5;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
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


namespace AssignmentCourse2Task5 {
    
    
    /// <summary>
    /// ControlTowerWindow
    /// </summary>
    public partial class ControlTowerWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 10 "..\..\ControlTowerWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lblFlightTower;
        
        #line default
        #line hidden
        
        
        #line 11 "..\..\ControlTowerWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lblFlightCode;
        
        #line default
        #line hidden
        
        
        #line 12 "..\..\ControlTowerWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label liblStatus;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\ControlTowerWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lblTime;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\ControlTowerWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox lstFlights;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\ControlTowerWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lblNextFlight;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\ControlTowerWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtNextFlight;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\ControlTowerWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnSendPlane;
        
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
            System.Uri resourceLocater = new System.Uri("/AssignmentCourse2Task5;component/controltowerwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\ControlTowerWindow.xaml"
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
            this.lblFlightTower = ((System.Windows.Controls.Label)(target));
            return;
            case 2:
            this.lblFlightCode = ((System.Windows.Controls.Label)(target));
            return;
            case 3:
            this.liblStatus = ((System.Windows.Controls.Label)(target));
            return;
            case 4:
            this.lblTime = ((System.Windows.Controls.Label)(target));
            return;
            case 5:
            this.lstFlights = ((System.Windows.Controls.ListBox)(target));
            return;
            case 6:
            this.lblNextFlight = ((System.Windows.Controls.Label)(target));
            return;
            case 7:
            this.txtNextFlight = ((System.Windows.Controls.TextBox)(target));
            
            #line 16 "..\..\ControlTowerWindow.xaml"
            this.txtNextFlight.GotFocus += new System.Windows.RoutedEventHandler(this.txtBox_GotFocus);
            
            #line default
            #line hidden
            return;
            case 8:
            this.btnSendPlane = ((System.Windows.Controls.Button)(target));
            
            #line 17 "..\..\ControlTowerWindow.xaml"
            this.btnSendPlane.Click += new System.Windows.RoutedEventHandler(this.btnSendPlane_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

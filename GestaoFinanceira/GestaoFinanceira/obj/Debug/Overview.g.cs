﻿#pragma checksum "..\..\Overview.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "CC53F4A3BE5B7D48A79649A7676E34A4C2F937CFA571CC207416350F9CD9FC1C"
//------------------------------------------------------------------------------
// <auto-generated>
//     O código foi gerado por uma ferramenta.
//     Versão de Tempo de Execução:4.0.30319.42000
//
//     As alterações ao arquivo poderão causar comportamento incorreto e serão perdidas se
//     o código for gerado novamente.
// </auto-generated>
//------------------------------------------------------------------------------

using GestaoFinanceira;
using LiveCharts.Wpf;
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


namespace GestaoFinanceira {
    
    
    /// <summary>
    /// Overview
    /// </summary>
    public partial class Overview : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 119 "..\..\Overview.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal LiveCharts.Wpf.PieChart doughnut;
        
        #line default
        #line hidden
        
        
        #line 132 "..\..\Overview.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock received;
        
        #line default
        #line hidden
        
        
        #line 138 "..\..\Overview.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock paid;
        
        #line default
        #line hidden
        
        
        #line 144 "..\..\Overview.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock lastMonth;
        
        #line default
        #line hidden
        
        
        #line 150 "..\..\Overview.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock actualMonth;
        
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
            System.Uri resourceLocater = new System.Uri("/GestaoFinanceira;component/overview.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\Overview.xaml"
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
            
            #line 98 "..\..\Overview.xaml"
            ((System.Windows.Controls.Button)(target)).MouseEnter += new System.Windows.Input.MouseEventHandler(this.MenuButton_MouseEnter);
            
            #line default
            #line hidden
            
            #line 98 "..\..\Overview.xaml"
            ((System.Windows.Controls.Button)(target)).MouseLeave += new System.Windows.Input.MouseEventHandler(this.MenuButton_MouseLeave);
            
            #line default
            #line hidden
            return;
            case 2:
            
            #line 99 "..\..\Overview.xaml"
            ((System.Windows.Controls.Button)(target)).MouseEnter += new System.Windows.Input.MouseEventHandler(this.MenuButton_MouseEnter);
            
            #line default
            #line hidden
            
            #line 99 "..\..\Overview.xaml"
            ((System.Windows.Controls.Button)(target)).MouseLeave += new System.Windows.Input.MouseEventHandler(this.MenuButton_MouseLeave);
            
            #line default
            #line hidden
            return;
            case 3:
            
            #line 100 "..\..\Overview.xaml"
            ((System.Windows.Controls.Button)(target)).MouseEnter += new System.Windows.Input.MouseEventHandler(this.MenuButton_MouseEnter);
            
            #line default
            #line hidden
            
            #line 100 "..\..\Overview.xaml"
            ((System.Windows.Controls.Button)(target)).MouseLeave += new System.Windows.Input.MouseEventHandler(this.MenuButton_MouseLeave);
            
            #line default
            #line hidden
            return;
            case 4:
            this.doughnut = ((LiveCharts.Wpf.PieChart)(target));
            return;
            case 5:
            this.received = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 6:
            this.paid = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 7:
            this.lastMonth = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 8:
            this.actualMonth = ((System.Windows.Controls.TextBlock)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}


﻿#pragma checksum "..\..\..\views\RegisterUC.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5910F604B09DD8B910B172BB442B793CD57F1567"
//------------------------------------------------------------------------------
// <auto-generated>
//     קוד זה נוצר על-ידי כלי.
//     גירסת זמן ריצה:4.0.30319.42000
//
//     ייתכן ששינויים בקובץ זה גרמו לפעולה לא תקינה ויאבדו אם
//     הקוד נוצר מחדש.
// </auto-generated>
//------------------------------------------------------------------------------

using BE;
using MaterialDesignThemes.Wpf;
using MaterialDesignThemes.Wpf.Converters;
using MaterialDesignThemes.Wpf.Transitions;
using PL;
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


namespace PL.UserControls {
    
    
    /// <summary>
    /// RegisterUC
    /// </summary>
    public partial class RegisterUC : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 21 "..\..\..\views\RegisterUC.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid registerGrid;
        
        #line default
        #line hidden
        
        
        #line 42 "..\..\..\views\RegisterUC.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox userName;
        
        #line default
        #line hidden
        
        
        #line 43 "..\..\..\views\RegisterUC.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox name;
        
        #line default
        #line hidden
        
        
        #line 44 "..\..\..\views\RegisterUC.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox password;
        
        #line default
        #line hidden
        
        
        #line 45 "..\..\..\views\RegisterUC.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox birthYear;
        
        #line default
        #line hidden
        
        
        #line 46 "..\..\..\views\RegisterUC.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox height;
        
        #line default
        #line hidden
        
        
        #line 47 "..\..\..\views\RegisterUC.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox weight;
        
        #line default
        #line hidden
        
        
        #line 48 "..\..\..\views\RegisterUC.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox DestinationWeight;
        
        #line default
        #line hidden
        
        
        #line 49 "..\..\..\views\RegisterUC.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox gender;
        
        #line default
        #line hidden
        
        
        #line 53 "..\..\..\views\RegisterUC.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox sportCombo;
        
        #line default
        #line hidden
        
        
        #line 74 "..\..\..\views\RegisterUC.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Back;
        
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
            System.Uri resourceLocater = new System.Uri("/PL;component/views/registeruc.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\views\RegisterUC.xaml"
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
            this.registerGrid = ((System.Windows.Controls.Grid)(target));
            return;
            case 2:
            this.userName = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.name = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.password = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.birthYear = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.height = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.weight = ((System.Windows.Controls.TextBox)(target));
            return;
            case 8:
            this.DestinationWeight = ((System.Windows.Controls.TextBox)(target));
            return;
            case 9:
            this.gender = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 10:
            this.sportCombo = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 11:
            this.Back = ((System.Windows.Controls.Button)(target));
            
            #line 74 "..\..\..\views\RegisterUC.xaml"
            this.Back.Click += new System.Windows.RoutedEventHandler(this.Back_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}


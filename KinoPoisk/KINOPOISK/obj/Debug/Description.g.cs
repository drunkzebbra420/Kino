﻿#pragma checksum "..\..\Description.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "A2BE4A5AD3E25351CDA6C029C3CF78838FE5760A4698007196154EA0F02925B2"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using KINOPOISK;
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


namespace KINOPOISK {
    
    
    /// <summary>
    /// Description
    /// </summary>
    public partial class Description : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 51 "..\..\Description.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button backBtn;
        
        #line default
        #line hidden
        
        
        #line 68 "..\..\Description.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image poster;
        
        #line default
        #line hidden
        
        
        #line 73 "..\..\Description.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock nameText;
        
        #line default
        #line hidden
        
        
        #line 75 "..\..\Description.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock yearText;
        
        #line default
        #line hidden
        
        
        #line 79 "..\..\Description.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock genreText;
        
        #line default
        #line hidden
        
        
        #line 81 "..\..\Description.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock ageText;
        
        #line default
        #line hidden
        
        
        #line 83 "..\..\Description.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock descriptionText;
        
        #line default
        #line hidden
        
        
        #line 89 "..\..\Description.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock durationText;
        
        #line default
        #line hidden
        
        
        #line 92 "..\..\Description.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button watch_filmBtn;
        
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
            System.Uri resourceLocater = new System.Uri("/KINOPOISK;component/description.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\Description.xaml"
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
            this.backBtn = ((System.Windows.Controls.Button)(target));
            
            #line 51 "..\..\Description.xaml"
            this.backBtn.Click += new System.Windows.RoutedEventHandler(this.backBtn_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.poster = ((System.Windows.Controls.Image)(target));
            return;
            case 3:
            this.nameText = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 4:
            this.yearText = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 5:
            this.genreText = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 6:
            this.ageText = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 7:
            this.descriptionText = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 8:
            this.durationText = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 9:
            this.watch_filmBtn = ((System.Windows.Controls.Button)(target));
            
            #line 92 "..\..\Description.xaml"
            this.watch_filmBtn.Click += new System.Windows.RoutedEventHandler(this.watch_filmBtn_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}


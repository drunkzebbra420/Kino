﻿#pragma checksum "..\..\Player.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "AC7161AA7C0910BFDB8D11BD2ED529BFCA32D07413F1BB98EA8D58E11C5B5682"
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
    /// Player
    /// </summary>
    public partial class Player : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 33 "..\..\Player.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MediaElement VideoControl;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\Player.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button exitBtn;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\Player.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock timeText;
        
        #line default
        #line hidden
        
        
        #line 41 "..\..\Player.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Slider slider2;
        
        #line default
        #line hidden
        
        
        #line 43 "..\..\Player.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.StackPanel bar;
        
        #line default
        #line hidden
        
        
        #line 44 "..\..\Player.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button PlayButton;
        
        #line default
        #line hidden
        
        
        #line 45 "..\..\Player.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock pauseText;
        
        #line default
        #line hidden
        
        
        #line 48 "..\..\Player.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button fullScreenButton;
        
        #line default
        #line hidden
        
        
        #line 51 "..\..\Player.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Slider volumeSlider;
        
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
            System.Uri resourceLocater = new System.Uri("/KINOPOISK;component/player.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\Player.xaml"
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
            
            #line 8 "..\..\Player.xaml"
            ((KINOPOISK.Player)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Window_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.VideoControl = ((System.Windows.Controls.MediaElement)(target));
            
            #line 33 "..\..\Player.xaml"
            this.VideoControl.MediaOpened += new System.Windows.RoutedEventHandler(this.VideoControl_MediaOpened);
            
            #line default
            #line hidden
            return;
            case 3:
            this.exitBtn = ((System.Windows.Controls.Button)(target));
            
            #line 35 "..\..\Player.xaml"
            this.exitBtn.Click += new System.Windows.RoutedEventHandler(this.exitBtn_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.timeText = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 5:
            this.slider2 = ((System.Windows.Controls.Slider)(target));
            
            #line 41 "..\..\Player.xaml"
            this.slider2.LostMouseCapture += new System.Windows.Input.MouseEventHandler(this.slider2_LostMouseCapture);
            
            #line default
            #line hidden
            return;
            case 6:
            this.bar = ((System.Windows.Controls.StackPanel)(target));
            return;
            case 7:
            this.PlayButton = ((System.Windows.Controls.Button)(target));
            
            #line 44 "..\..\Player.xaml"
            this.PlayButton.Click += new System.Windows.RoutedEventHandler(this.PlayClick);
            
            #line default
            #line hidden
            return;
            case 8:
            this.pauseText = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 9:
            this.fullScreenButton = ((System.Windows.Controls.Button)(target));
            
            #line 48 "..\..\Player.xaml"
            this.fullScreenButton.Click += new System.Windows.RoutedEventHandler(this.fullScreenButton_Click);
            
            #line default
            #line hidden
            return;
            case 10:
            this.volumeSlider = ((System.Windows.Controls.Slider)(target));
            
            #line 51 "..\..\Player.xaml"
            this.volumeSlider.ValueChanged += new System.Windows.RoutedPropertyChangedEventHandler<double>(this.volumeSlider_ValueChanged);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}


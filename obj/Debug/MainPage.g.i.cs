﻿#pragma checksum "C:\Users\Sania_000\Documents\Visual Studio 2013\Projects\Ruler\Ruler\MainPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "46A6504749B1140905094B9608828EAA"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34014
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Microsoft.Phone.Controls;
using System;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Automation.Peers;
using System.Windows.Automation.Provider;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Resources;
using System.Windows.Shapes;
using System.Windows.Threading;


namespace Ruler {
    
    
    public partial class MainPage : Microsoft.Phone.Controls.PhoneApplicationPage {
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal System.Windows.Media.RotateTransform rotateTransform;
        
        internal System.Windows.Controls.Canvas Axes;
        
        internal System.Windows.Controls.Canvas CanvasForTouching;
        
        internal System.Windows.Controls.Button unitOfMeasurement;
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Windows.Application.LoadComponent(this, new System.Uri("/Ruler;component/MainPage.xaml", System.UriKind.Relative));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.rotateTransform = ((System.Windows.Media.RotateTransform)(this.FindName("rotateTransform")));
            this.Axes = ((System.Windows.Controls.Canvas)(this.FindName("Axes")));
            this.CanvasForTouching = ((System.Windows.Controls.Canvas)(this.FindName("CanvasForTouching")));
            this.unitOfMeasurement = ((System.Windows.Controls.Button)(this.FindName("unitOfMeasurement")));
        }
    }
}


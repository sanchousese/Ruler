using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using Ruler.Resources;
using System.Windows.Input;
using Microsoft.Phone.Info;
using System.Windows.Shapes;
using System.Windows.Media;
using Ruler.view;

namespace Ruler
{
    public partial class MainPage : PhoneApplicationPage
    {

        public MainPage()
        {
            InitializeComponent();
            DrawAxes.drawAxes(Axes);
            this.OrientationChanged += new EventHandler<OrientationChangedEventArgs>(OnOrientationChanged);
            Touch.FrameReported += new TouchFrameEventHandler(Touch_FrameReported);

        }

        private void Touch_FrameReported(object sender, TouchFrameEventArgs e)
        {
            int pointsNumber = e.GetTouchPoints(Axes).Count;
            TouchPointCollection pointCollection = e.GetTouchPoints(Axes);
        }

        private void OnOrientationChanged(object sender, OrientationChangedEventArgs e)
        {
            if (e.Orientation == PageOrientation.LandscapeRight)
                rotateTransform.Angle = 180;
            else
                rotateTransform.Angle = 0;

        }


    }
}
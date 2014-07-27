using Microsoft.Phone.Controls;
using Ruler.view;
using System;
using System.Windows;
using System.Windows.Input;

namespace Ruler
{
    public partial class MainPage : PhoneApplicationPage
    {

        private bool isInch = true;
        private bool isDrawingAble = true;


        public MainPage()
        {
            InitializeComponent();
            initDrawing();
            Touch.FrameReported += new TouchFrameEventHandler(Touch_FrameReported);
        }

        private void initDrawing()
        {
            Axes.Children.Clear();
            DrawAxes.drawAxes(Axes, isInch);
            Touching.setDpi(DrawAxes.getDpi());
            Touching.setCanvas(CanvasForTouching);
        }

        private void Touch_FrameReported(object sender, TouchFrameEventArgs e)
        {
            if (isDrawingAble)
            {
                int pointsNumber = e.GetTouchPoints(CanvasForTouching).Count;
                TouchPointCollection pointCollection = e.GetTouchPoints(CanvasForTouching);

                if (pointsNumber == 1)
                {
                    Touching.drawTouching(pointCollection[0].Position);
                }
                else
                {
                    Touching.drawSeveralTouches(pointCollection[0].Position, pointCollection[1].Position);
                }
            }
        }

        private void unitOfMeasurement_MouseEnter(object sender, MouseEventArgs e)
        {
            isDrawingAble = false;
        }

        private void unitOfMeasurement_MouseLeave(object sender, MouseEventArgs e)
        {
            isDrawingAble = true;
        }

        private void unitOfMeasurement_Click(object sender, RoutedEventArgs e)
        {
            isInch = !isInch;
            unitOfMeasurement.Content = isInch ? "inch" : "cm";
            initDrawing();
        }
    }
}
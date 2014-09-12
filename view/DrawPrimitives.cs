using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;

namespace Ruler.view
{
    class DrawPrimitives
    {
        protected static Canvas canvas;
        protected static double dpi;
        private const double radiusPoint = 30;

        protected static void drawLine(double X1, double Y1, double X2, double Y2)
        {
            Line line = new Line();
            line.Stroke = new SolidColorBrush(Colors.Black);

            line.X1 = X1;
            line.Y1 = Y1;
            line.X2 = X2;
            line.Y2 = Y2;
            canvas.Children.Add(line);
        }

        protected static void drawLine(double X1, double Y1, double X2, double Y2, bool isTouching)
        {
            Line line = new Line();
            line.Stroke = new SolidColorBrush(Colors.Red);
            line.Opacity = 0.5;
            line.StrokeThickness = 5;
            line.X1 = X1;
            line.Y1 = Y1;
            line.X2 = X2;
            line.Y2 = Y2;
            canvas.Children.Add(line);
        }


        protected static void drawPoint(Point point)
        {
            Ellipse ellipse = new Ellipse();
            ellipse.Fill = new SolidColorBrush(Colors.Red);
            ellipse.Width = radiusPoint;
            ellipse.Height = radiusPoint;
            Canvas.SetLeft(ellipse, point.X - radiusPoint / 2);
            Canvas.SetTop(ellipse, point.Y - radiusPoint / 2);
            canvas.Children.Add(ellipse);
        }


        protected static void drawText(string text, double x, double y)
        {
            TextBlock number = new TextBlock();
            number.Text = "\t" + text;
            number.Foreground = new SolidColorBrush(Colors.Black);
            number.Margin = new Thickness(x - number.ActualWidth / 2, y + number.ActualHeight/2, 0, 0);

            canvas.Children.Add(number);

        }

        protected static void drawText(string text, double x, double y, int angle)
        {
            TextBlock number = new TextBlock();
            number.Text = "\t" + text;
            number.Foreground = new SolidColorBrush(Colors.Black);
            number.Margin = new Thickness(x - number.ActualWidth / 2, y + number.ActualHeight / 2, 0, 0);

            canvas.Children.Add(number);
        }

        protected static void drawText(string text, double x, double y, bool isRotate)
        {
            TextBlock number = new TextBlock();
            number.Text = "\t" + text;
            number.Foreground = new SolidColorBrush(Colors.Black);
            number.Margin = new Thickness(x + number.ActualHeight*2, y - number.ActualHeight, 0, 0);
            RotateTransform rotate = new RotateTransform();
            rotate.Angle = 90;
            number.RenderTransform = rotate;

            canvas.Children.Add(number);

            TextBlock number1 = new TextBlock();
            number1.Text = "\t" + text;
            number1.Foreground = new SolidColorBrush(Colors.Black);
            number1.Margin = new Thickness(x - number1.ActualHeight*2, y + 2 * number1.ActualHeight, 0, 0);
            RotateTransform rotate1 = new RotateTransform();
            rotate1.Angle = 270;
            number1.RenderTransform = rotate1;

            canvas.Children.Add(number1);
        }


        public static void setCanvas(Canvas canva) { canvas = canva; }
    }
}

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

        protected static void drawPoint(Point point)
        {
            Ellipse ellipse = new Ellipse();
            ellipse.Fill = new SolidColorBrush(Colors.Green);
            ellipse.Width = radiusPoint;
            ellipse.Height = radiusPoint;
            Canvas.SetLeft(ellipse, point.X - radiusPoint / 2);
            Canvas.SetTop(ellipse, point.Y - radiusPoint / 2);
            canvas.Children.Add(ellipse);
        }


        protected static void drawText(string text, double x, double y)
        {
            TextBlock number = new TextBlock();
            number.Text = text;
            number.Foreground = new SolidColorBrush(Colors.Black);
            number.Margin = new Thickness(x - number.ActualWidth / 2, y - number.ActualHeight, 0, 0);



            Rectangle rectangle = new Rectangle();
            rectangle.Fill = new SolidColorBrush(Colors.White);
            rectangle.Width = number.ActualWidth * 2;
            rectangle.Height = number.ActualWidth;
            rectangle.Margin = new Thickness(x - number.ActualHeight / 2, y - number.ActualHeight, 0, 0);

            canvas.Children.Add(rectangle);
            canvas.Children.Add(number);
        }

        protected static void drawText(string text, double x, double y, bool isRotate)
        {
            TextBlock number = new TextBlock();
            number.Text = text;
            number.Foreground = new SolidColorBrush(Colors.Black);
            number.Margin = new Thickness(x + number.ActualHeight, y - number.ActualHeight, 0, 0);
            RotateTransform rotate = new RotateTransform();
            rotate.Angle = 90;
            number.RenderTransform = rotate;

            Rectangle rectangle = new Rectangle();
            rectangle.Fill = new SolidColorBrush(Colors.White);
            rectangle.Width = number.ActualWidth * 2;
            rectangle.Height = number.ActualWidth;
            rectangle.Margin = new Thickness(x + number.ActualHeight, y - number.ActualHeight, 0, 0);
            rectangle.RenderTransform = rotate;

            canvas.Children.Add(rectangle);
            canvas.Children.Add(number);
        }


        public static void setCanvas(Canvas canva) { canvas = canva; }
    }
}

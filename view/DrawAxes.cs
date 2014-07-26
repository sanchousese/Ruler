using Microsoft.Phone.Info;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;

namespace Ruler.view
{
    class DrawAxes
    {
        private static double dpi;
        private static double realWidth;
        private static double realHeight;
        private static Canvas canvas;


        public static void drawAxes(Canvas canva)
        {
            canvas = canva;

            initSizes();

            drawAxeX();

            drawAxeY();
        }

        private static void drawAxeY()
        {
            for (int i = 1; dpi * i <= realWidth; i++)
            {
                drawLine(i, 0, dpi * i, realWidth / 8, dpi * i);

                if (i > 1)
                {
                    drawText(i, realWidth / 6, dpi * i);
                }
            }

            double littleDpi = dpi / 10;

            for (int i = 1; littleDpi * i <= realWidth; i++)
                if (littleDpi * i >= realWidth / 10)
                    drawLine(i, 0, littleDpi * i, realWidth / 10, littleDpi * i);


        }

        private static void drawAxeX()
        {
            for (int i = 1; dpi * i <= realHeight; i++)
            {
                drawLine(i, dpi * i, 0, dpi * i, realWidth / 8);

                drawText(i, dpi * i, realWidth / 6);
            }

            double littleDpi = dpi / 10;

            for (int i = 1; littleDpi * i <= realHeight; i++)
                if (littleDpi * i >= realWidth / 10)
                    drawLine(i, littleDpi * i, 0, littleDpi * i, realWidth / 10);

        }

        private static void drawLine(int i, double X1, double Y1, double X2, double Y2)
        {
            Line line = new Line();
            line.Stroke = new SolidColorBrush(Colors.Black);
            line.X1 = X1;
            line.Y1 = Y1;
            line.X2 = X2;
            line.Y2 = Y2;
            canvas.Children.Add(line);
        }

        private static void drawText(int i, double x, double y)
        {
            TextBlock number = new TextBlock();
            number.Text = i + "";
            number.Foreground = new SolidColorBrush(Colors.Black);
            number.Margin = new Thickness(x - number.ActualWidth / 2, y - number.ActualHeight, 0, 0);
            canvas.Children.Add(number);
        }

        private static void initSizes()
        {
            object temp;
            DeviceExtendedProperties.TryGetValue("PhysicalScreenResolution", out temp);
            var screenResolution = (Size)temp;
            realHeight = screenResolution.Height;
            realWidth = screenResolution.Width;

            DeviceExtendedProperties.TryGetValue("RawDpiX", out temp);
            dpi = (double)temp / 2.54;
        }
    }
}

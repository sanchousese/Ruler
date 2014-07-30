using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace Ruler.view
{
    class Touching : DrawPrimitives
    {
        public static void drawTouching(Point point)
        {
            canvas.Children.Clear();

            showPoint(point);

            drawText((Math.Round(point.X / dpi, 2)).ToString(), point.X / 2, point.Y);
            drawText((Math.Round(point.Y / dpi, 2)).ToString(), point.X, point.Y / 2, true);
        }

        public static void drawSeveralTouches(Point first, Point second)
        {
            canvas.Children.Clear();

            showPoint(first);
            showPoint(second);


            if (Math.Abs(first.X - second.X) >= 30)
            {
                double scaleX = Math.Round(Math.Abs((first.X - second.X) / dpi), 1);
                double coordX = Math.Min(first.X, second.X) + Math.Abs(first.X - second.X) / 2;
                drawText(scaleX + "", coordX, Math.Max(first.Y, second.Y));
            }

            if (Math.Abs(first.Y - second.Y) >= 30)
            {
                double scaleY = Math.Round(Math.Abs((first.Y - second.Y) / dpi), 1);
                double coordY = Math.Min(first.Y, second.Y) + Math.Abs(first.Y - second.Y) / 2;
                drawText(scaleY + "", Math.Max(first.X, second.X), coordY, true);
            }
        }

        private static void showPoint(Point point)
        {
            drawLine(0, point.Y, canvas.Height, point.Y);
            drawLine(point.X, 0, point.X, canvas.Width);

            drawPoint(point);
        }

        public static void setDpi(double d) { dpi = d; }
    }
}

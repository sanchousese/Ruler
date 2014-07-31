using Microsoft.Phone.Info;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;

namespace Ruler.view
{
    internal class DrawAxes : DrawPrimitives
    {
        private static bool isDpiInInch;
        private static double realWidth;
        private static double realHeight;

        public static void drawAxes(Canvas canva, bool isInch)
        {
            setCanvas(canva);
            isDpiInInch = isInch;
            initSizes();
            drawAxeX();
            drawAxeY();
        }

        private static void drawAxeY()
        {
            for (int i = 1; dpi * i <= realHeight; i++)
            {
                if (dpi * i >= realWidth / 8)
                {
                    drawLine(0, dpi * i, realWidth / 8, dpi * i);

                    drawText(i.ToString(), realWidth / 6, dpi * i);
                }
            }

            double littleDpi = dpi / 10;

            for (int i = 1; littleDpi * i <= realHeight; i++)
                if (littleDpi * i >= realWidth / 10)
                    drawLine(0, littleDpi * i, realWidth / 10, littleDpi * i);
        }

        private static void drawAxeX()
        {
            for (int i = 1; dpi * i <= realWidth; i++)
            {
                if (dpi * i >= realWidth / 8)
                {
                    drawLine(dpi * i, 0, dpi * i, realWidth / 8);

                    drawText(i.ToString(), dpi * i, realWidth / 6);

                }
            }

            double littleDpi = dpi / 10;

            for (int i = 1; littleDpi * i <= realWidth; i++)
                if (littleDpi * i >= realWidth / 10)
                    drawLine(littleDpi * i, 0, littleDpi * i, realWidth / 10);
        }

        private static void initSizes()
        {
            object temp;
            DeviceExtendedProperties.TryGetValue("PhysicalScreenResolution", out temp);
            var screenResolution = (Size)temp;

            DeviceExtendedProperties.TryGetValue("RawDpiX", out temp);
            dpi = (isDpiInInch ? (double)temp : (double)temp / 2.54) * canvas.Height / screenResolution.Height;
            realWidth = canvas.Height;
            realHeight = canvas.Width;

        }

        public static double getDpi() { return dpi; }
    }
}
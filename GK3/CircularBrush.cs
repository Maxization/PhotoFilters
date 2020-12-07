using GK3.Filters;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GK3
{
    public static class CircularBrush
    {
        public static int width = 30;
        public static int height = 30;

        public static void Fill(DirectBitmap actualBm, DirectBitmap orginalBm, IFilter filter, FilterType filterType, int X, int Y)
        {
            int Width = actualBm.Width;
            int Height = actualBm.Height;

            int hh = height * height;
            int ww = width * width;
            int hhww = hh * ww;
            int x0 = width;
            int dx = 0;

            for (int x = -width; x <= width; x++)
                if (X + x < Width && X + x >= 0)
                {
                    Color color = orginalBm.GetPixel(X + x, Y);
                    Color col = filter.Handle(filterType, color);
                    actualBm.SetPixel(X + x, Y, col);
                }


            for (int y = 1; y <= height; y++)
            {
                int x1 = x0 - (dx - 1);
                for (; x1 > 0; x1--)
                    if (x1 * x1 * hh + y * y * ww <= hhww)
                        break;
                dx = x0 - x1;
                x0 = x1;

                for (int x = -x0; x <= x0; x++)
                {
                    if (X + x < Width && X + x >= 0)
                    {
                        if (Y - y < Height && Y - y >= 0)
                        {
                            Color color = orginalBm.GetPixel(X + x, Y - y);
                            Color col = filter.Handle(filterType, color);
                            actualBm.SetPixel(X + x, Y - y, col);

                        }
                        if (Y + y < Height && Y + y >= 0)
                        {
                            Color color = orginalBm.GetPixel(X + x, Y + y);
                            Color col = filter.Handle(filterType, color);
                            actualBm.SetPixel(X + x, Y + y, col);
                        }
                    }
                }
            }
        }
    }
}

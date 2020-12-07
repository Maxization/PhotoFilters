using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GK3.Filters
{
    public class BrightnessChangeFilter : BaseFilter
    {
        FilterType filterType = FilterType.BrightnessChange;
        int d = 50;

        public void Add()
        {
            if (d < 255)
            {
                d += 40;
                d = Math.Min(d, 255);
            }
        }

        public void Sub()
        {
            if (d > -255)
            {
                d -= 40;
                d = Math.Max(d, -255);
            }
        }
        public override Color Handle(FilterType type, Color color)
        {
            if (filterType == type)
            {
                int R = color.R + d;
                if (R > 255) R = 255;
                if (R < 0) R = 0;

                int G = color.G + d;
                if (G > 255) G = 255;
                if (G < 0) G = 0;

                int B = color.B + d;
                if (B > 255) B = 255;
                if (B < 0) B = 0;

                return Color.FromArgb(R, G, B);
            }

            if (next != null)
                return next.Handle(type, color);
            return base.Handle(type, color);
        }
    }
}

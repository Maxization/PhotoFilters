using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GK3.Filters
{
    public class ContrastFilter : BaseFilter
    {
        FilterType filterType = FilterType.Contrast;
        int d = 50;

        public void Add()
        {
            if (d < 127)
            {
                d += 20;
                d = Math.Min(127, d);
            }
        }

        public void Sub()
        {
            if (d > 0)
            {
                d -= 20;
                d = Math.Max(0, d);
            }
        }

        public override Color Handle(FilterType type, Color color)
        {
            if (filterType == type)
            {
                double fA = 255f / (255f - 2f * d);
                double fB = (-255f * d) / (255f - 2 * d);

                int R = color.R;
                if (R < d) R = 0;
                else if (R > 255 - d) R = 255;
                else R = (int)(fA * R + fB);


                int G = color.G;
                if (G < d) G = 0;
                else if (G > 255 - d) G = 255;
                else G = (int)(fA * G + fB);


                int B = color.B;
                if (B < d) B = 0;
                else if (B > 255 - d) B = 255;
                else B = (int)(fA * B + fB);


                return Color.FromArgb(R, G, B);
            }

            if (next != null)
                return next.Handle(type, color);
            return base.Handle(type, color);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GK3.Filters
{
    public class GammaCorrectionFilter : BaseFilter
    {
        FilterType filterType = FilterType.GammaCorrection;
        double gamma = 2;

        public void Add()
        {
            gamma *= 2;
        }

        public void Sub()
        {
            gamma /= 2;
        }
        public override Color Handle(FilterType type, Color color)
        {
            if (filterType == type)
            {

                double R = color.R / 255f;
                R = Math.Pow(R, gamma);

                double G = color.G / 255f;
                G = Math.Pow(G, gamma);

                double B = color.B / 255f;
                B = Math.Pow(B, gamma);


                return Color.FromArgb((int)(255 * R), (int)(255 * G), (int)(255 * B));
            }

            if (next != null)
                return next.Handle(type, color);
            return base.Handle(type, color);
        }
    }
}

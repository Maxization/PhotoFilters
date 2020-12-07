using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GK3.Filters
{
    public class NegationFilter : BaseFilter
    {
        FilterType filterType = FilterType.Negation;

        public override Color Handle(FilterType type, Color color)
        {
            if (filterType == type)
            {
                int R = 255 - color.R;
                int G = 255 - color.G;
                int B = 255 - color.B;
                return Color.FromArgb(R, G, B);
            }

            if (next != null)
                return next.Handle(type, color);
            return base.Handle(type, color);
        }
    }
}

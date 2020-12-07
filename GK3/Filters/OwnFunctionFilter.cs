using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GK3.Filters
{
    public class OwnFunctionFilter : BaseFilter
    {
        FilterType filterType = FilterType.OwnFunction;
        Vertex[] ownFunction;
        public OwnFunctionFilter(Vertex[] ownFunction)
        {
            this.ownFunction = ownFunction;
        }

        public override Color Handle(FilterType type, Color color)
        {
            if (filterType == type)
            {
                int R = color.R;
                int G = color.G;
                int B = color.B;

                bool bR, bG, bB;
                bR = bG = bB = false;

                for (int i = 1; i < ownFunction.Length; i++)
                {
                    if (bR && bG && bB) break;

                    double fA = (double)(ownFunction[i - 1].Y - ownFunction[i].Y) / (double)(ownFunction[i - 1].X - ownFunction[i].X);
                    double fB = ownFunction[i - 1].Y - fA * ownFunction[i - 1].X;

                    if (ownFunction[i - 1].X < R && ownFunction[i].X > R && !bR)
                    {
                        bR = true;
                        R = (int)(fA * ownFunction[i - 1].X + fB);
                    }

                    if (ownFunction[i - 1].X < G && ownFunction[i].X > G && !bG)
                    {
                        bG = true;
                        G = (int)(fA * ownFunction[i - 1].X + fB);
                    }

                    if (ownFunction[i - 1].X < B && ownFunction[i].X > B && !bB)
                    {
                        bB = true;
                        B = (int)(fA * ownFunction[i - 1].X + fB);
                    }
                }

                return Color.FromArgb(R, G, B);
            }

            if (next != null)
                return next.Handle(type, color);
            return base.Handle(type, color);
        }
    }
}

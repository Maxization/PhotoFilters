using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GK3.Filters
{
    public interface IFilter
    {
        Color Handle(FilterType type, DirectBitmap b, int x, int y);
        void setNext(IFilter filter);
    }

    public abstract class BaseFilter : IFilter
    {
        protected IFilter next;
        public virtual Color Handle(FilterType type, DirectBitmap b, int x, int y)
        {
            return b.GetPixel(x, y);
        }
        public void setNext(IFilter filter)
        {
            next = filter;
        }
    }

    public class NegationFilter : BaseFilter
    {
        FilterType filterType = FilterType.Negation;

        public override Color Handle(FilterType type, DirectBitmap b, int x, int y)
        {
            if(filterType == type)
            {
                Color col = b.GetPixel(x, y);
                int R = 255 - col.R;
                int G = 255 - col.G;
                int B = 255 - col.B;
                return Color.FromArgb(R, G, B);
            }

            if (next != null)
                return next.Handle(type, b, x, y);
            return base.Handle(type, b, x, y);
        }
    }

    public class BrightnessChangeFilter : BaseFilter
    {
        FilterType filterType = FilterType.BrightnessChange;
        int d = 50;
        public override Color Handle(FilterType type, DirectBitmap b, int x, int y)
        {
            if(filterType == type)
            {
                Color col = b.GetPixel(x, y);
                int R = col.R + d;
                if (R > 255) R = 255;
                if (R < 0) R = 0;

                int G = col.G + d;
                if (G > 255) G = 255;
                if (G < 0) G = 0;

                int B = col.B + d;
                if (B > 255) B = 255;
                if (B < 0) B = 0;

                return Color.FromArgb(R, G, B);
            }

            if (next != null)
                return next.Handle(type, b, x, y);
            return base.Handle(type, b, x, y);
        }
    }

    public class ContrastFilter : BaseFilter
    {
        FilterType filterType = FilterType.Contrast;
        int d = 50;

        public override Color Handle(FilterType type, DirectBitmap b, int x, int y)
        {
            if (filterType == type)
            {
                double fA = 255f/(255f - 2f*d);
                double fB = (-255f * d) / (255f - 2 * d);

                Color col = b.GetPixel(x, y);

                int R = col.R;
                if (R < d) R = 0;
                else if (R > 255 - d) R = 255;
                else R = (int)(fA * R + fB);


                int G = col.G;
                if (G < d) G = 0;
                else if (G > 255 - d) G = 255;
                else G = (int)(fA * G + fB);


                int B = col.B;
                if (B < d) B = 0;
                else if (B > 255 - d) B = 255;
                else B = (int)(fA * B + fB);


                return Color.FromArgb(R, G, B);
            }

            if (next != null)
                return next.Handle(type, b, x, y);
            return base.Handle(type, b, x, y);
        }
    }

    public class GammaCorrectionFilter : BaseFilter
    {
        FilterType filterType = FilterType.GammaCorrection;
        double gamma = 2;
        public override Color Handle(FilterType type, DirectBitmap b, int x, int y)
        {
            if (filterType == type)
            {
                Color col = b.GetPixel(x, y);

                double R = col.R / 255f;
                R = Math.Pow(R, gamma);

                double G = col.G / 255f;
                G = Math.Pow(G, gamma);

                double B = col.B / 255f;
                B = Math.Pow(B, gamma);


                return Color.FromArgb((int)(255 * R), (int)(255 * G), (int)(255 * B));
            }

            if (next != null)
                return next.Handle(type, b, x, y);
            return base.Handle(type, b, x, y);
        }
    }
}

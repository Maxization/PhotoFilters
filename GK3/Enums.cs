using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GK3
{
    enum ModeType
    {
        AddPolygon,
        Brush,
        DeletePolygon,
        TheWholePicture,
    }

    public enum FilterType
    {
        NoFilter,
        Negation,
        BrightnessChange,
        GammaCorrection,
        Contrast,
        OwnFunction
    }
}

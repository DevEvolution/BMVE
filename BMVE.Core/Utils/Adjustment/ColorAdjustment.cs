using SkiaSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMVE.Core.Utils.Adjustment
{
    internal static class ColorAdjustment
    {
        internal static SKColor IntRGBToColor(int value)
        {
            byte[] bytes = ConverterAdjustment.IntToByteArray(value);

            return new SKColor(bytes[2], bytes[1], bytes[0], bytes[3]); // SKColor.FromArgb(bytes[3], bytes[2], bytes[1], bytes[0]);
        }
    }
}

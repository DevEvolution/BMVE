using BMVE.Core.Utils.Utils;
using SkiaSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;

namespace BMVE.Core.Utils.State
{
    internal static class ScreenState
    {
        internal static SKColor BackgroundColor = SKColors.Black;

        internal static SKColor ForegroundColor = SKColors.White;

        internal static FontInfo CurrentFont = new FontInfo()
        {
            Family = "Arial",
            Size = 16.0,
            Stretch = FontStretches.Normal,
            Style = FontStyles.Normal, 
            Weight = FontWeights.Normal
        };

        internal static int ScreenWidth;

        internal static int ScreenHeight;
    }
}

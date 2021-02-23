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
        internal static SKColor BackgroundColor = new SKColor(0xFF101010);

        internal static SKColor ForegroundColor = SKColors.White;
        
        internal static int BorderThickness = 1;

        internal static FontInfo CurrentFont = new FontInfo()
        {
            Family = "Century Gothic",
            Size = 20.0,
            Stretch = FontStretches.Normal,
            Style = FontStyles.Normal, 
            Weight = FontWeights.Normal
        };

        internal static int ScreenWidth;

        internal static int ScreenHeight;
    }
}

using BMVE.Core.Drawable.Primitives;
using BMVE.Core.Utils.Adjustment;
using BMVE.Core.Utils.Drawing;
using BMVE.Core.Utils.State;
using SkiaSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace BMVE.Core.Commands
{
    internal static class TextProxy
    {
        internal static void Text_SetFont(string fontFamily)
        {
            ScreenState.CurrentFont.Family = fontFamily;
        }

        internal static void Text_SetFontSize(double fontSize)
        {
            ScreenState.CurrentFont.Size = fontSize;
        }

        internal static void Text_SetFontNormal()
        {
            ScreenState.CurrentFont.Weight = FontWeights.Normal;
            ScreenState.CurrentFont.Style = FontStyles.Normal;
        }

        internal static void Text_SetFontBold()
        {
            ScreenState.CurrentFont.Weight = FontWeights.Bold;
            ScreenState.CurrentFont.Style = FontStyles.Normal;
        }

        internal static void Text_SetFontItalic()
        {
            ScreenState.CurrentFont.Weight = FontWeights.Normal;
            ScreenState.CurrentFont.Style = FontStyles.Italic;
        }

        internal static void Text_SetFontBoldItalic()
        {
            ScreenState.CurrentFont.Weight = FontWeights.Bold;
            ScreenState.CurrentFont.Style = FontStyles.Italic;
        }

        internal static string Text_GetFont()
        {
            return ScreenState.CurrentFont.Family;
        }

        internal static double Text_GetFontSize()
        {
            return ScreenState.CurrentFont.Size;
        }
    }
}

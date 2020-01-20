using BMVE.Core.Drawable.Primitives;
using BMVE.Core.Utils.Adjustment;
using BMVE.Core.Utils.Drawing;
using BMVE.Core.Utils.State;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMVE.Core.Commands
{
    internal static class DrawingProxy
    {
        internal static void Draw_Line(int x, int y, int width, int height, int color)
        {
            DrawingPipeline.Add(new UILine
            {
                X = x,
                Y = y,
                X1 = x + width,
                Y1 = y + height,
                ForegroundColor = ColorAdjustment.IntRGBToColor(color)
            });
        }

        internal static void Draw_Rectangle(int x, int y, int width, int height, int color)
        {
            DrawingPipeline.Add(new UIRectangle
            {
                X = x,
                Y = y,
                Width = width,
                Height = height,
                ForegroundColor = ColorAdjustment.IntRGBToColor(color)
            });
        }

        internal static void Draw_Rectangle(int x, int y, int width, int height, int foregroundColor, int backgroundColor)
        {
            DrawingPipeline.Add(new UIRectangle
            {
                X = x,
                Y = y,
                Width = width,
                Height = height,
                ForegroundColor = ColorAdjustment.IntRGBToColor(foregroundColor),
                BackgroundColor = ColorAdjustment.IntRGBToColor(backgroundColor)
            });
        }

        internal static void Draw_Ellipse(int x, int y, int width, int height, int color)
        {
            int halfWidth = width / 2,
                halfHeight = height / 2;
            DrawingPipeline.Add(new UIEllipse
            {
                X = x + halfWidth,
                Y = y + halfHeight,
                Width = halfWidth,
                Height = halfHeight,
                ForegroundColor = ColorAdjustment.IntRGBToColor(color)
            });
        }

        internal static void Draw_Ellipse(int x, int y, int width, int height, int foregroundColor, int backgroundColor)
        {
            int halfWidth = width / 2,
                halfHeight = height / 2;
            DrawingPipeline.Add(new UIEllipse
            {
                X = x + halfWidth,
                Y = y + halfHeight,
                Width = halfWidth,
                Height = halfHeight,
                ForegroundColor = ColorAdjustment.IntRGBToColor(foregroundColor),
                BackgroundColor = ColorAdjustment.IntRGBToColor(backgroundColor)
            });
        }

        internal static int RGB(byte r, byte g, byte b)
        {
            return ConverterAdjustment.BytesToInt(new byte[] { 0xff, r, g, b });
        }

        internal static void Screen_SetBackgroundColor(int color)
        {
            ScreenState.BackgroundColor = ColorAdjustment.IntRGBToColor(color);
        }

        internal static void Screen_SetForegroundColor(int color)
        {
            ScreenState.ForegroundColor = ColorAdjustment.IntRGBToColor(color);
        }

        internal static void Screen_Clear()
        {
            DrawingPipeline.Clear();
        }

        internal static void Screen_SetRefreshRateFPS(int fps)
        {
            DrawingPipeline.RefreshRate = fps;
        }

        internal static int Screen_GetRefreshRateFPS()
        {
            return DrawingPipeline.RefreshRate;
        }

        internal static void Screen_Render()
        {
            DrawingPipeline.BufferingRender();
        }
    }
}

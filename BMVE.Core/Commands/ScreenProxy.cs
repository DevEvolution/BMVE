using BMVE.Core.Drawable.Primitives;
using BMVE.Core.Enums;
using BMVE.Core.Utils.Adjustment;
using BMVE.Core.Utils.Drawing;
using BMVE.Core.Utils.State;
using BMVE.Core.Utils.Utils;
using SkiaSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMVE.Core.Commands
{
    internal static class ScreenProxy
    {
        internal static void Screen_DrawText(int x, int y, string text)
        {
            DrawText(text, x, y, ScreenState.ForegroundColor);
        }

        internal static void Screen_DrawText(int x, int y, string text, int color)
        {
            DrawText(text, x, y, ColorAdjustment.IntRGBToColor(color));
        }

        internal static void Screen_SetLineSize(int size)
        {
            AssertLineHasCorrectWidth(size);

            ScreenState.BorderThickness = size;
        }

        internal static int Screen_GetLineSize() => ScreenState.BorderThickness;

        internal static void Screen_DrawLine(int x, int y, int width, int height, int color)
        {
            DrawingPipeline.Add(new UILine
            {
                X = x,
                Y = y,
                X1 = x + width,
                Y1 = y + height,
                ForegroundColor = ColorAdjustment.IntRGBToColor(color),
                BorderThickness = ScreenState.BorderThickness
            });
        }

        internal static void Screen_DrawRectangle(int x, int y, int width, int height, int color)
        {
            DrawingPipeline.Add(new UIRectangle
            {
                X = x,
                Y = y,
                Width = width,
                Height = height,
                ForegroundColor = ColorAdjustment.IntRGBToColor(color),
                BorderThickness = ScreenState.BorderThickness
            });
        }

        internal static void Screen_DrawRectangle(int x, int y, int width, int height, int foregroundColor, int backgroundColor)
        {
            DrawingPipeline.Add(new UIRectangle
            {
                X = x,
                Y = y,
                Width = width,
                Height = height,
                ForegroundColor = ColorAdjustment.IntRGBToColor(foregroundColor),
                BackgroundColor = ColorAdjustment.IntRGBToColor(backgroundColor),
                BorderThickness = ScreenState.BorderThickness
            });
        }

        internal static void Screen_DrawEllipse(int x, int y, int width, int height, int color)
        {
            int halfWidth = width / 2,
                halfHeight = height / 2;
            DrawingPipeline.Add(new UIEllipse
            {
                X = x + halfWidth,
                Y = y + halfHeight,
                Width = halfWidth,
                Height = halfHeight,
                ForegroundColor = ColorAdjustment.IntRGBToColor(color),
                BorderThickness = ScreenState.BorderThickness
            });
        }

        internal static void Screen_DrawEllipse(int x, int y, int width, int height, int foregroundColor, int backgroundColor)
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
                BackgroundColor = ColorAdjustment.IntRGBToColor(backgroundColor),
                BorderThickness = ScreenState.BorderThickness
            });
        }

        internal static void Screen_DrawImage(int number, int x, int y)
        {
            AssertImageIsOpen(number);

            var socket = ManagedSocketResolver
                .ImageSocket
                .GetSocket(number);

            DrawingPipeline.Add(new UIImage()
            {
                X = x,
                Y = y,
                Width = socket.Image.Width,
                Height = socket.Image.Height,
                Image = socket
            });
        }

        internal static void Screen_DrawImage(int number, int x, int y, int width, int height)
        {
            AssertImageIsOpen(number);

            var socket = ManagedSocketResolver
                .ImageSocket
                .GetSocket(number);

            DrawingPipeline.Add(new UIImage()
            {
                X = x,
                Y = y,
                Width = width,
                Height = height,
                Image = socket
            });
        }

        internal static int RGB(byte r, byte g, byte b)
        {
            return ConverterAdjustment.BytesToInt(new byte[] { 0xff, r, g, b });
        }

        internal static int RGBA(byte r, byte g, byte b, byte a)
        {
            return ConverterAdjustment.BytesToInt(new byte[] { a, r, g, b });
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

        internal static void Screen_SetDrawingMode(RenderingMode mode)
        {
            DrawingPipeline.RenderingMode = mode;
        }

        internal static RenderingMode Screen_GetDrawingMode()
        {
            return DrawingPipeline.RenderingMode;
        }

        private static void DrawText(string text, int x, int y, SKColor color)
        {
            var font = new Utils.Utils.FontInfo()
            {
                Family = ScreenState.CurrentFont.Family,
                Size = ScreenState.CurrentFont.Size,
                Stretch = ScreenState.CurrentFont.Stretch,
                Weight = ScreenState.CurrentFont.Weight,
                Style = ScreenState.CurrentFont.Style
            };

            DrawingPipeline.Add(new UIText()
            {
                Text = text,
                X = x,
                Y = y,
                ForegroundColor = color,
                FontInfo = new Utils.Utils.FontInfo()
                {
                    Family = ScreenState.CurrentFont.Family,
                    Size = ScreenState.CurrentFont.Size,
                    Stretch = ScreenState.CurrentFont.Stretch,
                    Weight = ScreenState.CurrentFont.Weight,
                    Style = ScreenState.CurrentFont.Style
                }
            });
        }

        private static void AssertImageIsOpen(int number)
        {
            if (!ManagedSocketResolver.ImageSocket.IsSocketBusy(number))
            {
                throw new Exception($"Изображение №{number} не открыто");
            }
        }

        private static void AssertLineHasCorrectWidth(int size)
        {
            if (size < 1)
            {
                throw new Exception("Размер линии не может быть меньше 1");
            }
        }
    }
}

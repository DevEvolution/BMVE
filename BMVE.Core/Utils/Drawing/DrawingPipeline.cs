using BMVE.Core.Drawable.Primitives;
using BMVE.Core.Enums;
using BMVE.Core.Interfaces;
using BMVE.Core.Utils.State;
using BMVE.Core.Utils.Utils;
using BMVE.Core.View;
using SkiaSharp;
using SkiaSharp.Views.Desktop;
using SkiaSharp.Views.WPF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace BMVE.Core.Utils.Drawing
{
    internal static class DrawingPipeline
    {
        private static LimitedConcurrentQueue<DrawingSnapshot> DrawingQueue = new LimitedConcurrentQueue<DrawingSnapshot>(60);

        internal static RenderingMode RenderingMode = RenderingMode.Immediate;

        internal static int RefreshRate { get => CodeView.GetRefreshFPSRate(); set => CodeView.SetRefreshFPSRate(value); }

        private static DrawingSnapshot CurrentSnapshot = new DrawingSnapshot();

        private static Topten.RichTextKit.TextBlock textBlock = new Topten.RichTextKit.TextBlock();
        

        private static bool TryGetSnapshot(out DrawingSnapshot currentSnapshot)
        {
            return DrawingQueue.TryDequeue(out currentSnapshot);
        }

        internal static void Add(IDrawable drawable)
        {
            switch (RenderingMode)
            {
                case RenderingMode.Immediate:

                    CurrentSnapshot.Add(drawable);
                    DrawingQueue.Enqueue(CurrentSnapshot.Clone());
                    break;

                case RenderingMode.Buffered:
                    CurrentSnapshot.Add(drawable);
                    break;

                default:
                    break;
            }
        }

        internal static void Clear()
        {
            CurrentSnapshot.Clear();
        }

        internal static void BufferingRender()
        {
            DrawingQueue.Enqueue(CurrentSnapshot.Clone());
        }

        internal static void Render(SKElement sender, SKPaintSurfaceEventArgs args)
        {
            if (!TryGetSnapshot(out DrawingSnapshot currentSnapshot))
            {
                currentSnapshot = CurrentSnapshot;
            };// return;

            //if (currentSnapshot.DrawingPipe.Count == 0)
            //    return;

            SKSurface surface = args.Surface;
            SKCanvas session = surface.Canvas;

            // Settings
            //session.Antialiasing = CanvasAntialiasing.Antialiased;
            //session.TextAntialiasing = Microsoft.Graphics.Canvas.Text.CanvasTextAntialiasing.ClearType;

            //CanvasDevice device = CanvasDevice.GetSharedDevice();
            double screenWidth = sender.ActualWidth,
                screenHeight = sender.ActualHeight;
            //CanvasRenderTarget offscreen = new CanvasRenderTarget(device, (float)screenWidth, (float)screenHeight, 96);

            // Draw
            //using (CanvasDrawingSession ds = offscreen.CreateDrawingSession())
            //{
            // Console preparations
            int console_maxRowCount = (int)Math.Floor(screenHeight / MeasureStringHeight());
            LimitedQueue<string> console_outputQueue = new LimitedQueue<string>(console_maxRowCount);

            // Clear
            session.Clear(ScreenState.BackgroundColor);
            foreach (IDrawable drawable in currentSnapshot.DrawingPipe)
            {
                switch (drawable)
                {
                    case UIText text:
                        {
                            session.DrawText(text.Text, text.X, text.Y, new SKPaint()
                            {
                                Color = text.ForegroundColor,
                                Typeface = SKTypeface.FromFamilyName(text.FontInfo.Family),
                                TextSize = (float)text.FontInfo.Size
                            });

                            break;
                        }
                    case UIEllipse ellipse:
                        {
                            if (ellipse.BackgroundColor.HasValue)
                            {
                                session.DrawOval(ellipse.X, ellipse.Y, ellipse.Width, ellipse.Height, new SKPaint()
                                {
                                    Color = ellipse.BackgroundColor.Value,
                                    Style = SKPaintStyle.Fill
                                });
                            }

                            session.DrawOval(ellipse.X, ellipse.Y, ellipse.Width, ellipse.Height, new SKPaint()
                            {
                                Color = ellipse.ForegroundColor,
                                Style = SKPaintStyle.Stroke
                            });


                            //if (ellipse.BackgroundColor.HasValue)
                            //    ds.FillEllipse(ellipse.X, ellipse.Y, ellipse.Width, ellipse.Height, ellipse.BackgroundColor.Value);

                            //ds.DrawEllipse(ellipse.X, ellipse.Y, ellipse.Width, ellipse.Height, ellipse.ForegroundColor);
                            break;
                        }
                    case UIRectangle rectangle:
                        {
                            if (rectangle.BackgroundColor.HasValue)
                            { 
                                session.DrawRect(rectangle.X, rectangle.Y, rectangle.Width, rectangle.Height, new SKPaint()
                                {
                                    Color = rectangle.BackgroundColor.Value,
                                    Style = SKPaintStyle.Fill
                                });
                            }

                            session.DrawRect(rectangle.X, rectangle.Y, rectangle.Width, rectangle.Height, new SKPaint()
                            {
                                Color = rectangle.ForegroundColor,
                                Style = SKPaintStyle.Fill
                            });

                            //if (rectangle.BackgroundColor.HasValue)
                            //    ds.FillRectangle(rectangle.X, rectangle.Y, rectangle.Width, rectangle.Height, rectangle.BackgroundColor.Value);

                            //ds.DrawRectangle(rectangle.X, rectangle.Y, rectangle.Width, rectangle.Height, rectangle.ForegroundColor);
                            break;
                        }
                    case UILine line:
                        {
                            session.DrawLine(line.X, line.Y, line.X1, line.Y1, new SKPaint()
                            {
                                Color = line.ForegroundColor
                            });

                            //ds.DrawLine(line.X, line.Y, line.X1, line.Y1, line.ForegroundColor);
                            break;
                        }
                    case UIConsoleText consoleText:
                        {
                            console_outputQueue.Enqueue(consoleText.Text);
                            break;
                        }
                    case UIImage image:
                        {
                            var bounds = image.Image.TransformedImage.Info.Rect;
                            var width = image.Image.TransformedImage.Width;
                            var height = image.Image.TransformedImage.Height;
                            session.DrawBitmap(image.Image.TransformedImage, new SKRect(image.X, image.Y, image.X + image.Width, image.Y + image.Height));

                            //var bounds = image.Image.TransformedImage.GetBounds(ds);
                            //ds.DrawImage(image.Image.TransformedImage, new Rect(image.X + (image.Width - bounds.Width) / 2, image.Y + (image.Height - bounds.Height) / 2, bounds.Width, bounds.Height), bounds, 1, CanvasImageInterpolation.HighQualityCubic);
                            break;
                        }
                    default:
                        {
                            session.DrawText("Drawing error", 0, 0, new SKPaint()
                            {
                                Color = SKColors.Red
                            });
                            //ds.DrawText("Drawing error", 0, 0, Colors.Red);
                            break;
                        }
                }
            }

            textBlock.Clear();
            textBlock.MaxWidth = args.Info.Width;
            // Draw console
            StringBuilder console_textToDraw = new StringBuilder();
            while (console_outputQueue.Count > 0)
            {
                console_textToDraw.AppendLine(console_outputQueue.Dequeue());

            }
            
            textBlock.AddText(console_textToDraw.ToString(), new Topten.RichTextKit.Style() 
            {
                TextColor = ScreenState.ForegroundColor,
                FontFamily = ScreenState.CurrentFont.Family,
                FontSize = (float)ScreenState.CurrentFont.Size
            });
            textBlock.Paint(session);

            // SKIA FUCKED UP
            //session.DrawText(console_textToDraw.ToString(), 0, 10, new SKPaint()
            //{
            //    Color = ScreenState.ForegroundColor,
            //    Typeface = SKTypeface.FromFamilyName(ScreenState.CurrentFont.Family),
            //    TextSize = (float)ScreenState.CurrentFont.Size
            //});

            // WIN 2D
            //ds.DrawText(console_textToDraw.ToString(), 0, 0, ScreenState.ForegroundColor,
            //    new Microsoft.Graphics.Canvas.Text.CanvasTextFormat()
            //    {
            //        FontFamily = ScreenState.CurrentFont.Family,
            //        FontSize = (float)ScreenState.CurrentFont.Size,
            //        FontStretch = ScreenState.CurrentFont.Stretch,
            //        FontWeight = ScreenState.CurrentFont.Weight,
            //        FontStyle = ScreenState.CurrentFont.Style
            //    });
            //}
            //session.DrawImage(offscreen, 0, 0);
            //GC.Collect();
        }

        private static double MeasureStringHeight()
        {
            var tb = new TextBlock
            {
                Text = "a",
                FontFamily = new FontFamily(ScreenState.CurrentFont.Family),
                FontSize = (float)ScreenState.CurrentFont.Size,
                FontStretch = ScreenState.CurrentFont.Stretch,
                FontWeight = ScreenState.CurrentFont.Weight,
                FontStyle = ScreenState.CurrentFont.Style
            };
            tb.Measure(new Size(Double.PositiveInfinity, Double.PositiveInfinity));
            return tb.DesiredSize.Height;
        }
    }
}

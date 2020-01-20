using BMVE.Core.Commands;
using BMVE.Core.Utils.Drawing;
using SkiaSharp.Views.WPF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Threading;

namespace BMVE.Core.View
{
    /// <summary>
    /// Main view
    /// </summary>
    public class CodeView : Window
    {
        internal SKElement renderView;

        // WARNING! This timer calls rendering. 
        // Avoid stopping this timer manually
        private static DispatcherTimer RenderCallTimer;

        public static Runnable ClassToExecute; // = new Runnable();

        /// <summary>
        /// Sets the FPS (refresh rate)
        /// </summary>
        /// <param name="fps">FPS value</param>
        internal static void SetRefreshFPSRate(int fps)
        {
            double refreshRate = 1000 / (double)fps;
            RenderCallTimer.Interval = TimeSpan.FromMilliseconds(refreshRate);
        }

        /// <summary>
        /// Gets the FPS (refresh rate)
        /// </summary>
        /// <returns>FPS value</returns>
        internal static int GetRefreshFPSRate()
        {
            return (int)RenderCallTimer.Interval.TotalMilliseconds;
        }

        public CodeView()
        {
            // Startup settings
            this.Width = 1200;
            this.Height = 900;
            this.WindowStartupLocation = WindowStartupLocation.CenterScreen;

            // Skia element
            renderView = new SKElement();
            renderView.Name = "renderView";
            this.Content = renderView;
            this.renderView.PaintSurface += RenderView_PaintSurface;
            this.Loaded += CodeView_Loaded;
        }

        private void CodeView_Loaded(object sender, RoutedEventArgs e)
        {
            RenderCallTimer = new DispatcherTimer();
            SetRefreshFPSRate(60);
            RenderCallTimer.Tick += DispatcherTimer_Tick;
            RenderCallTimer.Start();

            RunAsync();
        }

        private void RenderView_PaintSurface(object sender, SkiaSharp.Views.Desktop.SKPaintSurfaceEventArgs e)
        {
            DrawingPipeline.Render(renderView, e);
        }

        private void DispatcherTimer_Tick(object sender, object e)
        {
            renderView.InvalidateVisual();
            //InputState.MousePosition = new Tuple<int, int>((int)(Window.Current.CoreWindow.PointerPosition.X - Window.Current.CoreWindow.Bounds.Left), (int)(Window.Current.CoreWindow.PointerPosition.Y - Window.Current.CoreWindow.Bounds.Top));
        }

        private async void RunAsync()
        {
            await Task.Run(() =>
            {
                ClassToExecute.Main();
                ConsoleProxy.Console_DummyRead();
            });

            RenderCallTimer.Stop();
        }
    }
}

using BMVE.Core.Commands;
using BMVE.Core.Utils.Drawing;
using BMVE.Core.Utils.State;
using SkiaSharp.Views.WPF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
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
            this.PreviewKeyDown += CodeView_PreviewKeyDown;
            this.PreviewKeyUp += CodeView_PreviewKeyUp;
            this.PreviewMouseDown += CodeView_PreviewMouseDown;
            this.PreviewMouseUp += CodeView_PreviewMouseUp;
        }

        private void CodeView_PreviewMouseDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            InputState.RegisterPressedMouseButton(e.ChangedButton);
        }

        private void CodeView_PreviewMouseUp(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            InputState.UnregisterPressedMouseButton(e.ChangedButton);
        }

        private void CodeView_PreviewKeyDown(object sender, System.Windows.Input.KeyEventArgs e)
        {
            InputState.CapsLockState = ((Keyboard.GetKeyStates(Key.CapsLock) & KeyStates.Toggled) == KeyStates.Toggled);
            InputState.RegisterPressedKey(e.Key);
        }

        private void CodeView_PreviewKeyUp(object sender, System.Windows.Input.KeyEventArgs e)
        {
            InputState.UnregisterPressedKey(e.Key);
        }

        private void CodeView_Loaded(object sender, RoutedEventArgs e)
        {
            RenderCallTimer = new DispatcherTimer();
            SetRefreshFPSRate(60);
            RenderCallTimer.Tick += DispatcherTimer_Tick;
            RenderCallTimer.Start();

            InputLanguageManager.Current.InputLanguageChanged += Current_InputLanguageChanged;
            RunAsync();
        }

        private void Current_InputLanguageChanged(object sender, InputLanguageEventArgs e)
        {
            InputState.SetInputLanguage(e.NewLanguage.Name);
        }

        private void RenderView_PaintSurface(object sender, SkiaSharp.Views.Desktop.SKPaintSurfaceEventArgs e)
        {
            DrawingPipeline.Render(renderView, e);
        }

        private void DispatcherTimer_Tick(object sender, object e)
        {
            renderView.InvalidateVisual();
            Point mousePosition = Mouse.GetPosition(this);
            InputState.MousePosition = new Tuple<int, int>((int)(mousePosition.X), (int)(mousePosition.Y));
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

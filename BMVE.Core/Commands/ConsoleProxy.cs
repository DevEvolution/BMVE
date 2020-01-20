using BMVE.Core.Drawable.Primitives;
using BMVE.Core.Utils.Drawing;
using BMVE.Core.Utils.State;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMVE.Core.Commands
{
    internal static class ConsoleProxy
    {
        internal static void Console_WriteLine(params object[] text)
        {
            string fullText = string.Concat(text.Select(x => x.ToString()));

            DrawingPipeline.Add(new UIConsoleText()
            {
                ForegroundColor = ScreenState.ForegroundColor,
                FontInfo = ScreenState.CurrentFont.Clone(),
                Text = fullText
            });
        }

        internal static string Console_ReadString()
        {
            List<char> previousInput = new List<char>();
            List<char> currentInput = new List<char>();

            StringBuilder inputString = new StringBuilder();

            UIConsoleText inputUIText = new UIConsoleText()
            {
                Text = "",
                ForegroundColor = ScreenState.ForegroundColor,
                FontInfo = new Utils.Utils.FontInfo()
                {
                    Family = ScreenState.CurrentFont.Family,
                    Size = ScreenState.CurrentFont.Size,
                    Stretch = ScreenState.CurrentFont.Stretch,
                    Weight = ScreenState.CurrentFont.Weight,
                    Style = ScreenState.CurrentFont.Style
                }
            };

            DrawingPipeline.Add(inputUIText);

            var previousMode = SystemProxy.System_GetDrawingMode();

            do
            {
                currentInput = InputState.GetInputChars();
            }
            while (currentInput.Contains('\n'));

            SystemProxy.System_SetDrawingMode(Enums.RenderingMode.Buffered);

            do
            {
                currentInput = InputState.GetInputChars();

                if (currentInput.Count > previousInput.Count)
                {
                    char[] entry = currentInput.Except(previousInput).ToArray();
                    if (entry.Contains('\b'))
                    {
                        if (inputString.Length > 0)
                            inputString = inputString.Remove(inputString.Length - 1, 1);
                        entry = entry.Except(new char[] { '\b' }).ToArray();
                    }
                    if (entry.Length > 0)
                        inputString.Append(entry);
                    inputUIText.Text = inputString.ToString();
                    DrawingProxy.Screen_Render();
                }

                previousInput = new List<char>(currentInput);
            }
            while (!currentInput.Contains('\n'));
            inputString = inputString.Remove(inputString.Length - 1, 1);
            inputUIText.Text = inputString.ToString();

            SystemProxy.System_SetDrawingMode(previousMode);

            return inputString.ToString();
        }

        internal static void Console_DummyRead()
        {
            SystemProxy.System_SetDrawingMode(Enums.RenderingMode.Buffered);

            StopwatchProxy.Stopwatch_Start(9993);
            int previous = 0;
            do
            {
                if (StopwatchProxy.Stopwatch_GetMillisecondsElapsed(9993) - 100 > previous)
                    DrawingProxy.Screen_Render();
            }
            while (StopwatchProxy.Stopwatch_GetSecondsElapsed(9993) < 2);
        }
    }
}

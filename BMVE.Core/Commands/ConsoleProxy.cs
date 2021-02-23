using BMVE.Core.Drawable.Primitives;
using BMVE.Core.Utils.Drawing;
using BMVE.Core.Utils.State;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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

        internal static string Console_ReadLine(string prompt = "") => ReadConsoleInput(prompt: prompt);

        internal static int Console_ReadInt(string prompt = "")
        {
            string input = ReadConsoleInput(x => x == "-" || int.TryParse(x, out int _), prompt);
            if (int.TryParse(input, out int result)) return result;
            else return 0;
        }

        internal static double Console_ReadDouble(string prompt = "")
        {
            string input = ReadConsoleInput(x => x == "-" || double.TryParse(x, out double _), prompt);
            if (double.TryParse(input, out double result)) return result;
            else return 0;
        }

        internal static bool Console_ReadBool(string prompt = "")
        {
            string input = ReadConsoleInput(x => 
            {
                var str = x.ToLower();
                return str == "0" || str == "1" ||
                str == "t" || str == "f" ||
                str == "n" || str == "y" ||
                str == "н" || str == "д";
            }, prompt);
            switch (input.ToLower())
            {
                case "1":
                case "t":
                case "y":
                case "д":
                    return true;
                case "0":
                case "f":
                case "n":
                case "н":
                default:
                    return false;
            }
        }

        internal static void Console_DummyRead()
        {
            ScreenProxy.Screen_SetDrawingMode(Enums.RenderingMode.Buffered);

            StopwatchProxy.Stopwatch_Start(9993);
            int previous = 0;
            do
            {
                if (StopwatchProxy.Stopwatch_GetMillisecondsElapsed(9993) - 100 > previous)
                    ScreenProxy.Screen_Render();
            }
            while (StopwatchProxy.Stopwatch_GetSecondsElapsed(9993) < 2);
        }

        private static string ReadConsoleInput(Func<string, bool> validationMethod = null, string prompt = "")
        {
            List<char> previousInput = new List<char>();
            List<char> currentInput = new List<char>();

            StringBuilder inputString = new StringBuilder();

            UIConsoleText inputUIText = new UIConsoleText()
            {
                Text = prompt,
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

            var previousMode = ScreenProxy.Screen_GetDrawingMode();

            // Wait until 'ENTER' gets released
            do
            {
                currentInput = InputState.GetInputChars();
            }
            while (currentInput.Contains('\n'));

            // Input
            ScreenProxy.Screen_SetDrawingMode(Enums.RenderingMode.Buffered);
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            var lastInputTime = stopwatch.ElapsedMilliseconds;
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
                    {
                        if (validationMethod != null)
                        {
                            if (validationMethod(inputString.ToString() + new string(entry)))
                                inputString.Append(entry);
                        }
                        else
                        {
                            inputString.Append(entry);
                        }
                    }

                    inputUIText.Text = prompt + inputString.ToString();
                    lastInputTime = stopwatch.ElapsedMilliseconds;
                    ScreenProxy.Screen_Render();
                }
                else if (currentInput.Count > 0 && currentInput.Count == previousInput.Count && stopwatch.ElapsedMilliseconds - lastInputTime > 200)
                {
                    char[] entry = currentInput.ToArray();
                    if (entry.Contains('\b'))
                    {
                        if (inputString.Length > 0)
                            inputString = inputString.Remove(inputString.Length - 1, 1);
                        entry = entry.Except(new char[] { '\b' }).ToArray();
                    }
                    if (entry.Length > 0)
                    {
                        if (validationMethod != null)
                        {
                            if (validationMethod(inputString.ToString() + new string(entry)))
                                inputString.Append(entry);
                        }
                        else
                        {
                            inputString.Append(entry);
                        }
                    }
                    inputUIText.Text = prompt + inputString.ToString();
                    lastInputTime = stopwatch.ElapsedMilliseconds;
                    ScreenProxy.Screen_Render();
                }
                previousInput = new List<char>(currentInput);
            }
            while (!currentInput.Contains('\n'));
            if(inputString.Length > 0 && inputString[inputString.Length - 1] == '\n')
                inputString = inputString.Remove(inputString.Length - 1, 1);
            inputUIText.Text = prompt + inputString.ToString();

            ScreenProxy.Screen_SetDrawingMode(previousMode);
            return inputString.ToString();
        }
    }
}

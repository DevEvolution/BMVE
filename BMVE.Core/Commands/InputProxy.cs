using BMVE.Core.Drawable.Primitives;
using BMVE.Core.Utils.Drawing;
using BMVE.Core.Utils.State;
using SkiaSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace BMVE.Core.Commands
{
    internal static class InputProxy
    {
        internal static string Input_ReadString(int x, int y)
        {
            List<char> previousInput = new List<char>();
            List<char> currentInput = new List<char>();

            StringBuilder inputString = new StringBuilder();

            UIText inputUIText = new UIText()
            {
                Text = "",
                X = x,
                Y = y,
                ForegroundColor = SKColors.Red,
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

            SystemProxy.System_SetDrawingMode(previousMode);

            return inputString.ToString();
        }

        internal static string[] Input_GetPressedChars()
        {
            return InputState.GetInputChars().Cast<string>().ToArray();
        }

        internal static int Input_WaitForKey()
        {
            List<Key> pressedKeys;
            do
            {
                pressedKeys = InputState.GetPressedKeys();
            }
            while (!pressedKeys.Any());
            return (int)pressedKeys.First();
        }

        internal static int Input_GetMousePositionX() => InputState.MousePosition.Item1;
        internal static int Input_GetMousePositionY() => InputState.MousePosition.Item2;

        internal static bool Input_IsMousePressed(int button)
        {
            return InputState.GetMouseButtons().Contains(button);
        }

        internal static bool Input_IsKeyPressed(int key)
        {
            return InputState.GetPressedKeys().Contains((Key)key);
        }
    }
}

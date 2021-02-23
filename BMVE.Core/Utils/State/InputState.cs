using BMVE.Core.Enums;
using BMVE.Core.Utils.Utils;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace BMVE.Core.Utils.State
{
    internal static class InputState
    {
        private static volatile ConcurrentDictionary<Key, bool> _pressedKeys = new ConcurrentDictionary<Key, bool>();
        private static volatile ConcurrentDictionary<MouseButton, bool> _pressedMouseButtons = new ConcurrentDictionary<MouseButton, bool>();
        private static volatile bool _capsLockKey = false;
        private static volatile bool _numLockKey = false;

        private static volatile InputLanguage _inputLanguage = InputLanguage.English;

        internal static volatile Tuple<int, int> MousePosition = new Tuple<int, int>(0, 0);

        private static Dictionary<InputLanguage, VKLayout> KeyboardLayouts = new Dictionary<InputLanguage, VKLayout>
        {
            [InputLanguage.English] = new EnglishLayout(),
            [InputLanguage.Russian] = new RussianLayout()
        };

        internal static bool HasPressed { get => _pressedKeys.Values.Contains(true); }

        internal static bool CapsLockState { get => _capsLockKey; set => _capsLockKey = value; }

        internal static void RegisterPressedKey(Key vk)
        {
            _pressedKeys[vk] = true;
        }

        internal static void RegisterPressedMouseButton(MouseButton btn)
        {
            _pressedMouseButtons[btn] = true;
        }

        internal static void UnregisterPressedKey(Key vk)
        {
            _pressedKeys[vk] = false;
        }

        internal static void UnregisterPressedMouseButton(MouseButton btn)
        {
            _pressedMouseButtons[btn] = false;
        }

        internal static List<Key> GetPressedKeys()
        {
            return _pressedKeys.Where(x => x.Value == true).Select(x => x.Key).ToList();
        }

        internal static void SetInputLanguage(string lang)
        {
            switch (lang)
            {
                case "ru-RU":
                    _inputLanguage = InputLanguage.Russian;
                    break;
                case "en-US":
                default:
                    _inputLanguage = InputLanguage.English;
                    break;
            }
        }

        internal static InputLanguage GetInputLanguage()
            => _inputLanguage;

        internal static List<int> GetMouseButtons()
        {
            List<int> buttons = new List<int>();
            if (_pressedMouseButtons.TryGetValue(MouseButton.Left, out bool left) && left) buttons.Add(0);
            if (_pressedMouseButtons.TryGetValue(MouseButton.Right, out bool right) && right) buttons.Add(1);
            if (_pressedMouseButtons.TryGetValue(MouseButton.Middle, out bool middle) && middle) buttons.Add(2);
            if (_pressedMouseButtons.TryGetValue(MouseButton.XButton1, out bool xbtn1) && xbtn1) buttons.Add(3);
            if (_pressedMouseButtons.TryGetValue(MouseButton.XButton2, out bool xbtn2) && xbtn2) buttons.Add(4);

            return buttons;
        }

        internal static List<char> GetInputChars()
        {
            if (!_pressedKeys.Any(x => x.Value == true)) return new List<char>();

            bool isShiftPressed = _pressedKeys.Where(x => x.Value == true).Any(x => x.Key == Key.LeftShift || x.Key == Key.RightShift);
            bool isCapsToggled = CapsLockState;

            List<char> input = new List<char>();
            VKLayout currentLayout = KeyboardLayouts[_inputLanguage];
            foreach (var key in _pressedKeys.Where(x => x.Value == true &&
                 x.Key != Key.LeftShift && x.Key != Key.RightShift &&
                 x.Key != Key.LeftCtrl && x.Key != Key.RightCtrl).Select(x => x.Key))
            {
                if (currentLayout.KeyMap.TryGetValue(key, out CharShiftPair charmap))
                {
                    char symbol;
                    if (char.IsLetter(charmap.Char))
                    {
                        if (isCapsToggled) symbol = isShiftPressed ? charmap.Char : charmap.ShiftChar;
                        else symbol = isShiftPressed ? charmap.ShiftChar : charmap.Char;
                    }
                    else 
                    {
                        symbol = isShiftPressed ? charmap.ShiftChar : charmap.Char;
                    }
                    input.Add(symbol);
                }
            }

            return input;
        }
    }
}

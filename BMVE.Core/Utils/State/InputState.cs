using BMVE.Core.Enums;
using BMVE.Core.Utils.Utils;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMVE.Core.Utils.State
{
    internal static class InputState
    {
        //private static volatile ConcurrentDictionary<VirtualKey, bool> _pressedKeys = new ConcurrentDictionary<VirtualKey, bool>();

        private static volatile InputLanguage _inputLanguage = InputLanguage.English;

        internal static volatile Tuple<int, int> MousePosition = new Tuple<int, int>(0, 0);

        private static Dictionary<InputLanguage, VKLayout> KeyboardLayouts = new Dictionary<InputLanguage, VKLayout>
        {
            [InputLanguage.English] = new EnglishLayout(),
            [InputLanguage.Russian] = new RussianLayout()
        };

        //internal static bool HasPressed { get => _pressedKeys.Values.Contains(true); }

        //internal static void RegisterPressedKey(VirtualKey vk)
        //{
        //    _pressedKeys[vk] = true;
        //}

        //internal static void UnregisterPressedKey(VirtualKey vk)
        //{
        //    _pressedKeys[vk] = false;
        //}

        //internal static List<VirtualKey> GetPressedKeys()
        //{
        //    return _pressedKeys.Where(x => x.Value == true).Select(x => x.Key).ToList();
        //}

        internal static void SetInputLanguage(string lang)
        {
            switch (lang)
            {
                case "ru":
                    _inputLanguage = InputLanguage.Russian;
                    break;
                case "en-Us":
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
            //if (_pressedKeys.TryGetValue(VirtualKey.LeftButton, out bool left) && left) buttons.Add(0);
            //if (_pressedKeys.TryGetValue(VirtualKey.RightButton, out bool right) && right) buttons.Add(1);
            //if (_pressedKeys.TryGetValue(VirtualKey.MiddleButton, out bool middle) && middle) buttons.Add(2);
            //if (_pressedKeys.TryGetValue(VirtualKey.XButton1, out bool xbtn1) && xbtn1) buttons.Add(3);
            //if (_pressedKeys.TryGetValue(VirtualKey.XButton2, out bool xbtn2) && xbtn2) buttons.Add(4);
            //_pressedKeys.TryGetValue(VirtualKey.XButton1, out bool xbutton1);

            return buttons;
        }

        internal static List<char> GetInputChars()
        {
            //if (!_pressedKeys.Any(x => x.Value == true)) return new List<char>();

            //bool isShiftPressed = _pressedKeys.Where(x => x.Value == true).Any(x => x.Key == VirtualKey.Shift);

            //List<char> input = new List<char>();
            //VKLayout currentLayout = KeyboardLayouts[_inputLanguage];
            //foreach (var key in _pressedKeys.Where(x => x.Value == true &&
            //     x.Key != VirtualKey.Shift &&
            //     x.Key != VirtualKey.Control).Select(x => x.Key))
            //{
            //    if (currentLayout.KeyMap.TryGetValue(key, out CharShiftPair charmap))
            //    {
            //        input.Add(isShiftPressed ?
            //            charmap.ShiftChar :
            //            charmap.Char);
            //    }
            //}

            //return input;
            return new List<char>();
        }
    }
}

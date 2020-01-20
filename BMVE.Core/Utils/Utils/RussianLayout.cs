using BMVE.Core.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMVE.Core.Utils.Utils
{
    internal class RussianLayout : VKLayout
    {
        internal RussianLayout()
        {
            Language = InputLanguage.English;
            //KeyMap = new Dictionary<VirtualKey, CharShiftPair>
            //{
            //    // numbers
            //    [VirtualKey.Number0] = "0)",
            //    [VirtualKey.Number1] = "1!",
            //    [VirtualKey.Number2] = "2\"",
            //    [VirtualKey.Number3] = "3№",
            //    [VirtualKey.Number4] = "4;",
            //    [VirtualKey.Number5] = "5%",
            //    [VirtualKey.Number6] = "6:",
            //    [VirtualKey.Number7] = "7?",
            //    [VirtualKey.Number8] = "8*",
            //    [VirtualKey.Number9] = "9(",

            //    //numpad
            //    [VirtualKey.NumberPad0] = "00",
            //    [VirtualKey.NumberPad1] = "11",
            //    [VirtualKey.NumberPad2] = "22",
            //    [VirtualKey.NumberPad3] = "33",
            //    [VirtualKey.NumberPad4] = "44",
            //    [VirtualKey.NumberPad5] = "55",
            //    [VirtualKey.NumberPad6] = "66",
            //    [VirtualKey.NumberPad7] = "77",
            //    [VirtualKey.NumberPad8] = "88",
            //    [VirtualKey.NumberPad9] = "99",

            //    // letters
            //    [VirtualKey.A] = "фФ",
            //    [VirtualKey.B] = "иИ",
            //    [VirtualKey.C] = "сС",
            //    [VirtualKey.D] = "вВ",
            //    [VirtualKey.E] = "уУ",
            //    [VirtualKey.F] = "аА",
            //    [VirtualKey.G] = "пП",
            //    [VirtualKey.H] = "рР",
            //    [VirtualKey.I] = "шШ",
            //    [VirtualKey.J] = "оО",
            //    [VirtualKey.K] = "лЛ",
            //    [VirtualKey.L] = "дД",
            //    [VirtualKey.M] = "ьЬ",
            //    [VirtualKey.N] = "тТ",
            //    [VirtualKey.O] = "щЩ",
            //    [VirtualKey.P] = "зЗ",
            //    [VirtualKey.Q] = "йЙ",
            //    [VirtualKey.R] = "кК",
            //    [VirtualKey.S] = "ыЫ",
            //    [VirtualKey.T] = "еЕ",
            //    [VirtualKey.U] = "гГ",
            //    [VirtualKey.V] = "мМ",
            //    [VirtualKey.W] = "цЦ",
            //    [VirtualKey.X] = "чЧ",
            //    [VirtualKey.Y] = "нН",
            //    [VirtualKey.Z] = "яЯ",

            //    // additional symbols
            //    [(VirtualKey)189] = "-_",
            //    [(VirtualKey)187] = "=+",
            //    [(VirtualKey)188] = "бБ",
            //    [(VirtualKey)190] = "юЮ",
            //    [(VirtualKey)191] = ".,",
            //    [(VirtualKey)192] = "ёЁ",
            //    [(VirtualKey)220] = "\\/",
            //    [(VirtualKey)219] = "хХ",
            //    [(VirtualKey)221] = "ъЪ",
            //    [(VirtualKey)186] = "жЖ",
            //    [(VirtualKey)222] = "эЭ",

            //    // space
            //    [VirtualKey.Space] = "  ",

            //    // additional num keys
            //    [VirtualKey.Add] = "++",
            //    [VirtualKey.Subtract] = "--",
            //    [VirtualKey.Multiply] = "**",
            //    [VirtualKey.Divide] = "//",

            //    // spec
            //    [VirtualKey.Back] = $"\b\b",
            //    [VirtualKey.Tab] = "\t\t",
            //    [VirtualKey.Enter] = "\n\n",
            //};
        }
    }
}

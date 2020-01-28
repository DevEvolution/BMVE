using BMVE.Core.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace BMVE.Core.Utils.Utils
{
    internal class RussianLayout : VKLayout
    {
        internal RussianLayout()
        {
            Language = InputLanguage.English;
            KeyMap = new Dictionary<Key, CharShiftPair>
            {
                // numbers
                [Key.D0] = "0)",
                [Key.D1] = "1!",
                [Key.D2] = "2\"",
                [Key.D3] = "3№",
                [Key.D4] = "4;",
                [Key.D5] = "5%",
                [Key.D6] = "6:",
                [Key.D7] = "7?",
                [Key.D8] = "8*",
                [Key.D9] = "9(",

                //numpad
                [Key.NumPad0] = "00",
                [Key.NumPad1] = "11",
                [Key.NumPad2] = "22",
                [Key.NumPad3] = "33",
                [Key.NumPad4] = "44",
                [Key.NumPad5] = "55",
                [Key.NumPad6] = "66",
                [Key.NumPad7] = "77",
                [Key.NumPad8] = "88",
                [Key.NumPad9] = "99",

                // letters
                [Key.A] = "фФ",
                [Key.B] = "иИ",
                [Key.C] = "сС",
                [Key.D] = "вВ",
                [Key.E] = "уУ",
                [Key.F] = "аА",
                [Key.G] = "пП",
                [Key.H] = "рР",
                [Key.I] = "шШ",
                [Key.J] = "оО",
                [Key.K] = "лЛ",
                [Key.L] = "дД",
                [Key.M] = "ьЬ",
                [Key.N] = "тТ",
                [Key.O] = "щЩ",
                [Key.P] = "зЗ",
                [Key.Q] = "йЙ",
                [Key.R] = "кК",
                [Key.S] = "ыЫ",
                [Key.T] = "еЕ",
                [Key.U] = "гГ",
                [Key.V] = "мМ",
                [Key.W] = "цЦ",
                [Key.X] = "чЧ",
                [Key.Y] = "нН",
                [Key.Z] = "яЯ",

                // additional symbols
                [Key.OemMinus] = "-_",
                [Key.OemPlus] = "=+",
                [Key.OemComma] = "бБ",
                [Key.OemPeriod] = "юЮ",
                [Key.OemQuestion] = ".,",
                [Key.OemTilde] = "ёЁ",
                [Key.OemBackslash] = "\\/",
                [Key.OemOpenBrackets] = "хХ",
                [Key.OemCloseBrackets] = "ъЪ",
                [Key.OemSemicolon] = "жЖ",
                [Key.OemQuotes] = "эЭ",

                // space
                [Key.Space] = "  ",

                // additional num keys
                [Key.Add] = "++",
                [Key.Subtract] = "--",
                [Key.Multiply] = "**",
                [Key.Divide] = "//",

                // spec
                [Key.Back] = $"\b\b",
                [Key.Tab] = "\t\t",
                [Key.Enter] = "\n\n",
            };
        }
    }
}

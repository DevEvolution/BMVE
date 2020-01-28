using BMVE.Core.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace BMVE.Core.Utils.Utils
{
    internal class EnglishLayout : VKLayout
    {
        internal EnglishLayout()
        {
            Language = InputLanguage.English;
            KeyMap = new Dictionary<Key, CharShiftPair>
            {
                // numbers
                [Key.D0] = "0)",
                [Key.D1] = "1!",
                [Key.D2] = "2@",
                [Key.D3] = "3#",
                [Key.D4] = "4$",
                [Key.D5] = "5%",
                [Key.D6] = "6^",
                [Key.D7] = "7&",
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
                [Key.A] = "aA",
                [Key.B] = "bB",
                [Key.C] = "cC",
                [Key.D] = "dD",
                [Key.E] = "eE",
                [Key.F] = "fF",
                [Key.G] = "gG",
                [Key.H] = "hH",
                [Key.I] = "iI",
                [Key.J] = "jJ",
                [Key.K] = "kK",
                [Key.L] = "lL",
                [Key.M] = "mM",
                [Key.N] = "nN",
                [Key.O] = "oO",
                [Key.P] = "pP",
                [Key.Q] = "qQ",
                [Key.R] = "rR",
                [Key.S] = "sS",
                [Key.T] = "tT",
                [Key.U] = "uU",
                [Key.V] = "vV",
                [Key.W] = "wW",
                [Key.X] = "xX",
                [Key.Y] = "yY",
                [Key.Z] = "zZ",

                // additional symbols
                [Key.OemMinus] = "-_",
                [Key.OemPlus] = "=+",
                [Key.OemComma] = ",<",
                [Key.OemPeriod] = ".>",
                [Key.OemQuestion] = "/?",
                [Key.OemTilde] = "`~",
                [Key.OemBackslash] = "\\|",
                [Key.OemOpenBrackets] = "[{",
                [Key.OemCloseBrackets] = "]}",
                [Key.OemSemicolon] = ";:",
                [Key.OemQuotes] = "'\"",

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

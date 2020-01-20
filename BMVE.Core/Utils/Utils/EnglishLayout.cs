using BMVE.Core.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMVE.Core.Utils.Utils
{
    internal class EnglishLayout : VKLayout
    {
        internal EnglishLayout()
        {
            Language = InputLanguage.English;
            //KeyMap = new Dictionary<VirtualKey, CharShiftPair>
            //{
            //    // numbers
            //    [VirtualKey.Number0] = "0)",
            //    [VirtualKey.Number1] = "1!",
            //    [VirtualKey.Number2] = "2@",
            //    [VirtualKey.Number3] = "3#",
            //    [VirtualKey.Number4] = "4$",
            //    [VirtualKey.Number5] = "5%",
            //    [VirtualKey.Number6] = "6^",
            //    [VirtualKey.Number7] = "7&",
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
            //    [VirtualKey.A] = "aA",
            //    [VirtualKey.B] = "bB",
            //    [VirtualKey.C] = "cC",
            //    [VirtualKey.D] = "dD",
            //    [VirtualKey.E] = "eE",
            //    [VirtualKey.F] = "fF",
            //    [VirtualKey.G] = "gG",
            //    [VirtualKey.H] = "hH",
            //    [VirtualKey.I] = "iI",
            //    [VirtualKey.J] = "jJ",
            //    [VirtualKey.K] = "kK",
            //    [VirtualKey.L] = "lL",
            //    [VirtualKey.M] = "mM",
            //    [VirtualKey.N] = "nN",
            //    [VirtualKey.O] = "oO",
            //    [VirtualKey.P] = "pP",
            //    [VirtualKey.Q] = "qQ",
            //    [VirtualKey.R] = "rR",
            //    [VirtualKey.S] = "sS",
            //    [VirtualKey.T] = "tT",
            //    [VirtualKey.U] = "uU",
            //    [VirtualKey.V] = "vV",
            //    [VirtualKey.W] = "wW",
            //    [VirtualKey.X] = "xX",
            //    [VirtualKey.Y] = "yY",
            //    [VirtualKey.Z] = "zZ",

            //    // additional symbols
            //    [(VirtualKey)189] = "-_",
            //    [(VirtualKey)187] = "=+",
            //    [(VirtualKey)188] = ",<",
            //    [(VirtualKey)190] = ".>",
            //    [(VirtualKey)191] = "/?",
            //    [(VirtualKey)192] = "`~",
            //    [(VirtualKey)220] = "\\|",
            //    [(VirtualKey)219] = "[{",
            //    [(VirtualKey)221] = "]}",
            //    [(VirtualKey)186] = ";:",
            //    [(VirtualKey)222] = "'\"",

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

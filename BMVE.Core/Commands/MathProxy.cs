using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMVE.Core.Commands
{
    internal static class MathProxy
    {
        internal static double Math_Acos(double a) => Math.Acos(a);
        internal static double Math_Asin(double a) => Math.Asin(a);
        internal static double Math_Atan(double a) => Math.Atan(a);
        internal static double Math_Atan2(double a, double b) => Math.Atan2(a, b);
        internal static double Math_Abs(double a) => Math.Abs(a);
        internal static double Math_Ceil(double a) => Math.Ceiling(a);
        internal static double Math_Cos(double a) => Math.Cos(a);
        internal static double Math_Cosh(double a) => Math.Cosh(a);
        internal static double Math_Exp(double a) => Math.Exp(a);
        internal static double Math_Floor(double a) => Math.Floor(a);
        internal static double Math_Log(double a) => Math.Log(a);
        internal static double Math_Log10(double a) => Math.Log10(a);
        internal static double Math_Pow(double a, double power) => Math.Pow(a, power);
        internal static double Math_Round(double a) => Math.Round(a);
        internal static double Math_Sin(double a) => Math.Sin(a);
        internal static double Math_Sinh(double a) => Math.Sinh(a);
        internal static double Math_Sqrt(double a) => Math.Sqrt(a);
        internal static double Math_Tan(double a) => Math.Tan(a);
        internal static double Math_Tanh(double a) => Math.Tanh(a);
        internal static double Math_Truncate(double a) => Math.Truncate(a);
        internal static double Math_PI() => Math.PI;
        internal static int Math_RandomInt() => rand.Next();
        internal static double Math_RandomDouble() => rand.NextDouble();

        private static Random rand = new Random();

    }
}

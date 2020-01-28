using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMVE.Core.Commands
{
    internal static class ConvertProxy
    {
        internal static int Convert_StringToInt(string str) => Convert.ToInt32(str);
        internal static double Convert_StringToDouble(string str) => Convert.ToDouble(str);
        internal static bool Convert_StringToBoolean(string str) => Convert.ToBoolean(str);
        internal static double Convert_IntToDouble(int value) => Convert.ToDouble(value);
        internal static string Convert_IntToString(int value) => Convert.ToString(value);
        internal static bool Convert_IntToBoolean(int value) => Convert.ToBoolean(value);
        internal static string Convert_DoubleToString(double value) => Convert.ToString(value);
        internal static int Convert_DoubleToInt(double value) => Convert.ToInt32(value);
        internal static bool Convert_DoubleToBoolean(double value) => Convert.ToBoolean(value);
        internal static string Convert_BooleanToString(bool value) => Convert.ToString(value);
        internal static int Convert_BooleanToInt(bool value) => Convert.ToInt32(value);
        internal static double Convert_BooleanToDouble(bool value) => Convert.ToDouble(value);
    }
}

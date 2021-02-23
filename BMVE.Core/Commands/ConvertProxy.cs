using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMVE.Core.Commands
{
    internal static class ConvertProxy
    {
        internal static int Convert_ToInt(string value) => Convert.ToInt32(value);
        internal static int Convert_ToInt(uint value) => Convert.ToInt32(value);
        internal static int Convert_ToInt(long value) => Convert.ToInt32(value);
        internal static int Convert_ToInt(ulong value) => Convert.ToInt32(value);
        internal static int Convert_ToInt(short value) => Convert.ToInt32(value);
        internal static int Convert_ToInt(ushort value) => Convert.ToInt32(value);
        internal static int Convert_ToInt(byte value) => Convert.ToInt32(value);
        internal static int Convert_ToInt(sbyte value) => Convert.ToInt32(value);
        internal static int Convert_ToInt(decimal value) => Convert.ToInt32(value);
        internal static int Convert_ToInt(double value) => Convert.ToInt32(value);
        internal static int Convert_ToInt(float value) => Convert.ToInt32(value);
        internal static int Convert_ToInt(bool value) => Convert.ToInt32(value);
        
        internal static uint Convert_ToUInt(string value) => Convert.ToUInt32(value);
        internal static uint Convert_ToUInt(int value) => Convert.ToUInt32(value);
        internal static uint Convert_ToUInt(long value) => Convert.ToUInt32(value);
        internal static uint Convert_ToUInt(ulong value) => Convert.ToUInt32(value);
        internal static uint Convert_ToUInt(short value) => Convert.ToUInt32(value);
        internal static uint Convert_ToUInt(ushort value) => Convert.ToUInt32(value);
        internal static uint Convert_ToUInt(byte value) => Convert.ToUInt32(value);
        internal static uint Convert_ToUInt(sbyte value) => Convert.ToUInt32(value);
        internal static uint Convert_ToUInt(decimal value) => Convert.ToUInt32(value);
        internal static uint Convert_ToUInt(double value) => Convert.ToUInt32(value);
        internal static uint Convert_ToUInt(float value) => Convert.ToUInt32(value);
        internal static uint Convert_ToUInt(bool value) => Convert.ToUInt32(value);
        
        internal static long Convert_ToLong(string value) => Convert.ToInt64(value);
        internal static long Convert_ToLong(uint value) => Convert.ToInt64(value);
        internal static long Convert_ToLong(int value) => Convert.ToInt64(value);
        internal static long Convert_ToLong(ulong value) => Convert.ToInt64(value);
        internal static long Convert_ToLong(short value) => Convert.ToInt64(value);
        internal static long Convert_ToLong(ushort value) => Convert.ToInt64(value);
        internal static long Convert_ToLong(byte value) => Convert.ToInt64(value);
        internal static long Convert_ToLong(sbyte value) => Convert.ToInt64(value);
        internal static long Convert_ToLong(decimal value) => Convert.ToInt64(value);
        internal static long Convert_ToLong(double value) => Convert.ToInt64(value);
        internal static long Convert_ToLong(float value) => Convert.ToInt64(value);
        internal static long Convert_ToLong(bool value) => Convert.ToInt64(value);
        
        internal static ulong Convert_ToULong(string value) => Convert.ToUInt64(value);
        internal static ulong Convert_ToULong(uint value) => Convert.ToUInt64(value);
        internal static ulong Convert_ToULong(int value) => Convert.ToUInt64(value);
        internal static ulong Convert_ToULong(long value) => Convert.ToUInt64(value);
        internal static ulong Convert_ToULong(short value) => Convert.ToUInt64(value);
        internal static ulong Convert_ToULong(ushort value) => Convert.ToUInt64(value);
        internal static ulong Convert_ToULong(byte value) => Convert.ToUInt64(value);
        internal static ulong Convert_ToULong(sbyte value) => Convert.ToUInt64(value);
        internal static ulong Convert_ToULong(decimal value) => Convert.ToUInt64(value);
        internal static ulong Convert_ToULong(double value) => Convert.ToUInt64(value);
        internal static ulong Convert_ToULong(float value) => Convert.ToUInt64(value);
        internal static ulong Convert_ToULong(bool value) => Convert.ToUInt64(value);
        
        internal static short Convert_ToShort(string value) => Convert.ToInt16(value);
        internal static short Convert_ToShort(uint value) => Convert.ToInt16(value);
        internal static short Convert_ToShort(int value) => Convert.ToInt16(value);
        internal static short Convert_ToShort(ushort value) => Convert.ToInt16(value);
        internal static short Convert_ToShort(ulong value) => Convert.ToInt16(value);
        internal static short Convert_ToShort(long value) => Convert.ToInt16(value);
        internal static short Convert_ToShort(byte value) => Convert.ToInt16(value);
        internal static short Convert_ToShort(sbyte value) => Convert.ToInt16(value);
        internal static short Convert_ToShort(decimal value) => Convert.ToInt16(value);
        internal static short Convert_ToShort(double value) => Convert.ToInt16(value);
        internal static short Convert_ToShort(float value) => Convert.ToInt16(value);
        internal static short Convert_ToShort(bool value) => Convert.ToInt16(value);
        
        internal static ushort Convert_ToUShort(string value) => Convert.ToUInt16(value);
        internal static ushort Convert_ToUShort(uint value) => Convert.ToUInt16(value);
        internal static ushort Convert_ToUShort(int value) => Convert.ToUInt16(value);
        internal static ushort Convert_ToUShort(long value) => Convert.ToUInt16(value);
        internal static ushort Convert_ToUShort(short value) => Convert.ToUInt16(value);
        internal static ushort Convert_ToUShort(ulong value) => Convert.ToUInt16(value);
        internal static ushort Convert_ToUShort(byte value) => Convert.ToUInt16(value);
        internal static ushort Convert_ToUShort(sbyte value) => Convert.ToUInt16(value);
        internal static ushort Convert_ToUShort(decimal value) => Convert.ToUInt16(value);
        internal static ushort Convert_ToUShort(double value) => Convert.ToUInt16(value);
        internal static ushort Convert_ToUShort(float value) => Convert.ToUInt16(value);
        internal static ushort Convert_ToUShort(bool value) => Convert.ToUInt16(value);
        
        internal static byte Convert_ToByte(string value) => Convert.ToByte(value);
        internal static byte Convert_ToByte(uint value) => Convert.ToByte(value);
        internal static byte Convert_ToByte(int value) => Convert.ToByte(value);
        internal static byte Convert_ToByte(short value) => Convert.ToByte(value);
        internal static byte Convert_ToByte(ulong value) => Convert.ToByte(value);
        internal static byte Convert_ToByte(long value) => Convert.ToByte(value);
        internal static byte Convert_ToByte(byte value) => Convert.ToByte(value);
        internal static byte Convert_ToByte(ushort value) => Convert.ToByte(value);
        internal static byte Convert_ToByte(decimal value) => Convert.ToByte(value);
        internal static byte Convert_ToByte(double value) => Convert.ToByte(value);
        internal static byte Convert_ToByte(float value) => Convert.ToByte(value);
        internal static byte Convert_ToByte(bool value) => Convert.ToByte(value);
        
        internal static sbyte Convert_ToSByte(string value) => Convert.ToSByte(value);
        internal static sbyte Convert_ToSByte(uint value) => Convert.ToSByte(value);
        internal static sbyte Convert_ToSByte(int value) => Convert.ToSByte(value);
        internal static sbyte Convert_ToSByte(long value) => Convert.ToSByte(value);
        internal static sbyte Convert_ToSByte(byte value) => Convert.ToSByte(value);
        internal static sbyte Convert_ToSByte(ulong value) => Convert.ToSByte(value);
        internal static sbyte Convert_ToSByte(short value) => Convert.ToSByte(value);
        internal static sbyte Convert_ToSByte(ushort value) => Convert.ToSByte(value);
        internal static sbyte Convert_ToSByte(decimal value) => Convert.ToSByte(value);
        internal static sbyte Convert_ToSByte(double value) => Convert.ToSByte(value);
        internal static sbyte Convert_ToSByte(float value) => Convert.ToSByte(value);
        internal static sbyte Convert_ToSByte(bool value) => Convert.ToSByte(value);
        
        internal static double Convert_ToDouble(string value) => Convert.ToDouble(value);
        internal static double Convert_ToDouble(uint value) => Convert.ToDouble(value);
        internal static double Convert_ToDouble(int value) => Convert.ToDouble(value);
        internal static double Convert_ToDouble(long value) => Convert.ToDouble(value);
        internal static double Convert_ToDouble(byte value) => Convert.ToDouble(value);
        internal static double Convert_ToDouble(ulong value) => Convert.ToDouble(value);
        internal static double Convert_ToDouble(short value) => Convert.ToDouble(value);
        internal static double Convert_ToDouble(ushort value) => Convert.ToDouble(value);
        internal static double Convert_ToDouble(decimal value) => Convert.ToDouble(value);
        internal static double Convert_ToDouble(sbyte value) => Convert.ToDouble(value);
        internal static double Convert_ToDouble(float value) => Convert.ToDouble(value);
        internal static double Convert_ToDouble(bool value) => Convert.ToDouble(value);
        
        internal static float Convert_ToFloat(string value) => Convert.ToSingle(value);
        internal static float Convert_ToFloat(uint value) => Convert.ToSingle(value);
        internal static float Convert_ToFloat(int value) => Convert.ToSingle(value);
        internal static float Convert_ToFloat(long value) => Convert.ToSingle(value);
        internal static float Convert_ToFloat(byte value) => Convert.ToSingle(value);
        internal static float Convert_ToFloat(ulong value) => Convert.ToSingle(value);
        internal static float Convert_ToFloat(short value) => Convert.ToSingle(value);
        internal static float Convert_ToFloat(ushort value) => Convert.ToSingle(value);
        internal static float Convert_ToFloat(decimal value) => Convert.ToSingle(value);
        internal static float Convert_ToFloat(sbyte value) => Convert.ToSingle(value);
        internal static float Convert_ToFloat(double value) => Convert.ToSingle(value);
        internal static float Convert_ToFloat(bool value) => Convert.ToSingle(value);
        
        internal static decimal Convert_ToDecimal(string value) => Convert.ToDecimal(value);
        internal static decimal Convert_ToDecimal(uint value) => Convert.ToDecimal(value);
        internal static decimal Convert_ToDecimal(int value) => Convert.ToDecimal(value);
        internal static decimal Convert_ToDecimal(long value) => Convert.ToDecimal(value);
        internal static decimal Convert_ToDecimal(byte value) => Convert.ToDecimal(value);
        internal static decimal Convert_ToDecimal(ulong value) => Convert.ToDecimal(value);
        internal static decimal Convert_ToDecimal(short value) => Convert.ToDecimal(value);
        internal static decimal Convert_ToDecimal(ushort value) => Convert.ToDecimal(value);
        internal static decimal Convert_ToDecimal(double value) => Convert.ToDecimal(value);
        internal static decimal Convert_ToDecimal(sbyte value) => Convert.ToDecimal(value);
        internal static decimal Convert_ToDecimal(float value) => Convert.ToDecimal(value);
        internal static decimal Convert_ToDecimal(bool value) => Convert.ToDecimal(value);
        
        internal static bool Convert_ToBoolean(string value) => Convert.ToBoolean(value);
        internal static bool Convert_ToBoolean(uint value) => Convert.ToBoolean(value);
        internal static bool Convert_ToBoolean(int value) => Convert.ToBoolean(value);
        internal static bool Convert_ToBoolean(long value) => Convert.ToBoolean(value);
        internal static bool Convert_ToBoolean(byte value) => Convert.ToBoolean(value);
        internal static bool Convert_ToBoolean(ulong value) => Convert.ToBoolean(value);
        internal static bool Convert_ToBoolean(short value) => Convert.ToBoolean(value);
        internal static bool Convert_ToBoolean(ushort value) => Convert.ToBoolean(value);
        internal static bool Convert_ToBoolean(double value) => Convert.ToBoolean(value);
        internal static bool Convert_ToBoolean(sbyte value) => Convert.ToBoolean(value);
        internal static bool Convert_ToBoolean(float value) => Convert.ToBoolean(value);
        internal static bool Convert_ToBoolean(decimal value) => Convert.ToBoolean(value);
            
        internal static string Convert_ToString(string value) => Convert.ToString(value);
        internal static string Convert_ToString(uint value) => Convert.ToString(value);
        internal static string Convert_ToString(int value) => Convert.ToString(value);
        internal static string Convert_ToString(long value) => Convert.ToString(value);
        internal static string Convert_ToString(byte value) => Convert.ToString(value);
        internal static string Convert_ToString(ulong value) => Convert.ToString(value);
        internal static string Convert_ToString(short value) => Convert.ToString(value);
        internal static string Convert_ToString(ushort value) => Convert.ToString(value);
        internal static string Convert_ToString(double value) => Convert.ToString(value);
        internal static string Convert_ToString(sbyte value) => Convert.ToString(value);
        internal static string Convert_ToString(float value) => Convert.ToString(value);
        internal static string Convert_ToString(decimal value) => Convert.ToString(value);

        internal static string Convert_ToString(DateTime value) => value.ToString();
    }
}

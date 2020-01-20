using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMVE.Core.Utils.Adjustment
{
    internal static class ConverterAdjustment
    {
        internal static int BytesToInt(byte[] bytes)
        {
            if (bytes.Length != 4) throw new ArgumentException("Cannot parse bytes to int because of incorrect byte[length]");
            int value = bytes[0] & 0xFF;

            value = (value << 8) + (bytes[1] & 0xFF);
            value = (value << 8) + (bytes[2] & 0xFF);
            value = (value << 8) + (bytes[3] & 0xFF);
            return value;
        }

        internal static byte[] IntToByteArray(int value)
        {
            byte[] bytes = new byte[4];
            bytes[0] = (byte)value;
            bytes[1] = (byte)(value >> 8);
            bytes[2] = (byte)(value >> 16);
            bytes[3] = (byte)(value >> 24);
            return bytes;
        }
    }
}

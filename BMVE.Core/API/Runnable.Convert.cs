using BMVE.Core.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMVE.Core
{
    public partial class Runnable
    {
        /// <summary>
        /// Преобразование к типу <see cref="int"/> (System.Int32) - целое число 4 байта со знаком
        /// </summary>
        /// <param name="value">Что преобразовывать</param>
        /// <returns>Преобразованное к типу <see cref="int"/> значение</returns>
        protected int Convert_ToInt(string value) => ConvertProxy.Convert_ToInt(value);

        /// <summary>
        /// Преобразование к типу <see cref="int"/> (System.Int32) - целое число 4 байта со знаком
        /// </summary>
        /// <param name="value">Что преобразовывать</param>
        /// <returns>Преобразованное к типу <see cref="int"/> значение</returns>
        protected int Convert_ToInt(uint value) => ConvertProxy.Convert_ToInt(value);

        /// <summary>
        /// Преобразование к типу <see cref="int"/> (System.Int32) - целое число 4 байта со знаком
        /// </summary>
        /// <param name="value">Что преобразовывать</param>
        /// <returns>Преобразованное к типу <see cref="int"/> значение</returns>
        protected int Convert_ToInt(long value) => ConvertProxy.Convert_ToInt(value);

        /// <summary>
        /// Преобразование к типу <see cref="int"/> (System.Int32) - целое число 4 байта со знаком
        /// </summary>
        /// <param name="value">Что преобразовывать</param>
        /// <returns>Преобразованное к типу <see cref="int"/> значение</returns>
        protected int Convert_ToInt(ulong value) => ConvertProxy.Convert_ToInt(value);

        /// <summary>
        /// Преобразование к типу <see cref="int"/> (System.Int32) - целое число 4 байта со знаком
        /// </summary>
        /// <param name="value">Что преобразовывать</param>
        /// <returns>Преобразованное к типу <see cref="int"/> значение</returns>
        protected int Convert_ToInt(short value) => ConvertProxy.Convert_ToInt(value);

        /// <summary>
        /// Преобразование к типу <see cref="int"/> (System.Int32) - целое число 4 байта со знаком
        /// </summary>
        /// <param name="value">Что преобразовывать</param>
        /// <returns>Преобразованное к типу <see cref="int"/> значение</returns>
        protected int Convert_ToInt(ushort value) => ConvertProxy.Convert_ToInt(value);

        /// <summary>
        /// Преобразование к типу <see cref="int"/> (System.Int32) - целое число 4 байта со знаком
        /// </summary>
        /// <param name="value">Что преобразовывать</param>
        /// <returns>Преобразованное к типу <see cref="int"/> значение</returns>
        protected int Convert_ToInt(byte value) => ConvertProxy.Convert_ToInt(value);

        /// <summary>
        /// Преобразование к типу <see cref="int"/> (System.Int32) - целое число 4 байта со знаком
        /// </summary>
        /// <param name="value">Что преобразовывать</param>
        /// <returns>Преобразованное к типу <see cref="int"/> значение</returns>
        protected int Convert_ToInt(sbyte value) => ConvertProxy.Convert_ToInt(value);

        /// <summary>
        /// Преобразование к типу <see cref="int"/> (System.Int32) - целое число 4 байта со знаком
        /// </summary>
        /// <param name="value">Что преобразовывать</param>
        /// <returns>Преобразованное к типу <see cref="int"/> значение</returns>
        protected int Convert_ToInt(decimal value) => ConvertProxy.Convert_ToInt(value);

        /// <summary>
        /// Преобразование к типу <see cref="int"/> (System.Int32) - целое число 4 байта со знаком
        /// </summary>
        /// <param name="value">Что преобразовывать</param>
        /// <returns>Преобразованное к типу <see cref="int"/> значение</returns>
        protected int Convert_ToInt(double value) => ConvertProxy.Convert_ToInt(value);

        /// <summary>
        /// Преобразование к типу <see cref="int"/> (System.Int32) - целое число 4 байта со знаком
        /// </summary>
        /// <param name="value">Что преобразовывать</param>
        /// <returns>Преобразованное к типу <see cref="int"/> значение</returns>
        protected int Convert_ToInt(float value) => ConvertProxy.Convert_ToInt(value);

        /// <summary>
        /// Преобразование к типу <see cref="int"/> (System.Int32) - целое число 4 байта со знаком
        /// </summary>
        /// <param name="value">Что преобразовывать</param>
        /// <returns>Преобразованное к типу <see cref="int"/> значение</returns>
        protected int Convert_ToInt(bool value) => ConvertProxy.Convert_ToInt(value);

        /// <summary>
        /// Преобразование к типу <see cref="uint"/> (System.UInt32) - целое число 4 байта без знака
        /// </summary>
        /// <param name="value">Что преобразовывать</param>
        /// <returns>Преобразованное к типу <see cref="uint"/> значение</returns>
        protected uint Convert_ToUInt(string value) => ConvertProxy.Convert_ToUInt(value);

        /// <summary>
        /// Преобразование к типу <see cref="uint"/> (System.UInt32) - целое число 4 байта без знака
        /// </summary>
        /// <param name="value">Что преобразовывать</param>
        /// <returns>Преобразованное к типу <see cref="uint"/> значение</returns>
        protected uint Convert_ToUInt(int value) => ConvertProxy.Convert_ToUInt(value);

        /// <summary>
        /// Преобразование к типу <see cref="uint"/> (System.UInt32) - целое число 4 байта без знака
        /// </summary>
        /// <param name="value">Что преобразовывать</param>
        /// <returns>Преобразованное к типу <see cref="uint"/> значение</returns>
        protected uint Convert_ToUInt(long value) => ConvertProxy.Convert_ToUInt(value);

        /// <summary>
        /// Преобразование к типу <see cref="uint"/> (System.UInt32) - целое число 4 байта без знака
        /// </summary>
        /// <param name="value">Что преобразовывать</param>
        /// <returns>Преобразованное к типу <see cref="uint"/> значение</returns>
        protected uint Convert_ToUInt(ulong value) => ConvertProxy.Convert_ToUInt(value);

        /// <summary>
        /// Преобразование к типу <see cref="uint"/> (System.UInt32) - целое число 4 байта без знака
        /// </summary>
        /// <param name="value">Что преобразовывать</param>
        /// <returns>Преобразованное к типу <see cref="uint"/> значение</returns>
        protected uint Convert_ToUInt(short value) => ConvertProxy.Convert_ToUInt(value);

        /// <summary>
        /// Преобразование к типу <see cref="uint"/> (System.UInt32) - целое число 4 байта без знака
        /// </summary>
        /// <param name="value">Что преобразовывать</param>
        /// <returns>Преобразованное к типу <see cref="uint"/> значение</returns>
        protected uint Convert_ToUInt(ushort value) => ConvertProxy.Convert_ToUInt(value);

        /// <summary>
        /// Преобразование к типу <see cref="uint"/> (System.UInt32) - целое число 4 байта без знака
        /// </summary>
        /// <param name="value">Что преобразовывать</param>
        /// <returns>Преобразованное к типу <see cref="uint"/> значение</returns>
        protected uint Convert_ToUInt(byte value) => ConvertProxy.Convert_ToUInt(value);

        /// <summary>
        /// Преобразование к типу <see cref="uint"/> (System.UInt32) - целое число 4 байта без знака
        /// </summary>
        /// <param name="value">Что преобразовывать</param>
        /// <returns>Преобразованное к типу <see cref="uint"/> значение</returns>
        protected uint Convert_ToUInt(sbyte value) => ConvertProxy.Convert_ToUInt(value);

        /// <summary>
        /// Преобразование к типу <see cref="uint"/> (System.UInt32) - целое число 4 байта без знака
        /// </summary>
        /// <param name="value">Что преобразовывать</param>
        /// <returns>Преобразованное к типу <see cref="uint"/> значение</returns>
        protected uint Convert_ToUInt(decimal value) => ConvertProxy.Convert_ToUInt(value);

        /// <summary>
        /// Преобразование к типу <see cref="uint"/> (System.UInt32) - целое число 4 байта без знака
        /// </summary>
        /// <param name="value">Что преобразовывать</param>
        /// <returns>Преобразованное к типу <see cref="uint"/> значение</returns>
        protected uint Convert_ToUInt(double value) => ConvertProxy.Convert_ToUInt(value);

        /// <summary>
        /// Преобразование к типу <see cref="uint"/> (System.UInt32) - целое число 4 байта без знака
        /// </summary>
        /// <param name="value">Что преобразовывать</param>
        /// <returns>Преобразованное к типу <see cref="uint"/> значение</returns>
        protected uint Convert_ToUInt(float value) => ConvertProxy.Convert_ToUInt(value);

        /// <summary>
        /// Преобразование к типу <see cref="uint"/> (System.UInt32) - целое число 4 байта без знака
        /// </summary>
        /// <param name="value">Что преобразовывать</param>
        /// <returns>Преобразованное к типу <see cref="uint"/> значение</returns>
        protected uint Convert_ToUInt(bool value) => ConvertProxy.Convert_ToUInt(value);

        /// <summary>
        /// Преобразование к типу <see cref="long"/> (System.Int64) - целое число 8 байта со знаком
        /// </summary>
        /// <param name="value">Что преобразовывать</param>
        /// <returns>Преобразованное к типу <see cref="long"/> значение</returns>
        protected long Convert_ToLong(string value) => ConvertProxy.Convert_ToLong(value);

        /// <summary>
        /// Преобразование к типу <see cref="long"/> (System.Int64) - целое число 8 байта со знаком
        /// </summary>
        /// <param name="value">Что преобразовывать</param>
        /// <returns>Преобразованное к типу <see cref="long"/> значение</returns>
        protected long Convert_ToLong(uint value) => ConvertProxy.Convert_ToLong(value);

        /// <summary>
        /// Преобразование к типу <see cref="long"/> (System.Int64) - целое число 8 байта со знаком
        /// </summary>
        /// <param name="value">Что преобразовывать</param>
        /// <returns>Преобразованное к типу <see cref="long"/> значение</returns>
        protected long Convert_ToLong(int value) => ConvertProxy.Convert_ToLong(value);

        /// <summary>
        /// Преобразование к типу <see cref="long"/> (System.Int64) - целое число 8 байта со знаком
        /// </summary>
        /// <param name="value">Что преобразовывать</param>
        /// <returns>Преобразованное к типу <see cref="long"/> значение</returns>
        protected long Convert_ToLong(ulong value) => ConvertProxy.Convert_ToLong(value);

        /// <summary>
        /// Преобразование к типу <see cref="long"/> (System.Int64) - целое число 8 байта со знаком
        /// </summary>
        /// <param name="value">Что преобразовывать</param>
        /// <returns>Преобразованное к типу <see cref="long"/> значение</returns>
        protected long Convert_ToLong(short value) => ConvertProxy.Convert_ToLong(value);

        /// <summary>
        /// Преобразование к типу <see cref="long"/> (System.Int64) - целое число 8 байта со знаком
        /// </summary>
        /// <param name="value">Что преобразовывать</param>
        /// <returns>Преобразованное к типу <see cref="long"/> значение</returns>
        protected long Convert_ToLong(ushort value) => ConvertProxy.Convert_ToLong(value);

        /// <summary>
        /// Преобразование к типу <see cref="long"/> (System.Int64) - целое число 8 байта со знаком
        /// </summary>
        /// <param name="value">Что преобразовывать</param>
        /// <returns>Преобразованное к типу <see cref="long"/> значение</returns>
        protected long Convert_ToLong(byte value) => ConvertProxy.Convert_ToLong(value);

        /// <summary>
        /// Преобразование к типу <see cref="long"/> (System.Int64) - целое число 8 байта со знаком
        /// </summary>
        /// <param name="value">Что преобразовывать</param>
        /// <returns>Преобразованное к типу <see cref="long"/> значение</returns>
        protected long Convert_ToLong(sbyte value) => ConvertProxy.Convert_ToLong(value);

        /// <summary>
        /// Преобразование к типу <see cref="long"/> (System.Int64) - целое число 8 байта со знаком
        /// </summary>
        /// <param name="value">Что преобразовывать</param>
        /// <returns>Преобразованное к типу <see cref="long"/> значение</returns>
        protected long Convert_ToLong(decimal value) => ConvertProxy.Convert_ToLong(value);

        /// <summary>
        /// Преобразование к типу <see cref="long"/> (System.Int64) - целое число 8 байта со знаком
        /// </summary>
        /// <param name="value">Что преобразовывать</param>
        /// <returns>Преобразованное к типу <see cref="long"/> значение</returns>
        protected long Convert_ToLong(double value) => ConvertProxy.Convert_ToLong(value);

        /// <summary>
        /// Преобразование к типу <see cref="long"/> (System.Int64) - целое число 8 байта со знаком
        /// </summary>
        /// <param name="value">Что преобразовывать</param>
        /// <returns>Преобразованное к типу <see cref="long"/> значение</returns>
        protected long Convert_ToLong(float value) => ConvertProxy.Convert_ToLong(value);

        /// <summary>
        /// Преобразование к типу <see cref="long"/> (System.Int64) - целое число 8 байта со знаком
        /// </summary>
        /// <param name="value">Что преобразовывать</param>
        /// <returns>Преобразованное к типу <see cref="long"/> значение</returns>
        protected long Convert_ToLong(bool value) => ConvertProxy.Convert_ToLong(value);

        /// <summary>
        /// Преобразование к типу <see cref="ulong"/> (System.UInt64) - целое число 8 байта без знака
        /// </summary>
        /// <param name="value">Что преобразовывать</param>
        /// <returns>Преобразованное к типу <see cref="ulong"/> значение</returns>
        protected ulong Convert_ToULong(string value) => ConvertProxy.Convert_ToULong(value);

        /// <summary>
        /// Преобразование к типу <see cref="ulong"/> (System.UInt64) - целое число 8 байта без знака
        /// </summary>
        /// <param name="value">Что преобразовывать</param>
        /// <returns>Преобразованное к типу <see cref="ulong"/> значение</returns>
        protected ulong Convert_ToULong(uint value) => ConvertProxy.Convert_ToULong(value);

        /// <summary>
        /// Преобразование к типу <see cref="ulong"/> (System.UInt64) - целое число 8 байта без знака
        /// </summary>
        /// <param name="value">Что преобразовывать</param>
        /// <returns>Преобразованное к типу <see cref="ulong"/> значение</returns>
        protected ulong Convert_ToULong(int value) => ConvertProxy.Convert_ToULong(value);

        /// <summary>
        /// Преобразование к типу <see cref="ulong"/> (System.UInt64) - целое число 8 байта без знака
        /// </summary>
        /// <param name="value">Что преобразовывать</param>
        /// <returns>Преобразованное к типу <see cref="ulong"/> значение</returns>
        protected ulong Convert_ToULong(long value) => ConvertProxy.Convert_ToULong(value);

        /// <summary>
        /// Преобразование к типу <see cref="ulong"/> (System.UInt64) - целое число 8 байта без знака
        /// </summary>
        /// <param name="value">Что преобразовывать</param>
        /// <returns>Преобразованное к типу <see cref="ulong"/> значение</returns>
        protected ulong Convert_ToULong(short value) => ConvertProxy.Convert_ToULong(value);

        /// <summary>
        /// Преобразование к типу <see cref="ulong"/> (System.UInt64) - целое число 8 байта без знака
        /// </summary>
        /// <param name="value">Что преобразовывать</param>
        /// <returns>Преобразованное к типу <see cref="ulong"/> значение</returns>
        protected ulong Convert_ToULong(ushort value) => ConvertProxy.Convert_ToULong(value);

        /// <summary>
        /// Преобразование к типу <see cref="ulong"/> (System.UInt64) - целое число 8 байта без знака
        /// </summary>
        /// <param name="value">Что преобразовывать</param>
        /// <returns>Преобразованное к типу <see cref="ulong"/> значение</returns>
        protected ulong Convert_ToULong(byte value) => ConvertProxy.Convert_ToULong(value);

        /// <summary>
        /// Преобразование к типу <see cref="ulong"/> (System.UInt64) - целое число 8 байта без знака
        /// </summary>
        /// <param name="value">Что преобразовывать</param>
        /// <returns>Преобразованное к типу <see cref="ulong"/> значение</returns>
        protected ulong Convert_ToULong(sbyte value) => ConvertProxy.Convert_ToULong(value);

        /// <summary>
        /// Преобразование к типу <see cref="ulong"/> (System.UInt64) - целое число 8 байта без знака
        /// </summary>
        /// <param name="value">Что преобразовывать</param>
        /// <returns>Преобразованное к типу <see cref="ulong"/> значение</returns>
        protected ulong Convert_ToULong(decimal value) => ConvertProxy.Convert_ToULong(value);

        /// <summary>
        /// Преобразование к типу <see cref="ulong"/> (System.UInt64) - целое число 8 байта без знака
        /// </summary>
        /// <param name="value">Что преобразовывать</param>
        /// <returns>Преобразованное к типу <see cref="ulong"/> значение</returns>
        protected ulong Convert_ToULong(double value) => ConvertProxy.Convert_ToULong(value);

        /// <summary>
        /// Преобразование к типу <see cref="ulong"/> (System.UInt64) - целое число 8 байта без знака
        /// </summary>
        /// <param name="value">Что преобразовывать</param>
        /// <returns>Преобразованное к типу <see cref="ulong"/> значение</returns>
        protected ulong Convert_ToULong(float value) => ConvertProxy.Convert_ToULong(value);

        /// <summary>
        /// Преобразование к типу <see cref="ulong"/> (System.UInt64) - целое число 8 байта без знака
        /// </summary>
        /// <param name="value">Что преобразовывать</param>
        /// <returns>Преобразованное к типу <see cref="ulong"/> значение</returns>
        protected ulong Convert_ToULong(bool value) => ConvertProxy.Convert_ToULong(value);

        /// <summary>
        /// Преобразование к типу <see cref="short"/> (System.Int16) - целое число 2 байта со знаком
        /// </summary>
        /// <param name="value">Что преобразовывать</param>
        /// <returns>Преобразованное к типу <see cref="short"/> значение</returns>
        protected short Convert_ToShort(string value) => ConvertProxy.Convert_ToShort(value);

        /// <summary>
        /// Преобразование к типу <see cref="short"/> (System.Int16) - целое число 2 байта со знаком
        /// </summary>
        /// <param name="value">Что преобразовывать</param>
        /// <returns>Преобразованное к типу <see cref="short"/> значение</returns>
        protected short Convert_ToShort(uint value) => ConvertProxy.Convert_ToShort(value);

        /// <summary>
        /// Преобразование к типу <see cref="short"/> (System.Int16) - целое число 2 байта со знаком
        /// </summary>
        /// <param name="value">Что преобразовывать</param>
        /// <returns>Преобразованное к типу <see cref="short"/> значение</returns>
        protected short Convert_ToShort(int value) => ConvertProxy.Convert_ToShort(value);

        /// <summary>
        /// Преобразование к типу <see cref="short"/> (System.Int16) - целое число 2 байта со знаком
        /// </summary>
        /// <param name="value">Что преобразовывать</param>
        /// <returns>Преобразованное к типу <see cref="short"/> значение</returns>
        protected short Convert_ToShort(ushort value) => ConvertProxy.Convert_ToShort(value);

        /// <summary>
        /// Преобразование к типу <see cref="short"/> (System.Int16) - целое число 2 байта со знаком
        /// </summary>
        /// <param name="value">Что преобразовывать</param>
        /// <returns>Преобразованное к типу <see cref="short"/> значение</returns>
        protected short Convert_ToShort(ulong value) => ConvertProxy.Convert_ToShort(value);

        /// <summary>
        /// Преобразование к типу <see cref="short"/> (System.Int16) - целое число 2 байта со знаком
        /// </summary>
        /// <param name="value">Что преобразовывать</param>
        /// <returns>Преобразованное к типу <see cref="short"/> значение</returns>
        protected short Convert_ToShort(long value) => ConvertProxy.Convert_ToShort(value);

        /// <summary>
        /// Преобразование к типу <see cref="short"/> (System.Int16) - целое число 2 байта со знаком
        /// </summary>
        /// <param name="value">Что преобразовывать</param>
        /// <returns>Преобразованное к типу <see cref="short"/> значение</returns>
        protected short Convert_ToShort(byte value) => ConvertProxy.Convert_ToShort(value);

        /// <summary>
        /// Преобразование к типу <see cref="short"/> (System.Int16) - целое число 2 байта со знаком
        /// </summary>
        /// <param name="value">Что преобразовывать</param>
        /// <returns>Преобразованное к типу <see cref="short"/> значение</returns>
        protected short Convert_ToShort(sbyte value) => ConvertProxy.Convert_ToShort(value);

        /// <summary>
        /// Преобразование к типу <see cref="short"/> (System.Int16) - целое число 2 байта со знаком
        /// </summary>
        /// <param name="value">Что преобразовывать</param>
        /// <returns>Преобразованное к типу <see cref="short"/> значение</returns>
        protected short Convert_ToShort(decimal value) => ConvertProxy.Convert_ToShort(value);

        /// <summary>
        /// Преобразование к типу <see cref="short"/> (System.Int16) - целое число 2 байта со знаком
        /// </summary>
        /// <param name="value">Что преобразовывать</param>
        /// <returns>Преобразованное к типу <see cref="short"/> значение</returns>
        protected short Convert_ToShort(double value) => ConvertProxy.Convert_ToShort(value);

        /// <summary>
        /// Преобразование к типу <see cref="short"/> (System.Int16) - целое число 2 байта со знаком
        /// </summary>
        /// <param name="value">Что преобразовывать</param>
        /// <returns>Преобразованное к типу <see cref="short"/> значение</returns>
        protected short Convert_ToShort(float value) => ConvertProxy.Convert_ToShort(value);

        /// <summary>
        /// Преобразование к типу <see cref="short"/> (System.Int16) - целое число 2 байта со знаком
        /// </summary>
        /// <param name="value">Что преобразовывать</param>
        /// <returns>Преобразованное к типу <see cref="short"/> значение</returns>
        protected short Convert_ToShort(bool value) => ConvertProxy.Convert_ToShort(value);

        /// <summary>
        /// Преобразование к типу <see cref="ushort"/> (System.UInt16) - целое число 2 байта без знака
        /// </summary>
        /// <param name="value">Что преобразовывать</param>
        /// <returns>Преобразованное к типу <see cref="ushort"/> значение</returns>
        protected ushort Convert_ToUShort(string value) => ConvertProxy.Convert_ToUShort(value);

        /// <summary>
        /// Преобразование к типу <see cref="ushort"/> (System.UInt16) - целое число 2 байта без знака
        /// </summary>
        /// <param name="value">Что преобразовывать</param>
        /// <returns>Преобразованное к типу <see cref="ushort"/> значение</returns>
        protected ushort Convert_ToUShort(uint value) => ConvertProxy.Convert_ToUShort(value);

        /// <summary>
        /// Преобразование к типу <see cref="ushort"/> (System.UInt16) - целое число 2 байта без знака
        /// </summary>
        /// <param name="value">Что преобразовывать</param>
        /// <returns>Преобразованное к типу <see cref="ushort"/> значение</returns>
        protected ushort Convert_ToUShort(int value) => ConvertProxy.Convert_ToUShort(value);

        /// <summary>
        /// Преобразование к типу <see cref="ushort"/> (System.UInt16) - целое число 2 байта без знака
        /// </summary>
        /// <param name="value">Что преобразовывать</param>
        /// <returns>Преобразованное к типу <see cref="ushort"/> значение</returns>
        protected ushort Convert_ToUShort(long value) => ConvertProxy.Convert_ToUShort(value);

        /// <summary>
        /// Преобразование к типу <see cref="ushort"/> (System.UInt16) - целое число 2 байта без знака
        /// </summary>
        /// <param name="value">Что преобразовывать</param>
        /// <returns>Преобразованное к типу <see cref="ushort"/> значение</returns>
        protected ushort Convert_ToUShort(short value) => ConvertProxy.Convert_ToUShort(value);

        /// <summary>
        /// Преобразование к типу <see cref="ushort"/> (System.UInt16) - целое число 2 байта без знака
        /// </summary>
        /// <param name="value">Что преобразовывать</param>
        /// <returns>Преобразованное к типу <see cref="ushort"/> значение</returns>
        protected ushort Convert_ToUShort(ulong value) => ConvertProxy.Convert_ToUShort(value);

        /// <summary>
        /// Преобразование к типу <see cref="ushort"/> (System.UInt16) - целое число 2 байта без знака
        /// </summary>
        /// <param name="value">Что преобразовывать</param>
        /// <returns>Преобразованное к типу <see cref="ushort"/> значение</returns>
        protected ushort Convert_ToUShort(byte value) => ConvertProxy.Convert_ToUShort(value);

        /// <summary>
        /// Преобразование к типу <see cref="ushort"/> (System.UInt16) - целое число 2 байта без знака
        /// </summary>
        /// <param name="value">Что преобразовывать</param>
        /// <returns>Преобразованное к типу <see cref="ushort"/> значение</returns>
        protected ushort Convert_ToUShort(sbyte value) => ConvertProxy.Convert_ToUShort(value);

        /// <summary>
        /// Преобразование к типу <see cref="ushort"/> (System.UInt16) - целое число 2 байта без знака
        /// </summary>
        /// <param name="value">Что преобразовывать</param>
        /// <returns>Преобразованное к типу <see cref="ushort"/> значение</returns>
        protected ushort Convert_ToUShort(decimal value) => ConvertProxy.Convert_ToUShort(value);

        /// <summary>
        /// Преобразование к типу <see cref="ushort"/> (System.UInt16) - целое число 2 байта без знака
        /// </summary>
        /// <param name="value">Что преобразовывать</param>
        /// <returns>Преобразованное к типу <see cref="ushort"/> значение</returns>
        protected ushort Convert_ToUShort(double value) => ConvertProxy.Convert_ToUShort(value);

        /// <summary>
        /// Преобразование к типу <see cref="ushort"/> (System.UInt16) - целое число 2 байта без знака
        /// </summary>
        /// <param name="value">Что преобразовывать</param>
        /// <returns>Преобразованное к типу <see cref="ushort"/> значение</returns>
        protected ushort Convert_ToUShort(float value) => ConvertProxy.Convert_ToUShort(value);

        /// <summary>
        /// Преобразование к типу <see cref="ushort"/> (System.UInt16) - целое число 2 байта без знака
        /// </summary>
        /// <param name="value">Что преобразовывать</param>
        /// <returns>Преобразованное к типу <see cref="ushort"/> значение</returns>
        protected ushort Convert_ToUShort(bool value) => ConvertProxy.Convert_ToUShort(value);

        /// <summary>
        /// Преобразование к типу <see cref="byte"/> (System.Byte) - целое число 1 байт без знака
        /// </summary>
        /// <param name="value">Что преобразовывать</param>
        /// <returns>Преобразованное к типу <see cref="byte"/> значение</returns>
        protected byte Convert_ToByte(string value) => ConvertProxy.Convert_ToByte(value);

        /// <summary>
        /// Преобразование к типу <see cref="byte"/> (System.Byte) - целое число 1 байт без знака
        /// </summary>
        /// <param name="value">Что преобразовывать</param>
        /// <returns>Преобразованное к типу <see cref="byte"/> значение</returns>
        protected byte Convert_ToByte(uint value) => ConvertProxy.Convert_ToByte(value);

        /// <summary>
        /// Преобразование к типу <see cref="byte"/> (System.Byte) - целое число 1 байт без знака
        /// </summary>
        /// <param name="value">Что преобразовывать</param>
        /// <returns>Преобразованное к типу <see cref="byte"/> значение</returns>
        protected byte Convert_ToByte(int value) => ConvertProxy.Convert_ToByte(value);

        /// <summary>
        /// Преобразование к типу <see cref="byte"/> (System.Byte) - целое число 1 байт без знака
        /// </summary>
        /// <param name="value">Что преобразовывать</param>
        /// <returns>Преобразованное к типу <see cref="byte"/> значение</returns>
        protected byte Convert_ToByte(short value) => ConvertProxy.Convert_ToByte(value);

        /// <summary>
        /// Преобразование к типу <see cref="byte"/> (System.Byte) - целое число 1 байт без знака
        /// </summary>
        /// <param name="value">Что преобразовывать</param>
        /// <returns>Преобразованное к типу <see cref="byte"/> значение</returns>
        protected byte Convert_ToByte(ulong value) => ConvertProxy.Convert_ToByte(value);

        /// <summary>
        /// Преобразование к типу <see cref="byte"/> (System.Byte) - целое число 1 байт без знака
        /// </summary>
        /// <param name="value">Что преобразовывать</param>
        /// <returns>Преобразованное к типу <see cref="byte"/> значение</returns>
        protected byte Convert_ToByte(long value) => ConvertProxy.Convert_ToByte(value);

        /// <summary>
        /// Преобразование к типу <see cref="byte"/> (System.Byte) - целое число 1 байт без знака
        /// </summary>
        /// <param name="value">Что преобразовывать</param>
        /// <returns>Преобразованное к типу <see cref="byte"/> значение</returns>
        protected byte Convert_ToByte(byte value) => ConvertProxy.Convert_ToByte(value);

        /// <summary>
        /// Преобразование к типу <see cref="byte"/> (System.Byte) - целое число 1 байт без знака
        /// </summary>
        /// <param name="value">Что преобразовывать</param>
        /// <returns>Преобразованное к типу <see cref="byte"/> значение</returns>
        protected byte Convert_ToByte(ushort value) => ConvertProxy.Convert_ToByte(value);

        /// <summary>
        /// Преобразование к типу <see cref="byte"/> (System.Byte) - целое число 1 байт без знака
        /// </summary>
        /// <param name="value">Что преобразовывать</param>
        /// <returns>Преобразованное к типу <see cref="byte"/> значение</returns>
        protected byte Convert_ToByte(decimal value) => ConvertProxy.Convert_ToByte(value);

        /// <summary>
        /// Преобразование к типу <see cref="byte"/> (System.Byte) - целое число 1 байт без знака
        /// </summary>
        /// <param name="value">Что преобразовывать</param>
        /// <returns>Преобразованное к типу <see cref="byte"/> значение</returns>
        protected byte Convert_ToByte(double value) => ConvertProxy.Convert_ToByte(value);

        /// <summary>
        /// Преобразование к типу <see cref="byte"/> (System.Byte) - целое число 1 байт без знака
        /// </summary>
        /// <param name="value">Что преобразовывать</param>
        /// <returns>Преобразованное к типу <see cref="byte"/> значение</returns>
        protected byte Convert_ToByte(float value) => ConvertProxy.Convert_ToByte(value);

        /// <summary>
        /// Преобразование к типу <see cref="byte"/> (System.Byte) - целое число 1 байт без знака
        /// </summary>
        /// <param name="value">Что преобразовывать</param>
        /// <returns>Преобразованное к типу <see cref="byte"/> значение</returns>
        protected byte Convert_ToByte(bool value) => ConvertProxy.Convert_ToByte(value);

        /// <summary>
        /// Преобразование к типу <see cref="sbyte"/> (System.SByte) - целое число 1 байт со знаком
        /// </summary>
        /// <param name="value">Что преобразовывать</param>
        /// <returns>Преобразованное к типу <see cref="sbyte"/> значение</returns>
        protected sbyte Convert_ToSByte(string value) => ConvertProxy.Convert_ToSByte(value);

        /// <summary>
        /// Преобразование к типу <see cref="sbyte"/> (System.SByte) - целое число 1 байт со знаком
        /// </summary>
        /// <param name="value">Что преобразовывать</param>
        /// <returns>Преобразованное к типу <see cref="sbyte"/> значение</returns>
        protected sbyte Convert_ToSByte(uint value) => ConvertProxy.Convert_ToSByte(value);

        /// <summary>
        /// Преобразование к типу <see cref="sbyte"/> (System.SByte) - целое число 1 байт со знаком
        /// </summary>
        /// <param name="value">Что преобразовывать</param>
        /// <returns>Преобразованное к типу <see cref="sbyte"/> значение</returns>
        protected sbyte Convert_ToSByte(int value) => ConvertProxy.Convert_ToSByte(value);

        /// <summary>
        /// Преобразование к типу <see cref="sbyte"/> (System.SByte) - целое число 1 байт со знаком
        /// </summary>
        /// <param name="value">Что преобразовывать</param>
        /// <returns>Преобразованное к типу <see cref="sbyte"/> значение</returns>
        protected sbyte Convert_ToSByte(long value) => ConvertProxy.Convert_ToSByte(value);

        /// <summary>
        /// Преобразование к типу <see cref="sbyte"/> (System.SByte) - целое число 1 байт со знаком
        /// </summary>
        /// <param name="value">Что преобразовывать</param>
        /// <returns>Преобразованное к типу <see cref="sbyte"/> значение</returns>
        protected sbyte Convert_ToSByte(byte value) => ConvertProxy.Convert_ToSByte(value);

        /// <summary>
        /// Преобразование к типу <see cref="sbyte"/> (System.SByte) - целое число 1 байт со знаком
        /// </summary>
        /// <param name="value">Что преобразовывать</param>
        /// <returns>Преобразованное к типу <see cref="sbyte"/> значение</returns>
        protected sbyte Convert_ToSByte(ulong value) => ConvertProxy.Convert_ToSByte(value);

        /// <summary>
        /// Преобразование к типу <see cref="sbyte"/> (System.SByte) - целое число 1 байт со знаком
        /// </summary>
        /// <param name="value">Что преобразовывать</param>
        /// <returns>Преобразованное к типу <see cref="sbyte"/> значение</returns>
        protected sbyte Convert_ToSByte(short value) => ConvertProxy.Convert_ToSByte(value);

        /// <summary>
        /// Преобразование к типу <see cref="sbyte"/> (System.SByte) - целое число 1 байт со знаком
        /// </summary>
        /// <param name="value">Что преобразовывать</param>
        /// <returns>Преобразованное к типу <see cref="sbyte"/> значение</returns>
        protected sbyte Convert_ToSByte(ushort value) => ConvertProxy.Convert_ToSByte(value);

        /// <summary>
        /// Преобразование к типу <see cref="sbyte"/> (System.SByte) - целое число 1 байт со знаком
        /// </summary>
        /// <param name="value">Что преобразовывать</param>
        /// <returns>Преобразованное к типу <see cref="sbyte"/> значение</returns>
        protected sbyte Convert_ToSByte(decimal value) => ConvertProxy.Convert_ToSByte(value);

        /// <summary>
        /// Преобразование к типу <see cref="sbyte"/> (System.SByte) - целое число 1 байт со знаком
        /// </summary>
        /// <param name="value">Что преобразовывать</param>
        /// <returns>Преобразованное к типу <see cref="sbyte"/> значение</returns>
        protected sbyte Convert_ToSByte(double value) => ConvertProxy.Convert_ToSByte(value);

        /// <summary>
        /// Преобразование к типу <see cref="sbyte"/> (System.SByte) - целое число 1 байт со знаком
        /// </summary>
        /// <param name="value">Что преобразовывать</param>
        /// <returns>Преобразованное к типу <see cref="sbyte"/> значение</returns>
        protected sbyte Convert_ToSByte(float value) => ConvertProxy.Convert_ToSByte(value);

        /// <summary>
        /// Преобразование к типу <see cref="sbyte"/> (System.SByte) - целое число 1 байт со знаком
        /// </summary>
        /// <param name="value">Что преобразовывать</param>
        /// <returns>Преобразованное к типу <see cref="sbyte"/> значение</returns>
        protected sbyte Convert_ToSByte(bool value) => ConvertProxy.Convert_ToSByte(value);

        /// <summary>
        /// Преобразование к типу <see cref="double"/> (System.Double) - дробное число 8 байт (15 цифр после запятой)
        /// </summary>
        /// <param name="value">Что преобразовывать</param>
        /// <returns>Преобразованное к типу <see cref="double"/> значение</returns>
        protected double Convert_ToDouble(string value) => ConvertProxy.Convert_ToDouble(value);

        /// <summary>
        /// Преобразование к типу <see cref="double"/> (System.Double) - дробное число 8 байт (15 цифр после запятой)
        /// </summary>
        /// <param name="value">Что преобразовывать</param>
        /// <returns>Преобразованное к типу <see cref="double"/> значение</returns>
        protected double Convert_ToDouble(uint value) => ConvertProxy.Convert_ToDouble(value);

        /// <summary>
        /// Преобразование к типу <see cref="double"/> (System.Double) - дробное число 8 байт (15 цифр после запятой)
        /// </summary>
        /// <param name="value">Что преобразовывать</param>
        /// <returns>Преобразованное к типу <see cref="double"/> значение</returns>
        protected double Convert_ToDouble(int value) => ConvertProxy.Convert_ToDouble(value);

        /// <summary>
        /// Преобразование к типу <see cref="double"/> (System.Double) - дробное число 8 байт (15 цифр после запятой)
        /// </summary>
        /// <param name="value">Что преобразовывать</param>
        /// <returns>Преобразованное к типу <see cref="double"/> значение</returns>
        protected double Convert_ToDouble(long value) => ConvertProxy.Convert_ToDouble(value);

        /// <summary>
        /// Преобразование к типу <see cref="double"/> (System.Double) - дробное число 8 байт (15 цифр после запятой)
        /// </summary>
        /// <param name="value">Что преобразовывать</param>
        /// <returns>Преобразованное к типу <see cref="double"/> значение</returns>
        protected double Convert_ToDouble(byte value) => ConvertProxy.Convert_ToDouble(value);

        /// <summary>
        /// Преобразование к типу <see cref="double"/> (System.Double) - дробное число 8 байт (15 цифр после запятой)
        /// </summary>
        /// <param name="value">Что преобразовывать</param>
        /// <returns>Преобразованное к типу <see cref="double"/> значение</returns>
        protected double Convert_ToDouble(ulong value) => ConvertProxy.Convert_ToDouble(value);

        /// <summary>
        /// Преобразование к типу <see cref="double"/> (System.Double) - дробное число 8 байт (15 цифр после запятой)
        /// </summary>
        /// <param name="value">Что преобразовывать</param>
        /// <returns>Преобразованное к типу <see cref="double"/> значение</returns>
        protected double Convert_ToDouble(short value) => ConvertProxy.Convert_ToDouble(value);

        /// <summary>
        /// Преобразование к типу <see cref="double"/> (System.Double) - дробное число 8 байт (15 цифр после запятой)
        /// </summary>
        /// <param name="value">Что преобразовывать</param>
        /// <returns>Преобразованное к типу <see cref="double"/> значение</returns>
        protected double Convert_ToDouble(ushort value) => ConvertProxy.Convert_ToDouble(value);

        /// <summary>
        /// Преобразование к типу <see cref="double"/> (System.Double) - дробное число 8 байт (15 цифр после запятой)
        /// </summary>
        /// <param name="value">Что преобразовывать</param>
        /// <returns>Преобразованное к типу <see cref="double"/> значение</returns>
        protected double Convert_ToDouble(decimal value) => ConvertProxy.Convert_ToDouble(value);

        /// <summary>
        /// Преобразование к типу <see cref="double"/> (System.Double) - дробное число 8 байт (15 цифр после запятой)
        /// </summary>
        /// <param name="value">Что преобразовывать</param>
        /// <returns>Преобразованное к типу <see cref="double"/> значение</returns>
        protected double Convert_ToDouble(sbyte value) => ConvertProxy.Convert_ToDouble(value);

        /// <summary>
        /// Преобразование к типу <see cref="double"/> (System.Double) - дробное число 8 байт (15 цифр после запятой)
        /// </summary>
        /// <param name="value">Что преобразовывать</param>
        /// <returns>Преобразованное к типу <see cref="double"/> значение</returns>
        protected double Convert_ToDouble(float value) => ConvertProxy.Convert_ToDouble(value);

        /// <summary>
        /// Преобразование к типу <see cref="double"/> (System.Double) - дробное число 8 байт (15 цифр после запятой)
        /// </summary>
        /// <param name="value">Что преобразовывать</param>
        /// <returns>Преобразованное к типу <see cref="double"/> значение</returns>
        protected double Convert_ToDouble(bool value) => ConvertProxy.Convert_ToDouble(value);

        /// <summary>
        /// Преобразование к типу <see cref="float"/> (System.Single) - дробное число 4 байт (6-7 цифр после запятой)
        /// </summary>
        /// <param name="value">Что преобразовывать</param>
        /// <returns>Преобразованное к типу <see cref="float"/> значение</returns>
        protected float Convert_ToFloat(string value) => ConvertProxy.Convert_ToFloat(value);

        /// <summary>
        /// Преобразование к типу <see cref="float"/> (System.Single) - дробное число 4 байт (6-7 цифр после запятой)
        /// </summary>
        /// <param name="value">Что преобразовывать</param>
        /// <returns>Преобразованное к типу <see cref="float"/> значение</returns>
        protected float Convert_ToFloat(uint value) => ConvertProxy.Convert_ToFloat(value);

        /// <summary>
        /// Преобразование к типу <see cref="float"/> (System.Single) - дробное число 4 байт (6-7 цифр после запятой)
        /// </summary>
        /// <param name="value">Что преобразовывать</param>
        /// <returns>Преобразованное к типу <see cref="float"/> значение</returns>
        protected float Convert_ToFloat(int value) => ConvertProxy.Convert_ToFloat(value);

        /// <summary>
        /// Преобразование к типу <see cref="float"/> (System.Single) - дробное число 4 байт (6-7 цифр после запятой)
        /// </summary>
        /// <param name="value">Что преобразовывать</param>
        /// <returns>Преобразованное к типу <see cref="float"/> значение</returns>
        protected float Convert_ToFloat(long value) => ConvertProxy.Convert_ToFloat(value);

        /// <summary>
        /// Преобразование к типу <see cref="float"/> (System.Single) - дробное число 4 байт (6-7 цифр после запятой)
        /// </summary>
        /// <param name="value">Что преобразовывать</param>
        /// <returns>Преобразованное к типу <see cref="float"/> значение</returns>
        protected float Convert_ToFloat(byte value) => ConvertProxy.Convert_ToFloat(value);

        /// <summary>
        /// Преобразование к типу <see cref="float"/> (System.Single) - дробное число 4 байт (6-7 цифр после запятой)
        /// </summary>
        /// <param name="value">Что преобразовывать</param>
        /// <returns>Преобразованное к типу <see cref="float"/> значение</returns>
        protected float Convert_ToFloat(ulong value) => ConvertProxy.Convert_ToFloat(value);

        /// <summary>
        /// Преобразование к типу <see cref="float"/> (System.Single) - дробное число 4 байт (6-7 цифр после запятой)
        /// </summary>
        /// <param name="value">Что преобразовывать</param>
        /// <returns>Преобразованное к типу <see cref="float"/> значение</returns>
        protected float Convert_ToFloat(short value) => ConvertProxy.Convert_ToFloat(value);

        /// <summary>
        /// Преобразование к типу <see cref="float"/> (System.Single) - дробное число 4 байт (6-7 цифр после запятой)
        /// </summary>
        /// <param name="value">Что преобразовывать</param>
        /// <returns>Преобразованное к типу <see cref="float"/> значение</returns>
        protected float Convert_ToFloat(ushort value) => ConvertProxy.Convert_ToFloat(value);

        /// <summary>
        /// Преобразование к типу <see cref="float"/> (System.Single) - дробное число 4 байт (6-7 цифр после запятой)
        /// </summary>
        /// <param name="value">Что преобразовывать</param>
        /// <returns>Преобразованное к типу <see cref="float"/> значение</returns>
        protected float Convert_ToFloat(decimal value) => ConvertProxy.Convert_ToFloat(value);

        /// <summary>
        /// Преобразование к типу <see cref="float"/> (System.Single) - дробное число 4 байт (6-7 цифр после запятой)
        /// </summary>
        /// <param name="value">Что преобразовывать</param>
        /// <returns>Преобразованное к типу <see cref="float"/> значение</returns>
        protected float Convert_ToFloat(sbyte value) => ConvertProxy.Convert_ToFloat(value);

        /// <summary>
        /// Преобразование к типу <see cref="float"/> (System.Single) - дробное число 4 байт (6-7 цифр после запятой)
        /// </summary>
        /// <param name="value">Что преобразовывать</param>
        /// <returns>Преобразованное к типу <see cref="float"/> значение</returns>
        protected float Convert_ToFloat(double value) => ConvertProxy.Convert_ToFloat(value);

        /// <summary>
        /// Преобразование к типу <see cref="float"/> (System.Single) - дробное число 4 байт (6-7 цифр после запятой)
        /// </summary>
        /// <param name="value">Что преобразовывать</param>
        /// <returns>Преобразованное к типу <see cref="float"/> значение</returns>
        protected float Convert_ToFloat(bool value) => ConvertProxy.Convert_ToFloat(value);

        /// <summary>
        /// Преобразование к типу <see cref="decimal"/> (System.Decimal) - дробное число 16 байт (28-29 цифр после запятой)
        /// </summary>
        /// <param name="value">Что преобразовывать</param>
        /// <returns>Преобразованное к типу <see cref="decimal"/> значение</returns>
        protected decimal Convert_ToDecimal(string value) => ConvertProxy.Convert_ToDecimal(value);

        /// <summary>
        /// Преобразование к типу <see cref="decimal"/> (System.Decimal) - дробное число 16 байт (28-29 цифр после запятой)
        /// </summary>
        /// <param name="value">Что преобразовывать</param>
        /// <returns>Преобразованное к типу <see cref="decimal"/> значение</returns>
        protected decimal Convert_ToDecimal(uint value) => ConvertProxy.Convert_ToDecimal(value);

        /// <summary>
        /// Преобразование к типу <see cref="decimal"/> (System.Decimal) - дробное число 16 байт (28-29 цифр после запятой)
        /// </summary>
        /// <param name="value">Что преобразовывать</param>
        /// <returns>Преобразованное к типу <see cref="decimal"/> значение</returns>
        protected decimal Convert_ToDecimal(int value) => ConvertProxy.Convert_ToDecimal(value);

        /// <summary>
        /// Преобразование к типу <see cref="decimal"/> (System.Decimal) - дробное число 16 байт (28-29 цифр после запятой)
        /// </summary>
        /// <param name="value">Что преобразовывать</param>
        /// <returns>Преобразованное к типу <see cref="decimal"/> значение</returns>
        protected decimal Convert_ToDecimal(long value) => ConvertProxy.Convert_ToDecimal(value);

        /// <summary>
        /// Преобразование к типу <see cref="decimal"/> (System.Decimal) - дробное число 16 байт (28-29 цифр после запятой)
        /// </summary>
        /// <param name="value">Что преобразовывать</param>
        /// <returns>Преобразованное к типу <see cref="decimal"/> значение</returns>
        protected decimal Convert_ToDecimal(byte value) => ConvertProxy.Convert_ToDecimal(value);

        /// <summary>
        /// Преобразование к типу <see cref="decimal"/> (System.Decimal) - дробное число 16 байт (28-29 цифр после запятой)
        /// </summary>
        /// <param name="value">Что преобразовывать</param>
        /// <returns>Преобразованное к типу <see cref="decimal"/> значение</returns>
        protected decimal Convert_ToDecimal(ulong value) => ConvertProxy.Convert_ToDecimal(value);

        /// <summary>
        /// Преобразование к типу <see cref="decimal"/> (System.Decimal) - дробное число 16 байт (28-29 цифр после запятой)
        /// </summary>
        /// <param name="value">Что преобразовывать</param>
        /// <returns>Преобразованное к типу <see cref="decimal"/> значение</returns>
        protected decimal Convert_ToDecimal(short value) => ConvertProxy.Convert_ToDecimal(value);

        /// <summary>
        /// Преобразование к типу <see cref="decimal"/> (System.Decimal) - дробное число 16 байт (28-29 цифр после запятой)
        /// </summary>
        /// <param name="value">Что преобразовывать</param>
        /// <returns>Преобразованное к типу <see cref="decimal"/> значение</returns>
        protected decimal Convert_ToDecimal(ushort value) => ConvertProxy.Convert_ToDecimal(value);

        /// <summary>
        /// Преобразование к типу <see cref="decimal"/> (System.Decimal) - дробное число 16 байт (28-29 цифр после запятой)
        /// </summary>
        /// <param name="value">Что преобразовывать</param>
        /// <returns>Преобразованное к типу <see cref="decimal"/> значение</returns>
        protected decimal Convert_ToDecimal(double value) => ConvertProxy.Convert_ToDecimal(value);

        /// <summary>
        /// Преобразование к типу <see cref="decimal"/> (System.Decimal) - дробное число 16 байт (28-29 цифр после запятой)
        /// </summary>
        /// <param name="value">Что преобразовывать</param>
        /// <returns>Преобразованное к типу <see cref="decimal"/> значение</returns>
        protected decimal Convert_ToDecimal(sbyte value) => ConvertProxy.Convert_ToDecimal(value);

        /// <summary>
        /// Преобразование к типу <see cref="decimal"/> (System.Decimal) - дробное число 16 байт (28-29 цифр после запятой)
        /// </summary>
        /// <param name="value">Что преобразовывать</param>
        /// <returns>Преобразованное к типу <see cref="decimal"/> значение</returns>
        protected decimal Convert_ToDecimal(float value) => ConvertProxy.Convert_ToDecimal(value);

        /// <summary>
        /// Преобразование к типу <see cref="decimal"/> (System.Decimal) - дробное число 16 байт (28-29 цифр после запятой)
        /// </summary>
        /// <param name="value">Что преобразовывать</param>
        /// <returns>Преобразованное к типу <see cref="decimal"/> значение</returns>
        protected decimal Convert_ToDecimal(bool value) => ConvertProxy.Convert_ToDecimal(value);

        /// <summary>
        /// Преобразование к типу <see cref="bool"/> (System.Boolean) - 1 бит
        /// </summary>
        /// <param name="value">Что преобразовывать</param>
        /// <returns>Преобразованное к типу <see cref="bool"/> значение</returns>
        protected bool Convert_ToBoolean(string value) => ConvertProxy.Convert_ToBoolean(value);

        /// <summary>
        /// Преобразование к типу <see cref="bool"/> (System.Boolean) - 1 бит
        /// </summary>
        /// <param name="value">Что преобразовывать</param>
        /// <returns>Преобразованное к типу <see cref="bool"/> значение</returns>
        protected bool Convert_ToBoolean(uint value) => ConvertProxy.Convert_ToBoolean(value);

        /// <summary>
        /// Преобразование к типу <see cref="bool"/> (System.Boolean) - 1 бит
        /// </summary>
        /// <param name="value">Что преобразовывать</param>
        /// <returns>Преобразованное к типу <see cref="bool"/> значение</returns>
        protected bool Convert_ToBoolean(int value) => ConvertProxy.Convert_ToBoolean(value);

        /// <summary>
        /// Преобразование к типу <see cref="bool"/> (System.Boolean) - 1 бит
        /// </summary>
        /// <param name="value">Что преобразовывать</param>
        /// <returns>Преобразованное к типу <see cref="bool"/> значение</returns>
        protected bool Convert_ToBoolean(long value) => ConvertProxy.Convert_ToBoolean(value);

        /// <summary>
        /// Преобразование к типу <see cref="bool"/> (System.Boolean) - 1 бит
        /// </summary>
        /// <param name="value">Что преобразовывать</param>
        /// <returns>Преобразованное к типу <see cref="bool"/> значение</returns>
        protected bool Convert_ToBoolean(byte value) => ConvertProxy.Convert_ToBoolean(value);

        /// <summary>
        /// Преобразование к типу <see cref="bool"/> (System.Boolean) - 1 бит
        /// </summary>
        /// <param name="value">Что преобразовывать</param>
        /// <returns>Преобразованное к типу <see cref="bool"/> значение</returns>
        protected bool Convert_ToBoolean(ulong value) => ConvertProxy.Convert_ToBoolean(value);

        /// <summary>
        /// Преобразование к типу <see cref="bool"/> (System.Boolean) - 1 бит
        /// </summary>
        /// <param name="value">Что преобразовывать</param>
        /// <returns>Преобразованное к типу <see cref="bool"/> значение</returns>
        protected bool Convert_ToBoolean(short value) => ConvertProxy.Convert_ToBoolean(value);

        /// <summary>
        /// Преобразование к типу <see cref="bool"/> (System.Boolean) - 1 бит
        /// </summary>
        /// <param name="value">Что преобразовывать</param>
        /// <returns>Преобразованное к типу <see cref="bool"/> значение</returns>
        protected bool Convert_ToBoolean(ushort value) => ConvertProxy.Convert_ToBoolean(value);

        /// <summary>
        /// Преобразование к типу <see cref="bool"/> (System.Boolean) - 1 бит
        /// </summary>
        /// <param name="value">Что преобразовывать</param>
        /// <returns>Преобразованное к типу <see cref="bool"/> значение</returns>
        protected bool Convert_ToBoolean(double value) => ConvertProxy.Convert_ToBoolean(value);

        /// <summary>
        /// Преобразование к типу <see cref="bool"/> (System.Boolean) - 1 бит
        /// </summary>
        /// <param name="value">Что преобразовывать</param>
        /// <returns>Преобразованное к типу <see cref="bool"/> значение</returns>
        protected bool Convert_ToBoolean(sbyte value) => ConvertProxy.Convert_ToBoolean(value);

        /// <summary>
        /// Преобразование к типу <see cref="bool"/> (System.Boolean) - 1 бит
        /// </summary>
        /// <param name="value">Что преобразовывать</param>
        /// <returns>Преобразованное к типу <see cref="bool"/> значение</returns>
        protected bool Convert_ToBoolean(float value) => ConvertProxy.Convert_ToBoolean(value);

        /// <summary>
        /// Преобразование к типу <see cref="bool"/> (System.Boolean) - 1 бит
        /// </summary>
        /// <param name="value">Что преобразовывать</param>
        /// <returns>Преобразованное к типу <see cref="bool"/> значение</returns>
        protected bool Convert_ToBoolean(decimal value) => ConvertProxy.Convert_ToBoolean(value);

        /// <summary>
        /// Преобразование к типу <see cref="string"/> (System.String) - строка текста переменной длины, каждый символ - System.Char (2 байта), кодировка Unicode
        /// </summary>
        /// <param name="value">Что преобразовывать</param>
        /// <returns>Преобразованное к типу <see cref="string"/> значение</returns>
        protected string Convert_ToString(string value) => ConvertProxy.Convert_ToString(value);

        /// <summary>
        /// Преобразование к типу <see cref="string"/> (System.String) - строка текста переменной длины, каждый символ - System.Char (2 байта), кодировка Unicode
        /// </summary>
        /// <param name="value">Что преобразовывать</param>
        /// <returns>Преобразованное к типу <see cref="string"/> значение</returns>
        protected string Convert_ToString(uint value) => ConvertProxy.Convert_ToString(value);

        /// <summary>
        /// Преобразование к типу <see cref="string"/> (System.String) - строка текста переменной длины, каждый символ - System.Char (2 байта), кодировка Unicode
        /// </summary>
        /// <param name="value">Что преобразовывать</param>
        /// <returns>Преобразованное к типу <see cref="string"/> значение</returns>
        protected string Convert_ToString(int value) => ConvertProxy.Convert_ToString(value);

        /// <summary>
        /// Преобразование к типу <see cref="string"/> (System.String) - строка текста переменной длины, каждый символ - System.Char (2 байта), кодировка Unicode
        /// </summary>
        /// <param name="value">Что преобразовывать</param>
        /// <returns>Преобразованное к типу <see cref="string"/> значение</returns>
        protected string Convert_ToString(long value) => ConvertProxy.Convert_ToString(value);

        /// <summary>
        /// Преобразование к типу <see cref="string"/> (System.String) - строка текста переменной длины, каждый символ - System.Char (2 байта), кодировка Unicode
        /// </summary>
        /// <param name="value">Что преобразовывать</param>
        /// <returns>Преобразованное к типу <see cref="string"/> значение</returns>
        protected string Convert_ToString(byte value) => ConvertProxy.Convert_ToString(value);

        /// <summary>
        /// Преобразование к типу <see cref="string"/> (System.String) - строка текста переменной длины, каждый символ - System.Char (2 байта), кодировка Unicode
        /// </summary>
        /// <param name="value">Что преобразовывать</param>
        /// <returns>Преобразованное к типу <see cref="string"/> значение</returns>
        protected string Convert_ToString(ulong value) => ConvertProxy.Convert_ToString(value);

        /// <summary>
        /// Преобразование к типу <see cref="string"/> (System.String) - строка текста переменной длины, каждый символ - System.Char (2 байта), кодировка Unicode
        /// </summary>
        /// <param name="value">Что преобразовывать</param>
        /// <returns>Преобразованное к типу <see cref="string"/> значение</returns>
        protected string Convert_ToString(short value) => ConvertProxy.Convert_ToString(value);

        /// <summary>
        /// Преобразование к типу <see cref="string"/> (System.String) - строка текста переменной длины, каждый символ - System.Char (2 байта), кодировка Unicode
        /// </summary>
        /// <param name="value">Что преобразовывать</param>
        /// <returns>Преобразованное к типу <see cref="string"/> значение</returns>
        protected string Convert_ToString(ushort value) => ConvertProxy.Convert_ToString(value);

        /// <summary>
        /// Преобразование к типу <see cref="string"/> (System.String) - строка текста переменной длины, каждый символ - System.Char (2 байта), кодировка Unicode
        /// </summary>
        /// <param name="value">Что преобразовывать</param>
        /// <returns>Преобразованное к типу <see cref="string"/> значение</returns>
        protected string Convert_ToString(double value) => ConvertProxy.Convert_ToString(value);

        /// <summary>
        /// Преобразование к типу <see cref="string"/> (System.String) - строка текста переменной длины, каждый символ - System.Char (2 байта), кодировка Unicode
        /// </summary>
        /// <param name="value">Что преобразовывать</param>
        /// <returns>Преобразованное к типу <see cref="string"/> значение</returns>
        protected string Convert_ToString(sbyte value) => ConvertProxy.Convert_ToString(value);

        /// <summary>
        /// Преобразование к типу <see cref="string"/> (System.String) - строка текста переменной длины, каждый символ - System.Char (2 байта), кодировка Unicode
        /// </summary>
        /// <param name="value">Что преобразовывать</param>
        /// <returns>Преобразованное к типу <see cref="string"/> значение</returns>
        protected string Convert_ToString(float value) => ConvertProxy.Convert_ToString(value);

        /// <summary>
        /// Преобразование к типу <see cref="string"/> (System.String) - строка текста переменной длины, каждый символ - System.Char (2 байта), кодировка Unicode
        /// </summary>
        /// <param name="value">Что преобразовывать</param>
        /// <returns>Преобразованное к типу <see cref="string"/> значение</returns>
        protected string Convert_ToString(decimal value) => ConvertProxy.Convert_ToString(value);

        /// <summary>
        /// Преобразование к типу <see cref="string"/> (System.String) - строка текста переменной длины, каждый символ - System.Char (2 байта), кодировка Unicode
        /// </summary>
        /// <param name="value">Что преобразовывать</param>
        /// <returns>Преобразованное к типу <see cref="string"/> значение</returns>
        protected string Convert_ToString(DateTime value) => ConvertProxy.Convert_ToString(value);
    }
}

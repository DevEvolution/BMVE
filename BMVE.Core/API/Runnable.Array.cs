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
        /// Создает новый массив типа <see cref="ulong"/> указанного размера
        /// </summary>
        /// <param name="size">Размер массива</param>
        /// <returns>Новый массив</returns>
        protected ulong[] Array_OfULong(int size) => ArrayProxy.Array_Create<ulong>(size);

        /// <summary>
        /// Создает новый двухмерный массив типа <see cref="ulong"/> указанного размера
        /// </summary>
        /// <param name="sizeA">Первая размерность массива</param>
        /// <param name="sizeB">Вторая размерность массива</param>
        /// <returns>Новый массив</returns>
        protected ulong[,] Array_OfULong(int sizeA, int sizeB) => ArrayProxy.Array_Create2<ulong>(sizeA, sizeB);

        /// <summary>
        /// Создает новый трехмерный массив типа <see cref="ulong"/> указанного размера
        /// </summary>
        /// <param name="sizeA">Первая размерность массива</param>
        /// <param name="sizeB">Вторая размерность массива</param>
        /// <param name="sizeC">Третья размерность массива</param>
        /// <returns>Новый массив</returns>
        protected ulong[,,] Array_OfULong(int sizeA, int sizeB, int sizeC) => ArrayProxy.Array_Create3<ulong>(sizeA, sizeB, sizeC);

        /// <summary>
        /// Создает новый массив типа <see cref="long"/> указанного размера
        /// </summary>
        /// <param name="size">Размер массива</param>
        /// <returns>Новый массив</returns>
        protected long[] Array_OfLong(int size) => ArrayProxy.Array_Create<long>(size);

        /// <summary>
        /// Создает новый двухмерный массив типа <see cref="long"/> указанного размера
        /// </summary>
        /// <param name="sizeA">Первая размерность массива</param>
        /// <param name="sizeB">Вторая размерность массива</param>
        /// <returns>Новый массив</returns>
        protected long[,] Array_OfLong(int sizeA, int sizeB) => ArrayProxy.Array_Create2<long>(sizeA, sizeB);

        /// <summary>
        /// Создает новый трехмерный массив типа <see cref="long"/> указанного размера
        /// </summary>
        /// <param name="sizeA">Первая размерность массива</param>
        /// <param name="sizeB">Вторая размерность массива</param>
        /// <param name="sizeC">Третья размерность массива</param>
        /// <returns>Новый массив</returns>
        protected long[,,] Array_OfLong(int sizeA, int sizeB, int sizeC) => ArrayProxy.Array_Create3<long>(sizeA, sizeB, sizeC);

        /// <summary>
        /// Создает новый массив типа <see cref="uint"/> указанного размера
        /// </summary>
        /// <param name="size">Размер массива</param>
        /// <returns>Новый массив</returns>
        protected uint[] Array_OfUInt(int size) => ArrayProxy.Array_Create<uint>(size);

        /// <summary>
        /// Создает новый двухмерный массив типа <see cref="uint"/> указанного размера
        /// </summary>
        /// <param name="sizeA">Первая размерность массива</param>
        /// <param name="sizeB">Вторая размерность массива</param>
        /// <returns>Новый массив</returns>
        protected uint[,] Array_OfUInt(int sizeA, int sizeB) => ArrayProxy.Array_Create2<uint>(sizeA, sizeB);

        /// <summary>
        /// Создает новый трехмерный массив типа <see cref="uint"/> указанного размера
        /// </summary>
        /// <param name="sizeA">Первая размерность массива</param>
        /// <param name="sizeB">Вторая размерность массива</param>
        /// <param name="sizeC">Третья размерность массива</param>
        /// <returns>Новый массив</returns>
        protected uint[,,] Array_OfUInt(int sizeA, int sizeB, int sizeC) => ArrayProxy.Array_Create3<uint>(sizeA, sizeB, sizeC);

        /// <summary>
        /// Создает новый массив типа <see cref="int"/> указанного размера
        /// </summary>
        /// <param name="size">Размер массива</param>
        /// <returns>Новый массив</returns>
        protected int[] Array_OfInt(int size) => ArrayProxy.Array_Create<int>(size);

        /// <summary>
        /// Создает новый двухмерный массив типа <see cref="int"/> указанного размера
        /// </summary>
        /// <param name="sizeA">Первая размерность массива</param>
        /// <param name="sizeB">Вторая размерность массива</param>
        /// <returns>Новый массив</returns>
        protected int[,] Array_OfInt(int sizeA, int sizeB) => ArrayProxy.Array_Create2<int>(sizeA, sizeB);

        /// <summary>
        /// Создает новый трехмерный массив типа <see cref="int"/> указанного размера
        /// </summary>
        /// <param name="sizeA">Первая размерность массива</param>
        /// <param name="sizeB">Вторая размерность массива</param>
        /// <param name="sizeC">Третья размерность массива</param>
        /// <returns>Новый массив</returns>
        protected int[,,] Array_OfInt(int sizeA, int sizeB, int sizeC) => ArrayProxy.Array_Create3<int>(sizeA, sizeB, sizeC);

        /// <summary>
        /// Создает новый массив типа <see cref="ushort"/> указанного размера
        /// </summary>
        /// <param name="size">Размер массива</param>
        /// <returns>Новый массив</returns>
        protected ushort[] Array_OfUShort(int size) => ArrayProxy.Array_Create<ushort>(size);

        /// <summary>
        /// Создает новый двухмерный массив типа <see cref="ushort"/> указанного размера
        /// </summary>
        /// <param name="sizeA">Первая размерность массива</param>
        /// <param name="sizeB">Вторая размерность массива</param>
        /// <returns>Новый массив</returns>
        protected ushort[,] Array_OfUShort(int sizeA, int sizeB) => ArrayProxy.Array_Create2<ushort>(sizeA, sizeB);

        /// <summary>
        /// Создает новый трехмерный массив типа <see cref="ushort"/> указанного размера
        /// </summary>
        /// <param name="sizeA">Первая размерность массива</param>
        /// <param name="sizeB">Вторая размерность массива</param>
        /// <param name="sizeC">Третья размерность массива</param>
        /// <returns>Новый массив</returns>
        protected ushort[,,] Array_OfUShort(int sizeA, int sizeB, int sizeC) => ArrayProxy.Array_Create3<ushort>(sizeA, sizeB, sizeC);

        /// <summary>
        /// Создает новый массив типа <see cref="short"/> указанного размера
        /// </summary>
        /// <param name="size">Размер массива</param>
        /// <returns>Новый массив</returns>
        protected short[] Array_OfShort(int size) => ArrayProxy.Array_Create<short>(size);

        /// <summary>
        /// Создает новый двухмерный массив типа <see cref="short"/> указанного размера
        /// </summary>
        /// <param name="sizeA">Первая размерность массива</param>
        /// <param name="sizeB">Вторая размерность массива</param>
        /// <returns>Новый массив</returns>
        protected short[,] Array_OfShort(int sizeA, int sizeB) => ArrayProxy.Array_Create2<short>(sizeA, sizeB);

        /// <summary>
        /// Создает новый трехмерный массив типа <see cref="short"/> указанного размера
        /// </summary>
        /// <param name="sizeA">Первая размерность массива</param>
        /// <param name="sizeB">Вторая размерность массива</param>
        /// <param name="sizeC">Третья размерность массива</param>
        /// <returns>Новый массив</returns>
        protected short[,,] Array_OfShort(int sizeA, int sizeB, int sizeC) => ArrayProxy.Array_Create3<short>(sizeA, sizeB, sizeC);

        /// <summary>
        /// Создает новый массив типа <see cref="byte"/> указанного размера
        /// </summary>
        /// <param name="size">Размер массива</param>
        /// <returns>Новый массив</returns>
        protected byte[] Array_OfByte(int size) => ArrayProxy.Array_Create<byte>(size);

        /// <summary>
        /// Создает новый двухмерный массив типа <see cref="byte"/> указанного размера
        /// </summary>
        /// <param name="sizeA">Первая размерность массива</param>
        /// <param name="sizeB">Вторая размерность массива</param>
        /// <returns>Новый массив</returns>
        protected byte[,] Array_OfByte(int sizeA, int sizeB) => ArrayProxy.Array_Create2<byte>(sizeA, sizeB);

        /// <summary>
        /// Создает новый трехмерный массив типа <see cref="byte"/> указанного размера
        /// </summary>
        /// <param name="sizeA">Первая размерность массива</param>
        /// <param name="sizeB">Вторая размерность массива</param>
        /// <param name="sizeC">Третья размерность массива</param>
        /// <returns>Новый массив</returns>
        protected byte[,,] Array_OfByte(int sizeA, int sizeB, int sizeC) => ArrayProxy.Array_Create3<byte>(sizeA, sizeB, sizeC);

        /// <summary>
        /// Создает новый массив типа <see cref="sbyte"/> указанного размера
        /// </summary>
        /// <param name="size">Размер массива</param>
        /// <returns>Новый массив</returns>
        protected sbyte[] Array_OfSByte(int size) => ArrayProxy.Array_Create<sbyte>(size);

        /// <summary>
        /// Создает новый двухмерный массив типа <see cref="sbyte"/> указанного размера
        /// </summary>
        /// <param name="sizeA">Первая размерность массива</param>
        /// <param name="sizeB">Вторая размерность массива</param>
        /// <returns>Новый массив</returns>
        protected sbyte[,] Array_OfSByte(int sizeA, int sizeB) => ArrayProxy.Array_Create2<sbyte>(sizeA, sizeB);

        /// <summary>
        /// Создает новый трехмерный массив типа <see cref="sbyte"/> указанного размера
        /// </summary>
        /// <param name="sizeA">Первая размерность массива</param>
        /// <param name="sizeB">Вторая размерность массива</param>
        /// <param name="sizeC">Третья размерность массива</param>
        /// <returns>Новый массив</returns>
        protected sbyte[,,] Array_OfSByte(int sizeA, int sizeB, int sizeC) => ArrayProxy.Array_Create3<sbyte>(sizeA, sizeB, sizeC);

        /// <summary>
        /// Создает новый массив типа <see cref="decimal"/> указанного размера
        /// </summary>
        /// <param name="size">Размер массива</param>
        /// <returns>Новый массив</returns>
        protected decimal[] Array_OfDecimal(int size) => ArrayProxy.Array_Create<decimal>(size);

        /// <summary>
        /// Создает новый двухмерный массив типа <see cref="decimal"/> указанного размера
        /// </summary>
        /// <param name="sizeA">Первая размерность массива</param>
        /// <param name="sizeB">Вторая размерность массива</param>
        /// <returns>Новый массив</returns>
        protected decimal[,] Array_OfDecimal(int sizeA, int sizeB) => ArrayProxy.Array_Create2<decimal>(sizeA, sizeB);

        /// <summary>
        /// Создает новый трехмерный массив типа <see cref="decimal"/> указанного размера
        /// </summary>
        /// <param name="sizeA">Первая размерность массива</param>
        /// <param name="sizeB">Вторая размерность массива</param>
        /// <param name="sizeC">Третья размерность массива</param>
        /// <returns>Новый массив</returns>
        protected decimal[,,] Array_OfDecimal(int sizeA, int sizeB, int sizeC) => ArrayProxy.Array_Create3<decimal>(sizeA, sizeB, sizeC);

        /// <summary>
        /// Создает новый массив типа <see cref="double"/> указанного размера
        /// </summary>
        /// <param name="size">Размер массива</param>
        /// <returns>Новый массив</returns>
        protected double[] Array_OfDouble(int size) => ArrayProxy.Array_Create<double>(size);

        /// <summary>
        /// Создает новый двухмерный массив типа <see cref="double"/> указанного размера
        /// </summary>
        /// <param name="sizeA">Первая размерность массива</param>
        /// <param name="sizeB">Вторая размерность массива</param>
        /// <returns>Новый массив</returns>
        protected double[,] Array_OfDouble(int sizeA, int sizeB) => ArrayProxy.Array_Create2<double>(sizeA, sizeB);

        /// <summary>
        /// Создает новый трехмерный массив типа <see cref="double"/> указанного размера
        /// </summary>
        /// <param name="sizeA">Первая размерность массива</param>
        /// <param name="sizeB">Вторая размерность массива</param>
        /// <param name="sizeC">Третья размерность массива</param>
        /// <returns>Новый массив</returns>
        protected double[,,] Array_OfDouble(int sizeA, int sizeB, int sizeC) => ArrayProxy.Array_Create3<double>(sizeA, sizeB, sizeC);

        /// <summary>
        /// Создает новый массив типа <see cref="float"/> указанного размера
        /// </summary>
        /// <param name="size">Размер массива</param>
        /// <returns>Новый массив</returns>
        protected float[] Array_OfFloat(int size) => ArrayProxy.Array_Create<float>(size);

        /// <summary>
        /// Создает новый двухмерный массив типа <see cref="float"/> указанного размера
        /// </summary>
        /// <param name="sizeA">Первая размерность массива</param>
        /// <param name="sizeB">Вторая размерность массива</param>
        /// <returns>Новый массив</returns>
        protected float[,] Array_OfFloat(int sizeA, int sizeB) => ArrayProxy.Array_Create2<float>(sizeA, sizeB);

        /// <summary>
        /// Создает новый трехмерный массив типа <see cref="float"/> указанного размера
        /// </summary>
        /// <param name="sizeA">Первая размерность массива</param>
        /// <param name="sizeB">Вторая размерность массива</param>
        /// <param name="sizeC">Третья размерность массива</param>
        /// <returns>Новый массив</returns>
        protected float[,,] Array_OfFloat(int sizeA, int sizeB, int sizeC) => ArrayProxy.Array_Create3<float>(sizeA, sizeB, sizeC);

        /// <summary>
        /// Создает новый массив типа <see cref="bool"/> указанного размера
        /// </summary>
        /// <param name="size">Размер массива</param>
        /// <returns>Новый массив</returns>
        protected bool[] Array_OfBool(int size) => ArrayProxy.Array_Create<bool>(size);

        /// <summary>
        /// Создает новый двухмерный массив типа <see cref="bool"/> указанного размера
        /// </summary>
        /// <param name="sizeA">Первая размерность массива</param>
        /// <param name="sizeB">Вторая размерность массива</param>
        /// <returns>Новый массив</returns>
        protected bool[,] Array_OfBool(int sizeA, int sizeB) => ArrayProxy.Array_Create2<bool>(sizeA, sizeB);

        /// <summary>
        /// Создает новый трехмерный массив типа <see cref="float"/> указанного размера
        /// </summary>
        /// <param name="sizeA">Первая размерность массива</param>
        /// <param name="sizeB">Вторая размерность массива</param>
        /// <param name="sizeC">Третья размерность массива</param>
        /// <returns>Новый массив</returns>
        protected bool[,,] Array_OfBool(int sizeA, int sizeB, int sizeC) => ArrayProxy.Array_Create3<bool>(sizeA, sizeB, sizeC);

        /// <summary>
        /// Создает новый массив типа <see cref="char"/> указанного размера
        /// </summary>
        /// <param name="size">Размер массива</param>
        /// <returns>Новый массив</returns>
        protected char[] Array_OfChar(int size) => ArrayProxy.Array_Create<char>(size);

        /// <summary>
        /// Создает новый двухмерный массив типа <see cref="char"/> указанного размера
        /// </summary>
        /// <param name="sizeA">Первая размерность массива</param>
        /// <param name="sizeB">Вторая размерность массива</param>
        /// <returns>Новый массив</returns>
        protected char[,] Array_OfChar(int sizeA, int sizeB) => ArrayProxy.Array_Create2<char>(sizeA, sizeB);

        /// <summary>
        /// Создает новый трехмерный массив типа <see cref="char"/> указанного размера
        /// </summary>
        /// <param name="sizeA">Первая размерность массива</param>
        /// <param name="sizeB">Вторая размерность массива</param>
        /// <param name="sizeC">Третья размерность массива</param>
        /// <returns>Новый массив</returns>
        protected char[,,] Array_OfChar(int sizeA, int sizeB, int sizeC) => ArrayProxy.Array_Create3<char>(sizeA, sizeB, sizeC);

        /// <summary>
        /// Создает новый массив типа <see cref="string"/> указанного размера
        /// </summary>
        /// <param name="size">Размер массива</param>
        /// <returns>Новый массив</returns>
        protected string[] Array_OfString(int size) => ArrayProxy.Array_Create<string>(size);

        /// <summary>
        /// Создает новый двухмерный массив типа <see cref="string"/> указанного размера
        /// </summary>
        /// <param name="sizeA">Первая размерность массива</param>
        /// <param name="sizeB">Вторая размерность массива</param>
        /// <returns>Новый массив</returns>
        protected string[,] Array_OfString(int sizeA, int sizeB) => ArrayProxy.Array_Create2<string>(sizeA, sizeB);

        /// <summary>
        /// Создает новый трехмерный массив типа <see cref="string"/> указанного размера
        /// </summary>
        /// <param name="sizeA">Первая размерность массива</param>
        /// <param name="sizeB">Вторая размерность массива</param>
        /// <param name="sizeC">Третья размерность массива</param>
        /// <returns>Новый массив</returns>
        protected string[,,] Array_OfString(int sizeA, int sizeB, int sizeC) => ArrayProxy.Array_Create3<string>(sizeA, sizeB, sizeC);

        /// <summary>
        /// Создает новый массив типа <see cref="DateTime"/> указанного размера
        /// </summary>
        /// <param name="size">Размер массива</param>
        /// <returns>Новый массив</returns>
        protected DateTime[] Array_OfDateTime(int size) => ArrayProxy.Array_Create<DateTime>(size);

        /// <summary>
        /// Создает новый двухмерный массив типа <see cref="DateTime"/> указанного размера
        /// </summary>
        /// <param name="sizeA">Первая размерность массива</param>
        /// <param name="sizeB">Вторая размерность массива</param>
        /// <returns>Новый массив</returns>
        protected DateTime[,] Array_OfDateTime(int sizeA, int sizeB) => ArrayProxy.Array_Create2<DateTime>(sizeA, sizeB);

        /// <summary>
        /// Создает новый трехмерный массив типа <see cref="DateTime"/> указанного размера
        /// </summary>
        /// <param name="sizeA">Первая размерность массива</param>
        /// <param name="sizeB">Вторая размерность массива</param>
        /// <param name="sizeC">Третья размерность массива</param>
        /// <returns>Новый массив</returns>
        protected DateTime[,,] Array_OfDateTime(int sizeA, int sizeB, int sizeC) => ArrayProxy.Array_Create3<DateTime>(sizeA, sizeB, sizeC);

        /// <summary>
        /// Добавляет новый целочисленный элемент в конец массива
        /// </summary>
        /// <param name="array">Массив для добавления</param>
        /// <param name="value">Новый элемент</param>
        /// <returns>Массив с добавленным новым значением</returns>
        protected ulong[] Array_Add(ulong[] array, ulong value) => ArrayProxy.Array_Add(array, value);

        /// <summary>
        /// Добавляет новый целочисленный элемент в конец массива
        /// </summary>
        /// <param name="array">Массив для добавления</param>
        /// <param name="value">Новый элемент</param>
        /// <returns>Массив с добавленным новым значением</returns>
        protected long[] Array_Add(long[] array, long value) => ArrayProxy.Array_Add(array, value);

        /// <summary>
        /// Добавляет новый целочисленный элемент в конец массива
        /// </summary>
        /// <param name="array">Массив для добавления</param>
        /// <param name="value">Новый элемент</param>
        /// <returns>Массив с добавленным новым значением</returns>
        protected uint[] Array_Add(uint[] array, uint value) => ArrayProxy.Array_Add(array, value);

        /// <summary>
        /// Добавляет новый целочисленный элемент в конец массива
        /// </summary>
        /// <param name="array">Массив для добавления</param>
        /// <param name="value">Новый элемент</param>
        /// <returns>Массив с добавленным новым значением</returns>
        protected int[] Array_Add(int[] array, int value) => ArrayProxy.Array_Add(array, value);

        /// <summary>
        /// Добавляет новый целочисленный элемент в конец массива
        /// </summary>
        /// <param name="array">Массив для добавления</param>
        /// <param name="value">Новый элемент</param>
        /// <returns>Массив с добавленным новым значением</returns>
        protected ushort[] Array_Add(ushort[] array, ushort value) => ArrayProxy.Array_Add(array, value);
        
        /// <summary>
        /// Добавляет новый целочисленный элемент в конец массива
        /// </summary>
        /// <param name="array">Массив для добавления</param>
        /// <param name="value">Новый элемент</param>
        /// <returns>Массив с добавленным новым значением</returns>
        protected short[] Array_Add(short[] array, short value) => ArrayProxy.Array_Add(array, value);

        /// <summary>
        /// Добавляет новый целочисленный элемент в конец массива
        /// </summary>
        /// <param name="array">Массив для добавления</param>
        /// <param name="value">Новый элемент</param>
        /// <returns>Массив с добавленным новым значением</returns>
        protected byte[] Array_Add(byte[] array, byte value) => ArrayProxy.Array_Add(array, value);
        
        /// <summary>
        /// Добавляет новый целочисленный элемент в конец массива
        /// </summary>
        /// <param name="array">Массив для добавления</param>
        /// <param name="value">Новый элемент</param>
        /// <returns>Массив с добавленным новым значением</returns>
        protected sbyte[] Array_Add(sbyte[] array, sbyte value) => ArrayProxy.Array_Add(array, value);
        
        /// <summary>
        /// Добавляет новый целочисленный элемент в конец массива
        /// </summary>
        /// <param name="array">Массив для добавления</param>
        /// <param name="value">Новый элемент</param>
        /// <returns>Массив с добавленным новым значением</returns>
        protected bool[] Array_Add(bool[] array, bool value) => ArrayProxy.Array_Add(array, value);

        /// <summary>
        /// Добавляет новый дробный элемент в конец массива
        /// </summary>
        /// <param name="array">Массив для добавления</param>
        /// <param name="value">Новый элемент</param>
        /// <returns>Массив с добавленным новым значением</returns>
        protected decimal[] Array_Add(decimal[] array, decimal value) => ArrayProxy.Array_Add(array, value);

        /// <summary>
        /// Добавляет новый дробный элемент в конец массива
        /// </summary>
        /// <param name="array">Массив для добавления</param>
        /// <param name="value">Новый элемент</param>
        /// <returns>Массив с добавленным новым значением</returns>
        protected double[] Array_Add(double[] array, double value) => ArrayProxy.Array_Add(array, value);
        
        /// <summary>
        /// Добавляет новый дробный элемент в конец массива
        /// </summary>
        /// <param name="array">Массив для добавления</param>
        /// <param name="value">Новый элемент</param>
        /// <returns>Массив с добавленным новым значением</returns>
        protected float[] Array_Add(float[] array, float value) => ArrayProxy.Array_Add(array, value);

        /// <summary>
        /// Добавляет новый элемент-строку в конец массива
        /// </summary>
        /// <param name="array">Массив для добавления</param>
        /// <param name="value">Новый элемент</param>
        /// <returns>Массив с добавленным новым значением</returns>
        protected char[] Array_Add(char[] array, char value) => ArrayProxy.Array_Add(array, value);

        /// <summary>
        /// Добавляет новый элемент-строку в конец массива
        /// </summary>
        /// <param name="array">Массив для добавления</param>
        /// <param name="value">Новый элемент</param>
        /// <returns>Массив с добавленным новым значением</returns>
        protected string[] Array_Add(string[] array, string value) => ArrayProxy.Array_Add(array, value);

        /// <summary>
        /// Добавляет новый элемент в конец массива
        /// </summary>
        /// <param name="array">Массив для добавления</param>
        /// <param name="value">Новый элемент</param>
        /// <returns>Массив с добавленным новым значением</returns>
        protected DateTime[] Array_Add(DateTime[] array, DateTime value) => ArrayProxy.Array_Add(array, value);

        /// <summary>
        /// Вставляет новый элемент по указанному индексу в массиве
        /// </summary>
        /// <param name="array">Массив для вставки</param>
        /// <param name="index">Индекс, куда будет вставлен элемент</param>
        /// <param name="value">Значение, которое будет вставлено</param>
        /// <returns>Массив со вставленным значением</returns>
        protected ulong[] Array_Insert(ulong[] array, int index, ulong value) => ArrayProxy.Array_Insert(array, index, value);

        /// <summary>
        /// Вставляет новый элемент по указанному индексу в массиве
        /// </summary>
        /// <param name="array">Массив для вставки</param>
        /// <param name="index">Индекс, куда будет вставлен элемент</param>
        /// <param name="value">Значение, которое будет вставлено</param>
        /// <returns>Массив со вставленным значением</returns>
        protected long[] Array_Insert(long[] array, int index, long value) => ArrayProxy.Array_Insert(array, index, value);

        /// <summary>
        /// Вставляет новый элемент по указанному индексу в массиве
        /// </summary>
        /// <param name="array">Массив для вставки</param>
        /// <param name="index">Индекс, куда будет вставлен элемент</param>
        /// <param name="value">Значение, которое будет вставлено</param>
        /// <returns>Массив со вставленным значением</returns>
        protected uint[] Array_Insert(uint[] array, int index, uint value) => ArrayProxy.Array_Insert(array, index, value);

        /// <summary>
        /// Вставляет новый элемент по указанному индексу в массиве
        /// </summary>
        /// <param name="array">Массив для вставки</param>
        /// <param name="index">Индекс, куда будет вставлен элемент</param>
        /// <param name="value">Значение, которое будет вставлено</param>
        /// <returns>Массив со вставленным значением</returns>
        protected int[] Array_Insert(int[] array, int index, int value) => ArrayProxy.Array_Insert(array, index, value);

        /// <summary>
        /// Вставляет новый элемент по указанному индексу в массиве
        /// </summary>
        /// <param name="array">Массив для вставки</param>
        /// <param name="index">Индекс, куда будет вставлен элемент</param>
        /// <param name="value">Значение, которое будет вставлено</param>
        /// <returns>Массив со вставленным значением</returns>
        protected ushort[] Array_Insert(ushort[] array, int index, ushort value) => ArrayProxy.Array_Insert(array, index, value);

        /// <summary>
        /// Вставляет новый элемент по указанному индексу в массиве
        /// </summary>
        /// <param name="array">Массив для вставки</param>
        /// <param name="index">Индекс, куда будет вставлен элемент</param>
        /// <param name="value">Значение, которое будет вставлено</param>
        /// <returns>Массив со вставленным значением</returns>
        protected short[] Array_Insert(short[] array, int index, short value) => ArrayProxy.Array_Insert(array, index, value);

        /// <summary>
        /// Вставляет новый элемент по указанному индексу в массиве
        /// </summary>
        /// <param name="array">Массив для вставки</param>
        /// <param name="index">Индекс, куда будет вставлен элемент</param>
        /// <param name="value">Значение, которое будет вставлено</param>
        /// <returns>Массив со вставленным значением</returns>
        protected byte[] Array_Insert(byte[] array, int index, byte value) => ArrayProxy.Array_Insert(array, index, value);

        /// <summary>
        /// Вставляет новый элемент по указанному индексу в массиве
        /// </summary>
        /// <param name="array">Массив для вставки</param>
        /// <param name="index">Индекс, куда будет вставлен элемент</param>
        /// <param name="value">Значение, которое будет вставлено</param>
        /// <returns>Массив со вставленным значением</returns>
        protected sbyte[] Array_Insert(sbyte[] array, int index, sbyte value) => ArrayProxy.Array_Insert(array, index, value);

        /// <summary>
        /// Вставляет новый элемент по указанному индексу в массиве
        /// </summary>
        /// <param name="array">Массив для вставки</param>
        /// <param name="index">Индекс, куда будет вставлен элемент</param>
        /// <param name="value">Значение, которое будет вставлено</param>
        /// <returns>Массив со вставленным значением</returns>
        protected bool[] Array_Insert(bool[] array, int index, bool value) => ArrayProxy.Array_Insert(array, index, value);

        /// <summary>
        /// Вставляет новый элемент по указанному индексу в массиве
        /// </summary>
        /// <param name="array">Массив для вставки</param>
        /// <param name="index">Индекс, куда будет вставлен элемент</param>
        /// <param name="value">Значение, которое будет вставлено</param>
        /// <returns>Массив со вставленным значением</returns>
        protected decimal[] Array_Insert(decimal[] array, int index, decimal value) => ArrayProxy.Array_Insert(array, index, value);

        /// <summary>
        /// Вставляет новый элемент по указанному индексу в массиве
        /// </summary>
        /// <param name="array">Массив для вставки</param>
        /// <param name="index">Индекс, куда будет вставлен элемент</param>
        /// <param name="value">Значение, которое будет вставлено</param>
        /// <returns>Массив со вставленным значением</returns>
        protected double[] Array_Insert(double[] array, int index, double value) => ArrayProxy.Array_Insert(array, index, value);

        /// <summary>
        /// Вставляет новый элемент по указанному индексу в массиве
        /// </summary>
        /// <param name="array">Массив для вставки</param>
        /// <param name="index">Индекс, куда будет вставлен элемент</param>
        /// <param name="value">Значение, которое будет вставлено</param>
        /// <returns>Массив со вставленным значением</returns>
        protected float[] Array_Insert(float[] array, int index, float value) => ArrayProxy.Array_Insert(array, index, value);

        /// <summary>
        /// Вставляет новый элемент по указанному индексу в массиве
        /// </summary>
        /// <param name="array">Массив для вставки</param>
        /// <param name="index">Индекс, куда будет вставлен элемент</param>
        /// <param name="value">Значение, которое будет вставлено</param>
        /// <returns>Массив со вставленным значением</returns>
        protected char[] Array_Insert(char[] array, int index, char value) => ArrayProxy.Array_Insert(array, index, value);

        /// <summary>
        /// Вставляет новый элемент по указанному индексу в массиве
        /// </summary>
        /// <param name="array">Массив для вставки</param>
        /// <param name="index">Индекс, куда будет вставлен элемент</param>
        /// <param name="value">Значение, которое будет вставлено</param>
        /// <returns>Массив со вставленным значением</returns>
        protected string[] Array_Insert(string[] array, int index, string value) => ArrayProxy.Array_Insert(array, index, value);

        /// <summary>
        /// Вставляет новый элемент по указанному индексу в массиве
        /// </summary>
        /// <param name="array">Массив для вставки</param>
        /// <param name="index">Индекс, куда будет вставлен элемент</param>
        /// <param name="value">Значение, которое будет вставлено</param>
        /// <returns>Массив со вставленным значением</returns>
        protected DateTime[] Array_Insert(DateTime[] array, int index, DateTime value) => ArrayProxy.Array_Insert(array, index, value);

        /// <summary>
        /// Удаляет элемент по указанному индексу в массиве
        /// </summary>
        /// <param name="array">Массив</param>
        /// <param name="index">Индекс, откуда будет удален элемент</param>
        /// <returns>Массив с удаленным значением</returns>
        protected ulong[] Array_Remove(ulong[] array, int index) => ArrayProxy.Array_Remove(array, index);

        /// <summary>
        /// Удаляет элемент по указанному индексу в массиве
        /// </summary>
        /// <param name="array">Массив</param>
        /// <param name="index">Индекс, откуда будет удален элемент</param>
        /// <returns>Массив с удаленным значением</returns>
        protected long[] Array_Remove(long[] array, int index) => ArrayProxy.Array_Remove(array, index);

        /// <summary>
        /// Удаляет элемент по указанному индексу в массиве
        /// </summary>
        /// <param name="array">Массив</param>
        /// <param name="index">Индекс, откуда будет удален элемент</param>
        /// <returns>Массив с удаленным значением</returns>
        protected uint[] Array_Remove(uint[] array, int index) => ArrayProxy.Array_Remove(array, index);

        /// <summary>
        /// Удаляет элемент по указанному индексу в массиве
        /// </summary>
        /// <param name="array">Массив</param>
        /// <param name="index">Индекс, откуда будет удален элемент</param>
        /// <returns>Массив с удаленным значением</returns>
        protected int[] Array_Remove(int[] array, int index) => ArrayProxy.Array_Remove(array, index);

        /// <summary>
        /// Удаляет элемент по указанному индексу в массиве
        /// </summary>
        /// <param name="array">Массив</param>
        /// <param name="index">Индекс, откуда будет удален элемент</param>
        /// <returns>Массив с удаленным значением</returns>
        protected ushort[] Array_Remove(ushort[] array, int index) => ArrayProxy.Array_Remove(array, index);

        /// <summary>
        /// Удаляет элемент по указанному индексу в массиве
        /// </summary>
        /// <param name="array">Массив</param>
        /// <param name="index">Индекс, откуда будет удален элемент</param>
        /// <returns>Массив с удаленным значением</returns>
        protected short[] Array_Remove(short[] array, int index) => ArrayProxy.Array_Remove(array, index);

        /// <summary>
        /// Удаляет элемент по указанному индексу в массиве
        /// </summary>
        /// <param name="array">Массив</param>
        /// <param name="index">Индекс, откуда будет удален элемент</param>
        /// <returns>Массив с удаленным значением</returns>
        protected byte[] Array_Remove(byte[] array, int index) => ArrayProxy.Array_Remove(array, index);

        /// <summary>
        /// Удаляет элемент по указанному индексу в массиве
        /// </summary>
        /// <param name="array">Массив</param>
        /// <param name="index">Индекс, откуда будет удален элемент</param>
        /// <returns>Массив с удаленным значением</returns>
        protected sbyte[] Array_Remove(sbyte[] array, int index) => ArrayProxy.Array_Remove(array, index);

        /// <summary>
        /// Удаляет элемент по указанному индексу в массиве
        /// </summary>
        /// <param name="array">Массив</param>
        /// <param name="index">Индекс, откуда будет удален элемент</param>
        /// <returns>Массив с удаленным значением</returns>
        protected decimal[] Array_Remove(decimal[] array, int index) => ArrayProxy.Array_Remove(array, index);

        /// <summary>
        /// Удаляет элемент по указанному индексу в массиве
        /// </summary>
        /// <param name="array">Массив</param>
        /// <param name="index">Индекс, откуда будет удален элемент</param>
        /// <returns>Массив с удаленным значением</returns>
        protected double[] Array_Remove(double[] array, int index) => ArrayProxy.Array_Remove(array, index);

        /// <summary>
        /// Удаляет элемент по указанному индексу в массиве
        /// </summary>
        /// <param name="array">Массив</param>
        /// <param name="index">Индекс, откуда будет удален элемент</param>
        /// <returns>Массив с удаленным значением</returns>
        protected float[] Array_Remove(float[] array, int index) => ArrayProxy.Array_Remove(array, index);

        /// <summary>
        /// Удаляет элемент по указанному индексу в массиве
        /// </summary>
        /// <param name="array">Массив</param>
        /// <param name="index">Индекс, откуда будет удален элемент</param>
        /// <returns>Массив с удаленным значением</returns>
        protected char[] Array_Remove(char[] array, int index) => ArrayProxy.Array_Remove(array, index);

        /// <summary>
        /// Удаляет элемент по указанному индексу в массиве
        /// </summary>
        /// <param name="array">Массив</param>
        /// <param name="index">Индекс, откуда будет удален элемент</param>
        /// <returns>Массив с удаленным значением</returns>
        protected string[] Array_Remove(string[] array, int index) => ArrayProxy.Array_Remove(array, index);

        /// <summary>
        /// Удаляет элемент по указанному индексу в массиве
        /// </summary>
        /// <param name="array">Массив</param>
        /// <param name="index">Индекс, откуда будет удален элемент</param>
        /// <returns>Массив с удаленным значением</returns>
        protected bool[] Array_Remove(bool[] array, int index) => ArrayProxy.Array_Remove(array, index);

        /// <summary>
        /// Удаляет элемент по указанному индексу в массиве
        /// </summary>
        /// <param name="array">Массив</param>
        /// <param name="index">Индекс, откуда будет удален элемент</param>
        /// <returns>Массив с удаленным значением</returns>
        protected DateTime[] Array_Remove(DateTime[] array, int index) => ArrayProxy.Array_Remove(array, index);

        /// <summary>
        /// Возвращает количество элементов в массиве
        /// </summary>
        /// <param name="array">Массив</param>
        /// <returns>Количество элементов в массиве</returns>
        protected int Array_Length(ulong[] array) => ArrayProxy.Array_Length(array);

        /// <summary>
        /// Возвращает размерность указанного измерения массива
        /// </summary>
        /// <param name="array">Массив</param>
        /// <param name="dimension">Измерение</param>
        /// <returns>Размерность указанного измерения массива</returns>
        protected int Array_Length(ulong[,] array, int dimension) => ArrayProxy.Array_Length(array, dimension);

        /// <summary>
        /// Возвращает размерность указанного измерения массива
        /// </summary>
        /// <param name="array">Массив</param>
        /// <param name="dimension">Измерение</param>
        /// <returns>Размерность указанного измерения массива</returns>
        protected int Array_Length(ulong[,,] array, int dimension) => ArrayProxy.Array_Length(array, dimension);

        /// <summary>
        /// Возвращает количество элементов в массиве
        /// </summary>
        /// <param name="array">Массив</param>
        /// <returns>Количество элементов в массиве</returns>
        protected int Array_Length(long[] array) => ArrayProxy.Array_Length(array);

        /// <summary>
        /// Возвращает размерность указанного измерения массива
        /// </summary>
        /// <param name="array">Массив</param>
        /// <param name="dimension">Измерение</param>
        /// <returns>Размерность указанного измерения массива</returns>
        protected int Array_Length(long[,] array, int dimension) => ArrayProxy.Array_Length(array, dimension);

        /// <summary>
        /// Возвращает размерность указанного измерения массива
        /// </summary>
        /// <param name="array">Массив</param>
        /// <param name="dimension">Измерение</param>
        /// <returns>Размерность указанного измерения массива</returns>
        protected int Array_Length(long[,,] array, int dimension) => ArrayProxy.Array_Length(array, dimension);

        /// <summary>
        /// Возвращает количество элементов в массиве
        /// </summary>
        /// <param name="array">Массив</param>
        /// <returns>Количество элементов в массиве</returns>
        protected int Array_Length(uint[] array) => ArrayProxy.Array_Length(array);

        /// <summary>
        /// Возвращает размерность указанного измерения массива
        /// </summary>
        /// <param name="array">Массив</param>
        /// <param name="dimension">Измерение</param>
        /// <returns>Размерность указанного измерения массива</returns>
        protected int Array_Length(uint[,] array, int dimension) => ArrayProxy.Array_Length(array, dimension);

        /// <summary>
        /// Возвращает размерность указанного измерения массива
        /// </summary>
        /// <param name="array">Массив</param>
        /// <param name="dimension">Измерение</param>
        /// <returns>Размерность указанного измерения массива</returns>
        protected int Array_Length(uint[,,] array, int dimension) => ArrayProxy.Array_Length(array, dimension);

        /// <summary>
        /// Возвращает количество элементов в массиве
        /// </summary>
        /// <param name="array">Массив</param>
        /// <returns>Количество элементов в массиве</returns>
        protected int Array_Length(int[] array) => ArrayProxy.Array_Length(array);

        /// <summary>
        /// Возвращает размерность указанного измерения массива
        /// </summary>
        /// <param name="array">Массив</param>
        /// <param name="dimension">Измерение</param>
        /// <returns>Размерность указанного измерения массива</returns>
        protected int Array_Length(int[,] array, int dimension) => ArrayProxy.Array_Length(array, dimension);

        /// <summary>
        /// Возвращает размерность указанного измерения массива
        /// </summary>
        /// <param name="array">Массив</param>
        /// <param name="dimension">Измерение</param>
        /// <returns>Размерность указанного измерения массива</returns>
        protected int Array_Length(int[,,] array, int dimension) => ArrayProxy.Array_Length(array, dimension);

        /// <summary>
        /// Возвращает количество элементов в массиве
        /// </summary>
        /// <param name="array">Массив</param>
        /// <returns>Количество элементов в массиве</returns>
        protected int Array_Length(ushort[] array) => ArrayProxy.Array_Length(array);

        /// <summary>
        /// Возвращает размерность указанного измерения массива
        /// </summary>
        /// <param name="array">Массив</param>
        /// <param name="dimension">Измерение</param>
        /// <returns>Размерность указанного измерения массива</returns>
        protected int Array_Length(ushort[,] array, int dimension) => ArrayProxy.Array_Length(array, dimension);

        /// <summary>
        /// Возвращает размерность указанного измерения массива
        /// </summary>
        /// <param name="array">Массив</param>
        /// <param name="dimension">Измерение</param>
        /// <returns>Размерность указанного измерения массива</returns>
        protected int Array_Length(ushort[,,] array, int dimension) => ArrayProxy.Array_Length(array, dimension);

        /// <summary>
        /// Возвращает количество элементов в массиве
        /// </summary>
        /// <param name="array">Массив</param>
        /// <returns>Количество элементов в массиве</returns>
        protected int Array_Length(short[] array) => ArrayProxy.Array_Length(array);

        /// <summary>
        /// Возвращает размерность указанного измерения массива
        /// </summary>
        /// <param name="array">Массив</param>
        /// <param name="dimension">Измерение</param>
        /// <returns>Размерность указанного измерения массива</returns>
        protected int Array_Length(short[,] array, int dimension) => ArrayProxy.Array_Length(array, dimension);

        /// <summary>
        /// Возвращает размерность указанного измерения массива
        /// </summary>
        /// <param name="array">Массив</param>
        /// <param name="dimension">Измерение</param>
        /// <returns>Размерность указанного измерения массива</returns>
        protected int Array_Length(short[,,] array, int dimension) => ArrayProxy.Array_Length(array, dimension);

        /// <summary>
        /// Возвращает количество элементов в массиве
        /// </summary>
        /// <param name="array">Массив</param>
        /// <returns>Количество элементов в массиве</returns>
        protected int Array_Length(byte[] array) => ArrayProxy.Array_Length(array);

        /// <summary>
        /// Возвращает размерность указанного измерения массива
        /// </summary>
        /// <param name="array">Массив</param>
        /// <param name="dimension">Измерение</param>
        /// <returns>Размерность указанного измерения массива</returns>
        protected int Array_Length(byte[,] array, int dimension) => ArrayProxy.Array_Length(array, dimension);

        /// <summary>
        /// Возвращает размерность указанного измерения массива
        /// </summary>
        /// <param name="array">Массив</param>
        /// <param name="dimension">Измерение</param>
        /// <returns>Размерность указанного измерения массива</returns>
        protected int Array_Length(byte[,,] array, int dimension) => ArrayProxy.Array_Length(array, dimension);

        /// <summary>
        /// Возвращает количество элементов в массиве
        /// </summary>
        /// <param name="array">Массив</param>
        /// <returns>Количество элементов в массиве</returns>
        protected int Array_Length(sbyte[] array) => ArrayProxy.Array_Length(array);

        /// <summary>
        /// Возвращает размерность указанного измерения массива
        /// </summary>
        /// <param name="array">Массив</param>
        /// <param name="dimension">Измерение</param>
        /// <returns>Размерность указанного измерения массива</returns>
        protected int Array_Length(sbyte[,] array, int dimension) => ArrayProxy.Array_Length(array, dimension);

        /// <summary>
        /// Возвращает размерность указанного измерения массива
        /// </summary>
        /// <param name="array">Массив</param>
        /// <param name="dimension">Измерение</param>
        /// <returns>Размерность указанного измерения массива</returns>
        protected int Array_Length(sbyte[,,] array, int dimension) => ArrayProxy.Array_Length(array, dimension);

        /// <summary>
        /// Возвращает количество элементов в массиве
        /// </summary>
        /// <param name="array">Массив</param>
        /// <returns>Количество элементов в массиве</returns>
        protected int Array_Length(decimal[] array) => ArrayProxy.Array_Length(array);

        /// <summary>
        /// Возвращает размерность указанного измерения массива
        /// </summary>
        /// <param name="array">Массив</param>
        /// <param name="dimension">Измерение</param>
        /// <returns>Размерность указанного измерения массива</returns>
        protected int Array_Length(decimal[,] array, int dimension) => ArrayProxy.Array_Length(array, dimension);

        /// <summary>
        /// Возвращает размерность указанного измерения массива
        /// </summary>
        /// <param name="array">Массив</param>
        /// <param name="dimension">Измерение</param>
        /// <returns>Размерность указанного измерения массива</returns>
        protected int Array_Length(decimal[,,] array, int dimension) => ArrayProxy.Array_Length(array, dimension);

        /// <summary>
        /// Возвращает количество элементов в массиве
        /// </summary>
        /// <param name="array">Массив</param>
        /// <returns>Количество элементов в массиве</returns>
        protected int Array_Length(double[] array) => ArrayProxy.Array_Length(array);

        /// <summary>
        /// Возвращает размерность указанного измерения массива
        /// </summary>
        /// <param name="array">Массив</param>
        /// <param name="dimension">Измерение</param>
        /// <returns>Размерность указанного измерения массива</returns>
        protected int Array_Length(double[,] array, int dimension) => ArrayProxy.Array_Length(array, dimension);

        /// <summary>
        /// Возвращает размерность указанного измерения массива
        /// </summary>
        /// <param name="array">Массив</param>
        /// <param name="dimension">Измерение</param>
        /// <returns>Размерность указанного измерения массива</returns>
        protected int Array_Length(double[,,] array, int dimension) => ArrayProxy.Array_Length(array, dimension);

        /// <summary>
        /// Возвращает количество элементов в массиве
        /// </summary>
        /// <param name="array">Массив</param>
        /// <returns>Количество элементов в массиве</returns>
        protected int Array_Length(float[] array) => ArrayProxy.Array_Length(array);

        /// <summary>
        /// Возвращает размерность указанного измерения массива
        /// </summary>
        /// <param name="array">Массив</param>
        /// <param name="dimension">Измерение</param>
        /// <returns>Размерность указанного измерения массива</returns>
        protected int Array_Length(float[,] array, int dimension) => ArrayProxy.Array_Length(array, dimension);

        /// <summary>
        /// Возвращает размерность указанного измерения массива
        /// </summary>
        /// <param name="array">Массив</param>
        /// <param name="dimension">Измерение</param>
        /// <returns>Размерность указанного измерения массива</returns>
        protected int Array_Length(float[,,] array, int dimension) => ArrayProxy.Array_Length(array, dimension);

        /// <summary>
        /// Возвращает количество элементов в массиве
        /// </summary>
        /// <param name="array">Массив</param>
        /// <returns>Количество элементов в массиве</returns>
        protected int Array_Length(char[] array) => ArrayProxy.Array_Length(array);

        /// <summary>
        /// Возвращает размерность указанного измерения массива
        /// </summary>
        /// <param name="array">Массив</param>
        /// <param name="dimension">Измерение</param>
        /// <returns>Размерность указанного измерения массива</returns>
        protected int Array_Length(char[,] array, int dimension) => ArrayProxy.Array_Length(array, dimension);

        /// <summary>
        /// Возвращает размерность указанного измерения массива
        /// </summary>
        /// <param name="array">Массив</param>
        /// <param name="dimension">Измерение</param>
        /// <returns>Размерность указанного измерения массива</returns>
        protected int Array_Length(char[,,] array, int dimension) => ArrayProxy.Array_Length(array, dimension);

        /// <summary>
        /// Возвращает количество элементов в массиве
        /// </summary>
        /// <param name="array">Массив</param>
        /// <returns>Количество элементов в массиве</returns>
        protected int Array_Length(string[] array) => ArrayProxy.Array_Length(array);

        /// <summary>
        /// Возвращает размерность указанного измерения массива
        /// </summary>
        /// <param name="array">Массив</param>
        /// <param name="dimension">Измерение</param>
        /// <returns>Размерность указанного измерения массива</returns>
        protected int Array_Length(string[,] array, int dimension) => ArrayProxy.Array_Length(array, dimension);

        /// <summary>
        /// Возвращает размерность указанного измерения массива
        /// </summary>
        /// <param name="array">Массив</param>
        /// <param name="dimension">Измерение</param>
        /// <returns>Размерность указанного измерения массива</returns>
        protected int Array_Length(string[,,] array, int dimension) => ArrayProxy.Array_Length(array, dimension);

        /// <summary>
        /// Возвращает количество элементов в массиве
        /// </summary>
        /// <param name="array">Массив</param>
        /// <returns>Количество элементов в массиве</returns>
        protected int Array_Length(bool[] array) => ArrayProxy.Array_Length(array);

        /// <summary>
        /// Возвращает размерность указанного измерения массива
        /// </summary>
        /// <param name="array">Массив</param>
        /// <param name="dimension">Измерение</param>
        /// <returns>Размерность указанного измерения массива</returns>
        protected int Array_Length(bool[,] array, int dimension) => ArrayProxy.Array_Length(array, dimension);

        /// <summary>
        /// Возвращает размерность указанного измерения массива
        /// </summary>
        /// <param name="array">Массив</param>
        /// <param name="dimension">Измерение</param>
        /// <returns>Размерность указанного измерения массива</returns>
        protected int Array_Length(bool[,,] array, int dimension) => ArrayProxy.Array_Length(array, dimension);

        /// <summary>
        /// Возвращает количество элементов в массиве
        /// </summary>
        /// <param name="array">Массив</param>
        /// <returns>Количество элементов в массиве</returns>
        protected int Array_Length(DateTime[] array) => ArrayProxy.Array_Length(array);

        /// <summary>
        /// Возвращает размерность указанного измерения массива
        /// </summary>
        /// <param name="array">Массив</param>
        /// <param name="dimension">Измерение</param>
        /// <returns>Размерность указанного измерения массива</returns>
        protected int Array_Length(DateTime[,] array, int dimension) => ArrayProxy.Array_Length(array, dimension);

        /// <summary>
        /// Возвращает размерность указанного измерения массива
        /// </summary>
        /// <param name="array">Массив</param>
        /// <param name="dimension">Измерение</param>
        /// <returns>Размерность указанного измерения массива</returns>
        protected int Array_Length(DateTime[,,] array, int dimension) => ArrayProxy.Array_Length(array, dimension);

        /// <summary>
        /// Проверяет массив на наличие заданного элемента
        /// </summary>
        /// <param name="array">Массив</param>
        /// <param name="value">Элемент, на наличие которого проверяется</param>
        /// <returns>Есть ли в массиве указанный элемент</returns>
        protected bool Array_Contains(ulong[] array, ulong value) => ArrayProxy.Array_Contains(array, value);

        /// <summary>
        /// Проверяет массив на наличие заданного элемента
        /// </summary>
        /// <param name="array">Массив</param>
        /// <param name="value">Элемент, на наличие которого проверяется</param>
        /// <returns>Есть ли в массиве указанный элемент</returns>
        protected bool Array_Contains(long[] array, long value) => ArrayProxy.Array_Contains(array, value);

        /// <summary>
        /// Проверяет массив на наличие заданного элемента
        /// </summary>
        /// <param name="array">Массив</param>
        /// <param name="value">Элемент, на наличие которого проверяется</param>
        /// <returns>Есть ли в массиве указанный элемент</returns>
        protected bool Array_Contains(uint[] array, uint value) => ArrayProxy.Array_Contains(array, value);

        /// <summary>
        /// Проверяет массив на наличие заданного элемента
        /// </summary>
        /// <param name="array">Массив</param>
        /// <param name="value">Элемент, на наличие которого проверяется</param>
        /// <returns>Есть ли в массиве указанный элемент</returns>
        protected bool Array_Contains(int[] array, int value) => ArrayProxy.Array_Contains(array, value);

        /// <summary>
        /// Проверяет массив на наличие заданного элемента
        /// </summary>
        /// <param name="array">Массив</param>
        /// <param name="value">Элемент, на наличие которого проверяется</param>
        /// <returns>Есть ли в массиве указанный элемент</returns>
        protected bool Array_Contains(ushort[] array, ushort value) => ArrayProxy.Array_Contains(array, value);

        /// <summary>
        /// Проверяет массив на наличие заданного элемента
        /// </summary>
        /// <param name="array">Массив</param>
        /// <param name="value">Элемент, на наличие которого проверяется</param>
        /// <returns>Есть ли в массиве указанный элемент</returns>
        protected bool Array_Contains(short[] array, short value) => ArrayProxy.Array_Contains(array, value);

        /// <summary>
        /// Проверяет массив на наличие заданного элемента
        /// </summary>
        /// <param name="array">Массив</param>
        /// <param name="value">Элемент, на наличие которого проверяется</param>
        /// <returns>Есть ли в массиве указанный элемент</returns>
        protected bool Array_Contains(byte[] array, byte value) => ArrayProxy.Array_Contains(array, value);

        /// <summary>
        /// Проверяет массив на наличие заданного элемента
        /// </summary>
        /// <param name="array">Массив</param>
        /// <param name="value">Элемент, на наличие которого проверяется</param>
        /// <returns>Есть ли в массиве указанный элемент</returns>
        protected bool Array_Contains(sbyte[] array, sbyte value) => ArrayProxy.Array_Contains(array, value);

        /// <summary>
        /// Проверяет массив на наличие заданного элемента
        /// </summary>
        /// <param name="array">Массив</param>
        /// <param name="value">Элемент, на наличие которого проверяется</param>
        /// <returns>Есть ли в массиве указанный элемент</returns>
        protected bool Array_Contains(decimal[] array, decimal value) => ArrayProxy.Array_Contains(array, value);

        /// <summary>
        /// Проверяет массив на наличие заданного элемента
        /// </summary>
        /// <param name="array">Массив</param>
        /// <param name="value">Элемент, на наличие которого проверяется</param>
        /// <returns>Есть ли в массиве указанный элемент</returns>
        protected bool Array_Contains(double[] array, double value) => ArrayProxy.Array_Contains(array, value);

        /// <summary>
        /// Проверяет массив на наличие заданного элемента
        /// </summary>
        /// <param name="array">Массив</param>
        /// <param name="value">Элемент, на наличие которого проверяется</param>
        /// <returns>Есть ли в массиве указанный элемент</returns>
        protected bool Array_Contains(float[] array, float value) => ArrayProxy.Array_Contains(array, value);

        /// <summary>
        /// Проверяет массив на наличие заданного элемента
        /// </summary>
        /// <param name="array">Массив</param>
        /// <param name="value">Элемент, на наличие которого проверяется</param>
        /// <returns>Есть ли в массиве указанный элемент</returns>
        protected bool Array_Contains(char[] array, char value) => ArrayProxy.Array_Contains(array, value);

        /// <summary>
        /// Проверяет массив на наличие заданного элемента
        /// </summary>
        /// <param name="array">Массив</param>
        /// <param name="value">Элемент, на наличие которого проверяется</param>
        /// <returns>Есть ли в массиве указанный элемент</returns>
        protected bool Array_Contains(string[] array, string value) => ArrayProxy.Array_Contains(array, value);

        /// <summary>
        /// Проверяет массив на наличие заданного элемента
        /// </summary>
        /// <param name="array">Массив</param>
        /// <param name="value">Элемент, на наличие которого проверяется</param>
        /// <returns>Есть ли в массиве указанный элемент</returns>
        protected bool Array_Contains(bool[] array, bool value) => ArrayProxy.Array_Contains(array, value);

        /// <summary>
        /// Проверяет массив на наличие заданного элемента
        /// </summary>
        /// <param name="array">Массив</param>
        /// <param name="value">Элемент, на наличие которого проверяется</param>
        /// <returns>Есть ли в массиве указанный элемент</returns>
        protected bool Array_Contains(DateTime[] array, DateTime value) => ArrayProxy.Array_Contains(array, value);

        /// <summary>
        /// Возвращает позицию первого найденного элемента в массиве, или -1 если элемент не найден
        /// </summary>
        /// <param name="array">Массив</param>
        /// <param name="value">Искомый элемент</param>
        /// <returns>Позиция указанного элемента в массиве или -1, если не найден</returns>
        protected int Array_IndexOf(ulong[] array, ulong value) => ArrayProxy.Array_IndexOf(array, value);

        /// <summary>
        /// Возвращает позицию первого найденного элемента в массиве, или -1 если элемент не найден
        /// </summary>
        /// <param name="array">Массив</param>
        /// <param name="value">Искомый элемент</param>
        /// <returns>Позиция указанного элемента в массиве или -1, если не найден</returns>
        protected int Array_IndexOf(long[] array, long value) => ArrayProxy.Array_IndexOf(array, value);

        /// <summary>
        /// Возвращает позицию первого найденного элемента в массиве, или -1 если элемент не найден
        /// </summary>
        /// <param name="array">Массив</param>
        /// <param name="value">Искомый элемент</param>
        /// <returns>Позиция указанного элемента в массиве или -1, если не найден</returns>
        protected int Array_IndexOf(uint[] array, uint value) => ArrayProxy.Array_IndexOf(array, value);

        /// <summary>
        /// Возвращает позицию первого найденного элемента в массиве, или -1 если элемент не найден
        /// </summary>
        /// <param name="array">Массив</param>
        /// <param name="value">Искомый элемент</param>
        /// <returns>Позиция указанного элемента в массиве или -1, если не найден</returns>
        protected int Array_IndexOf(int[] array, int value) => ArrayProxy.Array_IndexOf(array, value);

        /// <summary>
        /// Возвращает позицию первого найденного элемента в массиве, или -1 если элемент не найден
        /// </summary>
        /// <param name="array">Массив</param>
        /// <param name="value">Искомый элемент</param>
        /// <returns>Позиция указанного элемента в массиве или -1, если не найден</returns>
        protected int Array_IndexOf(ushort[] array, ushort value) => ArrayProxy.Array_IndexOf(array, value);

        /// <summary>
        /// Возвращает позицию первого найденного элемента в массиве, или -1 если элемент не найден
        /// </summary>
        /// <param name="array">Массив</param>
        /// <param name="value">Искомый элемент</param>
        /// <returns>Позиция указанного элемента в массиве или -1, если не найден</returns>
        protected int Array_IndexOf(short[] array, short value) => ArrayProxy.Array_IndexOf(array, value);

        /// <summary>
        /// Возвращает позицию первого найденного элемента в массиве, или -1 если элемент не найден
        /// </summary>
        /// <param name="array">Массив</param>
        /// <param name="value">Искомый элемент</param>
        /// <returns>Позиция указанного элемента в массиве или -1, если не найден</returns>
        protected int Array_IndexOf(byte[] array, byte value) => ArrayProxy.Array_IndexOf(array, value);

        /// <summary>
        /// Возвращает позицию первого найденного элемента в массиве, или -1 если элемент не найден
        /// </summary>
        /// <param name="array">Массив</param>
        /// <param name="value">Искомый элемент</param>
        /// <returns>Позиция указанного элемента в массиве или -1, если не найден</returns>
        protected int Array_IndexOf(sbyte[] array, sbyte value) => ArrayProxy.Array_IndexOf(array, value);

        /// <summary>
        /// Возвращает позицию первого найденного элемента в массиве, или -1 если элемент не найден
        /// </summary>
        /// <param name="array">Массив</param>
        /// <param name="value">Искомый элемент</param>
        /// <returns>Позиция указанного элемента в массиве или -1, если не найден</returns>
        protected int Array_IndexOf(decimal[] array, decimal value) => ArrayProxy.Array_IndexOf(array, value);

        /// <summary>
        /// Возвращает позицию первого найденного элемента в массиве, или -1 если элемент не найден
        /// </summary>
        /// <param name="array">Массив</param>
        /// <param name="value">Искомый элемент</param>
        /// <returns>Позиция указанного элемента в массиве или -1, если не найден</returns>
        protected int Array_IndexOf(double[] array, double value) => ArrayProxy.Array_IndexOf(array, value);

        /// <summary>
        /// Возвращает позицию первого найденного элемента в массиве, или -1 если элемент не найден
        /// </summary>
        /// <param name="array">Массив</param>
        /// <param name="value">Искомый элемент</param>
        /// <returns>Позиция указанного элемента в массиве или -1, если не найден</returns>
        protected int Array_IndexOf(float[] array, float value) => ArrayProxy.Array_IndexOf(array, value);

        /// <summary>
        /// Возвращает позицию первого найденного элемента в массиве, или -1 если элемент не найден
        /// </summary>
        /// <param name="array">Массив</param>
        /// <param name="value">Искомый элемент</param>
        /// <returns>Позиция указанного элемента в массиве или -1, если не найден</returns>
        protected int Array_IndexOf(char[] array, char value) => ArrayProxy.Array_IndexOf(array, value);

        /// <summary>
        /// Возвращает позицию первого найденного элемента в массиве, или -1 если элемент не найден
        /// </summary>
        /// <param name="array">Массив</param>
        /// <param name="value">Искомый элемент</param>
        /// <returns>Позиция указанного элемента в массиве или -1, если не найден</returns>
        protected int Array_IndexOf(string[] array, string value) => ArrayProxy.Array_IndexOf(array, value);

        /// <summary>
        /// Возвращает позицию первого найденного элемента в массиве, или -1 если элемент не найден
        /// </summary>
        /// <param name="array">Массив</param>
        /// <param name="value">Искомый элемент</param>
        /// <returns>Позиция указанного элемента в массиве или -1, если не найден</returns>
        protected int Array_IndexOf(bool[] array, bool value) => ArrayProxy.Array_IndexOf(array, value);

        /// <summary>
        /// Возвращает позицию первого найденного элемента в массиве, или -1 если элемент не найден
        /// </summary>
        /// <param name="array">Массив</param>
        /// <param name="value">Искомый элемент</param>
        /// <returns>Позиция указанного элемента в массиве или -1, если не найден</returns>
        protected int Array_IndexOf(DateTime[] array, DateTime value) => ArrayProxy.Array_IndexOf(array, value);

        /// <summary>
        /// Возвращает позицию последнего найденного элемента в массиве, или -1 если элемент не найден
        /// </summary>
        /// <param name="array">Массив</param>
        /// <param name="value">Искомый элемент</param>
        /// <returns>Позиция указанного элемента в массиве или -1, если не найден</returns>
        protected int Array_LastIndexOf(ulong[] array, ulong value) => ArrayProxy.Array_LastIndexOf(array, value);

        /// <summary>
        /// Возвращает позицию последнего найденного элемента в массиве, или -1 если элемент не найден
        /// </summary>
        /// <param name="array">Массив</param>
        /// <param name="value">Искомый элемент</param>
        /// <returns>Позиция указанного элемента в массиве или -1, если не найден</returns>
        protected int Array_LastIndexOf(long[] array, long value) => ArrayProxy.Array_LastIndexOf(array, value);

        /// <summary>
        /// Возвращает позицию последнего найденного элемента в массиве, или -1 если элемент не найден
        /// </summary>
        /// <param name="array">Массив</param>
        /// <param name="value">Искомый элемент</param>
        /// <returns>Позиция указанного элемента в массиве или -1, если не найден</returns>
        protected int Array_LastIndexOf(uint[] array, uint value) => ArrayProxy.Array_LastIndexOf(array, value);

        /// <summary>
        /// Возвращает позицию последнего найденного элемента в массиве, или -1 если элемент не найден
        /// </summary>
        /// <param name="array">Массив</param>
        /// <param name="value">Искомый элемент</param>
        /// <returns>Позиция указанного элемента в массиве или -1, если не найден</returns>
        protected int Array_LastIndexOf(int[] array, int value) => ArrayProxy.Array_LastIndexOf(array, value);

        /// <summary>
        /// Возвращает позицию последнего найденного элемента в массиве, или -1 если элемент не найден
        /// </summary>
        /// <param name="array">Массив</param>
        /// <param name="value">Искомый элемент</param>
        /// <returns>Позиция указанного элемента в массиве или -1, если не найден</returns>
        protected int Array_LastIndexOf(ushort[] array, ushort value) => ArrayProxy.Array_LastIndexOf(array, value);

        /// <summary>
        /// Возвращает позицию последнего найденного элемента в массиве, или -1 если элемент не найден
        /// </summary>
        /// <param name="array">Массив</param>
        /// <param name="value">Искомый элемент</param>
        /// <returns>Позиция указанного элемента в массиве или -1, если не найден</returns>
        protected int Array_LastIndexOf(short[] array, short value) => ArrayProxy.Array_LastIndexOf(array, value);

        /// <summary>
        /// Возвращает позицию последнего найденного элемента в массиве, или -1 если элемент не найден
        /// </summary>
        /// <param name="array">Массив</param>
        /// <param name="value">Искомый элемент</param>
        /// <returns>Позиция указанного элемента в массиве или -1, если не найден</returns>
        protected int Array_LastIndexOf(byte[] array, byte value) => ArrayProxy.Array_LastIndexOf(array, value);

        /// <summary>
        /// Возвращает позицию последнего найденного элемента в массиве, или -1 если элемент не найден
        /// </summary>
        /// <param name="array">Массив</param>
        /// <param name="value">Искомый элемент</param>
        /// <returns>Позиция указанного элемента в массиве или -1, если не найден</returns>
        protected int Array_LastIndexOf(sbyte[] array, sbyte value) => ArrayProxy.Array_LastIndexOf(array, value);

        /// <summary>
        /// Возвращает позицию последнего найденного элемента в массиве, или -1 если элемент не найден
        /// </summary>
        /// <param name="array">Массив</param>
        /// <param name="value">Искомый элемент</param>
        /// <returns>Позиция указанного элемента в массиве или -1, если не найден</returns>
        protected int Array_LastIndexOf(decimal[] array, decimal value) => ArrayProxy.Array_LastIndexOf(array, value);

        /// <summary>
        /// Возвращает позицию последнего найденного элемента в массиве, или -1 если элемент не найден
        /// </summary>
        /// <param name="array">Массив</param>
        /// <param name="value">Искомый элемент</param>
        /// <returns>Позиция указанного элемента в массиве или -1, если не найден</returns>
        protected int Array_LastIndexOf(double[] array, double value) => ArrayProxy.Array_LastIndexOf(array, value);

        /// <summary>
        /// Возвращает позицию последнего найденного элемента в массиве, или -1 если элемент не найден
        /// </summary>
        /// <param name="array">Массив</param>
        /// <param name="value">Искомый элемент</param>
        /// <returns>Позиция указанного элемента в массиве или -1, если не найден</returns>
        protected int Array_LastIndexOf(float[] array, float value) => ArrayProxy.Array_LastIndexOf(array, value);

        /// <summary>
        /// Возвращает позицию последнего найденного элемента в массиве, или -1 если элемент не найден
        /// </summary>
        /// <param name="array">Массив</param>
        /// <param name="value">Искомый элемент</param>
        /// <returns>Позиция указанного элемента в массиве или -1, если не найден</returns>
        protected int Array_LastIndexOf(char[] array, char value) => ArrayProxy.Array_LastIndexOf(array, value);

        /// <summary>
        /// Возвращает позицию последнего найденного элемента в массиве, или -1 если элемент не найден
        /// </summary>
        /// <param name="array">Массив</param>
        /// <param name="value">Искомый элемент</param>
        /// <returns>Позиция указанного элемента в массиве или -1, если не найден</returns>
        protected int Array_LastIndexOf(string[] array, string value) => ArrayProxy.Array_LastIndexOf(array, value);

        /// <summary>
        /// Возвращает позицию последнего найденного элемента в массиве, или -1 если элемент не найден
        /// </summary>
        /// <param name="array">Массив</param>
        /// <param name="value">Искомый элемент</param>
        /// <returns>Позиция указанного элемента в массиве или -1, если не найден</returns>
        protected int Array_LastIndexOf(bool[] array, bool value) => ArrayProxy.Array_LastIndexOf(array, value);

        /// <summary>
        /// Возвращает позицию последнего найденного элемента в массиве, или -1 если элемент не найден
        /// </summary>
        /// <param name="array">Массив</param>
        /// <param name="value">Искомый элемент</param>
        /// <returns>Позиция указанного элемента в массиве или -1, если не найден</returns>
        protected int Array_LastIndexOf(DateTime[] array, DateTime value) => ArrayProxy.Array_LastIndexOf(array, value);

        /// <summary>
        /// Создает копию массива
        /// </summary>
        /// <param name="array">Исходный массив</param>
        /// <returns>Копия массива</returns>
        protected ulong[] Array_Copy(ulong[] array) => ArrayProxy.Array_Copy(array);

        /// <summary>
        /// Создает копию массива
        /// </summary>
        /// <param name="array">Исходный массив</param>
        /// <returns>Копия массива</returns>
        protected long[] Array_Copy(long[] array) => ArrayProxy.Array_Copy(array);

        /// <summary>
        /// Создает копию массива
        /// </summary>
        /// <param name="array">Исходный массив</param>
        /// <returns>Копия массива</returns>
        protected uint[] Array_Copy(uint[] array) => ArrayProxy.Array_Copy(array);

        /// <summary>
        /// Создает копию массива
        /// </summary>
        /// <param name="array">Исходный массив</param>
        /// <returns>Копия массива</returns>
        protected int[] Array_Copy(int[] array) => ArrayProxy.Array_Copy(array);

        /// <summary>
        /// Создает копию массива
        /// </summary>
        /// <param name="array">Исходный массив</param>
        /// <returns>Копия массива</returns>
        protected ushort[] Array_Copy(ushort[] array) => ArrayProxy.Array_Copy(array);

        /// <summary>
        /// Создает копию массива
        /// </summary>
        /// <param name="array">Исходный массив</param>
        /// <returns>Копия массива</returns>
        protected short[] Array_Copy(short[] array) => ArrayProxy.Array_Copy(array);

        /// <summary>
        /// Создает копию массива
        /// </summary>
        /// <param name="array">Исходный массив</param>
        /// <returns>Копия массива</returns>
        protected byte[] Array_Copy(byte[] array) => ArrayProxy.Array_Copy(array);

        /// <summary>
        /// Создает копию массива
        /// </summary>
        /// <param name="array">Исходный массив</param>
        /// <returns>Копия массива</returns>
        protected sbyte[] Array_Copy(sbyte[] array) => ArrayProxy.Array_Copy(array);

        /// <summary>
        /// Создает копию массива
        /// </summary>
        /// <param name="array">Исходный массив</param>
        /// <returns>Копия массива</returns>
        protected decimal[] Array_Copy(decimal[] array) => ArrayProxy.Array_Copy(array);

        /// <summary>
        /// Создает копию массива
        /// </summary>
        /// <param name="array">Исходный массив</param>
        /// <returns>Копия массива</returns>
        protected double[] Array_Copy(double[] array) => ArrayProxy.Array_Copy(array);

        /// <summary>
        /// Создает копию массива
        /// </summary>
        /// <param name="array">Исходный массив</param>
        /// <returns>Копия массива</returns>
        protected float[] Array_Copy(float[] array) => ArrayProxy.Array_Copy(array);

        /// <summary>
        /// Создает копию массива
        /// </summary>
        /// <param name="array">Исходный массив</param>
        /// <returns>Копия массива</returns>
        protected char[] Array_Copy(char[] array) => ArrayProxy.Array_Copy(array);

        /// <summary>
        /// Создает копию массива
        /// </summary>
        /// <param name="array">Исходный массив</param>
        /// <returns>Копия массива</returns>
        protected string[] Array_Copy(string[] array) => ArrayProxy.Array_Copy(array);

        /// <summary>
        /// Создает копию массива
        /// </summary>
        /// <param name="array">Исходный массив</param>
        /// <returns>Копия массива</returns>
        protected bool[] Array_Copy(bool[] array) => ArrayProxy.Array_Copy(array);

        /// <summary>
        /// Создает копию массива
        /// </summary>
        /// <param name="array">Исходный массив</param>
        /// <returns>Копия массива</returns>
        protected DateTime[] Array_Copy(DateTime[] array) => ArrayProxy.Array_Copy(array);

        /// <summary>
        /// Сцепляет два массива
        /// </summary>
        /// <param name="arrayA">Первый массив</param>
        /// <param name="arrayB">Второй массив</param>
        /// <returns>Массив, состоящий из элементов массивов, указанных в параметрах</returns>
        protected ulong[] Array_Concat(ulong[] arrayA, ulong[] arrayB) => ArrayProxy.Array_Concat(arrayA, arrayB);

        /// <summary>
        /// Сцепляет два массива
        /// </summary>
        /// <param name="arrayA">Первый массив</param>
        /// <param name="arrayB">Второй массив</param>
        /// <returns>Массив, состоящий из элементов массивов, указанных в параметрах</returns>
        protected long[] Array_Concat(long[] arrayA, long[] arrayB) => ArrayProxy.Array_Concat(arrayA, arrayB);

        /// <summary>
        /// Сцепляет два массива
        /// </summary>
        /// <param name="arrayA">Первый массив</param>
        /// <param name="arrayB">Второй массив</param>
        /// <returns>Массив, состоящий из элементов массивов, указанных в параметрах</returns>
        protected uint[] Array_Concat(uint[] arrayA, uint[] arrayB) => ArrayProxy.Array_Concat(arrayA, arrayB);

        /// <summary>
        /// Сцепляет два массива
        /// </summary>
        /// <param name="arrayA">Первый массив</param>
        /// <param name="arrayB">Второй массив</param>
        /// <returns>Массив, состоящий из элементов массивов, указанных в параметрах</returns>
        protected int[] Array_Concat(int[] arrayA, int[] arrayB) => ArrayProxy.Array_Concat(arrayA, arrayB);

        /// <summary>
        /// Сцепляет два массива
        /// </summary>
        /// <param name="arrayA">Первый массив</param>
        /// <param name="arrayB">Второй массив</param>
        /// <returns>Массив, состоящий из элементов массивов, указанных в параметрах</returns>
        protected ushort[] Array_Concat(ushort[] arrayA, ushort[] arrayB) => ArrayProxy.Array_Concat(arrayA, arrayB);

        /// <summary>
        /// Сцепляет два массива
        /// </summary>
        /// <param name="arrayA">Первый массив</param>
        /// <param name="arrayB">Второй массив</param>
        /// <returns>Массив, состоящий из элементов массивов, указанных в параметрах</returns>
        protected short[] Array_Concat(short[] arrayA, short[] arrayB) => ArrayProxy.Array_Concat(arrayA, arrayB);

        /// <summary>
        /// Сцепляет два массива
        /// </summary>
        /// <param name="arrayA">Первый массив</param>
        /// <param name="arrayB">Второй массив</param>
        /// <returns>Массив, состоящий из элементов массивов, указанных в параметрах</returns>
        protected byte[] Array_Concat(byte[] arrayA, byte[] arrayB) => ArrayProxy.Array_Concat(arrayA, arrayB);

        /// <summary>
        /// Сцепляет два массива
        /// </summary>
        /// <param name="arrayA">Первый массив</param>
        /// <param name="arrayB">Второй массив</param>
        /// <returns>Массив, состоящий из элементов массивов, указанных в параметрах</returns>
        protected sbyte[] Array_Concat(sbyte[] arrayA, sbyte[] arrayB) => ArrayProxy.Array_Concat(arrayA, arrayB);

        /// <summary>
        /// Сцепляет два массива
        /// </summary>
        /// <param name="arrayA">Первый массив</param>
        /// <param name="arrayB">Второй массив</param>
        /// <returns>Массив, состоящий из элементов массивов, указанных в параметрах</returns>
        protected decimal[] Array_Concat(decimal[] arrayA, decimal[] arrayB) => ArrayProxy.Array_Concat(arrayA, arrayB);

        /// <summary>
        /// Сцепляет два массива
        /// </summary>
        /// <param name="arrayA">Первый массив</param>
        /// <param name="arrayB">Второй массив</param>
        /// <returns>Массив, состоящий из элементов массивов, указанных в параметрах</returns>
        protected double[] Array_Concat(double[] arrayA, double[] arrayB) => ArrayProxy.Array_Concat(arrayA, arrayB);

        /// <summary>
        /// Сцепляет два массива
        /// </summary>
        /// <param name="arrayA">Первый массив</param>
        /// <param name="arrayB">Второй массив</param>
        /// <returns>Массив, состоящий из элементов массивов, указанных в параметрах</returns>
        protected float[] Array_Concat(float[] arrayA, float[] arrayB) => ArrayProxy.Array_Concat(arrayA, arrayB);

        /// <summary>
        /// Сцепляет два массива
        /// </summary>
        /// <param name="arrayA">Первый массив</param>
        /// <param name="arrayB">Второй массив</param>
        /// <returns>Массив, состоящий из элементов массивов, указанных в параметрах</returns>
        protected char[] Array_Concat(char[] arrayA, char[] arrayB) => ArrayProxy.Array_Concat(arrayA, arrayB);

        /// <summary>
        /// Сцепляет два массива
        /// </summary>
        /// <param name="arrayA">Первый массив</param>
        /// <param name="arrayB">Второй массив</param>
        /// <returns>Массив, состоящий из элементов массивов, указанных в параметрах</returns>
        protected string[] Array_Concat(string[] arrayA, string[] arrayB) => ArrayProxy.Array_Concat(arrayA, arrayB);

        /// <summary>
        /// Сцепляет два массива
        /// </summary>
        /// <param name="arrayA">Первый массив</param>
        /// <param name="arrayB">Второй массив</param>
        /// <returns>Массив, состоящий из элементов массивов, указанных в параметрах</returns>
        protected bool[] Array_Concat(bool[] arrayA, bool[] arrayB) => ArrayProxy.Array_Concat(arrayA, arrayB);

        /// <summary>
        /// Сцепляет два массива
        /// </summary>
        /// <param name="arrayA">Первый массив</param>
        /// <param name="arrayB">Второй массив</param>
        /// <returns>Массив, состоящий из элементов массивов, указанных в параметрах</returns>
        protected DateTime[] Array_Concat(DateTime[] arrayA, DateTime[] arrayB) => ArrayProxy.Array_Concat(arrayA, arrayB);
    }
}

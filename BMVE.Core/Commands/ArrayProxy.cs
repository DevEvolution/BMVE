using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMVE.Core.Commands
{
    internal static class ArrayProxy
    {
        internal static int[] Array_OfInt(int size)
        {
            ValidateArraySize(size);
            return new int[size];
        }
        internal static int[,] Array_OfInt(int sizeA, int sizeB)
        {
            ValidateArraySize(sizeA);
            ValidateArraySize(sizeB);
            return new int[sizeA, sizeB];
        }
        internal static int[,,] Array_OfInt(int sizeA, int sizeB, int sizeC)
        {
            ValidateArraySize(sizeA);
            ValidateArraySize(sizeB);
            ValidateArraySize(sizeC);
            return new int[sizeA, sizeB, sizeC];
        }
        internal static double[] Array_OfDouble(int size)
        {
            ValidateArraySize(size);
            return new double[size];
        }
        internal static double[,] Array_OfDouble(int sizeA, int sizeB)
        {
            ValidateArraySize(sizeA);
            ValidateArraySize(sizeB);
            return new double[sizeA, sizeB];
        }
        internal static double[,,] Array_OfDouble(int sizeA, int sizeB, int sizeC)
        {
            ValidateArraySize(sizeA);
            ValidateArraySize(sizeB);
            ValidateArraySize(sizeC);
            return new double[sizeA, sizeB, sizeC];
        }
        internal static string[] Array_OfString(int size)
        {
            ValidateArraySize(size);
            var array = new string[size];
            for (int i = 0; i < size; i++)
            {
                array[i] = String.Empty;
            }
            return array;
        }
        internal static string[,] Array_OfString(int sizeA, int sizeB)
        {
            ValidateArraySize(sizeA);
            ValidateArraySize(sizeB);
            var array = new string[sizeA, sizeB];
            for (int i = 0; i < sizeA; i++)
            {
                for (int j = 0; j < sizeB; j++)
                {
                    array[i, j] = String.Empty;
                }
            }
            return array;
        }
        internal static string[,,] Array_OfString(int sizeA, int sizeB, int sizeC)
        {
            ValidateArraySize(sizeA);
            ValidateArraySize(sizeB);
            ValidateArraySize(sizeC);
            var array = new string[sizeA, sizeB, sizeC];
            for (int i = 0; i < sizeA; i++)
            {
                for (int j = 0; j < sizeB; j++)
                {
                    for (int k = 0; k < sizeC; k++)
                    {
                        array[i, j, k] = String.Empty;
                    }
                }
            }
            return array;
        }
        internal static bool[] Array_OfBool(int size)
        {
            ValidateArraySize(size);
            return new bool[size];
        }
        internal static bool[,] Array_OfBool(int sizeA, int sizeB)
        {
            ValidateArraySize(sizeA);
            ValidateArraySize(sizeB);
            return new bool[sizeA, sizeB];
        }
        internal static bool[,,] Array_OfBool(int sizeA, int sizeB, int sizeC)
        {
            ValidateArraySize(sizeA);
            ValidateArraySize(sizeB);
            ValidateArraySize(sizeC);
            return new bool[sizeA, sizeB, sizeC];
        }
        internal static int[] Array_Add(int[] array, int value)
        {
            var list = array.ToList();
            list.Add(value);
            return list.ToArray();
        }
        internal static double[] Array_Add(double[] array, double value)
        {
            var list = array.ToList();
            list.Add(value);
            return list.ToArray();
        }
        internal static string[] Array_Add(string[] array, string value)
        {
            var list = array.ToList();
            list.Add(value);
            return list.ToArray();
        }
        internal static bool[] Array_Add(bool[] array, bool value)
        {
            var list = array.ToList();
            list.Add(value);
            return list.ToArray();
        }
        internal static int[] Array_Insert(int[] array, int index, int value)
        {
            ValidateArrayIndex(array, index);
            var list = array.ToList();
            list.Insert(index, value);
            return list.ToArray();
        }
        internal static double[] Array_Insert(double[] array, int index, double value)
        {
            ValidateArrayIndex(array, index);
            var list = array.ToList();
            list.Insert(index, value);
            return list.ToArray();
        }
        internal static string[] Array_Insert(string[] array, int index, string value)
        {
            ValidateArrayIndex(array, index);
            var list = array.ToList();
            list.Insert(index, value);
            return list.ToArray();
        }
        internal static bool[] Array_Insert(bool[] array, int index, bool value)
        {
            ValidateArrayIndex(array, index);
            var list = array.ToList();
            list.Insert(index, value);
            return list.ToArray();
        }
        internal static int[] Array_Remove(int[] array, int index)
        {
            ValidateArrayIndex(array, index);
            var list = array.ToList();
            list.RemoveAt(index);
            return list.ToArray();
        }
        internal static double[] Array_Remove(double[] array, int index)
        {
            ValidateArrayIndex(array, index);
            var list = array.ToList();
            list.RemoveAt(index);
            return list.ToArray();
        }
        internal static string[] Array_Remove(string[] array, int index)
        {
            ValidateArrayIndex(array, index);
            var list = array.ToList();
            list.RemoveAt(index);
            return list.ToArray();
        }
        internal static bool[] Array_Remove(bool[] array, int index)
        {
            ValidateArrayIndex(array, index);
            var list = array.ToList();
            list.RemoveAt(index);
            return list.ToArray();
        }
        internal static int Array_Length(int[] array) => array.Length;
        internal static int Array_Length(int[,] array, int dimension) => array.GetLength(dimension);
        internal static int Array_Length(int[,,] array, int dimension) => array.GetLength(dimension);
        internal static int Array_Length(double[] array) => array.Length;
        internal static int Array_Length(double[,] array, int dimension) => array.GetLength(dimension);
        internal static int Array_Length(double[,,] array, int dimension) => array.GetLength(dimension);
        internal static int Array_Length(string[] array) => array.Length;
        internal static int Array_Length(string[,] array, int dimension) => array.GetLength(dimension);
        internal static int Array_Length(string[,,] array, int dimension) => array.GetLength(dimension);
        internal static int Array_Length(bool[] array) => array.Length;
        internal static int Array_Length(bool[,] array, int dimension) => array.GetLength(dimension);
        internal static int Array_Length(bool[,,] array, int dimension) => array.GetLength(dimension);
        internal static bool Array_Contains(int[] array, int value) => array.Contains(value);
        internal static bool Array_Contains(double[] array, double value) => array.Contains(value);
        internal static bool Array_Contains(string[] array, string value) => array.Contains(value);
        internal static bool Array_Contains(bool[] array, bool value) => array.Contains(value);
        internal static int Array_IndexOf(int[] array, int value) => array.ToList().IndexOf(value);
        internal static int Array_IndexOf(double[] array, double value) => array.ToList().IndexOf(value);
        internal static int Array_IndexOf(string[] array, string value) => array.ToList().IndexOf(value);
        internal static int Array_IndexOf(bool[] array, bool value) => array.ToList().IndexOf(value);
        internal static int Array_LastIndexOf(int[] array, int value) => array.ToList().LastIndexOf(value);
        internal static int Array_LastIndexOf(double[] array, double value) => array.ToList().LastIndexOf(value);
        internal static int Array_LastIndexOf(string[] array, string value) => array.ToList().LastIndexOf(value);
        internal static int Array_LastIndexOf(bool[] array, bool value) => array.ToList().LastIndexOf(value);
        internal static int[] Array_Copy(int[] array)
        {
            int[] copy = new int[array.Length];
            array.CopyTo(copy, 0);
            return copy;
        }
        internal static double[] Array_Copy(double[] array)
        {
            double[] copy = new double[array.Length];
            array.CopyTo(copy, 0);
            return copy;
        }
        internal static string[] Array_Copy(string[] array)
        {
            string[] copy = new string[array.Length];
            array.CopyTo(copy, 0);
            return copy;
        }
        internal static bool[] Array_Copy(bool[] array)
        {
            bool[] copy = new bool[array.Length];
            array.CopyTo(copy, 0);
            return copy;
        }
        internal static int[] Array_Concat(int[] arrayA, int[] arrayB) => arrayA.Concat(arrayB).ToArray();
        internal static double[] Array_Concat(double[] arrayA, double[] arrayB) => arrayA.Concat(arrayB).ToArray();
        internal static string[] Array_Concat(string[] arrayA, string[] arrayB) => arrayA.Concat(arrayB).ToArray();
        internal static bool[] Array_Concat(bool[] arrayA, bool[] arrayB) => arrayA.Concat(arrayB).ToArray();


        private static void ValidateArraySize(int size)
        {
            if (size <= 0)
            {
                throw new Exception("Массив не может быть нулевого отрицательного размера");
            }
        }

        private static void ValidateArrayIndex(Array array, int index)
        {
            if (index < 0 || index >= array.Length)
            {
                throw new Exception("Индекс не входит в границы массива");
            }
        }
    }
}

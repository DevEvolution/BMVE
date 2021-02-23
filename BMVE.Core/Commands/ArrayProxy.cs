using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMVE.Core.Commands
{
    internal static class ArrayProxy
    {
        internal static T[] Array_Create<T>(int size)
        {
            ValidateArraySize(size);
            return Array.CreateInstance(typeof(T), size) as T[];
        }
        
        internal static T[,] Array_Create2<T>(int sizeA, int sizeB)
        {
            ValidateArraySize(sizeA);
            ValidateArraySize(sizeB);
            return Array.CreateInstance(typeof(T), sizeA, sizeB) as T[,];
        }
        
        internal static T[,,] Array_Create3<T>(int sizeA, int sizeB, int sizeC)
        {
            ValidateArraySize(sizeA);
            ValidateArraySize(sizeB);
            ValidateArraySize(sizeC);
            return Array.CreateInstance(typeof(T), sizeA, sizeB, sizeC) as T[,,];
        }

        internal static T[] Array_Add<T>(T[] array, T value)
        {
            int newLength = array.Length + 1;
            T[] newArray = new T[newLength];
            Array.Copy(array, newArray, array.Length);
            newArray[newLength - 1] = value;
            return newArray;
        }

        internal static T[] Array_Insert<T>(T[] array, int index, T value)
        {
            ValidateArrayIndex(array, index);
            var list = array.ToList();
            list.Insert(index, value);
            return list.ToArray();
        }

        internal static T[] Array_Remove<T>(T[] array, int index)
        {
            ValidateArrayIndex(array, index);
            var list = array.ToList();
            list.RemoveAt(index);
            return list.ToArray();
        }
        internal static int Array_Length<T>(T[] array) => array.Length;
        internal static int Array_Length<T>(T[,] array, int dimension) => array.GetLength(dimension);
        internal static int Array_Length<T>(T[,,] array, int dimension) => array.GetLength(dimension);

        internal static bool Array_Contains<T>(T[] array, T value) => array.Contains(value);

        internal static int Array_IndexOf<T>(T[] array, T value) => array.ToList().IndexOf(value);

        internal static int Array_LastIndexOf<T>(T[] array, T value) => array.ToList().LastIndexOf(value);

        internal static T[] Array_Copy<T>(T[] array)
        {
            T[] copy = new T[array.Length];
            array.CopyTo(copy, 0);
            return copy;
        }

        internal static T[] Array_Concat<T>(T[] arrayA, T[] arrayB) => arrayA.Concat(arrayB).ToArray();
        
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

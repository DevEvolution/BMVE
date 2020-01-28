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
        /// Создает новый массив целых чисел указанного размера
        /// </summary>
        /// <param name="size">Размер массива</param>
        /// <returns>Новый массив</returns>
        protected int[] Array_OfInt(int size) => ArrayProxy.Array_OfInt(size);

        /// <summary>
        /// Создает новый двухмерный массив целых чисел указанного размера
        /// </summary>
        /// <param name="sizeA">Первая размерность массива</param>
        /// <param name="sizeB">Вторая размерность массива</param>
        /// <returns>Новый массив</returns>
        protected int[,] Array_OfInt(int sizeA, int sizeB) => ArrayProxy.Array_OfInt(sizeA, sizeB);

        /// <summary>
        /// Создает новый трехмерный массив целых чисел указанного размера
        /// </summary>
        /// <param name="sizeA">Первая размерность массива</param>
        /// <param name="sizeB">Вторая размерность массива</param>
        /// <param name="sizeC">Третья размерность массива</param>
        /// <returns>Новый массив</returns>
        protected int[,,] Array_OfInt(int sizeA, int sizeB, int sizeC) => ArrayProxy.Array_OfInt(sizeA, sizeB, sizeC);

        /// <summary>
        /// Создает новый массив дробных чисел указанного размера
        /// </summary>
        /// <param name="size">Размер массива</param>
        /// <returns>Новый массив</returns>
        protected double[] Array_OfDouble(int size) => ArrayProxy.Array_OfDouble(size);

        /// <summary>
        /// Создает новый двухмерный массив дробных чисел указанного размера
        /// </summary>
        /// <param name="sizeA">Первая размерность массива</param>
        /// <param name="sizeB">Вторая размерность массива</param>
        /// <returns>Новый массив</returns>
        protected double[,] Array_OfDouble(int sizeA, int sizeB) => ArrayProxy.Array_OfDouble(sizeA, sizeB);

        /// <summary>
        /// Создает новый трехмерный массив дробных чисел указанного размера
        /// </summary>
        /// <param name="sizeA">Первая размерность массива</param>
        /// <param name="sizeB">Вторая размерность массива</param>
        /// <param name="sizeC">Третья размерность массива</param>
        /// <returns>Новый массив</returns>
        protected double[,,] Array_OfDouble(int sizeA, int sizeB, int sizeC) => ArrayProxy.Array_OfDouble(sizeA, sizeB, sizeC);

        /// <summary>
        /// Создает новый массив строк указанного размера
        /// </summary>
        /// <param name="size">Размер массива</param>
        /// <returns>Новый массив</returns>
        protected string[] Array_OfString(int size) => ArrayProxy.Array_OfString(size);

        /// <summary>
        /// Создает новый двухмерный массив строк указанного размера
        /// </summary>
        /// <param name="sizeA">Первая размерность массива</param>
        /// <param name="sizeB">Вторая размерность массива</param>
        /// <returns>Новый массив</returns>
        protected string[,] Array_OfString(int sizeA, int sizeB) => ArrayProxy.Array_OfString(sizeA, sizeB);

        /// <summary>
        /// Создает новый трехмерный массив строк указанного размера
        /// </summary>
        /// <param name="sizeA">Первая размерность массива</param>
        /// <param name="sizeB">Вторая размерность массива</param>
        /// <param name="sizeC">Третья размерность массива</param>
        /// <returns>Новый массив</returns>
        protected string[,,] Array_OfString(int sizeA, int sizeB, int sizeC) => ArrayProxy.Array_OfString(sizeA, sizeB, sizeC);

        /// <summary>
        /// Создает новый массив логических значений указанного размера
        /// </summary>
        /// <param name="size">Размер массива</param>
        /// <returns>Новый массив</returns>
        protected bool[] Array_OfBool(int size) => ArrayProxy.Array_OfBool(size);

        /// <summary>
        /// Создает новый двухмерный массив логических значений указанного размера
        /// </summary>
        /// <param name="sizeA">Первая размерность массива</param>
        /// <param name="sizeB">Вторая размерность массива</param>
        /// <returns>Новый массив</returns>
        protected bool[,] Array_OfBool(int sizeA, int sizeB) => ArrayProxy.Array_OfBool(sizeA, sizeB);

        /// <summary>
        /// Создает новый трехмерный массив логических значений указанного размера
        /// </summary>
        /// <param name="sizeA">Первая размерность массива</param>
        /// <param name="sizeB">Вторая размерность массива</param>
        /// <param name="sizeC">Третья размерность массива</param>
        /// <returns>Новый массив</returns>
        protected bool[,,] Array_OfBool(int sizeA, int sizeB, int sizeC) => ArrayProxy.Array_OfBool(sizeA, sizeB, sizeC);

        /// <summary>
        /// Добавляет новый целочисленный элемент в конец массива
        /// </summary>
        /// <param name="array">Массив для добавления</param>
        /// <param name="value">Новый элемент</param>
        /// <returns>Массив с добавленным новым значением</returns>
        protected int[] Array_Add(int[] array, int value) => ArrayProxy.Array_Add(array, value);

        /// <summary>
        /// Добавляет новый дробный элемент в конец массива
        /// </summary>
        /// <param name="array">Массив для добавления</param>
        /// <param name="value">Новый элемент</param>
        /// <returns>Массив с добавленным новым значением</returns>
        protected double[] Array_Add(double[] array, double value) => ArrayProxy.Array_Add(array, value);

        /// <summary>
        /// Добавляет новый элемент-строку в конец массива
        /// </summary>
        /// <param name="array">Массив для добавления</param>
        /// <param name="value">Новый элемент</param>
        /// <returns>Массив с добавленным новым значением</returns>
        protected string[] Array_Add(string[] array, string value) => ArrayProxy.Array_Add(array, value);

        /// <summary>
        /// Добавляет новый элемент-логическое значение в конец массива
        /// </summary>
        /// <param name="array">Массив для добавления</param>
        /// <param name="value">Новый элемент</param>
        /// <returns>Массив с добавленным новым значением</returns>
        protected bool[] Array_Add(bool[] array, bool value) => ArrayProxy.Array_Add(array, value);

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
        protected double[] Array_Insert(double[] array, int index, double value) => ArrayProxy.Array_Insert(array, index, value);

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
        protected bool[] Array_Insert(bool[] array, int index, bool value) => ArrayProxy.Array_Insert(array, index, value);

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
        protected double[] Array_Remove(double[] array, int index) => ArrayProxy.Array_Remove(array, index);

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
        protected bool Array_Contains(double[] array, double value) => ArrayProxy.Array_Contains(array, value);

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
        protected int Array_IndexOf(double[] array, double value) => ArrayProxy.Array_IndexOf(array, value);

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
        protected int Array_LastIndexOf(double[] array, double value) => ArrayProxy.Array_LastIndexOf(array, value);

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
        protected double[] Array_Copy(double[] array) => ArrayProxy.Array_Copy(array);

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
        protected double[] Array_Concat(double[] arrayA, double[] arrayB) => ArrayProxy.Array_Concat(arrayA, arrayB);

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
    }
}

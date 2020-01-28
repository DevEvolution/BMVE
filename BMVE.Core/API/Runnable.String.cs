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
        /// Получить код первого символа в строке
        /// </summary>
        /// <param name="str">Строка, содержащая как минимум один символ</param>
        /// <returns>Код символа</returns>
        protected int String_GetCharCode(string str) => StringProxy.String_GetCharCode(str);

        /// <summary>
        /// Возвращает длину указанной строки
        /// </summary>
        /// <param name="str">Строка</param>
        /// <returns>Длина строки</returns>
        protected int String_Length(string str) => StringProxy.String_Length(str);

        /// <summary>
        /// Получает символ, находящийся по указанному индексу в указанной строке
        /// </summary>
        /// <param name="str">Строка</param>
        /// <param name="index">Индекс символа</param>
        /// <returns>Строка, содержащая символ</returns>
        protected string String_CharAt(string str, int index) => StringProxy.String_CharAt(str, index);

        /// <summary>
        /// Возвращает индекс первой найденной указанной строки в другой строке
        /// </summary>
        /// <param name="fullString">Строка, в которой будет осуществляться поиск</param>
        /// <param name="findString">Строка, вхождение которой будет искаться</param>
        /// <returns>Индекс первой найденной указанной строки в другой строке или -1, если не найдена</returns>
        protected int String_IndexOf(string fullString, string findString) => StringProxy.String_IndexOf(fullString, findString);

        /// <summary>
        /// Возвращает индекс последней найденной указанной строки в другой строке
        /// </summary>
        /// <param name="fullString">Строка, в которой будет осуществляться поиск</param>
        /// <param name="findString">Строка, вхождение которой будет искаться</param>
        /// <returns>Индекс последней найденной указанной строки в другой строке или -1, если не найдена</returns>
        protected int String_LastIndexOf(string fullString, string findString) => StringProxy.String_LastIndexOf(fullString, findString);

        /// <summary>
        /// Возвращает строку, содержающую указанное количество символов слева из другой строки
        /// </summary>
        /// <param name="str">Строка, из которой будет взята подстрока</param>
        /// <param name="length">Количество символов слева, которое должно быть взято</param>
        /// <returns>Строка, содержающая указанное количество символов слева из другой строки</returns>
        protected string String_LeftSubstring(string str, int length) => StringProxy.String_LeftSubstring(str, length);

        /// <summary>
        /// Возвращает строку, содержающую указанное количество символов справа из другой строки
        /// </summary>
        /// <param name="str">Строка, из которой будет взята подстрока</param>
        /// <param name="length">Количество символов справа, которое должно быть взято</param>
        /// <returns>Строка, содержающая указанное количество символов справа из другой строки</returns>
        protected string String_RightSubstring(string str, int length) => StringProxy.String_RightSubstring(str, length);

        /// <summary>
        /// Возвращает строку, содержащую указанное количество символов, скопированное из другой строки, начиная с указанного индекса
        /// </summary>
        /// <param name="str">Строка, из которой будет взята подстрока</param>
        /// <param name="start">Индекс, начиная с которого символы должны быть скопированы</param>
        /// <param name="length">Количество символов, которое должно быть скопировано</param>
        /// <returns>Строка, содержающая указанное количество символов из другой строки</returns>
        protected string String_Substring(string str, int start, int length) => StringProxy.String_Substring(str, start, length);

        /// <summary>
        /// Преобразовывает строку к нижнему регистру
        /// </summary>
        /// <param name="str">Строка</param>
        /// <returns>Строка в нижнем регистре</returns>
        protected string String_ToLower(string str) => StringProxy.String_ToLower(str);

        /// <summary>
        /// Преобразовывает строку к ВЕРХНЕМУ регистру
        /// </summary>
        /// <param name="str">Строка</param>
        /// <returns>Строка в ВЕРХНЕМ регистре</returns>
        protected string String_ToUpper(string str) => StringProxy.String_ToUpper(str);

        /// <summary>
        /// Убирает все отступы и пробелы слева в строке
        /// </summary>
        /// <param name="str">Строка</param>
        /// <returns>Строка без отступов слева</returns>
        protected string String_TrimLeft(string str) => StringProxy.String_TrimLeft(str);

        /// <summary>
        /// Убирает все отступы и пробелы справа в строке
        /// </summary>
        /// <param name="str">Строка</param>
        /// <returns>Строка без отступов справа</returns>
        protected string String_TrimRight(string str) => StringProxy.String_TrimRight(str);

        /// <summary>
        /// Убирает все отступы и пробелы в начале и конце строки
        /// </summary>
        /// <param name="str">Строка</param>
        /// <returns>Строка без отступов в начале и в конце</returns>
        protected string String_Trim(string str) => StringProxy.String_Trim(str);

        /// <summary>
        /// Заменяет все вхождения указанной подстроки на другую подстроку в указанной строке
        /// </summary>
        /// <param name="fullString">Строка</param>
        /// <param name="oldValue">Подстрока для замены</param>
        /// <param name="newValue">Подстрока, на которую будет заменено старое значение</param>
        /// <returns>Строка с замененными последовательностями</returns>
        protected string String_Replace(string fullString, string oldValue, string newValue) => StringProxy.String_Replace(fullString, oldValue, newValue);

        /// <summary>
        /// Переворачивает строку задом наперед
        /// </summary>
        /// <param name="str">Строка</param>
        /// <returns>Перевернутая строка</returns>
        protected string String_Reverse(string str) => StringProxy.String_Reverse(str);

        /// <summary>
        /// Создает пустую строку
        /// </summary>
        /// <returns>Пустая строка</returns>
        protected string String_CreateEmpty() => StringProxy.String_CreateEmpty();

        /// <summary>
        /// Создает строку, состоящую из указанного количества пробелов
        /// </summary>
        /// <param name="length">Количество пробелов</param>
        /// <returns>Строка из пробелов</returns>
        protected string String_CreateSpaces(int length) => StringProxy.String_CreateSpaces(length);

        /// <summary>
        /// Проверяет, находятся ли в строке только цифры
        /// </summary>
        /// <param name="str">Строка</param>
        /// <returns>В строке только/не только цифры</returns>
        protected bool String_IsOnlyDigits(string str) => StringProxy.String_IsOnlyDigits(str);

        /// <summary>
        /// Проверяет, находятся ли в строке только буквы
        /// </summary>
        /// <param name="str">Строка</param>
        /// <returns>В строке только/не только буквы</returns>
        protected bool String_IsOnlyLetters(string str) => StringProxy.String_IsOnlyLetters(str);

        /// <summary>
        /// Является ли строка числом
        /// </summary>
        /// <param name="str">Строка</param>
        /// <returns>Является ли строка числом</returns>
        protected bool String_IsNumber(string str) => StringProxy.String_IsNumber(str);

        /// <summary>
        /// Находится ли вся строка в нижнем регистре
        /// </summary>
        /// <param name="str">Строка</param>
        /// <returns>Находится ли вся строка в нижнем регистре</returns>
        protected bool String_IsLowerCase(string str) => StringProxy.String_IsLowerCase(str);

        /// <summary>
        /// Находится ли вся строка в ВЕРХНЕМ регистре
        /// </summary>
        /// <param name="str">Строка</param>
        /// <returns>Находится ли вся строка в ВЕРХНЕМ регистре</returns>
        protected bool String_IsUpperCase(string str) => StringProxy.String_IsUpperCase(str);

        /// <summary>
        /// Является ли строка пустой
        /// </summary>
        /// <param name="str">Строка</param>
        /// <returns>Является ли строка пустой</returns>
        protected bool String_IsEmpty(string str) => StringProxy.String_IsEmpty(str);

        /// <summary>
        /// Создает копию строки
        /// </summary>
        /// <param name="str">Строка</param>
        /// <returns>Копия строки</returns>
        protected string String_Copy(string str) => StringProxy.String_Copy(str);

        /// <summary>
        /// Форматирует строку
        /// </summary>
        /// <param name="str">Строка</param>
        /// <param name="values">Значения для подстановки</param>
        /// <returns>Форматированная строка</returns>
        protected string String_Format(string str, params object[] values) => StringProxy.String_Format(str, values);
    }
}

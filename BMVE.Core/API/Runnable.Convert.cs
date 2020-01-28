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
        /// Преобразует строку в целое число
        /// </summary>
        /// <param name="str">Строка</param>
        /// <returns>Целое число</returns>
        protected int Convert_StringToInt(string str) => ConvertProxy.Convert_StringToInt(str);

        /// <summary>
        /// Преобразует строку в дробное число
        /// </summary>
        /// <param name="str">Строка</param>
        /// <returns>Дробное число</returns>
        protected double Convert_StringToDouble(string str) => ConvertProxy.Convert_StringToDouble(str);

        /// <summary>
        /// Преобразует строку в логическое значение
        /// </summary>
        /// <param name="str">Строка</param>
        /// <returns>Логическое значение</returns>
        protected bool Convert_StringToBoolean(string str) => ConvertProxy.Convert_StringToBoolean(str);

        /// <summary>
        /// Преобразует целое число в дробное число
        /// </summary>
        /// <param name="value">Целое число</param>
        /// <returns>Дробное число</returns>
        protected double Convert_IntToDouble(int value) => ConvertProxy.Convert_IntToDouble(value);

        /// <summary>
        /// Преобразует целое число в строку
        /// </summary>
        /// <param name="value">Целое число</param>
        /// <returns>Строка</returns>
        protected string Convert_IntToString(int value) => ConvertProxy.Convert_IntToString(value);

        /// <summary>
        /// Преобразует целое число в логическое значение
        /// </summary>
        /// <param name="value">Целое число</param>
        /// <returns>Логическое значение</returns>
        protected bool Convert_IntToBoolean(int value) => ConvertProxy.Convert_IntToBoolean(value);

        /// <summary>
        /// Преобразует дробное число в строку
        /// </summary>
        /// <param name="value">Дробное число</param>
        /// <returns>Строка</returns>
        protected string Convert_DoubleToString(double value) => ConvertProxy.Convert_DoubleToString(value);

        /// <summary>
        /// Преобразует дробное число в целое число
        /// </summary>
        /// <param name="value">Дробное число</param>
        /// <returns>Целое число</returns>
        protected int Convert_DoubleToInt(double value) => ConvertProxy.Convert_DoubleToInt(value);

        /// <summary>
        /// Преобразует дробное число в логическое значение
        /// </summary>
        /// <param name="value">Дробное число</param>
        /// <returns>Логическое значение</returns>
        protected bool Convert_DoubleToBoolean(double value) => ConvertProxy.Convert_DoubleToBoolean(value);

        /// <summary>
        /// Преобразует логическое значение в строку
        /// </summary>
        /// <param name="value">Логическое значение</param>
        /// <returns>Строка</returns>
        protected string Convert_BooleanToString(bool value) => ConvertProxy.Convert_BooleanToString(value);

        /// <summary>
        /// Преобразует логическое значение в целое число
        /// </summary>
        /// <param name="value">Логическое значение</param>
        /// <returns>Целое число</returns>
        protected int Convert_BooleanToInt(bool value) => ConvertProxy.Convert_BooleanToInt(value);

        /// <summary>
        /// Преобразует логическое значение в дробное число
        /// </summary>
        /// <param name="value">Строка</param>
        /// <returns>Дробное число</returns>
        protected double Convert_BooleanToDouble(bool value) => ConvertProxy.Convert_BooleanToDouble(value);
    }
}

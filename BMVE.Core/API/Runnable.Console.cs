using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BMVE.Core.Commands;

namespace BMVE.Core
{
    public partial class Runnable
    {
        /// <summary>
        /// Печатает текст в консоль с новой строки
        /// <para>При печати текста используются настройки шрифта и цвет вывода текста</para>
        /// </summary>
        /// <param name="text">Текст, который должен быть выведен в консоль</param>
        protected void Console_WriteLine(params object[] text) => ConsoleProxy.Console_WriteLine(text);

        /// <summary>
        /// Читает строку, которую пользователь вводит с клавиатуры
        /// </summary>
        /// <param name="prompt">Строка-приглашение к вводу</param>
        /// <returns>Строка, введенная с клавиатуры</returns>
        protected string Console_ReadLine(string prompt = "") => ConsoleProxy.Console_ReadLine(prompt);

        /// <summary>
        /// Читает целое число, которое пользователь вводит с клавиатуры
        /// </summary>
        /// <param name="prompt">Строка-приглашение к вводу</param>
        /// <returns>Число, введенная с клавиатуры</returns>
        protected int Console_ReadInt(string prompt = "") => ConsoleProxy.Console_ReadInt(prompt);

        /// <summary>
        /// Читает дробное число, которое пользователь вводит с клавиатуры
        /// </summary>
        /// <param name="prompt">Строка-приглашение к вводу</param>
        /// <returns>Число, введенная с клавиатуры</returns>
        protected double Console_ReadDouble(string prompt = "") => ConsoleProxy.Console_ReadDouble(prompt);

        /// <summary>
        /// Читает двоичный флаг, который пользователь вводит с клавиатуры
        /// <para>Поддерживаются символы:</para>
        /// <para>true = <c>1</c>, <c>T</c>, <c>Y</c>, <c>Д</c></para>
        /// <para>false = <c>0</c>, <c>F</c>, <c>N</c>, <c>Н</c></para>
        /// </summary>
        /// <param name="prompt">Строка-приглашение к вводу</param>
        /// <returns>Флаг, введенный с клавиатуры</returns>
        protected bool Console_ReadBool(string prompt = "") => ConsoleProxy.Console_ReadBool(prompt);
    }
}

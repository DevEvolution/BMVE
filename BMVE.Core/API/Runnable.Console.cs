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
        /// <returns>Строка, введенная с клавиатуры</returns>
        protected string Console_ReadString() => ConsoleProxy.Console_ReadString();
    }
}

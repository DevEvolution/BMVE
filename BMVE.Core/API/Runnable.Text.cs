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
        /// Отображает текст по указанным координатам
        /// </summary>
        /// <param name="text">Текст</param>
        /// <param name="x">Координата X</param>
        /// <param name="y">Координата Y</param>
        protected void Text_Write(string text, int x, int y) => TextProxy.Text_Write(text, x, y);

        /// <summary>
        /// Отображает окрашенный текст по указанным координатам
        /// </summary>
        /// <param name="text">Текст</param>
        /// <param name="x">Координата X</param>
        /// <param name="y">Координата Y</param>
        /// <param name="color">Цвет текста</param>
        protected void Text_Write(string text, int x, int y, int color) => TextProxy.Text_Write(text, x, y, color);

        /// <summary>
        /// Задает семейство шрифтов для отображения текста
        /// </summary>
        /// <param name="fontFamily">Название семейства шрифтов</param>
        protected void Text_SetFont(string fontFamily) => TextProxy.Text_SetFont(fontFamily);

        /// <summary>
        /// Задает размер шрифта
        /// </summary>
        /// <param name="fontSize">Размер шрифта</param>
        protected void Text_SetFontSize(double fontSize) => TextProxy.Text_SetFontSize(fontSize);

        /// <summary>
        /// Задает стиль текста: обычный
        /// </summary>
        protected void Text_SetFontNormal() => TextProxy.Text_SetFontNormal();

        /// <summary>
        /// Задает стиль текста: жирный
        /// </summary>
        protected void Text_SetFontBold() => TextProxy.Text_SetFontBold();

        /// <summary>
        /// Задает стиль текста: курсив
        /// </summary>
        protected void Text_SetFontItalic() => TextProxy.Text_SetFontItalic();

        /// <summary>
        /// Задает стиль текста: жирый курсив
        /// </summary>
        protected void Text_SetFontBoldItalic() => TextProxy.Text_SetFontBoldItalic();

        /// <summary>
        /// Возвращает название используемого шрифта
        /// </summary>
        /// <returns>Название используемого шрифта</returns>
        protected string Text_GetFont() => TextProxy.Text_GetFont();

        /// <summary>
        /// Возвращает размер используемого шрифта
        /// </summary>
        /// <returns>Размер используемого шрифта</returns>
        protected double Text_GetFontSize() => TextProxy.Text_GetFontSize();
    }
}

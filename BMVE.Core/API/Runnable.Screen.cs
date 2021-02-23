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
        /// <param name="x">Координата X</param>
        /// <param name="y">Координата Y</param>
        /// <param name="text">Текст</param>
        protected void Screen_DrawText(int x, int y, string text) => ScreenProxy.Screen_DrawText(x, y, text);

        /// <summary>
        /// Отображает окрашенный текст по указанным координатам
        /// </summary>
        /// <param name="x">Координата X</param>
        /// <param name="y">Координата Y</param>
        /// <param name="text">Текст</param>
        /// <param name="color">Цвет текста</param>
        protected void Screen_DrawText(int x, int y, string text, int color) => ScreenProxy.Screen_DrawText(x, y, text, color);

        /// <summary>
        /// Задает размер линии
        /// </summary>
        /// <param name="size">Размер линии</param>
        protected void Screen_SetLineSize(int size) => ScreenProxy.Screen_SetLineSize(size);

        /// <summary>
        /// Возвращает размер линии
        /// </summary>
        /// <returns>Размер линии</returns>
        protected int Screen_GetLineSize() => ScreenProxy.Screen_GetLineSize();

        /// <summary>
        /// Рисует линию заданным цветом
        /// </summary>
        /// <param name="x">Координата X</param>
        /// <param name="y">Координата Y</param>
        /// <param name="width">Ширина линии</param>
        /// <param name="height">Высота линии</param>
        /// <param name="color">Цвет линии</param>
        protected void Screen_DrawLine(int x, int y, int width, int height, int color) => ScreenProxy.Screen_DrawLine(x, y, width, height, color);

        /// <summary>
        /// Рисует незакрашенный прямоугольник
        /// </summary>
        /// <param name="x">Координата X</param>
        /// <param name="y">Координата Y</param>
        /// <param name="width">Ширина</param>
        /// <param name="height">Высота</param>
        /// <param name="color">Цвет окантовки</param>
        protected void Screen_DrawRectangle(int x, int y, int width, int height, int color) => ScreenProxy.Screen_DrawRectangle(x, y, width, height, color);

        /// <summary>
        /// Рисует закрашенный прямоугольник
        /// </summary>
        /// <param name="x">Координата X</param>
        /// <param name="y">Координата Y</param>
        /// <param name="width">Ширина</param>
        /// <param name="height">Высота</param>
        /// <param name="foregroundColor">Цвет окантовки</param>
        /// <param name="backgroundColor">Цвет заливки</param>
        protected void Screen_DrawRectangle(int x, int y, int width, int height, int foregroundColor, int backgroundColor) => ScreenProxy.Screen_DrawRectangle(x, y, width, height, foregroundColor, backgroundColor);

        /// <summary>
        /// Рисует незакрашенный эллипс
        /// </summary>
        /// <param name="x">Координата X</param>
        /// <param name="y">Координата Y</param>
        /// <param name="width">Ширина</param>
        /// <param name="height">Высота</param>
        /// <param name="color">Цвет окантовки</param>
        protected void Screen_DrawEllipse(int x, int y, int width, int height, int color) => ScreenProxy.Screen_DrawEllipse(x, y, width, height, color);

        /// <summary>
        /// Рисует закрашенный эллипс
        /// </summary>
        /// <param name="x">Координата X</param>
        /// <param name="y">Координата Y</param>
        /// <param name="width">Ширина</param>
        /// <param name="height">Высота</param>
        /// <param name="foregroundColor">Цвет окантовки</param>
        /// <param name="backgroundColor">Цвет заливки</param>
        protected void Screen_DrawEllipse(int x, int y, int width, int height, int foregroundColor, int backgroundColor) => ScreenProxy.Screen_DrawEllipse(x, y, width, height, foregroundColor, backgroundColor);

        /// <summary>
        /// Рисует изображение по указанным координатам
        /// </summary>
        /// <param name="number">Номер изображения</param>
        /// <param name="x">Координата X</param>
        /// <param name="y">Координата Y</param>
        protected void Screen_DrawImage(int number, int x, int y) => ScreenProxy.Screen_DrawImage(number, x, y);

        /// <summary>
        /// Рисует изображение по указанных размеров по координатам
        /// </summary>
        /// <param name="number">Номер изображения</param>
        /// <param name="x">Координата X</param>
        /// <param name="y">Координата Y</param>
        /// <param name="width">Ширина</param>
        /// <param name="height">Высота</param>
        protected void Screen_DrawImage(int number, int x, int y, int width, int height) => ScreenProxy.Screen_DrawImage(number, x, y, width, height);

        /// <summary>
        /// Кодирует цвет как комбинацию трёх основных цветов: красного, зелёного и синего
        /// </summary>
        /// <param name="r">Насыщенность красного цвета (от 0 до 255)</param>
        /// <param name="g">Насыщенность зеленого цвета (от 0 до 255)</param>
        /// <param name="b">Насыщенность синего цвета (от 0 до 255)</param>
        /// <returns>Закодированный цвет</returns>
        protected int RGB(byte r, byte g, byte b) => ScreenProxy.RGB(r, g, b);

        /// <summary>
        /// Кодирует цвет как комбинацию четырёх компонент: красного, зелёного, синего цветов и альфа-канала (коэффициент прозрачности)
        /// </summary>
        /// <param name="r">Насыщенность красного цвета (от 0 до 255)</param>
        /// <param name="g">Насыщенность зеленого цвета (от 0 до 255)</param>
        /// <param name="b">Насыщенность синего цвета (от 0 до 255)</param>
        /// <param name="a">Альфа-канал (коеффициент прозрачности) (от 0 до 255)</param>
        /// <returns>Закодированный цвет</returns>
        protected int RGBA(byte r, byte g, byte b, byte a) => ScreenProxy.RGBA(r, g, b, a);

        /// <summary>
        /// Очистка экрана и заливка его цветом, указанным при помощи команды <see cref="Screen_SetBackgroundColor(int)"/>
        /// </summary>
        protected void Screen_Clear() => ScreenProxy.Screen_Clear();

        /// <summary>
        /// Устанавливает цвет заливки экрана при очистке с помощью команды <see cref="Screen_Clear"/>
        /// </summary>
        /// <param name="color">Цвет заливки</param>
        protected void Screen_SetBackgroundColor(int color) => ScreenProxy.Screen_SetBackgroundColor(color);

        /// <summary>
        /// Команда отрисовки элементов на экран при включенном режиме <see cref="System_SetBufferedDrawingMode"/>
        /// </summary>
        protected void Screen_Render() => ScreenProxy.Screen_Render();

        /// <summary>
        /// Задает режим отображения: немедленное отображение
        /// </summary>
        protected void Screen_SetImmediateDrawingMode() => ScreenProxy.Screen_SetDrawingMode(Enums.RenderingMode.Immediate);

        /// <summary>
        /// Задает режим отображения: буферизованное отображение
        /// </summary>
        protected void Screen_SetBufferedDrawingMode() => ScreenProxy.Screen_SetDrawingMode(Enums.RenderingMode.Buffered);
    }
}

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
        /// Рисует линию заданным цветом
        /// </summary>
        /// <param name="x">Координата X</param>
        /// <param name="y">Координата Y</param>
        /// <param name="width">Ширина линии</param>
        /// <param name="height">Высота линии</param>
        /// <param name="color">Цвет линии</param>
        protected void Draw_Line(int x, int y, int width, int height, int color) => DrawingProxy.Draw_Line(x, y, width, height, color);

        /// <summary>
        /// Рисует незакрашенный прямоугольник
        /// </summary>
        /// <param name="x">Координата X</param>
        /// <param name="y">Координата Y</param>
        /// <param name="width">Ширина</param>
        /// <param name="height">Высота</param>
        /// <param name="color">Цвет окантовки</param>
        protected void Draw_Rectangle(int x, int y, int width, int height, int color) => DrawingProxy.Draw_Rectangle(x, y, width, height, color);

        /// <summary>
        /// Рисует закрашенный прямоугольник
        /// </summary>
        /// <param name="x">Координата X</param>
        /// <param name="y">Координата Y</param>
        /// <param name="width">Ширина</param>
        /// <param name="height">Высота</param>
        /// <param name="foregroundColor">Цвет окантовки</param>
        /// <param name="backgroundColor">Цвет заливки</param>
        protected void Draw_Rectangle(int x, int y, int width, int height, int foregroundColor, int backgroundColor) => DrawingProxy.Draw_Rectangle(x, y, width, height, foregroundColor, backgroundColor);

        /// <summary>
        /// Рисует незакрашенный эллипс
        /// </summary>
        /// <param name="x">Координата X</param>
        /// <param name="y">Координата Y</param>
        /// <param name="width">Ширина</param>
        /// <param name="height">Высота</param>
        /// <param name="color">Цвет окантовки</param>
        protected void Draw_Ellipse(int x, int y, int width, int height, int color) => DrawingProxy.Draw_Ellipse(x, y, width, height, color);

        /// <summary>
        /// Рисует закрашенный эллипс
        /// </summary>
        /// <param name="x">Координата X</param>
        /// <param name="y">Координата Y</param>
        /// <param name="width">Ширина</param>
        /// <param name="height">Высота</param>
        /// <param name="foregroundColor">Цвет окантовки</param>
        /// <param name="backgroundColor">Цвет заливки</param>
        protected void Draw_Ellipse(int x, int y, int width, int height, int foregroundColor, int backgroundColor) => DrawingProxy.Draw_Ellipse(x, y, width, height, foregroundColor, backgroundColor);

        /// <summary>
        /// Кодирует цвет как комбинацию трёх основных цветов: красного, зелёного и синего
        /// </summary>
        /// <param name="r">Насыщенность красного цвета (от 0 до 255)</param>
        /// <param name="g">Насыщенность зеленого цвета (от 0 до 255)</param>
        /// <param name="b">Насыщенность синего цвета (от 0 до 255)</param>
        /// <returns>Закодированный цвет</returns>
        protected int RGB(int r, int g, int b) => DrawingProxy.RGB((byte)r, (byte)g, (byte)b);

        /// <summary>
        /// Очистка экрана и заливка его цветом, указанным при помощи команды <see cref="Screen_SetBackgroundColor(int)"/>
        /// </summary>
        protected void Screen_Clear() => DrawingProxy.Screen_Clear();

        /// <summary>
        /// Устанавливает цвет заливки экрана при очистке с помощью команды <see cref="Screen_Clear"/>
        /// </summary>
        /// <param name="color">Цвет заливки</param>
        protected void Screen_SetBackgroundColor(int color) => DrawingProxy.Screen_SetBackgroundColor(color);

        /// <summary>
        /// Команда отрисовки элементов на экран при включенном режиме <see cref="System_SetBufferedDrawingMode"/>
        /// </summary>
        protected void Screen_Render() => DrawingProxy.Screen_Render();
    }
}

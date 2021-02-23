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
        /// Загружает изображение
        /// </summary>
        /// <param name="number">Номер изображения, под которым будет загружено изображение</param>
        /// <param name="path">Путь к изображению</param>
        protected void Image_Load(int number, string path) => ImageProxy.Image_Load(number, path);

        /// <summary>
        /// Закрывает изображение
        /// </summary>
        /// <param name="number">Номер изображения</param>
        protected void Image_Close(int number) => ImageProxy.Image_Close(number);

        /// <summary>
        /// Поворачивает изображение
        /// </summary>
        /// <param name="number">Номер изображения</param>
        /// <param name="degrees">Угол в градусах</param>
        protected void Image_Rotate(int number, double degrees) => ImageProxy.Image_Rotate(number, degrees);

        /// <summary>
        /// Получает угол, на который повернуто изображение
        /// </summary>
        /// <param name="number">Номер изображения</param>
        /// <returns>Угол в градусах</returns>
        protected double Image_GetAngle(int number) => ImageProxy.Image_GetAngle(number);

        /// <summary>
        /// Получает ширину изображения
        /// </summary>
        /// <param name="number">Номер изображения</param>
        /// <returns>Ширина в пикселях</returns>
        protected int Image_GetWidth(int number) => ImageProxy.Image_GetWidth(number);

        /// <summary>
        /// Получает высоту изображения
        /// </summary>
        /// <param name="number">Номер изображения</param>
        /// <returns>Высота в пикселях</returns>
        protected int Image_GetHeight(int number) => ImageProxy.Image_GetHeight(number);
    }
}

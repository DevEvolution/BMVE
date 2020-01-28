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
        /// Арккосинус числа
        /// </summary>
        /// <param name="a">Число</param>
        /// <returns>Арккосинус числа</returns>
        protected double Math_Acos(double a) => MathProxy.Math_Acos(a);

        /// <summary>
        /// Арксинус числа
        /// </summary>
        /// <param name="a">Число</param>
        /// <returns>Арксинус числа</returns>
        protected double Math_Asin(double a) => MathProxy.Math_Asin(a);

        /// <summary>
        /// Арктангенс числа
        /// </summary>
        /// <param name="a">Число</param>
        /// <returns>Арктангенс числа</returns>
        protected double Math_Atan(double a) => MathProxy.Math_Atan(a);

        /// <summary>
        /// Возвращает угол, тангенс которого равен отношению двух указанных чисел
        /// </summary>
        /// <param name="a">Число A</param>
        /// <param name="b">Число B</param>
        /// <returns>Угол, тангенс которого равен отношению двух указанных чисел</returns>
        protected double Math_Atan2(double a, double b) => MathProxy.Math_Atan2(a, b);

        /// <summary>
        /// Модуль числа
        /// </summary>
        /// <param name="a">Число</param>
        /// <returns>Модуль числа</returns>
        protected double Math_Abs(double a) => MathProxy.Math_Abs(a);

        /// <summary>
        /// Округляет число в большую сторону
        /// </summary>
        /// <param name="a">Число</param>
        /// <returns>Округленное число</returns>
        protected double Math_Ceil(double a) => MathProxy.Math_Ceil(a);

        /// <summary>
        /// Косинус числа
        /// </summary>
        /// <param name="a">Число</param>
        /// <returns>Косинус числа</returns>
        protected double Math_Cos(double a) => MathProxy.Math_Cos(a);

        /// <summary>
        /// Гиперболический косинус числа
        /// </summary>
        /// <param name="a">Число</param>
        /// <returns>Гиперболический косинус числа</returns>
        protected double Math_Cosh(double a) => MathProxy.Math_Cosh(a);

        /// <summary>
        /// Экспонента числа
        /// </summary>
        /// <param name="a">Число</param>
        /// <returns>Экспонента числа</returns>
        protected double Math_Exp(double a) => MathProxy.Math_Exp(a);

        /// <summary>
        /// Округляет число в меньшую сторону
        /// </summary>
        /// <param name="a">Число</param>
        /// <returns>Округленное число</returns>
        protected double Math_Floor(double a) => MathProxy.Math_Floor(a);

        /// <summary>
        /// Логарифм числа
        /// </summary>
        /// <param name="a">Число</param>
        /// <returns>Логарифм числа</returns>
        protected double Math_Log(double a) => MathProxy.Math_Log(a);

        /// <summary>
        /// Десятичный логарифм числа
        /// </summary>
        /// <param name="a">Число</param>
        /// <returns>Десятичный логарифм числа</returns>
        protected double Math_Log10(double a) => MathProxy.Math_Log10(a);

        /// <summary>
        /// Возводит число в указанную степень
        /// </summary>
        /// <param name="a">Число</param>
        /// <param name="power">Степень</param>
        /// <returns>Число в указанной степени</returns>
        protected double Math_Pow(double a, double power) => MathProxy.Math_Pow(a, power);

        /// <summary>
        /// Округляет число
        /// </summary>
        /// <param name="a">Число</param>
        /// <returns>Округленное число</returns>
        protected double Math_Round(double a) => MathProxy.Math_Round(a);

        /// <summary>
        /// Синус числа
        /// </summary>
        /// <param name="a">Число</param>
        /// <returns>Синус числа</returns>
        protected double Math_Sin(double a) => MathProxy.Math_Sin(a);

        /// <summary>
        /// Гиперболический синус числа
        /// </summary>
        /// <param name="a">Число</param>
        /// <returns>Гиперболический синус числа</returns>
        protected double Math_Sinh(double a) => MathProxy.Math_Sinh(a);

        /// <summary>
        /// Квадратный корень числа
        /// </summary>
        /// <param name="a">Число</param>
        /// <returns>Квадратный корень числа</returns>
        protected double Math_Sqrt(double a) => MathProxy.Math_Sqrt(a);

        /// <summary>
        /// Тангенс числа
        /// </summary>
        /// <param name="a">Число</param>
        /// <returns>Тангенс</returns>
        protected double Math_Tan(double a) => MathProxy.Math_Tan(a);

        /// <summary>
        /// Гиперболический тангенс числа
        /// </summary>
        /// <param name="a">Число</param>
        /// <returns>Гиперболический тангенс числа</returns>
        protected double Math_Tanh(double a) => MathProxy.Math_Tanh(a);

        /// <summary>
        /// Откидывает дробную часть
        /// </summary>
        /// <param name="a">Число</param>
        /// <returns>Число без дробной части</returns>
        protected double Math_Truncate(double a) => MathProxy.Math_Truncate(a);

        /// <summary>
        /// Возвращает число пи
        /// </summary>
        /// <returns>Число пи</returns>
        protected double Math_PI() => MathProxy.Math_PI();

        /// <summary>
        /// Возвращает случайное целое число
        /// </summary>
        /// <returns>Случайное число</returns>
        protected int Math_RandomInt() => MathProxy.Math_RandomInt();

        /// <summary>
        /// Возвращает случайное десятичное число
        /// </summary>
        /// <returns>Случайное число</returns>
        protected double Math_RandomDouble() => MathProxy.Math_RandomDouble();
    }
}

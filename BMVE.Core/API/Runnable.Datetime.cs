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
        /// Возвращает текущую дату и время
        /// </summary>
        /// <returns>Текущая дата и время</returns>
        protected DateTime Datetime_Now() => DatetimeProxy.Datetime_Now();

        /// <summary>
        /// Возвращает текущую дату и время в формате UTC
        /// </summary>
        /// <returns>Текущая дата и время в формате UTC</returns>
        protected DateTime Datetime_UtcNow() => DatetimeProxy.Datetime_UtcNow();

        /// <summary>
        /// Возвращает текущую дату
        /// </summary>
        /// <returns>Текущая дата</returns>
        protected DateTime Datetime_GetCurrentDate() => DatetimeProxy.Datetime_GetCurrentDate();

        /// <summary>
        /// Возвращает текущую дату в формате UTC
        /// </summary>
        /// <returns>Текущая дата в формате UTC</returns>
        protected DateTime Datetime_GetCurrentUtcDate() => DatetimeProxy.Datetime_GetCurrentUtcDate();

        /// <summary>
        /// Возвращает текущее время
        /// </summary>
        /// <returns>Текущее время</returns>
        protected DateTime Datetime_GetCurrentTime() => DatetimeProxy.Datetime_GetCurrentTime();

        /// <summary>
        /// Возвращает текущее время в формате UTC
        /// </summary>
        /// <returns>Текущее время в формате UTC</returns>
        protected DateTime Datetime_GetCurrentUtcTime() => DatetimeProxy.Datetime_GetCurrentUtcTime();

        /// <summary>
        /// Возвращает текущий год
        /// </summary>
        /// <returns>Текущий год</returns>
        protected int Datetime_GetCurrentYear() => DatetimeProxy.Datetime_GetCurrentYear();

        /// <summary>
        /// Возвращает текущий месяц
        /// </summary>
        /// <returns>Текущий месяц</returns>
        protected int Datetime_GetCurrentMonth() => DatetimeProxy.Datetime_GetCurrentMonth();

        /// <summary>
        /// Возвращает текущий день
        /// </summary>
        /// <returns>Текущий день</returns>
        protected int Datetime_GetCurrentDay() => DatetimeProxy.Datetime_GetCurrentDay();

        /// <summary>
        /// Возвращает текущий день недели
        /// </summary>
        /// <returns>Текущий день недели</returns>
        protected int Datetime_GetCurrentDayOfWeek() => DatetimeProxy.Datetime_GetCurrentDayOfWeek();

        /// <summary>
        /// Возвращает текущий час
        /// </summary>
        /// <returns>Текущий час</returns>
        protected int Datetime_GetCurrentHour() => DatetimeProxy.Datetime_GetCurrentHour();

        /// <summary>
        /// Возвращает текущую минуту
        /// </summary>
        /// <returns>Текущая минута</returns>
        protected int Datetime_GetCurrentMinutes() => DatetimeProxy.Datetime_GetCurrentMinutes();

        /// <summary>
        /// Возвращает текущую секунду
        /// </summary>
        /// <returns>Текущая секунда</returns>
        protected int Datetime_GetCurrentSeconds() => DatetimeProxy.Datetime_GetCurrentSeconds();

        /// <summary>
        /// Возвращает текущую миллисекунду
        /// </summary>
        /// <returns>Текущая миллисекунда</returns>
        protected int Datetime_GetCurrentMilliseconds() => DatetimeProxy.Datetime_GetCurrentMilliseconds();

        /// <summary>
        /// Создает форматированную строку даты
        /// </summary>
        /// <param name="year">Год</param>
        /// <param name="month">Месяц</param>
        /// <param name="day">День</param>
        /// <returns>Дата</returns>
        protected DateTime Datetime_CreateDate(int year, int month = 1, int day = 1) => DatetimeProxy.Datetime_CreateDate(year, month, day);

        /// <summary>
        /// Создает форматированную строку даты и времени
        /// </summary>
        /// <param name="year">Год</param>
        /// <param name="month">Месяц</param>
        /// <param name="day">День</param>
        /// <param name="hours">Час</param>
        /// <param name="minutes">Минута</param>
        /// <param name="seconds">Секунда</param>
        /// <returns>Дата и время</returns>
        protected DateTime Datetime_CreateDatetime(int year, int month = 1, int day = 1, int hours = 0, int minutes = 0, int seconds = 0) => DatetimeProxy.Datetime_CreateDatetime(year, month, day, hours, minutes, seconds);

        /// <summary>
        /// Создает форматированную строку времени
        /// </summary>
        /// <param name="hours">Час</param>
        /// <param name="minutes">Минута</param>
        /// <param name="seconds">Секунда</param>
        /// <returns>Время</returns>
        protected DateTime Datetime_CreateTime(int hours = 0, int minutes = 0, int seconds = 0) => DatetimeProxy.Datetime_CreateTime(hours, minutes, seconds);

        /// <summary>
        /// Складывает две <see cref="DateTime"/>
        /// </summary>
        /// <param name="first">Первая дата и время</param>
        /// <param name="second">Вторая дата и время</param>
        /// <returns>Сумма двух <see cref="DateTime"/></returns>
        protected DateTime Datetime_Add(DateTime first, DateTime second) => DatetimeProxy.Datetime_Add(first, second);

        /// <summary>
        /// Вычитает <see cref="DateTime"/> из <see cref="DateTime"/>
        /// </summary>
        /// <param name="first">Откуда вычитают</param>
        /// <param name="second">Сколько вычитают</param>
        /// <returns>Разность двух <see cref="DateTime"/></returns>
        protected DateTime Datetime_Subtract(DateTime first, DateTime second) => DatetimeProxy.Datetime_Subtract(first, second);
    }
}

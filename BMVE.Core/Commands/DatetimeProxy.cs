using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMVE.Core.Commands
{
    internal static class DatetimeProxy
    {
        internal static DateTime Datetime_Now() => DateTime.Now;
        internal static DateTime Datetime_UtcNow() => DateTime.UtcNow;
        internal static DateTime Datetime_GetCurrentDate() => DateTime.Now.Date;
        internal static DateTime Datetime_GetCurrentUtcDate() => DateTime.UtcNow.Date;
        internal static DateTime Datetime_GetCurrentTime() => new DateTime(DateTime.Now.TimeOfDay.Ticks);
        internal static DateTime Datetime_GetCurrentUtcTime() => new DateTime(DateTime.UtcNow.TimeOfDay.Ticks);
        internal static int Datetime_GetCurrentYear() => DateTime.Now.Date.Year;
        internal static int Datetime_GetCurrentMonth() => DateTime.Now.Date.Month;
        internal static int Datetime_GetCurrentDay() => DateTime.Now.Date.Day;
        internal static int Datetime_GetCurrentDayOfWeek() => (int)DateTime.Now.Date.DayOfWeek;
        internal static int Datetime_GetCurrentHour() => DateTime.Now.TimeOfDay.Hours;
        internal static int Datetime_GetCurrentMinutes() => DateTime.Now.TimeOfDay.Minutes;
        internal static int Datetime_GetCurrentSeconds() => DateTime.Now.TimeOfDay.Seconds;
        internal static int Datetime_GetCurrentMilliseconds() => DateTime.Now.TimeOfDay.Milliseconds;
        internal static DateTime Datetime_CreateDate(int year, int month = 1, int day = 1) => new DateTime(day, month, year);
        internal static DateTime Datetime_CreateDatetime(int year, int month = 1, int day = 1, int hours = 0, int minutes = 0, int seconds = 0) => new DateTime(year, month, day, hours, minutes, seconds);
        internal static DateTime Datetime_CreateTime(int hours = 0, int minutes = 0, int seconds = 0) => new DateTime(0, 0, 0, hours, minutes, seconds);
        
        internal static DateTime Datetime_Add(DateTime a, DateTime b) => a.Add(new TimeSpan(b.Ticks));
        internal static DateTime Datetime_Subtract(DateTime a, DateTime b) => new DateTime(a.Subtract(b).Ticks);

        // TODO: Datetime diff, Datetime addition, Datetime subtraction
    }
}

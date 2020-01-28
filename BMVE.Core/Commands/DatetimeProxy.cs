using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMVE.Core.Commands
{
    internal static class DatetimeProxy
    {
        internal static string Datetime_Now() => DateTime.Now.ToString();
        internal static string Datetime_UtcNow() => DateTime.UtcNow.ToString();
        internal static string Datetime_GetCurrentDate() => DateTime.Now.ToString("d");
        internal static string Datetime_GetCurrentUtcDate() => DateTime.UtcNow.ToString("d");
        internal static string Datetime_GetCurrentTime() => DateTime.Now.ToString("T");
        internal static string Datetime_GetCurrentUtcTime() => DateTime.UtcNow.ToString("T");
        internal static int Datetime_GetCurrentYear() => DateTime.Now.Date.Year;
        internal static int Datetime_GetCurrentMonth() => DateTime.Now.Date.Month;
        internal static int Datetime_GetCurrentDay() => DateTime.Now.Date.Day;
        internal static int Datetime_GetCurrentDayOfWeek() => (int)DateTime.Now.Date.DayOfWeek;
        internal static int Datetime_GetCurrentHour() => DateTime.Now.TimeOfDay.Hours;
        internal static int Datetime_GetCurrentMinutes() => DateTime.Now.TimeOfDay.Minutes;
        internal static int Datetime_GetCurrentSeconds() => DateTime.Now.TimeOfDay.Seconds;
        internal static int Datetime_GetCurrentMilliseconds() => DateTime.Now.TimeOfDay.Milliseconds;
        internal static string Datetime_CreateDate(int year, int month = 1, int day = 1) => new DateTime(day, month, year).ToString("d");
        internal static string Datetime_CreateDatetime(int year, int month = 1, int day = 1, int hours = 0, int minutes = 0, int seconds = 0) => new DateTime(day, month, year, hours, minutes, seconds).ToString();
        internal static string Datetime_CreateTime(int hours = 0, int minutes = 0, int seconds = 0) => new TimeSpan(hours, minutes, seconds).ToString("T");

        // TODO: Datetime diff, Datetime addition, Datetime subtraction
    }
}

using System;

namespace Vein.DateTimeToolbox.Extensions
{
    public static class DateTimeExtensions
    {
        public static DateTime Yesterday(this DateTime date)
        {
            return date.AddDays(-1);
        }
    }
}

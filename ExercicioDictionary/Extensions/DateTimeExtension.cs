using System;
using System.Collections.Generic;
using System.Globalization;

namespace ExtensionMethods.Extensions
{
    static class DateTimeExtension
    {

        public static string ElapsedTime(this DateTime thisObj)
        {
            TimeSpan  duration = DateTime.Now.Subtract(thisObj);

            if (duration.TotalHours < 24.0)
            {
                return duration.TotalHours.ToString("f1", CultureInfo.InvariantCulture) + "hours";

            }
            else
            {
                return duration.TotalHours.ToString("f1", CultureInfo.InvariantCulture) + "days";
            }
        }
    }
}

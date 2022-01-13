using System;
using System.Collections.Generic;
using System.Text;

namespace HtmlAgilityPack
{
    public static class HtmlAttributeExtensions
    {
        public static DateTime GetJavaTimeStamp(this HtmlAttribute attribute) => TimeUtility.JavaTimeStampToDateTime(double.Parse(attribute.Value));
        public static DateTime GetUnixTimeStamp(this HtmlAttribute attribute) => TimeUtility.UnixTimeStampToDateTime(double.Parse(attribute.Value));
    }

    internal static class TimeUtility
    {
        public static DateTime UnixTimeStampToDateTime(double unixTimeStamp)
        {
            // Unix timestamp is seconds past epoch
            DateTime dateTime = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc);
            dateTime = dateTime.AddSeconds(unixTimeStamp).ToLocalTime();
            return dateTime;
        }

        public static DateTime JavaTimeStampToDateTime(double javaTimeStamp)
        {
            // Java timestamp is milliseconds past epoch
            DateTime dateTime = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc);
            dateTime = dateTime.AddMilliseconds(javaTimeStamp).ToLocalTime();
            return dateTime;
        }
    }
}

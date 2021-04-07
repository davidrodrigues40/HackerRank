namespace Core.Services
{
    public static class TimeService
    {
        public static (string hour, string min, string sec) GetMilitaryTime(string[] timeArray)
        {
            int hour = int.Parse(timeArray[0]);
            int min = int.Parse(timeArray[1]);
            int sec = int.Parse(timeArray[2].Substring(0, 2));
            string ap = timeArray[2].Substring(2, 2);

            if (ap == "PM" && hour != 12)
            {
                hour += 12;
            }

            if (ap == "AM" && hour == 12)
            {
                hour = 0;
            }

            return (ConvertToStringValues(hour, min, sec));
        }

        private static (string hour, string min, string sec) ConvertToStringValues(int hour, int min, int sec)
        {
            var format = "00";
            return (FormatString(hour, format), FormatString(min, format), FormatString(sec, format));
        }

        private static string FormatString(int value, string format)
        {
            return value.ToString(format);
        }
    }
}

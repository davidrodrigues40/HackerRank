using System;

namespace Core.Problems
{
    public class TimeConversion : IWorker
    {
        public void DoWork(object input)
        {
            var s = (string)input;
            var timeArr = s.Split(':');
            var (hour, min, sec) = GetMilitaryTime(timeArr);

            Console.WriteLine($"{hour}:{min}:{sec}");

        }

        private (string hour, string min, string sec) GetMilitaryTime(string[] timeArray)
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

        private (string hour, string min, string sec) ConvertToStringValues(int hour, int min, int sec)
        {
            var format = "00";
            return (FormatInt(hour, format), FormatInt(min, format), FormatInt(sec, format));
        }

        private string FormatInt(int value, string format)
        {
            return value.ToString(format);
        }
    }
}

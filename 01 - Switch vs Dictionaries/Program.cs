using System;
using System.Collections.Generic;

namespace SwitchVsDictionaries
{
    class Program
    {
        static void Main()
        {
            int day = 3;
            Console.WriteLine($"Using switch: {GetDayNameSwitch(day)}");
            Console.WriteLine($"Using dictionary: {GetDayNameDictionary(day)}");
        }

        public static string GetDayNameSwitch(int day)
        {
            return day switch
            {
                1 => "Monday",
                2 => "Tuesday",
                3 => "Wednesday",
                4 => "Thursday",
                5 => "Friday",
                6 => "Saturday",
                7 => "Sunday",
                _ => "Invalid day"
            };
        }

        private static readonly Dictionary<int, string> DayNames = new()
        {
            { 1, "Monday" },
            { 2, "Tuesday" },
            { 3, "Wednesday" },
            { 4, "Thursday" },
            { 5, "Friday" },
            { 6, "Saturday" },
            { 7, "Sunday" }
        };

        public static string GetDayNameDictionary(int day)
        {
            return DayNames.TryGetValue(day, out var name) ? name : "Invalid day";
        }
    }
}

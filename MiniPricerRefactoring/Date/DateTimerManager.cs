using System;
using System.Collections.Generic;
using System.Linq;
using CalcService;

namespace MiniPricerRefactoring
{
    public static class DateTimerManager
    {
        public static DateTime? from;
        public static DateTime? to;
        public static IEnumerable<DateTime> dates;
        public static int numberOff;
        public static int GetDays()
        {
            dates = Referentials.Dates(from.Value.Year);
            int result = 0;
            var i = (to - from).Value.Days;
            if (from > to)
                throw new Exception("Error");
            if (from == null)
                throw new Exception("No value");
            if (to == null)
                throw new Exception("No value");

            if (to > from)
            {
                for (int j = 0; j < i; j++)
                {
                    DateTime newDate = from.Value.AddDays(j);
                    if (newDate.DayOfWeek != DayOfWeek.Saturday &&
                        newDate.DayOfWeek != DayOfWeek.Sunday)
                    {
                        if (dates.Contains(newDate))
                            continue;
                        else
                            result++;
                    }
                    else
                    {
                        numberOff++;
                    }
                }
            }

            return result;
        }
    }
}

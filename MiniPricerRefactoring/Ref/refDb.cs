using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace MiniPricerRefactoring.Ref
{
    public static class refDb
    {
        private static bool TestConnec()
        {
            if (File.Exists("Data/Dates.txt"))
                return true;

            return false;
        }

        public static IEnumerable<DateTime> GetDates()
        {
            if (!TestConnec())
                ServiceLocator.Instance.Logger.Log("The referential is broken");
            else
            {
                var list = File.ReadAllLines("Data/Dates.txt");
                foreach (var s in list)
                {
                    yield return DateTime.Parse(s);
                }
            }
        }
    }
}

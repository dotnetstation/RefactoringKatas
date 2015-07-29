using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniPricerRefactoring.Ref
{
    public static class Referentials
    {
        private static readonly DateTime[] dates =
        {
            new DateTime(2013, 05, 01), 
            new DateTime(2014, 05, 01),
            new DateTime(2012, 05, 01),
            new DateTime(2011, 05, 01),
            new DateTime(2010, 05, 01),
            new DateTime(2015, 05, 01),
            new DateTime(2013, 05, 08), 
            new DateTime(2014, 05, 08),
            new DateTime(2012, 05, 08),
            new DateTime(2011, 05, 08),
            new DateTime(2010, 05, 08),
            new DateTime(2015, 05, 08),
            new DateTime(2013, 12, 25), 
            new DateTime(2014, 12, 25),
            new DateTime(2012, 12, 25),
            new DateTime(2011, 12, 25),
            new DateTime(2010, 12, 25),
            new DateTime(2015, 01, 01),
            new DateTime(2013, 01, 01),
            new DateTime(2014, 01, 01),
            new DateTime(2012, 01, 01),
            new DateTime(2011, 01, 01),
            new DateTime(2010, 01, 01),
            new DateTime(2015, 01, 01),
        };

        public static IEnumerable<DateTime> Dates(int year)
        {
            IEnumerable<DateTime> listOfDates;

            try
            {
                // get referentiel dates
                listOfDates = refDb.GetDates();

            }
            catch (Exception)
            {
                // get default dates 
                // todo check if is complete
                listOfDates = dates.ToList();
            }

            if (listOfDates != null)
            {
                foreach (var date in listOfDates)
                {
                    if (date.Year == year)
                        yield return date;
                }
            }
        }
    }
}

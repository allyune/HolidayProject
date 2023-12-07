using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Utils
{
    public static class PropertiesUtils
    {
        public static bool isAvailableForPeriod(
           DateTime fromDate, DateTime toDate, List<DateTime> bookedDates)
        {
            return !bookedDates.Any(date => date >= fromDate && date <= toDate);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPINCSHARP
{
    internal class LeapYear
    {
       public int year;
   public LeapYear(int leap)
        {
            for (year = leap; year <= 2100; year += 4)
            {
                Console.WriteLine(year);
            }
        }
        public static void CheckLeapYears()
        {
            Console.WriteLine("The Next 20 Leap Years Are");
             new LeapYear(2022);
        }

}
}

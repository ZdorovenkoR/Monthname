using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monthname
{
    class Program
    {
         enum MonthName
        {
            january,
            February,
            March,
            April,
            May,
            June,
            July,
            August,
            September,
            October,
            November,
            December
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите порядковый номер месяца");
            int monthNumber = Convert.ToInt32(Console.ReadLine());
            if (monthNumber <= 0 || monthNumber > 12)
            {
                Console.WriteLine("Порядковый номер должен быть в диапозоне от 1 до 12");
                return;
            }
            if (monthNumber == 1)
                Console.WriteLine(MonthName.january);
            else if (monthNumber == 2)
                Console.WriteLine(MonthName.February);
            else if (monthNumber == 3)
                Console.WriteLine(MonthName.March);
            else if (monthNumber == 4)
                Console.WriteLine(MonthName.April);
            else if (monthNumber == 5)
                Console.WriteLine(MonthName.May);
            else if (monthNumber == 6)
                Console.WriteLine(MonthName.June);
            else if (monthNumber == 7)
                Console.WriteLine(MonthName.July);
            else if (monthNumber == 8)
                Console.WriteLine(MonthName.August);
            else if (monthNumber == 9)
                Console.WriteLine(MonthName.September);
            else if (monthNumber == 10)
                Console.WriteLine(MonthName.October);
            else if (monthNumber == 11)
                Console.WriteLine(MonthName.November);
            else if (monthNumber == 12)
                Console.WriteLine(MonthName.December);


        }
    }
};

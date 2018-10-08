using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int month year;
            Console.WriteLine("Escribe el mes");
            month = Int32.Parse(Console.ReadLine());
            CheckMonth(month);

           Console.WriteLine(AskDay(year, month));


            Console.ReadKey();
        }
        public static int CheckMonth(int month)
        {
            int count = 0;
            do
            {
                if (count > 0)
                {
                    Console.WriteLine("El número de mes no es correcto, introduzca de nuevo");
                    month = Int32.Parse(Console.ReadLine());
                }
                count = count + 1;
            } while (month < 1 || month > 12);
            return month;
        }

        public static int AskDay(int year, int month)
        {
            int maxDays;

            if (DateTime.IsLeapYear(year) && month == 2)
            {
                maxDays = 29;
            }
            else if (!DateTime.IsLeapYear(year) && month == 2)
            {
                maxDays = 28;
            }
            else if (month==3 || month == 6|| month== 9|| month ==11)
            {
                maxDays = 30;
            }
            else 
            {
                maxDays = 31;
            }

            return maxDays;


            return day;
        }
    }
}

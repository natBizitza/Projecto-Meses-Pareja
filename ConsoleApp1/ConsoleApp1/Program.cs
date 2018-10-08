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
            int month, year, maxDays,randYear1, randYear2;
            Console.WriteLine("Escribe el mes");
            month = Convert.ToInt32(Console.ReadLine());
            CheckMonth(month);

            Console.WriteLine("Escriba dos años entre los que generar uno aleatorio");
            randYear1 = Convert.ToInt32(Console.ReadLine());
            randYear2 = Convert.ToInt32(Console.ReadLine());
            year = Year(randYear1, randYear2);

            Console.WriteLine("El año generado es " + year);
            maxDays = AskDays(year, month);

            Console.WriteLine(AskDays(year, month));

        

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

        public static int Year(int randYear1, int randYear2)
        {
            int year;
            Random random = new Random();
            if (randYear2 > randYear1)
            {
                year = random.Next(randYear1, randYear2);//Max value al final  
            }
            else
            {
                year = random.Next(randYear2, randYear1);
            }
            return year;
        }

        public static int AskDays(int year, int month)
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
        }

        public static int ShowNextDay(int days, int maxDays, int month, int year)
        {
          if(days +1 >maxDays)
            {
                days = 1;
                month++;
            }
          else if(month>12)
            {
                year++;
            } else
            {
                //Console.WriteLine("Something is wrong");
            }
          return days, month, year;
        }
    }
}

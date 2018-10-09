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
            int month, year, maxDays,randYear1, randYear2, days;
            Console.WriteLine("Escribe el mes");
            month = Convert.ToInt32(Console.ReadLine());
            month = CheckMonth(month);

            Console.WriteLine("Escriba dos años entre los que generar uno aleatorio");
            randYear1 = Convert.ToInt32(Console.ReadLine());
            randYear2 = Convert.ToInt32(Console.ReadLine());
            year = Year(randYear1, randYear2);

            Console.WriteLine("El año generado es " + year);
            maxDays = AskDays(year, month);

            Console.WriteLine(AskDays(year, month));

            Console.WriteLine("Introduce un dia ");
            days = Convert.ToInt32(Console.ReadLine());

            //Hay que cambiar el valor de days porque si no cuando diera error se quedaria con el valor asignado anteriormente
            days = CheckDay(days, maxDays);
            
            Console.WriteLine("Date: " + days + "/" + month + "/" + year);

            ShowNextDay( days, month, year, maxDays);

            Console.ReadKey();
        }

        public static int CheckMonth(int month)
        {
            //to repeat until it´s correct
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
                year = random.Next(randYear1, randYear2 +1 );//Max value al final  
            }
            else
            {
                year = random.Next(randYear2, randYear1 +1);
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

        public static int CheckDay(int days, int maxDays)
        {
            do
            {
                if (maxDays < days || days < 1)
                {
                    Console.WriteLine("Please, introduce correct day.");
                    days = Convert.ToInt32(Console.ReadLine());
                } 
            } while (days > maxDays || days < 1);

            return days;
        }

        public static void ShowNextDay(int days, int month, int year, int maxDays)
        {
            //int days, month, maxDays, year;
            days++;
            if (days > maxDays)
            {
                days = 1;
                month++;
                if (month > 12)
                {
                    month=1;
                    year++;
                }
            }
            Console.WriteLine("Next date: " + days + "/" + month + "/" + year);
        }

        
    }
}

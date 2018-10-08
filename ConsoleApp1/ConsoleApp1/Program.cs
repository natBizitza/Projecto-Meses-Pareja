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
            int month;
            Console.WriteLine("Escribe el mes");
            month = Int32.Parse(Console.ReadLine());
            CheckMonth(month);


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
    }
}

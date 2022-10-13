using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("bir sayı girin");
            int sayi = Convert.ToInt16(Console.ReadLine());
            Console.Clear();
            int i, j;
            for (i = 1; i <= sayi; i++)
            {
                for (j = 1; j <= i; j++)
                {
                    Console.Write("" + (j));
                }
                Console.WriteLine("");
            }
            Console.ReadKey();
        }
    }
}

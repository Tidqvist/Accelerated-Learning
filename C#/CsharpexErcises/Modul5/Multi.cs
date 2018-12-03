using System;
using System.Collections.Generic;
using System.Text;

namespace Modul5
{
    class Multi
    {
        public static void MultiplicationTable(params int[] numbers)
        {
            foreach (var number in numbers)
            {
                PrintMultiplicationTable(number);
            }
        }

        public static void PrintMultiplicationTable(int x)
        {
            Console.WriteLine();
            PrintHeader(x);
            for (int i = 1; i <= x; i++)
            {
                Console.WriteLine($"{x} * {i} = {(x * i)}");
            }
        }

        public static void PrintHeader(int x)
        {
            Console.WriteLine("╔═════════════════════════════╗");
            Console.WriteLine($"║ Multiplikationstabell för {x} ║");
            Console.WriteLine("╚═════════════════════════════╝");

            //int length = 30;
            //for (int col = 0; col <= length; col++)
            //{
            //    if (col == 0)
            //        Console.Write("╔");
            //    else if (col == length)
            //        Console.Write("╗");
            //    else
            //        Console.Write("═");
            //}
            //Console.WriteLine();
            //for (int col = 0; col <= length; col++)
            //{
            //    if (col == 0 | col == length)
            //        Console.Write("║");
            //    else
            //        Console.Write(" ");
            //}
            //Console.WriteLine();
            //for (int col = 0; col <= length; col++)
            //{
            //    if (col == 0)
            //        Console.Write("╚");
            //    else if (col == length)
            //        Console.Write("╝");
            //    else
            //        Console.Write("═");
            //}
        }
    }
}

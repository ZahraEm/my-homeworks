using System;

namespace Problem1_31Dec
{
    class Program
    {
        static void Main(string[] args)
        {
            WithArray.MaxMin();


            //------------------------without Array---------------
            //int max;
            //int min;

            //try
            //{

            //    Console.WriteLine("Please Enter a Number:");
            //    int n = Convert.ToInt32(Console.ReadLine());
            //    Console.WriteLine($"Please Enter Number {(1)}:");
            //    int m = Convert.ToInt32(Console.ReadLine());
            //    max = m;
            //    min = m;
            //    for (int i = 1; i < n; i++)
            //    {
            //        Console.WriteLine($"Please Enter Number {(i + 1)}:");
            //         m = Convert.ToInt32(Console.ReadLine());

            //        if (m > max)
            //        {
            //            max = m;
            //        }
            //        if (m < min)
            //        {
            //            min = m;
            //        }
            //    }
            //    Console.WriteLine("max is:" + max);
            //    Console.WriteLine("min is:" + min);
            //}

            //catch (FormatException)
            //{
            //    Console.ForegroundColor = ConsoleColor.Red;
            //    Console.WriteLine("Please Enter Just a Number.");
            //}


            Console.ReadKey();
        }
    }
}

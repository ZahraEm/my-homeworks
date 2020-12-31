using System;
using System.Collections.Generic;
using System.Text;

namespace Problem1_31Dec
{
    class WithArray
    {
        public static void MaxMin()
        {
            int max;
            int min;

            try
            {

                Console.WriteLine("Please Enter a Number:");
                int n = Convert.ToInt32(Console.ReadLine());
                int[] numbers = new int[n];

                for (int i = 0; i < n; i++)
                {
                    Console.WriteLine($"Please Enter Number {(i + 1)}:");
                    numbers[i] = Convert.ToInt32(Console.ReadLine());
                }
                max = numbers[0];
                min = numbers[0];
                foreach (int item in numbers)
                {
                    if (item > max)
                    {
                        max = item;
                    }
                    if (item < min)
                    {
                        min = item;
                    }
                }
                Console.WriteLine("max is:" + max);
                Console.WriteLine("min is:" + min);

            }

            catch (FormatException)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Please Enter Just a Number.");
            }


            Console.ReadKey();
        }
    }
}

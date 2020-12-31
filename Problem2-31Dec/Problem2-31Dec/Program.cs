using System;

namespace Problem2_31Dec
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y = 0;
            Console.WriteLine("Please Enter a number:");
            int number = Convert.ToInt32(Console.ReadLine());
            int n = number;
            while (n > 0)
            {
                x = n % 10;
                y = (y * 10) + x;
                n = n / 10;
            }
            Console.WriteLine("Reverse Is::" + y);

            if (y == number)
            {
                Console.BackgroundColor = ConsoleColor.Green;
                Console.WriteLine("adad motegharen ast");
                Console.ResetColor();

            }

            else
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.WriteLine("adad na motegharen ast");
                Console.ResetColor();
            }


            Console.ReadKey();
        }
    }
}

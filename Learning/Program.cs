using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning
{
    class Program
    {
        static void Main(string[] args)
        {
                Console.WriteLine("A = ");
                int a = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("B = ");
                int b = Convert.ToInt32(Console.ReadLine());
                if (a > b && a % b == 0)
                {
                    Console.WriteLine($"{a} bigger than {b} and remainder equals 0");
                }
                else if (a > b && a % b != 0)
                {
                    Console.WriteLine($"{a} bigger than {b} and remainder don't equals 0");
                }
                else if (a < b && b % a == 0)
                {
                    Console.WriteLine($"{a} smaller than {b} and remainder equals 0");
                }
                else if (a < b && b % a != 0)
                {
                    Console.WriteLine($"{a} smaller than {b} and remainder don't equals 0");
                }
                else if ( a == b )
                {
                    Console.WriteLine($"{a} equals {b}");
                }
            string selection = Console.ReadLine();
            switch (selection)
            {
                case "Y":
                    Console.WriteLine("Y");
                    break;
                case "N":
                    Console.WriteLine("N");
                    break;
                default:
                    Console.WriteLine("Error");
                    break;
            }
            int[] arrayWithPositiveNumbers = { 1, 2, 3, 4, 5, -1, -3, -5, 8, 14, 32 };
            int countOfPositiveNumbers = 0;
            string positiveNumbers;
            foreach(int number in arrayWithPositiveNumbers)
            {
                if( number > 0 )
                {
                        Console.Write(number + " ");
                        countOfPositiveNumbers++;
                }
            }
            Console.Write("- positive numbers");
            Console.WriteLine(" ");
            Console.WriteLine($"Count of positive numbers is {countOfPositiveNumbers}");


            /*int[] numbers = { -4, -3, -2, -1, 0, 1, 2, 3, 4 };

            int n = numbers.Length;
            int x = n / 2;
            int temp;
            for(int i = 0; i < x; i++)
            {
                temp = numbers[i];
                numbers[i] = numbers[n - i-1];
                numbers[n - i-1] = temp;
            }
            foreach(int i in numbers)
            {
                Console.Write($"{i} \t");
            }*/


            Console.ReadLine();
        }
    }
}

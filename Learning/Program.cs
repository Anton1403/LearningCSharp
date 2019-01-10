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

            int[] numbers = new int[7];
            Console.WriteLine("Write 7 numbers");
            for(int i = 0; i < numbers.Length; i++)
            {
                Console.Write("{0} number is: ", i + 1);
                numbers[i] = Int32.Parse(Console.ReadLine());
            }

            int temp;
            for (int i = 0; i < numbers.Length; i++)
            {
                for ( int j = i + 1; j < numbers.Length; j++)
                {
                    if(numbers[i] > numbers[j])
                    {
                        temp = numbers[i];
                        numbers[i] = numbers[j];
                        numbers[j] = temp;
                    }
                }
            }
            Console.WriteLine("Sorted array: ");
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }

               
            /*int[] arrayWithPositiveNumbers = { 1, 2, 3, 4, 5, -1, -3, -5, 8, 14, 32 };
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
            */



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

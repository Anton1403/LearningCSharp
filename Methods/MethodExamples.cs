using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    class MethodExamples
    {
        static void Main(string[] args)
        {
            int a = 10;
            int b = 20;

            string greeting = SayHello();
            string parting = SayGoodBye();
            Console.WriteLine(greeting + " and " + parting);

            int sum = GetSum( 10, 15 );
            Console.WriteLine(sum); // 25
            sum = GetSum(a, b);
            Console.WriteLine(sum); // 30
            sum = GetSum(a + b + 10, 20);
            Console.WriteLine(sum); // 60
            Display("Anton", 20);

            int result = OptionalParam(2, 3);
            Console.WriteLine(result); // 14
            result = OptionalParam(2, 3, 10);
            Console.WriteLine(result); // 19

            result = OptionalParam(x: 2, y: 4); // You can named parameters how you wanna to do, also in disparity way
            Console.WriteLine(result); // 15
            result = OptionalParam(y: 1, x: 2, s: 3); // Disparity way (first - y, second - x, third - s), although arguments should be in order
            Console.WriteLine(result); // 11

            int aa = 5;
            Console.WriteLine($"Number a = {aa}"); // 5
            IncrementRef(ref aa); // 6
            Console.WriteLine($"Now number a = {aa}"); // 6, ref use link on our number 'aa'

            GetData(10, 15, out int area, out int perim);
            Console.WriteLine($"Area = {area}"); // 150 is area
            Console.WriteLine($"Perimetr = {perim}"); // 50 is perimetr

            Addition(1, 2, 3, 4, 5); // get sum of this numbers = 15
            int[] array = new int[] { 1, 2, 3, 4 }; 
            Addition(array); // // get sum of array above = 10
            Addition(); // we dont transfer to method anything, so we will see 0(in method we have variable result, which equals 0)

            Addition1(3, "hello", 21, 22); // we can transfer int, string and array

            Addition2(1, 2, 3, 4, 5);
            int[] array1 = new int[] { 1, 2, 3, 4 };
            Addition2Mas(array1, 2);

            Console.ReadLine();
        }

        static string SayHello() // method which display hello
        {
            return "Hello, my Dear";
        }

        static string SayGoodBye() // method which display bye
        {
            return "GoodBye, my Dear";
        }

        static int GetSum(int x, int y) // returned sum of numbers
        {
            return x + y;
        }

        static void Display(string name, int age) // method with different types of arguments
        {
            Console.WriteLine($"Name: {name}, Age: {age}");
        }

        static int OptionalParam(int x, int y, int z = 5, int s = 4) // optional Parameters
        {
            return  x + y + z + s;
        }

        static void IncrementRef(ref int x) // ref method
        {
            x++;
            Console.WriteLine($"IncrementRef: {x}");
        }

        static void GetData(int x, int y, out int area, out int perim) // out-parameters
        {
            area = x * y;
            perim = (x + y) * 2;
        }

        static void Addition(params int[] integers) // if we dont know count of parameters, we well use 'params'
        {
            int result = 0;
            for(int i = 0; i < integers.Length; i++)
            {
                result += integers[i];
            }
            Console.WriteLine(result);
        }

        static void Addition1(int x, string mes, params int[] integers ) // different parameters: int, string int[]
        {
            Console.WriteLine($"{x}, {mes}");
            for(int i = 0; i< integers.Length; i++)
            {
                Console.WriteLine($"{integers[i]} ");
            }
        }

        static void Addition2(params int[] integers)
        {
            int result = 0;
            for(int i = 0; i < integers.Length; i++)
            {
                result += integers[i];
            }
            Console.WriteLine(result);
        }
        static void Addition2Mas(int[] integers, int k)
        {
            int result = 0;
            for(int i = 0; i < integers.Length; i++)
            {
                result += (integers[i] * k);
            }
            Console.WriteLine(result);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    class Program
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
    }
}

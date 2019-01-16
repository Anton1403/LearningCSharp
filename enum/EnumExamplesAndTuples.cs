using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace @enum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write 2 numbers: ");
            double a = Convert.ToDouble(Console.ReadLine());
            double b = Convert.ToDouble(Console.ReadLine());
            MathOp(a, b, Operation.Add);
            MathOp(a, b, Operation.Multiply);

            var tuple = (5, 10); // tuple with 2 numbers
            Console.WriteLine(tuple.Item1); // output items of tuple
            Console.WriteLine(tuple.Item2);
            tuple.Item1 += 20; // add to the first item 20
            Console.WriteLine(tuple.Item1);

            var tuple1 = GetValues(); // get numbers from method
            Console.WriteLine(tuple1.Item1);
            Console.WriteLine(tuple1.Item2);
            Console.WriteLine(tuple1.Item3);

            var tuple2 = GetNamedValues(new int[] {1,2,3,4,5,6,7 });
            Console.WriteLine($"Sum of numbers equals {tuple2.sum}");
            Console.WriteLine($"Count of numbers equals {tuple2.count}");
            Console.ReadLine();
        }

        enum Operation 
        {
            Add = 1,
            Substract,
            Multiply,
            Divide
        }

        static void MathOp (double x, double y, Operation op) 
        {
            double result = 0.0;
            switch (op)
            {
                case Operation.Add:
                    result = x + y;
                    break;
                case Operation.Substract:
                    result = x - y;
                    break;
                case Operation.Multiply:
                    result = x * y;
                    break;
                case Operation.Divide:
                    result = x / y;
                    break;
            }
            Console.WriteLine($"Result of operation '{op}' equals {0}", result);
        }

        private static (int, int, int) GetValues()
        {
            var result = (1, 3, 5);
            return result;
        }

        private static (int sum, int count) GetNamedValues(int[] numbers) // method which counts summary of numbers and count of numbers
        {
            var result = (sum: 0, count: 0);
            for(int i = 0; i < numbers.Length; i++)
            {
                result.sum += numbers[i];
                result.count++;
            }
            return result;
        }
    }
}

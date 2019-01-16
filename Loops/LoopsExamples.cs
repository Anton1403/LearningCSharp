using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    class LoopsExamples
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 9; i++)
            {
                Console.WriteLine($"Квадрат числа {i} равен {i * i}");
            }



            int a = 6;
            while(a > 0)
            {
                Console.WriteLine(a);
                a--;
            }



            for (int x = 0; x < 9; x++)
            {
                if (x == 5)
                    continue;
                Console.WriteLine(x);
            }

            Console.ReadLine();
        }
    }
}

using System;
using System.Linq;

namespace Calculator
{
    class Program
    {
        delegate int Calculate(int x, int y);

        static void Main(string[] args)
        {
            var num = new[] {1, 2, 3, 4};

            Calculate calc = (x, y) => x + y;
            Console.WriteLine(GetValue(num, calc));

            calc += (x, y) => x * y;
            Console.WriteLine(GetValue(num, calc));

            Console.ReadKey();
        }

        private static int GetValue(int[] num, Calculate calc)
        {
            return num.Sum(n => calc(n, 1));
        }
    }
}
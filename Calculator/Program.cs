using System;
using System.Linq;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            var num = new[] {1, 2, 3, 4};

            Console.WriteLine(GetValue(num, (x, y) => x + y));
            Console.WriteLine(GetValue(num, (x, y) => x * y));

            Console.ReadKey();
        }

        private static int GetValue(int[] num, Func<int, int, int> calc)
        {
            return num.Sum(n => calc(n, 1));
        }
    }
}
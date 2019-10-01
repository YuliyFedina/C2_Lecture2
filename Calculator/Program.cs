using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            var num = new[] { 1, 2, 3, 4 };

            var calc = new Calculator(Operation.Add);
            Console.WriteLine(GetValue(num, calc));

            var multiply = new Calculator(Operation.Multiply);
            Console.WriteLine(GetValue(num, multiply));

            Console.ReadKey();
        }

        private static int GetValue(int[] num, Calculator calc)
        {
            int result = 0;

            foreach (var n in num)
            {
                result += calc.Calculate(n, 1);
            }

            return result;
        }
    }
}

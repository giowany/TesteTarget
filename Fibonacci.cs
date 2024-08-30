using System;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Fibonacci
{
    class Program
    {
        private static int a = 0;
        private static int b = 1;
        private static int c;
        private static int num = 0;

        static void Main(string[] args)
        {
            Calculate();
        }

        private static void Calculate()
        {
            Console.WriteLine("Digite um número: ");
            num = int.Parse(Console.ReadLine());

            if (BelongsFibonacci(num))
            {
                Console.WriteLine($"O número {num} pertence à sequência de Fibonacci.");
            }

            else
            {
                Console.WriteLine($"O número {num} não pertence à sequência de Fibonacci.");
            }


        }

        private static bool BelongsFibonacci(int n)
        {
            while(b < n)
            {
                c = b;
                b = b + a;
                a = c;
            }

            return b == n;
        }
    }
}
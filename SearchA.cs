using System;

namespace VerificadorDeLetras
{
    class Program
    {
        private static string text;
        private static string lowerText;
        private static int count = 0;

        static void Main(string[] args)
        {
            SearchA();
        }

        private static void SearchA()
        {

            Console.Write("Digite uma string: ");
            text = Console.ReadLine();

            lowerText = text.ToLower();

            count = 0;
            foreach (char character in lowerText)
            {
                if (character == 'a')
                {
                    count++;
                }
            }

            if (count > 0)
            {
                Console.WriteLine($"A letra 'a' aparece {count} vezes na string.");
            }
            else
            {
                Console.WriteLine("A letra 'a' não foi encontrada na string.");
            }
        }
    }
}
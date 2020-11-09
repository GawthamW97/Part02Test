using System;

namespace Part_02_Test
{
    class Program
    {
        static void Main(string[] args)
        {
            DiamondOne(4);
        }

        private static void DiamondOne(int num)
        {
            for(int i = 1; i < num; i++) 
            {
                for (int k = 0; k < num - i; k++)
                    Console.Write(" ");
                for (int j = 0; j < i; j++) 
                {
                    Console.Write("* ");
                }
                Console.WriteLine("");
            }

            for (int i = num; i > 0; i--)
            {
                for (int k = 0; k < num - i; k++)
                    Console.Write(" ");
                for (int j = 0; j < i; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine("");
            }
            Console.ReadLine();
        }
    }
}

using System;
using System.Numerics;

namespace _3N_1
{
    class Program
    {
        static void Main(string[] args)
        {
            BigInteger erg = BigInteger.Parse("1");
            BigInteger hold = erg;

            while(true)
            {
                erg = hold;
                Console.Write($"Processing {erg}");
                int stepCount = 0;
                while(erg != 1)
                {
                    erg = erg % 2 == 0 ? erg / 2 : erg * 3 + 1;
                    stepCount++;
                }
                Console.WriteLine($"  --> Took {stepCount} steps.");
                hold++;
            }
        }
    }
}

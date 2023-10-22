using System;

namespace programmeringsinlämning4_9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ange triangelns sidlängd");
            try
            {
                int sidlängd = int.Parse(Console.ReadLine());

                for (int a = 1; a <= sidlängd; a++)
                {
                    for (int b = 1; b <= a; b++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine("");
                }
            } 
            catch{
                Console.WriteLine("Ingen giltlig siffra");
            }
        }
    }
}
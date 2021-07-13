using System;

namespace Uebung05
{
    class Program
    {
        static void Main(string[] args)
        {
            Mammal[] Garten = new Mammal[2];
            Fish[] Aquarium = new Fish[2];

            Garten[0] = new Kaninchen("Kurt", "Henry");
            Garten[1] = new Katze("Hagen");

            Aquarium[0] = new Guppy("Kurt", "Gerhard");
            Aquarium[1] = new Goldfisch("Friedrich", "Ute");

            Pet[] Zoo = new Pet[4];
            int i = 0;

            foreach(var tier in Garten)
            {
                Zoo[i] = tier;
                i++;
            }

            foreach(var tier in Aquarium)
            {
                Zoo[i] = tier;
                i++;
            }

            
            foreach(var tier in Zoo)
            {
                Console.WriteLine(tier);
                tier.Attend();

                try
                {
                    (tier as IStrokeable).Stroke();
                }
                catch (System.NullReferenceException)
                {
                    Console.WriteLine();
                    continue;
                }
                
                Console.WriteLine();
            }
        }
    }
}

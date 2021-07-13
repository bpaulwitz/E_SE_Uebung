using System;

namespace Uebung05
{
    public class Katze : Mammal
    {
        public override void Attend()
        {
            System.Console.WriteLine("Fell bürsten.");
        }

        public override void Move()
        {
            System.Console.WriteLine("schleicht umher.");
        }

        public override void Stroke()
        {
            Console.WriteLine("Katze wird gestreichelt.");
            var rand = new System.Random();
            if(rand.NextDouble() <= 0.2)
            {
                Console.WriteLine("Katze beißt.");
            }
        }

        public override string ToString()
        {
            return $"Art: Katze\nName: {name}";
        }

        public Katze(string _name = "Katze") : base()
        {
            name = _name;
        }
    }
}
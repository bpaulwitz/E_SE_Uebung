using System;

namespace Aufgabe5
{
    class Program
    {
        static void Main(string[] args)
        {
            int augenZahl;
            Random rand = new Random();
            int bilanz = 0;

            for (int i = 0; i < 1000; i++)
            {
                bilanz--;
                augenZahl = 0;
                for (int j = 0; j < 3; j++)
                {
                   augenZahl += rand.Next(1, 7);
                }

                if(augenZahl == 16)
                    bilanz += 5;
                else if(augenZahl == 17)
                    bilanz += 10;
                else if(augenZahl == 18)
                    bilanz += 100;

                //oder übersichtlicher mit switch case:
                /*
                switch (augenZahl)
                {
                    case 16: bilanz += 5; break;
                    case 17: bilanz += 10; break;
                    case 18: bilanz += 100; break;
                }
                */
            }
            Console.WriteLine($"Bilanz: {bilanz} Euro");
        }
    }
}

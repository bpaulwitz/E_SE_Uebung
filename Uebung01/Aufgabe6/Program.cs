using System;
using System.Globalization;

namespace Aufgabe6
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] kitts, niue;
            Random rand = new Random();
            int anzahlJahre = 10;
            int basisJahr = 2021 - 10;
            kitts = new double[anzahlJahre];
            niue = new double[anzahlJahre];

            //Initialisieren mit zufälligen Werten
            for(int i = 0; i < anzahlJahre; i++)
            {
                kitts[i] = rand.NextDouble() * 10.0;
                niue[i] = rand.NextDouble() * 10.0;

                //Anzeigen
                Console.WriteLine("Jahr: {0}\tSt. Kitts. {1:0.00}\t\tNiue: {2:0.00}", basisJahr + i, kitts[i], niue[i]);
            }
            Console.WriteLine();

            //Man könnte natürlich auch beide for-Schleifen zusammenfassen, ich wollte hier nur die Initialisierung vom Rest trennen
            double ausKitts = 0.0, ausNiue = 0.0;
            for (int i = 0; i < anzahlJahre; i++)
            {
                ausKitts += kitts[i];
                ausNiue += niue[i];

                if(kitts[i] > niue[i])
                    Console.WriteLine($"Im Jahr {basisJahr + i} hat St. Kitts und Nevis einen höheren Ausstoß.", CultureInfo.InvariantCulture);
                else if(kitts[i] < niue[i])
                    Console.WriteLine($"Im Jahr {basisJahr + i} hat Niue einen höheren Ausstoß.", CultureInfo.InvariantCulture);
                else
                    Console.WriteLine($"Im Jahr {basisJahr + i} haben beide gleich hohen Ausstoß.", CultureInfo.InvariantCulture);
            }

            //Ausgabe des gesamten Ausstoßes (wird in der Ausgabe jeweils noch durch die Anzahl der Jahre geteilt, um den Durschnitt auszugeben)
            if(ausKitts > ausNiue)
                Console.WriteLine($"Insgesamt hat St. Kitts und Nevis mit {(ausKitts / anzahlJahre):0.00} einen höheren durschnittlichen Ausstoß.", CultureInfo.InvariantCulture);
            else if(ausKitts < ausNiue)
                Console.WriteLine($"Insgesamt hat Niue mit {(ausNiue / anzahlJahre):0.00} einen höheren durschnittlichen Ausstoß.", CultureInfo.InvariantCulture);
            else
                Console.WriteLine($"Insgesamt haben beide mit {(ausNiue / anzahlJahre):0.00} einen gleich hohen durschnittlichen Ausstoß.", CultureInfo.InvariantCulture);
        }
    }
}

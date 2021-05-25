using System;
using System.Globalization;

namespace Aufgabe4
{
    class Program
    {
        static void Main4_1()
        {
            //Objekt der Random-Klasse -> generiert uns mit den Methoden 'Next' und 'NextDouble' zufällige Werte
            Random rand = new Random();

            //anlegen eines Double-Arrays mit zufälliger Länge zwischen 1 und 500
            int arrayLength = rand.Next(499) + 1;
            double[] d_nuesse = new double[arrayLength];
            Console.WriteLine("Array Länge: {0}", arrayLength);

            for (int i = 0; i < arrayLength; i++)
            {
                d_nuesse[i] = rand.NextDouble() * (4.0 - 0.75) + 0.75;
            }

            for (int i = 0; i < arrayLength; i++)
            {
                Console.WriteLine($"{i}: {d_nuesse[i]}");
            }
        }
        static void Main4_2()
        {
            //Objekt der Random-Klasse -> generiert uns mit den Methoden 'Next' und 'NextDouble' zufällige Werte
            Random rand = new Random();

            //anlegen eines Double-Arrays mit zufälliger Länge zwischen 1 und 500
            int arrayLength = rand.Next(499) + 1;
            double[] d_nuesse = new double[arrayLength];
            Console.WriteLine("Array Länge: {0}", arrayLength);

            for (int i = 0; i < arrayLength; i++)
            {
                d_nuesse[i] = rand.NextDouble() * (4.0 - 0.75) + 0.75;
            }

            int anzahlHaselnuesse = 0, anzahlWalnuesse = 0;
            double volDurchschnHasel = 0.0, volDurchschnWal = 0.0;

            for (int i = 0; i < arrayLength; i++)
            {
                double currentDurchmesser = d_nuesse[i];
                double volumen = 1.0 / 6.0 * Math.PI * currentDurchmesser * currentDurchmesser * currentDurchmesser;
                bool isHasel = currentDurchmesser < 2.0;
                if(isHasel)
                {
                    anzahlHaselnuesse++;
                    volDurchschnHasel += volumen;
                }
                else
                {
                    anzahlWalnuesse++;
                    volDurchschnWal += volumen;
                }
            }

            volDurchschnHasel /= anzahlHaselnuesse;
            volDurchschnWal /= anzahlWalnuesse;

            Console.WriteLine($"Anzahl Haselnüsse: {anzahlHaselnuesse}\tDurchschnittl. Vol: {volDurchschnHasel}\n" + 
                $"Anzahl Walnüsse: {anzahlWalnuesse}\tDurchschnittl. Vol: {volDurchschnWal}", CultureInfo.InvariantCulture);
        }
        static void Main(string[] args)
        {
            Main4_2();
        }
    }
}

using System;
using System.Threading;

namespace Aufgabe1
{
    class Program
    {
        static void Flash(int delay)
        {
            //Vorherige Farbe speichern
            ConsoleColor previousColor = Console.BackgroundColor;
            //Allen Text aus der Konsole löschen
            Console.Clear();
            //In eine andere Farbe als die vorherige einfärben (entweder weiß oder rot)
            if(previousColor != ConsoleColor.White)
            {
                //Hintergrundfarbe setzen
                Console.BackgroundColor = ConsoleColor.White;
                //Konsole leeren (überschreibt alles vorherige mit 'unsichtbaren' Zeichen, die als Hintergrund die zuvor festgelegte Farbe haben)
                Console.Clear();
            }
            else
            {
                //Hintergrundfarbe setzen
                Console.BackgroundColor = ConsoleColor.Red;
                //Konsole leeren
                Console.Clear();
            }    
                
            //Für die eingegebene Zeit abwarten
            Thread.Sleep(delay);

            //Hintergrundfarbe auf die vorherige zurücksetzen
            Console.BackgroundColor = previousColor;
            //Text aus der Konsole löschen
            Console.Clear();
        }

        static void Main(string[] args)
        {
            //Text einlesen
            string input;
            Console.WriteLine("Text eingeben:");
            input = Console.ReadLine();

            //Jeden Buchstaben im Text durchgehen
            foreach (char character in input)
            {
                //Buchstabe zu Morsecode konvertieren
                string morseCode = MorseTable.GetMorseCode(character);

                //jedes Signal (dargestellt durch '.' oder '-') im Morsecode durchgehen
                foreach (char morseChar in morseCode)
                {
                    //kurzes Signal
                    if(morseChar == '.')
                        Flash(100);
                    //langes Signal
                    else if(morseChar == '-')
                        Flash(500);
                    //Falls ein Char weder '.' noch '-' ist, können wir eine Exception werfen
                    else
                        throw new FormatException(morseChar + " is not a valide morse symbol!");
                    //Kurz warten, bevor wir das nächste Signal senden
                    Thread.Sleep(100);
                }
            }
        }
    }
}

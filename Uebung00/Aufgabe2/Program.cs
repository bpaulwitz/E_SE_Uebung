using System;
using System.Globalization;

namespace Aufgabe2
{
    class Program
    {
        enum Kategory
        {
            A, B, C, NOT_SET
        }

        static void Main(string[] args)
        {
            string Bezeichnung = "BEZEICHNUNG";
            int Registriernummer = -1;
            char Kategorie = 'Z';
            //Kategory Kategorie = Kategory.NOT_SET;
            double Leuchtkraft = -1.00;

            //String einlesen
            Console.WriteLine("Bitte Bezeichnung eingeben:");
            Bezeichnung = Console.ReadLine();

            //String einlesen und zu Int konvertieren
            Console.WriteLine("Bitte Registriernummer eingeben:");
            //TryParse gibt zurück, ob der Wert konvertiert werden konnte oder nicht
            bool isInt = int.TryParse(Console.ReadLine(), out Registriernummer);
            if(!isInt)
            {
                Console.WriteLine("ERROR: Der eingegebene Wert war kein Int!");
                return;
            }

            //Einzelnen Char einlesen
            Console.WriteLine("Bitte Kategorie eingeben:");
            Kategorie = Console.ReadKey().KeyChar;
            //Kategory.TryParse(Console.ReadLine(), out Kategorie);
            //Andere Möglichkeiten:
            //Kategorie = Console.ReadLine()[0]; //-> 1. Character im String
            //char.TryParse(Console.ReadLine(), out Kategorie); //

            //String einlesen und zu Double konvertieren (hier mal ausführlich mit Try-Catch Blöcken)
            Console.WriteLine("\nBitte Leuchtkraft eingeben:");
            try
            {
                Leuchtkraft = double.Parse(Console.ReadLine());
            }
            catch (ArgumentNullException e)
            {
                Console.WriteLine($"ERROR: ArgumentNullException (kann bei Console.ReadLine() nicht passieren, da immer ein string zurück gegeben wird) {e.ToString()}");
                return;
            }
            catch (FormatException e)
            {
                Console.WriteLine($"ERROR: FormatException (falsches Format) {e.ToString()}");
                return;
            }
            catch (OverflowException e)
            {
                Console.WriteLine("ERROR: OverflowException (falls der Wert zu groß ist, um in der Variable gespeichert zu werden." +
                $"Also hier wert < double.MinValue() oder wert > double.MaxValue()) {e.ToString()}");
                return;
            }
            
            //Alternativ natürlich:
            /*
            bool isDouble = double.TryParse(Console.ReadLine(), out Leuchtkraft);
            if(!isDouble)
            {
                Console.WriteLine("ERROR: Der eingegebene Wert war kein Double!");
                return;
            }
            */

            //Ausgabe
            Console.WriteLine($"\n\nBezeichnung: {Bezeichnung}\nRegistriernummer: {Registriernummer}\n" + 
                $"Kategorie: {Kategorie}\nLeuchtkraft: " + String.Format("{0:0.00}", Leuchtkraft), 
                CultureInfo.InvariantCulture, NumberStyles.AllowDecimalPoint);
        }
    }
}

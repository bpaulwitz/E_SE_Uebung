using System;
using System.Globalization;

namespace Aufgabe2
{
    class Program
    {
        //Enumeration
        enum Kategory
        {
            A, B, C, NOT_SET
        }

        //Main-Methode unseres Programms
        static void Main(string[] args)
        {
            string Bezeichnung = "BEZEICHNUNG";
            int Registriernummer = -1; //int können positiv oder negativ sein. Unsigned int nur positiv
            char Kategorie = 'Z'; //Einzelne Buchstaben/ Chars werden in '...' gespeichert, nicht wie strings in "..."
            //Kategory Kategorie = Kategory.NOT_SET; //Das ist die Möglichkeit mit den Enumerations
            double Leuchtkraft = -1.00;

            //Ausgabe auf der Konsole
            Console.WriteLine("Bitte Bezeichnung eingeben:");
            //String von der Konsole einlesen und in der Variable 'Bezeichnung' speichern
            Bezeichnung = Console.ReadLine();

            //String einlesen und zu Int konvertieren
            Console.WriteLine("Bitte Registriernummer eingeben:");
            //TryParse gibt zurück, ob der Wert konvertiert werden konnte oder nicht
            bool isInt = int.TryParse(Console.ReadLine(), out Registriernummer);
            if(!isInt) //Wenn es kein (!) int ist (also die Konvertierung erfolglos)
            {
                Console.WriteLine("ERROR: Der eingegebene Wert war kein Int!");
                //Verlässt die aktuelle Methode (und da wir in der Main-Methode sind, schließt das Programm). Ein Rückgabewert ist nicht nötig, weil die Main-Methode void (also nichts) zurück gibt
                return;
            }

            //Einzelnen Char einlesen
            Console.WriteLine("Bitte Kategorie eingeben:");
            Kategorie = Console.ReadKey().KeyChar; //Einlesen eines einzelnen Characters -> Die erste Taste, die gedrückt wird. Der Wert (was im Character steht), wird in .KeyChar gespeichert
            //Kategory.TryParse(Console.ReadLine(), out Kategorie); //Das ist die Möglichkeit mit den Enumerations
            //Andere Möglichkeiten:
            //Kategorie = Console.ReadLine()[0]; //-> Zugriff auf 1. Character (also an 0. Stelle, da fangen Programmierer an zu zählen) im String
            //char.Parse(Console.ReadLine(), out Kategorie); //man muss das Ergebnis von TryParse nicht unbedingt weiter nutzen um den Fehler aufzufangen, aber dann sollte man Parse nutzen

            //String einlesen und zu Double konvertieren (hier mal ausführlich mit Try-Catch Blöcken)
            //So wird es auch bei .TryParse gemacht. Hier ist es ausführlich mit Parse geschrieben.
            //Vorteil davon ist, dass auf verschiedene Fehlerfälle eingegangen werden kann
            Console.WriteLine("\nBitte Leuchtkraft eingeben:");
            try
            {
                Leuchtkraft = double.Parse(Console.ReadLine()); //Hier wird das Parsen im try-Block 'versucht'
            }
            catch (ArgumentNullException e) //Verschiedene Fehlertypen (hier: ArgumentNullException) werden nach dem Versuch in catch-Blöcken 'aufgefangen' und abgearbeitet.
            {
                //Wenn vor einem String ein '$' steht, können Variablen direkt in geschweiften Klammern in den String eingebettet und in diesem Fall ausgegeben werden. Die Methode .ToString() konvertiert jede Variable zu einem string
                Console.WriteLine($"ERROR: ArgumentNullException (kann bei Console.ReadLine() nicht passieren, da immer ein string zurück gegeben wird) {e.ToString()}");
                return;
            }
            catch (FormatException e) //Verschiedene Fehlertypen (hier: FormatException) werden nach dem Versuch in catch-Blöcken 'aufgefangen' und abgearbeitet.
            {
                Console.WriteLine($"ERROR: FormatException (falsches Format) {e.ToString()}");
                return;
            }
            catch (OverflowException e) //Verschiedene Fehlertypen (hier: OverflowException) werden nach dem Versuch in catch-Blöcken 'aufgefangen' und abgearbeitet.
            {
                Console.WriteLine("ERROR: OverflowException (falls der Wert zu groß ist, um in der Variable gespeichert zu werden." +
                $"Also hier wert < double.MinValue() oder wert > double.MaxValue()) {e.ToString()}");
                return;
            }
            
            //Alternativ ohne verschiedene Exceptions/ Fehler zu unterscheiden natürlich mit TryParse:
            /*
            bool isDouble = double.TryParse(Console.ReadLine(), out Leuchtkraft);
            if(!isDouble)
            {
                Console.WriteLine("ERROR: Der eingegebene Wert war kein Double!");
                return;
            }
            */

            //Ausgabe unter Benutzung von InvariantCulture und AllowDecimalPoint
            Console.WriteLine($"\n\nBezeichnung: {Bezeichnung}\nRegistriernummer: {Registriernummer}\n" + 
                //String.Format("{0:0.00}", [DOUBLE-WERT]) gibt den DOUBLE-WERT als String bis auf zwei Nachkommastellen aus
                $"Kategorie: {Kategorie}\nLeuchtkraft: " + String.Format("{0:0.00}", Leuchtkraft), 
                CultureInfo.InvariantCulture, NumberStyles.AllowDecimalPoint);
        }
    }
}

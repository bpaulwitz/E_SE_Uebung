using System;

namespace Aufgabe7
{
    class Program
    {
        static void Main(string[] args)
        {
            //Anlegen des Arrays
            string[] erstplatzierte = {
                "Dorothea Wierer",
                "Tiril Eckhoff",
                "Denise Herrmann",
                "Hanna Öberg",
                "Marte Olsbu Røiseland",
                "Franziska Preuß",
                "Ingrid Landmark Tandrevold",
                "Julia Simon",
                "Justine Braisaz",
                "Lisa Vittozzi"
            };

            //eine Zählvariable 'platz', die wir in jedem Schritt inkrementieren
            int platz = 1;

            //hier speichern wir die maximale Länge der jeweiligen Strings
            int maxLenghtPlatz = 0, maxLenghtName = 0;

            //maximale string länge herausfinden -> benötigen wir für das padding
            foreach (string name in erstplatzierte)
            {
                maxLenghtName = name.Length < maxLenghtName ? maxLenghtName : name.Length;
                maxLenghtPlatz = platz.ToString().Length < maxLenghtPlatz ? maxLenghtPlatz : platz.ToString().Length;
                platz++;
            }

            //maxLength ggf auf die Länge der Spaltentitel anpassen
            maxLenghtPlatz = "Platz".Length < maxLenghtPlatz ? maxLenghtPlatz : "Platz".Length;
            maxLenghtName = "Name".Length < maxLenghtName ? maxLenghtName : "Name".Length;

            //einen String anlegen, in dem wir unsere Markdown-Tabelle hineinschreiben
            //[string].PadRight([Anzahl], [Char]) hängt nach dem string [Anzahl] mal den Buchstaben [Char] an
            string markdownString = "| " + "Platz".PadRight(maxLenghtPlatz, ' ') + " | " + "Name".PadRight(maxLenghtName, ' ') + " |\n";
            //Zusätzliches Padding für fehlende Leerzeichen
            markdownString += "|".PadRight(maxLenghtPlatz + 3, '-') + "|".PadRight(maxLenghtName + 3, '-') + "|\n";

            //Wiederverwenden unserer Zählervariable
            platz = 1;
            foreach (string name in erstplatzierte)
            {
                markdownString += "| " + platz.ToString().PadRight(maxLenghtPlatz, ' ') + " | " + name.PadRight(maxLenghtName, ' ') + " |\n";
                platz++;
            }

            //Ausgabe der Markdown Tabelle
            Console.Write(markdownString);

            //Wiederholen, solange eine gültige Platzierung eingegeben wird
            do
            {
                Console.WriteLine("Platzierung eingeben:");
                try
                {
                    platz = int.Parse(Console.ReadLine());
                    //array fängt bei 0 zu zählen an, unsere Platzierungen bei 1 -> wir müssen 1 subtrahieren um auf den Array zuzugreifen
                    Console.WriteLine($"Platz {platz}: " + erstplatzierte[platz - 1]);
                }
                catch (System.FormatException e)
                {
                    Console.WriteLine("ERROR: Ungültiges Format!\n" + e.ToString());
                    break;
                }
                catch (System.IndexOutOfRangeException e)
                {
                    Console.WriteLine("ERROR: ungültiger Platz!\n" + e.ToString());
                    break;
                }
            }
            //Gültiger Platz: 1 <= platz <= 10
            while(platz <= 10 && platz >= 1);
        }
    }
}

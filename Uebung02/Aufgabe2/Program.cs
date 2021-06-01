using System;

namespace Aufgabe2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ein Energiewesen mit Konstruktor ohne Parametern erstellen
            Energiewesen fritz = new Energiewesen();
            Console.WriteLine(fritz);

            ////Ein Energiewesen mit Konstruktor mit Parametern erstellen
            Energiewesen kurt = new Energiewesen("Kurt", 1, Energiewesen.Kategorie.ELEKTRO, 52.7385f);
            Console.WriteLine(kurt);
        }
    }
}

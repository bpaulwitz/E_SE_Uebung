using System;
using System.Globalization;

namespace Aufgabe3
{
    class Program
    {
        static void Main(string[] args)
        {
            double intervallUnten, intervallOben;
            double schrittgroesse;
            double x, y;

            try
            {
                Console.WriteLine("Untere Intervallgrenze:");
                intervallUnten = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.WriteLine("Obere Intervallgrenze:");
                intervallOben = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.WriteLine("Schrittgröße:");
                schrittgroesse = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }
            catch (FormatException)
            {
                Console.WriteLine("Falsches Format");
                return;
            }
            catch (OverflowException)
            {
                Console.WriteLine("Überschreitung des Wertebereichs");
                return;
            }
            catch (Exception)
            {
                Console.WriteLine("Fehler");
                return;
            }

            x = intervallUnten;
            while (x <= intervallOben)
            {
                //Polstellen von f(x) -> durch 0 kann nicht geteilt werden
                if(Math.Abs((x + 2) * (x - 1) * (x - 1)) <= 0.001)
                {
                    Console.WriteLine("Polstelle bei " + x.ToString());
                }
                else
                {
                    y = (3 * x - 6) / ((x + 2) * (x - 1) * (x - 1));
                    Console.WriteLine($"f({x}) = {y}");
                }
                x += schrittgroesse;
            }
        }
    }
}

using System;

namespace Aufgabe4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("4a:\n");
            
            {
                int a = 1, b = 2, c = 3, r = 4;
                double y = 4.0;

                /*
                Wenn durch zwei Ganzzahlen (int a und int b) geteilt wird, ist auch das errechnete Ergebnis eine ganze Zahl (selbst wenn es wie hier in double gespeichert wird!)
                Möchte man hingegen den Rest berücksichtigen, muss man mindestens eine der beiden Variablen zuvor zu double oder float konvertieren, wie in der auskommentierten Folgezeile gezeigt
                */
                double d = a / b;
                //double d = a / (double)b; //-> löst das 'Problem'
                Console.WriteLine($"d = a / b = {d}");

                double f = a * b / (c - y) - a / b;
                //double f = a * b / (c - y) - a / (double)b;
                Console.WriteLine($"f = a * b / (c - y) - a / b = {f}");

                //In der Math-Assembly (in der System-Assembly enthalten) findet man nützliche mathematische Funktionen wie hier die Wurzel (Math.Sqrt) - Square-Root
                //Wenn Math.Sqrt einen negativen Input bekommt (wie hier), gibt es double.NaN zurück
                f = (-b * Math.Sqrt(b * b - 4 * a * c) / 2 * a);
                Console.WriteLine($"f = (-b * sqrt(b * b - 4 * a * c) / 2 * a) = {f}");

                //In der Math-Assembly (in der System-Assembly enthalten) findet man eine Annäherung an Pi (Math.PI)
                double A = Math.PI * r * r;
                Console.WriteLine($"A = Math.PI * r * r = {A}");
            }

            
            Console.WriteLine("\n\n4b:\n");
            {
                double x, y, x1, x2, y1, y2;

                //In den folgendem Abschnitt habe ich immer noch mögliche Konvertierfehler mitaufgefangen. Man sieht, dass es länglich wird.
                Console.WriteLine("Wert x eingeben:");
                bool isDouble = double.TryParse(Console.ReadLine(), out x);
                if(!isDouble)
                {
                    Console.WriteLine("ERROR: Kein double");
                    return;
                }

                Console.WriteLine("Wert y eingeben:");
                isDouble = double.TryParse(Console.ReadLine(), out y);
                if(!isDouble)
                {
                    Console.WriteLine("ERROR: Kein double");
                    return;
                }

                Console.WriteLine("Wert x1 eingeben:");
                isDouble = double.TryParse(Console.ReadLine(), out x1);
                if(!isDouble)
                {
                    Console.WriteLine("ERROR: Kein double");
                    return;
                }

                Console.WriteLine("Wert y1 eingeben:");
                isDouble = double.TryParse(Console.ReadLine(), out y1);
                if(!isDouble)
                {
                    Console.WriteLine("ERROR: Kein double");
                    return;
                }

                Console.WriteLine("Wert x2 eingeben:");
                isDouble = double.TryParse(Console.ReadLine(), out x2);
                if(!isDouble)
                {
                    Console.WriteLine("ERROR: Kein double");
                    return;
                }

                Console.WriteLine("Wert y2 eingeben:");
                isDouble = double.TryParse(Console.ReadLine(), out y2);
                if(!isDouble)
                {
                    Console.WriteLine("ERROR: Kein double");
                    return;
                }

                //1.
                /*
                x liegt zwischen x1 und x2 wenn:
                    (x kleiner gleich (<=) x1 UND (&&) x größer gleich (>=) x2 ist) ODER (||) (x kleiner gleich (<=) x2 UND (&&) x größer gleich (>=) x1 ist)
                */
                bool liegtDazwischen = (x <= x1 && x >= x2) || (x <= x2 && x >= x1);
                //Man kann auch bool-Variablen mit Console.WriteLine() ausgeben
                Console.WriteLine("Wert {0} liegt in dem Bereich [{1}...{2}]: {3}", x, x1, x2, liegtDazwischen);

                //2.                                                                    // wenn:
                bool inRechteck =   ((x <= x1 && x >= x2) || (x <= x2 && x >= x1)) &&   // x zwischen x1 und x2 UND (&&) //->Ausdrücke können über mehrere Zeilen gehen
                                    ((y <= y1 && y >= y2) || (y <= y2 && y >= y1));     // y zwischen y1 und y2
                Console.WriteLine("Wert liegt in dem Rechteck: {0}", inRechteck);

                //3.
                //wenn (x1 gleich (==) x2) UND (&&) (y1 gleich (==) y2)
                bool istGleich = (x1 == x2) && (y1 == y2);
                Console.WriteLine("Punkt 1 hat die gleichen Koordinaten wie Punkt 2: {0}", istGleich);

                //4.
                                                                                //wenn: 
                bool oder = ((x <= x1 && x >= x2) || (x <= x2 && x >= x1)) ||   // x zwischen x1 und x2 ODER (||)
                            ((y <= y1 && y >= y2) || (y <= y2 && y >= y1));     // y zwischen y1 und y2
                Console.WriteLine("x1 <= x <= x2 oder y1 <= y <= y2: {0}", oder);
            }
            
            Console.WriteLine("\n\n4c:\n");
            {
                //Speichern von Binär-Darstellung mit 0b-Präfix
                int x = 0b0001_0001, y=0b1000_1000, z=0b1111;
                //Ausgabe der Integer in Hexadezimal: intVariable.ToString("X")}
                Console.WriteLine($"x: {x.ToString("X")}\ty: {y.ToString("X")}\tz: {z.ToString("X")}\t");

                int result = x & y & z;
                Console.WriteLine($"x & y & z = {result.ToString("X")}");
                /*Ergebnis: 
                    0001_0001 <- x
                    1000_1000 <- y
                    0000_1111 <- z
                  & _________
                    0000_0000 <- x & y & z
                */

                result = (x | y) & z;
                Console.WriteLine($"(x | y) & z = {result.ToString("X")}");
                /*Ergebnis: 
                    0001_0001 <- x
                    1000_1000 <- y
                  | _________
                    1001_1001 <- x | y
                    0000_1111 <- z
                  & _________
                    0000_1001 <- (x | y) & z
                */

                result = ~(x ^ y);
                Console.WriteLine($"~(x ^ y) = {result.ToString("X")}");
                /*Ergebnis:
                    Das ganze wird in einem int gespeichert -> 32 Bit. Die 0en in den ersten Stellen werden bei der Negation gekippt.
                    [0...0]0001_0001 <- x
                    [0...0]1000_1000 <- y
                  ^ ________________
                    [0...0]1001_1001 <- x ^ y
                  ~ ________________
                    [1...1]0110_0110 <- ~(x ^ y)
                */

                result = ~(x ^ y) & byte.MaxValue;
                Console.WriteLine($"~(x ^ y) & byte.MaxValue = {result.ToString("X")}");
                /*Ergebnis:
                    Das ganze wird in einem int gespeichert -> 32 Bit. Die 0en in den ersten Stellen werden bei der Negation gekippt, 
                        aber das Ergebnis wird danach mit dem Wert von byte.MaxValue (8 Bit) 'verunded' (nach der impliziten konvertierung zu 32 Bit int)
                    [0...0]0001_0001 <- x
                    [0...0]1000_1000 <- y
                  ^ ________________
                    [0...0]1001_1001 <- x ^ y
                  ~ ________________
                    [1...1]0110_0110 <- ~(x ^ y)
                  ([0...0])1111_1111 <- (int)byte.MaxValue
                  & ________________
                    [0...0]0110_0110 <- ~(x ^ y) & byte.MaxValue
                */

                result = x << 3;
                Console.WriteLine($"x << 3 = {result.ToString("X")}");
            }
        }
    }
}

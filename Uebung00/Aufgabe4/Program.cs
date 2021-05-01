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

                double d = a / b;
                //double d = a / (double)b; //-> löst das 'Problem'
                Console.WriteLine($"d = a / b = {d}");

                double f = a * b / (c - y) - a / b;
                //double f = a * b / (c - y) - a / (double)b;
                Console.WriteLine($"f = a * b / (c - y) - a / b = {f}");

                //Wenn Math.Sqrt einen negativen Input bekommt (wie hier), gibt es double.NaN zurück
                f = (-b * Math.Sqrt(b * b - 4 * a * c) / 2 * a);
                Console.WriteLine($"f = (-b * sqrt(b * b - 4 * a * c) / 2 * a) = {f}");

                double A = Math.PI * r * r;
                Console.WriteLine($"A = Math.PI * r * r = {A}");
            }

            
            Console.WriteLine("\n\n4b:\n");
            {
                double x, y, x1, x2, y1, y2;

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
                bool liegtDazwischen = (x <= x1 && x >= x2) || (x <= x2 && x >= x1);
                Console.WriteLine("Wert {0} liegt in dem Bereich [{1}...{2}]: {3}", x, x1, x2, liegtDazwischen);

                //2.
                bool inRechteck = ((x <= x1 && x >= x2) || (x <= x2 && x >= x1)) && 
                    ((y <= y1 && y >= y2) || (y <= y2 && y >= y1));
                Console.WriteLine("Wert liegt in dem Rechteck: {0}", inRechteck);

                //3.
                bool istGleich = (x1 == x2) && (y1 == y2);
                Console.WriteLine("Punkt 1 hat die gleichen Koordinaten wie Punkt 2: {0}", istGleich);

                //4.
                bool oder = (x <= x1 && x >= x2) || (x <= x2 && x >= x1) || 
                    ((y <= y1 && y >= y2) || (y <= y2 && y >= y1));
                Console.WriteLine("x1 <= x <= x2 oder y1 <= y <= y2: {0}", oder);
            }
            
            Console.WriteLine("\n\n4c:\n");
            {
                int x = 0b0001_0001, y=0b1000_1000, z=0b1111;
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

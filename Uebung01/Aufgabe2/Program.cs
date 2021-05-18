using System;

namespace Aufgabe2
{
    class Program
    {
        static void Main2_1()
        {
            Console.WriteLine("Jahr eingeben:");
            int jahr;
            if(!int.TryParse(Console.ReadLine(), out jahr))
            {
                Console.WriteLine("Kein gültiges Jahr!");
                return;
            }
            
            bool vierTeilbar = jahr % 4 == 0;
            if(vierTeilbar)
            {
                bool saekularJahr = jahr % 100 == 0;
                if(saekularJahr)
                {
                    if(jahr % 400 == 0)
                        Console.WriteLine($"{jahr} ist ein Schaltjahr");
                    else
                        Console.WriteLine($"{jahr} ist kein Schaltjahr");
                }
                else
                    Console.WriteLine($"{jahr} ist ein Schaltjahr");
            }
            else
                Console.WriteLine($"{jahr} ist kein Schaltjahr");
        }

        static void Main2_2()
        {
            Console.WriteLine("Jahr eingeben:");
            string consoleInput;
            int jahr;

            //do-while Schleife wird mindestens einmal ausgeführt und testet unten in dem While-Statement, ob 
            //die Schleife weiterhin wiederholt wird
            do
            {
                consoleInput = Console.ReadLine();
                if(consoleInput == "")
                {
                    //springt zum nächsten loop -> testet, ob die schleife wiederholt wird
                    continue;
                    //Alternativ könnte man auch 'break;' verwenden, das würde die Schleife direkt verlassen
                }

                if(!int.TryParse(consoleInput, out jahr))
                {
                    Console.WriteLine("Kein gültiges Jahr!");
                    return;
                }
                
                bool vierTeilbar = jahr % 4 == 0;
                if(vierTeilbar)
                {
                    bool saekularJahr = jahr % 100 == 0;
                    if(saekularJahr)
                    {
                        if(jahr % 400 == 0)
                            Console.WriteLine($"{jahr} ist ein Schaltjahr");
                        else
                            Console.WriteLine($"{jahr} ist kein Schaltjahr");
                    }
                    else
                        Console.WriteLine($"{jahr} ist ein Schaltjahr");
                }
                else
                    Console.WriteLine($"{jahr} ist kein Schaltjahr");
            } while (consoleInput != "");

            
        }

        static void Main(string[] args)
        {
            Main2_2();
        }
    }
}

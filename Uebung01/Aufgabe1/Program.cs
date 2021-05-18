using System;

namespace Aufgabe1
{
    class Program
    {
        static void Main1_1()
        {
            double centProMin = 9.9;
            double gebuehr = 399;
            double freiMinuten = 100;

            double anzahlMinuten = 101;
            double kosten = gebuehr;

            if(anzahlMinuten > freiMinuten)
            {
                kosten += centProMin * (anzahlMinuten - freiMinuten);
            }

            //oder mit ternären Operator:
            //kosten += anzahlMinuten > freiMinuten ? centProMin * (anzahlMinuten - freiMinuten) : 0;

            Console.WriteLine($"Kosten: {(kosten / 100.0):0.00} Euro");
        }

        static void Main1_2()
        {
            double centProMin = 9.9;
            double gebuehr = 399;
            double freiMinuten = 100;
            double anzahlMinuten;

            Console.WriteLine("Anzahl der Minuten angeben:");

            //Wenn der Code im if-Statement nur eine Zeile lang ist, können die geschweiften Klammern darum weggelassen werden
            if(!Double.TryParse(Console.ReadLine(), out anzahlMinuten))
            {
                Console.WriteLine("not a valid number");
                return;
            }
                            
            double kosten = gebuehr;

            if(anzahlMinuten > freiMinuten)
            {
                kosten += centProMin * (anzahlMinuten - freiMinuten);
            }

            //oder mit ternären Operator:
            //kosten += anzahlMinuten > freiMinuten ? centProMin * (anzahlMinuten - freiMinuten) : 0;

            Console.WriteLine($"Kosten: {(kosten / 100.0):0.00} Euro");
        }

        static void Main1_3()
        {
            double centProMin = 9.9;
            double gebuehr = 399;
            double tarifSGebuehr = 600;
            double tarifMGebuehr = 1100;
            double tarifLGebuehr = 2000;

            double freiMinuten = 100;
            double anzahlMinuten;
            char tarif;

            Console.WriteLine("Anzahl der Minuten angeben:");

            //Wenn der Code im if-Statement nur eine Zeile lang ist, können die geschweiften Klammern darum weggelassen werden
            if(!Double.TryParse(Console.ReadLine(), out anzahlMinuten))
            {
                Console.WriteLine("not a valid number");
                return;
            }

            Console.WriteLine("Tarif [S | M | L] angeben:");
            tarif = Console.ReadKey().KeyChar;
            if(tarif != 'S' && tarif != 'M' && tarif != 'L')
            {
                Console.WriteLine("not a valid option");
                return;
            }
            
            double kosten = gebuehr;
            kosten += anzahlMinuten > freiMinuten ? centProMin * (anzahlMinuten - freiMinuten) : 0;

            switch (tarif)
            {
                case 'S':
                    kosten += tarifSGebuehr;
                    break;
                case 'M':
                    kosten += tarifMGebuehr;
                    break;
                case 'L':
                    kosten += tarifLGebuehr;
                    break;
            }

            Console.WriteLine($"\nKosten: {(kosten / 100.0):0.00} Euro");
        }

        static void Main(string[] args)
        {
            Main1_3();
        }
    }
}

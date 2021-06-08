using System;

namespace Aufgabe4
{
    class Program
    {
        static void Main(string[] args)
        {
            Smartphone sp = new Smartphone();
            Console.WriteLine(sp);
            sp.pinSetzen();
            Console.WriteLine(sp);
            sp.pinSetzen();
            sp.lockSmartphone();
            Console.WriteLine(sp);
        }
    }
}

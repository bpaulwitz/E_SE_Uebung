using System;

namespace Aufgabe3
{
    class Program
    {
        static void Main(string[] args)
        {
            float fahrenheit, celsius;
            //ORIGINAL: celsius = 0,
            celsius = 0.0f;
            //ORIGINAL: fahrenheit = 9 / 5 * celsius + 32;
            fahrenheit = 9.0f / 5.0f * celsius + 32;
            //ORIGINAL: Console.WriteLine("{0} Celsius entspricht {0} Fahrenheit", celsius, fahrenheit);
            Console.WriteLine("{0} Celsius entspricht {1} Fahrenheit", celsius, fahrenheit);
            Console.WriteLine("Celsius: ");
            //ORIGINAL: celsius = Convert.ToFloat(Console.ReadLine());
            celsius = (float)Convert.ToDouble(Console.ReadLine());
            //ORIGINAL: fahrenheit = 9 / 5 * celsius + 32;
            fahrenheit = 9.0f / 5.0f * celsius + 32;
            //ORIGINAL: Console.WriteLine("Fahrenheit:", Fahrenheit);
            Console.WriteLine("Fahrenheit: {0}", fahrenheit);
        }
    }
}

using System;

namespace Aufgabe3
{
    /* Struct:
     * - Implizit versiegelt (es kann kein Struct und keine Klasse von einem Struct erben)
     * - Value Type:
     *      - Das bedeutet, wenn man ein Objekt von einem Struct erstellt, liegt es zur Verwendung inline vor
     *      - Value Type ist der Gegensatz zu Reference Type, zu dem in C# Klassen gehören. 
     *          Objekte eines Reference Types liegen immer als Referenz (~ Pointer) vor.
    */
    struct Size
    {
        private int w, h;

        public int width
        {
            get => this.w;
            set
            {
                if(value < 0)
                    throw new ArgumentException("ERROR at Aufgabe3.Size.width: width can't be negative!");
                else
                    this.w = value;
            }
        }

        public int height
        {
            get => this.h;
            set
            {
                if(value < 0)
                    throw new ArgumentException("ERROR at Aufgabe3.Size.height: height can't be negative!");
                else
                    this.h = value;
            }
        }

        public Size(int width, int height)
        {
            /*
            Zuerst müssen wir w und h mit einem Wert initialisieren, weil wir mit der Property darauf zugreifen.

            Hier verwenden wir direkt die Properties, sodass ggf. auch die Exception geworfen wird, 
            wenn wir das Struct mit falschen Werten anlegen und nicht nur, wenn wir die Properties benutzen.

            Alternativ könnte man auch noch mal testen, ob die Parameter im Konstruktor negativ sind und die
            gleiche Exception werfen, aber in der Regel versucht man so gut es geht, auf vorhandene Funktionalität
            aufzubauen und nicht mehrmals denselben Code zu schreiben.
            */
            w = 0; 
            h = 0;

            this.width = width;
            this.height = height;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Size size;
            
            //Testen der height für [-2, 2]
            Console.WriteLine("Testing height:");
            for (int i = -2; i < 3; i++)
            {
                try
                {
                    size = new Size(10, i);
                    Console.WriteLine($"Created Size({10},{i}).");
                }
                catch(ArgumentException argExc)
                {
                    Console.WriteLine($"i: {i} - " + argExc.Message);
                }
            }

            //Testen der width für [-2, 2]
            Console.WriteLine("\nTesting width:");
            for (int j = -2; j < 3; j++)
            {
                try
                {
                    size = new Size(j, 10);
                    Console.WriteLine($"Created Size({j},{10}).");
                }
                catch(ArgumentException argExc)
                {
                    Console.WriteLine($"j: {j} - " + argExc.Message);
                }
            }
            
        }
    }
}

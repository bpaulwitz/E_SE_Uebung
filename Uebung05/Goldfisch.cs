namespace Uebung05
{
    public class Goldfisch : Fish, IStrokeable
    {
        public override void Swim()
        {
            System.Console.WriteLine("Schwimmt im Kreis.");
        }

        public void Stroke()
        {
            if(besitzer == null)
            {
                System.Console.WriteLine("Schwimmt weg.");
            }
            else
            {
                System.Console.WriteLine("Goldfisch wird gestreichelt.");
            }
        }

        public override string ToString()
        {
            return $"Art: Goldfisch\nName: {name}\nBesitzer: {besitzer}";
        }

        public Goldfisch(string _name = "Goldfisch") : base()
        {
            name = _name;
        }

        public Goldfisch(string besitzer, string _name = "Goldfisch") : base(besitzer)
        {
            name = _name;
        }
    }
}
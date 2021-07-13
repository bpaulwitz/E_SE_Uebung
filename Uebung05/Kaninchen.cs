namespace Uebung05
{
    public class Kaninchen : Mammal
    {
        public override void Attend()
        {
            System.Console.WriteLine("Stall ausmisten.");
        }

        public override void Move()
        {
            System.Console.WriteLine("hoppelt umher.");
        }

        public override void Stroke()
        {
            System.Console.WriteLine("Kaninchen wird gestreichelt.");
        }

        public override string ToString()
        {
            return $"Art: Kaninchen\nName: {name}\nBesitzer: {besitzer}";
        }

        public Kaninchen(string _name = "Kaninchen") : base()
        {
            name = _name;
        }

        public Kaninchen(string besitzer, string _name = "Kaninchen") : base(besitzer)
        {
            name = _name;
        }
    }
}
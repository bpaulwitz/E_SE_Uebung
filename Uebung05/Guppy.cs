namespace Uebung05
{
    
    public class Guppy : Fish
    {
        public override void Swim()
        {
            System.Console.WriteLine("Schwimmt vor und zurück.");
        }

        public override string ToString()
        {
            return $"Art: Guppy\nName: {name}\nBesitzer: {besitzer}";
        }

        public Guppy(string _name = "Guppy") : base()
        {
            name = _name;
        }

        public Guppy(string besitzer, string _name = "Guppy") : base(besitzer)
        {
            name = _name;
        }
    }
}
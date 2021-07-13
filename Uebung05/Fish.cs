namespace Uebung05
{
    public abstract class Fish : Pet
    {
        public abstract void Swim();

        public override void Attend()
        {
            System.Console.WriteLine("Das Wasser wird gewechselt.");
        }

        public Fish() : base()
        {
            name = "Fisch";
        }

        public Fish(string besitzer, string _name = "Fisch") : base(besitzer)
        {
            name = _name;
        }
    }    
}
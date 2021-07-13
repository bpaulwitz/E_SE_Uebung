namespace Uebung05
{
    public abstract class Mammal : Pet, IStrokeable
    {
        public abstract void Move();

        public Mammal() : base()
        {
            name = "Säugetier";
        }

        public Mammal(string besitzer) : base(besitzer)
        {
            name = "Säugetier";
        }

        public abstract void Stroke();
    }
}
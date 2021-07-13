

namespace Uebung05
{
    public abstract class Pet
    {
        public string name
        {
            get;
            set;
        }

        public readonly string besitzer;

        public abstract void Attend();

        public Pet()
        {
            besitzer = null;
            name = "Haustier";
        }

        public Pet(string _besitzer)
        {
            besitzer = _besitzer;
            name = "Haustier";
        }
    }
}
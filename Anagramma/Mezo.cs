namespace Anagramma
{
    public abstract class Mezo
    {
        protected char ertek;
        protected int szint;

        public char Ertek { get => ertek; }
        public int Szint { get => szint; }

        public Mezo(char ertek)
        {
            this.ertek = ertek;
            szint = 0;
        }

        public abstract override string ToString();
    }
}

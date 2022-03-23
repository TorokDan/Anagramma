namespace Anagramma
{
    public class Gyerek : Mezo
    {
        protected Mezo anya;
        protected string szo;
        public Gyerek(Mezo anya, char ertek) : base(ertek)
        {
            this.anya = anya;
            this.szint = anya.Szint + 1;
            this.szo = anya.ToString() + ertek; 
        }

        public override string ToString()
        {
            return szo;
        }
    }
}

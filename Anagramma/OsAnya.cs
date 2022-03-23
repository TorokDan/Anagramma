namespace Anagramma
{
    public class OsAnya : Mezo
    {
        public OsAnya(char ertek) : base(ertek)
        {
            szint++;
        }

        public override string ToString()
        {
            return ertek.ToString();
        }
    }
}

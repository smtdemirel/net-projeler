namespace AbstractClass
{
    public abstract class Otomobil
    {
        public int KacTekeriVar()
        {
            return 4;
        }
        public abstract Marka MarkasiNedir();
        public virtual Renk RengiNedir()
        {
            return Renk.Beyaz;
        }
    }
}
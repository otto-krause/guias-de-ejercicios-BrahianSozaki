namespace E3
{
    public class LectoraDeCD : Componentes
    {
        int frecuencias;
        int precio;

        public LectoraDeCD(int frecuencias, int precio)
        {
            this.frecuencias = frecuencias;
            this.precio = precio;
        }
        public bool EsCompatible(MotherBoard motherboard)
        {
            return motherboard.Frecuencias >= frecuencias;
        }

        public int Precio()
        {
            return this.precio;
        }
    }
}
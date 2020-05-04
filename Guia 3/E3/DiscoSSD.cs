namespace E3
{
    public class DiscoSSD : Componentes
    {
        int frecuencias;
        int precio;

        public DiscoSSD(int frecuencias, int precio)
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
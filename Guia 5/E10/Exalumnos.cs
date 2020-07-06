namespace E10
{
    public class Exalumnos
    {
        int cantidadDeIdiomasQueHabla;
        public int CantidadDeIdiomasQueHabla { get => cantidadDeIdiomasQueHabla; }
        int cuantoGana;
        public int CuantoGana { get => cuantoGana; }
        int cantidadDePaisesVisitados;
        public int CantidadDePaisesVisitados { get => cantidadDePaisesVisitados; }

        public Exalumnos(int cantidadDeIdiomasQueHabla, int cuantoGana, int cantidadDePaisesVisitados)
        {
            this.cantidadDeIdiomasQueHabla = cantidadDeIdiomasQueHabla;
            this.cuantoGana = cuantoGana;
            this.cantidadDePaisesVisitados = cantidadDePaisesVisitados;
        }

        
    }
}
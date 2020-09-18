namespace Ejercicio
{
    public class Extraterrestres : Villano
    {
        private int cantidadDePersonasAbducidas;
        private int cantidadDeExtremidades;
        public Extraterrestres(int cantidadDePersonasAbducidas, int cantidadDeExtremidades)
        {
            this.cantidadDePersonasAbducidas = cantidadDePersonasAbducidas;
            this.cantidadDeExtremidades = cantidadDeExtremidades;
        }
        public override int poder()
        {
            return cantidadDePersonasAbducidas / cantidadDeExtremidades;
        }

        public override void realizarMaldad() => cantidadDePersonasAbducidas++;
    }
}
namespace Ejercicio
{
    public class Habitante
    {
        private int cantidadDeDinero;
        public int CantidadDeDinero { get => cantidadDeDinero; }
        public Habitante(int cantidadDeDinero)
        {
            this.cantidadDeDinero = cantidadDeDinero;
        }
        public bool claseAlta(){
            return cantidadDeDinero > 5000000;
        }
        public bool claseMedia(){
            return cantidadDeDinero > 1000000 && cantidadDeDinero < 5000000;
        }
        public bool claseBaja(){
            return cantidadDeDinero < 1000000;
        }
        public void leRoban(){
            cantidadDeDinero -= 1000000;
        }
        public void recibeDeRobinHood(int montoRecibido) => cantidadDeDinero += montoRecibido;
    }
}
namespace Ejercicio
{
    public class Psicopatas : Villano
    {
        private int cantidadDeAsesinatos;
        private int inteligencia;
        public Psicopatas(int cantidadDeAsesinatos, int inteligencia)
        {
            this.cantidadDeAsesinatos = cantidadDeAsesinatos;
            this.inteligencia = inteligencia;
        }
        public override int poder(){
            return inteligencia * cantidadDeAsesinatos;
        }
        public override void realizarMaldad() => cantidadDeAsesinatos += 5;

    }
}
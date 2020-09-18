namespace Ejercicio
{
    public class Tecnologias
    {
        private string nombre;
        public string Nombre { get => nombre; }
        private int potencia;
        private int cantidadDeUsos;
        public Tecnologias(string nombre, int potencia, int cantidadDeUsos)
        {
            this.nombre = nombre;
            this.potencia = potencia;
            this.cantidadDeUsos = cantidadDeUsos;
        }
        public int poder(){
            return potencia / cantidadDeUsos;
        }
    }
}
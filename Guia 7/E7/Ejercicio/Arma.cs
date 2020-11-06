namespace Ejercicio
{
    public class Arma
    {
        string nombre;
        public string Nombre { get => nombre; }
        int potencia;
        public int Potencia { get => potencia; }
        public Arma(string nombre, int potencia)
        {
            this.nombre = nombre;
            this.potencia = potencia;
        }
    }
}
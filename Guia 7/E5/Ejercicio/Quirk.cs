using System.Linq;
namespace Ejercicio
{
    public class Quirk
    {
        int tiempoDeUso;
        public int TiempoDeUso { get => tiempoDeUso; }
        bool tieneConsecuencias;
        string nombre;

        public int Nombre { get => nombre.Count(); }
        public Quirk(int tiempoDeUso, bool tieneConsecuencias, string nombre)
        {
            this.tiempoDeUso = tiempoDeUso;
            this.tieneConsecuencias = tieneConsecuencias;
            this.nombre = nombre;
        }
    }
}
using System.Linq;
namespace Ejercicio
{
    public class Quirk
    {
        int tiempoDeUso;
        bool tieneConsecuencias;
        string nombre;
        public string Nombre { get => nombre; }

        public Quirk(int tiempoDeUso, bool tieneConsecuencias, string nombre)
        {
            this.tiempoDeUso = tiempoDeUso;
            this.tieneConsecuencias = tieneConsecuencias;
            this.nombre = nombre;
        }

        public int poder(){
            return tiempoDeUso * nombre.Count();
        }
        public bool esPeligroso(){
            return (poder() > 1000 && tiempoDeUso > 60) || nombre == "OneForAll";
        }

    }
}
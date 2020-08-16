using System.Collections.Generic;
using System.Linq;
namespace Ejercicio
{
    public class Receta
    {
        private List<int> ingredientes;
        public int Ingredientes(){
            return ingredientes.Count();
        }
        private int pasos;
        public int Pasos { get => pasos; }

        public Receta(List<int> ingredientes, int pasos)
        {
            this.ingredientes = ingredientes;
            this.pasos = pasos;
        }

        public bool esDeGordo(){
            return ingredientes.Sum(ingrediente => ingrediente) > 2000;
        }
        public bool esRapida(){
            return ingredientes.Count() / pasos > 1;
        }
    }
}
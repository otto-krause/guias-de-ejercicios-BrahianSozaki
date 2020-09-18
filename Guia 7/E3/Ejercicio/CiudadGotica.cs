using System.Collections.Generic;
using System.Linq;
namespace Ejercicio
{
    public class CiudadGotica
    {
        private List<Habitante> habitantes;
        public CiudadGotica(List<Habitante> habitantes)
        {
            this.habitantes = habitantes;
        }
        public bool esLujosa(){
            int cantidadDeHabitantes = habitantes.Count();
            List<Habitante> habitantesRicos = habitantes.Where(i => i.claseAlta()).ToList();
            return habitantesRicos.Count() > cantidadDeHabitantes / 2;
        }
        public List<Habitante> sonLosMasTop(){
            List<Habitante> losMasTop = habitantes.OrderByDescending(i => i.CantidadDeDinero).Take(10).ToList();
            return losMasTop;
        }
    }
}
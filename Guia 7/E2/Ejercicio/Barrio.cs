using System.Collections.Generic;
using System.Linq;
namespace Ejercicio
{
    public class Barrio
    {
        
        List<Niño> niñosDelBarrio;
        public Barrio(List<Niño> niñosDelBarrio){
            this.niñosDelBarrio = niñosDelBarrio;
        }
        public List<Niño> losDeMasCaramelos(){
            List<Niño> niñosConMasCaramelos = new List<Niño>();
            niñosDelBarrio = niñosDelBarrio.OrderByDescending(i => i.cantidadDeCaramelos()).ToList();
            niñosConMasCaramelos = niñosDelBarrio.Take(3).ToList();
            return niñosConMasCaramelos;
        }
        
    }
}
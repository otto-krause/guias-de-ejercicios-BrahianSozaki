using System.Collections.Generic;
using System.Linq;

namespace Ejercicio
{
    public class Pandilla
    {
        List<Villano> villanos;
        public Pandilla(List<Villano> villanos)
        {
            this.villanos = villanos;
        }

        public int PoderTotal(){
            return villanos.Sum(i => i.poder());
        }

    }
}
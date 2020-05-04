using System.Collections.Generic;
namespace E3
{
    public class PC
    {
        MotherBoard mother;
        List<Componentes> componentes = new List<Componentes>();

        public PC(MotherBoard mother, List<Componentes> componentes)
        {
            this.mother = mother;
            this.componentes = componentes;
        }

        public int PrecioTotal(){
            int precioTotal = 0;
            foreach (var i in componentes){
                precioTotal += i.Precio();
            }
            return precioTotal;
        }
        public bool SePuedeArmar(){
            foreach (var i in componentes){
                if (!i.EsCompatible(mother)) return false;
            }
            return true;
        }
    }
}
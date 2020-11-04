using System.Collections.Generic;
using System.Linq;
namespace Ejercicio
{
    public class Persona
    {
        Quirk quirk;
        public Quirk Quirk { get => quirk; }
        List<Quirk> quirks;
        public List<Quirk> Quirks { get => quirks; }
        public Persona(Quirk quirk)
        {
            this.quirk = quirk;
            this.quirks = new List<Quirk>{quirk};
        }

        public int poder(){
            return quirk.poder();
        }
        public bool esPeligroso(){
            return quirk.esPeligroso();
        }
        public void añadirQuirk(Quirk quirk){
            quirks.Add(quirk);
        }
        public void borrarQuirk(string nombreDelQuirk){
            List<Quirk> quirksSinElEliminado = quirks.Except(quirks.Where(i => i.Nombre == nombreDelQuirk)).ToList();
            quirks = quirksSinElEliminado;
            
        }

    }
}
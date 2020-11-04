using System.Linq;
namespace Ejercicio
{
    public class OneForAll
    {
        Heroe portador;
        int poderDelOfa;
        public int PoderDelOfa { get => poderDelOfa; }
        public OneForAll(Heroe portador)
        {
            this.portador = portador;
            this.poderDelOfa = portador.poder();
        }        

        public void cambiarPortador(Heroe nuevoPortador){
            string nombreDelQuirk = "";
            var quirk = portador.Quirks.Where(i => i.Nombre == "OneForAll").ToList();
            quirk.ForEach(i => nombreDelQuirk = i.Nombre);

            int porcentajeExtra = 15 * portador.poder() / 100;
            portador.borrarQuirk(nombreDelQuirk);
            portador = nuevoPortador;
            poderDelOfa += porcentajeExtra;
            Quirk OFA = new Quirk(180, true, "OneForAll");
            portador.añadirQuirk(OFA);
            
        }

    }
}
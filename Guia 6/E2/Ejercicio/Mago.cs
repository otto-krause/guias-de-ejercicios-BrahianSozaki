using System.Collections.Generic;
using System.Linq;
namespace Ejercicio
{
    public class Mago
    {
        List<Receta> recetas;
        Varita varita;

        public Mago(List<Receta> recetas)
        {
            this.recetas = recetas;
        }

        public bool esUnLento(){
            List<Receta> recetasRapidas = recetas.Where(receta => receta.esRapida()).ToList();
            Receta recetaRapida = recetasRapidas.First();
            varita = new Carpe(1, recetaRapida);
            return varita.tiempoParaLaReceta() > 30;
        }
        public bool noSeCuida(){
            List<Receta> recetasDeGordo = recetas.Where(receta => receta.esDeGordo()).ToList();
            return recetas.Count() / 2 <= recetasDeGordo.Count();
        }
    }
}
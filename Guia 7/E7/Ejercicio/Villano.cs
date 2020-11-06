using System.Collections.Generic;
using System.Linq;

namespace Ejercicio
{
    public class Villano
    {
        List<Minion> minions;
        List<Minion> minionsAplicados;
        Ciudad ciudad;
        Minion minionUtil;
        public Villano(List<Minion> minions, Ciudad ciudad)
        {
            this.minions = minions;
            this.ciudad = ciudad;
        }

        public void nuevoMinion(){
            Arma rayoCongelante = new Arma("Rayo Congelante", 10);
            Minion minion = new Minion(rayoCongelante, 5, "Amarillo");
            minions.Add(minion);
        }

        public void otorgarArma (Arma arma){
            minions.ForEach(i => i.obtenerArma(arma));
        }

        public void alimentar (int bananasDadas){
            minions.ForEach(i => i.obtenerBananas(bananasDadas));
        }
        
        public void premiar(){
            switch (minionsAplicados.Count()){
                case 0:
                    throw new System.Exception("No hay minions para la mision");
                default:
                    ciudad.reduccionDeGrados();
                    minionsAplicados.ForEach(i => i.obtenerBananas(10));
                    sumarMaldadesRealizadas();
                    break;
            }
        }
        public void sumarMaldadesRealizadas() => minionsAplicados.ForEach(i => i.sumarCantidadDeMaldadesRealizadas());

        public void congelar(){
            minionsAplicados = minions.Where(i => i.tieneUnaArmaCongelante() == true && i.nivelDeConcentracion() > 500).ToList();
            premiar();
        }

        public void robar(string objeto){
            switch (objeto){
                case "Piramide":
                    minionsAplicados = minions.Where(i => i.nivelDeConcentracion() >= ciudad.AlturaPiramide/2).ToList();
                    premiar();
                    break;
                case "Suero Mutante":
                    minionsAplicados = minions.Where(i => i.CantidadDeBananas >= 100 && i.nivelDeConcentracion() >= 23).ToList();
                    switch(minionsAplicados.Count()){
                        case 0:
                            throw new System.Exception("No hay minions para la mision");
                        default:
                            minionsAplicados.ForEach(i => i.seTransforma());
                            sumarMaldadesRealizadas();
                            break;
                    }
                    break;
                case "La Luna":
                    minionsAplicados = minions.Where(i => i.tieneUnArmaEncogedora()).ToList();
                    switch(minionsAplicados.Count()){
                        case 0:
                            throw new System.Exception("No hay minions para la mision");
                        default:
                            Arma rayoCongelante = new Arma("Rayo congelante", 10);
                            minionsAplicados.ForEach(i => i.obtenerArma(rayoCongelante));
                            sumarMaldadesRealizadas();
                            break;
                    }
                    break;
            }
        }
        public Minion minionMasUtil(){
            List<Minion> minionMasUtil = minions.Where(i => i.CantidadDeMaldadesRealizadas == minions.Max(i => i.CantidadDeMaldadesRealizadas)).ToList();
            foreach(var i in minionMasUtil) minionUtil = i;
            return minionUtil;
        }

        public List<Minion> minionsInutiles(){
            List<Minion> minionInutiles = minions.Where(i => i.CantidadDeMaldadesRealizadas == 0).ToList();
            return minionInutiles;
        }

    }
}
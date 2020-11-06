using System.Collections.Generic;
using System.Linq;

namespace Ejercicio
{
    public class Minion
    {
        List<Arma> armas;
        int cantidadDeBananas;
        public int CantidadDeBananas { get => cantidadDeBananas; }
        string color;
        int cantidadDeMaldadesRealizadas;
        public int CantidadDeMaldadesRealizadas { get => cantidadDeMaldadesRealizadas; }
        public Minion(Arma arma, int cantidadDeBananas, string color)
        {
            this.armas = new List<Arma>();
            this.armas.Add(arma);
            this.cantidadDeBananas = cantidadDeBananas;
            this.color = color;
        }
        public void sumarCantidadDeMaldadesRealizadas() => cantidadDeMaldadesRealizadas++;
        public bool tieneUnaArmaCongelante(){
            bool tieneElArmaCongelante = false;
            armas.ForEach(i => tieneElArmaCongelante = i.Nombre == "Rayo Congelante");
            return tieneElArmaCongelante;
        }

        public bool tieneUnArmaEncogedora(){
            bool tieneElRayoEncogedor = false;
            armas.ForEach(i => tieneElRayoEncogedor = i.Nombre == "Rayo Encogedor");
            return tieneElRayoEncogedor;
        }
        public bool esPeligroso(){
            return (armas.Count() > 2 || color == "Violeta") && color != "Verde";
        }
        public void seTransforma(){
            switch(color){
                case "Amarillo":
                            armas.Clear();
                            color = "Violeta";
                            break;
                case "Violeta":
                            color = "Verde";//En caso de que se refiera sin la existencia del minion verde se borra este case del switch por no tener relevancia
                            break;
                case "Verde": 
                            color = "Amarillo";//En caso de que no se tenga que poder cambiar otra vez a amarillo se borraria esta parte del case
                            cantidadDeBananas = 1;
                            break;
            }
            cantidadDeBananas--;
        }
        public void obtenerArma(Arma arma) => armas.Add(arma);

        public void obtenerBananas(int bananasObtenidas) => cantidadDeBananas += bananasObtenidas;

        public int nivelDeConcentracion(){
            switch(color){
                case "Amarillo":
                            return armas.Max(i => i.Potencia) + cantidadDeBananas;
                case "Violeta":
                            return cantidadDeBananas;
                case "Verde":
                            return 5;
                default:
                    return 0;
            }
        }

    }
}
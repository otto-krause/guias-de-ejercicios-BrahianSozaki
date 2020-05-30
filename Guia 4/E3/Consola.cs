using System.Collections.Generic;
namespace E3
{
    public abstract class Consola
    {
        protected List<Juego> juegos;
        protected int puntaje;
        public Consola(int puntaje)
        {
            juegos = new List<Juego>();
            this.puntaje = puntaje;
        }

        public abstract void jugar(int horas);

        public abstract void agregarJuego(Juego juego);

        public virtual int revisarPuntaje()
        {
            return puntaje;
        }

        public string elMasNuevo(){
            int mayor = 0;
            string texto = "";
            foreach (var i in juegos){
                if (mayor < i.AñoDeLanzamiento){
                    mayor = i.AñoDeLanzamiento;
                    texto = "Nombre: " + i.Nombre + "\nAño de lanzamiento: " + i.AñoDeLanzamiento + "\nNombre de la Consola en la que se juega: " + i.NombreDeLaConsola;
                }
            }
            return texto;
        }

        public string elMasViejo(){
            int menor = 2021;
            string texto = "";
            foreach (var i in juegos){
                if (menor > i.AñoDeLanzamiento){
                    menor = i.AñoDeLanzamiento;
                    texto = "Nombre: " + i.Nombre + "\nAño de lanzamiento: " + i.AñoDeLanzamiento + "\nNombre de la Consola en la que se juega: " + i.NombreDeLaConsola;
                }
            }
            return texto;
        }
    }
}
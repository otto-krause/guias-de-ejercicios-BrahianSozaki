using System.Collections.Generic;
namespace E3
{
    public class Jugador
    {
        string nombre;
        List <Consola> consolas;
        public List<Consola> Consolas { get => consolas; }

        public Jugador(string nombre)
        {
            this.nombre = nombre;
            this.consolas = new List<Consola>();
            consolas.Add(new CajaX(0));
            consolas.Add(new PC(0));
            consolas.Add(new Ponystation4(0));
            consolas.Add(new Ponystation4_pro_SaladaEdition(0));
        }

        public void adquirirJuego(Juego juego){
            foreach (var i in consolas){
                if ( juego.NombreDeLaConsola == i.ToString() ) i.agregarJuego(juego);
            }
        }

        public string laMasUsada(){
            int mayor = 0;
            string texto = "";
            foreach (var i in consolas){
                if (mayor < i.revisarPuntaje()){
                    mayor = i.revisarPuntaje();
                    texto = "Nombre de la consola mas usada: " + i.ToString();
                }
            }
            return texto;
        }

        public void Jugar(string nombreDeLaConsola, int horas){
            foreach (var i in consolas){
                if ( nombreDeLaConsola == i.ToString() ) i.jugar(horas);
            }
        }
    }
}
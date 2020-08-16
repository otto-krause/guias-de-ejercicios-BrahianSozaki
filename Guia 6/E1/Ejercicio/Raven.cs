using System.Collections.Generic;
using System.Linq;
namespace Ejercicio
{
    public class Raven : Titan
    {
        List<string> pensamientos;
        int cantidadDePorciones;
        int felicidad;
        public Raven(int tristeza) : base(tristeza)
        {
            this.pensamientos = new List<string>();
            pensamientos.Add("Extraño a mi Papi");
            pensamientos.Add("Me quedé sin MANTECA");
            pensamientos.Add("Perdí a Pipo");
            pensamientos.Add("Voy a comprar pilas para Robocop");
            pensamientos.Add("¿Donde esta Pipo?");
            cantidadDePorciones = 4;
            felicidad = tristeza;
        }
        public override void comerPizza() => felicidad += 2 * cantidadDePorciones;
        public override void llorarPorRobocop() => pensamientos.RemoveAt(0);
        public override bool estaTriste(){
            int count = 0;
            foreach (var i in pensamientos){
                if(i.Contains("Papi") || i.Contains("perrito") || i.Contains("Robocop") ||
                   i.Contains("Pipo") || i.Contains("MANTECA")) count++;
            }
            return count >= 5 && felicidad >= 10;
        }
        public override int poder(){
            int count = 0;
            foreach (var i in pensamientos){
                if(i.Contains("Papi") || i.Contains("perrito") || i.Contains("Robocop") ||
                   i.Contains("Pipo") || i.Contains("MANTECA")) count++;
            }
            return count;
        }

    }
}
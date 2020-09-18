using System;
using System.Collections.Generic;
using System.Linq;
namespace Ejercicio
{
    public class Batman
    {
        private List<Tecnologias> batiriñonera;
        private int vida;
        private int estres;

        public Batman(List<Tecnologias> batiriñonera)
        {
            this.batiriñonera = batiriñonera;
            this.vida = 800;
            this.estres = 8;
        }
        public int poder(){
            int poderTotalDeLasHerramientas = 0;
            batiriñonera.ForEach(i => poderTotalDeLasHerramientas += i.poder());
            return vida + poderTotalDeLasHerramientas;
        }
        public void Tecnologias(Tecnologias tecnologia){
            batiriñonera.Add(tecnologia);
        }        
        public void combatirElCrimen(List<Villano> villanos){
            int fuerzaTotal = 0;
            estres += villanos.Count();
            villanos.ForEach(i => fuerzaTotal += i.poder());
            if (poder() < fuerzaTotal){
                vida -= 200;
            }
        }
        public void llorarASusPadres(){
            estres -= 10;

            batiriñonera.RemoveAt(1);
        }
        public bool estaEstresado(){
            return estres > 15;
        }
        public bool estaALaModa(){
            return batiriñonera.All(n => n.Nombre.StartsWith("Bati"));
        }
        public void bailarBatiTwist() => vida += 100;
    }
}
using System.Collections.Generic;
namespace E2
{
    public class Empresa
    {

        List<Monstruos> amistosos = new List<Monstruos>();
        List<Monstruos> peligrosos = new List<Monstruos>();
        List<Monstruos> respetables = new List<Monstruos>();
        public Empresa()
        {
            amistosos.Add(new Amistosos(10));
            amistosos.Add(new Amistosos(80));

            peligrosos.Add(new Amistosos(16));
            peligrosos.Add(new Amistosos(75));
        }

        public void NocheDeSustos(){
            foreach (var i in peligrosos) i.asustar();
            foreach (var i in amistosos) i.asustar();
        }

        public void NocheDeRisas(){
            foreach (var i in peligrosos) i.reir();
            foreach (var i in amistosos) i.reir();
        }

        public void Respetables(){
            foreach(var i in amistosos){
                if (i.Respeto > 70) respetables.Add(i); 
            }
            foreach(var i in peligrosos){
                if (i.Respeto > 70) respetables.Add(i);
            }
        }

        public int energia (){
            int suma = 0;
            foreach (var i in amistosos){
                suma += i.Respeto;
            }
            foreach (var i in peligrosos){
                suma += i.Respeto;
            }
            return suma;
        }

    }
}
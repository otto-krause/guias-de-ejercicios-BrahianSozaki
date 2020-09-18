using System.Collections.Generic;
using System.Linq;
namespace Ejercicio
{
    public class Ladrones : Villano
    {
        private string tipo;
        private int cantidadDeMaldades;
        List<Habitante> habitantes;
        public Ladrones(string tipo, int cantidadDeMaldades, List<Habitante> habitantes)
        {
            this.tipo = tipo;
            this.cantidadDeMaldades = cantidadDeMaldades;
        }
        public override int poder(){
            return cantidadDeMaldades;
        }
        public override void realizarMaldad(){
            switch (tipo){
                case "GuanteBlanco":

                    List<Habitante> habitantesClaseAlta = habitantes.Where(i => i.claseAlta()).ToList();
                    habitantesClaseAlta.ForEach(i => i.leRoban());

                    cantidadDeMaldades += habitantesClaseAlta.Count();
                    break;

                case "GuanteMarron":

                    List<Habitante> habitantesClaseMedia = habitantes.Where(i => i.claseMedia()).ToList();
                    habitantesClaseMedia.ForEach(i => i.leRoban());

                    cantidadDeMaldades += habitantesClaseMedia.Count();
                    break;
                    
                case "RobinHood":

                    List<Habitante> habitantesRicos = habitantes.Where(i => i.claseMedia()).Where(i => i.claseAlta()).ToList();
                    habitantesRicos.ForEach(i => i.leRoban());
                    int monto = habitantesRicos.Count() * 1000000;

                    List<Habitante> habitantesPobres = habitantes.Where(i => i.claseBaja()).ToList();
                    habitantes.ForEach(i => i.recibeDeRobinHood(monto / habitantesPobres.Count()));

                    cantidadDeMaldades += habitantesRicos.Count();
                    break;                
            }
            
        }
    }
}
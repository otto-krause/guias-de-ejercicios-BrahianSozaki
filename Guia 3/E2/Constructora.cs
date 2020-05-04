using System.Collections.Generic;
namespace E2
{
    public class Constructora
    {
        int presupuesto;
        int horasDeTrabajoParaLaRealizacion;
        List<Contratistas> contratistas = new List<Contratistas>();

        public Constructora(int presupuesto, int horasDeTrabajoParaLaRealizacion, List<Contratistas> contratistas)
        {
            this.presupuesto = presupuesto;
            this.horasDeTrabajoParaLaRealizacion = horasDeTrabajoParaLaRealizacion;
            this.contratistas = contratistas;
        }

        public bool alcanzaElPresupuesto(){
            int presupuestoNecesario = 0;
            foreach (var i in contratistas){
                i.trabajar(horasDeTrabajoParaLaRealizacion);
                presupuestoNecesario += i.cobrar();
            }
            return presupuesto > presupuestoNecesario;
        }

    }
}
using System.Collections.Generic;

namespace E2
{
    public class Clinica
    {
        List<Medico> medicos = new List<Medico>();
        string especialidadPedida;
        public Clinica (string especialidadPedida){

            Medico n1 = new Medico("Jorge", "Escalada", "Traumatologia", 50);
            medicos.Add(n1);
            Medico n2 = new Medico("Angelica", "La Torre", "Traumatologia", 37);
            medicos.Add(n2);
            Medico n3 = new Medico("Pedro", "Picapiedra", "Dermatologia", 30);
            medicos.Add(n3);

            this.especialidadPedida = especialidadPedida;

        }
        
        public string DisponibilidadDelMedico(){

            string mensaje;

            foreach (var i in medicos){

                if (i.EstaDisponible(especialidadPedida)){

                    mensaje = ("El medico que lo atendera se llama: " + i.Nombre());
                    return mensaje;

                }

            }

            return "Intente de nuevo mas tarde";

        }

    }
}
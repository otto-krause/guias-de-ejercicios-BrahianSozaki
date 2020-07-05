using System.Linq;
using System.Collections.Generic;
namespace E4
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
            List<Medico> aux = medicos.Where(medico => especialidadPedida == medico.Especialidad).ToList();
            List<Medico> medicosDisponibles = aux.Where(medico => medico.EstaDisponible()).ToList();
            int cont = medicosDisponibles.Count;
            switch(cont){
                case 0:
                    return "Intente de nuevo mas tarde";
                default:
                    Medico disponible = medicosDisponibles.First();
                    disponible.AumentarTurnos();
                    return "El medico que lo atendera se llama: " + disponible.Nombre + " " + disponible.Apellido;
            }
        }
    }
}
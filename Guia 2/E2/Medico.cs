namespace E2
{
    public class Medico
    {
        
        string nombre;
        string apellido;
        string especialidad;
        int cantidadDeTurnos;

        public Medico (string nombre, string apellido, string especialidad, int cantidadDeTurnos){

            this.nombre = nombre;
            this.apellido = apellido;
            this.especialidad = especialidad;
            this.cantidadDeTurnos = cantidadDeTurnos;

        }
        public bool EstaDisponible(string especialidadPedida){

            if(especialidadPedida == especialidad) return cantidadDeTurnos < 50;
            return false;

        }

        public string Nombre(){

            return nombre;

        }

    }
}
namespace E2
{
    public class Medico
    {
        
        string nombre;
        string apellido;
        string especialidad;
        int cantidadDeTurnos;

        public Medico(string nombre, string apellido, string especialidad, int cantidadDeTurnos)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.especialidad = especialidad;
            this.cantidadDeTurnos = cantidadDeTurnos;
        }

        public bool EstaDisponible(){
            return cantidadDeTurnos < 50;
        }

        public string getEspecialidad(){
            return especialidad;
        }

        public string getNombre(){
            return nombre;
        }

    }
}
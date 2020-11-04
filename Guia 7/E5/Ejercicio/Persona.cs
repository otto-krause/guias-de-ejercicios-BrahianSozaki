namespace Ejercicio
{
    public class Persona
    {
        Quirk quirk;

        public Persona(Quirk quirk)
        {
            this.quirk = quirk;
        }

        public int poder(){
            return quirk.TiempoDeUso * quirk.Nombre;
        }
        public bool esPeligroso(){
            return poder() > 1000 && quirk.TiempoDeUso > 60;
        }
    }
}
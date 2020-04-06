namespace Programas
{
    public class Gatito
    {
        string nombre;
        bool vacunas;
        int energia;

        public Gatito (string nombre, bool vacunas, int energia){
            this.nombre=nombre;
            this.vacunas=vacunas;
            this.energia=energia;
        }

        public string Nombre(){
            return nombre;
        }

        public bool EstaVacunado(){
            return vacunas;
        }

        public void jugar (int minutos){
            energia -= 2*minutos;
        }

        public void Comer (){
            energia += 50;
        }

        public bool estaSaludable (){
            return vacunas && energia > 30;
        }

    }
}
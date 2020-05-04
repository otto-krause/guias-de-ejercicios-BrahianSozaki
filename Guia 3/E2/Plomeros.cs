namespace E2
{
    public class Plomeros : Contratistas
    {
        int horasTrabajadas;

        public Plomeros()
        {
            this.horasTrabajadas = 0;
        }

        public int cobrar()
        {
            return horasTrabajadas * 80;    
        }

        public void trabajar(int horasTrabajadas)
        {
            this.horasTrabajadas = horasTrabajadas;
        }
    }
}
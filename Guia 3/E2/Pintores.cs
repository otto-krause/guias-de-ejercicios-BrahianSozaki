namespace E2
{
    public class Pintores : Contratistas
    {
        int horasTrabajadas;

        public Pintores()
        {
            this.horasTrabajadas = 0;
        }

        public int cobrar()
        {
            return 50*(horasTrabajadas * 3);
        }

        public void trabajar(int horasTrabajadas)
        {
            this.horasTrabajadas = horasTrabajadas;
        }
    }
}
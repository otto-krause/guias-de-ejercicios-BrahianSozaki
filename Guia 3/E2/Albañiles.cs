namespace E2
{
    public class Albañiles : Contratistas
    {
        int edad;
        int horasTrabajadas;

        string titulo;

        public Albañiles(int edad, string titulo)
        {
            this.edad = edad;
            this.horasTrabajadas = 0;
            this.titulo = titulo;
        }

        public int cobrar()
        {
            int cobra;
            if (edad > 20 && edad < 30) cobra = 50*horasTrabajadas;
            else
                if (edad > 30 && edad < 50) cobra = 90*horasTrabajadas;
                else cobra = 120* horasTrabajadas;

            if (this.titulo == "MMO") cobra += 50;
            
            return cobra;
                
        }

        public void trabajar(int horasTrabajadas)
        {
            this.horasTrabajadas = horasTrabajadas;
        }
    }
}
namespace E7
{
    public class Alfajor
    {
        string nombre;
        int precio;
        public int Precio { get => precio; }
        string nombreDeLaEmpresa;

        public Alfajor(string nombre, int precio, string nombreDeLaEmpresa)
        {
            this.nombre = nombre;
            this.precio = precio;
            this.nombreDeLaEmpresa = nombreDeLaEmpresa;
        }

        public void Aumentos(int opcion){
            switch (opcion){
                case 1:
                    precio += 80;
                    break;
                case 2:
                    precio *= 2;
                    break;
                case 3:
                    if (nombreDeLaEmpresa != "Waymayen"){
                        precio += 1000;
                    }
                    break;
            }
        }


    }
}
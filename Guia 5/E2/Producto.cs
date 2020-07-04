namespace E5
{
    public class Producto
    {
        private string nombre;
        public string Nombre { get => nombre; }
        private int precio;
        public int Precio { get => precio; }

        public Producto(string nombre, int precio){
            this.nombre = nombre;
            this.precio = precio;
        }

    }
}
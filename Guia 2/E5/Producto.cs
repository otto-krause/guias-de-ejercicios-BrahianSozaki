namespace E5
{
    public class Producto
    {
        string nombre;
        int precio;

        public Producto(string nombre, int precio){
            this.nombre = nombre;
            this.precio = precio;
        }

        public string getNombre(){
            return nombre;
        }
        public int getPrecio(){
            return precio;
        }
    }
}
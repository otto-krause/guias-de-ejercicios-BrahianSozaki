using System.Collections.Generic;

namespace E5
{
    public class Carrito
    {
        List<Producto> productos = new List<Producto>();
        public Carrito(){
            Producto p1 = new Producto("Banana", 30);
            productos.Add(p1);
            Producto p2 = new Producto("Surtidas", 60);
            productos.Add(p2);
            Producto p3 = new Producto("Leche la Martona", 44);
            productos.Add(p3);
        }

    }
}
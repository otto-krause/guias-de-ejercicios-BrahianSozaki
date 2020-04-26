using System.Collections.Generic;

namespace E5
{
    public class Carrito
    {
        List <Producto> productos = new List<Producto>();
        public Carrito (){
            Producto p1 = new Producto("Leche la Martona", 44);
            Producto p2 = new Producto("Surtidas", 60);
            productos.Add(p1);
            productos.Add(p2);
        }

        public int precio(string producto){
            foreach (var i in productos){
                if (producto == i.getNombre()){
                    return i.getPrecio();
                }
            }
            return 0;
        }
    }
}
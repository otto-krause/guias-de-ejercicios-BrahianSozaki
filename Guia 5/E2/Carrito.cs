using System.Collections.Generic;
using System.Linq;
namespace E2
{
    public class Carrito
    {
        List <Producto> productos;
        public Carrito (){
            productos = new List<Producto>();
            Producto p1 = new Producto("Leche la Martona", 44);
            Producto p2 = new Producto("Surtidas", 60);
            productos.Add(p1);
            productos.Add(p2);
        }

        public int precio(string producto){
            int ganancias = 0;
            List<Producto> precios = productos.Where(Producto => producto == Producto.Nombre).ToList();
            precios.ForEach(precio => ganancias = precio.Precio);
            return ganancias;
        }
    }
}
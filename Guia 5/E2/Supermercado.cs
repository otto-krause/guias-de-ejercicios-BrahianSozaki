using System.Collections.Generic;
using System.Linq;

namespace E5
{
    public class Supermercado
    {
        
        List<Carrito> carritos = new List<Carrito>();
        string producto;
        int cantidadDelProducto;

        public Supermercado (string producto, int cantidadDelProducto){
            this.producto = producto;
            this.cantidadDelProducto = cantidadDelProducto;

            Carrito c1 = new Carrito();
            carritos.Add(c1);
        }

        public int Ganancias(){
            int ganancias = 0;
            carritos.ForEach(precios => ganancias = precios.precio(producto));
            return  ganancias * cantidadDelProducto;
        }

    }
}
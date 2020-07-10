using System.Collections.Generic;
using System.Linq;

namespace E2
{
    public class Supermercado
    {
        
        List<Carrito> carritos;
        string producto;
        int cantidadDelProducto;

        public Supermercado (string producto, int cantidadDelProducto){
            this.producto = producto;
            this.cantidadDelProducto = cantidadDelProducto;
            carritos = new List<Carrito>();

            Carrito c1 = new Carrito();
            carritos.Add(c1);
        }

        public int Ganancias(){
            int ganancias = 0;
            carritos.Sum(precios => ganancias = precios.precio(producto));
            return  ganancias * cantidadDelProducto;
        }

    }
}
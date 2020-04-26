using System.Collections.Generic;

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
            int precio = 0;
            foreach (var i in carritos){
                precio = i.precio(producto);
            }
            return precio * cantidadDelProducto;
        }

    }
}
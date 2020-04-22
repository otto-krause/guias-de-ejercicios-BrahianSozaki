using System.Collections.Generic;

namespace E5
{
    public class Supermercado
    {
        List<Carrito> carritos = new List<Carrito>();
        public Supermercado (){
            Carrito c1 = new Carrito();
            carritos.Add(c1);
            Carrito c2 = new Carrito();
            carritos.Add(c2);
            Carrito c3 = new Carrito();
            carritos.Add(c3);
        }

        public int Ganancias (){
            return 50;
        }

    }
}
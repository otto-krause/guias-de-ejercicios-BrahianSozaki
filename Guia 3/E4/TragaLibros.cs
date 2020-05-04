using System.Collections.Generic;
namespace E4
{
    public class TragaLibros
    {
        List<Libro> libro = new List<Libro>();

        public void Leer(Libro libro){
            this.libro.Add(libro);
        }

        public int CalcularCI(){
            return 5*libro.Count;
        }
    }
}
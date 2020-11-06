using System.Collections.Generic;
using System.Linq;

namespace Ejercicio
{
    public class Ciudad
    {
        int cantidadDeGrados;
        List<string> objetos;
        int alturaPiramide;
        public int AlturaPiramide { get => alturaPiramide; }
        public Ciudad(int cantidadDeGrados, List<string> objetos, int alturaPiramide)
        {
            this.cantidadDeGrados = cantidadDeGrados;
            this.objetos = objetos;
            this.alturaPiramide = alturaPiramide;
        }

        public void reduccionDeGrados(){
            cantidadDeGrados -= 30;
        }

        public void eliminarObjeto(string objetoRobado){
            List<string> objetosSinElEliminado = objetos.Except(objetos.Where(i => i == objetoRobado)).ToList();
            objetos = objetosSinElEliminado;
        }

    }
}
using System;

namespace Programas
{
    public class Camara
    {
        
        int megapixeles, cantidadDeFotos;
        public Camara(int megapixeles, int cantidadDeFotos){
            
            this.megapixeles = megapixeles;
            this.cantidadDeFotos = cantidadDeFotos;
        
        }

        public int pesoPorFoto(){
            
            int totalPixeles = megapixeles * 1000000;
            int totalDeBytes = totalPixeles * 3;
            return totalDeBytes;
        
        }
        public int PesoTotalDeFotos(){
            
            int totalMB = pesoPorFoto() / 1000000;
            int totalPeso = totalMB * cantidadDeFotos;
            return totalMB;
        
        }

    }
}
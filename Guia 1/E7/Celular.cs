using System;

namespace Programas
{
    public class Celular
    {
        bool NFC;
        bool Bluethoot;
        int MemoriaDeAlmacenamiento;
        int CantidadDeAplicaciones;
        public Celular (bool NFC, bool Bluethoot, int MemoriaDeAlmacenamiento, int CantidadDeAplicaciones){

            this.NFC = NFC;
            this.Bluethoot = Bluethoot;
            this.MemoriaDeAlmacenamiento = MemoriaDeAlmacenamiento;
            this.CantidadDeAplicaciones = CantidadDeAplicaciones;

        }

        public int MemoriaDisponible(){

            int pesoTotalDeFotos = 0;
            Camara frontal = new Camara(10,10);
            pesoTotalDeFotos += frontal.PesoTotalDeFotos();
            Camara trasera = new Camara(20,20);
            pesoTotalDeFotos += trasera.PesoTotalDeFotos();

            int PesoAplicaciones = CantidadDeAplicaciones * 70;
            int MemoriaDeAlmacenamientoDisponible = MemoriaDeAlmacenamiento;
            int resto = 0;
            resto += PesoAplicaciones + pesoTotalDeFotos;
            MemoriaDeAlmacenamientoDisponible -= resto;
            return MemoriaDeAlmacenamientoDisponible;

        }
        public bool TeCargaLaSube(){

            return NFC;

        }



    }
}
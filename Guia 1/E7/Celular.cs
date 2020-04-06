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


            Camara camara = new Camara(100,10);

            int PesoAplicaciones = CantidadDeAplicaciones * 70;
            int MemoriaDeAlmacenamientoDisponible = MemoriaDeAlmacenamiento;
            MemoriaDeAlmacenamientoDisponible -= PesoAplicaciones + camara.PesoTotalDeFotos();
            return MemoriaDeAlmacenamientoDisponible;

        }
        public bool TeCargaLaSube(){

            return NFC;

        }



    }
}
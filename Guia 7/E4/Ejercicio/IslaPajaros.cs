using System.Collections.Generic;
using System.Linq;
namespace Ejercicio
{
    public class IslaPajaros
    {
        List<Pajaros> pajaros;
        List<Obstaculo> obstaculos;
        public IslaPajaros(List<Pajaros> pajaros, List<Obstaculo> obstaculos)
        {
            this.pajaros = pajaros;
            this.obstaculos = obstaculos;
        }
        public void manejarIraConMatilda() => pajaros.ForEach(i => i.reducirIra());
        public void invasionCerdil() => pajaros.ForEach(i => i.seEnoja());
        public void fiestaSorpresa(Pajaros pajaro) => pajaro.seEnoja();
        public void serieDeEventos(Pajaros pajaro){
            manejarIraConMatilda();
            invasionCerdil();
            fiestaSorpresa(pajaro);
        }
        public void naceUnPajaro(Pajaros recienNacido) => pajaros.Add(recienNacido);
        public bool atacarIslaCerdos(){
            bool gananPajaros = false;
            while (gananPajaros == false && pajaros != null){
                foreach(var i in obstaculos){
                    Pajaros pajaroMasFuerte = pajaros.Single(j => j.fuerza() == pajaros.Max(j => j.fuerza()));
                    if(pajaroMasFuerte.fuerza() > i.resistenciaDelObstaculo()){
                        gananPajaros = true;
                    }else{
                        gananPajaros = false;
                        pajaros.RemoveAll(j => j.fuerza() == pajaroMasFuerte.fuerza());
                    }
                }
            }
            if (gananPajaros == true) obstaculos.Clear();
            return gananPajaros;
        }
    }
}
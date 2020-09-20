namespace Ejercicio
{
    public class Huevo
    {
        private int peso;
        public Huevo(int peso)
        {
            this.peso = peso;
        }
        public int fuerza(){
            return peso;
        }
        public void seRompe(IslaPajaros isla){
            Pajaros pajaro = new PajarosComunes(0);
            isla.naceUnPajaro(pajaro);
        }
    }
}
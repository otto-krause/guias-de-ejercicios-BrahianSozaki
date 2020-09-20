namespace Ejercicio
{
    public class CerditosArmados : Cerditos
    {
        int resistenciaDelObjeto;
        public CerditosArmados(int resistenciaDelObjeto)
        {
            this.resistenciaDelObjeto = resistenciaDelObjeto;
        }
        public override int resistenciaDelObstaculo()
        {
            return 10 * resistenciaDelObjeto;
        }
    }
}
namespace Ejercicio
{
    public class SpiderGwen : SpidermanClasico
    {
        private int glamour;

        public SpiderGwen(int glamour, int fuerza) : base(fuerza)
        {
            this.glamour = glamour;
        }
        public override int poder()
        {
            if(glamour < 1 || glamour > 10){
                throw new System.Exception("El glamour super los rangos. Debe estar comprendido entre 1-10");
            }else{
                return fuerza + glamour;
            }
        }

    }
}
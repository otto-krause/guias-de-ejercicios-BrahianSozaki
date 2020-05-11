namespace E5
{
    public class X
    {
        double xBuster;
        Armadura armadura;

        public X()
        {
            this.armadura = new FalconArmor();
            this.xBuster = 10;
        }

        public void CambiarArmadura(Armadura armadura){
            this.armadura = armadura;
        }
        public void Entrenamiento(int minutos)
        {
            xBuster += 2*minutos;
            if (armadura == new FalconArmor()) armadura.Entrenar(minutos);
            else armadura.Entrenar(xBuster);
        }
        public double Fuerza (){
            return xBuster + armadura.BonificacionDeDaño();
        }

    }
}
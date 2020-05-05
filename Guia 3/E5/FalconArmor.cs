namespace E5
{
    public class FalconArmor : Armadura
    {
        int potencia;
        double resistencia;

        public FalconArmor()
        {
            this.potencia = 25;
            this.resistencia = 10;
        }

        public double BonificacionDeDaño (){
            return (potencia+resistencia)/2;
        }

        public void Entrenar(double xBuster)
        {
            double minutos = (xBuster / 2)-5;
            potencia += 10;
            if (resistencia >= minutos) resistencia -= minutos;
            else resistencia -= resistencia;
        }
    }
}
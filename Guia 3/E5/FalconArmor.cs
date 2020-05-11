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

        public void Entrenar(double var)
        {
            potencia += 10;
            if (resistencia >= var) resistencia -= var;
            else resistencia -= resistencia;
        }
    }
}
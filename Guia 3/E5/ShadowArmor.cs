namespace E5
{
    public class ShadowArmor : Armadura
    {

        double desgaste;

        public ShadowArmor()
        {
            this.desgaste = 10;
        }

        public void Entrenar(double xBuster)
        {
            desgaste += xBuster;
        }
        public double BonificacionDeDaño()
        {
            return 80 / desgaste;
        }
    }
}
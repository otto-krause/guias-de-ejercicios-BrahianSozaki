namespace Ejercicio
{
    public class Arma
    {
        private int dureza;
        private int potencia;

        public Arma(int dureza, int potencia)
        {
            this.dureza = dureza;
            this.potencia = potencia;
        }

        public int Fuerza(){
            return potencia + Fibonacci();
        }

        public int Fibonacci(){
            int a = 0, b = 0, c = 1;
            for (int i = 1; i < dureza; i++){
                a = b;
                b = c;
                c = a + b;
            }
            return dureza == 0 ? 0 : dureza == 1 ? 1 : c;
        }

    }
}
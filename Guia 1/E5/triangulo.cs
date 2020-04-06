namespace Programas
{
    public class Triangulo
    {
        double lado;
        double lado1;
        double lado2;
        public Triangulo (double lado, double lado1, double lado2){
            this.lado = lado;
            this.lado1 = lado1;
            this.lado2 = lado2;
        }
        public bool EsEscaleno(){
            return lado!=lado1 && lado1 != lado2 && lado != lado2;
        }

        public bool EsIsosceles(){
            return (lado == lado1 && lado1 != lado2 && lado != lado2) || (lado1 == lado2 && lado!=lado1 && lado != lado2) || (lado == lado2 && lado!=lado1 && lado1 != lado2);
        }
        public bool EsEquilatero(){
            return lado == lado1 && lado1 == lado2;
        }

    }
}
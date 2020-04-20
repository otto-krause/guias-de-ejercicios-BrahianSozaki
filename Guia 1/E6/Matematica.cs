using System; //Lo coloque para mostrar la fibonacci para usar console.x

namespace Programas
{
    public class Matematica
    {
        public void Fibonacci(int num){

            int fibo = 0, fibo1 = 1, aux = 0;

            while (aux != num/2){

                Console.WriteLine(fibo);
                fibo+=fibo1;
                Console.WriteLine(fibo1);
                fibo1+=fibo;

                aux+=1;

            }

        }

        public int Factorial(int num){

            int aux = 1, cont = 2;

            while (cont != num+1){

                aux = aux * cont;
                cont+=1;

            }
            
            return aux;

        }

        public bool Mayor(int num, int num1){

            return num > num1;

        }

        public bool Menor(int num, int num1){

            return num > num1;

        }

        public int Cubo(int num){

            int aux, cont = 0;
            aux = num;

            while (cont != 2){

                aux = aux * num;
                cont+=1;

            }
            return aux;
            
        }
    }
}
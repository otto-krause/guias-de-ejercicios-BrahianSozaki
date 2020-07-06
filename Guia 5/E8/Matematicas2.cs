using System.Collections.Generic;
using System.Linq;
namespace E8
{
    public class Matematicas2
    {
        List<int> numeros;

        public Matematicas2(List<int> numeros)
        {
            this.numeros = numeros;
        }

        public List<int> primos(){
            int auxi = 0;
            List<int> primos = new List<int>();
            foreach(var i in numeros){
                for (int x = 1; x < (i+1); x++){
                    if(i % x == 0){
                        auxi++;
                    }
                }
                switch(auxi){
                    case 2:
                        primos.Add(i);
                        break;
                }
                auxi = 0;
            }
            return primos;
        }
        public List<int> pares(){
            return numeros.Where(n => n % 2 == 0).ToList();
        }
        public List<int> aplanar(){
            return numeros.Distinct().ToList();
        }
        public int suma(){
            return numeros.Sum();
        }
        public int sumaPrimos(){
            return primos().Sum();
        }
        public int mayor(){
            return numeros.Max();
        }
        public int menor(){
            return numeros.Min();
        }
    }
}
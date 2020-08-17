using System.Collections.Generic;
using System.Linq;
namespace Ejercicio
{
    public class Zero
    {
        List<Arma> armas;

        public Zero(List<Arma> armas)
        {
            this.armas = armas;
        }

        public int poder(){
            return laMasPolentosa().poder();
        }
        public Arma laMasPolentosa(){
            Arma armaMasPulenta = armas.First();
            foreach(var arma in armas){
                if (armas.Max(arma => arma.poder()) == arma.poder()) armaMasPulenta = arma;
            }
            return armaMasPulenta;
        }

        public bool loPuedeVencer(Mavericks maverick){
            return poder() > maverick.fuerza();
        }
        public bool losPuedeVencer(List<Mavericks> mavericks){
            bool esMayor = true;
            esMayor = mavericks.Any(n => n.fuerza() > poder());
            return !esMayor;
        }
    }
}
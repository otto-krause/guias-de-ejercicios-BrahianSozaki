using System.Collections.Generic;

namespace E3
{
    public class Album
    {
        

        List<Figurita> album = new List<Figurita>();

        public Album(){

            Figurita j1 = new Figurita("Messi", "Delantero", "Argentina", 10);
            album.Add(j1);
            Figurita j2 = new Figurita("Ronaldo", "Delantero", "Portugal", 19);
            album.Add(j2);
            Figurita j3 = new Figurita("Mascherano", "MedioCampista", "Argentina", 11);
            album.Add(j3);

        }

        public bool apareceEnElAlbum(int numeroDeLaFigurita){

            foreach (var i in album)
            {
                
                if (numeroDeLaFigurita == i.getNumeroDeLaFigurita()) return true;

            }
            return false;

        }

        public void ingreso(string nombre, string posicion, string pais, int numeroDeLaFigurita){

            album.Add(new Figurita (nombre, posicion, pais, numeroDeLaFigurita));

        }

        public int DelanterosMedioCampistas(int i){
            int count = 0;
            if (i==0){
                foreach (var j in album){
                    if(j.getPosicion() == "Delantero") count++;
                }
                return count;
            }else{
                foreach (var j in album){
                    if(j.getPosicion() == "MedioCampista") count++;
                }
                return count;
            }
        }

        public bool EstaCompleto(){
            return album.Count == 352;
        }

    }
}
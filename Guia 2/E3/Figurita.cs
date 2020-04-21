namespace E3
{
    public class Figurita
    {
        
        string nombre;
        string posicion;
        string pais;
        int numeroDeLaFigurita;

        public Figurita (string nombre, string posicion, string pais, int numeroDeLaFigurita){
            this.nombre = nombre;
            this.posicion = posicion;
            this.pais = pais;
            this.numeroDeLaFigurita = numeroDeLaFigurita;
        }

        public int getNumeroDeLaFigurita(){
            return numeroDeLaFigurita;
        }

        public string getPosicion(){
            return posicion;
        }

    }
}
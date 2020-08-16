namespace Ejercicio
{
    public class Acebo : Varita
    {
        public Acebo(int potencia, Receta receta) : base(potencia, receta)
        {
        }
        public override int tiempoParaLaReceta(){
            return receta.Ingredientes() + potencia;
        }
    }
}
namespace E3
{
    public class Ponystation4_pro_SaladaEdition : Consola
    {
        public Ponystation4_pro_SaladaEdition(int puntaje) : base(puntaje)
        {
        }
        public override void agregarJuego(Juego juego)
        {
            juegos.Clear();
            juegos.Add(juego);
        }
        public override void jugar(int horas)
        {
           puntaje += 3 * horas;
        }
        public override int revisarPuntaje()
        {
            return base.revisarPuntaje() / 2;
        }

        public override string ToString()
        {
            return "Ponystation4_pro_SaladaEdition";
        }
    }
}
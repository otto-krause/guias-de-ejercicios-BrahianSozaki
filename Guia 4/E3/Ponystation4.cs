namespace E3
{
    public class Ponystation4 : Consola
    {
        public Ponystation4(int puntaje) : base(puntaje)
        {
        }
        public override void agregarJuego(Juego juego)
        {
            juegos.Add(juego);
            puntaje += 29;
        }
        public override void jugar(int horas)
        {
            puntaje += 3 * horas;
        }

        public override string ToString()
        {
            return "Ponystation4";
        }

    }
}
namespace E3
{
    public class PC : Consola
    {
        public PC (int puntaje) : base(puntaje)
        {
        }
        public override void agregarJuego(Juego juego)
        {
            juegos.Add(juego);
        }
        public override void jugar(int horas)
        {
            puntaje += 10 * horas;
        }

        public override string ToString()
        {
            return "PC";
        }

    }
}
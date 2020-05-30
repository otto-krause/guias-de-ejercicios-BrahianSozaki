namespace E3
{
    public class CajaX : Consola
    {
        public CajaX(int puntaje) : base (puntaje)
        {
        }
        public override void agregarJuego(Juego juego)
        {
            juegos.Add(juego);
            puntaje += 25;
        }

        public override void jugar(int horas)
        {
            puntaje += 4 * horas;
        }

        public override string ToString()
        {
            return "CajaX";
        }
    }
}
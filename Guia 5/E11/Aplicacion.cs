namespace E11
{
    public class Aplicacion
    {
        private int tiempoDeUso;
        public int TiempoDeUso { get => tiempoDeUso; }
        private int cantidadDeToquesEnLaPantalla;
        public int CantidadDeToquesEnLaPantalla { get => cantidadDeToquesEnLaPantalla; }
        private int tiempoDeUsoDelTeclado;
        public int TiempoDeUsoDelTeclado { get => tiempoDeUsoDelTeclado; }
        private bool permisos;
        public bool Permisos { get => permisos; }

        public Aplicacion(int tiempoDeUso, int cantidadDeToquesEnLaPantalla, int tiempoDeUsoDelTeclado, bool permisos)
        {
            this.tiempoDeUso = tiempoDeUso;
            this.cantidadDeToquesEnLaPantalla = cantidadDeToquesEnLaPantalla;
            this.tiempoDeUsoDelTeclado = tiempoDeUsoDelTeclado;
            this.permisos = permisos;
        }

        public bool esUnJuego(){
            return cantidadDeToquesEnLaPantalla/tiempoDeUso == 25;
        }
        public bool esUnaRedSocial(){
            return tiempoDeUsoDelTeclado / tiempoDeUso > 20 && permisos;
        }
    }
}
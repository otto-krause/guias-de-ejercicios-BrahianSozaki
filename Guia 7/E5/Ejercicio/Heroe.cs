namespace Ejercicio
{
    public class Heroe : Persona
    {
        int contadorDeVictorias;
        public int ContadorDeVictorias { get => contadorDeVictorias; }
        int contadorDeDerrotas;
        bool tieneLicenciaDeHeroe;
        bool tieneActaDeDefuncion;
        public bool TieneActaDeDefuncion { get => tieneActaDeDefuncion; }

        public Heroe(Quirk quirk) : base(quirk)
        {
            this.contadorDeVictorias = 0;
            this.contadorDeDerrotas = 0;
            this.tieneLicenciaDeHeroe = true;
            this.tieneActaDeDefuncion = false;
        }

        public void pelearContraVillano(Villano villano){
            if( poder() > villano.poder() ) contadorDeVictorias++;
            else contadorDeDerrotas++;
        }

        public void pelearContraPandilla(Pandilla pandilla){
            if( poder() > pandilla.PoderTotal() ) contadorDeVictorias++;
            else{
                tieneLicenciaDeHeroe = false;
                tieneActaDeDefuncion = true;
            }
        }

    }
}
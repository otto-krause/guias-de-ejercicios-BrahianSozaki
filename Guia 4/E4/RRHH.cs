namespace E4
{
    public class RRHH : Empleado
    {

        int cantidadDePersonasReferidas;
        public RRHH (int cantidadDePersonasReferidas, int cajaBancaria) : base(cajaBancaria)
        {
            this.cantidadDePersonasReferidas = cantidadDePersonasReferidas;
        }
        public override void depositan() => cajaBancaria += 5000 + (cantidadDePersonasReferidas * 5000);

    }
}
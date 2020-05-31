namespace E4
{
    public abstract class Empleado
    {
        protected int cajaBancaria;
        public int CajaBancaria { get => cajaBancaria; }
        public Empleado (int cajaBancaria){
            this.cajaBancaria = cajaBancaria;
        }

        public abstract void depositan();
        public void extraen(int cuantoExtraen) => cajaBancaria -= cuantoExtraen;
    }
}
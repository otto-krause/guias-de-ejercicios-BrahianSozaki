namespace E4
{
    public class Programador : Empleado
    {
        string nivelDelProgramador;
        public Programador(string nivelDelProgramador,int cajaBancaria) : base(cajaBancaria)
        {
            this.nivelDelProgramador = nivelDelProgramador;
        }

        public override void depositan(){
            switch (nivelDelProgramador){
                case "junior":
                    cajaBancaria += 30000;  
                    break;
                case "semiSenior":
                    cajaBancaria += 40000;
                    break;
                case "senior":
                    cajaBancaria += 60000;
                    break;
            }
        }

    }
}
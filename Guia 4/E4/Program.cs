using System;

namespace E4
{
    class Program
    {
        static void Main(string[] args)
        {

            Empleado RRHH = new RRHH(5,0);
            Empleado junior = new Programador("junior",0);
            Empleado semiSenior = new Programador("semiSenior",0);
            Empleado senior = new Programador("senior",0);
            Empleado Administrativo = new Administrativo(0);

            string opcion = "";
            int monto;

            while (opcion != "Salir"){

                Console.WriteLine("[1]Depositar al RRHH\n"+
                "[2]Depositar a los Programadores\n"+
                "[3]Depositar al Administrativo\n"+
                "[4]Extraer del RRHH\n"+
                "[5]Extraer de uno de los Programadores\n"+
                "[6]Extraer del Administrativo\n"+
                "[7]Ver caja bancaria del RRHH\n"+
                "[8]Ver caja bancaria de los Programadores\n"+
                "[9]Ver caja bancaria del Administrativo");
                opcion = Console.ReadLine();

                switch (opcion){
                    case "1":
                        RRHH.depositan();
                        break;

                    case "2":
                        junior.depositan();
                        semiSenior.depositan();
                        senior.depositan();
                        break;

                    case "3":
                        Administrativo.depositan();
                        break;
                    case "4":
                        Console.WriteLine("Ingrese el monto que se desea extraer de la cuenta del RRHH");
                        monto = Int32.Parse(Console.ReadLine());
                        RRHH.extraen(monto);
                        break;
                    case "5":
                        Console.WriteLine("Ingrese el monto que se desea extraer de la cuenta del Programador");
                        monto = Int32.Parse(Console.ReadLine());
                        Console.WriteLine("[1]Extraer del junior\n[2]Extraer del semiSenior\n[3]Extraer del senior");
                        opcion = Console.ReadLine();
                        switch (opcion){
                            case "1":
                                junior.extraen(monto);
                                break;
                            case "2":
                                semiSenior.extraen(monto);
                                break;
                            case "3":
                                senior.extraen(monto);
                                break;
                        }
                        break;
                    case "6":
                        Console.WriteLine("Ingrese el monto que se desea extraer de la cuenta del Administrativo");
                        monto = Int32.Parse(Console.ReadLine());
                        Administrativo.extraen(monto);
                        break;
                    case "7":
                        Console.WriteLine("Monto de la cuenta del RRHH: " + RRHH.CajaBancaria);
                        break;
                    case "8":
                        Console.WriteLine("Monto de la cuenta del junior: " + junior.CajaBancaria +
                                          "\nMonto de la cuenta del semiSenior" + semiSenior.CajaBancaria+
                                          "\nMonto de la cuenta del senior" + senior.CajaBancaria);
                        break;
                    case "9":
                        Console.WriteLine("Monto de la cuenta del Administrativo: " + Administrativo.CajaBancaria);
                        break;
                    default:
                        opcion = "Salir";
                        break;
                }

            }
        }
    }
}

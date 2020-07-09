using System;
using System.Linq;
using System.Collections.Generic;
namespace E11
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Aplicacion> aplicaciones = new List<Aplicacion>();
            int tiempoDeUso = 0;
            int cantidadDeToquesEnLaPantalla = 0;
            int tiempoDeUsoDelTeclado = 0;
            bool permisos = false;

            /*
            Use estos ejemplos para diferenciar los tipos.
            juego = 30, 750, 0, false
            redSocial = 20, 0, 450,true
            aplicacion = 30, 500, 300, false
            */
            
            string terminarIngreso = "Continuar";

            while (terminarIngreso != "Salir"){
                Console.WriteLine("Ingrese el tiempo de uso de la app");
                tiempoDeUso = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese la cantidad de toques en la pantalla(0 si no utiliza la pantalla)");
                cantidadDeToquesEnLaPantalla = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese la cantidad de tiempo que usa el teclado(0 si no lo utiliza)");
                tiempoDeUsoDelTeclado = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Tiene permisos como el uso de la camara? (True o False)");
                permisos = Convert.ToBoolean(Console.ReadLine());

                Aplicacion aplicacion = new Aplicacion(tiempoDeUso, cantidadDeToquesEnLaPantalla, tiempoDeUsoDelTeclado, permisos);
                aplicaciones.Add(aplicacion);

                Console.WriteLine("'Continuar' para seguir ingresando y 'Salir' para terminar el ingreso");
                terminarIngreso = Console.ReadLine();
            }

            //Mas que los datos no encuentro forma de diferenciarlos asi que imprimo eso.
            List<Aplicacion> juego = aplicaciones.Where(i => i.esUnJuego()).ToList();
            Console.WriteLine("Los juegos son: ");
            juego.ForEach(i => Console.WriteLine(i.TiempoDeUso +" "+ i.CantidadDeToquesEnLaPantalla +" "+ i.TiempoDeUsoDelTeclado +" "+ i.Permisos));

            List<Aplicacion> redSocial = aplicaciones.Where(i => i.esUnaRedSocial()).ToList();
            Console.WriteLine("Las redes sociales son:");
            redSocial.ForEach(i => Console.WriteLine(i.TiempoDeUso +" "+ i.CantidadDeToquesEnLaPantalla +" "+ i.TiempoDeUsoDelTeclado +" "+ i.Permisos));

            List<Aplicacion> aplicacionesSimples = aplicaciones.Where(i => !i.esUnJuego() && !i.esUnaRedSocial()).ToList();
            Console.WriteLine("Y las aplicaciones no pertenecientes a estas categorias son:");
            aplicacionesSimples.ForEach(i => Console.WriteLine(i.TiempoDeUso +" "+ i.CantidadDeToquesEnLaPantalla +" "+ i.TiempoDeUsoDelTeclado +" "+ i.Permisos));
            
        }
    }
}

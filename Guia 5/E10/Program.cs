using System;
using System.Linq;
using System.Collections.Generic;
namespace E10
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Exalumnos> exalumnos = new List<Exalumnos>();
            Exalumnos e1 = new Exalumnos(6, 400000, 8);
            exalumnos.Add(e1);

            Exalumnos e2 = new Exalumnos(2, 400000, 5);
            exalumnos.Add(e2);

            Exalumnos e3 = new Exalumnos(2, 250000, 6);
            exalumnos.Add(e3);

            Exalumnos e4 = new Exalumnos(4, 350000, 9);
            exalumnos.Add(e4);

            Exalumnos e5 = new Exalumnos(2, 250000, 2);
            exalumnos.Add(e5);

            Exalumnos e6 = new Exalumnos(3, 850000, 3);
            exalumnos.Add(e6);

            bool fueExitoso = false;

            switch(exalumnos.Count(x => x.CantidadDeIdiomasQueHabla > 5)){
                case 0:
                    fueExitoso = false;
                    break;
                default:
                    
                    if(exalumnos.Count(x => x.CantidadDeIdiomasQueHabla >= 2) == exalumnos.Count()){

                        switch(exalumnos.Count(x => x.CantidadDePaisesVisitados > 3)){
                                case 1:
                                case 2:
                                case 3:
                                    fueExitoso = false;
                                    break;

                                default:

                                    switch(exalumnos.Count(x => x.CuantoGana > 200000)){
                                        case 1:
                                        case 2:
                                        case 3:
                                        case 4:
                                        case 5:
                                            fueExitoso = false;
                                            break;
                                        default:
                                            fueExitoso = true;
                                            break;
                                    }
                                    break;

                            }
                            break;

                    }
                    break;

            }

            Console.WriteLine("El curso fue exitoso? " + fueExitoso);
        }
    }
}

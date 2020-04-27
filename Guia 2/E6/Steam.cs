using System.Collections.Generic;

namespace E6
{
    public class Steam
    {
        List<Juego> juegos = new List<Juego>();
        public Steam (){
            Juego j1 = new Juego("Space Invaders", "Shoot'em up", 5, "Un juego que brilla por si solo debido a su gran jugabilidad y...");
            Juego j2 = new Juego("Super Mario Bros.", "Plataformeo", 5, "Me encantan los juegos de mario y mario verde");
            Juego j3 = new Juego("World of Warcraft", "Rol", 3, "Es muy entretenido pero pagar de a mes no me atrae");
            Juego j4 = new Juego("Megaman x7", "Plataformeo", 1, "Que es esto.. Sonic 2006??");
            juegos.Add(j1);
            juegos.Add(j2);
            juegos.Add(j3);
            juegos.Add(j4);
        }
        public List<string> Buscador(string buscar, int opcion){
            List<string> buscador = new List<string>();
            switch (opcion){
                case 1:
                    foreach (var i in juegos){
                        if (buscar == i.Genero){
                            buscador.Add(i.Descripcion());
                        }
                    }
                    break;
                case 2:
                    foreach (var i in juegos){
                        switch (buscar){
                            case "Alta":
                                if (i.getEstrellas() >= 4){
                                    buscador.Add(i.Descripcion());
                                }
                                break;
                            case "Media":
                                if (i.getEstrellas() == 3){
                                    buscador.Add(i.Descripcion());
                                }
                                break;
                            case "Baja":
                                if (i.getEstrellas() <= 2){
                                    buscador.Add(i.Descripcion());
                                }
                                break;
                        }
                    }
                    break;
            }
            return buscador;
        }
    }
}
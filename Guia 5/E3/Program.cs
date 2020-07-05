using System;
using System.Collections.Generic;
using System.Linq;
namespace E3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Carga de datos

            List<Caballeros_del_Zodiaco> caballeros = new List<Caballeros_del_Zodiaco>();

            Armadura armaduraDeSeiya = new Armadura("Cloth de Pegaso",  "Bronce");
            Caballeros_del_Zodiaco Seiya = new Caballeros_del_Zodiaco("Seiya", "Atena", armaduraDeSeiya, "Sagitario");
            caballeros.Add(Seiya);
            
            Armadura armaduraDeMills = new Armadura("Surplice de Elf", "Bronce");
            Caballeros_del_Zodiaco Mills = new Caballeros_del_Zodiaco("Mills", "Hades", armaduraDeMills, "Elfo");
            caballeros.Add(Mills);

            Armadura armaduraDeShiryu = new Armadura("Cloth de Dragon", "Bronce");
            Caballeros_del_Zodiaco Shiryu = new Caballeros_del_Zodiaco("Shiryu", "Atena", armaduraDeShiryu, "Libra");
            caballeros.Add(Shiryu);

            Armadura armaduraDeDeathMask = new Armadura("Cloth de Cancer", "Oro");
            Caballeros_del_Zodiaco DeathMask = new Caballeros_del_Zodiaco("DeathMask", "Atena", armaduraDeDeathMask, "Cancer");
            caballeros.Add(DeathMask);

            //Saints que apoyan a Atena

            Console.WriteLine("Armaduras de los saints que apoyan a Atena:");

            List<Caballeros_del_Zodiaco> armadurasDeSeguidoresDeAtena = caballeros.Where(caballeros => caballeros.DiosAlQueApoya == "Atena").ToList();
            armadurasDeSeguidoresDeAtena.ForEach(armaduras => Console.WriteLine (armaduras.getArmaduras()));

            //Nombre de los dioses sin repetir
            Console.WriteLine("\nDioses\n");

            List<string> Dioses = new List<string>();
            caballeros.ForEach(i => Dioses.Add(i.DiosAlQueApoya));

            var DiosesSinRepetir = Dioses.Distinct();
            
            foreach(var i in DiosesSinRepetir) Console.WriteLine(i);

            //Signos que empiezan con C
            Console.WriteLine("\nSignos que empiezan con 'C'\n");

            List<string> Signos = new List<string>();
            caballeros.ForEach(i => Signos.Add(i.SignoDelZodiaco));
            
            List<string> SignosConC = new List<string>();
            foreach (var i in Signos) if (i.StartsWith("C")) SignosConC.Add(i);

            SignosConC.ForEach(i => Console.WriteLine("Signos que comienzan con 'C': " + i));

        }
    }
}

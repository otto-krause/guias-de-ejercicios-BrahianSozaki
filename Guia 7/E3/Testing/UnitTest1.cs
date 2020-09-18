using NUnit.Framework;
using Ejercicio;
using System;
using System.Collections.Generic;
using System.Linq;
namespace Testing
{
    public class Tests
    {
        Batman batman;
        List<Tecnologias> batiriñonera;
        CiudadGotica ciudadGotica;
        List<Habitante> habitantes;
        List<Villano> villanos;
        [SetUp]
        public void Setup()
        {
            batiriñonera = new List<Tecnologias>();
            Tecnologias batibumerangs = new Tecnologias("Batibumerangs", 100, 1);
            batiriñonera.Add(batibumerangs);
            batman = new Batman(batiriñonera);

            villanos = new List<Villano>();
            Psicopatas psicopata = new Psicopatas(5, 100);
            villanos.Add(psicopata);
            
            Habitante habitante = new Habitante(2000000);
            Habitante habitante1 = new Habitante(7000000);
            Habitante habitante2 = new Habitante(8000000);
            Habitante habitante3 = new Habitante(9000000);
            Habitante habitante4 = new Habitante(10000000);
            Habitante habitante5 = new Habitante(11000000);
            Habitante habitante6 = new Habitante(12000000);
            Habitante habitante7 = new Habitante(13000000);
            Habitante habitante8 = new Habitante(14000000);
            Habitante habitante9 = new Habitante(15000000);
            Habitante habitante10 = new Habitante(16000000);
            Habitante habitante11 = new Habitante(500000);
            habitantes = new List<Habitante>();
            habitantes.Add(habitante);
            habitantes.Add(habitante1);
            habitantes.Add(habitante2);
            habitantes.Add(habitante3);
            habitantes.Add(habitante4);
            habitantes.Add(habitante5);
            habitantes.Add(habitante6);
            habitantes.Add(habitante7);
            habitantes.Add(habitante8);
            habitantes.Add(habitante9);
            habitantes.Add(habitante10);
            habitantes.Add(habitante11);
            ciudadGotica = new CiudadGotica(habitantes);
        }

        [Test]
        public void TestSaberSiBatmanEstaEstresadoYHacerloCombatir()
        {
            Assert.AreEqual(false, batman.estaEstresado());
            batman.combatirElCrimen(villanos);
        }
        [Test]
        public void TestSaberSiBatmanEstaALaModaBatmanBailaBatiTwistLosVillanosHacenMaldadesYSeMuestraLos10Top()
        {
            Assert.AreEqual(true, batman.estaALaModa());
            batman.bailarBatiTwist();
            villanos.ForEach(i => i.realizarMaldad());
            List<Habitante> losMasTop = ciudadGotica.sonLosMasTop();
            foreach (var i in losMasTop) Console.WriteLine(i.CantidadDeDinero);
        }
    }
}
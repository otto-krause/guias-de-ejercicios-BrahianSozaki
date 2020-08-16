using NUnit.Framework;
using Ejercicio;
using System.Collections.Generic;
namespace Testing
{
    public class Tests
    {
        private Arma bastonDeMetal;
        private Arma bombasDeHumo;
        private List<Arma> arsenalDeRobin;
        Robin RicardoTapia;
        ChicoBestia HulkJR;
        Raven raven;
        [SetUp]
        public void Setup()
        {
            bastonDeMetal = new Arma(15,10);
            bombasDeHumo = new Arma(14, 89);
            arsenalDeRobin = new List<Arma>();
            arsenalDeRobin.Add(bastonDeMetal);
            arsenalDeRobin.Add(bombasDeHumo);
            RicardoTapia = new Robin(arsenalDeRobin, 10);
            HulkJR = new ChicoBestia(2);
            raven = new Raven(2);
        }

        //Robin
        [Test]
        public void TestCalculoDeFibonacciDelBastonDeMetalEs610YLos10DeLaPotencia620()
        {
            Assert.AreEqual(610, bastonDeMetal.Fibonacci());
            Assert.AreEqual(620, bastonDeMetal.Fuerza());
        }
        [Test]
        public void TestHacerQueRobinLloréDosvecesPorRobocopYLuegoCalcularSuPoder()
        {
            RicardoTapia.llorarPorRobocop();
            RicardoTapia.llorarPorRobocop();
            Assert.AreEqual(598, RicardoTapia.poder());
        }

        //ChicoBestia
        [Test]
        public void TestHacerQueChicoBestiaComaPizzaYCalcularPoder()
        {
            HulkJR.comerPizza();
            Assert.AreEqual(871, HulkJR.poder());
        }
        [Test]
        public void TestChicoBestiaComePizzaYConocerSiElPoderDeRavenEsMayorAlDeLosDemásTitanes()
        {
            HulkJR.comerPizza();
            bool esMasFuerte = false;
            if (raven.poder() > HulkJR.poder() && raven.poder() > RicardoTapia.poder()) esMasFuerte = true;
            Assert.AreEqual(false, esMasFuerte);
        }

        [Test]
        public void TestNivelDeTristezaDeChicoBestia()
        {
            HulkJR.llorarPorRobocop();
            Assert.AreEqual(0, HulkJR.NivelDeTristeza());
        }

        //Raven
        [Test]
        public void TestRavenCome4PorcionesDePizzaYVemosSiEstaTriste()
        {
            raven.comerPizza();
            Assert.AreEqual(true, raven.estaTriste());
        }
        [Test]
        public void TestRivenLloraPorRobocopYVemosSiEstaTriste()
        {
            raven.llorarPorRobocop();
            Assert.AreEqual(false, raven.estaTriste());
        }
    }
}
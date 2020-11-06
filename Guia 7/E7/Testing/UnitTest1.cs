using NUnit.Framework;
using Ejercicio;
using System.Collections.Generic;
using System.Linq;

namespace Testing
{
    public class Tests
    {
        Arma ElDestructinadorDeMetal;
        Arma ElOtakuinador; //AguilarVersion. Patente pendiente
        Arma rayoCongelante;
        Minion Kevin;
        List<Minion> minions;
        List<string> objetos;
        Ciudad ciudad;
        Villano gru;
        
        [SetUp]
        public void Setup()
        {
            ElDestructinadorDeMetal = new Arma("El Destructinador De Metal", 20);
            rayoCongelante = new Arma("Rayo Congelante", 10);
            ElOtakuinador = new Arma("El Otakuinador", 100);
            Kevin = new Minion(rayoCongelante, 10, "Amarillo");
            minions = new List<Minion>{Kevin};
            objetos = new List<string>{"Piramides", "Suero Mutante", "La Luna"};
            ciudad = new Ciudad(24, objetos, 100);
            gru = new Villano(minions, ciudad);
        }

        [Test]
        public void TestCrearUnMinion_OtorgarleUnArmaAUnMinion_Alimentarlo_SaberSiEsPeligrosoYCantidadDeConcentracion()
        {
            gru.nuevoMinion();
            gru.otorgarArma(ElDestructinadorDeMetal);
            gru.otorgarArma(ElOtakuinador);
            gru.alimentar(10);
            Assert.AreEqual(true, Kevin.esPeligroso());
            Assert.AreEqual(120, Kevin.nivelDeConcentracion());
        }

        [Test]
        public void TestNoPoderRobarSueroMutanteYSaberCualEsElMinionMasUtil_Kevin()
        {
            Assert.Throws<System.Exception>(() => gru.robar("Suero Mutante"));
            Assert.AreEqual(Kevin, gru.minionMasUtil());
        }

        [Test]
        public void TestCambiarAKevinAVerde_NoEsPeligrosoYSuNivelDeConcentracionEs()
        {
            Kevin.seTransforma();
            Kevin.seTransforma();
            Kevin.esPeligroso();
            Assert.AreEqual(5, Kevin.nivelDeConcentracion());
        }
    }
}
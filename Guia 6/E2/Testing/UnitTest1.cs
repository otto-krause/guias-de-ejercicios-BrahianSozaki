using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;
namespace Testing
{
    public class Tests
    {
        List<int> ingredientes;
        List<Receta> receta;
        Mago HarryPostre;

        [SetUp]
        public void Setup()
        {
            ingredientes = new List<int>();
            ingredientes.Add(400);
            ingredientes.Add(400);
            ingredientes.Add(400);
            receta = new List<Receta>();
            receta.Add(new Receta(ingredientes, 3));
            receta.Add(new Receta(ingredientes, 3));
            HarryPostre = new Mago(receta);
        }

        [Test]
        public void TestVerSiTodasLasRecetasSonDeGordo()
        {
            Assert.AreEqual(false, receta.All(receta => receta.esDeGordo()));
        }
        [Test]
        public void TestVerSiAlgunaRecetaEsRapida()
        {
            Assert.AreEqual(true, receta.Any(receta => receta.esRapida()));
        }
        [Test]
        public void TestVerSiHarryEsLento()
        {
            Assert.AreEqual(false, HarryPostre.esUnLento());
        }
        [Test]
        public void TestVerSiHarryNoSeCuida()
        {
            Assert.AreEqual(false, HarryPostre.noSeCuida());
        }
    }
}
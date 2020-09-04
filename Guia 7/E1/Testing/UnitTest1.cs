using NUnit.Framework;
using Ejercicio;
using System.Collections.Generic;
namespace Testing
{
    public class Tests
    {
        MilesMorales Morales;
        PeterParker Parker;
        SpiderGwen Gwen;
        SpidermanNoir Noir;
        Kingpin kingpin;
        [SetUp]
        public void Setup()
        {
            Parker = new PeterParker(400, 400);
            Noir = new SpidermanNoir(20, 20, 2);
            Gwen = new SpiderGwen(10, 6);
            Morales = new MilesMorales(5, 20);
            kingpin = new Kingpin();
        }

        [Test]
        public void TestElPoderDePeterEs800()
        {
            Assert.AreEqual(800, Parker.poder());
        }
        [Test]
        public void TestElPoderDeNoirEs42()
        {
            Assert.AreEqual(42, Noir.poder());
        }
        [Test]
        public void TestElPoderDeGwenEs16()
        {
            Assert.AreEqual(16, Gwen.poder());
        }
        
        [Test]
        public void TestElGlamourDeGwenSeSaleDeRango()
        {
            SpiderGwen gwen2 = new SpiderGwen(11, 20);
            Assert.Throws<System.Exception>(() => gwen2.poder());

        }
        
        [Test]
        public void TestElPoderDeMilesEs25()
        {
            Assert.AreEqual(25, Morales.poder());
        }

        [Test]
        public void TestKingpinNoFueDerrotado()
        {
            Assert.AreEqual(false, kingpin.fueVencido());
        }
        [Test]
        public void TestKingpinFueDerrotado()
        {
            Parker.atacar(kingpin);
            Assert.AreEqual(true, kingpin.fueVencido());
        }
        
    }
}
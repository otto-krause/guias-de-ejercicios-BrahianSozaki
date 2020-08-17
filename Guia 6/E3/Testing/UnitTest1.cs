using NUnit.Framework;
using System.Collections.Generic;
using Ejercicio;
namespace Testing
{
    public class Tests
    {
        Sables sableDeLuz;
        Blasters blasterGastado;
        Sables katana;
        List<Arma> armasDeZero;
        Mavericks roberto;
        Mavericks carlos;
        List<Mavericks> mavericks;
        Zero zero;

        [SetUp]
        public void Setup()
        {
            sableDeLuz = new Sables(100, 0, 1);
            blasterGastado = new Blasters(300, 0, 70);
            katana = new Sables(55, 0, 2);
            armasDeZero = new List<Arma>();
            armasDeZero.Add(sableDeLuz);
            armasDeZero.Add(blasterGastado);
            armasDeZero.Add(katana);
            roberto = new Mavericks(sableDeLuz, 20);
            carlos = new Mavericks(katana, 100);
            mavericks = new List<Mavericks>();
            mavericks.Add(roberto);
            mavericks.Add(carlos);
            zero = new Zero(armasDeZero);
        }

        [Test]
        public void TestElPoderDelSableDeLuzEs200()
        {
            Assert.AreEqual(200, sableDeLuz.poder());
        }
        [Test]
        public void TestElPoderDelBlasterGastadoEs230()
        {
            Assert.AreEqual(230, blasterGastado.poder());
        }
        [Test]
        public void TestElPoderDeLaKatanaEs220()
        {
            Assert.AreEqual(220, katana.poder());
        }
        [Test]
        public void TestComprobarSiElArmaMasPolentosaEsElBlasterGastadoYTambienElPoderDeZeroEsDe230()
        {
            Assert.AreEqual(blasterGastado, zero.laMasPolentosa());
            Assert.AreEqual(230, zero.poder());
        }
        [Test]
        public void TestComprobarQueZeroLeGanaARoberto()
        {
            Assert.AreEqual(true, zero.loPuedeVencer(roberto));
        }
        [Test]
        public void TestComprobarQueZeroNoLeGanaACarlos()
        {
            Assert.AreEqual(false, zero.loPuedeVencer(carlos));
        }
        [Test]
        public void TestComprobarQueZeroNoLesGanaALosMavericks()
        {
            Assert.AreEqual(false, zero.losPuedeVencer(mavericks));
        }
    }
}
using NUnit.Framework;
using Ejercicio;
using System.Collections.Generic;
namespace Testing
{
    public class Tests
    {
        Niño niño;
        Niño otroNiño;
        Niño niño2;
        Niño niño3;
        List<Niño> legion1;
        List<Niño> legion2;
        AdultosComunes adultoComun;

        [SetUp]
        public void Setup()
        {
            niño = new Niño(5, true);
            otroNiño = new Niño(2, false);
            niño2 = new Niño(7, true);
            niño3 = new Niño(2, true);

            legion1 = new List<Niño>();
            legion2 = new List<Niño>();

            legion1.Add(niño);
            legion1.Add(otroNiño);

            legion2.Add(niño2);
            legion2.Add(niño3);

            adultoComun = new AdultosComunes();
        }

        [Test]
        public void TestCapacidadDeAsustarDeUnNiño()
        {
            Assert.AreEqual(40, niño.capacidadDeSusto());
            //Assert.Throws<System.Exception>(() => niño.capacidadDeSusto());
        }

        [Test]
        public void TestHacerQueUnNiñoAsusteObtieneCaramelosYSeLosCome()
        {
            niño.asustar(adultoComun);
            niño.comerCaramelos(1);
        }
        [Test]
        public void TestLaCreacionNoFallaLaLegionAsustaAUnaPersonaYLaLegionAñadeIntegrantes()
        {
            Assert.True(legion1.Count >= 2);
            Legion legion = new Legion(legion1);
            legion.asustar(adultoComun);
            legion.añadirIntegrantes(legion2);
        }
        [Test]
        public void TestHacerQueUnNiñoComaYRevisarSuActitud()
        {
            Assert.AreEqual(5, niño.ActitudDelNiño);
            niño.comerCaramelos(10);
            Assert.AreEqual(2, niño.ActitudDelNiño);
            niño.comerCaramelos(10);
            Assert.AreEqual(0, niño.ActitudDelNiño);
        }

    }
}
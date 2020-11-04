using NUnit.Framework;
using Ejercicio;
using System.Collections.Generic;
using System.Linq;

namespace Testing
{
    public class Tests
    {
        Heroe AllMight;
        Quirk OFA;
        Heroe ArturoMirodilla;
        Quirk PiroQuinesis;
        Villano GentleCriminal;
        Quirk Elasticity;
        Villano laBrava;
        Quirk Love;
        Heroe Endeavor;
        Quirk HellFlame;
        List<Villano> youtubers;
        Pandilla youtuberos;

        [SetUp]
        public void Setup()
        {
            OFA = new Quirk(180, false, "One For All");
            AllMight = new Heroe(OFA);
            HellFlame = new Quirk(300, false, "HellFlame");
            Endeavor = new Heroe(HellFlame);
            PiroQuinesis = new Quirk(300, false, "PiroQuinesis");
            ArturoMirodilla = new Heroe(OFA);

            Elasticity = new Quirk(60, false, "Elasticity");
            GentleCriminal = new Villano(true, false, false, Elasticity);
            Love = new Quirk(60, false, "Love");
            laBrava = new Villano(false, true, false, Love);
            youtubers = new List<Villano>{laBrava, GentleCriminal};
            youtuberos = new Pandilla(youtubers);
        }

        [Test]
        public void TestPoderDeAllMightYEsPeligroso()
        {
            Assert.AreEqual(1980, AllMight.poder());
            Assert.True(AllMight.esPeligroso());
        }
        [Test]
        public void TestElVillanoEsMuyMaloYAlgunaVezFueBueno()
        {
            Assert.False(GentleCriminal.esMuyMalo());
            Assert.True(GentleCriminal.algunaVezFueBueno());
        }
        [Test]
        public void TestEndeavorPeleaContraUnVillanoYLuegoContraUnaPandilla()
        {
            Endeavor.pelearContraVillano(GentleCriminal);
            Assert.AreEqual(1, Endeavor.ContadorDeVictorias);
            Endeavor.pelearContraPandilla(youtuberos);
            Assert.AreEqual(2, Endeavor.ContadorDeVictorias);
        }

        [Test]
        public void TestElQuirkDeEndeavorEsPeligroso()
        {
            Assert.True(Endeavor.esPeligroso());
        }

        [Test]
        public void Test()
        {
            OneForAll ofa = new OneForAll(AllMight);
            ofa.cambiarPortador(ArturoMirodilla);
            Assert.AreEqual(2, ArturoMirodilla.Quirks.Count());

            Heroe portadorAleatorio = new Heroe(PiroQuinesis);
            ofa.cambiarPortador(portadorAleatorio);
            Assert.AreEqual(1, ArturoMirodilla.Quirks.Count());
        }

    }
}
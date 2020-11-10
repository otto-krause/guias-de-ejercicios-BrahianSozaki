using NUnit.Framework;
using Ejercicio;
using System.Collections.Generic;
using System.Linq;
using System;

namespace Testing
{
    public class Tests
    {
        Riley riley;
        Recuerdo recuerdo;
        Recuerdo recuerdo1;
        List<Recuerdo> recuerdosCentrales;

        DateTime fecha;
        [SetUp]
        public void Setup()
        {
            fecha = new DateTime(2009, 02, 26);
            recuerdo = new Recuerdo("Comi torta", fecha, "Alegre");
            fecha = new DateTime(2017, 05, 30);
            recuerdo1 = new Recuerdo("Murio sora en Kingdom Hearts", fecha, "Triste");
            recuerdosCentrales = new List<Recuerdo>{recuerdo, recuerdo1};//Agregado para probar que salga 1 recuerdo central dificl solamente
            riley = new Riley("Alegre", recuerdosCentrales);
        }

        [Test]
        public void TestRileyViveUnEvento_AsientoElRecuerdoYComprueboLosMasdificiles()
        {
            fecha = new DateTime(2010, 10, 12);
            riley.agregarEvento("Me cai de la bicicleta y llore mucho tiempo en el piso por el dolor", fecha, "Triste");
            riley.agregarEvento("Me cai de la bicicleta y llore mucho tiempo en el piso por el dolor", fecha, "Triste");
            riley.asentarRecuerdo();
            Assert.AreEqual(1, riley.recuerdosDificles().Count());
        }

        [Test]
        public void TestSaberSiRileyNiegaUnRecuerdoDa1YMandarARileyADormir()
        {
            fecha = new DateTime(2010, 10, 12);
            riley.agregarEvento("Me cai de la bicicleta y llore mucho tiempo en el piso por el dolor", fecha, "Triste");
            Assert.AreEqual(1, riley.negarRecuerdo().Count());
            riley.dormir("Llore");
        }

        

    }
}
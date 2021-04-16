using Microsoft.VisualStudio.TestTools.UnitTesting;
using Cykel;
using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;

namespace Cykel.Tests
{
    [TestClass()]
    public class CykelTests
    {


        [TestMethod()]
        public void CykelVariablerErSatTest()
        {
            // Jeg begyndte at få fejl i unitTest da jeg lavede dette projekt, og kunne ikke få det til at virke ud 'NUnit.Framework.' foran Assert.
            Cykel nyCykel = new Cykel("cykelnavn", 749, "City Bike", 7);
            NUnit.Framework.Assert.That(nyCykel.Navn == "cykelnavn");
            NUnit.Framework.Assert.That(nyCykel.Pris == 749);
            NUnit.Framework.Assert.That(nyCykel.Type == "City Bike");
            NUnit.Framework.Assert.That(nyCykel.Gear == 7);
        }

        [TestMethod()]
        public void opretNyCykelTest()
        {
            Cykel nyCykel = new Cykel("cykelnavn", 749, "City Bike", 7);
            List<Cykel> cykelInventar = new List<Cykel>();
            cykelInventar.Add(nyCykel);
            NUnit.Framework.Assert.That(cykelInventar[0] == nyCykel);
        }

        [TestMethod()]
        public void sletCykelTest()
        {
            Cykel nyCykel = new Cykel("cykelnavn", 749, "City Bike", 7);
            Cykel nyCykel2 = new Cykel("BMX", 1000, "BMX", 0);
            List<Cykel> cykelInventar = new List<Cykel>();
            cykelInventar.Add(nyCykel);
            cykelInventar.Add(nyCykel2);
            //Console.WriteLine(cykelInventar[0].Navn);
            NUnit.Framework.Assert.That(cykelInventar[0] == nyCykel);
            cykelInventar.RemoveAt(0);
            //Console.WriteLine(cykelInventar[0].Navn);
            NUnit.Framework.Assert.That(cykelInventar[0] != nyCykel);
        }

        [TestMethod()]
        public void opdaterCykelTest()
        {
            Cykel nyCykel = new Cykel("Dame cykel", 749, "City Bike", 7);
            Cykel nyCykel2 = new Cykel("BMX", 1000, "BMX", 0);
            List<Cykel> cykelInventar = new List<Cykel>();
            cykelInventar.Add(nyCykel);
            cykelInventar.Add(nyCykel2);
            NUnit.Framework.Assert.That(cykelInventar[0] == nyCykel);
            Console.WriteLine(cykelInventar[0].Pris);
            cykelInventar.RemoveAt(0);
            Cykel opdateretCykel = new Cykel("Dame cykel", 827, "City Bike", 7);
            cykelInventar.Insert(0, opdateretCykel);
            NUnit.Framework.Assert.That(cykelInventar[0].Pris != nyCykel.Pris);
            Console.WriteLine(cykelInventar[0].Pris);
        }

        [TestMethod()]
        public void HentInventarTest()
        {
            Cykel nyCykel = new Cykel("Dame cykel", 749, "City Bike", 7);
            Cykel nyCykel2 = new Cykel("BMX", 1000, "BMX", 0);
            List<Cykel> cykelInventar = new List<Cykel>();
            cykelInventar.Add(nyCykel);
            cykelInventar.Add(nyCykel2);

            Cykel[] cykelInventar2 = new Cykel[cykelInventar.Count];
            for (int i = 0; i < cykelInventar2.Length; i++)
            {
                cykelInventar2[i] = cykelInventar[i];
            }
            NUnit.Framework.Assert.That(cykelInventar[0].Pris == cykelInventar2[0].Pris);
        }
    }
}
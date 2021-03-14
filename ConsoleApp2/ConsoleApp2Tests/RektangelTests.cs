using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleApp2;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2.Tests
{
    [TestClass()]
    public class RektangelTests
    {
        [TestMethod()]
        public void AreaTest()
        {
            Assert.AreEqual(Rektangel.Area(5, 10), 50);
        }

        [TestMethod()]
        public void OmkretsTest()
        {
            Assert.AreEqual(Rektangel.Omkrets(5, 10), 30);
        }

        [TestMethod()]
        public void KvadratTest()
        {
            Assert.AreEqual(Rektangel.Kvadrat(5), 25);
        }
    }
}
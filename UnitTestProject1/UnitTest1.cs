using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestesTriangulo;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        

        [TestMethod]
        public void TestMethod1()
        {
            teste tiposTriangulos = new teste();

            string expectedResult = tiposTriangulos.calculo(0, 0, 0);
            Assert.AreEqual(expectedResult,("INEXISTENTE"));
        }
        [TestMethod]
        public void TestMethod2()
        {
            teste tiposTriangulos = new teste();

            string expectedResult = tiposTriangulos.calculo(1, 2, 3);
            Assert.AreEqual(expectedResult, ("INEXISTENTE"));
        }
        [TestMethod]
        public void TestMethod3()
        {
            teste tiposTriangulos = new teste();

            string expectedResult = tiposTriangulos.calculo(1, 1, 1);
            Assert.AreEqual(expectedResult, ("EQUILATERO"));
        }

        [TestMethod]
        public void TestMethod4()
        {
            teste tiposTriangulos = new teste();

            string expectedResult = tiposTriangulos.calculo(1, 2, 2);
            Assert.AreEqual(expectedResult, ("ISOCELES"));
        }

        [TestMethod]
        public void TestMethod5()
        {
            teste tiposTriangulos = new teste();

            string expectedResult = tiposTriangulos.calculo(2, 2, 1);
            Assert.AreEqual(expectedResult, ("ISOCELES"));
        }

        [TestMethod]
        public void TestMethod6()
        {
            teste tiposTriangulos = new teste();

            string expectedResult = tiposTriangulos.calculo(2, 3, 4);
            Assert.AreEqual(expectedResult, ("ESCALENO"));
        }

    }
}

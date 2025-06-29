using Microsoft.VisualStudio.TestTools.UnitTesting;
using Math.Lib;
namespace Math.Tests
{
    [TestClass]
    public class RooterTests
    {

        [TestMethod]
        public void TestMethod1()
        {
        }

        [TestMethod]
        public void BasicRooterTest()
        {
            Rooter rooter = new Rooter();
            double expectedResult = 2.0;
            double input = expectedResult * expectedResult;
            double actualResult = rooter.SquareRoot(input);
            Assert.AreEqual(expectedResult, actualResult, delta: expectedResult / 100);
        }

        [TestMethod]
        public void RooterValueRange()
        {
            Rooter rooter = new Rooter();
            for (double expected = 1e-8; expected < 1e+8; expected *= 3.2)
                RooterOneValue(rooter, expected);
        }
        private void RooterOneValue(Rooter rooter, double expectedResult)
        {
            double input = expectedResult * expectedResult;
            double actualResult = rooter.SquareRoot(input);
            Assert.AreEqual(expectedResult, actualResult, delta: expectedResult / 1000);
        }

        [TestMethod]
        public void RooterTestNegativeInputx()
        {
            Rooter rooter = new Rooter();
            try
            {
                rooter.SquareRoot(-10);
            }
            catch (System.ArgumentOutOfRangeException)
            {
                return;
            }
            Assert.Fail();
        }

        //activdad 1 
        [TestMethod]
        public void RooterTestNegativeInputxWithMessage()
        {
            Rooter rooter = new Rooter();
            try
            {
                rooter.SquareRoot(-10);
                Assert.Fail("Se esperaba una excepcion ArgumentOutOfRangeException");
            }
            catch (System.ArgumentOutOfRangeException ex)
            {
                StringAssert.Contains(ex.Message, "El valor ingresado es invalido, solo se puede ingresar números positivos");
                // Assert.AreEqual("El valor ingresado es invalido, solo se puede ingresar números positivos", ex.Message);
                return;
            }
            // Assert.Fail();
        }        

    }
}
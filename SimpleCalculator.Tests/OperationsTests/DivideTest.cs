using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SimpleCalculator.Operations;

namespace SimpleCalculator.Tests
{
    [TestClass]
    public class DivideTest
    {
        [TestMethod]
        public void EnsureFourDividedbyTwo()
        {
            DivideNumber dividenumber = new DivideNumber();
            int expectedResult = 2;
            int actualResult = dividenumber.DivideStuff(4, 2);
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}

using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SimpleCalculator.Operations;

namespace SimpleCalculator.Tests
{
    [TestClass]
    public class SubTest
    {
        [TestMethod]
        public void EnsureTenMinusOne()
        {
            SubtractNumber subtractnumber = new SubtractNumber();
            int expectedResult = 9;
            int actualResult = subtractnumber.SubtractStuff(10, 1);
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}

using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SimpleCalculator.Operations;

namespace SimpleCalculator.Tests
{
    [TestClass]
    public class MultiTest
    {
        [TestMethod]
        public void EnsureTenMultiplyOne()
        {
            MultiplyNumber multiplynumber = new MultiplyNumber();
            int expectedResult = 10;
            int actualResult = multiplynumber.MultiplyStuff(10, 1);
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}

using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SimpleCalculator.Operations;

namespace SimpleCalculator.Tests
{
    [TestClass]
    public class AddTest
    {
        [TestMethod]
        public void EnsureOnePlusOne()
        {
            AddNumber addnumber = new AddNumber();
            int expectedResult = 2;
            int actualResult = addnumber.AddStuff(1, 1);
            Assert.AreEqual(expectedResult, actualResult);

        }
    }
}

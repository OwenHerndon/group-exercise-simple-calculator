using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SimpleCalculator.Constants;

namespace SimpleCalculatorTests.ConstantsTests
{
    [TestClass]
    public class ConstantsTest
    {
        [TestMethod]
        public void ConstantsInstance()
        {
            Constants constant = new Constants();
            Assert.IsNotNull(constant);
        }
    }
}

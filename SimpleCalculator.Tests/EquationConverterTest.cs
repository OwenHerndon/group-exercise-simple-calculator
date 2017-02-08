using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SimpleCalculator.Tests
{
    [TestClass]
    public class EquationConverterTest
    {
        //[TestMethod]
        //public void EnsureMathRouter()
        //{
        //    EquationConverter equationCoverter = new EquationConverter();
        //    int expectedResult = 5;
        //    int actualResult = equationCoverter.MathRouter(3, '+', 2);
        //    Assert.AreEqual(expectedResult, actualResult);
        //}

        [TestMethod]
        public void EnsureMathRouter()
        {
            EquationConverter equationConverter = new EquationConverter();
            int expectedResult = 4;
            int actualResult = equationConverter.MathRouter("5", "-", "1");
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void EnsureLastAnswer()
        {
            EquationConverter equationConverter = new EquationConverter();
            int expectedResult = 6;
            int actualResult = equationConverter.LastAnswer(6);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void EnsureLastQuestionReturnsString()
        {
            EquationConverter equationConverter = new EquationConverter();
            string expectedResult = "1 + 1";
            string actualResult = equationConverter.LastQuestion("1 + 1");
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}

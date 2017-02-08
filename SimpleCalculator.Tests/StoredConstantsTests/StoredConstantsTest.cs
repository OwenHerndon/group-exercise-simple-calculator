using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SimpleCalculator.StoredConstants;
using System.Collections.Generic;

namespace SimpleCalculatorTests
{
    [TestClass]
    public class StoredConstantsTest
    {
        [TestMethod]
        public void EnsureValueCanBeStored()
        {
            StoredConstants constants = new StoredConstants();

            Dictionary<char, int> expectedDictionary = new Dictionary<char, int>();
            expectedDictionary.Add('c', 21);

            Dictionary<char, int> actualDictionary = constants.AddConstantsToDictionary('c', 21);
            CollectionAssert.AreEqual(expectedDictionary, actualDictionary);
        }
    }
}
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RomanParserFW;

namespace Test
{
    [TestClass]
    public class UnitTestConversionTable
    {
        [TestMethod]
        public void BorderMinValue()
        {
            var table = new ConversionTable();
            string result = table.GetSymbolOf(1);
            string expectedSymbol = "I";
            Assert.AreEqual(result, expectedSymbol);
        }

        [TestMethod]
        public void BorderMaxValue()
        {
            var table = new ConversionTable();
            string result = table.GetSymbolOf(1000);
            string expectedSymbol = "M";
            Assert.AreEqual(result, expectedSymbol);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void OutOfRange()
        {
            var table = new ConversionTable();
            string result = table.GetSymbolOf(0);
        }
    }
}

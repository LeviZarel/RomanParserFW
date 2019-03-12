using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RomanParserFW;

namespace Test
{
    [TestClass]
    public class UnitTestRomanBuilder
    {
        [TestMethod]
        public void OneDigit()
        {
            var builder = new RomanBuilder();
            RomanNumber result = builder.GetRomanNumber(9);
            var expectedSymbol = "IX";
            Assert.AreEqual(result.Symbol, expectedSymbol);
        }

        [TestMethod]
        public void TwoDigits()
        {
            var builder = new RomanBuilder();
            RomanNumber result = builder.GetRomanNumber(98);
            var expectedSymbol = "XCVIII";
            Assert.AreEqual(result.Symbol, expectedSymbol);
        }

        [TestMethod]
        public void ThreeDigits()
        {
            var builder = new RomanBuilder();
            RomanNumber result = builder.GetRomanNumber(176);
            var expectedSymbol = "CLXXVI";
            Assert.AreEqual(result.Symbol, expectedSymbol);
        }

        [TestMethod]
        public void FourDigits()
        {
            var builder = new RomanBuilder();
            RomanNumber result = builder.GetRomanNumber(2194);
            var expectedSymbol = "MMCXCIV";
            Assert.AreEqual(result.Symbol, expectedSymbol);
        }

        [TestMethod]
        public void BorderMin()
        {
            var builder = new RomanBuilder();
            RomanNumber result = builder.GetRomanNumber(1);
            var expectedSymbol = "I";
            Assert.AreEqual(result.Symbol, expectedSymbol);
        }

        [TestMethod]
        public void BorderMax()
        {
            var builder = new RomanBuilder();
            RomanNumber result = builder.GetRomanNumber(3999);
            var expectedSymbol = "MMMCMXCIX";
            Assert.AreEqual(result.Symbol, expectedSymbol);
        }

        [TestMethod]
        public void ValueZero()
        {
            var builder = new RomanBuilder();
            RomanNumber result = builder.GetRomanNumber(0);
            var expectedSymbol = "";
            Assert.AreEqual(result.Symbol, expectedSymbol);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void OutOfRangeMin()
        {
            var builder = new RomanBuilder();
            RomanNumber result = builder.GetRomanNumber(-1);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void OutOfRangeMax()
        {
            var builder = new RomanBuilder();
            RomanNumber result = builder.GetRomanNumber(4000);
        }

        [TestMethod]
        public void SendValueFalseInToUpperCase()
        {
            var uppeCaseValue = ConfigReader.GetValueBoolOf("upperCase", false);
            var builder = new RomanBuilder();
            RomanNumber result = builder.GetRomanNumber(666);
            var expectedSymbol = "dclxvi";
            Assert.AreEqual(result.GetSymbol(uppeCaseValue), expectedSymbol);
        }

        [TestMethod]
        public void SendValueTrueInToUpperCase()
        {
            var uppeCaseValue = ConfigReader.GetValueBoolOf("upperCase", true);
            var builder = new RomanBuilder();
            RomanNumber result = builder.GetRomanNumber(777);
            var expectedSymbol = "DCCLXXVII";
            Assert.AreEqual(result.GetSymbol(uppeCaseValue), expectedSymbol);
        }

        [TestMethod]
        public void SendDefaultValueInToUpperCase()
        {
            var uppeCaseValue = ConfigReader.GetValueBoolOf("upperCase");
            var builder = new RomanBuilder();
            RomanNumber result = builder.GetRomanNumber(123);
            var expectedSymbol = "CXXIII";
            Assert.AreEqual(result.GetSymbol(uppeCaseValue), expectedSymbol);
        }
    }
}

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
        public void One_Digit()
        {
            var builder = new RomanBuilder();
            RomanNumber result = builder.GetRomanNumber(9);
            var expectedSymbol = "IX";
            Assert.AreEqual(result.Symbol, expectedSymbol);
        }

        [TestMethod]
        public void Two_Digits()
        {
            var builder = new RomanBuilder();
            RomanNumber result = builder.GetRomanNumber(98);
            var expectedSymbol = "XCVIII";
            Assert.AreEqual(result.Symbol, expectedSymbol);
        }

        [TestMethod]
        public void Three_Digits()
        {
            var builder = new RomanBuilder();
            RomanNumber result = builder.GetRomanNumber(176);
            var expectedSymbol = "CLXXVI";
            Assert.AreEqual(result.Symbol, expectedSymbol);
        }

        [TestMethod]
        public void Four_Digits()
        {
            var builder = new RomanBuilder();
            RomanNumber result = builder.GetRomanNumber(2194);
            var expectedSymbol = "MMCXCIV";
            Assert.AreEqual(result.Symbol, expectedSymbol);
        }

        [TestMethod]
        public void Border_Min()
        {
            var builder = new RomanBuilder();
            RomanNumber result = builder.GetRomanNumber(1);
            var expectedSymbol = "I";
            Assert.AreEqual(result.Symbol, expectedSymbol);
        }

        [TestMethod]
        public void Border_Max()
        {
            var builder = new RomanBuilder();
            RomanNumber result = builder.GetRomanNumber(3999);
            var expectedSymbol = "MMMCMXCIX";
            Assert.AreEqual(result.Symbol, expectedSymbol);
        }

        [TestMethod]
        public void Value_Zero()
        {
            var builder = new RomanBuilder();
            RomanNumber result = builder.GetRomanNumber(0);
            var expectedSymbol = "";
            Assert.AreEqual(result.Symbol, expectedSymbol);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Out_Of_Range_Min()
        {
            var builder = new RomanBuilder();
            RomanNumber result = builder.GetRomanNumber(-1);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Out_Of_Range_Max()
        {
            var builder = new RomanBuilder();
            RomanNumber result = builder.GetRomanNumber(4000);
        }

        [TestMethod]
        public void Send_Value_False_Of_UpperCase_In_RomanConfig()
        {
            var config = new RomanConfig();
            config.UpperCase = false;
            var builder = new RomanBuilder(config);
            RomanNumber result = builder.GetRomanNumber(666);
            var expectedSymbol = "dclxvi";
            Assert.AreEqual(result.Symbol, expectedSymbol);
        }

        [TestMethod]
        public void Send_Value_True_Of_UpperCase_In_RomanConfig()
        {
            var config = new RomanConfig();
            config.UpperCase = true;
            var builder = new RomanBuilder(config);
            RomanNumber result = builder.GetRomanNumber(777);
            var expectedSymbol = "DCCLXXVII";
            Assert.AreEqual(result.Symbol, expectedSymbol);
        }

        [TestMethod]
        public void Send_Value_True_Of_ExtraCharacters_In_RomanConfig()
        {
            var config = new RomanConfig();
            config.ExtraCharacters = true;
            var builder = new RomanBuilder(config);
            RomanNumber result = builder.GetRomanNumber(123);
            var expectedSymbol = "[CXXIII]";
            Assert.AreEqual(result.Symbol, expectedSymbol);
        }

        [TestMethod]
        public void Send_Value_False_Of_ExtraCharacters_In_RomanConfig()
        {
            var config = new RomanConfig();
            config.ExtraCharacters = false;
            var builder = new RomanBuilder(config);
            RomanNumber result = builder.GetRomanNumber(123);
            var expectedSymbol = "CXXIII";
            Assert.AreEqual(result.Symbol, expectedSymbol);
        }

        [TestMethod]
        public void Send_Value_True_On_ExtraCharacters_And_Value_False_Of_UpperCase_In_RomanConfig()
        {
            var config = new RomanConfig();
            config.ExtraCharacters = true;
            config.UpperCase = false;
            var builder = new RomanBuilder(config);
            RomanNumber result = builder.GetRomanNumber(123);
            var expectedSymbol = "[cxxiii]";
            Assert.AreEqual(result.Symbol, expectedSymbol);
        }

        [TestMethod]
        public void Sende_Default_Values_In_RomanConfig()
        {
            var config = new RomanConfig();
            var builder = new RomanBuilder(config);
            RomanNumber result = builder.GetRomanNumber(444);
            var expectedSymbol = "CDXLIV";
            Assert.AreEqual(result.Symbol, expectedSymbol);
        }

        [TestMethod]
        public void Send_True_ExtraCharacters_And_UperCase_False_And_Open_An_Close_Of_Character_In_RomanConfig()
        {
            var config = new RomanConfig();
            config.ExtraCharacters = true;
            config.UpperCase = false;
            config.CharacterOpen = "{";
            config.CharacterClose = "}";
            var builder = new RomanBuilder(config);
            RomanNumber result = builder.GetRomanNumber(123);
            var expectedSymbol = "{cxxiii}";
            Assert.AreEqual(result.Symbol, expectedSymbol);
        }
    }
}

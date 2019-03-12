using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RomanParserFW
{
    public class RomanBuilder
    {
        private string OutOfRangeMesagge = "Insert number in range 1 and 3999";
        private Parser MyParser;
        private RomanConfig MyConfig;

        public RomanBuilder()
        {
            MyParser = new Parser();
            MyConfig = new RomanConfig();
        }
        public RomanBuilder(RomanConfig myConfig)
        {
            MyParser = new Parser();
            MyConfig = myConfig;
        }

        private string BuildRomanNumber(int number)
        {
            if (number < 0 || number > 3999)
                throw new ArgumentOutOfRangeException(OutOfRangeMesagge);
            if (number >= 1000)
                return MyParser.GetItem(1000) + BuildRomanNumber(number - 1000);
            if (number >= 900)
                return MyParser.GetItem(900) + BuildRomanNumber(number - 900);
            if (number >= 500)
                return MyParser.GetItem(500) + BuildRomanNumber(number - 500);
            if (number >= 400)
                return MyParser.GetItem(400) + BuildRomanNumber(number - 400);
            if (number >= 100)
                return MyParser.GetItem(100) + BuildRomanNumber(number - 100);
            if (number >= 90)
                return MyParser.GetItem(90) + BuildRomanNumber(number - 90);
            if (number >= 50)
                return MyParser.GetItem(50) + BuildRomanNumber(number - 50);
            if (number >= 40)
                return MyParser.GetItem(40) + BuildRomanNumber(number - 40);
            if (number >= 10)
                return MyParser.GetItem(10) + BuildRomanNumber(number - 10);
            if (number >= 9)
                return MyParser.GetItem(9) + BuildRomanNumber(number - 9);
            if (number >= 5)
                return MyParser.GetItem(5) + BuildRomanNumber(number - 5);
            if (number >= 4)
                return MyParser.GetItem(4) + BuildRomanNumber(number - 4);
            if (number >= 1)
                return MyParser.GetItem(1) + BuildRomanNumber(number - 1);
            else
                return "";
        }

        public RomanNumber GetRomanNumber(int number)
        {
            string symbol = BuildRomanNumber(number);
            if (!MyConfig.UpperCase)
            {
                symbol = symbol.ToLower();
            }
            if (MyConfig.Bracket)
            {
                symbol = $"[{symbol}]";
            }
            return new RomanNumber(number, symbol);
        }
    }
}

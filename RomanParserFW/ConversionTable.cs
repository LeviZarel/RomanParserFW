using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RomanParserFW
{
    public class ConversionTable
    {
        private string InvalidValueMesagge = "Number not exist in Table";
        private List<RomanNumber> Table;
        public ConversionTable()
        {
            Table = new List<RomanNumber>
            {
                new RomanNumber(1000, "M"),
                new RomanNumber(900, "CM"),
                new RomanNumber(500, "D"),
                new RomanNumber(400, "CD"),
                new RomanNumber(100, "C"),
                new RomanNumber(90, "XC"),
                new RomanNumber(50, "L"),
                new RomanNumber(40, "XL"),
                new RomanNumber(10, "X"),
                new RomanNumber(9, "IX"),
                new RomanNumber(5, "V"),
                new RomanNumber(4, "IV"),
                new RomanNumber(1, "I")
            };
        }
        public string GetSymbolOf(int number)
        {
            foreach (var romanNumber in Table)
            {
                if (number == romanNumber.Value)
                    return romanNumber.Symbol;
            }
            throw new ArgumentException(InvalidValueMesagge);
        }
    }
}

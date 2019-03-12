using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RomanParserFW
{
    public class RomanNumber
    {
        public int Value { get; private set; }
        public string Symbol { get; private set; }
        public RomanNumber(int value, string symbol)
        {
            Value = value;
            Symbol = symbol;
        }
        public string GetSymbol(bool upperCase=true)
        {
            if (!upperCase)
                return Symbol.ToLower();
            return Symbol;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RomanParserFW
{
    public class Parser
    {
        private ConversionTable Table;
        public Parser()
        {
            Table = new ConversionTable();
        }
        public string GetItem(int value)
        {
            return Table.GetSymbolOf(value);
        }
    }
}

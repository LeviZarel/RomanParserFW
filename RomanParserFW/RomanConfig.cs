using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RomanParserFW
{
    public class RomanConfig
    {
        public bool UpperCase { get; set; }
        public bool Bracket { get; set; }
        
        public RomanConfig()
        {
            UpperCase = true;
            Bracket = false;
        }
    }
}

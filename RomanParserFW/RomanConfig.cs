using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RomanParserFW
{
    public class RomanConfig
    {
        public bool UpperCase { get; set; } = true;
        public bool ExtraCharacters { get; set; } = false;
        public string CharacterOpen { get; set; } = "[";
        public string CharacterClose { get; set; } = "]";

    }
}

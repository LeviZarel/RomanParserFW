using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;


namespace RomanParserFW
{
    public class Program
    {
        static void Main(string[] args)
        {
            RomanConfig config = new RomanConfig();
            config.UpperCase = ConfigReader.GetValueBoolOf("upperCase");
            config.ExtraCharacters = ConfigReader.GetValueBoolOf("extraCharacters");
            config.CharacterOpen = ConfigReader.GetValueStringOf("characterOpen");
            config.CharacterClose = ConfigReader.GetValueStringOf("characterClose");
            RomanBuilder builder = new RomanBuilder(config);
            for (int i = 0; i < 10; i++)
            {
                Console.Write("enter number: ");
                var input = Console.ReadLine();
                var romanNumber = builder.GetRomanNumber(int.Parse(input));
                Console.WriteLine($"number {input} in roman is {romanNumber.Symbol}");
            }
        }
        
    }
}

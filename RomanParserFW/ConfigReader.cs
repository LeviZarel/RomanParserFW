using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;


namespace RomanParserFW
{
    
    public class ConfigReader
    {
        public static bool GetValueBoolOf(string Key, bool DefaultValue=true)
        {
            string value = ConfigurationManager.AppSettings[Key];
            if (!string.IsNullOrEmpty(value))
            {
                return Convert.ToBoolean(value);
            }
            return DefaultValue;
        }
        public static string GetValueStringOf(string Key, string DefaultValue = "")
        {
            string value = ConfigurationManager.AppSettings[Key];
            if (!string.IsNullOrEmpty(value))
            {
                return value;
            }
            return DefaultValue;
        }
    }
}

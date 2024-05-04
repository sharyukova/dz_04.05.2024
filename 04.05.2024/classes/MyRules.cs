using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _04._05._2024
{
    internal class MyRules
    {
        public static string ReplaceE(string text)
        {
            

            text = text.Replace("ё", "е");

            return text; 
        }
    }
}

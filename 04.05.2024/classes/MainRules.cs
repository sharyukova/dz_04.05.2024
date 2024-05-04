using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _04._05._2024
{
    public class MainRules
    {
        /// <summary>
        /// Правильно расставляет пробелы со знаками препинания
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        public static string CorrectPunctuationSpaces(string text)
        {
            Regex pointRegex = new Regex(@"\s*\.\s*");
            Regex comaRegex = new Regex(@"\s*\,\s*");
            Regex qstnMarkRegex = new Regex(@"\s*\?\s*");
            Regex exclmtnMarkRegex = new Regex(@"\s*\!\s*");
            Regex dashRegex = new Regex(@"\s*\u2013\s*");
            Regex bracketsRegex = new Regex(@"\s*\(\s*(.*?)\s*\)\s*");
            Regex quotesRegex = new Regex("\\s*\"\\s*(.*?)\\s*\"\\s*");

            text = pointRegex.Replace(text, ". ");
            text = comaRegex.Replace(text, ", ");
            text = qstnMarkRegex.Replace(text, "? ");
            text = exclmtnMarkRegex.Replace(text, "! ");
            text = dashRegex.Replace(text, " \u2013 ");
            text = bracketsRegex.Replace(text, " ($1) ");
            text = quotesRegex.Replace(text, " \"$1\" ");

            return text;
        }

        /// <summary>
        /// Исключает возможность использования пробела длиною больше 1
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        public static string CorrectSpaces(string text)
        {
            Regex spaceRegex = new Regex(@"\s+");

            text = spaceRegex.Replace(text, " ");
            
            return text;
        }

        /// <summary>
        /// Заменяет кавычки "" >>> «»
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        public static string CorrectQuotes(string text)
        {
            Regex quotesRegex = new Regex("\\s*\"\\s*(.*?)\\s*\"\\s*");

            text = quotesRegex.Replace(text, " «$1» "); 
            
            return text;
        }

        /// <summary>
        /// Правильно расставляет пробелов с дефисом
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        public static string CorrectDashSpaces(string text)
        {
            Regex dashRegex = new Regex(@"\s*\-\s*");

            text = dashRegex.Replace(text, "-");

            return text;
        }

        /// <summary>
        /// Использует корректное троеточие
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        public static string CorrectEllipsis(string text)
        {
            Regex ellipsisRegex = new Regex(@"\.\.\.\s*");

            text = ellipsisRegex.Replace(text, "…");


            return text;
        }
    }
}

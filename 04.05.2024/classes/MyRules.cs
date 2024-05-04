using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace _04._05._2024
{
    public class MyRules
    {
        /// <summary>
        /// хамена буквы ё на е
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        public static string ReplaceE(string text)
        {
            text = text.Replace("ё", "е");

            return text; 
        }


        /// <summary>
        /// Цензурит все непристояные слова и выражения
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        public static string Censor(string text)
        {
            string filePath = "words.txt"; 
            string[] badWords = File.ReadAllLines(filePath);

            foreach (string word in badWords)
            {
                string pattern = @"\b" + Regex.Escape(word) + @"\b";
                text = Regex.Replace(text, pattern, "https://youtu.be/dQw4w9WgXcQ?si=uB7OTe3SZ2BuatF9", RegexOptions.IgnoreCase);
            }
            return text;
        }
    }
}

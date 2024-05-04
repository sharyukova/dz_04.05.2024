using _04._05._2024;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace tests_04._05._2024
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ReplaceE_Text_ReturnsReplacedText()
        {
            string inputText = "Привёт, мир!";
            string expectedOutput = "Привет, мир!";

            string result = MyRules.ReplaceE(inputText);

            Assert.AreEqual(expectedOutput, result);
        }

        [TestMethod]
        public void Censor_BadWord_ReturnsLink()
        {
            string inputText = "дурак";
            string expectedOutput = "https://youtu.be/dQw4w9WgXcQ?si=uB7OTe3SZ2BuatF9";

            string result = MyRules.Censor(inputText);

            Assert.AreEqual(expectedOutput, result);
        }

        [TestMethod]
        public void CorrectPunctuationSpaces_Text_ReturnsCorrected()
        {
            string inputText = "Привет ,мир ! ( c# )";
            string expectedOutput = "Привет, мир! (c#) ";

            string result = MainRules.CorrectPunctuationSpaces(inputText);

            Assert.AreEqual(expectedOutput, result);
        }

        [TestMethod]
        public void CorrectSpaces_DoubleSpace_OneSpace()
        {
            string inputText = "Привет,  мир!";
            string expectedOutput = "Привет, мир!";

            string result = MainRules.CorrectSpaces(inputText);

            Assert.AreEqual(expectedOutput, result);
        }

        [TestMethod]
        public void CorrectQuotes_SameQuotes_DiffQuotes()
        {
            string inputText = "Привет, \"мир\"";
            string expectedOutput = "Привет, «мир» ";

            string result = MainRules.CorrectQuotes(inputText);

            Assert.AreEqual(expectedOutput, result);
        }

        [TestMethod]
        public void CorrectDashSpaces_IncorrDash_CorrDash()
        {
            string inputText = "Hello - world";
            string expectedOutput = "Hello-world";

            string result = MainRules.CorrectDashSpaces(inputText);

            Assert.AreEqual(expectedOutput, result);
        }

        [TestMethod]
        public void CorrectEllipsis_3Dots_Ellipsis()
        {
            string inputText = "Hello world...";
            string expectedOutput = "Hello world…";

            string result = MainRules.CorrectEllipsis(inputText);

            Assert.AreEqual(expectedOutput, result);
        }

        [TestMethod]
        public void UseMainRules_NoChanges()
        {
            TypographerForm form = new TypographerForm();
            string inputText = "Привет , Мир !";
            string expectedOutput = "Привет , Мир !";

            string result = form.UseMainRules(inputText, false, false, false, false, false, false, false);

            Assert.AreEqual(expectedOutput, result);
        }

        [TestMethod]
        public void UseMainRules_AllChanges()
        {
            TypographerForm form = new TypographerForm();
            string inputText = "\"Привет , Мир\" почему аборт мат ?  изменённое выражение - текст";
            string expectedOutput = " «Привет, Мир» почему https://youtu.be/dQw4w9WgXcQ?si=uB7OTe3SZ2BuatF9 мат? измененное выражение-текст";

            string result = form.UseMainRules(inputText, true, true, true, true, true, true, true);

            Assert.AreEqual(expectedOutput, result);
        }


        [TestMethod]
        public void UseMainRules_ReplaceEAndCensor()
        {
            TypographerForm form = new TypographerForm();
            string inputText = "дурак ёмаё";
            string expectedOutput = "https://youtu.be/dQw4w9WgXcQ?si=uB7OTe3SZ2BuatF9 емае";

            string result = form.UseMainRules(inputText, false, false, false, false, false, true, true);

            Assert.AreEqual(expectedOutput, result);
        }
    }
}

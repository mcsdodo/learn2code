using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace RomanConverter
{
    [TestClass]
    public class ConvertToRomanExampleTest
    {
        [TestMethod]
        public void ShouldConvertFromArabic()
        {
            Assert.AreEqual("I", ConvertToRoman(1));
            Assert.AreEqual("II", ConvertToRoman(2));
            Assert.AreEqual("III", ConvertToRoman(3));

            Assert.AreEqual("V", ConvertToRoman(5));
            Assert.AreEqual("VI", ConvertToRoman(6));
            Assert.AreEqual("VIII", ConvertToRoman(8));

            Assert.AreEqual("X", ConvertToRoman(10));
            Assert.AreEqual("XX", ConvertToRoman(20));
            Assert.AreEqual("XXX", ConvertToRoman(30));

            Assert.AreEqual("XXV", ConvertToRoman(25));

            Assert.AreEqual("IV", ConvertToRoman(4));
            Assert.AreEqual("IX", ConvertToRoman(9));

            Assert.AreEqual("XXXIV", ConvertToRoman(34));
            Assert.AreEqual("XXXIX", ConvertToRoman(39));
        }

        private Dictionary<int, string> dict = new Dictionary<int, string>()
        {
            {10, "X"},
            {9, "IX"},
            {5, "V"},
            {4, "IV"},
            {1, "I"}
        };


        private string ConvertToRoman(int number)
        {
            string retVal = string.Empty;

            foreach (KeyValuePair<int, string> pair in dict)
            {
                if (number >= pair.Key)
                {
                    retVal += pair.Value.JoinTimes(number/pair.Key);
                    number = number%pair.Key;
                }
            }
            return retVal;
        }
    }
}

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


            Assert.AreEqual("L", ConvertToRoman(50));
            Assert.AreEqual("C", ConvertToRoman(100));
            Assert.AreEqual("D", ConvertToRoman(500));
            Assert.AreEqual("M", ConvertToRoman(1000));

            Assert.AreEqual("XLII", ConvertToRoman(42));
            Assert.AreEqual("MMXIV", ConvertToRoman(2014));
            Assert.AreEqual("MCMXCIX", ConvertToRoman(1999));
            Assert.AreEqual("DCLXVI", ConvertToRoman(666));
            Assert.AreEqual("CDXLIV", ConvertToRoman(444));
        }

        private Dictionary<int, string> dict = new Dictionary<int, string>()
        {
			{1000, "M"},
			{900, "CM"},
			{500, "D"},
			{400, "CD"},
			{100, "C"},
			{90, "XC"},
			{50, "L"},
			{40, "XL"},
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
                    number = number % pair.Key;
                }
            }
            return retVal;
        }
    }
}

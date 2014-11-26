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
		}

		private string ConvertToRoman(int number)
		{
		    if (number == 10)
		    {
		        return "X";
		    }
		    string retVal = string.Empty;

		    if (number > 10)
		    {
		        return "X".JoinTimes(number / 10);
		    }

		    if (number > 5)
		    {
		        retVal = "V";
		        number = number - 5;
		    }

		    if (number == 5)
		    {
		        return "V";
		    }
		    return retVal + "I".JoinTimes(number);
		}
	}
}

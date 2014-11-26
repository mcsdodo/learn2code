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
		}

		private string ConvertToRoman(int number)
		{
		    if (number == 2)
		    {
		        return "II";
		    }
		    if (number == 3)
		    {
		        return "III";
		    }
		    return "I";
		}
	}
}

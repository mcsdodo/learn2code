using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace RomanConverter
{
	[TestClass]
	public class ConvertToArabicExampleTest
	{
		[TestMethod]
		public void ShouldConvertFromRoman()
		{
			Assert.AreEqual(1, ConvertToArabic("I"));
			Assert.AreEqual(2, ConvertToArabic("II"));
			Assert.AreEqual(3, ConvertToArabic("III"));
			Assert.AreEqual(5, ConvertToArabic("V"));
			Assert.AreEqual(10, ConvertToArabic("X"));
			Assert.AreEqual(20, ConvertToArabic("XX"));
			Assert.AreEqual(50, ConvertToArabic("L"));
			Assert.AreEqual(100, ConvertToArabic("C"));
			Assert.AreEqual(500, ConvertToArabic("D"));
			Assert.AreEqual(1000, ConvertToArabic("M"));

			Assert.AreEqual(6, ConvertToArabic("VI"));
			Assert.AreEqual(11, ConvertToArabic("XI"));

			Assert.AreEqual(4, ConvertToArabic("IV"));
			Assert.AreEqual(9, ConvertToArabic("IX"));
			Assert.AreEqual(40, ConvertToArabic("XL"));

			Assert.AreEqual(1984, ConvertToArabic("MCMLXXXIV"));
		}

		private Dictionary<char, int> dict = new Dictionary<char, int>()
			{
				{'M', 1000},
				{'D', 500},
				{'C', 100},
				{'L', 50},
				{'X', 10},
				{'V', 5},
				{'I', 1}
			};


		private int ConvertToArabic(string romanNumber)
		{
			char[] romanNumberInversedArray = romanNumber.ToCharArray().Reverse().ToArray();

			var position = 0;
			var sum = 0;
			while (position < romanNumberInversedArray.Length)
			{
				sum += dict[romanNumberInversedArray[position]];

				if (position < romanNumberInversedArray.Length - 1 && dict[romanNumberInversedArray[position + 1]] < dict[romanNumberInversedArray[position]])
				{
					sum -= dict[romanNumberInversedArray[position + 1]];
					position++;
				}
				position++;
			}
			return sum;
		}


	}
}

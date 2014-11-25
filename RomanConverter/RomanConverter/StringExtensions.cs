namespace RomanConverter
{
	public static class StringExtensions
	{
		public static string JoinTimes(this string val, int times)
		{
			var retVal = string.Empty;
			for (int i = 0; i < times; i++)
			{
				retVal += val;
			}
			return retVal;
		}
	}
}
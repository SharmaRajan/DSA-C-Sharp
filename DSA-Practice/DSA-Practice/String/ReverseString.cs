using System;

namespace DSA_Practice.String
{
	public class ReverseString
	{
		public void reverse(string str)
		{
			for(int i = str.Length - 1; i >= 0; i--)
			{
				Console.Write(str[i]);
			}
		}
	}
}


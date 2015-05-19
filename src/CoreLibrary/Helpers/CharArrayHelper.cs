using System;

namespace SoftCircuitLibrary.Core
{
	public static class CharArrayHelpers
	{
		public static bool[] ToBoolArray (this char[] chars)
		{
			bool[] bitArray= new bool[chars.Length * 8];
			
			for(int i=0; i < chars.Length; i++)
			{
				bool[] charItem= ((byte) chars[i]).ToBoolArray();
				Array.Copy(charItem, 0, bitArray, 8 * i, 8);
			}
			
			return bitArray;
		}				
	}
}


using System;

namespace SoftCircuitLibrary.Core
{
	public static class HexStringHelpers
	{
		public static bool[] HexToBoolArray (this string bitString)
		{
			bool[] bitArray= new bool[bitString.Length * 4];
			
			char[] bitChars= bitString.ToCharArray();
			for(int i=0; i < bitChars.Length; i++)
			{
				bool[] hex= bitChars[i].HexToBoolArray();
				Array.Copy(hex, 0, bitArray, 4 * i, 4);
			}
			
			return bitArray;
		}				
	}
}


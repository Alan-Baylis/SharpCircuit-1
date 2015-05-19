using System;

namespace SoftCircuitLibrary.Core
{
	public static class BitStringHelpers
	{		
		public static bool[] BitsToBoolArray (this string bitString)
		{
			bool[] bitArray= new bool[bitString.Length];
			
			char[] bitChars= bitString.ToCharArray();
			for(int i=0; i < bitChars.Length; i++)
			{
				bitArray[i]= bitChars[i]=='1'? true: false;
			}
			
			return bitArray;
		}			
	}
	
	
}


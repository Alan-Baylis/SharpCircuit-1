using System;

namespace SoftCircuitLibrary.Core
{
	public static class BoolArrayHelpers
	{
		public static bool Matches (this bool[] boolArray, bool[] matchBoolArray)
		{
			bool matched= MatchesLength(boolArray, matchBoolArray);
			
			if (matched)
			{
				for(int i=0; i<boolArray.Length; i++)
				{
					matched= boolArray[i]==matchBoolArray[i];
					if (!matched)
					{
						break;
					}
				}
			}
			
			return matched;
		}
			
		public static bool MatchesLength (this bool[] boolArray, bool[] matchBoolArray)
		{
			return boolArray.Length==matchBoolArray.Length;					
		}
		
		public static byte ToByte(this bool[] boolArray)
		{
			int returnByte= 0;
			
			foreach(bool boolValue in boolArray)
			{
				returnByte= (returnByte<<1) + (boolValue?1:0);
			}
			
			return (byte) returnByte;
		}
		
		public static short ToShort(this bool[] boolArray)
		{
			int returnShort= 0;
			
			foreach(bool boolValue in boolArray)
			{
				returnShort= (returnShort<<1) + (boolValue?1:0);
			}
			
			return (short) returnShort;
		}
		
		public static long ToLong(this bool[] boolArray)
		{
			long returnLong= 0;
			
			foreach(bool boolValue in boolArray)
			{
				returnLong= (returnLong<<1) + (boolValue?1:0);
			}
			
			return returnLong;
		}
	}
}


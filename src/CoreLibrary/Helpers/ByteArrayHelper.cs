using System;

namespace SoftCircuitLibrary.Core
{
	public static class ByteArrayHelpers
	{
		public static bool[] ToBoolArray (this byte[] byteData)
		{
			bool[] bitArray= new bool[byteData.Length * 8];
			
			for(int i=0; i < byteData.Length; i++)
			{
				bool[] byteItem= ((byte) byteData[i]).ToBoolArray();
				Array.Copy(byteItem, 0, bitArray, 8 * i, 8);
			}
			
			return bitArray;
		}				
	}
}


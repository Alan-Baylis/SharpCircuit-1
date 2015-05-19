using System;

namespace SoftCircuitLibrary.Core
{
	public static class LongHelper
	{
		public static bool[] ToBoolArray(this long longVal)
		{
			bool[] longResult= new bool[64];
			byte[] longBytes= BitConverter.GetBytes(longVal);
			for(int i=0; i<longBytes.Length; i++)
			{
				Array.Copy(longBytes[i].ToBoolArray(), 0, longResult, i * 8, 8);
			}
			
			return longResult;
		}
	}
}


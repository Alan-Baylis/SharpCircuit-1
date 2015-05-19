using System;

namespace SoftCircuitLibrary.Core
{
	public static class IntHelper
	{
		public static bool[] ToBoolArray(this int intVal)
		{
			bool[] intResult= new bool[32];
			byte[] intBytes= BitConverter.GetBytes(intVal);
			for(int i=0; i<intBytes.Length; i++)
			{
				Array.Copy(intBytes[i].ToBoolArray(), 0, intResult, i * 8, 8);
			}
			
			return intResult;
		}
	}
}

